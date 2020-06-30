/*
               File: WWPBaseObjects.SecRoleFunRoleActionAssociationWW
        Description: Association Role
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:58:31.5
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
   public class secrolefunroleactionassociationww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public secrolefunroleactionassociationww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public secrolefunroleactionassociationww( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_SecRoleId ,
                           long aP1_SecParentFunctionalityId )
      {
         this.AV9SecRoleId = aP0_SecRoleId;
         this.AV29SecParentFunctionalityId = aP1_SecParentFunctionalityId;
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
               AV25SecFunctionalityKey = GetNextPar( );
               AV35OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV36OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV29SecParentFunctionalityId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV59ddo_SecFunctionalityKeyTitleControlIdToReplace = GetNextPar( );
               AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace = GetNextPar( );
               AV13SecFunctionalityIdRemovedXml = GetNextPar( );
               AV12SecFunctionalityIdAddedXml = GetNextPar( );
               AV9SecRoleId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               A4SecRoleId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV21i = (long)(NumberUtil.Val( GetNextPar( ), "."));
               ajax_req_read_hidden_sdt(GetNextPar( ), AV11SecFunctionalityIdRemoved);
               AV15SecFunctionalityIdToFind = (long)(NumberUtil.Val( GetNextPar( ), "."));
               ajax_req_read_hidden_sdt(GetNextPar( ), AV10SecFunctionalityIdAdded);
               AV31SecRoleIdParm = (short)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV25SecFunctionalityKey, AV35OrderedBy, AV36OrderedDsc, AV29SecParentFunctionalityId, AV59ddo_SecFunctionalityKeyTitleControlIdToReplace, AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace, AV13SecFunctionalityIdRemovedXml, AV12SecFunctionalityIdAddedXml, AV9SecRoleId, A4SecRoleId, AV21i, AV11SecFunctionalityIdRemoved, AV15SecFunctionalityIdToFind, AV10SecFunctionalityIdAdded, AV31SecRoleIdParm) ;
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
               AV9SecRoleId = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9SecRoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9SecRoleId), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vSECROLEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9SecRoleId), "ZZZ9"), context));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV29SecParentFunctionalityId = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29SecParentFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29SecParentFunctionalityId), 10, 0)));
               }
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
         PA0N2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0N2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022711583122", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("wwpbaseobjects.secrolefunroleactionassociationww.aspx") + "?" + UrlEncode("" +AV9SecRoleId) + "," + UrlEncode("" +AV29SecParentFunctionalityId)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vSECFUNCTIONALITYKEY", AV25SecFunctionalityKey);
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV35OrderedBy), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV36OrderedDsc));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_25", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_25), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV78GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV81GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV80GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV71DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV71DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vSECFUNCTIONALITYKEYTITLEFILTERDATA", AV56SecFunctionalityKeyTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vSECFUNCTIONALITYKEYTITLEFILTERDATA", AV56SecFunctionalityKeyTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA", AV60SecFunctionalityDescriptionTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA", AV60SecFunctionalityDescriptionTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vSECROLEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9SecRoleId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vSECROLEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9SecRoleId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "SECROLEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A4SecRoleId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vI", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21i), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vSECFUNCTIONALITYIDREMOVED", AV11SecFunctionalityIdRemoved);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vSECFUNCTIONALITYIDREMOVED", AV11SecFunctionalityIdRemoved);
         }
         GxWebStd.gx_hidden_field( context, "vSECFUNCTIONALITYIDTOFIND", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15SecFunctionalityIdToFind), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vSECFUNCTIONALITYIDADDED", AV10SecFunctionalityIdAdded);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vSECFUNCTIONALITYIDADDED", AV10SecFunctionalityIdAdded);
         }
         GxWebStd.gx_hidden_field( context, "vSECROLEIDPARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV31SecRoleIdParm), 4, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vSECFUNCTIONALITYROLE", AV16SecFunctionalityRole);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vSECFUNCTIONALITYROLE", AV16SecFunctionalityRole);
         }
         GxWebStd.gx_hidden_field( context, "vSECPARENTFUNCTIONALITYID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV29SecParentFunctionalityId), 10, 0, ".", "")));
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
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Caption", StringUtil.RTrim( Ddo_secfunctionalitykey_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Tooltip", StringUtil.RTrim( Ddo_secfunctionalitykey_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Cls", StringUtil.RTrim( Ddo_secfunctionalitykey_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Dropdownoptionstype", StringUtil.RTrim( Ddo_secfunctionalitykey_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_secfunctionalitykey_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Includesortasc", StringUtil.BoolToStr( Ddo_secfunctionalitykey_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Includesortdsc", StringUtil.BoolToStr( Ddo_secfunctionalitykey_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Sortedstatus", StringUtil.RTrim( Ddo_secfunctionalitykey_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Includefilter", StringUtil.BoolToStr( Ddo_secfunctionalitykey_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Includedatalist", StringUtil.BoolToStr( Ddo_secfunctionalitykey_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Sortasc", StringUtil.RTrim( Ddo_secfunctionalitykey_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Sortdsc", StringUtil.RTrim( Ddo_secfunctionalitykey_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Searchbuttontext", StringUtil.RTrim( Ddo_secfunctionalitykey_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Caption", StringUtil.RTrim( Ddo_secfunctionalitydescription_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Tooltip", StringUtil.RTrim( Ddo_secfunctionalitydescription_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Cls", StringUtil.RTrim( Ddo_secfunctionalitydescription_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Dropdownoptionstype", StringUtil.RTrim( Ddo_secfunctionalitydescription_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_secfunctionalitydescription_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Includesortasc", StringUtil.BoolToStr( Ddo_secfunctionalitydescription_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Includesortdsc", StringUtil.BoolToStr( Ddo_secfunctionalitydescription_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Sortedstatus", StringUtil.RTrim( Ddo_secfunctionalitydescription_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Includefilter", StringUtil.BoolToStr( Ddo_secfunctionalitydescription_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Includedatalist", StringUtil.BoolToStr( Ddo_secfunctionalitydescription_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Sortasc", StringUtil.RTrim( Ddo_secfunctionalitydescription_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Sortdsc", StringUtil.RTrim( Ddo_secfunctionalitydescription_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Searchbuttontext", StringUtil.RTrim( Ddo_secfunctionalitydescription_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Activeeventkey", StringUtil.RTrim( Ddo_secfunctionalitykey_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Activeeventkey", StringUtil.RTrim( Ddo_secfunctionalitydescription_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYKEY_Activeeventkey", StringUtil.RTrim( Ddo_secfunctionalitykey_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_SECFUNCTIONALITYDESCRIPTION_Activeeventkey", StringUtil.RTrim( Ddo_secfunctionalitydescription_Activeeventkey));
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
            WE0N2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0N2( ) ;
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
         return formatLink("wwpbaseobjects.secrolefunroleactionassociationww.aspx") + "?" + UrlEncode("" +AV9SecRoleId) + "," + UrlEncode("" +AV29SecParentFunctionalityId) ;
      }

      public override String GetPgmname( )
      {
         return "WWPBaseObjects.SecRoleFunRoleActionAssociationWW" ;
      }

      public override String GetPgmdesc( )
      {
         return "Association Role" ;
      }

      protected void WB0N0( )
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
            wb_table1_14_0N2( true) ;
         }
         else
         {
            wb_table1_14_0N2( false) ;
         }
         return  ;
      }

      protected void wb_table1_14_0N2e( bool wbgen )
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
               context.SendWebValue( "Parent Functionality") ;
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
               GridColumn.AddObjectProperty("Value", StringUtil.BoolToStr( AV18IsAssociated));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.BoolToStr( AV19IsAssociatedOld));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkavIsassociatedold.Enabled), 5, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV78GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV81GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV80GridPageSize);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnconfirm_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(25), 2, 0)+","+"null"+");", "保存", bttBtnconfirm_Jsonclick, 5, "确认", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\SecRoleFunRoleActionAssociationWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(25), 2, 0)+","+"null"+");", "取消", bttBtncancel_Jsonclick, 1, "取消", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\SecRoleFunRoleActionAssociationWW.htm");
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
            ucDdo_secfunctionalitykey.SetProperty("IncludeDataList", Ddo_secfunctionalitykey_Includedatalist);
            ucDdo_secfunctionalitykey.SetProperty("SortASC", Ddo_secfunctionalitykey_Sortasc);
            ucDdo_secfunctionalitykey.SetProperty("SortDSC", Ddo_secfunctionalitykey_Sortdsc);
            ucDdo_secfunctionalitykey.SetProperty("SearchButtonText", Ddo_secfunctionalitykey_Searchbuttontext);
            ucDdo_secfunctionalitykey.SetProperty("DropDownOptionsTitleSettingsIcons", AV71DDO_TitleSettingsIcons);
            ucDdo_secfunctionalitykey.SetProperty("DropDownOptionsData", AV56SecFunctionalityKeyTitleFilterData);
            ucDdo_secfunctionalitykey.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_secfunctionalitykey_Internalname, "DDO_SECFUNCTIONALITYKEYContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'" + sGXsfl_25_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_secfunctionalitykeytitlecontrolidtoreplace_Internalname, AV59ddo_SecFunctionalityKeyTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", 0, edtavDdo_secfunctionalitykeytitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WWPBaseObjects\\SecRoleFunRoleActionAssociationWW.htm");
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
            ucDdo_secfunctionalitydescription.SetProperty("DropDownOptionsTitleSettingsIcons", AV71DDO_TitleSettingsIcons);
            ucDdo_secfunctionalitydescription.SetProperty("DropDownOptionsData", AV60SecFunctionalityDescriptionTitleFilterData);
            ucDdo_secfunctionalitydescription.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_secfunctionalitydescription_Internalname, "DDO_SECFUNCTIONALITYDESCRIPTIONContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'" + sGXsfl_25_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_secfunctionalitydescriptiontitlecontrolidtoreplace_Internalname, AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", 0, edtavDdo_secfunctionalitydescriptiontitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WWPBaseObjects\\SecRoleFunRoleActionAssociationWW.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'" + sGXsfl_25_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavSecfunctionalityidaddedxml_Internalname, AV12SecFunctionalityIdAddedXml, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", 0, edtavSecfunctionalityidaddedxml_Visible, 1, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "2097152", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WWPBaseObjects\\SecRoleFunRoleActionAssociationWW.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_25_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavSecfunctionalityidremovedxml_Internalname, AV13SecFunctionalityIdRemovedXml, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", 0, edtavSecfunctionalityidremovedxml_Visible, 1, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "2097152", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WWPBaseObjects\\SecRoleFunRoleActionAssociationWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_25_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV35OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV35OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WWPBaseObjects\\SecRoleFunRoleActionAssociationWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'" + sGXsfl_25_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV36OrderedDsc), StringUtil.BoolToStr( AV36OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_WWPBaseObjects\\SecRoleFunRoleActionAssociationWW.htm");
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

      protected void START0N2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "Association Role", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0N0( ) ;
      }

      protected void WS0N2( )
      {
         START0N2( ) ;
         EVT0N2( ) ;
      }

      protected void EVT0N2( )
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
                              E110N2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E120N2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_SECFUNCTIONALITYKEY.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E130N2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_SECFUNCTIONALITYDESCRIPTION.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E140N2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false;
                                 /* Set Refresh If Secfunctionalitykey Changed */
                                 if ( StringUtil.StrCmp(cgiGet( "GXH_vSECFUNCTIONALITYKEY"), AV25SecFunctionalityKey) != 0 )
                                 {
                                    Rfr0gs = true;
                                 }
                                 /* Set Refresh If Orderedby Changed */
                                 if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV35OrderedBy )) )
                                 {
                                    Rfr0gs = true;
                                 }
                                 /* Set Refresh If Ordereddsc Changed */
                                 if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV36OrderedDsc )
                                 {
                                    Rfr0gs = true;
                                 }
                                 if ( ! Rfr0gs )
                                 {
                                    /* Execute user event: Enter */
                                    E150N2 ();
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
                                    E160N2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E170N2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E180N2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VISASSOCIATED.CLICK") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E190N2 ();
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

      protected void WE0N2( )
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

      protected void PA0N2( )
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
                                       String AV25SecFunctionalityKey ,
                                       short AV35OrderedBy ,
                                       bool AV36OrderedDsc ,
                                       long AV29SecParentFunctionalityId ,
                                       String AV59ddo_SecFunctionalityKeyTitleControlIdToReplace ,
                                       String AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace ,
                                       String AV13SecFunctionalityIdRemovedXml ,
                                       String AV12SecFunctionalityIdAddedXml ,
                                       short AV9SecRoleId ,
                                       short A4SecRoleId ,
                                       long AV21i ,
                                       GxSimpleCollection<long> AV11SecFunctionalityIdRemoved ,
                                       long AV15SecFunctionalityIdToFind ,
                                       GxSimpleCollection<long> AV10SecFunctionalityIdAdded ,
                                       short AV31SecRoleIdParm )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF0N2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_SECFUNCTIONALITYID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A1SecFunctionalityId), "ZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "SECFUNCTIONALITYID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SecFunctionalityId), 10, 0, ".", "")));
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
         RF0N2( ) ;
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

      protected void RF0N2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 25;
         /* Execute user event: Refresh */
         E170N2 ();
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
                                                 AV25SecFunctionalityKey ,
                                                 A3SecFunctionalityKey ,
                                                 AV35OrderedBy ,
                                                 AV36OrderedDsc ,
                                                 A2SecParentFunctionalityId ,
                                                 AV29SecParentFunctionalityId } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.LONG
                                                 }
            } ) ;
            lV25SecFunctionalityKey = StringUtil.Concat( StringUtil.RTrim( AV25SecFunctionalityKey), "%", "");
            /* Using cursor H000N2 */
            pr_default.execute(0, new Object[] {AV29SecParentFunctionalityId, lV25SecFunctionalityKey, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_25_idx = 1;
            sGXsfl_25_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_25_idx), 4, 0)), 4, "0");
            SubsflControlProps_252( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A1SecFunctionalityId = H000N2_A1SecFunctionalityId[0];
               A7SecFunctionalityActive = H000N2_A7SecFunctionalityActive[0];
               A11SecParentFunctionalityDescription = H000N2_A11SecParentFunctionalityDescription[0];
               A2SecParentFunctionalityId = H000N2_A2SecParentFunctionalityId[0];
               n2SecParentFunctionalityId = H000N2_n2SecParentFunctionalityId[0];
               A9SecFunctionalityType = H000N2_A9SecFunctionalityType[0];
               A8SecFunctionalityDescription = H000N2_A8SecFunctionalityDescription[0];
               A3SecFunctionalityKey = H000N2_A3SecFunctionalityKey[0];
               A11SecParentFunctionalityDescription = H000N2_A11SecParentFunctionalityDescription[0];
               E180N2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 25;
            WB0N0( ) ;
         }
         bGXsfl_25_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes0N2( )
      {
         GxWebStd.gx_hidden_field( context, "vSECROLEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9SecRoleId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vSECROLEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9SecRoleId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_SECFUNCTIONALITYID"+"_"+sGXsfl_25_idx, GetSecureSignedToken( sGXsfl_25_idx, context.localUtil.Format( (decimal)(A1SecFunctionalityId), "ZZZZZZZZZ9"), context));
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
                                              AV25SecFunctionalityKey ,
                                              A3SecFunctionalityKey ,
                                              AV35OrderedBy ,
                                              AV36OrderedDsc ,
                                              A2SecParentFunctionalityId ,
                                              AV29SecParentFunctionalityId } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.LONG
                                              }
         } ) ;
         lV25SecFunctionalityKey = StringUtil.Concat( StringUtil.RTrim( AV25SecFunctionalityKey), "%", "");
         /* Using cursor H000N3 */
         pr_default.execute(1, new Object[] {AV29SecParentFunctionalityId, lV25SecFunctionalityKey});
         GRID_nRecordCount = H000N3_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV25SecFunctionalityKey, AV35OrderedBy, AV36OrderedDsc, AV29SecParentFunctionalityId, AV59ddo_SecFunctionalityKeyTitleControlIdToReplace, AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace, AV13SecFunctionalityIdRemovedXml, AV12SecFunctionalityIdAddedXml, AV9SecRoleId, A4SecRoleId, AV21i, AV11SecFunctionalityIdRemoved, AV15SecFunctionalityIdToFind, AV10SecFunctionalityIdAdded, AV31SecRoleIdParm) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV25SecFunctionalityKey, AV35OrderedBy, AV36OrderedDsc, AV29SecParentFunctionalityId, AV59ddo_SecFunctionalityKeyTitleControlIdToReplace, AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace, AV13SecFunctionalityIdRemovedXml, AV12SecFunctionalityIdAddedXml, AV9SecRoleId, A4SecRoleId, AV21i, AV11SecFunctionalityIdRemoved, AV15SecFunctionalityIdToFind, AV10SecFunctionalityIdAdded, AV31SecRoleIdParm) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV25SecFunctionalityKey, AV35OrderedBy, AV36OrderedDsc, AV29SecParentFunctionalityId, AV59ddo_SecFunctionalityKeyTitleControlIdToReplace, AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace, AV13SecFunctionalityIdRemovedXml, AV12SecFunctionalityIdAddedXml, AV9SecRoleId, A4SecRoleId, AV21i, AV11SecFunctionalityIdRemoved, AV15SecFunctionalityIdToFind, AV10SecFunctionalityIdAdded, AV31SecRoleIdParm) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV25SecFunctionalityKey, AV35OrderedBy, AV36OrderedDsc, AV29SecParentFunctionalityId, AV59ddo_SecFunctionalityKeyTitleControlIdToReplace, AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace, AV13SecFunctionalityIdRemovedXml, AV12SecFunctionalityIdAddedXml, AV9SecRoleId, A4SecRoleId, AV21i, AV11SecFunctionalityIdRemoved, AV15SecFunctionalityIdToFind, AV10SecFunctionalityIdAdded, AV31SecRoleIdParm) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV25SecFunctionalityKey, AV35OrderedBy, AV36OrderedDsc, AV29SecParentFunctionalityId, AV59ddo_SecFunctionalityKeyTitleControlIdToReplace, AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace, AV13SecFunctionalityIdRemovedXml, AV12SecFunctionalityIdAddedXml, AV9SecRoleId, A4SecRoleId, AV21i, AV11SecFunctionalityIdRemoved, AV15SecFunctionalityIdToFind, AV10SecFunctionalityIdAdded, AV31SecRoleIdParm) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP0N0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         chkavIsassociatedold.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavIsassociatedold_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavIsassociatedold.Enabled), 5, 0)), !bGXsfl_25_Refreshing);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E160N2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV71DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vSECFUNCTIONALITYKEYTITLEFILTERDATA"), AV56SecFunctionalityKeyTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA"), AV60SecFunctionalityDescriptionTitleFilterData);
            /* Read variables values. */
            AV25SecFunctionalityKey = cgiGet( edtavSecfunctionalitykey_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25SecFunctionalityKey", AV25SecFunctionalityKey);
            AV59ddo_SecFunctionalityKeyTitleControlIdToReplace = cgiGet( edtavDdo_secfunctionalitykeytitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59ddo_SecFunctionalityKeyTitleControlIdToReplace", AV59ddo_SecFunctionalityKeyTitleControlIdToReplace);
            AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace = cgiGet( edtavDdo_secfunctionalitydescriptiontitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace", AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace);
            AV12SecFunctionalityIdAddedXml = cgiGet( edtavSecfunctionalityidaddedxml_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SecFunctionalityIdAddedXml", AV12SecFunctionalityIdAddedXml);
            AV13SecFunctionalityIdRemovedXml = cgiGet( edtavSecfunctionalityidremovedxml_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13SecFunctionalityIdRemovedXml", AV13SecFunctionalityIdRemovedXml);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDEREDBY");
               GX_FocusControl = edtavOrderedby_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV35OrderedBy = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV35OrderedBy), 4, 0)));
            }
            else
            {
               AV35OrderedBy = (short)(context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV35OrderedBy), 4, 0)));
            }
            AV36OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36OrderedDsc", AV36OrderedDsc);
            /* Read saved values. */
            nRC_GXsfl_25 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_25"), ".", ","));
            AV78GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV81GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV80GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_secfunctionalitykey_Caption = cgiGet( "DDO_SECFUNCTIONALITYKEY_Caption");
            Ddo_secfunctionalitykey_Tooltip = cgiGet( "DDO_SECFUNCTIONALITYKEY_Tooltip");
            Ddo_secfunctionalitykey_Cls = cgiGet( "DDO_SECFUNCTIONALITYKEY_Cls");
            Ddo_secfunctionalitykey_Dropdownoptionstype = cgiGet( "DDO_SECFUNCTIONALITYKEY_Dropdownoptionstype");
            Ddo_secfunctionalitykey_Titlecontrolidtoreplace = cgiGet( "DDO_SECFUNCTIONALITYKEY_Titlecontrolidtoreplace");
            Ddo_secfunctionalitykey_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_SECFUNCTIONALITYKEY_Includesortasc"));
            Ddo_secfunctionalitykey_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_SECFUNCTIONALITYKEY_Includesortdsc"));
            Ddo_secfunctionalitykey_Sortedstatus = cgiGet( "DDO_SECFUNCTIONALITYKEY_Sortedstatus");
            Ddo_secfunctionalitykey_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_SECFUNCTIONALITYKEY_Includefilter"));
            Ddo_secfunctionalitykey_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_SECFUNCTIONALITYKEY_Includedatalist"));
            Ddo_secfunctionalitykey_Sortasc = cgiGet( "DDO_SECFUNCTIONALITYKEY_Sortasc");
            Ddo_secfunctionalitykey_Sortdsc = cgiGet( "DDO_SECFUNCTIONALITYKEY_Sortdsc");
            Ddo_secfunctionalitykey_Searchbuttontext = cgiGet( "DDO_SECFUNCTIONALITYKEY_Searchbuttontext");
            Ddo_secfunctionalitydescription_Caption = cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Caption");
            Ddo_secfunctionalitydescription_Tooltip = cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Tooltip");
            Ddo_secfunctionalitydescription_Cls = cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Cls");
            Ddo_secfunctionalitydescription_Dropdownoptionstype = cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Dropdownoptionstype");
            Ddo_secfunctionalitydescription_Titlecontrolidtoreplace = cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Titlecontrolidtoreplace");
            Ddo_secfunctionalitydescription_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Includesortasc"));
            Ddo_secfunctionalitydescription_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Includesortdsc"));
            Ddo_secfunctionalitydescription_Sortedstatus = cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Sortedstatus");
            Ddo_secfunctionalitydescription_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Includefilter"));
            Ddo_secfunctionalitydescription_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Includedatalist"));
            Ddo_secfunctionalitydescription_Sortasc = cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Sortasc");
            Ddo_secfunctionalitydescription_Sortdsc = cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Sortdsc");
            Ddo_secfunctionalitydescription_Searchbuttontext = cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_secfunctionalitykey_Activeeventkey = cgiGet( "DDO_SECFUNCTIONALITYKEY_Activeeventkey");
            Ddo_secfunctionalitydescription_Activeeventkey = cgiGet( "DDO_SECFUNCTIONALITYDESCRIPTION_Activeeventkey");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( StringUtil.StrCmp(cgiGet( "GXH_vSECFUNCTIONALITYKEY"), AV25SecFunctionalityKey) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV35OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV36OrderedDsc )
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
         E160N2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E160N2( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_secfunctionalitykey_Titlecontrolidtoreplace = subGrid_Internalname+"_SecFunctionalityKey";
         ucDdo_secfunctionalitykey.SendProperty(context, "", false, Ddo_secfunctionalitykey_Internalname, "TitleControlIdToReplace", Ddo_secfunctionalitykey_Titlecontrolidtoreplace);
         AV59ddo_SecFunctionalityKeyTitleControlIdToReplace = Ddo_secfunctionalitykey_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59ddo_SecFunctionalityKeyTitleControlIdToReplace", AV59ddo_SecFunctionalityKeyTitleControlIdToReplace);
         edtavDdo_secfunctionalitykeytitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_secfunctionalitykeytitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_secfunctionalitykeytitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_secfunctionalitydescription_Titlecontrolidtoreplace = subGrid_Internalname+"_SecFunctionalityDescription";
         ucDdo_secfunctionalitydescription.SendProperty(context, "", false, Ddo_secfunctionalitydescription_Internalname, "TitleControlIdToReplace", Ddo_secfunctionalitydescription_Titlecontrolidtoreplace);
         AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace = Ddo_secfunctionalitydescription_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace", AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace);
         edtavDdo_secfunctionalitydescriptiontitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_secfunctionalitydescriptiontitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_secfunctionalitydescriptiontitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "角色相关";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         edtavOrderedby_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrderedby_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrderedby_Visible), 5, 0)), true);
         if ( AV35OrderedBy < 1 )
         {
            AV35OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV35OrderedBy), 4, 0)));
         }
         edtavOrdereddsc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrdereddsc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrdereddsc_Visible), 5, 0)), true);
         edtavSecfunctionalityidaddedxml_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSecfunctionalityidaddedxml_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSecfunctionalityidaddedxml_Visible), 5, 0)), true);
         edtavSecfunctionalityidremovedxml_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSecfunctionalityidremovedxml_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSecfunctionalityidremovedxml_Visible), 5, 0)), true);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV71DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV71DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
         /* Using cursor H000N4 */
         pr_default.execute(2, new Object[] {AV9SecRoleId});
         while ( (pr_default.getStatus(2) != 101) )
         {
            A4SecRoleId = H000N4_A4SecRoleId[0];
            A12SecRoleDescription = H000N4_A12SecRoleDescription[0];
            Form.Caption = StringUtil.Format( "Associate Functionalities to Role :: %1", A12SecRoleDescription, "", "", "", "", "", "", "", "");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(2);
      }

      protected void E170N2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV56SecFunctionalityKeyTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV60SecFunctionalityDescriptionTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV74WWPContext) ;
         /* Execute user subroutine: 'LOAD LISTS' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         edtSecFunctionalityKey_Titleformat = 2;
         edtSecFunctionalityKey_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "权限名称", AV59ddo_SecFunctionalityKeyTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecFunctionalityKey_Internalname, "Title", edtSecFunctionalityKey_Title, !bGXsfl_25_Refreshing);
         edtSecFunctionalityDescription_Titleformat = 2;
         edtSecFunctionalityDescription_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "权限描述", AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecFunctionalityDescription_Internalname, "Title", edtSecFunctionalityDescription_Title, !bGXsfl_25_Refreshing);
         AV78GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV78GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV78GridCurrentPage), 10, 0)));
         AV80GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV80GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV80GridPageSize), 10, 0)));
         AV81GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV81GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV81GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56SecFunctionalityKeyTitleFilterData", AV56SecFunctionalityKeyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV60SecFunctionalityDescriptionTitleFilterData", AV60SecFunctionalityDescriptionTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV11SecFunctionalityIdRemoved", AV11SecFunctionalityIdRemoved);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10SecFunctionalityIdAdded", AV10SecFunctionalityIdAdded);
      }

      protected void E110N2( )
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
            AV77PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV77PageToGo) ;
         }
      }

      protected void E120N2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E130N2( )
      {
         /* Ddo_secfunctionalitykey_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_secfunctionalitykey_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV35OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV35OrderedBy), 4, 0)));
            AV36OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36OrderedDsc", AV36OrderedDsc);
            Ddo_secfunctionalitykey_Sortedstatus = "ASC";
            ucDdo_secfunctionalitykey.SendProperty(context, "", false, Ddo_secfunctionalitykey_Internalname, "SortedStatus", Ddo_secfunctionalitykey_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_secfunctionalitykey_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV35OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV35OrderedBy), 4, 0)));
            AV36OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36OrderedDsc", AV36OrderedDsc);
            Ddo_secfunctionalitykey_Sortedstatus = "DSC";
            ucDdo_secfunctionalitykey.SendProperty(context, "", false, Ddo_secfunctionalitykey_Internalname, "SortedStatus", Ddo_secfunctionalitykey_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56SecFunctionalityKeyTitleFilterData", AV56SecFunctionalityKeyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV60SecFunctionalityDescriptionTitleFilterData", AV60SecFunctionalityDescriptionTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV11SecFunctionalityIdRemoved", AV11SecFunctionalityIdRemoved);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10SecFunctionalityIdAdded", AV10SecFunctionalityIdAdded);
      }

      protected void E140N2( )
      {
         /* Ddo_secfunctionalitydescription_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_secfunctionalitydescription_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV35OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV35OrderedBy), 4, 0)));
            AV36OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36OrderedDsc", AV36OrderedDsc);
            Ddo_secfunctionalitydescription_Sortedstatus = "ASC";
            ucDdo_secfunctionalitydescription.SendProperty(context, "", false, Ddo_secfunctionalitydescription_Internalname, "SortedStatus", Ddo_secfunctionalitydescription_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_secfunctionalitydescription_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV35OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV35OrderedBy), 4, 0)));
            AV36OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36OrderedDsc", AV36OrderedDsc);
            Ddo_secfunctionalitydescription_Sortedstatus = "DSC";
            ucDdo_secfunctionalitydescription.SendProperty(context, "", false, Ddo_secfunctionalitydescription_Internalname, "SortedStatus", Ddo_secfunctionalitydescription_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56SecFunctionalityKeyTitleFilterData", AV56SecFunctionalityKeyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV60SecFunctionalityDescriptionTitleFilterData", AV60SecFunctionalityDescriptionTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV11SecFunctionalityIdRemoved", AV11SecFunctionalityIdRemoved);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10SecFunctionalityIdAdded", AV10SecFunctionalityIdAdded);
      }

      private void E180N2( )
      {
         /* Grid_Load Routine */
         AV31SecRoleIdParm = AV9SecRoleId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31SecRoleIdParm", StringUtil.LTrim( StringUtil.Str( (decimal)(AV31SecRoleIdParm), 4, 0)));
         AV19IsAssociatedOld = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavIsassociatedold_Internalname, AV19IsAssociatedOld);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vISASSOCIATEDOLD"+"_"+sGXsfl_25_idx, GetSecureSignedToken( sGXsfl_25_idx, AV19IsAssociatedOld, context));
         /* Using cursor H000N5 */
         pr_default.execute(3, new Object[] {A1SecFunctionalityId, AV31SecRoleIdParm});
         while ( (pr_default.getStatus(3) != 101) )
         {
            A4SecRoleId = H000N5_A4SecRoleId[0];
            AV19IsAssociatedOld = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, chkavIsassociatedold_Internalname, AV19IsAssociatedOld);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vISASSOCIATEDOLD"+"_"+sGXsfl_25_idx, GetSecureSignedToken( sGXsfl_25_idx, AV19IsAssociatedOld, context));
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(3);
         AV15SecFunctionalityIdToFind = A1SecFunctionalityId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15SecFunctionalityIdToFind", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15SecFunctionalityIdToFind), 10, 0)));
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
         if ( AV21i > 0 )
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
         E150N2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E150N2( )
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
         AV21i = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21i", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21i), 10, 0)));
         AV86GXV1 = 1;
         while ( AV86GXV1 <= AV11SecFunctionalityIdRemoved.Count )
         {
            AV14SecFunctionalityId = (long)(AV11SecFunctionalityIdRemoved.GetNumeric(AV86GXV1));
            AV16SecFunctionalityRole = new GeneXus.Programs.wwpbaseobjects.SdtSecFunctionalityRole(context);
            AV16SecFunctionalityRole.Load(AV14SecFunctionalityId, AV9SecRoleId);
            if ( AV16SecFunctionalityRole.Success() )
            {
               AV16SecFunctionalityRole.Delete();
            }
            if ( ! AV16SecFunctionalityRole.Success() )
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
            AV21i = (long)(AV21i+1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21i", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21i), 10, 0)));
            AV86GXV1 = (int)(AV86GXV1+1);
         }
         AV21i = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21i", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21i), 10, 0)));
         AV87GXV2 = 1;
         while ( AV87GXV2 <= AV10SecFunctionalityIdAdded.Count )
         {
            AV14SecFunctionalityId = (long)(AV10SecFunctionalityIdAdded.GetNumeric(AV87GXV2));
            AV16SecFunctionalityRole = new GeneXus.Programs.wwpbaseobjects.SdtSecFunctionalityRole(context);
            AV16SecFunctionalityRole.gxTpr_Secroleid = AV9SecRoleId;
            AV16SecFunctionalityRole.gxTpr_Secfunctionalityid = AV14SecFunctionalityId;
            AV16SecFunctionalityRole.Save();
            if ( ! AV16SecFunctionalityRole.Success() )
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
            AV21i = (long)(AV21i+1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21i", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21i), 10, 0)));
            AV87GXV2 = (int)(AV87GXV2+1);
         }
         if ( AV17Success )
         {
            if ( AV10SecFunctionalityIdAdded.Count + AV11SecFunctionalityIdRemoved.Count > 0 )
            {
               context.CommitDataStores("wwpbaseobjects.secrolefunroleactionassociationww",pr_default);
               AV12SecFunctionalityIdAddedXml = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SecFunctionalityIdAddedXml", AV12SecFunctionalityIdAddedXml);
               AV13SecFunctionalityIdRemovedXml = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13SecFunctionalityIdRemovedXml", AV13SecFunctionalityIdRemovedXml);
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
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16SecFunctionalityRole", AV16SecFunctionalityRole);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV11SecFunctionalityIdRemoved", AV11SecFunctionalityIdRemoved);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10SecFunctionalityIdAdded", AV10SecFunctionalityIdAdded);
      }

      protected void E190N2( )
      {
         /* Isassociated_Click Routine */
         /* Execute user subroutine: 'LOAD LISTS' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV15SecFunctionalityIdToFind = A1SecFunctionalityId;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15SecFunctionalityIdToFind", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15SecFunctionalityIdToFind), 10, 0)));
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
               AV11SecFunctionalityIdRemoved.RemoveItem((int)(AV21i));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21i", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21i), 10, 0)));
            }
            else
            {
               AV10SecFunctionalityIdAdded.Add(AV15SecFunctionalityIdToFind, 0);
            }
         }
         else
         {
            if ( AV19IsAssociatedOld )
            {
               AV11SecFunctionalityIdRemoved.Add(AV15SecFunctionalityIdToFind, 0);
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
               AV10SecFunctionalityIdAdded.RemoveItem((int)(AV21i));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21i", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21i), 10, 0)));
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
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV11SecFunctionalityIdRemoved", AV11SecFunctionalityIdRemoved);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10SecFunctionalityIdAdded", AV10SecFunctionalityIdAdded);
      }

      protected void S132( )
      {
         /* 'FIND IN ADDED' Routine */
         AV21i = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21i", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21i), 10, 0)));
         AV88GXV3 = 1;
         while ( AV88GXV3 <= AV10SecFunctionalityIdAdded.Count )
         {
            AV14SecFunctionalityId = (long)(AV10SecFunctionalityIdAdded.GetNumeric(AV88GXV3));
            if ( AV14SecFunctionalityId == AV15SecFunctionalityIdToFind )
            {
               if (true) break;
            }
            AV21i = (long)(AV21i+1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21i", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21i), 10, 0)));
            AV88GXV3 = (int)(AV88GXV3+1);
         }
         if ( AV21i > AV10SecFunctionalityIdAdded.Count )
         {
            AV21i = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21i", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21i), 10, 0)));
         }
      }

      protected void S122( )
      {
         /* 'FIND IN REMOVED' Routine */
         AV21i = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21i", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21i), 10, 0)));
         AV89GXV4 = 1;
         while ( AV89GXV4 <= AV11SecFunctionalityIdRemoved.Count )
         {
            AV14SecFunctionalityId = (long)(AV11SecFunctionalityIdRemoved.GetNumeric(AV89GXV4));
            if ( AV14SecFunctionalityId == AV15SecFunctionalityIdToFind )
            {
               if (true) break;
            }
            AV21i = (long)(AV21i+1);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21i", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21i), 10, 0)));
            AV89GXV4 = (int)(AV89GXV4+1);
         }
         if ( AV21i > AV11SecFunctionalityIdRemoved.Count )
         {
            AV21i = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21i", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21i), 10, 0)));
         }
      }

      protected void S112( )
      {
         /* 'LOAD LISTS' Routine */
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV13SecFunctionalityIdRemovedXml)) )
         {
            AV11SecFunctionalityIdRemoved.FromXml(AV13SecFunctionalityIdRemovedXml, null, "Collection", "");
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12SecFunctionalityIdAddedXml)) )
         {
            AV10SecFunctionalityIdAdded.FromXml(AV12SecFunctionalityIdAddedXml, null, "Collection", "");
         }
      }

      protected void S152( )
      {
         /* 'SAVE LISTS' Routine */
         if ( AV11SecFunctionalityIdRemoved.Count > 0 )
         {
            AV13SecFunctionalityIdRemovedXml = AV11SecFunctionalityIdRemoved.ToXml(false, true, "Collection", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13SecFunctionalityIdRemovedXml", AV13SecFunctionalityIdRemovedXml);
         }
         else
         {
            AV13SecFunctionalityIdRemovedXml = "";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13SecFunctionalityIdRemovedXml", AV13SecFunctionalityIdRemovedXml);
         }
         if ( AV10SecFunctionalityIdAdded.Count > 0 )
         {
            AV12SecFunctionalityIdAddedXml = AV10SecFunctionalityIdAdded.ToXml(false, true, "Collection", "");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SecFunctionalityIdAddedXml", AV12SecFunctionalityIdAddedXml);
         }
         else
         {
            AV12SecFunctionalityIdAddedXml = "";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SecFunctionalityIdAddedXml", AV12SecFunctionalityIdAddedXml);
         }
      }

      protected void S142( )
      {
         /* 'SHOW ERROR MESSAGES' Routine */
         AV91GXV6 = 1;
         AV90GXV5 = AV16SecFunctionalityRole.GetMessages();
         while ( AV91GXV6 <= AV90GXV5.Count )
         {
            AV20Message = ((SdtMessages_Message)AV90GXV5.Item(AV91GXV6));
            if ( AV20Message.gxTpr_Type == 1 )
            {
               GX_msglist.addItem(AV20Message.gxTpr_Description);
            }
            AV91GXV6 = (int)(AV91GXV6+1);
         }
      }

      protected void wb_table1_14_0N2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblUnnamedtable1_Internalname, tblUnnamedtable1_Internalname, "", "", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavSecfunctionalitykey_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSecfunctionalitykey_Internalname, "权限名称", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_25_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSecfunctionalitykey_Internalname, AV25SecFunctionalityKey, StringUtil.RTrim( context.localUtil.Format( AV25SecFunctionalityKey, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,19);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSecfunctionalitykey_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavSecfunctionalitykey_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecRoleFunRoleActionAssociationWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_14_0N2e( true) ;
         }
         else
         {
            wb_table1_14_0N2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV9SecRoleId = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9SecRoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9SecRoleId), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vSECROLEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9SecRoleId), "ZZZ9"), context));
         AV29SecParentFunctionalityId = Convert.ToInt64(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29SecParentFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29SecParentFunctionalityId), 10, 0)));
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
         PA0N2( ) ;
         WS0N2( ) ;
         WE0N2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022711583778", true);
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
         context.AddJavascriptSource("wwpbaseobjects/secrolefunroleactionassociationww.js", "?202022711583779", false);
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

      protected void SubsflControlProps_252( )
      {
         chkavIsassociated_Internalname = "vISASSOCIATED_"+sGXsfl_25_idx;
         chkavIsassociatedold_Internalname = "vISASSOCIATEDOLD_"+sGXsfl_25_idx;
         edtSecFunctionalityId_Internalname = "SECFUNCTIONALITYID_"+sGXsfl_25_idx;
         edtSecFunctionalityKey_Internalname = "SECFUNCTIONALITYKEY_"+sGXsfl_25_idx;
         edtSecFunctionalityDescription_Internalname = "SECFUNCTIONALITYDESCRIPTION_"+sGXsfl_25_idx;
         cmbSecFunctionalityType_Internalname = "SECFUNCTIONALITYTYPE_"+sGXsfl_25_idx;
         edtSecParentFunctionalityId_Internalname = "SECPARENTFUNCTIONALITYID_"+sGXsfl_25_idx;
         edtSecParentFunctionalityDescription_Internalname = "SECPARENTFUNCTIONALITYDESCRIPTION_"+sGXsfl_25_idx;
         chkSecFunctionalityActive_Internalname = "SECFUNCTIONALITYACTIVE_"+sGXsfl_25_idx;
      }

      protected void SubsflControlProps_fel_252( )
      {
         chkavIsassociated_Internalname = "vISASSOCIATED_"+sGXsfl_25_fel_idx;
         chkavIsassociatedold_Internalname = "vISASSOCIATEDOLD_"+sGXsfl_25_fel_idx;
         edtSecFunctionalityId_Internalname = "SECFUNCTIONALITYID_"+sGXsfl_25_fel_idx;
         edtSecFunctionalityKey_Internalname = "SECFUNCTIONALITYKEY_"+sGXsfl_25_fel_idx;
         edtSecFunctionalityDescription_Internalname = "SECFUNCTIONALITYDESCRIPTION_"+sGXsfl_25_fel_idx;
         cmbSecFunctionalityType_Internalname = "SECFUNCTIONALITYTYPE_"+sGXsfl_25_fel_idx;
         edtSecParentFunctionalityId_Internalname = "SECPARENTFUNCTIONALITYID_"+sGXsfl_25_fel_idx;
         edtSecParentFunctionalityDescription_Internalname = "SECPARENTFUNCTIONALITYDESCRIPTION_"+sGXsfl_25_fel_idx;
         chkSecFunctionalityActive_Internalname = "SECFUNCTIONALITYACTIVE_"+sGXsfl_25_fel_idx;
      }

      protected void sendrow_252( )
      {
         SubsflControlProps_252( ) ;
         WB0N0( ) ;
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
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecFunctionalityId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SecFunctionalityId), 10, 0, ".", "")),context.localUtil.Format( (decimal)(A1SecFunctionalityId), "ZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSecFunctionalityId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)25,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecFunctionalityKey_Internalname,(String)A3SecFunctionalityKey,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSecFunctionalityKey_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)25,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecFunctionalityDescription_Internalname,(String)A8SecFunctionalityDescription,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSecFunctionalityDescription_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)25,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            if ( ( cmbSecFunctionalityType.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "SECFUNCTIONALITYTYPE_" + sGXsfl_25_idx;
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
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbSecFunctionalityType_Internalname, "Values", (String)(cmbSecFunctionalityType.ToJavascriptSource()), !bGXsfl_25_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecParentFunctionalityId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A2SecParentFunctionalityId), 10, 0, ".", "")),context.localUtil.Format( (decimal)(A2SecParentFunctionalityId), "ZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSecParentFunctionalityId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)25,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSecParentFunctionalityDescription_Internalname,(String)A11SecParentFunctionalityDescription,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSecParentFunctionalityDescription_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)25,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Check box */
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GridRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkSecFunctionalityActive_Internalname,StringUtil.BoolToStr( A7SecFunctionalityActive),(String)"",(String)"",(short)0,(short)0,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn hidden-xs",(String)"",(String)""});
            send_integrity_lvl_hashes0N2( ) ;
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
         GXCCtl = "SECFUNCTIONALITYTYPE_" + sGXsfl_25_idx;
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
         GXCCtl = "SECFUNCTIONALITYACTIVE_" + sGXsfl_25_idx;
         chkSecFunctionalityActive.Name = GXCCtl;
         chkSecFunctionalityActive.WebTags = "";
         chkSecFunctionalityActive.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkSecFunctionalityActive_Internalname, "TitleCaption", chkSecFunctionalityActive.Caption, !bGXsfl_25_Refreshing);
         chkSecFunctionalityActive.CheckedValue = "false";
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtavSecfunctionalitykey_Internalname = "vSECFUNCTIONALITYKEY";
         tblUnnamedtable1_Internalname = "UNNAMEDTABLE1";
         divLayout_unnamedtable1_Internalname = "LAYOUT_UNNAMEDTABLE1";
         Dvpanel_unnamedtable1_Internalname = "DVPANEL_UNNAMEDTABLE1";
         divHtml_dvpanel_unnamedtable1_Internalname = "HTML_DVPANEL_UNNAMEDTABLE1";
         chkavIsassociated_Internalname = "vISASSOCIATED";
         chkavIsassociatedold_Internalname = "vISASSOCIATEDOLD";
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
         bttBtnconfirm_Internalname = "BTNCONFIRM";
         bttBtncancel_Internalname = "BTNCANCEL";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_secfunctionalitykey_Internalname = "DDO_SECFUNCTIONALITYKEY";
         edtavDdo_secfunctionalitykeytitlecontrolidtoreplace_Internalname = "vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE";
         Ddo_secfunctionalitydescription_Internalname = "DDO_SECFUNCTIONALITYDESCRIPTION";
         edtavDdo_secfunctionalitydescriptiontitlecontrolidtoreplace_Internalname = "vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE";
         edtavSecfunctionalityidaddedxml_Internalname = "vSECFUNCTIONALITYIDADDEDXML";
         edtavSecfunctionalityidremovedxml_Internalname = "vSECFUNCTIONALITYIDREMOVEDXML";
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
         chkSecFunctionalityActive.Caption = "";
         chkavIsassociatedold.Caption = "";
         chkavIsassociated.Caption = "";
         edtSecParentFunctionalityDescription_Jsonclick = "";
         edtSecParentFunctionalityId_Jsonclick = "";
         cmbSecFunctionalityType_Jsonclick = "";
         edtSecFunctionalityDescription_Jsonclick = "";
         edtSecFunctionalityKey_Jsonclick = "";
         edtSecFunctionalityId_Jsonclick = "";
         chkavIsassociatedold.Visible = 0;
         chkavIsassociated.Visible = -1;
         chkavIsassociated.Enabled = 1;
         edtavSecfunctionalitykey_Jsonclick = "";
         edtavSecfunctionalitykey_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavSecfunctionalityidremovedxml_Visible = 1;
         edtavSecfunctionalityidaddedxml_Visible = 1;
         edtavDdo_secfunctionalitydescriptiontitlecontrolidtoreplace_Visible = 1;
         edtavDdo_secfunctionalitykeytitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtSecFunctionalityDescription_Titleformat = 0;
         edtSecFunctionalityDescription_Title = "权限描述";
         edtSecFunctionalityKey_Titleformat = 0;
         edtSecFunctionalityKey_Title = "权限名称";
         chkavIsassociatedold.Enabled = 1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
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
         Ddo_secfunctionalitykey_Sortdsc = "WWP_TSSortDSC";
         Ddo_secfunctionalitykey_Sortasc = "WWP_TSSortASC";
         Ddo_secfunctionalitykey_Includedatalist = Convert.ToBoolean( 0);
         Ddo_secfunctionalitykey_Includefilter = Convert.ToBoolean( 0);
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
         Form.Caption = "Association Role";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV25SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV35OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV36OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV29SecParentFunctionalityId',fld:'vSECPARENTFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9'},{av:'AV21i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV11SecFunctionalityIdRemoved',fld:'vSECFUNCTIONALITYIDREMOVED',pic:''},{av:'AV15SecFunctionalityIdToFind',fld:'vSECFUNCTIONALITYIDTOFIND',pic:'ZZZZZZZZZ9'},{av:'AV10SecFunctionalityIdAdded',fld:'vSECFUNCTIONALITYIDADDED',pic:''},{av:'AV31SecRoleIdParm',fld:'vSECROLEIDPARM',pic:'ZZZ9'},{av:'AV59ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13SecFunctionalityIdRemovedXml',fld:'vSECFUNCTIONALITYIDREMOVEDXML',pic:''},{av:'AV12SecFunctionalityIdAddedXml',fld:'vSECFUNCTIONALITYIDADDEDXML',pic:''},{av:'AV9SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV56SecFunctionalityKeyTitleFilterData',fld:'vSECFUNCTIONALITYKEYTITLEFILTERDATA',pic:''},{av:'AV60SecFunctionalityDescriptionTitleFilterData',fld:'vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtSecFunctionalityKey_Titleformat',ctrl:'SECFUNCTIONALITYKEY',prop:'Titleformat'},{av:'edtSecFunctionalityKey_Title',ctrl:'SECFUNCTIONALITYKEY',prop:'Title'},{av:'edtSecFunctionalityDescription_Titleformat',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Titleformat'},{av:'edtSecFunctionalityDescription_Title',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Title'},{av:'AV78GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV80GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV81GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV11SecFunctionalityIdRemoved',fld:'vSECFUNCTIONALITYIDREMOVED',pic:''},{av:'AV10SecFunctionalityIdAdded',fld:'vSECFUNCTIONALITYIDADDED',pic:''}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E110N2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV25SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV35OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV36OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV29SecParentFunctionalityId',fld:'vSECPARENTFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'AV59ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV13SecFunctionalityIdRemovedXml',fld:'vSECFUNCTIONALITYIDREMOVEDXML',pic:''},{av:'AV12SecFunctionalityIdAddedXml',fld:'vSECFUNCTIONALITYIDADDEDXML',pic:''},{av:'AV9SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true},{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9'},{av:'AV21i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV11SecFunctionalityIdRemoved',fld:'vSECFUNCTIONALITYIDREMOVED',pic:''},{av:'AV15SecFunctionalityIdToFind',fld:'vSECFUNCTIONALITYIDTOFIND',pic:'ZZZZZZZZZ9'},{av:'AV10SecFunctionalityIdAdded',fld:'vSECFUNCTIONALITYIDADDED',pic:''},{av:'AV31SecRoleIdParm',fld:'vSECROLEIDPARM',pic:'ZZZ9'},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E120N2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV25SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV35OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV36OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV29SecParentFunctionalityId',fld:'vSECPARENTFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'AV59ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV13SecFunctionalityIdRemovedXml',fld:'vSECFUNCTIONALITYIDREMOVEDXML',pic:''},{av:'AV12SecFunctionalityIdAddedXml',fld:'vSECFUNCTIONALITYIDADDEDXML',pic:''},{av:'AV9SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true},{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9'},{av:'AV21i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV11SecFunctionalityIdRemoved',fld:'vSECFUNCTIONALITYIDREMOVED',pic:''},{av:'AV15SecFunctionalityIdToFind',fld:'vSECFUNCTIONALITYIDTOFIND',pic:'ZZZZZZZZZ9'},{av:'AV10SecFunctionalityIdAdded',fld:'vSECFUNCTIONALITYIDADDED',pic:''},{av:'AV31SecRoleIdParm',fld:'vSECROLEIDPARM',pic:'ZZZ9'},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_SECFUNCTIONALITYKEY.ONOPTIONCLICKED","{handler:'E130N2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV25SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV35OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV36OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV29SecParentFunctionalityId',fld:'vSECPARENTFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'AV59ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV13SecFunctionalityIdRemovedXml',fld:'vSECFUNCTIONALITYIDREMOVEDXML',pic:''},{av:'AV12SecFunctionalityIdAddedXml',fld:'vSECFUNCTIONALITYIDADDEDXML',pic:''},{av:'AV9SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true},{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9'},{av:'AV21i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV11SecFunctionalityIdRemoved',fld:'vSECFUNCTIONALITYIDREMOVED',pic:''},{av:'AV15SecFunctionalityIdToFind',fld:'vSECFUNCTIONALITYIDTOFIND',pic:'ZZZZZZZZZ9'},{av:'AV10SecFunctionalityIdAdded',fld:'vSECFUNCTIONALITYIDADDED',pic:''},{av:'AV31SecRoleIdParm',fld:'vSECROLEIDPARM',pic:'ZZZ9'},{av:'Ddo_secfunctionalitykey_Activeeventkey',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_SECFUNCTIONALITYKEY.ONOPTIONCLICKED",",oparms:[{av:'AV35OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV36OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_secfunctionalitykey_Sortedstatus',ctrl:'DDO_SECFUNCTIONALITYKEY',prop:'SortedStatus'},{av:'AV56SecFunctionalityKeyTitleFilterData',fld:'vSECFUNCTIONALITYKEYTITLEFILTERDATA',pic:''},{av:'AV60SecFunctionalityDescriptionTitleFilterData',fld:'vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtSecFunctionalityKey_Titleformat',ctrl:'SECFUNCTIONALITYKEY',prop:'Titleformat'},{av:'edtSecFunctionalityKey_Title',ctrl:'SECFUNCTIONALITYKEY',prop:'Title'},{av:'edtSecFunctionalityDescription_Titleformat',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Titleformat'},{av:'edtSecFunctionalityDescription_Title',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Title'},{av:'AV78GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV80GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV81GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV11SecFunctionalityIdRemoved',fld:'vSECFUNCTIONALITYIDREMOVED',pic:''},{av:'AV10SecFunctionalityIdAdded',fld:'vSECFUNCTIONALITYIDADDED',pic:''}]}");
         setEventMetadata("DDO_SECFUNCTIONALITYDESCRIPTION.ONOPTIONCLICKED","{handler:'E140N2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV25SecFunctionalityKey',fld:'vSECFUNCTIONALITYKEY',pic:''},{av:'AV35OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV36OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV29SecParentFunctionalityId',fld:'vSECPARENTFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'AV59ddo_SecFunctionalityKeyTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYKEYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace',fld:'vDDO_SECFUNCTIONALITYDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV13SecFunctionalityIdRemovedXml',fld:'vSECFUNCTIONALITYIDREMOVEDXML',pic:''},{av:'AV12SecFunctionalityIdAddedXml',fld:'vSECFUNCTIONALITYIDADDEDXML',pic:''},{av:'AV9SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true},{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9'},{av:'AV21i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV11SecFunctionalityIdRemoved',fld:'vSECFUNCTIONALITYIDREMOVED',pic:''},{av:'AV15SecFunctionalityIdToFind',fld:'vSECFUNCTIONALITYIDTOFIND',pic:'ZZZZZZZZZ9'},{av:'AV10SecFunctionalityIdAdded',fld:'vSECFUNCTIONALITYIDADDED',pic:''},{av:'AV31SecRoleIdParm',fld:'vSECROLEIDPARM',pic:'ZZZ9'},{av:'Ddo_secfunctionalitydescription_Activeeventkey',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_SECFUNCTIONALITYDESCRIPTION.ONOPTIONCLICKED",",oparms:[{av:'AV35OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV36OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_secfunctionalitydescription_Sortedstatus',ctrl:'DDO_SECFUNCTIONALITYDESCRIPTION',prop:'SortedStatus'},{av:'AV56SecFunctionalityKeyTitleFilterData',fld:'vSECFUNCTIONALITYKEYTITLEFILTERDATA',pic:''},{av:'AV60SecFunctionalityDescriptionTitleFilterData',fld:'vSECFUNCTIONALITYDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'edtSecFunctionalityKey_Titleformat',ctrl:'SECFUNCTIONALITYKEY',prop:'Titleformat'},{av:'edtSecFunctionalityKey_Title',ctrl:'SECFUNCTIONALITYKEY',prop:'Title'},{av:'edtSecFunctionalityDescription_Titleformat',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Titleformat'},{av:'edtSecFunctionalityDescription_Title',ctrl:'SECFUNCTIONALITYDESCRIPTION',prop:'Title'},{av:'AV78GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV80GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV81GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV11SecFunctionalityIdRemoved',fld:'vSECFUNCTIONALITYIDREMOVED',pic:''},{av:'AV10SecFunctionalityIdAdded',fld:'vSECFUNCTIONALITYIDADDED',pic:''}]}");
         setEventMetadata("GRID.LOAD","{handler:'E180N2',iparms:[{av:'AV9SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true},{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9'},{av:'A1SecFunctionalityId',fld:'SECFUNCTIONALITYID',pic:'ZZZZZZZZZ9',hsh:true},{av:'AV21i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV11SecFunctionalityIdRemoved',fld:'vSECFUNCTIONALITYIDREMOVED',pic:''},{av:'AV15SecFunctionalityIdToFind',fld:'vSECFUNCTIONALITYIDTOFIND',pic:'ZZZZZZZZZ9'},{av:'AV10SecFunctionalityIdAdded',fld:'vSECFUNCTIONALITYIDADDED',pic:''},{av:'AV31SecRoleIdParm',fld:'vSECROLEIDPARM',pic:'ZZZ9'}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV31SecRoleIdParm',fld:'vSECROLEIDPARM',pic:'ZZZ9'},{av:'AV19IsAssociatedOld',fld:'vISASSOCIATEDOLD',pic:'',hsh:true},{av:'AV15SecFunctionalityIdToFind',fld:'vSECFUNCTIONALITYIDTOFIND',pic:'ZZZZZZZZZ9'},{av:'AV18IsAssociated',fld:'vISASSOCIATED',pic:''},{av:'AV21i',fld:'vI',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("ENTER","{handler:'E150N2',iparms:[{av:'AV11SecFunctionalityIdRemoved',fld:'vSECFUNCTIONALITYIDREMOVED',pic:''},{av:'AV9SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true},{av:'AV10SecFunctionalityIdAdded',fld:'vSECFUNCTIONALITYIDADDED',pic:''},{av:'AV13SecFunctionalityIdRemovedXml',fld:'vSECFUNCTIONALITYIDREMOVEDXML',pic:''},{av:'AV12SecFunctionalityIdAddedXml',fld:'vSECFUNCTIONALITYIDADDEDXML',pic:''},{av:'AV16SecFunctionalityRole',fld:'vSECFUNCTIONALITYROLE',pic:''}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV21i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV16SecFunctionalityRole',fld:'vSECFUNCTIONALITYROLE',pic:''},{av:'AV12SecFunctionalityIdAddedXml',fld:'vSECFUNCTIONALITYIDADDEDXML',pic:''},{av:'AV13SecFunctionalityIdRemovedXml',fld:'vSECFUNCTIONALITYIDREMOVEDXML',pic:''},{av:'AV11SecFunctionalityIdRemoved',fld:'vSECFUNCTIONALITYIDREMOVED',pic:''},{av:'AV10SecFunctionalityIdAdded',fld:'vSECFUNCTIONALITYIDADDED',pic:''}]}");
         setEventMetadata("VISASSOCIATED.CLICK","{handler:'E190N2',iparms:[{av:'A1SecFunctionalityId',fld:'SECFUNCTIONALITYID',pic:'ZZZZZZZZZ9',hsh:true},{av:'AV18IsAssociated',fld:'vISASSOCIATED',pic:''},{av:'AV19IsAssociatedOld',fld:'vISASSOCIATEDOLD',pic:'',hsh:true},{av:'AV21i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV11SecFunctionalityIdRemoved',fld:'vSECFUNCTIONALITYIDREMOVED',pic:''},{av:'AV10SecFunctionalityIdAdded',fld:'vSECFUNCTIONALITYIDADDED',pic:''},{av:'AV13SecFunctionalityIdRemovedXml',fld:'vSECFUNCTIONALITYIDREMOVEDXML',pic:''},{av:'AV12SecFunctionalityIdAddedXml',fld:'vSECFUNCTIONALITYIDADDEDXML',pic:''},{av:'AV15SecFunctionalityIdToFind',fld:'vSECFUNCTIONALITYIDTOFIND',pic:'ZZZZZZZZZ9'}]");
         setEventMetadata("VISASSOCIATED.CLICK",",oparms:[{av:'AV15SecFunctionalityIdToFind',fld:'vSECFUNCTIONALITYIDTOFIND',pic:'ZZZZZZZZZ9'},{av:'AV11SecFunctionalityIdRemoved',fld:'vSECFUNCTIONALITYIDREMOVED',pic:''},{av:'AV10SecFunctionalityIdAdded',fld:'vSECFUNCTIONALITYIDADDED',pic:''},{av:'AV21i',fld:'vI',pic:'ZZZZZZZZZ9'},{av:'AV13SecFunctionalityIdRemovedXml',fld:'vSECFUNCTIONALITYIDREMOVEDXML',pic:''},{av:'AV12SecFunctionalityIdAddedXml',fld:'vSECFUNCTIONALITYIDADDEDXML',pic:''}]}");
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
         Ddo_secfunctionalitydescription_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV25SecFunctionalityKey = "";
         AV59ddo_SecFunctionalityKeyTitleControlIdToReplace = "";
         AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace = "";
         AV13SecFunctionalityIdRemovedXml = "";
         AV12SecFunctionalityIdAddedXml = "";
         AV11SecFunctionalityIdRemoved = new GxSimpleCollection<long>();
         AV10SecFunctionalityIdAdded = new GxSimpleCollection<long>();
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV71DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV56SecFunctionalityKeyTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV60SecFunctionalityDescriptionTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV16SecFunctionalityRole = new GeneXus.Programs.wwpbaseobjects.SdtSecFunctionalityRole(context);
         Ddo_secfunctionalitykey_Sortedstatus = "";
         Ddo_secfunctionalitydescription_Sortedstatus = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ucDvpanel_unnamedtable1 = new GXUserControl();
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         A3SecFunctionalityKey = "";
         A8SecFunctionalityDescription = "";
         A11SecParentFunctionalityDescription = "";
         ucGridpaginationbar = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtnconfirm_Jsonclick = "";
         bttBtncancel_Jsonclick = "";
         ucDdo_secfunctionalitykey = new GXUserControl();
         ucDdo_secfunctionalitydescription = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         lV25SecFunctionalityKey = "";
         H000N2_A1SecFunctionalityId = new long[1] ;
         H000N2_A7SecFunctionalityActive = new bool[] {false} ;
         H000N2_A11SecParentFunctionalityDescription = new String[] {""} ;
         H000N2_A2SecParentFunctionalityId = new long[1] ;
         H000N2_n2SecParentFunctionalityId = new bool[] {false} ;
         H000N2_A9SecFunctionalityType = new short[1] ;
         H000N2_A8SecFunctionalityDescription = new String[] {""} ;
         H000N2_A3SecFunctionalityKey = new String[] {""} ;
         H000N3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         H000N4_A4SecRoleId = new short[1] ;
         H000N4_A12SecRoleDescription = new String[] {""} ;
         A12SecRoleDescription = "";
         AV74WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         H000N5_A1SecFunctionalityId = new long[1] ;
         H000N5_A4SecRoleId = new short[1] ;
         GridRow = new GXWebRow();
         AV90GXV5 = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         AV20Message = new SdtMessages_Message(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         GXCCtl = "";
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secrolefunroleactionassociationww__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secrolefunroleactionassociationww__default(),
            new Object[][] {
                new Object[] {
               H000N2_A1SecFunctionalityId, H000N2_A7SecFunctionalityActive, H000N2_A11SecParentFunctionalityDescription, H000N2_A2SecParentFunctionalityId, H000N2_n2SecParentFunctionalityId, H000N2_A9SecFunctionalityType, H000N2_A8SecFunctionalityDescription, H000N2_A3SecFunctionalityKey
               }
               , new Object[] {
               H000N3_AGRID_nRecordCount
               }
               , new Object[] {
               H000N4_A4SecRoleId, H000N4_A12SecRoleDescription
               }
               , new Object[] {
               H000N5_A1SecFunctionalityId, H000N5_A4SecRoleId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
         chkavIsassociatedold.Enabled = 0;
      }

      private short AV9SecRoleId ;
      private short wcpOAV9SecRoleId ;
      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_25 ;
      private short nGXsfl_25_idx=1 ;
      private short GRID_nEOF ;
      private short AV35OrderedBy ;
      private short A4SecRoleId ;
      private short AV31SecRoleIdParm ;
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
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_secfunctionalitykeytitlecontrolidtoreplace_Visible ;
      private int edtavDdo_secfunctionalitydescriptiontitlecontrolidtoreplace_Visible ;
      private int edtavSecfunctionalityidaddedxml_Visible ;
      private int edtavSecfunctionalityidremovedxml_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV77PageToGo ;
      private int AV86GXV1 ;
      private int AV87GXV2 ;
      private int AV88GXV3 ;
      private int AV89GXV4 ;
      private int AV91GXV6 ;
      private int edtavSecfunctionalitykey_Enabled ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long AV29SecParentFunctionalityId ;
      private long wcpOAV29SecParentFunctionalityId ;
      private long GRID_nFirstRecordOnPage ;
      private long AV21i ;
      private long AV15SecFunctionalityIdToFind ;
      private long AV78GridCurrentPage ;
      private long AV81GridRecordCount ;
      private long AV80GridPageSize ;
      private long A1SecFunctionalityId ;
      private long A2SecParentFunctionalityId ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private long AV14SecFunctionalityId ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_secfunctionalitykey_Activeeventkey ;
      private String Ddo_secfunctionalitydescription_Activeeventkey ;
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
      private String Ddo_secfunctionalitykey_Caption ;
      private String Ddo_secfunctionalitykey_Tooltip ;
      private String Ddo_secfunctionalitykey_Cls ;
      private String Ddo_secfunctionalitykey_Dropdownoptionstype ;
      private String Ddo_secfunctionalitykey_Titlecontrolidtoreplace ;
      private String Ddo_secfunctionalitykey_Sortedstatus ;
      private String Ddo_secfunctionalitykey_Sortasc ;
      private String Ddo_secfunctionalitykey_Sortdsc ;
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
      private String edtSecFunctionalityKey_Title ;
      private String edtSecFunctionalityDescription_Title ;
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
      private String Ddo_secfunctionalitykey_Internalname ;
      private String edtavDdo_secfunctionalitykeytitlecontrolidtoreplace_Internalname ;
      private String Ddo_secfunctionalitydescription_Internalname ;
      private String edtavDdo_secfunctionalitydescriptiontitlecontrolidtoreplace_Internalname ;
      private String edtavSecfunctionalityidaddedxml_Internalname ;
      private String edtavSecfunctionalityidremovedxml_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String chkavIsassociated_Internalname ;
      private String chkavIsassociatedold_Internalname ;
      private String edtSecFunctionalityId_Internalname ;
      private String edtSecFunctionalityKey_Internalname ;
      private String edtSecFunctionalityDescription_Internalname ;
      private String cmbSecFunctionalityType_Internalname ;
      private String edtSecParentFunctionalityId_Internalname ;
      private String edtSecParentFunctionalityDescription_Internalname ;
      private String chkSecFunctionalityActive_Internalname ;
      private String edtavSecfunctionalitykey_Internalname ;
      private String scmdbuf ;
      private String tblUnnamedtable1_Internalname ;
      private String edtavSecfunctionalitykey_Jsonclick ;
      private String sGXsfl_25_fel_idx="0001" ;
      private String ROClassString ;
      private String edtSecFunctionalityId_Jsonclick ;
      private String edtSecFunctionalityKey_Jsonclick ;
      private String edtSecFunctionalityDescription_Jsonclick ;
      private String GXCCtl ;
      private String cmbSecFunctionalityType_Jsonclick ;
      private String edtSecParentFunctionalityId_Jsonclick ;
      private String edtSecParentFunctionalityDescription_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV36OrderedDsc ;
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
      private bool Ddo_secfunctionalitykey_Includesortasc ;
      private bool Ddo_secfunctionalitykey_Includesortdsc ;
      private bool Ddo_secfunctionalitykey_Includefilter ;
      private bool Ddo_secfunctionalitykey_Includedatalist ;
      private bool Ddo_secfunctionalitydescription_Includesortasc ;
      private bool Ddo_secfunctionalitydescription_Includesortdsc ;
      private bool Ddo_secfunctionalitydescription_Includefilter ;
      private bool Ddo_secfunctionalitydescription_Includedatalist ;
      private bool wbLoad ;
      private bool AV18IsAssociated ;
      private bool AV19IsAssociatedOld ;
      private bool A7SecFunctionalityActive ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n2SecParentFunctionalityId ;
      private bool bGXsfl_25_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV17Success ;
      private String AV13SecFunctionalityIdRemovedXml ;
      private String AV12SecFunctionalityIdAddedXml ;
      private String AV25SecFunctionalityKey ;
      private String AV59ddo_SecFunctionalityKeyTitleControlIdToReplace ;
      private String AV63ddo_SecFunctionalityDescriptionTitleControlIdToReplace ;
      private String A3SecFunctionalityKey ;
      private String A8SecFunctionalityDescription ;
      private String A11SecParentFunctionalityDescription ;
      private String lV25SecFunctionalityKey ;
      private String A12SecRoleDescription ;
      private GxSimpleCollection<long> AV11SecFunctionalityIdRemoved ;
      private GxSimpleCollection<long> AV10SecFunctionalityIdAdded ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_unnamedtable1 ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_secfunctionalitykey ;
      private GXUserControl ucDdo_secfunctionalitydescription ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCheckbox chkavIsassociated ;
      private GXCheckbox chkavIsassociatedold ;
      private GXCombobox cmbSecFunctionalityType ;
      private GXCheckbox chkSecFunctionalityActive ;
      private IDataStoreProvider pr_default ;
      private long[] H000N2_A1SecFunctionalityId ;
      private bool[] H000N2_A7SecFunctionalityActive ;
      private String[] H000N2_A11SecParentFunctionalityDescription ;
      private long[] H000N2_A2SecParentFunctionalityId ;
      private bool[] H000N2_n2SecParentFunctionalityId ;
      private short[] H000N2_A9SecFunctionalityType ;
      private String[] H000N2_A8SecFunctionalityDescription ;
      private String[] H000N2_A3SecFunctionalityKey ;
      private long[] H000N3_AGRID_nRecordCount ;
      private short[] H000N4_A4SecRoleId ;
      private String[] H000N4_A12SecRoleDescription ;
      private long[] H000N5_A1SecFunctionalityId ;
      private short[] H000N5_A4SecRoleId ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GXBaseCollection<SdtMessages_Message> AV90GXV5 ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV56SecFunctionalityKeyTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV60SecFunctionalityDescriptionTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV74WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtSecFunctionalityRole AV16SecFunctionalityRole ;
      private SdtMessages_Message AV20Message ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV71DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class secrolefunroleactionassociationww__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class secrolefunroleactionassociationww__default : DataStoreHelperBase, IDataStoreHelper
 {
    protected Object[] conditional_H000N2( IGxContext context ,
                                           String AV25SecFunctionalityKey ,
                                           String A3SecFunctionalityKey ,
                                           short AV35OrderedBy ,
                                           bool AV36OrderedDsc ,
                                           long A2SecParentFunctionalityId ,
                                           long AV29SecParentFunctionalityId )
    {
       String sWhereString = "" ;
       String scmdbuf ;
       short[] GXv_int2 ;
       GXv_int2 = new short [5] ;
       Object[] GXv_Object3 ;
       GXv_Object3 = new Object [2] ;
       String sSelectString ;
       String sFromString ;
       String sOrderString ;
       sSelectString = " T1.[SecFunctionalityId], T1.[SecFunctionalityActive], T2.[SecFunctionalityDescription] AS SecParentFunctionalityDescription, T1.[SecParentFunctionalityId] AS SecParentFunctionalityId, T1.[SecFunctionalityType], T1.[SecFunctionalityDescription], T1.[SecFunctionalityKey]";
       sFromString = " FROM ([SecFunctionality] T1 WITH (NOLOCK) LEFT JOIN [SecFunctionality] T2 WITH (NOLOCK) ON T2.[SecFunctionalityId] = T1.[SecParentFunctionalityId])";
       sOrderString = "";
       sWhereString = sWhereString + " WHERE (T1.[SecParentFunctionalityId] = @AV29SecParentFunctionalityId)";
       if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV25SecFunctionalityKey)) )
       {
          sWhereString = sWhereString + " and (T1.[SecFunctionalityKey] like '%' + @lV25SecFunctionalityKey + '%')";
       }
       else
       {
          GXv_int2[1] = 1;
       }
       if ( ( AV35OrderedBy == 1 ) && ! AV36OrderedDsc )
       {
          sOrderString = sOrderString + " ORDER BY T1.[SecParentFunctionalityId], T1.[SecFunctionalityKey]";
       }
       else if ( ( AV35OrderedBy == 1 ) && ( AV36OrderedDsc ) )
       {
          sOrderString = sOrderString + " ORDER BY T1.[SecParentFunctionalityId] DESC, T1.[SecFunctionalityKey] DESC";
       }
       else if ( ( AV35OrderedBy == 2 ) && ! AV36OrderedDsc )
       {
          sOrderString = sOrderString + " ORDER BY T1.[SecParentFunctionalityId], T1.[SecFunctionalityDescription]";
       }
       else if ( ( AV35OrderedBy == 2 ) && ( AV36OrderedDsc ) )
       {
          sOrderString = sOrderString + " ORDER BY T1.[SecParentFunctionalityId] DESC, T1.[SecFunctionalityDescription] DESC";
       }
       else if ( true )
       {
          sOrderString = sOrderString + " ORDER BY T1.[SecFunctionalityId]";
       }
       scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
       GXv_Object3[0] = scmdbuf;
       GXv_Object3[1] = GXv_int2;
       return GXv_Object3 ;
    }

    protected Object[] conditional_H000N3( IGxContext context ,
                                           String AV25SecFunctionalityKey ,
                                           String A3SecFunctionalityKey ,
                                           short AV35OrderedBy ,
                                           bool AV36OrderedDsc ,
                                           long A2SecParentFunctionalityId ,
                                           long AV29SecParentFunctionalityId )
    {
       String sWhereString = "" ;
       String scmdbuf ;
       short[] GXv_int4 ;
       GXv_int4 = new short [2] ;
       Object[] GXv_Object5 ;
       GXv_Object5 = new Object [2] ;
       scmdbuf = "SELECT COUNT(*) FROM ([SecFunctionality] T1 WITH (NOLOCK) LEFT JOIN [SecFunctionality] T2 WITH (NOLOCK) ON T2.[SecFunctionalityId] = T1.[SecParentFunctionalityId])";
       scmdbuf = scmdbuf + " WHERE (T1.[SecParentFunctionalityId] = @AV29SecParentFunctionalityId)";
       if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV25SecFunctionalityKey)) )
       {
          sWhereString = sWhereString + " and (T1.[SecFunctionalityKey] like '%' + @lV25SecFunctionalityKey + '%')";
       }
       else
       {
          GXv_int4[1] = 1;
       }
       scmdbuf = scmdbuf + sWhereString;
       if ( ( AV35OrderedBy == 1 ) && ! AV36OrderedDsc )
       {
          scmdbuf = scmdbuf + "";
       }
       else if ( ( AV35OrderedBy == 1 ) && ( AV36OrderedDsc ) )
       {
          scmdbuf = scmdbuf + "";
       }
       else if ( ( AV35OrderedBy == 2 ) && ! AV36OrderedDsc )
       {
          scmdbuf = scmdbuf + "";
       }
       else if ( ( AV35OrderedBy == 2 ) && ( AV36OrderedDsc ) )
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
                   return conditional_H000N2(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (short)dynConstraints[2] , (bool)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] );
             case 1 :
                   return conditional_H000N3(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (short)dynConstraints[2] , (bool)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] );
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
       ,new ForEachCursor(def[3])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmH000N4 ;
        prmH000N4 = new Object[] {
        new Object[] {"@AV9SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmH000N5 ;
        prmH000N5 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0} ,
        new Object[] {"@AV31SecRoleIdParm",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmH000N2 ;
        prmH000N2 = new Object[] {
        new Object[] {"@AV29SecParentFunctionalityId",SqlDbType.Decimal,10,0} ,
        new Object[] {"@lV25SecFunctionalityKey",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
        new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
        new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
        } ;
        Object[] prmH000N3 ;
        prmH000N3 = new Object[] {
        new Object[] {"@AV29SecParentFunctionalityId",SqlDbType.Decimal,10,0} ,
        new Object[] {"@lV25SecFunctionalityKey",SqlDbType.NVarChar,100,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("H000N2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000N2,11,0,true,false )
           ,new CursorDef("H000N3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000N3,1,0,true,false )
           ,new CursorDef("H000N4", "SELECT [SecRoleId], [SecRoleDescription] FROM [SecRole] WITH (NOLOCK) WHERE [SecRoleId] = @AV9SecRoleId ORDER BY [SecRoleId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000N4,1,0,false,true )
           ,new CursorDef("H000N5", "SELECT [SecFunctionalityId], [SecRoleId] FROM [SecFunctionalityRole] WITH (NOLOCK) WHERE [SecFunctionalityId] = @SecFunctionalityId and [SecRoleId] = @AV31SecRoleIdParm ORDER BY [SecFunctionalityId], [SecRoleId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000N5,1,0,false,true )
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
              ((bool[]) buf[1])[0] = rslt.getBool(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((long[]) buf[3])[0] = rslt.getLong(4) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(4);
              ((short[]) buf[5])[0] = rslt.getShort(5) ;
              ((String[]) buf[6])[0] = rslt.getVarchar(6) ;
              ((String[]) buf[7])[0] = rslt.getVarchar(7) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 2 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
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
                 stmt.SetParameter(sIdx, (long)parms[5]);
              }
              if ( (short)parms[1] == 0 )
              {
                 sIdx = (short)(sIdx+1);
                 stmt.SetParameter(sIdx, (String)parms[6]);
              }
              if ( (short)parms[2] == 0 )
              {
                 sIdx = (short)(sIdx+1);
                 stmt.SetParameter(sIdx, (int)parms[7]);
              }
              if ( (short)parms[3] == 0 )
              {
                 sIdx = (short)(sIdx+1);
                 stmt.SetParameter(sIdx, (int)parms[8]);
              }
              if ( (short)parms[4] == 0 )
              {
                 sIdx = (short)(sIdx+1);
                 stmt.SetParameter(sIdx, (int)parms[9]);
              }
              return;
           case 1 :
              sIdx = 0;
              if ( (short)parms[0] == 0 )
              {
                 sIdx = (short)(sIdx+1);
                 stmt.SetParameter(sIdx, (long)parms[2]);
              }
              if ( (short)parms[1] == 0 )
              {
                 sIdx = (short)(sIdx+1);
                 stmt.SetParameter(sIdx, (String)parms[3]);
              }
              return;
           case 2 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 3 :
              stmt.SetParameter(1, (long)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              return;
     }
  }

}

}
