/*
               File: BR_Pathology_SpecimenWW
        Description:  病理学送检组织
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:12:19.80
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
   public class br_pathology_specimenww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_pathology_specimenww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_pathology_specimenww( IGxContext context )
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
               AV17TFBR_Pathology_SpecimenID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV18TFBR_Pathology_SpecimenID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV21TFBR_PathologyID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV22TFBR_PathologyID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV25TFBR_Pathology_Specimen_Name = GetNextPar( );
               AV26TFBR_Pathology_Specimen_Name_Sel = GetNextPar( );
               AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace = GetNextPar( );
               AV23ddo_BR_PathologyIDTitleControlIdToReplace = GetNextPar( );
               AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace = GetNextPar( );
               AV52Pgmname = GetNextPar( );
               AV39IsAuthorized_Display = StringUtil.StrToBool( GetNextPar( ));
               AV40IsAuthorized_BR_Pathology_Specimen_Name = StringUtil.StrToBool( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Pathology_SpecimenID, AV18TFBR_Pathology_SpecimenID_To, AV21TFBR_PathologyID, AV22TFBR_PathologyID_To, AV25TFBR_Pathology_Specimen_Name, AV26TFBR_Pathology_Specimen_Name_Sel, AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace, AV23ddo_BR_PathologyIDTitleControlIdToReplace, AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace, AV52Pgmname, AV39IsAuthorized_Display, AV40IsAuthorized_BR_Pathology_Specimen_Name) ;
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
         PA532( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START532( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022815121997", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_pathology_specimenww.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_SPECIMENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFBR_Pathology_SpecimenID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_SPECIMENID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFBR_Pathology_SpecimenID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGYID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21TFBR_PathologyID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGYID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22TFBR_PathologyID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_SPECIMEN_NAME", AV25TFBR_Pathology_Specimen_Name);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_SPECIMEN_NAME_SEL", AV26TFBR_Pathology_Specimen_Name_Sel);
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_31", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_31), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV30GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV32GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV31GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV28DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV28DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_SPECIMENIDTITLEFILTERDATA", AV16BR_Pathology_SpecimenIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_SPECIMENIDTITLEFILTERDATA", AV16BR_Pathology_SpecimenIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGYIDTITLEFILTERDATA", AV20BR_PathologyIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGYIDTITLEFILTERDATA", AV20BR_PathologyIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_SPECIMEN_NAMETITLEFILTERDATA", AV24BR_Pathology_Specimen_NameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_SPECIMEN_NAMETITLEFILTERDATA", AV24BR_Pathology_Specimen_NameTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV52Pgmname));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_DISPLAY", AV39IsAuthorized_Display);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_BR_PATHOLOGY_SPECIMEN_NAME", AV40IsAuthorized_BR_Pathology_Specimen_Name);
         GxWebStd.gx_hidden_field( context, "gxhash_vISAUTHORIZED_BR_PATHOLOGY_SPECIMEN_NAME", GetSecureSignedToken( "", AV40IsAuthorized_BR_Pathology_Specimen_Name, context));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Caption", StringUtil.RTrim( Ddo_br_pathology_specimenid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Tooltip", StringUtil.RTrim( Ddo_br_pathology_specimenid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Cls", StringUtil.RTrim( Ddo_br_pathology_specimenid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Filteredtext_set", StringUtil.RTrim( Ddo_br_pathology_specimenid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Filteredtextto_set", StringUtil.RTrim( Ddo_br_pathology_specimenid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_specimenid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_specimenid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_specimenid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_specimenid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_specimenid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_specimenid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Filtertype", StringUtil.RTrim( Ddo_br_pathology_specimenid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Filterisrange", StringUtil.BoolToStr( Ddo_br_pathology_specimenid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_specimenid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Sortasc", StringUtil.RTrim( Ddo_br_pathology_specimenid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_specimenid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Cleanfilter", StringUtil.RTrim( Ddo_br_pathology_specimenid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Rangefilterfrom", StringUtil.RTrim( Ddo_br_pathology_specimenid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Rangefilterto", StringUtil.RTrim( Ddo_br_pathology_specimenid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_specimenid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Caption", StringUtil.RTrim( Ddo_br_pathologyid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Tooltip", StringUtil.RTrim( Ddo_br_pathologyid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Cls", StringUtil.RTrim( Ddo_br_pathologyid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Filteredtext_set", StringUtil.RTrim( Ddo_br_pathologyid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Filteredtextto_set", StringUtil.RTrim( Ddo_br_pathologyid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathologyid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathologyid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathologyid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathologyid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Sortedstatus", StringUtil.RTrim( Ddo_br_pathologyid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Includefilter", StringUtil.BoolToStr( Ddo_br_pathologyid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Filtertype", StringUtil.RTrim( Ddo_br_pathologyid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Filterisrange", StringUtil.BoolToStr( Ddo_br_pathologyid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathologyid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Sortasc", StringUtil.RTrim( Ddo_br_pathologyid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Sortdsc", StringUtil.RTrim( Ddo_br_pathologyid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Cleanfilter", StringUtil.RTrim( Ddo_br_pathologyid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Rangefilterfrom", StringUtil.RTrim( Ddo_br_pathologyid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Rangefilterto", StringUtil.RTrim( Ddo_br_pathologyid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathologyid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Caption", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Tooltip", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Cls", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Filteredtext_set", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Selectedvalue_set", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_specimen_name_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_specimen_name_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_specimen_name_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Filtertype", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Filterisrange", StringUtil.BoolToStr( Ddo_br_pathology_specimen_name_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_specimen_name_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Datalisttype", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Datalistproc", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_pathology_specimen_name_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Sortasc", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Loadingdata", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Cleanfilter", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Noresultsfound", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_specimenid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_specimenid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_pathology_specimenid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathologyid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_pathologyid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_specimenid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_specimenid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_pathology_specimenid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathologyid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_pathologyid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Selectedvalue_get));
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
            WE532( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT532( ) ;
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
         return formatLink("br_pathology_specimenww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "BR_Pathology_SpecimenWW" ;
      }

      public override String GetPgmdesc( )
      {
         return " 病理学送检组织" ;
      }

      protected void WB530( )
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
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(31), 2, 0)+","+"null"+");", "插入", bttBtninsert_Jsonclick, 5, "插入", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Pathology_SpecimenWW.htm");
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavDisplay_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DeleteAttribute ActionBaseColorAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Pathology_SpecimenID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_SpecimenID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_SpecimenID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_PathologyID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_PathologyID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_PathologyID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Pathology_Specimen_Name_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_Specimen_Name_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_Specimen_Name_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV33Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDisplay_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV34Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV36Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A274BR_Pathology_SpecimenID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_SpecimenID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_SpecimenID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A226BR_PathologyID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_PathologyID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_PathologyID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A275BR_Pathology_Specimen_Name);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_Specimen_Name_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_Specimen_Name_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtBR_Pathology_Specimen_Name_Link));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV30GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV32GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV31GridPageSize);
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
            ucDdo_br_pathology_specimenid.SetProperty("Caption", Ddo_br_pathology_specimenid_Caption);
            ucDdo_br_pathology_specimenid.SetProperty("Tooltip", Ddo_br_pathology_specimenid_Tooltip);
            ucDdo_br_pathology_specimenid.SetProperty("Cls", Ddo_br_pathology_specimenid_Cls);
            ucDdo_br_pathology_specimenid.SetProperty("DropDownOptionsType", Ddo_br_pathology_specimenid_Dropdownoptionstype);
            ucDdo_br_pathology_specimenid.SetProperty("IncludeSortASC", Ddo_br_pathology_specimenid_Includesortasc);
            ucDdo_br_pathology_specimenid.SetProperty("IncludeSortDSC", Ddo_br_pathology_specimenid_Includesortdsc);
            ucDdo_br_pathology_specimenid.SetProperty("IncludeFilter", Ddo_br_pathology_specimenid_Includefilter);
            ucDdo_br_pathology_specimenid.SetProperty("FilterType", Ddo_br_pathology_specimenid_Filtertype);
            ucDdo_br_pathology_specimenid.SetProperty("FilterIsRange", Ddo_br_pathology_specimenid_Filterisrange);
            ucDdo_br_pathology_specimenid.SetProperty("IncludeDataList", Ddo_br_pathology_specimenid_Includedatalist);
            ucDdo_br_pathology_specimenid.SetProperty("SortASC", Ddo_br_pathology_specimenid_Sortasc);
            ucDdo_br_pathology_specimenid.SetProperty("SortDSC", Ddo_br_pathology_specimenid_Sortdsc);
            ucDdo_br_pathology_specimenid.SetProperty("CleanFilter", Ddo_br_pathology_specimenid_Cleanfilter);
            ucDdo_br_pathology_specimenid.SetProperty("RangeFilterFrom", Ddo_br_pathology_specimenid_Rangefilterfrom);
            ucDdo_br_pathology_specimenid.SetProperty("RangeFilterTo", Ddo_br_pathology_specimenid_Rangefilterto);
            ucDdo_br_pathology_specimenid.SetProperty("SearchButtonText", Ddo_br_pathology_specimenid_Searchbuttontext);
            ucDdo_br_pathology_specimenid.SetProperty("DropDownOptionsTitleSettingsIcons", AV28DDO_TitleSettingsIcons);
            ucDdo_br_pathology_specimenid.SetProperty("DropDownOptionsData", AV16BR_Pathology_SpecimenIDTitleFilterData);
            ucDdo_br_pathology_specimenid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_specimenid_Internalname, "DDO_BR_PATHOLOGY_SPECIMENIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_specimenidtitlecontrolidtoreplace_Internalname, AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", 0, edtavDdo_br_pathology_specimenidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_SpecimenWW.htm");
            /* User Defined Control */
            ucDdo_br_pathologyid.SetProperty("Caption", Ddo_br_pathologyid_Caption);
            ucDdo_br_pathologyid.SetProperty("Tooltip", Ddo_br_pathologyid_Tooltip);
            ucDdo_br_pathologyid.SetProperty("Cls", Ddo_br_pathologyid_Cls);
            ucDdo_br_pathologyid.SetProperty("DropDownOptionsType", Ddo_br_pathologyid_Dropdownoptionstype);
            ucDdo_br_pathologyid.SetProperty("IncludeSortASC", Ddo_br_pathologyid_Includesortasc);
            ucDdo_br_pathologyid.SetProperty("IncludeSortDSC", Ddo_br_pathologyid_Includesortdsc);
            ucDdo_br_pathologyid.SetProperty("IncludeFilter", Ddo_br_pathologyid_Includefilter);
            ucDdo_br_pathologyid.SetProperty("FilterType", Ddo_br_pathologyid_Filtertype);
            ucDdo_br_pathologyid.SetProperty("FilterIsRange", Ddo_br_pathologyid_Filterisrange);
            ucDdo_br_pathologyid.SetProperty("IncludeDataList", Ddo_br_pathologyid_Includedatalist);
            ucDdo_br_pathologyid.SetProperty("SortASC", Ddo_br_pathologyid_Sortasc);
            ucDdo_br_pathologyid.SetProperty("SortDSC", Ddo_br_pathologyid_Sortdsc);
            ucDdo_br_pathologyid.SetProperty("CleanFilter", Ddo_br_pathologyid_Cleanfilter);
            ucDdo_br_pathologyid.SetProperty("RangeFilterFrom", Ddo_br_pathologyid_Rangefilterfrom);
            ucDdo_br_pathologyid.SetProperty("RangeFilterTo", Ddo_br_pathologyid_Rangefilterto);
            ucDdo_br_pathologyid.SetProperty("SearchButtonText", Ddo_br_pathologyid_Searchbuttontext);
            ucDdo_br_pathologyid.SetProperty("DropDownOptionsTitleSettingsIcons", AV28DDO_TitleSettingsIcons);
            ucDdo_br_pathologyid.SetProperty("DropDownOptionsData", AV20BR_PathologyIDTitleFilterData);
            ucDdo_br_pathologyid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathologyid_Internalname, "DDO_BR_PATHOLOGYIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname, AV23ddo_BR_PathologyIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", 0, edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_SpecimenWW.htm");
            /* User Defined Control */
            ucDdo_br_pathology_specimen_name.SetProperty("Caption", Ddo_br_pathology_specimen_name_Caption);
            ucDdo_br_pathology_specimen_name.SetProperty("Tooltip", Ddo_br_pathology_specimen_name_Tooltip);
            ucDdo_br_pathology_specimen_name.SetProperty("Cls", Ddo_br_pathology_specimen_name_Cls);
            ucDdo_br_pathology_specimen_name.SetProperty("DropDownOptionsType", Ddo_br_pathology_specimen_name_Dropdownoptionstype);
            ucDdo_br_pathology_specimen_name.SetProperty("IncludeSortASC", Ddo_br_pathology_specimen_name_Includesortasc);
            ucDdo_br_pathology_specimen_name.SetProperty("IncludeSortDSC", Ddo_br_pathology_specimen_name_Includesortdsc);
            ucDdo_br_pathology_specimen_name.SetProperty("IncludeFilter", Ddo_br_pathology_specimen_name_Includefilter);
            ucDdo_br_pathology_specimen_name.SetProperty("FilterType", Ddo_br_pathology_specimen_name_Filtertype);
            ucDdo_br_pathology_specimen_name.SetProperty("FilterIsRange", Ddo_br_pathology_specimen_name_Filterisrange);
            ucDdo_br_pathology_specimen_name.SetProperty("IncludeDataList", Ddo_br_pathology_specimen_name_Includedatalist);
            ucDdo_br_pathology_specimen_name.SetProperty("DataListType", Ddo_br_pathology_specimen_name_Datalisttype);
            ucDdo_br_pathology_specimen_name.SetProperty("DataListProc", Ddo_br_pathology_specimen_name_Datalistproc);
            ucDdo_br_pathology_specimen_name.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_pathology_specimen_name_Datalistupdateminimumcharacters);
            ucDdo_br_pathology_specimen_name.SetProperty("SortASC", Ddo_br_pathology_specimen_name_Sortasc);
            ucDdo_br_pathology_specimen_name.SetProperty("SortDSC", Ddo_br_pathology_specimen_name_Sortdsc);
            ucDdo_br_pathology_specimen_name.SetProperty("LoadingData", Ddo_br_pathology_specimen_name_Loadingdata);
            ucDdo_br_pathology_specimen_name.SetProperty("CleanFilter", Ddo_br_pathology_specimen_name_Cleanfilter);
            ucDdo_br_pathology_specimen_name.SetProperty("NoResultsFound", Ddo_br_pathology_specimen_name_Noresultsfound);
            ucDdo_br_pathology_specimen_name.SetProperty("SearchButtonText", Ddo_br_pathology_specimen_name_Searchbuttontext);
            ucDdo_br_pathology_specimen_name.SetProperty("DropDownOptionsTitleSettingsIcons", AV28DDO_TitleSettingsIcons);
            ucDdo_br_pathology_specimen_name.SetProperty("DropDownOptionsData", AV24BR_Pathology_Specimen_NameTitleFilterData);
            ucDdo_br_pathology_specimen_name.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_specimen_name_Internalname, "DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_specimen_nametitlecontrolidtoreplace_Internalname, AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", 0, edtavDdo_br_pathology_specimen_nametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_SpecimenWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_SpecimenWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_Pathology_SpecimenWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_specimenid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFBR_Pathology_SpecimenID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV17TFBR_Pathology_SpecimenID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_specimenid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_specimenid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_SpecimenWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_specimenid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFBR_Pathology_SpecimenID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV18TFBR_Pathology_SpecimenID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_specimenid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_specimenid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_SpecimenWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathologyid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21TFBR_PathologyID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV21TFBR_PathologyID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathologyid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathologyid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_SpecimenWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathologyid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22TFBR_PathologyID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV22TFBR_PathologyID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathologyid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathologyid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_SpecimenWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_specimen_name_Internalname, AV25TFBR_Pathology_Specimen_Name, StringUtil.RTrim( context.localUtil.Format( AV25TFBR_Pathology_Specimen_Name, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_specimen_name_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_specimen_name_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_SpecimenWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_specimen_name_sel_Internalname, AV26TFBR_Pathology_Specimen_Name_Sel, StringUtil.RTrim( context.localUtil.Format( AV26TFBR_Pathology_Specimen_Name_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_specimen_name_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_specimen_name_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_SpecimenWW.htm");
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

      protected void START532( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", " 病理学送检组织", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP530( ) ;
      }

      protected void WS532( )
      {
         START532( ) ;
         EVT532( ) ;
      }

      protected void EVT532( )
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
                              E11532 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E12532 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_SPECIMENID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E13532 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGYID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E14532 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_SPECIMEN_NAME.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E15532 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E16532 ();
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
                              AV33Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV33Display)) ? AV49Display_GXI : context.convertURL( context.PathToRelativeUrl( AV33Display))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV33Display), true);
                              AV34Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV34Update)) ? AV50Update_GXI : context.convertURL( context.PathToRelativeUrl( AV34Update))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV34Update), true);
                              AV36Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV36Delete)) ? AV51Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV36Delete))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV36Delete), true);
                              A274BR_Pathology_SpecimenID = (long)(context.localUtil.CToN( cgiGet( edtBR_Pathology_SpecimenID_Internalname), ".", ","));
                              A226BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( edtBR_PathologyID_Internalname), ".", ","));
                              n226BR_PathologyID = false;
                              A275BR_Pathology_Specimen_Name = cgiGet( edtBR_Pathology_Specimen_Name_Internalname);
                              n275BR_Pathology_Specimen_Name = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E17532 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E18532 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E19532 ();
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
                                       /* Set Refresh If Tfbr_pathology_specimenid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_SPECIMENID"), ".", ",") != Convert.ToDecimal( AV17TFBR_Pathology_SpecimenID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_specimenid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_SPECIMENID_TO"), ".", ",") != Convert.ToDecimal( AV18TFBR_Pathology_SpecimenID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathologyid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGYID"), ".", ",") != Convert.ToDecimal( AV21TFBR_PathologyID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathologyid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGYID_TO"), ".", ",") != Convert.ToDecimal( AV22TFBR_PathologyID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_specimen_name Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_SPECIMEN_NAME"), AV25TFBR_Pathology_Specimen_Name) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_specimen_name_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_SPECIMEN_NAME_SEL"), AV26TFBR_Pathology_Specimen_Name_Sel) != 0 )
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

      protected void WE532( )
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

      protected void PA532( )
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
               GX_FocusControl = edtavDdo_br_pathology_specimenidtitlecontrolidtoreplace_Internalname;
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
                                       long AV17TFBR_Pathology_SpecimenID ,
                                       long AV18TFBR_Pathology_SpecimenID_To ,
                                       long AV21TFBR_PathologyID ,
                                       long AV22TFBR_PathologyID_To ,
                                       String AV25TFBR_Pathology_Specimen_Name ,
                                       String AV26TFBR_Pathology_Specimen_Name_Sel ,
                                       String AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace ,
                                       String AV23ddo_BR_PathologyIDTitleControlIdToReplace ,
                                       String AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace ,
                                       String AV52Pgmname ,
                                       bool AV39IsAuthorized_Display ,
                                       bool AV40IsAuthorized_BR_Pathology_Specimen_Name )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF532( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PATHOLOGY_SPECIMENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A274BR_Pathology_SpecimenID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_PATHOLOGY_SPECIMENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A274BR_Pathology_SpecimenID), 18, 0, ".", "")));
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
         RF532( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV52Pgmname = "BR_Pathology_SpecimenWW";
         context.Gx_err = 0;
      }

      protected void RF532( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 31;
         /* Execute user event: Refresh */
         E18532 ();
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
                                                 AV43BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid ,
                                                 AV44BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to ,
                                                 AV45BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid ,
                                                 AV46BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to ,
                                                 AV48BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel ,
                                                 AV47BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name ,
                                                 A274BR_Pathology_SpecimenID ,
                                                 A226BR_PathologyID ,
                                                 A275BR_Pathology_Specimen_Name ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                                 TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV47BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name = StringUtil.Concat( StringUtil.RTrim( AV47BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name), "%", "");
            /* Using cursor H00532 */
            pr_default.execute(0, new Object[] {AV43BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid, AV44BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to, AV45BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid, AV46BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to, lV47BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name, AV48BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_31_idx = 1;
            sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
            SubsflControlProps_312( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A275BR_Pathology_Specimen_Name = H00532_A275BR_Pathology_Specimen_Name[0];
               n275BR_Pathology_Specimen_Name = H00532_n275BR_Pathology_Specimen_Name[0];
               A226BR_PathologyID = H00532_A226BR_PathologyID[0];
               n226BR_PathologyID = H00532_n226BR_PathologyID[0];
               A274BR_Pathology_SpecimenID = H00532_A274BR_Pathology_SpecimenID[0];
               E19532 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 31;
            WB530( ) ;
         }
         bGXsfl_31_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes532( )
      {
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_BR_PATHOLOGY_SPECIMEN_NAME", AV40IsAuthorized_BR_Pathology_Specimen_Name);
         GxWebStd.gx_hidden_field( context, "gxhash_vISAUTHORIZED_BR_PATHOLOGY_SPECIMEN_NAME", GetSecureSignedToken( "", AV40IsAuthorized_BR_Pathology_Specimen_Name, context));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PATHOLOGY_SPECIMENID"+"_"+sGXsfl_31_idx, GetSecureSignedToken( sGXsfl_31_idx, context.localUtil.Format( (decimal)(A274BR_Pathology_SpecimenID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         AV43BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid = AV17TFBR_Pathology_SpecimenID;
         AV44BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to = AV18TFBR_Pathology_SpecimenID_To;
         AV45BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid = AV21TFBR_PathologyID;
         AV46BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to = AV22TFBR_PathologyID_To;
         AV47BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name = AV25TFBR_Pathology_Specimen_Name;
         AV48BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel = AV26TFBR_Pathology_Specimen_Name_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV43BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid ,
                                              AV44BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to ,
                                              AV45BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid ,
                                              AV46BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to ,
                                              AV48BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel ,
                                              AV47BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name ,
                                              A274BR_Pathology_SpecimenID ,
                                              A226BR_PathologyID ,
                                              A275BR_Pathology_Specimen_Name ,
                                              AV13OrderedBy ,
                                              AV14OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV47BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name = StringUtil.Concat( StringUtil.RTrim( AV47BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name), "%", "");
         /* Using cursor H00533 */
         pr_default.execute(1, new Object[] {AV43BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid, AV44BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to, AV45BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid, AV46BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to, lV47BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name, AV48BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel});
         GRID_nRecordCount = H00533_AGRID_nRecordCount[0];
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
         AV43BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid = AV17TFBR_Pathology_SpecimenID;
         AV44BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to = AV18TFBR_Pathology_SpecimenID_To;
         AV45BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid = AV21TFBR_PathologyID;
         AV46BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to = AV22TFBR_PathologyID_To;
         AV47BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name = AV25TFBR_Pathology_Specimen_Name;
         AV48BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel = AV26TFBR_Pathology_Specimen_Name_Sel;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Pathology_SpecimenID, AV18TFBR_Pathology_SpecimenID_To, AV21TFBR_PathologyID, AV22TFBR_PathologyID_To, AV25TFBR_Pathology_Specimen_Name, AV26TFBR_Pathology_Specimen_Name_Sel, AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace, AV23ddo_BR_PathologyIDTitleControlIdToReplace, AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace, AV52Pgmname, AV39IsAuthorized_Display, AV40IsAuthorized_BR_Pathology_Specimen_Name) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV43BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid = AV17TFBR_Pathology_SpecimenID;
         AV44BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to = AV18TFBR_Pathology_SpecimenID_To;
         AV45BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid = AV21TFBR_PathologyID;
         AV46BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to = AV22TFBR_PathologyID_To;
         AV47BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name = AV25TFBR_Pathology_Specimen_Name;
         AV48BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel = AV26TFBR_Pathology_Specimen_Name_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Pathology_SpecimenID, AV18TFBR_Pathology_SpecimenID_To, AV21TFBR_PathologyID, AV22TFBR_PathologyID_To, AV25TFBR_Pathology_Specimen_Name, AV26TFBR_Pathology_Specimen_Name_Sel, AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace, AV23ddo_BR_PathologyIDTitleControlIdToReplace, AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace, AV52Pgmname, AV39IsAuthorized_Display, AV40IsAuthorized_BR_Pathology_Specimen_Name) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV43BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid = AV17TFBR_Pathology_SpecimenID;
         AV44BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to = AV18TFBR_Pathology_SpecimenID_To;
         AV45BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid = AV21TFBR_PathologyID;
         AV46BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to = AV22TFBR_PathologyID_To;
         AV47BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name = AV25TFBR_Pathology_Specimen_Name;
         AV48BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel = AV26TFBR_Pathology_Specimen_Name_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Pathology_SpecimenID, AV18TFBR_Pathology_SpecimenID_To, AV21TFBR_PathologyID, AV22TFBR_PathologyID_To, AV25TFBR_Pathology_Specimen_Name, AV26TFBR_Pathology_Specimen_Name_Sel, AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace, AV23ddo_BR_PathologyIDTitleControlIdToReplace, AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace, AV52Pgmname, AV39IsAuthorized_Display, AV40IsAuthorized_BR_Pathology_Specimen_Name) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV43BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid = AV17TFBR_Pathology_SpecimenID;
         AV44BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to = AV18TFBR_Pathology_SpecimenID_To;
         AV45BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid = AV21TFBR_PathologyID;
         AV46BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to = AV22TFBR_PathologyID_To;
         AV47BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name = AV25TFBR_Pathology_Specimen_Name;
         AV48BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel = AV26TFBR_Pathology_Specimen_Name_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Pathology_SpecimenID, AV18TFBR_Pathology_SpecimenID_To, AV21TFBR_PathologyID, AV22TFBR_PathologyID_To, AV25TFBR_Pathology_Specimen_Name, AV26TFBR_Pathology_Specimen_Name_Sel, AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace, AV23ddo_BR_PathologyIDTitleControlIdToReplace, AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace, AV52Pgmname, AV39IsAuthorized_Display, AV40IsAuthorized_BR_Pathology_Specimen_Name) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV43BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid = AV17TFBR_Pathology_SpecimenID;
         AV44BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to = AV18TFBR_Pathology_SpecimenID_To;
         AV45BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid = AV21TFBR_PathologyID;
         AV46BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to = AV22TFBR_PathologyID_To;
         AV47BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name = AV25TFBR_Pathology_Specimen_Name;
         AV48BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel = AV26TFBR_Pathology_Specimen_Name_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Pathology_SpecimenID, AV18TFBR_Pathology_SpecimenID_To, AV21TFBR_PathologyID, AV22TFBR_PathologyID_To, AV25TFBR_Pathology_Specimen_Name, AV26TFBR_Pathology_Specimen_Name_Sel, AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace, AV23ddo_BR_PathologyIDTitleControlIdToReplace, AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace, AV52Pgmname, AV39IsAuthorized_Display, AV40IsAuthorized_BR_Pathology_Specimen_Name) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP530( )
      {
         /* Before Start, stand alone formulas. */
         AV52Pgmname = "BR_Pathology_SpecimenWW";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E17532 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV28DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_SPECIMENIDTITLEFILTERDATA"), AV16BR_Pathology_SpecimenIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGYIDTITLEFILTERDATA"), AV20BR_PathologyIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_SPECIMEN_NAMETITLEFILTERDATA"), AV24BR_Pathology_Specimen_NameTitleFilterData);
            /* Read variables values. */
            AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_specimenidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace", AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace);
            AV23ddo_BR_PathologyIDTitleControlIdToReplace = cgiGet( edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_PathologyIDTitleControlIdToReplace", AV23ddo_BR_PathologyIDTitleControlIdToReplace);
            AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_specimen_nametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace", AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace);
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
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_specimenid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_specimenid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PATHOLOGY_SPECIMENID");
               GX_FocusControl = edtavTfbr_pathology_specimenid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV17TFBR_Pathology_SpecimenID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Pathology_SpecimenID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Pathology_SpecimenID), 18, 0)));
            }
            else
            {
               AV17TFBR_Pathology_SpecimenID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_pathology_specimenid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Pathology_SpecimenID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Pathology_SpecimenID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_specimenid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_specimenid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PATHOLOGY_SPECIMENID_TO");
               GX_FocusControl = edtavTfbr_pathology_specimenid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV18TFBR_Pathology_SpecimenID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Pathology_SpecimenID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Pathology_SpecimenID_To), 18, 0)));
            }
            else
            {
               AV18TFBR_Pathology_SpecimenID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_pathology_specimenid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Pathology_SpecimenID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Pathology_SpecimenID_To), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathologyid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathologyid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PATHOLOGYID");
               GX_FocusControl = edtavTfbr_pathologyid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV21TFBR_PathologyID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_PathologyID), 18, 0)));
            }
            else
            {
               AV21TFBR_PathologyID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_pathologyid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_PathologyID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathologyid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathologyid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PATHOLOGYID_TO");
               GX_FocusControl = edtavTfbr_pathologyid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV22TFBR_PathologyID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_PathologyID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_PathologyID_To), 18, 0)));
            }
            else
            {
               AV22TFBR_PathologyID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_pathologyid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_PathologyID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_PathologyID_To), 18, 0)));
            }
            AV25TFBR_Pathology_Specimen_Name = cgiGet( edtavTfbr_pathology_specimen_name_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_Pathology_Specimen_Name", AV25TFBR_Pathology_Specimen_Name);
            AV26TFBR_Pathology_Specimen_Name_Sel = cgiGet( edtavTfbr_pathology_specimen_name_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_Pathology_Specimen_Name_Sel", AV26TFBR_Pathology_Specimen_Name_Sel);
            /* Read saved values. */
            nRC_GXsfl_31 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_31"), ".", ","));
            AV30GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV32GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV31GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_pathology_specimenid_Caption = cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Caption");
            Ddo_br_pathology_specimenid_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Tooltip");
            Ddo_br_pathology_specimenid_Cls = cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Cls");
            Ddo_br_pathology_specimenid_Filteredtext_set = cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Filteredtext_set");
            Ddo_br_pathology_specimenid_Filteredtextto_set = cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Filteredtextto_set");
            Ddo_br_pathology_specimenid_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Dropdownoptionstype");
            Ddo_br_pathology_specimenid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Titlecontrolidtoreplace");
            Ddo_br_pathology_specimenid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Includesortasc"));
            Ddo_br_pathology_specimenid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Includesortdsc"));
            Ddo_br_pathology_specimenid_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Sortedstatus");
            Ddo_br_pathology_specimenid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Includefilter"));
            Ddo_br_pathology_specimenid_Filtertype = cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Filtertype");
            Ddo_br_pathology_specimenid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Filterisrange"));
            Ddo_br_pathology_specimenid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Includedatalist"));
            Ddo_br_pathology_specimenid_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Sortasc");
            Ddo_br_pathology_specimenid_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Sortdsc");
            Ddo_br_pathology_specimenid_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Cleanfilter");
            Ddo_br_pathology_specimenid_Rangefilterfrom = cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Rangefilterfrom");
            Ddo_br_pathology_specimenid_Rangefilterto = cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Rangefilterto");
            Ddo_br_pathology_specimenid_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Searchbuttontext");
            Ddo_br_pathologyid_Caption = cgiGet( "DDO_BR_PATHOLOGYID_Caption");
            Ddo_br_pathologyid_Tooltip = cgiGet( "DDO_BR_PATHOLOGYID_Tooltip");
            Ddo_br_pathologyid_Cls = cgiGet( "DDO_BR_PATHOLOGYID_Cls");
            Ddo_br_pathologyid_Filteredtext_set = cgiGet( "DDO_BR_PATHOLOGYID_Filteredtext_set");
            Ddo_br_pathologyid_Filteredtextto_set = cgiGet( "DDO_BR_PATHOLOGYID_Filteredtextto_set");
            Ddo_br_pathologyid_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGYID_Dropdownoptionstype");
            Ddo_br_pathologyid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGYID_Titlecontrolidtoreplace");
            Ddo_br_pathologyid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_Includesortasc"));
            Ddo_br_pathologyid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_Includesortdsc"));
            Ddo_br_pathologyid_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGYID_Sortedstatus");
            Ddo_br_pathologyid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_Includefilter"));
            Ddo_br_pathologyid_Filtertype = cgiGet( "DDO_BR_PATHOLOGYID_Filtertype");
            Ddo_br_pathologyid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_Filterisrange"));
            Ddo_br_pathologyid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_Includedatalist"));
            Ddo_br_pathologyid_Sortasc = cgiGet( "DDO_BR_PATHOLOGYID_Sortasc");
            Ddo_br_pathologyid_Sortdsc = cgiGet( "DDO_BR_PATHOLOGYID_Sortdsc");
            Ddo_br_pathologyid_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGYID_Cleanfilter");
            Ddo_br_pathologyid_Rangefilterfrom = cgiGet( "DDO_BR_PATHOLOGYID_Rangefilterfrom");
            Ddo_br_pathologyid_Rangefilterto = cgiGet( "DDO_BR_PATHOLOGYID_Rangefilterto");
            Ddo_br_pathologyid_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGYID_Searchbuttontext");
            Ddo_br_pathology_specimen_name_Caption = cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Caption");
            Ddo_br_pathology_specimen_name_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Tooltip");
            Ddo_br_pathology_specimen_name_Cls = cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Cls");
            Ddo_br_pathology_specimen_name_Filteredtext_set = cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Filteredtext_set");
            Ddo_br_pathology_specimen_name_Selectedvalue_set = cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Selectedvalue_set");
            Ddo_br_pathology_specimen_name_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Dropdownoptionstype");
            Ddo_br_pathology_specimen_name_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Titlecontrolidtoreplace");
            Ddo_br_pathology_specimen_name_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Includesortasc"));
            Ddo_br_pathology_specimen_name_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Includesortdsc"));
            Ddo_br_pathology_specimen_name_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Sortedstatus");
            Ddo_br_pathology_specimen_name_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Includefilter"));
            Ddo_br_pathology_specimen_name_Filtertype = cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Filtertype");
            Ddo_br_pathology_specimen_name_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Filterisrange"));
            Ddo_br_pathology_specimen_name_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Includedatalist"));
            Ddo_br_pathology_specimen_name_Datalisttype = cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Datalisttype");
            Ddo_br_pathology_specimen_name_Datalistproc = cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Datalistproc");
            Ddo_br_pathology_specimen_name_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_pathology_specimen_name_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Sortasc");
            Ddo_br_pathology_specimen_name_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Sortdsc");
            Ddo_br_pathology_specimen_name_Loadingdata = cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Loadingdata");
            Ddo_br_pathology_specimen_name_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Cleanfilter");
            Ddo_br_pathology_specimen_name_Noresultsfound = cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Noresultsfound");
            Ddo_br_pathology_specimen_name_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_pathology_specimenid_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Activeeventkey");
            Ddo_br_pathology_specimenid_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Filteredtext_get");
            Ddo_br_pathology_specimenid_Filteredtextto_get = cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Filteredtextto_get");
            Ddo_br_pathologyid_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGYID_Activeeventkey");
            Ddo_br_pathologyid_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGYID_Filteredtext_get");
            Ddo_br_pathologyid_Filteredtextto_get = cgiGet( "DDO_BR_PATHOLOGYID_Filteredtextto_get");
            Ddo_br_pathology_specimen_name_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Activeeventkey");
            Ddo_br_pathology_specimen_name_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Filteredtext_get");
            Ddo_br_pathology_specimen_name_Selectedvalue_get = cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Selectedvalue_get");
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
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_SPECIMENID"), ".", ",") != Convert.ToDecimal( AV17TFBR_Pathology_SpecimenID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_SPECIMENID_TO"), ".", ",") != Convert.ToDecimal( AV18TFBR_Pathology_SpecimenID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGYID"), ".", ",") != Convert.ToDecimal( AV21TFBR_PathologyID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGYID_TO"), ".", ",") != Convert.ToDecimal( AV22TFBR_PathologyID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_SPECIMEN_NAME"), AV25TFBR_Pathology_Specimen_Name) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_SPECIMEN_NAME_SEL"), AV26TFBR_Pathology_Specimen_Name_Sel) != 0 )
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
         E17532 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E17532( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GXt_boolean1 = AV40IsAuthorized_BR_Pathology_Specimen_Name;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Pathology_Specimen", out  GXt_boolean1) ;
         AV40IsAuthorized_BR_Pathology_Specimen_Name = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40IsAuthorized_BR_Pathology_Specimen_Name", AV40IsAuthorized_BR_Pathology_Specimen_Name);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vISAUTHORIZED_BR_PATHOLOGY_SPECIMEN_NAME", GetSecureSignedToken( "", AV40IsAuthorized_BR_Pathology_Specimen_Name, context));
         edtavTfbr_pathology_specimenid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_specimenid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_specimenid_Visible), 5, 0)), true);
         edtavTfbr_pathology_specimenid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_specimenid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_specimenid_to_Visible), 5, 0)), true);
         edtavTfbr_pathologyid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathologyid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathologyid_Visible), 5, 0)), true);
         edtavTfbr_pathologyid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathologyid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathologyid_to_Visible), 5, 0)), true);
         edtavTfbr_pathology_specimen_name_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_specimen_name_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_specimen_name_Visible), 5, 0)), true);
         edtavTfbr_pathology_specimen_name_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_specimen_name_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_specimen_name_sel_Visible), 5, 0)), true);
         Ddo_br_pathology_specimenid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_SpecimenID";
         ucDdo_br_pathology_specimenid.SendProperty(context, "", false, Ddo_br_pathology_specimenid_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_specimenid_Titlecontrolidtoreplace);
         AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace = Ddo_br_pathology_specimenid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace", AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace);
         edtavDdo_br_pathology_specimenidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_specimenidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_specimenidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathologyid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_PathologyID";
         ucDdo_br_pathologyid.SendProperty(context, "", false, Ddo_br_pathologyid_Internalname, "TitleControlIdToReplace", Ddo_br_pathologyid_Titlecontrolidtoreplace);
         AV23ddo_BR_PathologyIDTitleControlIdToReplace = Ddo_br_pathologyid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_PathologyIDTitleControlIdToReplace", AV23ddo_BR_PathologyIDTitleControlIdToReplace);
         edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_specimen_name_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_Specimen_Name";
         ucDdo_br_pathology_specimen_name.SendProperty(context, "", false, Ddo_br_pathology_specimen_name_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_specimen_name_Titlecontrolidtoreplace);
         AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace = Ddo_br_pathology_specimen_name_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace", AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace);
         edtavDdo_br_pathology_specimen_nametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_specimen_nametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_specimen_nametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " 病理学送检组织";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV28DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV28DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E18532( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV16BR_Pathology_SpecimenIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_PathologyIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_Pathology_Specimen_NameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
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
         edtBR_Pathology_SpecimenID_Titleformat = 2;
         edtBR_Pathology_SpecimenID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "病理学送检组织主键", AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_SpecimenID_Internalname, "Title", edtBR_Pathology_SpecimenID_Title, !bGXsfl_31_Refreshing);
         edtBR_PathologyID_Titleformat = 2;
         edtBR_PathologyID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "病理学主键", AV23ddo_BR_PathologyIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_Internalname, "Title", edtBR_PathologyID_Title, !bGXsfl_31_Refreshing);
         edtBR_Pathology_Specimen_Name_Titleformat = 2;
         edtBR_Pathology_Specimen_Name_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "送检组织名称", AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Specimen_Name_Internalname, "Title", edtBR_Pathology_Specimen_Name_Title, !bGXsfl_31_Refreshing);
         AV30GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30GridCurrentPage), 10, 0)));
         AV31GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV31GridPageSize), 10, 0)));
         AV32GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV32GridRecordCount), 10, 0)));
         AV43BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid = AV17TFBR_Pathology_SpecimenID;
         AV44BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to = AV18TFBR_Pathology_SpecimenID_To;
         AV45BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid = AV21TFBR_PathologyID;
         AV46BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to = AV22TFBR_PathologyID_To;
         AV47BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name = AV25TFBR_Pathology_Specimen_Name;
         AV48BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel = AV26TFBR_Pathology_Specimen_Name_Sel;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Pathology_SpecimenIDTitleFilterData", AV16BR_Pathology_SpecimenIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_PathologyIDTitleFilterData", AV20BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Pathology_Specimen_NameTitleFilterData", AV24BR_Pathology_Specimen_NameTitleFilterData);
      }

      protected void E11532( )
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
            AV29PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV29PageToGo) ;
         }
      }

      protected void E12532( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E13532( )
      {
         /* Ddo_br_pathology_specimenid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_specimenid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_pathology_specimenid_Sortedstatus = "ASC";
            ucDdo_br_pathology_specimenid.SendProperty(context, "", false, Ddo_br_pathology_specimenid_Internalname, "SortedStatus", Ddo_br_pathology_specimenid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_specimenid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_pathology_specimenid_Sortedstatus = "DSC";
            ucDdo_br_pathology_specimenid.SendProperty(context, "", false, Ddo_br_pathology_specimenid_Internalname, "SortedStatus", Ddo_br_pathology_specimenid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_specimenid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV17TFBR_Pathology_SpecimenID = (long)(NumberUtil.Val( Ddo_br_pathology_specimenid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Pathology_SpecimenID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Pathology_SpecimenID), 18, 0)));
            AV18TFBR_Pathology_SpecimenID_To = (long)(NumberUtil.Val( Ddo_br_pathology_specimenid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Pathology_SpecimenID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Pathology_SpecimenID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Pathology_SpecimenIDTitleFilterData", AV16BR_Pathology_SpecimenIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_PathologyIDTitleFilterData", AV20BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Pathology_Specimen_NameTitleFilterData", AV24BR_Pathology_Specimen_NameTitleFilterData);
      }

      protected void E14532( )
      {
         /* Ddo_br_pathologyid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathologyid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_pathologyid_Sortedstatus = "ASC";
            ucDdo_br_pathologyid.SendProperty(context, "", false, Ddo_br_pathologyid_Internalname, "SortedStatus", Ddo_br_pathologyid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathologyid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_pathologyid_Sortedstatus = "DSC";
            ucDdo_br_pathologyid.SendProperty(context, "", false, Ddo_br_pathologyid_Internalname, "SortedStatus", Ddo_br_pathologyid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathologyid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV21TFBR_PathologyID = (long)(NumberUtil.Val( Ddo_br_pathologyid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_PathologyID), 18, 0)));
            AV22TFBR_PathologyID_To = (long)(NumberUtil.Val( Ddo_br_pathologyid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_PathologyID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_PathologyID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Pathology_SpecimenIDTitleFilterData", AV16BR_Pathology_SpecimenIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_PathologyIDTitleFilterData", AV20BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Pathology_Specimen_NameTitleFilterData", AV24BR_Pathology_Specimen_NameTitleFilterData);
      }

      protected void E15532( )
      {
         /* Ddo_br_pathology_specimen_name_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_specimen_name_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_pathology_specimen_name_Sortedstatus = "ASC";
            ucDdo_br_pathology_specimen_name.SendProperty(context, "", false, Ddo_br_pathology_specimen_name_Internalname, "SortedStatus", Ddo_br_pathology_specimen_name_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_specimen_name_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_pathology_specimen_name_Sortedstatus = "DSC";
            ucDdo_br_pathology_specimen_name.SendProperty(context, "", false, Ddo_br_pathology_specimen_name_Internalname, "SortedStatus", Ddo_br_pathology_specimen_name_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_specimen_name_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV25TFBR_Pathology_Specimen_Name = Ddo_br_pathology_specimen_name_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_Pathology_Specimen_Name", AV25TFBR_Pathology_Specimen_Name);
            AV26TFBR_Pathology_Specimen_Name_Sel = Ddo_br_pathology_specimen_name_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_Pathology_Specimen_Name_Sel", AV26TFBR_Pathology_Specimen_Name_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Pathology_SpecimenIDTitleFilterData", AV16BR_Pathology_SpecimenIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_PathologyIDTitleFilterData", AV20BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Pathology_Specimen_NameTitleFilterData", AV24BR_Pathology_Specimen_NameTitleFilterData);
      }

      private void E19532( )
      {
         /* Grid_Load Routine */
         AV33Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDisplay_Internalname, AV33Display);
         AV49Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         if ( AV39IsAuthorized_Display )
         {
            edtavDisplay_Link = formatLink("br_pathology_specimenview.aspx") + "?" + UrlEncode("" +A274BR_Pathology_SpecimenID) + "," + UrlEncode(StringUtil.RTrim(""));
         }
         AV34Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV34Update);
         AV50Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavUpdate_Tooltiptext = "修改";
         edtavUpdate_Link = formatLink("br_pathology_specimen.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A274BR_Pathology_SpecimenID);
         AV36Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV36Delete);
         AV51Delete_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavDelete_Tooltiptext = "删除";
         edtavDelete_Link = formatLink("br_pathology_specimen.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A274BR_Pathology_SpecimenID);
         if ( AV40IsAuthorized_BR_Pathology_Specimen_Name )
         {
            edtBR_Pathology_Specimen_Name_Link = formatLink("br_pathology_specimenview.aspx") + "?" + UrlEncode("" +A274BR_Pathology_SpecimenID) + "," + UrlEncode(StringUtil.RTrim(""));
         }
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

      protected void E16532( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("br_pathology_specimen.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S162( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_br_pathology_specimenid_Sortedstatus = "";
         ucDdo_br_pathology_specimenid.SendProperty(context, "", false, Ddo_br_pathology_specimenid_Internalname, "SortedStatus", Ddo_br_pathology_specimenid_Sortedstatus);
         Ddo_br_pathologyid_Sortedstatus = "";
         ucDdo_br_pathologyid.SendProperty(context, "", false, Ddo_br_pathologyid_Internalname, "SortedStatus", Ddo_br_pathologyid_Sortedstatus);
         Ddo_br_pathology_specimen_name_Sortedstatus = "";
         ucDdo_br_pathology_specimen_name.SendProperty(context, "", false, Ddo_br_pathology_specimen_name_Internalname, "SortedStatus", Ddo_br_pathology_specimen_name_Sortedstatus);
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
            Ddo_br_pathology_specimenid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathology_specimenid.SendProperty(context, "", false, Ddo_br_pathology_specimenid_Internalname, "SortedStatus", Ddo_br_pathology_specimenid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 2 )
         {
            Ddo_br_pathologyid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathologyid.SendProperty(context, "", false, Ddo_br_pathologyid_Internalname, "SortedStatus", Ddo_br_pathologyid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 3 )
         {
            Ddo_br_pathology_specimen_name_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathology_specimen_name.SendProperty(context, "", false, Ddo_br_pathology_specimen_name_Internalname, "SortedStatus", Ddo_br_pathology_specimen_name_Sortedstatus);
         }
      }

      protected void S142( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean1 = AV39IsAuthorized_Display;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Pathology_Specimen", out  GXt_boolean1) ;
         AV39IsAuthorized_Display = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39IsAuthorized_Display", AV39IsAuthorized_Display);
         if ( ! ( AV39IsAuthorized_Display ) )
         {
            edtavDisplay_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDisplay_Visible), 5, 0)), !bGXsfl_31_Refreshing);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV15Session.Get(AV52Pgmname+"GridState"), "") == 0 )
         {
            AV11GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV52Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV11GridState.FromXml(AV15Session.Get(AV52Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
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
         AV53GXV1 = 1;
         while ( AV53GXV1 <= AV11GridState.gxTpr_Filtervalues.Count )
         {
            AV12GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV11GridState.gxTpr_Filtervalues.Item(AV53GXV1));
            if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_SPECIMENID") == 0 )
            {
               AV17TFBR_Pathology_SpecimenID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Pathology_SpecimenID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Pathology_SpecimenID), 18, 0)));
               AV18TFBR_Pathology_SpecimenID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Pathology_SpecimenID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Pathology_SpecimenID_To), 18, 0)));
               if ( ! (0==AV17TFBR_Pathology_SpecimenID) )
               {
                  Ddo_br_pathology_specimenid_Filteredtext_set = StringUtil.Str( (decimal)(AV17TFBR_Pathology_SpecimenID), 18, 0);
                  ucDdo_br_pathology_specimenid.SendProperty(context, "", false, Ddo_br_pathology_specimenid_Internalname, "FilteredText_set", Ddo_br_pathology_specimenid_Filteredtext_set);
               }
               if ( ! (0==AV18TFBR_Pathology_SpecimenID_To) )
               {
                  Ddo_br_pathology_specimenid_Filteredtextto_set = StringUtil.Str( (decimal)(AV18TFBR_Pathology_SpecimenID_To), 18, 0);
                  ucDdo_br_pathology_specimenid.SendProperty(context, "", false, Ddo_br_pathology_specimenid_Internalname, "FilteredTextTo_set", Ddo_br_pathology_specimenid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGYID") == 0 )
            {
               AV21TFBR_PathologyID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_PathologyID), 18, 0)));
               AV22TFBR_PathologyID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_PathologyID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_PathologyID_To), 18, 0)));
               if ( ! (0==AV21TFBR_PathologyID) )
               {
                  Ddo_br_pathologyid_Filteredtext_set = StringUtil.Str( (decimal)(AV21TFBR_PathologyID), 18, 0);
                  ucDdo_br_pathologyid.SendProperty(context, "", false, Ddo_br_pathologyid_Internalname, "FilteredText_set", Ddo_br_pathologyid_Filteredtext_set);
               }
               if ( ! (0==AV22TFBR_PathologyID_To) )
               {
                  Ddo_br_pathologyid_Filteredtextto_set = StringUtil.Str( (decimal)(AV22TFBR_PathologyID_To), 18, 0);
                  ucDdo_br_pathologyid.SendProperty(context, "", false, Ddo_br_pathologyid_Internalname, "FilteredTextTo_set", Ddo_br_pathologyid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_SPECIMEN_NAME") == 0 )
            {
               AV25TFBR_Pathology_Specimen_Name = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_Pathology_Specimen_Name", AV25TFBR_Pathology_Specimen_Name);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV25TFBR_Pathology_Specimen_Name)) )
               {
                  Ddo_br_pathology_specimen_name_Filteredtext_set = AV25TFBR_Pathology_Specimen_Name;
                  ucDdo_br_pathology_specimen_name.SendProperty(context, "", false, Ddo_br_pathology_specimen_name_Internalname, "FilteredText_set", Ddo_br_pathology_specimen_name_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_SPECIMEN_NAME_SEL") == 0 )
            {
               AV26TFBR_Pathology_Specimen_Name_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_Pathology_Specimen_Name_Sel", AV26TFBR_Pathology_Specimen_Name_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26TFBR_Pathology_Specimen_Name_Sel)) )
               {
                  Ddo_br_pathology_specimen_name_Selectedvalue_set = AV26TFBR_Pathology_Specimen_Name_Sel;
                  ucDdo_br_pathology_specimen_name.SendProperty(context, "", false, Ddo_br_pathology_specimen_name_Internalname, "SelectedValue_set", Ddo_br_pathology_specimen_name_Selectedvalue_set);
               }
            }
            AV53GXV1 = (int)(AV53GXV1+1);
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
         AV11GridState.FromXml(AV15Session.Get(AV52Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV11GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV11GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV11GridState.gxTpr_Filtervalues.Clear();
         if ( ! ( (0==AV17TFBR_Pathology_SpecimenID) && (0==AV18TFBR_Pathology_SpecimenID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_SPECIMENID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV17TFBR_Pathology_SpecimenID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV18TFBR_Pathology_SpecimenID_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (0==AV21TFBR_PathologyID) && (0==AV22TFBR_PathologyID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGYID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV21TFBR_PathologyID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV22TFBR_PathologyID_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV25TFBR_Pathology_Specimen_Name)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_SPECIMEN_NAME";
            AV12GridStateFilterValue.gxTpr_Value = AV25TFBR_Pathology_Specimen_Name;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26TFBR_Pathology_Specimen_Name_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_SPECIMEN_NAME_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV26TFBR_Pathology_Specimen_Name_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         AV11GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV11GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV52Pgmname+"GridState",  AV11GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV52Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Pathology_Specimen";
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
         PA532( ) ;
         WS532( ) ;
         WE532( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022815122818", true);
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
         context.AddJavascriptSource("br_pathology_specimenww.js", "?202022815122818", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false);
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
         edtBR_Pathology_SpecimenID_Internalname = "BR_PATHOLOGY_SPECIMENID_"+sGXsfl_31_idx;
         edtBR_PathologyID_Internalname = "BR_PATHOLOGYID_"+sGXsfl_31_idx;
         edtBR_Pathology_Specimen_Name_Internalname = "BR_PATHOLOGY_SPECIMEN_NAME_"+sGXsfl_31_idx;
      }

      protected void SubsflControlProps_fel_312( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_31_fel_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_31_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_31_fel_idx;
         edtBR_Pathology_SpecimenID_Internalname = "BR_PATHOLOGY_SPECIMENID_"+sGXsfl_31_fel_idx;
         edtBR_PathologyID_Internalname = "BR_PATHOLOGYID_"+sGXsfl_31_fel_idx;
         edtBR_Pathology_Specimen_Name_Internalname = "BR_PATHOLOGY_SPECIMEN_NAME_"+sGXsfl_31_fel_idx;
      }

      protected void sendrow_312( )
      {
         SubsflControlProps_312( ) ;
         WB530( ) ;
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
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDisplay_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV33Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV33Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV49Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV33Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV33Display)) ? AV49Display_GXI : context.PathToRelativeUrl( AV33Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavDisplay_Visible,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV33Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV34Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV34Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV50Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV34Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV34Update)) ? AV50Update_GXI : context.PathToRelativeUrl( AV34Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV34Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "DeleteAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV36Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV36Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV51Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV36Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV36Delete)) ? AV51Delete_GXI : context.PathToRelativeUrl( AV36Delete));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)edtavDelete_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV36Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_SpecimenID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A274BR_Pathology_SpecimenID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A274BR_Pathology_SpecimenID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_SpecimenID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_PathologyID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A226BR_PathologyID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A226BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_PathologyID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_Specimen_Name_Internalname,(String)A275BR_Pathology_Specimen_Name,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtBR_Pathology_Specimen_Name_Link,(String)"",(String)"",(String)"",(String)edtBR_Pathology_Specimen_Name_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes532( ) ;
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
         edtBR_Pathology_SpecimenID_Internalname = "BR_PATHOLOGY_SPECIMENID";
         edtBR_PathologyID_Internalname = "BR_PATHOLOGYID";
         edtBR_Pathology_Specimen_Name_Internalname = "BR_PATHOLOGY_SPECIMEN_NAME";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_pathology_specimenid_Internalname = "DDO_BR_PATHOLOGY_SPECIMENID";
         edtavDdo_br_pathology_specimenidtitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_SPECIMENIDTITLECONTROLIDTOREPLACE";
         Ddo_br_pathologyid_Internalname = "DDO_BR_PATHOLOGYID";
         edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_specimen_name_Internalname = "DDO_BR_PATHOLOGY_SPECIMEN_NAME";
         edtavDdo_br_pathology_specimen_nametitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_SPECIMEN_NAMETITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         edtavTfbr_pathology_specimenid_Internalname = "vTFBR_PATHOLOGY_SPECIMENID";
         edtavTfbr_pathology_specimenid_to_Internalname = "vTFBR_PATHOLOGY_SPECIMENID_TO";
         edtavTfbr_pathologyid_Internalname = "vTFBR_PATHOLOGYID";
         edtavTfbr_pathologyid_to_Internalname = "vTFBR_PATHOLOGYID_TO";
         edtavTfbr_pathology_specimen_name_Internalname = "vTFBR_PATHOLOGY_SPECIMEN_NAME";
         edtavTfbr_pathology_specimen_name_sel_Internalname = "vTFBR_PATHOLOGY_SPECIMEN_NAME_SEL";
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
         edtBR_Pathology_Specimen_Name_Jsonclick = "";
         edtBR_PathologyID_Jsonclick = "";
         edtBR_Pathology_SpecimenID_Jsonclick = "";
         edtavTfbr_pathology_specimen_name_sel_Jsonclick = "";
         edtavTfbr_pathology_specimen_name_sel_Visible = 1;
         edtavTfbr_pathology_specimen_name_Jsonclick = "";
         edtavTfbr_pathology_specimen_name_Visible = 1;
         edtavTfbr_pathologyid_to_Jsonclick = "";
         edtavTfbr_pathologyid_to_Visible = 1;
         edtavTfbr_pathologyid_Jsonclick = "";
         edtavTfbr_pathologyid_Visible = 1;
         edtavTfbr_pathology_specimenid_to_Jsonclick = "";
         edtavTfbr_pathology_specimenid_to_Visible = 1;
         edtavTfbr_pathology_specimenid_Jsonclick = "";
         edtavTfbr_pathology_specimenid_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_pathology_specimen_nametitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathology_specimenidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtBR_Pathology_Specimen_Name_Link = "";
         edtavDelete_Tooltiptext = "删除";
         edtavDelete_Link = "";
         edtavUpdate_Tooltiptext = "修改";
         edtavUpdate_Link = "";
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Pathology_Specimen_Name_Titleformat = 0;
         edtBR_Pathology_Specimen_Name_Title = "送检组织名称";
         edtBR_PathologyID_Titleformat = 0;
         edtBR_PathologyID_Title = "病理学主键";
         edtBR_Pathology_SpecimenID_Titleformat = 0;
         edtBR_Pathology_SpecimenID_Title = "病理学送检组织主键";
         edtavDisplay_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         Ddo_br_pathology_specimen_name_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_specimen_name_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_pathology_specimen_name_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathology_specimen_name_Loadingdata = "WWP_TSLoading";
         Ddo_br_pathology_specimen_name_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_specimen_name_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_specimen_name_Datalistupdateminimumcharacters = 0;
         Ddo_br_pathology_specimen_name_Datalistproc = "BR_Pathology_SpecimenWWGetFilterData";
         Ddo_br_pathology_specimen_name_Datalisttype = "Dynamic";
         Ddo_br_pathology_specimen_name_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_pathology_specimen_name_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_pathology_specimen_name_Filtertype = "Character";
         Ddo_br_pathology_specimen_name_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_pathology_specimen_name_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_specimen_name_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_specimen_name_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_specimen_name_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_specimen_name_Cls = "ColumnSettings";
         Ddo_br_pathology_specimen_name_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_specimen_name_Caption = "";
         Ddo_br_pathologyid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathologyid_Rangefilterto = "WWP_TSTo";
         Ddo_br_pathologyid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_pathologyid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathologyid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathologyid_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathologyid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathologyid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_Filtertype = "Numeric";
         Ddo_br_pathologyid_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_Titlecontrolidtoreplace = "";
         Ddo_br_pathologyid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathologyid_Cls = "ColumnSettings";
         Ddo_br_pathologyid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathologyid_Caption = "";
         Ddo_br_pathology_specimenid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_specimenid_Rangefilterto = "WWP_TSTo";
         Ddo_br_pathology_specimenid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_pathology_specimenid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathology_specimenid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_specimenid_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_specimenid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_specimenid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_pathology_specimenid_Filtertype = "Numeric";
         Ddo_br_pathology_specimenid_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_pathology_specimenid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_specimenid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_specimenid_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_specimenid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_specimenid_Cls = "ColumnSettings";
         Ddo_br_pathology_specimenid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_specimenid_Caption = "";
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
         Form.Caption = " 病理学送检组织";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV39IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMENIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMEN_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV17TFBR_Pathology_SpecimenID',fld:'vTFBR_PATHOLOGY_SPECIMENID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_SpecimenID_To',fld:'vTFBR_PATHOLOGY_SPECIMENID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Specimen_Name',fld:'vTFBR_PATHOLOGY_SPECIMEN_NAME',pic:''},{av:'AV26TFBR_Pathology_Specimen_Name_Sel',fld:'vTFBR_PATHOLOGY_SPECIMEN_NAME_SEL',pic:''},{av:'AV52Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV40IsAuthorized_BR_Pathology_Specimen_Name',fld:'vISAUTHORIZED_BR_PATHOLOGY_SPECIMEN_NAME',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV16BR_Pathology_SpecimenIDTitleFilterData',fld:'vBR_PATHOLOGY_SPECIMENIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Specimen_NameTitleFilterData',fld:'vBR_PATHOLOGY_SPECIMEN_NAMETITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_SpecimenID_Titleformat',ctrl:'BR_PATHOLOGY_SPECIMENID',prop:'Titleformat'},{av:'edtBR_Pathology_SpecimenID_Title',ctrl:'BR_PATHOLOGY_SPECIMENID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Specimen_Name_Titleformat',ctrl:'BR_PATHOLOGY_SPECIMEN_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Specimen_Name_Title',ctrl:'BR_PATHOLOGY_SPECIMEN_NAME',prop:'Title'},{av:'AV30GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV31GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV32GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E11532',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_SpecimenID',fld:'vTFBR_PATHOLOGY_SPECIMENID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_SpecimenID_To',fld:'vTFBR_PATHOLOGY_SPECIMENID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Specimen_Name',fld:'vTFBR_PATHOLOGY_SPECIMEN_NAME',pic:''},{av:'AV26TFBR_Pathology_Specimen_Name_Sel',fld:'vTFBR_PATHOLOGY_SPECIMEN_NAME_SEL',pic:''},{av:'AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMENIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMEN_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV52Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV40IsAuthorized_BR_Pathology_Specimen_Name',fld:'vISAUTHORIZED_BR_PATHOLOGY_SPECIMEN_NAME',pic:'',hsh:true},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E12532',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_SpecimenID',fld:'vTFBR_PATHOLOGY_SPECIMENID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_SpecimenID_To',fld:'vTFBR_PATHOLOGY_SPECIMENID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Specimen_Name',fld:'vTFBR_PATHOLOGY_SPECIMEN_NAME',pic:''},{av:'AV26TFBR_Pathology_Specimen_Name_Sel',fld:'vTFBR_PATHOLOGY_SPECIMEN_NAME_SEL',pic:''},{av:'AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMENIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMEN_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV52Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV40IsAuthorized_BR_Pathology_Specimen_Name',fld:'vISAUTHORIZED_BR_PATHOLOGY_SPECIMEN_NAME',pic:'',hsh:true},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_SPECIMENID.ONOPTIONCLICKED","{handler:'E13532',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_SpecimenID',fld:'vTFBR_PATHOLOGY_SPECIMENID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_SpecimenID_To',fld:'vTFBR_PATHOLOGY_SPECIMENID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Specimen_Name',fld:'vTFBR_PATHOLOGY_SPECIMEN_NAME',pic:''},{av:'AV26TFBR_Pathology_Specimen_Name_Sel',fld:'vTFBR_PATHOLOGY_SPECIMEN_NAME_SEL',pic:''},{av:'AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMENIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMEN_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV52Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV40IsAuthorized_BR_Pathology_Specimen_Name',fld:'vISAUTHORIZED_BR_PATHOLOGY_SPECIMEN_NAME',pic:'',hsh:true},{av:'Ddo_br_pathology_specimenid_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_SPECIMENID',prop:'ActiveEventKey'},{av:'Ddo_br_pathology_specimenid_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGY_SPECIMENID',prop:'FilteredText_get'},{av:'Ddo_br_pathology_specimenid_Filteredtextto_get',ctrl:'DDO_BR_PATHOLOGY_SPECIMENID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_SPECIMENID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_specimenid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_SPECIMENID',prop:'SortedStatus'},{av:'AV17TFBR_Pathology_SpecimenID',fld:'vTFBR_PATHOLOGY_SPECIMENID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_SpecimenID_To',fld:'vTFBR_PATHOLOGY_SPECIMENID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'Ddo_br_pathology_specimen_name_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_SPECIMEN_NAME',prop:'SortedStatus'},{av:'AV16BR_Pathology_SpecimenIDTitleFilterData',fld:'vBR_PATHOLOGY_SPECIMENIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Specimen_NameTitleFilterData',fld:'vBR_PATHOLOGY_SPECIMEN_NAMETITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_SpecimenID_Titleformat',ctrl:'BR_PATHOLOGY_SPECIMENID',prop:'Titleformat'},{av:'edtBR_Pathology_SpecimenID_Title',ctrl:'BR_PATHOLOGY_SPECIMENID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Specimen_Name_Titleformat',ctrl:'BR_PATHOLOGY_SPECIMEN_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Specimen_Name_Title',ctrl:'BR_PATHOLOGY_SPECIMEN_NAME',prop:'Title'},{av:'AV30GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV31GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV32GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGYID.ONOPTIONCLICKED","{handler:'E14532',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_SpecimenID',fld:'vTFBR_PATHOLOGY_SPECIMENID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_SpecimenID_To',fld:'vTFBR_PATHOLOGY_SPECIMENID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Specimen_Name',fld:'vTFBR_PATHOLOGY_SPECIMEN_NAME',pic:''},{av:'AV26TFBR_Pathology_Specimen_Name_Sel',fld:'vTFBR_PATHOLOGY_SPECIMEN_NAME_SEL',pic:''},{av:'AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMENIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMEN_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV52Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV40IsAuthorized_BR_Pathology_Specimen_Name',fld:'vISAUTHORIZED_BR_PATHOLOGY_SPECIMEN_NAME',pic:'',hsh:true},{av:'Ddo_br_pathologyid_Activeeventkey',ctrl:'DDO_BR_PATHOLOGYID',prop:'ActiveEventKey'},{av:'Ddo_br_pathologyid_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGYID',prop:'FilteredText_get'},{av:'Ddo_br_pathologyid_Filteredtextto_get',ctrl:'DDO_BR_PATHOLOGYID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGYID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_pathology_specimenid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_SPECIMENID',prop:'SortedStatus'},{av:'Ddo_br_pathology_specimen_name_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_SPECIMEN_NAME',prop:'SortedStatus'},{av:'AV16BR_Pathology_SpecimenIDTitleFilterData',fld:'vBR_PATHOLOGY_SPECIMENIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Specimen_NameTitleFilterData',fld:'vBR_PATHOLOGY_SPECIMEN_NAMETITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_SpecimenID_Titleformat',ctrl:'BR_PATHOLOGY_SPECIMENID',prop:'Titleformat'},{av:'edtBR_Pathology_SpecimenID_Title',ctrl:'BR_PATHOLOGY_SPECIMENID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Specimen_Name_Titleformat',ctrl:'BR_PATHOLOGY_SPECIMEN_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Specimen_Name_Title',ctrl:'BR_PATHOLOGY_SPECIMEN_NAME',prop:'Title'},{av:'AV30GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV31GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV32GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_SPECIMEN_NAME.ONOPTIONCLICKED","{handler:'E15532',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_SpecimenID',fld:'vTFBR_PATHOLOGY_SPECIMENID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_SpecimenID_To',fld:'vTFBR_PATHOLOGY_SPECIMENID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Specimen_Name',fld:'vTFBR_PATHOLOGY_SPECIMEN_NAME',pic:''},{av:'AV26TFBR_Pathology_Specimen_Name_Sel',fld:'vTFBR_PATHOLOGY_SPECIMEN_NAME_SEL',pic:''},{av:'AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMENIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMEN_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV52Pgmname',fld:'vPGMNAME',pic:''},{av:'AV39IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV40IsAuthorized_BR_Pathology_Specimen_Name',fld:'vISAUTHORIZED_BR_PATHOLOGY_SPECIMEN_NAME',pic:'',hsh:true},{av:'Ddo_br_pathology_specimen_name_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_SPECIMEN_NAME',prop:'ActiveEventKey'},{av:'Ddo_br_pathology_specimen_name_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGY_SPECIMEN_NAME',prop:'FilteredText_get'},{av:'Ddo_br_pathology_specimen_name_Selectedvalue_get',ctrl:'DDO_BR_PATHOLOGY_SPECIMEN_NAME',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_SPECIMEN_NAME.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_specimen_name_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_SPECIMEN_NAME',prop:'SortedStatus'},{av:'AV25TFBR_Pathology_Specimen_Name',fld:'vTFBR_PATHOLOGY_SPECIMEN_NAME',pic:''},{av:'AV26TFBR_Pathology_Specimen_Name_Sel',fld:'vTFBR_PATHOLOGY_SPECIMEN_NAME_SEL',pic:''},{av:'Ddo_br_pathology_specimenid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_SPECIMENID',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'AV16BR_Pathology_SpecimenIDTitleFilterData',fld:'vBR_PATHOLOGY_SPECIMENIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Specimen_NameTitleFilterData',fld:'vBR_PATHOLOGY_SPECIMEN_NAMETITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_SpecimenID_Titleformat',ctrl:'BR_PATHOLOGY_SPECIMENID',prop:'Titleformat'},{av:'edtBR_Pathology_SpecimenID_Title',ctrl:'BR_PATHOLOGY_SPECIMENID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Specimen_Name_Titleformat',ctrl:'BR_PATHOLOGY_SPECIMEN_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Specimen_Name_Title',ctrl:'BR_PATHOLOGY_SPECIMEN_NAME',prop:'Title'},{av:'AV30GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV31GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV32GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV39IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E19532',iparms:[{av:'AV39IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'A274BR_Pathology_SpecimenID',fld:'BR_PATHOLOGY_SPECIMENID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV40IsAuthorized_BR_Pathology_Specimen_Name',fld:'vISAUTHORIZED_BR_PATHOLOGY_SPECIMEN_NAME',pic:'',hsh:true}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV33Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'},{av:'AV34Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV36Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'},{av:'edtBR_Pathology_Specimen_Name_Link',ctrl:'BR_PATHOLOGY_SPECIMEN_NAME',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E16532',iparms:[{av:'A274BR_Pathology_SpecimenID',fld:'BR_PATHOLOGY_SPECIMENID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
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
         Ddo_br_pathology_specimenid_Activeeventkey = "";
         Ddo_br_pathology_specimenid_Filteredtext_get = "";
         Ddo_br_pathology_specimenid_Filteredtextto_get = "";
         Ddo_br_pathologyid_Activeeventkey = "";
         Ddo_br_pathologyid_Filteredtext_get = "";
         Ddo_br_pathologyid_Filteredtextto_get = "";
         Ddo_br_pathology_specimen_name_Activeeventkey = "";
         Ddo_br_pathology_specimen_name_Filteredtext_get = "";
         Ddo_br_pathology_specimen_name_Selectedvalue_get = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV25TFBR_Pathology_Specimen_Name = "";
         AV26TFBR_Pathology_Specimen_Name_Sel = "";
         AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace = "";
         AV23ddo_BR_PathologyIDTitleControlIdToReplace = "";
         AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace = "";
         AV52Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV28DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV16BR_Pathology_SpecimenIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_PathologyIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_Pathology_Specimen_NameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_pathology_specimenid_Filteredtext_set = "";
         Ddo_br_pathology_specimenid_Filteredtextto_set = "";
         Ddo_br_pathology_specimenid_Sortedstatus = "";
         Ddo_br_pathologyid_Filteredtext_set = "";
         Ddo_br_pathologyid_Filteredtextto_set = "";
         Ddo_br_pathologyid_Sortedstatus = "";
         Ddo_br_pathology_specimen_name_Filteredtext_set = "";
         Ddo_br_pathology_specimen_name_Selectedvalue_set = "";
         Ddo_br_pathology_specimen_name_Sortedstatus = "";
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
         AV33Display = "";
         AV34Update = "";
         AV36Delete = "";
         A275BR_Pathology_Specimen_Name = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_pathology_specimenid = new GXUserControl();
         ucDdo_br_pathologyid = new GXUserControl();
         ucDdo_br_pathology_specimen_name = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV49Display_GXI = "";
         AV50Update_GXI = "";
         AV51Delete_GXI = "";
         scmdbuf = "";
         lV47BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name = "";
         AV48BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel = "";
         AV47BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name = "";
         H00532_A275BR_Pathology_Specimen_Name = new String[] {""} ;
         H00532_n275BR_Pathology_Specimen_Name = new bool[] {false} ;
         H00532_A226BR_PathologyID = new long[1] ;
         H00532_n226BR_PathologyID = new bool[] {false} ;
         H00532_A274BR_Pathology_SpecimenID = new long[1] ;
         H00533_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_pathology_specimenww__default(),
            new Object[][] {
                new Object[] {
               H00532_A275BR_Pathology_Specimen_Name, H00532_n275BR_Pathology_Specimen_Name, H00532_A226BR_PathologyID, H00532_n226BR_PathologyID, H00532_A274BR_Pathology_SpecimenID
               }
               , new Object[] {
               H00533_AGRID_nRecordCount
               }
            }
         );
         AV52Pgmname = "BR_Pathology_SpecimenWW";
         /* GeneXus formulas. */
         AV52Pgmname = "BR_Pathology_SpecimenWW";
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
      private short edtBR_Pathology_SpecimenID_Titleformat ;
      private short edtBR_PathologyID_Titleformat ;
      private short edtBR_Pathology_Specimen_Name_Titleformat ;
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
      private int Ddo_br_pathology_specimen_name_Datalistupdateminimumcharacters ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavDisplay_Visible ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_br_pathology_specimenidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_specimen_nametitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfbr_pathology_specimenid_Visible ;
      private int edtavTfbr_pathology_specimenid_to_Visible ;
      private int edtavTfbr_pathologyid_Visible ;
      private int edtavTfbr_pathologyid_to_Visible ;
      private int edtavTfbr_pathology_specimen_name_Visible ;
      private int edtavTfbr_pathology_specimen_name_sel_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV29PageToGo ;
      private int AV53GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV17TFBR_Pathology_SpecimenID ;
      private long AV18TFBR_Pathology_SpecimenID_To ;
      private long AV21TFBR_PathologyID ;
      private long AV22TFBR_PathologyID_To ;
      private long AV30GridCurrentPage ;
      private long AV32GridRecordCount ;
      private long AV31GridPageSize ;
      private long A274BR_Pathology_SpecimenID ;
      private long A226BR_PathologyID ;
      private long GRID_nCurrentRecord ;
      private long AV43BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid ;
      private long AV44BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to ;
      private long AV45BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid ;
      private long AV46BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_pathology_specimenid_Activeeventkey ;
      private String Ddo_br_pathology_specimenid_Filteredtext_get ;
      private String Ddo_br_pathology_specimenid_Filteredtextto_get ;
      private String Ddo_br_pathologyid_Activeeventkey ;
      private String Ddo_br_pathologyid_Filteredtext_get ;
      private String Ddo_br_pathologyid_Filteredtextto_get ;
      private String Ddo_br_pathology_specimen_name_Activeeventkey ;
      private String Ddo_br_pathology_specimen_name_Filteredtext_get ;
      private String Ddo_br_pathology_specimen_name_Selectedvalue_get ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_31_idx="0001" ;
      private String AV52Pgmname ;
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
      private String Ddo_br_pathology_specimenid_Caption ;
      private String Ddo_br_pathology_specimenid_Tooltip ;
      private String Ddo_br_pathology_specimenid_Cls ;
      private String Ddo_br_pathology_specimenid_Filteredtext_set ;
      private String Ddo_br_pathology_specimenid_Filteredtextto_set ;
      private String Ddo_br_pathology_specimenid_Dropdownoptionstype ;
      private String Ddo_br_pathology_specimenid_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_specimenid_Sortedstatus ;
      private String Ddo_br_pathology_specimenid_Filtertype ;
      private String Ddo_br_pathology_specimenid_Sortasc ;
      private String Ddo_br_pathology_specimenid_Sortdsc ;
      private String Ddo_br_pathology_specimenid_Cleanfilter ;
      private String Ddo_br_pathology_specimenid_Rangefilterfrom ;
      private String Ddo_br_pathology_specimenid_Rangefilterto ;
      private String Ddo_br_pathology_specimenid_Searchbuttontext ;
      private String Ddo_br_pathologyid_Caption ;
      private String Ddo_br_pathologyid_Tooltip ;
      private String Ddo_br_pathologyid_Cls ;
      private String Ddo_br_pathologyid_Filteredtext_set ;
      private String Ddo_br_pathologyid_Filteredtextto_set ;
      private String Ddo_br_pathologyid_Dropdownoptionstype ;
      private String Ddo_br_pathologyid_Titlecontrolidtoreplace ;
      private String Ddo_br_pathologyid_Sortedstatus ;
      private String Ddo_br_pathologyid_Filtertype ;
      private String Ddo_br_pathologyid_Sortasc ;
      private String Ddo_br_pathologyid_Sortdsc ;
      private String Ddo_br_pathologyid_Cleanfilter ;
      private String Ddo_br_pathologyid_Rangefilterfrom ;
      private String Ddo_br_pathologyid_Rangefilterto ;
      private String Ddo_br_pathologyid_Searchbuttontext ;
      private String Ddo_br_pathology_specimen_name_Caption ;
      private String Ddo_br_pathology_specimen_name_Tooltip ;
      private String Ddo_br_pathology_specimen_name_Cls ;
      private String Ddo_br_pathology_specimen_name_Filteredtext_set ;
      private String Ddo_br_pathology_specimen_name_Selectedvalue_set ;
      private String Ddo_br_pathology_specimen_name_Dropdownoptionstype ;
      private String Ddo_br_pathology_specimen_name_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_specimen_name_Sortedstatus ;
      private String Ddo_br_pathology_specimen_name_Filtertype ;
      private String Ddo_br_pathology_specimen_name_Datalisttype ;
      private String Ddo_br_pathology_specimen_name_Datalistproc ;
      private String Ddo_br_pathology_specimen_name_Sortasc ;
      private String Ddo_br_pathology_specimen_name_Sortdsc ;
      private String Ddo_br_pathology_specimen_name_Loadingdata ;
      private String Ddo_br_pathology_specimen_name_Cleanfilter ;
      private String Ddo_br_pathology_specimen_name_Noresultsfound ;
      private String Ddo_br_pathology_specimen_name_Searchbuttontext ;
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
      private String edtBR_Pathology_SpecimenID_Title ;
      private String edtBR_PathologyID_Title ;
      private String edtBR_Pathology_Specimen_Name_Title ;
      private String subGrid_Header ;
      private String edtavDisplay_Link ;
      private String edtavDisplay_Tooltiptext ;
      private String edtavUpdate_Link ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavDelete_Link ;
      private String edtavDelete_Tooltiptext ;
      private String edtBR_Pathology_Specimen_Name_Link ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_pathology_specimenid_Internalname ;
      private String edtavDdo_br_pathology_specimenidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathologyid_Internalname ;
      private String edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_specimen_name_Internalname ;
      private String edtavDdo_br_pathology_specimen_nametitlecontrolidtoreplace_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavTfbr_pathology_specimenid_Internalname ;
      private String edtavTfbr_pathology_specimenid_Jsonclick ;
      private String edtavTfbr_pathology_specimenid_to_Internalname ;
      private String edtavTfbr_pathology_specimenid_to_Jsonclick ;
      private String edtavTfbr_pathologyid_Internalname ;
      private String edtavTfbr_pathologyid_Jsonclick ;
      private String edtavTfbr_pathologyid_to_Internalname ;
      private String edtavTfbr_pathologyid_to_Jsonclick ;
      private String edtavTfbr_pathology_specimen_name_Internalname ;
      private String edtavTfbr_pathology_specimen_name_Jsonclick ;
      private String edtavTfbr_pathology_specimen_name_sel_Internalname ;
      private String edtavTfbr_pathology_specimen_name_sel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDisplay_Internalname ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String edtBR_Pathology_SpecimenID_Internalname ;
      private String edtBR_PathologyID_Internalname ;
      private String edtBR_Pathology_Specimen_Name_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_31_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtBR_Pathology_SpecimenID_Jsonclick ;
      private String edtBR_PathologyID_Jsonclick ;
      private String edtBR_Pathology_Specimen_Name_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV14OrderedDsc ;
      private bool AV39IsAuthorized_Display ;
      private bool AV40IsAuthorized_BR_Pathology_Specimen_Name ;
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
      private bool Ddo_br_pathology_specimenid_Includesortasc ;
      private bool Ddo_br_pathology_specimenid_Includesortdsc ;
      private bool Ddo_br_pathology_specimenid_Includefilter ;
      private bool Ddo_br_pathology_specimenid_Filterisrange ;
      private bool Ddo_br_pathology_specimenid_Includedatalist ;
      private bool Ddo_br_pathologyid_Includesortasc ;
      private bool Ddo_br_pathologyid_Includesortdsc ;
      private bool Ddo_br_pathologyid_Includefilter ;
      private bool Ddo_br_pathologyid_Filterisrange ;
      private bool Ddo_br_pathologyid_Includedatalist ;
      private bool Ddo_br_pathology_specimen_name_Includesortasc ;
      private bool Ddo_br_pathology_specimen_name_Includesortdsc ;
      private bool Ddo_br_pathology_specimen_name_Includefilter ;
      private bool Ddo_br_pathology_specimen_name_Filterisrange ;
      private bool Ddo_br_pathology_specimen_name_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_31_Refreshing=false ;
      private bool n226BR_PathologyID ;
      private bool n275BR_Pathology_Specimen_Name ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool GXt_boolean1 ;
      private bool AV33Display_IsBlob ;
      private bool AV34Update_IsBlob ;
      private bool AV36Delete_IsBlob ;
      private String AV25TFBR_Pathology_Specimen_Name ;
      private String AV26TFBR_Pathology_Specimen_Name_Sel ;
      private String AV19ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace ;
      private String AV23ddo_BR_PathologyIDTitleControlIdToReplace ;
      private String AV27ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace ;
      private String A275BR_Pathology_Specimen_Name ;
      private String AV49Display_GXI ;
      private String AV50Update_GXI ;
      private String AV51Delete_GXI ;
      private String lV47BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name ;
      private String AV48BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel ;
      private String AV47BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name ;
      private String AV33Display ;
      private String AV34Update ;
      private String AV36Delete ;
      private IGxSession AV15Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_pathology_specimenid ;
      private GXUserControl ucDdo_br_pathologyid ;
      private GXUserControl ucDdo_br_pathology_specimen_name ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H00532_A275BR_Pathology_Specimen_Name ;
      private bool[] H00532_n275BR_Pathology_Specimen_Name ;
      private long[] H00532_A226BR_PathologyID ;
      private bool[] H00532_n226BR_PathologyID ;
      private long[] H00532_A274BR_Pathology_SpecimenID ;
      private long[] H00533_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV16BR_Pathology_SpecimenIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV20BR_PathologyIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV24BR_Pathology_Specimen_NameTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV11GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV12GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV28DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class br_pathology_specimenww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00532( IGxContext context ,
                                             long AV43BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid ,
                                             long AV44BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to ,
                                             long AV45BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid ,
                                             long AV46BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to ,
                                             String AV48BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel ,
                                             String AV47BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name ,
                                             long A274BR_Pathology_SpecimenID ,
                                             long A226BR_PathologyID ,
                                             String A275BR_Pathology_Specimen_Name ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
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
         sSelectString = " [BR_Pathology_Specimen_Name], [BR_PathologyID], [BR_Pathology_SpecimenID]";
         sFromString = " FROM [BR_Pathology_Specimen] WITH (NOLOCK)";
         sOrderString = "";
         if ( ! (0==AV43BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_SpecimenID] >= @AV43BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_SpecimenID] >= @AV43BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ! (0==AV44BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_SpecimenID] <= @AV44BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_SpecimenID] <= @AV44BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to)";
            }
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV45BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] >= @AV45BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] >= @AV45BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid)";
            }
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (0==AV46BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] <= @AV46BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] <= @AV46BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to)";
            }
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV48BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Specimen_Name] like @lV47BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Specimen_Name] like @lV47BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name)";
            }
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Specimen_Name] = @AV48BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Specimen_Name] = @AV48BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel)";
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
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_SpecimenID]";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_SpecimenID] DESC";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_PathologyID]";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_PathologyID] DESC";
         }
         else if ( ( AV13OrderedBy == 3 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Specimen_Name]";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Specimen_Name] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_SpecimenID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H00533( IGxContext context ,
                                             long AV43BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid ,
                                             long AV44BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to ,
                                             long AV45BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid ,
                                             long AV46BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to ,
                                             String AV48BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel ,
                                             String AV47BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name ,
                                             long A274BR_Pathology_SpecimenID ,
                                             long A226BR_PathologyID ,
                                             String A275BR_Pathology_Specimen_Name ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [6] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [BR_Pathology_Specimen] WITH (NOLOCK)";
         if ( ! (0==AV43BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_SpecimenID] >= @AV43BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_SpecimenID] >= @AV43BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid)";
            }
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ! (0==AV44BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_SpecimenID] <= @AV44BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_SpecimenID] <= @AV44BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to)";
            }
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( ! (0==AV45BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] >= @AV45BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] >= @AV45BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid)";
            }
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! (0==AV46BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] <= @AV46BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] <= @AV46BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to)";
            }
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV48BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Specimen_Name] like @lV47BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Specimen_Name] like @lV47BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name)";
            }
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Specimen_Name] = @AV48BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Specimen_Name] = @AV48BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel)";
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
                     return conditional_H00532(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (short)dynConstraints[9] , (bool)dynConstraints[10] );
               case 1 :
                     return conditional_H00533(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (short)dynConstraints[9] , (bool)dynConstraints[10] );
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
          Object[] prmH00532 ;
          prmH00532 = new Object[] {
          new Object[] {"@AV43BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV44BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV45BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV46BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV47BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV48BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00533 ;
          prmH00533 = new Object[] {
          new Object[] {"@AV43BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV44BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV45BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV46BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV47BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV48BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel",SqlDbType.NVarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00532", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00532,11,0,true,false )
             ,new CursorDef("H00533", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00533,1,0,true,false )
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
                ((long[]) buf[2])[0] = rslt.getLong(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((long[]) buf[4])[0] = rslt.getLong(3) ;
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
                   stmt.SetParameter(sIdx, (long)parms[10]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[11]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[12]);
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
                   stmt.SetParameter(sIdx, (long)parms[7]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[8]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[9]);
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
