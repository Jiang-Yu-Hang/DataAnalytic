/*
               File: BR_MedicalImaging_DiagPrompt
        Description: 选择影像学诊断意见
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:14:44.97
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
   public class br_medicalimaging_diagprompt : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public br_medicalimaging_diagprompt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_medicalimaging_diagprompt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_InOutBR_MedicalImaging_DiagID ,
                           ref String aP1_InOutBR_MedicalImaging_Diag_Loc )
      {
         this.AV8InOutBR_MedicalImaging_DiagID = aP0_InOutBR_MedicalImaging_DiagID;
         this.AV9InOutBR_MedicalImaging_Diag_Loc = aP1_InOutBR_MedicalImaging_Diag_Loc;
         executePrivate();
         aP0_InOutBR_MedicalImaging_DiagID=this.AV8InOutBR_MedicalImaging_DiagID;
         aP1_InOutBR_MedicalImaging_Diag_Loc=this.AV9InOutBR_MedicalImaging_Diag_Loc;
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
               nRC_GXsfl_12 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_12_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_12_idx = GetNextPar( );
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
               AV11OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV12OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV14ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace = GetNextPar( );
               AV16ddo_BR_MedicalImagingIDTitleControlIdToReplace = GetNextPar( );
               AV18ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace = GetNextPar( );
               AV20ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace = GetNextPar( );
               AV22ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace = GetNextPar( );
               AV30ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace, AV16ddo_BR_MedicalImagingIDTitleControlIdToReplace, AV18ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace, AV20ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace, AV22ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace, AV30ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace) ;
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
               AV8InOutBR_MedicalImaging_DiagID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_MedicalImaging_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_MedicalImaging_DiagID), 18, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV9InOutBR_MedicalImaging_Diag_Loc = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutBR_MedicalImaging_Diag_Loc", AV9InOutBR_MedicalImaging_Diag_Loc);
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
            ValidateSpaRequest();
            PA5N2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV33Pgmname = "BR_MedicalImaging_DiagPrompt";
               context.Gx_err = 0;
               WS5N2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE5N2( ) ;
               }
            }
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

      protected void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      protected void RenderHtmlOpenForm( )
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
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 127771), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxcfg.js", "?20202281514458", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
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
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "";
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_medicalimaging_diagprompt.aspx") + "?" + UrlEncode("" +AV8InOutBR_MedicalImaging_DiagID) + "," + UrlEncode(StringUtil.RTrim(AV9InOutBR_MedicalImaging_Diag_Loc))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11OrderedBy), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV12OrderedDsc));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_12", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_12), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV27GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV26GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV23DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV23DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGING_DIAGIDTITLEFILTERDATA", AV13BR_MedicalImaging_DiagIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGING_DIAGIDTITLEFILTERDATA", AV13BR_MedicalImaging_DiagIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGINGIDTITLEFILTERDATA", AV15BR_MedicalImagingIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGINGIDTITLEFILTERDATA", AV15BR_MedicalImagingIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGING_DIAG_LOCTITLEFILTERDATA", AV17BR_MedicalImaging_Diag_LocTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGING_DIAG_LOCTITLEFILTERDATA", AV17BR_MedicalImaging_Diag_LocTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGING_DIAG_ORGANTITLEFILTERDATA", AV19BR_MedicalImaging_Diag_OrganTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGING_DIAG_ORGANTITLEFILTERDATA", AV19BR_MedicalImaging_Diag_OrganTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGING_DIAG_DISTITLEFILTERDATA", AV21BR_MedicalImaging_Diag_DisTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGING_DIAG_DISTITLEFILTERDATA", AV21BR_MedicalImaging_Diag_DisTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGING_DIAG_NOTITLEFILTERDATA", AV29BR_MedicalImaging_Diag_NoTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGING_DIAG_NOTITLEFILTERDATA", AV29BR_MedicalImaging_Diag_NoTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vINOUTBR_MEDICALIMAGING_DIAGID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8InOutBR_MedicalImaging_DiagID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINOUTBR_MEDICALIMAGING_DIAG_LOC", AV9InOutBR_MedicalImaging_Diag_Loc);
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_diagid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_diagid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_diagid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_diagid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_diagid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_diagid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_diagid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_diagid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_diagid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_diagid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Caption", StringUtil.RTrim( Ddo_br_medicalimagingid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Tooltip", StringUtil.RTrim( Ddo_br_medicalimagingid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Cls", StringUtil.RTrim( Ddo_br_medicalimagingid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimagingid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimagingid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimagingid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimagingid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimagingid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimagingid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimagingid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Sortasc", StringUtil.RTrim( Ddo_br_medicalimagingid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimagingid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimagingid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Caption", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Tooltip", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Cls", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_loc_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_loc_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_loc_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_loc_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Caption", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Tooltip", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Cls", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_organ_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_organ_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_organ_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_organ_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Caption", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Tooltip", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Cls", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_dis_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_dis_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_dis_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_dis_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Caption", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Tooltip", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Cls", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_no_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_no_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_no_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_diag_no_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_diagid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimagingid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAGID_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_diagid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimagingid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_LOC_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_diag_loc_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_diag_organ_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_DIS_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_diag_dis_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_DIAG_NO_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_diag_no_Activeeventkey));
      }

      protected void RenderHtmlCloseForm5N2( )
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
         context.WriteHtmlTextNl( "</body>") ;
         context.WriteHtmlTextNl( "</html>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
      }

      public override String GetPgmname( )
      {
         return "BR_MedicalImaging_DiagPrompt" ;
      }

      public override String GetPgmdesc( )
      {
         return "选择影像学诊断意见" ;
      }

      protected void WB5N0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            RenderHtmlHeaders( ) ;
            RenderHtmlOpenForm( ) ;
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
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", divTablemain_Height, "px", "TableMain", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WorkWithCell", "left", "top", "", "", "div");
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"12\">") ;
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"SelectAttribute ActionBaseColorAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV28Select));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavSelect_Tooltiptext));
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
         if ( wbEnd == 12 )
         {
            wbEnd = 0;
            nRC_GXsfl_12 = (short)(nGXsfl_12_idx-1);
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV25GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV27GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV26GridPageSize);
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
            ucDdo_br_medicalimaging_diagid.SetProperty("IncludeDataList", Ddo_br_medicalimaging_diagid_Includedatalist);
            ucDdo_br_medicalimaging_diagid.SetProperty("SortASC", Ddo_br_medicalimaging_diagid_Sortasc);
            ucDdo_br_medicalimaging_diagid.SetProperty("SortDSC", Ddo_br_medicalimaging_diagid_Sortdsc);
            ucDdo_br_medicalimaging_diagid.SetProperty("SearchButtonText", Ddo_br_medicalimaging_diagid_Searchbuttontext);
            ucDdo_br_medicalimaging_diagid.SetProperty("DropDownOptionsTitleSettingsIcons", AV23DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_diagid.SetProperty("DropDownOptionsData", AV13BR_MedicalImaging_DiagIDTitleFilterData);
            ucDdo_br_medicalimaging_diagid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_diagid_Internalname, "DDO_BR_MEDICALIMAGING_DIAGIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_diagidtitlecontrolidtoreplace_Internalname, AV14ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,28);\"", 0, edtavDdo_br_medicalimaging_diagidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImaging_DiagPrompt.htm");
            /* User Defined Control */
            ucDdo_br_medicalimagingid.SetProperty("Caption", Ddo_br_medicalimagingid_Caption);
            ucDdo_br_medicalimagingid.SetProperty("Tooltip", Ddo_br_medicalimagingid_Tooltip);
            ucDdo_br_medicalimagingid.SetProperty("Cls", Ddo_br_medicalimagingid_Cls);
            ucDdo_br_medicalimagingid.SetProperty("DropDownOptionsType", Ddo_br_medicalimagingid_Dropdownoptionstype);
            ucDdo_br_medicalimagingid.SetProperty("IncludeSortASC", Ddo_br_medicalimagingid_Includesortasc);
            ucDdo_br_medicalimagingid.SetProperty("IncludeSortDSC", Ddo_br_medicalimagingid_Includesortdsc);
            ucDdo_br_medicalimagingid.SetProperty("IncludeFilter", Ddo_br_medicalimagingid_Includefilter);
            ucDdo_br_medicalimagingid.SetProperty("IncludeDataList", Ddo_br_medicalimagingid_Includedatalist);
            ucDdo_br_medicalimagingid.SetProperty("SortASC", Ddo_br_medicalimagingid_Sortasc);
            ucDdo_br_medicalimagingid.SetProperty("SortDSC", Ddo_br_medicalimagingid_Sortdsc);
            ucDdo_br_medicalimagingid.SetProperty("SearchButtonText", Ddo_br_medicalimagingid_Searchbuttontext);
            ucDdo_br_medicalimagingid.SetProperty("DropDownOptionsTitleSettingsIcons", AV23DDO_TitleSettingsIcons);
            ucDdo_br_medicalimagingid.SetProperty("DropDownOptionsData", AV15BR_MedicalImagingIDTitleFilterData);
            ucDdo_br_medicalimagingid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimagingid_Internalname, "DDO_BR_MEDICALIMAGINGIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Internalname, AV16ddo_BR_MedicalImagingIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,30);\"", 0, edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImaging_DiagPrompt.htm");
            /* User Defined Control */
            ucDdo_br_medicalimaging_diag_loc.SetProperty("Caption", Ddo_br_medicalimaging_diag_loc_Caption);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("Tooltip", Ddo_br_medicalimaging_diag_loc_Tooltip);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("Cls", Ddo_br_medicalimaging_diag_loc_Cls);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("DropDownOptionsType", Ddo_br_medicalimaging_diag_loc_Dropdownoptionstype);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("IncludeSortASC", Ddo_br_medicalimaging_diag_loc_Includesortasc);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("IncludeSortDSC", Ddo_br_medicalimaging_diag_loc_Includesortdsc);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("IncludeFilter", Ddo_br_medicalimaging_diag_loc_Includefilter);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("IncludeDataList", Ddo_br_medicalimaging_diag_loc_Includedatalist);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("SortASC", Ddo_br_medicalimaging_diag_loc_Sortasc);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("SortDSC", Ddo_br_medicalimaging_diag_loc_Sortdsc);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("SearchButtonText", Ddo_br_medicalimaging_diag_loc_Searchbuttontext);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("DropDownOptionsTitleSettingsIcons", AV23DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_diag_loc.SetProperty("DropDownOptionsData", AV17BR_MedicalImaging_Diag_LocTitleFilterData);
            ucDdo_br_medicalimaging_diag_loc.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_diag_loc_Internalname, "DDO_BR_MEDICALIMAGING_DIAG_LOCContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_diag_loctitlecontrolidtoreplace_Internalname, AV18ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,32);\"", 0, edtavDdo_br_medicalimaging_diag_loctitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImaging_DiagPrompt.htm");
            /* User Defined Control */
            ucDdo_br_medicalimaging_diag_organ.SetProperty("Caption", Ddo_br_medicalimaging_diag_organ_Caption);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("Tooltip", Ddo_br_medicalimaging_diag_organ_Tooltip);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("Cls", Ddo_br_medicalimaging_diag_organ_Cls);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("DropDownOptionsType", Ddo_br_medicalimaging_diag_organ_Dropdownoptionstype);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("IncludeSortASC", Ddo_br_medicalimaging_diag_organ_Includesortasc);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("IncludeSortDSC", Ddo_br_medicalimaging_diag_organ_Includesortdsc);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("IncludeFilter", Ddo_br_medicalimaging_diag_organ_Includefilter);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("IncludeDataList", Ddo_br_medicalimaging_diag_organ_Includedatalist);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("SortASC", Ddo_br_medicalimaging_diag_organ_Sortasc);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("SortDSC", Ddo_br_medicalimaging_diag_organ_Sortdsc);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("SearchButtonText", Ddo_br_medicalimaging_diag_organ_Searchbuttontext);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("DropDownOptionsTitleSettingsIcons", AV23DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_diag_organ.SetProperty("DropDownOptionsData", AV19BR_MedicalImaging_Diag_OrganTitleFilterData);
            ucDdo_br_medicalimaging_diag_organ.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_diag_organ_Internalname, "DDO_BR_MEDICALIMAGING_DIAG_ORGANContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_diag_organtitlecontrolidtoreplace_Internalname, AV20ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", 0, edtavDdo_br_medicalimaging_diag_organtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImaging_DiagPrompt.htm");
            /* User Defined Control */
            ucDdo_br_medicalimaging_diag_dis.SetProperty("Caption", Ddo_br_medicalimaging_diag_dis_Caption);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("Tooltip", Ddo_br_medicalimaging_diag_dis_Tooltip);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("Cls", Ddo_br_medicalimaging_diag_dis_Cls);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("DropDownOptionsType", Ddo_br_medicalimaging_diag_dis_Dropdownoptionstype);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("IncludeSortASC", Ddo_br_medicalimaging_diag_dis_Includesortasc);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("IncludeSortDSC", Ddo_br_medicalimaging_diag_dis_Includesortdsc);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("IncludeFilter", Ddo_br_medicalimaging_diag_dis_Includefilter);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("IncludeDataList", Ddo_br_medicalimaging_diag_dis_Includedatalist);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("SortASC", Ddo_br_medicalimaging_diag_dis_Sortasc);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("SortDSC", Ddo_br_medicalimaging_diag_dis_Sortdsc);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("SearchButtonText", Ddo_br_medicalimaging_diag_dis_Searchbuttontext);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("DropDownOptionsTitleSettingsIcons", AV23DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_diag_dis.SetProperty("DropDownOptionsData", AV21BR_MedicalImaging_Diag_DisTitleFilterData);
            ucDdo_br_medicalimaging_diag_dis.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_diag_dis_Internalname, "DDO_BR_MEDICALIMAGING_DIAG_DISContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_diag_distitlecontrolidtoreplace_Internalname, AV22ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,36);\"", 0, edtavDdo_br_medicalimaging_diag_distitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImaging_DiagPrompt.htm");
            /* User Defined Control */
            ucDdo_br_medicalimaging_diag_no.SetProperty("Caption", Ddo_br_medicalimaging_diag_no_Caption);
            ucDdo_br_medicalimaging_diag_no.SetProperty("Tooltip", Ddo_br_medicalimaging_diag_no_Tooltip);
            ucDdo_br_medicalimaging_diag_no.SetProperty("Cls", Ddo_br_medicalimaging_diag_no_Cls);
            ucDdo_br_medicalimaging_diag_no.SetProperty("DropDownOptionsType", Ddo_br_medicalimaging_diag_no_Dropdownoptionstype);
            ucDdo_br_medicalimaging_diag_no.SetProperty("IncludeSortASC", Ddo_br_medicalimaging_diag_no_Includesortasc);
            ucDdo_br_medicalimaging_diag_no.SetProperty("IncludeSortDSC", Ddo_br_medicalimaging_diag_no_Includesortdsc);
            ucDdo_br_medicalimaging_diag_no.SetProperty("IncludeFilter", Ddo_br_medicalimaging_diag_no_Includefilter);
            ucDdo_br_medicalimaging_diag_no.SetProperty("IncludeDataList", Ddo_br_medicalimaging_diag_no_Includedatalist);
            ucDdo_br_medicalimaging_diag_no.SetProperty("SortASC", Ddo_br_medicalimaging_diag_no_Sortasc);
            ucDdo_br_medicalimaging_diag_no.SetProperty("SortDSC", Ddo_br_medicalimaging_diag_no_Sortdsc);
            ucDdo_br_medicalimaging_diag_no.SetProperty("SearchButtonText", Ddo_br_medicalimaging_diag_no_Searchbuttontext);
            ucDdo_br_medicalimaging_diag_no.SetProperty("DropDownOptionsTitleSettingsIcons", AV23DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_diag_no.SetProperty("DropDownOptionsData", AV29BR_MedicalImaging_Diag_NoTitleFilterData);
            ucDdo_br_medicalimaging_diag_no.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_diag_no_Internalname, "DDO_BR_MEDICALIMAGING_DIAG_NOContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_diag_notitlecontrolidtoreplace_Internalname, AV30ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", 0, edtavDdo_br_medicalimaging_diag_notitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImaging_DiagPrompt.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,40);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicalImaging_DiagPrompt.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV12OrderedDsc), StringUtil.BoolToStr( AV12OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,41);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_MedicalImaging_DiagPrompt.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 12 )
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

      protected void START5N2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "选择影像学诊断意见", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP5N0( ) ;
      }

      protected void WS5N2( )
      {
         START5N2( ) ;
         EVT5N2( ) ;
      }

      protected void EVT5N2( )
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
                           E115N2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E125N2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_DIAGID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E135N2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGINGID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E145N2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_DIAG_LOC.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E155N2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_DIAG_ORGAN.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E165N2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_DIAG_DIS.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E175N2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_DIAG_NO.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E185N2 ();
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
                        if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) )
                        {
                           nGXsfl_12_idx = (short)(NumberUtil.Val( sEvtType, "."));
                           sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
                           SubsflControlProps_122( ) ;
                           AV28Select = cgiGet( edtavSelect_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV28Select)) ? AV34Select_GXI : context.convertURL( context.PathToRelativeUrl( AV28Select))), !bGXsfl_12_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "SrcSet", context.GetImageSrcSet( AV28Select), true);
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
                                 E195N2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E205N2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E215N2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    Rfr0gs = false;
                                    /* Set Refresh If Orderedby Changed */
                                    if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV11OrderedBy )) )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Ordereddsc Changed */
                                    if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV12OrderedDsc )
                                    {
                                       Rfr0gs = true;
                                    }
                                    if ( ! Rfr0gs )
                                    {
                                       /* Execute user event: Enter */
                                       E225N2 ();
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

      protected void WE5N2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm5N2( ) ;
            }
         }
      }

      protected void PA5N2( )
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
         SubsflControlProps_122( ) ;
         while ( nGXsfl_12_idx <= nRC_GXsfl_12 )
         {
            sendrow_122( ) ;
            nGXsfl_12_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_12_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1));
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV11OrderedBy ,
                                       bool AV12OrderedDsc ,
                                       String AV14ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace ,
                                       String AV16ddo_BR_MedicalImagingIDTitleControlIdToReplace ,
                                       String AV18ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace ,
                                       String AV20ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace ,
                                       String AV22ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace ,
                                       String AV30ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF5N2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_MEDICALIMAGING_DIAGID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A270BR_MedicalImaging_DiagID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_MEDICALIMAGING_DIAGID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A270BR_MedicalImaging_DiagID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_MEDICALIMAGING_DIAG_LOC", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A271BR_MedicalImaging_Diag_Loc, "")), context));
         GxWebStd.gx_hidden_field( context, "BR_MEDICALIMAGING_DIAG_LOC", A271BR_MedicalImaging_Diag_Loc);
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
         RF5N2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV33Pgmname = "BR_MedicalImaging_DiagPrompt";
         context.Gx_err = 0;
      }

      protected void RF5N2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 12;
         /* Execute user event: Refresh */
         E205N2 ();
         nGXsfl_12_idx = 1;
         sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
         SubsflControlProps_122( ) ;
         bGXsfl_12_Refreshing = true;
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
            SubsflControlProps_122( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV11OrderedBy ,
                                                 AV12OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            /* Using cursor H005N2 */
            pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_12_idx = 1;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A517BR_MedicalImaging_Diag_No = H005N2_A517BR_MedicalImaging_Diag_No[0];
               n517BR_MedicalImaging_Diag_No = H005N2_n517BR_MedicalImaging_Diag_No[0];
               A273BR_MedicalImaging_Diag_Dis = H005N2_A273BR_MedicalImaging_Diag_Dis[0];
               n273BR_MedicalImaging_Diag_Dis = H005N2_n273BR_MedicalImaging_Diag_Dis[0];
               A272BR_MedicalImaging_Diag_Organ = H005N2_A272BR_MedicalImaging_Diag_Organ[0];
               n272BR_MedicalImaging_Diag_Organ = H005N2_n272BR_MedicalImaging_Diag_Organ[0];
               A271BR_MedicalImaging_Diag_Loc = H005N2_A271BR_MedicalImaging_Diag_Loc[0];
               n271BR_MedicalImaging_Diag_Loc = H005N2_n271BR_MedicalImaging_Diag_Loc[0];
               A225BR_MedicalImagingID = H005N2_A225BR_MedicalImagingID[0];
               n225BR_MedicalImagingID = H005N2_n225BR_MedicalImagingID[0];
               A270BR_MedicalImaging_DiagID = H005N2_A270BR_MedicalImaging_DiagID[0];
               E215N2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 12;
            WB5N0( ) ;
         }
         bGXsfl_12_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes5N2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_MEDICALIMAGING_DIAGID"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, context.localUtil.Format( (decimal)(A270BR_MedicalImaging_DiagID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_MEDICALIMAGING_DIAG_LOC"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, StringUtil.RTrim( context.localUtil.Format( A271BR_MedicalImaging_Diag_Loc, "")), context));
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
                                              AV11OrderedBy ,
                                              AV12OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         /* Using cursor H005N3 */
         pr_default.execute(1);
         GRID_nRecordCount = H005N3_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace, AV16ddo_BR_MedicalImagingIDTitleControlIdToReplace, AV18ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace, AV20ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace, AV22ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace, AV30ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace, AV16ddo_BR_MedicalImagingIDTitleControlIdToReplace, AV18ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace, AV20ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace, AV22ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace, AV30ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace, AV16ddo_BR_MedicalImagingIDTitleControlIdToReplace, AV18ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace, AV20ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace, AV22ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace, AV30ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace, AV16ddo_BR_MedicalImagingIDTitleControlIdToReplace, AV18ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace, AV20ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace, AV22ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace, AV30ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace, AV16ddo_BR_MedicalImagingIDTitleControlIdToReplace, AV18ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace, AV20ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace, AV22ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace, AV30ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP5N0( )
      {
         /* Before Start, stand alone formulas. */
         AV33Pgmname = "BR_MedicalImaging_DiagPrompt";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E195N2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV23DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICALIMAGING_DIAGIDTITLEFILTERDATA"), AV13BR_MedicalImaging_DiagIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICALIMAGINGIDTITLEFILTERDATA"), AV15BR_MedicalImagingIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICALIMAGING_DIAG_LOCTITLEFILTERDATA"), AV17BR_MedicalImaging_Diag_LocTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICALIMAGING_DIAG_ORGANTITLEFILTERDATA"), AV19BR_MedicalImaging_Diag_OrganTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICALIMAGING_DIAG_DISTITLEFILTERDATA"), AV21BR_MedicalImaging_Diag_DisTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICALIMAGING_DIAG_NOTITLEFILTERDATA"), AV29BR_MedicalImaging_Diag_NoTitleFilterData);
            /* Read variables values. */
            AV14ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_diagidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace", AV14ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace);
            AV16ddo_BR_MedicalImagingIDTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_BR_MedicalImagingIDTitleControlIdToReplace", AV16ddo_BR_MedicalImagingIDTitleControlIdToReplace);
            AV18ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_diag_loctitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace", AV18ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace);
            AV20ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_diag_organtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace", AV20ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace);
            AV22ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_diag_distitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace", AV22ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace);
            AV30ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_diag_notitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace", AV30ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDEREDBY");
               GX_FocusControl = edtavOrderedby_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV11OrderedBy = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            }
            else
            {
               AV11OrderedBy = (short)(context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            }
            AV12OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            /* Read saved values. */
            nRC_GXsfl_12 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_12"), ".", ","));
            AV25GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV27GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV26GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID_nFirstRecordOnPage"), ".", ","));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID_nEOF"), ".", ","));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
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
            Ddo_br_medicalimaging_diagid_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Dropdownoptionstype");
            Ddo_br_medicalimaging_diagid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_diagid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Includesortasc"));
            Ddo_br_medicalimaging_diagid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Includesortdsc"));
            Ddo_br_medicalimaging_diagid_Sortedstatus = cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Sortedstatus");
            Ddo_br_medicalimaging_diagid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Includefilter"));
            Ddo_br_medicalimaging_diagid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Includedatalist"));
            Ddo_br_medicalimaging_diagid_Sortasc = cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Sortasc");
            Ddo_br_medicalimaging_diagid_Sortdsc = cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Sortdsc");
            Ddo_br_medicalimaging_diagid_Searchbuttontext = cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Searchbuttontext");
            Ddo_br_medicalimagingid_Caption = cgiGet( "DDO_BR_MEDICALIMAGINGID_Caption");
            Ddo_br_medicalimagingid_Tooltip = cgiGet( "DDO_BR_MEDICALIMAGINGID_Tooltip");
            Ddo_br_medicalimagingid_Cls = cgiGet( "DDO_BR_MEDICALIMAGINGID_Cls");
            Ddo_br_medicalimagingid_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICALIMAGINGID_Dropdownoptionstype");
            Ddo_br_medicalimagingid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICALIMAGINGID_Titlecontrolidtoreplace");
            Ddo_br_medicalimagingid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGINGID_Includesortasc"));
            Ddo_br_medicalimagingid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGINGID_Includesortdsc"));
            Ddo_br_medicalimagingid_Sortedstatus = cgiGet( "DDO_BR_MEDICALIMAGINGID_Sortedstatus");
            Ddo_br_medicalimagingid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGINGID_Includefilter"));
            Ddo_br_medicalimagingid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGINGID_Includedatalist"));
            Ddo_br_medicalimagingid_Sortasc = cgiGet( "DDO_BR_MEDICALIMAGINGID_Sortasc");
            Ddo_br_medicalimagingid_Sortdsc = cgiGet( "DDO_BR_MEDICALIMAGINGID_Sortdsc");
            Ddo_br_medicalimagingid_Searchbuttontext = cgiGet( "DDO_BR_MEDICALIMAGINGID_Searchbuttontext");
            Ddo_br_medicalimaging_diag_loc_Caption = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Caption");
            Ddo_br_medicalimaging_diag_loc_Tooltip = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Tooltip");
            Ddo_br_medicalimaging_diag_loc_Cls = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Cls");
            Ddo_br_medicalimaging_diag_loc_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Dropdownoptionstype");
            Ddo_br_medicalimaging_diag_loc_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_diag_loc_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Includesortasc"));
            Ddo_br_medicalimaging_diag_loc_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Includesortdsc"));
            Ddo_br_medicalimaging_diag_loc_Sortedstatus = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Sortedstatus");
            Ddo_br_medicalimaging_diag_loc_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Includefilter"));
            Ddo_br_medicalimaging_diag_loc_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Includedatalist"));
            Ddo_br_medicalimaging_diag_loc_Sortasc = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Sortasc");
            Ddo_br_medicalimaging_diag_loc_Sortdsc = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Sortdsc");
            Ddo_br_medicalimaging_diag_loc_Searchbuttontext = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Searchbuttontext");
            Ddo_br_medicalimaging_diag_organ_Caption = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Caption");
            Ddo_br_medicalimaging_diag_organ_Tooltip = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Tooltip");
            Ddo_br_medicalimaging_diag_organ_Cls = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Cls");
            Ddo_br_medicalimaging_diag_organ_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Dropdownoptionstype");
            Ddo_br_medicalimaging_diag_organ_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_diag_organ_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Includesortasc"));
            Ddo_br_medicalimaging_diag_organ_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Includesortdsc"));
            Ddo_br_medicalimaging_diag_organ_Sortedstatus = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Sortedstatus");
            Ddo_br_medicalimaging_diag_organ_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Includefilter"));
            Ddo_br_medicalimaging_diag_organ_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Includedatalist"));
            Ddo_br_medicalimaging_diag_organ_Sortasc = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Sortasc");
            Ddo_br_medicalimaging_diag_organ_Sortdsc = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Sortdsc");
            Ddo_br_medicalimaging_diag_organ_Searchbuttontext = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Searchbuttontext");
            Ddo_br_medicalimaging_diag_dis_Caption = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Caption");
            Ddo_br_medicalimaging_diag_dis_Tooltip = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Tooltip");
            Ddo_br_medicalimaging_diag_dis_Cls = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Cls");
            Ddo_br_medicalimaging_diag_dis_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Dropdownoptionstype");
            Ddo_br_medicalimaging_diag_dis_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_diag_dis_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Includesortasc"));
            Ddo_br_medicalimaging_diag_dis_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Includesortdsc"));
            Ddo_br_medicalimaging_diag_dis_Sortedstatus = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Sortedstatus");
            Ddo_br_medicalimaging_diag_dis_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Includefilter"));
            Ddo_br_medicalimaging_diag_dis_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Includedatalist"));
            Ddo_br_medicalimaging_diag_dis_Sortasc = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Sortasc");
            Ddo_br_medicalimaging_diag_dis_Sortdsc = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Sortdsc");
            Ddo_br_medicalimaging_diag_dis_Searchbuttontext = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Searchbuttontext");
            Ddo_br_medicalimaging_diag_no_Caption = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Caption");
            Ddo_br_medicalimaging_diag_no_Tooltip = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Tooltip");
            Ddo_br_medicalimaging_diag_no_Cls = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Cls");
            Ddo_br_medicalimaging_diag_no_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Dropdownoptionstype");
            Ddo_br_medicalimaging_diag_no_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_diag_no_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Includesortasc"));
            Ddo_br_medicalimaging_diag_no_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Includesortdsc"));
            Ddo_br_medicalimaging_diag_no_Sortedstatus = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Sortedstatus");
            Ddo_br_medicalimaging_diag_no_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Includefilter"));
            Ddo_br_medicalimaging_diag_no_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Includedatalist"));
            Ddo_br_medicalimaging_diag_no_Sortasc = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Sortasc");
            Ddo_br_medicalimaging_diag_no_Sortdsc = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Sortdsc");
            Ddo_br_medicalimaging_diag_no_Searchbuttontext = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_medicalimaging_diagid_Activeeventkey = cgiGet( "DDO_BR_MEDICALIMAGING_DIAGID_Activeeventkey");
            Ddo_br_medicalimagingid_Activeeventkey = cgiGet( "DDO_BR_MEDICALIMAGINGID_Activeeventkey");
            Ddo_br_medicalimaging_diag_loc_Activeeventkey = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_LOC_Activeeventkey");
            Ddo_br_medicalimaging_diag_organ_Activeeventkey = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_ORGAN_Activeeventkey");
            Ddo_br_medicalimaging_diag_dis_Activeeventkey = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_DIS_Activeeventkey");
            Ddo_br_medicalimaging_diag_no_Activeeventkey = cgiGet( "DDO_BR_MEDICALIMAGING_DIAG_NO_Activeeventkey");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV11OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV12OrderedDsc )
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
         E195N2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E195N2( )
      {
         /* Start Routine */
         GXt_boolean1 = AV5IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_MedicalImaging_Diag", out  GXt_boolean1) ;
         AV5IsAuthorized = GXt_boolean1;
         if ( ! AV5IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV33Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         divTablemain_Height = 493;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTablemain_Internalname, "Height", StringUtil.LTrim( StringUtil.Str( (decimal)(divTablemain_Height), 9, 0)), true);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_br_medicalimaging_diagid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_DiagID";
         ucDdo_br_medicalimaging_diagid.SendProperty(context, "", false, Ddo_br_medicalimaging_diagid_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_diagid_Titlecontrolidtoreplace);
         AV14ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace = Ddo_br_medicalimaging_diagid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace", AV14ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_diagidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicalimaging_diagidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_diagidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicalimagingid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImagingID";
         ucDdo_br_medicalimagingid.SendProperty(context, "", false, Ddo_br_medicalimagingid_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimagingid_Titlecontrolidtoreplace);
         AV16ddo_BR_MedicalImagingIDTitleControlIdToReplace = Ddo_br_medicalimagingid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_BR_MedicalImagingIDTitleControlIdToReplace", AV16ddo_BR_MedicalImagingIDTitleControlIdToReplace);
         edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicalimaging_diag_loc_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_Diag_Loc";
         ucDdo_br_medicalimaging_diag_loc.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_loc_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_diag_loc_Titlecontrolidtoreplace);
         AV18ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace = Ddo_br_medicalimaging_diag_loc_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace", AV18ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_diag_loctitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicalimaging_diag_loctitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_diag_loctitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicalimaging_diag_organ_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_Diag_Organ";
         ucDdo_br_medicalimaging_diag_organ.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_organ_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_diag_organ_Titlecontrolidtoreplace);
         AV20ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace = Ddo_br_medicalimaging_diag_organ_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace", AV20ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_diag_organtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicalimaging_diag_organtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_diag_organtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicalimaging_diag_dis_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_Diag_Dis";
         ucDdo_br_medicalimaging_diag_dis.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_dis_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_diag_dis_Titlecontrolidtoreplace);
         AV22ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace = Ddo_br_medicalimaging_diag_dis_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace", AV22ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_diag_distitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicalimaging_diag_distitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_diag_distitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicalimaging_diag_no_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_Diag_No";
         ucDdo_br_medicalimaging_diag_no.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_no_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_diag_no_Titlecontrolidtoreplace);
         AV30ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace = Ddo_br_medicalimaging_diag_no_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace", AV30ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_diag_notitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicalimaging_diag_notitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_diag_notitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "选择Data Mgmt Portal - RAAP";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         edtavOrderedby_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrderedby_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrderedby_Visible), 5, 0)), true);
         if ( AV11OrderedBy < 1 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
         }
         edtavOrdereddsc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrdereddsc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrdereddsc_Visible), 5, 0)), true);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV23DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV23DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E205N2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV13BR_MedicalImaging_DiagIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15BR_MedicalImagingIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17BR_MedicalImaging_Diag_LocTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19BR_MedicalImaging_Diag_OrganTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_MedicalImaging_Diag_DisTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV29BR_MedicalImaging_Diag_NoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         edtBR_MedicalImaging_DiagID_Titleformat = 2;
         edtBR_MedicalImaging_DiagID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "影像学诊断意见主键", AV14ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_DiagID_Internalname, "Title", edtBR_MedicalImaging_DiagID_Title, !bGXsfl_12_Refreshing);
         edtBR_MedicalImagingID_Titleformat = 2;
         edtBR_MedicalImagingID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "影像学主键", AV16ddo_BR_MedicalImagingIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImagingID_Internalname, "Title", edtBR_MedicalImagingID_Title, !bGXsfl_12_Refreshing);
         edtBR_MedicalImaging_Diag_Loc_Titleformat = 2;
         edtBR_MedicalImaging_Diag_Loc_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "诊断意见(部位)", AV18ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_Diag_Loc_Internalname, "Title", edtBR_MedicalImaging_Diag_Loc_Title, !bGXsfl_12_Refreshing);
         edtBR_MedicalImaging_Diag_Organ_Titleformat = 2;
         edtBR_MedicalImaging_Diag_Organ_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "诊断意见(器官)", AV20ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_Diag_Organ_Internalname, "Title", edtBR_MedicalImaging_Diag_Organ_Title, !bGXsfl_12_Refreshing);
         edtBR_MedicalImaging_Diag_Dis_Titleformat = 2;
         edtBR_MedicalImaging_Diag_Dis_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "诊断意见(疾病)", AV22ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_Diag_Dis_Internalname, "Title", edtBR_MedicalImaging_Diag_Dis_Title, !bGXsfl_12_Refreshing);
         edtBR_MedicalImaging_Diag_No_Titleformat = 2;
         edtBR_MedicalImaging_Diag_No_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "序号", AV30ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_Diag_No_Internalname, "Title", edtBR_MedicalImaging_Diag_No_Title, !bGXsfl_12_Refreshing);
         AV25GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25GridCurrentPage), 10, 0)));
         AV26GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26GridPageSize), 10, 0)));
         AV27GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV27GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_MedicalImaging_DiagIDTitleFilterData", AV13BR_MedicalImaging_DiagIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_MedicalImagingIDTitleFilterData", AV15BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_MedicalImaging_Diag_LocTitleFilterData", AV17BR_MedicalImaging_Diag_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_MedicalImaging_Diag_OrganTitleFilterData", AV19BR_MedicalImaging_Diag_OrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_MedicalImaging_Diag_DisTitleFilterData", AV21BR_MedicalImaging_Diag_DisTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_MedicalImaging_Diag_NoTitleFilterData", AV29BR_MedicalImaging_Diag_NoTitleFilterData);
      }

      protected void E115N2( )
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
            AV24PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV24PageToGo) ;
         }
      }

      protected void E125N2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E135N2( )
      {
         /* Ddo_br_medicalimaging_diagid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_diagid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_diagid_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_diagid.SendProperty(context, "", false, Ddo_br_medicalimaging_diagid_Internalname, "SortedStatus", Ddo_br_medicalimaging_diagid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_diagid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_diagid_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_diagid.SendProperty(context, "", false, Ddo_br_medicalimaging_diagid_Internalname, "SortedStatus", Ddo_br_medicalimaging_diagid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_MedicalImaging_DiagIDTitleFilterData", AV13BR_MedicalImaging_DiagIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_MedicalImagingIDTitleFilterData", AV15BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_MedicalImaging_Diag_LocTitleFilterData", AV17BR_MedicalImaging_Diag_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_MedicalImaging_Diag_OrganTitleFilterData", AV19BR_MedicalImaging_Diag_OrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_MedicalImaging_Diag_DisTitleFilterData", AV21BR_MedicalImaging_Diag_DisTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_MedicalImaging_Diag_NoTitleFilterData", AV29BR_MedicalImaging_Diag_NoTitleFilterData);
      }

      protected void E145N2( )
      {
         /* Ddo_br_medicalimagingid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimagingid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimagingid_Sortedstatus = "ASC";
            ucDdo_br_medicalimagingid.SendProperty(context, "", false, Ddo_br_medicalimagingid_Internalname, "SortedStatus", Ddo_br_medicalimagingid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimagingid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimagingid_Sortedstatus = "DSC";
            ucDdo_br_medicalimagingid.SendProperty(context, "", false, Ddo_br_medicalimagingid_Internalname, "SortedStatus", Ddo_br_medicalimagingid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_MedicalImaging_DiagIDTitleFilterData", AV13BR_MedicalImaging_DiagIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_MedicalImagingIDTitleFilterData", AV15BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_MedicalImaging_Diag_LocTitleFilterData", AV17BR_MedicalImaging_Diag_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_MedicalImaging_Diag_OrganTitleFilterData", AV19BR_MedicalImaging_Diag_OrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_MedicalImaging_Diag_DisTitleFilterData", AV21BR_MedicalImaging_Diag_DisTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_MedicalImaging_Diag_NoTitleFilterData", AV29BR_MedicalImaging_Diag_NoTitleFilterData);
      }

      protected void E155N2( )
      {
         /* Ddo_br_medicalimaging_diag_loc_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_diag_loc_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_diag_loc_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_diag_loc.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_loc_Internalname, "SortedStatus", Ddo_br_medicalimaging_diag_loc_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_diag_loc_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_diag_loc_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_diag_loc.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_loc_Internalname, "SortedStatus", Ddo_br_medicalimaging_diag_loc_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_MedicalImaging_DiagIDTitleFilterData", AV13BR_MedicalImaging_DiagIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_MedicalImagingIDTitleFilterData", AV15BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_MedicalImaging_Diag_LocTitleFilterData", AV17BR_MedicalImaging_Diag_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_MedicalImaging_Diag_OrganTitleFilterData", AV19BR_MedicalImaging_Diag_OrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_MedicalImaging_Diag_DisTitleFilterData", AV21BR_MedicalImaging_Diag_DisTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_MedicalImaging_Diag_NoTitleFilterData", AV29BR_MedicalImaging_Diag_NoTitleFilterData);
      }

      protected void E165N2( )
      {
         /* Ddo_br_medicalimaging_diag_organ_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_diag_organ_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_diag_organ_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_diag_organ.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_organ_Internalname, "SortedStatus", Ddo_br_medicalimaging_diag_organ_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_diag_organ_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_diag_organ_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_diag_organ.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_organ_Internalname, "SortedStatus", Ddo_br_medicalimaging_diag_organ_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_MedicalImaging_DiagIDTitleFilterData", AV13BR_MedicalImaging_DiagIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_MedicalImagingIDTitleFilterData", AV15BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_MedicalImaging_Diag_LocTitleFilterData", AV17BR_MedicalImaging_Diag_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_MedicalImaging_Diag_OrganTitleFilterData", AV19BR_MedicalImaging_Diag_OrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_MedicalImaging_Diag_DisTitleFilterData", AV21BR_MedicalImaging_Diag_DisTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_MedicalImaging_Diag_NoTitleFilterData", AV29BR_MedicalImaging_Diag_NoTitleFilterData);
      }

      protected void E175N2( )
      {
         /* Ddo_br_medicalimaging_diag_dis_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_diag_dis_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_diag_dis_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_diag_dis.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_dis_Internalname, "SortedStatus", Ddo_br_medicalimaging_diag_dis_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_diag_dis_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_diag_dis_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_diag_dis.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_dis_Internalname, "SortedStatus", Ddo_br_medicalimaging_diag_dis_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_MedicalImaging_DiagIDTitleFilterData", AV13BR_MedicalImaging_DiagIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_MedicalImagingIDTitleFilterData", AV15BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_MedicalImaging_Diag_LocTitleFilterData", AV17BR_MedicalImaging_Diag_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_MedicalImaging_Diag_OrganTitleFilterData", AV19BR_MedicalImaging_Diag_OrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_MedicalImaging_Diag_DisTitleFilterData", AV21BR_MedicalImaging_Diag_DisTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_MedicalImaging_Diag_NoTitleFilterData", AV29BR_MedicalImaging_Diag_NoTitleFilterData);
      }

      protected void E185N2( )
      {
         /* Ddo_br_medicalimaging_diag_no_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_diag_no_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_diag_no_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_diag_no.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_no_Internalname, "SortedStatus", Ddo_br_medicalimaging_diag_no_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_diag_no_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_diag_no_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_diag_no.SendProperty(context, "", false, Ddo_br_medicalimaging_diag_no_Internalname, "SortedStatus", Ddo_br_medicalimaging_diag_no_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_MedicalImaging_DiagIDTitleFilterData", AV13BR_MedicalImaging_DiagIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_MedicalImagingIDTitleFilterData", AV15BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_MedicalImaging_Diag_LocTitleFilterData", AV17BR_MedicalImaging_Diag_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_MedicalImaging_Diag_OrganTitleFilterData", AV19BR_MedicalImaging_Diag_OrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_MedicalImaging_Diag_DisTitleFilterData", AV21BR_MedicalImaging_Diag_DisTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_MedicalImaging_Diag_NoTitleFilterData", AV29BR_MedicalImaging_Diag_NoTitleFilterData);
      }

      private void E215N2( )
      {
         /* Grid_Load Routine */
         AV28Select = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSelect_Internalname, AV28Select);
         AV34Select_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         edtavSelect_Tooltiptext = "选择";
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 12;
         }
         sendrow_122( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_12_Refreshing )
         {
            context.DoAjaxLoad(12, GridRow);
         }
         /*  Sending Event outputs  */
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E225N2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E225N2( )
      {
         /* Enter Routine */
         AV8InOutBR_MedicalImaging_DiagID = A270BR_MedicalImaging_DiagID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_MedicalImaging_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_MedicalImaging_DiagID), 18, 0)));
         AV9InOutBR_MedicalImaging_Diag_Loc = A271BR_MedicalImaging_Diag_Loc;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutBR_MedicalImaging_Diag_Loc", AV9InOutBR_MedicalImaging_Diag_Loc);
         context.setWebReturnParms(new Object[] {(long)AV8InOutBR_MedicalImaging_DiagID,(String)AV9InOutBR_MedicalImaging_Diag_Loc});
         context.setWebReturnParmsMetadata(new Object[] {"AV8InOutBR_MedicalImaging_DiagID","AV9InOutBR_MedicalImaging_Diag_Loc"});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
         /*  Sending Event outputs  */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV8InOutBR_MedicalImaging_DiagID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_MedicalImaging_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_MedicalImaging_DiagID), 18, 0)));
         AV9InOutBR_MedicalImaging_Diag_Loc = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutBR_MedicalImaging_Diag_Loc", AV9InOutBR_MedicalImaging_Diag_Loc);
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
         PA5N2( ) ;
         WS5N2( ) ;
         WE5N2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022815145546", true);
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
         context.AddJavascriptSource("br_medicalimaging_diagprompt.js", "?202022815145546", false);
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

      protected void SubsflControlProps_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_idx;
         edtBR_MedicalImaging_DiagID_Internalname = "BR_MEDICALIMAGING_DIAGID_"+sGXsfl_12_idx;
         edtBR_MedicalImagingID_Internalname = "BR_MEDICALIMAGINGID_"+sGXsfl_12_idx;
         edtBR_MedicalImaging_Diag_Loc_Internalname = "BR_MEDICALIMAGING_DIAG_LOC_"+sGXsfl_12_idx;
         edtBR_MedicalImaging_Diag_Organ_Internalname = "BR_MEDICALIMAGING_DIAG_ORGAN_"+sGXsfl_12_idx;
         edtBR_MedicalImaging_Diag_Dis_Internalname = "BR_MEDICALIMAGING_DIAG_DIS_"+sGXsfl_12_idx;
         edtBR_MedicalImaging_Diag_No_Internalname = "BR_MEDICALIMAGING_DIAG_NO_"+sGXsfl_12_idx;
      }

      protected void SubsflControlProps_fel_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_fel_idx;
         edtBR_MedicalImaging_DiagID_Internalname = "BR_MEDICALIMAGING_DIAGID_"+sGXsfl_12_fel_idx;
         edtBR_MedicalImagingID_Internalname = "BR_MEDICALIMAGINGID_"+sGXsfl_12_fel_idx;
         edtBR_MedicalImaging_Diag_Loc_Internalname = "BR_MEDICALIMAGING_DIAG_LOC_"+sGXsfl_12_fel_idx;
         edtBR_MedicalImaging_Diag_Organ_Internalname = "BR_MEDICALIMAGING_DIAG_ORGAN_"+sGXsfl_12_fel_idx;
         edtBR_MedicalImaging_Diag_Dis_Internalname = "BR_MEDICALIMAGING_DIAG_DIS_"+sGXsfl_12_fel_idx;
         edtBR_MedicalImaging_Diag_No_Internalname = "BR_MEDICALIMAGING_DIAG_NO_"+sGXsfl_12_fel_idx;
      }

      protected void sendrow_122( )
      {
         SubsflControlProps_122( ) ;
         WB5N0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_12_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_12_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_12_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavSelect_Enabled!=0)&&(edtavSelect_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 13,'',false,'',12)\"" : " ");
            ClassString = "SelectAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV28Select_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV28Select))&&String.IsNullOrEmpty(StringUtil.RTrim( AV34Select_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV28Select)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV28Select)) ? AV34Select_GXI : context.PathToRelativeUrl( AV28Select));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSelect_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSelect_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSelect_Jsonclick,"'"+""+"'"+",false,"+"'"+"EENTER."+sGXsfl_12_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV28Select_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImaging_DiagID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A270BR_MedicalImaging_DiagID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A270BR_MedicalImaging_DiagID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImaging_DiagID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImagingID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A225BR_MedicalImagingID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A225BR_MedicalImagingID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImagingID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImaging_Diag_Loc_Internalname,(String)A271BR_MedicalImaging_Diag_Loc,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImaging_Diag_Loc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImaging_Diag_Organ_Internalname,(String)A272BR_MedicalImaging_Diag_Organ,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImaging_Diag_Organ_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImaging_Diag_Dis_Internalname,(String)A273BR_MedicalImaging_Diag_Dis,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImaging_Diag_Dis_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImaging_Diag_No_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A517BR_MedicalImaging_Diag_No), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A517BR_MedicalImaging_Diag_No), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImaging_Diag_No_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            send_integrity_lvl_hashes5N2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_12_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_12_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1));
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
         }
         /* End function sendrow_122 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtavSelect_Internalname = "vSELECT";
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
         edtavSelect_Jsonclick = "";
         edtavSelect_Visible = -1;
         edtavSelect_Enabled = 1;
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
         edtavSelect_Tooltiptext = "选择";
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
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         divTablemain_Height = 0;
         Ddo_br_medicalimaging_diag_no_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_diag_no_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_diag_no_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_diag_no_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_diag_no_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_diag_no_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_diag_no_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_diag_no_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimaging_diag_no_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimaging_diag_no_Cls = "ColumnSettings";
         Ddo_br_medicalimaging_diag_no_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimaging_diag_no_Caption = "";
         Ddo_br_medicalimaging_diag_dis_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_diag_dis_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_diag_dis_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_diag_dis_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_diag_dis_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_diag_dis_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_diag_dis_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_diag_dis_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimaging_diag_dis_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimaging_diag_dis_Cls = "ColumnSettings";
         Ddo_br_medicalimaging_diag_dis_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimaging_diag_dis_Caption = "";
         Ddo_br_medicalimaging_diag_organ_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_diag_organ_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_diag_organ_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_diag_organ_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_diag_organ_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_diag_organ_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_diag_organ_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_diag_organ_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimaging_diag_organ_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimaging_diag_organ_Cls = "ColumnSettings";
         Ddo_br_medicalimaging_diag_organ_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimaging_diag_organ_Caption = "";
         Ddo_br_medicalimaging_diag_loc_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_diag_loc_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_diag_loc_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_diag_loc_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_diag_loc_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_diag_loc_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_diag_loc_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_diag_loc_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimaging_diag_loc_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimaging_diag_loc_Cls = "ColumnSettings";
         Ddo_br_medicalimaging_diag_loc_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimaging_diag_loc_Caption = "";
         Ddo_br_medicalimagingid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimagingid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimagingid_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimagingid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimagingid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medicalimagingid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimagingid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimagingid_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimagingid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimagingid_Cls = "ColumnSettings";
         Ddo_br_medicalimagingid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimagingid_Caption = "";
         Ddo_br_medicalimaging_diagid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_diagid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_diagid_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_diagid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_diagid_Includefilter = Convert.ToBoolean( 0);
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
         Form.Caption = "选择影像学诊断意见";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV13BR_MedicalImaging_DiagIDTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV15BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV17BR_MedicalImaging_Diag_LocTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV19BR_MedicalImaging_Diag_OrganTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_Diag_DisTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_DISTITLEFILTERDATA',pic:''},{av:'AV29BR_MedicalImaging_Diag_NoTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_NOTITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImaging_DiagID_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_DiagID_Title',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Title'},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Loc_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Loc_Title',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Organ_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Organ_Title',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Dis_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Dis_Title',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_No_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_No_Title',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Title'},{av:'AV25GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV26GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV27GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E115N2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E125N2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_DIAGID.ONOPTIONCLICKED","{handler:'E135N2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medicalimaging_diagid_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_DIAGID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_DIAGID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_diagid_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAGID',prop:'SortedStatus'},{av:'AV13BR_MedicalImaging_DiagIDTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV15BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV17BR_MedicalImaging_Diag_LocTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV19BR_MedicalImaging_Diag_OrganTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_Diag_DisTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_DISTITLEFILTERDATA',pic:''},{av:'AV29BR_MedicalImaging_Diag_NoTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_NOTITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImaging_DiagID_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_DiagID_Title',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Title'},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Loc_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Loc_Title',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Organ_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Organ_Title',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Dis_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Dis_Title',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_No_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_No_Title',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Title'},{av:'AV25GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV26GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV27GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGINGID.ONOPTIONCLICKED","{handler:'E145N2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medicalimagingid_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGINGID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGINGID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimagingid_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGINGID',prop:'SortedStatus'},{av:'AV13BR_MedicalImaging_DiagIDTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV15BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV17BR_MedicalImaging_Diag_LocTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV19BR_MedicalImaging_Diag_OrganTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_Diag_DisTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_DISTITLEFILTERDATA',pic:''},{av:'AV29BR_MedicalImaging_Diag_NoTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_NOTITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImaging_DiagID_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_DiagID_Title',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Title'},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Loc_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Loc_Title',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Organ_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Organ_Title',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Dis_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Dis_Title',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_No_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_No_Title',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Title'},{av:'AV25GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV26GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV27GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_DIAG_LOC.ONOPTIONCLICKED","{handler:'E155N2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medicalimaging_diag_loc_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_LOC',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_DIAG_LOC.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_diag_loc_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_LOC',prop:'SortedStatus'},{av:'AV13BR_MedicalImaging_DiagIDTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV15BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV17BR_MedicalImaging_Diag_LocTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV19BR_MedicalImaging_Diag_OrganTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_Diag_DisTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_DISTITLEFILTERDATA',pic:''},{av:'AV29BR_MedicalImaging_Diag_NoTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_NOTITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImaging_DiagID_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_DiagID_Title',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Title'},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Loc_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Loc_Title',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Organ_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Organ_Title',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Dis_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Dis_Title',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_No_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_No_Title',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Title'},{av:'AV25GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV26GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV27GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_DIAG_ORGAN.ONOPTIONCLICKED","{handler:'E165N2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medicalimaging_diag_organ_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_ORGAN',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_DIAG_ORGAN.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_diag_organ_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_ORGAN',prop:'SortedStatus'},{av:'AV13BR_MedicalImaging_DiagIDTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV15BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV17BR_MedicalImaging_Diag_LocTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV19BR_MedicalImaging_Diag_OrganTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_Diag_DisTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_DISTITLEFILTERDATA',pic:''},{av:'AV29BR_MedicalImaging_Diag_NoTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_NOTITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImaging_DiagID_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_DiagID_Title',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Title'},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Loc_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Loc_Title',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Organ_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Organ_Title',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Dis_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Dis_Title',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_No_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_No_Title',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Title'},{av:'AV25GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV26GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV27GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_DIAG_DIS.ONOPTIONCLICKED","{handler:'E175N2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medicalimaging_diag_dis_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_DIS',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_DIAG_DIS.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_diag_dis_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_DIS',prop:'SortedStatus'},{av:'AV13BR_MedicalImaging_DiagIDTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV15BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV17BR_MedicalImaging_Diag_LocTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV19BR_MedicalImaging_Diag_OrganTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_Diag_DisTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_DISTITLEFILTERDATA',pic:''},{av:'AV29BR_MedicalImaging_Diag_NoTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_NOTITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImaging_DiagID_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_DiagID_Title',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Title'},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Loc_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Loc_Title',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Organ_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Organ_Title',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Dis_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Dis_Title',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_No_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_No_Title',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Title'},{av:'AV25GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV26GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV27GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_DIAG_NO.ONOPTIONCLICKED","{handler:'E185N2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_ORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_DISTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_DIAG_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medicalimaging_diag_no_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_NO',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_DIAG_NO.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_diag_no_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_DIAG_NO',prop:'SortedStatus'},{av:'AV13BR_MedicalImaging_DiagIDTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAGIDTITLEFILTERDATA',pic:''},{av:'AV15BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV17BR_MedicalImaging_Diag_LocTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_LOCTITLEFILTERDATA',pic:''},{av:'AV19BR_MedicalImaging_Diag_OrganTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_ORGANTITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_Diag_DisTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_DISTITLEFILTERDATA',pic:''},{av:'AV29BR_MedicalImaging_Diag_NoTitleFilterData',fld:'vBR_MEDICALIMAGING_DIAG_NOTITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImaging_DiagID_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_DiagID_Title',ctrl:'BR_MEDICALIMAGING_DIAGID',prop:'Title'},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Loc_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Loc_Title',ctrl:'BR_MEDICALIMAGING_DIAG_LOC',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Organ_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Organ_Title',ctrl:'BR_MEDICALIMAGING_DIAG_ORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_Dis_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_Dis_Title',ctrl:'BR_MEDICALIMAGING_DIAG_DIS',prop:'Title'},{av:'edtBR_MedicalImaging_Diag_No_Titleformat',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Titleformat'},{av:'edtBR_MedicalImaging_Diag_No_Title',ctrl:'BR_MEDICALIMAGING_DIAG_NO',prop:'Title'},{av:'AV25GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV26GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV27GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E215N2',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV28Select',fld:'vSELECT',pic:''},{av:'edtavSelect_Tooltiptext',ctrl:'vSELECT',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E225N2',iparms:[{av:'A270BR_MedicalImaging_DiagID',fld:'BR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A271BR_MedicalImaging_Diag_Loc',fld:'BR_MEDICALIMAGING_DIAG_LOC',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV8InOutBR_MedicalImaging_DiagID',fld:'vINOUTBR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV9InOutBR_MedicalImaging_Diag_Loc',fld:'vINOUTBR_MEDICALIMAGING_DIAG_LOC',pic:''}]}");
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
         wcpOAV9InOutBR_MedicalImaging_Diag_Loc = "";
         Gridpaginationbar_Selectedpage = "";
         Ddo_br_medicalimaging_diagid_Activeeventkey = "";
         Ddo_br_medicalimagingid_Activeeventkey = "";
         Ddo_br_medicalimaging_diag_loc_Activeeventkey = "";
         Ddo_br_medicalimaging_diag_organ_Activeeventkey = "";
         Ddo_br_medicalimaging_diag_dis_Activeeventkey = "";
         Ddo_br_medicalimaging_diag_no_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV14ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace = "";
         AV16ddo_BR_MedicalImagingIDTitleControlIdToReplace = "";
         AV18ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace = "";
         AV20ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace = "";
         AV22ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace = "";
         AV30ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace = "";
         GXKey = "";
         AV33Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV23DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV13BR_MedicalImaging_DiagIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15BR_MedicalImagingIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17BR_MedicalImaging_Diag_LocTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19BR_MedicalImaging_Diag_OrganTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_MedicalImaging_Diag_DisTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV29BR_MedicalImaging_Diag_NoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_medicalimaging_diagid_Sortedstatus = "";
         Ddo_br_medicalimagingid_Sortedstatus = "";
         Ddo_br_medicalimaging_diag_loc_Sortedstatus = "";
         Ddo_br_medicalimaging_diag_organ_Sortedstatus = "";
         Ddo_br_medicalimaging_diag_dis_Sortedstatus = "";
         Ddo_br_medicalimaging_diag_no_Sortedstatus = "";
         GX_FocusControl = "";
         sPrefix = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV28Select = "";
         A271BR_MedicalImaging_Diag_Loc = "";
         A272BR_MedicalImaging_Diag_Organ = "";
         A273BR_MedicalImaging_Diag_Dis = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_medicalimaging_diagid = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_br_medicalimagingid = new GXUserControl();
         ucDdo_br_medicalimaging_diag_loc = new GXUserControl();
         ucDdo_br_medicalimaging_diag_organ = new GXUserControl();
         ucDdo_br_medicalimaging_diag_dis = new GXUserControl();
         ucDdo_br_medicalimaging_diag_no = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV34Select_GXI = "";
         scmdbuf = "";
         H005N2_A517BR_MedicalImaging_Diag_No = new long[1] ;
         H005N2_n517BR_MedicalImaging_Diag_No = new bool[] {false} ;
         H005N2_A273BR_MedicalImaging_Diag_Dis = new String[] {""} ;
         H005N2_n273BR_MedicalImaging_Diag_Dis = new bool[] {false} ;
         H005N2_A272BR_MedicalImaging_Diag_Organ = new String[] {""} ;
         H005N2_n272BR_MedicalImaging_Diag_Organ = new bool[] {false} ;
         H005N2_A271BR_MedicalImaging_Diag_Loc = new String[] {""} ;
         H005N2_n271BR_MedicalImaging_Diag_Loc = new bool[] {false} ;
         H005N2_A225BR_MedicalImagingID = new long[1] ;
         H005N2_n225BR_MedicalImagingID = new bool[] {false} ;
         H005N2_A270BR_MedicalImaging_DiagID = new long[1] ;
         H005N3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_medicalimaging_diagprompt__default(),
            new Object[][] {
                new Object[] {
               H005N2_A517BR_MedicalImaging_Diag_No, H005N2_n517BR_MedicalImaging_Diag_No, H005N2_A273BR_MedicalImaging_Diag_Dis, H005N2_n273BR_MedicalImaging_Diag_Dis, H005N2_A272BR_MedicalImaging_Diag_Organ, H005N2_n272BR_MedicalImaging_Diag_Organ, H005N2_A271BR_MedicalImaging_Diag_Loc, H005N2_n271BR_MedicalImaging_Diag_Loc, H005N2_A225BR_MedicalImagingID, H005N2_n225BR_MedicalImagingID,
               H005N2_A270BR_MedicalImaging_DiagID
               }
               , new Object[] {
               H005N3_AGRID_nRecordCount
               }
            }
         );
         AV33Pgmname = "BR_MedicalImaging_DiagPrompt";
         /* GeneXus formulas. */
         AV33Pgmname = "BR_MedicalImaging_DiagPrompt";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_12 ;
      private short nGXsfl_12_idx=1 ;
      private short GRID_nEOF ;
      private short AV11OrderedBy ;
      private short initialized ;
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
      private int divTablemain_Height ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
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
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV24PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavSelect_Enabled ;
      private int edtavSelect_Visible ;
      private long AV8InOutBR_MedicalImaging_DiagID ;
      private long wcpOAV8InOutBR_MedicalImaging_DiagID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV25GridCurrentPage ;
      private long AV27GridRecordCount ;
      private long AV26GridPageSize ;
      private long A270BR_MedicalImaging_DiagID ;
      private long A225BR_MedicalImagingID ;
      private long A517BR_MedicalImaging_Diag_No ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_medicalimaging_diagid_Activeeventkey ;
      private String Ddo_br_medicalimagingid_Activeeventkey ;
      private String Ddo_br_medicalimaging_diag_loc_Activeeventkey ;
      private String Ddo_br_medicalimaging_diag_organ_Activeeventkey ;
      private String Ddo_br_medicalimaging_diag_dis_Activeeventkey ;
      private String Ddo_br_medicalimaging_diag_no_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_12_idx="0001" ;
      private String GXKey ;
      private String AV33Pgmname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
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
      private String Ddo_br_medicalimaging_diagid_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_diagid_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_diagid_Sortedstatus ;
      private String Ddo_br_medicalimaging_diagid_Sortasc ;
      private String Ddo_br_medicalimaging_diagid_Sortdsc ;
      private String Ddo_br_medicalimaging_diagid_Searchbuttontext ;
      private String Ddo_br_medicalimagingid_Caption ;
      private String Ddo_br_medicalimagingid_Tooltip ;
      private String Ddo_br_medicalimagingid_Cls ;
      private String Ddo_br_medicalimagingid_Dropdownoptionstype ;
      private String Ddo_br_medicalimagingid_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimagingid_Sortedstatus ;
      private String Ddo_br_medicalimagingid_Sortasc ;
      private String Ddo_br_medicalimagingid_Sortdsc ;
      private String Ddo_br_medicalimagingid_Searchbuttontext ;
      private String Ddo_br_medicalimaging_diag_loc_Caption ;
      private String Ddo_br_medicalimaging_diag_loc_Tooltip ;
      private String Ddo_br_medicalimaging_diag_loc_Cls ;
      private String Ddo_br_medicalimaging_diag_loc_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_diag_loc_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_diag_loc_Sortedstatus ;
      private String Ddo_br_medicalimaging_diag_loc_Sortasc ;
      private String Ddo_br_medicalimaging_diag_loc_Sortdsc ;
      private String Ddo_br_medicalimaging_diag_loc_Searchbuttontext ;
      private String Ddo_br_medicalimaging_diag_organ_Caption ;
      private String Ddo_br_medicalimaging_diag_organ_Tooltip ;
      private String Ddo_br_medicalimaging_diag_organ_Cls ;
      private String Ddo_br_medicalimaging_diag_organ_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_diag_organ_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_diag_organ_Sortedstatus ;
      private String Ddo_br_medicalimaging_diag_organ_Sortasc ;
      private String Ddo_br_medicalimaging_diag_organ_Sortdsc ;
      private String Ddo_br_medicalimaging_diag_organ_Searchbuttontext ;
      private String Ddo_br_medicalimaging_diag_dis_Caption ;
      private String Ddo_br_medicalimaging_diag_dis_Tooltip ;
      private String Ddo_br_medicalimaging_diag_dis_Cls ;
      private String Ddo_br_medicalimaging_diag_dis_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_diag_dis_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_diag_dis_Sortedstatus ;
      private String Ddo_br_medicalimaging_diag_dis_Sortasc ;
      private String Ddo_br_medicalimaging_diag_dis_Sortdsc ;
      private String Ddo_br_medicalimaging_diag_dis_Searchbuttontext ;
      private String Ddo_br_medicalimaging_diag_no_Caption ;
      private String Ddo_br_medicalimaging_diag_no_Tooltip ;
      private String Ddo_br_medicalimaging_diag_no_Cls ;
      private String Ddo_br_medicalimaging_diag_no_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_diag_no_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_diag_no_Sortedstatus ;
      private String Ddo_br_medicalimaging_diag_no_Sortasc ;
      private String Ddo_br_medicalimaging_diag_no_Sortdsc ;
      private String Ddo_br_medicalimaging_diag_no_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
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
      private String edtavSelect_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_medicalimaging_diagid_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
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
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavSelect_Internalname ;
      private String edtBR_MedicalImaging_DiagID_Internalname ;
      private String edtBR_MedicalImagingID_Internalname ;
      private String edtBR_MedicalImaging_Diag_Loc_Internalname ;
      private String edtBR_MedicalImaging_Diag_Organ_Internalname ;
      private String edtBR_MedicalImaging_Diag_Dis_Internalname ;
      private String edtBR_MedicalImaging_Diag_No_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_12_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavSelect_Jsonclick ;
      private String ROClassString ;
      private String edtBR_MedicalImaging_DiagID_Jsonclick ;
      private String edtBR_MedicalImagingID_Jsonclick ;
      private String edtBR_MedicalImaging_Diag_Loc_Jsonclick ;
      private String edtBR_MedicalImaging_Diag_Organ_Jsonclick ;
      private String edtBR_MedicalImaging_Diag_Dis_Jsonclick ;
      private String edtBR_MedicalImaging_Diag_No_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV12OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_br_medicalimaging_diagid_Includesortasc ;
      private bool Ddo_br_medicalimaging_diagid_Includesortdsc ;
      private bool Ddo_br_medicalimaging_diagid_Includefilter ;
      private bool Ddo_br_medicalimaging_diagid_Includedatalist ;
      private bool Ddo_br_medicalimagingid_Includesortasc ;
      private bool Ddo_br_medicalimagingid_Includesortdsc ;
      private bool Ddo_br_medicalimagingid_Includefilter ;
      private bool Ddo_br_medicalimagingid_Includedatalist ;
      private bool Ddo_br_medicalimaging_diag_loc_Includesortasc ;
      private bool Ddo_br_medicalimaging_diag_loc_Includesortdsc ;
      private bool Ddo_br_medicalimaging_diag_loc_Includefilter ;
      private bool Ddo_br_medicalimaging_diag_loc_Includedatalist ;
      private bool Ddo_br_medicalimaging_diag_organ_Includesortasc ;
      private bool Ddo_br_medicalimaging_diag_organ_Includesortdsc ;
      private bool Ddo_br_medicalimaging_diag_organ_Includefilter ;
      private bool Ddo_br_medicalimaging_diag_organ_Includedatalist ;
      private bool Ddo_br_medicalimaging_diag_dis_Includesortasc ;
      private bool Ddo_br_medicalimaging_diag_dis_Includesortdsc ;
      private bool Ddo_br_medicalimaging_diag_dis_Includefilter ;
      private bool Ddo_br_medicalimaging_diag_dis_Includedatalist ;
      private bool Ddo_br_medicalimaging_diag_no_Includesortasc ;
      private bool Ddo_br_medicalimaging_diag_no_Includesortdsc ;
      private bool Ddo_br_medicalimaging_diag_no_Includefilter ;
      private bool Ddo_br_medicalimaging_diag_no_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_12_Refreshing=false ;
      private bool n225BR_MedicalImagingID ;
      private bool n271BR_MedicalImaging_Diag_Loc ;
      private bool n272BR_MedicalImaging_Diag_Organ ;
      private bool n273BR_MedicalImaging_Diag_Dis ;
      private bool n517BR_MedicalImaging_Diag_No ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool gx_refresh_fired ;
      private bool AV28Select_IsBlob ;
      private String AV9InOutBR_MedicalImaging_Diag_Loc ;
      private String wcpOAV9InOutBR_MedicalImaging_Diag_Loc ;
      private String AV14ddo_BR_MedicalImaging_DiagIDTitleControlIdToReplace ;
      private String AV16ddo_BR_MedicalImagingIDTitleControlIdToReplace ;
      private String AV18ddo_BR_MedicalImaging_Diag_LocTitleControlIdToReplace ;
      private String AV20ddo_BR_MedicalImaging_Diag_OrganTitleControlIdToReplace ;
      private String AV22ddo_BR_MedicalImaging_Diag_DisTitleControlIdToReplace ;
      private String AV30ddo_BR_MedicalImaging_Diag_NoTitleControlIdToReplace ;
      private String A271BR_MedicalImaging_Diag_Loc ;
      private String A272BR_MedicalImaging_Diag_Organ ;
      private String A273BR_MedicalImaging_Diag_Dis ;
      private String AV34Select_GXI ;
      private String AV28Select ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_medicalimaging_diagid ;
      private GXUserControl ucDdo_br_medicalimagingid ;
      private GXUserControl ucDdo_br_medicalimaging_diag_loc ;
      private GXUserControl ucDdo_br_medicalimaging_diag_organ ;
      private GXUserControl ucDdo_br_medicalimaging_diag_dis ;
      private GXUserControl ucDdo_br_medicalimaging_diag_no ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private long aP0_InOutBR_MedicalImaging_DiagID ;
      private String aP1_InOutBR_MedicalImaging_Diag_Loc ;
      private IDataStoreProvider pr_default ;
      private long[] H005N2_A517BR_MedicalImaging_Diag_No ;
      private bool[] H005N2_n517BR_MedicalImaging_Diag_No ;
      private String[] H005N2_A273BR_MedicalImaging_Diag_Dis ;
      private bool[] H005N2_n273BR_MedicalImaging_Diag_Dis ;
      private String[] H005N2_A272BR_MedicalImaging_Diag_Organ ;
      private bool[] H005N2_n272BR_MedicalImaging_Diag_Organ ;
      private String[] H005N2_A271BR_MedicalImaging_Diag_Loc ;
      private bool[] H005N2_n271BR_MedicalImaging_Diag_Loc ;
      private long[] H005N2_A225BR_MedicalImagingID ;
      private bool[] H005N2_n225BR_MedicalImagingID ;
      private long[] H005N2_A270BR_MedicalImaging_DiagID ;
      private long[] H005N3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV13BR_MedicalImaging_DiagIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV15BR_MedicalImagingIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV17BR_MedicalImaging_Diag_LocTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV19BR_MedicalImaging_Diag_OrganTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV21BR_MedicalImaging_Diag_DisTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV29BR_MedicalImaging_Diag_NoTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV23DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class br_medicalimaging_diagprompt__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H005N2( IGxContext context ,
                                             short AV11OrderedBy ,
                                             bool AV12OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [3] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [BR_MedicalImaging_Diag_No], [BR_MedicalImaging_Diag_Dis], [BR_MedicalImaging_Diag_Organ], [BR_MedicalImaging_Diag_Loc], [BR_MedicalImagingID], [BR_MedicalImaging_DiagID]";
         sFromString = " FROM [BR_MedicalImaging_Diag] WITH (NOLOCK)";
         sOrderString = "";
         if ( ( AV11OrderedBy == 1 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicalImaging_DiagID]";
         }
         else if ( ( AV11OrderedBy == 1 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicalImaging_DiagID] DESC";
         }
         else if ( ( AV11OrderedBy == 2 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicalImagingID]";
         }
         else if ( ( AV11OrderedBy == 2 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicalImagingID] DESC";
         }
         else if ( ( AV11OrderedBy == 3 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicalImaging_Diag_Loc]";
         }
         else if ( ( AV11OrderedBy == 3 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicalImaging_Diag_Loc] DESC";
         }
         else if ( ( AV11OrderedBy == 4 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicalImaging_Diag_Organ]";
         }
         else if ( ( AV11OrderedBy == 4 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicalImaging_Diag_Organ] DESC";
         }
         else if ( ( AV11OrderedBy == 5 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicalImaging_Diag_Dis]";
         }
         else if ( ( AV11OrderedBy == 5 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicalImaging_Diag_Dis] DESC";
         }
         else if ( ( AV11OrderedBy == 6 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicalImaging_Diag_No]";
         }
         else if ( ( AV11OrderedBy == 6 ) && ( AV12OrderedDsc ) )
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

      protected Object[] conditional_H005N3( IGxContext context ,
                                             short AV11OrderedBy ,
                                             bool AV12OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [BR_MedicalImaging_Diag] WITH (NOLOCK)";
         if ( ( AV11OrderedBy == 1 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 1 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 2 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 2 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 3 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 3 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 4 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 4 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 5 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 5 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 6 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 6 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( true )
         {
            scmdbuf = scmdbuf + "";
         }
         GXv_Object5[0] = scmdbuf;
         return GXv_Object5 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H005N2(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
               case 1 :
                     return conditional_H005N3(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
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
          Object[] prmH005N2 ;
          prmH005N2 = new Object[] {
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH005N3 ;
          prmH005N3 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H005N2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005N2,11,0,true,false )
             ,new CursorDef("H005N3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005N3,1,0,true,false )
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
