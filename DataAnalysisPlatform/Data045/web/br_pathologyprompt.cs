/*
               File: BR_PathologyPrompt
        Description: 选择病理学
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:13:16.70
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
   public class br_pathologyprompt : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public br_pathologyprompt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_pathologyprompt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_InOutBR_PathologyID ,
                           ref long aP1_InOutBR_PathologyID_TestID )
      {
         this.AV8InOutBR_PathologyID = aP0_InOutBR_PathologyID;
         this.AV9InOutBR_PathologyID_TestID = aP1_InOutBR_PathologyID_TestID;
         executePrivate();
         aP0_InOutBR_PathologyID=this.AV8InOutBR_PathologyID;
         aP1_InOutBR_PathologyID_TestID=this.AV9InOutBR_PathologyID_TestID;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbBR_Pathology_N = new GXCombobox();
         cmbBR_Pathology_M = new GXCombobox();
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
               AV14ddo_BR_PathologyIDTitleControlIdToReplace = GetNextPar( );
               AV16ddo_BR_EncounterIDTitleControlIdToReplace = GetNextPar( );
               AV18ddo_BR_Information_PatientNoTitleControlIdToReplace = GetNextPar( );
               AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace = GetNextPar( );
               AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace = GetNextPar( );
               AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace = GetNextPar( );
               AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace = GetNextPar( );
               AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace = GetNextPar( );
               AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace = GetNextPar( );
               AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace = GetNextPar( );
               AV38ddo_BR_Pathology_TTitleControlIdToReplace = GetNextPar( );
               AV40ddo_BR_Pathology_NTitleControlIdToReplace = GetNextPar( );
               AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace = GetNextPar( );
               AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace = GetNextPar( );
               AV46ddo_BR_Pathology_MTitleControlIdToReplace = GetNextPar( );
               AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_PathologyIDTitleControlIdToReplace, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_Information_PatientNoTitleControlIdToReplace, AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace, AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace, AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace, AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace, AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace, AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace, AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace, AV38ddo_BR_Pathology_TTitleControlIdToReplace, AV40ddo_BR_Pathology_NTitleControlIdToReplace, AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace, AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace, AV46ddo_BR_Pathology_MTitleControlIdToReplace, AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace) ;
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
               AV8InOutBR_PathologyID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_PathologyID), 18, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV9InOutBR_PathologyID_TestID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutBR_PathologyID_TestID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9InOutBR_PathologyID_TestID), 10, 0)));
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
            PA5M2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV53Pgmname = "BR_PathologyPrompt";
               context.Gx_err = 0;
               WS5M2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE5M2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202281513174", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-zh.js", "?"+context.GetBuildNumber( 127771), false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_pathologyprompt.aspx") + "?" + UrlEncode("" +AV8InOutBR_PathologyID) + "," + UrlEncode("" +AV9InOutBR_PathologyID_TestID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV33GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV35GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV34GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV31DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV31DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGYIDTITLEFILTERDATA", AV13BR_PathologyIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGYIDTITLEFILTERDATA", AV13BR_PathologyIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTERIDTITLEFILTERDATA", AV15BR_EncounterIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTERIDTITLEFILTERDATA", AV15BR_EncounterIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_INFORMATION_PATIENTNOTITLEFILTERDATA", AV17BR_Information_PatientNoTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_INFORMATION_PATIENTNOTITLEFILTERDATA", AV17BR_Information_PatientNoTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA", AV19BR_PathologyID_TestIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA", AV19BR_PathologyID_TestIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGYID_PADATETITLEFILTERDATA", AV21BR_PathologyID_PADateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGYID_PADATETITLEFILTERDATA", AV21BR_PathologyID_PADateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA", AV23BR_PathologyID_PAHospTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA", AV23BR_PathologyID_PAHospTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGYID_PAAGETITLEFILTERDATA", AV25BR_PathologyID_PAAgeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGYID_PAAGETITLEFILTERDATA", AV25BR_PathologyID_PAAgeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA", AV27BR_PathologyID_PrePaDiaTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA", AV27BR_PathologyID_PrePaDiaTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA", AV29BR_PathologyID_PAResultTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA", AV29BR_PathologyID_PAResultTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA", AV49BR_Pathology_Dia_NameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA", AV49BR_Pathology_Dia_NameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_TTITLEFILTERDATA", AV37BR_Pathology_TTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_TTITLEFILTERDATA", AV37BR_Pathology_TTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_NTITLEFILTERDATA", AV39BR_Pathology_NTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_NTITLEFILTERDATA", AV39BR_Pathology_NTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA", AV41BR_Pathology_LymphNumTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA", AV41BR_Pathology_LymphNumTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA", AV43BR_Pathology_LymphRateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA", AV43BR_Pathology_LymphRateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_MTITLEFILTERDATA", AV45BR_Pathology_MTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_MTITLEFILTERDATA", AV45BR_Pathology_MTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_METALOCTITLEFILTERDATA", AV47BR_Pathology_MetaLocTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_METALOCTITLEFILTERDATA", AV47BR_Pathology_MetaLocTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vINOUTBR_PATHOLOGYID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8InOutBR_PathologyID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINOUTBR_PATHOLOGYID_TESTID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9InOutBR_PathologyID_TestID), 10, 0, ".", "")));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Caption", StringUtil.RTrim( Ddo_br_pathologyid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Tooltip", StringUtil.RTrim( Ddo_br_pathologyid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Cls", StringUtil.RTrim( Ddo_br_pathologyid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathologyid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathologyid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathologyid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathologyid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Sortedstatus", StringUtil.RTrim( Ddo_br_pathologyid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Includefilter", StringUtil.BoolToStr( Ddo_br_pathologyid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathologyid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Sortasc", StringUtil.RTrim( Ddo_br_pathologyid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Sortdsc", StringUtil.RTrim( Ddo_br_pathologyid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathologyid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Caption", StringUtil.RTrim( Ddo_br_encounterid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Tooltip", StringUtil.RTrim( Ddo_br_encounterid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Cls", StringUtil.RTrim( Ddo_br_encounterid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounterid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounterid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounterid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounterid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Sortedstatus", StringUtil.RTrim( Ddo_br_encounterid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Includefilter", StringUtil.BoolToStr( Ddo_br_encounterid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounterid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Sortasc", StringUtil.RTrim( Ddo_br_encounterid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Sortdsc", StringUtil.RTrim( Ddo_br_encounterid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounterid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Caption", StringUtil.RTrim( Ddo_br_information_patientno_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Tooltip", StringUtil.RTrim( Ddo_br_information_patientno_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Cls", StringUtil.RTrim( Ddo_br_information_patientno_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_information_patientno_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_information_patientno_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Includesortasc", StringUtil.BoolToStr( Ddo_br_information_patientno_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Includesortdsc", StringUtil.BoolToStr( Ddo_br_information_patientno_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Sortedstatus", StringUtil.RTrim( Ddo_br_information_patientno_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Includefilter", StringUtil.BoolToStr( Ddo_br_information_patientno_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Includedatalist", StringUtil.BoolToStr( Ddo_br_information_patientno_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Sortasc", StringUtil.RTrim( Ddo_br_information_patientno_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Sortdsc", StringUtil.RTrim( Ddo_br_information_patientno_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Searchbuttontext", StringUtil.RTrim( Ddo_br_information_patientno_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Caption", StringUtil.RTrim( Ddo_br_pathologyid_testid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Tooltip", StringUtil.RTrim( Ddo_br_pathologyid_testid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Cls", StringUtil.RTrim( Ddo_br_pathologyid_testid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathologyid_testid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathologyid_testid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathologyid_testid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathologyid_testid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Sortedstatus", StringUtil.RTrim( Ddo_br_pathologyid_testid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Includefilter", StringUtil.BoolToStr( Ddo_br_pathologyid_testid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathologyid_testid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Sortasc", StringUtil.RTrim( Ddo_br_pathologyid_testid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Sortdsc", StringUtil.RTrim( Ddo_br_pathologyid_testid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathologyid_testid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Caption", StringUtil.RTrim( Ddo_br_pathologyid_padate_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Tooltip", StringUtil.RTrim( Ddo_br_pathologyid_padate_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Cls", StringUtil.RTrim( Ddo_br_pathologyid_padate_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathologyid_padate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathologyid_padate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathologyid_padate_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathologyid_padate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Sortedstatus", StringUtil.RTrim( Ddo_br_pathologyid_padate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Includefilter", StringUtil.BoolToStr( Ddo_br_pathologyid_padate_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathologyid_padate_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Sortasc", StringUtil.RTrim( Ddo_br_pathologyid_padate_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Sortdsc", StringUtil.RTrim( Ddo_br_pathologyid_padate_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathologyid_padate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Caption", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Tooltip", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Cls", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathologyid_pahosp_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathologyid_pahosp_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Sortedstatus", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Includefilter", StringUtil.BoolToStr( Ddo_br_pathologyid_pahosp_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathologyid_pahosp_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Sortasc", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Sortdsc", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Caption", StringUtil.RTrim( Ddo_br_pathologyid_paage_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Tooltip", StringUtil.RTrim( Ddo_br_pathologyid_paage_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Cls", StringUtil.RTrim( Ddo_br_pathologyid_paage_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathologyid_paage_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathologyid_paage_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathologyid_paage_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathologyid_paage_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Sortedstatus", StringUtil.RTrim( Ddo_br_pathologyid_paage_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Includefilter", StringUtil.BoolToStr( Ddo_br_pathologyid_paage_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathologyid_paage_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Sortasc", StringUtil.RTrim( Ddo_br_pathologyid_paage_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Sortdsc", StringUtil.RTrim( Ddo_br_pathologyid_paage_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathologyid_paage_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Caption", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Tooltip", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Cls", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathologyid_prepadia_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathologyid_prepadia_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Sortedstatus", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Includefilter", StringUtil.BoolToStr( Ddo_br_pathologyid_prepadia_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathologyid_prepadia_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Sortasc", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Sortdsc", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Caption", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Tooltip", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Cls", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathologyid_paresult_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathologyid_paresult_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Sortedstatus", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Includefilter", StringUtil.BoolToStr( Ddo_br_pathologyid_paresult_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathologyid_paresult_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Sortasc", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Sortdsc", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Caption", StringUtil.RTrim( Ddo_br_pathology_dia_name_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Tooltip", StringUtil.RTrim( Ddo_br_pathology_dia_name_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Cls", StringUtil.RTrim( Ddo_br_pathology_dia_name_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_dia_name_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_dia_name_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_dia_name_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_dia_name_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_dia_name_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_dia_name_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_dia_name_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Sortasc", StringUtil.RTrim( Ddo_br_pathology_dia_name_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_dia_name_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_dia_name_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Caption", StringUtil.RTrim( Ddo_br_pathology_t_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Tooltip", StringUtil.RTrim( Ddo_br_pathology_t_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Cls", StringUtil.RTrim( Ddo_br_pathology_t_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_t_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_t_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_t_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_t_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_t_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_t_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_t_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Sortasc", StringUtil.RTrim( Ddo_br_pathology_t_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_t_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_t_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Caption", StringUtil.RTrim( Ddo_br_pathology_n_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Tooltip", StringUtil.RTrim( Ddo_br_pathology_n_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Cls", StringUtil.RTrim( Ddo_br_pathology_n_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_n_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_n_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_n_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_n_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_n_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_n_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_n_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Sortasc", StringUtil.RTrim( Ddo_br_pathology_n_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_n_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_n_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Caption", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Tooltip", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Cls", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_lymphnum_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_lymphnum_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_lymphnum_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_lymphnum_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Sortasc", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Caption", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Tooltip", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Cls", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_lymphrate_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_lymphrate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_lymphrate_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_lymphrate_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Sortasc", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Caption", StringUtil.RTrim( Ddo_br_pathology_m_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Tooltip", StringUtil.RTrim( Ddo_br_pathology_m_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Cls", StringUtil.RTrim( Ddo_br_pathology_m_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_m_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_m_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_m_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_m_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_m_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_m_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_m_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Sortasc", StringUtil.RTrim( Ddo_br_pathology_m_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_m_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_m_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Caption", StringUtil.RTrim( Ddo_br_pathology_metaloc_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Tooltip", StringUtil.RTrim( Ddo_br_pathology_metaloc_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Cls", StringUtil.RTrim( Ddo_br_pathology_metaloc_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_metaloc_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_metaloc_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_metaloc_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_metaloc_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_metaloc_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_metaloc_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_metaloc_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Sortasc", StringUtil.RTrim( Ddo_br_pathology_metaloc_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_metaloc_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_metaloc_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey", StringUtil.RTrim( Ddo_br_information_patientno_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_testid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_padate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_paage_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_dia_name_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_t_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_n_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_m_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_metaloc_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey", StringUtil.RTrim( Ddo_br_information_patientno_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_testid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_padate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_paage_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_dia_name_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_t_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_n_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_m_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_metaloc_Activeeventkey));
      }

      protected void RenderHtmlCloseForm5M2( )
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
         return "BR_PathologyPrompt" ;
      }

      public override String GetPgmdesc( )
      {
         return "选择病理学" ;
      }

      protected void WB5M0( )
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
               if ( edtBR_PathologyID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_PathologyID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_PathologyID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_EncounterID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_EncounterID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_EncounterID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(410), 4, 0))+"px"+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Information_PatientNo_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Information_PatientNo_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Information_PatientNo_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_PathologyID_TestID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_PathologyID_TestID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_PathologyID_TestID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_PathologyID_PADate_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_PathologyID_PADate_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_PathologyID_PADate_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_PathologyID_PAHosp_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_PathologyID_PAHosp_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_PathologyID_PAHosp_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_PathologyID_PAAge_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_PathologyID_PAAge_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_PathologyID_PAAge_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_PathologyID_PrePaDia_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_PathologyID_PrePaDia_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_PathologyID_PrePaDia_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_PathologyID_PAResult_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_PathologyID_PAResult_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_PathologyID_PAResult_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Pathology_Dia_Name_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_Dia_Name_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_Dia_Name_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Pathology_T_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_T_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_T_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( cmbBR_Pathology_N_Titleformat == 0 )
               {
                  context.SendWebValue( cmbBR_Pathology_N.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( cmbBR_Pathology_N.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Pathology_LymphNum_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_LymphNum_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_LymphNum_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Pathology_LymphRate_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_LymphRate_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_LymphRate_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( cmbBR_Pathology_M_Titleformat == 0 )
               {
                  context.SendWebValue( cmbBR_Pathology_M.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( cmbBR_Pathology_M.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Pathology_MetaLoc_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_MetaLoc_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_MetaLoc_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV36Select));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavSelect_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A226BR_PathologyID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_PathologyID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_PathologyID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_EncounterID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_EncounterID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A36BR_Information_PatientNo);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Information_PatientNo_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Information_PatientNo_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A237BR_PathologyID_TestID), 10, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_PathologyID_TestID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_PathologyID_TestID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A238BR_PathologyID_PADate, "9999/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_PathologyID_PADate_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_PathologyID_PADate_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A239BR_PathologyID_PAHosp);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_PathologyID_PAHosp_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_PathologyID_PAHosp_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A240BR_PathologyID_PAAge), 3, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_PathologyID_PAAge_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_PathologyID_PAAge_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A241BR_PathologyID_PrePaDia);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_PathologyID_PrePaDia_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_PathologyID_PrePaDia_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A242BR_PathologyID_PAResult);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_PathologyID_PAResult_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_PathologyID_PAResult_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A326BR_Pathology_Dia_Name);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_Dia_Name_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_Dia_Name_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A314BR_Pathology_T, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_T_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_T_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A315BR_Pathology_N);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( cmbBR_Pathology_N.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbBR_Pathology_N_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A316BR_Pathology_LymphNum, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_LymphNum_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_LymphNum_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A317BR_Pathology_LymphRate);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_LymphRate_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_LymphRate_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A318BR_Pathology_M);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( cmbBR_Pathology_M.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbBR_Pathology_M_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A319BR_Pathology_MetaLoc);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_MetaLoc_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_MetaLoc_Titleformat), 4, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV33GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV35GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV34GridPageSize);
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
            ucDdo_br_pathologyid.SetProperty("Caption", Ddo_br_pathologyid_Caption);
            ucDdo_br_pathologyid.SetProperty("Tooltip", Ddo_br_pathologyid_Tooltip);
            ucDdo_br_pathologyid.SetProperty("Cls", Ddo_br_pathologyid_Cls);
            ucDdo_br_pathologyid.SetProperty("DropDownOptionsType", Ddo_br_pathologyid_Dropdownoptionstype);
            ucDdo_br_pathologyid.SetProperty("IncludeSortASC", Ddo_br_pathologyid_Includesortasc);
            ucDdo_br_pathologyid.SetProperty("IncludeSortDSC", Ddo_br_pathologyid_Includesortdsc);
            ucDdo_br_pathologyid.SetProperty("IncludeFilter", Ddo_br_pathologyid_Includefilter);
            ucDdo_br_pathologyid.SetProperty("IncludeDataList", Ddo_br_pathologyid_Includedatalist);
            ucDdo_br_pathologyid.SetProperty("SortASC", Ddo_br_pathologyid_Sortasc);
            ucDdo_br_pathologyid.SetProperty("SortDSC", Ddo_br_pathologyid_Sortdsc);
            ucDdo_br_pathologyid.SetProperty("SearchButtonText", Ddo_br_pathologyid_Searchbuttontext);
            ucDdo_br_pathologyid.SetProperty("DropDownOptionsTitleSettingsIcons", AV31DDO_TitleSettingsIcons);
            ucDdo_br_pathologyid.SetProperty("DropDownOptionsData", AV13BR_PathologyIDTitleFilterData);
            ucDdo_br_pathologyid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathologyid_Internalname, "DDO_BR_PATHOLOGYIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname, AV14ddo_BR_PathologyIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", 0, edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyPrompt.htm");
            /* User Defined Control */
            ucDdo_br_encounterid.SetProperty("Caption", Ddo_br_encounterid_Caption);
            ucDdo_br_encounterid.SetProperty("Tooltip", Ddo_br_encounterid_Tooltip);
            ucDdo_br_encounterid.SetProperty("Cls", Ddo_br_encounterid_Cls);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsType", Ddo_br_encounterid_Dropdownoptionstype);
            ucDdo_br_encounterid.SetProperty("IncludeSortASC", Ddo_br_encounterid_Includesortasc);
            ucDdo_br_encounterid.SetProperty("IncludeSortDSC", Ddo_br_encounterid_Includesortdsc);
            ucDdo_br_encounterid.SetProperty("IncludeFilter", Ddo_br_encounterid_Includefilter);
            ucDdo_br_encounterid.SetProperty("IncludeDataList", Ddo_br_encounterid_Includedatalist);
            ucDdo_br_encounterid.SetProperty("SortASC", Ddo_br_encounterid_Sortasc);
            ucDdo_br_encounterid.SetProperty("SortDSC", Ddo_br_encounterid_Sortdsc);
            ucDdo_br_encounterid.SetProperty("SearchButtonText", Ddo_br_encounterid_Searchbuttontext);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsTitleSettingsIcons", AV31DDO_TitleSettingsIcons);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsData", AV15BR_EncounterIDTitleFilterData);
            ucDdo_br_encounterid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounterid_Internalname, "DDO_BR_ENCOUNTERIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, AV16ddo_BR_EncounterIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,40);\"", 0, edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyPrompt.htm");
            /* User Defined Control */
            ucDdo_br_information_patientno.SetProperty("Caption", Ddo_br_information_patientno_Caption);
            ucDdo_br_information_patientno.SetProperty("Tooltip", Ddo_br_information_patientno_Tooltip);
            ucDdo_br_information_patientno.SetProperty("Cls", Ddo_br_information_patientno_Cls);
            ucDdo_br_information_patientno.SetProperty("DropDownOptionsType", Ddo_br_information_patientno_Dropdownoptionstype);
            ucDdo_br_information_patientno.SetProperty("IncludeSortASC", Ddo_br_information_patientno_Includesortasc);
            ucDdo_br_information_patientno.SetProperty("IncludeSortDSC", Ddo_br_information_patientno_Includesortdsc);
            ucDdo_br_information_patientno.SetProperty("IncludeFilter", Ddo_br_information_patientno_Includefilter);
            ucDdo_br_information_patientno.SetProperty("IncludeDataList", Ddo_br_information_patientno_Includedatalist);
            ucDdo_br_information_patientno.SetProperty("SortASC", Ddo_br_information_patientno_Sortasc);
            ucDdo_br_information_patientno.SetProperty("SortDSC", Ddo_br_information_patientno_Sortdsc);
            ucDdo_br_information_patientno.SetProperty("SearchButtonText", Ddo_br_information_patientno_Searchbuttontext);
            ucDdo_br_information_patientno.SetProperty("DropDownOptionsTitleSettingsIcons", AV31DDO_TitleSettingsIcons);
            ucDdo_br_information_patientno.SetProperty("DropDownOptionsData", AV17BR_Information_PatientNoTitleFilterData);
            ucDdo_br_information_patientno.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_information_patientno_Internalname, "DDO_BR_INFORMATION_PATIENTNOContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname, AV18ddo_BR_Information_PatientNoTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,42);\"", 0, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyPrompt.htm");
            /* User Defined Control */
            ucDdo_br_pathologyid_testid.SetProperty("Caption", Ddo_br_pathologyid_testid_Caption);
            ucDdo_br_pathologyid_testid.SetProperty("Tooltip", Ddo_br_pathologyid_testid_Tooltip);
            ucDdo_br_pathologyid_testid.SetProperty("Cls", Ddo_br_pathologyid_testid_Cls);
            ucDdo_br_pathologyid_testid.SetProperty("DropDownOptionsType", Ddo_br_pathologyid_testid_Dropdownoptionstype);
            ucDdo_br_pathologyid_testid.SetProperty("IncludeSortASC", Ddo_br_pathologyid_testid_Includesortasc);
            ucDdo_br_pathologyid_testid.SetProperty("IncludeSortDSC", Ddo_br_pathologyid_testid_Includesortdsc);
            ucDdo_br_pathologyid_testid.SetProperty("IncludeFilter", Ddo_br_pathologyid_testid_Includefilter);
            ucDdo_br_pathologyid_testid.SetProperty("IncludeDataList", Ddo_br_pathologyid_testid_Includedatalist);
            ucDdo_br_pathologyid_testid.SetProperty("SortASC", Ddo_br_pathologyid_testid_Sortasc);
            ucDdo_br_pathologyid_testid.SetProperty("SortDSC", Ddo_br_pathologyid_testid_Sortdsc);
            ucDdo_br_pathologyid_testid.SetProperty("SearchButtonText", Ddo_br_pathologyid_testid_Searchbuttontext);
            ucDdo_br_pathologyid_testid.SetProperty("DropDownOptionsTitleSettingsIcons", AV31DDO_TitleSettingsIcons);
            ucDdo_br_pathologyid_testid.SetProperty("DropDownOptionsData", AV19BR_PathologyID_TestIDTitleFilterData);
            ucDdo_br_pathologyid_testid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathologyid_testid_Internalname, "DDO_BR_PATHOLOGYID_TESTIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathologyid_testidtitlecontrolidtoreplace_Internalname, AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", 0, edtavDdo_br_pathologyid_testidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyPrompt.htm");
            /* User Defined Control */
            ucDdo_br_pathologyid_padate.SetProperty("Caption", Ddo_br_pathologyid_padate_Caption);
            ucDdo_br_pathologyid_padate.SetProperty("Tooltip", Ddo_br_pathologyid_padate_Tooltip);
            ucDdo_br_pathologyid_padate.SetProperty("Cls", Ddo_br_pathologyid_padate_Cls);
            ucDdo_br_pathologyid_padate.SetProperty("DropDownOptionsType", Ddo_br_pathologyid_padate_Dropdownoptionstype);
            ucDdo_br_pathologyid_padate.SetProperty("IncludeSortASC", Ddo_br_pathologyid_padate_Includesortasc);
            ucDdo_br_pathologyid_padate.SetProperty("IncludeSortDSC", Ddo_br_pathologyid_padate_Includesortdsc);
            ucDdo_br_pathologyid_padate.SetProperty("IncludeFilter", Ddo_br_pathologyid_padate_Includefilter);
            ucDdo_br_pathologyid_padate.SetProperty("IncludeDataList", Ddo_br_pathologyid_padate_Includedatalist);
            ucDdo_br_pathologyid_padate.SetProperty("SortASC", Ddo_br_pathologyid_padate_Sortasc);
            ucDdo_br_pathologyid_padate.SetProperty("SortDSC", Ddo_br_pathologyid_padate_Sortdsc);
            ucDdo_br_pathologyid_padate.SetProperty("SearchButtonText", Ddo_br_pathologyid_padate_Searchbuttontext);
            ucDdo_br_pathologyid_padate.SetProperty("DropDownOptionsTitleSettingsIcons", AV31DDO_TitleSettingsIcons);
            ucDdo_br_pathologyid_padate.SetProperty("DropDownOptionsData", AV21BR_PathologyID_PADateTitleFilterData);
            ucDdo_br_pathologyid_padate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathologyid_padate_Internalname, "DDO_BR_PATHOLOGYID_PADATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathologyid_padatetitlecontrolidtoreplace_Internalname, AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", 0, edtavDdo_br_pathologyid_padatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyPrompt.htm");
            /* User Defined Control */
            ucDdo_br_pathologyid_pahosp.SetProperty("Caption", Ddo_br_pathologyid_pahosp_Caption);
            ucDdo_br_pathologyid_pahosp.SetProperty("Tooltip", Ddo_br_pathologyid_pahosp_Tooltip);
            ucDdo_br_pathologyid_pahosp.SetProperty("Cls", Ddo_br_pathologyid_pahosp_Cls);
            ucDdo_br_pathologyid_pahosp.SetProperty("DropDownOptionsType", Ddo_br_pathologyid_pahosp_Dropdownoptionstype);
            ucDdo_br_pathologyid_pahosp.SetProperty("IncludeSortASC", Ddo_br_pathologyid_pahosp_Includesortasc);
            ucDdo_br_pathologyid_pahosp.SetProperty("IncludeSortDSC", Ddo_br_pathologyid_pahosp_Includesortdsc);
            ucDdo_br_pathologyid_pahosp.SetProperty("IncludeFilter", Ddo_br_pathologyid_pahosp_Includefilter);
            ucDdo_br_pathologyid_pahosp.SetProperty("IncludeDataList", Ddo_br_pathologyid_pahosp_Includedatalist);
            ucDdo_br_pathologyid_pahosp.SetProperty("SortASC", Ddo_br_pathologyid_pahosp_Sortasc);
            ucDdo_br_pathologyid_pahosp.SetProperty("SortDSC", Ddo_br_pathologyid_pahosp_Sortdsc);
            ucDdo_br_pathologyid_pahosp.SetProperty("SearchButtonText", Ddo_br_pathologyid_pahosp_Searchbuttontext);
            ucDdo_br_pathologyid_pahosp.SetProperty("DropDownOptionsTitleSettingsIcons", AV31DDO_TitleSettingsIcons);
            ucDdo_br_pathologyid_pahosp.SetProperty("DropDownOptionsData", AV23BR_PathologyID_PAHospTitleFilterData);
            ucDdo_br_pathologyid_pahosp.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathologyid_pahosp_Internalname, "DDO_BR_PATHOLOGYID_PAHOSPContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathologyid_pahosptitlecontrolidtoreplace_Internalname, AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", 0, edtavDdo_br_pathologyid_pahosptitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyPrompt.htm");
            /* User Defined Control */
            ucDdo_br_pathologyid_paage.SetProperty("Caption", Ddo_br_pathologyid_paage_Caption);
            ucDdo_br_pathologyid_paage.SetProperty("Tooltip", Ddo_br_pathologyid_paage_Tooltip);
            ucDdo_br_pathologyid_paage.SetProperty("Cls", Ddo_br_pathologyid_paage_Cls);
            ucDdo_br_pathologyid_paage.SetProperty("DropDownOptionsType", Ddo_br_pathologyid_paage_Dropdownoptionstype);
            ucDdo_br_pathologyid_paage.SetProperty("IncludeSortASC", Ddo_br_pathologyid_paage_Includesortasc);
            ucDdo_br_pathologyid_paage.SetProperty("IncludeSortDSC", Ddo_br_pathologyid_paage_Includesortdsc);
            ucDdo_br_pathologyid_paage.SetProperty("IncludeFilter", Ddo_br_pathologyid_paage_Includefilter);
            ucDdo_br_pathologyid_paage.SetProperty("IncludeDataList", Ddo_br_pathologyid_paage_Includedatalist);
            ucDdo_br_pathologyid_paage.SetProperty("SortASC", Ddo_br_pathologyid_paage_Sortasc);
            ucDdo_br_pathologyid_paage.SetProperty("SortDSC", Ddo_br_pathologyid_paage_Sortdsc);
            ucDdo_br_pathologyid_paage.SetProperty("SearchButtonText", Ddo_br_pathologyid_paage_Searchbuttontext);
            ucDdo_br_pathologyid_paage.SetProperty("DropDownOptionsTitleSettingsIcons", AV31DDO_TitleSettingsIcons);
            ucDdo_br_pathologyid_paage.SetProperty("DropDownOptionsData", AV25BR_PathologyID_PAAgeTitleFilterData);
            ucDdo_br_pathologyid_paage.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathologyid_paage_Internalname, "DDO_BR_PATHOLOGYID_PAAGEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathologyid_paagetitlecontrolidtoreplace_Internalname, AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", 0, edtavDdo_br_pathologyid_paagetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyPrompt.htm");
            /* User Defined Control */
            ucDdo_br_pathologyid_prepadia.SetProperty("Caption", Ddo_br_pathologyid_prepadia_Caption);
            ucDdo_br_pathologyid_prepadia.SetProperty("Tooltip", Ddo_br_pathologyid_prepadia_Tooltip);
            ucDdo_br_pathologyid_prepadia.SetProperty("Cls", Ddo_br_pathologyid_prepadia_Cls);
            ucDdo_br_pathologyid_prepadia.SetProperty("DropDownOptionsType", Ddo_br_pathologyid_prepadia_Dropdownoptionstype);
            ucDdo_br_pathologyid_prepadia.SetProperty("IncludeSortASC", Ddo_br_pathologyid_prepadia_Includesortasc);
            ucDdo_br_pathologyid_prepadia.SetProperty("IncludeSortDSC", Ddo_br_pathologyid_prepadia_Includesortdsc);
            ucDdo_br_pathologyid_prepadia.SetProperty("IncludeFilter", Ddo_br_pathologyid_prepadia_Includefilter);
            ucDdo_br_pathologyid_prepadia.SetProperty("IncludeDataList", Ddo_br_pathologyid_prepadia_Includedatalist);
            ucDdo_br_pathologyid_prepadia.SetProperty("SortASC", Ddo_br_pathologyid_prepadia_Sortasc);
            ucDdo_br_pathologyid_prepadia.SetProperty("SortDSC", Ddo_br_pathologyid_prepadia_Sortdsc);
            ucDdo_br_pathologyid_prepadia.SetProperty("SearchButtonText", Ddo_br_pathologyid_prepadia_Searchbuttontext);
            ucDdo_br_pathologyid_prepadia.SetProperty("DropDownOptionsTitleSettingsIcons", AV31DDO_TitleSettingsIcons);
            ucDdo_br_pathologyid_prepadia.SetProperty("DropDownOptionsData", AV27BR_PathologyID_PrePaDiaTitleFilterData);
            ucDdo_br_pathologyid_prepadia.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathologyid_prepadia_Internalname, "DDO_BR_PATHOLOGYID_PREPADIAContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathologyid_prepadiatitlecontrolidtoreplace_Internalname, AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", 0, edtavDdo_br_pathologyid_prepadiatitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyPrompt.htm");
            /* User Defined Control */
            ucDdo_br_pathologyid_paresult.SetProperty("Caption", Ddo_br_pathologyid_paresult_Caption);
            ucDdo_br_pathologyid_paresult.SetProperty("Tooltip", Ddo_br_pathologyid_paresult_Tooltip);
            ucDdo_br_pathologyid_paresult.SetProperty("Cls", Ddo_br_pathologyid_paresult_Cls);
            ucDdo_br_pathologyid_paresult.SetProperty("DropDownOptionsType", Ddo_br_pathologyid_paresult_Dropdownoptionstype);
            ucDdo_br_pathologyid_paresult.SetProperty("IncludeSortASC", Ddo_br_pathologyid_paresult_Includesortasc);
            ucDdo_br_pathologyid_paresult.SetProperty("IncludeSortDSC", Ddo_br_pathologyid_paresult_Includesortdsc);
            ucDdo_br_pathologyid_paresult.SetProperty("IncludeFilter", Ddo_br_pathologyid_paresult_Includefilter);
            ucDdo_br_pathologyid_paresult.SetProperty("IncludeDataList", Ddo_br_pathologyid_paresult_Includedatalist);
            ucDdo_br_pathologyid_paresult.SetProperty("SortASC", Ddo_br_pathologyid_paresult_Sortasc);
            ucDdo_br_pathologyid_paresult.SetProperty("SortDSC", Ddo_br_pathologyid_paresult_Sortdsc);
            ucDdo_br_pathologyid_paresult.SetProperty("SearchButtonText", Ddo_br_pathologyid_paresult_Searchbuttontext);
            ucDdo_br_pathologyid_paresult.SetProperty("DropDownOptionsTitleSettingsIcons", AV31DDO_TitleSettingsIcons);
            ucDdo_br_pathologyid_paresult.SetProperty("DropDownOptionsData", AV29BR_PathologyID_PAResultTitleFilterData);
            ucDdo_br_pathologyid_paresult.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathologyid_paresult_Internalname, "DDO_BR_PATHOLOGYID_PARESULTContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathologyid_paresulttitlecontrolidtoreplace_Internalname, AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", 0, edtavDdo_br_pathologyid_paresulttitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyPrompt.htm");
            /* User Defined Control */
            ucDdo_br_pathology_dia_name.SetProperty("Caption", Ddo_br_pathology_dia_name_Caption);
            ucDdo_br_pathology_dia_name.SetProperty("Tooltip", Ddo_br_pathology_dia_name_Tooltip);
            ucDdo_br_pathology_dia_name.SetProperty("Cls", Ddo_br_pathology_dia_name_Cls);
            ucDdo_br_pathology_dia_name.SetProperty("DropDownOptionsType", Ddo_br_pathology_dia_name_Dropdownoptionstype);
            ucDdo_br_pathology_dia_name.SetProperty("IncludeSortASC", Ddo_br_pathology_dia_name_Includesortasc);
            ucDdo_br_pathology_dia_name.SetProperty("IncludeSortDSC", Ddo_br_pathology_dia_name_Includesortdsc);
            ucDdo_br_pathology_dia_name.SetProperty("IncludeFilter", Ddo_br_pathology_dia_name_Includefilter);
            ucDdo_br_pathology_dia_name.SetProperty("IncludeDataList", Ddo_br_pathology_dia_name_Includedatalist);
            ucDdo_br_pathology_dia_name.SetProperty("SortASC", Ddo_br_pathology_dia_name_Sortasc);
            ucDdo_br_pathology_dia_name.SetProperty("SortDSC", Ddo_br_pathology_dia_name_Sortdsc);
            ucDdo_br_pathology_dia_name.SetProperty("SearchButtonText", Ddo_br_pathology_dia_name_Searchbuttontext);
            ucDdo_br_pathology_dia_name.SetProperty("DropDownOptionsTitleSettingsIcons", AV31DDO_TitleSettingsIcons);
            ucDdo_br_pathology_dia_name.SetProperty("DropDownOptionsData", AV49BR_Pathology_Dia_NameTitleFilterData);
            ucDdo_br_pathology_dia_name.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_dia_name_Internalname, "DDO_BR_PATHOLOGY_DIA_NAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_dia_nametitlecontrolidtoreplace_Internalname, AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", 0, edtavDdo_br_pathology_dia_nametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyPrompt.htm");
            /* User Defined Control */
            ucDdo_br_pathology_t.SetProperty("Caption", Ddo_br_pathology_t_Caption);
            ucDdo_br_pathology_t.SetProperty("Tooltip", Ddo_br_pathology_t_Tooltip);
            ucDdo_br_pathology_t.SetProperty("Cls", Ddo_br_pathology_t_Cls);
            ucDdo_br_pathology_t.SetProperty("DropDownOptionsType", Ddo_br_pathology_t_Dropdownoptionstype);
            ucDdo_br_pathology_t.SetProperty("IncludeSortASC", Ddo_br_pathology_t_Includesortasc);
            ucDdo_br_pathology_t.SetProperty("IncludeSortDSC", Ddo_br_pathology_t_Includesortdsc);
            ucDdo_br_pathology_t.SetProperty("IncludeFilter", Ddo_br_pathology_t_Includefilter);
            ucDdo_br_pathology_t.SetProperty("IncludeDataList", Ddo_br_pathology_t_Includedatalist);
            ucDdo_br_pathology_t.SetProperty("SortASC", Ddo_br_pathology_t_Sortasc);
            ucDdo_br_pathology_t.SetProperty("SortDSC", Ddo_br_pathology_t_Sortdsc);
            ucDdo_br_pathology_t.SetProperty("SearchButtonText", Ddo_br_pathology_t_Searchbuttontext);
            ucDdo_br_pathology_t.SetProperty("DropDownOptionsTitleSettingsIcons", AV31DDO_TitleSettingsIcons);
            ucDdo_br_pathology_t.SetProperty("DropDownOptionsData", AV37BR_Pathology_TTitleFilterData);
            ucDdo_br_pathology_t.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_t_Internalname, "DDO_BR_PATHOLOGY_TContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_ttitlecontrolidtoreplace_Internalname, AV38ddo_BR_Pathology_TTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", 0, edtavDdo_br_pathology_ttitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyPrompt.htm");
            /* User Defined Control */
            ucDdo_br_pathology_n.SetProperty("Caption", Ddo_br_pathology_n_Caption);
            ucDdo_br_pathology_n.SetProperty("Tooltip", Ddo_br_pathology_n_Tooltip);
            ucDdo_br_pathology_n.SetProperty("Cls", Ddo_br_pathology_n_Cls);
            ucDdo_br_pathology_n.SetProperty("DropDownOptionsType", Ddo_br_pathology_n_Dropdownoptionstype);
            ucDdo_br_pathology_n.SetProperty("IncludeSortASC", Ddo_br_pathology_n_Includesortasc);
            ucDdo_br_pathology_n.SetProperty("IncludeSortDSC", Ddo_br_pathology_n_Includesortdsc);
            ucDdo_br_pathology_n.SetProperty("IncludeFilter", Ddo_br_pathology_n_Includefilter);
            ucDdo_br_pathology_n.SetProperty("IncludeDataList", Ddo_br_pathology_n_Includedatalist);
            ucDdo_br_pathology_n.SetProperty("SortASC", Ddo_br_pathology_n_Sortasc);
            ucDdo_br_pathology_n.SetProperty("SortDSC", Ddo_br_pathology_n_Sortdsc);
            ucDdo_br_pathology_n.SetProperty("SearchButtonText", Ddo_br_pathology_n_Searchbuttontext);
            ucDdo_br_pathology_n.SetProperty("DropDownOptionsTitleSettingsIcons", AV31DDO_TitleSettingsIcons);
            ucDdo_br_pathology_n.SetProperty("DropDownOptionsData", AV39BR_Pathology_NTitleFilterData);
            ucDdo_br_pathology_n.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_n_Internalname, "DDO_BR_PATHOLOGY_NContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_ntitlecontrolidtoreplace_Internalname, AV40ddo_BR_Pathology_NTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,60);\"", 0, edtavDdo_br_pathology_ntitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyPrompt.htm");
            /* User Defined Control */
            ucDdo_br_pathology_lymphnum.SetProperty("Caption", Ddo_br_pathology_lymphnum_Caption);
            ucDdo_br_pathology_lymphnum.SetProperty("Tooltip", Ddo_br_pathology_lymphnum_Tooltip);
            ucDdo_br_pathology_lymphnum.SetProperty("Cls", Ddo_br_pathology_lymphnum_Cls);
            ucDdo_br_pathology_lymphnum.SetProperty("DropDownOptionsType", Ddo_br_pathology_lymphnum_Dropdownoptionstype);
            ucDdo_br_pathology_lymphnum.SetProperty("IncludeSortASC", Ddo_br_pathology_lymphnum_Includesortasc);
            ucDdo_br_pathology_lymphnum.SetProperty("IncludeSortDSC", Ddo_br_pathology_lymphnum_Includesortdsc);
            ucDdo_br_pathology_lymphnum.SetProperty("IncludeFilter", Ddo_br_pathology_lymphnum_Includefilter);
            ucDdo_br_pathology_lymphnum.SetProperty("IncludeDataList", Ddo_br_pathology_lymphnum_Includedatalist);
            ucDdo_br_pathology_lymphnum.SetProperty("SortASC", Ddo_br_pathology_lymphnum_Sortasc);
            ucDdo_br_pathology_lymphnum.SetProperty("SortDSC", Ddo_br_pathology_lymphnum_Sortdsc);
            ucDdo_br_pathology_lymphnum.SetProperty("SearchButtonText", Ddo_br_pathology_lymphnum_Searchbuttontext);
            ucDdo_br_pathology_lymphnum.SetProperty("DropDownOptionsTitleSettingsIcons", AV31DDO_TitleSettingsIcons);
            ucDdo_br_pathology_lymphnum.SetProperty("DropDownOptionsData", AV41BR_Pathology_LymphNumTitleFilterData);
            ucDdo_br_pathology_lymphnum.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_lymphnum_Internalname, "DDO_BR_PATHOLOGY_LYMPHNUMContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_lymphnumtitlecontrolidtoreplace_Internalname, AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,62);\"", 0, edtavDdo_br_pathology_lymphnumtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyPrompt.htm");
            /* User Defined Control */
            ucDdo_br_pathology_lymphrate.SetProperty("Caption", Ddo_br_pathology_lymphrate_Caption);
            ucDdo_br_pathology_lymphrate.SetProperty("Tooltip", Ddo_br_pathology_lymphrate_Tooltip);
            ucDdo_br_pathology_lymphrate.SetProperty("Cls", Ddo_br_pathology_lymphrate_Cls);
            ucDdo_br_pathology_lymphrate.SetProperty("DropDownOptionsType", Ddo_br_pathology_lymphrate_Dropdownoptionstype);
            ucDdo_br_pathology_lymphrate.SetProperty("IncludeSortASC", Ddo_br_pathology_lymphrate_Includesortasc);
            ucDdo_br_pathology_lymphrate.SetProperty("IncludeSortDSC", Ddo_br_pathology_lymphrate_Includesortdsc);
            ucDdo_br_pathology_lymphrate.SetProperty("IncludeFilter", Ddo_br_pathology_lymphrate_Includefilter);
            ucDdo_br_pathology_lymphrate.SetProperty("IncludeDataList", Ddo_br_pathology_lymphrate_Includedatalist);
            ucDdo_br_pathology_lymphrate.SetProperty("SortASC", Ddo_br_pathology_lymphrate_Sortasc);
            ucDdo_br_pathology_lymphrate.SetProperty("SortDSC", Ddo_br_pathology_lymphrate_Sortdsc);
            ucDdo_br_pathology_lymphrate.SetProperty("SearchButtonText", Ddo_br_pathology_lymphrate_Searchbuttontext);
            ucDdo_br_pathology_lymphrate.SetProperty("DropDownOptionsTitleSettingsIcons", AV31DDO_TitleSettingsIcons);
            ucDdo_br_pathology_lymphrate.SetProperty("DropDownOptionsData", AV43BR_Pathology_LymphRateTitleFilterData);
            ucDdo_br_pathology_lymphrate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_lymphrate_Internalname, "DDO_BR_PATHOLOGY_LYMPHRATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_lymphratetitlecontrolidtoreplace_Internalname, AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", 0, edtavDdo_br_pathology_lymphratetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyPrompt.htm");
            /* User Defined Control */
            ucDdo_br_pathology_m.SetProperty("Caption", Ddo_br_pathology_m_Caption);
            ucDdo_br_pathology_m.SetProperty("Tooltip", Ddo_br_pathology_m_Tooltip);
            ucDdo_br_pathology_m.SetProperty("Cls", Ddo_br_pathology_m_Cls);
            ucDdo_br_pathology_m.SetProperty("DropDownOptionsType", Ddo_br_pathology_m_Dropdownoptionstype);
            ucDdo_br_pathology_m.SetProperty("IncludeSortASC", Ddo_br_pathology_m_Includesortasc);
            ucDdo_br_pathology_m.SetProperty("IncludeSortDSC", Ddo_br_pathology_m_Includesortdsc);
            ucDdo_br_pathology_m.SetProperty("IncludeFilter", Ddo_br_pathology_m_Includefilter);
            ucDdo_br_pathology_m.SetProperty("IncludeDataList", Ddo_br_pathology_m_Includedatalist);
            ucDdo_br_pathology_m.SetProperty("SortASC", Ddo_br_pathology_m_Sortasc);
            ucDdo_br_pathology_m.SetProperty("SortDSC", Ddo_br_pathology_m_Sortdsc);
            ucDdo_br_pathology_m.SetProperty("SearchButtonText", Ddo_br_pathology_m_Searchbuttontext);
            ucDdo_br_pathology_m.SetProperty("DropDownOptionsTitleSettingsIcons", AV31DDO_TitleSettingsIcons);
            ucDdo_br_pathology_m.SetProperty("DropDownOptionsData", AV45BR_Pathology_MTitleFilterData);
            ucDdo_br_pathology_m.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_m_Internalname, "DDO_BR_PATHOLOGY_MContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_mtitlecontrolidtoreplace_Internalname, AV46ddo_BR_Pathology_MTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", 0, edtavDdo_br_pathology_mtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyPrompt.htm");
            /* User Defined Control */
            ucDdo_br_pathology_metaloc.SetProperty("Caption", Ddo_br_pathology_metaloc_Caption);
            ucDdo_br_pathology_metaloc.SetProperty("Tooltip", Ddo_br_pathology_metaloc_Tooltip);
            ucDdo_br_pathology_metaloc.SetProperty("Cls", Ddo_br_pathology_metaloc_Cls);
            ucDdo_br_pathology_metaloc.SetProperty("DropDownOptionsType", Ddo_br_pathology_metaloc_Dropdownoptionstype);
            ucDdo_br_pathology_metaloc.SetProperty("IncludeSortASC", Ddo_br_pathology_metaloc_Includesortasc);
            ucDdo_br_pathology_metaloc.SetProperty("IncludeSortDSC", Ddo_br_pathology_metaloc_Includesortdsc);
            ucDdo_br_pathology_metaloc.SetProperty("IncludeFilter", Ddo_br_pathology_metaloc_Includefilter);
            ucDdo_br_pathology_metaloc.SetProperty("IncludeDataList", Ddo_br_pathology_metaloc_Includedatalist);
            ucDdo_br_pathology_metaloc.SetProperty("SortASC", Ddo_br_pathology_metaloc_Sortasc);
            ucDdo_br_pathology_metaloc.SetProperty("SortDSC", Ddo_br_pathology_metaloc_Sortdsc);
            ucDdo_br_pathology_metaloc.SetProperty("SearchButtonText", Ddo_br_pathology_metaloc_Searchbuttontext);
            ucDdo_br_pathology_metaloc.SetProperty("DropDownOptionsTitleSettingsIcons", AV31DDO_TitleSettingsIcons);
            ucDdo_br_pathology_metaloc.SetProperty("DropDownOptionsData", AV47BR_Pathology_MetaLocTitleFilterData);
            ucDdo_br_pathology_metaloc.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_metaloc_Internalname, "DDO_BR_PATHOLOGY_METALOCContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_metaloctitlecontrolidtoreplace_Internalname, AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,68);\"", 0, edtavDdo_br_pathology_metaloctitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyPrompt.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,70);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_PathologyPrompt.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV12OrderedDsc), StringUtil.BoolToStr( AV12OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,71);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_PathologyPrompt.htm");
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

      protected void START5M2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "选择病理学", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP5M0( ) ;
      }

      protected void WS5M2( )
      {
         START5M2( ) ;
         EVT5M2( ) ;
      }

      protected void EVT5M2( )
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
                           E115M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E125M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGYID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E135M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTERID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E145M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E155M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGYID_TESTID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E165M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGYID_PADATE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E175M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGYID_PAHOSP.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E185M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGYID_PAAGE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E195M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGYID_PREPADIA.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E205M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGYID_PARESULT.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E215M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_DIA_NAME.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E225M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_T.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E235M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_N.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E245M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_LYMPHNUM.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E255M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_LYMPHRATE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E265M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_M.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E275M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_METALOC.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E285M2 ();
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
                           AV36Select = cgiGet( edtavSelect_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV36Select)) ? AV54Select_GXI : context.convertURL( context.PathToRelativeUrl( AV36Select))), !bGXsfl_12_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "SrcSet", context.GetImageSrcSet( AV36Select), true);
                           A226BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( edtBR_PathologyID_Internalname), ".", ","));
                           A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
                           n19BR_EncounterID = false;
                           A36BR_Information_PatientNo = cgiGet( edtBR_Information_PatientNo_Internalname);
                           n36BR_Information_PatientNo = false;
                           A237BR_PathologyID_TestID = (long)(context.localUtil.CToN( cgiGet( edtBR_PathologyID_TestID_Internalname), ".", ","));
                           n237BR_PathologyID_TestID = false;
                           A238BR_PathologyID_PADate = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtBR_PathologyID_PADate_Internalname), 0));
                           n238BR_PathologyID_PADate = false;
                           A239BR_PathologyID_PAHosp = cgiGet( edtBR_PathologyID_PAHosp_Internalname);
                           n239BR_PathologyID_PAHosp = false;
                           A240BR_PathologyID_PAAge = (short)(context.localUtil.CToN( cgiGet( edtBR_PathologyID_PAAge_Internalname), ".", ","));
                           n240BR_PathologyID_PAAge = false;
                           A241BR_PathologyID_PrePaDia = cgiGet( edtBR_PathologyID_PrePaDia_Internalname);
                           n241BR_PathologyID_PrePaDia = false;
                           A242BR_PathologyID_PAResult = cgiGet( edtBR_PathologyID_PAResult_Internalname);
                           n242BR_PathologyID_PAResult = false;
                           A326BR_Pathology_Dia_Name = cgiGet( edtBR_Pathology_Dia_Name_Internalname);
                           n326BR_Pathology_Dia_Name = false;
                           A314BR_Pathology_T = context.localUtil.CToN( cgiGet( edtBR_Pathology_T_Internalname), ".", ",");
                           n314BR_Pathology_T = false;
                           cmbBR_Pathology_N.Name = cmbBR_Pathology_N_Internalname;
                           cmbBR_Pathology_N.CurrentValue = cgiGet( cmbBR_Pathology_N_Internalname);
                           A315BR_Pathology_N = cgiGet( cmbBR_Pathology_N_Internalname);
                           n315BR_Pathology_N = false;
                           A316BR_Pathology_LymphNum = context.localUtil.CToN( cgiGet( edtBR_Pathology_LymphNum_Internalname), ".", ",");
                           n316BR_Pathology_LymphNum = false;
                           A317BR_Pathology_LymphRate = cgiGet( edtBR_Pathology_LymphRate_Internalname);
                           n317BR_Pathology_LymphRate = false;
                           cmbBR_Pathology_M.Name = cmbBR_Pathology_M_Internalname;
                           cmbBR_Pathology_M.CurrentValue = cgiGet( cmbBR_Pathology_M_Internalname);
                           A318BR_Pathology_M = cgiGet( cmbBR_Pathology_M_Internalname);
                           n318BR_Pathology_M = false;
                           A319BR_Pathology_MetaLoc = cgiGet( edtBR_Pathology_MetaLoc_Internalname);
                           n319BR_Pathology_MetaLoc = false;
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E295M2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E305M2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E315M2 ();
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
                                       E325M2 ();
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

      protected void WE5M2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm5M2( ) ;
            }
         }
      }

      protected void PA5M2( )
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
               GX_FocusControl = edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname;
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
                                       String AV14ddo_BR_PathologyIDTitleControlIdToReplace ,
                                       String AV16ddo_BR_EncounterIDTitleControlIdToReplace ,
                                       String AV18ddo_BR_Information_PatientNoTitleControlIdToReplace ,
                                       String AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace ,
                                       String AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace ,
                                       String AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace ,
                                       String AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace ,
                                       String AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace ,
                                       String AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace ,
                                       String AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace ,
                                       String AV38ddo_BR_Pathology_TTitleControlIdToReplace ,
                                       String AV40ddo_BR_Pathology_NTitleControlIdToReplace ,
                                       String AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace ,
                                       String AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace ,
                                       String AV46ddo_BR_Pathology_MTitleControlIdToReplace ,
                                       String AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF5M2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PATHOLOGYID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A226BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_PATHOLOGYID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A226BR_PathologyID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PATHOLOGYID_TESTID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A237BR_PathologyID_TestID), "ZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_PATHOLOGYID_TESTID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A237BR_PathologyID_TestID), 10, 0, ".", "")));
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
         RF5M2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV53Pgmname = "BR_PathologyPrompt";
         context.Gx_err = 0;
      }

      protected void RF5M2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 12;
         /* Execute user event: Refresh */
         E305M2 ();
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
            /* Using cursor H005M2 */
            pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_12_idx = 1;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A85BR_Information_ID = H005M2_A85BR_Information_ID[0];
               n85BR_Information_ID = H005M2_n85BR_Information_ID[0];
               A319BR_Pathology_MetaLoc = H005M2_A319BR_Pathology_MetaLoc[0];
               n319BR_Pathology_MetaLoc = H005M2_n319BR_Pathology_MetaLoc[0];
               A318BR_Pathology_M = H005M2_A318BR_Pathology_M[0];
               n318BR_Pathology_M = H005M2_n318BR_Pathology_M[0];
               A317BR_Pathology_LymphRate = H005M2_A317BR_Pathology_LymphRate[0];
               n317BR_Pathology_LymphRate = H005M2_n317BR_Pathology_LymphRate[0];
               A316BR_Pathology_LymphNum = H005M2_A316BR_Pathology_LymphNum[0];
               n316BR_Pathology_LymphNum = H005M2_n316BR_Pathology_LymphNum[0];
               A315BR_Pathology_N = H005M2_A315BR_Pathology_N[0];
               n315BR_Pathology_N = H005M2_n315BR_Pathology_N[0];
               A314BR_Pathology_T = H005M2_A314BR_Pathology_T[0];
               n314BR_Pathology_T = H005M2_n314BR_Pathology_T[0];
               A326BR_Pathology_Dia_Name = H005M2_A326BR_Pathology_Dia_Name[0];
               n326BR_Pathology_Dia_Name = H005M2_n326BR_Pathology_Dia_Name[0];
               A242BR_PathologyID_PAResult = H005M2_A242BR_PathologyID_PAResult[0];
               n242BR_PathologyID_PAResult = H005M2_n242BR_PathologyID_PAResult[0];
               A241BR_PathologyID_PrePaDia = H005M2_A241BR_PathologyID_PrePaDia[0];
               n241BR_PathologyID_PrePaDia = H005M2_n241BR_PathologyID_PrePaDia[0];
               A240BR_PathologyID_PAAge = H005M2_A240BR_PathologyID_PAAge[0];
               n240BR_PathologyID_PAAge = H005M2_n240BR_PathologyID_PAAge[0];
               A239BR_PathologyID_PAHosp = H005M2_A239BR_PathologyID_PAHosp[0];
               n239BR_PathologyID_PAHosp = H005M2_n239BR_PathologyID_PAHosp[0];
               A238BR_PathologyID_PADate = H005M2_A238BR_PathologyID_PADate[0];
               n238BR_PathologyID_PADate = H005M2_n238BR_PathologyID_PADate[0];
               A237BR_PathologyID_TestID = H005M2_A237BR_PathologyID_TestID[0];
               n237BR_PathologyID_TestID = H005M2_n237BR_PathologyID_TestID[0];
               A36BR_Information_PatientNo = H005M2_A36BR_Information_PatientNo[0];
               n36BR_Information_PatientNo = H005M2_n36BR_Information_PatientNo[0];
               A19BR_EncounterID = H005M2_A19BR_EncounterID[0];
               n19BR_EncounterID = H005M2_n19BR_EncounterID[0];
               A226BR_PathologyID = H005M2_A226BR_PathologyID[0];
               A85BR_Information_ID = H005M2_A85BR_Information_ID[0];
               n85BR_Information_ID = H005M2_n85BR_Information_ID[0];
               A36BR_Information_PatientNo = H005M2_A36BR_Information_PatientNo[0];
               n36BR_Information_PatientNo = H005M2_n36BR_Information_PatientNo[0];
               E315M2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 12;
            WB5M0( ) ;
         }
         bGXsfl_12_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes5M2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PATHOLOGYID"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, context.localUtil.Format( (decimal)(A226BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PATHOLOGYID_TESTID"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, context.localUtil.Format( (decimal)(A237BR_PathologyID_TestID), "ZZZZZZZZZZ"), context));
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
         /* Using cursor H005M3 */
         pr_default.execute(1);
         GRID_nRecordCount = H005M3_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_PathologyIDTitleControlIdToReplace, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_Information_PatientNoTitleControlIdToReplace, AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace, AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace, AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace, AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace, AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace, AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace, AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace, AV38ddo_BR_Pathology_TTitleControlIdToReplace, AV40ddo_BR_Pathology_NTitleControlIdToReplace, AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace, AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace, AV46ddo_BR_Pathology_MTitleControlIdToReplace, AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_PathologyIDTitleControlIdToReplace, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_Information_PatientNoTitleControlIdToReplace, AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace, AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace, AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace, AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace, AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace, AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace, AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace, AV38ddo_BR_Pathology_TTitleControlIdToReplace, AV40ddo_BR_Pathology_NTitleControlIdToReplace, AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace, AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace, AV46ddo_BR_Pathology_MTitleControlIdToReplace, AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_PathologyIDTitleControlIdToReplace, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_Information_PatientNoTitleControlIdToReplace, AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace, AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace, AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace, AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace, AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace, AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace, AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace, AV38ddo_BR_Pathology_TTitleControlIdToReplace, AV40ddo_BR_Pathology_NTitleControlIdToReplace, AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace, AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace, AV46ddo_BR_Pathology_MTitleControlIdToReplace, AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_PathologyIDTitleControlIdToReplace, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_Information_PatientNoTitleControlIdToReplace, AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace, AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace, AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace, AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace, AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace, AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace, AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace, AV38ddo_BR_Pathology_TTitleControlIdToReplace, AV40ddo_BR_Pathology_NTitleControlIdToReplace, AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace, AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace, AV46ddo_BR_Pathology_MTitleControlIdToReplace, AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_PathologyIDTitleControlIdToReplace, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_Information_PatientNoTitleControlIdToReplace, AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace, AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace, AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace, AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace, AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace, AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace, AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace, AV38ddo_BR_Pathology_TTitleControlIdToReplace, AV40ddo_BR_Pathology_NTitleControlIdToReplace, AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace, AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace, AV46ddo_BR_Pathology_MTitleControlIdToReplace, AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP5M0( )
      {
         /* Before Start, stand alone formulas. */
         AV53Pgmname = "BR_PathologyPrompt";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E295M2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV31DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGYIDTITLEFILTERDATA"), AV13BR_PathologyIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTERIDTITLEFILTERDATA"), AV15BR_EncounterIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_INFORMATION_PATIENTNOTITLEFILTERDATA"), AV17BR_Information_PatientNoTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA"), AV19BR_PathologyID_TestIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGYID_PADATETITLEFILTERDATA"), AV21BR_PathologyID_PADateTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA"), AV23BR_PathologyID_PAHospTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGYID_PAAGETITLEFILTERDATA"), AV25BR_PathologyID_PAAgeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA"), AV27BR_PathologyID_PrePaDiaTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA"), AV29BR_PathologyID_PAResultTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA"), AV49BR_Pathology_Dia_NameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_TTITLEFILTERDATA"), AV37BR_Pathology_TTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_NTITLEFILTERDATA"), AV39BR_Pathology_NTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA"), AV41BR_Pathology_LymphNumTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA"), AV43BR_Pathology_LymphRateTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_MTITLEFILTERDATA"), AV45BR_Pathology_MTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_METALOCTITLEFILTERDATA"), AV47BR_Pathology_MetaLocTitleFilterData);
            /* Read variables values. */
            AV14ddo_BR_PathologyIDTitleControlIdToReplace = cgiGet( edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_BR_PathologyIDTitleControlIdToReplace", AV14ddo_BR_PathologyIDTitleControlIdToReplace);
            AV16ddo_BR_EncounterIDTitleControlIdToReplace = cgiGet( edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_BR_EncounterIDTitleControlIdToReplace", AV16ddo_BR_EncounterIDTitleControlIdToReplace);
            AV18ddo_BR_Information_PatientNoTitleControlIdToReplace = cgiGet( edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_BR_Information_PatientNoTitleControlIdToReplace", AV18ddo_BR_Information_PatientNoTitleControlIdToReplace);
            AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace = cgiGet( edtavDdo_br_pathologyid_testidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace", AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace);
            AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace = cgiGet( edtavDdo_br_pathologyid_padatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace", AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace);
            AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace = cgiGet( edtavDdo_br_pathologyid_pahosptitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace", AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace);
            AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace = cgiGet( edtavDdo_br_pathologyid_paagetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace", AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace);
            AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace = cgiGet( edtavDdo_br_pathologyid_prepadiatitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace", AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace);
            AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace = cgiGet( edtavDdo_br_pathologyid_paresulttitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace", AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace);
            AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_dia_nametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace", AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace);
            AV38ddo_BR_Pathology_TTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_ttitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38ddo_BR_Pathology_TTitleControlIdToReplace", AV38ddo_BR_Pathology_TTitleControlIdToReplace);
            AV40ddo_BR_Pathology_NTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_ntitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40ddo_BR_Pathology_NTitleControlIdToReplace", AV40ddo_BR_Pathology_NTitleControlIdToReplace);
            AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_lymphnumtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace", AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace);
            AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_lymphratetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace", AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace);
            AV46ddo_BR_Pathology_MTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_mtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46ddo_BR_Pathology_MTitleControlIdToReplace", AV46ddo_BR_Pathology_MTitleControlIdToReplace);
            AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_metaloctitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace", AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace);
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
            AV33GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV35GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV34GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_pathologyid_Caption = cgiGet( "DDO_BR_PATHOLOGYID_Caption");
            Ddo_br_pathologyid_Tooltip = cgiGet( "DDO_BR_PATHOLOGYID_Tooltip");
            Ddo_br_pathologyid_Cls = cgiGet( "DDO_BR_PATHOLOGYID_Cls");
            Ddo_br_pathologyid_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGYID_Dropdownoptionstype");
            Ddo_br_pathologyid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGYID_Titlecontrolidtoreplace");
            Ddo_br_pathologyid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_Includesortasc"));
            Ddo_br_pathologyid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_Includesortdsc"));
            Ddo_br_pathologyid_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGYID_Sortedstatus");
            Ddo_br_pathologyid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_Includefilter"));
            Ddo_br_pathologyid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_Includedatalist"));
            Ddo_br_pathologyid_Sortasc = cgiGet( "DDO_BR_PATHOLOGYID_Sortasc");
            Ddo_br_pathologyid_Sortdsc = cgiGet( "DDO_BR_PATHOLOGYID_Sortdsc");
            Ddo_br_pathologyid_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGYID_Searchbuttontext");
            Ddo_br_encounterid_Caption = cgiGet( "DDO_BR_ENCOUNTERID_Caption");
            Ddo_br_encounterid_Tooltip = cgiGet( "DDO_BR_ENCOUNTERID_Tooltip");
            Ddo_br_encounterid_Cls = cgiGet( "DDO_BR_ENCOUNTERID_Cls");
            Ddo_br_encounterid_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTERID_Dropdownoptionstype");
            Ddo_br_encounterid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTERID_Titlecontrolidtoreplace");
            Ddo_br_encounterid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Includesortasc"));
            Ddo_br_encounterid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Includesortdsc"));
            Ddo_br_encounterid_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTERID_Sortedstatus");
            Ddo_br_encounterid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Includefilter"));
            Ddo_br_encounterid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Includedatalist"));
            Ddo_br_encounterid_Sortasc = cgiGet( "DDO_BR_ENCOUNTERID_Sortasc");
            Ddo_br_encounterid_Sortdsc = cgiGet( "DDO_BR_ENCOUNTERID_Sortdsc");
            Ddo_br_encounterid_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTERID_Searchbuttontext");
            Ddo_br_information_patientno_Caption = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Caption");
            Ddo_br_information_patientno_Tooltip = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Tooltip");
            Ddo_br_information_patientno_Cls = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Cls");
            Ddo_br_information_patientno_Dropdownoptionstype = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Dropdownoptionstype");
            Ddo_br_information_patientno_Titlecontrolidtoreplace = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Titlecontrolidtoreplace");
            Ddo_br_information_patientno_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Includesortasc"));
            Ddo_br_information_patientno_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Includesortdsc"));
            Ddo_br_information_patientno_Sortedstatus = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Sortedstatus");
            Ddo_br_information_patientno_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Includefilter"));
            Ddo_br_information_patientno_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Includedatalist"));
            Ddo_br_information_patientno_Sortasc = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Sortasc");
            Ddo_br_information_patientno_Sortdsc = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Sortdsc");
            Ddo_br_information_patientno_Searchbuttontext = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Searchbuttontext");
            Ddo_br_pathologyid_testid_Caption = cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Caption");
            Ddo_br_pathologyid_testid_Tooltip = cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Tooltip");
            Ddo_br_pathologyid_testid_Cls = cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Cls");
            Ddo_br_pathologyid_testid_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Dropdownoptionstype");
            Ddo_br_pathologyid_testid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Titlecontrolidtoreplace");
            Ddo_br_pathologyid_testid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Includesortasc"));
            Ddo_br_pathologyid_testid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Includesortdsc"));
            Ddo_br_pathologyid_testid_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Sortedstatus");
            Ddo_br_pathologyid_testid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Includefilter"));
            Ddo_br_pathologyid_testid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Includedatalist"));
            Ddo_br_pathologyid_testid_Sortasc = cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Sortasc");
            Ddo_br_pathologyid_testid_Sortdsc = cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Sortdsc");
            Ddo_br_pathologyid_testid_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Searchbuttontext");
            Ddo_br_pathologyid_padate_Caption = cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Caption");
            Ddo_br_pathologyid_padate_Tooltip = cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Tooltip");
            Ddo_br_pathologyid_padate_Cls = cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Cls");
            Ddo_br_pathologyid_padate_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Dropdownoptionstype");
            Ddo_br_pathologyid_padate_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Titlecontrolidtoreplace");
            Ddo_br_pathologyid_padate_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Includesortasc"));
            Ddo_br_pathologyid_padate_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Includesortdsc"));
            Ddo_br_pathologyid_padate_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Sortedstatus");
            Ddo_br_pathologyid_padate_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Includefilter"));
            Ddo_br_pathologyid_padate_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Includedatalist"));
            Ddo_br_pathologyid_padate_Sortasc = cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Sortasc");
            Ddo_br_pathologyid_padate_Sortdsc = cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Sortdsc");
            Ddo_br_pathologyid_padate_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Searchbuttontext");
            Ddo_br_pathologyid_pahosp_Caption = cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Caption");
            Ddo_br_pathologyid_pahosp_Tooltip = cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Tooltip");
            Ddo_br_pathologyid_pahosp_Cls = cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Cls");
            Ddo_br_pathologyid_pahosp_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Dropdownoptionstype");
            Ddo_br_pathologyid_pahosp_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Titlecontrolidtoreplace");
            Ddo_br_pathologyid_pahosp_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Includesortasc"));
            Ddo_br_pathologyid_pahosp_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Includesortdsc"));
            Ddo_br_pathologyid_pahosp_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Sortedstatus");
            Ddo_br_pathologyid_pahosp_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Includefilter"));
            Ddo_br_pathologyid_pahosp_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Includedatalist"));
            Ddo_br_pathologyid_pahosp_Sortasc = cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Sortasc");
            Ddo_br_pathologyid_pahosp_Sortdsc = cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Sortdsc");
            Ddo_br_pathologyid_pahosp_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Searchbuttontext");
            Ddo_br_pathologyid_paage_Caption = cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Caption");
            Ddo_br_pathologyid_paage_Tooltip = cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Tooltip");
            Ddo_br_pathologyid_paage_Cls = cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Cls");
            Ddo_br_pathologyid_paage_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Dropdownoptionstype");
            Ddo_br_pathologyid_paage_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Titlecontrolidtoreplace");
            Ddo_br_pathologyid_paage_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Includesortasc"));
            Ddo_br_pathologyid_paage_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Includesortdsc"));
            Ddo_br_pathologyid_paage_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Sortedstatus");
            Ddo_br_pathologyid_paage_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Includefilter"));
            Ddo_br_pathologyid_paage_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Includedatalist"));
            Ddo_br_pathologyid_paage_Sortasc = cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Sortasc");
            Ddo_br_pathologyid_paage_Sortdsc = cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Sortdsc");
            Ddo_br_pathologyid_paage_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Searchbuttontext");
            Ddo_br_pathologyid_prepadia_Caption = cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Caption");
            Ddo_br_pathologyid_prepadia_Tooltip = cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Tooltip");
            Ddo_br_pathologyid_prepadia_Cls = cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Cls");
            Ddo_br_pathologyid_prepadia_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Dropdownoptionstype");
            Ddo_br_pathologyid_prepadia_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Titlecontrolidtoreplace");
            Ddo_br_pathologyid_prepadia_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Includesortasc"));
            Ddo_br_pathologyid_prepadia_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Includesortdsc"));
            Ddo_br_pathologyid_prepadia_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Sortedstatus");
            Ddo_br_pathologyid_prepadia_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Includefilter"));
            Ddo_br_pathologyid_prepadia_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Includedatalist"));
            Ddo_br_pathologyid_prepadia_Sortasc = cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Sortasc");
            Ddo_br_pathologyid_prepadia_Sortdsc = cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Sortdsc");
            Ddo_br_pathologyid_prepadia_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Searchbuttontext");
            Ddo_br_pathologyid_paresult_Caption = cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Caption");
            Ddo_br_pathologyid_paresult_Tooltip = cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Tooltip");
            Ddo_br_pathologyid_paresult_Cls = cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Cls");
            Ddo_br_pathologyid_paresult_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Dropdownoptionstype");
            Ddo_br_pathologyid_paresult_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Titlecontrolidtoreplace");
            Ddo_br_pathologyid_paresult_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Includesortasc"));
            Ddo_br_pathologyid_paresult_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Includesortdsc"));
            Ddo_br_pathologyid_paresult_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Sortedstatus");
            Ddo_br_pathologyid_paresult_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Includefilter"));
            Ddo_br_pathologyid_paresult_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Includedatalist"));
            Ddo_br_pathologyid_paresult_Sortasc = cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Sortasc");
            Ddo_br_pathologyid_paresult_Sortdsc = cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Sortdsc");
            Ddo_br_pathologyid_paresult_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Searchbuttontext");
            Ddo_br_pathology_dia_name_Caption = cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Caption");
            Ddo_br_pathology_dia_name_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Tooltip");
            Ddo_br_pathology_dia_name_Cls = cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Cls");
            Ddo_br_pathology_dia_name_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Dropdownoptionstype");
            Ddo_br_pathology_dia_name_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Titlecontrolidtoreplace");
            Ddo_br_pathology_dia_name_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Includesortasc"));
            Ddo_br_pathology_dia_name_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Includesortdsc"));
            Ddo_br_pathology_dia_name_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Sortedstatus");
            Ddo_br_pathology_dia_name_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Includefilter"));
            Ddo_br_pathology_dia_name_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Includedatalist"));
            Ddo_br_pathology_dia_name_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Sortasc");
            Ddo_br_pathology_dia_name_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Sortdsc");
            Ddo_br_pathology_dia_name_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Searchbuttontext");
            Ddo_br_pathology_t_Caption = cgiGet( "DDO_BR_PATHOLOGY_T_Caption");
            Ddo_br_pathology_t_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_T_Tooltip");
            Ddo_br_pathology_t_Cls = cgiGet( "DDO_BR_PATHOLOGY_T_Cls");
            Ddo_br_pathology_t_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_T_Dropdownoptionstype");
            Ddo_br_pathology_t_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_T_Titlecontrolidtoreplace");
            Ddo_br_pathology_t_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_T_Includesortasc"));
            Ddo_br_pathology_t_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_T_Includesortdsc"));
            Ddo_br_pathology_t_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_T_Sortedstatus");
            Ddo_br_pathology_t_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_T_Includefilter"));
            Ddo_br_pathology_t_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_T_Includedatalist"));
            Ddo_br_pathology_t_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_T_Sortasc");
            Ddo_br_pathology_t_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_T_Sortdsc");
            Ddo_br_pathology_t_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_T_Searchbuttontext");
            Ddo_br_pathology_n_Caption = cgiGet( "DDO_BR_PATHOLOGY_N_Caption");
            Ddo_br_pathology_n_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_N_Tooltip");
            Ddo_br_pathology_n_Cls = cgiGet( "DDO_BR_PATHOLOGY_N_Cls");
            Ddo_br_pathology_n_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_N_Dropdownoptionstype");
            Ddo_br_pathology_n_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_N_Titlecontrolidtoreplace");
            Ddo_br_pathology_n_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_N_Includesortasc"));
            Ddo_br_pathology_n_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_N_Includesortdsc"));
            Ddo_br_pathology_n_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_N_Sortedstatus");
            Ddo_br_pathology_n_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_N_Includefilter"));
            Ddo_br_pathology_n_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_N_Includedatalist"));
            Ddo_br_pathology_n_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_N_Sortasc");
            Ddo_br_pathology_n_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_N_Sortdsc");
            Ddo_br_pathology_n_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_N_Searchbuttontext");
            Ddo_br_pathology_lymphnum_Caption = cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Caption");
            Ddo_br_pathology_lymphnum_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Tooltip");
            Ddo_br_pathology_lymphnum_Cls = cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Cls");
            Ddo_br_pathology_lymphnum_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Dropdownoptionstype");
            Ddo_br_pathology_lymphnum_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Titlecontrolidtoreplace");
            Ddo_br_pathology_lymphnum_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Includesortasc"));
            Ddo_br_pathology_lymphnum_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Includesortdsc"));
            Ddo_br_pathology_lymphnum_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Sortedstatus");
            Ddo_br_pathology_lymphnum_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Includefilter"));
            Ddo_br_pathology_lymphnum_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Includedatalist"));
            Ddo_br_pathology_lymphnum_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Sortasc");
            Ddo_br_pathology_lymphnum_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Sortdsc");
            Ddo_br_pathology_lymphnum_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Searchbuttontext");
            Ddo_br_pathology_lymphrate_Caption = cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Caption");
            Ddo_br_pathology_lymphrate_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Tooltip");
            Ddo_br_pathology_lymphrate_Cls = cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Cls");
            Ddo_br_pathology_lymphrate_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Dropdownoptionstype");
            Ddo_br_pathology_lymphrate_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Titlecontrolidtoreplace");
            Ddo_br_pathology_lymphrate_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Includesortasc"));
            Ddo_br_pathology_lymphrate_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Includesortdsc"));
            Ddo_br_pathology_lymphrate_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Sortedstatus");
            Ddo_br_pathology_lymphrate_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Includefilter"));
            Ddo_br_pathology_lymphrate_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Includedatalist"));
            Ddo_br_pathology_lymphrate_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Sortasc");
            Ddo_br_pathology_lymphrate_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Sortdsc");
            Ddo_br_pathology_lymphrate_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Searchbuttontext");
            Ddo_br_pathology_m_Caption = cgiGet( "DDO_BR_PATHOLOGY_M_Caption");
            Ddo_br_pathology_m_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_M_Tooltip");
            Ddo_br_pathology_m_Cls = cgiGet( "DDO_BR_PATHOLOGY_M_Cls");
            Ddo_br_pathology_m_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_M_Dropdownoptionstype");
            Ddo_br_pathology_m_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_M_Titlecontrolidtoreplace");
            Ddo_br_pathology_m_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_M_Includesortasc"));
            Ddo_br_pathology_m_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_M_Includesortdsc"));
            Ddo_br_pathology_m_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_M_Sortedstatus");
            Ddo_br_pathology_m_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_M_Includefilter"));
            Ddo_br_pathology_m_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_M_Includedatalist"));
            Ddo_br_pathology_m_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_M_Sortasc");
            Ddo_br_pathology_m_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_M_Sortdsc");
            Ddo_br_pathology_m_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_M_Searchbuttontext");
            Ddo_br_pathology_metaloc_Caption = cgiGet( "DDO_BR_PATHOLOGY_METALOC_Caption");
            Ddo_br_pathology_metaloc_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_METALOC_Tooltip");
            Ddo_br_pathology_metaloc_Cls = cgiGet( "DDO_BR_PATHOLOGY_METALOC_Cls");
            Ddo_br_pathology_metaloc_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_METALOC_Dropdownoptionstype");
            Ddo_br_pathology_metaloc_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_METALOC_Titlecontrolidtoreplace");
            Ddo_br_pathology_metaloc_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_METALOC_Includesortasc"));
            Ddo_br_pathology_metaloc_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_METALOC_Includesortdsc"));
            Ddo_br_pathology_metaloc_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_METALOC_Sortedstatus");
            Ddo_br_pathology_metaloc_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_METALOC_Includefilter"));
            Ddo_br_pathology_metaloc_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_METALOC_Includedatalist"));
            Ddo_br_pathology_metaloc_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_METALOC_Sortasc");
            Ddo_br_pathology_metaloc_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_METALOC_Sortdsc");
            Ddo_br_pathology_metaloc_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_METALOC_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_pathologyid_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGYID_Activeeventkey");
            Ddo_br_encounterid_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTERID_Activeeventkey");
            Ddo_br_information_patientno_Activeeventkey = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey");
            Ddo_br_pathologyid_testid_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Activeeventkey");
            Ddo_br_pathologyid_padate_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Activeeventkey");
            Ddo_br_pathologyid_pahosp_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Activeeventkey");
            Ddo_br_pathologyid_paage_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Activeeventkey");
            Ddo_br_pathologyid_prepadia_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Activeeventkey");
            Ddo_br_pathologyid_paresult_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Activeeventkey");
            Ddo_br_pathology_dia_name_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Activeeventkey");
            Ddo_br_pathology_t_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_T_Activeeventkey");
            Ddo_br_pathology_n_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_N_Activeeventkey");
            Ddo_br_pathology_lymphnum_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Activeeventkey");
            Ddo_br_pathology_lymphrate_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Activeeventkey");
            Ddo_br_pathology_m_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_M_Activeeventkey");
            Ddo_br_pathology_metaloc_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_METALOC_Activeeventkey");
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
         E295M2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E295M2( )
      {
         /* Start Routine */
         GXt_boolean1 = AV5IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Pathology", out  GXt_boolean1) ;
         AV5IsAuthorized = GXt_boolean1;
         if ( ! AV5IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV53Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         divTablemain_Height = 493;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTablemain_Internalname, "Height", StringUtil.LTrim( StringUtil.Str( (decimal)(divTablemain_Height), 9, 0)), true);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_br_pathologyid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_PathologyID";
         ucDdo_br_pathologyid.SendProperty(context, "", false, Ddo_br_pathologyid_Internalname, "TitleControlIdToReplace", Ddo_br_pathologyid_Titlecontrolidtoreplace);
         AV14ddo_BR_PathologyIDTitleControlIdToReplace = Ddo_br_pathologyid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_BR_PathologyIDTitleControlIdToReplace", AV14ddo_BR_PathologyIDTitleControlIdToReplace);
         edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounterid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_EncounterID";
         ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "TitleControlIdToReplace", Ddo_br_encounterid_Titlecontrolidtoreplace);
         AV16ddo_BR_EncounterIDTitleControlIdToReplace = Ddo_br_encounterid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_BR_EncounterIDTitleControlIdToReplace", AV16ddo_BR_EncounterIDTitleControlIdToReplace);
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_information_patientno_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Information_PatientNo";
         ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "TitleControlIdToReplace", Ddo_br_information_patientno_Titlecontrolidtoreplace);
         AV18ddo_BR_Information_PatientNoTitleControlIdToReplace = Ddo_br_information_patientno_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_BR_Information_PatientNoTitleControlIdToReplace", AV18ddo_BR_Information_PatientNoTitleControlIdToReplace);
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathologyid_testid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_PathologyID_TestID";
         ucDdo_br_pathologyid_testid.SendProperty(context, "", false, Ddo_br_pathologyid_testid_Internalname, "TitleControlIdToReplace", Ddo_br_pathologyid_testid_Titlecontrolidtoreplace);
         AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace = Ddo_br_pathologyid_testid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace", AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace);
         edtavDdo_br_pathologyid_testidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathologyid_testidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathologyid_testidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathologyid_padate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_PathologyID_PADate";
         ucDdo_br_pathologyid_padate.SendProperty(context, "", false, Ddo_br_pathologyid_padate_Internalname, "TitleControlIdToReplace", Ddo_br_pathologyid_padate_Titlecontrolidtoreplace);
         AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace = Ddo_br_pathologyid_padate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace", AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace);
         edtavDdo_br_pathologyid_padatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathologyid_padatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathologyid_padatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathologyid_pahosp_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_PathologyID_PAHosp";
         ucDdo_br_pathologyid_pahosp.SendProperty(context, "", false, Ddo_br_pathologyid_pahosp_Internalname, "TitleControlIdToReplace", Ddo_br_pathologyid_pahosp_Titlecontrolidtoreplace);
         AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace = Ddo_br_pathologyid_pahosp_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace", AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace);
         edtavDdo_br_pathologyid_pahosptitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathologyid_pahosptitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathologyid_pahosptitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathologyid_paage_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_PathologyID_PAAge";
         ucDdo_br_pathologyid_paage.SendProperty(context, "", false, Ddo_br_pathologyid_paage_Internalname, "TitleControlIdToReplace", Ddo_br_pathologyid_paage_Titlecontrolidtoreplace);
         AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace = Ddo_br_pathologyid_paage_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace", AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace);
         edtavDdo_br_pathologyid_paagetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathologyid_paagetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathologyid_paagetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathologyid_prepadia_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_PathologyID_PrePaDia";
         ucDdo_br_pathologyid_prepadia.SendProperty(context, "", false, Ddo_br_pathologyid_prepadia_Internalname, "TitleControlIdToReplace", Ddo_br_pathologyid_prepadia_Titlecontrolidtoreplace);
         AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace = Ddo_br_pathologyid_prepadia_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace", AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace);
         edtavDdo_br_pathologyid_prepadiatitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathologyid_prepadiatitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathologyid_prepadiatitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathologyid_paresult_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_PathologyID_PAResult";
         ucDdo_br_pathologyid_paresult.SendProperty(context, "", false, Ddo_br_pathologyid_paresult_Internalname, "TitleControlIdToReplace", Ddo_br_pathologyid_paresult_Titlecontrolidtoreplace);
         AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace = Ddo_br_pathologyid_paresult_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace", AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace);
         edtavDdo_br_pathologyid_paresulttitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathologyid_paresulttitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathologyid_paresulttitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_dia_name_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_Dia_Name";
         ucDdo_br_pathology_dia_name.SendProperty(context, "", false, Ddo_br_pathology_dia_name_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_dia_name_Titlecontrolidtoreplace);
         AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace = Ddo_br_pathology_dia_name_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace", AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace);
         edtavDdo_br_pathology_dia_nametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_dia_nametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_dia_nametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_t_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_T";
         ucDdo_br_pathology_t.SendProperty(context, "", false, Ddo_br_pathology_t_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_t_Titlecontrolidtoreplace);
         AV38ddo_BR_Pathology_TTitleControlIdToReplace = Ddo_br_pathology_t_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38ddo_BR_Pathology_TTitleControlIdToReplace", AV38ddo_BR_Pathology_TTitleControlIdToReplace);
         edtavDdo_br_pathology_ttitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_ttitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_ttitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_n_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_N";
         ucDdo_br_pathology_n.SendProperty(context, "", false, Ddo_br_pathology_n_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_n_Titlecontrolidtoreplace);
         AV40ddo_BR_Pathology_NTitleControlIdToReplace = Ddo_br_pathology_n_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40ddo_BR_Pathology_NTitleControlIdToReplace", AV40ddo_BR_Pathology_NTitleControlIdToReplace);
         edtavDdo_br_pathology_ntitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_ntitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_ntitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_lymphnum_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_LymphNum";
         ucDdo_br_pathology_lymphnum.SendProperty(context, "", false, Ddo_br_pathology_lymphnum_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_lymphnum_Titlecontrolidtoreplace);
         AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace = Ddo_br_pathology_lymphnum_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace", AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace);
         edtavDdo_br_pathology_lymphnumtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_lymphnumtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_lymphnumtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_lymphrate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_LymphRate";
         ucDdo_br_pathology_lymphrate.SendProperty(context, "", false, Ddo_br_pathology_lymphrate_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_lymphrate_Titlecontrolidtoreplace);
         AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace = Ddo_br_pathology_lymphrate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace", AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace);
         edtavDdo_br_pathology_lymphratetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_lymphratetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_lymphratetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_m_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_M";
         ucDdo_br_pathology_m.SendProperty(context, "", false, Ddo_br_pathology_m_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_m_Titlecontrolidtoreplace);
         AV46ddo_BR_Pathology_MTitleControlIdToReplace = Ddo_br_pathology_m_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46ddo_BR_Pathology_MTitleControlIdToReplace", AV46ddo_BR_Pathology_MTitleControlIdToReplace);
         edtavDdo_br_pathology_mtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_mtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_mtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_metaloc_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_MetaLoc";
         ucDdo_br_pathology_metaloc.SendProperty(context, "", false, Ddo_br_pathology_metaloc_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_metaloc_Titlecontrolidtoreplace);
         AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace = Ddo_br_pathology_metaloc_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace", AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace);
         edtavDdo_br_pathology_metaloctitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_metaloctitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_metaloctitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "选择病理学";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV31DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV31DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E305M2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV13BR_PathologyIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17BR_Information_PatientNoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19BR_PathologyID_TestIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_PathologyID_PADateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV23BR_PathologyID_PAHospTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV25BR_PathologyID_PAAgeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV27BR_PathologyID_PrePaDiaTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV29BR_PathologyID_PAResultTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV49BR_Pathology_Dia_NameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV37BR_Pathology_TTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV39BR_Pathology_NTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV41BR_Pathology_LymphNumTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV43BR_Pathology_LymphRateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV45BR_Pathology_MTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV47BR_Pathology_MetaLocTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         edtBR_PathologyID_Titleformat = 2;
         edtBR_PathologyID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "病理学主键", AV14ddo_BR_PathologyIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_Internalname, "Title", edtBR_PathologyID_Title, !bGXsfl_12_Refreshing);
         edtBR_EncounterID_Titleformat = 2;
         edtBR_EncounterID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊信息主键", AV16ddo_BR_EncounterIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Title", edtBR_EncounterID_Title, !bGXsfl_12_Refreshing);
         edtBR_Information_PatientNo_Titleformat = 2;
         edtBR_Information_PatientNo_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "患者编号", AV18ddo_BR_Information_PatientNoTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_PatientNo_Internalname, "Title", edtBR_Information_PatientNo_Title, !bGXsfl_12_Refreshing);
         edtBR_PathologyID_TestID_Titleformat = 2;
         edtBR_PathologyID_TestID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "项目序号", AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_TestID_Internalname, "Title", edtBR_PathologyID_TestID_Title, !bGXsfl_12_Refreshing);
         edtBR_PathologyID_PADate_Titleformat = 2;
         edtBR_PathologyID_PADate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "病理检查日期", AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_PADate_Internalname, "Title", edtBR_PathologyID_PADate_Title, !bGXsfl_12_Refreshing);
         edtBR_PathologyID_PAHosp_Titleformat = 2;
         edtBR_PathologyID_PAHosp_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "检查医院", AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_PAHosp_Internalname, "Title", edtBR_PathologyID_PAHosp_Title, !bGXsfl_12_Refreshing);
         edtBR_PathologyID_PAAge_Titleformat = 2;
         edtBR_PathologyID_PAAge_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "年龄", AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_PAAge_Internalname, "Title", edtBR_PathologyID_PAAge_Title, !bGXsfl_12_Refreshing);
         edtBR_PathologyID_PrePaDia_Titleformat = 2;
         edtBR_PathologyID_PrePaDia_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "病理前诊断", AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_PrePaDia_Internalname, "Title", edtBR_PathologyID_PrePaDia_Title, !bGXsfl_12_Refreshing);
         edtBR_PathologyID_PAResult_Titleformat = 2;
         edtBR_PathologyID_PAResult_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "病理描述", AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_PAResult_Internalname, "Title", edtBR_PathologyID_PAResult_Title, !bGXsfl_12_Refreshing);
         edtBR_Pathology_Dia_Name_Titleformat = 2;
         edtBR_Pathology_Dia_Name_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "病理诊断名称", AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Dia_Name_Internalname, "Title", edtBR_Pathology_Dia_Name_Title, !bGXsfl_12_Refreshing);
         edtBR_Pathology_T_Titleformat = 2;
         edtBR_Pathology_T_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "原发肿瘤分级", AV38ddo_BR_Pathology_TTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_T_Internalname, "Title", edtBR_Pathology_T_Title, !bGXsfl_12_Refreshing);
         cmbBR_Pathology_N_Titleformat = 2;
         cmbBR_Pathology_N.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "是否淋巴结转移", AV40ddo_BR_Pathology_NTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Pathology_N_Internalname, "Title", cmbBR_Pathology_N.Title.Text, !bGXsfl_12_Refreshing);
         edtBR_Pathology_LymphNum_Titleformat = 2;
         edtBR_Pathology_LymphNum_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "淋巴结数目", AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_LymphNum_Internalname, "Title", edtBR_Pathology_LymphNum_Title, !bGXsfl_12_Refreshing);
         edtBR_Pathology_LymphRate_Titleformat = 2;
         edtBR_Pathology_LymphRate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "淋巴结转移比例", AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_LymphRate_Internalname, "Title", edtBR_Pathology_LymphRate_Title, !bGXsfl_12_Refreshing);
         cmbBR_Pathology_M_Titleformat = 2;
         cmbBR_Pathology_M.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "是否远端转移", AV46ddo_BR_Pathology_MTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Pathology_M_Internalname, "Title", cmbBR_Pathology_M.Title.Text, !bGXsfl_12_Refreshing);
         edtBR_Pathology_MetaLoc_Titleformat = 2;
         edtBR_Pathology_MetaLoc_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "远端转移部位", AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_MetaLoc_Internalname, "Title", edtBR_Pathology_MetaLoc_Title, !bGXsfl_12_Refreshing);
         AV33GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV33GridCurrentPage), 10, 0)));
         AV34GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34GridPageSize), 10, 0)));
         AV35GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV35GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_PathologyIDTitleFilterData", AV13BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_PathologyID_TestIDTitleFilterData", AV19BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_PathologyID_PADateTitleFilterData", AV21BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_PathologyID_PAHospTitleFilterData", AV23BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_PathologyID_PAAgeTitleFilterData", AV25BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_PathologyID_PrePaDiaTitleFilterData", AV27BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_PathologyID_PAResultTitleFilterData", AV29BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Pathology_Dia_NameTitleFilterData", AV49BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_Pathology_TTitleFilterData", AV37BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39BR_Pathology_NTitleFilterData", AV39BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41BR_Pathology_LymphNumTitleFilterData", AV41BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV43BR_Pathology_LymphRateTitleFilterData", AV43BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_Pathology_MTitleFilterData", AV45BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47BR_Pathology_MetaLocTitleFilterData", AV47BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E115M2( )
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
            AV32PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV32PageToGo) ;
         }
      }

      protected void E125M2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E135M2( )
      {
         /* Ddo_br_pathologyid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathologyid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathologyid_Sortedstatus = "ASC";
            ucDdo_br_pathologyid.SendProperty(context, "", false, Ddo_br_pathologyid_Internalname, "SortedStatus", Ddo_br_pathologyid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathologyid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathologyid_Sortedstatus = "DSC";
            ucDdo_br_pathologyid.SendProperty(context, "", false, Ddo_br_pathologyid_Internalname, "SortedStatus", Ddo_br_pathologyid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_PathologyIDTitleFilterData", AV13BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_PathologyID_TestIDTitleFilterData", AV19BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_PathologyID_PADateTitleFilterData", AV21BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_PathologyID_PAHospTitleFilterData", AV23BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_PathologyID_PAAgeTitleFilterData", AV25BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_PathologyID_PrePaDiaTitleFilterData", AV27BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_PathologyID_PAResultTitleFilterData", AV29BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Pathology_Dia_NameTitleFilterData", AV49BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_Pathology_TTitleFilterData", AV37BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39BR_Pathology_NTitleFilterData", AV39BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41BR_Pathology_LymphNumTitleFilterData", AV41BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV43BR_Pathology_LymphRateTitleFilterData", AV43BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_Pathology_MTitleFilterData", AV45BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47BR_Pathology_MetaLocTitleFilterData", AV47BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E145M2( )
      {
         /* Ddo_br_encounterid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounterid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounterid_Sortedstatus = "ASC";
            ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounterid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounterid_Sortedstatus = "DSC";
            ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_PathologyIDTitleFilterData", AV13BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_PathologyID_TestIDTitleFilterData", AV19BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_PathologyID_PADateTitleFilterData", AV21BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_PathologyID_PAHospTitleFilterData", AV23BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_PathologyID_PAAgeTitleFilterData", AV25BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_PathologyID_PrePaDiaTitleFilterData", AV27BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_PathologyID_PAResultTitleFilterData", AV29BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Pathology_Dia_NameTitleFilterData", AV49BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_Pathology_TTitleFilterData", AV37BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39BR_Pathology_NTitleFilterData", AV39BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41BR_Pathology_LymphNumTitleFilterData", AV41BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV43BR_Pathology_LymphRateTitleFilterData", AV43BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_Pathology_MTitleFilterData", AV45BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47BR_Pathology_MetaLocTitleFilterData", AV47BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E155M2( )
      {
         /* Ddo_br_information_patientno_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_information_patientno_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_information_patientno_Sortedstatus = "ASC";
            ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "SortedStatus", Ddo_br_information_patientno_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_information_patientno_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_information_patientno_Sortedstatus = "DSC";
            ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "SortedStatus", Ddo_br_information_patientno_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_PathologyIDTitleFilterData", AV13BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_PathologyID_TestIDTitleFilterData", AV19BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_PathologyID_PADateTitleFilterData", AV21BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_PathologyID_PAHospTitleFilterData", AV23BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_PathologyID_PAAgeTitleFilterData", AV25BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_PathologyID_PrePaDiaTitleFilterData", AV27BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_PathologyID_PAResultTitleFilterData", AV29BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Pathology_Dia_NameTitleFilterData", AV49BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_Pathology_TTitleFilterData", AV37BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39BR_Pathology_NTitleFilterData", AV39BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41BR_Pathology_LymphNumTitleFilterData", AV41BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV43BR_Pathology_LymphRateTitleFilterData", AV43BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_Pathology_MTitleFilterData", AV45BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47BR_Pathology_MetaLocTitleFilterData", AV47BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E165M2( )
      {
         /* Ddo_br_pathologyid_testid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathologyid_testid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathologyid_testid_Sortedstatus = "ASC";
            ucDdo_br_pathologyid_testid.SendProperty(context, "", false, Ddo_br_pathologyid_testid_Internalname, "SortedStatus", Ddo_br_pathologyid_testid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathologyid_testid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathologyid_testid_Sortedstatus = "DSC";
            ucDdo_br_pathologyid_testid.SendProperty(context, "", false, Ddo_br_pathologyid_testid_Internalname, "SortedStatus", Ddo_br_pathologyid_testid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_PathologyIDTitleFilterData", AV13BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_PathologyID_TestIDTitleFilterData", AV19BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_PathologyID_PADateTitleFilterData", AV21BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_PathologyID_PAHospTitleFilterData", AV23BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_PathologyID_PAAgeTitleFilterData", AV25BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_PathologyID_PrePaDiaTitleFilterData", AV27BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_PathologyID_PAResultTitleFilterData", AV29BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Pathology_Dia_NameTitleFilterData", AV49BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_Pathology_TTitleFilterData", AV37BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39BR_Pathology_NTitleFilterData", AV39BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41BR_Pathology_LymphNumTitleFilterData", AV41BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV43BR_Pathology_LymphRateTitleFilterData", AV43BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_Pathology_MTitleFilterData", AV45BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47BR_Pathology_MetaLocTitleFilterData", AV47BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E175M2( )
      {
         /* Ddo_br_pathologyid_padate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathologyid_padate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathologyid_padate_Sortedstatus = "ASC";
            ucDdo_br_pathologyid_padate.SendProperty(context, "", false, Ddo_br_pathologyid_padate_Internalname, "SortedStatus", Ddo_br_pathologyid_padate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathologyid_padate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathologyid_padate_Sortedstatus = "DSC";
            ucDdo_br_pathologyid_padate.SendProperty(context, "", false, Ddo_br_pathologyid_padate_Internalname, "SortedStatus", Ddo_br_pathologyid_padate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_PathologyIDTitleFilterData", AV13BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_PathologyID_TestIDTitleFilterData", AV19BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_PathologyID_PADateTitleFilterData", AV21BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_PathologyID_PAHospTitleFilterData", AV23BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_PathologyID_PAAgeTitleFilterData", AV25BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_PathologyID_PrePaDiaTitleFilterData", AV27BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_PathologyID_PAResultTitleFilterData", AV29BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Pathology_Dia_NameTitleFilterData", AV49BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_Pathology_TTitleFilterData", AV37BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39BR_Pathology_NTitleFilterData", AV39BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41BR_Pathology_LymphNumTitleFilterData", AV41BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV43BR_Pathology_LymphRateTitleFilterData", AV43BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_Pathology_MTitleFilterData", AV45BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47BR_Pathology_MetaLocTitleFilterData", AV47BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E185M2( )
      {
         /* Ddo_br_pathologyid_pahosp_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathologyid_pahosp_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathologyid_pahosp_Sortedstatus = "ASC";
            ucDdo_br_pathologyid_pahosp.SendProperty(context, "", false, Ddo_br_pathologyid_pahosp_Internalname, "SortedStatus", Ddo_br_pathologyid_pahosp_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathologyid_pahosp_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathologyid_pahosp_Sortedstatus = "DSC";
            ucDdo_br_pathologyid_pahosp.SendProperty(context, "", false, Ddo_br_pathologyid_pahosp_Internalname, "SortedStatus", Ddo_br_pathologyid_pahosp_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_PathologyIDTitleFilterData", AV13BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_PathologyID_TestIDTitleFilterData", AV19BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_PathologyID_PADateTitleFilterData", AV21BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_PathologyID_PAHospTitleFilterData", AV23BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_PathologyID_PAAgeTitleFilterData", AV25BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_PathologyID_PrePaDiaTitleFilterData", AV27BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_PathologyID_PAResultTitleFilterData", AV29BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Pathology_Dia_NameTitleFilterData", AV49BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_Pathology_TTitleFilterData", AV37BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39BR_Pathology_NTitleFilterData", AV39BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41BR_Pathology_LymphNumTitleFilterData", AV41BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV43BR_Pathology_LymphRateTitleFilterData", AV43BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_Pathology_MTitleFilterData", AV45BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47BR_Pathology_MetaLocTitleFilterData", AV47BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E195M2( )
      {
         /* Ddo_br_pathologyid_paage_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathologyid_paage_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathologyid_paage_Sortedstatus = "ASC";
            ucDdo_br_pathologyid_paage.SendProperty(context, "", false, Ddo_br_pathologyid_paage_Internalname, "SortedStatus", Ddo_br_pathologyid_paage_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathologyid_paage_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathologyid_paage_Sortedstatus = "DSC";
            ucDdo_br_pathologyid_paage.SendProperty(context, "", false, Ddo_br_pathologyid_paage_Internalname, "SortedStatus", Ddo_br_pathologyid_paage_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_PathologyIDTitleFilterData", AV13BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_PathologyID_TestIDTitleFilterData", AV19BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_PathologyID_PADateTitleFilterData", AV21BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_PathologyID_PAHospTitleFilterData", AV23BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_PathologyID_PAAgeTitleFilterData", AV25BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_PathologyID_PrePaDiaTitleFilterData", AV27BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_PathologyID_PAResultTitleFilterData", AV29BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Pathology_Dia_NameTitleFilterData", AV49BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_Pathology_TTitleFilterData", AV37BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39BR_Pathology_NTitleFilterData", AV39BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41BR_Pathology_LymphNumTitleFilterData", AV41BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV43BR_Pathology_LymphRateTitleFilterData", AV43BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_Pathology_MTitleFilterData", AV45BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47BR_Pathology_MetaLocTitleFilterData", AV47BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E205M2( )
      {
         /* Ddo_br_pathologyid_prepadia_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathologyid_prepadia_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathologyid_prepadia_Sortedstatus = "ASC";
            ucDdo_br_pathologyid_prepadia.SendProperty(context, "", false, Ddo_br_pathologyid_prepadia_Internalname, "SortedStatus", Ddo_br_pathologyid_prepadia_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathologyid_prepadia_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathologyid_prepadia_Sortedstatus = "DSC";
            ucDdo_br_pathologyid_prepadia.SendProperty(context, "", false, Ddo_br_pathologyid_prepadia_Internalname, "SortedStatus", Ddo_br_pathologyid_prepadia_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_PathologyIDTitleFilterData", AV13BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_PathologyID_TestIDTitleFilterData", AV19BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_PathologyID_PADateTitleFilterData", AV21BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_PathologyID_PAHospTitleFilterData", AV23BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_PathologyID_PAAgeTitleFilterData", AV25BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_PathologyID_PrePaDiaTitleFilterData", AV27BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_PathologyID_PAResultTitleFilterData", AV29BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Pathology_Dia_NameTitleFilterData", AV49BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_Pathology_TTitleFilterData", AV37BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39BR_Pathology_NTitleFilterData", AV39BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41BR_Pathology_LymphNumTitleFilterData", AV41BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV43BR_Pathology_LymphRateTitleFilterData", AV43BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_Pathology_MTitleFilterData", AV45BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47BR_Pathology_MetaLocTitleFilterData", AV47BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E215M2( )
      {
         /* Ddo_br_pathologyid_paresult_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathologyid_paresult_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathologyid_paresult_Sortedstatus = "ASC";
            ucDdo_br_pathologyid_paresult.SendProperty(context, "", false, Ddo_br_pathologyid_paresult_Internalname, "SortedStatus", Ddo_br_pathologyid_paresult_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathologyid_paresult_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathologyid_paresult_Sortedstatus = "DSC";
            ucDdo_br_pathologyid_paresult.SendProperty(context, "", false, Ddo_br_pathologyid_paresult_Internalname, "SortedStatus", Ddo_br_pathologyid_paresult_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_PathologyIDTitleFilterData", AV13BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_PathologyID_TestIDTitleFilterData", AV19BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_PathologyID_PADateTitleFilterData", AV21BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_PathologyID_PAHospTitleFilterData", AV23BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_PathologyID_PAAgeTitleFilterData", AV25BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_PathologyID_PrePaDiaTitleFilterData", AV27BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_PathologyID_PAResultTitleFilterData", AV29BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Pathology_Dia_NameTitleFilterData", AV49BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_Pathology_TTitleFilterData", AV37BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39BR_Pathology_NTitleFilterData", AV39BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41BR_Pathology_LymphNumTitleFilterData", AV41BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV43BR_Pathology_LymphRateTitleFilterData", AV43BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_Pathology_MTitleFilterData", AV45BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47BR_Pathology_MetaLocTitleFilterData", AV47BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E225M2( )
      {
         /* Ddo_br_pathology_dia_name_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_dia_name_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 10;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_dia_name_Sortedstatus = "ASC";
            ucDdo_br_pathology_dia_name.SendProperty(context, "", false, Ddo_br_pathology_dia_name_Internalname, "SortedStatus", Ddo_br_pathology_dia_name_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_dia_name_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 10;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_dia_name_Sortedstatus = "DSC";
            ucDdo_br_pathology_dia_name.SendProperty(context, "", false, Ddo_br_pathology_dia_name_Internalname, "SortedStatus", Ddo_br_pathology_dia_name_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_PathologyIDTitleFilterData", AV13BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_PathologyID_TestIDTitleFilterData", AV19BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_PathologyID_PADateTitleFilterData", AV21BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_PathologyID_PAHospTitleFilterData", AV23BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_PathologyID_PAAgeTitleFilterData", AV25BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_PathologyID_PrePaDiaTitleFilterData", AV27BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_PathologyID_PAResultTitleFilterData", AV29BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Pathology_Dia_NameTitleFilterData", AV49BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_Pathology_TTitleFilterData", AV37BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39BR_Pathology_NTitleFilterData", AV39BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41BR_Pathology_LymphNumTitleFilterData", AV41BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV43BR_Pathology_LymphRateTitleFilterData", AV43BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_Pathology_MTitleFilterData", AV45BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47BR_Pathology_MetaLocTitleFilterData", AV47BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E235M2( )
      {
         /* Ddo_br_pathology_t_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_t_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_t_Sortedstatus = "ASC";
            ucDdo_br_pathology_t.SendProperty(context, "", false, Ddo_br_pathology_t_Internalname, "SortedStatus", Ddo_br_pathology_t_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_t_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_t_Sortedstatus = "DSC";
            ucDdo_br_pathology_t.SendProperty(context, "", false, Ddo_br_pathology_t_Internalname, "SortedStatus", Ddo_br_pathology_t_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_PathologyIDTitleFilterData", AV13BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_PathologyID_TestIDTitleFilterData", AV19BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_PathologyID_PADateTitleFilterData", AV21BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_PathologyID_PAHospTitleFilterData", AV23BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_PathologyID_PAAgeTitleFilterData", AV25BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_PathologyID_PrePaDiaTitleFilterData", AV27BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_PathologyID_PAResultTitleFilterData", AV29BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Pathology_Dia_NameTitleFilterData", AV49BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_Pathology_TTitleFilterData", AV37BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39BR_Pathology_NTitleFilterData", AV39BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41BR_Pathology_LymphNumTitleFilterData", AV41BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV43BR_Pathology_LymphRateTitleFilterData", AV43BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_Pathology_MTitleFilterData", AV45BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47BR_Pathology_MetaLocTitleFilterData", AV47BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E245M2( )
      {
         /* Ddo_br_pathology_n_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_n_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_n_Sortedstatus = "ASC";
            ucDdo_br_pathology_n.SendProperty(context, "", false, Ddo_br_pathology_n_Internalname, "SortedStatus", Ddo_br_pathology_n_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_n_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_n_Sortedstatus = "DSC";
            ucDdo_br_pathology_n.SendProperty(context, "", false, Ddo_br_pathology_n_Internalname, "SortedStatus", Ddo_br_pathology_n_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_PathologyIDTitleFilterData", AV13BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_PathologyID_TestIDTitleFilterData", AV19BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_PathologyID_PADateTitleFilterData", AV21BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_PathologyID_PAHospTitleFilterData", AV23BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_PathologyID_PAAgeTitleFilterData", AV25BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_PathologyID_PrePaDiaTitleFilterData", AV27BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_PathologyID_PAResultTitleFilterData", AV29BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Pathology_Dia_NameTitleFilterData", AV49BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_Pathology_TTitleFilterData", AV37BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39BR_Pathology_NTitleFilterData", AV39BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41BR_Pathology_LymphNumTitleFilterData", AV41BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV43BR_Pathology_LymphRateTitleFilterData", AV43BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_Pathology_MTitleFilterData", AV45BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47BR_Pathology_MetaLocTitleFilterData", AV47BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E255M2( )
      {
         /* Ddo_br_pathology_lymphnum_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_lymphnum_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 13;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_lymphnum_Sortedstatus = "ASC";
            ucDdo_br_pathology_lymphnum.SendProperty(context, "", false, Ddo_br_pathology_lymphnum_Internalname, "SortedStatus", Ddo_br_pathology_lymphnum_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_lymphnum_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 13;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_lymphnum_Sortedstatus = "DSC";
            ucDdo_br_pathology_lymphnum.SendProperty(context, "", false, Ddo_br_pathology_lymphnum_Internalname, "SortedStatus", Ddo_br_pathology_lymphnum_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_PathologyIDTitleFilterData", AV13BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_PathologyID_TestIDTitleFilterData", AV19BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_PathologyID_PADateTitleFilterData", AV21BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_PathologyID_PAHospTitleFilterData", AV23BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_PathologyID_PAAgeTitleFilterData", AV25BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_PathologyID_PrePaDiaTitleFilterData", AV27BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_PathologyID_PAResultTitleFilterData", AV29BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Pathology_Dia_NameTitleFilterData", AV49BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_Pathology_TTitleFilterData", AV37BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39BR_Pathology_NTitleFilterData", AV39BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41BR_Pathology_LymphNumTitleFilterData", AV41BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV43BR_Pathology_LymphRateTitleFilterData", AV43BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_Pathology_MTitleFilterData", AV45BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47BR_Pathology_MetaLocTitleFilterData", AV47BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E265M2( )
      {
         /* Ddo_br_pathology_lymphrate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_lymphrate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 14;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_lymphrate_Sortedstatus = "ASC";
            ucDdo_br_pathology_lymphrate.SendProperty(context, "", false, Ddo_br_pathology_lymphrate_Internalname, "SortedStatus", Ddo_br_pathology_lymphrate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_lymphrate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 14;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_lymphrate_Sortedstatus = "DSC";
            ucDdo_br_pathology_lymphrate.SendProperty(context, "", false, Ddo_br_pathology_lymphrate_Internalname, "SortedStatus", Ddo_br_pathology_lymphrate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_PathologyIDTitleFilterData", AV13BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_PathologyID_TestIDTitleFilterData", AV19BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_PathologyID_PADateTitleFilterData", AV21BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_PathologyID_PAHospTitleFilterData", AV23BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_PathologyID_PAAgeTitleFilterData", AV25BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_PathologyID_PrePaDiaTitleFilterData", AV27BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_PathologyID_PAResultTitleFilterData", AV29BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Pathology_Dia_NameTitleFilterData", AV49BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_Pathology_TTitleFilterData", AV37BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39BR_Pathology_NTitleFilterData", AV39BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41BR_Pathology_LymphNumTitleFilterData", AV41BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV43BR_Pathology_LymphRateTitleFilterData", AV43BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_Pathology_MTitleFilterData", AV45BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47BR_Pathology_MetaLocTitleFilterData", AV47BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E275M2( )
      {
         /* Ddo_br_pathology_m_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_m_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 15;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_m_Sortedstatus = "ASC";
            ucDdo_br_pathology_m.SendProperty(context, "", false, Ddo_br_pathology_m_Internalname, "SortedStatus", Ddo_br_pathology_m_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_m_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 15;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_m_Sortedstatus = "DSC";
            ucDdo_br_pathology_m.SendProperty(context, "", false, Ddo_br_pathology_m_Internalname, "SortedStatus", Ddo_br_pathology_m_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_PathologyIDTitleFilterData", AV13BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_PathologyID_TestIDTitleFilterData", AV19BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_PathologyID_PADateTitleFilterData", AV21BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_PathologyID_PAHospTitleFilterData", AV23BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_PathologyID_PAAgeTitleFilterData", AV25BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_PathologyID_PrePaDiaTitleFilterData", AV27BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_PathologyID_PAResultTitleFilterData", AV29BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Pathology_Dia_NameTitleFilterData", AV49BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_Pathology_TTitleFilterData", AV37BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39BR_Pathology_NTitleFilterData", AV39BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41BR_Pathology_LymphNumTitleFilterData", AV41BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV43BR_Pathology_LymphRateTitleFilterData", AV43BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_Pathology_MTitleFilterData", AV45BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47BR_Pathology_MetaLocTitleFilterData", AV47BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E285M2( )
      {
         /* Ddo_br_pathology_metaloc_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_metaloc_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 16;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_metaloc_Sortedstatus = "ASC";
            ucDdo_br_pathology_metaloc.SendProperty(context, "", false, Ddo_br_pathology_metaloc_Internalname, "SortedStatus", Ddo_br_pathology_metaloc_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_metaloc_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 16;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_metaloc_Sortedstatus = "DSC";
            ucDdo_br_pathology_metaloc.SendProperty(context, "", false, Ddo_br_pathology_metaloc_Internalname, "SortedStatus", Ddo_br_pathology_metaloc_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_PathologyIDTitleFilterData", AV13BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_PathologyID_TestIDTitleFilterData", AV19BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_PathologyID_PADateTitleFilterData", AV21BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_PathologyID_PAHospTitleFilterData", AV23BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_PathologyID_PAAgeTitleFilterData", AV25BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_PathologyID_PrePaDiaTitleFilterData", AV27BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_PathologyID_PAResultTitleFilterData", AV29BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Pathology_Dia_NameTitleFilterData", AV49BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_Pathology_TTitleFilterData", AV37BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39BR_Pathology_NTitleFilterData", AV39BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV41BR_Pathology_LymphNumTitleFilterData", AV41BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV43BR_Pathology_LymphRateTitleFilterData", AV43BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_Pathology_MTitleFilterData", AV45BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV47BR_Pathology_MetaLocTitleFilterData", AV47BR_Pathology_MetaLocTitleFilterData);
      }

      private void E315M2( )
      {
         /* Grid_Load Routine */
         AV36Select = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSelect_Internalname, AV36Select);
         AV54Select_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
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
         E325M2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E325M2( )
      {
         /* Enter Routine */
         AV8InOutBR_PathologyID = A226BR_PathologyID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_PathologyID), 18, 0)));
         AV9InOutBR_PathologyID_TestID = A237BR_PathologyID_TestID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutBR_PathologyID_TestID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9InOutBR_PathologyID_TestID), 10, 0)));
         context.setWebReturnParms(new Object[] {(long)AV8InOutBR_PathologyID,(long)AV9InOutBR_PathologyID_TestID});
         context.setWebReturnParmsMetadata(new Object[] {"AV8InOutBR_PathologyID","AV9InOutBR_PathologyID_TestID"});
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
         AV8InOutBR_PathologyID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_PathologyID), 18, 0)));
         AV9InOutBR_PathologyID_TestID = Convert.ToInt64(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutBR_PathologyID_TestID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9InOutBR_PathologyID_TestID), 10, 0)));
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
         PA5M2( ) ;
         WS5M2( ) ;
         WE5M2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022815135072", true);
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
         context.AddJavascriptSource("br_pathologyprompt.js", "?202022815135072", false);
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
         edtBR_PathologyID_Internalname = "BR_PATHOLOGYID_"+sGXsfl_12_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_12_idx;
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO_"+sGXsfl_12_idx;
         edtBR_PathologyID_TestID_Internalname = "BR_PATHOLOGYID_TESTID_"+sGXsfl_12_idx;
         edtBR_PathologyID_PADate_Internalname = "BR_PATHOLOGYID_PADATE_"+sGXsfl_12_idx;
         edtBR_PathologyID_PAHosp_Internalname = "BR_PATHOLOGYID_PAHOSP_"+sGXsfl_12_idx;
         edtBR_PathologyID_PAAge_Internalname = "BR_PATHOLOGYID_PAAGE_"+sGXsfl_12_idx;
         edtBR_PathologyID_PrePaDia_Internalname = "BR_PATHOLOGYID_PREPADIA_"+sGXsfl_12_idx;
         edtBR_PathologyID_PAResult_Internalname = "BR_PATHOLOGYID_PARESULT_"+sGXsfl_12_idx;
         edtBR_Pathology_Dia_Name_Internalname = "BR_PATHOLOGY_DIA_NAME_"+sGXsfl_12_idx;
         edtBR_Pathology_T_Internalname = "BR_PATHOLOGY_T_"+sGXsfl_12_idx;
         cmbBR_Pathology_N_Internalname = "BR_PATHOLOGY_N_"+sGXsfl_12_idx;
         edtBR_Pathology_LymphNum_Internalname = "BR_PATHOLOGY_LYMPHNUM_"+sGXsfl_12_idx;
         edtBR_Pathology_LymphRate_Internalname = "BR_PATHOLOGY_LYMPHRATE_"+sGXsfl_12_idx;
         cmbBR_Pathology_M_Internalname = "BR_PATHOLOGY_M_"+sGXsfl_12_idx;
         edtBR_Pathology_MetaLoc_Internalname = "BR_PATHOLOGY_METALOC_"+sGXsfl_12_idx;
      }

      protected void SubsflControlProps_fel_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_fel_idx;
         edtBR_PathologyID_Internalname = "BR_PATHOLOGYID_"+sGXsfl_12_fel_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_12_fel_idx;
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO_"+sGXsfl_12_fel_idx;
         edtBR_PathologyID_TestID_Internalname = "BR_PATHOLOGYID_TESTID_"+sGXsfl_12_fel_idx;
         edtBR_PathologyID_PADate_Internalname = "BR_PATHOLOGYID_PADATE_"+sGXsfl_12_fel_idx;
         edtBR_PathologyID_PAHosp_Internalname = "BR_PATHOLOGYID_PAHOSP_"+sGXsfl_12_fel_idx;
         edtBR_PathologyID_PAAge_Internalname = "BR_PATHOLOGYID_PAAGE_"+sGXsfl_12_fel_idx;
         edtBR_PathologyID_PrePaDia_Internalname = "BR_PATHOLOGYID_PREPADIA_"+sGXsfl_12_fel_idx;
         edtBR_PathologyID_PAResult_Internalname = "BR_PATHOLOGYID_PARESULT_"+sGXsfl_12_fel_idx;
         edtBR_Pathology_Dia_Name_Internalname = "BR_PATHOLOGY_DIA_NAME_"+sGXsfl_12_fel_idx;
         edtBR_Pathology_T_Internalname = "BR_PATHOLOGY_T_"+sGXsfl_12_fel_idx;
         cmbBR_Pathology_N_Internalname = "BR_PATHOLOGY_N_"+sGXsfl_12_fel_idx;
         edtBR_Pathology_LymphNum_Internalname = "BR_PATHOLOGY_LYMPHNUM_"+sGXsfl_12_fel_idx;
         edtBR_Pathology_LymphRate_Internalname = "BR_PATHOLOGY_LYMPHRATE_"+sGXsfl_12_fel_idx;
         cmbBR_Pathology_M_Internalname = "BR_PATHOLOGY_M_"+sGXsfl_12_fel_idx;
         edtBR_Pathology_MetaLoc_Internalname = "BR_PATHOLOGY_METALOC_"+sGXsfl_12_fel_idx;
      }

      protected void sendrow_122( )
      {
         SubsflControlProps_122( ) ;
         WB5M0( ) ;
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
            AV36Select_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV36Select))&&String.IsNullOrEmpty(StringUtil.RTrim( AV54Select_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV36Select)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV36Select)) ? AV54Select_GXI : context.PathToRelativeUrl( AV36Select));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSelect_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSelect_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSelect_Jsonclick,"'"+""+"'"+",false,"+"'"+"EENTER."+sGXsfl_12_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV36Select_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_PathologyID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A226BR_PathologyID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A226BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_PathologyID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_EncounterID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_EncounterID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Information_PatientNo_Internalname,(String)A36BR_Information_PatientNo,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Information_PatientNo_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)410,(String)"px",(short)17,(String)"px",(short)2000,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_PathologyID_TestID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A237BR_PathologyID_TestID), 10, 0, ".", "")),context.localUtil.Format( (decimal)(A237BR_PathologyID_TestID), "ZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_PathologyID_TestID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_PathologyID_PADate_Internalname,context.localUtil.Format(A238BR_PathologyID_PADate, "9999/99/99"),context.localUtil.Format( A238BR_PathologyID_PADate, "9999/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_PathologyID_PADate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Date",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_PathologyID_PAHosp_Internalname,(String)A239BR_PathologyID_PAHosp,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_PathologyID_PAHosp_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_PathologyID_PAAge_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A240BR_PathologyID_PAAge), 3, 0, ".", "")),context.localUtil.Format( (decimal)(A240BR_PathologyID_PAAge), "ZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_PathologyID_PAAge_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)3,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_PathologyID_PrePaDia_Internalname,(String)A241BR_PathologyID_PrePaDia,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_PathologyID_PrePaDia_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4000,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_PathologyID_PAResult_Internalname,(String)A242BR_PathologyID_PAResult,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_PathologyID_PAResult_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9999,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_Dia_Name_Internalname,(String)A326BR_Pathology_Dia_Name,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_Dia_Name_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)3000,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_T_Internalname,StringUtil.LTrim( StringUtil.NToC( A314BR_Pathology_T, 15, 5, ".", "")),context.localUtil.Format( A314BR_Pathology_T, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_T_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbBR_Pathology_N.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "BR_PATHOLOGY_N_" + sGXsfl_12_idx;
               cmbBR_Pathology_N.Name = GXCCtl;
               cmbBR_Pathology_N.WebTags = "";
               cmbBR_Pathology_N.addItem("", "(请选择)", 0);
               cmbBR_Pathology_N.addItem("否", "否", 0);
               cmbBR_Pathology_N.addItem("是", "是", 0);
               cmbBR_Pathology_N.addItem("不详", "不详", 0);
               if ( cmbBR_Pathology_N.ItemCount > 0 )
               {
                  A315BR_Pathology_N = cmbBR_Pathology_N.getValidValue(A315BR_Pathology_N);
                  n315BR_Pathology_N = false;
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbBR_Pathology_N,(String)cmbBR_Pathology_N_Internalname,StringUtil.RTrim( A315BR_Pathology_N),(short)1,(String)cmbBR_Pathology_N_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"svchar",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbBR_Pathology_N.CurrentValue = StringUtil.RTrim( A315BR_Pathology_N);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Pathology_N_Internalname, "Values", (String)(cmbBR_Pathology_N.ToJavascriptSource()), !bGXsfl_12_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_LymphNum_Internalname,StringUtil.LTrim( StringUtil.NToC( A316BR_Pathology_LymphNum, 15, 5, ".", "")),context.localUtil.Format( A316BR_Pathology_LymphNum, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_LymphNum_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_LymphRate_Internalname,(String)A317BR_Pathology_LymphRate,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_LymphRate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbBR_Pathology_M.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "BR_PATHOLOGY_M_" + sGXsfl_12_idx;
               cmbBR_Pathology_M.Name = GXCCtl;
               cmbBR_Pathology_M.WebTags = "";
               cmbBR_Pathology_M.addItem("", "(请选择)", 0);
               cmbBR_Pathology_M.addItem("否", "否", 0);
               cmbBR_Pathology_M.addItem("是", "是", 0);
               cmbBR_Pathology_M.addItem("不详", "不详", 0);
               if ( cmbBR_Pathology_M.ItemCount > 0 )
               {
                  A318BR_Pathology_M = cmbBR_Pathology_M.getValidValue(A318BR_Pathology_M);
                  n318BR_Pathology_M = false;
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbBR_Pathology_M,(String)cmbBR_Pathology_M_Internalname,StringUtil.RTrim( A318BR_Pathology_M),(short)1,(String)cmbBR_Pathology_M_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"svchar",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbBR_Pathology_M.CurrentValue = StringUtil.RTrim( A318BR_Pathology_M);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Pathology_M_Internalname, "Values", (String)(cmbBR_Pathology_M.ToJavascriptSource()), !bGXsfl_12_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_MetaLoc_Internalname,(String)A319BR_Pathology_MetaLoc,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_MetaLoc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes5M2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_12_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_12_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1));
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
         }
         /* End function sendrow_122 */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "BR_PATHOLOGY_N_" + sGXsfl_12_idx;
         cmbBR_Pathology_N.Name = GXCCtl;
         cmbBR_Pathology_N.WebTags = "";
         cmbBR_Pathology_N.addItem("", "(请选择)", 0);
         cmbBR_Pathology_N.addItem("否", "否", 0);
         cmbBR_Pathology_N.addItem("是", "是", 0);
         cmbBR_Pathology_N.addItem("不详", "不详", 0);
         if ( cmbBR_Pathology_N.ItemCount > 0 )
         {
            A315BR_Pathology_N = cmbBR_Pathology_N.getValidValue(A315BR_Pathology_N);
            n315BR_Pathology_N = false;
         }
         GXCCtl = "BR_PATHOLOGY_M_" + sGXsfl_12_idx;
         cmbBR_Pathology_M.Name = GXCCtl;
         cmbBR_Pathology_M.WebTags = "";
         cmbBR_Pathology_M.addItem("", "(请选择)", 0);
         cmbBR_Pathology_M.addItem("否", "否", 0);
         cmbBR_Pathology_M.addItem("是", "是", 0);
         cmbBR_Pathology_M.addItem("不详", "不详", 0);
         if ( cmbBR_Pathology_M.ItemCount > 0 )
         {
            A318BR_Pathology_M = cmbBR_Pathology_M.getValidValue(A318BR_Pathology_M);
            n318BR_Pathology_M = false;
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtavSelect_Internalname = "vSELECT";
         edtBR_PathologyID_Internalname = "BR_PATHOLOGYID";
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO";
         edtBR_PathologyID_TestID_Internalname = "BR_PATHOLOGYID_TESTID";
         edtBR_PathologyID_PADate_Internalname = "BR_PATHOLOGYID_PADATE";
         edtBR_PathologyID_PAHosp_Internalname = "BR_PATHOLOGYID_PAHOSP";
         edtBR_PathologyID_PAAge_Internalname = "BR_PATHOLOGYID_PAAGE";
         edtBR_PathologyID_PrePaDia_Internalname = "BR_PATHOLOGYID_PREPADIA";
         edtBR_PathologyID_PAResult_Internalname = "BR_PATHOLOGYID_PARESULT";
         edtBR_Pathology_Dia_Name_Internalname = "BR_PATHOLOGY_DIA_NAME";
         edtBR_Pathology_T_Internalname = "BR_PATHOLOGY_T";
         cmbBR_Pathology_N_Internalname = "BR_PATHOLOGY_N";
         edtBR_Pathology_LymphNum_Internalname = "BR_PATHOLOGY_LYMPHNUM";
         edtBR_Pathology_LymphRate_Internalname = "BR_PATHOLOGY_LYMPHRATE";
         cmbBR_Pathology_M_Internalname = "BR_PATHOLOGY_M";
         edtBR_Pathology_MetaLoc_Internalname = "BR_PATHOLOGY_METALOC";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_pathologyid_Internalname = "DDO_BR_PATHOLOGYID";
         edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE";
         Ddo_br_encounterid_Internalname = "DDO_BR_ENCOUNTERID";
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE";
         Ddo_br_information_patientno_Internalname = "DDO_BR_INFORMATION_PATIENTNO";
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname = "vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE";
         Ddo_br_pathologyid_testid_Internalname = "DDO_BR_PATHOLOGYID_TESTID";
         edtavDdo_br_pathologyid_testidtitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE";
         Ddo_br_pathologyid_padate_Internalname = "DDO_BR_PATHOLOGYID_PADATE";
         edtavDdo_br_pathologyid_padatetitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE";
         Ddo_br_pathologyid_pahosp_Internalname = "DDO_BR_PATHOLOGYID_PAHOSP";
         edtavDdo_br_pathologyid_pahosptitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE";
         Ddo_br_pathologyid_paage_Internalname = "DDO_BR_PATHOLOGYID_PAAGE";
         edtavDdo_br_pathologyid_paagetitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE";
         Ddo_br_pathologyid_prepadia_Internalname = "DDO_BR_PATHOLOGYID_PREPADIA";
         edtavDdo_br_pathologyid_prepadiatitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE";
         Ddo_br_pathologyid_paresult_Internalname = "DDO_BR_PATHOLOGYID_PARESULT";
         edtavDdo_br_pathologyid_paresulttitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_dia_name_Internalname = "DDO_BR_PATHOLOGY_DIA_NAME";
         edtavDdo_br_pathology_dia_nametitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_t_Internalname = "DDO_BR_PATHOLOGY_T";
         edtavDdo_br_pathology_ttitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_n_Internalname = "DDO_BR_PATHOLOGY_N";
         edtavDdo_br_pathology_ntitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_lymphnum_Internalname = "DDO_BR_PATHOLOGY_LYMPHNUM";
         edtavDdo_br_pathology_lymphnumtitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_lymphrate_Internalname = "DDO_BR_PATHOLOGY_LYMPHRATE";
         edtavDdo_br_pathology_lymphratetitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_m_Internalname = "DDO_BR_PATHOLOGY_M";
         edtavDdo_br_pathology_mtitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_metaloc_Internalname = "DDO_BR_PATHOLOGY_METALOC";
         edtavDdo_br_pathology_metaloctitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE";
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
         edtBR_Pathology_MetaLoc_Jsonclick = "";
         cmbBR_Pathology_M_Jsonclick = "";
         edtBR_Pathology_LymphRate_Jsonclick = "";
         edtBR_Pathology_LymphNum_Jsonclick = "";
         cmbBR_Pathology_N_Jsonclick = "";
         edtBR_Pathology_T_Jsonclick = "";
         edtBR_Pathology_Dia_Name_Jsonclick = "";
         edtBR_PathologyID_PAResult_Jsonclick = "";
         edtBR_PathologyID_PrePaDia_Jsonclick = "";
         edtBR_PathologyID_PAAge_Jsonclick = "";
         edtBR_PathologyID_PAHosp_Jsonclick = "";
         edtBR_PathologyID_PADate_Jsonclick = "";
         edtBR_PathologyID_TestID_Jsonclick = "";
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_EncounterID_Jsonclick = "";
         edtBR_PathologyID_Jsonclick = "";
         edtavSelect_Jsonclick = "";
         edtavSelect_Visible = -1;
         edtavSelect_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_pathology_metaloctitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathology_mtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathology_lymphratetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathology_lymphnumtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathology_ntitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathology_ttitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathology_dia_nametitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathologyid_paresulttitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathologyid_prepadiatitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathologyid_paagetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathologyid_pahosptitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathologyid_padatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathologyid_testidtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavSelect_Tooltiptext = "选择";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Pathology_MetaLoc_Titleformat = 0;
         edtBR_Pathology_MetaLoc_Title = "远端转移部位";
         cmbBR_Pathology_M_Titleformat = 0;
         cmbBR_Pathology_M.Title.Text = "是否远端转移";
         edtBR_Pathology_LymphRate_Titleformat = 0;
         edtBR_Pathology_LymphRate_Title = "淋巴结转移比例";
         edtBR_Pathology_LymphNum_Titleformat = 0;
         edtBR_Pathology_LymphNum_Title = "淋巴结数目";
         cmbBR_Pathology_N_Titleformat = 0;
         cmbBR_Pathology_N.Title.Text = "是否淋巴结转移";
         edtBR_Pathology_T_Titleformat = 0;
         edtBR_Pathology_T_Title = "原发肿瘤分级";
         edtBR_Pathology_Dia_Name_Titleformat = 0;
         edtBR_Pathology_Dia_Name_Title = "病理诊断名称";
         edtBR_PathologyID_PAResult_Titleformat = 0;
         edtBR_PathologyID_PAResult_Title = "病理描述";
         edtBR_PathologyID_PrePaDia_Titleformat = 0;
         edtBR_PathologyID_PrePaDia_Title = "病理前诊断";
         edtBR_PathologyID_PAAge_Titleformat = 0;
         edtBR_PathologyID_PAAge_Title = "年龄";
         edtBR_PathologyID_PAHosp_Titleformat = 0;
         edtBR_PathologyID_PAHosp_Title = "检查医院";
         edtBR_PathologyID_PADate_Titleformat = 0;
         edtBR_PathologyID_PADate_Title = "病理检查日期";
         edtBR_PathologyID_TestID_Titleformat = 0;
         edtBR_PathologyID_TestID_Title = "项目序号";
         edtBR_Information_PatientNo_Titleformat = 0;
         edtBR_Information_PatientNo_Title = "患者编号";
         edtBR_EncounterID_Titleformat = 0;
         edtBR_EncounterID_Title = "就诊信息主键";
         edtBR_PathologyID_Titleformat = 0;
         edtBR_PathologyID_Title = "病理学主键";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         divTablemain_Height = 0;
         Ddo_br_pathology_metaloc_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_metaloc_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_metaloc_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_metaloc_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_metaloc_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathology_metaloc_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_metaloc_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_metaloc_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_metaloc_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_metaloc_Cls = "ColumnSettings";
         Ddo_br_pathology_metaloc_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_metaloc_Caption = "";
         Ddo_br_pathology_m_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_m_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_m_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_m_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_m_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathology_m_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_m_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_m_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_m_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_m_Cls = "ColumnSettings";
         Ddo_br_pathology_m_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_m_Caption = "";
         Ddo_br_pathology_lymphrate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_lymphrate_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_lymphrate_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_lymphrate_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_lymphrate_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathology_lymphrate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_lymphrate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_lymphrate_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_lymphrate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_lymphrate_Cls = "ColumnSettings";
         Ddo_br_pathology_lymphrate_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_lymphrate_Caption = "";
         Ddo_br_pathology_lymphnum_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_lymphnum_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_lymphnum_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_lymphnum_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_lymphnum_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathology_lymphnum_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_lymphnum_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_lymphnum_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_lymphnum_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_lymphnum_Cls = "ColumnSettings";
         Ddo_br_pathology_lymphnum_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_lymphnum_Caption = "";
         Ddo_br_pathology_n_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_n_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_n_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_n_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_n_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathology_n_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_n_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_n_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_n_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_n_Cls = "ColumnSettings";
         Ddo_br_pathology_n_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_n_Caption = "";
         Ddo_br_pathology_t_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_t_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_t_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_t_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_t_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathology_t_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_t_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_t_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_t_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_t_Cls = "ColumnSettings";
         Ddo_br_pathology_t_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_t_Caption = "";
         Ddo_br_pathology_dia_name_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_dia_name_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_dia_name_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_dia_name_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_dia_name_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathology_dia_name_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_dia_name_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_dia_name_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_dia_name_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_dia_name_Cls = "ColumnSettings";
         Ddo_br_pathology_dia_name_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_dia_name_Caption = "";
         Ddo_br_pathologyid_paresult_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathologyid_paresult_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathologyid_paresult_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathologyid_paresult_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathologyid_paresult_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathologyid_paresult_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_paresult_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_paresult_Titlecontrolidtoreplace = "";
         Ddo_br_pathologyid_paresult_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathologyid_paresult_Cls = "ColumnSettings";
         Ddo_br_pathologyid_paresult_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathologyid_paresult_Caption = "";
         Ddo_br_pathologyid_prepadia_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathologyid_prepadia_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathologyid_prepadia_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathologyid_prepadia_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathologyid_prepadia_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathologyid_prepadia_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_prepadia_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_prepadia_Titlecontrolidtoreplace = "";
         Ddo_br_pathologyid_prepadia_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathologyid_prepadia_Cls = "ColumnSettings";
         Ddo_br_pathologyid_prepadia_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathologyid_prepadia_Caption = "";
         Ddo_br_pathologyid_paage_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathologyid_paage_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathologyid_paage_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathologyid_paage_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathologyid_paage_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathologyid_paage_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_paage_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_paage_Titlecontrolidtoreplace = "";
         Ddo_br_pathologyid_paage_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathologyid_paage_Cls = "ColumnSettings";
         Ddo_br_pathologyid_paage_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathologyid_paage_Caption = "";
         Ddo_br_pathologyid_pahosp_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathologyid_pahosp_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathologyid_pahosp_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathologyid_pahosp_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathologyid_pahosp_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathologyid_pahosp_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_pahosp_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_pahosp_Titlecontrolidtoreplace = "";
         Ddo_br_pathologyid_pahosp_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathologyid_pahosp_Cls = "ColumnSettings";
         Ddo_br_pathologyid_pahosp_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathologyid_pahosp_Caption = "";
         Ddo_br_pathologyid_padate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathologyid_padate_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathologyid_padate_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathologyid_padate_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathologyid_padate_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathologyid_padate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_padate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_padate_Titlecontrolidtoreplace = "";
         Ddo_br_pathologyid_padate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathologyid_padate_Cls = "ColumnSettings";
         Ddo_br_pathologyid_padate_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathologyid_padate_Caption = "";
         Ddo_br_pathologyid_testid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathologyid_testid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathologyid_testid_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathologyid_testid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathologyid_testid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathologyid_testid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_testid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_testid_Titlecontrolidtoreplace = "";
         Ddo_br_pathologyid_testid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathologyid_testid_Cls = "ColumnSettings";
         Ddo_br_pathologyid_testid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathologyid_testid_Caption = "";
         Ddo_br_information_patientno_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_information_patientno_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_information_patientno_Sortasc = "WWP_TSSortASC";
         Ddo_br_information_patientno_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_information_patientno_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_information_patientno_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_information_patientno_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_information_patientno_Titlecontrolidtoreplace = "";
         Ddo_br_information_patientno_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_information_patientno_Cls = "ColumnSettings";
         Ddo_br_information_patientno_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_information_patientno_Caption = "";
         Ddo_br_encounterid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounterid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounterid_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounterid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounterid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounterid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounterid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounterid_Titlecontrolidtoreplace = "";
         Ddo_br_encounterid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounterid_Cls = "ColumnSettings";
         Ddo_br_encounterid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounterid_Caption = "";
         Ddo_br_pathologyid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathologyid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathologyid_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathologyid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathologyid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathologyid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_Titlecontrolidtoreplace = "";
         Ddo_br_pathologyid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathologyid_Cls = "ColumnSettings";
         Ddo_br_pathologyid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathologyid_Caption = "";
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
         Form.Caption = "选择病理学";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV13BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV21BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV23BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV25BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV27BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV29BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV49BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV37BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV39BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV41BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV43BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV45BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV47BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV33GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV34GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV35GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E115M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E125M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_PATHOLOGYID.ONOPTIONCLICKED","{handler:'E135M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_pathologyid_Activeeventkey',ctrl:'DDO_BR_PATHOLOGYID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGYID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'AV13BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV21BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV23BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV25BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV27BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV29BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV49BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV37BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV39BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV41BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV43BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV45BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV47BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV33GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV34GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV35GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED","{handler:'E145M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_encounterid_Activeeventkey',ctrl:'DDO_BR_ENCOUNTERID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'AV13BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV21BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV23BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV25BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV27BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV29BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV49BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV37BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV39BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV41BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV43BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV45BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV47BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV33GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV34GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV35GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED","{handler:'E155M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_information_patientno_Activeeventkey',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'AV13BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV21BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV23BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV25BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV27BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV29BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV49BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV37BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV39BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV41BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV43BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV45BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV47BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV33GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV34GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV35GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PATHOLOGYID_TESTID.ONOPTIONCLICKED","{handler:'E165M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_pathologyid_testid_Activeeventkey',ctrl:'DDO_BR_PATHOLOGYID_TESTID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGYID_TESTID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathologyid_testid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_TESTID',prop:'SortedStatus'},{av:'AV13BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV21BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV23BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV25BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV27BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV29BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV49BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV37BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV39BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV41BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV43BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV45BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV47BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV33GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV34GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV35GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PATHOLOGYID_PADATE.ONOPTIONCLICKED","{handler:'E175M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_pathologyid_padate_Activeeventkey',ctrl:'DDO_BR_PATHOLOGYID_PADATE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGYID_PADATE.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathologyid_padate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PADATE',prop:'SortedStatus'},{av:'AV13BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV21BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV23BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV25BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV27BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV29BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV49BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV37BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV39BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV41BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV43BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV45BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV47BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV33GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV34GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV35GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PATHOLOGYID_PAHOSP.ONOPTIONCLICKED","{handler:'E185M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_pathologyid_pahosp_Activeeventkey',ctrl:'DDO_BR_PATHOLOGYID_PAHOSP',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGYID_PAHOSP.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathologyid_pahosp_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAHOSP',prop:'SortedStatus'},{av:'AV13BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV21BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV23BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV25BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV27BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV29BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV49BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV37BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV39BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV41BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV43BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV45BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV47BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV33GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV34GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV35GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PATHOLOGYID_PAAGE.ONOPTIONCLICKED","{handler:'E195M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_pathologyid_paage_Activeeventkey',ctrl:'DDO_BR_PATHOLOGYID_PAAGE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGYID_PAAGE.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathologyid_paage_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAAGE',prop:'SortedStatus'},{av:'AV13BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV21BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV23BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV25BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV27BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV29BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV49BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV37BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV39BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV41BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV43BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV45BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV47BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV33GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV34GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV35GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PATHOLOGYID_PREPADIA.ONOPTIONCLICKED","{handler:'E205M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_pathologyid_prepadia_Activeeventkey',ctrl:'DDO_BR_PATHOLOGYID_PREPADIA',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGYID_PREPADIA.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathologyid_prepadia_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PREPADIA',prop:'SortedStatus'},{av:'AV13BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV21BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV23BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV25BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV27BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV29BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV49BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV37BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV39BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV41BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV43BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV45BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV47BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV33GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV34GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV35GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PATHOLOGYID_PARESULT.ONOPTIONCLICKED","{handler:'E215M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_pathologyid_paresult_Activeeventkey',ctrl:'DDO_BR_PATHOLOGYID_PARESULT',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGYID_PARESULT.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathologyid_paresult_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PARESULT',prop:'SortedStatus'},{av:'AV13BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV21BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV23BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV25BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV27BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV29BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV49BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV37BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV39BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV41BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV43BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV45BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV47BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV33GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV34GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV35GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_DIA_NAME.ONOPTIONCLICKED","{handler:'E225M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_pathology_dia_name_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_DIA_NAME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_DIA_NAME.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_dia_name_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIA_NAME',prop:'SortedStatus'},{av:'AV13BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV21BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV23BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV25BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV27BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV29BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV49BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV37BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV39BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV41BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV43BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV45BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV47BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV33GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV34GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV35GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_T.ONOPTIONCLICKED","{handler:'E235M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_pathology_t_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_T',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_T.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_t_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_T',prop:'SortedStatus'},{av:'AV13BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV21BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV23BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV25BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV27BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV29BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV49BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV37BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV39BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV41BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV43BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV45BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV47BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV33GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV34GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV35GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_N.ONOPTIONCLICKED","{handler:'E245M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_pathology_n_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_N',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_N.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_n_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_N',prop:'SortedStatus'},{av:'AV13BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV21BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV23BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV25BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV27BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV29BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV49BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV37BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV39BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV41BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV43BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV45BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV47BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV33GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV34GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV35GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_LYMPHNUM.ONOPTIONCLICKED","{handler:'E255M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_pathology_lymphnum_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_LYMPHNUM',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_LYMPHNUM.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_lymphnum_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHNUM',prop:'SortedStatus'},{av:'AV13BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV21BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV23BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV25BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV27BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV29BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV49BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV37BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV39BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV41BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV43BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV45BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV47BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV33GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV34GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV35GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_LYMPHRATE.ONOPTIONCLICKED","{handler:'E265M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_pathology_lymphrate_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_LYMPHRATE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_LYMPHRATE.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_lymphrate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHRATE',prop:'SortedStatus'},{av:'AV13BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV21BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV23BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV25BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV27BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV29BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV49BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV37BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV39BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV41BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV43BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV45BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV47BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV33GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV34GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV35GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_M.ONOPTIONCLICKED","{handler:'E275M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_pathology_m_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_M',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_M.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_m_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_M',prop:'SortedStatus'},{av:'AV13BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV21BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV23BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV25BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV27BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV29BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV49BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV37BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV39BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV41BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV43BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV45BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV47BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV33GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV34GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV35GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_METALOC.ONOPTIONCLICKED","{handler:'E285M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_pathology_metaloc_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_METALOC',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_METALOC.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_metaloc_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_METALOC',prop:'SortedStatus'},{av:'AV13BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV21BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV23BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV25BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV27BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV29BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV49BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV37BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV39BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV41BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV43BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV45BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV47BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV33GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV34GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV35GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E315M2',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV36Select',fld:'vSELECT',pic:''},{av:'edtavSelect_Tooltiptext',ctrl:'vSELECT',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E325M2',iparms:[{av:'A226BR_PathologyID',fld:'BR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A237BR_PathologyID_TestID',fld:'BR_PATHOLOGYID_TESTID',pic:'ZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV8InOutBR_PathologyID',fld:'vINOUTBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV9InOutBR_PathologyID_TestID',fld:'vINOUTBR_PATHOLOGYID_TESTID',pic:'ZZZZZZZZZZ'}]}");
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
         Ddo_br_pathologyid_Activeeventkey = "";
         Ddo_br_encounterid_Activeeventkey = "";
         Ddo_br_information_patientno_Activeeventkey = "";
         Ddo_br_pathologyid_testid_Activeeventkey = "";
         Ddo_br_pathologyid_padate_Activeeventkey = "";
         Ddo_br_pathologyid_pahosp_Activeeventkey = "";
         Ddo_br_pathologyid_paage_Activeeventkey = "";
         Ddo_br_pathologyid_prepadia_Activeeventkey = "";
         Ddo_br_pathologyid_paresult_Activeeventkey = "";
         Ddo_br_pathology_dia_name_Activeeventkey = "";
         Ddo_br_pathology_t_Activeeventkey = "";
         Ddo_br_pathology_n_Activeeventkey = "";
         Ddo_br_pathology_lymphnum_Activeeventkey = "";
         Ddo_br_pathology_lymphrate_Activeeventkey = "";
         Ddo_br_pathology_m_Activeeventkey = "";
         Ddo_br_pathology_metaloc_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV14ddo_BR_PathologyIDTitleControlIdToReplace = "";
         AV16ddo_BR_EncounterIDTitleControlIdToReplace = "";
         AV18ddo_BR_Information_PatientNoTitleControlIdToReplace = "";
         AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace = "";
         AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace = "";
         AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace = "";
         AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace = "";
         AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace = "";
         AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace = "";
         AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace = "";
         AV38ddo_BR_Pathology_TTitleControlIdToReplace = "";
         AV40ddo_BR_Pathology_NTitleControlIdToReplace = "";
         AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace = "";
         AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace = "";
         AV46ddo_BR_Pathology_MTitleControlIdToReplace = "";
         AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace = "";
         GXKey = "";
         AV53Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV31DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV13BR_PathologyIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17BR_Information_PatientNoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19BR_PathologyID_TestIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_PathologyID_PADateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV23BR_PathologyID_PAHospTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV25BR_PathologyID_PAAgeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV27BR_PathologyID_PrePaDiaTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV29BR_PathologyID_PAResultTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV49BR_Pathology_Dia_NameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV37BR_Pathology_TTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV39BR_Pathology_NTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV41BR_Pathology_LymphNumTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV43BR_Pathology_LymphRateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV45BR_Pathology_MTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV47BR_Pathology_MetaLocTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_pathologyid_Sortedstatus = "";
         Ddo_br_encounterid_Sortedstatus = "";
         Ddo_br_information_patientno_Sortedstatus = "";
         Ddo_br_pathologyid_testid_Sortedstatus = "";
         Ddo_br_pathologyid_padate_Sortedstatus = "";
         Ddo_br_pathologyid_pahosp_Sortedstatus = "";
         Ddo_br_pathologyid_paage_Sortedstatus = "";
         Ddo_br_pathologyid_prepadia_Sortedstatus = "";
         Ddo_br_pathologyid_paresult_Sortedstatus = "";
         Ddo_br_pathology_dia_name_Sortedstatus = "";
         Ddo_br_pathology_t_Sortedstatus = "";
         Ddo_br_pathology_n_Sortedstatus = "";
         Ddo_br_pathology_lymphnum_Sortedstatus = "";
         Ddo_br_pathology_lymphrate_Sortedstatus = "";
         Ddo_br_pathology_m_Sortedstatus = "";
         Ddo_br_pathology_metaloc_Sortedstatus = "";
         GX_FocusControl = "";
         sPrefix = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV36Select = "";
         A36BR_Information_PatientNo = "";
         A238BR_PathologyID_PADate = DateTime.MinValue;
         A239BR_PathologyID_PAHosp = "";
         A241BR_PathologyID_PrePaDia = "";
         A242BR_PathologyID_PAResult = "";
         A326BR_Pathology_Dia_Name = "";
         A315BR_Pathology_N = "";
         A317BR_Pathology_LymphRate = "";
         A318BR_Pathology_M = "";
         A319BR_Pathology_MetaLoc = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_pathologyid = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_br_encounterid = new GXUserControl();
         ucDdo_br_information_patientno = new GXUserControl();
         ucDdo_br_pathologyid_testid = new GXUserControl();
         ucDdo_br_pathologyid_padate = new GXUserControl();
         ucDdo_br_pathologyid_pahosp = new GXUserControl();
         ucDdo_br_pathologyid_paage = new GXUserControl();
         ucDdo_br_pathologyid_prepadia = new GXUserControl();
         ucDdo_br_pathologyid_paresult = new GXUserControl();
         ucDdo_br_pathology_dia_name = new GXUserControl();
         ucDdo_br_pathology_t = new GXUserControl();
         ucDdo_br_pathology_n = new GXUserControl();
         ucDdo_br_pathology_lymphnum = new GXUserControl();
         ucDdo_br_pathology_lymphrate = new GXUserControl();
         ucDdo_br_pathology_m = new GXUserControl();
         ucDdo_br_pathology_metaloc = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV54Select_GXI = "";
         scmdbuf = "";
         H005M2_A85BR_Information_ID = new long[1] ;
         H005M2_n85BR_Information_ID = new bool[] {false} ;
         H005M2_A319BR_Pathology_MetaLoc = new String[] {""} ;
         H005M2_n319BR_Pathology_MetaLoc = new bool[] {false} ;
         H005M2_A318BR_Pathology_M = new String[] {""} ;
         H005M2_n318BR_Pathology_M = new bool[] {false} ;
         H005M2_A317BR_Pathology_LymphRate = new String[] {""} ;
         H005M2_n317BR_Pathology_LymphRate = new bool[] {false} ;
         H005M2_A316BR_Pathology_LymphNum = new decimal[1] ;
         H005M2_n316BR_Pathology_LymphNum = new bool[] {false} ;
         H005M2_A315BR_Pathology_N = new String[] {""} ;
         H005M2_n315BR_Pathology_N = new bool[] {false} ;
         H005M2_A314BR_Pathology_T = new decimal[1] ;
         H005M2_n314BR_Pathology_T = new bool[] {false} ;
         H005M2_A326BR_Pathology_Dia_Name = new String[] {""} ;
         H005M2_n326BR_Pathology_Dia_Name = new bool[] {false} ;
         H005M2_A242BR_PathologyID_PAResult = new String[] {""} ;
         H005M2_n242BR_PathologyID_PAResult = new bool[] {false} ;
         H005M2_A241BR_PathologyID_PrePaDia = new String[] {""} ;
         H005M2_n241BR_PathologyID_PrePaDia = new bool[] {false} ;
         H005M2_A240BR_PathologyID_PAAge = new short[1] ;
         H005M2_n240BR_PathologyID_PAAge = new bool[] {false} ;
         H005M2_A239BR_PathologyID_PAHosp = new String[] {""} ;
         H005M2_n239BR_PathologyID_PAHosp = new bool[] {false} ;
         H005M2_A238BR_PathologyID_PADate = new DateTime[] {DateTime.MinValue} ;
         H005M2_n238BR_PathologyID_PADate = new bool[] {false} ;
         H005M2_A237BR_PathologyID_TestID = new long[1] ;
         H005M2_n237BR_PathologyID_TestID = new bool[] {false} ;
         H005M2_A36BR_Information_PatientNo = new String[] {""} ;
         H005M2_n36BR_Information_PatientNo = new bool[] {false} ;
         H005M2_A19BR_EncounterID = new long[1] ;
         H005M2_n19BR_EncounterID = new bool[] {false} ;
         H005M2_A226BR_PathologyID = new long[1] ;
         H005M3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_pathologyprompt__default(),
            new Object[][] {
                new Object[] {
               H005M2_A85BR_Information_ID, H005M2_n85BR_Information_ID, H005M2_A319BR_Pathology_MetaLoc, H005M2_n319BR_Pathology_MetaLoc, H005M2_A318BR_Pathology_M, H005M2_n318BR_Pathology_M, H005M2_A317BR_Pathology_LymphRate, H005M2_n317BR_Pathology_LymphRate, H005M2_A316BR_Pathology_LymphNum, H005M2_n316BR_Pathology_LymphNum,
               H005M2_A315BR_Pathology_N, H005M2_n315BR_Pathology_N, H005M2_A314BR_Pathology_T, H005M2_n314BR_Pathology_T, H005M2_A326BR_Pathology_Dia_Name, H005M2_n326BR_Pathology_Dia_Name, H005M2_A242BR_PathologyID_PAResult, H005M2_n242BR_PathologyID_PAResult, H005M2_A241BR_PathologyID_PrePaDia, H005M2_n241BR_PathologyID_PrePaDia,
               H005M2_A240BR_PathologyID_PAAge, H005M2_n240BR_PathologyID_PAAge, H005M2_A239BR_PathologyID_PAHosp, H005M2_n239BR_PathologyID_PAHosp, H005M2_A238BR_PathologyID_PADate, H005M2_n238BR_PathologyID_PADate, H005M2_A237BR_PathologyID_TestID, H005M2_n237BR_PathologyID_TestID, H005M2_A36BR_Information_PatientNo, H005M2_n36BR_Information_PatientNo,
               H005M2_A19BR_EncounterID, H005M2_n19BR_EncounterID, H005M2_A226BR_PathologyID
               }
               , new Object[] {
               H005M3_AGRID_nRecordCount
               }
            }
         );
         AV53Pgmname = "BR_PathologyPrompt";
         /* GeneXus formulas. */
         AV53Pgmname = "BR_PathologyPrompt";
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
      private short edtBR_PathologyID_Titleformat ;
      private short edtBR_EncounterID_Titleformat ;
      private short edtBR_Information_PatientNo_Titleformat ;
      private short edtBR_PathologyID_TestID_Titleformat ;
      private short edtBR_PathologyID_PADate_Titleformat ;
      private short edtBR_PathologyID_PAHosp_Titleformat ;
      private short edtBR_PathologyID_PAAge_Titleformat ;
      private short edtBR_PathologyID_PrePaDia_Titleformat ;
      private short edtBR_PathologyID_PAResult_Titleformat ;
      private short edtBR_Pathology_Dia_Name_Titleformat ;
      private short edtBR_Pathology_T_Titleformat ;
      private short cmbBR_Pathology_N_Titleformat ;
      private short edtBR_Pathology_LymphNum_Titleformat ;
      private short edtBR_Pathology_LymphRate_Titleformat ;
      private short cmbBR_Pathology_M_Titleformat ;
      private short edtBR_Pathology_MetaLoc_Titleformat ;
      private short subGrid_Sortable ;
      private short A240BR_PathologyID_PAAge ;
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
      private int edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathologyid_testidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathologyid_padatetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathologyid_pahosptitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathologyid_paagetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathologyid_prepadiatitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathologyid_paresulttitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_dia_nametitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_ttitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_ntitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_lymphnumtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_lymphratetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_mtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_metaloctitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV32PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavSelect_Enabled ;
      private int edtavSelect_Visible ;
      private long AV8InOutBR_PathologyID ;
      private long AV9InOutBR_PathologyID_TestID ;
      private long wcpOAV8InOutBR_PathologyID ;
      private long wcpOAV9InOutBR_PathologyID_TestID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV33GridCurrentPage ;
      private long AV35GridRecordCount ;
      private long AV34GridPageSize ;
      private long A226BR_PathologyID ;
      private long A19BR_EncounterID ;
      private long A237BR_PathologyID_TestID ;
      private long GRID_nCurrentRecord ;
      private long A85BR_Information_ID ;
      private long GRID_nRecordCount ;
      private decimal A314BR_Pathology_T ;
      private decimal A316BR_Pathology_LymphNum ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_pathologyid_Activeeventkey ;
      private String Ddo_br_encounterid_Activeeventkey ;
      private String Ddo_br_information_patientno_Activeeventkey ;
      private String Ddo_br_pathologyid_testid_Activeeventkey ;
      private String Ddo_br_pathologyid_padate_Activeeventkey ;
      private String Ddo_br_pathologyid_pahosp_Activeeventkey ;
      private String Ddo_br_pathologyid_paage_Activeeventkey ;
      private String Ddo_br_pathologyid_prepadia_Activeeventkey ;
      private String Ddo_br_pathologyid_paresult_Activeeventkey ;
      private String Ddo_br_pathology_dia_name_Activeeventkey ;
      private String Ddo_br_pathology_t_Activeeventkey ;
      private String Ddo_br_pathology_n_Activeeventkey ;
      private String Ddo_br_pathology_lymphnum_Activeeventkey ;
      private String Ddo_br_pathology_lymphrate_Activeeventkey ;
      private String Ddo_br_pathology_m_Activeeventkey ;
      private String Ddo_br_pathology_metaloc_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_12_idx="0001" ;
      private String GXKey ;
      private String AV53Pgmname ;
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
      private String Ddo_br_pathologyid_Caption ;
      private String Ddo_br_pathologyid_Tooltip ;
      private String Ddo_br_pathologyid_Cls ;
      private String Ddo_br_pathologyid_Dropdownoptionstype ;
      private String Ddo_br_pathologyid_Titlecontrolidtoreplace ;
      private String Ddo_br_pathologyid_Sortedstatus ;
      private String Ddo_br_pathologyid_Sortasc ;
      private String Ddo_br_pathologyid_Sortdsc ;
      private String Ddo_br_pathologyid_Searchbuttontext ;
      private String Ddo_br_encounterid_Caption ;
      private String Ddo_br_encounterid_Tooltip ;
      private String Ddo_br_encounterid_Cls ;
      private String Ddo_br_encounterid_Dropdownoptionstype ;
      private String Ddo_br_encounterid_Titlecontrolidtoreplace ;
      private String Ddo_br_encounterid_Sortedstatus ;
      private String Ddo_br_encounterid_Sortasc ;
      private String Ddo_br_encounterid_Sortdsc ;
      private String Ddo_br_encounterid_Searchbuttontext ;
      private String Ddo_br_information_patientno_Caption ;
      private String Ddo_br_information_patientno_Tooltip ;
      private String Ddo_br_information_patientno_Cls ;
      private String Ddo_br_information_patientno_Dropdownoptionstype ;
      private String Ddo_br_information_patientno_Titlecontrolidtoreplace ;
      private String Ddo_br_information_patientno_Sortedstatus ;
      private String Ddo_br_information_patientno_Sortasc ;
      private String Ddo_br_information_patientno_Sortdsc ;
      private String Ddo_br_information_patientno_Searchbuttontext ;
      private String Ddo_br_pathologyid_testid_Caption ;
      private String Ddo_br_pathologyid_testid_Tooltip ;
      private String Ddo_br_pathologyid_testid_Cls ;
      private String Ddo_br_pathologyid_testid_Dropdownoptionstype ;
      private String Ddo_br_pathologyid_testid_Titlecontrolidtoreplace ;
      private String Ddo_br_pathologyid_testid_Sortedstatus ;
      private String Ddo_br_pathologyid_testid_Sortasc ;
      private String Ddo_br_pathologyid_testid_Sortdsc ;
      private String Ddo_br_pathologyid_testid_Searchbuttontext ;
      private String Ddo_br_pathologyid_padate_Caption ;
      private String Ddo_br_pathologyid_padate_Tooltip ;
      private String Ddo_br_pathologyid_padate_Cls ;
      private String Ddo_br_pathologyid_padate_Dropdownoptionstype ;
      private String Ddo_br_pathologyid_padate_Titlecontrolidtoreplace ;
      private String Ddo_br_pathologyid_padate_Sortedstatus ;
      private String Ddo_br_pathologyid_padate_Sortasc ;
      private String Ddo_br_pathologyid_padate_Sortdsc ;
      private String Ddo_br_pathologyid_padate_Searchbuttontext ;
      private String Ddo_br_pathologyid_pahosp_Caption ;
      private String Ddo_br_pathologyid_pahosp_Tooltip ;
      private String Ddo_br_pathologyid_pahosp_Cls ;
      private String Ddo_br_pathologyid_pahosp_Dropdownoptionstype ;
      private String Ddo_br_pathologyid_pahosp_Titlecontrolidtoreplace ;
      private String Ddo_br_pathologyid_pahosp_Sortedstatus ;
      private String Ddo_br_pathologyid_pahosp_Sortasc ;
      private String Ddo_br_pathologyid_pahosp_Sortdsc ;
      private String Ddo_br_pathologyid_pahosp_Searchbuttontext ;
      private String Ddo_br_pathologyid_paage_Caption ;
      private String Ddo_br_pathologyid_paage_Tooltip ;
      private String Ddo_br_pathologyid_paage_Cls ;
      private String Ddo_br_pathologyid_paage_Dropdownoptionstype ;
      private String Ddo_br_pathologyid_paage_Titlecontrolidtoreplace ;
      private String Ddo_br_pathologyid_paage_Sortedstatus ;
      private String Ddo_br_pathologyid_paage_Sortasc ;
      private String Ddo_br_pathologyid_paage_Sortdsc ;
      private String Ddo_br_pathologyid_paage_Searchbuttontext ;
      private String Ddo_br_pathologyid_prepadia_Caption ;
      private String Ddo_br_pathologyid_prepadia_Tooltip ;
      private String Ddo_br_pathologyid_prepadia_Cls ;
      private String Ddo_br_pathologyid_prepadia_Dropdownoptionstype ;
      private String Ddo_br_pathologyid_prepadia_Titlecontrolidtoreplace ;
      private String Ddo_br_pathologyid_prepadia_Sortedstatus ;
      private String Ddo_br_pathologyid_prepadia_Sortasc ;
      private String Ddo_br_pathologyid_prepadia_Sortdsc ;
      private String Ddo_br_pathologyid_prepadia_Searchbuttontext ;
      private String Ddo_br_pathologyid_paresult_Caption ;
      private String Ddo_br_pathologyid_paresult_Tooltip ;
      private String Ddo_br_pathologyid_paresult_Cls ;
      private String Ddo_br_pathologyid_paresult_Dropdownoptionstype ;
      private String Ddo_br_pathologyid_paresult_Titlecontrolidtoreplace ;
      private String Ddo_br_pathologyid_paresult_Sortedstatus ;
      private String Ddo_br_pathologyid_paresult_Sortasc ;
      private String Ddo_br_pathologyid_paresult_Sortdsc ;
      private String Ddo_br_pathologyid_paresult_Searchbuttontext ;
      private String Ddo_br_pathology_dia_name_Caption ;
      private String Ddo_br_pathology_dia_name_Tooltip ;
      private String Ddo_br_pathology_dia_name_Cls ;
      private String Ddo_br_pathology_dia_name_Dropdownoptionstype ;
      private String Ddo_br_pathology_dia_name_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_dia_name_Sortedstatus ;
      private String Ddo_br_pathology_dia_name_Sortasc ;
      private String Ddo_br_pathology_dia_name_Sortdsc ;
      private String Ddo_br_pathology_dia_name_Searchbuttontext ;
      private String Ddo_br_pathology_t_Caption ;
      private String Ddo_br_pathology_t_Tooltip ;
      private String Ddo_br_pathology_t_Cls ;
      private String Ddo_br_pathology_t_Dropdownoptionstype ;
      private String Ddo_br_pathology_t_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_t_Sortedstatus ;
      private String Ddo_br_pathology_t_Sortasc ;
      private String Ddo_br_pathology_t_Sortdsc ;
      private String Ddo_br_pathology_t_Searchbuttontext ;
      private String Ddo_br_pathology_n_Caption ;
      private String Ddo_br_pathology_n_Tooltip ;
      private String Ddo_br_pathology_n_Cls ;
      private String Ddo_br_pathology_n_Dropdownoptionstype ;
      private String Ddo_br_pathology_n_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_n_Sortedstatus ;
      private String Ddo_br_pathology_n_Sortasc ;
      private String Ddo_br_pathology_n_Sortdsc ;
      private String Ddo_br_pathology_n_Searchbuttontext ;
      private String Ddo_br_pathology_lymphnum_Caption ;
      private String Ddo_br_pathology_lymphnum_Tooltip ;
      private String Ddo_br_pathology_lymphnum_Cls ;
      private String Ddo_br_pathology_lymphnum_Dropdownoptionstype ;
      private String Ddo_br_pathology_lymphnum_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_lymphnum_Sortedstatus ;
      private String Ddo_br_pathology_lymphnum_Sortasc ;
      private String Ddo_br_pathology_lymphnum_Sortdsc ;
      private String Ddo_br_pathology_lymphnum_Searchbuttontext ;
      private String Ddo_br_pathology_lymphrate_Caption ;
      private String Ddo_br_pathology_lymphrate_Tooltip ;
      private String Ddo_br_pathology_lymphrate_Cls ;
      private String Ddo_br_pathology_lymphrate_Dropdownoptionstype ;
      private String Ddo_br_pathology_lymphrate_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_lymphrate_Sortedstatus ;
      private String Ddo_br_pathology_lymphrate_Sortasc ;
      private String Ddo_br_pathology_lymphrate_Sortdsc ;
      private String Ddo_br_pathology_lymphrate_Searchbuttontext ;
      private String Ddo_br_pathology_m_Caption ;
      private String Ddo_br_pathology_m_Tooltip ;
      private String Ddo_br_pathology_m_Cls ;
      private String Ddo_br_pathology_m_Dropdownoptionstype ;
      private String Ddo_br_pathology_m_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_m_Sortedstatus ;
      private String Ddo_br_pathology_m_Sortasc ;
      private String Ddo_br_pathology_m_Sortdsc ;
      private String Ddo_br_pathology_m_Searchbuttontext ;
      private String Ddo_br_pathology_metaloc_Caption ;
      private String Ddo_br_pathology_metaloc_Tooltip ;
      private String Ddo_br_pathology_metaloc_Cls ;
      private String Ddo_br_pathology_metaloc_Dropdownoptionstype ;
      private String Ddo_br_pathology_metaloc_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_metaloc_Sortedstatus ;
      private String Ddo_br_pathology_metaloc_Sortasc ;
      private String Ddo_br_pathology_metaloc_Sortdsc ;
      private String Ddo_br_pathology_metaloc_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtBR_PathologyID_Title ;
      private String edtBR_EncounterID_Title ;
      private String edtBR_Information_PatientNo_Title ;
      private String edtBR_PathologyID_TestID_Title ;
      private String edtBR_PathologyID_PADate_Title ;
      private String edtBR_PathologyID_PAHosp_Title ;
      private String edtBR_PathologyID_PAAge_Title ;
      private String edtBR_PathologyID_PrePaDia_Title ;
      private String edtBR_PathologyID_PAResult_Title ;
      private String edtBR_Pathology_Dia_Name_Title ;
      private String edtBR_Pathology_T_Title ;
      private String edtBR_Pathology_LymphNum_Title ;
      private String edtBR_Pathology_LymphRate_Title ;
      private String edtBR_Pathology_MetaLoc_Title ;
      private String subGrid_Header ;
      private String edtavSelect_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_pathologyid_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounterid_Internalname ;
      private String edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_information_patientno_Internalname ;
      private String edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathologyid_testid_Internalname ;
      private String edtavDdo_br_pathologyid_testidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathologyid_padate_Internalname ;
      private String edtavDdo_br_pathologyid_padatetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathologyid_pahosp_Internalname ;
      private String edtavDdo_br_pathologyid_pahosptitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathologyid_paage_Internalname ;
      private String edtavDdo_br_pathologyid_paagetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathologyid_prepadia_Internalname ;
      private String edtavDdo_br_pathologyid_prepadiatitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathologyid_paresult_Internalname ;
      private String edtavDdo_br_pathologyid_paresulttitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_dia_name_Internalname ;
      private String edtavDdo_br_pathology_dia_nametitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_t_Internalname ;
      private String edtavDdo_br_pathology_ttitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_n_Internalname ;
      private String edtavDdo_br_pathology_ntitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_lymphnum_Internalname ;
      private String edtavDdo_br_pathology_lymphnumtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_lymphrate_Internalname ;
      private String edtavDdo_br_pathology_lymphratetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_m_Internalname ;
      private String edtavDdo_br_pathology_mtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_metaloc_Internalname ;
      private String edtavDdo_br_pathology_metaloctitlecontrolidtoreplace_Internalname ;
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
      private String edtBR_PathologyID_Internalname ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_PathologyID_TestID_Internalname ;
      private String edtBR_PathologyID_PADate_Internalname ;
      private String edtBR_PathologyID_PAHosp_Internalname ;
      private String edtBR_PathologyID_PAAge_Internalname ;
      private String edtBR_PathologyID_PrePaDia_Internalname ;
      private String edtBR_PathologyID_PAResult_Internalname ;
      private String edtBR_Pathology_Dia_Name_Internalname ;
      private String edtBR_Pathology_T_Internalname ;
      private String cmbBR_Pathology_N_Internalname ;
      private String edtBR_Pathology_LymphNum_Internalname ;
      private String edtBR_Pathology_LymphRate_Internalname ;
      private String cmbBR_Pathology_M_Internalname ;
      private String edtBR_Pathology_MetaLoc_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_12_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavSelect_Jsonclick ;
      private String ROClassString ;
      private String edtBR_PathologyID_Jsonclick ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String edtBR_PathologyID_TestID_Jsonclick ;
      private String edtBR_PathologyID_PADate_Jsonclick ;
      private String edtBR_PathologyID_PAHosp_Jsonclick ;
      private String edtBR_PathologyID_PAAge_Jsonclick ;
      private String edtBR_PathologyID_PrePaDia_Jsonclick ;
      private String edtBR_PathologyID_PAResult_Jsonclick ;
      private String edtBR_Pathology_Dia_Name_Jsonclick ;
      private String edtBR_Pathology_T_Jsonclick ;
      private String GXCCtl ;
      private String cmbBR_Pathology_N_Jsonclick ;
      private String edtBR_Pathology_LymphNum_Jsonclick ;
      private String edtBR_Pathology_LymphRate_Jsonclick ;
      private String cmbBR_Pathology_M_Jsonclick ;
      private String edtBR_Pathology_MetaLoc_Jsonclick ;
      private DateTime A238BR_PathologyID_PADate ;
      private bool entryPointCalled ;
      private bool AV12OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_br_pathologyid_Includesortasc ;
      private bool Ddo_br_pathologyid_Includesortdsc ;
      private bool Ddo_br_pathologyid_Includefilter ;
      private bool Ddo_br_pathologyid_Includedatalist ;
      private bool Ddo_br_encounterid_Includesortasc ;
      private bool Ddo_br_encounterid_Includesortdsc ;
      private bool Ddo_br_encounterid_Includefilter ;
      private bool Ddo_br_encounterid_Includedatalist ;
      private bool Ddo_br_information_patientno_Includesortasc ;
      private bool Ddo_br_information_patientno_Includesortdsc ;
      private bool Ddo_br_information_patientno_Includefilter ;
      private bool Ddo_br_information_patientno_Includedatalist ;
      private bool Ddo_br_pathologyid_testid_Includesortasc ;
      private bool Ddo_br_pathologyid_testid_Includesortdsc ;
      private bool Ddo_br_pathologyid_testid_Includefilter ;
      private bool Ddo_br_pathologyid_testid_Includedatalist ;
      private bool Ddo_br_pathologyid_padate_Includesortasc ;
      private bool Ddo_br_pathologyid_padate_Includesortdsc ;
      private bool Ddo_br_pathologyid_padate_Includefilter ;
      private bool Ddo_br_pathologyid_padate_Includedatalist ;
      private bool Ddo_br_pathologyid_pahosp_Includesortasc ;
      private bool Ddo_br_pathologyid_pahosp_Includesortdsc ;
      private bool Ddo_br_pathologyid_pahosp_Includefilter ;
      private bool Ddo_br_pathologyid_pahosp_Includedatalist ;
      private bool Ddo_br_pathologyid_paage_Includesortasc ;
      private bool Ddo_br_pathologyid_paage_Includesortdsc ;
      private bool Ddo_br_pathologyid_paage_Includefilter ;
      private bool Ddo_br_pathologyid_paage_Includedatalist ;
      private bool Ddo_br_pathologyid_prepadia_Includesortasc ;
      private bool Ddo_br_pathologyid_prepadia_Includesortdsc ;
      private bool Ddo_br_pathologyid_prepadia_Includefilter ;
      private bool Ddo_br_pathologyid_prepadia_Includedatalist ;
      private bool Ddo_br_pathologyid_paresult_Includesortasc ;
      private bool Ddo_br_pathologyid_paresult_Includesortdsc ;
      private bool Ddo_br_pathologyid_paresult_Includefilter ;
      private bool Ddo_br_pathologyid_paresult_Includedatalist ;
      private bool Ddo_br_pathology_dia_name_Includesortasc ;
      private bool Ddo_br_pathology_dia_name_Includesortdsc ;
      private bool Ddo_br_pathology_dia_name_Includefilter ;
      private bool Ddo_br_pathology_dia_name_Includedatalist ;
      private bool Ddo_br_pathology_t_Includesortasc ;
      private bool Ddo_br_pathology_t_Includesortdsc ;
      private bool Ddo_br_pathology_t_Includefilter ;
      private bool Ddo_br_pathology_t_Includedatalist ;
      private bool Ddo_br_pathology_n_Includesortasc ;
      private bool Ddo_br_pathology_n_Includesortdsc ;
      private bool Ddo_br_pathology_n_Includefilter ;
      private bool Ddo_br_pathology_n_Includedatalist ;
      private bool Ddo_br_pathology_lymphnum_Includesortasc ;
      private bool Ddo_br_pathology_lymphnum_Includesortdsc ;
      private bool Ddo_br_pathology_lymphnum_Includefilter ;
      private bool Ddo_br_pathology_lymphnum_Includedatalist ;
      private bool Ddo_br_pathology_lymphrate_Includesortasc ;
      private bool Ddo_br_pathology_lymphrate_Includesortdsc ;
      private bool Ddo_br_pathology_lymphrate_Includefilter ;
      private bool Ddo_br_pathology_lymphrate_Includedatalist ;
      private bool Ddo_br_pathology_m_Includesortasc ;
      private bool Ddo_br_pathology_m_Includesortdsc ;
      private bool Ddo_br_pathology_m_Includefilter ;
      private bool Ddo_br_pathology_m_Includedatalist ;
      private bool Ddo_br_pathology_metaloc_Includesortasc ;
      private bool Ddo_br_pathology_metaloc_Includesortdsc ;
      private bool Ddo_br_pathology_metaloc_Includefilter ;
      private bool Ddo_br_pathology_metaloc_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_12_Refreshing=false ;
      private bool n19BR_EncounterID ;
      private bool n36BR_Information_PatientNo ;
      private bool n237BR_PathologyID_TestID ;
      private bool n238BR_PathologyID_PADate ;
      private bool n239BR_PathologyID_PAHosp ;
      private bool n240BR_PathologyID_PAAge ;
      private bool n241BR_PathologyID_PrePaDia ;
      private bool n242BR_PathologyID_PAResult ;
      private bool n326BR_Pathology_Dia_Name ;
      private bool n314BR_Pathology_T ;
      private bool n315BR_Pathology_N ;
      private bool n316BR_Pathology_LymphNum ;
      private bool n317BR_Pathology_LymphRate ;
      private bool n318BR_Pathology_M ;
      private bool n319BR_Pathology_MetaLoc ;
      private bool gxdyncontrolsrefreshing ;
      private bool n85BR_Information_ID ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool gx_refresh_fired ;
      private bool AV36Select_IsBlob ;
      private String AV14ddo_BR_PathologyIDTitleControlIdToReplace ;
      private String AV16ddo_BR_EncounterIDTitleControlIdToReplace ;
      private String AV18ddo_BR_Information_PatientNoTitleControlIdToReplace ;
      private String AV20ddo_BR_PathologyID_TestIDTitleControlIdToReplace ;
      private String AV22ddo_BR_PathologyID_PADateTitleControlIdToReplace ;
      private String AV24ddo_BR_PathologyID_PAHospTitleControlIdToReplace ;
      private String AV26ddo_BR_PathologyID_PAAgeTitleControlIdToReplace ;
      private String AV28ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace ;
      private String AV30ddo_BR_PathologyID_PAResultTitleControlIdToReplace ;
      private String AV50ddo_BR_Pathology_Dia_NameTitleControlIdToReplace ;
      private String AV38ddo_BR_Pathology_TTitleControlIdToReplace ;
      private String AV40ddo_BR_Pathology_NTitleControlIdToReplace ;
      private String AV42ddo_BR_Pathology_LymphNumTitleControlIdToReplace ;
      private String AV44ddo_BR_Pathology_LymphRateTitleControlIdToReplace ;
      private String AV46ddo_BR_Pathology_MTitleControlIdToReplace ;
      private String AV48ddo_BR_Pathology_MetaLocTitleControlIdToReplace ;
      private String A36BR_Information_PatientNo ;
      private String A239BR_PathologyID_PAHosp ;
      private String A241BR_PathologyID_PrePaDia ;
      private String A242BR_PathologyID_PAResult ;
      private String A326BR_Pathology_Dia_Name ;
      private String A315BR_Pathology_N ;
      private String A317BR_Pathology_LymphRate ;
      private String A318BR_Pathology_M ;
      private String A319BR_Pathology_MetaLoc ;
      private String AV54Select_GXI ;
      private String AV36Select ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_pathologyid ;
      private GXUserControl ucDdo_br_encounterid ;
      private GXUserControl ucDdo_br_information_patientno ;
      private GXUserControl ucDdo_br_pathologyid_testid ;
      private GXUserControl ucDdo_br_pathologyid_padate ;
      private GXUserControl ucDdo_br_pathologyid_pahosp ;
      private GXUserControl ucDdo_br_pathologyid_paage ;
      private GXUserControl ucDdo_br_pathologyid_prepadia ;
      private GXUserControl ucDdo_br_pathologyid_paresult ;
      private GXUserControl ucDdo_br_pathology_dia_name ;
      private GXUserControl ucDdo_br_pathology_t ;
      private GXUserControl ucDdo_br_pathology_n ;
      private GXUserControl ucDdo_br_pathology_lymphnum ;
      private GXUserControl ucDdo_br_pathology_lymphrate ;
      private GXUserControl ucDdo_br_pathology_m ;
      private GXUserControl ucDdo_br_pathology_metaloc ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private long aP0_InOutBR_PathologyID ;
      private long aP1_InOutBR_PathologyID_TestID ;
      private GXCombobox cmbBR_Pathology_N ;
      private GXCombobox cmbBR_Pathology_M ;
      private IDataStoreProvider pr_default ;
      private long[] H005M2_A85BR_Information_ID ;
      private bool[] H005M2_n85BR_Information_ID ;
      private String[] H005M2_A319BR_Pathology_MetaLoc ;
      private bool[] H005M2_n319BR_Pathology_MetaLoc ;
      private String[] H005M2_A318BR_Pathology_M ;
      private bool[] H005M2_n318BR_Pathology_M ;
      private String[] H005M2_A317BR_Pathology_LymphRate ;
      private bool[] H005M2_n317BR_Pathology_LymphRate ;
      private decimal[] H005M2_A316BR_Pathology_LymphNum ;
      private bool[] H005M2_n316BR_Pathology_LymphNum ;
      private String[] H005M2_A315BR_Pathology_N ;
      private bool[] H005M2_n315BR_Pathology_N ;
      private decimal[] H005M2_A314BR_Pathology_T ;
      private bool[] H005M2_n314BR_Pathology_T ;
      private String[] H005M2_A326BR_Pathology_Dia_Name ;
      private bool[] H005M2_n326BR_Pathology_Dia_Name ;
      private String[] H005M2_A242BR_PathologyID_PAResult ;
      private bool[] H005M2_n242BR_PathologyID_PAResult ;
      private String[] H005M2_A241BR_PathologyID_PrePaDia ;
      private bool[] H005M2_n241BR_PathologyID_PrePaDia ;
      private short[] H005M2_A240BR_PathologyID_PAAge ;
      private bool[] H005M2_n240BR_PathologyID_PAAge ;
      private String[] H005M2_A239BR_PathologyID_PAHosp ;
      private bool[] H005M2_n239BR_PathologyID_PAHosp ;
      private DateTime[] H005M2_A238BR_PathologyID_PADate ;
      private bool[] H005M2_n238BR_PathologyID_PADate ;
      private long[] H005M2_A237BR_PathologyID_TestID ;
      private bool[] H005M2_n237BR_PathologyID_TestID ;
      private String[] H005M2_A36BR_Information_PatientNo ;
      private bool[] H005M2_n36BR_Information_PatientNo ;
      private long[] H005M2_A19BR_EncounterID ;
      private bool[] H005M2_n19BR_EncounterID ;
      private long[] H005M2_A226BR_PathologyID ;
      private long[] H005M3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV13BR_PathologyIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV15BR_EncounterIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV17BR_Information_PatientNoTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV19BR_PathologyID_TestIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV21BR_PathologyID_PADateTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV23BR_PathologyID_PAHospTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV25BR_PathologyID_PAAgeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV27BR_PathologyID_PrePaDiaTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV29BR_PathologyID_PAResultTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV49BR_Pathology_Dia_NameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV37BR_Pathology_TTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV39BR_Pathology_NTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV41BR_Pathology_LymphNumTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV43BR_Pathology_LymphRateTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV45BR_Pathology_MTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV47BR_Pathology_MetaLocTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV31DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class br_pathologyprompt__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H005M2( IGxContext context ,
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
         sSelectString = " T2.[BR_Information_ID], T1.[BR_Pathology_MetaLoc], T1.[BR_Pathology_M], T1.[BR_Pathology_LymphRate], T1.[BR_Pathology_LymphNum], T1.[BR_Pathology_N], T1.[BR_Pathology_T], T1.[BR_Pathology_Dia_Name], T1.[BR_PathologyID_PAResult], T1.[BR_PathologyID_PrePaDia], T1.[BR_PathologyID_PAAge], T1.[BR_PathologyID_PAHosp], T1.[BR_PathologyID_PADate], T1.[BR_PathologyID_TestID], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_PathologyID]";
         sFromString = " FROM (([BR_Pathology] T1 WITH (NOLOCK) LEFT JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         sOrderString = "";
         if ( ( AV11OrderedBy == 1 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_PathologyID]";
         }
         else if ( ( AV11OrderedBy == 1 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_PathologyID] DESC";
         }
         else if ( ( AV11OrderedBy == 2 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_EncounterID]";
         }
         else if ( ( AV11OrderedBy == 2 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_EncounterID] DESC";
         }
         else if ( ( AV11OrderedBy == 3 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T3.[BR_Information_PatientNo]";
         }
         else if ( ( AV11OrderedBy == 3 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T3.[BR_Information_PatientNo] DESC";
         }
         else if ( ( AV11OrderedBy == 4 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_PathologyID_TestID]";
         }
         else if ( ( AV11OrderedBy == 4 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_PathologyID_TestID] DESC";
         }
         else if ( ( AV11OrderedBy == 5 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_PathologyID_PADate]";
         }
         else if ( ( AV11OrderedBy == 5 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_PathologyID_PADate] DESC";
         }
         else if ( ( AV11OrderedBy == 6 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_PathologyID_PAHosp]";
         }
         else if ( ( AV11OrderedBy == 6 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_PathologyID_PAHosp] DESC";
         }
         else if ( ( AV11OrderedBy == 7 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_PathologyID_PAAge]";
         }
         else if ( ( AV11OrderedBy == 7 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_PathologyID_PAAge] DESC";
         }
         else if ( ( AV11OrderedBy == 8 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_PathologyID_PrePaDia]";
         }
         else if ( ( AV11OrderedBy == 8 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_PathologyID_PrePaDia] DESC";
         }
         else if ( ( AV11OrderedBy == 9 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_PathologyID_PAResult]";
         }
         else if ( ( AV11OrderedBy == 9 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_PathologyID_PAResult] DESC";
         }
         else if ( ( AV11OrderedBy == 10 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Pathology_Dia_Name]";
         }
         else if ( ( AV11OrderedBy == 10 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Pathology_Dia_Name] DESC";
         }
         else if ( ( AV11OrderedBy == 11 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Pathology_T]";
         }
         else if ( ( AV11OrderedBy == 11 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Pathology_T] DESC";
         }
         else if ( ( AV11OrderedBy == 12 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Pathology_N]";
         }
         else if ( ( AV11OrderedBy == 12 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Pathology_N] DESC";
         }
         else if ( ( AV11OrderedBy == 13 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Pathology_LymphNum]";
         }
         else if ( ( AV11OrderedBy == 13 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Pathology_LymphNum] DESC";
         }
         else if ( ( AV11OrderedBy == 14 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Pathology_LymphRate]";
         }
         else if ( ( AV11OrderedBy == 14 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Pathology_LymphRate] DESC";
         }
         else if ( ( AV11OrderedBy == 15 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Pathology_M]";
         }
         else if ( ( AV11OrderedBy == 15 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Pathology_M] DESC";
         }
         else if ( ( AV11OrderedBy == 16 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Pathology_MetaLoc]";
         }
         else if ( ( AV11OrderedBy == 16 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Pathology_MetaLoc] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_PathologyID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H005M3( IGxContext context ,
                                             short AV11OrderedBy ,
                                             bool AV12OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM (([BR_Pathology] T1 WITH (NOLOCK) LEFT JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
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
         else if ( ( AV11OrderedBy == 7 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 7 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 8 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 8 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 9 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 9 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 10 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 10 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 11 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 11 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 12 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 12 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 13 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 13 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 14 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 14 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 15 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 15 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 16 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 16 ) && ( AV12OrderedDsc ) )
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
                     return conditional_H005M2(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
               case 1 :
                     return conditional_H005M3(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
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
          Object[] prmH005M2 ;
          prmH005M2 = new Object[] {
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH005M3 ;
          prmH005M3 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H005M2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005M2,11,0,true,false )
             ,new CursorDef("H005M3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005M3,1,0,true,false )
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
                ((decimal[]) buf[8])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((decimal[]) buf[12])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((String[]) buf[18])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((short[]) buf[20])[0] = rslt.getShort(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((String[]) buf[22])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(12);
                ((DateTime[]) buf[24])[0] = rslt.getGXDate(13) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(13);
                ((long[]) buf[26])[0] = rslt.getLong(14) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(14);
                ((String[]) buf[28])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(15);
                ((long[]) buf[30])[0] = rslt.getLong(16) ;
                ((bool[]) buf[31])[0] = rslt.wasNull(16);
                ((long[]) buf[32])[0] = rslt.getLong(17) ;
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
