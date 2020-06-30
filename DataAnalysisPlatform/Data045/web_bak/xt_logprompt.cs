/*
               File: XT_LogPrompt
        Description: 选择系统日志
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:42:21.23
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
   public class xt_logprompt : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public xt_logprompt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public xt_logprompt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_InOutXT_LogID ,
                           ref long aP1_InOutXT_LogUserID )
      {
         this.AV8InOutXT_LogID = aP0_InOutXT_LogID;
         this.AV9InOutXT_LogUserID = aP1_InOutXT_LogUserID;
         executePrivate();
         aP0_InOutXT_LogID=this.AV8InOutXT_LogID;
         aP1_InOutXT_LogUserID=this.AV9InOutXT_LogUserID;
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
               AV14ddo_XT_LogIDTitleControlIdToReplace = GetNextPar( );
               AV16ddo_XT_LogUserIDTitleControlIdToReplace = GetNextPar( );
               AV18ddo_XT_LogSecUserNameTitleControlIdToReplace = GetNextPar( );
               AV20ddo_XT_LogTimeTitleControlIdToReplace = GetNextPar( );
               AV22ddo_XT_LogPageTitleControlIdToReplace = GetNextPar( );
               AV24ddo_XT_LogButtonNameTitleControlIdToReplace = GetNextPar( );
               AV26ddo_XT_LogTypeTitleControlIdToReplace = GetNextPar( );
               AV28ddo_XT_LogProviderIDTitleControlIdToReplace = GetNextPar( );
               AV30ddo_XT_LogProviderNameTitleControlIdToReplace = GetNextPar( );
               AV32ddo_XT_LogTargetTitleControlIdToReplace = GetNextPar( );
               AV34ddo_XT_LogSonTargetTitleControlIdToReplace = GetNextPar( );
               AV36ddo_XT_LogTargetModuleTitleControlIdToReplace = GetNextPar( );
               AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace = GetNextPar( );
               AV40ddo_XT_LogTargetOperateTitleControlIdToReplace = GetNextPar( );
               AV42ddo_XT_LogDescriptionTitleControlIdToReplace = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_XT_LogIDTitleControlIdToReplace, AV16ddo_XT_LogUserIDTitleControlIdToReplace, AV18ddo_XT_LogSecUserNameTitleControlIdToReplace, AV20ddo_XT_LogTimeTitleControlIdToReplace, AV22ddo_XT_LogPageTitleControlIdToReplace, AV24ddo_XT_LogButtonNameTitleControlIdToReplace, AV26ddo_XT_LogTypeTitleControlIdToReplace, AV28ddo_XT_LogProviderIDTitleControlIdToReplace, AV30ddo_XT_LogProviderNameTitleControlIdToReplace, AV32ddo_XT_LogTargetTitleControlIdToReplace, AV34ddo_XT_LogSonTargetTitleControlIdToReplace, AV36ddo_XT_LogTargetModuleTitleControlIdToReplace, AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace, AV40ddo_XT_LogTargetOperateTitleControlIdToReplace, AV42ddo_XT_LogDescriptionTitleControlIdToReplace) ;
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
               AV8InOutXT_LogID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutXT_LogID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutXT_LogID), 18, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV9InOutXT_LogUserID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutXT_LogUserID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9InOutXT_LogUserID), 18, 0)));
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
            PA4H2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV51Pgmname = "XT_LogPrompt";
               context.Gx_err = 0;
               WS4H2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE4H2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202279422156", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-zh.js", "?"+context.GetBuildNumber( 127771), false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("xt_logprompt.aspx") + "?" + UrlEncode("" +AV8InOutXT_LogID) + "," + UrlEncode("" +AV9InOutXT_LogUserID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV45GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV47GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV46GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV43DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV43DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_LOGIDTITLEFILTERDATA", AV13XT_LogIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_LOGIDTITLEFILTERDATA", AV13XT_LogIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_LOGUSERIDTITLEFILTERDATA", AV15XT_LogUserIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_LOGUSERIDTITLEFILTERDATA", AV15XT_LogUserIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_LOGSECUSERNAMETITLEFILTERDATA", AV17XT_LogSecUserNameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_LOGSECUSERNAMETITLEFILTERDATA", AV17XT_LogSecUserNameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_LOGTIMETITLEFILTERDATA", AV19XT_LogTimeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_LOGTIMETITLEFILTERDATA", AV19XT_LogTimeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_LOGPAGETITLEFILTERDATA", AV21XT_LogPageTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_LOGPAGETITLEFILTERDATA", AV21XT_LogPageTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_LOGBUTTONNAMETITLEFILTERDATA", AV23XT_LogButtonNameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_LOGBUTTONNAMETITLEFILTERDATA", AV23XT_LogButtonNameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_LOGTYPETITLEFILTERDATA", AV25XT_LogTypeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_LOGTYPETITLEFILTERDATA", AV25XT_LogTypeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_LOGPROVIDERIDTITLEFILTERDATA", AV27XT_LogProviderIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_LOGPROVIDERIDTITLEFILTERDATA", AV27XT_LogProviderIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_LOGPROVIDERNAMETITLEFILTERDATA", AV29XT_LogProviderNameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_LOGPROVIDERNAMETITLEFILTERDATA", AV29XT_LogProviderNameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_LOGTARGETTITLEFILTERDATA", AV31XT_LogTargetTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_LOGTARGETTITLEFILTERDATA", AV31XT_LogTargetTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_LOGSONTARGETTITLEFILTERDATA", AV33XT_LogSonTargetTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_LOGSONTARGETTITLEFILTERDATA", AV33XT_LogSonTargetTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_LOGTARGETMODULETITLEFILTERDATA", AV35XT_LogTargetModuleTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_LOGTARGETMODULETITLEFILTERDATA", AV35XT_LogTargetModuleTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_LOGTARGETSONMODULETITLEFILTERDATA", AV37XT_LogTargetSonModuleTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_LOGTARGETSONMODULETITLEFILTERDATA", AV37XT_LogTargetSonModuleTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_LOGTARGETOPERATETITLEFILTERDATA", AV39XT_LogTargetOperateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_LOGTARGETOPERATETITLEFILTERDATA", AV39XT_LogTargetOperateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_LOGDESCRIPTIONTITLEFILTERDATA", AV41XT_LogDescriptionTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_LOGDESCRIPTIONTITLEFILTERDATA", AV41XT_LogDescriptionTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vINOUTXT_LOGID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8InOutXT_LogID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINOUTXT_LOGUSERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9InOutXT_LogUserID), 18, 0, ".", "")));
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
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGID_Caption", StringUtil.RTrim( Ddo_xt_logid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGID_Tooltip", StringUtil.RTrim( Ddo_xt_logid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGID_Cls", StringUtil.RTrim( Ddo_xt_logid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGID_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_logid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_logid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGID_Includesortasc", StringUtil.BoolToStr( Ddo_xt_logid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGID_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_logid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGID_Sortedstatus", StringUtil.RTrim( Ddo_xt_logid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGID_Includefilter", StringUtil.BoolToStr( Ddo_xt_logid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGID_Includedatalist", StringUtil.BoolToStr( Ddo_xt_logid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGID_Sortasc", StringUtil.RTrim( Ddo_xt_logid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGID_Sortdsc", StringUtil.RTrim( Ddo_xt_logid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGID_Searchbuttontext", StringUtil.RTrim( Ddo_xt_logid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGUSERID_Caption", StringUtil.RTrim( Ddo_xt_loguserid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGUSERID_Tooltip", StringUtil.RTrim( Ddo_xt_loguserid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGUSERID_Cls", StringUtil.RTrim( Ddo_xt_loguserid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGUSERID_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_loguserid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGUSERID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_loguserid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGUSERID_Includesortasc", StringUtil.BoolToStr( Ddo_xt_loguserid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGUSERID_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_loguserid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGUSERID_Sortedstatus", StringUtil.RTrim( Ddo_xt_loguserid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGUSERID_Includefilter", StringUtil.BoolToStr( Ddo_xt_loguserid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGUSERID_Includedatalist", StringUtil.BoolToStr( Ddo_xt_loguserid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGUSERID_Sortasc", StringUtil.RTrim( Ddo_xt_loguserid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGUSERID_Sortdsc", StringUtil.RTrim( Ddo_xt_loguserid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGUSERID_Searchbuttontext", StringUtil.RTrim( Ddo_xt_loguserid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGSECUSERNAME_Caption", StringUtil.RTrim( Ddo_xt_logsecusername_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGSECUSERNAME_Tooltip", StringUtil.RTrim( Ddo_xt_logsecusername_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGSECUSERNAME_Cls", StringUtil.RTrim( Ddo_xt_logsecusername_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGSECUSERNAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_logsecusername_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGSECUSERNAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_logsecusername_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGSECUSERNAME_Includesortasc", StringUtil.BoolToStr( Ddo_xt_logsecusername_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGSECUSERNAME_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_logsecusername_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGSECUSERNAME_Sortedstatus", StringUtil.RTrim( Ddo_xt_logsecusername_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGSECUSERNAME_Includefilter", StringUtil.BoolToStr( Ddo_xt_logsecusername_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGSECUSERNAME_Includedatalist", StringUtil.BoolToStr( Ddo_xt_logsecusername_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGSECUSERNAME_Sortasc", StringUtil.RTrim( Ddo_xt_logsecusername_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGSECUSERNAME_Sortdsc", StringUtil.RTrim( Ddo_xt_logsecusername_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGSECUSERNAME_Searchbuttontext", StringUtil.RTrim( Ddo_xt_logsecusername_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTIME_Caption", StringUtil.RTrim( Ddo_xt_logtime_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTIME_Tooltip", StringUtil.RTrim( Ddo_xt_logtime_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTIME_Cls", StringUtil.RTrim( Ddo_xt_logtime_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTIME_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_logtime_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTIME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_logtime_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTIME_Includesortasc", StringUtil.BoolToStr( Ddo_xt_logtime_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTIME_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_logtime_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTIME_Sortedstatus", StringUtil.RTrim( Ddo_xt_logtime_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTIME_Includefilter", StringUtil.BoolToStr( Ddo_xt_logtime_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTIME_Includedatalist", StringUtil.BoolToStr( Ddo_xt_logtime_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTIME_Sortasc", StringUtil.RTrim( Ddo_xt_logtime_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTIME_Sortdsc", StringUtil.RTrim( Ddo_xt_logtime_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTIME_Searchbuttontext", StringUtil.RTrim( Ddo_xt_logtime_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPAGE_Caption", StringUtil.RTrim( Ddo_xt_logpage_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPAGE_Tooltip", StringUtil.RTrim( Ddo_xt_logpage_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPAGE_Cls", StringUtil.RTrim( Ddo_xt_logpage_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPAGE_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_logpage_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPAGE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_logpage_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPAGE_Includesortasc", StringUtil.BoolToStr( Ddo_xt_logpage_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPAGE_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_logpage_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPAGE_Sortedstatus", StringUtil.RTrim( Ddo_xt_logpage_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPAGE_Includefilter", StringUtil.BoolToStr( Ddo_xt_logpage_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPAGE_Includedatalist", StringUtil.BoolToStr( Ddo_xt_logpage_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPAGE_Sortasc", StringUtil.RTrim( Ddo_xt_logpage_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPAGE_Sortdsc", StringUtil.RTrim( Ddo_xt_logpage_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPAGE_Searchbuttontext", StringUtil.RTrim( Ddo_xt_logpage_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGBUTTONNAME_Caption", StringUtil.RTrim( Ddo_xt_logbuttonname_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGBUTTONNAME_Tooltip", StringUtil.RTrim( Ddo_xt_logbuttonname_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGBUTTONNAME_Cls", StringUtil.RTrim( Ddo_xt_logbuttonname_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGBUTTONNAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_logbuttonname_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGBUTTONNAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_logbuttonname_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGBUTTONNAME_Includesortasc", StringUtil.BoolToStr( Ddo_xt_logbuttonname_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGBUTTONNAME_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_logbuttonname_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGBUTTONNAME_Sortedstatus", StringUtil.RTrim( Ddo_xt_logbuttonname_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGBUTTONNAME_Includefilter", StringUtil.BoolToStr( Ddo_xt_logbuttonname_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGBUTTONNAME_Includedatalist", StringUtil.BoolToStr( Ddo_xt_logbuttonname_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGBUTTONNAME_Sortasc", StringUtil.RTrim( Ddo_xt_logbuttonname_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGBUTTONNAME_Sortdsc", StringUtil.RTrim( Ddo_xt_logbuttonname_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGBUTTONNAME_Searchbuttontext", StringUtil.RTrim( Ddo_xt_logbuttonname_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTYPE_Caption", StringUtil.RTrim( Ddo_xt_logtype_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTYPE_Tooltip", StringUtil.RTrim( Ddo_xt_logtype_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTYPE_Cls", StringUtil.RTrim( Ddo_xt_logtype_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTYPE_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_logtype_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTYPE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_logtype_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTYPE_Includesortasc", StringUtil.BoolToStr( Ddo_xt_logtype_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTYPE_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_logtype_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTYPE_Sortedstatus", StringUtil.RTrim( Ddo_xt_logtype_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTYPE_Includefilter", StringUtil.BoolToStr( Ddo_xt_logtype_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTYPE_Includedatalist", StringUtil.BoolToStr( Ddo_xt_logtype_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTYPE_Sortasc", StringUtil.RTrim( Ddo_xt_logtype_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTYPE_Sortdsc", StringUtil.RTrim( Ddo_xt_logtype_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTYPE_Searchbuttontext", StringUtil.RTrim( Ddo_xt_logtype_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPROVIDERID_Caption", StringUtil.RTrim( Ddo_xt_logproviderid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPROVIDERID_Tooltip", StringUtil.RTrim( Ddo_xt_logproviderid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPROVIDERID_Cls", StringUtil.RTrim( Ddo_xt_logproviderid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPROVIDERID_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_logproviderid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPROVIDERID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_logproviderid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPROVIDERID_Includesortasc", StringUtil.BoolToStr( Ddo_xt_logproviderid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPROVIDERID_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_logproviderid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPROVIDERID_Sortedstatus", StringUtil.RTrim( Ddo_xt_logproviderid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPROVIDERID_Includefilter", StringUtil.BoolToStr( Ddo_xt_logproviderid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPROVIDERID_Includedatalist", StringUtil.BoolToStr( Ddo_xt_logproviderid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPROVIDERID_Sortasc", StringUtil.RTrim( Ddo_xt_logproviderid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPROVIDERID_Sortdsc", StringUtil.RTrim( Ddo_xt_logproviderid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPROVIDERID_Searchbuttontext", StringUtil.RTrim( Ddo_xt_logproviderid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPROVIDERNAME_Caption", StringUtil.RTrim( Ddo_xt_logprovidername_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPROVIDERNAME_Tooltip", StringUtil.RTrim( Ddo_xt_logprovidername_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPROVIDERNAME_Cls", StringUtil.RTrim( Ddo_xt_logprovidername_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPROVIDERNAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_logprovidername_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPROVIDERNAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_logprovidername_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPROVIDERNAME_Includesortasc", StringUtil.BoolToStr( Ddo_xt_logprovidername_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPROVIDERNAME_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_logprovidername_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPROVIDERNAME_Sortedstatus", StringUtil.RTrim( Ddo_xt_logprovidername_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPROVIDERNAME_Includefilter", StringUtil.BoolToStr( Ddo_xt_logprovidername_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPROVIDERNAME_Includedatalist", StringUtil.BoolToStr( Ddo_xt_logprovidername_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPROVIDERNAME_Sortasc", StringUtil.RTrim( Ddo_xt_logprovidername_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPROVIDERNAME_Sortdsc", StringUtil.RTrim( Ddo_xt_logprovidername_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPROVIDERNAME_Searchbuttontext", StringUtil.RTrim( Ddo_xt_logprovidername_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGET_Caption", StringUtil.RTrim( Ddo_xt_logtarget_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGET_Tooltip", StringUtil.RTrim( Ddo_xt_logtarget_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGET_Cls", StringUtil.RTrim( Ddo_xt_logtarget_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGET_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_logtarget_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGET_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_logtarget_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGET_Includesortasc", StringUtil.BoolToStr( Ddo_xt_logtarget_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGET_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_logtarget_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGET_Sortedstatus", StringUtil.RTrim( Ddo_xt_logtarget_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGET_Includefilter", StringUtil.BoolToStr( Ddo_xt_logtarget_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGET_Includedatalist", StringUtil.BoolToStr( Ddo_xt_logtarget_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGET_Sortasc", StringUtil.RTrim( Ddo_xt_logtarget_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGET_Sortdsc", StringUtil.RTrim( Ddo_xt_logtarget_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGET_Searchbuttontext", StringUtil.RTrim( Ddo_xt_logtarget_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGSONTARGET_Caption", StringUtil.RTrim( Ddo_xt_logsontarget_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGSONTARGET_Tooltip", StringUtil.RTrim( Ddo_xt_logsontarget_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGSONTARGET_Cls", StringUtil.RTrim( Ddo_xt_logsontarget_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGSONTARGET_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_logsontarget_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGSONTARGET_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_logsontarget_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGSONTARGET_Includesortasc", StringUtil.BoolToStr( Ddo_xt_logsontarget_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGSONTARGET_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_logsontarget_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGSONTARGET_Sortedstatus", StringUtil.RTrim( Ddo_xt_logsontarget_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGSONTARGET_Includefilter", StringUtil.BoolToStr( Ddo_xt_logsontarget_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGSONTARGET_Includedatalist", StringUtil.BoolToStr( Ddo_xt_logsontarget_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGSONTARGET_Sortasc", StringUtil.RTrim( Ddo_xt_logsontarget_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGSONTARGET_Sortdsc", StringUtil.RTrim( Ddo_xt_logsontarget_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGSONTARGET_Searchbuttontext", StringUtil.RTrim( Ddo_xt_logsontarget_Searchbuttontext));
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
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETSONMODULE_Caption", StringUtil.RTrim( Ddo_xt_logtargetsonmodule_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETSONMODULE_Tooltip", StringUtil.RTrim( Ddo_xt_logtargetsonmodule_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETSONMODULE_Cls", StringUtil.RTrim( Ddo_xt_logtargetsonmodule_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETSONMODULE_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_logtargetsonmodule_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETSONMODULE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_logtargetsonmodule_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETSONMODULE_Includesortasc", StringUtil.BoolToStr( Ddo_xt_logtargetsonmodule_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETSONMODULE_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_logtargetsonmodule_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETSONMODULE_Sortedstatus", StringUtil.RTrim( Ddo_xt_logtargetsonmodule_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETSONMODULE_Includefilter", StringUtil.BoolToStr( Ddo_xt_logtargetsonmodule_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETSONMODULE_Includedatalist", StringUtil.BoolToStr( Ddo_xt_logtargetsonmodule_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETSONMODULE_Sortasc", StringUtil.RTrim( Ddo_xt_logtargetsonmodule_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETSONMODULE_Sortdsc", StringUtil.RTrim( Ddo_xt_logtargetsonmodule_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETSONMODULE_Searchbuttontext", StringUtil.RTrim( Ddo_xt_logtargetsonmodule_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETOPERATE_Caption", StringUtil.RTrim( Ddo_xt_logtargetoperate_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETOPERATE_Tooltip", StringUtil.RTrim( Ddo_xt_logtargetoperate_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETOPERATE_Cls", StringUtil.RTrim( Ddo_xt_logtargetoperate_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETOPERATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_xt_logtargetoperate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETOPERATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_xt_logtargetoperate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETOPERATE_Includesortasc", StringUtil.BoolToStr( Ddo_xt_logtargetoperate_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETOPERATE_Includesortdsc", StringUtil.BoolToStr( Ddo_xt_logtargetoperate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETOPERATE_Sortedstatus", StringUtil.RTrim( Ddo_xt_logtargetoperate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETOPERATE_Includefilter", StringUtil.BoolToStr( Ddo_xt_logtargetoperate_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETOPERATE_Includedatalist", StringUtil.BoolToStr( Ddo_xt_logtargetoperate_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETOPERATE_Sortasc", StringUtil.RTrim( Ddo_xt_logtargetoperate_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETOPERATE_Sortdsc", StringUtil.RTrim( Ddo_xt_logtargetoperate_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETOPERATE_Searchbuttontext", StringUtil.RTrim( Ddo_xt_logtargetoperate_Searchbuttontext));
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
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGID_Activeeventkey", StringUtil.RTrim( Ddo_xt_logid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGUSERID_Activeeventkey", StringUtil.RTrim( Ddo_xt_loguserid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGSECUSERNAME_Activeeventkey", StringUtil.RTrim( Ddo_xt_logsecusername_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTIME_Activeeventkey", StringUtil.RTrim( Ddo_xt_logtime_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPAGE_Activeeventkey", StringUtil.RTrim( Ddo_xt_logpage_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGBUTTONNAME_Activeeventkey", StringUtil.RTrim( Ddo_xt_logbuttonname_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTYPE_Activeeventkey", StringUtil.RTrim( Ddo_xt_logtype_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPROVIDERID_Activeeventkey", StringUtil.RTrim( Ddo_xt_logproviderid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPROVIDERNAME_Activeeventkey", StringUtil.RTrim( Ddo_xt_logprovidername_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGET_Activeeventkey", StringUtil.RTrim( Ddo_xt_logtarget_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGSONTARGET_Activeeventkey", StringUtil.RTrim( Ddo_xt_logsontarget_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETMODULE_Activeeventkey", StringUtil.RTrim( Ddo_xt_logtargetmodule_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETSONMODULE_Activeeventkey", StringUtil.RTrim( Ddo_xt_logtargetsonmodule_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETOPERATE_Activeeventkey", StringUtil.RTrim( Ddo_xt_logtargetoperate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGDESCRIPTION_Activeeventkey", StringUtil.RTrim( Ddo_xt_logdescription_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGID_Activeeventkey", StringUtil.RTrim( Ddo_xt_logid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGUSERID_Activeeventkey", StringUtil.RTrim( Ddo_xt_loguserid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGSECUSERNAME_Activeeventkey", StringUtil.RTrim( Ddo_xt_logsecusername_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTIME_Activeeventkey", StringUtil.RTrim( Ddo_xt_logtime_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPAGE_Activeeventkey", StringUtil.RTrim( Ddo_xt_logpage_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGBUTTONNAME_Activeeventkey", StringUtil.RTrim( Ddo_xt_logbuttonname_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTYPE_Activeeventkey", StringUtil.RTrim( Ddo_xt_logtype_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPROVIDERID_Activeeventkey", StringUtil.RTrim( Ddo_xt_logproviderid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGPROVIDERNAME_Activeeventkey", StringUtil.RTrim( Ddo_xt_logprovidername_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGET_Activeeventkey", StringUtil.RTrim( Ddo_xt_logtarget_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGSONTARGET_Activeeventkey", StringUtil.RTrim( Ddo_xt_logsontarget_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETMODULE_Activeeventkey", StringUtil.RTrim( Ddo_xt_logtargetmodule_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETSONMODULE_Activeeventkey", StringUtil.RTrim( Ddo_xt_logtargetsonmodule_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGTARGETOPERATE_Activeeventkey", StringUtil.RTrim( Ddo_xt_logtargetoperate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_LOGDESCRIPTION_Activeeventkey", StringUtil.RTrim( Ddo_xt_logdescription_Activeeventkey));
      }

      protected void RenderHtmlCloseForm4H2( )
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
         return "XT_LogPrompt" ;
      }

      public override String GetPgmdesc( )
      {
         return "选择系统日志" ;
      }

      protected void WB4H0( )
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
               if ( edtXT_LogID_Titleformat == 0 )
               {
                  context.SendWebValue( edtXT_LogID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtXT_LogID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtXT_LogUserID_Titleformat == 0 )
               {
                  context.SendWebValue( edtXT_LogUserID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtXT_LogUserID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtXT_LogSecUserName_Titleformat == 0 )
               {
                  context.SendWebValue( edtXT_LogSecUserName_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtXT_LogSecUserName_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtXT_LogTime_Titleformat == 0 )
               {
                  context.SendWebValue( edtXT_LogTime_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtXT_LogTime_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( cmbXT_LogPage_Titleformat == 0 )
               {
                  context.SendWebValue( cmbXT_LogPage.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( cmbXT_LogPage.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtXT_LogButtonName_Titleformat == 0 )
               {
                  context.SendWebValue( edtXT_LogButtonName_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtXT_LogButtonName_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtXT_LogType_Titleformat == 0 )
               {
                  context.SendWebValue( edtXT_LogType_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtXT_LogType_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtXT_LogProviderID_Titleformat == 0 )
               {
                  context.SendWebValue( edtXT_LogProviderID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtXT_LogProviderID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtXT_LogProviderName_Titleformat == 0 )
               {
                  context.SendWebValue( edtXT_LogProviderName_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtXT_LogProviderName_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtXT_LogTarget_Titleformat == 0 )
               {
                  context.SendWebValue( edtXT_LogTarget_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtXT_LogTarget_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtXT_LogSonTarget_Titleformat == 0 )
               {
                  context.SendWebValue( edtXT_LogSonTarget_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtXT_LogSonTarget_Title) ;
               }
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtXT_LogTargetSonModule_Titleformat == 0 )
               {
                  context.SendWebValue( edtXT_LogTargetSonModule_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtXT_LogTargetSonModule_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( cmbXT_LogTargetOperate_Titleformat == 0 )
               {
                  context.SendWebValue( cmbXT_LogTargetOperate.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( cmbXT_LogTargetOperate.Title.Text) ;
               }
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV48Select));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavSelect_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A173XT_LogID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtXT_LogID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtXT_LogID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A214XT_LogUserID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtXT_LogUserID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtXT_LogUserID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A174XT_LogSecUserName);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtXT_LogSecUserName_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtXT_LogSecUserName_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.TToC( A220XT_LogTime, 10, 8, 0, 0, "/", ":", " "));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtXT_LogTime_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtXT_LogTime_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A176XT_LogPage);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( cmbXT_LogPage.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbXT_LogPage_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A177XT_LogButtonName);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtXT_LogButtonName_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtXT_LogButtonName_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A213XT_LogType);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtXT_LogType_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtXT_LogType_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A215XT_LogProviderID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtXT_LogProviderID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtXT_LogProviderID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A219XT_LogProviderName);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtXT_LogProviderName_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtXT_LogProviderName_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A216XT_LogTarget);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtXT_LogTarget_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtXT_LogTarget_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A223XT_LogSonTarget);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtXT_LogSonTarget_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtXT_LogSonTarget_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A217XT_LogTargetModule);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtXT_LogTargetModule_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtXT_LogTargetModule_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A222XT_LogTargetSonModule);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtXT_LogTargetSonModule_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtXT_LogTargetSonModule_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A218XT_LogTargetOperate);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( cmbXT_LogTargetOperate.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbXT_LogTargetOperate_Titleformat), 4, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV45GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV47GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV46GridPageSize);
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
            ucDdo_xt_logid.SetProperty("Caption", Ddo_xt_logid_Caption);
            ucDdo_xt_logid.SetProperty("Tooltip", Ddo_xt_logid_Tooltip);
            ucDdo_xt_logid.SetProperty("Cls", Ddo_xt_logid_Cls);
            ucDdo_xt_logid.SetProperty("DropDownOptionsType", Ddo_xt_logid_Dropdownoptionstype);
            ucDdo_xt_logid.SetProperty("IncludeSortASC", Ddo_xt_logid_Includesortasc);
            ucDdo_xt_logid.SetProperty("IncludeSortDSC", Ddo_xt_logid_Includesortdsc);
            ucDdo_xt_logid.SetProperty("IncludeFilter", Ddo_xt_logid_Includefilter);
            ucDdo_xt_logid.SetProperty("IncludeDataList", Ddo_xt_logid_Includedatalist);
            ucDdo_xt_logid.SetProperty("SortASC", Ddo_xt_logid_Sortasc);
            ucDdo_xt_logid.SetProperty("SortDSC", Ddo_xt_logid_Sortdsc);
            ucDdo_xt_logid.SetProperty("SearchButtonText", Ddo_xt_logid_Searchbuttontext);
            ucDdo_xt_logid.SetProperty("DropDownOptionsTitleSettingsIcons", AV43DDO_TitleSettingsIcons);
            ucDdo_xt_logid.SetProperty("DropDownOptionsData", AV13XT_LogIDTitleFilterData);
            ucDdo_xt_logid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_logid_Internalname, "DDO_XT_LOGIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_logidtitlecontrolidtoreplace_Internalname, AV14ddo_XT_LogIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", 0, edtavDdo_xt_logidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_LogPrompt.htm");
            /* User Defined Control */
            ucDdo_xt_loguserid.SetProperty("Caption", Ddo_xt_loguserid_Caption);
            ucDdo_xt_loguserid.SetProperty("Tooltip", Ddo_xt_loguserid_Tooltip);
            ucDdo_xt_loguserid.SetProperty("Cls", Ddo_xt_loguserid_Cls);
            ucDdo_xt_loguserid.SetProperty("DropDownOptionsType", Ddo_xt_loguserid_Dropdownoptionstype);
            ucDdo_xt_loguserid.SetProperty("IncludeSortASC", Ddo_xt_loguserid_Includesortasc);
            ucDdo_xt_loguserid.SetProperty("IncludeSortDSC", Ddo_xt_loguserid_Includesortdsc);
            ucDdo_xt_loguserid.SetProperty("IncludeFilter", Ddo_xt_loguserid_Includefilter);
            ucDdo_xt_loguserid.SetProperty("IncludeDataList", Ddo_xt_loguserid_Includedatalist);
            ucDdo_xt_loguserid.SetProperty("SortASC", Ddo_xt_loguserid_Sortasc);
            ucDdo_xt_loguserid.SetProperty("SortDSC", Ddo_xt_loguserid_Sortdsc);
            ucDdo_xt_loguserid.SetProperty("SearchButtonText", Ddo_xt_loguserid_Searchbuttontext);
            ucDdo_xt_loguserid.SetProperty("DropDownOptionsTitleSettingsIcons", AV43DDO_TitleSettingsIcons);
            ucDdo_xt_loguserid.SetProperty("DropDownOptionsData", AV15XT_LogUserIDTitleFilterData);
            ucDdo_xt_loguserid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_loguserid_Internalname, "DDO_XT_LOGUSERIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_loguseridtitlecontrolidtoreplace_Internalname, AV16ddo_XT_LogUserIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", 0, edtavDdo_xt_loguseridtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_LogPrompt.htm");
            /* User Defined Control */
            ucDdo_xt_logsecusername.SetProperty("Caption", Ddo_xt_logsecusername_Caption);
            ucDdo_xt_logsecusername.SetProperty("Tooltip", Ddo_xt_logsecusername_Tooltip);
            ucDdo_xt_logsecusername.SetProperty("Cls", Ddo_xt_logsecusername_Cls);
            ucDdo_xt_logsecusername.SetProperty("DropDownOptionsType", Ddo_xt_logsecusername_Dropdownoptionstype);
            ucDdo_xt_logsecusername.SetProperty("IncludeSortASC", Ddo_xt_logsecusername_Includesortasc);
            ucDdo_xt_logsecusername.SetProperty("IncludeSortDSC", Ddo_xt_logsecusername_Includesortdsc);
            ucDdo_xt_logsecusername.SetProperty("IncludeFilter", Ddo_xt_logsecusername_Includefilter);
            ucDdo_xt_logsecusername.SetProperty("IncludeDataList", Ddo_xt_logsecusername_Includedatalist);
            ucDdo_xt_logsecusername.SetProperty("SortASC", Ddo_xt_logsecusername_Sortasc);
            ucDdo_xt_logsecusername.SetProperty("SortDSC", Ddo_xt_logsecusername_Sortdsc);
            ucDdo_xt_logsecusername.SetProperty("SearchButtonText", Ddo_xt_logsecusername_Searchbuttontext);
            ucDdo_xt_logsecusername.SetProperty("DropDownOptionsTitleSettingsIcons", AV43DDO_TitleSettingsIcons);
            ucDdo_xt_logsecusername.SetProperty("DropDownOptionsData", AV17XT_LogSecUserNameTitleFilterData);
            ucDdo_xt_logsecusername.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_logsecusername_Internalname, "DDO_XT_LOGSECUSERNAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_logsecusernametitlecontrolidtoreplace_Internalname, AV18ddo_XT_LogSecUserNameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,41);\"", 0, edtavDdo_xt_logsecusernametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_LogPrompt.htm");
            /* User Defined Control */
            ucDdo_xt_logtime.SetProperty("Caption", Ddo_xt_logtime_Caption);
            ucDdo_xt_logtime.SetProperty("Tooltip", Ddo_xt_logtime_Tooltip);
            ucDdo_xt_logtime.SetProperty("Cls", Ddo_xt_logtime_Cls);
            ucDdo_xt_logtime.SetProperty("DropDownOptionsType", Ddo_xt_logtime_Dropdownoptionstype);
            ucDdo_xt_logtime.SetProperty("IncludeSortASC", Ddo_xt_logtime_Includesortasc);
            ucDdo_xt_logtime.SetProperty("IncludeSortDSC", Ddo_xt_logtime_Includesortdsc);
            ucDdo_xt_logtime.SetProperty("IncludeFilter", Ddo_xt_logtime_Includefilter);
            ucDdo_xt_logtime.SetProperty("IncludeDataList", Ddo_xt_logtime_Includedatalist);
            ucDdo_xt_logtime.SetProperty("SortASC", Ddo_xt_logtime_Sortasc);
            ucDdo_xt_logtime.SetProperty("SortDSC", Ddo_xt_logtime_Sortdsc);
            ucDdo_xt_logtime.SetProperty("SearchButtonText", Ddo_xt_logtime_Searchbuttontext);
            ucDdo_xt_logtime.SetProperty("DropDownOptionsTitleSettingsIcons", AV43DDO_TitleSettingsIcons);
            ucDdo_xt_logtime.SetProperty("DropDownOptionsData", AV19XT_LogTimeTitleFilterData);
            ucDdo_xt_logtime.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_logtime_Internalname, "DDO_XT_LOGTIMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_logtimetitlecontrolidtoreplace_Internalname, AV20ddo_XT_LogTimeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", 0, edtavDdo_xt_logtimetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_LogPrompt.htm");
            /* User Defined Control */
            ucDdo_xt_logpage.SetProperty("Caption", Ddo_xt_logpage_Caption);
            ucDdo_xt_logpage.SetProperty("Tooltip", Ddo_xt_logpage_Tooltip);
            ucDdo_xt_logpage.SetProperty("Cls", Ddo_xt_logpage_Cls);
            ucDdo_xt_logpage.SetProperty("DropDownOptionsType", Ddo_xt_logpage_Dropdownoptionstype);
            ucDdo_xt_logpage.SetProperty("IncludeSortASC", Ddo_xt_logpage_Includesortasc);
            ucDdo_xt_logpage.SetProperty("IncludeSortDSC", Ddo_xt_logpage_Includesortdsc);
            ucDdo_xt_logpage.SetProperty("IncludeFilter", Ddo_xt_logpage_Includefilter);
            ucDdo_xt_logpage.SetProperty("IncludeDataList", Ddo_xt_logpage_Includedatalist);
            ucDdo_xt_logpage.SetProperty("SortASC", Ddo_xt_logpage_Sortasc);
            ucDdo_xt_logpage.SetProperty("SortDSC", Ddo_xt_logpage_Sortdsc);
            ucDdo_xt_logpage.SetProperty("SearchButtonText", Ddo_xt_logpage_Searchbuttontext);
            ucDdo_xt_logpage.SetProperty("DropDownOptionsTitleSettingsIcons", AV43DDO_TitleSettingsIcons);
            ucDdo_xt_logpage.SetProperty("DropDownOptionsData", AV21XT_LogPageTitleFilterData);
            ucDdo_xt_logpage.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_logpage_Internalname, "DDO_XT_LOGPAGEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_logpagetitlecontrolidtoreplace_Internalname, AV22ddo_XT_LogPageTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"", 0, edtavDdo_xt_logpagetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_LogPrompt.htm");
            /* User Defined Control */
            ucDdo_xt_logbuttonname.SetProperty("Caption", Ddo_xt_logbuttonname_Caption);
            ucDdo_xt_logbuttonname.SetProperty("Tooltip", Ddo_xt_logbuttonname_Tooltip);
            ucDdo_xt_logbuttonname.SetProperty("Cls", Ddo_xt_logbuttonname_Cls);
            ucDdo_xt_logbuttonname.SetProperty("DropDownOptionsType", Ddo_xt_logbuttonname_Dropdownoptionstype);
            ucDdo_xt_logbuttonname.SetProperty("IncludeSortASC", Ddo_xt_logbuttonname_Includesortasc);
            ucDdo_xt_logbuttonname.SetProperty("IncludeSortDSC", Ddo_xt_logbuttonname_Includesortdsc);
            ucDdo_xt_logbuttonname.SetProperty("IncludeFilter", Ddo_xt_logbuttonname_Includefilter);
            ucDdo_xt_logbuttonname.SetProperty("IncludeDataList", Ddo_xt_logbuttonname_Includedatalist);
            ucDdo_xt_logbuttonname.SetProperty("SortASC", Ddo_xt_logbuttonname_Sortasc);
            ucDdo_xt_logbuttonname.SetProperty("SortDSC", Ddo_xt_logbuttonname_Sortdsc);
            ucDdo_xt_logbuttonname.SetProperty("SearchButtonText", Ddo_xt_logbuttonname_Searchbuttontext);
            ucDdo_xt_logbuttonname.SetProperty("DropDownOptionsTitleSettingsIcons", AV43DDO_TitleSettingsIcons);
            ucDdo_xt_logbuttonname.SetProperty("DropDownOptionsData", AV23XT_LogButtonNameTitleFilterData);
            ucDdo_xt_logbuttonname.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_logbuttonname_Internalname, "DDO_XT_LOGBUTTONNAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_logbuttonnametitlecontrolidtoreplace_Internalname, AV24ddo_XT_LogButtonNameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,47);\"", 0, edtavDdo_xt_logbuttonnametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_LogPrompt.htm");
            /* User Defined Control */
            ucDdo_xt_logtype.SetProperty("Caption", Ddo_xt_logtype_Caption);
            ucDdo_xt_logtype.SetProperty("Tooltip", Ddo_xt_logtype_Tooltip);
            ucDdo_xt_logtype.SetProperty("Cls", Ddo_xt_logtype_Cls);
            ucDdo_xt_logtype.SetProperty("DropDownOptionsType", Ddo_xt_logtype_Dropdownoptionstype);
            ucDdo_xt_logtype.SetProperty("IncludeSortASC", Ddo_xt_logtype_Includesortasc);
            ucDdo_xt_logtype.SetProperty("IncludeSortDSC", Ddo_xt_logtype_Includesortdsc);
            ucDdo_xt_logtype.SetProperty("IncludeFilter", Ddo_xt_logtype_Includefilter);
            ucDdo_xt_logtype.SetProperty("IncludeDataList", Ddo_xt_logtype_Includedatalist);
            ucDdo_xt_logtype.SetProperty("SortASC", Ddo_xt_logtype_Sortasc);
            ucDdo_xt_logtype.SetProperty("SortDSC", Ddo_xt_logtype_Sortdsc);
            ucDdo_xt_logtype.SetProperty("SearchButtonText", Ddo_xt_logtype_Searchbuttontext);
            ucDdo_xt_logtype.SetProperty("DropDownOptionsTitleSettingsIcons", AV43DDO_TitleSettingsIcons);
            ucDdo_xt_logtype.SetProperty("DropDownOptionsData", AV25XT_LogTypeTitleFilterData);
            ucDdo_xt_logtype.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_logtype_Internalname, "DDO_XT_LOGTYPEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_logtypetitlecontrolidtoreplace_Internalname, AV26ddo_XT_LogTypeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", 0, edtavDdo_xt_logtypetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_LogPrompt.htm");
            /* User Defined Control */
            ucDdo_xt_logproviderid.SetProperty("Caption", Ddo_xt_logproviderid_Caption);
            ucDdo_xt_logproviderid.SetProperty("Tooltip", Ddo_xt_logproviderid_Tooltip);
            ucDdo_xt_logproviderid.SetProperty("Cls", Ddo_xt_logproviderid_Cls);
            ucDdo_xt_logproviderid.SetProperty("DropDownOptionsType", Ddo_xt_logproviderid_Dropdownoptionstype);
            ucDdo_xt_logproviderid.SetProperty("IncludeSortASC", Ddo_xt_logproviderid_Includesortasc);
            ucDdo_xt_logproviderid.SetProperty("IncludeSortDSC", Ddo_xt_logproviderid_Includesortdsc);
            ucDdo_xt_logproviderid.SetProperty("IncludeFilter", Ddo_xt_logproviderid_Includefilter);
            ucDdo_xt_logproviderid.SetProperty("IncludeDataList", Ddo_xt_logproviderid_Includedatalist);
            ucDdo_xt_logproviderid.SetProperty("SortASC", Ddo_xt_logproviderid_Sortasc);
            ucDdo_xt_logproviderid.SetProperty("SortDSC", Ddo_xt_logproviderid_Sortdsc);
            ucDdo_xt_logproviderid.SetProperty("SearchButtonText", Ddo_xt_logproviderid_Searchbuttontext);
            ucDdo_xt_logproviderid.SetProperty("DropDownOptionsTitleSettingsIcons", AV43DDO_TitleSettingsIcons);
            ucDdo_xt_logproviderid.SetProperty("DropDownOptionsData", AV27XT_LogProviderIDTitleFilterData);
            ucDdo_xt_logproviderid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_logproviderid_Internalname, "DDO_XT_LOGPROVIDERIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_logprovideridtitlecontrolidtoreplace_Internalname, AV28ddo_XT_LogProviderIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", 0, edtavDdo_xt_logprovideridtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_LogPrompt.htm");
            /* User Defined Control */
            ucDdo_xt_logprovidername.SetProperty("Caption", Ddo_xt_logprovidername_Caption);
            ucDdo_xt_logprovidername.SetProperty("Tooltip", Ddo_xt_logprovidername_Tooltip);
            ucDdo_xt_logprovidername.SetProperty("Cls", Ddo_xt_logprovidername_Cls);
            ucDdo_xt_logprovidername.SetProperty("DropDownOptionsType", Ddo_xt_logprovidername_Dropdownoptionstype);
            ucDdo_xt_logprovidername.SetProperty("IncludeSortASC", Ddo_xt_logprovidername_Includesortasc);
            ucDdo_xt_logprovidername.SetProperty("IncludeSortDSC", Ddo_xt_logprovidername_Includesortdsc);
            ucDdo_xt_logprovidername.SetProperty("IncludeFilter", Ddo_xt_logprovidername_Includefilter);
            ucDdo_xt_logprovidername.SetProperty("IncludeDataList", Ddo_xt_logprovidername_Includedatalist);
            ucDdo_xt_logprovidername.SetProperty("SortASC", Ddo_xt_logprovidername_Sortasc);
            ucDdo_xt_logprovidername.SetProperty("SortDSC", Ddo_xt_logprovidername_Sortdsc);
            ucDdo_xt_logprovidername.SetProperty("SearchButtonText", Ddo_xt_logprovidername_Searchbuttontext);
            ucDdo_xt_logprovidername.SetProperty("DropDownOptionsTitleSettingsIcons", AV43DDO_TitleSettingsIcons);
            ucDdo_xt_logprovidername.SetProperty("DropDownOptionsData", AV29XT_LogProviderNameTitleFilterData);
            ucDdo_xt_logprovidername.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_logprovidername_Internalname, "DDO_XT_LOGPROVIDERNAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_logprovidernametitlecontrolidtoreplace_Internalname, AV30ddo_XT_LogProviderNameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", 0, edtavDdo_xt_logprovidernametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_LogPrompt.htm");
            /* User Defined Control */
            ucDdo_xt_logtarget.SetProperty("Caption", Ddo_xt_logtarget_Caption);
            ucDdo_xt_logtarget.SetProperty("Tooltip", Ddo_xt_logtarget_Tooltip);
            ucDdo_xt_logtarget.SetProperty("Cls", Ddo_xt_logtarget_Cls);
            ucDdo_xt_logtarget.SetProperty("DropDownOptionsType", Ddo_xt_logtarget_Dropdownoptionstype);
            ucDdo_xt_logtarget.SetProperty("IncludeSortASC", Ddo_xt_logtarget_Includesortasc);
            ucDdo_xt_logtarget.SetProperty("IncludeSortDSC", Ddo_xt_logtarget_Includesortdsc);
            ucDdo_xt_logtarget.SetProperty("IncludeFilter", Ddo_xt_logtarget_Includefilter);
            ucDdo_xt_logtarget.SetProperty("IncludeDataList", Ddo_xt_logtarget_Includedatalist);
            ucDdo_xt_logtarget.SetProperty("SortASC", Ddo_xt_logtarget_Sortasc);
            ucDdo_xt_logtarget.SetProperty("SortDSC", Ddo_xt_logtarget_Sortdsc);
            ucDdo_xt_logtarget.SetProperty("SearchButtonText", Ddo_xt_logtarget_Searchbuttontext);
            ucDdo_xt_logtarget.SetProperty("DropDownOptionsTitleSettingsIcons", AV43DDO_TitleSettingsIcons);
            ucDdo_xt_logtarget.SetProperty("DropDownOptionsData", AV31XT_LogTargetTitleFilterData);
            ucDdo_xt_logtarget.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_logtarget_Internalname, "DDO_XT_LOGTARGETContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_logtargettitlecontrolidtoreplace_Internalname, AV32ddo_XT_LogTargetTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", 0, edtavDdo_xt_logtargettitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_LogPrompt.htm");
            /* User Defined Control */
            ucDdo_xt_logsontarget.SetProperty("Caption", Ddo_xt_logsontarget_Caption);
            ucDdo_xt_logsontarget.SetProperty("Tooltip", Ddo_xt_logsontarget_Tooltip);
            ucDdo_xt_logsontarget.SetProperty("Cls", Ddo_xt_logsontarget_Cls);
            ucDdo_xt_logsontarget.SetProperty("DropDownOptionsType", Ddo_xt_logsontarget_Dropdownoptionstype);
            ucDdo_xt_logsontarget.SetProperty("IncludeSortASC", Ddo_xt_logsontarget_Includesortasc);
            ucDdo_xt_logsontarget.SetProperty("IncludeSortDSC", Ddo_xt_logsontarget_Includesortdsc);
            ucDdo_xt_logsontarget.SetProperty("IncludeFilter", Ddo_xt_logsontarget_Includefilter);
            ucDdo_xt_logsontarget.SetProperty("IncludeDataList", Ddo_xt_logsontarget_Includedatalist);
            ucDdo_xt_logsontarget.SetProperty("SortASC", Ddo_xt_logsontarget_Sortasc);
            ucDdo_xt_logsontarget.SetProperty("SortDSC", Ddo_xt_logsontarget_Sortdsc);
            ucDdo_xt_logsontarget.SetProperty("SearchButtonText", Ddo_xt_logsontarget_Searchbuttontext);
            ucDdo_xt_logsontarget.SetProperty("DropDownOptionsTitleSettingsIcons", AV43DDO_TitleSettingsIcons);
            ucDdo_xt_logsontarget.SetProperty("DropDownOptionsData", AV33XT_LogSonTargetTitleFilterData);
            ucDdo_xt_logsontarget.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_logsontarget_Internalname, "DDO_XT_LOGSONTARGETContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_logsontargettitlecontrolidtoreplace_Internalname, AV34ddo_XT_LogSonTargetTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", 0, edtavDdo_xt_logsontargettitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_LogPrompt.htm");
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
            ucDdo_xt_logtargetmodule.SetProperty("DropDownOptionsTitleSettingsIcons", AV43DDO_TitleSettingsIcons);
            ucDdo_xt_logtargetmodule.SetProperty("DropDownOptionsData", AV35XT_LogTargetModuleTitleFilterData);
            ucDdo_xt_logtargetmodule.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_logtargetmodule_Internalname, "DDO_XT_LOGTARGETMODULEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_logtargetmoduletitlecontrolidtoreplace_Internalname, AV36ddo_XT_LogTargetModuleTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", 0, edtavDdo_xt_logtargetmoduletitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_LogPrompt.htm");
            /* User Defined Control */
            ucDdo_xt_logtargetsonmodule.SetProperty("Caption", Ddo_xt_logtargetsonmodule_Caption);
            ucDdo_xt_logtargetsonmodule.SetProperty("Tooltip", Ddo_xt_logtargetsonmodule_Tooltip);
            ucDdo_xt_logtargetsonmodule.SetProperty("Cls", Ddo_xt_logtargetsonmodule_Cls);
            ucDdo_xt_logtargetsonmodule.SetProperty("DropDownOptionsType", Ddo_xt_logtargetsonmodule_Dropdownoptionstype);
            ucDdo_xt_logtargetsonmodule.SetProperty("IncludeSortASC", Ddo_xt_logtargetsonmodule_Includesortasc);
            ucDdo_xt_logtargetsonmodule.SetProperty("IncludeSortDSC", Ddo_xt_logtargetsonmodule_Includesortdsc);
            ucDdo_xt_logtargetsonmodule.SetProperty("IncludeFilter", Ddo_xt_logtargetsonmodule_Includefilter);
            ucDdo_xt_logtargetsonmodule.SetProperty("IncludeDataList", Ddo_xt_logtargetsonmodule_Includedatalist);
            ucDdo_xt_logtargetsonmodule.SetProperty("SortASC", Ddo_xt_logtargetsonmodule_Sortasc);
            ucDdo_xt_logtargetsonmodule.SetProperty("SortDSC", Ddo_xt_logtargetsonmodule_Sortdsc);
            ucDdo_xt_logtargetsonmodule.SetProperty("SearchButtonText", Ddo_xt_logtargetsonmodule_Searchbuttontext);
            ucDdo_xt_logtargetsonmodule.SetProperty("DropDownOptionsTitleSettingsIcons", AV43DDO_TitleSettingsIcons);
            ucDdo_xt_logtargetsonmodule.SetProperty("DropDownOptionsData", AV37XT_LogTargetSonModuleTitleFilterData);
            ucDdo_xt_logtargetsonmodule.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_logtargetsonmodule_Internalname, "DDO_XT_LOGTARGETSONMODULEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_logtargetsonmoduletitlecontrolidtoreplace_Internalname, AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,61);\"", 0, edtavDdo_xt_logtargetsonmoduletitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_LogPrompt.htm");
            /* User Defined Control */
            ucDdo_xt_logtargetoperate.SetProperty("Caption", Ddo_xt_logtargetoperate_Caption);
            ucDdo_xt_logtargetoperate.SetProperty("Tooltip", Ddo_xt_logtargetoperate_Tooltip);
            ucDdo_xt_logtargetoperate.SetProperty("Cls", Ddo_xt_logtargetoperate_Cls);
            ucDdo_xt_logtargetoperate.SetProperty("DropDownOptionsType", Ddo_xt_logtargetoperate_Dropdownoptionstype);
            ucDdo_xt_logtargetoperate.SetProperty("IncludeSortASC", Ddo_xt_logtargetoperate_Includesortasc);
            ucDdo_xt_logtargetoperate.SetProperty("IncludeSortDSC", Ddo_xt_logtargetoperate_Includesortdsc);
            ucDdo_xt_logtargetoperate.SetProperty("IncludeFilter", Ddo_xt_logtargetoperate_Includefilter);
            ucDdo_xt_logtargetoperate.SetProperty("IncludeDataList", Ddo_xt_logtargetoperate_Includedatalist);
            ucDdo_xt_logtargetoperate.SetProperty("SortASC", Ddo_xt_logtargetoperate_Sortasc);
            ucDdo_xt_logtargetoperate.SetProperty("SortDSC", Ddo_xt_logtargetoperate_Sortdsc);
            ucDdo_xt_logtargetoperate.SetProperty("SearchButtonText", Ddo_xt_logtargetoperate_Searchbuttontext);
            ucDdo_xt_logtargetoperate.SetProperty("DropDownOptionsTitleSettingsIcons", AV43DDO_TitleSettingsIcons);
            ucDdo_xt_logtargetoperate.SetProperty("DropDownOptionsData", AV39XT_LogTargetOperateTitleFilterData);
            ucDdo_xt_logtargetoperate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_logtargetoperate_Internalname, "DDO_XT_LOGTARGETOPERATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_logtargetoperatetitlecontrolidtoreplace_Internalname, AV40ddo_XT_LogTargetOperateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", 0, edtavDdo_xt_logtargetoperatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_LogPrompt.htm");
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
            ucDdo_xt_logdescription.SetProperty("DropDownOptionsTitleSettingsIcons", AV43DDO_TitleSettingsIcons);
            ucDdo_xt_logdescription.SetProperty("DropDownOptionsData", AV41XT_LogDescriptionTitleFilterData);
            ucDdo_xt_logdescription.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_logdescription_Internalname, "DDO_XT_LOGDESCRIPTIONContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_logdescriptiontitlecontrolidtoreplace_Internalname, AV42ddo_XT_LogDescriptionTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,65);\"", 0, edtavDdo_xt_logdescriptiontitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_LogPrompt.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,67);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_XT_LogPrompt.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV12OrderedDsc), StringUtil.BoolToStr( AV12OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,68);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_XT_LogPrompt.htm");
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

      protected void START4H2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "选择系统日志", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP4H0( ) ;
      }

      protected void WS4H2( )
      {
         START4H2( ) ;
         EVT4H2( ) ;
      }

      protected void EVT4H2( )
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
                           E114H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E124H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_XT_LOGID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E134H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_XT_LOGUSERID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E144H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_XT_LOGSECUSERNAME.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E154H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_XT_LOGTIME.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E164H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_XT_LOGPAGE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E174H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_XT_LOGBUTTONNAME.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E184H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_XT_LOGTYPE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E194H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_XT_LOGPROVIDERID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E204H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_XT_LOGPROVIDERNAME.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E214H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_XT_LOGTARGET.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E224H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_XT_LOGSONTARGET.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E234H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_XT_LOGTARGETMODULE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E244H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_XT_LOGTARGETSONMODULE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E254H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_XT_LOGTARGETOPERATE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E264H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_XT_LOGDESCRIPTION.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E274H2 ();
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
                           AV48Select = cgiGet( edtavSelect_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV48Select)) ? AV52Select_GXI : context.convertURL( context.PathToRelativeUrl( AV48Select))), !bGXsfl_12_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "SrcSet", context.GetImageSrcSet( AV48Select), true);
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
                                 E284H2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E294H2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E304H2 ();
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
                                       E314H2 ();
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

      protected void WE4H2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm4H2( ) ;
            }
         }
      }

      protected void PA4H2( )
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
               GX_FocusControl = edtavDdo_xt_logidtitlecontrolidtoreplace_Internalname;
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
                                       String AV14ddo_XT_LogIDTitleControlIdToReplace ,
                                       String AV16ddo_XT_LogUserIDTitleControlIdToReplace ,
                                       String AV18ddo_XT_LogSecUserNameTitleControlIdToReplace ,
                                       String AV20ddo_XT_LogTimeTitleControlIdToReplace ,
                                       String AV22ddo_XT_LogPageTitleControlIdToReplace ,
                                       String AV24ddo_XT_LogButtonNameTitleControlIdToReplace ,
                                       String AV26ddo_XT_LogTypeTitleControlIdToReplace ,
                                       String AV28ddo_XT_LogProviderIDTitleControlIdToReplace ,
                                       String AV30ddo_XT_LogProviderNameTitleControlIdToReplace ,
                                       String AV32ddo_XT_LogTargetTitleControlIdToReplace ,
                                       String AV34ddo_XT_LogSonTargetTitleControlIdToReplace ,
                                       String AV36ddo_XT_LogTargetModuleTitleControlIdToReplace ,
                                       String AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace ,
                                       String AV40ddo_XT_LogTargetOperateTitleControlIdToReplace ,
                                       String AV42ddo_XT_LogDescriptionTitleControlIdToReplace )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF4H2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_XT_LOGID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A173XT_LogID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "XT_LOGID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A173XT_LogID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_XT_LOGUSERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A214XT_LogUserID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "XT_LOGUSERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A214XT_LogUserID), 18, 0, ".", "")));
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
         RF4H2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV51Pgmname = "XT_LogPrompt";
         context.Gx_err = 0;
      }

      protected void RF4H2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 12;
         /* Execute user event: Refresh */
         E294H2 ();
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
            /* Using cursor H004H2 */
            pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_12_idx = 1;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A221XT_LogDescription = H004H2_A221XT_LogDescription[0];
               n221XT_LogDescription = H004H2_n221XT_LogDescription[0];
               A218XT_LogTargetOperate = H004H2_A218XT_LogTargetOperate[0];
               n218XT_LogTargetOperate = H004H2_n218XT_LogTargetOperate[0];
               A222XT_LogTargetSonModule = H004H2_A222XT_LogTargetSonModule[0];
               n222XT_LogTargetSonModule = H004H2_n222XT_LogTargetSonModule[0];
               A217XT_LogTargetModule = H004H2_A217XT_LogTargetModule[0];
               n217XT_LogTargetModule = H004H2_n217XT_LogTargetModule[0];
               A223XT_LogSonTarget = H004H2_A223XT_LogSonTarget[0];
               n223XT_LogSonTarget = H004H2_n223XT_LogSonTarget[0];
               A216XT_LogTarget = H004H2_A216XT_LogTarget[0];
               n216XT_LogTarget = H004H2_n216XT_LogTarget[0];
               A219XT_LogProviderName = H004H2_A219XT_LogProviderName[0];
               n219XT_LogProviderName = H004H2_n219XT_LogProviderName[0];
               A215XT_LogProviderID = H004H2_A215XT_LogProviderID[0];
               n215XT_LogProviderID = H004H2_n215XT_LogProviderID[0];
               A213XT_LogType = H004H2_A213XT_LogType[0];
               n213XT_LogType = H004H2_n213XT_LogType[0];
               A177XT_LogButtonName = H004H2_A177XT_LogButtonName[0];
               n177XT_LogButtonName = H004H2_n177XT_LogButtonName[0];
               A176XT_LogPage = H004H2_A176XT_LogPage[0];
               n176XT_LogPage = H004H2_n176XT_LogPage[0];
               A220XT_LogTime = H004H2_A220XT_LogTime[0];
               n220XT_LogTime = H004H2_n220XT_LogTime[0];
               A174XT_LogSecUserName = H004H2_A174XT_LogSecUserName[0];
               n174XT_LogSecUserName = H004H2_n174XT_LogSecUserName[0];
               A214XT_LogUserID = H004H2_A214XT_LogUserID[0];
               n214XT_LogUserID = H004H2_n214XT_LogUserID[0];
               A173XT_LogID = H004H2_A173XT_LogID[0];
               E304H2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 12;
            WB4H0( ) ;
         }
         bGXsfl_12_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes4H2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_XT_LOGID"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, context.localUtil.Format( (decimal)(A173XT_LogID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_XT_LOGUSERID"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, context.localUtil.Format( (decimal)(A214XT_LogUserID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         /* Using cursor H004H3 */
         pr_default.execute(1);
         GRID_nRecordCount = H004H3_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_XT_LogIDTitleControlIdToReplace, AV16ddo_XT_LogUserIDTitleControlIdToReplace, AV18ddo_XT_LogSecUserNameTitleControlIdToReplace, AV20ddo_XT_LogTimeTitleControlIdToReplace, AV22ddo_XT_LogPageTitleControlIdToReplace, AV24ddo_XT_LogButtonNameTitleControlIdToReplace, AV26ddo_XT_LogTypeTitleControlIdToReplace, AV28ddo_XT_LogProviderIDTitleControlIdToReplace, AV30ddo_XT_LogProviderNameTitleControlIdToReplace, AV32ddo_XT_LogTargetTitleControlIdToReplace, AV34ddo_XT_LogSonTargetTitleControlIdToReplace, AV36ddo_XT_LogTargetModuleTitleControlIdToReplace, AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace, AV40ddo_XT_LogTargetOperateTitleControlIdToReplace, AV42ddo_XT_LogDescriptionTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_XT_LogIDTitleControlIdToReplace, AV16ddo_XT_LogUserIDTitleControlIdToReplace, AV18ddo_XT_LogSecUserNameTitleControlIdToReplace, AV20ddo_XT_LogTimeTitleControlIdToReplace, AV22ddo_XT_LogPageTitleControlIdToReplace, AV24ddo_XT_LogButtonNameTitleControlIdToReplace, AV26ddo_XT_LogTypeTitleControlIdToReplace, AV28ddo_XT_LogProviderIDTitleControlIdToReplace, AV30ddo_XT_LogProviderNameTitleControlIdToReplace, AV32ddo_XT_LogTargetTitleControlIdToReplace, AV34ddo_XT_LogSonTargetTitleControlIdToReplace, AV36ddo_XT_LogTargetModuleTitleControlIdToReplace, AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace, AV40ddo_XT_LogTargetOperateTitleControlIdToReplace, AV42ddo_XT_LogDescriptionTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_XT_LogIDTitleControlIdToReplace, AV16ddo_XT_LogUserIDTitleControlIdToReplace, AV18ddo_XT_LogSecUserNameTitleControlIdToReplace, AV20ddo_XT_LogTimeTitleControlIdToReplace, AV22ddo_XT_LogPageTitleControlIdToReplace, AV24ddo_XT_LogButtonNameTitleControlIdToReplace, AV26ddo_XT_LogTypeTitleControlIdToReplace, AV28ddo_XT_LogProviderIDTitleControlIdToReplace, AV30ddo_XT_LogProviderNameTitleControlIdToReplace, AV32ddo_XT_LogTargetTitleControlIdToReplace, AV34ddo_XT_LogSonTargetTitleControlIdToReplace, AV36ddo_XT_LogTargetModuleTitleControlIdToReplace, AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace, AV40ddo_XT_LogTargetOperateTitleControlIdToReplace, AV42ddo_XT_LogDescriptionTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_XT_LogIDTitleControlIdToReplace, AV16ddo_XT_LogUserIDTitleControlIdToReplace, AV18ddo_XT_LogSecUserNameTitleControlIdToReplace, AV20ddo_XT_LogTimeTitleControlIdToReplace, AV22ddo_XT_LogPageTitleControlIdToReplace, AV24ddo_XT_LogButtonNameTitleControlIdToReplace, AV26ddo_XT_LogTypeTitleControlIdToReplace, AV28ddo_XT_LogProviderIDTitleControlIdToReplace, AV30ddo_XT_LogProviderNameTitleControlIdToReplace, AV32ddo_XT_LogTargetTitleControlIdToReplace, AV34ddo_XT_LogSonTargetTitleControlIdToReplace, AV36ddo_XT_LogTargetModuleTitleControlIdToReplace, AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace, AV40ddo_XT_LogTargetOperateTitleControlIdToReplace, AV42ddo_XT_LogDescriptionTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_XT_LogIDTitleControlIdToReplace, AV16ddo_XT_LogUserIDTitleControlIdToReplace, AV18ddo_XT_LogSecUserNameTitleControlIdToReplace, AV20ddo_XT_LogTimeTitleControlIdToReplace, AV22ddo_XT_LogPageTitleControlIdToReplace, AV24ddo_XT_LogButtonNameTitleControlIdToReplace, AV26ddo_XT_LogTypeTitleControlIdToReplace, AV28ddo_XT_LogProviderIDTitleControlIdToReplace, AV30ddo_XT_LogProviderNameTitleControlIdToReplace, AV32ddo_XT_LogTargetTitleControlIdToReplace, AV34ddo_XT_LogSonTargetTitleControlIdToReplace, AV36ddo_XT_LogTargetModuleTitleControlIdToReplace, AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace, AV40ddo_XT_LogTargetOperateTitleControlIdToReplace, AV42ddo_XT_LogDescriptionTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP4H0( )
      {
         /* Before Start, stand alone formulas. */
         AV51Pgmname = "XT_LogPrompt";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E284H2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV43DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_LOGIDTITLEFILTERDATA"), AV13XT_LogIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_LOGUSERIDTITLEFILTERDATA"), AV15XT_LogUserIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_LOGSECUSERNAMETITLEFILTERDATA"), AV17XT_LogSecUserNameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_LOGTIMETITLEFILTERDATA"), AV19XT_LogTimeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_LOGPAGETITLEFILTERDATA"), AV21XT_LogPageTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_LOGBUTTONNAMETITLEFILTERDATA"), AV23XT_LogButtonNameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_LOGTYPETITLEFILTERDATA"), AV25XT_LogTypeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_LOGPROVIDERIDTITLEFILTERDATA"), AV27XT_LogProviderIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_LOGPROVIDERNAMETITLEFILTERDATA"), AV29XT_LogProviderNameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_LOGTARGETTITLEFILTERDATA"), AV31XT_LogTargetTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_LOGSONTARGETTITLEFILTERDATA"), AV33XT_LogSonTargetTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_LOGTARGETMODULETITLEFILTERDATA"), AV35XT_LogTargetModuleTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_LOGTARGETSONMODULETITLEFILTERDATA"), AV37XT_LogTargetSonModuleTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_LOGTARGETOPERATETITLEFILTERDATA"), AV39XT_LogTargetOperateTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_LOGDESCRIPTIONTITLEFILTERDATA"), AV41XT_LogDescriptionTitleFilterData);
            /* Read variables values. */
            AV14ddo_XT_LogIDTitleControlIdToReplace = cgiGet( edtavDdo_xt_logidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_XT_LogIDTitleControlIdToReplace", AV14ddo_XT_LogIDTitleControlIdToReplace);
            AV16ddo_XT_LogUserIDTitleControlIdToReplace = cgiGet( edtavDdo_xt_loguseridtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_XT_LogUserIDTitleControlIdToReplace", AV16ddo_XT_LogUserIDTitleControlIdToReplace);
            AV18ddo_XT_LogSecUserNameTitleControlIdToReplace = cgiGet( edtavDdo_xt_logsecusernametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_XT_LogSecUserNameTitleControlIdToReplace", AV18ddo_XT_LogSecUserNameTitleControlIdToReplace);
            AV20ddo_XT_LogTimeTitleControlIdToReplace = cgiGet( edtavDdo_xt_logtimetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_XT_LogTimeTitleControlIdToReplace", AV20ddo_XT_LogTimeTitleControlIdToReplace);
            AV22ddo_XT_LogPageTitleControlIdToReplace = cgiGet( edtavDdo_xt_logpagetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ddo_XT_LogPageTitleControlIdToReplace", AV22ddo_XT_LogPageTitleControlIdToReplace);
            AV24ddo_XT_LogButtonNameTitleControlIdToReplace = cgiGet( edtavDdo_xt_logbuttonnametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24ddo_XT_LogButtonNameTitleControlIdToReplace", AV24ddo_XT_LogButtonNameTitleControlIdToReplace);
            AV26ddo_XT_LogTypeTitleControlIdToReplace = cgiGet( edtavDdo_xt_logtypetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26ddo_XT_LogTypeTitleControlIdToReplace", AV26ddo_XT_LogTypeTitleControlIdToReplace);
            AV28ddo_XT_LogProviderIDTitleControlIdToReplace = cgiGet( edtavDdo_xt_logprovideridtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28ddo_XT_LogProviderIDTitleControlIdToReplace", AV28ddo_XT_LogProviderIDTitleControlIdToReplace);
            AV30ddo_XT_LogProviderNameTitleControlIdToReplace = cgiGet( edtavDdo_xt_logprovidernametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30ddo_XT_LogProviderNameTitleControlIdToReplace", AV30ddo_XT_LogProviderNameTitleControlIdToReplace);
            AV32ddo_XT_LogTargetTitleControlIdToReplace = cgiGet( edtavDdo_xt_logtargettitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32ddo_XT_LogTargetTitleControlIdToReplace", AV32ddo_XT_LogTargetTitleControlIdToReplace);
            AV34ddo_XT_LogSonTargetTitleControlIdToReplace = cgiGet( edtavDdo_xt_logsontargettitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34ddo_XT_LogSonTargetTitleControlIdToReplace", AV34ddo_XT_LogSonTargetTitleControlIdToReplace);
            AV36ddo_XT_LogTargetModuleTitleControlIdToReplace = cgiGet( edtavDdo_xt_logtargetmoduletitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36ddo_XT_LogTargetModuleTitleControlIdToReplace", AV36ddo_XT_LogTargetModuleTitleControlIdToReplace);
            AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace = cgiGet( edtavDdo_xt_logtargetsonmoduletitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace", AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace);
            AV40ddo_XT_LogTargetOperateTitleControlIdToReplace = cgiGet( edtavDdo_xt_logtargetoperatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40ddo_XT_LogTargetOperateTitleControlIdToReplace", AV40ddo_XT_LogTargetOperateTitleControlIdToReplace);
            AV42ddo_XT_LogDescriptionTitleControlIdToReplace = cgiGet( edtavDdo_xt_logdescriptiontitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42ddo_XT_LogDescriptionTitleControlIdToReplace", AV42ddo_XT_LogDescriptionTitleControlIdToReplace);
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
            AV45GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV47GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV46GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_xt_logid_Caption = cgiGet( "DDO_XT_LOGID_Caption");
            Ddo_xt_logid_Tooltip = cgiGet( "DDO_XT_LOGID_Tooltip");
            Ddo_xt_logid_Cls = cgiGet( "DDO_XT_LOGID_Cls");
            Ddo_xt_logid_Dropdownoptionstype = cgiGet( "DDO_XT_LOGID_Dropdownoptionstype");
            Ddo_xt_logid_Titlecontrolidtoreplace = cgiGet( "DDO_XT_LOGID_Titlecontrolidtoreplace");
            Ddo_xt_logid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGID_Includesortasc"));
            Ddo_xt_logid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGID_Includesortdsc"));
            Ddo_xt_logid_Sortedstatus = cgiGet( "DDO_XT_LOGID_Sortedstatus");
            Ddo_xt_logid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGID_Includefilter"));
            Ddo_xt_logid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGID_Includedatalist"));
            Ddo_xt_logid_Sortasc = cgiGet( "DDO_XT_LOGID_Sortasc");
            Ddo_xt_logid_Sortdsc = cgiGet( "DDO_XT_LOGID_Sortdsc");
            Ddo_xt_logid_Searchbuttontext = cgiGet( "DDO_XT_LOGID_Searchbuttontext");
            Ddo_xt_loguserid_Caption = cgiGet( "DDO_XT_LOGUSERID_Caption");
            Ddo_xt_loguserid_Tooltip = cgiGet( "DDO_XT_LOGUSERID_Tooltip");
            Ddo_xt_loguserid_Cls = cgiGet( "DDO_XT_LOGUSERID_Cls");
            Ddo_xt_loguserid_Dropdownoptionstype = cgiGet( "DDO_XT_LOGUSERID_Dropdownoptionstype");
            Ddo_xt_loguserid_Titlecontrolidtoreplace = cgiGet( "DDO_XT_LOGUSERID_Titlecontrolidtoreplace");
            Ddo_xt_loguserid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGUSERID_Includesortasc"));
            Ddo_xt_loguserid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGUSERID_Includesortdsc"));
            Ddo_xt_loguserid_Sortedstatus = cgiGet( "DDO_XT_LOGUSERID_Sortedstatus");
            Ddo_xt_loguserid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGUSERID_Includefilter"));
            Ddo_xt_loguserid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGUSERID_Includedatalist"));
            Ddo_xt_loguserid_Sortasc = cgiGet( "DDO_XT_LOGUSERID_Sortasc");
            Ddo_xt_loguserid_Sortdsc = cgiGet( "DDO_XT_LOGUSERID_Sortdsc");
            Ddo_xt_loguserid_Searchbuttontext = cgiGet( "DDO_XT_LOGUSERID_Searchbuttontext");
            Ddo_xt_logsecusername_Caption = cgiGet( "DDO_XT_LOGSECUSERNAME_Caption");
            Ddo_xt_logsecusername_Tooltip = cgiGet( "DDO_XT_LOGSECUSERNAME_Tooltip");
            Ddo_xt_logsecusername_Cls = cgiGet( "DDO_XT_LOGSECUSERNAME_Cls");
            Ddo_xt_logsecusername_Dropdownoptionstype = cgiGet( "DDO_XT_LOGSECUSERNAME_Dropdownoptionstype");
            Ddo_xt_logsecusername_Titlecontrolidtoreplace = cgiGet( "DDO_XT_LOGSECUSERNAME_Titlecontrolidtoreplace");
            Ddo_xt_logsecusername_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGSECUSERNAME_Includesortasc"));
            Ddo_xt_logsecusername_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGSECUSERNAME_Includesortdsc"));
            Ddo_xt_logsecusername_Sortedstatus = cgiGet( "DDO_XT_LOGSECUSERNAME_Sortedstatus");
            Ddo_xt_logsecusername_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGSECUSERNAME_Includefilter"));
            Ddo_xt_logsecusername_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGSECUSERNAME_Includedatalist"));
            Ddo_xt_logsecusername_Sortasc = cgiGet( "DDO_XT_LOGSECUSERNAME_Sortasc");
            Ddo_xt_logsecusername_Sortdsc = cgiGet( "DDO_XT_LOGSECUSERNAME_Sortdsc");
            Ddo_xt_logsecusername_Searchbuttontext = cgiGet( "DDO_XT_LOGSECUSERNAME_Searchbuttontext");
            Ddo_xt_logtime_Caption = cgiGet( "DDO_XT_LOGTIME_Caption");
            Ddo_xt_logtime_Tooltip = cgiGet( "DDO_XT_LOGTIME_Tooltip");
            Ddo_xt_logtime_Cls = cgiGet( "DDO_XT_LOGTIME_Cls");
            Ddo_xt_logtime_Dropdownoptionstype = cgiGet( "DDO_XT_LOGTIME_Dropdownoptionstype");
            Ddo_xt_logtime_Titlecontrolidtoreplace = cgiGet( "DDO_XT_LOGTIME_Titlecontrolidtoreplace");
            Ddo_xt_logtime_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGTIME_Includesortasc"));
            Ddo_xt_logtime_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGTIME_Includesortdsc"));
            Ddo_xt_logtime_Sortedstatus = cgiGet( "DDO_XT_LOGTIME_Sortedstatus");
            Ddo_xt_logtime_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGTIME_Includefilter"));
            Ddo_xt_logtime_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGTIME_Includedatalist"));
            Ddo_xt_logtime_Sortasc = cgiGet( "DDO_XT_LOGTIME_Sortasc");
            Ddo_xt_logtime_Sortdsc = cgiGet( "DDO_XT_LOGTIME_Sortdsc");
            Ddo_xt_logtime_Searchbuttontext = cgiGet( "DDO_XT_LOGTIME_Searchbuttontext");
            Ddo_xt_logpage_Caption = cgiGet( "DDO_XT_LOGPAGE_Caption");
            Ddo_xt_logpage_Tooltip = cgiGet( "DDO_XT_LOGPAGE_Tooltip");
            Ddo_xt_logpage_Cls = cgiGet( "DDO_XT_LOGPAGE_Cls");
            Ddo_xt_logpage_Dropdownoptionstype = cgiGet( "DDO_XT_LOGPAGE_Dropdownoptionstype");
            Ddo_xt_logpage_Titlecontrolidtoreplace = cgiGet( "DDO_XT_LOGPAGE_Titlecontrolidtoreplace");
            Ddo_xt_logpage_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGPAGE_Includesortasc"));
            Ddo_xt_logpage_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGPAGE_Includesortdsc"));
            Ddo_xt_logpage_Sortedstatus = cgiGet( "DDO_XT_LOGPAGE_Sortedstatus");
            Ddo_xt_logpage_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGPAGE_Includefilter"));
            Ddo_xt_logpage_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGPAGE_Includedatalist"));
            Ddo_xt_logpage_Sortasc = cgiGet( "DDO_XT_LOGPAGE_Sortasc");
            Ddo_xt_logpage_Sortdsc = cgiGet( "DDO_XT_LOGPAGE_Sortdsc");
            Ddo_xt_logpage_Searchbuttontext = cgiGet( "DDO_XT_LOGPAGE_Searchbuttontext");
            Ddo_xt_logbuttonname_Caption = cgiGet( "DDO_XT_LOGBUTTONNAME_Caption");
            Ddo_xt_logbuttonname_Tooltip = cgiGet( "DDO_XT_LOGBUTTONNAME_Tooltip");
            Ddo_xt_logbuttonname_Cls = cgiGet( "DDO_XT_LOGBUTTONNAME_Cls");
            Ddo_xt_logbuttonname_Dropdownoptionstype = cgiGet( "DDO_XT_LOGBUTTONNAME_Dropdownoptionstype");
            Ddo_xt_logbuttonname_Titlecontrolidtoreplace = cgiGet( "DDO_XT_LOGBUTTONNAME_Titlecontrolidtoreplace");
            Ddo_xt_logbuttonname_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGBUTTONNAME_Includesortasc"));
            Ddo_xt_logbuttonname_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGBUTTONNAME_Includesortdsc"));
            Ddo_xt_logbuttonname_Sortedstatus = cgiGet( "DDO_XT_LOGBUTTONNAME_Sortedstatus");
            Ddo_xt_logbuttonname_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGBUTTONNAME_Includefilter"));
            Ddo_xt_logbuttonname_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGBUTTONNAME_Includedatalist"));
            Ddo_xt_logbuttonname_Sortasc = cgiGet( "DDO_XT_LOGBUTTONNAME_Sortasc");
            Ddo_xt_logbuttonname_Sortdsc = cgiGet( "DDO_XT_LOGBUTTONNAME_Sortdsc");
            Ddo_xt_logbuttonname_Searchbuttontext = cgiGet( "DDO_XT_LOGBUTTONNAME_Searchbuttontext");
            Ddo_xt_logtype_Caption = cgiGet( "DDO_XT_LOGTYPE_Caption");
            Ddo_xt_logtype_Tooltip = cgiGet( "DDO_XT_LOGTYPE_Tooltip");
            Ddo_xt_logtype_Cls = cgiGet( "DDO_XT_LOGTYPE_Cls");
            Ddo_xt_logtype_Dropdownoptionstype = cgiGet( "DDO_XT_LOGTYPE_Dropdownoptionstype");
            Ddo_xt_logtype_Titlecontrolidtoreplace = cgiGet( "DDO_XT_LOGTYPE_Titlecontrolidtoreplace");
            Ddo_xt_logtype_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGTYPE_Includesortasc"));
            Ddo_xt_logtype_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGTYPE_Includesortdsc"));
            Ddo_xt_logtype_Sortedstatus = cgiGet( "DDO_XT_LOGTYPE_Sortedstatus");
            Ddo_xt_logtype_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGTYPE_Includefilter"));
            Ddo_xt_logtype_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGTYPE_Includedatalist"));
            Ddo_xt_logtype_Sortasc = cgiGet( "DDO_XT_LOGTYPE_Sortasc");
            Ddo_xt_logtype_Sortdsc = cgiGet( "DDO_XT_LOGTYPE_Sortdsc");
            Ddo_xt_logtype_Searchbuttontext = cgiGet( "DDO_XT_LOGTYPE_Searchbuttontext");
            Ddo_xt_logproviderid_Caption = cgiGet( "DDO_XT_LOGPROVIDERID_Caption");
            Ddo_xt_logproviderid_Tooltip = cgiGet( "DDO_XT_LOGPROVIDERID_Tooltip");
            Ddo_xt_logproviderid_Cls = cgiGet( "DDO_XT_LOGPROVIDERID_Cls");
            Ddo_xt_logproviderid_Dropdownoptionstype = cgiGet( "DDO_XT_LOGPROVIDERID_Dropdownoptionstype");
            Ddo_xt_logproviderid_Titlecontrolidtoreplace = cgiGet( "DDO_XT_LOGPROVIDERID_Titlecontrolidtoreplace");
            Ddo_xt_logproviderid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGPROVIDERID_Includesortasc"));
            Ddo_xt_logproviderid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGPROVIDERID_Includesortdsc"));
            Ddo_xt_logproviderid_Sortedstatus = cgiGet( "DDO_XT_LOGPROVIDERID_Sortedstatus");
            Ddo_xt_logproviderid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGPROVIDERID_Includefilter"));
            Ddo_xt_logproviderid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGPROVIDERID_Includedatalist"));
            Ddo_xt_logproviderid_Sortasc = cgiGet( "DDO_XT_LOGPROVIDERID_Sortasc");
            Ddo_xt_logproviderid_Sortdsc = cgiGet( "DDO_XT_LOGPROVIDERID_Sortdsc");
            Ddo_xt_logproviderid_Searchbuttontext = cgiGet( "DDO_XT_LOGPROVIDERID_Searchbuttontext");
            Ddo_xt_logprovidername_Caption = cgiGet( "DDO_XT_LOGPROVIDERNAME_Caption");
            Ddo_xt_logprovidername_Tooltip = cgiGet( "DDO_XT_LOGPROVIDERNAME_Tooltip");
            Ddo_xt_logprovidername_Cls = cgiGet( "DDO_XT_LOGPROVIDERNAME_Cls");
            Ddo_xt_logprovidername_Dropdownoptionstype = cgiGet( "DDO_XT_LOGPROVIDERNAME_Dropdownoptionstype");
            Ddo_xt_logprovidername_Titlecontrolidtoreplace = cgiGet( "DDO_XT_LOGPROVIDERNAME_Titlecontrolidtoreplace");
            Ddo_xt_logprovidername_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGPROVIDERNAME_Includesortasc"));
            Ddo_xt_logprovidername_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGPROVIDERNAME_Includesortdsc"));
            Ddo_xt_logprovidername_Sortedstatus = cgiGet( "DDO_XT_LOGPROVIDERNAME_Sortedstatus");
            Ddo_xt_logprovidername_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGPROVIDERNAME_Includefilter"));
            Ddo_xt_logprovidername_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGPROVIDERNAME_Includedatalist"));
            Ddo_xt_logprovidername_Sortasc = cgiGet( "DDO_XT_LOGPROVIDERNAME_Sortasc");
            Ddo_xt_logprovidername_Sortdsc = cgiGet( "DDO_XT_LOGPROVIDERNAME_Sortdsc");
            Ddo_xt_logprovidername_Searchbuttontext = cgiGet( "DDO_XT_LOGPROVIDERNAME_Searchbuttontext");
            Ddo_xt_logtarget_Caption = cgiGet( "DDO_XT_LOGTARGET_Caption");
            Ddo_xt_logtarget_Tooltip = cgiGet( "DDO_XT_LOGTARGET_Tooltip");
            Ddo_xt_logtarget_Cls = cgiGet( "DDO_XT_LOGTARGET_Cls");
            Ddo_xt_logtarget_Dropdownoptionstype = cgiGet( "DDO_XT_LOGTARGET_Dropdownoptionstype");
            Ddo_xt_logtarget_Titlecontrolidtoreplace = cgiGet( "DDO_XT_LOGTARGET_Titlecontrolidtoreplace");
            Ddo_xt_logtarget_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGTARGET_Includesortasc"));
            Ddo_xt_logtarget_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGTARGET_Includesortdsc"));
            Ddo_xt_logtarget_Sortedstatus = cgiGet( "DDO_XT_LOGTARGET_Sortedstatus");
            Ddo_xt_logtarget_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGTARGET_Includefilter"));
            Ddo_xt_logtarget_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGTARGET_Includedatalist"));
            Ddo_xt_logtarget_Sortasc = cgiGet( "DDO_XT_LOGTARGET_Sortasc");
            Ddo_xt_logtarget_Sortdsc = cgiGet( "DDO_XT_LOGTARGET_Sortdsc");
            Ddo_xt_logtarget_Searchbuttontext = cgiGet( "DDO_XT_LOGTARGET_Searchbuttontext");
            Ddo_xt_logsontarget_Caption = cgiGet( "DDO_XT_LOGSONTARGET_Caption");
            Ddo_xt_logsontarget_Tooltip = cgiGet( "DDO_XT_LOGSONTARGET_Tooltip");
            Ddo_xt_logsontarget_Cls = cgiGet( "DDO_XT_LOGSONTARGET_Cls");
            Ddo_xt_logsontarget_Dropdownoptionstype = cgiGet( "DDO_XT_LOGSONTARGET_Dropdownoptionstype");
            Ddo_xt_logsontarget_Titlecontrolidtoreplace = cgiGet( "DDO_XT_LOGSONTARGET_Titlecontrolidtoreplace");
            Ddo_xt_logsontarget_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGSONTARGET_Includesortasc"));
            Ddo_xt_logsontarget_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGSONTARGET_Includesortdsc"));
            Ddo_xt_logsontarget_Sortedstatus = cgiGet( "DDO_XT_LOGSONTARGET_Sortedstatus");
            Ddo_xt_logsontarget_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGSONTARGET_Includefilter"));
            Ddo_xt_logsontarget_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGSONTARGET_Includedatalist"));
            Ddo_xt_logsontarget_Sortasc = cgiGet( "DDO_XT_LOGSONTARGET_Sortasc");
            Ddo_xt_logsontarget_Sortdsc = cgiGet( "DDO_XT_LOGSONTARGET_Sortdsc");
            Ddo_xt_logsontarget_Searchbuttontext = cgiGet( "DDO_XT_LOGSONTARGET_Searchbuttontext");
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
            Ddo_xt_logtargetsonmodule_Caption = cgiGet( "DDO_XT_LOGTARGETSONMODULE_Caption");
            Ddo_xt_logtargetsonmodule_Tooltip = cgiGet( "DDO_XT_LOGTARGETSONMODULE_Tooltip");
            Ddo_xt_logtargetsonmodule_Cls = cgiGet( "DDO_XT_LOGTARGETSONMODULE_Cls");
            Ddo_xt_logtargetsonmodule_Dropdownoptionstype = cgiGet( "DDO_XT_LOGTARGETSONMODULE_Dropdownoptionstype");
            Ddo_xt_logtargetsonmodule_Titlecontrolidtoreplace = cgiGet( "DDO_XT_LOGTARGETSONMODULE_Titlecontrolidtoreplace");
            Ddo_xt_logtargetsonmodule_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGTARGETSONMODULE_Includesortasc"));
            Ddo_xt_logtargetsonmodule_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGTARGETSONMODULE_Includesortdsc"));
            Ddo_xt_logtargetsonmodule_Sortedstatus = cgiGet( "DDO_XT_LOGTARGETSONMODULE_Sortedstatus");
            Ddo_xt_logtargetsonmodule_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGTARGETSONMODULE_Includefilter"));
            Ddo_xt_logtargetsonmodule_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGTARGETSONMODULE_Includedatalist"));
            Ddo_xt_logtargetsonmodule_Sortasc = cgiGet( "DDO_XT_LOGTARGETSONMODULE_Sortasc");
            Ddo_xt_logtargetsonmodule_Sortdsc = cgiGet( "DDO_XT_LOGTARGETSONMODULE_Sortdsc");
            Ddo_xt_logtargetsonmodule_Searchbuttontext = cgiGet( "DDO_XT_LOGTARGETSONMODULE_Searchbuttontext");
            Ddo_xt_logtargetoperate_Caption = cgiGet( "DDO_XT_LOGTARGETOPERATE_Caption");
            Ddo_xt_logtargetoperate_Tooltip = cgiGet( "DDO_XT_LOGTARGETOPERATE_Tooltip");
            Ddo_xt_logtargetoperate_Cls = cgiGet( "DDO_XT_LOGTARGETOPERATE_Cls");
            Ddo_xt_logtargetoperate_Dropdownoptionstype = cgiGet( "DDO_XT_LOGTARGETOPERATE_Dropdownoptionstype");
            Ddo_xt_logtargetoperate_Titlecontrolidtoreplace = cgiGet( "DDO_XT_LOGTARGETOPERATE_Titlecontrolidtoreplace");
            Ddo_xt_logtargetoperate_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGTARGETOPERATE_Includesortasc"));
            Ddo_xt_logtargetoperate_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGTARGETOPERATE_Includesortdsc"));
            Ddo_xt_logtargetoperate_Sortedstatus = cgiGet( "DDO_XT_LOGTARGETOPERATE_Sortedstatus");
            Ddo_xt_logtargetoperate_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGTARGETOPERATE_Includefilter"));
            Ddo_xt_logtargetoperate_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_XT_LOGTARGETOPERATE_Includedatalist"));
            Ddo_xt_logtargetoperate_Sortasc = cgiGet( "DDO_XT_LOGTARGETOPERATE_Sortasc");
            Ddo_xt_logtargetoperate_Sortdsc = cgiGet( "DDO_XT_LOGTARGETOPERATE_Sortdsc");
            Ddo_xt_logtargetoperate_Searchbuttontext = cgiGet( "DDO_XT_LOGTARGETOPERATE_Searchbuttontext");
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
            Ddo_xt_logid_Activeeventkey = cgiGet( "DDO_XT_LOGID_Activeeventkey");
            Ddo_xt_loguserid_Activeeventkey = cgiGet( "DDO_XT_LOGUSERID_Activeeventkey");
            Ddo_xt_logsecusername_Activeeventkey = cgiGet( "DDO_XT_LOGSECUSERNAME_Activeeventkey");
            Ddo_xt_logtime_Activeeventkey = cgiGet( "DDO_XT_LOGTIME_Activeeventkey");
            Ddo_xt_logpage_Activeeventkey = cgiGet( "DDO_XT_LOGPAGE_Activeeventkey");
            Ddo_xt_logbuttonname_Activeeventkey = cgiGet( "DDO_XT_LOGBUTTONNAME_Activeeventkey");
            Ddo_xt_logtype_Activeeventkey = cgiGet( "DDO_XT_LOGTYPE_Activeeventkey");
            Ddo_xt_logproviderid_Activeeventkey = cgiGet( "DDO_XT_LOGPROVIDERID_Activeeventkey");
            Ddo_xt_logprovidername_Activeeventkey = cgiGet( "DDO_XT_LOGPROVIDERNAME_Activeeventkey");
            Ddo_xt_logtarget_Activeeventkey = cgiGet( "DDO_XT_LOGTARGET_Activeeventkey");
            Ddo_xt_logsontarget_Activeeventkey = cgiGet( "DDO_XT_LOGSONTARGET_Activeeventkey");
            Ddo_xt_logtargetmodule_Activeeventkey = cgiGet( "DDO_XT_LOGTARGETMODULE_Activeeventkey");
            Ddo_xt_logtargetsonmodule_Activeeventkey = cgiGet( "DDO_XT_LOGTARGETSONMODULE_Activeeventkey");
            Ddo_xt_logtargetoperate_Activeeventkey = cgiGet( "DDO_XT_LOGTARGETOPERATE_Activeeventkey");
            Ddo_xt_logdescription_Activeeventkey = cgiGet( "DDO_XT_LOGDESCRIPTION_Activeeventkey");
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
         E284H2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E284H2( )
      {
         /* Start Routine */
         GXt_boolean1 = AV5IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWXT_Log", out  GXt_boolean1) ;
         AV5IsAuthorized = GXt_boolean1;
         if ( ! AV5IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV51Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         divTablemain_Height = 493;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTablemain_Internalname, "Height", StringUtil.LTrim( StringUtil.Str( (decimal)(divTablemain_Height), 9, 0)), true);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_xt_logid_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_LogID";
         ucDdo_xt_logid.SendProperty(context, "", false, Ddo_xt_logid_Internalname, "TitleControlIdToReplace", Ddo_xt_logid_Titlecontrolidtoreplace);
         AV14ddo_XT_LogIDTitleControlIdToReplace = Ddo_xt_logid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_XT_LogIDTitleControlIdToReplace", AV14ddo_XT_LogIDTitleControlIdToReplace);
         edtavDdo_xt_logidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_logidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_logidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_xt_loguserid_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_LogUserID";
         ucDdo_xt_loguserid.SendProperty(context, "", false, Ddo_xt_loguserid_Internalname, "TitleControlIdToReplace", Ddo_xt_loguserid_Titlecontrolidtoreplace);
         AV16ddo_XT_LogUserIDTitleControlIdToReplace = Ddo_xt_loguserid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_XT_LogUserIDTitleControlIdToReplace", AV16ddo_XT_LogUserIDTitleControlIdToReplace);
         edtavDdo_xt_loguseridtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_loguseridtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_loguseridtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_xt_logsecusername_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_LogSecUserName";
         ucDdo_xt_logsecusername.SendProperty(context, "", false, Ddo_xt_logsecusername_Internalname, "TitleControlIdToReplace", Ddo_xt_logsecusername_Titlecontrolidtoreplace);
         AV18ddo_XT_LogSecUserNameTitleControlIdToReplace = Ddo_xt_logsecusername_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_XT_LogSecUserNameTitleControlIdToReplace", AV18ddo_XT_LogSecUserNameTitleControlIdToReplace);
         edtavDdo_xt_logsecusernametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_logsecusernametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_logsecusernametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_xt_logtime_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_LogTime";
         ucDdo_xt_logtime.SendProperty(context, "", false, Ddo_xt_logtime_Internalname, "TitleControlIdToReplace", Ddo_xt_logtime_Titlecontrolidtoreplace);
         AV20ddo_XT_LogTimeTitleControlIdToReplace = Ddo_xt_logtime_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_XT_LogTimeTitleControlIdToReplace", AV20ddo_XT_LogTimeTitleControlIdToReplace);
         edtavDdo_xt_logtimetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_logtimetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_logtimetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_xt_logpage_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_LogPage";
         ucDdo_xt_logpage.SendProperty(context, "", false, Ddo_xt_logpage_Internalname, "TitleControlIdToReplace", Ddo_xt_logpage_Titlecontrolidtoreplace);
         AV22ddo_XT_LogPageTitleControlIdToReplace = Ddo_xt_logpage_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ddo_XT_LogPageTitleControlIdToReplace", AV22ddo_XT_LogPageTitleControlIdToReplace);
         edtavDdo_xt_logpagetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_logpagetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_logpagetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_xt_logbuttonname_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_LogButtonName";
         ucDdo_xt_logbuttonname.SendProperty(context, "", false, Ddo_xt_logbuttonname_Internalname, "TitleControlIdToReplace", Ddo_xt_logbuttonname_Titlecontrolidtoreplace);
         AV24ddo_XT_LogButtonNameTitleControlIdToReplace = Ddo_xt_logbuttonname_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24ddo_XT_LogButtonNameTitleControlIdToReplace", AV24ddo_XT_LogButtonNameTitleControlIdToReplace);
         edtavDdo_xt_logbuttonnametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_logbuttonnametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_logbuttonnametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_xt_logtype_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_LogType";
         ucDdo_xt_logtype.SendProperty(context, "", false, Ddo_xt_logtype_Internalname, "TitleControlIdToReplace", Ddo_xt_logtype_Titlecontrolidtoreplace);
         AV26ddo_XT_LogTypeTitleControlIdToReplace = Ddo_xt_logtype_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26ddo_XT_LogTypeTitleControlIdToReplace", AV26ddo_XT_LogTypeTitleControlIdToReplace);
         edtavDdo_xt_logtypetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_logtypetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_logtypetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_xt_logproviderid_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_LogProviderID";
         ucDdo_xt_logproviderid.SendProperty(context, "", false, Ddo_xt_logproviderid_Internalname, "TitleControlIdToReplace", Ddo_xt_logproviderid_Titlecontrolidtoreplace);
         AV28ddo_XT_LogProviderIDTitleControlIdToReplace = Ddo_xt_logproviderid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28ddo_XT_LogProviderIDTitleControlIdToReplace", AV28ddo_XT_LogProviderIDTitleControlIdToReplace);
         edtavDdo_xt_logprovideridtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_logprovideridtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_logprovideridtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_xt_logprovidername_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_LogProviderName";
         ucDdo_xt_logprovidername.SendProperty(context, "", false, Ddo_xt_logprovidername_Internalname, "TitleControlIdToReplace", Ddo_xt_logprovidername_Titlecontrolidtoreplace);
         AV30ddo_XT_LogProviderNameTitleControlIdToReplace = Ddo_xt_logprovidername_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30ddo_XT_LogProviderNameTitleControlIdToReplace", AV30ddo_XT_LogProviderNameTitleControlIdToReplace);
         edtavDdo_xt_logprovidernametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_logprovidernametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_logprovidernametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_xt_logtarget_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_LogTarget";
         ucDdo_xt_logtarget.SendProperty(context, "", false, Ddo_xt_logtarget_Internalname, "TitleControlIdToReplace", Ddo_xt_logtarget_Titlecontrolidtoreplace);
         AV32ddo_XT_LogTargetTitleControlIdToReplace = Ddo_xt_logtarget_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32ddo_XT_LogTargetTitleControlIdToReplace", AV32ddo_XT_LogTargetTitleControlIdToReplace);
         edtavDdo_xt_logtargettitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_logtargettitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_logtargettitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_xt_logsontarget_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_LogSonTarget";
         ucDdo_xt_logsontarget.SendProperty(context, "", false, Ddo_xt_logsontarget_Internalname, "TitleControlIdToReplace", Ddo_xt_logsontarget_Titlecontrolidtoreplace);
         AV34ddo_XT_LogSonTargetTitleControlIdToReplace = Ddo_xt_logsontarget_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34ddo_XT_LogSonTargetTitleControlIdToReplace", AV34ddo_XT_LogSonTargetTitleControlIdToReplace);
         edtavDdo_xt_logsontargettitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_logsontargettitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_logsontargettitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_xt_logtargetmodule_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_LogTargetModule";
         ucDdo_xt_logtargetmodule.SendProperty(context, "", false, Ddo_xt_logtargetmodule_Internalname, "TitleControlIdToReplace", Ddo_xt_logtargetmodule_Titlecontrolidtoreplace);
         AV36ddo_XT_LogTargetModuleTitleControlIdToReplace = Ddo_xt_logtargetmodule_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36ddo_XT_LogTargetModuleTitleControlIdToReplace", AV36ddo_XT_LogTargetModuleTitleControlIdToReplace);
         edtavDdo_xt_logtargetmoduletitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_logtargetmoduletitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_logtargetmoduletitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_xt_logtargetsonmodule_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_LogTargetSonModule";
         ucDdo_xt_logtargetsonmodule.SendProperty(context, "", false, Ddo_xt_logtargetsonmodule_Internalname, "TitleControlIdToReplace", Ddo_xt_logtargetsonmodule_Titlecontrolidtoreplace);
         AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace = Ddo_xt_logtargetsonmodule_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace", AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace);
         edtavDdo_xt_logtargetsonmoduletitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_logtargetsonmoduletitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_logtargetsonmoduletitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_xt_logtargetoperate_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_LogTargetOperate";
         ucDdo_xt_logtargetoperate.SendProperty(context, "", false, Ddo_xt_logtargetoperate_Internalname, "TitleControlIdToReplace", Ddo_xt_logtargetoperate_Titlecontrolidtoreplace);
         AV40ddo_XT_LogTargetOperateTitleControlIdToReplace = Ddo_xt_logtargetoperate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40ddo_XT_LogTargetOperateTitleControlIdToReplace", AV40ddo_XT_LogTargetOperateTitleControlIdToReplace);
         edtavDdo_xt_logtargetoperatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_logtargetoperatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_logtargetoperatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_xt_logdescription_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_LogDescription";
         ucDdo_xt_logdescription.SendProperty(context, "", false, Ddo_xt_logdescription_Internalname, "TitleControlIdToReplace", Ddo_xt_logdescription_Titlecontrolidtoreplace);
         AV42ddo_XT_LogDescriptionTitleControlIdToReplace = Ddo_xt_logdescription_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42ddo_XT_LogDescriptionTitleControlIdToReplace", AV42ddo_XT_LogDescriptionTitleControlIdToReplace);
         edtavDdo_xt_logdescriptiontitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_logdescriptiontitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_logdescriptiontitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "选择系统日志";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV43DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV43DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E294H2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV13XT_LogIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15XT_LogUserIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17XT_LogSecUserNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19XT_LogTimeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21XT_LogPageTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV23XT_LogButtonNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV25XT_LogTypeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV27XT_LogProviderIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV29XT_LogProviderNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV31XT_LogTargetTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV33XT_LogSonTargetTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV35XT_LogTargetModuleTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV37XT_LogTargetSonModuleTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV39XT_LogTargetOperateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV41XT_LogDescriptionTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         edtXT_LogID_Titleformat = 2;
         edtXT_LogID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "系统日志主键", AV14ddo_XT_LogIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogID_Internalname, "Title", edtXT_LogID_Title, !bGXsfl_12_Refreshing);
         edtXT_LogUserID_Titleformat = 2;
         edtXT_LogUserID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "ID", AV16ddo_XT_LogUserIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogUserID_Internalname, "Title", edtXT_LogUserID_Title, !bGXsfl_12_Refreshing);
         edtXT_LogSecUserName_Titleformat = 2;
         edtXT_LogSecUserName_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "操作人", AV18ddo_XT_LogSecUserNameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogSecUserName_Internalname, "Title", edtXT_LogSecUserName_Title, !bGXsfl_12_Refreshing);
         edtXT_LogTime_Titleformat = 2;
         edtXT_LogTime_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "操作时间", AV20ddo_XT_LogTimeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogTime_Internalname, "Title", edtXT_LogTime_Title, !bGXsfl_12_Refreshing);
         cmbXT_LogPage_Titleformat = 2;
         cmbXT_LogPage.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "操作页面", AV22ddo_XT_LogPageTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbXT_LogPage_Internalname, "Title", cmbXT_LogPage.Title.Text, !bGXsfl_12_Refreshing);
         edtXT_LogButtonName_Titleformat = 2;
         edtXT_LogButtonName_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "操作的按钮", AV24ddo_XT_LogButtonNameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogButtonName_Internalname, "Title", edtXT_LogButtonName_Title, !bGXsfl_12_Refreshing);
         edtXT_LogType_Titleformat = 2;
         edtXT_LogType_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "日志类型", AV26ddo_XT_LogTypeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogType_Internalname, "Title", edtXT_LogType_Title, !bGXsfl_12_Refreshing);
         edtXT_LogProviderID_Titleformat = 2;
         edtXT_LogProviderID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "ID", AV28ddo_XT_LogProviderIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogProviderID_Internalname, "Title", edtXT_LogProviderID_Title, !bGXsfl_12_Refreshing);
         edtXT_LogProviderName_Titleformat = 2;
         edtXT_LogProviderName_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "日志分院名称", AV30ddo_XT_LogProviderNameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogProviderName_Internalname, "Title", edtXT_LogProviderName_Title, !bGXsfl_12_Refreshing);
         edtXT_LogTarget_Titleformat = 2;
         edtXT_LogTarget_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "日志操作对象", AV32ddo_XT_LogTargetTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogTarget_Internalname, "Title", edtXT_LogTarget_Title, !bGXsfl_12_Refreshing);
         edtXT_LogSonTarget_Titleformat = 2;
         edtXT_LogSonTarget_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "日志操作子对象", AV34ddo_XT_LogSonTargetTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogSonTarget_Internalname, "Title", edtXT_LogSonTarget_Title, !bGXsfl_12_Refreshing);
         edtXT_LogTargetModule_Titleformat = 2;
         edtXT_LogTargetModule_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "日志操作模块", AV36ddo_XT_LogTargetModuleTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogTargetModule_Internalname, "Title", edtXT_LogTargetModule_Title, !bGXsfl_12_Refreshing);
         edtXT_LogTargetSonModule_Titleformat = 2;
         edtXT_LogTargetSonModule_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "日志操作模块子模块", AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogTargetSonModule_Internalname, "Title", edtXT_LogTargetSonModule_Title, !bGXsfl_12_Refreshing);
         cmbXT_LogTargetOperate_Titleformat = 2;
         cmbXT_LogTargetOperate.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "日志操作对象动作", AV40ddo_XT_LogTargetOperateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbXT_LogTargetOperate_Internalname, "Title", cmbXT_LogTargetOperate.Title.Text, !bGXsfl_12_Refreshing);
         edtXT_LogDescription_Titleformat = 2;
         edtXT_LogDescription_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "日志描述", AV42ddo_XT_LogDescriptionTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogDescription_Internalname, "Title", edtXT_LogDescription_Title, !bGXsfl_12_Refreshing);
         AV45GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV45GridCurrentPage), 10, 0)));
         AV46GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV46GridPageSize), 10, 0)));
         AV47GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV47GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13XT_LogIDTitleFilterData", AV13XT_LogIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15XT_LogUserIDTitleFilterData", AV15XT_LogUserIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17XT_LogSecUserNameTitleFilterData", AV17XT_LogSecUserNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_LogTimeTitleFilterData", AV19XT_LogTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21XT_LogPageTitleFilterData", AV21XT_LogPageTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23XT_LogButtonNameTitleFilterData", AV23XT_LogButtonNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25XT_LogTypeTitleFilterData", AV25XT_LogTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27XT_LogProviderIDTitleFilterData", AV27XT_LogProviderIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29XT_LogProviderNameTitleFilterData", AV29XT_LogProviderNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31XT_LogTargetTitleFilterData", AV31XT_LogTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33XT_LogSonTargetTitleFilterData", AV33XT_LogSonTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35XT_LogTargetModuleTitleFilterData", AV35XT_LogTargetModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37XT_LogTargetSonModuleTitleFilterData", AV37XT_LogTargetSonModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39XT_LogTargetOperateTitleFilterData", AV39XT_LogTargetOperateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41XT_LogDescriptionTitleFilterData", AV41XT_LogDescriptionTitleFilterData);
      }

      protected void E114H2( )
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
            AV44PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV44PageToGo) ;
         }
      }

      protected void E124H2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E134H2( )
      {
         /* Ddo_xt_logid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_logid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_logid_Sortedstatus = "ASC";
            ucDdo_xt_logid.SendProperty(context, "", false, Ddo_xt_logid_Internalname, "SortedStatus", Ddo_xt_logid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_logid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_logid_Sortedstatus = "DSC";
            ucDdo_xt_logid.SendProperty(context, "", false, Ddo_xt_logid_Internalname, "SortedStatus", Ddo_xt_logid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13XT_LogIDTitleFilterData", AV13XT_LogIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15XT_LogUserIDTitleFilterData", AV15XT_LogUserIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17XT_LogSecUserNameTitleFilterData", AV17XT_LogSecUserNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_LogTimeTitleFilterData", AV19XT_LogTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21XT_LogPageTitleFilterData", AV21XT_LogPageTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23XT_LogButtonNameTitleFilterData", AV23XT_LogButtonNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25XT_LogTypeTitleFilterData", AV25XT_LogTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27XT_LogProviderIDTitleFilterData", AV27XT_LogProviderIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29XT_LogProviderNameTitleFilterData", AV29XT_LogProviderNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31XT_LogTargetTitleFilterData", AV31XT_LogTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33XT_LogSonTargetTitleFilterData", AV33XT_LogSonTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35XT_LogTargetModuleTitleFilterData", AV35XT_LogTargetModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37XT_LogTargetSonModuleTitleFilterData", AV37XT_LogTargetSonModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39XT_LogTargetOperateTitleFilterData", AV39XT_LogTargetOperateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41XT_LogDescriptionTitleFilterData", AV41XT_LogDescriptionTitleFilterData);
      }

      protected void E144H2( )
      {
         /* Ddo_xt_loguserid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_loguserid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_loguserid_Sortedstatus = "ASC";
            ucDdo_xt_loguserid.SendProperty(context, "", false, Ddo_xt_loguserid_Internalname, "SortedStatus", Ddo_xt_loguserid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_loguserid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_loguserid_Sortedstatus = "DSC";
            ucDdo_xt_loguserid.SendProperty(context, "", false, Ddo_xt_loguserid_Internalname, "SortedStatus", Ddo_xt_loguserid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13XT_LogIDTitleFilterData", AV13XT_LogIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15XT_LogUserIDTitleFilterData", AV15XT_LogUserIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17XT_LogSecUserNameTitleFilterData", AV17XT_LogSecUserNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_LogTimeTitleFilterData", AV19XT_LogTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21XT_LogPageTitleFilterData", AV21XT_LogPageTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23XT_LogButtonNameTitleFilterData", AV23XT_LogButtonNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25XT_LogTypeTitleFilterData", AV25XT_LogTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27XT_LogProviderIDTitleFilterData", AV27XT_LogProviderIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29XT_LogProviderNameTitleFilterData", AV29XT_LogProviderNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31XT_LogTargetTitleFilterData", AV31XT_LogTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33XT_LogSonTargetTitleFilterData", AV33XT_LogSonTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35XT_LogTargetModuleTitleFilterData", AV35XT_LogTargetModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37XT_LogTargetSonModuleTitleFilterData", AV37XT_LogTargetSonModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39XT_LogTargetOperateTitleFilterData", AV39XT_LogTargetOperateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41XT_LogDescriptionTitleFilterData", AV41XT_LogDescriptionTitleFilterData);
      }

      protected void E154H2( )
      {
         /* Ddo_xt_logsecusername_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_logsecusername_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_logsecusername_Sortedstatus = "ASC";
            ucDdo_xt_logsecusername.SendProperty(context, "", false, Ddo_xt_logsecusername_Internalname, "SortedStatus", Ddo_xt_logsecusername_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_logsecusername_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_logsecusername_Sortedstatus = "DSC";
            ucDdo_xt_logsecusername.SendProperty(context, "", false, Ddo_xt_logsecusername_Internalname, "SortedStatus", Ddo_xt_logsecusername_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13XT_LogIDTitleFilterData", AV13XT_LogIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15XT_LogUserIDTitleFilterData", AV15XT_LogUserIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17XT_LogSecUserNameTitleFilterData", AV17XT_LogSecUserNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_LogTimeTitleFilterData", AV19XT_LogTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21XT_LogPageTitleFilterData", AV21XT_LogPageTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23XT_LogButtonNameTitleFilterData", AV23XT_LogButtonNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25XT_LogTypeTitleFilterData", AV25XT_LogTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27XT_LogProviderIDTitleFilterData", AV27XT_LogProviderIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29XT_LogProviderNameTitleFilterData", AV29XT_LogProviderNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31XT_LogTargetTitleFilterData", AV31XT_LogTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33XT_LogSonTargetTitleFilterData", AV33XT_LogSonTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35XT_LogTargetModuleTitleFilterData", AV35XT_LogTargetModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37XT_LogTargetSonModuleTitleFilterData", AV37XT_LogTargetSonModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39XT_LogTargetOperateTitleFilterData", AV39XT_LogTargetOperateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41XT_LogDescriptionTitleFilterData", AV41XT_LogDescriptionTitleFilterData);
      }

      protected void E164H2( )
      {
         /* Ddo_xt_logtime_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_logtime_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_logtime_Sortedstatus = "ASC";
            ucDdo_xt_logtime.SendProperty(context, "", false, Ddo_xt_logtime_Internalname, "SortedStatus", Ddo_xt_logtime_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_logtime_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_logtime_Sortedstatus = "DSC";
            ucDdo_xt_logtime.SendProperty(context, "", false, Ddo_xt_logtime_Internalname, "SortedStatus", Ddo_xt_logtime_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13XT_LogIDTitleFilterData", AV13XT_LogIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15XT_LogUserIDTitleFilterData", AV15XT_LogUserIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17XT_LogSecUserNameTitleFilterData", AV17XT_LogSecUserNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_LogTimeTitleFilterData", AV19XT_LogTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21XT_LogPageTitleFilterData", AV21XT_LogPageTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23XT_LogButtonNameTitleFilterData", AV23XT_LogButtonNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25XT_LogTypeTitleFilterData", AV25XT_LogTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27XT_LogProviderIDTitleFilterData", AV27XT_LogProviderIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29XT_LogProviderNameTitleFilterData", AV29XT_LogProviderNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31XT_LogTargetTitleFilterData", AV31XT_LogTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33XT_LogSonTargetTitleFilterData", AV33XT_LogSonTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35XT_LogTargetModuleTitleFilterData", AV35XT_LogTargetModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37XT_LogTargetSonModuleTitleFilterData", AV37XT_LogTargetSonModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39XT_LogTargetOperateTitleFilterData", AV39XT_LogTargetOperateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41XT_LogDescriptionTitleFilterData", AV41XT_LogDescriptionTitleFilterData);
      }

      protected void E174H2( )
      {
         /* Ddo_xt_logpage_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_logpage_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_logpage_Sortedstatus = "ASC";
            ucDdo_xt_logpage.SendProperty(context, "", false, Ddo_xt_logpage_Internalname, "SortedStatus", Ddo_xt_logpage_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_logpage_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_logpage_Sortedstatus = "DSC";
            ucDdo_xt_logpage.SendProperty(context, "", false, Ddo_xt_logpage_Internalname, "SortedStatus", Ddo_xt_logpage_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13XT_LogIDTitleFilterData", AV13XT_LogIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15XT_LogUserIDTitleFilterData", AV15XT_LogUserIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17XT_LogSecUserNameTitleFilterData", AV17XT_LogSecUserNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_LogTimeTitleFilterData", AV19XT_LogTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21XT_LogPageTitleFilterData", AV21XT_LogPageTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23XT_LogButtonNameTitleFilterData", AV23XT_LogButtonNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25XT_LogTypeTitleFilterData", AV25XT_LogTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27XT_LogProviderIDTitleFilterData", AV27XT_LogProviderIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29XT_LogProviderNameTitleFilterData", AV29XT_LogProviderNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31XT_LogTargetTitleFilterData", AV31XT_LogTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33XT_LogSonTargetTitleFilterData", AV33XT_LogSonTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35XT_LogTargetModuleTitleFilterData", AV35XT_LogTargetModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37XT_LogTargetSonModuleTitleFilterData", AV37XT_LogTargetSonModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39XT_LogTargetOperateTitleFilterData", AV39XT_LogTargetOperateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41XT_LogDescriptionTitleFilterData", AV41XT_LogDescriptionTitleFilterData);
      }

      protected void E184H2( )
      {
         /* Ddo_xt_logbuttonname_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_logbuttonname_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_logbuttonname_Sortedstatus = "ASC";
            ucDdo_xt_logbuttonname.SendProperty(context, "", false, Ddo_xt_logbuttonname_Internalname, "SortedStatus", Ddo_xt_logbuttonname_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_logbuttonname_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_logbuttonname_Sortedstatus = "DSC";
            ucDdo_xt_logbuttonname.SendProperty(context, "", false, Ddo_xt_logbuttonname_Internalname, "SortedStatus", Ddo_xt_logbuttonname_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13XT_LogIDTitleFilterData", AV13XT_LogIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15XT_LogUserIDTitleFilterData", AV15XT_LogUserIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17XT_LogSecUserNameTitleFilterData", AV17XT_LogSecUserNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_LogTimeTitleFilterData", AV19XT_LogTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21XT_LogPageTitleFilterData", AV21XT_LogPageTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23XT_LogButtonNameTitleFilterData", AV23XT_LogButtonNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25XT_LogTypeTitleFilterData", AV25XT_LogTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27XT_LogProviderIDTitleFilterData", AV27XT_LogProviderIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29XT_LogProviderNameTitleFilterData", AV29XT_LogProviderNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31XT_LogTargetTitleFilterData", AV31XT_LogTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33XT_LogSonTargetTitleFilterData", AV33XT_LogSonTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35XT_LogTargetModuleTitleFilterData", AV35XT_LogTargetModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37XT_LogTargetSonModuleTitleFilterData", AV37XT_LogTargetSonModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39XT_LogTargetOperateTitleFilterData", AV39XT_LogTargetOperateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41XT_LogDescriptionTitleFilterData", AV41XT_LogDescriptionTitleFilterData);
      }

      protected void E194H2( )
      {
         /* Ddo_xt_logtype_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_logtype_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_logtype_Sortedstatus = "ASC";
            ucDdo_xt_logtype.SendProperty(context, "", false, Ddo_xt_logtype_Internalname, "SortedStatus", Ddo_xt_logtype_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_logtype_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_logtype_Sortedstatus = "DSC";
            ucDdo_xt_logtype.SendProperty(context, "", false, Ddo_xt_logtype_Internalname, "SortedStatus", Ddo_xt_logtype_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13XT_LogIDTitleFilterData", AV13XT_LogIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15XT_LogUserIDTitleFilterData", AV15XT_LogUserIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17XT_LogSecUserNameTitleFilterData", AV17XT_LogSecUserNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_LogTimeTitleFilterData", AV19XT_LogTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21XT_LogPageTitleFilterData", AV21XT_LogPageTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23XT_LogButtonNameTitleFilterData", AV23XT_LogButtonNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25XT_LogTypeTitleFilterData", AV25XT_LogTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27XT_LogProviderIDTitleFilterData", AV27XT_LogProviderIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29XT_LogProviderNameTitleFilterData", AV29XT_LogProviderNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31XT_LogTargetTitleFilterData", AV31XT_LogTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33XT_LogSonTargetTitleFilterData", AV33XT_LogSonTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35XT_LogTargetModuleTitleFilterData", AV35XT_LogTargetModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37XT_LogTargetSonModuleTitleFilterData", AV37XT_LogTargetSonModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39XT_LogTargetOperateTitleFilterData", AV39XT_LogTargetOperateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41XT_LogDescriptionTitleFilterData", AV41XT_LogDescriptionTitleFilterData);
      }

      protected void E204H2( )
      {
         /* Ddo_xt_logproviderid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_logproviderid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_logproviderid_Sortedstatus = "ASC";
            ucDdo_xt_logproviderid.SendProperty(context, "", false, Ddo_xt_logproviderid_Internalname, "SortedStatus", Ddo_xt_logproviderid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_logproviderid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_logproviderid_Sortedstatus = "DSC";
            ucDdo_xt_logproviderid.SendProperty(context, "", false, Ddo_xt_logproviderid_Internalname, "SortedStatus", Ddo_xt_logproviderid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13XT_LogIDTitleFilterData", AV13XT_LogIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15XT_LogUserIDTitleFilterData", AV15XT_LogUserIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17XT_LogSecUserNameTitleFilterData", AV17XT_LogSecUserNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_LogTimeTitleFilterData", AV19XT_LogTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21XT_LogPageTitleFilterData", AV21XT_LogPageTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23XT_LogButtonNameTitleFilterData", AV23XT_LogButtonNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25XT_LogTypeTitleFilterData", AV25XT_LogTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27XT_LogProviderIDTitleFilterData", AV27XT_LogProviderIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29XT_LogProviderNameTitleFilterData", AV29XT_LogProviderNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31XT_LogTargetTitleFilterData", AV31XT_LogTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33XT_LogSonTargetTitleFilterData", AV33XT_LogSonTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35XT_LogTargetModuleTitleFilterData", AV35XT_LogTargetModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37XT_LogTargetSonModuleTitleFilterData", AV37XT_LogTargetSonModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39XT_LogTargetOperateTitleFilterData", AV39XT_LogTargetOperateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41XT_LogDescriptionTitleFilterData", AV41XT_LogDescriptionTitleFilterData);
      }

      protected void E214H2( )
      {
         /* Ddo_xt_logprovidername_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_logprovidername_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_logprovidername_Sortedstatus = "ASC";
            ucDdo_xt_logprovidername.SendProperty(context, "", false, Ddo_xt_logprovidername_Internalname, "SortedStatus", Ddo_xt_logprovidername_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_logprovidername_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_logprovidername_Sortedstatus = "DSC";
            ucDdo_xt_logprovidername.SendProperty(context, "", false, Ddo_xt_logprovidername_Internalname, "SortedStatus", Ddo_xt_logprovidername_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13XT_LogIDTitleFilterData", AV13XT_LogIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15XT_LogUserIDTitleFilterData", AV15XT_LogUserIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17XT_LogSecUserNameTitleFilterData", AV17XT_LogSecUserNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_LogTimeTitleFilterData", AV19XT_LogTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21XT_LogPageTitleFilterData", AV21XT_LogPageTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23XT_LogButtonNameTitleFilterData", AV23XT_LogButtonNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25XT_LogTypeTitleFilterData", AV25XT_LogTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27XT_LogProviderIDTitleFilterData", AV27XT_LogProviderIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29XT_LogProviderNameTitleFilterData", AV29XT_LogProviderNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31XT_LogTargetTitleFilterData", AV31XT_LogTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33XT_LogSonTargetTitleFilterData", AV33XT_LogSonTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35XT_LogTargetModuleTitleFilterData", AV35XT_LogTargetModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37XT_LogTargetSonModuleTitleFilterData", AV37XT_LogTargetSonModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39XT_LogTargetOperateTitleFilterData", AV39XT_LogTargetOperateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41XT_LogDescriptionTitleFilterData", AV41XT_LogDescriptionTitleFilterData);
      }

      protected void E224H2( )
      {
         /* Ddo_xt_logtarget_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_logtarget_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 10;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_logtarget_Sortedstatus = "ASC";
            ucDdo_xt_logtarget.SendProperty(context, "", false, Ddo_xt_logtarget_Internalname, "SortedStatus", Ddo_xt_logtarget_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_logtarget_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 10;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_logtarget_Sortedstatus = "DSC";
            ucDdo_xt_logtarget.SendProperty(context, "", false, Ddo_xt_logtarget_Internalname, "SortedStatus", Ddo_xt_logtarget_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13XT_LogIDTitleFilterData", AV13XT_LogIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15XT_LogUserIDTitleFilterData", AV15XT_LogUserIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17XT_LogSecUserNameTitleFilterData", AV17XT_LogSecUserNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_LogTimeTitleFilterData", AV19XT_LogTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21XT_LogPageTitleFilterData", AV21XT_LogPageTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23XT_LogButtonNameTitleFilterData", AV23XT_LogButtonNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25XT_LogTypeTitleFilterData", AV25XT_LogTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27XT_LogProviderIDTitleFilterData", AV27XT_LogProviderIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29XT_LogProviderNameTitleFilterData", AV29XT_LogProviderNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31XT_LogTargetTitleFilterData", AV31XT_LogTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33XT_LogSonTargetTitleFilterData", AV33XT_LogSonTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35XT_LogTargetModuleTitleFilterData", AV35XT_LogTargetModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37XT_LogTargetSonModuleTitleFilterData", AV37XT_LogTargetSonModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39XT_LogTargetOperateTitleFilterData", AV39XT_LogTargetOperateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41XT_LogDescriptionTitleFilterData", AV41XT_LogDescriptionTitleFilterData);
      }

      protected void E234H2( )
      {
         /* Ddo_xt_logsontarget_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_logsontarget_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_logsontarget_Sortedstatus = "ASC";
            ucDdo_xt_logsontarget.SendProperty(context, "", false, Ddo_xt_logsontarget_Internalname, "SortedStatus", Ddo_xt_logsontarget_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_logsontarget_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_logsontarget_Sortedstatus = "DSC";
            ucDdo_xt_logsontarget.SendProperty(context, "", false, Ddo_xt_logsontarget_Internalname, "SortedStatus", Ddo_xt_logsontarget_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13XT_LogIDTitleFilterData", AV13XT_LogIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15XT_LogUserIDTitleFilterData", AV15XT_LogUserIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17XT_LogSecUserNameTitleFilterData", AV17XT_LogSecUserNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_LogTimeTitleFilterData", AV19XT_LogTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21XT_LogPageTitleFilterData", AV21XT_LogPageTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23XT_LogButtonNameTitleFilterData", AV23XT_LogButtonNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25XT_LogTypeTitleFilterData", AV25XT_LogTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27XT_LogProviderIDTitleFilterData", AV27XT_LogProviderIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29XT_LogProviderNameTitleFilterData", AV29XT_LogProviderNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31XT_LogTargetTitleFilterData", AV31XT_LogTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33XT_LogSonTargetTitleFilterData", AV33XT_LogSonTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35XT_LogTargetModuleTitleFilterData", AV35XT_LogTargetModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37XT_LogTargetSonModuleTitleFilterData", AV37XT_LogTargetSonModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39XT_LogTargetOperateTitleFilterData", AV39XT_LogTargetOperateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41XT_LogDescriptionTitleFilterData", AV41XT_LogDescriptionTitleFilterData);
      }

      protected void E244H2( )
      {
         /* Ddo_xt_logtargetmodule_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_logtargetmodule_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_logtargetmodule_Sortedstatus = "ASC";
            ucDdo_xt_logtargetmodule.SendProperty(context, "", false, Ddo_xt_logtargetmodule_Internalname, "SortedStatus", Ddo_xt_logtargetmodule_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_logtargetmodule_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_logtargetmodule_Sortedstatus = "DSC";
            ucDdo_xt_logtargetmodule.SendProperty(context, "", false, Ddo_xt_logtargetmodule_Internalname, "SortedStatus", Ddo_xt_logtargetmodule_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13XT_LogIDTitleFilterData", AV13XT_LogIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15XT_LogUserIDTitleFilterData", AV15XT_LogUserIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17XT_LogSecUserNameTitleFilterData", AV17XT_LogSecUserNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_LogTimeTitleFilterData", AV19XT_LogTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21XT_LogPageTitleFilterData", AV21XT_LogPageTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23XT_LogButtonNameTitleFilterData", AV23XT_LogButtonNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25XT_LogTypeTitleFilterData", AV25XT_LogTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27XT_LogProviderIDTitleFilterData", AV27XT_LogProviderIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29XT_LogProviderNameTitleFilterData", AV29XT_LogProviderNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31XT_LogTargetTitleFilterData", AV31XT_LogTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33XT_LogSonTargetTitleFilterData", AV33XT_LogSonTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35XT_LogTargetModuleTitleFilterData", AV35XT_LogTargetModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37XT_LogTargetSonModuleTitleFilterData", AV37XT_LogTargetSonModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39XT_LogTargetOperateTitleFilterData", AV39XT_LogTargetOperateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41XT_LogDescriptionTitleFilterData", AV41XT_LogDescriptionTitleFilterData);
      }

      protected void E254H2( )
      {
         /* Ddo_xt_logtargetsonmodule_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_logtargetsonmodule_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 13;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_logtargetsonmodule_Sortedstatus = "ASC";
            ucDdo_xt_logtargetsonmodule.SendProperty(context, "", false, Ddo_xt_logtargetsonmodule_Internalname, "SortedStatus", Ddo_xt_logtargetsonmodule_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_logtargetsonmodule_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 13;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_logtargetsonmodule_Sortedstatus = "DSC";
            ucDdo_xt_logtargetsonmodule.SendProperty(context, "", false, Ddo_xt_logtargetsonmodule_Internalname, "SortedStatus", Ddo_xt_logtargetsonmodule_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13XT_LogIDTitleFilterData", AV13XT_LogIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15XT_LogUserIDTitleFilterData", AV15XT_LogUserIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17XT_LogSecUserNameTitleFilterData", AV17XT_LogSecUserNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_LogTimeTitleFilterData", AV19XT_LogTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21XT_LogPageTitleFilterData", AV21XT_LogPageTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23XT_LogButtonNameTitleFilterData", AV23XT_LogButtonNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25XT_LogTypeTitleFilterData", AV25XT_LogTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27XT_LogProviderIDTitleFilterData", AV27XT_LogProviderIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29XT_LogProviderNameTitleFilterData", AV29XT_LogProviderNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31XT_LogTargetTitleFilterData", AV31XT_LogTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33XT_LogSonTargetTitleFilterData", AV33XT_LogSonTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35XT_LogTargetModuleTitleFilterData", AV35XT_LogTargetModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37XT_LogTargetSonModuleTitleFilterData", AV37XT_LogTargetSonModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39XT_LogTargetOperateTitleFilterData", AV39XT_LogTargetOperateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41XT_LogDescriptionTitleFilterData", AV41XT_LogDescriptionTitleFilterData);
      }

      protected void E264H2( )
      {
         /* Ddo_xt_logtargetoperate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_logtargetoperate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 14;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_logtargetoperate_Sortedstatus = "ASC";
            ucDdo_xt_logtargetoperate.SendProperty(context, "", false, Ddo_xt_logtargetoperate_Internalname, "SortedStatus", Ddo_xt_logtargetoperate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_logtargetoperate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 14;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_logtargetoperate_Sortedstatus = "DSC";
            ucDdo_xt_logtargetoperate.SendProperty(context, "", false, Ddo_xt_logtargetoperate_Internalname, "SortedStatus", Ddo_xt_logtargetoperate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13XT_LogIDTitleFilterData", AV13XT_LogIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15XT_LogUserIDTitleFilterData", AV15XT_LogUserIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17XT_LogSecUserNameTitleFilterData", AV17XT_LogSecUserNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_LogTimeTitleFilterData", AV19XT_LogTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21XT_LogPageTitleFilterData", AV21XT_LogPageTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23XT_LogButtonNameTitleFilterData", AV23XT_LogButtonNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25XT_LogTypeTitleFilterData", AV25XT_LogTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27XT_LogProviderIDTitleFilterData", AV27XT_LogProviderIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29XT_LogProviderNameTitleFilterData", AV29XT_LogProviderNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31XT_LogTargetTitleFilterData", AV31XT_LogTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33XT_LogSonTargetTitleFilterData", AV33XT_LogSonTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35XT_LogTargetModuleTitleFilterData", AV35XT_LogTargetModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37XT_LogTargetSonModuleTitleFilterData", AV37XT_LogTargetSonModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39XT_LogTargetOperateTitleFilterData", AV39XT_LogTargetOperateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41XT_LogDescriptionTitleFilterData", AV41XT_LogDescriptionTitleFilterData);
      }

      protected void E274H2( )
      {
         /* Ddo_xt_logdescription_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_logdescription_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 15;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_logdescription_Sortedstatus = "ASC";
            ucDdo_xt_logdescription.SendProperty(context, "", false, Ddo_xt_logdescription_Internalname, "SortedStatus", Ddo_xt_logdescription_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_logdescription_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 15;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_xt_logdescription_Sortedstatus = "DSC";
            ucDdo_xt_logdescription.SendProperty(context, "", false, Ddo_xt_logdescription_Internalname, "SortedStatus", Ddo_xt_logdescription_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13XT_LogIDTitleFilterData", AV13XT_LogIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15XT_LogUserIDTitleFilterData", AV15XT_LogUserIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17XT_LogSecUserNameTitleFilterData", AV17XT_LogSecUserNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_LogTimeTitleFilterData", AV19XT_LogTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21XT_LogPageTitleFilterData", AV21XT_LogPageTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23XT_LogButtonNameTitleFilterData", AV23XT_LogButtonNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25XT_LogTypeTitleFilterData", AV25XT_LogTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27XT_LogProviderIDTitleFilterData", AV27XT_LogProviderIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29XT_LogProviderNameTitleFilterData", AV29XT_LogProviderNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31XT_LogTargetTitleFilterData", AV31XT_LogTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33XT_LogSonTargetTitleFilterData", AV33XT_LogSonTargetTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35XT_LogTargetModuleTitleFilterData", AV35XT_LogTargetModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37XT_LogTargetSonModuleTitleFilterData", AV37XT_LogTargetSonModuleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39XT_LogTargetOperateTitleFilterData", AV39XT_LogTargetOperateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41XT_LogDescriptionTitleFilterData", AV41XT_LogDescriptionTitleFilterData);
      }

      private void E304H2( )
      {
         /* Grid_Load Routine */
         AV48Select = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSelect_Internalname, AV48Select);
         AV52Select_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
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
         E314H2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E314H2( )
      {
         /* Enter Routine */
         AV8InOutXT_LogID = A173XT_LogID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutXT_LogID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutXT_LogID), 18, 0)));
         AV9InOutXT_LogUserID = A214XT_LogUserID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutXT_LogUserID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9InOutXT_LogUserID), 18, 0)));
         context.setWebReturnParms(new Object[] {(long)AV8InOutXT_LogID,(long)AV9InOutXT_LogUserID});
         context.setWebReturnParmsMetadata(new Object[] {"AV8InOutXT_LogID","AV9InOutXT_LogUserID"});
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
         AV8InOutXT_LogID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutXT_LogID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutXT_LogID), 18, 0)));
         AV9InOutXT_LogUserID = Convert.ToInt64(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutXT_LogUserID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9InOutXT_LogUserID), 18, 0)));
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
         PA4H2( ) ;
         WS4H2( ) ;
         WE4H2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279425251", true);
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
         context.AddJavascriptSource("xt_logprompt.js", "?20202279425251", false);
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
         edtXT_LogID_Internalname = "XT_LOGID_"+sGXsfl_12_idx;
         edtXT_LogUserID_Internalname = "XT_LOGUSERID_"+sGXsfl_12_idx;
         edtXT_LogSecUserName_Internalname = "XT_LOGSECUSERNAME_"+sGXsfl_12_idx;
         edtXT_LogTime_Internalname = "XT_LOGTIME_"+sGXsfl_12_idx;
         cmbXT_LogPage_Internalname = "XT_LOGPAGE_"+sGXsfl_12_idx;
         edtXT_LogButtonName_Internalname = "XT_LOGBUTTONNAME_"+sGXsfl_12_idx;
         edtXT_LogType_Internalname = "XT_LOGTYPE_"+sGXsfl_12_idx;
         edtXT_LogProviderID_Internalname = "XT_LOGPROVIDERID_"+sGXsfl_12_idx;
         edtXT_LogProviderName_Internalname = "XT_LOGPROVIDERNAME_"+sGXsfl_12_idx;
         edtXT_LogTarget_Internalname = "XT_LOGTARGET_"+sGXsfl_12_idx;
         edtXT_LogSonTarget_Internalname = "XT_LOGSONTARGET_"+sGXsfl_12_idx;
         edtXT_LogTargetModule_Internalname = "XT_LOGTARGETMODULE_"+sGXsfl_12_idx;
         edtXT_LogTargetSonModule_Internalname = "XT_LOGTARGETSONMODULE_"+sGXsfl_12_idx;
         cmbXT_LogTargetOperate_Internalname = "XT_LOGTARGETOPERATE_"+sGXsfl_12_idx;
         edtXT_LogDescription_Internalname = "XT_LOGDESCRIPTION_"+sGXsfl_12_idx;
      }

      protected void SubsflControlProps_fel_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_fel_idx;
         edtXT_LogID_Internalname = "XT_LOGID_"+sGXsfl_12_fel_idx;
         edtXT_LogUserID_Internalname = "XT_LOGUSERID_"+sGXsfl_12_fel_idx;
         edtXT_LogSecUserName_Internalname = "XT_LOGSECUSERNAME_"+sGXsfl_12_fel_idx;
         edtXT_LogTime_Internalname = "XT_LOGTIME_"+sGXsfl_12_fel_idx;
         cmbXT_LogPage_Internalname = "XT_LOGPAGE_"+sGXsfl_12_fel_idx;
         edtXT_LogButtonName_Internalname = "XT_LOGBUTTONNAME_"+sGXsfl_12_fel_idx;
         edtXT_LogType_Internalname = "XT_LOGTYPE_"+sGXsfl_12_fel_idx;
         edtXT_LogProviderID_Internalname = "XT_LOGPROVIDERID_"+sGXsfl_12_fel_idx;
         edtXT_LogProviderName_Internalname = "XT_LOGPROVIDERNAME_"+sGXsfl_12_fel_idx;
         edtXT_LogTarget_Internalname = "XT_LOGTARGET_"+sGXsfl_12_fel_idx;
         edtXT_LogSonTarget_Internalname = "XT_LOGSONTARGET_"+sGXsfl_12_fel_idx;
         edtXT_LogTargetModule_Internalname = "XT_LOGTARGETMODULE_"+sGXsfl_12_fel_idx;
         edtXT_LogTargetSonModule_Internalname = "XT_LOGTARGETSONMODULE_"+sGXsfl_12_fel_idx;
         cmbXT_LogTargetOperate_Internalname = "XT_LOGTARGETOPERATE_"+sGXsfl_12_fel_idx;
         edtXT_LogDescription_Internalname = "XT_LOGDESCRIPTION_"+sGXsfl_12_fel_idx;
      }

      protected void sendrow_122( )
      {
         SubsflControlProps_122( ) ;
         WB4H0( ) ;
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
            AV48Select_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV48Select))&&String.IsNullOrEmpty(StringUtil.RTrim( AV52Select_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV48Select)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV48Select)) ? AV52Select_GXI : context.PathToRelativeUrl( AV48Select));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSelect_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSelect_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSelect_Jsonclick,"'"+""+"'"+",false,"+"'"+"EENTER."+sGXsfl_12_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV48Select_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_LogID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A173XT_LogID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A173XT_LogID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_LogID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_LogUserID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A214XT_LogUserID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A214XT_LogUserID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_LogUserID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_LogSecUserName_Internalname,(String)A174XT_LogSecUserName,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_LogSecUserName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_LogTime_Internalname,context.localUtil.TToC( A220XT_LogTime, 10, 8, 0, 0, "/", ":", " "),context.localUtil.Format( A220XT_LogTime, "9999/99/99 99:99:99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_LogTime_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)19,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbXT_LogPage.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "XT_LOGPAGE_" + sGXsfl_12_idx;
               cmbXT_LogPage.Name = GXCCtl;
               cmbXT_LogPage.WebTags = "";
               if ( cmbXT_LogPage.ItemCount > 0 )
               {
                  A176XT_LogPage = cmbXT_LogPage.getValidValue(A176XT_LogPage);
                  n176XT_LogPage = false;
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbXT_LogPage,(String)cmbXT_LogPage_Internalname,StringUtil.RTrim( A176XT_LogPage),(short)1,(String)cmbXT_LogPage_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"svchar",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbXT_LogPage.CurrentValue = StringUtil.RTrim( A176XT_LogPage);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbXT_LogPage_Internalname, "Values", (String)(cmbXT_LogPage.ToJavascriptSource()), !bGXsfl_12_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_LogButtonName_Internalname,(String)A177XT_LogButtonName,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_LogButtonName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_LogType_Internalname,(String)A213XT_LogType,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_LogType_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"DM_LogType",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_LogProviderID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A215XT_LogProviderID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A215XT_LogProviderID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_LogProviderID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_LogProviderName_Internalname,(String)A219XT_LogProviderName,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_LogProviderName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_LogTarget_Internalname,(String)A216XT_LogTarget,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_LogTarget_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)5000,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_LogSonTarget_Internalname,(String)A223XT_LogSonTarget,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_LogSonTarget_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_LogTargetModule_Internalname,(String)A217XT_LogTargetModule,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_LogTargetModule_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_LogTargetSonModule_Internalname,(String)A222XT_LogTargetSonModule,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_LogTargetSonModule_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbXT_LogTargetOperate.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "XT_LOGTARGETOPERATE_" + sGXsfl_12_idx;
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
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbXT_LogTargetOperate,(String)cmbXT_LogTargetOperate_Internalname,StringUtil.RTrim( A218XT_LogTargetOperate),(short)1,(String)cmbXT_LogTargetOperate_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"svchar",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbXT_LogTargetOperate.CurrentValue = StringUtil.RTrim( A218XT_LogTargetOperate);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbXT_LogTargetOperate_Internalname, "Values", (String)(cmbXT_LogTargetOperate.ToJavascriptSource()), !bGXsfl_12_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_LogDescription_Internalname,(String)A221XT_LogDescription,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_LogDescription_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)5000,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes4H2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_12_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_12_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1));
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
         }
         /* End function sendrow_122 */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "XT_LOGPAGE_" + sGXsfl_12_idx;
         cmbXT_LogPage.Name = GXCCtl;
         cmbXT_LogPage.WebTags = "";
         if ( cmbXT_LogPage.ItemCount > 0 )
         {
            A176XT_LogPage = cmbXT_LogPage.getValidValue(A176XT_LogPage);
            n176XT_LogPage = false;
         }
         GXCCtl = "XT_LOGTARGETOPERATE_" + sGXsfl_12_idx;
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
         edtavSelect_Internalname = "vSELECT";
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
         Ddo_xt_logid_Internalname = "DDO_XT_LOGID";
         edtavDdo_xt_logidtitlecontrolidtoreplace_Internalname = "vDDO_XT_LOGIDTITLECONTROLIDTOREPLACE";
         Ddo_xt_loguserid_Internalname = "DDO_XT_LOGUSERID";
         edtavDdo_xt_loguseridtitlecontrolidtoreplace_Internalname = "vDDO_XT_LOGUSERIDTITLECONTROLIDTOREPLACE";
         Ddo_xt_logsecusername_Internalname = "DDO_XT_LOGSECUSERNAME";
         edtavDdo_xt_logsecusernametitlecontrolidtoreplace_Internalname = "vDDO_XT_LOGSECUSERNAMETITLECONTROLIDTOREPLACE";
         Ddo_xt_logtime_Internalname = "DDO_XT_LOGTIME";
         edtavDdo_xt_logtimetitlecontrolidtoreplace_Internalname = "vDDO_XT_LOGTIMETITLECONTROLIDTOREPLACE";
         Ddo_xt_logpage_Internalname = "DDO_XT_LOGPAGE";
         edtavDdo_xt_logpagetitlecontrolidtoreplace_Internalname = "vDDO_XT_LOGPAGETITLECONTROLIDTOREPLACE";
         Ddo_xt_logbuttonname_Internalname = "DDO_XT_LOGBUTTONNAME";
         edtavDdo_xt_logbuttonnametitlecontrolidtoreplace_Internalname = "vDDO_XT_LOGBUTTONNAMETITLECONTROLIDTOREPLACE";
         Ddo_xt_logtype_Internalname = "DDO_XT_LOGTYPE";
         edtavDdo_xt_logtypetitlecontrolidtoreplace_Internalname = "vDDO_XT_LOGTYPETITLECONTROLIDTOREPLACE";
         Ddo_xt_logproviderid_Internalname = "DDO_XT_LOGPROVIDERID";
         edtavDdo_xt_logprovideridtitlecontrolidtoreplace_Internalname = "vDDO_XT_LOGPROVIDERIDTITLECONTROLIDTOREPLACE";
         Ddo_xt_logprovidername_Internalname = "DDO_XT_LOGPROVIDERNAME";
         edtavDdo_xt_logprovidernametitlecontrolidtoreplace_Internalname = "vDDO_XT_LOGPROVIDERNAMETITLECONTROLIDTOREPLACE";
         Ddo_xt_logtarget_Internalname = "DDO_XT_LOGTARGET";
         edtavDdo_xt_logtargettitlecontrolidtoreplace_Internalname = "vDDO_XT_LOGTARGETTITLECONTROLIDTOREPLACE";
         Ddo_xt_logsontarget_Internalname = "DDO_XT_LOGSONTARGET";
         edtavDdo_xt_logsontargettitlecontrolidtoreplace_Internalname = "vDDO_XT_LOGSONTARGETTITLECONTROLIDTOREPLACE";
         Ddo_xt_logtargetmodule_Internalname = "DDO_XT_LOGTARGETMODULE";
         edtavDdo_xt_logtargetmoduletitlecontrolidtoreplace_Internalname = "vDDO_XT_LOGTARGETMODULETITLECONTROLIDTOREPLACE";
         Ddo_xt_logtargetsonmodule_Internalname = "DDO_XT_LOGTARGETSONMODULE";
         edtavDdo_xt_logtargetsonmoduletitlecontrolidtoreplace_Internalname = "vDDO_XT_LOGTARGETSONMODULETITLECONTROLIDTOREPLACE";
         Ddo_xt_logtargetoperate_Internalname = "DDO_XT_LOGTARGETOPERATE";
         edtavDdo_xt_logtargetoperatetitlecontrolidtoreplace_Internalname = "vDDO_XT_LOGTARGETOPERATETITLECONTROLIDTOREPLACE";
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
         edtavSelect_Jsonclick = "";
         edtavSelect_Visible = -1;
         edtavSelect_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_xt_logdescriptiontitlecontrolidtoreplace_Visible = 1;
         edtavDdo_xt_logtargetoperatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_xt_logtargetsonmoduletitlecontrolidtoreplace_Visible = 1;
         edtavDdo_xt_logtargetmoduletitlecontrolidtoreplace_Visible = 1;
         edtavDdo_xt_logsontargettitlecontrolidtoreplace_Visible = 1;
         edtavDdo_xt_logtargettitlecontrolidtoreplace_Visible = 1;
         edtavDdo_xt_logprovidernametitlecontrolidtoreplace_Visible = 1;
         edtavDdo_xt_logprovideridtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_xt_logtypetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_xt_logbuttonnametitlecontrolidtoreplace_Visible = 1;
         edtavDdo_xt_logpagetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_xt_logtimetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_xt_logsecusernametitlecontrolidtoreplace_Visible = 1;
         edtavDdo_xt_loguseridtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_xt_logidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavSelect_Tooltiptext = "选择";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtXT_LogDescription_Titleformat = 0;
         edtXT_LogDescription_Title = "日志描述";
         cmbXT_LogTargetOperate_Titleformat = 0;
         cmbXT_LogTargetOperate.Title.Text = "日志操作对象动作";
         edtXT_LogTargetSonModule_Titleformat = 0;
         edtXT_LogTargetSonModule_Title = "日志操作模块子模块";
         edtXT_LogTargetModule_Titleformat = 0;
         edtXT_LogTargetModule_Title = "日志操作模块";
         edtXT_LogSonTarget_Titleformat = 0;
         edtXT_LogSonTarget_Title = "日志操作子对象";
         edtXT_LogTarget_Titleformat = 0;
         edtXT_LogTarget_Title = "日志操作对象";
         edtXT_LogProviderName_Titleformat = 0;
         edtXT_LogProviderName_Title = "日志分院名称";
         edtXT_LogProviderID_Titleformat = 0;
         edtXT_LogProviderID_Title = "ID";
         edtXT_LogType_Titleformat = 0;
         edtXT_LogType_Title = "日志类型";
         edtXT_LogButtonName_Titleformat = 0;
         edtXT_LogButtonName_Title = "操作的按钮";
         cmbXT_LogPage_Titleformat = 0;
         cmbXT_LogPage.Title.Text = "操作页面";
         edtXT_LogTime_Titleformat = 0;
         edtXT_LogTime_Title = "操作时间";
         edtXT_LogSecUserName_Titleformat = 0;
         edtXT_LogSecUserName_Title = "操作人";
         edtXT_LogUserID_Titleformat = 0;
         edtXT_LogUserID_Title = "ID";
         edtXT_LogID_Titleformat = 0;
         edtXT_LogID_Title = "系统日志主键";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         divTablemain_Height = 0;
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
         Ddo_xt_logtargetoperate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_logtargetoperate_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_logtargetoperate_Sortasc = "WWP_TSSortASC";
         Ddo_xt_logtargetoperate_Includedatalist = Convert.ToBoolean( 0);
         Ddo_xt_logtargetoperate_Includefilter = Convert.ToBoolean( 0);
         Ddo_xt_logtargetoperate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_xt_logtargetoperate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_xt_logtargetoperate_Titlecontrolidtoreplace = "";
         Ddo_xt_logtargetoperate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_xt_logtargetoperate_Cls = "ColumnSettings";
         Ddo_xt_logtargetoperate_Tooltip = "WWP_TSColumnOptions";
         Ddo_xt_logtargetoperate_Caption = "";
         Ddo_xt_logtargetsonmodule_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_logtargetsonmodule_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_logtargetsonmodule_Sortasc = "WWP_TSSortASC";
         Ddo_xt_logtargetsonmodule_Includedatalist = Convert.ToBoolean( 0);
         Ddo_xt_logtargetsonmodule_Includefilter = Convert.ToBoolean( 0);
         Ddo_xt_logtargetsonmodule_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_xt_logtargetsonmodule_Includesortasc = Convert.ToBoolean( -1);
         Ddo_xt_logtargetsonmodule_Titlecontrolidtoreplace = "";
         Ddo_xt_logtargetsonmodule_Dropdownoptionstype = "GridTitleSettings";
         Ddo_xt_logtargetsonmodule_Cls = "ColumnSettings";
         Ddo_xt_logtargetsonmodule_Tooltip = "WWP_TSColumnOptions";
         Ddo_xt_logtargetsonmodule_Caption = "";
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
         Ddo_xt_logsontarget_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_logsontarget_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_logsontarget_Sortasc = "WWP_TSSortASC";
         Ddo_xt_logsontarget_Includedatalist = Convert.ToBoolean( 0);
         Ddo_xt_logsontarget_Includefilter = Convert.ToBoolean( 0);
         Ddo_xt_logsontarget_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_xt_logsontarget_Includesortasc = Convert.ToBoolean( -1);
         Ddo_xt_logsontarget_Titlecontrolidtoreplace = "";
         Ddo_xt_logsontarget_Dropdownoptionstype = "GridTitleSettings";
         Ddo_xt_logsontarget_Cls = "ColumnSettings";
         Ddo_xt_logsontarget_Tooltip = "WWP_TSColumnOptions";
         Ddo_xt_logsontarget_Caption = "";
         Ddo_xt_logtarget_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_logtarget_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_logtarget_Sortasc = "WWP_TSSortASC";
         Ddo_xt_logtarget_Includedatalist = Convert.ToBoolean( 0);
         Ddo_xt_logtarget_Includefilter = Convert.ToBoolean( 0);
         Ddo_xt_logtarget_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_xt_logtarget_Includesortasc = Convert.ToBoolean( -1);
         Ddo_xt_logtarget_Titlecontrolidtoreplace = "";
         Ddo_xt_logtarget_Dropdownoptionstype = "GridTitleSettings";
         Ddo_xt_logtarget_Cls = "ColumnSettings";
         Ddo_xt_logtarget_Tooltip = "WWP_TSColumnOptions";
         Ddo_xt_logtarget_Caption = "";
         Ddo_xt_logprovidername_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_logprovidername_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_logprovidername_Sortasc = "WWP_TSSortASC";
         Ddo_xt_logprovidername_Includedatalist = Convert.ToBoolean( 0);
         Ddo_xt_logprovidername_Includefilter = Convert.ToBoolean( 0);
         Ddo_xt_logprovidername_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_xt_logprovidername_Includesortasc = Convert.ToBoolean( -1);
         Ddo_xt_logprovidername_Titlecontrolidtoreplace = "";
         Ddo_xt_logprovidername_Dropdownoptionstype = "GridTitleSettings";
         Ddo_xt_logprovidername_Cls = "ColumnSettings";
         Ddo_xt_logprovidername_Tooltip = "WWP_TSColumnOptions";
         Ddo_xt_logprovidername_Caption = "";
         Ddo_xt_logproviderid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_logproviderid_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_logproviderid_Sortasc = "WWP_TSSortASC";
         Ddo_xt_logproviderid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_xt_logproviderid_Includefilter = Convert.ToBoolean( 0);
         Ddo_xt_logproviderid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_xt_logproviderid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_xt_logproviderid_Titlecontrolidtoreplace = "";
         Ddo_xt_logproviderid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_xt_logproviderid_Cls = "ColumnSettings";
         Ddo_xt_logproviderid_Tooltip = "WWP_TSColumnOptions";
         Ddo_xt_logproviderid_Caption = "";
         Ddo_xt_logtype_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_logtype_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_logtype_Sortasc = "WWP_TSSortASC";
         Ddo_xt_logtype_Includedatalist = Convert.ToBoolean( 0);
         Ddo_xt_logtype_Includefilter = Convert.ToBoolean( 0);
         Ddo_xt_logtype_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_xt_logtype_Includesortasc = Convert.ToBoolean( -1);
         Ddo_xt_logtype_Titlecontrolidtoreplace = "";
         Ddo_xt_logtype_Dropdownoptionstype = "GridTitleSettings";
         Ddo_xt_logtype_Cls = "ColumnSettings";
         Ddo_xt_logtype_Tooltip = "WWP_TSColumnOptions";
         Ddo_xt_logtype_Caption = "";
         Ddo_xt_logbuttonname_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_logbuttonname_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_logbuttonname_Sortasc = "WWP_TSSortASC";
         Ddo_xt_logbuttonname_Includedatalist = Convert.ToBoolean( 0);
         Ddo_xt_logbuttonname_Includefilter = Convert.ToBoolean( 0);
         Ddo_xt_logbuttonname_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_xt_logbuttonname_Includesortasc = Convert.ToBoolean( -1);
         Ddo_xt_logbuttonname_Titlecontrolidtoreplace = "";
         Ddo_xt_logbuttonname_Dropdownoptionstype = "GridTitleSettings";
         Ddo_xt_logbuttonname_Cls = "ColumnSettings";
         Ddo_xt_logbuttonname_Tooltip = "WWP_TSColumnOptions";
         Ddo_xt_logbuttonname_Caption = "";
         Ddo_xt_logpage_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_logpage_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_logpage_Sortasc = "WWP_TSSortASC";
         Ddo_xt_logpage_Includedatalist = Convert.ToBoolean( 0);
         Ddo_xt_logpage_Includefilter = Convert.ToBoolean( 0);
         Ddo_xt_logpage_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_xt_logpage_Includesortasc = Convert.ToBoolean( -1);
         Ddo_xt_logpage_Titlecontrolidtoreplace = "";
         Ddo_xt_logpage_Dropdownoptionstype = "GridTitleSettings";
         Ddo_xt_logpage_Cls = "ColumnSettings";
         Ddo_xt_logpage_Tooltip = "WWP_TSColumnOptions";
         Ddo_xt_logpage_Caption = "";
         Ddo_xt_logtime_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_logtime_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_logtime_Sortasc = "WWP_TSSortASC";
         Ddo_xt_logtime_Includedatalist = Convert.ToBoolean( 0);
         Ddo_xt_logtime_Includefilter = Convert.ToBoolean( 0);
         Ddo_xt_logtime_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_xt_logtime_Includesortasc = Convert.ToBoolean( -1);
         Ddo_xt_logtime_Titlecontrolidtoreplace = "";
         Ddo_xt_logtime_Dropdownoptionstype = "GridTitleSettings";
         Ddo_xt_logtime_Cls = "ColumnSettings";
         Ddo_xt_logtime_Tooltip = "WWP_TSColumnOptions";
         Ddo_xt_logtime_Caption = "";
         Ddo_xt_logsecusername_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_logsecusername_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_logsecusername_Sortasc = "WWP_TSSortASC";
         Ddo_xt_logsecusername_Includedatalist = Convert.ToBoolean( 0);
         Ddo_xt_logsecusername_Includefilter = Convert.ToBoolean( 0);
         Ddo_xt_logsecusername_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_xt_logsecusername_Includesortasc = Convert.ToBoolean( -1);
         Ddo_xt_logsecusername_Titlecontrolidtoreplace = "";
         Ddo_xt_logsecusername_Dropdownoptionstype = "GridTitleSettings";
         Ddo_xt_logsecusername_Cls = "ColumnSettings";
         Ddo_xt_logsecusername_Tooltip = "WWP_TSColumnOptions";
         Ddo_xt_logsecusername_Caption = "";
         Ddo_xt_loguserid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_loguserid_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_loguserid_Sortasc = "WWP_TSSortASC";
         Ddo_xt_loguserid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_xt_loguserid_Includefilter = Convert.ToBoolean( 0);
         Ddo_xt_loguserid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_xt_loguserid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_xt_loguserid_Titlecontrolidtoreplace = "";
         Ddo_xt_loguserid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_xt_loguserid_Cls = "ColumnSettings";
         Ddo_xt_loguserid_Tooltip = "WWP_TSColumnOptions";
         Ddo_xt_loguserid_Caption = "";
         Ddo_xt_logid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_xt_logid_Sortdsc = "WWP_TSSortDSC";
         Ddo_xt_logid_Sortasc = "WWP_TSSortASC";
         Ddo_xt_logid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_xt_logid_Includefilter = Convert.ToBoolean( 0);
         Ddo_xt_logid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_xt_logid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_xt_logid_Titlecontrolidtoreplace = "";
         Ddo_xt_logid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_xt_logid_Cls = "ColumnSettings";
         Ddo_xt_logid_Tooltip = "WWP_TSColumnOptions";
         Ddo_xt_logid_Caption = "";
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
         Form.Caption = "选择系统日志";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_LogIDTitleControlIdToReplace',fld:'vDDO_XT_LOGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_LogUserIDTitleControlIdToReplace',fld:'vDDO_XT_LOGUSERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_LogSecUserNameTitleControlIdToReplace',fld:'vDDO_XT_LOGSECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_LogTimeTitleControlIdToReplace',fld:'vDDO_XT_LOGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_XT_LogPageTitleControlIdToReplace',fld:'vDDO_XT_LOGPAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_XT_LogButtonNameTitleControlIdToReplace',fld:'vDDO_XT_LOGBUTTONNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_XT_LogTypeTitleControlIdToReplace',fld:'vDDO_XT_LOGTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_XT_LogProviderIDTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_XT_LogProviderNameTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_XT_LogTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_XT_LogSonTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGSONTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_XT_LogTargetModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETSONMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_XT_LogTargetOperateTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETOPERATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_XT_LogDescriptionTitleControlIdToReplace',fld:'vDDO_XT_LOGDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV13XT_LogIDTitleFilterData',fld:'vXT_LOGIDTITLEFILTERDATA',pic:''},{av:'AV15XT_LogUserIDTitleFilterData',fld:'vXT_LOGUSERIDTITLEFILTERDATA',pic:''},{av:'AV17XT_LogSecUserNameTitleFilterData',fld:'vXT_LOGSECUSERNAMETITLEFILTERDATA',pic:''},{av:'AV19XT_LogTimeTitleFilterData',fld:'vXT_LOGTIMETITLEFILTERDATA',pic:''},{av:'AV21XT_LogPageTitleFilterData',fld:'vXT_LOGPAGETITLEFILTERDATA',pic:''},{av:'AV23XT_LogButtonNameTitleFilterData',fld:'vXT_LOGBUTTONNAMETITLEFILTERDATA',pic:''},{av:'AV25XT_LogTypeTitleFilterData',fld:'vXT_LOGTYPETITLEFILTERDATA',pic:''},{av:'AV27XT_LogProviderIDTitleFilterData',fld:'vXT_LOGPROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV29XT_LogProviderNameTitleFilterData',fld:'vXT_LOGPROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV31XT_LogTargetTitleFilterData',fld:'vXT_LOGTARGETTITLEFILTERDATA',pic:''},{av:'AV33XT_LogSonTargetTitleFilterData',fld:'vXT_LOGSONTARGETTITLEFILTERDATA',pic:''},{av:'AV35XT_LogTargetModuleTitleFilterData',fld:'vXT_LOGTARGETMODULETITLEFILTERDATA',pic:''},{av:'AV37XT_LogTargetSonModuleTitleFilterData',fld:'vXT_LOGTARGETSONMODULETITLEFILTERDATA',pic:''},{av:'AV39XT_LogTargetOperateTitleFilterData',fld:'vXT_LOGTARGETOPERATETITLEFILTERDATA',pic:''},{av:'AV41XT_LogDescriptionTitleFilterData',fld:'vXT_LOGDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtXT_LogID_Titleformat',ctrl:'XT_LOGID',prop:'Titleformat'},{av:'edtXT_LogID_Title',ctrl:'XT_LOGID',prop:'Title'},{av:'edtXT_LogUserID_Titleformat',ctrl:'XT_LOGUSERID',prop:'Titleformat'},{av:'edtXT_LogUserID_Title',ctrl:'XT_LOGUSERID',prop:'Title'},{av:'edtXT_LogSecUserName_Titleformat',ctrl:'XT_LOGSECUSERNAME',prop:'Titleformat'},{av:'edtXT_LogSecUserName_Title',ctrl:'XT_LOGSECUSERNAME',prop:'Title'},{av:'edtXT_LogTime_Titleformat',ctrl:'XT_LOGTIME',prop:'Titleformat'},{av:'edtXT_LogTime_Title',ctrl:'XT_LOGTIME',prop:'Title'},{av:'cmbXT_LogPage'},{av:'edtXT_LogButtonName_Titleformat',ctrl:'XT_LOGBUTTONNAME',prop:'Titleformat'},{av:'edtXT_LogButtonName_Title',ctrl:'XT_LOGBUTTONNAME',prop:'Title'},{av:'edtXT_LogType_Titleformat',ctrl:'XT_LOGTYPE',prop:'Titleformat'},{av:'edtXT_LogType_Title',ctrl:'XT_LOGTYPE',prop:'Title'},{av:'edtXT_LogProviderID_Titleformat',ctrl:'XT_LOGPROVIDERID',prop:'Titleformat'},{av:'edtXT_LogProviderID_Title',ctrl:'XT_LOGPROVIDERID',prop:'Title'},{av:'edtXT_LogProviderName_Titleformat',ctrl:'XT_LOGPROVIDERNAME',prop:'Titleformat'},{av:'edtXT_LogProviderName_Title',ctrl:'XT_LOGPROVIDERNAME',prop:'Title'},{av:'edtXT_LogTarget_Titleformat',ctrl:'XT_LOGTARGET',prop:'Titleformat'},{av:'edtXT_LogTarget_Title',ctrl:'XT_LOGTARGET',prop:'Title'},{av:'edtXT_LogSonTarget_Titleformat',ctrl:'XT_LOGSONTARGET',prop:'Titleformat'},{av:'edtXT_LogSonTarget_Title',ctrl:'XT_LOGSONTARGET',prop:'Title'},{av:'edtXT_LogTargetModule_Titleformat',ctrl:'XT_LOGTARGETMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetModule_Title',ctrl:'XT_LOGTARGETMODULE',prop:'Title'},{av:'edtXT_LogTargetSonModule_Titleformat',ctrl:'XT_LOGTARGETSONMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetSonModule_Title',ctrl:'XT_LOGTARGETSONMODULE',prop:'Title'},{av:'cmbXT_LogTargetOperate'},{av:'edtXT_LogDescription_Titleformat',ctrl:'XT_LOGDESCRIPTION',prop:'Titleformat'},{av:'edtXT_LogDescription_Title',ctrl:'XT_LOGDESCRIPTION',prop:'Title'},{av:'AV45GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV46GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV47GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E114H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_LogIDTitleControlIdToReplace',fld:'vDDO_XT_LOGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_LogUserIDTitleControlIdToReplace',fld:'vDDO_XT_LOGUSERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_LogSecUserNameTitleControlIdToReplace',fld:'vDDO_XT_LOGSECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_LogTimeTitleControlIdToReplace',fld:'vDDO_XT_LOGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_XT_LogPageTitleControlIdToReplace',fld:'vDDO_XT_LOGPAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_XT_LogButtonNameTitleControlIdToReplace',fld:'vDDO_XT_LOGBUTTONNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_XT_LogTypeTitleControlIdToReplace',fld:'vDDO_XT_LOGTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_XT_LogProviderIDTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_XT_LogProviderNameTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_XT_LogTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_XT_LogSonTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGSONTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_XT_LogTargetModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETSONMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_XT_LogTargetOperateTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETOPERATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_XT_LogDescriptionTitleControlIdToReplace',fld:'vDDO_XT_LOGDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E124H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_LogIDTitleControlIdToReplace',fld:'vDDO_XT_LOGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_LogUserIDTitleControlIdToReplace',fld:'vDDO_XT_LOGUSERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_LogSecUserNameTitleControlIdToReplace',fld:'vDDO_XT_LOGSECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_LogTimeTitleControlIdToReplace',fld:'vDDO_XT_LOGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_XT_LogPageTitleControlIdToReplace',fld:'vDDO_XT_LOGPAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_XT_LogButtonNameTitleControlIdToReplace',fld:'vDDO_XT_LOGBUTTONNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_XT_LogTypeTitleControlIdToReplace',fld:'vDDO_XT_LOGTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_XT_LogProviderIDTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_XT_LogProviderNameTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_XT_LogTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_XT_LogSonTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGSONTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_XT_LogTargetModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETSONMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_XT_LogTargetOperateTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETOPERATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_XT_LogDescriptionTitleControlIdToReplace',fld:'vDDO_XT_LOGDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_XT_LOGID.ONOPTIONCLICKED","{handler:'E134H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_LogIDTitleControlIdToReplace',fld:'vDDO_XT_LOGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_LogUserIDTitleControlIdToReplace',fld:'vDDO_XT_LOGUSERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_LogSecUserNameTitleControlIdToReplace',fld:'vDDO_XT_LOGSECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_LogTimeTitleControlIdToReplace',fld:'vDDO_XT_LOGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_XT_LogPageTitleControlIdToReplace',fld:'vDDO_XT_LOGPAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_XT_LogButtonNameTitleControlIdToReplace',fld:'vDDO_XT_LOGBUTTONNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_XT_LogTypeTitleControlIdToReplace',fld:'vDDO_XT_LOGTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_XT_LogProviderIDTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_XT_LogProviderNameTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_XT_LogTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_XT_LogSonTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGSONTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_XT_LogTargetModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETSONMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_XT_LogTargetOperateTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETOPERATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_XT_LogDescriptionTitleControlIdToReplace',fld:'vDDO_XT_LOGDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_xt_logid_Activeeventkey',ctrl:'DDO_XT_LOGID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_LOGID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_logid_Sortedstatus',ctrl:'DDO_XT_LOGID',prop:'SortedStatus'},{av:'AV13XT_LogIDTitleFilterData',fld:'vXT_LOGIDTITLEFILTERDATA',pic:''},{av:'AV15XT_LogUserIDTitleFilterData',fld:'vXT_LOGUSERIDTITLEFILTERDATA',pic:''},{av:'AV17XT_LogSecUserNameTitleFilterData',fld:'vXT_LOGSECUSERNAMETITLEFILTERDATA',pic:''},{av:'AV19XT_LogTimeTitleFilterData',fld:'vXT_LOGTIMETITLEFILTERDATA',pic:''},{av:'AV21XT_LogPageTitleFilterData',fld:'vXT_LOGPAGETITLEFILTERDATA',pic:''},{av:'AV23XT_LogButtonNameTitleFilterData',fld:'vXT_LOGBUTTONNAMETITLEFILTERDATA',pic:''},{av:'AV25XT_LogTypeTitleFilterData',fld:'vXT_LOGTYPETITLEFILTERDATA',pic:''},{av:'AV27XT_LogProviderIDTitleFilterData',fld:'vXT_LOGPROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV29XT_LogProviderNameTitleFilterData',fld:'vXT_LOGPROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV31XT_LogTargetTitleFilterData',fld:'vXT_LOGTARGETTITLEFILTERDATA',pic:''},{av:'AV33XT_LogSonTargetTitleFilterData',fld:'vXT_LOGSONTARGETTITLEFILTERDATA',pic:''},{av:'AV35XT_LogTargetModuleTitleFilterData',fld:'vXT_LOGTARGETMODULETITLEFILTERDATA',pic:''},{av:'AV37XT_LogTargetSonModuleTitleFilterData',fld:'vXT_LOGTARGETSONMODULETITLEFILTERDATA',pic:''},{av:'AV39XT_LogTargetOperateTitleFilterData',fld:'vXT_LOGTARGETOPERATETITLEFILTERDATA',pic:''},{av:'AV41XT_LogDescriptionTitleFilterData',fld:'vXT_LOGDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtXT_LogID_Titleformat',ctrl:'XT_LOGID',prop:'Titleformat'},{av:'edtXT_LogID_Title',ctrl:'XT_LOGID',prop:'Title'},{av:'edtXT_LogUserID_Titleformat',ctrl:'XT_LOGUSERID',prop:'Titleformat'},{av:'edtXT_LogUserID_Title',ctrl:'XT_LOGUSERID',prop:'Title'},{av:'edtXT_LogSecUserName_Titleformat',ctrl:'XT_LOGSECUSERNAME',prop:'Titleformat'},{av:'edtXT_LogSecUserName_Title',ctrl:'XT_LOGSECUSERNAME',prop:'Title'},{av:'edtXT_LogTime_Titleformat',ctrl:'XT_LOGTIME',prop:'Titleformat'},{av:'edtXT_LogTime_Title',ctrl:'XT_LOGTIME',prop:'Title'},{av:'cmbXT_LogPage'},{av:'edtXT_LogButtonName_Titleformat',ctrl:'XT_LOGBUTTONNAME',prop:'Titleformat'},{av:'edtXT_LogButtonName_Title',ctrl:'XT_LOGBUTTONNAME',prop:'Title'},{av:'edtXT_LogType_Titleformat',ctrl:'XT_LOGTYPE',prop:'Titleformat'},{av:'edtXT_LogType_Title',ctrl:'XT_LOGTYPE',prop:'Title'},{av:'edtXT_LogProviderID_Titleformat',ctrl:'XT_LOGPROVIDERID',prop:'Titleformat'},{av:'edtXT_LogProviderID_Title',ctrl:'XT_LOGPROVIDERID',prop:'Title'},{av:'edtXT_LogProviderName_Titleformat',ctrl:'XT_LOGPROVIDERNAME',prop:'Titleformat'},{av:'edtXT_LogProviderName_Title',ctrl:'XT_LOGPROVIDERNAME',prop:'Title'},{av:'edtXT_LogTarget_Titleformat',ctrl:'XT_LOGTARGET',prop:'Titleformat'},{av:'edtXT_LogTarget_Title',ctrl:'XT_LOGTARGET',prop:'Title'},{av:'edtXT_LogSonTarget_Titleformat',ctrl:'XT_LOGSONTARGET',prop:'Titleformat'},{av:'edtXT_LogSonTarget_Title',ctrl:'XT_LOGSONTARGET',prop:'Title'},{av:'edtXT_LogTargetModule_Titleformat',ctrl:'XT_LOGTARGETMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetModule_Title',ctrl:'XT_LOGTARGETMODULE',prop:'Title'},{av:'edtXT_LogTargetSonModule_Titleformat',ctrl:'XT_LOGTARGETSONMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetSonModule_Title',ctrl:'XT_LOGTARGETSONMODULE',prop:'Title'},{av:'cmbXT_LogTargetOperate'},{av:'edtXT_LogDescription_Titleformat',ctrl:'XT_LOGDESCRIPTION',prop:'Titleformat'},{av:'edtXT_LogDescription_Title',ctrl:'XT_LOGDESCRIPTION',prop:'Title'},{av:'AV45GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV46GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV47GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_XT_LOGUSERID.ONOPTIONCLICKED","{handler:'E144H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_LogIDTitleControlIdToReplace',fld:'vDDO_XT_LOGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_LogUserIDTitleControlIdToReplace',fld:'vDDO_XT_LOGUSERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_LogSecUserNameTitleControlIdToReplace',fld:'vDDO_XT_LOGSECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_LogTimeTitleControlIdToReplace',fld:'vDDO_XT_LOGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_XT_LogPageTitleControlIdToReplace',fld:'vDDO_XT_LOGPAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_XT_LogButtonNameTitleControlIdToReplace',fld:'vDDO_XT_LOGBUTTONNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_XT_LogTypeTitleControlIdToReplace',fld:'vDDO_XT_LOGTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_XT_LogProviderIDTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_XT_LogProviderNameTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_XT_LogTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_XT_LogSonTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGSONTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_XT_LogTargetModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETSONMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_XT_LogTargetOperateTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETOPERATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_XT_LogDescriptionTitleControlIdToReplace',fld:'vDDO_XT_LOGDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_xt_loguserid_Activeeventkey',ctrl:'DDO_XT_LOGUSERID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_LOGUSERID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_loguserid_Sortedstatus',ctrl:'DDO_XT_LOGUSERID',prop:'SortedStatus'},{av:'AV13XT_LogIDTitleFilterData',fld:'vXT_LOGIDTITLEFILTERDATA',pic:''},{av:'AV15XT_LogUserIDTitleFilterData',fld:'vXT_LOGUSERIDTITLEFILTERDATA',pic:''},{av:'AV17XT_LogSecUserNameTitleFilterData',fld:'vXT_LOGSECUSERNAMETITLEFILTERDATA',pic:''},{av:'AV19XT_LogTimeTitleFilterData',fld:'vXT_LOGTIMETITLEFILTERDATA',pic:''},{av:'AV21XT_LogPageTitleFilterData',fld:'vXT_LOGPAGETITLEFILTERDATA',pic:''},{av:'AV23XT_LogButtonNameTitleFilterData',fld:'vXT_LOGBUTTONNAMETITLEFILTERDATA',pic:''},{av:'AV25XT_LogTypeTitleFilterData',fld:'vXT_LOGTYPETITLEFILTERDATA',pic:''},{av:'AV27XT_LogProviderIDTitleFilterData',fld:'vXT_LOGPROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV29XT_LogProviderNameTitleFilterData',fld:'vXT_LOGPROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV31XT_LogTargetTitleFilterData',fld:'vXT_LOGTARGETTITLEFILTERDATA',pic:''},{av:'AV33XT_LogSonTargetTitleFilterData',fld:'vXT_LOGSONTARGETTITLEFILTERDATA',pic:''},{av:'AV35XT_LogTargetModuleTitleFilterData',fld:'vXT_LOGTARGETMODULETITLEFILTERDATA',pic:''},{av:'AV37XT_LogTargetSonModuleTitleFilterData',fld:'vXT_LOGTARGETSONMODULETITLEFILTERDATA',pic:''},{av:'AV39XT_LogTargetOperateTitleFilterData',fld:'vXT_LOGTARGETOPERATETITLEFILTERDATA',pic:''},{av:'AV41XT_LogDescriptionTitleFilterData',fld:'vXT_LOGDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtXT_LogID_Titleformat',ctrl:'XT_LOGID',prop:'Titleformat'},{av:'edtXT_LogID_Title',ctrl:'XT_LOGID',prop:'Title'},{av:'edtXT_LogUserID_Titleformat',ctrl:'XT_LOGUSERID',prop:'Titleformat'},{av:'edtXT_LogUserID_Title',ctrl:'XT_LOGUSERID',prop:'Title'},{av:'edtXT_LogSecUserName_Titleformat',ctrl:'XT_LOGSECUSERNAME',prop:'Titleformat'},{av:'edtXT_LogSecUserName_Title',ctrl:'XT_LOGSECUSERNAME',prop:'Title'},{av:'edtXT_LogTime_Titleformat',ctrl:'XT_LOGTIME',prop:'Titleformat'},{av:'edtXT_LogTime_Title',ctrl:'XT_LOGTIME',prop:'Title'},{av:'cmbXT_LogPage'},{av:'edtXT_LogButtonName_Titleformat',ctrl:'XT_LOGBUTTONNAME',prop:'Titleformat'},{av:'edtXT_LogButtonName_Title',ctrl:'XT_LOGBUTTONNAME',prop:'Title'},{av:'edtXT_LogType_Titleformat',ctrl:'XT_LOGTYPE',prop:'Titleformat'},{av:'edtXT_LogType_Title',ctrl:'XT_LOGTYPE',prop:'Title'},{av:'edtXT_LogProviderID_Titleformat',ctrl:'XT_LOGPROVIDERID',prop:'Titleformat'},{av:'edtXT_LogProviderID_Title',ctrl:'XT_LOGPROVIDERID',prop:'Title'},{av:'edtXT_LogProviderName_Titleformat',ctrl:'XT_LOGPROVIDERNAME',prop:'Titleformat'},{av:'edtXT_LogProviderName_Title',ctrl:'XT_LOGPROVIDERNAME',prop:'Title'},{av:'edtXT_LogTarget_Titleformat',ctrl:'XT_LOGTARGET',prop:'Titleformat'},{av:'edtXT_LogTarget_Title',ctrl:'XT_LOGTARGET',prop:'Title'},{av:'edtXT_LogSonTarget_Titleformat',ctrl:'XT_LOGSONTARGET',prop:'Titleformat'},{av:'edtXT_LogSonTarget_Title',ctrl:'XT_LOGSONTARGET',prop:'Title'},{av:'edtXT_LogTargetModule_Titleformat',ctrl:'XT_LOGTARGETMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetModule_Title',ctrl:'XT_LOGTARGETMODULE',prop:'Title'},{av:'edtXT_LogTargetSonModule_Titleformat',ctrl:'XT_LOGTARGETSONMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetSonModule_Title',ctrl:'XT_LOGTARGETSONMODULE',prop:'Title'},{av:'cmbXT_LogTargetOperate'},{av:'edtXT_LogDescription_Titleformat',ctrl:'XT_LOGDESCRIPTION',prop:'Titleformat'},{av:'edtXT_LogDescription_Title',ctrl:'XT_LOGDESCRIPTION',prop:'Title'},{av:'AV45GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV46GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV47GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_XT_LOGSECUSERNAME.ONOPTIONCLICKED","{handler:'E154H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_LogIDTitleControlIdToReplace',fld:'vDDO_XT_LOGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_LogUserIDTitleControlIdToReplace',fld:'vDDO_XT_LOGUSERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_LogSecUserNameTitleControlIdToReplace',fld:'vDDO_XT_LOGSECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_LogTimeTitleControlIdToReplace',fld:'vDDO_XT_LOGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_XT_LogPageTitleControlIdToReplace',fld:'vDDO_XT_LOGPAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_XT_LogButtonNameTitleControlIdToReplace',fld:'vDDO_XT_LOGBUTTONNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_XT_LogTypeTitleControlIdToReplace',fld:'vDDO_XT_LOGTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_XT_LogProviderIDTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_XT_LogProviderNameTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_XT_LogTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_XT_LogSonTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGSONTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_XT_LogTargetModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETSONMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_XT_LogTargetOperateTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETOPERATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_XT_LogDescriptionTitleControlIdToReplace',fld:'vDDO_XT_LOGDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_xt_logsecusername_Activeeventkey',ctrl:'DDO_XT_LOGSECUSERNAME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_LOGSECUSERNAME.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_logsecusername_Sortedstatus',ctrl:'DDO_XT_LOGSECUSERNAME',prop:'SortedStatus'},{av:'AV13XT_LogIDTitleFilterData',fld:'vXT_LOGIDTITLEFILTERDATA',pic:''},{av:'AV15XT_LogUserIDTitleFilterData',fld:'vXT_LOGUSERIDTITLEFILTERDATA',pic:''},{av:'AV17XT_LogSecUserNameTitleFilterData',fld:'vXT_LOGSECUSERNAMETITLEFILTERDATA',pic:''},{av:'AV19XT_LogTimeTitleFilterData',fld:'vXT_LOGTIMETITLEFILTERDATA',pic:''},{av:'AV21XT_LogPageTitleFilterData',fld:'vXT_LOGPAGETITLEFILTERDATA',pic:''},{av:'AV23XT_LogButtonNameTitleFilterData',fld:'vXT_LOGBUTTONNAMETITLEFILTERDATA',pic:''},{av:'AV25XT_LogTypeTitleFilterData',fld:'vXT_LOGTYPETITLEFILTERDATA',pic:''},{av:'AV27XT_LogProviderIDTitleFilterData',fld:'vXT_LOGPROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV29XT_LogProviderNameTitleFilterData',fld:'vXT_LOGPROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV31XT_LogTargetTitleFilterData',fld:'vXT_LOGTARGETTITLEFILTERDATA',pic:''},{av:'AV33XT_LogSonTargetTitleFilterData',fld:'vXT_LOGSONTARGETTITLEFILTERDATA',pic:''},{av:'AV35XT_LogTargetModuleTitleFilterData',fld:'vXT_LOGTARGETMODULETITLEFILTERDATA',pic:''},{av:'AV37XT_LogTargetSonModuleTitleFilterData',fld:'vXT_LOGTARGETSONMODULETITLEFILTERDATA',pic:''},{av:'AV39XT_LogTargetOperateTitleFilterData',fld:'vXT_LOGTARGETOPERATETITLEFILTERDATA',pic:''},{av:'AV41XT_LogDescriptionTitleFilterData',fld:'vXT_LOGDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtXT_LogID_Titleformat',ctrl:'XT_LOGID',prop:'Titleformat'},{av:'edtXT_LogID_Title',ctrl:'XT_LOGID',prop:'Title'},{av:'edtXT_LogUserID_Titleformat',ctrl:'XT_LOGUSERID',prop:'Titleformat'},{av:'edtXT_LogUserID_Title',ctrl:'XT_LOGUSERID',prop:'Title'},{av:'edtXT_LogSecUserName_Titleformat',ctrl:'XT_LOGSECUSERNAME',prop:'Titleformat'},{av:'edtXT_LogSecUserName_Title',ctrl:'XT_LOGSECUSERNAME',prop:'Title'},{av:'edtXT_LogTime_Titleformat',ctrl:'XT_LOGTIME',prop:'Titleformat'},{av:'edtXT_LogTime_Title',ctrl:'XT_LOGTIME',prop:'Title'},{av:'cmbXT_LogPage'},{av:'edtXT_LogButtonName_Titleformat',ctrl:'XT_LOGBUTTONNAME',prop:'Titleformat'},{av:'edtXT_LogButtonName_Title',ctrl:'XT_LOGBUTTONNAME',prop:'Title'},{av:'edtXT_LogType_Titleformat',ctrl:'XT_LOGTYPE',prop:'Titleformat'},{av:'edtXT_LogType_Title',ctrl:'XT_LOGTYPE',prop:'Title'},{av:'edtXT_LogProviderID_Titleformat',ctrl:'XT_LOGPROVIDERID',prop:'Titleformat'},{av:'edtXT_LogProviderID_Title',ctrl:'XT_LOGPROVIDERID',prop:'Title'},{av:'edtXT_LogProviderName_Titleformat',ctrl:'XT_LOGPROVIDERNAME',prop:'Titleformat'},{av:'edtXT_LogProviderName_Title',ctrl:'XT_LOGPROVIDERNAME',prop:'Title'},{av:'edtXT_LogTarget_Titleformat',ctrl:'XT_LOGTARGET',prop:'Titleformat'},{av:'edtXT_LogTarget_Title',ctrl:'XT_LOGTARGET',prop:'Title'},{av:'edtXT_LogSonTarget_Titleformat',ctrl:'XT_LOGSONTARGET',prop:'Titleformat'},{av:'edtXT_LogSonTarget_Title',ctrl:'XT_LOGSONTARGET',prop:'Title'},{av:'edtXT_LogTargetModule_Titleformat',ctrl:'XT_LOGTARGETMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetModule_Title',ctrl:'XT_LOGTARGETMODULE',prop:'Title'},{av:'edtXT_LogTargetSonModule_Titleformat',ctrl:'XT_LOGTARGETSONMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetSonModule_Title',ctrl:'XT_LOGTARGETSONMODULE',prop:'Title'},{av:'cmbXT_LogTargetOperate'},{av:'edtXT_LogDescription_Titleformat',ctrl:'XT_LOGDESCRIPTION',prop:'Titleformat'},{av:'edtXT_LogDescription_Title',ctrl:'XT_LOGDESCRIPTION',prop:'Title'},{av:'AV45GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV46GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV47GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_XT_LOGTIME.ONOPTIONCLICKED","{handler:'E164H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_LogIDTitleControlIdToReplace',fld:'vDDO_XT_LOGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_LogUserIDTitleControlIdToReplace',fld:'vDDO_XT_LOGUSERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_LogSecUserNameTitleControlIdToReplace',fld:'vDDO_XT_LOGSECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_LogTimeTitleControlIdToReplace',fld:'vDDO_XT_LOGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_XT_LogPageTitleControlIdToReplace',fld:'vDDO_XT_LOGPAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_XT_LogButtonNameTitleControlIdToReplace',fld:'vDDO_XT_LOGBUTTONNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_XT_LogTypeTitleControlIdToReplace',fld:'vDDO_XT_LOGTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_XT_LogProviderIDTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_XT_LogProviderNameTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_XT_LogTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_XT_LogSonTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGSONTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_XT_LogTargetModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETSONMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_XT_LogTargetOperateTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETOPERATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_XT_LogDescriptionTitleControlIdToReplace',fld:'vDDO_XT_LOGDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_xt_logtime_Activeeventkey',ctrl:'DDO_XT_LOGTIME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_LOGTIME.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_logtime_Sortedstatus',ctrl:'DDO_XT_LOGTIME',prop:'SortedStatus'},{av:'AV13XT_LogIDTitleFilterData',fld:'vXT_LOGIDTITLEFILTERDATA',pic:''},{av:'AV15XT_LogUserIDTitleFilterData',fld:'vXT_LOGUSERIDTITLEFILTERDATA',pic:''},{av:'AV17XT_LogSecUserNameTitleFilterData',fld:'vXT_LOGSECUSERNAMETITLEFILTERDATA',pic:''},{av:'AV19XT_LogTimeTitleFilterData',fld:'vXT_LOGTIMETITLEFILTERDATA',pic:''},{av:'AV21XT_LogPageTitleFilterData',fld:'vXT_LOGPAGETITLEFILTERDATA',pic:''},{av:'AV23XT_LogButtonNameTitleFilterData',fld:'vXT_LOGBUTTONNAMETITLEFILTERDATA',pic:''},{av:'AV25XT_LogTypeTitleFilterData',fld:'vXT_LOGTYPETITLEFILTERDATA',pic:''},{av:'AV27XT_LogProviderIDTitleFilterData',fld:'vXT_LOGPROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV29XT_LogProviderNameTitleFilterData',fld:'vXT_LOGPROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV31XT_LogTargetTitleFilterData',fld:'vXT_LOGTARGETTITLEFILTERDATA',pic:''},{av:'AV33XT_LogSonTargetTitleFilterData',fld:'vXT_LOGSONTARGETTITLEFILTERDATA',pic:''},{av:'AV35XT_LogTargetModuleTitleFilterData',fld:'vXT_LOGTARGETMODULETITLEFILTERDATA',pic:''},{av:'AV37XT_LogTargetSonModuleTitleFilterData',fld:'vXT_LOGTARGETSONMODULETITLEFILTERDATA',pic:''},{av:'AV39XT_LogTargetOperateTitleFilterData',fld:'vXT_LOGTARGETOPERATETITLEFILTERDATA',pic:''},{av:'AV41XT_LogDescriptionTitleFilterData',fld:'vXT_LOGDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtXT_LogID_Titleformat',ctrl:'XT_LOGID',prop:'Titleformat'},{av:'edtXT_LogID_Title',ctrl:'XT_LOGID',prop:'Title'},{av:'edtXT_LogUserID_Titleformat',ctrl:'XT_LOGUSERID',prop:'Titleformat'},{av:'edtXT_LogUserID_Title',ctrl:'XT_LOGUSERID',prop:'Title'},{av:'edtXT_LogSecUserName_Titleformat',ctrl:'XT_LOGSECUSERNAME',prop:'Titleformat'},{av:'edtXT_LogSecUserName_Title',ctrl:'XT_LOGSECUSERNAME',prop:'Title'},{av:'edtXT_LogTime_Titleformat',ctrl:'XT_LOGTIME',prop:'Titleformat'},{av:'edtXT_LogTime_Title',ctrl:'XT_LOGTIME',prop:'Title'},{av:'cmbXT_LogPage'},{av:'edtXT_LogButtonName_Titleformat',ctrl:'XT_LOGBUTTONNAME',prop:'Titleformat'},{av:'edtXT_LogButtonName_Title',ctrl:'XT_LOGBUTTONNAME',prop:'Title'},{av:'edtXT_LogType_Titleformat',ctrl:'XT_LOGTYPE',prop:'Titleformat'},{av:'edtXT_LogType_Title',ctrl:'XT_LOGTYPE',prop:'Title'},{av:'edtXT_LogProviderID_Titleformat',ctrl:'XT_LOGPROVIDERID',prop:'Titleformat'},{av:'edtXT_LogProviderID_Title',ctrl:'XT_LOGPROVIDERID',prop:'Title'},{av:'edtXT_LogProviderName_Titleformat',ctrl:'XT_LOGPROVIDERNAME',prop:'Titleformat'},{av:'edtXT_LogProviderName_Title',ctrl:'XT_LOGPROVIDERNAME',prop:'Title'},{av:'edtXT_LogTarget_Titleformat',ctrl:'XT_LOGTARGET',prop:'Titleformat'},{av:'edtXT_LogTarget_Title',ctrl:'XT_LOGTARGET',prop:'Title'},{av:'edtXT_LogSonTarget_Titleformat',ctrl:'XT_LOGSONTARGET',prop:'Titleformat'},{av:'edtXT_LogSonTarget_Title',ctrl:'XT_LOGSONTARGET',prop:'Title'},{av:'edtXT_LogTargetModule_Titleformat',ctrl:'XT_LOGTARGETMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetModule_Title',ctrl:'XT_LOGTARGETMODULE',prop:'Title'},{av:'edtXT_LogTargetSonModule_Titleformat',ctrl:'XT_LOGTARGETSONMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetSonModule_Title',ctrl:'XT_LOGTARGETSONMODULE',prop:'Title'},{av:'cmbXT_LogTargetOperate'},{av:'edtXT_LogDescription_Titleformat',ctrl:'XT_LOGDESCRIPTION',prop:'Titleformat'},{av:'edtXT_LogDescription_Title',ctrl:'XT_LOGDESCRIPTION',prop:'Title'},{av:'AV45GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV46GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV47GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_XT_LOGPAGE.ONOPTIONCLICKED","{handler:'E174H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_LogIDTitleControlIdToReplace',fld:'vDDO_XT_LOGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_LogUserIDTitleControlIdToReplace',fld:'vDDO_XT_LOGUSERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_LogSecUserNameTitleControlIdToReplace',fld:'vDDO_XT_LOGSECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_LogTimeTitleControlIdToReplace',fld:'vDDO_XT_LOGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_XT_LogPageTitleControlIdToReplace',fld:'vDDO_XT_LOGPAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_XT_LogButtonNameTitleControlIdToReplace',fld:'vDDO_XT_LOGBUTTONNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_XT_LogTypeTitleControlIdToReplace',fld:'vDDO_XT_LOGTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_XT_LogProviderIDTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_XT_LogProviderNameTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_XT_LogTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_XT_LogSonTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGSONTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_XT_LogTargetModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETSONMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_XT_LogTargetOperateTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETOPERATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_XT_LogDescriptionTitleControlIdToReplace',fld:'vDDO_XT_LOGDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_xt_logpage_Activeeventkey',ctrl:'DDO_XT_LOGPAGE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_LOGPAGE.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_logpage_Sortedstatus',ctrl:'DDO_XT_LOGPAGE',prop:'SortedStatus'},{av:'AV13XT_LogIDTitleFilterData',fld:'vXT_LOGIDTITLEFILTERDATA',pic:''},{av:'AV15XT_LogUserIDTitleFilterData',fld:'vXT_LOGUSERIDTITLEFILTERDATA',pic:''},{av:'AV17XT_LogSecUserNameTitleFilterData',fld:'vXT_LOGSECUSERNAMETITLEFILTERDATA',pic:''},{av:'AV19XT_LogTimeTitleFilterData',fld:'vXT_LOGTIMETITLEFILTERDATA',pic:''},{av:'AV21XT_LogPageTitleFilterData',fld:'vXT_LOGPAGETITLEFILTERDATA',pic:''},{av:'AV23XT_LogButtonNameTitleFilterData',fld:'vXT_LOGBUTTONNAMETITLEFILTERDATA',pic:''},{av:'AV25XT_LogTypeTitleFilterData',fld:'vXT_LOGTYPETITLEFILTERDATA',pic:''},{av:'AV27XT_LogProviderIDTitleFilterData',fld:'vXT_LOGPROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV29XT_LogProviderNameTitleFilterData',fld:'vXT_LOGPROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV31XT_LogTargetTitleFilterData',fld:'vXT_LOGTARGETTITLEFILTERDATA',pic:''},{av:'AV33XT_LogSonTargetTitleFilterData',fld:'vXT_LOGSONTARGETTITLEFILTERDATA',pic:''},{av:'AV35XT_LogTargetModuleTitleFilterData',fld:'vXT_LOGTARGETMODULETITLEFILTERDATA',pic:''},{av:'AV37XT_LogTargetSonModuleTitleFilterData',fld:'vXT_LOGTARGETSONMODULETITLEFILTERDATA',pic:''},{av:'AV39XT_LogTargetOperateTitleFilterData',fld:'vXT_LOGTARGETOPERATETITLEFILTERDATA',pic:''},{av:'AV41XT_LogDescriptionTitleFilterData',fld:'vXT_LOGDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtXT_LogID_Titleformat',ctrl:'XT_LOGID',prop:'Titleformat'},{av:'edtXT_LogID_Title',ctrl:'XT_LOGID',prop:'Title'},{av:'edtXT_LogUserID_Titleformat',ctrl:'XT_LOGUSERID',prop:'Titleformat'},{av:'edtXT_LogUserID_Title',ctrl:'XT_LOGUSERID',prop:'Title'},{av:'edtXT_LogSecUserName_Titleformat',ctrl:'XT_LOGSECUSERNAME',prop:'Titleformat'},{av:'edtXT_LogSecUserName_Title',ctrl:'XT_LOGSECUSERNAME',prop:'Title'},{av:'edtXT_LogTime_Titleformat',ctrl:'XT_LOGTIME',prop:'Titleformat'},{av:'edtXT_LogTime_Title',ctrl:'XT_LOGTIME',prop:'Title'},{av:'cmbXT_LogPage'},{av:'edtXT_LogButtonName_Titleformat',ctrl:'XT_LOGBUTTONNAME',prop:'Titleformat'},{av:'edtXT_LogButtonName_Title',ctrl:'XT_LOGBUTTONNAME',prop:'Title'},{av:'edtXT_LogType_Titleformat',ctrl:'XT_LOGTYPE',prop:'Titleformat'},{av:'edtXT_LogType_Title',ctrl:'XT_LOGTYPE',prop:'Title'},{av:'edtXT_LogProviderID_Titleformat',ctrl:'XT_LOGPROVIDERID',prop:'Titleformat'},{av:'edtXT_LogProviderID_Title',ctrl:'XT_LOGPROVIDERID',prop:'Title'},{av:'edtXT_LogProviderName_Titleformat',ctrl:'XT_LOGPROVIDERNAME',prop:'Titleformat'},{av:'edtXT_LogProviderName_Title',ctrl:'XT_LOGPROVIDERNAME',prop:'Title'},{av:'edtXT_LogTarget_Titleformat',ctrl:'XT_LOGTARGET',prop:'Titleformat'},{av:'edtXT_LogTarget_Title',ctrl:'XT_LOGTARGET',prop:'Title'},{av:'edtXT_LogSonTarget_Titleformat',ctrl:'XT_LOGSONTARGET',prop:'Titleformat'},{av:'edtXT_LogSonTarget_Title',ctrl:'XT_LOGSONTARGET',prop:'Title'},{av:'edtXT_LogTargetModule_Titleformat',ctrl:'XT_LOGTARGETMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetModule_Title',ctrl:'XT_LOGTARGETMODULE',prop:'Title'},{av:'edtXT_LogTargetSonModule_Titleformat',ctrl:'XT_LOGTARGETSONMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetSonModule_Title',ctrl:'XT_LOGTARGETSONMODULE',prop:'Title'},{av:'cmbXT_LogTargetOperate'},{av:'edtXT_LogDescription_Titleformat',ctrl:'XT_LOGDESCRIPTION',prop:'Titleformat'},{av:'edtXT_LogDescription_Title',ctrl:'XT_LOGDESCRIPTION',prop:'Title'},{av:'AV45GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV46GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV47GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_XT_LOGBUTTONNAME.ONOPTIONCLICKED","{handler:'E184H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_LogIDTitleControlIdToReplace',fld:'vDDO_XT_LOGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_LogUserIDTitleControlIdToReplace',fld:'vDDO_XT_LOGUSERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_LogSecUserNameTitleControlIdToReplace',fld:'vDDO_XT_LOGSECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_LogTimeTitleControlIdToReplace',fld:'vDDO_XT_LOGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_XT_LogPageTitleControlIdToReplace',fld:'vDDO_XT_LOGPAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_XT_LogButtonNameTitleControlIdToReplace',fld:'vDDO_XT_LOGBUTTONNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_XT_LogTypeTitleControlIdToReplace',fld:'vDDO_XT_LOGTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_XT_LogProviderIDTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_XT_LogProviderNameTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_XT_LogTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_XT_LogSonTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGSONTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_XT_LogTargetModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETSONMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_XT_LogTargetOperateTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETOPERATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_XT_LogDescriptionTitleControlIdToReplace',fld:'vDDO_XT_LOGDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_xt_logbuttonname_Activeeventkey',ctrl:'DDO_XT_LOGBUTTONNAME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_LOGBUTTONNAME.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_logbuttonname_Sortedstatus',ctrl:'DDO_XT_LOGBUTTONNAME',prop:'SortedStatus'},{av:'AV13XT_LogIDTitleFilterData',fld:'vXT_LOGIDTITLEFILTERDATA',pic:''},{av:'AV15XT_LogUserIDTitleFilterData',fld:'vXT_LOGUSERIDTITLEFILTERDATA',pic:''},{av:'AV17XT_LogSecUserNameTitleFilterData',fld:'vXT_LOGSECUSERNAMETITLEFILTERDATA',pic:''},{av:'AV19XT_LogTimeTitleFilterData',fld:'vXT_LOGTIMETITLEFILTERDATA',pic:''},{av:'AV21XT_LogPageTitleFilterData',fld:'vXT_LOGPAGETITLEFILTERDATA',pic:''},{av:'AV23XT_LogButtonNameTitleFilterData',fld:'vXT_LOGBUTTONNAMETITLEFILTERDATA',pic:''},{av:'AV25XT_LogTypeTitleFilterData',fld:'vXT_LOGTYPETITLEFILTERDATA',pic:''},{av:'AV27XT_LogProviderIDTitleFilterData',fld:'vXT_LOGPROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV29XT_LogProviderNameTitleFilterData',fld:'vXT_LOGPROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV31XT_LogTargetTitleFilterData',fld:'vXT_LOGTARGETTITLEFILTERDATA',pic:''},{av:'AV33XT_LogSonTargetTitleFilterData',fld:'vXT_LOGSONTARGETTITLEFILTERDATA',pic:''},{av:'AV35XT_LogTargetModuleTitleFilterData',fld:'vXT_LOGTARGETMODULETITLEFILTERDATA',pic:''},{av:'AV37XT_LogTargetSonModuleTitleFilterData',fld:'vXT_LOGTARGETSONMODULETITLEFILTERDATA',pic:''},{av:'AV39XT_LogTargetOperateTitleFilterData',fld:'vXT_LOGTARGETOPERATETITLEFILTERDATA',pic:''},{av:'AV41XT_LogDescriptionTitleFilterData',fld:'vXT_LOGDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtXT_LogID_Titleformat',ctrl:'XT_LOGID',prop:'Titleformat'},{av:'edtXT_LogID_Title',ctrl:'XT_LOGID',prop:'Title'},{av:'edtXT_LogUserID_Titleformat',ctrl:'XT_LOGUSERID',prop:'Titleformat'},{av:'edtXT_LogUserID_Title',ctrl:'XT_LOGUSERID',prop:'Title'},{av:'edtXT_LogSecUserName_Titleformat',ctrl:'XT_LOGSECUSERNAME',prop:'Titleformat'},{av:'edtXT_LogSecUserName_Title',ctrl:'XT_LOGSECUSERNAME',prop:'Title'},{av:'edtXT_LogTime_Titleformat',ctrl:'XT_LOGTIME',prop:'Titleformat'},{av:'edtXT_LogTime_Title',ctrl:'XT_LOGTIME',prop:'Title'},{av:'cmbXT_LogPage'},{av:'edtXT_LogButtonName_Titleformat',ctrl:'XT_LOGBUTTONNAME',prop:'Titleformat'},{av:'edtXT_LogButtonName_Title',ctrl:'XT_LOGBUTTONNAME',prop:'Title'},{av:'edtXT_LogType_Titleformat',ctrl:'XT_LOGTYPE',prop:'Titleformat'},{av:'edtXT_LogType_Title',ctrl:'XT_LOGTYPE',prop:'Title'},{av:'edtXT_LogProviderID_Titleformat',ctrl:'XT_LOGPROVIDERID',prop:'Titleformat'},{av:'edtXT_LogProviderID_Title',ctrl:'XT_LOGPROVIDERID',prop:'Title'},{av:'edtXT_LogProviderName_Titleformat',ctrl:'XT_LOGPROVIDERNAME',prop:'Titleformat'},{av:'edtXT_LogProviderName_Title',ctrl:'XT_LOGPROVIDERNAME',prop:'Title'},{av:'edtXT_LogTarget_Titleformat',ctrl:'XT_LOGTARGET',prop:'Titleformat'},{av:'edtXT_LogTarget_Title',ctrl:'XT_LOGTARGET',prop:'Title'},{av:'edtXT_LogSonTarget_Titleformat',ctrl:'XT_LOGSONTARGET',prop:'Titleformat'},{av:'edtXT_LogSonTarget_Title',ctrl:'XT_LOGSONTARGET',prop:'Title'},{av:'edtXT_LogTargetModule_Titleformat',ctrl:'XT_LOGTARGETMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetModule_Title',ctrl:'XT_LOGTARGETMODULE',prop:'Title'},{av:'edtXT_LogTargetSonModule_Titleformat',ctrl:'XT_LOGTARGETSONMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetSonModule_Title',ctrl:'XT_LOGTARGETSONMODULE',prop:'Title'},{av:'cmbXT_LogTargetOperate'},{av:'edtXT_LogDescription_Titleformat',ctrl:'XT_LOGDESCRIPTION',prop:'Titleformat'},{av:'edtXT_LogDescription_Title',ctrl:'XT_LOGDESCRIPTION',prop:'Title'},{av:'AV45GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV46GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV47GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_XT_LOGTYPE.ONOPTIONCLICKED","{handler:'E194H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_LogIDTitleControlIdToReplace',fld:'vDDO_XT_LOGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_LogUserIDTitleControlIdToReplace',fld:'vDDO_XT_LOGUSERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_LogSecUserNameTitleControlIdToReplace',fld:'vDDO_XT_LOGSECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_LogTimeTitleControlIdToReplace',fld:'vDDO_XT_LOGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_XT_LogPageTitleControlIdToReplace',fld:'vDDO_XT_LOGPAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_XT_LogButtonNameTitleControlIdToReplace',fld:'vDDO_XT_LOGBUTTONNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_XT_LogTypeTitleControlIdToReplace',fld:'vDDO_XT_LOGTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_XT_LogProviderIDTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_XT_LogProviderNameTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_XT_LogTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_XT_LogSonTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGSONTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_XT_LogTargetModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETSONMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_XT_LogTargetOperateTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETOPERATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_XT_LogDescriptionTitleControlIdToReplace',fld:'vDDO_XT_LOGDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_xt_logtype_Activeeventkey',ctrl:'DDO_XT_LOGTYPE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_LOGTYPE.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_logtype_Sortedstatus',ctrl:'DDO_XT_LOGTYPE',prop:'SortedStatus'},{av:'AV13XT_LogIDTitleFilterData',fld:'vXT_LOGIDTITLEFILTERDATA',pic:''},{av:'AV15XT_LogUserIDTitleFilterData',fld:'vXT_LOGUSERIDTITLEFILTERDATA',pic:''},{av:'AV17XT_LogSecUserNameTitleFilterData',fld:'vXT_LOGSECUSERNAMETITLEFILTERDATA',pic:''},{av:'AV19XT_LogTimeTitleFilterData',fld:'vXT_LOGTIMETITLEFILTERDATA',pic:''},{av:'AV21XT_LogPageTitleFilterData',fld:'vXT_LOGPAGETITLEFILTERDATA',pic:''},{av:'AV23XT_LogButtonNameTitleFilterData',fld:'vXT_LOGBUTTONNAMETITLEFILTERDATA',pic:''},{av:'AV25XT_LogTypeTitleFilterData',fld:'vXT_LOGTYPETITLEFILTERDATA',pic:''},{av:'AV27XT_LogProviderIDTitleFilterData',fld:'vXT_LOGPROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV29XT_LogProviderNameTitleFilterData',fld:'vXT_LOGPROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV31XT_LogTargetTitleFilterData',fld:'vXT_LOGTARGETTITLEFILTERDATA',pic:''},{av:'AV33XT_LogSonTargetTitleFilterData',fld:'vXT_LOGSONTARGETTITLEFILTERDATA',pic:''},{av:'AV35XT_LogTargetModuleTitleFilterData',fld:'vXT_LOGTARGETMODULETITLEFILTERDATA',pic:''},{av:'AV37XT_LogTargetSonModuleTitleFilterData',fld:'vXT_LOGTARGETSONMODULETITLEFILTERDATA',pic:''},{av:'AV39XT_LogTargetOperateTitleFilterData',fld:'vXT_LOGTARGETOPERATETITLEFILTERDATA',pic:''},{av:'AV41XT_LogDescriptionTitleFilterData',fld:'vXT_LOGDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtXT_LogID_Titleformat',ctrl:'XT_LOGID',prop:'Titleformat'},{av:'edtXT_LogID_Title',ctrl:'XT_LOGID',prop:'Title'},{av:'edtXT_LogUserID_Titleformat',ctrl:'XT_LOGUSERID',prop:'Titleformat'},{av:'edtXT_LogUserID_Title',ctrl:'XT_LOGUSERID',prop:'Title'},{av:'edtXT_LogSecUserName_Titleformat',ctrl:'XT_LOGSECUSERNAME',prop:'Titleformat'},{av:'edtXT_LogSecUserName_Title',ctrl:'XT_LOGSECUSERNAME',prop:'Title'},{av:'edtXT_LogTime_Titleformat',ctrl:'XT_LOGTIME',prop:'Titleformat'},{av:'edtXT_LogTime_Title',ctrl:'XT_LOGTIME',prop:'Title'},{av:'cmbXT_LogPage'},{av:'edtXT_LogButtonName_Titleformat',ctrl:'XT_LOGBUTTONNAME',prop:'Titleformat'},{av:'edtXT_LogButtonName_Title',ctrl:'XT_LOGBUTTONNAME',prop:'Title'},{av:'edtXT_LogType_Titleformat',ctrl:'XT_LOGTYPE',prop:'Titleformat'},{av:'edtXT_LogType_Title',ctrl:'XT_LOGTYPE',prop:'Title'},{av:'edtXT_LogProviderID_Titleformat',ctrl:'XT_LOGPROVIDERID',prop:'Titleformat'},{av:'edtXT_LogProviderID_Title',ctrl:'XT_LOGPROVIDERID',prop:'Title'},{av:'edtXT_LogProviderName_Titleformat',ctrl:'XT_LOGPROVIDERNAME',prop:'Titleformat'},{av:'edtXT_LogProviderName_Title',ctrl:'XT_LOGPROVIDERNAME',prop:'Title'},{av:'edtXT_LogTarget_Titleformat',ctrl:'XT_LOGTARGET',prop:'Titleformat'},{av:'edtXT_LogTarget_Title',ctrl:'XT_LOGTARGET',prop:'Title'},{av:'edtXT_LogSonTarget_Titleformat',ctrl:'XT_LOGSONTARGET',prop:'Titleformat'},{av:'edtXT_LogSonTarget_Title',ctrl:'XT_LOGSONTARGET',prop:'Title'},{av:'edtXT_LogTargetModule_Titleformat',ctrl:'XT_LOGTARGETMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetModule_Title',ctrl:'XT_LOGTARGETMODULE',prop:'Title'},{av:'edtXT_LogTargetSonModule_Titleformat',ctrl:'XT_LOGTARGETSONMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetSonModule_Title',ctrl:'XT_LOGTARGETSONMODULE',prop:'Title'},{av:'cmbXT_LogTargetOperate'},{av:'edtXT_LogDescription_Titleformat',ctrl:'XT_LOGDESCRIPTION',prop:'Titleformat'},{av:'edtXT_LogDescription_Title',ctrl:'XT_LOGDESCRIPTION',prop:'Title'},{av:'AV45GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV46GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV47GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_XT_LOGPROVIDERID.ONOPTIONCLICKED","{handler:'E204H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_LogIDTitleControlIdToReplace',fld:'vDDO_XT_LOGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_LogUserIDTitleControlIdToReplace',fld:'vDDO_XT_LOGUSERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_LogSecUserNameTitleControlIdToReplace',fld:'vDDO_XT_LOGSECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_LogTimeTitleControlIdToReplace',fld:'vDDO_XT_LOGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_XT_LogPageTitleControlIdToReplace',fld:'vDDO_XT_LOGPAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_XT_LogButtonNameTitleControlIdToReplace',fld:'vDDO_XT_LOGBUTTONNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_XT_LogTypeTitleControlIdToReplace',fld:'vDDO_XT_LOGTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_XT_LogProviderIDTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_XT_LogProviderNameTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_XT_LogTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_XT_LogSonTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGSONTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_XT_LogTargetModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETSONMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_XT_LogTargetOperateTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETOPERATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_XT_LogDescriptionTitleControlIdToReplace',fld:'vDDO_XT_LOGDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_xt_logproviderid_Activeeventkey',ctrl:'DDO_XT_LOGPROVIDERID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_LOGPROVIDERID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_logproviderid_Sortedstatus',ctrl:'DDO_XT_LOGPROVIDERID',prop:'SortedStatus'},{av:'AV13XT_LogIDTitleFilterData',fld:'vXT_LOGIDTITLEFILTERDATA',pic:''},{av:'AV15XT_LogUserIDTitleFilterData',fld:'vXT_LOGUSERIDTITLEFILTERDATA',pic:''},{av:'AV17XT_LogSecUserNameTitleFilterData',fld:'vXT_LOGSECUSERNAMETITLEFILTERDATA',pic:''},{av:'AV19XT_LogTimeTitleFilterData',fld:'vXT_LOGTIMETITLEFILTERDATA',pic:''},{av:'AV21XT_LogPageTitleFilterData',fld:'vXT_LOGPAGETITLEFILTERDATA',pic:''},{av:'AV23XT_LogButtonNameTitleFilterData',fld:'vXT_LOGBUTTONNAMETITLEFILTERDATA',pic:''},{av:'AV25XT_LogTypeTitleFilterData',fld:'vXT_LOGTYPETITLEFILTERDATA',pic:''},{av:'AV27XT_LogProviderIDTitleFilterData',fld:'vXT_LOGPROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV29XT_LogProviderNameTitleFilterData',fld:'vXT_LOGPROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV31XT_LogTargetTitleFilterData',fld:'vXT_LOGTARGETTITLEFILTERDATA',pic:''},{av:'AV33XT_LogSonTargetTitleFilterData',fld:'vXT_LOGSONTARGETTITLEFILTERDATA',pic:''},{av:'AV35XT_LogTargetModuleTitleFilterData',fld:'vXT_LOGTARGETMODULETITLEFILTERDATA',pic:''},{av:'AV37XT_LogTargetSonModuleTitleFilterData',fld:'vXT_LOGTARGETSONMODULETITLEFILTERDATA',pic:''},{av:'AV39XT_LogTargetOperateTitleFilterData',fld:'vXT_LOGTARGETOPERATETITLEFILTERDATA',pic:''},{av:'AV41XT_LogDescriptionTitleFilterData',fld:'vXT_LOGDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtXT_LogID_Titleformat',ctrl:'XT_LOGID',prop:'Titleformat'},{av:'edtXT_LogID_Title',ctrl:'XT_LOGID',prop:'Title'},{av:'edtXT_LogUserID_Titleformat',ctrl:'XT_LOGUSERID',prop:'Titleformat'},{av:'edtXT_LogUserID_Title',ctrl:'XT_LOGUSERID',prop:'Title'},{av:'edtXT_LogSecUserName_Titleformat',ctrl:'XT_LOGSECUSERNAME',prop:'Titleformat'},{av:'edtXT_LogSecUserName_Title',ctrl:'XT_LOGSECUSERNAME',prop:'Title'},{av:'edtXT_LogTime_Titleformat',ctrl:'XT_LOGTIME',prop:'Titleformat'},{av:'edtXT_LogTime_Title',ctrl:'XT_LOGTIME',prop:'Title'},{av:'cmbXT_LogPage'},{av:'edtXT_LogButtonName_Titleformat',ctrl:'XT_LOGBUTTONNAME',prop:'Titleformat'},{av:'edtXT_LogButtonName_Title',ctrl:'XT_LOGBUTTONNAME',prop:'Title'},{av:'edtXT_LogType_Titleformat',ctrl:'XT_LOGTYPE',prop:'Titleformat'},{av:'edtXT_LogType_Title',ctrl:'XT_LOGTYPE',prop:'Title'},{av:'edtXT_LogProviderID_Titleformat',ctrl:'XT_LOGPROVIDERID',prop:'Titleformat'},{av:'edtXT_LogProviderID_Title',ctrl:'XT_LOGPROVIDERID',prop:'Title'},{av:'edtXT_LogProviderName_Titleformat',ctrl:'XT_LOGPROVIDERNAME',prop:'Titleformat'},{av:'edtXT_LogProviderName_Title',ctrl:'XT_LOGPROVIDERNAME',prop:'Title'},{av:'edtXT_LogTarget_Titleformat',ctrl:'XT_LOGTARGET',prop:'Titleformat'},{av:'edtXT_LogTarget_Title',ctrl:'XT_LOGTARGET',prop:'Title'},{av:'edtXT_LogSonTarget_Titleformat',ctrl:'XT_LOGSONTARGET',prop:'Titleformat'},{av:'edtXT_LogSonTarget_Title',ctrl:'XT_LOGSONTARGET',prop:'Title'},{av:'edtXT_LogTargetModule_Titleformat',ctrl:'XT_LOGTARGETMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetModule_Title',ctrl:'XT_LOGTARGETMODULE',prop:'Title'},{av:'edtXT_LogTargetSonModule_Titleformat',ctrl:'XT_LOGTARGETSONMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetSonModule_Title',ctrl:'XT_LOGTARGETSONMODULE',prop:'Title'},{av:'cmbXT_LogTargetOperate'},{av:'edtXT_LogDescription_Titleformat',ctrl:'XT_LOGDESCRIPTION',prop:'Titleformat'},{av:'edtXT_LogDescription_Title',ctrl:'XT_LOGDESCRIPTION',prop:'Title'},{av:'AV45GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV46GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV47GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_XT_LOGPROVIDERNAME.ONOPTIONCLICKED","{handler:'E214H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_LogIDTitleControlIdToReplace',fld:'vDDO_XT_LOGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_LogUserIDTitleControlIdToReplace',fld:'vDDO_XT_LOGUSERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_LogSecUserNameTitleControlIdToReplace',fld:'vDDO_XT_LOGSECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_LogTimeTitleControlIdToReplace',fld:'vDDO_XT_LOGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_XT_LogPageTitleControlIdToReplace',fld:'vDDO_XT_LOGPAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_XT_LogButtonNameTitleControlIdToReplace',fld:'vDDO_XT_LOGBUTTONNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_XT_LogTypeTitleControlIdToReplace',fld:'vDDO_XT_LOGTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_XT_LogProviderIDTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_XT_LogProviderNameTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_XT_LogTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_XT_LogSonTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGSONTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_XT_LogTargetModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETSONMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_XT_LogTargetOperateTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETOPERATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_XT_LogDescriptionTitleControlIdToReplace',fld:'vDDO_XT_LOGDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_xt_logprovidername_Activeeventkey',ctrl:'DDO_XT_LOGPROVIDERNAME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_LOGPROVIDERNAME.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_logprovidername_Sortedstatus',ctrl:'DDO_XT_LOGPROVIDERNAME',prop:'SortedStatus'},{av:'AV13XT_LogIDTitleFilterData',fld:'vXT_LOGIDTITLEFILTERDATA',pic:''},{av:'AV15XT_LogUserIDTitleFilterData',fld:'vXT_LOGUSERIDTITLEFILTERDATA',pic:''},{av:'AV17XT_LogSecUserNameTitleFilterData',fld:'vXT_LOGSECUSERNAMETITLEFILTERDATA',pic:''},{av:'AV19XT_LogTimeTitleFilterData',fld:'vXT_LOGTIMETITLEFILTERDATA',pic:''},{av:'AV21XT_LogPageTitleFilterData',fld:'vXT_LOGPAGETITLEFILTERDATA',pic:''},{av:'AV23XT_LogButtonNameTitleFilterData',fld:'vXT_LOGBUTTONNAMETITLEFILTERDATA',pic:''},{av:'AV25XT_LogTypeTitleFilterData',fld:'vXT_LOGTYPETITLEFILTERDATA',pic:''},{av:'AV27XT_LogProviderIDTitleFilterData',fld:'vXT_LOGPROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV29XT_LogProviderNameTitleFilterData',fld:'vXT_LOGPROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV31XT_LogTargetTitleFilterData',fld:'vXT_LOGTARGETTITLEFILTERDATA',pic:''},{av:'AV33XT_LogSonTargetTitleFilterData',fld:'vXT_LOGSONTARGETTITLEFILTERDATA',pic:''},{av:'AV35XT_LogTargetModuleTitleFilterData',fld:'vXT_LOGTARGETMODULETITLEFILTERDATA',pic:''},{av:'AV37XT_LogTargetSonModuleTitleFilterData',fld:'vXT_LOGTARGETSONMODULETITLEFILTERDATA',pic:''},{av:'AV39XT_LogTargetOperateTitleFilterData',fld:'vXT_LOGTARGETOPERATETITLEFILTERDATA',pic:''},{av:'AV41XT_LogDescriptionTitleFilterData',fld:'vXT_LOGDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtXT_LogID_Titleformat',ctrl:'XT_LOGID',prop:'Titleformat'},{av:'edtXT_LogID_Title',ctrl:'XT_LOGID',prop:'Title'},{av:'edtXT_LogUserID_Titleformat',ctrl:'XT_LOGUSERID',prop:'Titleformat'},{av:'edtXT_LogUserID_Title',ctrl:'XT_LOGUSERID',prop:'Title'},{av:'edtXT_LogSecUserName_Titleformat',ctrl:'XT_LOGSECUSERNAME',prop:'Titleformat'},{av:'edtXT_LogSecUserName_Title',ctrl:'XT_LOGSECUSERNAME',prop:'Title'},{av:'edtXT_LogTime_Titleformat',ctrl:'XT_LOGTIME',prop:'Titleformat'},{av:'edtXT_LogTime_Title',ctrl:'XT_LOGTIME',prop:'Title'},{av:'cmbXT_LogPage'},{av:'edtXT_LogButtonName_Titleformat',ctrl:'XT_LOGBUTTONNAME',prop:'Titleformat'},{av:'edtXT_LogButtonName_Title',ctrl:'XT_LOGBUTTONNAME',prop:'Title'},{av:'edtXT_LogType_Titleformat',ctrl:'XT_LOGTYPE',prop:'Titleformat'},{av:'edtXT_LogType_Title',ctrl:'XT_LOGTYPE',prop:'Title'},{av:'edtXT_LogProviderID_Titleformat',ctrl:'XT_LOGPROVIDERID',prop:'Titleformat'},{av:'edtXT_LogProviderID_Title',ctrl:'XT_LOGPROVIDERID',prop:'Title'},{av:'edtXT_LogProviderName_Titleformat',ctrl:'XT_LOGPROVIDERNAME',prop:'Titleformat'},{av:'edtXT_LogProviderName_Title',ctrl:'XT_LOGPROVIDERNAME',prop:'Title'},{av:'edtXT_LogTarget_Titleformat',ctrl:'XT_LOGTARGET',prop:'Titleformat'},{av:'edtXT_LogTarget_Title',ctrl:'XT_LOGTARGET',prop:'Title'},{av:'edtXT_LogSonTarget_Titleformat',ctrl:'XT_LOGSONTARGET',prop:'Titleformat'},{av:'edtXT_LogSonTarget_Title',ctrl:'XT_LOGSONTARGET',prop:'Title'},{av:'edtXT_LogTargetModule_Titleformat',ctrl:'XT_LOGTARGETMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetModule_Title',ctrl:'XT_LOGTARGETMODULE',prop:'Title'},{av:'edtXT_LogTargetSonModule_Titleformat',ctrl:'XT_LOGTARGETSONMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetSonModule_Title',ctrl:'XT_LOGTARGETSONMODULE',prop:'Title'},{av:'cmbXT_LogTargetOperate'},{av:'edtXT_LogDescription_Titleformat',ctrl:'XT_LOGDESCRIPTION',prop:'Titleformat'},{av:'edtXT_LogDescription_Title',ctrl:'XT_LOGDESCRIPTION',prop:'Title'},{av:'AV45GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV46GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV47GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_XT_LOGTARGET.ONOPTIONCLICKED","{handler:'E224H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_LogIDTitleControlIdToReplace',fld:'vDDO_XT_LOGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_LogUserIDTitleControlIdToReplace',fld:'vDDO_XT_LOGUSERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_LogSecUserNameTitleControlIdToReplace',fld:'vDDO_XT_LOGSECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_LogTimeTitleControlIdToReplace',fld:'vDDO_XT_LOGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_XT_LogPageTitleControlIdToReplace',fld:'vDDO_XT_LOGPAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_XT_LogButtonNameTitleControlIdToReplace',fld:'vDDO_XT_LOGBUTTONNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_XT_LogTypeTitleControlIdToReplace',fld:'vDDO_XT_LOGTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_XT_LogProviderIDTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_XT_LogProviderNameTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_XT_LogTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_XT_LogSonTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGSONTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_XT_LogTargetModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETSONMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_XT_LogTargetOperateTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETOPERATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_XT_LogDescriptionTitleControlIdToReplace',fld:'vDDO_XT_LOGDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_xt_logtarget_Activeeventkey',ctrl:'DDO_XT_LOGTARGET',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_LOGTARGET.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_logtarget_Sortedstatus',ctrl:'DDO_XT_LOGTARGET',prop:'SortedStatus'},{av:'AV13XT_LogIDTitleFilterData',fld:'vXT_LOGIDTITLEFILTERDATA',pic:''},{av:'AV15XT_LogUserIDTitleFilterData',fld:'vXT_LOGUSERIDTITLEFILTERDATA',pic:''},{av:'AV17XT_LogSecUserNameTitleFilterData',fld:'vXT_LOGSECUSERNAMETITLEFILTERDATA',pic:''},{av:'AV19XT_LogTimeTitleFilterData',fld:'vXT_LOGTIMETITLEFILTERDATA',pic:''},{av:'AV21XT_LogPageTitleFilterData',fld:'vXT_LOGPAGETITLEFILTERDATA',pic:''},{av:'AV23XT_LogButtonNameTitleFilterData',fld:'vXT_LOGBUTTONNAMETITLEFILTERDATA',pic:''},{av:'AV25XT_LogTypeTitleFilterData',fld:'vXT_LOGTYPETITLEFILTERDATA',pic:''},{av:'AV27XT_LogProviderIDTitleFilterData',fld:'vXT_LOGPROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV29XT_LogProviderNameTitleFilterData',fld:'vXT_LOGPROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV31XT_LogTargetTitleFilterData',fld:'vXT_LOGTARGETTITLEFILTERDATA',pic:''},{av:'AV33XT_LogSonTargetTitleFilterData',fld:'vXT_LOGSONTARGETTITLEFILTERDATA',pic:''},{av:'AV35XT_LogTargetModuleTitleFilterData',fld:'vXT_LOGTARGETMODULETITLEFILTERDATA',pic:''},{av:'AV37XT_LogTargetSonModuleTitleFilterData',fld:'vXT_LOGTARGETSONMODULETITLEFILTERDATA',pic:''},{av:'AV39XT_LogTargetOperateTitleFilterData',fld:'vXT_LOGTARGETOPERATETITLEFILTERDATA',pic:''},{av:'AV41XT_LogDescriptionTitleFilterData',fld:'vXT_LOGDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtXT_LogID_Titleformat',ctrl:'XT_LOGID',prop:'Titleformat'},{av:'edtXT_LogID_Title',ctrl:'XT_LOGID',prop:'Title'},{av:'edtXT_LogUserID_Titleformat',ctrl:'XT_LOGUSERID',prop:'Titleformat'},{av:'edtXT_LogUserID_Title',ctrl:'XT_LOGUSERID',prop:'Title'},{av:'edtXT_LogSecUserName_Titleformat',ctrl:'XT_LOGSECUSERNAME',prop:'Titleformat'},{av:'edtXT_LogSecUserName_Title',ctrl:'XT_LOGSECUSERNAME',prop:'Title'},{av:'edtXT_LogTime_Titleformat',ctrl:'XT_LOGTIME',prop:'Titleformat'},{av:'edtXT_LogTime_Title',ctrl:'XT_LOGTIME',prop:'Title'},{av:'cmbXT_LogPage'},{av:'edtXT_LogButtonName_Titleformat',ctrl:'XT_LOGBUTTONNAME',prop:'Titleformat'},{av:'edtXT_LogButtonName_Title',ctrl:'XT_LOGBUTTONNAME',prop:'Title'},{av:'edtXT_LogType_Titleformat',ctrl:'XT_LOGTYPE',prop:'Titleformat'},{av:'edtXT_LogType_Title',ctrl:'XT_LOGTYPE',prop:'Title'},{av:'edtXT_LogProviderID_Titleformat',ctrl:'XT_LOGPROVIDERID',prop:'Titleformat'},{av:'edtXT_LogProviderID_Title',ctrl:'XT_LOGPROVIDERID',prop:'Title'},{av:'edtXT_LogProviderName_Titleformat',ctrl:'XT_LOGPROVIDERNAME',prop:'Titleformat'},{av:'edtXT_LogProviderName_Title',ctrl:'XT_LOGPROVIDERNAME',prop:'Title'},{av:'edtXT_LogTarget_Titleformat',ctrl:'XT_LOGTARGET',prop:'Titleformat'},{av:'edtXT_LogTarget_Title',ctrl:'XT_LOGTARGET',prop:'Title'},{av:'edtXT_LogSonTarget_Titleformat',ctrl:'XT_LOGSONTARGET',prop:'Titleformat'},{av:'edtXT_LogSonTarget_Title',ctrl:'XT_LOGSONTARGET',prop:'Title'},{av:'edtXT_LogTargetModule_Titleformat',ctrl:'XT_LOGTARGETMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetModule_Title',ctrl:'XT_LOGTARGETMODULE',prop:'Title'},{av:'edtXT_LogTargetSonModule_Titleformat',ctrl:'XT_LOGTARGETSONMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetSonModule_Title',ctrl:'XT_LOGTARGETSONMODULE',prop:'Title'},{av:'cmbXT_LogTargetOperate'},{av:'edtXT_LogDescription_Titleformat',ctrl:'XT_LOGDESCRIPTION',prop:'Titleformat'},{av:'edtXT_LogDescription_Title',ctrl:'XT_LOGDESCRIPTION',prop:'Title'},{av:'AV45GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV46GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV47GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_XT_LOGSONTARGET.ONOPTIONCLICKED","{handler:'E234H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_LogIDTitleControlIdToReplace',fld:'vDDO_XT_LOGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_LogUserIDTitleControlIdToReplace',fld:'vDDO_XT_LOGUSERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_LogSecUserNameTitleControlIdToReplace',fld:'vDDO_XT_LOGSECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_LogTimeTitleControlIdToReplace',fld:'vDDO_XT_LOGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_XT_LogPageTitleControlIdToReplace',fld:'vDDO_XT_LOGPAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_XT_LogButtonNameTitleControlIdToReplace',fld:'vDDO_XT_LOGBUTTONNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_XT_LogTypeTitleControlIdToReplace',fld:'vDDO_XT_LOGTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_XT_LogProviderIDTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_XT_LogProviderNameTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_XT_LogTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_XT_LogSonTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGSONTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_XT_LogTargetModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETSONMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_XT_LogTargetOperateTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETOPERATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_XT_LogDescriptionTitleControlIdToReplace',fld:'vDDO_XT_LOGDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_xt_logsontarget_Activeeventkey',ctrl:'DDO_XT_LOGSONTARGET',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_LOGSONTARGET.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_logsontarget_Sortedstatus',ctrl:'DDO_XT_LOGSONTARGET',prop:'SortedStatus'},{av:'AV13XT_LogIDTitleFilterData',fld:'vXT_LOGIDTITLEFILTERDATA',pic:''},{av:'AV15XT_LogUserIDTitleFilterData',fld:'vXT_LOGUSERIDTITLEFILTERDATA',pic:''},{av:'AV17XT_LogSecUserNameTitleFilterData',fld:'vXT_LOGSECUSERNAMETITLEFILTERDATA',pic:''},{av:'AV19XT_LogTimeTitleFilterData',fld:'vXT_LOGTIMETITLEFILTERDATA',pic:''},{av:'AV21XT_LogPageTitleFilterData',fld:'vXT_LOGPAGETITLEFILTERDATA',pic:''},{av:'AV23XT_LogButtonNameTitleFilterData',fld:'vXT_LOGBUTTONNAMETITLEFILTERDATA',pic:''},{av:'AV25XT_LogTypeTitleFilterData',fld:'vXT_LOGTYPETITLEFILTERDATA',pic:''},{av:'AV27XT_LogProviderIDTitleFilterData',fld:'vXT_LOGPROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV29XT_LogProviderNameTitleFilterData',fld:'vXT_LOGPROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV31XT_LogTargetTitleFilterData',fld:'vXT_LOGTARGETTITLEFILTERDATA',pic:''},{av:'AV33XT_LogSonTargetTitleFilterData',fld:'vXT_LOGSONTARGETTITLEFILTERDATA',pic:''},{av:'AV35XT_LogTargetModuleTitleFilterData',fld:'vXT_LOGTARGETMODULETITLEFILTERDATA',pic:''},{av:'AV37XT_LogTargetSonModuleTitleFilterData',fld:'vXT_LOGTARGETSONMODULETITLEFILTERDATA',pic:''},{av:'AV39XT_LogTargetOperateTitleFilterData',fld:'vXT_LOGTARGETOPERATETITLEFILTERDATA',pic:''},{av:'AV41XT_LogDescriptionTitleFilterData',fld:'vXT_LOGDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtXT_LogID_Titleformat',ctrl:'XT_LOGID',prop:'Titleformat'},{av:'edtXT_LogID_Title',ctrl:'XT_LOGID',prop:'Title'},{av:'edtXT_LogUserID_Titleformat',ctrl:'XT_LOGUSERID',prop:'Titleformat'},{av:'edtXT_LogUserID_Title',ctrl:'XT_LOGUSERID',prop:'Title'},{av:'edtXT_LogSecUserName_Titleformat',ctrl:'XT_LOGSECUSERNAME',prop:'Titleformat'},{av:'edtXT_LogSecUserName_Title',ctrl:'XT_LOGSECUSERNAME',prop:'Title'},{av:'edtXT_LogTime_Titleformat',ctrl:'XT_LOGTIME',prop:'Titleformat'},{av:'edtXT_LogTime_Title',ctrl:'XT_LOGTIME',prop:'Title'},{av:'cmbXT_LogPage'},{av:'edtXT_LogButtonName_Titleformat',ctrl:'XT_LOGBUTTONNAME',prop:'Titleformat'},{av:'edtXT_LogButtonName_Title',ctrl:'XT_LOGBUTTONNAME',prop:'Title'},{av:'edtXT_LogType_Titleformat',ctrl:'XT_LOGTYPE',prop:'Titleformat'},{av:'edtXT_LogType_Title',ctrl:'XT_LOGTYPE',prop:'Title'},{av:'edtXT_LogProviderID_Titleformat',ctrl:'XT_LOGPROVIDERID',prop:'Titleformat'},{av:'edtXT_LogProviderID_Title',ctrl:'XT_LOGPROVIDERID',prop:'Title'},{av:'edtXT_LogProviderName_Titleformat',ctrl:'XT_LOGPROVIDERNAME',prop:'Titleformat'},{av:'edtXT_LogProviderName_Title',ctrl:'XT_LOGPROVIDERNAME',prop:'Title'},{av:'edtXT_LogTarget_Titleformat',ctrl:'XT_LOGTARGET',prop:'Titleformat'},{av:'edtXT_LogTarget_Title',ctrl:'XT_LOGTARGET',prop:'Title'},{av:'edtXT_LogSonTarget_Titleformat',ctrl:'XT_LOGSONTARGET',prop:'Titleformat'},{av:'edtXT_LogSonTarget_Title',ctrl:'XT_LOGSONTARGET',prop:'Title'},{av:'edtXT_LogTargetModule_Titleformat',ctrl:'XT_LOGTARGETMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetModule_Title',ctrl:'XT_LOGTARGETMODULE',prop:'Title'},{av:'edtXT_LogTargetSonModule_Titleformat',ctrl:'XT_LOGTARGETSONMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetSonModule_Title',ctrl:'XT_LOGTARGETSONMODULE',prop:'Title'},{av:'cmbXT_LogTargetOperate'},{av:'edtXT_LogDescription_Titleformat',ctrl:'XT_LOGDESCRIPTION',prop:'Titleformat'},{av:'edtXT_LogDescription_Title',ctrl:'XT_LOGDESCRIPTION',prop:'Title'},{av:'AV45GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV46GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV47GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_XT_LOGTARGETMODULE.ONOPTIONCLICKED","{handler:'E244H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_LogIDTitleControlIdToReplace',fld:'vDDO_XT_LOGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_LogUserIDTitleControlIdToReplace',fld:'vDDO_XT_LOGUSERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_LogSecUserNameTitleControlIdToReplace',fld:'vDDO_XT_LOGSECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_LogTimeTitleControlIdToReplace',fld:'vDDO_XT_LOGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_XT_LogPageTitleControlIdToReplace',fld:'vDDO_XT_LOGPAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_XT_LogButtonNameTitleControlIdToReplace',fld:'vDDO_XT_LOGBUTTONNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_XT_LogTypeTitleControlIdToReplace',fld:'vDDO_XT_LOGTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_XT_LogProviderIDTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_XT_LogProviderNameTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_XT_LogTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_XT_LogSonTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGSONTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_XT_LogTargetModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETSONMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_XT_LogTargetOperateTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETOPERATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_XT_LogDescriptionTitleControlIdToReplace',fld:'vDDO_XT_LOGDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_xt_logtargetmodule_Activeeventkey',ctrl:'DDO_XT_LOGTARGETMODULE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_LOGTARGETMODULE.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_logtargetmodule_Sortedstatus',ctrl:'DDO_XT_LOGTARGETMODULE',prop:'SortedStatus'},{av:'AV13XT_LogIDTitleFilterData',fld:'vXT_LOGIDTITLEFILTERDATA',pic:''},{av:'AV15XT_LogUserIDTitleFilterData',fld:'vXT_LOGUSERIDTITLEFILTERDATA',pic:''},{av:'AV17XT_LogSecUserNameTitleFilterData',fld:'vXT_LOGSECUSERNAMETITLEFILTERDATA',pic:''},{av:'AV19XT_LogTimeTitleFilterData',fld:'vXT_LOGTIMETITLEFILTERDATA',pic:''},{av:'AV21XT_LogPageTitleFilterData',fld:'vXT_LOGPAGETITLEFILTERDATA',pic:''},{av:'AV23XT_LogButtonNameTitleFilterData',fld:'vXT_LOGBUTTONNAMETITLEFILTERDATA',pic:''},{av:'AV25XT_LogTypeTitleFilterData',fld:'vXT_LOGTYPETITLEFILTERDATA',pic:''},{av:'AV27XT_LogProviderIDTitleFilterData',fld:'vXT_LOGPROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV29XT_LogProviderNameTitleFilterData',fld:'vXT_LOGPROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV31XT_LogTargetTitleFilterData',fld:'vXT_LOGTARGETTITLEFILTERDATA',pic:''},{av:'AV33XT_LogSonTargetTitleFilterData',fld:'vXT_LOGSONTARGETTITLEFILTERDATA',pic:''},{av:'AV35XT_LogTargetModuleTitleFilterData',fld:'vXT_LOGTARGETMODULETITLEFILTERDATA',pic:''},{av:'AV37XT_LogTargetSonModuleTitleFilterData',fld:'vXT_LOGTARGETSONMODULETITLEFILTERDATA',pic:''},{av:'AV39XT_LogTargetOperateTitleFilterData',fld:'vXT_LOGTARGETOPERATETITLEFILTERDATA',pic:''},{av:'AV41XT_LogDescriptionTitleFilterData',fld:'vXT_LOGDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtXT_LogID_Titleformat',ctrl:'XT_LOGID',prop:'Titleformat'},{av:'edtXT_LogID_Title',ctrl:'XT_LOGID',prop:'Title'},{av:'edtXT_LogUserID_Titleformat',ctrl:'XT_LOGUSERID',prop:'Titleformat'},{av:'edtXT_LogUserID_Title',ctrl:'XT_LOGUSERID',prop:'Title'},{av:'edtXT_LogSecUserName_Titleformat',ctrl:'XT_LOGSECUSERNAME',prop:'Titleformat'},{av:'edtXT_LogSecUserName_Title',ctrl:'XT_LOGSECUSERNAME',prop:'Title'},{av:'edtXT_LogTime_Titleformat',ctrl:'XT_LOGTIME',prop:'Titleformat'},{av:'edtXT_LogTime_Title',ctrl:'XT_LOGTIME',prop:'Title'},{av:'cmbXT_LogPage'},{av:'edtXT_LogButtonName_Titleformat',ctrl:'XT_LOGBUTTONNAME',prop:'Titleformat'},{av:'edtXT_LogButtonName_Title',ctrl:'XT_LOGBUTTONNAME',prop:'Title'},{av:'edtXT_LogType_Titleformat',ctrl:'XT_LOGTYPE',prop:'Titleformat'},{av:'edtXT_LogType_Title',ctrl:'XT_LOGTYPE',prop:'Title'},{av:'edtXT_LogProviderID_Titleformat',ctrl:'XT_LOGPROVIDERID',prop:'Titleformat'},{av:'edtXT_LogProviderID_Title',ctrl:'XT_LOGPROVIDERID',prop:'Title'},{av:'edtXT_LogProviderName_Titleformat',ctrl:'XT_LOGPROVIDERNAME',prop:'Titleformat'},{av:'edtXT_LogProviderName_Title',ctrl:'XT_LOGPROVIDERNAME',prop:'Title'},{av:'edtXT_LogTarget_Titleformat',ctrl:'XT_LOGTARGET',prop:'Titleformat'},{av:'edtXT_LogTarget_Title',ctrl:'XT_LOGTARGET',prop:'Title'},{av:'edtXT_LogSonTarget_Titleformat',ctrl:'XT_LOGSONTARGET',prop:'Titleformat'},{av:'edtXT_LogSonTarget_Title',ctrl:'XT_LOGSONTARGET',prop:'Title'},{av:'edtXT_LogTargetModule_Titleformat',ctrl:'XT_LOGTARGETMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetModule_Title',ctrl:'XT_LOGTARGETMODULE',prop:'Title'},{av:'edtXT_LogTargetSonModule_Titleformat',ctrl:'XT_LOGTARGETSONMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetSonModule_Title',ctrl:'XT_LOGTARGETSONMODULE',prop:'Title'},{av:'cmbXT_LogTargetOperate'},{av:'edtXT_LogDescription_Titleformat',ctrl:'XT_LOGDESCRIPTION',prop:'Titleformat'},{av:'edtXT_LogDescription_Title',ctrl:'XT_LOGDESCRIPTION',prop:'Title'},{av:'AV45GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV46GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV47GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_XT_LOGTARGETSONMODULE.ONOPTIONCLICKED","{handler:'E254H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_LogIDTitleControlIdToReplace',fld:'vDDO_XT_LOGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_LogUserIDTitleControlIdToReplace',fld:'vDDO_XT_LOGUSERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_LogSecUserNameTitleControlIdToReplace',fld:'vDDO_XT_LOGSECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_LogTimeTitleControlIdToReplace',fld:'vDDO_XT_LOGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_XT_LogPageTitleControlIdToReplace',fld:'vDDO_XT_LOGPAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_XT_LogButtonNameTitleControlIdToReplace',fld:'vDDO_XT_LOGBUTTONNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_XT_LogTypeTitleControlIdToReplace',fld:'vDDO_XT_LOGTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_XT_LogProviderIDTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_XT_LogProviderNameTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_XT_LogTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_XT_LogSonTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGSONTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_XT_LogTargetModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETSONMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_XT_LogTargetOperateTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETOPERATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_XT_LogDescriptionTitleControlIdToReplace',fld:'vDDO_XT_LOGDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_xt_logtargetsonmodule_Activeeventkey',ctrl:'DDO_XT_LOGTARGETSONMODULE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_LOGTARGETSONMODULE.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_logtargetsonmodule_Sortedstatus',ctrl:'DDO_XT_LOGTARGETSONMODULE',prop:'SortedStatus'},{av:'AV13XT_LogIDTitleFilterData',fld:'vXT_LOGIDTITLEFILTERDATA',pic:''},{av:'AV15XT_LogUserIDTitleFilterData',fld:'vXT_LOGUSERIDTITLEFILTERDATA',pic:''},{av:'AV17XT_LogSecUserNameTitleFilterData',fld:'vXT_LOGSECUSERNAMETITLEFILTERDATA',pic:''},{av:'AV19XT_LogTimeTitleFilterData',fld:'vXT_LOGTIMETITLEFILTERDATA',pic:''},{av:'AV21XT_LogPageTitleFilterData',fld:'vXT_LOGPAGETITLEFILTERDATA',pic:''},{av:'AV23XT_LogButtonNameTitleFilterData',fld:'vXT_LOGBUTTONNAMETITLEFILTERDATA',pic:''},{av:'AV25XT_LogTypeTitleFilterData',fld:'vXT_LOGTYPETITLEFILTERDATA',pic:''},{av:'AV27XT_LogProviderIDTitleFilterData',fld:'vXT_LOGPROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV29XT_LogProviderNameTitleFilterData',fld:'vXT_LOGPROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV31XT_LogTargetTitleFilterData',fld:'vXT_LOGTARGETTITLEFILTERDATA',pic:''},{av:'AV33XT_LogSonTargetTitleFilterData',fld:'vXT_LOGSONTARGETTITLEFILTERDATA',pic:''},{av:'AV35XT_LogTargetModuleTitleFilterData',fld:'vXT_LOGTARGETMODULETITLEFILTERDATA',pic:''},{av:'AV37XT_LogTargetSonModuleTitleFilterData',fld:'vXT_LOGTARGETSONMODULETITLEFILTERDATA',pic:''},{av:'AV39XT_LogTargetOperateTitleFilterData',fld:'vXT_LOGTARGETOPERATETITLEFILTERDATA',pic:''},{av:'AV41XT_LogDescriptionTitleFilterData',fld:'vXT_LOGDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtXT_LogID_Titleformat',ctrl:'XT_LOGID',prop:'Titleformat'},{av:'edtXT_LogID_Title',ctrl:'XT_LOGID',prop:'Title'},{av:'edtXT_LogUserID_Titleformat',ctrl:'XT_LOGUSERID',prop:'Titleformat'},{av:'edtXT_LogUserID_Title',ctrl:'XT_LOGUSERID',prop:'Title'},{av:'edtXT_LogSecUserName_Titleformat',ctrl:'XT_LOGSECUSERNAME',prop:'Titleformat'},{av:'edtXT_LogSecUserName_Title',ctrl:'XT_LOGSECUSERNAME',prop:'Title'},{av:'edtXT_LogTime_Titleformat',ctrl:'XT_LOGTIME',prop:'Titleformat'},{av:'edtXT_LogTime_Title',ctrl:'XT_LOGTIME',prop:'Title'},{av:'cmbXT_LogPage'},{av:'edtXT_LogButtonName_Titleformat',ctrl:'XT_LOGBUTTONNAME',prop:'Titleformat'},{av:'edtXT_LogButtonName_Title',ctrl:'XT_LOGBUTTONNAME',prop:'Title'},{av:'edtXT_LogType_Titleformat',ctrl:'XT_LOGTYPE',prop:'Titleformat'},{av:'edtXT_LogType_Title',ctrl:'XT_LOGTYPE',prop:'Title'},{av:'edtXT_LogProviderID_Titleformat',ctrl:'XT_LOGPROVIDERID',prop:'Titleformat'},{av:'edtXT_LogProviderID_Title',ctrl:'XT_LOGPROVIDERID',prop:'Title'},{av:'edtXT_LogProviderName_Titleformat',ctrl:'XT_LOGPROVIDERNAME',prop:'Titleformat'},{av:'edtXT_LogProviderName_Title',ctrl:'XT_LOGPROVIDERNAME',prop:'Title'},{av:'edtXT_LogTarget_Titleformat',ctrl:'XT_LOGTARGET',prop:'Titleformat'},{av:'edtXT_LogTarget_Title',ctrl:'XT_LOGTARGET',prop:'Title'},{av:'edtXT_LogSonTarget_Titleformat',ctrl:'XT_LOGSONTARGET',prop:'Titleformat'},{av:'edtXT_LogSonTarget_Title',ctrl:'XT_LOGSONTARGET',prop:'Title'},{av:'edtXT_LogTargetModule_Titleformat',ctrl:'XT_LOGTARGETMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetModule_Title',ctrl:'XT_LOGTARGETMODULE',prop:'Title'},{av:'edtXT_LogTargetSonModule_Titleformat',ctrl:'XT_LOGTARGETSONMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetSonModule_Title',ctrl:'XT_LOGTARGETSONMODULE',prop:'Title'},{av:'cmbXT_LogTargetOperate'},{av:'edtXT_LogDescription_Titleformat',ctrl:'XT_LOGDESCRIPTION',prop:'Titleformat'},{av:'edtXT_LogDescription_Title',ctrl:'XT_LOGDESCRIPTION',prop:'Title'},{av:'AV45GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV46GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV47GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_XT_LOGTARGETOPERATE.ONOPTIONCLICKED","{handler:'E264H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_LogIDTitleControlIdToReplace',fld:'vDDO_XT_LOGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_LogUserIDTitleControlIdToReplace',fld:'vDDO_XT_LOGUSERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_LogSecUserNameTitleControlIdToReplace',fld:'vDDO_XT_LOGSECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_LogTimeTitleControlIdToReplace',fld:'vDDO_XT_LOGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_XT_LogPageTitleControlIdToReplace',fld:'vDDO_XT_LOGPAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_XT_LogButtonNameTitleControlIdToReplace',fld:'vDDO_XT_LOGBUTTONNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_XT_LogTypeTitleControlIdToReplace',fld:'vDDO_XT_LOGTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_XT_LogProviderIDTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_XT_LogProviderNameTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_XT_LogTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_XT_LogSonTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGSONTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_XT_LogTargetModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETSONMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_XT_LogTargetOperateTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETOPERATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_XT_LogDescriptionTitleControlIdToReplace',fld:'vDDO_XT_LOGDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_xt_logtargetoperate_Activeeventkey',ctrl:'DDO_XT_LOGTARGETOPERATE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_LOGTARGETOPERATE.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_logtargetoperate_Sortedstatus',ctrl:'DDO_XT_LOGTARGETOPERATE',prop:'SortedStatus'},{av:'AV13XT_LogIDTitleFilterData',fld:'vXT_LOGIDTITLEFILTERDATA',pic:''},{av:'AV15XT_LogUserIDTitleFilterData',fld:'vXT_LOGUSERIDTITLEFILTERDATA',pic:''},{av:'AV17XT_LogSecUserNameTitleFilterData',fld:'vXT_LOGSECUSERNAMETITLEFILTERDATA',pic:''},{av:'AV19XT_LogTimeTitleFilterData',fld:'vXT_LOGTIMETITLEFILTERDATA',pic:''},{av:'AV21XT_LogPageTitleFilterData',fld:'vXT_LOGPAGETITLEFILTERDATA',pic:''},{av:'AV23XT_LogButtonNameTitleFilterData',fld:'vXT_LOGBUTTONNAMETITLEFILTERDATA',pic:''},{av:'AV25XT_LogTypeTitleFilterData',fld:'vXT_LOGTYPETITLEFILTERDATA',pic:''},{av:'AV27XT_LogProviderIDTitleFilterData',fld:'vXT_LOGPROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV29XT_LogProviderNameTitleFilterData',fld:'vXT_LOGPROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV31XT_LogTargetTitleFilterData',fld:'vXT_LOGTARGETTITLEFILTERDATA',pic:''},{av:'AV33XT_LogSonTargetTitleFilterData',fld:'vXT_LOGSONTARGETTITLEFILTERDATA',pic:''},{av:'AV35XT_LogTargetModuleTitleFilterData',fld:'vXT_LOGTARGETMODULETITLEFILTERDATA',pic:''},{av:'AV37XT_LogTargetSonModuleTitleFilterData',fld:'vXT_LOGTARGETSONMODULETITLEFILTERDATA',pic:''},{av:'AV39XT_LogTargetOperateTitleFilterData',fld:'vXT_LOGTARGETOPERATETITLEFILTERDATA',pic:''},{av:'AV41XT_LogDescriptionTitleFilterData',fld:'vXT_LOGDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtXT_LogID_Titleformat',ctrl:'XT_LOGID',prop:'Titleformat'},{av:'edtXT_LogID_Title',ctrl:'XT_LOGID',prop:'Title'},{av:'edtXT_LogUserID_Titleformat',ctrl:'XT_LOGUSERID',prop:'Titleformat'},{av:'edtXT_LogUserID_Title',ctrl:'XT_LOGUSERID',prop:'Title'},{av:'edtXT_LogSecUserName_Titleformat',ctrl:'XT_LOGSECUSERNAME',prop:'Titleformat'},{av:'edtXT_LogSecUserName_Title',ctrl:'XT_LOGSECUSERNAME',prop:'Title'},{av:'edtXT_LogTime_Titleformat',ctrl:'XT_LOGTIME',prop:'Titleformat'},{av:'edtXT_LogTime_Title',ctrl:'XT_LOGTIME',prop:'Title'},{av:'cmbXT_LogPage'},{av:'edtXT_LogButtonName_Titleformat',ctrl:'XT_LOGBUTTONNAME',prop:'Titleformat'},{av:'edtXT_LogButtonName_Title',ctrl:'XT_LOGBUTTONNAME',prop:'Title'},{av:'edtXT_LogType_Titleformat',ctrl:'XT_LOGTYPE',prop:'Titleformat'},{av:'edtXT_LogType_Title',ctrl:'XT_LOGTYPE',prop:'Title'},{av:'edtXT_LogProviderID_Titleformat',ctrl:'XT_LOGPROVIDERID',prop:'Titleformat'},{av:'edtXT_LogProviderID_Title',ctrl:'XT_LOGPROVIDERID',prop:'Title'},{av:'edtXT_LogProviderName_Titleformat',ctrl:'XT_LOGPROVIDERNAME',prop:'Titleformat'},{av:'edtXT_LogProviderName_Title',ctrl:'XT_LOGPROVIDERNAME',prop:'Title'},{av:'edtXT_LogTarget_Titleformat',ctrl:'XT_LOGTARGET',prop:'Titleformat'},{av:'edtXT_LogTarget_Title',ctrl:'XT_LOGTARGET',prop:'Title'},{av:'edtXT_LogSonTarget_Titleformat',ctrl:'XT_LOGSONTARGET',prop:'Titleformat'},{av:'edtXT_LogSonTarget_Title',ctrl:'XT_LOGSONTARGET',prop:'Title'},{av:'edtXT_LogTargetModule_Titleformat',ctrl:'XT_LOGTARGETMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetModule_Title',ctrl:'XT_LOGTARGETMODULE',prop:'Title'},{av:'edtXT_LogTargetSonModule_Titleformat',ctrl:'XT_LOGTARGETSONMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetSonModule_Title',ctrl:'XT_LOGTARGETSONMODULE',prop:'Title'},{av:'cmbXT_LogTargetOperate'},{av:'edtXT_LogDescription_Titleformat',ctrl:'XT_LOGDESCRIPTION',prop:'Titleformat'},{av:'edtXT_LogDescription_Title',ctrl:'XT_LOGDESCRIPTION',prop:'Title'},{av:'AV45GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV46GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV47GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_XT_LOGDESCRIPTION.ONOPTIONCLICKED","{handler:'E274H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_XT_LogIDTitleControlIdToReplace',fld:'vDDO_XT_LOGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_XT_LogUserIDTitleControlIdToReplace',fld:'vDDO_XT_LOGUSERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_XT_LogSecUserNameTitleControlIdToReplace',fld:'vDDO_XT_LOGSECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_XT_LogTimeTitleControlIdToReplace',fld:'vDDO_XT_LOGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_XT_LogPageTitleControlIdToReplace',fld:'vDDO_XT_LOGPAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_XT_LogButtonNameTitleControlIdToReplace',fld:'vDDO_XT_LOGBUTTONNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_XT_LogTypeTitleControlIdToReplace',fld:'vDDO_XT_LOGTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_XT_LogProviderIDTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_XT_LogProviderNameTitleControlIdToReplace',fld:'vDDO_XT_LOGPROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_XT_LogTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_XT_LogSonTargetTitleControlIdToReplace',fld:'vDDO_XT_LOGSONTARGETTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_XT_LogTargetModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETSONMODULETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_XT_LogTargetOperateTitleControlIdToReplace',fld:'vDDO_XT_LOGTARGETOPERATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_XT_LogDescriptionTitleControlIdToReplace',fld:'vDDO_XT_LOGDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_xt_logdescription_Activeeventkey',ctrl:'DDO_XT_LOGDESCRIPTION',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_LOGDESCRIPTION.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_logdescription_Sortedstatus',ctrl:'DDO_XT_LOGDESCRIPTION',prop:'SortedStatus'},{av:'AV13XT_LogIDTitleFilterData',fld:'vXT_LOGIDTITLEFILTERDATA',pic:''},{av:'AV15XT_LogUserIDTitleFilterData',fld:'vXT_LOGUSERIDTITLEFILTERDATA',pic:''},{av:'AV17XT_LogSecUserNameTitleFilterData',fld:'vXT_LOGSECUSERNAMETITLEFILTERDATA',pic:''},{av:'AV19XT_LogTimeTitleFilterData',fld:'vXT_LOGTIMETITLEFILTERDATA',pic:''},{av:'AV21XT_LogPageTitleFilterData',fld:'vXT_LOGPAGETITLEFILTERDATA',pic:''},{av:'AV23XT_LogButtonNameTitleFilterData',fld:'vXT_LOGBUTTONNAMETITLEFILTERDATA',pic:''},{av:'AV25XT_LogTypeTitleFilterData',fld:'vXT_LOGTYPETITLEFILTERDATA',pic:''},{av:'AV27XT_LogProviderIDTitleFilterData',fld:'vXT_LOGPROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV29XT_LogProviderNameTitleFilterData',fld:'vXT_LOGPROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV31XT_LogTargetTitleFilterData',fld:'vXT_LOGTARGETTITLEFILTERDATA',pic:''},{av:'AV33XT_LogSonTargetTitleFilterData',fld:'vXT_LOGSONTARGETTITLEFILTERDATA',pic:''},{av:'AV35XT_LogTargetModuleTitleFilterData',fld:'vXT_LOGTARGETMODULETITLEFILTERDATA',pic:''},{av:'AV37XT_LogTargetSonModuleTitleFilterData',fld:'vXT_LOGTARGETSONMODULETITLEFILTERDATA',pic:''},{av:'AV39XT_LogTargetOperateTitleFilterData',fld:'vXT_LOGTARGETOPERATETITLEFILTERDATA',pic:''},{av:'AV41XT_LogDescriptionTitleFilterData',fld:'vXT_LOGDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtXT_LogID_Titleformat',ctrl:'XT_LOGID',prop:'Titleformat'},{av:'edtXT_LogID_Title',ctrl:'XT_LOGID',prop:'Title'},{av:'edtXT_LogUserID_Titleformat',ctrl:'XT_LOGUSERID',prop:'Titleformat'},{av:'edtXT_LogUserID_Title',ctrl:'XT_LOGUSERID',prop:'Title'},{av:'edtXT_LogSecUserName_Titleformat',ctrl:'XT_LOGSECUSERNAME',prop:'Titleformat'},{av:'edtXT_LogSecUserName_Title',ctrl:'XT_LOGSECUSERNAME',prop:'Title'},{av:'edtXT_LogTime_Titleformat',ctrl:'XT_LOGTIME',prop:'Titleformat'},{av:'edtXT_LogTime_Title',ctrl:'XT_LOGTIME',prop:'Title'},{av:'cmbXT_LogPage'},{av:'edtXT_LogButtonName_Titleformat',ctrl:'XT_LOGBUTTONNAME',prop:'Titleformat'},{av:'edtXT_LogButtonName_Title',ctrl:'XT_LOGBUTTONNAME',prop:'Title'},{av:'edtXT_LogType_Titleformat',ctrl:'XT_LOGTYPE',prop:'Titleformat'},{av:'edtXT_LogType_Title',ctrl:'XT_LOGTYPE',prop:'Title'},{av:'edtXT_LogProviderID_Titleformat',ctrl:'XT_LOGPROVIDERID',prop:'Titleformat'},{av:'edtXT_LogProviderID_Title',ctrl:'XT_LOGPROVIDERID',prop:'Title'},{av:'edtXT_LogProviderName_Titleformat',ctrl:'XT_LOGPROVIDERNAME',prop:'Titleformat'},{av:'edtXT_LogProviderName_Title',ctrl:'XT_LOGPROVIDERNAME',prop:'Title'},{av:'edtXT_LogTarget_Titleformat',ctrl:'XT_LOGTARGET',prop:'Titleformat'},{av:'edtXT_LogTarget_Title',ctrl:'XT_LOGTARGET',prop:'Title'},{av:'edtXT_LogSonTarget_Titleformat',ctrl:'XT_LOGSONTARGET',prop:'Titleformat'},{av:'edtXT_LogSonTarget_Title',ctrl:'XT_LOGSONTARGET',prop:'Title'},{av:'edtXT_LogTargetModule_Titleformat',ctrl:'XT_LOGTARGETMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetModule_Title',ctrl:'XT_LOGTARGETMODULE',prop:'Title'},{av:'edtXT_LogTargetSonModule_Titleformat',ctrl:'XT_LOGTARGETSONMODULE',prop:'Titleformat'},{av:'edtXT_LogTargetSonModule_Title',ctrl:'XT_LOGTARGETSONMODULE',prop:'Title'},{av:'cmbXT_LogTargetOperate'},{av:'edtXT_LogDescription_Titleformat',ctrl:'XT_LOGDESCRIPTION',prop:'Titleformat'},{av:'edtXT_LogDescription_Title',ctrl:'XT_LOGDESCRIPTION',prop:'Title'},{av:'AV45GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV46GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV47GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E304H2',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV48Select',fld:'vSELECT',pic:''},{av:'edtavSelect_Tooltiptext',ctrl:'vSELECT',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E314H2',iparms:[{av:'A173XT_LogID',fld:'XT_LOGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A214XT_LogUserID',fld:'XT_LOGUSERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV8InOutXT_LogID',fld:'vINOUTXT_LOGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV9InOutXT_LogUserID',fld:'vINOUTXT_LOGUSERID',pic:'ZZZZZZZZZZZZZZZZZZ'}]}");
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
         Ddo_xt_logid_Activeeventkey = "";
         Ddo_xt_loguserid_Activeeventkey = "";
         Ddo_xt_logsecusername_Activeeventkey = "";
         Ddo_xt_logtime_Activeeventkey = "";
         Ddo_xt_logpage_Activeeventkey = "";
         Ddo_xt_logbuttonname_Activeeventkey = "";
         Ddo_xt_logtype_Activeeventkey = "";
         Ddo_xt_logproviderid_Activeeventkey = "";
         Ddo_xt_logprovidername_Activeeventkey = "";
         Ddo_xt_logtarget_Activeeventkey = "";
         Ddo_xt_logsontarget_Activeeventkey = "";
         Ddo_xt_logtargetmodule_Activeeventkey = "";
         Ddo_xt_logtargetsonmodule_Activeeventkey = "";
         Ddo_xt_logtargetoperate_Activeeventkey = "";
         Ddo_xt_logdescription_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV14ddo_XT_LogIDTitleControlIdToReplace = "";
         AV16ddo_XT_LogUserIDTitleControlIdToReplace = "";
         AV18ddo_XT_LogSecUserNameTitleControlIdToReplace = "";
         AV20ddo_XT_LogTimeTitleControlIdToReplace = "";
         AV22ddo_XT_LogPageTitleControlIdToReplace = "";
         AV24ddo_XT_LogButtonNameTitleControlIdToReplace = "";
         AV26ddo_XT_LogTypeTitleControlIdToReplace = "";
         AV28ddo_XT_LogProviderIDTitleControlIdToReplace = "";
         AV30ddo_XT_LogProviderNameTitleControlIdToReplace = "";
         AV32ddo_XT_LogTargetTitleControlIdToReplace = "";
         AV34ddo_XT_LogSonTargetTitleControlIdToReplace = "";
         AV36ddo_XT_LogTargetModuleTitleControlIdToReplace = "";
         AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace = "";
         AV40ddo_XT_LogTargetOperateTitleControlIdToReplace = "";
         AV42ddo_XT_LogDescriptionTitleControlIdToReplace = "";
         GXKey = "";
         AV51Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV43DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV13XT_LogIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15XT_LogUserIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17XT_LogSecUserNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19XT_LogTimeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21XT_LogPageTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV23XT_LogButtonNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV25XT_LogTypeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV27XT_LogProviderIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV29XT_LogProviderNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV31XT_LogTargetTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV33XT_LogSonTargetTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV35XT_LogTargetModuleTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV37XT_LogTargetSonModuleTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV39XT_LogTargetOperateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV41XT_LogDescriptionTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_xt_logid_Sortedstatus = "";
         Ddo_xt_loguserid_Sortedstatus = "";
         Ddo_xt_logsecusername_Sortedstatus = "";
         Ddo_xt_logtime_Sortedstatus = "";
         Ddo_xt_logpage_Sortedstatus = "";
         Ddo_xt_logbuttonname_Sortedstatus = "";
         Ddo_xt_logtype_Sortedstatus = "";
         Ddo_xt_logproviderid_Sortedstatus = "";
         Ddo_xt_logprovidername_Sortedstatus = "";
         Ddo_xt_logtarget_Sortedstatus = "";
         Ddo_xt_logsontarget_Sortedstatus = "";
         Ddo_xt_logtargetmodule_Sortedstatus = "";
         Ddo_xt_logtargetsonmodule_Sortedstatus = "";
         Ddo_xt_logtargetoperate_Sortedstatus = "";
         Ddo_xt_logdescription_Sortedstatus = "";
         GX_FocusControl = "";
         sPrefix = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV48Select = "";
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
         ucDdo_xt_logid = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_xt_loguserid = new GXUserControl();
         ucDdo_xt_logsecusername = new GXUserControl();
         ucDdo_xt_logtime = new GXUserControl();
         ucDdo_xt_logpage = new GXUserControl();
         ucDdo_xt_logbuttonname = new GXUserControl();
         ucDdo_xt_logtype = new GXUserControl();
         ucDdo_xt_logproviderid = new GXUserControl();
         ucDdo_xt_logprovidername = new GXUserControl();
         ucDdo_xt_logtarget = new GXUserControl();
         ucDdo_xt_logsontarget = new GXUserControl();
         ucDdo_xt_logtargetmodule = new GXUserControl();
         ucDdo_xt_logtargetsonmodule = new GXUserControl();
         ucDdo_xt_logtargetoperate = new GXUserControl();
         ucDdo_xt_logdescription = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV52Select_GXI = "";
         scmdbuf = "";
         H004H2_A221XT_LogDescription = new String[] {""} ;
         H004H2_n221XT_LogDescription = new bool[] {false} ;
         H004H2_A218XT_LogTargetOperate = new String[] {""} ;
         H004H2_n218XT_LogTargetOperate = new bool[] {false} ;
         H004H2_A222XT_LogTargetSonModule = new String[] {""} ;
         H004H2_n222XT_LogTargetSonModule = new bool[] {false} ;
         H004H2_A217XT_LogTargetModule = new String[] {""} ;
         H004H2_n217XT_LogTargetModule = new bool[] {false} ;
         H004H2_A223XT_LogSonTarget = new String[] {""} ;
         H004H2_n223XT_LogSonTarget = new bool[] {false} ;
         H004H2_A216XT_LogTarget = new String[] {""} ;
         H004H2_n216XT_LogTarget = new bool[] {false} ;
         H004H2_A219XT_LogProviderName = new String[] {""} ;
         H004H2_n219XT_LogProviderName = new bool[] {false} ;
         H004H2_A215XT_LogProviderID = new long[1] ;
         H004H2_n215XT_LogProviderID = new bool[] {false} ;
         H004H2_A213XT_LogType = new String[] {""} ;
         H004H2_n213XT_LogType = new bool[] {false} ;
         H004H2_A177XT_LogButtonName = new String[] {""} ;
         H004H2_n177XT_LogButtonName = new bool[] {false} ;
         H004H2_A176XT_LogPage = new String[] {""} ;
         H004H2_n176XT_LogPage = new bool[] {false} ;
         H004H2_A220XT_LogTime = new DateTime[] {DateTime.MinValue} ;
         H004H2_n220XT_LogTime = new bool[] {false} ;
         H004H2_A174XT_LogSecUserName = new String[] {""} ;
         H004H2_n174XT_LogSecUserName = new bool[] {false} ;
         H004H2_A214XT_LogUserID = new long[1] ;
         H004H2_n214XT_LogUserID = new bool[] {false} ;
         H004H2_A173XT_LogID = new long[1] ;
         H004H3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.xt_logprompt__default(),
            new Object[][] {
                new Object[] {
               H004H2_A221XT_LogDescription, H004H2_n221XT_LogDescription, H004H2_A218XT_LogTargetOperate, H004H2_n218XT_LogTargetOperate, H004H2_A222XT_LogTargetSonModule, H004H2_n222XT_LogTargetSonModule, H004H2_A217XT_LogTargetModule, H004H2_n217XT_LogTargetModule, H004H2_A223XT_LogSonTarget, H004H2_n223XT_LogSonTarget,
               H004H2_A216XT_LogTarget, H004H2_n216XT_LogTarget, H004H2_A219XT_LogProviderName, H004H2_n219XT_LogProviderName, H004H2_A215XT_LogProviderID, H004H2_n215XT_LogProviderID, H004H2_A213XT_LogType, H004H2_n213XT_LogType, H004H2_A177XT_LogButtonName, H004H2_n177XT_LogButtonName,
               H004H2_A176XT_LogPage, H004H2_n176XT_LogPage, H004H2_A220XT_LogTime, H004H2_n220XT_LogTime, H004H2_A174XT_LogSecUserName, H004H2_n174XT_LogSecUserName, H004H2_A214XT_LogUserID, H004H2_n214XT_LogUserID, H004H2_A173XT_LogID
               }
               , new Object[] {
               H004H3_AGRID_nRecordCount
               }
            }
         );
         AV51Pgmname = "XT_LogPrompt";
         /* GeneXus formulas. */
         AV51Pgmname = "XT_LogPrompt";
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
      private short edtXT_LogID_Titleformat ;
      private short edtXT_LogUserID_Titleformat ;
      private short edtXT_LogSecUserName_Titleformat ;
      private short edtXT_LogTime_Titleformat ;
      private short cmbXT_LogPage_Titleformat ;
      private short edtXT_LogButtonName_Titleformat ;
      private short edtXT_LogType_Titleformat ;
      private short edtXT_LogProviderID_Titleformat ;
      private short edtXT_LogProviderName_Titleformat ;
      private short edtXT_LogTarget_Titleformat ;
      private short edtXT_LogSonTarget_Titleformat ;
      private short edtXT_LogTargetModule_Titleformat ;
      private short edtXT_LogTargetSonModule_Titleformat ;
      private short cmbXT_LogTargetOperate_Titleformat ;
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
      private int divTablemain_Height ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_xt_logidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_xt_loguseridtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_xt_logsecusernametitlecontrolidtoreplace_Visible ;
      private int edtavDdo_xt_logtimetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_xt_logpagetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_xt_logbuttonnametitlecontrolidtoreplace_Visible ;
      private int edtavDdo_xt_logtypetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_xt_logprovideridtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_xt_logprovidernametitlecontrolidtoreplace_Visible ;
      private int edtavDdo_xt_logtargettitlecontrolidtoreplace_Visible ;
      private int edtavDdo_xt_logsontargettitlecontrolidtoreplace_Visible ;
      private int edtavDdo_xt_logtargetmoduletitlecontrolidtoreplace_Visible ;
      private int edtavDdo_xt_logtargetsonmoduletitlecontrolidtoreplace_Visible ;
      private int edtavDdo_xt_logtargetoperatetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_xt_logdescriptiontitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV44PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavSelect_Enabled ;
      private int edtavSelect_Visible ;
      private long AV8InOutXT_LogID ;
      private long AV9InOutXT_LogUserID ;
      private long wcpOAV8InOutXT_LogID ;
      private long wcpOAV9InOutXT_LogUserID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV45GridCurrentPage ;
      private long AV47GridRecordCount ;
      private long AV46GridPageSize ;
      private long A173XT_LogID ;
      private long A214XT_LogUserID ;
      private long A215XT_LogProviderID ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_xt_logid_Activeeventkey ;
      private String Ddo_xt_loguserid_Activeeventkey ;
      private String Ddo_xt_logsecusername_Activeeventkey ;
      private String Ddo_xt_logtime_Activeeventkey ;
      private String Ddo_xt_logpage_Activeeventkey ;
      private String Ddo_xt_logbuttonname_Activeeventkey ;
      private String Ddo_xt_logtype_Activeeventkey ;
      private String Ddo_xt_logproviderid_Activeeventkey ;
      private String Ddo_xt_logprovidername_Activeeventkey ;
      private String Ddo_xt_logtarget_Activeeventkey ;
      private String Ddo_xt_logsontarget_Activeeventkey ;
      private String Ddo_xt_logtargetmodule_Activeeventkey ;
      private String Ddo_xt_logtargetsonmodule_Activeeventkey ;
      private String Ddo_xt_logtargetoperate_Activeeventkey ;
      private String Ddo_xt_logdescription_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_12_idx="0001" ;
      private String GXKey ;
      private String AV51Pgmname ;
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
      private String Ddo_xt_logid_Caption ;
      private String Ddo_xt_logid_Tooltip ;
      private String Ddo_xt_logid_Cls ;
      private String Ddo_xt_logid_Dropdownoptionstype ;
      private String Ddo_xt_logid_Titlecontrolidtoreplace ;
      private String Ddo_xt_logid_Sortedstatus ;
      private String Ddo_xt_logid_Sortasc ;
      private String Ddo_xt_logid_Sortdsc ;
      private String Ddo_xt_logid_Searchbuttontext ;
      private String Ddo_xt_loguserid_Caption ;
      private String Ddo_xt_loguserid_Tooltip ;
      private String Ddo_xt_loguserid_Cls ;
      private String Ddo_xt_loguserid_Dropdownoptionstype ;
      private String Ddo_xt_loguserid_Titlecontrolidtoreplace ;
      private String Ddo_xt_loguserid_Sortedstatus ;
      private String Ddo_xt_loguserid_Sortasc ;
      private String Ddo_xt_loguserid_Sortdsc ;
      private String Ddo_xt_loguserid_Searchbuttontext ;
      private String Ddo_xt_logsecusername_Caption ;
      private String Ddo_xt_logsecusername_Tooltip ;
      private String Ddo_xt_logsecusername_Cls ;
      private String Ddo_xt_logsecusername_Dropdownoptionstype ;
      private String Ddo_xt_logsecusername_Titlecontrolidtoreplace ;
      private String Ddo_xt_logsecusername_Sortedstatus ;
      private String Ddo_xt_logsecusername_Sortasc ;
      private String Ddo_xt_logsecusername_Sortdsc ;
      private String Ddo_xt_logsecusername_Searchbuttontext ;
      private String Ddo_xt_logtime_Caption ;
      private String Ddo_xt_logtime_Tooltip ;
      private String Ddo_xt_logtime_Cls ;
      private String Ddo_xt_logtime_Dropdownoptionstype ;
      private String Ddo_xt_logtime_Titlecontrolidtoreplace ;
      private String Ddo_xt_logtime_Sortedstatus ;
      private String Ddo_xt_logtime_Sortasc ;
      private String Ddo_xt_logtime_Sortdsc ;
      private String Ddo_xt_logtime_Searchbuttontext ;
      private String Ddo_xt_logpage_Caption ;
      private String Ddo_xt_logpage_Tooltip ;
      private String Ddo_xt_logpage_Cls ;
      private String Ddo_xt_logpage_Dropdownoptionstype ;
      private String Ddo_xt_logpage_Titlecontrolidtoreplace ;
      private String Ddo_xt_logpage_Sortedstatus ;
      private String Ddo_xt_logpage_Sortasc ;
      private String Ddo_xt_logpage_Sortdsc ;
      private String Ddo_xt_logpage_Searchbuttontext ;
      private String Ddo_xt_logbuttonname_Caption ;
      private String Ddo_xt_logbuttonname_Tooltip ;
      private String Ddo_xt_logbuttonname_Cls ;
      private String Ddo_xt_logbuttonname_Dropdownoptionstype ;
      private String Ddo_xt_logbuttonname_Titlecontrolidtoreplace ;
      private String Ddo_xt_logbuttonname_Sortedstatus ;
      private String Ddo_xt_logbuttonname_Sortasc ;
      private String Ddo_xt_logbuttonname_Sortdsc ;
      private String Ddo_xt_logbuttonname_Searchbuttontext ;
      private String Ddo_xt_logtype_Caption ;
      private String Ddo_xt_logtype_Tooltip ;
      private String Ddo_xt_logtype_Cls ;
      private String Ddo_xt_logtype_Dropdownoptionstype ;
      private String Ddo_xt_logtype_Titlecontrolidtoreplace ;
      private String Ddo_xt_logtype_Sortedstatus ;
      private String Ddo_xt_logtype_Sortasc ;
      private String Ddo_xt_logtype_Sortdsc ;
      private String Ddo_xt_logtype_Searchbuttontext ;
      private String Ddo_xt_logproviderid_Caption ;
      private String Ddo_xt_logproviderid_Tooltip ;
      private String Ddo_xt_logproviderid_Cls ;
      private String Ddo_xt_logproviderid_Dropdownoptionstype ;
      private String Ddo_xt_logproviderid_Titlecontrolidtoreplace ;
      private String Ddo_xt_logproviderid_Sortedstatus ;
      private String Ddo_xt_logproviderid_Sortasc ;
      private String Ddo_xt_logproviderid_Sortdsc ;
      private String Ddo_xt_logproviderid_Searchbuttontext ;
      private String Ddo_xt_logprovidername_Caption ;
      private String Ddo_xt_logprovidername_Tooltip ;
      private String Ddo_xt_logprovidername_Cls ;
      private String Ddo_xt_logprovidername_Dropdownoptionstype ;
      private String Ddo_xt_logprovidername_Titlecontrolidtoreplace ;
      private String Ddo_xt_logprovidername_Sortedstatus ;
      private String Ddo_xt_logprovidername_Sortasc ;
      private String Ddo_xt_logprovidername_Sortdsc ;
      private String Ddo_xt_logprovidername_Searchbuttontext ;
      private String Ddo_xt_logtarget_Caption ;
      private String Ddo_xt_logtarget_Tooltip ;
      private String Ddo_xt_logtarget_Cls ;
      private String Ddo_xt_logtarget_Dropdownoptionstype ;
      private String Ddo_xt_logtarget_Titlecontrolidtoreplace ;
      private String Ddo_xt_logtarget_Sortedstatus ;
      private String Ddo_xt_logtarget_Sortasc ;
      private String Ddo_xt_logtarget_Sortdsc ;
      private String Ddo_xt_logtarget_Searchbuttontext ;
      private String Ddo_xt_logsontarget_Caption ;
      private String Ddo_xt_logsontarget_Tooltip ;
      private String Ddo_xt_logsontarget_Cls ;
      private String Ddo_xt_logsontarget_Dropdownoptionstype ;
      private String Ddo_xt_logsontarget_Titlecontrolidtoreplace ;
      private String Ddo_xt_logsontarget_Sortedstatus ;
      private String Ddo_xt_logsontarget_Sortasc ;
      private String Ddo_xt_logsontarget_Sortdsc ;
      private String Ddo_xt_logsontarget_Searchbuttontext ;
      private String Ddo_xt_logtargetmodule_Caption ;
      private String Ddo_xt_logtargetmodule_Tooltip ;
      private String Ddo_xt_logtargetmodule_Cls ;
      private String Ddo_xt_logtargetmodule_Dropdownoptionstype ;
      private String Ddo_xt_logtargetmodule_Titlecontrolidtoreplace ;
      private String Ddo_xt_logtargetmodule_Sortedstatus ;
      private String Ddo_xt_logtargetmodule_Sortasc ;
      private String Ddo_xt_logtargetmodule_Sortdsc ;
      private String Ddo_xt_logtargetmodule_Searchbuttontext ;
      private String Ddo_xt_logtargetsonmodule_Caption ;
      private String Ddo_xt_logtargetsonmodule_Tooltip ;
      private String Ddo_xt_logtargetsonmodule_Cls ;
      private String Ddo_xt_logtargetsonmodule_Dropdownoptionstype ;
      private String Ddo_xt_logtargetsonmodule_Titlecontrolidtoreplace ;
      private String Ddo_xt_logtargetsonmodule_Sortedstatus ;
      private String Ddo_xt_logtargetsonmodule_Sortasc ;
      private String Ddo_xt_logtargetsonmodule_Sortdsc ;
      private String Ddo_xt_logtargetsonmodule_Searchbuttontext ;
      private String Ddo_xt_logtargetoperate_Caption ;
      private String Ddo_xt_logtargetoperate_Tooltip ;
      private String Ddo_xt_logtargetoperate_Cls ;
      private String Ddo_xt_logtargetoperate_Dropdownoptionstype ;
      private String Ddo_xt_logtargetoperate_Titlecontrolidtoreplace ;
      private String Ddo_xt_logtargetoperate_Sortedstatus ;
      private String Ddo_xt_logtargetoperate_Sortasc ;
      private String Ddo_xt_logtargetoperate_Sortdsc ;
      private String Ddo_xt_logtargetoperate_Searchbuttontext ;
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
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtXT_LogID_Title ;
      private String edtXT_LogUserID_Title ;
      private String edtXT_LogSecUserName_Title ;
      private String edtXT_LogTime_Title ;
      private String edtXT_LogButtonName_Title ;
      private String edtXT_LogType_Title ;
      private String edtXT_LogProviderID_Title ;
      private String edtXT_LogProviderName_Title ;
      private String edtXT_LogTarget_Title ;
      private String edtXT_LogSonTarget_Title ;
      private String edtXT_LogTargetModule_Title ;
      private String edtXT_LogTargetSonModule_Title ;
      private String edtXT_LogDescription_Title ;
      private String subGrid_Header ;
      private String edtavSelect_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_xt_logid_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_xt_logidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_xt_loguserid_Internalname ;
      private String edtavDdo_xt_loguseridtitlecontrolidtoreplace_Internalname ;
      private String Ddo_xt_logsecusername_Internalname ;
      private String edtavDdo_xt_logsecusernametitlecontrolidtoreplace_Internalname ;
      private String Ddo_xt_logtime_Internalname ;
      private String edtavDdo_xt_logtimetitlecontrolidtoreplace_Internalname ;
      private String Ddo_xt_logpage_Internalname ;
      private String edtavDdo_xt_logpagetitlecontrolidtoreplace_Internalname ;
      private String Ddo_xt_logbuttonname_Internalname ;
      private String edtavDdo_xt_logbuttonnametitlecontrolidtoreplace_Internalname ;
      private String Ddo_xt_logtype_Internalname ;
      private String edtavDdo_xt_logtypetitlecontrolidtoreplace_Internalname ;
      private String Ddo_xt_logproviderid_Internalname ;
      private String edtavDdo_xt_logprovideridtitlecontrolidtoreplace_Internalname ;
      private String Ddo_xt_logprovidername_Internalname ;
      private String edtavDdo_xt_logprovidernametitlecontrolidtoreplace_Internalname ;
      private String Ddo_xt_logtarget_Internalname ;
      private String edtavDdo_xt_logtargettitlecontrolidtoreplace_Internalname ;
      private String Ddo_xt_logsontarget_Internalname ;
      private String edtavDdo_xt_logsontargettitlecontrolidtoreplace_Internalname ;
      private String Ddo_xt_logtargetmodule_Internalname ;
      private String edtavDdo_xt_logtargetmoduletitlecontrolidtoreplace_Internalname ;
      private String Ddo_xt_logtargetsonmodule_Internalname ;
      private String edtavDdo_xt_logtargetsonmoduletitlecontrolidtoreplace_Internalname ;
      private String Ddo_xt_logtargetoperate_Internalname ;
      private String edtavDdo_xt_logtargetoperatetitlecontrolidtoreplace_Internalname ;
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
      private String edtavSelect_Internalname ;
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
      private String sGXsfl_12_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavSelect_Jsonclick ;
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
      private bool AV12OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_xt_logid_Includesortasc ;
      private bool Ddo_xt_logid_Includesortdsc ;
      private bool Ddo_xt_logid_Includefilter ;
      private bool Ddo_xt_logid_Includedatalist ;
      private bool Ddo_xt_loguserid_Includesortasc ;
      private bool Ddo_xt_loguserid_Includesortdsc ;
      private bool Ddo_xt_loguserid_Includefilter ;
      private bool Ddo_xt_loguserid_Includedatalist ;
      private bool Ddo_xt_logsecusername_Includesortasc ;
      private bool Ddo_xt_logsecusername_Includesortdsc ;
      private bool Ddo_xt_logsecusername_Includefilter ;
      private bool Ddo_xt_logsecusername_Includedatalist ;
      private bool Ddo_xt_logtime_Includesortasc ;
      private bool Ddo_xt_logtime_Includesortdsc ;
      private bool Ddo_xt_logtime_Includefilter ;
      private bool Ddo_xt_logtime_Includedatalist ;
      private bool Ddo_xt_logpage_Includesortasc ;
      private bool Ddo_xt_logpage_Includesortdsc ;
      private bool Ddo_xt_logpage_Includefilter ;
      private bool Ddo_xt_logpage_Includedatalist ;
      private bool Ddo_xt_logbuttonname_Includesortasc ;
      private bool Ddo_xt_logbuttonname_Includesortdsc ;
      private bool Ddo_xt_logbuttonname_Includefilter ;
      private bool Ddo_xt_logbuttonname_Includedatalist ;
      private bool Ddo_xt_logtype_Includesortasc ;
      private bool Ddo_xt_logtype_Includesortdsc ;
      private bool Ddo_xt_logtype_Includefilter ;
      private bool Ddo_xt_logtype_Includedatalist ;
      private bool Ddo_xt_logproviderid_Includesortasc ;
      private bool Ddo_xt_logproviderid_Includesortdsc ;
      private bool Ddo_xt_logproviderid_Includefilter ;
      private bool Ddo_xt_logproviderid_Includedatalist ;
      private bool Ddo_xt_logprovidername_Includesortasc ;
      private bool Ddo_xt_logprovidername_Includesortdsc ;
      private bool Ddo_xt_logprovidername_Includefilter ;
      private bool Ddo_xt_logprovidername_Includedatalist ;
      private bool Ddo_xt_logtarget_Includesortasc ;
      private bool Ddo_xt_logtarget_Includesortdsc ;
      private bool Ddo_xt_logtarget_Includefilter ;
      private bool Ddo_xt_logtarget_Includedatalist ;
      private bool Ddo_xt_logsontarget_Includesortasc ;
      private bool Ddo_xt_logsontarget_Includesortdsc ;
      private bool Ddo_xt_logsontarget_Includefilter ;
      private bool Ddo_xt_logsontarget_Includedatalist ;
      private bool Ddo_xt_logtargetmodule_Includesortasc ;
      private bool Ddo_xt_logtargetmodule_Includesortdsc ;
      private bool Ddo_xt_logtargetmodule_Includefilter ;
      private bool Ddo_xt_logtargetmodule_Includedatalist ;
      private bool Ddo_xt_logtargetsonmodule_Includesortasc ;
      private bool Ddo_xt_logtargetsonmodule_Includesortdsc ;
      private bool Ddo_xt_logtargetsonmodule_Includefilter ;
      private bool Ddo_xt_logtargetsonmodule_Includedatalist ;
      private bool Ddo_xt_logtargetoperate_Includesortasc ;
      private bool Ddo_xt_logtargetoperate_Includesortdsc ;
      private bool Ddo_xt_logtargetoperate_Includefilter ;
      private bool Ddo_xt_logtargetoperate_Includedatalist ;
      private bool Ddo_xt_logdescription_Includesortasc ;
      private bool Ddo_xt_logdescription_Includesortdsc ;
      private bool Ddo_xt_logdescription_Includefilter ;
      private bool Ddo_xt_logdescription_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_12_Refreshing=false ;
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
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool gx_refresh_fired ;
      private bool AV48Select_IsBlob ;
      private String AV14ddo_XT_LogIDTitleControlIdToReplace ;
      private String AV16ddo_XT_LogUserIDTitleControlIdToReplace ;
      private String AV18ddo_XT_LogSecUserNameTitleControlIdToReplace ;
      private String AV20ddo_XT_LogTimeTitleControlIdToReplace ;
      private String AV22ddo_XT_LogPageTitleControlIdToReplace ;
      private String AV24ddo_XT_LogButtonNameTitleControlIdToReplace ;
      private String AV26ddo_XT_LogTypeTitleControlIdToReplace ;
      private String AV28ddo_XT_LogProviderIDTitleControlIdToReplace ;
      private String AV30ddo_XT_LogProviderNameTitleControlIdToReplace ;
      private String AV32ddo_XT_LogTargetTitleControlIdToReplace ;
      private String AV34ddo_XT_LogSonTargetTitleControlIdToReplace ;
      private String AV36ddo_XT_LogTargetModuleTitleControlIdToReplace ;
      private String AV38ddo_XT_LogTargetSonModuleTitleControlIdToReplace ;
      private String AV40ddo_XT_LogTargetOperateTitleControlIdToReplace ;
      private String AV42ddo_XT_LogDescriptionTitleControlIdToReplace ;
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
      private String AV52Select_GXI ;
      private String AV48Select ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_xt_logid ;
      private GXUserControl ucDdo_xt_loguserid ;
      private GXUserControl ucDdo_xt_logsecusername ;
      private GXUserControl ucDdo_xt_logtime ;
      private GXUserControl ucDdo_xt_logpage ;
      private GXUserControl ucDdo_xt_logbuttonname ;
      private GXUserControl ucDdo_xt_logtype ;
      private GXUserControl ucDdo_xt_logproviderid ;
      private GXUserControl ucDdo_xt_logprovidername ;
      private GXUserControl ucDdo_xt_logtarget ;
      private GXUserControl ucDdo_xt_logsontarget ;
      private GXUserControl ucDdo_xt_logtargetmodule ;
      private GXUserControl ucDdo_xt_logtargetsonmodule ;
      private GXUserControl ucDdo_xt_logtargetoperate ;
      private GXUserControl ucDdo_xt_logdescription ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private long aP0_InOutXT_LogID ;
      private long aP1_InOutXT_LogUserID ;
      private GXCombobox cmbXT_LogPage ;
      private GXCombobox cmbXT_LogTargetOperate ;
      private IDataStoreProvider pr_default ;
      private String[] H004H2_A221XT_LogDescription ;
      private bool[] H004H2_n221XT_LogDescription ;
      private String[] H004H2_A218XT_LogTargetOperate ;
      private bool[] H004H2_n218XT_LogTargetOperate ;
      private String[] H004H2_A222XT_LogTargetSonModule ;
      private bool[] H004H2_n222XT_LogTargetSonModule ;
      private String[] H004H2_A217XT_LogTargetModule ;
      private bool[] H004H2_n217XT_LogTargetModule ;
      private String[] H004H2_A223XT_LogSonTarget ;
      private bool[] H004H2_n223XT_LogSonTarget ;
      private String[] H004H2_A216XT_LogTarget ;
      private bool[] H004H2_n216XT_LogTarget ;
      private String[] H004H2_A219XT_LogProviderName ;
      private bool[] H004H2_n219XT_LogProviderName ;
      private long[] H004H2_A215XT_LogProviderID ;
      private bool[] H004H2_n215XT_LogProviderID ;
      private String[] H004H2_A213XT_LogType ;
      private bool[] H004H2_n213XT_LogType ;
      private String[] H004H2_A177XT_LogButtonName ;
      private bool[] H004H2_n177XT_LogButtonName ;
      private String[] H004H2_A176XT_LogPage ;
      private bool[] H004H2_n176XT_LogPage ;
      private DateTime[] H004H2_A220XT_LogTime ;
      private bool[] H004H2_n220XT_LogTime ;
      private String[] H004H2_A174XT_LogSecUserName ;
      private bool[] H004H2_n174XT_LogSecUserName ;
      private long[] H004H2_A214XT_LogUserID ;
      private bool[] H004H2_n214XT_LogUserID ;
      private long[] H004H2_A173XT_LogID ;
      private long[] H004H3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV13XT_LogIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV15XT_LogUserIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV17XT_LogSecUserNameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV19XT_LogTimeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV21XT_LogPageTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV23XT_LogButtonNameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV25XT_LogTypeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV27XT_LogProviderIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV29XT_LogProviderNameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV31XT_LogTargetTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV33XT_LogSonTargetTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV35XT_LogTargetModuleTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV37XT_LogTargetSonModuleTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV39XT_LogTargetOperateTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV41XT_LogDescriptionTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV43DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class xt_logprompt__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H004H2( IGxContext context ,
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
         sSelectString = " [XT_LogDescription], [XT_LogTargetOperate], [XT_LogTargetSonModule], [XT_LogTargetModule], [XT_LogSonTarget], [XT_LogTarget], [XT_LogProviderName], [XT_LogProviderID], [XT_LogType], [XT_LogButtonName], [XT_LogPage], [XT_LogTime], [XT_LogSecUserName], [XT_LogUserID], [XT_LogID]";
         sFromString = " FROM [XT_Log] WITH (NOLOCK)";
         sOrderString = "";
         if ( ( AV11OrderedBy == 1 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogID]";
         }
         else if ( ( AV11OrderedBy == 1 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogID] DESC";
         }
         else if ( ( AV11OrderedBy == 2 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogUserID]";
         }
         else if ( ( AV11OrderedBy == 2 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogUserID] DESC";
         }
         else if ( ( AV11OrderedBy == 3 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogSecUserName]";
         }
         else if ( ( AV11OrderedBy == 3 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogSecUserName] DESC";
         }
         else if ( ( AV11OrderedBy == 4 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogTime]";
         }
         else if ( ( AV11OrderedBy == 4 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogTime] DESC";
         }
         else if ( ( AV11OrderedBy == 5 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogPage]";
         }
         else if ( ( AV11OrderedBy == 5 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogPage] DESC";
         }
         else if ( ( AV11OrderedBy == 6 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogButtonName]";
         }
         else if ( ( AV11OrderedBy == 6 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogButtonName] DESC";
         }
         else if ( ( AV11OrderedBy == 7 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogType]";
         }
         else if ( ( AV11OrderedBy == 7 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogType] DESC";
         }
         else if ( ( AV11OrderedBy == 8 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogProviderID]";
         }
         else if ( ( AV11OrderedBy == 8 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogProviderID] DESC";
         }
         else if ( ( AV11OrderedBy == 9 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogProviderName]";
         }
         else if ( ( AV11OrderedBy == 9 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogProviderName] DESC";
         }
         else if ( ( AV11OrderedBy == 10 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogTarget]";
         }
         else if ( ( AV11OrderedBy == 10 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogTarget] DESC";
         }
         else if ( ( AV11OrderedBy == 11 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogSonTarget]";
         }
         else if ( ( AV11OrderedBy == 11 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogSonTarget] DESC";
         }
         else if ( ( AV11OrderedBy == 12 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogTargetModule]";
         }
         else if ( ( AV11OrderedBy == 12 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogTargetModule] DESC";
         }
         else if ( ( AV11OrderedBy == 13 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogTargetSonModule]";
         }
         else if ( ( AV11OrderedBy == 13 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogTargetSonModule] DESC";
         }
         else if ( ( AV11OrderedBy == 14 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogTargetOperate]";
         }
         else if ( ( AV11OrderedBy == 14 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogTargetOperate] DESC";
         }
         else if ( ( AV11OrderedBy == 15 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogDescription]";
         }
         else if ( ( AV11OrderedBy == 15 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogDescription] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [XT_LogID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H004H3( IGxContext context ,
                                             short AV11OrderedBy ,
                                             bool AV12OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [XT_Log] WITH (NOLOCK)";
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
         else if ( ( AV11OrderedBy == 8 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 8 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 9 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 9 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 10 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 10 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 11 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 11 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 12 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 12 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 13 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 13 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 14 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 14 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 15 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 15 ) && ( AV12OrderedDsc ) )
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
                     return conditional_H004H2(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
               case 1 :
                     return conditional_H004H3(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
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
          Object[] prmH004H2 ;
          prmH004H2 = new Object[] {
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH004H3 ;
          prmH004H3 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H004H2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH004H2,11,0,true,false )
             ,new CursorDef("H004H3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH004H3,1,0,true,false )
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
