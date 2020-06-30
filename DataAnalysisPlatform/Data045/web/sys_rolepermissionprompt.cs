/*
               File: SYS_RolePermissionPrompt
        Description: 选择SYS_Role Permission
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:16:34.91
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
   public class sys_rolepermissionprompt : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public sys_rolepermissionprompt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public sys_rolepermissionprompt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref Guid aP0_InOutSYS_RolePermissionRoleID ,
                           ref String aP1_InOutSYS_RolePermissionPermissionCode )
      {
         this.AV8InOutSYS_RolePermissionRoleID = aP0_InOutSYS_RolePermissionRoleID;
         this.AV9InOutSYS_RolePermissionPermissionCode = aP1_InOutSYS_RolePermissionPermissionCode;
         executePrivate();
         aP0_InOutSYS_RolePermissionRoleID=this.AV8InOutSYS_RolePermissionRoleID;
         aP1_InOutSYS_RolePermissionPermissionCode=this.AV9InOutSYS_RolePermissionPermissionCode;
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
               AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace = GetNextPar( );
               AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace, AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace) ;
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
               AV8InOutSYS_RolePermissionRoleID = (Guid)(StringUtil.StrToGuid( gxfirstwebparm));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutSYS_RolePermissionRoleID", AV8InOutSYS_RolePermissionRoleID.ToString());
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV9InOutSYS_RolePermissionPermissionCode = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutSYS_RolePermissionPermissionCode", AV9InOutSYS_RolePermissionPermissionCode);
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
            PA8F2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV25Pgmname = "SYS_RolePermissionPrompt";
               context.Gx_err = 0;
               WS8F2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE8F2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022815163498", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("sys_rolepermissionprompt.aspx") + "?" + UrlEncode(AV8InOutSYS_RolePermissionRoleID.ToString()) + "," + UrlEncode(StringUtil.RTrim(AV9InOutSYS_RolePermissionPermissionCode))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV20GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV17DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV17DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vSYS_ROLEPERMISSIONROLEIDTITLEFILTERDATA", AV13SYS_RolePermissionRoleIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vSYS_ROLEPERMISSIONROLEIDTITLEFILTERDATA", AV13SYS_RolePermissionRoleIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vSYS_ROLEPERMISSIONPERMISSIONCODETITLEFILTERDATA", AV15SYS_RolePermissionPermissionCodeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vSYS_ROLEPERMISSIONPERMISSIONCODETITLEFILTERDATA", AV15SYS_RolePermissionPermissionCodeTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vINOUTSYS_ROLEPERMISSIONROLEID", AV8InOutSYS_RolePermissionRoleID.ToString());
         GxWebStd.gx_hidden_field( context, "vINOUTSYS_ROLEPERMISSIONPERMISSIONCODE", AV9InOutSYS_RolePermissionPermissionCode);
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
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONROLEID_Caption", StringUtil.RTrim( Ddo_sys_rolepermissionroleid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONROLEID_Tooltip", StringUtil.RTrim( Ddo_sys_rolepermissionroleid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONROLEID_Cls", StringUtil.RTrim( Ddo_sys_rolepermissionroleid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONROLEID_Dropdownoptionstype", StringUtil.RTrim( Ddo_sys_rolepermissionroleid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONROLEID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_sys_rolepermissionroleid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONROLEID_Includesortasc", StringUtil.BoolToStr( Ddo_sys_rolepermissionroleid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONROLEID_Includesortdsc", StringUtil.BoolToStr( Ddo_sys_rolepermissionroleid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONROLEID_Sortedstatus", StringUtil.RTrim( Ddo_sys_rolepermissionroleid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONROLEID_Includefilter", StringUtil.BoolToStr( Ddo_sys_rolepermissionroleid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONROLEID_Includedatalist", StringUtil.BoolToStr( Ddo_sys_rolepermissionroleid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONROLEID_Sortasc", StringUtil.RTrim( Ddo_sys_rolepermissionroleid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONROLEID_Sortdsc", StringUtil.RTrim( Ddo_sys_rolepermissionroleid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONROLEID_Searchbuttontext", StringUtil.RTrim( Ddo_sys_rolepermissionroleid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Caption", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Tooltip", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Cls", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Dropdownoptionstype", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Includesortasc", StringUtil.BoolToStr( Ddo_sys_rolepermissionpermissioncode_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Includesortdsc", StringUtil.BoolToStr( Ddo_sys_rolepermissionpermissioncode_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Sortedstatus", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Includefilter", StringUtil.BoolToStr( Ddo_sys_rolepermissionpermissioncode_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Includedatalist", StringUtil.BoolToStr( Ddo_sys_rolepermissionpermissioncode_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Sortasc", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Sortdsc", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Searchbuttontext", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONROLEID_Activeeventkey", StringUtil.RTrim( Ddo_sys_rolepermissionroleid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Activeeventkey", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONROLEID_Activeeventkey", StringUtil.RTrim( Ddo_sys_rolepermissionroleid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Activeeventkey", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Activeeventkey));
      }

      protected void RenderHtmlCloseForm8F2( )
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
         return "SYS_RolePermissionPrompt" ;
      }

      public override String GetPgmdesc( )
      {
         return "选择SYS_Role Permission" ;
      }

      protected void WB8F0( )
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtSYS_RolePermissionRoleID_Titleformat == 0 )
               {
                  context.SendWebValue( edtSYS_RolePermissionRoleID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtSYS_RolePermissionRoleID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtSYS_RolePermissionPermissionCode_Titleformat == 0 )
               {
                  context.SendWebValue( edtSYS_RolePermissionPermissionCode_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtSYS_RolePermissionPermissionCode_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV22Select));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavSelect_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A444SYS_RolePermissionRoleID.ToString());
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtSYS_RolePermissionRoleID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSYS_RolePermissionRoleID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A445SYS_RolePermissionPermissionCode);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtSYS_RolePermissionPermissionCode_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSYS_RolePermissionPermissionCode_Titleformat), 4, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV19GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV21GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV20GridPageSize);
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
            ucDdo_sys_rolepermissionroleid.SetProperty("Caption", Ddo_sys_rolepermissionroleid_Caption);
            ucDdo_sys_rolepermissionroleid.SetProperty("Tooltip", Ddo_sys_rolepermissionroleid_Tooltip);
            ucDdo_sys_rolepermissionroleid.SetProperty("Cls", Ddo_sys_rolepermissionroleid_Cls);
            ucDdo_sys_rolepermissionroleid.SetProperty("DropDownOptionsType", Ddo_sys_rolepermissionroleid_Dropdownoptionstype);
            ucDdo_sys_rolepermissionroleid.SetProperty("IncludeSortASC", Ddo_sys_rolepermissionroleid_Includesortasc);
            ucDdo_sys_rolepermissionroleid.SetProperty("IncludeSortDSC", Ddo_sys_rolepermissionroleid_Includesortdsc);
            ucDdo_sys_rolepermissionroleid.SetProperty("IncludeFilter", Ddo_sys_rolepermissionroleid_Includefilter);
            ucDdo_sys_rolepermissionroleid.SetProperty("IncludeDataList", Ddo_sys_rolepermissionroleid_Includedatalist);
            ucDdo_sys_rolepermissionroleid.SetProperty("SortASC", Ddo_sys_rolepermissionroleid_Sortasc);
            ucDdo_sys_rolepermissionroleid.SetProperty("SortDSC", Ddo_sys_rolepermissionroleid_Sortdsc);
            ucDdo_sys_rolepermissionroleid.SetProperty("SearchButtonText", Ddo_sys_rolepermissionroleid_Searchbuttontext);
            ucDdo_sys_rolepermissionroleid.SetProperty("DropDownOptionsTitleSettingsIcons", AV17DDO_TitleSettingsIcons);
            ucDdo_sys_rolepermissionroleid.SetProperty("DropDownOptionsData", AV13SYS_RolePermissionRoleIDTitleFilterData);
            ucDdo_sys_rolepermissionroleid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_sys_rolepermissionroleid_Internalname, "DDO_SYS_ROLEPERMISSIONROLEIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_sys_rolepermissionroleidtitlecontrolidtoreplace_Internalname, AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,24);\"", 0, edtavDdo_sys_rolepermissionroleidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_SYS_RolePermissionPrompt.htm");
            /* User Defined Control */
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("Caption", Ddo_sys_rolepermissionpermissioncode_Caption);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("Tooltip", Ddo_sys_rolepermissionpermissioncode_Tooltip);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("Cls", Ddo_sys_rolepermissionpermissioncode_Cls);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("DropDownOptionsType", Ddo_sys_rolepermissionpermissioncode_Dropdownoptionstype);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("IncludeSortASC", Ddo_sys_rolepermissionpermissioncode_Includesortasc);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("IncludeSortDSC", Ddo_sys_rolepermissionpermissioncode_Includesortdsc);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("IncludeFilter", Ddo_sys_rolepermissionpermissioncode_Includefilter);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("IncludeDataList", Ddo_sys_rolepermissionpermissioncode_Includedatalist);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("SortASC", Ddo_sys_rolepermissionpermissioncode_Sortasc);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("SortDSC", Ddo_sys_rolepermissionpermissioncode_Sortdsc);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("SearchButtonText", Ddo_sys_rolepermissionpermissioncode_Searchbuttontext);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("DropDownOptionsTitleSettingsIcons", AV17DDO_TitleSettingsIcons);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("DropDownOptionsData", AV15SYS_RolePermissionPermissionCodeTitleFilterData);
            ucDdo_sys_rolepermissionpermissioncode.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_sys_rolepermissionpermissioncode_Internalname, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_sys_rolepermissionpermissioncodetitlecontrolidtoreplace_Internalname, AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,26);\"", 0, edtavDdo_sys_rolepermissionpermissioncodetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_SYS_RolePermissionPrompt.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,28);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_SYS_RolePermissionPrompt.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV12OrderedDsc), StringUtil.BoolToStr( AV12OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_SYS_RolePermissionPrompt.htm");
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

      protected void START8F2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "选择SYS_Role Permission", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP8F0( ) ;
      }

      protected void WS8F2( )
      {
         START8F2( ) ;
         EVT8F2( ) ;
      }

      protected void EVT8F2( )
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
                           E118F2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E128F2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_SYS_ROLEPERMISSIONROLEID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E138F2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E148F2 ();
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
                           AV22Select = cgiGet( edtavSelect_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV22Select)) ? AV26Select_GXI : context.convertURL( context.PathToRelativeUrl( AV22Select))), !bGXsfl_12_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "SrcSet", context.GetImageSrcSet( AV22Select), true);
                           A444SYS_RolePermissionRoleID = (Guid)(StringUtil.StrToGuid( cgiGet( edtSYS_RolePermissionRoleID_Internalname)));
                           A445SYS_RolePermissionPermissionCode = cgiGet( edtSYS_RolePermissionPermissionCode_Internalname);
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E158F2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E168F2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E178F2 ();
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
                                       E188F2 ();
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

      protected void WE8F2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm8F2( ) ;
            }
         }
      }

      protected void PA8F2( )
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
               GX_FocusControl = edtavDdo_sys_rolepermissionroleidtitlecontrolidtoreplace_Internalname;
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
                                       String AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace ,
                                       String AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF8F2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_SYS_ROLEPERMISSIONROLEID", GetSecureSignedToken( "", A444SYS_RolePermissionRoleID, context));
         GxWebStd.gx_hidden_field( context, "SYS_ROLEPERMISSIONROLEID", A444SYS_RolePermissionRoleID.ToString());
         GxWebStd.gx_hidden_field( context, "gxhash_SYS_ROLEPERMISSIONPERMISSIONCODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A445SYS_RolePermissionPermissionCode, "")), context));
         GxWebStd.gx_hidden_field( context, "SYS_ROLEPERMISSIONPERMISSIONCODE", A445SYS_RolePermissionPermissionCode);
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
         RF8F2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV25Pgmname = "SYS_RolePermissionPrompt";
         context.Gx_err = 0;
      }

      protected void RF8F2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 12;
         /* Execute user event: Refresh */
         E168F2 ();
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
            pr_datastore1.dynParam(0, new Object[]{ new Object[]{
                                                 AV11OrderedBy ,
                                                 AV12OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            /* Using cursor H008F2 */
            pr_datastore1.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_12_idx = 1;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
            while ( ( (pr_datastore1.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A445SYS_RolePermissionPermissionCode = H008F2_A445SYS_RolePermissionPermissionCode[0];
               A444SYS_RolePermissionRoleID = (Guid)((Guid)(H008F2_A444SYS_RolePermissionRoleID[0]));
               E178F2 ();
               pr_datastore1.readNext(0);
            }
            GRID_nEOF = (short)(((pr_datastore1.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_datastore1.close(0);
            wbEnd = 12;
            WB8F0( ) ;
         }
         bGXsfl_12_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes8F2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_SYS_ROLEPERMISSIONROLEID"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, A444SYS_RolePermissionRoleID, context));
         GxWebStd.gx_hidden_field( context, "gxhash_SYS_ROLEPERMISSIONPERMISSIONCODE"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, StringUtil.RTrim( context.localUtil.Format( A445SYS_RolePermissionPermissionCode, "")), context));
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
         pr_datastore1.dynParam(1, new Object[]{ new Object[]{
                                              AV11OrderedBy ,
                                              AV12OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         /* Using cursor H008F3 */
         pr_datastore1.execute(1);
         GRID_nRecordCount = H008F3_AGRID_nRecordCount[0];
         pr_datastore1.close(1);
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace, AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace, AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace, AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace, AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace, AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP8F0( )
      {
         /* Before Start, stand alone formulas. */
         AV25Pgmname = "SYS_RolePermissionPrompt";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E158F2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV17DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vSYS_ROLEPERMISSIONROLEIDTITLEFILTERDATA"), AV13SYS_RolePermissionRoleIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vSYS_ROLEPERMISSIONPERMISSIONCODETITLEFILTERDATA"), AV15SYS_RolePermissionPermissionCodeTitleFilterData);
            /* Read variables values. */
            AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace = cgiGet( edtavDdo_sys_rolepermissionroleidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace", AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace);
            AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace = cgiGet( edtavDdo_sys_rolepermissionpermissioncodetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace", AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace);
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
            AV19GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV21GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV20GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_sys_rolepermissionroleid_Caption = cgiGet( "DDO_SYS_ROLEPERMISSIONROLEID_Caption");
            Ddo_sys_rolepermissionroleid_Tooltip = cgiGet( "DDO_SYS_ROLEPERMISSIONROLEID_Tooltip");
            Ddo_sys_rolepermissionroleid_Cls = cgiGet( "DDO_SYS_ROLEPERMISSIONROLEID_Cls");
            Ddo_sys_rolepermissionroleid_Dropdownoptionstype = cgiGet( "DDO_SYS_ROLEPERMISSIONROLEID_Dropdownoptionstype");
            Ddo_sys_rolepermissionroleid_Titlecontrolidtoreplace = cgiGet( "DDO_SYS_ROLEPERMISSIONROLEID_Titlecontrolidtoreplace");
            Ddo_sys_rolepermissionroleid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_SYS_ROLEPERMISSIONROLEID_Includesortasc"));
            Ddo_sys_rolepermissionroleid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_SYS_ROLEPERMISSIONROLEID_Includesortdsc"));
            Ddo_sys_rolepermissionroleid_Sortedstatus = cgiGet( "DDO_SYS_ROLEPERMISSIONROLEID_Sortedstatus");
            Ddo_sys_rolepermissionroleid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_SYS_ROLEPERMISSIONROLEID_Includefilter"));
            Ddo_sys_rolepermissionroleid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_SYS_ROLEPERMISSIONROLEID_Includedatalist"));
            Ddo_sys_rolepermissionroleid_Sortasc = cgiGet( "DDO_SYS_ROLEPERMISSIONROLEID_Sortasc");
            Ddo_sys_rolepermissionroleid_Sortdsc = cgiGet( "DDO_SYS_ROLEPERMISSIONROLEID_Sortdsc");
            Ddo_sys_rolepermissionroleid_Searchbuttontext = cgiGet( "DDO_SYS_ROLEPERMISSIONROLEID_Searchbuttontext");
            Ddo_sys_rolepermissionpermissioncode_Caption = cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Caption");
            Ddo_sys_rolepermissionpermissioncode_Tooltip = cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Tooltip");
            Ddo_sys_rolepermissionpermissioncode_Cls = cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Cls");
            Ddo_sys_rolepermissionpermissioncode_Dropdownoptionstype = cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Dropdownoptionstype");
            Ddo_sys_rolepermissionpermissioncode_Titlecontrolidtoreplace = cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Titlecontrolidtoreplace");
            Ddo_sys_rolepermissionpermissioncode_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Includesortasc"));
            Ddo_sys_rolepermissionpermissioncode_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Includesortdsc"));
            Ddo_sys_rolepermissionpermissioncode_Sortedstatus = cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Sortedstatus");
            Ddo_sys_rolepermissionpermissioncode_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Includefilter"));
            Ddo_sys_rolepermissionpermissioncode_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Includedatalist"));
            Ddo_sys_rolepermissionpermissioncode_Sortasc = cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Sortasc");
            Ddo_sys_rolepermissionpermissioncode_Sortdsc = cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Sortdsc");
            Ddo_sys_rolepermissionpermissioncode_Searchbuttontext = cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_sys_rolepermissionroleid_Activeeventkey = cgiGet( "DDO_SYS_ROLEPERMISSIONROLEID_Activeeventkey");
            Ddo_sys_rolepermissionpermissioncode_Activeeventkey = cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Activeeventkey");
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
         E158F2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E158F2( )
      {
         /* Start Routine */
         GXt_boolean1 = AV5IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Manager", out  GXt_boolean1) ;
         AV5IsAuthorized = GXt_boolean1;
         if ( ! AV5IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV25Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         divTablemain_Height = 493;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTablemain_Internalname, "Height", StringUtil.LTrim( StringUtil.Str( (decimal)(divTablemain_Height), 9, 0)), true);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_sys_rolepermissionroleid_Titlecontrolidtoreplace = subGrid_Internalname+"_SYS_RolePermissionRoleID";
         ucDdo_sys_rolepermissionroleid.SendProperty(context, "", false, Ddo_sys_rolepermissionroleid_Internalname, "TitleControlIdToReplace", Ddo_sys_rolepermissionroleid_Titlecontrolidtoreplace);
         AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace = Ddo_sys_rolepermissionroleid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace", AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace);
         edtavDdo_sys_rolepermissionroleidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_sys_rolepermissionroleidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_sys_rolepermissionroleidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_sys_rolepermissionpermissioncode_Titlecontrolidtoreplace = subGrid_Internalname+"_SYS_RolePermissionPermissionCode";
         ucDdo_sys_rolepermissionpermissioncode.SendProperty(context, "", false, Ddo_sys_rolepermissionpermissioncode_Internalname, "TitleControlIdToReplace", Ddo_sys_rolepermissionpermissioncode_Titlecontrolidtoreplace);
         AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace = Ddo_sys_rolepermissionpermissioncode_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace", AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace);
         edtavDdo_sys_rolepermissionpermissioncodetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_sys_rolepermissionpermissioncodetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_sys_rolepermissionpermissioncodetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "选择SYS_Role Permission";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV17DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV17DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E168F2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV13SYS_RolePermissionRoleIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15SYS_RolePermissionPermissionCodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         edtSYS_RolePermissionRoleID_Titleformat = 2;
         edtSYS_RolePermissionRoleID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Role ID", AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_RolePermissionRoleID_Internalname, "Title", edtSYS_RolePermissionRoleID_Title, !bGXsfl_12_Refreshing);
         edtSYS_RolePermissionPermissionCode_Titleformat = 2;
         edtSYS_RolePermissionPermissionCode_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Permission Code", AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_RolePermissionPermissionCode_Internalname, "Title", edtSYS_RolePermissionPermissionCode_Title, !bGXsfl_12_Refreshing);
         AV19GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19GridCurrentPage), 10, 0)));
         AV20GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20GridPageSize), 10, 0)));
         AV21GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13SYS_RolePermissionRoleIDTitleFilterData", AV13SYS_RolePermissionRoleIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15SYS_RolePermissionPermissionCodeTitleFilterData", AV15SYS_RolePermissionPermissionCodeTitleFilterData);
      }

      protected void E118F2( )
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
            AV18PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV18PageToGo) ;
         }
      }

      protected void E128F2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E138F2( )
      {
         /* Ddo_sys_rolepermissionroleid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_sys_rolepermissionroleid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_sys_rolepermissionroleid_Sortedstatus = "ASC";
            ucDdo_sys_rolepermissionroleid.SendProperty(context, "", false, Ddo_sys_rolepermissionroleid_Internalname, "SortedStatus", Ddo_sys_rolepermissionroleid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_sys_rolepermissionroleid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_sys_rolepermissionroleid_Sortedstatus = "DSC";
            ucDdo_sys_rolepermissionroleid.SendProperty(context, "", false, Ddo_sys_rolepermissionroleid_Internalname, "SortedStatus", Ddo_sys_rolepermissionroleid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13SYS_RolePermissionRoleIDTitleFilterData", AV13SYS_RolePermissionRoleIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15SYS_RolePermissionPermissionCodeTitleFilterData", AV15SYS_RolePermissionPermissionCodeTitleFilterData);
      }

      protected void E148F2( )
      {
         /* Ddo_sys_rolepermissionpermissioncode_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_sys_rolepermissionpermissioncode_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_sys_rolepermissionpermissioncode_Sortedstatus = "ASC";
            ucDdo_sys_rolepermissionpermissioncode.SendProperty(context, "", false, Ddo_sys_rolepermissionpermissioncode_Internalname, "SortedStatus", Ddo_sys_rolepermissionpermissioncode_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_sys_rolepermissionpermissioncode_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_sys_rolepermissionpermissioncode_Sortedstatus = "DSC";
            ucDdo_sys_rolepermissionpermissioncode.SendProperty(context, "", false, Ddo_sys_rolepermissionpermissioncode_Internalname, "SortedStatus", Ddo_sys_rolepermissionpermissioncode_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13SYS_RolePermissionRoleIDTitleFilterData", AV13SYS_RolePermissionRoleIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15SYS_RolePermissionPermissionCodeTitleFilterData", AV15SYS_RolePermissionPermissionCodeTitleFilterData);
      }

      private void E178F2( )
      {
         /* Grid_Load Routine */
         AV22Select = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSelect_Internalname, AV22Select);
         AV26Select_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
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
         E188F2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E188F2( )
      {
         /* Enter Routine */
         AV8InOutSYS_RolePermissionRoleID = (Guid)(A444SYS_RolePermissionRoleID);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutSYS_RolePermissionRoleID", AV8InOutSYS_RolePermissionRoleID.ToString());
         AV9InOutSYS_RolePermissionPermissionCode = A445SYS_RolePermissionPermissionCode;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutSYS_RolePermissionPermissionCode", AV9InOutSYS_RolePermissionPermissionCode);
         context.setWebReturnParms(new Object[] {(Guid)AV8InOutSYS_RolePermissionRoleID,(String)AV9InOutSYS_RolePermissionPermissionCode});
         context.setWebReturnParmsMetadata(new Object[] {"AV8InOutSYS_RolePermissionRoleID","AV9InOutSYS_RolePermissionPermissionCode"});
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
         AV8InOutSYS_RolePermissionRoleID = (Guid)((Guid)getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutSYS_RolePermissionRoleID", AV8InOutSYS_RolePermissionRoleID.ToString());
         AV9InOutSYS_RolePermissionPermissionCode = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutSYS_RolePermissionPermissionCode", AV9InOutSYS_RolePermissionPermissionCode);
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
         PA8F2( ) ;
         WS8F2( ) ;
         WE8F2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022815163924", true);
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
         context.AddJavascriptSource("sys_rolepermissionprompt.js", "?202022815163924", false);
         context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false);
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
         edtSYS_RolePermissionRoleID_Internalname = "SYS_ROLEPERMISSIONROLEID_"+sGXsfl_12_idx;
         edtSYS_RolePermissionPermissionCode_Internalname = "SYS_ROLEPERMISSIONPERMISSIONCODE_"+sGXsfl_12_idx;
      }

      protected void SubsflControlProps_fel_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_fel_idx;
         edtSYS_RolePermissionRoleID_Internalname = "SYS_ROLEPERMISSIONROLEID_"+sGXsfl_12_fel_idx;
         edtSYS_RolePermissionPermissionCode_Internalname = "SYS_ROLEPERMISSIONPERMISSIONCODE_"+sGXsfl_12_fel_idx;
      }

      protected void sendrow_122( )
      {
         SubsflControlProps_122( ) ;
         WB8F0( ) ;
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
            AV22Select_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV22Select))&&String.IsNullOrEmpty(StringUtil.RTrim( AV26Select_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV22Select)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV22Select)) ? AV26Select_GXI : context.PathToRelativeUrl( AV22Select));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSelect_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSelect_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSelect_Jsonclick,"'"+""+"'"+",false,"+"'"+"EENTER."+sGXsfl_12_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV22Select_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSYS_RolePermissionRoleID_Internalname,A444SYS_RolePermissionRoleID.ToString(),A444SYS_RolePermissionRoleID.ToString(),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSYS_RolePermissionRoleID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)36,(short)0,(short)0,(short)12,(short)1,(short)0,(short)0,(bool)true,(String)"",(String)"",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSYS_RolePermissionPermissionCode_Internalname,(String)A445SYS_RolePermissionPermissionCode,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSYS_RolePermissionPermissionCode_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)64,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes8F2( ) ;
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
         edtSYS_RolePermissionRoleID_Internalname = "SYS_ROLEPERMISSIONROLEID";
         edtSYS_RolePermissionPermissionCode_Internalname = "SYS_ROLEPERMISSIONPERMISSIONCODE";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_sys_rolepermissionroleid_Internalname = "DDO_SYS_ROLEPERMISSIONROLEID";
         edtavDdo_sys_rolepermissionroleidtitlecontrolidtoreplace_Internalname = "vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE";
         Ddo_sys_rolepermissionpermissioncode_Internalname = "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE";
         edtavDdo_sys_rolepermissionpermissioncodetitlecontrolidtoreplace_Internalname = "vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE";
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
         edtSYS_RolePermissionPermissionCode_Jsonclick = "";
         edtSYS_RolePermissionRoleID_Jsonclick = "";
         edtavSelect_Jsonclick = "";
         edtavSelect_Visible = -1;
         edtavSelect_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_sys_rolepermissionpermissioncodetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_sys_rolepermissionroleidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavSelect_Tooltiptext = "选择";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtSYS_RolePermissionPermissionCode_Titleformat = 0;
         edtSYS_RolePermissionPermissionCode_Title = "Permission Code";
         edtSYS_RolePermissionRoleID_Titleformat = 0;
         edtSYS_RolePermissionRoleID_Title = "Role ID";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         divTablemain_Height = 0;
         Ddo_sys_rolepermissionpermissioncode_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_sys_rolepermissionpermissioncode_Sortdsc = "WWP_TSSortDSC";
         Ddo_sys_rolepermissionpermissioncode_Sortasc = "WWP_TSSortASC";
         Ddo_sys_rolepermissionpermissioncode_Includedatalist = Convert.ToBoolean( 0);
         Ddo_sys_rolepermissionpermissioncode_Includefilter = Convert.ToBoolean( 0);
         Ddo_sys_rolepermissionpermissioncode_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_sys_rolepermissionpermissioncode_Includesortasc = Convert.ToBoolean( -1);
         Ddo_sys_rolepermissionpermissioncode_Titlecontrolidtoreplace = "";
         Ddo_sys_rolepermissionpermissioncode_Dropdownoptionstype = "GridTitleSettings";
         Ddo_sys_rolepermissionpermissioncode_Cls = "ColumnSettings";
         Ddo_sys_rolepermissionpermissioncode_Tooltip = "WWP_TSColumnOptions";
         Ddo_sys_rolepermissionpermissioncode_Caption = "";
         Ddo_sys_rolepermissionroleid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_sys_rolepermissionroleid_Sortdsc = "WWP_TSSortDSC";
         Ddo_sys_rolepermissionroleid_Sortasc = "WWP_TSSortASC";
         Ddo_sys_rolepermissionroleid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_sys_rolepermissionroleid_Includefilter = Convert.ToBoolean( 0);
         Ddo_sys_rolepermissionroleid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_sys_rolepermissionroleid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_sys_rolepermissionroleid_Titlecontrolidtoreplace = "";
         Ddo_sys_rolepermissionroleid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_sys_rolepermissionroleid_Cls = "ColumnSettings";
         Ddo_sys_rolepermissionroleid_Tooltip = "WWP_TSColumnOptions";
         Ddo_sys_rolepermissionroleid_Caption = "";
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
         Form.Caption = "选择SYS_Role Permission";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV13SYS_RolePermissionRoleIDTitleFilterData',fld:'vSYS_ROLEPERMISSIONROLEIDTITLEFILTERDATA',pic:''},{av:'AV15SYS_RolePermissionPermissionCodeTitleFilterData',fld:'vSYS_ROLEPERMISSIONPERMISSIONCODETITLEFILTERDATA',pic:''},{av:'edtSYS_RolePermissionRoleID_Titleformat',ctrl:'SYS_ROLEPERMISSIONROLEID',prop:'Titleformat'},{av:'edtSYS_RolePermissionRoleID_Title',ctrl:'SYS_ROLEPERMISSIONROLEID',prop:'Title'},{av:'edtSYS_RolePermissionPermissionCode_Titleformat',ctrl:'SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'Titleformat'},{av:'edtSYS_RolePermissionPermissionCode_Title',ctrl:'SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'Title'},{av:'AV19GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV20GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV21GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E118F2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E128F2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_SYS_ROLEPERMISSIONROLEID.ONOPTIONCLICKED","{handler:'E138F2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_sys_rolepermissionroleid_Activeeventkey',ctrl:'DDO_SYS_ROLEPERMISSIONROLEID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_SYS_ROLEPERMISSIONROLEID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_sys_rolepermissionroleid_Sortedstatus',ctrl:'DDO_SYS_ROLEPERMISSIONROLEID',prop:'SortedStatus'},{av:'AV13SYS_RolePermissionRoleIDTitleFilterData',fld:'vSYS_ROLEPERMISSIONROLEIDTITLEFILTERDATA',pic:''},{av:'AV15SYS_RolePermissionPermissionCodeTitleFilterData',fld:'vSYS_ROLEPERMISSIONPERMISSIONCODETITLEFILTERDATA',pic:''},{av:'edtSYS_RolePermissionRoleID_Titleformat',ctrl:'SYS_ROLEPERMISSIONROLEID',prop:'Titleformat'},{av:'edtSYS_RolePermissionRoleID_Title',ctrl:'SYS_ROLEPERMISSIONROLEID',prop:'Title'},{av:'edtSYS_RolePermissionPermissionCode_Titleformat',ctrl:'SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'Titleformat'},{av:'edtSYS_RolePermissionPermissionCode_Title',ctrl:'SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'Title'},{av:'AV19GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV20GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV21GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_SYS_ROLEPERMISSIONPERMISSIONCODE.ONOPTIONCLICKED","{handler:'E148F2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_sys_rolepermissionpermissioncode_Activeeventkey',ctrl:'DDO_SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_SYS_ROLEPERMISSIONPERMISSIONCODE.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_sys_rolepermissionpermissioncode_Sortedstatus',ctrl:'DDO_SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'SortedStatus'},{av:'AV13SYS_RolePermissionRoleIDTitleFilterData',fld:'vSYS_ROLEPERMISSIONROLEIDTITLEFILTERDATA',pic:''},{av:'AV15SYS_RolePermissionPermissionCodeTitleFilterData',fld:'vSYS_ROLEPERMISSIONPERMISSIONCODETITLEFILTERDATA',pic:''},{av:'edtSYS_RolePermissionRoleID_Titleformat',ctrl:'SYS_ROLEPERMISSIONROLEID',prop:'Titleformat'},{av:'edtSYS_RolePermissionRoleID_Title',ctrl:'SYS_ROLEPERMISSIONROLEID',prop:'Title'},{av:'edtSYS_RolePermissionPermissionCode_Titleformat',ctrl:'SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'Titleformat'},{av:'edtSYS_RolePermissionPermissionCode_Title',ctrl:'SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'Title'},{av:'AV19GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV20GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV21GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E178F2',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV22Select',fld:'vSELECT',pic:''},{av:'edtavSelect_Tooltiptext',ctrl:'vSELECT',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E188F2',iparms:[{av:'A444SYS_RolePermissionRoleID',fld:'SYS_ROLEPERMISSIONROLEID',pic:'',hsh:true},{av:'A445SYS_RolePermissionPermissionCode',fld:'SYS_ROLEPERMISSIONPERMISSIONCODE',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV8InOutSYS_RolePermissionRoleID',fld:'vINOUTSYS_ROLEPERMISSIONROLEID',pic:''},{av:'AV9InOutSYS_RolePermissionPermissionCode',fld:'vINOUTSYS_ROLEPERMISSIONPERMISSIONCODE',pic:''}]}");
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
         wcpOAV8InOutSYS_RolePermissionRoleID = (Guid)(Guid.Empty);
         wcpOAV9InOutSYS_RolePermissionPermissionCode = "";
         Gridpaginationbar_Selectedpage = "";
         Ddo_sys_rolepermissionroleid_Activeeventkey = "";
         Ddo_sys_rolepermissionpermissioncode_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace = "";
         AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace = "";
         GXKey = "";
         AV25Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV17DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV13SYS_RolePermissionRoleIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15SYS_RolePermissionPermissionCodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_sys_rolepermissionroleid_Sortedstatus = "";
         Ddo_sys_rolepermissionpermissioncode_Sortedstatus = "";
         GX_FocusControl = "";
         sPrefix = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV22Select = "";
         A444SYS_RolePermissionRoleID = (Guid)(Guid.Empty);
         A445SYS_RolePermissionPermissionCode = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_sys_rolepermissionroleid = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_sys_rolepermissionpermissioncode = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV26Select_GXI = "";
         scmdbuf = "";
         H008F2_A445SYS_RolePermissionPermissionCode = new String[] {""} ;
         H008F2_A444SYS_RolePermissionRoleID = new Guid[] {Guid.Empty} ;
         H008F3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.sys_rolepermissionprompt__datastore1(),
            new Object[][] {
                new Object[] {
               H008F2_A445SYS_RolePermissionPermissionCode, H008F2_A444SYS_RolePermissionRoleID
               }
               , new Object[] {
               H008F3_AGRID_nRecordCount
               }
            }
         );
         AV25Pgmname = "SYS_RolePermissionPrompt";
         /* GeneXus formulas. */
         AV25Pgmname = "SYS_RolePermissionPrompt";
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
      private short edtSYS_RolePermissionRoleID_Titleformat ;
      private short edtSYS_RolePermissionPermissionCode_Titleformat ;
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
      private int edtavDdo_sys_rolepermissionroleidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_sys_rolepermissionpermissioncodetitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV18PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavSelect_Enabled ;
      private int edtavSelect_Visible ;
      private long GRID_nFirstRecordOnPage ;
      private long AV19GridCurrentPage ;
      private long AV21GridRecordCount ;
      private long AV20GridPageSize ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_sys_rolepermissionroleid_Activeeventkey ;
      private String Ddo_sys_rolepermissionpermissioncode_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_12_idx="0001" ;
      private String GXKey ;
      private String AV25Pgmname ;
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
      private String Ddo_sys_rolepermissionroleid_Caption ;
      private String Ddo_sys_rolepermissionroleid_Tooltip ;
      private String Ddo_sys_rolepermissionroleid_Cls ;
      private String Ddo_sys_rolepermissionroleid_Dropdownoptionstype ;
      private String Ddo_sys_rolepermissionroleid_Titlecontrolidtoreplace ;
      private String Ddo_sys_rolepermissionroleid_Sortedstatus ;
      private String Ddo_sys_rolepermissionroleid_Sortasc ;
      private String Ddo_sys_rolepermissionroleid_Sortdsc ;
      private String Ddo_sys_rolepermissionroleid_Searchbuttontext ;
      private String Ddo_sys_rolepermissionpermissioncode_Caption ;
      private String Ddo_sys_rolepermissionpermissioncode_Tooltip ;
      private String Ddo_sys_rolepermissionpermissioncode_Cls ;
      private String Ddo_sys_rolepermissionpermissioncode_Dropdownoptionstype ;
      private String Ddo_sys_rolepermissionpermissioncode_Titlecontrolidtoreplace ;
      private String Ddo_sys_rolepermissionpermissioncode_Sortedstatus ;
      private String Ddo_sys_rolepermissionpermissioncode_Sortasc ;
      private String Ddo_sys_rolepermissionpermissioncode_Sortdsc ;
      private String Ddo_sys_rolepermissionpermissioncode_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtSYS_RolePermissionRoleID_Title ;
      private String edtSYS_RolePermissionPermissionCode_Title ;
      private String subGrid_Header ;
      private String edtavSelect_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_sys_rolepermissionroleid_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_sys_rolepermissionroleidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_sys_rolepermissionpermissioncode_Internalname ;
      private String edtavDdo_sys_rolepermissionpermissioncodetitlecontrolidtoreplace_Internalname ;
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
      private String edtSYS_RolePermissionRoleID_Internalname ;
      private String edtSYS_RolePermissionPermissionCode_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_12_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavSelect_Jsonclick ;
      private String ROClassString ;
      private String edtSYS_RolePermissionRoleID_Jsonclick ;
      private String edtSYS_RolePermissionPermissionCode_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV12OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_sys_rolepermissionroleid_Includesortasc ;
      private bool Ddo_sys_rolepermissionroleid_Includesortdsc ;
      private bool Ddo_sys_rolepermissionroleid_Includefilter ;
      private bool Ddo_sys_rolepermissionroleid_Includedatalist ;
      private bool Ddo_sys_rolepermissionpermissioncode_Includesortasc ;
      private bool Ddo_sys_rolepermissionpermissioncode_Includesortdsc ;
      private bool Ddo_sys_rolepermissionpermissioncode_Includefilter ;
      private bool Ddo_sys_rolepermissionpermissioncode_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_12_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool gx_refresh_fired ;
      private bool AV22Select_IsBlob ;
      private String AV9InOutSYS_RolePermissionPermissionCode ;
      private String wcpOAV9InOutSYS_RolePermissionPermissionCode ;
      private String AV14ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace ;
      private String AV16ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace ;
      private String A445SYS_RolePermissionPermissionCode ;
      private String AV26Select_GXI ;
      private String AV22Select ;
      private Guid AV8InOutSYS_RolePermissionRoleID ;
      private Guid wcpOAV8InOutSYS_RolePermissionRoleID ;
      private Guid A444SYS_RolePermissionRoleID ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_sys_rolepermissionroleid ;
      private GXUserControl ucDdo_sys_rolepermissionpermissioncode ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private Guid aP0_InOutSYS_RolePermissionRoleID ;
      private String aP1_InOutSYS_RolePermissionPermissionCode ;
      private IDataStoreProvider pr_datastore1 ;
      private String[] H008F2_A445SYS_RolePermissionPermissionCode ;
      private Guid[] H008F2_A444SYS_RolePermissionRoleID ;
      private long[] H008F3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV13SYS_RolePermissionRoleIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV15SYS_RolePermissionPermissionCodeTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV17DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class sys_rolepermissionprompt__datastore1 : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H008F2( IGxContext context ,
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
         sSelectString = " [PermissionCode], [RoleID]";
         sFromString = " FROM [SYS_RolePermission] WITH (NOLOCK)";
         sOrderString = "";
         if ( ( AV11OrderedBy == 1 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [RoleID]";
         }
         else if ( ( AV11OrderedBy == 1 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [RoleID] DESC";
         }
         else if ( ( AV11OrderedBy == 2 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [PermissionCode]";
         }
         else if ( ( AV11OrderedBy == 2 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [PermissionCode] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [RoleID], [PermissionCode]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H008F3( IGxContext context ,
                                             short AV11OrderedBy ,
                                             bool AV12OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [SYS_RolePermission] WITH (NOLOCK)";
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
                     return conditional_H008F2(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
               case 1 :
                     return conditional_H008F3(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
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
          Object[] prmH008F2 ;
          prmH008F2 = new Object[] {
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH008F3 ;
          prmH008F3 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H008F2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH008F2,11,0,true,false )
             ,new CursorDef("H008F3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH008F3,1,0,true,false )
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
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
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

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

}
