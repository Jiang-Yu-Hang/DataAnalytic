/*
               File: BR_PathologyBR_Pathology_OtherWC
        Description: BR_Pathology BR_Pathology_Other WC
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:17.60
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
   public class br_pathologybr_pathology_otherwc : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_pathologybr_pathology_otherwc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
            context.SetDefaultTheme("WorkWithPlusTheme");
         }
      }

      public br_pathologybr_pathology_otherwc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_PathologyID )
      {
         this.AV8BR_PathologyID = aP0_BR_PathologyID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      public override void SetPrefix( String sPPrefix )
      {
         sPrefix = sPPrefix;
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "dyncomponent") == 0 )
               {
                  setAjaxEventMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  nDynComponent = 1;
                  sCompPrefix = GetNextPar( );
                  sSFPrefix = GetNextPar( );
                  AV8BR_PathologyID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_PathologyID), 18, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(long)AV8BR_PathologyID});
                  componentstart();
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix);
                  componentdraw();
                  context.httpAjaxContext.ajax_rspEndCmp();
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
                  sPrefix = GetNextPar( );
                  edtavMindel_Visible = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavMindel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavMindel_Visible), 5, 0)), !bGXsfl_28_Refreshing);
                  edtavMyedit_Visible = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavMyedit_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavMyedit_Visible), 5, 0)), !bGXsfl_28_Refreshing);
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
                  AV14OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV15OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
                  AV8BR_PathologyID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace = GetNextPar( );
                  AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace = GetNextPar( );
                  AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace = GetNextPar( );
                  AV24ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace = GetNextPar( );
                  AV50Pgmname = GetNextPar( );
                  edtavMindel_Visible = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavMindel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavMindel_Visible), 5, 0)), !bGXsfl_28_Refreshing);
                  edtavMyedit_Visible = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavMyedit_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavMyedit_Visible), 5, 0)), !bGXsfl_28_Refreshing);
                  sPrefix = GetNextPar( );
                  init_default_properties( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_PathologyID, AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace, AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace, AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace, AV24ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace, AV50Pgmname, sPrefix) ;
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
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.IsLocalStorageSupported( ) )
            {
               context.PushCurrentUrl();
            }
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
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               ValidateSpaRequest();
            }
            PA5G2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV50Pgmname = "BR_PathologyBR_Pathology_OtherWC";
               context.Gx_err = 0;
               WS5G2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  if ( nDynComponent == 0 )
                  {
                     throw new System.Net.WebException("WebComponent is not allowed to run") ;
                  }
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
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
            context.WriteHtmlText( "<title>") ;
            context.SendWebValue( "BR_Pathology BR_Pathology_Other WC") ;
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
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 127771), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxcfg.js", "?20202279381786", false);
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
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.CloseHtmlHeader();
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
            FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
            context.WriteHtmlText( "<body ") ;
            bodyStyle = "";
            if ( nGXWrapped == 0 )
            {
               bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
            }
            context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
            context.WriteHtmlText( FormProcess+">") ;
            context.skipLines(1);
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_pathologybr_pathology_otherwc.aspx") + "?" + UrlEncode("" +AV8BR_PathologyID)+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, "FORM", "Class", "form-horizontal Form", true);
         }
         else
         {
            bool toggleHtmlOutput = isOutputEnabled( ) ;
            if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableOutput();
               }
            }
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gxwebcomponent-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            if ( toggleHtmlOutput )
            {
               if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableOutput();
                  }
               }
            }
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14OrderedBy), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vORDEREDDSC", StringUtil.BoolToStr( AV15OrderedDsc));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_GXsfl_28", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_28), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV28GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV30GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV29GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vDDO_TITLESETTINGSICONS", AV25DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vDDO_TITLESETTINGSICONS", AV25DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA", AV17BR_Pathology_Other_BioTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA", AV17BR_Pathology_Other_BioTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA", AV19BR_Pathology_Other_BioNumTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA", AV19BR_Pathology_Other_BioNumTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA", AV21BR_Pathology_Other_BioNumUnitTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA", AV21BR_Pathology_Other_BioNumUnitTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA", AV23BR_Pathology_Other_AbnIndTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA", AV23BR_Pathology_Other_AbnIndTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV8BR_PathologyID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV8BR_PathologyID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vPGMNAME", StringUtil.RTrim( AV50Pgmname));
         GxWebStd.gx_hidden_field( context, sPrefix+"vBR_PATHOLOGYID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8BR_PathologyID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Width", StringUtil.RTrim( Dvpanel_tableheader_Width));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Cls", StringUtil.RTrim( Dvpanel_tableheader_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Title", StringUtil.RTrim( Dvpanel_tableheader_Title));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Collapsible", StringUtil.BoolToStr( Dvpanel_tableheader_Collapsible));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Collapsed", StringUtil.BoolToStr( Dvpanel_tableheader_Collapsed));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Autowidth", StringUtil.BoolToStr( Dvpanel_tableheader_Autowidth));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Autoheight", StringUtil.BoolToStr( Dvpanel_tableheader_Autoheight));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_tableheader_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Iconposition", StringUtil.RTrim( Dvpanel_tableheader_Iconposition));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Autoscroll", StringUtil.BoolToStr( Dvpanel_tableheader_Autoscroll));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Class", StringUtil.RTrim( Gridpaginationbar_Class));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Previous", StringUtil.RTrim( Gridpaginationbar_Previous));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Next", StringUtil.RTrim( Gridpaginationbar_Next));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Caption", StringUtil.RTrim( Gridpaginationbar_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Showfirst", StringUtil.BoolToStr( Gridpaginationbar_Showfirst));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Showprevious", StringUtil.BoolToStr( Gridpaginationbar_Showprevious));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Shownext", StringUtil.BoolToStr( Gridpaginationbar_Shownext));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Showlast", StringUtil.BoolToStr( Gridpaginationbar_Showlast));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Pagestoshow", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Pagestoshow), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Pagingbuttonsposition", StringUtil.RTrim( Gridpaginationbar_Pagingbuttonsposition));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Pagingcaptionposition", StringUtil.RTrim( Gridpaginationbar_Pagingcaptionposition));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Emptygridclass", StringUtil.RTrim( Gridpaginationbar_Emptygridclass));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselector", StringUtil.BoolToStr( Gridpaginationbar_Rowsperpageselector));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageoptions", StringUtil.RTrim( Gridpaginationbar_Rowsperpageoptions));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Emptygridcaption", StringUtil.RTrim( Gridpaginationbar_Emptygridcaption));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpagecaption", StringUtil.RTrim( Gridpaginationbar_Rowsperpagecaption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIO_Caption", StringUtil.RTrim( Ddo_br_pathology_other_bio_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIO_Tooltip", StringUtil.RTrim( Ddo_br_pathology_other_bio_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIO_Cls", StringUtil.RTrim( Ddo_br_pathology_other_bio_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIO_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_other_bio_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIO_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_other_bio_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIO_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_other_bio_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIO_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_other_bio_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIO_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_other_bio_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIO_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_other_bio_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIO_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_other_bio_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIO_Sortasc", StringUtil.RTrim( Ddo_br_pathology_other_bio_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIO_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_other_bio_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIO_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_other_bio_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUM_Caption", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUM_Tooltip", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUM_Cls", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUM_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUM_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUM_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_other_bionum_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUM_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_other_bionum_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUM_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUM_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_other_bionum_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUM_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_other_bionum_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUM_Sortasc", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUM_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUM_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Caption", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Tooltip", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Cls", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_other_bionumunit_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_other_bionumunit_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_other_bionumunit_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_other_bionumunit_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Sortasc", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNIND_Caption", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNIND_Tooltip", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNIND_Cls", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNIND_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNIND_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNIND_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_other_abnind_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNIND_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_other_abnind_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNIND_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNIND_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_other_abnind_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNIND_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_other_abnind_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNIND_Sortasc", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNIND_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNIND_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIO_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_bio_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUM_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNIND_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"vMINDEL_Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavMindel_Visible), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vMYEDIT_Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavMyedit_Visible), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIO_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_bio_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUM_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_bionum_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_bionumunit_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNIND_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_other_abnind_Activeeventkey));
      }

      protected void RenderHtmlCloseForm5G2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_pathologybr_pathology_otherwc.js", "?20202279382064", false);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GX_FocusControl", GX_FocusControl);
         define_styles( ) ;
         SendSecurityToken(sPrefix);
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            SendAjaxEncryptionKey();
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
         else
         {
            SendWebComponentState();
            context.WriteHtmlText( "</div>") ;
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
         }
      }

      public override String GetPgmname( )
      {
         return "BR_PathologyBR_Pathology_OtherWC" ;
      }

      public override String GetPgmdesc( )
      {
         return "BR_Pathology BR_Pathology_Other WC" ;
      }

      protected void WB5G0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               RenderHtmlHeaders( ) ;
            }
            RenderHtmlOpenForm( ) ;
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_pathologybr_pathology_otherwc.aspx");
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
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablegridheader_Internalname, 1, 0, "px", 0, "px", "Table100x100", "left", "top", "", "", "div");
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
            ucDvpanel_tableheader.Render(context, "dvelop.gxbootstrap.panel", Dvpanel_tableheader_Internalname, sPrefix+"DVPANEL_TABLEHEADERContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+sPrefix+"DVPANEL_TABLEHEADERContainer"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_tableheader_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableheader_Internalname, divTableheader_Visible, 0, "px", 0, "px", "", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'" + sPrefix + "',false,'',0)\"";
            ClassString = "Button ButtonColor";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(28), 2, 0)+","+"null"+");", "新增", bttBtninsert_Jsonclick, 5, "插入", "", StyleString, ClassString, bttBtninsert_Visible, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+sPrefix+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_PathologyBR_Pathology_OtherWC.htm");
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
               context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"DivS\" data-gxgridid=\"28\">") ;
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavMyedit_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavMindel_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "病理学其他信息主键") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Pathology_Other_Bio_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_Other_Bio_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_Other_Bio_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Pathology_Other_BioNum_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_Other_BioNum_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_Other_BioNum_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Pathology_Other_BioNumUnit_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_Other_BioNumUnit_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_Other_BioNumUnit_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Pathology_Other_AbnInd_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_Other_AbnInd_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_Other_AbnInd_Title) ;
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
               GridContainer.AddObjectProperty("CmpContext", sPrefix);
               GridContainer.AddObjectProperty("InMasterPage", "false");
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV35Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV40myedit));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavMyedit_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavMyedit_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV44mindel));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavMindel_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavMindel_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A288BR_Pathology_OtherID), 18, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A289BR_Pathology_Other_Bio);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_Other_Bio_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_Other_Bio_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A290BR_Pathology_Other_BioNum, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_Other_BioNum_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_Other_BioNum_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A291BR_Pathology_Other_BioNumUnit);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_Other_BioNumUnit_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_Other_BioNumUnit_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A295BR_Pathology_Other_AbnInd);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_Other_AbnInd_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_Other_AbnInd_Titleformat), 4, 0, ".", "")));
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
               context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid(sPrefix+"_"+"Grid", GridContainer);
               if ( ! isAjaxCallMode( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData", GridContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData"+"V", GridContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+sPrefix+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV28GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV30GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV29GridPageSize);
            ucGridpaginationbar.Render(context, "dvelop.dvpaginationbar", Gridpaginationbar_Internalname, sPrefix+"GRIDPAGINATIONBARContainer");
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
            ucDdo_br_pathology_other_bio.SetProperty("Caption", Ddo_br_pathology_other_bio_Caption);
            ucDdo_br_pathology_other_bio.SetProperty("Tooltip", Ddo_br_pathology_other_bio_Tooltip);
            ucDdo_br_pathology_other_bio.SetProperty("Cls", Ddo_br_pathology_other_bio_Cls);
            ucDdo_br_pathology_other_bio.SetProperty("DropDownOptionsType", Ddo_br_pathology_other_bio_Dropdownoptionstype);
            ucDdo_br_pathology_other_bio.SetProperty("IncludeSortASC", Ddo_br_pathology_other_bio_Includesortasc);
            ucDdo_br_pathology_other_bio.SetProperty("IncludeSortDSC", Ddo_br_pathology_other_bio_Includesortdsc);
            ucDdo_br_pathology_other_bio.SetProperty("IncludeFilter", Ddo_br_pathology_other_bio_Includefilter);
            ucDdo_br_pathology_other_bio.SetProperty("IncludeDataList", Ddo_br_pathology_other_bio_Includedatalist);
            ucDdo_br_pathology_other_bio.SetProperty("SortASC", Ddo_br_pathology_other_bio_Sortasc);
            ucDdo_br_pathology_other_bio.SetProperty("SortDSC", Ddo_br_pathology_other_bio_Sortdsc);
            ucDdo_br_pathology_other_bio.SetProperty("SearchButtonText", Ddo_br_pathology_other_bio_Searchbuttontext);
            ucDdo_br_pathology_other_bio.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_br_pathology_other_bio.SetProperty("DropDownOptionsData", AV17BR_Pathology_Other_BioTitleFilterData);
            ucDdo_br_pathology_other_bio.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_other_bio_Internalname, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIOContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Internalname, AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"", 0, edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyBR_Pathology_OtherWC.htm");
            /* User Defined Control */
            ucDdo_br_pathology_other_bionum.SetProperty("Caption", Ddo_br_pathology_other_bionum_Caption);
            ucDdo_br_pathology_other_bionum.SetProperty("Tooltip", Ddo_br_pathology_other_bionum_Tooltip);
            ucDdo_br_pathology_other_bionum.SetProperty("Cls", Ddo_br_pathology_other_bionum_Cls);
            ucDdo_br_pathology_other_bionum.SetProperty("DropDownOptionsType", Ddo_br_pathology_other_bionum_Dropdownoptionstype);
            ucDdo_br_pathology_other_bionum.SetProperty("IncludeSortASC", Ddo_br_pathology_other_bionum_Includesortasc);
            ucDdo_br_pathology_other_bionum.SetProperty("IncludeSortDSC", Ddo_br_pathology_other_bionum_Includesortdsc);
            ucDdo_br_pathology_other_bionum.SetProperty("IncludeFilter", Ddo_br_pathology_other_bionum_Includefilter);
            ucDdo_br_pathology_other_bionum.SetProperty("IncludeDataList", Ddo_br_pathology_other_bionum_Includedatalist);
            ucDdo_br_pathology_other_bionum.SetProperty("SortASC", Ddo_br_pathology_other_bionum_Sortasc);
            ucDdo_br_pathology_other_bionum.SetProperty("SortDSC", Ddo_br_pathology_other_bionum_Sortdsc);
            ucDdo_br_pathology_other_bionum.SetProperty("SearchButtonText", Ddo_br_pathology_other_bionum_Searchbuttontext);
            ucDdo_br_pathology_other_bionum.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_br_pathology_other_bionum.SetProperty("DropDownOptionsData", AV19BR_Pathology_Other_BioNumTitleFilterData);
            ucDdo_br_pathology_other_bionum.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_other_bionum_Internalname, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_other_bionumtitlecontrolidtoreplace_Internalname, AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,47);\"", 0, edtavDdo_br_pathology_other_bionumtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyBR_Pathology_OtherWC.htm");
            /* User Defined Control */
            ucDdo_br_pathology_other_bionumunit.SetProperty("Caption", Ddo_br_pathology_other_bionumunit_Caption);
            ucDdo_br_pathology_other_bionumunit.SetProperty("Tooltip", Ddo_br_pathology_other_bionumunit_Tooltip);
            ucDdo_br_pathology_other_bionumunit.SetProperty("Cls", Ddo_br_pathology_other_bionumunit_Cls);
            ucDdo_br_pathology_other_bionumunit.SetProperty("DropDownOptionsType", Ddo_br_pathology_other_bionumunit_Dropdownoptionstype);
            ucDdo_br_pathology_other_bionumunit.SetProperty("IncludeSortASC", Ddo_br_pathology_other_bionumunit_Includesortasc);
            ucDdo_br_pathology_other_bionumunit.SetProperty("IncludeSortDSC", Ddo_br_pathology_other_bionumunit_Includesortdsc);
            ucDdo_br_pathology_other_bionumunit.SetProperty("IncludeFilter", Ddo_br_pathology_other_bionumunit_Includefilter);
            ucDdo_br_pathology_other_bionumunit.SetProperty("IncludeDataList", Ddo_br_pathology_other_bionumunit_Includedatalist);
            ucDdo_br_pathology_other_bionumunit.SetProperty("SortASC", Ddo_br_pathology_other_bionumunit_Sortasc);
            ucDdo_br_pathology_other_bionumunit.SetProperty("SortDSC", Ddo_br_pathology_other_bionumunit_Sortdsc);
            ucDdo_br_pathology_other_bionumunit.SetProperty("SearchButtonText", Ddo_br_pathology_other_bionumunit_Searchbuttontext);
            ucDdo_br_pathology_other_bionumunit.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_br_pathology_other_bionumunit.SetProperty("DropDownOptionsData", AV21BR_Pathology_Other_BioNumUnitTitleFilterData);
            ucDdo_br_pathology_other_bionumunit.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_other_bionumunit_Internalname, sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNITContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_other_bionumunittitlecontrolidtoreplace_Internalname, AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", 0, edtavDdo_br_pathology_other_bionumunittitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyBR_Pathology_OtherWC.htm");
            /* User Defined Control */
            ucDdo_br_pathology_other_abnind.SetProperty("Caption", Ddo_br_pathology_other_abnind_Caption);
            ucDdo_br_pathology_other_abnind.SetProperty("Tooltip", Ddo_br_pathology_other_abnind_Tooltip);
            ucDdo_br_pathology_other_abnind.SetProperty("Cls", Ddo_br_pathology_other_abnind_Cls);
            ucDdo_br_pathology_other_abnind.SetProperty("DropDownOptionsType", Ddo_br_pathology_other_abnind_Dropdownoptionstype);
            ucDdo_br_pathology_other_abnind.SetProperty("IncludeSortASC", Ddo_br_pathology_other_abnind_Includesortasc);
            ucDdo_br_pathology_other_abnind.SetProperty("IncludeSortDSC", Ddo_br_pathology_other_abnind_Includesortdsc);
            ucDdo_br_pathology_other_abnind.SetProperty("IncludeFilter", Ddo_br_pathology_other_abnind_Includefilter);
            ucDdo_br_pathology_other_abnind.SetProperty("IncludeDataList", Ddo_br_pathology_other_abnind_Includedatalist);
            ucDdo_br_pathology_other_abnind.SetProperty("SortASC", Ddo_br_pathology_other_abnind_Sortasc);
            ucDdo_br_pathology_other_abnind.SetProperty("SortDSC", Ddo_br_pathology_other_abnind_Sortdsc);
            ucDdo_br_pathology_other_abnind.SetProperty("SearchButtonText", Ddo_br_pathology_other_abnind_Searchbuttontext);
            ucDdo_br_pathology_other_abnind.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_br_pathology_other_abnind.SetProperty("DropDownOptionsData", AV23BR_Pathology_Other_AbnIndTitleFilterData);
            ucDdo_br_pathology_other_abnind.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_other_abnind_Internalname, sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNINDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_other_abnindtitlecontrolidtoreplace_Internalname, AV24ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", 0, edtavDdo_br_pathology_other_abnindtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyBR_Pathology_OtherWC.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_PathologyID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A226BR_PathologyID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A226BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_PathologyID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_PathologyID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_PathologyBR_Pathology_OtherWC.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, sPrefix+"WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV14OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_PathologyBR_Pathology_OtherWC.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV15OrderedDsc), StringUtil.BoolToStr( AV15OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_PathologyBR_Pathology_OtherWC.htm");
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
                  context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid(sPrefix+"_"+"Grid", GridContainer);
                  if ( ! isAjaxCallMode( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData", GridContainer.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData"+"V", GridContainer.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+sPrefix+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START5G2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
               Form.Meta.addItem("description", "BR_Pathology BR_Pathology_Other WC", 0) ;
            }
            context.wjLoc = "";
            context.nUserReturn = 0;
            context.wbHandled = 0;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               sXEvt = cgiGet( "_EventName");
               if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
               {
               }
            }
         }
         wbErr = false;
         if ( ( StringUtil.Len( sPrefix) == 0 ) || ( nDraw == 1 ) )
         {
            if ( nDoneStart == 0 )
            {
               STRUP5G0( ) ;
            }
         }
      }

      protected void WS5G2( )
      {
         START5G2( ) ;
         EVT5G2( ) ;
      }

      protected void EVT5G2( )
      {
         sXEvt = cgiGet( "_EventName");
         if ( ( ( ( StringUtil.Len( sPrefix) == 0 ) ) || ( StringUtil.StringSearch( sXEvt, sPrefix, 1) > 0 ) ) && ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               if ( context.wbHandled == 0 )
               {
                  if ( StringUtil.Len( sPrefix) == 0 )
                  {
                     sEvt = cgiGet( "_EventName");
                     EvtGridId = cgiGet( "_EventGridId");
                     EvtRowId = cgiGet( "_EventRowId");
                  }
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
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5G0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEPAGE") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5G0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E115G2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5G0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E125G2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_OTHER_BIO.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5G0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E135G2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_OTHER_BIONUM.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5G0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E145G2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5G0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E155G2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_OTHER_ABNIND.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5G0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E165G2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5G0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: 'DoInsert' */
                                    E175G2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5G0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Internalname;
                                    context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                 }
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5G0( ) ;
                              }
                              nGXsfl_28_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
                              SubsflControlProps_282( ) ;
                              AV35Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV35Display)) ? AV47Display_GXI : context.convertURL( context.PathToRelativeUrl( AV35Display))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV35Display), true);
                              AV40myedit = cgiGet( edtavMyedit_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavMyedit_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV40myedit)) ? AV48Myedit_GXI : context.convertURL( context.PathToRelativeUrl( AV40myedit))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavMyedit_Internalname, "SrcSet", context.GetImageSrcSet( AV40myedit), true);
                              AV44mindel = cgiGet( edtavMindel_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavMindel_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV44mindel)) ? AV49Mindel_GXI : context.convertURL( context.PathToRelativeUrl( AV44mindel))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavMindel_Internalname, "SrcSet", context.GetImageSrcSet( AV44mindel), true);
                              A288BR_Pathology_OtherID = (long)(context.localUtil.CToN( cgiGet( edtBR_Pathology_OtherID_Internalname), ".", ","));
                              A289BR_Pathology_Other_Bio = cgiGet( edtBR_Pathology_Other_Bio_Internalname);
                              n289BR_Pathology_Other_Bio = false;
                              A290BR_Pathology_Other_BioNum = context.localUtil.CToN( cgiGet( edtBR_Pathology_Other_BioNum_Internalname), ".", ",");
                              n290BR_Pathology_Other_BioNum = false;
                              A291BR_Pathology_Other_BioNumUnit = cgiGet( edtBR_Pathology_Other_BioNumUnit_Internalname);
                              n291BR_Pathology_Other_BioNumUnit = false;
                              A295BR_Pathology_Other_AbnInd = cgiGet( edtBR_Pathology_Other_AbnInd_Internalname);
                              n295BR_Pathology_Other_AbnInd = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: Start */
                                          E185G2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: Refresh */
                                          E195G2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          E205G2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          if ( ! wbErr )
                                          {
                                             Rfr0gs = false;
                                             /* Set Refresh If Orderedby Changed */
                                             if ( ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV14OrderedBy )) )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Ordereddsc Changed */
                                             if ( StringUtil.StrToBool( cgiGet( sPrefix+"GXH_vORDEREDDSC")) != AV15OrderedDsc )
                                             {
                                                Rfr0gs = true;
                                             }
                                             if ( ! Rfr0gs )
                                             {
                                             }
                                             dynload_actions( ) ;
                                          }
                                       }
                                    }
                                    /* No code required for Cancel button. It is implemented as the Reset button. */
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                                    {
                                       STRUP5G0( ) ;
                                    }
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                       }
                                    }
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

      protected void WE5G2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm5G2( ) ;
            }
         }
      }

      protected void PA5G2( )
      {
         if ( nDonePA == 0 )
         {
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               initialize_properties( ) ;
            }
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
               {
                  gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
               }
            }
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableJsOutput();
               }
            }
            init_web_controls( ) ;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( toggleJsOutput )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableJsOutput();
                  }
               }
            }
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
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
                                       short AV14OrderedBy ,
                                       bool AV15OrderedDsc ,
                                       long AV8BR_PathologyID ,
                                       String AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace ,
                                       String AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace ,
                                       String AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace ,
                                       String AV24ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace ,
                                       String AV50Pgmname ,
                                       String sPrefix )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF5G2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_BR_PATHOLOGY_OTHERID", GetSecureSignedToken( sPrefix, context.localUtil.Format( (decimal)(A288BR_Pathology_OtherID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, sPrefix+"BR_PATHOLOGY_OTHERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A288BR_Pathology_OtherID), 18, 0, ".", "")));
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
         RF5G2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV50Pgmname = "BR_PathologyBR_Pathology_OtherWC";
         context.Gx_err = 0;
      }

      protected void RF5G2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 28;
         /* Execute user event: Refresh */
         E195G2 ();
         nGXsfl_28_idx = 1;
         sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
         SubsflControlProps_282( ) ;
         bGXsfl_28_Refreshing = true;
         GridContainer.AddObjectProperty("GridName", "Grid");
         GridContainer.AddObjectProperty("CmpContext", sPrefix);
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
                                                 AV14OrderedBy ,
                                                 AV15OrderedDsc ,
                                                 A226BR_PathologyID ,
                                                 AV8BR_PathologyID } ,
                                                 new int[]{
                                                 TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.LONG
                                                 }
            } ) ;
            /* Using cursor H005G2 */
            pr_default.execute(0, new Object[] {AV8BR_PathologyID, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_28_idx = 1;
            sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
            SubsflControlProps_282( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A226BR_PathologyID = H005G2_A226BR_PathologyID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
               n226BR_PathologyID = H005G2_n226BR_PathologyID[0];
               A295BR_Pathology_Other_AbnInd = H005G2_A295BR_Pathology_Other_AbnInd[0];
               n295BR_Pathology_Other_AbnInd = H005G2_n295BR_Pathology_Other_AbnInd[0];
               A291BR_Pathology_Other_BioNumUnit = H005G2_A291BR_Pathology_Other_BioNumUnit[0];
               n291BR_Pathology_Other_BioNumUnit = H005G2_n291BR_Pathology_Other_BioNumUnit[0];
               A290BR_Pathology_Other_BioNum = H005G2_A290BR_Pathology_Other_BioNum[0];
               n290BR_Pathology_Other_BioNum = H005G2_n290BR_Pathology_Other_BioNum[0];
               A289BR_Pathology_Other_Bio = H005G2_A289BR_Pathology_Other_Bio[0];
               n289BR_Pathology_Other_Bio = H005G2_n289BR_Pathology_Other_Bio[0];
               A288BR_Pathology_OtherID = H005G2_A288BR_Pathology_OtherID[0];
               E205G2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 28;
            WB5G0( ) ;
         }
         bGXsfl_28_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes5G2( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_BR_PATHOLOGY_OTHERID"+"_"+sGXsfl_28_idx, GetSecureSignedToken( sPrefix+sGXsfl_28_idx, context.localUtil.Format( (decimal)(A288BR_Pathology_OtherID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
                                              AV14OrderedBy ,
                                              AV15OrderedDsc ,
                                              A226BR_PathologyID ,
                                              AV8BR_PathologyID } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.LONG
                                              }
         } ) ;
         /* Using cursor H005G3 */
         pr_default.execute(1, new Object[] {AV8BR_PathologyID});
         GRID_nRecordCount = H005G3_AGRID_nRecordCount[0];
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
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_PathologyID, AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace, AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace, AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace, AV24ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace, AV50Pgmname, sPrefix) ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_PathologyID, AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace, AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace, AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace, AV24ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace, AV50Pgmname, sPrefix) ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_PathologyID, AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace, AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace, AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace, AV24ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace, AV50Pgmname, sPrefix) ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_PathologyID, AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace, AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace, AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace, AV24ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace, AV50Pgmname, sPrefix) ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_PathologyID, AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace, AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace, AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace, AV24ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace, AV50Pgmname, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP5G0( )
      {
         /* Before Start, stand alone formulas. */
         AV50Pgmname = "BR_PathologyBR_Pathology_OtherWC";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E185G2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vDDO_TITLESETTINGSICONS"), AV25DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA"), AV17BR_Pathology_Other_BioTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA"), AV19BR_Pathology_Other_BioNumTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA"), AV21BR_Pathology_Other_BioNumUnitTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA"), AV23BR_Pathology_Other_AbnIndTitleFilterData);
            /* Read variables values. */
            AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace", AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace);
            AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_other_bionumtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace", AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace);
            AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_other_bionumunittitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace", AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace);
            AV24ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_other_abnindtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV24ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace", AV24ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace);
            A226BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( edtBR_PathologyID_Internalname), ".", ","));
            n226BR_PathologyID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDEREDBY");
               GX_FocusControl = edtavOrderedby_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV14OrderedBy = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            }
            else
            {
               AV14OrderedBy = (short)(context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            }
            AV15OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            /* Read saved values. */
            nRC_GXsfl_28 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_GXsfl_28"), ".", ","));
            AV28GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDCURRENTPAGE"), ".", ","));
            AV30GridRecordCount = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDRECORDCOUNT"), ".", ","));
            AV29GridPageSize = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDPAGESIZE"), ".", ","));
            wcpOAV8BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV8BR_PathologyID"), ".", ","));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_nFirstRecordOnPage"), ".", ","));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_nEOF"), ".", ","));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Dvpanel_tableheader_Width = cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Width");
            Dvpanel_tableheader_Cls = cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Cls");
            Dvpanel_tableheader_Title = cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Title");
            Dvpanel_tableheader_Collapsible = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Collapsible"));
            Dvpanel_tableheader_Collapsed = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Collapsed"));
            Dvpanel_tableheader_Autowidth = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Autowidth"));
            Dvpanel_tableheader_Autoheight = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Autoheight"));
            Dvpanel_tableheader_Showcollapseicon = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Showcollapseicon"));
            Dvpanel_tableheader_Iconposition = cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Iconposition");
            Dvpanel_tableheader_Autoscroll = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Autoscroll"));
            Gridpaginationbar_Class = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Class");
            Gridpaginationbar_Previous = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Previous");
            Gridpaginationbar_Next = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Next");
            Gridpaginationbar_Caption = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Caption");
            Gridpaginationbar_Showfirst = StringUtil.StrToBool( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Showfirst"));
            Gridpaginationbar_Showprevious = StringUtil.StrToBool( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Showprevious"));
            Gridpaginationbar_Shownext = StringUtil.StrToBool( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Shownext"));
            Gridpaginationbar_Showlast = StringUtil.StrToBool( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Showlast"));
            Gridpaginationbar_Pagestoshow = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Pagestoshow"), ".", ","));
            Gridpaginationbar_Pagingbuttonsposition = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Pagingbuttonsposition");
            Gridpaginationbar_Pagingcaptionposition = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Pagingcaptionposition");
            Gridpaginationbar_Emptygridclass = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Emptygridclass");
            Gridpaginationbar_Rowsperpageselector = StringUtil.StrToBool( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselector"));
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Gridpaginationbar_Rowsperpageoptions = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageoptions");
            Gridpaginationbar_Emptygridcaption = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Emptygridcaption");
            Gridpaginationbar_Rowsperpagecaption = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpagecaption");
            Ddo_br_pathology_other_bio_Caption = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIO_Caption");
            Ddo_br_pathology_other_bio_Tooltip = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIO_Tooltip");
            Ddo_br_pathology_other_bio_Cls = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIO_Cls");
            Ddo_br_pathology_other_bio_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIO_Dropdownoptionstype");
            Ddo_br_pathology_other_bio_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIO_Titlecontrolidtoreplace");
            Ddo_br_pathology_other_bio_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIO_Includesortasc"));
            Ddo_br_pathology_other_bio_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIO_Includesortdsc"));
            Ddo_br_pathology_other_bio_Sortedstatus = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIO_Sortedstatus");
            Ddo_br_pathology_other_bio_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIO_Includefilter"));
            Ddo_br_pathology_other_bio_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIO_Includedatalist"));
            Ddo_br_pathology_other_bio_Sortasc = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIO_Sortasc");
            Ddo_br_pathology_other_bio_Sortdsc = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIO_Sortdsc");
            Ddo_br_pathology_other_bio_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIO_Searchbuttontext");
            Ddo_br_pathology_other_bionum_Caption = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUM_Caption");
            Ddo_br_pathology_other_bionum_Tooltip = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUM_Tooltip");
            Ddo_br_pathology_other_bionum_Cls = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUM_Cls");
            Ddo_br_pathology_other_bionum_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUM_Dropdownoptionstype");
            Ddo_br_pathology_other_bionum_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUM_Titlecontrolidtoreplace");
            Ddo_br_pathology_other_bionum_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUM_Includesortasc"));
            Ddo_br_pathology_other_bionum_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUM_Includesortdsc"));
            Ddo_br_pathology_other_bionum_Sortedstatus = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUM_Sortedstatus");
            Ddo_br_pathology_other_bionum_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUM_Includefilter"));
            Ddo_br_pathology_other_bionum_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUM_Includedatalist"));
            Ddo_br_pathology_other_bionum_Sortasc = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUM_Sortasc");
            Ddo_br_pathology_other_bionum_Sortdsc = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUM_Sortdsc");
            Ddo_br_pathology_other_bionum_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUM_Searchbuttontext");
            Ddo_br_pathology_other_bionumunit_Caption = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Caption");
            Ddo_br_pathology_other_bionumunit_Tooltip = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Tooltip");
            Ddo_br_pathology_other_bionumunit_Cls = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Cls");
            Ddo_br_pathology_other_bionumunit_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Dropdownoptionstype");
            Ddo_br_pathology_other_bionumunit_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Titlecontrolidtoreplace");
            Ddo_br_pathology_other_bionumunit_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Includesortasc"));
            Ddo_br_pathology_other_bionumunit_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Includesortdsc"));
            Ddo_br_pathology_other_bionumunit_Sortedstatus = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Sortedstatus");
            Ddo_br_pathology_other_bionumunit_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Includefilter"));
            Ddo_br_pathology_other_bionumunit_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Includedatalist"));
            Ddo_br_pathology_other_bionumunit_Sortasc = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Sortasc");
            Ddo_br_pathology_other_bionumunit_Sortdsc = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Sortdsc");
            Ddo_br_pathology_other_bionumunit_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Searchbuttontext");
            Ddo_br_pathology_other_abnind_Caption = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNIND_Caption");
            Ddo_br_pathology_other_abnind_Tooltip = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNIND_Tooltip");
            Ddo_br_pathology_other_abnind_Cls = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNIND_Cls");
            Ddo_br_pathology_other_abnind_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNIND_Dropdownoptionstype");
            Ddo_br_pathology_other_abnind_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNIND_Titlecontrolidtoreplace");
            Ddo_br_pathology_other_abnind_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNIND_Includesortasc"));
            Ddo_br_pathology_other_abnind_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNIND_Includesortdsc"));
            Ddo_br_pathology_other_abnind_Sortedstatus = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNIND_Sortedstatus");
            Ddo_br_pathology_other_abnind_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNIND_Includefilter"));
            Ddo_br_pathology_other_abnind_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNIND_Includedatalist"));
            Ddo_br_pathology_other_abnind_Sortasc = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNIND_Sortasc");
            Ddo_br_pathology_other_abnind_Sortdsc = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNIND_Sortdsc");
            Ddo_br_pathology_other_abnind_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNIND_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_pathology_other_bio_Activeeventkey = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIO_Activeeventkey");
            Ddo_br_pathology_other_bionum_Activeeventkey = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUM_Activeeventkey");
            Ddo_br_pathology_other_bionumunit_Activeeventkey = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT_Activeeventkey");
            Ddo_br_pathology_other_abnind_Activeeventkey = cgiGet( sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNIND_Activeeventkey");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV14OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( sPrefix+"GXH_vORDEREDDSC")) != AV15OrderedDsc )
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
         E185G2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E185G2( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_br_pathology_other_bio_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_Other_Bio";
         ucDdo_br_pathology_other_bio.SendProperty(context, sPrefix, false, Ddo_br_pathology_other_bio_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_other_bio_Titlecontrolidtoreplace);
         AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace = Ddo_br_pathology_other_bio_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace", AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace);
         edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_other_bionum_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_Other_BioNum";
         ucDdo_br_pathology_other_bionum.SendProperty(context, sPrefix, false, Ddo_br_pathology_other_bionum_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_other_bionum_Titlecontrolidtoreplace);
         AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace = Ddo_br_pathology_other_bionum_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace", AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace);
         edtavDdo_br_pathology_other_bionumtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_pathology_other_bionumtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_other_bionumtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_other_bionumunit_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_Other_BioNumUnit";
         ucDdo_br_pathology_other_bionumunit.SendProperty(context, sPrefix, false, Ddo_br_pathology_other_bionumunit_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_other_bionumunit_Titlecontrolidtoreplace);
         AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace = Ddo_br_pathology_other_bionumunit_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace", AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace);
         edtavDdo_br_pathology_other_bionumunittitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_pathology_other_bionumunittitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_other_bionumunittitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_other_abnind_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_Other_AbnInd";
         ucDdo_br_pathology_other_abnind.SendProperty(context, sPrefix, false, Ddo_br_pathology_other_abnind_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_other_abnind_Titlecontrolidtoreplace);
         AV24ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace = Ddo_br_pathology_other_abnind_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV24ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace", AV24ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace);
         edtavDdo_br_pathology_other_abnindtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_pathology_other_abnindtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_other_abnindtitlecontrolidtoreplace_Visible), 5, 0)), true);
         edtBR_PathologyID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_PathologyID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_PathologyID_Visible), 5, 0)), true);
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
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavOrderedby_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrderedby_Visible), 5, 0)), true);
         if ( AV14OrderedBy < 1 )
         {
            AV14OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
         }
         edtavOrdereddsc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavOrdereddsc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrdereddsc_Visible), 5, 0)), true);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV25DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV25DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, sPrefix, false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
         AV38tEncounterType = StringUtil.Trim( AV39WebSession.Get("Br_EncounterType"));
         if ( StringUtil.StrCmp(AV38tEncounterType, "check") == 0 )
         {
            divTableheader_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divTableheader_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divTableheader_Visible), 5, 0)), true);
            edtavMindel_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavMindel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavMindel_Visible), 5, 0)), !bGXsfl_28_Refreshing);
            edtavMyedit_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavMyedit_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavMyedit_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         }
      }

      protected void E195G2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV17BR_Pathology_Other_BioTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19BR_Pathology_Other_BioNumTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_Pathology_Other_BioNumUnitTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV23BR_Pathology_Other_AbnIndTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
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
         edtBR_Pathology_Other_Bio_Titleformat = 2;
         edtBR_Pathology_Other_Bio_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "肿瘤标志物", AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Pathology_Other_Bio_Internalname, "Title", edtBR_Pathology_Other_Bio_Title, !bGXsfl_28_Refreshing);
         edtBR_Pathology_Other_BioNum_Titleformat = 2;
         edtBR_Pathology_Other_BioNum_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "定量结果", AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Pathology_Other_BioNum_Internalname, "Title", edtBR_Pathology_Other_BioNum_Title, !bGXsfl_28_Refreshing);
         edtBR_Pathology_Other_BioNumUnit_Titleformat = 2;
         edtBR_Pathology_Other_BioNumUnit_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "定量结果单位", AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Pathology_Other_BioNumUnit_Internalname, "Title", edtBR_Pathology_Other_BioNumUnit_Title, !bGXsfl_28_Refreshing);
         edtBR_Pathology_Other_AbnInd_Titleformat = 2;
         edtBR_Pathology_Other_AbnInd_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "结果提示", AV24ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Pathology_Other_AbnInd_Internalname, "Title", edtBR_Pathology_Other_AbnInd_Title, !bGXsfl_28_Refreshing);
         AV28GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV28GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28GridCurrentPage), 10, 0)));
         AV29GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV29GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29GridPageSize), 10, 0)));
         AV30GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV30GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_Pathology_Other_BioTitleFilterData", AV17BR_Pathology_Other_BioTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV19BR_Pathology_Other_BioNumTitleFilterData", AV19BR_Pathology_Other_BioNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Pathology_Other_BioNumUnitTitleFilterData", AV21BR_Pathology_Other_BioNumUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_Pathology_Other_AbnIndTitleFilterData", AV23BR_Pathology_Other_AbnIndTitleFilterData);
      }

      protected void E115G2( )
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
            AV27PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV27PageToGo) ;
         }
      }

      protected void E125G2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E135G2( )
      {
         /* Ddo_br_pathology_other_bio_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_other_bio_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV14OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_pathology_other_bio_Sortedstatus = "ASC";
            ucDdo_br_pathology_other_bio.SendProperty(context, sPrefix, false, Ddo_br_pathology_other_bio_Internalname, "SortedStatus", Ddo_br_pathology_other_bio_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_other_bio_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV14OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_pathology_other_bio_Sortedstatus = "DSC";
            ucDdo_br_pathology_other_bio.SendProperty(context, sPrefix, false, Ddo_br_pathology_other_bio_Internalname, "SortedStatus", Ddo_br_pathology_other_bio_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_Pathology_Other_BioTitleFilterData", AV17BR_Pathology_Other_BioTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV19BR_Pathology_Other_BioNumTitleFilterData", AV19BR_Pathology_Other_BioNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Pathology_Other_BioNumUnitTitleFilterData", AV21BR_Pathology_Other_BioNumUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_Pathology_Other_AbnIndTitleFilterData", AV23BR_Pathology_Other_AbnIndTitleFilterData);
      }

      protected void E145G2( )
      {
         /* Ddo_br_pathology_other_bionum_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_other_bionum_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV14OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_pathology_other_bionum_Sortedstatus = "ASC";
            ucDdo_br_pathology_other_bionum.SendProperty(context, sPrefix, false, Ddo_br_pathology_other_bionum_Internalname, "SortedStatus", Ddo_br_pathology_other_bionum_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_other_bionum_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV14OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_pathology_other_bionum_Sortedstatus = "DSC";
            ucDdo_br_pathology_other_bionum.SendProperty(context, sPrefix, false, Ddo_br_pathology_other_bionum_Internalname, "SortedStatus", Ddo_br_pathology_other_bionum_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_Pathology_Other_BioTitleFilterData", AV17BR_Pathology_Other_BioTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV19BR_Pathology_Other_BioNumTitleFilterData", AV19BR_Pathology_Other_BioNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Pathology_Other_BioNumUnitTitleFilterData", AV21BR_Pathology_Other_BioNumUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_Pathology_Other_AbnIndTitleFilterData", AV23BR_Pathology_Other_AbnIndTitleFilterData);
      }

      protected void E155G2( )
      {
         /* Ddo_br_pathology_other_bionumunit_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_other_bionumunit_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV14OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_pathology_other_bionumunit_Sortedstatus = "ASC";
            ucDdo_br_pathology_other_bionumunit.SendProperty(context, sPrefix, false, Ddo_br_pathology_other_bionumunit_Internalname, "SortedStatus", Ddo_br_pathology_other_bionumunit_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_other_bionumunit_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV14OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_pathology_other_bionumunit_Sortedstatus = "DSC";
            ucDdo_br_pathology_other_bionumunit.SendProperty(context, sPrefix, false, Ddo_br_pathology_other_bionumunit_Internalname, "SortedStatus", Ddo_br_pathology_other_bionumunit_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_Pathology_Other_BioTitleFilterData", AV17BR_Pathology_Other_BioTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV19BR_Pathology_Other_BioNumTitleFilterData", AV19BR_Pathology_Other_BioNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Pathology_Other_BioNumUnitTitleFilterData", AV21BR_Pathology_Other_BioNumUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_Pathology_Other_AbnIndTitleFilterData", AV23BR_Pathology_Other_AbnIndTitleFilterData);
      }

      protected void E165G2( )
      {
         /* Ddo_br_pathology_other_abnind_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_other_abnind_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV14OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_pathology_other_abnind_Sortedstatus = "ASC";
            ucDdo_br_pathology_other_abnind.SendProperty(context, sPrefix, false, Ddo_br_pathology_other_abnind_Internalname, "SortedStatus", Ddo_br_pathology_other_abnind_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_other_abnind_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV14OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_pathology_other_abnind_Sortedstatus = "DSC";
            ucDdo_br_pathology_other_abnind.SendProperty(context, sPrefix, false, Ddo_br_pathology_other_abnind_Internalname, "SortedStatus", Ddo_br_pathology_other_abnind_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_Pathology_Other_BioTitleFilterData", AV17BR_Pathology_Other_BioTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV19BR_Pathology_Other_BioNumTitleFilterData", AV19BR_Pathology_Other_BioNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Pathology_Other_BioNumUnitTitleFilterData", AV21BR_Pathology_Other_BioNumUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_Pathology_Other_AbnIndTitleFilterData", AV23BR_Pathology_Other_AbnIndTitleFilterData);
      }

      private void E205G2( )
      {
         /* Grid_Load Routine */
         AV35Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtavDisplay_Internalname, AV35Display);
         AV47Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = formatLink("br_pathology_otherview.aspx") + "?" + UrlEncode("" +A288BR_Pathology_OtherID) + "," + UrlEncode(StringUtil.RTrim(""));
         AV40myedit = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtavMyedit_Internalname, AV40myedit);
         AV48Myedit_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavMyedit_Tooltiptext = "";
         AV44mindel = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtavMindel_Internalname, AV44mindel);
         AV49Mindel_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavMindel_Tooltiptext = "";
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

      protected void E175G2( )
      {
         /* 'DoInsert' Routine */
         if ( 1 == 0 )
         {
            CallWebObject(formatLink("br_pathology_other.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
            context.wjLocDisableFrm = 1;
         }
         CallWebObject(formatLink("br_pathology_otherinsert.aspx") + "?" + UrlEncode("" +AV8BR_PathologyID));
         context.wjLocDisableFrm = 1;
      }

      protected void S132( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean2 = AV42IsAuthorized_myedit;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Other", out  GXt_boolean2) ;
         AV42IsAuthorized_myedit = GXt_boolean2;
         if ( ! ( AV42IsAuthorized_myedit ) )
         {
            edtavMyedit_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavMyedit_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavMyedit_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         }
         GXt_boolean2 = AV37TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Other", out  GXt_boolean2) ;
         AV37TempBoolean = GXt_boolean2;
         if ( ! ( AV37TempBoolean ) )
         {
            bttBtninsert_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, bttBtninsert_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtninsert_Visible), 5, 0)), true);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV16Session.Get(AV50Pgmname+"GridState"), "") == 0 )
         {
            AV12GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV50Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV12GridState.FromXml(AV16Session.Get(AV50Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV14OrderedBy = AV12GridState.gxTpr_Orderedby;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
         AV15OrderedDsc = AV12GridState.gxTpr_Ordereddsc;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV12GridState.gxTpr_Pagesize))) )
         {
            subGrid_Rows = (int)(NumberUtil.Val( AV12GridState.gxTpr_Pagesize, "."));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         }
      }

      protected void S142( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV12GridState.FromXml(AV16Session.Get(AV50Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV12GridState.gxTpr_Orderedby = AV14OrderedBy;
         AV12GridState.gxTpr_Ordereddsc = AV15OrderedDsc;
         AV12GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV50Pgmname+"GridState",  AV12GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV10TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV10TrnContext.gxTpr_Callerobject = AV50Pgmname;
         AV10TrnContext.gxTpr_Callerondelete = true;
         AV10TrnContext.gxTpr_Callerurl = AV9HTTPRequest.ScriptName+"?"+AV9HTTPRequest.QueryString;
         AV10TrnContext.gxTpr_Transactionname = "BR_Pathology_Other";
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11TrnContextAtt.gxTpr_Attributename = "BR_PathologyID";
         AV11TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BR_PathologyID), 18, 0);
         AV10TrnContext.gxTpr_Attributes.Add(AV11TrnContextAtt, 0);
         AV16Session.Set("TrnContext", AV10TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV8BR_PathologyID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_PathologyID), 18, 0)));
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
         PA5G2( ) ;
         WS5G2( ) ;
         WE5G2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void componentbind( Object[] obj )
      {
         if ( IsUrlCreated( ) )
         {
            return  ;
         }
         sCtrlAV8BR_PathologyID = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA5G2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_pathologybr_pathology_otherwc", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA5G2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV8BR_PathologyID = Convert.ToInt64(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_PathologyID), 18, 0)));
         }
         wcpOAV8BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV8BR_PathologyID"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( AV8BR_PathologyID != wcpOAV8BR_PathologyID ) ) )
         {
            setjustcreated();
         }
         wcpOAV8BR_PathologyID = AV8BR_PathologyID;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV8BR_PathologyID = cgiGet( sPrefix+"AV8BR_PathologyID_CTRL");
         if ( StringUtil.Len( sCtrlAV8BR_PathologyID) > 0 )
         {
            AV8BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( sCtrlAV8BR_PathologyID), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_PathologyID), 18, 0)));
         }
         else
         {
            AV8BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"AV8BR_PathologyID_PARM"), ".", ","));
         }
      }

      public override void componentprocess( String sPPrefix ,
                                             String sPSFPrefix ,
                                             String sCompEvt )
      {
         sCompPrefix = sPPrefix;
         sSFPrefix = sPSFPrefix;
         sPrefix = sCompPrefix + sSFPrefix;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         INITWEB( ) ;
         nDraw = 0;
         PA5G2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS5G2( ) ;
         if ( isFullAjaxMode( ) )
         {
            componentdraw();
         }
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override void componentstart( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
      }

      protected void WCStart( )
      {
         nDraw = 1;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WS5G2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"AV8BR_PathologyID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8BR_PathologyID), 18, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV8BR_PathologyID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV8BR_PathologyID_CTRL", StringUtil.RTrim( sCtrlAV8BR_PathologyID));
         }
      }

      public override void componentdraw( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WCParametersSet( ) ;
         WE5G2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override String getstring( String sGXControl )
      {
         String sCtrlName ;
         if ( StringUtil.StrCmp(StringUtil.Substring( sGXControl, 1, 1), "&") == 0 )
         {
            sCtrlName = StringUtil.Substring( sGXControl, 2, StringUtil.Len( sGXControl)-1);
         }
         else
         {
            sCtrlName = sGXControl;
         }
         return cgiGet( sPrefix+"v"+StringUtil.Upper( sCtrlName)) ;
      }

      public override void componentjscripts( )
      {
         include_jscripts( ) ;
      }

      public override void componentthemes( )
      {
         define_styles( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279383152", true);
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
         context.AddJavascriptSource("br_pathologybr_pathology_otherwc.js", "?20202279383153", false);
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
         edtavDisplay_Internalname = sPrefix+"vDISPLAY_"+sGXsfl_28_idx;
         edtavMyedit_Internalname = sPrefix+"vMYEDIT_"+sGXsfl_28_idx;
         edtavMindel_Internalname = sPrefix+"vMINDEL_"+sGXsfl_28_idx;
         edtBR_Pathology_OtherID_Internalname = sPrefix+"BR_PATHOLOGY_OTHERID_"+sGXsfl_28_idx;
         edtBR_Pathology_Other_Bio_Internalname = sPrefix+"BR_PATHOLOGY_OTHER_BIO_"+sGXsfl_28_idx;
         edtBR_Pathology_Other_BioNum_Internalname = sPrefix+"BR_PATHOLOGY_OTHER_BIONUM_"+sGXsfl_28_idx;
         edtBR_Pathology_Other_BioNumUnit_Internalname = sPrefix+"BR_PATHOLOGY_OTHER_BIONUMUNIT_"+sGXsfl_28_idx;
         edtBR_Pathology_Other_AbnInd_Internalname = sPrefix+"BR_PATHOLOGY_OTHER_ABNIND_"+sGXsfl_28_idx;
      }

      protected void SubsflControlProps_fel_282( )
      {
         edtavDisplay_Internalname = sPrefix+"vDISPLAY_"+sGXsfl_28_fel_idx;
         edtavMyedit_Internalname = sPrefix+"vMYEDIT_"+sGXsfl_28_fel_idx;
         edtavMindel_Internalname = sPrefix+"vMINDEL_"+sGXsfl_28_fel_idx;
         edtBR_Pathology_OtherID_Internalname = sPrefix+"BR_PATHOLOGY_OTHERID_"+sGXsfl_28_fel_idx;
         edtBR_Pathology_Other_Bio_Internalname = sPrefix+"BR_PATHOLOGY_OTHER_BIO_"+sGXsfl_28_fel_idx;
         edtBR_Pathology_Other_BioNum_Internalname = sPrefix+"BR_PATHOLOGY_OTHER_BIONUM_"+sGXsfl_28_fel_idx;
         edtBR_Pathology_Other_BioNumUnit_Internalname = sPrefix+"BR_PATHOLOGY_OTHER_BIONUMUNIT_"+sGXsfl_28_fel_idx;
         edtBR_Pathology_Other_AbnInd_Internalname = sPrefix+"BR_PATHOLOGY_OTHER_ABNIND_"+sGXsfl_28_fel_idx;
      }

      protected void sendrow_282( )
      {
         SubsflControlProps_282( ) ;
         WB5G0( ) ;
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
            AV35Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV35Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV47Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV35Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV35Display)) ? AV47Display_GXI : context.PathToRelativeUrl( AV35Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV35Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavMyedit_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavMyedit_Enabled!=0)&&(edtavMyedit_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 30,'"+sPrefix+"',false,'',28)\"" : " ");
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV40myedit_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV40myedit))&&String.IsNullOrEmpty(StringUtil.RTrim( AV48Myedit_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV40myedit)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV40myedit)) ? AV48Myedit_GXI : context.PathToRelativeUrl( AV40myedit));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavMyedit_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(int)edtavMyedit_Visible,(short)1,(String)"",(String)edtavMyedit_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)7,(String)edtavMyedit_Jsonclick,(String)"'"+sPrefix+"'"+",false,"+"'"+"e215g2_client"+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV40myedit_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavMindel_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavMindel_Enabled!=0)&&(edtavMindel_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 31,'"+sPrefix+"',false,'',28)\"" : " ");
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV44mindel_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV44mindel))&&String.IsNullOrEmpty(StringUtil.RTrim( AV49Mindel_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV44mindel)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV44mindel)) ? AV49Mindel_GXI : context.PathToRelativeUrl( AV44mindel));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavMindel_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(int)edtavMindel_Visible,(short)1,(String)"",(String)edtavMindel_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)7,(String)edtavMindel_Jsonclick,(String)"'"+sPrefix+"'"+",false,"+"'"+"e225g2_client"+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV44mindel_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_OtherID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A288BR_Pathology_OtherID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A288BR_Pathology_OtherID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_OtherID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_Other_Bio_Internalname,(String)A289BR_Pathology_Other_Bio,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_Other_Bio_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_Other_BioNum_Internalname,StringUtil.LTrim( StringUtil.NToC( A290BR_Pathology_Other_BioNum, 15, 5, ".", "")),context.localUtil.Format( A290BR_Pathology_Other_BioNum, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_Other_BioNum_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs hidden-sm",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_Other_BioNumUnit_Internalname,(String)A291BR_Pathology_Other_BioNumUnit,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_Other_BioNumUnit_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs hidden-sm",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_Other_AbnInd_Internalname,(String)A295BR_Pathology_Other_AbnInd,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_Other_AbnInd_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs hidden-sm",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes5G2( ) ;
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
         bttBtninsert_Internalname = sPrefix+"BTNINSERT";
         divTableactions_Internalname = sPrefix+"TABLEACTIONS";
         divTableheader_Internalname = sPrefix+"TABLEHEADER";
         divLayout_tableheader_Internalname = sPrefix+"LAYOUT_TABLEHEADER";
         Dvpanel_tableheader_Internalname = sPrefix+"DVPANEL_TABLEHEADER";
         divHtml_dvpanel_tableheader_Internalname = sPrefix+"HTML_DVPANEL_TABLEHEADER";
         edtavDisplay_Internalname = sPrefix+"vDISPLAY";
         edtavMyedit_Internalname = sPrefix+"vMYEDIT";
         edtavMindel_Internalname = sPrefix+"vMINDEL";
         edtBR_Pathology_OtherID_Internalname = sPrefix+"BR_PATHOLOGY_OTHERID";
         edtBR_Pathology_Other_Bio_Internalname = sPrefix+"BR_PATHOLOGY_OTHER_BIO";
         edtBR_Pathology_Other_BioNum_Internalname = sPrefix+"BR_PATHOLOGY_OTHER_BIONUM";
         edtBR_Pathology_Other_BioNumUnit_Internalname = sPrefix+"BR_PATHOLOGY_OTHER_BIONUMUNIT";
         edtBR_Pathology_Other_AbnInd_Internalname = sPrefix+"BR_PATHOLOGY_OTHER_ABNIND";
         Gridpaginationbar_Internalname = sPrefix+"GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = sPrefix+"HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = sPrefix+"GRIDTABLEWITHPAGINATIONBAR";
         divTablegridheader_Internalname = sPrefix+"TABLEGRIDHEADER";
         Ddo_br_pathology_other_bio_Internalname = sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIO";
         edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_other_bionum_Internalname = sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUM";
         edtavDdo_br_pathology_other_bionumtitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_other_bionumunit_Internalname = sPrefix+"DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT";
         edtavDdo_br_pathology_other_bionumunittitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_other_abnind_Internalname = sPrefix+"DDO_BR_PATHOLOGY_OTHER_ABNIND";
         edtavDdo_br_pathology_other_abnindtitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE";
         edtBR_PathologyID_Internalname = sPrefix+"BR_PATHOLOGYID";
         Workwithplusutilities1_Internalname = sPrefix+"WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = sPrefix+"vORDEREDBY";
         edtavOrdereddsc_Internalname = sPrefix+"vORDEREDDSC";
         divHtml_bottomauxiliarcontrols_Internalname = sPrefix+"HTML_BOTTOMAUXILIARCONTROLS";
         divLayoutmaintable_Internalname = sPrefix+"LAYOUTMAINTABLE";
         Form.Internalname = sPrefix+"FORM";
         subGrid_Internalname = sPrefix+"GRID";
      }

      public override void initialize_properties( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.SetDefaultTheme("WorkWithPlusTheme");
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         init_default_properties( ) ;
         edtBR_Pathology_Other_AbnInd_Jsonclick = "";
         edtBR_Pathology_Other_BioNumUnit_Jsonclick = "";
         edtBR_Pathology_Other_BioNum_Jsonclick = "";
         edtBR_Pathology_Other_Bio_Jsonclick = "";
         edtBR_Pathology_OtherID_Jsonclick = "";
         edtavMindel_Jsonclick = "";
         edtavMindel_Enabled = 1;
         edtavMyedit_Jsonclick = "";
         edtavMyedit_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtBR_PathologyID_Jsonclick = "";
         edtBR_PathologyID_Visible = 1;
         edtavDdo_br_pathology_other_abnindtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathology_other_bionumunittitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathology_other_bionumtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavMindel_Tooltiptext = "";
         edtavMyedit_Tooltiptext = "";
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Pathology_Other_AbnInd_Titleformat = 0;
         edtBR_Pathology_Other_AbnInd_Title = "结果提示";
         edtBR_Pathology_Other_BioNumUnit_Titleformat = 0;
         edtBR_Pathology_Other_BioNumUnit_Title = "定量结果单位";
         edtBR_Pathology_Other_BioNum_Titleformat = 0;
         edtBR_Pathology_Other_BioNum_Title = "定量结果";
         edtBR_Pathology_Other_Bio_Titleformat = 0;
         edtBR_Pathology_Other_Bio_Title = "肿瘤标志物";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         bttBtninsert_Visible = 1;
         divTableheader_Visible = 1;
         Ddo_br_pathology_other_abnind_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_other_abnind_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_other_abnind_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_other_abnind_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_other_abnind_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathology_other_abnind_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_abnind_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_abnind_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_other_abnind_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_other_abnind_Cls = "ColumnSettings";
         Ddo_br_pathology_other_abnind_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_other_abnind_Caption = "";
         Ddo_br_pathology_other_bionumunit_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_other_bionumunit_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_other_bionumunit_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_other_bionumunit_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_other_bionumunit_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathology_other_bionumunit_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_bionumunit_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_bionumunit_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_other_bionumunit_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_other_bionumunit_Cls = "ColumnSettings";
         Ddo_br_pathology_other_bionumunit_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_other_bionumunit_Caption = "";
         Ddo_br_pathology_other_bionum_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_other_bionum_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_other_bionum_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_other_bionum_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_other_bionum_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathology_other_bionum_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_bionum_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_bionum_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_other_bionum_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_other_bionum_Cls = "ColumnSettings";
         Ddo_br_pathology_other_bionum_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_other_bionum_Caption = "";
         Ddo_br_pathology_other_bio_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_other_bio_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_other_bio_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_other_bio_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_other_bio_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathology_other_bio_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_bio_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_other_bio_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_other_bio_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_other_bio_Cls = "ColumnSettings";
         Ddo_br_pathology_other_bio_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_other_bio_Caption = "";
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
         subGrid_Rows = 0;
         edtavMyedit_Visible = -1;
         edtavMindel_Visible = -1;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV8BR_PathologyID',fld:'vBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'edtavMindel_Visible',ctrl:'vMINDEL',prop:'Visible'},{av:'edtavMyedit_Visible',ctrl:'vMYEDIT',prop:'Visible'},{av:'sPrefix'},{av:'AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV50Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV17BR_Pathology_Other_BioTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA',pic:''},{av:'AV19BR_Pathology_Other_BioNumTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA',pic:''},{av:'AV21BR_Pathology_Other_BioNumUnitTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA',pic:''},{av:'AV23BR_Pathology_Other_AbnIndTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_Other_Bio_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Bio_Title',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Title'},{av:'edtBR_Pathology_Other_BioNum_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNum_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Title'},{av:'edtBR_Pathology_Other_BioNumUnit_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNumUnit_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Title'},{av:'edtBR_Pathology_Other_AbnInd_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Titleformat'},{av:'edtBR_Pathology_Other_AbnInd_Title',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Title'},{av:'AV28GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV29GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV30GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavMyedit_Visible',ctrl:'vMYEDIT',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E115G2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_PathologyID',fld:'vBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50Pgmname',fld:'vPGMNAME',pic:''},{av:'edtavMindel_Visible',ctrl:'vMINDEL',prop:'Visible'},{av:'edtavMyedit_Visible',ctrl:'vMYEDIT',prop:'Visible'},{av:'sPrefix'},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E125G2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_PathologyID',fld:'vBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50Pgmname',fld:'vPGMNAME',pic:''},{av:'edtavMindel_Visible',ctrl:'vMINDEL',prop:'Visible'},{av:'edtavMyedit_Visible',ctrl:'vMYEDIT',prop:'Visible'},{av:'sPrefix'},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_BIO.ONOPTIONCLICKED","{handler:'E135G2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_PathologyID',fld:'vBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50Pgmname',fld:'vPGMNAME',pic:''},{av:'edtavMindel_Visible',ctrl:'vMINDEL',prop:'Visible'},{av:'edtavMyedit_Visible',ctrl:'vMYEDIT',prop:'Visible'},{av:'sPrefix'},{av:'Ddo_br_pathology_other_bio_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIO',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_BIO.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_other_bio_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIO',prop:'SortedStatus'},{av:'AV17BR_Pathology_Other_BioTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA',pic:''},{av:'AV19BR_Pathology_Other_BioNumTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA',pic:''},{av:'AV21BR_Pathology_Other_BioNumUnitTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA',pic:''},{av:'AV23BR_Pathology_Other_AbnIndTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_Other_Bio_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Bio_Title',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Title'},{av:'edtBR_Pathology_Other_BioNum_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNum_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Title'},{av:'edtBR_Pathology_Other_BioNumUnit_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNumUnit_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Title'},{av:'edtBR_Pathology_Other_AbnInd_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Titleformat'},{av:'edtBR_Pathology_Other_AbnInd_Title',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Title'},{av:'AV28GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV29GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV30GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavMyedit_Visible',ctrl:'vMYEDIT',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_BIONUM.ONOPTIONCLICKED","{handler:'E145G2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_PathologyID',fld:'vBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50Pgmname',fld:'vPGMNAME',pic:''},{av:'edtavMindel_Visible',ctrl:'vMINDEL',prop:'Visible'},{av:'edtavMyedit_Visible',ctrl:'vMYEDIT',prop:'Visible'},{av:'sPrefix'},{av:'Ddo_br_pathology_other_bionum_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUM',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_BIONUM.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_other_bionum_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUM',prop:'SortedStatus'},{av:'AV17BR_Pathology_Other_BioTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA',pic:''},{av:'AV19BR_Pathology_Other_BioNumTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA',pic:''},{av:'AV21BR_Pathology_Other_BioNumUnitTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA',pic:''},{av:'AV23BR_Pathology_Other_AbnIndTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_Other_Bio_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Bio_Title',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Title'},{av:'edtBR_Pathology_Other_BioNum_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNum_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Title'},{av:'edtBR_Pathology_Other_BioNumUnit_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNumUnit_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Title'},{av:'edtBR_Pathology_Other_AbnInd_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Titleformat'},{av:'edtBR_Pathology_Other_AbnInd_Title',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Title'},{av:'AV28GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV29GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV30GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavMyedit_Visible',ctrl:'vMYEDIT',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT.ONOPTIONCLICKED","{handler:'E155G2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_PathologyID',fld:'vBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50Pgmname',fld:'vPGMNAME',pic:''},{av:'edtavMindel_Visible',ctrl:'vMINDEL',prop:'Visible'},{av:'edtavMyedit_Visible',ctrl:'vMYEDIT',prop:'Visible'},{av:'sPrefix'},{av:'Ddo_br_pathology_other_bionumunit_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_other_bionumunit_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'SortedStatus'},{av:'AV17BR_Pathology_Other_BioTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA',pic:''},{av:'AV19BR_Pathology_Other_BioNumTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA',pic:''},{av:'AV21BR_Pathology_Other_BioNumUnitTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA',pic:''},{av:'AV23BR_Pathology_Other_AbnIndTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_Other_Bio_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Bio_Title',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Title'},{av:'edtBR_Pathology_Other_BioNum_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNum_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Title'},{av:'edtBR_Pathology_Other_BioNumUnit_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNumUnit_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Title'},{av:'edtBR_Pathology_Other_AbnInd_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Titleformat'},{av:'edtBR_Pathology_Other_AbnInd_Title',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Title'},{av:'AV28GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV29GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV30GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavMyedit_Visible',ctrl:'vMYEDIT',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_ABNIND.ONOPTIONCLICKED","{handler:'E165G2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_PathologyID',fld:'vBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_BIONUMUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_OTHER_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50Pgmname',fld:'vPGMNAME',pic:''},{av:'edtavMindel_Visible',ctrl:'vMINDEL',prop:'Visible'},{av:'edtavMyedit_Visible',ctrl:'vMYEDIT',prop:'Visible'},{av:'sPrefix'},{av:'Ddo_br_pathology_other_abnind_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_OTHER_ABNIND',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_OTHER_ABNIND.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_other_abnind_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_OTHER_ABNIND',prop:'SortedStatus'},{av:'AV17BR_Pathology_Other_BioTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIOTITLEFILTERDATA',pic:''},{av:'AV19BR_Pathology_Other_BioNumTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMTITLEFILTERDATA',pic:''},{av:'AV21BR_Pathology_Other_BioNumUnitTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_BIONUMUNITTITLEFILTERDATA',pic:''},{av:'AV23BR_Pathology_Other_AbnIndTitleFilterData',fld:'vBR_PATHOLOGY_OTHER_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_Other_Bio_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Titleformat'},{av:'edtBR_Pathology_Other_Bio_Title',ctrl:'BR_PATHOLOGY_OTHER_BIO',prop:'Title'},{av:'edtBR_Pathology_Other_BioNum_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNum_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUM',prop:'Title'},{av:'edtBR_Pathology_Other_BioNumUnit_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Titleformat'},{av:'edtBR_Pathology_Other_BioNumUnit_Title',ctrl:'BR_PATHOLOGY_OTHER_BIONUMUNIT',prop:'Title'},{av:'edtBR_Pathology_Other_AbnInd_Titleformat',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Titleformat'},{av:'edtBR_Pathology_Other_AbnInd_Title',ctrl:'BR_PATHOLOGY_OTHER_ABNIND',prop:'Title'},{av:'AV28GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV29GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV30GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavMyedit_Visible',ctrl:'vMYEDIT',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E205G2',iparms:[{av:'A288BR_Pathology_OtherID',fld:'BR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV35Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'},{av:'AV40myedit',fld:'vMYEDIT',pic:''},{av:'edtavMyedit_Tooltiptext',ctrl:'vMYEDIT',prop:'Tooltiptext'},{av:'AV44mindel',fld:'vMINDEL',pic:''},{av:'edtavMindel_Tooltiptext',ctrl:'vMINDEL',prop:'Tooltiptext'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E175G2',iparms:[{av:'A288BR_Pathology_OtherID',fld:'BR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV8BR_PathologyID',fld:'vBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("'DOINSERT'",",oparms:[]}");
         setEventMetadata("VMYEDIT.CLICK","{handler:'E215G2',iparms:[{av:'A288BR_Pathology_OtherID',fld:'BR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("VMYEDIT.CLICK",",oparms:[]}");
         setEventMetadata("VMINDEL.CLICK","{handler:'E225G2',iparms:[{av:'A288BR_Pathology_OtherID',fld:'BR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("VMINDEL.CLICK",",oparms:[]}");
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
         Ddo_br_pathology_other_bio_Activeeventkey = "";
         Ddo_br_pathology_other_bionum_Activeeventkey = "";
         Ddo_br_pathology_other_bionumunit_Activeeventkey = "";
         Ddo_br_pathology_other_abnind_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sPrefix = "";
         AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace = "";
         AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace = "";
         AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace = "";
         AV24ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace = "";
         AV50Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV25DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV17BR_Pathology_Other_BioTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19BR_Pathology_Other_BioNumTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_Pathology_Other_BioNumUnitTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV23BR_Pathology_Other_AbnIndTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_pathology_other_bio_Sortedstatus = "";
         Ddo_br_pathology_other_bionum_Sortedstatus = "";
         Ddo_br_pathology_other_bionumunit_Sortedstatus = "";
         Ddo_br_pathology_other_abnind_Sortedstatus = "";
         GX_FocusControl = "";
         ucDvpanel_tableheader = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtninsert_Jsonclick = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV35Display = "";
         AV40myedit = "";
         AV44mindel = "";
         A289BR_Pathology_Other_Bio = "";
         A291BR_Pathology_Other_BioNumUnit = "";
         A295BR_Pathology_Other_AbnInd = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_pathology_other_bio = new GXUserControl();
         ucDdo_br_pathology_other_bionum = new GXUserControl();
         ucDdo_br_pathology_other_bionumunit = new GXUserControl();
         ucDdo_br_pathology_other_abnind = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV47Display_GXI = "";
         AV48Myedit_GXI = "";
         AV49Mindel_GXI = "";
         scmdbuf = "";
         H005G2_A226BR_PathologyID = new long[1] ;
         H005G2_n226BR_PathologyID = new bool[] {false} ;
         H005G2_A295BR_Pathology_Other_AbnInd = new String[] {""} ;
         H005G2_n295BR_Pathology_Other_AbnInd = new bool[] {false} ;
         H005G2_A291BR_Pathology_Other_BioNumUnit = new String[] {""} ;
         H005G2_n291BR_Pathology_Other_BioNumUnit = new bool[] {false} ;
         H005G2_A290BR_Pathology_Other_BioNum = new decimal[1] ;
         H005G2_n290BR_Pathology_Other_BioNum = new bool[] {false} ;
         H005G2_A289BR_Pathology_Other_Bio = new String[] {""} ;
         H005G2_n289BR_Pathology_Other_Bio = new bool[] {false} ;
         H005G2_A288BR_Pathology_OtherID = new long[1] ;
         H005G3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV38tEncounterType = "";
         AV39WebSession = context.GetSession();
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         AV16Session = context.GetSession();
         AV12GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV10TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9HTTPRequest = new GxHttpRequest( context);
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlAV8BR_PathologyID = "";
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_pathologybr_pathology_otherwc__default(),
            new Object[][] {
                new Object[] {
               H005G2_A226BR_PathologyID, H005G2_n226BR_PathologyID, H005G2_A295BR_Pathology_Other_AbnInd, H005G2_n295BR_Pathology_Other_AbnInd, H005G2_A291BR_Pathology_Other_BioNumUnit, H005G2_n291BR_Pathology_Other_BioNumUnit, H005G2_A290BR_Pathology_Other_BioNum, H005G2_n290BR_Pathology_Other_BioNum, H005G2_A289BR_Pathology_Other_Bio, H005G2_n289BR_Pathology_Other_Bio,
               H005G2_A288BR_Pathology_OtherID
               }
               , new Object[] {
               H005G3_AGRID_nRecordCount
               }
            }
         );
         AV50Pgmname = "BR_PathologyBR_Pathology_OtherWC";
         /* GeneXus formulas. */
         AV50Pgmname = "BR_PathologyBR_Pathology_OtherWC";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short nRC_GXsfl_28 ;
      private short nGXsfl_28_idx=1 ;
      private short GRID_nEOF ;
      private short AV14OrderedBy ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtBR_Pathology_Other_Bio_Titleformat ;
      private short edtBR_Pathology_Other_BioNum_Titleformat ;
      private short edtBR_Pathology_Other_BioNumUnit_Titleformat ;
      private short edtBR_Pathology_Other_AbnInd_Titleformat ;
      private short subGrid_Sortable ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid_Backstyle ;
      private int edtavMindel_Visible ;
      private int edtavMyedit_Visible ;
      private int subGrid_Rows ;
      private int Gridpaginationbar_Rowsperpageselectedvalue ;
      private int Gridpaginationbar_Pagestoshow ;
      private int divTableheader_Visible ;
      private int bttBtninsert_Visible ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_other_bionumtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_other_bionumunittitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_other_abnindtitlecontrolidtoreplace_Visible ;
      private int edtBR_PathologyID_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV27PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavMyedit_Enabled ;
      private int edtavMindel_Enabled ;
      private long AV8BR_PathologyID ;
      private long wcpOAV8BR_PathologyID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV28GridCurrentPage ;
      private long AV30GridRecordCount ;
      private long AV29GridPageSize ;
      private long A288BR_Pathology_OtherID ;
      private long A226BR_PathologyID ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private decimal A290BR_Pathology_Other_BioNum ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_pathology_other_bio_Activeeventkey ;
      private String Ddo_br_pathology_other_bionum_Activeeventkey ;
      private String Ddo_br_pathology_other_bionumunit_Activeeventkey ;
      private String Ddo_br_pathology_other_abnind_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sGXsfl_28_idx="0001" ;
      private String edtavMindel_Internalname ;
      private String edtavMyedit_Internalname ;
      private String AV50Pgmname ;
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
      private String Ddo_br_pathology_other_bio_Caption ;
      private String Ddo_br_pathology_other_bio_Tooltip ;
      private String Ddo_br_pathology_other_bio_Cls ;
      private String Ddo_br_pathology_other_bio_Dropdownoptionstype ;
      private String Ddo_br_pathology_other_bio_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_other_bio_Sortedstatus ;
      private String Ddo_br_pathology_other_bio_Sortasc ;
      private String Ddo_br_pathology_other_bio_Sortdsc ;
      private String Ddo_br_pathology_other_bio_Searchbuttontext ;
      private String Ddo_br_pathology_other_bionum_Caption ;
      private String Ddo_br_pathology_other_bionum_Tooltip ;
      private String Ddo_br_pathology_other_bionum_Cls ;
      private String Ddo_br_pathology_other_bionum_Dropdownoptionstype ;
      private String Ddo_br_pathology_other_bionum_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_other_bionum_Sortedstatus ;
      private String Ddo_br_pathology_other_bionum_Sortasc ;
      private String Ddo_br_pathology_other_bionum_Sortdsc ;
      private String Ddo_br_pathology_other_bionum_Searchbuttontext ;
      private String Ddo_br_pathology_other_bionumunit_Caption ;
      private String Ddo_br_pathology_other_bionumunit_Tooltip ;
      private String Ddo_br_pathology_other_bionumunit_Cls ;
      private String Ddo_br_pathology_other_bionumunit_Dropdownoptionstype ;
      private String Ddo_br_pathology_other_bionumunit_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_other_bionumunit_Sortedstatus ;
      private String Ddo_br_pathology_other_bionumunit_Sortasc ;
      private String Ddo_br_pathology_other_bionumunit_Sortdsc ;
      private String Ddo_br_pathology_other_bionumunit_Searchbuttontext ;
      private String Ddo_br_pathology_other_abnind_Caption ;
      private String Ddo_br_pathology_other_abnind_Tooltip ;
      private String Ddo_br_pathology_other_abnind_Cls ;
      private String Ddo_br_pathology_other_abnind_Dropdownoptionstype ;
      private String Ddo_br_pathology_other_abnind_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_other_abnind_Sortedstatus ;
      private String Ddo_br_pathology_other_abnind_Sortasc ;
      private String Ddo_br_pathology_other_abnind_Sortdsc ;
      private String Ddo_br_pathology_other_abnind_Searchbuttontext ;
      private String GX_FocusControl ;
      private String divLayoutmaintable_Internalname ;
      private String divTablegridheader_Internalname ;
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
      private String edtBR_Pathology_Other_Bio_Title ;
      private String edtBR_Pathology_Other_BioNum_Title ;
      private String edtBR_Pathology_Other_BioNumUnit_Title ;
      private String edtBR_Pathology_Other_AbnInd_Title ;
      private String subGrid_Header ;
      private String edtavDisplay_Link ;
      private String edtavDisplay_Tooltiptext ;
      private String edtavMyedit_Tooltiptext ;
      private String edtavMindel_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_pathology_other_bio_Internalname ;
      private String edtavDdo_br_pathology_other_biotitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_other_bionum_Internalname ;
      private String edtavDdo_br_pathology_other_bionumtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_other_bionumunit_Internalname ;
      private String edtavDdo_br_pathology_other_bionumunittitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_other_abnind_Internalname ;
      private String edtavDdo_br_pathology_other_abnindtitlecontrolidtoreplace_Internalname ;
      private String edtBR_PathologyID_Internalname ;
      private String edtBR_PathologyID_Jsonclick ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDisplay_Internalname ;
      private String edtBR_Pathology_OtherID_Internalname ;
      private String edtBR_Pathology_Other_Bio_Internalname ;
      private String edtBR_Pathology_Other_BioNum_Internalname ;
      private String edtBR_Pathology_Other_BioNumUnit_Internalname ;
      private String edtBR_Pathology_Other_AbnInd_Internalname ;
      private String scmdbuf ;
      private String sCtrlAV8BR_PathologyID ;
      private String sGXsfl_28_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavMyedit_Jsonclick ;
      private String edtavMindel_Jsonclick ;
      private String ROClassString ;
      private String edtBR_Pathology_OtherID_Jsonclick ;
      private String edtBR_Pathology_Other_Bio_Jsonclick ;
      private String edtBR_Pathology_Other_BioNum_Jsonclick ;
      private String edtBR_Pathology_Other_BioNumUnit_Jsonclick ;
      private String edtBR_Pathology_Other_AbnInd_Jsonclick ;
      private bool entryPointCalled ;
      private bool bGXsfl_28_Refreshing=false ;
      private bool AV15OrderedDsc ;
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
      private bool Ddo_br_pathology_other_bio_Includesortasc ;
      private bool Ddo_br_pathology_other_bio_Includesortdsc ;
      private bool Ddo_br_pathology_other_bio_Includefilter ;
      private bool Ddo_br_pathology_other_bio_Includedatalist ;
      private bool Ddo_br_pathology_other_bionum_Includesortasc ;
      private bool Ddo_br_pathology_other_bionum_Includesortdsc ;
      private bool Ddo_br_pathology_other_bionum_Includefilter ;
      private bool Ddo_br_pathology_other_bionum_Includedatalist ;
      private bool Ddo_br_pathology_other_bionumunit_Includesortasc ;
      private bool Ddo_br_pathology_other_bionumunit_Includesortdsc ;
      private bool Ddo_br_pathology_other_bionumunit_Includefilter ;
      private bool Ddo_br_pathology_other_bionumunit_Includedatalist ;
      private bool Ddo_br_pathology_other_abnind_Includesortasc ;
      private bool Ddo_br_pathology_other_abnind_Includesortdsc ;
      private bool Ddo_br_pathology_other_abnind_Includefilter ;
      private bool Ddo_br_pathology_other_abnind_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n289BR_Pathology_Other_Bio ;
      private bool n290BR_Pathology_Other_BioNum ;
      private bool n291BR_Pathology_Other_BioNumUnit ;
      private bool n295BR_Pathology_Other_AbnInd ;
      private bool gxdyncontrolsrefreshing ;
      private bool n226BR_PathologyID ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV42IsAuthorized_myedit ;
      private bool AV37TempBoolean ;
      private bool GXt_boolean2 ;
      private bool AV35Display_IsBlob ;
      private bool AV40myedit_IsBlob ;
      private bool AV44mindel_IsBlob ;
      private String AV18ddo_BR_Pathology_Other_BioTitleControlIdToReplace ;
      private String AV20ddo_BR_Pathology_Other_BioNumTitleControlIdToReplace ;
      private String AV22ddo_BR_Pathology_Other_BioNumUnitTitleControlIdToReplace ;
      private String AV24ddo_BR_Pathology_Other_AbnIndTitleControlIdToReplace ;
      private String A289BR_Pathology_Other_Bio ;
      private String A291BR_Pathology_Other_BioNumUnit ;
      private String A295BR_Pathology_Other_AbnInd ;
      private String AV47Display_GXI ;
      private String AV48Myedit_GXI ;
      private String AV49Mindel_GXI ;
      private String AV38tEncounterType ;
      private String AV35Display ;
      private String AV40myedit ;
      private String AV44mindel ;
      private IGxSession AV39WebSession ;
      private IGxSession AV16Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_pathology_other_bio ;
      private GXUserControl ucDdo_br_pathology_other_bionum ;
      private GXUserControl ucDdo_br_pathology_other_bionumunit ;
      private GXUserControl ucDdo_br_pathology_other_abnind ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] H005G2_A226BR_PathologyID ;
      private bool[] H005G2_n226BR_PathologyID ;
      private String[] H005G2_A295BR_Pathology_Other_AbnInd ;
      private bool[] H005G2_n295BR_Pathology_Other_AbnInd ;
      private String[] H005G2_A291BR_Pathology_Other_BioNumUnit ;
      private bool[] H005G2_n291BR_Pathology_Other_BioNumUnit ;
      private decimal[] H005G2_A290BR_Pathology_Other_BioNum ;
      private bool[] H005G2_n290BR_Pathology_Other_BioNum ;
      private String[] H005G2_A289BR_Pathology_Other_Bio ;
      private bool[] H005G2_n289BR_Pathology_Other_Bio ;
      private long[] H005G2_A288BR_Pathology_OtherID ;
      private long[] H005G3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV9HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV17BR_Pathology_Other_BioTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV19BR_Pathology_Other_BioNumTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV21BR_Pathology_Other_BioNumUnitTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV23BR_Pathology_Other_AbnIndTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV25DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV12GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV10TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV11TrnContextAtt ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
   }

   public class br_pathologybr_pathology_otherwc__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H005G2( IGxContext context ,
                                             short AV14OrderedBy ,
                                             bool AV15OrderedDsc ,
                                             long A226BR_PathologyID ,
                                             long AV8BR_PathologyID )
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
         sSelectString = " [BR_PathologyID], [BR_Pathology_Other_AbnInd], [BR_Pathology_Other_BioNumUnit], [BR_Pathology_Other_BioNum], [BR_Pathology_Other_Bio], [BR_Pathology_OtherID]";
         sFromString = " FROM [BR_Pathology_Other] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([BR_PathologyID] = @AV8BR_PathologyID)";
         if ( ( AV14OrderedBy == 1 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_OtherID] DESC";
         }
         else if ( ( AV14OrderedBy == 1 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_OtherID]";
         }
         else if ( ( AV14OrderedBy == 2 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_PathologyID], [BR_Pathology_Other_BioNum]";
         }
         else if ( ( AV14OrderedBy == 2 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_PathologyID] DESC, [BR_Pathology_Other_BioNum] DESC";
         }
         else if ( ( AV14OrderedBy == 3 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_PathologyID], [BR_Pathology_Other_BioNumUnit]";
         }
         else if ( ( AV14OrderedBy == 3 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_PathologyID] DESC, [BR_Pathology_Other_BioNumUnit] DESC";
         }
         else if ( ( AV14OrderedBy == 4 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_PathologyID], [BR_Pathology_Other_AbnInd]";
         }
         else if ( ( AV14OrderedBy == 4 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_PathologyID] DESC, [BR_Pathology_Other_AbnInd] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_OtherID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H005G3( IGxContext context ,
                                             short AV14OrderedBy ,
                                             bool AV15OrderedDsc ,
                                             long A226BR_PathologyID ,
                                             long AV8BR_PathologyID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [1] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [BR_Pathology_Other] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([BR_PathologyID] = @AV8BR_PathologyID)";
         if ( ( AV14OrderedBy == 1 ) && ! AV15OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 1 ) && ( AV15OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 2 ) && ! AV15OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 2 ) && ( AV15OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 3 ) && ! AV15OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 3 ) && ( AV15OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 4 ) && ! AV15OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 4 ) && ( AV15OrderedDsc ) )
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
                     return conditional_H005G2(context, (short)dynConstraints[0] , (bool)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] );
               case 1 :
                     return conditional_H005G3(context, (short)dynConstraints[0] , (bool)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] );
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
          Object[] prmH005G2 ;
          prmH005G2 = new Object[] {
          new Object[] {"@AV8BR_PathologyID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH005G3 ;
          prmH005G3 = new Object[] {
          new Object[] {"@AV8BR_PathologyID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H005G2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005G2,11,0,true,false )
             ,new CursorDef("H005G3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005G3,1,0,true,false )
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
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((decimal[]) buf[6])[0] = rslt.getDecimal(4) ;
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
                   stmt.SetParameter(sIdx, (long)parms[4]);
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
                   stmt.SetParameter(sIdx, (long)parms[1]);
                }
                return;
       }
    }

 }

}
