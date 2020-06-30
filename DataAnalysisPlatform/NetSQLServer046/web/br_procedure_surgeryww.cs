/*
               File: BR_Procedure_SurgeryWW
        Description:  诊疗处理手术信息
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 12:4:41.44
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
   public class br_procedure_surgeryww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_procedure_surgeryww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_procedure_surgeryww( IGxContext context )
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
               AV17TFBR_Procedure_SurgeryID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV18TFBR_Procedure_SurgeryID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV21TFBR_ProcedureID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV22TFBR_ProcedureID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV25TFBR_Procedure_Surgery_Name = GetNextPar( );
               AV26TFBR_Procedure_Surgery_Name_Sel = GetNextPar( );
               AV29TFBR_Procedure_Surgery_Loc = GetNextPar( );
               AV30TFBR_Procedure_Surgery_Loc_Sel = GetNextPar( );
               AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace = GetNextPar( );
               AV23ddo_BR_ProcedureIDTitleControlIdToReplace = GetNextPar( );
               AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace = GetNextPar( );
               AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace = GetNextPar( );
               AV58Pgmname = GetNextPar( );
               AV39IsAuthorized_Update = StringUtil.StrToBool( GetNextPar( ));
               AV41IsAuthorized_Delete = StringUtil.StrToBool( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Procedure_SurgeryID, AV18TFBR_Procedure_SurgeryID_To, AV21TFBR_ProcedureID, AV22TFBR_ProcedureID_To, AV25TFBR_Procedure_Surgery_Name, AV26TFBR_Procedure_Surgery_Name_Sel, AV29TFBR_Procedure_Surgery_Loc, AV30TFBR_Procedure_Surgery_Loc_Sel, AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace, AV23ddo_BR_ProcedureIDTitleControlIdToReplace, AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace, AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace, AV58Pgmname, AV39IsAuthorized_Update, AV41IsAuthorized_Delete) ;
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
         PA662( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START662( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202271244167", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_procedure_surgeryww.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PROCEDURE_SURGERYID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFBR_Procedure_SurgeryID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PROCEDURE_SURGERYID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFBR_Procedure_SurgeryID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PROCEDUREID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21TFBR_ProcedureID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PROCEDUREID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22TFBR_ProcedureID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PROCEDURE_SURGERY_NAME", AV25TFBR_Procedure_Surgery_Name);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PROCEDURE_SURGERY_NAME_SEL", AV26TFBR_Procedure_Surgery_Name_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PROCEDURE_SURGERY_LOC", AV29TFBR_Procedure_Surgery_Loc);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PROCEDURE_SURGERY_LOC_SEL", AV30TFBR_Procedure_Surgery_Loc_Sel);
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PROCEDURE_SURGERYIDTITLEFILTERDATA", AV16BR_Procedure_SurgeryIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PROCEDURE_SURGERYIDTITLEFILTERDATA", AV16BR_Procedure_SurgeryIDTitleFilterData);
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PROCEDURE_SURGERY_NAMETITLEFILTERDATA", AV24BR_Procedure_Surgery_NameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PROCEDURE_SURGERY_NAMETITLEFILTERDATA", AV24BR_Procedure_Surgery_NameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PROCEDURE_SURGERY_LOCTITLEFILTERDATA", AV28BR_Procedure_Surgery_LocTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PROCEDURE_SURGERY_LOCTITLEFILTERDATA", AV28BR_Procedure_Surgery_LocTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV58Pgmname));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Caption", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Tooltip", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Cls", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Filteredtext_set", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Filteredtextto_set", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedure_surgeryid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedure_surgeryid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Sortedstatus", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Includefilter", StringUtil.BoolToStr( Ddo_br_procedure_surgeryid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Filtertype", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Filterisrange", StringUtil.BoolToStr( Ddo_br_procedure_surgeryid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedure_surgeryid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Sortasc", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Sortdsc", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Cleanfilter", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Rangefilterfrom", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Rangefilterto", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Searchbuttontext));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Caption", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Tooltip", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Cls", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Filteredtext_set", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Selectedvalue_set", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedure_surgery_name_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedure_surgery_name_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Sortedstatus", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Includefilter", StringUtil.BoolToStr( Ddo_br_procedure_surgery_name_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Filtertype", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Filterisrange", StringUtil.BoolToStr( Ddo_br_procedure_surgery_name_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedure_surgery_name_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Datalisttype", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Datalistproc", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_procedure_surgery_name_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Sortasc", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Sortdsc", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Loadingdata", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Cleanfilter", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Noresultsfound", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Caption", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Tooltip", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Cls", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Filteredtext_set", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Selectedvalue_set", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedure_surgery_loc_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedure_surgery_loc_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Sortedstatus", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Includefilter", StringUtil.BoolToStr( Ddo_br_procedure_surgery_loc_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Filtertype", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Filterisrange", StringUtil.BoolToStr( Ddo_br_procedure_surgery_loc_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedure_surgery_loc_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Datalisttype", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Datalistproc", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_procedure_surgery_loc_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Sortasc", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Sortdsc", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Loadingdata", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Cleanfilter", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Noresultsfound", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Filteredtext_get", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Activeeventkey", StringUtil.RTrim( Ddo_br_procedureid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Filteredtext_get", StringUtil.RTrim( Ddo_br_procedureid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_procedureid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Filteredtext_get", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Selectedvalue_get", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Filteredtext_get", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Selectedvalue_get", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Filteredtext_get", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERYID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_procedure_surgeryid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Activeeventkey", StringUtil.RTrim( Ddo_br_procedureid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Filteredtext_get", StringUtil.RTrim( Ddo_br_procedureid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_procedureid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Filteredtext_get", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_NAME_Selectedvalue_get", StringUtil.RTrim( Ddo_br_procedure_surgery_name_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Filteredtext_get", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_SURGERY_LOC_Selectedvalue_get", StringUtil.RTrim( Ddo_br_procedure_surgery_loc_Selectedvalue_get));
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
            WE662( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT662( ) ;
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
         return formatLink("br_procedure_surgeryww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "BR_Procedure_SurgeryWW" ;
      }

      public override String GetPgmdesc( )
      {
         return " 诊疗处理手术信息" ;
      }

      protected void WB660( )
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
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(31), 2, 0)+","+"null"+");", "插入", bttBtninsert_Jsonclick, 5, "插入", "", StyleString, ClassString, bttBtninsert_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Procedure_SurgeryWW.htm");
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
               if ( edtBR_Procedure_SurgeryID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Procedure_SurgeryID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Procedure_SurgeryID_Title) ;
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
               if ( edtBR_Procedure_Surgery_Name_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Procedure_Surgery_Name_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Procedure_Surgery_Name_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Procedure_Surgery_Loc_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Procedure_Surgery_Loc_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Procedure_Surgery_Loc_Title) ;
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
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A320BR_Procedure_SurgeryID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Procedure_SurgeryID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Procedure_SurgeryID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A139BR_ProcedureID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_ProcedureID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_ProcedureID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A321BR_Procedure_Surgery_Name);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Procedure_Surgery_Name_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Procedure_Surgery_Name_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtBR_Procedure_Surgery_Name_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A322BR_Procedure_Surgery_Loc);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Procedure_Surgery_Loc_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Procedure_Surgery_Loc_Titleformat), 4, 0, ".", "")));
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
            ucDdo_br_procedure_surgeryid.SetProperty("Caption", Ddo_br_procedure_surgeryid_Caption);
            ucDdo_br_procedure_surgeryid.SetProperty("Tooltip", Ddo_br_procedure_surgeryid_Tooltip);
            ucDdo_br_procedure_surgeryid.SetProperty("Cls", Ddo_br_procedure_surgeryid_Cls);
            ucDdo_br_procedure_surgeryid.SetProperty("DropDownOptionsType", Ddo_br_procedure_surgeryid_Dropdownoptionstype);
            ucDdo_br_procedure_surgeryid.SetProperty("IncludeSortASC", Ddo_br_procedure_surgeryid_Includesortasc);
            ucDdo_br_procedure_surgeryid.SetProperty("IncludeSortDSC", Ddo_br_procedure_surgeryid_Includesortdsc);
            ucDdo_br_procedure_surgeryid.SetProperty("IncludeFilter", Ddo_br_procedure_surgeryid_Includefilter);
            ucDdo_br_procedure_surgeryid.SetProperty("FilterType", Ddo_br_procedure_surgeryid_Filtertype);
            ucDdo_br_procedure_surgeryid.SetProperty("FilterIsRange", Ddo_br_procedure_surgeryid_Filterisrange);
            ucDdo_br_procedure_surgeryid.SetProperty("IncludeDataList", Ddo_br_procedure_surgeryid_Includedatalist);
            ucDdo_br_procedure_surgeryid.SetProperty("SortASC", Ddo_br_procedure_surgeryid_Sortasc);
            ucDdo_br_procedure_surgeryid.SetProperty("SortDSC", Ddo_br_procedure_surgeryid_Sortdsc);
            ucDdo_br_procedure_surgeryid.SetProperty("CleanFilter", Ddo_br_procedure_surgeryid_Cleanfilter);
            ucDdo_br_procedure_surgeryid.SetProperty("RangeFilterFrom", Ddo_br_procedure_surgeryid_Rangefilterfrom);
            ucDdo_br_procedure_surgeryid.SetProperty("RangeFilterTo", Ddo_br_procedure_surgeryid_Rangefilterto);
            ucDdo_br_procedure_surgeryid.SetProperty("SearchButtonText", Ddo_br_procedure_surgeryid_Searchbuttontext);
            ucDdo_br_procedure_surgeryid.SetProperty("DropDownOptionsTitleSettingsIcons", AV32DDO_TitleSettingsIcons);
            ucDdo_br_procedure_surgeryid.SetProperty("DropDownOptionsData", AV16BR_Procedure_SurgeryIDTitleFilterData);
            ucDdo_br_procedure_surgeryid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedure_surgeryid_Internalname, "DDO_BR_PROCEDURE_SURGERYIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedure_surgeryidtitlecontrolidtoreplace_Internalname, AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,47);\"", 0, edtavDdo_br_procedure_surgeryidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Procedure_SurgeryWW.htm");
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
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname, AV23ddo_BR_ProcedureIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", 0, edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Procedure_SurgeryWW.htm");
            /* User Defined Control */
            ucDdo_br_procedure_surgery_name.SetProperty("Caption", Ddo_br_procedure_surgery_name_Caption);
            ucDdo_br_procedure_surgery_name.SetProperty("Tooltip", Ddo_br_procedure_surgery_name_Tooltip);
            ucDdo_br_procedure_surgery_name.SetProperty("Cls", Ddo_br_procedure_surgery_name_Cls);
            ucDdo_br_procedure_surgery_name.SetProperty("DropDownOptionsType", Ddo_br_procedure_surgery_name_Dropdownoptionstype);
            ucDdo_br_procedure_surgery_name.SetProperty("IncludeSortASC", Ddo_br_procedure_surgery_name_Includesortasc);
            ucDdo_br_procedure_surgery_name.SetProperty("IncludeSortDSC", Ddo_br_procedure_surgery_name_Includesortdsc);
            ucDdo_br_procedure_surgery_name.SetProperty("IncludeFilter", Ddo_br_procedure_surgery_name_Includefilter);
            ucDdo_br_procedure_surgery_name.SetProperty("FilterType", Ddo_br_procedure_surgery_name_Filtertype);
            ucDdo_br_procedure_surgery_name.SetProperty("FilterIsRange", Ddo_br_procedure_surgery_name_Filterisrange);
            ucDdo_br_procedure_surgery_name.SetProperty("IncludeDataList", Ddo_br_procedure_surgery_name_Includedatalist);
            ucDdo_br_procedure_surgery_name.SetProperty("DataListType", Ddo_br_procedure_surgery_name_Datalisttype);
            ucDdo_br_procedure_surgery_name.SetProperty("DataListProc", Ddo_br_procedure_surgery_name_Datalistproc);
            ucDdo_br_procedure_surgery_name.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_procedure_surgery_name_Datalistupdateminimumcharacters);
            ucDdo_br_procedure_surgery_name.SetProperty("SortASC", Ddo_br_procedure_surgery_name_Sortasc);
            ucDdo_br_procedure_surgery_name.SetProperty("SortDSC", Ddo_br_procedure_surgery_name_Sortdsc);
            ucDdo_br_procedure_surgery_name.SetProperty("LoadingData", Ddo_br_procedure_surgery_name_Loadingdata);
            ucDdo_br_procedure_surgery_name.SetProperty("CleanFilter", Ddo_br_procedure_surgery_name_Cleanfilter);
            ucDdo_br_procedure_surgery_name.SetProperty("NoResultsFound", Ddo_br_procedure_surgery_name_Noresultsfound);
            ucDdo_br_procedure_surgery_name.SetProperty("SearchButtonText", Ddo_br_procedure_surgery_name_Searchbuttontext);
            ucDdo_br_procedure_surgery_name.SetProperty("DropDownOptionsTitleSettingsIcons", AV32DDO_TitleSettingsIcons);
            ucDdo_br_procedure_surgery_name.SetProperty("DropDownOptionsData", AV24BR_Procedure_Surgery_NameTitleFilterData);
            ucDdo_br_procedure_surgery_name.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedure_surgery_name_Internalname, "DDO_BR_PROCEDURE_SURGERY_NAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedure_surgery_nametitlecontrolidtoreplace_Internalname, AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", 0, edtavDdo_br_procedure_surgery_nametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Procedure_SurgeryWW.htm");
            /* User Defined Control */
            ucDdo_br_procedure_surgery_loc.SetProperty("Caption", Ddo_br_procedure_surgery_loc_Caption);
            ucDdo_br_procedure_surgery_loc.SetProperty("Tooltip", Ddo_br_procedure_surgery_loc_Tooltip);
            ucDdo_br_procedure_surgery_loc.SetProperty("Cls", Ddo_br_procedure_surgery_loc_Cls);
            ucDdo_br_procedure_surgery_loc.SetProperty("DropDownOptionsType", Ddo_br_procedure_surgery_loc_Dropdownoptionstype);
            ucDdo_br_procedure_surgery_loc.SetProperty("IncludeSortASC", Ddo_br_procedure_surgery_loc_Includesortasc);
            ucDdo_br_procedure_surgery_loc.SetProperty("IncludeSortDSC", Ddo_br_procedure_surgery_loc_Includesortdsc);
            ucDdo_br_procedure_surgery_loc.SetProperty("IncludeFilter", Ddo_br_procedure_surgery_loc_Includefilter);
            ucDdo_br_procedure_surgery_loc.SetProperty("FilterType", Ddo_br_procedure_surgery_loc_Filtertype);
            ucDdo_br_procedure_surgery_loc.SetProperty("FilterIsRange", Ddo_br_procedure_surgery_loc_Filterisrange);
            ucDdo_br_procedure_surgery_loc.SetProperty("IncludeDataList", Ddo_br_procedure_surgery_loc_Includedatalist);
            ucDdo_br_procedure_surgery_loc.SetProperty("DataListType", Ddo_br_procedure_surgery_loc_Datalisttype);
            ucDdo_br_procedure_surgery_loc.SetProperty("DataListProc", Ddo_br_procedure_surgery_loc_Datalistproc);
            ucDdo_br_procedure_surgery_loc.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_procedure_surgery_loc_Datalistupdateminimumcharacters);
            ucDdo_br_procedure_surgery_loc.SetProperty("SortASC", Ddo_br_procedure_surgery_loc_Sortasc);
            ucDdo_br_procedure_surgery_loc.SetProperty("SortDSC", Ddo_br_procedure_surgery_loc_Sortdsc);
            ucDdo_br_procedure_surgery_loc.SetProperty("LoadingData", Ddo_br_procedure_surgery_loc_Loadingdata);
            ucDdo_br_procedure_surgery_loc.SetProperty("CleanFilter", Ddo_br_procedure_surgery_loc_Cleanfilter);
            ucDdo_br_procedure_surgery_loc.SetProperty("NoResultsFound", Ddo_br_procedure_surgery_loc_Noresultsfound);
            ucDdo_br_procedure_surgery_loc.SetProperty("SearchButtonText", Ddo_br_procedure_surgery_loc_Searchbuttontext);
            ucDdo_br_procedure_surgery_loc.SetProperty("DropDownOptionsTitleSettingsIcons", AV32DDO_TitleSettingsIcons);
            ucDdo_br_procedure_surgery_loc.SetProperty("DropDownOptionsData", AV28BR_Procedure_Surgery_LocTitleFilterData);
            ucDdo_br_procedure_surgery_loc.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedure_surgery_loc_Internalname, "DDO_BR_PROCEDURE_SURGERY_LOCContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedure_surgery_loctitlecontrolidtoreplace_Internalname, AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", 0, edtavDdo_br_procedure_surgery_loctitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Procedure_SurgeryWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Procedure_SurgeryWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_Procedure_SurgeryWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_procedure_surgeryid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFBR_Procedure_SurgeryID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV17TFBR_Procedure_SurgeryID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_procedure_surgeryid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_procedure_surgeryid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Procedure_SurgeryWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_procedure_surgeryid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFBR_Procedure_SurgeryID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV18TFBR_Procedure_SurgeryID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_procedure_surgeryid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_procedure_surgeryid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Procedure_SurgeryWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_procedureid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21TFBR_ProcedureID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV21TFBR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_procedureid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_procedureid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Procedure_SurgeryWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_procedureid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22TFBR_ProcedureID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV22TFBR_ProcedureID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,60);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_procedureid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_procedureid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Procedure_SurgeryWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_procedure_surgery_name_Internalname, AV25TFBR_Procedure_Surgery_Name, StringUtil.RTrim( context.localUtil.Format( AV25TFBR_Procedure_Surgery_Name, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,61);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_procedure_surgery_name_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_procedure_surgery_name_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Procedure_SurgeryWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_procedure_surgery_name_sel_Internalname, AV26TFBR_Procedure_Surgery_Name_Sel, StringUtil.RTrim( context.localUtil.Format( AV26TFBR_Procedure_Surgery_Name_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,62);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_procedure_surgery_name_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_procedure_surgery_name_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Procedure_SurgeryWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_procedure_surgery_loc_Internalname, AV29TFBR_Procedure_Surgery_Loc, StringUtil.RTrim( context.localUtil.Format( AV29TFBR_Procedure_Surgery_Loc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_procedure_surgery_loc_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_procedure_surgery_loc_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Procedure_SurgeryWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_procedure_surgery_loc_sel_Internalname, AV30TFBR_Procedure_Surgery_Loc_Sel, StringUtil.RTrim( context.localUtil.Format( AV30TFBR_Procedure_Surgery_Loc_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_procedure_surgery_loc_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_procedure_surgery_loc_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Procedure_SurgeryWW.htm");
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

      protected void START662( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", " 诊疗处理手术信息", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP660( ) ;
      }

      protected void WS662( )
      {
         START662( ) ;
         EVT662( ) ;
      }

      protected void EVT662( )
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
                              E11662 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E12662 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDURE_SURGERYID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E13662 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDUREID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E14662 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDURE_SURGERY_NAME.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E15662 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDURE_SURGERY_LOC.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E16662 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E17662 ();
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
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV37Display)) ? AV55Display_GXI : context.convertURL( context.PathToRelativeUrl( AV37Display))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV37Display), true);
                              AV38Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV38Update)) ? AV56Update_GXI : context.convertURL( context.PathToRelativeUrl( AV38Update))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV38Update), true);
                              AV40Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV40Delete)) ? AV57Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV40Delete))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV40Delete), true);
                              A320BR_Procedure_SurgeryID = (long)(context.localUtil.CToN( cgiGet( edtBR_Procedure_SurgeryID_Internalname), ".", ","));
                              A139BR_ProcedureID = (long)(context.localUtil.CToN( cgiGet( edtBR_ProcedureID_Internalname), ".", ","));
                              A321BR_Procedure_Surgery_Name = cgiGet( edtBR_Procedure_Surgery_Name_Internalname);
                              n321BR_Procedure_Surgery_Name = false;
                              A322BR_Procedure_Surgery_Loc = cgiGet( edtBR_Procedure_Surgery_Loc_Internalname);
                              n322BR_Procedure_Surgery_Loc = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E18662 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E19662 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E20662 ();
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
                                       /* Set Refresh If Tfbr_procedure_surgeryid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PROCEDURE_SURGERYID"), ".", ",") != Convert.ToDecimal( AV17TFBR_Procedure_SurgeryID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_procedure_surgeryid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PROCEDURE_SURGERYID_TO"), ".", ",") != Convert.ToDecimal( AV18TFBR_Procedure_SurgeryID_To )) )
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
                                       /* Set Refresh If Tfbr_procedure_surgery_name Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PROCEDURE_SURGERY_NAME"), AV25TFBR_Procedure_Surgery_Name) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_procedure_surgery_name_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PROCEDURE_SURGERY_NAME_SEL"), AV26TFBR_Procedure_Surgery_Name_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_procedure_surgery_loc Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PROCEDURE_SURGERY_LOC"), AV29TFBR_Procedure_Surgery_Loc) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_procedure_surgery_loc_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PROCEDURE_SURGERY_LOC_SEL"), AV30TFBR_Procedure_Surgery_Loc_Sel) != 0 )
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

      protected void WE662( )
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

      protected void PA662( )
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
               GX_FocusControl = edtavDdo_br_procedure_surgeryidtitlecontrolidtoreplace_Internalname;
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
                                       long AV17TFBR_Procedure_SurgeryID ,
                                       long AV18TFBR_Procedure_SurgeryID_To ,
                                       long AV21TFBR_ProcedureID ,
                                       long AV22TFBR_ProcedureID_To ,
                                       String AV25TFBR_Procedure_Surgery_Name ,
                                       String AV26TFBR_Procedure_Surgery_Name_Sel ,
                                       String AV29TFBR_Procedure_Surgery_Loc ,
                                       String AV30TFBR_Procedure_Surgery_Loc_Sel ,
                                       String AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace ,
                                       String AV23ddo_BR_ProcedureIDTitleControlIdToReplace ,
                                       String AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace ,
                                       String AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace ,
                                       String AV58Pgmname ,
                                       bool AV39IsAuthorized_Update ,
                                       bool AV41IsAuthorized_Delete )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF662( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PROCEDURE_SURGERYID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A320BR_Procedure_SurgeryID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_PROCEDURE_SURGERYID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A320BR_Procedure_SurgeryID), 18, 0, ".", "")));
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
         RF662( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV58Pgmname = "BR_Procedure_SurgeryWW";
         context.Gx_err = 0;
      }

      protected void RF662( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 31;
         /* Execute user event: Refresh */
         E19662 ();
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
                                                 AV47BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid ,
                                                 AV48BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to ,
                                                 AV49BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid ,
                                                 AV50BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to ,
                                                 AV52BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel ,
                                                 AV51BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name ,
                                                 AV54BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel ,
                                                 AV53BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc ,
                                                 A320BR_Procedure_SurgeryID ,
                                                 A139BR_ProcedureID ,
                                                 A321BR_Procedure_Surgery_Name ,
                                                 A322BR_Procedure_Surgery_Loc ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG,
                                                 TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV51BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name = StringUtil.Concat( StringUtil.RTrim( AV51BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name), "%", "");
            lV53BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc = StringUtil.Concat( StringUtil.RTrim( AV53BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc), "%", "");
            /* Using cursor H00662 */
            pr_default.execute(0, new Object[] {AV47BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid, AV48BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to, AV49BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid, AV50BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to, lV51BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name, AV52BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel, lV53BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc, AV54BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_31_idx = 1;
            sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
            SubsflControlProps_312( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A322BR_Procedure_Surgery_Loc = H00662_A322BR_Procedure_Surgery_Loc[0];
               n322BR_Procedure_Surgery_Loc = H00662_n322BR_Procedure_Surgery_Loc[0];
               A321BR_Procedure_Surgery_Name = H00662_A321BR_Procedure_Surgery_Name[0];
               n321BR_Procedure_Surgery_Name = H00662_n321BR_Procedure_Surgery_Name[0];
               A139BR_ProcedureID = H00662_A139BR_ProcedureID[0];
               A320BR_Procedure_SurgeryID = H00662_A320BR_Procedure_SurgeryID[0];
               E20662 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 31;
            WB660( ) ;
         }
         bGXsfl_31_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes662( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PROCEDURE_SURGERYID"+"_"+sGXsfl_31_idx, GetSecureSignedToken( sGXsfl_31_idx, context.localUtil.Format( (decimal)(A320BR_Procedure_SurgeryID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         AV47BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid = AV17TFBR_Procedure_SurgeryID;
         AV48BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to = AV18TFBR_Procedure_SurgeryID_To;
         AV49BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid = AV21TFBR_ProcedureID;
         AV50BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to = AV22TFBR_ProcedureID_To;
         AV51BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name = AV25TFBR_Procedure_Surgery_Name;
         AV52BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel = AV26TFBR_Procedure_Surgery_Name_Sel;
         AV53BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc = AV29TFBR_Procedure_Surgery_Loc;
         AV54BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel = AV30TFBR_Procedure_Surgery_Loc_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV47BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid ,
                                              AV48BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to ,
                                              AV49BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid ,
                                              AV50BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to ,
                                              AV52BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel ,
                                              AV51BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name ,
                                              AV54BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel ,
                                              AV53BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc ,
                                              A320BR_Procedure_SurgeryID ,
                                              A139BR_ProcedureID ,
                                              A321BR_Procedure_Surgery_Name ,
                                              A322BR_Procedure_Surgery_Loc ,
                                              AV13OrderedBy ,
                                              AV14OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV51BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name = StringUtil.Concat( StringUtil.RTrim( AV51BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name), "%", "");
         lV53BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc = StringUtil.Concat( StringUtil.RTrim( AV53BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc), "%", "");
         /* Using cursor H00663 */
         pr_default.execute(1, new Object[] {AV47BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid, AV48BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to, AV49BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid, AV50BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to, lV51BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name, AV52BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel, lV53BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc, AV54BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel});
         GRID_nRecordCount = H00663_AGRID_nRecordCount[0];
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
         AV47BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid = AV17TFBR_Procedure_SurgeryID;
         AV48BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to = AV18TFBR_Procedure_SurgeryID_To;
         AV49BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid = AV21TFBR_ProcedureID;
         AV50BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to = AV22TFBR_ProcedureID_To;
         AV51BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name = AV25TFBR_Procedure_Surgery_Name;
         AV52BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel = AV26TFBR_Procedure_Surgery_Name_Sel;
         AV53BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc = AV29TFBR_Procedure_Surgery_Loc;
         AV54BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel = AV30TFBR_Procedure_Surgery_Loc_Sel;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Procedure_SurgeryID, AV18TFBR_Procedure_SurgeryID_To, AV21TFBR_ProcedureID, AV22TFBR_ProcedureID_To, AV25TFBR_Procedure_Surgery_Name, AV26TFBR_Procedure_Surgery_Name_Sel, AV29TFBR_Procedure_Surgery_Loc, AV30TFBR_Procedure_Surgery_Loc_Sel, AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace, AV23ddo_BR_ProcedureIDTitleControlIdToReplace, AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace, AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace, AV58Pgmname, AV39IsAuthorized_Update, AV41IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV47BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid = AV17TFBR_Procedure_SurgeryID;
         AV48BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to = AV18TFBR_Procedure_SurgeryID_To;
         AV49BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid = AV21TFBR_ProcedureID;
         AV50BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to = AV22TFBR_ProcedureID_To;
         AV51BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name = AV25TFBR_Procedure_Surgery_Name;
         AV52BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel = AV26TFBR_Procedure_Surgery_Name_Sel;
         AV53BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc = AV29TFBR_Procedure_Surgery_Loc;
         AV54BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel = AV30TFBR_Procedure_Surgery_Loc_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Procedure_SurgeryID, AV18TFBR_Procedure_SurgeryID_To, AV21TFBR_ProcedureID, AV22TFBR_ProcedureID_To, AV25TFBR_Procedure_Surgery_Name, AV26TFBR_Procedure_Surgery_Name_Sel, AV29TFBR_Procedure_Surgery_Loc, AV30TFBR_Procedure_Surgery_Loc_Sel, AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace, AV23ddo_BR_ProcedureIDTitleControlIdToReplace, AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace, AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace, AV58Pgmname, AV39IsAuthorized_Update, AV41IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV47BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid = AV17TFBR_Procedure_SurgeryID;
         AV48BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to = AV18TFBR_Procedure_SurgeryID_To;
         AV49BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid = AV21TFBR_ProcedureID;
         AV50BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to = AV22TFBR_ProcedureID_To;
         AV51BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name = AV25TFBR_Procedure_Surgery_Name;
         AV52BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel = AV26TFBR_Procedure_Surgery_Name_Sel;
         AV53BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc = AV29TFBR_Procedure_Surgery_Loc;
         AV54BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel = AV30TFBR_Procedure_Surgery_Loc_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Procedure_SurgeryID, AV18TFBR_Procedure_SurgeryID_To, AV21TFBR_ProcedureID, AV22TFBR_ProcedureID_To, AV25TFBR_Procedure_Surgery_Name, AV26TFBR_Procedure_Surgery_Name_Sel, AV29TFBR_Procedure_Surgery_Loc, AV30TFBR_Procedure_Surgery_Loc_Sel, AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace, AV23ddo_BR_ProcedureIDTitleControlIdToReplace, AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace, AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace, AV58Pgmname, AV39IsAuthorized_Update, AV41IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV47BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid = AV17TFBR_Procedure_SurgeryID;
         AV48BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to = AV18TFBR_Procedure_SurgeryID_To;
         AV49BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid = AV21TFBR_ProcedureID;
         AV50BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to = AV22TFBR_ProcedureID_To;
         AV51BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name = AV25TFBR_Procedure_Surgery_Name;
         AV52BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel = AV26TFBR_Procedure_Surgery_Name_Sel;
         AV53BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc = AV29TFBR_Procedure_Surgery_Loc;
         AV54BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel = AV30TFBR_Procedure_Surgery_Loc_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Procedure_SurgeryID, AV18TFBR_Procedure_SurgeryID_To, AV21TFBR_ProcedureID, AV22TFBR_ProcedureID_To, AV25TFBR_Procedure_Surgery_Name, AV26TFBR_Procedure_Surgery_Name_Sel, AV29TFBR_Procedure_Surgery_Loc, AV30TFBR_Procedure_Surgery_Loc_Sel, AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace, AV23ddo_BR_ProcedureIDTitleControlIdToReplace, AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace, AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace, AV58Pgmname, AV39IsAuthorized_Update, AV41IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV47BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid = AV17TFBR_Procedure_SurgeryID;
         AV48BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to = AV18TFBR_Procedure_SurgeryID_To;
         AV49BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid = AV21TFBR_ProcedureID;
         AV50BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to = AV22TFBR_ProcedureID_To;
         AV51BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name = AV25TFBR_Procedure_Surgery_Name;
         AV52BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel = AV26TFBR_Procedure_Surgery_Name_Sel;
         AV53BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc = AV29TFBR_Procedure_Surgery_Loc;
         AV54BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel = AV30TFBR_Procedure_Surgery_Loc_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Procedure_SurgeryID, AV18TFBR_Procedure_SurgeryID_To, AV21TFBR_ProcedureID, AV22TFBR_ProcedureID_To, AV25TFBR_Procedure_Surgery_Name, AV26TFBR_Procedure_Surgery_Name_Sel, AV29TFBR_Procedure_Surgery_Loc, AV30TFBR_Procedure_Surgery_Loc_Sel, AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace, AV23ddo_BR_ProcedureIDTitleControlIdToReplace, AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace, AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace, AV58Pgmname, AV39IsAuthorized_Update, AV41IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP660( )
      {
         /* Before Start, stand alone formulas. */
         AV58Pgmname = "BR_Procedure_SurgeryWW";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E18662 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV32DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PROCEDURE_SURGERYIDTITLEFILTERDATA"), AV16BR_Procedure_SurgeryIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PROCEDUREIDTITLEFILTERDATA"), AV20BR_ProcedureIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PROCEDURE_SURGERY_NAMETITLEFILTERDATA"), AV24BR_Procedure_Surgery_NameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PROCEDURE_SURGERY_LOCTITLEFILTERDATA"), AV28BR_Procedure_Surgery_LocTitleFilterData);
            /* Read variables values. */
            AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace = cgiGet( edtavDdo_br_procedure_surgeryidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace", AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace);
            AV23ddo_BR_ProcedureIDTitleControlIdToReplace = cgiGet( edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_ProcedureIDTitleControlIdToReplace", AV23ddo_BR_ProcedureIDTitleControlIdToReplace);
            AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace = cgiGet( edtavDdo_br_procedure_surgery_nametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace", AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace);
            AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace = cgiGet( edtavDdo_br_procedure_surgery_loctitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace", AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace);
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
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_procedure_surgeryid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_procedure_surgeryid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PROCEDURE_SURGERYID");
               GX_FocusControl = edtavTfbr_procedure_surgeryid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV17TFBR_Procedure_SurgeryID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Procedure_SurgeryID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Procedure_SurgeryID), 18, 0)));
            }
            else
            {
               AV17TFBR_Procedure_SurgeryID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_procedure_surgeryid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Procedure_SurgeryID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Procedure_SurgeryID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_procedure_surgeryid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_procedure_surgeryid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PROCEDURE_SURGERYID_TO");
               GX_FocusControl = edtavTfbr_procedure_surgeryid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV18TFBR_Procedure_SurgeryID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Procedure_SurgeryID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Procedure_SurgeryID_To), 18, 0)));
            }
            else
            {
               AV18TFBR_Procedure_SurgeryID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_procedure_surgeryid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Procedure_SurgeryID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Procedure_SurgeryID_To), 18, 0)));
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
            AV25TFBR_Procedure_Surgery_Name = cgiGet( edtavTfbr_procedure_surgery_name_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_Procedure_Surgery_Name", AV25TFBR_Procedure_Surgery_Name);
            AV26TFBR_Procedure_Surgery_Name_Sel = cgiGet( edtavTfbr_procedure_surgery_name_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_Procedure_Surgery_Name_Sel", AV26TFBR_Procedure_Surgery_Name_Sel);
            AV29TFBR_Procedure_Surgery_Loc = cgiGet( edtavTfbr_procedure_surgery_loc_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_Procedure_Surgery_Loc", AV29TFBR_Procedure_Surgery_Loc);
            AV30TFBR_Procedure_Surgery_Loc_Sel = cgiGet( edtavTfbr_procedure_surgery_loc_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_Procedure_Surgery_Loc_Sel", AV30TFBR_Procedure_Surgery_Loc_Sel);
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
            Ddo_br_procedure_surgeryid_Caption = cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Caption");
            Ddo_br_procedure_surgeryid_Tooltip = cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Tooltip");
            Ddo_br_procedure_surgeryid_Cls = cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Cls");
            Ddo_br_procedure_surgeryid_Filteredtext_set = cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Filteredtext_set");
            Ddo_br_procedure_surgeryid_Filteredtextto_set = cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Filteredtextto_set");
            Ddo_br_procedure_surgeryid_Dropdownoptionstype = cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Dropdownoptionstype");
            Ddo_br_procedure_surgeryid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Titlecontrolidtoreplace");
            Ddo_br_procedure_surgeryid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Includesortasc"));
            Ddo_br_procedure_surgeryid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Includesortdsc"));
            Ddo_br_procedure_surgeryid_Sortedstatus = cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Sortedstatus");
            Ddo_br_procedure_surgeryid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Includefilter"));
            Ddo_br_procedure_surgeryid_Filtertype = cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Filtertype");
            Ddo_br_procedure_surgeryid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Filterisrange"));
            Ddo_br_procedure_surgeryid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Includedatalist"));
            Ddo_br_procedure_surgeryid_Sortasc = cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Sortasc");
            Ddo_br_procedure_surgeryid_Sortdsc = cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Sortdsc");
            Ddo_br_procedure_surgeryid_Cleanfilter = cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Cleanfilter");
            Ddo_br_procedure_surgeryid_Rangefilterfrom = cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Rangefilterfrom");
            Ddo_br_procedure_surgeryid_Rangefilterto = cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Rangefilterto");
            Ddo_br_procedure_surgeryid_Searchbuttontext = cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Searchbuttontext");
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
            Ddo_br_procedure_surgery_name_Caption = cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Caption");
            Ddo_br_procedure_surgery_name_Tooltip = cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Tooltip");
            Ddo_br_procedure_surgery_name_Cls = cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Cls");
            Ddo_br_procedure_surgery_name_Filteredtext_set = cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Filteredtext_set");
            Ddo_br_procedure_surgery_name_Selectedvalue_set = cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Selectedvalue_set");
            Ddo_br_procedure_surgery_name_Dropdownoptionstype = cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Dropdownoptionstype");
            Ddo_br_procedure_surgery_name_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Titlecontrolidtoreplace");
            Ddo_br_procedure_surgery_name_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Includesortasc"));
            Ddo_br_procedure_surgery_name_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Includesortdsc"));
            Ddo_br_procedure_surgery_name_Sortedstatus = cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Sortedstatus");
            Ddo_br_procedure_surgery_name_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Includefilter"));
            Ddo_br_procedure_surgery_name_Filtertype = cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Filtertype");
            Ddo_br_procedure_surgery_name_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Filterisrange"));
            Ddo_br_procedure_surgery_name_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Includedatalist"));
            Ddo_br_procedure_surgery_name_Datalisttype = cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Datalisttype");
            Ddo_br_procedure_surgery_name_Datalistproc = cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Datalistproc");
            Ddo_br_procedure_surgery_name_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_procedure_surgery_name_Sortasc = cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Sortasc");
            Ddo_br_procedure_surgery_name_Sortdsc = cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Sortdsc");
            Ddo_br_procedure_surgery_name_Loadingdata = cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Loadingdata");
            Ddo_br_procedure_surgery_name_Cleanfilter = cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Cleanfilter");
            Ddo_br_procedure_surgery_name_Noresultsfound = cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Noresultsfound");
            Ddo_br_procedure_surgery_name_Searchbuttontext = cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Searchbuttontext");
            Ddo_br_procedure_surgery_loc_Caption = cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Caption");
            Ddo_br_procedure_surgery_loc_Tooltip = cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Tooltip");
            Ddo_br_procedure_surgery_loc_Cls = cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Cls");
            Ddo_br_procedure_surgery_loc_Filteredtext_set = cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Filteredtext_set");
            Ddo_br_procedure_surgery_loc_Selectedvalue_set = cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Selectedvalue_set");
            Ddo_br_procedure_surgery_loc_Dropdownoptionstype = cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Dropdownoptionstype");
            Ddo_br_procedure_surgery_loc_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Titlecontrolidtoreplace");
            Ddo_br_procedure_surgery_loc_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Includesortasc"));
            Ddo_br_procedure_surgery_loc_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Includesortdsc"));
            Ddo_br_procedure_surgery_loc_Sortedstatus = cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Sortedstatus");
            Ddo_br_procedure_surgery_loc_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Includefilter"));
            Ddo_br_procedure_surgery_loc_Filtertype = cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Filtertype");
            Ddo_br_procedure_surgery_loc_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Filterisrange"));
            Ddo_br_procedure_surgery_loc_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Includedatalist"));
            Ddo_br_procedure_surgery_loc_Datalisttype = cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Datalisttype");
            Ddo_br_procedure_surgery_loc_Datalistproc = cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Datalistproc");
            Ddo_br_procedure_surgery_loc_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_procedure_surgery_loc_Sortasc = cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Sortasc");
            Ddo_br_procedure_surgery_loc_Sortdsc = cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Sortdsc");
            Ddo_br_procedure_surgery_loc_Loadingdata = cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Loadingdata");
            Ddo_br_procedure_surgery_loc_Cleanfilter = cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Cleanfilter");
            Ddo_br_procedure_surgery_loc_Noresultsfound = cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Noresultsfound");
            Ddo_br_procedure_surgery_loc_Searchbuttontext = cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_procedure_surgeryid_Activeeventkey = cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Activeeventkey");
            Ddo_br_procedure_surgeryid_Filteredtext_get = cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Filteredtext_get");
            Ddo_br_procedure_surgeryid_Filteredtextto_get = cgiGet( "DDO_BR_PROCEDURE_SURGERYID_Filteredtextto_get");
            Ddo_br_procedureid_Activeeventkey = cgiGet( "DDO_BR_PROCEDUREID_Activeeventkey");
            Ddo_br_procedureid_Filteredtext_get = cgiGet( "DDO_BR_PROCEDUREID_Filteredtext_get");
            Ddo_br_procedureid_Filteredtextto_get = cgiGet( "DDO_BR_PROCEDUREID_Filteredtextto_get");
            Ddo_br_procedure_surgery_name_Activeeventkey = cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Activeeventkey");
            Ddo_br_procedure_surgery_name_Filteredtext_get = cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Filteredtext_get");
            Ddo_br_procedure_surgery_name_Selectedvalue_get = cgiGet( "DDO_BR_PROCEDURE_SURGERY_NAME_Selectedvalue_get");
            Ddo_br_procedure_surgery_loc_Activeeventkey = cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Activeeventkey");
            Ddo_br_procedure_surgery_loc_Filteredtext_get = cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Filteredtext_get");
            Ddo_br_procedure_surgery_loc_Selectedvalue_get = cgiGet( "DDO_BR_PROCEDURE_SURGERY_LOC_Selectedvalue_get");
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
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PROCEDURE_SURGERYID"), ".", ",") != Convert.ToDecimal( AV17TFBR_Procedure_SurgeryID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PROCEDURE_SURGERYID_TO"), ".", ",") != Convert.ToDecimal( AV18TFBR_Procedure_SurgeryID_To )) )
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
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PROCEDURE_SURGERY_NAME"), AV25TFBR_Procedure_Surgery_Name) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PROCEDURE_SURGERY_NAME_SEL"), AV26TFBR_Procedure_Surgery_Name_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PROCEDURE_SURGERY_LOC"), AV29TFBR_Procedure_Surgery_Loc) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PROCEDURE_SURGERY_LOC_SEL"), AV30TFBR_Procedure_Surgery_Loc_Sel) != 0 )
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
         E18662 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E18662( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         edtavTfbr_procedure_surgeryid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_procedure_surgeryid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_procedure_surgeryid_Visible), 5, 0)), true);
         edtavTfbr_procedure_surgeryid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_procedure_surgeryid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_procedure_surgeryid_to_Visible), 5, 0)), true);
         edtavTfbr_procedureid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_procedureid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_procedureid_Visible), 5, 0)), true);
         edtavTfbr_procedureid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_procedureid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_procedureid_to_Visible), 5, 0)), true);
         edtavTfbr_procedure_surgery_name_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_procedure_surgery_name_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_procedure_surgery_name_Visible), 5, 0)), true);
         edtavTfbr_procedure_surgery_name_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_procedure_surgery_name_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_procedure_surgery_name_sel_Visible), 5, 0)), true);
         edtavTfbr_procedure_surgery_loc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_procedure_surgery_loc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_procedure_surgery_loc_Visible), 5, 0)), true);
         edtavTfbr_procedure_surgery_loc_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_procedure_surgery_loc_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_procedure_surgery_loc_sel_Visible), 5, 0)), true);
         Ddo_br_procedure_surgeryid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Procedure_SurgeryID";
         ucDdo_br_procedure_surgeryid.SendProperty(context, "", false, Ddo_br_procedure_surgeryid_Internalname, "TitleControlIdToReplace", Ddo_br_procedure_surgeryid_Titlecontrolidtoreplace);
         AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace = Ddo_br_procedure_surgeryid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace", AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace);
         edtavDdo_br_procedure_surgeryidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_procedure_surgeryidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedure_surgeryidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_procedureid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_ProcedureID";
         ucDdo_br_procedureid.SendProperty(context, "", false, Ddo_br_procedureid_Internalname, "TitleControlIdToReplace", Ddo_br_procedureid_Titlecontrolidtoreplace);
         AV23ddo_BR_ProcedureIDTitleControlIdToReplace = Ddo_br_procedureid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_ProcedureIDTitleControlIdToReplace", AV23ddo_BR_ProcedureIDTitleControlIdToReplace);
         edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_procedure_surgery_name_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Procedure_Surgery_Name";
         ucDdo_br_procedure_surgery_name.SendProperty(context, "", false, Ddo_br_procedure_surgery_name_Internalname, "TitleControlIdToReplace", Ddo_br_procedure_surgery_name_Titlecontrolidtoreplace);
         AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace = Ddo_br_procedure_surgery_name_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace", AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace);
         edtavDdo_br_procedure_surgery_nametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_procedure_surgery_nametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedure_surgery_nametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_procedure_surgery_loc_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Procedure_Surgery_Loc";
         ucDdo_br_procedure_surgery_loc.SendProperty(context, "", false, Ddo_br_procedure_surgery_loc_Internalname, "TitleControlIdToReplace", Ddo_br_procedure_surgery_loc_Titlecontrolidtoreplace);
         AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace = Ddo_br_procedure_surgery_loc_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace", AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace);
         edtavDdo_br_procedure_surgery_loctitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_procedure_surgery_loctitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedure_surgery_loctitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " 诊疗处理手术信息";
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

      protected void E19662( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV16BR_Procedure_SurgeryIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_ProcedureIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_Procedure_Surgery_NameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28BR_Procedure_Surgery_LocTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
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
         edtBR_Procedure_SurgeryID_Titleformat = 2;
         edtBR_Procedure_SurgeryID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "主键", AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Procedure_SurgeryID_Internalname, "Title", edtBR_Procedure_SurgeryID_Title, !bGXsfl_31_Refreshing);
         edtBR_ProcedureID_Titleformat = 2;
         edtBR_ProcedureID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "诊疗处理主键", AV23ddo_BR_ProcedureIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_ProcedureID_Internalname, "Title", edtBR_ProcedureID_Title, !bGXsfl_31_Refreshing);
         edtBR_Procedure_Surgery_Name_Titleformat = 2;
         edtBR_Procedure_Surgery_Name_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "手术名称", AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Procedure_Surgery_Name_Internalname, "Title", edtBR_Procedure_Surgery_Name_Title, !bGXsfl_31_Refreshing);
         edtBR_Procedure_Surgery_Loc_Titleformat = 2;
         edtBR_Procedure_Surgery_Loc_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "手术部位", AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Procedure_Surgery_Loc_Internalname, "Title", edtBR_Procedure_Surgery_Loc_Title, !bGXsfl_31_Refreshing);
         AV34GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34GridCurrentPage), 10, 0)));
         AV35GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV35GridPageSize), 10, 0)));
         AV36GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV36GridRecordCount), 10, 0)));
         AV47BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid = AV17TFBR_Procedure_SurgeryID;
         AV48BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to = AV18TFBR_Procedure_SurgeryID_To;
         AV49BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid = AV21TFBR_ProcedureID;
         AV50BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to = AV22TFBR_ProcedureID_To;
         AV51BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name = AV25TFBR_Procedure_Surgery_Name;
         AV52BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel = AV26TFBR_Procedure_Surgery_Name_Sel;
         AV53BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc = AV29TFBR_Procedure_Surgery_Loc;
         AV54BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel = AV30TFBR_Procedure_Surgery_Loc_Sel;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Procedure_SurgeryIDTitleFilterData", AV16BR_Procedure_SurgeryIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_ProcedureIDTitleFilterData", AV20BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Procedure_Surgery_NameTitleFilterData", AV24BR_Procedure_Surgery_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Procedure_Surgery_LocTitleFilterData", AV28BR_Procedure_Surgery_LocTitleFilterData);
      }

      protected void E11662( )
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

      protected void E12662( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E13662( )
      {
         /* Ddo_br_procedure_surgeryid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedure_surgeryid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_procedure_surgeryid_Sortedstatus = "ASC";
            ucDdo_br_procedure_surgeryid.SendProperty(context, "", false, Ddo_br_procedure_surgeryid_Internalname, "SortedStatus", Ddo_br_procedure_surgeryid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_surgeryid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_procedure_surgeryid_Sortedstatus = "DSC";
            ucDdo_br_procedure_surgeryid.SendProperty(context, "", false, Ddo_br_procedure_surgeryid_Internalname, "SortedStatus", Ddo_br_procedure_surgeryid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_surgeryid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV17TFBR_Procedure_SurgeryID = (long)(NumberUtil.Val( Ddo_br_procedure_surgeryid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Procedure_SurgeryID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Procedure_SurgeryID), 18, 0)));
            AV18TFBR_Procedure_SurgeryID_To = (long)(NumberUtil.Val( Ddo_br_procedure_surgeryid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Procedure_SurgeryID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Procedure_SurgeryID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Procedure_SurgeryIDTitleFilterData", AV16BR_Procedure_SurgeryIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_ProcedureIDTitleFilterData", AV20BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Procedure_Surgery_NameTitleFilterData", AV24BR_Procedure_Surgery_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Procedure_Surgery_LocTitleFilterData", AV28BR_Procedure_Surgery_LocTitleFilterData);
      }

      protected void E14662( )
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
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Procedure_SurgeryIDTitleFilterData", AV16BR_Procedure_SurgeryIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_ProcedureIDTitleFilterData", AV20BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Procedure_Surgery_NameTitleFilterData", AV24BR_Procedure_Surgery_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Procedure_Surgery_LocTitleFilterData", AV28BR_Procedure_Surgery_LocTitleFilterData);
      }

      protected void E15662( )
      {
         /* Ddo_br_procedure_surgery_name_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedure_surgery_name_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_procedure_surgery_name_Sortedstatus = "ASC";
            ucDdo_br_procedure_surgery_name.SendProperty(context, "", false, Ddo_br_procedure_surgery_name_Internalname, "SortedStatus", Ddo_br_procedure_surgery_name_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_surgery_name_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_procedure_surgery_name_Sortedstatus = "DSC";
            ucDdo_br_procedure_surgery_name.SendProperty(context, "", false, Ddo_br_procedure_surgery_name_Internalname, "SortedStatus", Ddo_br_procedure_surgery_name_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_surgery_name_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV25TFBR_Procedure_Surgery_Name = Ddo_br_procedure_surgery_name_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_Procedure_Surgery_Name", AV25TFBR_Procedure_Surgery_Name);
            AV26TFBR_Procedure_Surgery_Name_Sel = Ddo_br_procedure_surgery_name_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_Procedure_Surgery_Name_Sel", AV26TFBR_Procedure_Surgery_Name_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Procedure_SurgeryIDTitleFilterData", AV16BR_Procedure_SurgeryIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_ProcedureIDTitleFilterData", AV20BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Procedure_Surgery_NameTitleFilterData", AV24BR_Procedure_Surgery_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Procedure_Surgery_LocTitleFilterData", AV28BR_Procedure_Surgery_LocTitleFilterData);
      }

      protected void E16662( )
      {
         /* Ddo_br_procedure_surgery_loc_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedure_surgery_loc_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_procedure_surgery_loc_Sortedstatus = "ASC";
            ucDdo_br_procedure_surgery_loc.SendProperty(context, "", false, Ddo_br_procedure_surgery_loc_Internalname, "SortedStatus", Ddo_br_procedure_surgery_loc_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_surgery_loc_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_procedure_surgery_loc_Sortedstatus = "DSC";
            ucDdo_br_procedure_surgery_loc.SendProperty(context, "", false, Ddo_br_procedure_surgery_loc_Internalname, "SortedStatus", Ddo_br_procedure_surgery_loc_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_surgery_loc_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV29TFBR_Procedure_Surgery_Loc = Ddo_br_procedure_surgery_loc_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_Procedure_Surgery_Loc", AV29TFBR_Procedure_Surgery_Loc);
            AV30TFBR_Procedure_Surgery_Loc_Sel = Ddo_br_procedure_surgery_loc_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_Procedure_Surgery_Loc_Sel", AV30TFBR_Procedure_Surgery_Loc_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Procedure_SurgeryIDTitleFilterData", AV16BR_Procedure_SurgeryIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_ProcedureIDTitleFilterData", AV20BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Procedure_Surgery_NameTitleFilterData", AV24BR_Procedure_Surgery_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Procedure_Surgery_LocTitleFilterData", AV28BR_Procedure_Surgery_LocTitleFilterData);
      }

      private void E20662( )
      {
         /* Grid_Load Routine */
         AV37Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDisplay_Internalname, AV37Display);
         AV55Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = formatLink("br_procedure_surgeryview.aspx") + "?" + UrlEncode("" +A320BR_Procedure_SurgeryID) + "," + UrlEncode(StringUtil.RTrim(""));
         AV38Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV38Update);
         AV56Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavUpdate_Tooltiptext = "修改";
         if ( AV39IsAuthorized_Update )
         {
            edtavUpdate_Link = formatLink("br_procedure_surgery.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A320BR_Procedure_SurgeryID);
         }
         AV40Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV40Delete);
         AV57Delete_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavDelete_Tooltiptext = "删除";
         if ( AV41IsAuthorized_Delete )
         {
            edtavDelete_Link = formatLink("br_procedure_surgery.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A320BR_Procedure_SurgeryID);
         }
         edtBR_Procedure_Surgery_Name_Link = formatLink("br_procedure_surgeryview.aspx") + "?" + UrlEncode("" +A320BR_Procedure_SurgeryID) + "," + UrlEncode(StringUtil.RTrim(""));
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

      protected void E17662( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("br_procedure_surgery.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S162( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_br_procedure_surgeryid_Sortedstatus = "";
         ucDdo_br_procedure_surgeryid.SendProperty(context, "", false, Ddo_br_procedure_surgeryid_Internalname, "SortedStatus", Ddo_br_procedure_surgeryid_Sortedstatus);
         Ddo_br_procedureid_Sortedstatus = "";
         ucDdo_br_procedureid.SendProperty(context, "", false, Ddo_br_procedureid_Internalname, "SortedStatus", Ddo_br_procedureid_Sortedstatus);
         Ddo_br_procedure_surgery_name_Sortedstatus = "";
         ucDdo_br_procedure_surgery_name.SendProperty(context, "", false, Ddo_br_procedure_surgery_name_Internalname, "SortedStatus", Ddo_br_procedure_surgery_name_Sortedstatus);
         Ddo_br_procedure_surgery_loc_Sortedstatus = "";
         ucDdo_br_procedure_surgery_loc.SendProperty(context, "", false, Ddo_br_procedure_surgery_loc_Internalname, "SortedStatus", Ddo_br_procedure_surgery_loc_Sortedstatus);
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
            Ddo_br_procedure_surgeryid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_procedure_surgeryid.SendProperty(context, "", false, Ddo_br_procedure_surgeryid_Internalname, "SortedStatus", Ddo_br_procedure_surgeryid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 2 )
         {
            Ddo_br_procedureid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_procedureid.SendProperty(context, "", false, Ddo_br_procedureid_Internalname, "SortedStatus", Ddo_br_procedureid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 3 )
         {
            Ddo_br_procedure_surgery_name_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_procedure_surgery_name.SendProperty(context, "", false, Ddo_br_procedure_surgery_name_Internalname, "SortedStatus", Ddo_br_procedure_surgery_name_Sortedstatus);
         }
         else if ( AV13OrderedBy == 4 )
         {
            Ddo_br_procedure_surgery_loc_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_procedure_surgery_loc.SendProperty(context, "", false, Ddo_br_procedure_surgery_loc_Internalname, "SortedStatus", Ddo_br_procedure_surgery_loc_Sortedstatus);
         }
      }

      protected void S142( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean2 = AV39IsAuthorized_Update;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Procedure_Surgery", out  GXt_boolean2) ;
         AV39IsAuthorized_Update = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39IsAuthorized_Update", AV39IsAuthorized_Update);
         if ( ! ( AV39IsAuthorized_Update ) )
         {
            edtavUpdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_31_Refreshing);
         }
         GXt_boolean2 = AV41IsAuthorized_Delete;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Procedure_Surgery", out  GXt_boolean2) ;
         AV41IsAuthorized_Delete = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41IsAuthorized_Delete", AV41IsAuthorized_Delete);
         if ( ! ( AV41IsAuthorized_Delete ) )
         {
            edtavDelete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Visible), 5, 0)), !bGXsfl_31_Refreshing);
         }
         GXt_boolean2 = AV42TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Procedure_Surgery", out  GXt_boolean2) ;
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
         if ( StringUtil.StrCmp(AV15Session.Get(AV58Pgmname+"GridState"), "") == 0 )
         {
            AV11GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV58Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV11GridState.FromXml(AV15Session.Get(AV58Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
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
         AV59GXV1 = 1;
         while ( AV59GXV1 <= AV11GridState.gxTpr_Filtervalues.Count )
         {
            AV12GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV11GridState.gxTpr_Filtervalues.Item(AV59GXV1));
            if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_SURGERYID") == 0 )
            {
               AV17TFBR_Procedure_SurgeryID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Procedure_SurgeryID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Procedure_SurgeryID), 18, 0)));
               AV18TFBR_Procedure_SurgeryID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Procedure_SurgeryID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Procedure_SurgeryID_To), 18, 0)));
               if ( ! (0==AV17TFBR_Procedure_SurgeryID) )
               {
                  Ddo_br_procedure_surgeryid_Filteredtext_set = StringUtil.Str( (decimal)(AV17TFBR_Procedure_SurgeryID), 18, 0);
                  ucDdo_br_procedure_surgeryid.SendProperty(context, "", false, Ddo_br_procedure_surgeryid_Internalname, "FilteredText_set", Ddo_br_procedure_surgeryid_Filteredtext_set);
               }
               if ( ! (0==AV18TFBR_Procedure_SurgeryID_To) )
               {
                  Ddo_br_procedure_surgeryid_Filteredtextto_set = StringUtil.Str( (decimal)(AV18TFBR_Procedure_SurgeryID_To), 18, 0);
                  ucDdo_br_procedure_surgeryid.SendProperty(context, "", false, Ddo_br_procedure_surgeryid_Internalname, "FilteredTextTo_set", Ddo_br_procedure_surgeryid_Filteredtextto_set);
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
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_SURGERY_NAME") == 0 )
            {
               AV25TFBR_Procedure_Surgery_Name = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_Procedure_Surgery_Name", AV25TFBR_Procedure_Surgery_Name);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV25TFBR_Procedure_Surgery_Name)) )
               {
                  Ddo_br_procedure_surgery_name_Filteredtext_set = AV25TFBR_Procedure_Surgery_Name;
                  ucDdo_br_procedure_surgery_name.SendProperty(context, "", false, Ddo_br_procedure_surgery_name_Internalname, "FilteredText_set", Ddo_br_procedure_surgery_name_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_SURGERY_NAME_SEL") == 0 )
            {
               AV26TFBR_Procedure_Surgery_Name_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_Procedure_Surgery_Name_Sel", AV26TFBR_Procedure_Surgery_Name_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26TFBR_Procedure_Surgery_Name_Sel)) )
               {
                  Ddo_br_procedure_surgery_name_Selectedvalue_set = AV26TFBR_Procedure_Surgery_Name_Sel;
                  ucDdo_br_procedure_surgery_name.SendProperty(context, "", false, Ddo_br_procedure_surgery_name_Internalname, "SelectedValue_set", Ddo_br_procedure_surgery_name_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_SURGERY_LOC") == 0 )
            {
               AV29TFBR_Procedure_Surgery_Loc = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_Procedure_Surgery_Loc", AV29TFBR_Procedure_Surgery_Loc);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV29TFBR_Procedure_Surgery_Loc)) )
               {
                  Ddo_br_procedure_surgery_loc_Filteredtext_set = AV29TFBR_Procedure_Surgery_Loc;
                  ucDdo_br_procedure_surgery_loc.SendProperty(context, "", false, Ddo_br_procedure_surgery_loc_Internalname, "FilteredText_set", Ddo_br_procedure_surgery_loc_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_SURGERY_LOC_SEL") == 0 )
            {
               AV30TFBR_Procedure_Surgery_Loc_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_Procedure_Surgery_Loc_Sel", AV30TFBR_Procedure_Surgery_Loc_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV30TFBR_Procedure_Surgery_Loc_Sel)) )
               {
                  Ddo_br_procedure_surgery_loc_Selectedvalue_set = AV30TFBR_Procedure_Surgery_Loc_Sel;
                  ucDdo_br_procedure_surgery_loc.SendProperty(context, "", false, Ddo_br_procedure_surgery_loc_Internalname, "SelectedValue_set", Ddo_br_procedure_surgery_loc_Selectedvalue_set);
               }
            }
            AV59GXV1 = (int)(AV59GXV1+1);
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
         AV11GridState.FromXml(AV15Session.Get(AV58Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV11GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV11GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV11GridState.gxTpr_Filtervalues.Clear();
         if ( ! ( (0==AV17TFBR_Procedure_SurgeryID) && (0==AV18TFBR_Procedure_SurgeryID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PROCEDURE_SURGERYID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV17TFBR_Procedure_SurgeryID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV18TFBR_Procedure_SurgeryID_To), 18, 0);
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
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV25TFBR_Procedure_Surgery_Name)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PROCEDURE_SURGERY_NAME";
            AV12GridStateFilterValue.gxTpr_Value = AV25TFBR_Procedure_Surgery_Name;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26TFBR_Procedure_Surgery_Name_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PROCEDURE_SURGERY_NAME_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV26TFBR_Procedure_Surgery_Name_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV29TFBR_Procedure_Surgery_Loc)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PROCEDURE_SURGERY_LOC";
            AV12GridStateFilterValue.gxTpr_Value = AV29TFBR_Procedure_Surgery_Loc;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV30TFBR_Procedure_Surgery_Loc_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PROCEDURE_SURGERY_LOC_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV30TFBR_Procedure_Surgery_Loc_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         AV11GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV11GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV58Pgmname+"GridState",  AV11GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV58Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Procedure_Surgery";
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
         PA662( ) ;
         WS662( ) ;
         WE662( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202271245290", true);
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
         context.AddJavascriptSource("br_procedure_surgeryww.js", "?20202271245291", false);
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
         edtBR_Procedure_SurgeryID_Internalname = "BR_PROCEDURE_SURGERYID_"+sGXsfl_31_idx;
         edtBR_ProcedureID_Internalname = "BR_PROCEDUREID_"+sGXsfl_31_idx;
         edtBR_Procedure_Surgery_Name_Internalname = "BR_PROCEDURE_SURGERY_NAME_"+sGXsfl_31_idx;
         edtBR_Procedure_Surgery_Loc_Internalname = "BR_PROCEDURE_SURGERY_LOC_"+sGXsfl_31_idx;
      }

      protected void SubsflControlProps_fel_312( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_31_fel_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_31_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_31_fel_idx;
         edtBR_Procedure_SurgeryID_Internalname = "BR_PROCEDURE_SURGERYID_"+sGXsfl_31_fel_idx;
         edtBR_ProcedureID_Internalname = "BR_PROCEDUREID_"+sGXsfl_31_fel_idx;
         edtBR_Procedure_Surgery_Name_Internalname = "BR_PROCEDURE_SURGERY_NAME_"+sGXsfl_31_fel_idx;
         edtBR_Procedure_Surgery_Loc_Internalname = "BR_PROCEDURE_SURGERY_LOC_"+sGXsfl_31_fel_idx;
      }

      protected void sendrow_312( )
      {
         SubsflControlProps_312( ) ;
         WB660( ) ;
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
            AV37Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV37Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV55Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV37Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV37Display)) ? AV55Display_GXI : context.PathToRelativeUrl( AV37Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV37Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV38Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV38Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV56Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV38Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV38Update)) ? AV56Update_GXI : context.PathToRelativeUrl( AV38Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavUpdate_Visible,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV38Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "DeleteAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV40Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV40Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV57Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV40Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV40Delete)) ? AV57Delete_GXI : context.PathToRelativeUrl( AV40Delete));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)edtavDelete_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavDelete_Visible,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV40Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Procedure_SurgeryID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A320BR_Procedure_SurgeryID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A320BR_Procedure_SurgeryID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Procedure_SurgeryID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
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
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Procedure_Surgery_Name_Internalname,(String)A321BR_Procedure_Surgery_Name,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtBR_Procedure_Surgery_Name_Link,(String)"",(String)"",(String)"",(String)edtBR_Procedure_Surgery_Name_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Procedure_Surgery_Loc_Internalname,(String)A322BR_Procedure_Surgery_Loc,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Procedure_Surgery_Loc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes662( ) ;
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
         edtBR_Procedure_SurgeryID_Internalname = "BR_PROCEDURE_SURGERYID";
         edtBR_ProcedureID_Internalname = "BR_PROCEDUREID";
         edtBR_Procedure_Surgery_Name_Internalname = "BR_PROCEDURE_SURGERY_NAME";
         edtBR_Procedure_Surgery_Loc_Internalname = "BR_PROCEDURE_SURGERY_LOC";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_procedure_surgeryid_Internalname = "DDO_BR_PROCEDURE_SURGERYID";
         edtavDdo_br_procedure_surgeryidtitlecontrolidtoreplace_Internalname = "vDDO_BR_PROCEDURE_SURGERYIDTITLECONTROLIDTOREPLACE";
         Ddo_br_procedureid_Internalname = "DDO_BR_PROCEDUREID";
         edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname = "vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE";
         Ddo_br_procedure_surgery_name_Internalname = "DDO_BR_PROCEDURE_SURGERY_NAME";
         edtavDdo_br_procedure_surgery_nametitlecontrolidtoreplace_Internalname = "vDDO_BR_PROCEDURE_SURGERY_NAMETITLECONTROLIDTOREPLACE";
         Ddo_br_procedure_surgery_loc_Internalname = "DDO_BR_PROCEDURE_SURGERY_LOC";
         edtavDdo_br_procedure_surgery_loctitlecontrolidtoreplace_Internalname = "vDDO_BR_PROCEDURE_SURGERY_LOCTITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         edtavTfbr_procedure_surgeryid_Internalname = "vTFBR_PROCEDURE_SURGERYID";
         edtavTfbr_procedure_surgeryid_to_Internalname = "vTFBR_PROCEDURE_SURGERYID_TO";
         edtavTfbr_procedureid_Internalname = "vTFBR_PROCEDUREID";
         edtavTfbr_procedureid_to_Internalname = "vTFBR_PROCEDUREID_TO";
         edtavTfbr_procedure_surgery_name_Internalname = "vTFBR_PROCEDURE_SURGERY_NAME";
         edtavTfbr_procedure_surgery_name_sel_Internalname = "vTFBR_PROCEDURE_SURGERY_NAME_SEL";
         edtavTfbr_procedure_surgery_loc_Internalname = "vTFBR_PROCEDURE_SURGERY_LOC";
         edtavTfbr_procedure_surgery_loc_sel_Internalname = "vTFBR_PROCEDURE_SURGERY_LOC_SEL";
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
         edtBR_Procedure_Surgery_Loc_Jsonclick = "";
         edtBR_Procedure_Surgery_Name_Jsonclick = "";
         edtBR_ProcedureID_Jsonclick = "";
         edtBR_Procedure_SurgeryID_Jsonclick = "";
         edtavTfbr_procedure_surgery_loc_sel_Jsonclick = "";
         edtavTfbr_procedure_surgery_loc_sel_Visible = 1;
         edtavTfbr_procedure_surgery_loc_Jsonclick = "";
         edtavTfbr_procedure_surgery_loc_Visible = 1;
         edtavTfbr_procedure_surgery_name_sel_Jsonclick = "";
         edtavTfbr_procedure_surgery_name_sel_Visible = 1;
         edtavTfbr_procedure_surgery_name_Jsonclick = "";
         edtavTfbr_procedure_surgery_name_Visible = 1;
         edtavTfbr_procedureid_to_Jsonclick = "";
         edtavTfbr_procedureid_to_Visible = 1;
         edtavTfbr_procedureid_Jsonclick = "";
         edtavTfbr_procedureid_Visible = 1;
         edtavTfbr_procedure_surgeryid_to_Jsonclick = "";
         edtavTfbr_procedure_surgeryid_to_Visible = 1;
         edtavTfbr_procedure_surgeryid_Jsonclick = "";
         edtavTfbr_procedure_surgeryid_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_procedure_surgery_loctitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_procedure_surgery_nametitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_procedure_surgeryidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtBR_Procedure_Surgery_Name_Link = "";
         edtavDelete_Tooltiptext = "删除";
         edtavDelete_Link = "";
         edtavUpdate_Tooltiptext = "修改";
         edtavUpdate_Link = "";
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Procedure_Surgery_Loc_Titleformat = 0;
         edtBR_Procedure_Surgery_Loc_Title = "手术部位";
         edtBR_Procedure_Surgery_Name_Titleformat = 0;
         edtBR_Procedure_Surgery_Name_Title = "手术名称";
         edtBR_ProcedureID_Titleformat = 0;
         edtBR_ProcedureID_Title = "诊疗处理主键";
         edtBR_Procedure_SurgeryID_Titleformat = 0;
         edtBR_Procedure_SurgeryID_Title = "主键";
         edtavDelete_Visible = -1;
         edtavUpdate_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         bttBtninsert_Visible = 1;
         Ddo_br_procedure_surgery_loc_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_procedure_surgery_loc_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_procedure_surgery_loc_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_procedure_surgery_loc_Loadingdata = "WWP_TSLoading";
         Ddo_br_procedure_surgery_loc_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_procedure_surgery_loc_Sortasc = "WWP_TSSortASC";
         Ddo_br_procedure_surgery_loc_Datalistupdateminimumcharacters = 0;
         Ddo_br_procedure_surgery_loc_Datalistproc = "BR_Procedure_SurgeryWWGetFilterData";
         Ddo_br_procedure_surgery_loc_Datalisttype = "Dynamic";
         Ddo_br_procedure_surgery_loc_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_procedure_surgery_loc_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_procedure_surgery_loc_Filtertype = "Character";
         Ddo_br_procedure_surgery_loc_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_procedure_surgery_loc_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_procedure_surgery_loc_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_procedure_surgery_loc_Titlecontrolidtoreplace = "";
         Ddo_br_procedure_surgery_loc_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_procedure_surgery_loc_Cls = "ColumnSettings";
         Ddo_br_procedure_surgery_loc_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_procedure_surgery_loc_Caption = "";
         Ddo_br_procedure_surgery_name_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_procedure_surgery_name_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_procedure_surgery_name_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_procedure_surgery_name_Loadingdata = "WWP_TSLoading";
         Ddo_br_procedure_surgery_name_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_procedure_surgery_name_Sortasc = "WWP_TSSortASC";
         Ddo_br_procedure_surgery_name_Datalistupdateminimumcharacters = 0;
         Ddo_br_procedure_surgery_name_Datalistproc = "BR_Procedure_SurgeryWWGetFilterData";
         Ddo_br_procedure_surgery_name_Datalisttype = "Dynamic";
         Ddo_br_procedure_surgery_name_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_procedure_surgery_name_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_procedure_surgery_name_Filtertype = "Character";
         Ddo_br_procedure_surgery_name_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_procedure_surgery_name_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_procedure_surgery_name_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_procedure_surgery_name_Titlecontrolidtoreplace = "";
         Ddo_br_procedure_surgery_name_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_procedure_surgery_name_Cls = "ColumnSettings";
         Ddo_br_procedure_surgery_name_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_procedure_surgery_name_Caption = "";
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
         Ddo_br_procedure_surgeryid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_procedure_surgeryid_Rangefilterto = "WWP_TSTo";
         Ddo_br_procedure_surgeryid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_procedure_surgeryid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_procedure_surgeryid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_procedure_surgeryid_Sortasc = "WWP_TSSortASC";
         Ddo_br_procedure_surgeryid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_procedure_surgeryid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_procedure_surgeryid_Filtertype = "Numeric";
         Ddo_br_procedure_surgeryid_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_procedure_surgeryid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_procedure_surgeryid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_procedure_surgeryid_Titlecontrolidtoreplace = "";
         Ddo_br_procedure_surgeryid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_procedure_surgeryid_Cls = "ColumnSettings";
         Ddo_br_procedure_surgeryid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_procedure_surgeryid_Caption = "";
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
         Form.Caption = " 诊疗处理手术信息";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV17TFBR_Procedure_SurgeryID',fld:'vTFBR_PROCEDURE_SURGERYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_SurgeryID_To',fld:'vTFBR_PROCEDURE_SURGERYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Procedure_Surgery_Name',fld:'vTFBR_PROCEDURE_SURGERY_NAME',pic:''},{av:'AV26TFBR_Procedure_Surgery_Name_Sel',fld:'vTFBR_PROCEDURE_SURGERY_NAME_SEL',pic:''},{av:'AV29TFBR_Procedure_Surgery_Loc',fld:'vTFBR_PROCEDURE_SURGERY_LOC',pic:''},{av:'AV30TFBR_Procedure_Surgery_Loc_Sel',fld:'vTFBR_PROCEDURE_SURGERY_LOC_SEL',pic:''},{av:'AV58Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV16BR_Procedure_SurgeryIDTitleFilterData',fld:'vBR_PROCEDURE_SURGERYIDTITLEFILTERDATA',pic:''},{av:'AV20BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Procedure_Surgery_NameTitleFilterData',fld:'vBR_PROCEDURE_SURGERY_NAMETITLEFILTERDATA',pic:''},{av:'AV28BR_Procedure_Surgery_LocTitleFilterData',fld:'vBR_PROCEDURE_SURGERY_LOCTITLEFILTERDATA',pic:''},{av:'edtBR_Procedure_SurgeryID_Titleformat',ctrl:'BR_PROCEDURE_SURGERYID',prop:'Titleformat'},{av:'edtBR_Procedure_SurgeryID_Title',ctrl:'BR_PROCEDURE_SURGERYID',prop:'Title'},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_Procedure_Surgery_Name_Titleformat',ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Titleformat'},{av:'edtBR_Procedure_Surgery_Name_Title',ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Title'},{av:'edtBR_Procedure_Surgery_Loc_Titleformat',ctrl:'BR_PROCEDURE_SURGERY_LOC',prop:'Titleformat'},{av:'edtBR_Procedure_Surgery_Loc_Title',ctrl:'BR_PROCEDURE_SURGERY_LOC',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E11662',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Procedure_SurgeryID',fld:'vTFBR_PROCEDURE_SURGERYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_SurgeryID_To',fld:'vTFBR_PROCEDURE_SURGERYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Procedure_Surgery_Name',fld:'vTFBR_PROCEDURE_SURGERY_NAME',pic:''},{av:'AV26TFBR_Procedure_Surgery_Name_Sel',fld:'vTFBR_PROCEDURE_SURGERY_NAME_SEL',pic:''},{av:'AV29TFBR_Procedure_Surgery_Loc',fld:'vTFBR_PROCEDURE_SURGERY_LOC',pic:''},{av:'AV30TFBR_Procedure_Surgery_Loc_Sel',fld:'vTFBR_PROCEDURE_SURGERY_LOC_SEL',pic:''},{av:'AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E12662',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Procedure_SurgeryID',fld:'vTFBR_PROCEDURE_SURGERYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_SurgeryID_To',fld:'vTFBR_PROCEDURE_SURGERYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Procedure_Surgery_Name',fld:'vTFBR_PROCEDURE_SURGERY_NAME',pic:''},{av:'AV26TFBR_Procedure_Surgery_Name_Sel',fld:'vTFBR_PROCEDURE_SURGERY_NAME_SEL',pic:''},{av:'AV29TFBR_Procedure_Surgery_Loc',fld:'vTFBR_PROCEDURE_SURGERY_LOC',pic:''},{av:'AV30TFBR_Procedure_Surgery_Loc_Sel',fld:'vTFBR_PROCEDURE_SURGERY_LOC_SEL',pic:''},{av:'AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_PROCEDURE_SURGERYID.ONOPTIONCLICKED","{handler:'E13662',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Procedure_SurgeryID',fld:'vTFBR_PROCEDURE_SURGERYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_SurgeryID_To',fld:'vTFBR_PROCEDURE_SURGERYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Procedure_Surgery_Name',fld:'vTFBR_PROCEDURE_SURGERY_NAME',pic:''},{av:'AV26TFBR_Procedure_Surgery_Name_Sel',fld:'vTFBR_PROCEDURE_SURGERY_NAME_SEL',pic:''},{av:'AV29TFBR_Procedure_Surgery_Loc',fld:'vTFBR_PROCEDURE_SURGERY_LOC',pic:''},{av:'AV30TFBR_Procedure_Surgery_Loc_Sel',fld:'vTFBR_PROCEDURE_SURGERY_LOC_SEL',pic:''},{av:'AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_procedure_surgeryid_Activeeventkey',ctrl:'DDO_BR_PROCEDURE_SURGERYID',prop:'ActiveEventKey'},{av:'Ddo_br_procedure_surgeryid_Filteredtext_get',ctrl:'DDO_BR_PROCEDURE_SURGERYID',prop:'FilteredText_get'},{av:'Ddo_br_procedure_surgeryid_Filteredtextto_get',ctrl:'DDO_BR_PROCEDURE_SURGERYID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_PROCEDURE_SURGERYID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedure_surgeryid_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_SURGERYID',prop:'SortedStatus'},{av:'AV17TFBR_Procedure_SurgeryID',fld:'vTFBR_PROCEDURE_SURGERYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_SurgeryID_To',fld:'vTFBR_PROCEDURE_SURGERYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_procedureid_Sortedstatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'Ddo_br_procedure_surgery_name_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_SURGERY_NAME',prop:'SortedStatus'},{av:'Ddo_br_procedure_surgery_loc_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_SURGERY_LOC',prop:'SortedStatus'},{av:'AV16BR_Procedure_SurgeryIDTitleFilterData',fld:'vBR_PROCEDURE_SURGERYIDTITLEFILTERDATA',pic:''},{av:'AV20BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Procedure_Surgery_NameTitleFilterData',fld:'vBR_PROCEDURE_SURGERY_NAMETITLEFILTERDATA',pic:''},{av:'AV28BR_Procedure_Surgery_LocTitleFilterData',fld:'vBR_PROCEDURE_SURGERY_LOCTITLEFILTERDATA',pic:''},{av:'edtBR_Procedure_SurgeryID_Titleformat',ctrl:'BR_PROCEDURE_SURGERYID',prop:'Titleformat'},{av:'edtBR_Procedure_SurgeryID_Title',ctrl:'BR_PROCEDURE_SURGERYID',prop:'Title'},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_Procedure_Surgery_Name_Titleformat',ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Titleformat'},{av:'edtBR_Procedure_Surgery_Name_Title',ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Title'},{av:'edtBR_Procedure_Surgery_Loc_Titleformat',ctrl:'BR_PROCEDURE_SURGERY_LOC',prop:'Titleformat'},{av:'edtBR_Procedure_Surgery_Loc_Title',ctrl:'BR_PROCEDURE_SURGERY_LOC',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PROCEDUREID.ONOPTIONCLICKED","{handler:'E14662',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Procedure_SurgeryID',fld:'vTFBR_PROCEDURE_SURGERYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_SurgeryID_To',fld:'vTFBR_PROCEDURE_SURGERYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Procedure_Surgery_Name',fld:'vTFBR_PROCEDURE_SURGERY_NAME',pic:''},{av:'AV26TFBR_Procedure_Surgery_Name_Sel',fld:'vTFBR_PROCEDURE_SURGERY_NAME_SEL',pic:''},{av:'AV29TFBR_Procedure_Surgery_Loc',fld:'vTFBR_PROCEDURE_SURGERY_LOC',pic:''},{av:'AV30TFBR_Procedure_Surgery_Loc_Sel',fld:'vTFBR_PROCEDURE_SURGERY_LOC_SEL',pic:''},{av:'AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_procedureid_Activeeventkey',ctrl:'DDO_BR_PROCEDUREID',prop:'ActiveEventKey'},{av:'Ddo_br_procedureid_Filteredtext_get',ctrl:'DDO_BR_PROCEDUREID',prop:'FilteredText_get'},{av:'Ddo_br_procedureid_Filteredtextto_get',ctrl:'DDO_BR_PROCEDUREID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_PROCEDUREID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedureid_Sortedstatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_procedure_surgeryid_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_SURGERYID',prop:'SortedStatus'},{av:'Ddo_br_procedure_surgery_name_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_SURGERY_NAME',prop:'SortedStatus'},{av:'Ddo_br_procedure_surgery_loc_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_SURGERY_LOC',prop:'SortedStatus'},{av:'AV16BR_Procedure_SurgeryIDTitleFilterData',fld:'vBR_PROCEDURE_SURGERYIDTITLEFILTERDATA',pic:''},{av:'AV20BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Procedure_Surgery_NameTitleFilterData',fld:'vBR_PROCEDURE_SURGERY_NAMETITLEFILTERDATA',pic:''},{av:'AV28BR_Procedure_Surgery_LocTitleFilterData',fld:'vBR_PROCEDURE_SURGERY_LOCTITLEFILTERDATA',pic:''},{av:'edtBR_Procedure_SurgeryID_Titleformat',ctrl:'BR_PROCEDURE_SURGERYID',prop:'Titleformat'},{av:'edtBR_Procedure_SurgeryID_Title',ctrl:'BR_PROCEDURE_SURGERYID',prop:'Title'},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_Procedure_Surgery_Name_Titleformat',ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Titleformat'},{av:'edtBR_Procedure_Surgery_Name_Title',ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Title'},{av:'edtBR_Procedure_Surgery_Loc_Titleformat',ctrl:'BR_PROCEDURE_SURGERY_LOC',prop:'Titleformat'},{av:'edtBR_Procedure_Surgery_Loc_Title',ctrl:'BR_PROCEDURE_SURGERY_LOC',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PROCEDURE_SURGERY_NAME.ONOPTIONCLICKED","{handler:'E15662',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Procedure_SurgeryID',fld:'vTFBR_PROCEDURE_SURGERYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_SurgeryID_To',fld:'vTFBR_PROCEDURE_SURGERYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Procedure_Surgery_Name',fld:'vTFBR_PROCEDURE_SURGERY_NAME',pic:''},{av:'AV26TFBR_Procedure_Surgery_Name_Sel',fld:'vTFBR_PROCEDURE_SURGERY_NAME_SEL',pic:''},{av:'AV29TFBR_Procedure_Surgery_Loc',fld:'vTFBR_PROCEDURE_SURGERY_LOC',pic:''},{av:'AV30TFBR_Procedure_Surgery_Loc_Sel',fld:'vTFBR_PROCEDURE_SURGERY_LOC_SEL',pic:''},{av:'AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_procedure_surgery_name_Activeeventkey',ctrl:'DDO_BR_PROCEDURE_SURGERY_NAME',prop:'ActiveEventKey'},{av:'Ddo_br_procedure_surgery_name_Filteredtext_get',ctrl:'DDO_BR_PROCEDURE_SURGERY_NAME',prop:'FilteredText_get'},{av:'Ddo_br_procedure_surgery_name_Selectedvalue_get',ctrl:'DDO_BR_PROCEDURE_SURGERY_NAME',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_PROCEDURE_SURGERY_NAME.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedure_surgery_name_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_SURGERY_NAME',prop:'SortedStatus'},{av:'AV25TFBR_Procedure_Surgery_Name',fld:'vTFBR_PROCEDURE_SURGERY_NAME',pic:''},{av:'AV26TFBR_Procedure_Surgery_Name_Sel',fld:'vTFBR_PROCEDURE_SURGERY_NAME_SEL',pic:''},{av:'Ddo_br_procedure_surgeryid_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_SURGERYID',prop:'SortedStatus'},{av:'Ddo_br_procedureid_Sortedstatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'Ddo_br_procedure_surgery_loc_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_SURGERY_LOC',prop:'SortedStatus'},{av:'AV16BR_Procedure_SurgeryIDTitleFilterData',fld:'vBR_PROCEDURE_SURGERYIDTITLEFILTERDATA',pic:''},{av:'AV20BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Procedure_Surgery_NameTitleFilterData',fld:'vBR_PROCEDURE_SURGERY_NAMETITLEFILTERDATA',pic:''},{av:'AV28BR_Procedure_Surgery_LocTitleFilterData',fld:'vBR_PROCEDURE_SURGERY_LOCTITLEFILTERDATA',pic:''},{av:'edtBR_Procedure_SurgeryID_Titleformat',ctrl:'BR_PROCEDURE_SURGERYID',prop:'Titleformat'},{av:'edtBR_Procedure_SurgeryID_Title',ctrl:'BR_PROCEDURE_SURGERYID',prop:'Title'},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_Procedure_Surgery_Name_Titleformat',ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Titleformat'},{av:'edtBR_Procedure_Surgery_Name_Title',ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Title'},{av:'edtBR_Procedure_Surgery_Loc_Titleformat',ctrl:'BR_PROCEDURE_SURGERY_LOC',prop:'Titleformat'},{av:'edtBR_Procedure_Surgery_Loc_Title',ctrl:'BR_PROCEDURE_SURGERY_LOC',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PROCEDURE_SURGERY_LOC.ONOPTIONCLICKED","{handler:'E16662',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Procedure_SurgeryID',fld:'vTFBR_PROCEDURE_SURGERYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Procedure_SurgeryID_To',fld:'vTFBR_PROCEDURE_SURGERYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Procedure_Surgery_Name',fld:'vTFBR_PROCEDURE_SURGERY_NAME',pic:''},{av:'AV26TFBR_Procedure_Surgery_Name_Sel',fld:'vTFBR_PROCEDURE_SURGERY_NAME_SEL',pic:''},{av:'AV29TFBR_Procedure_Surgery_Loc',fld:'vTFBR_PROCEDURE_SURGERY_LOC',pic:''},{av:'AV30TFBR_Procedure_Surgery_Loc_Sel',fld:'vTFBR_PROCEDURE_SURGERY_LOC_SEL',pic:''},{av:'AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_SURGERY_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_procedure_surgery_loc_Activeeventkey',ctrl:'DDO_BR_PROCEDURE_SURGERY_LOC',prop:'ActiveEventKey'},{av:'Ddo_br_procedure_surgery_loc_Filteredtext_get',ctrl:'DDO_BR_PROCEDURE_SURGERY_LOC',prop:'FilteredText_get'},{av:'Ddo_br_procedure_surgery_loc_Selectedvalue_get',ctrl:'DDO_BR_PROCEDURE_SURGERY_LOC',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_PROCEDURE_SURGERY_LOC.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedure_surgery_loc_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_SURGERY_LOC',prop:'SortedStatus'},{av:'AV29TFBR_Procedure_Surgery_Loc',fld:'vTFBR_PROCEDURE_SURGERY_LOC',pic:''},{av:'AV30TFBR_Procedure_Surgery_Loc_Sel',fld:'vTFBR_PROCEDURE_SURGERY_LOC_SEL',pic:''},{av:'Ddo_br_procedure_surgeryid_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_SURGERYID',prop:'SortedStatus'},{av:'Ddo_br_procedureid_Sortedstatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'Ddo_br_procedure_surgery_name_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_SURGERY_NAME',prop:'SortedStatus'},{av:'AV16BR_Procedure_SurgeryIDTitleFilterData',fld:'vBR_PROCEDURE_SURGERYIDTITLEFILTERDATA',pic:''},{av:'AV20BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Procedure_Surgery_NameTitleFilterData',fld:'vBR_PROCEDURE_SURGERY_NAMETITLEFILTERDATA',pic:''},{av:'AV28BR_Procedure_Surgery_LocTitleFilterData',fld:'vBR_PROCEDURE_SURGERY_LOCTITLEFILTERDATA',pic:''},{av:'edtBR_Procedure_SurgeryID_Titleformat',ctrl:'BR_PROCEDURE_SURGERYID',prop:'Titleformat'},{av:'edtBR_Procedure_SurgeryID_Title',ctrl:'BR_PROCEDURE_SURGERYID',prop:'Title'},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_Procedure_Surgery_Name_Titleformat',ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Titleformat'},{av:'edtBR_Procedure_Surgery_Name_Title',ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Title'},{av:'edtBR_Procedure_Surgery_Loc_Titleformat',ctrl:'BR_PROCEDURE_SURGERY_LOC',prop:'Titleformat'},{av:'edtBR_Procedure_Surgery_Loc_Title',ctrl:'BR_PROCEDURE_SURGERY_LOC',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E20662',iparms:[{av:'A320BR_Procedure_SurgeryID',fld:'BR_PROCEDURE_SURGERYID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV39IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV41IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV37Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'},{av:'AV38Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV40Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'},{av:'edtBR_Procedure_Surgery_Name_Link',ctrl:'BR_PROCEDURE_SURGERY_NAME',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E17662',iparms:[{av:'A320BR_Procedure_SurgeryID',fld:'BR_PROCEDURE_SURGERYID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
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
         Ddo_br_procedure_surgeryid_Activeeventkey = "";
         Ddo_br_procedure_surgeryid_Filteredtext_get = "";
         Ddo_br_procedure_surgeryid_Filteredtextto_get = "";
         Ddo_br_procedureid_Activeeventkey = "";
         Ddo_br_procedureid_Filteredtext_get = "";
         Ddo_br_procedureid_Filteredtextto_get = "";
         Ddo_br_procedure_surgery_name_Activeeventkey = "";
         Ddo_br_procedure_surgery_name_Filteredtext_get = "";
         Ddo_br_procedure_surgery_name_Selectedvalue_get = "";
         Ddo_br_procedure_surgery_loc_Activeeventkey = "";
         Ddo_br_procedure_surgery_loc_Filteredtext_get = "";
         Ddo_br_procedure_surgery_loc_Selectedvalue_get = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV25TFBR_Procedure_Surgery_Name = "";
         AV26TFBR_Procedure_Surgery_Name_Sel = "";
         AV29TFBR_Procedure_Surgery_Loc = "";
         AV30TFBR_Procedure_Surgery_Loc_Sel = "";
         AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace = "";
         AV23ddo_BR_ProcedureIDTitleControlIdToReplace = "";
         AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace = "";
         AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace = "";
         AV58Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV32DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV16BR_Procedure_SurgeryIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_ProcedureIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_Procedure_Surgery_NameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28BR_Procedure_Surgery_LocTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_procedure_surgeryid_Filteredtext_set = "";
         Ddo_br_procedure_surgeryid_Filteredtextto_set = "";
         Ddo_br_procedure_surgeryid_Sortedstatus = "";
         Ddo_br_procedureid_Filteredtext_set = "";
         Ddo_br_procedureid_Filteredtextto_set = "";
         Ddo_br_procedureid_Sortedstatus = "";
         Ddo_br_procedure_surgery_name_Filteredtext_set = "";
         Ddo_br_procedure_surgery_name_Selectedvalue_set = "";
         Ddo_br_procedure_surgery_name_Sortedstatus = "";
         Ddo_br_procedure_surgery_loc_Filteredtext_set = "";
         Ddo_br_procedure_surgery_loc_Selectedvalue_set = "";
         Ddo_br_procedure_surgery_loc_Sortedstatus = "";
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
         A321BR_Procedure_Surgery_Name = "";
         A322BR_Procedure_Surgery_Loc = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_procedure_surgeryid = new GXUserControl();
         ucDdo_br_procedureid = new GXUserControl();
         ucDdo_br_procedure_surgery_name = new GXUserControl();
         ucDdo_br_procedure_surgery_loc = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV55Display_GXI = "";
         AV56Update_GXI = "";
         AV57Delete_GXI = "";
         scmdbuf = "";
         lV51BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name = "";
         lV53BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc = "";
         AV52BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel = "";
         AV51BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name = "";
         AV54BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel = "";
         AV53BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc = "";
         H00662_A322BR_Procedure_Surgery_Loc = new String[] {""} ;
         H00662_n322BR_Procedure_Surgery_Loc = new bool[] {false} ;
         H00662_A321BR_Procedure_Surgery_Name = new String[] {""} ;
         H00662_n321BR_Procedure_Surgery_Name = new bool[] {false} ;
         H00662_A139BR_ProcedureID = new long[1] ;
         H00662_A320BR_Procedure_SurgeryID = new long[1] ;
         H00663_AGRID_nRecordCount = new long[1] ;
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_procedure_surgeryww__default(),
            new Object[][] {
                new Object[] {
               H00662_A322BR_Procedure_Surgery_Loc, H00662_n322BR_Procedure_Surgery_Loc, H00662_A321BR_Procedure_Surgery_Name, H00662_n321BR_Procedure_Surgery_Name, H00662_A139BR_ProcedureID, H00662_A320BR_Procedure_SurgeryID
               }
               , new Object[] {
               H00663_AGRID_nRecordCount
               }
            }
         );
         AV58Pgmname = "BR_Procedure_SurgeryWW";
         /* GeneXus formulas. */
         AV58Pgmname = "BR_Procedure_SurgeryWW";
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
      private short edtBR_Procedure_SurgeryID_Titleformat ;
      private short edtBR_ProcedureID_Titleformat ;
      private short edtBR_Procedure_Surgery_Name_Titleformat ;
      private short edtBR_Procedure_Surgery_Loc_Titleformat ;
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
      private int Ddo_br_procedure_surgery_name_Datalistupdateminimumcharacters ;
      private int Ddo_br_procedure_surgery_loc_Datalistupdateminimumcharacters ;
      private int bttBtninsert_Visible ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavUpdate_Visible ;
      private int edtavDelete_Visible ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_br_procedure_surgeryidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_procedure_surgery_nametitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_procedure_surgery_loctitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfbr_procedure_surgeryid_Visible ;
      private int edtavTfbr_procedure_surgeryid_to_Visible ;
      private int edtavTfbr_procedureid_Visible ;
      private int edtavTfbr_procedureid_to_Visible ;
      private int edtavTfbr_procedure_surgery_name_Visible ;
      private int edtavTfbr_procedure_surgery_name_sel_Visible ;
      private int edtavTfbr_procedure_surgery_loc_Visible ;
      private int edtavTfbr_procedure_surgery_loc_sel_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV33PageToGo ;
      private int AV59GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV17TFBR_Procedure_SurgeryID ;
      private long AV18TFBR_Procedure_SurgeryID_To ;
      private long AV21TFBR_ProcedureID ;
      private long AV22TFBR_ProcedureID_To ;
      private long AV34GridCurrentPage ;
      private long AV36GridRecordCount ;
      private long AV35GridPageSize ;
      private long A320BR_Procedure_SurgeryID ;
      private long A139BR_ProcedureID ;
      private long GRID_nCurrentRecord ;
      private long AV47BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid ;
      private long AV48BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to ;
      private long AV49BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid ;
      private long AV50BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_procedure_surgeryid_Activeeventkey ;
      private String Ddo_br_procedure_surgeryid_Filteredtext_get ;
      private String Ddo_br_procedure_surgeryid_Filteredtextto_get ;
      private String Ddo_br_procedureid_Activeeventkey ;
      private String Ddo_br_procedureid_Filteredtext_get ;
      private String Ddo_br_procedureid_Filteredtextto_get ;
      private String Ddo_br_procedure_surgery_name_Activeeventkey ;
      private String Ddo_br_procedure_surgery_name_Filteredtext_get ;
      private String Ddo_br_procedure_surgery_name_Selectedvalue_get ;
      private String Ddo_br_procedure_surgery_loc_Activeeventkey ;
      private String Ddo_br_procedure_surgery_loc_Filteredtext_get ;
      private String Ddo_br_procedure_surgery_loc_Selectedvalue_get ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_31_idx="0001" ;
      private String AV58Pgmname ;
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
      private String Ddo_br_procedure_surgeryid_Caption ;
      private String Ddo_br_procedure_surgeryid_Tooltip ;
      private String Ddo_br_procedure_surgeryid_Cls ;
      private String Ddo_br_procedure_surgeryid_Filteredtext_set ;
      private String Ddo_br_procedure_surgeryid_Filteredtextto_set ;
      private String Ddo_br_procedure_surgeryid_Dropdownoptionstype ;
      private String Ddo_br_procedure_surgeryid_Titlecontrolidtoreplace ;
      private String Ddo_br_procedure_surgeryid_Sortedstatus ;
      private String Ddo_br_procedure_surgeryid_Filtertype ;
      private String Ddo_br_procedure_surgeryid_Sortasc ;
      private String Ddo_br_procedure_surgeryid_Sortdsc ;
      private String Ddo_br_procedure_surgeryid_Cleanfilter ;
      private String Ddo_br_procedure_surgeryid_Rangefilterfrom ;
      private String Ddo_br_procedure_surgeryid_Rangefilterto ;
      private String Ddo_br_procedure_surgeryid_Searchbuttontext ;
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
      private String Ddo_br_procedure_surgery_name_Caption ;
      private String Ddo_br_procedure_surgery_name_Tooltip ;
      private String Ddo_br_procedure_surgery_name_Cls ;
      private String Ddo_br_procedure_surgery_name_Filteredtext_set ;
      private String Ddo_br_procedure_surgery_name_Selectedvalue_set ;
      private String Ddo_br_procedure_surgery_name_Dropdownoptionstype ;
      private String Ddo_br_procedure_surgery_name_Titlecontrolidtoreplace ;
      private String Ddo_br_procedure_surgery_name_Sortedstatus ;
      private String Ddo_br_procedure_surgery_name_Filtertype ;
      private String Ddo_br_procedure_surgery_name_Datalisttype ;
      private String Ddo_br_procedure_surgery_name_Datalistproc ;
      private String Ddo_br_procedure_surgery_name_Sortasc ;
      private String Ddo_br_procedure_surgery_name_Sortdsc ;
      private String Ddo_br_procedure_surgery_name_Loadingdata ;
      private String Ddo_br_procedure_surgery_name_Cleanfilter ;
      private String Ddo_br_procedure_surgery_name_Noresultsfound ;
      private String Ddo_br_procedure_surgery_name_Searchbuttontext ;
      private String Ddo_br_procedure_surgery_loc_Caption ;
      private String Ddo_br_procedure_surgery_loc_Tooltip ;
      private String Ddo_br_procedure_surgery_loc_Cls ;
      private String Ddo_br_procedure_surgery_loc_Filteredtext_set ;
      private String Ddo_br_procedure_surgery_loc_Selectedvalue_set ;
      private String Ddo_br_procedure_surgery_loc_Dropdownoptionstype ;
      private String Ddo_br_procedure_surgery_loc_Titlecontrolidtoreplace ;
      private String Ddo_br_procedure_surgery_loc_Sortedstatus ;
      private String Ddo_br_procedure_surgery_loc_Filtertype ;
      private String Ddo_br_procedure_surgery_loc_Datalisttype ;
      private String Ddo_br_procedure_surgery_loc_Datalistproc ;
      private String Ddo_br_procedure_surgery_loc_Sortasc ;
      private String Ddo_br_procedure_surgery_loc_Sortdsc ;
      private String Ddo_br_procedure_surgery_loc_Loadingdata ;
      private String Ddo_br_procedure_surgery_loc_Cleanfilter ;
      private String Ddo_br_procedure_surgery_loc_Noresultsfound ;
      private String Ddo_br_procedure_surgery_loc_Searchbuttontext ;
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
      private String edtBR_Procedure_SurgeryID_Title ;
      private String edtBR_ProcedureID_Title ;
      private String edtBR_Procedure_Surgery_Name_Title ;
      private String edtBR_Procedure_Surgery_Loc_Title ;
      private String subGrid_Header ;
      private String edtavDisplay_Link ;
      private String edtavDisplay_Tooltiptext ;
      private String edtavUpdate_Link ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavDelete_Link ;
      private String edtavDelete_Tooltiptext ;
      private String edtBR_Procedure_Surgery_Name_Link ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_procedure_surgeryid_Internalname ;
      private String edtavDdo_br_procedure_surgeryidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_procedureid_Internalname ;
      private String edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_procedure_surgery_name_Internalname ;
      private String edtavDdo_br_procedure_surgery_nametitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_procedure_surgery_loc_Internalname ;
      private String edtavDdo_br_procedure_surgery_loctitlecontrolidtoreplace_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavTfbr_procedure_surgeryid_Internalname ;
      private String edtavTfbr_procedure_surgeryid_Jsonclick ;
      private String edtavTfbr_procedure_surgeryid_to_Internalname ;
      private String edtavTfbr_procedure_surgeryid_to_Jsonclick ;
      private String edtavTfbr_procedureid_Internalname ;
      private String edtavTfbr_procedureid_Jsonclick ;
      private String edtavTfbr_procedureid_to_Internalname ;
      private String edtavTfbr_procedureid_to_Jsonclick ;
      private String edtavTfbr_procedure_surgery_name_Internalname ;
      private String edtavTfbr_procedure_surgery_name_Jsonclick ;
      private String edtavTfbr_procedure_surgery_name_sel_Internalname ;
      private String edtavTfbr_procedure_surgery_name_sel_Jsonclick ;
      private String edtavTfbr_procedure_surgery_loc_Internalname ;
      private String edtavTfbr_procedure_surgery_loc_Jsonclick ;
      private String edtavTfbr_procedure_surgery_loc_sel_Internalname ;
      private String edtavTfbr_procedure_surgery_loc_sel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDisplay_Internalname ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String edtBR_Procedure_SurgeryID_Internalname ;
      private String edtBR_ProcedureID_Internalname ;
      private String edtBR_Procedure_Surgery_Name_Internalname ;
      private String edtBR_Procedure_Surgery_Loc_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_31_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtBR_Procedure_SurgeryID_Jsonclick ;
      private String edtBR_ProcedureID_Jsonclick ;
      private String edtBR_Procedure_Surgery_Name_Jsonclick ;
      private String edtBR_Procedure_Surgery_Loc_Jsonclick ;
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
      private bool Ddo_br_procedure_surgeryid_Includesortasc ;
      private bool Ddo_br_procedure_surgeryid_Includesortdsc ;
      private bool Ddo_br_procedure_surgeryid_Includefilter ;
      private bool Ddo_br_procedure_surgeryid_Filterisrange ;
      private bool Ddo_br_procedure_surgeryid_Includedatalist ;
      private bool Ddo_br_procedureid_Includesortasc ;
      private bool Ddo_br_procedureid_Includesortdsc ;
      private bool Ddo_br_procedureid_Includefilter ;
      private bool Ddo_br_procedureid_Filterisrange ;
      private bool Ddo_br_procedureid_Includedatalist ;
      private bool Ddo_br_procedure_surgery_name_Includesortasc ;
      private bool Ddo_br_procedure_surgery_name_Includesortdsc ;
      private bool Ddo_br_procedure_surgery_name_Includefilter ;
      private bool Ddo_br_procedure_surgery_name_Filterisrange ;
      private bool Ddo_br_procedure_surgery_name_Includedatalist ;
      private bool Ddo_br_procedure_surgery_loc_Includesortasc ;
      private bool Ddo_br_procedure_surgery_loc_Includesortdsc ;
      private bool Ddo_br_procedure_surgery_loc_Includefilter ;
      private bool Ddo_br_procedure_surgery_loc_Filterisrange ;
      private bool Ddo_br_procedure_surgery_loc_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_31_Refreshing=false ;
      private bool n321BR_Procedure_Surgery_Name ;
      private bool n322BR_Procedure_Surgery_Loc ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV42TempBoolean ;
      private bool GXt_boolean2 ;
      private bool AV37Display_IsBlob ;
      private bool AV38Update_IsBlob ;
      private bool AV40Delete_IsBlob ;
      private String AV25TFBR_Procedure_Surgery_Name ;
      private String AV26TFBR_Procedure_Surgery_Name_Sel ;
      private String AV29TFBR_Procedure_Surgery_Loc ;
      private String AV30TFBR_Procedure_Surgery_Loc_Sel ;
      private String AV19ddo_BR_Procedure_SurgeryIDTitleControlIdToReplace ;
      private String AV23ddo_BR_ProcedureIDTitleControlIdToReplace ;
      private String AV27ddo_BR_Procedure_Surgery_NameTitleControlIdToReplace ;
      private String AV31ddo_BR_Procedure_Surgery_LocTitleControlIdToReplace ;
      private String A321BR_Procedure_Surgery_Name ;
      private String A322BR_Procedure_Surgery_Loc ;
      private String AV55Display_GXI ;
      private String AV56Update_GXI ;
      private String AV57Delete_GXI ;
      private String lV51BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name ;
      private String lV53BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc ;
      private String AV52BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel ;
      private String AV51BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name ;
      private String AV54BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel ;
      private String AV53BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc ;
      private String AV37Display ;
      private String AV38Update ;
      private String AV40Delete ;
      private IGxSession AV15Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_procedure_surgeryid ;
      private GXUserControl ucDdo_br_procedureid ;
      private GXUserControl ucDdo_br_procedure_surgery_name ;
      private GXUserControl ucDdo_br_procedure_surgery_loc ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H00662_A322BR_Procedure_Surgery_Loc ;
      private bool[] H00662_n322BR_Procedure_Surgery_Loc ;
      private String[] H00662_A321BR_Procedure_Surgery_Name ;
      private bool[] H00662_n321BR_Procedure_Surgery_Name ;
      private long[] H00662_A139BR_ProcedureID ;
      private long[] H00662_A320BR_Procedure_SurgeryID ;
      private long[] H00663_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV16BR_Procedure_SurgeryIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV20BR_ProcedureIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV24BR_Procedure_Surgery_NameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV28BR_Procedure_Surgery_LocTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV11GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV12GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV32DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class br_procedure_surgeryww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00662( IGxContext context ,
                                             long AV47BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid ,
                                             long AV48BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to ,
                                             long AV49BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid ,
                                             long AV50BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to ,
                                             String AV52BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel ,
                                             String AV51BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name ,
                                             String AV54BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel ,
                                             String AV53BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc ,
                                             long A320BR_Procedure_SurgeryID ,
                                             long A139BR_ProcedureID ,
                                             String A321BR_Procedure_Surgery_Name ,
                                             String A322BR_Procedure_Surgery_Loc ,
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
         sSelectString = " [BR_Procedure_Surgery_Loc], [BR_Procedure_Surgery_Name], [BR_ProcedureID], [BR_Procedure_SurgeryID]";
         sFromString = " FROM [BR_Procedure_Surgery] WITH (NOLOCK)";
         sOrderString = "";
         if ( ! (0==AV47BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_SurgeryID] >= @AV47BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_SurgeryID] >= @AV47BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ! (0==AV48BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_SurgeryID] <= @AV48BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_SurgeryID] <= @AV48BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to)";
            }
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV49BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_ProcedureID] >= @AV49BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_ProcedureID] >= @AV49BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid)";
            }
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (0==AV50BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_ProcedureID] <= @AV50BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_ProcedureID] <= @AV50BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to)";
            }
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV52BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Surgery_Name] like @lV51BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Surgery_Name] like @lV51BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name)";
            }
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV52BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Surgery_Name] = @AV52BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Surgery_Name] = @AV52BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel)";
            }
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV54BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV53BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Surgery_Loc] like @lV53BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Surgery_Loc] like @lV53BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc)";
            }
         }
         else
         {
            GXv_int3[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Surgery_Loc] = @AV54BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Surgery_Loc] = @AV54BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel)";
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
            sOrderString = sOrderString + " ORDER BY [BR_Procedure_SurgeryID]";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Procedure_SurgeryID] DESC";
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
            sOrderString = sOrderString + " ORDER BY [BR_Procedure_Surgery_Name]";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Procedure_Surgery_Name] DESC";
         }
         else if ( ( AV13OrderedBy == 4 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Procedure_Surgery_Loc]";
         }
         else if ( ( AV13OrderedBy == 4 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Procedure_Surgery_Loc] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Procedure_SurgeryID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H00663( IGxContext context ,
                                             long AV47BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid ,
                                             long AV48BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to ,
                                             long AV49BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid ,
                                             long AV50BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to ,
                                             String AV52BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel ,
                                             String AV51BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name ,
                                             String AV54BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel ,
                                             String AV53BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc ,
                                             long A320BR_Procedure_SurgeryID ,
                                             long A139BR_ProcedureID ,
                                             String A321BR_Procedure_Surgery_Name ,
                                             String A322BR_Procedure_Surgery_Loc ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [8] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [BR_Procedure_Surgery] WITH (NOLOCK)";
         if ( ! (0==AV47BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_SurgeryID] >= @AV47BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_SurgeryID] >= @AV47BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid)";
            }
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ! (0==AV48BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_SurgeryID] <= @AV48BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_SurgeryID] <= @AV48BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to)";
            }
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( ! (0==AV49BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_ProcedureID] >= @AV49BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_ProcedureID] >= @AV49BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid)";
            }
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! (0==AV50BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_ProcedureID] <= @AV50BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_ProcedureID] <= @AV50BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to)";
            }
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV52BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Surgery_Name] like @lV51BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Surgery_Name] like @lV51BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name)";
            }
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV52BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Surgery_Name] = @AV52BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Surgery_Name] = @AV52BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel)";
            }
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV54BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV53BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Surgery_Loc] like @lV53BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Surgery_Loc] like @lV53BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc)";
            }
         }
         else
         {
            GXv_int5[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Surgery_Loc] = @AV54BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Surgery_Loc] = @AV54BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel)";
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
                     return conditional_H00662(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (long)dynConstraints[8] , (long)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (short)dynConstraints[12] , (bool)dynConstraints[13] );
               case 1 :
                     return conditional_H00663(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (long)dynConstraints[8] , (long)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (short)dynConstraints[12] , (bool)dynConstraints[13] );
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
          Object[] prmH00662 ;
          prmH00662 = new Object[] {
          new Object[] {"@AV47BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV48BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV49BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV50BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV51BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV52BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV53BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV54BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00663 ;
          prmH00663 = new Object[] {
          new Object[] {"@AV47BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV48BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV49BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV50BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV51BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV52BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV53BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV54BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel",SqlDbType.NVarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00662", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00662,11,0,true,false )
             ,new CursorDef("H00663", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00663,1,0,true,false )
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
