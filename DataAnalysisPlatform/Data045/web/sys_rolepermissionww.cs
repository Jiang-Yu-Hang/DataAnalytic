/*
               File: SYS_RolePermissionWW
        Description:  SYS_Role Permission
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:16:37.52
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
   public class sys_rolepermissionww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public sys_rolepermissionww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public sys_rolepermissionww( IGxContext context )
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
               nRC_GXsfl_35 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_35_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_35_idx = GetNextPar( );
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
               AV34SYS_RolePermissionPermissionCode = GetNextPar( );
               AV13OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV14OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV20TFSYS_RolePermissionPermissionCode = GetNextPar( );
               AV21TFSYS_RolePermissionPermissionCode_Sel = GetNextPar( );
               AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace = GetNextPar( );
               AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace = GetNextPar( );
               AV51Pgmname = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV34SYS_RolePermissionPermissionCode, AV13OrderedBy, AV14OrderedDsc, AV20TFSYS_RolePermissionPermissionCode, AV21TFSYS_RolePermissionPermissionCode_Sel, AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace, AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace, AV51Pgmname) ;
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
         PA8D2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START8D2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022815163766", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("sys_rolepermissionww.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vSYS_ROLEPERMISSIONPERMISSIONCODE", AV34SYS_RolePermissionPermissionCode);
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV14OrderedDsc));
         GxWebStd.gx_hidden_field( context, "GXH_vTFSYS_ROLEPERMISSIONPERMISSIONCODE", AV20TFSYS_RolePermissionPermissionCode);
         GxWebStd.gx_hidden_field( context, "GXH_vTFSYS_ROLEPERMISSIONPERMISSIONCODE_SEL", AV21TFSYS_RolePermissionPermissionCode_Sel);
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_35", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_35), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV27GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV26GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV23DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV23DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vSYS_ROLEPERMISSIONROLEIDTITLEFILTERDATA", AV17SYS_RolePermissionRoleIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vSYS_ROLEPERMISSIONROLEIDTITLEFILTERDATA", AV17SYS_RolePermissionRoleIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vSYS_ROLEPERMISSIONPERMISSIONCODETITLEFILTERDATA", AV19SYS_RolePermissionPermissionCodeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vSYS_ROLEPERMISSIONPERMISSIONCODETITLEFILTERDATA", AV19SYS_RolePermissionPermissionCodeTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV51Pgmname));
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
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Filteredtext_set", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Selectedvalue_set", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Dropdownoptionstype", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Includesortasc", StringUtil.BoolToStr( Ddo_sys_rolepermissionpermissioncode_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Includesortdsc", StringUtil.BoolToStr( Ddo_sys_rolepermissionpermissioncode_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Sortedstatus", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Includefilter", StringUtil.BoolToStr( Ddo_sys_rolepermissionpermissioncode_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Filtertype", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Filterisrange", StringUtil.BoolToStr( Ddo_sys_rolepermissionpermissioncode_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Includedatalist", StringUtil.BoolToStr( Ddo_sys_rolepermissionpermissioncode_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Datalisttype", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Datalistproc", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_sys_rolepermissionpermissioncode_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Sortasc", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Sortdsc", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Loadingdata", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Cleanfilter", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Noresultsfound", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Searchbuttontext", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONROLEID_Activeeventkey", StringUtil.RTrim( Ddo_sys_rolepermissionroleid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Activeeventkey", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Filteredtext_get", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Selectedvalue_get", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONROLEID_Activeeventkey", StringUtil.RTrim( Ddo_sys_rolepermissionroleid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Activeeventkey", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Filteredtext_get", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Selectedvalue_get", StringUtil.RTrim( Ddo_sys_rolepermissionpermissioncode_Selectedvalue_get));
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
            WE8D2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT8D2( ) ;
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
         return formatLink("sys_rolepermissionww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "SYS_RolePermissionWW" ;
      }

      public override String GetPgmdesc( )
      {
         return " SYS_Role Permission" ;
      }

      protected void WB8D0( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroupColoredActions", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            ClassString = "Button ButtonColor";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(35), 2, 0)+","+"null"+");", "新增", bttBtninsert_Jsonclick, 5, "插入", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_RolePermissionWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavSys_rolepermissionpermissioncode_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSys_rolepermissionpermissioncode_Internalname, "Permission Code", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_35_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSys_rolepermissionpermissioncode_Internalname, AV34SYS_RolePermissionPermissionCode, StringUtil.RTrim( context.localUtil.Format( AV34SYS_RolePermissionPermissionCode, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSys_rolepermissionpermissioncode_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavSys_rolepermissionpermissioncode_Enabled, 0, "text", "", 64, "chr", 1, "row", 64, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_RolePermissionWW.htm");
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"35\">") ;
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DeleteAttribute ActionBaseColorAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV28Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV29Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV31Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
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
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtSYS_RolePermissionPermissionCode_Link));
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
         if ( wbEnd == 35 )
         {
            wbEnd = 0;
            nRC_GXsfl_35 = (short)(nGXsfl_35_idx-1);
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV25GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV27GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV26GridPageSize);
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
            ucDdo_sys_rolepermissionroleid.SetProperty("DropDownOptionsTitleSettingsIcons", AV23DDO_TitleSettingsIcons);
            ucDdo_sys_rolepermissionroleid.SetProperty("DropDownOptionsData", AV17SYS_RolePermissionRoleIDTitleFilterData);
            ucDdo_sys_rolepermissionroleid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_sys_rolepermissionroleid_Internalname, "DDO_SYS_ROLEPERMISSIONROLEIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'" + sGXsfl_35_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_sys_rolepermissionroleidtitlecontrolidtoreplace_Internalname, AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", 0, edtavDdo_sys_rolepermissionroleidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_SYS_RolePermissionWW.htm");
            /* User Defined Control */
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("Caption", Ddo_sys_rolepermissionpermissioncode_Caption);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("Tooltip", Ddo_sys_rolepermissionpermissioncode_Tooltip);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("Cls", Ddo_sys_rolepermissionpermissioncode_Cls);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("DropDownOptionsType", Ddo_sys_rolepermissionpermissioncode_Dropdownoptionstype);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("IncludeSortASC", Ddo_sys_rolepermissionpermissioncode_Includesortasc);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("IncludeSortDSC", Ddo_sys_rolepermissionpermissioncode_Includesortdsc);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("IncludeFilter", Ddo_sys_rolepermissionpermissioncode_Includefilter);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("FilterType", Ddo_sys_rolepermissionpermissioncode_Filtertype);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("FilterIsRange", Ddo_sys_rolepermissionpermissioncode_Filterisrange);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("IncludeDataList", Ddo_sys_rolepermissionpermissioncode_Includedatalist);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("DataListType", Ddo_sys_rolepermissionpermissioncode_Datalisttype);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("DataListProc", Ddo_sys_rolepermissionpermissioncode_Datalistproc);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("DataListUpdateMinimumCharacters", Ddo_sys_rolepermissionpermissioncode_Datalistupdateminimumcharacters);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("SortASC", Ddo_sys_rolepermissionpermissioncode_Sortasc);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("SortDSC", Ddo_sys_rolepermissionpermissioncode_Sortdsc);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("LoadingData", Ddo_sys_rolepermissionpermissioncode_Loadingdata);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("CleanFilter", Ddo_sys_rolepermissionpermissioncode_Cleanfilter);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("NoResultsFound", Ddo_sys_rolepermissionpermissioncode_Noresultsfound);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("SearchButtonText", Ddo_sys_rolepermissionpermissioncode_Searchbuttontext);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("DropDownOptionsTitleSettingsIcons", AV23DDO_TitleSettingsIcons);
            ucDdo_sys_rolepermissionpermissioncode.SetProperty("DropDownOptionsData", AV19SYS_RolePermissionPermissionCodeTitleFilterData);
            ucDdo_sys_rolepermissionpermissioncode.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_sys_rolepermissionpermissioncode_Internalname, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'" + sGXsfl_35_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_sys_rolepermissionpermissioncodetitlecontrolidtoreplace_Internalname, AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", 0, edtavDdo_sys_rolepermissionpermissioncodetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_SYS_RolePermissionWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'" + sGXsfl_35_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_SYS_RolePermissionWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_35_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_SYS_RolePermissionWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'" + sGXsfl_35_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfsys_rolepermissionpermissioncode_Internalname, AV20TFSYS_RolePermissionPermissionCode, StringUtil.RTrim( context.localUtil.Format( AV20TFSYS_RolePermissionPermissionCode, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfsys_rolepermissionpermissioncode_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfsys_rolepermissionpermissioncode_Visible, 1, 0, "text", "", 64, "chr", 1, "row", 64, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_RolePermissionWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_35_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfsys_rolepermissionpermissioncode_sel_Internalname, AV21TFSYS_RolePermissionPermissionCode_Sel, StringUtil.RTrim( context.localUtil.Format( AV21TFSYS_RolePermissionPermissionCode_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfsys_rolepermissionpermissioncode_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfsys_rolepermissionpermissioncode_sel_Visible, 1, 0, "text", "", 64, "chr", 1, "row", 64, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_RolePermissionWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 35 )
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

      protected void START8D2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", " SYS_Role Permission", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP8D0( ) ;
      }

      protected void WS8D2( )
      {
         START8D2( ) ;
         EVT8D2( ) ;
      }

      protected void EVT8D2( )
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
                              E118D2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E128D2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_SYS_ROLEPERMISSIONROLEID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E138D2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E148D2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E158D2 ();
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
                              nGXsfl_35_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_35_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_35_idx), 4, 0)), 4, "0");
                              SubsflControlProps_352( ) ;
                              AV28Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV28Display)) ? AV48Display_GXI : context.convertURL( context.PathToRelativeUrl( AV28Display))), !bGXsfl_35_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV28Display), true);
                              AV29Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV29Update)) ? AV49Update_GXI : context.convertURL( context.PathToRelativeUrl( AV29Update))), !bGXsfl_35_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV29Update), true);
                              AV31Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV31Delete)) ? AV50Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV31Delete))), !bGXsfl_35_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV31Delete), true);
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
                                    E168D2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E178D2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E188D2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Sys_rolepermissionpermissioncode Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vSYS_ROLEPERMISSIONPERMISSIONCODE"), AV34SYS_RolePermissionPermissionCode) != 0 )
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
                                       /* Set Refresh If Tfsys_rolepermissionpermissioncode Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFSYS_ROLEPERMISSIONPERMISSIONCODE"), AV20TFSYS_RolePermissionPermissionCode) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfsys_rolepermissionpermissioncode_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFSYS_ROLEPERMISSIONPERMISSIONCODE_SEL"), AV21TFSYS_RolePermissionPermissionCode_Sel) != 0 )
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

      protected void WE8D2( )
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

      protected void PA8D2( )
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
               GX_FocusControl = edtavSys_rolepermissionpermissioncode_Internalname;
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
         SubsflControlProps_352( ) ;
         while ( nGXsfl_35_idx <= nRC_GXsfl_35 )
         {
            sendrow_352( ) ;
            nGXsfl_35_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_35_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_35_idx+1));
            sGXsfl_35_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_35_idx), 4, 0)), 4, "0");
            SubsflControlProps_352( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       String AV34SYS_RolePermissionPermissionCode ,
                                       short AV13OrderedBy ,
                                       bool AV14OrderedDsc ,
                                       String AV20TFSYS_RolePermissionPermissionCode ,
                                       String AV21TFSYS_RolePermissionPermissionCode_Sel ,
                                       String AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace ,
                                       String AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace ,
                                       String AV51Pgmname )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF8D2( ) ;
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
         RF8D2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV51Pgmname = "SYS_RolePermissionWW";
         context.Gx_err = 0;
      }

      protected void RF8D2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 35;
         /* Execute user event: Refresh */
         E178D2 ();
         nGXsfl_35_idx = 1;
         sGXsfl_35_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_35_idx), 4, 0)), 4, "0");
         SubsflControlProps_352( ) ;
         bGXsfl_35_Refreshing = true;
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
            SubsflControlProps_352( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_datastore1.dynParam(0, new Object[]{ new Object[]{
                                                 AV45SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode ,
                                                 AV47SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel ,
                                                 AV46SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode ,
                                                 A445SYS_RolePermissionPermissionCode ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV45SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode = StringUtil.Concat( StringUtil.RTrim( AV45SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode), "%", "");
            lV46SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode = StringUtil.Concat( StringUtil.RTrim( AV46SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode), "%", "");
            /* Using cursor H008D2 */
            pr_datastore1.execute(0, new Object[] {lV45SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode, lV46SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode, AV47SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_35_idx = 1;
            sGXsfl_35_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_35_idx), 4, 0)), 4, "0");
            SubsflControlProps_352( ) ;
            while ( ( (pr_datastore1.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A445SYS_RolePermissionPermissionCode = H008D2_A445SYS_RolePermissionPermissionCode[0];
               A444SYS_RolePermissionRoleID = (Guid)((Guid)(H008D2_A444SYS_RolePermissionRoleID[0]));
               E188D2 ();
               pr_datastore1.readNext(0);
            }
            GRID_nEOF = (short)(((pr_datastore1.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_datastore1.close(0);
            wbEnd = 35;
            WB8D0( ) ;
         }
         bGXsfl_35_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes8D2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_SYS_ROLEPERMISSIONROLEID"+"_"+sGXsfl_35_idx, GetSecureSignedToken( sGXsfl_35_idx, A444SYS_RolePermissionRoleID, context));
         GxWebStd.gx_hidden_field( context, "gxhash_SYS_ROLEPERMISSIONPERMISSIONCODE"+"_"+sGXsfl_35_idx, GetSecureSignedToken( sGXsfl_35_idx, StringUtil.RTrim( context.localUtil.Format( A445SYS_RolePermissionPermissionCode, "")), context));
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
         AV45SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode = AV34SYS_RolePermissionPermissionCode;
         AV46SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode = AV20TFSYS_RolePermissionPermissionCode;
         AV47SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel = AV21TFSYS_RolePermissionPermissionCode_Sel;
         pr_datastore1.dynParam(1, new Object[]{ new Object[]{
                                              AV45SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode ,
                                              AV47SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel ,
                                              AV46SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode ,
                                              A445SYS_RolePermissionPermissionCode ,
                                              AV13OrderedBy ,
                                              AV14OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV45SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode = StringUtil.Concat( StringUtil.RTrim( AV45SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode), "%", "");
         lV46SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode = StringUtil.Concat( StringUtil.RTrim( AV46SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode), "%", "");
         /* Using cursor H008D3 */
         pr_datastore1.execute(1, new Object[] {lV45SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode, lV46SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode, AV47SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel});
         GRID_nRecordCount = H008D3_AGRID_nRecordCount[0];
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
         AV45SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode = AV34SYS_RolePermissionPermissionCode;
         AV46SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode = AV20TFSYS_RolePermissionPermissionCode;
         AV47SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel = AV21TFSYS_RolePermissionPermissionCode_Sel;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV34SYS_RolePermissionPermissionCode, AV13OrderedBy, AV14OrderedDsc, AV20TFSYS_RolePermissionPermissionCode, AV21TFSYS_RolePermissionPermissionCode_Sel, AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace, AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace, AV51Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV45SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode = AV34SYS_RolePermissionPermissionCode;
         AV46SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode = AV20TFSYS_RolePermissionPermissionCode;
         AV47SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel = AV21TFSYS_RolePermissionPermissionCode_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV34SYS_RolePermissionPermissionCode, AV13OrderedBy, AV14OrderedDsc, AV20TFSYS_RolePermissionPermissionCode, AV21TFSYS_RolePermissionPermissionCode_Sel, AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace, AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace, AV51Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV45SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode = AV34SYS_RolePermissionPermissionCode;
         AV46SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode = AV20TFSYS_RolePermissionPermissionCode;
         AV47SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel = AV21TFSYS_RolePermissionPermissionCode_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV34SYS_RolePermissionPermissionCode, AV13OrderedBy, AV14OrderedDsc, AV20TFSYS_RolePermissionPermissionCode, AV21TFSYS_RolePermissionPermissionCode_Sel, AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace, AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace, AV51Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV45SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode = AV34SYS_RolePermissionPermissionCode;
         AV46SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode = AV20TFSYS_RolePermissionPermissionCode;
         AV47SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel = AV21TFSYS_RolePermissionPermissionCode_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV34SYS_RolePermissionPermissionCode, AV13OrderedBy, AV14OrderedDsc, AV20TFSYS_RolePermissionPermissionCode, AV21TFSYS_RolePermissionPermissionCode_Sel, AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace, AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace, AV51Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV45SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode = AV34SYS_RolePermissionPermissionCode;
         AV46SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode = AV20TFSYS_RolePermissionPermissionCode;
         AV47SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel = AV21TFSYS_RolePermissionPermissionCode_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV34SYS_RolePermissionPermissionCode, AV13OrderedBy, AV14OrderedDsc, AV20TFSYS_RolePermissionPermissionCode, AV21TFSYS_RolePermissionPermissionCode_Sel, AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace, AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace, AV51Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP8D0( )
      {
         /* Before Start, stand alone formulas. */
         AV51Pgmname = "SYS_RolePermissionWW";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E168D2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV23DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vSYS_ROLEPERMISSIONROLEIDTITLEFILTERDATA"), AV17SYS_RolePermissionRoleIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vSYS_ROLEPERMISSIONPERMISSIONCODETITLEFILTERDATA"), AV19SYS_RolePermissionPermissionCodeTitleFilterData);
            /* Read variables values. */
            AV34SYS_RolePermissionPermissionCode = cgiGet( edtavSys_rolepermissionpermissioncode_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34SYS_RolePermissionPermissionCode", AV34SYS_RolePermissionPermissionCode);
            AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace = cgiGet( edtavDdo_sys_rolepermissionroleidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace", AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace);
            AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace = cgiGet( edtavDdo_sys_rolepermissionpermissioncodetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace", AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace);
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
            AV20TFSYS_RolePermissionPermissionCode = cgiGet( edtavTfsys_rolepermissionpermissioncode_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20TFSYS_RolePermissionPermissionCode", AV20TFSYS_RolePermissionPermissionCode);
            AV21TFSYS_RolePermissionPermissionCode_Sel = cgiGet( edtavTfsys_rolepermissionpermissioncode_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFSYS_RolePermissionPermissionCode_Sel", AV21TFSYS_RolePermissionPermissionCode_Sel);
            /* Read saved values. */
            nRC_GXsfl_35 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_35"), ".", ","));
            AV25GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV27GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV26GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_sys_rolepermissionpermissioncode_Filteredtext_set = cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Filteredtext_set");
            Ddo_sys_rolepermissionpermissioncode_Selectedvalue_set = cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Selectedvalue_set");
            Ddo_sys_rolepermissionpermissioncode_Dropdownoptionstype = cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Dropdownoptionstype");
            Ddo_sys_rolepermissionpermissioncode_Titlecontrolidtoreplace = cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Titlecontrolidtoreplace");
            Ddo_sys_rolepermissionpermissioncode_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Includesortasc"));
            Ddo_sys_rolepermissionpermissioncode_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Includesortdsc"));
            Ddo_sys_rolepermissionpermissioncode_Sortedstatus = cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Sortedstatus");
            Ddo_sys_rolepermissionpermissioncode_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Includefilter"));
            Ddo_sys_rolepermissionpermissioncode_Filtertype = cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Filtertype");
            Ddo_sys_rolepermissionpermissioncode_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Filterisrange"));
            Ddo_sys_rolepermissionpermissioncode_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Includedatalist"));
            Ddo_sys_rolepermissionpermissioncode_Datalisttype = cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Datalisttype");
            Ddo_sys_rolepermissionpermissioncode_Datalistproc = cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Datalistproc");
            Ddo_sys_rolepermissionpermissioncode_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_sys_rolepermissionpermissioncode_Sortasc = cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Sortasc");
            Ddo_sys_rolepermissionpermissioncode_Sortdsc = cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Sortdsc");
            Ddo_sys_rolepermissionpermissioncode_Loadingdata = cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Loadingdata");
            Ddo_sys_rolepermissionpermissioncode_Cleanfilter = cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Cleanfilter");
            Ddo_sys_rolepermissionpermissioncode_Noresultsfound = cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Noresultsfound");
            Ddo_sys_rolepermissionpermissioncode_Searchbuttontext = cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_sys_rolepermissionroleid_Activeeventkey = cgiGet( "DDO_SYS_ROLEPERMISSIONROLEID_Activeeventkey");
            Ddo_sys_rolepermissionpermissioncode_Activeeventkey = cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Activeeventkey");
            Ddo_sys_rolepermissionpermissioncode_Filteredtext_get = cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Filteredtext_get");
            Ddo_sys_rolepermissionpermissioncode_Selectedvalue_get = cgiGet( "DDO_SYS_ROLEPERMISSIONPERMISSIONCODE_Selectedvalue_get");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( StringUtil.StrCmp(cgiGet( "GXH_vSYS_ROLEPERMISSIONPERMISSIONCODE"), AV34SYS_RolePermissionPermissionCode) != 0 )
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
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFSYS_ROLEPERMISSIONPERMISSIONCODE"), AV20TFSYS_RolePermissionPermissionCode) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFSYS_ROLEPERMISSIONPERMISSIONCODE_SEL"), AV21TFSYS_RolePermissionPermissionCode_Sel) != 0 )
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
         E168D2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E168D2( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         edtavTfsys_rolepermissionpermissioncode_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfsys_rolepermissionpermissioncode_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfsys_rolepermissionpermissioncode_Visible), 5, 0)), true);
         edtavTfsys_rolepermissionpermissioncode_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfsys_rolepermissionpermissioncode_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfsys_rolepermissionpermissioncode_sel_Visible), 5, 0)), true);
         Ddo_sys_rolepermissionroleid_Titlecontrolidtoreplace = subGrid_Internalname+"_SYS_RolePermissionRoleID";
         ucDdo_sys_rolepermissionroleid.SendProperty(context, "", false, Ddo_sys_rolepermissionroleid_Internalname, "TitleControlIdToReplace", Ddo_sys_rolepermissionroleid_Titlecontrolidtoreplace);
         AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace = Ddo_sys_rolepermissionroleid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace", AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace);
         edtavDdo_sys_rolepermissionroleidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_sys_rolepermissionroleidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_sys_rolepermissionroleidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_sys_rolepermissionpermissioncode_Titlecontrolidtoreplace = subGrid_Internalname+"_SYS_RolePermissionPermissionCode";
         ucDdo_sys_rolepermissionpermissioncode.SendProperty(context, "", false, Ddo_sys_rolepermissionpermissioncode_Internalname, "TitleControlIdToReplace", Ddo_sys_rolepermissionpermissioncode_Titlecontrolidtoreplace);
         AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace = Ddo_sys_rolepermissionpermissioncode_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace", AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace);
         edtavDdo_sys_rolepermissionpermissioncodetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_sys_rolepermissionpermissioncodetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_sys_rolepermissionpermissioncodetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " SYS_Role Permission";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV23DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV23DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E178D2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV17SYS_RolePermissionRoleIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19SYS_RolePermissionPermissionCodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         /* Execute user subroutine: 'SAVEGRIDSTATE' */
         S142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         edtSYS_RolePermissionRoleID_Titleformat = 2;
         edtSYS_RolePermissionRoleID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Role ID", AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_RolePermissionRoleID_Internalname, "Title", edtSYS_RolePermissionRoleID_Title, !bGXsfl_35_Refreshing);
         edtSYS_RolePermissionPermissionCode_Titleformat = 2;
         edtSYS_RolePermissionPermissionCode_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Permission Code", AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_RolePermissionPermissionCode_Internalname, "Title", edtSYS_RolePermissionPermissionCode_Title, !bGXsfl_35_Refreshing);
         AV25GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25GridCurrentPage), 10, 0)));
         AV26GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26GridPageSize), 10, 0)));
         AV27GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV27GridRecordCount), 10, 0)));
         AV45SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode = AV34SYS_RolePermissionPermissionCode;
         AV46SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode = AV20TFSYS_RolePermissionPermissionCode;
         AV47SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel = AV21TFSYS_RolePermissionPermissionCode_Sel;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17SYS_RolePermissionRoleIDTitleFilterData", AV17SYS_RolePermissionRoleIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19SYS_RolePermissionPermissionCodeTitleFilterData", AV19SYS_RolePermissionPermissionCodeTitleFilterData);
      }

      protected void E118D2( )
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
            AV24PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV24PageToGo) ;
         }
      }

      protected void E128D2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E138D2( )
      {
         /* Ddo_sys_rolepermissionroleid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_sys_rolepermissionroleid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_sys_rolepermissionroleid_Sortedstatus = "ASC";
            ucDdo_sys_rolepermissionroleid.SendProperty(context, "", false, Ddo_sys_rolepermissionroleid_Internalname, "SortedStatus", Ddo_sys_rolepermissionroleid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_sys_rolepermissionroleid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_sys_rolepermissionroleid_Sortedstatus = "DSC";
            ucDdo_sys_rolepermissionroleid.SendProperty(context, "", false, Ddo_sys_rolepermissionroleid_Internalname, "SortedStatus", Ddo_sys_rolepermissionroleid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17SYS_RolePermissionRoleIDTitleFilterData", AV17SYS_RolePermissionRoleIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19SYS_RolePermissionPermissionCodeTitleFilterData", AV19SYS_RolePermissionPermissionCodeTitleFilterData);
      }

      protected void E148D2( )
      {
         /* Ddo_sys_rolepermissionpermissioncode_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_sys_rolepermissionpermissioncode_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_sys_rolepermissionpermissioncode_Sortedstatus = "ASC";
            ucDdo_sys_rolepermissionpermissioncode.SendProperty(context, "", false, Ddo_sys_rolepermissionpermissioncode_Internalname, "SortedStatus", Ddo_sys_rolepermissionpermissioncode_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_sys_rolepermissionpermissioncode_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_sys_rolepermissionpermissioncode_Sortedstatus = "DSC";
            ucDdo_sys_rolepermissionpermissioncode.SendProperty(context, "", false, Ddo_sys_rolepermissionpermissioncode_Internalname, "SortedStatus", Ddo_sys_rolepermissionpermissioncode_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_sys_rolepermissionpermissioncode_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV20TFSYS_RolePermissionPermissionCode = Ddo_sys_rolepermissionpermissioncode_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20TFSYS_RolePermissionPermissionCode", AV20TFSYS_RolePermissionPermissionCode);
            AV21TFSYS_RolePermissionPermissionCode_Sel = Ddo_sys_rolepermissionpermissioncode_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFSYS_RolePermissionPermissionCode_Sel", AV21TFSYS_RolePermissionPermissionCode_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17SYS_RolePermissionRoleIDTitleFilterData", AV17SYS_RolePermissionRoleIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19SYS_RolePermissionPermissionCodeTitleFilterData", AV19SYS_RolePermissionPermissionCodeTitleFilterData);
      }

      private void E188D2( )
      {
         /* Grid_Load Routine */
         AV28Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDisplay_Internalname, AV28Display);
         AV48Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = formatLink("sys_rolepermissionview.aspx") + "?" + UrlEncode(A444SYS_RolePermissionRoleID.ToString()) + "," + UrlEncode(StringUtil.RTrim(A445SYS_RolePermissionPermissionCode)) + "," + UrlEncode(StringUtil.RTrim(""));
         AV29Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV29Update);
         AV49Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavUpdate_Tooltiptext = "修改";
         edtavUpdate_Link = formatLink("sys_rolepermission.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode(A444SYS_RolePermissionRoleID.ToString()) + "," + UrlEncode(StringUtil.RTrim(A445SYS_RolePermissionPermissionCode));
         AV31Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV31Delete);
         AV50Delete_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavDelete_Tooltiptext = "删除";
         edtavDelete_Link = formatLink("sys_rolepermission.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode(A444SYS_RolePermissionRoleID.ToString()) + "," + UrlEncode(StringUtil.RTrim(A445SYS_RolePermissionPermissionCode));
         edtSYS_RolePermissionPermissionCode_Link = formatLink("sys_rolepermissionview.aspx") + "?" + UrlEncode(A444SYS_RolePermissionRoleID.ToString()) + "," + UrlEncode(StringUtil.RTrim(A445SYS_RolePermissionPermissionCode)) + "," + UrlEncode(StringUtil.RTrim(""));
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 35;
         }
         sendrow_352( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_35_Refreshing )
         {
            context.DoAjaxLoad(35, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void E158D2( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("sys_rolepermission.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode(Guid.Empty.ToString()) + "," + UrlEncode(StringUtil.RTrim("")));
         context.wjLocDisableFrm = 1;
      }

      protected void S152( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_sys_rolepermissionroleid_Sortedstatus = "";
         ucDdo_sys_rolepermissionroleid.SendProperty(context, "", false, Ddo_sys_rolepermissionroleid_Internalname, "SortedStatus", Ddo_sys_rolepermissionroleid_Sortedstatus);
         Ddo_sys_rolepermissionpermissioncode_Sortedstatus = "";
         ucDdo_sys_rolepermissionpermissioncode.SendProperty(context, "", false, Ddo_sys_rolepermissionpermissioncode_Internalname, "SortedStatus", Ddo_sys_rolepermissionpermissioncode_Sortedstatus);
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
            Ddo_sys_rolepermissionroleid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_sys_rolepermissionroleid.SendProperty(context, "", false, Ddo_sys_rolepermissionroleid_Internalname, "SortedStatus", Ddo_sys_rolepermissionroleid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 2 )
         {
            Ddo_sys_rolepermissionpermissioncode_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_sys_rolepermissionpermissioncode.SendProperty(context, "", false, Ddo_sys_rolepermissionpermissioncode_Internalname, "SortedStatus", Ddo_sys_rolepermissionpermissioncode_Sortedstatus);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV16Session.Get(AV51Pgmname+"GridState"), "") == 0 )
         {
            AV11GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV51Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV11GridState.FromXml(AV16Session.Get(AV51Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
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
         AV52GXV1 = 1;
         while ( AV52GXV1 <= AV11GridState.gxTpr_Filtervalues.Count )
         {
            AV12GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV11GridState.gxTpr_Filtervalues.Item(AV52GXV1));
            if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "SYS_ROLEPERMISSIONPERMISSIONCODE") == 0 )
            {
               AV34SYS_RolePermissionPermissionCode = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34SYS_RolePermissionPermissionCode", AV34SYS_RolePermissionPermissionCode);
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFSYS_ROLEPERMISSIONPERMISSIONCODE") == 0 )
            {
               AV20TFSYS_RolePermissionPermissionCode = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20TFSYS_RolePermissionPermissionCode", AV20TFSYS_RolePermissionPermissionCode);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV20TFSYS_RolePermissionPermissionCode)) )
               {
                  Ddo_sys_rolepermissionpermissioncode_Filteredtext_set = AV20TFSYS_RolePermissionPermissionCode;
                  ucDdo_sys_rolepermissionpermissioncode.SendProperty(context, "", false, Ddo_sys_rolepermissionpermissioncode_Internalname, "FilteredText_set", Ddo_sys_rolepermissionpermissioncode_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFSYS_ROLEPERMISSIONPERMISSIONCODE_SEL") == 0 )
            {
               AV21TFSYS_RolePermissionPermissionCode_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFSYS_RolePermissionPermissionCode_Sel", AV21TFSYS_RolePermissionPermissionCode_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV21TFSYS_RolePermissionPermissionCode_Sel)) )
               {
                  Ddo_sys_rolepermissionpermissioncode_Selectedvalue_set = AV21TFSYS_RolePermissionPermissionCode_Sel;
                  ucDdo_sys_rolepermissionpermissioncode.SendProperty(context, "", false, Ddo_sys_rolepermissionpermissioncode_Internalname, "SelectedValue_set", Ddo_sys_rolepermissionpermissioncode_Selectedvalue_set);
               }
            }
            AV52GXV1 = (int)(AV52GXV1+1);
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
         AV11GridState.FromXml(AV16Session.Get(AV51Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV11GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV11GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV11GridState.gxTpr_Filtervalues.Clear();
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV34SYS_RolePermissionPermissionCode)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "SYS_ROLEPERMISSIONPERMISSIONCODE";
            AV12GridStateFilterValue.gxTpr_Value = AV34SYS_RolePermissionPermissionCode;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV20TFSYS_RolePermissionPermissionCode)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFSYS_ROLEPERMISSIONPERMISSIONCODE";
            AV12GridStateFilterValue.gxTpr_Value = AV20TFSYS_RolePermissionPermissionCode;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV21TFSYS_RolePermissionPermissionCode_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFSYS_ROLEPERMISSIONPERMISSIONCODE_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV21TFSYS_RolePermissionPermissionCode_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         AV11GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV11GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV51Pgmname+"GridState",  AV11GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV51Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "SYS_RolePermission";
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
         PA8D2( ) ;
         WS8D2( ) ;
         WE8D2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022815164335", true);
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
         context.AddJavascriptSource("sys_rolepermissionww.js", "?202022815164335", false);
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

      protected void SubsflControlProps_352( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_35_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_35_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_35_idx;
         edtSYS_RolePermissionRoleID_Internalname = "SYS_ROLEPERMISSIONROLEID_"+sGXsfl_35_idx;
         edtSYS_RolePermissionPermissionCode_Internalname = "SYS_ROLEPERMISSIONPERMISSIONCODE_"+sGXsfl_35_idx;
      }

      protected void SubsflControlProps_fel_352( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_35_fel_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_35_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_35_fel_idx;
         edtSYS_RolePermissionRoleID_Internalname = "SYS_ROLEPERMISSIONROLEID_"+sGXsfl_35_fel_idx;
         edtSYS_RolePermissionPermissionCode_Internalname = "SYS_ROLEPERMISSIONPERMISSIONCODE_"+sGXsfl_35_fel_idx;
      }

      protected void sendrow_352( )
      {
         SubsflControlProps_352( ) ;
         WB8D0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_35_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_35_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_35_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV28Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV28Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV48Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV28Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV28Display)) ? AV48Display_GXI : context.PathToRelativeUrl( AV28Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV28Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV29Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV29Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV49Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV29Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV29Update)) ? AV49Update_GXI : context.PathToRelativeUrl( AV29Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV29Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "DeleteAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV31Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV31Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV50Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV31Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV31Delete)) ? AV50Delete_GXI : context.PathToRelativeUrl( AV31Delete));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)edtavDelete_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV31Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSYS_RolePermissionRoleID_Internalname,A444SYS_RolePermissionRoleID.ToString(),A444SYS_RolePermissionRoleID.ToString(),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSYS_RolePermissionRoleID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)36,(short)0,(short)0,(short)35,(short)1,(short)0,(short)0,(bool)true,(String)"",(String)"",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSYS_RolePermissionPermissionCode_Internalname,(String)A445SYS_RolePermissionPermissionCode,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtSYS_RolePermissionPermissionCode_Link,(String)"",(String)"",(String)"",(String)edtSYS_RolePermissionPermissionCode_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)64,(short)0,(short)0,(short)35,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes8D2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_35_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_35_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_35_idx+1));
            sGXsfl_35_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_35_idx), 4, 0)), 4, "0");
            SubsflControlProps_352( ) ;
         }
         /* End function sendrow_352 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtninsert_Internalname = "BTNINSERT";
         edtavSys_rolepermissionpermissioncode_Internalname = "vSYS_ROLEPERMISSIONPERMISSIONCODE";
         divTableactions_Internalname = "TABLEACTIONS";
         divTableheader_Internalname = "TABLEHEADER";
         divLayout_tableheader_Internalname = "LAYOUT_TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         divHtml_dvpanel_tableheader_Internalname = "HTML_DVPANEL_TABLEHEADER";
         edtavDisplay_Internalname = "vDISPLAY";
         edtavUpdate_Internalname = "vUPDATE";
         edtavDelete_Internalname = "vDELETE";
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
         edtavTfsys_rolepermissionpermissioncode_Internalname = "vTFSYS_ROLEPERMISSIONPERMISSIONCODE";
         edtavTfsys_rolepermissionpermissioncode_sel_Internalname = "vTFSYS_ROLEPERMISSIONPERMISSIONCODE_SEL";
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
         edtavTfsys_rolepermissionpermissioncode_sel_Jsonclick = "";
         edtavTfsys_rolepermissionpermissioncode_sel_Visible = 1;
         edtavTfsys_rolepermissionpermissioncode_Jsonclick = "";
         edtavTfsys_rolepermissionpermissioncode_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_sys_rolepermissionpermissioncodetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_sys_rolepermissionroleidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtSYS_RolePermissionPermissionCode_Link = "";
         edtavDelete_Tooltiptext = "删除";
         edtavDelete_Link = "";
         edtavUpdate_Tooltiptext = "修改";
         edtavUpdate_Link = "";
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtSYS_RolePermissionPermissionCode_Titleformat = 0;
         edtSYS_RolePermissionPermissionCode_Title = "Permission Code";
         edtSYS_RolePermissionRoleID_Titleformat = 0;
         edtSYS_RolePermissionRoleID_Title = "Role ID";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         edtavSys_rolepermissionpermissioncode_Jsonclick = "";
         edtavSys_rolepermissionpermissioncode_Enabled = 1;
         Ddo_sys_rolepermissionpermissioncode_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_sys_rolepermissionpermissioncode_Noresultsfound = "WWP_TSNoResults";
         Ddo_sys_rolepermissionpermissioncode_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_sys_rolepermissionpermissioncode_Loadingdata = "WWP_TSLoading";
         Ddo_sys_rolepermissionpermissioncode_Sortdsc = "WWP_TSSortDSC";
         Ddo_sys_rolepermissionpermissioncode_Sortasc = "WWP_TSSortASC";
         Ddo_sys_rolepermissionpermissioncode_Datalistupdateminimumcharacters = 0;
         Ddo_sys_rolepermissionpermissioncode_Datalistproc = "SYS_RolePermissionWWGetFilterData";
         Ddo_sys_rolepermissionpermissioncode_Datalisttype = "Dynamic";
         Ddo_sys_rolepermissionpermissioncode_Includedatalist = Convert.ToBoolean( -1);
         Ddo_sys_rolepermissionpermissioncode_Filterisrange = Convert.ToBoolean( 0);
         Ddo_sys_rolepermissionpermissioncode_Filtertype = "Character";
         Ddo_sys_rolepermissionpermissioncode_Includefilter = Convert.ToBoolean( -1);
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
         Form.Caption = " SYS_Role Permission";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV34SYS_RolePermissionPermissionCode',fld:'vSYS_ROLEPERMISSIONPERMISSIONCODE',pic:''},{av:'AV20TFSYS_RolePermissionPermissionCode',fld:'vTFSYS_ROLEPERMISSIONPERMISSIONCODE',pic:''},{av:'AV21TFSYS_RolePermissionPermissionCode_Sel',fld:'vTFSYS_ROLEPERMISSIONPERMISSIONCODE_SEL',pic:''},{av:'AV51Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV17SYS_RolePermissionRoleIDTitleFilterData',fld:'vSYS_ROLEPERMISSIONROLEIDTITLEFILTERDATA',pic:''},{av:'AV19SYS_RolePermissionPermissionCodeTitleFilterData',fld:'vSYS_ROLEPERMISSIONPERMISSIONCODETITLEFILTERDATA',pic:''},{av:'edtSYS_RolePermissionRoleID_Titleformat',ctrl:'SYS_ROLEPERMISSIONROLEID',prop:'Titleformat'},{av:'edtSYS_RolePermissionRoleID_Title',ctrl:'SYS_ROLEPERMISSIONROLEID',prop:'Title'},{av:'edtSYS_RolePermissionPermissionCode_Titleformat',ctrl:'SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'Titleformat'},{av:'edtSYS_RolePermissionPermissionCode_Title',ctrl:'SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'Title'},{av:'AV25GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV26GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV27GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E118D2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV34SYS_RolePermissionPermissionCode',fld:'vSYS_ROLEPERMISSIONPERMISSIONCODE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV20TFSYS_RolePermissionPermissionCode',fld:'vTFSYS_ROLEPERMISSIONPERMISSIONCODE',pic:''},{av:'AV21TFSYS_RolePermissionPermissionCode_Sel',fld:'vTFSYS_ROLEPERMISSIONPERMISSIONCODE_SEL',pic:''},{av:'AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51Pgmname',fld:'vPGMNAME',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E128D2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV34SYS_RolePermissionPermissionCode',fld:'vSYS_ROLEPERMISSIONPERMISSIONCODE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV20TFSYS_RolePermissionPermissionCode',fld:'vTFSYS_ROLEPERMISSIONPERMISSIONCODE',pic:''},{av:'AV21TFSYS_RolePermissionPermissionCode_Sel',fld:'vTFSYS_ROLEPERMISSIONPERMISSIONCODE_SEL',pic:''},{av:'AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51Pgmname',fld:'vPGMNAME',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_SYS_ROLEPERMISSIONROLEID.ONOPTIONCLICKED","{handler:'E138D2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV34SYS_RolePermissionPermissionCode',fld:'vSYS_ROLEPERMISSIONPERMISSIONCODE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV20TFSYS_RolePermissionPermissionCode',fld:'vTFSYS_ROLEPERMISSIONPERMISSIONCODE',pic:''},{av:'AV21TFSYS_RolePermissionPermissionCode_Sel',fld:'vTFSYS_ROLEPERMISSIONPERMISSIONCODE_SEL',pic:''},{av:'AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_sys_rolepermissionroleid_Activeeventkey',ctrl:'DDO_SYS_ROLEPERMISSIONROLEID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_SYS_ROLEPERMISSIONROLEID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_sys_rolepermissionroleid_Sortedstatus',ctrl:'DDO_SYS_ROLEPERMISSIONROLEID',prop:'SortedStatus'},{av:'Ddo_sys_rolepermissionpermissioncode_Sortedstatus',ctrl:'DDO_SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'SortedStatus'},{av:'AV17SYS_RolePermissionRoleIDTitleFilterData',fld:'vSYS_ROLEPERMISSIONROLEIDTITLEFILTERDATA',pic:''},{av:'AV19SYS_RolePermissionPermissionCodeTitleFilterData',fld:'vSYS_ROLEPERMISSIONPERMISSIONCODETITLEFILTERDATA',pic:''},{av:'edtSYS_RolePermissionRoleID_Titleformat',ctrl:'SYS_ROLEPERMISSIONROLEID',prop:'Titleformat'},{av:'edtSYS_RolePermissionRoleID_Title',ctrl:'SYS_ROLEPERMISSIONROLEID',prop:'Title'},{av:'edtSYS_RolePermissionPermissionCode_Titleformat',ctrl:'SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'Titleformat'},{av:'edtSYS_RolePermissionPermissionCode_Title',ctrl:'SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'Title'},{av:'AV25GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV26GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV27GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_SYS_ROLEPERMISSIONPERMISSIONCODE.ONOPTIONCLICKED","{handler:'E148D2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV34SYS_RolePermissionPermissionCode',fld:'vSYS_ROLEPERMISSIONPERMISSIONCODE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV20TFSYS_RolePermissionPermissionCode',fld:'vTFSYS_ROLEPERMISSIONPERMISSIONCODE',pic:''},{av:'AV21TFSYS_RolePermissionPermissionCode_Sel',fld:'vTFSYS_ROLEPERMISSIONPERMISSIONCODE_SEL',pic:''},{av:'AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONROLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace',fld:'vDDO_SYS_ROLEPERMISSIONPERMISSIONCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_sys_rolepermissionpermissioncode_Activeeventkey',ctrl:'DDO_SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'ActiveEventKey'},{av:'Ddo_sys_rolepermissionpermissioncode_Filteredtext_get',ctrl:'DDO_SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'FilteredText_get'},{av:'Ddo_sys_rolepermissionpermissioncode_Selectedvalue_get',ctrl:'DDO_SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_SYS_ROLEPERMISSIONPERMISSIONCODE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_sys_rolepermissionpermissioncode_Sortedstatus',ctrl:'DDO_SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'SortedStatus'},{av:'AV20TFSYS_RolePermissionPermissionCode',fld:'vTFSYS_ROLEPERMISSIONPERMISSIONCODE',pic:''},{av:'AV21TFSYS_RolePermissionPermissionCode_Sel',fld:'vTFSYS_ROLEPERMISSIONPERMISSIONCODE_SEL',pic:''},{av:'Ddo_sys_rolepermissionroleid_Sortedstatus',ctrl:'DDO_SYS_ROLEPERMISSIONROLEID',prop:'SortedStatus'},{av:'AV17SYS_RolePermissionRoleIDTitleFilterData',fld:'vSYS_ROLEPERMISSIONROLEIDTITLEFILTERDATA',pic:''},{av:'AV19SYS_RolePermissionPermissionCodeTitleFilterData',fld:'vSYS_ROLEPERMISSIONPERMISSIONCODETITLEFILTERDATA',pic:''},{av:'edtSYS_RolePermissionRoleID_Titleformat',ctrl:'SYS_ROLEPERMISSIONROLEID',prop:'Titleformat'},{av:'edtSYS_RolePermissionRoleID_Title',ctrl:'SYS_ROLEPERMISSIONROLEID',prop:'Title'},{av:'edtSYS_RolePermissionPermissionCode_Titleformat',ctrl:'SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'Titleformat'},{av:'edtSYS_RolePermissionPermissionCode_Title',ctrl:'SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'Title'},{av:'AV25GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV26GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV27GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E188D2',iparms:[{av:'A444SYS_RolePermissionRoleID',fld:'SYS_ROLEPERMISSIONROLEID',pic:'',hsh:true},{av:'A445SYS_RolePermissionPermissionCode',fld:'SYS_ROLEPERMISSIONPERMISSIONCODE',pic:'',hsh:true}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV28Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'},{av:'AV29Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV31Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'},{av:'edtSYS_RolePermissionPermissionCode_Link',ctrl:'SYS_ROLEPERMISSIONPERMISSIONCODE',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E158D2',iparms:[{av:'A444SYS_RolePermissionRoleID',fld:'SYS_ROLEPERMISSIONROLEID',pic:'',hsh:true},{av:'A445SYS_RolePermissionPermissionCode',fld:'SYS_ROLEPERMISSIONPERMISSIONCODE',pic:'',hsh:true}]");
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
         Ddo_sys_rolepermissionroleid_Activeeventkey = "";
         Ddo_sys_rolepermissionpermissioncode_Activeeventkey = "";
         Ddo_sys_rolepermissionpermissioncode_Filteredtext_get = "";
         Ddo_sys_rolepermissionpermissioncode_Selectedvalue_get = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV34SYS_RolePermissionPermissionCode = "";
         AV20TFSYS_RolePermissionPermissionCode = "";
         AV21TFSYS_RolePermissionPermissionCode_Sel = "";
         AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace = "";
         AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace = "";
         AV51Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV23DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV17SYS_RolePermissionRoleIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19SYS_RolePermissionPermissionCodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_sys_rolepermissionroleid_Sortedstatus = "";
         Ddo_sys_rolepermissionpermissioncode_Filteredtext_set = "";
         Ddo_sys_rolepermissionpermissioncode_Selectedvalue_set = "";
         Ddo_sys_rolepermissionpermissioncode_Sortedstatus = "";
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
         AV28Display = "";
         AV29Update = "";
         AV31Delete = "";
         A444SYS_RolePermissionRoleID = (Guid)(Guid.Empty);
         A445SYS_RolePermissionPermissionCode = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_sys_rolepermissionroleid = new GXUserControl();
         ucDdo_sys_rolepermissionpermissioncode = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV48Display_GXI = "";
         AV49Update_GXI = "";
         AV50Delete_GXI = "";
         scmdbuf = "";
         lV45SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode = "";
         lV46SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode = "";
         AV45SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode = "";
         AV47SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel = "";
         AV46SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode = "";
         H008D2_A445SYS_RolePermissionPermissionCode = new String[] {""} ;
         H008D2_A444SYS_RolePermissionRoleID = new Guid[] {Guid.Empty} ;
         H008D3_AGRID_nRecordCount = new long[1] ;
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
         sImgUrl = "";
         ROClassString = "";
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.sys_rolepermissionww__datastore1(),
            new Object[][] {
                new Object[] {
               H008D2_A445SYS_RolePermissionPermissionCode, H008D2_A444SYS_RolePermissionRoleID
               }
               , new Object[] {
               H008D3_AGRID_nRecordCount
               }
            }
         );
         AV51Pgmname = "SYS_RolePermissionWW";
         /* GeneXus formulas. */
         AV51Pgmname = "SYS_RolePermissionWW";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_35 ;
      private short nGXsfl_35_idx=1 ;
      private short GRID_nEOF ;
      private short AV13OrderedBy ;
      private short initialized ;
      private short gxajaxcallmode ;
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
      private int Ddo_sys_rolepermissionpermissioncode_Datalistupdateminimumcharacters ;
      private int edtavSys_rolepermissionpermissioncode_Enabled ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_sys_rolepermissionroleidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_sys_rolepermissionpermissioncodetitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfsys_rolepermissionpermissioncode_Visible ;
      private int edtavTfsys_rolepermissionpermissioncode_sel_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV24PageToGo ;
      private int AV52GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV25GridCurrentPage ;
      private long AV27GridRecordCount ;
      private long AV26GridPageSize ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_sys_rolepermissionroleid_Activeeventkey ;
      private String Ddo_sys_rolepermissionpermissioncode_Activeeventkey ;
      private String Ddo_sys_rolepermissionpermissioncode_Filteredtext_get ;
      private String Ddo_sys_rolepermissionpermissioncode_Selectedvalue_get ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_35_idx="0001" ;
      private String AV51Pgmname ;
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
      private String Ddo_sys_rolepermissionpermissioncode_Filteredtext_set ;
      private String Ddo_sys_rolepermissionpermissioncode_Selectedvalue_set ;
      private String Ddo_sys_rolepermissionpermissioncode_Dropdownoptionstype ;
      private String Ddo_sys_rolepermissionpermissioncode_Titlecontrolidtoreplace ;
      private String Ddo_sys_rolepermissionpermissioncode_Sortedstatus ;
      private String Ddo_sys_rolepermissionpermissioncode_Filtertype ;
      private String Ddo_sys_rolepermissionpermissioncode_Datalisttype ;
      private String Ddo_sys_rolepermissionpermissioncode_Datalistproc ;
      private String Ddo_sys_rolepermissionpermissioncode_Sortasc ;
      private String Ddo_sys_rolepermissionpermissioncode_Sortdsc ;
      private String Ddo_sys_rolepermissionpermissioncode_Loadingdata ;
      private String Ddo_sys_rolepermissionpermissioncode_Cleanfilter ;
      private String Ddo_sys_rolepermissionpermissioncode_Noresultsfound ;
      private String Ddo_sys_rolepermissionpermissioncode_Searchbuttontext ;
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
      private String edtavSys_rolepermissionpermissioncode_Internalname ;
      private String edtavSys_rolepermissionpermissioncode_Jsonclick ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtSYS_RolePermissionRoleID_Title ;
      private String edtSYS_RolePermissionPermissionCode_Title ;
      private String subGrid_Header ;
      private String edtavDisplay_Link ;
      private String edtavDisplay_Tooltiptext ;
      private String edtavUpdate_Link ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavDelete_Link ;
      private String edtavDelete_Tooltiptext ;
      private String edtSYS_RolePermissionPermissionCode_Link ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_sys_rolepermissionroleid_Internalname ;
      private String edtavDdo_sys_rolepermissionroleidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_sys_rolepermissionpermissioncode_Internalname ;
      private String edtavDdo_sys_rolepermissionpermissioncodetitlecontrolidtoreplace_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavTfsys_rolepermissionpermissioncode_Internalname ;
      private String edtavTfsys_rolepermissionpermissioncode_Jsonclick ;
      private String edtavTfsys_rolepermissionpermissioncode_sel_Internalname ;
      private String edtavTfsys_rolepermissionpermissioncode_sel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDisplay_Internalname ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String edtSYS_RolePermissionRoleID_Internalname ;
      private String edtSYS_RolePermissionPermissionCode_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_35_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtSYS_RolePermissionRoleID_Jsonclick ;
      private String edtSYS_RolePermissionPermissionCode_Jsonclick ;
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
      private bool Ddo_sys_rolepermissionroleid_Includesortasc ;
      private bool Ddo_sys_rolepermissionroleid_Includesortdsc ;
      private bool Ddo_sys_rolepermissionroleid_Includefilter ;
      private bool Ddo_sys_rolepermissionroleid_Includedatalist ;
      private bool Ddo_sys_rolepermissionpermissioncode_Includesortasc ;
      private bool Ddo_sys_rolepermissionpermissioncode_Includesortdsc ;
      private bool Ddo_sys_rolepermissionpermissioncode_Includefilter ;
      private bool Ddo_sys_rolepermissionpermissioncode_Filterisrange ;
      private bool Ddo_sys_rolepermissionpermissioncode_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_35_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV28Display_IsBlob ;
      private bool AV29Update_IsBlob ;
      private bool AV31Delete_IsBlob ;
      private String AV34SYS_RolePermissionPermissionCode ;
      private String AV20TFSYS_RolePermissionPermissionCode ;
      private String AV21TFSYS_RolePermissionPermissionCode_Sel ;
      private String AV18ddo_SYS_RolePermissionRoleIDTitleControlIdToReplace ;
      private String AV22ddo_SYS_RolePermissionPermissionCodeTitleControlIdToReplace ;
      private String A445SYS_RolePermissionPermissionCode ;
      private String AV48Display_GXI ;
      private String AV49Update_GXI ;
      private String AV50Delete_GXI ;
      private String lV45SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode ;
      private String lV46SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode ;
      private String AV45SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode ;
      private String AV47SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel ;
      private String AV46SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode ;
      private String AV28Display ;
      private String AV29Update ;
      private String AV31Delete ;
      private Guid A444SYS_RolePermissionRoleID ;
      private IGxSession AV16Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_sys_rolepermissionroleid ;
      private GXUserControl ucDdo_sys_rolepermissionpermissioncode ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private String[] H008D2_A445SYS_RolePermissionPermissionCode ;
      private Guid[] H008D2_A444SYS_RolePermissionRoleID ;
      private long[] H008D3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV17SYS_RolePermissionRoleIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV19SYS_RolePermissionPermissionCodeTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV11GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV12GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV23DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class sys_rolepermissionww__datastore1 : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H008D2( IGxContext context ,
                                             String AV45SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode ,
                                             String AV47SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel ,
                                             String AV46SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode ,
                                             String A445SYS_RolePermissionPermissionCode ,
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
         sSelectString = " [PermissionCode], [RoleID]";
         sFromString = " FROM [SYS_RolePermission] WITH (NOLOCK)";
         sOrderString = "";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV45SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PermissionCode] like '%' + @lV45SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode + '%')";
            }
            else
            {
               sWhereString = sWhereString + " ([PermissionCode] like '%' + @lV45SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode + '%')";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV47SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV46SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PermissionCode] like @lV46SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode)";
            }
            else
            {
               sWhereString = sWhereString + " ([PermissionCode] like @lV46SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode)";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PermissionCode] = @AV47SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([PermissionCode] = @AV47SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel)";
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
            sOrderString = sOrderString + " ORDER BY [RoleID]";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [RoleID] DESC";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [PermissionCode]";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [PermissionCode] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [RoleID], [PermissionCode]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_H008D3( IGxContext context ,
                                             String AV45SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode ,
                                             String AV47SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel ,
                                             String AV46SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode ,
                                             String A445SYS_RolePermissionPermissionCode ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [3] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [SYS_RolePermission] WITH (NOLOCK)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV45SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PermissionCode] like '%' + @lV45SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode + '%')";
            }
            else
            {
               sWhereString = sWhereString + " ([PermissionCode] like '%' + @lV45SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode + '%')";
            }
         }
         else
         {
            GXv_int4[0] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV47SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV46SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PermissionCode] like @lV46SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode)";
            }
            else
            {
               sWhereString = sWhereString + " ([PermissionCode] like @lV46SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode)";
            }
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([PermissionCode] = @AV47SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([PermissionCode] = @AV47SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel)";
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
                     return conditional_H008D2(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (short)dynConstraints[4] , (bool)dynConstraints[5] );
               case 1 :
                     return conditional_H008D3(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (short)dynConstraints[4] , (bool)dynConstraints[5] );
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
          Object[] prmH008D2 ;
          prmH008D2 = new Object[] {
          new Object[] {"@lV45SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode",SqlDbType.NVarChar,64,0} ,
          new Object[] {"@lV46SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode",SqlDbType.NVarChar,64,0} ,
          new Object[] {"@AV47SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel",SqlDbType.NVarChar,64,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH008D3 ;
          prmH008D3 = new Object[] {
          new Object[] {"@lV45SYS_RolePermissionWWDS_1_Sys_rolepermissionpermissioncode",SqlDbType.NVarChar,64,0} ,
          new Object[] {"@lV46SYS_RolePermissionWWDS_2_Tfsys_rolepermissionpermissioncode",SqlDbType.NVarChar,64,0} ,
          new Object[] {"@AV47SYS_RolePermissionWWDS_3_Tfsys_rolepermissionpermissioncode_sel",SqlDbType.NVarChar,64,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H008D2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH008D2,11,0,true,false )
             ,new CursorDef("H008D3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH008D3,1,0,true,false )
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
                   stmt.SetParameter(sIdx, (String)parms[6]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[8]);
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
                   stmt.SetParameter(sIdx, (String)parms[3]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[4]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[5]);
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
