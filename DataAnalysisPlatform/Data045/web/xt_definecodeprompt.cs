/*
               File: XT_DefineCodePrompt
        Description: 选择数据字典数据
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:9:36.13
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
   public class xt_definecodeprompt : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public xt_definecodeprompt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public xt_definecodeprompt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_InOutXT_DefineCodeID ,
                           ref String aP1_InOutXT_DefineCodeName )
      {
         this.AV8InOutXT_DefineCodeID = aP0_InOutXT_DefineCodeID;
         this.AV9InOutXT_DefineCodeName = aP1_InOutXT_DefineCodeName;
         executePrivate();
         aP0_InOutXT_DefineCodeID=this.AV8InOutXT_DefineCodeID;
         aP1_InOutXT_DefineCodeName=this.AV9InOutXT_DefineCodeName;
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
               AV14ddo_XT_DefineCodeIDTitleControlIdToReplace = GetNextPar( );
               AV16ddo_XT_DefineCodeNameTitleControlIdToReplace = GetNextPar( );
               AV18ddo_XT_DefindcodeTypeIDTitleControlIdToReplace = GetNextPar( );
               AV20ddo_XT_DefindcodeTypeNameTitleControlIdToReplace = GetNextPar( );
               AV28ddo_XT_DefineCodeOrderTitleControlIdToReplace = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_XT_DefineCodeIDTitleControlIdToReplace, AV16ddo_XT_DefineCodeNameTitleControlIdToReplace, AV18ddo_XT_DefindcodeTypeIDTitleControlIdToReplace, AV20ddo_XT_DefindcodeTypeNameTitleControlIdToReplace, AV28ddo_XT_DefineCodeOrderTitleControlIdToReplace) ;
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
               AV8InOutXT_DefineCodeID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutXT_DefineCodeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutXT_DefineCodeID), 18, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV9InOutXT_DefineCodeName = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutXT_DefineCodeName", AV9InOutXT_DefineCodeName);
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
            PA2H2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV31Pgmname = "XT_DefineCodePrompt";
               context.Gx_err = 0;
               WS2H2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE2H2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202281593623", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("xt_definecodeprompt.aspx") + "?" + UrlEncode("" +AV8InOutXT_DefineCodeID) + "," + UrlEncode(StringUtil.RTrim(AV9InOutXT_DefineCodeName))+"\">") ;
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_DEFINECODEIDTITLEFILTERDATA", AV13XT_DefineCodeIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_DEFINECODEIDTITLEFILTERDATA", AV13XT_DefineCodeIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_DEFINECODENAMETITLEFILTERDATA", AV15XT_DefineCodeNameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_DEFINECODENAMETITLEFILTERDATA", AV15XT_DefineCodeNameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_DEFINDCODETYPEIDTITLEFILTERDATA", AV17XT_DefindcodeTypeIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_DEFINDCODETYPEIDTITLEFILTERDATA", AV17XT_DefindcodeTypeIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_DEFINDCODETYPENAMETITLEFILTERDATA", AV19XT_DefindcodeTypeNameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_DEFINDCODETYPENAMETITLEFILTERDATA", AV19XT_DefindcodeTypeNameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_DEFINECODEORDERTITLEFILTERDATA", AV27XT_DefineCodeOrderTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_DEFINECODEORDERTITLEFILTERDATA", AV27XT_DefineCodeOrderTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vINOUTXT_DEFINECODEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8InOutXT_DefineCodeID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINOUTXT_DEFINECODENAME", AV9InOutXT_DefineCodeName);
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
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODEID_Caption", StringUtil.RTrim( Ddo_xt_definecodeid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODEID_Tooltip", StringUtil.RTrim( Ddo_xt_definecodeid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODEID_Cls", StringUtil.RTrim( Ddo_xt_definecodeid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODEID_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_definecodeid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODEID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_definecodeid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODEID_Includesortasc", StringUtil.BoolToStr( Ddo_xt_definecodeid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODEID_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_definecodeid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODEID_Sortedstatus", StringUtil.RTrim( Ddo_xt_definecodeid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODEID_Includefilter", StringUtil.BoolToStr( Ddo_xt_definecodeid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODEID_Includedatalist", StringUtil.BoolToStr( Ddo_xt_definecodeid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODEID_Sortasc", StringUtil.RTrim( Ddo_xt_definecodeid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODEID_Sortdsc", StringUtil.RTrim( Ddo_xt_definecodeid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODEID_Searchbuttontext", StringUtil.RTrim( Ddo_xt_definecodeid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODENAME_Caption", StringUtil.RTrim( Ddo_xt_definecodename_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODENAME_Tooltip", StringUtil.RTrim( Ddo_xt_definecodename_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODENAME_Cls", StringUtil.RTrim( Ddo_xt_definecodename_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODENAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_definecodename_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODENAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_definecodename_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODENAME_Includesortasc", StringUtil.BoolToStr( Ddo_xt_definecodename_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODENAME_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_definecodename_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODENAME_Sortedstatus", StringUtil.RTrim( Ddo_xt_definecodename_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODENAME_Includefilter", StringUtil.BoolToStr( Ddo_xt_definecodename_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODENAME_Includedatalist", StringUtil.BoolToStr( Ddo_xt_definecodename_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODENAME_Sortasc", StringUtil.RTrim( Ddo_xt_definecodename_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODENAME_Sortdsc", StringUtil.RTrim( Ddo_xt_definecodename_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODENAME_Searchbuttontext", StringUtil.RTrim( Ddo_xt_definecodename_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPEID_Caption", StringUtil.RTrim( Ddo_xt_defindcodetypeid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPEID_Tooltip", StringUtil.RTrim( Ddo_xt_defindcodetypeid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPEID_Cls", StringUtil.RTrim( Ddo_xt_defindcodetypeid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPEID_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_defindcodetypeid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPEID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_defindcodetypeid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPEID_Includesortasc", StringUtil.BoolToStr( Ddo_xt_defindcodetypeid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPEID_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_defindcodetypeid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPEID_Sortedstatus", StringUtil.RTrim( Ddo_xt_defindcodetypeid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPEID_Includefilter", StringUtil.BoolToStr( Ddo_xt_defindcodetypeid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPEID_Includedatalist", StringUtil.BoolToStr( Ddo_xt_defindcodetypeid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPEID_Sortasc", StringUtil.RTrim( Ddo_xt_defindcodetypeid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPEID_Sortdsc", StringUtil.RTrim( Ddo_xt_defindcodetypeid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPEID_Searchbuttontext", StringUtil.RTrim( Ddo_xt_defindcodetypeid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPENAME_Caption", StringUtil.RTrim( Ddo_xt_defindcodetypename_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPENAME_Tooltip", StringUtil.RTrim( Ddo_xt_defindcodetypename_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPENAME_Cls", StringUtil.RTrim( Ddo_xt_defindcodetypename_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPENAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_defindcodetypename_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPENAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_defindcodetypename_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPENAME_Includesortasc", StringUtil.BoolToStr( Ddo_xt_defindcodetypename_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPENAME_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_defindcodetypename_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPENAME_Sortedstatus", StringUtil.RTrim( Ddo_xt_defindcodetypename_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPENAME_Includefilter", StringUtil.BoolToStr( Ddo_xt_defindcodetypename_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPENAME_Includedatalist", StringUtil.BoolToStr( Ddo_xt_defindcodetypename_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPENAME_Sortasc", StringUtil.RTrim( Ddo_xt_defindcodetypename_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPENAME_Sortdsc", StringUtil.RTrim( Ddo_xt_defindcodetypename_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPENAME_Searchbuttontext", StringUtil.RTrim( Ddo_xt_defindcodetypename_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODEORDER_Caption", StringUtil.RTrim( Ddo_xt_definecodeorder_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODEORDER_Tooltip", StringUtil.RTrim( Ddo_xt_definecodeorder_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODEORDER_Cls", StringUtil.RTrim( Ddo_xt_definecodeorder_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODEORDER_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_definecodeorder_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODEORDER_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_definecodeorder_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODEORDER_Includesortasc", StringUtil.BoolToStr( Ddo_xt_definecodeorder_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODEORDER_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_definecodeorder_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODEORDER_Sortedstatus", StringUtil.RTrim( Ddo_xt_definecodeorder_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODEORDER_Includefilter", StringUtil.BoolToStr( Ddo_xt_definecodeorder_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODEORDER_Includedatalist", StringUtil.BoolToStr( Ddo_xt_definecodeorder_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODEORDER_Sortasc", StringUtil.RTrim( Ddo_xt_definecodeorder_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODEORDER_Sortdsc", StringUtil.RTrim( Ddo_xt_definecodeorder_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODEORDER_Searchbuttontext", StringUtil.RTrim( Ddo_xt_definecodeorder_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODEID_Activeeventkey", StringUtil.RTrim( Ddo_xt_definecodeid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODENAME_Activeeventkey", StringUtil.RTrim( Ddo_xt_definecodename_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPEID_Activeeventkey", StringUtil.RTrim( Ddo_xt_defindcodetypeid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPENAME_Activeeventkey", StringUtil.RTrim( Ddo_xt_defindcodetypename_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODEORDER_Activeeventkey", StringUtil.RTrim( Ddo_xt_definecodeorder_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODEID_Activeeventkey", StringUtil.RTrim( Ddo_xt_definecodeid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODENAME_Activeeventkey", StringUtil.RTrim( Ddo_xt_definecodename_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPEID_Activeeventkey", StringUtil.RTrim( Ddo_xt_defindcodetypeid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPENAME_Activeeventkey", StringUtil.RTrim( Ddo_xt_defindcodetypename_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODEORDER_Activeeventkey", StringUtil.RTrim( Ddo_xt_definecodeorder_Activeeventkey));
      }

      protected void RenderHtmlCloseForm2H2( )
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
         return "XT_DefineCodePrompt" ;
      }

      public override String GetPgmdesc( )
      {
         return "选择数据字典数据" ;
      }

      protected void WB2H0( )
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
               if ( edtXT_DefineCodeID_Titleformat == 0 )
               {
                  context.SendWebValue( edtXT_DefineCodeID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtXT_DefineCodeID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtXT_DefineCodeName_Titleformat == 0 )
               {
                  context.SendWebValue( edtXT_DefineCodeName_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtXT_DefineCodeName_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtXT_DefindcodeTypeID_Titleformat == 0 )
               {
                  context.SendWebValue( edtXT_DefindcodeTypeID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtXT_DefindcodeTypeID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtXT_DefindcodeTypeName_Titleformat == 0 )
               {
                  context.SendWebValue( edtXT_DefindcodeTypeName_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtXT_DefindcodeTypeName_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtXT_DefineCodeOrder_Titleformat == 0 )
               {
                  context.SendWebValue( edtXT_DefineCodeOrder_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtXT_DefineCodeOrder_Title) ;
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
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A167XT_DefineCodeID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtXT_DefineCodeID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtXT_DefineCodeID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A168XT_DefineCodeName);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtXT_DefineCodeName_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtXT_DefineCodeName_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A165XT_DefindcodeTypeID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtXT_DefindcodeTypeID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtXT_DefindcodeTypeID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A166XT_DefindcodeTypeName);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtXT_DefindcodeTypeName_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtXT_DefindcodeTypeName_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A171XT_DefineCodeOrder), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtXT_DefineCodeOrder_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtXT_DefineCodeOrder_Titleformat), 4, 0, ".", "")));
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
            ucDdo_xt_definecodeid.SetProperty("Caption", Ddo_xt_definecodeid_Caption);
            ucDdo_xt_definecodeid.SetProperty("Tooltip", Ddo_xt_definecodeid_Tooltip);
            ucDdo_xt_definecodeid.SetProperty("Cls", Ddo_xt_definecodeid_Cls);
            ucDdo_xt_definecodeid.SetProperty("DropDownOptionsType", Ddo_xt_definecodeid_Dropdownoptionstype);
            ucDdo_xt_definecodeid.SetProperty("IncludeSortASC", Ddo_xt_definecodeid_Includesortasc);
            ucDdo_xt_definecodeid.SetProperty("IncludeSortDSC", Ddo_xt_definecodeid_Includesortdsc);
            ucDdo_xt_definecodeid.SetProperty("IncludeFilter", Ddo_xt_definecodeid_Includefilter);
            ucDdo_xt_definecodeid.SetProperty("IncludeDataList", Ddo_xt_definecodeid_Includedatalist);
            ucDdo_xt_definecodeid.SetProperty("SortASC", Ddo_xt_definecodeid_Sortasc);
            ucDdo_xt_definecodeid.SetProperty("SortDSC", Ddo_xt_definecodeid_Sortdsc);
            ucDdo_xt_definecodeid.SetProperty("SearchButtonText", Ddo_xt_definecodeid_Searchbuttontext);
            ucDdo_xt_definecodeid.SetProperty("DropDownOptionsTitleSettingsIcons", AV21DDO_TitleSettingsIcons);
            ucDdo_xt_definecodeid.SetProperty("DropDownOptionsData", AV13XT_DefineCodeIDTitleFilterData);
            ucDdo_xt_definecodeid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_definecodeid_Internalname, "DDO_XT_DEFINECODEIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_definecodeidtitlecontrolidtoreplace_Internalname, AV14ddo_XT_DefineCodeIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,27);\"", 0, edtavDdo_xt_definecodeidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_DefineCodePrompt.htm");
            /* User Defined Control */
            ucDdo_xt_definecodename.SetProperty("Caption", Ddo_xt_definecodename_Caption);
            ucDdo_xt_definecodename.SetProperty("Tooltip", Ddo_xt_definecodename_Tooltip);
            ucDdo_xt_definecodename.SetProperty("Cls", Ddo_xt_definecodename_Cls);
            ucDdo_xt_definecodename.SetProperty("DropDownOptionsType", Ddo_xt_definecodename_Dropdownoptionstype);
            ucDdo_xt_definecodename.SetProperty("IncludeSortASC", Ddo_xt_definecodename_Includesortasc);
            ucDdo_xt_definecodename.SetProperty("IncludeSortDSC", Ddo_xt_definecodename_Includesortdsc);
            ucDdo_xt_definecodename.SetProperty("IncludeFilter", Ddo_xt_definecodename_Includefilter);
            ucDdo_xt_definecodename.SetProperty("IncludeDataList", Ddo_xt_definecodename_Includedatalist);
            ucDdo_xt_definecodename.SetProperty("SortASC", Ddo_xt_definecodename_Sortasc);
            ucDdo_xt_definecodename.SetProperty("SortDSC", Ddo_xt_definecodename_Sortdsc);
            ucDdo_xt_definecodename.SetProperty("SearchButtonText", Ddo_xt_definecodename_Searchbuttontext);
            ucDdo_xt_definecodename.SetProperty("DropDownOptionsTitleSettingsIcons", AV21DDO_TitleSettingsIcons);
            ucDdo_xt_definecodename.SetProperty("DropDownOptionsData", AV15XT_DefineCodeNameTitleFilterData);
            ucDdo_xt_definecodename.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_definecodename_Internalname, "DDO_XT_DEFINECODENAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_definecodenametitlecontrolidtoreplace_Internalname, AV16ddo_XT_DefineCodeNameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", 0, edtavDdo_xt_definecodenametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_DefineCodePrompt.htm");
            /* User Defined Control */
            ucDdo_xt_defindcodetypeid.SetProperty("Caption", Ddo_xt_defindcodetypeid_Caption);
            ucDdo_xt_defindcodetypeid.SetProperty("Tooltip", Ddo_xt_defindcodetypeid_Tooltip);
            ucDdo_xt_defindcodetypeid.SetProperty("Cls", Ddo_xt_defindcodetypeid_Cls);
            ucDdo_xt_defindcodetypeid.SetProperty("DropDownOptionsType", Ddo_xt_defindcodetypeid_Dropdownoptionstype);
            ucDdo_xt_defindcodetypeid.SetProperty("IncludeSortASC", Ddo_xt_defindcodetypeid_Includesortasc);
            ucDdo_xt_defindcodetypeid.SetProperty("IncludeSortDSC", Ddo_xt_defindcodetypeid_Includesortdsc);
            ucDdo_xt_defindcodetypeid.SetProperty("IncludeFilter", Ddo_xt_defindcodetypeid_Includefilter);
            ucDdo_xt_defindcodetypeid.SetProperty("IncludeDataList", Ddo_xt_defindcodetypeid_Includedatalist);
            ucDdo_xt_defindcodetypeid.SetProperty("SortASC", Ddo_xt_defindcodetypeid_Sortasc);
            ucDdo_xt_defindcodetypeid.SetProperty("SortDSC", Ddo_xt_defindcodetypeid_Sortdsc);
            ucDdo_xt_defindcodetypeid.SetProperty("SearchButtonText", Ddo_xt_defindcodetypeid_Searchbuttontext);
            ucDdo_xt_defindcodetypeid.SetProperty("DropDownOptionsTitleSettingsIcons", AV21DDO_TitleSettingsIcons);
            ucDdo_xt_defindcodetypeid.SetProperty("DropDownOptionsData", AV17XT_DefindcodeTypeIDTitleFilterData);
            ucDdo_xt_defindcodetypeid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_defindcodetypeid_Internalname, "DDO_XT_DEFINDCODETYPEIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_defindcodetypeidtitlecontrolidtoreplace_Internalname, AV18ddo_XT_DefindcodeTypeIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,31);\"", 0, edtavDdo_xt_defindcodetypeidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_DefineCodePrompt.htm");
            /* User Defined Control */
            ucDdo_xt_defindcodetypename.SetProperty("Caption", Ddo_xt_defindcodetypename_Caption);
            ucDdo_xt_defindcodetypename.SetProperty("Tooltip", Ddo_xt_defindcodetypename_Tooltip);
            ucDdo_xt_defindcodetypename.SetProperty("Cls", Ddo_xt_defindcodetypename_Cls);
            ucDdo_xt_defindcodetypename.SetProperty("DropDownOptionsType", Ddo_xt_defindcodetypename_Dropdownoptionstype);
            ucDdo_xt_defindcodetypename.SetProperty("IncludeSortASC", Ddo_xt_defindcodetypename_Includesortasc);
            ucDdo_xt_defindcodetypename.SetProperty("IncludeSortDSC", Ddo_xt_defindcodetypename_Includesortdsc);
            ucDdo_xt_defindcodetypename.SetProperty("IncludeFilter", Ddo_xt_defindcodetypename_Includefilter);
            ucDdo_xt_defindcodetypename.SetProperty("IncludeDataList", Ddo_xt_defindcodetypename_Includedatalist);
            ucDdo_xt_defindcodetypename.SetProperty("SortASC", Ddo_xt_defindcodetypename_Sortasc);
            ucDdo_xt_defindcodetypename.SetProperty("SortDSC", Ddo_xt_defindcodetypename_Sortdsc);
            ucDdo_xt_defindcodetypename.SetProperty("SearchButtonText", Ddo_xt_defindcodetypename_Searchbuttontext);
            ucDdo_xt_defindcodetypename.SetProperty("DropDownOptionsTitleSettingsIcons", AV21DDO_TitleSettingsIcons);
            ucDdo_xt_defindcodetypename.SetProperty("DropDownOptionsData", AV19XT_DefindcodeTypeNameTitleFilterData);
            ucDdo_xt_defindcodetypename.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_defindcodetypename_Internalname, "DDO_XT_DEFINDCODETYPENAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_defindcodetypenametitlecontrolidtoreplace_Internalname, AV20ddo_XT_DefindcodeTypeNameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", 0, edtavDdo_xt_defindcodetypenametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_DefineCodePrompt.htm");
            /* User Defined Control */
            ucDdo_xt_definecodeorder.SetProperty("Caption", Ddo_xt_definecodeorder_Caption);
            ucDdo_xt_definecodeorder.SetProperty("Tooltip", Ddo_xt_definecodeorder_Tooltip);
            ucDdo_xt_definecodeorder.SetProperty("Cls", Ddo_xt_definecodeorder_Cls);
            ucDdo_xt_definecodeorder.SetProperty("DropDownOptionsType", Ddo_xt_definecodeorder_Dropdownoptionstype);
            ucDdo_xt_definecodeorder.SetProperty("IncludeSortASC", Ddo_xt_definecodeorder_Includesortasc);
            ucDdo_xt_definecodeorder.SetProperty("IncludeSortDSC", Ddo_xt_definecodeorder_Includesortdsc);
            ucDdo_xt_definecodeorder.SetProperty("IncludeFilter", Ddo_xt_definecodeorder_Includefilter);
            ucDdo_xt_definecodeorder.SetProperty("IncludeDataList", Ddo_xt_definecodeorder_Includedatalist);
            ucDdo_xt_definecodeorder.SetProperty("SortASC", Ddo_xt_definecodeorder_Sortasc);
            ucDdo_xt_definecodeorder.SetProperty("SortDSC", Ddo_xt_definecodeorder_Sortdsc);
            ucDdo_xt_definecodeorder.SetProperty("SearchButtonText", Ddo_xt_definecodeorder_Searchbuttontext);
            ucDdo_xt_definecodeorder.SetProperty("DropDownOptionsTitleSettingsIcons", AV21DDO_TitleSettingsIcons);
            ucDdo_xt_definecodeorder.SetProperty("DropDownOptionsData", AV27XT_DefineCodeOrderTitleFilterData);
            ucDdo_xt_definecodeorder.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_definecodeorder_Internalname, "DDO_XT_DEFINECODEORDERContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_definecodeordertitlecontrolidtoreplace_Internalname, AV28ddo_XT_DefineCodeOrderTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,35);\"", 0, edtavDdo_xt_definecodeordertitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_DefineCodePrompt.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_XT_DefineCodePrompt.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV12OrderedDsc), StringUtil.BoolToStr( AV12OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_XT_DefineCodePrompt.htm");
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

      protected void START2H2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "选择数据字典数据", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP2H0( ) ;
      }

      protected void WS2H2( )
      {
         START2H2( ) ;
         EVT2H2( ) ;
      }

      protected void EVT2H2( )
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
                           E112H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E122H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_XT_DEFINECODEID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E132H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_XT_DEFINECODENAME.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E142H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_XT_DEFINDCODETYPEID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E152H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_XT_DEFINDCODETYPENAME.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E162H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_XT_DEFINECODEORDER.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E172H2 ();
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
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV26Select)) ? AV32Select_GXI : context.convertURL( context.PathToRelativeUrl( AV26Select))), !bGXsfl_12_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "SrcSet", context.GetImageSrcSet( AV26Select), true);
                           A167XT_DefineCodeID = (long)(context.localUtil.CToN( cgiGet( edtXT_DefineCodeID_Internalname), ".", ","));
                           A168XT_DefineCodeName = cgiGet( edtXT_DefineCodeName_Internalname);
                           n168XT_DefineCodeName = false;
                           A165XT_DefindcodeTypeID = (long)(context.localUtil.CToN( cgiGet( edtXT_DefindcodeTypeID_Internalname), ".", ","));
                           A166XT_DefindcodeTypeName = cgiGet( edtXT_DefindcodeTypeName_Internalname);
                           n166XT_DefindcodeTypeName = false;
                           A171XT_DefineCodeOrder = (short)(context.localUtil.CToN( cgiGet( edtXT_DefineCodeOrder_Internalname), ".", ","));
                           n171XT_DefineCodeOrder = false;
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E182H2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E192H2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E202H2 ();
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
                                       E212H2 ();
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

      protected void WE2H2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm2H2( ) ;
            }
         }
      }

      protected void PA2H2( )
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
               GX_FocusControl = edtavDdo_xt_definecodeidtitlecontrolidtoreplace_Internalname;
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
                                       String AV14ddo_XT_DefineCodeIDTitleControlIdToReplace ,
                                       String AV16ddo_XT_DefineCodeNameTitleControlIdToReplace ,
                                       String AV18ddo_XT_DefindcodeTypeIDTitleControlIdToReplace ,
                                       String AV20ddo_XT_DefindcodeTypeNameTitleControlIdToReplace ,
                                       String AV28ddo_XT_DefineCodeOrderTitleControlIdToReplace )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF2H2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_XT_DEFINECODEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A167XT_DefineCodeID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "XT_DEFINECODEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A167XT_DefineCodeID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_XT_DEFINECODENAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A168XT_DefineCodeName, "")), context));
         GxWebStd.gx_hidden_field( context, "XT_DEFINECODENAME", A168XT_DefineCodeName);
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
         RF2H2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV31Pgmname = "XT_DefineCodePrompt";
         context.Gx_err = 0;
      }

      protected void RF2H2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 12;
         /* Execute user event: Refresh */
         E192H2 ();
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
            /* Using cursor H002H2 */
            pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_12_idx = 1;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A171XT_DefineCodeOrder = H002H2_A171XT_DefineCodeOrder[0];
               n171XT_DefineCodeOrder = H002H2_n171XT_DefineCodeOrder[0];
               A166XT_DefindcodeTypeName = H002H2_A166XT_DefindcodeTypeName[0];
               n166XT_DefindcodeTypeName = H002H2_n166XT_DefindcodeTypeName[0];
               A165XT_DefindcodeTypeID = H002H2_A165XT_DefindcodeTypeID[0];
               A168XT_DefineCodeName = H002H2_A168XT_DefineCodeName[0];
               n168XT_DefineCodeName = H002H2_n168XT_DefineCodeName[0];
               A167XT_DefineCodeID = H002H2_A167XT_DefineCodeID[0];
               A166XT_DefindcodeTypeName = H002H2_A166XT_DefindcodeTypeName[0];
               n166XT_DefindcodeTypeName = H002H2_n166XT_DefindcodeTypeName[0];
               E202H2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 12;
            WB2H0( ) ;
         }
         bGXsfl_12_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes2H2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_XT_DEFINECODEID"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, context.localUtil.Format( (decimal)(A167XT_DefineCodeID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_XT_DEFINECODENAME"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, StringUtil.RTrim( context.localUtil.Format( A168XT_DefineCodeName, "")), context));
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
         /* Using cursor H002H3 */
         pr_default.execute(1);
         GRID_nRecordCount = H002H3_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_XT_DefineCodeIDTitleControlIdToReplace, AV16ddo_XT_DefineCodeNameTitleControlIdToReplace, AV18ddo_XT_DefindcodeTypeIDTitleControlIdToReplace, AV20ddo_XT_DefindcodeTypeNameTitleControlIdToReplace, AV28ddo_XT_DefineCodeOrderTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_XT_DefineCodeIDTitleControlIdToReplace, AV16ddo_XT_DefineCodeNameTitleControlIdToReplace, AV18ddo_XT_DefindcodeTypeIDTitleControlIdToReplace, AV20ddo_XT_DefindcodeTypeNameTitleControlIdToReplace, AV28ddo_XT_DefineCodeOrderTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_XT_DefineCodeIDTitleControlIdToReplace, AV16ddo_XT_DefineCodeNameTitleControlIdToReplace, AV18ddo_XT_DefindcodeTypeIDTitleControlIdToReplace, AV20ddo_XT_DefindcodeTypeNameTitleControlIdToReplace, AV28ddo_XT_DefineCodeOrderTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_XT_DefineCodeIDTitleControlIdToReplace, AV16ddo_XT_DefineCodeNameTitleControlIdToReplace, AV18ddo_XT_DefindcodeTypeIDTitleControlIdToReplace, AV20ddo_XT_DefindcodeTypeNameTitleControlIdToReplace, AV28ddo_XT_DefineCodeOrderTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_XT_DefineCodeIDTitleControlIdToReplace, AV16ddo_XT_DefineCodeNameTitleControlIdToReplace, AV18ddo_XT_DefindcodeTypeIDTitleControlIdToReplace, AV20ddo_XT_DefindcodeTypeNameTitleControlIdToReplace, AV28ddo_XT_DefineCodeOrderTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP2H0( )
      {
         /* Before Start, stand alone formulas. */
         AV31Pgmname = "XT_DefineCodePrompt";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E182H2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV21DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_DEFINECODEIDTITLEFILTERDATA"), AV13XT_DefineCodeIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_DEFINECODENAMETITLEFILTERDATA"), AV15XT_DefineCodeNameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_DEFINDCODETYPEIDTITLEFILTERDATA"), AV17XT_DefindcodeTypeIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_DEFINDCODETYPENAMETITLEFILTERDATA"), AV19XT_DefindcodeTypeNameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_DEFINECODEORDERTITLEFILTERDATA"), AV27XT_DefineCodeOrderTitleFilterData);
            /* Read variables values. */
            AV14ddo_XT_DefineCodeIDTitleControlIdToReplace = cgiGet( edtavDdo_xt_definecodeidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_XT_DefineCodeIDTitleControlIdToReplace", AV14ddo_XT_DefineCodeIDTitleControlIdToReplace);
            AV16ddo_XT_DefineCodeNameTitleControlIdToReplace = cgiGet( edtavDdo_xt_definecodenametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_XT_DefineCodeNameTitleControlIdToReplace", AV16ddo_XT_DefineCodeNameTitleControlIdToReplace);
            AV18ddo_XT_DefindcodeTypeIDTitleControlIdToReplace = cgiGet( edtavDdo_xt_defindcodetypeidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_XT_DefindcodeTypeIDTitleControlIdToReplace", AV18ddo_XT_DefindcodeTypeIDTitleControlIdToReplace);
            AV20ddo_XT_DefindcodeTypeNameTitleControlIdToReplace = cgiGet( edtavDdo_xt_defindcodetypenametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_XT_DefindcodeTypeNameTitleControlIdToReplace", AV20ddo_XT_DefindcodeTypeNameTitleControlIdToReplace);
            AV28ddo_XT_DefineCodeOrderTitleControlIdToReplace = cgiGet( edtavDdo_xt_definecodeordertitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28ddo_XT_DefineCodeOrderTitleControlIdToReplace", AV28ddo_XT_DefineCodeOrderTitleControlIdToReplace);
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
            Ddo_xt_definecodeid_Caption = cgiGet( "DDO_XT_DEFINECODEID_Caption");
            Ddo_xt_definecodeid_Tooltip = cgiGet( "DDO_XT_DEFINECODEID_Tooltip");
            Ddo_xt_definecodeid_Cls = cgiGet( "DDO_XT_DEFINECODEID_Cls");
            Ddo_xt_definecodeid_Dropdownoptionstype = cgiGet( "DDO_XT_DEFINECODEID_Dropdownoptionstype");
            Ddo_xt_definecodeid_Titlecontrolidtoreplace = cgiGet( "DDO_XT_DEFINECODEID_Titlecontrolidtoreplace");
            Ddo_xt_definecodeid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_DEFINECODEID_Includesortasc"));
            Ddo_xt_definecodeid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_DEFINECODEID_Includesortdsc"));
            Ddo_xt_definecodeid_Sortedstatus = cgiGet( "DDO_XT_DEFINECODEID_Sortedstatus");
            Ddo_xt_definecodeid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_DEFINECODEID_Includefilter"));
            Ddo_xt_definecodeid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_DEFINECODEID_Includedatalist"));
            Ddo_xt_definecodeid_Sortasc = cgiGet( "DDO_XT_DEFINECODEID_Sortasc");
            Ddo_xt_definecodeid_Sortdsc = cgiGet( "DDO_XT_DEFINECODEID_Sortdsc");
            Ddo_xt_definecodeid_Searchbuttontext = cgiGet( "DDO_XT_DEFINECODEID_Searchbuttontext");
            Ddo_xt_definecodename_Caption = cgiGet( "DDO_XT_DEFINECODENAME_Caption");
            Ddo_xt_definecodename_Tooltip = cgiGet( "DDO_XT_DEFINECODENAME_Tooltip");
            Ddo_xt_definecodename_Cls = cgiGet( "DDO_XT_DEFINECODENAME_Cls");
            Ddo_xt_definecodename_Dropdownoptionstype = cgiGet( "DDO_XT_DEFINECODENAME_Dropdownoptionstype");
            Ddo_xt_definecodename_Titlecontrolidtoreplace = cgiGet( "DDO_XT_DEFINECODENAME_Titlecontrolidtoreplace");
            Ddo_xt_definecodename_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_DEFINECODENAME_Includesortasc"));
            Ddo_xt_definecodename_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_DEFINECODENAME_Includesortdsc"));
            Ddo_xt_definecodename_Sortedstatus = cgiGet( "DDO_XT_DEFINECODENAME_Sortedstatus");
            Ddo_xt_definecodename_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_DEFINECODENAME_Includefilter"));
            Ddo_xt_definecodename_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_DEFINECODENAME_Includedatalist"));
            Ddo_xt_definecodename_Sortasc = cgiGet( "DDO_XT_DEFINECODENAME_Sortasc");
            Ddo_xt_definecodename_Sortdsc = cgiGet( "DDO_XT_DEFINECODENAME_Sortdsc");
            Ddo_xt_definecodename_Searchbuttontext = cgiGet( "DDO_XT_DEFINECODENAME_Searchbuttontext");
            Ddo_xt_defindcodetypeid_Caption = cgiGet( "DDO_XT_DEFINDCODETYPEID_Caption");
            Ddo_xt_defindcodetypeid_Tooltip = cgiGet( "DDO_XT_DEFINDCODETYPEID_Tooltip");
            Ddo_xt_defindcodetypeid_Cls = cgiGet( "DDO_XT_DEFINDCODETYPEID_Cls");
            Ddo_xt_defindcodetypeid_Dropdownoptionstype = cgiGet( "DDO_XT_DEFINDCODETYPEID_Dropdownoptionstype");
            Ddo_xt_defindcodetypeid_Titlecontrolidtoreplace = cgiGet( "DDO_XT_DEFINDCODETYPEID_Titlecontrolidtoreplace");
            Ddo_xt_defindcodetypeid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_DEFINDCODETYPEID_Includesortasc"));
            Ddo_xt_defindcodetypeid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_DEFINDCODETYPEID_Includesortdsc"));
            Ddo_xt_defindcodetypeid_Sortedstatus = cgiGet( "DDO_XT_DEFINDCODETYPEID_Sortedstatus");
            Ddo_xt_defindcodetypeid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_DEFINDCODETYPEID_Includefilter"));
            Ddo_xt_defindcodetypeid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_DEFINDCODETYPEID_Includedatalist"));
            Ddo_xt_defindcodetypeid_Sortasc = cgiGet( "DDO_XT_DEFINDCODETYPEID_Sortasc");
            Ddo_xt_defindcodetypeid_Sortdsc = cgiGet( "DDO_XT_DEFINDCODETYPEID_Sortdsc");
            Ddo_xt_defindcodetypeid_Searchbuttontext = cgiGet( "DDO_XT_DEFINDCODETYPEID_Searchbuttontext");
            Ddo_xt_defindcodetypename_Caption = cgiGet( "DDO_XT_DEFINDCODETYPENAME_Caption");
            Ddo_xt_defindcodetypename_Tooltip = cgiGet( "DDO_XT_DEFINDCODETYPENAME_Tooltip");
            Ddo_xt_defindcodetypename_Cls = cgiGet( "DDO_XT_DEFINDCODETYPENAME_Cls");
            Ddo_xt_defindcodetypename_Dropdownoptionstype = cgiGet( "DDO_XT_DEFINDCODETYPENAME_Dropdownoptionstype");
            Ddo_xt_defindcodetypename_Titlecontrolidtoreplace = cgiGet( "DDO_XT_DEFINDCODETYPENAME_Titlecontrolidtoreplace");
            Ddo_xt_defindcodetypename_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_DEFINDCODETYPENAME_Includesortasc"));
            Ddo_xt_defindcodetypename_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_DEFINDCODETYPENAME_Includesortdsc"));
            Ddo_xt_defindcodetypename_Sortedstatus = cgiGet( "DDO_XT_DEFINDCODETYPENAME_Sortedstatus");
            Ddo_xt_defindcodetypename_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_DEFINDCODETYPENAME_Includefilter"));
            Ddo_xt_defindcodetypename_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_DEFINDCODETYPENAME_Includedatalist"));
            Ddo_xt_defindcodetypename_Sortasc = cgiGet( "DDO_XT_DEFINDCODETYPENAME_Sortasc");
            Ddo_xt_defindcodetypename_Sortdsc = cgiGet( "DDO_XT_DEFINDCODETYPENAME_Sortdsc");
            Ddo_xt_defindcodetypename_Searchbuttontext = cgiGet( "DDO_XT_DEFINDCODETYPENAME_Searchbuttontext");
            Ddo_xt_definecodeorder_Caption = cgiGet( "DDO_XT_DEFINECODEORDER_Caption");
            Ddo_xt_definecodeorder_Tooltip = cgiGet( "DDO_XT_DEFINECODEORDER_Tooltip");
            Ddo_xt_definecodeorder_Cls = cgiGet( "DDO_XT_DEFINECODEORDER_Cls");
            Ddo_xt_definecodeorder_Dropdownoptionstype = cgiGet( "DDO_XT_DEFINECODEORDER_Dropdownoptionstype");
            Ddo_xt_definecodeorder_Titlecontrolidtoreplace = cgiGet( "DDO_XT_DEFINECODEORDER_Titlecontrolidtoreplace");
            Ddo_xt_definecodeorder_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_DEFINECODEORDER_Includesortasc"));
            Ddo_xt_definecodeorder_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_DEFINECODEORDER_Includesortdsc"));
            Ddo_xt_definecodeorder_Sortedstatus = cgiGet( "DDO_XT_DEFINECODEORDER_Sortedstatus");
            Ddo_xt_definecodeorder_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_DEFINECODEORDER_Includefilter"));
            Ddo_xt_definecodeorder_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_DEFINECODEORDER_Includedatalist"));
            Ddo_xt_definecodeorder_Sortasc = cgiGet( "DDO_XT_DEFINECODEORDER_Sortasc");
            Ddo_xt_definecodeorder_Sortdsc = cgiGet( "DDO_XT_DEFINECODEORDER_Sortdsc");
            Ddo_xt_definecodeorder_Searchbuttontext = cgiGet( "DDO_XT_DEFINECODEORDER_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_xt_definecodeid_Activeeventkey = cgiGet( "DDO_XT_DEFINECODEID_Activeeventkey");
            Ddo_xt_definecodename_Activeeventkey = cgiGet( "DDO_XT_DEFINECODENAME_Activeeventkey");
            Ddo_xt_defindcodetypeid_Activeeventkey = cgiGet( "DDO_XT_DEFINDCODETYPEID_Activeeventkey");
            Ddo_xt_defindcodetypename_Activeeventkey = cgiGet( "DDO_XT_DEFINDCODETYPENAME_Activeeventkey");
            Ddo_xt_definecodeorder_Activeeventkey = cgiGet( "DDO_XT_DEFINECODEORDER_Activeeventkey");
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
         E182H2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E182H2( )
      {
         /* Start Routine */
         GXt_boolean1 = AV5IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_DefineCode", out  GXt_boolean1) ;
         AV5IsAuthorized = GXt_boolean1;
         if ( ! AV5IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV31Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         divTablemain_Height = 493;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTablemain_Internalname, "Height", StringUtil.LTrim( StringUtil.Str( (decimal)(divTablemain_Height), 9, 0)), true);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_xt_definecodeid_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_DefineCodeID";
         ucDdo_xt_definecodeid.SendProperty(context, "", false, Ddo_xt_definecodeid_Internalname, "TitleControlIdToReplace", Ddo_xt_definecodeid_Titlecontrolidtoreplace);
         AV14ddo_XT_DefineCodeIDTitleControlIdToReplace = Ddo_xt_definecodeid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_XT_DefineCodeIDTitleControlIdToReplace", AV14ddo_XT_DefineCodeIDTitleControlIdToReplace);
         edtavDdo_xt_definecodeidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_definecodeidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_definecodeidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_xt_definecodename_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_DefineCodeName";
         ucDdo_xt_definecodename.SendProperty(context, "", false, Ddo_xt_definecodename_Internalname, "TitleControlIdToReplace", Ddo_xt_definecodename_Titlecontrolidtoreplace);
         AV16ddo_XT_DefineCodeNameTitleControlIdToReplace = Ddo_xt_definecodename_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_XT_DefineCodeNameTitleControlIdToReplace", AV16ddo_XT_DefineCodeNameTitleControlIdToReplace);
         edtavDdo_xt_definecodenametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_definecodenametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_definecodenametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_xt_defindcodetypeid_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_DefindcodeTypeID";
         ucDdo_xt_defindcodetypeid.SendProperty(context, "", false, Ddo_xt_defindcodetypeid_Internalname, "TitleControlIdToReplace", Ddo_xt_defindcodetypeid_Titlecontrolidtoreplace);
         AV18ddo_XT_DefindcodeTypeIDTitleControlIdToReplace = Ddo_xt_defindcodetypeid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_XT_DefindcodeTypeIDTitleControlIdToReplace", AV18ddo_XT_DefindcodeTypeIDTitleControlIdToReplace);
         edtavDdo_xt_defindcodetypeidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_defindcodetypeidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_defindcodetypeidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_xt_defindcodetypename_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_DefindcodeTypeName";
         ucDdo_xt_defindcodetypename.SendProperty(context, "", false, Ddo_xt_defindcodetypename_Internalname, "TitleControlIdToReplace", Ddo_xt_defindcodetypename_Titlecontrolidtoreplace);
         AV20ddo_XT_DefindcodeTypeNameTitleControlIdToReplace = Ddo_xt_defindcodetypename_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_XT_DefindcodeTypeNameTitleControlIdToReplace", AV20ddo_XT_DefindcodeTypeNameTitleControlIdToReplace);
         edtavDdo_xt_defindcodetypenametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_defindcodetypenametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_defindcodetypenametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_xt_definecodeorder_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_DefineCodeOrder";
         ucDdo_xt_definecodeorder.SendProperty(context, "", false, Ddo_xt_definecodeorder_Internalname, "TitleControlIdToReplace", Ddo_xt_definecodeorder_Titlecontrolidtoreplace);
         AV28ddo_XT_DefineCodeOrderTitleControlIdToReplace = Ddo_xt_definecodeorder_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28ddo_XT_DefineCodeOrderTitleControlIdToReplace", AV28ddo_XT_DefineCodeOrderTitleControlIdToReplace);
         edtavDdo_xt_definecodeordertitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_definecodeordertitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_definecodeordertitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "选择数据字典数据";
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

      protected void E192H2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV13XT_DefineCodeIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15XT_DefineCodeNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17XT_DefindcodeTypeIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19XT_DefindcodeTypeNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV27XT_DefineCodeOrderTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         edtXT_DefineCodeID_Titleformat = 2;
         edtXT_DefineCodeID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "数据字典主键", AV14ddo_XT_DefineCodeIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_DefineCodeID_Internalname, "Title", edtXT_DefineCodeID_Title, !bGXsfl_12_Refreshing);
         edtXT_DefineCodeName_Titleformat = 2;
         edtXT_DefineCodeName_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "数据字典名称", AV16ddo_XT_DefineCodeNameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_DefineCodeName_Internalname, "Title", edtXT_DefineCodeName_Title, !bGXsfl_12_Refreshing);
         edtXT_DefindcodeTypeID_Titleformat = 2;
         edtXT_DefindcodeTypeID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "数据字典类型主键", AV18ddo_XT_DefindcodeTypeIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_DefindcodeTypeID_Internalname, "Title", edtXT_DefindcodeTypeID_Title, !bGXsfl_12_Refreshing);
         edtXT_DefindcodeTypeName_Titleformat = 2;
         edtXT_DefindcodeTypeName_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "数据字典类型名称", AV20ddo_XT_DefindcodeTypeNameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_DefindcodeTypeName_Internalname, "Title", edtXT_DefindcodeTypeName_Title, !bGXsfl_12_Refreshing);
         edtXT_DefineCodeOrder_Titleformat = 2;
         edtXT_DefineCodeOrder_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "数据字典信息排序", AV28ddo_XT_DefineCodeOrderTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_DefineCodeOrder_Internalname, "Title", edtXT_DefineCodeOrder_Title, !bGXsfl_12_Refreshing);
         AV23GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV23GridCurrentPage), 10, 0)));
         AV24GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24GridPageSize), 10, 0)));
         AV25GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13XT_DefineCodeIDTitleFilterData", AV13XT_DefineCodeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15XT_DefineCodeNameTitleFilterData", AV15XT_DefineCodeNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17XT_DefindcodeTypeIDTitleFilterData", AV17XT_DefindcodeTypeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_DefindcodeTypeNameTitleFilterData", AV19XT_DefindcodeTypeNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27XT_DefineCodeOrderTitleFilterData", AV27XT_DefineCodeOrderTitleFilterData);
      }

      protected void E112H2( )
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

      protected void E122H2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E132H2( )
      {
         /* Ddo_xt_definecodeid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_definecodeid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_definecodeid_Sortedstatus = "ASC";
            ucDdo_xt_definecodeid.SendProperty(context, "", false, Ddo_xt_definecodeid_Internalname, "SortedStatus", Ddo_xt_definecodeid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_definecodeid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_definecodeid_Sortedstatus = "DSC";
            ucDdo_xt_definecodeid.SendProperty(context, "", false, Ddo_xt_definecodeid_Internalname, "SortedStatus", Ddo_xt_definecodeid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13XT_DefineCodeIDTitleFilterData", AV13XT_DefineCodeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15XT_DefineCodeNameTitleFilterData", AV15XT_DefineCodeNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17XT_DefindcodeTypeIDTitleFilterData", AV17XT_DefindcodeTypeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_DefindcodeTypeNameTitleFilterData", AV19XT_DefindcodeTypeNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27XT_DefineCodeOrderTitleFilterData", AV27XT_DefineCodeOrderTitleFilterData);
      }

      protected void E142H2( )
      {
         /* Ddo_xt_definecodename_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_definecodename_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_definecodename_Sortedstatus = "ASC";
            ucDdo_xt_definecodename.SendProperty(context, "", false, Ddo_xt_definecodename_Internalname, "SortedStatus", Ddo_xt_definecodename_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_definecodename_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_definecodename_Sortedstatus = "DSC";
            ucDdo_xt_definecodename.SendProperty(context, "", false, Ddo_xt_definecodename_Internalname, "SortedStatus", Ddo_xt_definecodename_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13XT_DefineCodeIDTitleFilterData", AV13XT_DefineCodeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15XT_DefineCodeNameTitleFilterData", AV15XT_DefineCodeNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17XT_DefindcodeTypeIDTitleFilterData", AV17XT_DefindcodeTypeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_DefindcodeTypeNameTitleFilterData", AV19XT_DefindcodeTypeNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27XT_DefineCodeOrderTitleFilterData", AV27XT_DefineCodeOrderTitleFilterData);
      }

      protected void E152H2( )
      {
         /* Ddo_xt_defindcodetypeid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_defindcodetypeid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_defindcodetypeid_Sortedstatus = "ASC";
            ucDdo_xt_defindcodetypeid.SendProperty(context, "", false, Ddo_xt_defindcodetypeid_Internalname, "SortedStatus", Ddo_xt_defindcodetypeid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_defindcodetypeid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_defindcodetypeid_Sortedstatus = "DSC";
            ucDdo_xt_defindcodetypeid.SendProperty(context, "", false, Ddo_xt_defindcodetypeid_Internalname, "SortedStatus", Ddo_xt_defindcodetypeid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13XT_DefineCodeIDTitleFilterData", AV13XT_DefineCodeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15XT_DefineCodeNameTitleFilterData", AV15XT_DefineCodeNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17XT_DefindcodeTypeIDTitleFilterData", AV17XT_DefindcodeTypeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_DefindcodeTypeNameTitleFilterData", AV19XT_DefindcodeTypeNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27XT_DefineCodeOrderTitleFilterData", AV27XT_DefineCodeOrderTitleFilterData);
      }

      protected void E162H2( )
      {
         /* Ddo_xt_defindcodetypename_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_defindcodetypename_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_defindcodetypename_Sortedstatus = "ASC";
            ucDdo_xt_defindcodetypename.SendProperty(context, "", false, Ddo_xt_defindcodetypename_Internalname, "SortedStatus", Ddo_xt_defindcodetypename_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_defindcodetypename_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_defindcodetypename_Sortedstatus = "DSC";
            ucDdo_xt_defindcodetypename.SendProperty(context, "", false, Ddo_xt_defindcodetypename_Internalname, "SortedStatus", Ddo_xt_defindcodetypename_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13XT_DefineCodeIDTitleFilterData", AV13XT_DefineCodeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15XT_DefineCodeNameTitleFilterData", AV15XT_DefineCodeNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17XT_DefindcodeTypeIDTitleFilterData", AV17XT_DefindcodeTypeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_DefindcodeTypeNameTitleFilterData", AV19XT_DefindcodeTypeNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27XT_DefineCodeOrderTitleFilterData", AV27XT_DefineCodeOrderTitleFilterData);
      }

      protected void E172H2( )
      {
         /* Ddo_xt_definecodeorder_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_definecodeorder_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_definecodeorder_Sortedstatus = "ASC";
            ucDdo_xt_definecodeorder.SendProperty(context, "", false, Ddo_xt_definecodeorder_Internalname, "SortedStatus", Ddo_xt_definecodeorder_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_definecodeorder_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_definecodeorder_Sortedstatus = "DSC";
            ucDdo_xt_definecodeorder.SendProperty(context, "", false, Ddo_xt_definecodeorder_Internalname, "SortedStatus", Ddo_xt_definecodeorder_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13XT_DefineCodeIDTitleFilterData", AV13XT_DefineCodeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15XT_DefineCodeNameTitleFilterData", AV15XT_DefineCodeNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17XT_DefindcodeTypeIDTitleFilterData", AV17XT_DefindcodeTypeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_DefindcodeTypeNameTitleFilterData", AV19XT_DefindcodeTypeNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27XT_DefineCodeOrderTitleFilterData", AV27XT_DefineCodeOrderTitleFilterData);
      }

      private void E202H2( )
      {
         /* Grid_Load Routine */
         AV26Select = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSelect_Internalname, AV26Select);
         AV32Select_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
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
         E212H2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E212H2( )
      {
         /* Enter Routine */
         AV8InOutXT_DefineCodeID = A167XT_DefineCodeID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutXT_DefineCodeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutXT_DefineCodeID), 18, 0)));
         AV9InOutXT_DefineCodeName = A168XT_DefineCodeName;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutXT_DefineCodeName", AV9InOutXT_DefineCodeName);
         context.setWebReturnParms(new Object[] {(long)AV8InOutXT_DefineCodeID,(String)AV9InOutXT_DefineCodeName});
         context.setWebReturnParmsMetadata(new Object[] {"AV8InOutXT_DefineCodeID","AV9InOutXT_DefineCodeName"});
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
         AV8InOutXT_DefineCodeID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutXT_DefineCodeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutXT_DefineCodeID), 18, 0)));
         AV9InOutXT_DefineCodeName = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutXT_DefineCodeName", AV9InOutXT_DefineCodeName);
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
         PA2H2( ) ;
         WS2H2( ) ;
         WE2H2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202281594521", true);
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
         context.AddJavascriptSource("xt_definecodeprompt.js", "?20202281594521", false);
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

      protected void SubsflControlProps_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_idx;
         edtXT_DefineCodeID_Internalname = "XT_DEFINECODEID_"+sGXsfl_12_idx;
         edtXT_DefineCodeName_Internalname = "XT_DEFINECODENAME_"+sGXsfl_12_idx;
         edtXT_DefindcodeTypeID_Internalname = "XT_DEFINDCODETYPEID_"+sGXsfl_12_idx;
         edtXT_DefindcodeTypeName_Internalname = "XT_DEFINDCODETYPENAME_"+sGXsfl_12_idx;
         edtXT_DefineCodeOrder_Internalname = "XT_DEFINECODEORDER_"+sGXsfl_12_idx;
      }

      protected void SubsflControlProps_fel_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_fel_idx;
         edtXT_DefineCodeID_Internalname = "XT_DEFINECODEID_"+sGXsfl_12_fel_idx;
         edtXT_DefineCodeName_Internalname = "XT_DEFINECODENAME_"+sGXsfl_12_fel_idx;
         edtXT_DefindcodeTypeID_Internalname = "XT_DEFINDCODETYPEID_"+sGXsfl_12_fel_idx;
         edtXT_DefindcodeTypeName_Internalname = "XT_DEFINDCODETYPENAME_"+sGXsfl_12_fel_idx;
         edtXT_DefineCodeOrder_Internalname = "XT_DEFINECODEORDER_"+sGXsfl_12_fel_idx;
      }

      protected void sendrow_122( )
      {
         SubsflControlProps_122( ) ;
         WB2H0( ) ;
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
            AV26Select_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV26Select))&&String.IsNullOrEmpty(StringUtil.RTrim( AV32Select_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV26Select)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV26Select)) ? AV32Select_GXI : context.PathToRelativeUrl( AV26Select));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSelect_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSelect_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSelect_Jsonclick,"'"+""+"'"+",false,"+"'"+"EENTER."+sGXsfl_12_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV26Select_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_DefineCodeID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A167XT_DefineCodeID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A167XT_DefineCodeID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_DefineCodeID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_DefineCodeName_Internalname,(String)A168XT_DefineCodeName,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_DefineCodeName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_DefindcodeTypeID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A165XT_DefindcodeTypeID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A165XT_DefindcodeTypeID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_DefindcodeTypeID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_DefindcodeTypeName_Internalname,(String)A166XT_DefindcodeTypeName,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_DefindcodeTypeName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_DefineCodeOrder_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A171XT_DefineCodeOrder), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A171XT_DefineCodeOrder), "ZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_DefineCodeOrder_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            send_integrity_lvl_hashes2H2( ) ;
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
         edtXT_DefineCodeID_Internalname = "XT_DEFINECODEID";
         edtXT_DefineCodeName_Internalname = "XT_DEFINECODENAME";
         edtXT_DefindcodeTypeID_Internalname = "XT_DEFINDCODETYPEID";
         edtXT_DefindcodeTypeName_Internalname = "XT_DEFINDCODETYPENAME";
         edtXT_DefineCodeOrder_Internalname = "XT_DEFINECODEORDER";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_xt_definecodeid_Internalname = "DDO_XT_DEFINECODEID";
         edtavDdo_xt_definecodeidtitlecontrolidtoreplace_Internalname = "vDDO_XT_DEFINECODEIDTITLECONTROLIDTOREPLACE";
         Ddo_xt_definecodename_Internalname = "DDO_XT_DEFINECODENAME";
         edtavDdo_xt_definecodenametitlecontrolidtoreplace_Internalname = "vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE";
         Ddo_xt_defindcodetypeid_Internalname = "DDO_XT_DEFINDCODETYPEID";
         edtavDdo_xt_defindcodetypeidtitlecontrolidtoreplace_Internalname = "vDDO_XT_DEFINDCODETYPEIDTITLECONTROLIDTOREPLACE";
         Ddo_xt_defindcodetypename_Internalname = "DDO_XT_DEFINDCODETYPENAME";
         edtavDdo_xt_defindcodetypenametitlecontrolidtoreplace_Internalname = "vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE";
         Ddo_xt_definecodeorder_Internalname = "DDO_XT_DEFINECODEORDER";
         edtavDdo_xt_definecodeordertitlecontrolidtoreplace_Internalname = "vDDO_XT_DEFINECODEORDERTITLECONTROLIDTOREPLACE";
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
         edtXT_DefineCodeOrder_Jsonclick = "";
         edtXT_DefindcodeTypeName_Jsonclick = "";
         edtXT_DefindcodeTypeID_Jsonclick = "";
         edtXT_DefineCodeName_Jsonclick = "";
         edtXT_DefineCodeID_Jsonclick = "";
         edtavSelect_Jsonclick = "";
         edtavSelect_Visible = -1;
         edtavSelect_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_xt_definecodeordertitlecontrolidtoreplace_Visible = 1;
         edtavDdo_xt_defindcodetypenametitlecontrolidtoreplace_Visible = 1;
         edtavDdo_xt_defindcodetypeidtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_xt_definecodenametitlecontrolidtoreplace_Visible = 1;
         edtavDdo_xt_definecodeidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavSelect_Tooltiptext = "选择";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtXT_DefineCodeOrder_Titleformat = 0;
         edtXT_DefineCodeOrder_Title = "数据字典信息排序";
         edtXT_DefindcodeTypeName_Titleformat = 0;
         edtXT_DefindcodeTypeName_Title = "数据字典类型名称";
         edtXT_DefindcodeTypeID_Titleformat = 0;
         edtXT_DefindcodeTypeID_Title = "数据字典类型主键";
         edtXT_DefineCodeName_Titleformat = 0;
         edtXT_DefineCodeName_Title = "数据字典名称";
         edtXT_DefineCodeID_Titleformat = 0;
         edtXT_DefineCodeID_Title = "数据字典主键";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         divTablemain_Height = 0;
         Ddo_xt_definecodeorder_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_definecodeorder_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_definecodeorder_Sortasc = "WWP_TSSortASC";
         Ddo_xt_definecodeorder_Includedatalist = Convert.ToBoolean( 0);
         Ddo_xt_definecodeorder_Includefilter = Convert.ToBoolean( 0);
         Ddo_xt_definecodeorder_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_xt_definecodeorder_Includesortasc = Convert.ToBoolean( -1);
         Ddo_xt_definecodeorder_Titlecontrolidtoreplace = "";
         Ddo_xt_definecodeorder_Dropdownoptionstype = "GridTitleSettings";
         Ddo_xt_definecodeorder_Cls = "ColumnSettings";
         Ddo_xt_definecodeorder_Tooltip = "WWP_TSColumnOptions";
         Ddo_xt_definecodeorder_Caption = "";
         Ddo_xt_defindcodetypename_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_defindcodetypename_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_defindcodetypename_Sortasc = "WWP_TSSortASC";
         Ddo_xt_defindcodetypename_Includedatalist = Convert.ToBoolean( 0);
         Ddo_xt_defindcodetypename_Includefilter = Convert.ToBoolean( 0);
         Ddo_xt_defindcodetypename_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_xt_defindcodetypename_Includesortasc = Convert.ToBoolean( -1);
         Ddo_xt_defindcodetypename_Titlecontrolidtoreplace = "";
         Ddo_xt_defindcodetypename_Dropdownoptionstype = "GridTitleSettings";
         Ddo_xt_defindcodetypename_Cls = "ColumnSettings";
         Ddo_xt_defindcodetypename_Tooltip = "WWP_TSColumnOptions";
         Ddo_xt_defindcodetypename_Caption = "";
         Ddo_xt_defindcodetypeid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_defindcodetypeid_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_defindcodetypeid_Sortasc = "WWP_TSSortASC";
         Ddo_xt_defindcodetypeid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_xt_defindcodetypeid_Includefilter = Convert.ToBoolean( 0);
         Ddo_xt_defindcodetypeid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_xt_defindcodetypeid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_xt_defindcodetypeid_Titlecontrolidtoreplace = "";
         Ddo_xt_defindcodetypeid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_xt_defindcodetypeid_Cls = "ColumnSettings";
         Ddo_xt_defindcodetypeid_Tooltip = "WWP_TSColumnOptions";
         Ddo_xt_defindcodetypeid_Caption = "";
         Ddo_xt_definecodename_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_definecodename_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_definecodename_Sortasc = "WWP_TSSortASC";
         Ddo_xt_definecodename_Includedatalist = Convert.ToBoolean( 0);
         Ddo_xt_definecodename_Includefilter = Convert.ToBoolean( 0);
         Ddo_xt_definecodename_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_xt_definecodename_Includesortasc = Convert.ToBoolean( -1);
         Ddo_xt_definecodename_Titlecontrolidtoreplace = "";
         Ddo_xt_definecodename_Dropdownoptionstype = "GridTitleSettings";
         Ddo_xt_definecodename_Cls = "ColumnSettings";
         Ddo_xt_definecodename_Tooltip = "WWP_TSColumnOptions";
         Ddo_xt_definecodename_Caption = "";
         Ddo_xt_definecodeid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_definecodeid_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_definecodeid_Sortasc = "WWP_TSSortASC";
         Ddo_xt_definecodeid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_xt_definecodeid_Includefilter = Convert.ToBoolean( 0);
         Ddo_xt_definecodeid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_xt_definecodeid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_xt_definecodeid_Titlecontrolidtoreplace = "";
         Ddo_xt_definecodeid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_xt_definecodeid_Cls = "ColumnSettings";
         Ddo_xt_definecodeid_Tooltip = "WWP_TSColumnOptions";
         Ddo_xt_definecodeid_Caption = "";
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
         Form.Caption = "选择数据字典数据";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_DefineCodeIDTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_DefineCodeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_DefindcodeTypeIDTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_DefindcodeTypeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_XT_DefineCodeOrderTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODEORDERTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV13XT_DefineCodeIDTitleFilterData',fld:'vXT_DEFINECODEIDTITLEFILTERDATA',pic:''},{av:'AV15XT_DefineCodeNameTitleFilterData',fld:'vXT_DEFINECODENAMETITLEFILTERDATA',pic:''},{av:'AV17XT_DefindcodeTypeIDTitleFilterData',fld:'vXT_DEFINDCODETYPEIDTITLEFILTERDATA',pic:''},{av:'AV19XT_DefindcodeTypeNameTitleFilterData',fld:'vXT_DEFINDCODETYPENAMETITLEFILTERDATA',pic:''},{av:'AV27XT_DefineCodeOrderTitleFilterData',fld:'vXT_DEFINECODEORDERTITLEFILTERDATA',pic:''},{av:'edtXT_DefineCodeID_Titleformat',ctrl:'XT_DEFINECODEID',prop:'Titleformat'},{av:'edtXT_DefineCodeID_Title',ctrl:'XT_DEFINECODEID',prop:'Title'},{av:'edtXT_DefineCodeName_Titleformat',ctrl:'XT_DEFINECODENAME',prop:'Titleformat'},{av:'edtXT_DefineCodeName_Title',ctrl:'XT_DEFINECODENAME',prop:'Title'},{av:'edtXT_DefindcodeTypeID_Titleformat',ctrl:'XT_DEFINDCODETYPEID',prop:'Titleformat'},{av:'edtXT_DefindcodeTypeID_Title',ctrl:'XT_DEFINDCODETYPEID',prop:'Title'},{av:'edtXT_DefindcodeTypeName_Titleformat',ctrl:'XT_DEFINDCODETYPENAME',prop:'Titleformat'},{av:'edtXT_DefindcodeTypeName_Title',ctrl:'XT_DEFINDCODETYPENAME',prop:'Title'},{av:'edtXT_DefineCodeOrder_Titleformat',ctrl:'XT_DEFINECODEORDER',prop:'Titleformat'},{av:'edtXT_DefineCodeOrder_Title',ctrl:'XT_DEFINECODEORDER',prop:'Title'},{av:'AV23GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV24GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV25GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E112H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_DefineCodeIDTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_DefineCodeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_DefindcodeTypeIDTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_DefindcodeTypeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_XT_DefineCodeOrderTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODEORDERTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E122H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_DefineCodeIDTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_DefineCodeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_DefindcodeTypeIDTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_DefindcodeTypeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_XT_DefineCodeOrderTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODEORDERTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_XT_DEFINECODEID.ONOPTIONCLICKED","{handler:'E132H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_DefineCodeIDTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_DefineCodeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_DefindcodeTypeIDTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_DefindcodeTypeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_XT_DefineCodeOrderTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODEORDERTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_xt_definecodeid_Activeeventkey',ctrl:'DDO_XT_DEFINECODEID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_DEFINECODEID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_definecodeid_Sortedstatus',ctrl:'DDO_XT_DEFINECODEID',prop:'SortedStatus'},{av:'AV13XT_DefineCodeIDTitleFilterData',fld:'vXT_DEFINECODEIDTITLEFILTERDATA',pic:''},{av:'AV15XT_DefineCodeNameTitleFilterData',fld:'vXT_DEFINECODENAMETITLEFILTERDATA',pic:''},{av:'AV17XT_DefindcodeTypeIDTitleFilterData',fld:'vXT_DEFINDCODETYPEIDTITLEFILTERDATA',pic:''},{av:'AV19XT_DefindcodeTypeNameTitleFilterData',fld:'vXT_DEFINDCODETYPENAMETITLEFILTERDATA',pic:''},{av:'AV27XT_DefineCodeOrderTitleFilterData',fld:'vXT_DEFINECODEORDERTITLEFILTERDATA',pic:''},{av:'edtXT_DefineCodeID_Titleformat',ctrl:'XT_DEFINECODEID',prop:'Titleformat'},{av:'edtXT_DefineCodeID_Title',ctrl:'XT_DEFINECODEID',prop:'Title'},{av:'edtXT_DefineCodeName_Titleformat',ctrl:'XT_DEFINECODENAME',prop:'Titleformat'},{av:'edtXT_DefineCodeName_Title',ctrl:'XT_DEFINECODENAME',prop:'Title'},{av:'edtXT_DefindcodeTypeID_Titleformat',ctrl:'XT_DEFINDCODETYPEID',prop:'Titleformat'},{av:'edtXT_DefindcodeTypeID_Title',ctrl:'XT_DEFINDCODETYPEID',prop:'Title'},{av:'edtXT_DefindcodeTypeName_Titleformat',ctrl:'XT_DEFINDCODETYPENAME',prop:'Titleformat'},{av:'edtXT_DefindcodeTypeName_Title',ctrl:'XT_DEFINDCODETYPENAME',prop:'Title'},{av:'edtXT_DefineCodeOrder_Titleformat',ctrl:'XT_DEFINECODEORDER',prop:'Titleformat'},{av:'edtXT_DefineCodeOrder_Title',ctrl:'XT_DEFINECODEORDER',prop:'Title'},{av:'AV23GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV24GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV25GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_XT_DEFINECODENAME.ONOPTIONCLICKED","{handler:'E142H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_DefineCodeIDTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_DefineCodeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_DefindcodeTypeIDTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_DefindcodeTypeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_XT_DefineCodeOrderTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODEORDERTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_xt_definecodename_Activeeventkey',ctrl:'DDO_XT_DEFINECODENAME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_DEFINECODENAME.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_definecodename_Sortedstatus',ctrl:'DDO_XT_DEFINECODENAME',prop:'SortedStatus'},{av:'AV13XT_DefineCodeIDTitleFilterData',fld:'vXT_DEFINECODEIDTITLEFILTERDATA',pic:''},{av:'AV15XT_DefineCodeNameTitleFilterData',fld:'vXT_DEFINECODENAMETITLEFILTERDATA',pic:''},{av:'AV17XT_DefindcodeTypeIDTitleFilterData',fld:'vXT_DEFINDCODETYPEIDTITLEFILTERDATA',pic:''},{av:'AV19XT_DefindcodeTypeNameTitleFilterData',fld:'vXT_DEFINDCODETYPENAMETITLEFILTERDATA',pic:''},{av:'AV27XT_DefineCodeOrderTitleFilterData',fld:'vXT_DEFINECODEORDERTITLEFILTERDATA',pic:''},{av:'edtXT_DefineCodeID_Titleformat',ctrl:'XT_DEFINECODEID',prop:'Titleformat'},{av:'edtXT_DefineCodeID_Title',ctrl:'XT_DEFINECODEID',prop:'Title'},{av:'edtXT_DefineCodeName_Titleformat',ctrl:'XT_DEFINECODENAME',prop:'Titleformat'},{av:'edtXT_DefineCodeName_Title',ctrl:'XT_DEFINECODENAME',prop:'Title'},{av:'edtXT_DefindcodeTypeID_Titleformat',ctrl:'XT_DEFINDCODETYPEID',prop:'Titleformat'},{av:'edtXT_DefindcodeTypeID_Title',ctrl:'XT_DEFINDCODETYPEID',prop:'Title'},{av:'edtXT_DefindcodeTypeName_Titleformat',ctrl:'XT_DEFINDCODETYPENAME',prop:'Titleformat'},{av:'edtXT_DefindcodeTypeName_Title',ctrl:'XT_DEFINDCODETYPENAME',prop:'Title'},{av:'edtXT_DefineCodeOrder_Titleformat',ctrl:'XT_DEFINECODEORDER',prop:'Titleformat'},{av:'edtXT_DefineCodeOrder_Title',ctrl:'XT_DEFINECODEORDER',prop:'Title'},{av:'AV23GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV24GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV25GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_XT_DEFINDCODETYPEID.ONOPTIONCLICKED","{handler:'E152H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_DefineCodeIDTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_DefineCodeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_DefindcodeTypeIDTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_DefindcodeTypeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_XT_DefineCodeOrderTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODEORDERTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_xt_defindcodetypeid_Activeeventkey',ctrl:'DDO_XT_DEFINDCODETYPEID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_DEFINDCODETYPEID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_defindcodetypeid_Sortedstatus',ctrl:'DDO_XT_DEFINDCODETYPEID',prop:'SortedStatus'},{av:'AV13XT_DefineCodeIDTitleFilterData',fld:'vXT_DEFINECODEIDTITLEFILTERDATA',pic:''},{av:'AV15XT_DefineCodeNameTitleFilterData',fld:'vXT_DEFINECODENAMETITLEFILTERDATA',pic:''},{av:'AV17XT_DefindcodeTypeIDTitleFilterData',fld:'vXT_DEFINDCODETYPEIDTITLEFILTERDATA',pic:''},{av:'AV19XT_DefindcodeTypeNameTitleFilterData',fld:'vXT_DEFINDCODETYPENAMETITLEFILTERDATA',pic:''},{av:'AV27XT_DefineCodeOrderTitleFilterData',fld:'vXT_DEFINECODEORDERTITLEFILTERDATA',pic:''},{av:'edtXT_DefineCodeID_Titleformat',ctrl:'XT_DEFINECODEID',prop:'Titleformat'},{av:'edtXT_DefineCodeID_Title',ctrl:'XT_DEFINECODEID',prop:'Title'},{av:'edtXT_DefineCodeName_Titleformat',ctrl:'XT_DEFINECODENAME',prop:'Titleformat'},{av:'edtXT_DefineCodeName_Title',ctrl:'XT_DEFINECODENAME',prop:'Title'},{av:'edtXT_DefindcodeTypeID_Titleformat',ctrl:'XT_DEFINDCODETYPEID',prop:'Titleformat'},{av:'edtXT_DefindcodeTypeID_Title',ctrl:'XT_DEFINDCODETYPEID',prop:'Title'},{av:'edtXT_DefindcodeTypeName_Titleformat',ctrl:'XT_DEFINDCODETYPENAME',prop:'Titleformat'},{av:'edtXT_DefindcodeTypeName_Title',ctrl:'XT_DEFINDCODETYPENAME',prop:'Title'},{av:'edtXT_DefineCodeOrder_Titleformat',ctrl:'XT_DEFINECODEORDER',prop:'Titleformat'},{av:'edtXT_DefineCodeOrder_Title',ctrl:'XT_DEFINECODEORDER',prop:'Title'},{av:'AV23GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV24GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV25GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_XT_DEFINDCODETYPENAME.ONOPTIONCLICKED","{handler:'E162H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_DefineCodeIDTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_DefineCodeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_DefindcodeTypeIDTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_DefindcodeTypeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_XT_DefineCodeOrderTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODEORDERTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_xt_defindcodetypename_Activeeventkey',ctrl:'DDO_XT_DEFINDCODETYPENAME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_DEFINDCODETYPENAME.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_defindcodetypename_Sortedstatus',ctrl:'DDO_XT_DEFINDCODETYPENAME',prop:'SortedStatus'},{av:'AV13XT_DefineCodeIDTitleFilterData',fld:'vXT_DEFINECODEIDTITLEFILTERDATA',pic:''},{av:'AV15XT_DefineCodeNameTitleFilterData',fld:'vXT_DEFINECODENAMETITLEFILTERDATA',pic:''},{av:'AV17XT_DefindcodeTypeIDTitleFilterData',fld:'vXT_DEFINDCODETYPEIDTITLEFILTERDATA',pic:''},{av:'AV19XT_DefindcodeTypeNameTitleFilterData',fld:'vXT_DEFINDCODETYPENAMETITLEFILTERDATA',pic:''},{av:'AV27XT_DefineCodeOrderTitleFilterData',fld:'vXT_DEFINECODEORDERTITLEFILTERDATA',pic:''},{av:'edtXT_DefineCodeID_Titleformat',ctrl:'XT_DEFINECODEID',prop:'Titleformat'},{av:'edtXT_DefineCodeID_Title',ctrl:'XT_DEFINECODEID',prop:'Title'},{av:'edtXT_DefineCodeName_Titleformat',ctrl:'XT_DEFINECODENAME',prop:'Titleformat'},{av:'edtXT_DefineCodeName_Title',ctrl:'XT_DEFINECODENAME',prop:'Title'},{av:'edtXT_DefindcodeTypeID_Titleformat',ctrl:'XT_DEFINDCODETYPEID',prop:'Titleformat'},{av:'edtXT_DefindcodeTypeID_Title',ctrl:'XT_DEFINDCODETYPEID',prop:'Title'},{av:'edtXT_DefindcodeTypeName_Titleformat',ctrl:'XT_DEFINDCODETYPENAME',prop:'Titleformat'},{av:'edtXT_DefindcodeTypeName_Title',ctrl:'XT_DEFINDCODETYPENAME',prop:'Title'},{av:'edtXT_DefineCodeOrder_Titleformat',ctrl:'XT_DEFINECODEORDER',prop:'Titleformat'},{av:'edtXT_DefineCodeOrder_Title',ctrl:'XT_DEFINECODEORDER',prop:'Title'},{av:'AV23GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV24GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV25GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_XT_DEFINECODEORDER.ONOPTIONCLICKED","{handler:'E172H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_DefineCodeIDTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_DefineCodeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_DefindcodeTypeIDTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_DefindcodeTypeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_XT_DefineCodeOrderTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODEORDERTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_xt_definecodeorder_Activeeventkey',ctrl:'DDO_XT_DEFINECODEORDER',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_DEFINECODEORDER.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_definecodeorder_Sortedstatus',ctrl:'DDO_XT_DEFINECODEORDER',prop:'SortedStatus'},{av:'AV13XT_DefineCodeIDTitleFilterData',fld:'vXT_DEFINECODEIDTITLEFILTERDATA',pic:''},{av:'AV15XT_DefineCodeNameTitleFilterData',fld:'vXT_DEFINECODENAMETITLEFILTERDATA',pic:''},{av:'AV17XT_DefindcodeTypeIDTitleFilterData',fld:'vXT_DEFINDCODETYPEIDTITLEFILTERDATA',pic:''},{av:'AV19XT_DefindcodeTypeNameTitleFilterData',fld:'vXT_DEFINDCODETYPENAMETITLEFILTERDATA',pic:''},{av:'AV27XT_DefineCodeOrderTitleFilterData',fld:'vXT_DEFINECODEORDERTITLEFILTERDATA',pic:''},{av:'edtXT_DefineCodeID_Titleformat',ctrl:'XT_DEFINECODEID',prop:'Titleformat'},{av:'edtXT_DefineCodeID_Title',ctrl:'XT_DEFINECODEID',prop:'Title'},{av:'edtXT_DefineCodeName_Titleformat',ctrl:'XT_DEFINECODENAME',prop:'Titleformat'},{av:'edtXT_DefineCodeName_Title',ctrl:'XT_DEFINECODENAME',prop:'Title'},{av:'edtXT_DefindcodeTypeID_Titleformat',ctrl:'XT_DEFINDCODETYPEID',prop:'Titleformat'},{av:'edtXT_DefindcodeTypeID_Title',ctrl:'XT_DEFINDCODETYPEID',prop:'Title'},{av:'edtXT_DefindcodeTypeName_Titleformat',ctrl:'XT_DEFINDCODETYPENAME',prop:'Titleformat'},{av:'edtXT_DefindcodeTypeName_Title',ctrl:'XT_DEFINDCODETYPENAME',prop:'Title'},{av:'edtXT_DefineCodeOrder_Titleformat',ctrl:'XT_DEFINECODEORDER',prop:'Titleformat'},{av:'edtXT_DefineCodeOrder_Title',ctrl:'XT_DEFINECODEORDER',prop:'Title'},{av:'AV23GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV24GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV25GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E202H2',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV26Select',fld:'vSELECT',pic:''},{av:'edtavSelect_Tooltiptext',ctrl:'vSELECT',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E212H2',iparms:[{av:'A167XT_DefineCodeID',fld:'XT_DEFINECODEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A168XT_DefineCodeName',fld:'XT_DEFINECODENAME',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV8InOutXT_DefineCodeID',fld:'vINOUTXT_DEFINECODEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV9InOutXT_DefineCodeName',fld:'vINOUTXT_DEFINECODENAME',pic:''}]}");
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
         wcpOAV9InOutXT_DefineCodeName = "";
         Gridpaginationbar_Selectedpage = "";
         Ddo_xt_definecodeid_Activeeventkey = "";
         Ddo_xt_definecodename_Activeeventkey = "";
         Ddo_xt_defindcodetypeid_Activeeventkey = "";
         Ddo_xt_defindcodetypename_Activeeventkey = "";
         Ddo_xt_definecodeorder_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV14ddo_XT_DefineCodeIDTitleControlIdToReplace = "";
         AV16ddo_XT_DefineCodeNameTitleControlIdToReplace = "";
         AV18ddo_XT_DefindcodeTypeIDTitleControlIdToReplace = "";
         AV20ddo_XT_DefindcodeTypeNameTitleControlIdToReplace = "";
         AV28ddo_XT_DefineCodeOrderTitleControlIdToReplace = "";
         GXKey = "";
         AV31Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV21DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV13XT_DefineCodeIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15XT_DefineCodeNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17XT_DefindcodeTypeIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19XT_DefindcodeTypeNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV27XT_DefineCodeOrderTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_xt_definecodeid_Sortedstatus = "";
         Ddo_xt_definecodename_Sortedstatus = "";
         Ddo_xt_defindcodetypeid_Sortedstatus = "";
         Ddo_xt_defindcodetypename_Sortedstatus = "";
         Ddo_xt_definecodeorder_Sortedstatus = "";
         GX_FocusControl = "";
         sPrefix = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV26Select = "";
         A168XT_DefineCodeName = "";
         A166XT_DefindcodeTypeName = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_xt_definecodeid = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_xt_definecodename = new GXUserControl();
         ucDdo_xt_defindcodetypeid = new GXUserControl();
         ucDdo_xt_defindcodetypename = new GXUserControl();
         ucDdo_xt_definecodeorder = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV32Select_GXI = "";
         scmdbuf = "";
         H002H2_A171XT_DefineCodeOrder = new short[1] ;
         H002H2_n171XT_DefineCodeOrder = new bool[] {false} ;
         H002H2_A166XT_DefindcodeTypeName = new String[] {""} ;
         H002H2_n166XT_DefindcodeTypeName = new bool[] {false} ;
         H002H2_A165XT_DefindcodeTypeID = new long[1] ;
         H002H2_A168XT_DefineCodeName = new String[] {""} ;
         H002H2_n168XT_DefineCodeName = new bool[] {false} ;
         H002H2_A167XT_DefineCodeID = new long[1] ;
         H002H3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.xt_definecodeprompt__default(),
            new Object[][] {
                new Object[] {
               H002H2_A171XT_DefineCodeOrder, H002H2_n171XT_DefineCodeOrder, H002H2_A166XT_DefindcodeTypeName, H002H2_n166XT_DefindcodeTypeName, H002H2_A165XT_DefindcodeTypeID, H002H2_A168XT_DefineCodeName, H002H2_n168XT_DefineCodeName, H002H2_A167XT_DefineCodeID
               }
               , new Object[] {
               H002H3_AGRID_nRecordCount
               }
            }
         );
         AV31Pgmname = "XT_DefineCodePrompt";
         /* GeneXus formulas. */
         AV31Pgmname = "XT_DefineCodePrompt";
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
      private short edtXT_DefineCodeID_Titleformat ;
      private short edtXT_DefineCodeName_Titleformat ;
      private short edtXT_DefindcodeTypeID_Titleformat ;
      private short edtXT_DefindcodeTypeName_Titleformat ;
      private short edtXT_DefineCodeOrder_Titleformat ;
      private short subGrid_Sortable ;
      private short A171XT_DefineCodeOrder ;
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
      private int edtavDdo_xt_definecodeidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_xt_definecodenametitlecontrolidtoreplace_Visible ;
      private int edtavDdo_xt_defindcodetypeidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_xt_defindcodetypenametitlecontrolidtoreplace_Visible ;
      private int edtavDdo_xt_definecodeordertitlecontrolidtoreplace_Visible ;
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
      private long AV8InOutXT_DefineCodeID ;
      private long wcpOAV8InOutXT_DefineCodeID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV23GridCurrentPage ;
      private long AV25GridRecordCount ;
      private long AV24GridPageSize ;
      private long A167XT_DefineCodeID ;
      private long A165XT_DefindcodeTypeID ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_xt_definecodeid_Activeeventkey ;
      private String Ddo_xt_definecodename_Activeeventkey ;
      private String Ddo_xt_defindcodetypeid_Activeeventkey ;
      private String Ddo_xt_defindcodetypename_Activeeventkey ;
      private String Ddo_xt_definecodeorder_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_12_idx="0001" ;
      private String GXKey ;
      private String AV31Pgmname ;
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
      private String Ddo_xt_definecodeid_Caption ;
      private String Ddo_xt_definecodeid_Tooltip ;
      private String Ddo_xt_definecodeid_Cls ;
      private String Ddo_xt_definecodeid_Dropdownoptionstype ;
      private String Ddo_xt_definecodeid_Titlecontrolidtoreplace ;
      private String Ddo_xt_definecodeid_Sortedstatus ;
      private String Ddo_xt_definecodeid_Sortasc ;
      private String Ddo_xt_definecodeid_Sortdsc ;
      private String Ddo_xt_definecodeid_Searchbuttontext ;
      private String Ddo_xt_definecodename_Caption ;
      private String Ddo_xt_definecodename_Tooltip ;
      private String Ddo_xt_definecodename_Cls ;
      private String Ddo_xt_definecodename_Dropdownoptionstype ;
      private String Ddo_xt_definecodename_Titlecontrolidtoreplace ;
      private String Ddo_xt_definecodename_Sortedstatus ;
      private String Ddo_xt_definecodename_Sortasc ;
      private String Ddo_xt_definecodename_Sortdsc ;
      private String Ddo_xt_definecodename_Searchbuttontext ;
      private String Ddo_xt_defindcodetypeid_Caption ;
      private String Ddo_xt_defindcodetypeid_Tooltip ;
      private String Ddo_xt_defindcodetypeid_Cls ;
      private String Ddo_xt_defindcodetypeid_Dropdownoptionstype ;
      private String Ddo_xt_defindcodetypeid_Titlecontrolidtoreplace ;
      private String Ddo_xt_defindcodetypeid_Sortedstatus ;
      private String Ddo_xt_defindcodetypeid_Sortasc ;
      private String Ddo_xt_defindcodetypeid_Sortdsc ;
      private String Ddo_xt_defindcodetypeid_Searchbuttontext ;
      private String Ddo_xt_defindcodetypename_Caption ;
      private String Ddo_xt_defindcodetypename_Tooltip ;
      private String Ddo_xt_defindcodetypename_Cls ;
      private String Ddo_xt_defindcodetypename_Dropdownoptionstype ;
      private String Ddo_xt_defindcodetypename_Titlecontrolidtoreplace ;
      private String Ddo_xt_defindcodetypename_Sortedstatus ;
      private String Ddo_xt_defindcodetypename_Sortasc ;
      private String Ddo_xt_defindcodetypename_Sortdsc ;
      private String Ddo_xt_defindcodetypename_Searchbuttontext ;
      private String Ddo_xt_definecodeorder_Caption ;
      private String Ddo_xt_definecodeorder_Tooltip ;
      private String Ddo_xt_definecodeorder_Cls ;
      private String Ddo_xt_definecodeorder_Dropdownoptionstype ;
      private String Ddo_xt_definecodeorder_Titlecontrolidtoreplace ;
      private String Ddo_xt_definecodeorder_Sortedstatus ;
      private String Ddo_xt_definecodeorder_Sortasc ;
      private String Ddo_xt_definecodeorder_Sortdsc ;
      private String Ddo_xt_definecodeorder_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtXT_DefineCodeID_Title ;
      private String edtXT_DefineCodeName_Title ;
      private String edtXT_DefindcodeTypeID_Title ;
      private String edtXT_DefindcodeTypeName_Title ;
      private String edtXT_DefineCodeOrder_Title ;
      private String subGrid_Header ;
      private String edtavSelect_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_xt_definecodeid_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_xt_definecodeidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_xt_definecodename_Internalname ;
      private String edtavDdo_xt_definecodenametitlecontrolidtoreplace_Internalname ;
      private String Ddo_xt_defindcodetypeid_Internalname ;
      private String edtavDdo_xt_defindcodetypeidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_xt_defindcodetypename_Internalname ;
      private String edtavDdo_xt_defindcodetypenametitlecontrolidtoreplace_Internalname ;
      private String Ddo_xt_definecodeorder_Internalname ;
      private String edtavDdo_xt_definecodeordertitlecontrolidtoreplace_Internalname ;
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
      private String edtXT_DefineCodeID_Internalname ;
      private String edtXT_DefineCodeName_Internalname ;
      private String edtXT_DefindcodeTypeID_Internalname ;
      private String edtXT_DefindcodeTypeName_Internalname ;
      private String edtXT_DefineCodeOrder_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_12_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavSelect_Jsonclick ;
      private String ROClassString ;
      private String edtXT_DefineCodeID_Jsonclick ;
      private String edtXT_DefineCodeName_Jsonclick ;
      private String edtXT_DefindcodeTypeID_Jsonclick ;
      private String edtXT_DefindcodeTypeName_Jsonclick ;
      private String edtXT_DefineCodeOrder_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV12OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_xt_definecodeid_Includesortasc ;
      private bool Ddo_xt_definecodeid_Includesortdsc ;
      private bool Ddo_xt_definecodeid_Includefilter ;
      private bool Ddo_xt_definecodeid_Includedatalist ;
      private bool Ddo_xt_definecodename_Includesortasc ;
      private bool Ddo_xt_definecodename_Includesortdsc ;
      private bool Ddo_xt_definecodename_Includefilter ;
      private bool Ddo_xt_definecodename_Includedatalist ;
      private bool Ddo_xt_defindcodetypeid_Includesortasc ;
      private bool Ddo_xt_defindcodetypeid_Includesortdsc ;
      private bool Ddo_xt_defindcodetypeid_Includefilter ;
      private bool Ddo_xt_defindcodetypeid_Includedatalist ;
      private bool Ddo_xt_defindcodetypename_Includesortasc ;
      private bool Ddo_xt_defindcodetypename_Includesortdsc ;
      private bool Ddo_xt_defindcodetypename_Includefilter ;
      private bool Ddo_xt_defindcodetypename_Includedatalist ;
      private bool Ddo_xt_definecodeorder_Includesortasc ;
      private bool Ddo_xt_definecodeorder_Includesortdsc ;
      private bool Ddo_xt_definecodeorder_Includefilter ;
      private bool Ddo_xt_definecodeorder_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_12_Refreshing=false ;
      private bool n168XT_DefineCodeName ;
      private bool n166XT_DefindcodeTypeName ;
      private bool n171XT_DefineCodeOrder ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool gx_refresh_fired ;
      private bool AV26Select_IsBlob ;
      private String AV9InOutXT_DefineCodeName ;
      private String wcpOAV9InOutXT_DefineCodeName ;
      private String AV14ddo_XT_DefineCodeIDTitleControlIdToReplace ;
      private String AV16ddo_XT_DefineCodeNameTitleControlIdToReplace ;
      private String AV18ddo_XT_DefindcodeTypeIDTitleControlIdToReplace ;
      private String AV20ddo_XT_DefindcodeTypeNameTitleControlIdToReplace ;
      private String AV28ddo_XT_DefineCodeOrderTitleControlIdToReplace ;
      private String A168XT_DefineCodeName ;
      private String A166XT_DefindcodeTypeName ;
      private String AV32Select_GXI ;
      private String AV26Select ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_xt_definecodeid ;
      private GXUserControl ucDdo_xt_definecodename ;
      private GXUserControl ucDdo_xt_defindcodetypeid ;
      private GXUserControl ucDdo_xt_defindcodetypename ;
      private GXUserControl ucDdo_xt_definecodeorder ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private long aP0_InOutXT_DefineCodeID ;
      private String aP1_InOutXT_DefineCodeName ;
      private IDataStoreProvider pr_default ;
      private short[] H002H2_A171XT_DefineCodeOrder ;
      private bool[] H002H2_n171XT_DefineCodeOrder ;
      private String[] H002H2_A166XT_DefindcodeTypeName ;
      private bool[] H002H2_n166XT_DefindcodeTypeName ;
      private long[] H002H2_A165XT_DefindcodeTypeID ;
      private String[] H002H2_A168XT_DefineCodeName ;
      private bool[] H002H2_n168XT_DefineCodeName ;
      private long[] H002H2_A167XT_DefineCodeID ;
      private long[] H002H3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV13XT_DefineCodeIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV15XT_DefineCodeNameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV17XT_DefindcodeTypeIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV19XT_DefindcodeTypeNameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV27XT_DefineCodeOrderTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV21DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class xt_definecodeprompt__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H002H2( IGxContext context ,
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
         sSelectString = " T1.[XT_DefineCodeOrder], T2.[XT_DefindcodeTypeName], T1.[XT_DefindcodeTypeID], T1.[XT_DefineCodeName], T1.[XT_DefineCodeID]";
         sFromString = " FROM ([XT_DefineCode] T1 WITH (NOLOCK) INNER JOIN [XT_DefindcodeType] T2 WITH (NOLOCK) ON T2.[XT_DefindcodeTypeID] = T1.[XT_DefindcodeTypeID])";
         sOrderString = "";
         if ( ( AV11OrderedBy == 1 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[XT_DefineCodeID]";
         }
         else if ( ( AV11OrderedBy == 1 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[XT_DefineCodeID] DESC";
         }
         else if ( ( AV11OrderedBy == 2 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[XT_DefineCodeName]";
         }
         else if ( ( AV11OrderedBy == 2 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[XT_DefineCodeName] DESC";
         }
         else if ( ( AV11OrderedBy == 3 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[XT_DefindcodeTypeID]";
         }
         else if ( ( AV11OrderedBy == 3 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[XT_DefindcodeTypeID] DESC";
         }
         else if ( ( AV11OrderedBy == 4 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T2.[XT_DefindcodeTypeName]";
         }
         else if ( ( AV11OrderedBy == 4 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T2.[XT_DefindcodeTypeName] DESC";
         }
         else if ( ( AV11OrderedBy == 5 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[XT_DefineCodeOrder]";
         }
         else if ( ( AV11OrderedBy == 5 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[XT_DefineCodeOrder] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY T1.[XT_DefineCodeID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H002H3( IGxContext context ,
                                             short AV11OrderedBy ,
                                             bool AV12OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM ([XT_DefineCode] T1 WITH (NOLOCK) INNER JOIN [XT_DefindcodeType] T2 WITH (NOLOCK) ON T2.[XT_DefindcodeTypeID] = T1.[XT_DefindcodeTypeID])";
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
                     return conditional_H002H2(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
               case 1 :
                     return conditional_H002H3(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
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
          Object[] prmH002H2 ;
          prmH002H2 = new Object[] {
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH002H3 ;
          prmH002H3 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H002H2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002H2,11,0,true,false )
             ,new CursorDef("H002H3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002H3,1,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((long[]) buf[4])[0] = rslt.getLong(3) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((long[]) buf[7])[0] = rslt.getLong(5) ;
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
