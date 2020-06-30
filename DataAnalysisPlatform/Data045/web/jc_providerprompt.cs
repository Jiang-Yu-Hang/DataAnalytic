/*
               File: JC_ProviderPrompt
        Description: 选择医院
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:16:43.20
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
   public class jc_providerprompt : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public jc_providerprompt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public jc_providerprompt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_InOutJC_ProviderID ,
                           ref String aP1_InOutJC_ProviderName )
      {
         this.AV8InOutJC_ProviderID = aP0_InOutJC_ProviderID;
         this.AV9InOutJC_ProviderName = aP1_InOutJC_ProviderName;
         executePrivate();
         aP0_InOutJC_ProviderID=this.AV8InOutJC_ProviderID;
         aP1_InOutJC_ProviderName=this.AV9InOutJC_ProviderName;
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
               AV14ddo_JC_ProviderIDTitleControlIdToReplace = GetNextPar( );
               AV16ddo_JC_ProviderNameTitleControlIdToReplace = GetNextPar( );
               AV18ddo_JC_ProviderShortNameTitleControlIdToReplace = GetNextPar( );
               AV20ddo_JC_ProviderAddresssTitleControlIdToReplace = GetNextPar( );
               AV22ddo_JC_ProviderPhoneTitleControlIdToReplace = GetNextPar( );
               AV24ddo_JC_ProviderUserTitleControlIdToReplace = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_JC_ProviderIDTitleControlIdToReplace, AV16ddo_JC_ProviderNameTitleControlIdToReplace, AV18ddo_JC_ProviderShortNameTitleControlIdToReplace, AV20ddo_JC_ProviderAddresssTitleControlIdToReplace, AV22ddo_JC_ProviderPhoneTitleControlIdToReplace, AV24ddo_JC_ProviderUserTitleControlIdToReplace) ;
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
               AV8InOutJC_ProviderID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutJC_ProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutJC_ProviderID), 18, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV9InOutJC_ProviderName = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutJC_ProviderName", AV9InOutJC_ProviderName);
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
            PA8J2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV33Pgmname = "JC_ProviderPrompt";
               context.Gx_err = 0;
               WS8J2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE8J2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022815164331", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("jc_providerprompt.aspx") + "?" + UrlEncode("" +AV8InOutJC_ProviderID) + "," + UrlEncode(StringUtil.RTrim(AV9InOutJC_ProviderName))+"\">") ;
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vJC_PROVIDERIDTITLEFILTERDATA", AV13JC_ProviderIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vJC_PROVIDERIDTITLEFILTERDATA", AV13JC_ProviderIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vJC_PROVIDERNAMETITLEFILTERDATA", AV15JC_ProviderNameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vJC_PROVIDERNAMETITLEFILTERDATA", AV15JC_ProviderNameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vJC_PROVIDERSHORTNAMETITLEFILTERDATA", AV17JC_ProviderShortNameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vJC_PROVIDERSHORTNAMETITLEFILTERDATA", AV17JC_ProviderShortNameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vJC_PROVIDERADDRESSSTITLEFILTERDATA", AV19JC_ProviderAddresssTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vJC_PROVIDERADDRESSSTITLEFILTERDATA", AV19JC_ProviderAddresssTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vJC_PROVIDERPHONETITLEFILTERDATA", AV21JC_ProviderPhoneTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vJC_PROVIDERPHONETITLEFILTERDATA", AV21JC_ProviderPhoneTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vJC_PROVIDERUSERTITLEFILTERDATA", AV23JC_ProviderUserTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vJC_PROVIDERUSERTITLEFILTERDATA", AV23JC_ProviderUserTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vINOUTJC_PROVIDERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8InOutJC_ProviderID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINOUTJC_PROVIDERNAME", AV9InOutJC_ProviderName);
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
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Caption", StringUtil.RTrim( Ddo_jc_providerid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Tooltip", StringUtil.RTrim( Ddo_jc_providerid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Cls", StringUtil.RTrim( Ddo_jc_providerid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Dropdownoptionstype", StringUtil.RTrim( Ddo_jc_providerid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_jc_providerid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Includesortasc", StringUtil.BoolToStr( Ddo_jc_providerid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Includesortdsc", StringUtil.BoolToStr( Ddo_jc_providerid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Sortedstatus", StringUtil.RTrim( Ddo_jc_providerid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Includefilter", StringUtil.BoolToStr( Ddo_jc_providerid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Includedatalist", StringUtil.BoolToStr( Ddo_jc_providerid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Sortasc", StringUtil.RTrim( Ddo_jc_providerid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Sortdsc", StringUtil.RTrim( Ddo_jc_providerid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Searchbuttontext", StringUtil.RTrim( Ddo_jc_providerid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Caption", StringUtil.RTrim( Ddo_jc_providername_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Tooltip", StringUtil.RTrim( Ddo_jc_providername_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Cls", StringUtil.RTrim( Ddo_jc_providername_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_jc_providername_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_jc_providername_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Includesortasc", StringUtil.BoolToStr( Ddo_jc_providername_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Includesortdsc", StringUtil.BoolToStr( Ddo_jc_providername_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Sortedstatus", StringUtil.RTrim( Ddo_jc_providername_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Includefilter", StringUtil.BoolToStr( Ddo_jc_providername_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Includedatalist", StringUtil.BoolToStr( Ddo_jc_providername_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Sortasc", StringUtil.RTrim( Ddo_jc_providername_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Sortdsc", StringUtil.RTrim( Ddo_jc_providername_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Searchbuttontext", StringUtil.RTrim( Ddo_jc_providername_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Caption", StringUtil.RTrim( Ddo_jc_providershortname_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Tooltip", StringUtil.RTrim( Ddo_jc_providershortname_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Cls", StringUtil.RTrim( Ddo_jc_providershortname_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_jc_providershortname_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_jc_providershortname_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Includesortasc", StringUtil.BoolToStr( Ddo_jc_providershortname_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Includesortdsc", StringUtil.BoolToStr( Ddo_jc_providershortname_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Sortedstatus", StringUtil.RTrim( Ddo_jc_providershortname_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Includefilter", StringUtil.BoolToStr( Ddo_jc_providershortname_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Includedatalist", StringUtil.BoolToStr( Ddo_jc_providershortname_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Sortasc", StringUtil.RTrim( Ddo_jc_providershortname_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Sortdsc", StringUtil.RTrim( Ddo_jc_providershortname_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Searchbuttontext", StringUtil.RTrim( Ddo_jc_providershortname_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Caption", StringUtil.RTrim( Ddo_jc_provideraddresss_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Tooltip", StringUtil.RTrim( Ddo_jc_provideraddresss_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Cls", StringUtil.RTrim( Ddo_jc_provideraddresss_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Dropdownoptionstype", StringUtil.RTrim( Ddo_jc_provideraddresss_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_jc_provideraddresss_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Includesortasc", StringUtil.BoolToStr( Ddo_jc_provideraddresss_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Includesortdsc", StringUtil.BoolToStr( Ddo_jc_provideraddresss_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Sortedstatus", StringUtil.RTrim( Ddo_jc_provideraddresss_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Includefilter", StringUtil.BoolToStr( Ddo_jc_provideraddresss_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Includedatalist", StringUtil.BoolToStr( Ddo_jc_provideraddresss_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Sortasc", StringUtil.RTrim( Ddo_jc_provideraddresss_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Sortdsc", StringUtil.RTrim( Ddo_jc_provideraddresss_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Searchbuttontext", StringUtil.RTrim( Ddo_jc_provideraddresss_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Caption", StringUtil.RTrim( Ddo_jc_providerphone_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Tooltip", StringUtil.RTrim( Ddo_jc_providerphone_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Cls", StringUtil.RTrim( Ddo_jc_providerphone_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Dropdownoptionstype", StringUtil.RTrim( Ddo_jc_providerphone_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_jc_providerphone_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Includesortasc", StringUtil.BoolToStr( Ddo_jc_providerphone_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Includesortdsc", StringUtil.BoolToStr( Ddo_jc_providerphone_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Sortedstatus", StringUtil.RTrim( Ddo_jc_providerphone_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Includefilter", StringUtil.BoolToStr( Ddo_jc_providerphone_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Includedatalist", StringUtil.BoolToStr( Ddo_jc_providerphone_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Sortasc", StringUtil.RTrim( Ddo_jc_providerphone_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Sortdsc", StringUtil.RTrim( Ddo_jc_providerphone_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Searchbuttontext", StringUtil.RTrim( Ddo_jc_providerphone_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Caption", StringUtil.RTrim( Ddo_jc_provideruser_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Tooltip", StringUtil.RTrim( Ddo_jc_provideruser_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Cls", StringUtil.RTrim( Ddo_jc_provideruser_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Dropdownoptionstype", StringUtil.RTrim( Ddo_jc_provideruser_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_jc_provideruser_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Includesortasc", StringUtil.BoolToStr( Ddo_jc_provideruser_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Includesortdsc", StringUtil.BoolToStr( Ddo_jc_provideruser_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Sortedstatus", StringUtil.RTrim( Ddo_jc_provideruser_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Includefilter", StringUtil.BoolToStr( Ddo_jc_provideruser_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Includedatalist", StringUtil.BoolToStr( Ddo_jc_provideruser_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Sortasc", StringUtil.RTrim( Ddo_jc_provideruser_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Sortdsc", StringUtil.RTrim( Ddo_jc_provideruser_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Searchbuttontext", StringUtil.RTrim( Ddo_jc_provideruser_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Activeeventkey", StringUtil.RTrim( Ddo_jc_providerid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Activeeventkey", StringUtil.RTrim( Ddo_jc_providername_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Activeeventkey", StringUtil.RTrim( Ddo_jc_providershortname_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Activeeventkey", StringUtil.RTrim( Ddo_jc_provideraddresss_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Activeeventkey", StringUtil.RTrim( Ddo_jc_providerphone_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Activeeventkey", StringUtil.RTrim( Ddo_jc_provideruser_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Activeeventkey", StringUtil.RTrim( Ddo_jc_providerid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Activeeventkey", StringUtil.RTrim( Ddo_jc_providername_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Activeeventkey", StringUtil.RTrim( Ddo_jc_providershortname_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Activeeventkey", StringUtil.RTrim( Ddo_jc_provideraddresss_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Activeeventkey", StringUtil.RTrim( Ddo_jc_providerphone_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Activeeventkey", StringUtil.RTrim( Ddo_jc_provideruser_Activeeventkey));
      }

      protected void RenderHtmlCloseForm8J2( )
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
         return "JC_ProviderPrompt" ;
      }

      public override String GetPgmdesc( )
      {
         return "选择医院" ;
      }

      protected void WB8J0( )
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
               if ( edtJC_ProviderID_Titleformat == 0 )
               {
                  context.SendWebValue( edtJC_ProviderID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtJC_ProviderID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(410), 4, 0))+"px"+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtJC_ProviderName_Titleformat == 0 )
               {
                  context.SendWebValue( edtJC_ProviderName_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtJC_ProviderName_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtJC_ProviderShortName_Titleformat == 0 )
               {
                  context.SendWebValue( edtJC_ProviderShortName_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtJC_ProviderShortName_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(410), 4, 0))+"px"+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtJC_ProviderAddresss_Titleformat == 0 )
               {
                  context.SendWebValue( edtJC_ProviderAddresss_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtJC_ProviderAddresss_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtJC_ProviderPhone_Titleformat == 0 )
               {
                  context.SendWebValue( edtJC_ProviderPhone_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtJC_ProviderPhone_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtJC_ProviderUser_Titleformat == 0 )
               {
                  context.SendWebValue( edtJC_ProviderUser_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtJC_ProviderUser_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV30Select));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavSelect_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A87JC_ProviderID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtJC_ProviderID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtJC_ProviderID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A89JC_ProviderName);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtJC_ProviderName_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtJC_ProviderName_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A160JC_ProviderShortName);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtJC_ProviderShortName_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtJC_ProviderShortName_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A161JC_ProviderAddresss);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtJC_ProviderAddresss_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtJC_ProviderAddresss_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.RTrim( A162JC_ProviderPhone));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtJC_ProviderPhone_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtJC_ProviderPhone_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A163JC_ProviderUser);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtJC_ProviderUser_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtJC_ProviderUser_Titleformat), 4, 0, ".", "")));
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
            ucDdo_jc_providerid.SetProperty("Caption", Ddo_jc_providerid_Caption);
            ucDdo_jc_providerid.SetProperty("Tooltip", Ddo_jc_providerid_Tooltip);
            ucDdo_jc_providerid.SetProperty("Cls", Ddo_jc_providerid_Cls);
            ucDdo_jc_providerid.SetProperty("DropDownOptionsType", Ddo_jc_providerid_Dropdownoptionstype);
            ucDdo_jc_providerid.SetProperty("IncludeSortASC", Ddo_jc_providerid_Includesortasc);
            ucDdo_jc_providerid.SetProperty("IncludeSortDSC", Ddo_jc_providerid_Includesortdsc);
            ucDdo_jc_providerid.SetProperty("IncludeFilter", Ddo_jc_providerid_Includefilter);
            ucDdo_jc_providerid.SetProperty("IncludeDataList", Ddo_jc_providerid_Includedatalist);
            ucDdo_jc_providerid.SetProperty("SortASC", Ddo_jc_providerid_Sortasc);
            ucDdo_jc_providerid.SetProperty("SortDSC", Ddo_jc_providerid_Sortdsc);
            ucDdo_jc_providerid.SetProperty("SearchButtonText", Ddo_jc_providerid_Searchbuttontext);
            ucDdo_jc_providerid.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_jc_providerid.SetProperty("DropDownOptionsData", AV13JC_ProviderIDTitleFilterData);
            ucDdo_jc_providerid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_jc_providerid_Internalname, "DDO_JC_PROVIDERIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_jc_provideridtitlecontrolidtoreplace_Internalname, AV14ddo_JC_ProviderIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,28);\"", 0, edtavDdo_jc_provideridtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_JC_ProviderPrompt.htm");
            /* User Defined Control */
            ucDdo_jc_providername.SetProperty("Caption", Ddo_jc_providername_Caption);
            ucDdo_jc_providername.SetProperty("Tooltip", Ddo_jc_providername_Tooltip);
            ucDdo_jc_providername.SetProperty("Cls", Ddo_jc_providername_Cls);
            ucDdo_jc_providername.SetProperty("DropDownOptionsType", Ddo_jc_providername_Dropdownoptionstype);
            ucDdo_jc_providername.SetProperty("IncludeSortASC", Ddo_jc_providername_Includesortasc);
            ucDdo_jc_providername.SetProperty("IncludeSortDSC", Ddo_jc_providername_Includesortdsc);
            ucDdo_jc_providername.SetProperty("IncludeFilter", Ddo_jc_providername_Includefilter);
            ucDdo_jc_providername.SetProperty("IncludeDataList", Ddo_jc_providername_Includedatalist);
            ucDdo_jc_providername.SetProperty("SortASC", Ddo_jc_providername_Sortasc);
            ucDdo_jc_providername.SetProperty("SortDSC", Ddo_jc_providername_Sortdsc);
            ucDdo_jc_providername.SetProperty("SearchButtonText", Ddo_jc_providername_Searchbuttontext);
            ucDdo_jc_providername.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_jc_providername.SetProperty("DropDownOptionsData", AV15JC_ProviderNameTitleFilterData);
            ucDdo_jc_providername.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_jc_providername_Internalname, "DDO_JC_PROVIDERNAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_jc_providernametitlecontrolidtoreplace_Internalname, AV16ddo_JC_ProviderNameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,30);\"", 0, edtavDdo_jc_providernametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_JC_ProviderPrompt.htm");
            /* User Defined Control */
            ucDdo_jc_providershortname.SetProperty("Caption", Ddo_jc_providershortname_Caption);
            ucDdo_jc_providershortname.SetProperty("Tooltip", Ddo_jc_providershortname_Tooltip);
            ucDdo_jc_providershortname.SetProperty("Cls", Ddo_jc_providershortname_Cls);
            ucDdo_jc_providershortname.SetProperty("DropDownOptionsType", Ddo_jc_providershortname_Dropdownoptionstype);
            ucDdo_jc_providershortname.SetProperty("IncludeSortASC", Ddo_jc_providershortname_Includesortasc);
            ucDdo_jc_providershortname.SetProperty("IncludeSortDSC", Ddo_jc_providershortname_Includesortdsc);
            ucDdo_jc_providershortname.SetProperty("IncludeFilter", Ddo_jc_providershortname_Includefilter);
            ucDdo_jc_providershortname.SetProperty("IncludeDataList", Ddo_jc_providershortname_Includedatalist);
            ucDdo_jc_providershortname.SetProperty("SortASC", Ddo_jc_providershortname_Sortasc);
            ucDdo_jc_providershortname.SetProperty("SortDSC", Ddo_jc_providershortname_Sortdsc);
            ucDdo_jc_providershortname.SetProperty("SearchButtonText", Ddo_jc_providershortname_Searchbuttontext);
            ucDdo_jc_providershortname.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_jc_providershortname.SetProperty("DropDownOptionsData", AV17JC_ProviderShortNameTitleFilterData);
            ucDdo_jc_providershortname.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_jc_providershortname_Internalname, "DDO_JC_PROVIDERSHORTNAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_jc_providershortnametitlecontrolidtoreplace_Internalname, AV18ddo_JC_ProviderShortNameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,32);\"", 0, edtavDdo_jc_providershortnametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_JC_ProviderPrompt.htm");
            /* User Defined Control */
            ucDdo_jc_provideraddresss.SetProperty("Caption", Ddo_jc_provideraddresss_Caption);
            ucDdo_jc_provideraddresss.SetProperty("Tooltip", Ddo_jc_provideraddresss_Tooltip);
            ucDdo_jc_provideraddresss.SetProperty("Cls", Ddo_jc_provideraddresss_Cls);
            ucDdo_jc_provideraddresss.SetProperty("DropDownOptionsType", Ddo_jc_provideraddresss_Dropdownoptionstype);
            ucDdo_jc_provideraddresss.SetProperty("IncludeSortASC", Ddo_jc_provideraddresss_Includesortasc);
            ucDdo_jc_provideraddresss.SetProperty("IncludeSortDSC", Ddo_jc_provideraddresss_Includesortdsc);
            ucDdo_jc_provideraddresss.SetProperty("IncludeFilter", Ddo_jc_provideraddresss_Includefilter);
            ucDdo_jc_provideraddresss.SetProperty("IncludeDataList", Ddo_jc_provideraddresss_Includedatalist);
            ucDdo_jc_provideraddresss.SetProperty("SortASC", Ddo_jc_provideraddresss_Sortasc);
            ucDdo_jc_provideraddresss.SetProperty("SortDSC", Ddo_jc_provideraddresss_Sortdsc);
            ucDdo_jc_provideraddresss.SetProperty("SearchButtonText", Ddo_jc_provideraddresss_Searchbuttontext);
            ucDdo_jc_provideraddresss.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_jc_provideraddresss.SetProperty("DropDownOptionsData", AV19JC_ProviderAddresssTitleFilterData);
            ucDdo_jc_provideraddresss.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_jc_provideraddresss_Internalname, "DDO_JC_PROVIDERADDRESSSContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_jc_provideraddressstitlecontrolidtoreplace_Internalname, AV20ddo_JC_ProviderAddresssTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", 0, edtavDdo_jc_provideraddressstitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_JC_ProviderPrompt.htm");
            /* User Defined Control */
            ucDdo_jc_providerphone.SetProperty("Caption", Ddo_jc_providerphone_Caption);
            ucDdo_jc_providerphone.SetProperty("Tooltip", Ddo_jc_providerphone_Tooltip);
            ucDdo_jc_providerphone.SetProperty("Cls", Ddo_jc_providerphone_Cls);
            ucDdo_jc_providerphone.SetProperty("DropDownOptionsType", Ddo_jc_providerphone_Dropdownoptionstype);
            ucDdo_jc_providerphone.SetProperty("IncludeSortASC", Ddo_jc_providerphone_Includesortasc);
            ucDdo_jc_providerphone.SetProperty("IncludeSortDSC", Ddo_jc_providerphone_Includesortdsc);
            ucDdo_jc_providerphone.SetProperty("IncludeFilter", Ddo_jc_providerphone_Includefilter);
            ucDdo_jc_providerphone.SetProperty("IncludeDataList", Ddo_jc_providerphone_Includedatalist);
            ucDdo_jc_providerphone.SetProperty("SortASC", Ddo_jc_providerphone_Sortasc);
            ucDdo_jc_providerphone.SetProperty("SortDSC", Ddo_jc_providerphone_Sortdsc);
            ucDdo_jc_providerphone.SetProperty("SearchButtonText", Ddo_jc_providerphone_Searchbuttontext);
            ucDdo_jc_providerphone.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_jc_providerphone.SetProperty("DropDownOptionsData", AV21JC_ProviderPhoneTitleFilterData);
            ucDdo_jc_providerphone.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_jc_providerphone_Internalname, "DDO_JC_PROVIDERPHONEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_jc_providerphonetitlecontrolidtoreplace_Internalname, AV22ddo_JC_ProviderPhoneTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,36);\"", 0, edtavDdo_jc_providerphonetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_JC_ProviderPrompt.htm");
            /* User Defined Control */
            ucDdo_jc_provideruser.SetProperty("Caption", Ddo_jc_provideruser_Caption);
            ucDdo_jc_provideruser.SetProperty("Tooltip", Ddo_jc_provideruser_Tooltip);
            ucDdo_jc_provideruser.SetProperty("Cls", Ddo_jc_provideruser_Cls);
            ucDdo_jc_provideruser.SetProperty("DropDownOptionsType", Ddo_jc_provideruser_Dropdownoptionstype);
            ucDdo_jc_provideruser.SetProperty("IncludeSortASC", Ddo_jc_provideruser_Includesortasc);
            ucDdo_jc_provideruser.SetProperty("IncludeSortDSC", Ddo_jc_provideruser_Includesortdsc);
            ucDdo_jc_provideruser.SetProperty("IncludeFilter", Ddo_jc_provideruser_Includefilter);
            ucDdo_jc_provideruser.SetProperty("IncludeDataList", Ddo_jc_provideruser_Includedatalist);
            ucDdo_jc_provideruser.SetProperty("SortASC", Ddo_jc_provideruser_Sortasc);
            ucDdo_jc_provideruser.SetProperty("SortDSC", Ddo_jc_provideruser_Sortdsc);
            ucDdo_jc_provideruser.SetProperty("SearchButtonText", Ddo_jc_provideruser_Searchbuttontext);
            ucDdo_jc_provideruser.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_jc_provideruser.SetProperty("DropDownOptionsData", AV23JC_ProviderUserTitleFilterData);
            ucDdo_jc_provideruser.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_jc_provideruser_Internalname, "DDO_JC_PROVIDERUSERContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_jc_providerusertitlecontrolidtoreplace_Internalname, AV24ddo_JC_ProviderUserTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", 0, edtavDdo_jc_providerusertitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_JC_ProviderPrompt.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,40);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_JC_ProviderPrompt.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV12OrderedDsc), StringUtil.BoolToStr( AV12OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,41);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_JC_ProviderPrompt.htm");
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

      protected void START8J2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "选择医院", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP8J0( ) ;
      }

      protected void WS8J2( )
      {
         START8J2( ) ;
         EVT8J2( ) ;
      }

      protected void EVT8J2( )
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
                           E118J2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E128J2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_JC_PROVIDERID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E138J2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_JC_PROVIDERNAME.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E148J2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_JC_PROVIDERSHORTNAME.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E158J2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_JC_PROVIDERADDRESSS.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E168J2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_JC_PROVIDERPHONE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E178J2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_JC_PROVIDERUSER.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E188J2 ();
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
                           AV30Select = cgiGet( edtavSelect_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV30Select)) ? AV34Select_GXI : context.convertURL( context.PathToRelativeUrl( AV30Select))), !bGXsfl_12_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "SrcSet", context.GetImageSrcSet( AV30Select), true);
                           A87JC_ProviderID = (long)(context.localUtil.CToN( cgiGet( edtJC_ProviderID_Internalname), ".", ","));
                           A89JC_ProviderName = cgiGet( edtJC_ProviderName_Internalname);
                           n89JC_ProviderName = false;
                           A160JC_ProviderShortName = cgiGet( edtJC_ProviderShortName_Internalname);
                           n160JC_ProviderShortName = false;
                           A161JC_ProviderAddresss = cgiGet( edtJC_ProviderAddresss_Internalname);
                           n161JC_ProviderAddresss = false;
                           A162JC_ProviderPhone = cgiGet( edtJC_ProviderPhone_Internalname);
                           n162JC_ProviderPhone = false;
                           A163JC_ProviderUser = cgiGet( edtJC_ProviderUser_Internalname);
                           n163JC_ProviderUser = false;
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E198J2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E208J2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E218J2 ();
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
                                       E228J2 ();
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

      protected void WE8J2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm8J2( ) ;
            }
         }
      }

      protected void PA8J2( )
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
               GX_FocusControl = edtavDdo_jc_provideridtitlecontrolidtoreplace_Internalname;
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
                                       String AV14ddo_JC_ProviderIDTitleControlIdToReplace ,
                                       String AV16ddo_JC_ProviderNameTitleControlIdToReplace ,
                                       String AV18ddo_JC_ProviderShortNameTitleControlIdToReplace ,
                                       String AV20ddo_JC_ProviderAddresssTitleControlIdToReplace ,
                                       String AV22ddo_JC_ProviderPhoneTitleControlIdToReplace ,
                                       String AV24ddo_JC_ProviderUserTitleControlIdToReplace )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF8J2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_JC_PROVIDERADDRESSS", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A161JC_ProviderAddresss, "")), context));
         GxWebStd.gx_hidden_field( context, "JC_PROVIDERADDRESSS", A161JC_ProviderAddresss);
         GxWebStd.gx_hidden_field( context, "gxhash_JC_PROVIDERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A87JC_ProviderID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "JC_PROVIDERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A87JC_ProviderID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_JC_PROVIDERNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A89JC_ProviderName, "")), context));
         GxWebStd.gx_hidden_field( context, "JC_PROVIDERNAME", A89JC_ProviderName);
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
         RF8J2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV33Pgmname = "JC_ProviderPrompt";
         context.Gx_err = 0;
      }

      protected void RF8J2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 12;
         /* Execute user event: Refresh */
         E208J2 ();
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
            /* Using cursor H008J2 */
            pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_12_idx = 1;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A163JC_ProviderUser = H008J2_A163JC_ProviderUser[0];
               n163JC_ProviderUser = H008J2_n163JC_ProviderUser[0];
               A162JC_ProviderPhone = H008J2_A162JC_ProviderPhone[0];
               n162JC_ProviderPhone = H008J2_n162JC_ProviderPhone[0];
               A161JC_ProviderAddresss = H008J2_A161JC_ProviderAddresss[0];
               n161JC_ProviderAddresss = H008J2_n161JC_ProviderAddresss[0];
               A160JC_ProviderShortName = H008J2_A160JC_ProviderShortName[0];
               n160JC_ProviderShortName = H008J2_n160JC_ProviderShortName[0];
               A89JC_ProviderName = H008J2_A89JC_ProviderName[0];
               n89JC_ProviderName = H008J2_n89JC_ProviderName[0];
               A87JC_ProviderID = H008J2_A87JC_ProviderID[0];
               E218J2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 12;
            WB8J0( ) ;
         }
         bGXsfl_12_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes8J2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_JC_PROVIDERADDRESSS"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, StringUtil.RTrim( context.localUtil.Format( A161JC_ProviderAddresss, "")), context));
         GxWebStd.gx_hidden_field( context, "gxhash_JC_PROVIDERID"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, context.localUtil.Format( (decimal)(A87JC_ProviderID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_JC_PROVIDERNAME"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, StringUtil.RTrim( context.localUtil.Format( A89JC_ProviderName, "")), context));
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
         /* Using cursor H008J3 */
         pr_default.execute(1);
         GRID_nRecordCount = H008J3_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_JC_ProviderIDTitleControlIdToReplace, AV16ddo_JC_ProviderNameTitleControlIdToReplace, AV18ddo_JC_ProviderShortNameTitleControlIdToReplace, AV20ddo_JC_ProviderAddresssTitleControlIdToReplace, AV22ddo_JC_ProviderPhoneTitleControlIdToReplace, AV24ddo_JC_ProviderUserTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_JC_ProviderIDTitleControlIdToReplace, AV16ddo_JC_ProviderNameTitleControlIdToReplace, AV18ddo_JC_ProviderShortNameTitleControlIdToReplace, AV20ddo_JC_ProviderAddresssTitleControlIdToReplace, AV22ddo_JC_ProviderPhoneTitleControlIdToReplace, AV24ddo_JC_ProviderUserTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_JC_ProviderIDTitleControlIdToReplace, AV16ddo_JC_ProviderNameTitleControlIdToReplace, AV18ddo_JC_ProviderShortNameTitleControlIdToReplace, AV20ddo_JC_ProviderAddresssTitleControlIdToReplace, AV22ddo_JC_ProviderPhoneTitleControlIdToReplace, AV24ddo_JC_ProviderUserTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_JC_ProviderIDTitleControlIdToReplace, AV16ddo_JC_ProviderNameTitleControlIdToReplace, AV18ddo_JC_ProviderShortNameTitleControlIdToReplace, AV20ddo_JC_ProviderAddresssTitleControlIdToReplace, AV22ddo_JC_ProviderPhoneTitleControlIdToReplace, AV24ddo_JC_ProviderUserTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_JC_ProviderIDTitleControlIdToReplace, AV16ddo_JC_ProviderNameTitleControlIdToReplace, AV18ddo_JC_ProviderShortNameTitleControlIdToReplace, AV20ddo_JC_ProviderAddresssTitleControlIdToReplace, AV22ddo_JC_ProviderPhoneTitleControlIdToReplace, AV24ddo_JC_ProviderUserTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP8J0( )
      {
         /* Before Start, stand alone formulas. */
         AV33Pgmname = "JC_ProviderPrompt";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E198J2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV25DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vJC_PROVIDERIDTITLEFILTERDATA"), AV13JC_ProviderIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vJC_PROVIDERNAMETITLEFILTERDATA"), AV15JC_ProviderNameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vJC_PROVIDERSHORTNAMETITLEFILTERDATA"), AV17JC_ProviderShortNameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vJC_PROVIDERADDRESSSTITLEFILTERDATA"), AV19JC_ProviderAddresssTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vJC_PROVIDERPHONETITLEFILTERDATA"), AV21JC_ProviderPhoneTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vJC_PROVIDERUSERTITLEFILTERDATA"), AV23JC_ProviderUserTitleFilterData);
            /* Read variables values. */
            AV14ddo_JC_ProviderIDTitleControlIdToReplace = cgiGet( edtavDdo_jc_provideridtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_JC_ProviderIDTitleControlIdToReplace", AV14ddo_JC_ProviderIDTitleControlIdToReplace);
            AV16ddo_JC_ProviderNameTitleControlIdToReplace = cgiGet( edtavDdo_jc_providernametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_JC_ProviderNameTitleControlIdToReplace", AV16ddo_JC_ProviderNameTitleControlIdToReplace);
            AV18ddo_JC_ProviderShortNameTitleControlIdToReplace = cgiGet( edtavDdo_jc_providershortnametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_JC_ProviderShortNameTitleControlIdToReplace", AV18ddo_JC_ProviderShortNameTitleControlIdToReplace);
            AV20ddo_JC_ProviderAddresssTitleControlIdToReplace = cgiGet( edtavDdo_jc_provideraddressstitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_JC_ProviderAddresssTitleControlIdToReplace", AV20ddo_JC_ProviderAddresssTitleControlIdToReplace);
            AV22ddo_JC_ProviderPhoneTitleControlIdToReplace = cgiGet( edtavDdo_jc_providerphonetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ddo_JC_ProviderPhoneTitleControlIdToReplace", AV22ddo_JC_ProviderPhoneTitleControlIdToReplace);
            AV24ddo_JC_ProviderUserTitleControlIdToReplace = cgiGet( edtavDdo_jc_providerusertitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24ddo_JC_ProviderUserTitleControlIdToReplace", AV24ddo_JC_ProviderUserTitleControlIdToReplace);
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
            AV27GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV29GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV28GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_jc_providerid_Caption = cgiGet( "DDO_JC_PROVIDERID_Caption");
            Ddo_jc_providerid_Tooltip = cgiGet( "DDO_JC_PROVIDERID_Tooltip");
            Ddo_jc_providerid_Cls = cgiGet( "DDO_JC_PROVIDERID_Cls");
            Ddo_jc_providerid_Dropdownoptionstype = cgiGet( "DDO_JC_PROVIDERID_Dropdownoptionstype");
            Ddo_jc_providerid_Titlecontrolidtoreplace = cgiGet( "DDO_JC_PROVIDERID_Titlecontrolidtoreplace");
            Ddo_jc_providerid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERID_Includesortasc"));
            Ddo_jc_providerid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERID_Includesortdsc"));
            Ddo_jc_providerid_Sortedstatus = cgiGet( "DDO_JC_PROVIDERID_Sortedstatus");
            Ddo_jc_providerid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERID_Includefilter"));
            Ddo_jc_providerid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERID_Includedatalist"));
            Ddo_jc_providerid_Sortasc = cgiGet( "DDO_JC_PROVIDERID_Sortasc");
            Ddo_jc_providerid_Sortdsc = cgiGet( "DDO_JC_PROVIDERID_Sortdsc");
            Ddo_jc_providerid_Searchbuttontext = cgiGet( "DDO_JC_PROVIDERID_Searchbuttontext");
            Ddo_jc_providername_Caption = cgiGet( "DDO_JC_PROVIDERNAME_Caption");
            Ddo_jc_providername_Tooltip = cgiGet( "DDO_JC_PROVIDERNAME_Tooltip");
            Ddo_jc_providername_Cls = cgiGet( "DDO_JC_PROVIDERNAME_Cls");
            Ddo_jc_providername_Dropdownoptionstype = cgiGet( "DDO_JC_PROVIDERNAME_Dropdownoptionstype");
            Ddo_jc_providername_Titlecontrolidtoreplace = cgiGet( "DDO_JC_PROVIDERNAME_Titlecontrolidtoreplace");
            Ddo_jc_providername_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERNAME_Includesortasc"));
            Ddo_jc_providername_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERNAME_Includesortdsc"));
            Ddo_jc_providername_Sortedstatus = cgiGet( "DDO_JC_PROVIDERNAME_Sortedstatus");
            Ddo_jc_providername_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERNAME_Includefilter"));
            Ddo_jc_providername_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERNAME_Includedatalist"));
            Ddo_jc_providername_Sortasc = cgiGet( "DDO_JC_PROVIDERNAME_Sortasc");
            Ddo_jc_providername_Sortdsc = cgiGet( "DDO_JC_PROVIDERNAME_Sortdsc");
            Ddo_jc_providername_Searchbuttontext = cgiGet( "DDO_JC_PROVIDERNAME_Searchbuttontext");
            Ddo_jc_providershortname_Caption = cgiGet( "DDO_JC_PROVIDERSHORTNAME_Caption");
            Ddo_jc_providershortname_Tooltip = cgiGet( "DDO_JC_PROVIDERSHORTNAME_Tooltip");
            Ddo_jc_providershortname_Cls = cgiGet( "DDO_JC_PROVIDERSHORTNAME_Cls");
            Ddo_jc_providershortname_Dropdownoptionstype = cgiGet( "DDO_JC_PROVIDERSHORTNAME_Dropdownoptionstype");
            Ddo_jc_providershortname_Titlecontrolidtoreplace = cgiGet( "DDO_JC_PROVIDERSHORTNAME_Titlecontrolidtoreplace");
            Ddo_jc_providershortname_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERSHORTNAME_Includesortasc"));
            Ddo_jc_providershortname_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERSHORTNAME_Includesortdsc"));
            Ddo_jc_providershortname_Sortedstatus = cgiGet( "DDO_JC_PROVIDERSHORTNAME_Sortedstatus");
            Ddo_jc_providershortname_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERSHORTNAME_Includefilter"));
            Ddo_jc_providershortname_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERSHORTNAME_Includedatalist"));
            Ddo_jc_providershortname_Sortasc = cgiGet( "DDO_JC_PROVIDERSHORTNAME_Sortasc");
            Ddo_jc_providershortname_Sortdsc = cgiGet( "DDO_JC_PROVIDERSHORTNAME_Sortdsc");
            Ddo_jc_providershortname_Searchbuttontext = cgiGet( "DDO_JC_PROVIDERSHORTNAME_Searchbuttontext");
            Ddo_jc_provideraddresss_Caption = cgiGet( "DDO_JC_PROVIDERADDRESSS_Caption");
            Ddo_jc_provideraddresss_Tooltip = cgiGet( "DDO_JC_PROVIDERADDRESSS_Tooltip");
            Ddo_jc_provideraddresss_Cls = cgiGet( "DDO_JC_PROVIDERADDRESSS_Cls");
            Ddo_jc_provideraddresss_Dropdownoptionstype = cgiGet( "DDO_JC_PROVIDERADDRESSS_Dropdownoptionstype");
            Ddo_jc_provideraddresss_Titlecontrolidtoreplace = cgiGet( "DDO_JC_PROVIDERADDRESSS_Titlecontrolidtoreplace");
            Ddo_jc_provideraddresss_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERADDRESSS_Includesortasc"));
            Ddo_jc_provideraddresss_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERADDRESSS_Includesortdsc"));
            Ddo_jc_provideraddresss_Sortedstatus = cgiGet( "DDO_JC_PROVIDERADDRESSS_Sortedstatus");
            Ddo_jc_provideraddresss_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERADDRESSS_Includefilter"));
            Ddo_jc_provideraddresss_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERADDRESSS_Includedatalist"));
            Ddo_jc_provideraddresss_Sortasc = cgiGet( "DDO_JC_PROVIDERADDRESSS_Sortasc");
            Ddo_jc_provideraddresss_Sortdsc = cgiGet( "DDO_JC_PROVIDERADDRESSS_Sortdsc");
            Ddo_jc_provideraddresss_Searchbuttontext = cgiGet( "DDO_JC_PROVIDERADDRESSS_Searchbuttontext");
            Ddo_jc_providerphone_Caption = cgiGet( "DDO_JC_PROVIDERPHONE_Caption");
            Ddo_jc_providerphone_Tooltip = cgiGet( "DDO_JC_PROVIDERPHONE_Tooltip");
            Ddo_jc_providerphone_Cls = cgiGet( "DDO_JC_PROVIDERPHONE_Cls");
            Ddo_jc_providerphone_Dropdownoptionstype = cgiGet( "DDO_JC_PROVIDERPHONE_Dropdownoptionstype");
            Ddo_jc_providerphone_Titlecontrolidtoreplace = cgiGet( "DDO_JC_PROVIDERPHONE_Titlecontrolidtoreplace");
            Ddo_jc_providerphone_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERPHONE_Includesortasc"));
            Ddo_jc_providerphone_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERPHONE_Includesortdsc"));
            Ddo_jc_providerphone_Sortedstatus = cgiGet( "DDO_JC_PROVIDERPHONE_Sortedstatus");
            Ddo_jc_providerphone_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERPHONE_Includefilter"));
            Ddo_jc_providerphone_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERPHONE_Includedatalist"));
            Ddo_jc_providerphone_Sortasc = cgiGet( "DDO_JC_PROVIDERPHONE_Sortasc");
            Ddo_jc_providerphone_Sortdsc = cgiGet( "DDO_JC_PROVIDERPHONE_Sortdsc");
            Ddo_jc_providerphone_Searchbuttontext = cgiGet( "DDO_JC_PROVIDERPHONE_Searchbuttontext");
            Ddo_jc_provideruser_Caption = cgiGet( "DDO_JC_PROVIDERUSER_Caption");
            Ddo_jc_provideruser_Tooltip = cgiGet( "DDO_JC_PROVIDERUSER_Tooltip");
            Ddo_jc_provideruser_Cls = cgiGet( "DDO_JC_PROVIDERUSER_Cls");
            Ddo_jc_provideruser_Dropdownoptionstype = cgiGet( "DDO_JC_PROVIDERUSER_Dropdownoptionstype");
            Ddo_jc_provideruser_Titlecontrolidtoreplace = cgiGet( "DDO_JC_PROVIDERUSER_Titlecontrolidtoreplace");
            Ddo_jc_provideruser_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERUSER_Includesortasc"));
            Ddo_jc_provideruser_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERUSER_Includesortdsc"));
            Ddo_jc_provideruser_Sortedstatus = cgiGet( "DDO_JC_PROVIDERUSER_Sortedstatus");
            Ddo_jc_provideruser_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERUSER_Includefilter"));
            Ddo_jc_provideruser_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERUSER_Includedatalist"));
            Ddo_jc_provideruser_Sortasc = cgiGet( "DDO_JC_PROVIDERUSER_Sortasc");
            Ddo_jc_provideruser_Sortdsc = cgiGet( "DDO_JC_PROVIDERUSER_Sortdsc");
            Ddo_jc_provideruser_Searchbuttontext = cgiGet( "DDO_JC_PROVIDERUSER_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_jc_providerid_Activeeventkey = cgiGet( "DDO_JC_PROVIDERID_Activeeventkey");
            Ddo_jc_providername_Activeeventkey = cgiGet( "DDO_JC_PROVIDERNAME_Activeeventkey");
            Ddo_jc_providershortname_Activeeventkey = cgiGet( "DDO_JC_PROVIDERSHORTNAME_Activeeventkey");
            Ddo_jc_provideraddresss_Activeeventkey = cgiGet( "DDO_JC_PROVIDERADDRESSS_Activeeventkey");
            Ddo_jc_providerphone_Activeeventkey = cgiGet( "DDO_JC_PROVIDERPHONE_Activeeventkey");
            Ddo_jc_provideruser_Activeeventkey = cgiGet( "DDO_JC_PROVIDERUSER_Activeeventkey");
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
         E198J2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E198J2( )
      {
         /* Start Routine */
         GXt_boolean1 = AV5IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWJC_Provider", out  GXt_boolean1) ;
         AV5IsAuthorized = GXt_boolean1;
         if ( ! AV5IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV33Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         divTablemain_Height = 493;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTablemain_Internalname, "Height", StringUtil.LTrim( StringUtil.Str( (decimal)(divTablemain_Height), 9, 0)), true);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_jc_providerid_Titlecontrolidtoreplace = subGrid_Internalname+"_JC_ProviderID";
         ucDdo_jc_providerid.SendProperty(context, "", false, Ddo_jc_providerid_Internalname, "TitleControlIdToReplace", Ddo_jc_providerid_Titlecontrolidtoreplace);
         AV14ddo_JC_ProviderIDTitleControlIdToReplace = Ddo_jc_providerid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_JC_ProviderIDTitleControlIdToReplace", AV14ddo_JC_ProviderIDTitleControlIdToReplace);
         edtavDdo_jc_provideridtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_jc_provideridtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_jc_provideridtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_jc_providername_Titlecontrolidtoreplace = subGrid_Internalname+"_JC_ProviderName";
         ucDdo_jc_providername.SendProperty(context, "", false, Ddo_jc_providername_Internalname, "TitleControlIdToReplace", Ddo_jc_providername_Titlecontrolidtoreplace);
         AV16ddo_JC_ProviderNameTitleControlIdToReplace = Ddo_jc_providername_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_JC_ProviderNameTitleControlIdToReplace", AV16ddo_JC_ProviderNameTitleControlIdToReplace);
         edtavDdo_jc_providernametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_jc_providernametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_jc_providernametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_jc_providershortname_Titlecontrolidtoreplace = subGrid_Internalname+"_JC_ProviderShortName";
         ucDdo_jc_providershortname.SendProperty(context, "", false, Ddo_jc_providershortname_Internalname, "TitleControlIdToReplace", Ddo_jc_providershortname_Titlecontrolidtoreplace);
         AV18ddo_JC_ProviderShortNameTitleControlIdToReplace = Ddo_jc_providershortname_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_JC_ProviderShortNameTitleControlIdToReplace", AV18ddo_JC_ProviderShortNameTitleControlIdToReplace);
         edtavDdo_jc_providershortnametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_jc_providershortnametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_jc_providershortnametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_jc_provideraddresss_Titlecontrolidtoreplace = subGrid_Internalname+"_JC_ProviderAddresss";
         ucDdo_jc_provideraddresss.SendProperty(context, "", false, Ddo_jc_provideraddresss_Internalname, "TitleControlIdToReplace", Ddo_jc_provideraddresss_Titlecontrolidtoreplace);
         AV20ddo_JC_ProviderAddresssTitleControlIdToReplace = Ddo_jc_provideraddresss_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_JC_ProviderAddresssTitleControlIdToReplace", AV20ddo_JC_ProviderAddresssTitleControlIdToReplace);
         edtavDdo_jc_provideraddressstitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_jc_provideraddressstitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_jc_provideraddressstitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_jc_providerphone_Titlecontrolidtoreplace = subGrid_Internalname+"_JC_ProviderPhone";
         ucDdo_jc_providerphone.SendProperty(context, "", false, Ddo_jc_providerphone_Internalname, "TitleControlIdToReplace", Ddo_jc_providerphone_Titlecontrolidtoreplace);
         AV22ddo_JC_ProviderPhoneTitleControlIdToReplace = Ddo_jc_providerphone_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ddo_JC_ProviderPhoneTitleControlIdToReplace", AV22ddo_JC_ProviderPhoneTitleControlIdToReplace);
         edtavDdo_jc_providerphonetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_jc_providerphonetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_jc_providerphonetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_jc_provideruser_Titlecontrolidtoreplace = subGrid_Internalname+"_JC_ProviderUser";
         ucDdo_jc_provideruser.SendProperty(context, "", false, Ddo_jc_provideruser_Internalname, "TitleControlIdToReplace", Ddo_jc_provideruser_Titlecontrolidtoreplace);
         AV24ddo_JC_ProviderUserTitleControlIdToReplace = Ddo_jc_provideruser_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24ddo_JC_ProviderUserTitleControlIdToReplace", AV24ddo_JC_ProviderUserTitleControlIdToReplace);
         edtavDdo_jc_providerusertitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_jc_providerusertitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_jc_providerusertitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "选择医院";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV25DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV25DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E208J2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV13JC_ProviderIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15JC_ProviderNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17JC_ProviderShortNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19JC_ProviderAddresssTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21JC_ProviderPhoneTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV23JC_ProviderUserTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         edtJC_ProviderID_Titleformat = 2;
         edtJC_ProviderID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊医院", AV14ddo_JC_ProviderIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtJC_ProviderID_Internalname, "Title", edtJC_ProviderID_Title, !bGXsfl_12_Refreshing);
         edtJC_ProviderName_Titleformat = 2;
         edtJC_ProviderName_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "医院名称", AV16ddo_JC_ProviderNameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtJC_ProviderName_Internalname, "Title", edtJC_ProviderName_Title, !bGXsfl_12_Refreshing);
         edtJC_ProviderShortName_Titleformat = 2;
         edtJC_ProviderShortName_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "医院缩写", AV18ddo_JC_ProviderShortNameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtJC_ProviderShortName_Internalname, "Title", edtJC_ProviderShortName_Title, !bGXsfl_12_Refreshing);
         edtJC_ProviderAddresss_Titleformat = 2;
         edtJC_ProviderAddresss_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "医院地址", AV20ddo_JC_ProviderAddresssTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtJC_ProviderAddresss_Internalname, "Title", edtJC_ProviderAddresss_Title, !bGXsfl_12_Refreshing);
         edtJC_ProviderPhone_Titleformat = 2;
         edtJC_ProviderPhone_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "医院联系人电话", AV22ddo_JC_ProviderPhoneTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtJC_ProviderPhone_Internalname, "Title", edtJC_ProviderPhone_Title, !bGXsfl_12_Refreshing);
         edtJC_ProviderUser_Titleformat = 2;
         edtJC_ProviderUser_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "医院联系人", AV24ddo_JC_ProviderUserTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtJC_ProviderUser_Internalname, "Title", edtJC_ProviderUser_Title, !bGXsfl_12_Refreshing);
         AV27GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV27GridCurrentPage), 10, 0)));
         AV28GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28GridPageSize), 10, 0)));
         AV29GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13JC_ProviderIDTitleFilterData", AV13JC_ProviderIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15JC_ProviderNameTitleFilterData", AV15JC_ProviderNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17JC_ProviderShortNameTitleFilterData", AV17JC_ProviderShortNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19JC_ProviderAddresssTitleFilterData", AV19JC_ProviderAddresssTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21JC_ProviderPhoneTitleFilterData", AV21JC_ProviderPhoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23JC_ProviderUserTitleFilterData", AV23JC_ProviderUserTitleFilterData);
      }

      protected void E118J2( )
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

      protected void E128J2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E138J2( )
      {
         /* Ddo_jc_providerid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_jc_providerid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_jc_providerid_Sortedstatus = "ASC";
            ucDdo_jc_providerid.SendProperty(context, "", false, Ddo_jc_providerid_Internalname, "SortedStatus", Ddo_jc_providerid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_jc_providerid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_jc_providerid_Sortedstatus = "DSC";
            ucDdo_jc_providerid.SendProperty(context, "", false, Ddo_jc_providerid_Internalname, "SortedStatus", Ddo_jc_providerid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13JC_ProviderIDTitleFilterData", AV13JC_ProviderIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15JC_ProviderNameTitleFilterData", AV15JC_ProviderNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17JC_ProviderShortNameTitleFilterData", AV17JC_ProviderShortNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19JC_ProviderAddresssTitleFilterData", AV19JC_ProviderAddresssTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21JC_ProviderPhoneTitleFilterData", AV21JC_ProviderPhoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23JC_ProviderUserTitleFilterData", AV23JC_ProviderUserTitleFilterData);
      }

      protected void E148J2( )
      {
         /* Ddo_jc_providername_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_jc_providername_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_jc_providername_Sortedstatus = "ASC";
            ucDdo_jc_providername.SendProperty(context, "", false, Ddo_jc_providername_Internalname, "SortedStatus", Ddo_jc_providername_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_jc_providername_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_jc_providername_Sortedstatus = "DSC";
            ucDdo_jc_providername.SendProperty(context, "", false, Ddo_jc_providername_Internalname, "SortedStatus", Ddo_jc_providername_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13JC_ProviderIDTitleFilterData", AV13JC_ProviderIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15JC_ProviderNameTitleFilterData", AV15JC_ProviderNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17JC_ProviderShortNameTitleFilterData", AV17JC_ProviderShortNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19JC_ProviderAddresssTitleFilterData", AV19JC_ProviderAddresssTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21JC_ProviderPhoneTitleFilterData", AV21JC_ProviderPhoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23JC_ProviderUserTitleFilterData", AV23JC_ProviderUserTitleFilterData);
      }

      protected void E158J2( )
      {
         /* Ddo_jc_providershortname_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_jc_providershortname_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_jc_providershortname_Sortedstatus = "ASC";
            ucDdo_jc_providershortname.SendProperty(context, "", false, Ddo_jc_providershortname_Internalname, "SortedStatus", Ddo_jc_providershortname_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_jc_providershortname_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_jc_providershortname_Sortedstatus = "DSC";
            ucDdo_jc_providershortname.SendProperty(context, "", false, Ddo_jc_providershortname_Internalname, "SortedStatus", Ddo_jc_providershortname_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13JC_ProviderIDTitleFilterData", AV13JC_ProviderIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15JC_ProviderNameTitleFilterData", AV15JC_ProviderNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17JC_ProviderShortNameTitleFilterData", AV17JC_ProviderShortNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19JC_ProviderAddresssTitleFilterData", AV19JC_ProviderAddresssTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21JC_ProviderPhoneTitleFilterData", AV21JC_ProviderPhoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23JC_ProviderUserTitleFilterData", AV23JC_ProviderUserTitleFilterData);
      }

      protected void E168J2( )
      {
         /* Ddo_jc_provideraddresss_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_jc_provideraddresss_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_jc_provideraddresss_Sortedstatus = "ASC";
            ucDdo_jc_provideraddresss.SendProperty(context, "", false, Ddo_jc_provideraddresss_Internalname, "SortedStatus", Ddo_jc_provideraddresss_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_jc_provideraddresss_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_jc_provideraddresss_Sortedstatus = "DSC";
            ucDdo_jc_provideraddresss.SendProperty(context, "", false, Ddo_jc_provideraddresss_Internalname, "SortedStatus", Ddo_jc_provideraddresss_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13JC_ProviderIDTitleFilterData", AV13JC_ProviderIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15JC_ProviderNameTitleFilterData", AV15JC_ProviderNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17JC_ProviderShortNameTitleFilterData", AV17JC_ProviderShortNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19JC_ProviderAddresssTitleFilterData", AV19JC_ProviderAddresssTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21JC_ProviderPhoneTitleFilterData", AV21JC_ProviderPhoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23JC_ProviderUserTitleFilterData", AV23JC_ProviderUserTitleFilterData);
      }

      protected void E178J2( )
      {
         /* Ddo_jc_providerphone_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_jc_providerphone_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_jc_providerphone_Sortedstatus = "ASC";
            ucDdo_jc_providerphone.SendProperty(context, "", false, Ddo_jc_providerphone_Internalname, "SortedStatus", Ddo_jc_providerphone_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_jc_providerphone_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_jc_providerphone_Sortedstatus = "DSC";
            ucDdo_jc_providerphone.SendProperty(context, "", false, Ddo_jc_providerphone_Internalname, "SortedStatus", Ddo_jc_providerphone_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13JC_ProviderIDTitleFilterData", AV13JC_ProviderIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15JC_ProviderNameTitleFilterData", AV15JC_ProviderNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17JC_ProviderShortNameTitleFilterData", AV17JC_ProviderShortNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19JC_ProviderAddresssTitleFilterData", AV19JC_ProviderAddresssTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21JC_ProviderPhoneTitleFilterData", AV21JC_ProviderPhoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23JC_ProviderUserTitleFilterData", AV23JC_ProviderUserTitleFilterData);
      }

      protected void E188J2( )
      {
         /* Ddo_jc_provideruser_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_jc_provideruser_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_jc_provideruser_Sortedstatus = "ASC";
            ucDdo_jc_provideruser.SendProperty(context, "", false, Ddo_jc_provideruser_Internalname, "SortedStatus", Ddo_jc_provideruser_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_jc_provideruser_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_jc_provideruser_Sortedstatus = "DSC";
            ucDdo_jc_provideruser.SendProperty(context, "", false, Ddo_jc_provideruser_Internalname, "SortedStatus", Ddo_jc_provideruser_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13JC_ProviderIDTitleFilterData", AV13JC_ProviderIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15JC_ProviderNameTitleFilterData", AV15JC_ProviderNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17JC_ProviderShortNameTitleFilterData", AV17JC_ProviderShortNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19JC_ProviderAddresssTitleFilterData", AV19JC_ProviderAddresssTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21JC_ProviderPhoneTitleFilterData", AV21JC_ProviderPhoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23JC_ProviderUserTitleFilterData", AV23JC_ProviderUserTitleFilterData);
      }

      private void E218J2( )
      {
         /* Grid_Load Routine */
         AV30Select = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSelect_Internalname, AV30Select);
         AV34Select_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
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
         E228J2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E228J2( )
      {
         /* Enter Routine */
         AV8InOutJC_ProviderID = A87JC_ProviderID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutJC_ProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutJC_ProviderID), 18, 0)));
         AV9InOutJC_ProviderName = A89JC_ProviderName;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutJC_ProviderName", AV9InOutJC_ProviderName);
         context.setWebReturnParms(new Object[] {(long)AV8InOutJC_ProviderID,(String)AV9InOutJC_ProviderName});
         context.setWebReturnParmsMetadata(new Object[] {"AV8InOutJC_ProviderID","AV9InOutJC_ProviderName"});
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
         AV8InOutJC_ProviderID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutJC_ProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutJC_ProviderID), 18, 0)));
         AV9InOutJC_ProviderName = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutJC_ProviderName", AV9InOutJC_ProviderName);
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
         PA8J2( ) ;
         WS8J2( ) ;
         WE8J2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022815165363", true);
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
         context.AddJavascriptSource("jc_providerprompt.js", "?202022815165364", false);
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

      protected void SubsflControlProps_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_idx;
         edtJC_ProviderID_Internalname = "JC_PROVIDERID_"+sGXsfl_12_idx;
         edtJC_ProviderName_Internalname = "JC_PROVIDERNAME_"+sGXsfl_12_idx;
         edtJC_ProviderShortName_Internalname = "JC_PROVIDERSHORTNAME_"+sGXsfl_12_idx;
         edtJC_ProviderAddresss_Internalname = "JC_PROVIDERADDRESSS_"+sGXsfl_12_idx;
         edtJC_ProviderPhone_Internalname = "JC_PROVIDERPHONE_"+sGXsfl_12_idx;
         edtJC_ProviderUser_Internalname = "JC_PROVIDERUSER_"+sGXsfl_12_idx;
      }

      protected void SubsflControlProps_fel_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_fel_idx;
         edtJC_ProviderID_Internalname = "JC_PROVIDERID_"+sGXsfl_12_fel_idx;
         edtJC_ProviderName_Internalname = "JC_PROVIDERNAME_"+sGXsfl_12_fel_idx;
         edtJC_ProviderShortName_Internalname = "JC_PROVIDERSHORTNAME_"+sGXsfl_12_fel_idx;
         edtJC_ProviderAddresss_Internalname = "JC_PROVIDERADDRESSS_"+sGXsfl_12_fel_idx;
         edtJC_ProviderPhone_Internalname = "JC_PROVIDERPHONE_"+sGXsfl_12_fel_idx;
         edtJC_ProviderUser_Internalname = "JC_PROVIDERUSER_"+sGXsfl_12_fel_idx;
      }

      protected void sendrow_122( )
      {
         SubsflControlProps_122( ) ;
         WB8J0( ) ;
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
            AV30Select_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV30Select))&&String.IsNullOrEmpty(StringUtil.RTrim( AV34Select_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV30Select)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV30Select)) ? AV34Select_GXI : context.PathToRelativeUrl( AV30Select));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSelect_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSelect_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSelect_Jsonclick,"'"+""+"'"+",false,"+"'"+"EENTER."+sGXsfl_12_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV30Select_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtJC_ProviderID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A87JC_ProviderID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A87JC_ProviderID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtJC_ProviderID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtJC_ProviderName_Internalname,(String)A89JC_ProviderName,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtJC_ProviderName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)410,(String)"px",(short)17,(String)"px",(short)200,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtJC_ProviderShortName_Internalname,(String)A160JC_ProviderShortName,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtJC_ProviderShortName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtJC_ProviderAddresss_Internalname,(String)A161JC_ProviderAddresss,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+"e238j2_client"+"'","http://maps.google.com/maps?q="+GXUtil.UrlEncode( A161JC_ProviderAddresss),(String)"_blank",(String)"",(String)"",(String)edtJC_ProviderAddresss_Jsonclick,(short)7,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)410,(String)"px",(short)17,(String)"px",(short)1024,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"GeneXus\\Address",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            if ( context.isSmartDevice( ) )
            {
               gxphoneLink = "tel:" + StringUtil.RTrim( A162JC_ProviderPhone);
            }
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtJC_ProviderPhone_Internalname,StringUtil.RTrim( A162JC_ProviderPhone),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)gxphoneLink,(String)"",(String)"",(String)"",(String)edtJC_ProviderPhone_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"tel",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"GeneXus\\Phone",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtJC_ProviderUser_Internalname,(String)A163JC_ProviderUser,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtJC_ProviderUser_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes8J2( ) ;
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
         edtJC_ProviderID_Internalname = "JC_PROVIDERID";
         edtJC_ProviderName_Internalname = "JC_PROVIDERNAME";
         edtJC_ProviderShortName_Internalname = "JC_PROVIDERSHORTNAME";
         edtJC_ProviderAddresss_Internalname = "JC_PROVIDERADDRESSS";
         edtJC_ProviderPhone_Internalname = "JC_PROVIDERPHONE";
         edtJC_ProviderUser_Internalname = "JC_PROVIDERUSER";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_jc_providerid_Internalname = "DDO_JC_PROVIDERID";
         edtavDdo_jc_provideridtitlecontrolidtoreplace_Internalname = "vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE";
         Ddo_jc_providername_Internalname = "DDO_JC_PROVIDERNAME";
         edtavDdo_jc_providernametitlecontrolidtoreplace_Internalname = "vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE";
         Ddo_jc_providershortname_Internalname = "DDO_JC_PROVIDERSHORTNAME";
         edtavDdo_jc_providershortnametitlecontrolidtoreplace_Internalname = "vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE";
         Ddo_jc_provideraddresss_Internalname = "DDO_JC_PROVIDERADDRESSS";
         edtavDdo_jc_provideraddressstitlecontrolidtoreplace_Internalname = "vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE";
         Ddo_jc_providerphone_Internalname = "DDO_JC_PROVIDERPHONE";
         edtavDdo_jc_providerphonetitlecontrolidtoreplace_Internalname = "vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE";
         Ddo_jc_provideruser_Internalname = "DDO_JC_PROVIDERUSER";
         edtavDdo_jc_providerusertitlecontrolidtoreplace_Internalname = "vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE";
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
         edtJC_ProviderUser_Jsonclick = "";
         edtJC_ProviderPhone_Jsonclick = "";
         edtJC_ProviderAddresss_Jsonclick = "";
         edtJC_ProviderShortName_Jsonclick = "";
         edtJC_ProviderName_Jsonclick = "";
         edtJC_ProviderID_Jsonclick = "";
         edtavSelect_Jsonclick = "";
         edtavSelect_Visible = -1;
         edtavSelect_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_jc_providerusertitlecontrolidtoreplace_Visible = 1;
         edtavDdo_jc_providerphonetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_jc_provideraddressstitlecontrolidtoreplace_Visible = 1;
         edtavDdo_jc_providershortnametitlecontrolidtoreplace_Visible = 1;
         edtavDdo_jc_providernametitlecontrolidtoreplace_Visible = 1;
         edtavDdo_jc_provideridtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavSelect_Tooltiptext = "选择";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtJC_ProviderUser_Titleformat = 0;
         edtJC_ProviderUser_Title = "医院联系人";
         edtJC_ProviderPhone_Titleformat = 0;
         edtJC_ProviderPhone_Title = "医院联系人电话";
         edtJC_ProviderAddresss_Titleformat = 0;
         edtJC_ProviderAddresss_Title = "医院地址";
         edtJC_ProviderShortName_Titleformat = 0;
         edtJC_ProviderShortName_Title = "医院缩写";
         edtJC_ProviderName_Titleformat = 0;
         edtJC_ProviderName_Title = "医院名称";
         edtJC_ProviderID_Titleformat = 0;
         edtJC_ProviderID_Title = "就诊医院";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         divTablemain_Height = 0;
         Ddo_jc_provideruser_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_jc_provideruser_Sortdsc = "WWP_TSSortDSC";
         Ddo_jc_provideruser_Sortasc = "WWP_TSSortASC";
         Ddo_jc_provideruser_Includedatalist = Convert.ToBoolean( 0);
         Ddo_jc_provideruser_Includefilter = Convert.ToBoolean( 0);
         Ddo_jc_provideruser_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_jc_provideruser_Includesortasc = Convert.ToBoolean( -1);
         Ddo_jc_provideruser_Titlecontrolidtoreplace = "";
         Ddo_jc_provideruser_Dropdownoptionstype = "GridTitleSettings";
         Ddo_jc_provideruser_Cls = "ColumnSettings";
         Ddo_jc_provideruser_Tooltip = "WWP_TSColumnOptions";
         Ddo_jc_provideruser_Caption = "";
         Ddo_jc_providerphone_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_jc_providerphone_Sortdsc = "WWP_TSSortDSC";
         Ddo_jc_providerphone_Sortasc = "WWP_TSSortASC";
         Ddo_jc_providerphone_Includedatalist = Convert.ToBoolean( 0);
         Ddo_jc_providerphone_Includefilter = Convert.ToBoolean( 0);
         Ddo_jc_providerphone_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_jc_providerphone_Includesortasc = Convert.ToBoolean( -1);
         Ddo_jc_providerphone_Titlecontrolidtoreplace = "";
         Ddo_jc_providerphone_Dropdownoptionstype = "GridTitleSettings";
         Ddo_jc_providerphone_Cls = "ColumnSettings";
         Ddo_jc_providerphone_Tooltip = "WWP_TSColumnOptions";
         Ddo_jc_providerphone_Caption = "";
         Ddo_jc_provideraddresss_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_jc_provideraddresss_Sortdsc = "WWP_TSSortDSC";
         Ddo_jc_provideraddresss_Sortasc = "WWP_TSSortASC";
         Ddo_jc_provideraddresss_Includedatalist = Convert.ToBoolean( 0);
         Ddo_jc_provideraddresss_Includefilter = Convert.ToBoolean( 0);
         Ddo_jc_provideraddresss_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_jc_provideraddresss_Includesortasc = Convert.ToBoolean( -1);
         Ddo_jc_provideraddresss_Titlecontrolidtoreplace = "";
         Ddo_jc_provideraddresss_Dropdownoptionstype = "GridTitleSettings";
         Ddo_jc_provideraddresss_Cls = "ColumnSettings";
         Ddo_jc_provideraddresss_Tooltip = "WWP_TSColumnOptions";
         Ddo_jc_provideraddresss_Caption = "";
         Ddo_jc_providershortname_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_jc_providershortname_Sortdsc = "WWP_TSSortDSC";
         Ddo_jc_providershortname_Sortasc = "WWP_TSSortASC";
         Ddo_jc_providershortname_Includedatalist = Convert.ToBoolean( 0);
         Ddo_jc_providershortname_Includefilter = Convert.ToBoolean( 0);
         Ddo_jc_providershortname_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_jc_providershortname_Includesortasc = Convert.ToBoolean( -1);
         Ddo_jc_providershortname_Titlecontrolidtoreplace = "";
         Ddo_jc_providershortname_Dropdownoptionstype = "GridTitleSettings";
         Ddo_jc_providershortname_Cls = "ColumnSettings";
         Ddo_jc_providershortname_Tooltip = "WWP_TSColumnOptions";
         Ddo_jc_providershortname_Caption = "";
         Ddo_jc_providername_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_jc_providername_Sortdsc = "WWP_TSSortDSC";
         Ddo_jc_providername_Sortasc = "WWP_TSSortASC";
         Ddo_jc_providername_Includedatalist = Convert.ToBoolean( 0);
         Ddo_jc_providername_Includefilter = Convert.ToBoolean( 0);
         Ddo_jc_providername_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_jc_providername_Includesortasc = Convert.ToBoolean( -1);
         Ddo_jc_providername_Titlecontrolidtoreplace = "";
         Ddo_jc_providername_Dropdownoptionstype = "GridTitleSettings";
         Ddo_jc_providername_Cls = "ColumnSettings";
         Ddo_jc_providername_Tooltip = "WWP_TSColumnOptions";
         Ddo_jc_providername_Caption = "";
         Ddo_jc_providerid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_jc_providerid_Sortdsc = "WWP_TSSortDSC";
         Ddo_jc_providerid_Sortasc = "WWP_TSSortASC";
         Ddo_jc_providerid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_jc_providerid_Includefilter = Convert.ToBoolean( 0);
         Ddo_jc_providerid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_jc_providerid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_jc_providerid_Titlecontrolidtoreplace = "";
         Ddo_jc_providerid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_jc_providerid_Cls = "ColumnSettings";
         Ddo_jc_providerid_Tooltip = "WWP_TSColumnOptions";
         Ddo_jc_providerid_Caption = "";
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
         Form.Caption = "选择医院";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_JC_ProviderIDTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_JC_ProviderShortNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_JC_ProviderAddresssTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_JC_ProviderPhoneTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_JC_ProviderUserTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV13JC_ProviderIDTitleFilterData',fld:'vJC_PROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV15JC_ProviderNameTitleFilterData',fld:'vJC_PROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV17JC_ProviderShortNameTitleFilterData',fld:'vJC_PROVIDERSHORTNAMETITLEFILTERDATA',pic:''},{av:'AV19JC_ProviderAddresssTitleFilterData',fld:'vJC_PROVIDERADDRESSSTITLEFILTERDATA',pic:''},{av:'AV21JC_ProviderPhoneTitleFilterData',fld:'vJC_PROVIDERPHONETITLEFILTERDATA',pic:''},{av:'AV23JC_ProviderUserTitleFilterData',fld:'vJC_PROVIDERUSERTITLEFILTERDATA',pic:''},{av:'edtJC_ProviderID_Titleformat',ctrl:'JC_PROVIDERID',prop:'Titleformat'},{av:'edtJC_ProviderID_Title',ctrl:'JC_PROVIDERID',prop:'Title'},{av:'edtJC_ProviderName_Titleformat',ctrl:'JC_PROVIDERNAME',prop:'Titleformat'},{av:'edtJC_ProviderName_Title',ctrl:'JC_PROVIDERNAME',prop:'Title'},{av:'edtJC_ProviderShortName_Titleformat',ctrl:'JC_PROVIDERSHORTNAME',prop:'Titleformat'},{av:'edtJC_ProviderShortName_Title',ctrl:'JC_PROVIDERSHORTNAME',prop:'Title'},{av:'edtJC_ProviderAddresss_Titleformat',ctrl:'JC_PROVIDERADDRESSS',prop:'Titleformat'},{av:'edtJC_ProviderAddresss_Title',ctrl:'JC_PROVIDERADDRESSS',prop:'Title'},{av:'edtJC_ProviderPhone_Titleformat',ctrl:'JC_PROVIDERPHONE',prop:'Titleformat'},{av:'edtJC_ProviderPhone_Title',ctrl:'JC_PROVIDERPHONE',prop:'Title'},{av:'edtJC_ProviderUser_Titleformat',ctrl:'JC_PROVIDERUSER',prop:'Titleformat'},{av:'edtJC_ProviderUser_Title',ctrl:'JC_PROVIDERUSER',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("JC_PROVIDERADDRESSS.CLICK","{handler:'E238J2',iparms:[{av:'A161JC_ProviderAddresss',fld:'JC_PROVIDERADDRESSS',pic:'',hsh:true}]");
         setEventMetadata("JC_PROVIDERADDRESSS.CLICK",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E118J2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_JC_ProviderIDTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_JC_ProviderShortNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_JC_ProviderAddresssTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_JC_ProviderPhoneTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_JC_ProviderUserTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E128J2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_JC_ProviderIDTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_JC_ProviderShortNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_JC_ProviderAddresssTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_JC_ProviderPhoneTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_JC_ProviderUserTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_JC_PROVIDERID.ONOPTIONCLICKED","{handler:'E138J2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_JC_ProviderIDTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_JC_ProviderShortNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_JC_ProviderAddresssTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_JC_ProviderPhoneTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_JC_ProviderUserTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_jc_providerid_Activeeventkey',ctrl:'DDO_JC_PROVIDERID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_JC_PROVIDERID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_jc_providerid_Sortedstatus',ctrl:'DDO_JC_PROVIDERID',prop:'SortedStatus'},{av:'AV13JC_ProviderIDTitleFilterData',fld:'vJC_PROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV15JC_ProviderNameTitleFilterData',fld:'vJC_PROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV17JC_ProviderShortNameTitleFilterData',fld:'vJC_PROVIDERSHORTNAMETITLEFILTERDATA',pic:''},{av:'AV19JC_ProviderAddresssTitleFilterData',fld:'vJC_PROVIDERADDRESSSTITLEFILTERDATA',pic:''},{av:'AV21JC_ProviderPhoneTitleFilterData',fld:'vJC_PROVIDERPHONETITLEFILTERDATA',pic:''},{av:'AV23JC_ProviderUserTitleFilterData',fld:'vJC_PROVIDERUSERTITLEFILTERDATA',pic:''},{av:'edtJC_ProviderID_Titleformat',ctrl:'JC_PROVIDERID',prop:'Titleformat'},{av:'edtJC_ProviderID_Title',ctrl:'JC_PROVIDERID',prop:'Title'},{av:'edtJC_ProviderName_Titleformat',ctrl:'JC_PROVIDERNAME',prop:'Titleformat'},{av:'edtJC_ProviderName_Title',ctrl:'JC_PROVIDERNAME',prop:'Title'},{av:'edtJC_ProviderShortName_Titleformat',ctrl:'JC_PROVIDERSHORTNAME',prop:'Titleformat'},{av:'edtJC_ProviderShortName_Title',ctrl:'JC_PROVIDERSHORTNAME',prop:'Title'},{av:'edtJC_ProviderAddresss_Titleformat',ctrl:'JC_PROVIDERADDRESSS',prop:'Titleformat'},{av:'edtJC_ProviderAddresss_Title',ctrl:'JC_PROVIDERADDRESSS',prop:'Title'},{av:'edtJC_ProviderPhone_Titleformat',ctrl:'JC_PROVIDERPHONE',prop:'Titleformat'},{av:'edtJC_ProviderPhone_Title',ctrl:'JC_PROVIDERPHONE',prop:'Title'},{av:'edtJC_ProviderUser_Titleformat',ctrl:'JC_PROVIDERUSER',prop:'Titleformat'},{av:'edtJC_ProviderUser_Title',ctrl:'JC_PROVIDERUSER',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_JC_PROVIDERNAME.ONOPTIONCLICKED","{handler:'E148J2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_JC_ProviderIDTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_JC_ProviderShortNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_JC_ProviderAddresssTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_JC_ProviderPhoneTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_JC_ProviderUserTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_jc_providername_Activeeventkey',ctrl:'DDO_JC_PROVIDERNAME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_JC_PROVIDERNAME.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_jc_providername_Sortedstatus',ctrl:'DDO_JC_PROVIDERNAME',prop:'SortedStatus'},{av:'AV13JC_ProviderIDTitleFilterData',fld:'vJC_PROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV15JC_ProviderNameTitleFilterData',fld:'vJC_PROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV17JC_ProviderShortNameTitleFilterData',fld:'vJC_PROVIDERSHORTNAMETITLEFILTERDATA',pic:''},{av:'AV19JC_ProviderAddresssTitleFilterData',fld:'vJC_PROVIDERADDRESSSTITLEFILTERDATA',pic:''},{av:'AV21JC_ProviderPhoneTitleFilterData',fld:'vJC_PROVIDERPHONETITLEFILTERDATA',pic:''},{av:'AV23JC_ProviderUserTitleFilterData',fld:'vJC_PROVIDERUSERTITLEFILTERDATA',pic:''},{av:'edtJC_ProviderID_Titleformat',ctrl:'JC_PROVIDERID',prop:'Titleformat'},{av:'edtJC_ProviderID_Title',ctrl:'JC_PROVIDERID',prop:'Title'},{av:'edtJC_ProviderName_Titleformat',ctrl:'JC_PROVIDERNAME',prop:'Titleformat'},{av:'edtJC_ProviderName_Title',ctrl:'JC_PROVIDERNAME',prop:'Title'},{av:'edtJC_ProviderShortName_Titleformat',ctrl:'JC_PROVIDERSHORTNAME',prop:'Titleformat'},{av:'edtJC_ProviderShortName_Title',ctrl:'JC_PROVIDERSHORTNAME',prop:'Title'},{av:'edtJC_ProviderAddresss_Titleformat',ctrl:'JC_PROVIDERADDRESSS',prop:'Titleformat'},{av:'edtJC_ProviderAddresss_Title',ctrl:'JC_PROVIDERADDRESSS',prop:'Title'},{av:'edtJC_ProviderPhone_Titleformat',ctrl:'JC_PROVIDERPHONE',prop:'Titleformat'},{av:'edtJC_ProviderPhone_Title',ctrl:'JC_PROVIDERPHONE',prop:'Title'},{av:'edtJC_ProviderUser_Titleformat',ctrl:'JC_PROVIDERUSER',prop:'Titleformat'},{av:'edtJC_ProviderUser_Title',ctrl:'JC_PROVIDERUSER',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_JC_PROVIDERSHORTNAME.ONOPTIONCLICKED","{handler:'E158J2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_JC_ProviderIDTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_JC_ProviderShortNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_JC_ProviderAddresssTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_JC_ProviderPhoneTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_JC_ProviderUserTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_jc_providershortname_Activeeventkey',ctrl:'DDO_JC_PROVIDERSHORTNAME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_JC_PROVIDERSHORTNAME.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_jc_providershortname_Sortedstatus',ctrl:'DDO_JC_PROVIDERSHORTNAME',prop:'SortedStatus'},{av:'AV13JC_ProviderIDTitleFilterData',fld:'vJC_PROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV15JC_ProviderNameTitleFilterData',fld:'vJC_PROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV17JC_ProviderShortNameTitleFilterData',fld:'vJC_PROVIDERSHORTNAMETITLEFILTERDATA',pic:''},{av:'AV19JC_ProviderAddresssTitleFilterData',fld:'vJC_PROVIDERADDRESSSTITLEFILTERDATA',pic:''},{av:'AV21JC_ProviderPhoneTitleFilterData',fld:'vJC_PROVIDERPHONETITLEFILTERDATA',pic:''},{av:'AV23JC_ProviderUserTitleFilterData',fld:'vJC_PROVIDERUSERTITLEFILTERDATA',pic:''},{av:'edtJC_ProviderID_Titleformat',ctrl:'JC_PROVIDERID',prop:'Titleformat'},{av:'edtJC_ProviderID_Title',ctrl:'JC_PROVIDERID',prop:'Title'},{av:'edtJC_ProviderName_Titleformat',ctrl:'JC_PROVIDERNAME',prop:'Titleformat'},{av:'edtJC_ProviderName_Title',ctrl:'JC_PROVIDERNAME',prop:'Title'},{av:'edtJC_ProviderShortName_Titleformat',ctrl:'JC_PROVIDERSHORTNAME',prop:'Titleformat'},{av:'edtJC_ProviderShortName_Title',ctrl:'JC_PROVIDERSHORTNAME',prop:'Title'},{av:'edtJC_ProviderAddresss_Titleformat',ctrl:'JC_PROVIDERADDRESSS',prop:'Titleformat'},{av:'edtJC_ProviderAddresss_Title',ctrl:'JC_PROVIDERADDRESSS',prop:'Title'},{av:'edtJC_ProviderPhone_Titleformat',ctrl:'JC_PROVIDERPHONE',prop:'Titleformat'},{av:'edtJC_ProviderPhone_Title',ctrl:'JC_PROVIDERPHONE',prop:'Title'},{av:'edtJC_ProviderUser_Titleformat',ctrl:'JC_PROVIDERUSER',prop:'Titleformat'},{av:'edtJC_ProviderUser_Title',ctrl:'JC_PROVIDERUSER',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_JC_PROVIDERADDRESSS.ONOPTIONCLICKED","{handler:'E168J2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_JC_ProviderIDTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_JC_ProviderShortNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_JC_ProviderAddresssTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_JC_ProviderPhoneTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_JC_ProviderUserTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_jc_provideraddresss_Activeeventkey',ctrl:'DDO_JC_PROVIDERADDRESSS',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_JC_PROVIDERADDRESSS.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_jc_provideraddresss_Sortedstatus',ctrl:'DDO_JC_PROVIDERADDRESSS',prop:'SortedStatus'},{av:'AV13JC_ProviderIDTitleFilterData',fld:'vJC_PROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV15JC_ProviderNameTitleFilterData',fld:'vJC_PROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV17JC_ProviderShortNameTitleFilterData',fld:'vJC_PROVIDERSHORTNAMETITLEFILTERDATA',pic:''},{av:'AV19JC_ProviderAddresssTitleFilterData',fld:'vJC_PROVIDERADDRESSSTITLEFILTERDATA',pic:''},{av:'AV21JC_ProviderPhoneTitleFilterData',fld:'vJC_PROVIDERPHONETITLEFILTERDATA',pic:''},{av:'AV23JC_ProviderUserTitleFilterData',fld:'vJC_PROVIDERUSERTITLEFILTERDATA',pic:''},{av:'edtJC_ProviderID_Titleformat',ctrl:'JC_PROVIDERID',prop:'Titleformat'},{av:'edtJC_ProviderID_Title',ctrl:'JC_PROVIDERID',prop:'Title'},{av:'edtJC_ProviderName_Titleformat',ctrl:'JC_PROVIDERNAME',prop:'Titleformat'},{av:'edtJC_ProviderName_Title',ctrl:'JC_PROVIDERNAME',prop:'Title'},{av:'edtJC_ProviderShortName_Titleformat',ctrl:'JC_PROVIDERSHORTNAME',prop:'Titleformat'},{av:'edtJC_ProviderShortName_Title',ctrl:'JC_PROVIDERSHORTNAME',prop:'Title'},{av:'edtJC_ProviderAddresss_Titleformat',ctrl:'JC_PROVIDERADDRESSS',prop:'Titleformat'},{av:'edtJC_ProviderAddresss_Title',ctrl:'JC_PROVIDERADDRESSS',prop:'Title'},{av:'edtJC_ProviderPhone_Titleformat',ctrl:'JC_PROVIDERPHONE',prop:'Titleformat'},{av:'edtJC_ProviderPhone_Title',ctrl:'JC_PROVIDERPHONE',prop:'Title'},{av:'edtJC_ProviderUser_Titleformat',ctrl:'JC_PROVIDERUSER',prop:'Titleformat'},{av:'edtJC_ProviderUser_Title',ctrl:'JC_PROVIDERUSER',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_JC_PROVIDERPHONE.ONOPTIONCLICKED","{handler:'E178J2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_JC_ProviderIDTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_JC_ProviderShortNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_JC_ProviderAddresssTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_JC_ProviderPhoneTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_JC_ProviderUserTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_jc_providerphone_Activeeventkey',ctrl:'DDO_JC_PROVIDERPHONE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_JC_PROVIDERPHONE.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_jc_providerphone_Sortedstatus',ctrl:'DDO_JC_PROVIDERPHONE',prop:'SortedStatus'},{av:'AV13JC_ProviderIDTitleFilterData',fld:'vJC_PROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV15JC_ProviderNameTitleFilterData',fld:'vJC_PROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV17JC_ProviderShortNameTitleFilterData',fld:'vJC_PROVIDERSHORTNAMETITLEFILTERDATA',pic:''},{av:'AV19JC_ProviderAddresssTitleFilterData',fld:'vJC_PROVIDERADDRESSSTITLEFILTERDATA',pic:''},{av:'AV21JC_ProviderPhoneTitleFilterData',fld:'vJC_PROVIDERPHONETITLEFILTERDATA',pic:''},{av:'AV23JC_ProviderUserTitleFilterData',fld:'vJC_PROVIDERUSERTITLEFILTERDATA',pic:''},{av:'edtJC_ProviderID_Titleformat',ctrl:'JC_PROVIDERID',prop:'Titleformat'},{av:'edtJC_ProviderID_Title',ctrl:'JC_PROVIDERID',prop:'Title'},{av:'edtJC_ProviderName_Titleformat',ctrl:'JC_PROVIDERNAME',prop:'Titleformat'},{av:'edtJC_ProviderName_Title',ctrl:'JC_PROVIDERNAME',prop:'Title'},{av:'edtJC_ProviderShortName_Titleformat',ctrl:'JC_PROVIDERSHORTNAME',prop:'Titleformat'},{av:'edtJC_ProviderShortName_Title',ctrl:'JC_PROVIDERSHORTNAME',prop:'Title'},{av:'edtJC_ProviderAddresss_Titleformat',ctrl:'JC_PROVIDERADDRESSS',prop:'Titleformat'},{av:'edtJC_ProviderAddresss_Title',ctrl:'JC_PROVIDERADDRESSS',prop:'Title'},{av:'edtJC_ProviderPhone_Titleformat',ctrl:'JC_PROVIDERPHONE',prop:'Titleformat'},{av:'edtJC_ProviderPhone_Title',ctrl:'JC_PROVIDERPHONE',prop:'Title'},{av:'edtJC_ProviderUser_Titleformat',ctrl:'JC_PROVIDERUSER',prop:'Titleformat'},{av:'edtJC_ProviderUser_Title',ctrl:'JC_PROVIDERUSER',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_JC_PROVIDERUSER.ONOPTIONCLICKED","{handler:'E188J2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_JC_ProviderIDTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_JC_ProviderShortNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_JC_ProviderAddresssTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_JC_ProviderPhoneTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_JC_ProviderUserTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_jc_provideruser_Activeeventkey',ctrl:'DDO_JC_PROVIDERUSER',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_JC_PROVIDERUSER.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_jc_provideruser_Sortedstatus',ctrl:'DDO_JC_PROVIDERUSER',prop:'SortedStatus'},{av:'AV13JC_ProviderIDTitleFilterData',fld:'vJC_PROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV15JC_ProviderNameTitleFilterData',fld:'vJC_PROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV17JC_ProviderShortNameTitleFilterData',fld:'vJC_PROVIDERSHORTNAMETITLEFILTERDATA',pic:''},{av:'AV19JC_ProviderAddresssTitleFilterData',fld:'vJC_PROVIDERADDRESSSTITLEFILTERDATA',pic:''},{av:'AV21JC_ProviderPhoneTitleFilterData',fld:'vJC_PROVIDERPHONETITLEFILTERDATA',pic:''},{av:'AV23JC_ProviderUserTitleFilterData',fld:'vJC_PROVIDERUSERTITLEFILTERDATA',pic:''},{av:'edtJC_ProviderID_Titleformat',ctrl:'JC_PROVIDERID',prop:'Titleformat'},{av:'edtJC_ProviderID_Title',ctrl:'JC_PROVIDERID',prop:'Title'},{av:'edtJC_ProviderName_Titleformat',ctrl:'JC_PROVIDERNAME',prop:'Titleformat'},{av:'edtJC_ProviderName_Title',ctrl:'JC_PROVIDERNAME',prop:'Title'},{av:'edtJC_ProviderShortName_Titleformat',ctrl:'JC_PROVIDERSHORTNAME',prop:'Titleformat'},{av:'edtJC_ProviderShortName_Title',ctrl:'JC_PROVIDERSHORTNAME',prop:'Title'},{av:'edtJC_ProviderAddresss_Titleformat',ctrl:'JC_PROVIDERADDRESSS',prop:'Titleformat'},{av:'edtJC_ProviderAddresss_Title',ctrl:'JC_PROVIDERADDRESSS',prop:'Title'},{av:'edtJC_ProviderPhone_Titleformat',ctrl:'JC_PROVIDERPHONE',prop:'Titleformat'},{av:'edtJC_ProviderPhone_Title',ctrl:'JC_PROVIDERPHONE',prop:'Title'},{av:'edtJC_ProviderUser_Titleformat',ctrl:'JC_PROVIDERUSER',prop:'Titleformat'},{av:'edtJC_ProviderUser_Title',ctrl:'JC_PROVIDERUSER',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E218J2',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV30Select',fld:'vSELECT',pic:''},{av:'edtavSelect_Tooltiptext',ctrl:'vSELECT',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E228J2',iparms:[{av:'A87JC_ProviderID',fld:'JC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A89JC_ProviderName',fld:'JC_PROVIDERNAME',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV8InOutJC_ProviderID',fld:'vINOUTJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV9InOutJC_ProviderName',fld:'vINOUTJC_PROVIDERNAME',pic:''}]}");
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
         wcpOAV9InOutJC_ProviderName = "";
         Gridpaginationbar_Selectedpage = "";
         Ddo_jc_providerid_Activeeventkey = "";
         Ddo_jc_providername_Activeeventkey = "";
         Ddo_jc_providershortname_Activeeventkey = "";
         Ddo_jc_provideraddresss_Activeeventkey = "";
         Ddo_jc_providerphone_Activeeventkey = "";
         Ddo_jc_provideruser_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV14ddo_JC_ProviderIDTitleControlIdToReplace = "";
         AV16ddo_JC_ProviderNameTitleControlIdToReplace = "";
         AV18ddo_JC_ProviderShortNameTitleControlIdToReplace = "";
         AV20ddo_JC_ProviderAddresssTitleControlIdToReplace = "";
         AV22ddo_JC_ProviderPhoneTitleControlIdToReplace = "";
         AV24ddo_JC_ProviderUserTitleControlIdToReplace = "";
         GXKey = "";
         AV33Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV25DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV13JC_ProviderIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15JC_ProviderNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17JC_ProviderShortNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19JC_ProviderAddresssTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21JC_ProviderPhoneTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV23JC_ProviderUserTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_jc_providerid_Sortedstatus = "";
         Ddo_jc_providername_Sortedstatus = "";
         Ddo_jc_providershortname_Sortedstatus = "";
         Ddo_jc_provideraddresss_Sortedstatus = "";
         Ddo_jc_providerphone_Sortedstatus = "";
         Ddo_jc_provideruser_Sortedstatus = "";
         GX_FocusControl = "";
         sPrefix = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV30Select = "";
         A89JC_ProviderName = "";
         A160JC_ProviderShortName = "";
         A161JC_ProviderAddresss = "";
         A162JC_ProviderPhone = "";
         A163JC_ProviderUser = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_jc_providerid = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_jc_providername = new GXUserControl();
         ucDdo_jc_providershortname = new GXUserControl();
         ucDdo_jc_provideraddresss = new GXUserControl();
         ucDdo_jc_providerphone = new GXUserControl();
         ucDdo_jc_provideruser = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV34Select_GXI = "";
         scmdbuf = "";
         H008J2_A163JC_ProviderUser = new String[] {""} ;
         H008J2_n163JC_ProviderUser = new bool[] {false} ;
         H008J2_A162JC_ProviderPhone = new String[] {""} ;
         H008J2_n162JC_ProviderPhone = new bool[] {false} ;
         H008J2_A161JC_ProviderAddresss = new String[] {""} ;
         H008J2_n161JC_ProviderAddresss = new bool[] {false} ;
         H008J2_A160JC_ProviderShortName = new String[] {""} ;
         H008J2_n160JC_ProviderShortName = new bool[] {false} ;
         H008J2_A89JC_ProviderName = new String[] {""} ;
         H008J2_n89JC_ProviderName = new bool[] {false} ;
         H008J2_A87JC_ProviderID = new long[1] ;
         H008J3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         gxphoneLink = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.jc_providerprompt__default(),
            new Object[][] {
                new Object[] {
               H008J2_A163JC_ProviderUser, H008J2_n163JC_ProviderUser, H008J2_A162JC_ProviderPhone, H008J2_n162JC_ProviderPhone, H008J2_A161JC_ProviderAddresss, H008J2_n161JC_ProviderAddresss, H008J2_A160JC_ProviderShortName, H008J2_n160JC_ProviderShortName, H008J2_A89JC_ProviderName, H008J2_n89JC_ProviderName,
               H008J2_A87JC_ProviderID
               }
               , new Object[] {
               H008J3_AGRID_nRecordCount
               }
            }
         );
         AV33Pgmname = "JC_ProviderPrompt";
         /* GeneXus formulas. */
         AV33Pgmname = "JC_ProviderPrompt";
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
      private short edtJC_ProviderID_Titleformat ;
      private short edtJC_ProviderName_Titleformat ;
      private short edtJC_ProviderShortName_Titleformat ;
      private short edtJC_ProviderAddresss_Titleformat ;
      private short edtJC_ProviderPhone_Titleformat ;
      private short edtJC_ProviderUser_Titleformat ;
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
      private int edtavDdo_jc_provideridtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_jc_providernametitlecontrolidtoreplace_Visible ;
      private int edtavDdo_jc_providershortnametitlecontrolidtoreplace_Visible ;
      private int edtavDdo_jc_provideraddressstitlecontrolidtoreplace_Visible ;
      private int edtavDdo_jc_providerphonetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_jc_providerusertitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV26PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavSelect_Enabled ;
      private int edtavSelect_Visible ;
      private long AV8InOutJC_ProviderID ;
      private long wcpOAV8InOutJC_ProviderID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV27GridCurrentPage ;
      private long AV29GridRecordCount ;
      private long AV28GridPageSize ;
      private long A87JC_ProviderID ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_jc_providerid_Activeeventkey ;
      private String Ddo_jc_providername_Activeeventkey ;
      private String Ddo_jc_providershortname_Activeeventkey ;
      private String Ddo_jc_provideraddresss_Activeeventkey ;
      private String Ddo_jc_providerphone_Activeeventkey ;
      private String Ddo_jc_provideruser_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_12_idx="0001" ;
      private String GXKey ;
      private String AV33Pgmname ;
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
      private String Ddo_jc_providerid_Caption ;
      private String Ddo_jc_providerid_Tooltip ;
      private String Ddo_jc_providerid_Cls ;
      private String Ddo_jc_providerid_Dropdownoptionstype ;
      private String Ddo_jc_providerid_Titlecontrolidtoreplace ;
      private String Ddo_jc_providerid_Sortedstatus ;
      private String Ddo_jc_providerid_Sortasc ;
      private String Ddo_jc_providerid_Sortdsc ;
      private String Ddo_jc_providerid_Searchbuttontext ;
      private String Ddo_jc_providername_Caption ;
      private String Ddo_jc_providername_Tooltip ;
      private String Ddo_jc_providername_Cls ;
      private String Ddo_jc_providername_Dropdownoptionstype ;
      private String Ddo_jc_providername_Titlecontrolidtoreplace ;
      private String Ddo_jc_providername_Sortedstatus ;
      private String Ddo_jc_providername_Sortasc ;
      private String Ddo_jc_providername_Sortdsc ;
      private String Ddo_jc_providername_Searchbuttontext ;
      private String Ddo_jc_providershortname_Caption ;
      private String Ddo_jc_providershortname_Tooltip ;
      private String Ddo_jc_providershortname_Cls ;
      private String Ddo_jc_providershortname_Dropdownoptionstype ;
      private String Ddo_jc_providershortname_Titlecontrolidtoreplace ;
      private String Ddo_jc_providershortname_Sortedstatus ;
      private String Ddo_jc_providershortname_Sortasc ;
      private String Ddo_jc_providershortname_Sortdsc ;
      private String Ddo_jc_providershortname_Searchbuttontext ;
      private String Ddo_jc_provideraddresss_Caption ;
      private String Ddo_jc_provideraddresss_Tooltip ;
      private String Ddo_jc_provideraddresss_Cls ;
      private String Ddo_jc_provideraddresss_Dropdownoptionstype ;
      private String Ddo_jc_provideraddresss_Titlecontrolidtoreplace ;
      private String Ddo_jc_provideraddresss_Sortedstatus ;
      private String Ddo_jc_provideraddresss_Sortasc ;
      private String Ddo_jc_provideraddresss_Sortdsc ;
      private String Ddo_jc_provideraddresss_Searchbuttontext ;
      private String Ddo_jc_providerphone_Caption ;
      private String Ddo_jc_providerphone_Tooltip ;
      private String Ddo_jc_providerphone_Cls ;
      private String Ddo_jc_providerphone_Dropdownoptionstype ;
      private String Ddo_jc_providerphone_Titlecontrolidtoreplace ;
      private String Ddo_jc_providerphone_Sortedstatus ;
      private String Ddo_jc_providerphone_Sortasc ;
      private String Ddo_jc_providerphone_Sortdsc ;
      private String Ddo_jc_providerphone_Searchbuttontext ;
      private String Ddo_jc_provideruser_Caption ;
      private String Ddo_jc_provideruser_Tooltip ;
      private String Ddo_jc_provideruser_Cls ;
      private String Ddo_jc_provideruser_Dropdownoptionstype ;
      private String Ddo_jc_provideruser_Titlecontrolidtoreplace ;
      private String Ddo_jc_provideruser_Sortedstatus ;
      private String Ddo_jc_provideruser_Sortasc ;
      private String Ddo_jc_provideruser_Sortdsc ;
      private String Ddo_jc_provideruser_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtJC_ProviderID_Title ;
      private String edtJC_ProviderName_Title ;
      private String edtJC_ProviderShortName_Title ;
      private String edtJC_ProviderAddresss_Title ;
      private String edtJC_ProviderPhone_Title ;
      private String edtJC_ProviderUser_Title ;
      private String subGrid_Header ;
      private String edtavSelect_Tooltiptext ;
      private String A162JC_ProviderPhone ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_jc_providerid_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_jc_provideridtitlecontrolidtoreplace_Internalname ;
      private String Ddo_jc_providername_Internalname ;
      private String edtavDdo_jc_providernametitlecontrolidtoreplace_Internalname ;
      private String Ddo_jc_providershortname_Internalname ;
      private String edtavDdo_jc_providershortnametitlecontrolidtoreplace_Internalname ;
      private String Ddo_jc_provideraddresss_Internalname ;
      private String edtavDdo_jc_provideraddressstitlecontrolidtoreplace_Internalname ;
      private String Ddo_jc_providerphone_Internalname ;
      private String edtavDdo_jc_providerphonetitlecontrolidtoreplace_Internalname ;
      private String Ddo_jc_provideruser_Internalname ;
      private String edtavDdo_jc_providerusertitlecontrolidtoreplace_Internalname ;
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
      private String edtJC_ProviderID_Internalname ;
      private String edtJC_ProviderName_Internalname ;
      private String edtJC_ProviderShortName_Internalname ;
      private String edtJC_ProviderAddresss_Internalname ;
      private String edtJC_ProviderPhone_Internalname ;
      private String edtJC_ProviderUser_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_12_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavSelect_Jsonclick ;
      private String ROClassString ;
      private String edtJC_ProviderID_Jsonclick ;
      private String edtJC_ProviderName_Jsonclick ;
      private String edtJC_ProviderShortName_Jsonclick ;
      private String edtJC_ProviderAddresss_Jsonclick ;
      private String gxphoneLink ;
      private String edtJC_ProviderPhone_Jsonclick ;
      private String edtJC_ProviderUser_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV12OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_jc_providerid_Includesortasc ;
      private bool Ddo_jc_providerid_Includesortdsc ;
      private bool Ddo_jc_providerid_Includefilter ;
      private bool Ddo_jc_providerid_Includedatalist ;
      private bool Ddo_jc_providername_Includesortasc ;
      private bool Ddo_jc_providername_Includesortdsc ;
      private bool Ddo_jc_providername_Includefilter ;
      private bool Ddo_jc_providername_Includedatalist ;
      private bool Ddo_jc_providershortname_Includesortasc ;
      private bool Ddo_jc_providershortname_Includesortdsc ;
      private bool Ddo_jc_providershortname_Includefilter ;
      private bool Ddo_jc_providershortname_Includedatalist ;
      private bool Ddo_jc_provideraddresss_Includesortasc ;
      private bool Ddo_jc_provideraddresss_Includesortdsc ;
      private bool Ddo_jc_provideraddresss_Includefilter ;
      private bool Ddo_jc_provideraddresss_Includedatalist ;
      private bool Ddo_jc_providerphone_Includesortasc ;
      private bool Ddo_jc_providerphone_Includesortdsc ;
      private bool Ddo_jc_providerphone_Includefilter ;
      private bool Ddo_jc_providerphone_Includedatalist ;
      private bool Ddo_jc_provideruser_Includesortasc ;
      private bool Ddo_jc_provideruser_Includesortdsc ;
      private bool Ddo_jc_provideruser_Includefilter ;
      private bool Ddo_jc_provideruser_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_12_Refreshing=false ;
      private bool n89JC_ProviderName ;
      private bool n160JC_ProviderShortName ;
      private bool n161JC_ProviderAddresss ;
      private bool n162JC_ProviderPhone ;
      private bool n163JC_ProviderUser ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool gx_refresh_fired ;
      private bool AV30Select_IsBlob ;
      private String AV9InOutJC_ProviderName ;
      private String wcpOAV9InOutJC_ProviderName ;
      private String AV14ddo_JC_ProviderIDTitleControlIdToReplace ;
      private String AV16ddo_JC_ProviderNameTitleControlIdToReplace ;
      private String AV18ddo_JC_ProviderShortNameTitleControlIdToReplace ;
      private String AV20ddo_JC_ProviderAddresssTitleControlIdToReplace ;
      private String AV22ddo_JC_ProviderPhoneTitleControlIdToReplace ;
      private String AV24ddo_JC_ProviderUserTitleControlIdToReplace ;
      private String A89JC_ProviderName ;
      private String A160JC_ProviderShortName ;
      private String A161JC_ProviderAddresss ;
      private String A163JC_ProviderUser ;
      private String AV34Select_GXI ;
      private String AV30Select ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_jc_providerid ;
      private GXUserControl ucDdo_jc_providername ;
      private GXUserControl ucDdo_jc_providershortname ;
      private GXUserControl ucDdo_jc_provideraddresss ;
      private GXUserControl ucDdo_jc_providerphone ;
      private GXUserControl ucDdo_jc_provideruser ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private long aP0_InOutJC_ProviderID ;
      private String aP1_InOutJC_ProviderName ;
      private IDataStoreProvider pr_default ;
      private String[] H008J2_A163JC_ProviderUser ;
      private bool[] H008J2_n163JC_ProviderUser ;
      private String[] H008J2_A162JC_ProviderPhone ;
      private bool[] H008J2_n162JC_ProviderPhone ;
      private String[] H008J2_A161JC_ProviderAddresss ;
      private bool[] H008J2_n161JC_ProviderAddresss ;
      private String[] H008J2_A160JC_ProviderShortName ;
      private bool[] H008J2_n160JC_ProviderShortName ;
      private String[] H008J2_A89JC_ProviderName ;
      private bool[] H008J2_n89JC_ProviderName ;
      private long[] H008J2_A87JC_ProviderID ;
      private long[] H008J3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV13JC_ProviderIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV15JC_ProviderNameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV17JC_ProviderShortNameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV19JC_ProviderAddresssTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV21JC_ProviderPhoneTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV23JC_ProviderUserTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV25DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class jc_providerprompt__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H008J2( IGxContext context ,
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
         sSelectString = " [JC_ProviderUser], [JC_ProviderPhone], [JC_ProviderAddresss], [JC_ProviderShortName], [JC_ProviderName], [JC_ProviderID]";
         sFromString = " FROM [JC_Provider] WITH (NOLOCK)";
         sOrderString = "";
         if ( ( AV11OrderedBy == 1 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [JC_ProviderID]";
         }
         else if ( ( AV11OrderedBy == 1 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [JC_ProviderID] DESC";
         }
         else if ( ( AV11OrderedBy == 2 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [JC_ProviderName]";
         }
         else if ( ( AV11OrderedBy == 2 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [JC_ProviderName] DESC";
         }
         else if ( ( AV11OrderedBy == 3 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [JC_ProviderShortName]";
         }
         else if ( ( AV11OrderedBy == 3 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [JC_ProviderShortName] DESC";
         }
         else if ( ( AV11OrderedBy == 4 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [JC_ProviderAddresss]";
         }
         else if ( ( AV11OrderedBy == 4 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [JC_ProviderAddresss] DESC";
         }
         else if ( ( AV11OrderedBy == 5 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [JC_ProviderPhone]";
         }
         else if ( ( AV11OrderedBy == 5 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [JC_ProviderPhone] DESC";
         }
         else if ( ( AV11OrderedBy == 6 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [JC_ProviderUser]";
         }
         else if ( ( AV11OrderedBy == 6 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [JC_ProviderUser] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [JC_ProviderID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H008J3( IGxContext context ,
                                             short AV11OrderedBy ,
                                             bool AV12OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [JC_Provider] WITH (NOLOCK)";
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
                     return conditional_H008J2(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
               case 1 :
                     return conditional_H008J3(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
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
          Object[] prmH008J2 ;
          prmH008J2 = new Object[] {
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH008J3 ;
          prmH008J3 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H008J2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH008J2,11,0,true,false )
             ,new CursorDef("H008J3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH008J3,1,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getString(2, 20) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((long[]) buf[10])[0] = rslt.getLong(6) ;
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
