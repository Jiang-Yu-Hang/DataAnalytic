/*
               File: WWPBaseObjects.SecFunctionalityWW
        Description: Work With Functionality
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:39:9.8
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
   public class secfunctionalityww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public secfunctionalityww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public secfunctionalityww( IGxContext context )
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
         cmbSecFunctionalityType = new GXCombobox();
         chkSecFunctionalityActive = new GXCheckbox();
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
               nRC_GXsfl_36 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_36_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_36_idx = GetNextPar( );
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
               AV22SecFunctionalityKey = GetNextPar( );
               AV10SecFunctionalityDescription = GetNextPar( );
               AV29OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV30OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV41TFSecFunctionalityKey = GetNextPar( );
               AV42TFSecFunctionalityKey_Sel = GetNextPar( );
               AV45TFSecFunctionalityDescription = GetNextPar( );
               AV46TFSecFunctionalityDescription_Sel = GetNextPar( );
               AV43ddo_SecFunctionalityKeyTitleControlIdToReplace = GetNextPar( );
               AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace = GetNextPar( );
               AV105Pgmname = GetNextPar( );
               AV18IsAuthorized_Update = StringUtil.StrToBool( GetNextPar( ));
               AV19IsAuthorized_Delete = StringUtil.StrToBool( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV22SecFunctionalityKey, AV10SecFunctionalityDescription, AV29OrderedBy, AV30OrderedDsc, AV41TFSecFunctionalityKey, AV42TFSecFunctionalityKey_Sel, AV45TFSecFunctionalityDescription, AV46TFSecFunctionalityDescription_Sel, AV43ddo_SecFunctionalityKeyTitleControlIdToReplace, AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace, AV105Pgmname, AV18IsAuthorized_Update, AV19IsAuthorized_Delete) ;
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
         PA0H2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0H2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2020227939928", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("wwpbaseobjects.secfunctionalityww.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vSECFUNCTIONALITYKEY", AV22SecFunctionalityKey);
         GxWebStd.gx_hidden_field( context, "GXH_vSECFUNCTIONALITYDESCRIPTION", AV10SecFunctionalityDescription);
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV29OrderedBy), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV30OrderedDsc));
         GxWebStd.gx_hidden_field( context, "GXH_vTFSECFUNCTIONALITYKEY", AV41TFSecFunctionalityKey);
         GxWebStd.gx_hidden_field( context, "GXH_vTFSECFUNCTIONALITYKEY_SEL", AV42TFSecFunctionalityKey_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFSECFUNCTIONALITYDESCRIPTION", AV45TFSecFunctionalityDescription);
         GxWebStd.gx_hidden_field( context, "GXH_vTFSECFUNCTIONALITYDESCRIPTION_SEL", AV46TFSecFunctionalityDescription_Sel);
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_36", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_36), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV85GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV88GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV87GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV55DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV55DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vSECFUNCTIONALITYKEYTITLEFILTERDATA", AV40SecFunctionalityKeyTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vSECFUNCTIONALITYKEYTITLEFILTERDATA", AV40SecFunctionalityKeyTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA", AV44SecFunctionalityDescriptionTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA", AV44SecFunctionalityDescriptionTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV105Pgmname));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_UPDATE", AV18IsAuthorized_Update);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_DELETE", AV19IsAuthorized_Delete);
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
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Caption", StringUtil.RTrim( Ddo_secfunctionalitykey_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Tooltip", StringUtil.RTrim( Ddo_secfunctionalitykey_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Cls", StringUtil.RTrim( Ddo_secfunctionalitykey_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Filteredtext_set", StringUtil.RTrim( Ddo_secfunctionalitykey_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Selectedvalue_set", StringUtil.RTrim( Ddo_secfunctionalitykey_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Dropdownoptionstype", StringUtil.RTrim( Ddo_secfunctionalitykey_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_secfunctionalitykey_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Includesortasc", StringUtil.BoolToStr( Ddo_secfunctionalitykey_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Includesortdsc", StringUtil.BoolToStr( Ddo_secfunctionalitykey_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Sortedstatus", StringUtil.RTrim( Ddo_secfunctionalitykey_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Includefilter", StringUtil.BoolToStr( Ddo_secfunctionalitykey_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Filtertype", StringUtil.RTrim( Ddo_secfunctionalitykey_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Filterisrange", StringUtil.BoolToStr( Ddo_secfunctionalitykey_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Includedatalist", StringUtil.BoolToStr( Ddo_secfunctionalitykey_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Datalisttype", StringUtil.RTrim( Ddo_secfunctionalitykey_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Datalistproc", StringUtil.RTrim( Ddo_secfunctionalitykey_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_secfunctionalitykey_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Sortasc", StringUtil.RTrim( Ddo_secfunctionalitykey_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Sortdsc", StringUtil.RTrim( Ddo_secfunctionalitykey_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Loadingdata", StringUtil.RTrim( Ddo_secfunctionalitykey_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Cleanfilter", StringUtil.RTrim( Ddo_secfunctionalitykey_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Noresultsfound", StringUtil.RTrim( Ddo_secfunctionalitykey_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Searchbuttontext", StringUtil.RTrim( Ddo_secfunctionalitykey_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Caption", StringUtil.RTrim( Ddo_secfunctionalitydescription_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Tooltip", StringUtil.RTrim( Ddo_secfunctionalitydescription_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Cls", StringUtil.RTrim( Ddo_secfunctionalitydescription_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Filteredtext_set", StringUtil.RTrim( Ddo_secfunctionalitydescription_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Selectedvalue_set", StringUtil.RTrim( Ddo_secfunctionalitydescription_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Dropdownoptionstype", StringUtil.RTrim( Ddo_secfunctionalitydescription_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_secfunctionalitydescription_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Includesortasc", StringUtil.BoolToStr( Ddo_secfunctionalitydescription_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Includesortdsc", StringUtil.BoolToStr( Ddo_secfunctionalitydescription_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Sortedstatus", StringUtil.RTrim( Ddo_secfunctionalitydescription_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Includefilter", StringUtil.BoolToStr( Ddo_secfunctionalitydescription_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Filtertype", StringUtil.RTrim( Ddo_secfunctionalitydescription_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Filterisrange", StringUtil.BoolToStr( Ddo_secfunctionalitydescription_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Includedatalist", StringUtil.BoolToStr( Ddo_secfunctionalitydescription_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Datalisttype", StringUtil.RTrim( Ddo_secfunctionalitydescription_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Datalistproc", StringUtil.RTrim( Ddo_secfunctionalitydescription_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_secfunctionalitydescription_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Sortasc", StringUtil.RTrim( Ddo_secfunctionalitydescription_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Sortdsc", StringUtil.RTrim( Ddo_secfunctionalitydescription_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Loadingdata", StringUtil.RTrim( Ddo_secfunctionalitydescription_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Cleanfilter", StringUtil.RTrim( Ddo_secfunctionalitydescription_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Noresultsfound", StringUtil.RTrim( Ddo_secfunctionalitydescription_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Searchbuttontext", StringUtil.RTrim( Ddo_secfunctionalitydescription_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Activeeventkey", StringUtil.RTrim( Ddo_secfunctionalitykey_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Filteredtext_get", StringUtil.RTrim( Ddo_secfunctionalitykey_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Selectedvalue_get", StringUtil.RTrim( Ddo_secfunctionalitykey_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Activeeventkey", StringUtil.RTrim( Ddo_secfunctionalitydescription_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Filteredtext_get", StringUtil.RTrim( Ddo_secfunctionalitydescription_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Selectedvalue_get", StringUtil.RTrim( Ddo_secfunctionalitydescription_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Activeeventkey", StringUtil.RTrim( Ddo_secfunctionalitykey_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Filteredtext_get", StringUtil.RTrim( Ddo_secfunctionalitykey_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Selectedvalue_get", StringUtil.RTrim( Ddo_secfunctionalitykey_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Activeeventkey", StringUtil.RTrim( Ddo_secfunctionalitydescription_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Filteredtext_get", StringUtil.RTrim( Ddo_secfunctionalitydescription_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Selectedvalue_get", StringUtil.RTrim( Ddo_secfunctionalitydescription_Selectedvalue_get));
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
            WE0H2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0H2( ) ;
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
         return formatLink("wwpbaseobjects.secfunctionalityww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "WWPBaseObjects.SecFunctionalityWW" ;
      }

      public override String GetPgmdesc( )
      {
         return "Work With Functionality" ;
      }

      protected void WB0H0( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroupColoredActions", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            ClassString = "Button ButtonColor";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(36), 2, 0)+","+"null"+");", "新增", bttBtninsert_Jsonclick, 5, "插入", "", StyleString, ClassString, bttBtninsert_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\SecFunctionalityWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavSecfunctionalitykey_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSecfunctionalitykey_Internalname, "名称", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_36_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSecfunctionalitykey_Internalname, AV22SecFunctionalityKey, StringUtil.RTrim( context.localUtil.Format( AV22SecFunctionalityKey, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSecfunctionalitykey_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavSecfunctionalitykey_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecFunctionalityWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavSecfunctionalitydescription_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSecfunctionalitydescription_Internalname, "描述", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'" + sGXsfl_36_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSecfunctionalitydescription_Internalname, AV10SecFunctionalityDescription, StringUtil.RTrim( context.localUtil.Format( AV10SecFunctionalityDescription, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSecfunctionalitydescription_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavSecfunctionalitydescription_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecFunctionalityWW.htm");
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"36\">") ;
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+edtavUaviewchildren_Class+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "编号") ;
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "类型") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "父功能编号  ") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "父功能") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"AttributeCheckBox"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "是否启用？") ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV89Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV11Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV12Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV91FuncAssociateRole));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavFuncassociaterole_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavFuncassociaterole_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV24UAViewChildren));
               GridColumn.AddObjectProperty("Class", StringUtil.RTrim( edtavUaviewchildren_Class));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUaviewchildren_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUaviewchildren_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SecFunctionalityId), 10, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A3SecFunctionalityKey);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtSecFunctionalityKey_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSecFunctionalityKey_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A8SecFunctionalityDescription);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtSecFunctionalityDescription_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSecFunctionalityDescription_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtSecFunctionalityDescription_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A9SecFunctionalityType), 2, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A2SecParentFunctionalityId), 10, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A11SecParentFunctionalityDescription);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.BoolToStr( A7SecFunctionalityActive));
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
         if ( wbEnd == 36 )
         {
            wbEnd = 0;
            nRC_GXsfl_36 = (short)(nGXsfl_36_idx-1);
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV85GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV88GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV87GridPageSize);
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
            ucDdo_secfunctionalitykey.SetProperty("DropDownOptionsTitleSettingsIcons", AV55DDO_TitleSettingsIcons);
            ucDdo_secfunctionalitykey.SetProperty("DropDownOptionsData", AV40SecFunctionalityKeyTitleFilterData);
            ucDdo_secfunctionalitykey.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_secfunctionalitykey_Internalname, "DDO_SECFUNCTIONALITYKEYContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'" + sGXsfl_36_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_secfunctionalitykeytitlecontrolidtoreplace_Internalname, AV43ddo_SecFunctionalityKeyTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", 0, edtavDdo_secfunctionalitykeytitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WWPBaseObjects\\SecFunctionalityWW.htm");
            /* User Defined Control */
            ucDdo_secfunctionalitydescription.SetProperty("Caption", Ddo_secfunctionalitydescription_Caption);
            ucDdo_secfunctionalitydescription.SetProperty("Tooltip", Ddo_secfunctionalitydescription_Tooltip);
            ucDdo_secfunctionalitydescription.SetProperty("Cls", Ddo_secfunctionalitydescription_Cls);
            ucDdo_secfunctionalitydescription.SetProperty("DropDownOptionsType", Ddo_secfunctionalitydescription_Dropdownoptionstype);
            ucDdo_secfunctionalitydescription.SetProperty("IncludeSortASC", Ddo_secfunctionalitydescription_Includesortasc);
            ucDdo_secfunctionalitydescription.SetProperty("IncludeSortDSC", Ddo_secfunctionalitydescription_Includesortdsc);
            ucDdo_secfunctionalitydescription.SetProperty("IncludeFilter", Ddo_secfunctionalitydescription_Includefilter);
            ucDdo_secfunctionalitydescription.SetProperty("FilterType", Ddo_secfunctionalitydescription_Filtertype);
            ucDdo_secfunctionalitydescription.SetProperty("FilterIsRange", Ddo_secfunctionalitydescription_Filterisrange);
            ucDdo_secfunctionalitydescription.SetProperty("IncludeDataList", Ddo_secfunctionalitydescription_Includedatalist);
            ucDdo_secfunctionalitydescription.SetProperty("DataListType", Ddo_secfunctionalitydescription_Datalisttype);
            ucDdo_secfunctionalitydescription.SetProperty("DataListProc", Ddo_secfunctionalitydescription_Datalistproc);
            ucDdo_secfunctionalitydescription.SetProperty("DataListUpdateMinimumCharacters", Ddo_secfunctionalitydescription_Datalistupdateminimumcharacters);
            ucDdo_secfunctionalitydescription.SetProperty("SortASC", Ddo_secfunctionalitydescription_Sortasc);
            ucDdo_secfunctionalitydescription.SetProperty("SortDSC", Ddo_secfunctionalitydescription_Sortdsc);
            ucDdo_secfunctionalitydescription.SetProperty("LoadingData", Ddo_secfunctionalitydescription_Loadingdata);
            ucDdo_secfunctionalitydescription.SetProperty("CleanFilter", Ddo_secfunctionalitydescription_Cleanfilter);
            ucDdo_secfunctionalitydescription.SetProperty("NoResultsFound", Ddo_secfunctionalitydescription_Noresultsfound);
            ucDdo_secfunctionalitydescription.SetProperty("SearchButtonText", Ddo_secfunctionalitydescription_Searchbuttontext);
            ucDdo_secfunctionalitydescription.SetProperty("DropDownOptionsTitleSettingsIcons", AV55DDO_TitleSettingsIcons);
            ucDdo_secfunctionalitydescription.SetProperty("DropDownOptionsData", AV44SecFunctionalityDescriptionTitleFilterData);
            ucDdo_secfunctionalitydescription.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_secfunctionalitydescription_Internalname, "DDO_SECFUNCTIONALITYDESCRIPTIONContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'" + sGXsfl_36_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_secfunctionalitydescriptiontitlecontrolidtoreplace_Internalname, AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", 0, edtavDdo_secfunctionalitydescriptiontitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WWPBaseObjects\\SecFunctionalityWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'" + sGXsfl_36_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV29OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV29OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,61);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WWPBaseObjects\\SecFunctionalityWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'" + sGXsfl_36_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV30OrderedDsc), StringUtil.BoolToStr( AV30OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,62);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_WWPBaseObjects\\SecFunctionalityWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'" + sGXsfl_36_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfsecfunctionalitykey_Internalname, AV41TFSecFunctionalityKey, StringUtil.RTrim( context.localUtil.Format( AV41TFSecFunctionalityKey, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfsecfunctionalitykey_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfsecfunctionalitykey_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecFunctionalityWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'" + sGXsfl_36_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfsecfunctionalitykey_sel_Internalname, AV42TFSecFunctionalityKey_Sel, StringUtil.RTrim( context.localUtil.Format( AV42TFSecFunctionalityKey_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfsecfunctionalitykey_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfsecfunctionalitykey_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecFunctionalityWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'" + sGXsfl_36_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfsecfunctionalitydescription_Internalname, AV45TFSecFunctionalityDescription, StringUtil.RTrim( context.localUtil.Format( AV45TFSecFunctionalityDescription, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,65);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfsecfunctionalitydescription_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfsecfunctionalitydescription_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecFunctionalityWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_36_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfsecfunctionalitydescription_sel_Internalname, AV46TFSecFunctionalityDescription_Sel, StringUtil.RTrim( context.localUtil.Format( AV46TFSecFunctionalityDescription_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfsecfunctionalitydescription_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfsecfunctionalitydescription_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecFunctionalityWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 36 )
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

      protected void START0H2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "Work With Functionality", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0H0( ) ;
      }

      protected void WS0H2( )
      {
         START0H2( ) ;
         EVT0H2( ) ;
      }

      protected void EVT0H2( )
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
                              E110H2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E120H2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_SECFUNCTIONALITYKEY.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E130H2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_SECFUNCTIONALITYDESCRIPTION.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E140H2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E150H2 ();
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
                              nGXsfl_36_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0");
                              SubsflControlProps_362( ) ;
                              AV89Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV89Display)) ? AV100Display_GXI : context.convertURL( context.PathToRelativeUrl( AV89Display))), !bGXsfl_36_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV89Display), true);
                              AV11Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV11Update)) ? AV101Update_GXI : context.convertURL( context.PathToRelativeUrl( AV11Update))), !bGXsfl_36_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV11Update), true);
                              AV12Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV12Delete)) ? AV102Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV12Delete))), !bGXsfl_36_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV12Delete), true);
                              AV91FuncAssociateRole = cgiGet( edtavFuncassociaterole_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavFuncassociaterole_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV91FuncAssociateRole)) ? AV103Funcassociaterole_GXI : context.convertURL( context.PathToRelativeUrl( AV91FuncAssociateRole))), !bGXsfl_36_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavFuncassociaterole_Internalname, "SrcSet", context.GetImageSrcSet( AV91FuncAssociateRole), true);
                              AV24UAViewChildren = cgiGet( edtavUaviewchildren_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUaviewchildren_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV24UAViewChildren)) ? AV104Uaviewchildren_GXI : context.convertURL( context.PathToRelativeUrl( AV24UAViewChildren))), !bGXsfl_36_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUaviewchildren_Internalname, "SrcSet", context.GetImageSrcSet( AV24UAViewChildren), true);
                              A1SecFunctionalityId = (long)(context.localUtil.CToN( cgiGet( edtSecFunctionalityId_Internalname), ".", ","));
                              A3SecFunctionalityKey = cgiGet( edtSecFunctionalityKey_Internalname);
                              A8SecFunctionalityDescription = cgiGet( edtSecFunctionalityDescription_Internalname);
                              cmbSecFunctionalityType.Name = cmbSecFunctionalityType_Internalname;
                              cmbSecFunctionalityType.CurrentValue = cgiGet( cmbSecFunctionalityType_Internalname);
                              A9SecFunctionalityType = (short)(NumberUtil.Val( cgiGet( cmbSecFunctionalityType_Internalname), "."));
                              A2SecParentFunctionalityId = (long)(context.localUtil.CToN( cgiGet( edtSecParentFunctionalityId_Internalname), ".", ","));
                              n2SecParentFunctionalityId = false;
                              A11SecParentFunctionalityDescription = cgiGet( edtSecParentFunctionalityDescription_Internalname);
                              A7SecFunctionalityActive = StringUtil.StrToBool( cgiGet( chkSecFunctionalityActive_Internalname));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E160H2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E170H2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E180H2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Secfunctionalitykey Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vSECFUNCTIONALITYKEY"), AV22SecFunctionalityKey) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Secfunctionalitydescription Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vSECFUNCTIONALITYDESCRIPTION"), AV10SecFunctionalityDescription) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Orderedby Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV29OrderedBy )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ordereddsc Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV30OrderedDsc )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfsecfunctionalitykey Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFSECFUNCTIONALITYKEY"), AV41TFSecFunctionalityKey) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfsecfunctionalitykey_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFSECFUNCTIONALITYKEY_SEL"), AV42TFSecFunctionalityKey_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfsecfunctionalitydescription Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFSECFUNCTIONALITYDESCRIPTION"), AV45TFSecFunctionalityDescription) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfsecfunctionalitydescription_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFSECFUNCTIONALITYDESCRIPTION_SEL"), AV46TFSecFunctionalityDescription_Sel) != 0 )
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

      protected void WE0H2( )
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

      protected void PA0H2( )
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
               GX_FocusControl = edtavSecfunctionalitykey_Internalname;
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
         SubsflControlProps_362( ) ;
         while ( nGXsfl_36_idx <= nRC_GXsfl_36 )
         {
            sendrow_362( ) ;
            nGXsfl_36_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_36_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_36_idx+1));
            sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0");
            SubsflControlProps_362( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       String AV22SecFunctionalityKey ,
                                       String AV10SecFunctionalityDescription ,
                                       short AV29OrderedBy ,
                                       bool AV30OrderedDsc ,
                                       String AV41TFSecFunctionalityKey ,
                                       String AV42TFSecFunctionalityKey_Sel ,
                                       String AV45TFSecFunctionalityDescription ,
                                       String AV46TFSecFunctionalityDescription_Sel ,
                                       String AV43ddo_SecFunctionalityKeyTitleControlIdToReplace ,
                                       String AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace ,
                                       String AV105Pgmname ,
                                       bool AV18IsAuthorized_Update ,
                                       bool AV19IsAuthorized_Delete )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF0H2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_SECFUNCTIONALITYID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A1SecFunctionalityId), "ZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "SECFUNCTIONALITYID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SecFunctionalityId), 10, 0, ".", "")));
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
         RF0H2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV105Pgmname = "WWPBaseObjects.SecFunctionalityWW";
         context.Gx_err = 0;
      }

      protected void RF0H2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 36;
         /* Execute user event: Refresh */
         E170H2 ();
         nGXsfl_36_idx = 1;
         sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0");
         SubsflControlProps_362( ) ;
         bGXsfl_36_Refreshing = true;
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
            SubsflControlProps_362( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV94WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey ,
                                                 AV95WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription ,
                                                 AV97WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel ,
                                                 AV96WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey ,
                                                 AV99WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel ,
                                                 AV98WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription ,
                                                 A3SecFunctionalityKey ,
                                                 A8SecFunctionalityDescription ,
                                                 AV29OrderedBy ,
                                                 AV30OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV94WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey = StringUtil.Concat( StringUtil.RTrim( AV94WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey), "%", "");
            lV95WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription = StringUtil.Concat( StringUtil.RTrim( AV95WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription), "%", "");
            lV96WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey = StringUtil.Concat( StringUtil.RTrim( AV96WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey), "%", "");
            lV98WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription = StringUtil.Concat( StringUtil.RTrim( AV98WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription), "%", "");
            /* Using cursor H000H2 */
            pr_default.execute(0, new Object[] {lV94WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey, lV95WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription, lV96WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey, AV97WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel, lV98WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription, AV99WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_36_idx = 1;
            sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0");
            SubsflControlProps_362( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A7SecFunctionalityActive = H000H2_A7SecFunctionalityActive[0];
               A11SecParentFunctionalityDescription = H000H2_A11SecParentFunctionalityDescription[0];
               A2SecParentFunctionalityId = H000H2_A2SecParentFunctionalityId[0];
               n2SecParentFunctionalityId = H000H2_n2SecParentFunctionalityId[0];
               A9SecFunctionalityType = H000H2_A9SecFunctionalityType[0];
               A8SecFunctionalityDescription = H000H2_A8SecFunctionalityDescription[0];
               A3SecFunctionalityKey = H000H2_A3SecFunctionalityKey[0];
               A1SecFunctionalityId = H000H2_A1SecFunctionalityId[0];
               A11SecParentFunctionalityDescription = H000H2_A11SecParentFunctionalityDescription[0];
               E180H2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 36;
            WB0H0( ) ;
         }
         bGXsfl_36_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes0H2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_SECFUNCTIONALITYID"+"_"+sGXsfl_36_idx, GetSecureSignedToken( sGXsfl_36_idx, context.localUtil.Format( (decimal)(A1SecFunctionalityId), "ZZZZZZZZZ9"), context));
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
         AV94WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey = AV22SecFunctionalityKey;
         AV95WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription = AV10SecFunctionalityDescription;
         AV96WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey = AV41TFSecFunctionalityKey;
         AV97WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel = AV42TFSecFunctionalityKey_Sel;
         AV98WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription = AV45TFSecFunctionalityDescription;
         AV99WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel = AV46TFSecFunctionalityDescription_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV94WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey ,
                                              AV95WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription ,
                                              AV97WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel ,
                                              AV96WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey ,
                                              AV99WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel ,
                                              AV98WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription ,
                                              A3SecFunctionalityKey ,
                                              A8SecFunctionalityDescription ,
                                              AV29OrderedBy ,
                                              AV30OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV94WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey = StringUtil.Concat( StringUtil.RTrim( AV94WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey), "%", "");
         lV95WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription = StringUtil.Concat( StringUtil.RTrim( AV95WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription), "%", "");
         lV96WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey = StringUtil.Concat( StringUtil.RTrim( AV96WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey), "%", "");
         lV98WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription = StringUtil.Concat( StringUtil.RTrim( AV98WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription), "%", "");
         /* Using cursor H000H3 */
         pr_default.execute(1, new Object[] {lV94WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey, lV95WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription, lV96WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey, AV97WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel, lV98WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription, AV99WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel});
         GRID_nRecordCount = H000H3_AGRID_nRecordCount[0];
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
         AV94WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey = AV22SecFunctionalityKey;
         AV95WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription = AV10SecFunctionalityDescription;
         AV96WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey = AV41TFSecFunctionalityKey;
         AV97WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel = AV42TFSecFunctionalityKey_Sel;
         AV98WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription = AV45TFSecFunctionalityDescription;
         AV99WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel = AV46TFSecFunctionalityDescription_Sel;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV22SecFunctionalityKey, AV10SecFunctionalityDescription, AV29OrderedBy, AV30OrderedDsc, AV41TFSecFunctionalityKey, AV42TFSecFunctionalityKey_Sel, AV45TFSecFunctionalityDescription, AV46TFSecFunctionalityDescription_Sel, AV43ddo_SecFunctionalityKeyTitleControlIdToReplace, AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace, AV105Pgmname, AV18IsAuthorized_Update, AV19IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV94WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey = AV22SecFunctionalityKey;
         AV95WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription = AV10SecFunctionalityDescription;
         AV96WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey = AV41TFSecFunctionalityKey;
         AV97WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel = AV42TFSecFunctionalityKey_Sel;
         AV98WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription = AV45TFSecFunctionalityDescription;
         AV99WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel = AV46TFSecFunctionalityDescription_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV22SecFunctionalityKey, AV10SecFunctionalityDescription, AV29OrderedBy, AV30OrderedDsc, AV41TFSecFunctionalityKey, AV42TFSecFunctionalityKey_Sel, AV45TFSecFunctionalityDescription, AV46TFSecFunctionalityDescription_Sel, AV43ddo_SecFunctionalityKeyTitleControlIdToReplace, AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace, AV105Pgmname, AV18IsAuthorized_Update, AV19IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV94WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey = AV22SecFunctionalityKey;
         AV95WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription = AV10SecFunctionalityDescription;
         AV96WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey = AV41TFSecFunctionalityKey;
         AV97WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel = AV42TFSecFunctionalityKey_Sel;
         AV98WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription = AV45TFSecFunctionalityDescription;
         AV99WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel = AV46TFSecFunctionalityDescription_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV22SecFunctionalityKey, AV10SecFunctionalityDescription, AV29OrderedBy, AV30OrderedDsc, AV41TFSecFunctionalityKey, AV42TFSecFunctionalityKey_Sel, AV45TFSecFunctionalityDescription, AV46TFSecFunctionalityDescription_Sel, AV43ddo_SecFunctionalityKeyTitleControlIdToReplace, AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace, AV105Pgmname, AV18IsAuthorized_Update, AV19IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV94WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey = AV22SecFunctionalityKey;
         AV95WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription = AV10SecFunctionalityDescription;
         AV96WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey = AV41TFSecFunctionalityKey;
         AV97WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel = AV42TFSecFunctionalityKey_Sel;
         AV98WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription = AV45TFSecFunctionalityDescription;
         AV99WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel = AV46TFSecFunctionalityDescription_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV22SecFunctionalityKey, AV10SecFunctionalityDescription, AV29OrderedBy, AV30OrderedDsc, AV41TFSecFunctionalityKey, AV42TFSecFunctionalityKey_Sel, AV45TFSecFunctionalityDescription, AV46TFSecFunctionalityDescription_Sel, AV43ddo_SecFunctionalityKeyTitleControlIdToReplace, AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace, AV105Pgmname, AV18IsAuthorized_Update, AV19IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV94WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey = AV22SecFunctionalityKey;
         AV95WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription = AV10SecFunctionalityDescription;
         AV96WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey = AV41TFSecFunctionalityKey;
         AV97WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel = AV42TFSecFunctionalityKey_Sel;
         AV98WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription = AV45TFSecFunctionalityDescription;
         AV99WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel = AV46TFSecFunctionalityDescription_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV22SecFunctionalityKey, AV10SecFunctionalityDescription, AV29OrderedBy, AV30OrderedDsc, AV41TFSecFunctionalityKey, AV42TFSecFunctionalityKey_Sel, AV45TFSecFunctionalityDescription, AV46TFSecFunctionalityDescription_Sel, AV43ddo_SecFunctionalityKeyTitleControlIdToReplace, AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace, AV105Pgmname, AV18IsAuthorized_Update, AV19IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP0H0( )
      {
         /* Before Start, stand alone formulas. */
         AV105Pgmname = "WWPBaseObjects.SecFunctionalityWW";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E160H2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV55DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vSECFUNCTIONALITYKEYTITLEFILTERDATA"), AV40SecFunctionalityKeyTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA"), AV44SecFunctionalityDescriptionTitleFilterData);
            /* Read variables values. */
            AV22SecFunctionalityKey = cgiGet( edtavSecfunctionalitykey_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22SecFunctionalityKey", AV22SecFunctionalityKey);
            AV10SecFunctionalityDescription = cgiGet( edtavSecfunctionalitydescription_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10SecFunctionalityDescription", AV10SecFunctionalityDescription);
            AV43ddo_SecFunctionalityKeyTitleControlIdToReplace = cgiGet( edtavDdo_secfunctionalitykeytitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43ddo_SecFunctionalityKeyTitleControlIdToReplace", AV43ddo_SecFunctionalityKeyTitleControlIdToReplace);
            AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace = cgiGet( edtavDdo_secfunctionalitydescriptiontitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace", AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDEREDBY");
               GX_FocusControl = edtavOrderedby_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV29OrderedBy = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29OrderedBy), 4, 0)));
            }
            else
            {
               AV29OrderedBy = (short)(context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29OrderedBy), 4, 0)));
            }
            AV30OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30OrderedDsc", AV30OrderedDsc);
            AV41TFSecFunctionalityKey = cgiGet( edtavTfsecfunctionalitykey_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41TFSecFunctionalityKey", AV41TFSecFunctionalityKey);
            AV42TFSecFunctionalityKey_Sel = cgiGet( edtavTfsecfunctionalitykey_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42TFSecFunctionalityKey_Sel", AV42TFSecFunctionalityKey_Sel);
            AV45TFSecFunctionalityDescription = cgiGet( edtavTfsecfunctionalitydescription_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45TFSecFunctionalityDescription", AV45TFSecFunctionalityDescription);
            AV46TFSecFunctionalityDescription_Sel = cgiGet( edtavTfsecfunctionalitydescription_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46TFSecFunctionalityDescription_Sel", AV46TFSecFunctionalityDescription_Sel);
            /* Read saved values. */
            nRC_GXsfl_36 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_36"), ".", ","));
            AV85GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV88GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV87GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_secfunctionalitykey_Caption = cgiGet( "DDO_SECFUNCTIONALITYKEY_Caption");
            Ddo_secfunctionalitykey_Tooltip = cgiGet( "DDO_SECFUNCTIONALITYKEY_Tooltip");
            Ddo_secfunctionalitykey_Cls = cgiGet( "DDO_SECFUNCTIONALITYKEY_Cls");
            Ddo_secfunctionalitykey_Filteredtext_set = cgiGet( "DDO_SECFUNCTIONALITYKEY_Filteredtext_set");
            Ddo_secfunctionalitykey_Selectedvalue_set = cgiGet( "DDO_SECFUNCTIONALITYKEY_Selectedvalue_set");
            Ddo_secfunctionalitykey_Dropdownoptionstype = cgiGet( "DDO_SECFUNCTIONALITYKEY_Dropdownoptionstype");
            Ddo_secfunctionalitykey_Titlecontrolidtoreplace = cgiGet( "DDO_SECFUNCTIONALITYKEY_Titlecontrolidtoreplace");
            Ddo_secfunctionalitykey_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_SECFUNCTIONALITYKEY_Includesortasc"));
            Ddo_secfunctionalitykey_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_SECFUNCTIONALITYKEY_Includesortdsc"));
            Ddo_secfunctionalitykey_Sortedstatus = cgiGet( "DDO_SECFUNCTIONALITYKEY_Sortedstatus");
            Ddo_secfunctionalitykey_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_SECFUNCTIONALITYKEY_Includefilter"));
            Ddo_secfunctionalitykey_Filtertype = cgiGet( "DDO_SECFUNCTIONALITYKEY_Filtertype");
            Ddo_secfunctionalitykey_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_SECFUNCTIONALITYKEY_Filterisrange"));
            Ddo_secfunctionalitykey_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_SECFUNCTIONALITYKEY_Includedatalist"));
            Ddo_secfunctionalitykey_Datalisttype = cgiGet( "DDO_SECFUNCTIONALITYKEY_Datalisttype");
            Ddo_secfunctionalitykey_Datalistproc = cgiGet( "DDO_SECFUNCTIONALITYKEY_Datalistproc");
            Ddo_secfunctionalitykey_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_SECFUNCTIONALITYKEY_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_secfunctionalitykey_Sortasc = cgiGet( "DDO_SECFUNCTIONALITYKEY_Sortasc");
            Ddo_secfunctionalitykey_Sortdsc = cgiGet( "DDO_SECFUNCTIONALITYKEY_Sortdsc");
            Ddo_secfunctionalitykey_Loadingdata = cgiGet( "DDO_SECFUNCTIONALITYKEY_Loadingdata");
            Ddo_secfunctionalitykey_Cleanfilter = cgiGet( "DDO_SECFUNCTIONALITYKEY_Cleanfilter");
            Ddo_secfunctionalitykey_Noresultsfound = cgiGet( "DDO_SECFUNCTIONALITYKEY_Noresultsfound");
            Ddo_secfunctionalitykey_Searchbuttontext = cgiGet( "DDO_SECFUNCTIONALITYKEY_Searchbuttontext");
            Ddo_secfunctionalitydescription_Caption = cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Caption");
            Ddo_secfunctionalitydescription_Tooltip = cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Tooltip");
            Ddo_secfunctionalitydescription_Cls = cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Cls");
            Ddo_secfunctionalitydescription_Filteredtext_set = cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Filteredtext_set");
            Ddo_secfunctionalitydescription_Selectedvalue_set = cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Selectedvalue_set");
            Ddo_secfunctionalitydescription_Dropdownoptionstype = cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Dropdownoptionstype");
            Ddo_secfunctionalitydescription_Titlecontrolidtoreplace = cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Titlecontrolidtoreplace");
            Ddo_secfunctionalitydescription_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Includesortasc"));
            Ddo_secfunctionalitydescription_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Includesortdsc"));
            Ddo_secfunctionalitydescription_Sortedstatus = cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Sortedstatus");
            Ddo_secfunctionalitydescription_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Includefilter"));
            Ddo_secfunctionalitydescription_Filtertype = cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Filtertype");
            Ddo_secfunctionalitydescription_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Filterisrange"));
            Ddo_secfunctionalitydescription_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Includedatalist"));
            Ddo_secfunctionalitydescription_Datalisttype = cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Datalisttype");
            Ddo_secfunctionalitydescription_Datalistproc = cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Datalistproc");
            Ddo_secfunctionalitydescription_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_secfunctionalitydescription_Sortasc = cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Sortasc");
            Ddo_secfunctionalitydescription_Sortdsc = cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Sortdsc");
            Ddo_secfunctionalitydescription_Loadingdata = cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Loadingdata");
            Ddo_secfunctionalitydescription_Cleanfilter = cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Cleanfilter");
            Ddo_secfunctionalitydescription_Noresultsfound = cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Noresultsfound");
            Ddo_secfunctionalitydescription_Searchbuttontext = cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_secfunctionalitykey_Activeeventkey = cgiGet( "DDO_SECFUNCTIONALITYKEY_Activeeventkey");
            Ddo_secfunctionalitykey_Filteredtext_get = cgiGet( "DDO_SECFUNCTIONALITYKEY_Filteredtext_get");
            Ddo_secfunctionalitykey_Selectedvalue_get = cgiGet( "DDO_SECFUNCTIONALITYKEY_Selectedvalue_get");
            Ddo_secfunctionalitydescription_Activeeventkey = cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Activeeventkey");
            Ddo_secfunctionalitydescription_Filteredtext_get = cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Filteredtext_get");
            Ddo_secfunctionalitydescription_Selectedvalue_get = cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Selectedvalue_get");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( StringUtil.StrCmp(cgiGet( "GXH_vSECFUNCTIONALITYKEY"), AV22SecFunctionalityKey) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vSECFUNCTIONALITYDESCRIPTION"), AV10SecFunctionalityDescription) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV29OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV30OrderedDsc )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFSECFUNCTIONALITYKEY"), AV41TFSecFunctionalityKey) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFSECFUNCTIONALITYKEY_SEL"), AV42TFSecFunctionalityKey_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFSECFUNCTIONALITYDESCRIPTION"), AV45TFSecFunctionalityDescription) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFSECFUNCTIONALITYDESCRIPTION_SEL"), AV46TFSecFunctionalityDescription_Sel) != 0 )
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
         E160H2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E160H2( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         edtavTfsecfunctionalitykey_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfsecfunctionalitykey_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfsecfunctionalitykey_Visible), 5, 0)), true);
         edtavTfsecfunctionalitykey_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfsecfunctionalitykey_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfsecfunctionalitykey_sel_Visible), 5, 0)), true);
         edtavTfsecfunctionalitydescription_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfsecfunctionalitydescription_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfsecfunctionalitydescription_Visible), 5, 0)), true);
         edtavTfsecfunctionalitydescription_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfsecfunctionalitydescription_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfsecfunctionalitydescription_sel_Visible), 5, 0)), true);
         Ddo_secfunctionalitykey_Titlecontrolidtoreplace = subGrid_Internalname+"_SecFunctionalityKey";
         ucDdo_secfunctionalitykey.SendProperty(context, "", false, Ddo_secfunctionalitykey_Internalname, "TitleControlIdToReplace", Ddo_secfunctionalitykey_Titlecontrolidtoreplace);
         AV43ddo_SecFunctionalityKeyTitleControlIdToReplace = Ddo_secfunctionalitykey_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43ddo_SecFunctionalityKeyTitleControlIdToReplace", AV43ddo_SecFunctionalityKeyTitleControlIdToReplace);
         edtavDdo_secfunctionalitykeytitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_secfunctionalitykeytitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_secfunctionalitykeytitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_secfunctionalitydescription_Titlecontrolidtoreplace = subGrid_Internalname+"_SecFunctionalityDescription";
         ucDdo_secfunctionalitydescription.SendProperty(context, "", false, Ddo_secfunctionalitydescription_Internalname, "TitleControlIdToReplace", Ddo_secfunctionalitydescription_Titlecontrolidtoreplace);
         AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace = Ddo_secfunctionalitydescription_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace", AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace);
         edtavDdo_secfunctionalitydescriptiontitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_secfunctionalitydescriptiontitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_secfunctionalitydescriptiontitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "权限";
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
         if ( AV29OrderedBy < 1 )
         {
            AV29OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29OrderedBy), 4, 0)));
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV55DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV55DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E170H2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV40SecFunctionalityKeyTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV44SecFunctionalityDescriptionTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV81WWPContext) ;
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
         edtSecFunctionalityKey_Titleformat = 2;
         edtSecFunctionalityKey_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "权限名称", AV43ddo_SecFunctionalityKeyTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecFunctionalityKey_Internalname, "Title", edtSecFunctionalityKey_Title, !bGXsfl_36_Refreshing);
         edtSecFunctionalityDescription_Titleformat = 2;
         edtSecFunctionalityDescription_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "权限描述", AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecFunctionalityDescription_Internalname, "Title", edtSecFunctionalityDescription_Title, !bGXsfl_36_Refreshing);
         AV85GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV85GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV85GridCurrentPage), 10, 0)));
         AV87GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV87GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV87GridPageSize), 10, 0)));
         AV88GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV88GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV88GridRecordCount), 10, 0)));
         AV94WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey = AV22SecFunctionalityKey;
         AV95WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription = AV10SecFunctionalityDescription;
         AV96WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey = AV41TFSecFunctionalityKey;
         AV97WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel = AV42TFSecFunctionalityKey_Sel;
         AV98WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription = AV45TFSecFunctionalityDescription;
         AV99WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel = AV46TFSecFunctionalityDescription_Sel;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40SecFunctionalityKeyTitleFilterData", AV40SecFunctionalityKeyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44SecFunctionalityDescriptionTitleFilterData", AV44SecFunctionalityDescriptionTitleFilterData);
      }

      protected void E110H2( )
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
            AV84PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV84PageToGo) ;
         }
      }

      protected void E120H2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E130H2( )
      {
         /* Ddo_secfunctionalitykey_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_secfunctionalitykey_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV29OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29OrderedBy), 4, 0)));
            AV30OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30OrderedDsc", AV30OrderedDsc);
            Ddo_secfunctionalitykey_Sortedstatus = "ASC";
            ucDdo_secfunctionalitykey.SendProperty(context, "", false, Ddo_secfunctionalitykey_Internalname, "SortedStatus", Ddo_secfunctionalitykey_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_secfunctionalitykey_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV29OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29OrderedBy), 4, 0)));
            AV30OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30OrderedDsc", AV30OrderedDsc);
            Ddo_secfunctionalitykey_Sortedstatus = "DSC";
            ucDdo_secfunctionalitykey.SendProperty(context, "", false, Ddo_secfunctionalitykey_Internalname, "SortedStatus", Ddo_secfunctionalitykey_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_secfunctionalitykey_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV41TFSecFunctionalityKey = Ddo_secfunctionalitykey_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41TFSecFunctionalityKey", AV41TFSecFunctionalityKey);
            AV42TFSecFunctionalityKey_Sel = Ddo_secfunctionalitykey_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42TFSecFunctionalityKey_Sel", AV42TFSecFunctionalityKey_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40SecFunctionalityKeyTitleFilterData", AV40SecFunctionalityKeyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44SecFunctionalityDescriptionTitleFilterData", AV44SecFunctionalityDescriptionTitleFilterData);
      }

      protected void E140H2( )
      {
         /* Ddo_secfunctionalitydescription_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_secfunctionalitydescription_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV29OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29OrderedBy), 4, 0)));
            AV30OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30OrderedDsc", AV30OrderedDsc);
            Ddo_secfunctionalitydescription_Sortedstatus = "ASC";
            ucDdo_secfunctionalitydescription.SendProperty(context, "", false, Ddo_secfunctionalitydescription_Internalname, "SortedStatus", Ddo_secfunctionalitydescription_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_secfunctionalitydescription_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV29OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29OrderedBy), 4, 0)));
            AV30OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30OrderedDsc", AV30OrderedDsc);
            Ddo_secfunctionalitydescription_Sortedstatus = "DSC";
            ucDdo_secfunctionalitydescription.SendProperty(context, "", false, Ddo_secfunctionalitydescription_Internalname, "SortedStatus", Ddo_secfunctionalitydescription_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_secfunctionalitydescription_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV45TFSecFunctionalityDescription = Ddo_secfunctionalitydescription_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45TFSecFunctionalityDescription", AV45TFSecFunctionalityDescription);
            AV46TFSecFunctionalityDescription_Sel = Ddo_secfunctionalitydescription_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46TFSecFunctionalityDescription_Sel", AV46TFSecFunctionalityDescription_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40SecFunctionalityKeyTitleFilterData", AV40SecFunctionalityKeyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44SecFunctionalityDescriptionTitleFilterData", AV44SecFunctionalityDescriptionTitleFilterData);
      }

      private void E180H2( )
      {
         /* Grid_Load Routine */
         AV89Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDisplay_Internalname, AV89Display);
         AV100Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = formatLink("wwpbaseobjects.secfunctionalityview.aspx") + "?" + UrlEncode("" +A1SecFunctionalityId) + "," + UrlEncode(StringUtil.RTrim(""));
         AV11Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV11Update);
         AV101Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavUpdate_Tooltiptext = "修改";
         if ( AV18IsAuthorized_Update )
         {
            edtavUpdate_Link = formatLink("wwpbaseobjects.secfunctionality.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A1SecFunctionalityId);
         }
         AV12Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV12Delete);
         AV102Delete_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavDelete_Tooltiptext = "删除";
         if ( AV19IsAuthorized_Delete )
         {
            edtavDelete_Link = formatLink("wwpbaseobjects.secfunctionality.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A1SecFunctionalityId);
         }
         AV91FuncAssociateRole = context.GetImagePath( "f7e96486-9f52-4b0c-b02e-ed623d2a7b90", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavFuncassociaterole_Internalname, AV91FuncAssociateRole);
         AV103Funcassociaterole_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f7e96486-9f52-4b0c-b02e-ed623d2a7b90", "", context.GetTheme( )));
         edtavFuncassociaterole_Tooltiptext = "";
         edtavFuncassociaterole_Link = formatLink("wwpbaseobjects.secfunctionalitysecfunctionalityroleassociation.aspx") + "?" + UrlEncode("" +A1SecFunctionalityId);
         AV24UAViewChildren = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUaviewchildren_Internalname, AV24UAViewChildren);
         AV104Uaviewchildren_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavUaviewchildren_Tooltiptext = "View Actions, Tabs and Modes";
         GXt_boolean2 = AV15TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secfunctionalityhaschildren(context ).execute(  A1SecFunctionalityId, out  GXt_boolean2) ;
         AV15TempBoolean = GXt_boolean2;
         if ( AV15TempBoolean )
         {
            edtavUaviewchildren_Link = formatLink("wwpbaseobjects.secfunctionalityfilterparentww.aspx") + "?" + UrlEncode("" +A1SecFunctionalityId);
            edtavUaviewchildren_Class = "ActionBaseColorAttribute";
         }
         else
         {
            edtavUaviewchildren_Link = "";
            edtavUaviewchildren_Class = "Invisible";
         }
         edtSecFunctionalityDescription_Link = formatLink("wwpbaseobjects.secfunctionalityview.aspx") + "?" + UrlEncode("" +A1SecFunctionalityId) + "," + UrlEncode(StringUtil.RTrim(""));
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 36;
         }
         sendrow_362( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_36_Refreshing )
         {
            context.DoAjaxLoad(36, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void E150H2( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("wwpbaseobjects.secfunctionality.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S162( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_secfunctionalitykey_Sortedstatus = "";
         ucDdo_secfunctionalitykey.SendProperty(context, "", false, Ddo_secfunctionalitykey_Internalname, "SortedStatus", Ddo_secfunctionalitykey_Sortedstatus);
         Ddo_secfunctionalitydescription_Sortedstatus = "";
         ucDdo_secfunctionalitydescription.SendProperty(context, "", false, Ddo_secfunctionalitydescription_Internalname, "SortedStatus", Ddo_secfunctionalitydescription_Sortedstatus);
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
         if ( AV29OrderedBy == 1 )
         {
            Ddo_secfunctionalitykey_Sortedstatus = (AV30OrderedDsc ? "DSC" : "ASC");
            ucDdo_secfunctionalitykey.SendProperty(context, "", false, Ddo_secfunctionalitykey_Internalname, "SortedStatus", Ddo_secfunctionalitykey_Sortedstatus);
         }
         else if ( AV29OrderedBy == 2 )
         {
            Ddo_secfunctionalitydescription_Sortedstatus = (AV30OrderedDsc ? "DSC" : "ASC");
            ucDdo_secfunctionalitydescription.SendProperty(context, "", false, Ddo_secfunctionalitydescription_Internalname, "SortedStatus", Ddo_secfunctionalitydescription_Sortedstatus);
         }
      }

      protected void S142( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean2 = AV18IsAuthorized_Update;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWFunctionality", out  GXt_boolean2) ;
         AV18IsAuthorized_Update = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18IsAuthorized_Update", AV18IsAuthorized_Update);
         if ( ! ( AV18IsAuthorized_Update ) )
         {
            edtavUpdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_36_Refreshing);
         }
         GXt_boolean2 = AV19IsAuthorized_Delete;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWFunctionality", out  GXt_boolean2) ;
         AV19IsAuthorized_Delete = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19IsAuthorized_Delete", AV19IsAuthorized_Delete);
         if ( ! ( AV19IsAuthorized_Delete ) )
         {
            edtavDelete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Visible), 5, 0)), !bGXsfl_36_Refreshing);
         }
         GXt_boolean2 = AV15TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWFunctionality", out  GXt_boolean2) ;
         AV15TempBoolean = GXt_boolean2;
         if ( ! ( AV15TempBoolean ) )
         {
            bttBtninsert_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtninsert_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtninsert_Visible), 5, 0)), true);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV13Session.Get(AV105Pgmname+"GridState"), "") == 0 )
         {
            AV27GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV105Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV27GridState.FromXml(AV13Session.Get(AV105Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV29OrderedBy = AV27GridState.gxTpr_Orderedby;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29OrderedBy), 4, 0)));
         AV30OrderedDsc = AV27GridState.gxTpr_Ordereddsc;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30OrderedDsc", AV30OrderedDsc);
         /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV106GXV1 = 1;
         while ( AV106GXV1 <= AV27GridState.gxTpr_Filtervalues.Count )
         {
            AV28GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV27GridState.gxTpr_Filtervalues.Item(AV106GXV1));
            if ( StringUtil.StrCmp(AV28GridStateFilterValue.gxTpr_Name, "SECFUNCTIONALITYKEY") == 0 )
            {
               AV22SecFunctionalityKey = AV28GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22SecFunctionalityKey", AV22SecFunctionalityKey);
            }
            else if ( StringUtil.StrCmp(AV28GridStateFilterValue.gxTpr_Name, "SECFUNCTIONALITYDESCRIPTION") == 0 )
            {
               AV10SecFunctionalityDescription = AV28GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10SecFunctionalityDescription", AV10SecFunctionalityDescription);
            }
            else if ( StringUtil.StrCmp(AV28GridStateFilterValue.gxTpr_Name, "TFSECFUNCTIONALITYKEY") == 0 )
            {
               AV41TFSecFunctionalityKey = AV28GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41TFSecFunctionalityKey", AV41TFSecFunctionalityKey);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV41TFSecFunctionalityKey)) )
               {
                  Ddo_secfunctionalitykey_Filteredtext_set = AV41TFSecFunctionalityKey;
                  ucDdo_secfunctionalitykey.SendProperty(context, "", false, Ddo_secfunctionalitykey_Internalname, "FilteredText_set", Ddo_secfunctionalitykey_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV28GridStateFilterValue.gxTpr_Name, "TFSECFUNCTIONALITYKEY_SEL") == 0 )
            {
               AV42TFSecFunctionalityKey_Sel = AV28GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42TFSecFunctionalityKey_Sel", AV42TFSecFunctionalityKey_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV42TFSecFunctionalityKey_Sel)) )
               {
                  Ddo_secfunctionalitykey_Selectedvalue_set = AV42TFSecFunctionalityKey_Sel;
                  ucDdo_secfunctionalitykey.SendProperty(context, "", false, Ddo_secfunctionalitykey_Internalname, "SelectedValue_set", Ddo_secfunctionalitykey_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV28GridStateFilterValue.gxTpr_Name, "TFSECFUNCTIONALITYDESCRIPTION") == 0 )
            {
               AV45TFSecFunctionalityDescription = AV28GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45TFSecFunctionalityDescription", AV45TFSecFunctionalityDescription);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV45TFSecFunctionalityDescription)) )
               {
                  Ddo_secfunctionalitydescription_Filteredtext_set = AV45TFSecFunctionalityDescription;
                  ucDdo_secfunctionalitydescription.SendProperty(context, "", false, Ddo_secfunctionalitydescription_Internalname, "FilteredText_set", Ddo_secfunctionalitydescription_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV28GridStateFilterValue.gxTpr_Name, "TFSECFUNCTIONALITYDESCRIPTION_SEL") == 0 )
            {
               AV46TFSecFunctionalityDescription_Sel = AV28GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46TFSecFunctionalityDescription_Sel", AV46TFSecFunctionalityDescription_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV46TFSecFunctionalityDescription_Sel)) )
               {
                  Ddo_secfunctionalitydescription_Selectedvalue_set = AV46TFSecFunctionalityDescription_Sel;
                  ucDdo_secfunctionalitydescription.SendProperty(context, "", false, Ddo_secfunctionalitydescription_Internalname, "SelectedValue_set", Ddo_secfunctionalitydescription_Selectedvalue_set);
               }
            }
            AV106GXV1 = (int)(AV106GXV1+1);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV27GridState.gxTpr_Pagesize))) )
         {
            subGrid_Rows = (int)(NumberUtil.Val( AV27GridState.gxTpr_Pagesize, "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         }
         subgrid_gotopage( AV27GridState.gxTpr_Currentpage) ;
      }

      protected void S152( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV27GridState.FromXml(AV13Session.Get(AV105Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV27GridState.gxTpr_Orderedby = AV29OrderedBy;
         AV27GridState.gxTpr_Ordereddsc = AV30OrderedDsc;
         AV27GridState.gxTpr_Filtervalues.Clear();
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV22SecFunctionalityKey)) )
         {
            AV28GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV28GridStateFilterValue.gxTpr_Name = "SECFUNCTIONALITYKEY";
            AV28GridStateFilterValue.gxTpr_Value = AV22SecFunctionalityKey;
            AV27GridState.gxTpr_Filtervalues.Add(AV28GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10SecFunctionalityDescription)) )
         {
            AV28GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV28GridStateFilterValue.gxTpr_Name = "SECFUNCTIONALITYDESCRIPTION";
            AV28GridStateFilterValue.gxTpr_Value = AV10SecFunctionalityDescription;
            AV27GridState.gxTpr_Filtervalues.Add(AV28GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV41TFSecFunctionalityKey)) )
         {
            AV28GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV28GridStateFilterValue.gxTpr_Name = "TFSECFUNCTIONALITYKEY";
            AV28GridStateFilterValue.gxTpr_Value = AV41TFSecFunctionalityKey;
            AV27GridState.gxTpr_Filtervalues.Add(AV28GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV42TFSecFunctionalityKey_Sel)) )
         {
            AV28GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV28GridStateFilterValue.gxTpr_Name = "TFSECFUNCTIONALITYKEY_SEL";
            AV28GridStateFilterValue.gxTpr_Value = AV42TFSecFunctionalityKey_Sel;
            AV27GridState.gxTpr_Filtervalues.Add(AV28GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV45TFSecFunctionalityDescription)) )
         {
            AV28GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV28GridStateFilterValue.gxTpr_Name = "TFSECFUNCTIONALITYDESCRIPTION";
            AV28GridStateFilterValue.gxTpr_Value = AV45TFSecFunctionalityDescription;
            AV27GridState.gxTpr_Filtervalues.Add(AV28GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV46TFSecFunctionalityDescription_Sel)) )
         {
            AV28GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV28GridStateFilterValue.gxTpr_Name = "TFSECFUNCTIONALITYDESCRIPTION_SEL";
            AV28GridStateFilterValue.gxTpr_Value = AV46TFSecFunctionalityDescription_Sel;
            AV27GridState.gxTpr_Filtervalues.Add(AV28GridStateFilterValue, 0);
         }
         AV27GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV27GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV105Pgmname+"GridState",  AV27GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV8TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV8TrnContext.gxTpr_Callerobject = AV105Pgmname;
         AV8TrnContext.gxTpr_Callerondelete = true;
         AV8TrnContext.gxTpr_Callerurl = AV7HTTPRequest.ScriptName+"?"+AV7HTTPRequest.QueryString;
         AV8TrnContext.gxTpr_Transactionname = "WWPBaseObjects.SecFunctionality";
         AV13Session.Set("TrnContext", AV8TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
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
         PA0H2( ) ;
         WS0H2( ) ;
         WE0H2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279391676", true);
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
         context.AddJavascriptSource("wwpbaseobjects/secfunctionalityww.js", "?20202279391676", false);
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

      protected void SubsflControlProps_362( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_36_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_36_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_36_idx;
         edtavFuncassociaterole_Internalname = "vFUNCASSOCIATEROLE_"+sGXsfl_36_idx;
         edtavUaviewchildren_Internalname = "vUAVIEWCHILDREN_"+sGXsfl_36_idx;
         edtSecFunctionalityId_Internalname = "SECFUNCTIONALITYID_"+sGXsfl_36_idx;
         edtSecFunctionalityKey_Internalname = "SECFUNCTIONALITYKEY_"+sGXsfl_36_idx;
         edtSecFunctionalityDescription_Internalname = "SECFUNCTIONALITYDESCRIPTION_"+sGXsfl_36_idx;
         cmbSecFunctionalityType_Internalname = "SECFUNCTIONALITYTYPE_"+sGXsfl_36_idx;
         edtSecParentFunctionalityId_Internalname = "SECPARENTFUNCTIONALITYID_"+sGXsfl_36_idx;
         edtSecParentFunctionalityDescription_Internalname = "SECPARENTFUNCTIONALITYDESCRIPTION_"+sGXsfl_36_idx;
         chkSecFunctionalityActive_Internalname = "SECFUNCTIONALITYACTIVE_"+sGXsfl_36_idx;
      }

      protected void SubsflControlProps_fel_362( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_36_fel_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_36_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_36_fel_idx;
         edtavFuncassociaterole_Internalname = "vFUNCASSOCIATEROLE_"+sGXsfl_36_fel_idx;
         edtavUaviewchildren_Internalname = "vUAVIEWCHILDREN_"+sGXsfl_36_fel_idx;
         edtSecFunctionalityId_Internalname = "SECFUNCTIONALITYID_"+sGXsfl_36_fel_idx;
         edtSecFunctionalityKey_Internalname = "SECFUNCTIONALITYKEY_"+sGXsfl_36_fel_idx;
         edtSecFunctionalityDescription_Internalname = "SECFUNCTIONALITYDESCRIPTION_"+sGXsfl_36_fel_idx;
         cmbSecFunctionalityType_Internalname = "SECFUNCTIONALITYTYPE_"+sGXsfl_36_fel_idx;
         edtSecParentFunctionalityId_Internalname = "SECPARENTFUNCTIONALITYID_"+sGXsfl_36_fel_idx;
         edtSecParentFunctionalityDescription_Internalname = "SECPARENTFUNCTIONALITYDESCRIPTION_"+sGXsfl_36_fel_idx;
         chkSecFunctionalityActive_Internalname = "SECFUNCTIONALITYACTIVE_"+sGXsfl_36_fel_idx;
      }

      protected void sendrow_362( )
      {
         SubsflControlProps_362( ) ;
         WB0H0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_36_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_36_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_36_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV89Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV89Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV100Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV89Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV89Display)) ? AV100Display_GXI : context.PathToRelativeUrl( AV89Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV89Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV11Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV11Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV101Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV11Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV11Update)) ? AV101Update_GXI : context.PathToRelativeUrl( AV11Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavUpdate_Visible,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV11Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "DeleteAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV12Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV12Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV102Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV12Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV12Delete)) ? AV102Delete_GXI : context.PathToRelativeUrl( AV12Delete));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)edtavDelete_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavDelete_Visible,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV12Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV91FuncAssociateRole_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV91FuncAssociateRole))&&String.IsNullOrEmpty(StringUtil.RTrim( AV103Funcassociaterole_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV91FuncAssociateRole)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV91FuncAssociateRole)) ? AV103Funcassociaterole_GXI : context.PathToRelativeUrl( AV91FuncAssociateRole));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavFuncassociaterole_Internalname,(String)sImgUrl,(String)edtavFuncassociaterole_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavFuncassociaterole_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV91FuncAssociateRole_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = edtavUaviewchildren_Class;
            StyleString = "";
            AV24UAViewChildren_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV24UAViewChildren))&&String.IsNullOrEmpty(StringUtil.RTrim( AV104Uaviewchildren_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV24UAViewChildren)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV24UAViewChildren)) ? AV104Uaviewchildren_GXI : context.PathToRelativeUrl( AV24UAViewChildren));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUaviewchildren_Internalname,(String)sImgUrl,(String)edtavUaviewchildren_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavUaviewchildren_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV24UAViewChildren_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecFunctionalityId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SecFunctionalityId), 10, 0, ".", "")),context.localUtil.Format( (decimal)(A1SecFunctionalityId), "ZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSecFunctionalityId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)36,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecFunctionalityKey_Internalname,(String)A3SecFunctionalityKey,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSecFunctionalityKey_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)36,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecFunctionalityDescription_Internalname,(String)A8SecFunctionalityDescription,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtSecFunctionalityDescription_Link,(String)"",(String)"",(String)"",(String)edtSecFunctionalityDescription_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)36,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            if ( ( cmbSecFunctionalityType.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "SECFUNCTIONALITYTYPE_" + sGXsfl_36_idx;
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
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbSecFunctionalityType,(String)cmbSecFunctionalityType_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(A9SecFunctionalityType), 2, 0)),(short)1,(String)cmbSecFunctionalityType_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)0,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbSecFunctionalityType.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A9SecFunctionalityType), 2, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbSecFunctionalityType_Internalname, "Values", (String)(cmbSecFunctionalityType.ToJavascriptSource()), !bGXsfl_36_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecParentFunctionalityId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A2SecParentFunctionalityId), 10, 0, ".", "")),context.localUtil.Format( (decimal)(A2SecParentFunctionalityId), "ZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSecParentFunctionalityId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)36,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecParentFunctionalityDescription_Internalname,(String)A11SecParentFunctionalityDescription,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSecParentFunctionalityDescription_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)36,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Check box */
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GridRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkSecFunctionalityActive_Internalname,StringUtil.BoolToStr( A7SecFunctionalityActive),(String)"",(String)"",(short)0,(short)0,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn hidden-xs",(String)"",(String)""});
            send_integrity_lvl_hashes0H2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_36_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_36_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_36_idx+1));
            sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0");
            SubsflControlProps_362( ) ;
         }
         /* End function sendrow_362 */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "SECFUNCTIONALITYTYPE_" + sGXsfl_36_idx;
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
         GXCCtl = "SECFUNCTIONALITYACTIVE_" + sGXsfl_36_idx;
         chkSecFunctionalityActive.Name = GXCCtl;
         chkSecFunctionalityActive.WebTags = "";
         chkSecFunctionalityActive.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkSecFunctionalityActive_Internalname, "TitleCaption", chkSecFunctionalityActive.Caption, !bGXsfl_36_Refreshing);
         chkSecFunctionalityActive.CheckedValue = "false";
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtninsert_Internalname = "BTNINSERT";
         edtavSecfunctionalitykey_Internalname = "vSECFUNCTIONALITYKEY";
         edtavSecfunctionalitydescription_Internalname = "vSECFUNCTIONALITYDESCRIPTION";
         divTableactions_Internalname = "TABLEACTIONS";
         divTableheader_Internalname = "TABLEHEADER";
         divLayout_tableheader_Internalname = "LAYOUT_TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         divHtml_dvpanel_tableheader_Internalname = "HTML_DVPANEL_TABLEHEADER";
         edtavDisplay_Internalname = "vDISPLAY";
         edtavUpdate_Internalname = "vUPDATE";
         edtavDelete_Internalname = "vDELETE";
         edtavFuncassociaterole_Internalname = "vFUNCASSOCIATEROLE";
         edtavUaviewchildren_Internalname = "vUAVIEWCHILDREN";
         edtSecFunctionalityId_Internalname = "SECFUNCTIONALITYID";
         edtSecFunctionalityKey_Internalname = "SECFUNCTIONALITYKEY";
         edtSecFunctionalityDescription_Internalname = "SECFUNCTIONALITYDESCRIPTION";
         cmbSecFunctionalityType_Internalname = "SECFUNCTIONALITYTYPE";
         edtSecParentFunctionalityId_Internalname = "SECPARENTFUNCTIONALITYID";
         edtSecParentFunctionalityDescription_Internalname = "SECPARENTFUNCTIONALITYDESCRIPTION";
         chkSecFunctionalityActive_Internalname = "SECFUNCTIONALITYACTIVE";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_secfunctionalitykey_Internalname = "DDO_SECFUNCTIONALITYKEY";
         edtavDdo_secfunctionalitykeytitlecontrolidtoreplace_Internalname = "vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE";
         Ddo_secfunctionalitydescription_Internalname = "DDO_SECFUNCTIONALITYDESCRIPTION";
         edtavDdo_secfunctionalitydescriptiontitlecontrolidtoreplace_Internalname = "vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         edtavTfsecfunctionalitykey_Internalname = "vTFSECFUNCTIONALITYKEY";
         edtavTfsecfunctionalitykey_sel_Internalname = "vTFSECFUNCTIONALITYKEY_SEL";
         edtavTfsecfunctionalitydescription_Internalname = "vTFSECFUNCTIONALITYDESCRIPTION";
         edtavTfsecfunctionalitydescription_sel_Internalname = "vTFSECFUNCTIONALITYDESCRIPTION_SEL";
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
         chkSecFunctionalityActive.Caption = "";
         edtSecParentFunctionalityDescription_Jsonclick = "";
         edtSecParentFunctionalityId_Jsonclick = "";
         cmbSecFunctionalityType_Jsonclick = "";
         edtSecFunctionalityDescription_Jsonclick = "";
         edtSecFunctionalityKey_Jsonclick = "";
         edtSecFunctionalityId_Jsonclick = "";
         edtavTfsecfunctionalitydescription_sel_Jsonclick = "";
         edtavTfsecfunctionalitydescription_sel_Visible = 1;
         edtavTfsecfunctionalitydescription_Jsonclick = "";
         edtavTfsecfunctionalitydescription_Visible = 1;
         edtavTfsecfunctionalitykey_sel_Jsonclick = "";
         edtavTfsecfunctionalitykey_sel_Visible = 1;
         edtavTfsecfunctionalitykey_Jsonclick = "";
         edtavTfsecfunctionalitykey_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_secfunctionalitydescriptiontitlecontrolidtoreplace_Visible = 1;
         edtavDdo_secfunctionalitykeytitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtSecFunctionalityDescription_Link = "";
         edtavUaviewchildren_Tooltiptext = "View Actions, Tabs and Modes";
         edtavUaviewchildren_Link = "";
         edtavFuncassociaterole_Tooltiptext = "";
         edtavFuncassociaterole_Link = "";
         edtavDelete_Tooltiptext = "删除";
         edtavDelete_Link = "";
         edtavUpdate_Tooltiptext = "修改";
         edtavUpdate_Link = "";
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtSecFunctionalityDescription_Titleformat = 0;
         edtSecFunctionalityDescription_Title = "权限描述";
         edtSecFunctionalityKey_Titleformat = 0;
         edtSecFunctionalityKey_Title = "权限名称";
         edtavUaviewchildren_Class = "ActionBaseColorAttribute";
         edtavDelete_Visible = -1;
         edtavUpdate_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         edtavSecfunctionalitydescription_Jsonclick = "";
         edtavSecfunctionalitydescription_Enabled = 1;
         edtavSecfunctionalitykey_Jsonclick = "";
         edtavSecfunctionalitykey_Enabled = 1;
         bttBtninsert_Visible = 1;
         Ddo_secfunctionalitydescription_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_secfunctionalitydescription_Noresultsfound = "WWP_TSNoResults";
         Ddo_secfunctionalitydescription_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_secfunctionalitydescription_Loadingdata = "WWP_TSLoading";
         Ddo_secfunctionalitydescription_Sortdsc = "WWP_TSSortDSC";
         Ddo_secfunctionalitydescription_Sortasc = "WWP_TSSortASC";
         Ddo_secfunctionalitydescription_Datalistupdateminimumcharacters = 0;
         Ddo_secfunctionalitydescription_Datalistproc = "WWPBaseObjects.SecFunctionalityWWGetFilterData";
         Ddo_secfunctionalitydescription_Datalisttype = "Dynamic";
         Ddo_secfunctionalitydescription_Includedatalist = Convert.ToBoolean( -1);
         Ddo_secfunctionalitydescription_Filterisrange = Convert.ToBoolean( 0);
         Ddo_secfunctionalitydescription_Filtertype = "Character";
         Ddo_secfunctionalitydescription_Includefilter = Convert.ToBoolean( -1);
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
         Ddo_secfunctionalitykey_Datalistproc = "WWPBaseObjects.SecFunctionalityWWGetFilterData";
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
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Work With Functionality";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV18IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV19IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV43ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV22SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV10SecFunctionalityDescription',fld:'vSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'AV41TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'AV42TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'AV45TFSecFunctionalityDescription',fld:'vTFSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'AV46TFSecFunctionalityDescription_Sel',fld:'vTFSECFUNCTIONALITYDESCRIPTION_SEL',pic:''},{av:'AV105Pgmname',fld:'vPGMNAME',pic:''},{av:'AV29OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV30OrderedDsc',fld:'vORDEREDDSC',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV40SecFunctionalityKeyTitleFilterData',fld:'vSECFUNCTIONALITYKEYTITLEFILTERDATA',pic:''},{av:'AV44SecFunctionalityDescriptionTitleFilterData',fld:'vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtSecFunctionalityKey_Titleformat',ctrl:'SECFUNCTIONALITYKEY',prop:'Titleformat'},{av:'edtSecFunctionalityKey_Title',ctrl:'SECFUNCTIONALITYKEY',prop:'Title'},{av:'edtSecFunctionalityDescription_Titleformat',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Titleformat'},{av:'edtSecFunctionalityDescription_Title',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Title'},{av:'AV85GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV87GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV88GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV18IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV19IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E110H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV22SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV10SecFunctionalityDescription',fld:'vSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'AV29OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV30OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV41TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'AV42TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'AV45TFSecFunctionalityDescription',fld:'vTFSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'AV46TFSecFunctionalityDescription_Sel',fld:'vTFSECFUNCTIONALITYDESCRIPTION_SEL',pic:''},{av:'AV43ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV105Pgmname',fld:'vPGMNAME',pic:''},{av:'AV18IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV19IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E120H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV22SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV10SecFunctionalityDescription',fld:'vSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'AV29OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV30OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV41TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'AV42TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'AV45TFSecFunctionalityDescription',fld:'vTFSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'AV46TFSecFunctionalityDescription_Sel',fld:'vTFSECFUNCTIONALITYDESCRIPTION_SEL',pic:''},{av:'AV43ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV105Pgmname',fld:'vPGMNAME',pic:''},{av:'AV18IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV19IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_SECFUNCTIONALITYKEY.ONOPTIONCLICKED","{handler:'E130H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV22SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV10SecFunctionalityDescription',fld:'vSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'AV29OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV30OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV41TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'AV42TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'AV45TFSecFunctionalityDescription',fld:'vTFSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'AV46TFSecFunctionalityDescription_Sel',fld:'vTFSECFUNCTIONALITYDESCRIPTION_SEL',pic:''},{av:'AV43ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV105Pgmname',fld:'vPGMNAME',pic:''},{av:'AV18IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV19IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_secfunctionalitykey_Activeeventkey',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'ActiveEventKey'},{av:'Ddo_secfunctionalitykey_Filteredtext_get',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'FilteredText_get'},{av:'Ddo_secfunctionalitykey_Selectedvalue_get',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_SECFUNCTIONALITYKEY.ONOPTIONCLICKED",",oparms:[{av:'AV29OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV30OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_secfunctionalitykey_Sortedstatus',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'SortedStatus'},{av:'AV41TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'AV42TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'Ddo_secfunctionalitydescription_Sortedstatus',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'SortedStatus'},{av:'AV40SecFunctionalityKeyTitleFilterData',fld:'vSECFUNCTIONALITYKEYTITLEFILTERDATA',pic:''},{av:'AV44SecFunctionalityDescriptionTitleFilterData',fld:'vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtSecFunctionalityKey_Titleformat',ctrl:'SECFUNCTIONALITYKEY',prop:'Titleformat'},{av:'edtSecFunctionalityKey_Title',ctrl:'SECFUNCTIONALITYKEY',prop:'Title'},{av:'edtSecFunctionalityDescription_Titleformat',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Titleformat'},{av:'edtSecFunctionalityDescription_Title',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Title'},{av:'AV85GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV87GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV88GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV18IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV19IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_SECFUNCTIONALITYDESCRIPTION.ONOPTIONCLICKED","{handler:'E140H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV22SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV10SecFunctionalityDescription',fld:'vSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'AV29OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV30OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV41TFSecFunctionalityKey',fld:'vTFSECFUNCTIONALITYKEY',pic:''},{av:'AV42TFSecFunctionalityKey_Sel',fld:'vTFSECFUNCTIONALITYKEY_SEL',pic:''},{av:'AV45TFSecFunctionalityDescription',fld:'vTFSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'AV46TFSecFunctionalityDescription_Sel',fld:'vTFSECFUNCTIONALITYDESCRIPTION_SEL',pic:''},{av:'AV43ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV105Pgmname',fld:'vPGMNAME',pic:''},{av:'AV18IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV19IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_secfunctionalitydescription_Activeeventkey',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'ActiveEventKey'},{av:'Ddo_secfunctionalitydescription_Filteredtext_get',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'FilteredText_get'},{av:'Ddo_secfunctionalitydescription_Selectedvalue_get',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_SECFUNCTIONALITYDESCRIPTION.ONOPTIONCLICKED",",oparms:[{av:'AV29OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV30OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_secfunctionalitydescription_Sortedstatus',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'SortedStatus'},{av:'AV45TFSecFunctionalityDescription',fld:'vTFSECFUNCTIONALITYDESCRIPTION',pic:''},{av:'AV46TFSecFunctionalityDescription_Sel',fld:'vTFSECFUNCTIONALITYDESCRIPTION_SEL',pic:''},{av:'Ddo_secfunctionalitykey_Sortedstatus',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'SortedStatus'},{av:'AV40SecFunctionalityKeyTitleFilterData',fld:'vSECFUNCTIONALITYKEYTITLEFILTERDATA',pic:''},{av:'AV44SecFunctionalityDescriptionTitleFilterData',fld:'vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtSecFunctionalityKey_Titleformat',ctrl:'SECFUNCTIONALITYKEY',prop:'Titleformat'},{av:'edtSecFunctionalityKey_Title',ctrl:'SECFUNCTIONALITYKEY',prop:'Title'},{av:'edtSecFunctionalityDescription_Titleformat',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Titleformat'},{av:'edtSecFunctionalityDescription_Title',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Title'},{av:'AV85GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV87GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV88GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV18IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV19IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E180H2',iparms:[{av:'A1SecFunctionalityId',fld:'SECFUNCTIONALITYID',pic:'ZZZZZZZZZ9',hsh:true},{av:'AV18IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV19IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV89Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'},{av:'AV11Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV12Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'},{av:'AV91FuncAssociateRole',fld:'vFUNCASSOCIATEROLE',pic:''},{av:'edtavFuncassociaterole_Tooltiptext',ctrl:'vFUNCASSOCIATEROLE',prop:'Tooltiptext'},{av:'edtavFuncassociaterole_Link',ctrl:'vFUNCASSOCIATEROLE',prop:'Link'},{av:'AV24UAViewChildren',fld:'vUAVIEWCHILDREN',pic:''},{av:'edtavUaviewchildren_Tooltiptext',ctrl:'vUAVIEWCHILDREN',prop:'Tooltiptext'},{av:'edtavUaviewchildren_Link',ctrl:'vUAVIEWCHILDREN',prop:'Link'},{av:'edtavUaviewchildren_Class',ctrl:'vUAVIEWCHILDREN',prop:'Class'},{av:'edtSecFunctionalityDescription_Link',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E150H2',iparms:[{av:'A1SecFunctionalityId',fld:'SECFUNCTIONALITYID',pic:'ZZZZZZZZZ9',hsh:true}]");
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
         Ddo_secfunctionalitykey_Activeeventkey = "";
         Ddo_secfunctionalitykey_Filteredtext_get = "";
         Ddo_secfunctionalitykey_Selectedvalue_get = "";
         Ddo_secfunctionalitydescription_Activeeventkey = "";
         Ddo_secfunctionalitydescription_Filteredtext_get = "";
         Ddo_secfunctionalitydescription_Selectedvalue_get = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV22SecFunctionalityKey = "";
         AV10SecFunctionalityDescription = "";
         AV41TFSecFunctionalityKey = "";
         AV42TFSecFunctionalityKey_Sel = "";
         AV45TFSecFunctionalityDescription = "";
         AV46TFSecFunctionalityDescription_Sel = "";
         AV43ddo_SecFunctionalityKeyTitleControlIdToReplace = "";
         AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace = "";
         AV105Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV55DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV40SecFunctionalityKeyTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV44SecFunctionalityDescriptionTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_secfunctionalitykey_Filteredtext_set = "";
         Ddo_secfunctionalitykey_Selectedvalue_set = "";
         Ddo_secfunctionalitykey_Sortedstatus = "";
         Ddo_secfunctionalitydescription_Filteredtext_set = "";
         Ddo_secfunctionalitydescription_Selectedvalue_set = "";
         Ddo_secfunctionalitydescription_Sortedstatus = "";
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
         AV89Display = "";
         AV11Update = "";
         AV12Delete = "";
         AV91FuncAssociateRole = "";
         AV24UAViewChildren = "";
         A3SecFunctionalityKey = "";
         A8SecFunctionalityDescription = "";
         A11SecParentFunctionalityDescription = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_secfunctionalitykey = new GXUserControl();
         ucDdo_secfunctionalitydescription = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV100Display_GXI = "";
         AV101Update_GXI = "";
         AV102Delete_GXI = "";
         AV103Funcassociaterole_GXI = "";
         AV104Uaviewchildren_GXI = "";
         scmdbuf = "";
         lV94WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey = "";
         lV95WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription = "";
         lV96WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey = "";
         lV98WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription = "";
         AV94WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey = "";
         AV95WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription = "";
         AV97WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel = "";
         AV96WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey = "";
         AV99WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel = "";
         AV98WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription = "";
         H000H2_A7SecFunctionalityActive = new bool[] {false} ;
         H000H2_A11SecParentFunctionalityDescription = new String[] {""} ;
         H000H2_A2SecParentFunctionalityId = new long[1] ;
         H000H2_n2SecParentFunctionalityId = new bool[] {false} ;
         H000H2_A9SecFunctionalityType = new short[1] ;
         H000H2_A8SecFunctionalityDescription = new String[] {""} ;
         H000H2_A3SecFunctionalityKey = new String[] {""} ;
         H000H2_A1SecFunctionalityId = new long[1] ;
         H000H3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV81WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         AV13Session = context.GetSession();
         AV27GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV28GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV8TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV7HTTPRequest = new GxHttpRequest( context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secfunctionalityww__default(),
            new Object[][] {
                new Object[] {
               H000H2_A7SecFunctionalityActive, H000H2_A11SecParentFunctionalityDescription, H000H2_A2SecParentFunctionalityId, H000H2_n2SecParentFunctionalityId, H000H2_A9SecFunctionalityType, H000H2_A8SecFunctionalityDescription, H000H2_A3SecFunctionalityKey, H000H2_A1SecFunctionalityId
               }
               , new Object[] {
               H000H3_AGRID_nRecordCount
               }
            }
         );
         AV105Pgmname = "WWPBaseObjects.SecFunctionalityWW";
         /* GeneXus formulas. */
         AV105Pgmname = "WWPBaseObjects.SecFunctionalityWW";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_36 ;
      private short nGXsfl_36_idx=1 ;
      private short GRID_nEOF ;
      private short AV29OrderedBy ;
      private short initialized ;
      private short gxajaxcallmode ;
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
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid_Backstyle ;
      private int subGrid_Rows ;
      private int Gridpaginationbar_Rowsperpageselectedvalue ;
      private int Gridpaginationbar_Pagestoshow ;
      private int Ddo_secfunctionalitykey_Datalistupdateminimumcharacters ;
      private int Ddo_secfunctionalitydescription_Datalistupdateminimumcharacters ;
      private int bttBtninsert_Visible ;
      private int edtavSecfunctionalitykey_Enabled ;
      private int edtavSecfunctionalitydescription_Enabled ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavUpdate_Visible ;
      private int edtavDelete_Visible ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_secfunctionalitykeytitlecontrolidtoreplace_Visible ;
      private int edtavDdo_secfunctionalitydescriptiontitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfsecfunctionalitykey_Visible ;
      private int edtavTfsecfunctionalitykey_sel_Visible ;
      private int edtavTfsecfunctionalitydescription_Visible ;
      private int edtavTfsecfunctionalitydescription_sel_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV84PageToGo ;
      private int AV106GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV85GridCurrentPage ;
      private long AV88GridRecordCount ;
      private long AV87GridPageSize ;
      private long A1SecFunctionalityId ;
      private long A2SecParentFunctionalityId ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_secfunctionalitykey_Activeeventkey ;
      private String Ddo_secfunctionalitykey_Filteredtext_get ;
      private String Ddo_secfunctionalitykey_Selectedvalue_get ;
      private String Ddo_secfunctionalitydescription_Activeeventkey ;
      private String Ddo_secfunctionalitydescription_Filteredtext_get ;
      private String Ddo_secfunctionalitydescription_Selectedvalue_get ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_36_idx="0001" ;
      private String AV105Pgmname ;
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
      private String Ddo_secfunctionalitydescription_Filteredtext_set ;
      private String Ddo_secfunctionalitydescription_Selectedvalue_set ;
      private String Ddo_secfunctionalitydescription_Dropdownoptionstype ;
      private String Ddo_secfunctionalitydescription_Titlecontrolidtoreplace ;
      private String Ddo_secfunctionalitydescription_Sortedstatus ;
      private String Ddo_secfunctionalitydescription_Filtertype ;
      private String Ddo_secfunctionalitydescription_Datalisttype ;
      private String Ddo_secfunctionalitydescription_Datalistproc ;
      private String Ddo_secfunctionalitydescription_Sortasc ;
      private String Ddo_secfunctionalitydescription_Sortdsc ;
      private String Ddo_secfunctionalitydescription_Loadingdata ;
      private String Ddo_secfunctionalitydescription_Cleanfilter ;
      private String Ddo_secfunctionalitydescription_Noresultsfound ;
      private String Ddo_secfunctionalitydescription_Searchbuttontext ;
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
      private String edtavSecfunctionalitykey_Internalname ;
      private String edtavSecfunctionalitykey_Jsonclick ;
      private String edtavSecfunctionalitydescription_Internalname ;
      private String edtavSecfunctionalitydescription_Jsonclick ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtavUaviewchildren_Class ;
      private String edtSecFunctionalityKey_Title ;
      private String edtSecFunctionalityDescription_Title ;
      private String subGrid_Header ;
      private String edtavDisplay_Link ;
      private String edtavDisplay_Tooltiptext ;
      private String edtavUpdate_Link ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavDelete_Link ;
      private String edtavDelete_Tooltiptext ;
      private String edtavFuncassociaterole_Link ;
      private String edtavFuncassociaterole_Tooltiptext ;
      private String edtavUaviewchildren_Link ;
      private String edtavUaviewchildren_Tooltiptext ;
      private String edtSecFunctionalityDescription_Link ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_secfunctionalitykey_Internalname ;
      private String edtavDdo_secfunctionalitykeytitlecontrolidtoreplace_Internalname ;
      private String Ddo_secfunctionalitydescription_Internalname ;
      private String edtavDdo_secfunctionalitydescriptiontitlecontrolidtoreplace_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavTfsecfunctionalitykey_Internalname ;
      private String edtavTfsecfunctionalitykey_Jsonclick ;
      private String edtavTfsecfunctionalitykey_sel_Internalname ;
      private String edtavTfsecfunctionalitykey_sel_Jsonclick ;
      private String edtavTfsecfunctionalitydescription_Internalname ;
      private String edtavTfsecfunctionalitydescription_Jsonclick ;
      private String edtavTfsecfunctionalitydescription_sel_Internalname ;
      private String edtavTfsecfunctionalitydescription_sel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDisplay_Internalname ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String edtavFuncassociaterole_Internalname ;
      private String edtavUaviewchildren_Internalname ;
      private String edtSecFunctionalityId_Internalname ;
      private String edtSecFunctionalityKey_Internalname ;
      private String edtSecFunctionalityDescription_Internalname ;
      private String cmbSecFunctionalityType_Internalname ;
      private String edtSecParentFunctionalityId_Internalname ;
      private String edtSecParentFunctionalityDescription_Internalname ;
      private String chkSecFunctionalityActive_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_36_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtSecFunctionalityId_Jsonclick ;
      private String edtSecFunctionalityKey_Jsonclick ;
      private String edtSecFunctionalityDescription_Jsonclick ;
      private String GXCCtl ;
      private String cmbSecFunctionalityType_Jsonclick ;
      private String edtSecParentFunctionalityId_Jsonclick ;
      private String edtSecParentFunctionalityDescription_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV30OrderedDsc ;
      private bool AV18IsAuthorized_Update ;
      private bool AV19IsAuthorized_Delete ;
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
      private bool Ddo_secfunctionalitydescription_Filterisrange ;
      private bool Ddo_secfunctionalitydescription_Includedatalist ;
      private bool wbLoad ;
      private bool A7SecFunctionalityActive ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_36_Refreshing=false ;
      private bool n2SecParentFunctionalityId ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV15TempBoolean ;
      private bool GXt_boolean2 ;
      private bool AV89Display_IsBlob ;
      private bool AV11Update_IsBlob ;
      private bool AV12Delete_IsBlob ;
      private bool AV91FuncAssociateRole_IsBlob ;
      private bool AV24UAViewChildren_IsBlob ;
      private String AV22SecFunctionalityKey ;
      private String AV10SecFunctionalityDescription ;
      private String AV41TFSecFunctionalityKey ;
      private String AV42TFSecFunctionalityKey_Sel ;
      private String AV45TFSecFunctionalityDescription ;
      private String AV46TFSecFunctionalityDescription_Sel ;
      private String AV43ddo_SecFunctionalityKeyTitleControlIdToReplace ;
      private String AV47ddo_SecFunctionalityDescriptionTitleControlIdToReplace ;
      private String A3SecFunctionalityKey ;
      private String A8SecFunctionalityDescription ;
      private String A11SecParentFunctionalityDescription ;
      private String AV100Display_GXI ;
      private String AV101Update_GXI ;
      private String AV102Delete_GXI ;
      private String AV103Funcassociaterole_GXI ;
      private String AV104Uaviewchildren_GXI ;
      private String lV94WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey ;
      private String lV95WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription ;
      private String lV96WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey ;
      private String lV98WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription ;
      private String AV94WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey ;
      private String AV95WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription ;
      private String AV97WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel ;
      private String AV96WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey ;
      private String AV99WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel ;
      private String AV98WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription ;
      private String AV89Display ;
      private String AV11Update ;
      private String AV12Delete ;
      private String AV91FuncAssociateRole ;
      private String AV24UAViewChildren ;
      private IGxSession AV13Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_secfunctionalitykey ;
      private GXUserControl ucDdo_secfunctionalitydescription ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbSecFunctionalityType ;
      private GXCheckbox chkSecFunctionalityActive ;
      private IDataStoreProvider pr_default ;
      private bool[] H000H2_A7SecFunctionalityActive ;
      private String[] H000H2_A11SecParentFunctionalityDescription ;
      private long[] H000H2_A2SecParentFunctionalityId ;
      private bool[] H000H2_n2SecParentFunctionalityId ;
      private short[] H000H2_A9SecFunctionalityType ;
      private String[] H000H2_A8SecFunctionalityDescription ;
      private String[] H000H2_A3SecFunctionalityKey ;
      private long[] H000H2_A1SecFunctionalityId ;
      private long[] H000H3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV7HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV40SecFunctionalityKeyTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV44SecFunctionalityDescriptionTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV81WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV8TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV27GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV28GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV55DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class secfunctionalityww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H000H2( IGxContext context ,
                                             String AV94WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey ,
                                             String AV95WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription ,
                                             String AV97WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel ,
                                             String AV96WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey ,
                                             String AV99WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel ,
                                             String AV98WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription ,
                                             String A3SecFunctionalityKey ,
                                             String A8SecFunctionalityDescription ,
                                             short AV29OrderedBy ,
                                             bool AV30OrderedDsc )
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
         sSelectString = " T1.[SecFunctionalityActive], T2.[SecFunctionalityDescription] AS SecParentFunctionalityDescription, T1.[SecParentFunctionalityId] AS SecParentFunctionalityId, T1.[SecFunctionalityType], T1.[SecFunctionalityDescription], T1.[SecFunctionalityKey], T1.[SecFunctionalityId]";
         sFromString = " FROM ([SecFunctionality] T1 WITH (NOLOCK) LEFT JOIN [SecFunctionality] T2 WITH (NOLOCK) ON T2.[SecFunctionalityId] = T1.[SecParentFunctionalityId])";
         sOrderString = "";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[SecFunctionalityKey] like '%' + @lV94WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey + '%')";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[SecFunctionalityKey] like '%' + @lV94WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey + '%')";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV95WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[SecFunctionalityDescription] like '%' + @lV95WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription + '%')";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[SecFunctionalityDescription] like '%' + @lV95WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription + '%')";
            }
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV97WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV96WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[SecFunctionalityKey] like @lV96WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[SecFunctionalityKey] like @lV96WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey)";
            }
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV97WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[SecFunctionalityKey] = @AV97WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[SecFunctionalityKey] = @AV97WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel)";
            }
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV99WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV98WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[SecFunctionalityDescription] like @lV98WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[SecFunctionalityDescription] like @lV98WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription)";
            }
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV99WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[SecFunctionalityDescription] = @AV99WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[SecFunctionalityDescription] = @AV99WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel)";
            }
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         if ( ( AV29OrderedBy == 1 ) && ! AV30OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[SecFunctionalityKey]";
         }
         else if ( ( AV29OrderedBy == 1 ) && ( AV30OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[SecFunctionalityKey] DESC";
         }
         else if ( ( AV29OrderedBy == 2 ) && ! AV30OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[SecFunctionalityDescription]";
         }
         else if ( ( AV29OrderedBy == 2 ) && ( AV30OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[SecFunctionalityDescription] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY T1.[SecFunctionalityId]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H000H3( IGxContext context ,
                                             String AV94WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey ,
                                             String AV95WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription ,
                                             String AV97WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel ,
                                             String AV96WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey ,
                                             String AV99WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel ,
                                             String AV98WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription ,
                                             String A3SecFunctionalityKey ,
                                             String A8SecFunctionalityDescription ,
                                             short AV29OrderedBy ,
                                             bool AV30OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [6] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM ([SecFunctionality] T1 WITH (NOLOCK) LEFT JOIN [SecFunctionality] T2 WITH (NOLOCK) ON T2.[SecFunctionalityId] = T1.[SecParentFunctionalityId])";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[SecFunctionalityKey] like '%' + @lV94WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey + '%')";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[SecFunctionalityKey] like '%' + @lV94WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey + '%')";
            }
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV95WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[SecFunctionalityDescription] like '%' + @lV95WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription + '%')";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[SecFunctionalityDescription] like '%' + @lV95WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription + '%')";
            }
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV97WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV96WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[SecFunctionalityKey] like @lV96WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[SecFunctionalityKey] like @lV96WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey)";
            }
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV97WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[SecFunctionalityKey] = @AV97WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[SecFunctionalityKey] = @AV97WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel)";
            }
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV99WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV98WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[SecFunctionalityDescription] like @lV98WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[SecFunctionalityDescription] like @lV98WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription)";
            }
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV99WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[SecFunctionalityDescription] = @AV99WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[SecFunctionalityDescription] = @AV99WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel)";
            }
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         if ( ( AV29OrderedBy == 1 ) && ! AV30OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV29OrderedBy == 1 ) && ( AV30OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV29OrderedBy == 2 ) && ! AV30OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV29OrderedBy == 2 ) && ( AV30OrderedDsc ) )
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
                     return conditional_H000H2(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (short)dynConstraints[8] , (bool)dynConstraints[9] );
               case 1 :
                     return conditional_H000H3(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (short)dynConstraints[8] , (bool)dynConstraints[9] );
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
          Object[] prmH000H2 ;
          prmH000H2 = new Object[] {
          new Object[] {"@lV94WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV95WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV96WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV97WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV98WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV99WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH000H3 ;
          prmH000H3 = new Object[] {
          new Object[] {"@lV94WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV95WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV96WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV97WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV98WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV99WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel",SqlDbType.NVarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000H2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000H2,11,0,true,false )
             ,new CursorDef("H000H3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000H3,1,0,true,false )
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
                ((bool[]) buf[0])[0] = rslt.getBool(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
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
                   stmt.SetParameter(sIdx, (String)parms[9]);
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
