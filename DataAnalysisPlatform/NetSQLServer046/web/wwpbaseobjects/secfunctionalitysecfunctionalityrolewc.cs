/*
               File: WWPBaseObjects.SecFunctionalitySecFunctionalityRoleWC
        Description: Sec Functionality Sec Functionality Role WC
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:28.19
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
namespace GeneXus.Programs.wwpbaseobjects {
   public class secfunctionalitysecfunctionalityrolewc : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public secfunctionalitysecfunctionalityrolewc( )
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

      public secfunctionalitysecfunctionalityrolewc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_SecFunctionalityId )
      {
         this.AV8SecFunctionalityId = aP0_SecFunctionalityId;
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
                  AV8SecFunctionalityId = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8SecFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8SecFunctionalityId), 10, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(long)AV8SecFunctionalityId});
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
                  nRC_GXsfl_29 = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  nGXsfl_29_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  sGXsfl_29_idx = GetNextPar( );
                  sPrefix = GetNextPar( );
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
                  AV46SecRoleName = GetNextPar( );
                  AV16OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV17OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
                  AV23TFSecRoleName = GetNextPar( );
                  AV24TFSecRoleName_Sel = GetNextPar( );
                  AV27TFSecRoleDescription = GetNextPar( );
                  AV28TFSecRoleDescription_Sel = GetNextPar( );
                  AV8SecFunctionalityId = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  AV25ddo_SecRoleNameTitleControlIdToReplace = GetNextPar( );
                  AV29ddo_SecRoleDescriptionTitleControlIdToReplace = GetNextPar( );
                  AV50Pgmname = GetNextPar( );
                  AV20IsAuthorized_Delete = StringUtil.StrToBool( GetNextPar( ));
                  AV13IsAuthorized_SecRoleName = StringUtil.StrToBool( GetNextPar( ));
                  A1SecFunctionalityId = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  sPrefix = GetNextPar( );
                  init_default_properties( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxgrGrid_refresh( subGrid_Rows, AV46SecRoleName, AV16OrderedBy, AV17OrderedDsc, AV23TFSecRoleName, AV24TFSecRoleName_Sel, AV27TFSecRoleDescription, AV28TFSecRoleDescription_Sel, AV8SecFunctionalityId, AV25ddo_SecRoleNameTitleControlIdToReplace, AV29ddo_SecRoleDescriptionTitleControlIdToReplace, AV50Pgmname, AV20IsAuthorized_Delete, AV13IsAuthorized_SecRoleName, A1SecFunctionalityId, sPrefix) ;
                  GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
                  GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
                  forbiddenHiddens = sPrefix + "hsh" + "SecFunctionalitySecFunctionalityRoleWC";
                  forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A1SecFunctionalityId), "ZZZZZZZZZ9");
                  GxWebStd.gx_hidden_field( context, sPrefix+"hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
                  GXUtil.WriteLog("wwpbaseobjects.secfunctionalitysecfunctionalityrolewc:[SendSecurityCheck value for]"+"SecFunctionalityId:"+context.localUtil.Format( (decimal)(A1SecFunctionalityId), "ZZZZZZZZZ9"));
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
            PA0S2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV50Pgmname = "WWPBaseObjects.SecFunctionalitySecFunctionalityRoleWC";
               context.Gx_err = 0;
               WS0S2( ) ;
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
            context.SendWebValue( "Sec Functionality Sec Functionality Role WC") ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022711552844", false);
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("wwpbaseobjects.secfunctionalitysecfunctionalityrolewc.aspx") + "?" + UrlEncode("" +AV8SecFunctionalityId)+"\">") ;
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
         forbiddenHiddens = sPrefix + "hsh" + "SecFunctionalitySecFunctionalityRoleWC";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A1SecFunctionalityId), "ZZZZZZZZZ9");
         GxWebStd.gx_hidden_field( context, sPrefix+"hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("wwpbaseobjects.secfunctionalitysecfunctionalityrolewc:[SendSecurityCheck value for]"+"SecFunctionalityId:"+context.localUtil.Format( (decimal)(A1SecFunctionalityId), "ZZZZZZZZZ9"));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vSECROLENAME", AV46SecRoleName);
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16OrderedBy), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vORDEREDDSC", StringUtil.BoolToStr( AV17OrderedDsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vTFSECROLENAME", AV23TFSecRoleName);
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vTFSECROLENAME_SEL", AV24TFSecRoleName_Sel);
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vTFSECROLEDESCRIPTION", AV27TFSecRoleDescription);
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vTFSECROLEDESCRIPTION_SEL", AV28TFSecRoleDescription_Sel);
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_GXsfl_29", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_29), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV40GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV43GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV42GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vDDO_TITLESETTINGSICONS", AV30DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vDDO_TITLESETTINGSICONS", AV30DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vSECROLENAMETITLEFILTERDATA", AV22SecRoleNameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vSECROLENAMETITLEFILTERDATA", AV22SecRoleNameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vSECROLEDESCRIPTIONTITLEFILTERDATA", AV26SecRoleDescriptionTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vSECROLEDESCRIPTIONTITLEFILTERDATA", AV26SecRoleDescriptionTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV8SecFunctionalityId", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV8SecFunctionalityId), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vPGMNAME", StringUtil.RTrim( AV50Pgmname));
         GxWebStd.gx_hidden_field( context, sPrefix+"vSECFUNCTIONALITYID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8SecFunctionalityId), 10, 0, ".", "")));
         GxWebStd.gx_boolean_hidden_field( context, sPrefix+"vISAUTHORIZED_DELETE", AV20IsAuthorized_Delete);
         GxWebStd.gx_boolean_hidden_field( context, sPrefix+"vISAUTHORIZED_SECROLENAME", AV13IsAuthorized_SecRoleName);
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_vISAUTHORIZED_SECROLENAME", GetSecureSignedToken( sPrefix, AV13IsAuthorized_SecRoleName, context));
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
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLENAME_Caption", StringUtil.RTrim( Ddo_secrolename_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLENAME_Tooltip", StringUtil.RTrim( Ddo_secrolename_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLENAME_Cls", StringUtil.RTrim( Ddo_secrolename_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLENAME_Filteredtext_set", StringUtil.RTrim( Ddo_secrolename_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLENAME_Selectedvalue_set", StringUtil.RTrim( Ddo_secrolename_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLENAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_secrolename_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLENAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_secrolename_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLENAME_Includesortasc", StringUtil.BoolToStr( Ddo_secrolename_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLENAME_Includesortdsc", StringUtil.BoolToStr( Ddo_secrolename_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLENAME_Sortedstatus", StringUtil.RTrim( Ddo_secrolename_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLENAME_Includefilter", StringUtil.BoolToStr( Ddo_secrolename_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLENAME_Filtertype", StringUtil.RTrim( Ddo_secrolename_Filtertype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLENAME_Filterisrange", StringUtil.BoolToStr( Ddo_secrolename_Filterisrange));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLENAME_Includedatalist", StringUtil.BoolToStr( Ddo_secrolename_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLENAME_Datalisttype", StringUtil.RTrim( Ddo_secrolename_Datalisttype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLENAME_Datalistproc", StringUtil.RTrim( Ddo_secrolename_Datalistproc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLENAME_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_secrolename_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLENAME_Sortasc", StringUtil.RTrim( Ddo_secrolename_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLENAME_Sortdsc", StringUtil.RTrim( Ddo_secrolename_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLENAME_Loadingdata", StringUtil.RTrim( Ddo_secrolename_Loadingdata));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLENAME_Cleanfilter", StringUtil.RTrim( Ddo_secrolename_Cleanfilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLENAME_Noresultsfound", StringUtil.RTrim( Ddo_secrolename_Noresultsfound));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLENAME_Searchbuttontext", StringUtil.RTrim( Ddo_secrolename_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLEDESCRIPTION_Caption", StringUtil.RTrim( Ddo_secroledescription_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLEDESCRIPTION_Tooltip", StringUtil.RTrim( Ddo_secroledescription_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLEDESCRIPTION_Cls", StringUtil.RTrim( Ddo_secroledescription_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLEDESCRIPTION_Filteredtext_set", StringUtil.RTrim( Ddo_secroledescription_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLEDESCRIPTION_Selectedvalue_set", StringUtil.RTrim( Ddo_secroledescription_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLEDESCRIPTION_Dropdownoptionstype", StringUtil.RTrim( Ddo_secroledescription_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLEDESCRIPTION_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_secroledescription_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLEDESCRIPTION_Includesortasc", StringUtil.BoolToStr( Ddo_secroledescription_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLEDESCRIPTION_Includesortdsc", StringUtil.BoolToStr( Ddo_secroledescription_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLEDESCRIPTION_Sortedstatus", StringUtil.RTrim( Ddo_secroledescription_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLEDESCRIPTION_Includefilter", StringUtil.BoolToStr( Ddo_secroledescription_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLEDESCRIPTION_Filtertype", StringUtil.RTrim( Ddo_secroledescription_Filtertype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLEDESCRIPTION_Filterisrange", StringUtil.BoolToStr( Ddo_secroledescription_Filterisrange));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLEDESCRIPTION_Includedatalist", StringUtil.BoolToStr( Ddo_secroledescription_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLEDESCRIPTION_Datalisttype", StringUtil.RTrim( Ddo_secroledescription_Datalisttype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLEDESCRIPTION_Datalistproc", StringUtil.RTrim( Ddo_secroledescription_Datalistproc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLEDESCRIPTION_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_secroledescription_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLEDESCRIPTION_Sortasc", StringUtil.RTrim( Ddo_secroledescription_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLEDESCRIPTION_Sortdsc", StringUtil.RTrim( Ddo_secroledescription_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLEDESCRIPTION_Loadingdata", StringUtil.RTrim( Ddo_secroledescription_Loadingdata));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLEDESCRIPTION_Cleanfilter", StringUtil.RTrim( Ddo_secroledescription_Cleanfilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLEDESCRIPTION_Noresultsfound", StringUtil.RTrim( Ddo_secroledescription_Noresultsfound));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLEDESCRIPTION_Searchbuttontext", StringUtil.RTrim( Ddo_secroledescription_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLENAME_Activeeventkey", StringUtil.RTrim( Ddo_secrolename_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLENAME_Filteredtext_get", StringUtil.RTrim( Ddo_secrolename_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLENAME_Selectedvalue_get", StringUtil.RTrim( Ddo_secrolename_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLEDESCRIPTION_Activeeventkey", StringUtil.RTrim( Ddo_secroledescription_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLEDESCRIPTION_Filteredtext_get", StringUtil.RTrim( Ddo_secroledescription_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLEDESCRIPTION_Selectedvalue_get", StringUtil.RTrim( Ddo_secroledescription_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLENAME_Activeeventkey", StringUtil.RTrim( Ddo_secrolename_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLENAME_Filteredtext_get", StringUtil.RTrim( Ddo_secrolename_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLENAME_Selectedvalue_get", StringUtil.RTrim( Ddo_secrolename_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLEDESCRIPTION_Activeeventkey", StringUtil.RTrim( Ddo_secroledescription_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLEDESCRIPTION_Filteredtext_get", StringUtil.RTrim( Ddo_secroledescription_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECROLEDESCRIPTION_Selectedvalue_get", StringUtil.RTrim( Ddo_secroledescription_Selectedvalue_get));
      }

      protected void RenderHtmlCloseForm0S2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("wwpbaseobjects/secfunctionalitysecfunctionalityrolewc.js", "?202022711553088", false);
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
         return "WWPBaseObjects.SecFunctionalitySecFunctionalityRoleWC" ;
      }

      public override String GetPgmdesc( )
      {
         return "Sec Functionality Sec Functionality Role WC" ;
      }

      protected void WB0S0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "wwpbaseobjects.secfunctionalitysecfunctionalityrolewc.aspx");
               context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
               context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
               context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false);
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
            GxWebStd.gx_div_start( context, divTableheader_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtableecrolename_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell CellWidth_12_5", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblFiltertextsecrolename_Internalname, "角色名称", "", "", lblFiltertextsecrolename_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_WWPBaseObjects\\SecFunctionalitySecFunctionalityRoleWC.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 CellWidth_87_5", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSecrolename_Internalname, "Sec Role Name", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'" + sPrefix + "',false,'" + sGXsfl_29_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSecrolename_Internalname, AV46SecRoleName, StringUtil.RTrim( context.localUtil.Format( AV46SecRoleName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,23);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSecrolename_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavSecrolename_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecFunctionalitySecFunctionalityRoleWC.htm");
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
               context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"DivS\" data-gxgridid=\"29\">") ;
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DeleteAttribute ActionBaseColorAttribute"+"\" "+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "角色编号") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtSecRoleName_Titleformat == 0 )
               {
                  context.SendWebValue( edtSecRoleName_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtSecRoleName_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtSecRoleDescription_Titleformat == 0 )
               {
                  context.SendWebValue( edtSecRoleDescription_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtSecRoleDescription_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV18Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A4SecRoleId), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A13SecRoleName);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtSecRoleName_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSecRoleName_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtSecRoleName_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A12SecRoleDescription);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtSecRoleDescription_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSecRoleDescription_Titleformat), 4, 0, ".", "")));
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
         if ( wbEnd == 29 )
         {
            wbEnd = 0;
            nRC_GXsfl_29 = (short)(nGXsfl_29_idx-1);
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV40GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV43GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV42GridPageSize);
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
            ucDdo_secrolename.SetProperty("Caption", Ddo_secrolename_Caption);
            ucDdo_secrolename.SetProperty("Tooltip", Ddo_secrolename_Tooltip);
            ucDdo_secrolename.SetProperty("Cls", Ddo_secrolename_Cls);
            ucDdo_secrolename.SetProperty("DropDownOptionsType", Ddo_secrolename_Dropdownoptionstype);
            ucDdo_secrolename.SetProperty("IncludeSortASC", Ddo_secrolename_Includesortasc);
            ucDdo_secrolename.SetProperty("IncludeSortDSC", Ddo_secrolename_Includesortdsc);
            ucDdo_secrolename.SetProperty("IncludeFilter", Ddo_secrolename_Includefilter);
            ucDdo_secrolename.SetProperty("FilterType", Ddo_secrolename_Filtertype);
            ucDdo_secrolename.SetProperty("FilterIsRange", Ddo_secrolename_Filterisrange);
            ucDdo_secrolename.SetProperty("IncludeDataList", Ddo_secrolename_Includedatalist);
            ucDdo_secrolename.SetProperty("DataListType", Ddo_secrolename_Datalisttype);
            ucDdo_secrolename.SetProperty("DataListProc", Ddo_secrolename_Datalistproc);
            ucDdo_secrolename.SetProperty("DataListUpdateMinimumCharacters", Ddo_secrolename_Datalistupdateminimumcharacters);
            ucDdo_secrolename.SetProperty("SortASC", Ddo_secrolename_Sortasc);
            ucDdo_secrolename.SetProperty("SortDSC", Ddo_secrolename_Sortdsc);
            ucDdo_secrolename.SetProperty("LoadingData", Ddo_secrolename_Loadingdata);
            ucDdo_secrolename.SetProperty("CleanFilter", Ddo_secrolename_Cleanfilter);
            ucDdo_secrolename.SetProperty("NoResultsFound", Ddo_secrolename_Noresultsfound);
            ucDdo_secrolename.SetProperty("SearchButtonText", Ddo_secrolename_Searchbuttontext);
            ucDdo_secrolename.SetProperty("DropDownOptionsTitleSettingsIcons", AV30DDO_TitleSettingsIcons);
            ucDdo_secrolename.SetProperty("DropDownOptionsData", AV22SecRoleNameTitleFilterData);
            ucDdo_secrolename.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_secrolename_Internalname, sPrefix+"DDO_SECROLENAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'" + sPrefix + "',false,'" + sGXsfl_29_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_secrolenametitlecontrolidtoreplace_Internalname, AV25ddo_SecRoleNameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,42);\"", 0, edtavDdo_secrolenametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_WWPBaseObjects\\SecFunctionalitySecFunctionalityRoleWC.htm");
            /* User Defined Control */
            ucDdo_secroledescription.SetProperty("Caption", Ddo_secroledescription_Caption);
            ucDdo_secroledescription.SetProperty("Tooltip", Ddo_secroledescription_Tooltip);
            ucDdo_secroledescription.SetProperty("Cls", Ddo_secroledescription_Cls);
            ucDdo_secroledescription.SetProperty("DropDownOptionsType", Ddo_secroledescription_Dropdownoptionstype);
            ucDdo_secroledescription.SetProperty("IncludeSortASC", Ddo_secroledescription_Includesortasc);
            ucDdo_secroledescription.SetProperty("IncludeSortDSC", Ddo_secroledescription_Includesortdsc);
            ucDdo_secroledescription.SetProperty("IncludeFilter", Ddo_secroledescription_Includefilter);
            ucDdo_secroledescription.SetProperty("FilterType", Ddo_secroledescription_Filtertype);
            ucDdo_secroledescription.SetProperty("FilterIsRange", Ddo_secroledescription_Filterisrange);
            ucDdo_secroledescription.SetProperty("IncludeDataList", Ddo_secroledescription_Includedatalist);
            ucDdo_secroledescription.SetProperty("DataListType", Ddo_secroledescription_Datalisttype);
            ucDdo_secroledescription.SetProperty("DataListProc", Ddo_secroledescription_Datalistproc);
            ucDdo_secroledescription.SetProperty("DataListUpdateMinimumCharacters", Ddo_secroledescription_Datalistupdateminimumcharacters);
            ucDdo_secroledescription.SetProperty("SortASC", Ddo_secroledescription_Sortasc);
            ucDdo_secroledescription.SetProperty("SortDSC", Ddo_secroledescription_Sortdsc);
            ucDdo_secroledescription.SetProperty("LoadingData", Ddo_secroledescription_Loadingdata);
            ucDdo_secroledescription.SetProperty("CleanFilter", Ddo_secroledescription_Cleanfilter);
            ucDdo_secroledescription.SetProperty("NoResultsFound", Ddo_secroledescription_Noresultsfound);
            ucDdo_secroledescription.SetProperty("SearchButtonText", Ddo_secroledescription_Searchbuttontext);
            ucDdo_secroledescription.SetProperty("DropDownOptionsTitleSettingsIcons", AV30DDO_TitleSettingsIcons);
            ucDdo_secroledescription.SetProperty("DropDownOptionsData", AV26SecRoleDescriptionTitleFilterData);
            ucDdo_secroledescription.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_secroledescription_Internalname, sPrefix+"DDO_SECROLEDESCRIPTIONContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'" + sPrefix + "',false,'" + sGXsfl_29_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_secroledescriptiontitlecontrolidtoreplace_Internalname, AV29ddo_SecRoleDescriptionTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", 0, edtavDdo_secroledescriptiontitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_WWPBaseObjects\\SecFunctionalitySecFunctionalityRoleWC.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtSecFunctionalityId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SecFunctionalityId), 10, 0, ".", "")), context.localUtil.Format( (decimal)(A1SecFunctionalityId), "ZZZZZZZZZ9"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSecFunctionalityId_Jsonclick, 0, "Attribute", "", "", "", "", edtSecFunctionalityId_Visible, 0, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WWPBaseObjects\\SecFunctionalitySecFunctionalityRoleWC.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, sPrefix+"WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'" + sPrefix + "',false,'" + sGXsfl_29_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV16OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,47);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WWPBaseObjects\\SecFunctionalitySecFunctionalityRoleWC.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'" + sPrefix + "',false,'" + sGXsfl_29_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV17OrderedDsc), StringUtil.BoolToStr( AV17OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_WWPBaseObjects\\SecFunctionalitySecFunctionalityRoleWC.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'" + sPrefix + "',false,'" + sGXsfl_29_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfsecrolename_Internalname, AV23TFSecRoleName, StringUtil.RTrim( context.localUtil.Format( AV23TFSecRoleName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfsecrolename_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfsecrolename_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecFunctionalitySecFunctionalityRoleWC.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'" + sPrefix + "',false,'" + sGXsfl_29_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfsecrolename_sel_Internalname, AV24TFSecRoleName_Sel, StringUtil.RTrim( context.localUtil.Format( AV24TFSecRoleName_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfsecrolename_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfsecrolename_sel_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecFunctionalitySecFunctionalityRoleWC.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'" + sPrefix + "',false,'" + sGXsfl_29_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfsecroledescription_Internalname, AV27TFSecRoleDescription, StringUtil.RTrim( context.localUtil.Format( AV27TFSecRoleDescription, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfsecroledescription_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfsecroledescription_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecFunctionalitySecFunctionalityRoleWC.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'" + sPrefix + "',false,'" + sGXsfl_29_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfsecroledescription_sel_Internalname, AV28TFSecRoleDescription_Sel, StringUtil.RTrim( context.localUtil.Format( AV28TFSecRoleDescription_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfsecroledescription_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfsecroledescription_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecFunctionalitySecFunctionalityRoleWC.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 29 )
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

      protected void START0S2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
               Form.Meta.addItem("description", "Sec Functionality Sec Functionality Role WC", 0) ;
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
               STRUP0S0( ) ;
            }
         }
      }

      protected void WS0S2( )
      {
         START0S2( ) ;
         EVT0S2( ) ;
      }

      protected void EVT0S2( )
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
                                 STRUP0S0( ) ;
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
                                 STRUP0S0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E110S2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0S0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E120S2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_SECROLENAME.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0S0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E130S2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_SECROLEDESCRIPTION.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0S0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E140S2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0S0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = edtavSecrolename_Internalname;
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
                                 STRUP0S0( ) ;
                              }
                              nGXsfl_29_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_29_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_29_idx), 4, 0)), 4, "0");
                              SubsflControlProps_292( ) ;
                              AV18Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV18Delete)) ? AV49Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV18Delete))), !bGXsfl_29_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV18Delete), true);
                              A4SecRoleId = (short)(context.localUtil.CToN( cgiGet( edtSecRoleId_Internalname), ".", ","));
                              A13SecRoleName = cgiGet( edtSecRoleName_Internalname);
                              A12SecRoleDescription = cgiGet( edtSecRoleDescription_Internalname);
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
                                          GX_FocusControl = edtavSecrolename_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: Start */
                                          E150S2 ();
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
                                          GX_FocusControl = edtavSecrolename_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: Refresh */
                                          E160S2 ();
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
                                          GX_FocusControl = edtavSecrolename_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          E170S2 ();
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
                                             /* Set Refresh If Secrolename Changed */
                                             if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vSECROLENAME"), AV46SecRoleName) != 0 )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Orderedby Changed */
                                             if ( ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV16OrderedBy )) )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Ordereddsc Changed */
                                             if ( StringUtil.StrToBool( cgiGet( sPrefix+"GXH_vORDEREDDSC")) != AV17OrderedDsc )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Tfsecrolename Changed */
                                             if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFSECROLENAME"), AV23TFSecRoleName) != 0 )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Tfsecrolename_sel Changed */
                                             if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFSECROLENAME_SEL"), AV24TFSecRoleName_Sel) != 0 )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Tfsecroledescription Changed */
                                             if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFSECROLEDESCRIPTION"), AV27TFSecRoleDescription) != 0 )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Tfsecroledescription_sel Changed */
                                             if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFSECROLEDESCRIPTION_SEL"), AV28TFSecRoleDescription_Sel) != 0 )
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
                                       STRUP0S0( ) ;
                                    }
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavSecrolename_Internalname;
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

      protected void WE0S2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm0S2( ) ;
            }
         }
      }

      protected void PA0S2( )
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
               GX_FocusControl = edtavSecrolename_Internalname;
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
         SubsflControlProps_292( ) ;
         while ( nGXsfl_29_idx <= nRC_GXsfl_29 )
         {
            sendrow_292( ) ;
            nGXsfl_29_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_29_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_29_idx+1));
            sGXsfl_29_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_29_idx), 4, 0)), 4, "0");
            SubsflControlProps_292( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       String AV46SecRoleName ,
                                       short AV16OrderedBy ,
                                       bool AV17OrderedDsc ,
                                       String AV23TFSecRoleName ,
                                       String AV24TFSecRoleName_Sel ,
                                       String AV27TFSecRoleDescription ,
                                       String AV28TFSecRoleDescription_Sel ,
                                       long AV8SecFunctionalityId ,
                                       String AV25ddo_SecRoleNameTitleControlIdToReplace ,
                                       String AV29ddo_SecRoleDescriptionTitleControlIdToReplace ,
                                       String AV50Pgmname ,
                                       bool AV20IsAuthorized_Delete ,
                                       bool AV13IsAuthorized_SecRoleName ,
                                       long A1SecFunctionalityId ,
                                       String sPrefix )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF0S2( ) ;
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
         RF0S2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV50Pgmname = "WWPBaseObjects.SecFunctionalitySecFunctionalityRoleWC";
         context.Gx_err = 0;
      }

      protected void RF0S2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 29;
         /* Execute user event: Refresh */
         E160S2 ();
         nGXsfl_29_idx = 1;
         sGXsfl_29_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_29_idx), 4, 0)), 4, "0");
         SubsflControlProps_292( ) ;
         bGXsfl_29_Refreshing = true;
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
            SubsflControlProps_292( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV46SecRoleName ,
                                                 AV24TFSecRoleName_Sel ,
                                                 AV23TFSecRoleName ,
                                                 AV28TFSecRoleDescription_Sel ,
                                                 AV27TFSecRoleDescription ,
                                                 A13SecRoleName ,
                                                 A12SecRoleDescription ,
                                                 AV16OrderedBy ,
                                                 AV17OrderedDsc ,
                                                 A1SecFunctionalityId ,
                                                 AV8SecFunctionalityId } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG,
                                                 TypeConstants.LONG
                                                 }
            } ) ;
            lV46SecRoleName = StringUtil.Concat( StringUtil.RTrim( AV46SecRoleName), "%", "");
            lV23TFSecRoleName = StringUtil.Concat( StringUtil.RTrim( AV23TFSecRoleName), "%", "");
            lV27TFSecRoleDescription = StringUtil.Concat( StringUtil.RTrim( AV27TFSecRoleDescription), "%", "");
            /* Using cursor H000S2 */
            pr_default.execute(0, new Object[] {AV8SecFunctionalityId, lV46SecRoleName, lV23TFSecRoleName, AV24TFSecRoleName_Sel, lV27TFSecRoleDescription, AV28TFSecRoleDescription_Sel, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_29_idx = 1;
            sGXsfl_29_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_29_idx), 4, 0)), 4, "0");
            SubsflControlProps_292( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A1SecFunctionalityId = H000S2_A1SecFunctionalityId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A1SecFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SecFunctionalityId), 10, 0)));
               A12SecRoleDescription = H000S2_A12SecRoleDescription[0];
               A13SecRoleName = H000S2_A13SecRoleName[0];
               A4SecRoleId = H000S2_A4SecRoleId[0];
               A12SecRoleDescription = H000S2_A12SecRoleDescription[0];
               A13SecRoleName = H000S2_A13SecRoleName[0];
               E170S2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 29;
            WB0S0( ) ;
         }
         bGXsfl_29_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes0S2( )
      {
         GxWebStd.gx_boolean_hidden_field( context, sPrefix+"vISAUTHORIZED_SECROLENAME", AV13IsAuthorized_SecRoleName);
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_vISAUTHORIZED_SECROLENAME", GetSecureSignedToken( sPrefix, AV13IsAuthorized_SecRoleName, context));
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
                                              AV46SecRoleName ,
                                              AV24TFSecRoleName_Sel ,
                                              AV23TFSecRoleName ,
                                              AV28TFSecRoleDescription_Sel ,
                                              AV27TFSecRoleDescription ,
                                              A13SecRoleName ,
                                              A12SecRoleDescription ,
                                              AV16OrderedBy ,
                                              AV17OrderedDsc ,
                                              A1SecFunctionalityId ,
                                              AV8SecFunctionalityId } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG,
                                              TypeConstants.LONG
                                              }
         } ) ;
         lV46SecRoleName = StringUtil.Concat( StringUtil.RTrim( AV46SecRoleName), "%", "");
         lV23TFSecRoleName = StringUtil.Concat( StringUtil.RTrim( AV23TFSecRoleName), "%", "");
         lV27TFSecRoleDescription = StringUtil.Concat( StringUtil.RTrim( AV27TFSecRoleDescription), "%", "");
         /* Using cursor H000S3 */
         pr_default.execute(1, new Object[] {AV8SecFunctionalityId, lV46SecRoleName, lV23TFSecRoleName, AV24TFSecRoleName_Sel, lV27TFSecRoleDescription, AV28TFSecRoleDescription_Sel});
         GRID_nRecordCount = H000S3_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV46SecRoleName, AV16OrderedBy, AV17OrderedDsc, AV23TFSecRoleName, AV24TFSecRoleName_Sel, AV27TFSecRoleDescription, AV28TFSecRoleDescription_Sel, AV8SecFunctionalityId, AV25ddo_SecRoleNameTitleControlIdToReplace, AV29ddo_SecRoleDescriptionTitleControlIdToReplace, AV50Pgmname, AV20IsAuthorized_Delete, AV13IsAuthorized_SecRoleName, A1SecFunctionalityId, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV46SecRoleName, AV16OrderedBy, AV17OrderedDsc, AV23TFSecRoleName, AV24TFSecRoleName_Sel, AV27TFSecRoleDescription, AV28TFSecRoleDescription_Sel, AV8SecFunctionalityId, AV25ddo_SecRoleNameTitleControlIdToReplace, AV29ddo_SecRoleDescriptionTitleControlIdToReplace, AV50Pgmname, AV20IsAuthorized_Delete, AV13IsAuthorized_SecRoleName, A1SecFunctionalityId, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV46SecRoleName, AV16OrderedBy, AV17OrderedDsc, AV23TFSecRoleName, AV24TFSecRoleName_Sel, AV27TFSecRoleDescription, AV28TFSecRoleDescription_Sel, AV8SecFunctionalityId, AV25ddo_SecRoleNameTitleControlIdToReplace, AV29ddo_SecRoleDescriptionTitleControlIdToReplace, AV50Pgmname, AV20IsAuthorized_Delete, AV13IsAuthorized_SecRoleName, A1SecFunctionalityId, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV46SecRoleName, AV16OrderedBy, AV17OrderedDsc, AV23TFSecRoleName, AV24TFSecRoleName_Sel, AV27TFSecRoleDescription, AV28TFSecRoleDescription_Sel, AV8SecFunctionalityId, AV25ddo_SecRoleNameTitleControlIdToReplace, AV29ddo_SecRoleDescriptionTitleControlIdToReplace, AV50Pgmname, AV20IsAuthorized_Delete, AV13IsAuthorized_SecRoleName, A1SecFunctionalityId, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV46SecRoleName, AV16OrderedBy, AV17OrderedDsc, AV23TFSecRoleName, AV24TFSecRoleName_Sel, AV27TFSecRoleDescription, AV28TFSecRoleDescription_Sel, AV8SecFunctionalityId, AV25ddo_SecRoleNameTitleControlIdToReplace, AV29ddo_SecRoleDescriptionTitleControlIdToReplace, AV50Pgmname, AV20IsAuthorized_Delete, AV13IsAuthorized_SecRoleName, A1SecFunctionalityId, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP0S0( )
      {
         /* Before Start, stand alone formulas. */
         AV50Pgmname = "WWPBaseObjects.SecFunctionalitySecFunctionalityRoleWC";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E150S2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vDDO_TITLESETTINGSICONS"), AV30DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vSECROLENAMETITLEFILTERDATA"), AV22SecRoleNameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vSECROLEDESCRIPTIONTITLEFILTERDATA"), AV26SecRoleDescriptionTitleFilterData);
            /* Read variables values. */
            AV46SecRoleName = cgiGet( edtavSecrolename_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV46SecRoleName", AV46SecRoleName);
            AV25ddo_SecRoleNameTitleControlIdToReplace = cgiGet( edtavDdo_secrolenametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV25ddo_SecRoleNameTitleControlIdToReplace", AV25ddo_SecRoleNameTitleControlIdToReplace);
            AV29ddo_SecRoleDescriptionTitleControlIdToReplace = cgiGet( edtavDdo_secroledescriptiontitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV29ddo_SecRoleDescriptionTitleControlIdToReplace", AV29ddo_SecRoleDescriptionTitleControlIdToReplace);
            A1SecFunctionalityId = (long)(context.localUtil.CToN( cgiGet( edtSecFunctionalityId_Internalname), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A1SecFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SecFunctionalityId), 10, 0)));
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDEREDBY");
               GX_FocusControl = edtavOrderedby_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV16OrderedBy = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV16OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16OrderedBy), 4, 0)));
            }
            else
            {
               AV16OrderedBy = (short)(context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV16OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16OrderedBy), 4, 0)));
            }
            AV17OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV17OrderedDsc", AV17OrderedDsc);
            AV23TFSecRoleName = cgiGet( edtavTfsecrolename_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV23TFSecRoleName", AV23TFSecRoleName);
            AV24TFSecRoleName_Sel = cgiGet( edtavTfsecrolename_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV24TFSecRoleName_Sel", AV24TFSecRoleName_Sel);
            AV27TFSecRoleDescription = cgiGet( edtavTfsecroledescription_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV27TFSecRoleDescription", AV27TFSecRoleDescription);
            AV28TFSecRoleDescription_Sel = cgiGet( edtavTfsecroledescription_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV28TFSecRoleDescription_Sel", AV28TFSecRoleDescription_Sel);
            /* Read saved values. */
            nRC_GXsfl_29 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_GXsfl_29"), ".", ","));
            AV40GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDCURRENTPAGE"), ".", ","));
            AV43GridRecordCount = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDRECORDCOUNT"), ".", ","));
            AV42GridPageSize = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDPAGESIZE"), ".", ","));
            wcpOAV8SecFunctionalityId = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV8SecFunctionalityId"), ".", ","));
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
            Ddo_secrolename_Caption = cgiGet( sPrefix+"DDO_SECROLENAME_Caption");
            Ddo_secrolename_Tooltip = cgiGet( sPrefix+"DDO_SECROLENAME_Tooltip");
            Ddo_secrolename_Cls = cgiGet( sPrefix+"DDO_SECROLENAME_Cls");
            Ddo_secrolename_Filteredtext_set = cgiGet( sPrefix+"DDO_SECROLENAME_Filteredtext_set");
            Ddo_secrolename_Selectedvalue_set = cgiGet( sPrefix+"DDO_SECROLENAME_Selectedvalue_set");
            Ddo_secrolename_Dropdownoptionstype = cgiGet( sPrefix+"DDO_SECROLENAME_Dropdownoptionstype");
            Ddo_secrolename_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_SECROLENAME_Titlecontrolidtoreplace");
            Ddo_secrolename_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_SECROLENAME_Includesortasc"));
            Ddo_secrolename_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_SECROLENAME_Includesortdsc"));
            Ddo_secrolename_Sortedstatus = cgiGet( sPrefix+"DDO_SECROLENAME_Sortedstatus");
            Ddo_secrolename_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_SECROLENAME_Includefilter"));
            Ddo_secrolename_Filtertype = cgiGet( sPrefix+"DDO_SECROLENAME_Filtertype");
            Ddo_secrolename_Filterisrange = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_SECROLENAME_Filterisrange"));
            Ddo_secrolename_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_SECROLENAME_Includedatalist"));
            Ddo_secrolename_Datalisttype = cgiGet( sPrefix+"DDO_SECROLENAME_Datalisttype");
            Ddo_secrolename_Datalistproc = cgiGet( sPrefix+"DDO_SECROLENAME_Datalistproc");
            Ddo_secrolename_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( sPrefix+"DDO_SECROLENAME_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_secrolename_Sortasc = cgiGet( sPrefix+"DDO_SECROLENAME_Sortasc");
            Ddo_secrolename_Sortdsc = cgiGet( sPrefix+"DDO_SECROLENAME_Sortdsc");
            Ddo_secrolename_Loadingdata = cgiGet( sPrefix+"DDO_SECROLENAME_Loadingdata");
            Ddo_secrolename_Cleanfilter = cgiGet( sPrefix+"DDO_SECROLENAME_Cleanfilter");
            Ddo_secrolename_Noresultsfound = cgiGet( sPrefix+"DDO_SECROLENAME_Noresultsfound");
            Ddo_secrolename_Searchbuttontext = cgiGet( sPrefix+"DDO_SECROLENAME_Searchbuttontext");
            Ddo_secroledescription_Caption = cgiGet( sPrefix+"DDO_SECROLEDESCRIPTION_Caption");
            Ddo_secroledescription_Tooltip = cgiGet( sPrefix+"DDO_SECROLEDESCRIPTION_Tooltip");
            Ddo_secroledescription_Cls = cgiGet( sPrefix+"DDO_SECROLEDESCRIPTION_Cls");
            Ddo_secroledescription_Filteredtext_set = cgiGet( sPrefix+"DDO_SECROLEDESCRIPTION_Filteredtext_set");
            Ddo_secroledescription_Selectedvalue_set = cgiGet( sPrefix+"DDO_SECROLEDESCRIPTION_Selectedvalue_set");
            Ddo_secroledescription_Dropdownoptionstype = cgiGet( sPrefix+"DDO_SECROLEDESCRIPTION_Dropdownoptionstype");
            Ddo_secroledescription_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_SECROLEDESCRIPTION_Titlecontrolidtoreplace");
            Ddo_secroledescription_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_SECROLEDESCRIPTION_Includesortasc"));
            Ddo_secroledescription_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_SECROLEDESCRIPTION_Includesortdsc"));
            Ddo_secroledescription_Sortedstatus = cgiGet( sPrefix+"DDO_SECROLEDESCRIPTION_Sortedstatus");
            Ddo_secroledescription_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_SECROLEDESCRIPTION_Includefilter"));
            Ddo_secroledescription_Filtertype = cgiGet( sPrefix+"DDO_SECROLEDESCRIPTION_Filtertype");
            Ddo_secroledescription_Filterisrange = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_SECROLEDESCRIPTION_Filterisrange"));
            Ddo_secroledescription_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_SECROLEDESCRIPTION_Includedatalist"));
            Ddo_secroledescription_Datalisttype = cgiGet( sPrefix+"DDO_SECROLEDESCRIPTION_Datalisttype");
            Ddo_secroledescription_Datalistproc = cgiGet( sPrefix+"DDO_SECROLEDESCRIPTION_Datalistproc");
            Ddo_secroledescription_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( sPrefix+"DDO_SECROLEDESCRIPTION_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_secroledescription_Sortasc = cgiGet( sPrefix+"DDO_SECROLEDESCRIPTION_Sortasc");
            Ddo_secroledescription_Sortdsc = cgiGet( sPrefix+"DDO_SECROLEDESCRIPTION_Sortdsc");
            Ddo_secroledescription_Loadingdata = cgiGet( sPrefix+"DDO_SECROLEDESCRIPTION_Loadingdata");
            Ddo_secroledescription_Cleanfilter = cgiGet( sPrefix+"DDO_SECROLEDESCRIPTION_Cleanfilter");
            Ddo_secroledescription_Noresultsfound = cgiGet( sPrefix+"DDO_SECROLEDESCRIPTION_Noresultsfound");
            Ddo_secroledescription_Searchbuttontext = cgiGet( sPrefix+"DDO_SECROLEDESCRIPTION_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_secrolename_Activeeventkey = cgiGet( sPrefix+"DDO_SECROLENAME_Activeeventkey");
            Ddo_secrolename_Filteredtext_get = cgiGet( sPrefix+"DDO_SECROLENAME_Filteredtext_get");
            Ddo_secrolename_Selectedvalue_get = cgiGet( sPrefix+"DDO_SECROLENAME_Selectedvalue_get");
            Ddo_secroledescription_Activeeventkey = cgiGet( sPrefix+"DDO_SECROLEDESCRIPTION_Activeeventkey");
            Ddo_secroledescription_Filteredtext_get = cgiGet( sPrefix+"DDO_SECROLEDESCRIPTION_Filteredtext_get");
            Ddo_secroledescription_Selectedvalue_get = cgiGet( sPrefix+"DDO_SECROLEDESCRIPTION_Selectedvalue_get");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            forbiddenHiddens = sPrefix + "hsh" + "SecFunctionalitySecFunctionalityRoleWC";
            A1SecFunctionalityId = (long)(context.localUtil.CToN( cgiGet( edtSecFunctionalityId_Internalname), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A1SecFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SecFunctionalityId), 10, 0)));
            forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A1SecFunctionalityId), "ZZZZZZZZZ9");
            hsh = cgiGet( sPrefix+"hsh");
            if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
            {
               GXUtil.WriteLog("wwpbaseobjects.secfunctionalitysecfunctionalityrolewc:[SecurityCheckFailed value for]"+"SecFunctionalityId:"+context.localUtil.Format( (decimal)(A1SecFunctionalityId), "ZZZZZZZZZ9"));
               GxWebError = 1;
               context.HttpContext.Response.StatusDescription = 403.ToString();
               context.HttpContext.Response.StatusCode = 403;
               context.WriteHtmlText( "<title>403 Forbidden</title>") ;
               context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
               context.WriteHtmlText( "<p /><hr />") ;
               GXUtil.WriteLog("send_http_error_code " + 403.ToString());
               return  ;
            }
            /* Check if conditions changed and reset current page numbers */
            if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vSECROLENAME"), AV46SecRoleName) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV16OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( sPrefix+"GXH_vORDEREDDSC")) != AV17OrderedDsc )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFSECROLENAME"), AV23TFSecRoleName) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFSECROLENAME_SEL"), AV24TFSecRoleName_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFSECROLEDESCRIPTION"), AV27TFSecRoleDescription) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFSECROLEDESCRIPTION_SEL"), AV28TFSecRoleDescription_Sel) != 0 )
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
         E150S2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E150S2( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GXt_boolean1 = AV13IsAuthorized_SecRoleName;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWSecRole", out  GXt_boolean1) ;
         AV13IsAuthorized_SecRoleName = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13IsAuthorized_SecRoleName", AV13IsAuthorized_SecRoleName);
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, sPrefix+"gxhash_vISAUTHORIZED_SECROLENAME", GetSecureSignedToken( sPrefix, AV13IsAuthorized_SecRoleName, context));
         edtavTfsecrolename_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTfsecrolename_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfsecrolename_Visible), 5, 0)), true);
         edtavTfsecrolename_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTfsecrolename_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfsecrolename_sel_Visible), 5, 0)), true);
         edtavTfsecroledescription_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTfsecroledescription_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfsecroledescription_Visible), 5, 0)), true);
         edtavTfsecroledescription_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTfsecroledescription_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfsecroledescription_sel_Visible), 5, 0)), true);
         Ddo_secrolename_Titlecontrolidtoreplace = subGrid_Internalname+"_SecRoleName";
         ucDdo_secrolename.SendProperty(context, sPrefix, false, Ddo_secrolename_Internalname, "TitleControlIdToReplace", Ddo_secrolename_Titlecontrolidtoreplace);
         AV25ddo_SecRoleNameTitleControlIdToReplace = Ddo_secrolename_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV25ddo_SecRoleNameTitleControlIdToReplace", AV25ddo_SecRoleNameTitleControlIdToReplace);
         edtavDdo_secrolenametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_secrolenametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_secrolenametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_secroledescription_Titlecontrolidtoreplace = subGrid_Internalname+"_SecRoleDescription";
         ucDdo_secroledescription.SendProperty(context, sPrefix, false, Ddo_secroledescription_Internalname, "TitleControlIdToReplace", Ddo_secroledescription_Titlecontrolidtoreplace);
         AV29ddo_SecRoleDescriptionTitleControlIdToReplace = Ddo_secroledescription_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV29ddo_SecRoleDescriptionTitleControlIdToReplace", AV29ddo_SecRoleDescriptionTitleControlIdToReplace);
         edtavDdo_secroledescriptiontitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_secroledescriptiontitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_secroledescriptiontitlecontrolidtoreplace_Visible), 5, 0)), true);
         edtSecFunctionalityId_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtSecFunctionalityId_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecFunctionalityId_Visible), 5, 0)), true);
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
         if ( AV16OrderedBy < 1 )
         {
            AV16OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV16OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16OrderedBy), 4, 0)));
            /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
            S132 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
         edtavOrdereddsc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavOrdereddsc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrdereddsc_Visible), 5, 0)), true);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV30DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV30DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, sPrefix, false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E160S2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV22SecRoleNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV26SecRoleDescriptionTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV38WWPContext) ;
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
         edtSecRoleName_Titleformat = 2;
         edtSecRoleName_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "角色名称", AV25ddo_SecRoleNameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtSecRoleName_Internalname, "Title", edtSecRoleName_Title, !bGXsfl_29_Refreshing);
         edtSecRoleDescription_Titleformat = 2;
         edtSecRoleDescription_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "角色描述", AV29ddo_SecRoleDescriptionTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtSecRoleDescription_Internalname, "Title", edtSecRoleDescription_Title, !bGXsfl_29_Refreshing);
         AV40GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV40GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV40GridCurrentPage), 10, 0)));
         AV42GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV42GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42GridPageSize), 10, 0)));
         AV43GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV43GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV43GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV22SecRoleNameTitleFilterData", AV22SecRoleNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV26SecRoleDescriptionTitleFilterData", AV26SecRoleDescriptionTitleFilterData);
      }

      protected void E110S2( )
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
            AV39PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV39PageToGo) ;
         }
      }

      protected void E120S2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E130S2( )
      {
         /* Ddo_secrolename_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_secrolename_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV16OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV16OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16OrderedBy), 4, 0)));
            AV17OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV17OrderedDsc", AV17OrderedDsc);
            Ddo_secrolename_Sortedstatus = "ASC";
            ucDdo_secrolename.SendProperty(context, sPrefix, false, Ddo_secrolename_Internalname, "SortedStatus", Ddo_secrolename_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_secrolename_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV16OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV16OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16OrderedBy), 4, 0)));
            AV17OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV17OrderedDsc", AV17OrderedDsc);
            Ddo_secrolename_Sortedstatus = "DSC";
            ucDdo_secrolename.SendProperty(context, sPrefix, false, Ddo_secrolename_Internalname, "SortedStatus", Ddo_secrolename_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_secrolename_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV23TFSecRoleName = Ddo_secrolename_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV23TFSecRoleName", AV23TFSecRoleName);
            AV24TFSecRoleName_Sel = Ddo_secrolename_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV24TFSecRoleName_Sel", AV24TFSecRoleName_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV22SecRoleNameTitleFilterData", AV22SecRoleNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV26SecRoleDescriptionTitleFilterData", AV26SecRoleDescriptionTitleFilterData);
      }

      protected void E140S2( )
      {
         /* Ddo_secroledescription_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_secroledescription_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV16OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV16OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16OrderedBy), 4, 0)));
            AV17OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV17OrderedDsc", AV17OrderedDsc);
            Ddo_secroledescription_Sortedstatus = "ASC";
            ucDdo_secroledescription.SendProperty(context, sPrefix, false, Ddo_secroledescription_Internalname, "SortedStatus", Ddo_secroledescription_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_secroledescription_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV16OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV16OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16OrderedBy), 4, 0)));
            AV17OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV17OrderedDsc", AV17OrderedDsc);
            Ddo_secroledescription_Sortedstatus = "DSC";
            ucDdo_secroledescription.SendProperty(context, sPrefix, false, Ddo_secroledescription_Internalname, "SortedStatus", Ddo_secroledescription_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_secroledescription_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV27TFSecRoleDescription = Ddo_secroledescription_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV27TFSecRoleDescription", AV27TFSecRoleDescription);
            AV28TFSecRoleDescription_Sel = Ddo_secroledescription_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV28TFSecRoleDescription_Sel", AV28TFSecRoleDescription_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV22SecRoleNameTitleFilterData", AV22SecRoleNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV26SecRoleDescriptionTitleFilterData", AV26SecRoleDescriptionTitleFilterData);
      }

      private void E170S2( )
      {
         /* Grid_Load Routine */
         AV18Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtavDelete_Internalname, AV18Delete);
         AV49Delete_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavDelete_Tooltiptext = "删除";
         if ( AV20IsAuthorized_Delete )
         {
            edtavDelete_Link = formatLink("wwpbaseobjects.secfunctionalityrole.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A1SecFunctionalityId) + "," + UrlEncode("" +A4SecRoleId);
         }
         if ( AV13IsAuthorized_SecRoleName )
         {
            edtSecRoleName_Link = formatLink("wwpbaseobjects.secroleview.aspx") + "?" + UrlEncode("" +A4SecRoleId) + "," + UrlEncode(StringUtil.RTrim(""));
         }
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 29;
         }
         sendrow_292( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_29_Refreshing )
         {
            context.DoAjaxLoad(29, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void S162( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_secrolename_Sortedstatus = "";
         ucDdo_secrolename.SendProperty(context, sPrefix, false, Ddo_secrolename_Internalname, "SortedStatus", Ddo_secrolename_Sortedstatus);
         Ddo_secroledescription_Sortedstatus = "";
         ucDdo_secroledescription.SendProperty(context, sPrefix, false, Ddo_secroledescription_Internalname, "SortedStatus", Ddo_secroledescription_Sortedstatus);
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
         if ( AV16OrderedBy == 1 )
         {
            Ddo_secrolename_Sortedstatus = (AV17OrderedDsc ? "DSC" : "ASC");
            ucDdo_secrolename.SendProperty(context, sPrefix, false, Ddo_secrolename_Internalname, "SortedStatus", Ddo_secrolename_Sortedstatus);
         }
         else if ( AV16OrderedBy == 2 )
         {
            Ddo_secroledescription_Sortedstatus = (AV17OrderedDsc ? "DSC" : "ASC");
            ucDdo_secroledescription.SendProperty(context, sPrefix, false, Ddo_secroledescription_Internalname, "SortedStatus", Ddo_secroledescription_Sortedstatus);
         }
      }

      protected void S142( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean1 = AV20IsAuthorized_Delete;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyobjectname(context ).execute(  "SecFunctionalityRole", out  GXt_boolean1) ;
         AV20IsAuthorized_Delete = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20IsAuthorized_Delete", AV20IsAuthorized_Delete);
         if ( ! ( AV20IsAuthorized_Delete ) )
         {
            edtavDelete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Visible), 5, 0)), !bGXsfl_29_Refreshing);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV12Session.Get(AV50Pgmname+"GridState"), "") == 0 )
         {
            AV14GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV50Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV14GridState.FromXml(AV12Session.Get(AV50Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV16OrderedBy = AV14GridState.gxTpr_Orderedby;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV16OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16OrderedBy), 4, 0)));
         AV17OrderedDsc = AV14GridState.gxTpr_Ordereddsc;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV17OrderedDsc", AV17OrderedDsc);
         /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV51GXV1 = 1;
         while ( AV51GXV1 <= AV14GridState.gxTpr_Filtervalues.Count )
         {
            AV15GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV14GridState.gxTpr_Filtervalues.Item(AV51GXV1));
            if ( StringUtil.StrCmp(AV15GridStateFilterValue.gxTpr_Name, "SECROLENAME") == 0 )
            {
               AV46SecRoleName = AV15GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV46SecRoleName", AV46SecRoleName);
            }
            else if ( StringUtil.StrCmp(AV15GridStateFilterValue.gxTpr_Name, "TFSECROLENAME") == 0 )
            {
               AV23TFSecRoleName = AV15GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV23TFSecRoleName", AV23TFSecRoleName);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV23TFSecRoleName)) )
               {
                  Ddo_secrolename_Filteredtext_set = AV23TFSecRoleName;
                  ucDdo_secrolename.SendProperty(context, sPrefix, false, Ddo_secrolename_Internalname, "FilteredText_set", Ddo_secrolename_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV15GridStateFilterValue.gxTpr_Name, "TFSECROLENAME_SEL") == 0 )
            {
               AV24TFSecRoleName_Sel = AV15GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV24TFSecRoleName_Sel", AV24TFSecRoleName_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV24TFSecRoleName_Sel)) )
               {
                  Ddo_secrolename_Selectedvalue_set = AV24TFSecRoleName_Sel;
                  ucDdo_secrolename.SendProperty(context, sPrefix, false, Ddo_secrolename_Internalname, "SelectedValue_set", Ddo_secrolename_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV15GridStateFilterValue.gxTpr_Name, "TFSECROLEDESCRIPTION") == 0 )
            {
               AV27TFSecRoleDescription = AV15GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV27TFSecRoleDescription", AV27TFSecRoleDescription);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV27TFSecRoleDescription)) )
               {
                  Ddo_secroledescription_Filteredtext_set = AV27TFSecRoleDescription;
                  ucDdo_secroledescription.SendProperty(context, sPrefix, false, Ddo_secroledescription_Internalname, "FilteredText_set", Ddo_secroledescription_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV15GridStateFilterValue.gxTpr_Name, "TFSECROLEDESCRIPTION_SEL") == 0 )
            {
               AV28TFSecRoleDescription_Sel = AV15GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV28TFSecRoleDescription_Sel", AV28TFSecRoleDescription_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV28TFSecRoleDescription_Sel)) )
               {
                  Ddo_secroledescription_Selectedvalue_set = AV28TFSecRoleDescription_Sel;
                  ucDdo_secroledescription.SendProperty(context, sPrefix, false, Ddo_secroledescription_Internalname, "SelectedValue_set", Ddo_secroledescription_Selectedvalue_set);
               }
            }
            AV51GXV1 = (int)(AV51GXV1+1);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV14GridState.gxTpr_Pagesize))) )
         {
            subGrid_Rows = (int)(NumberUtil.Val( AV14GridState.gxTpr_Pagesize, "."));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         }
      }

      protected void S152( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV14GridState.FromXml(AV12Session.Get(AV50Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV14GridState.gxTpr_Orderedby = AV16OrderedBy;
         AV14GridState.gxTpr_Ordereddsc = AV17OrderedDsc;
         AV14GridState.gxTpr_Filtervalues.Clear();
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV46SecRoleName)) )
         {
            AV15GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV15GridStateFilterValue.gxTpr_Name = "SECROLENAME";
            AV15GridStateFilterValue.gxTpr_Value = AV46SecRoleName;
            AV14GridState.gxTpr_Filtervalues.Add(AV15GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV23TFSecRoleName)) )
         {
            AV15GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV15GridStateFilterValue.gxTpr_Name = "TFSECROLENAME";
            AV15GridStateFilterValue.gxTpr_Value = AV23TFSecRoleName;
            AV14GridState.gxTpr_Filtervalues.Add(AV15GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV24TFSecRoleName_Sel)) )
         {
            AV15GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV15GridStateFilterValue.gxTpr_Name = "TFSECROLENAME_SEL";
            AV15GridStateFilterValue.gxTpr_Value = AV24TFSecRoleName_Sel;
            AV14GridState.gxTpr_Filtervalues.Add(AV15GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV27TFSecRoleDescription)) )
         {
            AV15GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV15GridStateFilterValue.gxTpr_Name = "TFSECROLEDESCRIPTION";
            AV15GridStateFilterValue.gxTpr_Value = AV27TFSecRoleDescription;
            AV14GridState.gxTpr_Filtervalues.Add(AV15GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV28TFSecRoleDescription_Sel)) )
         {
            AV15GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV15GridStateFilterValue.gxTpr_Name = "TFSECROLEDESCRIPTION_SEL";
            AV15GridStateFilterValue.gxTpr_Value = AV28TFSecRoleDescription_Sel;
            AV14GridState.gxTpr_Filtervalues.Add(AV15GridStateFilterValue, 0);
         }
         if ( ! (0==AV8SecFunctionalityId) )
         {
            AV15GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV15GridStateFilterValue.gxTpr_Name = "PARM_&SECFUNCTIONALITYID";
            AV15GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV8SecFunctionalityId), 10, 0);
            AV14GridState.gxTpr_Filtervalues.Add(AV15GridStateFilterValue, 0);
         }
         AV14GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV50Pgmname+"GridState",  AV14GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV10TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV10TrnContext.gxTpr_Callerobject = AV50Pgmname;
         AV10TrnContext.gxTpr_Callerondelete = true;
         AV10TrnContext.gxTpr_Callerurl = AV9HTTPRequest.ScriptName+"?"+AV9HTTPRequest.QueryString;
         AV10TrnContext.gxTpr_Transactionname = "WWPBaseObjects.SecFunctionalityRole";
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11TrnContextAtt.gxTpr_Attributename = "SecFunctionalityId";
         AV11TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8SecFunctionalityId), 10, 0);
         AV10TrnContext.gxTpr_Attributes.Add(AV11TrnContextAtt, 0);
         AV12Session.Set("TrnContext", AV10TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV8SecFunctionalityId = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8SecFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8SecFunctionalityId), 10, 0)));
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
         PA0S2( ) ;
         WS0S2( ) ;
         WE0S2( ) ;
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
         sCtrlAV8SecFunctionalityId = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA0S2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "wwpbaseobjects\\secfunctionalitysecfunctionalityrolewc", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA0S2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV8SecFunctionalityId = Convert.ToInt64(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8SecFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8SecFunctionalityId), 10, 0)));
         }
         wcpOAV8SecFunctionalityId = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV8SecFunctionalityId"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( AV8SecFunctionalityId != wcpOAV8SecFunctionalityId ) ) )
         {
            setjustcreated();
         }
         wcpOAV8SecFunctionalityId = AV8SecFunctionalityId;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV8SecFunctionalityId = cgiGet( sPrefix+"AV8SecFunctionalityId_CTRL");
         if ( StringUtil.Len( sCtrlAV8SecFunctionalityId) > 0 )
         {
            AV8SecFunctionalityId = (long)(context.localUtil.CToN( cgiGet( sCtrlAV8SecFunctionalityId), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8SecFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8SecFunctionalityId), 10, 0)));
         }
         else
         {
            AV8SecFunctionalityId = (long)(context.localUtil.CToN( cgiGet( sPrefix+"AV8SecFunctionalityId_PARM"), ".", ","));
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
         PA0S2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS0S2( ) ;
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
         WS0S2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"AV8SecFunctionalityId_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8SecFunctionalityId), 10, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV8SecFunctionalityId)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV8SecFunctionalityId_CTRL", StringUtil.RTrim( sCtrlAV8SecFunctionalityId));
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
         WE0S2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022711553951", true);
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
         context.AddJavascriptSource("wwpbaseobjects/secfunctionalitysecfunctionalityrolewc.js", "?202022711553951", false);
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

      protected void SubsflControlProps_292( )
      {
         edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_29_idx;
         edtSecRoleId_Internalname = sPrefix+"SECROLEID_"+sGXsfl_29_idx;
         edtSecRoleName_Internalname = sPrefix+"SECROLENAME_"+sGXsfl_29_idx;
         edtSecRoleDescription_Internalname = sPrefix+"SECROLEDESCRIPTION_"+sGXsfl_29_idx;
      }

      protected void SubsflControlProps_fel_292( )
      {
         edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_29_fel_idx;
         edtSecRoleId_Internalname = sPrefix+"SECROLEID_"+sGXsfl_29_fel_idx;
         edtSecRoleName_Internalname = sPrefix+"SECROLENAME_"+sGXsfl_29_fel_idx;
         edtSecRoleDescription_Internalname = sPrefix+"SECROLEDESCRIPTION_"+sGXsfl_29_fel_idx;
      }

      protected void sendrow_292( )
      {
         SubsflControlProps_292( ) ;
         WB0S0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_29_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_29_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_29_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "DeleteAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV18Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV18Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV49Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV18Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV18Delete)) ? AV49Delete_GXI : context.PathToRelativeUrl( AV18Delete));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)edtavDelete_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavDelete_Visible,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV18Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecRoleId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A4SecRoleId), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A4SecRoleId), "ZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSecRoleId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)29,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecRoleName_Internalname,(String)A13SecRoleName,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)edtSecRoleName_Link,(String)"",(String)"",(String)"",(String)edtSecRoleName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)29,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecRoleDescription_Internalname,(String)A12SecRoleDescription,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSecRoleDescription_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)120,(short)0,(short)0,(short)29,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes0S2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_29_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_29_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_29_idx+1));
            sGXsfl_29_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_29_idx), 4, 0)), 4, "0");
            SubsflControlProps_292( ) ;
         }
         /* End function sendrow_292 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblFiltertextsecrolename_Internalname = sPrefix+"FILTERTEXTSECROLENAME";
         edtavSecrolename_Internalname = sPrefix+"vSECROLENAME";
         divUnnamedtableecrolename_Internalname = sPrefix+"UNNAMEDTABLEECROLENAME";
         divTableheader_Internalname = sPrefix+"TABLEHEADER";
         divLayout_tableheader_Internalname = sPrefix+"LAYOUT_TABLEHEADER";
         Dvpanel_tableheader_Internalname = sPrefix+"DVPANEL_TABLEHEADER";
         divHtml_dvpanel_tableheader_Internalname = sPrefix+"HTML_DVPANEL_TABLEHEADER";
         edtavDelete_Internalname = sPrefix+"vDELETE";
         edtSecRoleId_Internalname = sPrefix+"SECROLEID";
         edtSecRoleName_Internalname = sPrefix+"SECROLENAME";
         edtSecRoleDescription_Internalname = sPrefix+"SECROLEDESCRIPTION";
         Gridpaginationbar_Internalname = sPrefix+"GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = sPrefix+"HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = sPrefix+"GRIDTABLEWITHPAGINATIONBAR";
         divTablegridheader_Internalname = sPrefix+"TABLEGRIDHEADER";
         Ddo_secrolename_Internalname = sPrefix+"DDO_SECROLENAME";
         edtavDdo_secrolenametitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_SECROLENAMETITLECONTROLIDTOREPLACE";
         Ddo_secroledescription_Internalname = sPrefix+"DDO_SECROLEDESCRIPTION";
         edtavDdo_secroledescriptiontitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE";
         edtSecFunctionalityId_Internalname = sPrefix+"SECFUNCTIONALITYID";
         Workwithplusutilities1_Internalname = sPrefix+"WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = sPrefix+"vORDEREDBY";
         edtavOrdereddsc_Internalname = sPrefix+"vORDEREDDSC";
         edtavTfsecrolename_Internalname = sPrefix+"vTFSECROLENAME";
         edtavTfsecrolename_sel_Internalname = sPrefix+"vTFSECROLENAME_SEL";
         edtavTfsecroledescription_Internalname = sPrefix+"vTFSECROLEDESCRIPTION";
         edtavTfsecroledescription_sel_Internalname = sPrefix+"vTFSECROLEDESCRIPTION_SEL";
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
         edtSecRoleDescription_Jsonclick = "";
         edtSecRoleName_Jsonclick = "";
         edtSecRoleId_Jsonclick = "";
         edtavTfsecroledescription_sel_Jsonclick = "";
         edtavTfsecroledescription_sel_Visible = 1;
         edtavTfsecroledescription_Jsonclick = "";
         edtavTfsecroledescription_Visible = 1;
         edtavTfsecrolename_sel_Jsonclick = "";
         edtavTfsecrolename_sel_Visible = 1;
         edtavTfsecrolename_Jsonclick = "";
         edtavTfsecrolename_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtSecFunctionalityId_Jsonclick = "";
         edtSecFunctionalityId_Visible = 1;
         edtavDdo_secroledescriptiontitlecontrolidtoreplace_Visible = 1;
         edtavDdo_secrolenametitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtSecRoleName_Link = "";
         edtavDelete_Tooltiptext = "删除";
         edtavDelete_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtSecRoleDescription_Titleformat = 0;
         edtSecRoleDescription_Title = "角色描述";
         edtSecRoleName_Titleformat = 0;
         edtSecRoleName_Title = "角色名称";
         edtavDelete_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         edtavSecrolename_Jsonclick = "";
         edtavSecrolename_Enabled = 1;
         Ddo_secroledescription_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_secroledescription_Noresultsfound = "WWP_TSNoResults";
         Ddo_secroledescription_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_secroledescription_Loadingdata = "WWP_TSLoading";
         Ddo_secroledescription_Sortdsc = "WWP_TSSortDSC";
         Ddo_secroledescription_Sortasc = "WWP_TSSortASC";
         Ddo_secroledescription_Datalistupdateminimumcharacters = 0;
         Ddo_secroledescription_Datalistproc = "WWPBaseObjects.SecFunctionalitySecFunctionalityRoleWCGetFilterData";
         Ddo_secroledescription_Datalisttype = "Dynamic";
         Ddo_secroledescription_Includedatalist = Convert.ToBoolean( -1);
         Ddo_secroledescription_Filterisrange = Convert.ToBoolean( 0);
         Ddo_secroledescription_Filtertype = "Character";
         Ddo_secroledescription_Includefilter = Convert.ToBoolean( -1);
         Ddo_secroledescription_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_secroledescription_Includesortasc = Convert.ToBoolean( -1);
         Ddo_secroledescription_Titlecontrolidtoreplace = "";
         Ddo_secroledescription_Dropdownoptionstype = "GridTitleSettings";
         Ddo_secroledescription_Cls = "ColumnSettings";
         Ddo_secroledescription_Tooltip = "WWP_TSColumnOptions";
         Ddo_secroledescription_Caption = "";
         Ddo_secrolename_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_secrolename_Noresultsfound = "WWP_TSNoResults";
         Ddo_secrolename_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_secrolename_Loadingdata = "WWP_TSLoading";
         Ddo_secrolename_Sortdsc = "WWP_TSSortDSC";
         Ddo_secrolename_Sortasc = "WWP_TSSortASC";
         Ddo_secrolename_Datalistupdateminimumcharacters = 0;
         Ddo_secrolename_Datalistproc = "WWPBaseObjects.SecFunctionalitySecFunctionalityRoleWCGetFilterData";
         Ddo_secrolename_Datalisttype = "Dynamic";
         Ddo_secrolename_Includedatalist = Convert.ToBoolean( -1);
         Ddo_secrolename_Filterisrange = Convert.ToBoolean( 0);
         Ddo_secrolename_Filtertype = "Character";
         Ddo_secrolename_Includefilter = Convert.ToBoolean( -1);
         Ddo_secrolename_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_secrolename_Includesortasc = Convert.ToBoolean( -1);
         Ddo_secrolename_Titlecontrolidtoreplace = "";
         Ddo_secrolename_Dropdownoptionstype = "GridTitleSettings";
         Ddo_secrolename_Cls = "ColumnSettings";
         Ddo_secrolename_Tooltip = "WWP_TSColumnOptions";
         Ddo_secrolename_Caption = "";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV20IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'AV25ddo_SecRoleNameTitleControlIdToReplace',fld:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_SecRoleDescriptionTitleControlIdToReplace',fld:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV50Pgmname',fld:'vPGMNAME',pic:''},{av:'AV16OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV17OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV46SecRoleName',fld:'vSECROLENAME',pic:''},{av:'AV23TFSecRoleName',fld:'vTFSECROLENAME',pic:''},{av:'AV24TFSecRoleName_Sel',fld:'vTFSECROLENAME_SEL',pic:''},{av:'AV27TFSecRoleDescription',fld:'vTFSECROLEDESCRIPTION',pic:''},{av:'AV28TFSecRoleDescription_Sel',fld:'vTFSECROLEDESCRIPTION_SEL',pic:''},{av:'AV8SecFunctionalityId',fld:'vSECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'AV13IsAuthorized_SecRoleName',fld:'vISAUTHORIZED_SECROLENAME',pic:'',hsh:true},{av:'A1SecFunctionalityId',fld:'SECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV22SecRoleNameTitleFilterData',fld:'vSECROLENAMETITLEFILTERDATA',pic:''},{av:'AV26SecRoleDescriptionTitleFilterData',fld:'vSECROLEDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtSecRoleName_Titleformat',ctrl:'SECROLENAME',prop:'Titleformat'},{av:'edtSecRoleName_Title',ctrl:'SECROLENAME',prop:'Title'},{av:'edtSecRoleDescription_Titleformat',ctrl:'SECROLEDESCRIPTION',prop:'Titleformat'},{av:'edtSecRoleDescription_Title',ctrl:'SECROLEDESCRIPTION',prop:'Title'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV20IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E110S2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV46SecRoleName',fld:'vSECROLENAME',pic:''},{av:'AV16OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV17OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV23TFSecRoleName',fld:'vTFSECROLENAME',pic:''},{av:'AV24TFSecRoleName_Sel',fld:'vTFSECROLENAME_SEL',pic:''},{av:'AV27TFSecRoleDescription',fld:'vTFSECROLEDESCRIPTION',pic:''},{av:'AV28TFSecRoleDescription_Sel',fld:'vTFSECROLEDESCRIPTION_SEL',pic:''},{av:'AV8SecFunctionalityId',fld:'vSECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'AV25ddo_SecRoleNameTitleControlIdToReplace',fld:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_SecRoleDescriptionTitleControlIdToReplace',fld:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50Pgmname',fld:'vPGMNAME',pic:''},{av:'AV20IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV13IsAuthorized_SecRoleName',fld:'vISAUTHORIZED_SECROLENAME',pic:'',hsh:true},{av:'A1SecFunctionalityId',fld:'SECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'sPrefix'},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E120S2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV46SecRoleName',fld:'vSECROLENAME',pic:''},{av:'AV16OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV17OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV23TFSecRoleName',fld:'vTFSECROLENAME',pic:''},{av:'AV24TFSecRoleName_Sel',fld:'vTFSECROLENAME_SEL',pic:''},{av:'AV27TFSecRoleDescription',fld:'vTFSECROLEDESCRIPTION',pic:''},{av:'AV28TFSecRoleDescription_Sel',fld:'vTFSECROLEDESCRIPTION_SEL',pic:''},{av:'AV8SecFunctionalityId',fld:'vSECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'AV25ddo_SecRoleNameTitleControlIdToReplace',fld:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_SecRoleDescriptionTitleControlIdToReplace',fld:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50Pgmname',fld:'vPGMNAME',pic:''},{av:'AV20IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV13IsAuthorized_SecRoleName',fld:'vISAUTHORIZED_SECROLENAME',pic:'',hsh:true},{av:'A1SecFunctionalityId',fld:'SECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'sPrefix'},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_SECROLENAME.ONOPTIONCLICKED","{handler:'E130S2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV46SecRoleName',fld:'vSECROLENAME',pic:''},{av:'AV16OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV17OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV23TFSecRoleName',fld:'vTFSECROLENAME',pic:''},{av:'AV24TFSecRoleName_Sel',fld:'vTFSECROLENAME_SEL',pic:''},{av:'AV27TFSecRoleDescription',fld:'vTFSECROLEDESCRIPTION',pic:''},{av:'AV28TFSecRoleDescription_Sel',fld:'vTFSECROLEDESCRIPTION_SEL',pic:''},{av:'AV8SecFunctionalityId',fld:'vSECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'AV25ddo_SecRoleNameTitleControlIdToReplace',fld:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_SecRoleDescriptionTitleControlIdToReplace',fld:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50Pgmname',fld:'vPGMNAME',pic:''},{av:'AV20IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV13IsAuthorized_SecRoleName',fld:'vISAUTHORIZED_SECROLENAME',pic:'',hsh:true},{av:'A1SecFunctionalityId',fld:'SECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'sPrefix'},{av:'Ddo_secrolename_Activeeventkey',ctrl:'DDO_SECROLENAME',prop:'ActiveEventKey'},{av:'Ddo_secrolename_Filteredtext_get',ctrl:'DDO_SECROLENAME',prop:'FilteredText_get'},{av:'Ddo_secrolename_Selectedvalue_get',ctrl:'DDO_SECROLENAME',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_SECROLENAME.ONOPTIONCLICKED",",oparms:[{av:'AV16OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV17OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_secrolename_Sortedstatus',ctrl:'DDO_SECROLENAME',prop:'SortedStatus'},{av:'AV23TFSecRoleName',fld:'vTFSECROLENAME',pic:''},{av:'AV24TFSecRoleName_Sel',fld:'vTFSECROLENAME_SEL',pic:''},{av:'Ddo_secroledescription_Sortedstatus',ctrl:'DDO_SECROLEDESCRIPTION',prop:'SortedStatus'},{av:'AV22SecRoleNameTitleFilterData',fld:'vSECROLENAMETITLEFILTERDATA',pic:''},{av:'AV26SecRoleDescriptionTitleFilterData',fld:'vSECROLEDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtSecRoleName_Titleformat',ctrl:'SECROLENAME',prop:'Titleformat'},{av:'edtSecRoleName_Title',ctrl:'SECROLENAME',prop:'Title'},{av:'edtSecRoleDescription_Titleformat',ctrl:'SECROLEDESCRIPTION',prop:'Titleformat'},{av:'edtSecRoleDescription_Title',ctrl:'SECROLEDESCRIPTION',prop:'Title'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV20IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'}]}");
         setEventMetadata("DDO_SECROLEDESCRIPTION.ONOPTIONCLICKED","{handler:'E140S2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV46SecRoleName',fld:'vSECROLENAME',pic:''},{av:'AV16OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV17OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV23TFSecRoleName',fld:'vTFSECROLENAME',pic:''},{av:'AV24TFSecRoleName_Sel',fld:'vTFSECROLENAME_SEL',pic:''},{av:'AV27TFSecRoleDescription',fld:'vTFSECROLEDESCRIPTION',pic:''},{av:'AV28TFSecRoleDescription_Sel',fld:'vTFSECROLEDESCRIPTION_SEL',pic:''},{av:'AV8SecFunctionalityId',fld:'vSECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'AV25ddo_SecRoleNameTitleControlIdToReplace',fld:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_SecRoleDescriptionTitleControlIdToReplace',fld:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50Pgmname',fld:'vPGMNAME',pic:''},{av:'AV20IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV13IsAuthorized_SecRoleName',fld:'vISAUTHORIZED_SECROLENAME',pic:'',hsh:true},{av:'A1SecFunctionalityId',fld:'SECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'sPrefix'},{av:'Ddo_secroledescription_Activeeventkey',ctrl:'DDO_SECROLEDESCRIPTION',prop:'ActiveEventKey'},{av:'Ddo_secroledescription_Filteredtext_get',ctrl:'DDO_SECROLEDESCRIPTION',prop:'FilteredText_get'},{av:'Ddo_secroledescription_Selectedvalue_get',ctrl:'DDO_SECROLEDESCRIPTION',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_SECROLEDESCRIPTION.ONOPTIONCLICKED",",oparms:[{av:'AV16OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV17OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_secroledescription_Sortedstatus',ctrl:'DDO_SECROLEDESCRIPTION',prop:'SortedStatus'},{av:'AV27TFSecRoleDescription',fld:'vTFSECROLEDESCRIPTION',pic:''},{av:'AV28TFSecRoleDescription_Sel',fld:'vTFSECROLEDESCRIPTION_SEL',pic:''},{av:'Ddo_secrolename_Sortedstatus',ctrl:'DDO_SECROLENAME',prop:'SortedStatus'},{av:'AV22SecRoleNameTitleFilterData',fld:'vSECROLENAMETITLEFILTERDATA',pic:''},{av:'AV26SecRoleDescriptionTitleFilterData',fld:'vSECROLEDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtSecRoleName_Titleformat',ctrl:'SECROLENAME',prop:'Titleformat'},{av:'edtSecRoleName_Title',ctrl:'SECROLENAME',prop:'Title'},{av:'edtSecRoleDescription_Titleformat',ctrl:'SECROLEDESCRIPTION',prop:'Titleformat'},{av:'edtSecRoleDescription_Title',ctrl:'SECROLEDESCRIPTION',prop:'Title'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV20IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E170S2',iparms:[{av:'AV20IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'A1SecFunctionalityId',fld:'SECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9'},{av:'AV13IsAuthorized_SecRoleName',fld:'vISAUTHORIZED_SECROLENAME',pic:'',hsh:true}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV18Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'},{av:'edtSecRoleName_Link',ctrl:'SECROLENAME',prop:'Link'}]}");
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
         Ddo_secrolename_Activeeventkey = "";
         Ddo_secrolename_Filteredtext_get = "";
         Ddo_secrolename_Selectedvalue_get = "";
         Ddo_secroledescription_Activeeventkey = "";
         Ddo_secroledescription_Filteredtext_get = "";
         Ddo_secroledescription_Selectedvalue_get = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sPrefix = "";
         AV46SecRoleName = "";
         AV23TFSecRoleName = "";
         AV24TFSecRoleName_Sel = "";
         AV27TFSecRoleDescription = "";
         AV28TFSecRoleDescription_Sel = "";
         AV25ddo_SecRoleNameTitleControlIdToReplace = "";
         AV29ddo_SecRoleDescriptionTitleControlIdToReplace = "";
         AV50Pgmname = "";
         GXKey = "";
         forbiddenHiddens = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV30DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV22SecRoleNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV26SecRoleDescriptionTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_secrolename_Filteredtext_set = "";
         Ddo_secrolename_Selectedvalue_set = "";
         Ddo_secrolename_Sortedstatus = "";
         Ddo_secroledescription_Filteredtext_set = "";
         Ddo_secroledescription_Selectedvalue_set = "";
         Ddo_secroledescription_Sortedstatus = "";
         GX_FocusControl = "";
         ucDvpanel_tableheader = new GXUserControl();
         lblFiltertextsecrolename_Jsonclick = "";
         TempTags = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV18Delete = "";
         A13SecRoleName = "";
         A12SecRoleDescription = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_secrolename = new GXUserControl();
         ClassString = "";
         StyleString = "";
         ucDdo_secroledescription = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV49Delete_GXI = "";
         scmdbuf = "";
         lV46SecRoleName = "";
         lV23TFSecRoleName = "";
         lV27TFSecRoleDescription = "";
         H000S2_A1SecFunctionalityId = new long[1] ;
         H000S2_A12SecRoleDescription = new String[] {""} ;
         H000S2_A13SecRoleName = new String[] {""} ;
         H000S2_A4SecRoleId = new short[1] ;
         H000S3_AGRID_nRecordCount = new long[1] ;
         hsh = "";
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV38WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         AV12Session = context.GetSession();
         AV14GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV15GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV10TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9HTTPRequest = new GxHttpRequest( context);
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlAV8SecFunctionalityId = "";
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secfunctionalitysecfunctionalityrolewc__default(),
            new Object[][] {
                new Object[] {
               H000S2_A1SecFunctionalityId, H000S2_A12SecRoleDescription, H000S2_A13SecRoleName, H000S2_A4SecRoleId
               }
               , new Object[] {
               H000S3_AGRID_nRecordCount
               }
            }
         );
         AV50Pgmname = "WWPBaseObjects.SecFunctionalitySecFunctionalityRoleWC";
         /* GeneXus formulas. */
         AV50Pgmname = "WWPBaseObjects.SecFunctionalitySecFunctionalityRoleWC";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short nRC_GXsfl_29 ;
      private short nGXsfl_29_idx=1 ;
      private short GRID_nEOF ;
      private short AV16OrderedBy ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtSecRoleName_Titleformat ;
      private short edtSecRoleDescription_Titleformat ;
      private short subGrid_Sortable ;
      private short A4SecRoleId ;
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
      private int subGrid_Rows ;
      private int Gridpaginationbar_Rowsperpageselectedvalue ;
      private int Gridpaginationbar_Pagestoshow ;
      private int Ddo_secrolename_Datalistupdateminimumcharacters ;
      private int Ddo_secroledescription_Datalistupdateminimumcharacters ;
      private int edtavSecrolename_Enabled ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavDelete_Visible ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_secrolenametitlecontrolidtoreplace_Visible ;
      private int edtavDdo_secroledescriptiontitlecontrolidtoreplace_Visible ;
      private int edtSecFunctionalityId_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfsecrolename_Visible ;
      private int edtavTfsecrolename_sel_Visible ;
      private int edtavTfsecroledescription_Visible ;
      private int edtavTfsecroledescription_sel_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV39PageToGo ;
      private int AV51GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long AV8SecFunctionalityId ;
      private long wcpOAV8SecFunctionalityId ;
      private long GRID_nFirstRecordOnPage ;
      private long A1SecFunctionalityId ;
      private long AV40GridCurrentPage ;
      private long AV43GridRecordCount ;
      private long AV42GridPageSize ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_secrolename_Activeeventkey ;
      private String Ddo_secrolename_Filteredtext_get ;
      private String Ddo_secrolename_Selectedvalue_get ;
      private String Ddo_secroledescription_Activeeventkey ;
      private String Ddo_secroledescription_Filteredtext_get ;
      private String Ddo_secroledescription_Selectedvalue_get ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sGXsfl_29_idx="0001" ;
      private String AV50Pgmname ;
      private String GXKey ;
      private String forbiddenHiddens ;
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
      private String Ddo_secrolename_Caption ;
      private String Ddo_secrolename_Tooltip ;
      private String Ddo_secrolename_Cls ;
      private String Ddo_secrolename_Filteredtext_set ;
      private String Ddo_secrolename_Selectedvalue_set ;
      private String Ddo_secrolename_Dropdownoptionstype ;
      private String Ddo_secrolename_Titlecontrolidtoreplace ;
      private String Ddo_secrolename_Sortedstatus ;
      private String Ddo_secrolename_Filtertype ;
      private String Ddo_secrolename_Datalisttype ;
      private String Ddo_secrolename_Datalistproc ;
      private String Ddo_secrolename_Sortasc ;
      private String Ddo_secrolename_Sortdsc ;
      private String Ddo_secrolename_Loadingdata ;
      private String Ddo_secrolename_Cleanfilter ;
      private String Ddo_secrolename_Noresultsfound ;
      private String Ddo_secrolename_Searchbuttontext ;
      private String Ddo_secroledescription_Caption ;
      private String Ddo_secroledescription_Tooltip ;
      private String Ddo_secroledescription_Cls ;
      private String Ddo_secroledescription_Filteredtext_set ;
      private String Ddo_secroledescription_Selectedvalue_set ;
      private String Ddo_secroledescription_Dropdownoptionstype ;
      private String Ddo_secroledescription_Titlecontrolidtoreplace ;
      private String Ddo_secroledescription_Sortedstatus ;
      private String Ddo_secroledescription_Filtertype ;
      private String Ddo_secroledescription_Datalisttype ;
      private String Ddo_secroledescription_Datalistproc ;
      private String Ddo_secroledescription_Sortasc ;
      private String Ddo_secroledescription_Sortdsc ;
      private String Ddo_secroledescription_Loadingdata ;
      private String Ddo_secroledescription_Cleanfilter ;
      private String Ddo_secroledescription_Noresultsfound ;
      private String Ddo_secroledescription_Searchbuttontext ;
      private String GX_FocusControl ;
      private String divLayoutmaintable_Internalname ;
      private String divTablegridheader_Internalname ;
      private String divHtml_dvpanel_tableheader_Internalname ;
      private String Dvpanel_tableheader_Internalname ;
      private String divLayout_tableheader_Internalname ;
      private String divTableheader_Internalname ;
      private String divUnnamedtableecrolename_Internalname ;
      private String lblFiltertextsecrolename_Internalname ;
      private String lblFiltertextsecrolename_Jsonclick ;
      private String edtavSecrolename_Internalname ;
      private String TempTags ;
      private String edtavSecrolename_Jsonclick ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtSecRoleName_Title ;
      private String edtSecRoleDescription_Title ;
      private String subGrid_Header ;
      private String edtavDelete_Link ;
      private String edtavDelete_Tooltiptext ;
      private String edtSecRoleName_Link ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_secrolename_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_secrolenametitlecontrolidtoreplace_Internalname ;
      private String Ddo_secroledescription_Internalname ;
      private String edtavDdo_secroledescriptiontitlecontrolidtoreplace_Internalname ;
      private String edtSecFunctionalityId_Internalname ;
      private String edtSecFunctionalityId_Jsonclick ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavTfsecrolename_Internalname ;
      private String edtavTfsecrolename_Jsonclick ;
      private String edtavTfsecrolename_sel_Internalname ;
      private String edtavTfsecrolename_sel_Jsonclick ;
      private String edtavTfsecroledescription_Internalname ;
      private String edtavTfsecroledescription_Jsonclick ;
      private String edtavTfsecroledescription_sel_Internalname ;
      private String edtavTfsecroledescription_sel_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDelete_Internalname ;
      private String edtSecRoleId_Internalname ;
      private String edtSecRoleName_Internalname ;
      private String edtSecRoleDescription_Internalname ;
      private String scmdbuf ;
      private String hsh ;
      private String sCtrlAV8SecFunctionalityId ;
      private String sGXsfl_29_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtSecRoleId_Jsonclick ;
      private String edtSecRoleName_Jsonclick ;
      private String edtSecRoleDescription_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV17OrderedDsc ;
      private bool AV20IsAuthorized_Delete ;
      private bool AV13IsAuthorized_SecRoleName ;
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
      private bool Ddo_secrolename_Includesortasc ;
      private bool Ddo_secrolename_Includesortdsc ;
      private bool Ddo_secrolename_Includefilter ;
      private bool Ddo_secrolename_Filterisrange ;
      private bool Ddo_secrolename_Includedatalist ;
      private bool Ddo_secroledescription_Includesortasc ;
      private bool Ddo_secroledescription_Includesortdsc ;
      private bool Ddo_secroledescription_Includefilter ;
      private bool Ddo_secroledescription_Filterisrange ;
      private bool Ddo_secroledescription_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_29_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool GXt_boolean1 ;
      private bool AV18Delete_IsBlob ;
      private String AV46SecRoleName ;
      private String AV23TFSecRoleName ;
      private String AV24TFSecRoleName_Sel ;
      private String AV27TFSecRoleDescription ;
      private String AV28TFSecRoleDescription_Sel ;
      private String AV25ddo_SecRoleNameTitleControlIdToReplace ;
      private String AV29ddo_SecRoleDescriptionTitleControlIdToReplace ;
      private String A13SecRoleName ;
      private String A12SecRoleDescription ;
      private String AV49Delete_GXI ;
      private String lV46SecRoleName ;
      private String lV23TFSecRoleName ;
      private String lV27TFSecRoleDescription ;
      private String AV18Delete ;
      private IGxSession AV12Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_secrolename ;
      private GXUserControl ucDdo_secroledescription ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] H000S2_A1SecFunctionalityId ;
      private String[] H000S2_A12SecRoleDescription ;
      private String[] H000S2_A13SecRoleName ;
      private short[] H000S2_A4SecRoleId ;
      private long[] H000S3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV9HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV22SecRoleNameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV26SecRoleDescriptionTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV38WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV10TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV11TrnContextAtt ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV14GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV15GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV30DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class secfunctionalitysecfunctionalityrolewc__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H000S2( IGxContext context ,
                                             String AV46SecRoleName ,
                                             String AV24TFSecRoleName_Sel ,
                                             String AV23TFSecRoleName ,
                                             String AV28TFSecRoleDescription_Sel ,
                                             String AV27TFSecRoleDescription ,
                                             String A13SecRoleName ,
                                             String A12SecRoleDescription ,
                                             short AV16OrderedBy ,
                                             bool AV17OrderedDsc ,
                                             long A1SecFunctionalityId ,
                                             long AV8SecFunctionalityId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [9] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " T1.[SecFunctionalityId], T2.[SecRoleDescription], T2.[SecRoleName], T1.[SecRoleId]";
         sFromString = " FROM ([SecFunctionalityRole] T1 WITH (NOLOCK) INNER JOIN [SecRole] T2 WITH (NOLOCK) ON T2.[SecRoleId] = T1.[SecRoleId])";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE (T1.[SecFunctionalityId] = @AV8SecFunctionalityId)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV46SecRoleName)) )
         {
            sWhereString = sWhereString + " and (T2.[SecRoleName] like '%' + @lV46SecRoleName + '%')";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV24TFSecRoleName_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV23TFSecRoleName)) ) )
         {
            sWhereString = sWhereString + " and (T2.[SecRoleName] like @lV23TFSecRoleName)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV24TFSecRoleName_Sel)) )
         {
            sWhereString = sWhereString + " and (T2.[SecRoleName] = @AV24TFSecRoleName_Sel)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV28TFSecRoleDescription_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV27TFSecRoleDescription)) ) )
         {
            sWhereString = sWhereString + " and (T2.[SecRoleDescription] like @lV27TFSecRoleDescription)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV28TFSecRoleDescription_Sel)) )
         {
            sWhereString = sWhereString + " and (T2.[SecRoleDescription] = @AV28TFSecRoleDescription_Sel)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ( AV16OrderedBy == 1 ) && ! AV17OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[SecFunctionalityId], T2.[SecRoleName]";
         }
         else if ( ( AV16OrderedBy == 1 ) && ( AV17OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[SecFunctionalityId] DESC, T2.[SecRoleName] DESC";
         }
         else if ( ( AV16OrderedBy == 2 ) && ! AV17OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[SecFunctionalityId], T2.[SecRoleDescription]";
         }
         else if ( ( AV16OrderedBy == 2 ) && ( AV17OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[SecFunctionalityId] DESC, T2.[SecRoleDescription] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY T1.[SecFunctionalityId], T1.[SecRoleId]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H000S3( IGxContext context ,
                                             String AV46SecRoleName ,
                                             String AV24TFSecRoleName_Sel ,
                                             String AV23TFSecRoleName ,
                                             String AV28TFSecRoleDescription_Sel ,
                                             String AV27TFSecRoleDescription ,
                                             String A13SecRoleName ,
                                             String A12SecRoleDescription ,
                                             short AV16OrderedBy ,
                                             bool AV17OrderedDsc ,
                                             long A1SecFunctionalityId ,
                                             long AV8SecFunctionalityId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [6] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM ([SecFunctionalityRole] T1 WITH (NOLOCK) INNER JOIN [SecRole] T2 WITH (NOLOCK) ON T2.[SecRoleId] = T1.[SecRoleId])";
         scmdbuf = scmdbuf + " WHERE (T1.[SecFunctionalityId] = @AV8SecFunctionalityId)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV46SecRoleName)) )
         {
            sWhereString = sWhereString + " and (T2.[SecRoleName] like '%' + @lV46SecRoleName + '%')";
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV24TFSecRoleName_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV23TFSecRoleName)) ) )
         {
            sWhereString = sWhereString + " and (T2.[SecRoleName] like @lV23TFSecRoleName)";
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV24TFSecRoleName_Sel)) )
         {
            sWhereString = sWhereString + " and (T2.[SecRoleName] = @AV24TFSecRoleName_Sel)";
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV28TFSecRoleDescription_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV27TFSecRoleDescription)) ) )
         {
            sWhereString = sWhereString + " and (T2.[SecRoleDescription] like @lV27TFSecRoleDescription)";
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV28TFSecRoleDescription_Sel)) )
         {
            sWhereString = sWhereString + " and (T2.[SecRoleDescription] = @AV28TFSecRoleDescription_Sel)";
         }
         else
         {
            GXv_int5[5] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         if ( ( AV16OrderedBy == 1 ) && ! AV17OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV16OrderedBy == 1 ) && ( AV17OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV16OrderedBy == 2 ) && ! AV17OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV16OrderedBy == 2 ) && ( AV17OrderedDsc ) )
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
                     return conditional_H000S2(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (short)dynConstraints[7] , (bool)dynConstraints[8] , (long)dynConstraints[9] , (long)dynConstraints[10] );
               case 1 :
                     return conditional_H000S3(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (short)dynConstraints[7] , (bool)dynConstraints[8] , (long)dynConstraints[9] , (long)dynConstraints[10] );
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
          Object[] prmH000S2 ;
          prmH000S2 = new Object[] {
          new Object[] {"@AV8SecFunctionalityId",SqlDbType.Decimal,10,0} ,
          new Object[] {"@lV46SecRoleName",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV23TFSecRoleName",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV24TFSecRoleName_Sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV27TFSecRoleDescription",SqlDbType.NVarChar,120,0} ,
          new Object[] {"@AV28TFSecRoleDescription_Sel",SqlDbType.NVarChar,120,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH000S3 ;
          prmH000S3 = new Object[] {
          new Object[] {"@AV8SecFunctionalityId",SqlDbType.Decimal,10,0} ,
          new Object[] {"@lV46SecRoleName",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV23TFSecRoleName",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV24TFSecRoleName_Sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV27TFSecRoleDescription",SqlDbType.NVarChar,120,0} ,
          new Object[] {"@AV28TFSecRoleDescription_Sel",SqlDbType.NVarChar,120,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000S2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000S2,11,0,true,false )
             ,new CursorDef("H000S3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000S3,1,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
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
                   stmt.SetParameter(sIdx, (long)parms[9]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[15]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[16]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[17]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[6]);
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
