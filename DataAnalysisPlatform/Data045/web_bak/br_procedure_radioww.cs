/*
               File: BR_Procedure_RadioWW
        Description:  诊疗处理化疗信息
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:45:28.56
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
   public class br_procedure_radioww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_procedure_radioww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_procedure_radioww( IGxContext context )
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
               AV17TFBR_Procedure_RadioID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV18TFBR_Procedure_RadioID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV21TFBR_ProcedureID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV22TFBR_ProcedureID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV25TFBR_Procedure_Radio_Loc = GetNextPar( );
               AV26TFBR_Procedure_Radio_Loc_Sel = GetNextPar( );
               AV29TFBR_Procedure_Radio_Amount = GetNextPar( );
               AV43TFBR_Procedure_Radio_Amount_Sel = GetNextPar( );
               AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace = GetNextPar( );
               AV23ddo_BR_ProcedureIDTitleControlIdToReplace = GetNextPar( );
               AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace = GetNextPar( );
               AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace = GetNextPar( );
               AV59Pgmname = GetNextPar( );
               AV39IsAuthorized_Update = StringUtil.StrToBool( GetNextPar( ));
               AV41IsAuthorized_Delete = StringUtil.StrToBool( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Procedure_RadioID, AV18TFBR_Procedure_RadioID_To, AV21TFBR_ProcedureID, AV22TFBR_ProcedureID_To, AV25TFBR_Procedure_Radio_Loc, AV26TFBR_Procedure_Radio_Loc_Sel, AV29TFBR_Procedure_Radio_Amount, AV43TFBR_Procedure_Radio_Amount_Sel, AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace, AV23ddo_BR_ProcedureIDTitleControlIdToReplace, AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace, AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace, AV59Pgmname, AV39IsAuthorized_Update, AV41IsAuthorized_Delete) ;
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
         PA682( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START682( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202279452880", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_procedure_radioww.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PROCEDURE_RADIOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFBR_Procedure_RadioID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PROCEDURE_RADIOID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFBR_Procedure_RadioID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PROCEDUREID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21TFBR_ProcedureID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PROCEDUREID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22TFBR_ProcedureID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PROCEDURE_RADIO_LOC", AV25TFBR_Procedure_Radio_Loc);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PROCEDURE_RADIO_LOC_SEL", AV26TFBR_Procedure_Radio_Loc_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PROCEDURE_RADIO_AMOUNT", AV29TFBR_Procedure_Radio_Amount);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PROCEDURE_RADIO_AMOUNT_SEL", AV43TFBR_Procedure_Radio_Amount_Sel);
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_31", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_31), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV34GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV36GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV35GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV32DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV32DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PROCEDURE_RADIOIDTITLEFILTERDATA", AV16BR_Procedure_RadioIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PROCEDURE_RADIOIDTITLEFILTERDATA", AV16BR_Procedure_RadioIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PROCEDUREIDTITLEFILTERDATA", AV20BR_ProcedureIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PROCEDUREIDTITLEFILTERDATA", AV20BR_ProcedureIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PROCEDURE_RADIO_LOCTITLEFILTERDATA", AV24BR_Procedure_Radio_LocTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PROCEDURE_RADIO_LOCTITLEFILTERDATA", AV24BR_Procedure_Radio_LocTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PROCEDURE_RADIO_AMOUNTTITLEFILTERDATA", AV28BR_Procedure_Radio_AmountTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PROCEDURE_RADIO_AMOUNTTITLEFILTERDATA", AV28BR_Procedure_Radio_AmountTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV59Pgmname));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_UPDATE", AV39IsAuthorized_Update);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_DELETE", AV41IsAuthorized_Delete);
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Caption", StringUtil.RTrim( Ddo_br_procedure_radioid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Tooltip", StringUtil.RTrim( Ddo_br_procedure_radioid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Cls", StringUtil.RTrim( Ddo_br_procedure_radioid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Filteredtext_set", StringUtil.RTrim( Ddo_br_procedure_radioid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Filteredtextto_set", StringUtil.RTrim( Ddo_br_procedure_radioid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedure_radioid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedure_radioid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedure_radioid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedure_radioid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Sortedstatus", StringUtil.RTrim( Ddo_br_procedure_radioid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Includefilter", StringUtil.BoolToStr( Ddo_br_procedure_radioid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Filtertype", StringUtil.RTrim( Ddo_br_procedure_radioid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Filterisrange", StringUtil.BoolToStr( Ddo_br_procedure_radioid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedure_radioid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Sortasc", StringUtil.RTrim( Ddo_br_procedure_radioid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Sortdsc", StringUtil.RTrim( Ddo_br_procedure_radioid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Cleanfilter", StringUtil.RTrim( Ddo_br_procedure_radioid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Rangefilterfrom", StringUtil.RTrim( Ddo_br_procedure_radioid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Rangefilterto", StringUtil.RTrim( Ddo_br_procedure_radioid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedure_radioid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Caption", StringUtil.RTrim( Ddo_br_procedureid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Tooltip", StringUtil.RTrim( Ddo_br_procedureid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Cls", StringUtil.RTrim( Ddo_br_procedureid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Filteredtext_set", StringUtil.RTrim( Ddo_br_procedureid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Filteredtextto_set", StringUtil.RTrim( Ddo_br_procedureid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedureid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedureid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedureid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedureid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Sortedstatus", StringUtil.RTrim( Ddo_br_procedureid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Includefilter", StringUtil.BoolToStr( Ddo_br_procedureid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Filtertype", StringUtil.RTrim( Ddo_br_procedureid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Filterisrange", StringUtil.BoolToStr( Ddo_br_procedureid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedureid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Sortasc", StringUtil.RTrim( Ddo_br_procedureid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Sortdsc", StringUtil.RTrim( Ddo_br_procedureid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Cleanfilter", StringUtil.RTrim( Ddo_br_procedureid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Rangefilterfrom", StringUtil.RTrim( Ddo_br_procedureid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Rangefilterto", StringUtil.RTrim( Ddo_br_procedureid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedureid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Caption", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Tooltip", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Cls", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Filteredtext_set", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Selectedvalue_set", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedure_radio_loc_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedure_radio_loc_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Sortedstatus", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Includefilter", StringUtil.BoolToStr( Ddo_br_procedure_radio_loc_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Filtertype", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Filterisrange", StringUtil.BoolToStr( Ddo_br_procedure_radio_loc_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedure_radio_loc_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Datalisttype", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Datalistproc", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_procedure_radio_loc_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Sortasc", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Sortdsc", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Loadingdata", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Cleanfilter", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Noresultsfound", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Caption", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Tooltip", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Cls", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Filteredtext_set", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Selectedvalue_set", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedure_radio_amount_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedure_radio_amount_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Sortedstatus", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Includefilter", StringUtil.BoolToStr( Ddo_br_procedure_radio_amount_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Filtertype", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Filterisrange", StringUtil.BoolToStr( Ddo_br_procedure_radio_amount_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedure_radio_amount_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Datalisttype", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Datalistproc", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_procedure_radio_amount_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Sortasc", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Sortdsc", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Loadingdata", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Cleanfilter", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Noresultsfound", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_radioid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Filteredtext_get", StringUtil.RTrim( Ddo_br_procedure_radioid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_procedure_radioid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Activeeventkey", StringUtil.RTrim( Ddo_br_procedureid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Filteredtext_get", StringUtil.RTrim( Ddo_br_procedureid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_procedureid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Filteredtext_get", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Selectedvalue_get", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Filteredtext_get", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Selectedvalue_get", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_radioid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Filteredtext_get", StringUtil.RTrim( Ddo_br_procedure_radioid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_procedure_radioid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Activeeventkey", StringUtil.RTrim( Ddo_br_procedureid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Filteredtext_get", StringUtil.RTrim( Ddo_br_procedureid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_procedureid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Filteredtext_get", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Selectedvalue_get", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Filteredtext_get", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Selectedvalue_get", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Selectedvalue_get));
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
            WE682( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT682( ) ;
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
         return formatLink("br_procedure_radioww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "BR_Procedure_RadioWW" ;
      }

      public override String GetPgmdesc( )
      {
         return " 诊疗处理化疗信息" ;
      }

      protected void WB680( )
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
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(31), 2, 0)+","+"null"+");", "插入", bttBtninsert_Jsonclick, 5, "插入", "", StyleString, ClassString, bttBtninsert_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Procedure_RadioWW.htm");
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
               if ( edtBR_Procedure_RadioID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Procedure_RadioID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Procedure_RadioID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_ProcedureID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_ProcedureID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_ProcedureID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Procedure_Radio_Loc_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Procedure_Radio_Loc_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Procedure_Radio_Loc_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Procedure_Radio_Amount_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Procedure_Radio_Amount_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Procedure_Radio_Amount_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV37Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV38Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV40Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A323BR_Procedure_RadioID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Procedure_RadioID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Procedure_RadioID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A139BR_ProcedureID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_ProcedureID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_ProcedureID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A324BR_Procedure_Radio_Loc);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Procedure_Radio_Loc_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Procedure_Radio_Loc_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtBR_Procedure_Radio_Loc_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A325BR_Procedure_Radio_Amount);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Procedure_Radio_Amount_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Procedure_Radio_Amount_Titleformat), 4, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV34GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV36GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV35GridPageSize);
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
            ucDdo_br_procedure_radioid.SetProperty("Caption", Ddo_br_procedure_radioid_Caption);
            ucDdo_br_procedure_radioid.SetProperty("Tooltip", Ddo_br_procedure_radioid_Tooltip);
            ucDdo_br_procedure_radioid.SetProperty("Cls", Ddo_br_procedure_radioid_Cls);
            ucDdo_br_procedure_radioid.SetProperty("DropDownOptionsType", Ddo_br_procedure_radioid_Dropdownoptionstype);
            ucDdo_br_procedure_radioid.SetProperty("IncludeSortASC", Ddo_br_procedure_radioid_Includesortasc);
            ucDdo_br_procedure_radioid.SetProperty("IncludeSortDSC", Ddo_br_procedure_radioid_Includesortdsc);
            ucDdo_br_procedure_radioid.SetProperty("IncludeFilter", Ddo_br_procedure_radioid_Includefilter);
            ucDdo_br_procedure_radioid.SetProperty("FilterType", Ddo_br_procedure_radioid_Filtertype);
            ucDdo_br_procedure_radioid.SetProperty("FilterIsRange", Ddo_br_procedure_radioid_Filterisrange);
            ucDdo_br_procedure_radioid.SetProperty("IncludeDataList", Ddo_br_procedure_radioid_Includedatalist);
            ucDdo_br_procedure_radioid.SetProperty("SortASC", Ddo_br_procedure_radioid_Sortasc);
            ucDdo_br_procedure_radioid.SetProperty("SortDSC", Ddo_br_procedure_radioid_Sortdsc);
            ucDdo_br_procedure_radioid.SetProperty("CleanFilter", Ddo_br_procedure_radioid_Cleanfilter);
            ucDdo_br_procedure_radioid.SetProperty("RangeFilterFrom", Ddo_br_procedure_radioid_Rangefilterfrom);
            ucDdo_br_procedure_radioid.SetProperty("RangeFilterTo", Ddo_br_procedure_radioid_Rangefilterto);
            ucDdo_br_procedure_radioid.SetProperty("SearchButtonText", Ddo_br_procedure_radioid_Searchbuttontext);
            ucDdo_br_procedure_radioid.SetProperty("DropDownOptionsTitleSettingsIcons", AV32DDO_TitleSettingsIcons);
            ucDdo_br_procedure_radioid.SetProperty("DropDownOptionsData", AV16BR_Procedure_RadioIDTitleFilterData);
            ucDdo_br_procedure_radioid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedure_radioid_Internalname, "DDO_BR_PROCEDURE_RADIOIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedure_radioidtitlecontrolidtoreplace_Internalname, AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,47);\"", 0, edtavDdo_br_procedure_radioidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Procedure_RadioWW.htm");
            /* User Defined Control */
            ucDdo_br_procedureid.SetProperty("Caption", Ddo_br_procedureid_Caption);
            ucDdo_br_procedureid.SetProperty("Tooltip", Ddo_br_procedureid_Tooltip);
            ucDdo_br_procedureid.SetProperty("Cls", Ddo_br_procedureid_Cls);
            ucDdo_br_procedureid.SetProperty("DropDownOptionsType", Ddo_br_procedureid_Dropdownoptionstype);
            ucDdo_br_procedureid.SetProperty("IncludeSortASC", Ddo_br_procedureid_Includesortasc);
            ucDdo_br_procedureid.SetProperty("IncludeSortDSC", Ddo_br_procedureid_Includesortdsc);
            ucDdo_br_procedureid.SetProperty("IncludeFilter", Ddo_br_procedureid_Includefilter);
            ucDdo_br_procedureid.SetProperty("FilterType", Ddo_br_procedureid_Filtertype);
            ucDdo_br_procedureid.SetProperty("FilterIsRange", Ddo_br_procedureid_Filterisrange);
            ucDdo_br_procedureid.SetProperty("IncludeDataList", Ddo_br_procedureid_Includedatalist);
            ucDdo_br_procedureid.SetProperty("SortASC", Ddo_br_procedureid_Sortasc);
            ucDdo_br_procedureid.SetProperty("SortDSC", Ddo_br_procedureid_Sortdsc);
            ucDdo_br_procedureid.SetProperty("CleanFilter", Ddo_br_procedureid_Cleanfilter);
            ucDdo_br_procedureid.SetProperty("RangeFilterFrom", Ddo_br_procedureid_Rangefilterfrom);
            ucDdo_br_procedureid.SetProperty("RangeFilterTo", Ddo_br_procedureid_Rangefilterto);
            ucDdo_br_procedureid.SetProperty("SearchButtonText", Ddo_br_procedureid_Searchbuttontext);
            ucDdo_br_procedureid.SetProperty("DropDownOptionsTitleSettingsIcons", AV32DDO_TitleSettingsIcons);
            ucDdo_br_procedureid.SetProperty("DropDownOptionsData", AV20BR_ProcedureIDTitleFilterData);
            ucDdo_br_procedureid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedureid_Internalname, "DDO_BR_PROCEDUREIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname, AV23ddo_BR_ProcedureIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", 0, edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Procedure_RadioWW.htm");
            /* User Defined Control */
            ucDdo_br_procedure_radio_loc.SetProperty("Caption", Ddo_br_procedure_radio_loc_Caption);
            ucDdo_br_procedure_radio_loc.SetProperty("Tooltip", Ddo_br_procedure_radio_loc_Tooltip);
            ucDdo_br_procedure_radio_loc.SetProperty("Cls", Ddo_br_procedure_radio_loc_Cls);
            ucDdo_br_procedure_radio_loc.SetProperty("DropDownOptionsType", Ddo_br_procedure_radio_loc_Dropdownoptionstype);
            ucDdo_br_procedure_radio_loc.SetProperty("IncludeSortASC", Ddo_br_procedure_radio_loc_Includesortasc);
            ucDdo_br_procedure_radio_loc.SetProperty("IncludeSortDSC", Ddo_br_procedure_radio_loc_Includesortdsc);
            ucDdo_br_procedure_radio_loc.SetProperty("IncludeFilter", Ddo_br_procedure_radio_loc_Includefilter);
            ucDdo_br_procedure_radio_loc.SetProperty("FilterType", Ddo_br_procedure_radio_loc_Filtertype);
            ucDdo_br_procedure_radio_loc.SetProperty("FilterIsRange", Ddo_br_procedure_radio_loc_Filterisrange);
            ucDdo_br_procedure_radio_loc.SetProperty("IncludeDataList", Ddo_br_procedure_radio_loc_Includedatalist);
            ucDdo_br_procedure_radio_loc.SetProperty("DataListType", Ddo_br_procedure_radio_loc_Datalisttype);
            ucDdo_br_procedure_radio_loc.SetProperty("DataListProc", Ddo_br_procedure_radio_loc_Datalistproc);
            ucDdo_br_procedure_radio_loc.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_procedure_radio_loc_Datalistupdateminimumcharacters);
            ucDdo_br_procedure_radio_loc.SetProperty("SortASC", Ddo_br_procedure_radio_loc_Sortasc);
            ucDdo_br_procedure_radio_loc.SetProperty("SortDSC", Ddo_br_procedure_radio_loc_Sortdsc);
            ucDdo_br_procedure_radio_loc.SetProperty("LoadingData", Ddo_br_procedure_radio_loc_Loadingdata);
            ucDdo_br_procedure_radio_loc.SetProperty("CleanFilter", Ddo_br_procedure_radio_loc_Cleanfilter);
            ucDdo_br_procedure_radio_loc.SetProperty("NoResultsFound", Ddo_br_procedure_radio_loc_Noresultsfound);
            ucDdo_br_procedure_radio_loc.SetProperty("SearchButtonText", Ddo_br_procedure_radio_loc_Searchbuttontext);
            ucDdo_br_procedure_radio_loc.SetProperty("DropDownOptionsTitleSettingsIcons", AV32DDO_TitleSettingsIcons);
            ucDdo_br_procedure_radio_loc.SetProperty("DropDownOptionsData", AV24BR_Procedure_Radio_LocTitleFilterData);
            ucDdo_br_procedure_radio_loc.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedure_radio_loc_Internalname, "DDO_BR_PROCEDURE_RADIO_LOCContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedure_radio_loctitlecontrolidtoreplace_Internalname, AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", 0, edtavDdo_br_procedure_radio_loctitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Procedure_RadioWW.htm");
            /* User Defined Control */
            ucDdo_br_procedure_radio_amount.SetProperty("Caption", Ddo_br_procedure_radio_amount_Caption);
            ucDdo_br_procedure_radio_amount.SetProperty("Tooltip", Ddo_br_procedure_radio_amount_Tooltip);
            ucDdo_br_procedure_radio_amount.SetProperty("Cls", Ddo_br_procedure_radio_amount_Cls);
            ucDdo_br_procedure_radio_amount.SetProperty("DropDownOptionsType", Ddo_br_procedure_radio_amount_Dropdownoptionstype);
            ucDdo_br_procedure_radio_amount.SetProperty("IncludeSortASC", Ddo_br_procedure_radio_amount_Includesortasc);
            ucDdo_br_procedure_radio_amount.SetProperty("IncludeSortDSC", Ddo_br_procedure_radio_amount_Includesortdsc);
            ucDdo_br_procedure_radio_amount.SetProperty("IncludeFilter", Ddo_br_procedure_radio_amount_Includefilter);
            ucDdo_br_procedure_radio_amount.SetProperty("FilterType", Ddo_br_procedure_radio_amount_Filtertype);
            ucDdo_br_procedure_radio_amount.SetProperty("FilterIsRange", Ddo_br_procedure_radio_amount_Filterisrange);
            ucDdo_br_procedure_radio_amount.SetProperty("IncludeDataList", Ddo_br_procedure_radio_amount_Includedatalist);
            ucDdo_br_procedure_radio_amount.SetProperty("DataListType", Ddo_br_procedure_radio_amount_Datalisttype);
            ucDdo_br_procedure_radio_amount.SetProperty("DataListProc", Ddo_br_procedure_radio_amount_Datalistproc);
            ucDdo_br_procedure_radio_amount.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_procedure_radio_amount_Datalistupdateminimumcharacters);
            ucDdo_br_procedure_radio_amount.SetProperty("SortASC", Ddo_br_procedure_radio_amount_Sortasc);
            ucDdo_br_procedure_radio_amount.SetProperty("SortDSC", Ddo_br_procedure_radio_amount_Sortdsc);
            ucDdo_br_procedure_radio_amount.SetProperty("LoadingData", Ddo_br_procedure_radio_amount_Loadingdata);
            ucDdo_br_procedure_radio_amount.SetProperty("CleanFilter", Ddo_br_procedure_radio_amount_Cleanfilter);
            ucDdo_br_procedure_radio_amount.SetProperty("NoResultsFound", Ddo_br_procedure_radio_amount_Noresultsfound);
            ucDdo_br_procedure_radio_amount.SetProperty("SearchButtonText", Ddo_br_procedure_radio_amount_Searchbuttontext);
            ucDdo_br_procedure_radio_amount.SetProperty("DropDownOptionsTitleSettingsIcons", AV32DDO_TitleSettingsIcons);
            ucDdo_br_procedure_radio_amount.SetProperty("DropDownOptionsData", AV28BR_Procedure_Radio_AmountTitleFilterData);
            ucDdo_br_procedure_radio_amount.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedure_radio_amount_Internalname, "DDO_BR_PROCEDURE_RADIO_AMOUNTContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedure_radio_amounttitlecontrolidtoreplace_Internalname, AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", 0, edtavDdo_br_procedure_radio_amounttitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Procedure_RadioWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Procedure_RadioWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_Procedure_RadioWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_procedure_radioid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFBR_Procedure_RadioID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV17TFBR_Procedure_RadioID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_procedure_radioid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_procedure_radioid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Procedure_RadioWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_procedure_radioid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFBR_Procedure_RadioID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV18TFBR_Procedure_RadioID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_procedure_radioid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_procedure_radioid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Procedure_RadioWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_procedureid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21TFBR_ProcedureID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV21TFBR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_procedureid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_procedureid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Procedure_RadioWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_procedureid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22TFBR_ProcedureID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV22TFBR_ProcedureID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,60);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_procedureid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_procedureid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Procedure_RadioWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_procedure_radio_loc_Internalname, AV25TFBR_Procedure_Radio_Loc, StringUtil.RTrim( context.localUtil.Format( AV25TFBR_Procedure_Radio_Loc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,61);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_procedure_radio_loc_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_procedure_radio_loc_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Procedure_RadioWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_procedure_radio_loc_sel_Internalname, AV26TFBR_Procedure_Radio_Loc_Sel, StringUtil.RTrim( context.localUtil.Format( AV26TFBR_Procedure_Radio_Loc_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,62);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_procedure_radio_loc_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_procedure_radio_loc_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Procedure_RadioWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_procedure_radio_amount_Internalname, AV29TFBR_Procedure_Radio_Amount, StringUtil.RTrim( context.localUtil.Format( AV29TFBR_Procedure_Radio_Amount, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_procedure_radio_amount_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_procedure_radio_amount_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Procedure_RadioWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_procedure_radio_amount_sel_Internalname, AV43TFBR_Procedure_Radio_Amount_Sel, StringUtil.RTrim( context.localUtil.Format( AV43TFBR_Procedure_Radio_Amount_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_procedure_radio_amount_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_procedure_radio_amount_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Procedure_RadioWW.htm");
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

      protected void START682( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", " 诊疗处理化疗信息", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP680( ) ;
      }

      protected void WS682( )
      {
         START682( ) ;
         EVT682( ) ;
      }

      protected void EVT682( )
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
                              E11682 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E12682 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDURE_RADIOID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E13682 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDUREID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E14682 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDURE_RADIO_LOC.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E15682 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDURE_RADIO_AMOUNT.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E16682 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E17682 ();
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
                              AV37Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV37Display)) ? AV56Display_GXI : context.convertURL( context.PathToRelativeUrl( AV37Display))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV37Display), true);
                              AV38Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV38Update)) ? AV57Update_GXI : context.convertURL( context.PathToRelativeUrl( AV38Update))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV38Update), true);
                              AV40Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV40Delete)) ? AV58Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV40Delete))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV40Delete), true);
                              A323BR_Procedure_RadioID = (long)(context.localUtil.CToN( cgiGet( edtBR_Procedure_RadioID_Internalname), ".", ","));
                              A139BR_ProcedureID = (long)(context.localUtil.CToN( cgiGet( edtBR_ProcedureID_Internalname), ".", ","));
                              A324BR_Procedure_Radio_Loc = cgiGet( edtBR_Procedure_Radio_Loc_Internalname);
                              n324BR_Procedure_Radio_Loc = false;
                              A325BR_Procedure_Radio_Amount = cgiGet( edtBR_Procedure_Radio_Amount_Internalname);
                              n325BR_Procedure_Radio_Amount = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E18682 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E19682 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E20682 ();
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
                                       /* Set Refresh If Tfbr_procedure_radioid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PROCEDURE_RADIOID"), ".", ",") != Convert.ToDecimal( AV17TFBR_Procedure_RadioID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_procedure_radioid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PROCEDURE_RADIOID_TO"), ".", ",") != Convert.ToDecimal( AV18TFBR_Procedure_RadioID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_procedureid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PROCEDUREID"), ".", ",") != Convert.ToDecimal( AV21TFBR_ProcedureID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_procedureid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PROCEDUREID_TO"), ".", ",") != Convert.ToDecimal( AV22TFBR_ProcedureID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_procedure_radio_loc Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PROCEDURE_RADIO_LOC"), AV25TFBR_Procedure_Radio_Loc) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_procedure_radio_loc_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PROCEDURE_RADIO_LOC_SEL"), AV26TFBR_Procedure_Radio_Loc_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_procedure_radio_amount Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PROCEDURE_RADIO_AMOUNT"), AV29TFBR_Procedure_Radio_Amount) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_procedure_radio_amount_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PROCEDURE_RADIO_AMOUNT_SEL"), AV43TFBR_Procedure_Radio_Amount_Sel) != 0 )
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

      protected void WE682( )
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

      protected void PA682( )
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
               GX_FocusControl = edtavDdo_br_procedure_radioidtitlecontrolidtoreplace_Internalname;
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
                                       long AV17TFBR_Procedure_RadioID ,
                                       long AV18TFBR_Procedure_RadioID_To ,
                                       long AV21TFBR_ProcedureID ,
                                       long AV22TFBR_ProcedureID_To ,
                                       String AV25TFBR_Procedure_Radio_Loc ,
                                       String AV26TFBR_Procedure_Radio_Loc_Sel ,
                                       String AV29TFBR_Procedure_Radio_Amount ,
                                       String AV43TFBR_Procedure_Radio_Amount_Sel ,
                                       String AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace ,
                                       String AV23ddo_BR_ProcedureIDTitleControlIdToReplace ,
                                       String AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace ,
                                       String AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace ,
                                       String AV59Pgmname ,
                                       bool AV39IsAuthorized_Update ,
                                       bool AV41IsAuthorized_Delete )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF682( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PROCEDURE_RADIOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A323BR_Procedure_RadioID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_PROCEDURE_RADIOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A323BR_Procedure_RadioID), 18, 0, ".", "")));
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
         RF682( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV59Pgmname = "BR_Procedure_RadioWW";
         context.Gx_err = 0;
      }

      protected void RF682( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 31;
         /* Execute user event: Refresh */
         E19682 ();
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
                                                 AV48BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid ,
                                                 AV49BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to ,
                                                 AV50BR_Procedure_RadioWWDS_3_Tfbr_procedureid ,
                                                 AV51BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to ,
                                                 AV53BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel ,
                                                 AV52BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc ,
                                                 AV55BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel ,
                                                 AV54BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount ,
                                                 A323BR_Procedure_RadioID ,
                                                 A139BR_ProcedureID ,
                                                 A324BR_Procedure_Radio_Loc ,
                                                 A325BR_Procedure_Radio_Amount ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG,
                                                 TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV52BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc = StringUtil.Concat( StringUtil.RTrim( AV52BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc), "%", "");
            lV54BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount = StringUtil.Concat( StringUtil.RTrim( AV54BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount), "%", "");
            /* Using cursor H00682 */
            pr_default.execute(0, new Object[] {AV48BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid, AV49BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to, AV50BR_Procedure_RadioWWDS_3_Tfbr_procedureid, AV51BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to, lV52BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc, AV53BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel, lV54BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount, AV55BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_31_idx = 1;
            sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
            SubsflControlProps_312( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A325BR_Procedure_Radio_Amount = H00682_A325BR_Procedure_Radio_Amount[0];
               n325BR_Procedure_Radio_Amount = H00682_n325BR_Procedure_Radio_Amount[0];
               A324BR_Procedure_Radio_Loc = H00682_A324BR_Procedure_Radio_Loc[0];
               n324BR_Procedure_Radio_Loc = H00682_n324BR_Procedure_Radio_Loc[0];
               A139BR_ProcedureID = H00682_A139BR_ProcedureID[0];
               A323BR_Procedure_RadioID = H00682_A323BR_Procedure_RadioID[0];
               E20682 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 31;
            WB680( ) ;
         }
         bGXsfl_31_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes682( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PROCEDURE_RADIOID"+"_"+sGXsfl_31_idx, GetSecureSignedToken( sGXsfl_31_idx, context.localUtil.Format( (decimal)(A323BR_Procedure_RadioID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         AV48BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid = AV17TFBR_Procedure_RadioID;
         AV49BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to = AV18TFBR_Procedure_RadioID_To;
         AV50BR_Procedure_RadioWWDS_3_Tfbr_procedureid = AV21TFBR_ProcedureID;
         AV51BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to = AV22TFBR_ProcedureID_To;
         AV52BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc = AV25TFBR_Procedure_Radio_Loc;
         AV53BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel = AV26TFBR_Procedure_Radio_Loc_Sel;
         AV54BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount = AV29TFBR_Procedure_Radio_Amount;
         AV55BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel = AV43TFBR_Procedure_Radio_Amount_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV48BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid ,
                                              AV49BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to ,
                                              AV50BR_Procedure_RadioWWDS_3_Tfbr_procedureid ,
                                              AV51BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to ,
                                              AV53BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel ,
                                              AV52BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc ,
                                              AV55BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel ,
                                              AV54BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount ,
                                              A323BR_Procedure_RadioID ,
                                              A139BR_ProcedureID ,
                                              A324BR_Procedure_Radio_Loc ,
                                              A325BR_Procedure_Radio_Amount ,
                                              AV13OrderedBy ,
                                              AV14OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV52BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc = StringUtil.Concat( StringUtil.RTrim( AV52BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc), "%", "");
         lV54BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount = StringUtil.Concat( StringUtil.RTrim( AV54BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount), "%", "");
         /* Using cursor H00683 */
         pr_default.execute(1, new Object[] {AV48BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid, AV49BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to, AV50BR_Procedure_RadioWWDS_3_Tfbr_procedureid, AV51BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to, lV52BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc, AV53BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel, lV54BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount, AV55BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel});
         GRID_nRecordCount = H00683_AGRID_nRecordCount[0];
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
         AV48BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid = AV17TFBR_Procedure_RadioID;
         AV49BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to = AV18TFBR_Procedure_RadioID_To;
         AV50BR_Procedure_RadioWWDS_3_Tfbr_procedureid = AV21TFBR_ProcedureID;
         AV51BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to = AV22TFBR_ProcedureID_To;
         AV52BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc = AV25TFBR_Procedure_Radio_Loc;
         AV53BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel = AV26TFBR_Procedure_Radio_Loc_Sel;
         AV54BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount = AV29TFBR_Procedure_Radio_Amount;
         AV55BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel = AV43TFBR_Procedure_Radio_Amount_Sel;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Procedure_RadioID, AV18TFBR_Procedure_RadioID_To, AV21TFBR_ProcedureID, AV22TFBR_ProcedureID_To, AV25TFBR_Procedure_Radio_Loc, AV26TFBR_Procedure_Radio_Loc_Sel, AV29TFBR_Procedure_Radio_Amount, AV43TFBR_Procedure_Radio_Amount_Sel, AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace, AV23ddo_BR_ProcedureIDTitleControlIdToReplace, AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace, AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace, AV59Pgmname, AV39IsAuthorized_Update, AV41IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV48BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid = AV17TFBR_Procedure_RadioID;
         AV49BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to = AV18TFBR_Procedure_RadioID_To;
         AV50BR_Procedure_RadioWWDS_3_Tfbr_procedureid = AV21TFBR_ProcedureID;
         AV51BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to = AV22TFBR_ProcedureID_To;
         AV52BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc = AV25TFBR_Procedure_Radio_Loc;
         AV53BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel = AV26TFBR_Procedure_Radio_Loc_Sel;
         AV54BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount = AV29TFBR_Procedure_Radio_Amount;
         AV55BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel = AV43TFBR_Procedure_Radio_Amount_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Procedure_RadioID, AV18TFBR_Procedure_RadioID_To, AV21TFBR_ProcedureID, AV22TFBR_ProcedureID_To, AV25TFBR_Procedure_Radio_Loc, AV26TFBR_Procedure_Radio_Loc_Sel, AV29TFBR_Procedure_Radio_Amount, AV43TFBR_Procedure_Radio_Amount_Sel, AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace, AV23ddo_BR_ProcedureIDTitleControlIdToReplace, AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace, AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace, AV59Pgmname, AV39IsAuthorized_Update, AV41IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV48BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid = AV17TFBR_Procedure_RadioID;
         AV49BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to = AV18TFBR_Procedure_RadioID_To;
         AV50BR_Procedure_RadioWWDS_3_Tfbr_procedureid = AV21TFBR_ProcedureID;
         AV51BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to = AV22TFBR_ProcedureID_To;
         AV52BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc = AV25TFBR_Procedure_Radio_Loc;
         AV53BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel = AV26TFBR_Procedure_Radio_Loc_Sel;
         AV54BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount = AV29TFBR_Procedure_Radio_Amount;
         AV55BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel = AV43TFBR_Procedure_Radio_Amount_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Procedure_RadioID, AV18TFBR_Procedure_RadioID_To, AV21TFBR_ProcedureID, AV22TFBR_ProcedureID_To, AV25TFBR_Procedure_Radio_Loc, AV26TFBR_Procedure_Radio_Loc_Sel, AV29TFBR_Procedure_Radio_Amount, AV43TFBR_Procedure_Radio_Amount_Sel, AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace, AV23ddo_BR_ProcedureIDTitleControlIdToReplace, AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace, AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace, AV59Pgmname, AV39IsAuthorized_Update, AV41IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV48BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid = AV17TFBR_Procedure_RadioID;
         AV49BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to = AV18TFBR_Procedure_RadioID_To;
         AV50BR_Procedure_RadioWWDS_3_Tfbr_procedureid = AV21TFBR_ProcedureID;
         AV51BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to = AV22TFBR_ProcedureID_To;
         AV52BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc = AV25TFBR_Procedure_Radio_Loc;
         AV53BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel = AV26TFBR_Procedure_Radio_Loc_Sel;
         AV54BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount = AV29TFBR_Procedure_Radio_Amount;
         AV55BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel = AV43TFBR_Procedure_Radio_Amount_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Procedure_RadioID, AV18TFBR_Procedure_RadioID_To, AV21TFBR_ProcedureID, AV22TFBR_ProcedureID_To, AV25TFBR_Procedure_Radio_Loc, AV26TFBR_Procedure_Radio_Loc_Sel, AV29TFBR_Procedure_Radio_Amount, AV43TFBR_Procedure_Radio_Amount_Sel, AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace, AV23ddo_BR_ProcedureIDTitleControlIdToReplace, AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace, AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace, AV59Pgmname, AV39IsAuthorized_Update, AV41IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV48BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid = AV17TFBR_Procedure_RadioID;
         AV49BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to = AV18TFBR_Procedure_RadioID_To;
         AV50BR_Procedure_RadioWWDS_3_Tfbr_procedureid = AV21TFBR_ProcedureID;
         AV51BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to = AV22TFBR_ProcedureID_To;
         AV52BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc = AV25TFBR_Procedure_Radio_Loc;
         AV53BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel = AV26TFBR_Procedure_Radio_Loc_Sel;
         AV54BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount = AV29TFBR_Procedure_Radio_Amount;
         AV55BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel = AV43TFBR_Procedure_Radio_Amount_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Procedure_RadioID, AV18TFBR_Procedure_RadioID_To, AV21TFBR_ProcedureID, AV22TFBR_ProcedureID_To, AV25TFBR_Procedure_Radio_Loc, AV26TFBR_Procedure_Radio_Loc_Sel, AV29TFBR_Procedure_Radio_Amount, AV43TFBR_Procedure_Radio_Amount_Sel, AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace, AV23ddo_BR_ProcedureIDTitleControlIdToReplace, AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace, AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace, AV59Pgmname, AV39IsAuthorized_Update, AV41IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP680( )
      {
         /* Before Start, stand alone formulas. */
         AV59Pgmname = "BR_Procedure_RadioWW";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E18682 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV32DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PROCEDURE_RADIOIDTITLEFILTERDATA"), AV16BR_Procedure_RadioIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PROCEDUREIDTITLEFILTERDATA"), AV20BR_ProcedureIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PROCEDURE_RADIO_LOCTITLEFILTERDATA"), AV24BR_Procedure_Radio_LocTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PROCEDURE_RADIO_AMOUNTTITLEFILTERDATA"), AV28BR_Procedure_Radio_AmountTitleFilterData);
            /* Read variables values. */
            AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace = cgiGet( edtavDdo_br_procedure_radioidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace", AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace);
            AV23ddo_BR_ProcedureIDTitleControlIdToReplace = cgiGet( edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_ProcedureIDTitleControlIdToReplace", AV23ddo_BR_ProcedureIDTitleControlIdToReplace);
            AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace = cgiGet( edtavDdo_br_procedure_radio_loctitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace", AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace);
            AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace = cgiGet( edtavDdo_br_procedure_radio_amounttitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace", AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace);
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
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_procedure_radioid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_procedure_radioid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PROCEDURE_RADIOID");
               GX_FocusControl = edtavTfbr_procedure_radioid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV17TFBR_Procedure_RadioID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Procedure_RadioID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Procedure_RadioID), 18, 0)));
            }
            else
            {
               AV17TFBR_Procedure_RadioID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_procedure_radioid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Procedure_RadioID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Procedure_RadioID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_procedure_radioid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_procedure_radioid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PROCEDURE_RADIOID_TO");
               GX_FocusControl = edtavTfbr_procedure_radioid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV18TFBR_Procedure_RadioID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Procedure_RadioID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Procedure_RadioID_To), 18, 0)));
            }
            else
            {
               AV18TFBR_Procedure_RadioID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_procedure_radioid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Procedure_RadioID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Procedure_RadioID_To), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_procedureid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_procedureid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PROCEDUREID");
               GX_FocusControl = edtavTfbr_procedureid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV21TFBR_ProcedureID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_ProcedureID), 18, 0)));
            }
            else
            {
               AV21TFBR_ProcedureID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_procedureid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_ProcedureID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_procedureid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_procedureid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PROCEDUREID_TO");
               GX_FocusControl = edtavTfbr_procedureid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV22TFBR_ProcedureID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_ProcedureID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_ProcedureID_To), 18, 0)));
            }
            else
            {
               AV22TFBR_ProcedureID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_procedureid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_ProcedureID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_ProcedureID_To), 18, 0)));
            }
            AV25TFBR_Procedure_Radio_Loc = cgiGet( edtavTfbr_procedure_radio_loc_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_Procedure_Radio_Loc", AV25TFBR_Procedure_Radio_Loc);
            AV26TFBR_Procedure_Radio_Loc_Sel = cgiGet( edtavTfbr_procedure_radio_loc_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_Procedure_Radio_Loc_Sel", AV26TFBR_Procedure_Radio_Loc_Sel);
            AV29TFBR_Procedure_Radio_Amount = cgiGet( edtavTfbr_procedure_radio_amount_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_Procedure_Radio_Amount", AV29TFBR_Procedure_Radio_Amount);
            AV43TFBR_Procedure_Radio_Amount_Sel = cgiGet( edtavTfbr_procedure_radio_amount_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43TFBR_Procedure_Radio_Amount_Sel", AV43TFBR_Procedure_Radio_Amount_Sel);
            /* Read saved values. */
            nRC_GXsfl_31 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_31"), ".", ","));
            AV34GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV36GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV35GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_procedure_radioid_Caption = cgiGet( "DDO_BR_PROCEDURE_RADIOID_Caption");
            Ddo_br_procedure_radioid_Tooltip = cgiGet( "DDO_BR_PROCEDURE_RADIOID_Tooltip");
            Ddo_br_procedure_radioid_Cls = cgiGet( "DDO_BR_PROCEDURE_RADIOID_Cls");
            Ddo_br_procedure_radioid_Filteredtext_set = cgiGet( "DDO_BR_PROCEDURE_RADIOID_Filteredtext_set");
            Ddo_br_procedure_radioid_Filteredtextto_set = cgiGet( "DDO_BR_PROCEDURE_RADIOID_Filteredtextto_set");
            Ddo_br_procedure_radioid_Dropdownoptionstype = cgiGet( "DDO_BR_PROCEDURE_RADIOID_Dropdownoptionstype");
            Ddo_br_procedure_radioid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PROCEDURE_RADIOID_Titlecontrolidtoreplace");
            Ddo_br_procedure_radioid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIOID_Includesortasc"));
            Ddo_br_procedure_radioid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIOID_Includesortdsc"));
            Ddo_br_procedure_radioid_Sortedstatus = cgiGet( "DDO_BR_PROCEDURE_RADIOID_Sortedstatus");
            Ddo_br_procedure_radioid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIOID_Includefilter"));
            Ddo_br_procedure_radioid_Filtertype = cgiGet( "DDO_BR_PROCEDURE_RADIOID_Filtertype");
            Ddo_br_procedure_radioid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIOID_Filterisrange"));
            Ddo_br_procedure_radioid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIOID_Includedatalist"));
            Ddo_br_procedure_radioid_Sortasc = cgiGet( "DDO_BR_PROCEDURE_RADIOID_Sortasc");
            Ddo_br_procedure_radioid_Sortdsc = cgiGet( "DDO_BR_PROCEDURE_RADIOID_Sortdsc");
            Ddo_br_procedure_radioid_Cleanfilter = cgiGet( "DDO_BR_PROCEDURE_RADIOID_Cleanfilter");
            Ddo_br_procedure_radioid_Rangefilterfrom = cgiGet( "DDO_BR_PROCEDURE_RADIOID_Rangefilterfrom");
            Ddo_br_procedure_radioid_Rangefilterto = cgiGet( "DDO_BR_PROCEDURE_RADIOID_Rangefilterto");
            Ddo_br_procedure_radioid_Searchbuttontext = cgiGet( "DDO_BR_PROCEDURE_RADIOID_Searchbuttontext");
            Ddo_br_procedureid_Caption = cgiGet( "DDO_BR_PROCEDUREID_Caption");
            Ddo_br_procedureid_Tooltip = cgiGet( "DDO_BR_PROCEDUREID_Tooltip");
            Ddo_br_procedureid_Cls = cgiGet( "DDO_BR_PROCEDUREID_Cls");
            Ddo_br_procedureid_Filteredtext_set = cgiGet( "DDO_BR_PROCEDUREID_Filteredtext_set");
            Ddo_br_procedureid_Filteredtextto_set = cgiGet( "DDO_BR_PROCEDUREID_Filteredtextto_set");
            Ddo_br_procedureid_Dropdownoptionstype = cgiGet( "DDO_BR_PROCEDUREID_Dropdownoptionstype");
            Ddo_br_procedureid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PROCEDUREID_Titlecontrolidtoreplace");
            Ddo_br_procedureid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDUREID_Includesortasc"));
            Ddo_br_procedureid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDUREID_Includesortdsc"));
            Ddo_br_procedureid_Sortedstatus = cgiGet( "DDO_BR_PROCEDUREID_Sortedstatus");
            Ddo_br_procedureid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDUREID_Includefilter"));
            Ddo_br_procedureid_Filtertype = cgiGet( "DDO_BR_PROCEDUREID_Filtertype");
            Ddo_br_procedureid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDUREID_Filterisrange"));
            Ddo_br_procedureid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDUREID_Includedatalist"));
            Ddo_br_procedureid_Sortasc = cgiGet( "DDO_BR_PROCEDUREID_Sortasc");
            Ddo_br_procedureid_Sortdsc = cgiGet( "DDO_BR_PROCEDUREID_Sortdsc");
            Ddo_br_procedureid_Cleanfilter = cgiGet( "DDO_BR_PROCEDUREID_Cleanfilter");
            Ddo_br_procedureid_Rangefilterfrom = cgiGet( "DDO_BR_PROCEDUREID_Rangefilterfrom");
            Ddo_br_procedureid_Rangefilterto = cgiGet( "DDO_BR_PROCEDUREID_Rangefilterto");
            Ddo_br_procedureid_Searchbuttontext = cgiGet( "DDO_BR_PROCEDUREID_Searchbuttontext");
            Ddo_br_procedure_radio_loc_Caption = cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Caption");
            Ddo_br_procedure_radio_loc_Tooltip = cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Tooltip");
            Ddo_br_procedure_radio_loc_Cls = cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Cls");
            Ddo_br_procedure_radio_loc_Filteredtext_set = cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Filteredtext_set");
            Ddo_br_procedure_radio_loc_Selectedvalue_set = cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Selectedvalue_set");
            Ddo_br_procedure_radio_loc_Dropdownoptionstype = cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Dropdownoptionstype");
            Ddo_br_procedure_radio_loc_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Titlecontrolidtoreplace");
            Ddo_br_procedure_radio_loc_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Includesortasc"));
            Ddo_br_procedure_radio_loc_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Includesortdsc"));
            Ddo_br_procedure_radio_loc_Sortedstatus = cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Sortedstatus");
            Ddo_br_procedure_radio_loc_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Includefilter"));
            Ddo_br_procedure_radio_loc_Filtertype = cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Filtertype");
            Ddo_br_procedure_radio_loc_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Filterisrange"));
            Ddo_br_procedure_radio_loc_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Includedatalist"));
            Ddo_br_procedure_radio_loc_Datalisttype = cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Datalisttype");
            Ddo_br_procedure_radio_loc_Datalistproc = cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Datalistproc");
            Ddo_br_procedure_radio_loc_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_procedure_radio_loc_Sortasc = cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Sortasc");
            Ddo_br_procedure_radio_loc_Sortdsc = cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Sortdsc");
            Ddo_br_procedure_radio_loc_Loadingdata = cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Loadingdata");
            Ddo_br_procedure_radio_loc_Cleanfilter = cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Cleanfilter");
            Ddo_br_procedure_radio_loc_Noresultsfound = cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Noresultsfound");
            Ddo_br_procedure_radio_loc_Searchbuttontext = cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Searchbuttontext");
            Ddo_br_procedure_radio_amount_Caption = cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Caption");
            Ddo_br_procedure_radio_amount_Tooltip = cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Tooltip");
            Ddo_br_procedure_radio_amount_Cls = cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Cls");
            Ddo_br_procedure_radio_amount_Filteredtext_set = cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Filteredtext_set");
            Ddo_br_procedure_radio_amount_Selectedvalue_set = cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Selectedvalue_set");
            Ddo_br_procedure_radio_amount_Dropdownoptionstype = cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Dropdownoptionstype");
            Ddo_br_procedure_radio_amount_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Titlecontrolidtoreplace");
            Ddo_br_procedure_radio_amount_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Includesortasc"));
            Ddo_br_procedure_radio_amount_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Includesortdsc"));
            Ddo_br_procedure_radio_amount_Sortedstatus = cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Sortedstatus");
            Ddo_br_procedure_radio_amount_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Includefilter"));
            Ddo_br_procedure_radio_amount_Filtertype = cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Filtertype");
            Ddo_br_procedure_radio_amount_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Filterisrange"));
            Ddo_br_procedure_radio_amount_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Includedatalist"));
            Ddo_br_procedure_radio_amount_Datalisttype = cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Datalisttype");
            Ddo_br_procedure_radio_amount_Datalistproc = cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Datalistproc");
            Ddo_br_procedure_radio_amount_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_procedure_radio_amount_Sortasc = cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Sortasc");
            Ddo_br_procedure_radio_amount_Sortdsc = cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Sortdsc");
            Ddo_br_procedure_radio_amount_Loadingdata = cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Loadingdata");
            Ddo_br_procedure_radio_amount_Cleanfilter = cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Cleanfilter");
            Ddo_br_procedure_radio_amount_Noresultsfound = cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Noresultsfound");
            Ddo_br_procedure_radio_amount_Searchbuttontext = cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_procedure_radioid_Activeeventkey = cgiGet( "DDO_BR_PROCEDURE_RADIOID_Activeeventkey");
            Ddo_br_procedure_radioid_Filteredtext_get = cgiGet( "DDO_BR_PROCEDURE_RADIOID_Filteredtext_get");
            Ddo_br_procedure_radioid_Filteredtextto_get = cgiGet( "DDO_BR_PROCEDURE_RADIOID_Filteredtextto_get");
            Ddo_br_procedureid_Activeeventkey = cgiGet( "DDO_BR_PROCEDUREID_Activeeventkey");
            Ddo_br_procedureid_Filteredtext_get = cgiGet( "DDO_BR_PROCEDUREID_Filteredtext_get");
            Ddo_br_procedureid_Filteredtextto_get = cgiGet( "DDO_BR_PROCEDUREID_Filteredtextto_get");
            Ddo_br_procedure_radio_loc_Activeeventkey = cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Activeeventkey");
            Ddo_br_procedure_radio_loc_Filteredtext_get = cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Filteredtext_get");
            Ddo_br_procedure_radio_loc_Selectedvalue_get = cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Selectedvalue_get");
            Ddo_br_procedure_radio_amount_Activeeventkey = cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Activeeventkey");
            Ddo_br_procedure_radio_amount_Filteredtext_get = cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Filteredtext_get");
            Ddo_br_procedure_radio_amount_Selectedvalue_get = cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Selectedvalue_get");
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
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PROCEDURE_RADIOID"), ".", ",") != Convert.ToDecimal( AV17TFBR_Procedure_RadioID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PROCEDURE_RADIOID_TO"), ".", ",") != Convert.ToDecimal( AV18TFBR_Procedure_RadioID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PROCEDUREID"), ".", ",") != Convert.ToDecimal( AV21TFBR_ProcedureID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PROCEDUREID_TO"), ".", ",") != Convert.ToDecimal( AV22TFBR_ProcedureID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PROCEDURE_RADIO_LOC"), AV25TFBR_Procedure_Radio_Loc) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PROCEDURE_RADIO_LOC_SEL"), AV26TFBR_Procedure_Radio_Loc_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PROCEDURE_RADIO_AMOUNT"), AV29TFBR_Procedure_Radio_Amount) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PROCEDURE_RADIO_AMOUNT_SEL"), AV43TFBR_Procedure_Radio_Amount_Sel) != 0 )
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
         E18682 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E18682( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         edtavTfbr_procedure_radioid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_procedure_radioid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_procedure_radioid_Visible), 5, 0)), true);
         edtavTfbr_procedure_radioid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_procedure_radioid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_procedure_radioid_to_Visible), 5, 0)), true);
         edtavTfbr_procedureid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_procedureid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_procedureid_Visible), 5, 0)), true);
         edtavTfbr_procedureid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_procedureid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_procedureid_to_Visible), 5, 0)), true);
         edtavTfbr_procedure_radio_loc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_procedure_radio_loc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_procedure_radio_loc_Visible), 5, 0)), true);
         edtavTfbr_procedure_radio_loc_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_procedure_radio_loc_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_procedure_radio_loc_sel_Visible), 5, 0)), true);
         edtavTfbr_procedure_radio_amount_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_procedure_radio_amount_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_procedure_radio_amount_Visible), 5, 0)), true);
         edtavTfbr_procedure_radio_amount_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_procedure_radio_amount_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_procedure_radio_amount_sel_Visible), 5, 0)), true);
         Ddo_br_procedure_radioid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Procedure_RadioID";
         ucDdo_br_procedure_radioid.SendProperty(context, "", false, Ddo_br_procedure_radioid_Internalname, "TitleControlIdToReplace", Ddo_br_procedure_radioid_Titlecontrolidtoreplace);
         AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace = Ddo_br_procedure_radioid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace", AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace);
         edtavDdo_br_procedure_radioidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_procedure_radioidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedure_radioidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_procedureid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_ProcedureID";
         ucDdo_br_procedureid.SendProperty(context, "", false, Ddo_br_procedureid_Internalname, "TitleControlIdToReplace", Ddo_br_procedureid_Titlecontrolidtoreplace);
         AV23ddo_BR_ProcedureIDTitleControlIdToReplace = Ddo_br_procedureid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_ProcedureIDTitleControlIdToReplace", AV23ddo_BR_ProcedureIDTitleControlIdToReplace);
         edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_procedure_radio_loc_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Procedure_Radio_Loc";
         ucDdo_br_procedure_radio_loc.SendProperty(context, "", false, Ddo_br_procedure_radio_loc_Internalname, "TitleControlIdToReplace", Ddo_br_procedure_radio_loc_Titlecontrolidtoreplace);
         AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace = Ddo_br_procedure_radio_loc_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace", AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace);
         edtavDdo_br_procedure_radio_loctitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_procedure_radio_loctitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedure_radio_loctitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_procedure_radio_amount_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Procedure_Radio_Amount";
         ucDdo_br_procedure_radio_amount.SendProperty(context, "", false, Ddo_br_procedure_radio_amount_Internalname, "TitleControlIdToReplace", Ddo_br_procedure_radio_amount_Titlecontrolidtoreplace);
         AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace = Ddo_br_procedure_radio_amount_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace", AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace);
         edtavDdo_br_procedure_radio_amounttitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_procedure_radio_amounttitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedure_radio_amounttitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " 诊疗处理化疗信息";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV32DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV32DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E19682( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV16BR_Procedure_RadioIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_ProcedureIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_Procedure_Radio_LocTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28BR_Procedure_Radio_AmountTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
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
         edtBR_Procedure_RadioID_Titleformat = 2;
         edtBR_Procedure_RadioID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "主键", AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Procedure_RadioID_Internalname, "Title", edtBR_Procedure_RadioID_Title, !bGXsfl_31_Refreshing);
         edtBR_ProcedureID_Titleformat = 2;
         edtBR_ProcedureID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "诊疗处理主键", AV23ddo_BR_ProcedureIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_ProcedureID_Internalname, "Title", edtBR_ProcedureID_Title, !bGXsfl_31_Refreshing);
         edtBR_Procedure_Radio_Loc_Titleformat = 2;
         edtBR_Procedure_Radio_Loc_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "放疗部位", AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Procedure_Radio_Loc_Internalname, "Title", edtBR_Procedure_Radio_Loc_Title, !bGXsfl_31_Refreshing);
         edtBR_Procedure_Radio_Amount_Titleformat = 2;
         edtBR_Procedure_Radio_Amount_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "放疗计量", AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Procedure_Radio_Amount_Internalname, "Title", edtBR_Procedure_Radio_Amount_Title, !bGXsfl_31_Refreshing);
         AV34GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34GridCurrentPage), 10, 0)));
         AV35GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV35GridPageSize), 10, 0)));
         AV36GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV36GridRecordCount), 10, 0)));
         AV48BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid = AV17TFBR_Procedure_RadioID;
         AV49BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to = AV18TFBR_Procedure_RadioID_To;
         AV50BR_Procedure_RadioWWDS_3_Tfbr_procedureid = AV21TFBR_ProcedureID;
         AV51BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to = AV22TFBR_ProcedureID_To;
         AV52BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc = AV25TFBR_Procedure_Radio_Loc;
         AV53BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel = AV26TFBR_Procedure_Radio_Loc_Sel;
         AV54BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount = AV29TFBR_Procedure_Radio_Amount;
         AV55BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel = AV43TFBR_Procedure_Radio_Amount_Sel;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Procedure_RadioIDTitleFilterData", AV16BR_Procedure_RadioIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_ProcedureIDTitleFilterData", AV20BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Procedure_Radio_LocTitleFilterData", AV24BR_Procedure_Radio_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Procedure_Radio_AmountTitleFilterData", AV28BR_Procedure_Radio_AmountTitleFilterData);
      }

      protected void E11682( )
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
            AV33PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV33PageToGo) ;
         }
      }

      protected void E12682( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E13682( )
      {
         /* Ddo_br_procedure_radioid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedure_radioid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_procedure_radioid_Sortedstatus = "ASC";
            ucDdo_br_procedure_radioid.SendProperty(context, "", false, Ddo_br_procedure_radioid_Internalname, "SortedStatus", Ddo_br_procedure_radioid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_radioid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_procedure_radioid_Sortedstatus = "DSC";
            ucDdo_br_procedure_radioid.SendProperty(context, "", false, Ddo_br_procedure_radioid_Internalname, "SortedStatus", Ddo_br_procedure_radioid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_radioid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV17TFBR_Procedure_RadioID = (long)(NumberUtil.Val( Ddo_br_procedure_radioid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Procedure_RadioID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Procedure_RadioID), 18, 0)));
            AV18TFBR_Procedure_RadioID_To = (long)(NumberUtil.Val( Ddo_br_procedure_radioid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Procedure_RadioID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Procedure_RadioID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Procedure_RadioIDTitleFilterData", AV16BR_Procedure_RadioIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_ProcedureIDTitleFilterData", AV20BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Procedure_Radio_LocTitleFilterData", AV24BR_Procedure_Radio_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Procedure_Radio_AmountTitleFilterData", AV28BR_Procedure_Radio_AmountTitleFilterData);
      }

      protected void E14682( )
      {
         /* Ddo_br_procedureid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedureid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_procedureid_Sortedstatus = "ASC";
            ucDdo_br_procedureid.SendProperty(context, "", false, Ddo_br_procedureid_Internalname, "SortedStatus", Ddo_br_procedureid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedureid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_procedureid_Sortedstatus = "DSC";
            ucDdo_br_procedureid.SendProperty(context, "", false, Ddo_br_procedureid_Internalname, "SortedStatus", Ddo_br_procedureid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedureid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV21TFBR_ProcedureID = (long)(NumberUtil.Val( Ddo_br_procedureid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_ProcedureID), 18, 0)));
            AV22TFBR_ProcedureID_To = (long)(NumberUtil.Val( Ddo_br_procedureid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_ProcedureID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_ProcedureID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Procedure_RadioIDTitleFilterData", AV16BR_Procedure_RadioIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_ProcedureIDTitleFilterData", AV20BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Procedure_Radio_LocTitleFilterData", AV24BR_Procedure_Radio_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Procedure_Radio_AmountTitleFilterData", AV28BR_Procedure_Radio_AmountTitleFilterData);
      }

      protected void E15682( )
      {
         /* Ddo_br_procedure_radio_loc_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedure_radio_loc_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_procedure_radio_loc_Sortedstatus = "ASC";
            ucDdo_br_procedure_radio_loc.SendProperty(context, "", false, Ddo_br_procedure_radio_loc_Internalname, "SortedStatus", Ddo_br_procedure_radio_loc_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_radio_loc_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_procedure_radio_loc_Sortedstatus = "DSC";
            ucDdo_br_procedure_radio_loc.SendProperty(context, "", false, Ddo_br_procedure_radio_loc_Internalname, "SortedStatus", Ddo_br_procedure_radio_loc_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_radio_loc_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV25TFBR_Procedure_Radio_Loc = Ddo_br_procedure_radio_loc_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_Procedure_Radio_Loc", AV25TFBR_Procedure_Radio_Loc);
            AV26TFBR_Procedure_Radio_Loc_Sel = Ddo_br_procedure_radio_loc_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_Procedure_Radio_Loc_Sel", AV26TFBR_Procedure_Radio_Loc_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Procedure_RadioIDTitleFilterData", AV16BR_Procedure_RadioIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_ProcedureIDTitleFilterData", AV20BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Procedure_Radio_LocTitleFilterData", AV24BR_Procedure_Radio_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Procedure_Radio_AmountTitleFilterData", AV28BR_Procedure_Radio_AmountTitleFilterData);
      }

      protected void E16682( )
      {
         /* Ddo_br_procedure_radio_amount_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedure_radio_amount_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_procedure_radio_amount_Sortedstatus = "ASC";
            ucDdo_br_procedure_radio_amount.SendProperty(context, "", false, Ddo_br_procedure_radio_amount_Internalname, "SortedStatus", Ddo_br_procedure_radio_amount_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_radio_amount_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_procedure_radio_amount_Sortedstatus = "DSC";
            ucDdo_br_procedure_radio_amount.SendProperty(context, "", false, Ddo_br_procedure_radio_amount_Internalname, "SortedStatus", Ddo_br_procedure_radio_amount_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_radio_amount_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV29TFBR_Procedure_Radio_Amount = Ddo_br_procedure_radio_amount_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_Procedure_Radio_Amount", AV29TFBR_Procedure_Radio_Amount);
            AV43TFBR_Procedure_Radio_Amount_Sel = Ddo_br_procedure_radio_amount_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43TFBR_Procedure_Radio_Amount_Sel", AV43TFBR_Procedure_Radio_Amount_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Procedure_RadioIDTitleFilterData", AV16BR_Procedure_RadioIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_ProcedureIDTitleFilterData", AV20BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Procedure_Radio_LocTitleFilterData", AV24BR_Procedure_Radio_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Procedure_Radio_AmountTitleFilterData", AV28BR_Procedure_Radio_AmountTitleFilterData);
      }

      private void E20682( )
      {
         /* Grid_Load Routine */
         AV37Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDisplay_Internalname, AV37Display);
         AV56Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = formatLink("br_procedure_radioview.aspx") + "?" + UrlEncode("" +A323BR_Procedure_RadioID) + "," + UrlEncode(StringUtil.RTrim(""));
         AV38Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV38Update);
         AV57Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavUpdate_Tooltiptext = "修改";
         if ( AV39IsAuthorized_Update )
         {
            edtavUpdate_Link = formatLink("br_procedure_radio.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A323BR_Procedure_RadioID);
         }
         AV40Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV40Delete);
         AV58Delete_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavDelete_Tooltiptext = "删除";
         if ( AV41IsAuthorized_Delete )
         {
            edtavDelete_Link = formatLink("br_procedure_radio.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A323BR_Procedure_RadioID);
         }
         edtBR_Procedure_Radio_Loc_Link = formatLink("br_procedure_radioview.aspx") + "?" + UrlEncode("" +A323BR_Procedure_RadioID) + "," + UrlEncode(StringUtil.RTrim(""));
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

      protected void E17682( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("br_procedure_radio.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S162( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_br_procedure_radioid_Sortedstatus = "";
         ucDdo_br_procedure_radioid.SendProperty(context, "", false, Ddo_br_procedure_radioid_Internalname, "SortedStatus", Ddo_br_procedure_radioid_Sortedstatus);
         Ddo_br_procedureid_Sortedstatus = "";
         ucDdo_br_procedureid.SendProperty(context, "", false, Ddo_br_procedureid_Internalname, "SortedStatus", Ddo_br_procedureid_Sortedstatus);
         Ddo_br_procedure_radio_loc_Sortedstatus = "";
         ucDdo_br_procedure_radio_loc.SendProperty(context, "", false, Ddo_br_procedure_radio_loc_Internalname, "SortedStatus", Ddo_br_procedure_radio_loc_Sortedstatus);
         Ddo_br_procedure_radio_amount_Sortedstatus = "";
         ucDdo_br_procedure_radio_amount.SendProperty(context, "", false, Ddo_br_procedure_radio_amount_Internalname, "SortedStatus", Ddo_br_procedure_radio_amount_Sortedstatus);
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
            Ddo_br_procedure_radioid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_procedure_radioid.SendProperty(context, "", false, Ddo_br_procedure_radioid_Internalname, "SortedStatus", Ddo_br_procedure_radioid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 2 )
         {
            Ddo_br_procedureid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_procedureid.SendProperty(context, "", false, Ddo_br_procedureid_Internalname, "SortedStatus", Ddo_br_procedureid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 3 )
         {
            Ddo_br_procedure_radio_loc_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_procedure_radio_loc.SendProperty(context, "", false, Ddo_br_procedure_radio_loc_Internalname, "SortedStatus", Ddo_br_procedure_radio_loc_Sortedstatus);
         }
         else if ( AV13OrderedBy == 4 )
         {
            Ddo_br_procedure_radio_amount_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_procedure_radio_amount.SendProperty(context, "", false, Ddo_br_procedure_radio_amount_Internalname, "SortedStatus", Ddo_br_procedure_radio_amount_Sortedstatus);
         }
      }

      protected void S142( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean2 = AV39IsAuthorized_Update;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Procedure_Radio", out  GXt_boolean2) ;
         AV39IsAuthorized_Update = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39IsAuthorized_Update", AV39IsAuthorized_Update);
         if ( ! ( AV39IsAuthorized_Update ) )
         {
            edtavUpdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_31_Refreshing);
         }
         GXt_boolean2 = AV41IsAuthorized_Delete;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Procedure_Radio", out  GXt_boolean2) ;
         AV41IsAuthorized_Delete = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41IsAuthorized_Delete", AV41IsAuthorized_Delete);
         if ( ! ( AV41IsAuthorized_Delete ) )
         {
            edtavDelete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Visible), 5, 0)), !bGXsfl_31_Refreshing);
         }
         GXt_boolean2 = AV42TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Procedure_Radio", out  GXt_boolean2) ;
         AV42TempBoolean = GXt_boolean2;
         if ( ! ( AV42TempBoolean ) )
         {
            bttBtninsert_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtninsert_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtninsert_Visible), 5, 0)), true);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV15Session.Get(AV59Pgmname+"GridState"), "") == 0 )
         {
            AV11GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV59Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV11GridState.FromXml(AV15Session.Get(AV59Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
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
         AV60GXV1 = 1;
         while ( AV60GXV1 <= AV11GridState.gxTpr_Filtervalues.Count )
         {
            AV12GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV11GridState.gxTpr_Filtervalues.Item(AV60GXV1));
            if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_RADIOID") == 0 )
            {
               AV17TFBR_Procedure_RadioID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Procedure_RadioID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Procedure_RadioID), 18, 0)));
               AV18TFBR_Procedure_RadioID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Procedure_RadioID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Procedure_RadioID_To), 18, 0)));
               if ( ! (0==AV17TFBR_Procedure_RadioID) )
               {
                  Ddo_br_procedure_radioid_Filteredtext_set = StringUtil.Str( (decimal)(AV17TFBR_Procedure_RadioID), 18, 0);
                  ucDdo_br_procedure_radioid.SendProperty(context, "", false, Ddo_br_procedure_radioid_Internalname, "FilteredText_set", Ddo_br_procedure_radioid_Filteredtext_set);
               }
               if ( ! (0==AV18TFBR_Procedure_RadioID_To) )
               {
                  Ddo_br_procedure_radioid_Filteredtextto_set = StringUtil.Str( (decimal)(AV18TFBR_Procedure_RadioID_To), 18, 0);
                  ucDdo_br_procedure_radioid.SendProperty(context, "", false, Ddo_br_procedure_radioid_Internalname, "FilteredTextTo_set", Ddo_br_procedure_radioid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDUREID") == 0 )
            {
               AV21TFBR_ProcedureID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_ProcedureID), 18, 0)));
               AV22TFBR_ProcedureID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_ProcedureID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_ProcedureID_To), 18, 0)));
               if ( ! (0==AV21TFBR_ProcedureID) )
               {
                  Ddo_br_procedureid_Filteredtext_set = StringUtil.Str( (decimal)(AV21TFBR_ProcedureID), 18, 0);
                  ucDdo_br_procedureid.SendProperty(context, "", false, Ddo_br_procedureid_Internalname, "FilteredText_set", Ddo_br_procedureid_Filteredtext_set);
               }
               if ( ! (0==AV22TFBR_ProcedureID_To) )
               {
                  Ddo_br_procedureid_Filteredtextto_set = StringUtil.Str( (decimal)(AV22TFBR_ProcedureID_To), 18, 0);
                  ucDdo_br_procedureid.SendProperty(context, "", false, Ddo_br_procedureid_Internalname, "FilteredTextTo_set", Ddo_br_procedureid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_RADIO_LOC") == 0 )
            {
               AV25TFBR_Procedure_Radio_Loc = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_Procedure_Radio_Loc", AV25TFBR_Procedure_Radio_Loc);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV25TFBR_Procedure_Radio_Loc)) )
               {
                  Ddo_br_procedure_radio_loc_Filteredtext_set = AV25TFBR_Procedure_Radio_Loc;
                  ucDdo_br_procedure_radio_loc.SendProperty(context, "", false, Ddo_br_procedure_radio_loc_Internalname, "FilteredText_set", Ddo_br_procedure_radio_loc_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_RADIO_LOC_SEL") == 0 )
            {
               AV26TFBR_Procedure_Radio_Loc_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_Procedure_Radio_Loc_Sel", AV26TFBR_Procedure_Radio_Loc_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26TFBR_Procedure_Radio_Loc_Sel)) )
               {
                  Ddo_br_procedure_radio_loc_Selectedvalue_set = AV26TFBR_Procedure_Radio_Loc_Sel;
                  ucDdo_br_procedure_radio_loc.SendProperty(context, "", false, Ddo_br_procedure_radio_loc_Internalname, "SelectedValue_set", Ddo_br_procedure_radio_loc_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_RADIO_AMOUNT") == 0 )
            {
               AV29TFBR_Procedure_Radio_Amount = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_Procedure_Radio_Amount", AV29TFBR_Procedure_Radio_Amount);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV29TFBR_Procedure_Radio_Amount)) )
               {
                  Ddo_br_procedure_radio_amount_Filteredtext_set = AV29TFBR_Procedure_Radio_Amount;
                  ucDdo_br_procedure_radio_amount.SendProperty(context, "", false, Ddo_br_procedure_radio_amount_Internalname, "FilteredText_set", Ddo_br_procedure_radio_amount_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_RADIO_AMOUNT_SEL") == 0 )
            {
               AV43TFBR_Procedure_Radio_Amount_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43TFBR_Procedure_Radio_Amount_Sel", AV43TFBR_Procedure_Radio_Amount_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV43TFBR_Procedure_Radio_Amount_Sel)) )
               {
                  Ddo_br_procedure_radio_amount_Selectedvalue_set = AV43TFBR_Procedure_Radio_Amount_Sel;
                  ucDdo_br_procedure_radio_amount.SendProperty(context, "", false, Ddo_br_procedure_radio_amount_Internalname, "SelectedValue_set", Ddo_br_procedure_radio_amount_Selectedvalue_set);
               }
            }
            AV60GXV1 = (int)(AV60GXV1+1);
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
         AV11GridState.FromXml(AV15Session.Get(AV59Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV11GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV11GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV11GridState.gxTpr_Filtervalues.Clear();
         if ( ! ( (0==AV17TFBR_Procedure_RadioID) && (0==AV18TFBR_Procedure_RadioID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PROCEDURE_RADIOID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV17TFBR_Procedure_RadioID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV18TFBR_Procedure_RadioID_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (0==AV21TFBR_ProcedureID) && (0==AV22TFBR_ProcedureID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PROCEDUREID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV21TFBR_ProcedureID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV22TFBR_ProcedureID_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV25TFBR_Procedure_Radio_Loc)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PROCEDURE_RADIO_LOC";
            AV12GridStateFilterValue.gxTpr_Value = AV25TFBR_Procedure_Radio_Loc;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26TFBR_Procedure_Radio_Loc_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PROCEDURE_RADIO_LOC_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV26TFBR_Procedure_Radio_Loc_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV29TFBR_Procedure_Radio_Amount)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PROCEDURE_RADIO_AMOUNT";
            AV12GridStateFilterValue.gxTpr_Value = AV29TFBR_Procedure_Radio_Amount;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV43TFBR_Procedure_Radio_Amount_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PROCEDURE_RADIO_AMOUNT_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV43TFBR_Procedure_Radio_Amount_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         AV11GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV11GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV59Pgmname+"GridState",  AV11GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV59Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Procedure_Radio";
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
         PA682( ) ;
         WS682( ) ;
         WE682( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279454020", true);
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
         context.AddJavascriptSource("br_procedure_radioww.js", "?20202279454021", false);
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

      protected void SubsflControlProps_312( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_31_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_31_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_31_idx;
         edtBR_Procedure_RadioID_Internalname = "BR_PROCEDURE_RADIOID_"+sGXsfl_31_idx;
         edtBR_ProcedureID_Internalname = "BR_PROCEDUREID_"+sGXsfl_31_idx;
         edtBR_Procedure_Radio_Loc_Internalname = "BR_PROCEDURE_RADIO_LOC_"+sGXsfl_31_idx;
         edtBR_Procedure_Radio_Amount_Internalname = "BR_PROCEDURE_RADIO_AMOUNT_"+sGXsfl_31_idx;
      }

      protected void SubsflControlProps_fel_312( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_31_fel_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_31_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_31_fel_idx;
         edtBR_Procedure_RadioID_Internalname = "BR_PROCEDURE_RADIOID_"+sGXsfl_31_fel_idx;
         edtBR_ProcedureID_Internalname = "BR_PROCEDUREID_"+sGXsfl_31_fel_idx;
         edtBR_Procedure_Radio_Loc_Internalname = "BR_PROCEDURE_RADIO_LOC_"+sGXsfl_31_fel_idx;
         edtBR_Procedure_Radio_Amount_Internalname = "BR_PROCEDURE_RADIO_AMOUNT_"+sGXsfl_31_fel_idx;
      }

      protected void sendrow_312( )
      {
         SubsflControlProps_312( ) ;
         WB680( ) ;
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
            AV37Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV37Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV56Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV37Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV37Display)) ? AV56Display_GXI : context.PathToRelativeUrl( AV37Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV37Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV38Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV38Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV57Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV38Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV38Update)) ? AV57Update_GXI : context.PathToRelativeUrl( AV38Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavUpdate_Visible,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV38Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "DeleteAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV40Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV40Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV58Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV40Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV40Delete)) ? AV58Delete_GXI : context.PathToRelativeUrl( AV40Delete));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)edtavDelete_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavDelete_Visible,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV40Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Procedure_RadioID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A323BR_Procedure_RadioID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A323BR_Procedure_RadioID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Procedure_RadioID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_ProcedureID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A139BR_ProcedureID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A139BR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_ProcedureID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Procedure_Radio_Loc_Internalname,(String)A324BR_Procedure_Radio_Loc,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtBR_Procedure_Radio_Loc_Link,(String)"",(String)"",(String)"",(String)edtBR_Procedure_Radio_Loc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Procedure_Radio_Amount_Internalname,(String)A325BR_Procedure_Radio_Amount,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Procedure_Radio_Amount_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes682( ) ;
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
         edtBR_Procedure_RadioID_Internalname = "BR_PROCEDURE_RADIOID";
         edtBR_ProcedureID_Internalname = "BR_PROCEDUREID";
         edtBR_Procedure_Radio_Loc_Internalname = "BR_PROCEDURE_RADIO_LOC";
         edtBR_Procedure_Radio_Amount_Internalname = "BR_PROCEDURE_RADIO_AMOUNT";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_procedure_radioid_Internalname = "DDO_BR_PROCEDURE_RADIOID";
         edtavDdo_br_procedure_radioidtitlecontrolidtoreplace_Internalname = "vDDO_BR_PROCEDURE_RADIOIDTITLECONTROLIDTOREPLACE";
         Ddo_br_procedureid_Internalname = "DDO_BR_PROCEDUREID";
         edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname = "vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE";
         Ddo_br_procedure_radio_loc_Internalname = "DDO_BR_PROCEDURE_RADIO_LOC";
         edtavDdo_br_procedure_radio_loctitlecontrolidtoreplace_Internalname = "vDDO_BR_PROCEDURE_RADIO_LOCTITLECONTROLIDTOREPLACE";
         Ddo_br_procedure_radio_amount_Internalname = "DDO_BR_PROCEDURE_RADIO_AMOUNT";
         edtavDdo_br_procedure_radio_amounttitlecontrolidtoreplace_Internalname = "vDDO_BR_PROCEDURE_RADIO_AMOUNTTITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         edtavTfbr_procedure_radioid_Internalname = "vTFBR_PROCEDURE_RADIOID";
         edtavTfbr_procedure_radioid_to_Internalname = "vTFBR_PROCEDURE_RADIOID_TO";
         edtavTfbr_procedureid_Internalname = "vTFBR_PROCEDUREID";
         edtavTfbr_procedureid_to_Internalname = "vTFBR_PROCEDUREID_TO";
         edtavTfbr_procedure_radio_loc_Internalname = "vTFBR_PROCEDURE_RADIO_LOC";
         edtavTfbr_procedure_radio_loc_sel_Internalname = "vTFBR_PROCEDURE_RADIO_LOC_SEL";
         edtavTfbr_procedure_radio_amount_Internalname = "vTFBR_PROCEDURE_RADIO_AMOUNT";
         edtavTfbr_procedure_radio_amount_sel_Internalname = "vTFBR_PROCEDURE_RADIO_AMOUNT_SEL";
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
         edtBR_Procedure_Radio_Amount_Jsonclick = "";
         edtBR_Procedure_Radio_Loc_Jsonclick = "";
         edtBR_ProcedureID_Jsonclick = "";
         edtBR_Procedure_RadioID_Jsonclick = "";
         edtavTfbr_procedure_radio_amount_sel_Jsonclick = "";
         edtavTfbr_procedure_radio_amount_sel_Visible = 1;
         edtavTfbr_procedure_radio_amount_Jsonclick = "";
         edtavTfbr_procedure_radio_amount_Visible = 1;
         edtavTfbr_procedure_radio_loc_sel_Jsonclick = "";
         edtavTfbr_procedure_radio_loc_sel_Visible = 1;
         edtavTfbr_procedure_radio_loc_Jsonclick = "";
         edtavTfbr_procedure_radio_loc_Visible = 1;
         edtavTfbr_procedureid_to_Jsonclick = "";
         edtavTfbr_procedureid_to_Visible = 1;
         edtavTfbr_procedureid_Jsonclick = "";
         edtavTfbr_procedureid_Visible = 1;
         edtavTfbr_procedure_radioid_to_Jsonclick = "";
         edtavTfbr_procedure_radioid_to_Visible = 1;
         edtavTfbr_procedure_radioid_Jsonclick = "";
         edtavTfbr_procedure_radioid_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_procedure_radio_amounttitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_procedure_radio_loctitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_procedure_radioidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtBR_Procedure_Radio_Loc_Link = "";
         edtavDelete_Tooltiptext = "删除";
         edtavDelete_Link = "";
         edtavUpdate_Tooltiptext = "修改";
         edtavUpdate_Link = "";
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Procedure_Radio_Amount_Titleformat = 0;
         edtBR_Procedure_Radio_Amount_Title = "放疗计量";
         edtBR_Procedure_Radio_Loc_Titleformat = 0;
         edtBR_Procedure_Radio_Loc_Title = "放疗部位";
         edtBR_ProcedureID_Titleformat = 0;
         edtBR_ProcedureID_Title = "诊疗处理主键";
         edtBR_Procedure_RadioID_Titleformat = 0;
         edtBR_Procedure_RadioID_Title = "主键";
         edtavDelete_Visible = -1;
         edtavUpdate_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         bttBtninsert_Visible = 1;
         Ddo_br_procedure_radio_amount_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_procedure_radio_amount_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_procedure_radio_amount_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_procedure_radio_amount_Loadingdata = "WWP_TSLoading";
         Ddo_br_procedure_radio_amount_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_procedure_radio_amount_Sortasc = "WWP_TSSortASC";
         Ddo_br_procedure_radio_amount_Datalistupdateminimumcharacters = 0;
         Ddo_br_procedure_radio_amount_Datalistproc = "BR_Procedure_RadioWWGetFilterData";
         Ddo_br_procedure_radio_amount_Datalisttype = "Dynamic";
         Ddo_br_procedure_radio_amount_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_procedure_radio_amount_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_procedure_radio_amount_Filtertype = "Character";
         Ddo_br_procedure_radio_amount_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_procedure_radio_amount_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_procedure_radio_amount_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_procedure_radio_amount_Titlecontrolidtoreplace = "";
         Ddo_br_procedure_radio_amount_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_procedure_radio_amount_Cls = "ColumnSettings";
         Ddo_br_procedure_radio_amount_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_procedure_radio_amount_Caption = "";
         Ddo_br_procedure_radio_loc_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_procedure_radio_loc_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_procedure_radio_loc_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_procedure_radio_loc_Loadingdata = "WWP_TSLoading";
         Ddo_br_procedure_radio_loc_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_procedure_radio_loc_Sortasc = "WWP_TSSortASC";
         Ddo_br_procedure_radio_loc_Datalistupdateminimumcharacters = 0;
         Ddo_br_procedure_radio_loc_Datalistproc = "BR_Procedure_RadioWWGetFilterData";
         Ddo_br_procedure_radio_loc_Datalisttype = "Dynamic";
         Ddo_br_procedure_radio_loc_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_procedure_radio_loc_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_procedure_radio_loc_Filtertype = "Character";
         Ddo_br_procedure_radio_loc_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_procedure_radio_loc_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_procedure_radio_loc_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_procedure_radio_loc_Titlecontrolidtoreplace = "";
         Ddo_br_procedure_radio_loc_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_procedure_radio_loc_Cls = "ColumnSettings";
         Ddo_br_procedure_radio_loc_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_procedure_radio_loc_Caption = "";
         Ddo_br_procedureid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_procedureid_Rangefilterto = "WWP_TSTo";
         Ddo_br_procedureid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_procedureid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_procedureid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_procedureid_Sortasc = "WWP_TSSortASC";
         Ddo_br_procedureid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_procedureid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_procedureid_Filtertype = "Numeric";
         Ddo_br_procedureid_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_procedureid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_procedureid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_procedureid_Titlecontrolidtoreplace = "";
         Ddo_br_procedureid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_procedureid_Cls = "ColumnSettings";
         Ddo_br_procedureid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_procedureid_Caption = "";
         Ddo_br_procedure_radioid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_procedure_radioid_Rangefilterto = "WWP_TSTo";
         Ddo_br_procedure_radioid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_procedure_radioid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_procedure_radioid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_procedure_radioid_Sortasc = "WWP_TSSortASC";
         Ddo_br_procedure_radioid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_procedure_radioid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_procedure_radioid_Filtertype = "Numeric";
         Ddo_br_procedure_radioid_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_procedure_radioid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_procedure_radioid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_procedure_radioid_Titlecontrolidtoreplace = "";
         Ddo_br_procedure_radioid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_procedure_radioid_Cls = "ColumnSettings";
         Ddo_br_procedure_radioid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_procedure_radioid_Caption = "";
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
         Form.Caption = " 诊疗处理化疗信息";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_AMOUNTTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV17TFBR_Procedure_RadioID',fld:'vTFBR_PROCEDURE_RADIOID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_RadioID_To',fld:'vTFBR_PROCEDURE_RADIOID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Procedure_Radio_Loc',fld:'vTFBR_PROCEDURE_RADIO_LOC',pic:''},{av:'AV26TFBR_Procedure_Radio_Loc_Sel',fld:'vTFBR_PROCEDURE_RADIO_LOC_SEL',pic:''},{av:'AV29TFBR_Procedure_Radio_Amount',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT',pic:''},{av:'AV43TFBR_Procedure_Radio_Amount_Sel',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT_SEL',pic:''},{av:'AV59Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV16BR_Procedure_RadioIDTitleFilterData',fld:'vBR_PROCEDURE_RADIOIDTITLEFILTERDATA',pic:''},{av:'AV20BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Procedure_Radio_LocTitleFilterData',fld:'vBR_PROCEDURE_RADIO_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_Procedure_Radio_AmountTitleFilterData',fld:'vBR_PROCEDURE_RADIO_AMOUNTTITLEFILTERDATA',pic:''},{av:'edtBR_Procedure_RadioID_Titleformat',ctrl:'BR_PROCEDURE_RADIOID',prop:'Titleformat'},{av:'edtBR_Procedure_RadioID_Title',ctrl:'BR_PROCEDURE_RADIOID',prop:'Title'},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_Procedure_Radio_Loc_Titleformat',ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Titleformat'},{av:'edtBR_Procedure_Radio_Loc_Title',ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Title'},{av:'edtBR_Procedure_Radio_Amount_Titleformat',ctrl:'BR_PROCEDURE_RADIO_AMOUNT',prop:'Titleformat'},{av:'edtBR_Procedure_Radio_Amount_Title',ctrl:'BR_PROCEDURE_RADIO_AMOUNT',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E11682',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Procedure_RadioID',fld:'vTFBR_PROCEDURE_RADIOID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_RadioID_To',fld:'vTFBR_PROCEDURE_RADIOID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Procedure_Radio_Loc',fld:'vTFBR_PROCEDURE_RADIO_LOC',pic:''},{av:'AV26TFBR_Procedure_Radio_Loc_Sel',fld:'vTFBR_PROCEDURE_RADIO_LOC_SEL',pic:''},{av:'AV29TFBR_Procedure_Radio_Amount',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT',pic:''},{av:'AV43TFBR_Procedure_Radio_Amount_Sel',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT_SEL',pic:''},{av:'AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_AMOUNTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E12682',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Procedure_RadioID',fld:'vTFBR_PROCEDURE_RADIOID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_RadioID_To',fld:'vTFBR_PROCEDURE_RADIOID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Procedure_Radio_Loc',fld:'vTFBR_PROCEDURE_RADIO_LOC',pic:''},{av:'AV26TFBR_Procedure_Radio_Loc_Sel',fld:'vTFBR_PROCEDURE_RADIO_LOC_SEL',pic:''},{av:'AV29TFBR_Procedure_Radio_Amount',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT',pic:''},{av:'AV43TFBR_Procedure_Radio_Amount_Sel',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT_SEL',pic:''},{av:'AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_AMOUNTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_PROCEDURE_RADIOID.ONOPTIONCLICKED","{handler:'E13682',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Procedure_RadioID',fld:'vTFBR_PROCEDURE_RADIOID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_RadioID_To',fld:'vTFBR_PROCEDURE_RADIOID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Procedure_Radio_Loc',fld:'vTFBR_PROCEDURE_RADIO_LOC',pic:''},{av:'AV26TFBR_Procedure_Radio_Loc_Sel',fld:'vTFBR_PROCEDURE_RADIO_LOC_SEL',pic:''},{av:'AV29TFBR_Procedure_Radio_Amount',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT',pic:''},{av:'AV43TFBR_Procedure_Radio_Amount_Sel',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT_SEL',pic:''},{av:'AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_AMOUNTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_procedure_radioid_Activeeventkey',ctrl:'DDO_BR_PROCEDURE_RADIOID',prop:'ActiveEventKey'},{av:'Ddo_br_procedure_radioid_Filteredtext_get',ctrl:'DDO_BR_PROCEDURE_RADIOID',prop:'FilteredText_get'},{av:'Ddo_br_procedure_radioid_Filteredtextto_get',ctrl:'DDO_BR_PROCEDURE_RADIOID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_PROCEDURE_RADIOID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedure_radioid_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIOID',prop:'SortedStatus'},{av:'AV17TFBR_Procedure_RadioID',fld:'vTFBR_PROCEDURE_RADIOID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_RadioID_To',fld:'vTFBR_PROCEDURE_RADIOID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_procedureid_Sortedstatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'Ddo_br_procedure_radio_loc_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIO_LOC',prop:'SortedStatus'},{av:'Ddo_br_procedure_radio_amount_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIO_AMOUNT',prop:'SortedStatus'},{av:'AV16BR_Procedure_RadioIDTitleFilterData',fld:'vBR_PROCEDURE_RADIOIDTITLEFILTERDATA',pic:''},{av:'AV20BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Procedure_Radio_LocTitleFilterData',fld:'vBR_PROCEDURE_RADIO_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_Procedure_Radio_AmountTitleFilterData',fld:'vBR_PROCEDURE_RADIO_AMOUNTTITLEFILTERDATA',pic:''},{av:'edtBR_Procedure_RadioID_Titleformat',ctrl:'BR_PROCEDURE_RADIOID',prop:'Titleformat'},{av:'edtBR_Procedure_RadioID_Title',ctrl:'BR_PROCEDURE_RADIOID',prop:'Title'},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_Procedure_Radio_Loc_Titleformat',ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Titleformat'},{av:'edtBR_Procedure_Radio_Loc_Title',ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Title'},{av:'edtBR_Procedure_Radio_Amount_Titleformat',ctrl:'BR_PROCEDURE_RADIO_AMOUNT',prop:'Titleformat'},{av:'edtBR_Procedure_Radio_Amount_Title',ctrl:'BR_PROCEDURE_RADIO_AMOUNT',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PROCEDUREID.ONOPTIONCLICKED","{handler:'E14682',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Procedure_RadioID',fld:'vTFBR_PROCEDURE_RADIOID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_RadioID_To',fld:'vTFBR_PROCEDURE_RADIOID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Procedure_Radio_Loc',fld:'vTFBR_PROCEDURE_RADIO_LOC',pic:''},{av:'AV26TFBR_Procedure_Radio_Loc_Sel',fld:'vTFBR_PROCEDURE_RADIO_LOC_SEL',pic:''},{av:'AV29TFBR_Procedure_Radio_Amount',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT',pic:''},{av:'AV43TFBR_Procedure_Radio_Amount_Sel',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT_SEL',pic:''},{av:'AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_AMOUNTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_procedureid_Activeeventkey',ctrl:'DDO_BR_PROCEDUREID',prop:'ActiveEventKey'},{av:'Ddo_br_procedureid_Filteredtext_get',ctrl:'DDO_BR_PROCEDUREID',prop:'FilteredText_get'},{av:'Ddo_br_procedureid_Filteredtextto_get',ctrl:'DDO_BR_PROCEDUREID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_PROCEDUREID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedureid_Sortedstatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_procedure_radioid_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIOID',prop:'SortedStatus'},{av:'Ddo_br_procedure_radio_loc_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIO_LOC',prop:'SortedStatus'},{av:'Ddo_br_procedure_radio_amount_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIO_AMOUNT',prop:'SortedStatus'},{av:'AV16BR_Procedure_RadioIDTitleFilterData',fld:'vBR_PROCEDURE_RADIOIDTITLEFILTERDATA',pic:''},{av:'AV20BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Procedure_Radio_LocTitleFilterData',fld:'vBR_PROCEDURE_RADIO_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_Procedure_Radio_AmountTitleFilterData',fld:'vBR_PROCEDURE_RADIO_AMOUNTTITLEFILTERDATA',pic:''},{av:'edtBR_Procedure_RadioID_Titleformat',ctrl:'BR_PROCEDURE_RADIOID',prop:'Titleformat'},{av:'edtBR_Procedure_RadioID_Title',ctrl:'BR_PROCEDURE_RADIOID',prop:'Title'},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_Procedure_Radio_Loc_Titleformat',ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Titleformat'},{av:'edtBR_Procedure_Radio_Loc_Title',ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Title'},{av:'edtBR_Procedure_Radio_Amount_Titleformat',ctrl:'BR_PROCEDURE_RADIO_AMOUNT',prop:'Titleformat'},{av:'edtBR_Procedure_Radio_Amount_Title',ctrl:'BR_PROCEDURE_RADIO_AMOUNT',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PROCEDURE_RADIO_LOC.ONOPTIONCLICKED","{handler:'E15682',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Procedure_RadioID',fld:'vTFBR_PROCEDURE_RADIOID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_RadioID_To',fld:'vTFBR_PROCEDURE_RADIOID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Procedure_Radio_Loc',fld:'vTFBR_PROCEDURE_RADIO_LOC',pic:''},{av:'AV26TFBR_Procedure_Radio_Loc_Sel',fld:'vTFBR_PROCEDURE_RADIO_LOC_SEL',pic:''},{av:'AV29TFBR_Procedure_Radio_Amount',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT',pic:''},{av:'AV43TFBR_Procedure_Radio_Amount_Sel',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT_SEL',pic:''},{av:'AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_AMOUNTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_procedure_radio_loc_Activeeventkey',ctrl:'DDO_BR_PROCEDURE_RADIO_LOC',prop:'ActiveEventKey'},{av:'Ddo_br_procedure_radio_loc_Filteredtext_get',ctrl:'DDO_BR_PROCEDURE_RADIO_LOC',prop:'FilteredText_get'},{av:'Ddo_br_procedure_radio_loc_Selectedvalue_get',ctrl:'DDO_BR_PROCEDURE_RADIO_LOC',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_PROCEDURE_RADIO_LOC.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedure_radio_loc_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIO_LOC',prop:'SortedStatus'},{av:'AV25TFBR_Procedure_Radio_Loc',fld:'vTFBR_PROCEDURE_RADIO_LOC',pic:''},{av:'AV26TFBR_Procedure_Radio_Loc_Sel',fld:'vTFBR_PROCEDURE_RADIO_LOC_SEL',pic:''},{av:'Ddo_br_procedure_radioid_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIOID',prop:'SortedStatus'},{av:'Ddo_br_procedureid_Sortedstatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'Ddo_br_procedure_radio_amount_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIO_AMOUNT',prop:'SortedStatus'},{av:'AV16BR_Procedure_RadioIDTitleFilterData',fld:'vBR_PROCEDURE_RADIOIDTITLEFILTERDATA',pic:''},{av:'AV20BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Procedure_Radio_LocTitleFilterData',fld:'vBR_PROCEDURE_RADIO_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_Procedure_Radio_AmountTitleFilterData',fld:'vBR_PROCEDURE_RADIO_AMOUNTTITLEFILTERDATA',pic:''},{av:'edtBR_Procedure_RadioID_Titleformat',ctrl:'BR_PROCEDURE_RADIOID',prop:'Titleformat'},{av:'edtBR_Procedure_RadioID_Title',ctrl:'BR_PROCEDURE_RADIOID',prop:'Title'},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_Procedure_Radio_Loc_Titleformat',ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Titleformat'},{av:'edtBR_Procedure_Radio_Loc_Title',ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Title'},{av:'edtBR_Procedure_Radio_Amount_Titleformat',ctrl:'BR_PROCEDURE_RADIO_AMOUNT',prop:'Titleformat'},{av:'edtBR_Procedure_Radio_Amount_Title',ctrl:'BR_PROCEDURE_RADIO_AMOUNT',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PROCEDURE_RADIO_AMOUNT.ONOPTIONCLICKED","{handler:'E16682',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Procedure_RadioID',fld:'vTFBR_PROCEDURE_RADIOID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_RadioID_To',fld:'vTFBR_PROCEDURE_RADIOID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Procedure_Radio_Loc',fld:'vTFBR_PROCEDURE_RADIO_LOC',pic:''},{av:'AV26TFBR_Procedure_Radio_Loc_Sel',fld:'vTFBR_PROCEDURE_RADIO_LOC_SEL',pic:''},{av:'AV29TFBR_Procedure_Radio_Amount',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT',pic:''},{av:'AV43TFBR_Procedure_Radio_Amount_Sel',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT_SEL',pic:''},{av:'AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_AMOUNTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_procedure_radio_amount_Activeeventkey',ctrl:'DDO_BR_PROCEDURE_RADIO_AMOUNT',prop:'ActiveEventKey'},{av:'Ddo_br_procedure_radio_amount_Filteredtext_get',ctrl:'DDO_BR_PROCEDURE_RADIO_AMOUNT',prop:'FilteredText_get'},{av:'Ddo_br_procedure_radio_amount_Selectedvalue_get',ctrl:'DDO_BR_PROCEDURE_RADIO_AMOUNT',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_PROCEDURE_RADIO_AMOUNT.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedure_radio_amount_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIO_AMOUNT',prop:'SortedStatus'},{av:'AV29TFBR_Procedure_Radio_Amount',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT',pic:''},{av:'AV43TFBR_Procedure_Radio_Amount_Sel',fld:'vTFBR_PROCEDURE_RADIO_AMOUNT_SEL',pic:''},{av:'Ddo_br_procedure_radioid_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIOID',prop:'SortedStatus'},{av:'Ddo_br_procedureid_Sortedstatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'Ddo_br_procedure_radio_loc_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIO_LOC',prop:'SortedStatus'},{av:'AV16BR_Procedure_RadioIDTitleFilterData',fld:'vBR_PROCEDURE_RADIOIDTITLEFILTERDATA',pic:''},{av:'AV20BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Procedure_Radio_LocTitleFilterData',fld:'vBR_PROCEDURE_RADIO_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_Procedure_Radio_AmountTitleFilterData',fld:'vBR_PROCEDURE_RADIO_AMOUNTTITLEFILTERDATA',pic:''},{av:'edtBR_Procedure_RadioID_Titleformat',ctrl:'BR_PROCEDURE_RADIOID',prop:'Titleformat'},{av:'edtBR_Procedure_RadioID_Title',ctrl:'BR_PROCEDURE_RADIOID',prop:'Title'},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_Procedure_Radio_Loc_Titleformat',ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Titleformat'},{av:'edtBR_Procedure_Radio_Loc_Title',ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Title'},{av:'edtBR_Procedure_Radio_Amount_Titleformat',ctrl:'BR_PROCEDURE_RADIO_AMOUNT',prop:'Titleformat'},{av:'edtBR_Procedure_Radio_Amount_Title',ctrl:'BR_PROCEDURE_RADIO_AMOUNT',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E20682',iparms:[{av:'A323BR_Procedure_RadioID',fld:'BR_PROCEDURE_RADIOID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV37Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'},{av:'AV38Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV40Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'},{av:'edtBR_Procedure_Radio_Loc_Link',ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E17682',iparms:[{av:'A323BR_Procedure_RadioID',fld:'BR_PROCEDURE_RADIOID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
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
         Ddo_br_procedure_radioid_Activeeventkey = "";
         Ddo_br_procedure_radioid_Filteredtext_get = "";
         Ddo_br_procedure_radioid_Filteredtextto_get = "";
         Ddo_br_procedureid_Activeeventkey = "";
         Ddo_br_procedureid_Filteredtext_get = "";
         Ddo_br_procedureid_Filteredtextto_get = "";
         Ddo_br_procedure_radio_loc_Activeeventkey = "";
         Ddo_br_procedure_radio_loc_Filteredtext_get = "";
         Ddo_br_procedure_radio_loc_Selectedvalue_get = "";
         Ddo_br_procedure_radio_amount_Activeeventkey = "";
         Ddo_br_procedure_radio_amount_Filteredtext_get = "";
         Ddo_br_procedure_radio_amount_Selectedvalue_get = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV25TFBR_Procedure_Radio_Loc = "";
         AV26TFBR_Procedure_Radio_Loc_Sel = "";
         AV29TFBR_Procedure_Radio_Amount = "";
         AV43TFBR_Procedure_Radio_Amount_Sel = "";
         AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace = "";
         AV23ddo_BR_ProcedureIDTitleControlIdToReplace = "";
         AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace = "";
         AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace = "";
         AV59Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV32DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV16BR_Procedure_RadioIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_ProcedureIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_Procedure_Radio_LocTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28BR_Procedure_Radio_AmountTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_procedure_radioid_Filteredtext_set = "";
         Ddo_br_procedure_radioid_Filteredtextto_set = "";
         Ddo_br_procedure_radioid_Sortedstatus = "";
         Ddo_br_procedureid_Filteredtext_set = "";
         Ddo_br_procedureid_Filteredtextto_set = "";
         Ddo_br_procedureid_Sortedstatus = "";
         Ddo_br_procedure_radio_loc_Filteredtext_set = "";
         Ddo_br_procedure_radio_loc_Selectedvalue_set = "";
         Ddo_br_procedure_radio_loc_Sortedstatus = "";
         Ddo_br_procedure_radio_amount_Filteredtext_set = "";
         Ddo_br_procedure_radio_amount_Selectedvalue_set = "";
         Ddo_br_procedure_radio_amount_Sortedstatus = "";
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
         AV37Display = "";
         AV38Update = "";
         AV40Delete = "";
         A324BR_Procedure_Radio_Loc = "";
         A325BR_Procedure_Radio_Amount = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_procedure_radioid = new GXUserControl();
         ucDdo_br_procedureid = new GXUserControl();
         ucDdo_br_procedure_radio_loc = new GXUserControl();
         ucDdo_br_procedure_radio_amount = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV56Display_GXI = "";
         AV57Update_GXI = "";
         AV58Delete_GXI = "";
         scmdbuf = "";
         lV52BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc = "";
         lV54BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount = "";
         AV53BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel = "";
         AV52BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc = "";
         AV55BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel = "";
         AV54BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount = "";
         H00682_A325BR_Procedure_Radio_Amount = new String[] {""} ;
         H00682_n325BR_Procedure_Radio_Amount = new bool[] {false} ;
         H00682_A324BR_Procedure_Radio_Loc = new String[] {""} ;
         H00682_n324BR_Procedure_Radio_Loc = new bool[] {false} ;
         H00682_A139BR_ProcedureID = new long[1] ;
         H00682_A323BR_Procedure_RadioID = new long[1] ;
         H00683_AGRID_nRecordCount = new long[1] ;
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_procedure_radioww__default(),
            new Object[][] {
                new Object[] {
               H00682_A325BR_Procedure_Radio_Amount, H00682_n325BR_Procedure_Radio_Amount, H00682_A324BR_Procedure_Radio_Loc, H00682_n324BR_Procedure_Radio_Loc, H00682_A139BR_ProcedureID, H00682_A323BR_Procedure_RadioID
               }
               , new Object[] {
               H00683_AGRID_nRecordCount
               }
            }
         );
         AV59Pgmname = "BR_Procedure_RadioWW";
         /* GeneXus formulas. */
         AV59Pgmname = "BR_Procedure_RadioWW";
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
      private short edtBR_Procedure_RadioID_Titleformat ;
      private short edtBR_ProcedureID_Titleformat ;
      private short edtBR_Procedure_Radio_Loc_Titleformat ;
      private short edtBR_Procedure_Radio_Amount_Titleformat ;
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
      private int Ddo_br_procedure_radio_loc_Datalistupdateminimumcharacters ;
      private int Ddo_br_procedure_radio_amount_Datalistupdateminimumcharacters ;
      private int bttBtninsert_Visible ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavUpdate_Visible ;
      private int edtavDelete_Visible ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_br_procedure_radioidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_procedure_radio_loctitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_procedure_radio_amounttitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfbr_procedure_radioid_Visible ;
      private int edtavTfbr_procedure_radioid_to_Visible ;
      private int edtavTfbr_procedureid_Visible ;
      private int edtavTfbr_procedureid_to_Visible ;
      private int edtavTfbr_procedure_radio_loc_Visible ;
      private int edtavTfbr_procedure_radio_loc_sel_Visible ;
      private int edtavTfbr_procedure_radio_amount_Visible ;
      private int edtavTfbr_procedure_radio_amount_sel_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV33PageToGo ;
      private int AV60GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV17TFBR_Procedure_RadioID ;
      private long AV18TFBR_Procedure_RadioID_To ;
      private long AV21TFBR_ProcedureID ;
      private long AV22TFBR_ProcedureID_To ;
      private long AV34GridCurrentPage ;
      private long AV36GridRecordCount ;
      private long AV35GridPageSize ;
      private long A323BR_Procedure_RadioID ;
      private long A139BR_ProcedureID ;
      private long GRID_nCurrentRecord ;
      private long AV48BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid ;
      private long AV49BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to ;
      private long AV50BR_Procedure_RadioWWDS_3_Tfbr_procedureid ;
      private long AV51BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_procedure_radioid_Activeeventkey ;
      private String Ddo_br_procedure_radioid_Filteredtext_get ;
      private String Ddo_br_procedure_radioid_Filteredtextto_get ;
      private String Ddo_br_procedureid_Activeeventkey ;
      private String Ddo_br_procedureid_Filteredtext_get ;
      private String Ddo_br_procedureid_Filteredtextto_get ;
      private String Ddo_br_procedure_radio_loc_Activeeventkey ;
      private String Ddo_br_procedure_radio_loc_Filteredtext_get ;
      private String Ddo_br_procedure_radio_loc_Selectedvalue_get ;
      private String Ddo_br_procedure_radio_amount_Activeeventkey ;
      private String Ddo_br_procedure_radio_amount_Filteredtext_get ;
      private String Ddo_br_procedure_radio_amount_Selectedvalue_get ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_31_idx="0001" ;
      private String AV59Pgmname ;
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
      private String Ddo_br_procedure_radioid_Caption ;
      private String Ddo_br_procedure_radioid_Tooltip ;
      private String Ddo_br_procedure_radioid_Cls ;
      private String Ddo_br_procedure_radioid_Filteredtext_set ;
      private String Ddo_br_procedure_radioid_Filteredtextto_set ;
      private String Ddo_br_procedure_radioid_Dropdownoptionstype ;
      private String Ddo_br_procedure_radioid_Titlecontrolidtoreplace ;
      private String Ddo_br_procedure_radioid_Sortedstatus ;
      private String Ddo_br_procedure_radioid_Filtertype ;
      private String Ddo_br_procedure_radioid_Sortasc ;
      private String Ddo_br_procedure_radioid_Sortdsc ;
      private String Ddo_br_procedure_radioid_Cleanfilter ;
      private String Ddo_br_procedure_radioid_Rangefilterfrom ;
      private String Ddo_br_procedure_radioid_Rangefilterto ;
      private String Ddo_br_procedure_radioid_Searchbuttontext ;
      private String Ddo_br_procedureid_Caption ;
      private String Ddo_br_procedureid_Tooltip ;
      private String Ddo_br_procedureid_Cls ;
      private String Ddo_br_procedureid_Filteredtext_set ;
      private String Ddo_br_procedureid_Filteredtextto_set ;
      private String Ddo_br_procedureid_Dropdownoptionstype ;
      private String Ddo_br_procedureid_Titlecontrolidtoreplace ;
      private String Ddo_br_procedureid_Sortedstatus ;
      private String Ddo_br_procedureid_Filtertype ;
      private String Ddo_br_procedureid_Sortasc ;
      private String Ddo_br_procedureid_Sortdsc ;
      private String Ddo_br_procedureid_Cleanfilter ;
      private String Ddo_br_procedureid_Rangefilterfrom ;
      private String Ddo_br_procedureid_Rangefilterto ;
      private String Ddo_br_procedureid_Searchbuttontext ;
      private String Ddo_br_procedure_radio_loc_Caption ;
      private String Ddo_br_procedure_radio_loc_Tooltip ;
      private String Ddo_br_procedure_radio_loc_Cls ;
      private String Ddo_br_procedure_radio_loc_Filteredtext_set ;
      private String Ddo_br_procedure_radio_loc_Selectedvalue_set ;
      private String Ddo_br_procedure_radio_loc_Dropdownoptionstype ;
      private String Ddo_br_procedure_radio_loc_Titlecontrolidtoreplace ;
      private String Ddo_br_procedure_radio_loc_Sortedstatus ;
      private String Ddo_br_procedure_radio_loc_Filtertype ;
      private String Ddo_br_procedure_radio_loc_Datalisttype ;
      private String Ddo_br_procedure_radio_loc_Datalistproc ;
      private String Ddo_br_procedure_radio_loc_Sortasc ;
      private String Ddo_br_procedure_radio_loc_Sortdsc ;
      private String Ddo_br_procedure_radio_loc_Loadingdata ;
      private String Ddo_br_procedure_radio_loc_Cleanfilter ;
      private String Ddo_br_procedure_radio_loc_Noresultsfound ;
      private String Ddo_br_procedure_radio_loc_Searchbuttontext ;
      private String Ddo_br_procedure_radio_amount_Caption ;
      private String Ddo_br_procedure_radio_amount_Tooltip ;
      private String Ddo_br_procedure_radio_amount_Cls ;
      private String Ddo_br_procedure_radio_amount_Filteredtext_set ;
      private String Ddo_br_procedure_radio_amount_Selectedvalue_set ;
      private String Ddo_br_procedure_radio_amount_Dropdownoptionstype ;
      private String Ddo_br_procedure_radio_amount_Titlecontrolidtoreplace ;
      private String Ddo_br_procedure_radio_amount_Sortedstatus ;
      private String Ddo_br_procedure_radio_amount_Filtertype ;
      private String Ddo_br_procedure_radio_amount_Datalisttype ;
      private String Ddo_br_procedure_radio_amount_Datalistproc ;
      private String Ddo_br_procedure_radio_amount_Sortasc ;
      private String Ddo_br_procedure_radio_amount_Sortdsc ;
      private String Ddo_br_procedure_radio_amount_Loadingdata ;
      private String Ddo_br_procedure_radio_amount_Cleanfilter ;
      private String Ddo_br_procedure_radio_amount_Noresultsfound ;
      private String Ddo_br_procedure_radio_amount_Searchbuttontext ;
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
      private String edtBR_Procedure_RadioID_Title ;
      private String edtBR_ProcedureID_Title ;
      private String edtBR_Procedure_Radio_Loc_Title ;
      private String edtBR_Procedure_Radio_Amount_Title ;
      private String subGrid_Header ;
      private String edtavDisplay_Link ;
      private String edtavDisplay_Tooltiptext ;
      private String edtavUpdate_Link ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavDelete_Link ;
      private String edtavDelete_Tooltiptext ;
      private String edtBR_Procedure_Radio_Loc_Link ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_procedure_radioid_Internalname ;
      private String edtavDdo_br_procedure_radioidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_procedureid_Internalname ;
      private String edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_procedure_radio_loc_Internalname ;
      private String edtavDdo_br_procedure_radio_loctitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_procedure_radio_amount_Internalname ;
      private String edtavDdo_br_procedure_radio_amounttitlecontrolidtoreplace_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavTfbr_procedure_radioid_Internalname ;
      private String edtavTfbr_procedure_radioid_Jsonclick ;
      private String edtavTfbr_procedure_radioid_to_Internalname ;
      private String edtavTfbr_procedure_radioid_to_Jsonclick ;
      private String edtavTfbr_procedureid_Internalname ;
      private String edtavTfbr_procedureid_Jsonclick ;
      private String edtavTfbr_procedureid_to_Internalname ;
      private String edtavTfbr_procedureid_to_Jsonclick ;
      private String edtavTfbr_procedure_radio_loc_Internalname ;
      private String edtavTfbr_procedure_radio_loc_Jsonclick ;
      private String edtavTfbr_procedure_radio_loc_sel_Internalname ;
      private String edtavTfbr_procedure_radio_loc_sel_Jsonclick ;
      private String edtavTfbr_procedure_radio_amount_Internalname ;
      private String edtavTfbr_procedure_radio_amount_Jsonclick ;
      private String edtavTfbr_procedure_radio_amount_sel_Internalname ;
      private String edtavTfbr_procedure_radio_amount_sel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDisplay_Internalname ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String edtBR_Procedure_RadioID_Internalname ;
      private String edtBR_ProcedureID_Internalname ;
      private String edtBR_Procedure_Radio_Loc_Internalname ;
      private String edtBR_Procedure_Radio_Amount_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_31_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtBR_Procedure_RadioID_Jsonclick ;
      private String edtBR_ProcedureID_Jsonclick ;
      private String edtBR_Procedure_Radio_Loc_Jsonclick ;
      private String edtBR_Procedure_Radio_Amount_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV14OrderedDsc ;
      private bool AV39IsAuthorized_Update ;
      private bool AV41IsAuthorized_Delete ;
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
      private bool Ddo_br_procedure_radioid_Includesortasc ;
      private bool Ddo_br_procedure_radioid_Includesortdsc ;
      private bool Ddo_br_procedure_radioid_Includefilter ;
      private bool Ddo_br_procedure_radioid_Filterisrange ;
      private bool Ddo_br_procedure_radioid_Includedatalist ;
      private bool Ddo_br_procedureid_Includesortasc ;
      private bool Ddo_br_procedureid_Includesortdsc ;
      private bool Ddo_br_procedureid_Includefilter ;
      private bool Ddo_br_procedureid_Filterisrange ;
      private bool Ddo_br_procedureid_Includedatalist ;
      private bool Ddo_br_procedure_radio_loc_Includesortasc ;
      private bool Ddo_br_procedure_radio_loc_Includesortdsc ;
      private bool Ddo_br_procedure_radio_loc_Includefilter ;
      private bool Ddo_br_procedure_radio_loc_Filterisrange ;
      private bool Ddo_br_procedure_radio_loc_Includedatalist ;
      private bool Ddo_br_procedure_radio_amount_Includesortasc ;
      private bool Ddo_br_procedure_radio_amount_Includesortdsc ;
      private bool Ddo_br_procedure_radio_amount_Includefilter ;
      private bool Ddo_br_procedure_radio_amount_Filterisrange ;
      private bool Ddo_br_procedure_radio_amount_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_31_Refreshing=false ;
      private bool n324BR_Procedure_Radio_Loc ;
      private bool n325BR_Procedure_Radio_Amount ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV42TempBoolean ;
      private bool GXt_boolean2 ;
      private bool AV37Display_IsBlob ;
      private bool AV38Update_IsBlob ;
      private bool AV40Delete_IsBlob ;
      private String AV25TFBR_Procedure_Radio_Loc ;
      private String AV26TFBR_Procedure_Radio_Loc_Sel ;
      private String AV29TFBR_Procedure_Radio_Amount ;
      private String AV43TFBR_Procedure_Radio_Amount_Sel ;
      private String AV19ddo_BR_Procedure_RadioIDTitleControlIdToReplace ;
      private String AV23ddo_BR_ProcedureIDTitleControlIdToReplace ;
      private String AV27ddo_BR_Procedure_Radio_LocTitleControlIdToReplace ;
      private String AV31ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace ;
      private String A324BR_Procedure_Radio_Loc ;
      private String A325BR_Procedure_Radio_Amount ;
      private String AV56Display_GXI ;
      private String AV57Update_GXI ;
      private String AV58Delete_GXI ;
      private String lV52BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc ;
      private String lV54BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount ;
      private String AV53BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel ;
      private String AV52BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc ;
      private String AV55BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel ;
      private String AV54BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount ;
      private String AV37Display ;
      private String AV38Update ;
      private String AV40Delete ;
      private IGxSession AV15Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_procedure_radioid ;
      private GXUserControl ucDdo_br_procedureid ;
      private GXUserControl ucDdo_br_procedure_radio_loc ;
      private GXUserControl ucDdo_br_procedure_radio_amount ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H00682_A325BR_Procedure_Radio_Amount ;
      private bool[] H00682_n325BR_Procedure_Radio_Amount ;
      private String[] H00682_A324BR_Procedure_Radio_Loc ;
      private bool[] H00682_n324BR_Procedure_Radio_Loc ;
      private long[] H00682_A139BR_ProcedureID ;
      private long[] H00682_A323BR_Procedure_RadioID ;
      private long[] H00683_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV16BR_Procedure_RadioIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV20BR_ProcedureIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV24BR_Procedure_Radio_LocTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV28BR_Procedure_Radio_AmountTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV11GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV12GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV32DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class br_procedure_radioww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00682( IGxContext context ,
                                             long AV48BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid ,
                                             long AV49BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to ,
                                             long AV50BR_Procedure_RadioWWDS_3_Tfbr_procedureid ,
                                             long AV51BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to ,
                                             String AV53BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel ,
                                             String AV52BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc ,
                                             String AV55BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel ,
                                             String AV54BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount ,
                                             long A323BR_Procedure_RadioID ,
                                             long A139BR_ProcedureID ,
                                             String A324BR_Procedure_Radio_Loc ,
                                             String A325BR_Procedure_Radio_Amount ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [11] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [BR_Procedure_Radio_Amount], [BR_Procedure_Radio_Loc], [BR_ProcedureID], [BR_Procedure_RadioID]";
         sFromString = " FROM [BR_Procedure_Radio] WITH (NOLOCK)";
         sOrderString = "";
         if ( ! (0==AV48BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_RadioID] >= @AV48BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_RadioID] >= @AV48BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ! (0==AV49BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_RadioID] <= @AV49BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_RadioID] <= @AV49BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to)";
            }
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV50BR_Procedure_RadioWWDS_3_Tfbr_procedureid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_ProcedureID] >= @AV50BR_Procedure_RadioWWDS_3_Tfbr_procedureid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_ProcedureID] >= @AV50BR_Procedure_RadioWWDS_3_Tfbr_procedureid)";
            }
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (0==AV51BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_ProcedureID] <= @AV51BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_ProcedureID] <= @AV51BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to)";
            }
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV53BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV52BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Radio_Loc] like @lV52BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Radio_Loc] like @lV52BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc)";
            }
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV53BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Radio_Loc] = @AV53BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Radio_Loc] = @AV53BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel)";
            }
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV55BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Radio_Amount] like @lV54BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Radio_Amount] like @lV54BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount)";
            }
         }
         else
         {
            GXv_int3[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Radio_Amount] = @AV55BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Radio_Amount] = @AV55BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel)";
            }
         }
         else
         {
            GXv_int3[7] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Procedure_RadioID]";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Procedure_RadioID] DESC";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_ProcedureID]";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_ProcedureID] DESC";
         }
         else if ( ( AV13OrderedBy == 3 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Procedure_Radio_Loc]";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Procedure_Radio_Loc] DESC";
         }
         else if ( ( AV13OrderedBy == 4 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Procedure_Radio_Amount]";
         }
         else if ( ( AV13OrderedBy == 4 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Procedure_Radio_Amount] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Procedure_RadioID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H00683( IGxContext context ,
                                             long AV48BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid ,
                                             long AV49BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to ,
                                             long AV50BR_Procedure_RadioWWDS_3_Tfbr_procedureid ,
                                             long AV51BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to ,
                                             String AV53BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel ,
                                             String AV52BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc ,
                                             String AV55BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel ,
                                             String AV54BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount ,
                                             long A323BR_Procedure_RadioID ,
                                             long A139BR_ProcedureID ,
                                             String A324BR_Procedure_Radio_Loc ,
                                             String A325BR_Procedure_Radio_Amount ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [8] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [BR_Procedure_Radio] WITH (NOLOCK)";
         if ( ! (0==AV48BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_RadioID] >= @AV48BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_RadioID] >= @AV48BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid)";
            }
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ! (0==AV49BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_RadioID] <= @AV49BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_RadioID] <= @AV49BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to)";
            }
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( ! (0==AV50BR_Procedure_RadioWWDS_3_Tfbr_procedureid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_ProcedureID] >= @AV50BR_Procedure_RadioWWDS_3_Tfbr_procedureid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_ProcedureID] >= @AV50BR_Procedure_RadioWWDS_3_Tfbr_procedureid)";
            }
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! (0==AV51BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_ProcedureID] <= @AV51BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_ProcedureID] <= @AV51BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to)";
            }
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV53BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV52BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Radio_Loc] like @lV52BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Radio_Loc] like @lV52BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc)";
            }
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV53BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Radio_Loc] = @AV53BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Radio_Loc] = @AV53BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel)";
            }
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV55BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Radio_Amount] like @lV54BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Radio_Amount] like @lV54BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount)";
            }
         }
         else
         {
            GXv_int5[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Radio_Amount] = @AV55BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Radio_Amount] = @AV55BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel)";
            }
         }
         else
         {
            GXv_int5[7] = 1;
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
                     return conditional_H00682(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (long)dynConstraints[8] , (long)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (short)dynConstraints[12] , (bool)dynConstraints[13] );
               case 1 :
                     return conditional_H00683(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (long)dynConstraints[8] , (long)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (short)dynConstraints[12] , (bool)dynConstraints[13] );
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
          Object[] prmH00682 ;
          prmH00682 = new Object[] {
          new Object[] {"@AV48BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV49BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV50BR_Procedure_RadioWWDS_3_Tfbr_procedureid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV51BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV52BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV53BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV54BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV55BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00683 ;
          prmH00683 = new Object[] {
          new Object[] {"@AV48BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV49BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV50BR_Procedure_RadioWWDS_3_Tfbr_procedureid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV51BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV52BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV53BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV54BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV55BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel",SqlDbType.NVarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00682", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00682,11,0,true,false )
             ,new CursorDef("H00683", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00683,1,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((long[]) buf[4])[0] = rslt.getLong(3) ;
                ((long[]) buf[5])[0] = rslt.getLong(4) ;
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
                   stmt.SetParameter(sIdx, (long)parms[11]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[12]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[13]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[14]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[19]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[20]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[21]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[8]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[9]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[10]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[11]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                return;
       }
    }

 }

}
