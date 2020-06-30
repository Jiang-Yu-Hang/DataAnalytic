/*
               File: WWPBaseObjects.SecRoleSecFunctionalityRoleWC
        Description: Sec Role Sec Functionality Role WC
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:54:57.33
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
   public class secrolesecfunctionalityrolewc : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public secrolesecfunctionalityrolewc( )
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

      public secrolesecfunctionalityrolewc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_SecRoleId )
      {
         this.AV8SecRoleId = aP0_SecRoleId;
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
         cmbSecFunctionalityType = new GXCombobox();
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
                  AV8SecRoleId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8SecRoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8SecRoleId), 4, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(short)AV8SecRoleId});
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
                  AV12SecFunctionalityKey = GetNextPar( );
                  AV20OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV21OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
                  AV44TFSecFunctionalityKey = GetNextPar( );
                  AV45TFSecFunctionalityKey_Sel = GetNextPar( );
                  AV8SecRoleId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV46ddo_SecFunctionalityKeyTitleControlIdToReplace = GetNextPar( );
                  AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace = GetNextPar( );
                  AV79Pgmname = GetNextPar( );
                  AV16IsAuthorized_SecFunctionalityDescription = StringUtil.StrToBool( GetNextPar( ));
                  sPrefix = GetNextPar( );
                  init_default_properties( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxgrGrid_refresh( subGrid_Rows, AV12SecFunctionalityKey, AV20OrderedBy, AV21OrderedDsc, AV44TFSecFunctionalityKey, AV45TFSecFunctionalityKey_Sel, AV8SecRoleId, AV46ddo_SecFunctionalityKeyTitleControlIdToReplace, AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace, AV79Pgmname, AV16IsAuthorized_SecFunctionalityDescription, sPrefix) ;
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
            PA0W2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV79Pgmname = "WWPBaseObjects.SecRoleSecFunctionalityRoleWC";
               context.Gx_err = 0;
               WS0W2( ) ;
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
            context.SendWebValue( "Sec Role Sec Functionality Role WC") ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022711545756", false);
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("wwpbaseobjects.secrolesecfunctionalityrolewc.aspx") + "?" + UrlEncode("" +AV8SecRoleId)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vSECFUNCTIONALITYKEY", AV12SecFunctionalityKey);
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV20OrderedBy), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vORDEREDDSC", StringUtil.BoolToStr( AV21OrderedDsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vTFSECFUNCTIONALITYKEY", AV44TFSecFunctionalityKey);
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vTFSECFUNCTIONALITYKEY_SEL", AV45TFSecFunctionalityKey_Sel);
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_GXsfl_29", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_29), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV70GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV73GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV72GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vDDO_TITLESETTINGSICONS", AV58DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vDDO_TITLESETTINGSICONS", AV58DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vSECFUNCTIONALITYKEYTITLEFILTERDATA", AV43SecFunctionalityKeyTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vSECFUNCTIONALITYKEYTITLEFILTERDATA", AV43SecFunctionalityKeyTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA", AV50SecFunctionalityDescriptionTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA", AV50SecFunctionalityDescriptionTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV8SecRoleId", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV8SecRoleId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vPGMNAME", StringUtil.RTrim( AV79Pgmname));
         GxWebStd.gx_hidden_field( context, sPrefix+"vSECROLEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8SecRoleId), 4, 0, ".", "")));
         GxWebStd.gx_boolean_hidden_field( context, sPrefix+"vISAUTHORIZED_SECFUNCTIONALITYDESCRIPTION", AV16IsAuthorized_SecFunctionalityDescription);
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_vISAUTHORIZED_SECFUNCTIONALITYDESCRIPTION", GetSecureSignedToken( sPrefix, AV16IsAuthorized_SecFunctionalityDescription, context));
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
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYKEY_Caption", StringUtil.RTrim( Ddo_secfunctionalitykey_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYKEY_Tooltip", StringUtil.RTrim( Ddo_secfunctionalitykey_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYKEY_Cls", StringUtil.RTrim( Ddo_secfunctionalitykey_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYKEY_Filteredtext_set", StringUtil.RTrim( Ddo_secfunctionalitykey_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYKEY_Selectedvalue_set", StringUtil.RTrim( Ddo_secfunctionalitykey_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYKEY_Dropdownoptionstype", StringUtil.RTrim( Ddo_secfunctionalitykey_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYKEY_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_secfunctionalitykey_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYKEY_Includesortasc", StringUtil.BoolToStr( Ddo_secfunctionalitykey_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYKEY_Includesortdsc", StringUtil.BoolToStr( Ddo_secfunctionalitykey_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYKEY_Sortedstatus", StringUtil.RTrim( Ddo_secfunctionalitykey_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYKEY_Includefilter", StringUtil.BoolToStr( Ddo_secfunctionalitykey_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYKEY_Filtertype", StringUtil.RTrim( Ddo_secfunctionalitykey_Filtertype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYKEY_Filterisrange", StringUtil.BoolToStr( Ddo_secfunctionalitykey_Filterisrange));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYKEY_Includedatalist", StringUtil.BoolToStr( Ddo_secfunctionalitykey_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYKEY_Datalisttype", StringUtil.RTrim( Ddo_secfunctionalitykey_Datalisttype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYKEY_Datalistproc", StringUtil.RTrim( Ddo_secfunctionalitykey_Datalistproc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYKEY_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_secfunctionalitykey_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYKEY_Sortasc", StringUtil.RTrim( Ddo_secfunctionalitykey_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYKEY_Sortdsc", StringUtil.RTrim( Ddo_secfunctionalitykey_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYKEY_Loadingdata", StringUtil.RTrim( Ddo_secfunctionalitykey_Loadingdata));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYKEY_Cleanfilter", StringUtil.RTrim( Ddo_secfunctionalitykey_Cleanfilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYKEY_Noresultsfound", StringUtil.RTrim( Ddo_secfunctionalitykey_Noresultsfound));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYKEY_Searchbuttontext", StringUtil.RTrim( Ddo_secfunctionalitykey_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTION_Caption", StringUtil.RTrim( Ddo_secfunctionalitydescription_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTION_Tooltip", StringUtil.RTrim( Ddo_secfunctionalitydescription_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTION_Cls", StringUtil.RTrim( Ddo_secfunctionalitydescription_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTION_Dropdownoptionstype", StringUtil.RTrim( Ddo_secfunctionalitydescription_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTION_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_secfunctionalitydescription_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTION_Includesortasc", StringUtil.BoolToStr( Ddo_secfunctionalitydescription_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTION_Includesortdsc", StringUtil.BoolToStr( Ddo_secfunctionalitydescription_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTION_Sortedstatus", StringUtil.RTrim( Ddo_secfunctionalitydescription_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTION_Includefilter", StringUtil.BoolToStr( Ddo_secfunctionalitydescription_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTION_Includedatalist", StringUtil.BoolToStr( Ddo_secfunctionalitydescription_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTION_Sortasc", StringUtil.RTrim( Ddo_secfunctionalitydescription_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTION_Sortdsc", StringUtil.RTrim( Ddo_secfunctionalitydescription_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTION_Searchbuttontext", StringUtil.RTrim( Ddo_secfunctionalitydescription_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYKEY_Activeeventkey", StringUtil.RTrim( Ddo_secfunctionalitykey_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYKEY_Filteredtext_get", StringUtil.RTrim( Ddo_secfunctionalitykey_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYKEY_Selectedvalue_get", StringUtil.RTrim( Ddo_secfunctionalitykey_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTION_Activeeventkey", StringUtil.RTrim( Ddo_secfunctionalitydescription_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYKEY_Activeeventkey", StringUtil.RTrim( Ddo_secfunctionalitykey_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYKEY_Filteredtext_get", StringUtil.RTrim( Ddo_secfunctionalitykey_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYKEY_Selectedvalue_get", StringUtil.RTrim( Ddo_secfunctionalitykey_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTION_Activeeventkey", StringUtil.RTrim( Ddo_secfunctionalitydescription_Activeeventkey));
      }

      protected void RenderHtmlCloseForm0W2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("wwpbaseobjects/secrolesecfunctionalityrolewc.js", "?202022711545969", false);
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
         return "WWPBaseObjects.SecRoleSecFunctionalityRoleWC" ;
      }

      public override String GetPgmdesc( )
      {
         return "Sec Role Sec Functionality Role WC" ;
      }

      protected void WB0W0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "wwpbaseobjects.secrolesecfunctionalityrolewc.aspx");
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
            GxWebStd.gx_div_start( context, divUnnamedtableecfunctionalitykey_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell CellWidth_12_5", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblFiltertextsecfunctionalitykey_Internalname, "权限名称", "", "", lblFiltertextsecfunctionalitykey_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_WWPBaseObjects\\SecRoleSecFunctionalityRoleWC.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 CellWidth_87_5", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSecfunctionalitykey_Internalname, "Sec Functionality Key", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'" + sPrefix + "',false,'" + sGXsfl_29_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSecfunctionalitykey_Internalname, AV12SecFunctionalityKey, StringUtil.RTrim( context.localUtil.Format( AV12SecFunctionalityKey, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,23);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSecfunctionalitykey_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavSecfunctionalitykey_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecRoleSecFunctionalityRoleWC.htm");
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "功能编号") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtSecFunctionalityKey_Titleformat == 0 )
               {
                  context.SendWebValue( edtSecFunctionalityKey_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtSecFunctionalityKey_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Functionality Type") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtSecFunctionalityDescription_Titleformat == 0 )
               {
                  context.SendWebValue( edtSecFunctionalityDescription_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtSecFunctionalityDescription_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Parent Functionality") ;
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
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SecFunctionalityId), 10, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A3SecFunctionalityKey);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtSecFunctionalityKey_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSecFunctionalityKey_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A9SecFunctionalityType), 2, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A8SecFunctionalityDescription);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtSecFunctionalityDescription_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSecFunctionalityDescription_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtSecFunctionalityDescription_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A11SecParentFunctionalityDescription);
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV70GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV73GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV72GridPageSize);
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
            ucDdo_secfunctionalitykey.SetProperty("Caption", Ddo_secfunctionalitykey_Caption);
            ucDdo_secfunctionalitykey.SetProperty("Tooltip", Ddo_secfunctionalitykey_Tooltip);
            ucDdo_secfunctionalitykey.SetProperty("Cls", Ddo_secfunctionalitykey_Cls);
            ucDdo_secfunctionalitykey.SetProperty("DropDownOptionsType", Ddo_secfunctionalitykey_Dropdownoptionstype);
            ucDdo_secfunctionalitykey.SetProperty("IncludeSortASC", Ddo_secfunctionalitykey_Includesortasc);
            ucDdo_secfunctionalitykey.SetProperty("IncludeSortDSC", Ddo_secfunctionalitykey_Includesortdsc);
            ucDdo_secfunctionalitykey.SetProperty("IncludeFilter", Ddo_secfunctionalitykey_Includefilter);
            ucDdo_secfunctionalitykey.SetProperty("FilterType", Ddo_secfunctionalitykey_Filtertype);
            ucDdo_secfunctionalitykey.SetProperty("FilterIsRange", Ddo_secfunctionalitykey_Filterisrange);
            ucDdo_secfunctionalitykey.SetProperty("IncludeDataList", Ddo_secfunctionalitykey_Includedatalist);
            ucDdo_secfunctionalitykey.SetProperty("DataListType", Ddo_secfunctionalitykey_Datalisttype);
            ucDdo_secfunctionalitykey.SetProperty("DataListProc", Ddo_secfunctionalitykey_Datalistproc);
            ucDdo_secfunctionalitykey.SetProperty("DataListUpdateMinimumCharacters", Ddo_secfunctionalitykey_Datalistupdateminimumcharacters);
            ucDdo_secfunctionalitykey.SetProperty("SortASC", Ddo_secfunctionalitykey_Sortasc);
            ucDdo_secfunctionalitykey.SetProperty("SortDSC", Ddo_secfunctionalitykey_Sortdsc);
            ucDdo_secfunctionalitykey.SetProperty("LoadingData", Ddo_secfunctionalitykey_Loadingdata);
            ucDdo_secfunctionalitykey.SetProperty("CleanFilter", Ddo_secfunctionalitykey_Cleanfilter);
            ucDdo_secfunctionalitykey.SetProperty("NoResultsFound", Ddo_secfunctionalitykey_Noresultsfound);
            ucDdo_secfunctionalitykey.SetProperty("SearchButtonText", Ddo_secfunctionalitykey_Searchbuttontext);
            ucDdo_secfunctionalitykey.SetProperty("DropDownOptionsTitleSettingsIcons", AV58DDO_TitleSettingsIcons);
            ucDdo_secfunctionalitykey.SetProperty("DropDownOptionsData", AV43SecFunctionalityKeyTitleFilterData);
            ucDdo_secfunctionalitykey.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_secfunctionalitykey_Internalname, sPrefix+"DDO_SECFUNCTIONALITYKEYContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'" + sPrefix + "',false,'" + sGXsfl_29_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_secfunctionalitykeytitlecontrolidtoreplace_Internalname, AV46ddo_SecFunctionalityKeyTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", 0, edtavDdo_secfunctionalitykeytitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_WWPBaseObjects\\SecRoleSecFunctionalityRoleWC.htm");
            /* User Defined Control */
            ucDdo_secfunctionalitydescription.SetProperty("Caption", Ddo_secfunctionalitydescription_Caption);
            ucDdo_secfunctionalitydescription.SetProperty("Tooltip", Ddo_secfunctionalitydescription_Tooltip);
            ucDdo_secfunctionalitydescription.SetProperty("Cls", Ddo_secfunctionalitydescription_Cls);
            ucDdo_secfunctionalitydescription.SetProperty("DropDownOptionsType", Ddo_secfunctionalitydescription_Dropdownoptionstype);
            ucDdo_secfunctionalitydescription.SetProperty("IncludeSortASC", Ddo_secfunctionalitydescription_Includesortasc);
            ucDdo_secfunctionalitydescription.SetProperty("IncludeSortDSC", Ddo_secfunctionalitydescription_Includesortdsc);
            ucDdo_secfunctionalitydescription.SetProperty("IncludeFilter", Ddo_secfunctionalitydescription_Includefilter);
            ucDdo_secfunctionalitydescription.SetProperty("IncludeDataList", Ddo_secfunctionalitydescription_Includedatalist);
            ucDdo_secfunctionalitydescription.SetProperty("SortASC", Ddo_secfunctionalitydescription_Sortasc);
            ucDdo_secfunctionalitydescription.SetProperty("SortDSC", Ddo_secfunctionalitydescription_Sortdsc);
            ucDdo_secfunctionalitydescription.SetProperty("SearchButtonText", Ddo_secfunctionalitydescription_Searchbuttontext);
            ucDdo_secfunctionalitydescription.SetProperty("DropDownOptionsTitleSettingsIcons", AV58DDO_TitleSettingsIcons);
            ucDdo_secfunctionalitydescription.SetProperty("DropDownOptionsData", AV50SecFunctionalityDescriptionTitleFilterData);
            ucDdo_secfunctionalitydescription.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_secfunctionalitydescription_Internalname, sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTIONContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'" + sPrefix + "',false,'" + sGXsfl_29_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_secfunctionalitydescriptiontitlecontrolidtoreplace_Internalname, AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"", 0, edtavDdo_secfunctionalitydescriptiontitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_WWPBaseObjects\\SecRoleSecFunctionalityRoleWC.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtSecRoleId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A4SecRoleId), 4, 0, ".", "")), context.localUtil.Format( (decimal)(A4SecRoleId), "ZZZ9"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSecRoleId_Jsonclick, 0, "Attribute", "", "", "", "", edtSecRoleId_Visible, 0, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WWPBaseObjects\\SecRoleSecFunctionalityRoleWC.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, sPrefix+"WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'" + sPrefix + "',false,'" + sGXsfl_29_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV20OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV20OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WWPBaseObjects\\SecRoleSecFunctionalityRoleWC.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'" + sPrefix + "',false,'" + sGXsfl_29_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV21OrderedDsc), StringUtil.BoolToStr( AV21OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_WWPBaseObjects\\SecRoleSecFunctionalityRoleWC.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'" + sPrefix + "',false,'" + sGXsfl_29_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfsecfunctionalitykey_Internalname, AV44TFSecFunctionalityKey, StringUtil.RTrim( context.localUtil.Format( AV44TFSecFunctionalityKey, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfsecfunctionalitykey_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfsecfunctionalitykey_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecRoleSecFunctionalityRoleWC.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'" + sPrefix + "',false,'" + sGXsfl_29_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfsecfunctionalitykey_sel_Internalname, AV45TFSecFunctionalityKey_Sel, StringUtil.RTrim( context.localUtil.Format( AV45TFSecFunctionalityKey_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfsecfunctionalitykey_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfsecfunctionalitykey_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecRoleSecFunctionalityRoleWC.htm");
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

      protected void START0W2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
               Form.Meta.addItem("description", "Sec Role Sec Functionality Role WC", 0) ;
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
               STRUP0W0( ) ;
            }
         }
      }

      protected void WS0W2( )
      {
         START0W2( ) ;
         EVT0W2( ) ;
      }

      protected void EVT0W2( )
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
                                 STRUP0W0( ) ;
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
                                 STRUP0W0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E110W2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0W0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E120W2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_SECFUNCTIONALITYKEY.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0W0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E130W2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_SECFUNCTIONALITYDESCRIPTION.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0W0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E140W2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0W0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = edtavSecfunctionalitykey_Internalname;
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
                                 STRUP0W0( ) ;
                              }
                              nGXsfl_29_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_29_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_29_idx), 4, 0)), 4, "0");
                              SubsflControlProps_292( ) ;
                              A1SecFunctionalityId = (long)(context.localUtil.CToN( cgiGet( edtSecFunctionalityId_Internalname), ".", ","));
                              A3SecFunctionalityKey = cgiGet( edtSecFunctionalityKey_Internalname);
                              cmbSecFunctionalityType.Name = cmbSecFunctionalityType_Internalname;
                              cmbSecFunctionalityType.CurrentValue = cgiGet( cmbSecFunctionalityType_Internalname);
                              A9SecFunctionalityType = (short)(NumberUtil.Val( cgiGet( cmbSecFunctionalityType_Internalname), "."));
                              A8SecFunctionalityDescription = cgiGet( edtSecFunctionalityDescription_Internalname);
                              A11SecParentFunctionalityDescription = cgiGet( edtSecParentFunctionalityDescription_Internalname);
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
                                          GX_FocusControl = edtavSecfunctionalitykey_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: Start */
                                          E150W2 ();
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
                                          GX_FocusControl = edtavSecfunctionalitykey_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: Refresh */
                                          E160W2 ();
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
                                          GX_FocusControl = edtavSecfunctionalitykey_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          E170W2 ();
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
                                             /* Set Refresh If Secfunctionalitykey Changed */
                                             if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vSECFUNCTIONALITYKEY"), AV12SecFunctionalityKey) != 0 )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Orderedby Changed */
                                             if ( ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV20OrderedBy )) )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Ordereddsc Changed */
                                             if ( StringUtil.StrToBool( cgiGet( sPrefix+"GXH_vORDEREDDSC")) != AV21OrderedDsc )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Tfsecfunctionalitykey Changed */
                                             if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFSECFUNCTIONALITYKEY"), AV44TFSecFunctionalityKey) != 0 )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Tfsecfunctionalitykey_sel Changed */
                                             if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFSECFUNCTIONALITYKEY_SEL"), AV45TFSecFunctionalityKey_Sel) != 0 )
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
                                       STRUP0W0( ) ;
                                    }
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavSecfunctionalitykey_Internalname;
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

      protected void WE0W2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm0W2( ) ;
            }
         }
      }

      protected void PA0W2( )
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
               GX_FocusControl = edtavSecfunctionalitykey_Internalname;
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
                                       String AV12SecFunctionalityKey ,
                                       short AV20OrderedBy ,
                                       bool AV21OrderedDsc ,
                                       String AV44TFSecFunctionalityKey ,
                                       String AV45TFSecFunctionalityKey_Sel ,
                                       short AV8SecRoleId ,
                                       String AV46ddo_SecFunctionalityKeyTitleControlIdToReplace ,
                                       String AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace ,
                                       String AV79Pgmname ,
                                       bool AV16IsAuthorized_SecFunctionalityDescription ,
                                       String sPrefix )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF0W2( ) ;
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
         RF0W2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV79Pgmname = "WWPBaseObjects.SecRoleSecFunctionalityRoleWC";
         context.Gx_err = 0;
      }

      protected void RF0W2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 29;
         /* Execute user event: Refresh */
         E160W2 ();
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
                                                 AV12SecFunctionalityKey ,
                                                 AV45TFSecFunctionalityKey_Sel ,
                                                 AV44TFSecFunctionalityKey ,
                                                 A3SecFunctionalityKey ,
                                                 AV20OrderedBy ,
                                                 AV21OrderedDsc ,
                                                 A4SecRoleId ,
                                                 AV8SecRoleId } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.SHORT
                                                 }
            } ) ;
            lV12SecFunctionalityKey = StringUtil.Concat( StringUtil.RTrim( AV12SecFunctionalityKey), "%", "");
            lV44TFSecFunctionalityKey = StringUtil.Concat( StringUtil.RTrim( AV44TFSecFunctionalityKey), "%", "");
            /* Using cursor H000W2 */
            pr_default.execute(0, new Object[] {AV8SecRoleId, lV12SecFunctionalityKey, lV44TFSecFunctionalityKey, AV45TFSecFunctionalityKey_Sel, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_29_idx = 1;
            sGXsfl_29_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_29_idx), 4, 0)), 4, "0");
            SubsflControlProps_292( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A2SecParentFunctionalityId = H000W2_A2SecParentFunctionalityId[0];
               n2SecParentFunctionalityId = H000W2_n2SecParentFunctionalityId[0];
               A4SecRoleId = H000W2_A4SecRoleId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A4SecRoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4SecRoleId), 4, 0)));
               A11SecParentFunctionalityDescription = H000W2_A11SecParentFunctionalityDescription[0];
               A8SecFunctionalityDescription = H000W2_A8SecFunctionalityDescription[0];
               A9SecFunctionalityType = H000W2_A9SecFunctionalityType[0];
               A3SecFunctionalityKey = H000W2_A3SecFunctionalityKey[0];
               A1SecFunctionalityId = H000W2_A1SecFunctionalityId[0];
               A2SecParentFunctionalityId = H000W2_A2SecParentFunctionalityId[0];
               n2SecParentFunctionalityId = H000W2_n2SecParentFunctionalityId[0];
               A8SecFunctionalityDescription = H000W2_A8SecFunctionalityDescription[0];
               A9SecFunctionalityType = H000W2_A9SecFunctionalityType[0];
               A3SecFunctionalityKey = H000W2_A3SecFunctionalityKey[0];
               A11SecParentFunctionalityDescription = H000W2_A11SecParentFunctionalityDescription[0];
               E170W2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 29;
            WB0W0( ) ;
         }
         bGXsfl_29_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes0W2( )
      {
         GxWebStd.gx_boolean_hidden_field( context, sPrefix+"vISAUTHORIZED_SECFUNCTIONALITYDESCRIPTION", AV16IsAuthorized_SecFunctionalityDescription);
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_vISAUTHORIZED_SECFUNCTIONALITYDESCRIPTION", GetSecureSignedToken( sPrefix, AV16IsAuthorized_SecFunctionalityDescription, context));
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
                                              AV12SecFunctionalityKey ,
                                              AV45TFSecFunctionalityKey_Sel ,
                                              AV44TFSecFunctionalityKey ,
                                              A3SecFunctionalityKey ,
                                              AV20OrderedBy ,
                                              AV21OrderedDsc ,
                                              A4SecRoleId ,
                                              AV8SecRoleId } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.SHORT
                                              }
         } ) ;
         lV12SecFunctionalityKey = StringUtil.Concat( StringUtil.RTrim( AV12SecFunctionalityKey), "%", "");
         lV44TFSecFunctionalityKey = StringUtil.Concat( StringUtil.RTrim( AV44TFSecFunctionalityKey), "%", "");
         /* Using cursor H000W3 */
         pr_default.execute(1, new Object[] {AV8SecRoleId, lV12SecFunctionalityKey, lV44TFSecFunctionalityKey, AV45TFSecFunctionalityKey_Sel});
         GRID_nRecordCount = H000W3_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV12SecFunctionalityKey, AV20OrderedBy, AV21OrderedDsc, AV44TFSecFunctionalityKey, AV45TFSecFunctionalityKey_Sel, AV8SecRoleId, AV46ddo_SecFunctionalityKeyTitleControlIdToReplace, AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace, AV79Pgmname, AV16IsAuthorized_SecFunctionalityDescription, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV12SecFunctionalityKey, AV20OrderedBy, AV21OrderedDsc, AV44TFSecFunctionalityKey, AV45TFSecFunctionalityKey_Sel, AV8SecRoleId, AV46ddo_SecFunctionalityKeyTitleControlIdToReplace, AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace, AV79Pgmname, AV16IsAuthorized_SecFunctionalityDescription, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV12SecFunctionalityKey, AV20OrderedBy, AV21OrderedDsc, AV44TFSecFunctionalityKey, AV45TFSecFunctionalityKey_Sel, AV8SecRoleId, AV46ddo_SecFunctionalityKeyTitleControlIdToReplace, AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace, AV79Pgmname, AV16IsAuthorized_SecFunctionalityDescription, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV12SecFunctionalityKey, AV20OrderedBy, AV21OrderedDsc, AV44TFSecFunctionalityKey, AV45TFSecFunctionalityKey_Sel, AV8SecRoleId, AV46ddo_SecFunctionalityKeyTitleControlIdToReplace, AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace, AV79Pgmname, AV16IsAuthorized_SecFunctionalityDescription, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV12SecFunctionalityKey, AV20OrderedBy, AV21OrderedDsc, AV44TFSecFunctionalityKey, AV45TFSecFunctionalityKey_Sel, AV8SecRoleId, AV46ddo_SecFunctionalityKeyTitleControlIdToReplace, AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace, AV79Pgmname, AV16IsAuthorized_SecFunctionalityDescription, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP0W0( )
      {
         /* Before Start, stand alone formulas. */
         AV79Pgmname = "WWPBaseObjects.SecRoleSecFunctionalityRoleWC";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E150W2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vDDO_TITLESETTINGSICONS"), AV58DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vSECFUNCTIONALITYKEYTITLEFILTERDATA"), AV43SecFunctionalityKeyTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA"), AV50SecFunctionalityDescriptionTitleFilterData);
            /* Read variables values. */
            AV12SecFunctionalityKey = cgiGet( edtavSecfunctionalitykey_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV12SecFunctionalityKey", AV12SecFunctionalityKey);
            AV46ddo_SecFunctionalityKeyTitleControlIdToReplace = cgiGet( edtavDdo_secfunctionalitykeytitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV46ddo_SecFunctionalityKeyTitleControlIdToReplace", AV46ddo_SecFunctionalityKeyTitleControlIdToReplace);
            AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace = cgiGet( edtavDdo_secfunctionalitydescriptiontitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace", AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace);
            A4SecRoleId = (short)(context.localUtil.CToN( cgiGet( edtSecRoleId_Internalname), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A4SecRoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4SecRoleId), 4, 0)));
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDEREDBY");
               GX_FocusControl = edtavOrderedby_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV20OrderedBy = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20OrderedBy), 4, 0)));
            }
            else
            {
               AV20OrderedBy = (short)(context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20OrderedBy), 4, 0)));
            }
            AV21OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV21OrderedDsc", AV21OrderedDsc);
            AV44TFSecFunctionalityKey = cgiGet( edtavTfsecfunctionalitykey_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV44TFSecFunctionalityKey", AV44TFSecFunctionalityKey);
            AV45TFSecFunctionalityKey_Sel = cgiGet( edtavTfsecfunctionalitykey_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV45TFSecFunctionalityKey_Sel", AV45TFSecFunctionalityKey_Sel);
            /* Read saved values. */
            nRC_GXsfl_29 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_GXsfl_29"), ".", ","));
            AV70GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDCURRENTPAGE"), ".", ","));
            AV73GridRecordCount = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDRECORDCOUNT"), ".", ","));
            AV72GridPageSize = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDPAGESIZE"), ".", ","));
            wcpOAV8SecRoleId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV8SecRoleId"), ".", ","));
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
            Ddo_secfunctionalitykey_Caption = cgiGet( sPrefix+"DDO_SECFUNCTIONALITYKEY_Caption");
            Ddo_secfunctionalitykey_Tooltip = cgiGet( sPrefix+"DDO_SECFUNCTIONALITYKEY_Tooltip");
            Ddo_secfunctionalitykey_Cls = cgiGet( sPrefix+"DDO_SECFUNCTIONALITYKEY_Cls");
            Ddo_secfunctionalitykey_Filteredtext_set = cgiGet( sPrefix+"DDO_SECFUNCTIONALITYKEY_Filteredtext_set");
            Ddo_secfunctionalitykey_Selectedvalue_set = cgiGet( sPrefix+"DDO_SECFUNCTIONALITYKEY_Selectedvalue_set");
            Ddo_secfunctionalitykey_Dropdownoptionstype = cgiGet( sPrefix+"DDO_SECFUNCTIONALITYKEY_Dropdownoptionstype");
            Ddo_secfunctionalitykey_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_SECFUNCTIONALITYKEY_Titlecontrolidtoreplace");
            Ddo_secfunctionalitykey_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_SECFUNCTIONALITYKEY_Includesortasc"));
            Ddo_secfunctionalitykey_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_SECFUNCTIONALITYKEY_Includesortdsc"));
            Ddo_secfunctionalitykey_Sortedstatus = cgiGet( sPrefix+"DDO_SECFUNCTIONALITYKEY_Sortedstatus");
            Ddo_secfunctionalitykey_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_SECFUNCTIONALITYKEY_Includefilter"));
            Ddo_secfunctionalitykey_Filtertype = cgiGet( sPrefix+"DDO_SECFUNCTIONALITYKEY_Filtertype");
            Ddo_secfunctionalitykey_Filterisrange = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_SECFUNCTIONALITYKEY_Filterisrange"));
            Ddo_secfunctionalitykey_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_SECFUNCTIONALITYKEY_Includedatalist"));
            Ddo_secfunctionalitykey_Datalisttype = cgiGet( sPrefix+"DDO_SECFUNCTIONALITYKEY_Datalisttype");
            Ddo_secfunctionalitykey_Datalistproc = cgiGet( sPrefix+"DDO_SECFUNCTIONALITYKEY_Datalistproc");
            Ddo_secfunctionalitykey_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( sPrefix+"DDO_SECFUNCTIONALITYKEY_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_secfunctionalitykey_Sortasc = cgiGet( sPrefix+"DDO_SECFUNCTIONALITYKEY_Sortasc");
            Ddo_secfunctionalitykey_Sortdsc = cgiGet( sPrefix+"DDO_SECFUNCTIONALITYKEY_Sortdsc");
            Ddo_secfunctionalitykey_Loadingdata = cgiGet( sPrefix+"DDO_SECFUNCTIONALITYKEY_Loadingdata");
            Ddo_secfunctionalitykey_Cleanfilter = cgiGet( sPrefix+"DDO_SECFUNCTIONALITYKEY_Cleanfilter");
            Ddo_secfunctionalitykey_Noresultsfound = cgiGet( sPrefix+"DDO_SECFUNCTIONALITYKEY_Noresultsfound");
            Ddo_secfunctionalitykey_Searchbuttontext = cgiGet( sPrefix+"DDO_SECFUNCTIONALITYKEY_Searchbuttontext");
            Ddo_secfunctionalitydescription_Caption = cgiGet( sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTION_Caption");
            Ddo_secfunctionalitydescription_Tooltip = cgiGet( sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTION_Tooltip");
            Ddo_secfunctionalitydescription_Cls = cgiGet( sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTION_Cls");
            Ddo_secfunctionalitydescription_Dropdownoptionstype = cgiGet( sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTION_Dropdownoptionstype");
            Ddo_secfunctionalitydescription_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTION_Titlecontrolidtoreplace");
            Ddo_secfunctionalitydescription_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTION_Includesortasc"));
            Ddo_secfunctionalitydescription_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTION_Includesortdsc"));
            Ddo_secfunctionalitydescription_Sortedstatus = cgiGet( sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTION_Sortedstatus");
            Ddo_secfunctionalitydescription_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTION_Includefilter"));
            Ddo_secfunctionalitydescription_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTION_Includedatalist"));
            Ddo_secfunctionalitydescription_Sortasc = cgiGet( sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTION_Sortasc");
            Ddo_secfunctionalitydescription_Sortdsc = cgiGet( sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTION_Sortdsc");
            Ddo_secfunctionalitydescription_Searchbuttontext = cgiGet( sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTION_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_secfunctionalitykey_Activeeventkey = cgiGet( sPrefix+"DDO_SECFUNCTIONALITYKEY_Activeeventkey");
            Ddo_secfunctionalitykey_Filteredtext_get = cgiGet( sPrefix+"DDO_SECFUNCTIONALITYKEY_Filteredtext_get");
            Ddo_secfunctionalitykey_Selectedvalue_get = cgiGet( sPrefix+"DDO_SECFUNCTIONALITYKEY_Selectedvalue_get");
            Ddo_secfunctionalitydescription_Activeeventkey = cgiGet( sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTION_Activeeventkey");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vSECFUNCTIONALITYKEY"), AV12SecFunctionalityKey) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV20OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( sPrefix+"GXH_vORDEREDDSC")) != AV21OrderedDsc )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFSECFUNCTIONALITYKEY"), AV44TFSecFunctionalityKey) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( sPrefix+"GXH_vTFSECFUNCTIONALITYKEY_SEL"), AV45TFSecFunctionalityKey_Sel) != 0 )
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
         E150W2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E150W2( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GXt_boolean1 = AV16IsAuthorized_SecFunctionalityDescription;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWSecFunctionality", out  GXt_boolean1) ;
         AV16IsAuthorized_SecFunctionalityDescription = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV16IsAuthorized_SecFunctionalityDescription", AV16IsAuthorized_SecFunctionalityDescription);
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, sPrefix+"gxhash_vISAUTHORIZED_SECFUNCTIONALITYDESCRIPTION", GetSecureSignedToken( sPrefix, AV16IsAuthorized_SecFunctionalityDescription, context));
         edtavTfsecfunctionalitykey_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTfsecfunctionalitykey_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfsecfunctionalitykey_Visible), 5, 0)), true);
         edtavTfsecfunctionalitykey_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTfsecfunctionalitykey_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfsecfunctionalitykey_sel_Visible), 5, 0)), true);
         Ddo_secfunctionalitykey_Titlecontrolidtoreplace = subGrid_Internalname+"_SecFunctionalityKey";
         ucDdo_secfunctionalitykey.SendProperty(context, sPrefix, false, Ddo_secfunctionalitykey_Internalname, "TitleControlIdToReplace", Ddo_secfunctionalitykey_Titlecontrolidtoreplace);
         AV46ddo_SecFunctionalityKeyTitleControlIdToReplace = Ddo_secfunctionalitykey_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV46ddo_SecFunctionalityKeyTitleControlIdToReplace", AV46ddo_SecFunctionalityKeyTitleControlIdToReplace);
         edtavDdo_secfunctionalitykeytitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_secfunctionalitykeytitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_secfunctionalitykeytitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_secfunctionalitydescription_Titlecontrolidtoreplace = subGrid_Internalname+"_SecFunctionalityDescription";
         ucDdo_secfunctionalitydescription.SendProperty(context, sPrefix, false, Ddo_secfunctionalitydescription_Internalname, "TitleControlIdToReplace", Ddo_secfunctionalitydescription_Titlecontrolidtoreplace);
         AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace = Ddo_secfunctionalitydescription_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace", AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace);
         edtavDdo_secfunctionalitydescriptiontitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_secfunctionalitydescriptiontitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_secfunctionalitydescriptiontitlecontrolidtoreplace_Visible), 5, 0)), true);
         edtSecRoleId_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtSecRoleId_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecRoleId_Visible), 5, 0)), true);
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
         if ( AV20OrderedBy < 1 )
         {
            AV20OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20OrderedBy), 4, 0)));
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV58DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV58DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, sPrefix, false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E160W2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV43SecFunctionalityKeyTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV50SecFunctionalityDescriptionTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV66WWPContext) ;
         /* Execute user subroutine: 'SAVEGRIDSTATE' */
         S142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         edtSecFunctionalityKey_Titleformat = 2;
         edtSecFunctionalityKey_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "权限名称", AV46ddo_SecFunctionalityKeyTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtSecFunctionalityKey_Internalname, "Title", edtSecFunctionalityKey_Title, !bGXsfl_29_Refreshing);
         edtSecFunctionalityDescription_Titleformat = 2;
         edtSecFunctionalityDescription_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "权限描述", AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtSecFunctionalityDescription_Internalname, "Title", edtSecFunctionalityDescription_Title, !bGXsfl_29_Refreshing);
         AV70GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV70GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV70GridCurrentPage), 10, 0)));
         AV72GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV72GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV72GridPageSize), 10, 0)));
         AV73GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV73GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV73GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV43SecFunctionalityKeyTitleFilterData", AV43SecFunctionalityKeyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV50SecFunctionalityDescriptionTitleFilterData", AV50SecFunctionalityDescriptionTitleFilterData);
      }

      protected void E110W2( )
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
            AV69PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV69PageToGo) ;
         }
      }

      protected void E120W2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E130W2( )
      {
         /* Ddo_secfunctionalitykey_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_secfunctionalitykey_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV20OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20OrderedBy), 4, 0)));
            AV21OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV21OrderedDsc", AV21OrderedDsc);
            Ddo_secfunctionalitykey_Sortedstatus = "ASC";
            ucDdo_secfunctionalitykey.SendProperty(context, sPrefix, false, Ddo_secfunctionalitykey_Internalname, "SortedStatus", Ddo_secfunctionalitykey_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_secfunctionalitykey_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV20OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20OrderedBy), 4, 0)));
            AV21OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV21OrderedDsc", AV21OrderedDsc);
            Ddo_secfunctionalitykey_Sortedstatus = "DSC";
            ucDdo_secfunctionalitykey.SendProperty(context, sPrefix, false, Ddo_secfunctionalitykey_Internalname, "SortedStatus", Ddo_secfunctionalitykey_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_secfunctionalitykey_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV44TFSecFunctionalityKey = Ddo_secfunctionalitykey_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV44TFSecFunctionalityKey", AV44TFSecFunctionalityKey);
            AV45TFSecFunctionalityKey_Sel = Ddo_secfunctionalitykey_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV45TFSecFunctionalityKey_Sel", AV45TFSecFunctionalityKey_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV43SecFunctionalityKeyTitleFilterData", AV43SecFunctionalityKeyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV50SecFunctionalityDescriptionTitleFilterData", AV50SecFunctionalityDescriptionTitleFilterData);
      }

      protected void E140W2( )
      {
         /* Ddo_secfunctionalitydescription_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_secfunctionalitydescription_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV20OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20OrderedBy), 4, 0)));
            AV21OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV21OrderedDsc", AV21OrderedDsc);
            Ddo_secfunctionalitydescription_Sortedstatus = "ASC";
            ucDdo_secfunctionalitydescription.SendProperty(context, sPrefix, false, Ddo_secfunctionalitydescription_Internalname, "SortedStatus", Ddo_secfunctionalitydescription_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_secfunctionalitydescription_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV20OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20OrderedBy), 4, 0)));
            AV21OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV21OrderedDsc", AV21OrderedDsc);
            Ddo_secfunctionalitydescription_Sortedstatus = "DSC";
            ucDdo_secfunctionalitydescription.SendProperty(context, sPrefix, false, Ddo_secfunctionalitydescription_Internalname, "SortedStatus", Ddo_secfunctionalitydescription_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV43SecFunctionalityKeyTitleFilterData", AV43SecFunctionalityKeyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV50SecFunctionalityDescriptionTitleFilterData", AV50SecFunctionalityDescriptionTitleFilterData);
      }

      private void E170W2( )
      {
         /* Grid_Load Routine */
         if ( AV16IsAuthorized_SecFunctionalityDescription )
         {
            edtSecFunctionalityDescription_Link = formatLink("wwpbaseobjects.secfunctionalityview.aspx") + "?" + UrlEncode("" +A1SecFunctionalityId) + "," + UrlEncode(StringUtil.RTrim(""));
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

      protected void S152( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_secfunctionalitykey_Sortedstatus = "";
         ucDdo_secfunctionalitykey.SendProperty(context, sPrefix, false, Ddo_secfunctionalitykey_Internalname, "SortedStatus", Ddo_secfunctionalitykey_Sortedstatus);
         Ddo_secfunctionalitydescription_Sortedstatus = "";
         ucDdo_secfunctionalitydescription.SendProperty(context, sPrefix, false, Ddo_secfunctionalitydescription_Internalname, "SortedStatus", Ddo_secfunctionalitydescription_Sortedstatus);
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
         if ( AV20OrderedBy == 1 )
         {
            Ddo_secfunctionalitykey_Sortedstatus = (AV21OrderedDsc ? "DSC" : "ASC");
            ucDdo_secfunctionalitykey.SendProperty(context, sPrefix, false, Ddo_secfunctionalitykey_Internalname, "SortedStatus", Ddo_secfunctionalitykey_Sortedstatus);
         }
         else if ( AV20OrderedBy == 2 )
         {
            Ddo_secfunctionalitydescription_Sortedstatus = (AV21OrderedDsc ? "DSC" : "ASC");
            ucDdo_secfunctionalitydescription.SendProperty(context, sPrefix, false, Ddo_secfunctionalitydescription_Internalname, "SortedStatus", Ddo_secfunctionalitydescription_Sortedstatus);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV15Session.Get(AV79Pgmname+"GridState"), "") == 0 )
         {
            AV17GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV79Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV17GridState.FromXml(AV15Session.Get(AV79Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV20OrderedBy = AV17GridState.gxTpr_Orderedby;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20OrderedBy), 4, 0)));
         AV21OrderedDsc = AV17GridState.gxTpr_Ordereddsc;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV21OrderedDsc", AV21OrderedDsc);
         /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV80GXV1 = 1;
         while ( AV80GXV1 <= AV17GridState.gxTpr_Filtervalues.Count )
         {
            AV18GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV17GridState.gxTpr_Filtervalues.Item(AV80GXV1));
            if ( StringUtil.StrCmp(AV18GridStateFilterValue.gxTpr_Name, "SECFUNCTIONALITYKEY") == 0 )
            {
               AV12SecFunctionalityKey = AV18GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV12SecFunctionalityKey", AV12SecFunctionalityKey);
            }
            else if ( StringUtil.StrCmp(AV18GridStateFilterValue.gxTpr_Name, "TFSECFUNCTIONALITYKEY") == 0 )
            {
               AV44TFSecFunctionalityKey = AV18GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV44TFSecFunctionalityKey", AV44TFSecFunctionalityKey);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV44TFSecFunctionalityKey)) )
               {
                  Ddo_secfunctionalitykey_Filteredtext_set = AV44TFSecFunctionalityKey;
                  ucDdo_secfunctionalitykey.SendProperty(context, sPrefix, false, Ddo_secfunctionalitykey_Internalname, "FilteredText_set", Ddo_secfunctionalitykey_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV18GridStateFilterValue.gxTpr_Name, "TFSECFUNCTIONALITYKEY_SEL") == 0 )
            {
               AV45TFSecFunctionalityKey_Sel = AV18GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV45TFSecFunctionalityKey_Sel", AV45TFSecFunctionalityKey_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV45TFSecFunctionalityKey_Sel)) )
               {
                  Ddo_secfunctionalitykey_Selectedvalue_set = AV45TFSecFunctionalityKey_Sel;
                  ucDdo_secfunctionalitykey.SendProperty(context, sPrefix, false, Ddo_secfunctionalitykey_Internalname, "SelectedValue_set", Ddo_secfunctionalitykey_Selectedvalue_set);
               }
            }
            AV80GXV1 = (int)(AV80GXV1+1);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV17GridState.gxTpr_Pagesize))) )
         {
            subGrid_Rows = (int)(NumberUtil.Val( AV17GridState.gxTpr_Pagesize, "."));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         }
      }

      protected void S142( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV17GridState.FromXml(AV15Session.Get(AV79Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV17GridState.gxTpr_Orderedby = AV20OrderedBy;
         AV17GridState.gxTpr_Ordereddsc = AV21OrderedDsc;
         AV17GridState.gxTpr_Filtervalues.Clear();
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12SecFunctionalityKey)) )
         {
            AV18GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV18GridStateFilterValue.gxTpr_Name = "SECFUNCTIONALITYKEY";
            AV18GridStateFilterValue.gxTpr_Value = AV12SecFunctionalityKey;
            AV17GridState.gxTpr_Filtervalues.Add(AV18GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV44TFSecFunctionalityKey)) )
         {
            AV18GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV18GridStateFilterValue.gxTpr_Name = "TFSECFUNCTIONALITYKEY";
            AV18GridStateFilterValue.gxTpr_Value = AV44TFSecFunctionalityKey;
            AV17GridState.gxTpr_Filtervalues.Add(AV18GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV45TFSecFunctionalityKey_Sel)) )
         {
            AV18GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV18GridStateFilterValue.gxTpr_Name = "TFSECFUNCTIONALITYKEY_SEL";
            AV18GridStateFilterValue.gxTpr_Value = AV45TFSecFunctionalityKey_Sel;
            AV17GridState.gxTpr_Filtervalues.Add(AV18GridStateFilterValue, 0);
         }
         if ( ! (0==AV8SecRoleId) )
         {
            AV18GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV18GridStateFilterValue.gxTpr_Name = "PARM_&SECROLEID";
            AV18GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV8SecRoleId), 4, 0);
            AV17GridState.gxTpr_Filtervalues.Add(AV18GridStateFilterValue, 0);
         }
         AV17GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV79Pgmname+"GridState",  AV17GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV10TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV10TrnContext.gxTpr_Callerobject = AV79Pgmname;
         AV10TrnContext.gxTpr_Callerondelete = true;
         AV10TrnContext.gxTpr_Callerurl = AV9HTTPRequest.ScriptName+"?"+AV9HTTPRequest.QueryString;
         AV10TrnContext.gxTpr_Transactionname = "WWPBaseObjects.SecFunctionalityRole";
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11TrnContextAtt.gxTpr_Attributename = "SecRoleId";
         AV11TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8SecRoleId), 4, 0);
         AV10TrnContext.gxTpr_Attributes.Add(AV11TrnContextAtt, 0);
         AV15Session.Set("TrnContext", AV10TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV8SecRoleId = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8SecRoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8SecRoleId), 4, 0)));
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
         PA0W2( ) ;
         WS0W2( ) ;
         WE0W2( ) ;
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
         sCtrlAV8SecRoleId = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA0W2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "wwpbaseobjects\\secrolesecfunctionalityrolewc", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA0W2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV8SecRoleId = Convert.ToInt16(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8SecRoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8SecRoleId), 4, 0)));
         }
         wcpOAV8SecRoleId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV8SecRoleId"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( AV8SecRoleId != wcpOAV8SecRoleId ) ) )
         {
            setjustcreated();
         }
         wcpOAV8SecRoleId = AV8SecRoleId;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV8SecRoleId = cgiGet( sPrefix+"AV8SecRoleId_CTRL");
         if ( StringUtil.Len( sCtrlAV8SecRoleId) > 0 )
         {
            AV8SecRoleId = (short)(context.localUtil.CToN( cgiGet( sCtrlAV8SecRoleId), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8SecRoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8SecRoleId), 4, 0)));
         }
         else
         {
            AV8SecRoleId = (short)(context.localUtil.CToN( cgiGet( sPrefix+"AV8SecRoleId_PARM"), ".", ","));
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
         PA0W2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS0W2( ) ;
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
         WS0W2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"AV8SecRoleId_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8SecRoleId), 4, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV8SecRoleId)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV8SecRoleId_CTRL", StringUtil.RTrim( sCtrlAV8SecRoleId));
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
         WE0W2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202271155813", true);
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
         context.AddJavascriptSource("wwpbaseobjects/secrolesecfunctionalityrolewc.js", "?20202271155813", false);
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
         edtSecFunctionalityId_Internalname = sPrefix+"SECFUNCTIONALITYID_"+sGXsfl_29_idx;
         edtSecFunctionalityKey_Internalname = sPrefix+"SECFUNCTIONALITYKEY_"+sGXsfl_29_idx;
         cmbSecFunctionalityType_Internalname = sPrefix+"SECFUNCTIONALITYTYPE_"+sGXsfl_29_idx;
         edtSecFunctionalityDescription_Internalname = sPrefix+"SECFUNCTIONALITYDESCRIPTION_"+sGXsfl_29_idx;
         edtSecParentFunctionalityDescription_Internalname = sPrefix+"SECPARENTFUNCTIONALITYDESCRIPTION_"+sGXsfl_29_idx;
      }

      protected void SubsflControlProps_fel_292( )
      {
         edtSecFunctionalityId_Internalname = sPrefix+"SECFUNCTIONALITYID_"+sGXsfl_29_fel_idx;
         edtSecFunctionalityKey_Internalname = sPrefix+"SECFUNCTIONALITYKEY_"+sGXsfl_29_fel_idx;
         cmbSecFunctionalityType_Internalname = sPrefix+"SECFUNCTIONALITYTYPE_"+sGXsfl_29_fel_idx;
         edtSecFunctionalityDescription_Internalname = sPrefix+"SECFUNCTIONALITYDESCRIPTION_"+sGXsfl_29_fel_idx;
         edtSecParentFunctionalityDescription_Internalname = sPrefix+"SECPARENTFUNCTIONALITYDESCRIPTION_"+sGXsfl_29_fel_idx;
      }

      protected void sendrow_292( )
      {
         SubsflControlProps_292( ) ;
         WB0W0( ) ;
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
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecFunctionalityId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SecFunctionalityId), 10, 0, ".", "")),context.localUtil.Format( (decimal)(A1SecFunctionalityId), "ZZZZZZZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSecFunctionalityId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)29,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecFunctionalityKey_Internalname,(String)A3SecFunctionalityKey,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSecFunctionalityKey_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)29,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            GXCCtl = "SECFUNCTIONALITYTYPE_" + sGXsfl_29_idx;
            cmbSecFunctionalityType.Name = GXCCtl;
            cmbSecFunctionalityType.WebTags = "";
            cmbSecFunctionalityType.addItem("1", "Mode", 0);
            cmbSecFunctionalityType.addItem("2", "Action", 0);
            cmbSecFunctionalityType.addItem("3", "Tab", 0);
            cmbSecFunctionalityType.addItem("4", "Object", 0);
            cmbSecFunctionalityType.addItem("5", "Attribute", 0);
            if ( cmbSecFunctionalityType.ItemCount > 0 )
            {
               A9SecFunctionalityType = (short)(NumberUtil.Val( cmbSecFunctionalityType.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A9SecFunctionalityType), 2, 0))), "."));
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbSecFunctionalityType,(String)cmbSecFunctionalityType_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(A9SecFunctionalityType), 2, 0)),(short)1,(String)cmbSecFunctionalityType_Jsonclick,(short)0,(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)0,(short)0,(short)1,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn",(String)"",(String)"",(String)"",(bool)true});
            cmbSecFunctionalityType.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A9SecFunctionalityType), 2, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbSecFunctionalityType_Internalname, "Values", (String)(cmbSecFunctionalityType.ToJavascriptSource()), !bGXsfl_29_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecFunctionalityDescription_Internalname,(String)A8SecFunctionalityDescription,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)edtSecFunctionalityDescription_Link,(String)"",(String)"",(String)"",(String)edtSecFunctionalityDescription_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)29,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecParentFunctionalityDescription_Internalname,(String)A11SecParentFunctionalityDescription,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSecParentFunctionalityDescription_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)29,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes0W2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_29_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_29_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_29_idx+1));
            sGXsfl_29_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_29_idx), 4, 0)), 4, "0");
            SubsflControlProps_292( ) ;
         }
         /* End function sendrow_292 */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "SECFUNCTIONALITYTYPE_" + sGXsfl_29_idx;
         cmbSecFunctionalityType.Name = GXCCtl;
         cmbSecFunctionalityType.WebTags = "";
         cmbSecFunctionalityType.addItem("1", "Mode", 0);
         cmbSecFunctionalityType.addItem("2", "Action", 0);
         cmbSecFunctionalityType.addItem("3", "Tab", 0);
         cmbSecFunctionalityType.addItem("4", "Object", 0);
         cmbSecFunctionalityType.addItem("5", "Attribute", 0);
         if ( cmbSecFunctionalityType.ItemCount > 0 )
         {
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblFiltertextsecfunctionalitykey_Internalname = sPrefix+"FILTERTEXTSECFUNCTIONALITYKEY";
         edtavSecfunctionalitykey_Internalname = sPrefix+"vSECFUNCTIONALITYKEY";
         divUnnamedtableecfunctionalitykey_Internalname = sPrefix+"UNNAMEDTABLEECFUNCTIONALITYKEY";
         divTableheader_Internalname = sPrefix+"TABLEHEADER";
         divLayout_tableheader_Internalname = sPrefix+"LAYOUT_TABLEHEADER";
         Dvpanel_tableheader_Internalname = sPrefix+"DVPANEL_TABLEHEADER";
         divHtml_dvpanel_tableheader_Internalname = sPrefix+"HTML_DVPANEL_TABLEHEADER";
         edtSecFunctionalityId_Internalname = sPrefix+"SECFUNCTIONALITYID";
         edtSecFunctionalityKey_Internalname = sPrefix+"SECFUNCTIONALITYKEY";
         cmbSecFunctionalityType_Internalname = sPrefix+"SECFUNCTIONALITYTYPE";
         edtSecFunctionalityDescription_Internalname = sPrefix+"SECFUNCTIONALITYDESCRIPTION";
         edtSecParentFunctionalityDescription_Internalname = sPrefix+"SECPARENTFUNCTIONALITYDESCRIPTION";
         Gridpaginationbar_Internalname = sPrefix+"GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = sPrefix+"HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = sPrefix+"GRIDTABLEWITHPAGINATIONBAR";
         divTablegridheader_Internalname = sPrefix+"TABLEGRIDHEADER";
         Ddo_secfunctionalitykey_Internalname = sPrefix+"DDO_SECFUNCTIONALITYKEY";
         edtavDdo_secfunctionalitykeytitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE";
         Ddo_secfunctionalitydescription_Internalname = sPrefix+"DDO_SECFUNCTIONALITYDESCRIPTION";
         edtavDdo_secfunctionalitydescriptiontitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE";
         edtSecRoleId_Internalname = sPrefix+"SECROLEID";
         Workwithplusutilities1_Internalname = sPrefix+"WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = sPrefix+"vORDEREDBY";
         edtavOrdereddsc_Internalname = sPrefix+"vORDEREDDSC";
         edtavTfsecfunctionalitykey_Internalname = sPrefix+"vTFSECFUNCTIONALITYKEY";
         edtavTfsecfunctionalitykey_sel_Internalname = sPrefix+"vTFSECFUNCTIONALITYKEY_SEL";
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
         edtSecParentFunctionalityDescription_Jsonclick = "";
         edtSecFunctionalityDescription_Jsonclick = "";
         cmbSecFunctionalityType_Jsonclick = "";
         edtSecFunctionalityKey_Jsonclick = "";
         edtSecFunctionalityId_Jsonclick = "";
         edtavTfsecfunctionalitykey_sel_Jsonclick = "";
         edtavTfsecfunctionalitykey_sel_Visible = 1;
         edtavTfsecfunctionalitykey_Jsonclick = "";
         edtavTfsecfunctionalitykey_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtSecRoleId_Jsonclick = "";
         edtSecRoleId_Visible = 1;
         edtavDdo_secfunctionalitydescriptiontitlecontrolidtoreplace_Visible = 1;
         edtavDdo_secfunctionalitykeytitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtSecFunctionalityDescription_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtSecFunctionalityDescription_Titleformat = 0;
         edtSecFunctionalityDescription_Title = "权限描述";
         edtSecFunctionalityKey_Titleformat = 0;
         edtSecFunctionalityKey_Title = "权限名称";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         edtavSecfunctionalitykey_Jsonclick = "";
         edtavSecfunctionalitykey_Enabled = 1;
         Ddo_secfunctionalitydescription_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_secfunctionalitydescription_Sortdsc = "WWP_TSSortDSC";
         Ddo_secfunctionalitydescription_Sortasc = "WWP_TSSortASC";
         Ddo_secfunctionalitydescription_Includedatalist = Convert.ToBoolean( 0);
         Ddo_secfunctionalitydescription_Includefilter = Convert.ToBoolean( 0);
         Ddo_secfunctionalitydescription_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_secfunctionalitydescription_Includesortasc = Convert.ToBoolean( -1);
         Ddo_secfunctionalitydescription_Titlecontrolidtoreplace = "";
         Ddo_secfunctionalitydescription_Dropdownoptionstype = "GridTitleSettings";
         Ddo_secfunctionalitydescription_Cls = "ColumnSettings";
         Ddo_secfunctionalitydescription_Tooltip = "WWP_TSColumnOptions";
         Ddo_secfunctionalitydescription_Caption = "";
         Ddo_secfunctionalitykey_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_secfunctionalitykey_Noresultsfound = "WWP_TSNoResults";
         Ddo_secfunctionalitykey_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_secfunctionalitykey_Loadingdata = "WWP_TSLoading";
         Ddo_secfunctionalitykey_Sortdsc = "WWP_TSSortDSC";
         Ddo_secfunctionalitykey_Sortasc = "WWP_TSSortASC";
         Ddo_secfunctionalitykey_Datalistupdateminimumcharacters = 0;
         Ddo_secfunctionalitykey_Datalistproc = "WWPBaseObjects.SecRoleSecFunctionalityRoleWCGetFilterData";
         Ddo_secfunctionalitykey_Datalisttype = "Dynamic";
         Ddo_secfunctionalitykey_Includedatalist = Convert.ToBoolean( -1);
         Ddo_secfunctionalitykey_Filterisrange = Convert.ToBoolean( 0);
         Ddo_secfunctionalitykey_Filtertype = "Character";
         Ddo_secfunctionalitykey_Includefilter = Convert.ToBoolean( -1);
         Ddo_secfunctionalitykey_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_secfunctionalitykey_Includesortasc = Convert.ToBoolean( -1);
         Ddo_secfunctionalitykey_Titlecontrolidtoreplace = "";
         Ddo_secfunctionalitykey_Dropdownoptionstype = "GridTitleSettings";
         Ddo_secfunctionalitykey_Cls = "ColumnSettings";
         Ddo_secfunctionalitykey_Tooltip = "WWP_TSColumnOptions";
         Ddo_secfunctionalitykey_Caption = "";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'sPrefix'},{av:'AV46ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV79Pgmname',fld:'vPGMNAME',pic:''},{av:'AV20OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV21OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV12SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV44TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'AV45TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'AV8SecRoleId',fld:'vSECROLEID',pic:'ZZZ9'},{av:'AV16IsAuthorized_SecFunctionalityDescription',fld:'vISAUTHORIZED_SECFUNCTIONALITYDESCRIPTION',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV43SecFunctionalityKeyTitleFilterData',fld:'vSECFUNCTIONALITYKEYTITLEFILTERDATA',pic:''},{av:'AV50SecFunctionalityDescriptionTitleFilterData',fld:'vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtSecFunctionalityKey_Titleformat',ctrl:'SECFUNCTIONALITYKEY',prop:'Titleformat'},{av:'edtSecFunctionalityKey_Title',ctrl:'SECFUNCTIONALITYKEY',prop:'Title'},{av:'edtSecFunctionalityDescription_Titleformat',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Titleformat'},{av:'edtSecFunctionalityDescription_Title',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV72GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV73GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E110W2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV12SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV20OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV21OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV44TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'AV45TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'AV8SecRoleId',fld:'vSECROLEID',pic:'ZZZ9'},{av:'AV46ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV79Pgmname',fld:'vPGMNAME',pic:''},{av:'AV16IsAuthorized_SecFunctionalityDescription',fld:'vISAUTHORIZED_SECFUNCTIONALITYDESCRIPTION',pic:'',hsh:true},{av:'sPrefix'},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E120W2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV12SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV20OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV21OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV44TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'AV45TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'AV8SecRoleId',fld:'vSECROLEID',pic:'ZZZ9'},{av:'AV46ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV79Pgmname',fld:'vPGMNAME',pic:''},{av:'AV16IsAuthorized_SecFunctionalityDescription',fld:'vISAUTHORIZED_SECFUNCTIONALITYDESCRIPTION',pic:'',hsh:true},{av:'sPrefix'},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_SECFUNCTIONALITYKEY.ONOPTIONCLICKED","{handler:'E130W2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV12SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV20OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV21OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV44TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'AV45TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'AV8SecRoleId',fld:'vSECROLEID',pic:'ZZZ9'},{av:'AV46ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV79Pgmname',fld:'vPGMNAME',pic:''},{av:'AV16IsAuthorized_SecFunctionalityDescription',fld:'vISAUTHORIZED_SECFUNCTIONALITYDESCRIPTION',pic:'',hsh:true},{av:'sPrefix'},{av:'Ddo_secfunctionalitykey_Activeeventkey',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'ActiveEventKey'},{av:'Ddo_secfunctionalitykey_Filteredtext_get',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'FilteredText_get'},{av:'Ddo_secfunctionalitykey_Selectedvalue_get',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_SECFUNCTIONALITYKEY.ONOPTIONCLICKED",",oparms:[{av:'AV20OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV21OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_secfunctionalitykey_Sortedstatus',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'SortedStatus'},{av:'AV44TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'AV45TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'Ddo_secfunctionalitydescription_Sortedstatus',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'SortedStatus'},{av:'AV43SecFunctionalityKeyTitleFilterData',fld:'vSECFUNCTIONALITYKEYTITLEFILTERDATA',pic:''},{av:'AV50SecFunctionalityDescriptionTitleFilterData',fld:'vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtSecFunctionalityKey_Titleformat',ctrl:'SECFUNCTIONALITYKEY',prop:'Titleformat'},{av:'edtSecFunctionalityKey_Title',ctrl:'SECFUNCTIONALITYKEY',prop:'Title'},{av:'edtSecFunctionalityDescription_Titleformat',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Titleformat'},{av:'edtSecFunctionalityDescription_Title',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV72GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV73GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_SECFUNCTIONALITYDESCRIPTION.ONOPTIONCLICKED","{handler:'E140W2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV12SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV20OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV21OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV44TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'AV45TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'AV8SecRoleId',fld:'vSECROLEID',pic:'ZZZ9'},{av:'AV46ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV79Pgmname',fld:'vPGMNAME',pic:''},{av:'AV16IsAuthorized_SecFunctionalityDescription',fld:'vISAUTHORIZED_SECFUNCTIONALITYDESCRIPTION',pic:'',hsh:true},{av:'sPrefix'},{av:'Ddo_secfunctionalitydescription_Activeeventkey',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_SECFUNCTIONALITYDESCRIPTION.ONOPTIONCLICKED",",oparms:[{av:'AV20OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV21OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_secfunctionalitydescription_Sortedstatus',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'SortedStatus'},{av:'Ddo_secfunctionalitykey_Sortedstatus',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'SortedStatus'},{av:'AV43SecFunctionalityKeyTitleFilterData',fld:'vSECFUNCTIONALITYKEYTITLEFILTERDATA',pic:''},{av:'AV50SecFunctionalityDescriptionTitleFilterData',fld:'vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtSecFunctionalityKey_Titleformat',ctrl:'SECFUNCTIONALITYKEY',prop:'Titleformat'},{av:'edtSecFunctionalityKey_Title',ctrl:'SECFUNCTIONALITYKEY',prop:'Title'},{av:'edtSecFunctionalityDescription_Titleformat',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Titleformat'},{av:'edtSecFunctionalityDescription_Title',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV72GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV73GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E170W2',iparms:[{av:'AV16IsAuthorized_SecFunctionalityDescription',fld:'vISAUTHORIZED_SECFUNCTIONALITYDESCRIPTION',pic:'',hsh:true},{av:'A1SecFunctionalityId',fld:'SECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'edtSecFunctionalityDescription_Link',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Link'}]}");
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
         Ddo_secfunctionalitykey_Activeeventkey = "";
         Ddo_secfunctionalitykey_Filteredtext_get = "";
         Ddo_secfunctionalitykey_Selectedvalue_get = "";
         Ddo_secfunctionalitydescription_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sPrefix = "";
         AV12SecFunctionalityKey = "";
         AV44TFSecFunctionalityKey = "";
         AV45TFSecFunctionalityKey_Sel = "";
         AV46ddo_SecFunctionalityKeyTitleControlIdToReplace = "";
         AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace = "";
         AV79Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV58DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV43SecFunctionalityKeyTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV50SecFunctionalityDescriptionTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_secfunctionalitykey_Filteredtext_set = "";
         Ddo_secfunctionalitykey_Selectedvalue_set = "";
         Ddo_secfunctionalitykey_Sortedstatus = "";
         Ddo_secfunctionalitydescription_Sortedstatus = "";
         GX_FocusControl = "";
         ucDvpanel_tableheader = new GXUserControl();
         lblFiltertextsecfunctionalitykey_Jsonclick = "";
         TempTags = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         A3SecFunctionalityKey = "";
         A8SecFunctionalityDescription = "";
         A11SecParentFunctionalityDescription = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_secfunctionalitykey = new GXUserControl();
         ClassString = "";
         StyleString = "";
         ucDdo_secfunctionalitydescription = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         lV12SecFunctionalityKey = "";
         lV44TFSecFunctionalityKey = "";
         H000W2_A2SecParentFunctionalityId = new long[1] ;
         H000W2_n2SecParentFunctionalityId = new bool[] {false} ;
         H000W2_A4SecRoleId = new short[1] ;
         H000W2_A11SecParentFunctionalityDescription = new String[] {""} ;
         H000W2_A8SecFunctionalityDescription = new String[] {""} ;
         H000W2_A9SecFunctionalityType = new short[1] ;
         H000W2_A3SecFunctionalityKey = new String[] {""} ;
         H000W2_A1SecFunctionalityId = new long[1] ;
         H000W3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV66WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         AV15Session = context.GetSession();
         AV17GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV18GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV10TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9HTTPRequest = new GxHttpRequest( context);
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlAV8SecRoleId = "";
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secrolesecfunctionalityrolewc__default(),
            new Object[][] {
                new Object[] {
               H000W2_A2SecParentFunctionalityId, H000W2_n2SecParentFunctionalityId, H000W2_A4SecRoleId, H000W2_A11SecParentFunctionalityDescription, H000W2_A8SecFunctionalityDescription, H000W2_A9SecFunctionalityType, H000W2_A3SecFunctionalityKey, H000W2_A1SecFunctionalityId
               }
               , new Object[] {
               H000W3_AGRID_nRecordCount
               }
            }
         );
         AV79Pgmname = "WWPBaseObjects.SecRoleSecFunctionalityRoleWC";
         /* GeneXus formulas. */
         AV79Pgmname = "WWPBaseObjects.SecRoleSecFunctionalityRoleWC";
         context.Gx_err = 0;
      }

      private short AV8SecRoleId ;
      private short wcpOAV8SecRoleId ;
      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short nRC_GXsfl_29 ;
      private short nGXsfl_29_idx=1 ;
      private short GRID_nEOF ;
      private short AV20OrderedBy ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtSecFunctionalityKey_Titleformat ;
      private short edtSecFunctionalityDescription_Titleformat ;
      private short subGrid_Sortable ;
      private short A9SecFunctionalityType ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short A4SecRoleId ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid_Backstyle ;
      private int subGrid_Rows ;
      private int Gridpaginationbar_Rowsperpageselectedvalue ;
      private int Gridpaginationbar_Pagestoshow ;
      private int Ddo_secfunctionalitykey_Datalistupdateminimumcharacters ;
      private int edtavSecfunctionalitykey_Enabled ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_secfunctionalitykeytitlecontrolidtoreplace_Visible ;
      private int edtavDdo_secfunctionalitydescriptiontitlecontrolidtoreplace_Visible ;
      private int edtSecRoleId_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfsecfunctionalitykey_Visible ;
      private int edtavTfsecfunctionalitykey_sel_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV69PageToGo ;
      private int AV80GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV70GridCurrentPage ;
      private long AV73GridRecordCount ;
      private long AV72GridPageSize ;
      private long A1SecFunctionalityId ;
      private long GRID_nCurrentRecord ;
      private long A2SecParentFunctionalityId ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_secfunctionalitykey_Activeeventkey ;
      private String Ddo_secfunctionalitykey_Filteredtext_get ;
      private String Ddo_secfunctionalitykey_Selectedvalue_get ;
      private String Ddo_secfunctionalitydescription_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sGXsfl_29_idx="0001" ;
      private String AV79Pgmname ;
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
      private String Ddo_secfunctionalitykey_Caption ;
      private String Ddo_secfunctionalitykey_Tooltip ;
      private String Ddo_secfunctionalitykey_Cls ;
      private String Ddo_secfunctionalitykey_Filteredtext_set ;
      private String Ddo_secfunctionalitykey_Selectedvalue_set ;
      private String Ddo_secfunctionalitykey_Dropdownoptionstype ;
      private String Ddo_secfunctionalitykey_Titlecontrolidtoreplace ;
      private String Ddo_secfunctionalitykey_Sortedstatus ;
      private String Ddo_secfunctionalitykey_Filtertype ;
      private String Ddo_secfunctionalitykey_Datalisttype ;
      private String Ddo_secfunctionalitykey_Datalistproc ;
      private String Ddo_secfunctionalitykey_Sortasc ;
      private String Ddo_secfunctionalitykey_Sortdsc ;
      private String Ddo_secfunctionalitykey_Loadingdata ;
      private String Ddo_secfunctionalitykey_Cleanfilter ;
      private String Ddo_secfunctionalitykey_Noresultsfound ;
      private String Ddo_secfunctionalitykey_Searchbuttontext ;
      private String Ddo_secfunctionalitydescription_Caption ;
      private String Ddo_secfunctionalitydescription_Tooltip ;
      private String Ddo_secfunctionalitydescription_Cls ;
      private String Ddo_secfunctionalitydescription_Dropdownoptionstype ;
      private String Ddo_secfunctionalitydescription_Titlecontrolidtoreplace ;
      private String Ddo_secfunctionalitydescription_Sortedstatus ;
      private String Ddo_secfunctionalitydescription_Sortasc ;
      private String Ddo_secfunctionalitydescription_Sortdsc ;
      private String Ddo_secfunctionalitydescription_Searchbuttontext ;
      private String GX_FocusControl ;
      private String divLayoutmaintable_Internalname ;
      private String divTablegridheader_Internalname ;
      private String divHtml_dvpanel_tableheader_Internalname ;
      private String Dvpanel_tableheader_Internalname ;
      private String divLayout_tableheader_Internalname ;
      private String divTableheader_Internalname ;
      private String divUnnamedtableecfunctionalitykey_Internalname ;
      private String lblFiltertextsecfunctionalitykey_Internalname ;
      private String lblFiltertextsecfunctionalitykey_Jsonclick ;
      private String edtavSecfunctionalitykey_Internalname ;
      private String TempTags ;
      private String edtavSecfunctionalitykey_Jsonclick ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtSecFunctionalityKey_Title ;
      private String edtSecFunctionalityDescription_Title ;
      private String subGrid_Header ;
      private String edtSecFunctionalityDescription_Link ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_secfunctionalitykey_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_secfunctionalitykeytitlecontrolidtoreplace_Internalname ;
      private String Ddo_secfunctionalitydescription_Internalname ;
      private String edtavDdo_secfunctionalitydescriptiontitlecontrolidtoreplace_Internalname ;
      private String edtSecRoleId_Internalname ;
      private String edtSecRoleId_Jsonclick ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavTfsecfunctionalitykey_Internalname ;
      private String edtavTfsecfunctionalitykey_Jsonclick ;
      private String edtavTfsecfunctionalitykey_sel_Internalname ;
      private String edtavTfsecfunctionalitykey_sel_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtSecFunctionalityId_Internalname ;
      private String edtSecFunctionalityKey_Internalname ;
      private String cmbSecFunctionalityType_Internalname ;
      private String edtSecFunctionalityDescription_Internalname ;
      private String edtSecParentFunctionalityDescription_Internalname ;
      private String scmdbuf ;
      private String sCtrlAV8SecRoleId ;
      private String sGXsfl_29_fel_idx="0001" ;
      private String ROClassString ;
      private String edtSecFunctionalityId_Jsonclick ;
      private String edtSecFunctionalityKey_Jsonclick ;
      private String GXCCtl ;
      private String cmbSecFunctionalityType_Jsonclick ;
      private String edtSecFunctionalityDescription_Jsonclick ;
      private String edtSecParentFunctionalityDescription_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV21OrderedDsc ;
      private bool AV16IsAuthorized_SecFunctionalityDescription ;
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
      private bool Ddo_secfunctionalitykey_Includesortasc ;
      private bool Ddo_secfunctionalitykey_Includesortdsc ;
      private bool Ddo_secfunctionalitykey_Includefilter ;
      private bool Ddo_secfunctionalitykey_Filterisrange ;
      private bool Ddo_secfunctionalitykey_Includedatalist ;
      private bool Ddo_secfunctionalitydescription_Includesortasc ;
      private bool Ddo_secfunctionalitydescription_Includesortdsc ;
      private bool Ddo_secfunctionalitydescription_Includefilter ;
      private bool Ddo_secfunctionalitydescription_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_29_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool n2SecParentFunctionalityId ;
      private bool returnInSub ;
      private bool GXt_boolean1 ;
      private bool gx_refresh_fired ;
      private String AV12SecFunctionalityKey ;
      private String AV44TFSecFunctionalityKey ;
      private String AV45TFSecFunctionalityKey_Sel ;
      private String AV46ddo_SecFunctionalityKeyTitleControlIdToReplace ;
      private String AV53ddo_SecFunctionalityDescriptionTitleControlIdToReplace ;
      private String A3SecFunctionalityKey ;
      private String A8SecFunctionalityDescription ;
      private String A11SecParentFunctionalityDescription ;
      private String lV12SecFunctionalityKey ;
      private String lV44TFSecFunctionalityKey ;
      private IGxSession AV15Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_secfunctionalitykey ;
      private GXUserControl ucDdo_secfunctionalitydescription ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbSecFunctionalityType ;
      private IDataStoreProvider pr_default ;
      private long[] H000W2_A2SecParentFunctionalityId ;
      private bool[] H000W2_n2SecParentFunctionalityId ;
      private short[] H000W2_A4SecRoleId ;
      private String[] H000W2_A11SecParentFunctionalityDescription ;
      private String[] H000W2_A8SecFunctionalityDescription ;
      private short[] H000W2_A9SecFunctionalityType ;
      private String[] H000W2_A3SecFunctionalityKey ;
      private long[] H000W2_A1SecFunctionalityId ;
      private long[] H000W3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV9HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV43SecFunctionalityKeyTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV50SecFunctionalityDescriptionTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV66WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV10TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV11TrnContextAtt ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV17GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV18GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV58DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class secrolesecfunctionalityrolewc__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H000W2( IGxContext context ,
                                             String AV12SecFunctionalityKey ,
                                             String AV45TFSecFunctionalityKey_Sel ,
                                             String AV44TFSecFunctionalityKey ,
                                             String A3SecFunctionalityKey ,
                                             short AV20OrderedBy ,
                                             bool AV21OrderedDsc ,
                                             short A4SecRoleId ,
                                             short AV8SecRoleId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " T2.[SecParentFunctionalityId] AS SecParentFunctionalityId, T1.[SecRoleId], T3.[SecFunctionalityDescription] AS SecParentFunctionalityDescription, T2.[SecFunctionalityDescription], T2.[SecFunctionalityType], T2.[SecFunctionalityKey], T1.[SecFunctionalityId]";
         sFromString = " FROM (([SecFunctionalityRole] T1 WITH (NOLOCK) INNER JOIN [SecFunctionality] T2 WITH (NOLOCK) ON T2.[SecFunctionalityId] = T1.[SecFunctionalityId]) LEFT JOIN [SecFunctionality] T3 WITH (NOLOCK) ON T3.[SecFunctionalityId] = T2.[SecParentFunctionalityId])";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE (T1.[SecRoleId] = @AV8SecRoleId)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12SecFunctionalityKey)) )
         {
            sWhereString = sWhereString + " and (T2.[SecFunctionalityKey] like '%' + @lV12SecFunctionalityKey + '%')";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV45TFSecFunctionalityKey_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV44TFSecFunctionalityKey)) ) )
         {
            sWhereString = sWhereString + " and (T2.[SecFunctionalityKey] like @lV44TFSecFunctionalityKey)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV45TFSecFunctionalityKey_Sel)) )
         {
            sWhereString = sWhereString + " and (T2.[SecFunctionalityKey] = @AV45TFSecFunctionalityKey_Sel)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ( AV20OrderedBy == 1 ) && ! AV21OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[SecRoleId], T2.[SecFunctionalityKey]";
         }
         else if ( ( AV20OrderedBy == 1 ) && ( AV21OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[SecRoleId] DESC, T2.[SecFunctionalityKey] DESC";
         }
         else if ( ( AV20OrderedBy == 2 ) && ! AV21OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[SecRoleId], T2.[SecFunctionalityDescription]";
         }
         else if ( ( AV20OrderedBy == 2 ) && ( AV21OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[SecRoleId] DESC, T2.[SecFunctionalityDescription] DESC";
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

      protected Object[] conditional_H000W3( IGxContext context ,
                                             String AV12SecFunctionalityKey ,
                                             String AV45TFSecFunctionalityKey_Sel ,
                                             String AV44TFSecFunctionalityKey ,
                                             String A3SecFunctionalityKey ,
                                             short AV20OrderedBy ,
                                             bool AV21OrderedDsc ,
                                             short A4SecRoleId ,
                                             short AV8SecRoleId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [4] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM (([SecFunctionalityRole] T1 WITH (NOLOCK) INNER JOIN [SecFunctionality] T2 WITH (NOLOCK) ON T2.[SecFunctionalityId] = T1.[SecFunctionalityId]) LEFT JOIN [SecFunctionality] T3 WITH (NOLOCK) ON T3.[SecFunctionalityId] = T2.[SecParentFunctionalityId])";
         scmdbuf = scmdbuf + " WHERE (T1.[SecRoleId] = @AV8SecRoleId)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12SecFunctionalityKey)) )
         {
            sWhereString = sWhereString + " and (T2.[SecFunctionalityKey] like '%' + @lV12SecFunctionalityKey + '%')";
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV45TFSecFunctionalityKey_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV44TFSecFunctionalityKey)) ) )
         {
            sWhereString = sWhereString + " and (T2.[SecFunctionalityKey] like @lV44TFSecFunctionalityKey)";
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV45TFSecFunctionalityKey_Sel)) )
         {
            sWhereString = sWhereString + " and (T2.[SecFunctionalityKey] = @AV45TFSecFunctionalityKey_Sel)";
         }
         else
         {
            GXv_int5[3] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         if ( ( AV20OrderedBy == 1 ) && ! AV21OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV20OrderedBy == 1 ) && ( AV21OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV20OrderedBy == 2 ) && ! AV21OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV20OrderedBy == 2 ) && ( AV21OrderedDsc ) )
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
                     return conditional_H000W2(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (short)dynConstraints[4] , (bool)dynConstraints[5] , (short)dynConstraints[6] , (short)dynConstraints[7] );
               case 1 :
                     return conditional_H000W3(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (short)dynConstraints[4] , (bool)dynConstraints[5] , (short)dynConstraints[6] , (short)dynConstraints[7] );
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
          Object[] prmH000W2 ;
          prmH000W2 = new Object[] {
          new Object[] {"@AV8SecRoleId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV12SecFunctionalityKey",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV44TFSecFunctionalityKey",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV45TFSecFunctionalityKey_Sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH000W3 ;
          prmH000W3 = new Object[] {
          new Object[] {"@AV8SecRoleId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV12SecFunctionalityKey",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV44TFSecFunctionalityKey",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV45TFSecFunctionalityKey_Sel",SqlDbType.NVarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000W2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000W2,11,0,true,false )
             ,new CursorDef("H000W3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000W3,1,0,true,false )
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
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(6) ;
                ((long[]) buf[7])[0] = rslt.getLong(7) ;
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
                   stmt.SetParameter(sIdx, (short)parms[7]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[8]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[9]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[11]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[12]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[13]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[4]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[5]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[6]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                return;
       }
    }

 }

}
