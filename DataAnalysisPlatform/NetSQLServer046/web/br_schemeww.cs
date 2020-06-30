/*
               File: BR_SchemeWW
        Description:  化疗方案
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 12:5:21.23
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
   public class br_schemeww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_schemeww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_schemeww( IGxContext context )
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
               AV13OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV14OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV17TFBR_SchemeID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV18TFBR_SchemeID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV21TFBR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV22TFBR_EncounterID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV25TFBR_Scheme_Chem_Regimens = GetNextPar( );
               AV26TFBR_Scheme_Chem_Regimens_Sel = GetNextPar( );
               AV29TFBR_Scheme_Therapy_Line = GetNextPar( );
               AV30TFBR_Scheme_Therapy_Line_Sel = GetNextPar( );
               AV33TFBR_Scheme_Chem_Cycle = NumberUtil.Val( GetNextPar( ), ".");
               AV34TFBR_Scheme_Chem_Cycle_To = NumberUtil.Val( GetNextPar( ), ".");
               AV37TFBR_Scheme_Chem_Detail = GetNextPar( );
               AV38TFBR_Scheme_Chem_Detail_Sel = GetNextPar( );
               AV19ddo_BR_SchemeIDTitleControlIdToReplace = GetNextPar( );
               AV23ddo_BR_EncounterIDTitleControlIdToReplace = GetNextPar( );
               AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = GetNextPar( );
               AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace = GetNextPar( );
               AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace = GetNextPar( );
               AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace = GetNextPar( );
               AV68Pgmname = GetNextPar( );
               AV47IsAuthorized_Update = StringUtil.StrToBool( GetNextPar( ));
               AV49IsAuthorized_Delete = StringUtil.StrToBool( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_SchemeID, AV18TFBR_SchemeID_To, AV21TFBR_EncounterID, AV22TFBR_EncounterID_To, AV25TFBR_Scheme_Chem_Regimens, AV26TFBR_Scheme_Chem_Regimens_Sel, AV29TFBR_Scheme_Therapy_Line, AV30TFBR_Scheme_Therapy_Line_Sel, AV33TFBR_Scheme_Chem_Cycle, AV34TFBR_Scheme_Chem_Cycle_To, AV37TFBR_Scheme_Chem_Detail, AV38TFBR_Scheme_Chem_Detail_Sel, AV19ddo_BR_SchemeIDTitleControlIdToReplace, AV23ddo_BR_EncounterIDTitleControlIdToReplace, AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace, AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace, AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace, AV68Pgmname, AV47IsAuthorized_Update, AV49IsAuthorized_Delete) ;
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
         PA6E2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START6E2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202271252153", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_schemeww.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV14OrderedDsc));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_SCHEMEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFBR_SchemeID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_SCHEMEID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFBR_SchemeID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21TFBR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_ENCOUNTERID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22TFBR_EncounterID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_SCHEME_CHEM_REGIMENS", AV25TFBR_Scheme_Chem_Regimens);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_SCHEME_CHEM_REGIMENS_SEL", AV26TFBR_Scheme_Chem_Regimens_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_SCHEME_THERAPY_LINE", AV29TFBR_Scheme_Therapy_Line);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_SCHEME_THERAPY_LINE_SEL", AV30TFBR_Scheme_Therapy_Line_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_SCHEME_CHEM_CYCLE", StringUtil.LTrim( StringUtil.NToC( AV33TFBR_Scheme_Chem_Cycle, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_SCHEME_CHEM_CYCLE_TO", StringUtil.LTrim( StringUtil.NToC( AV34TFBR_Scheme_Chem_Cycle_To, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_SCHEME_CHEM_DETAIL", AV37TFBR_Scheme_Chem_Detail);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_SCHEME_CHEM_DETAIL_SEL", AV38TFBR_Scheme_Chem_Detail_Sel);
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_31", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_31), 4, 0, ".", "")));
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_SCHEMEIDTITLEFILTERDATA", AV16BR_SchemeIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_SCHEMEIDTITLEFILTERDATA", AV16BR_SchemeIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTERIDTITLEFILTERDATA", AV20BR_EncounterIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTERIDTITLEFILTERDATA", AV20BR_EncounterIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA", AV24BR_Scheme_Chem_RegimensTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA", AV24BR_Scheme_Chem_RegimensTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_SCHEME_THERAPY_LINETITLEFILTERDATA", AV28BR_Scheme_Therapy_LineTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_SCHEME_THERAPY_LINETITLEFILTERDATA", AV28BR_Scheme_Therapy_LineTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_SCHEME_CHEM_CYCLETITLEFILTERDATA", AV32BR_Scheme_Chem_CycleTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_SCHEME_CHEM_CYCLETITLEFILTERDATA", AV32BR_Scheme_Chem_CycleTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_SCHEME_CHEM_DETAILTITLEFILTERDATA", AV36BR_Scheme_Chem_DetailTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_SCHEME_CHEM_DETAILTITLEFILTERDATA", AV36BR_Scheme_Chem_DetailTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV68Pgmname));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_UPDATE", AV47IsAuthorized_Update);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_DELETE", AV49IsAuthorized_Delete);
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Caption", StringUtil.RTrim( Ddo_br_schemeid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Tooltip", StringUtil.RTrim( Ddo_br_schemeid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Cls", StringUtil.RTrim( Ddo_br_schemeid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Filteredtext_set", StringUtil.RTrim( Ddo_br_schemeid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Filteredtextto_set", StringUtil.RTrim( Ddo_br_schemeid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_schemeid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_schemeid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Includesortasc", StringUtil.BoolToStr( Ddo_br_schemeid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_schemeid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Sortedstatus", StringUtil.RTrim( Ddo_br_schemeid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Includefilter", StringUtil.BoolToStr( Ddo_br_schemeid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Filtertype", StringUtil.RTrim( Ddo_br_schemeid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Filterisrange", StringUtil.BoolToStr( Ddo_br_schemeid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Includedatalist", StringUtil.BoolToStr( Ddo_br_schemeid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Sortasc", StringUtil.RTrim( Ddo_br_schemeid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Sortdsc", StringUtil.RTrim( Ddo_br_schemeid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Cleanfilter", StringUtil.RTrim( Ddo_br_schemeid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Rangefilterfrom", StringUtil.RTrim( Ddo_br_schemeid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Rangefilterto", StringUtil.RTrim( Ddo_br_schemeid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Searchbuttontext", StringUtil.RTrim( Ddo_br_schemeid_Searchbuttontext));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Caption", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Tooltip", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Cls", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Filteredtext_set", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Selectedvalue_set", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Includesortasc", StringUtil.BoolToStr( Ddo_br_scheme_chem_regimens_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Includesortdsc", StringUtil.BoolToStr( Ddo_br_scheme_chem_regimens_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Sortedstatus", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Includefilter", StringUtil.BoolToStr( Ddo_br_scheme_chem_regimens_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Filtertype", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Filterisrange", StringUtil.BoolToStr( Ddo_br_scheme_chem_regimens_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Includedatalist", StringUtil.BoolToStr( Ddo_br_scheme_chem_regimens_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Datalisttype", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Datalistproc", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_scheme_chem_regimens_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Sortasc", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Sortdsc", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Loadingdata", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Cleanfilter", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Noresultsfound", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Searchbuttontext", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Caption", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Tooltip", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Cls", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Filteredtext_set", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Selectedvalue_set", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Includesortasc", StringUtil.BoolToStr( Ddo_br_scheme_therapy_line_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_scheme_therapy_line_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Sortedstatus", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Includefilter", StringUtil.BoolToStr( Ddo_br_scheme_therapy_line_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Filtertype", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Filterisrange", StringUtil.BoolToStr( Ddo_br_scheme_therapy_line_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Includedatalist", StringUtil.BoolToStr( Ddo_br_scheme_therapy_line_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Datalisttype", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Datalistproc", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_scheme_therapy_line_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Sortasc", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Sortdsc", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Loadingdata", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Cleanfilter", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Noresultsfound", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Searchbuttontext", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Caption", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Tooltip", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Cls", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Filteredtext_set", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Filteredtextto_set", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Includesortasc", StringUtil.BoolToStr( Ddo_br_scheme_chem_cycle_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_scheme_chem_cycle_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Sortedstatus", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Includefilter", StringUtil.BoolToStr( Ddo_br_scheme_chem_cycle_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Filtertype", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Filterisrange", StringUtil.BoolToStr( Ddo_br_scheme_chem_cycle_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Includedatalist", StringUtil.BoolToStr( Ddo_br_scheme_chem_cycle_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Sortasc", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Sortdsc", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Cleanfilter", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Rangefilterfrom", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Rangefilterto", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Searchbuttontext", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Caption", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Tooltip", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Cls", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Filteredtext_set", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Selectedvalue_set", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Includesortasc", StringUtil.BoolToStr( Ddo_br_scheme_chem_detail_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Includesortdsc", StringUtil.BoolToStr( Ddo_br_scheme_chem_detail_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Sortedstatus", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Includefilter", StringUtil.BoolToStr( Ddo_br_scheme_chem_detail_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Filtertype", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Filterisrange", StringUtil.BoolToStr( Ddo_br_scheme_chem_detail_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Includedatalist", StringUtil.BoolToStr( Ddo_br_scheme_chem_detail_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Datalisttype", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Datalistproc", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_scheme_chem_detail_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Sortasc", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Sortdsc", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Loadingdata", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Cleanfilter", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Noresultsfound", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Searchbuttontext", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Activeeventkey", StringUtil.RTrim( Ddo_br_schemeid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Filteredtext_get", StringUtil.RTrim( Ddo_br_schemeid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_schemeid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtext_get", StringUtil.RTrim( Ddo_br_encounterid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_encounterid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Activeeventkey", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Filteredtext_get", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Selectedvalue_get", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Activeeventkey", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Filteredtext_get", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Selectedvalue_get", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Activeeventkey", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Filteredtext_get", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Activeeventkey", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Filteredtext_get", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Selectedvalue_get", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Activeeventkey", StringUtil.RTrim( Ddo_br_schemeid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Filteredtext_get", StringUtil.RTrim( Ddo_br_schemeid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_schemeid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtext_get", StringUtil.RTrim( Ddo_br_encounterid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_encounterid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Activeeventkey", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Filteredtext_get", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Selectedvalue_get", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Activeeventkey", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Filteredtext_get", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_THERAPY_LINE_Selectedvalue_get", StringUtil.RTrim( Ddo_br_scheme_therapy_line_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Activeeventkey", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Filteredtext_get", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_CYCLE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_scheme_chem_cycle_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Activeeventkey", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Filteredtext_get", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_DETAIL_Selectedvalue_get", StringUtil.RTrim( Ddo_br_scheme_chem_detail_Selectedvalue_get));
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
            WE6E2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT6E2( ) ;
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
         return formatLink("br_schemeww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "BR_SchemeWW" ;
      }

      public override String GetPgmdesc( )
      {
         return " 化疗方案" ;
      }

      protected void WB6E0( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroupColoredActions", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            ClassString = "Button ButtonColor";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(31), 2, 0)+","+"null"+");", "插入", bttBtninsert_Jsonclick, 5, "插入", "", StyleString, ClassString, bttBtninsert_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_SchemeWW.htm");
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DeleteAttribute ActionBaseColorAttribute"+"\" "+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_SchemeID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_SchemeID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_SchemeID_Title) ;
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Scheme_Chem_Regimens_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Scheme_Chem_Regimens_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Scheme_Chem_Regimens_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Scheme_Therapy_Line_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Scheme_Therapy_Line_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Scheme_Therapy_Line_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Scheme_Chem_Cycle_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Scheme_Chem_Cycle_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Scheme_Chem_Cycle_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Scheme_Chem_Detail_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Scheme_Chem_Detail_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Scheme_Chem_Detail_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV45Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV46Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV48Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A327BR_SchemeID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_SchemeID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_SchemeID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_EncounterID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_EncounterID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A328BR_Scheme_Chem_Regimens);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Scheme_Chem_Regimens_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Scheme_Chem_Regimens_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtBR_Scheme_Chem_Regimens_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A329BR_Scheme_Therapy_Line);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Scheme_Therapy_Line_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Scheme_Therapy_Line_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A330BR_Scheme_Chem_Cycle, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Scheme_Chem_Cycle_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Scheme_Chem_Cycle_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A331BR_Scheme_Chem_Detail);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Scheme_Chem_Detail_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Scheme_Chem_Detail_Titleformat), 4, 0, ".", "")));
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
            ucDdo_br_schemeid.SetProperty("Caption", Ddo_br_schemeid_Caption);
            ucDdo_br_schemeid.SetProperty("Tooltip", Ddo_br_schemeid_Tooltip);
            ucDdo_br_schemeid.SetProperty("Cls", Ddo_br_schemeid_Cls);
            ucDdo_br_schemeid.SetProperty("DropDownOptionsType", Ddo_br_schemeid_Dropdownoptionstype);
            ucDdo_br_schemeid.SetProperty("IncludeSortASC", Ddo_br_schemeid_Includesortasc);
            ucDdo_br_schemeid.SetProperty("IncludeSortDSC", Ddo_br_schemeid_Includesortdsc);
            ucDdo_br_schemeid.SetProperty("IncludeFilter", Ddo_br_schemeid_Includefilter);
            ucDdo_br_schemeid.SetProperty("FilterType", Ddo_br_schemeid_Filtertype);
            ucDdo_br_schemeid.SetProperty("FilterIsRange", Ddo_br_schemeid_Filterisrange);
            ucDdo_br_schemeid.SetProperty("IncludeDataList", Ddo_br_schemeid_Includedatalist);
            ucDdo_br_schemeid.SetProperty("SortASC", Ddo_br_schemeid_Sortasc);
            ucDdo_br_schemeid.SetProperty("SortDSC", Ddo_br_schemeid_Sortdsc);
            ucDdo_br_schemeid.SetProperty("CleanFilter", Ddo_br_schemeid_Cleanfilter);
            ucDdo_br_schemeid.SetProperty("RangeFilterFrom", Ddo_br_schemeid_Rangefilterfrom);
            ucDdo_br_schemeid.SetProperty("RangeFilterTo", Ddo_br_schemeid_Rangefilterto);
            ucDdo_br_schemeid.SetProperty("SearchButtonText", Ddo_br_schemeid_Searchbuttontext);
            ucDdo_br_schemeid.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_br_schemeid.SetProperty("DropDownOptionsData", AV16BR_SchemeIDTitleFilterData);
            ucDdo_br_schemeid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_schemeid_Internalname, "DDO_BR_SCHEMEIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_schemeidtitlecontrolidtoreplace_Internalname, AV19ddo_BR_SchemeIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", 0, edtavDdo_br_schemeidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_SchemeWW.htm");
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
            ucDdo_br_encounterid.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsData", AV20BR_EncounterIDTitleFilterData);
            ucDdo_br_encounterid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounterid_Internalname, "DDO_BR_ENCOUNTERIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, AV23ddo_BR_EncounterIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", 0, edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_SchemeWW.htm");
            /* User Defined Control */
            ucDdo_br_scheme_chem_regimens.SetProperty("Caption", Ddo_br_scheme_chem_regimens_Caption);
            ucDdo_br_scheme_chem_regimens.SetProperty("Tooltip", Ddo_br_scheme_chem_regimens_Tooltip);
            ucDdo_br_scheme_chem_regimens.SetProperty("Cls", Ddo_br_scheme_chem_regimens_Cls);
            ucDdo_br_scheme_chem_regimens.SetProperty("DropDownOptionsType", Ddo_br_scheme_chem_regimens_Dropdownoptionstype);
            ucDdo_br_scheme_chem_regimens.SetProperty("IncludeSortASC", Ddo_br_scheme_chem_regimens_Includesortasc);
            ucDdo_br_scheme_chem_regimens.SetProperty("IncludeSortDSC", Ddo_br_scheme_chem_regimens_Includesortdsc);
            ucDdo_br_scheme_chem_regimens.SetProperty("IncludeFilter", Ddo_br_scheme_chem_regimens_Includefilter);
            ucDdo_br_scheme_chem_regimens.SetProperty("FilterType", Ddo_br_scheme_chem_regimens_Filtertype);
            ucDdo_br_scheme_chem_regimens.SetProperty("FilterIsRange", Ddo_br_scheme_chem_regimens_Filterisrange);
            ucDdo_br_scheme_chem_regimens.SetProperty("IncludeDataList", Ddo_br_scheme_chem_regimens_Includedatalist);
            ucDdo_br_scheme_chem_regimens.SetProperty("DataListType", Ddo_br_scheme_chem_regimens_Datalisttype);
            ucDdo_br_scheme_chem_regimens.SetProperty("DataListProc", Ddo_br_scheme_chem_regimens_Datalistproc);
            ucDdo_br_scheme_chem_regimens.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_scheme_chem_regimens_Datalistupdateminimumcharacters);
            ucDdo_br_scheme_chem_regimens.SetProperty("SortASC", Ddo_br_scheme_chem_regimens_Sortasc);
            ucDdo_br_scheme_chem_regimens.SetProperty("SortDSC", Ddo_br_scheme_chem_regimens_Sortdsc);
            ucDdo_br_scheme_chem_regimens.SetProperty("LoadingData", Ddo_br_scheme_chem_regimens_Loadingdata);
            ucDdo_br_scheme_chem_regimens.SetProperty("CleanFilter", Ddo_br_scheme_chem_regimens_Cleanfilter);
            ucDdo_br_scheme_chem_regimens.SetProperty("NoResultsFound", Ddo_br_scheme_chem_regimens_Noresultsfound);
            ucDdo_br_scheme_chem_regimens.SetProperty("SearchButtonText", Ddo_br_scheme_chem_regimens_Searchbuttontext);
            ucDdo_br_scheme_chem_regimens.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_br_scheme_chem_regimens.SetProperty("DropDownOptionsData", AV24BR_Scheme_Chem_RegimensTitleFilterData);
            ucDdo_br_scheme_chem_regimens.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_scheme_chem_regimens_Internalname, "DDO_BR_SCHEME_CHEM_REGIMENSContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Internalname, AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", 0, edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_SchemeWW.htm");
            /* User Defined Control */
            ucDdo_br_scheme_therapy_line.SetProperty("Caption", Ddo_br_scheme_therapy_line_Caption);
            ucDdo_br_scheme_therapy_line.SetProperty("Tooltip", Ddo_br_scheme_therapy_line_Tooltip);
            ucDdo_br_scheme_therapy_line.SetProperty("Cls", Ddo_br_scheme_therapy_line_Cls);
            ucDdo_br_scheme_therapy_line.SetProperty("DropDownOptionsType", Ddo_br_scheme_therapy_line_Dropdownoptionstype);
            ucDdo_br_scheme_therapy_line.SetProperty("IncludeSortASC", Ddo_br_scheme_therapy_line_Includesortasc);
            ucDdo_br_scheme_therapy_line.SetProperty("IncludeSortDSC", Ddo_br_scheme_therapy_line_Includesortdsc);
            ucDdo_br_scheme_therapy_line.SetProperty("IncludeFilter", Ddo_br_scheme_therapy_line_Includefilter);
            ucDdo_br_scheme_therapy_line.SetProperty("FilterType", Ddo_br_scheme_therapy_line_Filtertype);
            ucDdo_br_scheme_therapy_line.SetProperty("FilterIsRange", Ddo_br_scheme_therapy_line_Filterisrange);
            ucDdo_br_scheme_therapy_line.SetProperty("IncludeDataList", Ddo_br_scheme_therapy_line_Includedatalist);
            ucDdo_br_scheme_therapy_line.SetProperty("DataListType", Ddo_br_scheme_therapy_line_Datalisttype);
            ucDdo_br_scheme_therapy_line.SetProperty("DataListProc", Ddo_br_scheme_therapy_line_Datalistproc);
            ucDdo_br_scheme_therapy_line.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_scheme_therapy_line_Datalistupdateminimumcharacters);
            ucDdo_br_scheme_therapy_line.SetProperty("SortASC", Ddo_br_scheme_therapy_line_Sortasc);
            ucDdo_br_scheme_therapy_line.SetProperty("SortDSC", Ddo_br_scheme_therapy_line_Sortdsc);
            ucDdo_br_scheme_therapy_line.SetProperty("LoadingData", Ddo_br_scheme_therapy_line_Loadingdata);
            ucDdo_br_scheme_therapy_line.SetProperty("CleanFilter", Ddo_br_scheme_therapy_line_Cleanfilter);
            ucDdo_br_scheme_therapy_line.SetProperty("NoResultsFound", Ddo_br_scheme_therapy_line_Noresultsfound);
            ucDdo_br_scheme_therapy_line.SetProperty("SearchButtonText", Ddo_br_scheme_therapy_line_Searchbuttontext);
            ucDdo_br_scheme_therapy_line.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_br_scheme_therapy_line.SetProperty("DropDownOptionsData", AV28BR_Scheme_Therapy_LineTitleFilterData);
            ucDdo_br_scheme_therapy_line.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_scheme_therapy_line_Internalname, "DDO_BR_SCHEME_THERAPY_LINEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_scheme_therapy_linetitlecontrolidtoreplace_Internalname, AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", 0, edtavDdo_br_scheme_therapy_linetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_SchemeWW.htm");
            /* User Defined Control */
            ucDdo_br_scheme_chem_cycle.SetProperty("Caption", Ddo_br_scheme_chem_cycle_Caption);
            ucDdo_br_scheme_chem_cycle.SetProperty("Tooltip", Ddo_br_scheme_chem_cycle_Tooltip);
            ucDdo_br_scheme_chem_cycle.SetProperty("Cls", Ddo_br_scheme_chem_cycle_Cls);
            ucDdo_br_scheme_chem_cycle.SetProperty("DropDownOptionsType", Ddo_br_scheme_chem_cycle_Dropdownoptionstype);
            ucDdo_br_scheme_chem_cycle.SetProperty("IncludeSortASC", Ddo_br_scheme_chem_cycle_Includesortasc);
            ucDdo_br_scheme_chem_cycle.SetProperty("IncludeSortDSC", Ddo_br_scheme_chem_cycle_Includesortdsc);
            ucDdo_br_scheme_chem_cycle.SetProperty("IncludeFilter", Ddo_br_scheme_chem_cycle_Includefilter);
            ucDdo_br_scheme_chem_cycle.SetProperty("FilterType", Ddo_br_scheme_chem_cycle_Filtertype);
            ucDdo_br_scheme_chem_cycle.SetProperty("FilterIsRange", Ddo_br_scheme_chem_cycle_Filterisrange);
            ucDdo_br_scheme_chem_cycle.SetProperty("IncludeDataList", Ddo_br_scheme_chem_cycle_Includedatalist);
            ucDdo_br_scheme_chem_cycle.SetProperty("SortASC", Ddo_br_scheme_chem_cycle_Sortasc);
            ucDdo_br_scheme_chem_cycle.SetProperty("SortDSC", Ddo_br_scheme_chem_cycle_Sortdsc);
            ucDdo_br_scheme_chem_cycle.SetProperty("CleanFilter", Ddo_br_scheme_chem_cycle_Cleanfilter);
            ucDdo_br_scheme_chem_cycle.SetProperty("RangeFilterFrom", Ddo_br_scheme_chem_cycle_Rangefilterfrom);
            ucDdo_br_scheme_chem_cycle.SetProperty("RangeFilterTo", Ddo_br_scheme_chem_cycle_Rangefilterto);
            ucDdo_br_scheme_chem_cycle.SetProperty("SearchButtonText", Ddo_br_scheme_chem_cycle_Searchbuttontext);
            ucDdo_br_scheme_chem_cycle.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_br_scheme_chem_cycle.SetProperty("DropDownOptionsData", AV32BR_Scheme_Chem_CycleTitleFilterData);
            ucDdo_br_scheme_chem_cycle.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_scheme_chem_cycle_Internalname, "DDO_BR_SCHEME_CHEM_CYCLEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_scheme_chem_cycletitlecontrolidtoreplace_Internalname, AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", 0, edtavDdo_br_scheme_chem_cycletitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_SchemeWW.htm");
            /* User Defined Control */
            ucDdo_br_scheme_chem_detail.SetProperty("Caption", Ddo_br_scheme_chem_detail_Caption);
            ucDdo_br_scheme_chem_detail.SetProperty("Tooltip", Ddo_br_scheme_chem_detail_Tooltip);
            ucDdo_br_scheme_chem_detail.SetProperty("Cls", Ddo_br_scheme_chem_detail_Cls);
            ucDdo_br_scheme_chem_detail.SetProperty("DropDownOptionsType", Ddo_br_scheme_chem_detail_Dropdownoptionstype);
            ucDdo_br_scheme_chem_detail.SetProperty("IncludeSortASC", Ddo_br_scheme_chem_detail_Includesortasc);
            ucDdo_br_scheme_chem_detail.SetProperty("IncludeSortDSC", Ddo_br_scheme_chem_detail_Includesortdsc);
            ucDdo_br_scheme_chem_detail.SetProperty("IncludeFilter", Ddo_br_scheme_chem_detail_Includefilter);
            ucDdo_br_scheme_chem_detail.SetProperty("FilterType", Ddo_br_scheme_chem_detail_Filtertype);
            ucDdo_br_scheme_chem_detail.SetProperty("FilterIsRange", Ddo_br_scheme_chem_detail_Filterisrange);
            ucDdo_br_scheme_chem_detail.SetProperty("IncludeDataList", Ddo_br_scheme_chem_detail_Includedatalist);
            ucDdo_br_scheme_chem_detail.SetProperty("DataListType", Ddo_br_scheme_chem_detail_Datalisttype);
            ucDdo_br_scheme_chem_detail.SetProperty("DataListProc", Ddo_br_scheme_chem_detail_Datalistproc);
            ucDdo_br_scheme_chem_detail.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_scheme_chem_detail_Datalistupdateminimumcharacters);
            ucDdo_br_scheme_chem_detail.SetProperty("SortASC", Ddo_br_scheme_chem_detail_Sortasc);
            ucDdo_br_scheme_chem_detail.SetProperty("SortDSC", Ddo_br_scheme_chem_detail_Sortdsc);
            ucDdo_br_scheme_chem_detail.SetProperty("LoadingData", Ddo_br_scheme_chem_detail_Loadingdata);
            ucDdo_br_scheme_chem_detail.SetProperty("CleanFilter", Ddo_br_scheme_chem_detail_Cleanfilter);
            ucDdo_br_scheme_chem_detail.SetProperty("NoResultsFound", Ddo_br_scheme_chem_detail_Noresultsfound);
            ucDdo_br_scheme_chem_detail.SetProperty("SearchButtonText", Ddo_br_scheme_chem_detail_Searchbuttontext);
            ucDdo_br_scheme_chem_detail.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_br_scheme_chem_detail.SetProperty("DropDownOptionsData", AV36BR_Scheme_Chem_DetailTitleFilterData);
            ucDdo_br_scheme_chem_detail.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_scheme_chem_detail_Internalname, "DDO_BR_SCHEME_CHEM_DETAILContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_scheme_chem_detailtitlecontrolidtoreplace_Internalname, AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", 0, edtavDdo_br_scheme_chem_detailtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_SchemeWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,61);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_SchemeWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,62);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_SchemeWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_schemeid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFBR_SchemeID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV17TFBR_SchemeID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_schemeid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_schemeid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_SchemeWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_schemeid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFBR_SchemeID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV18TFBR_SchemeID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_schemeid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_schemeid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_SchemeWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_encounterid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21TFBR_EncounterID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV21TFBR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,65);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_encounterid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_encounterid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_SchemeWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_encounterid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22TFBR_EncounterID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV22TFBR_EncounterID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_encounterid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_encounterid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_SchemeWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_scheme_chem_regimens_Internalname, AV25TFBR_Scheme_Chem_Regimens, StringUtil.RTrim( context.localUtil.Format( AV25TFBR_Scheme_Chem_Regimens, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,67);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_scheme_chem_regimens_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_scheme_chem_regimens_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_SchemeWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_scheme_chem_regimens_sel_Internalname, AV26TFBR_Scheme_Chem_Regimens_Sel, StringUtil.RTrim( context.localUtil.Format( AV26TFBR_Scheme_Chem_Regimens_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,68);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_scheme_chem_regimens_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_scheme_chem_regimens_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_SchemeWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_scheme_therapy_line_Internalname, AV29TFBR_Scheme_Therapy_Line, StringUtil.RTrim( context.localUtil.Format( AV29TFBR_Scheme_Therapy_Line, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,69);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_scheme_therapy_line_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_scheme_therapy_line_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_SchemeWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_scheme_therapy_line_sel_Internalname, AV30TFBR_Scheme_Therapy_Line_Sel, StringUtil.RTrim( context.localUtil.Format( AV30TFBR_Scheme_Therapy_Line_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,70);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_scheme_therapy_line_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_scheme_therapy_line_sel_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_SchemeWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_scheme_chem_cycle_Internalname, StringUtil.LTrim( StringUtil.NToC( AV33TFBR_Scheme_Chem_Cycle, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV33TFBR_Scheme_Chem_Cycle, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,71);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_scheme_chem_cycle_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_scheme_chem_cycle_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_SchemeWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_scheme_chem_cycle_to_Internalname, StringUtil.LTrim( StringUtil.NToC( AV34TFBR_Scheme_Chem_Cycle_To, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV34TFBR_Scheme_Chem_Cycle_To, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,72);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_scheme_chem_cycle_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_scheme_chem_cycle_to_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_SchemeWW.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfbr_scheme_chem_detail_Internalname, AV37TFBR_Scheme_Chem_Detail, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,73);\"", 0, edtavTfbr_scheme_chem_detail_Visible, 1, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_SchemeWW.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfbr_scheme_chem_detail_sel_Internalname, AV38TFBR_Scheme_Chem_Detail_Sel, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,74);\"", 0, edtavTfbr_scheme_chem_detail_sel_Visible, 1, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_SchemeWW.htm");
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

      protected void START6E2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", " 化疗方案", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP6E0( ) ;
      }

      protected void WS6E2( )
      {
         START6E2( ) ;
         EVT6E2( ) ;
      }

      protected void EVT6E2( )
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
                              E116E2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E126E2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_SCHEMEID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E136E2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTERID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E146E2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_SCHEME_CHEM_REGIMENS.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E156E2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_SCHEME_THERAPY_LINE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E166E2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_SCHEME_CHEM_CYCLE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E176E2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_SCHEME_CHEM_DETAIL.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E186E2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E196E2 ();
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
                              AV45Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV45Display)) ? AV65Display_GXI : context.convertURL( context.PathToRelativeUrl( AV45Display))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV45Display), true);
                              AV46Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV46Update)) ? AV66Update_GXI : context.convertURL( context.PathToRelativeUrl( AV46Update))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV46Update), true);
                              AV48Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV48Delete)) ? AV67Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV48Delete))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV48Delete), true);
                              A327BR_SchemeID = (long)(context.localUtil.CToN( cgiGet( edtBR_SchemeID_Internalname), ".", ","));
                              A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
                              A328BR_Scheme_Chem_Regimens = cgiGet( edtBR_Scheme_Chem_Regimens_Internalname);
                              n328BR_Scheme_Chem_Regimens = false;
                              A329BR_Scheme_Therapy_Line = cgiGet( edtBR_Scheme_Therapy_Line_Internalname);
                              n329BR_Scheme_Therapy_Line = false;
                              A330BR_Scheme_Chem_Cycle = context.localUtil.CToN( cgiGet( edtBR_Scheme_Chem_Cycle_Internalname), ".", ",");
                              n330BR_Scheme_Chem_Cycle = false;
                              A331BR_Scheme_Chem_Detail = cgiGet( edtBR_Scheme_Chem_Detail_Internalname);
                              n331BR_Scheme_Chem_Detail = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E206E2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E216E2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E226E2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
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
                                       /* Set Refresh If Tfbr_schemeid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_SCHEMEID"), ".", ",") != Convert.ToDecimal( AV17TFBR_SchemeID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_schemeid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_SCHEMEID_TO"), ".", ",") != Convert.ToDecimal( AV18TFBR_SchemeID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_encounterid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_ENCOUNTERID"), ".", ",") != Convert.ToDecimal( AV21TFBR_EncounterID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_encounterid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_ENCOUNTERID_TO"), ".", ",") != Convert.ToDecimal( AV22TFBR_EncounterID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_scheme_chem_regimens Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_SCHEME_CHEM_REGIMENS"), AV25TFBR_Scheme_Chem_Regimens) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_scheme_chem_regimens_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_SCHEME_CHEM_REGIMENS_SEL"), AV26TFBR_Scheme_Chem_Regimens_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_scheme_therapy_line Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_SCHEME_THERAPY_LINE"), AV29TFBR_Scheme_Therapy_Line) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_scheme_therapy_line_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_SCHEME_THERAPY_LINE_SEL"), AV30TFBR_Scheme_Therapy_Line_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_scheme_chem_cycle Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_SCHEME_CHEM_CYCLE"), ".", ",") != AV33TFBR_Scheme_Chem_Cycle )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_scheme_chem_cycle_to Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_SCHEME_CHEM_CYCLE_TO"), ".", ",") != AV34TFBR_Scheme_Chem_Cycle_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_scheme_chem_detail Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_SCHEME_CHEM_DETAIL"), AV37TFBR_Scheme_Chem_Detail) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_scheme_chem_detail_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_SCHEME_CHEM_DETAIL_SEL"), AV38TFBR_Scheme_Chem_Detail_Sel) != 0 )
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

      protected void WE6E2( )
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

      protected void PA6E2( )
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
               GX_FocusControl = edtavDdo_br_schemeidtitlecontrolidtoreplace_Internalname;
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
                                       short AV13OrderedBy ,
                                       bool AV14OrderedDsc ,
                                       long AV17TFBR_SchemeID ,
                                       long AV18TFBR_SchemeID_To ,
                                       long AV21TFBR_EncounterID ,
                                       long AV22TFBR_EncounterID_To ,
                                       String AV25TFBR_Scheme_Chem_Regimens ,
                                       String AV26TFBR_Scheme_Chem_Regimens_Sel ,
                                       String AV29TFBR_Scheme_Therapy_Line ,
                                       String AV30TFBR_Scheme_Therapy_Line_Sel ,
                                       decimal AV33TFBR_Scheme_Chem_Cycle ,
                                       decimal AV34TFBR_Scheme_Chem_Cycle_To ,
                                       String AV37TFBR_Scheme_Chem_Detail ,
                                       String AV38TFBR_Scheme_Chem_Detail_Sel ,
                                       String AV19ddo_BR_SchemeIDTitleControlIdToReplace ,
                                       String AV23ddo_BR_EncounterIDTitleControlIdToReplace ,
                                       String AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace ,
                                       String AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace ,
                                       String AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace ,
                                       String AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace ,
                                       String AV68Pgmname ,
                                       bool AV47IsAuthorized_Update ,
                                       bool AV49IsAuthorized_Delete )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF6E2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_SCHEMEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A327BR_SchemeID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_SCHEMEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A327BR_SchemeID), 18, 0, ".", "")));
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
         RF6E2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV68Pgmname = "BR_SchemeWW";
         context.Gx_err = 0;
      }

      protected void RF6E2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 31;
         /* Execute user event: Refresh */
         E216E2 ();
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
                                                 AV53BR_SchemeWWDS_1_Tfbr_schemeid ,
                                                 AV54BR_SchemeWWDS_2_Tfbr_schemeid_to ,
                                                 AV55BR_SchemeWWDS_3_Tfbr_encounterid ,
                                                 AV56BR_SchemeWWDS_4_Tfbr_encounterid_to ,
                                                 AV58BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel ,
                                                 AV57BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens ,
                                                 AV60BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel ,
                                                 AV59BR_SchemeWWDS_7_Tfbr_scheme_therapy_line ,
                                                 AV61BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle ,
                                                 AV62BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to ,
                                                 AV64BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel ,
                                                 AV63BR_SchemeWWDS_11_Tfbr_scheme_chem_detail ,
                                                 A327BR_SchemeID ,
                                                 A19BR_EncounterID ,
                                                 A328BR_Scheme_Chem_Regimens ,
                                                 A329BR_Scheme_Therapy_Line ,
                                                 A330BR_Scheme_Chem_Cycle ,
                                                 A331BR_Scheme_Chem_Detail ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL,
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN,
                                                 TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV57BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens = StringUtil.Concat( StringUtil.RTrim( AV57BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens), "%", "");
            lV59BR_SchemeWWDS_7_Tfbr_scheme_therapy_line = StringUtil.Concat( StringUtil.RTrim( AV59BR_SchemeWWDS_7_Tfbr_scheme_therapy_line), "%", "");
            lV63BR_SchemeWWDS_11_Tfbr_scheme_chem_detail = StringUtil.Concat( StringUtil.RTrim( AV63BR_SchemeWWDS_11_Tfbr_scheme_chem_detail), "%", "");
            /* Using cursor H006E2 */
            pr_default.execute(0, new Object[] {AV53BR_SchemeWWDS_1_Tfbr_schemeid, AV54BR_SchemeWWDS_2_Tfbr_schemeid_to, AV55BR_SchemeWWDS_3_Tfbr_encounterid, AV56BR_SchemeWWDS_4_Tfbr_encounterid_to, lV57BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens, AV58BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel, lV59BR_SchemeWWDS_7_Tfbr_scheme_therapy_line, AV60BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel, AV61BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle, AV62BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to, lV63BR_SchemeWWDS_11_Tfbr_scheme_chem_detail, AV64BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_31_idx = 1;
            sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
            SubsflControlProps_312( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A331BR_Scheme_Chem_Detail = H006E2_A331BR_Scheme_Chem_Detail[0];
               n331BR_Scheme_Chem_Detail = H006E2_n331BR_Scheme_Chem_Detail[0];
               A330BR_Scheme_Chem_Cycle = H006E2_A330BR_Scheme_Chem_Cycle[0];
               n330BR_Scheme_Chem_Cycle = H006E2_n330BR_Scheme_Chem_Cycle[0];
               A329BR_Scheme_Therapy_Line = H006E2_A329BR_Scheme_Therapy_Line[0];
               n329BR_Scheme_Therapy_Line = H006E2_n329BR_Scheme_Therapy_Line[0];
               A328BR_Scheme_Chem_Regimens = H006E2_A328BR_Scheme_Chem_Regimens[0];
               n328BR_Scheme_Chem_Regimens = H006E2_n328BR_Scheme_Chem_Regimens[0];
               A19BR_EncounterID = H006E2_A19BR_EncounterID[0];
               A327BR_SchemeID = H006E2_A327BR_SchemeID[0];
               E226E2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 31;
            WB6E0( ) ;
         }
         bGXsfl_31_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes6E2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_SCHEMEID"+"_"+sGXsfl_31_idx, GetSecureSignedToken( sGXsfl_31_idx, context.localUtil.Format( (decimal)(A327BR_SchemeID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         AV53BR_SchemeWWDS_1_Tfbr_schemeid = AV17TFBR_SchemeID;
         AV54BR_SchemeWWDS_2_Tfbr_schemeid_to = AV18TFBR_SchemeID_To;
         AV55BR_SchemeWWDS_3_Tfbr_encounterid = AV21TFBR_EncounterID;
         AV56BR_SchemeWWDS_4_Tfbr_encounterid_to = AV22TFBR_EncounterID_To;
         AV57BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens = AV25TFBR_Scheme_Chem_Regimens;
         AV58BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel = AV26TFBR_Scheme_Chem_Regimens_Sel;
         AV59BR_SchemeWWDS_7_Tfbr_scheme_therapy_line = AV29TFBR_Scheme_Therapy_Line;
         AV60BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel = AV30TFBR_Scheme_Therapy_Line_Sel;
         AV61BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle = AV33TFBR_Scheme_Chem_Cycle;
         AV62BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to = AV34TFBR_Scheme_Chem_Cycle_To;
         AV63BR_SchemeWWDS_11_Tfbr_scheme_chem_detail = AV37TFBR_Scheme_Chem_Detail;
         AV64BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel = AV38TFBR_Scheme_Chem_Detail_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV53BR_SchemeWWDS_1_Tfbr_schemeid ,
                                              AV54BR_SchemeWWDS_2_Tfbr_schemeid_to ,
                                              AV55BR_SchemeWWDS_3_Tfbr_encounterid ,
                                              AV56BR_SchemeWWDS_4_Tfbr_encounterid_to ,
                                              AV58BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel ,
                                              AV57BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens ,
                                              AV60BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel ,
                                              AV59BR_SchemeWWDS_7_Tfbr_scheme_therapy_line ,
                                              AV61BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle ,
                                              AV62BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to ,
                                              AV64BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel ,
                                              AV63BR_SchemeWWDS_11_Tfbr_scheme_chem_detail ,
                                              A327BR_SchemeID ,
                                              A19BR_EncounterID ,
                                              A328BR_Scheme_Chem_Regimens ,
                                              A329BR_Scheme_Therapy_Line ,
                                              A330BR_Scheme_Chem_Cycle ,
                                              A331BR_Scheme_Chem_Detail ,
                                              AV13OrderedBy ,
                                              AV14OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV57BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens = StringUtil.Concat( StringUtil.RTrim( AV57BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens), "%", "");
         lV59BR_SchemeWWDS_7_Tfbr_scheme_therapy_line = StringUtil.Concat( StringUtil.RTrim( AV59BR_SchemeWWDS_7_Tfbr_scheme_therapy_line), "%", "");
         lV63BR_SchemeWWDS_11_Tfbr_scheme_chem_detail = StringUtil.Concat( StringUtil.RTrim( AV63BR_SchemeWWDS_11_Tfbr_scheme_chem_detail), "%", "");
         /* Using cursor H006E3 */
         pr_default.execute(1, new Object[] {AV53BR_SchemeWWDS_1_Tfbr_schemeid, AV54BR_SchemeWWDS_2_Tfbr_schemeid_to, AV55BR_SchemeWWDS_3_Tfbr_encounterid, AV56BR_SchemeWWDS_4_Tfbr_encounterid_to, lV57BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens, AV58BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel, lV59BR_SchemeWWDS_7_Tfbr_scheme_therapy_line, AV60BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel, AV61BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle, AV62BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to, lV63BR_SchemeWWDS_11_Tfbr_scheme_chem_detail, AV64BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel});
         GRID_nRecordCount = H006E3_AGRID_nRecordCount[0];
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
         AV53BR_SchemeWWDS_1_Tfbr_schemeid = AV17TFBR_SchemeID;
         AV54BR_SchemeWWDS_2_Tfbr_schemeid_to = AV18TFBR_SchemeID_To;
         AV55BR_SchemeWWDS_3_Tfbr_encounterid = AV21TFBR_EncounterID;
         AV56BR_SchemeWWDS_4_Tfbr_encounterid_to = AV22TFBR_EncounterID_To;
         AV57BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens = AV25TFBR_Scheme_Chem_Regimens;
         AV58BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel = AV26TFBR_Scheme_Chem_Regimens_Sel;
         AV59BR_SchemeWWDS_7_Tfbr_scheme_therapy_line = AV29TFBR_Scheme_Therapy_Line;
         AV60BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel = AV30TFBR_Scheme_Therapy_Line_Sel;
         AV61BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle = AV33TFBR_Scheme_Chem_Cycle;
         AV62BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to = AV34TFBR_Scheme_Chem_Cycle_To;
         AV63BR_SchemeWWDS_11_Tfbr_scheme_chem_detail = AV37TFBR_Scheme_Chem_Detail;
         AV64BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel = AV38TFBR_Scheme_Chem_Detail_Sel;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_SchemeID, AV18TFBR_SchemeID_To, AV21TFBR_EncounterID, AV22TFBR_EncounterID_To, AV25TFBR_Scheme_Chem_Regimens, AV26TFBR_Scheme_Chem_Regimens_Sel, AV29TFBR_Scheme_Therapy_Line, AV30TFBR_Scheme_Therapy_Line_Sel, AV33TFBR_Scheme_Chem_Cycle, AV34TFBR_Scheme_Chem_Cycle_To, AV37TFBR_Scheme_Chem_Detail, AV38TFBR_Scheme_Chem_Detail_Sel, AV19ddo_BR_SchemeIDTitleControlIdToReplace, AV23ddo_BR_EncounterIDTitleControlIdToReplace, AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace, AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace, AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace, AV68Pgmname, AV47IsAuthorized_Update, AV49IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV53BR_SchemeWWDS_1_Tfbr_schemeid = AV17TFBR_SchemeID;
         AV54BR_SchemeWWDS_2_Tfbr_schemeid_to = AV18TFBR_SchemeID_To;
         AV55BR_SchemeWWDS_3_Tfbr_encounterid = AV21TFBR_EncounterID;
         AV56BR_SchemeWWDS_4_Tfbr_encounterid_to = AV22TFBR_EncounterID_To;
         AV57BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens = AV25TFBR_Scheme_Chem_Regimens;
         AV58BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel = AV26TFBR_Scheme_Chem_Regimens_Sel;
         AV59BR_SchemeWWDS_7_Tfbr_scheme_therapy_line = AV29TFBR_Scheme_Therapy_Line;
         AV60BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel = AV30TFBR_Scheme_Therapy_Line_Sel;
         AV61BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle = AV33TFBR_Scheme_Chem_Cycle;
         AV62BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to = AV34TFBR_Scheme_Chem_Cycle_To;
         AV63BR_SchemeWWDS_11_Tfbr_scheme_chem_detail = AV37TFBR_Scheme_Chem_Detail;
         AV64BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel = AV38TFBR_Scheme_Chem_Detail_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_SchemeID, AV18TFBR_SchemeID_To, AV21TFBR_EncounterID, AV22TFBR_EncounterID_To, AV25TFBR_Scheme_Chem_Regimens, AV26TFBR_Scheme_Chem_Regimens_Sel, AV29TFBR_Scheme_Therapy_Line, AV30TFBR_Scheme_Therapy_Line_Sel, AV33TFBR_Scheme_Chem_Cycle, AV34TFBR_Scheme_Chem_Cycle_To, AV37TFBR_Scheme_Chem_Detail, AV38TFBR_Scheme_Chem_Detail_Sel, AV19ddo_BR_SchemeIDTitleControlIdToReplace, AV23ddo_BR_EncounterIDTitleControlIdToReplace, AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace, AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace, AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace, AV68Pgmname, AV47IsAuthorized_Update, AV49IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV53BR_SchemeWWDS_1_Tfbr_schemeid = AV17TFBR_SchemeID;
         AV54BR_SchemeWWDS_2_Tfbr_schemeid_to = AV18TFBR_SchemeID_To;
         AV55BR_SchemeWWDS_3_Tfbr_encounterid = AV21TFBR_EncounterID;
         AV56BR_SchemeWWDS_4_Tfbr_encounterid_to = AV22TFBR_EncounterID_To;
         AV57BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens = AV25TFBR_Scheme_Chem_Regimens;
         AV58BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel = AV26TFBR_Scheme_Chem_Regimens_Sel;
         AV59BR_SchemeWWDS_7_Tfbr_scheme_therapy_line = AV29TFBR_Scheme_Therapy_Line;
         AV60BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel = AV30TFBR_Scheme_Therapy_Line_Sel;
         AV61BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle = AV33TFBR_Scheme_Chem_Cycle;
         AV62BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to = AV34TFBR_Scheme_Chem_Cycle_To;
         AV63BR_SchemeWWDS_11_Tfbr_scheme_chem_detail = AV37TFBR_Scheme_Chem_Detail;
         AV64BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel = AV38TFBR_Scheme_Chem_Detail_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_SchemeID, AV18TFBR_SchemeID_To, AV21TFBR_EncounterID, AV22TFBR_EncounterID_To, AV25TFBR_Scheme_Chem_Regimens, AV26TFBR_Scheme_Chem_Regimens_Sel, AV29TFBR_Scheme_Therapy_Line, AV30TFBR_Scheme_Therapy_Line_Sel, AV33TFBR_Scheme_Chem_Cycle, AV34TFBR_Scheme_Chem_Cycle_To, AV37TFBR_Scheme_Chem_Detail, AV38TFBR_Scheme_Chem_Detail_Sel, AV19ddo_BR_SchemeIDTitleControlIdToReplace, AV23ddo_BR_EncounterIDTitleControlIdToReplace, AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace, AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace, AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace, AV68Pgmname, AV47IsAuthorized_Update, AV49IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV53BR_SchemeWWDS_1_Tfbr_schemeid = AV17TFBR_SchemeID;
         AV54BR_SchemeWWDS_2_Tfbr_schemeid_to = AV18TFBR_SchemeID_To;
         AV55BR_SchemeWWDS_3_Tfbr_encounterid = AV21TFBR_EncounterID;
         AV56BR_SchemeWWDS_4_Tfbr_encounterid_to = AV22TFBR_EncounterID_To;
         AV57BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens = AV25TFBR_Scheme_Chem_Regimens;
         AV58BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel = AV26TFBR_Scheme_Chem_Regimens_Sel;
         AV59BR_SchemeWWDS_7_Tfbr_scheme_therapy_line = AV29TFBR_Scheme_Therapy_Line;
         AV60BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel = AV30TFBR_Scheme_Therapy_Line_Sel;
         AV61BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle = AV33TFBR_Scheme_Chem_Cycle;
         AV62BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to = AV34TFBR_Scheme_Chem_Cycle_To;
         AV63BR_SchemeWWDS_11_Tfbr_scheme_chem_detail = AV37TFBR_Scheme_Chem_Detail;
         AV64BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel = AV38TFBR_Scheme_Chem_Detail_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_SchemeID, AV18TFBR_SchemeID_To, AV21TFBR_EncounterID, AV22TFBR_EncounterID_To, AV25TFBR_Scheme_Chem_Regimens, AV26TFBR_Scheme_Chem_Regimens_Sel, AV29TFBR_Scheme_Therapy_Line, AV30TFBR_Scheme_Therapy_Line_Sel, AV33TFBR_Scheme_Chem_Cycle, AV34TFBR_Scheme_Chem_Cycle_To, AV37TFBR_Scheme_Chem_Detail, AV38TFBR_Scheme_Chem_Detail_Sel, AV19ddo_BR_SchemeIDTitleControlIdToReplace, AV23ddo_BR_EncounterIDTitleControlIdToReplace, AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace, AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace, AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace, AV68Pgmname, AV47IsAuthorized_Update, AV49IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV53BR_SchemeWWDS_1_Tfbr_schemeid = AV17TFBR_SchemeID;
         AV54BR_SchemeWWDS_2_Tfbr_schemeid_to = AV18TFBR_SchemeID_To;
         AV55BR_SchemeWWDS_3_Tfbr_encounterid = AV21TFBR_EncounterID;
         AV56BR_SchemeWWDS_4_Tfbr_encounterid_to = AV22TFBR_EncounterID_To;
         AV57BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens = AV25TFBR_Scheme_Chem_Regimens;
         AV58BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel = AV26TFBR_Scheme_Chem_Regimens_Sel;
         AV59BR_SchemeWWDS_7_Tfbr_scheme_therapy_line = AV29TFBR_Scheme_Therapy_Line;
         AV60BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel = AV30TFBR_Scheme_Therapy_Line_Sel;
         AV61BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle = AV33TFBR_Scheme_Chem_Cycle;
         AV62BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to = AV34TFBR_Scheme_Chem_Cycle_To;
         AV63BR_SchemeWWDS_11_Tfbr_scheme_chem_detail = AV37TFBR_Scheme_Chem_Detail;
         AV64BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel = AV38TFBR_Scheme_Chem_Detail_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_SchemeID, AV18TFBR_SchemeID_To, AV21TFBR_EncounterID, AV22TFBR_EncounterID_To, AV25TFBR_Scheme_Chem_Regimens, AV26TFBR_Scheme_Chem_Regimens_Sel, AV29TFBR_Scheme_Therapy_Line, AV30TFBR_Scheme_Therapy_Line_Sel, AV33TFBR_Scheme_Chem_Cycle, AV34TFBR_Scheme_Chem_Cycle_To, AV37TFBR_Scheme_Chem_Detail, AV38TFBR_Scheme_Chem_Detail_Sel, AV19ddo_BR_SchemeIDTitleControlIdToReplace, AV23ddo_BR_EncounterIDTitleControlIdToReplace, AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace, AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace, AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace, AV68Pgmname, AV47IsAuthorized_Update, AV49IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP6E0( )
      {
         /* Before Start, stand alone formulas. */
         AV68Pgmname = "BR_SchemeWW";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E206E2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV40DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_SCHEMEIDTITLEFILTERDATA"), AV16BR_SchemeIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTERIDTITLEFILTERDATA"), AV20BR_EncounterIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA"), AV24BR_Scheme_Chem_RegimensTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_SCHEME_THERAPY_LINETITLEFILTERDATA"), AV28BR_Scheme_Therapy_LineTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_SCHEME_CHEM_CYCLETITLEFILTERDATA"), AV32BR_Scheme_Chem_CycleTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_SCHEME_CHEM_DETAILTITLEFILTERDATA"), AV36BR_Scheme_Chem_DetailTitleFilterData);
            /* Read variables values. */
            AV19ddo_BR_SchemeIDTitleControlIdToReplace = cgiGet( edtavDdo_br_schemeidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_SchemeIDTitleControlIdToReplace", AV19ddo_BR_SchemeIDTitleControlIdToReplace);
            AV23ddo_BR_EncounterIDTitleControlIdToReplace = cgiGet( edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_EncounterIDTitleControlIdToReplace", AV23ddo_BR_EncounterIDTitleControlIdToReplace);
            AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = cgiGet( edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace", AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace);
            AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace = cgiGet( edtavDdo_br_scheme_therapy_linetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace", AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace);
            AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace = cgiGet( edtavDdo_br_scheme_chem_cycletitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace", AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace);
            AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace = cgiGet( edtavDdo_br_scheme_chem_detailtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace", AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace);
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
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_schemeid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_schemeid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_SCHEMEID");
               GX_FocusControl = edtavTfbr_schemeid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV17TFBR_SchemeID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_SchemeID), 18, 0)));
            }
            else
            {
               AV17TFBR_SchemeID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_schemeid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_SchemeID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_schemeid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_schemeid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_SCHEMEID_TO");
               GX_FocusControl = edtavTfbr_schemeid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV18TFBR_SchemeID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_SchemeID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_SchemeID_To), 18, 0)));
            }
            else
            {
               AV18TFBR_SchemeID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_schemeid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_SchemeID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_SchemeID_To), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_ENCOUNTERID");
               GX_FocusControl = edtavTfbr_encounterid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV21TFBR_EncounterID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_EncounterID), 18, 0)));
            }
            else
            {
               AV21TFBR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_EncounterID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_ENCOUNTERID_TO");
               GX_FocusControl = edtavTfbr_encounterid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV22TFBR_EncounterID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_EncounterID_To), 18, 0)));
            }
            else
            {
               AV22TFBR_EncounterID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_EncounterID_To), 18, 0)));
            }
            AV25TFBR_Scheme_Chem_Regimens = cgiGet( edtavTfbr_scheme_chem_regimens_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_Scheme_Chem_Regimens", AV25TFBR_Scheme_Chem_Regimens);
            AV26TFBR_Scheme_Chem_Regimens_Sel = cgiGet( edtavTfbr_scheme_chem_regimens_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_Scheme_Chem_Regimens_Sel", AV26TFBR_Scheme_Chem_Regimens_Sel);
            AV29TFBR_Scheme_Therapy_Line = cgiGet( edtavTfbr_scheme_therapy_line_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_Scheme_Therapy_Line", AV29TFBR_Scheme_Therapy_Line);
            AV30TFBR_Scheme_Therapy_Line_Sel = cgiGet( edtavTfbr_scheme_therapy_line_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_Scheme_Therapy_Line_Sel", AV30TFBR_Scheme_Therapy_Line_Sel);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_scheme_chem_cycle_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_scheme_chem_cycle_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_SCHEME_CHEM_CYCLE");
               GX_FocusControl = edtavTfbr_scheme_chem_cycle_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV33TFBR_Scheme_Chem_Cycle = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TFBR_Scheme_Chem_Cycle", StringUtil.LTrim( StringUtil.Str( AV33TFBR_Scheme_Chem_Cycle, 15, 5)));
            }
            else
            {
               AV33TFBR_Scheme_Chem_Cycle = context.localUtil.CToN( cgiGet( edtavTfbr_scheme_chem_cycle_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TFBR_Scheme_Chem_Cycle", StringUtil.LTrim( StringUtil.Str( AV33TFBR_Scheme_Chem_Cycle, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_scheme_chem_cycle_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_scheme_chem_cycle_to_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_SCHEME_CHEM_CYCLE_TO");
               GX_FocusControl = edtavTfbr_scheme_chem_cycle_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV34TFBR_Scheme_Chem_Cycle_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFBR_Scheme_Chem_Cycle_To", StringUtil.LTrim( StringUtil.Str( AV34TFBR_Scheme_Chem_Cycle_To, 15, 5)));
            }
            else
            {
               AV34TFBR_Scheme_Chem_Cycle_To = context.localUtil.CToN( cgiGet( edtavTfbr_scheme_chem_cycle_to_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFBR_Scheme_Chem_Cycle_To", StringUtil.LTrim( StringUtil.Str( AV34TFBR_Scheme_Chem_Cycle_To, 15, 5)));
            }
            AV37TFBR_Scheme_Chem_Detail = cgiGet( edtavTfbr_scheme_chem_detail_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37TFBR_Scheme_Chem_Detail", AV37TFBR_Scheme_Chem_Detail);
            AV38TFBR_Scheme_Chem_Detail_Sel = cgiGet( edtavTfbr_scheme_chem_detail_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38TFBR_Scheme_Chem_Detail_Sel", AV38TFBR_Scheme_Chem_Detail_Sel);
            /* Read saved values. */
            nRC_GXsfl_31 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_31"), ".", ","));
            AV42GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV44GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV43GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_schemeid_Caption = cgiGet( "DDO_BR_SCHEMEID_Caption");
            Ddo_br_schemeid_Tooltip = cgiGet( "DDO_BR_SCHEMEID_Tooltip");
            Ddo_br_schemeid_Cls = cgiGet( "DDO_BR_SCHEMEID_Cls");
            Ddo_br_schemeid_Filteredtext_set = cgiGet( "DDO_BR_SCHEMEID_Filteredtext_set");
            Ddo_br_schemeid_Filteredtextto_set = cgiGet( "DDO_BR_SCHEMEID_Filteredtextto_set");
            Ddo_br_schemeid_Dropdownoptionstype = cgiGet( "DDO_BR_SCHEMEID_Dropdownoptionstype");
            Ddo_br_schemeid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_SCHEMEID_Titlecontrolidtoreplace");
            Ddo_br_schemeid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEMEID_Includesortasc"));
            Ddo_br_schemeid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEMEID_Includesortdsc"));
            Ddo_br_schemeid_Sortedstatus = cgiGet( "DDO_BR_SCHEMEID_Sortedstatus");
            Ddo_br_schemeid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEMEID_Includefilter"));
            Ddo_br_schemeid_Filtertype = cgiGet( "DDO_BR_SCHEMEID_Filtertype");
            Ddo_br_schemeid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEMEID_Filterisrange"));
            Ddo_br_schemeid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEMEID_Includedatalist"));
            Ddo_br_schemeid_Sortasc = cgiGet( "DDO_BR_SCHEMEID_Sortasc");
            Ddo_br_schemeid_Sortdsc = cgiGet( "DDO_BR_SCHEMEID_Sortdsc");
            Ddo_br_schemeid_Cleanfilter = cgiGet( "DDO_BR_SCHEMEID_Cleanfilter");
            Ddo_br_schemeid_Rangefilterfrom = cgiGet( "DDO_BR_SCHEMEID_Rangefilterfrom");
            Ddo_br_schemeid_Rangefilterto = cgiGet( "DDO_BR_SCHEMEID_Rangefilterto");
            Ddo_br_schemeid_Searchbuttontext = cgiGet( "DDO_BR_SCHEMEID_Searchbuttontext");
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
            Ddo_br_scheme_chem_regimens_Caption = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Caption");
            Ddo_br_scheme_chem_regimens_Tooltip = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Tooltip");
            Ddo_br_scheme_chem_regimens_Cls = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Cls");
            Ddo_br_scheme_chem_regimens_Filteredtext_set = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Filteredtext_set");
            Ddo_br_scheme_chem_regimens_Selectedvalue_set = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Selectedvalue_set");
            Ddo_br_scheme_chem_regimens_Dropdownoptionstype = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Dropdownoptionstype");
            Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Titlecontrolidtoreplace");
            Ddo_br_scheme_chem_regimens_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Includesortasc"));
            Ddo_br_scheme_chem_regimens_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Includesortdsc"));
            Ddo_br_scheme_chem_regimens_Sortedstatus = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Sortedstatus");
            Ddo_br_scheme_chem_regimens_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Includefilter"));
            Ddo_br_scheme_chem_regimens_Filtertype = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Filtertype");
            Ddo_br_scheme_chem_regimens_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Filterisrange"));
            Ddo_br_scheme_chem_regimens_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Includedatalist"));
            Ddo_br_scheme_chem_regimens_Datalisttype = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Datalisttype");
            Ddo_br_scheme_chem_regimens_Datalistproc = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Datalistproc");
            Ddo_br_scheme_chem_regimens_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_scheme_chem_regimens_Sortasc = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Sortasc");
            Ddo_br_scheme_chem_regimens_Sortdsc = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Sortdsc");
            Ddo_br_scheme_chem_regimens_Loadingdata = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Loadingdata");
            Ddo_br_scheme_chem_regimens_Cleanfilter = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Cleanfilter");
            Ddo_br_scheme_chem_regimens_Noresultsfound = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Noresultsfound");
            Ddo_br_scheme_chem_regimens_Searchbuttontext = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Searchbuttontext");
            Ddo_br_scheme_therapy_line_Caption = cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Caption");
            Ddo_br_scheme_therapy_line_Tooltip = cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Tooltip");
            Ddo_br_scheme_therapy_line_Cls = cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Cls");
            Ddo_br_scheme_therapy_line_Filteredtext_set = cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Filteredtext_set");
            Ddo_br_scheme_therapy_line_Selectedvalue_set = cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Selectedvalue_set");
            Ddo_br_scheme_therapy_line_Dropdownoptionstype = cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Dropdownoptionstype");
            Ddo_br_scheme_therapy_line_Titlecontrolidtoreplace = cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Titlecontrolidtoreplace");
            Ddo_br_scheme_therapy_line_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Includesortasc"));
            Ddo_br_scheme_therapy_line_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Includesortdsc"));
            Ddo_br_scheme_therapy_line_Sortedstatus = cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Sortedstatus");
            Ddo_br_scheme_therapy_line_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Includefilter"));
            Ddo_br_scheme_therapy_line_Filtertype = cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Filtertype");
            Ddo_br_scheme_therapy_line_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Filterisrange"));
            Ddo_br_scheme_therapy_line_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Includedatalist"));
            Ddo_br_scheme_therapy_line_Datalisttype = cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Datalisttype");
            Ddo_br_scheme_therapy_line_Datalistproc = cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Datalistproc");
            Ddo_br_scheme_therapy_line_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_scheme_therapy_line_Sortasc = cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Sortasc");
            Ddo_br_scheme_therapy_line_Sortdsc = cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Sortdsc");
            Ddo_br_scheme_therapy_line_Loadingdata = cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Loadingdata");
            Ddo_br_scheme_therapy_line_Cleanfilter = cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Cleanfilter");
            Ddo_br_scheme_therapy_line_Noresultsfound = cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Noresultsfound");
            Ddo_br_scheme_therapy_line_Searchbuttontext = cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Searchbuttontext");
            Ddo_br_scheme_chem_cycle_Caption = cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Caption");
            Ddo_br_scheme_chem_cycle_Tooltip = cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Tooltip");
            Ddo_br_scheme_chem_cycle_Cls = cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Cls");
            Ddo_br_scheme_chem_cycle_Filteredtext_set = cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Filteredtext_set");
            Ddo_br_scheme_chem_cycle_Filteredtextto_set = cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Filteredtextto_set");
            Ddo_br_scheme_chem_cycle_Dropdownoptionstype = cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Dropdownoptionstype");
            Ddo_br_scheme_chem_cycle_Titlecontrolidtoreplace = cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Titlecontrolidtoreplace");
            Ddo_br_scheme_chem_cycle_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Includesortasc"));
            Ddo_br_scheme_chem_cycle_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Includesortdsc"));
            Ddo_br_scheme_chem_cycle_Sortedstatus = cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Sortedstatus");
            Ddo_br_scheme_chem_cycle_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Includefilter"));
            Ddo_br_scheme_chem_cycle_Filtertype = cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Filtertype");
            Ddo_br_scheme_chem_cycle_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Filterisrange"));
            Ddo_br_scheme_chem_cycle_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Includedatalist"));
            Ddo_br_scheme_chem_cycle_Sortasc = cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Sortasc");
            Ddo_br_scheme_chem_cycle_Sortdsc = cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Sortdsc");
            Ddo_br_scheme_chem_cycle_Cleanfilter = cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Cleanfilter");
            Ddo_br_scheme_chem_cycle_Rangefilterfrom = cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Rangefilterfrom");
            Ddo_br_scheme_chem_cycle_Rangefilterto = cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Rangefilterto");
            Ddo_br_scheme_chem_cycle_Searchbuttontext = cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Searchbuttontext");
            Ddo_br_scheme_chem_detail_Caption = cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Caption");
            Ddo_br_scheme_chem_detail_Tooltip = cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Tooltip");
            Ddo_br_scheme_chem_detail_Cls = cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Cls");
            Ddo_br_scheme_chem_detail_Filteredtext_set = cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Filteredtext_set");
            Ddo_br_scheme_chem_detail_Selectedvalue_set = cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Selectedvalue_set");
            Ddo_br_scheme_chem_detail_Dropdownoptionstype = cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Dropdownoptionstype");
            Ddo_br_scheme_chem_detail_Titlecontrolidtoreplace = cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Titlecontrolidtoreplace");
            Ddo_br_scheme_chem_detail_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Includesortasc"));
            Ddo_br_scheme_chem_detail_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Includesortdsc"));
            Ddo_br_scheme_chem_detail_Sortedstatus = cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Sortedstatus");
            Ddo_br_scheme_chem_detail_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Includefilter"));
            Ddo_br_scheme_chem_detail_Filtertype = cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Filtertype");
            Ddo_br_scheme_chem_detail_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Filterisrange"));
            Ddo_br_scheme_chem_detail_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Includedatalist"));
            Ddo_br_scheme_chem_detail_Datalisttype = cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Datalisttype");
            Ddo_br_scheme_chem_detail_Datalistproc = cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Datalistproc");
            Ddo_br_scheme_chem_detail_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_scheme_chem_detail_Sortasc = cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Sortasc");
            Ddo_br_scheme_chem_detail_Sortdsc = cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Sortdsc");
            Ddo_br_scheme_chem_detail_Loadingdata = cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Loadingdata");
            Ddo_br_scheme_chem_detail_Cleanfilter = cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Cleanfilter");
            Ddo_br_scheme_chem_detail_Noresultsfound = cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Noresultsfound");
            Ddo_br_scheme_chem_detail_Searchbuttontext = cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_schemeid_Activeeventkey = cgiGet( "DDO_BR_SCHEMEID_Activeeventkey");
            Ddo_br_schemeid_Filteredtext_get = cgiGet( "DDO_BR_SCHEMEID_Filteredtext_get");
            Ddo_br_schemeid_Filteredtextto_get = cgiGet( "DDO_BR_SCHEMEID_Filteredtextto_get");
            Ddo_br_encounterid_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTERID_Activeeventkey");
            Ddo_br_encounterid_Filteredtext_get = cgiGet( "DDO_BR_ENCOUNTERID_Filteredtext_get");
            Ddo_br_encounterid_Filteredtextto_get = cgiGet( "DDO_BR_ENCOUNTERID_Filteredtextto_get");
            Ddo_br_scheme_chem_regimens_Activeeventkey = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Activeeventkey");
            Ddo_br_scheme_chem_regimens_Filteredtext_get = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Filteredtext_get");
            Ddo_br_scheme_chem_regimens_Selectedvalue_get = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Selectedvalue_get");
            Ddo_br_scheme_therapy_line_Activeeventkey = cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Activeeventkey");
            Ddo_br_scheme_therapy_line_Filteredtext_get = cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Filteredtext_get");
            Ddo_br_scheme_therapy_line_Selectedvalue_get = cgiGet( "DDO_BR_SCHEME_THERAPY_LINE_Selectedvalue_get");
            Ddo_br_scheme_chem_cycle_Activeeventkey = cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Activeeventkey");
            Ddo_br_scheme_chem_cycle_Filteredtext_get = cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Filteredtext_get");
            Ddo_br_scheme_chem_cycle_Filteredtextto_get = cgiGet( "DDO_BR_SCHEME_CHEM_CYCLE_Filteredtextto_get");
            Ddo_br_scheme_chem_detail_Activeeventkey = cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Activeeventkey");
            Ddo_br_scheme_chem_detail_Filteredtext_get = cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Filteredtext_get");
            Ddo_br_scheme_chem_detail_Selectedvalue_get = cgiGet( "DDO_BR_SCHEME_CHEM_DETAIL_Selectedvalue_get");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV13OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV14OrderedDsc )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_SCHEMEID"), ".", ",") != Convert.ToDecimal( AV17TFBR_SchemeID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_SCHEMEID_TO"), ".", ",") != Convert.ToDecimal( AV18TFBR_SchemeID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_ENCOUNTERID"), ".", ",") != Convert.ToDecimal( AV21TFBR_EncounterID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_ENCOUNTERID_TO"), ".", ",") != Convert.ToDecimal( AV22TFBR_EncounterID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_SCHEME_CHEM_REGIMENS"), AV25TFBR_Scheme_Chem_Regimens) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_SCHEME_CHEM_REGIMENS_SEL"), AV26TFBR_Scheme_Chem_Regimens_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_SCHEME_THERAPY_LINE"), AV29TFBR_Scheme_Therapy_Line) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_SCHEME_THERAPY_LINE_SEL"), AV30TFBR_Scheme_Therapy_Line_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_SCHEME_CHEM_CYCLE"), ".", ",") != AV33TFBR_Scheme_Chem_Cycle )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_SCHEME_CHEM_CYCLE_TO"), ".", ",") != AV34TFBR_Scheme_Chem_Cycle_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_SCHEME_CHEM_DETAIL"), AV37TFBR_Scheme_Chem_Detail) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_SCHEME_CHEM_DETAIL_SEL"), AV38TFBR_Scheme_Chem_Detail_Sel) != 0 )
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
         E206E2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E206E2( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         edtavTfbr_schemeid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_schemeid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_schemeid_Visible), 5, 0)), true);
         edtavTfbr_schemeid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_schemeid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_schemeid_to_Visible), 5, 0)), true);
         edtavTfbr_encounterid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_encounterid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_encounterid_Visible), 5, 0)), true);
         edtavTfbr_encounterid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_encounterid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_encounterid_to_Visible), 5, 0)), true);
         edtavTfbr_scheme_chem_regimens_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_scheme_chem_regimens_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_scheme_chem_regimens_Visible), 5, 0)), true);
         edtavTfbr_scheme_chem_regimens_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_scheme_chem_regimens_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_scheme_chem_regimens_sel_Visible), 5, 0)), true);
         edtavTfbr_scheme_therapy_line_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_scheme_therapy_line_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_scheme_therapy_line_Visible), 5, 0)), true);
         edtavTfbr_scheme_therapy_line_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_scheme_therapy_line_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_scheme_therapy_line_sel_Visible), 5, 0)), true);
         edtavTfbr_scheme_chem_cycle_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_scheme_chem_cycle_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_scheme_chem_cycle_Visible), 5, 0)), true);
         edtavTfbr_scheme_chem_cycle_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_scheme_chem_cycle_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_scheme_chem_cycle_to_Visible), 5, 0)), true);
         edtavTfbr_scheme_chem_detail_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_scheme_chem_detail_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_scheme_chem_detail_Visible), 5, 0)), true);
         edtavTfbr_scheme_chem_detail_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_scheme_chem_detail_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_scheme_chem_detail_sel_Visible), 5, 0)), true);
         Ddo_br_schemeid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_SchemeID";
         ucDdo_br_schemeid.SendProperty(context, "", false, Ddo_br_schemeid_Internalname, "TitleControlIdToReplace", Ddo_br_schemeid_Titlecontrolidtoreplace);
         AV19ddo_BR_SchemeIDTitleControlIdToReplace = Ddo_br_schemeid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_SchemeIDTitleControlIdToReplace", AV19ddo_BR_SchemeIDTitleControlIdToReplace);
         edtavDdo_br_schemeidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_schemeidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_schemeidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounterid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_EncounterID";
         ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "TitleControlIdToReplace", Ddo_br_encounterid_Titlecontrolidtoreplace);
         AV23ddo_BR_EncounterIDTitleControlIdToReplace = Ddo_br_encounterid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_EncounterIDTitleControlIdToReplace", AV23ddo_BR_EncounterIDTitleControlIdToReplace);
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Scheme_Chem_Regimens";
         ucDdo_br_scheme_chem_regimens.SendProperty(context, "", false, Ddo_br_scheme_chem_regimens_Internalname, "TitleControlIdToReplace", Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace);
         AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace", AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace);
         edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_scheme_therapy_line_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Scheme_Therapy_Line";
         ucDdo_br_scheme_therapy_line.SendProperty(context, "", false, Ddo_br_scheme_therapy_line_Internalname, "TitleControlIdToReplace", Ddo_br_scheme_therapy_line_Titlecontrolidtoreplace);
         AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace = Ddo_br_scheme_therapy_line_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace", AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace);
         edtavDdo_br_scheme_therapy_linetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_scheme_therapy_linetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_scheme_therapy_linetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_scheme_chem_cycle_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Scheme_Chem_Cycle";
         ucDdo_br_scheme_chem_cycle.SendProperty(context, "", false, Ddo_br_scheme_chem_cycle_Internalname, "TitleControlIdToReplace", Ddo_br_scheme_chem_cycle_Titlecontrolidtoreplace);
         AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace = Ddo_br_scheme_chem_cycle_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace", AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace);
         edtavDdo_br_scheme_chem_cycletitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_scheme_chem_cycletitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_scheme_chem_cycletitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_scheme_chem_detail_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Scheme_Chem_Detail";
         ucDdo_br_scheme_chem_detail.SendProperty(context, "", false, Ddo_br_scheme_chem_detail_Internalname, "TitleControlIdToReplace", Ddo_br_scheme_chem_detail_Titlecontrolidtoreplace);
         AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace = Ddo_br_scheme_chem_detail_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace", AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace);
         edtavDdo_br_scheme_chem_detailtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_scheme_chem_detailtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_scheme_chem_detailtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " 化疗方案";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV40DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV40DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E216E2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV16BR_SchemeIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_Scheme_Chem_RegimensTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28BR_Scheme_Therapy_LineTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32BR_Scheme_Chem_CycleTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV36BR_Scheme_Chem_DetailTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
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
         edtBR_SchemeID_Titleformat = 2;
         edtBR_SchemeID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "化疗方案主键", AV19ddo_BR_SchemeIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_SchemeID_Internalname, "Title", edtBR_SchemeID_Title, !bGXsfl_31_Refreshing);
         edtBR_EncounterID_Titleformat = 2;
         edtBR_EncounterID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊信息主键", AV23ddo_BR_EncounterIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Title", edtBR_EncounterID_Title, !bGXsfl_31_Refreshing);
         edtBR_Scheme_Chem_Regimens_Titleformat = 2;
         edtBR_Scheme_Chem_Regimens_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "化疗方案", AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Scheme_Chem_Regimens_Internalname, "Title", edtBR_Scheme_Chem_Regimens_Title, !bGXsfl_31_Refreshing);
         edtBR_Scheme_Therapy_Line_Titleformat = 2;
         edtBR_Scheme_Therapy_Line_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "方案线级", AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Scheme_Therapy_Line_Internalname, "Title", edtBR_Scheme_Therapy_Line_Title, !bGXsfl_31_Refreshing);
         edtBR_Scheme_Chem_Cycle_Titleformat = 2;
         edtBR_Scheme_Chem_Cycle_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "化疗周期", AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Scheme_Chem_Cycle_Internalname, "Title", edtBR_Scheme_Chem_Cycle_Title, !bGXsfl_31_Refreshing);
         edtBR_Scheme_Chem_Detail_Titleformat = 2;
         edtBR_Scheme_Chem_Detail_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "化疗方案描述", AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Scheme_Chem_Detail_Internalname, "Title", edtBR_Scheme_Chem_Detail_Title, !bGXsfl_31_Refreshing);
         AV42GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42GridCurrentPage), 10, 0)));
         AV43GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV43GridPageSize), 10, 0)));
         AV44GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV44GridRecordCount), 10, 0)));
         AV53BR_SchemeWWDS_1_Tfbr_schemeid = AV17TFBR_SchemeID;
         AV54BR_SchemeWWDS_2_Tfbr_schemeid_to = AV18TFBR_SchemeID_To;
         AV55BR_SchemeWWDS_3_Tfbr_encounterid = AV21TFBR_EncounterID;
         AV56BR_SchemeWWDS_4_Tfbr_encounterid_to = AV22TFBR_EncounterID_To;
         AV57BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens = AV25TFBR_Scheme_Chem_Regimens;
         AV58BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel = AV26TFBR_Scheme_Chem_Regimens_Sel;
         AV59BR_SchemeWWDS_7_Tfbr_scheme_therapy_line = AV29TFBR_Scheme_Therapy_Line;
         AV60BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel = AV30TFBR_Scheme_Therapy_Line_Sel;
         AV61BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle = AV33TFBR_Scheme_Chem_Cycle;
         AV62BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to = AV34TFBR_Scheme_Chem_Cycle_To;
         AV63BR_SchemeWWDS_11_Tfbr_scheme_chem_detail = AV37TFBR_Scheme_Chem_Detail;
         AV64BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel = AV38TFBR_Scheme_Chem_Detail_Sel;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_SchemeIDTitleFilterData", AV16BR_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Scheme_Chem_RegimensTitleFilterData", AV24BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Scheme_Therapy_LineTitleFilterData", AV28BR_Scheme_Therapy_LineTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Scheme_Chem_CycleTitleFilterData", AV32BR_Scheme_Chem_CycleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Scheme_Chem_DetailTitleFilterData", AV36BR_Scheme_Chem_DetailTitleFilterData);
      }

      protected void E116E2( )
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

      protected void E126E2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E136E2( )
      {
         /* Ddo_br_schemeid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_schemeid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_schemeid_Sortedstatus = "ASC";
            ucDdo_br_schemeid.SendProperty(context, "", false, Ddo_br_schemeid_Internalname, "SortedStatus", Ddo_br_schemeid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_schemeid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_schemeid_Sortedstatus = "DSC";
            ucDdo_br_schemeid.SendProperty(context, "", false, Ddo_br_schemeid_Internalname, "SortedStatus", Ddo_br_schemeid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_schemeid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV17TFBR_SchemeID = (long)(NumberUtil.Val( Ddo_br_schemeid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_SchemeID), 18, 0)));
            AV18TFBR_SchemeID_To = (long)(NumberUtil.Val( Ddo_br_schemeid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_SchemeID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_SchemeID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_SchemeIDTitleFilterData", AV16BR_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Scheme_Chem_RegimensTitleFilterData", AV24BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Scheme_Therapy_LineTitleFilterData", AV28BR_Scheme_Therapy_LineTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Scheme_Chem_CycleTitleFilterData", AV32BR_Scheme_Chem_CycleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Scheme_Chem_DetailTitleFilterData", AV36BR_Scheme_Chem_DetailTitleFilterData);
      }

      protected void E146E2( )
      {
         /* Ddo_br_encounterid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounterid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 2;
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
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 2;
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
            AV21TFBR_EncounterID = (long)(NumberUtil.Val( Ddo_br_encounterid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_EncounterID), 18, 0)));
            AV22TFBR_EncounterID_To = (long)(NumberUtil.Val( Ddo_br_encounterid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_EncounterID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_SchemeIDTitleFilterData", AV16BR_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Scheme_Chem_RegimensTitleFilterData", AV24BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Scheme_Therapy_LineTitleFilterData", AV28BR_Scheme_Therapy_LineTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Scheme_Chem_CycleTitleFilterData", AV32BR_Scheme_Chem_CycleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Scheme_Chem_DetailTitleFilterData", AV36BR_Scheme_Chem_DetailTitleFilterData);
      }

      protected void E156E2( )
      {
         /* Ddo_br_scheme_chem_regimens_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_scheme_chem_regimens_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_scheme_chem_regimens_Sortedstatus = "ASC";
            ucDdo_br_scheme_chem_regimens.SendProperty(context, "", false, Ddo_br_scheme_chem_regimens_Internalname, "SortedStatus", Ddo_br_scheme_chem_regimens_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_scheme_chem_regimens_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_scheme_chem_regimens_Sortedstatus = "DSC";
            ucDdo_br_scheme_chem_regimens.SendProperty(context, "", false, Ddo_br_scheme_chem_regimens_Internalname, "SortedStatus", Ddo_br_scheme_chem_regimens_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_scheme_chem_regimens_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV25TFBR_Scheme_Chem_Regimens = Ddo_br_scheme_chem_regimens_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_Scheme_Chem_Regimens", AV25TFBR_Scheme_Chem_Regimens);
            AV26TFBR_Scheme_Chem_Regimens_Sel = Ddo_br_scheme_chem_regimens_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_Scheme_Chem_Regimens_Sel", AV26TFBR_Scheme_Chem_Regimens_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_SchemeIDTitleFilterData", AV16BR_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Scheme_Chem_RegimensTitleFilterData", AV24BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Scheme_Therapy_LineTitleFilterData", AV28BR_Scheme_Therapy_LineTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Scheme_Chem_CycleTitleFilterData", AV32BR_Scheme_Chem_CycleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Scheme_Chem_DetailTitleFilterData", AV36BR_Scheme_Chem_DetailTitleFilterData);
      }

      protected void E166E2( )
      {
         /* Ddo_br_scheme_therapy_line_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_scheme_therapy_line_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_scheme_therapy_line_Sortedstatus = "ASC";
            ucDdo_br_scheme_therapy_line.SendProperty(context, "", false, Ddo_br_scheme_therapy_line_Internalname, "SortedStatus", Ddo_br_scheme_therapy_line_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_scheme_therapy_line_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_scheme_therapy_line_Sortedstatus = "DSC";
            ucDdo_br_scheme_therapy_line.SendProperty(context, "", false, Ddo_br_scheme_therapy_line_Internalname, "SortedStatus", Ddo_br_scheme_therapy_line_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_scheme_therapy_line_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV29TFBR_Scheme_Therapy_Line = Ddo_br_scheme_therapy_line_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_Scheme_Therapy_Line", AV29TFBR_Scheme_Therapy_Line);
            AV30TFBR_Scheme_Therapy_Line_Sel = Ddo_br_scheme_therapy_line_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_Scheme_Therapy_Line_Sel", AV30TFBR_Scheme_Therapy_Line_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_SchemeIDTitleFilterData", AV16BR_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Scheme_Chem_RegimensTitleFilterData", AV24BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Scheme_Therapy_LineTitleFilterData", AV28BR_Scheme_Therapy_LineTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Scheme_Chem_CycleTitleFilterData", AV32BR_Scheme_Chem_CycleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Scheme_Chem_DetailTitleFilterData", AV36BR_Scheme_Chem_DetailTitleFilterData);
      }

      protected void E176E2( )
      {
         /* Ddo_br_scheme_chem_cycle_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_scheme_chem_cycle_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_scheme_chem_cycle_Sortedstatus = "ASC";
            ucDdo_br_scheme_chem_cycle.SendProperty(context, "", false, Ddo_br_scheme_chem_cycle_Internalname, "SortedStatus", Ddo_br_scheme_chem_cycle_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_scheme_chem_cycle_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_scheme_chem_cycle_Sortedstatus = "DSC";
            ucDdo_br_scheme_chem_cycle.SendProperty(context, "", false, Ddo_br_scheme_chem_cycle_Internalname, "SortedStatus", Ddo_br_scheme_chem_cycle_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_scheme_chem_cycle_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV33TFBR_Scheme_Chem_Cycle = NumberUtil.Val( Ddo_br_scheme_chem_cycle_Filteredtext_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TFBR_Scheme_Chem_Cycle", StringUtil.LTrim( StringUtil.Str( AV33TFBR_Scheme_Chem_Cycle, 15, 5)));
            AV34TFBR_Scheme_Chem_Cycle_To = NumberUtil.Val( Ddo_br_scheme_chem_cycle_Filteredtextto_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFBR_Scheme_Chem_Cycle_To", StringUtil.LTrim( StringUtil.Str( AV34TFBR_Scheme_Chem_Cycle_To, 15, 5)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_SchemeIDTitleFilterData", AV16BR_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Scheme_Chem_RegimensTitleFilterData", AV24BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Scheme_Therapy_LineTitleFilterData", AV28BR_Scheme_Therapy_LineTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Scheme_Chem_CycleTitleFilterData", AV32BR_Scheme_Chem_CycleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Scheme_Chem_DetailTitleFilterData", AV36BR_Scheme_Chem_DetailTitleFilterData);
      }

      protected void E186E2( )
      {
         /* Ddo_br_scheme_chem_detail_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_scheme_chem_detail_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_scheme_chem_detail_Sortedstatus = "ASC";
            ucDdo_br_scheme_chem_detail.SendProperty(context, "", false, Ddo_br_scheme_chem_detail_Internalname, "SortedStatus", Ddo_br_scheme_chem_detail_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_scheme_chem_detail_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_scheme_chem_detail_Sortedstatus = "DSC";
            ucDdo_br_scheme_chem_detail.SendProperty(context, "", false, Ddo_br_scheme_chem_detail_Internalname, "SortedStatus", Ddo_br_scheme_chem_detail_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_scheme_chem_detail_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV37TFBR_Scheme_Chem_Detail = Ddo_br_scheme_chem_detail_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37TFBR_Scheme_Chem_Detail", AV37TFBR_Scheme_Chem_Detail);
            AV38TFBR_Scheme_Chem_Detail_Sel = Ddo_br_scheme_chem_detail_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38TFBR_Scheme_Chem_Detail_Sel", AV38TFBR_Scheme_Chem_Detail_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_SchemeIDTitleFilterData", AV16BR_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Scheme_Chem_RegimensTitleFilterData", AV24BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Scheme_Therapy_LineTitleFilterData", AV28BR_Scheme_Therapy_LineTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Scheme_Chem_CycleTitleFilterData", AV32BR_Scheme_Chem_CycleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Scheme_Chem_DetailTitleFilterData", AV36BR_Scheme_Chem_DetailTitleFilterData);
      }

      private void E226E2( )
      {
         /* Grid_Load Routine */
         AV45Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDisplay_Internalname, AV45Display);
         AV65Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = formatLink("br_schemeview.aspx") + "?" + UrlEncode("" +A327BR_SchemeID) + "," + UrlEncode(StringUtil.RTrim(""));
         AV46Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV46Update);
         AV66Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavUpdate_Tooltiptext = "修改";
         if ( AV47IsAuthorized_Update )
         {
            edtavUpdate_Link = formatLink("br_scheme.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A327BR_SchemeID);
         }
         AV48Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV48Delete);
         AV67Delete_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavDelete_Tooltiptext = "删除";
         if ( AV49IsAuthorized_Delete )
         {
            edtavDelete_Link = formatLink("br_scheme.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A327BR_SchemeID);
         }
         edtBR_Scheme_Chem_Regimens_Link = formatLink("br_schemeview.aspx") + "?" + UrlEncode("" +A327BR_SchemeID) + "," + UrlEncode(StringUtil.RTrim(""));
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
         /*  Sending Event outputs  */
      }

      protected void E196E2( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("br_scheme.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S162( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_br_schemeid_Sortedstatus = "";
         ucDdo_br_schemeid.SendProperty(context, "", false, Ddo_br_schemeid_Internalname, "SortedStatus", Ddo_br_schemeid_Sortedstatus);
         Ddo_br_encounterid_Sortedstatus = "";
         ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
         Ddo_br_scheme_chem_regimens_Sortedstatus = "";
         ucDdo_br_scheme_chem_regimens.SendProperty(context, "", false, Ddo_br_scheme_chem_regimens_Internalname, "SortedStatus", Ddo_br_scheme_chem_regimens_Sortedstatus);
         Ddo_br_scheme_therapy_line_Sortedstatus = "";
         ucDdo_br_scheme_therapy_line.SendProperty(context, "", false, Ddo_br_scheme_therapy_line_Internalname, "SortedStatus", Ddo_br_scheme_therapy_line_Sortedstatus);
         Ddo_br_scheme_chem_cycle_Sortedstatus = "";
         ucDdo_br_scheme_chem_cycle.SendProperty(context, "", false, Ddo_br_scheme_chem_cycle_Internalname, "SortedStatus", Ddo_br_scheme_chem_cycle_Sortedstatus);
         Ddo_br_scheme_chem_detail_Sortedstatus = "";
         ucDdo_br_scheme_chem_detail.SendProperty(context, "", false, Ddo_br_scheme_chem_detail_Internalname, "SortedStatus", Ddo_br_scheme_chem_detail_Sortedstatus);
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
         if ( AV13OrderedBy == 1 )
         {
            Ddo_br_schemeid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_schemeid.SendProperty(context, "", false, Ddo_br_schemeid_Internalname, "SortedStatus", Ddo_br_schemeid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 2 )
         {
            Ddo_br_encounterid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 3 )
         {
            Ddo_br_scheme_chem_regimens_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_scheme_chem_regimens.SendProperty(context, "", false, Ddo_br_scheme_chem_regimens_Internalname, "SortedStatus", Ddo_br_scheme_chem_regimens_Sortedstatus);
         }
         else if ( AV13OrderedBy == 4 )
         {
            Ddo_br_scheme_therapy_line_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_scheme_therapy_line.SendProperty(context, "", false, Ddo_br_scheme_therapy_line_Internalname, "SortedStatus", Ddo_br_scheme_therapy_line_Sortedstatus);
         }
         else if ( AV13OrderedBy == 5 )
         {
            Ddo_br_scheme_chem_cycle_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_scheme_chem_cycle.SendProperty(context, "", false, Ddo_br_scheme_chem_cycle_Internalname, "SortedStatus", Ddo_br_scheme_chem_cycle_Sortedstatus);
         }
         else if ( AV13OrderedBy == 6 )
         {
            Ddo_br_scheme_chem_detail_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_scheme_chem_detail.SendProperty(context, "", false, Ddo_br_scheme_chem_detail_Internalname, "SortedStatus", Ddo_br_scheme_chem_detail_Sortedstatus);
         }
      }

      protected void S142( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean2 = AV47IsAuthorized_Update;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Scheme", out  GXt_boolean2) ;
         AV47IsAuthorized_Update = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47IsAuthorized_Update", AV47IsAuthorized_Update);
         if ( ! ( AV47IsAuthorized_Update ) )
         {
            edtavUpdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_31_Refreshing);
         }
         GXt_boolean2 = AV49IsAuthorized_Delete;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Scheme", out  GXt_boolean2) ;
         AV49IsAuthorized_Delete = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49IsAuthorized_Delete", AV49IsAuthorized_Delete);
         if ( ! ( AV49IsAuthorized_Delete ) )
         {
            edtavDelete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Visible), 5, 0)), !bGXsfl_31_Refreshing);
         }
         GXt_boolean2 = AV50TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Scheme", out  GXt_boolean2) ;
         AV50TempBoolean = GXt_boolean2;
         if ( ! ( AV50TempBoolean ) )
         {
            bttBtninsert_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtninsert_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtninsert_Visible), 5, 0)), true);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV15Session.Get(AV68Pgmname+"GridState"), "") == 0 )
         {
            AV11GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV68Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV11GridState.FromXml(AV15Session.Get(AV68Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
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
         AV69GXV1 = 1;
         while ( AV69GXV1 <= AV11GridState.gxTpr_Filtervalues.Count )
         {
            AV12GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV11GridState.gxTpr_Filtervalues.Item(AV69GXV1));
            if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_SCHEMEID") == 0 )
            {
               AV17TFBR_SchemeID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_SchemeID), 18, 0)));
               AV18TFBR_SchemeID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_SchemeID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_SchemeID_To), 18, 0)));
               if ( ! (0==AV17TFBR_SchemeID) )
               {
                  Ddo_br_schemeid_Filteredtext_set = StringUtil.Str( (decimal)(AV17TFBR_SchemeID), 18, 0);
                  ucDdo_br_schemeid.SendProperty(context, "", false, Ddo_br_schemeid_Internalname, "FilteredText_set", Ddo_br_schemeid_Filteredtext_set);
               }
               if ( ! (0==AV18TFBR_SchemeID_To) )
               {
                  Ddo_br_schemeid_Filteredtextto_set = StringUtil.Str( (decimal)(AV18TFBR_SchemeID_To), 18, 0);
                  ucDdo_br_schemeid.SendProperty(context, "", false, Ddo_br_schemeid_Internalname, "FilteredTextTo_set", Ddo_br_schemeid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTERID") == 0 )
            {
               AV21TFBR_EncounterID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_EncounterID), 18, 0)));
               AV22TFBR_EncounterID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_EncounterID_To), 18, 0)));
               if ( ! (0==AV21TFBR_EncounterID) )
               {
                  Ddo_br_encounterid_Filteredtext_set = StringUtil.Str( (decimal)(AV21TFBR_EncounterID), 18, 0);
                  ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "FilteredText_set", Ddo_br_encounterid_Filteredtext_set);
               }
               if ( ! (0==AV22TFBR_EncounterID_To) )
               {
                  Ddo_br_encounterid_Filteredtextto_set = StringUtil.Str( (decimal)(AV22TFBR_EncounterID_To), 18, 0);
                  ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "FilteredTextTo_set", Ddo_br_encounterid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_SCHEME_CHEM_REGIMENS") == 0 )
            {
               AV25TFBR_Scheme_Chem_Regimens = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_Scheme_Chem_Regimens", AV25TFBR_Scheme_Chem_Regimens);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV25TFBR_Scheme_Chem_Regimens)) )
               {
                  Ddo_br_scheme_chem_regimens_Filteredtext_set = AV25TFBR_Scheme_Chem_Regimens;
                  ucDdo_br_scheme_chem_regimens.SendProperty(context, "", false, Ddo_br_scheme_chem_regimens_Internalname, "FilteredText_set", Ddo_br_scheme_chem_regimens_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_SCHEME_CHEM_REGIMENS_SEL") == 0 )
            {
               AV26TFBR_Scheme_Chem_Regimens_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_Scheme_Chem_Regimens_Sel", AV26TFBR_Scheme_Chem_Regimens_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26TFBR_Scheme_Chem_Regimens_Sel)) )
               {
                  Ddo_br_scheme_chem_regimens_Selectedvalue_set = AV26TFBR_Scheme_Chem_Regimens_Sel;
                  ucDdo_br_scheme_chem_regimens.SendProperty(context, "", false, Ddo_br_scheme_chem_regimens_Internalname, "SelectedValue_set", Ddo_br_scheme_chem_regimens_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_SCHEME_THERAPY_LINE") == 0 )
            {
               AV29TFBR_Scheme_Therapy_Line = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_Scheme_Therapy_Line", AV29TFBR_Scheme_Therapy_Line);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV29TFBR_Scheme_Therapy_Line)) )
               {
                  Ddo_br_scheme_therapy_line_Filteredtext_set = AV29TFBR_Scheme_Therapy_Line;
                  ucDdo_br_scheme_therapy_line.SendProperty(context, "", false, Ddo_br_scheme_therapy_line_Internalname, "FilteredText_set", Ddo_br_scheme_therapy_line_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_SCHEME_THERAPY_LINE_SEL") == 0 )
            {
               AV30TFBR_Scheme_Therapy_Line_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_Scheme_Therapy_Line_Sel", AV30TFBR_Scheme_Therapy_Line_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV30TFBR_Scheme_Therapy_Line_Sel)) )
               {
                  Ddo_br_scheme_therapy_line_Selectedvalue_set = AV30TFBR_Scheme_Therapy_Line_Sel;
                  ucDdo_br_scheme_therapy_line.SendProperty(context, "", false, Ddo_br_scheme_therapy_line_Internalname, "SelectedValue_set", Ddo_br_scheme_therapy_line_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_SCHEME_CHEM_CYCLE") == 0 )
            {
               AV33TFBR_Scheme_Chem_Cycle = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TFBR_Scheme_Chem_Cycle", StringUtil.LTrim( StringUtil.Str( AV33TFBR_Scheme_Chem_Cycle, 15, 5)));
               AV34TFBR_Scheme_Chem_Cycle_To = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFBR_Scheme_Chem_Cycle_To", StringUtil.LTrim( StringUtil.Str( AV34TFBR_Scheme_Chem_Cycle_To, 15, 5)));
               if ( ! (Convert.ToDecimal(0)==AV33TFBR_Scheme_Chem_Cycle) )
               {
                  Ddo_br_scheme_chem_cycle_Filteredtext_set = StringUtil.Str( AV33TFBR_Scheme_Chem_Cycle, 15, 5);
                  ucDdo_br_scheme_chem_cycle.SendProperty(context, "", false, Ddo_br_scheme_chem_cycle_Internalname, "FilteredText_set", Ddo_br_scheme_chem_cycle_Filteredtext_set);
               }
               if ( ! (Convert.ToDecimal(0)==AV34TFBR_Scheme_Chem_Cycle_To) )
               {
                  Ddo_br_scheme_chem_cycle_Filteredtextto_set = StringUtil.Str( AV34TFBR_Scheme_Chem_Cycle_To, 15, 5);
                  ucDdo_br_scheme_chem_cycle.SendProperty(context, "", false, Ddo_br_scheme_chem_cycle_Internalname, "FilteredTextTo_set", Ddo_br_scheme_chem_cycle_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_SCHEME_CHEM_DETAIL") == 0 )
            {
               AV37TFBR_Scheme_Chem_Detail = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37TFBR_Scheme_Chem_Detail", AV37TFBR_Scheme_Chem_Detail);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV37TFBR_Scheme_Chem_Detail)) )
               {
                  Ddo_br_scheme_chem_detail_Filteredtext_set = AV37TFBR_Scheme_Chem_Detail;
                  ucDdo_br_scheme_chem_detail.SendProperty(context, "", false, Ddo_br_scheme_chem_detail_Internalname, "FilteredText_set", Ddo_br_scheme_chem_detail_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_SCHEME_CHEM_DETAIL_SEL") == 0 )
            {
               AV38TFBR_Scheme_Chem_Detail_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38TFBR_Scheme_Chem_Detail_Sel", AV38TFBR_Scheme_Chem_Detail_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV38TFBR_Scheme_Chem_Detail_Sel)) )
               {
                  Ddo_br_scheme_chem_detail_Selectedvalue_set = AV38TFBR_Scheme_Chem_Detail_Sel;
                  ucDdo_br_scheme_chem_detail.SendProperty(context, "", false, Ddo_br_scheme_chem_detail_Internalname, "SelectedValue_set", Ddo_br_scheme_chem_detail_Selectedvalue_set);
               }
            }
            AV69GXV1 = (int)(AV69GXV1+1);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV11GridState.gxTpr_Pagesize))) )
         {
            subGrid_Rows = (int)(NumberUtil.Val( AV11GridState.gxTpr_Pagesize, "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         }
         subgrid_gotopage( AV11GridState.gxTpr_Currentpage) ;
      }

      protected void S152( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV11GridState.FromXml(AV15Session.Get(AV68Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV11GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV11GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV11GridState.gxTpr_Filtervalues.Clear();
         if ( ! ( (0==AV17TFBR_SchemeID) && (0==AV18TFBR_SchemeID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_SCHEMEID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV17TFBR_SchemeID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV18TFBR_SchemeID_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (0==AV21TFBR_EncounterID) && (0==AV22TFBR_EncounterID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_ENCOUNTERID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV21TFBR_EncounterID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV22TFBR_EncounterID_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV25TFBR_Scheme_Chem_Regimens)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_SCHEME_CHEM_REGIMENS";
            AV12GridStateFilterValue.gxTpr_Value = AV25TFBR_Scheme_Chem_Regimens;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26TFBR_Scheme_Chem_Regimens_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_SCHEME_CHEM_REGIMENS_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV26TFBR_Scheme_Chem_Regimens_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV29TFBR_Scheme_Therapy_Line)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_SCHEME_THERAPY_LINE";
            AV12GridStateFilterValue.gxTpr_Value = AV29TFBR_Scheme_Therapy_Line;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV30TFBR_Scheme_Therapy_Line_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_SCHEME_THERAPY_LINE_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV30TFBR_Scheme_Therapy_Line_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (Convert.ToDecimal(0)==AV33TFBR_Scheme_Chem_Cycle) && (Convert.ToDecimal(0)==AV34TFBR_Scheme_Chem_Cycle_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_SCHEME_CHEM_CYCLE";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( AV33TFBR_Scheme_Chem_Cycle, 15, 5);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( AV34TFBR_Scheme_Chem_Cycle_To, 15, 5);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV37TFBR_Scheme_Chem_Detail)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_SCHEME_CHEM_DETAIL";
            AV12GridStateFilterValue.gxTpr_Value = AV37TFBR_Scheme_Chem_Detail;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV38TFBR_Scheme_Chem_Detail_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_SCHEME_CHEM_DETAIL_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV38TFBR_Scheme_Chem_Detail_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         AV11GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV11GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV68Pgmname+"GridState",  AV11GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV68Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Scheme";
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
         PA6E2( ) ;
         WS6E2( ) ;
         WE6E2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202271253758", true);
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
         context.AddJavascriptSource("br_schemeww.js", "?20202271253758", false);
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
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_312( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_31_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_31_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_31_idx;
         edtBR_SchemeID_Internalname = "BR_SCHEMEID_"+sGXsfl_31_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_31_idx;
         edtBR_Scheme_Chem_Regimens_Internalname = "BR_SCHEME_CHEM_REGIMENS_"+sGXsfl_31_idx;
         edtBR_Scheme_Therapy_Line_Internalname = "BR_SCHEME_THERAPY_LINE_"+sGXsfl_31_idx;
         edtBR_Scheme_Chem_Cycle_Internalname = "BR_SCHEME_CHEM_CYCLE_"+sGXsfl_31_idx;
         edtBR_Scheme_Chem_Detail_Internalname = "BR_SCHEME_CHEM_DETAIL_"+sGXsfl_31_idx;
      }

      protected void SubsflControlProps_fel_312( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_31_fel_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_31_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_31_fel_idx;
         edtBR_SchemeID_Internalname = "BR_SCHEMEID_"+sGXsfl_31_fel_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_31_fel_idx;
         edtBR_Scheme_Chem_Regimens_Internalname = "BR_SCHEME_CHEM_REGIMENS_"+sGXsfl_31_fel_idx;
         edtBR_Scheme_Therapy_Line_Internalname = "BR_SCHEME_THERAPY_LINE_"+sGXsfl_31_fel_idx;
         edtBR_Scheme_Chem_Cycle_Internalname = "BR_SCHEME_CHEM_CYCLE_"+sGXsfl_31_fel_idx;
         edtBR_Scheme_Chem_Detail_Internalname = "BR_SCHEME_CHEM_DETAIL_"+sGXsfl_31_fel_idx;
      }

      protected void sendrow_312( )
      {
         SubsflControlProps_312( ) ;
         WB6E0( ) ;
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
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV45Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV45Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV65Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV45Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV45Display)) ? AV65Display_GXI : context.PathToRelativeUrl( AV45Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV45Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV46Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV46Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV66Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV46Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV46Update)) ? AV66Update_GXI : context.PathToRelativeUrl( AV46Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavUpdate_Visible,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV46Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "DeleteAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV48Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV48Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV67Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV48Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV48Delete)) ? AV67Delete_GXI : context.PathToRelativeUrl( AV48Delete));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)edtavDelete_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavDelete_Visible,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV48Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_SchemeID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A327BR_SchemeID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A327BR_SchemeID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_SchemeID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_EncounterID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_EncounterID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Scheme_Chem_Regimens_Internalname,(String)A328BR_Scheme_Chem_Regimens,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtBR_Scheme_Chem_Regimens_Link,(String)"",(String)"",(String)"",(String)edtBR_Scheme_Chem_Regimens_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Scheme_Therapy_Line_Internalname,(String)A329BR_Scheme_Therapy_Line,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Scheme_Therapy_Line_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Scheme_Chem_Cycle_Internalname,StringUtil.LTrim( StringUtil.NToC( A330BR_Scheme_Chem_Cycle, 15, 5, ".", "")),context.localUtil.Format( A330BR_Scheme_Chem_Cycle, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Scheme_Chem_Cycle_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Scheme_Chem_Detail_Internalname,(String)A331BR_Scheme_Chem_Detail,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Scheme_Chem_Detail_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4000,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes6E2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_31_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_31_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_31_idx+1));
            sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
            SubsflControlProps_312( ) ;
         }
         /* End function sendrow_312 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtninsert_Internalname = "BTNINSERT";
         divTableactions_Internalname = "TABLEACTIONS";
         divTableheader_Internalname = "TABLEHEADER";
         divLayout_tableheader_Internalname = "LAYOUT_TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         divHtml_dvpanel_tableheader_Internalname = "HTML_DVPANEL_TABLEHEADER";
         edtavDisplay_Internalname = "vDISPLAY";
         edtavUpdate_Internalname = "vUPDATE";
         edtavDelete_Internalname = "vDELETE";
         edtBR_SchemeID_Internalname = "BR_SCHEMEID";
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtBR_Scheme_Chem_Regimens_Internalname = "BR_SCHEME_CHEM_REGIMENS";
         edtBR_Scheme_Therapy_Line_Internalname = "BR_SCHEME_THERAPY_LINE";
         edtBR_Scheme_Chem_Cycle_Internalname = "BR_SCHEME_CHEM_CYCLE";
         edtBR_Scheme_Chem_Detail_Internalname = "BR_SCHEME_CHEM_DETAIL";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_schemeid_Internalname = "DDO_BR_SCHEMEID";
         edtavDdo_br_schemeidtitlecontrolidtoreplace_Internalname = "vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE";
         Ddo_br_encounterid_Internalname = "DDO_BR_ENCOUNTERID";
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE";
         Ddo_br_scheme_chem_regimens_Internalname = "DDO_BR_SCHEME_CHEM_REGIMENS";
         edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Internalname = "vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE";
         Ddo_br_scheme_therapy_line_Internalname = "DDO_BR_SCHEME_THERAPY_LINE";
         edtavDdo_br_scheme_therapy_linetitlecontrolidtoreplace_Internalname = "vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE";
         Ddo_br_scheme_chem_cycle_Internalname = "DDO_BR_SCHEME_CHEM_CYCLE";
         edtavDdo_br_scheme_chem_cycletitlecontrolidtoreplace_Internalname = "vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE";
         Ddo_br_scheme_chem_detail_Internalname = "DDO_BR_SCHEME_CHEM_DETAIL";
         edtavDdo_br_scheme_chem_detailtitlecontrolidtoreplace_Internalname = "vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         edtavTfbr_schemeid_Internalname = "vTFBR_SCHEMEID";
         edtavTfbr_schemeid_to_Internalname = "vTFBR_SCHEMEID_TO";
         edtavTfbr_encounterid_Internalname = "vTFBR_ENCOUNTERID";
         edtavTfbr_encounterid_to_Internalname = "vTFBR_ENCOUNTERID_TO";
         edtavTfbr_scheme_chem_regimens_Internalname = "vTFBR_SCHEME_CHEM_REGIMENS";
         edtavTfbr_scheme_chem_regimens_sel_Internalname = "vTFBR_SCHEME_CHEM_REGIMENS_SEL";
         edtavTfbr_scheme_therapy_line_Internalname = "vTFBR_SCHEME_THERAPY_LINE";
         edtavTfbr_scheme_therapy_line_sel_Internalname = "vTFBR_SCHEME_THERAPY_LINE_SEL";
         edtavTfbr_scheme_chem_cycle_Internalname = "vTFBR_SCHEME_CHEM_CYCLE";
         edtavTfbr_scheme_chem_cycle_to_Internalname = "vTFBR_SCHEME_CHEM_CYCLE_TO";
         edtavTfbr_scheme_chem_detail_Internalname = "vTFBR_SCHEME_CHEM_DETAIL";
         edtavTfbr_scheme_chem_detail_sel_Internalname = "vTFBR_SCHEME_CHEM_DETAIL_SEL";
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
         edtBR_Scheme_Chem_Detail_Jsonclick = "";
         edtBR_Scheme_Chem_Cycle_Jsonclick = "";
         edtBR_Scheme_Therapy_Line_Jsonclick = "";
         edtBR_Scheme_Chem_Regimens_Jsonclick = "";
         edtBR_EncounterID_Jsonclick = "";
         edtBR_SchemeID_Jsonclick = "";
         edtavTfbr_scheme_chem_detail_sel_Visible = 1;
         edtavTfbr_scheme_chem_detail_Visible = 1;
         edtavTfbr_scheme_chem_cycle_to_Jsonclick = "";
         edtavTfbr_scheme_chem_cycle_to_Visible = 1;
         edtavTfbr_scheme_chem_cycle_Jsonclick = "";
         edtavTfbr_scheme_chem_cycle_Visible = 1;
         edtavTfbr_scheme_therapy_line_sel_Jsonclick = "";
         edtavTfbr_scheme_therapy_line_sel_Visible = 1;
         edtavTfbr_scheme_therapy_line_Jsonclick = "";
         edtavTfbr_scheme_therapy_line_Visible = 1;
         edtavTfbr_scheme_chem_regimens_sel_Jsonclick = "";
         edtavTfbr_scheme_chem_regimens_sel_Visible = 1;
         edtavTfbr_scheme_chem_regimens_Jsonclick = "";
         edtavTfbr_scheme_chem_regimens_Visible = 1;
         edtavTfbr_encounterid_to_Jsonclick = "";
         edtavTfbr_encounterid_to_Visible = 1;
         edtavTfbr_encounterid_Jsonclick = "";
         edtavTfbr_encounterid_Visible = 1;
         edtavTfbr_schemeid_to_Jsonclick = "";
         edtavTfbr_schemeid_to_Visible = 1;
         edtavTfbr_schemeid_Jsonclick = "";
         edtavTfbr_schemeid_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_scheme_chem_detailtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_scheme_chem_cycletitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_scheme_therapy_linetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_schemeidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtBR_Scheme_Chem_Regimens_Link = "";
         edtavDelete_Tooltiptext = "删除";
         edtavDelete_Link = "";
         edtavUpdate_Tooltiptext = "修改";
         edtavUpdate_Link = "";
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Scheme_Chem_Detail_Titleformat = 0;
         edtBR_Scheme_Chem_Detail_Title = "化疗方案描述";
         edtBR_Scheme_Chem_Cycle_Titleformat = 0;
         edtBR_Scheme_Chem_Cycle_Title = "化疗周期";
         edtBR_Scheme_Therapy_Line_Titleformat = 0;
         edtBR_Scheme_Therapy_Line_Title = "方案线级";
         edtBR_Scheme_Chem_Regimens_Titleformat = 0;
         edtBR_Scheme_Chem_Regimens_Title = "化疗方案";
         edtBR_EncounterID_Titleformat = 0;
         edtBR_EncounterID_Title = "就诊信息主键";
         edtBR_SchemeID_Titleformat = 0;
         edtBR_SchemeID_Title = "化疗方案主键";
         edtavDelete_Visible = -1;
         edtavUpdate_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         bttBtninsert_Visible = 1;
         Ddo_br_scheme_chem_detail_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_scheme_chem_detail_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_scheme_chem_detail_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_scheme_chem_detail_Loadingdata = "WWP_TSLoading";
         Ddo_br_scheme_chem_detail_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_scheme_chem_detail_Sortasc = "WWP_TSSortASC";
         Ddo_br_scheme_chem_detail_Datalistupdateminimumcharacters = 0;
         Ddo_br_scheme_chem_detail_Datalistproc = "BR_SchemeWWGetFilterData";
         Ddo_br_scheme_chem_detail_Datalisttype = "Dynamic";
         Ddo_br_scheme_chem_detail_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_scheme_chem_detail_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_scheme_chem_detail_Filtertype = "Character";
         Ddo_br_scheme_chem_detail_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_scheme_chem_detail_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_scheme_chem_detail_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_scheme_chem_detail_Titlecontrolidtoreplace = "";
         Ddo_br_scheme_chem_detail_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_scheme_chem_detail_Cls = "ColumnSettings";
         Ddo_br_scheme_chem_detail_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_scheme_chem_detail_Caption = "";
         Ddo_br_scheme_chem_cycle_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_scheme_chem_cycle_Rangefilterto = "WWP_TSTo";
         Ddo_br_scheme_chem_cycle_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_scheme_chem_cycle_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_scheme_chem_cycle_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_scheme_chem_cycle_Sortasc = "WWP_TSSortASC";
         Ddo_br_scheme_chem_cycle_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_scheme_chem_cycle_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_scheme_chem_cycle_Filtertype = "Numeric";
         Ddo_br_scheme_chem_cycle_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_scheme_chem_cycle_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_scheme_chem_cycle_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_scheme_chem_cycle_Titlecontrolidtoreplace = "";
         Ddo_br_scheme_chem_cycle_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_scheme_chem_cycle_Cls = "ColumnSettings";
         Ddo_br_scheme_chem_cycle_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_scheme_chem_cycle_Caption = "";
         Ddo_br_scheme_therapy_line_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_scheme_therapy_line_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_scheme_therapy_line_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_scheme_therapy_line_Loadingdata = "WWP_TSLoading";
         Ddo_br_scheme_therapy_line_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_scheme_therapy_line_Sortasc = "WWP_TSSortASC";
         Ddo_br_scheme_therapy_line_Datalistupdateminimumcharacters = 0;
         Ddo_br_scheme_therapy_line_Datalistproc = "BR_SchemeWWGetFilterData";
         Ddo_br_scheme_therapy_line_Datalisttype = "Dynamic";
         Ddo_br_scheme_therapy_line_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_scheme_therapy_line_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_scheme_therapy_line_Filtertype = "Character";
         Ddo_br_scheme_therapy_line_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_scheme_therapy_line_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_scheme_therapy_line_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_scheme_therapy_line_Titlecontrolidtoreplace = "";
         Ddo_br_scheme_therapy_line_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_scheme_therapy_line_Cls = "ColumnSettings";
         Ddo_br_scheme_therapy_line_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_scheme_therapy_line_Caption = "";
         Ddo_br_scheme_chem_regimens_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_scheme_chem_regimens_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_scheme_chem_regimens_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_scheme_chem_regimens_Loadingdata = "WWP_TSLoading";
         Ddo_br_scheme_chem_regimens_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_scheme_chem_regimens_Sortasc = "WWP_TSSortASC";
         Ddo_br_scheme_chem_regimens_Datalistupdateminimumcharacters = 0;
         Ddo_br_scheme_chem_regimens_Datalistproc = "BR_SchemeWWGetFilterData";
         Ddo_br_scheme_chem_regimens_Datalisttype = "Dynamic";
         Ddo_br_scheme_chem_regimens_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_scheme_chem_regimens_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_scheme_chem_regimens_Filtertype = "Character";
         Ddo_br_scheme_chem_regimens_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_scheme_chem_regimens_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_scheme_chem_regimens_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace = "";
         Ddo_br_scheme_chem_regimens_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_scheme_chem_regimens_Cls = "ColumnSettings";
         Ddo_br_scheme_chem_regimens_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_scheme_chem_regimens_Caption = "";
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
         Ddo_br_schemeid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_schemeid_Rangefilterto = "WWP_TSTo";
         Ddo_br_schemeid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_schemeid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_schemeid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_schemeid_Sortasc = "WWP_TSSortASC";
         Ddo_br_schemeid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_schemeid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_schemeid_Filtertype = "Numeric";
         Ddo_br_schemeid_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_schemeid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_schemeid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_schemeid_Titlecontrolidtoreplace = "";
         Ddo_br_schemeid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_schemeid_Cls = "ColumnSettings";
         Ddo_br_schemeid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_schemeid_Caption = "";
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
         Form.Caption = " 化疗方案";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV19ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV17TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV26TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV29TFBR_Scheme_Therapy_Line',fld:'vTFBR_SCHEME_THERAPY_LINE',pic:''},{av:'AV30TFBR_Scheme_Therapy_Line_Sel',fld:'vTFBR_SCHEME_THERAPY_LINE_SEL',pic:''},{av:'AV33TFBR_Scheme_Chem_Cycle',fld:'vTFBR_SCHEME_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV34TFBR_Scheme_Chem_Cycle_To',fld:'vTFBR_SCHEME_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV37TFBR_Scheme_Chem_Detail',fld:'vTFBR_SCHEME_CHEM_DETAIL',pic:''},{av:'AV38TFBR_Scheme_Chem_Detail_Sel',fld:'vTFBR_SCHEME_CHEM_DETAIL_SEL',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV16BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV28BR_Scheme_Therapy_LineTitleFilterData',fld:'vBR_SCHEME_THERAPY_LINETITLEFILTERDATA',pic:''},{av:'AV32BR_Scheme_Chem_CycleTitleFilterData',fld:'vBR_SCHEME_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV36BR_Scheme_Chem_DetailTitleFilterData',fld:'vBR_SCHEME_CHEM_DETAILTITLEFILTERDATA',pic:''},{av:'edtBR_SchemeID_Titleformat',ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'edtBR_SchemeID_Title',ctrl:'BR_SCHEMEID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Scheme_Therapy_Line_Titleformat',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Titleformat'},{av:'edtBR_Scheme_Therapy_Line_Title',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Title'},{av:'edtBR_Scheme_Chem_Cycle_Titleformat',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Cycle_Title',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Title'},{av:'edtBR_Scheme_Chem_Detail_Titleformat',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Detail_Title',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E116E2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV26TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV29TFBR_Scheme_Therapy_Line',fld:'vTFBR_SCHEME_THERAPY_LINE',pic:''},{av:'AV30TFBR_Scheme_Therapy_Line_Sel',fld:'vTFBR_SCHEME_THERAPY_LINE_SEL',pic:''},{av:'AV33TFBR_Scheme_Chem_Cycle',fld:'vTFBR_SCHEME_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV34TFBR_Scheme_Chem_Cycle_To',fld:'vTFBR_SCHEME_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV37TFBR_Scheme_Chem_Detail',fld:'vTFBR_SCHEME_CHEM_DETAIL',pic:''},{av:'AV38TFBR_Scheme_Chem_Detail_Sel',fld:'vTFBR_SCHEME_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E126E2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV26TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV29TFBR_Scheme_Therapy_Line',fld:'vTFBR_SCHEME_THERAPY_LINE',pic:''},{av:'AV30TFBR_Scheme_Therapy_Line_Sel',fld:'vTFBR_SCHEME_THERAPY_LINE_SEL',pic:''},{av:'AV33TFBR_Scheme_Chem_Cycle',fld:'vTFBR_SCHEME_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV34TFBR_Scheme_Chem_Cycle_To',fld:'vTFBR_SCHEME_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV37TFBR_Scheme_Chem_Detail',fld:'vTFBR_SCHEME_CHEM_DETAIL',pic:''},{av:'AV38TFBR_Scheme_Chem_Detail_Sel',fld:'vTFBR_SCHEME_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_SCHEMEID.ONOPTIONCLICKED","{handler:'E136E2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV26TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV29TFBR_Scheme_Therapy_Line',fld:'vTFBR_SCHEME_THERAPY_LINE',pic:''},{av:'AV30TFBR_Scheme_Therapy_Line_Sel',fld:'vTFBR_SCHEME_THERAPY_LINE_SEL',pic:''},{av:'AV33TFBR_Scheme_Chem_Cycle',fld:'vTFBR_SCHEME_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV34TFBR_Scheme_Chem_Cycle_To',fld:'vTFBR_SCHEME_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV37TFBR_Scheme_Chem_Detail',fld:'vTFBR_SCHEME_CHEM_DETAIL',pic:''},{av:'AV38TFBR_Scheme_Chem_Detail_Sel',fld:'vTFBR_SCHEME_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_schemeid_Activeeventkey',ctrl:'DDO_BR_SCHEMEID',prop:'ActiveEventKey'},{av:'Ddo_br_schemeid_Filteredtext_get',ctrl:'DDO_BR_SCHEMEID',prop:'FilteredText_get'},{av:'Ddo_br_schemeid_Filteredtextto_get',ctrl:'DDO_BR_SCHEMEID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_SCHEMEID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_schemeid_Sortedstatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'},{av:'AV17TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_scheme_chem_regimens_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'Ddo_br_scheme_therapy_line_Sortedstatus',ctrl:'DDO_BR_SCHEME_THERAPY_LINE',prop:'SortedStatus'},{av:'Ddo_br_scheme_chem_cycle_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_CYCLE',prop:'SortedStatus'},{av:'Ddo_br_scheme_chem_detail_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_DETAIL',prop:'SortedStatus'},{av:'AV16BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV28BR_Scheme_Therapy_LineTitleFilterData',fld:'vBR_SCHEME_THERAPY_LINETITLEFILTERDATA',pic:''},{av:'AV32BR_Scheme_Chem_CycleTitleFilterData',fld:'vBR_SCHEME_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV36BR_Scheme_Chem_DetailTitleFilterData',fld:'vBR_SCHEME_CHEM_DETAILTITLEFILTERDATA',pic:''},{av:'edtBR_SchemeID_Titleformat',ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'edtBR_SchemeID_Title',ctrl:'BR_SCHEMEID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Scheme_Therapy_Line_Titleformat',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Titleformat'},{av:'edtBR_Scheme_Therapy_Line_Title',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Title'},{av:'edtBR_Scheme_Chem_Cycle_Titleformat',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Cycle_Title',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Title'},{av:'edtBR_Scheme_Chem_Detail_Titleformat',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Detail_Title',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED","{handler:'E146E2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV26TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV29TFBR_Scheme_Therapy_Line',fld:'vTFBR_SCHEME_THERAPY_LINE',pic:''},{av:'AV30TFBR_Scheme_Therapy_Line_Sel',fld:'vTFBR_SCHEME_THERAPY_LINE_SEL',pic:''},{av:'AV33TFBR_Scheme_Chem_Cycle',fld:'vTFBR_SCHEME_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV34TFBR_Scheme_Chem_Cycle_To',fld:'vTFBR_SCHEME_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV37TFBR_Scheme_Chem_Detail',fld:'vTFBR_SCHEME_CHEM_DETAIL',pic:''},{av:'AV38TFBR_Scheme_Chem_Detail_Sel',fld:'vTFBR_SCHEME_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_encounterid_Activeeventkey',ctrl:'DDO_BR_ENCOUNTERID',prop:'ActiveEventKey'},{av:'Ddo_br_encounterid_Filteredtext_get',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredText_get'},{av:'Ddo_br_encounterid_Filteredtextto_get',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_schemeid_Sortedstatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'},{av:'Ddo_br_scheme_chem_regimens_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'Ddo_br_scheme_therapy_line_Sortedstatus',ctrl:'DDO_BR_SCHEME_THERAPY_LINE',prop:'SortedStatus'},{av:'Ddo_br_scheme_chem_cycle_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_CYCLE',prop:'SortedStatus'},{av:'Ddo_br_scheme_chem_detail_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_DETAIL',prop:'SortedStatus'},{av:'AV16BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV28BR_Scheme_Therapy_LineTitleFilterData',fld:'vBR_SCHEME_THERAPY_LINETITLEFILTERDATA',pic:''},{av:'AV32BR_Scheme_Chem_CycleTitleFilterData',fld:'vBR_SCHEME_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV36BR_Scheme_Chem_DetailTitleFilterData',fld:'vBR_SCHEME_CHEM_DETAILTITLEFILTERDATA',pic:''},{av:'edtBR_SchemeID_Titleformat',ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'edtBR_SchemeID_Title',ctrl:'BR_SCHEMEID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Scheme_Therapy_Line_Titleformat',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Titleformat'},{av:'edtBR_Scheme_Therapy_Line_Title',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Title'},{av:'edtBR_Scheme_Chem_Cycle_Titleformat',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Cycle_Title',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Title'},{av:'edtBR_Scheme_Chem_Detail_Titleformat',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Detail_Title',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_SCHEME_CHEM_REGIMENS.ONOPTIONCLICKED","{handler:'E156E2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV26TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV29TFBR_Scheme_Therapy_Line',fld:'vTFBR_SCHEME_THERAPY_LINE',pic:''},{av:'AV30TFBR_Scheme_Therapy_Line_Sel',fld:'vTFBR_SCHEME_THERAPY_LINE_SEL',pic:''},{av:'AV33TFBR_Scheme_Chem_Cycle',fld:'vTFBR_SCHEME_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV34TFBR_Scheme_Chem_Cycle_To',fld:'vTFBR_SCHEME_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV37TFBR_Scheme_Chem_Detail',fld:'vTFBR_SCHEME_CHEM_DETAIL',pic:''},{av:'AV38TFBR_Scheme_Chem_Detail_Sel',fld:'vTFBR_SCHEME_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_scheme_chem_regimens_Activeeventkey',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'ActiveEventKey'},{av:'Ddo_br_scheme_chem_regimens_Filteredtext_get',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'FilteredText_get'},{av:'Ddo_br_scheme_chem_regimens_Selectedvalue_get',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_SCHEME_CHEM_REGIMENS.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_scheme_chem_regimens_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'AV25TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV26TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'Ddo_br_schemeid_Sortedstatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_scheme_therapy_line_Sortedstatus',ctrl:'DDO_BR_SCHEME_THERAPY_LINE',prop:'SortedStatus'},{av:'Ddo_br_scheme_chem_cycle_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_CYCLE',prop:'SortedStatus'},{av:'Ddo_br_scheme_chem_detail_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_DETAIL',prop:'SortedStatus'},{av:'AV16BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV28BR_Scheme_Therapy_LineTitleFilterData',fld:'vBR_SCHEME_THERAPY_LINETITLEFILTERDATA',pic:''},{av:'AV32BR_Scheme_Chem_CycleTitleFilterData',fld:'vBR_SCHEME_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV36BR_Scheme_Chem_DetailTitleFilterData',fld:'vBR_SCHEME_CHEM_DETAILTITLEFILTERDATA',pic:''},{av:'edtBR_SchemeID_Titleformat',ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'edtBR_SchemeID_Title',ctrl:'BR_SCHEMEID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Scheme_Therapy_Line_Titleformat',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Titleformat'},{av:'edtBR_Scheme_Therapy_Line_Title',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Title'},{av:'edtBR_Scheme_Chem_Cycle_Titleformat',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Cycle_Title',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Title'},{av:'edtBR_Scheme_Chem_Detail_Titleformat',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Detail_Title',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_SCHEME_THERAPY_LINE.ONOPTIONCLICKED","{handler:'E166E2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV26TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV29TFBR_Scheme_Therapy_Line',fld:'vTFBR_SCHEME_THERAPY_LINE',pic:''},{av:'AV30TFBR_Scheme_Therapy_Line_Sel',fld:'vTFBR_SCHEME_THERAPY_LINE_SEL',pic:''},{av:'AV33TFBR_Scheme_Chem_Cycle',fld:'vTFBR_SCHEME_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV34TFBR_Scheme_Chem_Cycle_To',fld:'vTFBR_SCHEME_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV37TFBR_Scheme_Chem_Detail',fld:'vTFBR_SCHEME_CHEM_DETAIL',pic:''},{av:'AV38TFBR_Scheme_Chem_Detail_Sel',fld:'vTFBR_SCHEME_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_scheme_therapy_line_Activeeventkey',ctrl:'DDO_BR_SCHEME_THERAPY_LINE',prop:'ActiveEventKey'},{av:'Ddo_br_scheme_therapy_line_Filteredtext_get',ctrl:'DDO_BR_SCHEME_THERAPY_LINE',prop:'FilteredText_get'},{av:'Ddo_br_scheme_therapy_line_Selectedvalue_get',ctrl:'DDO_BR_SCHEME_THERAPY_LINE',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_SCHEME_THERAPY_LINE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_scheme_therapy_line_Sortedstatus',ctrl:'DDO_BR_SCHEME_THERAPY_LINE',prop:'SortedStatus'},{av:'AV29TFBR_Scheme_Therapy_Line',fld:'vTFBR_SCHEME_THERAPY_LINE',pic:''},{av:'AV30TFBR_Scheme_Therapy_Line_Sel',fld:'vTFBR_SCHEME_THERAPY_LINE_SEL',pic:''},{av:'Ddo_br_schemeid_Sortedstatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_scheme_chem_regimens_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'Ddo_br_scheme_chem_cycle_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_CYCLE',prop:'SortedStatus'},{av:'Ddo_br_scheme_chem_detail_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_DETAIL',prop:'SortedStatus'},{av:'AV16BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV28BR_Scheme_Therapy_LineTitleFilterData',fld:'vBR_SCHEME_THERAPY_LINETITLEFILTERDATA',pic:''},{av:'AV32BR_Scheme_Chem_CycleTitleFilterData',fld:'vBR_SCHEME_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV36BR_Scheme_Chem_DetailTitleFilterData',fld:'vBR_SCHEME_CHEM_DETAILTITLEFILTERDATA',pic:''},{av:'edtBR_SchemeID_Titleformat',ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'edtBR_SchemeID_Title',ctrl:'BR_SCHEMEID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Scheme_Therapy_Line_Titleformat',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Titleformat'},{av:'edtBR_Scheme_Therapy_Line_Title',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Title'},{av:'edtBR_Scheme_Chem_Cycle_Titleformat',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Cycle_Title',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Title'},{av:'edtBR_Scheme_Chem_Detail_Titleformat',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Detail_Title',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_SCHEME_CHEM_CYCLE.ONOPTIONCLICKED","{handler:'E176E2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV26TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV29TFBR_Scheme_Therapy_Line',fld:'vTFBR_SCHEME_THERAPY_LINE',pic:''},{av:'AV30TFBR_Scheme_Therapy_Line_Sel',fld:'vTFBR_SCHEME_THERAPY_LINE_SEL',pic:''},{av:'AV33TFBR_Scheme_Chem_Cycle',fld:'vTFBR_SCHEME_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV34TFBR_Scheme_Chem_Cycle_To',fld:'vTFBR_SCHEME_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV37TFBR_Scheme_Chem_Detail',fld:'vTFBR_SCHEME_CHEM_DETAIL',pic:''},{av:'AV38TFBR_Scheme_Chem_Detail_Sel',fld:'vTFBR_SCHEME_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_scheme_chem_cycle_Activeeventkey',ctrl:'DDO_BR_SCHEME_CHEM_CYCLE',prop:'ActiveEventKey'},{av:'Ddo_br_scheme_chem_cycle_Filteredtext_get',ctrl:'DDO_BR_SCHEME_CHEM_CYCLE',prop:'FilteredText_get'},{av:'Ddo_br_scheme_chem_cycle_Filteredtextto_get',ctrl:'DDO_BR_SCHEME_CHEM_CYCLE',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_SCHEME_CHEM_CYCLE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_scheme_chem_cycle_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_CYCLE',prop:'SortedStatus'},{av:'AV33TFBR_Scheme_Chem_Cycle',fld:'vTFBR_SCHEME_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV34TFBR_Scheme_Chem_Cycle_To',fld:'vTFBR_SCHEME_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'Ddo_br_schemeid_Sortedstatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_scheme_chem_regimens_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'Ddo_br_scheme_therapy_line_Sortedstatus',ctrl:'DDO_BR_SCHEME_THERAPY_LINE',prop:'SortedStatus'},{av:'Ddo_br_scheme_chem_detail_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_DETAIL',prop:'SortedStatus'},{av:'AV16BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV28BR_Scheme_Therapy_LineTitleFilterData',fld:'vBR_SCHEME_THERAPY_LINETITLEFILTERDATA',pic:''},{av:'AV32BR_Scheme_Chem_CycleTitleFilterData',fld:'vBR_SCHEME_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV36BR_Scheme_Chem_DetailTitleFilterData',fld:'vBR_SCHEME_CHEM_DETAILTITLEFILTERDATA',pic:''},{av:'edtBR_SchemeID_Titleformat',ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'edtBR_SchemeID_Title',ctrl:'BR_SCHEMEID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Scheme_Therapy_Line_Titleformat',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Titleformat'},{av:'edtBR_Scheme_Therapy_Line_Title',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Title'},{av:'edtBR_Scheme_Chem_Cycle_Titleformat',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Cycle_Title',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Title'},{av:'edtBR_Scheme_Chem_Detail_Titleformat',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Detail_Title',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_SCHEME_CHEM_DETAIL.ONOPTIONCLICKED","{handler:'E186E2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_SchemeID',fld:'vTFBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_SchemeID_To',fld:'vTFBR_SCHEMEID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Scheme_Chem_Regimens',fld:'vTFBR_SCHEME_CHEM_REGIMENS',pic:''},{av:'AV26TFBR_Scheme_Chem_Regimens_Sel',fld:'vTFBR_SCHEME_CHEM_REGIMENS_SEL',pic:''},{av:'AV29TFBR_Scheme_Therapy_Line',fld:'vTFBR_SCHEME_THERAPY_LINE',pic:''},{av:'AV30TFBR_Scheme_Therapy_Line_Sel',fld:'vTFBR_SCHEME_THERAPY_LINE_SEL',pic:''},{av:'AV33TFBR_Scheme_Chem_Cycle',fld:'vTFBR_SCHEME_CHEM_CYCLE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV34TFBR_Scheme_Chem_Cycle_To',fld:'vTFBR_SCHEME_CHEM_CYCLE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV37TFBR_Scheme_Chem_Detail',fld:'vTFBR_SCHEME_CHEM_DETAIL',pic:''},{av:'AV38TFBR_Scheme_Chem_Detail_Sel',fld:'vTFBR_SCHEME_CHEM_DETAIL_SEL',pic:''},{av:'AV19ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_THERAPY_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_scheme_chem_detail_Activeeventkey',ctrl:'DDO_BR_SCHEME_CHEM_DETAIL',prop:'ActiveEventKey'},{av:'Ddo_br_scheme_chem_detail_Filteredtext_get',ctrl:'DDO_BR_SCHEME_CHEM_DETAIL',prop:'FilteredText_get'},{av:'Ddo_br_scheme_chem_detail_Selectedvalue_get',ctrl:'DDO_BR_SCHEME_CHEM_DETAIL',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_SCHEME_CHEM_DETAIL.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_scheme_chem_detail_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_DETAIL',prop:'SortedStatus'},{av:'AV37TFBR_Scheme_Chem_Detail',fld:'vTFBR_SCHEME_CHEM_DETAIL',pic:''},{av:'AV38TFBR_Scheme_Chem_Detail_Sel',fld:'vTFBR_SCHEME_CHEM_DETAIL_SEL',pic:''},{av:'Ddo_br_schemeid_Sortedstatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_scheme_chem_regimens_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'Ddo_br_scheme_therapy_line_Sortedstatus',ctrl:'DDO_BR_SCHEME_THERAPY_LINE',prop:'SortedStatus'},{av:'Ddo_br_scheme_chem_cycle_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_CYCLE',prop:'SortedStatus'},{av:'AV16BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV28BR_Scheme_Therapy_LineTitleFilterData',fld:'vBR_SCHEME_THERAPY_LINETITLEFILTERDATA',pic:''},{av:'AV32BR_Scheme_Chem_CycleTitleFilterData',fld:'vBR_SCHEME_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV36BR_Scheme_Chem_DetailTitleFilterData',fld:'vBR_SCHEME_CHEM_DETAILTITLEFILTERDATA',pic:''},{av:'edtBR_SchemeID_Titleformat',ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'edtBR_SchemeID_Title',ctrl:'BR_SCHEMEID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Scheme_Therapy_Line_Titleformat',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Titleformat'},{av:'edtBR_Scheme_Therapy_Line_Title',ctrl:'BR_SCHEME_THERAPY_LINE',prop:'Title'},{av:'edtBR_Scheme_Chem_Cycle_Titleformat',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Cycle_Title',ctrl:'BR_SCHEME_CHEM_CYCLE',prop:'Title'},{av:'edtBR_Scheme_Chem_Detail_Titleformat',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Detail_Title',ctrl:'BR_SCHEME_CHEM_DETAIL',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E226E2',iparms:[{av:'A327BR_SchemeID',fld:'BR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV45Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'},{av:'AV46Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV48Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'},{av:'edtBR_Scheme_Chem_Regimens_Link',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E196E2',iparms:[{av:'A327BR_SchemeID',fld:'BR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("'DOINSERT'",",oparms:[]}");
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
         Ddo_br_schemeid_Activeeventkey = "";
         Ddo_br_schemeid_Filteredtext_get = "";
         Ddo_br_schemeid_Filteredtextto_get = "";
         Ddo_br_encounterid_Activeeventkey = "";
         Ddo_br_encounterid_Filteredtext_get = "";
         Ddo_br_encounterid_Filteredtextto_get = "";
         Ddo_br_scheme_chem_regimens_Activeeventkey = "";
         Ddo_br_scheme_chem_regimens_Filteredtext_get = "";
         Ddo_br_scheme_chem_regimens_Selectedvalue_get = "";
         Ddo_br_scheme_therapy_line_Activeeventkey = "";
         Ddo_br_scheme_therapy_line_Filteredtext_get = "";
         Ddo_br_scheme_therapy_line_Selectedvalue_get = "";
         Ddo_br_scheme_chem_cycle_Activeeventkey = "";
         Ddo_br_scheme_chem_cycle_Filteredtext_get = "";
         Ddo_br_scheme_chem_cycle_Filteredtextto_get = "";
         Ddo_br_scheme_chem_detail_Activeeventkey = "";
         Ddo_br_scheme_chem_detail_Filteredtext_get = "";
         Ddo_br_scheme_chem_detail_Selectedvalue_get = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV25TFBR_Scheme_Chem_Regimens = "";
         AV26TFBR_Scheme_Chem_Regimens_Sel = "";
         AV29TFBR_Scheme_Therapy_Line = "";
         AV30TFBR_Scheme_Therapy_Line_Sel = "";
         AV37TFBR_Scheme_Chem_Detail = "";
         AV38TFBR_Scheme_Chem_Detail_Sel = "";
         AV19ddo_BR_SchemeIDTitleControlIdToReplace = "";
         AV23ddo_BR_EncounterIDTitleControlIdToReplace = "";
         AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = "";
         AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace = "";
         AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace = "";
         AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace = "";
         AV68Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV40DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV16BR_SchemeIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_Scheme_Chem_RegimensTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28BR_Scheme_Therapy_LineTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32BR_Scheme_Chem_CycleTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV36BR_Scheme_Chem_DetailTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_schemeid_Filteredtext_set = "";
         Ddo_br_schemeid_Filteredtextto_set = "";
         Ddo_br_schemeid_Sortedstatus = "";
         Ddo_br_encounterid_Filteredtext_set = "";
         Ddo_br_encounterid_Filteredtextto_set = "";
         Ddo_br_encounterid_Sortedstatus = "";
         Ddo_br_scheme_chem_regimens_Filteredtext_set = "";
         Ddo_br_scheme_chem_regimens_Selectedvalue_set = "";
         Ddo_br_scheme_chem_regimens_Sortedstatus = "";
         Ddo_br_scheme_therapy_line_Filteredtext_set = "";
         Ddo_br_scheme_therapy_line_Selectedvalue_set = "";
         Ddo_br_scheme_therapy_line_Sortedstatus = "";
         Ddo_br_scheme_chem_cycle_Filteredtext_set = "";
         Ddo_br_scheme_chem_cycle_Filteredtextto_set = "";
         Ddo_br_scheme_chem_cycle_Sortedstatus = "";
         Ddo_br_scheme_chem_detail_Filteredtext_set = "";
         Ddo_br_scheme_chem_detail_Selectedvalue_set = "";
         Ddo_br_scheme_chem_detail_Sortedstatus = "";
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
         AV45Display = "";
         AV46Update = "";
         AV48Delete = "";
         A328BR_Scheme_Chem_Regimens = "";
         A329BR_Scheme_Therapy_Line = "";
         A331BR_Scheme_Chem_Detail = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_schemeid = new GXUserControl();
         ucDdo_br_encounterid = new GXUserControl();
         ucDdo_br_scheme_chem_regimens = new GXUserControl();
         ucDdo_br_scheme_therapy_line = new GXUserControl();
         ucDdo_br_scheme_chem_cycle = new GXUserControl();
         ucDdo_br_scheme_chem_detail = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV65Display_GXI = "";
         AV66Update_GXI = "";
         AV67Delete_GXI = "";
         scmdbuf = "";
         lV57BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens = "";
         lV59BR_SchemeWWDS_7_Tfbr_scheme_therapy_line = "";
         lV63BR_SchemeWWDS_11_Tfbr_scheme_chem_detail = "";
         AV58BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel = "";
         AV57BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens = "";
         AV60BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel = "";
         AV59BR_SchemeWWDS_7_Tfbr_scheme_therapy_line = "";
         AV64BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel = "";
         AV63BR_SchemeWWDS_11_Tfbr_scheme_chem_detail = "";
         H006E2_A331BR_Scheme_Chem_Detail = new String[] {""} ;
         H006E2_n331BR_Scheme_Chem_Detail = new bool[] {false} ;
         H006E2_A330BR_Scheme_Chem_Cycle = new decimal[1] ;
         H006E2_n330BR_Scheme_Chem_Cycle = new bool[] {false} ;
         H006E2_A329BR_Scheme_Therapy_Line = new String[] {""} ;
         H006E2_n329BR_Scheme_Therapy_Line = new bool[] {false} ;
         H006E2_A328BR_Scheme_Chem_Regimens = new String[] {""} ;
         H006E2_n328BR_Scheme_Chem_Regimens = new bool[] {false} ;
         H006E2_A19BR_EncounterID = new long[1] ;
         H006E2_A327BR_SchemeID = new long[1] ;
         H006E3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_schemeww__default(),
            new Object[][] {
                new Object[] {
               H006E2_A331BR_Scheme_Chem_Detail, H006E2_n331BR_Scheme_Chem_Detail, H006E2_A330BR_Scheme_Chem_Cycle, H006E2_n330BR_Scheme_Chem_Cycle, H006E2_A329BR_Scheme_Therapy_Line, H006E2_n329BR_Scheme_Therapy_Line, H006E2_A328BR_Scheme_Chem_Regimens, H006E2_n328BR_Scheme_Chem_Regimens, H006E2_A19BR_EncounterID, H006E2_A327BR_SchemeID
               }
               , new Object[] {
               H006E3_AGRID_nRecordCount
               }
            }
         );
         AV68Pgmname = "BR_SchemeWW";
         /* GeneXus formulas. */
         AV68Pgmname = "BR_SchemeWW";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_31 ;
      private short nGXsfl_31_idx=1 ;
      private short GRID_nEOF ;
      private short AV13OrderedBy ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtBR_SchemeID_Titleformat ;
      private short edtBR_EncounterID_Titleformat ;
      private short edtBR_Scheme_Chem_Regimens_Titleformat ;
      private short edtBR_Scheme_Therapy_Line_Titleformat ;
      private short edtBR_Scheme_Chem_Cycle_Titleformat ;
      private short edtBR_Scheme_Chem_Detail_Titleformat ;
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
      private int Ddo_br_scheme_chem_regimens_Datalistupdateminimumcharacters ;
      private int Ddo_br_scheme_therapy_line_Datalistupdateminimumcharacters ;
      private int Ddo_br_scheme_chem_detail_Datalistupdateminimumcharacters ;
      private int bttBtninsert_Visible ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavUpdate_Visible ;
      private int edtavDelete_Visible ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_br_schemeidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_scheme_therapy_linetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_scheme_chem_cycletitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_scheme_chem_detailtitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfbr_schemeid_Visible ;
      private int edtavTfbr_schemeid_to_Visible ;
      private int edtavTfbr_encounterid_Visible ;
      private int edtavTfbr_encounterid_to_Visible ;
      private int edtavTfbr_scheme_chem_regimens_Visible ;
      private int edtavTfbr_scheme_chem_regimens_sel_Visible ;
      private int edtavTfbr_scheme_therapy_line_Visible ;
      private int edtavTfbr_scheme_therapy_line_sel_Visible ;
      private int edtavTfbr_scheme_chem_cycle_Visible ;
      private int edtavTfbr_scheme_chem_cycle_to_Visible ;
      private int edtavTfbr_scheme_chem_detail_Visible ;
      private int edtavTfbr_scheme_chem_detail_sel_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV41PageToGo ;
      private int AV69GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV17TFBR_SchemeID ;
      private long AV18TFBR_SchemeID_To ;
      private long AV21TFBR_EncounterID ;
      private long AV22TFBR_EncounterID_To ;
      private long AV42GridCurrentPage ;
      private long AV44GridRecordCount ;
      private long AV43GridPageSize ;
      private long A327BR_SchemeID ;
      private long A19BR_EncounterID ;
      private long GRID_nCurrentRecord ;
      private long AV53BR_SchemeWWDS_1_Tfbr_schemeid ;
      private long AV54BR_SchemeWWDS_2_Tfbr_schemeid_to ;
      private long AV55BR_SchemeWWDS_3_Tfbr_encounterid ;
      private long AV56BR_SchemeWWDS_4_Tfbr_encounterid_to ;
      private long GRID_nRecordCount ;
      private decimal AV33TFBR_Scheme_Chem_Cycle ;
      private decimal AV34TFBR_Scheme_Chem_Cycle_To ;
      private decimal A330BR_Scheme_Chem_Cycle ;
      private decimal AV61BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle ;
      private decimal AV62BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_schemeid_Activeeventkey ;
      private String Ddo_br_schemeid_Filteredtext_get ;
      private String Ddo_br_schemeid_Filteredtextto_get ;
      private String Ddo_br_encounterid_Activeeventkey ;
      private String Ddo_br_encounterid_Filteredtext_get ;
      private String Ddo_br_encounterid_Filteredtextto_get ;
      private String Ddo_br_scheme_chem_regimens_Activeeventkey ;
      private String Ddo_br_scheme_chem_regimens_Filteredtext_get ;
      private String Ddo_br_scheme_chem_regimens_Selectedvalue_get ;
      private String Ddo_br_scheme_therapy_line_Activeeventkey ;
      private String Ddo_br_scheme_therapy_line_Filteredtext_get ;
      private String Ddo_br_scheme_therapy_line_Selectedvalue_get ;
      private String Ddo_br_scheme_chem_cycle_Activeeventkey ;
      private String Ddo_br_scheme_chem_cycle_Filteredtext_get ;
      private String Ddo_br_scheme_chem_cycle_Filteredtextto_get ;
      private String Ddo_br_scheme_chem_detail_Activeeventkey ;
      private String Ddo_br_scheme_chem_detail_Filteredtext_get ;
      private String Ddo_br_scheme_chem_detail_Selectedvalue_get ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_31_idx="0001" ;
      private String AV68Pgmname ;
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
      private String Ddo_br_schemeid_Caption ;
      private String Ddo_br_schemeid_Tooltip ;
      private String Ddo_br_schemeid_Cls ;
      private String Ddo_br_schemeid_Filteredtext_set ;
      private String Ddo_br_schemeid_Filteredtextto_set ;
      private String Ddo_br_schemeid_Dropdownoptionstype ;
      private String Ddo_br_schemeid_Titlecontrolidtoreplace ;
      private String Ddo_br_schemeid_Sortedstatus ;
      private String Ddo_br_schemeid_Filtertype ;
      private String Ddo_br_schemeid_Sortasc ;
      private String Ddo_br_schemeid_Sortdsc ;
      private String Ddo_br_schemeid_Cleanfilter ;
      private String Ddo_br_schemeid_Rangefilterfrom ;
      private String Ddo_br_schemeid_Rangefilterto ;
      private String Ddo_br_schemeid_Searchbuttontext ;
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
      private String Ddo_br_scheme_chem_regimens_Caption ;
      private String Ddo_br_scheme_chem_regimens_Tooltip ;
      private String Ddo_br_scheme_chem_regimens_Cls ;
      private String Ddo_br_scheme_chem_regimens_Filteredtext_set ;
      private String Ddo_br_scheme_chem_regimens_Selectedvalue_set ;
      private String Ddo_br_scheme_chem_regimens_Dropdownoptionstype ;
      private String Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace ;
      private String Ddo_br_scheme_chem_regimens_Sortedstatus ;
      private String Ddo_br_scheme_chem_regimens_Filtertype ;
      private String Ddo_br_scheme_chem_regimens_Datalisttype ;
      private String Ddo_br_scheme_chem_regimens_Datalistproc ;
      private String Ddo_br_scheme_chem_regimens_Sortasc ;
      private String Ddo_br_scheme_chem_regimens_Sortdsc ;
      private String Ddo_br_scheme_chem_regimens_Loadingdata ;
      private String Ddo_br_scheme_chem_regimens_Cleanfilter ;
      private String Ddo_br_scheme_chem_regimens_Noresultsfound ;
      private String Ddo_br_scheme_chem_regimens_Searchbuttontext ;
      private String Ddo_br_scheme_therapy_line_Caption ;
      private String Ddo_br_scheme_therapy_line_Tooltip ;
      private String Ddo_br_scheme_therapy_line_Cls ;
      private String Ddo_br_scheme_therapy_line_Filteredtext_set ;
      private String Ddo_br_scheme_therapy_line_Selectedvalue_set ;
      private String Ddo_br_scheme_therapy_line_Dropdownoptionstype ;
      private String Ddo_br_scheme_therapy_line_Titlecontrolidtoreplace ;
      private String Ddo_br_scheme_therapy_line_Sortedstatus ;
      private String Ddo_br_scheme_therapy_line_Filtertype ;
      private String Ddo_br_scheme_therapy_line_Datalisttype ;
      private String Ddo_br_scheme_therapy_line_Datalistproc ;
      private String Ddo_br_scheme_therapy_line_Sortasc ;
      private String Ddo_br_scheme_therapy_line_Sortdsc ;
      private String Ddo_br_scheme_therapy_line_Loadingdata ;
      private String Ddo_br_scheme_therapy_line_Cleanfilter ;
      private String Ddo_br_scheme_therapy_line_Noresultsfound ;
      private String Ddo_br_scheme_therapy_line_Searchbuttontext ;
      private String Ddo_br_scheme_chem_cycle_Caption ;
      private String Ddo_br_scheme_chem_cycle_Tooltip ;
      private String Ddo_br_scheme_chem_cycle_Cls ;
      private String Ddo_br_scheme_chem_cycle_Filteredtext_set ;
      private String Ddo_br_scheme_chem_cycle_Filteredtextto_set ;
      private String Ddo_br_scheme_chem_cycle_Dropdownoptionstype ;
      private String Ddo_br_scheme_chem_cycle_Titlecontrolidtoreplace ;
      private String Ddo_br_scheme_chem_cycle_Sortedstatus ;
      private String Ddo_br_scheme_chem_cycle_Filtertype ;
      private String Ddo_br_scheme_chem_cycle_Sortasc ;
      private String Ddo_br_scheme_chem_cycle_Sortdsc ;
      private String Ddo_br_scheme_chem_cycle_Cleanfilter ;
      private String Ddo_br_scheme_chem_cycle_Rangefilterfrom ;
      private String Ddo_br_scheme_chem_cycle_Rangefilterto ;
      private String Ddo_br_scheme_chem_cycle_Searchbuttontext ;
      private String Ddo_br_scheme_chem_detail_Caption ;
      private String Ddo_br_scheme_chem_detail_Tooltip ;
      private String Ddo_br_scheme_chem_detail_Cls ;
      private String Ddo_br_scheme_chem_detail_Filteredtext_set ;
      private String Ddo_br_scheme_chem_detail_Selectedvalue_set ;
      private String Ddo_br_scheme_chem_detail_Dropdownoptionstype ;
      private String Ddo_br_scheme_chem_detail_Titlecontrolidtoreplace ;
      private String Ddo_br_scheme_chem_detail_Sortedstatus ;
      private String Ddo_br_scheme_chem_detail_Filtertype ;
      private String Ddo_br_scheme_chem_detail_Datalisttype ;
      private String Ddo_br_scheme_chem_detail_Datalistproc ;
      private String Ddo_br_scheme_chem_detail_Sortasc ;
      private String Ddo_br_scheme_chem_detail_Sortdsc ;
      private String Ddo_br_scheme_chem_detail_Loadingdata ;
      private String Ddo_br_scheme_chem_detail_Cleanfilter ;
      private String Ddo_br_scheme_chem_detail_Noresultsfound ;
      private String Ddo_br_scheme_chem_detail_Searchbuttontext ;
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
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtBR_SchemeID_Title ;
      private String edtBR_EncounterID_Title ;
      private String edtBR_Scheme_Chem_Regimens_Title ;
      private String edtBR_Scheme_Therapy_Line_Title ;
      private String edtBR_Scheme_Chem_Cycle_Title ;
      private String edtBR_Scheme_Chem_Detail_Title ;
      private String subGrid_Header ;
      private String edtavDisplay_Link ;
      private String edtavDisplay_Tooltiptext ;
      private String edtavUpdate_Link ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavDelete_Link ;
      private String edtavDelete_Tooltiptext ;
      private String edtBR_Scheme_Chem_Regimens_Link ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_schemeid_Internalname ;
      private String edtavDdo_br_schemeidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounterid_Internalname ;
      private String edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_scheme_chem_regimens_Internalname ;
      private String edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_scheme_therapy_line_Internalname ;
      private String edtavDdo_br_scheme_therapy_linetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_scheme_chem_cycle_Internalname ;
      private String edtavDdo_br_scheme_chem_cycletitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_scheme_chem_detail_Internalname ;
      private String edtavDdo_br_scheme_chem_detailtitlecontrolidtoreplace_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavTfbr_schemeid_Internalname ;
      private String edtavTfbr_schemeid_Jsonclick ;
      private String edtavTfbr_schemeid_to_Internalname ;
      private String edtavTfbr_schemeid_to_Jsonclick ;
      private String edtavTfbr_encounterid_Internalname ;
      private String edtavTfbr_encounterid_Jsonclick ;
      private String edtavTfbr_encounterid_to_Internalname ;
      private String edtavTfbr_encounterid_to_Jsonclick ;
      private String edtavTfbr_scheme_chem_regimens_Internalname ;
      private String edtavTfbr_scheme_chem_regimens_Jsonclick ;
      private String edtavTfbr_scheme_chem_regimens_sel_Internalname ;
      private String edtavTfbr_scheme_chem_regimens_sel_Jsonclick ;
      private String edtavTfbr_scheme_therapy_line_Internalname ;
      private String edtavTfbr_scheme_therapy_line_Jsonclick ;
      private String edtavTfbr_scheme_therapy_line_sel_Internalname ;
      private String edtavTfbr_scheme_therapy_line_sel_Jsonclick ;
      private String edtavTfbr_scheme_chem_cycle_Internalname ;
      private String edtavTfbr_scheme_chem_cycle_Jsonclick ;
      private String edtavTfbr_scheme_chem_cycle_to_Internalname ;
      private String edtavTfbr_scheme_chem_cycle_to_Jsonclick ;
      private String edtavTfbr_scheme_chem_detail_Internalname ;
      private String edtavTfbr_scheme_chem_detail_sel_Internalname ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDisplay_Internalname ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String edtBR_SchemeID_Internalname ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_Scheme_Chem_Regimens_Internalname ;
      private String edtBR_Scheme_Therapy_Line_Internalname ;
      private String edtBR_Scheme_Chem_Cycle_Internalname ;
      private String edtBR_Scheme_Chem_Detail_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_31_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtBR_SchemeID_Jsonclick ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Scheme_Chem_Regimens_Jsonclick ;
      private String edtBR_Scheme_Therapy_Line_Jsonclick ;
      private String edtBR_Scheme_Chem_Cycle_Jsonclick ;
      private String edtBR_Scheme_Chem_Detail_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV14OrderedDsc ;
      private bool AV47IsAuthorized_Update ;
      private bool AV49IsAuthorized_Delete ;
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
      private bool Ddo_br_schemeid_Includesortasc ;
      private bool Ddo_br_schemeid_Includesortdsc ;
      private bool Ddo_br_schemeid_Includefilter ;
      private bool Ddo_br_schemeid_Filterisrange ;
      private bool Ddo_br_schemeid_Includedatalist ;
      private bool Ddo_br_encounterid_Includesortasc ;
      private bool Ddo_br_encounterid_Includesortdsc ;
      private bool Ddo_br_encounterid_Includefilter ;
      private bool Ddo_br_encounterid_Filterisrange ;
      private bool Ddo_br_encounterid_Includedatalist ;
      private bool Ddo_br_scheme_chem_regimens_Includesortasc ;
      private bool Ddo_br_scheme_chem_regimens_Includesortdsc ;
      private bool Ddo_br_scheme_chem_regimens_Includefilter ;
      private bool Ddo_br_scheme_chem_regimens_Filterisrange ;
      private bool Ddo_br_scheme_chem_regimens_Includedatalist ;
      private bool Ddo_br_scheme_therapy_line_Includesortasc ;
      private bool Ddo_br_scheme_therapy_line_Includesortdsc ;
      private bool Ddo_br_scheme_therapy_line_Includefilter ;
      private bool Ddo_br_scheme_therapy_line_Filterisrange ;
      private bool Ddo_br_scheme_therapy_line_Includedatalist ;
      private bool Ddo_br_scheme_chem_cycle_Includesortasc ;
      private bool Ddo_br_scheme_chem_cycle_Includesortdsc ;
      private bool Ddo_br_scheme_chem_cycle_Includefilter ;
      private bool Ddo_br_scheme_chem_cycle_Filterisrange ;
      private bool Ddo_br_scheme_chem_cycle_Includedatalist ;
      private bool Ddo_br_scheme_chem_detail_Includesortasc ;
      private bool Ddo_br_scheme_chem_detail_Includesortdsc ;
      private bool Ddo_br_scheme_chem_detail_Includefilter ;
      private bool Ddo_br_scheme_chem_detail_Filterisrange ;
      private bool Ddo_br_scheme_chem_detail_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_31_Refreshing=false ;
      private bool n328BR_Scheme_Chem_Regimens ;
      private bool n329BR_Scheme_Therapy_Line ;
      private bool n330BR_Scheme_Chem_Cycle ;
      private bool n331BR_Scheme_Chem_Detail ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV50TempBoolean ;
      private bool GXt_boolean2 ;
      private bool AV45Display_IsBlob ;
      private bool AV46Update_IsBlob ;
      private bool AV48Delete_IsBlob ;
      private String AV25TFBR_Scheme_Chem_Regimens ;
      private String AV26TFBR_Scheme_Chem_Regimens_Sel ;
      private String AV29TFBR_Scheme_Therapy_Line ;
      private String AV30TFBR_Scheme_Therapy_Line_Sel ;
      private String AV37TFBR_Scheme_Chem_Detail ;
      private String AV38TFBR_Scheme_Chem_Detail_Sel ;
      private String AV19ddo_BR_SchemeIDTitleControlIdToReplace ;
      private String AV23ddo_BR_EncounterIDTitleControlIdToReplace ;
      private String AV27ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace ;
      private String AV31ddo_BR_Scheme_Therapy_LineTitleControlIdToReplace ;
      private String AV35ddo_BR_Scheme_Chem_CycleTitleControlIdToReplace ;
      private String AV39ddo_BR_Scheme_Chem_DetailTitleControlIdToReplace ;
      private String A328BR_Scheme_Chem_Regimens ;
      private String A329BR_Scheme_Therapy_Line ;
      private String A331BR_Scheme_Chem_Detail ;
      private String AV65Display_GXI ;
      private String AV66Update_GXI ;
      private String AV67Delete_GXI ;
      private String lV57BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens ;
      private String lV59BR_SchemeWWDS_7_Tfbr_scheme_therapy_line ;
      private String lV63BR_SchemeWWDS_11_Tfbr_scheme_chem_detail ;
      private String AV58BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel ;
      private String AV57BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens ;
      private String AV60BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel ;
      private String AV59BR_SchemeWWDS_7_Tfbr_scheme_therapy_line ;
      private String AV64BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel ;
      private String AV63BR_SchemeWWDS_11_Tfbr_scheme_chem_detail ;
      private String AV45Display ;
      private String AV46Update ;
      private String AV48Delete ;
      private IGxSession AV15Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_schemeid ;
      private GXUserControl ucDdo_br_encounterid ;
      private GXUserControl ucDdo_br_scheme_chem_regimens ;
      private GXUserControl ucDdo_br_scheme_therapy_line ;
      private GXUserControl ucDdo_br_scheme_chem_cycle ;
      private GXUserControl ucDdo_br_scheme_chem_detail ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H006E2_A331BR_Scheme_Chem_Detail ;
      private bool[] H006E2_n331BR_Scheme_Chem_Detail ;
      private decimal[] H006E2_A330BR_Scheme_Chem_Cycle ;
      private bool[] H006E2_n330BR_Scheme_Chem_Cycle ;
      private String[] H006E2_A329BR_Scheme_Therapy_Line ;
      private bool[] H006E2_n329BR_Scheme_Therapy_Line ;
      private String[] H006E2_A328BR_Scheme_Chem_Regimens ;
      private bool[] H006E2_n328BR_Scheme_Chem_Regimens ;
      private long[] H006E2_A19BR_EncounterID ;
      private long[] H006E2_A327BR_SchemeID ;
      private long[] H006E3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV16BR_SchemeIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV20BR_EncounterIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV24BR_Scheme_Chem_RegimensTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV28BR_Scheme_Therapy_LineTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV32BR_Scheme_Chem_CycleTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV36BR_Scheme_Chem_DetailTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV11GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV12GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV40DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class br_schemeww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H006E2( IGxContext context ,
                                             long AV53BR_SchemeWWDS_1_Tfbr_schemeid ,
                                             long AV54BR_SchemeWWDS_2_Tfbr_schemeid_to ,
                                             long AV55BR_SchemeWWDS_3_Tfbr_encounterid ,
                                             long AV56BR_SchemeWWDS_4_Tfbr_encounterid_to ,
                                             String AV58BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel ,
                                             String AV57BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens ,
                                             String AV60BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel ,
                                             String AV59BR_SchemeWWDS_7_Tfbr_scheme_therapy_line ,
                                             decimal AV61BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle ,
                                             decimal AV62BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to ,
                                             String AV64BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel ,
                                             String AV63BR_SchemeWWDS_11_Tfbr_scheme_chem_detail ,
                                             long A327BR_SchemeID ,
                                             long A19BR_EncounterID ,
                                             String A328BR_Scheme_Chem_Regimens ,
                                             String A329BR_Scheme_Therapy_Line ,
                                             decimal A330BR_Scheme_Chem_Cycle ,
                                             String A331BR_Scheme_Chem_Detail ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [15] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [BR_Scheme_Chem_Detail], [BR_Scheme_Chem_Cycle], [BR_Scheme_Therapy_Line], [BR_Scheme_Chem_Regimens], [BR_EncounterID], [BR_SchemeID]";
         sFromString = " FROM [BR_Scheme] WITH (NOLOCK)";
         sOrderString = "";
         if ( ! (0==AV53BR_SchemeWWDS_1_Tfbr_schemeid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_SchemeID] >= @AV53BR_SchemeWWDS_1_Tfbr_schemeid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_SchemeID] >= @AV53BR_SchemeWWDS_1_Tfbr_schemeid)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ! (0==AV54BR_SchemeWWDS_2_Tfbr_schemeid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_SchemeID] <= @AV54BR_SchemeWWDS_2_Tfbr_schemeid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_SchemeID] <= @AV54BR_SchemeWWDS_2_Tfbr_schemeid_to)";
            }
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV55BR_SchemeWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterID] >= @AV55BR_SchemeWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterID] >= @AV55BR_SchemeWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (0==AV56BR_SchemeWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterID] <= @AV56BR_SchemeWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterID] <= @AV56BR_SchemeWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV58BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV57BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Chem_Regimens] like @lV57BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Chem_Regimens] like @lV57BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens)";
            }
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV58BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Chem_Regimens] = @AV58BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Chem_Regimens] = @AV58BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel)";
            }
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59BR_SchemeWWDS_7_Tfbr_scheme_therapy_line)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Therapy_Line] like @lV59BR_SchemeWWDS_7_Tfbr_scheme_therapy_line)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Therapy_Line] like @lV59BR_SchemeWWDS_7_Tfbr_scheme_therapy_line)";
            }
         }
         else
         {
            GXv_int3[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Therapy_Line] = @AV60BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Therapy_Line] = @AV60BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel)";
            }
         }
         else
         {
            GXv_int3[7] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV61BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Chem_Cycle] >= @AV61BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Chem_Cycle] >= @AV61BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle)";
            }
         }
         else
         {
            GXv_int3[8] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV62BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Chem_Cycle] <= @AV62BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Chem_Cycle] <= @AV62BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to)";
            }
         }
         else
         {
            GXv_int3[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV64BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV63BR_SchemeWWDS_11_Tfbr_scheme_chem_detail)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Chem_Detail] like @lV63BR_SchemeWWDS_11_Tfbr_scheme_chem_detail)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Chem_Detail] like @lV63BR_SchemeWWDS_11_Tfbr_scheme_chem_detail)";
            }
         }
         else
         {
            GXv_int3[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV64BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Chem_Detail] = @AV64BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Chem_Detail] = @AV64BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel)";
            }
         }
         else
         {
            GXv_int3[11] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_SchemeID]";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_SchemeID] DESC";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID]";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID] DESC";
         }
         else if ( ( AV13OrderedBy == 3 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Scheme_Chem_Regimens]";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Scheme_Chem_Regimens] DESC";
         }
         else if ( ( AV13OrderedBy == 4 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Scheme_Therapy_Line]";
         }
         else if ( ( AV13OrderedBy == 4 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Scheme_Therapy_Line] DESC";
         }
         else if ( ( AV13OrderedBy == 5 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Scheme_Chem_Cycle]";
         }
         else if ( ( AV13OrderedBy == 5 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Scheme_Chem_Cycle] DESC";
         }
         else if ( ( AV13OrderedBy == 6 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Scheme_Chem_Detail]";
         }
         else if ( ( AV13OrderedBy == 6 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Scheme_Chem_Detail] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [BR_SchemeID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H006E3( IGxContext context ,
                                             long AV53BR_SchemeWWDS_1_Tfbr_schemeid ,
                                             long AV54BR_SchemeWWDS_2_Tfbr_schemeid_to ,
                                             long AV55BR_SchemeWWDS_3_Tfbr_encounterid ,
                                             long AV56BR_SchemeWWDS_4_Tfbr_encounterid_to ,
                                             String AV58BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel ,
                                             String AV57BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens ,
                                             String AV60BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel ,
                                             String AV59BR_SchemeWWDS_7_Tfbr_scheme_therapy_line ,
                                             decimal AV61BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle ,
                                             decimal AV62BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to ,
                                             String AV64BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel ,
                                             String AV63BR_SchemeWWDS_11_Tfbr_scheme_chem_detail ,
                                             long A327BR_SchemeID ,
                                             long A19BR_EncounterID ,
                                             String A328BR_Scheme_Chem_Regimens ,
                                             String A329BR_Scheme_Therapy_Line ,
                                             decimal A330BR_Scheme_Chem_Cycle ,
                                             String A331BR_Scheme_Chem_Detail ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [12] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [BR_Scheme] WITH (NOLOCK)";
         if ( ! (0==AV53BR_SchemeWWDS_1_Tfbr_schemeid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_SchemeID] >= @AV53BR_SchemeWWDS_1_Tfbr_schemeid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_SchemeID] >= @AV53BR_SchemeWWDS_1_Tfbr_schemeid)";
            }
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ! (0==AV54BR_SchemeWWDS_2_Tfbr_schemeid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_SchemeID] <= @AV54BR_SchemeWWDS_2_Tfbr_schemeid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_SchemeID] <= @AV54BR_SchemeWWDS_2_Tfbr_schemeid_to)";
            }
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( ! (0==AV55BR_SchemeWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterID] >= @AV55BR_SchemeWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterID] >= @AV55BR_SchemeWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! (0==AV56BR_SchemeWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterID] <= @AV56BR_SchemeWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterID] <= @AV56BR_SchemeWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV58BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV57BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Chem_Regimens] like @lV57BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Chem_Regimens] like @lV57BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens)";
            }
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV58BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Chem_Regimens] = @AV58BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Chem_Regimens] = @AV58BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel)";
            }
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59BR_SchemeWWDS_7_Tfbr_scheme_therapy_line)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Therapy_Line] like @lV59BR_SchemeWWDS_7_Tfbr_scheme_therapy_line)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Therapy_Line] like @lV59BR_SchemeWWDS_7_Tfbr_scheme_therapy_line)";
            }
         }
         else
         {
            GXv_int5[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Therapy_Line] = @AV60BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Therapy_Line] = @AV60BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel)";
            }
         }
         else
         {
            GXv_int5[7] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV61BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Chem_Cycle] >= @AV61BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Chem_Cycle] >= @AV61BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle)";
            }
         }
         else
         {
            GXv_int5[8] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV62BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Chem_Cycle] <= @AV62BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Chem_Cycle] <= @AV62BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to)";
            }
         }
         else
         {
            GXv_int5[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV64BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV63BR_SchemeWWDS_11_Tfbr_scheme_chem_detail)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Chem_Detail] like @lV63BR_SchemeWWDS_11_Tfbr_scheme_chem_detail)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Chem_Detail] like @lV63BR_SchemeWWDS_11_Tfbr_scheme_chem_detail)";
            }
         }
         else
         {
            GXv_int5[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV64BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Scheme_Chem_Detail] = @AV64BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Scheme_Chem_Detail] = @AV64BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel)";
            }
         }
         else
         {
            GXv_int5[11] = 1;
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
                     return conditional_H006E2(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (decimal)dynConstraints[8] , (decimal)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (long)dynConstraints[12] , (long)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (decimal)dynConstraints[16] , (String)dynConstraints[17] , (short)dynConstraints[18] , (bool)dynConstraints[19] );
               case 1 :
                     return conditional_H006E3(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (decimal)dynConstraints[8] , (decimal)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (long)dynConstraints[12] , (long)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (decimal)dynConstraints[16] , (String)dynConstraints[17] , (short)dynConstraints[18] , (bool)dynConstraints[19] );
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
          Object[] prmH006E2 ;
          prmH006E2 = new Object[] {
          new Object[] {"@AV53BR_SchemeWWDS_1_Tfbr_schemeid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV54BR_SchemeWWDS_2_Tfbr_schemeid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV55BR_SchemeWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV56BR_SchemeWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV57BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV58BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV59BR_SchemeWWDS_7_Tfbr_scheme_therapy_line",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV60BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV61BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV62BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV63BR_SchemeWWDS_11_Tfbr_scheme_chem_detail",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV64BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH006E3 ;
          prmH006E3 = new Object[] {
          new Object[] {"@AV53BR_SchemeWWDS_1_Tfbr_schemeid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV54BR_SchemeWWDS_2_Tfbr_schemeid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV55BR_SchemeWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV56BR_SchemeWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV57BR_SchemeWWDS_5_Tfbr_scheme_chem_regimens",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV58BR_SchemeWWDS_6_Tfbr_scheme_chem_regimens_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV59BR_SchemeWWDS_7_Tfbr_scheme_therapy_line",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV60BR_SchemeWWDS_8_Tfbr_scheme_therapy_line_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV61BR_SchemeWWDS_9_Tfbr_scheme_chem_cycle",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV62BR_SchemeWWDS_10_Tfbr_scheme_chem_cycle_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV63BR_SchemeWWDS_11_Tfbr_scheme_chem_detail",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV64BR_SchemeWWDS_12_Tfbr_scheme_chem_detail_sel",SqlDbType.NVarChar,4000,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H006E2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH006E2,11,0,true,false )
             ,new CursorDef("H006E3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH006E3,1,0,true,false )
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
                ((decimal[]) buf[2])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((long[]) buf[8])[0] = rslt.getLong(5) ;
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
                   stmt.SetParameter(sIdx, (long)parms[15]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[16]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[17]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[18]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[23]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[24]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[25]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[26]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[27]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[28]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[29]);
                }
                return;
             case 1 :
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
                   stmt.SetParameter(sIdx, (long)parms[15]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[20]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[21]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                return;
       }
    }

 }

}
