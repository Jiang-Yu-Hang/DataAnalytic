/*
               File: WWPBaseObjects.SecUserWW
        Description: Work With User
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:39:9.56
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
   public class secuserww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public secuserww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public secuserww( IGxContext context )
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
               edtavUaassociateroles_Title = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUaassociateroles_Internalname, "Title", edtavUaassociateroles_Title, !bGXsfl_28_Refreshing);
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
               AV23OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV24OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV53ddo_SecUserNameTitleControlIdToReplace = GetNextPar( );
               AV100Pgmname = GetNextPar( );
               edtavUaassociateroles_Title = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUaassociateroles_Internalname, "Title", edtavUaassociateroles_Title, !bGXsfl_28_Refreshing);
               AV17IsAuthorized_Update = StringUtil.StrToBool( GetNextPar( ));
               AV16IsAuthorized_UAAssociateRoles = StringUtil.StrToBool( GetNextPar( ));
               AV93IsAuthorized_ProviderAndUser = StringUtil.StrToBool( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV23OrderedBy, AV24OrderedDsc, AV53ddo_SecUserNameTitleControlIdToReplace, AV100Pgmname, AV17IsAuthorized_Update, AV16IsAuthorized_UAAssociateRoles, AV93IsAuthorized_ProviderAndUser) ;
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
         PA0K2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0K2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2020227939969", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("wwpbaseobjects.secuserww.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV23OrderedBy), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV24OrderedDsc));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_28", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_28), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV81GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV84GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV83GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV54DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV54DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vSECUSERNAMETITLEFILTERDATA", AV50SecUserNameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vSECUSERNAMETITLEFILTERDATA", AV50SecUserNameTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV100Pgmname));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_UPDATE", AV17IsAuthorized_Update);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_UAASSOCIATEROLES", AV16IsAuthorized_UAAssociateRoles);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_PROVIDERANDUSER", AV93IsAuthorized_ProviderAndUser);
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
         GxWebStd.gx_hidden_field( context, "DDO_SECUSERNAME_Caption", StringUtil.RTrim( Ddo_secusername_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_SECUSERNAME_Tooltip", StringUtil.RTrim( Ddo_secusername_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_SECUSERNAME_Cls", StringUtil.RTrim( Ddo_secusername_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_SECUSERNAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_secusername_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_SECUSERNAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_secusername_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_SECUSERNAME_Includesortasc", StringUtil.BoolToStr( Ddo_secusername_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_SECUSERNAME_Includesortdsc", StringUtil.BoolToStr( Ddo_secusername_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_SECUSERNAME_Sortedstatus", StringUtil.RTrim( Ddo_secusername_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_SECUSERNAME_Includefilter", StringUtil.BoolToStr( Ddo_secusername_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_SECUSERNAME_Includedatalist", StringUtil.BoolToStr( Ddo_secusername_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_SECUSERNAME_Sortasc", StringUtil.RTrim( Ddo_secusername_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_SECUSERNAME_Sortdsc", StringUtil.RTrim( Ddo_secusername_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_SECUSERNAME_Searchbuttontext", StringUtil.RTrim( Ddo_secusername_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_SECUSERNAME_Activeeventkey", StringUtil.RTrim( Ddo_secusername_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "vUAASSOCIATEROLES_Title", StringUtil.RTrim( edtavUaassociateroles_Title));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_SECUSERNAME_Activeeventkey", StringUtil.RTrim( Ddo_secusername_Activeeventkey));
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
            WE0K2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0K2( ) ;
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
         return formatLink("wwpbaseobjects.secuserww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "WWPBaseObjects.SecUserWW" ;
      }

      public override String GetPgmdesc( )
      {
         return "Work With User" ;
      }

      protected void WB0K0( )
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
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(28), 2, 0)+","+"null"+");", "新增", bttBtninsert_Jsonclick, 5, "插入", "", StyleString, ClassString, bttBtninsert_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\SecUserWW.htm");
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavDeleteuserallinfo_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavUaassociateroles_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( edtavUaassociateroles_Title) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavProvideranduser_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "编号") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtSecUserName_Titleformat == 0 )
               {
                  context.SendWebValue( edtSecUserName_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtSecUserName_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "创建人") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "更新人") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "创建时间") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "更新时间") ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV12Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV91deleteUserAllInfo));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDeleteuserallinfo_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDeleteuserallinfo_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV15UAAssociateRoles));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtavUaassociateroles_Title));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUaassociateroles_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUaassociateroles_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUaassociateroles_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV87ProviderAndUser));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavProvideranduser_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavProvideranduser_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavProvideranduser_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A6SecUserId), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A14SecUserName);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtSecUserName_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSecUserName_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A178SecUserCrtUser);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A179SecUserUpdUser);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.TToC( A180SecUserCrtDate, 10, 8, 0, 0, "/", ":", " "));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.TToC( A181SecUserUpdDate, 10, 8, 0, 0, "/", ":", " "));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV81GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV84GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV83GridPageSize);
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
            ucDdo_secusername.SetProperty("Caption", Ddo_secusername_Caption);
            ucDdo_secusername.SetProperty("Tooltip", Ddo_secusername_Tooltip);
            ucDdo_secusername.SetProperty("Cls", Ddo_secusername_Cls);
            ucDdo_secusername.SetProperty("DropDownOptionsType", Ddo_secusername_Dropdownoptionstype);
            ucDdo_secusername.SetProperty("IncludeSortASC", Ddo_secusername_Includesortasc);
            ucDdo_secusername.SetProperty("IncludeSortDSC", Ddo_secusername_Includesortdsc);
            ucDdo_secusername.SetProperty("IncludeFilter", Ddo_secusername_Includefilter);
            ucDdo_secusername.SetProperty("IncludeDataList", Ddo_secusername_Includedatalist);
            ucDdo_secusername.SetProperty("SortASC", Ddo_secusername_Sortasc);
            ucDdo_secusername.SetProperty("SortDSC", Ddo_secusername_Sortdsc);
            ucDdo_secusername.SetProperty("SearchButtonText", Ddo_secusername_Searchbuttontext);
            ucDdo_secusername.SetProperty("DropDownOptionsTitleSettingsIcons", AV54DDO_TitleSettingsIcons);
            ucDdo_secusername.SetProperty("DropDownOptionsData", AV50SecUserNameTitleFilterData);
            ucDdo_secusername.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_secusername_Internalname, "DDO_SECUSERNAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_secusernametitlecontrolidtoreplace_Internalname, AV53ddo_SecUserNameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,47);\"", 0, edtavDdo_secusernametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WWPBaseObjects\\SecUserWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV23OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV23OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WWPBaseObjects\\SecUserWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV24OrderedDsc), StringUtil.BoolToStr( AV24OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_WWPBaseObjects\\SecUserWW.htm");
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

      protected void START0K2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "Work With User", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0K0( ) ;
      }

      protected void WS0K2( )
      {
         START0K2( ) ;
         EVT0K2( ) ;
      }

      protected void EVT0K2( )
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
                              E110K2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E120K2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_SECUSERNAME.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E130K2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E140K2 ();
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
                              AV12Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV12Update)) ? AV96Update_GXI : context.convertURL( context.PathToRelativeUrl( AV12Update))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV12Update), true);
                              AV91deleteUserAllInfo = cgiGet( edtavDeleteuserallinfo_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDeleteuserallinfo_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV91deleteUserAllInfo)) ? AV97Deleteuserallinfo_GXI : context.convertURL( context.PathToRelativeUrl( AV91deleteUserAllInfo))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDeleteuserallinfo_Internalname, "SrcSet", context.GetImageSrcSet( AV91deleteUserAllInfo), true);
                              AV15UAAssociateRoles = cgiGet( edtavUaassociateroles_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUaassociateroles_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV15UAAssociateRoles)) ? AV98Uaassociateroles_GXI : context.convertURL( context.PathToRelativeUrl( AV15UAAssociateRoles))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUaassociateroles_Internalname, "SrcSet", context.GetImageSrcSet( AV15UAAssociateRoles), true);
                              AV87ProviderAndUser = cgiGet( edtavProvideranduser_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavProvideranduser_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV87ProviderAndUser)) ? AV99Provideranduser_GXI : context.convertURL( context.PathToRelativeUrl( AV87ProviderAndUser))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavProvideranduser_Internalname, "SrcSet", context.GetImageSrcSet( AV87ProviderAndUser), true);
                              A6SecUserId = (short)(context.localUtil.CToN( cgiGet( edtSecUserId_Internalname), ".", ","));
                              A14SecUserName = cgiGet( edtSecUserName_Internalname);
                              A178SecUserCrtUser = cgiGet( edtSecUserCrtUser_Internalname);
                              n178SecUserCrtUser = false;
                              A179SecUserUpdUser = cgiGet( edtSecUserUpdUser_Internalname);
                              n179SecUserUpdUser = false;
                              A180SecUserCrtDate = context.localUtil.CToT( cgiGet( edtSecUserCrtDate_Internalname), 0);
                              n180SecUserCrtDate = false;
                              A181SecUserUpdDate = context.localUtil.CToT( cgiGet( edtSecUserUpdDate_Internalname), 0);
                              n181SecUserUpdDate = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E150K2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E160K2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E170K2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Orderedby Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV23OrderedBy )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ordereddsc Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV24OrderedDsc )
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

      protected void WE0K2( )
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

      protected void PA0K2( )
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
               GX_FocusControl = edtavDdo_secusernametitlecontrolidtoreplace_Internalname;
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
                                       short AV23OrderedBy ,
                                       bool AV24OrderedDsc ,
                                       String AV53ddo_SecUserNameTitleControlIdToReplace ,
                                       String AV100Pgmname ,
                                       bool AV17IsAuthorized_Update ,
                                       bool AV16IsAuthorized_UAAssociateRoles ,
                                       bool AV93IsAuthorized_ProviderAndUser )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF0K2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_SECUSERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A6SecUserId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "SECUSERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A6SecUserId), 4, 0, ".", "")));
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
         RF0K2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV100Pgmname = "WWPBaseObjects.SecUserWW";
         context.Gx_err = 0;
      }

      protected void RF0K2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 28;
         /* Execute user event: Refresh */
         E160K2 ();
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
                                                 A6SecUserId ,
                                                 AV90oSecUserIds ,
                                                 AV89IsRocheUser ,
                                                 AV23OrderedBy ,
                                                 AV24OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            /* Using cursor H000K2 */
            pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_28_idx = 1;
            sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
            SubsflControlProps_282( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A181SecUserUpdDate = H000K2_A181SecUserUpdDate[0];
               n181SecUserUpdDate = H000K2_n181SecUserUpdDate[0];
               A180SecUserCrtDate = H000K2_A180SecUserCrtDate[0];
               n180SecUserCrtDate = H000K2_n180SecUserCrtDate[0];
               A179SecUserUpdUser = H000K2_A179SecUserUpdUser[0];
               n179SecUserUpdUser = H000K2_n179SecUserUpdUser[0];
               A178SecUserCrtUser = H000K2_A178SecUserCrtUser[0];
               n178SecUserCrtUser = H000K2_n178SecUserCrtUser[0];
               A14SecUserName = H000K2_A14SecUserName[0];
               A6SecUserId = H000K2_A6SecUserId[0];
               E170K2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 28;
            WB0K0( ) ;
         }
         bGXsfl_28_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes0K2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_SECUSERID"+"_"+sGXsfl_28_idx, GetSecureSignedToken( sGXsfl_28_idx, context.localUtil.Format( (decimal)(A6SecUserId), "ZZZ9"), context));
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
                                              A6SecUserId ,
                                              AV90oSecUserIds ,
                                              AV89IsRocheUser ,
                                              AV23OrderedBy ,
                                              AV24OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         /* Using cursor H000K3 */
         pr_default.execute(1);
         GRID_nRecordCount = H000K3_AGRID_nRecordCount[0];
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
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV23OrderedBy, AV24OrderedDsc, AV53ddo_SecUserNameTitleControlIdToReplace, AV100Pgmname, AV17IsAuthorized_Update, AV16IsAuthorized_UAAssociateRoles, AV93IsAuthorized_ProviderAndUser) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV23OrderedBy, AV24OrderedDsc, AV53ddo_SecUserNameTitleControlIdToReplace, AV100Pgmname, AV17IsAuthorized_Update, AV16IsAuthorized_UAAssociateRoles, AV93IsAuthorized_ProviderAndUser) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV23OrderedBy, AV24OrderedDsc, AV53ddo_SecUserNameTitleControlIdToReplace, AV100Pgmname, AV17IsAuthorized_Update, AV16IsAuthorized_UAAssociateRoles, AV93IsAuthorized_ProviderAndUser) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV23OrderedBy, AV24OrderedDsc, AV53ddo_SecUserNameTitleControlIdToReplace, AV100Pgmname, AV17IsAuthorized_Update, AV16IsAuthorized_UAAssociateRoles, AV93IsAuthorized_ProviderAndUser) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV23OrderedBy, AV24OrderedDsc, AV53ddo_SecUserNameTitleControlIdToReplace, AV100Pgmname, AV17IsAuthorized_Update, AV16IsAuthorized_UAAssociateRoles, AV93IsAuthorized_ProviderAndUser) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP0K0( )
      {
         /* Before Start, stand alone formulas. */
         AV100Pgmname = "WWPBaseObjects.SecUserWW";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E150K2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV54DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vSECUSERNAMETITLEFILTERDATA"), AV50SecUserNameTitleFilterData);
            /* Read variables values. */
            AV53ddo_SecUserNameTitleControlIdToReplace = cgiGet( edtavDdo_secusernametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV53ddo_SecUserNameTitleControlIdToReplace", AV53ddo_SecUserNameTitleControlIdToReplace);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDEREDBY");
               GX_FocusControl = edtavOrderedby_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV23OrderedBy = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV23OrderedBy), 4, 0)));
            }
            else
            {
               AV23OrderedBy = (short)(context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV23OrderedBy), 4, 0)));
            }
            AV24OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24OrderedDsc", AV24OrderedDsc);
            /* Read saved values. */
            nRC_GXsfl_28 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_28"), ".", ","));
            AV81GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV84GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV83GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_secusername_Caption = cgiGet( "DDO_SECUSERNAME_Caption");
            Ddo_secusername_Tooltip = cgiGet( "DDO_SECUSERNAME_Tooltip");
            Ddo_secusername_Cls = cgiGet( "DDO_SECUSERNAME_Cls");
            Ddo_secusername_Dropdownoptionstype = cgiGet( "DDO_SECUSERNAME_Dropdownoptionstype");
            Ddo_secusername_Titlecontrolidtoreplace = cgiGet( "DDO_SECUSERNAME_Titlecontrolidtoreplace");
            Ddo_secusername_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_SECUSERNAME_Includesortasc"));
            Ddo_secusername_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_SECUSERNAME_Includesortdsc"));
            Ddo_secusername_Sortedstatus = cgiGet( "DDO_SECUSERNAME_Sortedstatus");
            Ddo_secusername_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_SECUSERNAME_Includefilter"));
            Ddo_secusername_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_SECUSERNAME_Includedatalist"));
            Ddo_secusername_Sortasc = cgiGet( "DDO_SECUSERNAME_Sortasc");
            Ddo_secusername_Sortdsc = cgiGet( "DDO_SECUSERNAME_Sortdsc");
            Ddo_secusername_Searchbuttontext = cgiGet( "DDO_SECUSERNAME_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_secusername_Activeeventkey = cgiGet( "DDO_SECUSERNAME_Activeeventkey");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV23OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV24OrderedDsc )
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
         E150K2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E150K2( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_secusername_Titlecontrolidtoreplace = subGrid_Internalname+"_SecUserName";
         ucDdo_secusername.SendProperty(context, "", false, Ddo_secusername_Internalname, "TitleControlIdToReplace", Ddo_secusername_Titlecontrolidtoreplace);
         AV53ddo_SecUserNameTitleControlIdToReplace = Ddo_secusername_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV53ddo_SecUserNameTitleControlIdToReplace", AV53ddo_SecUserNameTitleControlIdToReplace);
         edtavDdo_secusernametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_secusernametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_secusernametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "用户列表";
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
         if ( AV23OrderedBy < 1 )
         {
            AV23OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV23OrderedBy), 4, 0)));
         }
         edtavOrdereddsc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrdereddsc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrdereddsc_Visible), 5, 0)), true);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV54DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV54DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
         edtavUaassociateroles_Title = "Roles";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUaassociateroles_Internalname, "Title", edtavUaassociateroles_Title, !bGXsfl_28_Refreshing);
      }

      protected void E160K2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV89IsRocheUser = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV89IsRocheUser", AV89IsRocheUser);
         GXt_objcol_int2 = AV88tJC_ProviderIDs;
         new zutil_findallproviderids(context ).execute( out  GXt_objcol_int2) ;
         AV88tJC_ProviderIDs = GXt_objcol_int2;
         GXt_objcol_int3 = AV90oSecUserIds;
         new zutil_finduserifinprovider(context ).execute(  AV88tJC_ProviderIDs, out  GXt_objcol_int3) ;
         AV90oSecUserIds = GXt_objcol_int3;
         GXt_boolean4 = AV89IsRocheUser;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "RocheUser", out  GXt_boolean4) ;
         AV89IsRocheUser = GXt_boolean4;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV89IsRocheUser", AV89IsRocheUser);
         AV50SecUserNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV79WWPContext) ;
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
         edtSecUserName_Titleformat = 2;
         edtSecUserName_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "姓名", AV53ddo_SecUserNameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecUserName_Internalname, "Title", edtSecUserName_Title, !bGXsfl_28_Refreshing);
         AV81GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV81GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV81GridCurrentPage), 10, 0)));
         AV83GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV83GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV83GridPageSize), 10, 0)));
         AV84GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV84GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV84GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50SecUserNameTitleFilterData", AV50SecUserNameTitleFilterData);
      }

      protected void E110K2( )
      {
         /* Gridpaginationbar_Changepage Routine */
         if ( 1 == 0 )
         {
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
               AV80PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
               subgrid_gotopage( AV80PageToGo) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(Gridpaginationbar_Selectedpage, "Previous") == 0 )
            {
               subgrid_previouspage( ) ;
            }
            else if ( StringUtil.StrCmp(Gridpaginationbar_Selectedpage, "Next") == 0 )
            {
               subgrid_gotopage( subGrid_Currentpage( )+1) ;
            }
            else
            {
               AV80PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
               subgrid_gotopage( AV80PageToGo) ;
            }
         }
      }

      protected void E120K2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E130K2( )
      {
         /* Ddo_secusername_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_secusername_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV23OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV23OrderedBy), 4, 0)));
            AV24OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24OrderedDsc", AV24OrderedDsc);
            Ddo_secusername_Sortedstatus = "ASC";
            ucDdo_secusername.SendProperty(context, "", false, Ddo_secusername_Internalname, "SortedStatus", Ddo_secusername_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_secusername_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV23OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV23OrderedBy), 4, 0)));
            AV24OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24OrderedDsc", AV24OrderedDsc);
            Ddo_secusername_Sortedstatus = "DSC";
            ucDdo_secusername.SendProperty(context, "", false, Ddo_secusername_Internalname, "SortedStatus", Ddo_secusername_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50SecUserNameTitleFilterData", AV50SecUserNameTitleFilterData);
      }

      private void E170K2( )
      {
         /* Grid_Load Routine */
         AV12Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV12Update);
         AV96Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavUpdate_Tooltiptext = "修改";
         if ( AV17IsAuthorized_Update )
         {
            edtavUpdate_Link = formatLink("secuser_update.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A6SecUserId);
         }
         AV91deleteUserAllInfo = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDeleteuserallinfo_Internalname, AV91deleteUserAllInfo);
         AV97Deleteuserallinfo_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavDeleteuserallinfo_Tooltiptext = "";
         AV15UAAssociateRoles = context.GetImagePath( "cc488df4-dfce-487a-a445-6fdd39fec85e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUaassociateroles_Internalname, AV15UAAssociateRoles);
         AV98Uaassociateroles_GXI = GXDbFile.PathToUrl( context.GetImagePath( "cc488df4-dfce-487a-a445-6fdd39fec85e", "", context.GetTheme( )));
         edtavUaassociateroles_Tooltiptext = "";
         if ( AV16IsAuthorized_UAAssociateRoles )
         {
            edtavUaassociateroles_Link = formatLink("wwpbaseobjects.secusersecuserroleassociation.aspx") + "?" + UrlEncode("" +A6SecUserId);
         }
         AV87ProviderAndUser = context.GetImagePath( "5fe91247-fb4b-43c1-8f7d-1064913f323d", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavProvideranduser_Internalname, AV87ProviderAndUser);
         AV99Provideranduser_GXI = GXDbFile.PathToUrl( context.GetImagePath( "5fe91247-fb4b-43c1-8f7d-1064913f323d", "", context.GetTheme( )));
         edtavProvideranduser_Tooltiptext = "";
         if ( AV93IsAuthorized_ProviderAndUser )
         {
            edtavProvideranduser_Link = formatLink("wwpbaseobjects.secuserjc_providersecuserassociation.aspx") + "?" + UrlEncode("" +A6SecUserId);
         }
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

      protected void E140K2( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("secuser_update.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S132( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean4 = AV17IsAuthorized_Update;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWSecUser_Update", out  GXt_boolean4) ;
         AV17IsAuthorized_Update = GXt_boolean4;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17IsAuthorized_Update", AV17IsAuthorized_Update);
         if ( ! ( AV17IsAuthorized_Update ) )
         {
            edtavUpdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         }
         GXt_boolean4 = AV92IsAuthorized_deleteUserAllInfo;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWSecUser_Delete", out  GXt_boolean4) ;
         AV92IsAuthorized_deleteUserAllInfo = GXt_boolean4;
         if ( ! ( AV92IsAuthorized_deleteUserAllInfo ) )
         {
            edtavDeleteuserallinfo_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDeleteuserallinfo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDeleteuserallinfo_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         }
         GXt_boolean4 = AV16IsAuthorized_UAAssociateRoles;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "UserAssignRoles", out  GXt_boolean4) ;
         AV16IsAuthorized_UAAssociateRoles = GXt_boolean4;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16IsAuthorized_UAAssociateRoles", AV16IsAuthorized_UAAssociateRoles);
         if ( ! ( AV16IsAuthorized_UAAssociateRoles ) )
         {
            edtavUaassociateroles_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUaassociateroles_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUaassociateroles_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         }
         GXt_boolean4 = AV93IsAuthorized_ProviderAndUser;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "JC_ProviderSecUser", out  GXt_boolean4) ;
         AV93IsAuthorized_ProviderAndUser = GXt_boolean4;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV93IsAuthorized_ProviderAndUser", AV93IsAuthorized_ProviderAndUser);
         if ( ! ( AV93IsAuthorized_ProviderAndUser ) )
         {
            edtavProvideranduser_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavProvideranduser_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavProvideranduser_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         }
         GXt_boolean4 = AV19TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWSecUser_Insert", out  GXt_boolean4) ;
         AV19TempBoolean = GXt_boolean4;
         if ( ! ( AV19TempBoolean ) )
         {
            bttBtninsert_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtninsert_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtninsert_Visible), 5, 0)), true);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV14Session.Get(AV100Pgmname+"GridState"), "") == 0 )
         {
            AV20GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV100Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV20GridState.FromXml(AV14Session.Get(AV100Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV23OrderedBy = AV20GridState.gxTpr_Orderedby;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV23OrderedBy), 4, 0)));
         AV24OrderedDsc = AV20GridState.gxTpr_Ordereddsc;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24OrderedDsc", AV24OrderedDsc);
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV20GridState.gxTpr_Pagesize))) )
         {
            subGrid_Rows = (int)(NumberUtil.Val( AV20GridState.gxTpr_Pagesize, "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         }
         subgrid_gotopage( AV20GridState.gxTpr_Currentpage) ;
      }

      protected void S142( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV20GridState.FromXml(AV14Session.Get(AV100Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV20GridState.gxTpr_Orderedby = AV23OrderedBy;
         AV20GridState.gxTpr_Ordereddsc = AV24OrderedDsc;
         AV20GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV20GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV100Pgmname+"GridState",  AV20GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV100Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "WWPBaseObjects.SecUser";
         AV14Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
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
         PA0K2( ) ;
         WS0K2( ) ;
         WE0K2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020227939145", true);
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
         context.AddJavascriptSource("wwpbaseobjects/secuserww.js", "?2020227939145", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_282( )
      {
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_28_idx;
         edtavDeleteuserallinfo_Internalname = "vDELETEUSERALLINFO_"+sGXsfl_28_idx;
         edtavUaassociateroles_Internalname = "vUAASSOCIATEROLES_"+sGXsfl_28_idx;
         edtavProvideranduser_Internalname = "vPROVIDERANDUSER_"+sGXsfl_28_idx;
         edtSecUserId_Internalname = "SECUSERID_"+sGXsfl_28_idx;
         edtSecUserName_Internalname = "SECUSERNAME_"+sGXsfl_28_idx;
         edtSecUserCrtUser_Internalname = "SECUSERCRTUSER_"+sGXsfl_28_idx;
         edtSecUserUpdUser_Internalname = "SECUSERUPDUSER_"+sGXsfl_28_idx;
         edtSecUserCrtDate_Internalname = "SECUSERCRTDATE_"+sGXsfl_28_idx;
         edtSecUserUpdDate_Internalname = "SECUSERUPDDATE_"+sGXsfl_28_idx;
      }

      protected void SubsflControlProps_fel_282( )
      {
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_28_fel_idx;
         edtavDeleteuserallinfo_Internalname = "vDELETEUSERALLINFO_"+sGXsfl_28_fel_idx;
         edtavUaassociateroles_Internalname = "vUAASSOCIATEROLES_"+sGXsfl_28_fel_idx;
         edtavProvideranduser_Internalname = "vPROVIDERANDUSER_"+sGXsfl_28_fel_idx;
         edtSecUserId_Internalname = "SECUSERID_"+sGXsfl_28_fel_idx;
         edtSecUserName_Internalname = "SECUSERNAME_"+sGXsfl_28_fel_idx;
         edtSecUserCrtUser_Internalname = "SECUSERCRTUSER_"+sGXsfl_28_fel_idx;
         edtSecUserUpdUser_Internalname = "SECUSERUPDUSER_"+sGXsfl_28_fel_idx;
         edtSecUserCrtDate_Internalname = "SECUSERCRTDATE_"+sGXsfl_28_fel_idx;
         edtSecUserUpdDate_Internalname = "SECUSERUPDDATE_"+sGXsfl_28_fel_idx;
      }

      protected void sendrow_282( )
      {
         SubsflControlProps_282( ) ;
         WB0K0( ) ;
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
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV12Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV12Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV96Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV12Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV12Update)) ? AV96Update_GXI : context.PathToRelativeUrl( AV12Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavUpdate_Visible,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV12Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDeleteuserallinfo_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavDeleteuserallinfo_Enabled!=0)&&(edtavDeleteuserallinfo_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 30,'',false,'',28)\"" : " ");
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV91deleteUserAllInfo_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV91deleteUserAllInfo))&&String.IsNullOrEmpty(StringUtil.RTrim( AV97Deleteuserallinfo_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV91deleteUserAllInfo)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV91deleteUserAllInfo)) ? AV97Deleteuserallinfo_GXI : context.PathToRelativeUrl( AV91deleteUserAllInfo));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDeleteuserallinfo_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(int)edtavDeleteuserallinfo_Visible,(short)1,(String)"",(String)edtavDeleteuserallinfo_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)7,(String)edtavDeleteuserallinfo_Jsonclick,(String)"'"+""+"'"+",false,"+"'"+"e180k2_client"+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV91deleteUserAllInfo_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavUaassociateroles_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV15UAAssociateRoles_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV15UAAssociateRoles))&&String.IsNullOrEmpty(StringUtil.RTrim( AV98Uaassociateroles_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV15UAAssociateRoles)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV15UAAssociateRoles)) ? AV98Uaassociateroles_GXI : context.PathToRelativeUrl( AV15UAAssociateRoles));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUaassociateroles_Internalname,(String)sImgUrl,(String)edtavUaassociateroles_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavUaassociateroles_Visible,(short)1,(String)"",(String)edtavUaassociateroles_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV15UAAssociateRoles_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavProvideranduser_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV87ProviderAndUser_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV87ProviderAndUser))&&String.IsNullOrEmpty(StringUtil.RTrim( AV99Provideranduser_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV87ProviderAndUser)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV87ProviderAndUser)) ? AV99Provideranduser_GXI : context.PathToRelativeUrl( AV87ProviderAndUser));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavProvideranduser_Internalname,(String)sImgUrl,(String)edtavProvideranduser_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavProvideranduser_Visible,(short)1,(String)"",(String)edtavProvideranduser_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV87ProviderAndUser_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecUserId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A6SecUserId), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A6SecUserId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSecUserId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecUserName_Internalname,(String)A14SecUserName,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSecUserName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecUserCrtUser_Internalname,(String)A178SecUserCrtUser,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSecUserCrtUser_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)true,(String)"CrtUser",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecUserUpdUser_Internalname,(String)A179SecUserUpdUser,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSecUserUpdUser_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)true,(String)"UpdUser",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecUserCrtDate_Internalname,context.localUtil.TToC( A180SecUserCrtDate, 10, 8, 0, 0, "/", ":", " "),context.localUtil.Format( A180SecUserCrtDate, "99/99/99 99:99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSecUserCrtDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)14,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)true,(String)"CrtDate",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecUserUpdDate_Internalname,context.localUtil.TToC( A181SecUserUpdDate, 10, 8, 0, 0, "/", ":", " "),context.localUtil.Format( A181SecUserUpdDate, "9999/99/99 99:99:99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSecUserUpdDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)19,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)true,(String)"UpdDate",(String)"right",(bool)false});
            send_integrity_lvl_hashes0K2( ) ;
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
         edtavUpdate_Internalname = "vUPDATE";
         edtavDeleteuserallinfo_Internalname = "vDELETEUSERALLINFO";
         edtavUaassociateroles_Internalname = "vUAASSOCIATEROLES";
         edtavProvideranduser_Internalname = "vPROVIDERANDUSER";
         edtSecUserId_Internalname = "SECUSERID";
         edtSecUserName_Internalname = "SECUSERNAME";
         edtSecUserCrtUser_Internalname = "SECUSERCRTUSER";
         edtSecUserUpdUser_Internalname = "SECUSERUPDUSER";
         edtSecUserCrtDate_Internalname = "SECUSERCRTDATE";
         edtSecUserUpdDate_Internalname = "SECUSERUPDDATE";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_secusername_Internalname = "DDO_SECUSERNAME";
         edtavDdo_secusernametitlecontrolidtoreplace_Internalname = "vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE";
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
         edtSecUserUpdDate_Jsonclick = "";
         edtSecUserCrtDate_Jsonclick = "";
         edtSecUserUpdUser_Jsonclick = "";
         edtSecUserCrtUser_Jsonclick = "";
         edtSecUserName_Jsonclick = "";
         edtSecUserId_Jsonclick = "";
         edtavDeleteuserallinfo_Jsonclick = "";
         edtavDeleteuserallinfo_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_secusernametitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavProvideranduser_Tooltiptext = "";
         edtavProvideranduser_Link = "";
         edtavUaassociateroles_Tooltiptext = "";
         edtavUaassociateroles_Link = "";
         edtavDeleteuserallinfo_Tooltiptext = "";
         edtavUpdate_Tooltiptext = "修改";
         edtavUpdate_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtSecUserName_Titleformat = 0;
         edtSecUserName_Title = "姓名";
         edtavProvideranduser_Visible = -1;
         edtavUaassociateroles_Visible = -1;
         edtavDeleteuserallinfo_Visible = -1;
         edtavUpdate_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         bttBtninsert_Visible = 1;
         Ddo_secusername_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_secusername_Sortdsc = "WWP_TSSortDSC";
         Ddo_secusername_Sortasc = "WWP_TSSortASC";
         Ddo_secusername_Includedatalist = Convert.ToBoolean( 0);
         Ddo_secusername_Includefilter = Convert.ToBoolean( 0);
         Ddo_secusername_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_secusername_Includesortasc = Convert.ToBoolean( -1);
         Ddo_secusername_Titlecontrolidtoreplace = "";
         Ddo_secusername_Dropdownoptionstype = "GridTitleSettings";
         Ddo_secusername_Cls = "ColumnSettings";
         Ddo_secusername_Tooltip = "WWP_TSColumnOptions";
         Ddo_secusername_Caption = "";
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
         Form.Caption = "Work With User";
         subGrid_Rows = 0;
         edtavUaassociateroles_Title = "";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'edtavUaassociateroles_Title',ctrl:'vUAASSOCIATEROLES',prop:'Title'},{av:'AV17IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV16IsAuthorized_UAAssociateRoles',fld:'vISAUTHORIZED_UAASSOCIATEROLES',pic:''},{av:'AV93IsAuthorized_ProviderAndUser',fld:'vISAUTHORIZED_PROVIDERANDUSER',pic:''},{av:'AV53ddo_SecUserNameTitleControlIdToReplace',fld:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV100Pgmname',fld:'vPGMNAME',pic:''},{av:'AV23OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV24OrderedDsc',fld:'vORDEREDDSC',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV89IsRocheUser',fld:'vISROCHEUSER',pic:''},{av:'AV50SecUserNameTitleFilterData',fld:'vSECUSERNAMETITLEFILTERDATA',pic:''},{av:'edtSecUserName_Titleformat',ctrl:'SECUSERNAME',prop:'Titleformat'},{av:'edtSecUserName_Title',ctrl:'SECUSERNAME',prop:'Title'},{av:'AV81GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV83GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV84GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV17IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'edtavDeleteuserallinfo_Visible',ctrl:'vDELETEUSERALLINFO',prop:'Visible'},{av:'AV16IsAuthorized_UAAssociateRoles',fld:'vISAUTHORIZED_UAASSOCIATEROLES',pic:''},{av:'edtavUaassociateroles_Visible',ctrl:'vUAASSOCIATEROLES',prop:'Visible'},{av:'AV93IsAuthorized_ProviderAndUser',fld:'vISAUTHORIZED_PROVIDERANDUSER',pic:''},{av:'edtavProvideranduser_Visible',ctrl:'vPROVIDERANDUSER',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E110K2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV23OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV24OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV53ddo_SecUserNameTitleControlIdToReplace',fld:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV100Pgmname',fld:'vPGMNAME',pic:''},{av:'edtavUaassociateroles_Title',ctrl:'vUAASSOCIATEROLES',prop:'Title'},{av:'AV17IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV16IsAuthorized_UAAssociateRoles',fld:'vISAUTHORIZED_UAASSOCIATEROLES',pic:''},{av:'AV93IsAuthorized_ProviderAndUser',fld:'vISAUTHORIZED_PROVIDERANDUSER',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E120K2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV23OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV24OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV53ddo_SecUserNameTitleControlIdToReplace',fld:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV100Pgmname',fld:'vPGMNAME',pic:''},{av:'edtavUaassociateroles_Title',ctrl:'vUAASSOCIATEROLES',prop:'Title'},{av:'AV17IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV16IsAuthorized_UAAssociateRoles',fld:'vISAUTHORIZED_UAASSOCIATEROLES',pic:''},{av:'AV93IsAuthorized_ProviderAndUser',fld:'vISAUTHORIZED_PROVIDERANDUSER',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_SECUSERNAME.ONOPTIONCLICKED","{handler:'E130K2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV23OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV24OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV53ddo_SecUserNameTitleControlIdToReplace',fld:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV100Pgmname',fld:'vPGMNAME',pic:''},{av:'edtavUaassociateroles_Title',ctrl:'vUAASSOCIATEROLES',prop:'Title'},{av:'AV17IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV16IsAuthorized_UAAssociateRoles',fld:'vISAUTHORIZED_UAASSOCIATEROLES',pic:''},{av:'AV93IsAuthorized_ProviderAndUser',fld:'vISAUTHORIZED_PROVIDERANDUSER',pic:''},{av:'Ddo_secusername_Activeeventkey',ctrl:'DDO_SECUSERNAME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_SECUSERNAME.ONOPTIONCLICKED",",oparms:[{av:'AV23OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV24OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_secusername_Sortedstatus',ctrl:'DDO_SECUSERNAME',prop:'SortedStatus'},{av:'AV89IsRocheUser',fld:'vISROCHEUSER',pic:''},{av:'AV50SecUserNameTitleFilterData',fld:'vSECUSERNAMETITLEFILTERDATA',pic:''},{av:'edtSecUserName_Titleformat',ctrl:'SECUSERNAME',prop:'Titleformat'},{av:'edtSecUserName_Title',ctrl:'SECUSERNAME',prop:'Title'},{av:'AV81GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV83GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV84GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV17IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'edtavDeleteuserallinfo_Visible',ctrl:'vDELETEUSERALLINFO',prop:'Visible'},{av:'AV16IsAuthorized_UAAssociateRoles',fld:'vISAUTHORIZED_UAASSOCIATEROLES',pic:''},{av:'edtavUaassociateroles_Visible',ctrl:'vUAASSOCIATEROLES',prop:'Visible'},{av:'AV93IsAuthorized_ProviderAndUser',fld:'vISAUTHORIZED_PROVIDERANDUSER',pic:''},{av:'edtavProvideranduser_Visible',ctrl:'vPROVIDERANDUSER',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E170K2',iparms:[{av:'AV17IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'A6SecUserId',fld:'SECUSERID',pic:'ZZZ9',hsh:true},{av:'AV16IsAuthorized_UAAssociateRoles',fld:'vISAUTHORIZED_UAASSOCIATEROLES',pic:''},{av:'AV93IsAuthorized_ProviderAndUser',fld:'vISAUTHORIZED_PROVIDERANDUSER',pic:''}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV12Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV91deleteUserAllInfo',fld:'vDELETEUSERALLINFO',pic:''},{av:'edtavDeleteuserallinfo_Tooltiptext',ctrl:'vDELETEUSERALLINFO',prop:'Tooltiptext'},{av:'AV15UAAssociateRoles',fld:'vUAASSOCIATEROLES',pic:''},{av:'edtavUaassociateroles_Tooltiptext',ctrl:'vUAASSOCIATEROLES',prop:'Tooltiptext'},{av:'edtavUaassociateroles_Link',ctrl:'vUAASSOCIATEROLES',prop:'Link'},{av:'AV87ProviderAndUser',fld:'vPROVIDERANDUSER',pic:''},{av:'edtavProvideranduser_Tooltiptext',ctrl:'vPROVIDERANDUSER',prop:'Tooltiptext'},{av:'edtavProvideranduser_Link',ctrl:'vPROVIDERANDUSER',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E140K2',iparms:[{av:'A6SecUserId',fld:'SECUSERID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("'DOINSERT'",",oparms:[]}");
         setEventMetadata("VDELETEUSERALLINFO.CLICK","{handler:'E180K2',iparms:[{av:'A6SecUserId',fld:'SECUSERID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("VDELETEUSERALLINFO.CLICK",",oparms:[]}");
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
         Ddo_secusername_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV53ddo_SecUserNameTitleControlIdToReplace = "";
         AV100Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV54DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV50SecUserNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_secusername_Sortedstatus = "";
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
         AV12Update = "";
         AV91deleteUserAllInfo = "";
         AV15UAAssociateRoles = "";
         AV87ProviderAndUser = "";
         A14SecUserName = "";
         A178SecUserCrtUser = "";
         A179SecUserUpdUser = "";
         A180SecUserCrtDate = (DateTime)(DateTime.MinValue);
         A181SecUserUpdDate = (DateTime)(DateTime.MinValue);
         ucGridpaginationbar = new GXUserControl();
         ucDdo_secusername = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV96Update_GXI = "";
         AV97Deleteuserallinfo_GXI = "";
         AV98Uaassociateroles_GXI = "";
         AV99Provideranduser_GXI = "";
         scmdbuf = "";
         AV90oSecUserIds = new GxSimpleCollection<short>();
         H000K2_A181SecUserUpdDate = new DateTime[] {DateTime.MinValue} ;
         H000K2_n181SecUserUpdDate = new bool[] {false} ;
         H000K2_A180SecUserCrtDate = new DateTime[] {DateTime.MinValue} ;
         H000K2_n180SecUserCrtDate = new bool[] {false} ;
         H000K2_A179SecUserUpdUser = new String[] {""} ;
         H000K2_n179SecUserUpdUser = new bool[] {false} ;
         H000K2_A178SecUserCrtUser = new String[] {""} ;
         H000K2_n178SecUserCrtUser = new bool[] {false} ;
         H000K2_A14SecUserName = new String[] {""} ;
         H000K2_A6SecUserId = new short[1] ;
         H000K3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV88tJC_ProviderIDs = new GxSimpleCollection<long>();
         GXt_objcol_int2 = new GxSimpleCollection<long>();
         GXt_objcol_int3 = new GxSimpleCollection<short>();
         AV79WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         AV14Session = context.GetSession();
         AV20GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV8HTTPRequest = new GxHttpRequest( context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secuserww__default(),
            new Object[][] {
                new Object[] {
               H000K2_A181SecUserUpdDate, H000K2_n181SecUserUpdDate, H000K2_A180SecUserCrtDate, H000K2_n180SecUserCrtDate, H000K2_A179SecUserUpdUser, H000K2_n179SecUserUpdUser, H000K2_A178SecUserCrtUser, H000K2_n178SecUserCrtUser, H000K2_A14SecUserName, H000K2_A6SecUserId
               }
               , new Object[] {
               H000K3_AGRID_nRecordCount
               }
            }
         );
         AV100Pgmname = "WWPBaseObjects.SecUserWW";
         /* GeneXus formulas. */
         AV100Pgmname = "WWPBaseObjects.SecUserWW";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_28 ;
      private short nGXsfl_28_idx=1 ;
      private short GRID_nEOF ;
      private short AV23OrderedBy ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtSecUserName_Titleformat ;
      private short subGrid_Sortable ;
      private short A6SecUserId ;
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
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavUpdate_Visible ;
      private int edtavDeleteuserallinfo_Visible ;
      private int edtavUaassociateroles_Visible ;
      private int edtavProvideranduser_Visible ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_secusernametitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV80PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavDeleteuserallinfo_Enabled ;
      private long GRID_nFirstRecordOnPage ;
      private long AV81GridCurrentPage ;
      private long AV84GridRecordCount ;
      private long AV83GridPageSize ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String edtavUaassociateroles_Title ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_secusername_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_28_idx="0001" ;
      private String edtavUaassociateroles_Internalname ;
      private String AV100Pgmname ;
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
      private String Ddo_secusername_Caption ;
      private String Ddo_secusername_Tooltip ;
      private String Ddo_secusername_Cls ;
      private String Ddo_secusername_Dropdownoptionstype ;
      private String Ddo_secusername_Titlecontrolidtoreplace ;
      private String Ddo_secusername_Sortedstatus ;
      private String Ddo_secusername_Sortasc ;
      private String Ddo_secusername_Sortdsc ;
      private String Ddo_secusername_Searchbuttontext ;
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
      private String edtSecUserName_Title ;
      private String subGrid_Header ;
      private String edtavUpdate_Link ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavDeleteuserallinfo_Tooltiptext ;
      private String edtavUaassociateroles_Link ;
      private String edtavUaassociateroles_Tooltiptext ;
      private String edtavProvideranduser_Link ;
      private String edtavProvideranduser_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_secusername_Internalname ;
      private String edtavDdo_secusernametitlecontrolidtoreplace_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavUpdate_Internalname ;
      private String edtavDeleteuserallinfo_Internalname ;
      private String edtavProvideranduser_Internalname ;
      private String edtSecUserId_Internalname ;
      private String edtSecUserName_Internalname ;
      private String edtSecUserCrtUser_Internalname ;
      private String edtSecUserUpdUser_Internalname ;
      private String edtSecUserCrtDate_Internalname ;
      private String edtSecUserUpdDate_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_28_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavDeleteuserallinfo_Jsonclick ;
      private String ROClassString ;
      private String edtSecUserId_Jsonclick ;
      private String edtSecUserName_Jsonclick ;
      private String edtSecUserCrtUser_Jsonclick ;
      private String edtSecUserUpdUser_Jsonclick ;
      private String edtSecUserCrtDate_Jsonclick ;
      private String edtSecUserUpdDate_Jsonclick ;
      private DateTime A180SecUserCrtDate ;
      private DateTime A181SecUserUpdDate ;
      private bool entryPointCalled ;
      private bool bGXsfl_28_Refreshing=false ;
      private bool AV24OrderedDsc ;
      private bool AV17IsAuthorized_Update ;
      private bool AV16IsAuthorized_UAAssociateRoles ;
      private bool AV93IsAuthorized_ProviderAndUser ;
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
      private bool Ddo_secusername_Includesortasc ;
      private bool Ddo_secusername_Includesortdsc ;
      private bool Ddo_secusername_Includefilter ;
      private bool Ddo_secusername_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n178SecUserCrtUser ;
      private bool n179SecUserUpdUser ;
      private bool n180SecUserCrtDate ;
      private bool n181SecUserUpdDate ;
      private bool gxdyncontrolsrefreshing ;
      private bool AV89IsRocheUser ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV92IsAuthorized_deleteUserAllInfo ;
      private bool AV19TempBoolean ;
      private bool GXt_boolean4 ;
      private bool AV12Update_IsBlob ;
      private bool AV91deleteUserAllInfo_IsBlob ;
      private bool AV15UAAssociateRoles_IsBlob ;
      private bool AV87ProviderAndUser_IsBlob ;
      private String AV53ddo_SecUserNameTitleControlIdToReplace ;
      private String A14SecUserName ;
      private String A178SecUserCrtUser ;
      private String A179SecUserUpdUser ;
      private String AV96Update_GXI ;
      private String AV97Deleteuserallinfo_GXI ;
      private String AV98Uaassociateroles_GXI ;
      private String AV99Provideranduser_GXI ;
      private String AV12Update ;
      private String AV91deleteUserAllInfo ;
      private String AV15UAAssociateRoles ;
      private String AV87ProviderAndUser ;
      private GxSimpleCollection<short> AV90oSecUserIds ;
      private GxSimpleCollection<short> GXt_objcol_int3 ;
      private GxSimpleCollection<long> AV88tJC_ProviderIDs ;
      private GxSimpleCollection<long> GXt_objcol_int2 ;
      private IGxSession AV14Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_secusername ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private DateTime[] H000K2_A181SecUserUpdDate ;
      private bool[] H000K2_n181SecUserUpdDate ;
      private DateTime[] H000K2_A180SecUserCrtDate ;
      private bool[] H000K2_n180SecUserCrtDate ;
      private String[] H000K2_A179SecUserUpdUser ;
      private bool[] H000K2_n179SecUserUpdUser ;
      private String[] H000K2_A178SecUserCrtUser ;
      private bool[] H000K2_n178SecUserCrtUser ;
      private String[] H000K2_A14SecUserName ;
      private short[] H000K2_A6SecUserId ;
      private long[] H000K3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV50SecUserNameTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV79WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV20GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV54DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class secuserww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H000K2( IGxContext context ,
                                             short A6SecUserId ,
                                             GxSimpleCollection<short> AV90oSecUserIds ,
                                             bool AV89IsRocheUser ,
                                             short AV23OrderedBy ,
                                             bool AV24OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [3] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [SecUserUpdDate], [SecUserCrtDate], [SecUserUpdUser], [SecUserCrtUser], [SecUserName], [SecUserId]";
         sFromString = " FROM [SecUser] WITH (NOLOCK)";
         sOrderString = "";
         if ( ! AV89IsRocheUser )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV90oSecUserIds, "[SecUserId] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV90oSecUserIds, "[SecUserId] IN (", ")") + ")";
            }
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         if ( AV23OrderedBy == 1 )
         {
            sOrderString = sOrderString + " ORDER BY [SecUserId] DESC";
         }
         else if ( ( AV23OrderedBy == 2 ) && ! AV24OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [SecUserName]";
         }
         else if ( ( AV23OrderedBy == 2 ) && ( AV24OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [SecUserName] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [SecUserId]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object6[0] = scmdbuf;
         GXv_Object6[1] = GXv_int5;
         return GXv_Object6 ;
      }

      protected Object[] conditional_H000K3( IGxContext context ,
                                             short A6SecUserId ,
                                             GxSimpleCollection<short> AV90oSecUserIds ,
                                             bool AV89IsRocheUser ,
                                             short AV23OrderedBy ,
                                             bool AV24OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         Object[] GXv_Object7 ;
         GXv_Object7 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [SecUser] WITH (NOLOCK)";
         if ( ! AV89IsRocheUser )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV90oSecUserIds, "[SecUserId] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV90oSecUserIds, "[SecUserId] IN (", ")") + ")";
            }
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         if ( AV23OrderedBy == 1 )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV23OrderedBy == 2 ) && ! AV24OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV23OrderedBy == 2 ) && ( AV24OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( true )
         {
            scmdbuf = scmdbuf + "";
         }
         GXv_Object7[0] = scmdbuf;
         return GXv_Object7 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H000K2(context, (short)dynConstraints[0] , (GxSimpleCollection<short>)dynConstraints[1] , (bool)dynConstraints[2] , (short)dynConstraints[3] , (bool)dynConstraints[4] );
               case 1 :
                     return conditional_H000K3(context, (short)dynConstraints[0] , (GxSimpleCollection<short>)dynConstraints[1] , (bool)dynConstraints[2] , (short)dynConstraints[3] , (bool)dynConstraints[4] );
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
          Object[] prmH000K2 ;
          prmH000K2 = new Object[] {
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH000K3 ;
          prmH000K3 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H000K2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000K2,11,0,true,false )
             ,new CursorDef("H000K3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000K3,1,0,true,false )
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
                ((DateTime[]) buf[0])[0] = rslt.getGXDateTime(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
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

 }

}
