/*
               File: BR_MedicalImaging_DiagWW
        Description:  影像学诊断意见
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:42:16.33
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
   public class br_medicalimaging_diagww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_medicalimaging_diagww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_medicalimaging_diagww( IGxContext context )
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
               AV17TFBR_MedicalImaging_DiagID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV18TFBR_MedicalImaging_DiagID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV21TFBR_MedicalImagingID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV22TFBR_MedicalImagingID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV25TFBR_MedicalImaging_Diag_Loc = GetNextPar( );
               AV26TFBR_MedicalImaging_Diag_Loc_Sel = GetNextPar( );
               AV29TFBR_MedicalImaging_Diag_Organ = GetNextPar( );
               AV30TFBR_MedicalImaging_Diag_Organ_Sel = GetNextPar( );
               AV33TFBR_MedicalImaging_Diag_Dis = GetNextPar( );
               AV34TFBR_MedicalImaging_Diag_Dis_Sel = GetNextPar( );
               AV50TFBR_MedicalImaging_Diag_No = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV51TFBR_MedicalImaging_Diag_No_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace = GetNextPar( );
               AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace = GetNextPar( );
               AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace = GetNextPar( );
               AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace = GetNextPar( );
               AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace = GetNextPar( );
               AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace = GetNextPar( );
               AV70Pgmname = GetNextPar( );
               AV47IsAuthorized_Display = StringUtil.StrToBool( GetNextPar( ));
               AV43IsAuthorized_Update = StringUtil.StrToBool( GetNextPar( ));
               AV45IsAuthorized_Delete = StringUtil.StrToBool( GetNextPar( ));
               AV48IsAuthorized_BR_MedicalImaging_Diag_Loc = StringUtil.StrToBool( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_MedicalImaging_DiagID, AV18TFBR_MedicalImaging_DiagID_To, AV21TFBR_MedicalImagingID, AV22TFBR_MedicalImagingID_To, AV25TFBR_MedicalImaging_Diag_Loc, AV26TFBR_MedicalImaging_Diag_Loc_Sel, AV29TFBR_MedicalImaging_Diag_Organ, AV30TFBR_MedicalImaging_Diag_Organ_Sel, AV33TFBR_MedicalImaging_Diag_Dis, AV34TFBR_MedicalImaging_Diag_Dis_Sel, AV50TFBR_MedicalImaging_Diag_No, AV51TFBR_MedicalImaging_Diag_No_To, AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace, AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace, AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace, AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace, AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace, AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace, AV70Pgmname, AV47IsAuthorized_Display, AV43IsAuthorized_Update, AV45IsAuthorized_Delete, AV48IsAuthorized_BR_MedicalImaging_Diag_Loc) ;
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
         PA4P2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START4P2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202279421666", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_medicalimaging_diagww.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICALIMAGING_DIAGID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFBR_MedicalImaging_DiagID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICALIMAGING_DIAGID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFBR_MedicalImaging_DiagID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICALIMAGINGID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21TFBR_MedicalImagingID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICALIMAGINGID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22TFBR_MedicalImagingID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICALIMAGING_DIAG_LOC", AV25TFBR_MedicalImaging_Diag_Loc);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICALIMAGING_DIAG_LOC_SEL", AV26TFBR_MedicalImaging_Diag_Loc_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICALIMAGING_DIAG_ORGAN", AV29TFBR_MedicalImaging_Diag_Organ);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICALIMAGING_DIAG_ORGAN_SEL", AV30TFBR_MedicalImaging_Diag_Organ_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICALIMAGING_DIAG_DIS", AV33TFBR_MedicalImaging_Diag_Dis);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICALIMAGING_DIAG_DIS_SEL", AV34TFBR_MedicalImaging_Diag_Dis_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICALIMAGING_DIAG_NO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV50TFBR_MedicalImaging_Diag_No), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICALIMAGING_DIAG_NO_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV51TFBR_MedicalImaging_Diag_No_To), 18, 0, ".", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_31", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_31), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV38GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV40GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV39GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV36DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV36DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGING_DIAGIDTITLEFILTERDATA", AV16BR_MedicalImaging_DiagIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGING_DIAGIDTITLEFILTERDATA", AV16BR_MedicalImaging_DiagIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGINGIDTITLEFILTERDATA", AV20BR_MedicalImagingIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGINGIDTITLEFILTERDATA", AV20BR_MedicalImagingIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGING_DIAG_LOCTITLEFILTERDATA", AV24BR_MedicalImaging_Diag_LocTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGING_DIAG_LOCTITLEFILTERDATA", AV24BR_MedicalImaging_Diag_LocTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGING_DIAG_ORGANTITLEFILTERDATA", AV28BR_MedicalImaging_Diag_OrganTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGING_DIAG_ORGANTITLEFILTERDATA", AV28BR_MedicalImaging_Diag_OrganTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGING_DIAG_DISTITLEFILTERDATA", AV32BR_MedicalImaging_Diag_DisTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGING_DIAG_DISTITLEFILTERDATA", AV32BR_MedicalImaging_Diag_DisTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGING_DIAG_NOTITLEFILTERDATA", AV49BR_MedicalImaging_Diag_NoTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGING_DIAG_NOTITLEFILTERDATA", AV49BR_MedicalImaging_Diag_NoTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV70Pgmname));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_DISPLAY", AV47IsAuthorized_Display);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_UPDATE", AV43IsAuthorized_Update);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_DELETE", AV45IsAuthorized_Delete);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC", AV48IsAuthorized_BR_MedicalImaging_Diag_Loc);
         GxWebStd.gx_hidden_field( context, "gxhash_vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC", GetSecureSignedToken( "", AV48IsAuthorized_BR_MedicalImaging_Diag_Loc, context));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Caption", StringUtil.RTrim( Ddo_br_medicalimaging_diagid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Tooltip", StringUtil.RTrim( Ddo_br_medicalimaging_diagid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Cls", StringUtil.RTrim( Ddo_br_medicalimaging_diagid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Filteredtext_set", StringUtil.RTrim( Ddo_br_medicalimaging_diagid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Filteredtextto_set", StringUtil.RTrim( Ddo_br_medicalimaging_diagid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_diagid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_diagid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_diagid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_diagid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_diagid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_diagid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Filtertype", StringUtil.RTrim( Ddo_br_medicalimaging_diagid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Filterisrange", StringUtil.BoolToStr( Ddo_br_medicalimaging_diagid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_diagid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_diagid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_diagid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Cleanfilter", StringUtil.RTrim( Ddo_br_medicalimaging_diagid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Rangefilterfrom", StringUtil.RTrim( Ddo_br_medicalimaging_diagid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Rangefilterto", StringUtil.RTrim( Ddo_br_medicalimaging_diagid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_diagid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Caption", StringUtil.RTrim( Ddo_br_medicalimagingid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Tooltip", StringUtil.RTrim( Ddo_br_medicalimagingid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Cls", StringUtil.RTrim( Ddo_br_medicalimagingid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Filteredtext_set", StringUtil.RTrim( Ddo_br_medicalimagingid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Filteredtextto_set", StringUtil.RTrim( Ddo_br_medicalimagingid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimagingid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimagingid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimagingid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimagingid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimagingid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimagingid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Filtertype", StringUtil.RTrim( Ddo_br_medicalimagingid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Filterisrange", StringUtil.BoolToStr( Ddo_br_medicalimagingid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimagingid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Sortasc", StringUtil.RTrim( Ddo_br_medicalimagingid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimagingid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Cleanfilter", StringUtil.RTrim( Ddo_br_medicalimagingid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Rangefilterfrom", StringUtil.RTrim( Ddo_br_medicalimagingid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Rangefilterto", StringUtil.RTrim( Ddo_br_medicalimagingid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimagingid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Caption", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Tooltip", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Cls", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Filteredtext_set", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Selectedvalue_set", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_loc_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_loc_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_loc_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Filtertype", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Filterisrange", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_loc_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_loc_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Datalisttype", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Datalistproc", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_medicalimaging_diag_loc_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Loadingdata", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Cleanfilter", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Noresultsfound", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Caption", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Tooltip", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Cls", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Filteredtext_set", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Selectedvalue_set", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_organ_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_organ_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_organ_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Filtertype", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Filterisrange", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_organ_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_organ_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Datalisttype", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Datalistproc", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_medicalimaging_diag_organ_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Loadingdata", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Cleanfilter", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Noresultsfound", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Caption", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Tooltip", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Cls", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Filteredtext_set", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Selectedvalue_set", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_dis_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_dis_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_dis_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Filtertype", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Filterisrange", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_dis_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_dis_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Datalisttype", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Datalistproc", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_medicalimaging_diag_dis_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Loadingdata", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Cleanfilter", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Noresultsfound", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Caption", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Tooltip", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Cls", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Filteredtext_set", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Filteredtextto_set", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_no_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_no_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_no_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Filtertype", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Filterisrange", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_no_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_no_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Cleanfilter", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Rangefilterfrom", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Rangefilterto", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_diagid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Filteredtext_get", StringUtil.RTrim( Ddo_br_medicalimaging_diagid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_medicalimaging_diagid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimagingid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Filteredtext_get", StringUtil.RTrim( Ddo_br_medicalimagingid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_medicalimagingid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Filteredtext_get", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Filteredtext_get", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Filteredtext_get", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Filteredtext_get", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Filteredtextto_get", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_diagid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Filteredtext_get", StringUtil.RTrim( Ddo_br_medicalimaging_diagid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_medicalimaging_diagid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimagingid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Filteredtext_get", StringUtil.RTrim( Ddo_br_medicalimagingid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_medicalimagingid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Filteredtext_get", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Filteredtext_get", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Filteredtext_get", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Filteredtext_get", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Filteredtextto_get", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Filteredtextto_get));
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
            WE4P2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT4P2( ) ;
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
         return formatLink("br_medicalimaging_diagww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "BR_MedicalImaging_DiagWW" ;
      }

      public override String GetPgmdesc( )
      {
         return " 影像学诊断意见" ;
      }

      protected void WB4P0( )
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
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(31), 2, 0)+","+"null"+");", "插入", bttBtninsert_Jsonclick, 5, "插入", "", StyleString, ClassString, bttBtninsert_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_MedicalImaging_DiagWW.htm");
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DeleteAttribute ActionBaseColorAttribute"+"\" "+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_MedicalImaging_DiagID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_MedicalImaging_DiagID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_MedicalImaging_DiagID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_MedicalImagingID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_MedicalImagingID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_MedicalImagingID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_MedicalImaging_Diag_Loc_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_MedicalImaging_Diag_Loc_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_MedicalImaging_Diag_Loc_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_MedicalImaging_Diag_Organ_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_MedicalImaging_Diag_Organ_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_MedicalImaging_Diag_Organ_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_MedicalImaging_Diag_Dis_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_MedicalImaging_Diag_Dis_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_MedicalImaging_Diag_Dis_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_MedicalImaging_Diag_No_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_MedicalImaging_Diag_No_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_MedicalImaging_Diag_No_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV41Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDisplay_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV42Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV44Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A270BR_MedicalImaging_DiagID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicalImaging_DiagID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicalImaging_DiagID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A225BR_MedicalImagingID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicalImagingID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicalImagingID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A271BR_MedicalImaging_Diag_Loc);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicalImaging_Diag_Loc_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicalImaging_Diag_Loc_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtBR_MedicalImaging_Diag_Loc_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A272BR_MedicalImaging_Diag_Organ);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicalImaging_Diag_Organ_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicalImaging_Diag_Organ_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A273BR_MedicalImaging_Diag_Dis);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicalImaging_Diag_Dis_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicalImaging_Diag_Dis_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A517BR_MedicalImaging_Diag_No), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicalImaging_Diag_No_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicalImaging_Diag_No_Titleformat), 4, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV38GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV40GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV39GridPageSize);
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
            ucDdo_br_medicalimaging_diagid.SetProperty("Caption", Ddo_br_medicalimaging_diagid_Caption);
            ucDdo_br_medicalimaging_diagid.SetProperty("Tooltip", Ddo_br_medicalimaging_diagid_Tooltip);
            ucDdo_br_medicalimaging_diagid.SetProperty("Cls", Ddo_br_medicalimaging_diagid_Cls);
            ucDdo_br_medicalimaging_diagid.SetProperty("DropDownOptionsType", Ddo_br_medicalimaging_diagid_Dropdownoptionstype);
            ucDdo_br_medicalimaging_diagid.SetProperty("IncludeSortASC", Ddo_br_medicalimaging_diagid_Includesortasc);
            ucDdo_br_medicalimaging_diagid.SetProperty("IncludeSortDSC", Ddo_br_medicalimaging_diagid_Includesortdsc);
            ucDdo_br_medicalimaging_diagid.SetProperty("IncludeFilter", Ddo_br_medicalimaging_diagid_Includefilter);
            ucDdo_br_medicalimaging_diagid.SetProperty("FilterType", Ddo_br_medicalimaging_diagid_Filtertype);
            ucDdo_br_medicalimaging_diagid.SetProperty("FilterIsRange", Ddo_br_medicalimaging_diagid_Filterisrange);
            ucDdo_br_medicalimaging_diagid.SetProperty("IncludeDataList", Ddo_br_medicalimaging_diagid_Includedatalist);
            ucDdo_br_medicalimaging_diagid.SetProperty("SortASC", Ddo_br_medicalimaging_diagid_Sortasc);
            ucDdo_br_medicalimaging_diagid.SetProperty("SortDSC", Ddo_br_medicalimaging_diagid_Sortdsc);
            ucDdo_br_medicalimaging_diagid.SetProperty("CleanFilter", Ddo_br_medicalimaging_diagid_Cleanfilter);
            ucDdo_br_medicalimaging_diagid.SetProperty("RangeFilterFrom", Ddo_br_medicalimaging_diagid_Rangefilterfrom);
            ucDdo_br_medicalimaging_diagid.SetProperty("RangeFilterTo", Ddo_br_medicalimaging_diagid_Rangefilterto);
            ucDdo_br_medicalimaging_diagid.SetProperty("SearchButtonText", Ddo_br_medicalimaging_diagid_Searchbuttontext);
            ucDdo_br_medicalimaging_diagid.SetProperty("DropDownOptionsTitleSettingsIcons", AV36DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_diagid.SetProperty("DropDownOptionsData", AV16BR_MedicalImaging_DiagIDTitleFilterData);
            ucDdo_br_medicalimaging_diagid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_diagid_Internalname, "DDO_BR_MEDICALIMAGING_DIAGIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_diagidtitlecontrolidtoreplace_Internalname, AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", 0, edtavDdo_br_medicalimaging_diagidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImaging_DiagWW.htm");
            /* User Defined Control */
            ucDdo_br_medicalimagingid.SetProperty("Caption", Ddo_br_medicalimagingid_Caption);
            ucDdo_br_medicalimagingid.SetProperty("Tooltip", Ddo_br_medicalimagingid_Tooltip);
            ucDdo_br_medicalimagingid.SetProperty("Cls", Ddo_br_medicalimagingid_Cls);
            ucDdo_br_medicalimagingid.SetProperty("DropDownOptionsType", Ddo_br_medicalimagingid_Dropdownoptionstype);
            ucDdo_br_medicalimagingid.SetProperty("IncludeSortASC", Ddo_br_medicalimagingid_Includesortasc);
            ucDdo_br_medicalimagingid.SetProperty("IncludeSortDSC", Ddo_br_medicalimagingid_Includesortdsc);
            ucDdo_br_medicalimagingid.SetProperty("IncludeFilter", Ddo_br_medicalimagingid_Includefilter);
            ucDdo_br_medicalimagingid.SetProperty("FilterType", Ddo_br_medicalimagingid_Filtertype);
            ucDdo_br_medicalimagingid.SetProperty("FilterIsRange", Ddo_br_medicalimagingid_Filterisrange);
            ucDdo_br_medicalimagingid.SetProperty("IncludeDataList", Ddo_br_medicalimagingid_Includedatalist);
            ucDdo_br_medicalimagingid.SetProperty("SortASC", Ddo_br_medicalimagingid_Sortasc);
            ucDdo_br_medicalimagingid.SetProperty("SortDSC", Ddo_br_medicalimagingid_Sortdsc);
            ucDdo_br_medicalimagingid.SetProperty("CleanFilter", Ddo_br_medicalimagingid_Cleanfilter);
            ucDdo_br_medicalimagingid.SetProperty("RangeFilterFrom", Ddo_br_medicalimagingid_Rangefilterfrom);
            ucDdo_br_medicalimagingid.SetProperty("RangeFilterTo", Ddo_br_medicalimagingid_Rangefilterto);
            ucDdo_br_medicalimagingid.SetProperty("SearchButtonText", Ddo_br_medicalimagingid_Searchbuttontext);
            ucDdo_br_medicalimagingid.SetProperty("DropDownOptionsTitleSettingsIcons", AV36DDO_TitleSettingsIcons);
            ucDdo_br_medicalimagingid.SetProperty("DropDownOptionsData", AV20BR_MedicalImagingIDTitleFilterData);
            ucDdo_br_medicalimagingid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimagingid_Internalname, "DDO_BR_MEDICALIMAGINGIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Internalname, AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", 0, edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImaging_DiagWW.htm");
            /* User Defined Control */
            ucDdo_br_medicalimaging_diag_loc.SetProperty("Caption", Ddo_br_medicalimaging_diag_loc_Caption);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("Tooltip", Ddo_br_medicalimaging_diag_loc_Tooltip);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("Cls", Ddo_br_medicalimaging_diag_loc_Cls);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("DropDownOptionsType", Ddo_br_medicalimaging_diag_loc_Dropdownoptionstype);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("IncludeSortASC", Ddo_br_medicalimaging_diag_loc_Includesortasc);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("IncludeSortDSC", Ddo_br_medicalimaging_diag_loc_Includesortdsc);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("IncludeFilter", Ddo_br_medicalimaging_diag_loc_Includefilter);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("FilterType", Ddo_br_medicalimaging_diag_loc_Filtertype);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("FilterIsRange", Ddo_br_medicalimaging_diag_loc_Filterisrange);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("IncludeDataList", Ddo_br_medicalimaging_diag_loc_Includedatalist);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("DataListType", Ddo_br_medicalimaging_diag_loc_Datalisttype);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("DataListProc", Ddo_br_medicalimaging_diag_loc_Datalistproc);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_medicalimaging_diag_loc_Datalistupdateminimumcharacters);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("SortASC", Ddo_br_medicalimaging_diag_loc_Sortasc);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("SortDSC", Ddo_br_medicalimaging_diag_loc_Sortdsc);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("LoadingData", Ddo_br_medicalimaging_diag_loc_Loadingdata);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("CleanFilter", Ddo_br_medicalimaging_diag_loc_Cleanfilter);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("NoResultsFound", Ddo_br_medicalimaging_diag_loc_Noresultsfound);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("SearchButtonText", Ddo_br_medicalimaging_diag_loc_Searchbuttontext);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("DropDownOptionsTitleSettingsIcons", AV36DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("DropDownOptionsData", AV24BR_MedicalImaging_Diag_LocTitleFilterData);
            ucDdo_br_medicalimaging_diag_loc.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_diag_loc_Internalname, "DDO_BR_MEDICALIMAGING_DIAG_LOCContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_diag_loctitlecontrolidtoreplace_Internalname, AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", 0, edtavDdo_br_medicalimaging_diag_loctitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImaging_DiagWW.htm");
            /* User Defined Control */
            ucDdo_br_medicalimaging_diag_organ.SetProperty("Caption", Ddo_br_medicalimaging_diag_organ_Caption);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("Tooltip", Ddo_br_medicalimaging_diag_organ_Tooltip);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("Cls", Ddo_br_medicalimaging_diag_organ_Cls);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("DropDownOptionsType", Ddo_br_medicalimaging_diag_organ_Dropdownoptionstype);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("IncludeSortASC", Ddo_br_medicalimaging_diag_organ_Includesortasc);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("IncludeSortDSC", Ddo_br_medicalimaging_diag_organ_Includesortdsc);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("IncludeFilter", Ddo_br_medicalimaging_diag_organ_Includefilter);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("FilterType", Ddo_br_medicalimaging_diag_organ_Filtertype);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("FilterIsRange", Ddo_br_medicalimaging_diag_organ_Filterisrange);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("IncludeDataList", Ddo_br_medicalimaging_diag_organ_Includedatalist);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("DataListType", Ddo_br_medicalimaging_diag_organ_Datalisttype);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("DataListProc", Ddo_br_medicalimaging_diag_organ_Datalistproc);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_medicalimaging_diag_organ_Datalistupdateminimumcharacters);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("SortASC", Ddo_br_medicalimaging_diag_organ_Sortasc);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("SortDSC", Ddo_br_medicalimaging_diag_organ_Sortdsc);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("LoadingData", Ddo_br_medicalimaging_diag_organ_Loadingdata);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("CleanFilter", Ddo_br_medicalimaging_diag_organ_Cleanfilter);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("NoResultsFound", Ddo_br_medicalimaging_diag_organ_Noresultsfound);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("SearchButtonText", Ddo_br_medicalimaging_diag_organ_Searchbuttontext);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("DropDownOptionsTitleSettingsIcons", AV36DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("DropDownOptionsData", AV28BR_MedicalImaging_Diag_OrganTitleFilterData);
            ucDdo_br_medicalimaging_diag_organ.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_diag_organ_Internalname, "DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_diag_organtitlecontrolidtoreplace_Internalname, AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", 0, edtavDdo_br_medicalimaging_diag_organtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImaging_DiagWW.htm");
            /* User Defined Control */
            ucDdo_br_medicalimaging_diag_dis.SetProperty("Caption", Ddo_br_medicalimaging_diag_dis_Caption);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("Tooltip", Ddo_br_medicalimaging_diag_dis_Tooltip);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("Cls", Ddo_br_medicalimaging_diag_dis_Cls);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("DropDownOptionsType", Ddo_br_medicalimaging_diag_dis_Dropdownoptionstype);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("IncludeSortASC", Ddo_br_medicalimaging_diag_dis_Includesortasc);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("IncludeSortDSC", Ddo_br_medicalimaging_diag_dis_Includesortdsc);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("IncludeFilter", Ddo_br_medicalimaging_diag_dis_Includefilter);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("FilterType", Ddo_br_medicalimaging_diag_dis_Filtertype);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("FilterIsRange", Ddo_br_medicalimaging_diag_dis_Filterisrange);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("IncludeDataList", Ddo_br_medicalimaging_diag_dis_Includedatalist);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("DataListType", Ddo_br_medicalimaging_diag_dis_Datalisttype);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("DataListProc", Ddo_br_medicalimaging_diag_dis_Datalistproc);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_medicalimaging_diag_dis_Datalistupdateminimumcharacters);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("SortASC", Ddo_br_medicalimaging_diag_dis_Sortasc);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("SortDSC", Ddo_br_medicalimaging_diag_dis_Sortdsc);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("LoadingData", Ddo_br_medicalimaging_diag_dis_Loadingdata);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("CleanFilter", Ddo_br_medicalimaging_diag_dis_Cleanfilter);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("NoResultsFound", Ddo_br_medicalimaging_diag_dis_Noresultsfound);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("SearchButtonText", Ddo_br_medicalimaging_diag_dis_Searchbuttontext);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("DropDownOptionsTitleSettingsIcons", AV36DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("DropDownOptionsData", AV32BR_MedicalImaging_Diag_DisTitleFilterData);
            ucDdo_br_medicalimaging_diag_dis.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_diag_dis_Internalname, "DDO_BR_MEDICALIMAGING_DIAG_DISContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_diag_distitlecontrolidtoreplace_Internalname, AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", 0, edtavDdo_br_medicalimaging_diag_distitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImaging_DiagWW.htm");
            /* User Defined Control */
            ucDdo_br_medicalimaging_diag_no.SetProperty("Caption", Ddo_br_medicalimaging_diag_no_Caption);
            ucDdo_br_medicalimaging_diag_no.SetProperty("Tooltip", Ddo_br_medicalimaging_diag_no_Tooltip);
            ucDdo_br_medicalimaging_diag_no.SetProperty("Cls", Ddo_br_medicalimaging_diag_no_Cls);
            ucDdo_br_medicalimaging_diag_no.SetProperty("DropDownOptionsType", Ddo_br_medicalimaging_diag_no_Dropdownoptionstype);
            ucDdo_br_medicalimaging_diag_no.SetProperty("IncludeSortASC", Ddo_br_medicalimaging_diag_no_Includesortasc);
            ucDdo_br_medicalimaging_diag_no.SetProperty("IncludeSortDSC", Ddo_br_medicalimaging_diag_no_Includesortdsc);
            ucDdo_br_medicalimaging_diag_no.SetProperty("IncludeFilter", Ddo_br_medicalimaging_diag_no_Includefilter);
            ucDdo_br_medicalimaging_diag_no.SetProperty("FilterType", Ddo_br_medicalimaging_diag_no_Filtertype);
            ucDdo_br_medicalimaging_diag_no.SetProperty("FilterIsRange", Ddo_br_medicalimaging_diag_no_Filterisrange);
            ucDdo_br_medicalimaging_diag_no.SetProperty("IncludeDataList", Ddo_br_medicalimaging_diag_no_Includedatalist);
            ucDdo_br_medicalimaging_diag_no.SetProperty("SortASC", Ddo_br_medicalimaging_diag_no_Sortasc);
            ucDdo_br_medicalimaging_diag_no.SetProperty("SortDSC", Ddo_br_medicalimaging_diag_no_Sortdsc);
            ucDdo_br_medicalimaging_diag_no.SetProperty("CleanFilter", Ddo_br_medicalimaging_diag_no_Cleanfilter);
            ucDdo_br_medicalimaging_diag_no.SetProperty("RangeFilterFrom", Ddo_br_medicalimaging_diag_no_Rangefilterfrom);
            ucDdo_br_medicalimaging_diag_no.SetProperty("RangeFilterTo", Ddo_br_medicalimaging_diag_no_Rangefilterto);
            ucDdo_br_medicalimaging_diag_no.SetProperty("SearchButtonText", Ddo_br_medicalimaging_diag_no_Searchbuttontext);
            ucDdo_br_medicalimaging_diag_no.SetProperty("DropDownOptionsTitleSettingsIcons", AV36DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_diag_no.SetProperty("DropDownOptionsData", AV49BR_MedicalImaging_Diag_NoTitleFilterData);
            ucDdo_br_medicalimaging_diag_no.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_diag_no_Internalname, "DDO_BR_MEDICALIMAGING_DIAG_NOContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_diag_notitlecontrolidtoreplace_Internalname, AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", 0, edtavDdo_br_medicalimaging_diag_notitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImaging_DiagWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,61);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicalImaging_DiagWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,62);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_MedicalImaging_DiagWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medicalimaging_diagid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFBR_MedicalImaging_DiagID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV17TFBR_MedicalImaging_DiagID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medicalimaging_diagid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medicalimaging_diagid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicalImaging_DiagWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medicalimaging_diagid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFBR_MedicalImaging_DiagID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV18TFBR_MedicalImaging_DiagID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medicalimaging_diagid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medicalimaging_diagid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicalImaging_DiagWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medicalimagingid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21TFBR_MedicalImagingID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV21TFBR_MedicalImagingID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,65);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medicalimagingid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medicalimagingid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicalImaging_DiagWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medicalimagingid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22TFBR_MedicalImagingID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV22TFBR_MedicalImagingID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medicalimagingid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medicalimagingid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicalImaging_DiagWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medicalimaging_diag_loc_Internalname, AV25TFBR_MedicalImaging_Diag_Loc, StringUtil.RTrim( context.localUtil.Format( AV25TFBR_MedicalImaging_Diag_Loc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,67);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medicalimaging_diag_loc_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medicalimaging_diag_loc_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicalImaging_DiagWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medicalimaging_diag_loc_sel_Internalname, AV26TFBR_MedicalImaging_Diag_Loc_Sel, StringUtil.RTrim( context.localUtil.Format( AV26TFBR_MedicalImaging_Diag_Loc_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,68);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medicalimaging_diag_loc_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medicalimaging_diag_loc_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicalImaging_DiagWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medicalimaging_diag_organ_Internalname, AV29TFBR_MedicalImaging_Diag_Organ, StringUtil.RTrim( context.localUtil.Format( AV29TFBR_MedicalImaging_Diag_Organ, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,69);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medicalimaging_diag_organ_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medicalimaging_diag_organ_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicalImaging_DiagWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medicalimaging_diag_organ_sel_Internalname, AV30TFBR_MedicalImaging_Diag_Organ_Sel, StringUtil.RTrim( context.localUtil.Format( AV30TFBR_MedicalImaging_Diag_Organ_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,70);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medicalimaging_diag_organ_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medicalimaging_diag_organ_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicalImaging_DiagWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medicalimaging_diag_dis_Internalname, AV33TFBR_MedicalImaging_Diag_Dis, StringUtil.RTrim( context.localUtil.Format( AV33TFBR_MedicalImaging_Diag_Dis, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,71);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medicalimaging_diag_dis_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medicalimaging_diag_dis_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicalImaging_DiagWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medicalimaging_diag_dis_sel_Internalname, AV34TFBR_MedicalImaging_Diag_Dis_Sel, StringUtil.RTrim( context.localUtil.Format( AV34TFBR_MedicalImaging_Diag_Dis_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,72);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medicalimaging_diag_dis_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medicalimaging_diag_dis_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicalImaging_DiagWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medicalimaging_diag_no_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV50TFBR_MedicalImaging_Diag_No), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV50TFBR_MedicalImaging_Diag_No), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,73);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medicalimaging_diag_no_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medicalimaging_diag_no_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicalImaging_DiagWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medicalimaging_diag_no_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV51TFBR_MedicalImaging_Diag_No_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV51TFBR_MedicalImaging_Diag_No_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,74);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medicalimaging_diag_no_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medicalimaging_diag_no_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicalImaging_DiagWW.htm");
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

      protected void START4P2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", " 影像学诊断意见", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP4P0( ) ;
      }

      protected void WS4P2( )
      {
         START4P2( ) ;
         EVT4P2( ) ;
      }

      protected void EVT4P2( )
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
                              E114P2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E124P2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_DIAGID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E134P2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGINGID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E144P2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_DIAG_LOC.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E154P2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E164P2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_DIAG_DIS.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E174P2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_DIAG_NO.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E184P2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E194P2 ();
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
                              AV41Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV41Display)) ? AV67Display_GXI : context.convertURL( context.PathToRelativeUrl( AV41Display))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV41Display), true);
                              AV42Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV42Update)) ? AV68Update_GXI : context.convertURL( context.PathToRelativeUrl( AV42Update))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV42Update), true);
                              AV44Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV44Delete)) ? AV69Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV44Delete))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV44Delete), true);
                              A270BR_MedicalImaging_DiagID = (long)(context.localUtil.CToN( cgiGet( edtBR_MedicalImaging_DiagID_Internalname), ".", ","));
                              A225BR_MedicalImagingID = (long)(context.localUtil.CToN( cgiGet( edtBR_MedicalImagingID_Internalname), ".", ","));
                              n225BR_MedicalImagingID = false;
                              A271BR_MedicalImaging_Diag_Loc = cgiGet( edtBR_MedicalImaging_Diag_Loc_Internalname);
                              n271BR_MedicalImaging_Diag_Loc = false;
                              A272BR_MedicalImaging_Diag_Organ = cgiGet( edtBR_MedicalImaging_Diag_Organ_Internalname);
                              n272BR_MedicalImaging_Diag_Organ = false;
                              A273BR_MedicalImaging_Diag_Dis = cgiGet( edtBR_MedicalImaging_Diag_Dis_Internalname);
                              n273BR_MedicalImaging_Diag_Dis = false;
                              A517BR_MedicalImaging_Diag_No = (long)(context.localUtil.CToN( cgiGet( edtBR_MedicalImaging_Diag_No_Internalname), ".", ","));
                              n517BR_MedicalImaging_Diag_No = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E204P2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E214P2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E224P2 ();
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
                                       /* Set Refresh If Tfbr_medicalimaging_diagid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICALIMAGING_DIAGID"), ".", ",") != Convert.ToDecimal( AV17TFBR_MedicalImaging_DiagID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medicalimaging_diagid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICALIMAGING_DIAGID_TO"), ".", ",") != Convert.ToDecimal( AV18TFBR_MedicalImaging_DiagID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medicalimagingid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICALIMAGINGID"), ".", ",") != Convert.ToDecimal( AV21TFBR_MedicalImagingID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medicalimagingid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICALIMAGINGID_TO"), ".", ",") != Convert.ToDecimal( AV22TFBR_MedicalImagingID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medicalimaging_diag_loc Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICALIMAGING_DIAG_LOC"), AV25TFBR_MedicalImaging_Diag_Loc) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medicalimaging_diag_loc_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICALIMAGING_DIAG_LOC_SEL"), AV26TFBR_MedicalImaging_Diag_Loc_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medicalimaging_diag_organ Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICALIMAGING_DIAG_ORGAN"), AV29TFBR_MedicalImaging_Diag_Organ) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medicalimaging_diag_organ_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICALIMAGING_DIAG_ORGAN_SEL"), AV30TFBR_MedicalImaging_Diag_Organ_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medicalimaging_diag_dis Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICALIMAGING_DIAG_DIS"), AV33TFBR_MedicalImaging_Diag_Dis) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medicalimaging_diag_dis_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICALIMAGING_DIAG_DIS_SEL"), AV34TFBR_MedicalImaging_Diag_Dis_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medicalimaging_diag_no Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICALIMAGING_DIAG_NO"), ".", ",") != Convert.ToDecimal( AV50TFBR_MedicalImaging_Diag_No )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medicalimaging_diag_no_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICALIMAGING_DIAG_NO_TO"), ".", ",") != Convert.ToDecimal( AV51TFBR_MedicalImaging_Diag_No_To )) )
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

      protected void WE4P2( )
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

      protected void PA4P2( )
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
               GX_FocusControl = edtavDdo_br_medicalimaging_diagidtitlecontrolidtoreplace_Internalname;
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
                                       long AV17TFBR_MedicalImaging_DiagID ,
                                       long AV18TFBR_MedicalImaging_DiagID_To ,
                                       long AV21TFBR_MedicalImagingID ,
                                       long AV22TFBR_MedicalImagingID_To ,
                                       String AV25TFBR_MedicalImaging_Diag_Loc ,
                                       String AV26TFBR_MedicalImaging_Diag_Loc_Sel ,
                                       String AV29TFBR_MedicalImaging_Diag_Organ ,
                                       String AV30TFBR_MedicalImaging_Diag_Organ_Sel ,
                                       String AV33TFBR_MedicalImaging_Diag_Dis ,
                                       String AV34TFBR_MedicalImaging_Diag_Dis_Sel ,
                                       long AV50TFBR_MedicalImaging_Diag_No ,
                                       long AV51TFBR_MedicalImaging_Diag_No_To ,
                                       String AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace ,
                                       String AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace ,
                                       String AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace ,
                                       String AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace ,
                                       String AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace ,
                                       String AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace ,
                                       String AV70Pgmname ,
                                       bool AV47IsAuthorized_Display ,
                                       bool AV43IsAuthorized_Update ,
                                       bool AV45IsAuthorized_Delete ,
                                       bool AV48IsAuthorized_BR_MedicalImaging_Diag_Loc )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF4P2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_MEDICALIMAGING_DIAGID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A270BR_MedicalImaging_DiagID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_MEDICALIMAGING_DIAGID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A270BR_MedicalImaging_DiagID), 18, 0, ".", "")));
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
         RF4P2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV70Pgmname = "BR_MedicalImaging_DiagWW";
         context.Gx_err = 0;
      }

      protected void RF4P2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 31;
         /* Execute user event: Refresh */
         E214P2 ();
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
                                                 AV55BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid ,
                                                 AV56BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to ,
                                                 AV57BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid ,
                                                 AV58BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to ,
                                                 AV60BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel ,
                                                 AV59BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc ,
                                                 AV62BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel ,
                                                 AV61BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ ,
                                                 AV64BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel ,
                                                 AV63BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis ,
                                                 AV65BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no ,
                                                 AV66BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to ,
                                                 A270BR_MedicalImaging_DiagID ,
                                                 A225BR_MedicalImagingID ,
                                                 A271BR_MedicalImaging_Diag_Loc ,
                                                 A272BR_MedicalImaging_Diag_Organ ,
                                                 A273BR_MedicalImaging_Diag_Dis ,
                                                 A517BR_MedicalImaging_Diag_No ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                                 TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                                 TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV59BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc = StringUtil.Concat( StringUtil.RTrim( AV59BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc), "%", "");
            lV61BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ = StringUtil.Concat( StringUtil.RTrim( AV61BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ), "%", "");
            lV63BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis = StringUtil.Concat( StringUtil.RTrim( AV63BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis), "%", "");
            /* Using cursor H004P2 */
            pr_default.execute(0, new Object[] {AV55BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid, AV56BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to, AV57BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid, AV58BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to, lV59BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc, AV60BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel, lV61BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ, AV62BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel, lV63BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis, AV64BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel, AV65BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no, AV66BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_31_idx = 1;
            sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
            SubsflControlProps_312( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A517BR_MedicalImaging_Diag_No = H004P2_A517BR_MedicalImaging_Diag_No[0];
               n517BR_MedicalImaging_Diag_No = H004P2_n517BR_MedicalImaging_Diag_No[0];
               A273BR_MedicalImaging_Diag_Dis = H004P2_A273BR_MedicalImaging_Diag_Dis[0];
               n273BR_MedicalImaging_Diag_Dis = H004P2_n273BR_MedicalImaging_Diag_Dis[0];
               A272BR_MedicalImaging_Diag_Organ = H004P2_A272BR_MedicalImaging_Diag_Organ[0];
               n272BR_MedicalImaging_Diag_Organ = H004P2_n272BR_MedicalImaging_Diag_Organ[0];
               A271BR_MedicalImaging_Diag_Loc = H004P2_A271BR_MedicalImaging_Diag_Loc[0];
               n271BR_MedicalImaging_Diag_Loc = H004P2_n271BR_MedicalImaging_Diag_Loc[0];
               A225BR_MedicalImagingID = H004P2_A225BR_MedicalImagingID[0];
               n225BR_MedicalImagingID = H004P2_n225BR_MedicalImagingID[0];
               A270BR_MedicalImaging_DiagID = H004P2_A270BR_MedicalImaging_DiagID[0];
               E224P2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 31;
            WB4P0( ) ;
         }
         bGXsfl_31_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes4P2( )
      {
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC", AV48IsAuthorized_BR_MedicalImaging_Diag_Loc);
         GxWebStd.gx_hidden_field( context, "gxhash_vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC", GetSecureSignedToken( "", AV48IsAuthorized_BR_MedicalImaging_Diag_Loc, context));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_MEDICALIMAGING_DIAGID"+"_"+sGXsfl_31_idx, GetSecureSignedToken( sGXsfl_31_idx, context.localUtil.Format( (decimal)(A270BR_MedicalImaging_DiagID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         AV55BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid = AV17TFBR_MedicalImaging_DiagID;
         AV56BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to = AV18TFBR_MedicalImaging_DiagID_To;
         AV57BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid = AV21TFBR_MedicalImagingID;
         AV58BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to = AV22TFBR_MedicalImagingID_To;
         AV59BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc = AV25TFBR_MedicalImaging_Diag_Loc;
         AV60BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel = AV26TFBR_MedicalImaging_Diag_Loc_Sel;
         AV61BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ = AV29TFBR_MedicalImaging_Diag_Organ;
         AV62BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel = AV30TFBR_MedicalImaging_Diag_Organ_Sel;
         AV63BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis = AV33TFBR_MedicalImaging_Diag_Dis;
         AV64BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel = AV34TFBR_MedicalImaging_Diag_Dis_Sel;
         AV65BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no = AV50TFBR_MedicalImaging_Diag_No;
         AV66BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to = AV51TFBR_MedicalImaging_Diag_No_To;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV55BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid ,
                                              AV56BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to ,
                                              AV57BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid ,
                                              AV58BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to ,
                                              AV60BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel ,
                                              AV59BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc ,
                                              AV62BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel ,
                                              AV61BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ ,
                                              AV64BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel ,
                                              AV63BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis ,
                                              AV65BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no ,
                                              AV66BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to ,
                                              A270BR_MedicalImaging_DiagID ,
                                              A225BR_MedicalImagingID ,
                                              A271BR_MedicalImaging_Diag_Loc ,
                                              A272BR_MedicalImaging_Diag_Organ ,
                                              A273BR_MedicalImaging_Diag_Dis ,
                                              A517BR_MedicalImaging_Diag_No ,
                                              AV13OrderedBy ,
                                              AV14OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV59BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc = StringUtil.Concat( StringUtil.RTrim( AV59BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc), "%", "");
         lV61BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ = StringUtil.Concat( StringUtil.RTrim( AV61BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ), "%", "");
         lV63BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis = StringUtil.Concat( StringUtil.RTrim( AV63BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis), "%", "");
         /* Using cursor H004P3 */
         pr_default.execute(1, new Object[] {AV55BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid, AV56BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to, AV57BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid, AV58BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to, lV59BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc, AV60BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel, lV61BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ, AV62BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel, lV63BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis, AV64BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel, AV65BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no, AV66BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to});
         GRID_nRecordCount = H004P3_AGRID_nRecordCount[0];
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
         AV55BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid = AV17TFBR_MedicalImaging_DiagID;
         AV56BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to = AV18TFBR_MedicalImaging_DiagID_To;
         AV57BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid = AV21TFBR_MedicalImagingID;
         AV58BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to = AV22TFBR_MedicalImagingID_To;
         AV59BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc = AV25TFBR_MedicalImaging_Diag_Loc;
         AV60BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel = AV26TFBR_MedicalImaging_Diag_Loc_Sel;
         AV61BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ = AV29TFBR_MedicalImaging_Diag_Organ;
         AV62BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel = AV30TFBR_MedicalImaging_Diag_Organ_Sel;
         AV63BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis = AV33TFBR_MedicalImaging_Diag_Dis;
         AV64BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel = AV34TFBR_MedicalImaging_Diag_Dis_Sel;
         AV65BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no = AV50TFBR_MedicalImaging_Diag_No;
         AV66BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to = AV51TFBR_MedicalImaging_Diag_No_To;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_MedicalImaging_DiagID, AV18TFBR_MedicalImaging_DiagID_To, AV21TFBR_MedicalImagingID, AV22TFBR_MedicalImagingID_To, AV25TFBR_MedicalImaging_Diag_Loc, AV26TFBR_MedicalImaging_Diag_Loc_Sel, AV29TFBR_MedicalImaging_Diag_Organ, AV30TFBR_MedicalImaging_Diag_Organ_Sel, AV33TFBR_MedicalImaging_Diag_Dis, AV34TFBR_MedicalImaging_Diag_Dis_Sel, AV50TFBR_MedicalImaging_Diag_No, AV51TFBR_MedicalImaging_Diag_No_To, AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace, AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace, AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace, AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace, AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace, AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace, AV70Pgmname, AV47IsAuthorized_Display, AV43IsAuthorized_Update, AV45IsAuthorized_Delete, AV48IsAuthorized_BR_MedicalImaging_Diag_Loc) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV55BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid = AV17TFBR_MedicalImaging_DiagID;
         AV56BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to = AV18TFBR_MedicalImaging_DiagID_To;
         AV57BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid = AV21TFBR_MedicalImagingID;
         AV58BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to = AV22TFBR_MedicalImagingID_To;
         AV59BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc = AV25TFBR_MedicalImaging_Diag_Loc;
         AV60BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel = AV26TFBR_MedicalImaging_Diag_Loc_Sel;
         AV61BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ = AV29TFBR_MedicalImaging_Diag_Organ;
         AV62BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel = AV30TFBR_MedicalImaging_Diag_Organ_Sel;
         AV63BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis = AV33TFBR_MedicalImaging_Diag_Dis;
         AV64BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel = AV34TFBR_MedicalImaging_Diag_Dis_Sel;
         AV65BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no = AV50TFBR_MedicalImaging_Diag_No;
         AV66BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to = AV51TFBR_MedicalImaging_Diag_No_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_MedicalImaging_DiagID, AV18TFBR_MedicalImaging_DiagID_To, AV21TFBR_MedicalImagingID, AV22TFBR_MedicalImagingID_To, AV25TFBR_MedicalImaging_Diag_Loc, AV26TFBR_MedicalImaging_Diag_Loc_Sel, AV29TFBR_MedicalImaging_Diag_Organ, AV30TFBR_MedicalImaging_Diag_Organ_Sel, AV33TFBR_MedicalImaging_Diag_Dis, AV34TFBR_MedicalImaging_Diag_Dis_Sel, AV50TFBR_MedicalImaging_Diag_No, AV51TFBR_MedicalImaging_Diag_No_To, AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace, AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace, AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace, AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace, AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace, AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace, AV70Pgmname, AV47IsAuthorized_Display, AV43IsAuthorized_Update, AV45IsAuthorized_Delete, AV48IsAuthorized_BR_MedicalImaging_Diag_Loc) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV55BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid = AV17TFBR_MedicalImaging_DiagID;
         AV56BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to = AV18TFBR_MedicalImaging_DiagID_To;
         AV57BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid = AV21TFBR_MedicalImagingID;
         AV58BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to = AV22TFBR_MedicalImagingID_To;
         AV59BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc = AV25TFBR_MedicalImaging_Diag_Loc;
         AV60BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel = AV26TFBR_MedicalImaging_Diag_Loc_Sel;
         AV61BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ = AV29TFBR_MedicalImaging_Diag_Organ;
         AV62BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel = AV30TFBR_MedicalImaging_Diag_Organ_Sel;
         AV63BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis = AV33TFBR_MedicalImaging_Diag_Dis;
         AV64BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel = AV34TFBR_MedicalImaging_Diag_Dis_Sel;
         AV65BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no = AV50TFBR_MedicalImaging_Diag_No;
         AV66BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to = AV51TFBR_MedicalImaging_Diag_No_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_MedicalImaging_DiagID, AV18TFBR_MedicalImaging_DiagID_To, AV21TFBR_MedicalImagingID, AV22TFBR_MedicalImagingID_To, AV25TFBR_MedicalImaging_Diag_Loc, AV26TFBR_MedicalImaging_Diag_Loc_Sel, AV29TFBR_MedicalImaging_Diag_Organ, AV30TFBR_MedicalImaging_Diag_Organ_Sel, AV33TFBR_MedicalImaging_Diag_Dis, AV34TFBR_MedicalImaging_Diag_Dis_Sel, AV50TFBR_MedicalImaging_Diag_No, AV51TFBR_MedicalImaging_Diag_No_To, AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace, AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace, AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace, AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace, AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace, AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace, AV70Pgmname, AV47IsAuthorized_Display, AV43IsAuthorized_Update, AV45IsAuthorized_Delete, AV48IsAuthorized_BR_MedicalImaging_Diag_Loc) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV55BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid = AV17TFBR_MedicalImaging_DiagID;
         AV56BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to = AV18TFBR_MedicalImaging_DiagID_To;
         AV57BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid = AV21TFBR_MedicalImagingID;
         AV58BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to = AV22TFBR_MedicalImagingID_To;
         AV59BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc = AV25TFBR_MedicalImaging_Diag_Loc;
         AV60BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel = AV26TFBR_MedicalImaging_Diag_Loc_Sel;
         AV61BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ = AV29TFBR_MedicalImaging_Diag_Organ;
         AV62BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel = AV30TFBR_MedicalImaging_Diag_Organ_Sel;
         AV63BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis = AV33TFBR_MedicalImaging_Diag_Dis;
         AV64BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel = AV34TFBR_MedicalImaging_Diag_Dis_Sel;
         AV65BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no = AV50TFBR_MedicalImaging_Diag_No;
         AV66BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to = AV51TFBR_MedicalImaging_Diag_No_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_MedicalImaging_DiagID, AV18TFBR_MedicalImaging_DiagID_To, AV21TFBR_MedicalImagingID, AV22TFBR_MedicalImagingID_To, AV25TFBR_MedicalImaging_Diag_Loc, AV26TFBR_MedicalImaging_Diag_Loc_Sel, AV29TFBR_MedicalImaging_Diag_Organ, AV30TFBR_MedicalImaging_Diag_Organ_Sel, AV33TFBR_MedicalImaging_Diag_Dis, AV34TFBR_MedicalImaging_Diag_Dis_Sel, AV50TFBR_MedicalImaging_Diag_No, AV51TFBR_MedicalImaging_Diag_No_To, AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace, AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace, AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace, AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace, AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace, AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace, AV70Pgmname, AV47IsAuthorized_Display, AV43IsAuthorized_Update, AV45IsAuthorized_Delete, AV48IsAuthorized_BR_MedicalImaging_Diag_Loc) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV55BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid = AV17TFBR_MedicalImaging_DiagID;
         AV56BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to = AV18TFBR_MedicalImaging_DiagID_To;
         AV57BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid = AV21TFBR_MedicalImagingID;
         AV58BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to = AV22TFBR_MedicalImagingID_To;
         AV59BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc = AV25TFBR_MedicalImaging_Diag_Loc;
         AV60BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel = AV26TFBR_MedicalImaging_Diag_Loc_Sel;
         AV61BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ = AV29TFBR_MedicalImaging_Diag_Organ;
         AV62BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel = AV30TFBR_MedicalImaging_Diag_Organ_Sel;
         AV63BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis = AV33TFBR_MedicalImaging_Diag_Dis;
         AV64BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel = AV34TFBR_MedicalImaging_Diag_Dis_Sel;
         AV65BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no = AV50TFBR_MedicalImaging_Diag_No;
         AV66BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to = AV51TFBR_MedicalImaging_Diag_No_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_MedicalImaging_DiagID, AV18TFBR_MedicalImaging_DiagID_To, AV21TFBR_MedicalImagingID, AV22TFBR_MedicalImagingID_To, AV25TFBR_MedicalImaging_Diag_Loc, AV26TFBR_MedicalImaging_Diag_Loc_Sel, AV29TFBR_MedicalImaging_Diag_Organ, AV30TFBR_MedicalImaging_Diag_Organ_Sel, AV33TFBR_MedicalImaging_Diag_Dis, AV34TFBR_MedicalImaging_Diag_Dis_Sel, AV50TFBR_MedicalImaging_Diag_No, AV51TFBR_MedicalImaging_Diag_No_To, AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace, AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace, AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace, AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace, AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace, AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace, AV70Pgmname, AV47IsAuthorized_Display, AV43IsAuthorized_Update, AV45IsAuthorized_Delete, AV48IsAuthorized_BR_MedicalImaging_Diag_Loc) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP4P0( )
      {
         /* Before Start, stand alone formulas. */
         AV70Pgmname = "BR_MedicalImaging_DiagWW";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E204P2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV36DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICALIMAGING_DIAGIDTITLEFILTERDATA"), AV16BR_MedicalImaging_DiagIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICALIMAGINGIDTITLEFILTERDATA"), AV20BR_MedicalImagingIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICALIMAGING_DIAG_LOCTITLEFILTERDATA"), AV24BR_MedicalImaging_Diag_LocTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICALIMAGING_DIAG_ORGANTITLEFILTERDATA"), AV28BR_MedicalImaging_Diag_OrganTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICALIMAGING_DIAG_DISTITLEFILTERDATA"), AV32BR_MedicalImaging_Diag_DisTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICALIMAGING_DIAG_NOTITLEFILTERDATA"), AV49BR_MedicalImaging_Diag_NoTitleFilterData);
            /* Read variables values. */
            AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_diagidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace", AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace);
            AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace", AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace);
            AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_diag_loctitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace", AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace);
            AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_diag_organtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace", AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace);
            AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_diag_distitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace", AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace);
            AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_diag_notitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace", AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace);
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
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medicalimaging_diagid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medicalimaging_diagid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_MEDICALIMAGING_DIAGID");
               GX_FocusControl = edtavTfbr_medicalimaging_diagid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV17TFBR_MedicalImaging_DiagID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_MedicalImaging_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_MedicalImaging_DiagID), 18, 0)));
            }
            else
            {
               AV17TFBR_MedicalImaging_DiagID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_medicalimaging_diagid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_MedicalImaging_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_MedicalImaging_DiagID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medicalimaging_diagid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medicalimaging_diagid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_MEDICALIMAGING_DIAGID_TO");
               GX_FocusControl = edtavTfbr_medicalimaging_diagid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV18TFBR_MedicalImaging_DiagID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_MedicalImaging_DiagID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_MedicalImaging_DiagID_To), 18, 0)));
            }
            else
            {
               AV18TFBR_MedicalImaging_DiagID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_medicalimaging_diagid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_MedicalImaging_DiagID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_MedicalImaging_DiagID_To), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medicalimagingid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medicalimagingid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_MEDICALIMAGINGID");
               GX_FocusControl = edtavTfbr_medicalimagingid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV21TFBR_MedicalImagingID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_MedicalImagingID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_MedicalImagingID), 18, 0)));
            }
            else
            {
               AV21TFBR_MedicalImagingID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_medicalimagingid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_MedicalImagingID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_MedicalImagingID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medicalimagingid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medicalimagingid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_MEDICALIMAGINGID_TO");
               GX_FocusControl = edtavTfbr_medicalimagingid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV22TFBR_MedicalImagingID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_MedicalImagingID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_MedicalImagingID_To), 18, 0)));
            }
            else
            {
               AV22TFBR_MedicalImagingID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_medicalimagingid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_MedicalImagingID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_MedicalImagingID_To), 18, 0)));
            }
            AV25TFBR_MedicalImaging_Diag_Loc = cgiGet( edtavTfbr_medicalimaging_diag_loc_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_MedicalImaging_Diag_Loc", AV25TFBR_MedicalImaging_Diag_Loc);
            AV26TFBR_MedicalImaging_Diag_Loc_Sel = cgiGet( edtavTfbr_medicalimaging_diag_loc_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_MedicalImaging_Diag_Loc_Sel", AV26TFBR_MedicalImaging_Diag_Loc_Sel);
            AV29TFBR_MedicalImaging_Diag_Organ = cgiGet( edtavTfbr_medicalimaging_diag_organ_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_MedicalImaging_Diag_Organ", AV29TFBR_MedicalImaging_Diag_Organ);
            AV30TFBR_MedicalImaging_Diag_Organ_Sel = cgiGet( edtavTfbr_medicalimaging_diag_organ_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_MedicalImaging_Diag_Organ_Sel", AV30TFBR_MedicalImaging_Diag_Organ_Sel);
            AV33TFBR_MedicalImaging_Diag_Dis = cgiGet( edtavTfbr_medicalimaging_diag_dis_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TFBR_MedicalImaging_Diag_Dis", AV33TFBR_MedicalImaging_Diag_Dis);
            AV34TFBR_MedicalImaging_Diag_Dis_Sel = cgiGet( edtavTfbr_medicalimaging_diag_dis_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFBR_MedicalImaging_Diag_Dis_Sel", AV34TFBR_MedicalImaging_Diag_Dis_Sel);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medicalimaging_diag_no_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medicalimaging_diag_no_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_MEDICALIMAGING_DIAG_NO");
               GX_FocusControl = edtavTfbr_medicalimaging_diag_no_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV50TFBR_MedicalImaging_Diag_No = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV50TFBR_MedicalImaging_Diag_No", StringUtil.LTrim( StringUtil.Str( (decimal)(AV50TFBR_MedicalImaging_Diag_No), 18, 0)));
            }
            else
            {
               AV50TFBR_MedicalImaging_Diag_No = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_medicalimaging_diag_no_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV50TFBR_MedicalImaging_Diag_No", StringUtil.LTrim( StringUtil.Str( (decimal)(AV50TFBR_MedicalImaging_Diag_No), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medicalimaging_diag_no_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medicalimaging_diag_no_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_MEDICALIMAGING_DIAG_NO_TO");
               GX_FocusControl = edtavTfbr_medicalimaging_diag_no_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV51TFBR_MedicalImaging_Diag_No_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51TFBR_MedicalImaging_Diag_No_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV51TFBR_MedicalImaging_Diag_No_To), 18, 0)));
            }
            else
            {
               AV51TFBR_MedicalImaging_Diag_No_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_medicalimaging_diag_no_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51TFBR_MedicalImaging_Diag_No_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV51TFBR_MedicalImaging_Diag_No_To), 18, 0)));
            }
            /* Read saved values. */
            nRC_GXsfl_31 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_31"), ".", ","));
            AV38GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV40GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV39GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_medicalimaging_diagid_Caption = cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Caption");
            Ddo_br_medicalimaging_diagid_Tooltip = cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Tooltip");
            Ddo_br_medicalimaging_diagid_Cls = cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Cls");
            Ddo_br_medicalimaging_diagid_Filteredtext_set = cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Filteredtext_set");
            Ddo_br_medicalimaging_diagid_Filteredtextto_set = cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Filteredtextto_set");
            Ddo_br_medicalimaging_diagid_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Dropdownoptionstype");
            Ddo_br_medicalimaging_diagid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_diagid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Includesortasc"));
            Ddo_br_medicalimaging_diagid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Includesortdsc"));
            Ddo_br_medicalimaging_diagid_Sortedstatus = cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Sortedstatus");
            Ddo_br_medicalimaging_diagid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Includefilter"));
            Ddo_br_medicalimaging_diagid_Filtertype = cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Filtertype");
            Ddo_br_medicalimaging_diagid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Filterisrange"));
            Ddo_br_medicalimaging_diagid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Includedatalist"));
            Ddo_br_medicalimaging_diagid_Sortasc = cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Sortasc");
            Ddo_br_medicalimaging_diagid_Sortdsc = cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Sortdsc");
            Ddo_br_medicalimaging_diagid_Cleanfilter = cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Cleanfilter");
            Ddo_br_medicalimaging_diagid_Rangefilterfrom = cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Rangefilterfrom");
            Ddo_br_medicalimaging_diagid_Rangefilterto = cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Rangefilterto");
            Ddo_br_medicalimaging_diagid_Searchbuttontext = cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Searchbuttontext");
            Ddo_br_medicalimagingid_Caption = cgiGet( "DDO_BR_MEDICALIMAGINGID_Caption");
            Ddo_br_medicalimagingid_Tooltip = cgiGet( "DDO_BR_MEDICALIMAGINGID_Tooltip");
            Ddo_br_medicalimagingid_Cls = cgiGet( "DDO_BR_MEDICALIMAGINGID_Cls");
            Ddo_br_medicalimagingid_Filteredtext_set = cgiGet( "DDO_BR_MEDICALIMAGINGID_Filteredtext_set");
            Ddo_br_medicalimagingid_Filteredtextto_set = cgiGet( "DDO_BR_MEDICALIMAGINGID_Filteredtextto_set");
            Ddo_br_medicalimagingid_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICALIMAGINGID_Dropdownoptionstype");
            Ddo_br_medicalimagingid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICALIMAGINGID_Titlecontrolidtoreplace");
            Ddo_br_medicalimagingid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGINGID_Includesortasc"));
            Ddo_br_medicalimagingid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGINGID_Includesortdsc"));
            Ddo_br_medicalimagingid_Sortedstatus = cgiGet( "DDO_BR_MEDICALIMAGINGID_Sortedstatus");
            Ddo_br_medicalimagingid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGINGID_Includefilter"));
            Ddo_br_medicalimagingid_Filtertype = cgiGet( "DDO_BR_MEDICALIMAGINGID_Filtertype");
            Ddo_br_medicalimagingid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGINGID_Filterisrange"));
            Ddo_br_medicalimagingid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGINGID_Includedatalist"));
            Ddo_br_medicalimagingid_Sortasc = cgiGet( "DDO_BR_MEDICALIMAGINGID_Sortasc");
            Ddo_br_medicalimagingid_Sortdsc = cgiGet( "DDO_BR_MEDICALIMAGINGID_Sortdsc");
            Ddo_br_medicalimagingid_Cleanfilter = cgiGet( "DDO_BR_MEDICALIMAGINGID_Cleanfilter");
            Ddo_br_medicalimagingid_Rangefilterfrom = cgiGet( "DDO_BR_MEDICALIMAGINGID_Rangefilterfrom");
            Ddo_br_medicalimagingid_Rangefilterto = cgiGet( "DDO_BR_MEDICALIMAGINGID_Rangefilterto");
            Ddo_br_medicalimagingid_Searchbuttontext = cgiGet( "DDO_BR_MEDICALIMAGINGID_Searchbuttontext");
            Ddo_br_medicalimaging_diag_loc_Caption = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Caption");
            Ddo_br_medicalimaging_diag_loc_Tooltip = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Tooltip");
            Ddo_br_medicalimaging_diag_loc_Cls = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Cls");
            Ddo_br_medicalimaging_diag_loc_Filteredtext_set = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Filteredtext_set");
            Ddo_br_medicalimaging_diag_loc_Selectedvalue_set = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Selectedvalue_set");
            Ddo_br_medicalimaging_diag_loc_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Dropdownoptionstype");
            Ddo_br_medicalimaging_diag_loc_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_diag_loc_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Includesortasc"));
            Ddo_br_medicalimaging_diag_loc_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Includesortdsc"));
            Ddo_br_medicalimaging_diag_loc_Sortedstatus = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Sortedstatus");
            Ddo_br_medicalimaging_diag_loc_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Includefilter"));
            Ddo_br_medicalimaging_diag_loc_Filtertype = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Filtertype");
            Ddo_br_medicalimaging_diag_loc_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Filterisrange"));
            Ddo_br_medicalimaging_diag_loc_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Includedatalist"));
            Ddo_br_medicalimaging_diag_loc_Datalisttype = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Datalisttype");
            Ddo_br_medicalimaging_diag_loc_Datalistproc = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Datalistproc");
            Ddo_br_medicalimaging_diag_loc_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_medicalimaging_diag_loc_Sortasc = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Sortasc");
            Ddo_br_medicalimaging_diag_loc_Sortdsc = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Sortdsc");
            Ddo_br_medicalimaging_diag_loc_Loadingdata = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Loadingdata");
            Ddo_br_medicalimaging_diag_loc_Cleanfilter = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Cleanfilter");
            Ddo_br_medicalimaging_diag_loc_Noresultsfound = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Noresultsfound");
            Ddo_br_medicalimaging_diag_loc_Searchbuttontext = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Searchbuttontext");
            Ddo_br_medicalimaging_diag_organ_Caption = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Caption");
            Ddo_br_medicalimaging_diag_organ_Tooltip = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Tooltip");
            Ddo_br_medicalimaging_diag_organ_Cls = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Cls");
            Ddo_br_medicalimaging_diag_organ_Filteredtext_set = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Filteredtext_set");
            Ddo_br_medicalimaging_diag_organ_Selectedvalue_set = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Selectedvalue_set");
            Ddo_br_medicalimaging_diag_organ_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Dropdownoptionstype");
            Ddo_br_medicalimaging_diag_organ_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_diag_organ_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Includesortasc"));
            Ddo_br_medicalimaging_diag_organ_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Includesortdsc"));
            Ddo_br_medicalimaging_diag_organ_Sortedstatus = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Sortedstatus");
            Ddo_br_medicalimaging_diag_organ_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Includefilter"));
            Ddo_br_medicalimaging_diag_organ_Filtertype = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Filtertype");
            Ddo_br_medicalimaging_diag_organ_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Filterisrange"));
            Ddo_br_medicalimaging_diag_organ_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Includedatalist"));
            Ddo_br_medicalimaging_diag_organ_Datalisttype = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Datalisttype");
            Ddo_br_medicalimaging_diag_organ_Datalistproc = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Datalistproc");
            Ddo_br_medicalimaging_diag_organ_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_medicalimaging_diag_organ_Sortasc = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Sortasc");
            Ddo_br_medicalimaging_diag_organ_Sortdsc = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Sortdsc");
            Ddo_br_medicalimaging_diag_organ_Loadingdata = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Loadingdata");
            Ddo_br_medicalimaging_diag_organ_Cleanfilter = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Cleanfilter");
            Ddo_br_medicalimaging_diag_organ_Noresultsfound = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Noresultsfound");
            Ddo_br_medicalimaging_diag_organ_Searchbuttontext = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Searchbuttontext");
            Ddo_br_medicalimaging_diag_dis_Caption = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Caption");
            Ddo_br_medicalimaging_diag_dis_Tooltip = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Tooltip");
            Ddo_br_medicalimaging_diag_dis_Cls = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Cls");
            Ddo_br_medicalimaging_diag_dis_Filteredtext_set = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Filteredtext_set");
            Ddo_br_medicalimaging_diag_dis_Selectedvalue_set = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Selectedvalue_set");
            Ddo_br_medicalimaging_diag_dis_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Dropdownoptionstype");
            Ddo_br_medicalimaging_diag_dis_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_diag_dis_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Includesortasc"));
            Ddo_br_medicalimaging_diag_dis_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Includesortdsc"));
            Ddo_br_medicalimaging_diag_dis_Sortedstatus = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Sortedstatus");
            Ddo_br_medicalimaging_diag_dis_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Includefilter"));
            Ddo_br_medicalimaging_diag_dis_Filtertype = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Filtertype");
            Ddo_br_medicalimaging_diag_dis_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Filterisrange"));
            Ddo_br_medicalimaging_diag_dis_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Includedatalist"));
            Ddo_br_medicalimaging_diag_dis_Datalisttype = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Datalisttype");
            Ddo_br_medicalimaging_diag_dis_Datalistproc = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Datalistproc");
            Ddo_br_medicalimaging_diag_dis_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_medicalimaging_diag_dis_Sortasc = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Sortasc");
            Ddo_br_medicalimaging_diag_dis_Sortdsc = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Sortdsc");
            Ddo_br_medicalimaging_diag_dis_Loadingdata = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Loadingdata");
            Ddo_br_medicalimaging_diag_dis_Cleanfilter = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Cleanfilter");
            Ddo_br_medicalimaging_diag_dis_Noresultsfound = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Noresultsfound");
            Ddo_br_medicalimaging_diag_dis_Searchbuttontext = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Searchbuttontext");
            Ddo_br_medicalimaging_diag_no_Caption = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Caption");
            Ddo_br_medicalimaging_diag_no_Tooltip = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Tooltip");
            Ddo_br_medicalimaging_diag_no_Cls = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Cls");
            Ddo_br_medicalimaging_diag_no_Filteredtext_set = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Filteredtext_set");
            Ddo_br_medicalimaging_diag_no_Filteredtextto_set = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Filteredtextto_set");
            Ddo_br_medicalimaging_diag_no_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Dropdownoptionstype");
            Ddo_br_medicalimaging_diag_no_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_diag_no_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Includesortasc"));
            Ddo_br_medicalimaging_diag_no_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Includesortdsc"));
            Ddo_br_medicalimaging_diag_no_Sortedstatus = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Sortedstatus");
            Ddo_br_medicalimaging_diag_no_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Includefilter"));
            Ddo_br_medicalimaging_diag_no_Filtertype = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Filtertype");
            Ddo_br_medicalimaging_diag_no_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Filterisrange"));
            Ddo_br_medicalimaging_diag_no_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Includedatalist"));
            Ddo_br_medicalimaging_diag_no_Sortasc = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Sortasc");
            Ddo_br_medicalimaging_diag_no_Sortdsc = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Sortdsc");
            Ddo_br_medicalimaging_diag_no_Cleanfilter = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Cleanfilter");
            Ddo_br_medicalimaging_diag_no_Rangefilterfrom = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Rangefilterfrom");
            Ddo_br_medicalimaging_diag_no_Rangefilterto = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Rangefilterto");
            Ddo_br_medicalimaging_diag_no_Searchbuttontext = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_medicalimaging_diagid_Activeeventkey = cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Activeeventkey");
            Ddo_br_medicalimaging_diagid_Filteredtext_get = cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Filteredtext_get");
            Ddo_br_medicalimaging_diagid_Filteredtextto_get = cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Filteredtextto_get");
            Ddo_br_medicalimagingid_Activeeventkey = cgiGet( "DDO_BR_MEDICALIMAGINGID_Activeeventkey");
            Ddo_br_medicalimagingid_Filteredtext_get = cgiGet( "DDO_BR_MEDICALIMAGINGID_Filteredtext_get");
            Ddo_br_medicalimagingid_Filteredtextto_get = cgiGet( "DDO_BR_MEDICALIMAGINGID_Filteredtextto_get");
            Ddo_br_medicalimaging_diag_loc_Activeeventkey = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Activeeventkey");
            Ddo_br_medicalimaging_diag_loc_Filteredtext_get = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Filteredtext_get");
            Ddo_br_medicalimaging_diag_loc_Selectedvalue_get = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Selectedvalue_get");
            Ddo_br_medicalimaging_diag_organ_Activeeventkey = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Activeeventkey");
            Ddo_br_medicalimaging_diag_organ_Filteredtext_get = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Filteredtext_get");
            Ddo_br_medicalimaging_diag_organ_Selectedvalue_get = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Selectedvalue_get");
            Ddo_br_medicalimaging_diag_dis_Activeeventkey = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Activeeventkey");
            Ddo_br_medicalimaging_diag_dis_Filteredtext_get = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Filteredtext_get");
            Ddo_br_medicalimaging_diag_dis_Selectedvalue_get = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Selectedvalue_get");
            Ddo_br_medicalimaging_diag_no_Activeeventkey = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Activeeventkey");
            Ddo_br_medicalimaging_diag_no_Filteredtext_get = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Filteredtext_get");
            Ddo_br_medicalimaging_diag_no_Filteredtextto_get = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Filteredtextto_get");
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
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICALIMAGING_DIAGID"), ".", ",") != Convert.ToDecimal( AV17TFBR_MedicalImaging_DiagID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICALIMAGING_DIAGID_TO"), ".", ",") != Convert.ToDecimal( AV18TFBR_MedicalImaging_DiagID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICALIMAGINGID"), ".", ",") != Convert.ToDecimal( AV21TFBR_MedicalImagingID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICALIMAGINGID_TO"), ".", ",") != Convert.ToDecimal( AV22TFBR_MedicalImagingID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICALIMAGING_DIAG_LOC"), AV25TFBR_MedicalImaging_Diag_Loc) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICALIMAGING_DIAG_LOC_SEL"), AV26TFBR_MedicalImaging_Diag_Loc_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICALIMAGING_DIAG_ORGAN"), AV29TFBR_MedicalImaging_Diag_Organ) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICALIMAGING_DIAG_ORGAN_SEL"), AV30TFBR_MedicalImaging_Diag_Organ_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICALIMAGING_DIAG_DIS"), AV33TFBR_MedicalImaging_Diag_Dis) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICALIMAGING_DIAG_DIS_SEL"), AV34TFBR_MedicalImaging_Diag_Dis_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICALIMAGING_DIAG_NO"), ".", ",") != Convert.ToDecimal( AV50TFBR_MedicalImaging_Diag_No )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICALIMAGING_DIAG_NO_TO"), ".", ",") != Convert.ToDecimal( AV51TFBR_MedicalImaging_Diag_No_To )) )
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
         E204P2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E204P2( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GXt_boolean1 = AV48IsAuthorized_BR_MedicalImaging_Diag_Loc;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_MedicalImaging_Diag", out  GXt_boolean1) ;
         AV48IsAuthorized_BR_MedicalImaging_Diag_Loc = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48IsAuthorized_BR_MedicalImaging_Diag_Loc", AV48IsAuthorized_BR_MedicalImaging_Diag_Loc);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC", GetSecureSignedToken( "", AV48IsAuthorized_BR_MedicalImaging_Diag_Loc, context));
         edtavTfbr_medicalimaging_diagid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medicalimaging_diagid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medicalimaging_diagid_Visible), 5, 0)), true);
         edtavTfbr_medicalimaging_diagid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medicalimaging_diagid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medicalimaging_diagid_to_Visible), 5, 0)), true);
         edtavTfbr_medicalimagingid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medicalimagingid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medicalimagingid_Visible), 5, 0)), true);
         edtavTfbr_medicalimagingid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medicalimagingid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medicalimagingid_to_Visible), 5, 0)), true);
         edtavTfbr_medicalimaging_diag_loc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medicalimaging_diag_loc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medicalimaging_diag_loc_Visible), 5, 0)), true);
         edtavTfbr_medicalimaging_diag_loc_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medicalimaging_diag_loc_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medicalimaging_diag_loc_sel_Visible), 5, 0)), true);
         edtavTfbr_medicalimaging_diag_organ_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medicalimaging_diag_organ_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medicalimaging_diag_organ_Visible), 5, 0)), true);
         edtavTfbr_medicalimaging_diag_organ_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medicalimaging_diag_organ_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medicalimaging_diag_organ_sel_Visible), 5, 0)), true);
         edtavTfbr_medicalimaging_diag_dis_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medicalimaging_diag_dis_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medicalimaging_diag_dis_Visible), 5, 0)), true);
         edtavTfbr_medicalimaging_diag_dis_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medicalimaging_diag_dis_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medicalimaging_diag_dis_sel_Visible), 5, 0)), true);
         edtavTfbr_medicalimaging_diag_no_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medicalimaging_diag_no_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medicalimaging_diag_no_Visible), 5, 0)), true);
         edtavTfbr_medicalimaging_diag_no_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medicalimaging_diag_no_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medicalimaging_diag_no_to_Visible), 5, 0)), true);
         Ddo_br_medicalimaging_diagid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_DiagID";
         ucDdo_br_medicalimaging_diagid.SendProperty(context, "", false, Ddo_br_medicalimaging_diagid_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_diagid_Titlecontrolidtoreplace);
         AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace = Ddo_br_medicalimaging_diagid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace", AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_diagidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicalimaging_diagidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_diagidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicalimagingid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImagingID";
         ucDdo_br_medicalimagingid.SendProperty(context, "", false, Ddo_br_medicalimagingid_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimagingid_Titlecontrolidtoreplace);
         AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace = Ddo_br_medicalimagingid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace", AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace);
         edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicalimaging_diag_loc_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_Diag_Loc";
         ucDdo_br_medicalimaging_diag_loc.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_loc_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_diag_loc_Titlecontrolidtoreplace);
         AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace = Ddo_br_medicalimaging_diag_loc_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace", AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_diag_loctitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicalimaging_diag_loctitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_diag_loctitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicalimaging_diag_organ_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_Diag_Organ";
         ucDdo_br_medicalimaging_diag_organ.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_organ_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_diag_organ_Titlecontrolidtoreplace);
         AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace = Ddo_br_medicalimaging_diag_organ_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace", AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_diag_organtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicalimaging_diag_organtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_diag_organtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicalimaging_diag_dis_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_Diag_Dis";
         ucDdo_br_medicalimaging_diag_dis.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_dis_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_diag_dis_Titlecontrolidtoreplace);
         AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace = Ddo_br_medicalimaging_diag_dis_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace", AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_diag_distitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicalimaging_diag_distitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_diag_distitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicalimaging_diag_no_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_Diag_No";
         ucDdo_br_medicalimaging_diag_no.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_no_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_diag_no_Titlecontrolidtoreplace);
         AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace = Ddo_br_medicalimaging_diag_no_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace", AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_diag_notitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicalimaging_diag_notitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_diag_notitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " Data Mgmt Portal - RAAP";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV36DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV36DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E214P2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV16BR_MedicalImaging_DiagIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_MedicalImagingIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_MedicalImaging_Diag_LocTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28BR_MedicalImaging_Diag_OrganTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32BR_MedicalImaging_Diag_DisTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV49BR_MedicalImaging_Diag_NoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
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
         edtBR_MedicalImaging_DiagID_Titleformat = 2;
         edtBR_MedicalImaging_DiagID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "影像学诊断意见主键", AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_DiagID_Internalname, "Title", edtBR_MedicalImaging_DiagID_Title, !bGXsfl_31_Refreshing);
         edtBR_MedicalImagingID_Titleformat = 2;
         edtBR_MedicalImagingID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "影像学主键", AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImagingID_Internalname, "Title", edtBR_MedicalImagingID_Title, !bGXsfl_31_Refreshing);
         edtBR_MedicalImaging_Diag_Loc_Titleformat = 2;
         edtBR_MedicalImaging_Diag_Loc_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "诊断意见(部位)", AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_Diag_Loc_Internalname, "Title", edtBR_MedicalImaging_Diag_Loc_Title, !bGXsfl_31_Refreshing);
         edtBR_MedicalImaging_Diag_Organ_Titleformat = 2;
         edtBR_MedicalImaging_Diag_Organ_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "诊断意见(器官)", AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_Diag_Organ_Internalname, "Title", edtBR_MedicalImaging_Diag_Organ_Title, !bGXsfl_31_Refreshing);
         edtBR_MedicalImaging_Diag_Dis_Titleformat = 2;
         edtBR_MedicalImaging_Diag_Dis_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "诊断意见(疾病)", AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_Diag_Dis_Internalname, "Title", edtBR_MedicalImaging_Diag_Dis_Title, !bGXsfl_31_Refreshing);
         edtBR_MedicalImaging_Diag_No_Titleformat = 2;
         edtBR_MedicalImaging_Diag_No_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "序号", AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_Diag_No_Internalname, "Title", edtBR_MedicalImaging_Diag_No_Title, !bGXsfl_31_Refreshing);
         AV38GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV38GridCurrentPage), 10, 0)));
         AV39GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV39GridPageSize), 10, 0)));
         AV40GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV40GridRecordCount), 10, 0)));
         AV55BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid = AV17TFBR_MedicalImaging_DiagID;
         AV56BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to = AV18TFBR_MedicalImaging_DiagID_To;
         AV57BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid = AV21TFBR_MedicalImagingID;
         AV58BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to = AV22TFBR_MedicalImagingID_To;
         AV59BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc = AV25TFBR_MedicalImaging_Diag_Loc;
         AV60BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel = AV26TFBR_MedicalImaging_Diag_Loc_Sel;
         AV61BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ = AV29TFBR_MedicalImaging_Diag_Organ;
         AV62BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel = AV30TFBR_MedicalImaging_Diag_Organ_Sel;
         AV63BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis = AV33TFBR_MedicalImaging_Diag_Dis;
         AV64BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel = AV34TFBR_MedicalImaging_Diag_Dis_Sel;
         AV65BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no = AV50TFBR_MedicalImaging_Diag_No;
         AV66BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to = AV51TFBR_MedicalImaging_Diag_No_To;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_MedicalImaging_DiagIDTitleFilterData", AV16BR_MedicalImaging_DiagIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_MedicalImagingIDTitleFilterData", AV20BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_MedicalImaging_Diag_LocTitleFilterData", AV24BR_MedicalImaging_Diag_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_MedicalImaging_Diag_OrganTitleFilterData", AV28BR_MedicalImaging_Diag_OrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_MedicalImaging_Diag_DisTitleFilterData", AV32BR_MedicalImaging_Diag_DisTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_MedicalImaging_Diag_NoTitleFilterData", AV49BR_MedicalImaging_Diag_NoTitleFilterData);
      }

      protected void E114P2( )
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
            AV37PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV37PageToGo) ;
         }
      }

      protected void E124P2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E134P2( )
      {
         /* Ddo_br_medicalimaging_diagid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_diagid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_medicalimaging_diagid_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_diagid.SendProperty(context, "", false, Ddo_br_medicalimaging_diagid_Internalname, "SortedStatus", Ddo_br_medicalimaging_diagid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_diagid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_medicalimaging_diagid_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_diagid.SendProperty(context, "", false, Ddo_br_medicalimaging_diagid_Internalname, "SortedStatus", Ddo_br_medicalimaging_diagid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_diagid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV17TFBR_MedicalImaging_DiagID = (long)(NumberUtil.Val( Ddo_br_medicalimaging_diagid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_MedicalImaging_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_MedicalImaging_DiagID), 18, 0)));
            AV18TFBR_MedicalImaging_DiagID_To = (long)(NumberUtil.Val( Ddo_br_medicalimaging_diagid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_MedicalImaging_DiagID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_MedicalImaging_DiagID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_MedicalImaging_DiagIDTitleFilterData", AV16BR_MedicalImaging_DiagIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_MedicalImagingIDTitleFilterData", AV20BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_MedicalImaging_Diag_LocTitleFilterData", AV24BR_MedicalImaging_Diag_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_MedicalImaging_Diag_OrganTitleFilterData", AV28BR_MedicalImaging_Diag_OrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_MedicalImaging_Diag_DisTitleFilterData", AV32BR_MedicalImaging_Diag_DisTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_MedicalImaging_Diag_NoTitleFilterData", AV49BR_MedicalImaging_Diag_NoTitleFilterData);
      }

      protected void E144P2( )
      {
         /* Ddo_br_medicalimagingid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimagingid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_medicalimagingid_Sortedstatus = "ASC";
            ucDdo_br_medicalimagingid.SendProperty(context, "", false, Ddo_br_medicalimagingid_Internalname, "SortedStatus", Ddo_br_medicalimagingid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimagingid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_medicalimagingid_Sortedstatus = "DSC";
            ucDdo_br_medicalimagingid.SendProperty(context, "", false, Ddo_br_medicalimagingid_Internalname, "SortedStatus", Ddo_br_medicalimagingid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimagingid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV21TFBR_MedicalImagingID = (long)(NumberUtil.Val( Ddo_br_medicalimagingid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_MedicalImagingID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_MedicalImagingID), 18, 0)));
            AV22TFBR_MedicalImagingID_To = (long)(NumberUtil.Val( Ddo_br_medicalimagingid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_MedicalImagingID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_MedicalImagingID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_MedicalImaging_DiagIDTitleFilterData", AV16BR_MedicalImaging_DiagIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_MedicalImagingIDTitleFilterData", AV20BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_MedicalImaging_Diag_LocTitleFilterData", AV24BR_MedicalImaging_Diag_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_MedicalImaging_Diag_OrganTitleFilterData", AV28BR_MedicalImaging_Diag_OrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_MedicalImaging_Diag_DisTitleFilterData", AV32BR_MedicalImaging_Diag_DisTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_MedicalImaging_Diag_NoTitleFilterData", AV49BR_MedicalImaging_Diag_NoTitleFilterData);
      }

      protected void E154P2( )
      {
         /* Ddo_br_medicalimaging_diag_loc_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_diag_loc_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_medicalimaging_diag_loc_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_diag_loc.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_loc_Internalname, "SortedStatus", Ddo_br_medicalimaging_diag_loc_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_diag_loc_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_medicalimaging_diag_loc_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_diag_loc.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_loc_Internalname, "SortedStatus", Ddo_br_medicalimaging_diag_loc_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_diag_loc_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV25TFBR_MedicalImaging_Diag_Loc = Ddo_br_medicalimaging_diag_loc_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_MedicalImaging_Diag_Loc", AV25TFBR_MedicalImaging_Diag_Loc);
            AV26TFBR_MedicalImaging_Diag_Loc_Sel = Ddo_br_medicalimaging_diag_loc_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_MedicalImaging_Diag_Loc_Sel", AV26TFBR_MedicalImaging_Diag_Loc_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_MedicalImaging_DiagIDTitleFilterData", AV16BR_MedicalImaging_DiagIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_MedicalImagingIDTitleFilterData", AV20BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_MedicalImaging_Diag_LocTitleFilterData", AV24BR_MedicalImaging_Diag_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_MedicalImaging_Diag_OrganTitleFilterData", AV28BR_MedicalImaging_Diag_OrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_MedicalImaging_Diag_DisTitleFilterData", AV32BR_MedicalImaging_Diag_DisTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_MedicalImaging_Diag_NoTitleFilterData", AV49BR_MedicalImaging_Diag_NoTitleFilterData);
      }

      protected void E164P2( )
      {
         /* Ddo_br_medicalimaging_diag_organ_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_diag_organ_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_medicalimaging_diag_organ_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_diag_organ.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_organ_Internalname, "SortedStatus", Ddo_br_medicalimaging_diag_organ_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_diag_organ_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_medicalimaging_diag_organ_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_diag_organ.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_organ_Internalname, "SortedStatus", Ddo_br_medicalimaging_diag_organ_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_diag_organ_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV29TFBR_MedicalImaging_Diag_Organ = Ddo_br_medicalimaging_diag_organ_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_MedicalImaging_Diag_Organ", AV29TFBR_MedicalImaging_Diag_Organ);
            AV30TFBR_MedicalImaging_Diag_Organ_Sel = Ddo_br_medicalimaging_diag_organ_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_MedicalImaging_Diag_Organ_Sel", AV30TFBR_MedicalImaging_Diag_Organ_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_MedicalImaging_DiagIDTitleFilterData", AV16BR_MedicalImaging_DiagIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_MedicalImagingIDTitleFilterData", AV20BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_MedicalImaging_Diag_LocTitleFilterData", AV24BR_MedicalImaging_Diag_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_MedicalImaging_Diag_OrganTitleFilterData", AV28BR_MedicalImaging_Diag_OrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_MedicalImaging_Diag_DisTitleFilterData", AV32BR_MedicalImaging_Diag_DisTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_MedicalImaging_Diag_NoTitleFilterData", AV49BR_MedicalImaging_Diag_NoTitleFilterData);
      }

      protected void E174P2( )
      {
         /* Ddo_br_medicalimaging_diag_dis_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_diag_dis_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_medicalimaging_diag_dis_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_diag_dis.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_dis_Internalname, "SortedStatus", Ddo_br_medicalimaging_diag_dis_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_diag_dis_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_medicalimaging_diag_dis_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_diag_dis.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_dis_Internalname, "SortedStatus", Ddo_br_medicalimaging_diag_dis_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_diag_dis_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV33TFBR_MedicalImaging_Diag_Dis = Ddo_br_medicalimaging_diag_dis_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TFBR_MedicalImaging_Diag_Dis", AV33TFBR_MedicalImaging_Diag_Dis);
            AV34TFBR_MedicalImaging_Diag_Dis_Sel = Ddo_br_medicalimaging_diag_dis_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFBR_MedicalImaging_Diag_Dis_Sel", AV34TFBR_MedicalImaging_Diag_Dis_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_MedicalImaging_DiagIDTitleFilterData", AV16BR_MedicalImaging_DiagIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_MedicalImagingIDTitleFilterData", AV20BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_MedicalImaging_Diag_LocTitleFilterData", AV24BR_MedicalImaging_Diag_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_MedicalImaging_Diag_OrganTitleFilterData", AV28BR_MedicalImaging_Diag_OrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_MedicalImaging_Diag_DisTitleFilterData", AV32BR_MedicalImaging_Diag_DisTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_MedicalImaging_Diag_NoTitleFilterData", AV49BR_MedicalImaging_Diag_NoTitleFilterData);
      }

      protected void E184P2( )
      {
         /* Ddo_br_medicalimaging_diag_no_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_diag_no_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_medicalimaging_diag_no_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_diag_no.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_no_Internalname, "SortedStatus", Ddo_br_medicalimaging_diag_no_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_diag_no_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_medicalimaging_diag_no_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_diag_no.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_no_Internalname, "SortedStatus", Ddo_br_medicalimaging_diag_no_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_diag_no_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV50TFBR_MedicalImaging_Diag_No = (long)(NumberUtil.Val( Ddo_br_medicalimaging_diag_no_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV50TFBR_MedicalImaging_Diag_No", StringUtil.LTrim( StringUtil.Str( (decimal)(AV50TFBR_MedicalImaging_Diag_No), 18, 0)));
            AV51TFBR_MedicalImaging_Diag_No_To = (long)(NumberUtil.Val( Ddo_br_medicalimaging_diag_no_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51TFBR_MedicalImaging_Diag_No_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV51TFBR_MedicalImaging_Diag_No_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_MedicalImaging_DiagIDTitleFilterData", AV16BR_MedicalImaging_DiagIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_MedicalImagingIDTitleFilterData", AV20BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_MedicalImaging_Diag_LocTitleFilterData", AV24BR_MedicalImaging_Diag_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_MedicalImaging_Diag_OrganTitleFilterData", AV28BR_MedicalImaging_Diag_OrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_MedicalImaging_Diag_DisTitleFilterData", AV32BR_MedicalImaging_Diag_DisTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_MedicalImaging_Diag_NoTitleFilterData", AV49BR_MedicalImaging_Diag_NoTitleFilterData);
      }

      private void E224P2( )
      {
         /* Grid_Load Routine */
         AV41Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDisplay_Internalname, AV41Display);
         AV67Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         if ( AV47IsAuthorized_Display )
         {
            edtavDisplay_Link = formatLink("br_medicalimaging_diagview.aspx") + "?" + UrlEncode("" +A270BR_MedicalImaging_DiagID) + "," + UrlEncode(StringUtil.RTrim(""));
         }
         AV42Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV42Update);
         AV68Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavUpdate_Tooltiptext = "修改";
         if ( AV43IsAuthorized_Update )
         {
            edtavUpdate_Link = formatLink("br_medicalimaging_diag.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A270BR_MedicalImaging_DiagID);
         }
         AV44Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV44Delete);
         AV69Delete_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavDelete_Tooltiptext = "删除";
         if ( AV45IsAuthorized_Delete )
         {
            edtavDelete_Link = formatLink("br_medicalimaging_diag.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A270BR_MedicalImaging_DiagID);
         }
         if ( AV48IsAuthorized_BR_MedicalImaging_Diag_Loc )
         {
            edtBR_MedicalImaging_Diag_Loc_Link = formatLink("br_medicalimaging_diagview.aspx") + "?" + UrlEncode("" +A270BR_MedicalImaging_DiagID) + "," + UrlEncode(StringUtil.RTrim(""));
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

      protected void E194P2( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("br_medicalimaging_diag.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S162( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_br_medicalimaging_diagid_Sortedstatus = "";
         ucDdo_br_medicalimaging_diagid.SendProperty(context, "", false, Ddo_br_medicalimaging_diagid_Internalname, "SortedStatus", Ddo_br_medicalimaging_diagid_Sortedstatus);
         Ddo_br_medicalimagingid_Sortedstatus = "";
         ucDdo_br_medicalimagingid.SendProperty(context, "", false, Ddo_br_medicalimagingid_Internalname, "SortedStatus", Ddo_br_medicalimagingid_Sortedstatus);
         Ddo_br_medicalimaging_diag_loc_Sortedstatus = "";
         ucDdo_br_medicalimaging_diag_loc.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_loc_Internalname, "SortedStatus", Ddo_br_medicalimaging_diag_loc_Sortedstatus);
         Ddo_br_medicalimaging_diag_organ_Sortedstatus = "";
         ucDdo_br_medicalimaging_diag_organ.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_organ_Internalname, "SortedStatus", Ddo_br_medicalimaging_diag_organ_Sortedstatus);
         Ddo_br_medicalimaging_diag_dis_Sortedstatus = "";
         ucDdo_br_medicalimaging_diag_dis.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_dis_Internalname, "SortedStatus", Ddo_br_medicalimaging_diag_dis_Sortedstatus);
         Ddo_br_medicalimaging_diag_no_Sortedstatus = "";
         ucDdo_br_medicalimaging_diag_no.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_no_Internalname, "SortedStatus", Ddo_br_medicalimaging_diag_no_Sortedstatus);
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
            Ddo_br_medicalimaging_diagid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medicalimaging_diagid.SendProperty(context, "", false, Ddo_br_medicalimaging_diagid_Internalname, "SortedStatus", Ddo_br_medicalimaging_diagid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 2 )
         {
            Ddo_br_medicalimagingid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medicalimagingid.SendProperty(context, "", false, Ddo_br_medicalimagingid_Internalname, "SortedStatus", Ddo_br_medicalimagingid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 3 )
         {
            Ddo_br_medicalimaging_diag_loc_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medicalimaging_diag_loc.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_loc_Internalname, "SortedStatus", Ddo_br_medicalimaging_diag_loc_Sortedstatus);
         }
         else if ( AV13OrderedBy == 4 )
         {
            Ddo_br_medicalimaging_diag_organ_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medicalimaging_diag_organ.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_organ_Internalname, "SortedStatus", Ddo_br_medicalimaging_diag_organ_Sortedstatus);
         }
         else if ( AV13OrderedBy == 5 )
         {
            Ddo_br_medicalimaging_diag_dis_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medicalimaging_diag_dis.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_dis_Internalname, "SortedStatus", Ddo_br_medicalimaging_diag_dis_Sortedstatus);
         }
         else if ( AV13OrderedBy == 6 )
         {
            Ddo_br_medicalimaging_diag_no_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medicalimaging_diag_no.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_no_Internalname, "SortedStatus", Ddo_br_medicalimaging_diag_no_Sortedstatus);
         }
      }

      protected void S142( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean1 = AV47IsAuthorized_Display;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_MedicalImaging_Diag", out  GXt_boolean1) ;
         AV47IsAuthorized_Display = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47IsAuthorized_Display", AV47IsAuthorized_Display);
         if ( ! ( AV47IsAuthorized_Display ) )
         {
            edtavDisplay_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDisplay_Visible), 5, 0)), !bGXsfl_31_Refreshing);
         }
         GXt_boolean1 = AV43IsAuthorized_Update;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_MedicalImaging_Diag", out  GXt_boolean1) ;
         AV43IsAuthorized_Update = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43IsAuthorized_Update", AV43IsAuthorized_Update);
         if ( ! ( AV43IsAuthorized_Update ) )
         {
            edtavUpdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_31_Refreshing);
         }
         GXt_boolean1 = AV45IsAuthorized_Delete;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_MedicalImaging_Diag", out  GXt_boolean1) ;
         AV45IsAuthorized_Delete = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45IsAuthorized_Delete", AV45IsAuthorized_Delete);
         if ( ! ( AV45IsAuthorized_Delete ) )
         {
            edtavDelete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Visible), 5, 0)), !bGXsfl_31_Refreshing);
         }
         GXt_boolean1 = AV46TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_MedicalImaging_Diag", out  GXt_boolean1) ;
         AV46TempBoolean = GXt_boolean1;
         if ( ! ( AV46TempBoolean ) )
         {
            bttBtninsert_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtninsert_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtninsert_Visible), 5, 0)), true);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV15Session.Get(AV70Pgmname+"GridState"), "") == 0 )
         {
            AV11GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV70Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV11GridState.FromXml(AV15Session.Get(AV70Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
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
         AV71GXV1 = 1;
         while ( AV71GXV1 <= AV11GridState.gxTpr_Filtervalues.Count )
         {
            AV12GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV11GridState.gxTpr_Filtervalues.Item(AV71GXV1));
            if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICALIMAGING_DIAGID") == 0 )
            {
               AV17TFBR_MedicalImaging_DiagID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_MedicalImaging_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_MedicalImaging_DiagID), 18, 0)));
               AV18TFBR_MedicalImaging_DiagID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_MedicalImaging_DiagID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_MedicalImaging_DiagID_To), 18, 0)));
               if ( ! (0==AV17TFBR_MedicalImaging_DiagID) )
               {
                  Ddo_br_medicalimaging_diagid_Filteredtext_set = StringUtil.Str( (decimal)(AV17TFBR_MedicalImaging_DiagID), 18, 0);
                  ucDdo_br_medicalimaging_diagid.SendProperty(context, "", false, Ddo_br_medicalimaging_diagid_Internalname, "FilteredText_set", Ddo_br_medicalimaging_diagid_Filteredtext_set);
               }
               if ( ! (0==AV18TFBR_MedicalImaging_DiagID_To) )
               {
                  Ddo_br_medicalimaging_diagid_Filteredtextto_set = StringUtil.Str( (decimal)(AV18TFBR_MedicalImaging_DiagID_To), 18, 0);
                  ucDdo_br_medicalimaging_diagid.SendProperty(context, "", false, Ddo_br_medicalimaging_diagid_Internalname, "FilteredTextTo_set", Ddo_br_medicalimaging_diagid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICALIMAGINGID") == 0 )
            {
               AV21TFBR_MedicalImagingID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_MedicalImagingID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_MedicalImagingID), 18, 0)));
               AV22TFBR_MedicalImagingID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_MedicalImagingID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_MedicalImagingID_To), 18, 0)));
               if ( ! (0==AV21TFBR_MedicalImagingID) )
               {
                  Ddo_br_medicalimagingid_Filteredtext_set = StringUtil.Str( (decimal)(AV21TFBR_MedicalImagingID), 18, 0);
                  ucDdo_br_medicalimagingid.SendProperty(context, "", false, Ddo_br_medicalimagingid_Internalname, "FilteredText_set", Ddo_br_medicalimagingid_Filteredtext_set);
               }
               if ( ! (0==AV22TFBR_MedicalImagingID_To) )
               {
                  Ddo_br_medicalimagingid_Filteredtextto_set = StringUtil.Str( (decimal)(AV22TFBR_MedicalImagingID_To), 18, 0);
                  ucDdo_br_medicalimagingid.SendProperty(context, "", false, Ddo_br_medicalimagingid_Internalname, "FilteredTextTo_set", Ddo_br_medicalimagingid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICALIMAGING_DIAG_LOC") == 0 )
            {
               AV25TFBR_MedicalImaging_Diag_Loc = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_MedicalImaging_Diag_Loc", AV25TFBR_MedicalImaging_Diag_Loc);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV25TFBR_MedicalImaging_Diag_Loc)) )
               {
                  Ddo_br_medicalimaging_diag_loc_Filteredtext_set = AV25TFBR_MedicalImaging_Diag_Loc;
                  ucDdo_br_medicalimaging_diag_loc.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_loc_Internalname, "FilteredText_set", Ddo_br_medicalimaging_diag_loc_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICALIMAGING_DIAG_LOC_SEL") == 0 )
            {
               AV26TFBR_MedicalImaging_Diag_Loc_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_MedicalImaging_Diag_Loc_Sel", AV26TFBR_MedicalImaging_Diag_Loc_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26TFBR_MedicalImaging_Diag_Loc_Sel)) )
               {
                  Ddo_br_medicalimaging_diag_loc_Selectedvalue_set = AV26TFBR_MedicalImaging_Diag_Loc_Sel;
                  ucDdo_br_medicalimaging_diag_loc.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_loc_Internalname, "SelectedValue_set", Ddo_br_medicalimaging_diag_loc_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICALIMAGING_DIAG_ORGAN") == 0 )
            {
               AV29TFBR_MedicalImaging_Diag_Organ = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_MedicalImaging_Diag_Organ", AV29TFBR_MedicalImaging_Diag_Organ);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV29TFBR_MedicalImaging_Diag_Organ)) )
               {
                  Ddo_br_medicalimaging_diag_organ_Filteredtext_set = AV29TFBR_MedicalImaging_Diag_Organ;
                  ucDdo_br_medicalimaging_diag_organ.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_organ_Internalname, "FilteredText_set", Ddo_br_medicalimaging_diag_organ_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICALIMAGING_DIAG_ORGAN_SEL") == 0 )
            {
               AV30TFBR_MedicalImaging_Diag_Organ_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_MedicalImaging_Diag_Organ_Sel", AV30TFBR_MedicalImaging_Diag_Organ_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV30TFBR_MedicalImaging_Diag_Organ_Sel)) )
               {
                  Ddo_br_medicalimaging_diag_organ_Selectedvalue_set = AV30TFBR_MedicalImaging_Diag_Organ_Sel;
                  ucDdo_br_medicalimaging_diag_organ.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_organ_Internalname, "SelectedValue_set", Ddo_br_medicalimaging_diag_organ_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICALIMAGING_DIAG_DIS") == 0 )
            {
               AV33TFBR_MedicalImaging_Diag_Dis = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TFBR_MedicalImaging_Diag_Dis", AV33TFBR_MedicalImaging_Diag_Dis);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV33TFBR_MedicalImaging_Diag_Dis)) )
               {
                  Ddo_br_medicalimaging_diag_dis_Filteredtext_set = AV33TFBR_MedicalImaging_Diag_Dis;
                  ucDdo_br_medicalimaging_diag_dis.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_dis_Internalname, "FilteredText_set", Ddo_br_medicalimaging_diag_dis_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICALIMAGING_DIAG_DIS_SEL") == 0 )
            {
               AV34TFBR_MedicalImaging_Diag_Dis_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFBR_MedicalImaging_Diag_Dis_Sel", AV34TFBR_MedicalImaging_Diag_Dis_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV34TFBR_MedicalImaging_Diag_Dis_Sel)) )
               {
                  Ddo_br_medicalimaging_diag_dis_Selectedvalue_set = AV34TFBR_MedicalImaging_Diag_Dis_Sel;
                  ucDdo_br_medicalimaging_diag_dis.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_dis_Internalname, "SelectedValue_set", Ddo_br_medicalimaging_diag_dis_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICALIMAGING_DIAG_NO") == 0 )
            {
               AV50TFBR_MedicalImaging_Diag_No = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV50TFBR_MedicalImaging_Diag_No", StringUtil.LTrim( StringUtil.Str( (decimal)(AV50TFBR_MedicalImaging_Diag_No), 18, 0)));
               AV51TFBR_MedicalImaging_Diag_No_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51TFBR_MedicalImaging_Diag_No_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV51TFBR_MedicalImaging_Diag_No_To), 18, 0)));
               if ( ! (0==AV50TFBR_MedicalImaging_Diag_No) )
               {
                  Ddo_br_medicalimaging_diag_no_Filteredtext_set = StringUtil.Str( (decimal)(AV50TFBR_MedicalImaging_Diag_No), 18, 0);
                  ucDdo_br_medicalimaging_diag_no.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_no_Internalname, "FilteredText_set", Ddo_br_medicalimaging_diag_no_Filteredtext_set);
               }
               if ( ! (0==AV51TFBR_MedicalImaging_Diag_No_To) )
               {
                  Ddo_br_medicalimaging_diag_no_Filteredtextto_set = StringUtil.Str( (decimal)(AV51TFBR_MedicalImaging_Diag_No_To), 18, 0);
                  ucDdo_br_medicalimaging_diag_no.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_no_Internalname, "FilteredTextTo_set", Ddo_br_medicalimaging_diag_no_Filteredtextto_set);
               }
            }
            AV71GXV1 = (int)(AV71GXV1+1);
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
         AV11GridState.FromXml(AV15Session.Get(AV70Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV11GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV11GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV11GridState.gxTpr_Filtervalues.Clear();
         if ( ! ( (0==AV17TFBR_MedicalImaging_DiagID) && (0==AV18TFBR_MedicalImaging_DiagID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICALIMAGING_DIAGID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV17TFBR_MedicalImaging_DiagID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV18TFBR_MedicalImaging_DiagID_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (0==AV21TFBR_MedicalImagingID) && (0==AV22TFBR_MedicalImagingID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICALIMAGINGID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV21TFBR_MedicalImagingID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV22TFBR_MedicalImagingID_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV25TFBR_MedicalImaging_Diag_Loc)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICALIMAGING_DIAG_LOC";
            AV12GridStateFilterValue.gxTpr_Value = AV25TFBR_MedicalImaging_Diag_Loc;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26TFBR_MedicalImaging_Diag_Loc_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICALIMAGING_DIAG_LOC_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV26TFBR_MedicalImaging_Diag_Loc_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV29TFBR_MedicalImaging_Diag_Organ)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICALIMAGING_DIAG_ORGAN";
            AV12GridStateFilterValue.gxTpr_Value = AV29TFBR_MedicalImaging_Diag_Organ;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV30TFBR_MedicalImaging_Diag_Organ_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICALIMAGING_DIAG_ORGAN_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV30TFBR_MedicalImaging_Diag_Organ_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV33TFBR_MedicalImaging_Diag_Dis)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICALIMAGING_DIAG_DIS";
            AV12GridStateFilterValue.gxTpr_Value = AV33TFBR_MedicalImaging_Diag_Dis;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV34TFBR_MedicalImaging_Diag_Dis_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICALIMAGING_DIAG_DIS_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV34TFBR_MedicalImaging_Diag_Dis_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (0==AV50TFBR_MedicalImaging_Diag_No) && (0==AV51TFBR_MedicalImaging_Diag_No_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICALIMAGING_DIAG_NO";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV50TFBR_MedicalImaging_Diag_No), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV51TFBR_MedicalImaging_Diag_No_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         AV11GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV11GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV70Pgmname+"GridState",  AV11GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV70Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_MedicalImaging_Diag";
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
         PA4P2( ) ;
         WS4P2( ) ;
         WE4P2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279423316", true);
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
         context.AddJavascriptSource("br_medicalimaging_diagww.js", "?20202279423317", false);
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
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_312( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_31_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_31_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_31_idx;
         edtBR_MedicalImaging_DiagID_Internalname = "BR_MEDICALIMAGING_DIAGID_"+sGXsfl_31_idx;
         edtBR_MedicalImagingID_Internalname = "BR_MEDICALIMAGINGID_"+sGXsfl_31_idx;
         edtBR_MedicalImaging_Diag_Loc_Internalname = "BR_MEDICALIMAGING_DIAG_LOC_"+sGXsfl_31_idx;
         edtBR_MedicalImaging_Diag_Organ_Internalname = "BR_MEDICALIMAGING_DIAG_ORGAN_"+sGXsfl_31_idx;
         edtBR_MedicalImaging_Diag_Dis_Internalname = "BR_MEDICALIMAGING_DIAG_DIS_"+sGXsfl_31_idx;
         edtBR_MedicalImaging_Diag_No_Internalname = "BR_MEDICALIMAGING_DIAG_NO_"+sGXsfl_31_idx;
      }

      protected void SubsflControlProps_fel_312( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_31_fel_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_31_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_31_fel_idx;
         edtBR_MedicalImaging_DiagID_Internalname = "BR_MEDICALIMAGING_DIAGID_"+sGXsfl_31_fel_idx;
         edtBR_MedicalImagingID_Internalname = "BR_MEDICALIMAGINGID_"+sGXsfl_31_fel_idx;
         edtBR_MedicalImaging_Diag_Loc_Internalname = "BR_MEDICALIMAGING_DIAG_LOC_"+sGXsfl_31_fel_idx;
         edtBR_MedicalImaging_Diag_Organ_Internalname = "BR_MEDICALIMAGING_DIAG_ORGAN_"+sGXsfl_31_fel_idx;
         edtBR_MedicalImaging_Diag_Dis_Internalname = "BR_MEDICALIMAGING_DIAG_DIS_"+sGXsfl_31_fel_idx;
         edtBR_MedicalImaging_Diag_No_Internalname = "BR_MEDICALIMAGING_DIAG_NO_"+sGXsfl_31_fel_idx;
      }

      protected void sendrow_312( )
      {
         SubsflControlProps_312( ) ;
         WB4P0( ) ;
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
            AV41Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV41Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV67Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV41Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV41Display)) ? AV67Display_GXI : context.PathToRelativeUrl( AV41Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavDisplay_Visible,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV41Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV42Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV42Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV68Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV42Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV42Update)) ? AV68Update_GXI : context.PathToRelativeUrl( AV42Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavUpdate_Visible,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV42Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "DeleteAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV44Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV44Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV69Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV44Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV44Delete)) ? AV69Delete_GXI : context.PathToRelativeUrl( AV44Delete));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)edtavDelete_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavDelete_Visible,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV44Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImaging_DiagID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A270BR_MedicalImaging_DiagID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A270BR_MedicalImaging_DiagID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImaging_DiagID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImagingID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A225BR_MedicalImagingID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A225BR_MedicalImagingID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImagingID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImaging_Diag_Loc_Internalname,(String)A271BR_MedicalImaging_Diag_Loc,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtBR_MedicalImaging_Diag_Loc_Link,(String)"",(String)"",(String)"",(String)edtBR_MedicalImaging_Diag_Loc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImaging_Diag_Organ_Internalname,(String)A272BR_MedicalImaging_Diag_Organ,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImaging_Diag_Organ_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImaging_Diag_Dis_Internalname,(String)A273BR_MedicalImaging_Diag_Dis,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImaging_Diag_Dis_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImaging_Diag_No_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A517BR_MedicalImaging_Diag_No), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A517BR_MedicalImaging_Diag_No), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImaging_Diag_No_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            send_integrity_lvl_hashes4P2( ) ;
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
         edtBR_MedicalImaging_DiagID_Internalname = "BR_MEDICALIMAGING_DIAGID";
         edtBR_MedicalImagingID_Internalname = "BR_MEDICALIMAGINGID";
         edtBR_MedicalImaging_Diag_Loc_Internalname = "BR_MEDICALIMAGING_DIAG_LOC";
         edtBR_MedicalImaging_Diag_Organ_Internalname = "BR_MEDICALIMAGING_DIAG_ORGAN";
         edtBR_MedicalImaging_Diag_Dis_Internalname = "BR_MEDICALIMAGING_DIAG_DIS";
         edtBR_MedicalImaging_Diag_No_Internalname = "BR_MEDICALIMAGING_DIAG_NO";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_medicalimaging_diagid_Internalname = "DDO_BR_MEDICALIMAGING_DIAGID";
         edtavDdo_br_medicalimaging_diagidtitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE";
         Ddo_br_medicalimagingid_Internalname = "DDO_BR_MEDICALIMAGINGID";
         edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE";
         Ddo_br_medicalimaging_diag_loc_Internalname = "DDO_BR_MEDICALIMAGING_DIAG_LOC";
         edtavDdo_br_medicalimaging_diag_loctitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE";
         Ddo_br_medicalimaging_diag_organ_Internalname = "DDO_BR_MEDICALIMAGING_DIAG_ORGAN";
         edtavDdo_br_medicalimaging_diag_organtitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE";
         Ddo_br_medicalimaging_diag_dis_Internalname = "DDO_BR_MEDICALIMAGING_DIAG_DIS";
         edtavDdo_br_medicalimaging_diag_distitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE";
         Ddo_br_medicalimaging_diag_no_Internalname = "DDO_BR_MEDICALIMAGING_DIAG_NO";
         edtavDdo_br_medicalimaging_diag_notitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         edtavTfbr_medicalimaging_diagid_Internalname = "vTFBR_MEDICALIMAGING_DIAGID";
         edtavTfbr_medicalimaging_diagid_to_Internalname = "vTFBR_MEDICALIMAGING_DIAGID_TO";
         edtavTfbr_medicalimagingid_Internalname = "vTFBR_MEDICALIMAGINGID";
         edtavTfbr_medicalimagingid_to_Internalname = "vTFBR_MEDICALIMAGINGID_TO";
         edtavTfbr_medicalimaging_diag_loc_Internalname = "vTFBR_MEDICALIMAGING_DIAG_LOC";
         edtavTfbr_medicalimaging_diag_loc_sel_Internalname = "vTFBR_MEDICALIMAGING_DIAG_LOC_SEL";
         edtavTfbr_medicalimaging_diag_organ_Internalname = "vTFBR_MEDICALIMAGING_DIAG_ORGAN";
         edtavTfbr_medicalimaging_diag_organ_sel_Internalname = "vTFBR_MEDICALIMAGING_DIAG_ORGAN_SEL";
         edtavTfbr_medicalimaging_diag_dis_Internalname = "vTFBR_MEDICALIMAGING_DIAG_DIS";
         edtavTfbr_medicalimaging_diag_dis_sel_Internalname = "vTFBR_MEDICALIMAGING_DIAG_DIS_SEL";
         edtavTfbr_medicalimaging_diag_no_Internalname = "vTFBR_MEDICALIMAGING_DIAG_NO";
         edtavTfbr_medicalimaging_diag_no_to_Internalname = "vTFBR_MEDICALIMAGING_DIAG_NO_TO";
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
         edtBR_MedicalImaging_Diag_No_Jsonclick = "";
         edtBR_MedicalImaging_Diag_Dis_Jsonclick = "";
         edtBR_MedicalImaging_Diag_Organ_Jsonclick = "";
         edtBR_MedicalImaging_Diag_Loc_Jsonclick = "";
         edtBR_MedicalImagingID_Jsonclick = "";
         edtBR_MedicalImaging_DiagID_Jsonclick = "";
         edtavTfbr_medicalimaging_diag_no_to_Jsonclick = "";
         edtavTfbr_medicalimaging_diag_no_to_Visible = 1;
         edtavTfbr_medicalimaging_diag_no_Jsonclick = "";
         edtavTfbr_medicalimaging_diag_no_Visible = 1;
         edtavTfbr_medicalimaging_diag_dis_sel_Jsonclick = "";
         edtavTfbr_medicalimaging_diag_dis_sel_Visible = 1;
         edtavTfbr_medicalimaging_diag_dis_Jsonclick = "";
         edtavTfbr_medicalimaging_diag_dis_Visible = 1;
         edtavTfbr_medicalimaging_diag_organ_sel_Jsonclick = "";
         edtavTfbr_medicalimaging_diag_organ_sel_Visible = 1;
         edtavTfbr_medicalimaging_diag_organ_Jsonclick = "";
         edtavTfbr_medicalimaging_diag_organ_Visible = 1;
         edtavTfbr_medicalimaging_diag_loc_sel_Jsonclick = "";
         edtavTfbr_medicalimaging_diag_loc_sel_Visible = 1;
         edtavTfbr_medicalimaging_diag_loc_Jsonclick = "";
         edtavTfbr_medicalimaging_diag_loc_Visible = 1;
         edtavTfbr_medicalimagingid_to_Jsonclick = "";
         edtavTfbr_medicalimagingid_to_Visible = 1;
         edtavTfbr_medicalimagingid_Jsonclick = "";
         edtavTfbr_medicalimagingid_Visible = 1;
         edtavTfbr_medicalimaging_diagid_to_Jsonclick = "";
         edtavTfbr_medicalimaging_diagid_to_Visible = 1;
         edtavTfbr_medicalimaging_diagid_Jsonclick = "";
         edtavTfbr_medicalimaging_diagid_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_medicalimaging_diag_notitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medicalimaging_diag_distitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medicalimaging_diag_organtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medicalimaging_diag_loctitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medicalimaging_diagidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtBR_MedicalImaging_Diag_Loc_Link = "";
         edtavDelete_Tooltiptext = "删除";
         edtavDelete_Link = "";
         edtavUpdate_Tooltiptext = "修改";
         edtavUpdate_Link = "";
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_MedicalImaging_Diag_No_Titleformat = 0;
         edtBR_MedicalImaging_Diag_No_Title = "序号";
         edtBR_MedicalImaging_Diag_Dis_Titleformat = 0;
         edtBR_MedicalImaging_Diag_Dis_Title = "诊断意见(疾病)";
         edtBR_MedicalImaging_Diag_Organ_Titleformat = 0;
         edtBR_MedicalImaging_Diag_Organ_Title = "诊断意见(器官)";
         edtBR_MedicalImaging_Diag_Loc_Titleformat = 0;
         edtBR_MedicalImaging_Diag_Loc_Title = "诊断意见(部位)";
         edtBR_MedicalImagingID_Titleformat = 0;
         edtBR_MedicalImagingID_Title = "影像学主键";
         edtBR_MedicalImaging_DiagID_Titleformat = 0;
         edtBR_MedicalImaging_DiagID_Title = "影像学诊断意见主键";
         edtavDelete_Visible = -1;
         edtavUpdate_Visible = -1;
         edtavDisplay_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         bttBtninsert_Visible = 1;
         Ddo_br_medicalimaging_diag_no_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_diag_no_Rangefilterto = "WWP_TSTo";
         Ddo_br_medicalimaging_diag_no_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_medicalimaging_diag_no_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_medicalimaging_diag_no_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_diag_no_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_diag_no_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_diag_no_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_diag_no_Filtertype = "Numeric";
         Ddo_br_medicalimaging_diag_no_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_diag_no_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_diag_no_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_diag_no_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimaging_diag_no_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimaging_diag_no_Cls = "ColumnSettings";
         Ddo_br_medicalimaging_diag_no_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimaging_diag_no_Caption = "";
         Ddo_br_medicalimaging_diag_dis_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_diag_dis_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_medicalimaging_diag_dis_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_medicalimaging_diag_dis_Loadingdata = "WWP_TSLoading";
         Ddo_br_medicalimaging_diag_dis_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_diag_dis_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_diag_dis_Datalistupdateminimumcharacters = 0;
         Ddo_br_medicalimaging_diag_dis_Datalistproc = "BR_MedicalImaging_DiagWWGetFilterData";
         Ddo_br_medicalimaging_diag_dis_Datalisttype = "Dynamic";
         Ddo_br_medicalimaging_diag_dis_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_diag_dis_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_diag_dis_Filtertype = "Character";
         Ddo_br_medicalimaging_diag_dis_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_diag_dis_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_diag_dis_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_diag_dis_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimaging_diag_dis_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimaging_diag_dis_Cls = "ColumnSettings";
         Ddo_br_medicalimaging_diag_dis_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimaging_diag_dis_Caption = "";
         Ddo_br_medicalimaging_diag_organ_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_diag_organ_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_medicalimaging_diag_organ_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_medicalimaging_diag_organ_Loadingdata = "WWP_TSLoading";
         Ddo_br_medicalimaging_diag_organ_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_diag_organ_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_diag_organ_Datalistupdateminimumcharacters = 0;
         Ddo_br_medicalimaging_diag_organ_Datalistproc = "BR_MedicalImaging_DiagWWGetFilterData";
         Ddo_br_medicalimaging_diag_organ_Datalisttype = "Dynamic";
         Ddo_br_medicalimaging_diag_organ_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_diag_organ_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_diag_organ_Filtertype = "Character";
         Ddo_br_medicalimaging_diag_organ_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_diag_organ_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_diag_organ_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_diag_organ_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimaging_diag_organ_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimaging_diag_organ_Cls = "ColumnSettings";
         Ddo_br_medicalimaging_diag_organ_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimaging_diag_organ_Caption = "";
         Ddo_br_medicalimaging_diag_loc_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_diag_loc_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_medicalimaging_diag_loc_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_medicalimaging_diag_loc_Loadingdata = "WWP_TSLoading";
         Ddo_br_medicalimaging_diag_loc_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_diag_loc_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_diag_loc_Datalistupdateminimumcharacters = 0;
         Ddo_br_medicalimaging_diag_loc_Datalistproc = "BR_MedicalImaging_DiagWWGetFilterData";
         Ddo_br_medicalimaging_diag_loc_Datalisttype = "Dynamic";
         Ddo_br_medicalimaging_diag_loc_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_diag_loc_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_diag_loc_Filtertype = "Character";
         Ddo_br_medicalimaging_diag_loc_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_diag_loc_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_diag_loc_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_diag_loc_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimaging_diag_loc_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimaging_diag_loc_Cls = "ColumnSettings";
         Ddo_br_medicalimaging_diag_loc_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimaging_diag_loc_Caption = "";
         Ddo_br_medicalimagingid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimagingid_Rangefilterto = "WWP_TSTo";
         Ddo_br_medicalimagingid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_medicalimagingid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_medicalimagingid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimagingid_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimagingid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimagingid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_medicalimagingid_Filtertype = "Numeric";
         Ddo_br_medicalimagingid_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_medicalimagingid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimagingid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimagingid_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimagingid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimagingid_Cls = "ColumnSettings";
         Ddo_br_medicalimagingid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimagingid_Caption = "";
         Ddo_br_medicalimaging_diagid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_diagid_Rangefilterto = "WWP_TSTo";
         Ddo_br_medicalimaging_diagid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_medicalimaging_diagid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_medicalimaging_diagid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_diagid_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_diagid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_diagid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_diagid_Filtertype = "Numeric";
         Ddo_br_medicalimaging_diagid_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_diagid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_diagid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_diagid_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimaging_diagid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimaging_diagid_Cls = "ColumnSettings";
         Ddo_br_medicalimaging_diagid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimaging_diagid_Caption = "";
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
         Form.Caption = " 影像学诊断意见";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV17TFBR_MedicalImaging_DiagID',fld:'vTFBR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_MedicalImaging_DiagID_To',fld:'vTFBR_MEDICALIMAGING_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicalImagingID',fld:'vTFBR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicalImagingID_To',fld:'vTFBR_MEDICALIMAGINGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicalImaging_Diag_Loc',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC',pic:''},{av:'AV26TFBR_MedicalImaging_Diag_Loc_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_MedicalImaging_Diag_Organ',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN',pic:''},{av:'AV30TFBR_MedicalImaging_Diag_Organ_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_MedicalImaging_Diag_Dis',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS',pic:''},{av:'AV34TFBR_MedicalImaging_Diag_Dis_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS_SEL',pic:''},{av:'AV50TFBR_MedicalImaging_Diag_No',fld:'vTFBR_MEDICALIMAGING_DIAG_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV51TFBR_MedicalImaging_Diag_No_To',fld:'vTFBR_MEDICALIMAGING_DIAG_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48IsAuthorized_BR_MedicalImaging_Diag_Loc',fld:'vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV16BR_MedicalImaging_DiagIDTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV20BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV24BR_MedicalImaging_Diag_LocTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_MedicalImaging_Diag_OrganTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV32BR_MedicalImaging_Diag_DisTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_DISTITLEFILTERDATA',pic:''},{av:'AV49BR_MedicalImaging_Diag_NoTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_NOTITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImaging_DiagID_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_DiagID_Title',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Title'},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Loc_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Loc_Title',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Organ_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Organ_Title',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Dis_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Dis_Title',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_No_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_No_Title',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E114P2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_MedicalImaging_DiagID',fld:'vTFBR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_MedicalImaging_DiagID_To',fld:'vTFBR_MEDICALIMAGING_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicalImagingID',fld:'vTFBR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicalImagingID_To',fld:'vTFBR_MEDICALIMAGINGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicalImaging_Diag_Loc',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC',pic:''},{av:'AV26TFBR_MedicalImaging_Diag_Loc_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_MedicalImaging_Diag_Organ',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN',pic:''},{av:'AV30TFBR_MedicalImaging_Diag_Organ_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_MedicalImaging_Diag_Dis',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS',pic:''},{av:'AV34TFBR_MedicalImaging_Diag_Dis_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS_SEL',pic:''},{av:'AV50TFBR_MedicalImaging_Diag_No',fld:'vTFBR_MEDICALIMAGING_DIAG_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV51TFBR_MedicalImaging_Diag_No_To',fld:'vTFBR_MEDICALIMAGING_DIAG_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV48IsAuthorized_BR_MedicalImaging_Diag_Loc',fld:'vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC',pic:'',hsh:true},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E124P2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_MedicalImaging_DiagID',fld:'vTFBR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_MedicalImaging_DiagID_To',fld:'vTFBR_MEDICALIMAGING_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicalImagingID',fld:'vTFBR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicalImagingID_To',fld:'vTFBR_MEDICALIMAGINGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicalImaging_Diag_Loc',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC',pic:''},{av:'AV26TFBR_MedicalImaging_Diag_Loc_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_MedicalImaging_Diag_Organ',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN',pic:''},{av:'AV30TFBR_MedicalImaging_Diag_Organ_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_MedicalImaging_Diag_Dis',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS',pic:''},{av:'AV34TFBR_MedicalImaging_Diag_Dis_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS_SEL',pic:''},{av:'AV50TFBR_MedicalImaging_Diag_No',fld:'vTFBR_MEDICALIMAGING_DIAG_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV51TFBR_MedicalImaging_Diag_No_To',fld:'vTFBR_MEDICALIMAGING_DIAG_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV48IsAuthorized_BR_MedicalImaging_Diag_Loc',fld:'vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC',pic:'',hsh:true},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_DIAGID.ONOPTIONCLICKED","{handler:'E134P2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_MedicalImaging_DiagID',fld:'vTFBR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_MedicalImaging_DiagID_To',fld:'vTFBR_MEDICALIMAGING_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicalImagingID',fld:'vTFBR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicalImagingID_To',fld:'vTFBR_MEDICALIMAGINGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicalImaging_Diag_Loc',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC',pic:''},{av:'AV26TFBR_MedicalImaging_Diag_Loc_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_MedicalImaging_Diag_Organ',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN',pic:''},{av:'AV30TFBR_MedicalImaging_Diag_Organ_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_MedicalImaging_Diag_Dis',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS',pic:''},{av:'AV34TFBR_MedicalImaging_Diag_Dis_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS_SEL',pic:''},{av:'AV50TFBR_MedicalImaging_Diag_No',fld:'vTFBR_MEDICALIMAGING_DIAG_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV51TFBR_MedicalImaging_Diag_No_To',fld:'vTFBR_MEDICALIMAGING_DIAG_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV48IsAuthorized_BR_MedicalImaging_Diag_Loc',fld:'vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC',pic:'',hsh:true},{av:'Ddo_br_medicalimaging_diagid_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_DIAGID',prop:'ActiveEventKey'},{av:'Ddo_br_medicalimaging_diagid_Filteredtext_get',ctrl:'DDO_BR_MEDICALIMAGING_DIAGID',prop:'FilteredText_get'},{av:'Ddo_br_medicalimaging_diagid_Filteredtextto_get',ctrl:'DDO_BR_MEDICALIMAGING_DIAGID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_DIAGID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_diagid_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAGID',prop:'SortedStatus'},{av:'AV17TFBR_MedicalImaging_DiagID',fld:'vTFBR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_MedicalImaging_DiagID_To',fld:'vTFBR_MEDICALIMAGING_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_medicalimagingid_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGINGID',prop:'SortedStatus'},{av:'Ddo_br_medicalimaging_diag_loc_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_LOC',prop:'SortedStatus'},{av:'Ddo_br_medicalimaging_diag_organ_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_ORGAN',prop:'SortedStatus'},{av:'Ddo_br_medicalimaging_diag_dis_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_DIS',prop:'SortedStatus'},{av:'Ddo_br_medicalimaging_diag_no_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_NO',prop:'SortedStatus'},{av:'AV16BR_MedicalImaging_DiagIDTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV20BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV24BR_MedicalImaging_Diag_LocTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_MedicalImaging_Diag_OrganTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV32BR_MedicalImaging_Diag_DisTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_DISTITLEFILTERDATA',pic:''},{av:'AV49BR_MedicalImaging_Diag_NoTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_NOTITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImaging_DiagID_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_DiagID_Title',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Title'},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Loc_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Loc_Title',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Organ_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Organ_Title',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Dis_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Dis_Title',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_No_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_No_Title',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGINGID.ONOPTIONCLICKED","{handler:'E144P2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_MedicalImaging_DiagID',fld:'vTFBR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_MedicalImaging_DiagID_To',fld:'vTFBR_MEDICALIMAGING_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicalImagingID',fld:'vTFBR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicalImagingID_To',fld:'vTFBR_MEDICALIMAGINGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicalImaging_Diag_Loc',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC',pic:''},{av:'AV26TFBR_MedicalImaging_Diag_Loc_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_MedicalImaging_Diag_Organ',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN',pic:''},{av:'AV30TFBR_MedicalImaging_Diag_Organ_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_MedicalImaging_Diag_Dis',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS',pic:''},{av:'AV34TFBR_MedicalImaging_Diag_Dis_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS_SEL',pic:''},{av:'AV50TFBR_MedicalImaging_Diag_No',fld:'vTFBR_MEDICALIMAGING_DIAG_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV51TFBR_MedicalImaging_Diag_No_To',fld:'vTFBR_MEDICALIMAGING_DIAG_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV48IsAuthorized_BR_MedicalImaging_Diag_Loc',fld:'vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC',pic:'',hsh:true},{av:'Ddo_br_medicalimagingid_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGINGID',prop:'ActiveEventKey'},{av:'Ddo_br_medicalimagingid_Filteredtext_get',ctrl:'DDO_BR_MEDICALIMAGINGID',prop:'FilteredText_get'},{av:'Ddo_br_medicalimagingid_Filteredtextto_get',ctrl:'DDO_BR_MEDICALIMAGINGID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGINGID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimagingid_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGINGID',prop:'SortedStatus'},{av:'AV21TFBR_MedicalImagingID',fld:'vTFBR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicalImagingID_To',fld:'vTFBR_MEDICALIMAGINGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_medicalimaging_diagid_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAGID',prop:'SortedStatus'},{av:'Ddo_br_medicalimaging_diag_loc_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_LOC',prop:'SortedStatus'},{av:'Ddo_br_medicalimaging_diag_organ_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_ORGAN',prop:'SortedStatus'},{av:'Ddo_br_medicalimaging_diag_dis_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_DIS',prop:'SortedStatus'},{av:'Ddo_br_medicalimaging_diag_no_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_NO',prop:'SortedStatus'},{av:'AV16BR_MedicalImaging_DiagIDTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV20BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV24BR_MedicalImaging_Diag_LocTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_MedicalImaging_Diag_OrganTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV32BR_MedicalImaging_Diag_DisTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_DISTITLEFILTERDATA',pic:''},{av:'AV49BR_MedicalImaging_Diag_NoTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_NOTITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImaging_DiagID_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_DiagID_Title',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Title'},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Loc_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Loc_Title',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Organ_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Organ_Title',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Dis_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Dis_Title',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_No_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_No_Title',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_DIAG_LOC.ONOPTIONCLICKED","{handler:'E154P2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_MedicalImaging_DiagID',fld:'vTFBR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_MedicalImaging_DiagID_To',fld:'vTFBR_MEDICALIMAGING_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicalImagingID',fld:'vTFBR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicalImagingID_To',fld:'vTFBR_MEDICALIMAGINGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicalImaging_Diag_Loc',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC',pic:''},{av:'AV26TFBR_MedicalImaging_Diag_Loc_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_MedicalImaging_Diag_Organ',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN',pic:''},{av:'AV30TFBR_MedicalImaging_Diag_Organ_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_MedicalImaging_Diag_Dis',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS',pic:''},{av:'AV34TFBR_MedicalImaging_Diag_Dis_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS_SEL',pic:''},{av:'AV50TFBR_MedicalImaging_Diag_No',fld:'vTFBR_MEDICALIMAGING_DIAG_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV51TFBR_MedicalImaging_Diag_No_To',fld:'vTFBR_MEDICALIMAGING_DIAG_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV48IsAuthorized_BR_MedicalImaging_Diag_Loc',fld:'vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC',pic:'',hsh:true},{av:'Ddo_br_medicalimaging_diag_loc_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_LOC',prop:'ActiveEventKey'},{av:'Ddo_br_medicalimaging_diag_loc_Filteredtext_get',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_LOC',prop:'FilteredText_get'},{av:'Ddo_br_medicalimaging_diag_loc_Selectedvalue_get',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_LOC',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_DIAG_LOC.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_diag_loc_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_LOC',prop:'SortedStatus'},{av:'AV25TFBR_MedicalImaging_Diag_Loc',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC',pic:''},{av:'AV26TFBR_MedicalImaging_Diag_Loc_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC_SEL',pic:''},{av:'Ddo_br_medicalimaging_diagid_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAGID',prop:'SortedStatus'},{av:'Ddo_br_medicalimagingid_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGINGID',prop:'SortedStatus'},{av:'Ddo_br_medicalimaging_diag_organ_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_ORGAN',prop:'SortedStatus'},{av:'Ddo_br_medicalimaging_diag_dis_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_DIS',prop:'SortedStatus'},{av:'Ddo_br_medicalimaging_diag_no_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_NO',prop:'SortedStatus'},{av:'AV16BR_MedicalImaging_DiagIDTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV20BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV24BR_MedicalImaging_Diag_LocTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_MedicalImaging_Diag_OrganTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV32BR_MedicalImaging_Diag_DisTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_DISTITLEFILTERDATA',pic:''},{av:'AV49BR_MedicalImaging_Diag_NoTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_NOTITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImaging_DiagID_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_DiagID_Title',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Title'},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Loc_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Loc_Title',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Organ_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Organ_Title',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Dis_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Dis_Title',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_No_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_No_Title',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_DIAG_ORGAN.ONOPTIONCLICKED","{handler:'E164P2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_MedicalImaging_DiagID',fld:'vTFBR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_MedicalImaging_DiagID_To',fld:'vTFBR_MEDICALIMAGING_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicalImagingID',fld:'vTFBR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicalImagingID_To',fld:'vTFBR_MEDICALIMAGINGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicalImaging_Diag_Loc',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC',pic:''},{av:'AV26TFBR_MedicalImaging_Diag_Loc_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_MedicalImaging_Diag_Organ',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN',pic:''},{av:'AV30TFBR_MedicalImaging_Diag_Organ_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_MedicalImaging_Diag_Dis',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS',pic:''},{av:'AV34TFBR_MedicalImaging_Diag_Dis_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS_SEL',pic:''},{av:'AV50TFBR_MedicalImaging_Diag_No',fld:'vTFBR_MEDICALIMAGING_DIAG_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV51TFBR_MedicalImaging_Diag_No_To',fld:'vTFBR_MEDICALIMAGING_DIAG_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV48IsAuthorized_BR_MedicalImaging_Diag_Loc',fld:'vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC',pic:'',hsh:true},{av:'Ddo_br_medicalimaging_diag_organ_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_ORGAN',prop:'ActiveEventKey'},{av:'Ddo_br_medicalimaging_diag_organ_Filteredtext_get',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_ORGAN',prop:'FilteredText_get'},{av:'Ddo_br_medicalimaging_diag_organ_Selectedvalue_get',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_ORGAN',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_DIAG_ORGAN.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_diag_organ_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_ORGAN',prop:'SortedStatus'},{av:'AV29TFBR_MedicalImaging_Diag_Organ',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN',pic:''},{av:'AV30TFBR_MedicalImaging_Diag_Organ_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN_SEL',pic:''},{av:'Ddo_br_medicalimaging_diagid_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAGID',prop:'SortedStatus'},{av:'Ddo_br_medicalimagingid_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGINGID',prop:'SortedStatus'},{av:'Ddo_br_medicalimaging_diag_loc_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_LOC',prop:'SortedStatus'},{av:'Ddo_br_medicalimaging_diag_dis_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_DIS',prop:'SortedStatus'},{av:'Ddo_br_medicalimaging_diag_no_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_NO',prop:'SortedStatus'},{av:'AV16BR_MedicalImaging_DiagIDTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV20BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV24BR_MedicalImaging_Diag_LocTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_MedicalImaging_Diag_OrganTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV32BR_MedicalImaging_Diag_DisTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_DISTITLEFILTERDATA',pic:''},{av:'AV49BR_MedicalImaging_Diag_NoTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_NOTITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImaging_DiagID_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_DiagID_Title',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Title'},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Loc_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Loc_Title',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Organ_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Organ_Title',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Dis_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Dis_Title',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_No_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_No_Title',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_DIAG_DIS.ONOPTIONCLICKED","{handler:'E174P2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_MedicalImaging_DiagID',fld:'vTFBR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_MedicalImaging_DiagID_To',fld:'vTFBR_MEDICALIMAGING_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicalImagingID',fld:'vTFBR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicalImagingID_To',fld:'vTFBR_MEDICALIMAGINGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicalImaging_Diag_Loc',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC',pic:''},{av:'AV26TFBR_MedicalImaging_Diag_Loc_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_MedicalImaging_Diag_Organ',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN',pic:''},{av:'AV30TFBR_MedicalImaging_Diag_Organ_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_MedicalImaging_Diag_Dis',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS',pic:''},{av:'AV34TFBR_MedicalImaging_Diag_Dis_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS_SEL',pic:''},{av:'AV50TFBR_MedicalImaging_Diag_No',fld:'vTFBR_MEDICALIMAGING_DIAG_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV51TFBR_MedicalImaging_Diag_No_To',fld:'vTFBR_MEDICALIMAGING_DIAG_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV48IsAuthorized_BR_MedicalImaging_Diag_Loc',fld:'vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC',pic:'',hsh:true},{av:'Ddo_br_medicalimaging_diag_dis_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_DIS',prop:'ActiveEventKey'},{av:'Ddo_br_medicalimaging_diag_dis_Filteredtext_get',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_DIS',prop:'FilteredText_get'},{av:'Ddo_br_medicalimaging_diag_dis_Selectedvalue_get',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_DIS',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_DIAG_DIS.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_diag_dis_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_DIS',prop:'SortedStatus'},{av:'AV33TFBR_MedicalImaging_Diag_Dis',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS',pic:''},{av:'AV34TFBR_MedicalImaging_Diag_Dis_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS_SEL',pic:''},{av:'Ddo_br_medicalimaging_diagid_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAGID',prop:'SortedStatus'},{av:'Ddo_br_medicalimagingid_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGINGID',prop:'SortedStatus'},{av:'Ddo_br_medicalimaging_diag_loc_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_LOC',prop:'SortedStatus'},{av:'Ddo_br_medicalimaging_diag_organ_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_ORGAN',prop:'SortedStatus'},{av:'Ddo_br_medicalimaging_diag_no_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_NO',prop:'SortedStatus'},{av:'AV16BR_MedicalImaging_DiagIDTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV20BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV24BR_MedicalImaging_Diag_LocTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_MedicalImaging_Diag_OrganTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV32BR_MedicalImaging_Diag_DisTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_DISTITLEFILTERDATA',pic:''},{av:'AV49BR_MedicalImaging_Diag_NoTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_NOTITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImaging_DiagID_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_DiagID_Title',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Title'},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Loc_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Loc_Title',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Organ_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Organ_Title',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Dis_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Dis_Title',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_No_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_No_Title',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_DIAG_NO.ONOPTIONCLICKED","{handler:'E184P2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_MedicalImaging_DiagID',fld:'vTFBR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_MedicalImaging_DiagID_To',fld:'vTFBR_MEDICALIMAGING_DIAGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_MedicalImagingID',fld:'vTFBR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_MedicalImagingID_To',fld:'vTFBR_MEDICALIMAGINGID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_MedicalImaging_Diag_Loc',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC',pic:''},{av:'AV26TFBR_MedicalImaging_Diag_Loc_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_LOC_SEL',pic:''},{av:'AV29TFBR_MedicalImaging_Diag_Organ',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN',pic:''},{av:'AV30TFBR_MedicalImaging_Diag_Organ_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_ORGAN_SEL',pic:''},{av:'AV33TFBR_MedicalImaging_Diag_Dis',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS',pic:''},{av:'AV34TFBR_MedicalImaging_Diag_Dis_Sel',fld:'vTFBR_MEDICALIMAGING_DIAG_DIS_SEL',pic:''},{av:'AV50TFBR_MedicalImaging_Diag_No',fld:'vTFBR_MEDICALIMAGING_DIAG_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV51TFBR_MedicalImaging_Diag_No_To',fld:'vTFBR_MEDICALIMAGING_DIAG_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV48IsAuthorized_BR_MedicalImaging_Diag_Loc',fld:'vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC',pic:'',hsh:true},{av:'Ddo_br_medicalimaging_diag_no_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_NO',prop:'ActiveEventKey'},{av:'Ddo_br_medicalimaging_diag_no_Filteredtext_get',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_NO',prop:'FilteredText_get'},{av:'Ddo_br_medicalimaging_diag_no_Filteredtextto_get',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_NO',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_DIAG_NO.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_diag_no_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_NO',prop:'SortedStatus'},{av:'AV50TFBR_MedicalImaging_Diag_No',fld:'vTFBR_MEDICALIMAGING_DIAG_NO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV51TFBR_MedicalImaging_Diag_No_To',fld:'vTFBR_MEDICALIMAGING_DIAG_NO_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_medicalimaging_diagid_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAGID',prop:'SortedStatus'},{av:'Ddo_br_medicalimagingid_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGINGID',prop:'SortedStatus'},{av:'Ddo_br_medicalimaging_diag_loc_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_LOC',prop:'SortedStatus'},{av:'Ddo_br_medicalimaging_diag_organ_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_ORGAN',prop:'SortedStatus'},{av:'Ddo_br_medicalimaging_diag_dis_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_DIS',prop:'SortedStatus'},{av:'AV16BR_MedicalImaging_DiagIDTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV20BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV24BR_MedicalImaging_Diag_LocTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV28BR_MedicalImaging_Diag_OrganTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV32BR_MedicalImaging_Diag_DisTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_DISTITLEFILTERDATA',pic:''},{av:'AV49BR_MedicalImaging_Diag_NoTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_NOTITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImaging_DiagID_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_DiagID_Title',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Title'},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Loc_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Loc_Title',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Organ_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Organ_Title',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Dis_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Dis_Title',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_No_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_No_Title',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E224P2',iparms:[{av:'AV47IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'A270BR_MedicalImaging_DiagID',fld:'BR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV43IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV45IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV48IsAuthorized_BR_MedicalImaging_Diag_Loc',fld:'vISAUTHORIZED_BR_MEDICALIMAGING_DIAG_LOC',pic:'',hsh:true}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV41Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'},{av:'AV42Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV44Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'},{av:'edtBR_MedicalImaging_Diag_Loc_Link',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E194P2',iparms:[{av:'A270BR_MedicalImaging_DiagID',fld:'BR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
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
         Ddo_br_medicalimaging_diagid_Activeeventkey = "";
         Ddo_br_medicalimaging_diagid_Filteredtext_get = "";
         Ddo_br_medicalimaging_diagid_Filteredtextto_get = "";
         Ddo_br_medicalimagingid_Activeeventkey = "";
         Ddo_br_medicalimagingid_Filteredtext_get = "";
         Ddo_br_medicalimagingid_Filteredtextto_get = "";
         Ddo_br_medicalimaging_diag_loc_Activeeventkey = "";
         Ddo_br_medicalimaging_diag_loc_Filteredtext_get = "";
         Ddo_br_medicalimaging_diag_loc_Selectedvalue_get = "";
         Ddo_br_medicalimaging_diag_organ_Activeeventkey = "";
         Ddo_br_medicalimaging_diag_organ_Filteredtext_get = "";
         Ddo_br_medicalimaging_diag_organ_Selectedvalue_get = "";
         Ddo_br_medicalimaging_diag_dis_Activeeventkey = "";
         Ddo_br_medicalimaging_diag_dis_Filteredtext_get = "";
         Ddo_br_medicalimaging_diag_dis_Selectedvalue_get = "";
         Ddo_br_medicalimaging_diag_no_Activeeventkey = "";
         Ddo_br_medicalimaging_diag_no_Filteredtext_get = "";
         Ddo_br_medicalimaging_diag_no_Filteredtextto_get = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV25TFBR_MedicalImaging_Diag_Loc = "";
         AV26TFBR_MedicalImaging_Diag_Loc_Sel = "";
         AV29TFBR_MedicalImaging_Diag_Organ = "";
         AV30TFBR_MedicalImaging_Diag_Organ_Sel = "";
         AV33TFBR_MedicalImaging_Diag_Dis = "";
         AV34TFBR_MedicalImaging_Diag_Dis_Sel = "";
         AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace = "";
         AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace = "";
         AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace = "";
         AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace = "";
         AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace = "";
         AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace = "";
         AV70Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV36DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV16BR_MedicalImaging_DiagIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_MedicalImagingIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_MedicalImaging_Diag_LocTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28BR_MedicalImaging_Diag_OrganTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32BR_MedicalImaging_Diag_DisTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV49BR_MedicalImaging_Diag_NoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_medicalimaging_diagid_Filteredtext_set = "";
         Ddo_br_medicalimaging_diagid_Filteredtextto_set = "";
         Ddo_br_medicalimaging_diagid_Sortedstatus = "";
         Ddo_br_medicalimagingid_Filteredtext_set = "";
         Ddo_br_medicalimagingid_Filteredtextto_set = "";
         Ddo_br_medicalimagingid_Sortedstatus = "";
         Ddo_br_medicalimaging_diag_loc_Filteredtext_set = "";
         Ddo_br_medicalimaging_diag_loc_Selectedvalue_set = "";
         Ddo_br_medicalimaging_diag_loc_Sortedstatus = "";
         Ddo_br_medicalimaging_diag_organ_Filteredtext_set = "";
         Ddo_br_medicalimaging_diag_organ_Selectedvalue_set = "";
         Ddo_br_medicalimaging_diag_organ_Sortedstatus = "";
         Ddo_br_medicalimaging_diag_dis_Filteredtext_set = "";
         Ddo_br_medicalimaging_diag_dis_Selectedvalue_set = "";
         Ddo_br_medicalimaging_diag_dis_Sortedstatus = "";
         Ddo_br_medicalimaging_diag_no_Filteredtext_set = "";
         Ddo_br_medicalimaging_diag_no_Filteredtextto_set = "";
         Ddo_br_medicalimaging_diag_no_Sortedstatus = "";
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
         AV41Display = "";
         AV42Update = "";
         AV44Delete = "";
         A271BR_MedicalImaging_Diag_Loc = "";
         A272BR_MedicalImaging_Diag_Organ = "";
         A273BR_MedicalImaging_Diag_Dis = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_medicalimaging_diagid = new GXUserControl();
         ucDdo_br_medicalimagingid = new GXUserControl();
         ucDdo_br_medicalimaging_diag_loc = new GXUserControl();
         ucDdo_br_medicalimaging_diag_organ = new GXUserControl();
         ucDdo_br_medicalimaging_diag_dis = new GXUserControl();
         ucDdo_br_medicalimaging_diag_no = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV67Display_GXI = "";
         AV68Update_GXI = "";
         AV69Delete_GXI = "";
         scmdbuf = "";
         lV59BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc = "";
         lV61BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ = "";
         lV63BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis = "";
         AV60BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel = "";
         AV59BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc = "";
         AV62BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel = "";
         AV61BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ = "";
         AV64BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel = "";
         AV63BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis = "";
         H004P2_A517BR_MedicalImaging_Diag_No = new long[1] ;
         H004P2_n517BR_MedicalImaging_Diag_No = new bool[] {false} ;
         H004P2_A273BR_MedicalImaging_Diag_Dis = new String[] {""} ;
         H004P2_n273BR_MedicalImaging_Diag_Dis = new bool[] {false} ;
         H004P2_A272BR_MedicalImaging_Diag_Organ = new String[] {""} ;
         H004P2_n272BR_MedicalImaging_Diag_Organ = new bool[] {false} ;
         H004P2_A271BR_MedicalImaging_Diag_Loc = new String[] {""} ;
         H004P2_n271BR_MedicalImaging_Diag_Loc = new bool[] {false} ;
         H004P2_A225BR_MedicalImagingID = new long[1] ;
         H004P2_n225BR_MedicalImagingID = new bool[] {false} ;
         H004P2_A270BR_MedicalImaging_DiagID = new long[1] ;
         H004P3_AGRID_nRecordCount = new long[1] ;
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_medicalimaging_diagww__default(),
            new Object[][] {
                new Object[] {
               H004P2_A517BR_MedicalImaging_Diag_No, H004P2_n517BR_MedicalImaging_Diag_No, H004P2_A273BR_MedicalImaging_Diag_Dis, H004P2_n273BR_MedicalImaging_Diag_Dis, H004P2_A272BR_MedicalImaging_Diag_Organ, H004P2_n272BR_MedicalImaging_Diag_Organ, H004P2_A271BR_MedicalImaging_Diag_Loc, H004P2_n271BR_MedicalImaging_Diag_Loc, H004P2_A225BR_MedicalImagingID, H004P2_n225BR_MedicalImagingID,
               H004P2_A270BR_MedicalImaging_DiagID
               }
               , new Object[] {
               H004P3_AGRID_nRecordCount
               }
            }
         );
         AV70Pgmname = "BR_MedicalImaging_DiagWW";
         /* GeneXus formulas. */
         AV70Pgmname = "BR_MedicalImaging_DiagWW";
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
      private short edtBR_MedicalImaging_DiagID_Titleformat ;
      private short edtBR_MedicalImagingID_Titleformat ;
      private short edtBR_MedicalImaging_Diag_Loc_Titleformat ;
      private short edtBR_MedicalImaging_Diag_Organ_Titleformat ;
      private short edtBR_MedicalImaging_Diag_Dis_Titleformat ;
      private short edtBR_MedicalImaging_Diag_No_Titleformat ;
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
      private int Ddo_br_medicalimaging_diag_loc_Datalistupdateminimumcharacters ;
      private int Ddo_br_medicalimaging_diag_organ_Datalistupdateminimumcharacters ;
      private int Ddo_br_medicalimaging_diag_dis_Datalistupdateminimumcharacters ;
      private int bttBtninsert_Visible ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavDisplay_Visible ;
      private int edtavUpdate_Visible ;
      private int edtavDelete_Visible ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_br_medicalimaging_diagidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medicalimaging_diag_loctitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medicalimaging_diag_organtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medicalimaging_diag_distitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medicalimaging_diag_notitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfbr_medicalimaging_diagid_Visible ;
      private int edtavTfbr_medicalimaging_diagid_to_Visible ;
      private int edtavTfbr_medicalimagingid_Visible ;
      private int edtavTfbr_medicalimagingid_to_Visible ;
      private int edtavTfbr_medicalimaging_diag_loc_Visible ;
      private int edtavTfbr_medicalimaging_diag_loc_sel_Visible ;
      private int edtavTfbr_medicalimaging_diag_organ_Visible ;
      private int edtavTfbr_medicalimaging_diag_organ_sel_Visible ;
      private int edtavTfbr_medicalimaging_diag_dis_Visible ;
      private int edtavTfbr_medicalimaging_diag_dis_sel_Visible ;
      private int edtavTfbr_medicalimaging_diag_no_Visible ;
      private int edtavTfbr_medicalimaging_diag_no_to_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV37PageToGo ;
      private int AV71GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV17TFBR_MedicalImaging_DiagID ;
      private long AV18TFBR_MedicalImaging_DiagID_To ;
      private long AV21TFBR_MedicalImagingID ;
      private long AV22TFBR_MedicalImagingID_To ;
      private long AV50TFBR_MedicalImaging_Diag_No ;
      private long AV51TFBR_MedicalImaging_Diag_No_To ;
      private long AV38GridCurrentPage ;
      private long AV40GridRecordCount ;
      private long AV39GridPageSize ;
      private long A270BR_MedicalImaging_DiagID ;
      private long A225BR_MedicalImagingID ;
      private long A517BR_MedicalImaging_Diag_No ;
      private long GRID_nCurrentRecord ;
      private long AV55BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid ;
      private long AV56BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to ;
      private long AV57BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid ;
      private long AV58BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to ;
      private long AV65BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no ;
      private long AV66BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_medicalimaging_diagid_Activeeventkey ;
      private String Ddo_br_medicalimaging_diagid_Filteredtext_get ;
      private String Ddo_br_medicalimaging_diagid_Filteredtextto_get ;
      private String Ddo_br_medicalimagingid_Activeeventkey ;
      private String Ddo_br_medicalimagingid_Filteredtext_get ;
      private String Ddo_br_medicalimagingid_Filteredtextto_get ;
      private String Ddo_br_medicalimaging_diag_loc_Activeeventkey ;
      private String Ddo_br_medicalimaging_diag_loc_Filteredtext_get ;
      private String Ddo_br_medicalimaging_diag_loc_Selectedvalue_get ;
      private String Ddo_br_medicalimaging_diag_organ_Activeeventkey ;
      private String Ddo_br_medicalimaging_diag_organ_Filteredtext_get ;
      private String Ddo_br_medicalimaging_diag_organ_Selectedvalue_get ;
      private String Ddo_br_medicalimaging_diag_dis_Activeeventkey ;
      private String Ddo_br_medicalimaging_diag_dis_Filteredtext_get ;
      private String Ddo_br_medicalimaging_diag_dis_Selectedvalue_get ;
      private String Ddo_br_medicalimaging_diag_no_Activeeventkey ;
      private String Ddo_br_medicalimaging_diag_no_Filteredtext_get ;
      private String Ddo_br_medicalimaging_diag_no_Filteredtextto_get ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_31_idx="0001" ;
      private String AV70Pgmname ;
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
      private String Ddo_br_medicalimaging_diagid_Caption ;
      private String Ddo_br_medicalimaging_diagid_Tooltip ;
      private String Ddo_br_medicalimaging_diagid_Cls ;
      private String Ddo_br_medicalimaging_diagid_Filteredtext_set ;
      private String Ddo_br_medicalimaging_diagid_Filteredtextto_set ;
      private String Ddo_br_medicalimaging_diagid_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_diagid_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_diagid_Sortedstatus ;
      private String Ddo_br_medicalimaging_diagid_Filtertype ;
      private String Ddo_br_medicalimaging_diagid_Sortasc ;
      private String Ddo_br_medicalimaging_diagid_Sortdsc ;
      private String Ddo_br_medicalimaging_diagid_Cleanfilter ;
      private String Ddo_br_medicalimaging_diagid_Rangefilterfrom ;
      private String Ddo_br_medicalimaging_diagid_Rangefilterto ;
      private String Ddo_br_medicalimaging_diagid_Searchbuttontext ;
      private String Ddo_br_medicalimagingid_Caption ;
      private String Ddo_br_medicalimagingid_Tooltip ;
      private String Ddo_br_medicalimagingid_Cls ;
      private String Ddo_br_medicalimagingid_Filteredtext_set ;
      private String Ddo_br_medicalimagingid_Filteredtextto_set ;
      private String Ddo_br_medicalimagingid_Dropdownoptionstype ;
      private String Ddo_br_medicalimagingid_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimagingid_Sortedstatus ;
      private String Ddo_br_medicalimagingid_Filtertype ;
      private String Ddo_br_medicalimagingid_Sortasc ;
      private String Ddo_br_medicalimagingid_Sortdsc ;
      private String Ddo_br_medicalimagingid_Cleanfilter ;
      private String Ddo_br_medicalimagingid_Rangefilterfrom ;
      private String Ddo_br_medicalimagingid_Rangefilterto ;
      private String Ddo_br_medicalimagingid_Searchbuttontext ;
      private String Ddo_br_medicalimaging_diag_loc_Caption ;
      private String Ddo_br_medicalimaging_diag_loc_Tooltip ;
      private String Ddo_br_medicalimaging_diag_loc_Cls ;
      private String Ddo_br_medicalimaging_diag_loc_Filteredtext_set ;
      private String Ddo_br_medicalimaging_diag_loc_Selectedvalue_set ;
      private String Ddo_br_medicalimaging_diag_loc_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_diag_loc_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_diag_loc_Sortedstatus ;
      private String Ddo_br_medicalimaging_diag_loc_Filtertype ;
      private String Ddo_br_medicalimaging_diag_loc_Datalisttype ;
      private String Ddo_br_medicalimaging_diag_loc_Datalistproc ;
      private String Ddo_br_medicalimaging_diag_loc_Sortasc ;
      private String Ddo_br_medicalimaging_diag_loc_Sortdsc ;
      private String Ddo_br_medicalimaging_diag_loc_Loadingdata ;
      private String Ddo_br_medicalimaging_diag_loc_Cleanfilter ;
      private String Ddo_br_medicalimaging_diag_loc_Noresultsfound ;
      private String Ddo_br_medicalimaging_diag_loc_Searchbuttontext ;
      private String Ddo_br_medicalimaging_diag_organ_Caption ;
      private String Ddo_br_medicalimaging_diag_organ_Tooltip ;
      private String Ddo_br_medicalimaging_diag_organ_Cls ;
      private String Ddo_br_medicalimaging_diag_organ_Filteredtext_set ;
      private String Ddo_br_medicalimaging_diag_organ_Selectedvalue_set ;
      private String Ddo_br_medicalimaging_diag_organ_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_diag_organ_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_diag_organ_Sortedstatus ;
      private String Ddo_br_medicalimaging_diag_organ_Filtertype ;
      private String Ddo_br_medicalimaging_diag_organ_Datalisttype ;
      private String Ddo_br_medicalimaging_diag_organ_Datalistproc ;
      private String Ddo_br_medicalimaging_diag_organ_Sortasc ;
      private String Ddo_br_medicalimaging_diag_organ_Sortdsc ;
      private String Ddo_br_medicalimaging_diag_organ_Loadingdata ;
      private String Ddo_br_medicalimaging_diag_organ_Cleanfilter ;
      private String Ddo_br_medicalimaging_diag_organ_Noresultsfound ;
      private String Ddo_br_medicalimaging_diag_organ_Searchbuttontext ;
      private String Ddo_br_medicalimaging_diag_dis_Caption ;
      private String Ddo_br_medicalimaging_diag_dis_Tooltip ;
      private String Ddo_br_medicalimaging_diag_dis_Cls ;
      private String Ddo_br_medicalimaging_diag_dis_Filteredtext_set ;
      private String Ddo_br_medicalimaging_diag_dis_Selectedvalue_set ;
      private String Ddo_br_medicalimaging_diag_dis_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_diag_dis_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_diag_dis_Sortedstatus ;
      private String Ddo_br_medicalimaging_diag_dis_Filtertype ;
      private String Ddo_br_medicalimaging_diag_dis_Datalisttype ;
      private String Ddo_br_medicalimaging_diag_dis_Datalistproc ;
      private String Ddo_br_medicalimaging_diag_dis_Sortasc ;
      private String Ddo_br_medicalimaging_diag_dis_Sortdsc ;
      private String Ddo_br_medicalimaging_diag_dis_Loadingdata ;
      private String Ddo_br_medicalimaging_diag_dis_Cleanfilter ;
      private String Ddo_br_medicalimaging_diag_dis_Noresultsfound ;
      private String Ddo_br_medicalimaging_diag_dis_Searchbuttontext ;
      private String Ddo_br_medicalimaging_diag_no_Caption ;
      private String Ddo_br_medicalimaging_diag_no_Tooltip ;
      private String Ddo_br_medicalimaging_diag_no_Cls ;
      private String Ddo_br_medicalimaging_diag_no_Filteredtext_set ;
      private String Ddo_br_medicalimaging_diag_no_Filteredtextto_set ;
      private String Ddo_br_medicalimaging_diag_no_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_diag_no_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_diag_no_Sortedstatus ;
      private String Ddo_br_medicalimaging_diag_no_Filtertype ;
      private String Ddo_br_medicalimaging_diag_no_Sortasc ;
      private String Ddo_br_medicalimaging_diag_no_Sortdsc ;
      private String Ddo_br_medicalimaging_diag_no_Cleanfilter ;
      private String Ddo_br_medicalimaging_diag_no_Rangefilterfrom ;
      private String Ddo_br_medicalimaging_diag_no_Rangefilterto ;
      private String Ddo_br_medicalimaging_diag_no_Searchbuttontext ;
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
      private String edtBR_MedicalImaging_DiagID_Title ;
      private String edtBR_MedicalImagingID_Title ;
      private String edtBR_MedicalImaging_Diag_Loc_Title ;
      private String edtBR_MedicalImaging_Diag_Organ_Title ;
      private String edtBR_MedicalImaging_Diag_Dis_Title ;
      private String edtBR_MedicalImaging_Diag_No_Title ;
      private String subGrid_Header ;
      private String edtavDisplay_Link ;
      private String edtavDisplay_Tooltiptext ;
      private String edtavUpdate_Link ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavDelete_Link ;
      private String edtavDelete_Tooltiptext ;
      private String edtBR_MedicalImaging_Diag_Loc_Link ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_medicalimaging_diagid_Internalname ;
      private String edtavDdo_br_medicalimaging_diagidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medicalimagingid_Internalname ;
      private String edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medicalimaging_diag_loc_Internalname ;
      private String edtavDdo_br_medicalimaging_diag_loctitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medicalimaging_diag_organ_Internalname ;
      private String edtavDdo_br_medicalimaging_diag_organtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medicalimaging_diag_dis_Internalname ;
      private String edtavDdo_br_medicalimaging_diag_distitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medicalimaging_diag_no_Internalname ;
      private String edtavDdo_br_medicalimaging_diag_notitlecontrolidtoreplace_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavTfbr_medicalimaging_diagid_Internalname ;
      private String edtavTfbr_medicalimaging_diagid_Jsonclick ;
      private String edtavTfbr_medicalimaging_diagid_to_Internalname ;
      private String edtavTfbr_medicalimaging_diagid_to_Jsonclick ;
      private String edtavTfbr_medicalimagingid_Internalname ;
      private String edtavTfbr_medicalimagingid_Jsonclick ;
      private String edtavTfbr_medicalimagingid_to_Internalname ;
      private String edtavTfbr_medicalimagingid_to_Jsonclick ;
      private String edtavTfbr_medicalimaging_diag_loc_Internalname ;
      private String edtavTfbr_medicalimaging_diag_loc_Jsonclick ;
      private String edtavTfbr_medicalimaging_diag_loc_sel_Internalname ;
      private String edtavTfbr_medicalimaging_diag_loc_sel_Jsonclick ;
      private String edtavTfbr_medicalimaging_diag_organ_Internalname ;
      private String edtavTfbr_medicalimaging_diag_organ_Jsonclick ;
      private String edtavTfbr_medicalimaging_diag_organ_sel_Internalname ;
      private String edtavTfbr_medicalimaging_diag_organ_sel_Jsonclick ;
      private String edtavTfbr_medicalimaging_diag_dis_Internalname ;
      private String edtavTfbr_medicalimaging_diag_dis_Jsonclick ;
      private String edtavTfbr_medicalimaging_diag_dis_sel_Internalname ;
      private String edtavTfbr_medicalimaging_diag_dis_sel_Jsonclick ;
      private String edtavTfbr_medicalimaging_diag_no_Internalname ;
      private String edtavTfbr_medicalimaging_diag_no_Jsonclick ;
      private String edtavTfbr_medicalimaging_diag_no_to_Internalname ;
      private String edtavTfbr_medicalimaging_diag_no_to_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDisplay_Internalname ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String edtBR_MedicalImaging_DiagID_Internalname ;
      private String edtBR_MedicalImagingID_Internalname ;
      private String edtBR_MedicalImaging_Diag_Loc_Internalname ;
      private String edtBR_MedicalImaging_Diag_Organ_Internalname ;
      private String edtBR_MedicalImaging_Diag_Dis_Internalname ;
      private String edtBR_MedicalImaging_Diag_No_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_31_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtBR_MedicalImaging_DiagID_Jsonclick ;
      private String edtBR_MedicalImagingID_Jsonclick ;
      private String edtBR_MedicalImaging_Diag_Loc_Jsonclick ;
      private String edtBR_MedicalImaging_Diag_Organ_Jsonclick ;
      private String edtBR_MedicalImaging_Diag_Dis_Jsonclick ;
      private String edtBR_MedicalImaging_Diag_No_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV14OrderedDsc ;
      private bool AV47IsAuthorized_Display ;
      private bool AV43IsAuthorized_Update ;
      private bool AV45IsAuthorized_Delete ;
      private bool AV48IsAuthorized_BR_MedicalImaging_Diag_Loc ;
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
      private bool Ddo_br_medicalimaging_diagid_Includesortasc ;
      private bool Ddo_br_medicalimaging_diagid_Includesortdsc ;
      private bool Ddo_br_medicalimaging_diagid_Includefilter ;
      private bool Ddo_br_medicalimaging_diagid_Filterisrange ;
      private bool Ddo_br_medicalimaging_diagid_Includedatalist ;
      private bool Ddo_br_medicalimagingid_Includesortasc ;
      private bool Ddo_br_medicalimagingid_Includesortdsc ;
      private bool Ddo_br_medicalimagingid_Includefilter ;
      private bool Ddo_br_medicalimagingid_Filterisrange ;
      private bool Ddo_br_medicalimagingid_Includedatalist ;
      private bool Ddo_br_medicalimaging_diag_loc_Includesortasc ;
      private bool Ddo_br_medicalimaging_diag_loc_Includesortdsc ;
      private bool Ddo_br_medicalimaging_diag_loc_Includefilter ;
      private bool Ddo_br_medicalimaging_diag_loc_Filterisrange ;
      private bool Ddo_br_medicalimaging_diag_loc_Includedatalist ;
      private bool Ddo_br_medicalimaging_diag_organ_Includesortasc ;
      private bool Ddo_br_medicalimaging_diag_organ_Includesortdsc ;
      private bool Ddo_br_medicalimaging_diag_organ_Includefilter ;
      private bool Ddo_br_medicalimaging_diag_organ_Filterisrange ;
      private bool Ddo_br_medicalimaging_diag_organ_Includedatalist ;
      private bool Ddo_br_medicalimaging_diag_dis_Includesortasc ;
      private bool Ddo_br_medicalimaging_diag_dis_Includesortdsc ;
      private bool Ddo_br_medicalimaging_diag_dis_Includefilter ;
      private bool Ddo_br_medicalimaging_diag_dis_Filterisrange ;
      private bool Ddo_br_medicalimaging_diag_dis_Includedatalist ;
      private bool Ddo_br_medicalimaging_diag_no_Includesortasc ;
      private bool Ddo_br_medicalimaging_diag_no_Includesortdsc ;
      private bool Ddo_br_medicalimaging_diag_no_Includefilter ;
      private bool Ddo_br_medicalimaging_diag_no_Filterisrange ;
      private bool Ddo_br_medicalimaging_diag_no_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_31_Refreshing=false ;
      private bool n225BR_MedicalImagingID ;
      private bool n271BR_MedicalImaging_Diag_Loc ;
      private bool n272BR_MedicalImaging_Diag_Organ ;
      private bool n273BR_MedicalImaging_Diag_Dis ;
      private bool n517BR_MedicalImaging_Diag_No ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV46TempBoolean ;
      private bool GXt_boolean1 ;
      private bool AV41Display_IsBlob ;
      private bool AV42Update_IsBlob ;
      private bool AV44Delete_IsBlob ;
      private String AV25TFBR_MedicalImaging_Diag_Loc ;
      private String AV26TFBR_MedicalImaging_Diag_Loc_Sel ;
      private String AV29TFBR_MedicalImaging_Diag_Organ ;
      private String AV30TFBR_MedicalImaging_Diag_Organ_Sel ;
      private String AV33TFBR_MedicalImaging_Diag_Dis ;
      private String AV34TFBR_MedicalImaging_Diag_Dis_Sel ;
      private String AV19ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace ;
      private String AV23ddo_BR_MedicalImagingIDTitleControlIdToReplace ;
      private String AV27ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace ;
      private String AV31ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace ;
      private String AV35ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace ;
      private String AV52ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace ;
      private String A271BR_MedicalImaging_Diag_Loc ;
      private String A272BR_MedicalImaging_Diag_Organ ;
      private String A273BR_MedicalImaging_Diag_Dis ;
      private String AV67Display_GXI ;
      private String AV68Update_GXI ;
      private String AV69Delete_GXI ;
      private String lV59BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc ;
      private String lV61BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ ;
      private String lV63BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis ;
      private String AV60BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel ;
      private String AV59BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc ;
      private String AV62BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel ;
      private String AV61BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ ;
      private String AV64BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel ;
      private String AV63BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis ;
      private String AV41Display ;
      private String AV42Update ;
      private String AV44Delete ;
      private IGxSession AV15Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_medicalimaging_diagid ;
      private GXUserControl ucDdo_br_medicalimagingid ;
      private GXUserControl ucDdo_br_medicalimaging_diag_loc ;
      private GXUserControl ucDdo_br_medicalimaging_diag_organ ;
      private GXUserControl ucDdo_br_medicalimaging_diag_dis ;
      private GXUserControl ucDdo_br_medicalimaging_diag_no ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] H004P2_A517BR_MedicalImaging_Diag_No ;
      private bool[] H004P2_n517BR_MedicalImaging_Diag_No ;
      private String[] H004P2_A273BR_MedicalImaging_Diag_Dis ;
      private bool[] H004P2_n273BR_MedicalImaging_Diag_Dis ;
      private String[] H004P2_A272BR_MedicalImaging_Diag_Organ ;
      private bool[] H004P2_n272BR_MedicalImaging_Diag_Organ ;
      private String[] H004P2_A271BR_MedicalImaging_Diag_Loc ;
      private bool[] H004P2_n271BR_MedicalImaging_Diag_Loc ;
      private long[] H004P2_A225BR_MedicalImagingID ;
      private bool[] H004P2_n225BR_MedicalImagingID ;
      private long[] H004P2_A270BR_MedicalImaging_DiagID ;
      private long[] H004P3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV16BR_MedicalImaging_DiagIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV20BR_MedicalImagingIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV24BR_MedicalImaging_Diag_LocTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV28BR_MedicalImaging_Diag_OrganTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV32BR_MedicalImaging_Diag_DisTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV49BR_MedicalImaging_Diag_NoTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV11GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV12GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV36DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class br_medicalimaging_diagww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H004P2( IGxContext context ,
                                             long AV55BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid ,
                                             long AV56BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to ,
                                             long AV57BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid ,
                                             long AV58BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to ,
                                             String AV60BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel ,
                                             String AV59BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc ,
                                             String AV62BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel ,
                                             String AV61BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ ,
                                             String AV64BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel ,
                                             String AV63BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis ,
                                             long AV65BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no ,
                                             long AV66BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to ,
                                             long A270BR_MedicalImaging_DiagID ,
                                             long A225BR_MedicalImagingID ,
                                             String A271BR_MedicalImaging_Diag_Loc ,
                                             String A272BR_MedicalImaging_Diag_Organ ,
                                             String A273BR_MedicalImaging_Diag_Dis ,
                                             long A517BR_MedicalImaging_Diag_No ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [15] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [BR_MedicalImaging_Diag_No], [BR_MedicalImaging_Diag_Dis], [BR_MedicalImaging_Diag_Organ], [BR_MedicalImaging_Diag_Loc], [BR_MedicalImagingID], [BR_MedicalImaging_DiagID]";
         sFromString = " FROM [BR_MedicalImaging_Diag] WITH (NOLOCK)";
         sOrderString = "";
         if ( ! (0==AV55BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_DiagID] >= @AV55BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_DiagID] >= @AV55BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ! (0==AV56BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_DiagID] <= @AV56BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_DiagID] <= @AV56BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to)";
            }
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV57BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImagingID] >= @AV57BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImagingID] >= @AV57BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid)";
            }
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (0==AV58BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImagingID] <= @AV58BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImagingID] <= @AV58BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to)";
            }
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_Loc] like @lV59BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_Loc] like @lV59BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc)";
            }
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_Loc] = @AV60BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_Loc] = @AV60BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel)";
            }
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV62BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV61BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_Organ] like @lV61BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_Organ] like @lV61BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ)";
            }
         }
         else
         {
            GXv_int3[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV62BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_Organ] = @AV62BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_Organ] = @AV62BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel)";
            }
         }
         else
         {
            GXv_int3[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV64BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV63BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_Dis] like @lV63BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_Dis] like @lV63BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis)";
            }
         }
         else
         {
            GXv_int3[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV64BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_Dis] = @AV64BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_Dis] = @AV64BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel)";
            }
         }
         else
         {
            GXv_int3[9] = 1;
         }
         if ( ! (0==AV65BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_No] >= @AV65BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_No] >= @AV65BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no)";
            }
         }
         else
         {
            GXv_int3[10] = 1;
         }
         if ( ! (0==AV66BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_No] <= @AV66BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_No] <= @AV66BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to)";
            }
         }
         else
         {
            GXv_int3[11] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicalImaging_DiagID]";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicalImaging_DiagID] DESC";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicalImagingID]";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicalImagingID] DESC";
         }
         else if ( ( AV13OrderedBy == 3 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicalImaging_Diag_Loc]";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicalImaging_Diag_Loc] DESC";
         }
         else if ( ( AV13OrderedBy == 4 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicalImaging_Diag_Organ]";
         }
         else if ( ( AV13OrderedBy == 4 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicalImaging_Diag_Organ] DESC";
         }
         else if ( ( AV13OrderedBy == 5 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicalImaging_Diag_Dis]";
         }
         else if ( ( AV13OrderedBy == 5 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicalImaging_Diag_Dis] DESC";
         }
         else if ( ( AV13OrderedBy == 6 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicalImaging_Diag_No]";
         }
         else if ( ( AV13OrderedBy == 6 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicalImaging_Diag_No] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicalImaging_DiagID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H004P3( IGxContext context ,
                                             long AV55BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid ,
                                             long AV56BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to ,
                                             long AV57BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid ,
                                             long AV58BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to ,
                                             String AV60BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel ,
                                             String AV59BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc ,
                                             String AV62BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel ,
                                             String AV61BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ ,
                                             String AV64BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel ,
                                             String AV63BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis ,
                                             long AV65BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no ,
                                             long AV66BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to ,
                                             long A270BR_MedicalImaging_DiagID ,
                                             long A225BR_MedicalImagingID ,
                                             String A271BR_MedicalImaging_Diag_Loc ,
                                             String A272BR_MedicalImaging_Diag_Organ ,
                                             String A273BR_MedicalImaging_Diag_Dis ,
                                             long A517BR_MedicalImaging_Diag_No ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [12] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [BR_MedicalImaging_Diag] WITH (NOLOCK)";
         if ( ! (0==AV55BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_DiagID] >= @AV55BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_DiagID] >= @AV55BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid)";
            }
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ! (0==AV56BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_DiagID] <= @AV56BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_DiagID] <= @AV56BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to)";
            }
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( ! (0==AV57BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImagingID] >= @AV57BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImagingID] >= @AV57BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid)";
            }
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! (0==AV58BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImagingID] <= @AV58BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImagingID] <= @AV58BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to)";
            }
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_Loc] like @lV59BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_Loc] like @lV59BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc)";
            }
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_Loc] = @AV60BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_Loc] = @AV60BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel)";
            }
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV62BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV61BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_Organ] like @lV61BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_Organ] like @lV61BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ)";
            }
         }
         else
         {
            GXv_int5[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV62BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_Organ] = @AV62BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_Organ] = @AV62BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel)";
            }
         }
         else
         {
            GXv_int5[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV64BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV63BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_Dis] like @lV63BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_Dis] like @lV63BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis)";
            }
         }
         else
         {
            GXv_int5[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV64BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_Dis] = @AV64BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_Dis] = @AV64BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel)";
            }
         }
         else
         {
            GXv_int5[9] = 1;
         }
         if ( ! (0==AV65BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_No] >= @AV65BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_No] >= @AV65BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no)";
            }
         }
         else
         {
            GXv_int5[10] = 1;
         }
         if ( ! (0==AV66BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_No] <= @AV66BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_No] <= @AV66BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to)";
            }
         }
         else
         {
            GXv_int5[11] = 1;
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
                     return conditional_H004P2(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (long)dynConstraints[12] , (long)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (long)dynConstraints[17] , (short)dynConstraints[18] , (bool)dynConstraints[19] );
               case 1 :
                     return conditional_H004P3(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (long)dynConstraints[12] , (long)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (long)dynConstraints[17] , (short)dynConstraints[18] , (bool)dynConstraints[19] );
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
          Object[] prmH004P2 ;
          prmH004P2 = new Object[] {
          new Object[] {"@AV55BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV56BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV57BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV58BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV59BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV60BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV61BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV62BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV63BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV64BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV65BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV66BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH004P3 ;
          prmH004P3 = new Object[] {
          new Object[] {"@AV55BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV56BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV57BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV58BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV59BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV60BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV61BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV62BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV63BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV64BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV65BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV66BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H004P2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH004P2,11,0,true,false )
             ,new CursorDef("H004P3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH004P3,1,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((long[]) buf[8])[0] = rslt.getLong(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((long[]) buf[10])[0] = rslt.getLong(6) ;
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
                   stmt.SetParameter(sIdx, (long)parms[15]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[16]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[17]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[18]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[24]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[25]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[26]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[27]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[28]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[29]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[12]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[13]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[14]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[15]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[22]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[23]);
                }
                return;
       }
    }

 }

}
