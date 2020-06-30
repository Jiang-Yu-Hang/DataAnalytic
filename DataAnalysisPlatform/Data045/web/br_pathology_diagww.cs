/*
               File: BR_Pathology_DiagWW
        Description:  病理学诊断
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:12:31.75
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
   public class br_pathology_diagww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_pathology_diagww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_pathology_diagww( IGxContext context )
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
               AV17TFBR_Pathology_DiagID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV18TFBR_Pathology_DiagID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV21TFBR_PathologyID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV22TFBR_PathologyID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV25TFBR_Pathology_Diag_Loc = GetNextPar( );
               AV26TFBR_Pathology_Diag_Loc_Sel = GetNextPar( );
               AV29TFBR_Pathology_Diag_Organ = GetNextPar( );
               AV30TFBR_Pathology_Diag_Organ_Sel = GetNextPar( );
               AV33TFBR_Pathology_Diag_TumorType = GetNextPar( );
               AV34TFBR_Pathology_Diag_TumorType_Sel = GetNextPar( );
               AV37TFBR_Pathology_Diag_TumorStage = GetNextPar( );
               AV38TFBR_Pathology_Diag_TumorStage_Sel = GetNextPar( );
               AV41TFBR_Pathology_Diag_TumorGrade = GetNextPar( );
               AV42TFBR_Pathology_Diag_TumorGrade_Sel = GetNextPar( );
               AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace = GetNextPar( );
               AV23ddo_BR_PathologyIDTitleControlIdToReplace = GetNextPar( );
               AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace = GetNextPar( );
               AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace = GetNextPar( );
               AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace = GetNextPar( );
               AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace = GetNextPar( );
               AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace = GetNextPar( );
               AV98Pgmname = GetNextPar( );
               AV75IsAuthorized_Update = StringUtil.StrToBool( GetNextPar( ));
               AV77IsAuthorized_Delete = StringUtil.StrToBool( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Pathology_DiagID, AV18TFBR_Pathology_DiagID_To, AV21TFBR_PathologyID, AV22TFBR_PathologyID_To, AV25TFBR_Pathology_Diag_Loc, AV26TFBR_Pathology_Diag_Loc_Sel, AV29TFBR_Pathology_Diag_Organ, AV30TFBR_Pathology_Diag_Organ_Sel, AV33TFBR_Pathology_Diag_TumorType, AV34TFBR_Pathology_Diag_TumorType_Sel, AV37TFBR_Pathology_Diag_TumorStage, AV38TFBR_Pathology_Diag_TumorStage_Sel, AV41TFBR_Pathology_Diag_TumorGrade, AV42TFBR_Pathology_Diag_TumorGrade_Sel, AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace, AV23ddo_BR_PathologyIDTitleControlIdToReplace, AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace, AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace, AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace, AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace, AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace, AV98Pgmname, AV75IsAuthorized_Update, AV77IsAuthorized_Delete) ;
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
         PA552( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START552( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202281512325", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_pathology_diagww.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_DIAGID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFBR_Pathology_DiagID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_DIAGID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFBR_Pathology_DiagID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGYID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21TFBR_PathologyID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGYID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22TFBR_PathologyID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_DIAG_LOC", AV25TFBR_Pathology_Diag_Loc);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_DIAG_LOC_SEL", AV26TFBR_Pathology_Diag_Loc_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_DIAG_ORGAN", AV29TFBR_Pathology_Diag_Organ);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_DIAG_ORGAN_SEL", AV30TFBR_Pathology_Diag_Organ_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_DIAG_TUMORTYPE", AV33TFBR_Pathology_Diag_TumorType);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL", AV34TFBR_Pathology_Diag_TumorType_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_DIAG_TUMORSTAGE", AV37TFBR_Pathology_Diag_TumorStage);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL", AV38TFBR_Pathology_Diag_TumorStage_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_DIAG_TUMORGRADE", AV41TFBR_Pathology_Diag_TumorGrade);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL", AV42TFBR_Pathology_Diag_TumorGrade_Sel);
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_31", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_31), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV70GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV72GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV71GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV68DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV68DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_DIAGIDTITLEFILTERDATA", AV16BR_Pathology_DiagIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_DIAGIDTITLEFILTERDATA", AV16BR_Pathology_DiagIDTitleFilterData);
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_DIAG_LOCTITLEFILTERDATA", AV24BR_Pathology_Diag_LocTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_DIAG_LOCTITLEFILTERDATA", AV24BR_Pathology_Diag_LocTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_DIAG_ORGANTITLEFILTERDATA", AV28BR_Pathology_Diag_OrganTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_DIAG_ORGANTITLEFILTERDATA", AV28BR_Pathology_Diag_OrganTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_DIAG_TUMORTYPETITLEFILTERDATA", AV32BR_Pathology_Diag_TumorTypeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_DIAG_TUMORTYPETITLEFILTERDATA", AV32BR_Pathology_Diag_TumorTypeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_DIAG_TUMORSTAGETITLEFILTERDATA", AV36BR_Pathology_Diag_TumorStageTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_DIAG_TUMORSTAGETITLEFILTERDATA", AV36BR_Pathology_Diag_TumorStageTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_DIAG_TUMORGRADETITLEFILTERDATA", AV40BR_Pathology_Diag_TumorGradeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_DIAG_TUMORGRADETITLEFILTERDATA", AV40BR_Pathology_Diag_TumorGradeTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV98Pgmname));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_UPDATE", AV75IsAuthorized_Update);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_DELETE", AV77IsAuthorized_Delete);
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAGID_Caption", StringUtil.RTrim( Ddo_br_pathology_diagid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAGID_Tooltip", StringUtil.RTrim( Ddo_br_pathology_diagid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAGID_Cls", StringUtil.RTrim( Ddo_br_pathology_diagid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAGID_Filteredtext_set", StringUtil.RTrim( Ddo_br_pathology_diagid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAGID_Filteredtextto_set", StringUtil.RTrim( Ddo_br_pathology_diagid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAGID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_diagid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAGID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_diagid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAGID_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_diagid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAGID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_diagid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAGID_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_diagid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAGID_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_diagid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAGID_Filtertype", StringUtil.RTrim( Ddo_br_pathology_diagid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAGID_Filterisrange", StringUtil.BoolToStr( Ddo_br_pathology_diagid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAGID_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_diagid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAGID_Sortasc", StringUtil.RTrim( Ddo_br_pathology_diagid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAGID_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_diagid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAGID_Cleanfilter", StringUtil.RTrim( Ddo_br_pathology_diagid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAGID_Rangefilterfrom", StringUtil.RTrim( Ddo_br_pathology_diagid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAGID_Rangefilterto", StringUtil.RTrim( Ddo_br_pathology_diagid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAGID_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_diagid_Searchbuttontext));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_LOC_Caption", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_LOC_Tooltip", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_LOC_Cls", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_LOC_Filteredtext_set", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_LOC_Selectedvalue_set", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_LOC_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_LOC_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_LOC_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_diag_loc_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_LOC_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_diag_loc_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_LOC_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_LOC_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_diag_loc_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_LOC_Filtertype", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_LOC_Filterisrange", StringUtil.BoolToStr( Ddo_br_pathology_diag_loc_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_LOC_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_diag_loc_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_LOC_Datalisttype", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_LOC_Datalistproc", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_LOC_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_pathology_diag_loc_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_LOC_Sortasc", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_LOC_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_LOC_Loadingdata", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_LOC_Cleanfilter", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_LOC_Noresultsfound", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_LOC_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_ORGAN_Caption", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_ORGAN_Tooltip", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_ORGAN_Cls", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_ORGAN_Filteredtext_set", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_ORGAN_Selectedvalue_set", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_ORGAN_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_ORGAN_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_ORGAN_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_diag_organ_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_ORGAN_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_diag_organ_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_ORGAN_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_ORGAN_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_diag_organ_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_ORGAN_Filtertype", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_ORGAN_Filterisrange", StringUtil.BoolToStr( Ddo_br_pathology_diag_organ_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_ORGAN_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_diag_organ_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_ORGAN_Datalisttype", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_ORGAN_Datalistproc", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_ORGAN_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_pathology_diag_organ_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_ORGAN_Sortasc", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_ORGAN_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_ORGAN_Loadingdata", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_ORGAN_Cleanfilter", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_ORGAN_Noresultsfound", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_ORGAN_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Caption", StringUtil.RTrim( Ddo_br_pathology_diag_tumortype_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Tooltip", StringUtil.RTrim( Ddo_br_pathology_diag_tumortype_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Cls", StringUtil.RTrim( Ddo_br_pathology_diag_tumortype_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Filteredtext_set", StringUtil.RTrim( Ddo_br_pathology_diag_tumortype_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Selectedvalue_set", StringUtil.RTrim( Ddo_br_pathology_diag_tumortype_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_diag_tumortype_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_diag_tumortype_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_diag_tumortype_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_diag_tumortype_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_diag_tumortype_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_diag_tumortype_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Filtertype", StringUtil.RTrim( Ddo_br_pathology_diag_tumortype_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Filterisrange", StringUtil.BoolToStr( Ddo_br_pathology_diag_tumortype_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_diag_tumortype_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Datalisttype", StringUtil.RTrim( Ddo_br_pathology_diag_tumortype_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Datalistproc", StringUtil.RTrim( Ddo_br_pathology_diag_tumortype_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_pathology_diag_tumortype_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Sortasc", StringUtil.RTrim( Ddo_br_pathology_diag_tumortype_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_diag_tumortype_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Loadingdata", StringUtil.RTrim( Ddo_br_pathology_diag_tumortype_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Cleanfilter", StringUtil.RTrim( Ddo_br_pathology_diag_tumortype_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Noresultsfound", StringUtil.RTrim( Ddo_br_pathology_diag_tumortype_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_diag_tumortype_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Caption", StringUtil.RTrim( Ddo_br_pathology_diag_tumorstage_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Tooltip", StringUtil.RTrim( Ddo_br_pathology_diag_tumorstage_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Cls", StringUtil.RTrim( Ddo_br_pathology_diag_tumorstage_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Filteredtext_set", StringUtil.RTrim( Ddo_br_pathology_diag_tumorstage_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Selectedvalue_set", StringUtil.RTrim( Ddo_br_pathology_diag_tumorstage_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_diag_tumorstage_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_diag_tumorstage_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_diag_tumorstage_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_diag_tumorstage_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_diag_tumorstage_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_diag_tumorstage_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Filtertype", StringUtil.RTrim( Ddo_br_pathology_diag_tumorstage_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Filterisrange", StringUtil.BoolToStr( Ddo_br_pathology_diag_tumorstage_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_diag_tumorstage_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Datalisttype", StringUtil.RTrim( Ddo_br_pathology_diag_tumorstage_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Datalistproc", StringUtil.RTrim( Ddo_br_pathology_diag_tumorstage_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_pathology_diag_tumorstage_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Sortasc", StringUtil.RTrim( Ddo_br_pathology_diag_tumorstage_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_diag_tumorstage_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Loadingdata", StringUtil.RTrim( Ddo_br_pathology_diag_tumorstage_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Cleanfilter", StringUtil.RTrim( Ddo_br_pathology_diag_tumorstage_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Noresultsfound", StringUtil.RTrim( Ddo_br_pathology_diag_tumorstage_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_diag_tumorstage_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Caption", StringUtil.RTrim( Ddo_br_pathology_diag_tumorgrade_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Tooltip", StringUtil.RTrim( Ddo_br_pathology_diag_tumorgrade_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Cls", StringUtil.RTrim( Ddo_br_pathology_diag_tumorgrade_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Filteredtext_set", StringUtil.RTrim( Ddo_br_pathology_diag_tumorgrade_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Selectedvalue_set", StringUtil.RTrim( Ddo_br_pathology_diag_tumorgrade_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_diag_tumorgrade_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_diag_tumorgrade_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_diag_tumorgrade_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_diag_tumorgrade_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_diag_tumorgrade_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_diag_tumorgrade_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Filtertype", StringUtil.RTrim( Ddo_br_pathology_diag_tumorgrade_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Filterisrange", StringUtil.BoolToStr( Ddo_br_pathology_diag_tumorgrade_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_diag_tumorgrade_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Datalisttype", StringUtil.RTrim( Ddo_br_pathology_diag_tumorgrade_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Datalistproc", StringUtil.RTrim( Ddo_br_pathology_diag_tumorgrade_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_pathology_diag_tumorgrade_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Sortasc", StringUtil.RTrim( Ddo_br_pathology_diag_tumorgrade_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_diag_tumorgrade_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Loadingdata", StringUtil.RTrim( Ddo_br_pathology_diag_tumorgrade_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Cleanfilter", StringUtil.RTrim( Ddo_br_pathology_diag_tumorgrade_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Noresultsfound", StringUtil.RTrim( Ddo_br_pathology_diag_tumorgrade_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_diag_tumorgrade_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAGID_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_diagid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAGID_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_diagid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAGID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_pathology_diagid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathologyid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_pathologyid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_LOC_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_LOC_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_LOC_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_ORGAN_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_ORGAN_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_ORGAN_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_diag_tumortype_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_diag_tumortype_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathology_diag_tumortype_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_diag_tumorstage_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_diag_tumorstage_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathology_diag_tumorstage_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_diag_tumorgrade_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_diag_tumorgrade_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathology_diag_tumorgrade_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAGID_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_diagid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAGID_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_diagid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAGID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_pathology_diagid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathologyid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_pathologyid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_LOC_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_LOC_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_LOC_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathology_diag_loc_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_ORGAN_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_ORGAN_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_ORGAN_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathology_diag_organ_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_diag_tumortype_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_diag_tumortype_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathology_diag_tumortype_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_diag_tumorstage_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_diag_tumorstage_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathology_diag_tumorstage_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_diag_tumorgrade_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_diag_tumorgrade_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathology_diag_tumorgrade_Selectedvalue_get));
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
            WE552( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT552( ) ;
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
         return formatLink("br_pathology_diagww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "BR_Pathology_DiagWW" ;
      }

      public override String GetPgmdesc( )
      {
         return " 病理学诊断" ;
      }

      protected void WB550( )
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
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(31), 2, 0)+","+"null"+");", "插入", bttBtninsert_Jsonclick, 5, "插入", "", StyleString, ClassString, bttBtninsert_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Pathology_DiagWW.htm");
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
               if ( edtBR_Pathology_DiagID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_DiagID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_DiagID_Title) ;
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
               if ( edtBR_Pathology_Diag_Loc_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_Diag_Loc_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_Diag_Loc_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Pathology_Diag_Organ_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_Diag_Organ_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_Diag_Organ_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Pathology_Diag_TumorType_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_Diag_TumorType_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_Diag_TumorType_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Pathology_Diag_TumorStage_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_Diag_TumorStage_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_Diag_TumorStage_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Pathology_Diag_TumorGrade_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_Diag_TumorGrade_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_Diag_TumorGrade_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV73Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV74Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV76Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A276BR_Pathology_DiagID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_DiagID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_DiagID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A226BR_PathologyID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_PathologyID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_PathologyID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A277BR_Pathology_Diag_Loc);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_Diag_Loc_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_Diag_Loc_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtBR_Pathology_Diag_Loc_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A278BR_Pathology_Diag_Organ);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_Diag_Organ_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_Diag_Organ_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A279BR_Pathology_Diag_TumorType);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_Diag_TumorType_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_Diag_TumorType_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A280BR_Pathology_Diag_TumorStage);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_Diag_TumorStage_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_Diag_TumorStage_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A281BR_Pathology_Diag_TumorGrade);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_Diag_TumorGrade_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_Diag_TumorGrade_Titleformat), 4, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV70GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV72GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV71GridPageSize);
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
            ucDdo_br_pathology_diagid.SetProperty("Caption", Ddo_br_pathology_diagid_Caption);
            ucDdo_br_pathology_diagid.SetProperty("Tooltip", Ddo_br_pathology_diagid_Tooltip);
            ucDdo_br_pathology_diagid.SetProperty("Cls", Ddo_br_pathology_diagid_Cls);
            ucDdo_br_pathology_diagid.SetProperty("DropDownOptionsType", Ddo_br_pathology_diagid_Dropdownoptionstype);
            ucDdo_br_pathology_diagid.SetProperty("IncludeSortASC", Ddo_br_pathology_diagid_Includesortasc);
            ucDdo_br_pathology_diagid.SetProperty("IncludeSortDSC", Ddo_br_pathology_diagid_Includesortdsc);
            ucDdo_br_pathology_diagid.SetProperty("IncludeFilter", Ddo_br_pathology_diagid_Includefilter);
            ucDdo_br_pathology_diagid.SetProperty("FilterType", Ddo_br_pathology_diagid_Filtertype);
            ucDdo_br_pathology_diagid.SetProperty("FilterIsRange", Ddo_br_pathology_diagid_Filterisrange);
            ucDdo_br_pathology_diagid.SetProperty("IncludeDataList", Ddo_br_pathology_diagid_Includedatalist);
            ucDdo_br_pathology_diagid.SetProperty("SortASC", Ddo_br_pathology_diagid_Sortasc);
            ucDdo_br_pathology_diagid.SetProperty("SortDSC", Ddo_br_pathology_diagid_Sortdsc);
            ucDdo_br_pathology_diagid.SetProperty("CleanFilter", Ddo_br_pathology_diagid_Cleanfilter);
            ucDdo_br_pathology_diagid.SetProperty("RangeFilterFrom", Ddo_br_pathology_diagid_Rangefilterfrom);
            ucDdo_br_pathology_diagid.SetProperty("RangeFilterTo", Ddo_br_pathology_diagid_Rangefilterto);
            ucDdo_br_pathology_diagid.SetProperty("SearchButtonText", Ddo_br_pathology_diagid_Searchbuttontext);
            ucDdo_br_pathology_diagid.SetProperty("DropDownOptionsTitleSettingsIcons", AV68DDO_TitleSettingsIcons);
            ucDdo_br_pathology_diagid.SetProperty("DropDownOptionsData", AV16BR_Pathology_DiagIDTitleFilterData);
            ucDdo_br_pathology_diagid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_diagid_Internalname, "DDO_BR_PATHOLOGY_DIAGIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_diagidtitlecontrolidtoreplace_Internalname, AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", 0, edtavDdo_br_pathology_diagidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_DiagWW.htm");
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
            ucDdo_br_pathologyid.SetProperty("DropDownOptionsTitleSettingsIcons", AV68DDO_TitleSettingsIcons);
            ucDdo_br_pathologyid.SetProperty("DropDownOptionsData", AV20BR_PathologyIDTitleFilterData);
            ucDdo_br_pathologyid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathologyid_Internalname, "DDO_BR_PATHOLOGYIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname, AV23ddo_BR_PathologyIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", 0, edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_DiagWW.htm");
            /* User Defined Control */
            ucDdo_br_pathology_diag_loc.SetProperty("Caption", Ddo_br_pathology_diag_loc_Caption);
            ucDdo_br_pathology_diag_loc.SetProperty("Tooltip", Ddo_br_pathology_diag_loc_Tooltip);
            ucDdo_br_pathology_diag_loc.SetProperty("Cls", Ddo_br_pathology_diag_loc_Cls);
            ucDdo_br_pathology_diag_loc.SetProperty("DropDownOptionsType", Ddo_br_pathology_diag_loc_Dropdownoptionstype);
            ucDdo_br_pathology_diag_loc.SetProperty("IncludeSortASC", Ddo_br_pathology_diag_loc_Includesortasc);
            ucDdo_br_pathology_diag_loc.SetProperty("IncludeSortDSC", Ddo_br_pathology_diag_loc_Includesortdsc);
            ucDdo_br_pathology_diag_loc.SetProperty("IncludeFilter", Ddo_br_pathology_diag_loc_Includefilter);
            ucDdo_br_pathology_diag_loc.SetProperty("FilterType", Ddo_br_pathology_diag_loc_Filtertype);
            ucDdo_br_pathology_diag_loc.SetProperty("FilterIsRange", Ddo_br_pathology_diag_loc_Filterisrange);
            ucDdo_br_pathology_diag_loc.SetProperty("IncludeDataList", Ddo_br_pathology_diag_loc_Includedatalist);
            ucDdo_br_pathology_diag_loc.SetProperty("DataListType", Ddo_br_pathology_diag_loc_Datalisttype);
            ucDdo_br_pathology_diag_loc.SetProperty("DataListProc", Ddo_br_pathology_diag_loc_Datalistproc);
            ucDdo_br_pathology_diag_loc.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_pathology_diag_loc_Datalistupdateminimumcharacters);
            ucDdo_br_pathology_diag_loc.SetProperty("SortASC", Ddo_br_pathology_diag_loc_Sortasc);
            ucDdo_br_pathology_diag_loc.SetProperty("SortDSC", Ddo_br_pathology_diag_loc_Sortdsc);
            ucDdo_br_pathology_diag_loc.SetProperty("LoadingData", Ddo_br_pathology_diag_loc_Loadingdata);
            ucDdo_br_pathology_diag_loc.SetProperty("CleanFilter", Ddo_br_pathology_diag_loc_Cleanfilter);
            ucDdo_br_pathology_diag_loc.SetProperty("NoResultsFound", Ddo_br_pathology_diag_loc_Noresultsfound);
            ucDdo_br_pathology_diag_loc.SetProperty("SearchButtonText", Ddo_br_pathology_diag_loc_Searchbuttontext);
            ucDdo_br_pathology_diag_loc.SetProperty("DropDownOptionsTitleSettingsIcons", AV68DDO_TitleSettingsIcons);
            ucDdo_br_pathology_diag_loc.SetProperty("DropDownOptionsData", AV24BR_Pathology_Diag_LocTitleFilterData);
            ucDdo_br_pathology_diag_loc.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_diag_loc_Internalname, "DDO_BR_PATHOLOGY_DIAG_LOCContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_diag_loctitlecontrolidtoreplace_Internalname, AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", 0, edtavDdo_br_pathology_diag_loctitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_DiagWW.htm");
            /* User Defined Control */
            ucDdo_br_pathology_diag_organ.SetProperty("Caption", Ddo_br_pathology_diag_organ_Caption);
            ucDdo_br_pathology_diag_organ.SetProperty("Tooltip", Ddo_br_pathology_diag_organ_Tooltip);
            ucDdo_br_pathology_diag_organ.SetProperty("Cls", Ddo_br_pathology_diag_organ_Cls);
            ucDdo_br_pathology_diag_organ.SetProperty("DropDownOptionsType", Ddo_br_pathology_diag_organ_Dropdownoptionstype);
            ucDdo_br_pathology_diag_organ.SetProperty("IncludeSortASC", Ddo_br_pathology_diag_organ_Includesortasc);
            ucDdo_br_pathology_diag_organ.SetProperty("IncludeSortDSC", Ddo_br_pathology_diag_organ_Includesortdsc);
            ucDdo_br_pathology_diag_organ.SetProperty("IncludeFilter", Ddo_br_pathology_diag_organ_Includefilter);
            ucDdo_br_pathology_diag_organ.SetProperty("FilterType", Ddo_br_pathology_diag_organ_Filtertype);
            ucDdo_br_pathology_diag_organ.SetProperty("FilterIsRange", Ddo_br_pathology_diag_organ_Filterisrange);
            ucDdo_br_pathology_diag_organ.SetProperty("IncludeDataList", Ddo_br_pathology_diag_organ_Includedatalist);
            ucDdo_br_pathology_diag_organ.SetProperty("DataListType", Ddo_br_pathology_diag_organ_Datalisttype);
            ucDdo_br_pathology_diag_organ.SetProperty("DataListProc", Ddo_br_pathology_diag_organ_Datalistproc);
            ucDdo_br_pathology_diag_organ.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_pathology_diag_organ_Datalistupdateminimumcharacters);
            ucDdo_br_pathology_diag_organ.SetProperty("SortASC", Ddo_br_pathology_diag_organ_Sortasc);
            ucDdo_br_pathology_diag_organ.SetProperty("SortDSC", Ddo_br_pathology_diag_organ_Sortdsc);
            ucDdo_br_pathology_diag_organ.SetProperty("LoadingData", Ddo_br_pathology_diag_organ_Loadingdata);
            ucDdo_br_pathology_diag_organ.SetProperty("CleanFilter", Ddo_br_pathology_diag_organ_Cleanfilter);
            ucDdo_br_pathology_diag_organ.SetProperty("NoResultsFound", Ddo_br_pathology_diag_organ_Noresultsfound);
            ucDdo_br_pathology_diag_organ.SetProperty("SearchButtonText", Ddo_br_pathology_diag_organ_Searchbuttontext);
            ucDdo_br_pathology_diag_organ.SetProperty("DropDownOptionsTitleSettingsIcons", AV68DDO_TitleSettingsIcons);
            ucDdo_br_pathology_diag_organ.SetProperty("DropDownOptionsData", AV28BR_Pathology_Diag_OrganTitleFilterData);
            ucDdo_br_pathology_diag_organ.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_diag_organ_Internalname, "DDO_BR_PATHOLOGY_DIAG_ORGANContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_diag_organtitlecontrolidtoreplace_Internalname, AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", 0, edtavDdo_br_pathology_diag_organtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_DiagWW.htm");
            /* User Defined Control */
            ucDdo_br_pathology_diag_tumortype.SetProperty("Caption", Ddo_br_pathology_diag_tumortype_Caption);
            ucDdo_br_pathology_diag_tumortype.SetProperty("Tooltip", Ddo_br_pathology_diag_tumortype_Tooltip);
            ucDdo_br_pathology_diag_tumortype.SetProperty("Cls", Ddo_br_pathology_diag_tumortype_Cls);
            ucDdo_br_pathology_diag_tumortype.SetProperty("DropDownOptionsType", Ddo_br_pathology_diag_tumortype_Dropdownoptionstype);
            ucDdo_br_pathology_diag_tumortype.SetProperty("IncludeSortASC", Ddo_br_pathology_diag_tumortype_Includesortasc);
            ucDdo_br_pathology_diag_tumortype.SetProperty("IncludeSortDSC", Ddo_br_pathology_diag_tumortype_Includesortdsc);
            ucDdo_br_pathology_diag_tumortype.SetProperty("IncludeFilter", Ddo_br_pathology_diag_tumortype_Includefilter);
            ucDdo_br_pathology_diag_tumortype.SetProperty("FilterType", Ddo_br_pathology_diag_tumortype_Filtertype);
            ucDdo_br_pathology_diag_tumortype.SetProperty("FilterIsRange", Ddo_br_pathology_diag_tumortype_Filterisrange);
            ucDdo_br_pathology_diag_tumortype.SetProperty("IncludeDataList", Ddo_br_pathology_diag_tumortype_Includedatalist);
            ucDdo_br_pathology_diag_tumortype.SetProperty("DataListType", Ddo_br_pathology_diag_tumortype_Datalisttype);
            ucDdo_br_pathology_diag_tumortype.SetProperty("DataListProc", Ddo_br_pathology_diag_tumortype_Datalistproc);
            ucDdo_br_pathology_diag_tumortype.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_pathology_diag_tumortype_Datalistupdateminimumcharacters);
            ucDdo_br_pathology_diag_tumortype.SetProperty("SortASC", Ddo_br_pathology_diag_tumortype_Sortasc);
            ucDdo_br_pathology_diag_tumortype.SetProperty("SortDSC", Ddo_br_pathology_diag_tumortype_Sortdsc);
            ucDdo_br_pathology_diag_tumortype.SetProperty("LoadingData", Ddo_br_pathology_diag_tumortype_Loadingdata);
            ucDdo_br_pathology_diag_tumortype.SetProperty("CleanFilter", Ddo_br_pathology_diag_tumortype_Cleanfilter);
            ucDdo_br_pathology_diag_tumortype.SetProperty("NoResultsFound", Ddo_br_pathology_diag_tumortype_Noresultsfound);
            ucDdo_br_pathology_diag_tumortype.SetProperty("SearchButtonText", Ddo_br_pathology_diag_tumortype_Searchbuttontext);
            ucDdo_br_pathology_diag_tumortype.SetProperty("DropDownOptionsTitleSettingsIcons", AV68DDO_TitleSettingsIcons);
            ucDdo_br_pathology_diag_tumortype.SetProperty("DropDownOptionsData", AV32BR_Pathology_Diag_TumorTypeTitleFilterData);
            ucDdo_br_pathology_diag_tumortype.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_diag_tumortype_Internalname, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_diag_tumortypetitlecontrolidtoreplace_Internalname, AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", 0, edtavDdo_br_pathology_diag_tumortypetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_DiagWW.htm");
            /* User Defined Control */
            ucDdo_br_pathology_diag_tumorstage.SetProperty("Caption", Ddo_br_pathology_diag_tumorstage_Caption);
            ucDdo_br_pathology_diag_tumorstage.SetProperty("Tooltip", Ddo_br_pathology_diag_tumorstage_Tooltip);
            ucDdo_br_pathology_diag_tumorstage.SetProperty("Cls", Ddo_br_pathology_diag_tumorstage_Cls);
            ucDdo_br_pathology_diag_tumorstage.SetProperty("DropDownOptionsType", Ddo_br_pathology_diag_tumorstage_Dropdownoptionstype);
            ucDdo_br_pathology_diag_tumorstage.SetProperty("IncludeSortASC", Ddo_br_pathology_diag_tumorstage_Includesortasc);
            ucDdo_br_pathology_diag_tumorstage.SetProperty("IncludeSortDSC", Ddo_br_pathology_diag_tumorstage_Includesortdsc);
            ucDdo_br_pathology_diag_tumorstage.SetProperty("IncludeFilter", Ddo_br_pathology_diag_tumorstage_Includefilter);
            ucDdo_br_pathology_diag_tumorstage.SetProperty("FilterType", Ddo_br_pathology_diag_tumorstage_Filtertype);
            ucDdo_br_pathology_diag_tumorstage.SetProperty("FilterIsRange", Ddo_br_pathology_diag_tumorstage_Filterisrange);
            ucDdo_br_pathology_diag_tumorstage.SetProperty("IncludeDataList", Ddo_br_pathology_diag_tumorstage_Includedatalist);
            ucDdo_br_pathology_diag_tumorstage.SetProperty("DataListType", Ddo_br_pathology_diag_tumorstage_Datalisttype);
            ucDdo_br_pathology_diag_tumorstage.SetProperty("DataListProc", Ddo_br_pathology_diag_tumorstage_Datalistproc);
            ucDdo_br_pathology_diag_tumorstage.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_pathology_diag_tumorstage_Datalistupdateminimumcharacters);
            ucDdo_br_pathology_diag_tumorstage.SetProperty("SortASC", Ddo_br_pathology_diag_tumorstage_Sortasc);
            ucDdo_br_pathology_diag_tumorstage.SetProperty("SortDSC", Ddo_br_pathology_diag_tumorstage_Sortdsc);
            ucDdo_br_pathology_diag_tumorstage.SetProperty("LoadingData", Ddo_br_pathology_diag_tumorstage_Loadingdata);
            ucDdo_br_pathology_diag_tumorstage.SetProperty("CleanFilter", Ddo_br_pathology_diag_tumorstage_Cleanfilter);
            ucDdo_br_pathology_diag_tumorstage.SetProperty("NoResultsFound", Ddo_br_pathology_diag_tumorstage_Noresultsfound);
            ucDdo_br_pathology_diag_tumorstage.SetProperty("SearchButtonText", Ddo_br_pathology_diag_tumorstage_Searchbuttontext);
            ucDdo_br_pathology_diag_tumorstage.SetProperty("DropDownOptionsTitleSettingsIcons", AV68DDO_TitleSettingsIcons);
            ucDdo_br_pathology_diag_tumorstage.SetProperty("DropDownOptionsData", AV36BR_Pathology_Diag_TumorStageTitleFilterData);
            ucDdo_br_pathology_diag_tumorstage.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_diag_tumorstage_Internalname, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_diag_tumorstagetitlecontrolidtoreplace_Internalname, AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,60);\"", 0, edtavDdo_br_pathology_diag_tumorstagetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_DiagWW.htm");
            /* User Defined Control */
            ucDdo_br_pathology_diag_tumorgrade.SetProperty("Caption", Ddo_br_pathology_diag_tumorgrade_Caption);
            ucDdo_br_pathology_diag_tumorgrade.SetProperty("Tooltip", Ddo_br_pathology_diag_tumorgrade_Tooltip);
            ucDdo_br_pathology_diag_tumorgrade.SetProperty("Cls", Ddo_br_pathology_diag_tumorgrade_Cls);
            ucDdo_br_pathology_diag_tumorgrade.SetProperty("DropDownOptionsType", Ddo_br_pathology_diag_tumorgrade_Dropdownoptionstype);
            ucDdo_br_pathology_diag_tumorgrade.SetProperty("IncludeSortASC", Ddo_br_pathology_diag_tumorgrade_Includesortasc);
            ucDdo_br_pathology_diag_tumorgrade.SetProperty("IncludeSortDSC", Ddo_br_pathology_diag_tumorgrade_Includesortdsc);
            ucDdo_br_pathology_diag_tumorgrade.SetProperty("IncludeFilter", Ddo_br_pathology_diag_tumorgrade_Includefilter);
            ucDdo_br_pathology_diag_tumorgrade.SetProperty("FilterType", Ddo_br_pathology_diag_tumorgrade_Filtertype);
            ucDdo_br_pathology_diag_tumorgrade.SetProperty("FilterIsRange", Ddo_br_pathology_diag_tumorgrade_Filterisrange);
            ucDdo_br_pathology_diag_tumorgrade.SetProperty("IncludeDataList", Ddo_br_pathology_diag_tumorgrade_Includedatalist);
            ucDdo_br_pathology_diag_tumorgrade.SetProperty("DataListType", Ddo_br_pathology_diag_tumorgrade_Datalisttype);
            ucDdo_br_pathology_diag_tumorgrade.SetProperty("DataListProc", Ddo_br_pathology_diag_tumorgrade_Datalistproc);
            ucDdo_br_pathology_diag_tumorgrade.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_pathology_diag_tumorgrade_Datalistupdateminimumcharacters);
            ucDdo_br_pathology_diag_tumorgrade.SetProperty("SortASC", Ddo_br_pathology_diag_tumorgrade_Sortasc);
            ucDdo_br_pathology_diag_tumorgrade.SetProperty("SortDSC", Ddo_br_pathology_diag_tumorgrade_Sortdsc);
            ucDdo_br_pathology_diag_tumorgrade.SetProperty("LoadingData", Ddo_br_pathology_diag_tumorgrade_Loadingdata);
            ucDdo_br_pathology_diag_tumorgrade.SetProperty("CleanFilter", Ddo_br_pathology_diag_tumorgrade_Cleanfilter);
            ucDdo_br_pathology_diag_tumorgrade.SetProperty("NoResultsFound", Ddo_br_pathology_diag_tumorgrade_Noresultsfound);
            ucDdo_br_pathology_diag_tumorgrade.SetProperty("SearchButtonText", Ddo_br_pathology_diag_tumorgrade_Searchbuttontext);
            ucDdo_br_pathology_diag_tumorgrade.SetProperty("DropDownOptionsTitleSettingsIcons", AV68DDO_TitleSettingsIcons);
            ucDdo_br_pathology_diag_tumorgrade.SetProperty("DropDownOptionsData", AV40BR_Pathology_Diag_TumorGradeTitleFilterData);
            ucDdo_br_pathology_diag_tumorgrade.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_diag_tumorgrade_Internalname, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_diag_tumorgradetitlecontrolidtoreplace_Internalname, AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,62);\"", 0, edtavDdo_br_pathology_diag_tumorgradetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_DiagWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_DiagWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,65);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_Pathology_DiagWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_diagid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFBR_Pathology_DiagID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV17TFBR_Pathology_DiagID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_diagid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_diagid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_DiagWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_diagid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFBR_Pathology_DiagID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV18TFBR_Pathology_DiagID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,67);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_diagid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_diagid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_DiagWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathologyid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21TFBR_PathologyID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV21TFBR_PathologyID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,68);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathologyid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathologyid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_DiagWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathologyid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22TFBR_PathologyID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV22TFBR_PathologyID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,69);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathologyid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathologyid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_DiagWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_diag_loc_Internalname, AV25TFBR_Pathology_Diag_Loc, StringUtil.RTrim( context.localUtil.Format( AV25TFBR_Pathology_Diag_Loc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,70);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_diag_loc_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_diag_loc_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_DiagWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_diag_loc_sel_Internalname, AV26TFBR_Pathology_Diag_Loc_Sel, StringUtil.RTrim( context.localUtil.Format( AV26TFBR_Pathology_Diag_Loc_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,71);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_diag_loc_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_diag_loc_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_DiagWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_diag_organ_Internalname, AV29TFBR_Pathology_Diag_Organ, StringUtil.RTrim( context.localUtil.Format( AV29TFBR_Pathology_Diag_Organ, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,72);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_diag_organ_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_diag_organ_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_DiagWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_diag_organ_sel_Internalname, AV30TFBR_Pathology_Diag_Organ_Sel, StringUtil.RTrim( context.localUtil.Format( AV30TFBR_Pathology_Diag_Organ_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,73);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_diag_organ_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_diag_organ_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_DiagWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_diag_tumortype_Internalname, AV33TFBR_Pathology_Diag_TumorType, StringUtil.RTrim( context.localUtil.Format( AV33TFBR_Pathology_Diag_TumorType, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,74);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_diag_tumortype_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_diag_tumortype_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_DiagWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 75,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_diag_tumortype_sel_Internalname, AV34TFBR_Pathology_Diag_TumorType_Sel, StringUtil.RTrim( context.localUtil.Format( AV34TFBR_Pathology_Diag_TumorType_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,75);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_diag_tumortype_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_diag_tumortype_sel_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_DiagWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_diag_tumorstage_Internalname, AV37TFBR_Pathology_Diag_TumorStage, StringUtil.RTrim( context.localUtil.Format( AV37TFBR_Pathology_Diag_TumorStage, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_diag_tumorstage_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_diag_tumorstage_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_DiagWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_diag_tumorstage_sel_Internalname, AV38TFBR_Pathology_Diag_TumorStage_Sel, StringUtil.RTrim( context.localUtil.Format( AV38TFBR_Pathology_Diag_TumorStage_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,77);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_diag_tumorstage_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_diag_tumorstage_sel_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_DiagWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_diag_tumorgrade_Internalname, AV41TFBR_Pathology_Diag_TumorGrade, StringUtil.RTrim( context.localUtil.Format( AV41TFBR_Pathology_Diag_TumorGrade, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,78);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_diag_tumorgrade_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_diag_tumorgrade_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_DiagWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 79,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_diag_tumorgrade_sel_Internalname, AV42TFBR_Pathology_Diag_TumorGrade_Sel, StringUtil.RTrim( context.localUtil.Format( AV42TFBR_Pathology_Diag_TumorGrade_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,79);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_diag_tumorgrade_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_diag_tumorgrade_sel_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_DiagWW.htm");
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

      protected void START552( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", " 病理学诊断", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP550( ) ;
      }

      protected void WS552( )
      {
         START552( ) ;
         EVT552( ) ;
      }

      protected void EVT552( )
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
                              E11552 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E12552 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_DIAGID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E13552 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGYID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E14552 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_DIAG_LOC.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E15552 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_DIAG_ORGAN.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E16552 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E17552 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E18552 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E19552 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E20552 ();
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
                              AV73Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV73Display)) ? AV95Display_GXI : context.convertURL( context.PathToRelativeUrl( AV73Display))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV73Display), true);
                              AV74Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV74Update)) ? AV96Update_GXI : context.convertURL( context.PathToRelativeUrl( AV74Update))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV74Update), true);
                              AV76Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV76Delete)) ? AV97Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV76Delete))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV76Delete), true);
                              A276BR_Pathology_DiagID = (long)(context.localUtil.CToN( cgiGet( edtBR_Pathology_DiagID_Internalname), ".", ","));
                              A226BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( edtBR_PathologyID_Internalname), ".", ","));
                              n226BR_PathologyID = false;
                              A277BR_Pathology_Diag_Loc = cgiGet( edtBR_Pathology_Diag_Loc_Internalname);
                              n277BR_Pathology_Diag_Loc = false;
                              A278BR_Pathology_Diag_Organ = cgiGet( edtBR_Pathology_Diag_Organ_Internalname);
                              n278BR_Pathology_Diag_Organ = false;
                              A279BR_Pathology_Diag_TumorType = cgiGet( edtBR_Pathology_Diag_TumorType_Internalname);
                              n279BR_Pathology_Diag_TumorType = false;
                              A280BR_Pathology_Diag_TumorStage = cgiGet( edtBR_Pathology_Diag_TumorStage_Internalname);
                              n280BR_Pathology_Diag_TumorStage = false;
                              A281BR_Pathology_Diag_TumorGrade = cgiGet( edtBR_Pathology_Diag_TumorGrade_Internalname);
                              n281BR_Pathology_Diag_TumorGrade = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E21552 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E22552 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E23552 ();
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
                                       /* Set Refresh If Tfbr_pathology_diagid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_DIAGID"), ".", ",") != Convert.ToDecimal( AV17TFBR_Pathology_DiagID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_diagid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_DIAGID_TO"), ".", ",") != Convert.ToDecimal( AV18TFBR_Pathology_DiagID_To )) )
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
                                       /* Set Refresh If Tfbr_pathology_diag_loc Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_DIAG_LOC"), AV25TFBR_Pathology_Diag_Loc) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_diag_loc_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_DIAG_LOC_SEL"), AV26TFBR_Pathology_Diag_Loc_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_diag_organ Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_DIAG_ORGAN"), AV29TFBR_Pathology_Diag_Organ) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_diag_organ_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_DIAG_ORGAN_SEL"), AV30TFBR_Pathology_Diag_Organ_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_diag_tumortype Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_DIAG_TUMORTYPE"), AV33TFBR_Pathology_Diag_TumorType) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_diag_tumortype_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL"), AV34TFBR_Pathology_Diag_TumorType_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_diag_tumorstage Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_DIAG_TUMORSTAGE"), AV37TFBR_Pathology_Diag_TumorStage) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_diag_tumorstage_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL"), AV38TFBR_Pathology_Diag_TumorStage_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_diag_tumorgrade Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_DIAG_TUMORGRADE"), AV41TFBR_Pathology_Diag_TumorGrade) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_diag_tumorgrade_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL"), AV42TFBR_Pathology_Diag_TumorGrade_Sel) != 0 )
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

      protected void WE552( )
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

      protected void PA552( )
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
               GX_FocusControl = edtavDdo_br_pathology_diagidtitlecontrolidtoreplace_Internalname;
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
                                       long AV17TFBR_Pathology_DiagID ,
                                       long AV18TFBR_Pathology_DiagID_To ,
                                       long AV21TFBR_PathologyID ,
                                       long AV22TFBR_PathologyID_To ,
                                       String AV25TFBR_Pathology_Diag_Loc ,
                                       String AV26TFBR_Pathology_Diag_Loc_Sel ,
                                       String AV29TFBR_Pathology_Diag_Organ ,
                                       String AV30TFBR_Pathology_Diag_Organ_Sel ,
                                       String AV33TFBR_Pathology_Diag_TumorType ,
                                       String AV34TFBR_Pathology_Diag_TumorType_Sel ,
                                       String AV37TFBR_Pathology_Diag_TumorStage ,
                                       String AV38TFBR_Pathology_Diag_TumorStage_Sel ,
                                       String AV41TFBR_Pathology_Diag_TumorGrade ,
                                       String AV42TFBR_Pathology_Diag_TumorGrade_Sel ,
                                       String AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace ,
                                       String AV23ddo_BR_PathologyIDTitleControlIdToReplace ,
                                       String AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace ,
                                       String AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace ,
                                       String AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace ,
                                       String AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace ,
                                       String AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace ,
                                       String AV98Pgmname ,
                                       bool AV75IsAuthorized_Update ,
                                       bool AV77IsAuthorized_Delete )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF552( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PATHOLOGY_DIAGID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A276BR_Pathology_DiagID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_PATHOLOGY_DIAGID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A276BR_Pathology_DiagID), 18, 0, ".", "")));
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
         RF552( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV98Pgmname = "BR_Pathology_DiagWW";
         context.Gx_err = 0;
      }

      protected void RF552( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 31;
         /* Execute user event: Refresh */
         E22552 ();
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
                                                 AV81BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid ,
                                                 AV82BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to ,
                                                 AV83BR_Pathology_DiagWWDS_3_Tfbr_pathologyid ,
                                                 AV84BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to ,
                                                 AV86BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel ,
                                                 AV85BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc ,
                                                 AV88BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel ,
                                                 AV87BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ ,
                                                 AV90BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel ,
                                                 AV89BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype ,
                                                 AV92BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel ,
                                                 AV91BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage ,
                                                 AV94BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel ,
                                                 AV93BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade ,
                                                 A276BR_Pathology_DiagID ,
                                                 A226BR_PathologyID ,
                                                 A277BR_Pathology_Diag_Loc ,
                                                 A278BR_Pathology_Diag_Organ ,
                                                 A279BR_Pathology_Diag_TumorType ,
                                                 A280BR_Pathology_Diag_TumorStage ,
                                                 A281BR_Pathology_Diag_TumorGrade ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                                 TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV85BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc = StringUtil.Concat( StringUtil.RTrim( AV85BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc), "%", "");
            lV87BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ = StringUtil.Concat( StringUtil.RTrim( AV87BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ), "%", "");
            lV89BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype = StringUtil.Concat( StringUtil.RTrim( AV89BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype), "%", "");
            lV91BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage = StringUtil.Concat( StringUtil.RTrim( AV91BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage), "%", "");
            lV93BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade = StringUtil.Concat( StringUtil.RTrim( AV93BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade), "%", "");
            /* Using cursor H00552 */
            pr_default.execute(0, new Object[] {AV81BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid, AV82BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to, AV83BR_Pathology_DiagWWDS_3_Tfbr_pathologyid, AV84BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to, lV85BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc, AV86BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel, lV87BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ, AV88BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel, lV89BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype, AV90BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel, lV91BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage, AV92BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel, lV93BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade, AV94BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_31_idx = 1;
            sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
            SubsflControlProps_312( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A281BR_Pathology_Diag_TumorGrade = H00552_A281BR_Pathology_Diag_TumorGrade[0];
               n281BR_Pathology_Diag_TumorGrade = H00552_n281BR_Pathology_Diag_TumorGrade[0];
               A280BR_Pathology_Diag_TumorStage = H00552_A280BR_Pathology_Diag_TumorStage[0];
               n280BR_Pathology_Diag_TumorStage = H00552_n280BR_Pathology_Diag_TumorStage[0];
               A279BR_Pathology_Diag_TumorType = H00552_A279BR_Pathology_Diag_TumorType[0];
               n279BR_Pathology_Diag_TumorType = H00552_n279BR_Pathology_Diag_TumorType[0];
               A278BR_Pathology_Diag_Organ = H00552_A278BR_Pathology_Diag_Organ[0];
               n278BR_Pathology_Diag_Organ = H00552_n278BR_Pathology_Diag_Organ[0];
               A277BR_Pathology_Diag_Loc = H00552_A277BR_Pathology_Diag_Loc[0];
               n277BR_Pathology_Diag_Loc = H00552_n277BR_Pathology_Diag_Loc[0];
               A226BR_PathologyID = H00552_A226BR_PathologyID[0];
               n226BR_PathologyID = H00552_n226BR_PathologyID[0];
               A276BR_Pathology_DiagID = H00552_A276BR_Pathology_DiagID[0];
               E23552 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 31;
            WB550( ) ;
         }
         bGXsfl_31_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes552( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PATHOLOGY_DIAGID"+"_"+sGXsfl_31_idx, GetSecureSignedToken( sGXsfl_31_idx, context.localUtil.Format( (decimal)(A276BR_Pathology_DiagID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         AV81BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid = AV17TFBR_Pathology_DiagID;
         AV82BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to = AV18TFBR_Pathology_DiagID_To;
         AV83BR_Pathology_DiagWWDS_3_Tfbr_pathologyid = AV21TFBR_PathologyID;
         AV84BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to = AV22TFBR_PathologyID_To;
         AV85BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc = AV25TFBR_Pathology_Diag_Loc;
         AV86BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel = AV26TFBR_Pathology_Diag_Loc_Sel;
         AV87BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ = AV29TFBR_Pathology_Diag_Organ;
         AV88BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel = AV30TFBR_Pathology_Diag_Organ_Sel;
         AV89BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype = AV33TFBR_Pathology_Diag_TumorType;
         AV90BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel = AV34TFBR_Pathology_Diag_TumorType_Sel;
         AV91BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage = AV37TFBR_Pathology_Diag_TumorStage;
         AV92BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel = AV38TFBR_Pathology_Diag_TumorStage_Sel;
         AV93BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade = AV41TFBR_Pathology_Diag_TumorGrade;
         AV94BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel = AV42TFBR_Pathology_Diag_TumorGrade_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV81BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid ,
                                              AV82BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to ,
                                              AV83BR_Pathology_DiagWWDS_3_Tfbr_pathologyid ,
                                              AV84BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to ,
                                              AV86BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel ,
                                              AV85BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc ,
                                              AV88BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel ,
                                              AV87BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ ,
                                              AV90BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel ,
                                              AV89BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype ,
                                              AV92BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel ,
                                              AV91BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage ,
                                              AV94BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel ,
                                              AV93BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade ,
                                              A276BR_Pathology_DiagID ,
                                              A226BR_PathologyID ,
                                              A277BR_Pathology_Diag_Loc ,
                                              A278BR_Pathology_Diag_Organ ,
                                              A279BR_Pathology_Diag_TumorType ,
                                              A280BR_Pathology_Diag_TumorStage ,
                                              A281BR_Pathology_Diag_TumorGrade ,
                                              AV13OrderedBy ,
                                              AV14OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV85BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc = StringUtil.Concat( StringUtil.RTrim( AV85BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc), "%", "");
         lV87BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ = StringUtil.Concat( StringUtil.RTrim( AV87BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ), "%", "");
         lV89BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype = StringUtil.Concat( StringUtil.RTrim( AV89BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype), "%", "");
         lV91BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage = StringUtil.Concat( StringUtil.RTrim( AV91BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage), "%", "");
         lV93BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade = StringUtil.Concat( StringUtil.RTrim( AV93BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade), "%", "");
         /* Using cursor H00553 */
         pr_default.execute(1, new Object[] {AV81BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid, AV82BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to, AV83BR_Pathology_DiagWWDS_3_Tfbr_pathologyid, AV84BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to, lV85BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc, AV86BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel, lV87BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ, AV88BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel, lV89BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype, AV90BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel, lV91BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage, AV92BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel, lV93BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade, AV94BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel});
         GRID_nRecordCount = H00553_AGRID_nRecordCount[0];
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
         AV81BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid = AV17TFBR_Pathology_DiagID;
         AV82BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to = AV18TFBR_Pathology_DiagID_To;
         AV83BR_Pathology_DiagWWDS_3_Tfbr_pathologyid = AV21TFBR_PathologyID;
         AV84BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to = AV22TFBR_PathologyID_To;
         AV85BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc = AV25TFBR_Pathology_Diag_Loc;
         AV86BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel = AV26TFBR_Pathology_Diag_Loc_Sel;
         AV87BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ = AV29TFBR_Pathology_Diag_Organ;
         AV88BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel = AV30TFBR_Pathology_Diag_Organ_Sel;
         AV89BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype = AV33TFBR_Pathology_Diag_TumorType;
         AV90BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel = AV34TFBR_Pathology_Diag_TumorType_Sel;
         AV91BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage = AV37TFBR_Pathology_Diag_TumorStage;
         AV92BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel = AV38TFBR_Pathology_Diag_TumorStage_Sel;
         AV93BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade = AV41TFBR_Pathology_Diag_TumorGrade;
         AV94BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel = AV42TFBR_Pathology_Diag_TumorGrade_Sel;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Pathology_DiagID, AV18TFBR_Pathology_DiagID_To, AV21TFBR_PathologyID, AV22TFBR_PathologyID_To, AV25TFBR_Pathology_Diag_Loc, AV26TFBR_Pathology_Diag_Loc_Sel, AV29TFBR_Pathology_Diag_Organ, AV30TFBR_Pathology_Diag_Organ_Sel, AV33TFBR_Pathology_Diag_TumorType, AV34TFBR_Pathology_Diag_TumorType_Sel, AV37TFBR_Pathology_Diag_TumorStage, AV38TFBR_Pathology_Diag_TumorStage_Sel, AV41TFBR_Pathology_Diag_TumorGrade, AV42TFBR_Pathology_Diag_TumorGrade_Sel, AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace, AV23ddo_BR_PathologyIDTitleControlIdToReplace, AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace, AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace, AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace, AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace, AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace, AV98Pgmname, AV75IsAuthorized_Update, AV77IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV81BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid = AV17TFBR_Pathology_DiagID;
         AV82BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to = AV18TFBR_Pathology_DiagID_To;
         AV83BR_Pathology_DiagWWDS_3_Tfbr_pathologyid = AV21TFBR_PathologyID;
         AV84BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to = AV22TFBR_PathologyID_To;
         AV85BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc = AV25TFBR_Pathology_Diag_Loc;
         AV86BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel = AV26TFBR_Pathology_Diag_Loc_Sel;
         AV87BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ = AV29TFBR_Pathology_Diag_Organ;
         AV88BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel = AV30TFBR_Pathology_Diag_Organ_Sel;
         AV89BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype = AV33TFBR_Pathology_Diag_TumorType;
         AV90BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel = AV34TFBR_Pathology_Diag_TumorType_Sel;
         AV91BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage = AV37TFBR_Pathology_Diag_TumorStage;
         AV92BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel = AV38TFBR_Pathology_Diag_TumorStage_Sel;
         AV93BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade = AV41TFBR_Pathology_Diag_TumorGrade;
         AV94BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel = AV42TFBR_Pathology_Diag_TumorGrade_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Pathology_DiagID, AV18TFBR_Pathology_DiagID_To, AV21TFBR_PathologyID, AV22TFBR_PathologyID_To, AV25TFBR_Pathology_Diag_Loc, AV26TFBR_Pathology_Diag_Loc_Sel, AV29TFBR_Pathology_Diag_Organ, AV30TFBR_Pathology_Diag_Organ_Sel, AV33TFBR_Pathology_Diag_TumorType, AV34TFBR_Pathology_Diag_TumorType_Sel, AV37TFBR_Pathology_Diag_TumorStage, AV38TFBR_Pathology_Diag_TumorStage_Sel, AV41TFBR_Pathology_Diag_TumorGrade, AV42TFBR_Pathology_Diag_TumorGrade_Sel, AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace, AV23ddo_BR_PathologyIDTitleControlIdToReplace, AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace, AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace, AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace, AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace, AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace, AV98Pgmname, AV75IsAuthorized_Update, AV77IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV81BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid = AV17TFBR_Pathology_DiagID;
         AV82BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to = AV18TFBR_Pathology_DiagID_To;
         AV83BR_Pathology_DiagWWDS_3_Tfbr_pathologyid = AV21TFBR_PathologyID;
         AV84BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to = AV22TFBR_PathologyID_To;
         AV85BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc = AV25TFBR_Pathology_Diag_Loc;
         AV86BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel = AV26TFBR_Pathology_Diag_Loc_Sel;
         AV87BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ = AV29TFBR_Pathology_Diag_Organ;
         AV88BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel = AV30TFBR_Pathology_Diag_Organ_Sel;
         AV89BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype = AV33TFBR_Pathology_Diag_TumorType;
         AV90BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel = AV34TFBR_Pathology_Diag_TumorType_Sel;
         AV91BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage = AV37TFBR_Pathology_Diag_TumorStage;
         AV92BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel = AV38TFBR_Pathology_Diag_TumorStage_Sel;
         AV93BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade = AV41TFBR_Pathology_Diag_TumorGrade;
         AV94BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel = AV42TFBR_Pathology_Diag_TumorGrade_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Pathology_DiagID, AV18TFBR_Pathology_DiagID_To, AV21TFBR_PathologyID, AV22TFBR_PathologyID_To, AV25TFBR_Pathology_Diag_Loc, AV26TFBR_Pathology_Diag_Loc_Sel, AV29TFBR_Pathology_Diag_Organ, AV30TFBR_Pathology_Diag_Organ_Sel, AV33TFBR_Pathology_Diag_TumorType, AV34TFBR_Pathology_Diag_TumorType_Sel, AV37TFBR_Pathology_Diag_TumorStage, AV38TFBR_Pathology_Diag_TumorStage_Sel, AV41TFBR_Pathology_Diag_TumorGrade, AV42TFBR_Pathology_Diag_TumorGrade_Sel, AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace, AV23ddo_BR_PathologyIDTitleControlIdToReplace, AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace, AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace, AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace, AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace, AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace, AV98Pgmname, AV75IsAuthorized_Update, AV77IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV81BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid = AV17TFBR_Pathology_DiagID;
         AV82BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to = AV18TFBR_Pathology_DiagID_To;
         AV83BR_Pathology_DiagWWDS_3_Tfbr_pathologyid = AV21TFBR_PathologyID;
         AV84BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to = AV22TFBR_PathologyID_To;
         AV85BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc = AV25TFBR_Pathology_Diag_Loc;
         AV86BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel = AV26TFBR_Pathology_Diag_Loc_Sel;
         AV87BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ = AV29TFBR_Pathology_Diag_Organ;
         AV88BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel = AV30TFBR_Pathology_Diag_Organ_Sel;
         AV89BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype = AV33TFBR_Pathology_Diag_TumorType;
         AV90BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel = AV34TFBR_Pathology_Diag_TumorType_Sel;
         AV91BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage = AV37TFBR_Pathology_Diag_TumorStage;
         AV92BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel = AV38TFBR_Pathology_Diag_TumorStage_Sel;
         AV93BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade = AV41TFBR_Pathology_Diag_TumorGrade;
         AV94BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel = AV42TFBR_Pathology_Diag_TumorGrade_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Pathology_DiagID, AV18TFBR_Pathology_DiagID_To, AV21TFBR_PathologyID, AV22TFBR_PathologyID_To, AV25TFBR_Pathology_Diag_Loc, AV26TFBR_Pathology_Diag_Loc_Sel, AV29TFBR_Pathology_Diag_Organ, AV30TFBR_Pathology_Diag_Organ_Sel, AV33TFBR_Pathology_Diag_TumorType, AV34TFBR_Pathology_Diag_TumorType_Sel, AV37TFBR_Pathology_Diag_TumorStage, AV38TFBR_Pathology_Diag_TumorStage_Sel, AV41TFBR_Pathology_Diag_TumorGrade, AV42TFBR_Pathology_Diag_TumorGrade_Sel, AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace, AV23ddo_BR_PathologyIDTitleControlIdToReplace, AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace, AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace, AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace, AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace, AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace, AV98Pgmname, AV75IsAuthorized_Update, AV77IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV81BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid = AV17TFBR_Pathology_DiagID;
         AV82BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to = AV18TFBR_Pathology_DiagID_To;
         AV83BR_Pathology_DiagWWDS_3_Tfbr_pathologyid = AV21TFBR_PathologyID;
         AV84BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to = AV22TFBR_PathologyID_To;
         AV85BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc = AV25TFBR_Pathology_Diag_Loc;
         AV86BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel = AV26TFBR_Pathology_Diag_Loc_Sel;
         AV87BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ = AV29TFBR_Pathology_Diag_Organ;
         AV88BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel = AV30TFBR_Pathology_Diag_Organ_Sel;
         AV89BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype = AV33TFBR_Pathology_Diag_TumorType;
         AV90BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel = AV34TFBR_Pathology_Diag_TumorType_Sel;
         AV91BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage = AV37TFBR_Pathology_Diag_TumorStage;
         AV92BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel = AV38TFBR_Pathology_Diag_TumorStage_Sel;
         AV93BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade = AV41TFBR_Pathology_Diag_TumorGrade;
         AV94BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel = AV42TFBR_Pathology_Diag_TumorGrade_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Pathology_DiagID, AV18TFBR_Pathology_DiagID_To, AV21TFBR_PathologyID, AV22TFBR_PathologyID_To, AV25TFBR_Pathology_Diag_Loc, AV26TFBR_Pathology_Diag_Loc_Sel, AV29TFBR_Pathology_Diag_Organ, AV30TFBR_Pathology_Diag_Organ_Sel, AV33TFBR_Pathology_Diag_TumorType, AV34TFBR_Pathology_Diag_TumorType_Sel, AV37TFBR_Pathology_Diag_TumorStage, AV38TFBR_Pathology_Diag_TumorStage_Sel, AV41TFBR_Pathology_Diag_TumorGrade, AV42TFBR_Pathology_Diag_TumorGrade_Sel, AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace, AV23ddo_BR_PathologyIDTitleControlIdToReplace, AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace, AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace, AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace, AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace, AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace, AV98Pgmname, AV75IsAuthorized_Update, AV77IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP550( )
      {
         /* Before Start, stand alone formulas. */
         AV98Pgmname = "BR_Pathology_DiagWW";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E21552 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV68DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_DIAGIDTITLEFILTERDATA"), AV16BR_Pathology_DiagIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGYIDTITLEFILTERDATA"), AV20BR_PathologyIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_DIAG_LOCTITLEFILTERDATA"), AV24BR_Pathology_Diag_LocTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_DIAG_ORGANTITLEFILTERDATA"), AV28BR_Pathology_Diag_OrganTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_DIAG_TUMORTYPETITLEFILTERDATA"), AV32BR_Pathology_Diag_TumorTypeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_DIAG_TUMORSTAGETITLEFILTERDATA"), AV36BR_Pathology_Diag_TumorStageTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_DIAG_TUMORGRADETITLEFILTERDATA"), AV40BR_Pathology_Diag_TumorGradeTitleFilterData);
            /* Read variables values. */
            AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_diagidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace", AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace);
            AV23ddo_BR_PathologyIDTitleControlIdToReplace = cgiGet( edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_PathologyIDTitleControlIdToReplace", AV23ddo_BR_PathologyIDTitleControlIdToReplace);
            AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_diag_loctitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace", AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace);
            AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_diag_organtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace", AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace);
            AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_diag_tumortypetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace", AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace);
            AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_diag_tumorstagetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace", AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace);
            AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_diag_tumorgradetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace", AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace);
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
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_diagid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_diagid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PATHOLOGY_DIAGID");
               GX_FocusControl = edtavTfbr_pathology_diagid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV17TFBR_Pathology_DiagID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Pathology_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Pathology_DiagID), 18, 0)));
            }
            else
            {
               AV17TFBR_Pathology_DiagID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_pathology_diagid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Pathology_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Pathology_DiagID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_diagid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_diagid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PATHOLOGY_DIAGID_TO");
               GX_FocusControl = edtavTfbr_pathology_diagid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV18TFBR_Pathology_DiagID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Pathology_DiagID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Pathology_DiagID_To), 18, 0)));
            }
            else
            {
               AV18TFBR_Pathology_DiagID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_pathology_diagid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Pathology_DiagID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Pathology_DiagID_To), 18, 0)));
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
            AV25TFBR_Pathology_Diag_Loc = cgiGet( edtavTfbr_pathology_diag_loc_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_Pathology_Diag_Loc", AV25TFBR_Pathology_Diag_Loc);
            AV26TFBR_Pathology_Diag_Loc_Sel = cgiGet( edtavTfbr_pathology_diag_loc_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_Pathology_Diag_Loc_Sel", AV26TFBR_Pathology_Diag_Loc_Sel);
            AV29TFBR_Pathology_Diag_Organ = cgiGet( edtavTfbr_pathology_diag_organ_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_Pathology_Diag_Organ", AV29TFBR_Pathology_Diag_Organ);
            AV30TFBR_Pathology_Diag_Organ_Sel = cgiGet( edtavTfbr_pathology_diag_organ_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_Pathology_Diag_Organ_Sel", AV30TFBR_Pathology_Diag_Organ_Sel);
            AV33TFBR_Pathology_Diag_TumorType = cgiGet( edtavTfbr_pathology_diag_tumortype_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TFBR_Pathology_Diag_TumorType", AV33TFBR_Pathology_Diag_TumorType);
            AV34TFBR_Pathology_Diag_TumorType_Sel = cgiGet( edtavTfbr_pathology_diag_tumortype_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFBR_Pathology_Diag_TumorType_Sel", AV34TFBR_Pathology_Diag_TumorType_Sel);
            AV37TFBR_Pathology_Diag_TumorStage = cgiGet( edtavTfbr_pathology_diag_tumorstage_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37TFBR_Pathology_Diag_TumorStage", AV37TFBR_Pathology_Diag_TumorStage);
            AV38TFBR_Pathology_Diag_TumorStage_Sel = cgiGet( edtavTfbr_pathology_diag_tumorstage_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38TFBR_Pathology_Diag_TumorStage_Sel", AV38TFBR_Pathology_Diag_TumorStage_Sel);
            AV41TFBR_Pathology_Diag_TumorGrade = cgiGet( edtavTfbr_pathology_diag_tumorgrade_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41TFBR_Pathology_Diag_TumorGrade", AV41TFBR_Pathology_Diag_TumorGrade);
            AV42TFBR_Pathology_Diag_TumorGrade_Sel = cgiGet( edtavTfbr_pathology_diag_tumorgrade_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42TFBR_Pathology_Diag_TumorGrade_Sel", AV42TFBR_Pathology_Diag_TumorGrade_Sel);
            /* Read saved values. */
            nRC_GXsfl_31 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_31"), ".", ","));
            AV70GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV72GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV71GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_pathology_diagid_Caption = cgiGet( "DDO_BR_PATHOLOGY_DIAGID_Caption");
            Ddo_br_pathology_diagid_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_DIAGID_Tooltip");
            Ddo_br_pathology_diagid_Cls = cgiGet( "DDO_BR_PATHOLOGY_DIAGID_Cls");
            Ddo_br_pathology_diagid_Filteredtext_set = cgiGet( "DDO_BR_PATHOLOGY_DIAGID_Filteredtext_set");
            Ddo_br_pathology_diagid_Filteredtextto_set = cgiGet( "DDO_BR_PATHOLOGY_DIAGID_Filteredtextto_set");
            Ddo_br_pathology_diagid_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_DIAGID_Dropdownoptionstype");
            Ddo_br_pathology_diagid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_DIAGID_Titlecontrolidtoreplace");
            Ddo_br_pathology_diagid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIAGID_Includesortasc"));
            Ddo_br_pathology_diagid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIAGID_Includesortdsc"));
            Ddo_br_pathology_diagid_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_DIAGID_Sortedstatus");
            Ddo_br_pathology_diagid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIAGID_Includefilter"));
            Ddo_br_pathology_diagid_Filtertype = cgiGet( "DDO_BR_PATHOLOGY_DIAGID_Filtertype");
            Ddo_br_pathology_diagid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIAGID_Filterisrange"));
            Ddo_br_pathology_diagid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIAGID_Includedatalist"));
            Ddo_br_pathology_diagid_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_DIAGID_Sortasc");
            Ddo_br_pathology_diagid_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_DIAGID_Sortdsc");
            Ddo_br_pathology_diagid_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGY_DIAGID_Cleanfilter");
            Ddo_br_pathology_diagid_Rangefilterfrom = cgiGet( "DDO_BR_PATHOLOGY_DIAGID_Rangefilterfrom");
            Ddo_br_pathology_diagid_Rangefilterto = cgiGet( "DDO_BR_PATHOLOGY_DIAGID_Rangefilterto");
            Ddo_br_pathology_diagid_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_DIAGID_Searchbuttontext");
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
            Ddo_br_pathology_diag_loc_Caption = cgiGet( "DDO_BR_PATHOLOGY_DIAG_LOC_Caption");
            Ddo_br_pathology_diag_loc_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_DIAG_LOC_Tooltip");
            Ddo_br_pathology_diag_loc_Cls = cgiGet( "DDO_BR_PATHOLOGY_DIAG_LOC_Cls");
            Ddo_br_pathology_diag_loc_Filteredtext_set = cgiGet( "DDO_BR_PATHOLOGY_DIAG_LOC_Filteredtext_set");
            Ddo_br_pathology_diag_loc_Selectedvalue_set = cgiGet( "DDO_BR_PATHOLOGY_DIAG_LOC_Selectedvalue_set");
            Ddo_br_pathology_diag_loc_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_DIAG_LOC_Dropdownoptionstype");
            Ddo_br_pathology_diag_loc_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_DIAG_LOC_Titlecontrolidtoreplace");
            Ddo_br_pathology_diag_loc_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIAG_LOC_Includesortasc"));
            Ddo_br_pathology_diag_loc_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIAG_LOC_Includesortdsc"));
            Ddo_br_pathology_diag_loc_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_DIAG_LOC_Sortedstatus");
            Ddo_br_pathology_diag_loc_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIAG_LOC_Includefilter"));
            Ddo_br_pathology_diag_loc_Filtertype = cgiGet( "DDO_BR_PATHOLOGY_DIAG_LOC_Filtertype");
            Ddo_br_pathology_diag_loc_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIAG_LOC_Filterisrange"));
            Ddo_br_pathology_diag_loc_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIAG_LOC_Includedatalist"));
            Ddo_br_pathology_diag_loc_Datalisttype = cgiGet( "DDO_BR_PATHOLOGY_DIAG_LOC_Datalisttype");
            Ddo_br_pathology_diag_loc_Datalistproc = cgiGet( "DDO_BR_PATHOLOGY_DIAG_LOC_Datalistproc");
            Ddo_br_pathology_diag_loc_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_PATHOLOGY_DIAG_LOC_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_pathology_diag_loc_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_DIAG_LOC_Sortasc");
            Ddo_br_pathology_diag_loc_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_DIAG_LOC_Sortdsc");
            Ddo_br_pathology_diag_loc_Loadingdata = cgiGet( "DDO_BR_PATHOLOGY_DIAG_LOC_Loadingdata");
            Ddo_br_pathology_diag_loc_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGY_DIAG_LOC_Cleanfilter");
            Ddo_br_pathology_diag_loc_Noresultsfound = cgiGet( "DDO_BR_PATHOLOGY_DIAG_LOC_Noresultsfound");
            Ddo_br_pathology_diag_loc_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_DIAG_LOC_Searchbuttontext");
            Ddo_br_pathology_diag_organ_Caption = cgiGet( "DDO_BR_PATHOLOGY_DIAG_ORGAN_Caption");
            Ddo_br_pathology_diag_organ_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_DIAG_ORGAN_Tooltip");
            Ddo_br_pathology_diag_organ_Cls = cgiGet( "DDO_BR_PATHOLOGY_DIAG_ORGAN_Cls");
            Ddo_br_pathology_diag_organ_Filteredtext_set = cgiGet( "DDO_BR_PATHOLOGY_DIAG_ORGAN_Filteredtext_set");
            Ddo_br_pathology_diag_organ_Selectedvalue_set = cgiGet( "DDO_BR_PATHOLOGY_DIAG_ORGAN_Selectedvalue_set");
            Ddo_br_pathology_diag_organ_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_DIAG_ORGAN_Dropdownoptionstype");
            Ddo_br_pathology_diag_organ_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_DIAG_ORGAN_Titlecontrolidtoreplace");
            Ddo_br_pathology_diag_organ_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIAG_ORGAN_Includesortasc"));
            Ddo_br_pathology_diag_organ_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIAG_ORGAN_Includesortdsc"));
            Ddo_br_pathology_diag_organ_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_DIAG_ORGAN_Sortedstatus");
            Ddo_br_pathology_diag_organ_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIAG_ORGAN_Includefilter"));
            Ddo_br_pathology_diag_organ_Filtertype = cgiGet( "DDO_BR_PATHOLOGY_DIAG_ORGAN_Filtertype");
            Ddo_br_pathology_diag_organ_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIAG_ORGAN_Filterisrange"));
            Ddo_br_pathology_diag_organ_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIAG_ORGAN_Includedatalist"));
            Ddo_br_pathology_diag_organ_Datalisttype = cgiGet( "DDO_BR_PATHOLOGY_DIAG_ORGAN_Datalisttype");
            Ddo_br_pathology_diag_organ_Datalistproc = cgiGet( "DDO_BR_PATHOLOGY_DIAG_ORGAN_Datalistproc");
            Ddo_br_pathology_diag_organ_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_PATHOLOGY_DIAG_ORGAN_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_pathology_diag_organ_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_DIAG_ORGAN_Sortasc");
            Ddo_br_pathology_diag_organ_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_DIAG_ORGAN_Sortdsc");
            Ddo_br_pathology_diag_organ_Loadingdata = cgiGet( "DDO_BR_PATHOLOGY_DIAG_ORGAN_Loadingdata");
            Ddo_br_pathology_diag_organ_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGY_DIAG_ORGAN_Cleanfilter");
            Ddo_br_pathology_diag_organ_Noresultsfound = cgiGet( "DDO_BR_PATHOLOGY_DIAG_ORGAN_Noresultsfound");
            Ddo_br_pathology_diag_organ_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_DIAG_ORGAN_Searchbuttontext");
            Ddo_br_pathology_diag_tumortype_Caption = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Caption");
            Ddo_br_pathology_diag_tumortype_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Tooltip");
            Ddo_br_pathology_diag_tumortype_Cls = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Cls");
            Ddo_br_pathology_diag_tumortype_Filteredtext_set = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Filteredtext_set");
            Ddo_br_pathology_diag_tumortype_Selectedvalue_set = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Selectedvalue_set");
            Ddo_br_pathology_diag_tumortype_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Dropdownoptionstype");
            Ddo_br_pathology_diag_tumortype_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Titlecontrolidtoreplace");
            Ddo_br_pathology_diag_tumortype_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Includesortasc"));
            Ddo_br_pathology_diag_tumortype_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Includesortdsc"));
            Ddo_br_pathology_diag_tumortype_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Sortedstatus");
            Ddo_br_pathology_diag_tumortype_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Includefilter"));
            Ddo_br_pathology_diag_tumortype_Filtertype = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Filtertype");
            Ddo_br_pathology_diag_tumortype_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Filterisrange"));
            Ddo_br_pathology_diag_tumortype_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Includedatalist"));
            Ddo_br_pathology_diag_tumortype_Datalisttype = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Datalisttype");
            Ddo_br_pathology_diag_tumortype_Datalistproc = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Datalistproc");
            Ddo_br_pathology_diag_tumortype_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_pathology_diag_tumortype_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Sortasc");
            Ddo_br_pathology_diag_tumortype_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Sortdsc");
            Ddo_br_pathology_diag_tumortype_Loadingdata = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Loadingdata");
            Ddo_br_pathology_diag_tumortype_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Cleanfilter");
            Ddo_br_pathology_diag_tumortype_Noresultsfound = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Noresultsfound");
            Ddo_br_pathology_diag_tumortype_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Searchbuttontext");
            Ddo_br_pathology_diag_tumorstage_Caption = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Caption");
            Ddo_br_pathology_diag_tumorstage_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Tooltip");
            Ddo_br_pathology_diag_tumorstage_Cls = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Cls");
            Ddo_br_pathology_diag_tumorstage_Filteredtext_set = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Filteredtext_set");
            Ddo_br_pathology_diag_tumorstage_Selectedvalue_set = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Selectedvalue_set");
            Ddo_br_pathology_diag_tumorstage_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Dropdownoptionstype");
            Ddo_br_pathology_diag_tumorstage_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Titlecontrolidtoreplace");
            Ddo_br_pathology_diag_tumorstage_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Includesortasc"));
            Ddo_br_pathology_diag_tumorstage_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Includesortdsc"));
            Ddo_br_pathology_diag_tumorstage_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Sortedstatus");
            Ddo_br_pathology_diag_tumorstage_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Includefilter"));
            Ddo_br_pathology_diag_tumorstage_Filtertype = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Filtertype");
            Ddo_br_pathology_diag_tumorstage_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Filterisrange"));
            Ddo_br_pathology_diag_tumorstage_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Includedatalist"));
            Ddo_br_pathology_diag_tumorstage_Datalisttype = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Datalisttype");
            Ddo_br_pathology_diag_tumorstage_Datalistproc = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Datalistproc");
            Ddo_br_pathology_diag_tumorstage_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_pathology_diag_tumorstage_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Sortasc");
            Ddo_br_pathology_diag_tumorstage_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Sortdsc");
            Ddo_br_pathology_diag_tumorstage_Loadingdata = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Loadingdata");
            Ddo_br_pathology_diag_tumorstage_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Cleanfilter");
            Ddo_br_pathology_diag_tumorstage_Noresultsfound = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Noresultsfound");
            Ddo_br_pathology_diag_tumorstage_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Searchbuttontext");
            Ddo_br_pathology_diag_tumorgrade_Caption = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Caption");
            Ddo_br_pathology_diag_tumorgrade_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Tooltip");
            Ddo_br_pathology_diag_tumorgrade_Cls = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Cls");
            Ddo_br_pathology_diag_tumorgrade_Filteredtext_set = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Filteredtext_set");
            Ddo_br_pathology_diag_tumorgrade_Selectedvalue_set = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Selectedvalue_set");
            Ddo_br_pathology_diag_tumorgrade_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Dropdownoptionstype");
            Ddo_br_pathology_diag_tumorgrade_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Titlecontrolidtoreplace");
            Ddo_br_pathology_diag_tumorgrade_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Includesortasc"));
            Ddo_br_pathology_diag_tumorgrade_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Includesortdsc"));
            Ddo_br_pathology_diag_tumorgrade_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Sortedstatus");
            Ddo_br_pathology_diag_tumorgrade_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Includefilter"));
            Ddo_br_pathology_diag_tumorgrade_Filtertype = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Filtertype");
            Ddo_br_pathology_diag_tumorgrade_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Filterisrange"));
            Ddo_br_pathology_diag_tumorgrade_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Includedatalist"));
            Ddo_br_pathology_diag_tumorgrade_Datalisttype = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Datalisttype");
            Ddo_br_pathology_diag_tumorgrade_Datalistproc = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Datalistproc");
            Ddo_br_pathology_diag_tumorgrade_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_pathology_diag_tumorgrade_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Sortasc");
            Ddo_br_pathology_diag_tumorgrade_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Sortdsc");
            Ddo_br_pathology_diag_tumorgrade_Loadingdata = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Loadingdata");
            Ddo_br_pathology_diag_tumorgrade_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Cleanfilter");
            Ddo_br_pathology_diag_tumorgrade_Noresultsfound = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Noresultsfound");
            Ddo_br_pathology_diag_tumorgrade_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_pathology_diagid_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_DIAGID_Activeeventkey");
            Ddo_br_pathology_diagid_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGY_DIAGID_Filteredtext_get");
            Ddo_br_pathology_diagid_Filteredtextto_get = cgiGet( "DDO_BR_PATHOLOGY_DIAGID_Filteredtextto_get");
            Ddo_br_pathologyid_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGYID_Activeeventkey");
            Ddo_br_pathologyid_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGYID_Filteredtext_get");
            Ddo_br_pathologyid_Filteredtextto_get = cgiGet( "DDO_BR_PATHOLOGYID_Filteredtextto_get");
            Ddo_br_pathology_diag_loc_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_DIAG_LOC_Activeeventkey");
            Ddo_br_pathology_diag_loc_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGY_DIAG_LOC_Filteredtext_get");
            Ddo_br_pathology_diag_loc_Selectedvalue_get = cgiGet( "DDO_BR_PATHOLOGY_DIAG_LOC_Selectedvalue_get");
            Ddo_br_pathology_diag_organ_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_DIAG_ORGAN_Activeeventkey");
            Ddo_br_pathology_diag_organ_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGY_DIAG_ORGAN_Filteredtext_get");
            Ddo_br_pathology_diag_organ_Selectedvalue_get = cgiGet( "DDO_BR_PATHOLOGY_DIAG_ORGAN_Selectedvalue_get");
            Ddo_br_pathology_diag_tumortype_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Activeeventkey");
            Ddo_br_pathology_diag_tumortype_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Filteredtext_get");
            Ddo_br_pathology_diag_tumortype_Selectedvalue_get = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE_Selectedvalue_get");
            Ddo_br_pathology_diag_tumorstage_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Activeeventkey");
            Ddo_br_pathology_diag_tumorstage_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Filteredtext_get");
            Ddo_br_pathology_diag_tumorstage_Selectedvalue_get = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE_Selectedvalue_get");
            Ddo_br_pathology_diag_tumorgrade_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Activeeventkey");
            Ddo_br_pathology_diag_tumorgrade_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Filteredtext_get");
            Ddo_br_pathology_diag_tumorgrade_Selectedvalue_get = cgiGet( "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE_Selectedvalue_get");
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
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_DIAGID"), ".", ",") != Convert.ToDecimal( AV17TFBR_Pathology_DiagID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_DIAGID_TO"), ".", ",") != Convert.ToDecimal( AV18TFBR_Pathology_DiagID_To )) )
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
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_DIAG_LOC"), AV25TFBR_Pathology_Diag_Loc) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_DIAG_LOC_SEL"), AV26TFBR_Pathology_Diag_Loc_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_DIAG_ORGAN"), AV29TFBR_Pathology_Diag_Organ) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_DIAG_ORGAN_SEL"), AV30TFBR_Pathology_Diag_Organ_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_DIAG_TUMORTYPE"), AV33TFBR_Pathology_Diag_TumorType) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL"), AV34TFBR_Pathology_Diag_TumorType_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_DIAG_TUMORSTAGE"), AV37TFBR_Pathology_Diag_TumorStage) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL"), AV38TFBR_Pathology_Diag_TumorStage_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_DIAG_TUMORGRADE"), AV41TFBR_Pathology_Diag_TumorGrade) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL"), AV42TFBR_Pathology_Diag_TumorGrade_Sel) != 0 )
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
         E21552 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E21552( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         edtavTfbr_pathology_diagid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_diagid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_diagid_Visible), 5, 0)), true);
         edtavTfbr_pathology_diagid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_diagid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_diagid_to_Visible), 5, 0)), true);
         edtavTfbr_pathologyid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathologyid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathologyid_Visible), 5, 0)), true);
         edtavTfbr_pathologyid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathologyid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathologyid_to_Visible), 5, 0)), true);
         edtavTfbr_pathology_diag_loc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_diag_loc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_diag_loc_Visible), 5, 0)), true);
         edtavTfbr_pathology_diag_loc_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_diag_loc_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_diag_loc_sel_Visible), 5, 0)), true);
         edtavTfbr_pathology_diag_organ_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_diag_organ_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_diag_organ_Visible), 5, 0)), true);
         edtavTfbr_pathology_diag_organ_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_diag_organ_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_diag_organ_sel_Visible), 5, 0)), true);
         edtavTfbr_pathology_diag_tumortype_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_diag_tumortype_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_diag_tumortype_Visible), 5, 0)), true);
         edtavTfbr_pathology_diag_tumortype_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_diag_tumortype_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_diag_tumortype_sel_Visible), 5, 0)), true);
         edtavTfbr_pathology_diag_tumorstage_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_diag_tumorstage_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_diag_tumorstage_Visible), 5, 0)), true);
         edtavTfbr_pathology_diag_tumorstage_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_diag_tumorstage_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_diag_tumorstage_sel_Visible), 5, 0)), true);
         edtavTfbr_pathology_diag_tumorgrade_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_diag_tumorgrade_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_diag_tumorgrade_Visible), 5, 0)), true);
         edtavTfbr_pathology_diag_tumorgrade_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_diag_tumorgrade_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_diag_tumorgrade_sel_Visible), 5, 0)), true);
         Ddo_br_pathology_diagid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_DiagID";
         ucDdo_br_pathology_diagid.SendProperty(context, "", false, Ddo_br_pathology_diagid_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_diagid_Titlecontrolidtoreplace);
         AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace = Ddo_br_pathology_diagid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace", AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace);
         edtavDdo_br_pathology_diagidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_diagidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_diagidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathologyid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_PathologyID";
         ucDdo_br_pathologyid.SendProperty(context, "", false, Ddo_br_pathologyid_Internalname, "TitleControlIdToReplace", Ddo_br_pathologyid_Titlecontrolidtoreplace);
         AV23ddo_BR_PathologyIDTitleControlIdToReplace = Ddo_br_pathologyid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_PathologyIDTitleControlIdToReplace", AV23ddo_BR_PathologyIDTitleControlIdToReplace);
         edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_diag_loc_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_Diag_Loc";
         ucDdo_br_pathology_diag_loc.SendProperty(context, "", false, Ddo_br_pathology_diag_loc_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_diag_loc_Titlecontrolidtoreplace);
         AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace = Ddo_br_pathology_diag_loc_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace", AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace);
         edtavDdo_br_pathology_diag_loctitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_diag_loctitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_diag_loctitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_diag_organ_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_Diag_Organ";
         ucDdo_br_pathology_diag_organ.SendProperty(context, "", false, Ddo_br_pathology_diag_organ_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_diag_organ_Titlecontrolidtoreplace);
         AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace = Ddo_br_pathology_diag_organ_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace", AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace);
         edtavDdo_br_pathology_diag_organtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_diag_organtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_diag_organtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_diag_tumortype_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_Diag_TumorType";
         ucDdo_br_pathology_diag_tumortype.SendProperty(context, "", false, Ddo_br_pathology_diag_tumortype_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_diag_tumortype_Titlecontrolidtoreplace);
         AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace = Ddo_br_pathology_diag_tumortype_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace", AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace);
         edtavDdo_br_pathology_diag_tumortypetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_diag_tumortypetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_diag_tumortypetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_diag_tumorstage_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_Diag_TumorStage";
         ucDdo_br_pathology_diag_tumorstage.SendProperty(context, "", false, Ddo_br_pathology_diag_tumorstage_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_diag_tumorstage_Titlecontrolidtoreplace);
         AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace = Ddo_br_pathology_diag_tumorstage_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace", AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace);
         edtavDdo_br_pathology_diag_tumorstagetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_diag_tumorstagetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_diag_tumorstagetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_diag_tumorgrade_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_Diag_TumorGrade";
         ucDdo_br_pathology_diag_tumorgrade.SendProperty(context, "", false, Ddo_br_pathology_diag_tumorgrade_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_diag_tumorgrade_Titlecontrolidtoreplace);
         AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace = Ddo_br_pathology_diag_tumorgrade_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace", AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace);
         edtavDdo_br_pathology_diag_tumorgradetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_diag_tumorgradetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_diag_tumorgradetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " 病理学诊断";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV68DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV68DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E22552( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV16BR_Pathology_DiagIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_PathologyIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_Pathology_Diag_LocTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28BR_Pathology_Diag_OrganTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32BR_Pathology_Diag_TumorTypeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV36BR_Pathology_Diag_TumorStageTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV40BR_Pathology_Diag_TumorGradeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
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
         edtBR_Pathology_DiagID_Titleformat = 2;
         edtBR_Pathology_DiagID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "病理学诊断主键", AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_DiagID_Internalname, "Title", edtBR_Pathology_DiagID_Title, !bGXsfl_31_Refreshing);
         edtBR_PathologyID_Titleformat = 2;
         edtBR_PathologyID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "病理学主键", AV23ddo_BR_PathologyIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_Internalname, "Title", edtBR_PathologyID_Title, !bGXsfl_31_Refreshing);
         edtBR_Pathology_Diag_Loc_Titleformat = 2;
         edtBR_Pathology_Diag_Loc_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "病理诊断(部位)", AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Diag_Loc_Internalname, "Title", edtBR_Pathology_Diag_Loc_Title, !bGXsfl_31_Refreshing);
         edtBR_Pathology_Diag_Organ_Titleformat = 2;
         edtBR_Pathology_Diag_Organ_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "病理诊断(器官)", AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Diag_Organ_Internalname, "Title", edtBR_Pathology_Diag_Organ_Title, !bGXsfl_31_Refreshing);
         edtBR_Pathology_Diag_TumorType_Titleformat = 2;
         edtBR_Pathology_Diag_TumorType_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "肿瘤类型", AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Diag_TumorType_Internalname, "Title", edtBR_Pathology_Diag_TumorType_Title, !bGXsfl_31_Refreshing);
         edtBR_Pathology_Diag_TumorStage_Titleformat = 2;
         edtBR_Pathology_Diag_TumorStage_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "肿瘤分期", AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Diag_TumorStage_Internalname, "Title", edtBR_Pathology_Diag_TumorStage_Title, !bGXsfl_31_Refreshing);
         edtBR_Pathology_Diag_TumorGrade_Titleformat = 2;
         edtBR_Pathology_Diag_TumorGrade_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "肿瘤分级", AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Diag_TumorGrade_Internalname, "Title", edtBR_Pathology_Diag_TumorGrade_Title, !bGXsfl_31_Refreshing);
         AV70GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV70GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV70GridCurrentPage), 10, 0)));
         AV71GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV71GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV71GridPageSize), 10, 0)));
         AV72GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV72GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV72GridRecordCount), 10, 0)));
         AV81BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid = AV17TFBR_Pathology_DiagID;
         AV82BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to = AV18TFBR_Pathology_DiagID_To;
         AV83BR_Pathology_DiagWWDS_3_Tfbr_pathologyid = AV21TFBR_PathologyID;
         AV84BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to = AV22TFBR_PathologyID_To;
         AV85BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc = AV25TFBR_Pathology_Diag_Loc;
         AV86BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel = AV26TFBR_Pathology_Diag_Loc_Sel;
         AV87BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ = AV29TFBR_Pathology_Diag_Organ;
         AV88BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel = AV30TFBR_Pathology_Diag_Organ_Sel;
         AV89BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype = AV33TFBR_Pathology_Diag_TumorType;
         AV90BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel = AV34TFBR_Pathology_Diag_TumorType_Sel;
         AV91BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage = AV37TFBR_Pathology_Diag_TumorStage;
         AV92BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel = AV38TFBR_Pathology_Diag_TumorStage_Sel;
         AV93BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade = AV41TFBR_Pathology_Diag_TumorGrade;
         AV94BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel = AV42TFBR_Pathology_Diag_TumorGrade_Sel;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Pathology_DiagIDTitleFilterData", AV16BR_Pathology_DiagIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_PathologyIDTitleFilterData", AV20BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Pathology_Diag_LocTitleFilterData", AV24BR_Pathology_Diag_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Pathology_Diag_OrganTitleFilterData", AV28BR_Pathology_Diag_OrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Pathology_Diag_TumorTypeTitleFilterData", AV32BR_Pathology_Diag_TumorTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Pathology_Diag_TumorStageTitleFilterData", AV36BR_Pathology_Diag_TumorStageTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Pathology_Diag_TumorGradeTitleFilterData", AV40BR_Pathology_Diag_TumorGradeTitleFilterData);
      }

      protected void E11552( )
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

      protected void E12552( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E13552( )
      {
         /* Ddo_br_pathology_diagid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_diagid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_pathology_diagid_Sortedstatus = "ASC";
            ucDdo_br_pathology_diagid.SendProperty(context, "", false, Ddo_br_pathology_diagid_Internalname, "SortedStatus", Ddo_br_pathology_diagid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_diagid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_pathology_diagid_Sortedstatus = "DSC";
            ucDdo_br_pathology_diagid.SendProperty(context, "", false, Ddo_br_pathology_diagid_Internalname, "SortedStatus", Ddo_br_pathology_diagid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_diagid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV17TFBR_Pathology_DiagID = (long)(NumberUtil.Val( Ddo_br_pathology_diagid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Pathology_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Pathology_DiagID), 18, 0)));
            AV18TFBR_Pathology_DiagID_To = (long)(NumberUtil.Val( Ddo_br_pathology_diagid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Pathology_DiagID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Pathology_DiagID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Pathology_DiagIDTitleFilterData", AV16BR_Pathology_DiagIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_PathologyIDTitleFilterData", AV20BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Pathology_Diag_LocTitleFilterData", AV24BR_Pathology_Diag_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Pathology_Diag_OrganTitleFilterData", AV28BR_Pathology_Diag_OrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Pathology_Diag_TumorTypeTitleFilterData", AV32BR_Pathology_Diag_TumorTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Pathology_Diag_TumorStageTitleFilterData", AV36BR_Pathology_Diag_TumorStageTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Pathology_Diag_TumorGradeTitleFilterData", AV40BR_Pathology_Diag_TumorGradeTitleFilterData);
      }

      protected void E14552( )
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
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Pathology_DiagIDTitleFilterData", AV16BR_Pathology_DiagIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_PathologyIDTitleFilterData", AV20BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Pathology_Diag_LocTitleFilterData", AV24BR_Pathology_Diag_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Pathology_Diag_OrganTitleFilterData", AV28BR_Pathology_Diag_OrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Pathology_Diag_TumorTypeTitleFilterData", AV32BR_Pathology_Diag_TumorTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Pathology_Diag_TumorStageTitleFilterData", AV36BR_Pathology_Diag_TumorStageTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Pathology_Diag_TumorGradeTitleFilterData", AV40BR_Pathology_Diag_TumorGradeTitleFilterData);
      }

      protected void E15552( )
      {
         /* Ddo_br_pathology_diag_loc_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_diag_loc_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_pathology_diag_loc_Sortedstatus = "ASC";
            ucDdo_br_pathology_diag_loc.SendProperty(context, "", false, Ddo_br_pathology_diag_loc_Internalname, "SortedStatus", Ddo_br_pathology_diag_loc_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_diag_loc_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_pathology_diag_loc_Sortedstatus = "DSC";
            ucDdo_br_pathology_diag_loc.SendProperty(context, "", false, Ddo_br_pathology_diag_loc_Internalname, "SortedStatus", Ddo_br_pathology_diag_loc_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_diag_loc_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV25TFBR_Pathology_Diag_Loc = Ddo_br_pathology_diag_loc_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_Pathology_Diag_Loc", AV25TFBR_Pathology_Diag_Loc);
            AV26TFBR_Pathology_Diag_Loc_Sel = Ddo_br_pathology_diag_loc_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_Pathology_Diag_Loc_Sel", AV26TFBR_Pathology_Diag_Loc_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Pathology_DiagIDTitleFilterData", AV16BR_Pathology_DiagIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_PathologyIDTitleFilterData", AV20BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Pathology_Diag_LocTitleFilterData", AV24BR_Pathology_Diag_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Pathology_Diag_OrganTitleFilterData", AV28BR_Pathology_Diag_OrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Pathology_Diag_TumorTypeTitleFilterData", AV32BR_Pathology_Diag_TumorTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Pathology_Diag_TumorStageTitleFilterData", AV36BR_Pathology_Diag_TumorStageTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Pathology_Diag_TumorGradeTitleFilterData", AV40BR_Pathology_Diag_TumorGradeTitleFilterData);
      }

      protected void E16552( )
      {
         /* Ddo_br_pathology_diag_organ_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_diag_organ_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_pathology_diag_organ_Sortedstatus = "ASC";
            ucDdo_br_pathology_diag_organ.SendProperty(context, "", false, Ddo_br_pathology_diag_organ_Internalname, "SortedStatus", Ddo_br_pathology_diag_organ_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_diag_organ_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_pathology_diag_organ_Sortedstatus = "DSC";
            ucDdo_br_pathology_diag_organ.SendProperty(context, "", false, Ddo_br_pathology_diag_organ_Internalname, "SortedStatus", Ddo_br_pathology_diag_organ_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_diag_organ_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV29TFBR_Pathology_Diag_Organ = Ddo_br_pathology_diag_organ_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_Pathology_Diag_Organ", AV29TFBR_Pathology_Diag_Organ);
            AV30TFBR_Pathology_Diag_Organ_Sel = Ddo_br_pathology_diag_organ_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_Pathology_Diag_Organ_Sel", AV30TFBR_Pathology_Diag_Organ_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Pathology_DiagIDTitleFilterData", AV16BR_Pathology_DiagIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_PathologyIDTitleFilterData", AV20BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Pathology_Diag_LocTitleFilterData", AV24BR_Pathology_Diag_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Pathology_Diag_OrganTitleFilterData", AV28BR_Pathology_Diag_OrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Pathology_Diag_TumorTypeTitleFilterData", AV32BR_Pathology_Diag_TumorTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Pathology_Diag_TumorStageTitleFilterData", AV36BR_Pathology_Diag_TumorStageTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Pathology_Diag_TumorGradeTitleFilterData", AV40BR_Pathology_Diag_TumorGradeTitleFilterData);
      }

      protected void E17552( )
      {
         /* Ddo_br_pathology_diag_tumortype_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_diag_tumortype_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathology_diag_tumortype_Sortedstatus = "ASC";
            ucDdo_br_pathology_diag_tumortype.SendProperty(context, "", false, Ddo_br_pathology_diag_tumortype_Internalname, "SortedStatus", Ddo_br_pathology_diag_tumortype_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_diag_tumortype_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathology_diag_tumortype_Sortedstatus = "DSC";
            ucDdo_br_pathology_diag_tumortype.SendProperty(context, "", false, Ddo_br_pathology_diag_tumortype_Internalname, "SortedStatus", Ddo_br_pathology_diag_tumortype_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_diag_tumortype_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV33TFBR_Pathology_Diag_TumorType = Ddo_br_pathology_diag_tumortype_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TFBR_Pathology_Diag_TumorType", AV33TFBR_Pathology_Diag_TumorType);
            AV34TFBR_Pathology_Diag_TumorType_Sel = Ddo_br_pathology_diag_tumortype_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFBR_Pathology_Diag_TumorType_Sel", AV34TFBR_Pathology_Diag_TumorType_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Pathology_DiagIDTitleFilterData", AV16BR_Pathology_DiagIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_PathologyIDTitleFilterData", AV20BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Pathology_Diag_LocTitleFilterData", AV24BR_Pathology_Diag_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Pathology_Diag_OrganTitleFilterData", AV28BR_Pathology_Diag_OrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Pathology_Diag_TumorTypeTitleFilterData", AV32BR_Pathology_Diag_TumorTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Pathology_Diag_TumorStageTitleFilterData", AV36BR_Pathology_Diag_TumorStageTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Pathology_Diag_TumorGradeTitleFilterData", AV40BR_Pathology_Diag_TumorGradeTitleFilterData);
      }

      protected void E18552( )
      {
         /* Ddo_br_pathology_diag_tumorstage_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_diag_tumorstage_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathology_diag_tumorstage_Sortedstatus = "ASC";
            ucDdo_br_pathology_diag_tumorstage.SendProperty(context, "", false, Ddo_br_pathology_diag_tumorstage_Internalname, "SortedStatus", Ddo_br_pathology_diag_tumorstage_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_diag_tumorstage_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathology_diag_tumorstage_Sortedstatus = "DSC";
            ucDdo_br_pathology_diag_tumorstage.SendProperty(context, "", false, Ddo_br_pathology_diag_tumorstage_Internalname, "SortedStatus", Ddo_br_pathology_diag_tumorstage_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_diag_tumorstage_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV37TFBR_Pathology_Diag_TumorStage = Ddo_br_pathology_diag_tumorstage_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37TFBR_Pathology_Diag_TumorStage", AV37TFBR_Pathology_Diag_TumorStage);
            AV38TFBR_Pathology_Diag_TumorStage_Sel = Ddo_br_pathology_diag_tumorstage_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38TFBR_Pathology_Diag_TumorStage_Sel", AV38TFBR_Pathology_Diag_TumorStage_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Pathology_DiagIDTitleFilterData", AV16BR_Pathology_DiagIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_PathologyIDTitleFilterData", AV20BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Pathology_Diag_LocTitleFilterData", AV24BR_Pathology_Diag_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Pathology_Diag_OrganTitleFilterData", AV28BR_Pathology_Diag_OrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Pathology_Diag_TumorTypeTitleFilterData", AV32BR_Pathology_Diag_TumorTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Pathology_Diag_TumorStageTitleFilterData", AV36BR_Pathology_Diag_TumorStageTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Pathology_Diag_TumorGradeTitleFilterData", AV40BR_Pathology_Diag_TumorGradeTitleFilterData);
      }

      protected void E19552( )
      {
         /* Ddo_br_pathology_diag_tumorgrade_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_diag_tumorgrade_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathology_diag_tumorgrade_Sortedstatus = "ASC";
            ucDdo_br_pathology_diag_tumorgrade.SendProperty(context, "", false, Ddo_br_pathology_diag_tumorgrade_Internalname, "SortedStatus", Ddo_br_pathology_diag_tumorgrade_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_diag_tumorgrade_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathology_diag_tumorgrade_Sortedstatus = "DSC";
            ucDdo_br_pathology_diag_tumorgrade.SendProperty(context, "", false, Ddo_br_pathology_diag_tumorgrade_Internalname, "SortedStatus", Ddo_br_pathology_diag_tumorgrade_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_diag_tumorgrade_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV41TFBR_Pathology_Diag_TumorGrade = Ddo_br_pathology_diag_tumorgrade_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41TFBR_Pathology_Diag_TumorGrade", AV41TFBR_Pathology_Diag_TumorGrade);
            AV42TFBR_Pathology_Diag_TumorGrade_Sel = Ddo_br_pathology_diag_tumorgrade_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42TFBR_Pathology_Diag_TumorGrade_Sel", AV42TFBR_Pathology_Diag_TumorGrade_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Pathology_DiagIDTitleFilterData", AV16BR_Pathology_DiagIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_PathologyIDTitleFilterData", AV20BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Pathology_Diag_LocTitleFilterData", AV24BR_Pathology_Diag_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Pathology_Diag_OrganTitleFilterData", AV28BR_Pathology_Diag_OrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Pathology_Diag_TumorTypeTitleFilterData", AV32BR_Pathology_Diag_TumorTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Pathology_Diag_TumorStageTitleFilterData", AV36BR_Pathology_Diag_TumorStageTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Pathology_Diag_TumorGradeTitleFilterData", AV40BR_Pathology_Diag_TumorGradeTitleFilterData);
      }

      private void E23552( )
      {
         /* Grid_Load Routine */
         AV73Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDisplay_Internalname, AV73Display);
         AV95Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = formatLink("br_pathology_diagview.aspx") + "?" + UrlEncode("" +A276BR_Pathology_DiagID) + "," + UrlEncode(StringUtil.RTrim(""));
         AV74Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV74Update);
         AV96Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavUpdate_Tooltiptext = "修改";
         if ( AV75IsAuthorized_Update )
         {
            edtavUpdate_Link = formatLink("br_pathology_diag.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A276BR_Pathology_DiagID);
         }
         AV76Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV76Delete);
         AV97Delete_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavDelete_Tooltiptext = "删除";
         if ( AV77IsAuthorized_Delete )
         {
            edtavDelete_Link = formatLink("br_pathology_diag.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A276BR_Pathology_DiagID);
         }
         edtBR_Pathology_Diag_Loc_Link = formatLink("br_pathology_diagview.aspx") + "?" + UrlEncode("" +A276BR_Pathology_DiagID) + "," + UrlEncode(StringUtil.RTrim(""));
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

      protected void E20552( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("br_pathology_diag.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S162( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_br_pathology_diagid_Sortedstatus = "";
         ucDdo_br_pathology_diagid.SendProperty(context, "", false, Ddo_br_pathology_diagid_Internalname, "SortedStatus", Ddo_br_pathology_diagid_Sortedstatus);
         Ddo_br_pathologyid_Sortedstatus = "";
         ucDdo_br_pathologyid.SendProperty(context, "", false, Ddo_br_pathologyid_Internalname, "SortedStatus", Ddo_br_pathologyid_Sortedstatus);
         Ddo_br_pathology_diag_loc_Sortedstatus = "";
         ucDdo_br_pathology_diag_loc.SendProperty(context, "", false, Ddo_br_pathology_diag_loc_Internalname, "SortedStatus", Ddo_br_pathology_diag_loc_Sortedstatus);
         Ddo_br_pathology_diag_organ_Sortedstatus = "";
         ucDdo_br_pathology_diag_organ.SendProperty(context, "", false, Ddo_br_pathology_diag_organ_Internalname, "SortedStatus", Ddo_br_pathology_diag_organ_Sortedstatus);
         Ddo_br_pathology_diag_tumortype_Sortedstatus = "";
         ucDdo_br_pathology_diag_tumortype.SendProperty(context, "", false, Ddo_br_pathology_diag_tumortype_Internalname, "SortedStatus", Ddo_br_pathology_diag_tumortype_Sortedstatus);
         Ddo_br_pathology_diag_tumorstage_Sortedstatus = "";
         ucDdo_br_pathology_diag_tumorstage.SendProperty(context, "", false, Ddo_br_pathology_diag_tumorstage_Internalname, "SortedStatus", Ddo_br_pathology_diag_tumorstage_Sortedstatus);
         Ddo_br_pathology_diag_tumorgrade_Sortedstatus = "";
         ucDdo_br_pathology_diag_tumorgrade.SendProperty(context, "", false, Ddo_br_pathology_diag_tumorgrade_Internalname, "SortedStatus", Ddo_br_pathology_diag_tumorgrade_Sortedstatus);
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
            Ddo_br_pathology_diagid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathology_diagid.SendProperty(context, "", false, Ddo_br_pathology_diagid_Internalname, "SortedStatus", Ddo_br_pathology_diagid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 2 )
         {
            Ddo_br_pathologyid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathologyid.SendProperty(context, "", false, Ddo_br_pathologyid_Internalname, "SortedStatus", Ddo_br_pathologyid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 3 )
         {
            Ddo_br_pathology_diag_loc_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathology_diag_loc.SendProperty(context, "", false, Ddo_br_pathology_diag_loc_Internalname, "SortedStatus", Ddo_br_pathology_diag_loc_Sortedstatus);
         }
         else if ( AV13OrderedBy == 4 )
         {
            Ddo_br_pathology_diag_organ_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathology_diag_organ.SendProperty(context, "", false, Ddo_br_pathology_diag_organ_Internalname, "SortedStatus", Ddo_br_pathology_diag_organ_Sortedstatus);
         }
         else if ( AV13OrderedBy == 5 )
         {
            Ddo_br_pathology_diag_tumortype_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathology_diag_tumortype.SendProperty(context, "", false, Ddo_br_pathology_diag_tumortype_Internalname, "SortedStatus", Ddo_br_pathology_diag_tumortype_Sortedstatus);
         }
         else if ( AV13OrderedBy == 6 )
         {
            Ddo_br_pathology_diag_tumorstage_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathology_diag_tumorstage.SendProperty(context, "", false, Ddo_br_pathology_diag_tumorstage_Internalname, "SortedStatus", Ddo_br_pathology_diag_tumorstage_Sortedstatus);
         }
         else if ( AV13OrderedBy == 7 )
         {
            Ddo_br_pathology_diag_tumorgrade_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathology_diag_tumorgrade.SendProperty(context, "", false, Ddo_br_pathology_diag_tumorgrade_Internalname, "SortedStatus", Ddo_br_pathology_diag_tumorgrade_Sortedstatus);
         }
      }

      protected void S142( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean2 = AV75IsAuthorized_Update;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Diag", out  GXt_boolean2) ;
         AV75IsAuthorized_Update = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV75IsAuthorized_Update", AV75IsAuthorized_Update);
         if ( ! ( AV75IsAuthorized_Update ) )
         {
            edtavUpdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_31_Refreshing);
         }
         GXt_boolean2 = AV77IsAuthorized_Delete;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Diag", out  GXt_boolean2) ;
         AV77IsAuthorized_Delete = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV77IsAuthorized_Delete", AV77IsAuthorized_Delete);
         if ( ! ( AV77IsAuthorized_Delete ) )
         {
            edtavDelete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Visible), 5, 0)), !bGXsfl_31_Refreshing);
         }
         GXt_boolean2 = AV78TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Diag", out  GXt_boolean2) ;
         AV78TempBoolean = GXt_boolean2;
         if ( ! ( AV78TempBoolean ) )
         {
            bttBtninsert_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtninsert_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtninsert_Visible), 5, 0)), true);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV15Session.Get(AV98Pgmname+"GridState"), "") == 0 )
         {
            AV11GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV98Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV11GridState.FromXml(AV15Session.Get(AV98Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
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
         AV99GXV1 = 1;
         while ( AV99GXV1 <= AV11GridState.gxTpr_Filtervalues.Count )
         {
            AV12GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV11GridState.gxTpr_Filtervalues.Item(AV99GXV1));
            if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_DIAGID") == 0 )
            {
               AV17TFBR_Pathology_DiagID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Pathology_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Pathology_DiagID), 18, 0)));
               AV18TFBR_Pathology_DiagID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Pathology_DiagID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Pathology_DiagID_To), 18, 0)));
               if ( ! (0==AV17TFBR_Pathology_DiagID) )
               {
                  Ddo_br_pathology_diagid_Filteredtext_set = StringUtil.Str( (decimal)(AV17TFBR_Pathology_DiagID), 18, 0);
                  ucDdo_br_pathology_diagid.SendProperty(context, "", false, Ddo_br_pathology_diagid_Internalname, "FilteredText_set", Ddo_br_pathology_diagid_Filteredtext_set);
               }
               if ( ! (0==AV18TFBR_Pathology_DiagID_To) )
               {
                  Ddo_br_pathology_diagid_Filteredtextto_set = StringUtil.Str( (decimal)(AV18TFBR_Pathology_DiagID_To), 18, 0);
                  ucDdo_br_pathology_diagid.SendProperty(context, "", false, Ddo_br_pathology_diagid_Internalname, "FilteredTextTo_set", Ddo_br_pathology_diagid_Filteredtextto_set);
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
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_DIAG_LOC") == 0 )
            {
               AV25TFBR_Pathology_Diag_Loc = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_Pathology_Diag_Loc", AV25TFBR_Pathology_Diag_Loc);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV25TFBR_Pathology_Diag_Loc)) )
               {
                  Ddo_br_pathology_diag_loc_Filteredtext_set = AV25TFBR_Pathology_Diag_Loc;
                  ucDdo_br_pathology_diag_loc.SendProperty(context, "", false, Ddo_br_pathology_diag_loc_Internalname, "FilteredText_set", Ddo_br_pathology_diag_loc_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_DIAG_LOC_SEL") == 0 )
            {
               AV26TFBR_Pathology_Diag_Loc_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_Pathology_Diag_Loc_Sel", AV26TFBR_Pathology_Diag_Loc_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26TFBR_Pathology_Diag_Loc_Sel)) )
               {
                  Ddo_br_pathology_diag_loc_Selectedvalue_set = AV26TFBR_Pathology_Diag_Loc_Sel;
                  ucDdo_br_pathology_diag_loc.SendProperty(context, "", false, Ddo_br_pathology_diag_loc_Internalname, "SelectedValue_set", Ddo_br_pathology_diag_loc_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_DIAG_ORGAN") == 0 )
            {
               AV29TFBR_Pathology_Diag_Organ = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_Pathology_Diag_Organ", AV29TFBR_Pathology_Diag_Organ);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV29TFBR_Pathology_Diag_Organ)) )
               {
                  Ddo_br_pathology_diag_organ_Filteredtext_set = AV29TFBR_Pathology_Diag_Organ;
                  ucDdo_br_pathology_diag_organ.SendProperty(context, "", false, Ddo_br_pathology_diag_organ_Internalname, "FilteredText_set", Ddo_br_pathology_diag_organ_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_DIAG_ORGAN_SEL") == 0 )
            {
               AV30TFBR_Pathology_Diag_Organ_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_Pathology_Diag_Organ_Sel", AV30TFBR_Pathology_Diag_Organ_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV30TFBR_Pathology_Diag_Organ_Sel)) )
               {
                  Ddo_br_pathology_diag_organ_Selectedvalue_set = AV30TFBR_Pathology_Diag_Organ_Sel;
                  ucDdo_br_pathology_diag_organ.SendProperty(context, "", false, Ddo_br_pathology_diag_organ_Internalname, "SelectedValue_set", Ddo_br_pathology_diag_organ_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_DIAG_TUMORTYPE") == 0 )
            {
               AV33TFBR_Pathology_Diag_TumorType = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TFBR_Pathology_Diag_TumorType", AV33TFBR_Pathology_Diag_TumorType);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV33TFBR_Pathology_Diag_TumorType)) )
               {
                  Ddo_br_pathology_diag_tumortype_Filteredtext_set = AV33TFBR_Pathology_Diag_TumorType;
                  ucDdo_br_pathology_diag_tumortype.SendProperty(context, "", false, Ddo_br_pathology_diag_tumortype_Internalname, "FilteredText_set", Ddo_br_pathology_diag_tumortype_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL") == 0 )
            {
               AV34TFBR_Pathology_Diag_TumorType_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFBR_Pathology_Diag_TumorType_Sel", AV34TFBR_Pathology_Diag_TumorType_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV34TFBR_Pathology_Diag_TumorType_Sel)) )
               {
                  Ddo_br_pathology_diag_tumortype_Selectedvalue_set = AV34TFBR_Pathology_Diag_TumorType_Sel;
                  ucDdo_br_pathology_diag_tumortype.SendProperty(context, "", false, Ddo_br_pathology_diag_tumortype_Internalname, "SelectedValue_set", Ddo_br_pathology_diag_tumortype_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_DIAG_TUMORSTAGE") == 0 )
            {
               AV37TFBR_Pathology_Diag_TumorStage = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37TFBR_Pathology_Diag_TumorStage", AV37TFBR_Pathology_Diag_TumorStage);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV37TFBR_Pathology_Diag_TumorStage)) )
               {
                  Ddo_br_pathology_diag_tumorstage_Filteredtext_set = AV37TFBR_Pathology_Diag_TumorStage;
                  ucDdo_br_pathology_diag_tumorstage.SendProperty(context, "", false, Ddo_br_pathology_diag_tumorstage_Internalname, "FilteredText_set", Ddo_br_pathology_diag_tumorstage_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL") == 0 )
            {
               AV38TFBR_Pathology_Diag_TumorStage_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38TFBR_Pathology_Diag_TumorStage_Sel", AV38TFBR_Pathology_Diag_TumorStage_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV38TFBR_Pathology_Diag_TumorStage_Sel)) )
               {
                  Ddo_br_pathology_diag_tumorstage_Selectedvalue_set = AV38TFBR_Pathology_Diag_TumorStage_Sel;
                  ucDdo_br_pathology_diag_tumorstage.SendProperty(context, "", false, Ddo_br_pathology_diag_tumorstage_Internalname, "SelectedValue_set", Ddo_br_pathology_diag_tumorstage_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_DIAG_TUMORGRADE") == 0 )
            {
               AV41TFBR_Pathology_Diag_TumorGrade = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41TFBR_Pathology_Diag_TumorGrade", AV41TFBR_Pathology_Diag_TumorGrade);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV41TFBR_Pathology_Diag_TumorGrade)) )
               {
                  Ddo_br_pathology_diag_tumorgrade_Filteredtext_set = AV41TFBR_Pathology_Diag_TumorGrade;
                  ucDdo_br_pathology_diag_tumorgrade.SendProperty(context, "", false, Ddo_br_pathology_diag_tumorgrade_Internalname, "FilteredText_set", Ddo_br_pathology_diag_tumorgrade_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL") == 0 )
            {
               AV42TFBR_Pathology_Diag_TumorGrade_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42TFBR_Pathology_Diag_TumorGrade_Sel", AV42TFBR_Pathology_Diag_TumorGrade_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV42TFBR_Pathology_Diag_TumorGrade_Sel)) )
               {
                  Ddo_br_pathology_diag_tumorgrade_Selectedvalue_set = AV42TFBR_Pathology_Diag_TumorGrade_Sel;
                  ucDdo_br_pathology_diag_tumorgrade.SendProperty(context, "", false, Ddo_br_pathology_diag_tumorgrade_Internalname, "SelectedValue_set", Ddo_br_pathology_diag_tumorgrade_Selectedvalue_set);
               }
            }
            AV99GXV1 = (int)(AV99GXV1+1);
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
         AV11GridState.FromXml(AV15Session.Get(AV98Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV11GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV11GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV11GridState.gxTpr_Filtervalues.Clear();
         if ( ! ( (0==AV17TFBR_Pathology_DiagID) && (0==AV18TFBR_Pathology_DiagID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_DIAGID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV17TFBR_Pathology_DiagID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV18TFBR_Pathology_DiagID_To), 18, 0);
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
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV25TFBR_Pathology_Diag_Loc)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_DIAG_LOC";
            AV12GridStateFilterValue.gxTpr_Value = AV25TFBR_Pathology_Diag_Loc;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26TFBR_Pathology_Diag_Loc_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_DIAG_LOC_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV26TFBR_Pathology_Diag_Loc_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV29TFBR_Pathology_Diag_Organ)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_DIAG_ORGAN";
            AV12GridStateFilterValue.gxTpr_Value = AV29TFBR_Pathology_Diag_Organ;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV30TFBR_Pathology_Diag_Organ_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_DIAG_ORGAN_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV30TFBR_Pathology_Diag_Organ_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV33TFBR_Pathology_Diag_TumorType)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_DIAG_TUMORTYPE";
            AV12GridStateFilterValue.gxTpr_Value = AV33TFBR_Pathology_Diag_TumorType;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV34TFBR_Pathology_Diag_TumorType_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV34TFBR_Pathology_Diag_TumorType_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV37TFBR_Pathology_Diag_TumorStage)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_DIAG_TUMORSTAGE";
            AV12GridStateFilterValue.gxTpr_Value = AV37TFBR_Pathology_Diag_TumorStage;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV38TFBR_Pathology_Diag_TumorStage_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV38TFBR_Pathology_Diag_TumorStage_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV41TFBR_Pathology_Diag_TumorGrade)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_DIAG_TUMORGRADE";
            AV12GridStateFilterValue.gxTpr_Value = AV41TFBR_Pathology_Diag_TumorGrade;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV42TFBR_Pathology_Diag_TumorGrade_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV42TFBR_Pathology_Diag_TumorGrade_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         AV11GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV11GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV98Pgmname+"GridState",  AV11GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV98Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Pathology_Diag";
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
         PA552( ) ;
         WS552( ) ;
         WE552( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022815124939", true);
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
         context.AddJavascriptSource("br_pathology_diagww.js", "?202022815124939", false);
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
         edtBR_Pathology_DiagID_Internalname = "BR_PATHOLOGY_DIAGID_"+sGXsfl_31_idx;
         edtBR_PathologyID_Internalname = "BR_PATHOLOGYID_"+sGXsfl_31_idx;
         edtBR_Pathology_Diag_Loc_Internalname = "BR_PATHOLOGY_DIAG_LOC_"+sGXsfl_31_idx;
         edtBR_Pathology_Diag_Organ_Internalname = "BR_PATHOLOGY_DIAG_ORGAN_"+sGXsfl_31_idx;
         edtBR_Pathology_Diag_TumorType_Internalname = "BR_PATHOLOGY_DIAG_TUMORTYPE_"+sGXsfl_31_idx;
         edtBR_Pathology_Diag_TumorStage_Internalname = "BR_PATHOLOGY_DIAG_TUMORSTAGE_"+sGXsfl_31_idx;
         edtBR_Pathology_Diag_TumorGrade_Internalname = "BR_PATHOLOGY_DIAG_TUMORGRADE_"+sGXsfl_31_idx;
      }

      protected void SubsflControlProps_fel_312( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_31_fel_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_31_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_31_fel_idx;
         edtBR_Pathology_DiagID_Internalname = "BR_PATHOLOGY_DIAGID_"+sGXsfl_31_fel_idx;
         edtBR_PathologyID_Internalname = "BR_PATHOLOGYID_"+sGXsfl_31_fel_idx;
         edtBR_Pathology_Diag_Loc_Internalname = "BR_PATHOLOGY_DIAG_LOC_"+sGXsfl_31_fel_idx;
         edtBR_Pathology_Diag_Organ_Internalname = "BR_PATHOLOGY_DIAG_ORGAN_"+sGXsfl_31_fel_idx;
         edtBR_Pathology_Diag_TumorType_Internalname = "BR_PATHOLOGY_DIAG_TUMORTYPE_"+sGXsfl_31_fel_idx;
         edtBR_Pathology_Diag_TumorStage_Internalname = "BR_PATHOLOGY_DIAG_TUMORSTAGE_"+sGXsfl_31_fel_idx;
         edtBR_Pathology_Diag_TumorGrade_Internalname = "BR_PATHOLOGY_DIAG_TUMORGRADE_"+sGXsfl_31_fel_idx;
      }

      protected void sendrow_312( )
      {
         SubsflControlProps_312( ) ;
         WB550( ) ;
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
            AV73Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV73Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV95Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV73Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV73Display)) ? AV95Display_GXI : context.PathToRelativeUrl( AV73Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV73Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV74Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV74Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV96Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV74Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV74Update)) ? AV96Update_GXI : context.PathToRelativeUrl( AV74Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavUpdate_Visible,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV74Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "DeleteAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV76Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV76Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV97Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV76Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV76Delete)) ? AV97Delete_GXI : context.PathToRelativeUrl( AV76Delete));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)edtavDelete_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavDelete_Visible,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV76Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_DiagID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A276BR_Pathology_DiagID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A276BR_Pathology_DiagID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_DiagID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
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
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_Diag_Loc_Internalname,(String)A277BR_Pathology_Diag_Loc,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtBR_Pathology_Diag_Loc_Link,(String)"",(String)"",(String)"",(String)edtBR_Pathology_Diag_Loc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_Diag_Organ_Internalname,(String)A278BR_Pathology_Diag_Organ,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_Diag_Organ_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_Diag_TumorType_Internalname,(String)A279BR_Pathology_Diag_TumorType,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_Diag_TumorType_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_Diag_TumorStage_Internalname,(String)A280BR_Pathology_Diag_TumorStage,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_Diag_TumorStage_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_Diag_TumorGrade_Internalname,(String)A281BR_Pathology_Diag_TumorGrade,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_Diag_TumorGrade_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes552( ) ;
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
         edtBR_Pathology_DiagID_Internalname = "BR_PATHOLOGY_DIAGID";
         edtBR_PathologyID_Internalname = "BR_PATHOLOGYID";
         edtBR_Pathology_Diag_Loc_Internalname = "BR_PATHOLOGY_DIAG_LOC";
         edtBR_Pathology_Diag_Organ_Internalname = "BR_PATHOLOGY_DIAG_ORGAN";
         edtBR_Pathology_Diag_TumorType_Internalname = "BR_PATHOLOGY_DIAG_TUMORTYPE";
         edtBR_Pathology_Diag_TumorStage_Internalname = "BR_PATHOLOGY_DIAG_TUMORSTAGE";
         edtBR_Pathology_Diag_TumorGrade_Internalname = "BR_PATHOLOGY_DIAG_TUMORGRADE";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_pathology_diagid_Internalname = "DDO_BR_PATHOLOGY_DIAGID";
         edtavDdo_br_pathology_diagidtitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_DIAGIDTITLECONTROLIDTOREPLACE";
         Ddo_br_pathologyid_Internalname = "DDO_BR_PATHOLOGYID";
         edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_diag_loc_Internalname = "DDO_BR_PATHOLOGY_DIAG_LOC";
         edtavDdo_br_pathology_diag_loctitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_diag_organ_Internalname = "DDO_BR_PATHOLOGY_DIAG_ORGAN";
         edtavDdo_br_pathology_diag_organtitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_diag_tumortype_Internalname = "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE";
         edtavDdo_br_pathology_diag_tumortypetitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_DIAG_TUMORTYPETITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_diag_tumorstage_Internalname = "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE";
         edtavDdo_br_pathology_diag_tumorstagetitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_DIAG_TUMORSTAGETITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_diag_tumorgrade_Internalname = "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE";
         edtavDdo_br_pathology_diag_tumorgradetitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_DIAG_TUMORGRADETITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         edtavTfbr_pathology_diagid_Internalname = "vTFBR_PATHOLOGY_DIAGID";
         edtavTfbr_pathology_diagid_to_Internalname = "vTFBR_PATHOLOGY_DIAGID_TO";
         edtavTfbr_pathologyid_Internalname = "vTFBR_PATHOLOGYID";
         edtavTfbr_pathologyid_to_Internalname = "vTFBR_PATHOLOGYID_TO";
         edtavTfbr_pathology_diag_loc_Internalname = "vTFBR_PATHOLOGY_DIAG_LOC";
         edtavTfbr_pathology_diag_loc_sel_Internalname = "vTFBR_PATHOLOGY_DIAG_LOC_SEL";
         edtavTfbr_pathology_diag_organ_Internalname = "vTFBR_PATHOLOGY_DIAG_ORGAN";
         edtavTfbr_pathology_diag_organ_sel_Internalname = "vTFBR_PATHOLOGY_DIAG_ORGAN_SEL";
         edtavTfbr_pathology_diag_tumortype_Internalname = "vTFBR_PATHOLOGY_DIAG_TUMORTYPE";
         edtavTfbr_pathology_diag_tumortype_sel_Internalname = "vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL";
         edtavTfbr_pathology_diag_tumorstage_Internalname = "vTFBR_PATHOLOGY_DIAG_TUMORSTAGE";
         edtavTfbr_pathology_diag_tumorstage_sel_Internalname = "vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL";
         edtavTfbr_pathology_diag_tumorgrade_Internalname = "vTFBR_PATHOLOGY_DIAG_TUMORGRADE";
         edtavTfbr_pathology_diag_tumorgrade_sel_Internalname = "vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL";
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
         edtBR_Pathology_Diag_TumorGrade_Jsonclick = "";
         edtBR_Pathology_Diag_TumorStage_Jsonclick = "";
         edtBR_Pathology_Diag_TumorType_Jsonclick = "";
         edtBR_Pathology_Diag_Organ_Jsonclick = "";
         edtBR_Pathology_Diag_Loc_Jsonclick = "";
         edtBR_PathologyID_Jsonclick = "";
         edtBR_Pathology_DiagID_Jsonclick = "";
         edtavTfbr_pathology_diag_tumorgrade_sel_Jsonclick = "";
         edtavTfbr_pathology_diag_tumorgrade_sel_Visible = 1;
         edtavTfbr_pathology_diag_tumorgrade_Jsonclick = "";
         edtavTfbr_pathology_diag_tumorgrade_Visible = 1;
         edtavTfbr_pathology_diag_tumorstage_sel_Jsonclick = "";
         edtavTfbr_pathology_diag_tumorstage_sel_Visible = 1;
         edtavTfbr_pathology_diag_tumorstage_Jsonclick = "";
         edtavTfbr_pathology_diag_tumorstage_Visible = 1;
         edtavTfbr_pathology_diag_tumortype_sel_Jsonclick = "";
         edtavTfbr_pathology_diag_tumortype_sel_Visible = 1;
         edtavTfbr_pathology_diag_tumortype_Jsonclick = "";
         edtavTfbr_pathology_diag_tumortype_Visible = 1;
         edtavTfbr_pathology_diag_organ_sel_Jsonclick = "";
         edtavTfbr_pathology_diag_organ_sel_Visible = 1;
         edtavTfbr_pathology_diag_organ_Jsonclick = "";
         edtavTfbr_pathology_diag_organ_Visible = 1;
         edtavTfbr_pathology_diag_loc_sel_Jsonclick = "";
         edtavTfbr_pathology_diag_loc_sel_Visible = 1;
         edtavTfbr_pathology_diag_loc_Jsonclick = "";
         edtavTfbr_pathology_diag_loc_Visible = 1;
         edtavTfbr_pathologyid_to_Jsonclick = "";
         edtavTfbr_pathologyid_to_Visible = 1;
         edtavTfbr_pathologyid_Jsonclick = "";
         edtavTfbr_pathologyid_Visible = 1;
         edtavTfbr_pathology_diagid_to_Jsonclick = "";
         edtavTfbr_pathology_diagid_to_Visible = 1;
         edtavTfbr_pathology_diagid_Jsonclick = "";
         edtavTfbr_pathology_diagid_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_pathology_diag_tumorgradetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathology_diag_tumorstagetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathology_diag_tumortypetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathology_diag_organtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathology_diag_loctitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathology_diagidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtBR_Pathology_Diag_Loc_Link = "";
         edtavDelete_Tooltiptext = "删除";
         edtavDelete_Link = "";
         edtavUpdate_Tooltiptext = "修改";
         edtavUpdate_Link = "";
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Pathology_Diag_TumorGrade_Titleformat = 0;
         edtBR_Pathology_Diag_TumorGrade_Title = "肿瘤分级";
         edtBR_Pathology_Diag_TumorStage_Titleformat = 0;
         edtBR_Pathology_Diag_TumorStage_Title = "肿瘤分期";
         edtBR_Pathology_Diag_TumorType_Titleformat = 0;
         edtBR_Pathology_Diag_TumorType_Title = "肿瘤类型";
         edtBR_Pathology_Diag_Organ_Titleformat = 0;
         edtBR_Pathology_Diag_Organ_Title = "病理诊断(器官)";
         edtBR_Pathology_Diag_Loc_Titleformat = 0;
         edtBR_Pathology_Diag_Loc_Title = "病理诊断(部位)";
         edtBR_PathologyID_Titleformat = 0;
         edtBR_PathologyID_Title = "病理学主键";
         edtBR_Pathology_DiagID_Titleformat = 0;
         edtBR_Pathology_DiagID_Title = "病理学诊断主键";
         edtavDelete_Visible = -1;
         edtavUpdate_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         bttBtninsert_Visible = 1;
         Ddo_br_pathology_diag_tumorgrade_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_diag_tumorgrade_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_pathology_diag_tumorgrade_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathology_diag_tumorgrade_Loadingdata = "WWP_TSLoading";
         Ddo_br_pathology_diag_tumorgrade_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_diag_tumorgrade_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_diag_tumorgrade_Datalistupdateminimumcharacters = 0;
         Ddo_br_pathology_diag_tumorgrade_Datalistproc = "BR_Pathology_DiagWWGetFilterData";
         Ddo_br_pathology_diag_tumorgrade_Datalisttype = "Dynamic";
         Ddo_br_pathology_diag_tumorgrade_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_pathology_diag_tumorgrade_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_pathology_diag_tumorgrade_Filtertype = "Character";
         Ddo_br_pathology_diag_tumorgrade_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_pathology_diag_tumorgrade_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_diag_tumorgrade_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_diag_tumorgrade_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_diag_tumorgrade_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_diag_tumorgrade_Cls = "ColumnSettings";
         Ddo_br_pathology_diag_tumorgrade_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_diag_tumorgrade_Caption = "";
         Ddo_br_pathology_diag_tumorstage_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_diag_tumorstage_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_pathology_diag_tumorstage_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathology_diag_tumorstage_Loadingdata = "WWP_TSLoading";
         Ddo_br_pathology_diag_tumorstage_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_diag_tumorstage_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_diag_tumorstage_Datalistupdateminimumcharacters = 0;
         Ddo_br_pathology_diag_tumorstage_Datalistproc = "BR_Pathology_DiagWWGetFilterData";
         Ddo_br_pathology_diag_tumorstage_Datalisttype = "Dynamic";
         Ddo_br_pathology_diag_tumorstage_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_pathology_diag_tumorstage_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_pathology_diag_tumorstage_Filtertype = "Character";
         Ddo_br_pathology_diag_tumorstage_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_pathology_diag_tumorstage_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_diag_tumorstage_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_diag_tumorstage_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_diag_tumorstage_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_diag_tumorstage_Cls = "ColumnSettings";
         Ddo_br_pathology_diag_tumorstage_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_diag_tumorstage_Caption = "";
         Ddo_br_pathology_diag_tumortype_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_diag_tumortype_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_pathology_diag_tumortype_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathology_diag_tumortype_Loadingdata = "WWP_TSLoading";
         Ddo_br_pathology_diag_tumortype_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_diag_tumortype_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_diag_tumortype_Datalistupdateminimumcharacters = 0;
         Ddo_br_pathology_diag_tumortype_Datalistproc = "BR_Pathology_DiagWWGetFilterData";
         Ddo_br_pathology_diag_tumortype_Datalisttype = "Dynamic";
         Ddo_br_pathology_diag_tumortype_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_pathology_diag_tumortype_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_pathology_diag_tumortype_Filtertype = "Character";
         Ddo_br_pathology_diag_tumortype_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_pathology_diag_tumortype_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_diag_tumortype_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_diag_tumortype_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_diag_tumortype_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_diag_tumortype_Cls = "ColumnSettings";
         Ddo_br_pathology_diag_tumortype_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_diag_tumortype_Caption = "";
         Ddo_br_pathology_diag_organ_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_diag_organ_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_pathology_diag_organ_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathology_diag_organ_Loadingdata = "WWP_TSLoading";
         Ddo_br_pathology_diag_organ_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_diag_organ_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_diag_organ_Datalistupdateminimumcharacters = 0;
         Ddo_br_pathology_diag_organ_Datalistproc = "BR_Pathology_DiagWWGetFilterData";
         Ddo_br_pathology_diag_organ_Datalisttype = "Dynamic";
         Ddo_br_pathology_diag_organ_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_pathology_diag_organ_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_pathology_diag_organ_Filtertype = "Character";
         Ddo_br_pathology_diag_organ_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_pathology_diag_organ_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_diag_organ_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_diag_organ_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_diag_organ_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_diag_organ_Cls = "ColumnSettings";
         Ddo_br_pathology_diag_organ_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_diag_organ_Caption = "";
         Ddo_br_pathology_diag_loc_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_diag_loc_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_pathology_diag_loc_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathology_diag_loc_Loadingdata = "WWP_TSLoading";
         Ddo_br_pathology_diag_loc_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_diag_loc_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_diag_loc_Datalistupdateminimumcharacters = 0;
         Ddo_br_pathology_diag_loc_Datalistproc = "BR_Pathology_DiagWWGetFilterData";
         Ddo_br_pathology_diag_loc_Datalisttype = "Dynamic";
         Ddo_br_pathology_diag_loc_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_pathology_diag_loc_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_pathology_diag_loc_Filtertype = "Character";
         Ddo_br_pathology_diag_loc_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_pathology_diag_loc_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_diag_loc_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_diag_loc_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_diag_loc_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_diag_loc_Cls = "ColumnSettings";
         Ddo_br_pathology_diag_loc_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_diag_loc_Caption = "";
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
         Ddo_br_pathology_diagid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_diagid_Rangefilterto = "WWP_TSTo";
         Ddo_br_pathology_diagid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_pathology_diagid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathology_diagid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_diagid_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_diagid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_diagid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_pathology_diagid_Filtertype = "Numeric";
         Ddo_br_pathology_diagid_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_pathology_diagid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_diagid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_diagid_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_diagid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_diagid_Cls = "ColumnSettings";
         Ddo_br_pathology_diagid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_diagid_Caption = "";
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
         Form.Caption = " 病理学诊断";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORSTAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORGRADETITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV17TFBR_Pathology_DiagID',fld:'vTFBR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_DiagID_To',fld:'vTFBR_PATHOLOGY_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Diag_Loc',fld:'vTFBR_PATHOLOGY_DIAG_LOC',pic:''},{av:'AV26TFBR_Pathology_Diag_Loc_Sel',fld:'vTFBR_PATHOLOGY_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_Pathology_Diag_Organ',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN',pic:''},{av:'AV30TFBR_Pathology_Diag_Organ_Sel',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_Pathology_Diag_TumorType',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE',pic:''},{av:'AV34TFBR_Pathology_Diag_TumorType_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL',pic:''},{av:'AV37TFBR_Pathology_Diag_TumorStage',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE',pic:''},{av:'AV38TFBR_Pathology_Diag_TumorStage_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL',pic:''},{av:'AV41TFBR_Pathology_Diag_TumorGrade',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE',pic:''},{av:'AV42TFBR_Pathology_Diag_TumorGrade_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL',pic:''},{av:'AV98Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV16BR_Pathology_DiagIDTitleFilterData',fld:'vBR_PATHOLOGY_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Diag_LocTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_Pathology_Diag_OrganTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV32BR_Pathology_Diag_TumorTypeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Pathology_Diag_TumorStageTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORSTAGETITLEFILTERDATA',pic:''},{av:'AV40BR_Pathology_Diag_TumorGradeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORGRADETITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_DiagID_Titleformat',ctrl:'BR_PATHOLOGY_DIAGID',prop:'Titleformat'},{av:'edtBR_Pathology_DiagID_Title',ctrl:'BR_PATHOLOGY_DIAGID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Diag_Loc_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_Loc_Title',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Title'},{av:'edtBR_Pathology_Diag_Organ_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_Organ_Title',ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Title'},{av:'edtBR_Pathology_Diag_TumorType_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_TumorType_Title',ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Title'},{av:'edtBR_Pathology_Diag_TumorStage_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_TumorStage_Title',ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Title'},{av:'edtBR_Pathology_Diag_TumorGrade_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_TumorGrade_Title',ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E11552',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_DiagID',fld:'vTFBR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_DiagID_To',fld:'vTFBR_PATHOLOGY_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Diag_Loc',fld:'vTFBR_PATHOLOGY_DIAG_LOC',pic:''},{av:'AV26TFBR_Pathology_Diag_Loc_Sel',fld:'vTFBR_PATHOLOGY_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_Pathology_Diag_Organ',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN',pic:''},{av:'AV30TFBR_Pathology_Diag_Organ_Sel',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_Pathology_Diag_TumorType',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE',pic:''},{av:'AV34TFBR_Pathology_Diag_TumorType_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL',pic:''},{av:'AV37TFBR_Pathology_Diag_TumorStage',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE',pic:''},{av:'AV38TFBR_Pathology_Diag_TumorStage_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL',pic:''},{av:'AV41TFBR_Pathology_Diag_TumorGrade',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE',pic:''},{av:'AV42TFBR_Pathology_Diag_TumorGrade_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL',pic:''},{av:'AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORSTAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORGRADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV98Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E12552',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_DiagID',fld:'vTFBR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_DiagID_To',fld:'vTFBR_PATHOLOGY_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Diag_Loc',fld:'vTFBR_PATHOLOGY_DIAG_LOC',pic:''},{av:'AV26TFBR_Pathology_Diag_Loc_Sel',fld:'vTFBR_PATHOLOGY_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_Pathology_Diag_Organ',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN',pic:''},{av:'AV30TFBR_Pathology_Diag_Organ_Sel',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_Pathology_Diag_TumorType',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE',pic:''},{av:'AV34TFBR_Pathology_Diag_TumorType_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL',pic:''},{av:'AV37TFBR_Pathology_Diag_TumorStage',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE',pic:''},{av:'AV38TFBR_Pathology_Diag_TumorStage_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL',pic:''},{av:'AV41TFBR_Pathology_Diag_TumorGrade',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE',pic:''},{av:'AV42TFBR_Pathology_Diag_TumorGrade_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL',pic:''},{av:'AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORSTAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORGRADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV98Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_DIAGID.ONOPTIONCLICKED","{handler:'E13552',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_DiagID',fld:'vTFBR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_DiagID_To',fld:'vTFBR_PATHOLOGY_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Diag_Loc',fld:'vTFBR_PATHOLOGY_DIAG_LOC',pic:''},{av:'AV26TFBR_Pathology_Diag_Loc_Sel',fld:'vTFBR_PATHOLOGY_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_Pathology_Diag_Organ',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN',pic:''},{av:'AV30TFBR_Pathology_Diag_Organ_Sel',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_Pathology_Diag_TumorType',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE',pic:''},{av:'AV34TFBR_Pathology_Diag_TumorType_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL',pic:''},{av:'AV37TFBR_Pathology_Diag_TumorStage',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE',pic:''},{av:'AV38TFBR_Pathology_Diag_TumorStage_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL',pic:''},{av:'AV41TFBR_Pathology_Diag_TumorGrade',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE',pic:''},{av:'AV42TFBR_Pathology_Diag_TumorGrade_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL',pic:''},{av:'AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORSTAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORGRADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV98Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_pathology_diagid_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_DIAGID',prop:'ActiveEventKey'},{av:'Ddo_br_pathology_diagid_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGY_DIAGID',prop:'FilteredText_get'},{av:'Ddo_br_pathology_diagid_Filteredtextto_get',ctrl:'DDO_BR_PATHOLOGY_DIAGID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_DIAGID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_diagid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAGID',prop:'SortedStatus'},{av:'AV17TFBR_Pathology_DiagID',fld:'vTFBR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_DiagID_To',fld:'vTFBR_PATHOLOGY_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'Ddo_br_pathology_diag_loc_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_LOC',prop:'SortedStatus'},{av:'Ddo_br_pathology_diag_organ_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_ORGAN',prop:'SortedStatus'},{av:'Ddo_br_pathology_diag_tumortype_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'SortedStatus'},{av:'Ddo_br_pathology_diag_tumorstage_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'SortedStatus'},{av:'Ddo_br_pathology_diag_tumorgrade_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'SortedStatus'},{av:'AV16BR_Pathology_DiagIDTitleFilterData',fld:'vBR_PATHOLOGY_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Diag_LocTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_Pathology_Diag_OrganTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV32BR_Pathology_Diag_TumorTypeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Pathology_Diag_TumorStageTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORSTAGETITLEFILTERDATA',pic:''},{av:'AV40BR_Pathology_Diag_TumorGradeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORGRADETITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_DiagID_Titleformat',ctrl:'BR_PATHOLOGY_DIAGID',prop:'Titleformat'},{av:'edtBR_Pathology_DiagID_Title',ctrl:'BR_PATHOLOGY_DIAGID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Diag_Loc_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_Loc_Title',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Title'},{av:'edtBR_Pathology_Diag_Organ_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_Organ_Title',ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Title'},{av:'edtBR_Pathology_Diag_TumorType_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_TumorType_Title',ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Title'},{av:'edtBR_Pathology_Diag_TumorStage_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_TumorStage_Title',ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Title'},{av:'edtBR_Pathology_Diag_TumorGrade_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_TumorGrade_Title',ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGYID.ONOPTIONCLICKED","{handler:'E14552',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_DiagID',fld:'vTFBR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_DiagID_To',fld:'vTFBR_PATHOLOGY_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Diag_Loc',fld:'vTFBR_PATHOLOGY_DIAG_LOC',pic:''},{av:'AV26TFBR_Pathology_Diag_Loc_Sel',fld:'vTFBR_PATHOLOGY_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_Pathology_Diag_Organ',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN',pic:''},{av:'AV30TFBR_Pathology_Diag_Organ_Sel',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_Pathology_Diag_TumorType',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE',pic:''},{av:'AV34TFBR_Pathology_Diag_TumorType_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL',pic:''},{av:'AV37TFBR_Pathology_Diag_TumorStage',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE',pic:''},{av:'AV38TFBR_Pathology_Diag_TumorStage_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL',pic:''},{av:'AV41TFBR_Pathology_Diag_TumorGrade',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE',pic:''},{av:'AV42TFBR_Pathology_Diag_TumorGrade_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL',pic:''},{av:'AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORSTAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORGRADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV98Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_pathologyid_Activeeventkey',ctrl:'DDO_BR_PATHOLOGYID',prop:'ActiveEventKey'},{av:'Ddo_br_pathologyid_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGYID',prop:'FilteredText_get'},{av:'Ddo_br_pathologyid_Filteredtextto_get',ctrl:'DDO_BR_PATHOLOGYID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGYID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_pathology_diagid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAGID',prop:'SortedStatus'},{av:'Ddo_br_pathology_diag_loc_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_LOC',prop:'SortedStatus'},{av:'Ddo_br_pathology_diag_organ_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_ORGAN',prop:'SortedStatus'},{av:'Ddo_br_pathology_diag_tumortype_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'SortedStatus'},{av:'Ddo_br_pathology_diag_tumorstage_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'SortedStatus'},{av:'Ddo_br_pathology_diag_tumorgrade_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'SortedStatus'},{av:'AV16BR_Pathology_DiagIDTitleFilterData',fld:'vBR_PATHOLOGY_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Diag_LocTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_Pathology_Diag_OrganTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV32BR_Pathology_Diag_TumorTypeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Pathology_Diag_TumorStageTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORSTAGETITLEFILTERDATA',pic:''},{av:'AV40BR_Pathology_Diag_TumorGradeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORGRADETITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_DiagID_Titleformat',ctrl:'BR_PATHOLOGY_DIAGID',prop:'Titleformat'},{av:'edtBR_Pathology_DiagID_Title',ctrl:'BR_PATHOLOGY_DIAGID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Diag_Loc_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_Loc_Title',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Title'},{av:'edtBR_Pathology_Diag_Organ_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_Organ_Title',ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Title'},{av:'edtBR_Pathology_Diag_TumorType_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_TumorType_Title',ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Title'},{av:'edtBR_Pathology_Diag_TumorStage_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_TumorStage_Title',ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Title'},{av:'edtBR_Pathology_Diag_TumorGrade_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_TumorGrade_Title',ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_DIAG_LOC.ONOPTIONCLICKED","{handler:'E15552',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_DiagID',fld:'vTFBR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_DiagID_To',fld:'vTFBR_PATHOLOGY_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Diag_Loc',fld:'vTFBR_PATHOLOGY_DIAG_LOC',pic:''},{av:'AV26TFBR_Pathology_Diag_Loc_Sel',fld:'vTFBR_PATHOLOGY_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_Pathology_Diag_Organ',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN',pic:''},{av:'AV30TFBR_Pathology_Diag_Organ_Sel',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_Pathology_Diag_TumorType',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE',pic:''},{av:'AV34TFBR_Pathology_Diag_TumorType_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL',pic:''},{av:'AV37TFBR_Pathology_Diag_TumorStage',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE',pic:''},{av:'AV38TFBR_Pathology_Diag_TumorStage_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL',pic:''},{av:'AV41TFBR_Pathology_Diag_TumorGrade',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE',pic:''},{av:'AV42TFBR_Pathology_Diag_TumorGrade_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL',pic:''},{av:'AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORSTAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORGRADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV98Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_pathology_diag_loc_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_DIAG_LOC',prop:'ActiveEventKey'},{av:'Ddo_br_pathology_diag_loc_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGY_DIAG_LOC',prop:'FilteredText_get'},{av:'Ddo_br_pathology_diag_loc_Selectedvalue_get',ctrl:'DDO_BR_PATHOLOGY_DIAG_LOC',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_DIAG_LOC.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_diag_loc_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_LOC',prop:'SortedStatus'},{av:'AV25TFBR_Pathology_Diag_Loc',fld:'vTFBR_PATHOLOGY_DIAG_LOC',pic:''},{av:'AV26TFBR_Pathology_Diag_Loc_Sel',fld:'vTFBR_PATHOLOGY_DIAG_LOC_SEL',pic:''},{av:'Ddo_br_pathology_diagid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAGID',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'Ddo_br_pathology_diag_organ_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_ORGAN',prop:'SortedStatus'},{av:'Ddo_br_pathology_diag_tumortype_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'SortedStatus'},{av:'Ddo_br_pathology_diag_tumorstage_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'SortedStatus'},{av:'Ddo_br_pathology_diag_tumorgrade_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'SortedStatus'},{av:'AV16BR_Pathology_DiagIDTitleFilterData',fld:'vBR_PATHOLOGY_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Diag_LocTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_Pathology_Diag_OrganTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV32BR_Pathology_Diag_TumorTypeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Pathology_Diag_TumorStageTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORSTAGETITLEFILTERDATA',pic:''},{av:'AV40BR_Pathology_Diag_TumorGradeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORGRADETITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_DiagID_Titleformat',ctrl:'BR_PATHOLOGY_DIAGID',prop:'Titleformat'},{av:'edtBR_Pathology_DiagID_Title',ctrl:'BR_PATHOLOGY_DIAGID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Diag_Loc_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_Loc_Title',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Title'},{av:'edtBR_Pathology_Diag_Organ_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_Organ_Title',ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Title'},{av:'edtBR_Pathology_Diag_TumorType_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_TumorType_Title',ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Title'},{av:'edtBR_Pathology_Diag_TumorStage_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_TumorStage_Title',ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Title'},{av:'edtBR_Pathology_Diag_TumorGrade_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_TumorGrade_Title',ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_DIAG_ORGAN.ONOPTIONCLICKED","{handler:'E16552',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_DiagID',fld:'vTFBR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_DiagID_To',fld:'vTFBR_PATHOLOGY_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Diag_Loc',fld:'vTFBR_PATHOLOGY_DIAG_LOC',pic:''},{av:'AV26TFBR_Pathology_Diag_Loc_Sel',fld:'vTFBR_PATHOLOGY_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_Pathology_Diag_Organ',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN',pic:''},{av:'AV30TFBR_Pathology_Diag_Organ_Sel',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_Pathology_Diag_TumorType',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE',pic:''},{av:'AV34TFBR_Pathology_Diag_TumorType_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL',pic:''},{av:'AV37TFBR_Pathology_Diag_TumorStage',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE',pic:''},{av:'AV38TFBR_Pathology_Diag_TumorStage_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL',pic:''},{av:'AV41TFBR_Pathology_Diag_TumorGrade',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE',pic:''},{av:'AV42TFBR_Pathology_Diag_TumorGrade_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL',pic:''},{av:'AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORSTAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORGRADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV98Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_pathology_diag_organ_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_DIAG_ORGAN',prop:'ActiveEventKey'},{av:'Ddo_br_pathology_diag_organ_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGY_DIAG_ORGAN',prop:'FilteredText_get'},{av:'Ddo_br_pathology_diag_organ_Selectedvalue_get',ctrl:'DDO_BR_PATHOLOGY_DIAG_ORGAN',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_DIAG_ORGAN.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_diag_organ_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_ORGAN',prop:'SortedStatus'},{av:'AV29TFBR_Pathology_Diag_Organ',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN',pic:''},{av:'AV30TFBR_Pathology_Diag_Organ_Sel',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN_SEL',pic:''},{av:'Ddo_br_pathology_diagid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAGID',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'Ddo_br_pathology_diag_loc_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_LOC',prop:'SortedStatus'},{av:'Ddo_br_pathology_diag_tumortype_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'SortedStatus'},{av:'Ddo_br_pathology_diag_tumorstage_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'SortedStatus'},{av:'Ddo_br_pathology_diag_tumorgrade_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'SortedStatus'},{av:'AV16BR_Pathology_DiagIDTitleFilterData',fld:'vBR_PATHOLOGY_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Diag_LocTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_Pathology_Diag_OrganTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV32BR_Pathology_Diag_TumorTypeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Pathology_Diag_TumorStageTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORSTAGETITLEFILTERDATA',pic:''},{av:'AV40BR_Pathology_Diag_TumorGradeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORGRADETITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_DiagID_Titleformat',ctrl:'BR_PATHOLOGY_DIAGID',prop:'Titleformat'},{av:'edtBR_Pathology_DiagID_Title',ctrl:'BR_PATHOLOGY_DIAGID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Diag_Loc_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_Loc_Title',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Title'},{av:'edtBR_Pathology_Diag_Organ_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_Organ_Title',ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Title'},{av:'edtBR_Pathology_Diag_TumorType_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_TumorType_Title',ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Title'},{av:'edtBR_Pathology_Diag_TumorStage_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_TumorStage_Title',ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Title'},{av:'edtBR_Pathology_Diag_TumorGrade_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_TumorGrade_Title',ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_DIAG_TUMORTYPE.ONOPTIONCLICKED","{handler:'E17552',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_DiagID',fld:'vTFBR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_DiagID_To',fld:'vTFBR_PATHOLOGY_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Diag_Loc',fld:'vTFBR_PATHOLOGY_DIAG_LOC',pic:''},{av:'AV26TFBR_Pathology_Diag_Loc_Sel',fld:'vTFBR_PATHOLOGY_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_Pathology_Diag_Organ',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN',pic:''},{av:'AV30TFBR_Pathology_Diag_Organ_Sel',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_Pathology_Diag_TumorType',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE',pic:''},{av:'AV34TFBR_Pathology_Diag_TumorType_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL',pic:''},{av:'AV37TFBR_Pathology_Diag_TumorStage',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE',pic:''},{av:'AV38TFBR_Pathology_Diag_TumorStage_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL',pic:''},{av:'AV41TFBR_Pathology_Diag_TumorGrade',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE',pic:''},{av:'AV42TFBR_Pathology_Diag_TumorGrade_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL',pic:''},{av:'AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORSTAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORGRADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV98Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_pathology_diag_tumortype_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'ActiveEventKey'},{av:'Ddo_br_pathology_diag_tumortype_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'FilteredText_get'},{av:'Ddo_br_pathology_diag_tumortype_Selectedvalue_get',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_DIAG_TUMORTYPE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_diag_tumortype_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'SortedStatus'},{av:'AV33TFBR_Pathology_Diag_TumorType',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE',pic:''},{av:'AV34TFBR_Pathology_Diag_TumorType_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL',pic:''},{av:'Ddo_br_pathology_diagid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAGID',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'Ddo_br_pathology_diag_loc_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_LOC',prop:'SortedStatus'},{av:'Ddo_br_pathology_diag_organ_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_ORGAN',prop:'SortedStatus'},{av:'Ddo_br_pathology_diag_tumorstage_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'SortedStatus'},{av:'Ddo_br_pathology_diag_tumorgrade_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'SortedStatus'},{av:'AV16BR_Pathology_DiagIDTitleFilterData',fld:'vBR_PATHOLOGY_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Diag_LocTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_Pathology_Diag_OrganTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV32BR_Pathology_Diag_TumorTypeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Pathology_Diag_TumorStageTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORSTAGETITLEFILTERDATA',pic:''},{av:'AV40BR_Pathology_Diag_TumorGradeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORGRADETITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_DiagID_Titleformat',ctrl:'BR_PATHOLOGY_DIAGID',prop:'Titleformat'},{av:'edtBR_Pathology_DiagID_Title',ctrl:'BR_PATHOLOGY_DIAGID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Diag_Loc_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_Loc_Title',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Title'},{av:'edtBR_Pathology_Diag_Organ_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_Organ_Title',ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Title'},{av:'edtBR_Pathology_Diag_TumorType_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_TumorType_Title',ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Title'},{av:'edtBR_Pathology_Diag_TumorStage_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_TumorStage_Title',ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Title'},{av:'edtBR_Pathology_Diag_TumorGrade_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_TumorGrade_Title',ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE.ONOPTIONCLICKED","{handler:'E18552',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_DiagID',fld:'vTFBR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_DiagID_To',fld:'vTFBR_PATHOLOGY_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Diag_Loc',fld:'vTFBR_PATHOLOGY_DIAG_LOC',pic:''},{av:'AV26TFBR_Pathology_Diag_Loc_Sel',fld:'vTFBR_PATHOLOGY_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_Pathology_Diag_Organ',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN',pic:''},{av:'AV30TFBR_Pathology_Diag_Organ_Sel',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_Pathology_Diag_TumorType',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE',pic:''},{av:'AV34TFBR_Pathology_Diag_TumorType_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL',pic:''},{av:'AV37TFBR_Pathology_Diag_TumorStage',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE',pic:''},{av:'AV38TFBR_Pathology_Diag_TumorStage_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL',pic:''},{av:'AV41TFBR_Pathology_Diag_TumorGrade',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE',pic:''},{av:'AV42TFBR_Pathology_Diag_TumorGrade_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL',pic:''},{av:'AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORSTAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORGRADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV98Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_pathology_diag_tumorstage_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'ActiveEventKey'},{av:'Ddo_br_pathology_diag_tumorstage_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'FilteredText_get'},{av:'Ddo_br_pathology_diag_tumorstage_Selectedvalue_get',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_diag_tumorstage_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'SortedStatus'},{av:'AV37TFBR_Pathology_Diag_TumorStage',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE',pic:''},{av:'AV38TFBR_Pathology_Diag_TumorStage_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL',pic:''},{av:'Ddo_br_pathology_diagid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAGID',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'Ddo_br_pathology_diag_loc_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_LOC',prop:'SortedStatus'},{av:'Ddo_br_pathology_diag_organ_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_ORGAN',prop:'SortedStatus'},{av:'Ddo_br_pathology_diag_tumortype_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'SortedStatus'},{av:'Ddo_br_pathology_diag_tumorgrade_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'SortedStatus'},{av:'AV16BR_Pathology_DiagIDTitleFilterData',fld:'vBR_PATHOLOGY_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Diag_LocTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_Pathology_Diag_OrganTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV32BR_Pathology_Diag_TumorTypeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Pathology_Diag_TumorStageTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORSTAGETITLEFILTERDATA',pic:''},{av:'AV40BR_Pathology_Diag_TumorGradeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORGRADETITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_DiagID_Titleformat',ctrl:'BR_PATHOLOGY_DIAGID',prop:'Titleformat'},{av:'edtBR_Pathology_DiagID_Title',ctrl:'BR_PATHOLOGY_DIAGID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Diag_Loc_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_Loc_Title',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Title'},{av:'edtBR_Pathology_Diag_Organ_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_Organ_Title',ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Title'},{av:'edtBR_Pathology_Diag_TumorType_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_TumorType_Title',ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Title'},{av:'edtBR_Pathology_Diag_TumorStage_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_TumorStage_Title',ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Title'},{av:'edtBR_Pathology_Diag_TumorGrade_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_TumorGrade_Title',ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_DIAG_TUMORGRADE.ONOPTIONCLICKED","{handler:'E19552',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Pathology_DiagID',fld:'vTFBR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Pathology_DiagID_To',fld:'vTFBR_PATHOLOGY_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Pathology_Diag_Loc',fld:'vTFBR_PATHOLOGY_DIAG_LOC',pic:''},{av:'AV26TFBR_Pathology_Diag_Loc_Sel',fld:'vTFBR_PATHOLOGY_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_Pathology_Diag_Organ',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN',pic:''},{av:'AV30TFBR_Pathology_Diag_Organ_Sel',fld:'vTFBR_PATHOLOGY_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_Pathology_Diag_TumorType',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE',pic:''},{av:'AV34TFBR_Pathology_Diag_TumorType_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL',pic:''},{av:'AV37TFBR_Pathology_Diag_TumorStage',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE',pic:''},{av:'AV38TFBR_Pathology_Diag_TumorStage_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL',pic:''},{av:'AV41TFBR_Pathology_Diag_TumorGrade',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE',pic:''},{av:'AV42TFBR_Pathology_Diag_TumorGrade_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL',pic:''},{av:'AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORSTAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIAG_TUMORGRADETITLECONTROLIDTOREPLACE',pic:''},{av:'AV98Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_pathology_diag_tumorgrade_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'ActiveEventKey'},{av:'Ddo_br_pathology_diag_tumorgrade_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'FilteredText_get'},{av:'Ddo_br_pathology_diag_tumorgrade_Selectedvalue_get',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_DIAG_TUMORGRADE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_diag_tumorgrade_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'SortedStatus'},{av:'AV41TFBR_Pathology_Diag_TumorGrade',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE',pic:''},{av:'AV42TFBR_Pathology_Diag_TumorGrade_Sel',fld:'vTFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL',pic:''},{av:'Ddo_br_pathology_diagid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAGID',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'Ddo_br_pathology_diag_loc_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_LOC',prop:'SortedStatus'},{av:'Ddo_br_pathology_diag_organ_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_ORGAN',prop:'SortedStatus'},{av:'Ddo_br_pathology_diag_tumortype_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'SortedStatus'},{av:'Ddo_br_pathology_diag_tumorstage_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'SortedStatus'},{av:'AV16BR_Pathology_DiagIDTitleFilterData',fld:'vBR_PATHOLOGY_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV20BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Pathology_Diag_LocTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_Pathology_Diag_OrganTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV32BR_Pathology_Diag_TumorTypeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Pathology_Diag_TumorStageTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORSTAGETITLEFILTERDATA',pic:''},{av:'AV40BR_Pathology_Diag_TumorGradeTitleFilterData',fld:'vBR_PATHOLOGY_DIAG_TUMORGRADETITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_DiagID_Titleformat',ctrl:'BR_PATHOLOGY_DIAGID',prop:'Titleformat'},{av:'edtBR_Pathology_DiagID_Title',ctrl:'BR_PATHOLOGY_DIAGID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Diag_Loc_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_Loc_Title',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Title'},{av:'edtBR_Pathology_Diag_Organ_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_Organ_Title',ctrl:'BR_PATHOLOGY_DIAG_ORGAN',prop:'Title'},{av:'edtBR_Pathology_Diag_TumorType_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_TumorType_Title',ctrl:'BR_PATHOLOGY_DIAG_TUMORTYPE',prop:'Title'},{av:'edtBR_Pathology_Diag_TumorStage_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_TumorStage_Title',ctrl:'BR_PATHOLOGY_DIAG_TUMORSTAGE',prop:'Title'},{av:'edtBR_Pathology_Diag_TumorGrade_Titleformat',ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Titleformat'},{av:'edtBR_Pathology_Diag_TumorGrade_Title',ctrl:'BR_PATHOLOGY_DIAG_TUMORGRADE',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E23552',iparms:[{av:'A276BR_Pathology_DiagID',fld:'BR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV73Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'},{av:'AV74Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV76Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'},{av:'edtBR_Pathology_Diag_Loc_Link',ctrl:'BR_PATHOLOGY_DIAG_LOC',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E20552',iparms:[{av:'A276BR_Pathology_DiagID',fld:'BR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
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
         Ddo_br_pathology_diagid_Activeeventkey = "";
         Ddo_br_pathology_diagid_Filteredtext_get = "";
         Ddo_br_pathology_diagid_Filteredtextto_get = "";
         Ddo_br_pathologyid_Activeeventkey = "";
         Ddo_br_pathologyid_Filteredtext_get = "";
         Ddo_br_pathologyid_Filteredtextto_get = "";
         Ddo_br_pathology_diag_loc_Activeeventkey = "";
         Ddo_br_pathology_diag_loc_Filteredtext_get = "";
         Ddo_br_pathology_diag_loc_Selectedvalue_get = "";
         Ddo_br_pathology_diag_organ_Activeeventkey = "";
         Ddo_br_pathology_diag_organ_Filteredtext_get = "";
         Ddo_br_pathology_diag_organ_Selectedvalue_get = "";
         Ddo_br_pathology_diag_tumortype_Activeeventkey = "";
         Ddo_br_pathology_diag_tumortype_Filteredtext_get = "";
         Ddo_br_pathology_diag_tumortype_Selectedvalue_get = "";
         Ddo_br_pathology_diag_tumorstage_Activeeventkey = "";
         Ddo_br_pathology_diag_tumorstage_Filteredtext_get = "";
         Ddo_br_pathology_diag_tumorstage_Selectedvalue_get = "";
         Ddo_br_pathology_diag_tumorgrade_Activeeventkey = "";
         Ddo_br_pathology_diag_tumorgrade_Filteredtext_get = "";
         Ddo_br_pathology_diag_tumorgrade_Selectedvalue_get = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV25TFBR_Pathology_Diag_Loc = "";
         AV26TFBR_Pathology_Diag_Loc_Sel = "";
         AV29TFBR_Pathology_Diag_Organ = "";
         AV30TFBR_Pathology_Diag_Organ_Sel = "";
         AV33TFBR_Pathology_Diag_TumorType = "";
         AV34TFBR_Pathology_Diag_TumorType_Sel = "";
         AV37TFBR_Pathology_Diag_TumorStage = "";
         AV38TFBR_Pathology_Diag_TumorStage_Sel = "";
         AV41TFBR_Pathology_Diag_TumorGrade = "";
         AV42TFBR_Pathology_Diag_TumorGrade_Sel = "";
         AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace = "";
         AV23ddo_BR_PathologyIDTitleControlIdToReplace = "";
         AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace = "";
         AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace = "";
         AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace = "";
         AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace = "";
         AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace = "";
         AV98Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV68DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV16BR_Pathology_DiagIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_PathologyIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_Pathology_Diag_LocTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28BR_Pathology_Diag_OrganTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32BR_Pathology_Diag_TumorTypeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV36BR_Pathology_Diag_TumorStageTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV40BR_Pathology_Diag_TumorGradeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_pathology_diagid_Filteredtext_set = "";
         Ddo_br_pathology_diagid_Filteredtextto_set = "";
         Ddo_br_pathology_diagid_Sortedstatus = "";
         Ddo_br_pathologyid_Filteredtext_set = "";
         Ddo_br_pathologyid_Filteredtextto_set = "";
         Ddo_br_pathologyid_Sortedstatus = "";
         Ddo_br_pathology_diag_loc_Filteredtext_set = "";
         Ddo_br_pathology_diag_loc_Selectedvalue_set = "";
         Ddo_br_pathology_diag_loc_Sortedstatus = "";
         Ddo_br_pathology_diag_organ_Filteredtext_set = "";
         Ddo_br_pathology_diag_organ_Selectedvalue_set = "";
         Ddo_br_pathology_diag_organ_Sortedstatus = "";
         Ddo_br_pathology_diag_tumortype_Filteredtext_set = "";
         Ddo_br_pathology_diag_tumortype_Selectedvalue_set = "";
         Ddo_br_pathology_diag_tumortype_Sortedstatus = "";
         Ddo_br_pathology_diag_tumorstage_Filteredtext_set = "";
         Ddo_br_pathology_diag_tumorstage_Selectedvalue_set = "";
         Ddo_br_pathology_diag_tumorstage_Sortedstatus = "";
         Ddo_br_pathology_diag_tumorgrade_Filteredtext_set = "";
         Ddo_br_pathology_diag_tumorgrade_Selectedvalue_set = "";
         Ddo_br_pathology_diag_tumorgrade_Sortedstatus = "";
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
         AV73Display = "";
         AV74Update = "";
         AV76Delete = "";
         A277BR_Pathology_Diag_Loc = "";
         A278BR_Pathology_Diag_Organ = "";
         A279BR_Pathology_Diag_TumorType = "";
         A280BR_Pathology_Diag_TumorStage = "";
         A281BR_Pathology_Diag_TumorGrade = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_pathology_diagid = new GXUserControl();
         ucDdo_br_pathologyid = new GXUserControl();
         ucDdo_br_pathology_diag_loc = new GXUserControl();
         ucDdo_br_pathology_diag_organ = new GXUserControl();
         ucDdo_br_pathology_diag_tumortype = new GXUserControl();
         ucDdo_br_pathology_diag_tumorstage = new GXUserControl();
         ucDdo_br_pathology_diag_tumorgrade = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV95Display_GXI = "";
         AV96Update_GXI = "";
         AV97Delete_GXI = "";
         scmdbuf = "";
         lV85BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc = "";
         lV87BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ = "";
         lV89BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype = "";
         lV91BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage = "";
         lV93BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade = "";
         AV86BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel = "";
         AV85BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc = "";
         AV88BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel = "";
         AV87BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ = "";
         AV90BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel = "";
         AV89BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype = "";
         AV92BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel = "";
         AV91BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage = "";
         AV94BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel = "";
         AV93BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade = "";
         H00552_A281BR_Pathology_Diag_TumorGrade = new String[] {""} ;
         H00552_n281BR_Pathology_Diag_TumorGrade = new bool[] {false} ;
         H00552_A280BR_Pathology_Diag_TumorStage = new String[] {""} ;
         H00552_n280BR_Pathology_Diag_TumorStage = new bool[] {false} ;
         H00552_A279BR_Pathology_Diag_TumorType = new String[] {""} ;
         H00552_n279BR_Pathology_Diag_TumorType = new bool[] {false} ;
         H00552_A278BR_Pathology_Diag_Organ = new String[] {""} ;
         H00552_n278BR_Pathology_Diag_Organ = new bool[] {false} ;
         H00552_A277BR_Pathology_Diag_Loc = new String[] {""} ;
         H00552_n277BR_Pathology_Diag_Loc = new bool[] {false} ;
         H00552_A226BR_PathologyID = new long[1] ;
         H00552_n226BR_PathologyID = new bool[] {false} ;
         H00552_A276BR_Pathology_DiagID = new long[1] ;
         H00553_AGRID_nRecordCount = new long[1] ;
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_pathology_diagww__default(),
            new Object[][] {
                new Object[] {
               H00552_A281BR_Pathology_Diag_TumorGrade, H00552_n281BR_Pathology_Diag_TumorGrade, H00552_A280BR_Pathology_Diag_TumorStage, H00552_n280BR_Pathology_Diag_TumorStage, H00552_A279BR_Pathology_Diag_TumorType, H00552_n279BR_Pathology_Diag_TumorType, H00552_A278BR_Pathology_Diag_Organ, H00552_n278BR_Pathology_Diag_Organ, H00552_A277BR_Pathology_Diag_Loc, H00552_n277BR_Pathology_Diag_Loc,
               H00552_A226BR_PathologyID, H00552_n226BR_PathologyID, H00552_A276BR_Pathology_DiagID
               }
               , new Object[] {
               H00553_AGRID_nRecordCount
               }
            }
         );
         AV98Pgmname = "BR_Pathology_DiagWW";
         /* GeneXus formulas. */
         AV98Pgmname = "BR_Pathology_DiagWW";
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
      private short edtBR_Pathology_DiagID_Titleformat ;
      private short edtBR_PathologyID_Titleformat ;
      private short edtBR_Pathology_Diag_Loc_Titleformat ;
      private short edtBR_Pathology_Diag_Organ_Titleformat ;
      private short edtBR_Pathology_Diag_TumorType_Titleformat ;
      private short edtBR_Pathology_Diag_TumorStage_Titleformat ;
      private short edtBR_Pathology_Diag_TumorGrade_Titleformat ;
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
      private int Ddo_br_pathology_diag_loc_Datalistupdateminimumcharacters ;
      private int Ddo_br_pathology_diag_organ_Datalistupdateminimumcharacters ;
      private int Ddo_br_pathology_diag_tumortype_Datalistupdateminimumcharacters ;
      private int Ddo_br_pathology_diag_tumorstage_Datalistupdateminimumcharacters ;
      private int Ddo_br_pathology_diag_tumorgrade_Datalistupdateminimumcharacters ;
      private int bttBtninsert_Visible ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavUpdate_Visible ;
      private int edtavDelete_Visible ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_br_pathology_diagidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_diag_loctitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_diag_organtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_diag_tumortypetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_diag_tumorstagetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_diag_tumorgradetitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfbr_pathology_diagid_Visible ;
      private int edtavTfbr_pathology_diagid_to_Visible ;
      private int edtavTfbr_pathologyid_Visible ;
      private int edtavTfbr_pathologyid_to_Visible ;
      private int edtavTfbr_pathology_diag_loc_Visible ;
      private int edtavTfbr_pathology_diag_loc_sel_Visible ;
      private int edtavTfbr_pathology_diag_organ_Visible ;
      private int edtavTfbr_pathology_diag_organ_sel_Visible ;
      private int edtavTfbr_pathology_diag_tumortype_Visible ;
      private int edtavTfbr_pathology_diag_tumortype_sel_Visible ;
      private int edtavTfbr_pathology_diag_tumorstage_Visible ;
      private int edtavTfbr_pathology_diag_tumorstage_sel_Visible ;
      private int edtavTfbr_pathology_diag_tumorgrade_Visible ;
      private int edtavTfbr_pathology_diag_tumorgrade_sel_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV69PageToGo ;
      private int AV99GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV17TFBR_Pathology_DiagID ;
      private long AV18TFBR_Pathology_DiagID_To ;
      private long AV21TFBR_PathologyID ;
      private long AV22TFBR_PathologyID_To ;
      private long AV70GridCurrentPage ;
      private long AV72GridRecordCount ;
      private long AV71GridPageSize ;
      private long A276BR_Pathology_DiagID ;
      private long A226BR_PathologyID ;
      private long GRID_nCurrentRecord ;
      private long AV81BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid ;
      private long AV82BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to ;
      private long AV83BR_Pathology_DiagWWDS_3_Tfbr_pathologyid ;
      private long AV84BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_pathology_diagid_Activeeventkey ;
      private String Ddo_br_pathology_diagid_Filteredtext_get ;
      private String Ddo_br_pathology_diagid_Filteredtextto_get ;
      private String Ddo_br_pathologyid_Activeeventkey ;
      private String Ddo_br_pathologyid_Filteredtext_get ;
      private String Ddo_br_pathologyid_Filteredtextto_get ;
      private String Ddo_br_pathology_diag_loc_Activeeventkey ;
      private String Ddo_br_pathology_diag_loc_Filteredtext_get ;
      private String Ddo_br_pathology_diag_loc_Selectedvalue_get ;
      private String Ddo_br_pathology_diag_organ_Activeeventkey ;
      private String Ddo_br_pathology_diag_organ_Filteredtext_get ;
      private String Ddo_br_pathology_diag_organ_Selectedvalue_get ;
      private String Ddo_br_pathology_diag_tumortype_Activeeventkey ;
      private String Ddo_br_pathology_diag_tumortype_Filteredtext_get ;
      private String Ddo_br_pathology_diag_tumortype_Selectedvalue_get ;
      private String Ddo_br_pathology_diag_tumorstage_Activeeventkey ;
      private String Ddo_br_pathology_diag_tumorstage_Filteredtext_get ;
      private String Ddo_br_pathology_diag_tumorstage_Selectedvalue_get ;
      private String Ddo_br_pathology_diag_tumorgrade_Activeeventkey ;
      private String Ddo_br_pathology_diag_tumorgrade_Filteredtext_get ;
      private String Ddo_br_pathology_diag_tumorgrade_Selectedvalue_get ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_31_idx="0001" ;
      private String AV98Pgmname ;
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
      private String Ddo_br_pathology_diagid_Caption ;
      private String Ddo_br_pathology_diagid_Tooltip ;
      private String Ddo_br_pathology_diagid_Cls ;
      private String Ddo_br_pathology_diagid_Filteredtext_set ;
      private String Ddo_br_pathology_diagid_Filteredtextto_set ;
      private String Ddo_br_pathology_diagid_Dropdownoptionstype ;
      private String Ddo_br_pathology_diagid_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_diagid_Sortedstatus ;
      private String Ddo_br_pathology_diagid_Filtertype ;
      private String Ddo_br_pathology_diagid_Sortasc ;
      private String Ddo_br_pathology_diagid_Sortdsc ;
      private String Ddo_br_pathology_diagid_Cleanfilter ;
      private String Ddo_br_pathology_diagid_Rangefilterfrom ;
      private String Ddo_br_pathology_diagid_Rangefilterto ;
      private String Ddo_br_pathology_diagid_Searchbuttontext ;
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
      private String Ddo_br_pathology_diag_loc_Caption ;
      private String Ddo_br_pathology_diag_loc_Tooltip ;
      private String Ddo_br_pathology_diag_loc_Cls ;
      private String Ddo_br_pathology_diag_loc_Filteredtext_set ;
      private String Ddo_br_pathology_diag_loc_Selectedvalue_set ;
      private String Ddo_br_pathology_diag_loc_Dropdownoptionstype ;
      private String Ddo_br_pathology_diag_loc_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_diag_loc_Sortedstatus ;
      private String Ddo_br_pathology_diag_loc_Filtertype ;
      private String Ddo_br_pathology_diag_loc_Datalisttype ;
      private String Ddo_br_pathology_diag_loc_Datalistproc ;
      private String Ddo_br_pathology_diag_loc_Sortasc ;
      private String Ddo_br_pathology_diag_loc_Sortdsc ;
      private String Ddo_br_pathology_diag_loc_Loadingdata ;
      private String Ddo_br_pathology_diag_loc_Cleanfilter ;
      private String Ddo_br_pathology_diag_loc_Noresultsfound ;
      private String Ddo_br_pathology_diag_loc_Searchbuttontext ;
      private String Ddo_br_pathology_diag_organ_Caption ;
      private String Ddo_br_pathology_diag_organ_Tooltip ;
      private String Ddo_br_pathology_diag_organ_Cls ;
      private String Ddo_br_pathology_diag_organ_Filteredtext_set ;
      private String Ddo_br_pathology_diag_organ_Selectedvalue_set ;
      private String Ddo_br_pathology_diag_organ_Dropdownoptionstype ;
      private String Ddo_br_pathology_diag_organ_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_diag_organ_Sortedstatus ;
      private String Ddo_br_pathology_diag_organ_Filtertype ;
      private String Ddo_br_pathology_diag_organ_Datalisttype ;
      private String Ddo_br_pathology_diag_organ_Datalistproc ;
      private String Ddo_br_pathology_diag_organ_Sortasc ;
      private String Ddo_br_pathology_diag_organ_Sortdsc ;
      private String Ddo_br_pathology_diag_organ_Loadingdata ;
      private String Ddo_br_pathology_diag_organ_Cleanfilter ;
      private String Ddo_br_pathology_diag_organ_Noresultsfound ;
      private String Ddo_br_pathology_diag_organ_Searchbuttontext ;
      private String Ddo_br_pathology_diag_tumortype_Caption ;
      private String Ddo_br_pathology_diag_tumortype_Tooltip ;
      private String Ddo_br_pathology_diag_tumortype_Cls ;
      private String Ddo_br_pathology_diag_tumortype_Filteredtext_set ;
      private String Ddo_br_pathology_diag_tumortype_Selectedvalue_set ;
      private String Ddo_br_pathology_diag_tumortype_Dropdownoptionstype ;
      private String Ddo_br_pathology_diag_tumortype_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_diag_tumortype_Sortedstatus ;
      private String Ddo_br_pathology_diag_tumortype_Filtertype ;
      private String Ddo_br_pathology_diag_tumortype_Datalisttype ;
      private String Ddo_br_pathology_diag_tumortype_Datalistproc ;
      private String Ddo_br_pathology_diag_tumortype_Sortasc ;
      private String Ddo_br_pathology_diag_tumortype_Sortdsc ;
      private String Ddo_br_pathology_diag_tumortype_Loadingdata ;
      private String Ddo_br_pathology_diag_tumortype_Cleanfilter ;
      private String Ddo_br_pathology_diag_tumortype_Noresultsfound ;
      private String Ddo_br_pathology_diag_tumortype_Searchbuttontext ;
      private String Ddo_br_pathology_diag_tumorstage_Caption ;
      private String Ddo_br_pathology_diag_tumorstage_Tooltip ;
      private String Ddo_br_pathology_diag_tumorstage_Cls ;
      private String Ddo_br_pathology_diag_tumorstage_Filteredtext_set ;
      private String Ddo_br_pathology_diag_tumorstage_Selectedvalue_set ;
      private String Ddo_br_pathology_diag_tumorstage_Dropdownoptionstype ;
      private String Ddo_br_pathology_diag_tumorstage_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_diag_tumorstage_Sortedstatus ;
      private String Ddo_br_pathology_diag_tumorstage_Filtertype ;
      private String Ddo_br_pathology_diag_tumorstage_Datalisttype ;
      private String Ddo_br_pathology_diag_tumorstage_Datalistproc ;
      private String Ddo_br_pathology_diag_tumorstage_Sortasc ;
      private String Ddo_br_pathology_diag_tumorstage_Sortdsc ;
      private String Ddo_br_pathology_diag_tumorstage_Loadingdata ;
      private String Ddo_br_pathology_diag_tumorstage_Cleanfilter ;
      private String Ddo_br_pathology_diag_tumorstage_Noresultsfound ;
      private String Ddo_br_pathology_diag_tumorstage_Searchbuttontext ;
      private String Ddo_br_pathology_diag_tumorgrade_Caption ;
      private String Ddo_br_pathology_diag_tumorgrade_Tooltip ;
      private String Ddo_br_pathology_diag_tumorgrade_Cls ;
      private String Ddo_br_pathology_diag_tumorgrade_Filteredtext_set ;
      private String Ddo_br_pathology_diag_tumorgrade_Selectedvalue_set ;
      private String Ddo_br_pathology_diag_tumorgrade_Dropdownoptionstype ;
      private String Ddo_br_pathology_diag_tumorgrade_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_diag_tumorgrade_Sortedstatus ;
      private String Ddo_br_pathology_diag_tumorgrade_Filtertype ;
      private String Ddo_br_pathology_diag_tumorgrade_Datalisttype ;
      private String Ddo_br_pathology_diag_tumorgrade_Datalistproc ;
      private String Ddo_br_pathology_diag_tumorgrade_Sortasc ;
      private String Ddo_br_pathology_diag_tumorgrade_Sortdsc ;
      private String Ddo_br_pathology_diag_tumorgrade_Loadingdata ;
      private String Ddo_br_pathology_diag_tumorgrade_Cleanfilter ;
      private String Ddo_br_pathology_diag_tumorgrade_Noresultsfound ;
      private String Ddo_br_pathology_diag_tumorgrade_Searchbuttontext ;
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
      private String edtBR_Pathology_DiagID_Title ;
      private String edtBR_PathologyID_Title ;
      private String edtBR_Pathology_Diag_Loc_Title ;
      private String edtBR_Pathology_Diag_Organ_Title ;
      private String edtBR_Pathology_Diag_TumorType_Title ;
      private String edtBR_Pathology_Diag_TumorStage_Title ;
      private String edtBR_Pathology_Diag_TumorGrade_Title ;
      private String subGrid_Header ;
      private String edtavDisplay_Link ;
      private String edtavDisplay_Tooltiptext ;
      private String edtavUpdate_Link ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavDelete_Link ;
      private String edtavDelete_Tooltiptext ;
      private String edtBR_Pathology_Diag_Loc_Link ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_pathology_diagid_Internalname ;
      private String edtavDdo_br_pathology_diagidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathologyid_Internalname ;
      private String edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_diag_loc_Internalname ;
      private String edtavDdo_br_pathology_diag_loctitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_diag_organ_Internalname ;
      private String edtavDdo_br_pathology_diag_organtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_diag_tumortype_Internalname ;
      private String edtavDdo_br_pathology_diag_tumortypetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_diag_tumorstage_Internalname ;
      private String edtavDdo_br_pathology_diag_tumorstagetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_diag_tumorgrade_Internalname ;
      private String edtavDdo_br_pathology_diag_tumorgradetitlecontrolidtoreplace_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavTfbr_pathology_diagid_Internalname ;
      private String edtavTfbr_pathology_diagid_Jsonclick ;
      private String edtavTfbr_pathology_diagid_to_Internalname ;
      private String edtavTfbr_pathology_diagid_to_Jsonclick ;
      private String edtavTfbr_pathologyid_Internalname ;
      private String edtavTfbr_pathologyid_Jsonclick ;
      private String edtavTfbr_pathologyid_to_Internalname ;
      private String edtavTfbr_pathologyid_to_Jsonclick ;
      private String edtavTfbr_pathology_diag_loc_Internalname ;
      private String edtavTfbr_pathology_diag_loc_Jsonclick ;
      private String edtavTfbr_pathology_diag_loc_sel_Internalname ;
      private String edtavTfbr_pathology_diag_loc_sel_Jsonclick ;
      private String edtavTfbr_pathology_diag_organ_Internalname ;
      private String edtavTfbr_pathology_diag_organ_Jsonclick ;
      private String edtavTfbr_pathology_diag_organ_sel_Internalname ;
      private String edtavTfbr_pathology_diag_organ_sel_Jsonclick ;
      private String edtavTfbr_pathology_diag_tumortype_Internalname ;
      private String edtavTfbr_pathology_diag_tumortype_Jsonclick ;
      private String edtavTfbr_pathology_diag_tumortype_sel_Internalname ;
      private String edtavTfbr_pathology_diag_tumortype_sel_Jsonclick ;
      private String edtavTfbr_pathology_diag_tumorstage_Internalname ;
      private String edtavTfbr_pathology_diag_tumorstage_Jsonclick ;
      private String edtavTfbr_pathology_diag_tumorstage_sel_Internalname ;
      private String edtavTfbr_pathology_diag_tumorstage_sel_Jsonclick ;
      private String edtavTfbr_pathology_diag_tumorgrade_Internalname ;
      private String edtavTfbr_pathology_diag_tumorgrade_Jsonclick ;
      private String edtavTfbr_pathology_diag_tumorgrade_sel_Internalname ;
      private String edtavTfbr_pathology_diag_tumorgrade_sel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDisplay_Internalname ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String edtBR_Pathology_DiagID_Internalname ;
      private String edtBR_PathologyID_Internalname ;
      private String edtBR_Pathology_Diag_Loc_Internalname ;
      private String edtBR_Pathology_Diag_Organ_Internalname ;
      private String edtBR_Pathology_Diag_TumorType_Internalname ;
      private String edtBR_Pathology_Diag_TumorStage_Internalname ;
      private String edtBR_Pathology_Diag_TumorGrade_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_31_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtBR_Pathology_DiagID_Jsonclick ;
      private String edtBR_PathologyID_Jsonclick ;
      private String edtBR_Pathology_Diag_Loc_Jsonclick ;
      private String edtBR_Pathology_Diag_Organ_Jsonclick ;
      private String edtBR_Pathology_Diag_TumorType_Jsonclick ;
      private String edtBR_Pathology_Diag_TumorStage_Jsonclick ;
      private String edtBR_Pathology_Diag_TumorGrade_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV14OrderedDsc ;
      private bool AV75IsAuthorized_Update ;
      private bool AV77IsAuthorized_Delete ;
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
      private bool Ddo_br_pathology_diagid_Includesortasc ;
      private bool Ddo_br_pathology_diagid_Includesortdsc ;
      private bool Ddo_br_pathology_diagid_Includefilter ;
      private bool Ddo_br_pathology_diagid_Filterisrange ;
      private bool Ddo_br_pathology_diagid_Includedatalist ;
      private bool Ddo_br_pathologyid_Includesortasc ;
      private bool Ddo_br_pathologyid_Includesortdsc ;
      private bool Ddo_br_pathologyid_Includefilter ;
      private bool Ddo_br_pathologyid_Filterisrange ;
      private bool Ddo_br_pathologyid_Includedatalist ;
      private bool Ddo_br_pathology_diag_loc_Includesortasc ;
      private bool Ddo_br_pathology_diag_loc_Includesortdsc ;
      private bool Ddo_br_pathology_diag_loc_Includefilter ;
      private bool Ddo_br_pathology_diag_loc_Filterisrange ;
      private bool Ddo_br_pathology_diag_loc_Includedatalist ;
      private bool Ddo_br_pathology_diag_organ_Includesortasc ;
      private bool Ddo_br_pathology_diag_organ_Includesortdsc ;
      private bool Ddo_br_pathology_diag_organ_Includefilter ;
      private bool Ddo_br_pathology_diag_organ_Filterisrange ;
      private bool Ddo_br_pathology_diag_organ_Includedatalist ;
      private bool Ddo_br_pathology_diag_tumortype_Includesortasc ;
      private bool Ddo_br_pathology_diag_tumortype_Includesortdsc ;
      private bool Ddo_br_pathology_diag_tumortype_Includefilter ;
      private bool Ddo_br_pathology_diag_tumortype_Filterisrange ;
      private bool Ddo_br_pathology_diag_tumortype_Includedatalist ;
      private bool Ddo_br_pathology_diag_tumorstage_Includesortasc ;
      private bool Ddo_br_pathology_diag_tumorstage_Includesortdsc ;
      private bool Ddo_br_pathology_diag_tumorstage_Includefilter ;
      private bool Ddo_br_pathology_diag_tumorstage_Filterisrange ;
      private bool Ddo_br_pathology_diag_tumorstage_Includedatalist ;
      private bool Ddo_br_pathology_diag_tumorgrade_Includesortasc ;
      private bool Ddo_br_pathology_diag_tumorgrade_Includesortdsc ;
      private bool Ddo_br_pathology_diag_tumorgrade_Includefilter ;
      private bool Ddo_br_pathology_diag_tumorgrade_Filterisrange ;
      private bool Ddo_br_pathology_diag_tumorgrade_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_31_Refreshing=false ;
      private bool n226BR_PathologyID ;
      private bool n277BR_Pathology_Diag_Loc ;
      private bool n278BR_Pathology_Diag_Organ ;
      private bool n279BR_Pathology_Diag_TumorType ;
      private bool n280BR_Pathology_Diag_TumorStage ;
      private bool n281BR_Pathology_Diag_TumorGrade ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV78TempBoolean ;
      private bool GXt_boolean2 ;
      private bool AV73Display_IsBlob ;
      private bool AV74Update_IsBlob ;
      private bool AV76Delete_IsBlob ;
      private String AV25TFBR_Pathology_Diag_Loc ;
      private String AV26TFBR_Pathology_Diag_Loc_Sel ;
      private String AV29TFBR_Pathology_Diag_Organ ;
      private String AV30TFBR_Pathology_Diag_Organ_Sel ;
      private String AV33TFBR_Pathology_Diag_TumorType ;
      private String AV34TFBR_Pathology_Diag_TumorType_Sel ;
      private String AV37TFBR_Pathology_Diag_TumorStage ;
      private String AV38TFBR_Pathology_Diag_TumorStage_Sel ;
      private String AV41TFBR_Pathology_Diag_TumorGrade ;
      private String AV42TFBR_Pathology_Diag_TumorGrade_Sel ;
      private String AV19ddo_BR_Pathology_DiagIDTitleControlIdToReplace ;
      private String AV23ddo_BR_PathologyIDTitleControlIdToReplace ;
      private String AV27ddo_BR_Pathology_Diag_LocTitleControlIdToReplace ;
      private String AV31ddo_BR_Pathology_Diag_OrganTitleControlIdToReplace ;
      private String AV35ddo_BR_Pathology_Diag_TumorTypeTitleControlIdToReplace ;
      private String AV39ddo_BR_Pathology_Diag_TumorStageTitleControlIdToReplace ;
      private String AV43ddo_BR_Pathology_Diag_TumorGradeTitleControlIdToReplace ;
      private String A277BR_Pathology_Diag_Loc ;
      private String A278BR_Pathology_Diag_Organ ;
      private String A279BR_Pathology_Diag_TumorType ;
      private String A280BR_Pathology_Diag_TumorStage ;
      private String A281BR_Pathology_Diag_TumorGrade ;
      private String AV95Display_GXI ;
      private String AV96Update_GXI ;
      private String AV97Delete_GXI ;
      private String lV85BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc ;
      private String lV87BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ ;
      private String lV89BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype ;
      private String lV91BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage ;
      private String lV93BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade ;
      private String AV86BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel ;
      private String AV85BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc ;
      private String AV88BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel ;
      private String AV87BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ ;
      private String AV90BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel ;
      private String AV89BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype ;
      private String AV92BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel ;
      private String AV91BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage ;
      private String AV94BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel ;
      private String AV93BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade ;
      private String AV73Display ;
      private String AV74Update ;
      private String AV76Delete ;
      private IGxSession AV15Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_pathology_diagid ;
      private GXUserControl ucDdo_br_pathologyid ;
      private GXUserControl ucDdo_br_pathology_diag_loc ;
      private GXUserControl ucDdo_br_pathology_diag_organ ;
      private GXUserControl ucDdo_br_pathology_diag_tumortype ;
      private GXUserControl ucDdo_br_pathology_diag_tumorstage ;
      private GXUserControl ucDdo_br_pathology_diag_tumorgrade ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H00552_A281BR_Pathology_Diag_TumorGrade ;
      private bool[] H00552_n281BR_Pathology_Diag_TumorGrade ;
      private String[] H00552_A280BR_Pathology_Diag_TumorStage ;
      private bool[] H00552_n280BR_Pathology_Diag_TumorStage ;
      private String[] H00552_A279BR_Pathology_Diag_TumorType ;
      private bool[] H00552_n279BR_Pathology_Diag_TumorType ;
      private String[] H00552_A278BR_Pathology_Diag_Organ ;
      private bool[] H00552_n278BR_Pathology_Diag_Organ ;
      private String[] H00552_A277BR_Pathology_Diag_Loc ;
      private bool[] H00552_n277BR_Pathology_Diag_Loc ;
      private long[] H00552_A226BR_PathologyID ;
      private bool[] H00552_n226BR_PathologyID ;
      private long[] H00552_A276BR_Pathology_DiagID ;
      private long[] H00553_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV16BR_Pathology_DiagIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV20BR_PathologyIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV24BR_Pathology_Diag_LocTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV28BR_Pathology_Diag_OrganTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV32BR_Pathology_Diag_TumorTypeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV36BR_Pathology_Diag_TumorStageTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV40BR_Pathology_Diag_TumorGradeTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV11GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV12GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV68DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class br_pathology_diagww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00552( IGxContext context ,
                                             long AV81BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid ,
                                             long AV82BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to ,
                                             long AV83BR_Pathology_DiagWWDS_3_Tfbr_pathologyid ,
                                             long AV84BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to ,
                                             String AV86BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel ,
                                             String AV85BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc ,
                                             String AV88BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel ,
                                             String AV87BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ ,
                                             String AV90BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel ,
                                             String AV89BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype ,
                                             String AV92BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel ,
                                             String AV91BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage ,
                                             String AV94BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel ,
                                             String AV93BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade ,
                                             long A276BR_Pathology_DiagID ,
                                             long A226BR_PathologyID ,
                                             String A277BR_Pathology_Diag_Loc ,
                                             String A278BR_Pathology_Diag_Organ ,
                                             String A279BR_Pathology_Diag_TumorType ,
                                             String A280BR_Pathology_Diag_TumorStage ,
                                             String A281BR_Pathology_Diag_TumorGrade ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [17] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [BR_Pathology_Diag_TumorGrade], [BR_Pathology_Diag_TumorStage], [BR_Pathology_Diag_TumorType], [BR_Pathology_Diag_Organ], [BR_Pathology_Diag_Loc], [BR_PathologyID], [BR_Pathology_DiagID]";
         sFromString = " FROM [BR_Pathology_Diag] WITH (NOLOCK)";
         sOrderString = "";
         if ( ! (0==AV81BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_DiagID] >= @AV81BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_DiagID] >= @AV81BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ! (0==AV82BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_DiagID] <= @AV82BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_DiagID] <= @AV82BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to)";
            }
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV83BR_Pathology_DiagWWDS_3_Tfbr_pathologyid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] >= @AV83BR_Pathology_DiagWWDS_3_Tfbr_pathologyid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] >= @AV83BR_Pathology_DiagWWDS_3_Tfbr_pathologyid)";
            }
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (0==AV84BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] <= @AV84BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] <= @AV84BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to)";
            }
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_Loc] like @lV85BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_Loc] like @lV85BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc)";
            }
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_Loc] = @AV86BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_Loc] = @AV86BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel)";
            }
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_Organ] like @lV87BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_Organ] like @lV87BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ)";
            }
         }
         else
         {
            GXv_int3[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_Organ] = @AV88BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_Organ] = @AV88BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel)";
            }
         }
         else
         {
            GXv_int3[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV89BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorType] like @lV89BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorType] like @lV89BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype)";
            }
         }
         else
         {
            GXv_int3[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorType] = @AV90BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorType] = @AV90BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel)";
            }
         }
         else
         {
            GXv_int3[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV92BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorStage] like @lV91BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorStage] like @lV91BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage)";
            }
         }
         else
         {
            GXv_int3[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV92BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorStage] = @AV92BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorStage] = @AV92BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel)";
            }
         }
         else
         {
            GXv_int3[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorGrade] like @lV93BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorGrade] like @lV93BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade)";
            }
         }
         else
         {
            GXv_int3[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorGrade] = @AV94BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorGrade] = @AV94BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel)";
            }
         }
         else
         {
            GXv_int3[13] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_DiagID]";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_DiagID] DESC";
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
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Diag_Loc]";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Diag_Loc] DESC";
         }
         else if ( ( AV13OrderedBy == 4 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Diag_Organ]";
         }
         else if ( ( AV13OrderedBy == 4 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Diag_Organ] DESC";
         }
         else if ( ( AV13OrderedBy == 5 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Diag_TumorType]";
         }
         else if ( ( AV13OrderedBy == 5 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Diag_TumorType] DESC";
         }
         else if ( ( AV13OrderedBy == 6 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Diag_TumorStage]";
         }
         else if ( ( AV13OrderedBy == 6 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Diag_TumorStage] DESC";
         }
         else if ( ( AV13OrderedBy == 7 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Diag_TumorGrade]";
         }
         else if ( ( AV13OrderedBy == 7 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Diag_TumorGrade] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_DiagID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H00553( IGxContext context ,
                                             long AV81BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid ,
                                             long AV82BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to ,
                                             long AV83BR_Pathology_DiagWWDS_3_Tfbr_pathologyid ,
                                             long AV84BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to ,
                                             String AV86BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel ,
                                             String AV85BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc ,
                                             String AV88BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel ,
                                             String AV87BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ ,
                                             String AV90BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel ,
                                             String AV89BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype ,
                                             String AV92BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel ,
                                             String AV91BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage ,
                                             String AV94BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel ,
                                             String AV93BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade ,
                                             long A276BR_Pathology_DiagID ,
                                             long A226BR_PathologyID ,
                                             String A277BR_Pathology_Diag_Loc ,
                                             String A278BR_Pathology_Diag_Organ ,
                                             String A279BR_Pathology_Diag_TumorType ,
                                             String A280BR_Pathology_Diag_TumorStage ,
                                             String A281BR_Pathology_Diag_TumorGrade ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [14] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [BR_Pathology_Diag] WITH (NOLOCK)";
         if ( ! (0==AV81BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_DiagID] >= @AV81BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_DiagID] >= @AV81BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid)";
            }
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ! (0==AV82BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_DiagID] <= @AV82BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_DiagID] <= @AV82BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to)";
            }
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( ! (0==AV83BR_Pathology_DiagWWDS_3_Tfbr_pathologyid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] >= @AV83BR_Pathology_DiagWWDS_3_Tfbr_pathologyid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] >= @AV83BR_Pathology_DiagWWDS_3_Tfbr_pathologyid)";
            }
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! (0==AV84BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] <= @AV84BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] <= @AV84BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to)";
            }
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_Loc] like @lV85BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_Loc] like @lV85BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc)";
            }
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_Loc] = @AV86BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_Loc] = @AV86BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel)";
            }
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_Organ] like @lV87BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_Organ] like @lV87BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ)";
            }
         }
         else
         {
            GXv_int5[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_Organ] = @AV88BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_Organ] = @AV88BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel)";
            }
         }
         else
         {
            GXv_int5[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV89BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorType] like @lV89BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorType] like @lV89BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype)";
            }
         }
         else
         {
            GXv_int5[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorType] = @AV90BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorType] = @AV90BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel)";
            }
         }
         else
         {
            GXv_int5[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV92BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorStage] like @lV91BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorStage] like @lV91BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage)";
            }
         }
         else
         {
            GXv_int5[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV92BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorStage] = @AV92BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorStage] = @AV92BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel)";
            }
         }
         else
         {
            GXv_int5[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorGrade] like @lV93BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorGrade] like @lV93BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade)";
            }
         }
         else
         {
            GXv_int5[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorGrade] = @AV94BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorGrade] = @AV94BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel)";
            }
         }
         else
         {
            GXv_int5[13] = 1;
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
         else if ( ( AV13OrderedBy == 5 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 5 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 6 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 6 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 7 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 7 ) && ( AV14OrderedDsc ) )
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
                     return conditional_H00552(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (long)dynConstraints[14] , (long)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (short)dynConstraints[21] , (bool)dynConstraints[22] );
               case 1 :
                     return conditional_H00553(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (long)dynConstraints[14] , (long)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (short)dynConstraints[21] , (bool)dynConstraints[22] );
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
          Object[] prmH00552 ;
          prmH00552 = new Object[] {
          new Object[] {"@AV81BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV82BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV83BR_Pathology_DiagWWDS_3_Tfbr_pathologyid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV84BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV85BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV86BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV87BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV88BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV89BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV90BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV91BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV92BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV93BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV94BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00553 ;
          prmH00553 = new Object[] {
          new Object[] {"@AV81BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV82BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV83BR_Pathology_DiagWWDS_3_Tfbr_pathologyid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV84BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV85BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV86BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV87BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV88BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV89BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV90BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV91BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV92BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV93BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV94BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel",SqlDbType.NVarChar,40,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00552", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00552,11,0,true,false )
             ,new CursorDef("H00553", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00553,1,0,true,false )
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
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((long[]) buf[10])[0] = rslt.getLong(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((long[]) buf[12])[0] = rslt.getLong(7) ;
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
                   stmt.SetParameter(sIdx, (long)parms[17]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[18]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[19]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[20]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[24]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[25]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[26]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[27]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[28]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[29]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[30]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[31]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[32]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[33]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[14]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[15]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[16]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[17]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[24]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[25]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[26]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[27]);
                }
                return;
       }
    }

 }

}
