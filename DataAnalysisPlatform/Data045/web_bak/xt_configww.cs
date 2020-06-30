/*
               File: XT_ConfigWW
        Description:  系统配置表
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:46:31.32
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
   public class xt_configww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public xt_configww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public xt_configww( IGxContext context )
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
               nRC_GXsfl_28 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_28_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_28_idx = GetNextPar( );
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
               AV17TFXT_ConfigID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV18TFXT_ConfigID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV21TFXT_ConfigKey = GetNextPar( );
               AV22TFXT_ConfigKey_Sel = GetNextPar( );
               AV25TFXT_ConfigValue1 = GetNextPar( );
               AV26TFXT_ConfigValue1_Sel = GetNextPar( );
               AV29TFXT_ConfigValue2 = GetNextPar( );
               AV30TFXT_ConfigValue2_Sel = GetNextPar( );
               AV19ddo_XT_ConfigIDTitleControlIdToReplace = GetNextPar( );
               AV23ddo_XT_ConfigKeyTitleControlIdToReplace = GetNextPar( );
               AV27ddo_XT_ConfigValue1TitleControlIdToReplace = GetNextPar( );
               AV31ddo_XT_ConfigValue2TitleControlIdToReplace = GetNextPar( );
               AV56Pgmname = GetNextPar( );
               AV39IsAuthorized_Update = StringUtil.StrToBool( GetNextPar( ));
               AV41IsAuthorized_Delete = StringUtil.StrToBool( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFXT_ConfigID, AV18TFXT_ConfigID_To, AV21TFXT_ConfigKey, AV22TFXT_ConfigKey_Sel, AV25TFXT_ConfigValue1, AV26TFXT_ConfigValue1_Sel, AV29TFXT_ConfigValue2, AV30TFXT_ConfigValue2_Sel, AV19ddo_XT_ConfigIDTitleControlIdToReplace, AV23ddo_XT_ConfigKeyTitleControlIdToReplace, AV27ddo_XT_ConfigValue1TitleControlIdToReplace, AV31ddo_XT_ConfigValue2TitleControlIdToReplace, AV56Pgmname, AV39IsAuthorized_Update, AV41IsAuthorized_Delete) ;
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
         PA6X2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START6X2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202279463153", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("xt_configww.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vTFXT_CONFIGID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFXT_ConfigID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFXT_CONFIGID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFXT_ConfigID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFXT_CONFIGKEY", AV21TFXT_ConfigKey);
         GxWebStd.gx_hidden_field( context, "GXH_vTFXT_CONFIGKEY_SEL", AV22TFXT_ConfigKey_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFXT_CONFIGVALUE1", AV25TFXT_ConfigValue1);
         GxWebStd.gx_hidden_field( context, "GXH_vTFXT_CONFIGVALUE1_SEL", AV26TFXT_ConfigValue1_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFXT_CONFIGVALUE2", AV29TFXT_ConfigValue2);
         GxWebStd.gx_hidden_field( context, "GXH_vTFXT_CONFIGVALUE2_SEL", AV30TFXT_ConfigValue2_Sel);
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_28", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_28), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV34GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV36GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV35GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV32DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV32DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_CONFIGIDTITLEFILTERDATA", AV16XT_ConfigIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_CONFIGIDTITLEFILTERDATA", AV16XT_ConfigIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_CONFIGKEYTITLEFILTERDATA", AV20XT_ConfigKeyTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_CONFIGKEYTITLEFILTERDATA", AV20XT_ConfigKeyTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_CONFIGVALUE1TITLEFILTERDATA", AV24XT_ConfigValue1TitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_CONFIGVALUE1TITLEFILTERDATA", AV24XT_ConfigValue1TitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_CONFIGVALUE2TITLEFILTERDATA", AV28XT_ConfigValue2TitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_CONFIGVALUE2TITLEFILTERDATA", AV28XT_ConfigValue2TitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV56Pgmname));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_UPDATE", AV39IsAuthorized_Update);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_DELETE", AV41IsAuthorized_Delete);
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
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Caption", StringUtil.RTrim( Ddo_xt_configid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Tooltip", StringUtil.RTrim( Ddo_xt_configid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Cls", StringUtil.RTrim( Ddo_xt_configid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Filteredtext_set", StringUtil.RTrim( Ddo_xt_configid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Filteredtextto_set", StringUtil.RTrim( Ddo_xt_configid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_configid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_configid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Includesortasc", StringUtil.BoolToStr( Ddo_xt_configid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_configid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Sortedstatus", StringUtil.RTrim( Ddo_xt_configid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Includefilter", StringUtil.BoolToStr( Ddo_xt_configid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Filtertype", StringUtil.RTrim( Ddo_xt_configid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Filterisrange", StringUtil.BoolToStr( Ddo_xt_configid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Includedatalist", StringUtil.BoolToStr( Ddo_xt_configid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Sortasc", StringUtil.RTrim( Ddo_xt_configid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Sortdsc", StringUtil.RTrim( Ddo_xt_configid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Cleanfilter", StringUtil.RTrim( Ddo_xt_configid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Rangefilterfrom", StringUtil.RTrim( Ddo_xt_configid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Rangefilterto", StringUtil.RTrim( Ddo_xt_configid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Searchbuttontext", StringUtil.RTrim( Ddo_xt_configid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Caption", StringUtil.RTrim( Ddo_xt_configkey_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Tooltip", StringUtil.RTrim( Ddo_xt_configkey_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Cls", StringUtil.RTrim( Ddo_xt_configkey_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Filteredtext_set", StringUtil.RTrim( Ddo_xt_configkey_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Selectedvalue_set", StringUtil.RTrim( Ddo_xt_configkey_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_configkey_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_configkey_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Includesortasc", StringUtil.BoolToStr( Ddo_xt_configkey_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_configkey_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Sortedstatus", StringUtil.RTrim( Ddo_xt_configkey_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Includefilter", StringUtil.BoolToStr( Ddo_xt_configkey_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Filtertype", StringUtil.RTrim( Ddo_xt_configkey_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Filterisrange", StringUtil.BoolToStr( Ddo_xt_configkey_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Includedatalist", StringUtil.BoolToStr( Ddo_xt_configkey_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Datalisttype", StringUtil.RTrim( Ddo_xt_configkey_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Datalistproc", StringUtil.RTrim( Ddo_xt_configkey_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_xt_configkey_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Sortasc", StringUtil.RTrim( Ddo_xt_configkey_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Sortdsc", StringUtil.RTrim( Ddo_xt_configkey_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Loadingdata", StringUtil.RTrim( Ddo_xt_configkey_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Cleanfilter", StringUtil.RTrim( Ddo_xt_configkey_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Noresultsfound", StringUtil.RTrim( Ddo_xt_configkey_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Searchbuttontext", StringUtil.RTrim( Ddo_xt_configkey_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Caption", StringUtil.RTrim( Ddo_xt_configvalue1_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Tooltip", StringUtil.RTrim( Ddo_xt_configvalue1_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Cls", StringUtil.RTrim( Ddo_xt_configvalue1_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Filteredtext_set", StringUtil.RTrim( Ddo_xt_configvalue1_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Selectedvalue_set", StringUtil.RTrim( Ddo_xt_configvalue1_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_configvalue1_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_configvalue1_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Includesortasc", StringUtil.BoolToStr( Ddo_xt_configvalue1_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_configvalue1_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Sortedstatus", StringUtil.RTrim( Ddo_xt_configvalue1_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Includefilter", StringUtil.BoolToStr( Ddo_xt_configvalue1_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Filtertype", StringUtil.RTrim( Ddo_xt_configvalue1_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Filterisrange", StringUtil.BoolToStr( Ddo_xt_configvalue1_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Includedatalist", StringUtil.BoolToStr( Ddo_xt_configvalue1_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Datalisttype", StringUtil.RTrim( Ddo_xt_configvalue1_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Datalistproc", StringUtil.RTrim( Ddo_xt_configvalue1_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_xt_configvalue1_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Sortasc", StringUtil.RTrim( Ddo_xt_configvalue1_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Sortdsc", StringUtil.RTrim( Ddo_xt_configvalue1_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Loadingdata", StringUtil.RTrim( Ddo_xt_configvalue1_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Cleanfilter", StringUtil.RTrim( Ddo_xt_configvalue1_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Noresultsfound", StringUtil.RTrim( Ddo_xt_configvalue1_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Searchbuttontext", StringUtil.RTrim( Ddo_xt_configvalue1_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Caption", StringUtil.RTrim( Ddo_xt_configvalue2_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Tooltip", StringUtil.RTrim( Ddo_xt_configvalue2_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Cls", StringUtil.RTrim( Ddo_xt_configvalue2_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Filteredtext_set", StringUtil.RTrim( Ddo_xt_configvalue2_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Selectedvalue_set", StringUtil.RTrim( Ddo_xt_configvalue2_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_configvalue2_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_configvalue2_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Includesortasc", StringUtil.BoolToStr( Ddo_xt_configvalue2_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_configvalue2_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Sortedstatus", StringUtil.RTrim( Ddo_xt_configvalue2_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Includefilter", StringUtil.BoolToStr( Ddo_xt_configvalue2_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Filtertype", StringUtil.RTrim( Ddo_xt_configvalue2_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Filterisrange", StringUtil.BoolToStr( Ddo_xt_configvalue2_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Includedatalist", StringUtil.BoolToStr( Ddo_xt_configvalue2_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Datalisttype", StringUtil.RTrim( Ddo_xt_configvalue2_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Datalistproc", StringUtil.RTrim( Ddo_xt_configvalue2_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_xt_configvalue2_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Sortasc", StringUtil.RTrim( Ddo_xt_configvalue2_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Sortdsc", StringUtil.RTrim( Ddo_xt_configvalue2_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Loadingdata", StringUtil.RTrim( Ddo_xt_configvalue2_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Cleanfilter", StringUtil.RTrim( Ddo_xt_configvalue2_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Noresultsfound", StringUtil.RTrim( Ddo_xt_configvalue2_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Searchbuttontext", StringUtil.RTrim( Ddo_xt_configvalue2_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Activeeventkey", StringUtil.RTrim( Ddo_xt_configid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Filteredtext_get", StringUtil.RTrim( Ddo_xt_configid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Filteredtextto_get", StringUtil.RTrim( Ddo_xt_configid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Activeeventkey", StringUtil.RTrim( Ddo_xt_configkey_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Filteredtext_get", StringUtil.RTrim( Ddo_xt_configkey_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Selectedvalue_get", StringUtil.RTrim( Ddo_xt_configkey_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Activeeventkey", StringUtil.RTrim( Ddo_xt_configvalue1_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Filteredtext_get", StringUtil.RTrim( Ddo_xt_configvalue1_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Selectedvalue_get", StringUtil.RTrim( Ddo_xt_configvalue1_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Activeeventkey", StringUtil.RTrim( Ddo_xt_configvalue2_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Filteredtext_get", StringUtil.RTrim( Ddo_xt_configvalue2_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Selectedvalue_get", StringUtil.RTrim( Ddo_xt_configvalue2_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Activeeventkey", StringUtil.RTrim( Ddo_xt_configid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Filteredtext_get", StringUtil.RTrim( Ddo_xt_configid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Filteredtextto_get", StringUtil.RTrim( Ddo_xt_configid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Activeeventkey", StringUtil.RTrim( Ddo_xt_configkey_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Filteredtext_get", StringUtil.RTrim( Ddo_xt_configkey_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Selectedvalue_get", StringUtil.RTrim( Ddo_xt_configkey_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Activeeventkey", StringUtil.RTrim( Ddo_xt_configvalue1_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Filteredtext_get", StringUtil.RTrim( Ddo_xt_configvalue1_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Selectedvalue_get", StringUtil.RTrim( Ddo_xt_configvalue1_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Activeeventkey", StringUtil.RTrim( Ddo_xt_configvalue2_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Filteredtext_get", StringUtil.RTrim( Ddo_xt_configvalue2_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Selectedvalue_get", StringUtil.RTrim( Ddo_xt_configvalue2_Selectedvalue_get));
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
            WE6X2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT6X2( ) ;
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
         return formatLink("xt_configww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "XT_ConfigWW" ;
      }

      public override String GetPgmdesc( )
      {
         return " 系统配置表" ;
      }

      protected void WB6X0( )
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
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(28), 2, 0)+","+"null"+");", "新增", bttBtninsert_Jsonclick, 5, "插入", "", StyleString, ClassString, bttBtninsert_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_XT_ConfigWW.htm");
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"28\">") ;
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
               if ( edtXT_ConfigID_Titleformat == 0 )
               {
                  context.SendWebValue( edtXT_ConfigID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtXT_ConfigID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtXT_ConfigKey_Titleformat == 0 )
               {
                  context.SendWebValue( edtXT_ConfigKey_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtXT_ConfigKey_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtXT_ConfigValue1_Titleformat == 0 )
               {
                  context.SendWebValue( edtXT_ConfigValue1_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtXT_ConfigValue1_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtXT_ConfigValue2_Titleformat == 0 )
               {
                  context.SendWebValue( edtXT_ConfigValue2_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtXT_ConfigValue2_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV37Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV38Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV40Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A195XT_ConfigID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtXT_ConfigID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtXT_ConfigID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A196XT_ConfigKey);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtXT_ConfigKey_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtXT_ConfigKey_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtXT_ConfigKey_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A197XT_ConfigValue1);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtXT_ConfigValue1_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtXT_ConfigValue1_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A198XT_ConfigValue2);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtXT_ConfigValue2_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtXT_ConfigValue2_Titleformat), 4, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV34GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV36GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV35GridPageSize);
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
            ucDdo_xt_configid.SetProperty("Caption", Ddo_xt_configid_Caption);
            ucDdo_xt_configid.SetProperty("Tooltip", Ddo_xt_configid_Tooltip);
            ucDdo_xt_configid.SetProperty("Cls", Ddo_xt_configid_Cls);
            ucDdo_xt_configid.SetProperty("DropDownOptionsType", Ddo_xt_configid_Dropdownoptionstype);
            ucDdo_xt_configid.SetProperty("IncludeSortASC", Ddo_xt_configid_Includesortasc);
            ucDdo_xt_configid.SetProperty("IncludeSortDSC", Ddo_xt_configid_Includesortdsc);
            ucDdo_xt_configid.SetProperty("IncludeFilter", Ddo_xt_configid_Includefilter);
            ucDdo_xt_configid.SetProperty("FilterType", Ddo_xt_configid_Filtertype);
            ucDdo_xt_configid.SetProperty("FilterIsRange", Ddo_xt_configid_Filterisrange);
            ucDdo_xt_configid.SetProperty("IncludeDataList", Ddo_xt_configid_Includedatalist);
            ucDdo_xt_configid.SetProperty("SortASC", Ddo_xt_configid_Sortasc);
            ucDdo_xt_configid.SetProperty("SortDSC", Ddo_xt_configid_Sortdsc);
            ucDdo_xt_configid.SetProperty("CleanFilter", Ddo_xt_configid_Cleanfilter);
            ucDdo_xt_configid.SetProperty("RangeFilterFrom", Ddo_xt_configid_Rangefilterfrom);
            ucDdo_xt_configid.SetProperty("RangeFilterTo", Ddo_xt_configid_Rangefilterto);
            ucDdo_xt_configid.SetProperty("SearchButtonText", Ddo_xt_configid_Searchbuttontext);
            ucDdo_xt_configid.SetProperty("DropDownOptionsTitleSettingsIcons", AV32DDO_TitleSettingsIcons);
            ucDdo_xt_configid.SetProperty("DropDownOptionsData", AV16XT_ConfigIDTitleFilterData);
            ucDdo_xt_configid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_configid_Internalname, "DDO_XT_CONFIGIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_configidtitlecontrolidtoreplace_Internalname, AV19ddo_XT_ConfigIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", 0, edtavDdo_xt_configidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_ConfigWW.htm");
            /* User Defined Control */
            ucDdo_xt_configkey.SetProperty("Caption", Ddo_xt_configkey_Caption);
            ucDdo_xt_configkey.SetProperty("Tooltip", Ddo_xt_configkey_Tooltip);
            ucDdo_xt_configkey.SetProperty("Cls", Ddo_xt_configkey_Cls);
            ucDdo_xt_configkey.SetProperty("DropDownOptionsType", Ddo_xt_configkey_Dropdownoptionstype);
            ucDdo_xt_configkey.SetProperty("IncludeSortASC", Ddo_xt_configkey_Includesortasc);
            ucDdo_xt_configkey.SetProperty("IncludeSortDSC", Ddo_xt_configkey_Includesortdsc);
            ucDdo_xt_configkey.SetProperty("IncludeFilter", Ddo_xt_configkey_Includefilter);
            ucDdo_xt_configkey.SetProperty("FilterType", Ddo_xt_configkey_Filtertype);
            ucDdo_xt_configkey.SetProperty("FilterIsRange", Ddo_xt_configkey_Filterisrange);
            ucDdo_xt_configkey.SetProperty("IncludeDataList", Ddo_xt_configkey_Includedatalist);
            ucDdo_xt_configkey.SetProperty("DataListType", Ddo_xt_configkey_Datalisttype);
            ucDdo_xt_configkey.SetProperty("DataListProc", Ddo_xt_configkey_Datalistproc);
            ucDdo_xt_configkey.SetProperty("DataListUpdateMinimumCharacters", Ddo_xt_configkey_Datalistupdateminimumcharacters);
            ucDdo_xt_configkey.SetProperty("SortASC", Ddo_xt_configkey_Sortasc);
            ucDdo_xt_configkey.SetProperty("SortDSC", Ddo_xt_configkey_Sortdsc);
            ucDdo_xt_configkey.SetProperty("LoadingData", Ddo_xt_configkey_Loadingdata);
            ucDdo_xt_configkey.SetProperty("CleanFilter", Ddo_xt_configkey_Cleanfilter);
            ucDdo_xt_configkey.SetProperty("NoResultsFound", Ddo_xt_configkey_Noresultsfound);
            ucDdo_xt_configkey.SetProperty("SearchButtonText", Ddo_xt_configkey_Searchbuttontext);
            ucDdo_xt_configkey.SetProperty("DropDownOptionsTitleSettingsIcons", AV32DDO_TitleSettingsIcons);
            ucDdo_xt_configkey.SetProperty("DropDownOptionsData", AV20XT_ConfigKeyTitleFilterData);
            ucDdo_xt_configkey.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_configkey_Internalname, "DDO_XT_CONFIGKEYContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_configkeytitlecontrolidtoreplace_Internalname, AV23ddo_XT_ConfigKeyTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", 0, edtavDdo_xt_configkeytitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_ConfigWW.htm");
            /* User Defined Control */
            ucDdo_xt_configvalue1.SetProperty("Caption", Ddo_xt_configvalue1_Caption);
            ucDdo_xt_configvalue1.SetProperty("Tooltip", Ddo_xt_configvalue1_Tooltip);
            ucDdo_xt_configvalue1.SetProperty("Cls", Ddo_xt_configvalue1_Cls);
            ucDdo_xt_configvalue1.SetProperty("DropDownOptionsType", Ddo_xt_configvalue1_Dropdownoptionstype);
            ucDdo_xt_configvalue1.SetProperty("IncludeSortASC", Ddo_xt_configvalue1_Includesortasc);
            ucDdo_xt_configvalue1.SetProperty("IncludeSortDSC", Ddo_xt_configvalue1_Includesortdsc);
            ucDdo_xt_configvalue1.SetProperty("IncludeFilter", Ddo_xt_configvalue1_Includefilter);
            ucDdo_xt_configvalue1.SetProperty("FilterType", Ddo_xt_configvalue1_Filtertype);
            ucDdo_xt_configvalue1.SetProperty("FilterIsRange", Ddo_xt_configvalue1_Filterisrange);
            ucDdo_xt_configvalue1.SetProperty("IncludeDataList", Ddo_xt_configvalue1_Includedatalist);
            ucDdo_xt_configvalue1.SetProperty("DataListType", Ddo_xt_configvalue1_Datalisttype);
            ucDdo_xt_configvalue1.SetProperty("DataListProc", Ddo_xt_configvalue1_Datalistproc);
            ucDdo_xt_configvalue1.SetProperty("DataListUpdateMinimumCharacters", Ddo_xt_configvalue1_Datalistupdateminimumcharacters);
            ucDdo_xt_configvalue1.SetProperty("SortASC", Ddo_xt_configvalue1_Sortasc);
            ucDdo_xt_configvalue1.SetProperty("SortDSC", Ddo_xt_configvalue1_Sortdsc);
            ucDdo_xt_configvalue1.SetProperty("LoadingData", Ddo_xt_configvalue1_Loadingdata);
            ucDdo_xt_configvalue1.SetProperty("CleanFilter", Ddo_xt_configvalue1_Cleanfilter);
            ucDdo_xt_configvalue1.SetProperty("NoResultsFound", Ddo_xt_configvalue1_Noresultsfound);
            ucDdo_xt_configvalue1.SetProperty("SearchButtonText", Ddo_xt_configvalue1_Searchbuttontext);
            ucDdo_xt_configvalue1.SetProperty("DropDownOptionsTitleSettingsIcons", AV32DDO_TitleSettingsIcons);
            ucDdo_xt_configvalue1.SetProperty("DropDownOptionsData", AV24XT_ConfigValue1TitleFilterData);
            ucDdo_xt_configvalue1.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_configvalue1_Internalname, "DDO_XT_CONFIGVALUE1Container");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_configvalue1titlecontrolidtoreplace_Internalname, AV27ddo_XT_ConfigValue1TitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", 0, edtavDdo_xt_configvalue1titlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_ConfigWW.htm");
            /* User Defined Control */
            ucDdo_xt_configvalue2.SetProperty("Caption", Ddo_xt_configvalue2_Caption);
            ucDdo_xt_configvalue2.SetProperty("Tooltip", Ddo_xt_configvalue2_Tooltip);
            ucDdo_xt_configvalue2.SetProperty("Cls", Ddo_xt_configvalue2_Cls);
            ucDdo_xt_configvalue2.SetProperty("DropDownOptionsType", Ddo_xt_configvalue2_Dropdownoptionstype);
            ucDdo_xt_configvalue2.SetProperty("IncludeSortASC", Ddo_xt_configvalue2_Includesortasc);
            ucDdo_xt_configvalue2.SetProperty("IncludeSortDSC", Ddo_xt_configvalue2_Includesortdsc);
            ucDdo_xt_configvalue2.SetProperty("IncludeFilter", Ddo_xt_configvalue2_Includefilter);
            ucDdo_xt_configvalue2.SetProperty("FilterType", Ddo_xt_configvalue2_Filtertype);
            ucDdo_xt_configvalue2.SetProperty("FilterIsRange", Ddo_xt_configvalue2_Filterisrange);
            ucDdo_xt_configvalue2.SetProperty("IncludeDataList", Ddo_xt_configvalue2_Includedatalist);
            ucDdo_xt_configvalue2.SetProperty("DataListType", Ddo_xt_configvalue2_Datalisttype);
            ucDdo_xt_configvalue2.SetProperty("DataListProc", Ddo_xt_configvalue2_Datalistproc);
            ucDdo_xt_configvalue2.SetProperty("DataListUpdateMinimumCharacters", Ddo_xt_configvalue2_Datalistupdateminimumcharacters);
            ucDdo_xt_configvalue2.SetProperty("SortASC", Ddo_xt_configvalue2_Sortasc);
            ucDdo_xt_configvalue2.SetProperty("SortDSC", Ddo_xt_configvalue2_Sortdsc);
            ucDdo_xt_configvalue2.SetProperty("LoadingData", Ddo_xt_configvalue2_Loadingdata);
            ucDdo_xt_configvalue2.SetProperty("CleanFilter", Ddo_xt_configvalue2_Cleanfilter);
            ucDdo_xt_configvalue2.SetProperty("NoResultsFound", Ddo_xt_configvalue2_Noresultsfound);
            ucDdo_xt_configvalue2.SetProperty("SearchButtonText", Ddo_xt_configvalue2_Searchbuttontext);
            ucDdo_xt_configvalue2.SetProperty("DropDownOptionsTitleSettingsIcons", AV32DDO_TitleSettingsIcons);
            ucDdo_xt_configvalue2.SetProperty("DropDownOptionsData", AV28XT_ConfigValue2TitleFilterData);
            ucDdo_xt_configvalue2.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_configvalue2_Internalname, "DDO_XT_CONFIGVALUE2Container");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_configvalue2titlecontrolidtoreplace_Internalname, AV31ddo_XT_ConfigValue2TitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", 0, edtavDdo_xt_configvalue2titlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_ConfigWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_XT_ConfigWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_XT_ConfigWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfxt_configid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFXT_ConfigID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV17TFXT_ConfigID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfxt_configid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfxt_configid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_XT_ConfigWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfxt_configid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFXT_ConfigID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV18TFXT_ConfigID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfxt_configid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfxt_configid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_XT_ConfigWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfxt_configkey_Internalname, AV21TFXT_ConfigKey, StringUtil.RTrim( context.localUtil.Format( AV21TFXT_ConfigKey, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfxt_configkey_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfxt_configkey_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_ConfigWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfxt_configkey_sel_Internalname, AV22TFXT_ConfigKey_Sel, StringUtil.RTrim( context.localUtil.Format( AV22TFXT_ConfigKey_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfxt_configkey_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfxt_configkey_sel_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_ConfigWW.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfxt_configvalue1_Internalname, AV25TFXT_ConfigValue1, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", 0, edtavTfxt_configvalue1_Visible, 1, 0, 80, "chr", 3, "row", StyleString, ClassString, "", "", "200", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_ConfigWW.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfxt_configvalue1_sel_Internalname, AV26TFXT_ConfigValue1_Sel, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", 0, edtavTfxt_configvalue1_sel_Visible, 1, 0, 80, "chr", 3, "row", StyleString, ClassString, "", "", "200", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_ConfigWW.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfxt_configvalue2_Internalname, AV29TFXT_ConfigValue2, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,60);\"", 0, edtavTfxt_configvalue2_Visible, 1, 0, 80, "chr", 3, "row", StyleString, ClassString, "", "", "200", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_ConfigWW.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfxt_configvalue2_sel_Internalname, AV30TFXT_ConfigValue2_Sel, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,61);\"", 0, edtavTfxt_configvalue2_sel_Visible, 1, 0, 80, "chr", 3, "row", StyleString, ClassString, "", "", "200", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_ConfigWW.htm");
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

      protected void START6X2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", " 系统配置表", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP6X0( ) ;
      }

      protected void WS6X2( )
      {
         START6X2( ) ;
         EVT6X2( ) ;
      }

      protected void EVT6X2( )
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
                              E116X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E126X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_XT_CONFIGID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E136X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_XT_CONFIGKEY.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E146X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_XT_CONFIGVALUE1.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E156X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_XT_CONFIGVALUE2.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E166X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E176X2 ();
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
                              nGXsfl_28_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
                              SubsflControlProps_282( ) ;
                              AV37Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV37Display)) ? AV53Display_GXI : context.convertURL( context.PathToRelativeUrl( AV37Display))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV37Display), true);
                              AV38Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV38Update)) ? AV54Update_GXI : context.convertURL( context.PathToRelativeUrl( AV38Update))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV38Update), true);
                              AV40Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV40Delete)) ? AV55Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV40Delete))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV40Delete), true);
                              A195XT_ConfigID = (long)(context.localUtil.CToN( cgiGet( edtXT_ConfigID_Internalname), ".", ","));
                              A196XT_ConfigKey = cgiGet( edtXT_ConfigKey_Internalname);
                              n196XT_ConfigKey = false;
                              A197XT_ConfigValue1 = cgiGet( edtXT_ConfigValue1_Internalname);
                              n197XT_ConfigValue1 = false;
                              A198XT_ConfigValue2 = cgiGet( edtXT_ConfigValue2_Internalname);
                              n198XT_ConfigValue2 = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E186X2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E196X2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E206X2 ();
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
                                       /* Set Refresh If Tfxt_configid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFXT_CONFIGID"), ".", ",") != Convert.ToDecimal( AV17TFXT_ConfigID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfxt_configid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFXT_CONFIGID_TO"), ".", ",") != Convert.ToDecimal( AV18TFXT_ConfigID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfxt_configkey Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFXT_CONFIGKEY"), AV21TFXT_ConfigKey) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfxt_configkey_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFXT_CONFIGKEY_SEL"), AV22TFXT_ConfigKey_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfxt_configvalue1 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFXT_CONFIGVALUE1"), AV25TFXT_ConfigValue1) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfxt_configvalue1_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFXT_CONFIGVALUE1_SEL"), AV26TFXT_ConfigValue1_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfxt_configvalue2 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFXT_CONFIGVALUE2"), AV29TFXT_ConfigValue2) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfxt_configvalue2_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFXT_CONFIGVALUE2_SEL"), AV30TFXT_ConfigValue2_Sel) != 0 )
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

      protected void WE6X2( )
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

      protected void PA6X2( )
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
               GX_FocusControl = edtavDdo_xt_configidtitlecontrolidtoreplace_Internalname;
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
                                       short AV13OrderedBy ,
                                       bool AV14OrderedDsc ,
                                       long AV17TFXT_ConfigID ,
                                       long AV18TFXT_ConfigID_To ,
                                       String AV21TFXT_ConfigKey ,
                                       String AV22TFXT_ConfigKey_Sel ,
                                       String AV25TFXT_ConfigValue1 ,
                                       String AV26TFXT_ConfigValue1_Sel ,
                                       String AV29TFXT_ConfigValue2 ,
                                       String AV30TFXT_ConfigValue2_Sel ,
                                       String AV19ddo_XT_ConfigIDTitleControlIdToReplace ,
                                       String AV23ddo_XT_ConfigKeyTitleControlIdToReplace ,
                                       String AV27ddo_XT_ConfigValue1TitleControlIdToReplace ,
                                       String AV31ddo_XT_ConfigValue2TitleControlIdToReplace ,
                                       String AV56Pgmname ,
                                       bool AV39IsAuthorized_Update ,
                                       bool AV41IsAuthorized_Delete )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF6X2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_XT_CONFIGID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A195XT_ConfigID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "XT_CONFIGID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A195XT_ConfigID), 18, 0, ".", "")));
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
         RF6X2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV56Pgmname = "XT_ConfigWW";
         context.Gx_err = 0;
      }

      protected void RF6X2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 28;
         /* Execute user event: Refresh */
         E196X2 ();
         nGXsfl_28_idx = 1;
         sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
         SubsflControlProps_282( ) ;
         bGXsfl_28_Refreshing = true;
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
            SubsflControlProps_282( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV45XT_ConfigWWDS_1_Tfxt_configid ,
                                                 AV46XT_ConfigWWDS_2_Tfxt_configid_to ,
                                                 AV48XT_ConfigWWDS_4_Tfxt_configkey_sel ,
                                                 AV47XT_ConfigWWDS_3_Tfxt_configkey ,
                                                 AV50XT_ConfigWWDS_6_Tfxt_configvalue1_sel ,
                                                 AV49XT_ConfigWWDS_5_Tfxt_configvalue1 ,
                                                 AV52XT_ConfigWWDS_8_Tfxt_configvalue2_sel ,
                                                 AV51XT_ConfigWWDS_7_Tfxt_configvalue2 ,
                                                 A195XT_ConfigID ,
                                                 A196XT_ConfigKey ,
                                                 A197XT_ConfigValue1 ,
                                                 A198XT_ConfigValue2 ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING,
                                                 TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV47XT_ConfigWWDS_3_Tfxt_configkey = StringUtil.Concat( StringUtil.RTrim( AV47XT_ConfigWWDS_3_Tfxt_configkey), "%", "");
            lV49XT_ConfigWWDS_5_Tfxt_configvalue1 = StringUtil.Concat( StringUtil.RTrim( AV49XT_ConfigWWDS_5_Tfxt_configvalue1), "%", "");
            lV51XT_ConfigWWDS_7_Tfxt_configvalue2 = StringUtil.Concat( StringUtil.RTrim( AV51XT_ConfigWWDS_7_Tfxt_configvalue2), "%", "");
            /* Using cursor H006X2 */
            pr_default.execute(0, new Object[] {AV45XT_ConfigWWDS_1_Tfxt_configid, AV46XT_ConfigWWDS_2_Tfxt_configid_to, lV47XT_ConfigWWDS_3_Tfxt_configkey, AV48XT_ConfigWWDS_4_Tfxt_configkey_sel, lV49XT_ConfigWWDS_5_Tfxt_configvalue1, AV50XT_ConfigWWDS_6_Tfxt_configvalue1_sel, lV51XT_ConfigWWDS_7_Tfxt_configvalue2, AV52XT_ConfigWWDS_8_Tfxt_configvalue2_sel, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_28_idx = 1;
            sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
            SubsflControlProps_282( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A198XT_ConfigValue2 = H006X2_A198XT_ConfigValue2[0];
               n198XT_ConfigValue2 = H006X2_n198XT_ConfigValue2[0];
               A197XT_ConfigValue1 = H006X2_A197XT_ConfigValue1[0];
               n197XT_ConfigValue1 = H006X2_n197XT_ConfigValue1[0];
               A196XT_ConfigKey = H006X2_A196XT_ConfigKey[0];
               n196XT_ConfigKey = H006X2_n196XT_ConfigKey[0];
               A195XT_ConfigID = H006X2_A195XT_ConfigID[0];
               E206X2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 28;
            WB6X0( ) ;
         }
         bGXsfl_28_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes6X2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_XT_CONFIGID"+"_"+sGXsfl_28_idx, GetSecureSignedToken( sGXsfl_28_idx, context.localUtil.Format( (decimal)(A195XT_ConfigID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         AV45XT_ConfigWWDS_1_Tfxt_configid = AV17TFXT_ConfigID;
         AV46XT_ConfigWWDS_2_Tfxt_configid_to = AV18TFXT_ConfigID_To;
         AV47XT_ConfigWWDS_3_Tfxt_configkey = AV21TFXT_ConfigKey;
         AV48XT_ConfigWWDS_4_Tfxt_configkey_sel = AV22TFXT_ConfigKey_Sel;
         AV49XT_ConfigWWDS_5_Tfxt_configvalue1 = AV25TFXT_ConfigValue1;
         AV50XT_ConfigWWDS_6_Tfxt_configvalue1_sel = AV26TFXT_ConfigValue1_Sel;
         AV51XT_ConfigWWDS_7_Tfxt_configvalue2 = AV29TFXT_ConfigValue2;
         AV52XT_ConfigWWDS_8_Tfxt_configvalue2_sel = AV30TFXT_ConfigValue2_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV45XT_ConfigWWDS_1_Tfxt_configid ,
                                              AV46XT_ConfigWWDS_2_Tfxt_configid_to ,
                                              AV48XT_ConfigWWDS_4_Tfxt_configkey_sel ,
                                              AV47XT_ConfigWWDS_3_Tfxt_configkey ,
                                              AV50XT_ConfigWWDS_6_Tfxt_configvalue1_sel ,
                                              AV49XT_ConfigWWDS_5_Tfxt_configvalue1 ,
                                              AV52XT_ConfigWWDS_8_Tfxt_configvalue2_sel ,
                                              AV51XT_ConfigWWDS_7_Tfxt_configvalue2 ,
                                              A195XT_ConfigID ,
                                              A196XT_ConfigKey ,
                                              A197XT_ConfigValue1 ,
                                              A198XT_ConfigValue2 ,
                                              AV13OrderedBy ,
                                              AV14OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV47XT_ConfigWWDS_3_Tfxt_configkey = StringUtil.Concat( StringUtil.RTrim( AV47XT_ConfigWWDS_3_Tfxt_configkey), "%", "");
         lV49XT_ConfigWWDS_5_Tfxt_configvalue1 = StringUtil.Concat( StringUtil.RTrim( AV49XT_ConfigWWDS_5_Tfxt_configvalue1), "%", "");
         lV51XT_ConfigWWDS_7_Tfxt_configvalue2 = StringUtil.Concat( StringUtil.RTrim( AV51XT_ConfigWWDS_7_Tfxt_configvalue2), "%", "");
         /* Using cursor H006X3 */
         pr_default.execute(1, new Object[] {AV45XT_ConfigWWDS_1_Tfxt_configid, AV46XT_ConfigWWDS_2_Tfxt_configid_to, lV47XT_ConfigWWDS_3_Tfxt_configkey, AV48XT_ConfigWWDS_4_Tfxt_configkey_sel, lV49XT_ConfigWWDS_5_Tfxt_configvalue1, AV50XT_ConfigWWDS_6_Tfxt_configvalue1_sel, lV51XT_ConfigWWDS_7_Tfxt_configvalue2, AV52XT_ConfigWWDS_8_Tfxt_configvalue2_sel});
         GRID_nRecordCount = H006X3_AGRID_nRecordCount[0];
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
         AV45XT_ConfigWWDS_1_Tfxt_configid = AV17TFXT_ConfigID;
         AV46XT_ConfigWWDS_2_Tfxt_configid_to = AV18TFXT_ConfigID_To;
         AV47XT_ConfigWWDS_3_Tfxt_configkey = AV21TFXT_ConfigKey;
         AV48XT_ConfigWWDS_4_Tfxt_configkey_sel = AV22TFXT_ConfigKey_Sel;
         AV49XT_ConfigWWDS_5_Tfxt_configvalue1 = AV25TFXT_ConfigValue1;
         AV50XT_ConfigWWDS_6_Tfxt_configvalue1_sel = AV26TFXT_ConfigValue1_Sel;
         AV51XT_ConfigWWDS_7_Tfxt_configvalue2 = AV29TFXT_ConfigValue2;
         AV52XT_ConfigWWDS_8_Tfxt_configvalue2_sel = AV30TFXT_ConfigValue2_Sel;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFXT_ConfigID, AV18TFXT_ConfigID_To, AV21TFXT_ConfigKey, AV22TFXT_ConfigKey_Sel, AV25TFXT_ConfigValue1, AV26TFXT_ConfigValue1_Sel, AV29TFXT_ConfigValue2, AV30TFXT_ConfigValue2_Sel, AV19ddo_XT_ConfigIDTitleControlIdToReplace, AV23ddo_XT_ConfigKeyTitleControlIdToReplace, AV27ddo_XT_ConfigValue1TitleControlIdToReplace, AV31ddo_XT_ConfigValue2TitleControlIdToReplace, AV56Pgmname, AV39IsAuthorized_Update, AV41IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV45XT_ConfigWWDS_1_Tfxt_configid = AV17TFXT_ConfigID;
         AV46XT_ConfigWWDS_2_Tfxt_configid_to = AV18TFXT_ConfigID_To;
         AV47XT_ConfigWWDS_3_Tfxt_configkey = AV21TFXT_ConfigKey;
         AV48XT_ConfigWWDS_4_Tfxt_configkey_sel = AV22TFXT_ConfigKey_Sel;
         AV49XT_ConfigWWDS_5_Tfxt_configvalue1 = AV25TFXT_ConfigValue1;
         AV50XT_ConfigWWDS_6_Tfxt_configvalue1_sel = AV26TFXT_ConfigValue1_Sel;
         AV51XT_ConfigWWDS_7_Tfxt_configvalue2 = AV29TFXT_ConfigValue2;
         AV52XT_ConfigWWDS_8_Tfxt_configvalue2_sel = AV30TFXT_ConfigValue2_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFXT_ConfigID, AV18TFXT_ConfigID_To, AV21TFXT_ConfigKey, AV22TFXT_ConfigKey_Sel, AV25TFXT_ConfigValue1, AV26TFXT_ConfigValue1_Sel, AV29TFXT_ConfigValue2, AV30TFXT_ConfigValue2_Sel, AV19ddo_XT_ConfigIDTitleControlIdToReplace, AV23ddo_XT_ConfigKeyTitleControlIdToReplace, AV27ddo_XT_ConfigValue1TitleControlIdToReplace, AV31ddo_XT_ConfigValue2TitleControlIdToReplace, AV56Pgmname, AV39IsAuthorized_Update, AV41IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV45XT_ConfigWWDS_1_Tfxt_configid = AV17TFXT_ConfigID;
         AV46XT_ConfigWWDS_2_Tfxt_configid_to = AV18TFXT_ConfigID_To;
         AV47XT_ConfigWWDS_3_Tfxt_configkey = AV21TFXT_ConfigKey;
         AV48XT_ConfigWWDS_4_Tfxt_configkey_sel = AV22TFXT_ConfigKey_Sel;
         AV49XT_ConfigWWDS_5_Tfxt_configvalue1 = AV25TFXT_ConfigValue1;
         AV50XT_ConfigWWDS_6_Tfxt_configvalue1_sel = AV26TFXT_ConfigValue1_Sel;
         AV51XT_ConfigWWDS_7_Tfxt_configvalue2 = AV29TFXT_ConfigValue2;
         AV52XT_ConfigWWDS_8_Tfxt_configvalue2_sel = AV30TFXT_ConfigValue2_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFXT_ConfigID, AV18TFXT_ConfigID_To, AV21TFXT_ConfigKey, AV22TFXT_ConfigKey_Sel, AV25TFXT_ConfigValue1, AV26TFXT_ConfigValue1_Sel, AV29TFXT_ConfigValue2, AV30TFXT_ConfigValue2_Sel, AV19ddo_XT_ConfigIDTitleControlIdToReplace, AV23ddo_XT_ConfigKeyTitleControlIdToReplace, AV27ddo_XT_ConfigValue1TitleControlIdToReplace, AV31ddo_XT_ConfigValue2TitleControlIdToReplace, AV56Pgmname, AV39IsAuthorized_Update, AV41IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV45XT_ConfigWWDS_1_Tfxt_configid = AV17TFXT_ConfigID;
         AV46XT_ConfigWWDS_2_Tfxt_configid_to = AV18TFXT_ConfigID_To;
         AV47XT_ConfigWWDS_3_Tfxt_configkey = AV21TFXT_ConfigKey;
         AV48XT_ConfigWWDS_4_Tfxt_configkey_sel = AV22TFXT_ConfigKey_Sel;
         AV49XT_ConfigWWDS_5_Tfxt_configvalue1 = AV25TFXT_ConfigValue1;
         AV50XT_ConfigWWDS_6_Tfxt_configvalue1_sel = AV26TFXT_ConfigValue1_Sel;
         AV51XT_ConfigWWDS_7_Tfxt_configvalue2 = AV29TFXT_ConfigValue2;
         AV52XT_ConfigWWDS_8_Tfxt_configvalue2_sel = AV30TFXT_ConfigValue2_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFXT_ConfigID, AV18TFXT_ConfigID_To, AV21TFXT_ConfigKey, AV22TFXT_ConfigKey_Sel, AV25TFXT_ConfigValue1, AV26TFXT_ConfigValue1_Sel, AV29TFXT_ConfigValue2, AV30TFXT_ConfigValue2_Sel, AV19ddo_XT_ConfigIDTitleControlIdToReplace, AV23ddo_XT_ConfigKeyTitleControlIdToReplace, AV27ddo_XT_ConfigValue1TitleControlIdToReplace, AV31ddo_XT_ConfigValue2TitleControlIdToReplace, AV56Pgmname, AV39IsAuthorized_Update, AV41IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV45XT_ConfigWWDS_1_Tfxt_configid = AV17TFXT_ConfigID;
         AV46XT_ConfigWWDS_2_Tfxt_configid_to = AV18TFXT_ConfigID_To;
         AV47XT_ConfigWWDS_3_Tfxt_configkey = AV21TFXT_ConfigKey;
         AV48XT_ConfigWWDS_4_Tfxt_configkey_sel = AV22TFXT_ConfigKey_Sel;
         AV49XT_ConfigWWDS_5_Tfxt_configvalue1 = AV25TFXT_ConfigValue1;
         AV50XT_ConfigWWDS_6_Tfxt_configvalue1_sel = AV26TFXT_ConfigValue1_Sel;
         AV51XT_ConfigWWDS_7_Tfxt_configvalue2 = AV29TFXT_ConfigValue2;
         AV52XT_ConfigWWDS_8_Tfxt_configvalue2_sel = AV30TFXT_ConfigValue2_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFXT_ConfigID, AV18TFXT_ConfigID_To, AV21TFXT_ConfigKey, AV22TFXT_ConfigKey_Sel, AV25TFXT_ConfigValue1, AV26TFXT_ConfigValue1_Sel, AV29TFXT_ConfigValue2, AV30TFXT_ConfigValue2_Sel, AV19ddo_XT_ConfigIDTitleControlIdToReplace, AV23ddo_XT_ConfigKeyTitleControlIdToReplace, AV27ddo_XT_ConfigValue1TitleControlIdToReplace, AV31ddo_XT_ConfigValue2TitleControlIdToReplace, AV56Pgmname, AV39IsAuthorized_Update, AV41IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP6X0( )
      {
         /* Before Start, stand alone formulas. */
         AV56Pgmname = "XT_ConfigWW";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E186X2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV32DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_CONFIGIDTITLEFILTERDATA"), AV16XT_ConfigIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_CONFIGKEYTITLEFILTERDATA"), AV20XT_ConfigKeyTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_CONFIGVALUE1TITLEFILTERDATA"), AV24XT_ConfigValue1TitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_CONFIGVALUE2TITLEFILTERDATA"), AV28XT_ConfigValue2TitleFilterData);
            /* Read variables values. */
            AV19ddo_XT_ConfigIDTitleControlIdToReplace = cgiGet( edtavDdo_xt_configidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_XT_ConfigIDTitleControlIdToReplace", AV19ddo_XT_ConfigIDTitleControlIdToReplace);
            AV23ddo_XT_ConfigKeyTitleControlIdToReplace = cgiGet( edtavDdo_xt_configkeytitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_XT_ConfigKeyTitleControlIdToReplace", AV23ddo_XT_ConfigKeyTitleControlIdToReplace);
            AV27ddo_XT_ConfigValue1TitleControlIdToReplace = cgiGet( edtavDdo_xt_configvalue1titlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_XT_ConfigValue1TitleControlIdToReplace", AV27ddo_XT_ConfigValue1TitleControlIdToReplace);
            AV31ddo_XT_ConfigValue2TitleControlIdToReplace = cgiGet( edtavDdo_xt_configvalue2titlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_XT_ConfigValue2TitleControlIdToReplace", AV31ddo_XT_ConfigValue2TitleControlIdToReplace);
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
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfxt_configid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfxt_configid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFXT_CONFIGID");
               GX_FocusControl = edtavTfxt_configid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV17TFXT_ConfigID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFXT_ConfigID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFXT_ConfigID), 18, 0)));
            }
            else
            {
               AV17TFXT_ConfigID = (long)(context.localUtil.CToN( cgiGet( edtavTfxt_configid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFXT_ConfigID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFXT_ConfigID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfxt_configid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfxt_configid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFXT_CONFIGID_TO");
               GX_FocusControl = edtavTfxt_configid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV18TFXT_ConfigID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFXT_ConfigID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFXT_ConfigID_To), 18, 0)));
            }
            else
            {
               AV18TFXT_ConfigID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfxt_configid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFXT_ConfigID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFXT_ConfigID_To), 18, 0)));
            }
            AV21TFXT_ConfigKey = cgiGet( edtavTfxt_configkey_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFXT_ConfigKey", AV21TFXT_ConfigKey);
            AV22TFXT_ConfigKey_Sel = cgiGet( edtavTfxt_configkey_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFXT_ConfigKey_Sel", AV22TFXT_ConfigKey_Sel);
            AV25TFXT_ConfigValue1 = cgiGet( edtavTfxt_configvalue1_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFXT_ConfigValue1", AV25TFXT_ConfigValue1);
            AV26TFXT_ConfigValue1_Sel = cgiGet( edtavTfxt_configvalue1_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFXT_ConfigValue1_Sel", AV26TFXT_ConfigValue1_Sel);
            AV29TFXT_ConfigValue2 = cgiGet( edtavTfxt_configvalue2_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFXT_ConfigValue2", AV29TFXT_ConfigValue2);
            AV30TFXT_ConfigValue2_Sel = cgiGet( edtavTfxt_configvalue2_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFXT_ConfigValue2_Sel", AV30TFXT_ConfigValue2_Sel);
            /* Read saved values. */
            nRC_GXsfl_28 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_28"), ".", ","));
            AV34GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV36GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV35GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_xt_configid_Caption = cgiGet( "DDO_XT_CONFIGID_Caption");
            Ddo_xt_configid_Tooltip = cgiGet( "DDO_XT_CONFIGID_Tooltip");
            Ddo_xt_configid_Cls = cgiGet( "DDO_XT_CONFIGID_Cls");
            Ddo_xt_configid_Filteredtext_set = cgiGet( "DDO_XT_CONFIGID_Filteredtext_set");
            Ddo_xt_configid_Filteredtextto_set = cgiGet( "DDO_XT_CONFIGID_Filteredtextto_set");
            Ddo_xt_configid_Dropdownoptionstype = cgiGet( "DDO_XT_CONFIGID_Dropdownoptionstype");
            Ddo_xt_configid_Titlecontrolidtoreplace = cgiGet( "DDO_XT_CONFIGID_Titlecontrolidtoreplace");
            Ddo_xt_configid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGID_Includesortasc"));
            Ddo_xt_configid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGID_Includesortdsc"));
            Ddo_xt_configid_Sortedstatus = cgiGet( "DDO_XT_CONFIGID_Sortedstatus");
            Ddo_xt_configid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGID_Includefilter"));
            Ddo_xt_configid_Filtertype = cgiGet( "DDO_XT_CONFIGID_Filtertype");
            Ddo_xt_configid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGID_Filterisrange"));
            Ddo_xt_configid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGID_Includedatalist"));
            Ddo_xt_configid_Sortasc = cgiGet( "DDO_XT_CONFIGID_Sortasc");
            Ddo_xt_configid_Sortdsc = cgiGet( "DDO_XT_CONFIGID_Sortdsc");
            Ddo_xt_configid_Cleanfilter = cgiGet( "DDO_XT_CONFIGID_Cleanfilter");
            Ddo_xt_configid_Rangefilterfrom = cgiGet( "DDO_XT_CONFIGID_Rangefilterfrom");
            Ddo_xt_configid_Rangefilterto = cgiGet( "DDO_XT_CONFIGID_Rangefilterto");
            Ddo_xt_configid_Searchbuttontext = cgiGet( "DDO_XT_CONFIGID_Searchbuttontext");
            Ddo_xt_configkey_Caption = cgiGet( "DDO_XT_CONFIGKEY_Caption");
            Ddo_xt_configkey_Tooltip = cgiGet( "DDO_XT_CONFIGKEY_Tooltip");
            Ddo_xt_configkey_Cls = cgiGet( "DDO_XT_CONFIGKEY_Cls");
            Ddo_xt_configkey_Filteredtext_set = cgiGet( "DDO_XT_CONFIGKEY_Filteredtext_set");
            Ddo_xt_configkey_Selectedvalue_set = cgiGet( "DDO_XT_CONFIGKEY_Selectedvalue_set");
            Ddo_xt_configkey_Dropdownoptionstype = cgiGet( "DDO_XT_CONFIGKEY_Dropdownoptionstype");
            Ddo_xt_configkey_Titlecontrolidtoreplace = cgiGet( "DDO_XT_CONFIGKEY_Titlecontrolidtoreplace");
            Ddo_xt_configkey_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGKEY_Includesortasc"));
            Ddo_xt_configkey_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGKEY_Includesortdsc"));
            Ddo_xt_configkey_Sortedstatus = cgiGet( "DDO_XT_CONFIGKEY_Sortedstatus");
            Ddo_xt_configkey_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGKEY_Includefilter"));
            Ddo_xt_configkey_Filtertype = cgiGet( "DDO_XT_CONFIGKEY_Filtertype");
            Ddo_xt_configkey_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGKEY_Filterisrange"));
            Ddo_xt_configkey_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGKEY_Includedatalist"));
            Ddo_xt_configkey_Datalisttype = cgiGet( "DDO_XT_CONFIGKEY_Datalisttype");
            Ddo_xt_configkey_Datalistproc = cgiGet( "DDO_XT_CONFIGKEY_Datalistproc");
            Ddo_xt_configkey_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_XT_CONFIGKEY_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_xt_configkey_Sortasc = cgiGet( "DDO_XT_CONFIGKEY_Sortasc");
            Ddo_xt_configkey_Sortdsc = cgiGet( "DDO_XT_CONFIGKEY_Sortdsc");
            Ddo_xt_configkey_Loadingdata = cgiGet( "DDO_XT_CONFIGKEY_Loadingdata");
            Ddo_xt_configkey_Cleanfilter = cgiGet( "DDO_XT_CONFIGKEY_Cleanfilter");
            Ddo_xt_configkey_Noresultsfound = cgiGet( "DDO_XT_CONFIGKEY_Noresultsfound");
            Ddo_xt_configkey_Searchbuttontext = cgiGet( "DDO_XT_CONFIGKEY_Searchbuttontext");
            Ddo_xt_configvalue1_Caption = cgiGet( "DDO_XT_CONFIGVALUE1_Caption");
            Ddo_xt_configvalue1_Tooltip = cgiGet( "DDO_XT_CONFIGVALUE1_Tooltip");
            Ddo_xt_configvalue1_Cls = cgiGet( "DDO_XT_CONFIGVALUE1_Cls");
            Ddo_xt_configvalue1_Filteredtext_set = cgiGet( "DDO_XT_CONFIGVALUE1_Filteredtext_set");
            Ddo_xt_configvalue1_Selectedvalue_set = cgiGet( "DDO_XT_CONFIGVALUE1_Selectedvalue_set");
            Ddo_xt_configvalue1_Dropdownoptionstype = cgiGet( "DDO_XT_CONFIGVALUE1_Dropdownoptionstype");
            Ddo_xt_configvalue1_Titlecontrolidtoreplace = cgiGet( "DDO_XT_CONFIGVALUE1_Titlecontrolidtoreplace");
            Ddo_xt_configvalue1_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGVALUE1_Includesortasc"));
            Ddo_xt_configvalue1_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGVALUE1_Includesortdsc"));
            Ddo_xt_configvalue1_Sortedstatus = cgiGet( "DDO_XT_CONFIGVALUE1_Sortedstatus");
            Ddo_xt_configvalue1_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGVALUE1_Includefilter"));
            Ddo_xt_configvalue1_Filtertype = cgiGet( "DDO_XT_CONFIGVALUE1_Filtertype");
            Ddo_xt_configvalue1_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGVALUE1_Filterisrange"));
            Ddo_xt_configvalue1_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGVALUE1_Includedatalist"));
            Ddo_xt_configvalue1_Datalisttype = cgiGet( "DDO_XT_CONFIGVALUE1_Datalisttype");
            Ddo_xt_configvalue1_Datalistproc = cgiGet( "DDO_XT_CONFIGVALUE1_Datalistproc");
            Ddo_xt_configvalue1_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_XT_CONFIGVALUE1_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_xt_configvalue1_Sortasc = cgiGet( "DDO_XT_CONFIGVALUE1_Sortasc");
            Ddo_xt_configvalue1_Sortdsc = cgiGet( "DDO_XT_CONFIGVALUE1_Sortdsc");
            Ddo_xt_configvalue1_Loadingdata = cgiGet( "DDO_XT_CONFIGVALUE1_Loadingdata");
            Ddo_xt_configvalue1_Cleanfilter = cgiGet( "DDO_XT_CONFIGVALUE1_Cleanfilter");
            Ddo_xt_configvalue1_Noresultsfound = cgiGet( "DDO_XT_CONFIGVALUE1_Noresultsfound");
            Ddo_xt_configvalue1_Searchbuttontext = cgiGet( "DDO_XT_CONFIGVALUE1_Searchbuttontext");
            Ddo_xt_configvalue2_Caption = cgiGet( "DDO_XT_CONFIGVALUE2_Caption");
            Ddo_xt_configvalue2_Tooltip = cgiGet( "DDO_XT_CONFIGVALUE2_Tooltip");
            Ddo_xt_configvalue2_Cls = cgiGet( "DDO_XT_CONFIGVALUE2_Cls");
            Ddo_xt_configvalue2_Filteredtext_set = cgiGet( "DDO_XT_CONFIGVALUE2_Filteredtext_set");
            Ddo_xt_configvalue2_Selectedvalue_set = cgiGet( "DDO_XT_CONFIGVALUE2_Selectedvalue_set");
            Ddo_xt_configvalue2_Dropdownoptionstype = cgiGet( "DDO_XT_CONFIGVALUE2_Dropdownoptionstype");
            Ddo_xt_configvalue2_Titlecontrolidtoreplace = cgiGet( "DDO_XT_CONFIGVALUE2_Titlecontrolidtoreplace");
            Ddo_xt_configvalue2_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGVALUE2_Includesortasc"));
            Ddo_xt_configvalue2_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGVALUE2_Includesortdsc"));
            Ddo_xt_configvalue2_Sortedstatus = cgiGet( "DDO_XT_CONFIGVALUE2_Sortedstatus");
            Ddo_xt_configvalue2_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGVALUE2_Includefilter"));
            Ddo_xt_configvalue2_Filtertype = cgiGet( "DDO_XT_CONFIGVALUE2_Filtertype");
            Ddo_xt_configvalue2_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGVALUE2_Filterisrange"));
            Ddo_xt_configvalue2_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGVALUE2_Includedatalist"));
            Ddo_xt_configvalue2_Datalisttype = cgiGet( "DDO_XT_CONFIGVALUE2_Datalisttype");
            Ddo_xt_configvalue2_Datalistproc = cgiGet( "DDO_XT_CONFIGVALUE2_Datalistproc");
            Ddo_xt_configvalue2_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_XT_CONFIGVALUE2_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_xt_configvalue2_Sortasc = cgiGet( "DDO_XT_CONFIGVALUE2_Sortasc");
            Ddo_xt_configvalue2_Sortdsc = cgiGet( "DDO_XT_CONFIGVALUE2_Sortdsc");
            Ddo_xt_configvalue2_Loadingdata = cgiGet( "DDO_XT_CONFIGVALUE2_Loadingdata");
            Ddo_xt_configvalue2_Cleanfilter = cgiGet( "DDO_XT_CONFIGVALUE2_Cleanfilter");
            Ddo_xt_configvalue2_Noresultsfound = cgiGet( "DDO_XT_CONFIGVALUE2_Noresultsfound");
            Ddo_xt_configvalue2_Searchbuttontext = cgiGet( "DDO_XT_CONFIGVALUE2_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_xt_configid_Activeeventkey = cgiGet( "DDO_XT_CONFIGID_Activeeventkey");
            Ddo_xt_configid_Filteredtext_get = cgiGet( "DDO_XT_CONFIGID_Filteredtext_get");
            Ddo_xt_configid_Filteredtextto_get = cgiGet( "DDO_XT_CONFIGID_Filteredtextto_get");
            Ddo_xt_configkey_Activeeventkey = cgiGet( "DDO_XT_CONFIGKEY_Activeeventkey");
            Ddo_xt_configkey_Filteredtext_get = cgiGet( "DDO_XT_CONFIGKEY_Filteredtext_get");
            Ddo_xt_configkey_Selectedvalue_get = cgiGet( "DDO_XT_CONFIGKEY_Selectedvalue_get");
            Ddo_xt_configvalue1_Activeeventkey = cgiGet( "DDO_XT_CONFIGVALUE1_Activeeventkey");
            Ddo_xt_configvalue1_Filteredtext_get = cgiGet( "DDO_XT_CONFIGVALUE1_Filteredtext_get");
            Ddo_xt_configvalue1_Selectedvalue_get = cgiGet( "DDO_XT_CONFIGVALUE1_Selectedvalue_get");
            Ddo_xt_configvalue2_Activeeventkey = cgiGet( "DDO_XT_CONFIGVALUE2_Activeeventkey");
            Ddo_xt_configvalue2_Filteredtext_get = cgiGet( "DDO_XT_CONFIGVALUE2_Filteredtext_get");
            Ddo_xt_configvalue2_Selectedvalue_get = cgiGet( "DDO_XT_CONFIGVALUE2_Selectedvalue_get");
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
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFXT_CONFIGID"), ".", ",") != Convert.ToDecimal( AV17TFXT_ConfigID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFXT_CONFIGID_TO"), ".", ",") != Convert.ToDecimal( AV18TFXT_ConfigID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFXT_CONFIGKEY"), AV21TFXT_ConfigKey) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFXT_CONFIGKEY_SEL"), AV22TFXT_ConfigKey_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFXT_CONFIGVALUE1"), AV25TFXT_ConfigValue1) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFXT_CONFIGVALUE1_SEL"), AV26TFXT_ConfigValue1_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFXT_CONFIGVALUE2"), AV29TFXT_ConfigValue2) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFXT_CONFIGVALUE2_SEL"), AV30TFXT_ConfigValue2_Sel) != 0 )
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
         E186X2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E186X2( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         edtavTfxt_configid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfxt_configid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfxt_configid_Visible), 5, 0)), true);
         edtavTfxt_configid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfxt_configid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfxt_configid_to_Visible), 5, 0)), true);
         edtavTfxt_configkey_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfxt_configkey_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfxt_configkey_Visible), 5, 0)), true);
         edtavTfxt_configkey_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfxt_configkey_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfxt_configkey_sel_Visible), 5, 0)), true);
         edtavTfxt_configvalue1_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfxt_configvalue1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfxt_configvalue1_Visible), 5, 0)), true);
         edtavTfxt_configvalue1_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfxt_configvalue1_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfxt_configvalue1_sel_Visible), 5, 0)), true);
         edtavTfxt_configvalue2_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfxt_configvalue2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfxt_configvalue2_Visible), 5, 0)), true);
         edtavTfxt_configvalue2_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfxt_configvalue2_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfxt_configvalue2_sel_Visible), 5, 0)), true);
         Ddo_xt_configid_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_ConfigID";
         ucDdo_xt_configid.SendProperty(context, "", false, Ddo_xt_configid_Internalname, "TitleControlIdToReplace", Ddo_xt_configid_Titlecontrolidtoreplace);
         AV19ddo_XT_ConfigIDTitleControlIdToReplace = Ddo_xt_configid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_XT_ConfigIDTitleControlIdToReplace", AV19ddo_XT_ConfigIDTitleControlIdToReplace);
         edtavDdo_xt_configidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_configidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_configidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_xt_configkey_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_ConfigKey";
         ucDdo_xt_configkey.SendProperty(context, "", false, Ddo_xt_configkey_Internalname, "TitleControlIdToReplace", Ddo_xt_configkey_Titlecontrolidtoreplace);
         AV23ddo_XT_ConfigKeyTitleControlIdToReplace = Ddo_xt_configkey_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_XT_ConfigKeyTitleControlIdToReplace", AV23ddo_XT_ConfigKeyTitleControlIdToReplace);
         edtavDdo_xt_configkeytitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_configkeytitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_configkeytitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_xt_configvalue1_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_ConfigValue1";
         ucDdo_xt_configvalue1.SendProperty(context, "", false, Ddo_xt_configvalue1_Internalname, "TitleControlIdToReplace", Ddo_xt_configvalue1_Titlecontrolidtoreplace);
         AV27ddo_XT_ConfigValue1TitleControlIdToReplace = Ddo_xt_configvalue1_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_XT_ConfigValue1TitleControlIdToReplace", AV27ddo_XT_ConfigValue1TitleControlIdToReplace);
         edtavDdo_xt_configvalue1titlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_configvalue1titlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_configvalue1titlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_xt_configvalue2_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_ConfigValue2";
         ucDdo_xt_configvalue2.SendProperty(context, "", false, Ddo_xt_configvalue2_Internalname, "TitleControlIdToReplace", Ddo_xt_configvalue2_Titlecontrolidtoreplace);
         AV31ddo_XT_ConfigValue2TitleControlIdToReplace = Ddo_xt_configvalue2_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_XT_ConfigValue2TitleControlIdToReplace", AV31ddo_XT_ConfigValue2TitleControlIdToReplace);
         edtavDdo_xt_configvalue2titlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_configvalue2titlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_configvalue2titlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " 系统配置表";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV32DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV32DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E196X2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV16XT_ConfigIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20XT_ConfigKeyTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24XT_ConfigValue1TitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28XT_ConfigValue2TitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
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
         edtXT_ConfigID_Titleformat = 2;
         edtXT_ConfigID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "系统配置的主键", AV19ddo_XT_ConfigIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_ConfigID_Internalname, "Title", edtXT_ConfigID_Title, !bGXsfl_28_Refreshing);
         edtXT_ConfigKey_Titleformat = 2;
         edtXT_ConfigKey_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "配置名称", AV23ddo_XT_ConfigKeyTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_ConfigKey_Internalname, "Title", edtXT_ConfigKey_Title, !bGXsfl_28_Refreshing);
         edtXT_ConfigValue1_Titleformat = 2;
         edtXT_ConfigValue1_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "配置值1", AV27ddo_XT_ConfigValue1TitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_ConfigValue1_Internalname, "Title", edtXT_ConfigValue1_Title, !bGXsfl_28_Refreshing);
         edtXT_ConfigValue2_Titleformat = 2;
         edtXT_ConfigValue2_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "配置值2", AV31ddo_XT_ConfigValue2TitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_ConfigValue2_Internalname, "Title", edtXT_ConfigValue2_Title, !bGXsfl_28_Refreshing);
         AV34GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34GridCurrentPage), 10, 0)));
         AV35GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV35GridPageSize), 10, 0)));
         AV36GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV36GridRecordCount), 10, 0)));
         AV45XT_ConfigWWDS_1_Tfxt_configid = AV17TFXT_ConfigID;
         AV46XT_ConfigWWDS_2_Tfxt_configid_to = AV18TFXT_ConfigID_To;
         AV47XT_ConfigWWDS_3_Tfxt_configkey = AV21TFXT_ConfigKey;
         AV48XT_ConfigWWDS_4_Tfxt_configkey_sel = AV22TFXT_ConfigKey_Sel;
         AV49XT_ConfigWWDS_5_Tfxt_configvalue1 = AV25TFXT_ConfigValue1;
         AV50XT_ConfigWWDS_6_Tfxt_configvalue1_sel = AV26TFXT_ConfigValue1_Sel;
         AV51XT_ConfigWWDS_7_Tfxt_configvalue2 = AV29TFXT_ConfigValue2;
         AV52XT_ConfigWWDS_8_Tfxt_configvalue2_sel = AV30TFXT_ConfigValue2_Sel;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16XT_ConfigIDTitleFilterData", AV16XT_ConfigIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20XT_ConfigKeyTitleFilterData", AV20XT_ConfigKeyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24XT_ConfigValue1TitleFilterData", AV24XT_ConfigValue1TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28XT_ConfigValue2TitleFilterData", AV28XT_ConfigValue2TitleFilterData);
      }

      protected void E116X2( )
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
            AV33PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV33PageToGo) ;
         }
      }

      protected void E126X2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E136X2( )
      {
         /* Ddo_xt_configid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_configid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_xt_configid_Sortedstatus = "ASC";
            ucDdo_xt_configid.SendProperty(context, "", false, Ddo_xt_configid_Internalname, "SortedStatus", Ddo_xt_configid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_configid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_xt_configid_Sortedstatus = "DSC";
            ucDdo_xt_configid.SendProperty(context, "", false, Ddo_xt_configid_Internalname, "SortedStatus", Ddo_xt_configid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_configid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV17TFXT_ConfigID = (long)(NumberUtil.Val( Ddo_xt_configid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFXT_ConfigID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFXT_ConfigID), 18, 0)));
            AV18TFXT_ConfigID_To = (long)(NumberUtil.Val( Ddo_xt_configid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFXT_ConfigID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFXT_ConfigID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16XT_ConfigIDTitleFilterData", AV16XT_ConfigIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20XT_ConfigKeyTitleFilterData", AV20XT_ConfigKeyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24XT_ConfigValue1TitleFilterData", AV24XT_ConfigValue1TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28XT_ConfigValue2TitleFilterData", AV28XT_ConfigValue2TitleFilterData);
      }

      protected void E146X2( )
      {
         /* Ddo_xt_configkey_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_configkey_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_xt_configkey_Sortedstatus = "ASC";
            ucDdo_xt_configkey.SendProperty(context, "", false, Ddo_xt_configkey_Internalname, "SortedStatus", Ddo_xt_configkey_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_configkey_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_xt_configkey_Sortedstatus = "DSC";
            ucDdo_xt_configkey.SendProperty(context, "", false, Ddo_xt_configkey_Internalname, "SortedStatus", Ddo_xt_configkey_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_configkey_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV21TFXT_ConfigKey = Ddo_xt_configkey_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFXT_ConfigKey", AV21TFXT_ConfigKey);
            AV22TFXT_ConfigKey_Sel = Ddo_xt_configkey_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFXT_ConfigKey_Sel", AV22TFXT_ConfigKey_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16XT_ConfigIDTitleFilterData", AV16XT_ConfigIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20XT_ConfigKeyTitleFilterData", AV20XT_ConfigKeyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24XT_ConfigValue1TitleFilterData", AV24XT_ConfigValue1TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28XT_ConfigValue2TitleFilterData", AV28XT_ConfigValue2TitleFilterData);
      }

      protected void E156X2( )
      {
         /* Ddo_xt_configvalue1_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_configvalue1_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_xt_configvalue1_Sortedstatus = "ASC";
            ucDdo_xt_configvalue1.SendProperty(context, "", false, Ddo_xt_configvalue1_Internalname, "SortedStatus", Ddo_xt_configvalue1_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_configvalue1_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_xt_configvalue1_Sortedstatus = "DSC";
            ucDdo_xt_configvalue1.SendProperty(context, "", false, Ddo_xt_configvalue1_Internalname, "SortedStatus", Ddo_xt_configvalue1_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_configvalue1_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV25TFXT_ConfigValue1 = Ddo_xt_configvalue1_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFXT_ConfigValue1", AV25TFXT_ConfigValue1);
            AV26TFXT_ConfigValue1_Sel = Ddo_xt_configvalue1_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFXT_ConfigValue1_Sel", AV26TFXT_ConfigValue1_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16XT_ConfigIDTitleFilterData", AV16XT_ConfigIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20XT_ConfigKeyTitleFilterData", AV20XT_ConfigKeyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24XT_ConfigValue1TitleFilterData", AV24XT_ConfigValue1TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28XT_ConfigValue2TitleFilterData", AV28XT_ConfigValue2TitleFilterData);
      }

      protected void E166X2( )
      {
         /* Ddo_xt_configvalue2_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_configvalue2_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_xt_configvalue2_Sortedstatus = "ASC";
            ucDdo_xt_configvalue2.SendProperty(context, "", false, Ddo_xt_configvalue2_Internalname, "SortedStatus", Ddo_xt_configvalue2_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_configvalue2_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_xt_configvalue2_Sortedstatus = "DSC";
            ucDdo_xt_configvalue2.SendProperty(context, "", false, Ddo_xt_configvalue2_Internalname, "SortedStatus", Ddo_xt_configvalue2_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_configvalue2_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV29TFXT_ConfigValue2 = Ddo_xt_configvalue2_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFXT_ConfigValue2", AV29TFXT_ConfigValue2);
            AV30TFXT_ConfigValue2_Sel = Ddo_xt_configvalue2_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFXT_ConfigValue2_Sel", AV30TFXT_ConfigValue2_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16XT_ConfigIDTitleFilterData", AV16XT_ConfigIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20XT_ConfigKeyTitleFilterData", AV20XT_ConfigKeyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24XT_ConfigValue1TitleFilterData", AV24XT_ConfigValue1TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28XT_ConfigValue2TitleFilterData", AV28XT_ConfigValue2TitleFilterData);
      }

      private void E206X2( )
      {
         /* Grid_Load Routine */
         AV37Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDisplay_Internalname, AV37Display);
         AV53Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = formatLink("xt_configview.aspx") + "?" + UrlEncode("" +A195XT_ConfigID) + "," + UrlEncode(StringUtil.RTrim(""));
         AV38Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV38Update);
         AV54Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavUpdate_Tooltiptext = "修改";
         if ( AV39IsAuthorized_Update )
         {
            edtavUpdate_Link = formatLink("xt_config.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A195XT_ConfigID);
         }
         AV40Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV40Delete);
         AV55Delete_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavDelete_Tooltiptext = "删除";
         if ( AV41IsAuthorized_Delete )
         {
            edtavDelete_Link = formatLink("xt_config.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A195XT_ConfigID);
         }
         edtXT_ConfigKey_Link = formatLink("xt_configview.aspx") + "?" + UrlEncode("" +A195XT_ConfigID) + "," + UrlEncode(StringUtil.RTrim(""));
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

      protected void E176X2( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("xt_config.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S162( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_xt_configid_Sortedstatus = "";
         ucDdo_xt_configid.SendProperty(context, "", false, Ddo_xt_configid_Internalname, "SortedStatus", Ddo_xt_configid_Sortedstatus);
         Ddo_xt_configkey_Sortedstatus = "";
         ucDdo_xt_configkey.SendProperty(context, "", false, Ddo_xt_configkey_Internalname, "SortedStatus", Ddo_xt_configkey_Sortedstatus);
         Ddo_xt_configvalue1_Sortedstatus = "";
         ucDdo_xt_configvalue1.SendProperty(context, "", false, Ddo_xt_configvalue1_Internalname, "SortedStatus", Ddo_xt_configvalue1_Sortedstatus);
         Ddo_xt_configvalue2_Sortedstatus = "";
         ucDdo_xt_configvalue2.SendProperty(context, "", false, Ddo_xt_configvalue2_Internalname, "SortedStatus", Ddo_xt_configvalue2_Sortedstatus);
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
            Ddo_xt_configid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_xt_configid.SendProperty(context, "", false, Ddo_xt_configid_Internalname, "SortedStatus", Ddo_xt_configid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 2 )
         {
            Ddo_xt_configkey_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_xt_configkey.SendProperty(context, "", false, Ddo_xt_configkey_Internalname, "SortedStatus", Ddo_xt_configkey_Sortedstatus);
         }
         else if ( AV13OrderedBy == 3 )
         {
            Ddo_xt_configvalue1_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_xt_configvalue1.SendProperty(context, "", false, Ddo_xt_configvalue1_Internalname, "SortedStatus", Ddo_xt_configvalue1_Sortedstatus);
         }
         else if ( AV13OrderedBy == 4 )
         {
            Ddo_xt_configvalue2_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_xt_configvalue2.SendProperty(context, "", false, Ddo_xt_configvalue2_Internalname, "SortedStatus", Ddo_xt_configvalue2_Sortedstatus);
         }
      }

      protected void S142( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean2 = AV39IsAuthorized_Update;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWXT_Config_Update", out  GXt_boolean2) ;
         AV39IsAuthorized_Update = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39IsAuthorized_Update", AV39IsAuthorized_Update);
         if ( ! ( AV39IsAuthorized_Update ) )
         {
            edtavUpdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         }
         GXt_boolean2 = AV41IsAuthorized_Delete;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWXT_Config_Delete", out  GXt_boolean2) ;
         AV41IsAuthorized_Delete = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41IsAuthorized_Delete", AV41IsAuthorized_Delete);
         if ( ! ( AV41IsAuthorized_Delete ) )
         {
            edtavDelete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         }
         GXt_boolean2 = AV42TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWXT_Config_Insert", out  GXt_boolean2) ;
         AV42TempBoolean = GXt_boolean2;
         if ( ! ( AV42TempBoolean ) )
         {
            bttBtninsert_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtninsert_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtninsert_Visible), 5, 0)), true);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV15Session.Get(AV56Pgmname+"GridState"), "") == 0 )
         {
            AV11GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV56Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV11GridState.FromXml(AV15Session.Get(AV56Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
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
         AV57GXV1 = 1;
         while ( AV57GXV1 <= AV11GridState.gxTpr_Filtervalues.Count )
         {
            AV12GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV11GridState.gxTpr_Filtervalues.Item(AV57GXV1));
            if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFXT_CONFIGID") == 0 )
            {
               AV17TFXT_ConfigID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFXT_ConfigID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFXT_ConfigID), 18, 0)));
               AV18TFXT_ConfigID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFXT_ConfigID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFXT_ConfigID_To), 18, 0)));
               if ( ! (0==AV17TFXT_ConfigID) )
               {
                  Ddo_xt_configid_Filteredtext_set = StringUtil.Str( (decimal)(AV17TFXT_ConfigID), 18, 0);
                  ucDdo_xt_configid.SendProperty(context, "", false, Ddo_xt_configid_Internalname, "FilteredText_set", Ddo_xt_configid_Filteredtext_set);
               }
               if ( ! (0==AV18TFXT_ConfigID_To) )
               {
                  Ddo_xt_configid_Filteredtextto_set = StringUtil.Str( (decimal)(AV18TFXT_ConfigID_To), 18, 0);
                  ucDdo_xt_configid.SendProperty(context, "", false, Ddo_xt_configid_Internalname, "FilteredTextTo_set", Ddo_xt_configid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFXT_CONFIGKEY") == 0 )
            {
               AV21TFXT_ConfigKey = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFXT_ConfigKey", AV21TFXT_ConfigKey);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV21TFXT_ConfigKey)) )
               {
                  Ddo_xt_configkey_Filteredtext_set = AV21TFXT_ConfigKey;
                  ucDdo_xt_configkey.SendProperty(context, "", false, Ddo_xt_configkey_Internalname, "FilteredText_set", Ddo_xt_configkey_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFXT_CONFIGKEY_SEL") == 0 )
            {
               AV22TFXT_ConfigKey_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFXT_ConfigKey_Sel", AV22TFXT_ConfigKey_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV22TFXT_ConfigKey_Sel)) )
               {
                  Ddo_xt_configkey_Selectedvalue_set = AV22TFXT_ConfigKey_Sel;
                  ucDdo_xt_configkey.SendProperty(context, "", false, Ddo_xt_configkey_Internalname, "SelectedValue_set", Ddo_xt_configkey_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFXT_CONFIGVALUE1") == 0 )
            {
               AV25TFXT_ConfigValue1 = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFXT_ConfigValue1", AV25TFXT_ConfigValue1);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV25TFXT_ConfigValue1)) )
               {
                  Ddo_xt_configvalue1_Filteredtext_set = AV25TFXT_ConfigValue1;
                  ucDdo_xt_configvalue1.SendProperty(context, "", false, Ddo_xt_configvalue1_Internalname, "FilteredText_set", Ddo_xt_configvalue1_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFXT_CONFIGVALUE1_SEL") == 0 )
            {
               AV26TFXT_ConfigValue1_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFXT_ConfigValue1_Sel", AV26TFXT_ConfigValue1_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26TFXT_ConfigValue1_Sel)) )
               {
                  Ddo_xt_configvalue1_Selectedvalue_set = AV26TFXT_ConfigValue1_Sel;
                  ucDdo_xt_configvalue1.SendProperty(context, "", false, Ddo_xt_configvalue1_Internalname, "SelectedValue_set", Ddo_xt_configvalue1_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFXT_CONFIGVALUE2") == 0 )
            {
               AV29TFXT_ConfigValue2 = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFXT_ConfigValue2", AV29TFXT_ConfigValue2);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV29TFXT_ConfigValue2)) )
               {
                  Ddo_xt_configvalue2_Filteredtext_set = AV29TFXT_ConfigValue2;
                  ucDdo_xt_configvalue2.SendProperty(context, "", false, Ddo_xt_configvalue2_Internalname, "FilteredText_set", Ddo_xt_configvalue2_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFXT_CONFIGVALUE2_SEL") == 0 )
            {
               AV30TFXT_ConfigValue2_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFXT_ConfigValue2_Sel", AV30TFXT_ConfigValue2_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV30TFXT_ConfigValue2_Sel)) )
               {
                  Ddo_xt_configvalue2_Selectedvalue_set = AV30TFXT_ConfigValue2_Sel;
                  ucDdo_xt_configvalue2.SendProperty(context, "", false, Ddo_xt_configvalue2_Internalname, "SelectedValue_set", Ddo_xt_configvalue2_Selectedvalue_set);
               }
            }
            AV57GXV1 = (int)(AV57GXV1+1);
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
         AV11GridState.FromXml(AV15Session.Get(AV56Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV11GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV11GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV11GridState.gxTpr_Filtervalues.Clear();
         if ( ! ( (0==AV17TFXT_ConfigID) && (0==AV18TFXT_ConfigID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFXT_CONFIGID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV17TFXT_ConfigID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV18TFXT_ConfigID_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV21TFXT_ConfigKey)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFXT_CONFIGKEY";
            AV12GridStateFilterValue.gxTpr_Value = AV21TFXT_ConfigKey;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV22TFXT_ConfigKey_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFXT_CONFIGKEY_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV22TFXT_ConfigKey_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV25TFXT_ConfigValue1)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFXT_CONFIGVALUE1";
            AV12GridStateFilterValue.gxTpr_Value = AV25TFXT_ConfigValue1;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26TFXT_ConfigValue1_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFXT_CONFIGVALUE1_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV26TFXT_ConfigValue1_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV29TFXT_ConfigValue2)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFXT_CONFIGVALUE2";
            AV12GridStateFilterValue.gxTpr_Value = AV29TFXT_ConfigValue2;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV30TFXT_ConfigValue2_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFXT_CONFIGVALUE2_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV30TFXT_ConfigValue2_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         AV11GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV11GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV56Pgmname+"GridState",  AV11GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV56Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "XT_Config";
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
         PA6X2( ) ;
         WS6X2( ) ;
         WE6X2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279464242", true);
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
         context.AddJavascriptSource("xt_configww.js", "?20202279464243", false);
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
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_282( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_28_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_28_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_28_idx;
         edtXT_ConfigID_Internalname = "XT_CONFIGID_"+sGXsfl_28_idx;
         edtXT_ConfigKey_Internalname = "XT_CONFIGKEY_"+sGXsfl_28_idx;
         edtXT_ConfigValue1_Internalname = "XT_CONFIGVALUE1_"+sGXsfl_28_idx;
         edtXT_ConfigValue2_Internalname = "XT_CONFIGVALUE2_"+sGXsfl_28_idx;
      }

      protected void SubsflControlProps_fel_282( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_28_fel_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_28_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_28_fel_idx;
         edtXT_ConfigID_Internalname = "XT_CONFIGID_"+sGXsfl_28_fel_idx;
         edtXT_ConfigKey_Internalname = "XT_CONFIGKEY_"+sGXsfl_28_fel_idx;
         edtXT_ConfigValue1_Internalname = "XT_CONFIGVALUE1_"+sGXsfl_28_fel_idx;
         edtXT_ConfigValue2_Internalname = "XT_CONFIGVALUE2_"+sGXsfl_28_fel_idx;
      }

      protected void sendrow_282( )
      {
         SubsflControlProps_282( ) ;
         WB6X0( ) ;
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
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV37Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV37Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV53Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV37Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV37Display)) ? AV53Display_GXI : context.PathToRelativeUrl( AV37Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV37Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV38Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV38Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV54Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV38Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV38Update)) ? AV54Update_GXI : context.PathToRelativeUrl( AV38Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavUpdate_Visible,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV38Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "DeleteAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV40Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV40Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV55Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV40Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV40Delete)) ? AV55Delete_GXI : context.PathToRelativeUrl( AV40Delete));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)edtavDelete_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavDelete_Visible,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV40Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_ConfigID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A195XT_ConfigID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A195XT_ConfigID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_ConfigID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_ConfigKey_Internalname,(String)A196XT_ConfigKey,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtXT_ConfigKey_Link,(String)"",(String)"",(String)"",(String)edtXT_ConfigKey_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_ConfigValue1_Internalname,(String)A197XT_ConfigValue1,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_ConfigValue1_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)200,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_ConfigValue2_Internalname,(String)A198XT_ConfigValue2,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_ConfigValue2_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)200,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes6X2( ) ;
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
         bttBtninsert_Internalname = "BTNINSERT";
         divTableactions_Internalname = "TABLEACTIONS";
         divTableheader_Internalname = "TABLEHEADER";
         divLayout_tableheader_Internalname = "LAYOUT_TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         divHtml_dvpanel_tableheader_Internalname = "HTML_DVPANEL_TABLEHEADER";
         edtavDisplay_Internalname = "vDISPLAY";
         edtavUpdate_Internalname = "vUPDATE";
         edtavDelete_Internalname = "vDELETE";
         edtXT_ConfigID_Internalname = "XT_CONFIGID";
         edtXT_ConfigKey_Internalname = "XT_CONFIGKEY";
         edtXT_ConfigValue1_Internalname = "XT_CONFIGVALUE1";
         edtXT_ConfigValue2_Internalname = "XT_CONFIGVALUE2";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_xt_configid_Internalname = "DDO_XT_CONFIGID";
         edtavDdo_xt_configidtitlecontrolidtoreplace_Internalname = "vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE";
         Ddo_xt_configkey_Internalname = "DDO_XT_CONFIGKEY";
         edtavDdo_xt_configkeytitlecontrolidtoreplace_Internalname = "vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE";
         Ddo_xt_configvalue1_Internalname = "DDO_XT_CONFIGVALUE1";
         edtavDdo_xt_configvalue1titlecontrolidtoreplace_Internalname = "vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE";
         Ddo_xt_configvalue2_Internalname = "DDO_XT_CONFIGVALUE2";
         edtavDdo_xt_configvalue2titlecontrolidtoreplace_Internalname = "vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         edtavTfxt_configid_Internalname = "vTFXT_CONFIGID";
         edtavTfxt_configid_to_Internalname = "vTFXT_CONFIGID_TO";
         edtavTfxt_configkey_Internalname = "vTFXT_CONFIGKEY";
         edtavTfxt_configkey_sel_Internalname = "vTFXT_CONFIGKEY_SEL";
         edtavTfxt_configvalue1_Internalname = "vTFXT_CONFIGVALUE1";
         edtavTfxt_configvalue1_sel_Internalname = "vTFXT_CONFIGVALUE1_SEL";
         edtavTfxt_configvalue2_Internalname = "vTFXT_CONFIGVALUE2";
         edtavTfxt_configvalue2_sel_Internalname = "vTFXT_CONFIGVALUE2_SEL";
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
         edtXT_ConfigValue2_Jsonclick = "";
         edtXT_ConfigValue1_Jsonclick = "";
         edtXT_ConfigKey_Jsonclick = "";
         edtXT_ConfigID_Jsonclick = "";
         edtavTfxt_configvalue2_sel_Visible = 1;
         edtavTfxt_configvalue2_Visible = 1;
         edtavTfxt_configvalue1_sel_Visible = 1;
         edtavTfxt_configvalue1_Visible = 1;
         edtavTfxt_configkey_sel_Jsonclick = "";
         edtavTfxt_configkey_sel_Visible = 1;
         edtavTfxt_configkey_Jsonclick = "";
         edtavTfxt_configkey_Visible = 1;
         edtavTfxt_configid_to_Jsonclick = "";
         edtavTfxt_configid_to_Visible = 1;
         edtavTfxt_configid_Jsonclick = "";
         edtavTfxt_configid_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_xt_configvalue2titlecontrolidtoreplace_Visible = 1;
         edtavDdo_xt_configvalue1titlecontrolidtoreplace_Visible = 1;
         edtavDdo_xt_configkeytitlecontrolidtoreplace_Visible = 1;
         edtavDdo_xt_configidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtXT_ConfigKey_Link = "";
         edtavDelete_Tooltiptext = "删除";
         edtavDelete_Link = "";
         edtavUpdate_Tooltiptext = "修改";
         edtavUpdate_Link = "";
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtXT_ConfigValue2_Titleformat = 0;
         edtXT_ConfigValue2_Title = "配置值2";
         edtXT_ConfigValue1_Titleformat = 0;
         edtXT_ConfigValue1_Title = "配置值1";
         edtXT_ConfigKey_Titleformat = 0;
         edtXT_ConfigKey_Title = "配置名称";
         edtXT_ConfigID_Titleformat = 0;
         edtXT_ConfigID_Title = "系统配置的主键";
         edtavDelete_Visible = -1;
         edtavUpdate_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         bttBtninsert_Visible = 1;
         Ddo_xt_configvalue2_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_configvalue2_Noresultsfound = "WWP_TSNoResults";
         Ddo_xt_configvalue2_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_xt_configvalue2_Loadingdata = "WWP_TSLoading";
         Ddo_xt_configvalue2_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_configvalue2_Sortasc = "WWP_TSSortASC";
         Ddo_xt_configvalue2_Datalistupdateminimumcharacters = 0;
         Ddo_xt_configvalue2_Datalistproc = "XT_ConfigWWGetFilterData";
         Ddo_xt_configvalue2_Datalisttype = "Dynamic";
         Ddo_xt_configvalue2_Includedatalist = Convert.ToBoolean( -1);
         Ddo_xt_configvalue2_Filterisrange = Convert.ToBoolean( 0);
         Ddo_xt_configvalue2_Filtertype = "Character";
         Ddo_xt_configvalue2_Includefilter = Convert.ToBoolean( -1);
         Ddo_xt_configvalue2_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_xt_configvalue2_Includesortasc = Convert.ToBoolean( -1);
         Ddo_xt_configvalue2_Titlecontrolidtoreplace = "";
         Ddo_xt_configvalue2_Dropdownoptionstype = "GridTitleSettings";
         Ddo_xt_configvalue2_Cls = "ColumnSettings";
         Ddo_xt_configvalue2_Tooltip = "WWP_TSColumnOptions";
         Ddo_xt_configvalue2_Caption = "";
         Ddo_xt_configvalue1_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_configvalue1_Noresultsfound = "WWP_TSNoResults";
         Ddo_xt_configvalue1_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_xt_configvalue1_Loadingdata = "WWP_TSLoading";
         Ddo_xt_configvalue1_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_configvalue1_Sortasc = "WWP_TSSortASC";
         Ddo_xt_configvalue1_Datalistupdateminimumcharacters = 0;
         Ddo_xt_configvalue1_Datalistproc = "XT_ConfigWWGetFilterData";
         Ddo_xt_configvalue1_Datalisttype = "Dynamic";
         Ddo_xt_configvalue1_Includedatalist = Convert.ToBoolean( -1);
         Ddo_xt_configvalue1_Filterisrange = Convert.ToBoolean( 0);
         Ddo_xt_configvalue1_Filtertype = "Character";
         Ddo_xt_configvalue1_Includefilter = Convert.ToBoolean( -1);
         Ddo_xt_configvalue1_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_xt_configvalue1_Includesortasc = Convert.ToBoolean( -1);
         Ddo_xt_configvalue1_Titlecontrolidtoreplace = "";
         Ddo_xt_configvalue1_Dropdownoptionstype = "GridTitleSettings";
         Ddo_xt_configvalue1_Cls = "ColumnSettings";
         Ddo_xt_configvalue1_Tooltip = "WWP_TSColumnOptions";
         Ddo_xt_configvalue1_Caption = "";
         Ddo_xt_configkey_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_configkey_Noresultsfound = "WWP_TSNoResults";
         Ddo_xt_configkey_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_xt_configkey_Loadingdata = "WWP_TSLoading";
         Ddo_xt_configkey_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_configkey_Sortasc = "WWP_TSSortASC";
         Ddo_xt_configkey_Datalistupdateminimumcharacters = 0;
         Ddo_xt_configkey_Datalistproc = "XT_ConfigWWGetFilterData";
         Ddo_xt_configkey_Datalisttype = "Dynamic";
         Ddo_xt_configkey_Includedatalist = Convert.ToBoolean( -1);
         Ddo_xt_configkey_Filterisrange = Convert.ToBoolean( 0);
         Ddo_xt_configkey_Filtertype = "Character";
         Ddo_xt_configkey_Includefilter = Convert.ToBoolean( -1);
         Ddo_xt_configkey_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_xt_configkey_Includesortasc = Convert.ToBoolean( -1);
         Ddo_xt_configkey_Titlecontrolidtoreplace = "";
         Ddo_xt_configkey_Dropdownoptionstype = "GridTitleSettings";
         Ddo_xt_configkey_Cls = "ColumnSettings";
         Ddo_xt_configkey_Tooltip = "WWP_TSColumnOptions";
         Ddo_xt_configkey_Caption = "";
         Ddo_xt_configid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_configid_Rangefilterto = "WWP_TSTo";
         Ddo_xt_configid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_xt_configid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_xt_configid_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_configid_Sortasc = "WWP_TSSortASC";
         Ddo_xt_configid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_xt_configid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_xt_configid_Filtertype = "Numeric";
         Ddo_xt_configid_Includefilter = Convert.ToBoolean( -1);
         Ddo_xt_configid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_xt_configid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_xt_configid_Titlecontrolidtoreplace = "";
         Ddo_xt_configid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_xt_configid_Cls = "ColumnSettings";
         Ddo_xt_configid_Tooltip = "WWP_TSColumnOptions";
         Ddo_xt_configid_Caption = "";
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
         Form.Caption = " 系统配置表";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV19ddo_XT_ConfigIDTitleControlIdToReplace',fld:'vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_XT_ConfigKeyTitleControlIdToReplace',fld:'vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_XT_ConfigValue1TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_XT_ConfigValue2TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV17TFXT_ConfigID',fld:'vTFXT_CONFIGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFXT_ConfigID_To',fld:'vTFXT_CONFIGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFXT_ConfigKey',fld:'vTFXT_CONFIGKEY',pic:''},{av:'AV22TFXT_ConfigKey_Sel',fld:'vTFXT_CONFIGKEY_SEL',pic:''},{av:'AV25TFXT_ConfigValue1',fld:'vTFXT_CONFIGVALUE1',pic:''},{av:'AV26TFXT_ConfigValue1_Sel',fld:'vTFXT_CONFIGVALUE1_SEL',pic:''},{av:'AV29TFXT_ConfigValue2',fld:'vTFXT_CONFIGVALUE2',pic:''},{av:'AV30TFXT_ConfigValue2_Sel',fld:'vTFXT_CONFIGVALUE2_SEL',pic:''},{av:'AV56Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV16XT_ConfigIDTitleFilterData',fld:'vXT_CONFIGIDTITLEFILTERDATA',pic:''},{av:'AV20XT_ConfigKeyTitleFilterData',fld:'vXT_CONFIGKEYTITLEFILTERDATA',pic:''},{av:'AV24XT_ConfigValue1TitleFilterData',fld:'vXT_CONFIGVALUE1TITLEFILTERDATA',pic:''},{av:'AV28XT_ConfigValue2TitleFilterData',fld:'vXT_CONFIGVALUE2TITLEFILTERDATA',pic:''},{av:'edtXT_ConfigID_Titleformat',ctrl:'XT_CONFIGID',prop:'Titleformat'},{av:'edtXT_ConfigID_Title',ctrl:'XT_CONFIGID',prop:'Title'},{av:'edtXT_ConfigKey_Titleformat',ctrl:'XT_CONFIGKEY',prop:'Titleformat'},{av:'edtXT_ConfigKey_Title',ctrl:'XT_CONFIGKEY',prop:'Title'},{av:'edtXT_ConfigValue1_Titleformat',ctrl:'XT_CONFIGVALUE1',prop:'Titleformat'},{av:'edtXT_ConfigValue1_Title',ctrl:'XT_CONFIGVALUE1',prop:'Title'},{av:'edtXT_ConfigValue2_Titleformat',ctrl:'XT_CONFIGVALUE2',prop:'Titleformat'},{av:'edtXT_ConfigValue2_Title',ctrl:'XT_CONFIGVALUE2',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E116X2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFXT_ConfigID',fld:'vTFXT_CONFIGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFXT_ConfigID_To',fld:'vTFXT_CONFIGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFXT_ConfigKey',fld:'vTFXT_CONFIGKEY',pic:''},{av:'AV22TFXT_ConfigKey_Sel',fld:'vTFXT_CONFIGKEY_SEL',pic:''},{av:'AV25TFXT_ConfigValue1',fld:'vTFXT_CONFIGVALUE1',pic:''},{av:'AV26TFXT_ConfigValue1_Sel',fld:'vTFXT_CONFIGVALUE1_SEL',pic:''},{av:'AV29TFXT_ConfigValue2',fld:'vTFXT_CONFIGVALUE2',pic:''},{av:'AV30TFXT_ConfigValue2_Sel',fld:'vTFXT_CONFIGVALUE2_SEL',pic:''},{av:'AV19ddo_XT_ConfigIDTitleControlIdToReplace',fld:'vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_XT_ConfigKeyTitleControlIdToReplace',fld:'vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_XT_ConfigValue1TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_XT_ConfigValue2TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE',pic:''},{av:'AV56Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E126X2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFXT_ConfigID',fld:'vTFXT_CONFIGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFXT_ConfigID_To',fld:'vTFXT_CONFIGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFXT_ConfigKey',fld:'vTFXT_CONFIGKEY',pic:''},{av:'AV22TFXT_ConfigKey_Sel',fld:'vTFXT_CONFIGKEY_SEL',pic:''},{av:'AV25TFXT_ConfigValue1',fld:'vTFXT_CONFIGVALUE1',pic:''},{av:'AV26TFXT_ConfigValue1_Sel',fld:'vTFXT_CONFIGVALUE1_SEL',pic:''},{av:'AV29TFXT_ConfigValue2',fld:'vTFXT_CONFIGVALUE2',pic:''},{av:'AV30TFXT_ConfigValue2_Sel',fld:'vTFXT_CONFIGVALUE2_SEL',pic:''},{av:'AV19ddo_XT_ConfigIDTitleControlIdToReplace',fld:'vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_XT_ConfigKeyTitleControlIdToReplace',fld:'vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_XT_ConfigValue1TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_XT_ConfigValue2TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE',pic:''},{av:'AV56Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_XT_CONFIGID.ONOPTIONCLICKED","{handler:'E136X2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFXT_ConfigID',fld:'vTFXT_CONFIGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFXT_ConfigID_To',fld:'vTFXT_CONFIGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFXT_ConfigKey',fld:'vTFXT_CONFIGKEY',pic:''},{av:'AV22TFXT_ConfigKey_Sel',fld:'vTFXT_CONFIGKEY_SEL',pic:''},{av:'AV25TFXT_ConfigValue1',fld:'vTFXT_CONFIGVALUE1',pic:''},{av:'AV26TFXT_ConfigValue1_Sel',fld:'vTFXT_CONFIGVALUE1_SEL',pic:''},{av:'AV29TFXT_ConfigValue2',fld:'vTFXT_CONFIGVALUE2',pic:''},{av:'AV30TFXT_ConfigValue2_Sel',fld:'vTFXT_CONFIGVALUE2_SEL',pic:''},{av:'AV19ddo_XT_ConfigIDTitleControlIdToReplace',fld:'vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_XT_ConfigKeyTitleControlIdToReplace',fld:'vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_XT_ConfigValue1TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_XT_ConfigValue2TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE',pic:''},{av:'AV56Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_xt_configid_Activeeventkey',ctrl:'DDO_XT_CONFIGID',prop:'ActiveEventKey'},{av:'Ddo_xt_configid_Filteredtext_get',ctrl:'DDO_XT_CONFIGID',prop:'FilteredText_get'},{av:'Ddo_xt_configid_Filteredtextto_get',ctrl:'DDO_XT_CONFIGID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_XT_CONFIGID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_configid_Sortedstatus',ctrl:'DDO_XT_CONFIGID',prop:'SortedStatus'},{av:'AV17TFXT_ConfigID',fld:'vTFXT_CONFIGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFXT_ConfigID_To',fld:'vTFXT_CONFIGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_xt_configkey_Sortedstatus',ctrl:'DDO_XT_CONFIGKEY',prop:'SortedStatus'},{av:'Ddo_xt_configvalue1_Sortedstatus',ctrl:'DDO_XT_CONFIGVALUE1',prop:'SortedStatus'},{av:'Ddo_xt_configvalue2_Sortedstatus',ctrl:'DDO_XT_CONFIGVALUE2',prop:'SortedStatus'},{av:'AV16XT_ConfigIDTitleFilterData',fld:'vXT_CONFIGIDTITLEFILTERDATA',pic:''},{av:'AV20XT_ConfigKeyTitleFilterData',fld:'vXT_CONFIGKEYTITLEFILTERDATA',pic:''},{av:'AV24XT_ConfigValue1TitleFilterData',fld:'vXT_CONFIGVALUE1TITLEFILTERDATA',pic:''},{av:'AV28XT_ConfigValue2TitleFilterData',fld:'vXT_CONFIGVALUE2TITLEFILTERDATA',pic:''},{av:'edtXT_ConfigID_Titleformat',ctrl:'XT_CONFIGID',prop:'Titleformat'},{av:'edtXT_ConfigID_Title',ctrl:'XT_CONFIGID',prop:'Title'},{av:'edtXT_ConfigKey_Titleformat',ctrl:'XT_CONFIGKEY',prop:'Titleformat'},{av:'edtXT_ConfigKey_Title',ctrl:'XT_CONFIGKEY',prop:'Title'},{av:'edtXT_ConfigValue1_Titleformat',ctrl:'XT_CONFIGVALUE1',prop:'Titleformat'},{av:'edtXT_ConfigValue1_Title',ctrl:'XT_CONFIGVALUE1',prop:'Title'},{av:'edtXT_ConfigValue2_Titleformat',ctrl:'XT_CONFIGVALUE2',prop:'Titleformat'},{av:'edtXT_ConfigValue2_Title',ctrl:'XT_CONFIGVALUE2',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_XT_CONFIGKEY.ONOPTIONCLICKED","{handler:'E146X2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFXT_ConfigID',fld:'vTFXT_CONFIGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFXT_ConfigID_To',fld:'vTFXT_CONFIGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFXT_ConfigKey',fld:'vTFXT_CONFIGKEY',pic:''},{av:'AV22TFXT_ConfigKey_Sel',fld:'vTFXT_CONFIGKEY_SEL',pic:''},{av:'AV25TFXT_ConfigValue1',fld:'vTFXT_CONFIGVALUE1',pic:''},{av:'AV26TFXT_ConfigValue1_Sel',fld:'vTFXT_CONFIGVALUE1_SEL',pic:''},{av:'AV29TFXT_ConfigValue2',fld:'vTFXT_CONFIGVALUE2',pic:''},{av:'AV30TFXT_ConfigValue2_Sel',fld:'vTFXT_CONFIGVALUE2_SEL',pic:''},{av:'AV19ddo_XT_ConfigIDTitleControlIdToReplace',fld:'vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_XT_ConfigKeyTitleControlIdToReplace',fld:'vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_XT_ConfigValue1TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_XT_ConfigValue2TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE',pic:''},{av:'AV56Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_xt_configkey_Activeeventkey',ctrl:'DDO_XT_CONFIGKEY',prop:'ActiveEventKey'},{av:'Ddo_xt_configkey_Filteredtext_get',ctrl:'DDO_XT_CONFIGKEY',prop:'FilteredText_get'},{av:'Ddo_xt_configkey_Selectedvalue_get',ctrl:'DDO_XT_CONFIGKEY',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_XT_CONFIGKEY.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_configkey_Sortedstatus',ctrl:'DDO_XT_CONFIGKEY',prop:'SortedStatus'},{av:'AV21TFXT_ConfigKey',fld:'vTFXT_CONFIGKEY',pic:''},{av:'AV22TFXT_ConfigKey_Sel',fld:'vTFXT_CONFIGKEY_SEL',pic:''},{av:'Ddo_xt_configid_Sortedstatus',ctrl:'DDO_XT_CONFIGID',prop:'SortedStatus'},{av:'Ddo_xt_configvalue1_Sortedstatus',ctrl:'DDO_XT_CONFIGVALUE1',prop:'SortedStatus'},{av:'Ddo_xt_configvalue2_Sortedstatus',ctrl:'DDO_XT_CONFIGVALUE2',prop:'SortedStatus'},{av:'AV16XT_ConfigIDTitleFilterData',fld:'vXT_CONFIGIDTITLEFILTERDATA',pic:''},{av:'AV20XT_ConfigKeyTitleFilterData',fld:'vXT_CONFIGKEYTITLEFILTERDATA',pic:''},{av:'AV24XT_ConfigValue1TitleFilterData',fld:'vXT_CONFIGVALUE1TITLEFILTERDATA',pic:''},{av:'AV28XT_ConfigValue2TitleFilterData',fld:'vXT_CONFIGVALUE2TITLEFILTERDATA',pic:''},{av:'edtXT_ConfigID_Titleformat',ctrl:'XT_CONFIGID',prop:'Titleformat'},{av:'edtXT_ConfigID_Title',ctrl:'XT_CONFIGID',prop:'Title'},{av:'edtXT_ConfigKey_Titleformat',ctrl:'XT_CONFIGKEY',prop:'Titleformat'},{av:'edtXT_ConfigKey_Title',ctrl:'XT_CONFIGKEY',prop:'Title'},{av:'edtXT_ConfigValue1_Titleformat',ctrl:'XT_CONFIGVALUE1',prop:'Titleformat'},{av:'edtXT_ConfigValue1_Title',ctrl:'XT_CONFIGVALUE1',prop:'Title'},{av:'edtXT_ConfigValue2_Titleformat',ctrl:'XT_CONFIGVALUE2',prop:'Titleformat'},{av:'edtXT_ConfigValue2_Title',ctrl:'XT_CONFIGVALUE2',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_XT_CONFIGVALUE1.ONOPTIONCLICKED","{handler:'E156X2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFXT_ConfigID',fld:'vTFXT_CONFIGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFXT_ConfigID_To',fld:'vTFXT_CONFIGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFXT_ConfigKey',fld:'vTFXT_CONFIGKEY',pic:''},{av:'AV22TFXT_ConfigKey_Sel',fld:'vTFXT_CONFIGKEY_SEL',pic:''},{av:'AV25TFXT_ConfigValue1',fld:'vTFXT_CONFIGVALUE1',pic:''},{av:'AV26TFXT_ConfigValue1_Sel',fld:'vTFXT_CONFIGVALUE1_SEL',pic:''},{av:'AV29TFXT_ConfigValue2',fld:'vTFXT_CONFIGVALUE2',pic:''},{av:'AV30TFXT_ConfigValue2_Sel',fld:'vTFXT_CONFIGVALUE2_SEL',pic:''},{av:'AV19ddo_XT_ConfigIDTitleControlIdToReplace',fld:'vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_XT_ConfigKeyTitleControlIdToReplace',fld:'vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_XT_ConfigValue1TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_XT_ConfigValue2TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE',pic:''},{av:'AV56Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_xt_configvalue1_Activeeventkey',ctrl:'DDO_XT_CONFIGVALUE1',prop:'ActiveEventKey'},{av:'Ddo_xt_configvalue1_Filteredtext_get',ctrl:'DDO_XT_CONFIGVALUE1',prop:'FilteredText_get'},{av:'Ddo_xt_configvalue1_Selectedvalue_get',ctrl:'DDO_XT_CONFIGVALUE1',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_XT_CONFIGVALUE1.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_configvalue1_Sortedstatus',ctrl:'DDO_XT_CONFIGVALUE1',prop:'SortedStatus'},{av:'AV25TFXT_ConfigValue1',fld:'vTFXT_CONFIGVALUE1',pic:''},{av:'AV26TFXT_ConfigValue1_Sel',fld:'vTFXT_CONFIGVALUE1_SEL',pic:''},{av:'Ddo_xt_configid_Sortedstatus',ctrl:'DDO_XT_CONFIGID',prop:'SortedStatus'},{av:'Ddo_xt_configkey_Sortedstatus',ctrl:'DDO_XT_CONFIGKEY',prop:'SortedStatus'},{av:'Ddo_xt_configvalue2_Sortedstatus',ctrl:'DDO_XT_CONFIGVALUE2',prop:'SortedStatus'},{av:'AV16XT_ConfigIDTitleFilterData',fld:'vXT_CONFIGIDTITLEFILTERDATA',pic:''},{av:'AV20XT_ConfigKeyTitleFilterData',fld:'vXT_CONFIGKEYTITLEFILTERDATA',pic:''},{av:'AV24XT_ConfigValue1TitleFilterData',fld:'vXT_CONFIGVALUE1TITLEFILTERDATA',pic:''},{av:'AV28XT_ConfigValue2TitleFilterData',fld:'vXT_CONFIGVALUE2TITLEFILTERDATA',pic:''},{av:'edtXT_ConfigID_Titleformat',ctrl:'XT_CONFIGID',prop:'Titleformat'},{av:'edtXT_ConfigID_Title',ctrl:'XT_CONFIGID',prop:'Title'},{av:'edtXT_ConfigKey_Titleformat',ctrl:'XT_CONFIGKEY',prop:'Titleformat'},{av:'edtXT_ConfigKey_Title',ctrl:'XT_CONFIGKEY',prop:'Title'},{av:'edtXT_ConfigValue1_Titleformat',ctrl:'XT_CONFIGVALUE1',prop:'Titleformat'},{av:'edtXT_ConfigValue1_Title',ctrl:'XT_CONFIGVALUE1',prop:'Title'},{av:'edtXT_ConfigValue2_Titleformat',ctrl:'XT_CONFIGVALUE2',prop:'Titleformat'},{av:'edtXT_ConfigValue2_Title',ctrl:'XT_CONFIGVALUE2',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_XT_CONFIGVALUE2.ONOPTIONCLICKED","{handler:'E166X2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFXT_ConfigID',fld:'vTFXT_CONFIGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFXT_ConfigID_To',fld:'vTFXT_CONFIGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFXT_ConfigKey',fld:'vTFXT_CONFIGKEY',pic:''},{av:'AV22TFXT_ConfigKey_Sel',fld:'vTFXT_CONFIGKEY_SEL',pic:''},{av:'AV25TFXT_ConfigValue1',fld:'vTFXT_CONFIGVALUE1',pic:''},{av:'AV26TFXT_ConfigValue1_Sel',fld:'vTFXT_CONFIGVALUE1_SEL',pic:''},{av:'AV29TFXT_ConfigValue2',fld:'vTFXT_CONFIGVALUE2',pic:''},{av:'AV30TFXT_ConfigValue2_Sel',fld:'vTFXT_CONFIGVALUE2_SEL',pic:''},{av:'AV19ddo_XT_ConfigIDTitleControlIdToReplace',fld:'vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_XT_ConfigKeyTitleControlIdToReplace',fld:'vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_XT_ConfigValue1TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_XT_ConfigValue2TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE',pic:''},{av:'AV56Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_xt_configvalue2_Activeeventkey',ctrl:'DDO_XT_CONFIGVALUE2',prop:'ActiveEventKey'},{av:'Ddo_xt_configvalue2_Filteredtext_get',ctrl:'DDO_XT_CONFIGVALUE2',prop:'FilteredText_get'},{av:'Ddo_xt_configvalue2_Selectedvalue_get',ctrl:'DDO_XT_CONFIGVALUE2',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_XT_CONFIGVALUE2.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_configvalue2_Sortedstatus',ctrl:'DDO_XT_CONFIGVALUE2',prop:'SortedStatus'},{av:'AV29TFXT_ConfigValue2',fld:'vTFXT_CONFIGVALUE2',pic:''},{av:'AV30TFXT_ConfigValue2_Sel',fld:'vTFXT_CONFIGVALUE2_SEL',pic:''},{av:'Ddo_xt_configid_Sortedstatus',ctrl:'DDO_XT_CONFIGID',prop:'SortedStatus'},{av:'Ddo_xt_configkey_Sortedstatus',ctrl:'DDO_XT_CONFIGKEY',prop:'SortedStatus'},{av:'Ddo_xt_configvalue1_Sortedstatus',ctrl:'DDO_XT_CONFIGVALUE1',prop:'SortedStatus'},{av:'AV16XT_ConfigIDTitleFilterData',fld:'vXT_CONFIGIDTITLEFILTERDATA',pic:''},{av:'AV20XT_ConfigKeyTitleFilterData',fld:'vXT_CONFIGKEYTITLEFILTERDATA',pic:''},{av:'AV24XT_ConfigValue1TitleFilterData',fld:'vXT_CONFIGVALUE1TITLEFILTERDATA',pic:''},{av:'AV28XT_ConfigValue2TitleFilterData',fld:'vXT_CONFIGVALUE2TITLEFILTERDATA',pic:''},{av:'edtXT_ConfigID_Titleformat',ctrl:'XT_CONFIGID',prop:'Titleformat'},{av:'edtXT_ConfigID_Title',ctrl:'XT_CONFIGID',prop:'Title'},{av:'edtXT_ConfigKey_Titleformat',ctrl:'XT_CONFIGKEY',prop:'Titleformat'},{av:'edtXT_ConfigKey_Title',ctrl:'XT_CONFIGKEY',prop:'Title'},{av:'edtXT_ConfigValue1_Titleformat',ctrl:'XT_CONFIGVALUE1',prop:'Titleformat'},{av:'edtXT_ConfigValue1_Title',ctrl:'XT_CONFIGVALUE1',prop:'Title'},{av:'edtXT_ConfigValue2_Titleformat',ctrl:'XT_CONFIGVALUE2',prop:'Titleformat'},{av:'edtXT_ConfigValue2_Title',ctrl:'XT_CONFIGVALUE2',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E206X2',iparms:[{av:'A195XT_ConfigID',fld:'XT_CONFIGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV37Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'},{av:'AV38Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV40Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'},{av:'edtXT_ConfigKey_Link',ctrl:'XT_CONFIGKEY',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E176X2',iparms:[{av:'A195XT_ConfigID',fld:'XT_CONFIGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
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
         Ddo_xt_configid_Activeeventkey = "";
         Ddo_xt_configid_Filteredtext_get = "";
         Ddo_xt_configid_Filteredtextto_get = "";
         Ddo_xt_configkey_Activeeventkey = "";
         Ddo_xt_configkey_Filteredtext_get = "";
         Ddo_xt_configkey_Selectedvalue_get = "";
         Ddo_xt_configvalue1_Activeeventkey = "";
         Ddo_xt_configvalue1_Filteredtext_get = "";
         Ddo_xt_configvalue1_Selectedvalue_get = "";
         Ddo_xt_configvalue2_Activeeventkey = "";
         Ddo_xt_configvalue2_Filteredtext_get = "";
         Ddo_xt_configvalue2_Selectedvalue_get = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV21TFXT_ConfigKey = "";
         AV22TFXT_ConfigKey_Sel = "";
         AV25TFXT_ConfigValue1 = "";
         AV26TFXT_ConfigValue1_Sel = "";
         AV29TFXT_ConfigValue2 = "";
         AV30TFXT_ConfigValue2_Sel = "";
         AV19ddo_XT_ConfigIDTitleControlIdToReplace = "";
         AV23ddo_XT_ConfigKeyTitleControlIdToReplace = "";
         AV27ddo_XT_ConfigValue1TitleControlIdToReplace = "";
         AV31ddo_XT_ConfigValue2TitleControlIdToReplace = "";
         AV56Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV32DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV16XT_ConfigIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20XT_ConfigKeyTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24XT_ConfigValue1TitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28XT_ConfigValue2TitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_xt_configid_Filteredtext_set = "";
         Ddo_xt_configid_Filteredtextto_set = "";
         Ddo_xt_configid_Sortedstatus = "";
         Ddo_xt_configkey_Filteredtext_set = "";
         Ddo_xt_configkey_Selectedvalue_set = "";
         Ddo_xt_configkey_Sortedstatus = "";
         Ddo_xt_configvalue1_Filteredtext_set = "";
         Ddo_xt_configvalue1_Selectedvalue_set = "";
         Ddo_xt_configvalue1_Sortedstatus = "";
         Ddo_xt_configvalue2_Filteredtext_set = "";
         Ddo_xt_configvalue2_Selectedvalue_set = "";
         Ddo_xt_configvalue2_Sortedstatus = "";
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
         AV37Display = "";
         AV38Update = "";
         AV40Delete = "";
         A196XT_ConfigKey = "";
         A197XT_ConfigValue1 = "";
         A198XT_ConfigValue2 = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_xt_configid = new GXUserControl();
         ucDdo_xt_configkey = new GXUserControl();
         ucDdo_xt_configvalue1 = new GXUserControl();
         ucDdo_xt_configvalue2 = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV53Display_GXI = "";
         AV54Update_GXI = "";
         AV55Delete_GXI = "";
         scmdbuf = "";
         lV47XT_ConfigWWDS_3_Tfxt_configkey = "";
         lV49XT_ConfigWWDS_5_Tfxt_configvalue1 = "";
         lV51XT_ConfigWWDS_7_Tfxt_configvalue2 = "";
         AV48XT_ConfigWWDS_4_Tfxt_configkey_sel = "";
         AV47XT_ConfigWWDS_3_Tfxt_configkey = "";
         AV50XT_ConfigWWDS_6_Tfxt_configvalue1_sel = "";
         AV49XT_ConfigWWDS_5_Tfxt_configvalue1 = "";
         AV52XT_ConfigWWDS_8_Tfxt_configvalue2_sel = "";
         AV51XT_ConfigWWDS_7_Tfxt_configvalue2 = "";
         H006X2_A198XT_ConfigValue2 = new String[] {""} ;
         H006X2_n198XT_ConfigValue2 = new bool[] {false} ;
         H006X2_A197XT_ConfigValue1 = new String[] {""} ;
         H006X2_n197XT_ConfigValue1 = new bool[] {false} ;
         H006X2_A196XT_ConfigKey = new String[] {""} ;
         H006X2_n196XT_ConfigKey = new bool[] {false} ;
         H006X2_A195XT_ConfigID = new long[1] ;
         H006X3_AGRID_nRecordCount = new long[1] ;
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.xt_configww__default(),
            new Object[][] {
                new Object[] {
               H006X2_A198XT_ConfigValue2, H006X2_n198XT_ConfigValue2, H006X2_A197XT_ConfigValue1, H006X2_n197XT_ConfigValue1, H006X2_A196XT_ConfigKey, H006X2_n196XT_ConfigKey, H006X2_A195XT_ConfigID
               }
               , new Object[] {
               H006X3_AGRID_nRecordCount
               }
            }
         );
         AV56Pgmname = "XT_ConfigWW";
         /* GeneXus formulas. */
         AV56Pgmname = "XT_ConfigWW";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_28 ;
      private short nGXsfl_28_idx=1 ;
      private short GRID_nEOF ;
      private short AV13OrderedBy ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtXT_ConfigID_Titleformat ;
      private short edtXT_ConfigKey_Titleformat ;
      private short edtXT_ConfigValue1_Titleformat ;
      private short edtXT_ConfigValue2_Titleformat ;
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
      private int Ddo_xt_configkey_Datalistupdateminimumcharacters ;
      private int Ddo_xt_configvalue1_Datalistupdateminimumcharacters ;
      private int Ddo_xt_configvalue2_Datalistupdateminimumcharacters ;
      private int bttBtninsert_Visible ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavUpdate_Visible ;
      private int edtavDelete_Visible ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_xt_configidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_xt_configkeytitlecontrolidtoreplace_Visible ;
      private int edtavDdo_xt_configvalue1titlecontrolidtoreplace_Visible ;
      private int edtavDdo_xt_configvalue2titlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfxt_configid_Visible ;
      private int edtavTfxt_configid_to_Visible ;
      private int edtavTfxt_configkey_Visible ;
      private int edtavTfxt_configkey_sel_Visible ;
      private int edtavTfxt_configvalue1_Visible ;
      private int edtavTfxt_configvalue1_sel_Visible ;
      private int edtavTfxt_configvalue2_Visible ;
      private int edtavTfxt_configvalue2_sel_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV33PageToGo ;
      private int AV57GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV17TFXT_ConfigID ;
      private long AV18TFXT_ConfigID_To ;
      private long AV34GridCurrentPage ;
      private long AV36GridRecordCount ;
      private long AV35GridPageSize ;
      private long A195XT_ConfigID ;
      private long GRID_nCurrentRecord ;
      private long AV45XT_ConfigWWDS_1_Tfxt_configid ;
      private long AV46XT_ConfigWWDS_2_Tfxt_configid_to ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_xt_configid_Activeeventkey ;
      private String Ddo_xt_configid_Filteredtext_get ;
      private String Ddo_xt_configid_Filteredtextto_get ;
      private String Ddo_xt_configkey_Activeeventkey ;
      private String Ddo_xt_configkey_Filteredtext_get ;
      private String Ddo_xt_configkey_Selectedvalue_get ;
      private String Ddo_xt_configvalue1_Activeeventkey ;
      private String Ddo_xt_configvalue1_Filteredtext_get ;
      private String Ddo_xt_configvalue1_Selectedvalue_get ;
      private String Ddo_xt_configvalue2_Activeeventkey ;
      private String Ddo_xt_configvalue2_Filteredtext_get ;
      private String Ddo_xt_configvalue2_Selectedvalue_get ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_28_idx="0001" ;
      private String AV56Pgmname ;
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
      private String Ddo_xt_configid_Caption ;
      private String Ddo_xt_configid_Tooltip ;
      private String Ddo_xt_configid_Cls ;
      private String Ddo_xt_configid_Filteredtext_set ;
      private String Ddo_xt_configid_Filteredtextto_set ;
      private String Ddo_xt_configid_Dropdownoptionstype ;
      private String Ddo_xt_configid_Titlecontrolidtoreplace ;
      private String Ddo_xt_configid_Sortedstatus ;
      private String Ddo_xt_configid_Filtertype ;
      private String Ddo_xt_configid_Sortasc ;
      private String Ddo_xt_configid_Sortdsc ;
      private String Ddo_xt_configid_Cleanfilter ;
      private String Ddo_xt_configid_Rangefilterfrom ;
      private String Ddo_xt_configid_Rangefilterto ;
      private String Ddo_xt_configid_Searchbuttontext ;
      private String Ddo_xt_configkey_Caption ;
      private String Ddo_xt_configkey_Tooltip ;
      private String Ddo_xt_configkey_Cls ;
      private String Ddo_xt_configkey_Filteredtext_set ;
      private String Ddo_xt_configkey_Selectedvalue_set ;
      private String Ddo_xt_configkey_Dropdownoptionstype ;
      private String Ddo_xt_configkey_Titlecontrolidtoreplace ;
      private String Ddo_xt_configkey_Sortedstatus ;
      private String Ddo_xt_configkey_Filtertype ;
      private String Ddo_xt_configkey_Datalisttype ;
      private String Ddo_xt_configkey_Datalistproc ;
      private String Ddo_xt_configkey_Sortasc ;
      private String Ddo_xt_configkey_Sortdsc ;
      private String Ddo_xt_configkey_Loadingdata ;
      private String Ddo_xt_configkey_Cleanfilter ;
      private String Ddo_xt_configkey_Noresultsfound ;
      private String Ddo_xt_configkey_Searchbuttontext ;
      private String Ddo_xt_configvalue1_Caption ;
      private String Ddo_xt_configvalue1_Tooltip ;
      private String Ddo_xt_configvalue1_Cls ;
      private String Ddo_xt_configvalue1_Filteredtext_set ;
      private String Ddo_xt_configvalue1_Selectedvalue_set ;
      private String Ddo_xt_configvalue1_Dropdownoptionstype ;
      private String Ddo_xt_configvalue1_Titlecontrolidtoreplace ;
      private String Ddo_xt_configvalue1_Sortedstatus ;
      private String Ddo_xt_configvalue1_Filtertype ;
      private String Ddo_xt_configvalue1_Datalisttype ;
      private String Ddo_xt_configvalue1_Datalistproc ;
      private String Ddo_xt_configvalue1_Sortasc ;
      private String Ddo_xt_configvalue1_Sortdsc ;
      private String Ddo_xt_configvalue1_Loadingdata ;
      private String Ddo_xt_configvalue1_Cleanfilter ;
      private String Ddo_xt_configvalue1_Noresultsfound ;
      private String Ddo_xt_configvalue1_Searchbuttontext ;
      private String Ddo_xt_configvalue2_Caption ;
      private String Ddo_xt_configvalue2_Tooltip ;
      private String Ddo_xt_configvalue2_Cls ;
      private String Ddo_xt_configvalue2_Filteredtext_set ;
      private String Ddo_xt_configvalue2_Selectedvalue_set ;
      private String Ddo_xt_configvalue2_Dropdownoptionstype ;
      private String Ddo_xt_configvalue2_Titlecontrolidtoreplace ;
      private String Ddo_xt_configvalue2_Sortedstatus ;
      private String Ddo_xt_configvalue2_Filtertype ;
      private String Ddo_xt_configvalue2_Datalisttype ;
      private String Ddo_xt_configvalue2_Datalistproc ;
      private String Ddo_xt_configvalue2_Sortasc ;
      private String Ddo_xt_configvalue2_Sortdsc ;
      private String Ddo_xt_configvalue2_Loadingdata ;
      private String Ddo_xt_configvalue2_Cleanfilter ;
      private String Ddo_xt_configvalue2_Noresultsfound ;
      private String Ddo_xt_configvalue2_Searchbuttontext ;
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
      private String edtXT_ConfigID_Title ;
      private String edtXT_ConfigKey_Title ;
      private String edtXT_ConfigValue1_Title ;
      private String edtXT_ConfigValue2_Title ;
      private String subGrid_Header ;
      private String edtavDisplay_Link ;
      private String edtavDisplay_Tooltiptext ;
      private String edtavUpdate_Link ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavDelete_Link ;
      private String edtavDelete_Tooltiptext ;
      private String edtXT_ConfigKey_Link ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_xt_configid_Internalname ;
      private String edtavDdo_xt_configidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_xt_configkey_Internalname ;
      private String edtavDdo_xt_configkeytitlecontrolidtoreplace_Internalname ;
      private String Ddo_xt_configvalue1_Internalname ;
      private String edtavDdo_xt_configvalue1titlecontrolidtoreplace_Internalname ;
      private String Ddo_xt_configvalue2_Internalname ;
      private String edtavDdo_xt_configvalue2titlecontrolidtoreplace_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavTfxt_configid_Internalname ;
      private String edtavTfxt_configid_Jsonclick ;
      private String edtavTfxt_configid_to_Internalname ;
      private String edtavTfxt_configid_to_Jsonclick ;
      private String edtavTfxt_configkey_Internalname ;
      private String edtavTfxt_configkey_Jsonclick ;
      private String edtavTfxt_configkey_sel_Internalname ;
      private String edtavTfxt_configkey_sel_Jsonclick ;
      private String edtavTfxt_configvalue1_Internalname ;
      private String edtavTfxt_configvalue1_sel_Internalname ;
      private String edtavTfxt_configvalue2_Internalname ;
      private String edtavTfxt_configvalue2_sel_Internalname ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDisplay_Internalname ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String edtXT_ConfigID_Internalname ;
      private String edtXT_ConfigKey_Internalname ;
      private String edtXT_ConfigValue1_Internalname ;
      private String edtXT_ConfigValue2_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_28_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtXT_ConfigID_Jsonclick ;
      private String edtXT_ConfigKey_Jsonclick ;
      private String edtXT_ConfigValue1_Jsonclick ;
      private String edtXT_ConfigValue2_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV14OrderedDsc ;
      private bool AV39IsAuthorized_Update ;
      private bool AV41IsAuthorized_Delete ;
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
      private bool Ddo_xt_configid_Includesortasc ;
      private bool Ddo_xt_configid_Includesortdsc ;
      private bool Ddo_xt_configid_Includefilter ;
      private bool Ddo_xt_configid_Filterisrange ;
      private bool Ddo_xt_configid_Includedatalist ;
      private bool Ddo_xt_configkey_Includesortasc ;
      private bool Ddo_xt_configkey_Includesortdsc ;
      private bool Ddo_xt_configkey_Includefilter ;
      private bool Ddo_xt_configkey_Filterisrange ;
      private bool Ddo_xt_configkey_Includedatalist ;
      private bool Ddo_xt_configvalue1_Includesortasc ;
      private bool Ddo_xt_configvalue1_Includesortdsc ;
      private bool Ddo_xt_configvalue1_Includefilter ;
      private bool Ddo_xt_configvalue1_Filterisrange ;
      private bool Ddo_xt_configvalue1_Includedatalist ;
      private bool Ddo_xt_configvalue2_Includesortasc ;
      private bool Ddo_xt_configvalue2_Includesortdsc ;
      private bool Ddo_xt_configvalue2_Includefilter ;
      private bool Ddo_xt_configvalue2_Filterisrange ;
      private bool Ddo_xt_configvalue2_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_28_Refreshing=false ;
      private bool n196XT_ConfigKey ;
      private bool n197XT_ConfigValue1 ;
      private bool n198XT_ConfigValue2 ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV42TempBoolean ;
      private bool GXt_boolean2 ;
      private bool AV37Display_IsBlob ;
      private bool AV38Update_IsBlob ;
      private bool AV40Delete_IsBlob ;
      private String AV21TFXT_ConfigKey ;
      private String AV22TFXT_ConfigKey_Sel ;
      private String AV25TFXT_ConfigValue1 ;
      private String AV26TFXT_ConfigValue1_Sel ;
      private String AV29TFXT_ConfigValue2 ;
      private String AV30TFXT_ConfigValue2_Sel ;
      private String AV19ddo_XT_ConfigIDTitleControlIdToReplace ;
      private String AV23ddo_XT_ConfigKeyTitleControlIdToReplace ;
      private String AV27ddo_XT_ConfigValue1TitleControlIdToReplace ;
      private String AV31ddo_XT_ConfigValue2TitleControlIdToReplace ;
      private String A196XT_ConfigKey ;
      private String A197XT_ConfigValue1 ;
      private String A198XT_ConfigValue2 ;
      private String AV53Display_GXI ;
      private String AV54Update_GXI ;
      private String AV55Delete_GXI ;
      private String lV47XT_ConfigWWDS_3_Tfxt_configkey ;
      private String lV49XT_ConfigWWDS_5_Tfxt_configvalue1 ;
      private String lV51XT_ConfigWWDS_7_Tfxt_configvalue2 ;
      private String AV48XT_ConfigWWDS_4_Tfxt_configkey_sel ;
      private String AV47XT_ConfigWWDS_3_Tfxt_configkey ;
      private String AV50XT_ConfigWWDS_6_Tfxt_configvalue1_sel ;
      private String AV49XT_ConfigWWDS_5_Tfxt_configvalue1 ;
      private String AV52XT_ConfigWWDS_8_Tfxt_configvalue2_sel ;
      private String AV51XT_ConfigWWDS_7_Tfxt_configvalue2 ;
      private String AV37Display ;
      private String AV38Update ;
      private String AV40Delete ;
      private IGxSession AV15Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_xt_configid ;
      private GXUserControl ucDdo_xt_configkey ;
      private GXUserControl ucDdo_xt_configvalue1 ;
      private GXUserControl ucDdo_xt_configvalue2 ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H006X2_A198XT_ConfigValue2 ;
      private bool[] H006X2_n198XT_ConfigValue2 ;
      private String[] H006X2_A197XT_ConfigValue1 ;
      private bool[] H006X2_n197XT_ConfigValue1 ;
      private String[] H006X2_A196XT_ConfigKey ;
      private bool[] H006X2_n196XT_ConfigKey ;
      private long[] H006X2_A195XT_ConfigID ;
      private long[] H006X3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV16XT_ConfigIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV20XT_ConfigKeyTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV24XT_ConfigValue1TitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV28XT_ConfigValue2TitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV11GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV12GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV32DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class xt_configww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H006X2( IGxContext context ,
                                             long AV45XT_ConfigWWDS_1_Tfxt_configid ,
                                             long AV46XT_ConfigWWDS_2_Tfxt_configid_to ,
                                             String AV48XT_ConfigWWDS_4_Tfxt_configkey_sel ,
                                             String AV47XT_ConfigWWDS_3_Tfxt_configkey ,
                                             String AV50XT_ConfigWWDS_6_Tfxt_configvalue1_sel ,
                                             String AV49XT_ConfigWWDS_5_Tfxt_configvalue1 ,
                                             String AV52XT_ConfigWWDS_8_Tfxt_configvalue2_sel ,
                                             String AV51XT_ConfigWWDS_7_Tfxt_configvalue2 ,
                                             long A195XT_ConfigID ,
                                             String A196XT_ConfigKey ,
                                             String A197XT_ConfigValue1 ,
                                             String A198XT_ConfigValue2 ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [11] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [XT_ConfigValue2], [XT_ConfigValue1], [XT_ConfigKey], [XT_ConfigID]";
         sFromString = " FROM [XT_Config] WITH (NOLOCK)";
         sOrderString = "";
         if ( ! (0==AV45XT_ConfigWWDS_1_Tfxt_configid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigID] >= @AV45XT_ConfigWWDS_1_Tfxt_configid)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigID] >= @AV45XT_ConfigWWDS_1_Tfxt_configid)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ! (0==AV46XT_ConfigWWDS_2_Tfxt_configid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigID] <= @AV46XT_ConfigWWDS_2_Tfxt_configid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigID] <= @AV46XT_ConfigWWDS_2_Tfxt_configid_to)";
            }
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV48XT_ConfigWWDS_4_Tfxt_configkey_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47XT_ConfigWWDS_3_Tfxt_configkey)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigKey] like @lV47XT_ConfigWWDS_3_Tfxt_configkey)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigKey] like @lV47XT_ConfigWWDS_3_Tfxt_configkey)";
            }
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48XT_ConfigWWDS_4_Tfxt_configkey_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigKey] = @AV48XT_ConfigWWDS_4_Tfxt_configkey_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigKey] = @AV48XT_ConfigWWDS_4_Tfxt_configkey_sel)";
            }
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV50XT_ConfigWWDS_6_Tfxt_configvalue1_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV49XT_ConfigWWDS_5_Tfxt_configvalue1)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigValue1] like @lV49XT_ConfigWWDS_5_Tfxt_configvalue1)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigValue1] like @lV49XT_ConfigWWDS_5_Tfxt_configvalue1)";
            }
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV50XT_ConfigWWDS_6_Tfxt_configvalue1_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigValue1] = @AV50XT_ConfigWWDS_6_Tfxt_configvalue1_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigValue1] = @AV50XT_ConfigWWDS_6_Tfxt_configvalue1_sel)";
            }
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV52XT_ConfigWWDS_8_Tfxt_configvalue2_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51XT_ConfigWWDS_7_Tfxt_configvalue2)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigValue2] like @lV51XT_ConfigWWDS_7_Tfxt_configvalue2)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigValue2] like @lV51XT_ConfigWWDS_7_Tfxt_configvalue2)";
            }
         }
         else
         {
            GXv_int3[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV52XT_ConfigWWDS_8_Tfxt_configvalue2_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigValue2] = @AV52XT_ConfigWWDS_8_Tfxt_configvalue2_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigValue2] = @AV52XT_ConfigWWDS_8_Tfxt_configvalue2_sel)";
            }
         }
         else
         {
            GXv_int3[7] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [XT_ConfigID]";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [XT_ConfigID] DESC";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [XT_ConfigKey]";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [XT_ConfigKey] DESC";
         }
         else if ( ( AV13OrderedBy == 3 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [XT_ConfigValue1]";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [XT_ConfigValue1] DESC";
         }
         else if ( ( AV13OrderedBy == 4 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [XT_ConfigValue2]";
         }
         else if ( ( AV13OrderedBy == 4 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [XT_ConfigValue2] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [XT_ConfigID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H006X3( IGxContext context ,
                                             long AV45XT_ConfigWWDS_1_Tfxt_configid ,
                                             long AV46XT_ConfigWWDS_2_Tfxt_configid_to ,
                                             String AV48XT_ConfigWWDS_4_Tfxt_configkey_sel ,
                                             String AV47XT_ConfigWWDS_3_Tfxt_configkey ,
                                             String AV50XT_ConfigWWDS_6_Tfxt_configvalue1_sel ,
                                             String AV49XT_ConfigWWDS_5_Tfxt_configvalue1 ,
                                             String AV52XT_ConfigWWDS_8_Tfxt_configvalue2_sel ,
                                             String AV51XT_ConfigWWDS_7_Tfxt_configvalue2 ,
                                             long A195XT_ConfigID ,
                                             String A196XT_ConfigKey ,
                                             String A197XT_ConfigValue1 ,
                                             String A198XT_ConfigValue2 ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [8] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [XT_Config] WITH (NOLOCK)";
         if ( ! (0==AV45XT_ConfigWWDS_1_Tfxt_configid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigID] >= @AV45XT_ConfigWWDS_1_Tfxt_configid)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigID] >= @AV45XT_ConfigWWDS_1_Tfxt_configid)";
            }
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ! (0==AV46XT_ConfigWWDS_2_Tfxt_configid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigID] <= @AV46XT_ConfigWWDS_2_Tfxt_configid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigID] <= @AV46XT_ConfigWWDS_2_Tfxt_configid_to)";
            }
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV48XT_ConfigWWDS_4_Tfxt_configkey_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47XT_ConfigWWDS_3_Tfxt_configkey)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigKey] like @lV47XT_ConfigWWDS_3_Tfxt_configkey)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigKey] like @lV47XT_ConfigWWDS_3_Tfxt_configkey)";
            }
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48XT_ConfigWWDS_4_Tfxt_configkey_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigKey] = @AV48XT_ConfigWWDS_4_Tfxt_configkey_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigKey] = @AV48XT_ConfigWWDS_4_Tfxt_configkey_sel)";
            }
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV50XT_ConfigWWDS_6_Tfxt_configvalue1_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV49XT_ConfigWWDS_5_Tfxt_configvalue1)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigValue1] like @lV49XT_ConfigWWDS_5_Tfxt_configvalue1)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigValue1] like @lV49XT_ConfigWWDS_5_Tfxt_configvalue1)";
            }
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV50XT_ConfigWWDS_6_Tfxt_configvalue1_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigValue1] = @AV50XT_ConfigWWDS_6_Tfxt_configvalue1_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigValue1] = @AV50XT_ConfigWWDS_6_Tfxt_configvalue1_sel)";
            }
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV52XT_ConfigWWDS_8_Tfxt_configvalue2_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51XT_ConfigWWDS_7_Tfxt_configvalue2)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigValue2] like @lV51XT_ConfigWWDS_7_Tfxt_configvalue2)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigValue2] like @lV51XT_ConfigWWDS_7_Tfxt_configvalue2)";
            }
         }
         else
         {
            GXv_int5[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV52XT_ConfigWWDS_8_Tfxt_configvalue2_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigValue2] = @AV52XT_ConfigWWDS_8_Tfxt_configvalue2_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigValue2] = @AV52XT_ConfigWWDS_8_Tfxt_configvalue2_sel)";
            }
         }
         else
         {
            GXv_int5[7] = 1;
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
                     return conditional_H006X2(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (long)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (short)dynConstraints[12] , (bool)dynConstraints[13] );
               case 1 :
                     return conditional_H006X3(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (long)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (short)dynConstraints[12] , (bool)dynConstraints[13] );
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
          Object[] prmH006X2 ;
          prmH006X2 = new Object[] {
          new Object[] {"@AV45XT_ConfigWWDS_1_Tfxt_configid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV46XT_ConfigWWDS_2_Tfxt_configid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV47XT_ConfigWWDS_3_Tfxt_configkey",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV48XT_ConfigWWDS_4_Tfxt_configkey_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV49XT_ConfigWWDS_5_Tfxt_configvalue1",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@AV50XT_ConfigWWDS_6_Tfxt_configvalue1_sel",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@lV51XT_ConfigWWDS_7_Tfxt_configvalue2",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@AV52XT_ConfigWWDS_8_Tfxt_configvalue2_sel",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH006X3 ;
          prmH006X3 = new Object[] {
          new Object[] {"@AV45XT_ConfigWWDS_1_Tfxt_configid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV46XT_ConfigWWDS_2_Tfxt_configid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV47XT_ConfigWWDS_3_Tfxt_configkey",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV48XT_ConfigWWDS_4_Tfxt_configkey_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV49XT_ConfigWWDS_5_Tfxt_configvalue1",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@AV50XT_ConfigWWDS_6_Tfxt_configvalue1_sel",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@lV51XT_ConfigWWDS_7_Tfxt_configvalue2",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@AV52XT_ConfigWWDS_8_Tfxt_configvalue2_sel",SqlDbType.NVarChar,200,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H006X2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH006X2,11,0,true,false )
             ,new CursorDef("H006X3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH006X3,1,0,true,false )
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
                   stmt.SetParameter(sIdx, (long)parms[11]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[12]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[19]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[20]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[21]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[8]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[9]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                return;
       }
    }

 }

}
