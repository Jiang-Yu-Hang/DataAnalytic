/*
               File: XT_LogWW
        Description:  系统日志
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:11:47.90
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
   public class xt_logww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public xt_logww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public xt_logww( IGxContext context )
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
         cmbXT_LogPage = new GXCombobox();
         cmbXT_LogTargetOperate = new GXCombobox();
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
               nRC_GXsfl_29 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_29_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_29_idx = GetNextPar( );
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
               AV27XT_LogTargetModule = GetNextPar( );
               AV28tDesrciption = GetNextPar( );
               AV15OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV16OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV32ddo_XT_LogTargetModuleTitleControlIdToReplace = GetNextPar( );
               AV6ddo_XT_LogDescriptionTitleControlIdToReplace = GetNextPar( );
               AV40Pgmname = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV27XT_LogTargetModule, AV28tDesrciption, AV15OrderedBy, AV16OrderedDsc, AV32ddo_XT_LogTargetModuleTitleControlIdToReplace, AV6ddo_XT_LogDescriptionTitleControlIdToReplace, AV40Pgmname) ;
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
         PA4G2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START4G2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202281511481", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("xt_logww.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vXT_LOGTARGETMODULE", AV27XT_LogTargetModule);
         GxWebStd.gx_hidden_field( context, "GXH_vTDESRCIPTION", AV28tDesrciption);
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15OrderedBy), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV16OrderedDsc));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_29", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_29), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV5DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV5DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_LOGTARGETMODULETITLEFILTERDATA", AV29XT_LogTargetModuleTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_LOGTARGETMODULETITLEFILTERDATA", AV29XT_LogTargetModuleTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_LOGDESCRIPTIONTITLEFILTERDATA", AV26XT_LogDescriptionTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_LOGDESCRIPTIONTITLEFILTERDATA", AV26XT_LogDescriptionTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV40Pgmname));
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Width", StringUtil.RTrim( Dvpanel_unnamedtable1_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Cls", StringUtil.RTrim( Dvpanel_unnamedtable1_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Title", StringUtil.RTrim( Dvpanel_unnamedtable1_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Collapsible", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Collapsed", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Autowidth", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Autoheight", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Iconposition", StringUtil.RTrim( Dvpanel_unnamedtable1_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Autoscroll", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Autoscroll));
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
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETMODULE_Caption", StringUtil.RTrim( Ddo_xt_logtargetmodule_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETMODULE_Tooltip", StringUtil.RTrim( Ddo_xt_logtargetmodule_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETMODULE_Cls", StringUtil.RTrim( Ddo_xt_logtargetmodule_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETMODULE_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_logtargetmodule_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETMODULE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_logtargetmodule_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETMODULE_Includesortasc", StringUtil.BoolToStr( Ddo_xt_logtargetmodule_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETMODULE_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_logtargetmodule_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETMODULE_Sortedstatus", StringUtil.RTrim( Ddo_xt_logtargetmodule_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETMODULE_Includefilter", StringUtil.BoolToStr( Ddo_xt_logtargetmodule_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETMODULE_Includedatalist", StringUtil.BoolToStr( Ddo_xt_logtargetmodule_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETMODULE_Sortasc", StringUtil.RTrim( Ddo_xt_logtargetmodule_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETMODULE_Sortdsc", StringUtil.RTrim( Ddo_xt_logtargetmodule_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETMODULE_Searchbuttontext", StringUtil.RTrim( Ddo_xt_logtargetmodule_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGDESCRIPTION_Caption", StringUtil.RTrim( Ddo_xt_logdescription_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGDESCRIPTION_Tooltip", StringUtil.RTrim( Ddo_xt_logdescription_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGDESCRIPTION_Cls", StringUtil.RTrim( Ddo_xt_logdescription_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGDESCRIPTION_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_logdescription_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGDESCRIPTION_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_logdescription_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGDESCRIPTION_Includesortasc", StringUtil.BoolToStr( Ddo_xt_logdescription_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGDESCRIPTION_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_logdescription_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGDESCRIPTION_Sortedstatus", StringUtil.RTrim( Ddo_xt_logdescription_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGDESCRIPTION_Includefilter", StringUtil.BoolToStr( Ddo_xt_logdescription_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGDESCRIPTION_Includedatalist", StringUtil.BoolToStr( Ddo_xt_logdescription_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGDESCRIPTION_Sortasc", StringUtil.RTrim( Ddo_xt_logdescription_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGDESCRIPTION_Sortdsc", StringUtil.RTrim( Ddo_xt_logdescription_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGDESCRIPTION_Searchbuttontext", StringUtil.RTrim( Ddo_xt_logdescription_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETMODULE_Activeeventkey", StringUtil.RTrim( Ddo_xt_logtargetmodule_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGDESCRIPTION_Activeeventkey", StringUtil.RTrim( Ddo_xt_logdescription_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETMODULE_Activeeventkey", StringUtil.RTrim( Ddo_xt_logtargetmodule_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGDESCRIPTION_Activeeventkey", StringUtil.RTrim( Ddo_xt_logdescription_Activeeventkey));
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
            WE4G2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT4G2( ) ;
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
         return formatLink("xt_logww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "XT_LogWW" ;
      }

      public override String GetPgmdesc( )
      {
         return " 系统日志" ;
      }

      protected void WB4G0( )
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
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "TableMain", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_unnamedtable1_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDvpanel_unnamedtable1.SetProperty("Width", Dvpanel_unnamedtable1_Width);
            ucDvpanel_unnamedtable1.SetProperty("AutoWidth", Dvpanel_unnamedtable1_Autowidth);
            ucDvpanel_unnamedtable1.SetProperty("AutoHeight", Dvpanel_unnamedtable1_Autoheight);
            ucDvpanel_unnamedtable1.SetProperty("Cls", Dvpanel_unnamedtable1_Cls);
            ucDvpanel_unnamedtable1.SetProperty("Title", Dvpanel_unnamedtable1_Title);
            ucDvpanel_unnamedtable1.SetProperty("Collapsible", Dvpanel_unnamedtable1_Collapsible);
            ucDvpanel_unnamedtable1.SetProperty("Collapsed", Dvpanel_unnamedtable1_Collapsed);
            ucDvpanel_unnamedtable1.SetProperty("ShowCollapseIcon", Dvpanel_unnamedtable1_Showcollapseicon);
            ucDvpanel_unnamedtable1.SetProperty("IconPosition", Dvpanel_unnamedtable1_Iconposition);
            ucDvpanel_unnamedtable1.SetProperty("AutoScroll", Dvpanel_unnamedtable1_Autoscroll);
            ucDvpanel_unnamedtable1.Render(context, "dvelop.gxbootstrap.panel", Dvpanel_unnamedtable1_Internalname, "DVPANEL_UNNAMEDTABLE1Container");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_UNNAMEDTABLE1Container"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_unnamedtable1_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtable1_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavXt_logtargetmodule_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavXt_logtargetmodule_Internalname, "操作模块", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_29_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavXt_logtargetmodule_Internalname, AV27XT_LogTargetModule, StringUtil.RTrim( context.localUtil.Format( AV27XT_LogTargetModule, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,19);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavXt_logtargetmodule_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavXt_logtargetmodule_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_LogWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavTdesrciption_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavTdesrciption_Internalname, "日志描述", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'" + sGXsfl_29_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTdesrciption_Internalname, AV28tDesrciption, StringUtil.RTrim( context.localUtil.Format( AV28tDesrciption, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,23);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTdesrciption_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavTdesrciption_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_LogWW.htm");
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"29\">") ;
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "系统日志主键") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "操作人") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "操作时间") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "操作页面") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "操作的按钮") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "日志类型") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "日志分院名称") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "日志操作对象") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "日志操作子对象") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtXT_LogTargetModule_Titleformat == 0 )
               {
                  context.SendWebValue( edtXT_LogTargetModule_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtXT_LogTargetModule_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "日志操作模块子模块") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "日志操作对象动作") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtXT_LogDescription_Titleformat == 0 )
               {
                  context.SendWebValue( edtXT_LogDescription_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtXT_LogDescription_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV7Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A173XT_LogID), 18, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A214XT_LogUserID), 18, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A174XT_LogSecUserName);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.TToC( A220XT_LogTime, 10, 8, 0, 0, "/", ":", " "));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A176XT_LogPage);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A177XT_LogButtonName);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A213XT_LogType);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A215XT_LogProviderID), 18, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A219XT_LogProviderName);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A216XT_LogTarget);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A223XT_LogSonTarget);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A217XT_LogTargetModule);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtXT_LogTargetModule_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtXT_LogTargetModule_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A222XT_LogTargetSonModule);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A218XT_LogTargetOperate);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A221XT_LogDescription);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtXT_LogDescription_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtXT_LogDescription_Titleformat), 4, 0, ".", "")));
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
         if ( wbEnd == 29 )
         {
            wbEnd = 0;
            nRC_GXsfl_29 = (short)(nGXsfl_29_idx-1);
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV8GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV10GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV9GridPageSize);
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
            ucDdo_xt_logtargetmodule.SetProperty("Caption", Ddo_xt_logtargetmodule_Caption);
            ucDdo_xt_logtargetmodule.SetProperty("Tooltip", Ddo_xt_logtargetmodule_Tooltip);
            ucDdo_xt_logtargetmodule.SetProperty("Cls", Ddo_xt_logtargetmodule_Cls);
            ucDdo_xt_logtargetmodule.SetProperty("DropDownOptionsType", Ddo_xt_logtargetmodule_Dropdownoptionstype);
            ucDdo_xt_logtargetmodule.SetProperty("IncludeSortASC", Ddo_xt_logtargetmodule_Includesortasc);
            ucDdo_xt_logtargetmodule.SetProperty("IncludeSortDSC", Ddo_xt_logtargetmodule_Includesortdsc);
            ucDdo_xt_logtargetmodule.SetProperty("IncludeFilter", Ddo_xt_logtargetmodule_Includefilter);
            ucDdo_xt_logtargetmodule.SetProperty("IncludeDataList", Ddo_xt_logtargetmodule_Includedatalist);
            ucDdo_xt_logtargetmodule.SetProperty("SortASC", Ddo_xt_logtargetmodule_Sortasc);
            ucDdo_xt_logtargetmodule.SetProperty("SortDSC", Ddo_xt_logtargetmodule_Sortdsc);
            ucDdo_xt_logtargetmodule.SetProperty("SearchButtonText", Ddo_xt_logtargetmodule_Searchbuttontext);
            ucDdo_xt_logtargetmodule.SetProperty("DropDownOptionsTitleSettingsIcons", AV5DDO_TitleSettingsIcons);
            ucDdo_xt_logtargetmodule.SetProperty("DropDownOptionsData", AV29XT_LogTargetModuleTitleFilterData);
            ucDdo_xt_logtargetmodule.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_logtargetmodule_Internalname, "DDO_XT_LOGTARGETMODULEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_29_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_logtargetmoduletitlecontrolidtoreplace_Internalname, AV32ddo_XT_LogTargetModuleTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", 0, edtavDdo_xt_logtargetmoduletitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_LogWW.htm");
            /* User Defined Control */
            ucDdo_xt_logdescription.SetProperty("Caption", Ddo_xt_logdescription_Caption);
            ucDdo_xt_logdescription.SetProperty("Tooltip", Ddo_xt_logdescription_Tooltip);
            ucDdo_xt_logdescription.SetProperty("Cls", Ddo_xt_logdescription_Cls);
            ucDdo_xt_logdescription.SetProperty("DropDownOptionsType", Ddo_xt_logdescription_Dropdownoptionstype);
            ucDdo_xt_logdescription.SetProperty("IncludeSortASC", Ddo_xt_logdescription_Includesortasc);
            ucDdo_xt_logdescription.SetProperty("IncludeSortDSC", Ddo_xt_logdescription_Includesortdsc);
            ucDdo_xt_logdescription.SetProperty("IncludeFilter", Ddo_xt_logdescription_Includefilter);
            ucDdo_xt_logdescription.SetProperty("IncludeDataList", Ddo_xt_logdescription_Includedatalist);
            ucDdo_xt_logdescription.SetProperty("SortASC", Ddo_xt_logdescription_Sortasc);
            ucDdo_xt_logdescription.SetProperty("SortDSC", Ddo_xt_logdescription_Sortdsc);
            ucDdo_xt_logdescription.SetProperty("SearchButtonText", Ddo_xt_logdescription_Searchbuttontext);
            ucDdo_xt_logdescription.SetProperty("DropDownOptionsTitleSettingsIcons", AV5DDO_TitleSettingsIcons);
            ucDdo_xt_logdescription.SetProperty("DropDownOptionsData", AV26XT_LogDescriptionTitleFilterData);
            ucDdo_xt_logdescription.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_logdescription_Internalname, "DDO_XT_LOGDESCRIPTIONContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_29_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_logdescriptiontitlecontrolidtoreplace_Internalname, AV6ddo_XT_LogDescriptionTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", 0, edtavDdo_xt_logdescriptiontitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_LogWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'" + sGXsfl_29_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV15OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_XT_LogWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'" + sGXsfl_29_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV16OrderedDsc), StringUtil.BoolToStr( AV16OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_XT_LogWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 29 )
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

      protected void START4G2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", " 系统日志", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP4G0( ) ;
      }

      protected void WS4G2( )
      {
         START4G2( ) ;
         EVT4G2( ) ;
      }

      protected void EVT4G2( )
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
                              E114G2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E124G2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_XT_LOGTARGETMODULE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E134G2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_XT_LOGDESCRIPTION.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E144G2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VTDESRCIPTION.CONTROLVALUECHANGING") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E154G2 ();
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
                              nGXsfl_29_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_29_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_29_idx), 4, 0)), 4, "0");
                              SubsflControlProps_292( ) ;
                              AV7Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV7Display)) ? AV39Display_GXI : context.convertURL( context.PathToRelativeUrl( AV7Display))), !bGXsfl_29_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV7Display), true);
                              A173XT_LogID = (long)(context.localUtil.CToN( cgiGet( edtXT_LogID_Internalname), ".", ","));
                              A214XT_LogUserID = (long)(context.localUtil.CToN( cgiGet( edtXT_LogUserID_Internalname), ".", ","));
                              n214XT_LogUserID = false;
                              A174XT_LogSecUserName = cgiGet( edtXT_LogSecUserName_Internalname);
                              n174XT_LogSecUserName = false;
                              A220XT_LogTime = context.localUtil.CToT( cgiGet( edtXT_LogTime_Internalname), 0);
                              n220XT_LogTime = false;
                              cmbXT_LogPage.Name = cmbXT_LogPage_Internalname;
                              cmbXT_LogPage.CurrentValue = cgiGet( cmbXT_LogPage_Internalname);
                              A176XT_LogPage = cgiGet( cmbXT_LogPage_Internalname);
                              n176XT_LogPage = false;
                              A177XT_LogButtonName = cgiGet( edtXT_LogButtonName_Internalname);
                              n177XT_LogButtonName = false;
                              A213XT_LogType = cgiGet( edtXT_LogType_Internalname);
                              n213XT_LogType = false;
                              A215XT_LogProviderID = (long)(context.localUtil.CToN( cgiGet( edtXT_LogProviderID_Internalname), ".", ","));
                              n215XT_LogProviderID = false;
                              A219XT_LogProviderName = cgiGet( edtXT_LogProviderName_Internalname);
                              n219XT_LogProviderName = false;
                              A216XT_LogTarget = cgiGet( edtXT_LogTarget_Internalname);
                              n216XT_LogTarget = false;
                              A223XT_LogSonTarget = cgiGet( edtXT_LogSonTarget_Internalname);
                              n223XT_LogSonTarget = false;
                              A217XT_LogTargetModule = cgiGet( edtXT_LogTargetModule_Internalname);
                              n217XT_LogTargetModule = false;
                              A222XT_LogTargetSonModule = cgiGet( edtXT_LogTargetSonModule_Internalname);
                              n222XT_LogTargetSonModule = false;
                              cmbXT_LogTargetOperate.Name = cmbXT_LogTargetOperate_Internalname;
                              cmbXT_LogTargetOperate.CurrentValue = cgiGet( cmbXT_LogTargetOperate_Internalname);
                              A218XT_LogTargetOperate = cgiGet( cmbXT_LogTargetOperate_Internalname);
                              n218XT_LogTargetOperate = false;
                              A221XT_LogDescription = cgiGet( edtXT_LogDescription_Internalname);
                              n221XT_LogDescription = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E164G2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E174G2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E184G2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Xt_logtargetmodule Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vXT_LOGTARGETMODULE"), AV27XT_LogTargetModule) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tdesrciption Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTDESRCIPTION"), AV28tDesrciption) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Orderedby Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV15OrderedBy )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ordereddsc Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV16OrderedDsc )
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

      protected void WE4G2( )
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

      protected void PA4G2( )
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
               GX_FocusControl = edtavXt_logtargetmodule_Internalname;
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
         SubsflControlProps_292( ) ;
         while ( nGXsfl_29_idx <= nRC_GXsfl_29 )
         {
            sendrow_292( ) ;
            nGXsfl_29_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_29_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_29_idx+1));
            sGXsfl_29_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_29_idx), 4, 0)), 4, "0");
            SubsflControlProps_292( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       String AV27XT_LogTargetModule ,
                                       String AV28tDesrciption ,
                                       short AV15OrderedBy ,
                                       bool AV16OrderedDsc ,
                                       String AV32ddo_XT_LogTargetModuleTitleControlIdToReplace ,
                                       String AV6ddo_XT_LogDescriptionTitleControlIdToReplace ,
                                       String AV40Pgmname )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF4G2( ) ;
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
         RF4G2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV40Pgmname = "XT_LogWW";
         context.Gx_err = 0;
      }

      protected void RF4G2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 29;
         /* Execute user event: Refresh */
         E174G2 ();
         nGXsfl_29_idx = 1;
         sGXsfl_29_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_29_idx), 4, 0)), 4, "0");
         SubsflControlProps_292( ) ;
         bGXsfl_29_Refreshing = true;
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
            SubsflControlProps_292( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 A215XT_LogProviderID ,
                                                 AV35tJC_ProviderIDs ,
                                                 AV38XT_LogWWDS_1_Xt_logtargetmodule ,
                                                 AV28tDesrciption ,
                                                 AV34IsRocheUser ,
                                                 A217XT_LogTargetModule ,
                                                 A221XT_LogDescription ,
                                                 AV15OrderedBy ,
                                                 AV16OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT,
                                                 TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV38XT_LogWWDS_1_Xt_logtargetmodule = StringUtil.Concat( StringUtil.RTrim( AV38XT_LogWWDS_1_Xt_logtargetmodule), "%", "");
            lV28tDesrciption = StringUtil.Concat( StringUtil.RTrim( AV28tDesrciption), "%", "");
            /* Using cursor H004G2 */
            pr_default.execute(0, new Object[] {lV38XT_LogWWDS_1_Xt_logtargetmodule, lV28tDesrciption, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_29_idx = 1;
            sGXsfl_29_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_29_idx), 4, 0)), 4, "0");
            SubsflControlProps_292( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A221XT_LogDescription = H004G2_A221XT_LogDescription[0];
               n221XT_LogDescription = H004G2_n221XT_LogDescription[0];
               A218XT_LogTargetOperate = H004G2_A218XT_LogTargetOperate[0];
               n218XT_LogTargetOperate = H004G2_n218XT_LogTargetOperate[0];
               A222XT_LogTargetSonModule = H004G2_A222XT_LogTargetSonModule[0];
               n222XT_LogTargetSonModule = H004G2_n222XT_LogTargetSonModule[0];
               A217XT_LogTargetModule = H004G2_A217XT_LogTargetModule[0];
               n217XT_LogTargetModule = H004G2_n217XT_LogTargetModule[0];
               A223XT_LogSonTarget = H004G2_A223XT_LogSonTarget[0];
               n223XT_LogSonTarget = H004G2_n223XT_LogSonTarget[0];
               A216XT_LogTarget = H004G2_A216XT_LogTarget[0];
               n216XT_LogTarget = H004G2_n216XT_LogTarget[0];
               A219XT_LogProviderName = H004G2_A219XT_LogProviderName[0];
               n219XT_LogProviderName = H004G2_n219XT_LogProviderName[0];
               A215XT_LogProviderID = H004G2_A215XT_LogProviderID[0];
               n215XT_LogProviderID = H004G2_n215XT_LogProviderID[0];
               A213XT_LogType = H004G2_A213XT_LogType[0];
               n213XT_LogType = H004G2_n213XT_LogType[0];
               A177XT_LogButtonName = H004G2_A177XT_LogButtonName[0];
               n177XT_LogButtonName = H004G2_n177XT_LogButtonName[0];
               A176XT_LogPage = H004G2_A176XT_LogPage[0];
               n176XT_LogPage = H004G2_n176XT_LogPage[0];
               A220XT_LogTime = H004G2_A220XT_LogTime[0];
               n220XT_LogTime = H004G2_n220XT_LogTime[0];
               A174XT_LogSecUserName = H004G2_A174XT_LogSecUserName[0];
               n174XT_LogSecUserName = H004G2_n174XT_LogSecUserName[0];
               A214XT_LogUserID = H004G2_A214XT_LogUserID[0];
               n214XT_LogUserID = H004G2_n214XT_LogUserID[0];
               A173XT_LogID = H004G2_A173XT_LogID[0];
               E184G2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 29;
            WB4G0( ) ;
         }
         bGXsfl_29_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes4G2( )
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
         AV38XT_LogWWDS_1_Xt_logtargetmodule = AV27XT_LogTargetModule;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              A215XT_LogProviderID ,
                                              AV35tJC_ProviderIDs ,
                                              AV38XT_LogWWDS_1_Xt_logtargetmodule ,
                                              AV28tDesrciption ,
                                              AV34IsRocheUser ,
                                              A217XT_LogTargetModule ,
                                              A221XT_LogDescription ,
                                              AV15OrderedBy ,
                                              AV16OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT,
                                              TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV38XT_LogWWDS_1_Xt_logtargetmodule = StringUtil.Concat( StringUtil.RTrim( AV38XT_LogWWDS_1_Xt_logtargetmodule), "%", "");
         lV28tDesrciption = StringUtil.Concat( StringUtil.RTrim( AV28tDesrciption), "%", "");
         /* Using cursor H004G3 */
         pr_default.execute(1, new Object[] {lV38XT_LogWWDS_1_Xt_logtargetmodule, lV28tDesrciption});
         GRID_nRecordCount = H004G3_AGRID_nRecordCount[0];
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
         AV38XT_LogWWDS_1_Xt_logtargetmodule = AV27XT_LogTargetModule;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV27XT_LogTargetModule, AV28tDesrciption, AV15OrderedBy, AV16OrderedDsc, AV32ddo_XT_LogTargetModuleTitleControlIdToReplace, AV6ddo_XT_LogDescriptionTitleControlIdToReplace, AV40Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV38XT_LogWWDS_1_Xt_logtargetmodule = AV27XT_LogTargetModule;
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
            gxgrGrid_refresh( subGrid_Rows, AV27XT_LogTargetModule, AV28tDesrciption, AV15OrderedBy, AV16OrderedDsc, AV32ddo_XT_LogTargetModuleTitleControlIdToReplace, AV6ddo_XT_LogDescriptionTitleControlIdToReplace, AV40Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV38XT_LogWWDS_1_Xt_logtargetmodule = AV27XT_LogTargetModule;
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
            gxgrGrid_refresh( subGrid_Rows, AV27XT_LogTargetModule, AV28tDesrciption, AV15OrderedBy, AV16OrderedDsc, AV32ddo_XT_LogTargetModuleTitleControlIdToReplace, AV6ddo_XT_LogDescriptionTitleControlIdToReplace, AV40Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV38XT_LogWWDS_1_Xt_logtargetmodule = AV27XT_LogTargetModule;
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
            gxgrGrid_refresh( subGrid_Rows, AV27XT_LogTargetModule, AV28tDesrciption, AV15OrderedBy, AV16OrderedDsc, AV32ddo_XT_LogTargetModuleTitleControlIdToReplace, AV6ddo_XT_LogDescriptionTitleControlIdToReplace, AV40Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV38XT_LogWWDS_1_Xt_logtargetmodule = AV27XT_LogTargetModule;
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
            gxgrGrid_refresh( subGrid_Rows, AV27XT_LogTargetModule, AV28tDesrciption, AV15OrderedBy, AV16OrderedDsc, AV32ddo_XT_LogTargetModuleTitleControlIdToReplace, AV6ddo_XT_LogDescriptionTitleControlIdToReplace, AV40Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP4G0( )
      {
         /* Before Start, stand alone formulas. */
         AV40Pgmname = "XT_LogWW";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E164G2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV5DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_LOGTARGETMODULETITLEFILTERDATA"), AV29XT_LogTargetModuleTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_LOGDESCRIPTIONTITLEFILTERDATA"), AV26XT_LogDescriptionTitleFilterData);
            /* Read variables values. */
            AV27XT_LogTargetModule = cgiGet( edtavXt_logtargetmodule_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27XT_LogTargetModule", AV27XT_LogTargetModule);
            AV28tDesrciption = cgiGet( edtavTdesrciption_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28tDesrciption", AV28tDesrciption);
            AV32ddo_XT_LogTargetModuleTitleControlIdToReplace = cgiGet( edtavDdo_xt_logtargetmoduletitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32ddo_XT_LogTargetModuleTitleControlIdToReplace", AV32ddo_XT_LogTargetModuleTitleControlIdToReplace);
            AV6ddo_XT_LogDescriptionTitleControlIdToReplace = cgiGet( edtavDdo_xt_logdescriptiontitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6ddo_XT_LogDescriptionTitleControlIdToReplace", AV6ddo_XT_LogDescriptionTitleControlIdToReplace);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDEREDBY");
               GX_FocusControl = edtavOrderedby_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV15OrderedBy = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15OrderedBy), 4, 0)));
            }
            else
            {
               AV15OrderedBy = (short)(context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15OrderedBy), 4, 0)));
            }
            AV16OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16OrderedDsc", AV16OrderedDsc);
            /* Read saved values. */
            nRC_GXsfl_29 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_29"), ".", ","));
            AV8GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV10GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV9GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID_nFirstRecordOnPage"), ".", ","));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID_nEOF"), ".", ","));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Dvpanel_unnamedtable1_Width = cgiGet( "DVPANEL_UNNAMEDTABLE1_Width");
            Dvpanel_unnamedtable1_Cls = cgiGet( "DVPANEL_UNNAMEDTABLE1_Cls");
            Dvpanel_unnamedtable1_Title = cgiGet( "DVPANEL_UNNAMEDTABLE1_Title");
            Dvpanel_unnamedtable1_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE1_Collapsible"));
            Dvpanel_unnamedtable1_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE1_Collapsed"));
            Dvpanel_unnamedtable1_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE1_Autowidth"));
            Dvpanel_unnamedtable1_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE1_Autoheight"));
            Dvpanel_unnamedtable1_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE1_Showcollapseicon"));
            Dvpanel_unnamedtable1_Iconposition = cgiGet( "DVPANEL_UNNAMEDTABLE1_Iconposition");
            Dvpanel_unnamedtable1_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE1_Autoscroll"));
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
            Ddo_xt_logtargetmodule_Caption = cgiGet( "DDO_XT_LOGTARGETMODULE_Caption");
            Ddo_xt_logtargetmodule_Tooltip = cgiGet( "DDO_XT_LOGTARGETMODULE_Tooltip");
            Ddo_xt_logtargetmodule_Cls = cgiGet( "DDO_XT_LOGTARGETMODULE_Cls");
            Ddo_xt_logtargetmodule_Dropdownoptionstype = cgiGet( "DDO_XT_LOGTARGETMODULE_Dropdownoptionstype");
            Ddo_xt_logtargetmodule_Titlecontrolidtoreplace = cgiGet( "DDO_XT_LOGTARGETMODULE_Titlecontrolidtoreplace");
            Ddo_xt_logtargetmodule_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGTARGETMODULE_Includesortasc"));
            Ddo_xt_logtargetmodule_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGTARGETMODULE_Includesortdsc"));
            Ddo_xt_logtargetmodule_Sortedstatus = cgiGet( "DDO_XT_LOGTARGETMODULE_Sortedstatus");
            Ddo_xt_logtargetmodule_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGTARGETMODULE_Includefilter"));
            Ddo_xt_logtargetmodule_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGTARGETMODULE_Includedatalist"));
            Ddo_xt_logtargetmodule_Sortasc = cgiGet( "DDO_XT_LOGTARGETMODULE_Sortasc");
            Ddo_xt_logtargetmodule_Sortdsc = cgiGet( "DDO_XT_LOGTARGETMODULE_Sortdsc");
            Ddo_xt_logtargetmodule_Searchbuttontext = cgiGet( "DDO_XT_LOGTARGETMODULE_Searchbuttontext");
            Ddo_xt_logdescription_Caption = cgiGet( "DDO_XT_LOGDESCRIPTION_Caption");
            Ddo_xt_logdescription_Tooltip = cgiGet( "DDO_XT_LOGDESCRIPTION_Tooltip");
            Ddo_xt_logdescription_Cls = cgiGet( "DDO_XT_LOGDESCRIPTION_Cls");
            Ddo_xt_logdescription_Dropdownoptionstype = cgiGet( "DDO_XT_LOGDESCRIPTION_Dropdownoptionstype");
            Ddo_xt_logdescription_Titlecontrolidtoreplace = cgiGet( "DDO_XT_LOGDESCRIPTION_Titlecontrolidtoreplace");
            Ddo_xt_logdescription_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGDESCRIPTION_Includesortasc"));
            Ddo_xt_logdescription_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGDESCRIPTION_Includesortdsc"));
            Ddo_xt_logdescription_Sortedstatus = cgiGet( "DDO_XT_LOGDESCRIPTION_Sortedstatus");
            Ddo_xt_logdescription_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGDESCRIPTION_Includefilter"));
            Ddo_xt_logdescription_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGDESCRIPTION_Includedatalist"));
            Ddo_xt_logdescription_Sortasc = cgiGet( "DDO_XT_LOGDESCRIPTION_Sortasc");
            Ddo_xt_logdescription_Sortdsc = cgiGet( "DDO_XT_LOGDESCRIPTION_Sortdsc");
            Ddo_xt_logdescription_Searchbuttontext = cgiGet( "DDO_XT_LOGDESCRIPTION_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_xt_logtargetmodule_Activeeventkey = cgiGet( "DDO_XT_LOGTARGETMODULE_Activeeventkey");
            Ddo_xt_logdescription_Activeeventkey = cgiGet( "DDO_XT_LOGDESCRIPTION_Activeeventkey");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( StringUtil.StrCmp(cgiGet( "GXH_vXT_LOGTARGETMODULE"), AV27XT_LogTargetModule) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTDESRCIPTION"), AV28tDesrciption) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV15OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV16OrderedDsc )
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
         E164G2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E164G2( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_xt_logtargetmodule_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_LogTargetModule";
         ucDdo_xt_logtargetmodule.SendProperty(context, "", false, Ddo_xt_logtargetmodule_Internalname, "TitleControlIdToReplace", Ddo_xt_logtargetmodule_Titlecontrolidtoreplace);
         AV32ddo_XT_LogTargetModuleTitleControlIdToReplace = Ddo_xt_logtargetmodule_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32ddo_XT_LogTargetModuleTitleControlIdToReplace", AV32ddo_XT_LogTargetModuleTitleControlIdToReplace);
         edtavDdo_xt_logtargetmoduletitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_logtargetmoduletitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_logtargetmoduletitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_xt_logdescription_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_LogDescription";
         ucDdo_xt_logdescription.SendProperty(context, "", false, Ddo_xt_logdescription_Internalname, "TitleControlIdToReplace", Ddo_xt_logdescription_Titlecontrolidtoreplace);
         AV6ddo_XT_LogDescriptionTitleControlIdToReplace = Ddo_xt_logdescription_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6ddo_XT_LogDescriptionTitleControlIdToReplace", AV6ddo_XT_LogDescriptionTitleControlIdToReplace);
         edtavDdo_xt_logdescriptiontitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_logdescriptiontitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_logdescriptiontitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " 系统日志";
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
         if ( AV15OrderedBy < 1 )
         {
            AV15OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15OrderedBy), 4, 0)));
         }
         edtavOrdereddsc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrdereddsc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrdereddsc_Visible), 5, 0)), true);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV5DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV5DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E174G2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         GXt_objcol_int2 = AV35tJC_ProviderIDs;
         new zutil_findallproviderids(context ).execute( out  GXt_objcol_int2) ;
         AV35tJC_ProviderIDs = GXt_objcol_int2;
         AV34IsRocheUser = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34IsRocheUser", AV34IsRocheUser);
         GXt_boolean3 = AV34IsRocheUser;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "RocheUser", out  GXt_boolean3) ;
         AV34IsRocheUser = GXt_boolean3;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34IsRocheUser", AV34IsRocheUser);
         AV29XT_LogTargetModuleTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV26XT_LogDescriptionTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV24WWPContext) ;
         /* Execute user subroutine: 'SAVEGRIDSTATE' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         edtXT_LogTargetModule_Titleformat = 2;
         edtXT_LogTargetModule_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "操作模块", AV32ddo_XT_LogTargetModuleTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogTargetModule_Internalname, "Title", edtXT_LogTargetModule_Title, !bGXsfl_29_Refreshing);
         edtXT_LogDescription_Titleformat = 2;
         edtXT_LogDescription_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "日志描述", AV6ddo_XT_LogDescriptionTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogDescription_Internalname, "Title", edtXT_LogDescription_Title, !bGXsfl_29_Refreshing);
         AV8GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8GridCurrentPage), 10, 0)));
         AV9GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9GridPageSize), 10, 0)));
         AV10GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10GridRecordCount), 10, 0)));
         AV38XT_LogWWDS_1_Xt_logtargetmodule = AV27XT_LogTargetModule;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29XT_LogTargetModuleTitleFilterData", AV29XT_LogTargetModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26XT_LogDescriptionTitleFilterData", AV26XT_LogDescriptionTitleFilterData);
      }

      protected void E114G2( )
      {
         /* Gridpaginationbar_Changepage Routine */
         if ( 1 == 0 )
         {
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
               AV17PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
               subgrid_gotopage( AV17PageToGo) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(Gridpaginationbar_Selectedpage, "Previous") == 0 )
            {
               subgrid_previouspage( ) ;
            }
            else if ( StringUtil.StrCmp(Gridpaginationbar_Selectedpage, "Next") == 0 )
            {
               subgrid_gotopage( subGrid_Currentpage( )+1) ;
            }
            else
            {
               AV17PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
               subgrid_gotopage( AV17PageToGo) ;
            }
         }
      }

      protected void E124G2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E134G2( )
      {
         /* Ddo_xt_logtargetmodule_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_logtargetmodule_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV15OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15OrderedBy), 4, 0)));
            AV16OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16OrderedDsc", AV16OrderedDsc);
            Ddo_xt_logtargetmodule_Sortedstatus = "ASC";
            ucDdo_xt_logtargetmodule.SendProperty(context, "", false, Ddo_xt_logtargetmodule_Internalname, "SortedStatus", Ddo_xt_logtargetmodule_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_logtargetmodule_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV15OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15OrderedBy), 4, 0)));
            AV16OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16OrderedDsc", AV16OrderedDsc);
            Ddo_xt_logtargetmodule_Sortedstatus = "DSC";
            ucDdo_xt_logtargetmodule.SendProperty(context, "", false, Ddo_xt_logtargetmodule_Internalname, "SortedStatus", Ddo_xt_logtargetmodule_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29XT_LogTargetModuleTitleFilterData", AV29XT_LogTargetModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26XT_LogDescriptionTitleFilterData", AV26XT_LogDescriptionTitleFilterData);
      }

      protected void E144G2( )
      {
         /* Ddo_xt_logdescription_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_logdescription_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV15OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15OrderedBy), 4, 0)));
            AV16OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16OrderedDsc", AV16OrderedDsc);
            Ddo_xt_logdescription_Sortedstatus = "ASC";
            ucDdo_xt_logdescription.SendProperty(context, "", false, Ddo_xt_logdescription_Internalname, "SortedStatus", Ddo_xt_logdescription_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_logdescription_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV15OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15OrderedBy), 4, 0)));
            AV16OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16OrderedDsc", AV16OrderedDsc);
            Ddo_xt_logdescription_Sortedstatus = "DSC";
            ucDdo_xt_logdescription.SendProperty(context, "", false, Ddo_xt_logdescription_Internalname, "SortedStatus", Ddo_xt_logdescription_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29XT_LogTargetModuleTitleFilterData", AV29XT_LogTargetModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26XT_LogDescriptionTitleFilterData", AV26XT_LogDescriptionTitleFilterData);
      }

      private void E184G2( )
      {
         /* Grid_Load Routine */
         AV7Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDisplay_Internalname, AV7Display);
         AV39Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = formatLink("xt_logview.aspx") + "?" + UrlEncode("" +A173XT_LogID) + "," + UrlEncode(StringUtil.RTrim(""));
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 29;
         }
         sendrow_292( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_29_Refreshing )
         {
            context.DoAjaxLoad(29, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV19Session.Get(AV40Pgmname+"GridState"), "") == 0 )
         {
            AV11GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV40Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV11GridState.FromXml(AV19Session.Get(AV40Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV15OrderedBy = AV11GridState.gxTpr_Orderedby;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15OrderedBy), 4, 0)));
         AV16OrderedDsc = AV11GridState.gxTpr_Ordereddsc;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16OrderedDsc", AV16OrderedDsc);
         AV41GXV1 = 1;
         while ( AV41GXV1 <= AV11GridState.gxTpr_Filtervalues.Count )
         {
            AV12GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV11GridState.gxTpr_Filtervalues.Item(AV41GXV1));
            if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "XT_LOGTARGETMODULE") == 0 )
            {
               AV27XT_LogTargetModule = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27XT_LogTargetModule", AV27XT_LogTargetModule);
            }
            AV41GXV1 = (int)(AV41GXV1+1);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV11GridState.gxTpr_Pagesize))) )
         {
            subGrid_Rows = (int)(NumberUtil.Val( AV11GridState.gxTpr_Pagesize, "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         }
         subgrid_gotopage( AV11GridState.gxTpr_Currentpage) ;
      }

      protected void S132( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV11GridState.FromXml(AV19Session.Get(AV40Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV11GridState.gxTpr_Orderedby = AV15OrderedBy;
         AV11GridState.gxTpr_Ordereddsc = AV16OrderedDsc;
         AV11GridState.gxTpr_Filtervalues.Clear();
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV27XT_LogTargetModule)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "XT_LOGTARGETMODULE";
            AV12GridStateFilterValue.gxTpr_Value = AV27XT_LogTargetModule;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         AV11GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV11GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV40Pgmname+"GridState",  AV11GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV22TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV22TrnContext.gxTpr_Callerobject = AV40Pgmname;
         AV22TrnContext.gxTpr_Callerondelete = true;
         AV22TrnContext.gxTpr_Callerurl = AV13HTTPRequest.ScriptName+"?"+AV13HTTPRequest.QueryString;
         AV22TrnContext.gxTpr_Transactionname = "XT_Log";
         AV19Session.Set("TrnContext", AV22TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      protected void E154G2( )
      {
         /* Tdesrciption_Controlvaluechanging Routine */
         context.DoAjaxRefresh();
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29XT_LogTargetModuleTitleFilterData", AV29XT_LogTargetModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26XT_LogDescriptionTitleFilterData", AV26XT_LogDescriptionTitleFilterData);
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
         PA4G2( ) ;
         WS4G2( ) ;
         WE4G2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022815115361", true);
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
         context.AddJavascriptSource("xt_logww.js", "?202022815115362", false);
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

      protected void SubsflControlProps_292( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_29_idx;
         edtXT_LogID_Internalname = "XT_LOGID_"+sGXsfl_29_idx;
         edtXT_LogUserID_Internalname = "XT_LOGUSERID_"+sGXsfl_29_idx;
         edtXT_LogSecUserName_Internalname = "XT_LOGSECUSERNAME_"+sGXsfl_29_idx;
         edtXT_LogTime_Internalname = "XT_LOGTIME_"+sGXsfl_29_idx;
         cmbXT_LogPage_Internalname = "XT_LOGPAGE_"+sGXsfl_29_idx;
         edtXT_LogButtonName_Internalname = "XT_LOGBUTTONNAME_"+sGXsfl_29_idx;
         edtXT_LogType_Internalname = "XT_LOGTYPE_"+sGXsfl_29_idx;
         edtXT_LogProviderID_Internalname = "XT_LOGPROVIDERID_"+sGXsfl_29_idx;
         edtXT_LogProviderName_Internalname = "XT_LOGPROVIDERNAME_"+sGXsfl_29_idx;
         edtXT_LogTarget_Internalname = "XT_LOGTARGET_"+sGXsfl_29_idx;
         edtXT_LogSonTarget_Internalname = "XT_LOGSONTARGET_"+sGXsfl_29_idx;
         edtXT_LogTargetModule_Internalname = "XT_LOGTARGETMODULE_"+sGXsfl_29_idx;
         edtXT_LogTargetSonModule_Internalname = "XT_LOGTARGETSONMODULE_"+sGXsfl_29_idx;
         cmbXT_LogTargetOperate_Internalname = "XT_LOGTARGETOPERATE_"+sGXsfl_29_idx;
         edtXT_LogDescription_Internalname = "XT_LOGDESCRIPTION_"+sGXsfl_29_idx;
      }

      protected void SubsflControlProps_fel_292( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_29_fel_idx;
         edtXT_LogID_Internalname = "XT_LOGID_"+sGXsfl_29_fel_idx;
         edtXT_LogUserID_Internalname = "XT_LOGUSERID_"+sGXsfl_29_fel_idx;
         edtXT_LogSecUserName_Internalname = "XT_LOGSECUSERNAME_"+sGXsfl_29_fel_idx;
         edtXT_LogTime_Internalname = "XT_LOGTIME_"+sGXsfl_29_fel_idx;
         cmbXT_LogPage_Internalname = "XT_LOGPAGE_"+sGXsfl_29_fel_idx;
         edtXT_LogButtonName_Internalname = "XT_LOGBUTTONNAME_"+sGXsfl_29_fel_idx;
         edtXT_LogType_Internalname = "XT_LOGTYPE_"+sGXsfl_29_fel_idx;
         edtXT_LogProviderID_Internalname = "XT_LOGPROVIDERID_"+sGXsfl_29_fel_idx;
         edtXT_LogProviderName_Internalname = "XT_LOGPROVIDERNAME_"+sGXsfl_29_fel_idx;
         edtXT_LogTarget_Internalname = "XT_LOGTARGET_"+sGXsfl_29_fel_idx;
         edtXT_LogSonTarget_Internalname = "XT_LOGSONTARGET_"+sGXsfl_29_fel_idx;
         edtXT_LogTargetModule_Internalname = "XT_LOGTARGETMODULE_"+sGXsfl_29_fel_idx;
         edtXT_LogTargetSonModule_Internalname = "XT_LOGTARGETSONMODULE_"+sGXsfl_29_fel_idx;
         cmbXT_LogTargetOperate_Internalname = "XT_LOGTARGETOPERATE_"+sGXsfl_29_fel_idx;
         edtXT_LogDescription_Internalname = "XT_LOGDESCRIPTION_"+sGXsfl_29_fel_idx;
      }

      protected void sendrow_292( )
      {
         SubsflControlProps_292( ) ;
         WB4G0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_29_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_29_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_29_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV7Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV7Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV39Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV7Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV7Display)) ? AV39Display_GXI : context.PathToRelativeUrl( AV7Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV7Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_LogID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A173XT_LogID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A173XT_LogID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_LogID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)29,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_LogUserID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A214XT_LogUserID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A214XT_LogUserID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_LogUserID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)29,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_LogSecUserName_Internalname,(String)A174XT_LogSecUserName,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_LogSecUserName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)29,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_LogTime_Internalname,context.localUtil.TToC( A220XT_LogTime, 10, 8, 0, 0, "/", ":", " "),context.localUtil.Format( A220XT_LogTime, "9999/99/99 99:99:99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_LogTime_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)19,(short)0,(short)0,(short)29,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            if ( ( cmbXT_LogPage.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "XT_LOGPAGE_" + sGXsfl_29_idx;
               cmbXT_LogPage.Name = GXCCtl;
               cmbXT_LogPage.WebTags = "";
               if ( cmbXT_LogPage.ItemCount > 0 )
               {
                  A176XT_LogPage = cmbXT_LogPage.getValidValue(A176XT_LogPage);
                  n176XT_LogPage = false;
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbXT_LogPage,(String)cmbXT_LogPage_Internalname,StringUtil.RTrim( A176XT_LogPage),(short)1,(String)cmbXT_LogPage_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"svchar",(String)"",(short)0,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbXT_LogPage.CurrentValue = StringUtil.RTrim( A176XT_LogPage);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbXT_LogPage_Internalname, "Values", (String)(cmbXT_LogPage.ToJavascriptSource()), !bGXsfl_29_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_LogButtonName_Internalname,(String)A177XT_LogButtonName,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_LogButtonName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)29,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_LogType_Internalname,(String)A213XT_LogType,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_LogType_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)29,(short)1,(short)-1,(short)-1,(bool)true,(String)"DM_LogType",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_LogProviderID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A215XT_LogProviderID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A215XT_LogProviderID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_LogProviderID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)29,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_LogProviderName_Internalname,(String)A219XT_LogProviderName,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_LogProviderName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)29,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_LogTarget_Internalname,(String)A216XT_LogTarget,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_LogTarget_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)5000,(short)0,(short)0,(short)29,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_LogSonTarget_Internalname,(String)A223XT_LogSonTarget,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_LogSonTarget_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)29,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_LogTargetModule_Internalname,(String)A217XT_LogTargetModule,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_LogTargetModule_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)29,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_LogTargetSonModule_Internalname,(String)A222XT_LogTargetSonModule,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_LogTargetSonModule_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)29,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            if ( ( cmbXT_LogTargetOperate.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "XT_LOGTARGETOPERATE_" + sGXsfl_29_idx;
               cmbXT_LogTargetOperate.Name = GXCCtl;
               cmbXT_LogTargetOperate.WebTags = "";
               cmbXT_LogTargetOperate.addItem("Create", "新增", 0);
               cmbXT_LogTargetOperate.addItem("Update", "编辑", 0);
               cmbXT_LogTargetOperate.addItem("Delete", "删除", 0);
               cmbXT_LogTargetOperate.addItem("Create", "保存", 0);
               cmbXT_LogTargetOperate.addItem("Submit", "提交审批", 0);
               cmbXT_LogTargetOperate.addItem("Batchcheck", "批量初审", 0);
               cmbXT_LogTargetOperate.addItem("Batchapprove", "批量复审", 0);
               cmbXT_LogTargetOperate.addItem("Randomcheckpass", "初审抽查通过", 0);
               cmbXT_LogTargetOperate.addItem("Randomcheckrefuse", "初审抽查不通过", 0);
               cmbXT_LogTargetOperate.addItem("Randomapprovepass", "复审抽查通过", 0);
               cmbXT_LogTargetOperate.addItem("Randomapproverefuse", "复审抽查不通过", 0);
               cmbXT_LogTargetOperate.addItem("Check", "初审通过", 0);
               cmbXT_LogTargetOperate.addItem("Approve", "复审通过", 0);
               cmbXT_LogTargetOperate.addItem("Reupdate", "重新修改", 0);
               cmbXT_LogTargetOperate.addItem("Login", "登录", 0);
               if ( cmbXT_LogTargetOperate.ItemCount > 0 )
               {
                  A218XT_LogTargetOperate = cmbXT_LogTargetOperate.getValidValue(A218XT_LogTargetOperate);
                  n218XT_LogTargetOperate = false;
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbXT_LogTargetOperate,(String)cmbXT_LogTargetOperate_Internalname,StringUtil.RTrim( A218XT_LogTargetOperate),(short)1,(String)cmbXT_LogTargetOperate_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"svchar",(String)"",(short)0,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbXT_LogTargetOperate.CurrentValue = StringUtil.RTrim( A218XT_LogTargetOperate);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbXT_LogTargetOperate_Internalname, "Values", (String)(cmbXT_LogTargetOperate.ToJavascriptSource()), !bGXsfl_29_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_LogDescription_Internalname,(String)A221XT_LogDescription,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_LogDescription_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)5000,(short)0,(short)0,(short)29,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes4G2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_29_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_29_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_29_idx+1));
            sGXsfl_29_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_29_idx), 4, 0)), 4, "0");
            SubsflControlProps_292( ) ;
         }
         /* End function sendrow_292 */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "XT_LOGPAGE_" + sGXsfl_29_idx;
         cmbXT_LogPage.Name = GXCCtl;
         cmbXT_LogPage.WebTags = "";
         if ( cmbXT_LogPage.ItemCount > 0 )
         {
            A176XT_LogPage = cmbXT_LogPage.getValidValue(A176XT_LogPage);
            n176XT_LogPage = false;
         }
         GXCCtl = "XT_LOGTARGETOPERATE_" + sGXsfl_29_idx;
         cmbXT_LogTargetOperate.Name = GXCCtl;
         cmbXT_LogTargetOperate.WebTags = "";
         cmbXT_LogTargetOperate.addItem("Create", "新增", 0);
         cmbXT_LogTargetOperate.addItem("Update", "编辑", 0);
         cmbXT_LogTargetOperate.addItem("Delete", "删除", 0);
         cmbXT_LogTargetOperate.addItem("Create", "保存", 0);
         cmbXT_LogTargetOperate.addItem("Submit", "提交审批", 0);
         cmbXT_LogTargetOperate.addItem("Batchcheck", "批量初审", 0);
         cmbXT_LogTargetOperate.addItem("Batchapprove", "批量复审", 0);
         cmbXT_LogTargetOperate.addItem("Randomcheckpass", "初审抽查通过", 0);
         cmbXT_LogTargetOperate.addItem("Randomcheckrefuse", "初审抽查不通过", 0);
         cmbXT_LogTargetOperate.addItem("Randomapprovepass", "复审抽查通过", 0);
         cmbXT_LogTargetOperate.addItem("Randomapproverefuse", "复审抽查不通过", 0);
         cmbXT_LogTargetOperate.addItem("Check", "初审通过", 0);
         cmbXT_LogTargetOperate.addItem("Approve", "复审通过", 0);
         cmbXT_LogTargetOperate.addItem("Reupdate", "重新修改", 0);
         cmbXT_LogTargetOperate.addItem("Login", "登录", 0);
         if ( cmbXT_LogTargetOperate.ItemCount > 0 )
         {
            A218XT_LogTargetOperate = cmbXT_LogTargetOperate.getValidValue(A218XT_LogTargetOperate);
            n218XT_LogTargetOperate = false;
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtavXt_logtargetmodule_Internalname = "vXT_LOGTARGETMODULE";
         edtavTdesrciption_Internalname = "vTDESRCIPTION";
         divUnnamedtable1_Internalname = "UNNAMEDTABLE1";
         divLayout_unnamedtable1_Internalname = "LAYOUT_UNNAMEDTABLE1";
         Dvpanel_unnamedtable1_Internalname = "DVPANEL_UNNAMEDTABLE1";
         divHtml_dvpanel_unnamedtable1_Internalname = "HTML_DVPANEL_UNNAMEDTABLE1";
         edtavDisplay_Internalname = "vDISPLAY";
         edtXT_LogID_Internalname = "XT_LOGID";
         edtXT_LogUserID_Internalname = "XT_LOGUSERID";
         edtXT_LogSecUserName_Internalname = "XT_LOGSECUSERNAME";
         edtXT_LogTime_Internalname = "XT_LOGTIME";
         cmbXT_LogPage_Internalname = "XT_LOGPAGE";
         edtXT_LogButtonName_Internalname = "XT_LOGBUTTONNAME";
         edtXT_LogType_Internalname = "XT_LOGTYPE";
         edtXT_LogProviderID_Internalname = "XT_LOGPROVIDERID";
         edtXT_LogProviderName_Internalname = "XT_LOGPROVIDERNAME";
         edtXT_LogTarget_Internalname = "XT_LOGTARGET";
         edtXT_LogSonTarget_Internalname = "XT_LOGSONTARGET";
         edtXT_LogTargetModule_Internalname = "XT_LOGTARGETMODULE";
         edtXT_LogTargetSonModule_Internalname = "XT_LOGTARGETSONMODULE";
         cmbXT_LogTargetOperate_Internalname = "XT_LOGTARGETOPERATE";
         edtXT_LogDescription_Internalname = "XT_LOGDESCRIPTION";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_xt_logtargetmodule_Internalname = "DDO_XT_LOGTARGETMODULE";
         edtavDdo_xt_logtargetmoduletitlecontrolidtoreplace_Internalname = "vDDO_XT_LOGTARGETMODULETITLECONTROLIDTOREPLACE";
         Ddo_xt_logdescription_Internalname = "DDO_XT_LOGDESCRIPTION";
         edtavDdo_xt_logdescriptiontitlecontrolidtoreplace_Internalname = "vDDO_XT_LOGDESCRIPTIONTITLECONTROLIDTOREPLACE";
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
         edtXT_LogDescription_Jsonclick = "";
         cmbXT_LogTargetOperate_Jsonclick = "";
         edtXT_LogTargetSonModule_Jsonclick = "";
         edtXT_LogTargetModule_Jsonclick = "";
         edtXT_LogSonTarget_Jsonclick = "";
         edtXT_LogTarget_Jsonclick = "";
         edtXT_LogProviderName_Jsonclick = "";
         edtXT_LogProviderID_Jsonclick = "";
         edtXT_LogType_Jsonclick = "";
         edtXT_LogButtonName_Jsonclick = "";
         cmbXT_LogPage_Jsonclick = "";
         edtXT_LogTime_Jsonclick = "";
         edtXT_LogSecUserName_Jsonclick = "";
         edtXT_LogUserID_Jsonclick = "";
         edtXT_LogID_Jsonclick = "";
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_xt_logdescriptiontitlecontrolidtoreplace_Visible = 1;
         edtavDdo_xt_logtargetmoduletitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtXT_LogDescription_Titleformat = 0;
         edtXT_LogDescription_Title = "日志描述";
         edtXT_LogTargetModule_Titleformat = 0;
         edtXT_LogTargetModule_Title = "操作模块";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         edtavTdesrciption_Jsonclick = "";
         edtavTdesrciption_Enabled = 1;
         edtavXt_logtargetmodule_Jsonclick = "";
         edtavXt_logtargetmodule_Enabled = 1;
         Ddo_xt_logdescription_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_logdescription_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_logdescription_Sortasc = "WWP_TSSortASC";
         Ddo_xt_logdescription_Includedatalist = Convert.ToBoolean( 0);
         Ddo_xt_logdescription_Includefilter = Convert.ToBoolean( 0);
         Ddo_xt_logdescription_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_xt_logdescription_Includesortasc = Convert.ToBoolean( -1);
         Ddo_xt_logdescription_Titlecontrolidtoreplace = "";
         Ddo_xt_logdescription_Dropdownoptionstype = "GridTitleSettings";
         Ddo_xt_logdescription_Cls = "ColumnSettings";
         Ddo_xt_logdescription_Tooltip = "WWP_TSColumnOptions";
         Ddo_xt_logdescription_Caption = "";
         Ddo_xt_logtargetmodule_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_logtargetmodule_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_logtargetmodule_Sortasc = "WWP_TSSortASC";
         Ddo_xt_logtargetmodule_Includedatalist = Convert.ToBoolean( 0);
         Ddo_xt_logtargetmodule_Includefilter = Convert.ToBoolean( 0);
         Ddo_xt_logtargetmodule_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_xt_logtargetmodule_Includesortasc = Convert.ToBoolean( -1);
         Ddo_xt_logtargetmodule_Titlecontrolidtoreplace = "";
         Ddo_xt_logtargetmodule_Dropdownoptionstype = "GridTitleSettings";
         Ddo_xt_logtargetmodule_Cls = "ColumnSettings";
         Ddo_xt_logtargetmodule_Tooltip = "WWP_TSColumnOptions";
         Ddo_xt_logtargetmodule_Caption = "";
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
         Dvpanel_unnamedtable1_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable1_Iconposition = "left";
         Dvpanel_unnamedtable1_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable1_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_unnamedtable1_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable1_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable1_Collapsible = Convert.ToBoolean( -1);
         Dvpanel_unnamedtable1_Title = "";
         Dvpanel_unnamedtable1_Cls = "PanelNoHeader";
         Dvpanel_unnamedtable1_Width = "100%";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = " 系统日志";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV28tDesrciption',fld:'vTDESRCIPTION',pic:''},{av:'AV32ddo_XT_LogTargetModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV6ddo_XT_LogDescriptionTitleControlIdToReplace',fld:'vDDO_XT_LOGDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV27XT_LogTargetModule',fld:'vXT_LOGTARGETMODULE',pic:''},{av:'AV40Pgmname',fld:'vPGMNAME',pic:''},{av:'AV15OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV16OrderedDsc',fld:'vORDEREDDSC',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV34IsRocheUser',fld:'vISROCHEUSER',pic:''},{av:'AV29XT_LogTargetModuleTitleFilterData',fld:'vXT_LOGTARGETMODULETITLEFILTERDATA',pic:''},{av:'AV26XT_LogDescriptionTitleFilterData',fld:'vXT_LOGDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtXT_LogTargetModule_Titleformat',ctrl:'XT_LOGTARGETMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetModule_Title',ctrl:'XT_LOGTARGETMODULE',prop:'Title'},{av:'edtXT_LogDescription_Titleformat',ctrl:'XT_LOGDESCRIPTION',prop:'Titleformat'},{av:'edtXT_LogDescription_Title',ctrl:'XT_LOGDESCRIPTION',prop:'Title'},{av:'AV8GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV9GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV10GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E114G2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV27XT_LogTargetModule',fld:'vXT_LOGTARGETMODULE',pic:''},{av:'AV28tDesrciption',fld:'vTDESRCIPTION',pic:''},{av:'AV15OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV16OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV32ddo_XT_LogTargetModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV6ddo_XT_LogDescriptionTitleControlIdToReplace',fld:'vDDO_XT_LOGDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV40Pgmname',fld:'vPGMNAME',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E124G2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV27XT_LogTargetModule',fld:'vXT_LOGTARGETMODULE',pic:''},{av:'AV28tDesrciption',fld:'vTDESRCIPTION',pic:''},{av:'AV15OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV16OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV32ddo_XT_LogTargetModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV6ddo_XT_LogDescriptionTitleControlIdToReplace',fld:'vDDO_XT_LOGDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV40Pgmname',fld:'vPGMNAME',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_XT_LOGTARGETMODULE.ONOPTIONCLICKED","{handler:'E134G2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV27XT_LogTargetModule',fld:'vXT_LOGTARGETMODULE',pic:''},{av:'AV28tDesrciption',fld:'vTDESRCIPTION',pic:''},{av:'AV15OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV16OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV32ddo_XT_LogTargetModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV6ddo_XT_LogDescriptionTitleControlIdToReplace',fld:'vDDO_XT_LOGDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV40Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_xt_logtargetmodule_Activeeventkey',ctrl:'DDO_XT_LOGTARGETMODULE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_LOGTARGETMODULE.ONOPTIONCLICKED",",oparms:[{av:'AV15OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV16OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_logtargetmodule_Sortedstatus',ctrl:'DDO_XT_LOGTARGETMODULE',prop:'SortedStatus'},{av:'AV34IsRocheUser',fld:'vISROCHEUSER',pic:''},{av:'AV29XT_LogTargetModuleTitleFilterData',fld:'vXT_LOGTARGETMODULETITLEFILTERDATA',pic:''},{av:'AV26XT_LogDescriptionTitleFilterData',fld:'vXT_LOGDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtXT_LogTargetModule_Titleformat',ctrl:'XT_LOGTARGETMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetModule_Title',ctrl:'XT_LOGTARGETMODULE',prop:'Title'},{av:'edtXT_LogDescription_Titleformat',ctrl:'XT_LOGDESCRIPTION',prop:'Titleformat'},{av:'edtXT_LogDescription_Title',ctrl:'XT_LOGDESCRIPTION',prop:'Title'},{av:'AV8GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV9GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV10GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_XT_LOGDESCRIPTION.ONOPTIONCLICKED","{handler:'E144G2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV27XT_LogTargetModule',fld:'vXT_LOGTARGETMODULE',pic:''},{av:'AV28tDesrciption',fld:'vTDESRCIPTION',pic:''},{av:'AV15OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV16OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV32ddo_XT_LogTargetModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV6ddo_XT_LogDescriptionTitleControlIdToReplace',fld:'vDDO_XT_LOGDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV40Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_xt_logdescription_Activeeventkey',ctrl:'DDO_XT_LOGDESCRIPTION',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_LOGDESCRIPTION.ONOPTIONCLICKED",",oparms:[{av:'AV15OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV16OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_logdescription_Sortedstatus',ctrl:'DDO_XT_LOGDESCRIPTION',prop:'SortedStatus'},{av:'AV34IsRocheUser',fld:'vISROCHEUSER',pic:''},{av:'AV29XT_LogTargetModuleTitleFilterData',fld:'vXT_LOGTARGETMODULETITLEFILTERDATA',pic:''},{av:'AV26XT_LogDescriptionTitleFilterData',fld:'vXT_LOGDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtXT_LogTargetModule_Titleformat',ctrl:'XT_LOGTARGETMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetModule_Title',ctrl:'XT_LOGTARGETMODULE',prop:'Title'},{av:'edtXT_LogDescription_Titleformat',ctrl:'XT_LOGDESCRIPTION',prop:'Titleformat'},{av:'edtXT_LogDescription_Title',ctrl:'XT_LOGDESCRIPTION',prop:'Title'},{av:'AV8GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV9GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV10GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E184G2',iparms:[{av:'A173XT_LogID',fld:'XT_LOGID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV7Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'}]}");
         setEventMetadata("VTDESRCIPTION.CONTROLVALUECHANGING","{handler:'E154G2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV27XT_LogTargetModule',fld:'vXT_LOGTARGETMODULE',pic:''},{av:'AV28tDesrciption',fld:'vTDESRCIPTION',pic:''},{av:'AV15OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV16OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV32ddo_XT_LogTargetModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV6ddo_XT_LogDescriptionTitleControlIdToReplace',fld:'vDDO_XT_LOGDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV40Pgmname',fld:'vPGMNAME',pic:''}]");
         setEventMetadata("VTDESRCIPTION.CONTROLVALUECHANGING",",oparms:[{av:'AV34IsRocheUser',fld:'vISROCHEUSER',pic:''},{av:'AV29XT_LogTargetModuleTitleFilterData',fld:'vXT_LOGTARGETMODULETITLEFILTERDATA',pic:''},{av:'AV26XT_LogDescriptionTitleFilterData',fld:'vXT_LOGDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtXT_LogTargetModule_Titleformat',ctrl:'XT_LOGTARGETMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetModule_Title',ctrl:'XT_LOGTARGETMODULE',prop:'Title'},{av:'edtXT_LogDescription_Titleformat',ctrl:'XT_LOGDESCRIPTION',prop:'Titleformat'},{av:'edtXT_LogDescription_Title',ctrl:'XT_LOGDESCRIPTION',prop:'Title'},{av:'AV8GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV9GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV10GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
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
         Ddo_xt_logtargetmodule_Activeeventkey = "";
         Ddo_xt_logdescription_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV27XT_LogTargetModule = "";
         AV28tDesrciption = "";
         AV32ddo_XT_LogTargetModuleTitleControlIdToReplace = "";
         AV6ddo_XT_LogDescriptionTitleControlIdToReplace = "";
         AV40Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV5DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV29XT_LogTargetModuleTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV26XT_LogDescriptionTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_xt_logtargetmodule_Sortedstatus = "";
         Ddo_xt_logdescription_Sortedstatus = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ucDvpanel_unnamedtable1 = new GXUserControl();
         TempTags = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV7Display = "";
         A174XT_LogSecUserName = "";
         A220XT_LogTime = (DateTime)(DateTime.MinValue);
         A176XT_LogPage = "";
         A177XT_LogButtonName = "";
         A213XT_LogType = "";
         A219XT_LogProviderName = "";
         A216XT_LogTarget = "";
         A223XT_LogSonTarget = "";
         A217XT_LogTargetModule = "";
         A222XT_LogTargetSonModule = "";
         A218XT_LogTargetOperate = "";
         A221XT_LogDescription = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_xt_logtargetmodule = new GXUserControl();
         ClassString = "";
         StyleString = "";
         ucDdo_xt_logdescription = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV39Display_GXI = "";
         scmdbuf = "";
         lV38XT_LogWWDS_1_Xt_logtargetmodule = "";
         lV28tDesrciption = "";
         AV35tJC_ProviderIDs = new GxSimpleCollection<long>();
         AV38XT_LogWWDS_1_Xt_logtargetmodule = "";
         H004G2_A221XT_LogDescription = new String[] {""} ;
         H004G2_n221XT_LogDescription = new bool[] {false} ;
         H004G2_A218XT_LogTargetOperate = new String[] {""} ;
         H004G2_n218XT_LogTargetOperate = new bool[] {false} ;
         H004G2_A222XT_LogTargetSonModule = new String[] {""} ;
         H004G2_n222XT_LogTargetSonModule = new bool[] {false} ;
         H004G2_A217XT_LogTargetModule = new String[] {""} ;
         H004G2_n217XT_LogTargetModule = new bool[] {false} ;
         H004G2_A223XT_LogSonTarget = new String[] {""} ;
         H004G2_n223XT_LogSonTarget = new bool[] {false} ;
         H004G2_A216XT_LogTarget = new String[] {""} ;
         H004G2_n216XT_LogTarget = new bool[] {false} ;
         H004G2_A219XT_LogProviderName = new String[] {""} ;
         H004G2_n219XT_LogProviderName = new bool[] {false} ;
         H004G2_A215XT_LogProviderID = new long[1] ;
         H004G2_n215XT_LogProviderID = new bool[] {false} ;
         H004G2_A213XT_LogType = new String[] {""} ;
         H004G2_n213XT_LogType = new bool[] {false} ;
         H004G2_A177XT_LogButtonName = new String[] {""} ;
         H004G2_n177XT_LogButtonName = new bool[] {false} ;
         H004G2_A176XT_LogPage = new String[] {""} ;
         H004G2_n176XT_LogPage = new bool[] {false} ;
         H004G2_A220XT_LogTime = new DateTime[] {DateTime.MinValue} ;
         H004G2_n220XT_LogTime = new bool[] {false} ;
         H004G2_A174XT_LogSecUserName = new String[] {""} ;
         H004G2_n174XT_LogSecUserName = new bool[] {false} ;
         H004G2_A214XT_LogUserID = new long[1] ;
         H004G2_n214XT_LogUserID = new bool[] {false} ;
         H004G2_A173XT_LogID = new long[1] ;
         H004G3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         GXt_objcol_int2 = new GxSimpleCollection<long>();
         AV24WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         AV19Session = context.GetSession();
         AV11GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV22TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV13HTTPRequest = new GxHttpRequest( context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.xt_logww__default(),
            new Object[][] {
                new Object[] {
               H004G2_A221XT_LogDescription, H004G2_n221XT_LogDescription, H004G2_A218XT_LogTargetOperate, H004G2_n218XT_LogTargetOperate, H004G2_A222XT_LogTargetSonModule, H004G2_n222XT_LogTargetSonModule, H004G2_A217XT_LogTargetModule, H004G2_n217XT_LogTargetModule, H004G2_A223XT_LogSonTarget, H004G2_n223XT_LogSonTarget,
               H004G2_A216XT_LogTarget, H004G2_n216XT_LogTarget, H004G2_A219XT_LogProviderName, H004G2_n219XT_LogProviderName, H004G2_A215XT_LogProviderID, H004G2_n215XT_LogProviderID, H004G2_A213XT_LogType, H004G2_n213XT_LogType, H004G2_A177XT_LogButtonName, H004G2_n177XT_LogButtonName,
               H004G2_A176XT_LogPage, H004G2_n176XT_LogPage, H004G2_A220XT_LogTime, H004G2_n220XT_LogTime, H004G2_A174XT_LogSecUserName, H004G2_n174XT_LogSecUserName, H004G2_A214XT_LogUserID, H004G2_n214XT_LogUserID, H004G2_A173XT_LogID
               }
               , new Object[] {
               H004G3_AGRID_nRecordCount
               }
            }
         );
         AV40Pgmname = "XT_LogWW";
         /* GeneXus formulas. */
         AV40Pgmname = "XT_LogWW";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_29 ;
      private short nGXsfl_29_idx=1 ;
      private short GRID_nEOF ;
      private short AV15OrderedBy ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtXT_LogTargetModule_Titleformat ;
      private short edtXT_LogDescription_Titleformat ;
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
      private int edtavXt_logtargetmodule_Enabled ;
      private int edtavTdesrciption_Enabled ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_xt_logtargetmoduletitlecontrolidtoreplace_Visible ;
      private int edtavDdo_xt_logdescriptiontitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV17PageToGo ;
      private int AV41GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV8GridCurrentPage ;
      private long AV10GridRecordCount ;
      private long AV9GridPageSize ;
      private long A173XT_LogID ;
      private long A214XT_LogUserID ;
      private long A215XT_LogProviderID ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_xt_logtargetmodule_Activeeventkey ;
      private String Ddo_xt_logdescription_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_29_idx="0001" ;
      private String AV40Pgmname ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String Dvpanel_unnamedtable1_Width ;
      private String Dvpanel_unnamedtable1_Cls ;
      private String Dvpanel_unnamedtable1_Title ;
      private String Dvpanel_unnamedtable1_Iconposition ;
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
      private String Ddo_xt_logtargetmodule_Caption ;
      private String Ddo_xt_logtargetmodule_Tooltip ;
      private String Ddo_xt_logtargetmodule_Cls ;
      private String Ddo_xt_logtargetmodule_Dropdownoptionstype ;
      private String Ddo_xt_logtargetmodule_Titlecontrolidtoreplace ;
      private String Ddo_xt_logtargetmodule_Sortedstatus ;
      private String Ddo_xt_logtargetmodule_Sortasc ;
      private String Ddo_xt_logtargetmodule_Sortdsc ;
      private String Ddo_xt_logtargetmodule_Searchbuttontext ;
      private String Ddo_xt_logdescription_Caption ;
      private String Ddo_xt_logdescription_Tooltip ;
      private String Ddo_xt_logdescription_Cls ;
      private String Ddo_xt_logdescription_Dropdownoptionstype ;
      private String Ddo_xt_logdescription_Titlecontrolidtoreplace ;
      private String Ddo_xt_logdescription_Sortedstatus ;
      private String Ddo_xt_logdescription_Sortasc ;
      private String Ddo_xt_logdescription_Sortdsc ;
      private String Ddo_xt_logdescription_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divHtml_dvpanel_unnamedtable1_Internalname ;
      private String Dvpanel_unnamedtable1_Internalname ;
      private String divLayout_unnamedtable1_Internalname ;
      private String divUnnamedtable1_Internalname ;
      private String edtavXt_logtargetmodule_Internalname ;
      private String TempTags ;
      private String edtavXt_logtargetmodule_Jsonclick ;
      private String edtavTdesrciption_Internalname ;
      private String edtavTdesrciption_Jsonclick ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtXT_LogTargetModule_Title ;
      private String edtXT_LogDescription_Title ;
      private String subGrid_Header ;
      private String edtavDisplay_Link ;
      private String edtavDisplay_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_xt_logtargetmodule_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_xt_logtargetmoduletitlecontrolidtoreplace_Internalname ;
      private String Ddo_xt_logdescription_Internalname ;
      private String edtavDdo_xt_logdescriptiontitlecontrolidtoreplace_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDisplay_Internalname ;
      private String edtXT_LogID_Internalname ;
      private String edtXT_LogUserID_Internalname ;
      private String edtXT_LogSecUserName_Internalname ;
      private String edtXT_LogTime_Internalname ;
      private String cmbXT_LogPage_Internalname ;
      private String edtXT_LogButtonName_Internalname ;
      private String edtXT_LogType_Internalname ;
      private String edtXT_LogProviderID_Internalname ;
      private String edtXT_LogProviderName_Internalname ;
      private String edtXT_LogTarget_Internalname ;
      private String edtXT_LogSonTarget_Internalname ;
      private String edtXT_LogTargetModule_Internalname ;
      private String edtXT_LogTargetSonModule_Internalname ;
      private String cmbXT_LogTargetOperate_Internalname ;
      private String edtXT_LogDescription_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_29_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtXT_LogID_Jsonclick ;
      private String edtXT_LogUserID_Jsonclick ;
      private String edtXT_LogSecUserName_Jsonclick ;
      private String edtXT_LogTime_Jsonclick ;
      private String GXCCtl ;
      private String cmbXT_LogPage_Jsonclick ;
      private String edtXT_LogButtonName_Jsonclick ;
      private String edtXT_LogType_Jsonclick ;
      private String edtXT_LogProviderID_Jsonclick ;
      private String edtXT_LogProviderName_Jsonclick ;
      private String edtXT_LogTarget_Jsonclick ;
      private String edtXT_LogSonTarget_Jsonclick ;
      private String edtXT_LogTargetModule_Jsonclick ;
      private String edtXT_LogTargetSonModule_Jsonclick ;
      private String cmbXT_LogTargetOperate_Jsonclick ;
      private String edtXT_LogDescription_Jsonclick ;
      private DateTime A220XT_LogTime ;
      private bool entryPointCalled ;
      private bool AV16OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Dvpanel_unnamedtable1_Collapsible ;
      private bool Dvpanel_unnamedtable1_Collapsed ;
      private bool Dvpanel_unnamedtable1_Autowidth ;
      private bool Dvpanel_unnamedtable1_Autoheight ;
      private bool Dvpanel_unnamedtable1_Showcollapseicon ;
      private bool Dvpanel_unnamedtable1_Autoscroll ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_xt_logtargetmodule_Includesortasc ;
      private bool Ddo_xt_logtargetmodule_Includesortdsc ;
      private bool Ddo_xt_logtargetmodule_Includefilter ;
      private bool Ddo_xt_logtargetmodule_Includedatalist ;
      private bool Ddo_xt_logdescription_Includesortasc ;
      private bool Ddo_xt_logdescription_Includesortdsc ;
      private bool Ddo_xt_logdescription_Includefilter ;
      private bool Ddo_xt_logdescription_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_29_Refreshing=false ;
      private bool n214XT_LogUserID ;
      private bool n174XT_LogSecUserName ;
      private bool n220XT_LogTime ;
      private bool n176XT_LogPage ;
      private bool n177XT_LogButtonName ;
      private bool n213XT_LogType ;
      private bool n215XT_LogProviderID ;
      private bool n219XT_LogProviderName ;
      private bool n216XT_LogTarget ;
      private bool n223XT_LogSonTarget ;
      private bool n217XT_LogTargetModule ;
      private bool n222XT_LogTargetSonModule ;
      private bool n218XT_LogTargetOperate ;
      private bool n221XT_LogDescription ;
      private bool gxdyncontrolsrefreshing ;
      private bool AV34IsRocheUser ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool GXt_boolean3 ;
      private bool AV7Display_IsBlob ;
      private String AV27XT_LogTargetModule ;
      private String AV28tDesrciption ;
      private String AV32ddo_XT_LogTargetModuleTitleControlIdToReplace ;
      private String AV6ddo_XT_LogDescriptionTitleControlIdToReplace ;
      private String A174XT_LogSecUserName ;
      private String A176XT_LogPage ;
      private String A177XT_LogButtonName ;
      private String A213XT_LogType ;
      private String A219XT_LogProviderName ;
      private String A216XT_LogTarget ;
      private String A223XT_LogSonTarget ;
      private String A217XT_LogTargetModule ;
      private String A222XT_LogTargetSonModule ;
      private String A218XT_LogTargetOperate ;
      private String A221XT_LogDescription ;
      private String AV39Display_GXI ;
      private String lV38XT_LogWWDS_1_Xt_logtargetmodule ;
      private String lV28tDesrciption ;
      private String AV38XT_LogWWDS_1_Xt_logtargetmodule ;
      private String AV7Display ;
      private GxSimpleCollection<long> AV35tJC_ProviderIDs ;
      private GxSimpleCollection<long> GXt_objcol_int2 ;
      private IGxSession AV19Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_unnamedtable1 ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_xt_logtargetmodule ;
      private GXUserControl ucDdo_xt_logdescription ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbXT_LogPage ;
      private GXCombobox cmbXT_LogTargetOperate ;
      private IDataStoreProvider pr_default ;
      private String[] H004G2_A221XT_LogDescription ;
      private bool[] H004G2_n221XT_LogDescription ;
      private String[] H004G2_A218XT_LogTargetOperate ;
      private bool[] H004G2_n218XT_LogTargetOperate ;
      private String[] H004G2_A222XT_LogTargetSonModule ;
      private bool[] H004G2_n222XT_LogTargetSonModule ;
      private String[] H004G2_A217XT_LogTargetModule ;
      private bool[] H004G2_n217XT_LogTargetModule ;
      private String[] H004G2_A223XT_LogSonTarget ;
      private bool[] H004G2_n223XT_LogSonTarget ;
      private String[] H004G2_A216XT_LogTarget ;
      private bool[] H004G2_n216XT_LogTarget ;
      private String[] H004G2_A219XT_LogProviderName ;
      private bool[] H004G2_n219XT_LogProviderName ;
      private long[] H004G2_A215XT_LogProviderID ;
      private bool[] H004G2_n215XT_LogProviderID ;
      private String[] H004G2_A213XT_LogType ;
      private bool[] H004G2_n213XT_LogType ;
      private String[] H004G2_A177XT_LogButtonName ;
      private bool[] H004G2_n177XT_LogButtonName ;
      private String[] H004G2_A176XT_LogPage ;
      private bool[] H004G2_n176XT_LogPage ;
      private DateTime[] H004G2_A220XT_LogTime ;
      private bool[] H004G2_n220XT_LogTime ;
      private String[] H004G2_A174XT_LogSecUserName ;
      private bool[] H004G2_n174XT_LogSecUserName ;
      private long[] H004G2_A214XT_LogUserID ;
      private bool[] H004G2_n214XT_LogUserID ;
      private long[] H004G2_A173XT_LogID ;
      private long[] H004G3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV13HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV29XT_LogTargetModuleTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV26XT_LogDescriptionTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV5DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV11GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV12GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV22TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV24WWPContext ;
   }

   public class xt_logww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H004G2( IGxContext context ,
                                             long A215XT_LogProviderID ,
                                             GxSimpleCollection<long> AV35tJC_ProviderIDs ,
                                             String AV38XT_LogWWDS_1_Xt_logtargetmodule ,
                                             String AV28tDesrciption ,
                                             bool AV34IsRocheUser ,
                                             String A217XT_LogTargetModule ,
                                             String A221XT_LogDescription ,
                                             short AV15OrderedBy ,
                                             bool AV16OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [5] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [XT_LogDescription], [XT_LogTargetOperate], [XT_LogTargetSonModule], [XT_LogTargetModule], [XT_LogSonTarget], [XT_LogTarget], [XT_LogProviderName], [XT_LogProviderID], [XT_LogType], [XT_LogButtonName], [XT_LogPage], [XT_LogTime], [XT_LogSecUserName], [XT_LogUserID], [XT_LogID]";
         sFromString = " FROM [XT_Log] WITH (NOLOCK)";
         sOrderString = "";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV38XT_LogWWDS_1_Xt_logtargetmodule)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_LogTargetModule] like '%' + @lV38XT_LogWWDS_1_Xt_logtargetmodule + '%')";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_LogTargetModule] like '%' + @lV38XT_LogWWDS_1_Xt_logtargetmodule + '%')";
            }
         }
         else
         {
            GXv_int4[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV28tDesrciption)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_LogDescription] like '%' + @lV28tDesrciption + '%')";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_LogDescription] like '%' + @lV28tDesrciption + '%')";
            }
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( ! AV34IsRocheUser )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV35tJC_ProviderIDs, "[XT_LogProviderID] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV35tJC_ProviderIDs, "[XT_LogProviderID] IN (", ")") + ")";
            }
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         if ( AV15OrderedBy == 1 )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogID] DESC";
         }
         else if ( ( AV15OrderedBy == 2 ) && ! AV16OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogTargetModule]";
         }
         else if ( ( AV15OrderedBy == 2 ) && ( AV16OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogTargetModule] DESC";
         }
         else if ( ( AV15OrderedBy == 3 ) && ! AV16OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogDescription]";
         }
         else if ( ( AV15OrderedBy == 3 ) && ( AV16OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogDescription] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object5[0] = scmdbuf;
         GXv_Object5[1] = GXv_int4;
         return GXv_Object5 ;
      }

      protected Object[] conditional_H004G3( IGxContext context ,
                                             long A215XT_LogProviderID ,
                                             GxSimpleCollection<long> AV35tJC_ProviderIDs ,
                                             String AV38XT_LogWWDS_1_Xt_logtargetmodule ,
                                             String AV28tDesrciption ,
                                             bool AV34IsRocheUser ,
                                             String A217XT_LogTargetModule ,
                                             String A221XT_LogDescription ,
                                             short AV15OrderedBy ,
                                             bool AV16OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int6 ;
         GXv_int6 = new short [2] ;
         Object[] GXv_Object7 ;
         GXv_Object7 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [XT_Log] WITH (NOLOCK)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV38XT_LogWWDS_1_Xt_logtargetmodule)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_LogTargetModule] like '%' + @lV38XT_LogWWDS_1_Xt_logtargetmodule + '%')";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_LogTargetModule] like '%' + @lV38XT_LogWWDS_1_Xt_logtargetmodule + '%')";
            }
         }
         else
         {
            GXv_int6[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV28tDesrciption)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_LogDescription] like '%' + @lV28tDesrciption + '%')";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_LogDescription] like '%' + @lV28tDesrciption + '%')";
            }
         }
         else
         {
            GXv_int6[1] = 1;
         }
         if ( ! AV34IsRocheUser )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV35tJC_ProviderIDs, "[XT_LogProviderID] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV35tJC_ProviderIDs, "[XT_LogProviderID] IN (", ")") + ")";
            }
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         if ( AV15OrderedBy == 1 )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV15OrderedBy == 2 ) && ! AV16OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV15OrderedBy == 2 ) && ( AV16OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV15OrderedBy == 3 ) && ! AV16OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV15OrderedBy == 3 ) && ( AV16OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( true )
         {
            scmdbuf = scmdbuf + "";
         }
         GXv_Object7[0] = scmdbuf;
         GXv_Object7[1] = GXv_int6;
         return GXv_Object7 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H004G2(context, (long)dynConstraints[0] , (GxSimpleCollection<long>)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (bool)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (short)dynConstraints[7] , (bool)dynConstraints[8] );
               case 1 :
                     return conditional_H004G3(context, (long)dynConstraints[0] , (GxSimpleCollection<long>)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (bool)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (short)dynConstraints[7] , (bool)dynConstraints[8] );
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
          Object[] prmH004G2 ;
          prmH004G2 = new Object[] {
          new Object[] {"@lV38XT_LogWWDS_1_Xt_logtargetmodule",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV28tDesrciption",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH004G3 ;
          prmH004G3 = new Object[] {
          new Object[] {"@lV38XT_LogWWDS_1_Xt_logtargetmodule",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV28tDesrciption",SqlDbType.NVarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H004G2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH004G2,11,0,true,false )
             ,new CursorDef("H004G3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH004G3,1,0,true,false )
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
                ((long[]) buf[14])[0] = rslt.getLong(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((String[]) buf[18])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((String[]) buf[20])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((DateTime[]) buf[22])[0] = rslt.getGXDateTime(12) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(12);
                ((String[]) buf[24])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(13);
                ((long[]) buf[26])[0] = rslt.getLong(14) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(14);
                ((long[]) buf[28])[0] = rslt.getLong(15) ;
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
                   stmt.SetParameter(sIdx, (String)parms[5]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[6]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[7]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[8]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[9]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[2]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[3]);
                }
                return;
       }
    }

 }

}
