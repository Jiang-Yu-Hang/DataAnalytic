/*
               File: Test4
        Description: Test4
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 6/5/2019 10:45:50.51
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
   public class test4 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public test4( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public test4( IGxContext context )
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
         cmbavStatus = new GXCombobox();
         cmbview_NE_Status = new GXCombobox();
         chkavIsapprove = new GXCheckbox();
         chkavIsrecheck = new GXCheckbox();
         chkavIsupdate = new GXCheckbox();
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
               AV13OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV14OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV17TFview_NE_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV18TFview_NE_EncounterID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV21TFview_NE_Department = GetNextPar( );
               AV22TFview_NE_Department_Sel = GetNextPar( );
               AV25TFview_NE_ENCType = GetNextPar( );
               AV26TFview_NE_ENCType_Sel = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( AV13OrderedBy, AV14OrderedDsc, AV17TFview_NE_EncounterID, AV18TFview_NE_EncounterID_To, AV21TFview_NE_Department, AV22TFview_NE_Department_Sel, AV25TFview_NE_ENCType, AV26TFview_NE_ENCType_Sel) ;
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
         PAAB2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            STARTAB2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20196510455058", false);
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
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("test4.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vTFVIEW_NE_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFview_NE_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFVIEW_NE_ENCOUNTERID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFview_NE_EncounterID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFVIEW_NE_DEPARTMENT", AV21TFview_NE_Department);
         GxWebStd.gx_hidden_field( context, "GXH_vTFVIEW_NE_DEPARTMENT_SEL", AV22TFview_NE_Department_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFVIEW_NE_ENCTYPE", AV25TFview_NE_ENCType);
         GxWebStd.gx_hidden_field( context, "GXH_vTFVIEW_NE_ENCTYPE_SEL", AV26TFview_NE_ENCType_Sel);
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_28", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_28), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV64GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV66GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV65GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV62DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV62DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vVIEW_NE_ENCOUNTERIDTITLEFILTERDATA", AV16view_NE_EncounterIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vVIEW_NE_ENCOUNTERIDTITLEFILTERDATA", AV16view_NE_EncounterIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vVIEW_NE_DEPARTMENTTITLEFILTERDATA", AV20view_NE_DepartmentTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vVIEW_NE_DEPARTMENTTITLEFILTERDATA", AV20view_NE_DepartmentTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vVIEW_NE_ENCTYPETITLEFILTERDATA", AV24view_NE_ENCTypeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vVIEW_NE_ENCTYPETITLEFILTERDATA", AV24view_NE_ENCTypeTitleFilterData);
         }
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
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageoptions", StringUtil.RTrim( Gridpaginationbar_Rowsperpageoptions));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Emptygridcaption", StringUtil.RTrim( Gridpaginationbar_Emptygridcaption));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpagecaption", StringUtil.RTrim( Gridpaginationbar_Rowsperpagecaption));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Caption", StringUtil.RTrim( Ddo_view_ne_encounterid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Tooltip", StringUtil.RTrim( Ddo_view_ne_encounterid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Cls", StringUtil.RTrim( Ddo_view_ne_encounterid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Dropdownoptionstype", StringUtil.RTrim( Ddo_view_ne_encounterid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Includesortasc", StringUtil.BoolToStr( Ddo_view_ne_encounterid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Includesortdsc", StringUtil.BoolToStr( Ddo_view_ne_encounterid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Includefilter", StringUtil.BoolToStr( Ddo_view_ne_encounterid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Filtertype", StringUtil.RTrim( Ddo_view_ne_encounterid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Filterisrange", StringUtil.BoolToStr( Ddo_view_ne_encounterid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Includedatalist", StringUtil.BoolToStr( Ddo_view_ne_encounterid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Sortasc", StringUtil.RTrim( Ddo_view_ne_encounterid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Sortdsc", StringUtil.RTrim( Ddo_view_ne_encounterid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Cleanfilter", StringUtil.RTrim( Ddo_view_ne_encounterid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Rangefilterfrom", StringUtil.RTrim( Ddo_view_ne_encounterid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Rangefilterto", StringUtil.RTrim( Ddo_view_ne_encounterid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Searchbuttontext", StringUtil.RTrim( Ddo_view_ne_encounterid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_DEPARTMENT_Caption", StringUtil.RTrim( Ddo_view_ne_department_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_DEPARTMENT_Tooltip", StringUtil.RTrim( Ddo_view_ne_department_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_DEPARTMENT_Cls", StringUtil.RTrim( Ddo_view_ne_department_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_DEPARTMENT_Dropdownoptionstype", StringUtil.RTrim( Ddo_view_ne_department_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_DEPARTMENT_Includesortasc", StringUtil.BoolToStr( Ddo_view_ne_department_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_DEPARTMENT_Includesortdsc", StringUtil.BoolToStr( Ddo_view_ne_department_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_DEPARTMENT_Includefilter", StringUtil.BoolToStr( Ddo_view_ne_department_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_DEPARTMENT_Filtertype", StringUtil.RTrim( Ddo_view_ne_department_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_DEPARTMENT_Filterisrange", StringUtil.BoolToStr( Ddo_view_ne_department_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_DEPARTMENT_Includedatalist", StringUtil.BoolToStr( Ddo_view_ne_department_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_DEPARTMENT_Datalisttype", StringUtil.RTrim( Ddo_view_ne_department_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_DEPARTMENT_Datalistproc", StringUtil.RTrim( Ddo_view_ne_department_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_DEPARTMENT_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_view_ne_department_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_DEPARTMENT_Sortasc", StringUtil.RTrim( Ddo_view_ne_department_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_DEPARTMENT_Sortdsc", StringUtil.RTrim( Ddo_view_ne_department_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_DEPARTMENT_Loadingdata", StringUtil.RTrim( Ddo_view_ne_department_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_DEPARTMENT_Cleanfilter", StringUtil.RTrim( Ddo_view_ne_department_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_DEPARTMENT_Noresultsfound", StringUtil.RTrim( Ddo_view_ne_department_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_DEPARTMENT_Searchbuttontext", StringUtil.RTrim( Ddo_view_ne_department_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCTYPE_Caption", StringUtil.RTrim( Ddo_view_ne_enctype_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCTYPE_Tooltip", StringUtil.RTrim( Ddo_view_ne_enctype_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCTYPE_Cls", StringUtil.RTrim( Ddo_view_ne_enctype_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCTYPE_Dropdownoptionstype", StringUtil.RTrim( Ddo_view_ne_enctype_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCTYPE_Includesortasc", StringUtil.BoolToStr( Ddo_view_ne_enctype_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCTYPE_Includesortdsc", StringUtil.BoolToStr( Ddo_view_ne_enctype_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCTYPE_Includefilter", StringUtil.BoolToStr( Ddo_view_ne_enctype_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCTYPE_Filtertype", StringUtil.RTrim( Ddo_view_ne_enctype_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCTYPE_Filterisrange", StringUtil.BoolToStr( Ddo_view_ne_enctype_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCTYPE_Includedatalist", StringUtil.BoolToStr( Ddo_view_ne_enctype_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCTYPE_Datalisttype", StringUtil.RTrim( Ddo_view_ne_enctype_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCTYPE_Datalistproc", StringUtil.RTrim( Ddo_view_ne_enctype_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCTYPE_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_view_ne_enctype_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCTYPE_Sortasc", StringUtil.RTrim( Ddo_view_ne_enctype_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCTYPE_Sortdsc", StringUtil.RTrim( Ddo_view_ne_enctype_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCTYPE_Loadingdata", StringUtil.RTrim( Ddo_view_ne_enctype_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCTYPE_Cleanfilter", StringUtil.RTrim( Ddo_view_ne_enctype_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCTYPE_Noresultsfound", StringUtil.RTrim( Ddo_view_ne_enctype_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCTYPE_Searchbuttontext", StringUtil.RTrim( Ddo_view_ne_enctype_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Title", StringUtil.RTrim( Dvelop_confirmpanel_deleteencounter_Title));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Confirmationtext", StringUtil.RTrim( Dvelop_confirmpanel_deleteencounter_Confirmationtext));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Yesbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_deleteencounter_Yesbuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Nobuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_deleteencounter_Nobuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Cancelbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_deleteencounter_Cancelbuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Yesbuttonposition", StringUtil.RTrim( Dvelop_confirmpanel_deleteencounter_Yesbuttonposition));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Confirmtype", StringUtil.RTrim( Dvelop_confirmpanel_deleteencounter_Confirmtype));
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
            WEAB2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVTAB2( ) ;
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
         return formatLink("test4.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "Test4" ;
      }

      public override String GetPgmdesc( )
      {
         return "Test4" ;
      }

      protected void WBAB0( )
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
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(28), 2, 0)+","+"null"+");", "插入", bttBtninsert_Jsonclick, 7, "插入", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e11ab1_client"+"'", TempTags, "", 2, "HLP_Test4.htm");
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "就诊序号") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "就诊科室") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "就诊方式") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "就诊/入院时间") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "就诊/入院时间") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "审批状态") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "审批状态") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"AttributeCheckBox"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "初审抽查") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "view_NE_Is Rand Approve") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"AttributeCheckBox"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "复审抽查") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "view_NE_Is Rand Recheck") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"AttributeCheckBox"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "是否修改") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "view_NE_Is Update") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "view_NE_Tenant Tenant Code") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "view_NE_Information_ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "view_NE_Information_Patient No") ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV75deleteEncounter));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A549view_NE_EncounterID), 18, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A550view_NE_Department);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A551view_NE_ENCType);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(AV70AdmitDate, "99/99/99"));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavAdmitdate_Enabled), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.TToC( A552view_NE_AdmitDate, 10, 8, 0, 0, "/", ":", " "));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV71status), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbavStatus.Enabled), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A553view_NE_Status), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.BoolToStr( AV72IsApprove));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkavIsapprove.Enabled), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A555view_NE_IsRandApprove), 1, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.BoolToStr( AV73IsRecheck));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkavIsrecheck.Enabled), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A554view_NE_IsRandRecheck), 1, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.BoolToStr( AV74IsUpdate));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkavIsupdate.Enabled), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A556view_NE_IsUpdate), 1, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A557view_NE_TenantTenantCode);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A558view_NE_Information_ID), 18, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A559view_NE_Information_PatientNo);
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV64GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV66GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV65GridPageSize);
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
            ucDdo_view_ne_encounterid.SetProperty("Caption", Ddo_view_ne_encounterid_Caption);
            ucDdo_view_ne_encounterid.SetProperty("Tooltip", Ddo_view_ne_encounterid_Tooltip);
            ucDdo_view_ne_encounterid.SetProperty("Cls", Ddo_view_ne_encounterid_Cls);
            ucDdo_view_ne_encounterid.SetProperty("DropDownOptionsType", Ddo_view_ne_encounterid_Dropdownoptionstype);
            ucDdo_view_ne_encounterid.SetProperty("IncludeSortASC", Ddo_view_ne_encounterid_Includesortasc);
            ucDdo_view_ne_encounterid.SetProperty("IncludeSortDSC", Ddo_view_ne_encounterid_Includesortdsc);
            ucDdo_view_ne_encounterid.SetProperty("IncludeFilter", Ddo_view_ne_encounterid_Includefilter);
            ucDdo_view_ne_encounterid.SetProperty("FilterType", Ddo_view_ne_encounterid_Filtertype);
            ucDdo_view_ne_encounterid.SetProperty("FilterIsRange", Ddo_view_ne_encounterid_Filterisrange);
            ucDdo_view_ne_encounterid.SetProperty("IncludeDataList", Ddo_view_ne_encounterid_Includedatalist);
            ucDdo_view_ne_encounterid.SetProperty("SortASC", Ddo_view_ne_encounterid_Sortasc);
            ucDdo_view_ne_encounterid.SetProperty("SortDSC", Ddo_view_ne_encounterid_Sortdsc);
            ucDdo_view_ne_encounterid.SetProperty("CleanFilter", Ddo_view_ne_encounterid_Cleanfilter);
            ucDdo_view_ne_encounterid.SetProperty("RangeFilterFrom", Ddo_view_ne_encounterid_Rangefilterfrom);
            ucDdo_view_ne_encounterid.SetProperty("RangeFilterTo", Ddo_view_ne_encounterid_Rangefilterto);
            ucDdo_view_ne_encounterid.SetProperty("SearchButtonText", Ddo_view_ne_encounterid_Searchbuttontext);
            ucDdo_view_ne_encounterid.SetProperty("DropDownOptionsTitleSettingsIcons", AV62DDO_TitleSettingsIcons);
            ucDdo_view_ne_encounterid.SetProperty("DropDownOptionsData", AV16view_NE_EncounterIDTitleFilterData);
            ucDdo_view_ne_encounterid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_view_ne_encounterid_Internalname, "DDO_VIEW_NE_ENCOUNTERIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_view_ne_encounteridtitlecontrolidtoreplace_Internalname, AV19ddo_view_NE_EncounterIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", 0, 1, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, false, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_Test4.htm");
            /* User Defined Control */
            ucDdo_view_ne_department.SetProperty("Caption", Ddo_view_ne_department_Caption);
            ucDdo_view_ne_department.SetProperty("Tooltip", Ddo_view_ne_department_Tooltip);
            ucDdo_view_ne_department.SetProperty("Cls", Ddo_view_ne_department_Cls);
            ucDdo_view_ne_department.SetProperty("DropDownOptionsType", Ddo_view_ne_department_Dropdownoptionstype);
            ucDdo_view_ne_department.SetProperty("IncludeSortASC", Ddo_view_ne_department_Includesortasc);
            ucDdo_view_ne_department.SetProperty("IncludeSortDSC", Ddo_view_ne_department_Includesortdsc);
            ucDdo_view_ne_department.SetProperty("IncludeFilter", Ddo_view_ne_department_Includefilter);
            ucDdo_view_ne_department.SetProperty("FilterType", Ddo_view_ne_department_Filtertype);
            ucDdo_view_ne_department.SetProperty("FilterIsRange", Ddo_view_ne_department_Filterisrange);
            ucDdo_view_ne_department.SetProperty("IncludeDataList", Ddo_view_ne_department_Includedatalist);
            ucDdo_view_ne_department.SetProperty("DataListType", Ddo_view_ne_department_Datalisttype);
            ucDdo_view_ne_department.SetProperty("DataListProc", Ddo_view_ne_department_Datalistproc);
            ucDdo_view_ne_department.SetProperty("DataListUpdateMinimumCharacters", Ddo_view_ne_department_Datalistupdateminimumcharacters);
            ucDdo_view_ne_department.SetProperty("SortASC", Ddo_view_ne_department_Sortasc);
            ucDdo_view_ne_department.SetProperty("SortDSC", Ddo_view_ne_department_Sortdsc);
            ucDdo_view_ne_department.SetProperty("LoadingData", Ddo_view_ne_department_Loadingdata);
            ucDdo_view_ne_department.SetProperty("CleanFilter", Ddo_view_ne_department_Cleanfilter);
            ucDdo_view_ne_department.SetProperty("NoResultsFound", Ddo_view_ne_department_Noresultsfound);
            ucDdo_view_ne_department.SetProperty("SearchButtonText", Ddo_view_ne_department_Searchbuttontext);
            ucDdo_view_ne_department.SetProperty("DropDownOptionsTitleSettingsIcons", AV62DDO_TitleSettingsIcons);
            ucDdo_view_ne_department.SetProperty("DropDownOptionsData", AV20view_NE_DepartmentTitleFilterData);
            ucDdo_view_ne_department.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_view_ne_department_Internalname, "DDO_VIEW_NE_DEPARTMENTContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_view_ne_departmenttitlecontrolidtoreplace_Internalname, AV23ddo_view_NE_DepartmentTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", 0, 1, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, false, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_Test4.htm");
            /* User Defined Control */
            ucDdo_view_ne_enctype.SetProperty("Caption", Ddo_view_ne_enctype_Caption);
            ucDdo_view_ne_enctype.SetProperty("Tooltip", Ddo_view_ne_enctype_Tooltip);
            ucDdo_view_ne_enctype.SetProperty("Cls", Ddo_view_ne_enctype_Cls);
            ucDdo_view_ne_enctype.SetProperty("DropDownOptionsType", Ddo_view_ne_enctype_Dropdownoptionstype);
            ucDdo_view_ne_enctype.SetProperty("IncludeSortASC", Ddo_view_ne_enctype_Includesortasc);
            ucDdo_view_ne_enctype.SetProperty("IncludeSortDSC", Ddo_view_ne_enctype_Includesortdsc);
            ucDdo_view_ne_enctype.SetProperty("IncludeFilter", Ddo_view_ne_enctype_Includefilter);
            ucDdo_view_ne_enctype.SetProperty("FilterType", Ddo_view_ne_enctype_Filtertype);
            ucDdo_view_ne_enctype.SetProperty("FilterIsRange", Ddo_view_ne_enctype_Filterisrange);
            ucDdo_view_ne_enctype.SetProperty("IncludeDataList", Ddo_view_ne_enctype_Includedatalist);
            ucDdo_view_ne_enctype.SetProperty("DataListType", Ddo_view_ne_enctype_Datalisttype);
            ucDdo_view_ne_enctype.SetProperty("DataListProc", Ddo_view_ne_enctype_Datalistproc);
            ucDdo_view_ne_enctype.SetProperty("DataListUpdateMinimumCharacters", Ddo_view_ne_enctype_Datalistupdateminimumcharacters);
            ucDdo_view_ne_enctype.SetProperty("SortASC", Ddo_view_ne_enctype_Sortasc);
            ucDdo_view_ne_enctype.SetProperty("SortDSC", Ddo_view_ne_enctype_Sortdsc);
            ucDdo_view_ne_enctype.SetProperty("LoadingData", Ddo_view_ne_enctype_Loadingdata);
            ucDdo_view_ne_enctype.SetProperty("CleanFilter", Ddo_view_ne_enctype_Cleanfilter);
            ucDdo_view_ne_enctype.SetProperty("NoResultsFound", Ddo_view_ne_enctype_Noresultsfound);
            ucDdo_view_ne_enctype.SetProperty("SearchButtonText", Ddo_view_ne_enctype_Searchbuttontext);
            ucDdo_view_ne_enctype.SetProperty("DropDownOptionsTitleSettingsIcons", AV62DDO_TitleSettingsIcons);
            ucDdo_view_ne_enctype.SetProperty("DropDownOptionsData", AV24view_NE_ENCTypeTitleFilterData);
            ucDdo_view_ne_enctype.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_view_ne_enctype_Internalname, "DDO_VIEW_NE_ENCTYPEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_view_ne_enctypetitlecontrolidtoreplace_Internalname, AV27ddo_view_NE_ENCTypeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", 0, 1, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, false, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_Test4.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavView_ne_encounterid_selected_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV77view_NE_EncounterID_Selected), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV77view_NE_EncounterID_Selected), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,60);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavView_ne_encounterid_selected_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, false, "", "right", false, "HLP_Test4.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,61);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, false, "", "right", false, "HLP_Test4.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,62);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, false, "", "right", false, "HLP_Test4.htm");
            wb_table1_63_AB2( true) ;
         }
         else
         {
            wb_table1_63_AB2( false) ;
         }
         return  ;
      }

      protected void wb_table1_63_AB2e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfview_ne_encounterid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFview_NE_EncounterID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV17TFview_NE_EncounterID), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,68);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfview_ne_encounterid_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, false, "", "right", false, "HLP_Test4.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfview_ne_encounterid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFview_NE_EncounterID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV18TFview_NE_EncounterID_To), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,69);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfview_ne_encounterid_to_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, false, "", "right", false, "HLP_Test4.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfview_ne_department_Internalname, AV21TFview_NE_Department, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,70);\"", 0, 1, 1, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, false, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_Test4.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfview_ne_department_sel_Internalname, AV22TFview_NE_Department_Sel, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,71);\"", 0, 1, 1, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, false, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_Test4.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfview_ne_enctype_Internalname, AV25TFview_NE_ENCType, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,72);\"", 0, 1, 1, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, false, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_Test4.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfview_ne_enctype_sel_Internalname, AV26TFview_NE_ENCType_Sel, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,73);\"", 0, 1, 1, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, false, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_Test4.htm");
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

      protected void STARTAB2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "Test4", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUPAB0( ) ;
      }

      protected void WSAB2( )
      {
         STARTAB2( ) ;
         EVTAB2( ) ;
      }

      protected void EVTAB2( )
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
                              AV75deleteEncounter = cgiGet( edtavDeleteencounter_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDeleteencounter_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV75deleteEncounter)) ? AV86Deleteencounter_GXI : context.convertURL( context.PathToRelativeUrl( AV75deleteEncounter))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDeleteencounter_Internalname, "SrcSet", context.GetImageSrcSet( AV75deleteEncounter), true);
                              A549view_NE_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtview_NE_EncounterID_Internalname), ".", ","));
                              A550view_NE_Department = cgiGet( edtview_NE_Department_Internalname);
                              n550view_NE_Department = false;
                              A551view_NE_ENCType = cgiGet( edtview_NE_ENCType_Internalname);
                              n551view_NE_ENCType = false;
                              if ( context.localUtil.VCDateTime( cgiGet( edtavAdmitdate_Internalname), 0, 0) == 0 )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Admit Date"}), 1, "vADMITDATE");
                                 GX_FocusControl = edtavAdmitdate_Internalname;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true;
                                 AV70AdmitDate = (DateTime)(DateTime.MinValue);
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavAdmitdate_Internalname, context.localUtil.Format(AV70AdmitDate, "99/99/99"));
                              }
                              else
                              {
                                 AV70AdmitDate = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtavAdmitdate_Internalname), 0));
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavAdmitdate_Internalname, context.localUtil.Format(AV70AdmitDate, "99/99/99"));
                              }
                              A552view_NE_AdmitDate = context.localUtil.CToT( cgiGet( edtview_NE_AdmitDate_Internalname), 0);
                              n552view_NE_AdmitDate = false;
                              cmbavStatus.Name = cmbavStatus_Internalname;
                              cmbavStatus.CurrentValue = cgiGet( cmbavStatus_Internalname);
                              AV71status = (short)(NumberUtil.Val( cgiGet( cmbavStatus_Internalname), "."));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavStatus_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV71status), 4, 0)));
                              cmbview_NE_Status.Name = cmbview_NE_Status_Internalname;
                              cmbview_NE_Status.CurrentValue = cgiGet( cmbview_NE_Status_Internalname);
                              A553view_NE_Status = (short)(NumberUtil.Val( cgiGet( cmbview_NE_Status_Internalname), "."));
                              n553view_NE_Status = false;
                              AV72IsApprove = StringUtil.StrToBool( cgiGet( chkavIsapprove_Internalname));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavIsapprove_Internalname, AV72IsApprove);
                              A555view_NE_IsRandApprove = (short)(context.localUtil.CToN( cgiGet( edtview_NE_IsRandApprove_Internalname), ".", ","));
                              n555view_NE_IsRandApprove = false;
                              AV73IsRecheck = StringUtil.StrToBool( cgiGet( chkavIsrecheck_Internalname));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavIsrecheck_Internalname, AV73IsRecheck);
                              A554view_NE_IsRandRecheck = (short)(context.localUtil.CToN( cgiGet( edtview_NE_IsRandRecheck_Internalname), ".", ","));
                              n554view_NE_IsRandRecheck = false;
                              AV74IsUpdate = StringUtil.StrToBool( cgiGet( chkavIsupdate_Internalname));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavIsupdate_Internalname, AV74IsUpdate);
                              A556view_NE_IsUpdate = (short)(context.localUtil.CToN( cgiGet( edtview_NE_IsUpdate_Internalname), ".", ","));
                              n556view_NE_IsUpdate = false;
                              A557view_NE_TenantTenantCode = cgiGet( edtview_NE_TenantTenantCode_Internalname);
                              n557view_NE_TenantTenantCode = false;
                              A558view_NE_Information_ID = (long)(context.localUtil.CToN( cgiGet( edtview_NE_Information_ID_Internalname), ".", ","));
                              n558view_NE_Information_ID = false;
                              A559view_NE_Information_PatientNo = cgiGet( edtview_NE_Information_PatientNo_Internalname);
                              n559view_NE_Information_PatientNo = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E12AB2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E13AB2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E14AB2 ();
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
                                       /* Set Refresh If Tfview_ne_encounterid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFVIEW_NE_ENCOUNTERID"), ".", ",") != Convert.ToDecimal( AV17TFview_NE_EncounterID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfview_ne_encounterid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFVIEW_NE_ENCOUNTERID_TO"), ".", ",") != Convert.ToDecimal( AV18TFview_NE_EncounterID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfview_ne_department Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFVIEW_NE_DEPARTMENT"), AV21TFview_NE_Department) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfview_ne_department_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFVIEW_NE_DEPARTMENT_SEL"), AV22TFview_NE_Department_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfview_ne_enctype Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFVIEW_NE_ENCTYPE"), AV25TFview_NE_ENCType) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfview_ne_enctype_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFVIEW_NE_ENCTYPE_SEL"), AV26TFview_NE_ENCType_Sel) != 0 )
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

      protected void WEAB2( )
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

      protected void PAAB2( )
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
               GX_FocusControl = edtavDdo_view_ne_encounteridtitlecontrolidtoreplace_Internalname;
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

      protected void gxgrGrid_refresh( short AV13OrderedBy ,
                                       bool AV14OrderedDsc ,
                                       long AV17TFview_NE_EncounterID ,
                                       long AV18TFview_NE_EncounterID_To ,
                                       String AV21TFview_NE_Department ,
                                       String AV22TFview_NE_Department_Sel ,
                                       String AV25TFview_NE_ENCType ,
                                       String AV26TFview_NE_ENCType_Sel )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GRID_nCurrentRecord = 0;
         RFAB2( ) ;
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
         RFAB2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavAdmitdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAdmitdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAdmitdate_Enabled), 5, 0)), !bGXsfl_28_Refreshing);
         cmbavStatus.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavStatus_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavStatus.Enabled), 5, 0)), !bGXsfl_28_Refreshing);
         chkavIsapprove.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavIsapprove_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavIsapprove.Enabled), 5, 0)), !bGXsfl_28_Refreshing);
         chkavIsrecheck.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavIsrecheck_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavIsrecheck.Enabled), 5, 0)), !bGXsfl_28_Refreshing);
         chkavIsupdate.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavIsupdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavIsupdate.Enabled), 5, 0)), !bGXsfl_28_Refreshing);
      }

      protected void RFAB2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 28;
         /* Execute user event: Refresh */
         E13AB2 ();
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
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV80Test4DS_1_Tfview_ne_encounterid ,
                                                 AV81Test4DS_2_Tfview_ne_encounterid_to ,
                                                 AV83Test4DS_4_Tfview_ne_department_sel ,
                                                 AV82Test4DS_3_Tfview_ne_department ,
                                                 AV85Test4DS_6_Tfview_ne_enctype_sel ,
                                                 AV84Test4DS_5_Tfview_ne_enctype ,
                                                 A549view_NE_EncounterID ,
                                                 A550view_NE_Department ,
                                                 A551view_NE_ENCType ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                                 TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV82Test4DS_3_Tfview_ne_department = StringUtil.Concat( StringUtil.RTrim( AV82Test4DS_3_Tfview_ne_department), "%", "");
            lV84Test4DS_5_Tfview_ne_enctype = StringUtil.Concat( StringUtil.RTrim( AV84Test4DS_5_Tfview_ne_enctype), "%", "");
            /* Using cursor H00AB2 */
            pr_default.execute(0, new Object[] {AV80Test4DS_1_Tfview_ne_encounterid, AV81Test4DS_2_Tfview_ne_encounterid_to, lV82Test4DS_3_Tfview_ne_department, AV83Test4DS_4_Tfview_ne_department_sel, lV84Test4DS_5_Tfview_ne_enctype, AV85Test4DS_6_Tfview_ne_enctype_sel});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A559view_NE_Information_PatientNo = H00AB2_A559view_NE_Information_PatientNo[0];
               n559view_NE_Information_PatientNo = H00AB2_n559view_NE_Information_PatientNo[0];
               A558view_NE_Information_ID = H00AB2_A558view_NE_Information_ID[0];
               n558view_NE_Information_ID = H00AB2_n558view_NE_Information_ID[0];
               A557view_NE_TenantTenantCode = H00AB2_A557view_NE_TenantTenantCode[0];
               n557view_NE_TenantTenantCode = H00AB2_n557view_NE_TenantTenantCode[0];
               A556view_NE_IsUpdate = H00AB2_A556view_NE_IsUpdate[0];
               n556view_NE_IsUpdate = H00AB2_n556view_NE_IsUpdate[0];
               A554view_NE_IsRandRecheck = H00AB2_A554view_NE_IsRandRecheck[0];
               n554view_NE_IsRandRecheck = H00AB2_n554view_NE_IsRandRecheck[0];
               A555view_NE_IsRandApprove = H00AB2_A555view_NE_IsRandApprove[0];
               n555view_NE_IsRandApprove = H00AB2_n555view_NE_IsRandApprove[0];
               A553view_NE_Status = H00AB2_A553view_NE_Status[0];
               n553view_NE_Status = H00AB2_n553view_NE_Status[0];
               A552view_NE_AdmitDate = H00AB2_A552view_NE_AdmitDate[0];
               n552view_NE_AdmitDate = H00AB2_n552view_NE_AdmitDate[0];
               A551view_NE_ENCType = H00AB2_A551view_NE_ENCType[0];
               n551view_NE_ENCType = H00AB2_n551view_NE_ENCType[0];
               A550view_NE_Department = H00AB2_A550view_NE_Department[0];
               n550view_NE_Department = H00AB2_n550view_NE_Department[0];
               A549view_NE_EncounterID = H00AB2_A549view_NE_EncounterID[0];
               E14AB2 ();
               pr_default.readNext(0);
            }
            pr_default.close(0);
            wbEnd = 28;
            WBAB0( ) ;
         }
         bGXsfl_28_Refreshing = true;
      }

      protected void send_integrity_lvl_hashesAB2( )
      {
      }

      protected int subGrid_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid_Recordsperpage( )
      {
         return (int)(-1) ;
      }

      protected int subGrid_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected void STRUPAB0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavAdmitdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAdmitdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAdmitdate_Enabled), 5, 0)), !bGXsfl_28_Refreshing);
         cmbavStatus.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavStatus_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavStatus.Enabled), 5, 0)), !bGXsfl_28_Refreshing);
         chkavIsapprove.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavIsapprove_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavIsapprove.Enabled), 5, 0)), !bGXsfl_28_Refreshing);
         chkavIsrecheck.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavIsrecheck_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavIsrecheck.Enabled), 5, 0)), !bGXsfl_28_Refreshing);
         chkavIsupdate.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavIsupdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavIsupdate.Enabled), 5, 0)), !bGXsfl_28_Refreshing);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E12AB2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV62DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vVIEW_NE_ENCOUNTERIDTITLEFILTERDATA"), AV16view_NE_EncounterIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vVIEW_NE_DEPARTMENTTITLEFILTERDATA"), AV20view_NE_DepartmentTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vVIEW_NE_ENCTYPETITLEFILTERDATA"), AV24view_NE_ENCTypeTitleFilterData);
            /* Read variables values. */
            /* Read saved values. */
            nRC_GXsfl_28 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_28"), ".", ","));
            AV64GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV66GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV65GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Gridpaginationbar_Rowsperpageoptions = cgiGet( "GRIDPAGINATIONBAR_Rowsperpageoptions");
            Gridpaginationbar_Emptygridcaption = cgiGet( "GRIDPAGINATIONBAR_Emptygridcaption");
            Gridpaginationbar_Rowsperpagecaption = cgiGet( "GRIDPAGINATIONBAR_Rowsperpagecaption");
            Ddo_view_ne_encounterid_Caption = cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Caption");
            Ddo_view_ne_encounterid_Tooltip = cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Tooltip");
            Ddo_view_ne_encounterid_Cls = cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Cls");
            Ddo_view_ne_encounterid_Dropdownoptionstype = cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Dropdownoptionstype");
            Ddo_view_ne_encounterid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Includesortasc"));
            Ddo_view_ne_encounterid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Includesortdsc"));
            Ddo_view_ne_encounterid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Includefilter"));
            Ddo_view_ne_encounterid_Filtertype = cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Filtertype");
            Ddo_view_ne_encounterid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Filterisrange"));
            Ddo_view_ne_encounterid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Includedatalist"));
            Ddo_view_ne_encounterid_Sortasc = cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Sortasc");
            Ddo_view_ne_encounterid_Sortdsc = cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Sortdsc");
            Ddo_view_ne_encounterid_Cleanfilter = cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Cleanfilter");
            Ddo_view_ne_encounterid_Rangefilterfrom = cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Rangefilterfrom");
            Ddo_view_ne_encounterid_Rangefilterto = cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Rangefilterto");
            Ddo_view_ne_encounterid_Searchbuttontext = cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Searchbuttontext");
            Ddo_view_ne_department_Caption = cgiGet( "DDO_VIEW_NE_DEPARTMENT_Caption");
            Ddo_view_ne_department_Tooltip = cgiGet( "DDO_VIEW_NE_DEPARTMENT_Tooltip");
            Ddo_view_ne_department_Cls = cgiGet( "DDO_VIEW_NE_DEPARTMENT_Cls");
            Ddo_view_ne_department_Dropdownoptionstype = cgiGet( "DDO_VIEW_NE_DEPARTMENT_Dropdownoptionstype");
            Ddo_view_ne_department_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NE_DEPARTMENT_Includesortasc"));
            Ddo_view_ne_department_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NE_DEPARTMENT_Includesortdsc"));
            Ddo_view_ne_department_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NE_DEPARTMENT_Includefilter"));
            Ddo_view_ne_department_Filtertype = cgiGet( "DDO_VIEW_NE_DEPARTMENT_Filtertype");
            Ddo_view_ne_department_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NE_DEPARTMENT_Filterisrange"));
            Ddo_view_ne_department_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NE_DEPARTMENT_Includedatalist"));
            Ddo_view_ne_department_Datalisttype = cgiGet( "DDO_VIEW_NE_DEPARTMENT_Datalisttype");
            Ddo_view_ne_department_Datalistproc = cgiGet( "DDO_VIEW_NE_DEPARTMENT_Datalistproc");
            Ddo_view_ne_department_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_VIEW_NE_DEPARTMENT_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_view_ne_department_Sortasc = cgiGet( "DDO_VIEW_NE_DEPARTMENT_Sortasc");
            Ddo_view_ne_department_Sortdsc = cgiGet( "DDO_VIEW_NE_DEPARTMENT_Sortdsc");
            Ddo_view_ne_department_Loadingdata = cgiGet( "DDO_VIEW_NE_DEPARTMENT_Loadingdata");
            Ddo_view_ne_department_Cleanfilter = cgiGet( "DDO_VIEW_NE_DEPARTMENT_Cleanfilter");
            Ddo_view_ne_department_Noresultsfound = cgiGet( "DDO_VIEW_NE_DEPARTMENT_Noresultsfound");
            Ddo_view_ne_department_Searchbuttontext = cgiGet( "DDO_VIEW_NE_DEPARTMENT_Searchbuttontext");
            Ddo_view_ne_enctype_Caption = cgiGet( "DDO_VIEW_NE_ENCTYPE_Caption");
            Ddo_view_ne_enctype_Tooltip = cgiGet( "DDO_VIEW_NE_ENCTYPE_Tooltip");
            Ddo_view_ne_enctype_Cls = cgiGet( "DDO_VIEW_NE_ENCTYPE_Cls");
            Ddo_view_ne_enctype_Dropdownoptionstype = cgiGet( "DDO_VIEW_NE_ENCTYPE_Dropdownoptionstype");
            Ddo_view_ne_enctype_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NE_ENCTYPE_Includesortasc"));
            Ddo_view_ne_enctype_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NE_ENCTYPE_Includesortdsc"));
            Ddo_view_ne_enctype_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NE_ENCTYPE_Includefilter"));
            Ddo_view_ne_enctype_Filtertype = cgiGet( "DDO_VIEW_NE_ENCTYPE_Filtertype");
            Ddo_view_ne_enctype_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NE_ENCTYPE_Filterisrange"));
            Ddo_view_ne_enctype_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NE_ENCTYPE_Includedatalist"));
            Ddo_view_ne_enctype_Datalisttype = cgiGet( "DDO_VIEW_NE_ENCTYPE_Datalisttype");
            Ddo_view_ne_enctype_Datalistproc = cgiGet( "DDO_VIEW_NE_ENCTYPE_Datalistproc");
            Ddo_view_ne_enctype_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_VIEW_NE_ENCTYPE_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_view_ne_enctype_Sortasc = cgiGet( "DDO_VIEW_NE_ENCTYPE_Sortasc");
            Ddo_view_ne_enctype_Sortdsc = cgiGet( "DDO_VIEW_NE_ENCTYPE_Sortdsc");
            Ddo_view_ne_enctype_Loadingdata = cgiGet( "DDO_VIEW_NE_ENCTYPE_Loadingdata");
            Ddo_view_ne_enctype_Cleanfilter = cgiGet( "DDO_VIEW_NE_ENCTYPE_Cleanfilter");
            Ddo_view_ne_enctype_Noresultsfound = cgiGet( "DDO_VIEW_NE_ENCTYPE_Noresultsfound");
            Ddo_view_ne_enctype_Searchbuttontext = cgiGet( "DDO_VIEW_NE_ENCTYPE_Searchbuttontext");
            Dvelop_confirmpanel_deleteencounter_Title = cgiGet( "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Title");
            Dvelop_confirmpanel_deleteencounter_Confirmationtext = cgiGet( "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Confirmationtext");
            Dvelop_confirmpanel_deleteencounter_Yesbuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Yesbuttoncaption");
            Dvelop_confirmpanel_deleteencounter_Nobuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Nobuttoncaption");
            Dvelop_confirmpanel_deleteencounter_Cancelbuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Cancelbuttoncaption");
            Dvelop_confirmpanel_deleteencounter_Yesbuttonposition = cgiGet( "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Yesbuttonposition");
            Dvelop_confirmpanel_deleteencounter_Confirmtype = cgiGet( "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Confirmtype");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E12AB2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E12AB2( )
      {
         /* Start Routine */
      }

      protected void E13AB2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV80Test4DS_1_Tfview_ne_encounterid = AV17TFview_NE_EncounterID;
         AV81Test4DS_2_Tfview_ne_encounterid_to = AV18TFview_NE_EncounterID_To;
         AV82Test4DS_3_Tfview_ne_department = AV21TFview_NE_Department;
         AV83Test4DS_4_Tfview_ne_department_sel = AV22TFview_NE_Department_Sel;
         AV84Test4DS_5_Tfview_ne_enctype = AV25TFview_NE_ENCType;
         AV85Test4DS_6_Tfview_ne_enctype_sel = AV26TFview_NE_ENCType_Sel;
      }

      private void E14AB2( )
      {
         /* Grid_Load Routine */
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 28;
         }
         sendrow_282( ) ;
         if ( isFullAjaxMode( ) && ! bGXsfl_28_Refreshing )
         {
            context.DoAjaxLoad(28, GridRow);
         }
      }

      protected void S112( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
      }

      protected void S122( )
      {
         /* 'SETDDOSORTEDSTATUS' Routine */
      }

      protected void S132( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
      }

      protected void S142( )
      {
         /* 'DO DELETEENCOUNTER' Routine */
      }

      protected void S152( )
      {
         /* 'LOADGRIDSTATE' Routine */
      }

      protected void S162( )
      {
         /* 'SAVEGRIDSTATE' Routine */
      }

      protected void S172( )
      {
         /* 'PREPARETRANSACTION' Routine */
      }

      protected void wb_table1_63_AB2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTabledvelop_confirmpanel_deleteencounter_Internalname, tblTabledvelop_confirmpanel_deleteencounter_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center")+"\">") ;
            /* User Defined Control */
            ucDvelop_confirmpanel_deleteencounter.SetProperty("Title", Dvelop_confirmpanel_deleteencounter_Title);
            ucDvelop_confirmpanel_deleteencounter.SetProperty("ConfirmationText", Dvelop_confirmpanel_deleteencounter_Confirmationtext);
            ucDvelop_confirmpanel_deleteencounter.SetProperty("YesButtonCaption", Dvelop_confirmpanel_deleteencounter_Yesbuttoncaption);
            ucDvelop_confirmpanel_deleteencounter.SetProperty("NoButtonCaption", Dvelop_confirmpanel_deleteencounter_Nobuttoncaption);
            ucDvelop_confirmpanel_deleteencounter.SetProperty("CancelButtonCaption", Dvelop_confirmpanel_deleteencounter_Cancelbuttoncaption);
            ucDvelop_confirmpanel_deleteencounter.SetProperty("YesButtonPosition", Dvelop_confirmpanel_deleteencounter_Yesbuttonposition);
            ucDvelop_confirmpanel_deleteencounter.SetProperty("ConfirmType", Dvelop_confirmpanel_deleteencounter_Confirmtype);
            ucDvelop_confirmpanel_deleteencounter.Render(context, "dvelop.gxbootstrap.confirmpanel", Dvelop_confirmpanel_deleteencounter_Internalname, "DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer"+"Body"+"\" style=\"display:none;\">") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_63_AB2e( true) ;
         }
         else
         {
            wb_table1_63_AB2e( false) ;
         }
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
         PAAB2( ) ;
         WSAB2( ) ;
         WEAB2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20196510455725", true);
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
         context.AddJavascriptSource("test4.js", "?20196510455725", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_282( )
      {
         edtavDeleteencounter_Internalname = "vDELETEENCOUNTER_"+sGXsfl_28_idx;
         edtview_NE_EncounterID_Internalname = "VIEW_NE_ENCOUNTERID_"+sGXsfl_28_idx;
         edtview_NE_Department_Internalname = "VIEW_NE_DEPARTMENT_"+sGXsfl_28_idx;
         edtview_NE_ENCType_Internalname = "VIEW_NE_ENCTYPE_"+sGXsfl_28_idx;
         edtavAdmitdate_Internalname = "vADMITDATE_"+sGXsfl_28_idx;
         edtview_NE_AdmitDate_Internalname = "VIEW_NE_ADMITDATE_"+sGXsfl_28_idx;
         cmbavStatus_Internalname = "vSTATUS_"+sGXsfl_28_idx;
         cmbview_NE_Status_Internalname = "VIEW_NE_STATUS_"+sGXsfl_28_idx;
         chkavIsapprove_Internalname = "vISAPPROVE_"+sGXsfl_28_idx;
         edtview_NE_IsRandApprove_Internalname = "VIEW_NE_ISRANDAPPROVE_"+sGXsfl_28_idx;
         chkavIsrecheck_Internalname = "vISRECHECK_"+sGXsfl_28_idx;
         edtview_NE_IsRandRecheck_Internalname = "VIEW_NE_ISRANDRECHECK_"+sGXsfl_28_idx;
         chkavIsupdate_Internalname = "vISUPDATE_"+sGXsfl_28_idx;
         edtview_NE_IsUpdate_Internalname = "VIEW_NE_ISUPDATE_"+sGXsfl_28_idx;
         edtview_NE_TenantTenantCode_Internalname = "VIEW_NE_TENANTTENANTCODE_"+sGXsfl_28_idx;
         edtview_NE_Information_ID_Internalname = "VIEW_NE_INFORMATION_ID_"+sGXsfl_28_idx;
         edtview_NE_Information_PatientNo_Internalname = "VIEW_NE_INFORMATION_PATIENTNO_"+sGXsfl_28_idx;
      }

      protected void SubsflControlProps_fel_282( )
      {
         edtavDeleteencounter_Internalname = "vDELETEENCOUNTER_"+sGXsfl_28_fel_idx;
         edtview_NE_EncounterID_Internalname = "VIEW_NE_ENCOUNTERID_"+sGXsfl_28_fel_idx;
         edtview_NE_Department_Internalname = "VIEW_NE_DEPARTMENT_"+sGXsfl_28_fel_idx;
         edtview_NE_ENCType_Internalname = "VIEW_NE_ENCTYPE_"+sGXsfl_28_fel_idx;
         edtavAdmitdate_Internalname = "vADMITDATE_"+sGXsfl_28_fel_idx;
         edtview_NE_AdmitDate_Internalname = "VIEW_NE_ADMITDATE_"+sGXsfl_28_fel_idx;
         cmbavStatus_Internalname = "vSTATUS_"+sGXsfl_28_fel_idx;
         cmbview_NE_Status_Internalname = "VIEW_NE_STATUS_"+sGXsfl_28_fel_idx;
         chkavIsapprove_Internalname = "vISAPPROVE_"+sGXsfl_28_fel_idx;
         edtview_NE_IsRandApprove_Internalname = "VIEW_NE_ISRANDAPPROVE_"+sGXsfl_28_fel_idx;
         chkavIsrecheck_Internalname = "vISRECHECK_"+sGXsfl_28_fel_idx;
         edtview_NE_IsRandRecheck_Internalname = "VIEW_NE_ISRANDRECHECK_"+sGXsfl_28_fel_idx;
         chkavIsupdate_Internalname = "vISUPDATE_"+sGXsfl_28_fel_idx;
         edtview_NE_IsUpdate_Internalname = "VIEW_NE_ISUPDATE_"+sGXsfl_28_fel_idx;
         edtview_NE_TenantTenantCode_Internalname = "VIEW_NE_TENANTTENANTCODE_"+sGXsfl_28_fel_idx;
         edtview_NE_Information_ID_Internalname = "VIEW_NE_INFORMATION_ID_"+sGXsfl_28_fel_idx;
         edtview_NE_Information_PatientNo_Internalname = "VIEW_NE_INFORMATION_PATIENTNO_"+sGXsfl_28_fel_idx;
      }

      protected void sendrow_282( )
      {
         SubsflControlProps_282( ) ;
         WBAB0( ) ;
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
         /* Active Bitmap Variable */
         TempTags = " " + ((edtavDeleteencounter_Enabled!=0)&&(edtavDeleteencounter_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 29,'',false,'',28)\"" : " ");
         ClassString = "ActionBaseColorAttribute";
         StyleString = "";
         AV75deleteEncounter_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV75deleteEncounter))&&String.IsNullOrEmpty(StringUtil.RTrim( AV86Deleteencounter_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV75deleteEncounter)));
         sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV75deleteEncounter)) ? AV86Deleteencounter_GXI : context.PathToRelativeUrl( AV75deleteEncounter));
         GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDeleteencounter_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)7,(String)edtavDeleteencounter_Jsonclick,(String)"'"+""+"'"+",false,"+"'"+"e15ab2_client"+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV75deleteEncounter_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
         /* Subfile cell */
         if ( GridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtview_NE_EncounterID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A549view_NE_EncounterID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A549view_NE_EncounterID), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtview_NE_EncounterID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)false,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         if ( GridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtview_NE_Department_Internalname,(String)A550view_NE_Department,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtview_NE_Department_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4000,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)false,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         if ( GridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtview_NE_ENCType_Internalname,(String)A551view_NE_ENCType,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtview_NE_ENCType_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4000,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)false,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         if ( GridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavAdmitdate_Enabled!=0)&&(edtavAdmitdate_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 33,'',false,'"+sGXsfl_28_idx+"',28)\"" : " ");
         ROClassString = "Attribute";
         GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavAdmitdate_Internalname,context.localUtil.Format(AV70AdmitDate, "99/99/99"),context.localUtil.Format( AV70AdmitDate, "99/99/99"),TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+((edtavAdmitdate_Enabled!=0)&&(edtavAdmitdate_Visible!=0) ? " onblur=\""+";gx.evt.onblur(this,33);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavAdmitdate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(int)edtavAdmitdate_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)false,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         if ( GridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtview_NE_AdmitDate_Internalname,context.localUtil.TToC( A552view_NE_AdmitDate, 10, 8, 0, 0, "/", ":", " "),context.localUtil.Format( A552view_NE_AdmitDate, "9999/99/99 99:99:99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtview_NE_AdmitDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)19,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)false,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         if ( GridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
         }
         TempTags = " " + ((cmbavStatus.Enabled!=0)&&(cmbavStatus.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 35,'',false,'"+sGXsfl_28_idx+"',28)\"" : " ");
         if ( ( cmbavStatus.ItemCount == 0 ) && isAjaxCallMode( ) )
         {
            GXCCtl = "vSTATUS_" + sGXsfl_28_idx;
            cmbavStatus.Name = GXCCtl;
            cmbavStatus.WebTags = "";
            cmbavStatus.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 4, 0)), "(请选择)", 0);
            cmbavStatus.addItem("1", "录入中", 0);
            cmbavStatus.addItem("2", "待初审", 0);
            cmbavStatus.addItem("3", "初审不通过", 0);
            cmbavStatus.addItem("4", "待复审", 0);
            cmbavStatus.addItem("5", "复审不通过", 0);
            cmbavStatus.addItem("6", "完成", 0);
            if ( cmbavStatus.ItemCount > 0 )
            {
               AV71status = (short)(NumberUtil.Val( cmbavStatus.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV71status), 4, 0))), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavStatus_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV71status), 4, 0)));
            }
         }
         /* ComboBox */
         GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbavStatus,(String)cmbavStatus_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(AV71status), 4, 0)),(short)1,(String)cmbavStatus_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)-1,cmbavStatus.Enabled,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn",(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+((cmbavStatus.Enabled!=0)&&(cmbavStatus.Visible!=0) ? " onblur=\""+";gx.evt.onblur(this,35);\"" : " "),(String)"",(bool)false});
         cmbavStatus.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV71status), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavStatus_Internalname, "Values", (String)(cmbavStatus.ToJavascriptSource()), !bGXsfl_28_Refreshing);
         /* Subfile cell */
         if ( GridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         if ( ( cmbview_NE_Status.ItemCount == 0 ) && isAjaxCallMode( ) )
         {
            GXCCtl = "VIEW_NE_STATUS_" + sGXsfl_28_idx;
            cmbview_NE_Status.Name = GXCCtl;
            cmbview_NE_Status.WebTags = "";
            if ( cmbview_NE_Status.ItemCount > 0 )
            {
               A553view_NE_Status = (short)(NumberUtil.Val( cmbview_NE_Status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A553view_NE_Status), 4, 0))), "."));
               n553view_NE_Status = false;
            }
         }
         /* ComboBox */
         GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbview_NE_Status,(String)cmbview_NE_Status_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(A553view_NE_Status), 4, 0)),(short)1,(String)cmbview_NE_Status_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)0,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)false});
         cmbview_NE_Status.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A553view_NE_Status), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbview_NE_Status_Internalname, "Values", (String)(cmbview_NE_Status.ToJavascriptSource()), !bGXsfl_28_Refreshing);
         /* Subfile cell */
         if ( GridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
         }
         /* Check box */
         TempTags = " " + ((chkavIsapprove.Enabled!=0)&&(chkavIsapprove.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 37,'',false,'"+sGXsfl_28_idx+"',28)\"" : " ");
         ClassString = "AttributeCheckBox";
         StyleString = "";
         GridRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavIsapprove_Internalname,StringUtil.BoolToStr( AV72IsApprove),(String)"",(String)"",(short)-1,chkavIsapprove.Enabled,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn",(String)"",TempTags+" onclick=\"gx.fn.checkboxClick(37, this, 'true', 'false');gx.evt.onchange(this, event);\" "});
         /* Subfile cell */
         if ( GridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtview_NE_IsRandApprove_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A555view_NE_IsRandApprove), 1, 0, ".", "")),context.localUtil.Format( (decimal)(A555view_NE_IsRandApprove), "9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtview_NE_IsRandApprove_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)1,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)false,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         if ( GridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
         }
         /* Check box */
         TempTags = " " + ((chkavIsrecheck.Enabled!=0)&&(chkavIsrecheck.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 39,'',false,'"+sGXsfl_28_idx+"',28)\"" : " ");
         ClassString = "AttributeCheckBox";
         StyleString = "";
         GridRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavIsrecheck_Internalname,StringUtil.BoolToStr( AV73IsRecheck),(String)"",(String)"",(short)-1,chkavIsrecheck.Enabled,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn",(String)"",TempTags+" onclick=\"gx.fn.checkboxClick(39, this, 'true', 'false');gx.evt.onchange(this, event);\" "});
         /* Subfile cell */
         if ( GridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtview_NE_IsRandRecheck_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A554view_NE_IsRandRecheck), 1, 0, ".", "")),context.localUtil.Format( (decimal)(A554view_NE_IsRandRecheck), "9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtview_NE_IsRandRecheck_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)1,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)false,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         if ( GridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
         }
         /* Check box */
         TempTags = " " + ((chkavIsupdate.Enabled!=0)&&(chkavIsupdate.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 41,'',false,'"+sGXsfl_28_idx+"',28)\"" : " ");
         ClassString = "AttributeCheckBox";
         StyleString = "";
         GridRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavIsupdate_Internalname,StringUtil.BoolToStr( AV74IsUpdate),(String)"",(String)"",(short)-1,chkavIsupdate.Enabled,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn",(String)"",TempTags+" onclick=\"gx.fn.checkboxClick(41, this, 'true', 'false');gx.evt.onchange(this, event);\" "});
         /* Subfile cell */
         if ( GridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtview_NE_IsUpdate_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A556view_NE_IsUpdate), 1, 0, ".", "")),context.localUtil.Format( (decimal)(A556view_NE_IsUpdate), "9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtview_NE_IsUpdate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)1,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)false,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         if ( GridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtview_NE_TenantTenantCode_Internalname,(String)A557view_NE_TenantTenantCode,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtview_NE_TenantTenantCode_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)false,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         if ( GridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtview_NE_Information_ID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A558view_NE_Information_ID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A558view_NE_Information_ID), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtview_NE_Information_ID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)false,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         if ( GridContainer.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         ROClassString = "Attribute";
         GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtview_NE_Information_PatientNo_Internalname,(String)A559view_NE_Information_PatientNo,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtview_NE_Information_PatientNo_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4000,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)false,(String)"",(String)"left",(bool)true});
         send_integrity_lvl_hashesAB2( ) ;
         GridContainer.AddRow(GridRow);
         nGXsfl_28_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_28_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_28_idx+1));
         sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
         SubsflControlProps_282( ) ;
         /* End function sendrow_282 */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "vSTATUS_" + sGXsfl_28_idx;
         cmbavStatus.Name = GXCCtl;
         cmbavStatus.WebTags = "";
         cmbavStatus.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 4, 0)), "(请选择)", 0);
         cmbavStatus.addItem("1", "录入中", 0);
         cmbavStatus.addItem("2", "待初审", 0);
         cmbavStatus.addItem("3", "初审不通过", 0);
         cmbavStatus.addItem("4", "待复审", 0);
         cmbavStatus.addItem("5", "复审不通过", 0);
         cmbavStatus.addItem("6", "完成", 0);
         if ( cmbavStatus.ItemCount > 0 )
         {
            AV71status = (short)(NumberUtil.Val( cmbavStatus.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV71status), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbavStatus_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV71status), 4, 0)));
         }
         GXCCtl = "VIEW_NE_STATUS_" + sGXsfl_28_idx;
         cmbview_NE_Status.Name = GXCCtl;
         cmbview_NE_Status.WebTags = "";
         if ( cmbview_NE_Status.ItemCount > 0 )
         {
            A553view_NE_Status = (short)(NumberUtil.Val( cmbview_NE_Status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A553view_NE_Status), 4, 0))), "."));
            n553view_NE_Status = false;
         }
         GXCCtl = "vISAPPROVE_" + sGXsfl_28_idx;
         chkavIsapprove.Name = GXCCtl;
         chkavIsapprove.WebTags = "";
         chkavIsapprove.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavIsapprove_Internalname, "TitleCaption", chkavIsapprove.Caption, !bGXsfl_28_Refreshing);
         chkavIsapprove.CheckedValue = "false";
         GXCCtl = "vISRECHECK_" + sGXsfl_28_idx;
         chkavIsrecheck.Name = GXCCtl;
         chkavIsrecheck.WebTags = "";
         chkavIsrecheck.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavIsrecheck_Internalname, "TitleCaption", chkavIsrecheck.Caption, !bGXsfl_28_Refreshing);
         chkavIsrecheck.CheckedValue = "false";
         GXCCtl = "vISUPDATE_" + sGXsfl_28_idx;
         chkavIsupdate.Name = GXCCtl;
         chkavIsupdate.WebTags = "";
         chkavIsupdate.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavIsupdate_Internalname, "TitleCaption", chkavIsupdate.Caption, !bGXsfl_28_Refreshing);
         chkavIsupdate.CheckedValue = "false";
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
         edtavDeleteencounter_Internalname = "vDELETEENCOUNTER";
         edtview_NE_EncounterID_Internalname = "VIEW_NE_ENCOUNTERID";
         edtview_NE_Department_Internalname = "VIEW_NE_DEPARTMENT";
         edtview_NE_ENCType_Internalname = "VIEW_NE_ENCTYPE";
         edtavAdmitdate_Internalname = "vADMITDATE";
         edtview_NE_AdmitDate_Internalname = "VIEW_NE_ADMITDATE";
         cmbavStatus_Internalname = "vSTATUS";
         cmbview_NE_Status_Internalname = "VIEW_NE_STATUS";
         chkavIsapprove_Internalname = "vISAPPROVE";
         edtview_NE_IsRandApprove_Internalname = "VIEW_NE_ISRANDAPPROVE";
         chkavIsrecheck_Internalname = "vISRECHECK";
         edtview_NE_IsRandRecheck_Internalname = "VIEW_NE_ISRANDRECHECK";
         chkavIsupdate_Internalname = "vISUPDATE";
         edtview_NE_IsUpdate_Internalname = "VIEW_NE_ISUPDATE";
         edtview_NE_TenantTenantCode_Internalname = "VIEW_NE_TENANTTENANTCODE";
         edtview_NE_Information_ID_Internalname = "VIEW_NE_INFORMATION_ID";
         edtview_NE_Information_PatientNo_Internalname = "VIEW_NE_INFORMATION_PATIENTNO";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_view_ne_encounterid_Internalname = "DDO_VIEW_NE_ENCOUNTERID";
         edtavDdo_view_ne_encounteridtitlecontrolidtoreplace_Internalname = "vDDO_VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE";
         Ddo_view_ne_department_Internalname = "DDO_VIEW_NE_DEPARTMENT";
         edtavDdo_view_ne_departmenttitlecontrolidtoreplace_Internalname = "vDDO_VIEW_NE_DEPARTMENTTITLECONTROLIDTOREPLACE";
         Ddo_view_ne_enctype_Internalname = "DDO_VIEW_NE_ENCTYPE";
         edtavDdo_view_ne_enctypetitlecontrolidtoreplace_Internalname = "vDDO_VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         edtavView_ne_encounterid_selected_Internalname = "vVIEW_NE_ENCOUNTERID_SELECTED";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         Dvelop_confirmpanel_deleteencounter_Internalname = "DVELOP_CONFIRMPANEL_DELETEENCOUNTER";
         tblTabledvelop_confirmpanel_deleteencounter_Internalname = "TABLEDVELOP_CONFIRMPANEL_DELETEENCOUNTER";
         edtavTfview_ne_encounterid_Internalname = "vTFVIEW_NE_ENCOUNTERID";
         edtavTfview_ne_encounterid_to_Internalname = "vTFVIEW_NE_ENCOUNTERID_TO";
         edtavTfview_ne_department_Internalname = "vTFVIEW_NE_DEPARTMENT";
         edtavTfview_ne_department_sel_Internalname = "vTFVIEW_NE_DEPARTMENT_SEL";
         edtavTfview_ne_enctype_Internalname = "vTFVIEW_NE_ENCTYPE";
         edtavTfview_ne_enctype_sel_Internalname = "vTFVIEW_NE_ENCTYPE_SEL";
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
         chkavIsupdate.Caption = "";
         chkavIsrecheck.Caption = "";
         chkavIsapprove.Caption = "";
         edtview_NE_Information_PatientNo_Jsonclick = "";
         edtview_NE_Information_ID_Jsonclick = "";
         edtview_NE_TenantTenantCode_Jsonclick = "";
         edtview_NE_IsUpdate_Jsonclick = "";
         chkavIsupdate.Visible = -1;
         edtview_NE_IsRandRecheck_Jsonclick = "";
         chkavIsrecheck.Visible = -1;
         edtview_NE_IsRandApprove_Jsonclick = "";
         chkavIsapprove.Visible = -1;
         cmbview_NE_Status_Jsonclick = "";
         cmbavStatus_Jsonclick = "";
         cmbavStatus.Visible = -1;
         edtview_NE_AdmitDate_Jsonclick = "";
         edtavAdmitdate_Jsonclick = "";
         edtavAdmitdate_Visible = -1;
         edtview_NE_ENCType_Jsonclick = "";
         edtview_NE_Department_Jsonclick = "";
         edtview_NE_EncounterID_Jsonclick = "";
         edtavDeleteencounter_Jsonclick = "";
         edtavDeleteencounter_Visible = -1;
         edtavDeleteencounter_Enabled = 1;
         edtavTfview_ne_encounterid_to_Jsonclick = "";
         edtavTfview_ne_encounterid_Jsonclick = "";
         edtavOrdereddsc_Jsonclick = "";
         edtavOrderedby_Jsonclick = "";
         edtavView_ne_encounterid_selected_Jsonclick = "";
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         subGrid_Sortable = 0;
         subGrid_Header = "";
         chkavIsupdate.Enabled = 1;
         chkavIsrecheck.Enabled = 1;
         chkavIsapprove.Enabled = 1;
         cmbavStatus.Enabled = 1;
         edtavAdmitdate_Enabled = 1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         Dvelop_confirmpanel_deleteencounter_Confirmtype = "1";
         Dvelop_confirmpanel_deleteencounter_Yesbuttonposition = "left";
         Dvelop_confirmpanel_deleteencounter_Cancelbuttoncaption = "WWP_ConfirmTextCancel";
         Dvelop_confirmpanel_deleteencounter_Nobuttoncaption = "WWP_ConfirmTextNo";
         Dvelop_confirmpanel_deleteencounter_Yesbuttoncaption = "WWP_ConfirmTextYes";
         Dvelop_confirmpanel_deleteencounter_Confirmationtext = "确认删除？";
         Dvelop_confirmpanel_deleteencounter_Title = "";
         Ddo_view_ne_enctype_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_view_ne_enctype_Noresultsfound = "WWP_TSNoResults";
         Ddo_view_ne_enctype_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_view_ne_enctype_Loadingdata = "WWP_TSLoading";
         Ddo_view_ne_enctype_Sortdsc = "WWP_TSSortDSC";
         Ddo_view_ne_enctype_Sortasc = "WWP_TSSortASC";
         Ddo_view_ne_enctype_Datalistupdateminimumcharacters = 0;
         Ddo_view_ne_enctype_Datalistproc = "Test4GetFilterData";
         Ddo_view_ne_enctype_Datalisttype = "Dynamic";
         Ddo_view_ne_enctype_Includedatalist = Convert.ToBoolean( -1);
         Ddo_view_ne_enctype_Filterisrange = Convert.ToBoolean( 0);
         Ddo_view_ne_enctype_Filtertype = "Character";
         Ddo_view_ne_enctype_Includefilter = Convert.ToBoolean( -1);
         Ddo_view_ne_enctype_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_view_ne_enctype_Includesortasc = Convert.ToBoolean( -1);
         Ddo_view_ne_enctype_Dropdownoptionstype = "GridTitleSettings";
         Ddo_view_ne_enctype_Cls = "ColumnSettings";
         Ddo_view_ne_enctype_Tooltip = "WWP_TSColumnOptions";
         Ddo_view_ne_enctype_Caption = "";
         Ddo_view_ne_department_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_view_ne_department_Noresultsfound = "WWP_TSNoResults";
         Ddo_view_ne_department_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_view_ne_department_Loadingdata = "WWP_TSLoading";
         Ddo_view_ne_department_Sortdsc = "WWP_TSSortDSC";
         Ddo_view_ne_department_Sortasc = "WWP_TSSortASC";
         Ddo_view_ne_department_Datalistupdateminimumcharacters = 0;
         Ddo_view_ne_department_Datalistproc = "Test4GetFilterData";
         Ddo_view_ne_department_Datalisttype = "Dynamic";
         Ddo_view_ne_department_Includedatalist = Convert.ToBoolean( -1);
         Ddo_view_ne_department_Filterisrange = Convert.ToBoolean( 0);
         Ddo_view_ne_department_Filtertype = "Character";
         Ddo_view_ne_department_Includefilter = Convert.ToBoolean( -1);
         Ddo_view_ne_department_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_view_ne_department_Includesortasc = Convert.ToBoolean( -1);
         Ddo_view_ne_department_Dropdownoptionstype = "GridTitleSettings";
         Ddo_view_ne_department_Cls = "ColumnSettings";
         Ddo_view_ne_department_Tooltip = "WWP_TSColumnOptions";
         Ddo_view_ne_department_Caption = "";
         Ddo_view_ne_encounterid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_view_ne_encounterid_Rangefilterto = "WWP_TSTo";
         Ddo_view_ne_encounterid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_view_ne_encounterid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_view_ne_encounterid_Sortdsc = "WWP_TSSortDSC";
         Ddo_view_ne_encounterid_Sortasc = "WWP_TSSortASC";
         Ddo_view_ne_encounterid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_view_ne_encounterid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_view_ne_encounterid_Filtertype = "Numeric";
         Ddo_view_ne_encounterid_Includefilter = Convert.ToBoolean( -1);
         Ddo_view_ne_encounterid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_view_ne_encounterid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_view_ne_encounterid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_view_ne_encounterid_Cls = "ColumnSettings";
         Ddo_view_ne_encounterid_Tooltip = "WWP_TSColumnOptions";
         Ddo_view_ne_encounterid_Caption = "";
         Gridpaginationbar_Rowsperpagecaption = "WWP_PagingRowsPerPage";
         Gridpaginationbar_Emptygridcaption = "WWP_PagingEmptyGridCaption";
         Gridpaginationbar_Rowsperpageoptions = "5:WWP_Rows5,10:WWP_Rows10,20:WWP_Rows20,50:WWP_Rows50";
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
         Form.Caption = "Test4";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFview_NE_EncounterID',fld:'vTFVIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV18TFview_NE_EncounterID_To',fld:'vTFVIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV21TFview_NE_Department',fld:'vTFVIEW_NE_DEPARTMENT',pic:''},{av:'AV22TFview_NE_Department_Sel',fld:'vTFVIEW_NE_DEPARTMENT_SEL',pic:''},{av:'AV25TFview_NE_ENCType',fld:'vTFVIEW_NE_ENCTYPE',pic:''},{av:'AV26TFview_NE_ENCType_Sel',fld:'vTFVIEW_NE_ENCTYPE_SEL',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("GRID.LOAD","{handler:'E14AB2',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[]}");
         setEventMetadata("'DODELETEENCOUNTER'","{handler:'E15AB2',iparms:[]");
         setEventMetadata("'DODELETEENCOUNTER'",",oparms:[]}");
         setEventMetadata("'DOINSERT'","{handler:'E11AB1',iparms:[]");
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
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV21TFview_NE_Department = "";
         AV22TFview_NE_Department_Sel = "";
         AV25TFview_NE_ENCType = "";
         AV26TFview_NE_ENCType_Sel = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV62DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV16view_NE_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20view_NE_DepartmentTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24view_NE_ENCTypeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
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
         AV75deleteEncounter = "";
         A550view_NE_Department = "";
         A551view_NE_ENCType = "";
         AV70AdmitDate = DateTime.MinValue;
         A552view_NE_AdmitDate = (DateTime)(DateTime.MinValue);
         A557view_NE_TenantTenantCode = "";
         A559view_NE_Information_PatientNo = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_view_ne_encounterid = new GXUserControl();
         AV19ddo_view_NE_EncounterIDTitleControlIdToReplace = "";
         ucDdo_view_ne_department = new GXUserControl();
         AV23ddo_view_NE_DepartmentTitleControlIdToReplace = "";
         ucDdo_view_ne_enctype = new GXUserControl();
         AV27ddo_view_NE_ENCTypeTitleControlIdToReplace = "";
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV86Deleteencounter_GXI = "";
         scmdbuf = "";
         lV82Test4DS_3_Tfview_ne_department = "";
         lV84Test4DS_5_Tfview_ne_enctype = "";
         AV83Test4DS_4_Tfview_ne_department_sel = "";
         AV82Test4DS_3_Tfview_ne_department = "";
         AV85Test4DS_6_Tfview_ne_enctype_sel = "";
         AV84Test4DS_5_Tfview_ne_enctype = "";
         H00AB2_A559view_NE_Information_PatientNo = new String[] {""} ;
         H00AB2_n559view_NE_Information_PatientNo = new bool[] {false} ;
         H00AB2_A558view_NE_Information_ID = new long[1] ;
         H00AB2_n558view_NE_Information_ID = new bool[] {false} ;
         H00AB2_A557view_NE_TenantTenantCode = new String[] {""} ;
         H00AB2_n557view_NE_TenantTenantCode = new bool[] {false} ;
         H00AB2_A556view_NE_IsUpdate = new short[1] ;
         H00AB2_n556view_NE_IsUpdate = new bool[] {false} ;
         H00AB2_A554view_NE_IsRandRecheck = new short[1] ;
         H00AB2_n554view_NE_IsRandRecheck = new bool[] {false} ;
         H00AB2_A555view_NE_IsRandApprove = new short[1] ;
         H00AB2_n555view_NE_IsRandApprove = new bool[] {false} ;
         H00AB2_A553view_NE_Status = new short[1] ;
         H00AB2_n553view_NE_Status = new bool[] {false} ;
         H00AB2_A552view_NE_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         H00AB2_n552view_NE_AdmitDate = new bool[] {false} ;
         H00AB2_A551view_NE_ENCType = new String[] {""} ;
         H00AB2_n551view_NE_ENCType = new bool[] {false} ;
         H00AB2_A550view_NE_Department = new String[] {""} ;
         H00AB2_n550view_NE_Department = new bool[] {false} ;
         H00AB2_A549view_NE_EncounterID = new long[1] ;
         GridRow = new GXWebRow();
         ucDvelop_confirmpanel_deleteencounter = new GXUserControl();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.test4__default(),
            new Object[][] {
                new Object[] {
               H00AB2_A559view_NE_Information_PatientNo, H00AB2_n559view_NE_Information_PatientNo, H00AB2_A558view_NE_Information_ID, H00AB2_n558view_NE_Information_ID, H00AB2_A557view_NE_TenantTenantCode, H00AB2_n557view_NE_TenantTenantCode, H00AB2_A556view_NE_IsUpdate, H00AB2_n556view_NE_IsUpdate, H00AB2_A554view_NE_IsRandRecheck, H00AB2_n554view_NE_IsRandRecheck,
               H00AB2_A555view_NE_IsRandApprove, H00AB2_n555view_NE_IsRandApprove, H00AB2_A553view_NE_Status, H00AB2_n553view_NE_Status, H00AB2_A552view_NE_AdmitDate, H00AB2_n552view_NE_AdmitDate, H00AB2_A551view_NE_ENCType, H00AB2_n551view_NE_ENCType, H00AB2_A550view_NE_Department, H00AB2_n550view_NE_Department,
               H00AB2_A549view_NE_EncounterID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavAdmitdate_Enabled = 0;
         cmbavStatus.Enabled = 0;
         chkavIsapprove.Enabled = 0;
         chkavIsrecheck.Enabled = 0;
         chkavIsupdate.Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_28 ;
      private short nGXsfl_28_idx=1 ;
      private short AV13OrderedBy ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short subGrid_Sortable ;
      private short AV71status ;
      private short A553view_NE_Status ;
      private short A555view_NE_IsRandApprove ;
      private short A554view_NE_IsRandRecheck ;
      private short A556view_NE_IsUpdate ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short GRID_nEOF ;
      private short nGXWrapped ;
      private short subGrid_Backstyle ;
      private int Gridpaginationbar_Pagestoshow ;
      private int Ddo_view_ne_department_Datalistupdateminimumcharacters ;
      private int Ddo_view_ne_enctype_Datalistupdateminimumcharacters ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavAdmitdate_Enabled ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int subGrid_Islastpage ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavDeleteencounter_Enabled ;
      private int edtavDeleteencounter_Visible ;
      private int edtavAdmitdate_Visible ;
      private long AV17TFview_NE_EncounterID ;
      private long AV18TFview_NE_EncounterID_To ;
      private long AV64GridCurrentPage ;
      private long AV66GridRecordCount ;
      private long AV65GridPageSize ;
      private long A549view_NE_EncounterID ;
      private long A558view_NE_Information_ID ;
      private long AV77view_NE_EncounterID_Selected ;
      private long GRID_nCurrentRecord ;
      private long AV80Test4DS_1_Tfview_ne_encounterid ;
      private long AV81Test4DS_2_Tfview_ne_encounterid_to ;
      private long GRID_nFirstRecordOnPage ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_28_idx="0001" ;
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
      private String Ddo_view_ne_encounterid_Caption ;
      private String Ddo_view_ne_encounterid_Tooltip ;
      private String Ddo_view_ne_encounterid_Cls ;
      private String Ddo_view_ne_encounterid_Dropdownoptionstype ;
      private String Ddo_view_ne_encounterid_Filtertype ;
      private String Ddo_view_ne_encounterid_Sortasc ;
      private String Ddo_view_ne_encounterid_Sortdsc ;
      private String Ddo_view_ne_encounterid_Cleanfilter ;
      private String Ddo_view_ne_encounterid_Rangefilterfrom ;
      private String Ddo_view_ne_encounterid_Rangefilterto ;
      private String Ddo_view_ne_encounterid_Searchbuttontext ;
      private String Ddo_view_ne_department_Caption ;
      private String Ddo_view_ne_department_Tooltip ;
      private String Ddo_view_ne_department_Cls ;
      private String Ddo_view_ne_department_Dropdownoptionstype ;
      private String Ddo_view_ne_department_Filtertype ;
      private String Ddo_view_ne_department_Datalisttype ;
      private String Ddo_view_ne_department_Datalistproc ;
      private String Ddo_view_ne_department_Sortasc ;
      private String Ddo_view_ne_department_Sortdsc ;
      private String Ddo_view_ne_department_Loadingdata ;
      private String Ddo_view_ne_department_Cleanfilter ;
      private String Ddo_view_ne_department_Noresultsfound ;
      private String Ddo_view_ne_department_Searchbuttontext ;
      private String Ddo_view_ne_enctype_Caption ;
      private String Ddo_view_ne_enctype_Tooltip ;
      private String Ddo_view_ne_enctype_Cls ;
      private String Ddo_view_ne_enctype_Dropdownoptionstype ;
      private String Ddo_view_ne_enctype_Filtertype ;
      private String Ddo_view_ne_enctype_Datalisttype ;
      private String Ddo_view_ne_enctype_Datalistproc ;
      private String Ddo_view_ne_enctype_Sortasc ;
      private String Ddo_view_ne_enctype_Sortdsc ;
      private String Ddo_view_ne_enctype_Loadingdata ;
      private String Ddo_view_ne_enctype_Cleanfilter ;
      private String Ddo_view_ne_enctype_Noresultsfound ;
      private String Ddo_view_ne_enctype_Searchbuttontext ;
      private String Dvelop_confirmpanel_deleteencounter_Title ;
      private String Dvelop_confirmpanel_deleteencounter_Confirmationtext ;
      private String Dvelop_confirmpanel_deleteencounter_Yesbuttoncaption ;
      private String Dvelop_confirmpanel_deleteencounter_Nobuttoncaption ;
      private String Dvelop_confirmpanel_deleteencounter_Cancelbuttoncaption ;
      private String Dvelop_confirmpanel_deleteencounter_Yesbuttonposition ;
      private String Dvelop_confirmpanel_deleteencounter_Confirmtype ;
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
      private String subGrid_Header ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_view_ne_encounterid_Internalname ;
      private String edtavDdo_view_ne_encounteridtitlecontrolidtoreplace_Internalname ;
      private String Ddo_view_ne_department_Internalname ;
      private String edtavDdo_view_ne_departmenttitlecontrolidtoreplace_Internalname ;
      private String Ddo_view_ne_enctype_Internalname ;
      private String edtavDdo_view_ne_enctypetitlecontrolidtoreplace_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavView_ne_encounterid_selected_Internalname ;
      private String edtavView_ne_encounterid_selected_Jsonclick ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavTfview_ne_encounterid_Internalname ;
      private String edtavTfview_ne_encounterid_Jsonclick ;
      private String edtavTfview_ne_encounterid_to_Internalname ;
      private String edtavTfview_ne_encounterid_to_Jsonclick ;
      private String edtavTfview_ne_department_Internalname ;
      private String edtavTfview_ne_department_sel_Internalname ;
      private String edtavTfview_ne_enctype_Internalname ;
      private String edtavTfview_ne_enctype_sel_Internalname ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDeleteencounter_Internalname ;
      private String edtview_NE_EncounterID_Internalname ;
      private String edtview_NE_Department_Internalname ;
      private String edtview_NE_ENCType_Internalname ;
      private String edtavAdmitdate_Internalname ;
      private String edtview_NE_AdmitDate_Internalname ;
      private String cmbavStatus_Internalname ;
      private String cmbview_NE_Status_Internalname ;
      private String chkavIsapprove_Internalname ;
      private String edtview_NE_IsRandApprove_Internalname ;
      private String chkavIsrecheck_Internalname ;
      private String edtview_NE_IsRandRecheck_Internalname ;
      private String chkavIsupdate_Internalname ;
      private String edtview_NE_IsUpdate_Internalname ;
      private String edtview_NE_TenantTenantCode_Internalname ;
      private String edtview_NE_Information_ID_Internalname ;
      private String edtview_NE_Information_PatientNo_Internalname ;
      private String scmdbuf ;
      private String tblTabledvelop_confirmpanel_deleteencounter_Internalname ;
      private String Dvelop_confirmpanel_deleteencounter_Internalname ;
      private String sGXsfl_28_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavDeleteencounter_Jsonclick ;
      private String ROClassString ;
      private String edtview_NE_EncounterID_Jsonclick ;
      private String edtview_NE_Department_Jsonclick ;
      private String edtview_NE_ENCType_Jsonclick ;
      private String edtavAdmitdate_Jsonclick ;
      private String edtview_NE_AdmitDate_Jsonclick ;
      private String GXCCtl ;
      private String cmbavStatus_Jsonclick ;
      private String cmbview_NE_Status_Jsonclick ;
      private String edtview_NE_IsRandApprove_Jsonclick ;
      private String edtview_NE_IsRandRecheck_Jsonclick ;
      private String edtview_NE_IsUpdate_Jsonclick ;
      private String edtview_NE_TenantTenantCode_Jsonclick ;
      private String edtview_NE_Information_ID_Jsonclick ;
      private String edtview_NE_Information_PatientNo_Jsonclick ;
      private DateTime A552view_NE_AdmitDate ;
      private DateTime AV70AdmitDate ;
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
      private bool Ddo_view_ne_encounterid_Includesortasc ;
      private bool Ddo_view_ne_encounterid_Includesortdsc ;
      private bool Ddo_view_ne_encounterid_Includefilter ;
      private bool Ddo_view_ne_encounterid_Filterisrange ;
      private bool Ddo_view_ne_encounterid_Includedatalist ;
      private bool Ddo_view_ne_department_Includesortasc ;
      private bool Ddo_view_ne_department_Includesortdsc ;
      private bool Ddo_view_ne_department_Includefilter ;
      private bool Ddo_view_ne_department_Filterisrange ;
      private bool Ddo_view_ne_department_Includedatalist ;
      private bool Ddo_view_ne_enctype_Includesortasc ;
      private bool Ddo_view_ne_enctype_Includesortdsc ;
      private bool Ddo_view_ne_enctype_Includefilter ;
      private bool Ddo_view_ne_enctype_Filterisrange ;
      private bool Ddo_view_ne_enctype_Includedatalist ;
      private bool wbLoad ;
      private bool AV72IsApprove ;
      private bool AV73IsRecheck ;
      private bool AV74IsUpdate ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_28_Refreshing=false ;
      private bool n550view_NE_Department ;
      private bool n551view_NE_ENCType ;
      private bool n552view_NE_AdmitDate ;
      private bool n553view_NE_Status ;
      private bool n555view_NE_IsRandApprove ;
      private bool n554view_NE_IsRandRecheck ;
      private bool n556view_NE_IsUpdate ;
      private bool n557view_NE_TenantTenantCode ;
      private bool n558view_NE_Information_ID ;
      private bool n559view_NE_Information_PatientNo ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV75deleteEncounter_IsBlob ;
      private String AV21TFview_NE_Department ;
      private String AV22TFview_NE_Department_Sel ;
      private String AV25TFview_NE_ENCType ;
      private String AV26TFview_NE_ENCType_Sel ;
      private String A550view_NE_Department ;
      private String A551view_NE_ENCType ;
      private String A557view_NE_TenantTenantCode ;
      private String A559view_NE_Information_PatientNo ;
      private String AV19ddo_view_NE_EncounterIDTitleControlIdToReplace ;
      private String AV23ddo_view_NE_DepartmentTitleControlIdToReplace ;
      private String AV27ddo_view_NE_ENCTypeTitleControlIdToReplace ;
      private String AV86Deleteencounter_GXI ;
      private String lV82Test4DS_3_Tfview_ne_department ;
      private String lV84Test4DS_5_Tfview_ne_enctype ;
      private String AV83Test4DS_4_Tfview_ne_department_sel ;
      private String AV82Test4DS_3_Tfview_ne_department ;
      private String AV85Test4DS_6_Tfview_ne_enctype_sel ;
      private String AV84Test4DS_5_Tfview_ne_enctype ;
      private String AV75deleteEncounter ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_view_ne_encounterid ;
      private GXUserControl ucDdo_view_ne_department ;
      private GXUserControl ucDdo_view_ne_enctype ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXUserControl ucDvelop_confirmpanel_deleteencounter ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavStatus ;
      private GXCombobox cmbview_NE_Status ;
      private GXCheckbox chkavIsapprove ;
      private GXCheckbox chkavIsrecheck ;
      private GXCheckbox chkavIsupdate ;
      private IDataStoreProvider pr_default ;
      private String[] H00AB2_A559view_NE_Information_PatientNo ;
      private bool[] H00AB2_n559view_NE_Information_PatientNo ;
      private long[] H00AB2_A558view_NE_Information_ID ;
      private bool[] H00AB2_n558view_NE_Information_ID ;
      private String[] H00AB2_A557view_NE_TenantTenantCode ;
      private bool[] H00AB2_n557view_NE_TenantTenantCode ;
      private short[] H00AB2_A556view_NE_IsUpdate ;
      private bool[] H00AB2_n556view_NE_IsUpdate ;
      private short[] H00AB2_A554view_NE_IsRandRecheck ;
      private bool[] H00AB2_n554view_NE_IsRandRecheck ;
      private short[] H00AB2_A555view_NE_IsRandApprove ;
      private bool[] H00AB2_n555view_NE_IsRandApprove ;
      private short[] H00AB2_A553view_NE_Status ;
      private bool[] H00AB2_n553view_NE_Status ;
      private DateTime[] H00AB2_A552view_NE_AdmitDate ;
      private bool[] H00AB2_n552view_NE_AdmitDate ;
      private String[] H00AB2_A551view_NE_ENCType ;
      private bool[] H00AB2_n551view_NE_ENCType ;
      private String[] H00AB2_A550view_NE_Department ;
      private bool[] H00AB2_n550view_NE_Department ;
      private long[] H00AB2_A549view_NE_EncounterID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV16view_NE_EncounterIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV20view_NE_DepartmentTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV24view_NE_ENCTypeTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV62DDO_TitleSettingsIcons ;
   }

   public class test4__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00AB2( IGxContext context ,
                                             long AV80Test4DS_1_Tfview_ne_encounterid ,
                                             long AV81Test4DS_2_Tfview_ne_encounterid_to ,
                                             String AV83Test4DS_4_Tfview_ne_department_sel ,
                                             String AV82Test4DS_3_Tfview_ne_department ,
                                             String AV85Test4DS_6_Tfview_ne_enctype_sel ,
                                             String AV84Test4DS_5_Tfview_ne_enctype ,
                                             long A549view_NE_EncounterID ,
                                             String A550view_NE_Department ,
                                             String A551view_NE_ENCType ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [6] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         scmdbuf = "SELECT [view_NE_Information_PatientNo], [view_NE_Information_ID], [view_NE_TenantTenantCode], [view_NE_IsUpdate], [view_NE_IsRandRecheck], [view_NE_IsRandApprove], [view_NE_Status], [view_NE_AdmitDate], [view_NE_ENCType], [view_NE_Department], [view_NE_EncounterID] FROM dbo.[View_New_Encounter] WITH (NOLOCK)";
         if ( ! (0==AV80Test4DS_1_Tfview_ne_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_EncounterID] >= @AV80Test4DS_1_Tfview_ne_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_EncounterID] >= @AV80Test4DS_1_Tfview_ne_encounterid)";
            }
         }
         else
         {
            GXv_int1[0] = 1;
         }
         if ( ! (0==AV81Test4DS_2_Tfview_ne_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_EncounterID] <= @AV81Test4DS_2_Tfview_ne_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_EncounterID] <= @AV81Test4DS_2_Tfview_ne_encounterid_to)";
            }
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV83Test4DS_4_Tfview_ne_department_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82Test4DS_3_Tfview_ne_department)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Department] like @lV82Test4DS_3_Tfview_ne_department)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Department] like @lV82Test4DS_3_Tfview_ne_department)";
            }
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83Test4DS_4_Tfview_ne_department_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Department] = @AV83Test4DS_4_Tfview_ne_department_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Department] = @AV83Test4DS_4_Tfview_ne_department_sel)";
            }
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV85Test4DS_6_Tfview_ne_enctype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84Test4DS_5_Tfview_ne_enctype)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_ENCType] like @lV84Test4DS_5_Tfview_ne_enctype)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_ENCType] like @lV84Test4DS_5_Tfview_ne_enctype)";
            }
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85Test4DS_6_Tfview_ne_enctype_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_ENCType] = @AV85Test4DS_6_Tfview_ne_enctype_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_ENCType] = @AV85Test4DS_6_Tfview_ne_enctype_sel)";
            }
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + " ORDER BY [view_NE_EncounterID]";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + " ORDER BY [view_NE_EncounterID] DESC";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + " ORDER BY [view_NE_Department]";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + " ORDER BY [view_NE_Department] DESC";
         }
         else if ( ( AV13OrderedBy == 3 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + " ORDER BY [view_NE_ENCType]";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + " ORDER BY [view_NE_ENCType] DESC";
         }
         else if ( true )
         {
            scmdbuf = scmdbuf + " ORDER BY [view_NE_EncounterID]";
         }
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H00AB2(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (long)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (short)dynConstraints[9] , (bool)dynConstraints[10] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH00AB2 ;
          prmH00AB2 = new Object[] {
          new Object[] {"@AV80Test4DS_1_Tfview_ne_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV81Test4DS_2_Tfview_ne_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV82Test4DS_3_Tfview_ne_department",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV83Test4DS_4_Tfview_ne_department_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV84Test4DS_5_Tfview_ne_enctype",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV85Test4DS_6_Tfview_ne_enctype_sel",SqlDbType.NVarChar,4000,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00AB2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00AB2,11,0,false,false )
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
                ((long[]) buf[2])[0] = rslt.getLong(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((short[]) buf[6])[0] = rslt.getShort(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((short[]) buf[8])[0] = rslt.getShort(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((short[]) buf[10])[0] = rslt.getShort(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((short[]) buf[12])[0] = rslt.getShort(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[14])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((String[]) buf[18])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((long[]) buf[20])[0] = rslt.getLong(11) ;
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
                   stmt.SetParameter(sIdx, (long)parms[6]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[7]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[8]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[9]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                return;
       }
    }

 }

}
