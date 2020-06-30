/*
               File: JC_ProviderWW
        Description:  医院
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:16:45.76
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
   public class jc_providerww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public jc_providerww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public jc_providerww( IGxContext context )
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
               nRC_GXsfl_31 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_31_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_31_idx = GetNextPar( );
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
               AV17TFJC_ProviderID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV18TFJC_ProviderID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV21TFJC_ProviderName = GetNextPar( );
               AV22TFJC_ProviderName_Sel = GetNextPar( );
               AV25TFJC_ProviderShortName = GetNextPar( );
               AV26TFJC_ProviderShortName_Sel = GetNextPar( );
               AV29TFJC_ProviderAddresss = GetNextPar( );
               AV30TFJC_ProviderAddresss_Sel = GetNextPar( );
               AV33TFJC_ProviderPhone = GetNextPar( );
               AV34TFJC_ProviderPhone_Sel = GetNextPar( );
               AV37TFJC_ProviderUser = GetNextPar( );
               AV38TFJC_ProviderUser_Sel = GetNextPar( );
               AV19ddo_JC_ProviderIDTitleControlIdToReplace = GetNextPar( );
               AV23ddo_JC_ProviderNameTitleControlIdToReplace = GetNextPar( );
               AV27ddo_JC_ProviderShortNameTitleControlIdToReplace = GetNextPar( );
               AV31ddo_JC_ProviderAddresssTitleControlIdToReplace = GetNextPar( );
               AV35ddo_JC_ProviderPhoneTitleControlIdToReplace = GetNextPar( );
               AV39ddo_JC_ProviderUserTitleControlIdToReplace = GetNextPar( );
               AV68Pgmname = GetNextPar( );
               AV47IsAuthorized_Update = StringUtil.StrToBool( GetNextPar( ));
               AV49IsAuthorized_Delete = StringUtil.StrToBool( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFJC_ProviderID, AV18TFJC_ProviderID_To, AV21TFJC_ProviderName, AV22TFJC_ProviderName_Sel, AV25TFJC_ProviderShortName, AV26TFJC_ProviderShortName_Sel, AV29TFJC_ProviderAddresss, AV30TFJC_ProviderAddresss_Sel, AV33TFJC_ProviderPhone, AV34TFJC_ProviderPhone_Sel, AV37TFJC_ProviderUser, AV38TFJC_ProviderUser_Sel, AV19ddo_JC_ProviderIDTitleControlIdToReplace, AV23ddo_JC_ProviderNameTitleControlIdToReplace, AV27ddo_JC_ProviderShortNameTitleControlIdToReplace, AV31ddo_JC_ProviderAddresssTitleControlIdToReplace, AV35ddo_JC_ProviderPhoneTitleControlIdToReplace, AV39ddo_JC_ProviderUserTitleControlIdToReplace, AV68Pgmname, AV47IsAuthorized_Update, AV49IsAuthorized_Delete) ;
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
         PA8I2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START8I2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202281516462", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("jc_providerww.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vTFJC_PROVIDERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFJC_ProviderID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFJC_PROVIDERID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFJC_ProviderID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFJC_PROVIDERNAME", AV21TFJC_ProviderName);
         GxWebStd.gx_hidden_field( context, "GXH_vTFJC_PROVIDERNAME_SEL", AV22TFJC_ProviderName_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFJC_PROVIDERSHORTNAME", AV25TFJC_ProviderShortName);
         GxWebStd.gx_hidden_field( context, "GXH_vTFJC_PROVIDERSHORTNAME_SEL", AV26TFJC_ProviderShortName_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFJC_PROVIDERADDRESSS", AV29TFJC_ProviderAddresss);
         GxWebStd.gx_hidden_field( context, "GXH_vTFJC_PROVIDERADDRESSS_SEL", AV30TFJC_ProviderAddresss_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFJC_PROVIDERPHONE", StringUtil.RTrim( AV33TFJC_ProviderPhone));
         GxWebStd.gx_hidden_field( context, "GXH_vTFJC_PROVIDERPHONE_SEL", StringUtil.RTrim( AV34TFJC_ProviderPhone_Sel));
         GxWebStd.gx_hidden_field( context, "GXH_vTFJC_PROVIDERUSER", AV37TFJC_ProviderUser);
         GxWebStd.gx_hidden_field( context, "GXH_vTFJC_PROVIDERUSER_SEL", AV38TFJC_ProviderUser_Sel);
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_31", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_31), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV42GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV44GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV43GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV40DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV40DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vJC_PROVIDERIDTITLEFILTERDATA", AV16JC_ProviderIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vJC_PROVIDERIDTITLEFILTERDATA", AV16JC_ProviderIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vJC_PROVIDERNAMETITLEFILTERDATA", AV20JC_ProviderNameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vJC_PROVIDERNAMETITLEFILTERDATA", AV20JC_ProviderNameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vJC_PROVIDERSHORTNAMETITLEFILTERDATA", AV24JC_ProviderShortNameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vJC_PROVIDERSHORTNAMETITLEFILTERDATA", AV24JC_ProviderShortNameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vJC_PROVIDERADDRESSSTITLEFILTERDATA", AV28JC_ProviderAddresssTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vJC_PROVIDERADDRESSSTITLEFILTERDATA", AV28JC_ProviderAddresssTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vJC_PROVIDERPHONETITLEFILTERDATA", AV32JC_ProviderPhoneTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vJC_PROVIDERPHONETITLEFILTERDATA", AV32JC_ProviderPhoneTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vJC_PROVIDERUSERTITLEFILTERDATA", AV36JC_ProviderUserTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vJC_PROVIDERUSERTITLEFILTERDATA", AV36JC_ProviderUserTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV68Pgmname));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_UPDATE", AV47IsAuthorized_Update);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_DELETE", AV49IsAuthorized_Delete);
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
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Caption", StringUtil.RTrim( Ddo_jc_providerid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Tooltip", StringUtil.RTrim( Ddo_jc_providerid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Cls", StringUtil.RTrim( Ddo_jc_providerid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Filteredtext_set", StringUtil.RTrim( Ddo_jc_providerid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Filteredtextto_set", StringUtil.RTrim( Ddo_jc_providerid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Dropdownoptionstype", StringUtil.RTrim( Ddo_jc_providerid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_jc_providerid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Includesortasc", StringUtil.BoolToStr( Ddo_jc_providerid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Includesortdsc", StringUtil.BoolToStr( Ddo_jc_providerid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Sortedstatus", StringUtil.RTrim( Ddo_jc_providerid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Includefilter", StringUtil.BoolToStr( Ddo_jc_providerid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Filtertype", StringUtil.RTrim( Ddo_jc_providerid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Filterisrange", StringUtil.BoolToStr( Ddo_jc_providerid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Includedatalist", StringUtil.BoolToStr( Ddo_jc_providerid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Sortasc", StringUtil.RTrim( Ddo_jc_providerid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Sortdsc", StringUtil.RTrim( Ddo_jc_providerid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Cleanfilter", StringUtil.RTrim( Ddo_jc_providerid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Rangefilterfrom", StringUtil.RTrim( Ddo_jc_providerid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Rangefilterto", StringUtil.RTrim( Ddo_jc_providerid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Searchbuttontext", StringUtil.RTrim( Ddo_jc_providerid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Caption", StringUtil.RTrim( Ddo_jc_providername_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Tooltip", StringUtil.RTrim( Ddo_jc_providername_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Cls", StringUtil.RTrim( Ddo_jc_providername_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Filteredtext_set", StringUtil.RTrim( Ddo_jc_providername_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Selectedvalue_set", StringUtil.RTrim( Ddo_jc_providername_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_jc_providername_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_jc_providername_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Includesortasc", StringUtil.BoolToStr( Ddo_jc_providername_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Includesortdsc", StringUtil.BoolToStr( Ddo_jc_providername_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Sortedstatus", StringUtil.RTrim( Ddo_jc_providername_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Includefilter", StringUtil.BoolToStr( Ddo_jc_providername_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Filtertype", StringUtil.RTrim( Ddo_jc_providername_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Filterisrange", StringUtil.BoolToStr( Ddo_jc_providername_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Includedatalist", StringUtil.BoolToStr( Ddo_jc_providername_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Datalisttype", StringUtil.RTrim( Ddo_jc_providername_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Datalistproc", StringUtil.RTrim( Ddo_jc_providername_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_jc_providername_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Sortasc", StringUtil.RTrim( Ddo_jc_providername_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Sortdsc", StringUtil.RTrim( Ddo_jc_providername_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Loadingdata", StringUtil.RTrim( Ddo_jc_providername_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Cleanfilter", StringUtil.RTrim( Ddo_jc_providername_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Noresultsfound", StringUtil.RTrim( Ddo_jc_providername_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Searchbuttontext", StringUtil.RTrim( Ddo_jc_providername_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Caption", StringUtil.RTrim( Ddo_jc_providershortname_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Tooltip", StringUtil.RTrim( Ddo_jc_providershortname_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Cls", StringUtil.RTrim( Ddo_jc_providershortname_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Filteredtext_set", StringUtil.RTrim( Ddo_jc_providershortname_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Selectedvalue_set", StringUtil.RTrim( Ddo_jc_providershortname_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_jc_providershortname_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_jc_providershortname_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Includesortasc", StringUtil.BoolToStr( Ddo_jc_providershortname_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Includesortdsc", StringUtil.BoolToStr( Ddo_jc_providershortname_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Sortedstatus", StringUtil.RTrim( Ddo_jc_providershortname_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Includefilter", StringUtil.BoolToStr( Ddo_jc_providershortname_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Filtertype", StringUtil.RTrim( Ddo_jc_providershortname_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Filterisrange", StringUtil.BoolToStr( Ddo_jc_providershortname_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Includedatalist", StringUtil.BoolToStr( Ddo_jc_providershortname_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Datalisttype", StringUtil.RTrim( Ddo_jc_providershortname_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Datalistproc", StringUtil.RTrim( Ddo_jc_providershortname_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_jc_providershortname_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Sortasc", StringUtil.RTrim( Ddo_jc_providershortname_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Sortdsc", StringUtil.RTrim( Ddo_jc_providershortname_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Loadingdata", StringUtil.RTrim( Ddo_jc_providershortname_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Cleanfilter", StringUtil.RTrim( Ddo_jc_providershortname_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Noresultsfound", StringUtil.RTrim( Ddo_jc_providershortname_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Searchbuttontext", StringUtil.RTrim( Ddo_jc_providershortname_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Caption", StringUtil.RTrim( Ddo_jc_provideraddresss_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Tooltip", StringUtil.RTrim( Ddo_jc_provideraddresss_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Cls", StringUtil.RTrim( Ddo_jc_provideraddresss_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Filteredtext_set", StringUtil.RTrim( Ddo_jc_provideraddresss_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Selectedvalue_set", StringUtil.RTrim( Ddo_jc_provideraddresss_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Dropdownoptionstype", StringUtil.RTrim( Ddo_jc_provideraddresss_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_jc_provideraddresss_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Includesortasc", StringUtil.BoolToStr( Ddo_jc_provideraddresss_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Includesortdsc", StringUtil.BoolToStr( Ddo_jc_provideraddresss_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Sortedstatus", StringUtil.RTrim( Ddo_jc_provideraddresss_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Includefilter", StringUtil.BoolToStr( Ddo_jc_provideraddresss_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Filtertype", StringUtil.RTrim( Ddo_jc_provideraddresss_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Filterisrange", StringUtil.BoolToStr( Ddo_jc_provideraddresss_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Includedatalist", StringUtil.BoolToStr( Ddo_jc_provideraddresss_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Datalisttype", StringUtil.RTrim( Ddo_jc_provideraddresss_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Datalistproc", StringUtil.RTrim( Ddo_jc_provideraddresss_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_jc_provideraddresss_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Sortasc", StringUtil.RTrim( Ddo_jc_provideraddresss_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Sortdsc", StringUtil.RTrim( Ddo_jc_provideraddresss_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Loadingdata", StringUtil.RTrim( Ddo_jc_provideraddresss_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Cleanfilter", StringUtil.RTrim( Ddo_jc_provideraddresss_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Noresultsfound", StringUtil.RTrim( Ddo_jc_provideraddresss_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Searchbuttontext", StringUtil.RTrim( Ddo_jc_provideraddresss_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Caption", StringUtil.RTrim( Ddo_jc_providerphone_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Tooltip", StringUtil.RTrim( Ddo_jc_providerphone_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Cls", StringUtil.RTrim( Ddo_jc_providerphone_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Filteredtext_set", StringUtil.RTrim( Ddo_jc_providerphone_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Selectedvalue_set", StringUtil.RTrim( Ddo_jc_providerphone_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Dropdownoptionstype", StringUtil.RTrim( Ddo_jc_providerphone_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_jc_providerphone_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Includesortasc", StringUtil.BoolToStr( Ddo_jc_providerphone_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Includesortdsc", StringUtil.BoolToStr( Ddo_jc_providerphone_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Sortedstatus", StringUtil.RTrim( Ddo_jc_providerphone_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Includefilter", StringUtil.BoolToStr( Ddo_jc_providerphone_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Filtertype", StringUtil.RTrim( Ddo_jc_providerphone_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Filterisrange", StringUtil.BoolToStr( Ddo_jc_providerphone_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Includedatalist", StringUtil.BoolToStr( Ddo_jc_providerphone_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Datalisttype", StringUtil.RTrim( Ddo_jc_providerphone_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Datalistproc", StringUtil.RTrim( Ddo_jc_providerphone_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_jc_providerphone_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Sortasc", StringUtil.RTrim( Ddo_jc_providerphone_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Sortdsc", StringUtil.RTrim( Ddo_jc_providerphone_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Loadingdata", StringUtil.RTrim( Ddo_jc_providerphone_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Cleanfilter", StringUtil.RTrim( Ddo_jc_providerphone_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Noresultsfound", StringUtil.RTrim( Ddo_jc_providerphone_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Searchbuttontext", StringUtil.RTrim( Ddo_jc_providerphone_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Caption", StringUtil.RTrim( Ddo_jc_provideruser_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Tooltip", StringUtil.RTrim( Ddo_jc_provideruser_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Cls", StringUtil.RTrim( Ddo_jc_provideruser_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Filteredtext_set", StringUtil.RTrim( Ddo_jc_provideruser_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Selectedvalue_set", StringUtil.RTrim( Ddo_jc_provideruser_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Dropdownoptionstype", StringUtil.RTrim( Ddo_jc_provideruser_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_jc_provideruser_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Includesortasc", StringUtil.BoolToStr( Ddo_jc_provideruser_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Includesortdsc", StringUtil.BoolToStr( Ddo_jc_provideruser_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Sortedstatus", StringUtil.RTrim( Ddo_jc_provideruser_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Includefilter", StringUtil.BoolToStr( Ddo_jc_provideruser_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Filtertype", StringUtil.RTrim( Ddo_jc_provideruser_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Filterisrange", StringUtil.BoolToStr( Ddo_jc_provideruser_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Includedatalist", StringUtil.BoolToStr( Ddo_jc_provideruser_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Datalisttype", StringUtil.RTrim( Ddo_jc_provideruser_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Datalistproc", StringUtil.RTrim( Ddo_jc_provideruser_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_jc_provideruser_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Sortasc", StringUtil.RTrim( Ddo_jc_provideruser_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Sortdsc", StringUtil.RTrim( Ddo_jc_provideruser_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Loadingdata", StringUtil.RTrim( Ddo_jc_provideruser_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Cleanfilter", StringUtil.RTrim( Ddo_jc_provideruser_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Noresultsfound", StringUtil.RTrim( Ddo_jc_provideruser_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Searchbuttontext", StringUtil.RTrim( Ddo_jc_provideruser_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Activeeventkey", StringUtil.RTrim( Ddo_jc_providerid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Filteredtext_get", StringUtil.RTrim( Ddo_jc_providerid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Filteredtextto_get", StringUtil.RTrim( Ddo_jc_providerid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Activeeventkey", StringUtil.RTrim( Ddo_jc_providername_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Filteredtext_get", StringUtil.RTrim( Ddo_jc_providername_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Selectedvalue_get", StringUtil.RTrim( Ddo_jc_providername_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Activeeventkey", StringUtil.RTrim( Ddo_jc_providershortname_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Filteredtext_get", StringUtil.RTrim( Ddo_jc_providershortname_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Selectedvalue_get", StringUtil.RTrim( Ddo_jc_providershortname_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Activeeventkey", StringUtil.RTrim( Ddo_jc_provideraddresss_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Filteredtext_get", StringUtil.RTrim( Ddo_jc_provideraddresss_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Selectedvalue_get", StringUtil.RTrim( Ddo_jc_provideraddresss_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Activeeventkey", StringUtil.RTrim( Ddo_jc_providerphone_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Filteredtext_get", StringUtil.RTrim( Ddo_jc_providerphone_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Selectedvalue_get", StringUtil.RTrim( Ddo_jc_providerphone_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Activeeventkey", StringUtil.RTrim( Ddo_jc_provideruser_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Filteredtext_get", StringUtil.RTrim( Ddo_jc_provideruser_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Selectedvalue_get", StringUtil.RTrim( Ddo_jc_provideruser_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Activeeventkey", StringUtil.RTrim( Ddo_jc_providerid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Filteredtext_get", StringUtil.RTrim( Ddo_jc_providerid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERID_Filteredtextto_get", StringUtil.RTrim( Ddo_jc_providerid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Activeeventkey", StringUtil.RTrim( Ddo_jc_providername_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Filteredtext_get", StringUtil.RTrim( Ddo_jc_providername_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERNAME_Selectedvalue_get", StringUtil.RTrim( Ddo_jc_providername_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Activeeventkey", StringUtil.RTrim( Ddo_jc_providershortname_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Filteredtext_get", StringUtil.RTrim( Ddo_jc_providershortname_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERSHORTNAME_Selectedvalue_get", StringUtil.RTrim( Ddo_jc_providershortname_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Activeeventkey", StringUtil.RTrim( Ddo_jc_provideraddresss_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Filteredtext_get", StringUtil.RTrim( Ddo_jc_provideraddresss_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERADDRESSS_Selectedvalue_get", StringUtil.RTrim( Ddo_jc_provideraddresss_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Activeeventkey", StringUtil.RTrim( Ddo_jc_providerphone_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Filteredtext_get", StringUtil.RTrim( Ddo_jc_providerphone_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERPHONE_Selectedvalue_get", StringUtil.RTrim( Ddo_jc_providerphone_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Activeeventkey", StringUtil.RTrim( Ddo_jc_provideruser_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Filteredtext_get", StringUtil.RTrim( Ddo_jc_provideruser_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_JC_PROVIDERUSER_Selectedvalue_get", StringUtil.RTrim( Ddo_jc_provideruser_Selectedvalue_get));
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
            WE8I2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT8I2( ) ;
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
         return formatLink("jc_providerww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "JC_ProviderWW" ;
      }

      public override String GetPgmdesc( )
      {
         return " 医院" ;
      }

      protected void WB8I0( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroupColoredActions", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            ClassString = "Button ButtonColor";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(31), 2, 0)+","+"null"+");", "插入", bttBtninsert_Jsonclick, 5, "插入", "", StyleString, ClassString, bttBtninsert_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_JC_ProviderWW.htm");
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"31\">") ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV45Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV46Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV48Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Visible), 5, 0, ".", "")));
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
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtJC_ProviderName_Link));
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
         if ( wbEnd == 31 )
         {
            wbEnd = 0;
            nRC_GXsfl_31 = (short)(nGXsfl_31_idx-1);
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV42GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV44GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV43GridPageSize);
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
            ucDdo_jc_providerid.SetProperty("FilterType", Ddo_jc_providerid_Filtertype);
            ucDdo_jc_providerid.SetProperty("FilterIsRange", Ddo_jc_providerid_Filterisrange);
            ucDdo_jc_providerid.SetProperty("IncludeDataList", Ddo_jc_providerid_Includedatalist);
            ucDdo_jc_providerid.SetProperty("SortASC", Ddo_jc_providerid_Sortasc);
            ucDdo_jc_providerid.SetProperty("SortDSC", Ddo_jc_providerid_Sortdsc);
            ucDdo_jc_providerid.SetProperty("CleanFilter", Ddo_jc_providerid_Cleanfilter);
            ucDdo_jc_providerid.SetProperty("RangeFilterFrom", Ddo_jc_providerid_Rangefilterfrom);
            ucDdo_jc_providerid.SetProperty("RangeFilterTo", Ddo_jc_providerid_Rangefilterto);
            ucDdo_jc_providerid.SetProperty("SearchButtonText", Ddo_jc_providerid_Searchbuttontext);
            ucDdo_jc_providerid.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_jc_providerid.SetProperty("DropDownOptionsData", AV16JC_ProviderIDTitleFilterData);
            ucDdo_jc_providerid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_jc_providerid_Internalname, "DDO_JC_PROVIDERIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_jc_provideridtitlecontrolidtoreplace_Internalname, AV19ddo_JC_ProviderIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", 0, edtavDdo_jc_provideridtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_JC_ProviderWW.htm");
            /* User Defined Control */
            ucDdo_jc_providername.SetProperty("Caption", Ddo_jc_providername_Caption);
            ucDdo_jc_providername.SetProperty("Tooltip", Ddo_jc_providername_Tooltip);
            ucDdo_jc_providername.SetProperty("Cls", Ddo_jc_providername_Cls);
            ucDdo_jc_providername.SetProperty("DropDownOptionsType", Ddo_jc_providername_Dropdownoptionstype);
            ucDdo_jc_providername.SetProperty("IncludeSortASC", Ddo_jc_providername_Includesortasc);
            ucDdo_jc_providername.SetProperty("IncludeSortDSC", Ddo_jc_providername_Includesortdsc);
            ucDdo_jc_providername.SetProperty("IncludeFilter", Ddo_jc_providername_Includefilter);
            ucDdo_jc_providername.SetProperty("FilterType", Ddo_jc_providername_Filtertype);
            ucDdo_jc_providername.SetProperty("FilterIsRange", Ddo_jc_providername_Filterisrange);
            ucDdo_jc_providername.SetProperty("IncludeDataList", Ddo_jc_providername_Includedatalist);
            ucDdo_jc_providername.SetProperty("DataListType", Ddo_jc_providername_Datalisttype);
            ucDdo_jc_providername.SetProperty("DataListProc", Ddo_jc_providername_Datalistproc);
            ucDdo_jc_providername.SetProperty("DataListUpdateMinimumCharacters", Ddo_jc_providername_Datalistupdateminimumcharacters);
            ucDdo_jc_providername.SetProperty("SortASC", Ddo_jc_providername_Sortasc);
            ucDdo_jc_providername.SetProperty("SortDSC", Ddo_jc_providername_Sortdsc);
            ucDdo_jc_providername.SetProperty("LoadingData", Ddo_jc_providername_Loadingdata);
            ucDdo_jc_providername.SetProperty("CleanFilter", Ddo_jc_providername_Cleanfilter);
            ucDdo_jc_providername.SetProperty("NoResultsFound", Ddo_jc_providername_Noresultsfound);
            ucDdo_jc_providername.SetProperty("SearchButtonText", Ddo_jc_providername_Searchbuttontext);
            ucDdo_jc_providername.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_jc_providername.SetProperty("DropDownOptionsData", AV20JC_ProviderNameTitleFilterData);
            ucDdo_jc_providername.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_jc_providername_Internalname, "DDO_JC_PROVIDERNAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_jc_providernametitlecontrolidtoreplace_Internalname, AV23ddo_JC_ProviderNameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", 0, edtavDdo_jc_providernametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_JC_ProviderWW.htm");
            /* User Defined Control */
            ucDdo_jc_providershortname.SetProperty("Caption", Ddo_jc_providershortname_Caption);
            ucDdo_jc_providershortname.SetProperty("Tooltip", Ddo_jc_providershortname_Tooltip);
            ucDdo_jc_providershortname.SetProperty("Cls", Ddo_jc_providershortname_Cls);
            ucDdo_jc_providershortname.SetProperty("DropDownOptionsType", Ddo_jc_providershortname_Dropdownoptionstype);
            ucDdo_jc_providershortname.SetProperty("IncludeSortASC", Ddo_jc_providershortname_Includesortasc);
            ucDdo_jc_providershortname.SetProperty("IncludeSortDSC", Ddo_jc_providershortname_Includesortdsc);
            ucDdo_jc_providershortname.SetProperty("IncludeFilter", Ddo_jc_providershortname_Includefilter);
            ucDdo_jc_providershortname.SetProperty("FilterType", Ddo_jc_providershortname_Filtertype);
            ucDdo_jc_providershortname.SetProperty("FilterIsRange", Ddo_jc_providershortname_Filterisrange);
            ucDdo_jc_providershortname.SetProperty("IncludeDataList", Ddo_jc_providershortname_Includedatalist);
            ucDdo_jc_providershortname.SetProperty("DataListType", Ddo_jc_providershortname_Datalisttype);
            ucDdo_jc_providershortname.SetProperty("DataListProc", Ddo_jc_providershortname_Datalistproc);
            ucDdo_jc_providershortname.SetProperty("DataListUpdateMinimumCharacters", Ddo_jc_providershortname_Datalistupdateminimumcharacters);
            ucDdo_jc_providershortname.SetProperty("SortASC", Ddo_jc_providershortname_Sortasc);
            ucDdo_jc_providershortname.SetProperty("SortDSC", Ddo_jc_providershortname_Sortdsc);
            ucDdo_jc_providershortname.SetProperty("LoadingData", Ddo_jc_providershortname_Loadingdata);
            ucDdo_jc_providershortname.SetProperty("CleanFilter", Ddo_jc_providershortname_Cleanfilter);
            ucDdo_jc_providershortname.SetProperty("NoResultsFound", Ddo_jc_providershortname_Noresultsfound);
            ucDdo_jc_providershortname.SetProperty("SearchButtonText", Ddo_jc_providershortname_Searchbuttontext);
            ucDdo_jc_providershortname.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_jc_providershortname.SetProperty("DropDownOptionsData", AV24JC_ProviderShortNameTitleFilterData);
            ucDdo_jc_providershortname.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_jc_providershortname_Internalname, "DDO_JC_PROVIDERSHORTNAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_jc_providershortnametitlecontrolidtoreplace_Internalname, AV27ddo_JC_ProviderShortNameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", 0, edtavDdo_jc_providershortnametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_JC_ProviderWW.htm");
            /* User Defined Control */
            ucDdo_jc_provideraddresss.SetProperty("Caption", Ddo_jc_provideraddresss_Caption);
            ucDdo_jc_provideraddresss.SetProperty("Tooltip", Ddo_jc_provideraddresss_Tooltip);
            ucDdo_jc_provideraddresss.SetProperty("Cls", Ddo_jc_provideraddresss_Cls);
            ucDdo_jc_provideraddresss.SetProperty("DropDownOptionsType", Ddo_jc_provideraddresss_Dropdownoptionstype);
            ucDdo_jc_provideraddresss.SetProperty("IncludeSortASC", Ddo_jc_provideraddresss_Includesortasc);
            ucDdo_jc_provideraddresss.SetProperty("IncludeSortDSC", Ddo_jc_provideraddresss_Includesortdsc);
            ucDdo_jc_provideraddresss.SetProperty("IncludeFilter", Ddo_jc_provideraddresss_Includefilter);
            ucDdo_jc_provideraddresss.SetProperty("FilterType", Ddo_jc_provideraddresss_Filtertype);
            ucDdo_jc_provideraddresss.SetProperty("FilterIsRange", Ddo_jc_provideraddresss_Filterisrange);
            ucDdo_jc_provideraddresss.SetProperty("IncludeDataList", Ddo_jc_provideraddresss_Includedatalist);
            ucDdo_jc_provideraddresss.SetProperty("DataListType", Ddo_jc_provideraddresss_Datalisttype);
            ucDdo_jc_provideraddresss.SetProperty("DataListProc", Ddo_jc_provideraddresss_Datalistproc);
            ucDdo_jc_provideraddresss.SetProperty("DataListUpdateMinimumCharacters", Ddo_jc_provideraddresss_Datalistupdateminimumcharacters);
            ucDdo_jc_provideraddresss.SetProperty("SortASC", Ddo_jc_provideraddresss_Sortasc);
            ucDdo_jc_provideraddresss.SetProperty("SortDSC", Ddo_jc_provideraddresss_Sortdsc);
            ucDdo_jc_provideraddresss.SetProperty("LoadingData", Ddo_jc_provideraddresss_Loadingdata);
            ucDdo_jc_provideraddresss.SetProperty("CleanFilter", Ddo_jc_provideraddresss_Cleanfilter);
            ucDdo_jc_provideraddresss.SetProperty("NoResultsFound", Ddo_jc_provideraddresss_Noresultsfound);
            ucDdo_jc_provideraddresss.SetProperty("SearchButtonText", Ddo_jc_provideraddresss_Searchbuttontext);
            ucDdo_jc_provideraddresss.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_jc_provideraddresss.SetProperty("DropDownOptionsData", AV28JC_ProviderAddresssTitleFilterData);
            ucDdo_jc_provideraddresss.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_jc_provideraddresss_Internalname, "DDO_JC_PROVIDERADDRESSSContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_jc_provideraddressstitlecontrolidtoreplace_Internalname, AV31ddo_JC_ProviderAddresssTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", 0, edtavDdo_jc_provideraddressstitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_JC_ProviderWW.htm");
            /* User Defined Control */
            ucDdo_jc_providerphone.SetProperty("Caption", Ddo_jc_providerphone_Caption);
            ucDdo_jc_providerphone.SetProperty("Tooltip", Ddo_jc_providerphone_Tooltip);
            ucDdo_jc_providerphone.SetProperty("Cls", Ddo_jc_providerphone_Cls);
            ucDdo_jc_providerphone.SetProperty("DropDownOptionsType", Ddo_jc_providerphone_Dropdownoptionstype);
            ucDdo_jc_providerphone.SetProperty("IncludeSortASC", Ddo_jc_providerphone_Includesortasc);
            ucDdo_jc_providerphone.SetProperty("IncludeSortDSC", Ddo_jc_providerphone_Includesortdsc);
            ucDdo_jc_providerphone.SetProperty("IncludeFilter", Ddo_jc_providerphone_Includefilter);
            ucDdo_jc_providerphone.SetProperty("FilterType", Ddo_jc_providerphone_Filtertype);
            ucDdo_jc_providerphone.SetProperty("FilterIsRange", Ddo_jc_providerphone_Filterisrange);
            ucDdo_jc_providerphone.SetProperty("IncludeDataList", Ddo_jc_providerphone_Includedatalist);
            ucDdo_jc_providerphone.SetProperty("DataListType", Ddo_jc_providerphone_Datalisttype);
            ucDdo_jc_providerphone.SetProperty("DataListProc", Ddo_jc_providerphone_Datalistproc);
            ucDdo_jc_providerphone.SetProperty("DataListUpdateMinimumCharacters", Ddo_jc_providerphone_Datalistupdateminimumcharacters);
            ucDdo_jc_providerphone.SetProperty("SortASC", Ddo_jc_providerphone_Sortasc);
            ucDdo_jc_providerphone.SetProperty("SortDSC", Ddo_jc_providerphone_Sortdsc);
            ucDdo_jc_providerphone.SetProperty("LoadingData", Ddo_jc_providerphone_Loadingdata);
            ucDdo_jc_providerphone.SetProperty("CleanFilter", Ddo_jc_providerphone_Cleanfilter);
            ucDdo_jc_providerphone.SetProperty("NoResultsFound", Ddo_jc_providerphone_Noresultsfound);
            ucDdo_jc_providerphone.SetProperty("SearchButtonText", Ddo_jc_providerphone_Searchbuttontext);
            ucDdo_jc_providerphone.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_jc_providerphone.SetProperty("DropDownOptionsData", AV32JC_ProviderPhoneTitleFilterData);
            ucDdo_jc_providerphone.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_jc_providerphone_Internalname, "DDO_JC_PROVIDERPHONEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_jc_providerphonetitlecontrolidtoreplace_Internalname, AV35ddo_JC_ProviderPhoneTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", 0, edtavDdo_jc_providerphonetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_JC_ProviderWW.htm");
            /* User Defined Control */
            ucDdo_jc_provideruser.SetProperty("Caption", Ddo_jc_provideruser_Caption);
            ucDdo_jc_provideruser.SetProperty("Tooltip", Ddo_jc_provideruser_Tooltip);
            ucDdo_jc_provideruser.SetProperty("Cls", Ddo_jc_provideruser_Cls);
            ucDdo_jc_provideruser.SetProperty("DropDownOptionsType", Ddo_jc_provideruser_Dropdownoptionstype);
            ucDdo_jc_provideruser.SetProperty("IncludeSortASC", Ddo_jc_provideruser_Includesortasc);
            ucDdo_jc_provideruser.SetProperty("IncludeSortDSC", Ddo_jc_provideruser_Includesortdsc);
            ucDdo_jc_provideruser.SetProperty("IncludeFilter", Ddo_jc_provideruser_Includefilter);
            ucDdo_jc_provideruser.SetProperty("FilterType", Ddo_jc_provideruser_Filtertype);
            ucDdo_jc_provideruser.SetProperty("FilterIsRange", Ddo_jc_provideruser_Filterisrange);
            ucDdo_jc_provideruser.SetProperty("IncludeDataList", Ddo_jc_provideruser_Includedatalist);
            ucDdo_jc_provideruser.SetProperty("DataListType", Ddo_jc_provideruser_Datalisttype);
            ucDdo_jc_provideruser.SetProperty("DataListProc", Ddo_jc_provideruser_Datalistproc);
            ucDdo_jc_provideruser.SetProperty("DataListUpdateMinimumCharacters", Ddo_jc_provideruser_Datalistupdateminimumcharacters);
            ucDdo_jc_provideruser.SetProperty("SortASC", Ddo_jc_provideruser_Sortasc);
            ucDdo_jc_provideruser.SetProperty("SortDSC", Ddo_jc_provideruser_Sortdsc);
            ucDdo_jc_provideruser.SetProperty("LoadingData", Ddo_jc_provideruser_Loadingdata);
            ucDdo_jc_provideruser.SetProperty("CleanFilter", Ddo_jc_provideruser_Cleanfilter);
            ucDdo_jc_provideruser.SetProperty("NoResultsFound", Ddo_jc_provideruser_Noresultsfound);
            ucDdo_jc_provideruser.SetProperty("SearchButtonText", Ddo_jc_provideruser_Searchbuttontext);
            ucDdo_jc_provideruser.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_jc_provideruser.SetProperty("DropDownOptionsData", AV36JC_ProviderUserTitleFilterData);
            ucDdo_jc_provideruser.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_jc_provideruser_Internalname, "DDO_JC_PROVIDERUSERContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_jc_providerusertitlecontrolidtoreplace_Internalname, AV39ddo_JC_ProviderUserTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", 0, edtavDdo_jc_providerusertitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_JC_ProviderWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,61);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_JC_ProviderWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,62);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_JC_ProviderWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfjc_providerid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFJC_ProviderID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV17TFJC_ProviderID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfjc_providerid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfjc_providerid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_JC_ProviderWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfjc_providerid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFJC_ProviderID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV18TFJC_ProviderID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfjc_providerid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfjc_providerid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_JC_ProviderWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfjc_providername_Internalname, AV21TFJC_ProviderName, StringUtil.RTrim( context.localUtil.Format( AV21TFJC_ProviderName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,65);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfjc_providername_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfjc_providername_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 200, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_JC_ProviderWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfjc_providername_sel_Internalname, AV22TFJC_ProviderName_Sel, StringUtil.RTrim( context.localUtil.Format( AV22TFJC_ProviderName_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfjc_providername_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfjc_providername_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 200, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_JC_ProviderWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfjc_providershortname_Internalname, AV25TFJC_ProviderShortName, StringUtil.RTrim( context.localUtil.Format( AV25TFJC_ProviderShortName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,67);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfjc_providershortname_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfjc_providershortname_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_JC_ProviderWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfjc_providershortname_sel_Internalname, AV26TFJC_ProviderShortName_Sel, StringUtil.RTrim( context.localUtil.Format( AV26TFJC_ProviderShortName_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,68);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfjc_providershortname_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfjc_providershortname_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_JC_ProviderWW.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfjc_provideraddresss_Internalname, AV29TFJC_ProviderAddresss, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,69);\"", 0, edtavTfjc_provideraddresss_Visible, 1, 0, 80, "chr", 8, "row", StyleString, ClassString, "", "", "1024", 1, 0, "", "", 0, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_JC_ProviderWW.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfjc_provideraddresss_sel_Internalname, AV30TFJC_ProviderAddresss_Sel, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,70);\"", 0, edtavTfjc_provideraddresss_sel_Visible, 1, 0, 80, "chr", 8, "row", StyleString, ClassString, "", "", "1024", 1, 0, "", "", 0, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_JC_ProviderWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfjc_providerphone_Internalname, StringUtil.RTrim( AV33TFJC_ProviderPhone), StringUtil.RTrim( context.localUtil.Format( AV33TFJC_ProviderPhone, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,71);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfjc_providerphone_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfjc_providerphone_Visible, 1, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, 0, true, "", "left", true, "HLP_JC_ProviderWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfjc_providerphone_sel_Internalname, StringUtil.RTrim( AV34TFJC_ProviderPhone_Sel), StringUtil.RTrim( context.localUtil.Format( AV34TFJC_ProviderPhone_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,72);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfjc_providerphone_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfjc_providerphone_sel_Visible, 1, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, 0, true, "", "left", true, "HLP_JC_ProviderWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfjc_provideruser_Internalname, AV37TFJC_ProviderUser, StringUtil.RTrim( context.localUtil.Format( AV37TFJC_ProviderUser, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,73);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfjc_provideruser_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfjc_provideruser_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_JC_ProviderWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfjc_provideruser_sel_Internalname, AV38TFJC_ProviderUser_Sel, StringUtil.RTrim( context.localUtil.Format( AV38TFJC_ProviderUser_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,74);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfjc_provideruser_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfjc_provideruser_sel_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_JC_ProviderWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 31 )
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

      protected void START8I2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", " 医院", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP8I0( ) ;
      }

      protected void WS8I2( )
      {
         START8I2( ) ;
         EVT8I2( ) ;
      }

      protected void EVT8I2( )
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
                              E118I2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E128I2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_JC_PROVIDERID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E138I2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_JC_PROVIDERNAME.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E148I2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_JC_PROVIDERSHORTNAME.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E158I2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_JC_PROVIDERADDRESSS.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E168I2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_JC_PROVIDERPHONE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E178I2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_JC_PROVIDERUSER.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E188I2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E198I2 ();
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
                              nGXsfl_31_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
                              SubsflControlProps_312( ) ;
                              AV45Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV45Display)) ? AV65Display_GXI : context.convertURL( context.PathToRelativeUrl( AV45Display))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV45Display), true);
                              AV46Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV46Update)) ? AV66Update_GXI : context.convertURL( context.PathToRelativeUrl( AV46Update))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV46Update), true);
                              AV48Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV48Delete)) ? AV67Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV48Delete))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV48Delete), true);
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
                                    E208I2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E218I2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E228I2 ();
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
                                       /* Set Refresh If Tfjc_providerid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFJC_PROVIDERID"), ".", ",") != Convert.ToDecimal( AV17TFJC_ProviderID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfjc_providerid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFJC_PROVIDERID_TO"), ".", ",") != Convert.ToDecimal( AV18TFJC_ProviderID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfjc_providername Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFJC_PROVIDERNAME"), AV21TFJC_ProviderName) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfjc_providername_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFJC_PROVIDERNAME_SEL"), AV22TFJC_ProviderName_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfjc_providershortname Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFJC_PROVIDERSHORTNAME"), AV25TFJC_ProviderShortName) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfjc_providershortname_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFJC_PROVIDERSHORTNAME_SEL"), AV26TFJC_ProviderShortName_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfjc_provideraddresss Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFJC_PROVIDERADDRESSS"), AV29TFJC_ProviderAddresss) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfjc_provideraddresss_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFJC_PROVIDERADDRESSS_SEL"), AV30TFJC_ProviderAddresss_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfjc_providerphone Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFJC_PROVIDERPHONE"), AV33TFJC_ProviderPhone) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfjc_providerphone_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFJC_PROVIDERPHONE_SEL"), AV34TFJC_ProviderPhone_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfjc_provideruser Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFJC_PROVIDERUSER"), AV37TFJC_ProviderUser) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfjc_provideruser_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFJC_PROVIDERUSER_SEL"), AV38TFJC_ProviderUser_Sel) != 0 )
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

      protected void WE8I2( )
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

      protected void PA8I2( )
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
         SubsflControlProps_312( ) ;
         while ( nGXsfl_31_idx <= nRC_GXsfl_31 )
         {
            sendrow_312( ) ;
            nGXsfl_31_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_31_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_31_idx+1));
            sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
            SubsflControlProps_312( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV13OrderedBy ,
                                       bool AV14OrderedDsc ,
                                       long AV17TFJC_ProviderID ,
                                       long AV18TFJC_ProviderID_To ,
                                       String AV21TFJC_ProviderName ,
                                       String AV22TFJC_ProviderName_Sel ,
                                       String AV25TFJC_ProviderShortName ,
                                       String AV26TFJC_ProviderShortName_Sel ,
                                       String AV29TFJC_ProviderAddresss ,
                                       String AV30TFJC_ProviderAddresss_Sel ,
                                       String AV33TFJC_ProviderPhone ,
                                       String AV34TFJC_ProviderPhone_Sel ,
                                       String AV37TFJC_ProviderUser ,
                                       String AV38TFJC_ProviderUser_Sel ,
                                       String AV19ddo_JC_ProviderIDTitleControlIdToReplace ,
                                       String AV23ddo_JC_ProviderNameTitleControlIdToReplace ,
                                       String AV27ddo_JC_ProviderShortNameTitleControlIdToReplace ,
                                       String AV31ddo_JC_ProviderAddresssTitleControlIdToReplace ,
                                       String AV35ddo_JC_ProviderPhoneTitleControlIdToReplace ,
                                       String AV39ddo_JC_ProviderUserTitleControlIdToReplace ,
                                       String AV68Pgmname ,
                                       bool AV47IsAuthorized_Update ,
                                       bool AV49IsAuthorized_Delete )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF8I2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_JC_PROVIDERADDRESSS", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A161JC_ProviderAddresss, "")), context));
         GxWebStd.gx_hidden_field( context, "JC_PROVIDERADDRESSS", A161JC_ProviderAddresss);
         GxWebStd.gx_hidden_field( context, "gxhash_JC_PROVIDERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A87JC_ProviderID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "JC_PROVIDERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A87JC_ProviderID), 18, 0, ".", "")));
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
         RF8I2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV68Pgmname = "JC_ProviderWW";
         context.Gx_err = 0;
      }

      protected void RF8I2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 31;
         /* Execute user event: Refresh */
         E218I2 ();
         nGXsfl_31_idx = 1;
         sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
         SubsflControlProps_312( ) ;
         bGXsfl_31_Refreshing = true;
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
            SubsflControlProps_312( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV53JC_ProviderWWDS_1_Tfjc_providerid ,
                                                 AV54JC_ProviderWWDS_2_Tfjc_providerid_to ,
                                                 AV56JC_ProviderWWDS_4_Tfjc_providername_sel ,
                                                 AV55JC_ProviderWWDS_3_Tfjc_providername ,
                                                 AV58JC_ProviderWWDS_6_Tfjc_providershortname_sel ,
                                                 AV57JC_ProviderWWDS_5_Tfjc_providershortname ,
                                                 AV60JC_ProviderWWDS_8_Tfjc_provideraddresss_sel ,
                                                 AV59JC_ProviderWWDS_7_Tfjc_provideraddresss ,
                                                 AV62JC_ProviderWWDS_10_Tfjc_providerphone_sel ,
                                                 AV61JC_ProviderWWDS_9_Tfjc_providerphone ,
                                                 AV64JC_ProviderWWDS_12_Tfjc_provideruser_sel ,
                                                 AV63JC_ProviderWWDS_11_Tfjc_provideruser ,
                                                 A87JC_ProviderID ,
                                                 A89JC_ProviderName ,
                                                 A160JC_ProviderShortName ,
                                                 A161JC_ProviderAddresss ,
                                                 A162JC_ProviderPhone ,
                                                 A163JC_ProviderUser ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                                 TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV55JC_ProviderWWDS_3_Tfjc_providername = StringUtil.Concat( StringUtil.RTrim( AV55JC_ProviderWWDS_3_Tfjc_providername), "%", "");
            lV57JC_ProviderWWDS_5_Tfjc_providershortname = StringUtil.Concat( StringUtil.RTrim( AV57JC_ProviderWWDS_5_Tfjc_providershortname), "%", "");
            lV59JC_ProviderWWDS_7_Tfjc_provideraddresss = StringUtil.Concat( StringUtil.RTrim( AV59JC_ProviderWWDS_7_Tfjc_provideraddresss), "%", "");
            lV61JC_ProviderWWDS_9_Tfjc_providerphone = StringUtil.PadR( StringUtil.RTrim( AV61JC_ProviderWWDS_9_Tfjc_providerphone), 20, "%");
            lV63JC_ProviderWWDS_11_Tfjc_provideruser = StringUtil.Concat( StringUtil.RTrim( AV63JC_ProviderWWDS_11_Tfjc_provideruser), "%", "");
            /* Using cursor H008I2 */
            pr_default.execute(0, new Object[] {AV53JC_ProviderWWDS_1_Tfjc_providerid, AV54JC_ProviderWWDS_2_Tfjc_providerid_to, lV55JC_ProviderWWDS_3_Tfjc_providername, AV56JC_ProviderWWDS_4_Tfjc_providername_sel, lV57JC_ProviderWWDS_5_Tfjc_providershortname, AV58JC_ProviderWWDS_6_Tfjc_providershortname_sel, lV59JC_ProviderWWDS_7_Tfjc_provideraddresss, AV60JC_ProviderWWDS_8_Tfjc_provideraddresss_sel, lV61JC_ProviderWWDS_9_Tfjc_providerphone, AV62JC_ProviderWWDS_10_Tfjc_providerphone_sel, lV63JC_ProviderWWDS_11_Tfjc_provideruser, AV64JC_ProviderWWDS_12_Tfjc_provideruser_sel, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_31_idx = 1;
            sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
            SubsflControlProps_312( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A163JC_ProviderUser = H008I2_A163JC_ProviderUser[0];
               n163JC_ProviderUser = H008I2_n163JC_ProviderUser[0];
               A162JC_ProviderPhone = H008I2_A162JC_ProviderPhone[0];
               n162JC_ProviderPhone = H008I2_n162JC_ProviderPhone[0];
               A161JC_ProviderAddresss = H008I2_A161JC_ProviderAddresss[0];
               n161JC_ProviderAddresss = H008I2_n161JC_ProviderAddresss[0];
               A160JC_ProviderShortName = H008I2_A160JC_ProviderShortName[0];
               n160JC_ProviderShortName = H008I2_n160JC_ProviderShortName[0];
               A89JC_ProviderName = H008I2_A89JC_ProviderName[0];
               n89JC_ProviderName = H008I2_n89JC_ProviderName[0];
               A87JC_ProviderID = H008I2_A87JC_ProviderID[0];
               E228I2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 31;
            WB8I0( ) ;
         }
         bGXsfl_31_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes8I2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_JC_PROVIDERADDRESSS"+"_"+sGXsfl_31_idx, GetSecureSignedToken( sGXsfl_31_idx, StringUtil.RTrim( context.localUtil.Format( A161JC_ProviderAddresss, "")), context));
         GxWebStd.gx_hidden_field( context, "gxhash_JC_PROVIDERID"+"_"+sGXsfl_31_idx, GetSecureSignedToken( sGXsfl_31_idx, context.localUtil.Format( (decimal)(A87JC_ProviderID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         AV53JC_ProviderWWDS_1_Tfjc_providerid = AV17TFJC_ProviderID;
         AV54JC_ProviderWWDS_2_Tfjc_providerid_to = AV18TFJC_ProviderID_To;
         AV55JC_ProviderWWDS_3_Tfjc_providername = AV21TFJC_ProviderName;
         AV56JC_ProviderWWDS_4_Tfjc_providername_sel = AV22TFJC_ProviderName_Sel;
         AV57JC_ProviderWWDS_5_Tfjc_providershortname = AV25TFJC_ProviderShortName;
         AV58JC_ProviderWWDS_6_Tfjc_providershortname_sel = AV26TFJC_ProviderShortName_Sel;
         AV59JC_ProviderWWDS_7_Tfjc_provideraddresss = AV29TFJC_ProviderAddresss;
         AV60JC_ProviderWWDS_8_Tfjc_provideraddresss_sel = AV30TFJC_ProviderAddresss_Sel;
         AV61JC_ProviderWWDS_9_Tfjc_providerphone = AV33TFJC_ProviderPhone;
         AV62JC_ProviderWWDS_10_Tfjc_providerphone_sel = AV34TFJC_ProviderPhone_Sel;
         AV63JC_ProviderWWDS_11_Tfjc_provideruser = AV37TFJC_ProviderUser;
         AV64JC_ProviderWWDS_12_Tfjc_provideruser_sel = AV38TFJC_ProviderUser_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV53JC_ProviderWWDS_1_Tfjc_providerid ,
                                              AV54JC_ProviderWWDS_2_Tfjc_providerid_to ,
                                              AV56JC_ProviderWWDS_4_Tfjc_providername_sel ,
                                              AV55JC_ProviderWWDS_3_Tfjc_providername ,
                                              AV58JC_ProviderWWDS_6_Tfjc_providershortname_sel ,
                                              AV57JC_ProviderWWDS_5_Tfjc_providershortname ,
                                              AV60JC_ProviderWWDS_8_Tfjc_provideraddresss_sel ,
                                              AV59JC_ProviderWWDS_7_Tfjc_provideraddresss ,
                                              AV62JC_ProviderWWDS_10_Tfjc_providerphone_sel ,
                                              AV61JC_ProviderWWDS_9_Tfjc_providerphone ,
                                              AV64JC_ProviderWWDS_12_Tfjc_provideruser_sel ,
                                              AV63JC_ProviderWWDS_11_Tfjc_provideruser ,
                                              A87JC_ProviderID ,
                                              A89JC_ProviderName ,
                                              A160JC_ProviderShortName ,
                                              A161JC_ProviderAddresss ,
                                              A162JC_ProviderPhone ,
                                              A163JC_ProviderUser ,
                                              AV13OrderedBy ,
                                              AV14OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV55JC_ProviderWWDS_3_Tfjc_providername = StringUtil.Concat( StringUtil.RTrim( AV55JC_ProviderWWDS_3_Tfjc_providername), "%", "");
         lV57JC_ProviderWWDS_5_Tfjc_providershortname = StringUtil.Concat( StringUtil.RTrim( AV57JC_ProviderWWDS_5_Tfjc_providershortname), "%", "");
         lV59JC_ProviderWWDS_7_Tfjc_provideraddresss = StringUtil.Concat( StringUtil.RTrim( AV59JC_ProviderWWDS_7_Tfjc_provideraddresss), "%", "");
         lV61JC_ProviderWWDS_9_Tfjc_providerphone = StringUtil.PadR( StringUtil.RTrim( AV61JC_ProviderWWDS_9_Tfjc_providerphone), 20, "%");
         lV63JC_ProviderWWDS_11_Tfjc_provideruser = StringUtil.Concat( StringUtil.RTrim( AV63JC_ProviderWWDS_11_Tfjc_provideruser), "%", "");
         /* Using cursor H008I3 */
         pr_default.execute(1, new Object[] {AV53JC_ProviderWWDS_1_Tfjc_providerid, AV54JC_ProviderWWDS_2_Tfjc_providerid_to, lV55JC_ProviderWWDS_3_Tfjc_providername, AV56JC_ProviderWWDS_4_Tfjc_providername_sel, lV57JC_ProviderWWDS_5_Tfjc_providershortname, AV58JC_ProviderWWDS_6_Tfjc_providershortname_sel, lV59JC_ProviderWWDS_7_Tfjc_provideraddresss, AV60JC_ProviderWWDS_8_Tfjc_provideraddresss_sel, lV61JC_ProviderWWDS_9_Tfjc_providerphone, AV62JC_ProviderWWDS_10_Tfjc_providerphone_sel, lV63JC_ProviderWWDS_11_Tfjc_provideruser, AV64JC_ProviderWWDS_12_Tfjc_provideruser_sel});
         GRID_nRecordCount = H008I3_AGRID_nRecordCount[0];
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
         AV53JC_ProviderWWDS_1_Tfjc_providerid = AV17TFJC_ProviderID;
         AV54JC_ProviderWWDS_2_Tfjc_providerid_to = AV18TFJC_ProviderID_To;
         AV55JC_ProviderWWDS_3_Tfjc_providername = AV21TFJC_ProviderName;
         AV56JC_ProviderWWDS_4_Tfjc_providername_sel = AV22TFJC_ProviderName_Sel;
         AV57JC_ProviderWWDS_5_Tfjc_providershortname = AV25TFJC_ProviderShortName;
         AV58JC_ProviderWWDS_6_Tfjc_providershortname_sel = AV26TFJC_ProviderShortName_Sel;
         AV59JC_ProviderWWDS_7_Tfjc_provideraddresss = AV29TFJC_ProviderAddresss;
         AV60JC_ProviderWWDS_8_Tfjc_provideraddresss_sel = AV30TFJC_ProviderAddresss_Sel;
         AV61JC_ProviderWWDS_9_Tfjc_providerphone = AV33TFJC_ProviderPhone;
         AV62JC_ProviderWWDS_10_Tfjc_providerphone_sel = AV34TFJC_ProviderPhone_Sel;
         AV63JC_ProviderWWDS_11_Tfjc_provideruser = AV37TFJC_ProviderUser;
         AV64JC_ProviderWWDS_12_Tfjc_provideruser_sel = AV38TFJC_ProviderUser_Sel;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFJC_ProviderID, AV18TFJC_ProviderID_To, AV21TFJC_ProviderName, AV22TFJC_ProviderName_Sel, AV25TFJC_ProviderShortName, AV26TFJC_ProviderShortName_Sel, AV29TFJC_ProviderAddresss, AV30TFJC_ProviderAddresss_Sel, AV33TFJC_ProviderPhone, AV34TFJC_ProviderPhone_Sel, AV37TFJC_ProviderUser, AV38TFJC_ProviderUser_Sel, AV19ddo_JC_ProviderIDTitleControlIdToReplace, AV23ddo_JC_ProviderNameTitleControlIdToReplace, AV27ddo_JC_ProviderShortNameTitleControlIdToReplace, AV31ddo_JC_ProviderAddresssTitleControlIdToReplace, AV35ddo_JC_ProviderPhoneTitleControlIdToReplace, AV39ddo_JC_ProviderUserTitleControlIdToReplace, AV68Pgmname, AV47IsAuthorized_Update, AV49IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV53JC_ProviderWWDS_1_Tfjc_providerid = AV17TFJC_ProviderID;
         AV54JC_ProviderWWDS_2_Tfjc_providerid_to = AV18TFJC_ProviderID_To;
         AV55JC_ProviderWWDS_3_Tfjc_providername = AV21TFJC_ProviderName;
         AV56JC_ProviderWWDS_4_Tfjc_providername_sel = AV22TFJC_ProviderName_Sel;
         AV57JC_ProviderWWDS_5_Tfjc_providershortname = AV25TFJC_ProviderShortName;
         AV58JC_ProviderWWDS_6_Tfjc_providershortname_sel = AV26TFJC_ProviderShortName_Sel;
         AV59JC_ProviderWWDS_7_Tfjc_provideraddresss = AV29TFJC_ProviderAddresss;
         AV60JC_ProviderWWDS_8_Tfjc_provideraddresss_sel = AV30TFJC_ProviderAddresss_Sel;
         AV61JC_ProviderWWDS_9_Tfjc_providerphone = AV33TFJC_ProviderPhone;
         AV62JC_ProviderWWDS_10_Tfjc_providerphone_sel = AV34TFJC_ProviderPhone_Sel;
         AV63JC_ProviderWWDS_11_Tfjc_provideruser = AV37TFJC_ProviderUser;
         AV64JC_ProviderWWDS_12_Tfjc_provideruser_sel = AV38TFJC_ProviderUser_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFJC_ProviderID, AV18TFJC_ProviderID_To, AV21TFJC_ProviderName, AV22TFJC_ProviderName_Sel, AV25TFJC_ProviderShortName, AV26TFJC_ProviderShortName_Sel, AV29TFJC_ProviderAddresss, AV30TFJC_ProviderAddresss_Sel, AV33TFJC_ProviderPhone, AV34TFJC_ProviderPhone_Sel, AV37TFJC_ProviderUser, AV38TFJC_ProviderUser_Sel, AV19ddo_JC_ProviderIDTitleControlIdToReplace, AV23ddo_JC_ProviderNameTitleControlIdToReplace, AV27ddo_JC_ProviderShortNameTitleControlIdToReplace, AV31ddo_JC_ProviderAddresssTitleControlIdToReplace, AV35ddo_JC_ProviderPhoneTitleControlIdToReplace, AV39ddo_JC_ProviderUserTitleControlIdToReplace, AV68Pgmname, AV47IsAuthorized_Update, AV49IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV53JC_ProviderWWDS_1_Tfjc_providerid = AV17TFJC_ProviderID;
         AV54JC_ProviderWWDS_2_Tfjc_providerid_to = AV18TFJC_ProviderID_To;
         AV55JC_ProviderWWDS_3_Tfjc_providername = AV21TFJC_ProviderName;
         AV56JC_ProviderWWDS_4_Tfjc_providername_sel = AV22TFJC_ProviderName_Sel;
         AV57JC_ProviderWWDS_5_Tfjc_providershortname = AV25TFJC_ProviderShortName;
         AV58JC_ProviderWWDS_6_Tfjc_providershortname_sel = AV26TFJC_ProviderShortName_Sel;
         AV59JC_ProviderWWDS_7_Tfjc_provideraddresss = AV29TFJC_ProviderAddresss;
         AV60JC_ProviderWWDS_8_Tfjc_provideraddresss_sel = AV30TFJC_ProviderAddresss_Sel;
         AV61JC_ProviderWWDS_9_Tfjc_providerphone = AV33TFJC_ProviderPhone;
         AV62JC_ProviderWWDS_10_Tfjc_providerphone_sel = AV34TFJC_ProviderPhone_Sel;
         AV63JC_ProviderWWDS_11_Tfjc_provideruser = AV37TFJC_ProviderUser;
         AV64JC_ProviderWWDS_12_Tfjc_provideruser_sel = AV38TFJC_ProviderUser_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFJC_ProviderID, AV18TFJC_ProviderID_To, AV21TFJC_ProviderName, AV22TFJC_ProviderName_Sel, AV25TFJC_ProviderShortName, AV26TFJC_ProviderShortName_Sel, AV29TFJC_ProviderAddresss, AV30TFJC_ProviderAddresss_Sel, AV33TFJC_ProviderPhone, AV34TFJC_ProviderPhone_Sel, AV37TFJC_ProviderUser, AV38TFJC_ProviderUser_Sel, AV19ddo_JC_ProviderIDTitleControlIdToReplace, AV23ddo_JC_ProviderNameTitleControlIdToReplace, AV27ddo_JC_ProviderShortNameTitleControlIdToReplace, AV31ddo_JC_ProviderAddresssTitleControlIdToReplace, AV35ddo_JC_ProviderPhoneTitleControlIdToReplace, AV39ddo_JC_ProviderUserTitleControlIdToReplace, AV68Pgmname, AV47IsAuthorized_Update, AV49IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV53JC_ProviderWWDS_1_Tfjc_providerid = AV17TFJC_ProviderID;
         AV54JC_ProviderWWDS_2_Tfjc_providerid_to = AV18TFJC_ProviderID_To;
         AV55JC_ProviderWWDS_3_Tfjc_providername = AV21TFJC_ProviderName;
         AV56JC_ProviderWWDS_4_Tfjc_providername_sel = AV22TFJC_ProviderName_Sel;
         AV57JC_ProviderWWDS_5_Tfjc_providershortname = AV25TFJC_ProviderShortName;
         AV58JC_ProviderWWDS_6_Tfjc_providershortname_sel = AV26TFJC_ProviderShortName_Sel;
         AV59JC_ProviderWWDS_7_Tfjc_provideraddresss = AV29TFJC_ProviderAddresss;
         AV60JC_ProviderWWDS_8_Tfjc_provideraddresss_sel = AV30TFJC_ProviderAddresss_Sel;
         AV61JC_ProviderWWDS_9_Tfjc_providerphone = AV33TFJC_ProviderPhone;
         AV62JC_ProviderWWDS_10_Tfjc_providerphone_sel = AV34TFJC_ProviderPhone_Sel;
         AV63JC_ProviderWWDS_11_Tfjc_provideruser = AV37TFJC_ProviderUser;
         AV64JC_ProviderWWDS_12_Tfjc_provideruser_sel = AV38TFJC_ProviderUser_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFJC_ProviderID, AV18TFJC_ProviderID_To, AV21TFJC_ProviderName, AV22TFJC_ProviderName_Sel, AV25TFJC_ProviderShortName, AV26TFJC_ProviderShortName_Sel, AV29TFJC_ProviderAddresss, AV30TFJC_ProviderAddresss_Sel, AV33TFJC_ProviderPhone, AV34TFJC_ProviderPhone_Sel, AV37TFJC_ProviderUser, AV38TFJC_ProviderUser_Sel, AV19ddo_JC_ProviderIDTitleControlIdToReplace, AV23ddo_JC_ProviderNameTitleControlIdToReplace, AV27ddo_JC_ProviderShortNameTitleControlIdToReplace, AV31ddo_JC_ProviderAddresssTitleControlIdToReplace, AV35ddo_JC_ProviderPhoneTitleControlIdToReplace, AV39ddo_JC_ProviderUserTitleControlIdToReplace, AV68Pgmname, AV47IsAuthorized_Update, AV49IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV53JC_ProviderWWDS_1_Tfjc_providerid = AV17TFJC_ProviderID;
         AV54JC_ProviderWWDS_2_Tfjc_providerid_to = AV18TFJC_ProviderID_To;
         AV55JC_ProviderWWDS_3_Tfjc_providername = AV21TFJC_ProviderName;
         AV56JC_ProviderWWDS_4_Tfjc_providername_sel = AV22TFJC_ProviderName_Sel;
         AV57JC_ProviderWWDS_5_Tfjc_providershortname = AV25TFJC_ProviderShortName;
         AV58JC_ProviderWWDS_6_Tfjc_providershortname_sel = AV26TFJC_ProviderShortName_Sel;
         AV59JC_ProviderWWDS_7_Tfjc_provideraddresss = AV29TFJC_ProviderAddresss;
         AV60JC_ProviderWWDS_8_Tfjc_provideraddresss_sel = AV30TFJC_ProviderAddresss_Sel;
         AV61JC_ProviderWWDS_9_Tfjc_providerphone = AV33TFJC_ProviderPhone;
         AV62JC_ProviderWWDS_10_Tfjc_providerphone_sel = AV34TFJC_ProviderPhone_Sel;
         AV63JC_ProviderWWDS_11_Tfjc_provideruser = AV37TFJC_ProviderUser;
         AV64JC_ProviderWWDS_12_Tfjc_provideruser_sel = AV38TFJC_ProviderUser_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFJC_ProviderID, AV18TFJC_ProviderID_To, AV21TFJC_ProviderName, AV22TFJC_ProviderName_Sel, AV25TFJC_ProviderShortName, AV26TFJC_ProviderShortName_Sel, AV29TFJC_ProviderAddresss, AV30TFJC_ProviderAddresss_Sel, AV33TFJC_ProviderPhone, AV34TFJC_ProviderPhone_Sel, AV37TFJC_ProviderUser, AV38TFJC_ProviderUser_Sel, AV19ddo_JC_ProviderIDTitleControlIdToReplace, AV23ddo_JC_ProviderNameTitleControlIdToReplace, AV27ddo_JC_ProviderShortNameTitleControlIdToReplace, AV31ddo_JC_ProviderAddresssTitleControlIdToReplace, AV35ddo_JC_ProviderPhoneTitleControlIdToReplace, AV39ddo_JC_ProviderUserTitleControlIdToReplace, AV68Pgmname, AV47IsAuthorized_Update, AV49IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP8I0( )
      {
         /* Before Start, stand alone formulas. */
         AV68Pgmname = "JC_ProviderWW";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E208I2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV40DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vJC_PROVIDERIDTITLEFILTERDATA"), AV16JC_ProviderIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vJC_PROVIDERNAMETITLEFILTERDATA"), AV20JC_ProviderNameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vJC_PROVIDERSHORTNAMETITLEFILTERDATA"), AV24JC_ProviderShortNameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vJC_PROVIDERADDRESSSTITLEFILTERDATA"), AV28JC_ProviderAddresssTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vJC_PROVIDERPHONETITLEFILTERDATA"), AV32JC_ProviderPhoneTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vJC_PROVIDERUSERTITLEFILTERDATA"), AV36JC_ProviderUserTitleFilterData);
            /* Read variables values. */
            AV19ddo_JC_ProviderIDTitleControlIdToReplace = cgiGet( edtavDdo_jc_provideridtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_JC_ProviderIDTitleControlIdToReplace", AV19ddo_JC_ProviderIDTitleControlIdToReplace);
            AV23ddo_JC_ProviderNameTitleControlIdToReplace = cgiGet( edtavDdo_jc_providernametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_JC_ProviderNameTitleControlIdToReplace", AV23ddo_JC_ProviderNameTitleControlIdToReplace);
            AV27ddo_JC_ProviderShortNameTitleControlIdToReplace = cgiGet( edtavDdo_jc_providershortnametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_JC_ProviderShortNameTitleControlIdToReplace", AV27ddo_JC_ProviderShortNameTitleControlIdToReplace);
            AV31ddo_JC_ProviderAddresssTitleControlIdToReplace = cgiGet( edtavDdo_jc_provideraddressstitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_JC_ProviderAddresssTitleControlIdToReplace", AV31ddo_JC_ProviderAddresssTitleControlIdToReplace);
            AV35ddo_JC_ProviderPhoneTitleControlIdToReplace = cgiGet( edtavDdo_jc_providerphonetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_JC_ProviderPhoneTitleControlIdToReplace", AV35ddo_JC_ProviderPhoneTitleControlIdToReplace);
            AV39ddo_JC_ProviderUserTitleControlIdToReplace = cgiGet( edtavDdo_jc_providerusertitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39ddo_JC_ProviderUserTitleControlIdToReplace", AV39ddo_JC_ProviderUserTitleControlIdToReplace);
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
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfjc_providerid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfjc_providerid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFJC_PROVIDERID");
               GX_FocusControl = edtavTfjc_providerid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV17TFJC_ProviderID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFJC_ProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFJC_ProviderID), 18, 0)));
            }
            else
            {
               AV17TFJC_ProviderID = (long)(context.localUtil.CToN( cgiGet( edtavTfjc_providerid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFJC_ProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFJC_ProviderID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfjc_providerid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfjc_providerid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFJC_PROVIDERID_TO");
               GX_FocusControl = edtavTfjc_providerid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV18TFJC_ProviderID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFJC_ProviderID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFJC_ProviderID_To), 18, 0)));
            }
            else
            {
               AV18TFJC_ProviderID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfjc_providerid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFJC_ProviderID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFJC_ProviderID_To), 18, 0)));
            }
            AV21TFJC_ProviderName = cgiGet( edtavTfjc_providername_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFJC_ProviderName", AV21TFJC_ProviderName);
            AV22TFJC_ProviderName_Sel = cgiGet( edtavTfjc_providername_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFJC_ProviderName_Sel", AV22TFJC_ProviderName_Sel);
            AV25TFJC_ProviderShortName = cgiGet( edtavTfjc_providershortname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFJC_ProviderShortName", AV25TFJC_ProviderShortName);
            AV26TFJC_ProviderShortName_Sel = cgiGet( edtavTfjc_providershortname_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFJC_ProviderShortName_Sel", AV26TFJC_ProviderShortName_Sel);
            AV29TFJC_ProviderAddresss = cgiGet( edtavTfjc_provideraddresss_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFJC_ProviderAddresss", AV29TFJC_ProviderAddresss);
            AV30TFJC_ProviderAddresss_Sel = cgiGet( edtavTfjc_provideraddresss_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFJC_ProviderAddresss_Sel", AV30TFJC_ProviderAddresss_Sel);
            AV33TFJC_ProviderPhone = cgiGet( edtavTfjc_providerphone_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TFJC_ProviderPhone", AV33TFJC_ProviderPhone);
            AV34TFJC_ProviderPhone_Sel = cgiGet( edtavTfjc_providerphone_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFJC_ProviderPhone_Sel", AV34TFJC_ProviderPhone_Sel);
            AV37TFJC_ProviderUser = cgiGet( edtavTfjc_provideruser_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37TFJC_ProviderUser", AV37TFJC_ProviderUser);
            AV38TFJC_ProviderUser_Sel = cgiGet( edtavTfjc_provideruser_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38TFJC_ProviderUser_Sel", AV38TFJC_ProviderUser_Sel);
            /* Read saved values. */
            nRC_GXsfl_31 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_31"), ".", ","));
            AV42GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV44GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV43GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_jc_providerid_Caption = cgiGet( "DDO_JC_PROVIDERID_Caption");
            Ddo_jc_providerid_Tooltip = cgiGet( "DDO_JC_PROVIDERID_Tooltip");
            Ddo_jc_providerid_Cls = cgiGet( "DDO_JC_PROVIDERID_Cls");
            Ddo_jc_providerid_Filteredtext_set = cgiGet( "DDO_JC_PROVIDERID_Filteredtext_set");
            Ddo_jc_providerid_Filteredtextto_set = cgiGet( "DDO_JC_PROVIDERID_Filteredtextto_set");
            Ddo_jc_providerid_Dropdownoptionstype = cgiGet( "DDO_JC_PROVIDERID_Dropdownoptionstype");
            Ddo_jc_providerid_Titlecontrolidtoreplace = cgiGet( "DDO_JC_PROVIDERID_Titlecontrolidtoreplace");
            Ddo_jc_providerid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERID_Includesortasc"));
            Ddo_jc_providerid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERID_Includesortdsc"));
            Ddo_jc_providerid_Sortedstatus = cgiGet( "DDO_JC_PROVIDERID_Sortedstatus");
            Ddo_jc_providerid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERID_Includefilter"));
            Ddo_jc_providerid_Filtertype = cgiGet( "DDO_JC_PROVIDERID_Filtertype");
            Ddo_jc_providerid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERID_Filterisrange"));
            Ddo_jc_providerid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERID_Includedatalist"));
            Ddo_jc_providerid_Sortasc = cgiGet( "DDO_JC_PROVIDERID_Sortasc");
            Ddo_jc_providerid_Sortdsc = cgiGet( "DDO_JC_PROVIDERID_Sortdsc");
            Ddo_jc_providerid_Cleanfilter = cgiGet( "DDO_JC_PROVIDERID_Cleanfilter");
            Ddo_jc_providerid_Rangefilterfrom = cgiGet( "DDO_JC_PROVIDERID_Rangefilterfrom");
            Ddo_jc_providerid_Rangefilterto = cgiGet( "DDO_JC_PROVIDERID_Rangefilterto");
            Ddo_jc_providerid_Searchbuttontext = cgiGet( "DDO_JC_PROVIDERID_Searchbuttontext");
            Ddo_jc_providername_Caption = cgiGet( "DDO_JC_PROVIDERNAME_Caption");
            Ddo_jc_providername_Tooltip = cgiGet( "DDO_JC_PROVIDERNAME_Tooltip");
            Ddo_jc_providername_Cls = cgiGet( "DDO_JC_PROVIDERNAME_Cls");
            Ddo_jc_providername_Filteredtext_set = cgiGet( "DDO_JC_PROVIDERNAME_Filteredtext_set");
            Ddo_jc_providername_Selectedvalue_set = cgiGet( "DDO_JC_PROVIDERNAME_Selectedvalue_set");
            Ddo_jc_providername_Dropdownoptionstype = cgiGet( "DDO_JC_PROVIDERNAME_Dropdownoptionstype");
            Ddo_jc_providername_Titlecontrolidtoreplace = cgiGet( "DDO_JC_PROVIDERNAME_Titlecontrolidtoreplace");
            Ddo_jc_providername_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERNAME_Includesortasc"));
            Ddo_jc_providername_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERNAME_Includesortdsc"));
            Ddo_jc_providername_Sortedstatus = cgiGet( "DDO_JC_PROVIDERNAME_Sortedstatus");
            Ddo_jc_providername_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERNAME_Includefilter"));
            Ddo_jc_providername_Filtertype = cgiGet( "DDO_JC_PROVIDERNAME_Filtertype");
            Ddo_jc_providername_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERNAME_Filterisrange"));
            Ddo_jc_providername_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERNAME_Includedatalist"));
            Ddo_jc_providername_Datalisttype = cgiGet( "DDO_JC_PROVIDERNAME_Datalisttype");
            Ddo_jc_providername_Datalistproc = cgiGet( "DDO_JC_PROVIDERNAME_Datalistproc");
            Ddo_jc_providername_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_JC_PROVIDERNAME_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_jc_providername_Sortasc = cgiGet( "DDO_JC_PROVIDERNAME_Sortasc");
            Ddo_jc_providername_Sortdsc = cgiGet( "DDO_JC_PROVIDERNAME_Sortdsc");
            Ddo_jc_providername_Loadingdata = cgiGet( "DDO_JC_PROVIDERNAME_Loadingdata");
            Ddo_jc_providername_Cleanfilter = cgiGet( "DDO_JC_PROVIDERNAME_Cleanfilter");
            Ddo_jc_providername_Noresultsfound = cgiGet( "DDO_JC_PROVIDERNAME_Noresultsfound");
            Ddo_jc_providername_Searchbuttontext = cgiGet( "DDO_JC_PROVIDERNAME_Searchbuttontext");
            Ddo_jc_providershortname_Caption = cgiGet( "DDO_JC_PROVIDERSHORTNAME_Caption");
            Ddo_jc_providershortname_Tooltip = cgiGet( "DDO_JC_PROVIDERSHORTNAME_Tooltip");
            Ddo_jc_providershortname_Cls = cgiGet( "DDO_JC_PROVIDERSHORTNAME_Cls");
            Ddo_jc_providershortname_Filteredtext_set = cgiGet( "DDO_JC_PROVIDERSHORTNAME_Filteredtext_set");
            Ddo_jc_providershortname_Selectedvalue_set = cgiGet( "DDO_JC_PROVIDERSHORTNAME_Selectedvalue_set");
            Ddo_jc_providershortname_Dropdownoptionstype = cgiGet( "DDO_JC_PROVIDERSHORTNAME_Dropdownoptionstype");
            Ddo_jc_providershortname_Titlecontrolidtoreplace = cgiGet( "DDO_JC_PROVIDERSHORTNAME_Titlecontrolidtoreplace");
            Ddo_jc_providershortname_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERSHORTNAME_Includesortasc"));
            Ddo_jc_providershortname_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERSHORTNAME_Includesortdsc"));
            Ddo_jc_providershortname_Sortedstatus = cgiGet( "DDO_JC_PROVIDERSHORTNAME_Sortedstatus");
            Ddo_jc_providershortname_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERSHORTNAME_Includefilter"));
            Ddo_jc_providershortname_Filtertype = cgiGet( "DDO_JC_PROVIDERSHORTNAME_Filtertype");
            Ddo_jc_providershortname_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERSHORTNAME_Filterisrange"));
            Ddo_jc_providershortname_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERSHORTNAME_Includedatalist"));
            Ddo_jc_providershortname_Datalisttype = cgiGet( "DDO_JC_PROVIDERSHORTNAME_Datalisttype");
            Ddo_jc_providershortname_Datalistproc = cgiGet( "DDO_JC_PROVIDERSHORTNAME_Datalistproc");
            Ddo_jc_providershortname_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_JC_PROVIDERSHORTNAME_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_jc_providershortname_Sortasc = cgiGet( "DDO_JC_PROVIDERSHORTNAME_Sortasc");
            Ddo_jc_providershortname_Sortdsc = cgiGet( "DDO_JC_PROVIDERSHORTNAME_Sortdsc");
            Ddo_jc_providershortname_Loadingdata = cgiGet( "DDO_JC_PROVIDERSHORTNAME_Loadingdata");
            Ddo_jc_providershortname_Cleanfilter = cgiGet( "DDO_JC_PROVIDERSHORTNAME_Cleanfilter");
            Ddo_jc_providershortname_Noresultsfound = cgiGet( "DDO_JC_PROVIDERSHORTNAME_Noresultsfound");
            Ddo_jc_providershortname_Searchbuttontext = cgiGet( "DDO_JC_PROVIDERSHORTNAME_Searchbuttontext");
            Ddo_jc_provideraddresss_Caption = cgiGet( "DDO_JC_PROVIDERADDRESSS_Caption");
            Ddo_jc_provideraddresss_Tooltip = cgiGet( "DDO_JC_PROVIDERADDRESSS_Tooltip");
            Ddo_jc_provideraddresss_Cls = cgiGet( "DDO_JC_PROVIDERADDRESSS_Cls");
            Ddo_jc_provideraddresss_Filteredtext_set = cgiGet( "DDO_JC_PROVIDERADDRESSS_Filteredtext_set");
            Ddo_jc_provideraddresss_Selectedvalue_set = cgiGet( "DDO_JC_PROVIDERADDRESSS_Selectedvalue_set");
            Ddo_jc_provideraddresss_Dropdownoptionstype = cgiGet( "DDO_JC_PROVIDERADDRESSS_Dropdownoptionstype");
            Ddo_jc_provideraddresss_Titlecontrolidtoreplace = cgiGet( "DDO_JC_PROVIDERADDRESSS_Titlecontrolidtoreplace");
            Ddo_jc_provideraddresss_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERADDRESSS_Includesortasc"));
            Ddo_jc_provideraddresss_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERADDRESSS_Includesortdsc"));
            Ddo_jc_provideraddresss_Sortedstatus = cgiGet( "DDO_JC_PROVIDERADDRESSS_Sortedstatus");
            Ddo_jc_provideraddresss_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERADDRESSS_Includefilter"));
            Ddo_jc_provideraddresss_Filtertype = cgiGet( "DDO_JC_PROVIDERADDRESSS_Filtertype");
            Ddo_jc_provideraddresss_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERADDRESSS_Filterisrange"));
            Ddo_jc_provideraddresss_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERADDRESSS_Includedatalist"));
            Ddo_jc_provideraddresss_Datalisttype = cgiGet( "DDO_JC_PROVIDERADDRESSS_Datalisttype");
            Ddo_jc_provideraddresss_Datalistproc = cgiGet( "DDO_JC_PROVIDERADDRESSS_Datalistproc");
            Ddo_jc_provideraddresss_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_JC_PROVIDERADDRESSS_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_jc_provideraddresss_Sortasc = cgiGet( "DDO_JC_PROVIDERADDRESSS_Sortasc");
            Ddo_jc_provideraddresss_Sortdsc = cgiGet( "DDO_JC_PROVIDERADDRESSS_Sortdsc");
            Ddo_jc_provideraddresss_Loadingdata = cgiGet( "DDO_JC_PROVIDERADDRESSS_Loadingdata");
            Ddo_jc_provideraddresss_Cleanfilter = cgiGet( "DDO_JC_PROVIDERADDRESSS_Cleanfilter");
            Ddo_jc_provideraddresss_Noresultsfound = cgiGet( "DDO_JC_PROVIDERADDRESSS_Noresultsfound");
            Ddo_jc_provideraddresss_Searchbuttontext = cgiGet( "DDO_JC_PROVIDERADDRESSS_Searchbuttontext");
            Ddo_jc_providerphone_Caption = cgiGet( "DDO_JC_PROVIDERPHONE_Caption");
            Ddo_jc_providerphone_Tooltip = cgiGet( "DDO_JC_PROVIDERPHONE_Tooltip");
            Ddo_jc_providerphone_Cls = cgiGet( "DDO_JC_PROVIDERPHONE_Cls");
            Ddo_jc_providerphone_Filteredtext_set = cgiGet( "DDO_JC_PROVIDERPHONE_Filteredtext_set");
            Ddo_jc_providerphone_Selectedvalue_set = cgiGet( "DDO_JC_PROVIDERPHONE_Selectedvalue_set");
            Ddo_jc_providerphone_Dropdownoptionstype = cgiGet( "DDO_JC_PROVIDERPHONE_Dropdownoptionstype");
            Ddo_jc_providerphone_Titlecontrolidtoreplace = cgiGet( "DDO_JC_PROVIDERPHONE_Titlecontrolidtoreplace");
            Ddo_jc_providerphone_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERPHONE_Includesortasc"));
            Ddo_jc_providerphone_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERPHONE_Includesortdsc"));
            Ddo_jc_providerphone_Sortedstatus = cgiGet( "DDO_JC_PROVIDERPHONE_Sortedstatus");
            Ddo_jc_providerphone_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERPHONE_Includefilter"));
            Ddo_jc_providerphone_Filtertype = cgiGet( "DDO_JC_PROVIDERPHONE_Filtertype");
            Ddo_jc_providerphone_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERPHONE_Filterisrange"));
            Ddo_jc_providerphone_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERPHONE_Includedatalist"));
            Ddo_jc_providerphone_Datalisttype = cgiGet( "DDO_JC_PROVIDERPHONE_Datalisttype");
            Ddo_jc_providerphone_Datalistproc = cgiGet( "DDO_JC_PROVIDERPHONE_Datalistproc");
            Ddo_jc_providerphone_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_JC_PROVIDERPHONE_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_jc_providerphone_Sortasc = cgiGet( "DDO_JC_PROVIDERPHONE_Sortasc");
            Ddo_jc_providerphone_Sortdsc = cgiGet( "DDO_JC_PROVIDERPHONE_Sortdsc");
            Ddo_jc_providerphone_Loadingdata = cgiGet( "DDO_JC_PROVIDERPHONE_Loadingdata");
            Ddo_jc_providerphone_Cleanfilter = cgiGet( "DDO_JC_PROVIDERPHONE_Cleanfilter");
            Ddo_jc_providerphone_Noresultsfound = cgiGet( "DDO_JC_PROVIDERPHONE_Noresultsfound");
            Ddo_jc_providerphone_Searchbuttontext = cgiGet( "DDO_JC_PROVIDERPHONE_Searchbuttontext");
            Ddo_jc_provideruser_Caption = cgiGet( "DDO_JC_PROVIDERUSER_Caption");
            Ddo_jc_provideruser_Tooltip = cgiGet( "DDO_JC_PROVIDERUSER_Tooltip");
            Ddo_jc_provideruser_Cls = cgiGet( "DDO_JC_PROVIDERUSER_Cls");
            Ddo_jc_provideruser_Filteredtext_set = cgiGet( "DDO_JC_PROVIDERUSER_Filteredtext_set");
            Ddo_jc_provideruser_Selectedvalue_set = cgiGet( "DDO_JC_PROVIDERUSER_Selectedvalue_set");
            Ddo_jc_provideruser_Dropdownoptionstype = cgiGet( "DDO_JC_PROVIDERUSER_Dropdownoptionstype");
            Ddo_jc_provideruser_Titlecontrolidtoreplace = cgiGet( "DDO_JC_PROVIDERUSER_Titlecontrolidtoreplace");
            Ddo_jc_provideruser_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERUSER_Includesortasc"));
            Ddo_jc_provideruser_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERUSER_Includesortdsc"));
            Ddo_jc_provideruser_Sortedstatus = cgiGet( "DDO_JC_PROVIDERUSER_Sortedstatus");
            Ddo_jc_provideruser_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERUSER_Includefilter"));
            Ddo_jc_provideruser_Filtertype = cgiGet( "DDO_JC_PROVIDERUSER_Filtertype");
            Ddo_jc_provideruser_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERUSER_Filterisrange"));
            Ddo_jc_provideruser_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_JC_PROVIDERUSER_Includedatalist"));
            Ddo_jc_provideruser_Datalisttype = cgiGet( "DDO_JC_PROVIDERUSER_Datalisttype");
            Ddo_jc_provideruser_Datalistproc = cgiGet( "DDO_JC_PROVIDERUSER_Datalistproc");
            Ddo_jc_provideruser_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_JC_PROVIDERUSER_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_jc_provideruser_Sortasc = cgiGet( "DDO_JC_PROVIDERUSER_Sortasc");
            Ddo_jc_provideruser_Sortdsc = cgiGet( "DDO_JC_PROVIDERUSER_Sortdsc");
            Ddo_jc_provideruser_Loadingdata = cgiGet( "DDO_JC_PROVIDERUSER_Loadingdata");
            Ddo_jc_provideruser_Cleanfilter = cgiGet( "DDO_JC_PROVIDERUSER_Cleanfilter");
            Ddo_jc_provideruser_Noresultsfound = cgiGet( "DDO_JC_PROVIDERUSER_Noresultsfound");
            Ddo_jc_provideruser_Searchbuttontext = cgiGet( "DDO_JC_PROVIDERUSER_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_jc_providerid_Activeeventkey = cgiGet( "DDO_JC_PROVIDERID_Activeeventkey");
            Ddo_jc_providerid_Filteredtext_get = cgiGet( "DDO_JC_PROVIDERID_Filteredtext_get");
            Ddo_jc_providerid_Filteredtextto_get = cgiGet( "DDO_JC_PROVIDERID_Filteredtextto_get");
            Ddo_jc_providername_Activeeventkey = cgiGet( "DDO_JC_PROVIDERNAME_Activeeventkey");
            Ddo_jc_providername_Filteredtext_get = cgiGet( "DDO_JC_PROVIDERNAME_Filteredtext_get");
            Ddo_jc_providername_Selectedvalue_get = cgiGet( "DDO_JC_PROVIDERNAME_Selectedvalue_get");
            Ddo_jc_providershortname_Activeeventkey = cgiGet( "DDO_JC_PROVIDERSHORTNAME_Activeeventkey");
            Ddo_jc_providershortname_Filteredtext_get = cgiGet( "DDO_JC_PROVIDERSHORTNAME_Filteredtext_get");
            Ddo_jc_providershortname_Selectedvalue_get = cgiGet( "DDO_JC_PROVIDERSHORTNAME_Selectedvalue_get");
            Ddo_jc_provideraddresss_Activeeventkey = cgiGet( "DDO_JC_PROVIDERADDRESSS_Activeeventkey");
            Ddo_jc_provideraddresss_Filteredtext_get = cgiGet( "DDO_JC_PROVIDERADDRESSS_Filteredtext_get");
            Ddo_jc_provideraddresss_Selectedvalue_get = cgiGet( "DDO_JC_PROVIDERADDRESSS_Selectedvalue_get");
            Ddo_jc_providerphone_Activeeventkey = cgiGet( "DDO_JC_PROVIDERPHONE_Activeeventkey");
            Ddo_jc_providerphone_Filteredtext_get = cgiGet( "DDO_JC_PROVIDERPHONE_Filteredtext_get");
            Ddo_jc_providerphone_Selectedvalue_get = cgiGet( "DDO_JC_PROVIDERPHONE_Selectedvalue_get");
            Ddo_jc_provideruser_Activeeventkey = cgiGet( "DDO_JC_PROVIDERUSER_Activeeventkey");
            Ddo_jc_provideruser_Filteredtext_get = cgiGet( "DDO_JC_PROVIDERUSER_Filteredtext_get");
            Ddo_jc_provideruser_Selectedvalue_get = cgiGet( "DDO_JC_PROVIDERUSER_Selectedvalue_get");
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
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFJC_PROVIDERID"), ".", ",") != Convert.ToDecimal( AV17TFJC_ProviderID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFJC_PROVIDERID_TO"), ".", ",") != Convert.ToDecimal( AV18TFJC_ProviderID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFJC_PROVIDERNAME"), AV21TFJC_ProviderName) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFJC_PROVIDERNAME_SEL"), AV22TFJC_ProviderName_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFJC_PROVIDERSHORTNAME"), AV25TFJC_ProviderShortName) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFJC_PROVIDERSHORTNAME_SEL"), AV26TFJC_ProviderShortName_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFJC_PROVIDERADDRESSS"), AV29TFJC_ProviderAddresss) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFJC_PROVIDERADDRESSS_SEL"), AV30TFJC_ProviderAddresss_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFJC_PROVIDERPHONE"), AV33TFJC_ProviderPhone) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFJC_PROVIDERPHONE_SEL"), AV34TFJC_ProviderPhone_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFJC_PROVIDERUSER"), AV37TFJC_ProviderUser) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFJC_PROVIDERUSER_SEL"), AV38TFJC_ProviderUser_Sel) != 0 )
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
         E208I2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E208I2( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         edtavTfjc_providerid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfjc_providerid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfjc_providerid_Visible), 5, 0)), true);
         edtavTfjc_providerid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfjc_providerid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfjc_providerid_to_Visible), 5, 0)), true);
         edtavTfjc_providername_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfjc_providername_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfjc_providername_Visible), 5, 0)), true);
         edtavTfjc_providername_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfjc_providername_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfjc_providername_sel_Visible), 5, 0)), true);
         edtavTfjc_providershortname_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfjc_providershortname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfjc_providershortname_Visible), 5, 0)), true);
         edtavTfjc_providershortname_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfjc_providershortname_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfjc_providershortname_sel_Visible), 5, 0)), true);
         edtavTfjc_provideraddresss_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfjc_provideraddresss_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfjc_provideraddresss_Visible), 5, 0)), true);
         edtavTfjc_provideraddresss_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfjc_provideraddresss_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfjc_provideraddresss_sel_Visible), 5, 0)), true);
         edtavTfjc_providerphone_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfjc_providerphone_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfjc_providerphone_Visible), 5, 0)), true);
         edtavTfjc_providerphone_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfjc_providerphone_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfjc_providerphone_sel_Visible), 5, 0)), true);
         edtavTfjc_provideruser_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfjc_provideruser_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfjc_provideruser_Visible), 5, 0)), true);
         edtavTfjc_provideruser_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfjc_provideruser_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfjc_provideruser_sel_Visible), 5, 0)), true);
         Ddo_jc_providerid_Titlecontrolidtoreplace = subGrid_Internalname+"_JC_ProviderID";
         ucDdo_jc_providerid.SendProperty(context, "", false, Ddo_jc_providerid_Internalname, "TitleControlIdToReplace", Ddo_jc_providerid_Titlecontrolidtoreplace);
         AV19ddo_JC_ProviderIDTitleControlIdToReplace = Ddo_jc_providerid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_JC_ProviderIDTitleControlIdToReplace", AV19ddo_JC_ProviderIDTitleControlIdToReplace);
         edtavDdo_jc_provideridtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_jc_provideridtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_jc_provideridtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_jc_providername_Titlecontrolidtoreplace = subGrid_Internalname+"_JC_ProviderName";
         ucDdo_jc_providername.SendProperty(context, "", false, Ddo_jc_providername_Internalname, "TitleControlIdToReplace", Ddo_jc_providername_Titlecontrolidtoreplace);
         AV23ddo_JC_ProviderNameTitleControlIdToReplace = Ddo_jc_providername_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_JC_ProviderNameTitleControlIdToReplace", AV23ddo_JC_ProviderNameTitleControlIdToReplace);
         edtavDdo_jc_providernametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_jc_providernametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_jc_providernametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_jc_providershortname_Titlecontrolidtoreplace = subGrid_Internalname+"_JC_ProviderShortName";
         ucDdo_jc_providershortname.SendProperty(context, "", false, Ddo_jc_providershortname_Internalname, "TitleControlIdToReplace", Ddo_jc_providershortname_Titlecontrolidtoreplace);
         AV27ddo_JC_ProviderShortNameTitleControlIdToReplace = Ddo_jc_providershortname_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_JC_ProviderShortNameTitleControlIdToReplace", AV27ddo_JC_ProviderShortNameTitleControlIdToReplace);
         edtavDdo_jc_providershortnametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_jc_providershortnametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_jc_providershortnametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_jc_provideraddresss_Titlecontrolidtoreplace = subGrid_Internalname+"_JC_ProviderAddresss";
         ucDdo_jc_provideraddresss.SendProperty(context, "", false, Ddo_jc_provideraddresss_Internalname, "TitleControlIdToReplace", Ddo_jc_provideraddresss_Titlecontrolidtoreplace);
         AV31ddo_JC_ProviderAddresssTitleControlIdToReplace = Ddo_jc_provideraddresss_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_JC_ProviderAddresssTitleControlIdToReplace", AV31ddo_JC_ProviderAddresssTitleControlIdToReplace);
         edtavDdo_jc_provideraddressstitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_jc_provideraddressstitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_jc_provideraddressstitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_jc_providerphone_Titlecontrolidtoreplace = subGrid_Internalname+"_JC_ProviderPhone";
         ucDdo_jc_providerphone.SendProperty(context, "", false, Ddo_jc_providerphone_Internalname, "TitleControlIdToReplace", Ddo_jc_providerphone_Titlecontrolidtoreplace);
         AV35ddo_JC_ProviderPhoneTitleControlIdToReplace = Ddo_jc_providerphone_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_JC_ProviderPhoneTitleControlIdToReplace", AV35ddo_JC_ProviderPhoneTitleControlIdToReplace);
         edtavDdo_jc_providerphonetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_jc_providerphonetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_jc_providerphonetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_jc_provideruser_Titlecontrolidtoreplace = subGrid_Internalname+"_JC_ProviderUser";
         ucDdo_jc_provideruser.SendProperty(context, "", false, Ddo_jc_provideruser_Internalname, "TitleControlIdToReplace", Ddo_jc_provideruser_Titlecontrolidtoreplace);
         AV39ddo_JC_ProviderUserTitleControlIdToReplace = Ddo_jc_provideruser_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39ddo_JC_ProviderUserTitleControlIdToReplace", AV39ddo_JC_ProviderUserTitleControlIdToReplace);
         edtavDdo_jc_providerusertitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_jc_providerusertitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_jc_providerusertitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " 医院";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV40DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV40DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E218I2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV16JC_ProviderIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20JC_ProviderNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24JC_ProviderShortNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28JC_ProviderAddresssTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32JC_ProviderPhoneTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV36JC_ProviderUserTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
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
         edtJC_ProviderID_Titleformat = 2;
         edtJC_ProviderID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊医院", AV19ddo_JC_ProviderIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtJC_ProviderID_Internalname, "Title", edtJC_ProviderID_Title, !bGXsfl_31_Refreshing);
         edtJC_ProviderName_Titleformat = 2;
         edtJC_ProviderName_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "医院名称", AV23ddo_JC_ProviderNameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtJC_ProviderName_Internalname, "Title", edtJC_ProviderName_Title, !bGXsfl_31_Refreshing);
         edtJC_ProviderShortName_Titleformat = 2;
         edtJC_ProviderShortName_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "医院缩写", AV27ddo_JC_ProviderShortNameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtJC_ProviderShortName_Internalname, "Title", edtJC_ProviderShortName_Title, !bGXsfl_31_Refreshing);
         edtJC_ProviderAddresss_Titleformat = 2;
         edtJC_ProviderAddresss_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "医院地址", AV31ddo_JC_ProviderAddresssTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtJC_ProviderAddresss_Internalname, "Title", edtJC_ProviderAddresss_Title, !bGXsfl_31_Refreshing);
         edtJC_ProviderPhone_Titleformat = 2;
         edtJC_ProviderPhone_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "医院联系人电话", AV35ddo_JC_ProviderPhoneTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtJC_ProviderPhone_Internalname, "Title", edtJC_ProviderPhone_Title, !bGXsfl_31_Refreshing);
         edtJC_ProviderUser_Titleformat = 2;
         edtJC_ProviderUser_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "医院联系人", AV39ddo_JC_ProviderUserTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtJC_ProviderUser_Internalname, "Title", edtJC_ProviderUser_Title, !bGXsfl_31_Refreshing);
         AV42GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42GridCurrentPage), 10, 0)));
         AV43GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV43GridPageSize), 10, 0)));
         AV44GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV44GridRecordCount), 10, 0)));
         AV53JC_ProviderWWDS_1_Tfjc_providerid = AV17TFJC_ProviderID;
         AV54JC_ProviderWWDS_2_Tfjc_providerid_to = AV18TFJC_ProviderID_To;
         AV55JC_ProviderWWDS_3_Tfjc_providername = AV21TFJC_ProviderName;
         AV56JC_ProviderWWDS_4_Tfjc_providername_sel = AV22TFJC_ProviderName_Sel;
         AV57JC_ProviderWWDS_5_Tfjc_providershortname = AV25TFJC_ProviderShortName;
         AV58JC_ProviderWWDS_6_Tfjc_providershortname_sel = AV26TFJC_ProviderShortName_Sel;
         AV59JC_ProviderWWDS_7_Tfjc_provideraddresss = AV29TFJC_ProviderAddresss;
         AV60JC_ProviderWWDS_8_Tfjc_provideraddresss_sel = AV30TFJC_ProviderAddresss_Sel;
         AV61JC_ProviderWWDS_9_Tfjc_providerphone = AV33TFJC_ProviderPhone;
         AV62JC_ProviderWWDS_10_Tfjc_providerphone_sel = AV34TFJC_ProviderPhone_Sel;
         AV63JC_ProviderWWDS_11_Tfjc_provideruser = AV37TFJC_ProviderUser;
         AV64JC_ProviderWWDS_12_Tfjc_provideruser_sel = AV38TFJC_ProviderUser_Sel;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16JC_ProviderIDTitleFilterData", AV16JC_ProviderIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20JC_ProviderNameTitleFilterData", AV20JC_ProviderNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24JC_ProviderShortNameTitleFilterData", AV24JC_ProviderShortNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28JC_ProviderAddresssTitleFilterData", AV28JC_ProviderAddresssTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32JC_ProviderPhoneTitleFilterData", AV32JC_ProviderPhoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36JC_ProviderUserTitleFilterData", AV36JC_ProviderUserTitleFilterData);
      }

      protected void E118I2( )
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
            AV41PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV41PageToGo) ;
         }
      }

      protected void E128I2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E138I2( )
      {
         /* Ddo_jc_providerid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_jc_providerid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_jc_providerid_Sortedstatus = "ASC";
            ucDdo_jc_providerid.SendProperty(context, "", false, Ddo_jc_providerid_Internalname, "SortedStatus", Ddo_jc_providerid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_jc_providerid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_jc_providerid_Sortedstatus = "DSC";
            ucDdo_jc_providerid.SendProperty(context, "", false, Ddo_jc_providerid_Internalname, "SortedStatus", Ddo_jc_providerid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_jc_providerid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV17TFJC_ProviderID = (long)(NumberUtil.Val( Ddo_jc_providerid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFJC_ProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFJC_ProviderID), 18, 0)));
            AV18TFJC_ProviderID_To = (long)(NumberUtil.Val( Ddo_jc_providerid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFJC_ProviderID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFJC_ProviderID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16JC_ProviderIDTitleFilterData", AV16JC_ProviderIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20JC_ProviderNameTitleFilterData", AV20JC_ProviderNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24JC_ProviderShortNameTitleFilterData", AV24JC_ProviderShortNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28JC_ProviderAddresssTitleFilterData", AV28JC_ProviderAddresssTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32JC_ProviderPhoneTitleFilterData", AV32JC_ProviderPhoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36JC_ProviderUserTitleFilterData", AV36JC_ProviderUserTitleFilterData);
      }

      protected void E148I2( )
      {
         /* Ddo_jc_providername_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_jc_providername_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_jc_providername_Sortedstatus = "ASC";
            ucDdo_jc_providername.SendProperty(context, "", false, Ddo_jc_providername_Internalname, "SortedStatus", Ddo_jc_providername_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_jc_providername_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_jc_providername_Sortedstatus = "DSC";
            ucDdo_jc_providername.SendProperty(context, "", false, Ddo_jc_providername_Internalname, "SortedStatus", Ddo_jc_providername_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_jc_providername_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV21TFJC_ProviderName = Ddo_jc_providername_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFJC_ProviderName", AV21TFJC_ProviderName);
            AV22TFJC_ProviderName_Sel = Ddo_jc_providername_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFJC_ProviderName_Sel", AV22TFJC_ProviderName_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16JC_ProviderIDTitleFilterData", AV16JC_ProviderIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20JC_ProviderNameTitleFilterData", AV20JC_ProviderNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24JC_ProviderShortNameTitleFilterData", AV24JC_ProviderShortNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28JC_ProviderAddresssTitleFilterData", AV28JC_ProviderAddresssTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32JC_ProviderPhoneTitleFilterData", AV32JC_ProviderPhoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36JC_ProviderUserTitleFilterData", AV36JC_ProviderUserTitleFilterData);
      }

      protected void E158I2( )
      {
         /* Ddo_jc_providershortname_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_jc_providershortname_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_jc_providershortname_Sortedstatus = "ASC";
            ucDdo_jc_providershortname.SendProperty(context, "", false, Ddo_jc_providershortname_Internalname, "SortedStatus", Ddo_jc_providershortname_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_jc_providershortname_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_jc_providershortname_Sortedstatus = "DSC";
            ucDdo_jc_providershortname.SendProperty(context, "", false, Ddo_jc_providershortname_Internalname, "SortedStatus", Ddo_jc_providershortname_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_jc_providershortname_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV25TFJC_ProviderShortName = Ddo_jc_providershortname_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFJC_ProviderShortName", AV25TFJC_ProviderShortName);
            AV26TFJC_ProviderShortName_Sel = Ddo_jc_providershortname_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFJC_ProviderShortName_Sel", AV26TFJC_ProviderShortName_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16JC_ProviderIDTitleFilterData", AV16JC_ProviderIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20JC_ProviderNameTitleFilterData", AV20JC_ProviderNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24JC_ProviderShortNameTitleFilterData", AV24JC_ProviderShortNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28JC_ProviderAddresssTitleFilterData", AV28JC_ProviderAddresssTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32JC_ProviderPhoneTitleFilterData", AV32JC_ProviderPhoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36JC_ProviderUserTitleFilterData", AV36JC_ProviderUserTitleFilterData);
      }

      protected void E168I2( )
      {
         /* Ddo_jc_provideraddresss_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_jc_provideraddresss_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_jc_provideraddresss_Sortedstatus = "ASC";
            ucDdo_jc_provideraddresss.SendProperty(context, "", false, Ddo_jc_provideraddresss_Internalname, "SortedStatus", Ddo_jc_provideraddresss_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_jc_provideraddresss_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_jc_provideraddresss_Sortedstatus = "DSC";
            ucDdo_jc_provideraddresss.SendProperty(context, "", false, Ddo_jc_provideraddresss_Internalname, "SortedStatus", Ddo_jc_provideraddresss_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_jc_provideraddresss_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV29TFJC_ProviderAddresss = Ddo_jc_provideraddresss_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFJC_ProviderAddresss", AV29TFJC_ProviderAddresss);
            AV30TFJC_ProviderAddresss_Sel = Ddo_jc_provideraddresss_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFJC_ProviderAddresss_Sel", AV30TFJC_ProviderAddresss_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16JC_ProviderIDTitleFilterData", AV16JC_ProviderIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20JC_ProviderNameTitleFilterData", AV20JC_ProviderNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24JC_ProviderShortNameTitleFilterData", AV24JC_ProviderShortNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28JC_ProviderAddresssTitleFilterData", AV28JC_ProviderAddresssTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32JC_ProviderPhoneTitleFilterData", AV32JC_ProviderPhoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36JC_ProviderUserTitleFilterData", AV36JC_ProviderUserTitleFilterData);
      }

      protected void E178I2( )
      {
         /* Ddo_jc_providerphone_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_jc_providerphone_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_jc_providerphone_Sortedstatus = "ASC";
            ucDdo_jc_providerphone.SendProperty(context, "", false, Ddo_jc_providerphone_Internalname, "SortedStatus", Ddo_jc_providerphone_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_jc_providerphone_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_jc_providerphone_Sortedstatus = "DSC";
            ucDdo_jc_providerphone.SendProperty(context, "", false, Ddo_jc_providerphone_Internalname, "SortedStatus", Ddo_jc_providerphone_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_jc_providerphone_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV33TFJC_ProviderPhone = Ddo_jc_providerphone_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TFJC_ProviderPhone", AV33TFJC_ProviderPhone);
            AV34TFJC_ProviderPhone_Sel = Ddo_jc_providerphone_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFJC_ProviderPhone_Sel", AV34TFJC_ProviderPhone_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16JC_ProviderIDTitleFilterData", AV16JC_ProviderIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20JC_ProviderNameTitleFilterData", AV20JC_ProviderNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24JC_ProviderShortNameTitleFilterData", AV24JC_ProviderShortNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28JC_ProviderAddresssTitleFilterData", AV28JC_ProviderAddresssTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32JC_ProviderPhoneTitleFilterData", AV32JC_ProviderPhoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36JC_ProviderUserTitleFilterData", AV36JC_ProviderUserTitleFilterData);
      }

      protected void E188I2( )
      {
         /* Ddo_jc_provideruser_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_jc_provideruser_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_jc_provideruser_Sortedstatus = "ASC";
            ucDdo_jc_provideruser.SendProperty(context, "", false, Ddo_jc_provideruser_Internalname, "SortedStatus", Ddo_jc_provideruser_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_jc_provideruser_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_jc_provideruser_Sortedstatus = "DSC";
            ucDdo_jc_provideruser.SendProperty(context, "", false, Ddo_jc_provideruser_Internalname, "SortedStatus", Ddo_jc_provideruser_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_jc_provideruser_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV37TFJC_ProviderUser = Ddo_jc_provideruser_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37TFJC_ProviderUser", AV37TFJC_ProviderUser);
            AV38TFJC_ProviderUser_Sel = Ddo_jc_provideruser_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38TFJC_ProviderUser_Sel", AV38TFJC_ProviderUser_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16JC_ProviderIDTitleFilterData", AV16JC_ProviderIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20JC_ProviderNameTitleFilterData", AV20JC_ProviderNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24JC_ProviderShortNameTitleFilterData", AV24JC_ProviderShortNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28JC_ProviderAddresssTitleFilterData", AV28JC_ProviderAddresssTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32JC_ProviderPhoneTitleFilterData", AV32JC_ProviderPhoneTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36JC_ProviderUserTitleFilterData", AV36JC_ProviderUserTitleFilterData);
      }

      private void E228I2( )
      {
         /* Grid_Load Routine */
         AV45Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDisplay_Internalname, AV45Display);
         AV65Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = formatLink("jc_providerview.aspx") + "?" + UrlEncode("" +A87JC_ProviderID) + "," + UrlEncode(StringUtil.RTrim(""));
         AV46Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV46Update);
         AV66Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavUpdate_Tooltiptext = "修改";
         if ( AV47IsAuthorized_Update )
         {
            edtavUpdate_Link = formatLink("jc_provider.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A87JC_ProviderID);
         }
         AV48Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV48Delete);
         AV67Delete_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavDelete_Tooltiptext = "删除";
         if ( AV49IsAuthorized_Delete )
         {
            edtavDelete_Link = formatLink("jc_provider.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A87JC_ProviderID);
         }
         edtJC_ProviderName_Link = formatLink("jc_providerview.aspx") + "?" + UrlEncode("" +A87JC_ProviderID) + "," + UrlEncode(StringUtil.RTrim(""));
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 31;
         }
         sendrow_312( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_31_Refreshing )
         {
            context.DoAjaxLoad(31, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void E198I2( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("jc_provider.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S162( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_jc_providerid_Sortedstatus = "";
         ucDdo_jc_providerid.SendProperty(context, "", false, Ddo_jc_providerid_Internalname, "SortedStatus", Ddo_jc_providerid_Sortedstatus);
         Ddo_jc_providername_Sortedstatus = "";
         ucDdo_jc_providername.SendProperty(context, "", false, Ddo_jc_providername_Internalname, "SortedStatus", Ddo_jc_providername_Sortedstatus);
         Ddo_jc_providershortname_Sortedstatus = "";
         ucDdo_jc_providershortname.SendProperty(context, "", false, Ddo_jc_providershortname_Internalname, "SortedStatus", Ddo_jc_providershortname_Sortedstatus);
         Ddo_jc_provideraddresss_Sortedstatus = "";
         ucDdo_jc_provideraddresss.SendProperty(context, "", false, Ddo_jc_provideraddresss_Internalname, "SortedStatus", Ddo_jc_provideraddresss_Sortedstatus);
         Ddo_jc_providerphone_Sortedstatus = "";
         ucDdo_jc_providerphone.SendProperty(context, "", false, Ddo_jc_providerphone_Internalname, "SortedStatus", Ddo_jc_providerphone_Sortedstatus);
         Ddo_jc_provideruser_Sortedstatus = "";
         ucDdo_jc_provideruser.SendProperty(context, "", false, Ddo_jc_provideruser_Internalname, "SortedStatus", Ddo_jc_provideruser_Sortedstatus);
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
            Ddo_jc_providerid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_jc_providerid.SendProperty(context, "", false, Ddo_jc_providerid_Internalname, "SortedStatus", Ddo_jc_providerid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 2 )
         {
            Ddo_jc_providername_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_jc_providername.SendProperty(context, "", false, Ddo_jc_providername_Internalname, "SortedStatus", Ddo_jc_providername_Sortedstatus);
         }
         else if ( AV13OrderedBy == 3 )
         {
            Ddo_jc_providershortname_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_jc_providershortname.SendProperty(context, "", false, Ddo_jc_providershortname_Internalname, "SortedStatus", Ddo_jc_providershortname_Sortedstatus);
         }
         else if ( AV13OrderedBy == 4 )
         {
            Ddo_jc_provideraddresss_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_jc_provideraddresss.SendProperty(context, "", false, Ddo_jc_provideraddresss_Internalname, "SortedStatus", Ddo_jc_provideraddresss_Sortedstatus);
         }
         else if ( AV13OrderedBy == 5 )
         {
            Ddo_jc_providerphone_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_jc_providerphone.SendProperty(context, "", false, Ddo_jc_providerphone_Internalname, "SortedStatus", Ddo_jc_providerphone_Sortedstatus);
         }
         else if ( AV13OrderedBy == 6 )
         {
            Ddo_jc_provideruser_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_jc_provideruser.SendProperty(context, "", false, Ddo_jc_provideruser_Internalname, "SortedStatus", Ddo_jc_provideruser_Sortedstatus);
         }
      }

      protected void S142( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean2 = AV47IsAuthorized_Update;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWJC_Provider_Update", out  GXt_boolean2) ;
         AV47IsAuthorized_Update = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47IsAuthorized_Update", AV47IsAuthorized_Update);
         if ( ! ( AV47IsAuthorized_Update ) )
         {
            edtavUpdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_31_Refreshing);
         }
         GXt_boolean2 = AV49IsAuthorized_Delete;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWJC_Provider_Delete", out  GXt_boolean2) ;
         AV49IsAuthorized_Delete = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49IsAuthorized_Delete", AV49IsAuthorized_Delete);
         if ( ! ( AV49IsAuthorized_Delete ) )
         {
            edtavDelete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Visible), 5, 0)), !bGXsfl_31_Refreshing);
         }
         GXt_boolean2 = AV50TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWJC_Provider_Insert", out  GXt_boolean2) ;
         AV50TempBoolean = GXt_boolean2;
         if ( ! ( AV50TempBoolean ) )
         {
            bttBtninsert_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtninsert_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtninsert_Visible), 5, 0)), true);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV15Session.Get(AV68Pgmname+"GridState"), "") == 0 )
         {
            AV11GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV68Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV11GridState.FromXml(AV15Session.Get(AV68Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
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
         AV69GXV1 = 1;
         while ( AV69GXV1 <= AV11GridState.gxTpr_Filtervalues.Count )
         {
            AV12GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV11GridState.gxTpr_Filtervalues.Item(AV69GXV1));
            if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFJC_PROVIDERID") == 0 )
            {
               AV17TFJC_ProviderID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFJC_ProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFJC_ProviderID), 18, 0)));
               AV18TFJC_ProviderID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFJC_ProviderID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFJC_ProviderID_To), 18, 0)));
               if ( ! (0==AV17TFJC_ProviderID) )
               {
                  Ddo_jc_providerid_Filteredtext_set = StringUtil.Str( (decimal)(AV17TFJC_ProviderID), 18, 0);
                  ucDdo_jc_providerid.SendProperty(context, "", false, Ddo_jc_providerid_Internalname, "FilteredText_set", Ddo_jc_providerid_Filteredtext_set);
               }
               if ( ! (0==AV18TFJC_ProviderID_To) )
               {
                  Ddo_jc_providerid_Filteredtextto_set = StringUtil.Str( (decimal)(AV18TFJC_ProviderID_To), 18, 0);
                  ucDdo_jc_providerid.SendProperty(context, "", false, Ddo_jc_providerid_Internalname, "FilteredTextTo_set", Ddo_jc_providerid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFJC_PROVIDERNAME") == 0 )
            {
               AV21TFJC_ProviderName = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFJC_ProviderName", AV21TFJC_ProviderName);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV21TFJC_ProviderName)) )
               {
                  Ddo_jc_providername_Filteredtext_set = AV21TFJC_ProviderName;
                  ucDdo_jc_providername.SendProperty(context, "", false, Ddo_jc_providername_Internalname, "FilteredText_set", Ddo_jc_providername_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFJC_PROVIDERNAME_SEL") == 0 )
            {
               AV22TFJC_ProviderName_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFJC_ProviderName_Sel", AV22TFJC_ProviderName_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV22TFJC_ProviderName_Sel)) )
               {
                  Ddo_jc_providername_Selectedvalue_set = AV22TFJC_ProviderName_Sel;
                  ucDdo_jc_providername.SendProperty(context, "", false, Ddo_jc_providername_Internalname, "SelectedValue_set", Ddo_jc_providername_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFJC_PROVIDERSHORTNAME") == 0 )
            {
               AV25TFJC_ProviderShortName = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFJC_ProviderShortName", AV25TFJC_ProviderShortName);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV25TFJC_ProviderShortName)) )
               {
                  Ddo_jc_providershortname_Filteredtext_set = AV25TFJC_ProviderShortName;
                  ucDdo_jc_providershortname.SendProperty(context, "", false, Ddo_jc_providershortname_Internalname, "FilteredText_set", Ddo_jc_providershortname_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFJC_PROVIDERSHORTNAME_SEL") == 0 )
            {
               AV26TFJC_ProviderShortName_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFJC_ProviderShortName_Sel", AV26TFJC_ProviderShortName_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26TFJC_ProviderShortName_Sel)) )
               {
                  Ddo_jc_providershortname_Selectedvalue_set = AV26TFJC_ProviderShortName_Sel;
                  ucDdo_jc_providershortname.SendProperty(context, "", false, Ddo_jc_providershortname_Internalname, "SelectedValue_set", Ddo_jc_providershortname_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFJC_PROVIDERADDRESSS") == 0 )
            {
               AV29TFJC_ProviderAddresss = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFJC_ProviderAddresss", AV29TFJC_ProviderAddresss);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV29TFJC_ProviderAddresss)) )
               {
                  Ddo_jc_provideraddresss_Filteredtext_set = AV29TFJC_ProviderAddresss;
                  ucDdo_jc_provideraddresss.SendProperty(context, "", false, Ddo_jc_provideraddresss_Internalname, "FilteredText_set", Ddo_jc_provideraddresss_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFJC_PROVIDERADDRESSS_SEL") == 0 )
            {
               AV30TFJC_ProviderAddresss_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFJC_ProviderAddresss_Sel", AV30TFJC_ProviderAddresss_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV30TFJC_ProviderAddresss_Sel)) )
               {
                  Ddo_jc_provideraddresss_Selectedvalue_set = AV30TFJC_ProviderAddresss_Sel;
                  ucDdo_jc_provideraddresss.SendProperty(context, "", false, Ddo_jc_provideraddresss_Internalname, "SelectedValue_set", Ddo_jc_provideraddresss_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFJC_PROVIDERPHONE") == 0 )
            {
               AV33TFJC_ProviderPhone = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TFJC_ProviderPhone", AV33TFJC_ProviderPhone);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV33TFJC_ProviderPhone)) )
               {
                  Ddo_jc_providerphone_Filteredtext_set = AV33TFJC_ProviderPhone;
                  ucDdo_jc_providerphone.SendProperty(context, "", false, Ddo_jc_providerphone_Internalname, "FilteredText_set", Ddo_jc_providerphone_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFJC_PROVIDERPHONE_SEL") == 0 )
            {
               AV34TFJC_ProviderPhone_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFJC_ProviderPhone_Sel", AV34TFJC_ProviderPhone_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV34TFJC_ProviderPhone_Sel)) )
               {
                  Ddo_jc_providerphone_Selectedvalue_set = AV34TFJC_ProviderPhone_Sel;
                  ucDdo_jc_providerphone.SendProperty(context, "", false, Ddo_jc_providerphone_Internalname, "SelectedValue_set", Ddo_jc_providerphone_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFJC_PROVIDERUSER") == 0 )
            {
               AV37TFJC_ProviderUser = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37TFJC_ProviderUser", AV37TFJC_ProviderUser);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV37TFJC_ProviderUser)) )
               {
                  Ddo_jc_provideruser_Filteredtext_set = AV37TFJC_ProviderUser;
                  ucDdo_jc_provideruser.SendProperty(context, "", false, Ddo_jc_provideruser_Internalname, "FilteredText_set", Ddo_jc_provideruser_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFJC_PROVIDERUSER_SEL") == 0 )
            {
               AV38TFJC_ProviderUser_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38TFJC_ProviderUser_Sel", AV38TFJC_ProviderUser_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV38TFJC_ProviderUser_Sel)) )
               {
                  Ddo_jc_provideruser_Selectedvalue_set = AV38TFJC_ProviderUser_Sel;
                  ucDdo_jc_provideruser.SendProperty(context, "", false, Ddo_jc_provideruser_Internalname, "SelectedValue_set", Ddo_jc_provideruser_Selectedvalue_set);
               }
            }
            AV69GXV1 = (int)(AV69GXV1+1);
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
         AV11GridState.FromXml(AV15Session.Get(AV68Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV11GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV11GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV11GridState.gxTpr_Filtervalues.Clear();
         if ( ! ( (0==AV17TFJC_ProviderID) && (0==AV18TFJC_ProviderID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFJC_PROVIDERID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV17TFJC_ProviderID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV18TFJC_ProviderID_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV21TFJC_ProviderName)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFJC_PROVIDERNAME";
            AV12GridStateFilterValue.gxTpr_Value = AV21TFJC_ProviderName;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV22TFJC_ProviderName_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFJC_PROVIDERNAME_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV22TFJC_ProviderName_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV25TFJC_ProviderShortName)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFJC_PROVIDERSHORTNAME";
            AV12GridStateFilterValue.gxTpr_Value = AV25TFJC_ProviderShortName;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26TFJC_ProviderShortName_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFJC_PROVIDERSHORTNAME_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV26TFJC_ProviderShortName_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV29TFJC_ProviderAddresss)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFJC_PROVIDERADDRESSS";
            AV12GridStateFilterValue.gxTpr_Value = AV29TFJC_ProviderAddresss;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV30TFJC_ProviderAddresss_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFJC_PROVIDERADDRESSS_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV30TFJC_ProviderAddresss_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV33TFJC_ProviderPhone)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFJC_PROVIDERPHONE";
            AV12GridStateFilterValue.gxTpr_Value = AV33TFJC_ProviderPhone;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV34TFJC_ProviderPhone_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFJC_PROVIDERPHONE_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV34TFJC_ProviderPhone_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV37TFJC_ProviderUser)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFJC_PROVIDERUSER";
            AV12GridStateFilterValue.gxTpr_Value = AV37TFJC_ProviderUser;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV38TFJC_ProviderUser_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFJC_PROVIDERUSER_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV38TFJC_ProviderUser_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         AV11GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV11GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV68Pgmname+"GridState",  AV11GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV68Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "JC_Provider";
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
         PA8I2( ) ;
         WS8I2( ) ;
         WE8I2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202281517075", true);
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
         context.AddJavascriptSource("jc_providerww.js", "?20202281517076", false);
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
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_312( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_31_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_31_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_31_idx;
         edtJC_ProviderID_Internalname = "JC_PROVIDERID_"+sGXsfl_31_idx;
         edtJC_ProviderName_Internalname = "JC_PROVIDERNAME_"+sGXsfl_31_idx;
         edtJC_ProviderShortName_Internalname = "JC_PROVIDERSHORTNAME_"+sGXsfl_31_idx;
         edtJC_ProviderAddresss_Internalname = "JC_PROVIDERADDRESSS_"+sGXsfl_31_idx;
         edtJC_ProviderPhone_Internalname = "JC_PROVIDERPHONE_"+sGXsfl_31_idx;
         edtJC_ProviderUser_Internalname = "JC_PROVIDERUSER_"+sGXsfl_31_idx;
      }

      protected void SubsflControlProps_fel_312( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_31_fel_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_31_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_31_fel_idx;
         edtJC_ProviderID_Internalname = "JC_PROVIDERID_"+sGXsfl_31_fel_idx;
         edtJC_ProviderName_Internalname = "JC_PROVIDERNAME_"+sGXsfl_31_fel_idx;
         edtJC_ProviderShortName_Internalname = "JC_PROVIDERSHORTNAME_"+sGXsfl_31_fel_idx;
         edtJC_ProviderAddresss_Internalname = "JC_PROVIDERADDRESSS_"+sGXsfl_31_fel_idx;
         edtJC_ProviderPhone_Internalname = "JC_PROVIDERPHONE_"+sGXsfl_31_fel_idx;
         edtJC_ProviderUser_Internalname = "JC_PROVIDERUSER_"+sGXsfl_31_fel_idx;
      }

      protected void sendrow_312( )
      {
         SubsflControlProps_312( ) ;
         WB8I0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_31_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_31_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_31_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV45Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV45Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV65Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV45Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV45Display)) ? AV65Display_GXI : context.PathToRelativeUrl( AV45Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV45Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV46Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV46Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV66Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV46Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV46Update)) ? AV66Update_GXI : context.PathToRelativeUrl( AV46Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavUpdate_Visible,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV46Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "DeleteAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV48Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV48Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV67Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV48Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV48Delete)) ? AV67Delete_GXI : context.PathToRelativeUrl( AV48Delete));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)edtavDelete_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavDelete_Visible,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV48Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtJC_ProviderID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A87JC_ProviderID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A87JC_ProviderID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtJC_ProviderID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtJC_ProviderName_Internalname,(String)A89JC_ProviderName,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtJC_ProviderName_Link,(String)"",(String)"",(String)"",(String)edtJC_ProviderName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)410,(String)"px",(short)17,(String)"px",(short)200,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtJC_ProviderShortName_Internalname,(String)A160JC_ProviderShortName,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtJC_ProviderShortName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtJC_ProviderAddresss_Internalname,(String)A161JC_ProviderAddresss,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+"e238i2_client"+"'","http://maps.google.com/maps?q="+GXUtil.UrlEncode( A161JC_ProviderAddresss),(String)"_blank",(String)"",(String)"",(String)edtJC_ProviderAddresss_Jsonclick,(short)7,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)410,(String)"px",(short)17,(String)"px",(short)1024,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"GeneXus\\Address",(String)"left",(bool)true});
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
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtJC_ProviderPhone_Internalname,StringUtil.RTrim( A162JC_ProviderPhone),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)gxphoneLink,(String)"",(String)"",(String)"",(String)edtJC_ProviderPhone_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"tel",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"GeneXus\\Phone",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtJC_ProviderUser_Internalname,(String)A163JC_ProviderUser,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtJC_ProviderUser_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes8I2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_31_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_31_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_31_idx+1));
            sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
            SubsflControlProps_312( ) ;
         }
         /* End function sendrow_312 */
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
         edtavTfjc_providerid_Internalname = "vTFJC_PROVIDERID";
         edtavTfjc_providerid_to_Internalname = "vTFJC_PROVIDERID_TO";
         edtavTfjc_providername_Internalname = "vTFJC_PROVIDERNAME";
         edtavTfjc_providername_sel_Internalname = "vTFJC_PROVIDERNAME_SEL";
         edtavTfjc_providershortname_Internalname = "vTFJC_PROVIDERSHORTNAME";
         edtavTfjc_providershortname_sel_Internalname = "vTFJC_PROVIDERSHORTNAME_SEL";
         edtavTfjc_provideraddresss_Internalname = "vTFJC_PROVIDERADDRESSS";
         edtavTfjc_provideraddresss_sel_Internalname = "vTFJC_PROVIDERADDRESSS_SEL";
         edtavTfjc_providerphone_Internalname = "vTFJC_PROVIDERPHONE";
         edtavTfjc_providerphone_sel_Internalname = "vTFJC_PROVIDERPHONE_SEL";
         edtavTfjc_provideruser_Internalname = "vTFJC_PROVIDERUSER";
         edtavTfjc_provideruser_sel_Internalname = "vTFJC_PROVIDERUSER_SEL";
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
         edtavTfjc_provideruser_sel_Jsonclick = "";
         edtavTfjc_provideruser_sel_Visible = 1;
         edtavTfjc_provideruser_Jsonclick = "";
         edtavTfjc_provideruser_Visible = 1;
         edtavTfjc_providerphone_sel_Jsonclick = "";
         edtavTfjc_providerphone_sel_Visible = 1;
         edtavTfjc_providerphone_Jsonclick = "";
         edtavTfjc_providerphone_Visible = 1;
         edtavTfjc_provideraddresss_sel_Visible = 1;
         edtavTfjc_provideraddresss_Visible = 1;
         edtavTfjc_providershortname_sel_Jsonclick = "";
         edtavTfjc_providershortname_sel_Visible = 1;
         edtavTfjc_providershortname_Jsonclick = "";
         edtavTfjc_providershortname_Visible = 1;
         edtavTfjc_providername_sel_Jsonclick = "";
         edtavTfjc_providername_sel_Visible = 1;
         edtavTfjc_providername_Jsonclick = "";
         edtavTfjc_providername_Visible = 1;
         edtavTfjc_providerid_to_Jsonclick = "";
         edtavTfjc_providerid_to_Visible = 1;
         edtavTfjc_providerid_Jsonclick = "";
         edtavTfjc_providerid_Visible = 1;
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
         edtJC_ProviderName_Link = "";
         edtavDelete_Tooltiptext = "删除";
         edtavDelete_Link = "";
         edtavUpdate_Tooltiptext = "修改";
         edtavUpdate_Link = "";
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = "";
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
         edtavDelete_Visible = -1;
         edtavUpdate_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         bttBtninsert_Visible = 1;
         Ddo_jc_provideruser_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_jc_provideruser_Noresultsfound = "WWP_TSNoResults";
         Ddo_jc_provideruser_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_jc_provideruser_Loadingdata = "WWP_TSLoading";
         Ddo_jc_provideruser_Sortdsc = "WWP_TSSortDSC";
         Ddo_jc_provideruser_Sortasc = "WWP_TSSortASC";
         Ddo_jc_provideruser_Datalistupdateminimumcharacters = 0;
         Ddo_jc_provideruser_Datalistproc = "JC_ProviderWWGetFilterData";
         Ddo_jc_provideruser_Datalisttype = "Dynamic";
         Ddo_jc_provideruser_Includedatalist = Convert.ToBoolean( -1);
         Ddo_jc_provideruser_Filterisrange = Convert.ToBoolean( 0);
         Ddo_jc_provideruser_Filtertype = "Character";
         Ddo_jc_provideruser_Includefilter = Convert.ToBoolean( -1);
         Ddo_jc_provideruser_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_jc_provideruser_Includesortasc = Convert.ToBoolean( -1);
         Ddo_jc_provideruser_Titlecontrolidtoreplace = "";
         Ddo_jc_provideruser_Dropdownoptionstype = "GridTitleSettings";
         Ddo_jc_provideruser_Cls = "ColumnSettings";
         Ddo_jc_provideruser_Tooltip = "WWP_TSColumnOptions";
         Ddo_jc_provideruser_Caption = "";
         Ddo_jc_providerphone_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_jc_providerphone_Noresultsfound = "WWP_TSNoResults";
         Ddo_jc_providerphone_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_jc_providerphone_Loadingdata = "WWP_TSLoading";
         Ddo_jc_providerphone_Sortdsc = "WWP_TSSortDSC";
         Ddo_jc_providerphone_Sortasc = "WWP_TSSortASC";
         Ddo_jc_providerphone_Datalistupdateminimumcharacters = 0;
         Ddo_jc_providerphone_Datalistproc = "JC_ProviderWWGetFilterData";
         Ddo_jc_providerphone_Datalisttype = "Dynamic";
         Ddo_jc_providerphone_Includedatalist = Convert.ToBoolean( -1);
         Ddo_jc_providerphone_Filterisrange = Convert.ToBoolean( 0);
         Ddo_jc_providerphone_Filtertype = "Character";
         Ddo_jc_providerphone_Includefilter = Convert.ToBoolean( -1);
         Ddo_jc_providerphone_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_jc_providerphone_Includesortasc = Convert.ToBoolean( -1);
         Ddo_jc_providerphone_Titlecontrolidtoreplace = "";
         Ddo_jc_providerphone_Dropdownoptionstype = "GridTitleSettings";
         Ddo_jc_providerphone_Cls = "ColumnSettings";
         Ddo_jc_providerphone_Tooltip = "WWP_TSColumnOptions";
         Ddo_jc_providerphone_Caption = "";
         Ddo_jc_provideraddresss_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_jc_provideraddresss_Noresultsfound = "WWP_TSNoResults";
         Ddo_jc_provideraddresss_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_jc_provideraddresss_Loadingdata = "WWP_TSLoading";
         Ddo_jc_provideraddresss_Sortdsc = "WWP_TSSortDSC";
         Ddo_jc_provideraddresss_Sortasc = "WWP_TSSortASC";
         Ddo_jc_provideraddresss_Datalistupdateminimumcharacters = 0;
         Ddo_jc_provideraddresss_Datalistproc = "JC_ProviderWWGetFilterData";
         Ddo_jc_provideraddresss_Datalisttype = "Dynamic";
         Ddo_jc_provideraddresss_Includedatalist = Convert.ToBoolean( -1);
         Ddo_jc_provideraddresss_Filterisrange = Convert.ToBoolean( 0);
         Ddo_jc_provideraddresss_Filtertype = "Character";
         Ddo_jc_provideraddresss_Includefilter = Convert.ToBoolean( -1);
         Ddo_jc_provideraddresss_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_jc_provideraddresss_Includesortasc = Convert.ToBoolean( -1);
         Ddo_jc_provideraddresss_Titlecontrolidtoreplace = "";
         Ddo_jc_provideraddresss_Dropdownoptionstype = "GridTitleSettings";
         Ddo_jc_provideraddresss_Cls = "ColumnSettings";
         Ddo_jc_provideraddresss_Tooltip = "WWP_TSColumnOptions";
         Ddo_jc_provideraddresss_Caption = "";
         Ddo_jc_providershortname_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_jc_providershortname_Noresultsfound = "WWP_TSNoResults";
         Ddo_jc_providershortname_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_jc_providershortname_Loadingdata = "WWP_TSLoading";
         Ddo_jc_providershortname_Sortdsc = "WWP_TSSortDSC";
         Ddo_jc_providershortname_Sortasc = "WWP_TSSortASC";
         Ddo_jc_providershortname_Datalistupdateminimumcharacters = 0;
         Ddo_jc_providershortname_Datalistproc = "JC_ProviderWWGetFilterData";
         Ddo_jc_providershortname_Datalisttype = "Dynamic";
         Ddo_jc_providershortname_Includedatalist = Convert.ToBoolean( -1);
         Ddo_jc_providershortname_Filterisrange = Convert.ToBoolean( 0);
         Ddo_jc_providershortname_Filtertype = "Character";
         Ddo_jc_providershortname_Includefilter = Convert.ToBoolean( -1);
         Ddo_jc_providershortname_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_jc_providershortname_Includesortasc = Convert.ToBoolean( -1);
         Ddo_jc_providershortname_Titlecontrolidtoreplace = "";
         Ddo_jc_providershortname_Dropdownoptionstype = "GridTitleSettings";
         Ddo_jc_providershortname_Cls = "ColumnSettings";
         Ddo_jc_providershortname_Tooltip = "WWP_TSColumnOptions";
         Ddo_jc_providershortname_Caption = "";
         Ddo_jc_providername_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_jc_providername_Noresultsfound = "WWP_TSNoResults";
         Ddo_jc_providername_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_jc_providername_Loadingdata = "WWP_TSLoading";
         Ddo_jc_providername_Sortdsc = "WWP_TSSortDSC";
         Ddo_jc_providername_Sortasc = "WWP_TSSortASC";
         Ddo_jc_providername_Datalistupdateminimumcharacters = 0;
         Ddo_jc_providername_Datalistproc = "JC_ProviderWWGetFilterData";
         Ddo_jc_providername_Datalisttype = "Dynamic";
         Ddo_jc_providername_Includedatalist = Convert.ToBoolean( -1);
         Ddo_jc_providername_Filterisrange = Convert.ToBoolean( 0);
         Ddo_jc_providername_Filtertype = "Character";
         Ddo_jc_providername_Includefilter = Convert.ToBoolean( -1);
         Ddo_jc_providername_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_jc_providername_Includesortasc = Convert.ToBoolean( -1);
         Ddo_jc_providername_Titlecontrolidtoreplace = "";
         Ddo_jc_providername_Dropdownoptionstype = "GridTitleSettings";
         Ddo_jc_providername_Cls = "ColumnSettings";
         Ddo_jc_providername_Tooltip = "WWP_TSColumnOptions";
         Ddo_jc_providername_Caption = "";
         Ddo_jc_providerid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_jc_providerid_Rangefilterto = "WWP_TSTo";
         Ddo_jc_providerid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_jc_providerid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_jc_providerid_Sortdsc = "WWP_TSSortDSC";
         Ddo_jc_providerid_Sortasc = "WWP_TSSortASC";
         Ddo_jc_providerid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_jc_providerid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_jc_providerid_Filtertype = "Numeric";
         Ddo_jc_providerid_Includefilter = Convert.ToBoolean( -1);
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
         Form.Caption = " 医院";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV19ddo_JC_ProviderIDTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_JC_ProviderShortNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_JC_ProviderAddresssTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_JC_ProviderPhoneTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_JC_ProviderUserTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV17TFJC_ProviderID',fld:'vTFJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFJC_ProviderID_To',fld:'vTFJC_PROVIDERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFJC_ProviderName',fld:'vTFJC_PROVIDERNAME',pic:''},{av:'AV22TFJC_ProviderName_Sel',fld:'vTFJC_PROVIDERNAME_SEL',pic:''},{av:'AV25TFJC_ProviderShortName',fld:'vTFJC_PROVIDERSHORTNAME',pic:''},{av:'AV26TFJC_ProviderShortName_Sel',fld:'vTFJC_PROVIDERSHORTNAME_SEL',pic:''},{av:'AV29TFJC_ProviderAddresss',fld:'vTFJC_PROVIDERADDRESSS',pic:''},{av:'AV30TFJC_ProviderAddresss_Sel',fld:'vTFJC_PROVIDERADDRESSS_SEL',pic:''},{av:'AV33TFJC_ProviderPhone',fld:'vTFJC_PROVIDERPHONE',pic:''},{av:'AV34TFJC_ProviderPhone_Sel',fld:'vTFJC_PROVIDERPHONE_SEL',pic:''},{av:'AV37TFJC_ProviderUser',fld:'vTFJC_PROVIDERUSER',pic:''},{av:'AV38TFJC_ProviderUser_Sel',fld:'vTFJC_PROVIDERUSER_SEL',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV16JC_ProviderIDTitleFilterData',fld:'vJC_PROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV20JC_ProviderNameTitleFilterData',fld:'vJC_PROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV24JC_ProviderShortNameTitleFilterData',fld:'vJC_PROVIDERSHORTNAMETITLEFILTERDATA',pic:''},{av:'AV28JC_ProviderAddresssTitleFilterData',fld:'vJC_PROVIDERADDRESSSTITLEFILTERDATA',pic:''},{av:'AV32JC_ProviderPhoneTitleFilterData',fld:'vJC_PROVIDERPHONETITLEFILTERDATA',pic:''},{av:'AV36JC_ProviderUserTitleFilterData',fld:'vJC_PROVIDERUSERTITLEFILTERDATA',pic:''},{av:'edtJC_ProviderID_Titleformat',ctrl:'JC_PROVIDERID',prop:'Titleformat'},{av:'edtJC_ProviderID_Title',ctrl:'JC_PROVIDERID',prop:'Title'},{av:'edtJC_ProviderName_Titleformat',ctrl:'JC_PROVIDERNAME',prop:'Titleformat'},{av:'edtJC_ProviderName_Title',ctrl:'JC_PROVIDERNAME',prop:'Title'},{av:'edtJC_ProviderShortName_Titleformat',ctrl:'JC_PROVIDERSHORTNAME',prop:'Titleformat'},{av:'edtJC_ProviderShortName_Title',ctrl:'JC_PROVIDERSHORTNAME',prop:'Title'},{av:'edtJC_ProviderAddresss_Titleformat',ctrl:'JC_PROVIDERADDRESSS',prop:'Titleformat'},{av:'edtJC_ProviderAddresss_Title',ctrl:'JC_PROVIDERADDRESSS',prop:'Title'},{av:'edtJC_ProviderPhone_Titleformat',ctrl:'JC_PROVIDERPHONE',prop:'Titleformat'},{av:'edtJC_ProviderPhone_Title',ctrl:'JC_PROVIDERPHONE',prop:'Title'},{av:'edtJC_ProviderUser_Titleformat',ctrl:'JC_PROVIDERUSER',prop:'Titleformat'},{av:'edtJC_ProviderUser_Title',ctrl:'JC_PROVIDERUSER',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("JC_PROVIDERADDRESSS.CLICK","{handler:'E238I2',iparms:[{av:'A161JC_ProviderAddresss',fld:'JC_PROVIDERADDRESSS',pic:'',hsh:true}]");
         setEventMetadata("JC_PROVIDERADDRESSS.CLICK",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E118I2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFJC_ProviderID',fld:'vTFJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFJC_ProviderID_To',fld:'vTFJC_PROVIDERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFJC_ProviderName',fld:'vTFJC_PROVIDERNAME',pic:''},{av:'AV22TFJC_ProviderName_Sel',fld:'vTFJC_PROVIDERNAME_SEL',pic:''},{av:'AV25TFJC_ProviderShortName',fld:'vTFJC_PROVIDERSHORTNAME',pic:''},{av:'AV26TFJC_ProviderShortName_Sel',fld:'vTFJC_PROVIDERSHORTNAME_SEL',pic:''},{av:'AV29TFJC_ProviderAddresss',fld:'vTFJC_PROVIDERADDRESSS',pic:''},{av:'AV30TFJC_ProviderAddresss_Sel',fld:'vTFJC_PROVIDERADDRESSS_SEL',pic:''},{av:'AV33TFJC_ProviderPhone',fld:'vTFJC_PROVIDERPHONE',pic:''},{av:'AV34TFJC_ProviderPhone_Sel',fld:'vTFJC_PROVIDERPHONE_SEL',pic:''},{av:'AV37TFJC_ProviderUser',fld:'vTFJC_PROVIDERUSER',pic:''},{av:'AV38TFJC_ProviderUser_Sel',fld:'vTFJC_PROVIDERUSER_SEL',pic:''},{av:'AV19ddo_JC_ProviderIDTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_JC_ProviderShortNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_JC_ProviderAddresssTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_JC_ProviderPhoneTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_JC_ProviderUserTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E128I2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFJC_ProviderID',fld:'vTFJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFJC_ProviderID_To',fld:'vTFJC_PROVIDERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFJC_ProviderName',fld:'vTFJC_PROVIDERNAME',pic:''},{av:'AV22TFJC_ProviderName_Sel',fld:'vTFJC_PROVIDERNAME_SEL',pic:''},{av:'AV25TFJC_ProviderShortName',fld:'vTFJC_PROVIDERSHORTNAME',pic:''},{av:'AV26TFJC_ProviderShortName_Sel',fld:'vTFJC_PROVIDERSHORTNAME_SEL',pic:''},{av:'AV29TFJC_ProviderAddresss',fld:'vTFJC_PROVIDERADDRESSS',pic:''},{av:'AV30TFJC_ProviderAddresss_Sel',fld:'vTFJC_PROVIDERADDRESSS_SEL',pic:''},{av:'AV33TFJC_ProviderPhone',fld:'vTFJC_PROVIDERPHONE',pic:''},{av:'AV34TFJC_ProviderPhone_Sel',fld:'vTFJC_PROVIDERPHONE_SEL',pic:''},{av:'AV37TFJC_ProviderUser',fld:'vTFJC_PROVIDERUSER',pic:''},{av:'AV38TFJC_ProviderUser_Sel',fld:'vTFJC_PROVIDERUSER_SEL',pic:''},{av:'AV19ddo_JC_ProviderIDTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_JC_ProviderShortNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_JC_ProviderAddresssTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_JC_ProviderPhoneTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_JC_ProviderUserTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_JC_PROVIDERID.ONOPTIONCLICKED","{handler:'E138I2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFJC_ProviderID',fld:'vTFJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFJC_ProviderID_To',fld:'vTFJC_PROVIDERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFJC_ProviderName',fld:'vTFJC_PROVIDERNAME',pic:''},{av:'AV22TFJC_ProviderName_Sel',fld:'vTFJC_PROVIDERNAME_SEL',pic:''},{av:'AV25TFJC_ProviderShortName',fld:'vTFJC_PROVIDERSHORTNAME',pic:''},{av:'AV26TFJC_ProviderShortName_Sel',fld:'vTFJC_PROVIDERSHORTNAME_SEL',pic:''},{av:'AV29TFJC_ProviderAddresss',fld:'vTFJC_PROVIDERADDRESSS',pic:''},{av:'AV30TFJC_ProviderAddresss_Sel',fld:'vTFJC_PROVIDERADDRESSS_SEL',pic:''},{av:'AV33TFJC_ProviderPhone',fld:'vTFJC_PROVIDERPHONE',pic:''},{av:'AV34TFJC_ProviderPhone_Sel',fld:'vTFJC_PROVIDERPHONE_SEL',pic:''},{av:'AV37TFJC_ProviderUser',fld:'vTFJC_PROVIDERUSER',pic:''},{av:'AV38TFJC_ProviderUser_Sel',fld:'vTFJC_PROVIDERUSER_SEL',pic:''},{av:'AV19ddo_JC_ProviderIDTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_JC_ProviderShortNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_JC_ProviderAddresssTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_JC_ProviderPhoneTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_JC_ProviderUserTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_jc_providerid_Activeeventkey',ctrl:'DDO_JC_PROVIDERID',prop:'ActiveEventKey'},{av:'Ddo_jc_providerid_Filteredtext_get',ctrl:'DDO_JC_PROVIDERID',prop:'FilteredText_get'},{av:'Ddo_jc_providerid_Filteredtextto_get',ctrl:'DDO_JC_PROVIDERID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_JC_PROVIDERID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_jc_providerid_Sortedstatus',ctrl:'DDO_JC_PROVIDERID',prop:'SortedStatus'},{av:'AV17TFJC_ProviderID',fld:'vTFJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFJC_ProviderID_To',fld:'vTFJC_PROVIDERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_jc_providername_Sortedstatus',ctrl:'DDO_JC_PROVIDERNAME',prop:'SortedStatus'},{av:'Ddo_jc_providershortname_Sortedstatus',ctrl:'DDO_JC_PROVIDERSHORTNAME',prop:'SortedStatus'},{av:'Ddo_jc_provideraddresss_Sortedstatus',ctrl:'DDO_JC_PROVIDERADDRESSS',prop:'SortedStatus'},{av:'Ddo_jc_providerphone_Sortedstatus',ctrl:'DDO_JC_PROVIDERPHONE',prop:'SortedStatus'},{av:'Ddo_jc_provideruser_Sortedstatus',ctrl:'DDO_JC_PROVIDERUSER',prop:'SortedStatus'},{av:'AV16JC_ProviderIDTitleFilterData',fld:'vJC_PROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV20JC_ProviderNameTitleFilterData',fld:'vJC_PROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV24JC_ProviderShortNameTitleFilterData',fld:'vJC_PROVIDERSHORTNAMETITLEFILTERDATA',pic:''},{av:'AV28JC_ProviderAddresssTitleFilterData',fld:'vJC_PROVIDERADDRESSSTITLEFILTERDATA',pic:''},{av:'AV32JC_ProviderPhoneTitleFilterData',fld:'vJC_PROVIDERPHONETITLEFILTERDATA',pic:''},{av:'AV36JC_ProviderUserTitleFilterData',fld:'vJC_PROVIDERUSERTITLEFILTERDATA',pic:''},{av:'edtJC_ProviderID_Titleformat',ctrl:'JC_PROVIDERID',prop:'Titleformat'},{av:'edtJC_ProviderID_Title',ctrl:'JC_PROVIDERID',prop:'Title'},{av:'edtJC_ProviderName_Titleformat',ctrl:'JC_PROVIDERNAME',prop:'Titleformat'},{av:'edtJC_ProviderName_Title',ctrl:'JC_PROVIDERNAME',prop:'Title'},{av:'edtJC_ProviderShortName_Titleformat',ctrl:'JC_PROVIDERSHORTNAME',prop:'Titleformat'},{av:'edtJC_ProviderShortName_Title',ctrl:'JC_PROVIDERSHORTNAME',prop:'Title'},{av:'edtJC_ProviderAddresss_Titleformat',ctrl:'JC_PROVIDERADDRESSS',prop:'Titleformat'},{av:'edtJC_ProviderAddresss_Title',ctrl:'JC_PROVIDERADDRESSS',prop:'Title'},{av:'edtJC_ProviderPhone_Titleformat',ctrl:'JC_PROVIDERPHONE',prop:'Titleformat'},{av:'edtJC_ProviderPhone_Title',ctrl:'JC_PROVIDERPHONE',prop:'Title'},{av:'edtJC_ProviderUser_Titleformat',ctrl:'JC_PROVIDERUSER',prop:'Titleformat'},{av:'edtJC_ProviderUser_Title',ctrl:'JC_PROVIDERUSER',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_JC_PROVIDERNAME.ONOPTIONCLICKED","{handler:'E148I2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFJC_ProviderID',fld:'vTFJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFJC_ProviderID_To',fld:'vTFJC_PROVIDERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFJC_ProviderName',fld:'vTFJC_PROVIDERNAME',pic:''},{av:'AV22TFJC_ProviderName_Sel',fld:'vTFJC_PROVIDERNAME_SEL',pic:''},{av:'AV25TFJC_ProviderShortName',fld:'vTFJC_PROVIDERSHORTNAME',pic:''},{av:'AV26TFJC_ProviderShortName_Sel',fld:'vTFJC_PROVIDERSHORTNAME_SEL',pic:''},{av:'AV29TFJC_ProviderAddresss',fld:'vTFJC_PROVIDERADDRESSS',pic:''},{av:'AV30TFJC_ProviderAddresss_Sel',fld:'vTFJC_PROVIDERADDRESSS_SEL',pic:''},{av:'AV33TFJC_ProviderPhone',fld:'vTFJC_PROVIDERPHONE',pic:''},{av:'AV34TFJC_ProviderPhone_Sel',fld:'vTFJC_PROVIDERPHONE_SEL',pic:''},{av:'AV37TFJC_ProviderUser',fld:'vTFJC_PROVIDERUSER',pic:''},{av:'AV38TFJC_ProviderUser_Sel',fld:'vTFJC_PROVIDERUSER_SEL',pic:''},{av:'AV19ddo_JC_ProviderIDTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_JC_ProviderShortNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_JC_ProviderAddresssTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_JC_ProviderPhoneTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_JC_ProviderUserTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_jc_providername_Activeeventkey',ctrl:'DDO_JC_PROVIDERNAME',prop:'ActiveEventKey'},{av:'Ddo_jc_providername_Filteredtext_get',ctrl:'DDO_JC_PROVIDERNAME',prop:'FilteredText_get'},{av:'Ddo_jc_providername_Selectedvalue_get',ctrl:'DDO_JC_PROVIDERNAME',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_JC_PROVIDERNAME.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_jc_providername_Sortedstatus',ctrl:'DDO_JC_PROVIDERNAME',prop:'SortedStatus'},{av:'AV21TFJC_ProviderName',fld:'vTFJC_PROVIDERNAME',pic:''},{av:'AV22TFJC_ProviderName_Sel',fld:'vTFJC_PROVIDERNAME_SEL',pic:''},{av:'Ddo_jc_providerid_Sortedstatus',ctrl:'DDO_JC_PROVIDERID',prop:'SortedStatus'},{av:'Ddo_jc_providershortname_Sortedstatus',ctrl:'DDO_JC_PROVIDERSHORTNAME',prop:'SortedStatus'},{av:'Ddo_jc_provideraddresss_Sortedstatus',ctrl:'DDO_JC_PROVIDERADDRESSS',prop:'SortedStatus'},{av:'Ddo_jc_providerphone_Sortedstatus',ctrl:'DDO_JC_PROVIDERPHONE',prop:'SortedStatus'},{av:'Ddo_jc_provideruser_Sortedstatus',ctrl:'DDO_JC_PROVIDERUSER',prop:'SortedStatus'},{av:'AV16JC_ProviderIDTitleFilterData',fld:'vJC_PROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV20JC_ProviderNameTitleFilterData',fld:'vJC_PROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV24JC_ProviderShortNameTitleFilterData',fld:'vJC_PROVIDERSHORTNAMETITLEFILTERDATA',pic:''},{av:'AV28JC_ProviderAddresssTitleFilterData',fld:'vJC_PROVIDERADDRESSSTITLEFILTERDATA',pic:''},{av:'AV32JC_ProviderPhoneTitleFilterData',fld:'vJC_PROVIDERPHONETITLEFILTERDATA',pic:''},{av:'AV36JC_ProviderUserTitleFilterData',fld:'vJC_PROVIDERUSERTITLEFILTERDATA',pic:''},{av:'edtJC_ProviderID_Titleformat',ctrl:'JC_PROVIDERID',prop:'Titleformat'},{av:'edtJC_ProviderID_Title',ctrl:'JC_PROVIDERID',prop:'Title'},{av:'edtJC_ProviderName_Titleformat',ctrl:'JC_PROVIDERNAME',prop:'Titleformat'},{av:'edtJC_ProviderName_Title',ctrl:'JC_PROVIDERNAME',prop:'Title'},{av:'edtJC_ProviderShortName_Titleformat',ctrl:'JC_PROVIDERSHORTNAME',prop:'Titleformat'},{av:'edtJC_ProviderShortName_Title',ctrl:'JC_PROVIDERSHORTNAME',prop:'Title'},{av:'edtJC_ProviderAddresss_Titleformat',ctrl:'JC_PROVIDERADDRESSS',prop:'Titleformat'},{av:'edtJC_ProviderAddresss_Title',ctrl:'JC_PROVIDERADDRESSS',prop:'Title'},{av:'edtJC_ProviderPhone_Titleformat',ctrl:'JC_PROVIDERPHONE',prop:'Titleformat'},{av:'edtJC_ProviderPhone_Title',ctrl:'JC_PROVIDERPHONE',prop:'Title'},{av:'edtJC_ProviderUser_Titleformat',ctrl:'JC_PROVIDERUSER',prop:'Titleformat'},{av:'edtJC_ProviderUser_Title',ctrl:'JC_PROVIDERUSER',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_JC_PROVIDERSHORTNAME.ONOPTIONCLICKED","{handler:'E158I2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFJC_ProviderID',fld:'vTFJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFJC_ProviderID_To',fld:'vTFJC_PROVIDERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFJC_ProviderName',fld:'vTFJC_PROVIDERNAME',pic:''},{av:'AV22TFJC_ProviderName_Sel',fld:'vTFJC_PROVIDERNAME_SEL',pic:''},{av:'AV25TFJC_ProviderShortName',fld:'vTFJC_PROVIDERSHORTNAME',pic:''},{av:'AV26TFJC_ProviderShortName_Sel',fld:'vTFJC_PROVIDERSHORTNAME_SEL',pic:''},{av:'AV29TFJC_ProviderAddresss',fld:'vTFJC_PROVIDERADDRESSS',pic:''},{av:'AV30TFJC_ProviderAddresss_Sel',fld:'vTFJC_PROVIDERADDRESSS_SEL',pic:''},{av:'AV33TFJC_ProviderPhone',fld:'vTFJC_PROVIDERPHONE',pic:''},{av:'AV34TFJC_ProviderPhone_Sel',fld:'vTFJC_PROVIDERPHONE_SEL',pic:''},{av:'AV37TFJC_ProviderUser',fld:'vTFJC_PROVIDERUSER',pic:''},{av:'AV38TFJC_ProviderUser_Sel',fld:'vTFJC_PROVIDERUSER_SEL',pic:''},{av:'AV19ddo_JC_ProviderIDTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_JC_ProviderShortNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_JC_ProviderAddresssTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_JC_ProviderPhoneTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_JC_ProviderUserTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_jc_providershortname_Activeeventkey',ctrl:'DDO_JC_PROVIDERSHORTNAME',prop:'ActiveEventKey'},{av:'Ddo_jc_providershortname_Filteredtext_get',ctrl:'DDO_JC_PROVIDERSHORTNAME',prop:'FilteredText_get'},{av:'Ddo_jc_providershortname_Selectedvalue_get',ctrl:'DDO_JC_PROVIDERSHORTNAME',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_JC_PROVIDERSHORTNAME.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_jc_providershortname_Sortedstatus',ctrl:'DDO_JC_PROVIDERSHORTNAME',prop:'SortedStatus'},{av:'AV25TFJC_ProviderShortName',fld:'vTFJC_PROVIDERSHORTNAME',pic:''},{av:'AV26TFJC_ProviderShortName_Sel',fld:'vTFJC_PROVIDERSHORTNAME_SEL',pic:''},{av:'Ddo_jc_providerid_Sortedstatus',ctrl:'DDO_JC_PROVIDERID',prop:'SortedStatus'},{av:'Ddo_jc_providername_Sortedstatus',ctrl:'DDO_JC_PROVIDERNAME',prop:'SortedStatus'},{av:'Ddo_jc_provideraddresss_Sortedstatus',ctrl:'DDO_JC_PROVIDERADDRESSS',prop:'SortedStatus'},{av:'Ddo_jc_providerphone_Sortedstatus',ctrl:'DDO_JC_PROVIDERPHONE',prop:'SortedStatus'},{av:'Ddo_jc_provideruser_Sortedstatus',ctrl:'DDO_JC_PROVIDERUSER',prop:'SortedStatus'},{av:'AV16JC_ProviderIDTitleFilterData',fld:'vJC_PROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV20JC_ProviderNameTitleFilterData',fld:'vJC_PROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV24JC_ProviderShortNameTitleFilterData',fld:'vJC_PROVIDERSHORTNAMETITLEFILTERDATA',pic:''},{av:'AV28JC_ProviderAddresssTitleFilterData',fld:'vJC_PROVIDERADDRESSSTITLEFILTERDATA',pic:''},{av:'AV32JC_ProviderPhoneTitleFilterData',fld:'vJC_PROVIDERPHONETITLEFILTERDATA',pic:''},{av:'AV36JC_ProviderUserTitleFilterData',fld:'vJC_PROVIDERUSERTITLEFILTERDATA',pic:''},{av:'edtJC_ProviderID_Titleformat',ctrl:'JC_PROVIDERID',prop:'Titleformat'},{av:'edtJC_ProviderID_Title',ctrl:'JC_PROVIDERID',prop:'Title'},{av:'edtJC_ProviderName_Titleformat',ctrl:'JC_PROVIDERNAME',prop:'Titleformat'},{av:'edtJC_ProviderName_Title',ctrl:'JC_PROVIDERNAME',prop:'Title'},{av:'edtJC_ProviderShortName_Titleformat',ctrl:'JC_PROVIDERSHORTNAME',prop:'Titleformat'},{av:'edtJC_ProviderShortName_Title',ctrl:'JC_PROVIDERSHORTNAME',prop:'Title'},{av:'edtJC_ProviderAddresss_Titleformat',ctrl:'JC_PROVIDERADDRESSS',prop:'Titleformat'},{av:'edtJC_ProviderAddresss_Title',ctrl:'JC_PROVIDERADDRESSS',prop:'Title'},{av:'edtJC_ProviderPhone_Titleformat',ctrl:'JC_PROVIDERPHONE',prop:'Titleformat'},{av:'edtJC_ProviderPhone_Title',ctrl:'JC_PROVIDERPHONE',prop:'Title'},{av:'edtJC_ProviderUser_Titleformat',ctrl:'JC_PROVIDERUSER',prop:'Titleformat'},{av:'edtJC_ProviderUser_Title',ctrl:'JC_PROVIDERUSER',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_JC_PROVIDERADDRESSS.ONOPTIONCLICKED","{handler:'E168I2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFJC_ProviderID',fld:'vTFJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFJC_ProviderID_To',fld:'vTFJC_PROVIDERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFJC_ProviderName',fld:'vTFJC_PROVIDERNAME',pic:''},{av:'AV22TFJC_ProviderName_Sel',fld:'vTFJC_PROVIDERNAME_SEL',pic:''},{av:'AV25TFJC_ProviderShortName',fld:'vTFJC_PROVIDERSHORTNAME',pic:''},{av:'AV26TFJC_ProviderShortName_Sel',fld:'vTFJC_PROVIDERSHORTNAME_SEL',pic:''},{av:'AV29TFJC_ProviderAddresss',fld:'vTFJC_PROVIDERADDRESSS',pic:''},{av:'AV30TFJC_ProviderAddresss_Sel',fld:'vTFJC_PROVIDERADDRESSS_SEL',pic:''},{av:'AV33TFJC_ProviderPhone',fld:'vTFJC_PROVIDERPHONE',pic:''},{av:'AV34TFJC_ProviderPhone_Sel',fld:'vTFJC_PROVIDERPHONE_SEL',pic:''},{av:'AV37TFJC_ProviderUser',fld:'vTFJC_PROVIDERUSER',pic:''},{av:'AV38TFJC_ProviderUser_Sel',fld:'vTFJC_PROVIDERUSER_SEL',pic:''},{av:'AV19ddo_JC_ProviderIDTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_JC_ProviderShortNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_JC_ProviderAddresssTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_JC_ProviderPhoneTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_JC_ProviderUserTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_jc_provideraddresss_Activeeventkey',ctrl:'DDO_JC_PROVIDERADDRESSS',prop:'ActiveEventKey'},{av:'Ddo_jc_provideraddresss_Filteredtext_get',ctrl:'DDO_JC_PROVIDERADDRESSS',prop:'FilteredText_get'},{av:'Ddo_jc_provideraddresss_Selectedvalue_get',ctrl:'DDO_JC_PROVIDERADDRESSS',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_JC_PROVIDERADDRESSS.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_jc_provideraddresss_Sortedstatus',ctrl:'DDO_JC_PROVIDERADDRESSS',prop:'SortedStatus'},{av:'AV29TFJC_ProviderAddresss',fld:'vTFJC_PROVIDERADDRESSS',pic:''},{av:'AV30TFJC_ProviderAddresss_Sel',fld:'vTFJC_PROVIDERADDRESSS_SEL',pic:''},{av:'Ddo_jc_providerid_Sortedstatus',ctrl:'DDO_JC_PROVIDERID',prop:'SortedStatus'},{av:'Ddo_jc_providername_Sortedstatus',ctrl:'DDO_JC_PROVIDERNAME',prop:'SortedStatus'},{av:'Ddo_jc_providershortname_Sortedstatus',ctrl:'DDO_JC_PROVIDERSHORTNAME',prop:'SortedStatus'},{av:'Ddo_jc_providerphone_Sortedstatus',ctrl:'DDO_JC_PROVIDERPHONE',prop:'SortedStatus'},{av:'Ddo_jc_provideruser_Sortedstatus',ctrl:'DDO_JC_PROVIDERUSER',prop:'SortedStatus'},{av:'AV16JC_ProviderIDTitleFilterData',fld:'vJC_PROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV20JC_ProviderNameTitleFilterData',fld:'vJC_PROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV24JC_ProviderShortNameTitleFilterData',fld:'vJC_PROVIDERSHORTNAMETITLEFILTERDATA',pic:''},{av:'AV28JC_ProviderAddresssTitleFilterData',fld:'vJC_PROVIDERADDRESSSTITLEFILTERDATA',pic:''},{av:'AV32JC_ProviderPhoneTitleFilterData',fld:'vJC_PROVIDERPHONETITLEFILTERDATA',pic:''},{av:'AV36JC_ProviderUserTitleFilterData',fld:'vJC_PROVIDERUSERTITLEFILTERDATA',pic:''},{av:'edtJC_ProviderID_Titleformat',ctrl:'JC_PROVIDERID',prop:'Titleformat'},{av:'edtJC_ProviderID_Title',ctrl:'JC_PROVIDERID',prop:'Title'},{av:'edtJC_ProviderName_Titleformat',ctrl:'JC_PROVIDERNAME',prop:'Titleformat'},{av:'edtJC_ProviderName_Title',ctrl:'JC_PROVIDERNAME',prop:'Title'},{av:'edtJC_ProviderShortName_Titleformat',ctrl:'JC_PROVIDERSHORTNAME',prop:'Titleformat'},{av:'edtJC_ProviderShortName_Title',ctrl:'JC_PROVIDERSHORTNAME',prop:'Title'},{av:'edtJC_ProviderAddresss_Titleformat',ctrl:'JC_PROVIDERADDRESSS',prop:'Titleformat'},{av:'edtJC_ProviderAddresss_Title',ctrl:'JC_PROVIDERADDRESSS',prop:'Title'},{av:'edtJC_ProviderPhone_Titleformat',ctrl:'JC_PROVIDERPHONE',prop:'Titleformat'},{av:'edtJC_ProviderPhone_Title',ctrl:'JC_PROVIDERPHONE',prop:'Title'},{av:'edtJC_ProviderUser_Titleformat',ctrl:'JC_PROVIDERUSER',prop:'Titleformat'},{av:'edtJC_ProviderUser_Title',ctrl:'JC_PROVIDERUSER',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_JC_PROVIDERPHONE.ONOPTIONCLICKED","{handler:'E178I2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFJC_ProviderID',fld:'vTFJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFJC_ProviderID_To',fld:'vTFJC_PROVIDERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFJC_ProviderName',fld:'vTFJC_PROVIDERNAME',pic:''},{av:'AV22TFJC_ProviderName_Sel',fld:'vTFJC_PROVIDERNAME_SEL',pic:''},{av:'AV25TFJC_ProviderShortName',fld:'vTFJC_PROVIDERSHORTNAME',pic:''},{av:'AV26TFJC_ProviderShortName_Sel',fld:'vTFJC_PROVIDERSHORTNAME_SEL',pic:''},{av:'AV29TFJC_ProviderAddresss',fld:'vTFJC_PROVIDERADDRESSS',pic:''},{av:'AV30TFJC_ProviderAddresss_Sel',fld:'vTFJC_PROVIDERADDRESSS_SEL',pic:''},{av:'AV33TFJC_ProviderPhone',fld:'vTFJC_PROVIDERPHONE',pic:''},{av:'AV34TFJC_ProviderPhone_Sel',fld:'vTFJC_PROVIDERPHONE_SEL',pic:''},{av:'AV37TFJC_ProviderUser',fld:'vTFJC_PROVIDERUSER',pic:''},{av:'AV38TFJC_ProviderUser_Sel',fld:'vTFJC_PROVIDERUSER_SEL',pic:''},{av:'AV19ddo_JC_ProviderIDTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_JC_ProviderShortNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_JC_ProviderAddresssTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_JC_ProviderPhoneTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_JC_ProviderUserTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_jc_providerphone_Activeeventkey',ctrl:'DDO_JC_PROVIDERPHONE',prop:'ActiveEventKey'},{av:'Ddo_jc_providerphone_Filteredtext_get',ctrl:'DDO_JC_PROVIDERPHONE',prop:'FilteredText_get'},{av:'Ddo_jc_providerphone_Selectedvalue_get',ctrl:'DDO_JC_PROVIDERPHONE',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_JC_PROVIDERPHONE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_jc_providerphone_Sortedstatus',ctrl:'DDO_JC_PROVIDERPHONE',prop:'SortedStatus'},{av:'AV33TFJC_ProviderPhone',fld:'vTFJC_PROVIDERPHONE',pic:''},{av:'AV34TFJC_ProviderPhone_Sel',fld:'vTFJC_PROVIDERPHONE_SEL',pic:''},{av:'Ddo_jc_providerid_Sortedstatus',ctrl:'DDO_JC_PROVIDERID',prop:'SortedStatus'},{av:'Ddo_jc_providername_Sortedstatus',ctrl:'DDO_JC_PROVIDERNAME',prop:'SortedStatus'},{av:'Ddo_jc_providershortname_Sortedstatus',ctrl:'DDO_JC_PROVIDERSHORTNAME',prop:'SortedStatus'},{av:'Ddo_jc_provideraddresss_Sortedstatus',ctrl:'DDO_JC_PROVIDERADDRESSS',prop:'SortedStatus'},{av:'Ddo_jc_provideruser_Sortedstatus',ctrl:'DDO_JC_PROVIDERUSER',prop:'SortedStatus'},{av:'AV16JC_ProviderIDTitleFilterData',fld:'vJC_PROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV20JC_ProviderNameTitleFilterData',fld:'vJC_PROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV24JC_ProviderShortNameTitleFilterData',fld:'vJC_PROVIDERSHORTNAMETITLEFILTERDATA',pic:''},{av:'AV28JC_ProviderAddresssTitleFilterData',fld:'vJC_PROVIDERADDRESSSTITLEFILTERDATA',pic:''},{av:'AV32JC_ProviderPhoneTitleFilterData',fld:'vJC_PROVIDERPHONETITLEFILTERDATA',pic:''},{av:'AV36JC_ProviderUserTitleFilterData',fld:'vJC_PROVIDERUSERTITLEFILTERDATA',pic:''},{av:'edtJC_ProviderID_Titleformat',ctrl:'JC_PROVIDERID',prop:'Titleformat'},{av:'edtJC_ProviderID_Title',ctrl:'JC_PROVIDERID',prop:'Title'},{av:'edtJC_ProviderName_Titleformat',ctrl:'JC_PROVIDERNAME',prop:'Titleformat'},{av:'edtJC_ProviderName_Title',ctrl:'JC_PROVIDERNAME',prop:'Title'},{av:'edtJC_ProviderShortName_Titleformat',ctrl:'JC_PROVIDERSHORTNAME',prop:'Titleformat'},{av:'edtJC_ProviderShortName_Title',ctrl:'JC_PROVIDERSHORTNAME',prop:'Title'},{av:'edtJC_ProviderAddresss_Titleformat',ctrl:'JC_PROVIDERADDRESSS',prop:'Titleformat'},{av:'edtJC_ProviderAddresss_Title',ctrl:'JC_PROVIDERADDRESSS',prop:'Title'},{av:'edtJC_ProviderPhone_Titleformat',ctrl:'JC_PROVIDERPHONE',prop:'Titleformat'},{av:'edtJC_ProviderPhone_Title',ctrl:'JC_PROVIDERPHONE',prop:'Title'},{av:'edtJC_ProviderUser_Titleformat',ctrl:'JC_PROVIDERUSER',prop:'Titleformat'},{av:'edtJC_ProviderUser_Title',ctrl:'JC_PROVIDERUSER',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_JC_PROVIDERUSER.ONOPTIONCLICKED","{handler:'E188I2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFJC_ProviderID',fld:'vTFJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFJC_ProviderID_To',fld:'vTFJC_PROVIDERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFJC_ProviderName',fld:'vTFJC_PROVIDERNAME',pic:''},{av:'AV22TFJC_ProviderName_Sel',fld:'vTFJC_PROVIDERNAME_SEL',pic:''},{av:'AV25TFJC_ProviderShortName',fld:'vTFJC_PROVIDERSHORTNAME',pic:''},{av:'AV26TFJC_ProviderShortName_Sel',fld:'vTFJC_PROVIDERSHORTNAME_SEL',pic:''},{av:'AV29TFJC_ProviderAddresss',fld:'vTFJC_PROVIDERADDRESSS',pic:''},{av:'AV30TFJC_ProviderAddresss_Sel',fld:'vTFJC_PROVIDERADDRESSS_SEL',pic:''},{av:'AV33TFJC_ProviderPhone',fld:'vTFJC_PROVIDERPHONE',pic:''},{av:'AV34TFJC_ProviderPhone_Sel',fld:'vTFJC_PROVIDERPHONE_SEL',pic:''},{av:'AV37TFJC_ProviderUser',fld:'vTFJC_PROVIDERUSER',pic:''},{av:'AV38TFJC_ProviderUser_Sel',fld:'vTFJC_PROVIDERUSER_SEL',pic:''},{av:'AV19ddo_JC_ProviderIDTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_JC_ProviderNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_JC_ProviderShortNameTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERSHORTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_JC_ProviderAddresssTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERADDRESSSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_JC_ProviderPhoneTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERPHONETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_JC_ProviderUserTitleControlIdToReplace',fld:'vDDO_JC_PROVIDERUSERTITLECONTROLIDTOREPLACE',pic:''},{av:'AV68Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_jc_provideruser_Activeeventkey',ctrl:'DDO_JC_PROVIDERUSER',prop:'ActiveEventKey'},{av:'Ddo_jc_provideruser_Filteredtext_get',ctrl:'DDO_JC_PROVIDERUSER',prop:'FilteredText_get'},{av:'Ddo_jc_provideruser_Selectedvalue_get',ctrl:'DDO_JC_PROVIDERUSER',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_JC_PROVIDERUSER.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_jc_provideruser_Sortedstatus',ctrl:'DDO_JC_PROVIDERUSER',prop:'SortedStatus'},{av:'AV37TFJC_ProviderUser',fld:'vTFJC_PROVIDERUSER',pic:''},{av:'AV38TFJC_ProviderUser_Sel',fld:'vTFJC_PROVIDERUSER_SEL',pic:''},{av:'Ddo_jc_providerid_Sortedstatus',ctrl:'DDO_JC_PROVIDERID',prop:'SortedStatus'},{av:'Ddo_jc_providername_Sortedstatus',ctrl:'DDO_JC_PROVIDERNAME',prop:'SortedStatus'},{av:'Ddo_jc_providershortname_Sortedstatus',ctrl:'DDO_JC_PROVIDERSHORTNAME',prop:'SortedStatus'},{av:'Ddo_jc_provideraddresss_Sortedstatus',ctrl:'DDO_JC_PROVIDERADDRESSS',prop:'SortedStatus'},{av:'Ddo_jc_providerphone_Sortedstatus',ctrl:'DDO_JC_PROVIDERPHONE',prop:'SortedStatus'},{av:'AV16JC_ProviderIDTitleFilterData',fld:'vJC_PROVIDERIDTITLEFILTERDATA',pic:''},{av:'AV20JC_ProviderNameTitleFilterData',fld:'vJC_PROVIDERNAMETITLEFILTERDATA',pic:''},{av:'AV24JC_ProviderShortNameTitleFilterData',fld:'vJC_PROVIDERSHORTNAMETITLEFILTERDATA',pic:''},{av:'AV28JC_ProviderAddresssTitleFilterData',fld:'vJC_PROVIDERADDRESSSTITLEFILTERDATA',pic:''},{av:'AV32JC_ProviderPhoneTitleFilterData',fld:'vJC_PROVIDERPHONETITLEFILTERDATA',pic:''},{av:'AV36JC_ProviderUserTitleFilterData',fld:'vJC_PROVIDERUSERTITLEFILTERDATA',pic:''},{av:'edtJC_ProviderID_Titleformat',ctrl:'JC_PROVIDERID',prop:'Titleformat'},{av:'edtJC_ProviderID_Title',ctrl:'JC_PROVIDERID',prop:'Title'},{av:'edtJC_ProviderName_Titleformat',ctrl:'JC_PROVIDERNAME',prop:'Titleformat'},{av:'edtJC_ProviderName_Title',ctrl:'JC_PROVIDERNAME',prop:'Title'},{av:'edtJC_ProviderShortName_Titleformat',ctrl:'JC_PROVIDERSHORTNAME',prop:'Titleformat'},{av:'edtJC_ProviderShortName_Title',ctrl:'JC_PROVIDERSHORTNAME',prop:'Title'},{av:'edtJC_ProviderAddresss_Titleformat',ctrl:'JC_PROVIDERADDRESSS',prop:'Titleformat'},{av:'edtJC_ProviderAddresss_Title',ctrl:'JC_PROVIDERADDRESSS',prop:'Title'},{av:'edtJC_ProviderPhone_Titleformat',ctrl:'JC_PROVIDERPHONE',prop:'Titleformat'},{av:'edtJC_ProviderPhone_Title',ctrl:'JC_PROVIDERPHONE',prop:'Title'},{av:'edtJC_ProviderUser_Titleformat',ctrl:'JC_PROVIDERUSER',prop:'Titleformat'},{av:'edtJC_ProviderUser_Title',ctrl:'JC_PROVIDERUSER',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E228I2',iparms:[{av:'A87JC_ProviderID',fld:'JC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV47IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV49IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV45Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'},{av:'AV46Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV48Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'},{av:'edtJC_ProviderName_Link',ctrl:'JC_PROVIDERNAME',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E198I2',iparms:[{av:'A87JC_ProviderID',fld:'JC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
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
         Ddo_jc_providerid_Activeeventkey = "";
         Ddo_jc_providerid_Filteredtext_get = "";
         Ddo_jc_providerid_Filteredtextto_get = "";
         Ddo_jc_providername_Activeeventkey = "";
         Ddo_jc_providername_Filteredtext_get = "";
         Ddo_jc_providername_Selectedvalue_get = "";
         Ddo_jc_providershortname_Activeeventkey = "";
         Ddo_jc_providershortname_Filteredtext_get = "";
         Ddo_jc_providershortname_Selectedvalue_get = "";
         Ddo_jc_provideraddresss_Activeeventkey = "";
         Ddo_jc_provideraddresss_Filteredtext_get = "";
         Ddo_jc_provideraddresss_Selectedvalue_get = "";
         Ddo_jc_providerphone_Activeeventkey = "";
         Ddo_jc_providerphone_Filteredtext_get = "";
         Ddo_jc_providerphone_Selectedvalue_get = "";
         Ddo_jc_provideruser_Activeeventkey = "";
         Ddo_jc_provideruser_Filteredtext_get = "";
         Ddo_jc_provideruser_Selectedvalue_get = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV21TFJC_ProviderName = "";
         AV22TFJC_ProviderName_Sel = "";
         AV25TFJC_ProviderShortName = "";
         AV26TFJC_ProviderShortName_Sel = "";
         AV29TFJC_ProviderAddresss = "";
         AV30TFJC_ProviderAddresss_Sel = "";
         AV33TFJC_ProviderPhone = "";
         AV34TFJC_ProviderPhone_Sel = "";
         AV37TFJC_ProviderUser = "";
         AV38TFJC_ProviderUser_Sel = "";
         AV19ddo_JC_ProviderIDTitleControlIdToReplace = "";
         AV23ddo_JC_ProviderNameTitleControlIdToReplace = "";
         AV27ddo_JC_ProviderShortNameTitleControlIdToReplace = "";
         AV31ddo_JC_ProviderAddresssTitleControlIdToReplace = "";
         AV35ddo_JC_ProviderPhoneTitleControlIdToReplace = "";
         AV39ddo_JC_ProviderUserTitleControlIdToReplace = "";
         AV68Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV40DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV16JC_ProviderIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20JC_ProviderNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24JC_ProviderShortNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28JC_ProviderAddresssTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32JC_ProviderPhoneTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV36JC_ProviderUserTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_jc_providerid_Filteredtext_set = "";
         Ddo_jc_providerid_Filteredtextto_set = "";
         Ddo_jc_providerid_Sortedstatus = "";
         Ddo_jc_providername_Filteredtext_set = "";
         Ddo_jc_providername_Selectedvalue_set = "";
         Ddo_jc_providername_Sortedstatus = "";
         Ddo_jc_providershortname_Filteredtext_set = "";
         Ddo_jc_providershortname_Selectedvalue_set = "";
         Ddo_jc_providershortname_Sortedstatus = "";
         Ddo_jc_provideraddresss_Filteredtext_set = "";
         Ddo_jc_provideraddresss_Selectedvalue_set = "";
         Ddo_jc_provideraddresss_Sortedstatus = "";
         Ddo_jc_providerphone_Filteredtext_set = "";
         Ddo_jc_providerphone_Selectedvalue_set = "";
         Ddo_jc_providerphone_Sortedstatus = "";
         Ddo_jc_provideruser_Filteredtext_set = "";
         Ddo_jc_provideruser_Selectedvalue_set = "";
         Ddo_jc_provideruser_Sortedstatus = "";
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
         AV45Display = "";
         AV46Update = "";
         AV48Delete = "";
         A89JC_ProviderName = "";
         A160JC_ProviderShortName = "";
         A161JC_ProviderAddresss = "";
         A162JC_ProviderPhone = "";
         A163JC_ProviderUser = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_jc_providerid = new GXUserControl();
         ucDdo_jc_providername = new GXUserControl();
         ucDdo_jc_providershortname = new GXUserControl();
         ucDdo_jc_provideraddresss = new GXUserControl();
         ucDdo_jc_providerphone = new GXUserControl();
         ucDdo_jc_provideruser = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV65Display_GXI = "";
         AV66Update_GXI = "";
         AV67Delete_GXI = "";
         scmdbuf = "";
         lV55JC_ProviderWWDS_3_Tfjc_providername = "";
         lV57JC_ProviderWWDS_5_Tfjc_providershortname = "";
         lV59JC_ProviderWWDS_7_Tfjc_provideraddresss = "";
         lV61JC_ProviderWWDS_9_Tfjc_providerphone = "";
         lV63JC_ProviderWWDS_11_Tfjc_provideruser = "";
         AV56JC_ProviderWWDS_4_Tfjc_providername_sel = "";
         AV55JC_ProviderWWDS_3_Tfjc_providername = "";
         AV58JC_ProviderWWDS_6_Tfjc_providershortname_sel = "";
         AV57JC_ProviderWWDS_5_Tfjc_providershortname = "";
         AV60JC_ProviderWWDS_8_Tfjc_provideraddresss_sel = "";
         AV59JC_ProviderWWDS_7_Tfjc_provideraddresss = "";
         AV62JC_ProviderWWDS_10_Tfjc_providerphone_sel = "";
         AV61JC_ProviderWWDS_9_Tfjc_providerphone = "";
         AV64JC_ProviderWWDS_12_Tfjc_provideruser_sel = "";
         AV63JC_ProviderWWDS_11_Tfjc_provideruser = "";
         H008I2_A163JC_ProviderUser = new String[] {""} ;
         H008I2_n163JC_ProviderUser = new bool[] {false} ;
         H008I2_A162JC_ProviderPhone = new String[] {""} ;
         H008I2_n162JC_ProviderPhone = new bool[] {false} ;
         H008I2_A161JC_ProviderAddresss = new String[] {""} ;
         H008I2_n161JC_ProviderAddresss = new bool[] {false} ;
         H008I2_A160JC_ProviderShortName = new String[] {""} ;
         H008I2_n160JC_ProviderShortName = new bool[] {false} ;
         H008I2_A89JC_ProviderName = new String[] {""} ;
         H008I2_n89JC_ProviderName = new bool[] {false} ;
         H008I2_A87JC_ProviderID = new long[1] ;
         H008I3_AGRID_nRecordCount = new long[1] ;
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
         gxphoneLink = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.jc_providerww__default(),
            new Object[][] {
                new Object[] {
               H008I2_A163JC_ProviderUser, H008I2_n163JC_ProviderUser, H008I2_A162JC_ProviderPhone, H008I2_n162JC_ProviderPhone, H008I2_A161JC_ProviderAddresss, H008I2_n161JC_ProviderAddresss, H008I2_A160JC_ProviderShortName, H008I2_n160JC_ProviderShortName, H008I2_A89JC_ProviderName, H008I2_n89JC_ProviderName,
               H008I2_A87JC_ProviderID
               }
               , new Object[] {
               H008I3_AGRID_nRecordCount
               }
            }
         );
         AV68Pgmname = "JC_ProviderWW";
         /* GeneXus formulas. */
         AV68Pgmname = "JC_ProviderWW";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_31 ;
      private short nGXsfl_31_idx=1 ;
      private short GRID_nEOF ;
      private short AV13OrderedBy ;
      private short initialized ;
      private short gxajaxcallmode ;
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
      private int Ddo_jc_providername_Datalistupdateminimumcharacters ;
      private int Ddo_jc_providershortname_Datalistupdateminimumcharacters ;
      private int Ddo_jc_provideraddresss_Datalistupdateminimumcharacters ;
      private int Ddo_jc_providerphone_Datalistupdateminimumcharacters ;
      private int Ddo_jc_provideruser_Datalistupdateminimumcharacters ;
      private int bttBtninsert_Visible ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavUpdate_Visible ;
      private int edtavDelete_Visible ;
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
      private int edtavTfjc_providerid_Visible ;
      private int edtavTfjc_providerid_to_Visible ;
      private int edtavTfjc_providername_Visible ;
      private int edtavTfjc_providername_sel_Visible ;
      private int edtavTfjc_providershortname_Visible ;
      private int edtavTfjc_providershortname_sel_Visible ;
      private int edtavTfjc_provideraddresss_Visible ;
      private int edtavTfjc_provideraddresss_sel_Visible ;
      private int edtavTfjc_providerphone_Visible ;
      private int edtavTfjc_providerphone_sel_Visible ;
      private int edtavTfjc_provideruser_Visible ;
      private int edtavTfjc_provideruser_sel_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV41PageToGo ;
      private int AV69GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV17TFJC_ProviderID ;
      private long AV18TFJC_ProviderID_To ;
      private long AV42GridCurrentPage ;
      private long AV44GridRecordCount ;
      private long AV43GridPageSize ;
      private long A87JC_ProviderID ;
      private long GRID_nCurrentRecord ;
      private long AV53JC_ProviderWWDS_1_Tfjc_providerid ;
      private long AV54JC_ProviderWWDS_2_Tfjc_providerid_to ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_jc_providerid_Activeeventkey ;
      private String Ddo_jc_providerid_Filteredtext_get ;
      private String Ddo_jc_providerid_Filteredtextto_get ;
      private String Ddo_jc_providername_Activeeventkey ;
      private String Ddo_jc_providername_Filteredtext_get ;
      private String Ddo_jc_providername_Selectedvalue_get ;
      private String Ddo_jc_providershortname_Activeeventkey ;
      private String Ddo_jc_providershortname_Filteredtext_get ;
      private String Ddo_jc_providershortname_Selectedvalue_get ;
      private String Ddo_jc_provideraddresss_Activeeventkey ;
      private String Ddo_jc_provideraddresss_Filteredtext_get ;
      private String Ddo_jc_provideraddresss_Selectedvalue_get ;
      private String Ddo_jc_providerphone_Activeeventkey ;
      private String Ddo_jc_providerphone_Filteredtext_get ;
      private String Ddo_jc_providerphone_Selectedvalue_get ;
      private String Ddo_jc_provideruser_Activeeventkey ;
      private String Ddo_jc_provideruser_Filteredtext_get ;
      private String Ddo_jc_provideruser_Selectedvalue_get ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_31_idx="0001" ;
      private String AV33TFJC_ProviderPhone ;
      private String AV34TFJC_ProviderPhone_Sel ;
      private String AV68Pgmname ;
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
      private String Ddo_jc_providerid_Caption ;
      private String Ddo_jc_providerid_Tooltip ;
      private String Ddo_jc_providerid_Cls ;
      private String Ddo_jc_providerid_Filteredtext_set ;
      private String Ddo_jc_providerid_Filteredtextto_set ;
      private String Ddo_jc_providerid_Dropdownoptionstype ;
      private String Ddo_jc_providerid_Titlecontrolidtoreplace ;
      private String Ddo_jc_providerid_Sortedstatus ;
      private String Ddo_jc_providerid_Filtertype ;
      private String Ddo_jc_providerid_Sortasc ;
      private String Ddo_jc_providerid_Sortdsc ;
      private String Ddo_jc_providerid_Cleanfilter ;
      private String Ddo_jc_providerid_Rangefilterfrom ;
      private String Ddo_jc_providerid_Rangefilterto ;
      private String Ddo_jc_providerid_Searchbuttontext ;
      private String Ddo_jc_providername_Caption ;
      private String Ddo_jc_providername_Tooltip ;
      private String Ddo_jc_providername_Cls ;
      private String Ddo_jc_providername_Filteredtext_set ;
      private String Ddo_jc_providername_Selectedvalue_set ;
      private String Ddo_jc_providername_Dropdownoptionstype ;
      private String Ddo_jc_providername_Titlecontrolidtoreplace ;
      private String Ddo_jc_providername_Sortedstatus ;
      private String Ddo_jc_providername_Filtertype ;
      private String Ddo_jc_providername_Datalisttype ;
      private String Ddo_jc_providername_Datalistproc ;
      private String Ddo_jc_providername_Sortasc ;
      private String Ddo_jc_providername_Sortdsc ;
      private String Ddo_jc_providername_Loadingdata ;
      private String Ddo_jc_providername_Cleanfilter ;
      private String Ddo_jc_providername_Noresultsfound ;
      private String Ddo_jc_providername_Searchbuttontext ;
      private String Ddo_jc_providershortname_Caption ;
      private String Ddo_jc_providershortname_Tooltip ;
      private String Ddo_jc_providershortname_Cls ;
      private String Ddo_jc_providershortname_Filteredtext_set ;
      private String Ddo_jc_providershortname_Selectedvalue_set ;
      private String Ddo_jc_providershortname_Dropdownoptionstype ;
      private String Ddo_jc_providershortname_Titlecontrolidtoreplace ;
      private String Ddo_jc_providershortname_Sortedstatus ;
      private String Ddo_jc_providershortname_Filtertype ;
      private String Ddo_jc_providershortname_Datalisttype ;
      private String Ddo_jc_providershortname_Datalistproc ;
      private String Ddo_jc_providershortname_Sortasc ;
      private String Ddo_jc_providershortname_Sortdsc ;
      private String Ddo_jc_providershortname_Loadingdata ;
      private String Ddo_jc_providershortname_Cleanfilter ;
      private String Ddo_jc_providershortname_Noresultsfound ;
      private String Ddo_jc_providershortname_Searchbuttontext ;
      private String Ddo_jc_provideraddresss_Caption ;
      private String Ddo_jc_provideraddresss_Tooltip ;
      private String Ddo_jc_provideraddresss_Cls ;
      private String Ddo_jc_provideraddresss_Filteredtext_set ;
      private String Ddo_jc_provideraddresss_Selectedvalue_set ;
      private String Ddo_jc_provideraddresss_Dropdownoptionstype ;
      private String Ddo_jc_provideraddresss_Titlecontrolidtoreplace ;
      private String Ddo_jc_provideraddresss_Sortedstatus ;
      private String Ddo_jc_provideraddresss_Filtertype ;
      private String Ddo_jc_provideraddresss_Datalisttype ;
      private String Ddo_jc_provideraddresss_Datalistproc ;
      private String Ddo_jc_provideraddresss_Sortasc ;
      private String Ddo_jc_provideraddresss_Sortdsc ;
      private String Ddo_jc_provideraddresss_Loadingdata ;
      private String Ddo_jc_provideraddresss_Cleanfilter ;
      private String Ddo_jc_provideraddresss_Noresultsfound ;
      private String Ddo_jc_provideraddresss_Searchbuttontext ;
      private String Ddo_jc_providerphone_Caption ;
      private String Ddo_jc_providerphone_Tooltip ;
      private String Ddo_jc_providerphone_Cls ;
      private String Ddo_jc_providerphone_Filteredtext_set ;
      private String Ddo_jc_providerphone_Selectedvalue_set ;
      private String Ddo_jc_providerphone_Dropdownoptionstype ;
      private String Ddo_jc_providerphone_Titlecontrolidtoreplace ;
      private String Ddo_jc_providerphone_Sortedstatus ;
      private String Ddo_jc_providerphone_Filtertype ;
      private String Ddo_jc_providerphone_Datalisttype ;
      private String Ddo_jc_providerphone_Datalistproc ;
      private String Ddo_jc_providerphone_Sortasc ;
      private String Ddo_jc_providerphone_Sortdsc ;
      private String Ddo_jc_providerphone_Loadingdata ;
      private String Ddo_jc_providerphone_Cleanfilter ;
      private String Ddo_jc_providerphone_Noresultsfound ;
      private String Ddo_jc_providerphone_Searchbuttontext ;
      private String Ddo_jc_provideruser_Caption ;
      private String Ddo_jc_provideruser_Tooltip ;
      private String Ddo_jc_provideruser_Cls ;
      private String Ddo_jc_provideruser_Filteredtext_set ;
      private String Ddo_jc_provideruser_Selectedvalue_set ;
      private String Ddo_jc_provideruser_Dropdownoptionstype ;
      private String Ddo_jc_provideruser_Titlecontrolidtoreplace ;
      private String Ddo_jc_provideruser_Sortedstatus ;
      private String Ddo_jc_provideruser_Filtertype ;
      private String Ddo_jc_provideruser_Datalisttype ;
      private String Ddo_jc_provideruser_Datalistproc ;
      private String Ddo_jc_provideruser_Sortasc ;
      private String Ddo_jc_provideruser_Sortdsc ;
      private String Ddo_jc_provideruser_Loadingdata ;
      private String Ddo_jc_provideruser_Cleanfilter ;
      private String Ddo_jc_provideruser_Noresultsfound ;
      private String Ddo_jc_provideruser_Searchbuttontext ;
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
      private String edtJC_ProviderID_Title ;
      private String edtJC_ProviderName_Title ;
      private String edtJC_ProviderShortName_Title ;
      private String edtJC_ProviderAddresss_Title ;
      private String edtJC_ProviderPhone_Title ;
      private String edtJC_ProviderUser_Title ;
      private String subGrid_Header ;
      private String edtavDisplay_Link ;
      private String edtavDisplay_Tooltiptext ;
      private String edtavUpdate_Link ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavDelete_Link ;
      private String edtavDelete_Tooltiptext ;
      private String edtJC_ProviderName_Link ;
      private String A162JC_ProviderPhone ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_jc_providerid_Internalname ;
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
      private String edtavTfjc_providerid_Internalname ;
      private String edtavTfjc_providerid_Jsonclick ;
      private String edtavTfjc_providerid_to_Internalname ;
      private String edtavTfjc_providerid_to_Jsonclick ;
      private String edtavTfjc_providername_Internalname ;
      private String edtavTfjc_providername_Jsonclick ;
      private String edtavTfjc_providername_sel_Internalname ;
      private String edtavTfjc_providername_sel_Jsonclick ;
      private String edtavTfjc_providershortname_Internalname ;
      private String edtavTfjc_providershortname_Jsonclick ;
      private String edtavTfjc_providershortname_sel_Internalname ;
      private String edtavTfjc_providershortname_sel_Jsonclick ;
      private String edtavTfjc_provideraddresss_Internalname ;
      private String edtavTfjc_provideraddresss_sel_Internalname ;
      private String edtavTfjc_providerphone_Internalname ;
      private String edtavTfjc_providerphone_Jsonclick ;
      private String edtavTfjc_providerphone_sel_Internalname ;
      private String edtavTfjc_providerphone_sel_Jsonclick ;
      private String edtavTfjc_provideruser_Internalname ;
      private String edtavTfjc_provideruser_Jsonclick ;
      private String edtavTfjc_provideruser_sel_Internalname ;
      private String edtavTfjc_provideruser_sel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDisplay_Internalname ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String edtJC_ProviderID_Internalname ;
      private String edtJC_ProviderName_Internalname ;
      private String edtJC_ProviderShortName_Internalname ;
      private String edtJC_ProviderAddresss_Internalname ;
      private String edtJC_ProviderPhone_Internalname ;
      private String edtJC_ProviderUser_Internalname ;
      private String scmdbuf ;
      private String lV61JC_ProviderWWDS_9_Tfjc_providerphone ;
      private String AV62JC_ProviderWWDS_10_Tfjc_providerphone_sel ;
      private String AV61JC_ProviderWWDS_9_Tfjc_providerphone ;
      private String sGXsfl_31_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtJC_ProviderID_Jsonclick ;
      private String edtJC_ProviderName_Jsonclick ;
      private String edtJC_ProviderShortName_Jsonclick ;
      private String edtJC_ProviderAddresss_Jsonclick ;
      private String gxphoneLink ;
      private String edtJC_ProviderPhone_Jsonclick ;
      private String edtJC_ProviderUser_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV14OrderedDsc ;
      private bool AV47IsAuthorized_Update ;
      private bool AV49IsAuthorized_Delete ;
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
      private bool Ddo_jc_providerid_Includesortasc ;
      private bool Ddo_jc_providerid_Includesortdsc ;
      private bool Ddo_jc_providerid_Includefilter ;
      private bool Ddo_jc_providerid_Filterisrange ;
      private bool Ddo_jc_providerid_Includedatalist ;
      private bool Ddo_jc_providername_Includesortasc ;
      private bool Ddo_jc_providername_Includesortdsc ;
      private bool Ddo_jc_providername_Includefilter ;
      private bool Ddo_jc_providername_Filterisrange ;
      private bool Ddo_jc_providername_Includedatalist ;
      private bool Ddo_jc_providershortname_Includesortasc ;
      private bool Ddo_jc_providershortname_Includesortdsc ;
      private bool Ddo_jc_providershortname_Includefilter ;
      private bool Ddo_jc_providershortname_Filterisrange ;
      private bool Ddo_jc_providershortname_Includedatalist ;
      private bool Ddo_jc_provideraddresss_Includesortasc ;
      private bool Ddo_jc_provideraddresss_Includesortdsc ;
      private bool Ddo_jc_provideraddresss_Includefilter ;
      private bool Ddo_jc_provideraddresss_Filterisrange ;
      private bool Ddo_jc_provideraddresss_Includedatalist ;
      private bool Ddo_jc_providerphone_Includesortasc ;
      private bool Ddo_jc_providerphone_Includesortdsc ;
      private bool Ddo_jc_providerphone_Includefilter ;
      private bool Ddo_jc_providerphone_Filterisrange ;
      private bool Ddo_jc_providerphone_Includedatalist ;
      private bool Ddo_jc_provideruser_Includesortasc ;
      private bool Ddo_jc_provideruser_Includesortdsc ;
      private bool Ddo_jc_provideruser_Includefilter ;
      private bool Ddo_jc_provideruser_Filterisrange ;
      private bool Ddo_jc_provideruser_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_31_Refreshing=false ;
      private bool n89JC_ProviderName ;
      private bool n160JC_ProviderShortName ;
      private bool n161JC_ProviderAddresss ;
      private bool n162JC_ProviderPhone ;
      private bool n163JC_ProviderUser ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV50TempBoolean ;
      private bool GXt_boolean2 ;
      private bool AV45Display_IsBlob ;
      private bool AV46Update_IsBlob ;
      private bool AV48Delete_IsBlob ;
      private String AV21TFJC_ProviderName ;
      private String AV22TFJC_ProviderName_Sel ;
      private String AV25TFJC_ProviderShortName ;
      private String AV26TFJC_ProviderShortName_Sel ;
      private String AV29TFJC_ProviderAddresss ;
      private String AV30TFJC_ProviderAddresss_Sel ;
      private String AV37TFJC_ProviderUser ;
      private String AV38TFJC_ProviderUser_Sel ;
      private String AV19ddo_JC_ProviderIDTitleControlIdToReplace ;
      private String AV23ddo_JC_ProviderNameTitleControlIdToReplace ;
      private String AV27ddo_JC_ProviderShortNameTitleControlIdToReplace ;
      private String AV31ddo_JC_ProviderAddresssTitleControlIdToReplace ;
      private String AV35ddo_JC_ProviderPhoneTitleControlIdToReplace ;
      private String AV39ddo_JC_ProviderUserTitleControlIdToReplace ;
      private String A89JC_ProviderName ;
      private String A160JC_ProviderShortName ;
      private String A161JC_ProviderAddresss ;
      private String A163JC_ProviderUser ;
      private String AV65Display_GXI ;
      private String AV66Update_GXI ;
      private String AV67Delete_GXI ;
      private String lV55JC_ProviderWWDS_3_Tfjc_providername ;
      private String lV57JC_ProviderWWDS_5_Tfjc_providershortname ;
      private String lV59JC_ProviderWWDS_7_Tfjc_provideraddresss ;
      private String lV63JC_ProviderWWDS_11_Tfjc_provideruser ;
      private String AV56JC_ProviderWWDS_4_Tfjc_providername_sel ;
      private String AV55JC_ProviderWWDS_3_Tfjc_providername ;
      private String AV58JC_ProviderWWDS_6_Tfjc_providershortname_sel ;
      private String AV57JC_ProviderWWDS_5_Tfjc_providershortname ;
      private String AV60JC_ProviderWWDS_8_Tfjc_provideraddresss_sel ;
      private String AV59JC_ProviderWWDS_7_Tfjc_provideraddresss ;
      private String AV64JC_ProviderWWDS_12_Tfjc_provideruser_sel ;
      private String AV63JC_ProviderWWDS_11_Tfjc_provideruser ;
      private String AV45Display ;
      private String AV46Update ;
      private String AV48Delete ;
      private IGxSession AV15Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_jc_providerid ;
      private GXUserControl ucDdo_jc_providername ;
      private GXUserControl ucDdo_jc_providershortname ;
      private GXUserControl ucDdo_jc_provideraddresss ;
      private GXUserControl ucDdo_jc_providerphone ;
      private GXUserControl ucDdo_jc_provideruser ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H008I2_A163JC_ProviderUser ;
      private bool[] H008I2_n163JC_ProviderUser ;
      private String[] H008I2_A162JC_ProviderPhone ;
      private bool[] H008I2_n162JC_ProviderPhone ;
      private String[] H008I2_A161JC_ProviderAddresss ;
      private bool[] H008I2_n161JC_ProviderAddresss ;
      private String[] H008I2_A160JC_ProviderShortName ;
      private bool[] H008I2_n160JC_ProviderShortName ;
      private String[] H008I2_A89JC_ProviderName ;
      private bool[] H008I2_n89JC_ProviderName ;
      private long[] H008I2_A87JC_ProviderID ;
      private long[] H008I3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV16JC_ProviderIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV20JC_ProviderNameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV24JC_ProviderShortNameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV28JC_ProviderAddresssTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV32JC_ProviderPhoneTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV36JC_ProviderUserTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV11GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV12GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV40DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class jc_providerww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H008I2( IGxContext context ,
                                             long AV53JC_ProviderWWDS_1_Tfjc_providerid ,
                                             long AV54JC_ProviderWWDS_2_Tfjc_providerid_to ,
                                             String AV56JC_ProviderWWDS_4_Tfjc_providername_sel ,
                                             String AV55JC_ProviderWWDS_3_Tfjc_providername ,
                                             String AV58JC_ProviderWWDS_6_Tfjc_providershortname_sel ,
                                             String AV57JC_ProviderWWDS_5_Tfjc_providershortname ,
                                             String AV60JC_ProviderWWDS_8_Tfjc_provideraddresss_sel ,
                                             String AV59JC_ProviderWWDS_7_Tfjc_provideraddresss ,
                                             String AV62JC_ProviderWWDS_10_Tfjc_providerphone_sel ,
                                             String AV61JC_ProviderWWDS_9_Tfjc_providerphone ,
                                             String AV64JC_ProviderWWDS_12_Tfjc_provideruser_sel ,
                                             String AV63JC_ProviderWWDS_11_Tfjc_provideruser ,
                                             long A87JC_ProviderID ,
                                             String A89JC_ProviderName ,
                                             String A160JC_ProviderShortName ,
                                             String A161JC_ProviderAddresss ,
                                             String A162JC_ProviderPhone ,
                                             String A163JC_ProviderUser ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [15] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [JC_ProviderUser], [JC_ProviderPhone], [JC_ProviderAddresss], [JC_ProviderShortName], [JC_ProviderName], [JC_ProviderID]";
         sFromString = " FROM [JC_Provider] WITH (NOLOCK)";
         sOrderString = "";
         if ( ! (0==AV53JC_ProviderWWDS_1_Tfjc_providerid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderID] >= @AV53JC_ProviderWWDS_1_Tfjc_providerid)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderID] >= @AV53JC_ProviderWWDS_1_Tfjc_providerid)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ! (0==AV54JC_ProviderWWDS_2_Tfjc_providerid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderID] <= @AV54JC_ProviderWWDS_2_Tfjc_providerid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderID] <= @AV54JC_ProviderWWDS_2_Tfjc_providerid_to)";
            }
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV56JC_ProviderWWDS_4_Tfjc_providername_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55JC_ProviderWWDS_3_Tfjc_providername)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderName] like @lV55JC_ProviderWWDS_3_Tfjc_providername)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderName] like @lV55JC_ProviderWWDS_3_Tfjc_providername)";
            }
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56JC_ProviderWWDS_4_Tfjc_providername_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderName] = @AV56JC_ProviderWWDS_4_Tfjc_providername_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderName] = @AV56JC_ProviderWWDS_4_Tfjc_providername_sel)";
            }
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV58JC_ProviderWWDS_6_Tfjc_providershortname_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV57JC_ProviderWWDS_5_Tfjc_providershortname)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderShortName] like @lV57JC_ProviderWWDS_5_Tfjc_providershortname)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderShortName] like @lV57JC_ProviderWWDS_5_Tfjc_providershortname)";
            }
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV58JC_ProviderWWDS_6_Tfjc_providershortname_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderShortName] = @AV58JC_ProviderWWDS_6_Tfjc_providershortname_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderShortName] = @AV58JC_ProviderWWDS_6_Tfjc_providershortname_sel)";
            }
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV60JC_ProviderWWDS_8_Tfjc_provideraddresss_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59JC_ProviderWWDS_7_Tfjc_provideraddresss)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderAddresss] like @lV59JC_ProviderWWDS_7_Tfjc_provideraddresss)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderAddresss] like @lV59JC_ProviderWWDS_7_Tfjc_provideraddresss)";
            }
         }
         else
         {
            GXv_int3[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60JC_ProviderWWDS_8_Tfjc_provideraddresss_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderAddresss] = @AV60JC_ProviderWWDS_8_Tfjc_provideraddresss_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderAddresss] = @AV60JC_ProviderWWDS_8_Tfjc_provideraddresss_sel)";
            }
         }
         else
         {
            GXv_int3[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV62JC_ProviderWWDS_10_Tfjc_providerphone_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV61JC_ProviderWWDS_9_Tfjc_providerphone)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderPhone] like @lV61JC_ProviderWWDS_9_Tfjc_providerphone)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderPhone] like @lV61JC_ProviderWWDS_9_Tfjc_providerphone)";
            }
         }
         else
         {
            GXv_int3[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV62JC_ProviderWWDS_10_Tfjc_providerphone_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderPhone] = @AV62JC_ProviderWWDS_10_Tfjc_providerphone_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderPhone] = @AV62JC_ProviderWWDS_10_Tfjc_providerphone_sel)";
            }
         }
         else
         {
            GXv_int3[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV64JC_ProviderWWDS_12_Tfjc_provideruser_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV63JC_ProviderWWDS_11_Tfjc_provideruser)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderUser] like @lV63JC_ProviderWWDS_11_Tfjc_provideruser)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderUser] like @lV63JC_ProviderWWDS_11_Tfjc_provideruser)";
            }
         }
         else
         {
            GXv_int3[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV64JC_ProviderWWDS_12_Tfjc_provideruser_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderUser] = @AV64JC_ProviderWWDS_12_Tfjc_provideruser_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderUser] = @AV64JC_ProviderWWDS_12_Tfjc_provideruser_sel)";
            }
         }
         else
         {
            GXv_int3[11] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [JC_ProviderID]";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [JC_ProviderID] DESC";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [JC_ProviderName]";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [JC_ProviderName] DESC";
         }
         else if ( ( AV13OrderedBy == 3 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [JC_ProviderShortName]";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [JC_ProviderShortName] DESC";
         }
         else if ( ( AV13OrderedBy == 4 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [JC_ProviderAddresss]";
         }
         else if ( ( AV13OrderedBy == 4 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [JC_ProviderAddresss] DESC";
         }
         else if ( ( AV13OrderedBy == 5 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [JC_ProviderPhone]";
         }
         else if ( ( AV13OrderedBy == 5 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [JC_ProviderPhone] DESC";
         }
         else if ( ( AV13OrderedBy == 6 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [JC_ProviderUser]";
         }
         else if ( ( AV13OrderedBy == 6 ) && ( AV14OrderedDsc ) )
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

      protected Object[] conditional_H008I3( IGxContext context ,
                                             long AV53JC_ProviderWWDS_1_Tfjc_providerid ,
                                             long AV54JC_ProviderWWDS_2_Tfjc_providerid_to ,
                                             String AV56JC_ProviderWWDS_4_Tfjc_providername_sel ,
                                             String AV55JC_ProviderWWDS_3_Tfjc_providername ,
                                             String AV58JC_ProviderWWDS_6_Tfjc_providershortname_sel ,
                                             String AV57JC_ProviderWWDS_5_Tfjc_providershortname ,
                                             String AV60JC_ProviderWWDS_8_Tfjc_provideraddresss_sel ,
                                             String AV59JC_ProviderWWDS_7_Tfjc_provideraddresss ,
                                             String AV62JC_ProviderWWDS_10_Tfjc_providerphone_sel ,
                                             String AV61JC_ProviderWWDS_9_Tfjc_providerphone ,
                                             String AV64JC_ProviderWWDS_12_Tfjc_provideruser_sel ,
                                             String AV63JC_ProviderWWDS_11_Tfjc_provideruser ,
                                             long A87JC_ProviderID ,
                                             String A89JC_ProviderName ,
                                             String A160JC_ProviderShortName ,
                                             String A161JC_ProviderAddresss ,
                                             String A162JC_ProviderPhone ,
                                             String A163JC_ProviderUser ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [12] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [JC_Provider] WITH (NOLOCK)";
         if ( ! (0==AV53JC_ProviderWWDS_1_Tfjc_providerid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderID] >= @AV53JC_ProviderWWDS_1_Tfjc_providerid)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderID] >= @AV53JC_ProviderWWDS_1_Tfjc_providerid)";
            }
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ! (0==AV54JC_ProviderWWDS_2_Tfjc_providerid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderID] <= @AV54JC_ProviderWWDS_2_Tfjc_providerid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderID] <= @AV54JC_ProviderWWDS_2_Tfjc_providerid_to)";
            }
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV56JC_ProviderWWDS_4_Tfjc_providername_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55JC_ProviderWWDS_3_Tfjc_providername)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderName] like @lV55JC_ProviderWWDS_3_Tfjc_providername)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderName] like @lV55JC_ProviderWWDS_3_Tfjc_providername)";
            }
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56JC_ProviderWWDS_4_Tfjc_providername_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderName] = @AV56JC_ProviderWWDS_4_Tfjc_providername_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderName] = @AV56JC_ProviderWWDS_4_Tfjc_providername_sel)";
            }
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV58JC_ProviderWWDS_6_Tfjc_providershortname_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV57JC_ProviderWWDS_5_Tfjc_providershortname)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderShortName] like @lV57JC_ProviderWWDS_5_Tfjc_providershortname)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderShortName] like @lV57JC_ProviderWWDS_5_Tfjc_providershortname)";
            }
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV58JC_ProviderWWDS_6_Tfjc_providershortname_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderShortName] = @AV58JC_ProviderWWDS_6_Tfjc_providershortname_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderShortName] = @AV58JC_ProviderWWDS_6_Tfjc_providershortname_sel)";
            }
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV60JC_ProviderWWDS_8_Tfjc_provideraddresss_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59JC_ProviderWWDS_7_Tfjc_provideraddresss)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderAddresss] like @lV59JC_ProviderWWDS_7_Tfjc_provideraddresss)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderAddresss] like @lV59JC_ProviderWWDS_7_Tfjc_provideraddresss)";
            }
         }
         else
         {
            GXv_int5[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60JC_ProviderWWDS_8_Tfjc_provideraddresss_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderAddresss] = @AV60JC_ProviderWWDS_8_Tfjc_provideraddresss_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderAddresss] = @AV60JC_ProviderWWDS_8_Tfjc_provideraddresss_sel)";
            }
         }
         else
         {
            GXv_int5[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV62JC_ProviderWWDS_10_Tfjc_providerphone_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV61JC_ProviderWWDS_9_Tfjc_providerphone)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderPhone] like @lV61JC_ProviderWWDS_9_Tfjc_providerphone)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderPhone] like @lV61JC_ProviderWWDS_9_Tfjc_providerphone)";
            }
         }
         else
         {
            GXv_int5[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV62JC_ProviderWWDS_10_Tfjc_providerphone_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderPhone] = @AV62JC_ProviderWWDS_10_Tfjc_providerphone_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderPhone] = @AV62JC_ProviderWWDS_10_Tfjc_providerphone_sel)";
            }
         }
         else
         {
            GXv_int5[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV64JC_ProviderWWDS_12_Tfjc_provideruser_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV63JC_ProviderWWDS_11_Tfjc_provideruser)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderUser] like @lV63JC_ProviderWWDS_11_Tfjc_provideruser)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderUser] like @lV63JC_ProviderWWDS_11_Tfjc_provideruser)";
            }
         }
         else
         {
            GXv_int5[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV64JC_ProviderWWDS_12_Tfjc_provideruser_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderUser] = @AV64JC_ProviderWWDS_12_Tfjc_provideruser_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderUser] = @AV64JC_ProviderWWDS_12_Tfjc_provideruser_sel)";
            }
         }
         else
         {
            GXv_int5[11] = 1;
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
         else if ( ( AV13OrderedBy == 5 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 5 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 6 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 6 ) && ( AV14OrderedDsc ) )
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
                     return conditional_H008I2(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (long)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (short)dynConstraints[18] , (bool)dynConstraints[19] );
               case 1 :
                     return conditional_H008I3(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (long)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (short)dynConstraints[18] , (bool)dynConstraints[19] );
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
          Object[] prmH008I2 ;
          prmH008I2 = new Object[] {
          new Object[] {"@AV53JC_ProviderWWDS_1_Tfjc_providerid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV54JC_ProviderWWDS_2_Tfjc_providerid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV55JC_ProviderWWDS_3_Tfjc_providername",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@AV56JC_ProviderWWDS_4_Tfjc_providername_sel",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@lV57JC_ProviderWWDS_5_Tfjc_providershortname",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV58JC_ProviderWWDS_6_Tfjc_providershortname_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV59JC_ProviderWWDS_7_Tfjc_provideraddresss",SqlDbType.NVarChar,1024,0} ,
          new Object[] {"@AV60JC_ProviderWWDS_8_Tfjc_provideraddresss_sel",SqlDbType.NVarChar,1024,0} ,
          new Object[] {"@lV61JC_ProviderWWDS_9_Tfjc_providerphone",SqlDbType.NChar,20,0} ,
          new Object[] {"@AV62JC_ProviderWWDS_10_Tfjc_providerphone_sel",SqlDbType.NChar,20,0} ,
          new Object[] {"@lV63JC_ProviderWWDS_11_Tfjc_provideruser",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV64JC_ProviderWWDS_12_Tfjc_provideruser_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH008I3 ;
          prmH008I3 = new Object[] {
          new Object[] {"@AV53JC_ProviderWWDS_1_Tfjc_providerid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV54JC_ProviderWWDS_2_Tfjc_providerid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV55JC_ProviderWWDS_3_Tfjc_providername",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@AV56JC_ProviderWWDS_4_Tfjc_providername_sel",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@lV57JC_ProviderWWDS_5_Tfjc_providershortname",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV58JC_ProviderWWDS_6_Tfjc_providershortname_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV59JC_ProviderWWDS_7_Tfjc_provideraddresss",SqlDbType.NVarChar,1024,0} ,
          new Object[] {"@AV60JC_ProviderWWDS_8_Tfjc_provideraddresss_sel",SqlDbType.NVarChar,1024,0} ,
          new Object[] {"@lV61JC_ProviderWWDS_9_Tfjc_providerphone",SqlDbType.NChar,20,0} ,
          new Object[] {"@AV62JC_ProviderWWDS_10_Tfjc_providerphone_sel",SqlDbType.NChar,20,0} ,
          new Object[] {"@lV63JC_ProviderWWDS_11_Tfjc_provideruser",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV64JC_ProviderWWDS_12_Tfjc_provideruser_sel",SqlDbType.NVarChar,40,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H008I2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH008I2,11,0,true,false )
             ,new CursorDef("H008I3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH008I3,1,0,true,false )
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
                   stmt.SetParameter(sIdx, (long)parms[15]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[16]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[24]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[25]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[26]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[27]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[28]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[29]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[12]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[13]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                return;
       }
    }

 }

}
