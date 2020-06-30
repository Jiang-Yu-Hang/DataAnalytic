/*
               File: WWPBaseObjects.SecRoleSecUserRoleAssociationWW
        Description: 角色相关
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 12:1:2.32
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
   public class secrolesecuserroleassociationww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public secrolesecuserroleassociationww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public secrolesecuserroleassociationww( IGxContext context )
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

      protected override void createObjects( )
      {
         chkavIsassociated = new GXCheckbox();
         chkavIsassociatedold = new GXCheckbox();
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
               nRC_GXsfl_25 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_25_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_25_idx = GetNextPar( );
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
               AV24SecUserName = GetNextPar( );
               AV23OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV26ddo_SecUserNameTitleControlIdToReplace = GetNextPar( );
               AV15SecUserIdRemovedXml = GetNextPar( );
               AV14SecUserIdAddedXml = GetNextPar( );
               AV8SecRoleId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               A4SecRoleId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV20i = (long)(NumberUtil.Val( GetNextPar( ), "."));
               ajax_req_read_hidden_sdt(GetNextPar( ), AV11SecUserIdRemoved);
               AV13SecUserIdToFind = (short)(NumberUtil.Val( GetNextPar( ), "."));
               ajax_req_read_hidden_sdt(GetNextPar( ), AV10SecUserIdAdded);
               AV9SecRoleIdParm = (short)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV24SecUserName, AV23OrderedDsc, AV26ddo_SecUserNameTitleControlIdToReplace, AV15SecUserIdRemovedXml, AV14SecUserIdAddedXml, AV8SecRoleId, A4SecRoleId, AV20i, AV11SecUserIdRemoved, AV13SecUserIdToFind, AV10SecUserIdAdded, AV9SecRoleIdParm) ;
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
            if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
            {
               AV8SecRoleId = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8SecRoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8SecRoleId), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vSECROLEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8SecRoleId), "ZZZ9"), context));
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
         PA442( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START442( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2020227121244", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
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
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("wwpbaseobjects.secrolesecuserroleassociationww.aspx") + "?" + UrlEncode("" +AV8SecRoleId)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vSECUSERNAME", AV24SecUserName);
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV23OrderedDsc));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_25", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_25), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV29GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV31GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV30GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV27DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV27DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vSECUSERNAMETITLEFILTERDATA", AV25SecUserNameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vSECUSERNAMETITLEFILTERDATA", AV25SecUserNameTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vSECROLEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8SecRoleId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vSECROLEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8SecRoleId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "SECROLEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A4SecRoleId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vI", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV20i), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vSECUSERIDREMOVED", AV11SecUserIdRemoved);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vSECUSERIDREMOVED", AV11SecUserIdRemoved);
         }
         GxWebStd.gx_hidden_field( context, "vSECUSERIDTOFIND", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13SecUserIdToFind), 4, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vSECUSERIDADDED", AV10SecUserIdAdded);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vSECUSERIDADDED", AV10SecUserIdAdded);
         }
         GxWebStd.gx_hidden_field( context, "vSECROLEIDPARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9SecRoleIdParm), 4, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vSECUSERROLE", AV21SecUserRole);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vSECUSERROLE", AV21SecUserRole);
         }
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Width", StringUtil.RTrim( Dvpanel_unnamedtable1_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Cls", StringUtil.RTrim( Dvpanel_unnamedtable1_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Title", StringUtil.RTrim( Dvpanel_unnamedtable1_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Collapsible", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Collapsed", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Autowidth", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Autoheight", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Iconposition", StringUtil.RTrim( Dvpanel_unnamedtable1_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Autoscroll", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Autoscroll));
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
            WE442( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT442( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("wwpbaseobjects.secrolesecuserroleassociationww.aspx") + "?" + UrlEncode("" +AV8SecRoleId) ;
      }

      public override String GetPgmname( )
      {
         return "WWPBaseObjects.SecRoleSecUserRoleAssociationWW" ;
      }

      public override String GetPgmdesc( )
      {
         return "角色相关" ;
      }

      protected void WB440( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_unnamedtable1_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDvpanel_unnamedtable1.SetProperty("Width", Dvpanel_unnamedtable1_Width);
            ucDvpanel_unnamedtable1.SetProperty("AutoWidth", Dvpanel_unnamedtable1_Autowidth);
            ucDvpanel_unnamedtable1.SetProperty("AutoHeight", Dvpanel_unnamedtable1_Autoheight);
            ucDvpanel_unnamedtable1.SetProperty("Cls", Dvpanel_unnamedtable1_Cls);
            ucDvpanel_unnamedtable1.SetProperty("Title", Dvpanel_unnamedtable1_Title);
            ucDvpanel_unnamedtable1.SetProperty("Collapsible", Dvpanel_unnamedtable1_Collapsible);
            ucDvpanel_unnamedtable1.SetProperty("Collapsed", Dvpanel_unnamedtable1_Collapsed);
            ucDvpanel_unnamedtable1.SetProperty("ShowCollapseIcon", Dvpanel_unnamedtable1_Showcollapseicon);
            ucDvpanel_unnamedtable1.SetProperty("IconPosition", Dvpanel_unnamedtable1_Iconposition);
            ucDvpanel_unnamedtable1.SetProperty("AutoScroll", Dvpanel_unnamedtable1_Autoscroll);
            ucDvpanel_unnamedtable1.Render(context, "dvelop.gxbootstrap.panel", Dvpanel_unnamedtable1_Internalname, "DVPANEL_UNNAMEDTABLE1Container");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_UNNAMEDTABLE1Container"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_unnamedtable1_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            wb_table1_14_442( true) ;
         }
         else
         {
            wb_table1_14_442( false) ;
         }
         return  ;
      }

      protected void wb_table1_14_442e( bool wbgen )
      {
         if ( wbgen )
         {
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"25\">") ;
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"AttributeCheckBox"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
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
               context.SendWebValue( "密码") ;
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
               GridColumn.AddObjectProperty("Value", StringUtil.BoolToStr( AV18IsAssociated));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.BoolToStr( AV19IsAssociatedOld));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkavIsassociatedold.Enabled), 5, 0, ".", "")));
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
               GridColumn.AddObjectProperty("Value", A15SecUserPassword);
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
         if ( wbEnd == 25 )
         {
            wbEnd = 0;
            nRC_GXsfl_25 = (short)(nGXsfl_25_idx-1);
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV29GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV31GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV30GridPageSize);
            ucGridpaginationbar.Render(context, "dvelop.dvpaginationbar", Gridpaginationbar_Internalname, "GRIDPAGINATIONBARContainer");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnconfirm_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(25), 2, 0)+","+"null"+");", "保存", bttBtnconfirm_Jsonclick, 5, "确认", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\SecRoleSecUserRoleAssociationWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(25), 2, 0)+","+"null"+");", "取消", bttBtncancel_Jsonclick, 1, "取消", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\SecRoleSecUserRoleAssociationWW.htm");
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
            ucDdo_secusername.SetProperty("DropDownOptionsTitleSettingsIcons", AV27DDO_TitleSettingsIcons);
            ucDdo_secusername.SetProperty("DropDownOptionsData", AV25SecUserNameTitleFilterData);
            ucDdo_secusername.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_secusername_Internalname, "DDO_SECUSERNAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_25_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_secusernametitlecontrolidtoreplace_Internalname, AV26ddo_SecUserNameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", 0, edtavDdo_secusernametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WWPBaseObjects\\SecRoleSecUserRoleAssociationWW.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'" + sGXsfl_25_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavSecuseridaddedxml_Internalname, AV14SecUserIdAddedXml, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,47);\"", 0, edtavSecuseridaddedxml_Visible, 1, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "2097152", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WWPBaseObjects\\SecRoleSecUserRoleAssociationWW.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'" + sGXsfl_25_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavSecuseridremovedxml_Internalname, AV15SecUserIdRemovedXml, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", 0, edtavSecuseridremovedxml_Visible, 1, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "2097152", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WWPBaseObjects\\SecRoleSecUserRoleAssociationWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'" + sGXsfl_25_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV23OrderedDsc), StringUtil.BoolToStr( AV23OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_WWPBaseObjects\\SecRoleSecUserRoleAssociationWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 25 )
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

      protected void START442( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "角色相关", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP440( ) ;
      }

      protected void WS442( )
      {
         START442( ) ;
         EVT442( ) ;
      }

      protected void EVT442( )
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
                              E11442 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E12442 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_SECUSERNAME.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E13442 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false;
                                 /* Set Refresh If Secusername Changed */
                                 if ( StringUtil.StrCmp(cgiGet( "GXH_vSECUSERNAME"), AV24SecUserName) != 0 )
                                 {
                                    Rfr0gs = true;
                                 }
                                 /* Set Refresh If Ordereddsc Changed */
                                 if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV23OrderedDsc )
                                 {
                                    Rfr0gs = true;
                                 }
                                 if ( ! Rfr0gs )
                                 {
                                    /* Execute user event: Enter */
                                    E14442 ();
                                 }
                                 dynload_actions( ) ;
                              }
                              /* No code required for Cancel button. It is implemented as the Reset button. */
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 19), "VISASSOCIATED.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 19), "VISASSOCIATED.CLICK") == 0 ) )
                           {
                              nGXsfl_25_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_25_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_25_idx), 4, 0)), 4, "0");
                              SubsflControlProps_252( ) ;
                              AV18IsAssociated = StringUtil.StrToBool( cgiGet( chkavIsassociated_Internalname));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavIsassociated_Internalname, AV18IsAssociated);
                              AV19IsAssociatedOld = StringUtil.StrToBool( cgiGet( chkavIsassociatedold_Internalname));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavIsassociatedold_Internalname, AV19IsAssociatedOld);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vISASSOCIATEDOLD"+"_"+sGXsfl_25_idx, GetSecureSignedToken( sGXsfl_25_idx, AV19IsAssociatedOld, context));
                              A6SecUserId = (short)(context.localUtil.CToN( cgiGet( edtSecUserId_Internalname), ".", ","));
                              A14SecUserName = cgiGet( edtSecUserName_Internalname);
                              A15SecUserPassword = cgiGet( edtSecUserPassword_Internalname);
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E15442 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E16442 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E17442 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VISASSOCIATED.CLICK") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E18442 ();
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

      protected void WE442( )
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

      protected void PA442( )
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
               GX_FocusControl = edtavSecusername_Internalname;
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
         SubsflControlProps_252( ) ;
         while ( nGXsfl_25_idx <= nRC_GXsfl_25 )
         {
            sendrow_252( ) ;
            nGXsfl_25_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_25_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_25_idx+1));
            sGXsfl_25_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_25_idx), 4, 0)), 4, "0");
            SubsflControlProps_252( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       String AV24SecUserName ,
                                       bool AV23OrderedDsc ,
                                       String AV26ddo_SecUserNameTitleControlIdToReplace ,
                                       String AV15SecUserIdRemovedXml ,
                                       String AV14SecUserIdAddedXml ,
                                       short AV8SecRoleId ,
                                       short A4SecRoleId ,
                                       long AV20i ,
                                       GxSimpleCollection<short> AV11SecUserIdRemoved ,
                                       short AV13SecUserIdToFind ,
                                       GxSimpleCollection<short> AV10SecUserIdAdded ,
                                       short AV9SecRoleIdParm )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF442( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_SECUSERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A6SecUserId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "SECUSERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A6SecUserId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vISASSOCIATEDOLD", GetSecureSignedToken( "", AV19IsAssociatedOld, context));
         GxWebStd.gx_hidden_field( context, "vISASSOCIATEDOLD", StringUtil.BoolToStr( AV19IsAssociatedOld));
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
         RF442( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         chkavIsassociatedold.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavIsassociatedold_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavIsassociatedold.Enabled), 5, 0)), !bGXsfl_25_Refreshing);
      }

      protected void RF442( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 25;
         /* Execute user event: Refresh */
         E16442 ();
         nGXsfl_25_idx = 1;
         sGXsfl_25_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_25_idx), 4, 0)), 4, "0");
         SubsflControlProps_252( ) ;
         bGXsfl_25_Refreshing = true;
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
            SubsflControlProps_252( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV24SecUserName ,
                                                 A14SecUserName ,
                                                 AV23OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV24SecUserName = StringUtil.Concat( StringUtil.RTrim( AV24SecUserName), "%", "");
            /* Using cursor H00442 */
            pr_default.execute(0, new Object[] {lV24SecUserName, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_25_idx = 1;
            sGXsfl_25_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_25_idx), 4, 0)), 4, "0");
            SubsflControlProps_252( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A6SecUserId = H00442_A6SecUserId[0];
               A15SecUserPassword = H00442_A15SecUserPassword[0];
               A14SecUserName = H00442_A14SecUserName[0];
               E17442 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 25;
            WB440( ) ;
         }
         bGXsfl_25_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes442( )
      {
         GxWebStd.gx_hidden_field( context, "vSECROLEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8SecRoleId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vSECROLEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8SecRoleId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_SECUSERID"+"_"+sGXsfl_25_idx, GetSecureSignedToken( sGXsfl_25_idx, context.localUtil.Format( (decimal)(A6SecUserId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_vISASSOCIATEDOLD"+"_"+sGXsfl_25_idx, GetSecureSignedToken( sGXsfl_25_idx, AV19IsAssociatedOld, context));
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
                                              AV24SecUserName ,
                                              A14SecUserName ,
                                              AV23OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV24SecUserName = StringUtil.Concat( StringUtil.RTrim( AV24SecUserName), "%", "");
         /* Using cursor H00443 */
         pr_default.execute(1, new Object[] {lV24SecUserName});
         GRID_nRecordCount = H00443_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV24SecUserName, AV23OrderedDsc, AV26ddo_SecUserNameTitleControlIdToReplace, AV15SecUserIdRemovedXml, AV14SecUserIdAddedXml, AV8SecRoleId, A4SecRoleId, AV20i, AV11SecUserIdRemoved, AV13SecUserIdToFind, AV10SecUserIdAdded, AV9SecRoleIdParm) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV24SecUserName, AV23OrderedDsc, AV26ddo_SecUserNameTitleControlIdToReplace, AV15SecUserIdRemovedXml, AV14SecUserIdAddedXml, AV8SecRoleId, A4SecRoleId, AV20i, AV11SecUserIdRemoved, AV13SecUserIdToFind, AV10SecUserIdAdded, AV9SecRoleIdParm) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV24SecUserName, AV23OrderedDsc, AV26ddo_SecUserNameTitleControlIdToReplace, AV15SecUserIdRemovedXml, AV14SecUserIdAddedXml, AV8SecRoleId, A4SecRoleId, AV20i, AV11SecUserIdRemoved, AV13SecUserIdToFind, AV10SecUserIdAdded, AV9SecRoleIdParm) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV24SecUserName, AV23OrderedDsc, AV26ddo_SecUserNameTitleControlIdToReplace, AV15SecUserIdRemovedXml, AV14SecUserIdAddedXml, AV8SecRoleId, A4SecRoleId, AV20i, AV11SecUserIdRemoved, AV13SecUserIdToFind, AV10SecUserIdAdded, AV9SecRoleIdParm) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV24SecUserName, AV23OrderedDsc, AV26ddo_SecUserNameTitleControlIdToReplace, AV15SecUserIdRemovedXml, AV14SecUserIdAddedXml, AV8SecRoleId, A4SecRoleId, AV20i, AV11SecUserIdRemoved, AV13SecUserIdToFind, AV10SecUserIdAdded, AV9SecRoleIdParm) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP440( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         chkavIsassociatedold.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavIsassociatedold_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavIsassociatedold.Enabled), 5, 0)), !bGXsfl_25_Refreshing);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E15442 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV27DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vSECUSERNAMETITLEFILTERDATA"), AV25SecUserNameTitleFilterData);
            /* Read variables values. */
            AV24SecUserName = cgiGet( edtavSecusername_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24SecUserName", AV24SecUserName);
            AV26ddo_SecUserNameTitleControlIdToReplace = cgiGet( edtavDdo_secusernametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26ddo_SecUserNameTitleControlIdToReplace", AV26ddo_SecUserNameTitleControlIdToReplace);
            AV14SecUserIdAddedXml = cgiGet( edtavSecuseridaddedxml_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14SecUserIdAddedXml", AV14SecUserIdAddedXml);
            AV15SecUserIdRemovedXml = cgiGet( edtavSecuseridremovedxml_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15SecUserIdRemovedXml", AV15SecUserIdRemovedXml);
            AV23OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23OrderedDsc", AV23OrderedDsc);
            /* Read saved values. */
            nRC_GXsfl_25 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_25"), ".", ","));
            AV29GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV31GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV30GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID_nFirstRecordOnPage"), ".", ","));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID_nEOF"), ".", ","));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Dvpanel_unnamedtable1_Width = cgiGet( "DVPANEL_UNNAMEDTABLE1_Width");
            Dvpanel_unnamedtable1_Cls = cgiGet( "DVPANEL_UNNAMEDTABLE1_Cls");
            Dvpanel_unnamedtable1_Title = cgiGet( "DVPANEL_UNNAMEDTABLE1_Title");
            Dvpanel_unnamedtable1_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE1_Collapsible"));
            Dvpanel_unnamedtable1_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE1_Collapsed"));
            Dvpanel_unnamedtable1_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE1_Autowidth"));
            Dvpanel_unnamedtable1_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE1_Autoheight"));
            Dvpanel_unnamedtable1_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE1_Showcollapseicon"));
            Dvpanel_unnamedtable1_Iconposition = cgiGet( "DVPANEL_UNNAMEDTABLE1_Iconposition");
            Dvpanel_unnamedtable1_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE1_Autoscroll"));
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
            if ( StringUtil.StrCmp(cgiGet( "GXH_vSECUSERNAME"), AV24SecUserName) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV23OrderedDsc )
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
         E15442 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E15442( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_secusername_Titlecontrolidtoreplace = subGrid_Internalname+"_SecUserName";
         ucDdo_secusername.SendProperty(context, "", false, Ddo_secusername_Internalname, "TitleControlIdToReplace", Ddo_secusername_Titlecontrolidtoreplace);
         AV26ddo_SecUserNameTitleControlIdToReplace = Ddo_secusername_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26ddo_SecUserNameTitleControlIdToReplace", AV26ddo_SecUserNameTitleControlIdToReplace);
         edtavDdo_secusernametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_secusernametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_secusernametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "角色相关";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         edtavOrdereddsc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrdereddsc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrdereddsc_Visible), 5, 0)), true);
         edtavSecuseridaddedxml_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSecuseridaddedxml_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSecuseridaddedxml_Visible), 5, 0)), true);
         edtavSecuseridremovedxml_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSecuseridremovedxml_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSecuseridremovedxml_Visible), 5, 0)), true);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV27DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV27DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E16442( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV25SecUserNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         /* Execute user subroutine: 'LOAD LISTS' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         edtSecUserName_Titleformat = 2;
         edtSecUserName_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "姓名", AV26ddo_SecUserNameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecUserName_Internalname, "Title", edtSecUserName_Title, !bGXsfl_25_Refreshing);
         AV29GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29GridCurrentPage), 10, 0)));
         AV30GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30GridPageSize), 10, 0)));
         AV31GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV31GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25SecUserNameTitleFilterData", AV25SecUserNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV11SecUserIdRemoved", AV11SecUserIdRemoved);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10SecUserIdAdded", AV10SecUserIdAdded);
      }

      protected void E11442( )
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
            AV28PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV28PageToGo) ;
         }
      }

      protected void E12442( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E13442( )
      {
         /* Ddo_secusername_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_secusername_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV23OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23OrderedDsc", AV23OrderedDsc);
            Ddo_secusername_Sortedstatus = "ASC";
            ucDdo_secusername.SendProperty(context, "", false, Ddo_secusername_Internalname, "SortedStatus", Ddo_secusername_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_secusername_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV23OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23OrderedDsc", AV23OrderedDsc);
            Ddo_secusername_Sortedstatus = "DSC";
            ucDdo_secusername.SendProperty(context, "", false, Ddo_secusername_Internalname, "SortedStatus", Ddo_secusername_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25SecUserNameTitleFilterData", AV25SecUserNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV11SecUserIdRemoved", AV11SecUserIdRemoved);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10SecUserIdAdded", AV10SecUserIdAdded);
      }

      private void E17442( )
      {
         /* Grid_Load Routine */
         AV9SecRoleIdParm = AV8SecRoleId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9SecRoleIdParm", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9SecRoleIdParm), 4, 0)));
         AV19IsAssociatedOld = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavIsassociatedold_Internalname, AV19IsAssociatedOld);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vISASSOCIATEDOLD"+"_"+sGXsfl_25_idx, GetSecureSignedToken( sGXsfl_25_idx, AV19IsAssociatedOld, context));
         /* Using cursor H00444 */
         pr_default.execute(2, new Object[] {A6SecUserId, AV9SecRoleIdParm});
         while ( (pr_default.getStatus(2) != 101) )
         {
            A4SecRoleId = H00444_A4SecRoleId[0];
            AV19IsAssociatedOld = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavIsassociatedold_Internalname, AV19IsAssociatedOld);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vISASSOCIATEDOLD"+"_"+sGXsfl_25_idx, GetSecureSignedToken( sGXsfl_25_idx, AV19IsAssociatedOld, context));
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(2);
         AV13SecUserIdToFind = A6SecUserId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13SecUserIdToFind", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13SecUserIdToFind), 4, 0)));
         if ( AV19IsAssociatedOld )
         {
            /* Execute user subroutine: 'FIND IN REMOVED' */
            S122 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
         else
         {
            /* Execute user subroutine: 'FIND IN ADDED' */
            S132 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
         if ( AV20i > 0 )
         {
            AV18IsAssociated = (bool)(!AV19IsAssociatedOld);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavIsassociated_Internalname, AV18IsAssociated);
         }
         else
         {
            AV18IsAssociated = AV19IsAssociatedOld;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavIsassociated_Internalname, AV18IsAssociated);
         }
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 25;
         }
         sendrow_252( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_25_Refreshing )
         {
            context.DoAjaxLoad(25, GridRow);
         }
         /*  Sending Event outputs  */
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E14442 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E14442( )
      {
         /* Enter Routine */
         /* Execute user subroutine: 'LOAD LISTS' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV17Success = true;
         AV20i = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20i", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20i), 10, 0)));
         AV35GXV1 = 1;
         while ( AV35GXV1 <= AV11SecUserIdRemoved.Count )
         {
            AV12SecUserId = (short)(AV11SecUserIdRemoved.GetNumeric(AV35GXV1));
            AV21SecUserRole = new GeneXus.Programs.wwpbaseobjects.SdtSecUserRole(context);
            AV21SecUserRole.Load(AV12SecUserId, AV8SecRoleId);
            if ( AV21SecUserRole.Success() )
            {
               AV21SecUserRole.Delete();
            }
            if ( ! AV21SecUserRole.Success() )
            {
               AV17Success = false;
               /* Execute user subroutine: 'SHOW ERROR MESSAGES' */
               S142 ();
               if ( returnInSub )
               {
                  returnInSub = true;
                  if (true) return;
               }
            }
            AV20i = (long)(AV20i+1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20i", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20i), 10, 0)));
            AV35GXV1 = (int)(AV35GXV1+1);
         }
         AV20i = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20i", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20i), 10, 0)));
         AV36GXV2 = 1;
         while ( AV36GXV2 <= AV10SecUserIdAdded.Count )
         {
            AV12SecUserId = (short)(AV10SecUserIdAdded.GetNumeric(AV36GXV2));
            AV21SecUserRole = new GeneXus.Programs.wwpbaseobjects.SdtSecUserRole(context);
            AV21SecUserRole.gxTpr_Secroleid = AV8SecRoleId;
            AV21SecUserRole.gxTpr_Secuserid = AV12SecUserId;
            AV21SecUserRole.Save();
            if ( ! AV21SecUserRole.Success() )
            {
               AV17Success = false;
               /* Execute user subroutine: 'SHOW ERROR MESSAGES' */
               S142 ();
               if ( returnInSub )
               {
                  returnInSub = true;
                  if (true) return;
               }
            }
            AV20i = (long)(AV20i+1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20i", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20i), 10, 0)));
            AV36GXV2 = (int)(AV36GXV2+1);
         }
         if ( AV17Success )
         {
            if ( AV10SecUserIdAdded.Count + AV11SecUserIdRemoved.Count > 0 )
            {
               context.CommitDataStores("wwpbaseobjects.secrolesecuserroleassociationww",pr_default);
               AV14SecUserIdAddedXml = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14SecUserIdAddedXml", AV14SecUserIdAddedXml);
               AV15SecUserIdRemovedXml = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15SecUserIdRemovedXml", AV15SecUserIdRemovedXml);
               GX_msglist.addItem("数据更新成功");
            }
            else
            {
               GX_msglist.addItem("无变化生成");
            }
            context.setWebReturnParms(new Object[] {});
            context.setWebReturnParmsMetadata(new Object[] {});
            context.wjLocDisableFrm = 1;
            context.nUserReturn = 1;
            returnInSub = true;
            if (true) return;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21SecUserRole", AV21SecUserRole);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV11SecUserIdRemoved", AV11SecUserIdRemoved);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10SecUserIdAdded", AV10SecUserIdAdded);
      }

      protected void E18442( )
      {
         /* Isassociated_Click Routine */
         /* Execute user subroutine: 'LOAD LISTS' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV13SecUserIdToFind = A6SecUserId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13SecUserIdToFind", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13SecUserIdToFind), 4, 0)));
         if ( AV18IsAssociated )
         {
            if ( AV19IsAssociatedOld )
            {
               /* Execute user subroutine: 'FIND IN REMOVED' */
               S122 ();
               if ( returnInSub )
               {
                  returnInSub = true;
                  if (true) return;
               }
               AV11SecUserIdRemoved.RemoveItem((int)(AV20i));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20i", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20i), 10, 0)));
            }
            else
            {
               AV10SecUserIdAdded.Add(AV13SecUserIdToFind, 0);
            }
         }
         else
         {
            if ( AV19IsAssociatedOld )
            {
               AV11SecUserIdRemoved.Add(AV13SecUserIdToFind, 0);
            }
            else
            {
               /* Execute user subroutine: 'FIND IN ADDED' */
               S132 ();
               if ( returnInSub )
               {
                  returnInSub = true;
                  if (true) return;
               }
               AV10SecUserIdAdded.RemoveItem((int)(AV20i));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20i", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20i), 10, 0)));
            }
         }
         /* Execute user subroutine: 'SAVE LISTS' */
         S152 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV11SecUserIdRemoved", AV11SecUserIdRemoved);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10SecUserIdAdded", AV10SecUserIdAdded);
      }

      protected void S132( )
      {
         /* 'FIND IN ADDED' Routine */
         AV20i = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20i", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20i), 10, 0)));
         AV37GXV3 = 1;
         while ( AV37GXV3 <= AV10SecUserIdAdded.Count )
         {
            AV12SecUserId = (short)(AV10SecUserIdAdded.GetNumeric(AV37GXV3));
            if ( AV12SecUserId == AV13SecUserIdToFind )
            {
               if (true) break;
            }
            AV20i = (long)(AV20i+1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20i", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20i), 10, 0)));
            AV37GXV3 = (int)(AV37GXV3+1);
         }
         if ( AV20i > AV10SecUserIdAdded.Count )
         {
            AV20i = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20i", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20i), 10, 0)));
         }
      }

      protected void S122( )
      {
         /* 'FIND IN REMOVED' Routine */
         AV20i = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20i", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20i), 10, 0)));
         AV38GXV4 = 1;
         while ( AV38GXV4 <= AV11SecUserIdRemoved.Count )
         {
            AV12SecUserId = (short)(AV11SecUserIdRemoved.GetNumeric(AV38GXV4));
            if ( AV12SecUserId == AV13SecUserIdToFind )
            {
               if (true) break;
            }
            AV20i = (long)(AV20i+1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20i", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20i), 10, 0)));
            AV38GXV4 = (int)(AV38GXV4+1);
         }
         if ( AV20i > AV11SecUserIdRemoved.Count )
         {
            AV20i = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20i", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20i), 10, 0)));
         }
      }

      protected void S112( )
      {
         /* 'LOAD LISTS' Routine */
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV15SecUserIdRemovedXml)) )
         {
            AV11SecUserIdRemoved.FromXml(AV15SecUserIdRemovedXml, null, "Collection", "");
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV14SecUserIdAddedXml)) )
         {
            AV10SecUserIdAdded.FromXml(AV14SecUserIdAddedXml, null, "Collection", "");
         }
      }

      protected void S152( )
      {
         /* 'SAVE LISTS' Routine */
         if ( AV11SecUserIdRemoved.Count > 0 )
         {
            AV15SecUserIdRemovedXml = AV11SecUserIdRemoved.ToXml(false, true, "Collection", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15SecUserIdRemovedXml", AV15SecUserIdRemovedXml);
         }
         else
         {
            AV15SecUserIdRemovedXml = "";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15SecUserIdRemovedXml", AV15SecUserIdRemovedXml);
         }
         if ( AV10SecUserIdAdded.Count > 0 )
         {
            AV14SecUserIdAddedXml = AV10SecUserIdAdded.ToXml(false, true, "Collection", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14SecUserIdAddedXml", AV14SecUserIdAddedXml);
         }
         else
         {
            AV14SecUserIdAddedXml = "";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14SecUserIdAddedXml", AV14SecUserIdAddedXml);
         }
      }

      protected void S142( )
      {
         /* 'SHOW ERROR MESSAGES' Routine */
         AV40GXV6 = 1;
         AV39GXV5 = AV21SecUserRole.GetMessages();
         while ( AV40GXV6 <= AV39GXV5.Count )
         {
            AV16Message = ((SdtMessages_Message)AV39GXV5.Item(AV40GXV6));
            if ( AV16Message.gxTpr_Type == 1 )
            {
               GX_msglist.addItem(AV16Message.gxTpr_Description);
            }
            AV40GXV6 = (int)(AV40GXV6+1);
         }
      }

      protected void wb_table1_14_442( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblUnnamedtable1_Internalname, tblUnnamedtable1_Internalname, "", "", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavSecusername_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSecusername_Internalname, "姓名", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_25_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSecusername_Internalname, AV24SecUserName, StringUtil.RTrim( context.localUtil.Format( AV24SecUserName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,19);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSecusername_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavSecusername_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecRoleSecUserRoleAssociationWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_14_442e( true) ;
         }
         else
         {
            wb_table1_14_442e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV8SecRoleId = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8SecRoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8SecRoleId), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vSECROLEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8SecRoleId), "ZZZ9"), context));
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
         PA442( ) ;
         WS442( ) ;
         WE442( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020227121658", true);
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
         context.AddJavascriptSource("wwpbaseobjects/secrolesecuserroleassociationww.js", "?2020227121659", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_252( )
      {
         chkavIsassociated_Internalname = "vISASSOCIATED_"+sGXsfl_25_idx;
         chkavIsassociatedold_Internalname = "vISASSOCIATEDOLD_"+sGXsfl_25_idx;
         edtSecUserId_Internalname = "SECUSERID_"+sGXsfl_25_idx;
         edtSecUserName_Internalname = "SECUSERNAME_"+sGXsfl_25_idx;
         edtSecUserPassword_Internalname = "SECUSERPASSWORD_"+sGXsfl_25_idx;
      }

      protected void SubsflControlProps_fel_252( )
      {
         chkavIsassociated_Internalname = "vISASSOCIATED_"+sGXsfl_25_fel_idx;
         chkavIsassociatedold_Internalname = "vISASSOCIATEDOLD_"+sGXsfl_25_fel_idx;
         edtSecUserId_Internalname = "SECUSERID_"+sGXsfl_25_fel_idx;
         edtSecUserName_Internalname = "SECUSERNAME_"+sGXsfl_25_fel_idx;
         edtSecUserPassword_Internalname = "SECUSERPASSWORD_"+sGXsfl_25_fel_idx;
      }

      protected void sendrow_252( )
      {
         SubsflControlProps_252( ) ;
         WB440( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_25_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_25_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_25_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Check box */
            TempTags = " " + ((chkavIsassociated.Enabled!=0)&&(chkavIsassociated.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 26,'',false,'"+sGXsfl_25_idx+"',25)\"" : " ");
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GridRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavIsassociated_Internalname,StringUtil.BoolToStr( AV18IsAssociated),(String)"",(String)"",(short)-1,(short)1,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)TempTags});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Check box */
            TempTags = " " + ((chkavIsassociatedold.Enabled!=0)&&(chkavIsassociatedold.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 27,'',false,'"+sGXsfl_25_idx+"',25)\"" : " ");
            ClassString = "Attribute";
            StyleString = "";
            GridRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavIsassociatedold_Internalname,StringUtil.BoolToStr( AV19IsAssociatedOld),(String)"",(String)"",(short)0,chkavIsassociatedold.Enabled,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",TempTags+" onclick=\"gx.fn.checkboxClick(27, this, 'true', 'false');gx.evt.onchange(this, event);\" "});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecUserId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A6SecUserId), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A6SecUserId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSecUserId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)25,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecUserName_Internalname,(String)A14SecUserName,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSecUserName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)25,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecUserPassword_Internalname,(String)A15SecUserPassword,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSecUserPassword_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)-1,(short)0,(short)25,(short)1,(short)0,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes442( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_25_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_25_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_25_idx+1));
            sGXsfl_25_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_25_idx), 4, 0)), 4, "0");
            SubsflControlProps_252( ) ;
         }
         /* End function sendrow_252 */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "vISASSOCIATED_" + sGXsfl_25_idx;
         chkavIsassociated.Name = GXCCtl;
         chkavIsassociated.WebTags = "";
         chkavIsassociated.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavIsassociated_Internalname, "TitleCaption", chkavIsassociated.Caption, !bGXsfl_25_Refreshing);
         chkavIsassociated.CheckedValue = "false";
         GXCCtl = "vISASSOCIATEDOLD_" + sGXsfl_25_idx;
         chkavIsassociatedold.Name = GXCCtl;
         chkavIsassociatedold.WebTags = "";
         chkavIsassociatedold.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavIsassociatedold_Internalname, "TitleCaption", chkavIsassociatedold.Caption, !bGXsfl_25_Refreshing);
         chkavIsassociatedold.CheckedValue = "false";
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtavSecusername_Internalname = "vSECUSERNAME";
         tblUnnamedtable1_Internalname = "UNNAMEDTABLE1";
         divLayout_unnamedtable1_Internalname = "LAYOUT_UNNAMEDTABLE1";
         Dvpanel_unnamedtable1_Internalname = "DVPANEL_UNNAMEDTABLE1";
         divHtml_dvpanel_unnamedtable1_Internalname = "HTML_DVPANEL_UNNAMEDTABLE1";
         chkavIsassociated_Internalname = "vISASSOCIATED";
         chkavIsassociatedold_Internalname = "vISASSOCIATEDOLD";
         edtSecUserId_Internalname = "SECUSERID";
         edtSecUserName_Internalname = "SECUSERNAME";
         edtSecUserPassword_Internalname = "SECUSERPASSWORD";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         bttBtnconfirm_Internalname = "BTNCONFIRM";
         bttBtncancel_Internalname = "BTNCANCEL";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_secusername_Internalname = "DDO_SECUSERNAME";
         edtavDdo_secusernametitlecontrolidtoreplace_Internalname = "vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE";
         edtavSecuseridaddedxml_Internalname = "vSECUSERIDADDEDXML";
         edtavSecuseridremovedxml_Internalname = "vSECUSERIDREMOVEDXML";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
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
         chkavIsassociatedold.Caption = "";
         chkavIsassociated.Caption = "";
         edtSecUserPassword_Jsonclick = "";
         edtSecUserName_Jsonclick = "";
         edtSecUserId_Jsonclick = "";
         chkavIsassociatedold.Visible = 0;
         chkavIsassociated.Visible = -1;
         chkavIsassociated.Enabled = 1;
         edtavSecusername_Jsonclick = "";
         edtavSecusername_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavSecuseridremovedxml_Visible = 1;
         edtavSecuseridaddedxml_Visible = 1;
         edtavDdo_secusernametitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtSecUserName_Titleformat = 0;
         edtSecUserName_Title = "姓名";
         chkavIsassociatedold.Enabled = 1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
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
         Dvpanel_unnamedtable1_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable1_Iconposition = "left";
         Dvpanel_unnamedtable1_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable1_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_unnamedtable1_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable1_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable1_Collapsible = Convert.ToBoolean( -1);
         Dvpanel_unnamedtable1_Title = "";
         Dvpanel_unnamedtable1_Cls = "PanelNoHeader";
         Dvpanel_unnamedtable1_Width = "100%";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "角色相关";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV24SecUserName',fld:'vSECUSERNAME',pic:''},{av:'AV23OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9'},{av:'AV20i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV11SecUserIdRemoved',fld:'vSECUSERIDREMOVED',pic:''},{av:'AV13SecUserIdToFind',fld:'vSECUSERIDTOFIND',pic:'ZZZ9'},{av:'AV10SecUserIdAdded',fld:'vSECUSERIDADDED',pic:''},{av:'AV9SecRoleIdParm',fld:'vSECROLEIDPARM',pic:'ZZZ9'},{av:'AV26ddo_SecUserNameTitleControlIdToReplace',fld:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV15SecUserIdRemovedXml',fld:'vSECUSERIDREMOVEDXML',pic:''},{av:'AV14SecUserIdAddedXml',fld:'vSECUSERIDADDEDXML',pic:''},{av:'AV8SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV25SecUserNameTitleFilterData',fld:'vSECUSERNAMETITLEFILTERDATA',pic:''},{av:'edtSecUserName_Titleformat',ctrl:'SECUSERNAME',prop:'Titleformat'},{av:'edtSecUserName_Title',ctrl:'SECUSERNAME',prop:'Title'},{av:'AV29GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV30GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV31GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV11SecUserIdRemoved',fld:'vSECUSERIDREMOVED',pic:''},{av:'AV10SecUserIdAdded',fld:'vSECUSERIDADDED',pic:''}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E11442',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV24SecUserName',fld:'vSECUSERNAME',pic:''},{av:'AV23OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV26ddo_SecUserNameTitleControlIdToReplace',fld:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV15SecUserIdRemovedXml',fld:'vSECUSERIDREMOVEDXML',pic:''},{av:'AV14SecUserIdAddedXml',fld:'vSECUSERIDADDEDXML',pic:''},{av:'AV8SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true},{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9'},{av:'AV20i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV11SecUserIdRemoved',fld:'vSECUSERIDREMOVED',pic:''},{av:'AV13SecUserIdToFind',fld:'vSECUSERIDTOFIND',pic:'ZZZ9'},{av:'AV10SecUserIdAdded',fld:'vSECUSERIDADDED',pic:''},{av:'AV9SecRoleIdParm',fld:'vSECROLEIDPARM',pic:'ZZZ9'},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E12442',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV24SecUserName',fld:'vSECUSERNAME',pic:''},{av:'AV23OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV26ddo_SecUserNameTitleControlIdToReplace',fld:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV15SecUserIdRemovedXml',fld:'vSECUSERIDREMOVEDXML',pic:''},{av:'AV14SecUserIdAddedXml',fld:'vSECUSERIDADDEDXML',pic:''},{av:'AV8SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true},{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9'},{av:'AV20i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV11SecUserIdRemoved',fld:'vSECUSERIDREMOVED',pic:''},{av:'AV13SecUserIdToFind',fld:'vSECUSERIDTOFIND',pic:'ZZZ9'},{av:'AV10SecUserIdAdded',fld:'vSECUSERIDADDED',pic:''},{av:'AV9SecRoleIdParm',fld:'vSECROLEIDPARM',pic:'ZZZ9'},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_SECUSERNAME.ONOPTIONCLICKED","{handler:'E13442',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV24SecUserName',fld:'vSECUSERNAME',pic:''},{av:'AV23OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV26ddo_SecUserNameTitleControlIdToReplace',fld:'vDDO_SECUSERNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV15SecUserIdRemovedXml',fld:'vSECUSERIDREMOVEDXML',pic:''},{av:'AV14SecUserIdAddedXml',fld:'vSECUSERIDADDEDXML',pic:''},{av:'AV8SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true},{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9'},{av:'AV20i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV11SecUserIdRemoved',fld:'vSECUSERIDREMOVED',pic:''},{av:'AV13SecUserIdToFind',fld:'vSECUSERIDTOFIND',pic:'ZZZ9'},{av:'AV10SecUserIdAdded',fld:'vSECUSERIDADDED',pic:''},{av:'AV9SecRoleIdParm',fld:'vSECROLEIDPARM',pic:'ZZZ9'},{av:'Ddo_secusername_Activeeventkey',ctrl:'DDO_SECUSERNAME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_SECUSERNAME.ONOPTIONCLICKED",",oparms:[{av:'AV23OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_secusername_Sortedstatus',ctrl:'DDO_SECUSERNAME',prop:'SortedStatus'},{av:'AV25SecUserNameTitleFilterData',fld:'vSECUSERNAMETITLEFILTERDATA',pic:''},{av:'edtSecUserName_Titleformat',ctrl:'SECUSERNAME',prop:'Titleformat'},{av:'edtSecUserName_Title',ctrl:'SECUSERNAME',prop:'Title'},{av:'AV29GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV30GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV31GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV11SecUserIdRemoved',fld:'vSECUSERIDREMOVED',pic:''},{av:'AV10SecUserIdAdded',fld:'vSECUSERIDADDED',pic:''}]}");
         setEventMetadata("GRID.LOAD","{handler:'E17442',iparms:[{av:'AV8SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true},{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9'},{av:'A6SecUserId',fld:'SECUSERID',pic:'ZZZ9',hsh:true},{av:'AV20i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV11SecUserIdRemoved',fld:'vSECUSERIDREMOVED',pic:''},{av:'AV13SecUserIdToFind',fld:'vSECUSERIDTOFIND',pic:'ZZZ9'},{av:'AV10SecUserIdAdded',fld:'vSECUSERIDADDED',pic:''},{av:'AV9SecRoleIdParm',fld:'vSECROLEIDPARM',pic:'ZZZ9'}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV9SecRoleIdParm',fld:'vSECROLEIDPARM',pic:'ZZZ9'},{av:'AV19IsAssociatedOld',fld:'vISASSOCIATEDOLD',pic:'',hsh:true},{av:'AV13SecUserIdToFind',fld:'vSECUSERIDTOFIND',pic:'ZZZ9'},{av:'AV18IsAssociated',fld:'vISASSOCIATED',pic:''},{av:'AV20i',fld:'vI',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("ENTER","{handler:'E14442',iparms:[{av:'AV11SecUserIdRemoved',fld:'vSECUSERIDREMOVED',pic:''},{av:'AV8SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true},{av:'AV10SecUserIdAdded',fld:'vSECUSERIDADDED',pic:''},{av:'AV15SecUserIdRemovedXml',fld:'vSECUSERIDREMOVEDXML',pic:''},{av:'AV14SecUserIdAddedXml',fld:'vSECUSERIDADDEDXML',pic:''},{av:'AV21SecUserRole',fld:'vSECUSERROLE',pic:''}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV20i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV21SecUserRole',fld:'vSECUSERROLE',pic:''},{av:'AV14SecUserIdAddedXml',fld:'vSECUSERIDADDEDXML',pic:''},{av:'AV15SecUserIdRemovedXml',fld:'vSECUSERIDREMOVEDXML',pic:''},{av:'AV11SecUserIdRemoved',fld:'vSECUSERIDREMOVED',pic:''},{av:'AV10SecUserIdAdded',fld:'vSECUSERIDADDED',pic:''}]}");
         setEventMetadata("VISASSOCIATED.CLICK","{handler:'E18442',iparms:[{av:'A6SecUserId',fld:'SECUSERID',pic:'ZZZ9',hsh:true},{av:'AV18IsAssociated',fld:'vISASSOCIATED',pic:''},{av:'AV19IsAssociatedOld',fld:'vISASSOCIATEDOLD',pic:'',hsh:true},{av:'AV20i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV11SecUserIdRemoved',fld:'vSECUSERIDREMOVED',pic:''},{av:'AV10SecUserIdAdded',fld:'vSECUSERIDADDED',pic:''},{av:'AV15SecUserIdRemovedXml',fld:'vSECUSERIDREMOVEDXML',pic:''},{av:'AV14SecUserIdAddedXml',fld:'vSECUSERIDADDEDXML',pic:''},{av:'AV13SecUserIdToFind',fld:'vSECUSERIDTOFIND',pic:'ZZZ9'}]");
         setEventMetadata("VISASSOCIATED.CLICK",",oparms:[{av:'AV13SecUserIdToFind',fld:'vSECUSERIDTOFIND',pic:'ZZZ9'},{av:'AV11SecUserIdRemoved',fld:'vSECUSERIDREMOVED',pic:''},{av:'AV10SecUserIdAdded',fld:'vSECUSERIDADDED',pic:''},{av:'AV20i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV15SecUserIdRemovedXml',fld:'vSECUSERIDREMOVEDXML',pic:''},{av:'AV14SecUserIdAddedXml',fld:'vSECUSERIDADDEDXML',pic:''}]}");
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
         AV24SecUserName = "";
         AV26ddo_SecUserNameTitleControlIdToReplace = "";
         AV15SecUserIdRemovedXml = "";
         AV14SecUserIdAddedXml = "";
         AV11SecUserIdRemoved = new GxSimpleCollection<short>();
         AV10SecUserIdAdded = new GxSimpleCollection<short>();
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV27DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV25SecUserNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21SecUserRole = new GeneXus.Programs.wwpbaseobjects.SdtSecUserRole(context);
         Ddo_secusername_Sortedstatus = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ucDvpanel_unnamedtable1 = new GXUserControl();
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         A14SecUserName = "";
         A15SecUserPassword = "";
         ucGridpaginationbar = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtnconfirm_Jsonclick = "";
         bttBtncancel_Jsonclick = "";
         ucDdo_secusername = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         lV24SecUserName = "";
         H00442_A6SecUserId = new short[1] ;
         H00442_A15SecUserPassword = new String[] {""} ;
         H00442_A14SecUserName = new String[] {""} ;
         H00443_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         H00444_A6SecUserId = new short[1] ;
         H00444_A4SecRoleId = new short[1] ;
         GridRow = new GXWebRow();
         AV39GXV5 = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         AV16Message = new SdtMessages_Message(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         GXCCtl = "";
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secrolesecuserroleassociationww__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secrolesecuserroleassociationww__default(),
            new Object[][] {
                new Object[] {
               H00442_A6SecUserId, H00442_A15SecUserPassword, H00442_A14SecUserName
               }
               , new Object[] {
               H00443_AGRID_nRecordCount
               }
               , new Object[] {
               H00444_A6SecUserId, H00444_A4SecRoleId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
         chkavIsassociatedold.Enabled = 0;
      }

      private short AV8SecRoleId ;
      private short wcpOAV8SecRoleId ;
      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_25 ;
      private short nGXsfl_25_idx=1 ;
      private short GRID_nEOF ;
      private short A4SecRoleId ;
      private short AV13SecUserIdToFind ;
      private short AV9SecRoleIdParm ;
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
      private short AV12SecUserId ;
      private short nGXWrapped ;
      private short subGrid_Backstyle ;
      private int subGrid_Rows ;
      private int Gridpaginationbar_Rowsperpageselectedvalue ;
      private int Gridpaginationbar_Pagestoshow ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_secusernametitlecontrolidtoreplace_Visible ;
      private int edtavSecuseridaddedxml_Visible ;
      private int edtavSecuseridremovedxml_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV28PageToGo ;
      private int AV35GXV1 ;
      private int AV36GXV2 ;
      private int AV37GXV3 ;
      private int AV38GXV4 ;
      private int AV40GXV6 ;
      private int edtavSecusername_Enabled ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV20i ;
      private long AV29GridCurrentPage ;
      private long AV31GridRecordCount ;
      private long AV30GridPageSize ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_secusername_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_25_idx="0001" ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String Dvpanel_unnamedtable1_Width ;
      private String Dvpanel_unnamedtable1_Cls ;
      private String Dvpanel_unnamedtable1_Title ;
      private String Dvpanel_unnamedtable1_Iconposition ;
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
      private String divHtml_dvpanel_unnamedtable1_Internalname ;
      private String Dvpanel_unnamedtable1_Internalname ;
      private String divLayout_unnamedtable1_Internalname ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtSecUserName_Title ;
      private String subGrid_Header ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtnconfirm_Internalname ;
      private String bttBtnconfirm_Jsonclick ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_secusername_Internalname ;
      private String edtavDdo_secusernametitlecontrolidtoreplace_Internalname ;
      private String edtavSecuseridaddedxml_Internalname ;
      private String edtavSecuseridremovedxml_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String chkavIsassociated_Internalname ;
      private String chkavIsassociatedold_Internalname ;
      private String edtSecUserId_Internalname ;
      private String edtSecUserName_Internalname ;
      private String edtSecUserPassword_Internalname ;
      private String edtavSecusername_Internalname ;
      private String scmdbuf ;
      private String tblUnnamedtable1_Internalname ;
      private String edtavSecusername_Jsonclick ;
      private String sGXsfl_25_fel_idx="0001" ;
      private String ROClassString ;
      private String edtSecUserId_Jsonclick ;
      private String edtSecUserName_Jsonclick ;
      private String edtSecUserPassword_Jsonclick ;
      private String GXCCtl ;
      private bool entryPointCalled ;
      private bool AV23OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Dvpanel_unnamedtable1_Collapsible ;
      private bool Dvpanel_unnamedtable1_Collapsed ;
      private bool Dvpanel_unnamedtable1_Autowidth ;
      private bool Dvpanel_unnamedtable1_Autoheight ;
      private bool Dvpanel_unnamedtable1_Showcollapseicon ;
      private bool Dvpanel_unnamedtable1_Autoscroll ;
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
      private bool AV18IsAssociated ;
      private bool AV19IsAssociatedOld ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_25_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV17Success ;
      private String AV15SecUserIdRemovedXml ;
      private String AV14SecUserIdAddedXml ;
      private String AV24SecUserName ;
      private String AV26ddo_SecUserNameTitleControlIdToReplace ;
      private String A14SecUserName ;
      private String A15SecUserPassword ;
      private String lV24SecUserName ;
      private GxSimpleCollection<short> AV11SecUserIdRemoved ;
      private GxSimpleCollection<short> AV10SecUserIdAdded ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_unnamedtable1 ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_secusername ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCheckbox chkavIsassociated ;
      private GXCheckbox chkavIsassociatedold ;
      private IDataStoreProvider pr_default ;
      private short[] H00442_A6SecUserId ;
      private String[] H00442_A15SecUserPassword ;
      private String[] H00442_A14SecUserName ;
      private long[] H00443_AGRID_nRecordCount ;
      private short[] H00444_A6SecUserId ;
      private short[] H00444_A4SecRoleId ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GXBaseCollection<SdtMessages_Message> AV39GXV5 ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV25SecUserNameTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private SdtMessages_Message AV16Message ;
      private GeneXus.Programs.wwpbaseobjects.SdtSecUserRole AV21SecUserRole ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV27DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class secrolesecuserroleassociationww__datastore1 : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          def= new CursorDef[] {
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class secrolesecuserroleassociationww__default : DataStoreHelperBase, IDataStoreHelper
 {
    protected Object[] conditional_H00442( IGxContext context ,
                                           String AV24SecUserName ,
                                           String A14SecUserName ,
                                           bool AV23OrderedDsc )
    {
       String sWhereString = "" ;
       String scmdbuf ;
       short[] GXv_int2 ;
       GXv_int2 = new short [4] ;
       Object[] GXv_Object3 ;
       GXv_Object3 = new Object [2] ;
       String sSelectString ;
       String sFromString ;
       String sOrderString ;
       sSelectString = " [SecUserId], [SecUserPassword], [SecUserName]";
       sFromString = " FROM [SecUser] WITH (NOLOCK)";
       sOrderString = "";
       if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV24SecUserName)) )
       {
          if ( StringUtil.StrCmp("", sWhereString) != 0 )
          {
             sWhereString = sWhereString + " and ([SecUserName] like '%' + @lV24SecUserName + '%')";
          }
          else
          {
             sWhereString = sWhereString + " ([SecUserName] like '%' + @lV24SecUserName + '%')";
          }
       }
       else
       {
          GXv_int2[0] = 1;
       }
       if ( StringUtil.StrCmp("", sWhereString) != 0 )
       {
          sWhereString = " WHERE" + sWhereString;
       }
       if ( ! AV23OrderedDsc )
       {
          sOrderString = sOrderString + " ORDER BY [SecUserName]";
       }
       else if ( AV23OrderedDsc )
       {
          sOrderString = sOrderString + " ORDER BY [SecUserName] DESC";
       }
       else if ( true )
       {
          sOrderString = sOrderString + " ORDER BY [SecUserId]";
       }
       scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
       GXv_Object3[0] = scmdbuf;
       GXv_Object3[1] = GXv_int2;
       return GXv_Object3 ;
    }

    protected Object[] conditional_H00443( IGxContext context ,
                                           String AV24SecUserName ,
                                           String A14SecUserName ,
                                           bool AV23OrderedDsc )
    {
       String sWhereString = "" ;
       String scmdbuf ;
       short[] GXv_int4 ;
       GXv_int4 = new short [1] ;
       Object[] GXv_Object5 ;
       GXv_Object5 = new Object [2] ;
       scmdbuf = "SELECT COUNT(*) FROM [SecUser] WITH (NOLOCK)";
       if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV24SecUserName)) )
       {
          if ( StringUtil.StrCmp("", sWhereString) != 0 )
          {
             sWhereString = sWhereString + " and ([SecUserName] like '%' + @lV24SecUserName + '%')";
          }
          else
          {
             sWhereString = sWhereString + " ([SecUserName] like '%' + @lV24SecUserName + '%')";
          }
       }
       else
       {
          GXv_int4[0] = 1;
       }
       if ( StringUtil.StrCmp("", sWhereString) != 0 )
       {
          scmdbuf = scmdbuf + " WHERE" + sWhereString;
       }
       if ( ! AV23OrderedDsc )
       {
          scmdbuf = scmdbuf + "";
       }
       else if ( AV23OrderedDsc )
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
                   return conditional_H00442(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (bool)dynConstraints[2] );
             case 1 :
                   return conditional_H00443(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (bool)dynConstraints[2] );
       }
       return base.getDynamicStatement(cursor, context, dynConstraints);
    }

    public ICursor[] getCursors( )
    {
       cursorDefinitions();
       return new Cursor[] {
        new ForEachCursor(def[0])
       ,new ForEachCursor(def[1])
       ,new ForEachCursor(def[2])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmH00444 ;
        prmH00444 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@AV9SecRoleIdParm",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmH00442 ;
        prmH00442 = new Object[] {
        new Object[] {"@lV24SecUserName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
        new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
        new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
        } ;
        Object[] prmH00443 ;
        prmH00443 = new Object[] {
        new Object[] {"@lV24SecUserName",SqlDbType.NVarChar,100,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("H00442", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00442,11,0,true,false )
           ,new CursorDef("H00443", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00443,1,0,true,false )
           ,new CursorDef("H00444", "SELECT [SecUserId], [SecRoleId] FROM [SecUserRole] WITH (NOLOCK) WHERE [SecUserId] = @SecUserId and [SecRoleId] = @AV9SecRoleIdParm ORDER BY [SecUserId], [SecRoleId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00444,1,0,false,true )
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
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 2 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
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
           case 2 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              return;
     }
  }

}

}
