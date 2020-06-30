/*
               File: XT_DefineCodeWW
        Description:  数据字典数据
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:9:35.99
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
   public class xt_definecodeww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public xt_definecodeww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public xt_definecodeww( IGxContext context )
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
               nRC_GXsfl_34 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_34_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_34_idx = GetNextPar( );
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
               AV48XT_DefindcodeTypeName = GetNextPar( );
               AV13OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV14OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV23ddo_XT_DefineCodeNameTitleControlIdToReplace = GetNextPar( );
               AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace = GetNextPar( );
               AV60Pgmname = GetNextPar( );
               AV41IsAuthorized_Delete = StringUtil.StrToBool( GetNextPar( ));
               AV42IsAuthorized_XT_DefindcodeTypeName = StringUtil.StrToBool( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV48XT_DefindcodeTypeName, AV13OrderedBy, AV14OrderedDsc, AV23ddo_XT_DefineCodeNameTitleControlIdToReplace, AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace, AV60Pgmname, AV41IsAuthorized_Delete, AV42IsAuthorized_XT_DefindcodeTypeName) ;
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
         PA2G2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2G2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202281593611", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("xt_definecodeww.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vXT_DEFINDCODETYPENAME", AV48XT_DefindcodeTypeName);
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV14OrderedDsc));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_34", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_34), 4, 0, ".", "")));
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_DEFINECODENAMETITLEFILTERDATA", AV20XT_DefineCodeNameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_DEFINECODENAMETITLEFILTERDATA", AV20XT_DefineCodeNameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_DEFINDCODETYPENAMETITLEFILTERDATA", AV28XT_DefindcodeTypeNameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_DEFINDCODETYPENAMETITLEFILTERDATA", AV28XT_DefindcodeTypeNameTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV60Pgmname));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_DELETE", AV41IsAuthorized_Delete);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_XT_DEFINDCODETYPENAME", AV42IsAuthorized_XT_DefindcodeTypeName);
         GxWebStd.gx_hidden_field( context, "gxhash_vISAUTHORIZED_XT_DEFINDCODETYPENAME", GetSecureSignedToken( "", AV42IsAuthorized_XT_DefindcodeTypeName, context));
         GxWebStd.gx_hidden_field( context, "vBAS_TENANTTENANTCODE", AV53BAS_TenantTenantCode);
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
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODENAME_Activeeventkey", StringUtil.RTrim( Ddo_xt_definecodename_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPENAME_Activeeventkey", StringUtil.RTrim( Ddo_xt_defindcodetypename_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINECODENAME_Activeeventkey", StringUtil.RTrim( Ddo_xt_definecodename_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_XT_DEFINDCODETYPENAME_Activeeventkey", StringUtil.RTrim( Ddo_xt_defindcodetypename_Activeeventkey));
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
            WE2G2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2G2( ) ;
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
         return formatLink("xt_definecodeww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "XT_DefineCodeWW" ;
      }

      public override String GetPgmdesc( )
      {
         return " 数据字典数据" ;
      }

      protected void WB2G0( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroupColoredActions", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            ClassString = "Button ButtonColor";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(34), 2, 0)+","+"null"+");", "新增", bttBtninsert_Jsonclick, 5, "插入", "", StyleString, ClassString, bttBtninsert_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_XT_DefineCodeWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'',0)\"";
            ClassString = "ButtonColor";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnintialdata_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(34), 2, 0)+","+"null"+");", "初始化租户数据字典", bttBtnintialdata_Jsonclick, 7, "初始化租户数据字典", "", StyleString, ClassString, bttBtnintialdata_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"e112g1_client"+"'", TempTags, "", 2, "HLP_XT_DefineCodeWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavXt_defindcodetypename_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavXt_defindcodetypename_Internalname, "数据字典类型名称", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'" + sGXsfl_34_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavXt_defindcodetypename_Internalname, AV48XT_DefindcodeTypeName, StringUtil.RTrim( context.localUtil.Format( AV48XT_DefindcodeTypeName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,28);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavXt_defindcodetypename_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavXt_defindcodetypename_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_DefineCodeWW.htm");
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"34\">") ;
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DeleteAttribute ActionBaseColorAttribute"+"\" "+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "数据字典主键") ;
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "数据字典类型主键") ;
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "数据字典信息排序") ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV52minu));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavMinu_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV40Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A167XT_DefineCodeID), 18, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A168XT_DefineCodeName);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtXT_DefineCodeName_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtXT_DefineCodeName_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtXT_DefineCodeName_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A165XT_DefindcodeTypeID), 18, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A166XT_DefindcodeTypeName);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtXT_DefindcodeTypeName_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtXT_DefindcodeTypeName_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtXT_DefindcodeTypeName_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A171XT_DefineCodeOrder), 4, 0, ".", "")));
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
         if ( wbEnd == 34 )
         {
            wbEnd = 0;
            nRC_GXsfl_34 = (short)(nGXsfl_34_idx-1);
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
            ucDdo_xt_definecodename.SetProperty("DropDownOptionsTitleSettingsIcons", AV32DDO_TitleSettingsIcons);
            ucDdo_xt_definecodename.SetProperty("DropDownOptionsData", AV20XT_DefineCodeNameTitleFilterData);
            ucDdo_xt_definecodename.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_definecodename_Internalname, "DDO_XT_DEFINECODENAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'" + sGXsfl_34_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_definecodenametitlecontrolidtoreplace_Internalname, AV23ddo_XT_DefineCodeNameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", 0, edtavDdo_xt_definecodenametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_DefineCodeWW.htm");
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
            ucDdo_xt_defindcodetypename.SetProperty("DropDownOptionsTitleSettingsIcons", AV32DDO_TitleSettingsIcons);
            ucDdo_xt_defindcodetypename.SetProperty("DropDownOptionsData", AV28XT_DefindcodeTypeNameTitleFilterData);
            ucDdo_xt_defindcodetypename.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_xt_defindcodetypename_Internalname, "DDO_XT_DEFINDCODETYPENAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'" + sGXsfl_34_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_xt_defindcodetypenametitlecontrolidtoreplace_Internalname, AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", 0, edtavDdo_xt_defindcodetypenametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_DefineCodeWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'" + sGXsfl_34_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_XT_DefineCodeWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_34_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_XT_DefineCodeWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 34 )
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

      protected void START2G2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", " 数据字典数据", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP2G0( ) ;
      }

      protected void WS2G2( )
      {
         START2G2( ) ;
         EVT2G2( ) ;
      }

      protected void EVT2G2( )
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
                              E122G2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E132G2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_XT_DEFINECODENAME.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E142G2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_XT_DEFINDCODETYPENAME.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E152G2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E162G2 ();
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
                              nGXsfl_34_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_34_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_34_idx), 4, 0)), 4, "0");
                              SubsflControlProps_342( ) ;
                              AV37Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV37Display)) ? AV57Display_GXI : context.convertURL( context.PathToRelativeUrl( AV37Display))), !bGXsfl_34_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV37Display), true);
                              AV52minu = cgiGet( edtavMinu_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavMinu_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV52minu)) ? AV58Minu_GXI : context.convertURL( context.PathToRelativeUrl( AV52minu))), !bGXsfl_34_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavMinu_Internalname, "SrcSet", context.GetImageSrcSet( AV52minu), true);
                              AV40Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV40Delete)) ? AV59Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV40Delete))), !bGXsfl_34_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV40Delete), true);
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
                                    E172G2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E182G2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E192G2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Xt_defindcodetypename Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vXT_DEFINDCODETYPENAME"), AV48XT_DefindcodeTypeName) != 0 )
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

      protected void WE2G2( )
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

      protected void PA2G2( )
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
               GX_FocusControl = edtavXt_defindcodetypename_Internalname;
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
         SubsflControlProps_342( ) ;
         while ( nGXsfl_34_idx <= nRC_GXsfl_34 )
         {
            sendrow_342( ) ;
            nGXsfl_34_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_34_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_34_idx+1));
            sGXsfl_34_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_34_idx), 4, 0)), 4, "0");
            SubsflControlProps_342( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       String AV48XT_DefindcodeTypeName ,
                                       short AV13OrderedBy ,
                                       bool AV14OrderedDsc ,
                                       String AV23ddo_XT_DefineCodeNameTitleControlIdToReplace ,
                                       String AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace ,
                                       String AV60Pgmname ,
                                       bool AV41IsAuthorized_Delete ,
                                       bool AV42IsAuthorized_XT_DefindcodeTypeName )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF2G2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_XT_DEFINECODEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A167XT_DefineCodeID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "XT_DEFINECODEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A167XT_DefineCodeID), 18, 0, ".", "")));
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
         RF2G2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV60Pgmname = "XT_DefineCodeWW";
         context.Gx_err = 0;
      }

      protected void RF2G2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 34;
         /* Execute user event: Refresh */
         E182G2 ();
         nGXsfl_34_idx = 1;
         sGXsfl_34_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_34_idx), 4, 0)), 4, "0");
         SubsflControlProps_342( ) ;
         bGXsfl_34_Refreshing = true;
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
            SubsflControlProps_342( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV56XT_DefineCodeWWDS_1_Xt_defindcodetypename ,
                                                 A166XT_DefindcodeTypeName ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV56XT_DefineCodeWWDS_1_Xt_defindcodetypename = StringUtil.Concat( StringUtil.RTrim( AV56XT_DefineCodeWWDS_1_Xt_defindcodetypename), "%", "");
            /* Using cursor H002G2 */
            pr_default.execute(0, new Object[] {lV56XT_DefineCodeWWDS_1_Xt_defindcodetypename, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_34_idx = 1;
            sGXsfl_34_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_34_idx), 4, 0)), 4, "0");
            SubsflControlProps_342( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A171XT_DefineCodeOrder = H002G2_A171XT_DefineCodeOrder[0];
               n171XT_DefineCodeOrder = H002G2_n171XT_DefineCodeOrder[0];
               A166XT_DefindcodeTypeName = H002G2_A166XT_DefindcodeTypeName[0];
               n166XT_DefindcodeTypeName = H002G2_n166XT_DefindcodeTypeName[0];
               A165XT_DefindcodeTypeID = H002G2_A165XT_DefindcodeTypeID[0];
               A168XT_DefineCodeName = H002G2_A168XT_DefineCodeName[0];
               n168XT_DefineCodeName = H002G2_n168XT_DefineCodeName[0];
               A167XT_DefineCodeID = H002G2_A167XT_DefineCodeID[0];
               A166XT_DefindcodeTypeName = H002G2_A166XT_DefindcodeTypeName[0];
               n166XT_DefindcodeTypeName = H002G2_n166XT_DefindcodeTypeName[0];
               E192G2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 34;
            WB2G0( ) ;
         }
         bGXsfl_34_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes2G2( )
      {
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_XT_DEFINDCODETYPENAME", AV42IsAuthorized_XT_DefindcodeTypeName);
         GxWebStd.gx_hidden_field( context, "gxhash_vISAUTHORIZED_XT_DEFINDCODETYPENAME", GetSecureSignedToken( "", AV42IsAuthorized_XT_DefindcodeTypeName, context));
         GxWebStd.gx_hidden_field( context, "gxhash_XT_DEFINECODEID"+"_"+sGXsfl_34_idx, GetSecureSignedToken( sGXsfl_34_idx, context.localUtil.Format( (decimal)(A167XT_DefineCodeID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         AV56XT_DefineCodeWWDS_1_Xt_defindcodetypename = AV48XT_DefindcodeTypeName;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV56XT_DefineCodeWWDS_1_Xt_defindcodetypename ,
                                              A166XT_DefindcodeTypeName ,
                                              AV13OrderedBy ,
                                              AV14OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV56XT_DefineCodeWWDS_1_Xt_defindcodetypename = StringUtil.Concat( StringUtil.RTrim( AV56XT_DefineCodeWWDS_1_Xt_defindcodetypename), "%", "");
         /* Using cursor H002G3 */
         pr_default.execute(1, new Object[] {lV56XT_DefineCodeWWDS_1_Xt_defindcodetypename});
         GRID_nRecordCount = H002G3_AGRID_nRecordCount[0];
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
         AV56XT_DefineCodeWWDS_1_Xt_defindcodetypename = AV48XT_DefindcodeTypeName;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV48XT_DefindcodeTypeName, AV13OrderedBy, AV14OrderedDsc, AV23ddo_XT_DefineCodeNameTitleControlIdToReplace, AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace, AV60Pgmname, AV41IsAuthorized_Delete, AV42IsAuthorized_XT_DefindcodeTypeName) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV56XT_DefineCodeWWDS_1_Xt_defindcodetypename = AV48XT_DefindcodeTypeName;
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
            gxgrGrid_refresh( subGrid_Rows, AV48XT_DefindcodeTypeName, AV13OrderedBy, AV14OrderedDsc, AV23ddo_XT_DefineCodeNameTitleControlIdToReplace, AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace, AV60Pgmname, AV41IsAuthorized_Delete, AV42IsAuthorized_XT_DefindcodeTypeName) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV56XT_DefineCodeWWDS_1_Xt_defindcodetypename = AV48XT_DefindcodeTypeName;
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
            gxgrGrid_refresh( subGrid_Rows, AV48XT_DefindcodeTypeName, AV13OrderedBy, AV14OrderedDsc, AV23ddo_XT_DefineCodeNameTitleControlIdToReplace, AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace, AV60Pgmname, AV41IsAuthorized_Delete, AV42IsAuthorized_XT_DefindcodeTypeName) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV56XT_DefineCodeWWDS_1_Xt_defindcodetypename = AV48XT_DefindcodeTypeName;
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
            gxgrGrid_refresh( subGrid_Rows, AV48XT_DefindcodeTypeName, AV13OrderedBy, AV14OrderedDsc, AV23ddo_XT_DefineCodeNameTitleControlIdToReplace, AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace, AV60Pgmname, AV41IsAuthorized_Delete, AV42IsAuthorized_XT_DefindcodeTypeName) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV56XT_DefineCodeWWDS_1_Xt_defindcodetypename = AV48XT_DefindcodeTypeName;
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
            gxgrGrid_refresh( subGrid_Rows, AV48XT_DefindcodeTypeName, AV13OrderedBy, AV14OrderedDsc, AV23ddo_XT_DefineCodeNameTitleControlIdToReplace, AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace, AV60Pgmname, AV41IsAuthorized_Delete, AV42IsAuthorized_XT_DefindcodeTypeName) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP2G0( )
      {
         /* Before Start, stand alone formulas. */
         AV60Pgmname = "XT_DefineCodeWW";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E172G2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV32DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_DEFINECODENAMETITLEFILTERDATA"), AV20XT_DefineCodeNameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vXT_DEFINDCODETYPENAMETITLEFILTERDATA"), AV28XT_DefindcodeTypeNameTitleFilterData);
            /* Read variables values. */
            AV48XT_DefindcodeTypeName = cgiGet( edtavXt_defindcodetypename_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48XT_DefindcodeTypeName", AV48XT_DefindcodeTypeName);
            AV23ddo_XT_DefineCodeNameTitleControlIdToReplace = cgiGet( edtavDdo_xt_definecodenametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_XT_DefineCodeNameTitleControlIdToReplace", AV23ddo_XT_DefineCodeNameTitleControlIdToReplace);
            AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace = cgiGet( edtavDdo_xt_defindcodetypenametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace", AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace);
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
            /* Read saved values. */
            nRC_GXsfl_34 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_34"), ".", ","));
            AV34GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV36GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV35GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
            AV53BAS_TenantTenantCode = cgiGet( "vBAS_TENANTTENANTCODE");
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
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_xt_definecodename_Activeeventkey = cgiGet( "DDO_XT_DEFINECODENAME_Activeeventkey");
            Ddo_xt_defindcodetypename_Activeeventkey = cgiGet( "DDO_XT_DEFINDCODETYPENAME_Activeeventkey");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( StringUtil.StrCmp(cgiGet( "GXH_vXT_DEFINDCODETYPENAME"), AV48XT_DefindcodeTypeName) != 0 )
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
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E172G2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E172G2( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GXt_boolean1 = AV42IsAuthorized_XT_DefindcodeTypeName;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_DefindcodeType", out  GXt_boolean1) ;
         AV42IsAuthorized_XT_DefindcodeTypeName = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42IsAuthorized_XT_DefindcodeTypeName", AV42IsAuthorized_XT_DefindcodeTypeName);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vISAUTHORIZED_XT_DEFINDCODETYPENAME", GetSecureSignedToken( "", AV42IsAuthorized_XT_DefindcodeTypeName, context));
         Ddo_xt_definecodename_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_DefineCodeName";
         ucDdo_xt_definecodename.SendProperty(context, "", false, Ddo_xt_definecodename_Internalname, "TitleControlIdToReplace", Ddo_xt_definecodename_Titlecontrolidtoreplace);
         AV23ddo_XT_DefineCodeNameTitleControlIdToReplace = Ddo_xt_definecodename_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_XT_DefineCodeNameTitleControlIdToReplace", AV23ddo_XT_DefineCodeNameTitleControlIdToReplace);
         edtavDdo_xt_definecodenametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_definecodenametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_definecodenametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_xt_defindcodetypename_Titlecontrolidtoreplace = subGrid_Internalname+"_XT_DefindcodeTypeName";
         ucDdo_xt_defindcodetypename.SendProperty(context, "", false, Ddo_xt_defindcodetypename_Internalname, "TitleControlIdToReplace", Ddo_xt_defindcodetypename_Titlecontrolidtoreplace);
         AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace = Ddo_xt_defindcodetypename_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace", AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace);
         edtavDdo_xt_defindcodetypenametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_xt_defindcodetypenametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_xt_defindcodetypenametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " 数据字典数据";
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
         }
         edtavOrdereddsc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrdereddsc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrdereddsc_Visible), 5, 0)), true);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV32DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV32DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E182G2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV20XT_DefineCodeNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28XT_DefindcodeTypeNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         /* Execute user subroutine: 'CHECKSECURITYFORACTIONS' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'SAVEGRIDSTATE' */
         S142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         edtXT_DefineCodeName_Titleformat = 2;
         edtXT_DefineCodeName_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "数据字典名称", AV23ddo_XT_DefineCodeNameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_DefineCodeName_Internalname, "Title", edtXT_DefineCodeName_Title, !bGXsfl_34_Refreshing);
         edtXT_DefindcodeTypeName_Titleformat = 2;
         edtXT_DefindcodeTypeName_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "数据字典类型名称", AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_DefindcodeTypeName_Internalname, "Title", edtXT_DefindcodeTypeName_Title, !bGXsfl_34_Refreshing);
         AV34GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34GridCurrentPage), 10, 0)));
         AV35GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV35GridPageSize), 10, 0)));
         AV36GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV36GridRecordCount), 10, 0)));
         AV56XT_DefineCodeWWDS_1_Xt_defindcodetypename = AV48XT_DefindcodeTypeName;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20XT_DefineCodeNameTitleFilterData", AV20XT_DefineCodeNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28XT_DefindcodeTypeNameTitleFilterData", AV28XT_DefindcodeTypeNameTitleFilterData);
      }

      protected void E122G2( )
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

      protected void E132G2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E142G2( )
      {
         /* Ddo_xt_definecodename_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_definecodename_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV13OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_xt_definecodename_Sortedstatus = "ASC";
            ucDdo_xt_definecodename.SendProperty(context, "", false, Ddo_xt_definecodename_Internalname, "SortedStatus", Ddo_xt_definecodename_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_definecodename_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV13OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_xt_definecodename_Sortedstatus = "DSC";
            ucDdo_xt_definecodename.SendProperty(context, "", false, Ddo_xt_definecodename_Internalname, "SortedStatus", Ddo_xt_definecodename_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20XT_DefineCodeNameTitleFilterData", AV20XT_DefineCodeNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28XT_DefindcodeTypeNameTitleFilterData", AV28XT_DefindcodeTypeNameTitleFilterData);
      }

      protected void E152G2( )
      {
         /* Ddo_xt_defindcodetypename_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_xt_defindcodetypename_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV13OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_xt_defindcodetypename_Sortedstatus = "ASC";
            ucDdo_xt_defindcodetypename.SendProperty(context, "", false, Ddo_xt_defindcodetypename_Internalname, "SortedStatus", Ddo_xt_defindcodetypename_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_xt_defindcodetypename_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV13OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_xt_defindcodetypename_Sortedstatus = "DSC";
            ucDdo_xt_defindcodetypename.SendProperty(context, "", false, Ddo_xt_defindcodetypename_Internalname, "SortedStatus", Ddo_xt_defindcodetypename_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20XT_DefineCodeNameTitleFilterData", AV20XT_DefineCodeNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28XT_DefindcodeTypeNameTitleFilterData", AV28XT_DefindcodeTypeNameTitleFilterData);
      }

      private void E192G2( )
      {
         /* Grid_Load Routine */
         AV37Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDisplay_Internalname, AV37Display);
         AV57Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = formatLink("xt_definecodeview.aspx") + "?" + UrlEncode("" +A167XT_DefineCodeID) + "," + UrlEncode(StringUtil.RTrim(""));
         AV52minu = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavMinu_Internalname, AV52minu);
         AV58Minu_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavMinu_Tooltiptext = "";
         AV40Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV40Delete);
         AV59Delete_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavDelete_Tooltiptext = "删除";
         if ( AV41IsAuthorized_Delete )
         {
            edtavDelete_Link = formatLink("xt_definecode.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A167XT_DefineCodeID);
         }
         edtXT_DefineCodeName_Link = formatLink("xt_definecodeview.aspx") + "?" + UrlEncode("" +A167XT_DefineCodeID) + "," + UrlEncode(StringUtil.RTrim(""));
         if ( AV42IsAuthorized_XT_DefindcodeTypeName )
         {
            edtXT_DefindcodeTypeName_Link = formatLink("xt_defindcodetypeview.aspx") + "?" + UrlEncode("" +A165XT_DefindcodeTypeID) + "," + UrlEncode(StringUtil.RTrim(""));
         }
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 34;
         }
         sendrow_342( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_34_Refreshing )
         {
            context.DoAjaxLoad(34, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void E162G2( )
      {
         /* 'DoInsert' Routine */
         if ( 1 == 0 )
         {
            CallWebObject(formatLink("xt_definecode.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
            context.wjLocDisableFrm = 1;
         }
         CallWebObject(formatLink("xt_definecodeoperate.aspx") + "?" + UrlEncode("" +1) + "," + UrlEncode("" +A167XT_DefineCodeID));
         context.wjLocDisableFrm = 1;
      }

      protected void S132( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean1 = AV41IsAuthorized_Delete;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_DefineCode", out  GXt_boolean1) ;
         AV41IsAuthorized_Delete = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41IsAuthorized_Delete", AV41IsAuthorized_Delete);
         if ( ! ( AV41IsAuthorized_Delete ) )
         {
            edtavDelete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Visible), 5, 0)), !bGXsfl_34_Refreshing);
         }
         GXt_boolean1 = AV43TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_DefineCode", out  GXt_boolean1) ;
         AV43TempBoolean = GXt_boolean1;
         if ( ! ( AV43TempBoolean ) )
         {
            bttBtninsert_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtninsert_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtninsert_Visible), 5, 0)), true);
         }
         GXt_boolean1 = AV43TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_DefineCode", out  GXt_boolean1) ;
         AV43TempBoolean = GXt_boolean1;
         if ( ! ( AV43TempBoolean ) )
         {
            bttBtnintialdata_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnintialdata_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnintialdata_Visible), 5, 0)), true);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV15Session.Get(AV60Pgmname+"GridState"), "") == 0 )
         {
            AV11GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV60Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV11GridState.FromXml(AV15Session.Get(AV60Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV13OrderedBy = AV11GridState.gxTpr_Orderedby;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
         AV14OrderedDsc = AV11GridState.gxTpr_Ordereddsc;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
         AV61GXV1 = 1;
         while ( AV61GXV1 <= AV11GridState.gxTpr_Filtervalues.Count )
         {
            AV12GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV11GridState.gxTpr_Filtervalues.Item(AV61GXV1));
            if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "XT_DEFINDCODETYPENAME") == 0 )
            {
               AV48XT_DefindcodeTypeName = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48XT_DefindcodeTypeName", AV48XT_DefindcodeTypeName);
            }
            AV61GXV1 = (int)(AV61GXV1+1);
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
         AV11GridState.FromXml(AV15Session.Get(AV60Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV11GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV11GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV11GridState.gxTpr_Filtervalues.Clear();
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48XT_DefindcodeTypeName)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "XT_DEFINDCODETYPENAME";
            AV12GridStateFilterValue.gxTpr_Value = AV48XT_DefindcodeTypeName;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         AV11GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV11GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV60Pgmname+"GridState",  AV11GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV60Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "XT_DefineCode";
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
         PA2G2( ) ;
         WS2G2( ) ;
         WE2G2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202281594189", true);
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
         context.AddJavascriptSource("xt_definecodeww.js", "?20202281594189", false);
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

      protected void SubsflControlProps_342( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_34_idx;
         edtavMinu_Internalname = "vMINU_"+sGXsfl_34_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_34_idx;
         edtXT_DefineCodeID_Internalname = "XT_DEFINECODEID_"+sGXsfl_34_idx;
         edtXT_DefineCodeName_Internalname = "XT_DEFINECODENAME_"+sGXsfl_34_idx;
         edtXT_DefindcodeTypeID_Internalname = "XT_DEFINDCODETYPEID_"+sGXsfl_34_idx;
         edtXT_DefindcodeTypeName_Internalname = "XT_DEFINDCODETYPENAME_"+sGXsfl_34_idx;
         edtXT_DefineCodeOrder_Internalname = "XT_DEFINECODEORDER_"+sGXsfl_34_idx;
      }

      protected void SubsflControlProps_fel_342( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_34_fel_idx;
         edtavMinu_Internalname = "vMINU_"+sGXsfl_34_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_34_fel_idx;
         edtXT_DefineCodeID_Internalname = "XT_DEFINECODEID_"+sGXsfl_34_fel_idx;
         edtXT_DefineCodeName_Internalname = "XT_DEFINECODENAME_"+sGXsfl_34_fel_idx;
         edtXT_DefindcodeTypeID_Internalname = "XT_DEFINDCODETYPEID_"+sGXsfl_34_fel_idx;
         edtXT_DefindcodeTypeName_Internalname = "XT_DEFINDCODETYPENAME_"+sGXsfl_34_fel_idx;
         edtXT_DefineCodeOrder_Internalname = "XT_DEFINECODEORDER_"+sGXsfl_34_fel_idx;
      }

      protected void sendrow_342( )
      {
         SubsflControlProps_342( ) ;
         WB2G0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_34_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_34_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_34_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV37Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV37Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV57Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV37Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV37Display)) ? AV57Display_GXI : context.PathToRelativeUrl( AV37Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV37Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavMinu_Enabled!=0)&&(edtavMinu_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 36,'',false,'',34)\"" : " ");
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV52minu_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV52minu))&&String.IsNullOrEmpty(StringUtil.RTrim( AV58Minu_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV52minu)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV52minu)) ? AV58Minu_GXI : context.PathToRelativeUrl( AV52minu));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavMinu_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavMinu_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)7,(String)edtavMinu_Jsonclick,(String)"'"+""+"'"+",false,"+"'"+"e202g2_client"+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV52minu_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "DeleteAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV40Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV40Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV59Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV40Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV40Delete)) ? AV59Delete_GXI : context.PathToRelativeUrl( AV40Delete));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)edtavDelete_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavDelete_Visible,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV40Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_DefineCodeID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A167XT_DefineCodeID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A167XT_DefineCodeID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_DefineCodeID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)34,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_DefineCodeName_Internalname,(String)A168XT_DefineCodeName,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtXT_DefineCodeName_Link,(String)"",(String)"",(String)"",(String)edtXT_DefineCodeName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)34,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_DefindcodeTypeID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A165XT_DefindcodeTypeID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A165XT_DefindcodeTypeID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_DefindcodeTypeID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)34,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_DefindcodeTypeName_Internalname,(String)A166XT_DefindcodeTypeName,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtXT_DefindcodeTypeName_Link,(String)"",(String)"",(String)"",(String)edtXT_DefindcodeTypeName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)34,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtXT_DefineCodeOrder_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A171XT_DefineCodeOrder), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A171XT_DefineCodeOrder), "ZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtXT_DefineCodeOrder_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)34,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            send_integrity_lvl_hashes2G2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_34_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_34_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_34_idx+1));
            sGXsfl_34_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_34_idx), 4, 0)), 4, "0");
            SubsflControlProps_342( ) ;
         }
         /* End function sendrow_342 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtninsert_Internalname = "BTNINSERT";
         bttBtnintialdata_Internalname = "BTNINTIALDATA";
         edtavXt_defindcodetypename_Internalname = "vXT_DEFINDCODETYPENAME";
         divTableactions_Internalname = "TABLEACTIONS";
         divTableheader_Internalname = "TABLEHEADER";
         divLayout_tableheader_Internalname = "LAYOUT_TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         divHtml_dvpanel_tableheader_Internalname = "HTML_DVPANEL_TABLEHEADER";
         edtavDisplay_Internalname = "vDISPLAY";
         edtavMinu_Internalname = "vMINU";
         edtavDelete_Internalname = "vDELETE";
         edtXT_DefineCodeID_Internalname = "XT_DEFINECODEID";
         edtXT_DefineCodeName_Internalname = "XT_DEFINECODENAME";
         edtXT_DefindcodeTypeID_Internalname = "XT_DEFINDCODETYPEID";
         edtXT_DefindcodeTypeName_Internalname = "XT_DEFINDCODETYPENAME";
         edtXT_DefineCodeOrder_Internalname = "XT_DEFINECODEORDER";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_xt_definecodename_Internalname = "DDO_XT_DEFINECODENAME";
         edtavDdo_xt_definecodenametitlecontrolidtoreplace_Internalname = "vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE";
         Ddo_xt_defindcodetypename_Internalname = "DDO_XT_DEFINDCODETYPENAME";
         edtavDdo_xt_defindcodetypenametitlecontrolidtoreplace_Internalname = "vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE";
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
         edtavMinu_Jsonclick = "";
         edtavMinu_Visible = -1;
         edtavMinu_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_xt_defindcodetypenametitlecontrolidtoreplace_Visible = 1;
         edtavDdo_xt_definecodenametitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtXT_DefindcodeTypeName_Link = "";
         edtXT_DefineCodeName_Link = "";
         edtavDelete_Tooltiptext = "删除";
         edtavDelete_Link = "";
         edtavMinu_Tooltiptext = "";
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtXT_DefindcodeTypeName_Titleformat = 0;
         edtXT_DefindcodeTypeName_Title = "数据字典类型名称";
         edtXT_DefineCodeName_Titleformat = 0;
         edtXT_DefineCodeName_Title = "数据字典名称";
         edtavDelete_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         edtavXt_defindcodetypename_Jsonclick = "";
         edtavXt_defindcodetypename_Enabled = 1;
         bttBtnintialdata_Visible = 1;
         bttBtninsert_Visible = 1;
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
         Form.Caption = " 数据字典数据";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV23ddo_XT_DefineCodeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV48XT_DefindcodeTypeName',fld:'vXT_DEFINDCODETYPENAME',pic:''},{av:'AV60Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV42IsAuthorized_XT_DefindcodeTypeName',fld:'vISAUTHORIZED_XT_DEFINDCODETYPENAME',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV20XT_DefineCodeNameTitleFilterData',fld:'vXT_DEFINECODENAMETITLEFILTERDATA',pic:''},{av:'AV28XT_DefindcodeTypeNameTitleFilterData',fld:'vXT_DEFINDCODETYPENAMETITLEFILTERDATA',pic:''},{av:'edtXT_DefineCodeName_Titleformat',ctrl:'XT_DEFINECODENAME',prop:'Titleformat'},{av:'edtXT_DefineCodeName_Title',ctrl:'XT_DEFINECODENAME',prop:'Title'},{av:'edtXT_DefindcodeTypeName_Titleformat',ctrl:'XT_DEFINDCODETYPENAME',prop:'Titleformat'},{av:'edtXT_DefindcodeTypeName_Title',ctrl:'XT_DEFINDCODETYPENAME',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'},{ctrl:'BTNINTIALDATA',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E122G2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV48XT_DefindcodeTypeName',fld:'vXT_DEFINDCODETYPENAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV23ddo_XT_DefineCodeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV60Pgmname',fld:'vPGMNAME',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV42IsAuthorized_XT_DefindcodeTypeName',fld:'vISAUTHORIZED_XT_DEFINDCODETYPENAME',pic:'',hsh:true},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E132G2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV48XT_DefindcodeTypeName',fld:'vXT_DEFINDCODETYPENAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV23ddo_XT_DefineCodeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV60Pgmname',fld:'vPGMNAME',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV42IsAuthorized_XT_DefindcodeTypeName',fld:'vISAUTHORIZED_XT_DEFINDCODETYPENAME',pic:'',hsh:true},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_XT_DEFINECODENAME.ONOPTIONCLICKED","{handler:'E142G2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV48XT_DefindcodeTypeName',fld:'vXT_DEFINDCODETYPENAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV23ddo_XT_DefineCodeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV60Pgmname',fld:'vPGMNAME',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV42IsAuthorized_XT_DefindcodeTypeName',fld:'vISAUTHORIZED_XT_DEFINDCODETYPENAME',pic:'',hsh:true},{av:'Ddo_xt_definecodename_Activeeventkey',ctrl:'DDO_XT_DEFINECODENAME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_DEFINECODENAME.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_definecodename_Sortedstatus',ctrl:'DDO_XT_DEFINECODENAME',prop:'SortedStatus'},{av:'AV20XT_DefineCodeNameTitleFilterData',fld:'vXT_DEFINECODENAMETITLEFILTERDATA',pic:''},{av:'AV28XT_DefindcodeTypeNameTitleFilterData',fld:'vXT_DEFINDCODETYPENAMETITLEFILTERDATA',pic:''},{av:'edtXT_DefineCodeName_Titleformat',ctrl:'XT_DEFINECODENAME',prop:'Titleformat'},{av:'edtXT_DefineCodeName_Title',ctrl:'XT_DEFINECODENAME',prop:'Title'},{av:'edtXT_DefindcodeTypeName_Titleformat',ctrl:'XT_DEFINDCODETYPENAME',prop:'Titleformat'},{av:'edtXT_DefindcodeTypeName_Title',ctrl:'XT_DEFINDCODETYPENAME',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'},{ctrl:'BTNINTIALDATA',prop:'Visible'}]}");
         setEventMetadata("DDO_XT_DEFINDCODETYPENAME.ONOPTIONCLICKED","{handler:'E152G2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV48XT_DefindcodeTypeName',fld:'vXT_DEFINDCODETYPENAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV23ddo_XT_DefineCodeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINECODENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace',fld:'vDDO_XT_DEFINDCODETYPENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV60Pgmname',fld:'vPGMNAME',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV42IsAuthorized_XT_DefindcodeTypeName',fld:'vISAUTHORIZED_XT_DEFINDCODETYPENAME',pic:'',hsh:true},{av:'Ddo_xt_defindcodetypename_Activeeventkey',ctrl:'DDO_XT_DEFINDCODETYPENAME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_XT_DEFINDCODETYPENAME.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_xt_defindcodetypename_Sortedstatus',ctrl:'DDO_XT_DEFINDCODETYPENAME',prop:'SortedStatus'},{av:'AV20XT_DefineCodeNameTitleFilterData',fld:'vXT_DEFINECODENAMETITLEFILTERDATA',pic:''},{av:'AV28XT_DefindcodeTypeNameTitleFilterData',fld:'vXT_DEFINDCODETYPENAMETITLEFILTERDATA',pic:''},{av:'edtXT_DefineCodeName_Titleformat',ctrl:'XT_DEFINECODENAME',prop:'Titleformat'},{av:'edtXT_DefineCodeName_Title',ctrl:'XT_DEFINECODENAME',prop:'Title'},{av:'edtXT_DefindcodeTypeName_Titleformat',ctrl:'XT_DEFINDCODETYPENAME',prop:'Titleformat'},{av:'edtXT_DefindcodeTypeName_Title',ctrl:'XT_DEFINDCODETYPENAME',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'},{ctrl:'BTNINTIALDATA',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E192G2',iparms:[{av:'A167XT_DefineCodeID',fld:'XT_DEFINECODEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV42IsAuthorized_XT_DefindcodeTypeName',fld:'vISAUTHORIZED_XT_DEFINDCODETYPENAME',pic:'',hsh:true},{av:'A165XT_DefindcodeTypeID',fld:'XT_DEFINDCODETYPEID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV37Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'},{av:'AV52minu',fld:'vMINU',pic:''},{av:'edtavMinu_Tooltiptext',ctrl:'vMINU',prop:'Tooltiptext'},{av:'AV40Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'},{av:'edtXT_DefineCodeName_Link',ctrl:'XT_DEFINECODENAME',prop:'Link'},{av:'edtXT_DefindcodeTypeName_Link',ctrl:'XT_DEFINDCODETYPENAME',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E162G2',iparms:[{av:'A167XT_DefineCodeID',fld:'XT_DEFINECODEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("'DOINSERT'",",oparms:[]}");
         setEventMetadata("'DOINTIALDATA'","{handler:'E112G1',iparms:[{av:'AV53BAS_TenantTenantCode',fld:'vBAS_TENANTTENANTCODE',pic:''}]");
         setEventMetadata("'DOINTIALDATA'",",oparms:[{av:'AV53BAS_TenantTenantCode',fld:'vBAS_TENANTTENANTCODE',pic:''}]}");
         setEventMetadata("VMINU.CLICK","{handler:'E202G2',iparms:[{av:'A167XT_DefineCodeID',fld:'XT_DEFINECODEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("VMINU.CLICK",",oparms:[]}");
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
         Ddo_xt_definecodename_Activeeventkey = "";
         Ddo_xt_defindcodetypename_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV48XT_DefindcodeTypeName = "";
         AV23ddo_XT_DefineCodeNameTitleControlIdToReplace = "";
         AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace = "";
         AV60Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV32DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV20XT_DefineCodeNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28XT_DefindcodeTypeNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV53BAS_TenantTenantCode = "";
         Ddo_xt_definecodename_Sortedstatus = "";
         Ddo_xt_defindcodetypename_Sortedstatus = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ucDvpanel_tableheader = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtninsert_Jsonclick = "";
         bttBtnintialdata_Jsonclick = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV37Display = "";
         AV52minu = "";
         AV40Delete = "";
         A168XT_DefineCodeName = "";
         A166XT_DefindcodeTypeName = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_xt_definecodename = new GXUserControl();
         ucDdo_xt_defindcodetypename = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV57Display_GXI = "";
         AV58Minu_GXI = "";
         AV59Delete_GXI = "";
         scmdbuf = "";
         lV56XT_DefineCodeWWDS_1_Xt_defindcodetypename = "";
         AV56XT_DefineCodeWWDS_1_Xt_defindcodetypename = "";
         H002G2_A171XT_DefineCodeOrder = new short[1] ;
         H002G2_n171XT_DefineCodeOrder = new bool[] {false} ;
         H002G2_A166XT_DefindcodeTypeName = new String[] {""} ;
         H002G2_n166XT_DefindcodeTypeName = new bool[] {false} ;
         H002G2_A165XT_DefindcodeTypeID = new long[1] ;
         H002G2_A168XT_DefineCodeName = new String[] {""} ;
         H002G2_n168XT_DefineCodeName = new bool[] {false} ;
         H002G2_A167XT_DefineCodeID = new long[1] ;
         H002G3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.xt_definecodeww__default(),
            new Object[][] {
                new Object[] {
               H002G2_A171XT_DefineCodeOrder, H002G2_n171XT_DefineCodeOrder, H002G2_A166XT_DefindcodeTypeName, H002G2_n166XT_DefindcodeTypeName, H002G2_A165XT_DefindcodeTypeID, H002G2_A168XT_DefineCodeName, H002G2_n168XT_DefineCodeName, H002G2_A167XT_DefineCodeID
               }
               , new Object[] {
               H002G3_AGRID_nRecordCount
               }
            }
         );
         AV60Pgmname = "XT_DefineCodeWW";
         /* GeneXus formulas. */
         AV60Pgmname = "XT_DefineCodeWW";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_34 ;
      private short nGXsfl_34_idx=1 ;
      private short GRID_nEOF ;
      private short AV13OrderedBy ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtXT_DefineCodeName_Titleformat ;
      private short edtXT_DefindcodeTypeName_Titleformat ;
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
      private int bttBtninsert_Visible ;
      private int bttBtnintialdata_Visible ;
      private int edtavXt_defindcodetypename_Enabled ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavDelete_Visible ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_xt_definecodenametitlecontrolidtoreplace_Visible ;
      private int edtavDdo_xt_defindcodetypenametitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV33PageToGo ;
      private int AV61GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavMinu_Enabled ;
      private int edtavMinu_Visible ;
      private long GRID_nFirstRecordOnPage ;
      private long AV34GridCurrentPage ;
      private long AV36GridRecordCount ;
      private long AV35GridPageSize ;
      private long A167XT_DefineCodeID ;
      private long A165XT_DefindcodeTypeID ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_xt_definecodename_Activeeventkey ;
      private String Ddo_xt_defindcodetypename_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_34_idx="0001" ;
      private String AV60Pgmname ;
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
      private String Ddo_xt_definecodename_Caption ;
      private String Ddo_xt_definecodename_Tooltip ;
      private String Ddo_xt_definecodename_Cls ;
      private String Ddo_xt_definecodename_Dropdownoptionstype ;
      private String Ddo_xt_definecodename_Titlecontrolidtoreplace ;
      private String Ddo_xt_definecodename_Sortedstatus ;
      private String Ddo_xt_definecodename_Sortasc ;
      private String Ddo_xt_definecodename_Sortdsc ;
      private String Ddo_xt_definecodename_Searchbuttontext ;
      private String Ddo_xt_defindcodetypename_Caption ;
      private String Ddo_xt_defindcodetypename_Tooltip ;
      private String Ddo_xt_defindcodetypename_Cls ;
      private String Ddo_xt_defindcodetypename_Dropdownoptionstype ;
      private String Ddo_xt_defindcodetypename_Titlecontrolidtoreplace ;
      private String Ddo_xt_defindcodetypename_Sortedstatus ;
      private String Ddo_xt_defindcodetypename_Sortasc ;
      private String Ddo_xt_defindcodetypename_Sortdsc ;
      private String Ddo_xt_defindcodetypename_Searchbuttontext ;
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
      private String bttBtnintialdata_Internalname ;
      private String bttBtnintialdata_Jsonclick ;
      private String edtavXt_defindcodetypename_Internalname ;
      private String edtavXt_defindcodetypename_Jsonclick ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtXT_DefineCodeName_Title ;
      private String edtXT_DefindcodeTypeName_Title ;
      private String subGrid_Header ;
      private String edtavDisplay_Link ;
      private String edtavDisplay_Tooltiptext ;
      private String edtavMinu_Tooltiptext ;
      private String edtavDelete_Link ;
      private String edtavDelete_Tooltiptext ;
      private String edtXT_DefineCodeName_Link ;
      private String edtXT_DefindcodeTypeName_Link ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_xt_definecodename_Internalname ;
      private String edtavDdo_xt_definecodenametitlecontrolidtoreplace_Internalname ;
      private String Ddo_xt_defindcodetypename_Internalname ;
      private String edtavDdo_xt_defindcodetypenametitlecontrolidtoreplace_Internalname ;
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
      private String edtavMinu_Internalname ;
      private String edtavDelete_Internalname ;
      private String edtXT_DefineCodeID_Internalname ;
      private String edtXT_DefineCodeName_Internalname ;
      private String edtXT_DefindcodeTypeID_Internalname ;
      private String edtXT_DefindcodeTypeName_Internalname ;
      private String edtXT_DefineCodeOrder_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_34_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavMinu_Jsonclick ;
      private String ROClassString ;
      private String edtXT_DefineCodeID_Jsonclick ;
      private String edtXT_DefineCodeName_Jsonclick ;
      private String edtXT_DefindcodeTypeID_Jsonclick ;
      private String edtXT_DefindcodeTypeName_Jsonclick ;
      private String edtXT_DefineCodeOrder_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV14OrderedDsc ;
      private bool AV41IsAuthorized_Delete ;
      private bool AV42IsAuthorized_XT_DefindcodeTypeName ;
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
      private bool Ddo_xt_definecodename_Includesortasc ;
      private bool Ddo_xt_definecodename_Includesortdsc ;
      private bool Ddo_xt_definecodename_Includefilter ;
      private bool Ddo_xt_definecodename_Includedatalist ;
      private bool Ddo_xt_defindcodetypename_Includesortasc ;
      private bool Ddo_xt_defindcodetypename_Includesortdsc ;
      private bool Ddo_xt_defindcodetypename_Includefilter ;
      private bool Ddo_xt_defindcodetypename_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_34_Refreshing=false ;
      private bool n168XT_DefineCodeName ;
      private bool n166XT_DefindcodeTypeName ;
      private bool n171XT_DefineCodeOrder ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV43TempBoolean ;
      private bool GXt_boolean1 ;
      private bool AV37Display_IsBlob ;
      private bool AV52minu_IsBlob ;
      private bool AV40Delete_IsBlob ;
      private String AV48XT_DefindcodeTypeName ;
      private String AV23ddo_XT_DefineCodeNameTitleControlIdToReplace ;
      private String AV31ddo_XT_DefindcodeTypeNameTitleControlIdToReplace ;
      private String AV53BAS_TenantTenantCode ;
      private String A168XT_DefineCodeName ;
      private String A166XT_DefindcodeTypeName ;
      private String AV57Display_GXI ;
      private String AV58Minu_GXI ;
      private String AV59Delete_GXI ;
      private String lV56XT_DefineCodeWWDS_1_Xt_defindcodetypename ;
      private String AV56XT_DefineCodeWWDS_1_Xt_defindcodetypename ;
      private String AV37Display ;
      private String AV52minu ;
      private String AV40Delete ;
      private IGxSession AV15Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_xt_definecodename ;
      private GXUserControl ucDdo_xt_defindcodetypename ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] H002G2_A171XT_DefineCodeOrder ;
      private bool[] H002G2_n171XT_DefineCodeOrder ;
      private String[] H002G2_A166XT_DefindcodeTypeName ;
      private bool[] H002G2_n166XT_DefindcodeTypeName ;
      private long[] H002G2_A165XT_DefindcodeTypeID ;
      private String[] H002G2_A168XT_DefineCodeName ;
      private bool[] H002G2_n168XT_DefineCodeName ;
      private long[] H002G2_A167XT_DefineCodeID ;
      private long[] H002G3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV20XT_DefineCodeNameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV28XT_DefindcodeTypeNameTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV11GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV12GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV32DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class xt_definecodeww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H002G2( IGxContext context ,
                                             String AV56XT_DefineCodeWWDS_1_Xt_defindcodetypename ,
                                             String A166XT_DefindcodeTypeName ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [4] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " T1.[XT_DefineCodeOrder], T2.[XT_DefindcodeTypeName], T1.[XT_DefindcodeTypeID], T1.[XT_DefineCodeName], T1.[XT_DefineCodeID]";
         sFromString = " FROM ([XT_DefineCode] T1 WITH (NOLOCK) INNER JOIN [XT_DefindcodeType] T2 WITH (NOLOCK) ON T2.[XT_DefindcodeTypeID] = T1.[XT_DefindcodeTypeID])";
         sOrderString = "";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56XT_DefineCodeWWDS_1_Xt_defindcodetypename)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[XT_DefindcodeTypeName] like '%' + @lV56XT_DefineCodeWWDS_1_Xt_defindcodetypename + '%')";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[XT_DefindcodeTypeName] like '%' + @lV56XT_DefineCodeWWDS_1_Xt_defindcodetypename + '%')";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         if ( AV13OrderedBy == 1 )
         {
            sOrderString = sOrderString + " ORDER BY T1.[XT_DefineCodeID] DESC";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[XT_DefineCodeName]";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[XT_DefineCodeName] DESC";
         }
         else if ( ( AV13OrderedBy == 3 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T2.[XT_DefindcodeTypeName]";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T2.[XT_DefindcodeTypeName] DESC";
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

      protected Object[] conditional_H002G3( IGxContext context ,
                                             String AV56XT_DefineCodeWWDS_1_Xt_defindcodetypename ,
                                             String A166XT_DefindcodeTypeName ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [1] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM ([XT_DefineCode] T1 WITH (NOLOCK) INNER JOIN [XT_DefindcodeType] T2 WITH (NOLOCK) ON T2.[XT_DefindcodeTypeID] = T1.[XT_DefindcodeTypeID])";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56XT_DefineCodeWWDS_1_Xt_defindcodetypename)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[XT_DefindcodeTypeName] like '%' + @lV56XT_DefineCodeWWDS_1_Xt_defindcodetypename + '%')";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[XT_DefindcodeTypeName] like '%' + @lV56XT_DefineCodeWWDS_1_Xt_defindcodetypename + '%')";
            }
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         if ( AV13OrderedBy == 1 )
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
                     return conditional_H002G2(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (short)dynConstraints[2] , (bool)dynConstraints[3] );
               case 1 :
                     return conditional_H002G3(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (short)dynConstraints[2] , (bool)dynConstraints[3] );
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
          Object[] prmH002G2 ;
          prmH002G2 = new Object[] {
          new Object[] {"@lV56XT_DefineCodeWWDS_1_Xt_defindcodetypename",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH002G3 ;
          prmH002G3 = new Object[] {
          new Object[] {"@lV56XT_DefineCodeWWDS_1_Xt_defindcodetypename",SqlDbType.NVarChar,40,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002G2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002G2,11,0,true,false )
             ,new CursorDef("H002G3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002G3,1,0,true,false )
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
                   stmt.SetParameter(sIdx, (String)parms[4]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[5]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[6]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[7]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[1]);
                }
                return;
       }
    }

 }

}
