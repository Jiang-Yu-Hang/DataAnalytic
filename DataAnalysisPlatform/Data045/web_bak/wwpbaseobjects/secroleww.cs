/*
               File: WWPBaseObjects.SecRoleWW
        Description: Work With Role
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:39:8.31
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
   public class secroleww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public secroleww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public secroleww( IGxContext context )
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
               nRC_GXsfl_28 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_28_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_28_idx = GetNextPar( );
               edtavUaassociatefunctionalities_Title = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUaassociatefunctionalities_Internalname, "Title", edtavUaassociatefunctionalities_Title, !bGXsfl_28_Refreshing);
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
               AV46OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV47OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV73TFSecRoleName = GetNextPar( );
               AV74TFSecRoleName_Sel = GetNextPar( );
               AV77TFSecRoleDescription = GetNextPar( );
               AV78TFSecRoleDescription_Sel = GetNextPar( );
               AV75ddo_SecRoleNameTitleControlIdToReplace = GetNextPar( );
               AV79ddo_SecRoleDescriptionTitleControlIdToReplace = GetNextPar( );
               AV110Pgmname = GetNextPar( );
               edtavUaassociatefunctionalities_Title = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUaassociatefunctionalities_Internalname, "Title", edtavUaassociatefunctionalities_Title, !bGXsfl_28_Refreshing);
               AV39IsAuthorized_Update = StringUtil.StrToBool( GetNextPar( ));
               AV37IsAuthorized_UAAssociateFunctionalities = StringUtil.StrToBool( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV46OrderedBy, AV47OrderedDsc, AV73TFSecRoleName, AV74TFSecRoleName_Sel, AV77TFSecRoleDescription, AV78TFSecRoleDescription_Sel, AV75ddo_SecRoleNameTitleControlIdToReplace, AV79ddo_SecRoleDescriptionTitleControlIdToReplace, AV110Pgmname, AV39IsAuthorized_Update, AV37IsAuthorized_UAAssociateFunctionalities) ;
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
         PA0I2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0I2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2020227939852", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("wwpbaseobjects.secroleww.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV46OrderedBy), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV47OrderedDsc));
         GxWebStd.gx_hidden_field( context, "GXH_vTFSECROLENAME", AV73TFSecRoleName);
         GxWebStd.gx_hidden_field( context, "GXH_vTFSECROLENAME_SEL", AV74TFSecRoleName_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFSECROLEDESCRIPTION", AV77TFSecRoleDescription);
         GxWebStd.gx_hidden_field( context, "GXH_vTFSECROLEDESCRIPTION_SEL", AV78TFSecRoleDescription_Sel);
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_28", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_28), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV91GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV94GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV93GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV80DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV80DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vSECROLENAMETITLEFILTERDATA", AV72SecRoleNameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vSECROLENAMETITLEFILTERDATA", AV72SecRoleNameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vSECROLEDESCRIPTIONTITLEFILTERDATA", AV76SecRoleDescriptionTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vSECROLEDESCRIPTIONTITLEFILTERDATA", AV76SecRoleDescriptionTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV110Pgmname));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_UPDATE", AV39IsAuthorized_Update);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_UAASSOCIATEFUNCTIONALITIES", AV37IsAuthorized_UAAssociateFunctionalities);
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
         GxWebStd.gx_hidden_field( context, "DDO_SECROLENAME_Caption", StringUtil.RTrim( Ddo_secrolename_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLENAME_Tooltip", StringUtil.RTrim( Ddo_secrolename_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLENAME_Cls", StringUtil.RTrim( Ddo_secrolename_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLENAME_Filteredtext_set", StringUtil.RTrim( Ddo_secrolename_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLENAME_Selectedvalue_set", StringUtil.RTrim( Ddo_secrolename_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLENAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_secrolename_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLENAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_secrolename_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLENAME_Includesortasc", StringUtil.BoolToStr( Ddo_secrolename_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLENAME_Includesortdsc", StringUtil.BoolToStr( Ddo_secrolename_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLENAME_Sortedstatus", StringUtil.RTrim( Ddo_secrolename_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLENAME_Includefilter", StringUtil.BoolToStr( Ddo_secrolename_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLENAME_Filtertype", StringUtil.RTrim( Ddo_secrolename_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLENAME_Filterisrange", StringUtil.BoolToStr( Ddo_secrolename_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLENAME_Includedatalist", StringUtil.BoolToStr( Ddo_secrolename_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLENAME_Datalisttype", StringUtil.RTrim( Ddo_secrolename_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLENAME_Datalistproc", StringUtil.RTrim( Ddo_secrolename_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLENAME_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_secrolename_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLENAME_Sortasc", StringUtil.RTrim( Ddo_secrolename_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLENAME_Sortdsc", StringUtil.RTrim( Ddo_secrolename_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLENAME_Loadingdata", StringUtil.RTrim( Ddo_secrolename_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLENAME_Cleanfilter", StringUtil.RTrim( Ddo_secrolename_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLENAME_Noresultsfound", StringUtil.RTrim( Ddo_secrolename_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLENAME_Searchbuttontext", StringUtil.RTrim( Ddo_secrolename_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLEDESCRIPTION_Caption", StringUtil.RTrim( Ddo_secroledescription_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLEDESCRIPTION_Tooltip", StringUtil.RTrim( Ddo_secroledescription_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLEDESCRIPTION_Cls", StringUtil.RTrim( Ddo_secroledescription_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLEDESCRIPTION_Filteredtext_set", StringUtil.RTrim( Ddo_secroledescription_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLEDESCRIPTION_Selectedvalue_set", StringUtil.RTrim( Ddo_secroledescription_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLEDESCRIPTION_Dropdownoptionstype", StringUtil.RTrim( Ddo_secroledescription_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLEDESCRIPTION_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_secroledescription_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLEDESCRIPTION_Includesortasc", StringUtil.BoolToStr( Ddo_secroledescription_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLEDESCRIPTION_Includesortdsc", StringUtil.BoolToStr( Ddo_secroledescription_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLEDESCRIPTION_Sortedstatus", StringUtil.RTrim( Ddo_secroledescription_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLEDESCRIPTION_Includefilter", StringUtil.BoolToStr( Ddo_secroledescription_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLEDESCRIPTION_Filtertype", StringUtil.RTrim( Ddo_secroledescription_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLEDESCRIPTION_Filterisrange", StringUtil.BoolToStr( Ddo_secroledescription_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLEDESCRIPTION_Includedatalist", StringUtil.BoolToStr( Ddo_secroledescription_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLEDESCRIPTION_Datalisttype", StringUtil.RTrim( Ddo_secroledescription_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLEDESCRIPTION_Datalistproc", StringUtil.RTrim( Ddo_secroledescription_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLEDESCRIPTION_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_secroledescription_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLEDESCRIPTION_Sortasc", StringUtil.RTrim( Ddo_secroledescription_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLEDESCRIPTION_Sortdsc", StringUtil.RTrim( Ddo_secroledescription_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLEDESCRIPTION_Loadingdata", StringUtil.RTrim( Ddo_secroledescription_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLEDESCRIPTION_Cleanfilter", StringUtil.RTrim( Ddo_secroledescription_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLEDESCRIPTION_Noresultsfound", StringUtil.RTrim( Ddo_secroledescription_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLEDESCRIPTION_Searchbuttontext", StringUtil.RTrim( Ddo_secroledescription_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLENAME_Activeeventkey", StringUtil.RTrim( Ddo_secrolename_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLENAME_Filteredtext_get", StringUtil.RTrim( Ddo_secrolename_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLENAME_Selectedvalue_get", StringUtil.RTrim( Ddo_secrolename_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLEDESCRIPTION_Activeeventkey", StringUtil.RTrim( Ddo_secroledescription_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLEDESCRIPTION_Filteredtext_get", StringUtil.RTrim( Ddo_secroledescription_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLEDESCRIPTION_Selectedvalue_get", StringUtil.RTrim( Ddo_secroledescription_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "vUAASSOCIATEFUNCTIONALITIES_Title", StringUtil.RTrim( edtavUaassociatefunctionalities_Title));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLENAME_Activeeventkey", StringUtil.RTrim( Ddo_secrolename_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLENAME_Filteredtext_get", StringUtil.RTrim( Ddo_secrolename_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLENAME_Selectedvalue_get", StringUtil.RTrim( Ddo_secrolename_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLEDESCRIPTION_Activeeventkey", StringUtil.RTrim( Ddo_secroledescription_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLEDESCRIPTION_Filteredtext_get", StringUtil.RTrim( Ddo_secroledescription_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_SECROLEDESCRIPTION_Selectedvalue_get", StringUtil.RTrim( Ddo_secroledescription_Selectedvalue_get));
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
            WE0I2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0I2( ) ;
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
         return formatLink("wwpbaseobjects.secroleww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "WWPBaseObjects.SecRoleWW" ;
      }

      public override String GetPgmdesc( )
      {
         return "Work With Role" ;
      }

      protected void WB0I0( )
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
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(28), 2, 0)+","+"null"+");", "新增", bttBtninsert_Jsonclick, 5, "插入", "", StyleString, ClassString, bttBtninsert_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\SecRoleWW.htm");
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavUaassociatefunctionalities_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( edtavUaassociatefunctionalities_Title) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "编号") ;
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
               GridContainer.AddObjectProperty("CmpContext", "");
               GridContainer.AddObjectProperty("InMasterPage", "false");
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV95Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV13Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV98deleteRole));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDeleterole_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV97RoleAssociateUsers));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavRoleassociateusers_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavRoleassociateusers_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV36UAAssociateFunctionalities));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtavUaassociatefunctionalities_Title));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUaassociatefunctionalities_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUaassociatefunctionalities_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUaassociatefunctionalities_Visible), 5, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV91GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV94GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV93GridPageSize);
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
            ucDdo_secrolename.SetProperty("DropDownOptionsTitleSettingsIcons", AV80DDO_TitleSettingsIcons);
            ucDdo_secrolename.SetProperty("DropDownOptionsData", AV72SecRoleNameTitleFilterData);
            ucDdo_secrolename.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_secrolename_Internalname, "DDO_SECROLENAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_secrolenametitlecontrolidtoreplace_Internalname, AV75ddo_SecRoleNameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"", 0, edtavDdo_secrolenametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WWPBaseObjects\\SecRoleWW.htm");
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
            ucDdo_secroledescription.SetProperty("DropDownOptionsTitleSettingsIcons", AV80DDO_TitleSettingsIcons);
            ucDdo_secroledescription.SetProperty("DropDownOptionsData", AV76SecRoleDescriptionTitleFilterData);
            ucDdo_secroledescription.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_secroledescription_Internalname, "DDO_SECROLEDESCRIPTIONContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_secroledescriptiontitlecontrolidtoreplace_Internalname, AV79ddo_SecRoleDescriptionTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,47);\"", 0, edtavDdo_secroledescriptiontitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WWPBaseObjects\\SecRoleWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV46OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV46OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WWPBaseObjects\\SecRoleWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV47OrderedDsc), StringUtil.BoolToStr( AV47OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_WWPBaseObjects\\SecRoleWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfsecrolename_Internalname, AV73TFSecRoleName, StringUtil.RTrim( context.localUtil.Format( AV73TFSecRoleName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfsecrolename_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfsecrolename_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecRoleWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfsecrolename_sel_Internalname, AV74TFSecRoleName_Sel, StringUtil.RTrim( context.localUtil.Format( AV74TFSecRoleName_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfsecrolename_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfsecrolename_sel_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecRoleWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfsecroledescription_Internalname, AV77TFSecRoleDescription, StringUtil.RTrim( context.localUtil.Format( AV77TFSecRoleDescription, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfsecroledescription_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfsecroledescription_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecRoleWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfsecroledescription_sel_Internalname, AV78TFSecRoleDescription_Sel, StringUtil.RTrim( context.localUtil.Format( AV78TFSecRoleDescription_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfsecroledescription_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfsecroledescription_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecRoleWW.htm");
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

      protected void START0I2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "Work With Role", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0I0( ) ;
      }

      protected void WS0I2( )
      {
         START0I2( ) ;
         EVT0I2( ) ;
      }

      protected void EVT0I2( )
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
                              E110I2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E120I2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_SECROLENAME.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E130I2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_SECROLEDESCRIPTION.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E140I2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E150I2 ();
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
                              AV95Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV95Display)) ? AV105Display_GXI : context.convertURL( context.PathToRelativeUrl( AV95Display))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV95Display), true);
                              AV13Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV13Update)) ? AV106Update_GXI : context.convertURL( context.PathToRelativeUrl( AV13Update))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV13Update), true);
                              AV98deleteRole = cgiGet( edtavDeleterole_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDeleterole_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV98deleteRole)) ? AV107Deleterole_GXI : context.convertURL( context.PathToRelativeUrl( AV98deleteRole))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDeleterole_Internalname, "SrcSet", context.GetImageSrcSet( AV98deleteRole), true);
                              AV97RoleAssociateUsers = cgiGet( edtavRoleassociateusers_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavRoleassociateusers_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV97RoleAssociateUsers)) ? AV108Roleassociateusers_GXI : context.convertURL( context.PathToRelativeUrl( AV97RoleAssociateUsers))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavRoleassociateusers_Internalname, "SrcSet", context.GetImageSrcSet( AV97RoleAssociateUsers), true);
                              AV36UAAssociateFunctionalities = cgiGet( edtavUaassociatefunctionalities_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUaassociatefunctionalities_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV36UAAssociateFunctionalities)) ? AV109Uaassociatefunctionalities_GXI : context.convertURL( context.PathToRelativeUrl( AV36UAAssociateFunctionalities))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUaassociatefunctionalities_Internalname, "SrcSet", context.GetImageSrcSet( AV36UAAssociateFunctionalities), true);
                              A4SecRoleId = (short)(context.localUtil.CToN( cgiGet( edtSecRoleId_Internalname), ".", ","));
                              A13SecRoleName = cgiGet( edtSecRoleName_Internalname);
                              A12SecRoleDescription = cgiGet( edtSecRoleDescription_Internalname);
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E160I2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E170I2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E180I2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Orderedby Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV46OrderedBy )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ordereddsc Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV47OrderedDsc )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfsecrolename Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFSECROLENAME"), AV73TFSecRoleName) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfsecrolename_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFSECROLENAME_SEL"), AV74TFSecRoleName_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfsecroledescription Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFSECROLEDESCRIPTION"), AV77TFSecRoleDescription) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfsecroledescription_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFSECROLEDESCRIPTION_SEL"), AV78TFSecRoleDescription_Sel) != 0 )
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

      protected void WE0I2( )
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

      protected void PA0I2( )
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
               GX_FocusControl = edtavDdo_secrolenametitlecontrolidtoreplace_Internalname;
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

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV46OrderedBy ,
                                       bool AV47OrderedDsc ,
                                       String AV73TFSecRoleName ,
                                       String AV74TFSecRoleName_Sel ,
                                       String AV77TFSecRoleDescription ,
                                       String AV78TFSecRoleDescription_Sel ,
                                       String AV75ddo_SecRoleNameTitleControlIdToReplace ,
                                       String AV79ddo_SecRoleDescriptionTitleControlIdToReplace ,
                                       String AV110Pgmname ,
                                       bool AV39IsAuthorized_Update ,
                                       bool AV37IsAuthorized_UAAssociateFunctionalities )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF0I2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_SECROLEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A4SecRoleId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "SECROLEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A4SecRoleId), 4, 0, ".", "")));
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
         RF0I2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV110Pgmname = "WWPBaseObjects.SecRoleWW";
         context.Gx_err = 0;
      }

      protected void RF0I2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 28;
         /* Execute user event: Refresh */
         E170I2 ();
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
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV102WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel ,
                                                 AV101WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename ,
                                                 AV104WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel ,
                                                 AV103WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription ,
                                                 A13SecRoleName ,
                                                 A12SecRoleDescription ,
                                                 AV46OrderedBy ,
                                                 AV47OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV101WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename = StringUtil.Concat( StringUtil.RTrim( AV101WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename), "%", "");
            lV103WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription = StringUtil.Concat( StringUtil.RTrim( AV103WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription), "%", "");
            /* Using cursor H000I2 */
            pr_default.execute(0, new Object[] {lV101WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename, AV102WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel, lV103WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription, AV104WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_28_idx = 1;
            sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
            SubsflControlProps_282( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A12SecRoleDescription = H000I2_A12SecRoleDescription[0];
               A13SecRoleName = H000I2_A13SecRoleName[0];
               A4SecRoleId = H000I2_A4SecRoleId[0];
               E180I2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 28;
            WB0I0( ) ;
         }
         bGXsfl_28_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes0I2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_SECROLEID"+"_"+sGXsfl_28_idx, GetSecureSignedToken( sGXsfl_28_idx, context.localUtil.Format( (decimal)(A4SecRoleId), "ZZZ9"), context));
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
         AV101WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename = AV73TFSecRoleName;
         AV102WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel = AV74TFSecRoleName_Sel;
         AV103WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription = AV77TFSecRoleDescription;
         AV104WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel = AV78TFSecRoleDescription_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV102WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel ,
                                              AV101WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename ,
                                              AV104WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel ,
                                              AV103WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription ,
                                              A13SecRoleName ,
                                              A12SecRoleDescription ,
                                              AV46OrderedBy ,
                                              AV47OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV101WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename = StringUtil.Concat( StringUtil.RTrim( AV101WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename), "%", "");
         lV103WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription = StringUtil.Concat( StringUtil.RTrim( AV103WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription), "%", "");
         /* Using cursor H000I3 */
         pr_default.execute(1, new Object[] {lV101WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename, AV102WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel, lV103WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription, AV104WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel});
         GRID_nRecordCount = H000I3_AGRID_nRecordCount[0];
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
         AV101WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename = AV73TFSecRoleName;
         AV102WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel = AV74TFSecRoleName_Sel;
         AV103WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription = AV77TFSecRoleDescription;
         AV104WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel = AV78TFSecRoleDescription_Sel;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV46OrderedBy, AV47OrderedDsc, AV73TFSecRoleName, AV74TFSecRoleName_Sel, AV77TFSecRoleDescription, AV78TFSecRoleDescription_Sel, AV75ddo_SecRoleNameTitleControlIdToReplace, AV79ddo_SecRoleDescriptionTitleControlIdToReplace, AV110Pgmname, AV39IsAuthorized_Update, AV37IsAuthorized_UAAssociateFunctionalities) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV101WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename = AV73TFSecRoleName;
         AV102WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel = AV74TFSecRoleName_Sel;
         AV103WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription = AV77TFSecRoleDescription;
         AV104WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel = AV78TFSecRoleDescription_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV46OrderedBy, AV47OrderedDsc, AV73TFSecRoleName, AV74TFSecRoleName_Sel, AV77TFSecRoleDescription, AV78TFSecRoleDescription_Sel, AV75ddo_SecRoleNameTitleControlIdToReplace, AV79ddo_SecRoleDescriptionTitleControlIdToReplace, AV110Pgmname, AV39IsAuthorized_Update, AV37IsAuthorized_UAAssociateFunctionalities) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV101WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename = AV73TFSecRoleName;
         AV102WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel = AV74TFSecRoleName_Sel;
         AV103WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription = AV77TFSecRoleDescription;
         AV104WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel = AV78TFSecRoleDescription_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV46OrderedBy, AV47OrderedDsc, AV73TFSecRoleName, AV74TFSecRoleName_Sel, AV77TFSecRoleDescription, AV78TFSecRoleDescription_Sel, AV75ddo_SecRoleNameTitleControlIdToReplace, AV79ddo_SecRoleDescriptionTitleControlIdToReplace, AV110Pgmname, AV39IsAuthorized_Update, AV37IsAuthorized_UAAssociateFunctionalities) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV101WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename = AV73TFSecRoleName;
         AV102WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel = AV74TFSecRoleName_Sel;
         AV103WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription = AV77TFSecRoleDescription;
         AV104WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel = AV78TFSecRoleDescription_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV46OrderedBy, AV47OrderedDsc, AV73TFSecRoleName, AV74TFSecRoleName_Sel, AV77TFSecRoleDescription, AV78TFSecRoleDescription_Sel, AV75ddo_SecRoleNameTitleControlIdToReplace, AV79ddo_SecRoleDescriptionTitleControlIdToReplace, AV110Pgmname, AV39IsAuthorized_Update, AV37IsAuthorized_UAAssociateFunctionalities) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV101WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename = AV73TFSecRoleName;
         AV102WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel = AV74TFSecRoleName_Sel;
         AV103WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription = AV77TFSecRoleDescription;
         AV104WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel = AV78TFSecRoleDescription_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV46OrderedBy, AV47OrderedDsc, AV73TFSecRoleName, AV74TFSecRoleName_Sel, AV77TFSecRoleDescription, AV78TFSecRoleDescription_Sel, AV75ddo_SecRoleNameTitleControlIdToReplace, AV79ddo_SecRoleDescriptionTitleControlIdToReplace, AV110Pgmname, AV39IsAuthorized_Update, AV37IsAuthorized_UAAssociateFunctionalities) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP0I0( )
      {
         /* Before Start, stand alone formulas. */
         AV110Pgmname = "WWPBaseObjects.SecRoleWW";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E160I2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV80DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vSECROLENAMETITLEFILTERDATA"), AV72SecRoleNameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vSECROLEDESCRIPTIONTITLEFILTERDATA"), AV76SecRoleDescriptionTitleFilterData);
            /* Read variables values. */
            AV75ddo_SecRoleNameTitleControlIdToReplace = cgiGet( edtavDdo_secrolenametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV75ddo_SecRoleNameTitleControlIdToReplace", AV75ddo_SecRoleNameTitleControlIdToReplace);
            AV79ddo_SecRoleDescriptionTitleControlIdToReplace = cgiGet( edtavDdo_secroledescriptiontitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV79ddo_SecRoleDescriptionTitleControlIdToReplace", AV79ddo_SecRoleDescriptionTitleControlIdToReplace);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDEREDBY");
               GX_FocusControl = edtavOrderedby_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV46OrderedBy = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV46OrderedBy), 4, 0)));
            }
            else
            {
               AV46OrderedBy = (short)(context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV46OrderedBy), 4, 0)));
            }
            AV47OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47OrderedDsc", AV47OrderedDsc);
            AV73TFSecRoleName = cgiGet( edtavTfsecrolename_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV73TFSecRoleName", AV73TFSecRoleName);
            AV74TFSecRoleName_Sel = cgiGet( edtavTfsecrolename_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV74TFSecRoleName_Sel", AV74TFSecRoleName_Sel);
            AV77TFSecRoleDescription = cgiGet( edtavTfsecroledescription_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV77TFSecRoleDescription", AV77TFSecRoleDescription);
            AV78TFSecRoleDescription_Sel = cgiGet( edtavTfsecroledescription_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV78TFSecRoleDescription_Sel", AV78TFSecRoleDescription_Sel);
            /* Read saved values. */
            nRC_GXsfl_28 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_28"), ".", ","));
            AV91GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV94GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV93GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_secrolename_Caption = cgiGet( "DDO_SECROLENAME_Caption");
            Ddo_secrolename_Tooltip = cgiGet( "DDO_SECROLENAME_Tooltip");
            Ddo_secrolename_Cls = cgiGet( "DDO_SECROLENAME_Cls");
            Ddo_secrolename_Filteredtext_set = cgiGet( "DDO_SECROLENAME_Filteredtext_set");
            Ddo_secrolename_Selectedvalue_set = cgiGet( "DDO_SECROLENAME_Selectedvalue_set");
            Ddo_secrolename_Dropdownoptionstype = cgiGet( "DDO_SECROLENAME_Dropdownoptionstype");
            Ddo_secrolename_Titlecontrolidtoreplace = cgiGet( "DDO_SECROLENAME_Titlecontrolidtoreplace");
            Ddo_secrolename_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_SECROLENAME_Includesortasc"));
            Ddo_secrolename_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_SECROLENAME_Includesortdsc"));
            Ddo_secrolename_Sortedstatus = cgiGet( "DDO_SECROLENAME_Sortedstatus");
            Ddo_secrolename_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_SECROLENAME_Includefilter"));
            Ddo_secrolename_Filtertype = cgiGet( "DDO_SECROLENAME_Filtertype");
            Ddo_secrolename_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_SECROLENAME_Filterisrange"));
            Ddo_secrolename_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_SECROLENAME_Includedatalist"));
            Ddo_secrolename_Datalisttype = cgiGet( "DDO_SECROLENAME_Datalisttype");
            Ddo_secrolename_Datalistproc = cgiGet( "DDO_SECROLENAME_Datalistproc");
            Ddo_secrolename_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_SECROLENAME_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_secrolename_Sortasc = cgiGet( "DDO_SECROLENAME_Sortasc");
            Ddo_secrolename_Sortdsc = cgiGet( "DDO_SECROLENAME_Sortdsc");
            Ddo_secrolename_Loadingdata = cgiGet( "DDO_SECROLENAME_Loadingdata");
            Ddo_secrolename_Cleanfilter = cgiGet( "DDO_SECROLENAME_Cleanfilter");
            Ddo_secrolename_Noresultsfound = cgiGet( "DDO_SECROLENAME_Noresultsfound");
            Ddo_secrolename_Searchbuttontext = cgiGet( "DDO_SECROLENAME_Searchbuttontext");
            Ddo_secroledescription_Caption = cgiGet( "DDO_SECROLEDESCRIPTION_Caption");
            Ddo_secroledescription_Tooltip = cgiGet( "DDO_SECROLEDESCRIPTION_Tooltip");
            Ddo_secroledescription_Cls = cgiGet( "DDO_SECROLEDESCRIPTION_Cls");
            Ddo_secroledescription_Filteredtext_set = cgiGet( "DDO_SECROLEDESCRIPTION_Filteredtext_set");
            Ddo_secroledescription_Selectedvalue_set = cgiGet( "DDO_SECROLEDESCRIPTION_Selectedvalue_set");
            Ddo_secroledescription_Dropdownoptionstype = cgiGet( "DDO_SECROLEDESCRIPTION_Dropdownoptionstype");
            Ddo_secroledescription_Titlecontrolidtoreplace = cgiGet( "DDO_SECROLEDESCRIPTION_Titlecontrolidtoreplace");
            Ddo_secroledescription_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_SECROLEDESCRIPTION_Includesortasc"));
            Ddo_secroledescription_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_SECROLEDESCRIPTION_Includesortdsc"));
            Ddo_secroledescription_Sortedstatus = cgiGet( "DDO_SECROLEDESCRIPTION_Sortedstatus");
            Ddo_secroledescription_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_SECROLEDESCRIPTION_Includefilter"));
            Ddo_secroledescription_Filtertype = cgiGet( "DDO_SECROLEDESCRIPTION_Filtertype");
            Ddo_secroledescription_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_SECROLEDESCRIPTION_Filterisrange"));
            Ddo_secroledescription_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_SECROLEDESCRIPTION_Includedatalist"));
            Ddo_secroledescription_Datalisttype = cgiGet( "DDO_SECROLEDESCRIPTION_Datalisttype");
            Ddo_secroledescription_Datalistproc = cgiGet( "DDO_SECROLEDESCRIPTION_Datalistproc");
            Ddo_secroledescription_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_SECROLEDESCRIPTION_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_secroledescription_Sortasc = cgiGet( "DDO_SECROLEDESCRIPTION_Sortasc");
            Ddo_secroledescription_Sortdsc = cgiGet( "DDO_SECROLEDESCRIPTION_Sortdsc");
            Ddo_secroledescription_Loadingdata = cgiGet( "DDO_SECROLEDESCRIPTION_Loadingdata");
            Ddo_secroledescription_Cleanfilter = cgiGet( "DDO_SECROLEDESCRIPTION_Cleanfilter");
            Ddo_secroledescription_Noresultsfound = cgiGet( "DDO_SECROLEDESCRIPTION_Noresultsfound");
            Ddo_secroledescription_Searchbuttontext = cgiGet( "DDO_SECROLEDESCRIPTION_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_secrolename_Activeeventkey = cgiGet( "DDO_SECROLENAME_Activeeventkey");
            Ddo_secrolename_Filteredtext_get = cgiGet( "DDO_SECROLENAME_Filteredtext_get");
            Ddo_secrolename_Selectedvalue_get = cgiGet( "DDO_SECROLENAME_Selectedvalue_get");
            Ddo_secroledescription_Activeeventkey = cgiGet( "DDO_SECROLEDESCRIPTION_Activeeventkey");
            Ddo_secroledescription_Filteredtext_get = cgiGet( "DDO_SECROLEDESCRIPTION_Filteredtext_get");
            Ddo_secroledescription_Selectedvalue_get = cgiGet( "DDO_SECROLEDESCRIPTION_Selectedvalue_get");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV46OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV47OrderedDsc )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFSECROLENAME"), AV73TFSecRoleName) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFSECROLENAME_SEL"), AV74TFSecRoleName_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFSECROLEDESCRIPTION"), AV77TFSecRoleDescription) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFSECROLEDESCRIPTION_SEL"), AV78TFSecRoleDescription_Sel) != 0 )
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
         E160I2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E160I2( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         edtavTfsecrolename_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfsecrolename_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfsecrolename_Visible), 5, 0)), true);
         edtavTfsecrolename_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfsecrolename_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfsecrolename_sel_Visible), 5, 0)), true);
         edtavTfsecroledescription_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfsecroledescription_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfsecroledescription_Visible), 5, 0)), true);
         edtavTfsecroledescription_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfsecroledescription_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfsecroledescription_sel_Visible), 5, 0)), true);
         Ddo_secrolename_Titlecontrolidtoreplace = subGrid_Internalname+"_SecRoleName";
         ucDdo_secrolename.SendProperty(context, "", false, Ddo_secrolename_Internalname, "TitleControlIdToReplace", Ddo_secrolename_Titlecontrolidtoreplace);
         AV75ddo_SecRoleNameTitleControlIdToReplace = Ddo_secrolename_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV75ddo_SecRoleNameTitleControlIdToReplace", AV75ddo_SecRoleNameTitleControlIdToReplace);
         edtavDdo_secrolenametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_secrolenametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_secrolenametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_secroledescription_Titlecontrolidtoreplace = subGrid_Internalname+"_SecRoleDescription";
         ucDdo_secroledescription.SendProperty(context, "", false, Ddo_secroledescription_Internalname, "TitleControlIdToReplace", Ddo_secroledescription_Titlecontrolidtoreplace);
         AV79ddo_SecRoleDescriptionTitleControlIdToReplace = Ddo_secroledescription_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV79ddo_SecRoleDescriptionTitleControlIdToReplace", AV79ddo_SecRoleDescriptionTitleControlIdToReplace);
         edtavDdo_secroledescriptiontitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_secroledescriptiontitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_secroledescriptiontitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " 角色列表";
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
         if ( AV46OrderedBy < 1 )
         {
            AV46OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV46OrderedBy), 4, 0)));
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV80DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV80DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
         edtavUaassociatefunctionalities_Title = "Permissions";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUaassociatefunctionalities_Internalname, "Title", edtavUaassociatefunctionalities_Title, !bGXsfl_28_Refreshing);
      }

      protected void E170I2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV72SecRoleNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV76SecRoleDescriptionTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV89WWPContext) ;
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
         edtSecRoleName_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "名称", AV75ddo_SecRoleNameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecRoleName_Internalname, "Title", edtSecRoleName_Title, !bGXsfl_28_Refreshing);
         edtSecRoleDescription_Titleformat = 2;
         edtSecRoleDescription_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "描述", AV79ddo_SecRoleDescriptionTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecRoleDescription_Internalname, "Title", edtSecRoleDescription_Title, !bGXsfl_28_Refreshing);
         AV91GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV91GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV91GridCurrentPage), 10, 0)));
         AV93GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV93GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV93GridPageSize), 10, 0)));
         AV94GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV94GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV94GridRecordCount), 10, 0)));
         AV101WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename = AV73TFSecRoleName;
         AV102WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel = AV74TFSecRoleName_Sel;
         AV103WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription = AV77TFSecRoleDescription;
         AV104WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel = AV78TFSecRoleDescription_Sel;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV72SecRoleNameTitleFilterData", AV72SecRoleNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV76SecRoleDescriptionTitleFilterData", AV76SecRoleDescriptionTitleFilterData);
      }

      protected void E110I2( )
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
            AV90PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV90PageToGo) ;
         }
      }

      protected void E120I2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E130I2( )
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
            AV46OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV46OrderedBy), 4, 0)));
            AV47OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47OrderedDsc", AV47OrderedDsc);
            Ddo_secrolename_Sortedstatus = "ASC";
            ucDdo_secrolename.SendProperty(context, "", false, Ddo_secrolename_Internalname, "SortedStatus", Ddo_secrolename_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
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
            AV46OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV46OrderedBy), 4, 0)));
            AV47OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47OrderedDsc", AV47OrderedDsc);
            Ddo_secrolename_Sortedstatus = "DSC";
            ucDdo_secrolename.SendProperty(context, "", false, Ddo_secrolename_Internalname, "SortedStatus", Ddo_secrolename_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_secrolename_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV73TFSecRoleName = Ddo_secrolename_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV73TFSecRoleName", AV73TFSecRoleName);
            AV74TFSecRoleName_Sel = Ddo_secrolename_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV74TFSecRoleName_Sel", AV74TFSecRoleName_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV72SecRoleNameTitleFilterData", AV72SecRoleNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV76SecRoleDescriptionTitleFilterData", AV76SecRoleDescriptionTitleFilterData);
      }

      protected void E140I2( )
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
            AV46OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV46OrderedBy), 4, 0)));
            AV47OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47OrderedDsc", AV47OrderedDsc);
            Ddo_secroledescription_Sortedstatus = "ASC";
            ucDdo_secroledescription.SendProperty(context, "", false, Ddo_secroledescription_Internalname, "SortedStatus", Ddo_secroledescription_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
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
            AV46OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV46OrderedBy), 4, 0)));
            AV47OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47OrderedDsc", AV47OrderedDsc);
            Ddo_secroledescription_Sortedstatus = "DSC";
            ucDdo_secroledescription.SendProperty(context, "", false, Ddo_secroledescription_Internalname, "SortedStatus", Ddo_secroledescription_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_secroledescription_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV77TFSecRoleDescription = Ddo_secroledescription_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV77TFSecRoleDescription", AV77TFSecRoleDescription);
            AV78TFSecRoleDescription_Sel = Ddo_secroledescription_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV78TFSecRoleDescription_Sel", AV78TFSecRoleDescription_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV72SecRoleNameTitleFilterData", AV72SecRoleNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV76SecRoleDescriptionTitleFilterData", AV76SecRoleDescriptionTitleFilterData);
      }

      private void E180I2( )
      {
         /* Grid_Load Routine */
         AV95Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDisplay_Internalname, AV95Display);
         AV105Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = formatLink("wwpbaseobjects.secroleview.aspx") + "?" + UrlEncode("" +A4SecRoleId) + "," + UrlEncode(StringUtil.RTrim(""));
         AV13Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV13Update);
         AV106Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavUpdate_Tooltiptext = "修改";
         if ( AV39IsAuthorized_Update )
         {
            edtavUpdate_Link = formatLink("wwpbaseobjects.secrole.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A4SecRoleId);
         }
         AV98deleteRole = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDeleterole_Internalname, AV98deleteRole);
         AV107Deleterole_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavDeleterole_Tooltiptext = "";
         AV97RoleAssociateUsers = context.GetImagePath( "5fe91247-fb4b-43c1-8f7d-1064913f323d", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavRoleassociateusers_Internalname, AV97RoleAssociateUsers);
         AV108Roleassociateusers_GXI = GXDbFile.PathToUrl( context.GetImagePath( "5fe91247-fb4b-43c1-8f7d-1064913f323d", "", context.GetTheme( )));
         edtavRoleassociateusers_Tooltiptext = "";
         edtavRoleassociateusers_Link = formatLink("wwpbaseobjects.secrolesecuserroleassociationww.aspx") + "?" + UrlEncode("" +A4SecRoleId);
         AV36UAAssociateFunctionalities = context.GetImagePath( "262dee5c-db77-4c22-a7be-798351973470", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUaassociatefunctionalities_Internalname, AV36UAAssociateFunctionalities);
         AV109Uaassociatefunctionalities_GXI = GXDbFile.PathToUrl( context.GetImagePath( "262dee5c-db77-4c22-a7be-798351973470", "", context.GetTheme( )));
         edtavUaassociatefunctionalities_Tooltiptext = "";
         if ( AV37IsAuthorized_UAAssociateFunctionalities )
         {
            edtavUaassociatefunctionalities_Link = formatLink("wwpbaseobjects.secrolefunroleassociationww.aspx") + "?" + UrlEncode("" +A4SecRoleId);
         }
         edtSecRoleName_Link = formatLink("wwpbaseobjects.secroleview.aspx") + "?" + UrlEncode("" +A4SecRoleId) + "," + UrlEncode(StringUtil.RTrim(""));
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

      protected void E150I2( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("wwpbaseobjects.secrole.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S162( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_secrolename_Sortedstatus = "";
         ucDdo_secrolename.SendProperty(context, "", false, Ddo_secrolename_Internalname, "SortedStatus", Ddo_secrolename_Sortedstatus);
         Ddo_secroledescription_Sortedstatus = "";
         ucDdo_secroledescription.SendProperty(context, "", false, Ddo_secroledescription_Internalname, "SortedStatus", Ddo_secroledescription_Sortedstatus);
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
         if ( AV46OrderedBy == 2 )
         {
            Ddo_secrolename_Sortedstatus = (AV47OrderedDsc ? "DSC" : "ASC");
            ucDdo_secrolename.SendProperty(context, "", false, Ddo_secrolename_Internalname, "SortedStatus", Ddo_secrolename_Sortedstatus);
         }
         else if ( AV46OrderedBy == 3 )
         {
            Ddo_secroledescription_Sortedstatus = (AV47OrderedDsc ? "DSC" : "ASC");
            ucDdo_secroledescription.SendProperty(context, "", false, Ddo_secroledescription_Internalname, "SortedStatus", Ddo_secroledescription_Sortedstatus);
         }
      }

      protected void S142( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean2 = AV39IsAuthorized_Update;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "RoleModes", out  GXt_boolean2) ;
         AV39IsAuthorized_Update = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39IsAuthorized_Update", AV39IsAuthorized_Update);
         if ( ! ( AV39IsAuthorized_Update ) )
         {
            edtavUpdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         }
         GXt_boolean2 = AV37IsAuthorized_UAAssociateFunctionalities;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "RoleAssignFunctionalities", out  GXt_boolean2) ;
         AV37IsAuthorized_UAAssociateFunctionalities = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37IsAuthorized_UAAssociateFunctionalities", AV37IsAuthorized_UAAssociateFunctionalities);
         if ( ! ( AV37IsAuthorized_UAAssociateFunctionalities ) )
         {
            edtavUaassociatefunctionalities_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUaassociatefunctionalities_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUaassociatefunctionalities_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         }
         GXt_boolean2 = AV38TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "RoleModes", out  GXt_boolean2) ;
         AV38TempBoolean = GXt_boolean2;
         if ( ! ( AV38TempBoolean ) )
         {
            bttBtninsert_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtninsert_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtninsert_Visible), 5, 0)), true);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV15Session.Get(AV110Pgmname+"GridState"), "") == 0 )
         {
            AV43GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV110Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV43GridState.FromXml(AV15Session.Get(AV110Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV46OrderedBy = AV43GridState.gxTpr_Orderedby;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV46OrderedBy), 4, 0)));
         AV47OrderedDsc = AV43GridState.gxTpr_Ordereddsc;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47OrderedDsc", AV47OrderedDsc);
         /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV111GXV1 = 1;
         while ( AV111GXV1 <= AV43GridState.gxTpr_Filtervalues.Count )
         {
            AV44GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV43GridState.gxTpr_Filtervalues.Item(AV111GXV1));
            if ( StringUtil.StrCmp(AV44GridStateFilterValue.gxTpr_Name, "TFSECROLENAME") == 0 )
            {
               AV73TFSecRoleName = AV44GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV73TFSecRoleName", AV73TFSecRoleName);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV73TFSecRoleName)) )
               {
                  Ddo_secrolename_Filteredtext_set = AV73TFSecRoleName;
                  ucDdo_secrolename.SendProperty(context, "", false, Ddo_secrolename_Internalname, "FilteredText_set", Ddo_secrolename_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV44GridStateFilterValue.gxTpr_Name, "TFSECROLENAME_SEL") == 0 )
            {
               AV74TFSecRoleName_Sel = AV44GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV74TFSecRoleName_Sel", AV74TFSecRoleName_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV74TFSecRoleName_Sel)) )
               {
                  Ddo_secrolename_Selectedvalue_set = AV74TFSecRoleName_Sel;
                  ucDdo_secrolename.SendProperty(context, "", false, Ddo_secrolename_Internalname, "SelectedValue_set", Ddo_secrolename_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV44GridStateFilterValue.gxTpr_Name, "TFSECROLEDESCRIPTION") == 0 )
            {
               AV77TFSecRoleDescription = AV44GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV77TFSecRoleDescription", AV77TFSecRoleDescription);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV77TFSecRoleDescription)) )
               {
                  Ddo_secroledescription_Filteredtext_set = AV77TFSecRoleDescription;
                  ucDdo_secroledescription.SendProperty(context, "", false, Ddo_secroledescription_Internalname, "FilteredText_set", Ddo_secroledescription_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV44GridStateFilterValue.gxTpr_Name, "TFSECROLEDESCRIPTION_SEL") == 0 )
            {
               AV78TFSecRoleDescription_Sel = AV44GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV78TFSecRoleDescription_Sel", AV78TFSecRoleDescription_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV78TFSecRoleDescription_Sel)) )
               {
                  Ddo_secroledescription_Selectedvalue_set = AV78TFSecRoleDescription_Sel;
                  ucDdo_secroledescription.SendProperty(context, "", false, Ddo_secroledescription_Internalname, "SelectedValue_set", Ddo_secroledescription_Selectedvalue_set);
               }
            }
            AV111GXV1 = (int)(AV111GXV1+1);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV43GridState.gxTpr_Pagesize))) )
         {
            subGrid_Rows = (int)(NumberUtil.Val( AV43GridState.gxTpr_Pagesize, "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         }
         subgrid_gotopage( AV43GridState.gxTpr_Currentpage) ;
      }

      protected void S152( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV43GridState.FromXml(AV15Session.Get(AV110Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV43GridState.gxTpr_Orderedby = AV46OrderedBy;
         AV43GridState.gxTpr_Ordereddsc = AV47OrderedDsc;
         AV43GridState.gxTpr_Filtervalues.Clear();
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV73TFSecRoleName)) )
         {
            AV44GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV44GridStateFilterValue.gxTpr_Name = "TFSECROLENAME";
            AV44GridStateFilterValue.gxTpr_Value = AV73TFSecRoleName;
            AV43GridState.gxTpr_Filtervalues.Add(AV44GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV74TFSecRoleName_Sel)) )
         {
            AV44GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV44GridStateFilterValue.gxTpr_Name = "TFSECROLENAME_SEL";
            AV44GridStateFilterValue.gxTpr_Value = AV74TFSecRoleName_Sel;
            AV43GridState.gxTpr_Filtervalues.Add(AV44GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV77TFSecRoleDescription)) )
         {
            AV44GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV44GridStateFilterValue.gxTpr_Name = "TFSECROLEDESCRIPTION";
            AV44GridStateFilterValue.gxTpr_Value = AV77TFSecRoleDescription;
            AV43GridState.gxTpr_Filtervalues.Add(AV44GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV78TFSecRoleDescription_Sel)) )
         {
            AV44GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV44GridStateFilterValue.gxTpr_Name = "TFSECROLEDESCRIPTION_SEL";
            AV44GridStateFilterValue.gxTpr_Value = AV78TFSecRoleDescription_Sel;
            AV43GridState.gxTpr_Filtervalues.Add(AV44GridStateFilterValue, 0);
         }
         AV43GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV43GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV110Pgmname+"GridState",  AV43GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV110Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "WWPBaseObjects.SecRole";
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
         PA0I2( ) ;
         WS0I2( ) ;
         WE0I2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279391555", true);
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
         context.AddJavascriptSource("wwpbaseobjects/secroleww.js", "?20202279391555", false);
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

      protected void SubsflControlProps_282( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_28_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_28_idx;
         edtavDeleterole_Internalname = "vDELETEROLE_"+sGXsfl_28_idx;
         edtavRoleassociateusers_Internalname = "vROLEASSOCIATEUSERS_"+sGXsfl_28_idx;
         edtavUaassociatefunctionalities_Internalname = "vUAASSOCIATEFUNCTIONALITIES_"+sGXsfl_28_idx;
         edtSecRoleId_Internalname = "SECROLEID_"+sGXsfl_28_idx;
         edtSecRoleName_Internalname = "SECROLENAME_"+sGXsfl_28_idx;
         edtSecRoleDescription_Internalname = "SECROLEDESCRIPTION_"+sGXsfl_28_idx;
      }

      protected void SubsflControlProps_fel_282( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_28_fel_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_28_fel_idx;
         edtavDeleterole_Internalname = "vDELETEROLE_"+sGXsfl_28_fel_idx;
         edtavRoleassociateusers_Internalname = "vROLEASSOCIATEUSERS_"+sGXsfl_28_fel_idx;
         edtavUaassociatefunctionalities_Internalname = "vUAASSOCIATEFUNCTIONALITIES_"+sGXsfl_28_fel_idx;
         edtSecRoleId_Internalname = "SECROLEID_"+sGXsfl_28_fel_idx;
         edtSecRoleName_Internalname = "SECROLENAME_"+sGXsfl_28_fel_idx;
         edtSecRoleDescription_Internalname = "SECROLEDESCRIPTION_"+sGXsfl_28_fel_idx;
      }

      protected void sendrow_282( )
      {
         SubsflControlProps_282( ) ;
         WB0I0( ) ;
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
            AV95Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV95Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV105Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV95Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV95Display)) ? AV105Display_GXI : context.PathToRelativeUrl( AV95Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV95Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV13Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV13Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV106Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV13Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV13Update)) ? AV106Update_GXI : context.PathToRelativeUrl( AV13Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavUpdate_Visible,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV13Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavDeleterole_Enabled!=0)&&(edtavDeleterole_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 31,'',false,'',28)\"" : " ");
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV98deleteRole_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV98deleteRole))&&String.IsNullOrEmpty(StringUtil.RTrim( AV107Deleterole_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV98deleteRole)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV98deleteRole)) ? AV107Deleterole_GXI : context.PathToRelativeUrl( AV98deleteRole));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDeleterole_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDeleterole_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)7,(String)edtavDeleterole_Jsonclick,(String)"'"+""+"'"+",false,"+"'"+"e190i2_client"+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV98deleteRole_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV97RoleAssociateUsers_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV97RoleAssociateUsers))&&String.IsNullOrEmpty(StringUtil.RTrim( AV108Roleassociateusers_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV97RoleAssociateUsers)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV97RoleAssociateUsers)) ? AV108Roleassociateusers_GXI : context.PathToRelativeUrl( AV97RoleAssociateUsers));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavRoleassociateusers_Internalname,(String)sImgUrl,(String)edtavRoleassociateusers_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavRoleassociateusers_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV97RoleAssociateUsers_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavUaassociatefunctionalities_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV36UAAssociateFunctionalities_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV36UAAssociateFunctionalities))&&String.IsNullOrEmpty(StringUtil.RTrim( AV109Uaassociatefunctionalities_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV36UAAssociateFunctionalities)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV36UAAssociateFunctionalities)) ? AV109Uaassociatefunctionalities_GXI : context.PathToRelativeUrl( AV36UAAssociateFunctionalities));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUaassociatefunctionalities_Internalname,(String)sImgUrl,(String)edtavUaassociatefunctionalities_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavUaassociatefunctionalities_Visible,(short)1,(String)"",(String)edtavUaassociatefunctionalities_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV36UAAssociateFunctionalities_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecRoleId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A4SecRoleId), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A4SecRoleId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSecRoleId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecRoleName_Internalname,(String)A13SecRoleName,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtSecRoleName_Link,(String)"",(String)"",(String)"",(String)edtSecRoleName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecRoleDescription_Internalname,(String)A12SecRoleDescription,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSecRoleDescription_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)120,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes0I2( ) ;
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
         bttBtninsert_Internalname = "BTNINSERT";
         divTableactions_Internalname = "TABLEACTIONS";
         divTableheader_Internalname = "TABLEHEADER";
         divLayout_tableheader_Internalname = "LAYOUT_TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         divHtml_dvpanel_tableheader_Internalname = "HTML_DVPANEL_TABLEHEADER";
         edtavDisplay_Internalname = "vDISPLAY";
         edtavUpdate_Internalname = "vUPDATE";
         edtavDeleterole_Internalname = "vDELETEROLE";
         edtavRoleassociateusers_Internalname = "vROLEASSOCIATEUSERS";
         edtavUaassociatefunctionalities_Internalname = "vUAASSOCIATEFUNCTIONALITIES";
         edtSecRoleId_Internalname = "SECROLEID";
         edtSecRoleName_Internalname = "SECROLENAME";
         edtSecRoleDescription_Internalname = "SECROLEDESCRIPTION";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_secrolename_Internalname = "DDO_SECROLENAME";
         edtavDdo_secrolenametitlecontrolidtoreplace_Internalname = "vDDO_SECROLENAMETITLECONTROLIDTOREPLACE";
         Ddo_secroledescription_Internalname = "DDO_SECROLEDESCRIPTION";
         edtavDdo_secroledescriptiontitlecontrolidtoreplace_Internalname = "vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         edtavTfsecrolename_Internalname = "vTFSECROLENAME";
         edtavTfsecrolename_sel_Internalname = "vTFSECROLENAME_SEL";
         edtavTfsecroledescription_Internalname = "vTFSECROLEDESCRIPTION";
         edtavTfsecroledescription_sel_Internalname = "vTFSECROLEDESCRIPTION_SEL";
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
         edtSecRoleDescription_Jsonclick = "";
         edtSecRoleName_Jsonclick = "";
         edtSecRoleId_Jsonclick = "";
         edtavDeleterole_Jsonclick = "";
         edtavDeleterole_Visible = -1;
         edtavDeleterole_Enabled = 1;
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
         edtavDdo_secroledescriptiontitlecontrolidtoreplace_Visible = 1;
         edtavDdo_secrolenametitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtSecRoleName_Link = "";
         edtavUaassociatefunctionalities_Tooltiptext = "";
         edtavUaassociatefunctionalities_Link = "";
         edtavRoleassociateusers_Tooltiptext = "";
         edtavRoleassociateusers_Link = "";
         edtavDeleterole_Tooltiptext = "";
         edtavUpdate_Tooltiptext = "修改";
         edtavUpdate_Link = "";
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtSecRoleDescription_Titleformat = 0;
         edtSecRoleDescription_Title = "描述";
         edtSecRoleName_Titleformat = 0;
         edtSecRoleName_Title = "名称";
         edtavUaassociatefunctionalities_Visible = -1;
         edtavUpdate_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         bttBtninsert_Visible = 1;
         Ddo_secroledescription_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_secroledescription_Noresultsfound = "WWP_TSNoResults";
         Ddo_secroledescription_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_secroledescription_Loadingdata = "WWP_TSLoading";
         Ddo_secroledescription_Sortdsc = "WWP_TSSortDSC";
         Ddo_secroledescription_Sortasc = "WWP_TSSortASC";
         Ddo_secroledescription_Datalistupdateminimumcharacters = 0;
         Ddo_secroledescription_Datalistproc = "WWPBaseObjects.SecRoleWWGetFilterData";
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
         Ddo_secrolename_Datalistproc = "WWPBaseObjects.SecRoleWWGetFilterData";
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
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Work With Role";
         subGrid_Rows = 0;
         edtavUaassociatefunctionalities_Title = "";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'edtavUaassociatefunctionalities_Title',ctrl:'vUAASSOCIATEFUNCTIONALITIES',prop:'Title'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV37IsAuthorized_UAAssociateFunctionalities',fld:'vISAUTHORIZED_UAASSOCIATEFUNCTIONALITIES',pic:''},{av:'AV75ddo_SecRoleNameTitleControlIdToReplace',fld:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV79ddo_SecRoleDescriptionTitleControlIdToReplace',fld:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV73TFSecRoleName',fld:'vTFSECROLENAME',pic:''},{av:'AV74TFSecRoleName_Sel',fld:'vTFSECROLENAME_SEL',pic:''},{av:'AV77TFSecRoleDescription',fld:'vTFSECROLEDESCRIPTION',pic:''},{av:'AV78TFSecRoleDescription_Sel',fld:'vTFSECROLEDESCRIPTION_SEL',pic:''},{av:'AV110Pgmname',fld:'vPGMNAME',pic:''},{av:'AV46OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV47OrderedDsc',fld:'vORDEREDDSC',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV72SecRoleNameTitleFilterData',fld:'vSECROLENAMETITLEFILTERDATA',pic:''},{av:'AV76SecRoleDescriptionTitleFilterData',fld:'vSECROLEDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtSecRoleName_Titleformat',ctrl:'SECROLENAME',prop:'Titleformat'},{av:'edtSecRoleName_Title',ctrl:'SECROLENAME',prop:'Title'},{av:'edtSecRoleDescription_Titleformat',ctrl:'SECROLEDESCRIPTION',prop:'Titleformat'},{av:'edtSecRoleDescription_Title',ctrl:'SECROLEDESCRIPTION',prop:'Title'},{av:'AV91GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV93GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV94GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV37IsAuthorized_UAAssociateFunctionalities',fld:'vISAUTHORIZED_UAASSOCIATEFUNCTIONALITIES',pic:''},{av:'edtavUaassociatefunctionalities_Visible',ctrl:'vUAASSOCIATEFUNCTIONALITIES',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E110I2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV46OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV47OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV73TFSecRoleName',fld:'vTFSECROLENAME',pic:''},{av:'AV74TFSecRoleName_Sel',fld:'vTFSECROLENAME_SEL',pic:''},{av:'AV77TFSecRoleDescription',fld:'vTFSECROLEDESCRIPTION',pic:''},{av:'AV78TFSecRoleDescription_Sel',fld:'vTFSECROLEDESCRIPTION_SEL',pic:''},{av:'AV75ddo_SecRoleNameTitleControlIdToReplace',fld:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV79ddo_SecRoleDescriptionTitleControlIdToReplace',fld:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV110Pgmname',fld:'vPGMNAME',pic:''},{av:'edtavUaassociatefunctionalities_Title',ctrl:'vUAASSOCIATEFUNCTIONALITIES',prop:'Title'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV37IsAuthorized_UAAssociateFunctionalities',fld:'vISAUTHORIZED_UAASSOCIATEFUNCTIONALITIES',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E120I2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV46OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV47OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV73TFSecRoleName',fld:'vTFSECROLENAME',pic:''},{av:'AV74TFSecRoleName_Sel',fld:'vTFSECROLENAME_SEL',pic:''},{av:'AV77TFSecRoleDescription',fld:'vTFSECROLEDESCRIPTION',pic:''},{av:'AV78TFSecRoleDescription_Sel',fld:'vTFSECROLEDESCRIPTION_SEL',pic:''},{av:'AV75ddo_SecRoleNameTitleControlIdToReplace',fld:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV79ddo_SecRoleDescriptionTitleControlIdToReplace',fld:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV110Pgmname',fld:'vPGMNAME',pic:''},{av:'edtavUaassociatefunctionalities_Title',ctrl:'vUAASSOCIATEFUNCTIONALITIES',prop:'Title'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV37IsAuthorized_UAAssociateFunctionalities',fld:'vISAUTHORIZED_UAASSOCIATEFUNCTIONALITIES',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_SECROLENAME.ONOPTIONCLICKED","{handler:'E130I2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV46OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV47OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV73TFSecRoleName',fld:'vTFSECROLENAME',pic:''},{av:'AV74TFSecRoleName_Sel',fld:'vTFSECROLENAME_SEL',pic:''},{av:'AV77TFSecRoleDescription',fld:'vTFSECROLEDESCRIPTION',pic:''},{av:'AV78TFSecRoleDescription_Sel',fld:'vTFSECROLEDESCRIPTION_SEL',pic:''},{av:'AV75ddo_SecRoleNameTitleControlIdToReplace',fld:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV79ddo_SecRoleDescriptionTitleControlIdToReplace',fld:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV110Pgmname',fld:'vPGMNAME',pic:''},{av:'edtavUaassociatefunctionalities_Title',ctrl:'vUAASSOCIATEFUNCTIONALITIES',prop:'Title'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV37IsAuthorized_UAAssociateFunctionalities',fld:'vISAUTHORIZED_UAASSOCIATEFUNCTIONALITIES',pic:''},{av:'Ddo_secrolename_Activeeventkey',ctrl:'DDO_SECROLENAME',prop:'ActiveEventKey'},{av:'Ddo_secrolename_Filteredtext_get',ctrl:'DDO_SECROLENAME',prop:'FilteredText_get'},{av:'Ddo_secrolename_Selectedvalue_get',ctrl:'DDO_SECROLENAME',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_SECROLENAME.ONOPTIONCLICKED",",oparms:[{av:'AV46OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV47OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_secrolename_Sortedstatus',ctrl:'DDO_SECROLENAME',prop:'SortedStatus'},{av:'AV73TFSecRoleName',fld:'vTFSECROLENAME',pic:''},{av:'AV74TFSecRoleName_Sel',fld:'vTFSECROLENAME_SEL',pic:''},{av:'Ddo_secroledescription_Sortedstatus',ctrl:'DDO_SECROLEDESCRIPTION',prop:'SortedStatus'},{av:'AV72SecRoleNameTitleFilterData',fld:'vSECROLENAMETITLEFILTERDATA',pic:''},{av:'AV76SecRoleDescriptionTitleFilterData',fld:'vSECROLEDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtSecRoleName_Titleformat',ctrl:'SECROLENAME',prop:'Titleformat'},{av:'edtSecRoleName_Title',ctrl:'SECROLENAME',prop:'Title'},{av:'edtSecRoleDescription_Titleformat',ctrl:'SECROLEDESCRIPTION',prop:'Titleformat'},{av:'edtSecRoleDescription_Title',ctrl:'SECROLEDESCRIPTION',prop:'Title'},{av:'AV91GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV93GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV94GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV37IsAuthorized_UAAssociateFunctionalities',fld:'vISAUTHORIZED_UAASSOCIATEFUNCTIONALITIES',pic:''},{av:'edtavUaassociatefunctionalities_Visible',ctrl:'vUAASSOCIATEFUNCTIONALITIES',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_SECROLEDESCRIPTION.ONOPTIONCLICKED","{handler:'E140I2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV46OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV47OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV73TFSecRoleName',fld:'vTFSECROLENAME',pic:''},{av:'AV74TFSecRoleName_Sel',fld:'vTFSECROLENAME_SEL',pic:''},{av:'AV77TFSecRoleDescription',fld:'vTFSECROLEDESCRIPTION',pic:''},{av:'AV78TFSecRoleDescription_Sel',fld:'vTFSECROLEDESCRIPTION_SEL',pic:''},{av:'AV75ddo_SecRoleNameTitleControlIdToReplace',fld:'vDDO_SECROLENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV79ddo_SecRoleDescriptionTitleControlIdToReplace',fld:'vDDO_SECROLEDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV110Pgmname',fld:'vPGMNAME',pic:''},{av:'edtavUaassociatefunctionalities_Title',ctrl:'vUAASSOCIATEFUNCTIONALITIES',prop:'Title'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV37IsAuthorized_UAAssociateFunctionalities',fld:'vISAUTHORIZED_UAASSOCIATEFUNCTIONALITIES',pic:''},{av:'Ddo_secroledescription_Activeeventkey',ctrl:'DDO_SECROLEDESCRIPTION',prop:'ActiveEventKey'},{av:'Ddo_secroledescription_Filteredtext_get',ctrl:'DDO_SECROLEDESCRIPTION',prop:'FilteredText_get'},{av:'Ddo_secroledescription_Selectedvalue_get',ctrl:'DDO_SECROLEDESCRIPTION',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_SECROLEDESCRIPTION.ONOPTIONCLICKED",",oparms:[{av:'AV46OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV47OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_secroledescription_Sortedstatus',ctrl:'DDO_SECROLEDESCRIPTION',prop:'SortedStatus'},{av:'AV77TFSecRoleDescription',fld:'vTFSECROLEDESCRIPTION',pic:''},{av:'AV78TFSecRoleDescription_Sel',fld:'vTFSECROLEDESCRIPTION_SEL',pic:''},{av:'Ddo_secrolename_Sortedstatus',ctrl:'DDO_SECROLENAME',prop:'SortedStatus'},{av:'AV72SecRoleNameTitleFilterData',fld:'vSECROLENAMETITLEFILTERDATA',pic:''},{av:'AV76SecRoleDescriptionTitleFilterData',fld:'vSECROLEDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtSecRoleName_Titleformat',ctrl:'SECROLENAME',prop:'Titleformat'},{av:'edtSecRoleName_Title',ctrl:'SECROLENAME',prop:'Title'},{av:'edtSecRoleDescription_Titleformat',ctrl:'SECROLEDESCRIPTION',prop:'Titleformat'},{av:'edtSecRoleDescription_Title',ctrl:'SECROLEDESCRIPTION',prop:'Title'},{av:'AV91GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV93GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV94GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV37IsAuthorized_UAAssociateFunctionalities',fld:'vISAUTHORIZED_UAASSOCIATEFUNCTIONALITIES',pic:''},{av:'edtavUaassociatefunctionalities_Visible',ctrl:'vUAASSOCIATEFUNCTIONALITIES',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E180I2',iparms:[{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9',hsh:true},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV37IsAuthorized_UAAssociateFunctionalities',fld:'vISAUTHORIZED_UAASSOCIATEFUNCTIONALITIES',pic:''}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV95Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'},{av:'AV13Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV98deleteRole',fld:'vDELETEROLE',pic:''},{av:'edtavDeleterole_Tooltiptext',ctrl:'vDELETEROLE',prop:'Tooltiptext'},{av:'AV97RoleAssociateUsers',fld:'vROLEASSOCIATEUSERS',pic:''},{av:'edtavRoleassociateusers_Tooltiptext',ctrl:'vROLEASSOCIATEUSERS',prop:'Tooltiptext'},{av:'edtavRoleassociateusers_Link',ctrl:'vROLEASSOCIATEUSERS',prop:'Link'},{av:'AV36UAAssociateFunctionalities',fld:'vUAASSOCIATEFUNCTIONALITIES',pic:''},{av:'edtavUaassociatefunctionalities_Tooltiptext',ctrl:'vUAASSOCIATEFUNCTIONALITIES',prop:'Tooltiptext'},{av:'edtavUaassociatefunctionalities_Link',ctrl:'vUAASSOCIATEFUNCTIONALITIES',prop:'Link'},{av:'edtSecRoleName_Link',ctrl:'SECROLENAME',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E150I2',iparms:[{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("'DOINSERT'",",oparms:[]}");
         setEventMetadata("VDELETEROLE.CLICK","{handler:'E190I2',iparms:[{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("VDELETEROLE.CLICK",",oparms:[]}");
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
         AV73TFSecRoleName = "";
         AV74TFSecRoleName_Sel = "";
         AV77TFSecRoleDescription = "";
         AV78TFSecRoleDescription_Sel = "";
         AV75ddo_SecRoleNameTitleControlIdToReplace = "";
         AV79ddo_SecRoleDescriptionTitleControlIdToReplace = "";
         AV110Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV80DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV72SecRoleNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV76SecRoleDescriptionTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_secrolename_Filteredtext_set = "";
         Ddo_secrolename_Selectedvalue_set = "";
         Ddo_secrolename_Sortedstatus = "";
         Ddo_secroledescription_Filteredtext_set = "";
         Ddo_secroledescription_Selectedvalue_set = "";
         Ddo_secroledescription_Sortedstatus = "";
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
         AV95Display = "";
         AV13Update = "";
         AV98deleteRole = "";
         AV97RoleAssociateUsers = "";
         AV36UAAssociateFunctionalities = "";
         A13SecRoleName = "";
         A12SecRoleDescription = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_secrolename = new GXUserControl();
         ucDdo_secroledescription = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV105Display_GXI = "";
         AV106Update_GXI = "";
         AV107Deleterole_GXI = "";
         AV108Roleassociateusers_GXI = "";
         AV109Uaassociatefunctionalities_GXI = "";
         scmdbuf = "";
         lV101WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename = "";
         lV103WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription = "";
         AV102WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel = "";
         AV101WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename = "";
         AV104WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel = "";
         AV103WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription = "";
         H000I2_A12SecRoleDescription = new String[] {""} ;
         H000I2_A13SecRoleName = new String[] {""} ;
         H000I2_A4SecRoleId = new short[1] ;
         H000I3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV89WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         AV15Session = context.GetSession();
         AV43GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV44GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV8HTTPRequest = new GxHttpRequest( context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secroleww__default(),
            new Object[][] {
                new Object[] {
               H000I2_A12SecRoleDescription, H000I2_A13SecRoleName, H000I2_A4SecRoleId
               }
               , new Object[] {
               H000I3_AGRID_nRecordCount
               }
            }
         );
         AV110Pgmname = "WWPBaseObjects.SecRoleWW";
         /* GeneXus formulas. */
         AV110Pgmname = "WWPBaseObjects.SecRoleWW";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_28 ;
      private short nGXsfl_28_idx=1 ;
      private short GRID_nEOF ;
      private short AV46OrderedBy ;
      private short initialized ;
      private short gxajaxcallmode ;
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
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid_Backstyle ;
      private int subGrid_Rows ;
      private int Gridpaginationbar_Rowsperpageselectedvalue ;
      private int Gridpaginationbar_Pagestoshow ;
      private int Ddo_secrolename_Datalistupdateminimumcharacters ;
      private int Ddo_secroledescription_Datalistupdateminimumcharacters ;
      private int bttBtninsert_Visible ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavUpdate_Visible ;
      private int edtavUaassociatefunctionalities_Visible ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_secrolenametitlecontrolidtoreplace_Visible ;
      private int edtavDdo_secroledescriptiontitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfsecrolename_Visible ;
      private int edtavTfsecrolename_sel_Visible ;
      private int edtavTfsecroledescription_Visible ;
      private int edtavTfsecroledescription_sel_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV90PageToGo ;
      private int AV111GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavDeleterole_Enabled ;
      private int edtavDeleterole_Visible ;
      private long GRID_nFirstRecordOnPage ;
      private long AV91GridCurrentPage ;
      private long AV94GridRecordCount ;
      private long AV93GridPageSize ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String edtavUaassociatefunctionalities_Title ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_secrolename_Activeeventkey ;
      private String Ddo_secrolename_Filteredtext_get ;
      private String Ddo_secrolename_Selectedvalue_get ;
      private String Ddo_secroledescription_Activeeventkey ;
      private String Ddo_secroledescription_Filteredtext_get ;
      private String Ddo_secroledescription_Selectedvalue_get ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_28_idx="0001" ;
      private String edtavUaassociatefunctionalities_Internalname ;
      private String AV110Pgmname ;
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
      private String edtSecRoleName_Title ;
      private String edtSecRoleDescription_Title ;
      private String subGrid_Header ;
      private String edtavDisplay_Link ;
      private String edtavDisplay_Tooltiptext ;
      private String edtavUpdate_Link ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavDeleterole_Tooltiptext ;
      private String edtavRoleassociateusers_Link ;
      private String edtavRoleassociateusers_Tooltiptext ;
      private String edtavUaassociatefunctionalities_Link ;
      private String edtavUaassociatefunctionalities_Tooltiptext ;
      private String edtSecRoleName_Link ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_secrolename_Internalname ;
      private String edtavDdo_secrolenametitlecontrolidtoreplace_Internalname ;
      private String Ddo_secroledescription_Internalname ;
      private String edtavDdo_secroledescriptiontitlecontrolidtoreplace_Internalname ;
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
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDisplay_Internalname ;
      private String edtavUpdate_Internalname ;
      private String edtavDeleterole_Internalname ;
      private String edtavRoleassociateusers_Internalname ;
      private String edtSecRoleId_Internalname ;
      private String edtSecRoleName_Internalname ;
      private String edtSecRoleDescription_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_28_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavDeleterole_Jsonclick ;
      private String ROClassString ;
      private String edtSecRoleId_Jsonclick ;
      private String edtSecRoleName_Jsonclick ;
      private String edtSecRoleDescription_Jsonclick ;
      private bool entryPointCalled ;
      private bool bGXsfl_28_Refreshing=false ;
      private bool AV47OrderedDsc ;
      private bool AV39IsAuthorized_Update ;
      private bool AV37IsAuthorized_UAAssociateFunctionalities ;
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
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV38TempBoolean ;
      private bool GXt_boolean2 ;
      private bool AV95Display_IsBlob ;
      private bool AV13Update_IsBlob ;
      private bool AV98deleteRole_IsBlob ;
      private bool AV97RoleAssociateUsers_IsBlob ;
      private bool AV36UAAssociateFunctionalities_IsBlob ;
      private String AV73TFSecRoleName ;
      private String AV74TFSecRoleName_Sel ;
      private String AV77TFSecRoleDescription ;
      private String AV78TFSecRoleDescription_Sel ;
      private String AV75ddo_SecRoleNameTitleControlIdToReplace ;
      private String AV79ddo_SecRoleDescriptionTitleControlIdToReplace ;
      private String A13SecRoleName ;
      private String A12SecRoleDescription ;
      private String AV105Display_GXI ;
      private String AV106Update_GXI ;
      private String AV107Deleterole_GXI ;
      private String AV108Roleassociateusers_GXI ;
      private String AV109Uaassociatefunctionalities_GXI ;
      private String lV101WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename ;
      private String lV103WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription ;
      private String AV102WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel ;
      private String AV101WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename ;
      private String AV104WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel ;
      private String AV103WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription ;
      private String AV95Display ;
      private String AV13Update ;
      private String AV98deleteRole ;
      private String AV97RoleAssociateUsers ;
      private String AV36UAAssociateFunctionalities ;
      private IGxSession AV15Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_secrolename ;
      private GXUserControl ucDdo_secroledescription ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H000I2_A12SecRoleDescription ;
      private String[] H000I2_A13SecRoleName ;
      private short[] H000I2_A4SecRoleId ;
      private long[] H000I3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV72SecRoleNameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV76SecRoleDescriptionTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV89WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV43GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV44GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV80DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class secroleww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H000I2( IGxContext context ,
                                             String AV102WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel ,
                                             String AV101WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename ,
                                             String AV104WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel ,
                                             String AV103WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription ,
                                             String A13SecRoleName ,
                                             String A12SecRoleDescription ,
                                             short AV46OrderedBy ,
                                             bool AV47OrderedDsc )
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
         sSelectString = " [SecRoleDescription], [SecRoleName], [SecRoleId]";
         sFromString = " FROM [SecRole] WITH (NOLOCK)";
         sOrderString = "";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV102WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV101WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SecRoleName] like @lV101WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename)";
            }
            else
            {
               sWhereString = sWhereString + " ([SecRoleName] like @lV101WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV102WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SecRoleName] = @AV102WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([SecRoleName] = @AV102WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel)";
            }
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV104WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV103WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SecRoleDescription] like @lV103WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription)";
            }
            else
            {
               sWhereString = sWhereString + " ([SecRoleDescription] like @lV103WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription)";
            }
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV104WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SecRoleDescription] = @AV104WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([SecRoleDescription] = @AV104WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel)";
            }
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         if ( AV46OrderedBy == 1 )
         {
            sOrderString = sOrderString + " ORDER BY [SecRoleId] DESC";
         }
         else if ( ( AV46OrderedBy == 2 ) && ! AV47OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [SecRoleName]";
         }
         else if ( ( AV46OrderedBy == 2 ) && ( AV47OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [SecRoleName] DESC";
         }
         else if ( ( AV46OrderedBy == 3 ) && ! AV47OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [SecRoleDescription]";
         }
         else if ( ( AV46OrderedBy == 3 ) && ( AV47OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [SecRoleDescription] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [SecRoleId]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H000I3( IGxContext context ,
                                             String AV102WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel ,
                                             String AV101WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename ,
                                             String AV104WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel ,
                                             String AV103WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription ,
                                             String A13SecRoleName ,
                                             String A12SecRoleDescription ,
                                             short AV46OrderedBy ,
                                             bool AV47OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [4] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [SecRole] WITH (NOLOCK)";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV102WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV101WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SecRoleName] like @lV101WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename)";
            }
            else
            {
               sWhereString = sWhereString + " ([SecRoleName] like @lV101WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename)";
            }
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV102WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SecRoleName] = @AV102WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([SecRoleName] = @AV102WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel)";
            }
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV104WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV103WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SecRoleDescription] like @lV103WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription)";
            }
            else
            {
               sWhereString = sWhereString + " ([SecRoleDescription] like @lV103WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription)";
            }
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV104WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SecRoleDescription] = @AV104WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([SecRoleDescription] = @AV104WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel)";
            }
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         if ( AV46OrderedBy == 1 )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV46OrderedBy == 2 ) && ! AV47OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV46OrderedBy == 2 ) && ( AV47OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV46OrderedBy == 3 ) && ! AV47OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV46OrderedBy == 3 ) && ( AV47OrderedDsc ) )
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
                     return conditional_H000I2(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (short)dynConstraints[6] , (bool)dynConstraints[7] );
               case 1 :
                     return conditional_H000I3(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (short)dynConstraints[6] , (bool)dynConstraints[7] );
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
          Object[] prmH000I2 ;
          prmH000I2 = new Object[] {
          new Object[] {"@lV101WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV102WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV103WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription",SqlDbType.NVarChar,120,0} ,
          new Object[] {"@AV104WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel",SqlDbType.NVarChar,120,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH000I3 ;
          prmH000I3 = new Object[] {
          new Object[] {"@lV101WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV102WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV103WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription",SqlDbType.NVarChar,120,0} ,
          new Object[] {"@AV104WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel",SqlDbType.NVarChar,120,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000I2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000I2,11,0,true,false )
             ,new CursorDef("H000I3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000I3,1,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
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
                   stmt.SetParameter(sIdx, (String)parms[7]);
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
                   stmt.SetParameter(sIdx, (String)parms[4]);
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
