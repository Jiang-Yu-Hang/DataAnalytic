/*
               File: XT_ConfigPrompt
        Description: 选择系统配置表
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:46:33.82
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
   public class xt_configprompt : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public xt_configprompt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public xt_configprompt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_InOutXT_ConfigID ,
                           ref String aP1_InOutXT_ConfigKey )
      {
         this.AV8InOutXT_ConfigID = aP0_InOutXT_ConfigID;
         this.AV9InOutXT_ConfigKey = aP1_InOutXT_ConfigKey;
         executePrivate();
         aP0_InOutXT_ConfigID=this.AV8InOutXT_ConfigID;
         aP1_InOutXT_ConfigKey=this.AV9InOutXT_ConfigKey;
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
               AV14ddo_XT_ConfigIDTitleControlIdToReplace = GetNextPar( );
               AV16ddo_XT_ConfigKeyTitleControlIdToReplace = GetNextPar( );
               AV18ddo_XT_ConfigValue1TitleControlIdToReplace = GetNextPar( );
               AV20ddo_XT_ConfigValue2TitleControlIdToReplace = GetNextPar( );
               AV22ddo_XT_ConfigValue3TitleControlIdToReplace = GetNextPar( );
               AV24ddo_XT_ConfigValue4TitleControlIdToReplace = GetNextPar( );
               AV26ddo_XT_ConfigValue5TitleControlIdToReplace = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_XT_ConfigIDTitleControlIdToReplace, AV16ddo_XT_ConfigKeyTitleControlIdToReplace, AV18ddo_XT_ConfigValue1TitleControlIdToReplace, AV20ddo_XT_ConfigValue2TitleControlIdToReplace, AV22ddo_XT_ConfigValue3TitleControlIdToReplace, AV24ddo_XT_ConfigValue4TitleControlIdToReplace, AV26ddo_XT_ConfigValue5TitleControlIdToReplace) ;
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
               AV8InOutXT_ConfigID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutXT_ConfigID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutXT_ConfigID), 18, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV9InOutXT_ConfigKey = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutXT_ConfigKey", AV9InOutXT_ConfigKey);
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
            PA6Z2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV35Pgmname = "XT_ConfigPrompt";
               context.Gx_err = 0;
               WS6Z2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE6Z2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202279463396", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("xt_configprompt.aspx") + "?" + UrlEncode("" +AV8InOutXT_ConfigID) + "," + UrlEncode(StringUtil.RTrim(AV9InOutXT_ConfigKey))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV29GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV31GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV30GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV27DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV27DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_CONFIGIDTITLEFILTERDATA", AV13XT_ConfigIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_CONFIGIDTITLEFILTERDATA", AV13XT_ConfigIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_CONFIGKEYTITLEFILTERDATA", AV15XT_ConfigKeyTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_CONFIGKEYTITLEFILTERDATA", AV15XT_ConfigKeyTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_CONFIGVALUE1TITLEFILTERDATA", AV17XT_ConfigValue1TitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_CONFIGVALUE1TITLEFILTERDATA", AV17XT_ConfigValue1TitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_CONFIGVALUE2TITLEFILTERDATA", AV19XT_ConfigValue2TitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_CONFIGVALUE2TITLEFILTERDATA", AV19XT_ConfigValue2TitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_CONFIGVALUE3TITLEFILTERDATA", AV21XT_ConfigValue3TitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_CONFIGVALUE3TITLEFILTERDATA", AV21XT_ConfigValue3TitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_CONFIGVALUE4TITLEFILTERDATA", AV23XT_ConfigValue4TitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_CONFIGVALUE4TITLEFILTERDATA", AV23XT_ConfigValue4TitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_CONFIGVALUE5TITLEFILTERDATA", AV25XT_ConfigValue5TitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_CONFIGVALUE5TITLEFILTERDATA", AV25XT_ConfigValue5TitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vINOUTXT_CONFIGID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8InOutXT_ConfigID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINOUTXT_CONFIGKEY", AV9InOutXT_ConfigKey);
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
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Caption", StringUtil.RTrim( Ddo_xt_configid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Tooltip", StringUtil.RTrim( Ddo_xt_configid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Cls", StringUtil.RTrim( Ddo_xt_configid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_configid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_configid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Includesortasc", StringUtil.BoolToStr( Ddo_xt_configid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_configid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Sortedstatus", StringUtil.RTrim( Ddo_xt_configid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Includefilter", StringUtil.BoolToStr( Ddo_xt_configid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Includedatalist", StringUtil.BoolToStr( Ddo_xt_configid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Sortasc", StringUtil.RTrim( Ddo_xt_configid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Sortdsc", StringUtil.RTrim( Ddo_xt_configid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Searchbuttontext", StringUtil.RTrim( Ddo_xt_configid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Caption", StringUtil.RTrim( Ddo_xt_configkey_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Tooltip", StringUtil.RTrim( Ddo_xt_configkey_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Cls", StringUtil.RTrim( Ddo_xt_configkey_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_configkey_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_configkey_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Includesortasc", StringUtil.BoolToStr( Ddo_xt_configkey_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_configkey_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Sortedstatus", StringUtil.RTrim( Ddo_xt_configkey_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Includefilter", StringUtil.BoolToStr( Ddo_xt_configkey_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Includedatalist", StringUtil.BoolToStr( Ddo_xt_configkey_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Sortasc", StringUtil.RTrim( Ddo_xt_configkey_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Sortdsc", StringUtil.RTrim( Ddo_xt_configkey_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Searchbuttontext", StringUtil.RTrim( Ddo_xt_configkey_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Caption", StringUtil.RTrim( Ddo_xt_configvalue1_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Tooltip", StringUtil.RTrim( Ddo_xt_configvalue1_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Cls", StringUtil.RTrim( Ddo_xt_configvalue1_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_configvalue1_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_configvalue1_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Includesortasc", StringUtil.BoolToStr( Ddo_xt_configvalue1_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_configvalue1_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Sortedstatus", StringUtil.RTrim( Ddo_xt_configvalue1_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Includefilter", StringUtil.BoolToStr( Ddo_xt_configvalue1_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Includedatalist", StringUtil.BoolToStr( Ddo_xt_configvalue1_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Sortasc", StringUtil.RTrim( Ddo_xt_configvalue1_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Sortdsc", StringUtil.RTrim( Ddo_xt_configvalue1_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Searchbuttontext", StringUtil.RTrim( Ddo_xt_configvalue1_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Caption", StringUtil.RTrim( Ddo_xt_configvalue2_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Tooltip", StringUtil.RTrim( Ddo_xt_configvalue2_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Cls", StringUtil.RTrim( Ddo_xt_configvalue2_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_configvalue2_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_configvalue2_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Includesortasc", StringUtil.BoolToStr( Ddo_xt_configvalue2_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_configvalue2_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Sortedstatus", StringUtil.RTrim( Ddo_xt_configvalue2_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Includefilter", StringUtil.BoolToStr( Ddo_xt_configvalue2_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Includedatalist", StringUtil.BoolToStr( Ddo_xt_configvalue2_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Sortasc", StringUtil.RTrim( Ddo_xt_configvalue2_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Sortdsc", StringUtil.RTrim( Ddo_xt_configvalue2_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Searchbuttontext", StringUtil.RTrim( Ddo_xt_configvalue2_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE3_Caption", StringUtil.RTrim( Ddo_xt_configvalue3_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE3_Tooltip", StringUtil.RTrim( Ddo_xt_configvalue3_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE3_Cls", StringUtil.RTrim( Ddo_xt_configvalue3_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE3_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_configvalue3_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE3_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_configvalue3_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE3_Includesortasc", StringUtil.BoolToStr( Ddo_xt_configvalue3_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE3_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_configvalue3_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE3_Sortedstatus", StringUtil.RTrim( Ddo_xt_configvalue3_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE3_Includefilter", StringUtil.BoolToStr( Ddo_xt_configvalue3_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE3_Includedatalist", StringUtil.BoolToStr( Ddo_xt_configvalue3_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE3_Sortasc", StringUtil.RTrim( Ddo_xt_configvalue3_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE3_Sortdsc", StringUtil.RTrim( Ddo_xt_configvalue3_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE3_Searchbuttontext", StringUtil.RTrim( Ddo_xt_configvalue3_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE4_Caption", StringUtil.RTrim( Ddo_xt_configvalue4_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE4_Tooltip", StringUtil.RTrim( Ddo_xt_configvalue4_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE4_Cls", StringUtil.RTrim( Ddo_xt_configvalue4_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE4_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_configvalue4_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE4_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_configvalue4_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE4_Includesortasc", StringUtil.BoolToStr( Ddo_xt_configvalue4_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE4_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_configvalue4_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE4_Sortedstatus", StringUtil.RTrim( Ddo_xt_configvalue4_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE4_Includefilter", StringUtil.BoolToStr( Ddo_xt_configvalue4_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE4_Includedatalist", StringUtil.BoolToStr( Ddo_xt_configvalue4_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE4_Sortasc", StringUtil.RTrim( Ddo_xt_configvalue4_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE4_Sortdsc", StringUtil.RTrim( Ddo_xt_configvalue4_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE4_Searchbuttontext", StringUtil.RTrim( Ddo_xt_configvalue4_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE5_Caption", StringUtil.RTrim( Ddo_xt_configvalue5_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE5_Tooltip", StringUtil.RTrim( Ddo_xt_configvalue5_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE5_Cls", StringUtil.RTrim( Ddo_xt_configvalue5_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE5_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_configvalue5_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE5_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_configvalue5_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE5_Includesortasc", StringUtil.BoolToStr( Ddo_xt_configvalue5_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE5_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_configvalue5_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE5_Sortedstatus", StringUtil.RTrim( Ddo_xt_configvalue5_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE5_Includefilter", StringUtil.BoolToStr( Ddo_xt_configvalue5_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE5_Includedatalist", StringUtil.BoolToStr( Ddo_xt_configvalue5_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE5_Sortasc", StringUtil.RTrim( Ddo_xt_configvalue5_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE5_Sortdsc", StringUtil.RTrim( Ddo_xt_configvalue5_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE5_Searchbuttontext", StringUtil.RTrim( Ddo_xt_configvalue5_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Activeeventkey", StringUtil.RTrim( Ddo_xt_configid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Activeeventkey", StringUtil.RTrim( Ddo_xt_configkey_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Activeeventkey", StringUtil.RTrim( Ddo_xt_configvalue1_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Activeeventkey", StringUtil.RTrim( Ddo_xt_configvalue2_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE3_Activeeventkey", StringUtil.RTrim( Ddo_xt_configvalue3_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE4_Activeeventkey", StringUtil.RTrim( Ddo_xt_configvalue4_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE5_Activeeventkey", StringUtil.RTrim( Ddo_xt_configvalue5_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGID_Activeeventkey", StringUtil.RTrim( Ddo_xt_configid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGKEY_Activeeventkey", StringUtil.RTrim( Ddo_xt_configkey_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE1_Activeeventkey", StringUtil.RTrim( Ddo_xt_configvalue1_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE2_Activeeventkey", StringUtil.RTrim( Ddo_xt_configvalue2_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE3_Activeeventkey", StringUtil.RTrim( Ddo_xt_configvalue3_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE4_Activeeventkey", StringUtil.RTrim( Ddo_xt_configvalue4_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_CONFIGVALUE5_Activeeventkey", StringUtil.RTrim( Ddo_xt_configvalue5_Activeeventkey));
      }

      protected void RenderHtmlCloseForm6Z2( )
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
         return "XT_ConfigPrompt" ;
      }

      public override String GetPgmdesc( )
      {
         return "选择系统配置表" ;
      }

      protected void WB6Z0( )
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtXT_ConfigValue3_Titleformat == 0 )
               {
                  context.SendWebValue( edtXT_ConfigValue3_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtXT_ConfigValue3_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtXT_ConfigValue4_Titleformat == 0 )
               {
                  context.SendWebValue( edtXT_ConfigValue4_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtXT_ConfigValue4_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtXT_ConfigValue5_Titleformat == 0 )
               {
                  context.SendWebValue( edtXT_ConfigValue5_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtXT_ConfigValue5_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV32Select));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavSelect_Tooltiptext));
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
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A199XT_ConfigValue3);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtXT_ConfigValue3_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtXT_ConfigValue3_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A200XT_ConfigValue4);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtXT_ConfigValue4_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtXT_ConfigValue4_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A201XT_ConfigValue5);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtXT_ConfigValue5_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtXT_ConfigValue5_Titleformat), 4, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV29GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV31GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV30GridPageSize);
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
            ucDdo_xt_configid.SetProperty("IncludeDataList", Ddo_xt_configid_Includedatalist);
            ucDdo_xt_configid.SetProperty("SortASC", Ddo_xt_configid_Sortasc);
            ucDdo_xt_configid.SetProperty("SortDSC", Ddo_xt_configid_Sortdsc);
            ucDdo_xt_configid.SetProperty("SearchButtonText", Ddo_xt_configid_Searchbuttontext);
            ucDdo_xt_configid.SetProperty("DropDownOptionsTitleSettingsIcons", AV27DDO_TitleSettingsIcons);
            ucDdo_xt_configid.SetProperty("DropDownOptionsData", AV13XT_ConfigIDTitleFilterData);
            ucDdo_xt_configid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_configid_Internalname, "DDO_XT_CONFIGIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_configidtitlecontrolidtoreplace_Internalname, AV14ddo_XT_ConfigIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", 0, edtavDdo_xt_configidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_ConfigPrompt.htm");
            /* User Defined Control */
            ucDdo_xt_configkey.SetProperty("Caption", Ddo_xt_configkey_Caption);
            ucDdo_xt_configkey.SetProperty("Tooltip", Ddo_xt_configkey_Tooltip);
            ucDdo_xt_configkey.SetProperty("Cls", Ddo_xt_configkey_Cls);
            ucDdo_xt_configkey.SetProperty("DropDownOptionsType", Ddo_xt_configkey_Dropdownoptionstype);
            ucDdo_xt_configkey.SetProperty("IncludeSortASC", Ddo_xt_configkey_Includesortasc);
            ucDdo_xt_configkey.SetProperty("IncludeSortDSC", Ddo_xt_configkey_Includesortdsc);
            ucDdo_xt_configkey.SetProperty("IncludeFilter", Ddo_xt_configkey_Includefilter);
            ucDdo_xt_configkey.SetProperty("IncludeDataList", Ddo_xt_configkey_Includedatalist);
            ucDdo_xt_configkey.SetProperty("SortASC", Ddo_xt_configkey_Sortasc);
            ucDdo_xt_configkey.SetProperty("SortDSC", Ddo_xt_configkey_Sortdsc);
            ucDdo_xt_configkey.SetProperty("SearchButtonText", Ddo_xt_configkey_Searchbuttontext);
            ucDdo_xt_configkey.SetProperty("DropDownOptionsTitleSettingsIcons", AV27DDO_TitleSettingsIcons);
            ucDdo_xt_configkey.SetProperty("DropDownOptionsData", AV15XT_ConfigKeyTitleFilterData);
            ucDdo_xt_configkey.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_configkey_Internalname, "DDO_XT_CONFIGKEYContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_configkeytitlecontrolidtoreplace_Internalname, AV16ddo_XT_ConfigKeyTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,31);\"", 0, edtavDdo_xt_configkeytitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_ConfigPrompt.htm");
            /* User Defined Control */
            ucDdo_xt_configvalue1.SetProperty("Caption", Ddo_xt_configvalue1_Caption);
            ucDdo_xt_configvalue1.SetProperty("Tooltip", Ddo_xt_configvalue1_Tooltip);
            ucDdo_xt_configvalue1.SetProperty("Cls", Ddo_xt_configvalue1_Cls);
            ucDdo_xt_configvalue1.SetProperty("DropDownOptionsType", Ddo_xt_configvalue1_Dropdownoptionstype);
            ucDdo_xt_configvalue1.SetProperty("IncludeSortASC", Ddo_xt_configvalue1_Includesortasc);
            ucDdo_xt_configvalue1.SetProperty("IncludeSortDSC", Ddo_xt_configvalue1_Includesortdsc);
            ucDdo_xt_configvalue1.SetProperty("IncludeFilter", Ddo_xt_configvalue1_Includefilter);
            ucDdo_xt_configvalue1.SetProperty("IncludeDataList", Ddo_xt_configvalue1_Includedatalist);
            ucDdo_xt_configvalue1.SetProperty("SortASC", Ddo_xt_configvalue1_Sortasc);
            ucDdo_xt_configvalue1.SetProperty("SortDSC", Ddo_xt_configvalue1_Sortdsc);
            ucDdo_xt_configvalue1.SetProperty("SearchButtonText", Ddo_xt_configvalue1_Searchbuttontext);
            ucDdo_xt_configvalue1.SetProperty("DropDownOptionsTitleSettingsIcons", AV27DDO_TitleSettingsIcons);
            ucDdo_xt_configvalue1.SetProperty("DropDownOptionsData", AV17XT_ConfigValue1TitleFilterData);
            ucDdo_xt_configvalue1.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_configvalue1_Internalname, "DDO_XT_CONFIGVALUE1Container");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_configvalue1titlecontrolidtoreplace_Internalname, AV18ddo_XT_ConfigValue1TitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", 0, edtavDdo_xt_configvalue1titlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_ConfigPrompt.htm");
            /* User Defined Control */
            ucDdo_xt_configvalue2.SetProperty("Caption", Ddo_xt_configvalue2_Caption);
            ucDdo_xt_configvalue2.SetProperty("Tooltip", Ddo_xt_configvalue2_Tooltip);
            ucDdo_xt_configvalue2.SetProperty("Cls", Ddo_xt_configvalue2_Cls);
            ucDdo_xt_configvalue2.SetProperty("DropDownOptionsType", Ddo_xt_configvalue2_Dropdownoptionstype);
            ucDdo_xt_configvalue2.SetProperty("IncludeSortASC", Ddo_xt_configvalue2_Includesortasc);
            ucDdo_xt_configvalue2.SetProperty("IncludeSortDSC", Ddo_xt_configvalue2_Includesortdsc);
            ucDdo_xt_configvalue2.SetProperty("IncludeFilter", Ddo_xt_configvalue2_Includefilter);
            ucDdo_xt_configvalue2.SetProperty("IncludeDataList", Ddo_xt_configvalue2_Includedatalist);
            ucDdo_xt_configvalue2.SetProperty("SortASC", Ddo_xt_configvalue2_Sortasc);
            ucDdo_xt_configvalue2.SetProperty("SortDSC", Ddo_xt_configvalue2_Sortdsc);
            ucDdo_xt_configvalue2.SetProperty("SearchButtonText", Ddo_xt_configvalue2_Searchbuttontext);
            ucDdo_xt_configvalue2.SetProperty("DropDownOptionsTitleSettingsIcons", AV27DDO_TitleSettingsIcons);
            ucDdo_xt_configvalue2.SetProperty("DropDownOptionsData", AV19XT_ConfigValue2TitleFilterData);
            ucDdo_xt_configvalue2.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_configvalue2_Internalname, "DDO_XT_CONFIGVALUE2Container");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_configvalue2titlecontrolidtoreplace_Internalname, AV20ddo_XT_ConfigValue2TitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,35);\"", 0, edtavDdo_xt_configvalue2titlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_ConfigPrompt.htm");
            /* User Defined Control */
            ucDdo_xt_configvalue3.SetProperty("Caption", Ddo_xt_configvalue3_Caption);
            ucDdo_xt_configvalue3.SetProperty("Tooltip", Ddo_xt_configvalue3_Tooltip);
            ucDdo_xt_configvalue3.SetProperty("Cls", Ddo_xt_configvalue3_Cls);
            ucDdo_xt_configvalue3.SetProperty("DropDownOptionsType", Ddo_xt_configvalue3_Dropdownoptionstype);
            ucDdo_xt_configvalue3.SetProperty("IncludeSortASC", Ddo_xt_configvalue3_Includesortasc);
            ucDdo_xt_configvalue3.SetProperty("IncludeSortDSC", Ddo_xt_configvalue3_Includesortdsc);
            ucDdo_xt_configvalue3.SetProperty("IncludeFilter", Ddo_xt_configvalue3_Includefilter);
            ucDdo_xt_configvalue3.SetProperty("IncludeDataList", Ddo_xt_configvalue3_Includedatalist);
            ucDdo_xt_configvalue3.SetProperty("SortASC", Ddo_xt_configvalue3_Sortasc);
            ucDdo_xt_configvalue3.SetProperty("SortDSC", Ddo_xt_configvalue3_Sortdsc);
            ucDdo_xt_configvalue3.SetProperty("SearchButtonText", Ddo_xt_configvalue3_Searchbuttontext);
            ucDdo_xt_configvalue3.SetProperty("DropDownOptionsTitleSettingsIcons", AV27DDO_TitleSettingsIcons);
            ucDdo_xt_configvalue3.SetProperty("DropDownOptionsData", AV21XT_ConfigValue3TitleFilterData);
            ucDdo_xt_configvalue3.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_configvalue3_Internalname, "DDO_XT_CONFIGVALUE3Container");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_configvalue3titlecontrolidtoreplace_Internalname, AV22ddo_XT_ConfigValue3TitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", 0, edtavDdo_xt_configvalue3titlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_ConfigPrompt.htm");
            /* User Defined Control */
            ucDdo_xt_configvalue4.SetProperty("Caption", Ddo_xt_configvalue4_Caption);
            ucDdo_xt_configvalue4.SetProperty("Tooltip", Ddo_xt_configvalue4_Tooltip);
            ucDdo_xt_configvalue4.SetProperty("Cls", Ddo_xt_configvalue4_Cls);
            ucDdo_xt_configvalue4.SetProperty("DropDownOptionsType", Ddo_xt_configvalue4_Dropdownoptionstype);
            ucDdo_xt_configvalue4.SetProperty("IncludeSortASC", Ddo_xt_configvalue4_Includesortasc);
            ucDdo_xt_configvalue4.SetProperty("IncludeSortDSC", Ddo_xt_configvalue4_Includesortdsc);
            ucDdo_xt_configvalue4.SetProperty("IncludeFilter", Ddo_xt_configvalue4_Includefilter);
            ucDdo_xt_configvalue4.SetProperty("IncludeDataList", Ddo_xt_configvalue4_Includedatalist);
            ucDdo_xt_configvalue4.SetProperty("SortASC", Ddo_xt_configvalue4_Sortasc);
            ucDdo_xt_configvalue4.SetProperty("SortDSC", Ddo_xt_configvalue4_Sortdsc);
            ucDdo_xt_configvalue4.SetProperty("SearchButtonText", Ddo_xt_configvalue4_Searchbuttontext);
            ucDdo_xt_configvalue4.SetProperty("DropDownOptionsTitleSettingsIcons", AV27DDO_TitleSettingsIcons);
            ucDdo_xt_configvalue4.SetProperty("DropDownOptionsData", AV23XT_ConfigValue4TitleFilterData);
            ucDdo_xt_configvalue4.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_configvalue4_Internalname, "DDO_XT_CONFIGVALUE4Container");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_configvalue4titlecontrolidtoreplace_Internalname, AV24ddo_XT_ConfigValue4TitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", 0, edtavDdo_xt_configvalue4titlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_ConfigPrompt.htm");
            /* User Defined Control */
            ucDdo_xt_configvalue5.SetProperty("Caption", Ddo_xt_configvalue5_Caption);
            ucDdo_xt_configvalue5.SetProperty("Tooltip", Ddo_xt_configvalue5_Tooltip);
            ucDdo_xt_configvalue5.SetProperty("Cls", Ddo_xt_configvalue5_Cls);
            ucDdo_xt_configvalue5.SetProperty("DropDownOptionsType", Ddo_xt_configvalue5_Dropdownoptionstype);
            ucDdo_xt_configvalue5.SetProperty("IncludeSortASC", Ddo_xt_configvalue5_Includesortasc);
            ucDdo_xt_configvalue5.SetProperty("IncludeSortDSC", Ddo_xt_configvalue5_Includesortdsc);
            ucDdo_xt_configvalue5.SetProperty("IncludeFilter", Ddo_xt_configvalue5_Includefilter);
            ucDdo_xt_configvalue5.SetProperty("IncludeDataList", Ddo_xt_configvalue5_Includedatalist);
            ucDdo_xt_configvalue5.SetProperty("SortASC", Ddo_xt_configvalue5_Sortasc);
            ucDdo_xt_configvalue5.SetProperty("SortDSC", Ddo_xt_configvalue5_Sortdsc);
            ucDdo_xt_configvalue5.SetProperty("SearchButtonText", Ddo_xt_configvalue5_Searchbuttontext);
            ucDdo_xt_configvalue5.SetProperty("DropDownOptionsTitleSettingsIcons", AV27DDO_TitleSettingsIcons);
            ucDdo_xt_configvalue5.SetProperty("DropDownOptionsData", AV25XT_ConfigValue5TitleFilterData);
            ucDdo_xt_configvalue5.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_configvalue5_Internalname, "DDO_XT_CONFIGVALUE5Container");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_configvalue5titlecontrolidtoreplace_Internalname, AV26ddo_XT_ConfigValue5TitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,41);\"", 0, edtavDdo_xt_configvalue5titlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_ConfigPrompt.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_XT_ConfigPrompt.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV12OrderedDsc), StringUtil.BoolToStr( AV12OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_XT_ConfigPrompt.htm");
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

      protected void START6Z2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "选择系统配置表", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP6Z0( ) ;
      }

      protected void WS6Z2( )
      {
         START6Z2( ) ;
         EVT6Z2( ) ;
      }

      protected void EVT6Z2( )
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
                           E116Z2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E126Z2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_XT_CONFIGID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E136Z2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_XT_CONFIGKEY.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E146Z2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_XT_CONFIGVALUE1.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E156Z2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_XT_CONFIGVALUE2.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E166Z2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_XT_CONFIGVALUE3.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E176Z2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_XT_CONFIGVALUE4.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E186Z2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_XT_CONFIGVALUE5.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E196Z2 ();
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
                           AV32Select = cgiGet( edtavSelect_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV32Select)) ? AV36Select_GXI : context.convertURL( context.PathToRelativeUrl( AV32Select))), !bGXsfl_12_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "SrcSet", context.GetImageSrcSet( AV32Select), true);
                           A195XT_ConfigID = (long)(context.localUtil.CToN( cgiGet( edtXT_ConfigID_Internalname), ".", ","));
                           A196XT_ConfigKey = cgiGet( edtXT_ConfigKey_Internalname);
                           n196XT_ConfigKey = false;
                           A197XT_ConfigValue1 = cgiGet( edtXT_ConfigValue1_Internalname);
                           n197XT_ConfigValue1 = false;
                           A198XT_ConfigValue2 = cgiGet( edtXT_ConfigValue2_Internalname);
                           n198XT_ConfigValue2 = false;
                           A199XT_ConfigValue3 = cgiGet( edtXT_ConfigValue3_Internalname);
                           n199XT_ConfigValue3 = false;
                           A200XT_ConfigValue4 = cgiGet( edtXT_ConfigValue4_Internalname);
                           n200XT_ConfigValue4 = false;
                           A201XT_ConfigValue5 = cgiGet( edtXT_ConfigValue5_Internalname);
                           n201XT_ConfigValue5 = false;
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E206Z2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E216Z2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E226Z2 ();
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
                                       E236Z2 ();
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

      protected void WE6Z2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm6Z2( ) ;
            }
         }
      }

      protected void PA6Z2( )
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
                                       String AV14ddo_XT_ConfigIDTitleControlIdToReplace ,
                                       String AV16ddo_XT_ConfigKeyTitleControlIdToReplace ,
                                       String AV18ddo_XT_ConfigValue1TitleControlIdToReplace ,
                                       String AV20ddo_XT_ConfigValue2TitleControlIdToReplace ,
                                       String AV22ddo_XT_ConfigValue3TitleControlIdToReplace ,
                                       String AV24ddo_XT_ConfigValue4TitleControlIdToReplace ,
                                       String AV26ddo_XT_ConfigValue5TitleControlIdToReplace )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF6Z2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_XT_CONFIGID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A195XT_ConfigID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "XT_CONFIGID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A195XT_ConfigID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_XT_CONFIGKEY", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A196XT_ConfigKey, "")), context));
         GxWebStd.gx_hidden_field( context, "XT_CONFIGKEY", A196XT_ConfigKey);
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
         RF6Z2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV35Pgmname = "XT_ConfigPrompt";
         context.Gx_err = 0;
      }

      protected void RF6Z2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 12;
         /* Execute user event: Refresh */
         E216Z2 ();
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
            /* Using cursor H006Z2 */
            pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_12_idx = 1;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A201XT_ConfigValue5 = H006Z2_A201XT_ConfigValue5[0];
               n201XT_ConfigValue5 = H006Z2_n201XT_ConfigValue5[0];
               A200XT_ConfigValue4 = H006Z2_A200XT_ConfigValue4[0];
               n200XT_ConfigValue4 = H006Z2_n200XT_ConfigValue4[0];
               A199XT_ConfigValue3 = H006Z2_A199XT_ConfigValue3[0];
               n199XT_ConfigValue3 = H006Z2_n199XT_ConfigValue3[0];
               A198XT_ConfigValue2 = H006Z2_A198XT_ConfigValue2[0];
               n198XT_ConfigValue2 = H006Z2_n198XT_ConfigValue2[0];
               A197XT_ConfigValue1 = H006Z2_A197XT_ConfigValue1[0];
               n197XT_ConfigValue1 = H006Z2_n197XT_ConfigValue1[0];
               A196XT_ConfigKey = H006Z2_A196XT_ConfigKey[0];
               n196XT_ConfigKey = H006Z2_n196XT_ConfigKey[0];
               A195XT_ConfigID = H006Z2_A195XT_ConfigID[0];
               E226Z2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 12;
            WB6Z0( ) ;
         }
         bGXsfl_12_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes6Z2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_XT_CONFIGID"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, context.localUtil.Format( (decimal)(A195XT_ConfigID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_XT_CONFIGKEY"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, StringUtil.RTrim( context.localUtil.Format( A196XT_ConfigKey, "")), context));
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
         /* Using cursor H006Z3 */
         pr_default.execute(1);
         GRID_nRecordCount = H006Z3_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_XT_ConfigIDTitleControlIdToReplace, AV16ddo_XT_ConfigKeyTitleControlIdToReplace, AV18ddo_XT_ConfigValue1TitleControlIdToReplace, AV20ddo_XT_ConfigValue2TitleControlIdToReplace, AV22ddo_XT_ConfigValue3TitleControlIdToReplace, AV24ddo_XT_ConfigValue4TitleControlIdToReplace, AV26ddo_XT_ConfigValue5TitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_XT_ConfigIDTitleControlIdToReplace, AV16ddo_XT_ConfigKeyTitleControlIdToReplace, AV18ddo_XT_ConfigValue1TitleControlIdToReplace, AV20ddo_XT_ConfigValue2TitleControlIdToReplace, AV22ddo_XT_ConfigValue3TitleControlIdToReplace, AV24ddo_XT_ConfigValue4TitleControlIdToReplace, AV26ddo_XT_ConfigValue5TitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_XT_ConfigIDTitleControlIdToReplace, AV16ddo_XT_ConfigKeyTitleControlIdToReplace, AV18ddo_XT_ConfigValue1TitleControlIdToReplace, AV20ddo_XT_ConfigValue2TitleControlIdToReplace, AV22ddo_XT_ConfigValue3TitleControlIdToReplace, AV24ddo_XT_ConfigValue4TitleControlIdToReplace, AV26ddo_XT_ConfigValue5TitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_XT_ConfigIDTitleControlIdToReplace, AV16ddo_XT_ConfigKeyTitleControlIdToReplace, AV18ddo_XT_ConfigValue1TitleControlIdToReplace, AV20ddo_XT_ConfigValue2TitleControlIdToReplace, AV22ddo_XT_ConfigValue3TitleControlIdToReplace, AV24ddo_XT_ConfigValue4TitleControlIdToReplace, AV26ddo_XT_ConfigValue5TitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_XT_ConfigIDTitleControlIdToReplace, AV16ddo_XT_ConfigKeyTitleControlIdToReplace, AV18ddo_XT_ConfigValue1TitleControlIdToReplace, AV20ddo_XT_ConfigValue2TitleControlIdToReplace, AV22ddo_XT_ConfigValue3TitleControlIdToReplace, AV24ddo_XT_ConfigValue4TitleControlIdToReplace, AV26ddo_XT_ConfigValue5TitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP6Z0( )
      {
         /* Before Start, stand alone formulas. */
         AV35Pgmname = "XT_ConfigPrompt";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E206Z2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV27DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_CONFIGIDTITLEFILTERDATA"), AV13XT_ConfigIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_CONFIGKEYTITLEFILTERDATA"), AV15XT_ConfigKeyTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_CONFIGVALUE1TITLEFILTERDATA"), AV17XT_ConfigValue1TitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_CONFIGVALUE2TITLEFILTERDATA"), AV19XT_ConfigValue2TitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_CONFIGVALUE3TITLEFILTERDATA"), AV21XT_ConfigValue3TitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_CONFIGVALUE4TITLEFILTERDATA"), AV23XT_ConfigValue4TitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_CONFIGVALUE5TITLEFILTERDATA"), AV25XT_ConfigValue5TitleFilterData);
            /* Read variables values. */
            AV14ddo_XT_ConfigIDTitleControlIdToReplace = cgiGet( edtavDdo_xt_configidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_XT_ConfigIDTitleControlIdToReplace", AV14ddo_XT_ConfigIDTitleControlIdToReplace);
            AV16ddo_XT_ConfigKeyTitleControlIdToReplace = cgiGet( edtavDdo_xt_configkeytitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_XT_ConfigKeyTitleControlIdToReplace", AV16ddo_XT_ConfigKeyTitleControlIdToReplace);
            AV18ddo_XT_ConfigValue1TitleControlIdToReplace = cgiGet( edtavDdo_xt_configvalue1titlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_XT_ConfigValue1TitleControlIdToReplace", AV18ddo_XT_ConfigValue1TitleControlIdToReplace);
            AV20ddo_XT_ConfigValue2TitleControlIdToReplace = cgiGet( edtavDdo_xt_configvalue2titlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_XT_ConfigValue2TitleControlIdToReplace", AV20ddo_XT_ConfigValue2TitleControlIdToReplace);
            AV22ddo_XT_ConfigValue3TitleControlIdToReplace = cgiGet( edtavDdo_xt_configvalue3titlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ddo_XT_ConfigValue3TitleControlIdToReplace", AV22ddo_XT_ConfigValue3TitleControlIdToReplace);
            AV24ddo_XT_ConfigValue4TitleControlIdToReplace = cgiGet( edtavDdo_xt_configvalue4titlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24ddo_XT_ConfigValue4TitleControlIdToReplace", AV24ddo_XT_ConfigValue4TitleControlIdToReplace);
            AV26ddo_XT_ConfigValue5TitleControlIdToReplace = cgiGet( edtavDdo_xt_configvalue5titlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26ddo_XT_ConfigValue5TitleControlIdToReplace", AV26ddo_XT_ConfigValue5TitleControlIdToReplace);
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
            AV29GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV31GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV30GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_xt_configid_Caption = cgiGet( "DDO_XT_CONFIGID_Caption");
            Ddo_xt_configid_Tooltip = cgiGet( "DDO_XT_CONFIGID_Tooltip");
            Ddo_xt_configid_Cls = cgiGet( "DDO_XT_CONFIGID_Cls");
            Ddo_xt_configid_Dropdownoptionstype = cgiGet( "DDO_XT_CONFIGID_Dropdownoptionstype");
            Ddo_xt_configid_Titlecontrolidtoreplace = cgiGet( "DDO_XT_CONFIGID_Titlecontrolidtoreplace");
            Ddo_xt_configid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGID_Includesortasc"));
            Ddo_xt_configid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGID_Includesortdsc"));
            Ddo_xt_configid_Sortedstatus = cgiGet( "DDO_XT_CONFIGID_Sortedstatus");
            Ddo_xt_configid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGID_Includefilter"));
            Ddo_xt_configid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGID_Includedatalist"));
            Ddo_xt_configid_Sortasc = cgiGet( "DDO_XT_CONFIGID_Sortasc");
            Ddo_xt_configid_Sortdsc = cgiGet( "DDO_XT_CONFIGID_Sortdsc");
            Ddo_xt_configid_Searchbuttontext = cgiGet( "DDO_XT_CONFIGID_Searchbuttontext");
            Ddo_xt_configkey_Caption = cgiGet( "DDO_XT_CONFIGKEY_Caption");
            Ddo_xt_configkey_Tooltip = cgiGet( "DDO_XT_CONFIGKEY_Tooltip");
            Ddo_xt_configkey_Cls = cgiGet( "DDO_XT_CONFIGKEY_Cls");
            Ddo_xt_configkey_Dropdownoptionstype = cgiGet( "DDO_XT_CONFIGKEY_Dropdownoptionstype");
            Ddo_xt_configkey_Titlecontrolidtoreplace = cgiGet( "DDO_XT_CONFIGKEY_Titlecontrolidtoreplace");
            Ddo_xt_configkey_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGKEY_Includesortasc"));
            Ddo_xt_configkey_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGKEY_Includesortdsc"));
            Ddo_xt_configkey_Sortedstatus = cgiGet( "DDO_XT_CONFIGKEY_Sortedstatus");
            Ddo_xt_configkey_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGKEY_Includefilter"));
            Ddo_xt_configkey_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGKEY_Includedatalist"));
            Ddo_xt_configkey_Sortasc = cgiGet( "DDO_XT_CONFIGKEY_Sortasc");
            Ddo_xt_configkey_Sortdsc = cgiGet( "DDO_XT_CONFIGKEY_Sortdsc");
            Ddo_xt_configkey_Searchbuttontext = cgiGet( "DDO_XT_CONFIGKEY_Searchbuttontext");
            Ddo_xt_configvalue1_Caption = cgiGet( "DDO_XT_CONFIGVALUE1_Caption");
            Ddo_xt_configvalue1_Tooltip = cgiGet( "DDO_XT_CONFIGVALUE1_Tooltip");
            Ddo_xt_configvalue1_Cls = cgiGet( "DDO_XT_CONFIGVALUE1_Cls");
            Ddo_xt_configvalue1_Dropdownoptionstype = cgiGet( "DDO_XT_CONFIGVALUE1_Dropdownoptionstype");
            Ddo_xt_configvalue1_Titlecontrolidtoreplace = cgiGet( "DDO_XT_CONFIGVALUE1_Titlecontrolidtoreplace");
            Ddo_xt_configvalue1_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGVALUE1_Includesortasc"));
            Ddo_xt_configvalue1_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGVALUE1_Includesortdsc"));
            Ddo_xt_configvalue1_Sortedstatus = cgiGet( "DDO_XT_CONFIGVALUE1_Sortedstatus");
            Ddo_xt_configvalue1_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGVALUE1_Includefilter"));
            Ddo_xt_configvalue1_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGVALUE1_Includedatalist"));
            Ddo_xt_configvalue1_Sortasc = cgiGet( "DDO_XT_CONFIGVALUE1_Sortasc");
            Ddo_xt_configvalue1_Sortdsc = cgiGet( "DDO_XT_CONFIGVALUE1_Sortdsc");
            Ddo_xt_configvalue1_Searchbuttontext = cgiGet( "DDO_XT_CONFIGVALUE1_Searchbuttontext");
            Ddo_xt_configvalue2_Caption = cgiGet( "DDO_XT_CONFIGVALUE2_Caption");
            Ddo_xt_configvalue2_Tooltip = cgiGet( "DDO_XT_CONFIGVALUE2_Tooltip");
            Ddo_xt_configvalue2_Cls = cgiGet( "DDO_XT_CONFIGVALUE2_Cls");
            Ddo_xt_configvalue2_Dropdownoptionstype = cgiGet( "DDO_XT_CONFIGVALUE2_Dropdownoptionstype");
            Ddo_xt_configvalue2_Titlecontrolidtoreplace = cgiGet( "DDO_XT_CONFIGVALUE2_Titlecontrolidtoreplace");
            Ddo_xt_configvalue2_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGVALUE2_Includesortasc"));
            Ddo_xt_configvalue2_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGVALUE2_Includesortdsc"));
            Ddo_xt_configvalue2_Sortedstatus = cgiGet( "DDO_XT_CONFIGVALUE2_Sortedstatus");
            Ddo_xt_configvalue2_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGVALUE2_Includefilter"));
            Ddo_xt_configvalue2_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGVALUE2_Includedatalist"));
            Ddo_xt_configvalue2_Sortasc = cgiGet( "DDO_XT_CONFIGVALUE2_Sortasc");
            Ddo_xt_configvalue2_Sortdsc = cgiGet( "DDO_XT_CONFIGVALUE2_Sortdsc");
            Ddo_xt_configvalue2_Searchbuttontext = cgiGet( "DDO_XT_CONFIGVALUE2_Searchbuttontext");
            Ddo_xt_configvalue3_Caption = cgiGet( "DDO_XT_CONFIGVALUE3_Caption");
            Ddo_xt_configvalue3_Tooltip = cgiGet( "DDO_XT_CONFIGVALUE3_Tooltip");
            Ddo_xt_configvalue3_Cls = cgiGet( "DDO_XT_CONFIGVALUE3_Cls");
            Ddo_xt_configvalue3_Dropdownoptionstype = cgiGet( "DDO_XT_CONFIGVALUE3_Dropdownoptionstype");
            Ddo_xt_configvalue3_Titlecontrolidtoreplace = cgiGet( "DDO_XT_CONFIGVALUE3_Titlecontrolidtoreplace");
            Ddo_xt_configvalue3_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGVALUE3_Includesortasc"));
            Ddo_xt_configvalue3_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGVALUE3_Includesortdsc"));
            Ddo_xt_configvalue3_Sortedstatus = cgiGet( "DDO_XT_CONFIGVALUE3_Sortedstatus");
            Ddo_xt_configvalue3_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGVALUE3_Includefilter"));
            Ddo_xt_configvalue3_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGVALUE3_Includedatalist"));
            Ddo_xt_configvalue3_Sortasc = cgiGet( "DDO_XT_CONFIGVALUE3_Sortasc");
            Ddo_xt_configvalue3_Sortdsc = cgiGet( "DDO_XT_CONFIGVALUE3_Sortdsc");
            Ddo_xt_configvalue3_Searchbuttontext = cgiGet( "DDO_XT_CONFIGVALUE3_Searchbuttontext");
            Ddo_xt_configvalue4_Caption = cgiGet( "DDO_XT_CONFIGVALUE4_Caption");
            Ddo_xt_configvalue4_Tooltip = cgiGet( "DDO_XT_CONFIGVALUE4_Tooltip");
            Ddo_xt_configvalue4_Cls = cgiGet( "DDO_XT_CONFIGVALUE4_Cls");
            Ddo_xt_configvalue4_Dropdownoptionstype = cgiGet( "DDO_XT_CONFIGVALUE4_Dropdownoptionstype");
            Ddo_xt_configvalue4_Titlecontrolidtoreplace = cgiGet( "DDO_XT_CONFIGVALUE4_Titlecontrolidtoreplace");
            Ddo_xt_configvalue4_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGVALUE4_Includesortasc"));
            Ddo_xt_configvalue4_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGVALUE4_Includesortdsc"));
            Ddo_xt_configvalue4_Sortedstatus = cgiGet( "DDO_XT_CONFIGVALUE4_Sortedstatus");
            Ddo_xt_configvalue4_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGVALUE4_Includefilter"));
            Ddo_xt_configvalue4_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGVALUE4_Includedatalist"));
            Ddo_xt_configvalue4_Sortasc = cgiGet( "DDO_XT_CONFIGVALUE4_Sortasc");
            Ddo_xt_configvalue4_Sortdsc = cgiGet( "DDO_XT_CONFIGVALUE4_Sortdsc");
            Ddo_xt_configvalue4_Searchbuttontext = cgiGet( "DDO_XT_CONFIGVALUE4_Searchbuttontext");
            Ddo_xt_configvalue5_Caption = cgiGet( "DDO_XT_CONFIGVALUE5_Caption");
            Ddo_xt_configvalue5_Tooltip = cgiGet( "DDO_XT_CONFIGVALUE5_Tooltip");
            Ddo_xt_configvalue5_Cls = cgiGet( "DDO_XT_CONFIGVALUE5_Cls");
            Ddo_xt_configvalue5_Dropdownoptionstype = cgiGet( "DDO_XT_CONFIGVALUE5_Dropdownoptionstype");
            Ddo_xt_configvalue5_Titlecontrolidtoreplace = cgiGet( "DDO_XT_CONFIGVALUE5_Titlecontrolidtoreplace");
            Ddo_xt_configvalue5_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGVALUE5_Includesortasc"));
            Ddo_xt_configvalue5_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGVALUE5_Includesortdsc"));
            Ddo_xt_configvalue5_Sortedstatus = cgiGet( "DDO_XT_CONFIGVALUE5_Sortedstatus");
            Ddo_xt_configvalue5_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGVALUE5_Includefilter"));
            Ddo_xt_configvalue5_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_CONFIGVALUE5_Includedatalist"));
            Ddo_xt_configvalue5_Sortasc = cgiGet( "DDO_XT_CONFIGVALUE5_Sortasc");
            Ddo_xt_configvalue5_Sortdsc = cgiGet( "DDO_XT_CONFIGVALUE5_Sortdsc");
            Ddo_xt_configvalue5_Searchbuttontext = cgiGet( "DDO_XT_CONFIGVALUE5_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_xt_configid_Activeeventkey = cgiGet( "DDO_XT_CONFIGID_Activeeventkey");
            Ddo_xt_configkey_Activeeventkey = cgiGet( "DDO_XT_CONFIGKEY_Activeeventkey");
            Ddo_xt_configvalue1_Activeeventkey = cgiGet( "DDO_XT_CONFIGVALUE1_Activeeventkey");
            Ddo_xt_configvalue2_Activeeventkey = cgiGet( "DDO_XT_CONFIGVALUE2_Activeeventkey");
            Ddo_xt_configvalue3_Activeeventkey = cgiGet( "DDO_XT_CONFIGVALUE3_Activeeventkey");
            Ddo_xt_configvalue4_Activeeventkey = cgiGet( "DDO_XT_CONFIGVALUE4_Activeeventkey");
            Ddo_xt_configvalue5_Activeeventkey = cgiGet( "DDO_XT_CONFIGVALUE5_Activeeventkey");
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
         E206Z2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E206Z2( )
      {
         /* Start Routine */
         GXt_boolean1 = AV5IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWXT_Config", out  GXt_boolean1) ;
         AV5IsAuthorized = GXt_boolean1;
         if ( ! AV5IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV35Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         divTablemain_Height = 493;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTablemain_Internalname, "Height", StringUtil.LTrim( StringUtil.Str( (decimal)(divTablemain_Height), 9, 0)), true);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_xt_configid_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_ConfigID";
         ucDdo_xt_configid.SendProperty(context, "", false, Ddo_xt_configid_Internalname, "TitleControlIdToReplace", Ddo_xt_configid_Titlecontrolidtoreplace);
         AV14ddo_XT_ConfigIDTitleControlIdToReplace = Ddo_xt_configid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_XT_ConfigIDTitleControlIdToReplace", AV14ddo_XT_ConfigIDTitleControlIdToReplace);
         edtavDdo_xt_configidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_configidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_configidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_xt_configkey_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_ConfigKey";
         ucDdo_xt_configkey.SendProperty(context, "", false, Ddo_xt_configkey_Internalname, "TitleControlIdToReplace", Ddo_xt_configkey_Titlecontrolidtoreplace);
         AV16ddo_XT_ConfigKeyTitleControlIdToReplace = Ddo_xt_configkey_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_XT_ConfigKeyTitleControlIdToReplace", AV16ddo_XT_ConfigKeyTitleControlIdToReplace);
         edtavDdo_xt_configkeytitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_configkeytitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_configkeytitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_xt_configvalue1_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_ConfigValue1";
         ucDdo_xt_configvalue1.SendProperty(context, "", false, Ddo_xt_configvalue1_Internalname, "TitleControlIdToReplace", Ddo_xt_configvalue1_Titlecontrolidtoreplace);
         AV18ddo_XT_ConfigValue1TitleControlIdToReplace = Ddo_xt_configvalue1_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_XT_ConfigValue1TitleControlIdToReplace", AV18ddo_XT_ConfigValue1TitleControlIdToReplace);
         edtavDdo_xt_configvalue1titlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_configvalue1titlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_configvalue1titlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_xt_configvalue2_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_ConfigValue2";
         ucDdo_xt_configvalue2.SendProperty(context, "", false, Ddo_xt_configvalue2_Internalname, "TitleControlIdToReplace", Ddo_xt_configvalue2_Titlecontrolidtoreplace);
         AV20ddo_XT_ConfigValue2TitleControlIdToReplace = Ddo_xt_configvalue2_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_XT_ConfigValue2TitleControlIdToReplace", AV20ddo_XT_ConfigValue2TitleControlIdToReplace);
         edtavDdo_xt_configvalue2titlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_configvalue2titlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_configvalue2titlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_xt_configvalue3_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_ConfigValue3";
         ucDdo_xt_configvalue3.SendProperty(context, "", false, Ddo_xt_configvalue3_Internalname, "TitleControlIdToReplace", Ddo_xt_configvalue3_Titlecontrolidtoreplace);
         AV22ddo_XT_ConfigValue3TitleControlIdToReplace = Ddo_xt_configvalue3_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ddo_XT_ConfigValue3TitleControlIdToReplace", AV22ddo_XT_ConfigValue3TitleControlIdToReplace);
         edtavDdo_xt_configvalue3titlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_configvalue3titlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_configvalue3titlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_xt_configvalue4_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_ConfigValue4";
         ucDdo_xt_configvalue4.SendProperty(context, "", false, Ddo_xt_configvalue4_Internalname, "TitleControlIdToReplace", Ddo_xt_configvalue4_Titlecontrolidtoreplace);
         AV24ddo_XT_ConfigValue4TitleControlIdToReplace = Ddo_xt_configvalue4_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24ddo_XT_ConfigValue4TitleControlIdToReplace", AV24ddo_XT_ConfigValue4TitleControlIdToReplace);
         edtavDdo_xt_configvalue4titlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_configvalue4titlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_configvalue4titlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_xt_configvalue5_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_ConfigValue5";
         ucDdo_xt_configvalue5.SendProperty(context, "", false, Ddo_xt_configvalue5_Internalname, "TitleControlIdToReplace", Ddo_xt_configvalue5_Titlecontrolidtoreplace);
         AV26ddo_XT_ConfigValue5TitleControlIdToReplace = Ddo_xt_configvalue5_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26ddo_XT_ConfigValue5TitleControlIdToReplace", AV26ddo_XT_ConfigValue5TitleControlIdToReplace);
         edtavDdo_xt_configvalue5titlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_configvalue5titlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_configvalue5titlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "选择系统配置表";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV27DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV27DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E216Z2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV13XT_ConfigIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15XT_ConfigKeyTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17XT_ConfigValue1TitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19XT_ConfigValue2TitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21XT_ConfigValue3TitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV23XT_ConfigValue4TitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV25XT_ConfigValue5TitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         edtXT_ConfigID_Titleformat = 2;
         edtXT_ConfigID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "系统配置的主键", AV14ddo_XT_ConfigIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_ConfigID_Internalname, "Title", edtXT_ConfigID_Title, !bGXsfl_12_Refreshing);
         edtXT_ConfigKey_Titleformat = 2;
         edtXT_ConfigKey_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "配置名称", AV16ddo_XT_ConfigKeyTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_ConfigKey_Internalname, "Title", edtXT_ConfigKey_Title, !bGXsfl_12_Refreshing);
         edtXT_ConfigValue1_Titleformat = 2;
         edtXT_ConfigValue1_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "配置值1", AV18ddo_XT_ConfigValue1TitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_ConfigValue1_Internalname, "Title", edtXT_ConfigValue1_Title, !bGXsfl_12_Refreshing);
         edtXT_ConfigValue2_Titleformat = 2;
         edtXT_ConfigValue2_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "配置值2", AV20ddo_XT_ConfigValue2TitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_ConfigValue2_Internalname, "Title", edtXT_ConfigValue2_Title, !bGXsfl_12_Refreshing);
         edtXT_ConfigValue3_Titleformat = 2;
         edtXT_ConfigValue3_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "配置值3", AV22ddo_XT_ConfigValue3TitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_ConfigValue3_Internalname, "Title", edtXT_ConfigValue3_Title, !bGXsfl_12_Refreshing);
         edtXT_ConfigValue4_Titleformat = 2;
         edtXT_ConfigValue4_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "配置值4", AV24ddo_XT_ConfigValue4TitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_ConfigValue4_Internalname, "Title", edtXT_ConfigValue4_Title, !bGXsfl_12_Refreshing);
         edtXT_ConfigValue5_Titleformat = 2;
         edtXT_ConfigValue5_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "配置值5", AV26ddo_XT_ConfigValue5TitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_ConfigValue5_Internalname, "Title", edtXT_ConfigValue5_Title, !bGXsfl_12_Refreshing);
         AV29GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29GridCurrentPage), 10, 0)));
         AV30GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30GridPageSize), 10, 0)));
         AV31GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV31GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13XT_ConfigIDTitleFilterData", AV13XT_ConfigIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15XT_ConfigKeyTitleFilterData", AV15XT_ConfigKeyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17XT_ConfigValue1TitleFilterData", AV17XT_ConfigValue1TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_ConfigValue2TitleFilterData", AV19XT_ConfigValue2TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21XT_ConfigValue3TitleFilterData", AV21XT_ConfigValue3TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23XT_ConfigValue4TitleFilterData", AV23XT_ConfigValue4TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25XT_ConfigValue5TitleFilterData", AV25XT_ConfigValue5TitleFilterData);
      }

      protected void E116Z2( )
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
            AV28PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV28PageToGo) ;
         }
      }

      protected void E126Z2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E136Z2( )
      {
         /* Ddo_xt_configid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_configid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_configid_Sortedstatus = "ASC";
            ucDdo_xt_configid.SendProperty(context, "", false, Ddo_xt_configid_Internalname, "SortedStatus", Ddo_xt_configid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_configid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_configid_Sortedstatus = "DSC";
            ucDdo_xt_configid.SendProperty(context, "", false, Ddo_xt_configid_Internalname, "SortedStatus", Ddo_xt_configid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13XT_ConfigIDTitleFilterData", AV13XT_ConfigIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15XT_ConfigKeyTitleFilterData", AV15XT_ConfigKeyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17XT_ConfigValue1TitleFilterData", AV17XT_ConfigValue1TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_ConfigValue2TitleFilterData", AV19XT_ConfigValue2TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21XT_ConfigValue3TitleFilterData", AV21XT_ConfigValue3TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23XT_ConfigValue4TitleFilterData", AV23XT_ConfigValue4TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25XT_ConfigValue5TitleFilterData", AV25XT_ConfigValue5TitleFilterData);
      }

      protected void E146Z2( )
      {
         /* Ddo_xt_configkey_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_configkey_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_configkey_Sortedstatus = "ASC";
            ucDdo_xt_configkey.SendProperty(context, "", false, Ddo_xt_configkey_Internalname, "SortedStatus", Ddo_xt_configkey_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_configkey_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_configkey_Sortedstatus = "DSC";
            ucDdo_xt_configkey.SendProperty(context, "", false, Ddo_xt_configkey_Internalname, "SortedStatus", Ddo_xt_configkey_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13XT_ConfigIDTitleFilterData", AV13XT_ConfigIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15XT_ConfigKeyTitleFilterData", AV15XT_ConfigKeyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17XT_ConfigValue1TitleFilterData", AV17XT_ConfigValue1TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_ConfigValue2TitleFilterData", AV19XT_ConfigValue2TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21XT_ConfigValue3TitleFilterData", AV21XT_ConfigValue3TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23XT_ConfigValue4TitleFilterData", AV23XT_ConfigValue4TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25XT_ConfigValue5TitleFilterData", AV25XT_ConfigValue5TitleFilterData);
      }

      protected void E156Z2( )
      {
         /* Ddo_xt_configvalue1_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_configvalue1_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_configvalue1_Sortedstatus = "ASC";
            ucDdo_xt_configvalue1.SendProperty(context, "", false, Ddo_xt_configvalue1_Internalname, "SortedStatus", Ddo_xt_configvalue1_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_configvalue1_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_configvalue1_Sortedstatus = "DSC";
            ucDdo_xt_configvalue1.SendProperty(context, "", false, Ddo_xt_configvalue1_Internalname, "SortedStatus", Ddo_xt_configvalue1_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13XT_ConfigIDTitleFilterData", AV13XT_ConfigIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15XT_ConfigKeyTitleFilterData", AV15XT_ConfigKeyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17XT_ConfigValue1TitleFilterData", AV17XT_ConfigValue1TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_ConfigValue2TitleFilterData", AV19XT_ConfigValue2TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21XT_ConfigValue3TitleFilterData", AV21XT_ConfigValue3TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23XT_ConfigValue4TitleFilterData", AV23XT_ConfigValue4TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25XT_ConfigValue5TitleFilterData", AV25XT_ConfigValue5TitleFilterData);
      }

      protected void E166Z2( )
      {
         /* Ddo_xt_configvalue2_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_configvalue2_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_configvalue2_Sortedstatus = "ASC";
            ucDdo_xt_configvalue2.SendProperty(context, "", false, Ddo_xt_configvalue2_Internalname, "SortedStatus", Ddo_xt_configvalue2_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_configvalue2_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_configvalue2_Sortedstatus = "DSC";
            ucDdo_xt_configvalue2.SendProperty(context, "", false, Ddo_xt_configvalue2_Internalname, "SortedStatus", Ddo_xt_configvalue2_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13XT_ConfigIDTitleFilterData", AV13XT_ConfigIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15XT_ConfigKeyTitleFilterData", AV15XT_ConfigKeyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17XT_ConfigValue1TitleFilterData", AV17XT_ConfigValue1TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_ConfigValue2TitleFilterData", AV19XT_ConfigValue2TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21XT_ConfigValue3TitleFilterData", AV21XT_ConfigValue3TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23XT_ConfigValue4TitleFilterData", AV23XT_ConfigValue4TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25XT_ConfigValue5TitleFilterData", AV25XT_ConfigValue5TitleFilterData);
      }

      protected void E176Z2( )
      {
         /* Ddo_xt_configvalue3_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_configvalue3_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_configvalue3_Sortedstatus = "ASC";
            ucDdo_xt_configvalue3.SendProperty(context, "", false, Ddo_xt_configvalue3_Internalname, "SortedStatus", Ddo_xt_configvalue3_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_configvalue3_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_configvalue3_Sortedstatus = "DSC";
            ucDdo_xt_configvalue3.SendProperty(context, "", false, Ddo_xt_configvalue3_Internalname, "SortedStatus", Ddo_xt_configvalue3_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13XT_ConfigIDTitleFilterData", AV13XT_ConfigIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15XT_ConfigKeyTitleFilterData", AV15XT_ConfigKeyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17XT_ConfigValue1TitleFilterData", AV17XT_ConfigValue1TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_ConfigValue2TitleFilterData", AV19XT_ConfigValue2TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21XT_ConfigValue3TitleFilterData", AV21XT_ConfigValue3TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23XT_ConfigValue4TitleFilterData", AV23XT_ConfigValue4TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25XT_ConfigValue5TitleFilterData", AV25XT_ConfigValue5TitleFilterData);
      }

      protected void E186Z2( )
      {
         /* Ddo_xt_configvalue4_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_configvalue4_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_configvalue4_Sortedstatus = "ASC";
            ucDdo_xt_configvalue4.SendProperty(context, "", false, Ddo_xt_configvalue4_Internalname, "SortedStatus", Ddo_xt_configvalue4_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_configvalue4_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_configvalue4_Sortedstatus = "DSC";
            ucDdo_xt_configvalue4.SendProperty(context, "", false, Ddo_xt_configvalue4_Internalname, "SortedStatus", Ddo_xt_configvalue4_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13XT_ConfigIDTitleFilterData", AV13XT_ConfigIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15XT_ConfigKeyTitleFilterData", AV15XT_ConfigKeyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17XT_ConfigValue1TitleFilterData", AV17XT_ConfigValue1TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_ConfigValue2TitleFilterData", AV19XT_ConfigValue2TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21XT_ConfigValue3TitleFilterData", AV21XT_ConfigValue3TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23XT_ConfigValue4TitleFilterData", AV23XT_ConfigValue4TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25XT_ConfigValue5TitleFilterData", AV25XT_ConfigValue5TitleFilterData);
      }

      protected void E196Z2( )
      {
         /* Ddo_xt_configvalue5_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_configvalue5_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_configvalue5_Sortedstatus = "ASC";
            ucDdo_xt_configvalue5.SendProperty(context, "", false, Ddo_xt_configvalue5_Internalname, "SortedStatus", Ddo_xt_configvalue5_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_configvalue5_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_configvalue5_Sortedstatus = "DSC";
            ucDdo_xt_configvalue5.SendProperty(context, "", false, Ddo_xt_configvalue5_Internalname, "SortedStatus", Ddo_xt_configvalue5_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13XT_ConfigIDTitleFilterData", AV13XT_ConfigIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15XT_ConfigKeyTitleFilterData", AV15XT_ConfigKeyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17XT_ConfigValue1TitleFilterData", AV17XT_ConfigValue1TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_ConfigValue2TitleFilterData", AV19XT_ConfigValue2TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21XT_ConfigValue3TitleFilterData", AV21XT_ConfigValue3TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23XT_ConfigValue4TitleFilterData", AV23XT_ConfigValue4TitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25XT_ConfigValue5TitleFilterData", AV25XT_ConfigValue5TitleFilterData);
      }

      private void E226Z2( )
      {
         /* Grid_Load Routine */
         AV32Select = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSelect_Internalname, AV32Select);
         AV36Select_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
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
         E236Z2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E236Z2( )
      {
         /* Enter Routine */
         AV8InOutXT_ConfigID = A195XT_ConfigID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutXT_ConfigID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutXT_ConfigID), 18, 0)));
         AV9InOutXT_ConfigKey = A196XT_ConfigKey;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutXT_ConfigKey", AV9InOutXT_ConfigKey);
         context.setWebReturnParms(new Object[] {(long)AV8InOutXT_ConfigID,(String)AV9InOutXT_ConfigKey});
         context.setWebReturnParmsMetadata(new Object[] {"AV8InOutXT_ConfigID","AV9InOutXT_ConfigKey"});
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
         AV8InOutXT_ConfigID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutXT_ConfigID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutXT_ConfigID), 18, 0)));
         AV9InOutXT_ConfigKey = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutXT_ConfigKey", AV9InOutXT_ConfigKey);
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
         PA6Z2( ) ;
         WS6Z2( ) ;
         WE6Z2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279464727", true);
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
         context.AddJavascriptSource("xt_configprompt.js", "?20202279464728", false);
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
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_idx;
         edtXT_ConfigID_Internalname = "XT_CONFIGID_"+sGXsfl_12_idx;
         edtXT_ConfigKey_Internalname = "XT_CONFIGKEY_"+sGXsfl_12_idx;
         edtXT_ConfigValue1_Internalname = "XT_CONFIGVALUE1_"+sGXsfl_12_idx;
         edtXT_ConfigValue2_Internalname = "XT_CONFIGVALUE2_"+sGXsfl_12_idx;
         edtXT_ConfigValue3_Internalname = "XT_CONFIGVALUE3_"+sGXsfl_12_idx;
         edtXT_ConfigValue4_Internalname = "XT_CONFIGVALUE4_"+sGXsfl_12_idx;
         edtXT_ConfigValue5_Internalname = "XT_CONFIGVALUE5_"+sGXsfl_12_idx;
      }

      protected void SubsflControlProps_fel_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_fel_idx;
         edtXT_ConfigID_Internalname = "XT_CONFIGID_"+sGXsfl_12_fel_idx;
         edtXT_ConfigKey_Internalname = "XT_CONFIGKEY_"+sGXsfl_12_fel_idx;
         edtXT_ConfigValue1_Internalname = "XT_CONFIGVALUE1_"+sGXsfl_12_fel_idx;
         edtXT_ConfigValue2_Internalname = "XT_CONFIGVALUE2_"+sGXsfl_12_fel_idx;
         edtXT_ConfigValue3_Internalname = "XT_CONFIGVALUE3_"+sGXsfl_12_fel_idx;
         edtXT_ConfigValue4_Internalname = "XT_CONFIGVALUE4_"+sGXsfl_12_fel_idx;
         edtXT_ConfigValue5_Internalname = "XT_CONFIGVALUE5_"+sGXsfl_12_fel_idx;
      }

      protected void sendrow_122( )
      {
         SubsflControlProps_122( ) ;
         WB6Z0( ) ;
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
            AV32Select_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV32Select))&&String.IsNullOrEmpty(StringUtil.RTrim( AV36Select_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV32Select)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV32Select)) ? AV36Select_GXI : context.PathToRelativeUrl( AV32Select));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSelect_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSelect_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSelect_Jsonclick,"'"+""+"'"+",false,"+"'"+"EENTER."+sGXsfl_12_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV32Select_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_ConfigID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A195XT_ConfigID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A195XT_ConfigID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_ConfigID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_ConfigKey_Internalname,(String)A196XT_ConfigKey,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_ConfigKey_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_ConfigValue1_Internalname,(String)A197XT_ConfigValue1,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_ConfigValue1_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)200,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_ConfigValue2_Internalname,(String)A198XT_ConfigValue2,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_ConfigValue2_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)200,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_ConfigValue3_Internalname,(String)A199XT_ConfigValue3,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_ConfigValue3_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)200,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_ConfigValue4_Internalname,(String)A200XT_ConfigValue4,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_ConfigValue4_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)200,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_ConfigValue5_Internalname,(String)A201XT_ConfigValue5,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_ConfigValue5_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)200,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes6Z2( ) ;
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
         edtXT_ConfigID_Internalname = "XT_CONFIGID";
         edtXT_ConfigKey_Internalname = "XT_CONFIGKEY";
         edtXT_ConfigValue1_Internalname = "XT_CONFIGVALUE1";
         edtXT_ConfigValue2_Internalname = "XT_CONFIGVALUE2";
         edtXT_ConfigValue3_Internalname = "XT_CONFIGVALUE3";
         edtXT_ConfigValue4_Internalname = "XT_CONFIGVALUE4";
         edtXT_ConfigValue5_Internalname = "XT_CONFIGVALUE5";
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
         Ddo_xt_configvalue3_Internalname = "DDO_XT_CONFIGVALUE3";
         edtavDdo_xt_configvalue3titlecontrolidtoreplace_Internalname = "vDDO_XT_CONFIGVALUE3TITLECONTROLIDTOREPLACE";
         Ddo_xt_configvalue4_Internalname = "DDO_XT_CONFIGVALUE4";
         edtavDdo_xt_configvalue4titlecontrolidtoreplace_Internalname = "vDDO_XT_CONFIGVALUE4TITLECONTROLIDTOREPLACE";
         Ddo_xt_configvalue5_Internalname = "DDO_XT_CONFIGVALUE5";
         edtavDdo_xt_configvalue5titlecontrolidtoreplace_Internalname = "vDDO_XT_CONFIGVALUE5TITLECONTROLIDTOREPLACE";
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
         edtXT_ConfigValue5_Jsonclick = "";
         edtXT_ConfigValue4_Jsonclick = "";
         edtXT_ConfigValue3_Jsonclick = "";
         edtXT_ConfigValue2_Jsonclick = "";
         edtXT_ConfigValue1_Jsonclick = "";
         edtXT_ConfigKey_Jsonclick = "";
         edtXT_ConfigID_Jsonclick = "";
         edtavSelect_Jsonclick = "";
         edtavSelect_Visible = -1;
         edtavSelect_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_xt_configvalue5titlecontrolidtoreplace_Visible = 1;
         edtavDdo_xt_configvalue4titlecontrolidtoreplace_Visible = 1;
         edtavDdo_xt_configvalue3titlecontrolidtoreplace_Visible = 1;
         edtavDdo_xt_configvalue2titlecontrolidtoreplace_Visible = 1;
         edtavDdo_xt_configvalue1titlecontrolidtoreplace_Visible = 1;
         edtavDdo_xt_configkeytitlecontrolidtoreplace_Visible = 1;
         edtavDdo_xt_configidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavSelect_Tooltiptext = "选择";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtXT_ConfigValue5_Titleformat = 0;
         edtXT_ConfigValue5_Title = "配置值5";
         edtXT_ConfigValue4_Titleformat = 0;
         edtXT_ConfigValue4_Title = "配置值4";
         edtXT_ConfigValue3_Titleformat = 0;
         edtXT_ConfigValue3_Title = "配置值3";
         edtXT_ConfigValue2_Titleformat = 0;
         edtXT_ConfigValue2_Title = "配置值2";
         edtXT_ConfigValue1_Titleformat = 0;
         edtXT_ConfigValue1_Title = "配置值1";
         edtXT_ConfigKey_Titleformat = 0;
         edtXT_ConfigKey_Title = "配置名称";
         edtXT_ConfigID_Titleformat = 0;
         edtXT_ConfigID_Title = "系统配置的主键";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         divTablemain_Height = 0;
         Ddo_xt_configvalue5_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_configvalue5_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_configvalue5_Sortasc = "WWP_TSSortASC";
         Ddo_xt_configvalue5_Includedatalist = Convert.ToBoolean( 0);
         Ddo_xt_configvalue5_Includefilter = Convert.ToBoolean( 0);
         Ddo_xt_configvalue5_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_xt_configvalue5_Includesortasc = Convert.ToBoolean( -1);
         Ddo_xt_configvalue5_Titlecontrolidtoreplace = "";
         Ddo_xt_configvalue5_Dropdownoptionstype = "GridTitleSettings";
         Ddo_xt_configvalue5_Cls = "ColumnSettings";
         Ddo_xt_configvalue5_Tooltip = "WWP_TSColumnOptions";
         Ddo_xt_configvalue5_Caption = "";
         Ddo_xt_configvalue4_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_configvalue4_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_configvalue4_Sortasc = "WWP_TSSortASC";
         Ddo_xt_configvalue4_Includedatalist = Convert.ToBoolean( 0);
         Ddo_xt_configvalue4_Includefilter = Convert.ToBoolean( 0);
         Ddo_xt_configvalue4_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_xt_configvalue4_Includesortasc = Convert.ToBoolean( -1);
         Ddo_xt_configvalue4_Titlecontrolidtoreplace = "";
         Ddo_xt_configvalue4_Dropdownoptionstype = "GridTitleSettings";
         Ddo_xt_configvalue4_Cls = "ColumnSettings";
         Ddo_xt_configvalue4_Tooltip = "WWP_TSColumnOptions";
         Ddo_xt_configvalue4_Caption = "";
         Ddo_xt_configvalue3_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_configvalue3_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_configvalue3_Sortasc = "WWP_TSSortASC";
         Ddo_xt_configvalue3_Includedatalist = Convert.ToBoolean( 0);
         Ddo_xt_configvalue3_Includefilter = Convert.ToBoolean( 0);
         Ddo_xt_configvalue3_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_xt_configvalue3_Includesortasc = Convert.ToBoolean( -1);
         Ddo_xt_configvalue3_Titlecontrolidtoreplace = "";
         Ddo_xt_configvalue3_Dropdownoptionstype = "GridTitleSettings";
         Ddo_xt_configvalue3_Cls = "ColumnSettings";
         Ddo_xt_configvalue3_Tooltip = "WWP_TSColumnOptions";
         Ddo_xt_configvalue3_Caption = "";
         Ddo_xt_configvalue2_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_configvalue2_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_configvalue2_Sortasc = "WWP_TSSortASC";
         Ddo_xt_configvalue2_Includedatalist = Convert.ToBoolean( 0);
         Ddo_xt_configvalue2_Includefilter = Convert.ToBoolean( 0);
         Ddo_xt_configvalue2_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_xt_configvalue2_Includesortasc = Convert.ToBoolean( -1);
         Ddo_xt_configvalue2_Titlecontrolidtoreplace = "";
         Ddo_xt_configvalue2_Dropdownoptionstype = "GridTitleSettings";
         Ddo_xt_configvalue2_Cls = "ColumnSettings";
         Ddo_xt_configvalue2_Tooltip = "WWP_TSColumnOptions";
         Ddo_xt_configvalue2_Caption = "";
         Ddo_xt_configvalue1_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_configvalue1_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_configvalue1_Sortasc = "WWP_TSSortASC";
         Ddo_xt_configvalue1_Includedatalist = Convert.ToBoolean( 0);
         Ddo_xt_configvalue1_Includefilter = Convert.ToBoolean( 0);
         Ddo_xt_configvalue1_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_xt_configvalue1_Includesortasc = Convert.ToBoolean( -1);
         Ddo_xt_configvalue1_Titlecontrolidtoreplace = "";
         Ddo_xt_configvalue1_Dropdownoptionstype = "GridTitleSettings";
         Ddo_xt_configvalue1_Cls = "ColumnSettings";
         Ddo_xt_configvalue1_Tooltip = "WWP_TSColumnOptions";
         Ddo_xt_configvalue1_Caption = "";
         Ddo_xt_configkey_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_configkey_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_configkey_Sortasc = "WWP_TSSortASC";
         Ddo_xt_configkey_Includedatalist = Convert.ToBoolean( 0);
         Ddo_xt_configkey_Includefilter = Convert.ToBoolean( 0);
         Ddo_xt_configkey_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_xt_configkey_Includesortasc = Convert.ToBoolean( -1);
         Ddo_xt_configkey_Titlecontrolidtoreplace = "";
         Ddo_xt_configkey_Dropdownoptionstype = "GridTitleSettings";
         Ddo_xt_configkey_Cls = "ColumnSettings";
         Ddo_xt_configkey_Tooltip = "WWP_TSColumnOptions";
         Ddo_xt_configkey_Caption = "";
         Ddo_xt_configid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_configid_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_configid_Sortasc = "WWP_TSSortASC";
         Ddo_xt_configid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_xt_configid_Includefilter = Convert.ToBoolean( 0);
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
         Form.Caption = "选择系统配置表";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_ConfigIDTitleControlIdToReplace',fld:'vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_ConfigKeyTitleControlIdToReplace',fld:'vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_ConfigValue1TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_ConfigValue2TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_XT_ConfigValue3TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE3TITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_XT_ConfigValue4TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE4TITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_XT_ConfigValue5TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE5TITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV13XT_ConfigIDTitleFilterData',fld:'vXT_CONFIGIDTITLEFILTERDATA',pic:''},{av:'AV15XT_ConfigKeyTitleFilterData',fld:'vXT_CONFIGKEYTITLEFILTERDATA',pic:''},{av:'AV17XT_ConfigValue1TitleFilterData',fld:'vXT_CONFIGVALUE1TITLEFILTERDATA',pic:''},{av:'AV19XT_ConfigValue2TitleFilterData',fld:'vXT_CONFIGVALUE2TITLEFILTERDATA',pic:''},{av:'AV21XT_ConfigValue3TitleFilterData',fld:'vXT_CONFIGVALUE3TITLEFILTERDATA',pic:''},{av:'AV23XT_ConfigValue4TitleFilterData',fld:'vXT_CONFIGVALUE4TITLEFILTERDATA',pic:''},{av:'AV25XT_ConfigValue5TitleFilterData',fld:'vXT_CONFIGVALUE5TITLEFILTERDATA',pic:''},{av:'edtXT_ConfigID_Titleformat',ctrl:'XT_CONFIGID',prop:'Titleformat'},{av:'edtXT_ConfigID_Title',ctrl:'XT_CONFIGID',prop:'Title'},{av:'edtXT_ConfigKey_Titleformat',ctrl:'XT_CONFIGKEY',prop:'Titleformat'},{av:'edtXT_ConfigKey_Title',ctrl:'XT_CONFIGKEY',prop:'Title'},{av:'edtXT_ConfigValue1_Titleformat',ctrl:'XT_CONFIGVALUE1',prop:'Titleformat'},{av:'edtXT_ConfigValue1_Title',ctrl:'XT_CONFIGVALUE1',prop:'Title'},{av:'edtXT_ConfigValue2_Titleformat',ctrl:'XT_CONFIGVALUE2',prop:'Titleformat'},{av:'edtXT_ConfigValue2_Title',ctrl:'XT_CONFIGVALUE2',prop:'Title'},{av:'edtXT_ConfigValue3_Titleformat',ctrl:'XT_CONFIGVALUE3',prop:'Titleformat'},{av:'edtXT_ConfigValue3_Title',ctrl:'XT_CONFIGVALUE3',prop:'Title'},{av:'edtXT_ConfigValue4_Titleformat',ctrl:'XT_CONFIGVALUE4',prop:'Titleformat'},{av:'edtXT_ConfigValue4_Title',ctrl:'XT_CONFIGVALUE4',prop:'Title'},{av:'edtXT_ConfigValue5_Titleformat',ctrl:'XT_CONFIGVALUE5',prop:'Titleformat'},{av:'edtXT_ConfigValue5_Title',ctrl:'XT_CONFIGVALUE5',prop:'Title'},{av:'AV29GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV30GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV31GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E116Z2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_ConfigIDTitleControlIdToReplace',fld:'vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_ConfigKeyTitleControlIdToReplace',fld:'vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_ConfigValue1TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_ConfigValue2TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_XT_ConfigValue3TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE3TITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_XT_ConfigValue4TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE4TITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_XT_ConfigValue5TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE5TITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E126Z2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_ConfigIDTitleControlIdToReplace',fld:'vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_ConfigKeyTitleControlIdToReplace',fld:'vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_ConfigValue1TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_ConfigValue2TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_XT_ConfigValue3TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE3TITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_XT_ConfigValue4TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE4TITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_XT_ConfigValue5TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE5TITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_XT_CONFIGID.ONOPTIONCLICKED","{handler:'E136Z2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_ConfigIDTitleControlIdToReplace',fld:'vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_ConfigKeyTitleControlIdToReplace',fld:'vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_ConfigValue1TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_ConfigValue2TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_XT_ConfigValue3TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE3TITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_XT_ConfigValue4TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE4TITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_XT_ConfigValue5TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE5TITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_xt_configid_Activeeventkey',ctrl:'DDO_XT_CONFIGID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_CONFIGID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_configid_Sortedstatus',ctrl:'DDO_XT_CONFIGID',prop:'SortedStatus'},{av:'AV13XT_ConfigIDTitleFilterData',fld:'vXT_CONFIGIDTITLEFILTERDATA',pic:''},{av:'AV15XT_ConfigKeyTitleFilterData',fld:'vXT_CONFIGKEYTITLEFILTERDATA',pic:''},{av:'AV17XT_ConfigValue1TitleFilterData',fld:'vXT_CONFIGVALUE1TITLEFILTERDATA',pic:''},{av:'AV19XT_ConfigValue2TitleFilterData',fld:'vXT_CONFIGVALUE2TITLEFILTERDATA',pic:''},{av:'AV21XT_ConfigValue3TitleFilterData',fld:'vXT_CONFIGVALUE3TITLEFILTERDATA',pic:''},{av:'AV23XT_ConfigValue4TitleFilterData',fld:'vXT_CONFIGVALUE4TITLEFILTERDATA',pic:''},{av:'AV25XT_ConfigValue5TitleFilterData',fld:'vXT_CONFIGVALUE5TITLEFILTERDATA',pic:''},{av:'edtXT_ConfigID_Titleformat',ctrl:'XT_CONFIGID',prop:'Titleformat'},{av:'edtXT_ConfigID_Title',ctrl:'XT_CONFIGID',prop:'Title'},{av:'edtXT_ConfigKey_Titleformat',ctrl:'XT_CONFIGKEY',prop:'Titleformat'},{av:'edtXT_ConfigKey_Title',ctrl:'XT_CONFIGKEY',prop:'Title'},{av:'edtXT_ConfigValue1_Titleformat',ctrl:'XT_CONFIGVALUE1',prop:'Titleformat'},{av:'edtXT_ConfigValue1_Title',ctrl:'XT_CONFIGVALUE1',prop:'Title'},{av:'edtXT_ConfigValue2_Titleformat',ctrl:'XT_CONFIGVALUE2',prop:'Titleformat'},{av:'edtXT_ConfigValue2_Title',ctrl:'XT_CONFIGVALUE2',prop:'Title'},{av:'edtXT_ConfigValue3_Titleformat',ctrl:'XT_CONFIGVALUE3',prop:'Titleformat'},{av:'edtXT_ConfigValue3_Title',ctrl:'XT_CONFIGVALUE3',prop:'Title'},{av:'edtXT_ConfigValue4_Titleformat',ctrl:'XT_CONFIGVALUE4',prop:'Titleformat'},{av:'edtXT_ConfigValue4_Title',ctrl:'XT_CONFIGVALUE4',prop:'Title'},{av:'edtXT_ConfigValue5_Titleformat',ctrl:'XT_CONFIGVALUE5',prop:'Titleformat'},{av:'edtXT_ConfigValue5_Title',ctrl:'XT_CONFIGVALUE5',prop:'Title'},{av:'AV29GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV30GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV31GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_XT_CONFIGKEY.ONOPTIONCLICKED","{handler:'E146Z2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_ConfigIDTitleControlIdToReplace',fld:'vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_ConfigKeyTitleControlIdToReplace',fld:'vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_ConfigValue1TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_ConfigValue2TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_XT_ConfigValue3TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE3TITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_XT_ConfigValue4TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE4TITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_XT_ConfigValue5TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE5TITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_xt_configkey_Activeeventkey',ctrl:'DDO_XT_CONFIGKEY',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_CONFIGKEY.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_configkey_Sortedstatus',ctrl:'DDO_XT_CONFIGKEY',prop:'SortedStatus'},{av:'AV13XT_ConfigIDTitleFilterData',fld:'vXT_CONFIGIDTITLEFILTERDATA',pic:''},{av:'AV15XT_ConfigKeyTitleFilterData',fld:'vXT_CONFIGKEYTITLEFILTERDATA',pic:''},{av:'AV17XT_ConfigValue1TitleFilterData',fld:'vXT_CONFIGVALUE1TITLEFILTERDATA',pic:''},{av:'AV19XT_ConfigValue2TitleFilterData',fld:'vXT_CONFIGVALUE2TITLEFILTERDATA',pic:''},{av:'AV21XT_ConfigValue3TitleFilterData',fld:'vXT_CONFIGVALUE3TITLEFILTERDATA',pic:''},{av:'AV23XT_ConfigValue4TitleFilterData',fld:'vXT_CONFIGVALUE4TITLEFILTERDATA',pic:''},{av:'AV25XT_ConfigValue5TitleFilterData',fld:'vXT_CONFIGVALUE5TITLEFILTERDATA',pic:''},{av:'edtXT_ConfigID_Titleformat',ctrl:'XT_CONFIGID',prop:'Titleformat'},{av:'edtXT_ConfigID_Title',ctrl:'XT_CONFIGID',prop:'Title'},{av:'edtXT_ConfigKey_Titleformat',ctrl:'XT_CONFIGKEY',prop:'Titleformat'},{av:'edtXT_ConfigKey_Title',ctrl:'XT_CONFIGKEY',prop:'Title'},{av:'edtXT_ConfigValue1_Titleformat',ctrl:'XT_CONFIGVALUE1',prop:'Titleformat'},{av:'edtXT_ConfigValue1_Title',ctrl:'XT_CONFIGVALUE1',prop:'Title'},{av:'edtXT_ConfigValue2_Titleformat',ctrl:'XT_CONFIGVALUE2',prop:'Titleformat'},{av:'edtXT_ConfigValue2_Title',ctrl:'XT_CONFIGVALUE2',prop:'Title'},{av:'edtXT_ConfigValue3_Titleformat',ctrl:'XT_CONFIGVALUE3',prop:'Titleformat'},{av:'edtXT_ConfigValue3_Title',ctrl:'XT_CONFIGVALUE3',prop:'Title'},{av:'edtXT_ConfigValue4_Titleformat',ctrl:'XT_CONFIGVALUE4',prop:'Titleformat'},{av:'edtXT_ConfigValue4_Title',ctrl:'XT_CONFIGVALUE4',prop:'Title'},{av:'edtXT_ConfigValue5_Titleformat',ctrl:'XT_CONFIGVALUE5',prop:'Titleformat'},{av:'edtXT_ConfigValue5_Title',ctrl:'XT_CONFIGVALUE5',prop:'Title'},{av:'AV29GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV30GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV31GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_XT_CONFIGVALUE1.ONOPTIONCLICKED","{handler:'E156Z2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_ConfigIDTitleControlIdToReplace',fld:'vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_ConfigKeyTitleControlIdToReplace',fld:'vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_ConfigValue1TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_ConfigValue2TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_XT_ConfigValue3TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE3TITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_XT_ConfigValue4TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE4TITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_XT_ConfigValue5TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE5TITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_xt_configvalue1_Activeeventkey',ctrl:'DDO_XT_CONFIGVALUE1',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_CONFIGVALUE1.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_configvalue1_Sortedstatus',ctrl:'DDO_XT_CONFIGVALUE1',prop:'SortedStatus'},{av:'AV13XT_ConfigIDTitleFilterData',fld:'vXT_CONFIGIDTITLEFILTERDATA',pic:''},{av:'AV15XT_ConfigKeyTitleFilterData',fld:'vXT_CONFIGKEYTITLEFILTERDATA',pic:''},{av:'AV17XT_ConfigValue1TitleFilterData',fld:'vXT_CONFIGVALUE1TITLEFILTERDATA',pic:''},{av:'AV19XT_ConfigValue2TitleFilterData',fld:'vXT_CONFIGVALUE2TITLEFILTERDATA',pic:''},{av:'AV21XT_ConfigValue3TitleFilterData',fld:'vXT_CONFIGVALUE3TITLEFILTERDATA',pic:''},{av:'AV23XT_ConfigValue4TitleFilterData',fld:'vXT_CONFIGVALUE4TITLEFILTERDATA',pic:''},{av:'AV25XT_ConfigValue5TitleFilterData',fld:'vXT_CONFIGVALUE5TITLEFILTERDATA',pic:''},{av:'edtXT_ConfigID_Titleformat',ctrl:'XT_CONFIGID',prop:'Titleformat'},{av:'edtXT_ConfigID_Title',ctrl:'XT_CONFIGID',prop:'Title'},{av:'edtXT_ConfigKey_Titleformat',ctrl:'XT_CONFIGKEY',prop:'Titleformat'},{av:'edtXT_ConfigKey_Title',ctrl:'XT_CONFIGKEY',prop:'Title'},{av:'edtXT_ConfigValue1_Titleformat',ctrl:'XT_CONFIGVALUE1',prop:'Titleformat'},{av:'edtXT_ConfigValue1_Title',ctrl:'XT_CONFIGVALUE1',prop:'Title'},{av:'edtXT_ConfigValue2_Titleformat',ctrl:'XT_CONFIGVALUE2',prop:'Titleformat'},{av:'edtXT_ConfigValue2_Title',ctrl:'XT_CONFIGVALUE2',prop:'Title'},{av:'edtXT_ConfigValue3_Titleformat',ctrl:'XT_CONFIGVALUE3',prop:'Titleformat'},{av:'edtXT_ConfigValue3_Title',ctrl:'XT_CONFIGVALUE3',prop:'Title'},{av:'edtXT_ConfigValue4_Titleformat',ctrl:'XT_CONFIGVALUE4',prop:'Titleformat'},{av:'edtXT_ConfigValue4_Title',ctrl:'XT_CONFIGVALUE4',prop:'Title'},{av:'edtXT_ConfigValue5_Titleformat',ctrl:'XT_CONFIGVALUE5',prop:'Titleformat'},{av:'edtXT_ConfigValue5_Title',ctrl:'XT_CONFIGVALUE5',prop:'Title'},{av:'AV29GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV30GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV31GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_XT_CONFIGVALUE2.ONOPTIONCLICKED","{handler:'E166Z2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_ConfigIDTitleControlIdToReplace',fld:'vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_ConfigKeyTitleControlIdToReplace',fld:'vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_ConfigValue1TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_ConfigValue2TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_XT_ConfigValue3TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE3TITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_XT_ConfigValue4TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE4TITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_XT_ConfigValue5TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE5TITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_xt_configvalue2_Activeeventkey',ctrl:'DDO_XT_CONFIGVALUE2',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_CONFIGVALUE2.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_configvalue2_Sortedstatus',ctrl:'DDO_XT_CONFIGVALUE2',prop:'SortedStatus'},{av:'AV13XT_ConfigIDTitleFilterData',fld:'vXT_CONFIGIDTITLEFILTERDATA',pic:''},{av:'AV15XT_ConfigKeyTitleFilterData',fld:'vXT_CONFIGKEYTITLEFILTERDATA',pic:''},{av:'AV17XT_ConfigValue1TitleFilterData',fld:'vXT_CONFIGVALUE1TITLEFILTERDATA',pic:''},{av:'AV19XT_ConfigValue2TitleFilterData',fld:'vXT_CONFIGVALUE2TITLEFILTERDATA',pic:''},{av:'AV21XT_ConfigValue3TitleFilterData',fld:'vXT_CONFIGVALUE3TITLEFILTERDATA',pic:''},{av:'AV23XT_ConfigValue4TitleFilterData',fld:'vXT_CONFIGVALUE4TITLEFILTERDATA',pic:''},{av:'AV25XT_ConfigValue5TitleFilterData',fld:'vXT_CONFIGVALUE5TITLEFILTERDATA',pic:''},{av:'edtXT_ConfigID_Titleformat',ctrl:'XT_CONFIGID',prop:'Titleformat'},{av:'edtXT_ConfigID_Title',ctrl:'XT_CONFIGID',prop:'Title'},{av:'edtXT_ConfigKey_Titleformat',ctrl:'XT_CONFIGKEY',prop:'Titleformat'},{av:'edtXT_ConfigKey_Title',ctrl:'XT_CONFIGKEY',prop:'Title'},{av:'edtXT_ConfigValue1_Titleformat',ctrl:'XT_CONFIGVALUE1',prop:'Titleformat'},{av:'edtXT_ConfigValue1_Title',ctrl:'XT_CONFIGVALUE1',prop:'Title'},{av:'edtXT_ConfigValue2_Titleformat',ctrl:'XT_CONFIGVALUE2',prop:'Titleformat'},{av:'edtXT_ConfigValue2_Title',ctrl:'XT_CONFIGVALUE2',prop:'Title'},{av:'edtXT_ConfigValue3_Titleformat',ctrl:'XT_CONFIGVALUE3',prop:'Titleformat'},{av:'edtXT_ConfigValue3_Title',ctrl:'XT_CONFIGVALUE3',prop:'Title'},{av:'edtXT_ConfigValue4_Titleformat',ctrl:'XT_CONFIGVALUE4',prop:'Titleformat'},{av:'edtXT_ConfigValue4_Title',ctrl:'XT_CONFIGVALUE4',prop:'Title'},{av:'edtXT_ConfigValue5_Titleformat',ctrl:'XT_CONFIGVALUE5',prop:'Titleformat'},{av:'edtXT_ConfigValue5_Title',ctrl:'XT_CONFIGVALUE5',prop:'Title'},{av:'AV29GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV30GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV31GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_XT_CONFIGVALUE3.ONOPTIONCLICKED","{handler:'E176Z2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_ConfigIDTitleControlIdToReplace',fld:'vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_ConfigKeyTitleControlIdToReplace',fld:'vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_ConfigValue1TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_ConfigValue2TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_XT_ConfigValue3TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE3TITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_XT_ConfigValue4TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE4TITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_XT_ConfigValue5TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE5TITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_xt_configvalue3_Activeeventkey',ctrl:'DDO_XT_CONFIGVALUE3',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_CONFIGVALUE3.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_configvalue3_Sortedstatus',ctrl:'DDO_XT_CONFIGVALUE3',prop:'SortedStatus'},{av:'AV13XT_ConfigIDTitleFilterData',fld:'vXT_CONFIGIDTITLEFILTERDATA',pic:''},{av:'AV15XT_ConfigKeyTitleFilterData',fld:'vXT_CONFIGKEYTITLEFILTERDATA',pic:''},{av:'AV17XT_ConfigValue1TitleFilterData',fld:'vXT_CONFIGVALUE1TITLEFILTERDATA',pic:''},{av:'AV19XT_ConfigValue2TitleFilterData',fld:'vXT_CONFIGVALUE2TITLEFILTERDATA',pic:''},{av:'AV21XT_ConfigValue3TitleFilterData',fld:'vXT_CONFIGVALUE3TITLEFILTERDATA',pic:''},{av:'AV23XT_ConfigValue4TitleFilterData',fld:'vXT_CONFIGVALUE4TITLEFILTERDATA',pic:''},{av:'AV25XT_ConfigValue5TitleFilterData',fld:'vXT_CONFIGVALUE5TITLEFILTERDATA',pic:''},{av:'edtXT_ConfigID_Titleformat',ctrl:'XT_CONFIGID',prop:'Titleformat'},{av:'edtXT_ConfigID_Title',ctrl:'XT_CONFIGID',prop:'Title'},{av:'edtXT_ConfigKey_Titleformat',ctrl:'XT_CONFIGKEY',prop:'Titleformat'},{av:'edtXT_ConfigKey_Title',ctrl:'XT_CONFIGKEY',prop:'Title'},{av:'edtXT_ConfigValue1_Titleformat',ctrl:'XT_CONFIGVALUE1',prop:'Titleformat'},{av:'edtXT_ConfigValue1_Title',ctrl:'XT_CONFIGVALUE1',prop:'Title'},{av:'edtXT_ConfigValue2_Titleformat',ctrl:'XT_CONFIGVALUE2',prop:'Titleformat'},{av:'edtXT_ConfigValue2_Title',ctrl:'XT_CONFIGVALUE2',prop:'Title'},{av:'edtXT_ConfigValue3_Titleformat',ctrl:'XT_CONFIGVALUE3',prop:'Titleformat'},{av:'edtXT_ConfigValue3_Title',ctrl:'XT_CONFIGVALUE3',prop:'Title'},{av:'edtXT_ConfigValue4_Titleformat',ctrl:'XT_CONFIGVALUE4',prop:'Titleformat'},{av:'edtXT_ConfigValue4_Title',ctrl:'XT_CONFIGVALUE4',prop:'Title'},{av:'edtXT_ConfigValue5_Titleformat',ctrl:'XT_CONFIGVALUE5',prop:'Titleformat'},{av:'edtXT_ConfigValue5_Title',ctrl:'XT_CONFIGVALUE5',prop:'Title'},{av:'AV29GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV30GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV31GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_XT_CONFIGVALUE4.ONOPTIONCLICKED","{handler:'E186Z2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_ConfigIDTitleControlIdToReplace',fld:'vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_ConfigKeyTitleControlIdToReplace',fld:'vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_ConfigValue1TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_ConfigValue2TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_XT_ConfigValue3TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE3TITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_XT_ConfigValue4TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE4TITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_XT_ConfigValue5TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE5TITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_xt_configvalue4_Activeeventkey',ctrl:'DDO_XT_CONFIGVALUE4',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_CONFIGVALUE4.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_configvalue4_Sortedstatus',ctrl:'DDO_XT_CONFIGVALUE4',prop:'SortedStatus'},{av:'AV13XT_ConfigIDTitleFilterData',fld:'vXT_CONFIGIDTITLEFILTERDATA',pic:''},{av:'AV15XT_ConfigKeyTitleFilterData',fld:'vXT_CONFIGKEYTITLEFILTERDATA',pic:''},{av:'AV17XT_ConfigValue1TitleFilterData',fld:'vXT_CONFIGVALUE1TITLEFILTERDATA',pic:''},{av:'AV19XT_ConfigValue2TitleFilterData',fld:'vXT_CONFIGVALUE2TITLEFILTERDATA',pic:''},{av:'AV21XT_ConfigValue3TitleFilterData',fld:'vXT_CONFIGVALUE3TITLEFILTERDATA',pic:''},{av:'AV23XT_ConfigValue4TitleFilterData',fld:'vXT_CONFIGVALUE4TITLEFILTERDATA',pic:''},{av:'AV25XT_ConfigValue5TitleFilterData',fld:'vXT_CONFIGVALUE5TITLEFILTERDATA',pic:''},{av:'edtXT_ConfigID_Titleformat',ctrl:'XT_CONFIGID',prop:'Titleformat'},{av:'edtXT_ConfigID_Title',ctrl:'XT_CONFIGID',prop:'Title'},{av:'edtXT_ConfigKey_Titleformat',ctrl:'XT_CONFIGKEY',prop:'Titleformat'},{av:'edtXT_ConfigKey_Title',ctrl:'XT_CONFIGKEY',prop:'Title'},{av:'edtXT_ConfigValue1_Titleformat',ctrl:'XT_CONFIGVALUE1',prop:'Titleformat'},{av:'edtXT_ConfigValue1_Title',ctrl:'XT_CONFIGVALUE1',prop:'Title'},{av:'edtXT_ConfigValue2_Titleformat',ctrl:'XT_CONFIGVALUE2',prop:'Titleformat'},{av:'edtXT_ConfigValue2_Title',ctrl:'XT_CONFIGVALUE2',prop:'Title'},{av:'edtXT_ConfigValue3_Titleformat',ctrl:'XT_CONFIGVALUE3',prop:'Titleformat'},{av:'edtXT_ConfigValue3_Title',ctrl:'XT_CONFIGVALUE3',prop:'Title'},{av:'edtXT_ConfigValue4_Titleformat',ctrl:'XT_CONFIGVALUE4',prop:'Titleformat'},{av:'edtXT_ConfigValue4_Title',ctrl:'XT_CONFIGVALUE4',prop:'Title'},{av:'edtXT_ConfigValue5_Titleformat',ctrl:'XT_CONFIGVALUE5',prop:'Titleformat'},{av:'edtXT_ConfigValue5_Title',ctrl:'XT_CONFIGVALUE5',prop:'Title'},{av:'AV29GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV30GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV31GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_XT_CONFIGVALUE5.ONOPTIONCLICKED","{handler:'E196Z2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_ConfigIDTitleControlIdToReplace',fld:'vDDO_XT_CONFIGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_ConfigKeyTitleControlIdToReplace',fld:'vDDO_XT_CONFIGKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_ConfigValue1TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE1TITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_ConfigValue2TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE2TITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_XT_ConfigValue3TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE3TITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_XT_ConfigValue4TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE4TITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_XT_ConfigValue5TitleControlIdToReplace',fld:'vDDO_XT_CONFIGVALUE5TITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_xt_configvalue5_Activeeventkey',ctrl:'DDO_XT_CONFIGVALUE5',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_CONFIGVALUE5.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_configvalue5_Sortedstatus',ctrl:'DDO_XT_CONFIGVALUE5',prop:'SortedStatus'},{av:'AV13XT_ConfigIDTitleFilterData',fld:'vXT_CONFIGIDTITLEFILTERDATA',pic:''},{av:'AV15XT_ConfigKeyTitleFilterData',fld:'vXT_CONFIGKEYTITLEFILTERDATA',pic:''},{av:'AV17XT_ConfigValue1TitleFilterData',fld:'vXT_CONFIGVALUE1TITLEFILTERDATA',pic:''},{av:'AV19XT_ConfigValue2TitleFilterData',fld:'vXT_CONFIGVALUE2TITLEFILTERDATA',pic:''},{av:'AV21XT_ConfigValue3TitleFilterData',fld:'vXT_CONFIGVALUE3TITLEFILTERDATA',pic:''},{av:'AV23XT_ConfigValue4TitleFilterData',fld:'vXT_CONFIGVALUE4TITLEFILTERDATA',pic:''},{av:'AV25XT_ConfigValue5TitleFilterData',fld:'vXT_CONFIGVALUE5TITLEFILTERDATA',pic:''},{av:'edtXT_ConfigID_Titleformat',ctrl:'XT_CONFIGID',prop:'Titleformat'},{av:'edtXT_ConfigID_Title',ctrl:'XT_CONFIGID',prop:'Title'},{av:'edtXT_ConfigKey_Titleformat',ctrl:'XT_CONFIGKEY',prop:'Titleformat'},{av:'edtXT_ConfigKey_Title',ctrl:'XT_CONFIGKEY',prop:'Title'},{av:'edtXT_ConfigValue1_Titleformat',ctrl:'XT_CONFIGVALUE1',prop:'Titleformat'},{av:'edtXT_ConfigValue1_Title',ctrl:'XT_CONFIGVALUE1',prop:'Title'},{av:'edtXT_ConfigValue2_Titleformat',ctrl:'XT_CONFIGVALUE2',prop:'Titleformat'},{av:'edtXT_ConfigValue2_Title',ctrl:'XT_CONFIGVALUE2',prop:'Title'},{av:'edtXT_ConfigValue3_Titleformat',ctrl:'XT_CONFIGVALUE3',prop:'Titleformat'},{av:'edtXT_ConfigValue3_Title',ctrl:'XT_CONFIGVALUE3',prop:'Title'},{av:'edtXT_ConfigValue4_Titleformat',ctrl:'XT_CONFIGVALUE4',prop:'Titleformat'},{av:'edtXT_ConfigValue4_Title',ctrl:'XT_CONFIGVALUE4',prop:'Title'},{av:'edtXT_ConfigValue5_Titleformat',ctrl:'XT_CONFIGVALUE5',prop:'Titleformat'},{av:'edtXT_ConfigValue5_Title',ctrl:'XT_CONFIGVALUE5',prop:'Title'},{av:'AV29GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV30GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV31GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E226Z2',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV32Select',fld:'vSELECT',pic:''},{av:'edtavSelect_Tooltiptext',ctrl:'vSELECT',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E236Z2',iparms:[{av:'A195XT_ConfigID',fld:'XT_CONFIGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A196XT_ConfigKey',fld:'XT_CONFIGKEY',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV8InOutXT_ConfigID',fld:'vINOUTXT_CONFIGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV9InOutXT_ConfigKey',fld:'vINOUTXT_CONFIGKEY',pic:''}]}");
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
         wcpOAV9InOutXT_ConfigKey = "";
         Gridpaginationbar_Selectedpage = "";
         Ddo_xt_configid_Activeeventkey = "";
         Ddo_xt_configkey_Activeeventkey = "";
         Ddo_xt_configvalue1_Activeeventkey = "";
         Ddo_xt_configvalue2_Activeeventkey = "";
         Ddo_xt_configvalue3_Activeeventkey = "";
         Ddo_xt_configvalue4_Activeeventkey = "";
         Ddo_xt_configvalue5_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV14ddo_XT_ConfigIDTitleControlIdToReplace = "";
         AV16ddo_XT_ConfigKeyTitleControlIdToReplace = "";
         AV18ddo_XT_ConfigValue1TitleControlIdToReplace = "";
         AV20ddo_XT_ConfigValue2TitleControlIdToReplace = "";
         AV22ddo_XT_ConfigValue3TitleControlIdToReplace = "";
         AV24ddo_XT_ConfigValue4TitleControlIdToReplace = "";
         AV26ddo_XT_ConfigValue5TitleControlIdToReplace = "";
         GXKey = "";
         AV35Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV27DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV13XT_ConfigIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15XT_ConfigKeyTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17XT_ConfigValue1TitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19XT_ConfigValue2TitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21XT_ConfigValue3TitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV23XT_ConfigValue4TitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV25XT_ConfigValue5TitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_xt_configid_Sortedstatus = "";
         Ddo_xt_configkey_Sortedstatus = "";
         Ddo_xt_configvalue1_Sortedstatus = "";
         Ddo_xt_configvalue2_Sortedstatus = "";
         Ddo_xt_configvalue3_Sortedstatus = "";
         Ddo_xt_configvalue4_Sortedstatus = "";
         Ddo_xt_configvalue5_Sortedstatus = "";
         GX_FocusControl = "";
         sPrefix = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV32Select = "";
         A196XT_ConfigKey = "";
         A197XT_ConfigValue1 = "";
         A198XT_ConfigValue2 = "";
         A199XT_ConfigValue3 = "";
         A200XT_ConfigValue4 = "";
         A201XT_ConfigValue5 = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_xt_configid = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_xt_configkey = new GXUserControl();
         ucDdo_xt_configvalue1 = new GXUserControl();
         ucDdo_xt_configvalue2 = new GXUserControl();
         ucDdo_xt_configvalue3 = new GXUserControl();
         ucDdo_xt_configvalue4 = new GXUserControl();
         ucDdo_xt_configvalue5 = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV36Select_GXI = "";
         scmdbuf = "";
         H006Z2_A201XT_ConfigValue5 = new String[] {""} ;
         H006Z2_n201XT_ConfigValue5 = new bool[] {false} ;
         H006Z2_A200XT_ConfigValue4 = new String[] {""} ;
         H006Z2_n200XT_ConfigValue4 = new bool[] {false} ;
         H006Z2_A199XT_ConfigValue3 = new String[] {""} ;
         H006Z2_n199XT_ConfigValue3 = new bool[] {false} ;
         H006Z2_A198XT_ConfigValue2 = new String[] {""} ;
         H006Z2_n198XT_ConfigValue2 = new bool[] {false} ;
         H006Z2_A197XT_ConfigValue1 = new String[] {""} ;
         H006Z2_n197XT_ConfigValue1 = new bool[] {false} ;
         H006Z2_A196XT_ConfigKey = new String[] {""} ;
         H006Z2_n196XT_ConfigKey = new bool[] {false} ;
         H006Z2_A195XT_ConfigID = new long[1] ;
         H006Z3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.xt_configprompt__default(),
            new Object[][] {
                new Object[] {
               H006Z2_A201XT_ConfigValue5, H006Z2_n201XT_ConfigValue5, H006Z2_A200XT_ConfigValue4, H006Z2_n200XT_ConfigValue4, H006Z2_A199XT_ConfigValue3, H006Z2_n199XT_ConfigValue3, H006Z2_A198XT_ConfigValue2, H006Z2_n198XT_ConfigValue2, H006Z2_A197XT_ConfigValue1, H006Z2_n197XT_ConfigValue1,
               H006Z2_A196XT_ConfigKey, H006Z2_n196XT_ConfigKey, H006Z2_A195XT_ConfigID
               }
               , new Object[] {
               H006Z3_AGRID_nRecordCount
               }
            }
         );
         AV35Pgmname = "XT_ConfigPrompt";
         /* GeneXus formulas. */
         AV35Pgmname = "XT_ConfigPrompt";
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
      private short edtXT_ConfigID_Titleformat ;
      private short edtXT_ConfigKey_Titleformat ;
      private short edtXT_ConfigValue1_Titleformat ;
      private short edtXT_ConfigValue2_Titleformat ;
      private short edtXT_ConfigValue3_Titleformat ;
      private short edtXT_ConfigValue4_Titleformat ;
      private short edtXT_ConfigValue5_Titleformat ;
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
      private int edtavDdo_xt_configidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_xt_configkeytitlecontrolidtoreplace_Visible ;
      private int edtavDdo_xt_configvalue1titlecontrolidtoreplace_Visible ;
      private int edtavDdo_xt_configvalue2titlecontrolidtoreplace_Visible ;
      private int edtavDdo_xt_configvalue3titlecontrolidtoreplace_Visible ;
      private int edtavDdo_xt_configvalue4titlecontrolidtoreplace_Visible ;
      private int edtavDdo_xt_configvalue5titlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV28PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavSelect_Enabled ;
      private int edtavSelect_Visible ;
      private long AV8InOutXT_ConfigID ;
      private long wcpOAV8InOutXT_ConfigID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV29GridCurrentPage ;
      private long AV31GridRecordCount ;
      private long AV30GridPageSize ;
      private long A195XT_ConfigID ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_xt_configid_Activeeventkey ;
      private String Ddo_xt_configkey_Activeeventkey ;
      private String Ddo_xt_configvalue1_Activeeventkey ;
      private String Ddo_xt_configvalue2_Activeeventkey ;
      private String Ddo_xt_configvalue3_Activeeventkey ;
      private String Ddo_xt_configvalue4_Activeeventkey ;
      private String Ddo_xt_configvalue5_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_12_idx="0001" ;
      private String GXKey ;
      private String AV35Pgmname ;
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
      private String Ddo_xt_configid_Caption ;
      private String Ddo_xt_configid_Tooltip ;
      private String Ddo_xt_configid_Cls ;
      private String Ddo_xt_configid_Dropdownoptionstype ;
      private String Ddo_xt_configid_Titlecontrolidtoreplace ;
      private String Ddo_xt_configid_Sortedstatus ;
      private String Ddo_xt_configid_Sortasc ;
      private String Ddo_xt_configid_Sortdsc ;
      private String Ddo_xt_configid_Searchbuttontext ;
      private String Ddo_xt_configkey_Caption ;
      private String Ddo_xt_configkey_Tooltip ;
      private String Ddo_xt_configkey_Cls ;
      private String Ddo_xt_configkey_Dropdownoptionstype ;
      private String Ddo_xt_configkey_Titlecontrolidtoreplace ;
      private String Ddo_xt_configkey_Sortedstatus ;
      private String Ddo_xt_configkey_Sortasc ;
      private String Ddo_xt_configkey_Sortdsc ;
      private String Ddo_xt_configkey_Searchbuttontext ;
      private String Ddo_xt_configvalue1_Caption ;
      private String Ddo_xt_configvalue1_Tooltip ;
      private String Ddo_xt_configvalue1_Cls ;
      private String Ddo_xt_configvalue1_Dropdownoptionstype ;
      private String Ddo_xt_configvalue1_Titlecontrolidtoreplace ;
      private String Ddo_xt_configvalue1_Sortedstatus ;
      private String Ddo_xt_configvalue1_Sortasc ;
      private String Ddo_xt_configvalue1_Sortdsc ;
      private String Ddo_xt_configvalue1_Searchbuttontext ;
      private String Ddo_xt_configvalue2_Caption ;
      private String Ddo_xt_configvalue2_Tooltip ;
      private String Ddo_xt_configvalue2_Cls ;
      private String Ddo_xt_configvalue2_Dropdownoptionstype ;
      private String Ddo_xt_configvalue2_Titlecontrolidtoreplace ;
      private String Ddo_xt_configvalue2_Sortedstatus ;
      private String Ddo_xt_configvalue2_Sortasc ;
      private String Ddo_xt_configvalue2_Sortdsc ;
      private String Ddo_xt_configvalue2_Searchbuttontext ;
      private String Ddo_xt_configvalue3_Caption ;
      private String Ddo_xt_configvalue3_Tooltip ;
      private String Ddo_xt_configvalue3_Cls ;
      private String Ddo_xt_configvalue3_Dropdownoptionstype ;
      private String Ddo_xt_configvalue3_Titlecontrolidtoreplace ;
      private String Ddo_xt_configvalue3_Sortedstatus ;
      private String Ddo_xt_configvalue3_Sortasc ;
      private String Ddo_xt_configvalue3_Sortdsc ;
      private String Ddo_xt_configvalue3_Searchbuttontext ;
      private String Ddo_xt_configvalue4_Caption ;
      private String Ddo_xt_configvalue4_Tooltip ;
      private String Ddo_xt_configvalue4_Cls ;
      private String Ddo_xt_configvalue4_Dropdownoptionstype ;
      private String Ddo_xt_configvalue4_Titlecontrolidtoreplace ;
      private String Ddo_xt_configvalue4_Sortedstatus ;
      private String Ddo_xt_configvalue4_Sortasc ;
      private String Ddo_xt_configvalue4_Sortdsc ;
      private String Ddo_xt_configvalue4_Searchbuttontext ;
      private String Ddo_xt_configvalue5_Caption ;
      private String Ddo_xt_configvalue5_Tooltip ;
      private String Ddo_xt_configvalue5_Cls ;
      private String Ddo_xt_configvalue5_Dropdownoptionstype ;
      private String Ddo_xt_configvalue5_Titlecontrolidtoreplace ;
      private String Ddo_xt_configvalue5_Sortedstatus ;
      private String Ddo_xt_configvalue5_Sortasc ;
      private String Ddo_xt_configvalue5_Sortdsc ;
      private String Ddo_xt_configvalue5_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtXT_ConfigID_Title ;
      private String edtXT_ConfigKey_Title ;
      private String edtXT_ConfigValue1_Title ;
      private String edtXT_ConfigValue2_Title ;
      private String edtXT_ConfigValue3_Title ;
      private String edtXT_ConfigValue4_Title ;
      private String edtXT_ConfigValue5_Title ;
      private String subGrid_Header ;
      private String edtavSelect_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_xt_configid_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_xt_configidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_xt_configkey_Internalname ;
      private String edtavDdo_xt_configkeytitlecontrolidtoreplace_Internalname ;
      private String Ddo_xt_configvalue1_Internalname ;
      private String edtavDdo_xt_configvalue1titlecontrolidtoreplace_Internalname ;
      private String Ddo_xt_configvalue2_Internalname ;
      private String edtavDdo_xt_configvalue2titlecontrolidtoreplace_Internalname ;
      private String Ddo_xt_configvalue3_Internalname ;
      private String edtavDdo_xt_configvalue3titlecontrolidtoreplace_Internalname ;
      private String Ddo_xt_configvalue4_Internalname ;
      private String edtavDdo_xt_configvalue4titlecontrolidtoreplace_Internalname ;
      private String Ddo_xt_configvalue5_Internalname ;
      private String edtavDdo_xt_configvalue5titlecontrolidtoreplace_Internalname ;
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
      private String edtXT_ConfigID_Internalname ;
      private String edtXT_ConfigKey_Internalname ;
      private String edtXT_ConfigValue1_Internalname ;
      private String edtXT_ConfigValue2_Internalname ;
      private String edtXT_ConfigValue3_Internalname ;
      private String edtXT_ConfigValue4_Internalname ;
      private String edtXT_ConfigValue5_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_12_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavSelect_Jsonclick ;
      private String ROClassString ;
      private String edtXT_ConfigID_Jsonclick ;
      private String edtXT_ConfigKey_Jsonclick ;
      private String edtXT_ConfigValue1_Jsonclick ;
      private String edtXT_ConfigValue2_Jsonclick ;
      private String edtXT_ConfigValue3_Jsonclick ;
      private String edtXT_ConfigValue4_Jsonclick ;
      private String edtXT_ConfigValue5_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV12OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_xt_configid_Includesortasc ;
      private bool Ddo_xt_configid_Includesortdsc ;
      private bool Ddo_xt_configid_Includefilter ;
      private bool Ddo_xt_configid_Includedatalist ;
      private bool Ddo_xt_configkey_Includesortasc ;
      private bool Ddo_xt_configkey_Includesortdsc ;
      private bool Ddo_xt_configkey_Includefilter ;
      private bool Ddo_xt_configkey_Includedatalist ;
      private bool Ddo_xt_configvalue1_Includesortasc ;
      private bool Ddo_xt_configvalue1_Includesortdsc ;
      private bool Ddo_xt_configvalue1_Includefilter ;
      private bool Ddo_xt_configvalue1_Includedatalist ;
      private bool Ddo_xt_configvalue2_Includesortasc ;
      private bool Ddo_xt_configvalue2_Includesortdsc ;
      private bool Ddo_xt_configvalue2_Includefilter ;
      private bool Ddo_xt_configvalue2_Includedatalist ;
      private bool Ddo_xt_configvalue3_Includesortasc ;
      private bool Ddo_xt_configvalue3_Includesortdsc ;
      private bool Ddo_xt_configvalue3_Includefilter ;
      private bool Ddo_xt_configvalue3_Includedatalist ;
      private bool Ddo_xt_configvalue4_Includesortasc ;
      private bool Ddo_xt_configvalue4_Includesortdsc ;
      private bool Ddo_xt_configvalue4_Includefilter ;
      private bool Ddo_xt_configvalue4_Includedatalist ;
      private bool Ddo_xt_configvalue5_Includesortasc ;
      private bool Ddo_xt_configvalue5_Includesortdsc ;
      private bool Ddo_xt_configvalue5_Includefilter ;
      private bool Ddo_xt_configvalue5_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_12_Refreshing=false ;
      private bool n196XT_ConfigKey ;
      private bool n197XT_ConfigValue1 ;
      private bool n198XT_ConfigValue2 ;
      private bool n199XT_ConfigValue3 ;
      private bool n200XT_ConfigValue4 ;
      private bool n201XT_ConfigValue5 ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool gx_refresh_fired ;
      private bool AV32Select_IsBlob ;
      private String AV9InOutXT_ConfigKey ;
      private String wcpOAV9InOutXT_ConfigKey ;
      private String AV14ddo_XT_ConfigIDTitleControlIdToReplace ;
      private String AV16ddo_XT_ConfigKeyTitleControlIdToReplace ;
      private String AV18ddo_XT_ConfigValue1TitleControlIdToReplace ;
      private String AV20ddo_XT_ConfigValue2TitleControlIdToReplace ;
      private String AV22ddo_XT_ConfigValue3TitleControlIdToReplace ;
      private String AV24ddo_XT_ConfigValue4TitleControlIdToReplace ;
      private String AV26ddo_XT_ConfigValue5TitleControlIdToReplace ;
      private String A196XT_ConfigKey ;
      private String A197XT_ConfigValue1 ;
      private String A198XT_ConfigValue2 ;
      private String A199XT_ConfigValue3 ;
      private String A200XT_ConfigValue4 ;
      private String A201XT_ConfigValue5 ;
      private String AV36Select_GXI ;
      private String AV32Select ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_xt_configid ;
      private GXUserControl ucDdo_xt_configkey ;
      private GXUserControl ucDdo_xt_configvalue1 ;
      private GXUserControl ucDdo_xt_configvalue2 ;
      private GXUserControl ucDdo_xt_configvalue3 ;
      private GXUserControl ucDdo_xt_configvalue4 ;
      private GXUserControl ucDdo_xt_configvalue5 ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private long aP0_InOutXT_ConfigID ;
      private String aP1_InOutXT_ConfigKey ;
      private IDataStoreProvider pr_default ;
      private String[] H006Z2_A201XT_ConfigValue5 ;
      private bool[] H006Z2_n201XT_ConfigValue5 ;
      private String[] H006Z2_A200XT_ConfigValue4 ;
      private bool[] H006Z2_n200XT_ConfigValue4 ;
      private String[] H006Z2_A199XT_ConfigValue3 ;
      private bool[] H006Z2_n199XT_ConfigValue3 ;
      private String[] H006Z2_A198XT_ConfigValue2 ;
      private bool[] H006Z2_n198XT_ConfigValue2 ;
      private String[] H006Z2_A197XT_ConfigValue1 ;
      private bool[] H006Z2_n197XT_ConfigValue1 ;
      private String[] H006Z2_A196XT_ConfigKey ;
      private bool[] H006Z2_n196XT_ConfigKey ;
      private long[] H006Z2_A195XT_ConfigID ;
      private long[] H006Z3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV13XT_ConfigIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV15XT_ConfigKeyTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV17XT_ConfigValue1TitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV19XT_ConfigValue2TitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV21XT_ConfigValue3TitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV23XT_ConfigValue4TitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV25XT_ConfigValue5TitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV27DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class xt_configprompt__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H006Z2( IGxContext context ,
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
         sSelectString = " [XT_ConfigValue5], [XT_ConfigValue4], [XT_ConfigValue3], [XT_ConfigValue2], [XT_ConfigValue1], [XT_ConfigKey], [XT_ConfigID]";
         sFromString = " FROM [XT_Config] WITH (NOLOCK)";
         sOrderString = "";
         if ( ( AV11OrderedBy == 1 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [XT_ConfigID]";
         }
         else if ( ( AV11OrderedBy == 1 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [XT_ConfigID] DESC";
         }
         else if ( ( AV11OrderedBy == 2 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [XT_ConfigKey]";
         }
         else if ( ( AV11OrderedBy == 2 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [XT_ConfigKey] DESC";
         }
         else if ( ( AV11OrderedBy == 3 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [XT_ConfigValue1]";
         }
         else if ( ( AV11OrderedBy == 3 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [XT_ConfigValue1] DESC";
         }
         else if ( ( AV11OrderedBy == 4 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [XT_ConfigValue2]";
         }
         else if ( ( AV11OrderedBy == 4 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [XT_ConfigValue2] DESC";
         }
         else if ( ( AV11OrderedBy == 5 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [XT_ConfigValue3]";
         }
         else if ( ( AV11OrderedBy == 5 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [XT_ConfigValue3] DESC";
         }
         else if ( ( AV11OrderedBy == 6 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [XT_ConfigValue4]";
         }
         else if ( ( AV11OrderedBy == 6 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [XT_ConfigValue4] DESC";
         }
         else if ( ( AV11OrderedBy == 7 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [XT_ConfigValue5]";
         }
         else if ( ( AV11OrderedBy == 7 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [XT_ConfigValue5] DESC";
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

      protected Object[] conditional_H006Z3( IGxContext context ,
                                             short AV11OrderedBy ,
                                             bool AV12OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [XT_Config] WITH (NOLOCK)";
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
         else if ( ( AV11OrderedBy == 5 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 5 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 6 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 6 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 7 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 7 ) && ( AV12OrderedDsc ) )
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
                     return conditional_H006Z2(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
               case 1 :
                     return conditional_H006Z3(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
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
          Object[] prmH006Z2 ;
          prmH006Z2 = new Object[] {
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH006Z3 ;
          prmH006Z3 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H006Z2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH006Z2,11,0,true,false )
             ,new CursorDef("H006Z3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH006Z3,1,0,true,false )
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
                ((long[]) buf[12])[0] = rslt.getLong(7) ;
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
