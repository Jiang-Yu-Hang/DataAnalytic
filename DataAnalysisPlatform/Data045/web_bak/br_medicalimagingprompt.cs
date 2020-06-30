/*
               File: BR_MedicalImagingPrompt
        Description: 选择影像学
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:43:10.88
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
   public class br_medicalimagingprompt : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public br_medicalimagingprompt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_medicalimagingprompt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_InOutBR_MedicalImagingID ,
                           ref String aP1_InOutBR_MedicalImaging_ImageName )
      {
         this.AV8InOutBR_MedicalImagingID = aP0_InOutBR_MedicalImagingID;
         this.AV45InOutBR_MedicalImaging_ImageName = aP1_InOutBR_MedicalImaging_ImageName;
         executePrivate();
         aP0_InOutBR_MedicalImagingID=this.AV8InOutBR_MedicalImagingID;
         aP1_InOutBR_MedicalImaging_ImageName=this.AV45InOutBR_MedicalImaging_ImageName;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbBR_MedicalImaging_MetastasesDX = new GXCombobox();
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
               AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace = GetNextPar( );
               AV16ddo_BR_EncounterIDTitleControlIdToReplace = GetNextPar( );
               AV18ddo_BR_Information_PatientNoTitleControlIdToReplace = GetNextPar( );
               AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace = GetNextPar( );
               AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace = GetNextPar( );
               AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace = GetNextPar( );
               AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace = GetNextPar( );
               AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace = GetNextPar( );
               AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace = GetNextPar( );
               AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace = GetNextPar( );
               AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace = GetNextPar( );
               AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace = GetNextPar( );
               AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace = GetNextPar( );
               AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace = GetNextPar( );
               AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace = GetNextPar( );
               AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace = GetNextPar( );
               AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace = GetNextPar( );
               AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace = GetNextPar( );
               AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace = GetNextPar( );
               AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_Information_PatientNoTitleControlIdToReplace, AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace, AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace, AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace, AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace, AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace, AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace, AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace, AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace, AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace, AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace, AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace, AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace, AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace, AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace, AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace, AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace, AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace) ;
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
               AV8InOutBR_MedicalImagingID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_MedicalImagingID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_MedicalImagingID), 18, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV45InOutBR_MedicalImaging_ImageName = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45InOutBR_MedicalImaging_ImageName", AV45InOutBR_MedicalImaging_ImageName);
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
            PA5L2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV62Pgmname = "BR_MedicalImagingPrompt";
               context.Gx_err = 0;
               WS5L2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE5L2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202279431134", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_medicalimagingprompt.aspx") + "?" + UrlEncode("" +AV8InOutBR_MedicalImagingID) + "," + UrlEncode(StringUtil.RTrim(AV45InOutBR_MedicalImaging_ImageName))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV41GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV43GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV42GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV39DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV39DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGINGIDTITLEFILTERDATA", AV13BR_MedicalImagingIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGINGIDTITLEFILTERDATA", AV13BR_MedicalImagingIDTitleFilterData);
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGING_IDTITLEFILTERDATA", AV19BR_MedicalImaging_IDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGING_IDTITLEFILTERDATA", AV19BR_MedicalImaging_IDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGING_IMAGENAME_CODETITLEFILTERDATA", AV48BR_MedicalImaging_ImageName_CodeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGING_IMAGENAME_CODETITLEFILTERDATA", AV48BR_MedicalImaging_ImageName_CodeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA", AV25BR_MedicalImaging_ImageHospTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA", AV25BR_MedicalImaging_ImageHospTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGING_IMAGEHOSP_CODETITLEFILTERDATA", AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGING_IMAGEHOSP_CODETITLEFILTERDATA", AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGING_IMAGELOCTITLEFILTERDATA", AV29BR_MedicalImaging_ImageLocTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGING_IMAGELOCTITLEFILTERDATA", AV29BR_MedicalImaging_ImageLocTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGING_IMAGELOC_CODETITLEFILTERDATA", AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGING_IMAGELOC_CODETITLEFILTERDATA", AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGING_IMAGEORGANTITLEFILTERDATA", AV31BR_MedicalImaging_ImageOrganTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGING_IMAGEORGANTITLEFILTERDATA", AV31BR_MedicalImaging_ImageOrganTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGING_PREIMAGEDIAGTITLEFILTERDATA", AV33BR_MedicalImaging_PreImageDiagTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGING_PREIMAGEDIAGTITLEFILTERDATA", AV33BR_MedicalImaging_PreImageDiagTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGING_IMAGEDESTITLEFILTERDATA", AV35BR_MedicalImaging_ImageDesTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGING_IMAGEDESTITLEFILTERDATA", AV35BR_MedicalImaging_ImageDesTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGING_TUMORSIZETITLEFILTERDATA", AV37BR_MedicalImaging_TumorSizeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGING_TUMORSIZETITLEFILTERDATA", AV37BR_MedicalImaging_TumorSizeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGING_IMAGEHTMLTITLEFILTERDATA", AV46BR_MedicalImaging_ImageHtmlTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGING_IMAGEHTMLTITLEFILTERDATA", AV46BR_MedicalImaging_ImageHtmlTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGING_METASTASESDXTITLEFILTERDATA", AV54BR_MedicalImaging_MetastasesDXTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGING_METASTASESDXTITLEFILTERDATA", AV54BR_MedicalImaging_MetastasesDXTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGING_METALOCTITLEFILTERDATA", AV56BR_MedicalImaging_MetaLocTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGING_METALOCTITLEFILTERDATA", AV56BR_MedicalImaging_MetaLocTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGING_METADATETITLEFILTERDATA", AV58BR_MedicalImaging_MetaDateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGING_METADATETITLEFILTERDATA", AV58BR_MedicalImaging_MetaDateTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vINOUTBR_MEDICALIMAGINGID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8InOutBR_MedicalImagingID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINOUTBR_MEDICALIMAGING_IMAGENAME", AV45InOutBR_MedicalImaging_ImageName);
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_ID_Caption", StringUtil.RTrim( Ddo_br_medicalimaging_id_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_ID_Tooltip", StringUtil.RTrim( Ddo_br_medicalimaging_id_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_ID_Cls", StringUtil.RTrim( Ddo_br_medicalimaging_id_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_ID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_id_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_ID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_id_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_ID_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_id_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_ID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_id_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_ID_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_id_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_ID_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_id_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_ID_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_id_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_ID_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_id_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_ID_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_id_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_ID_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_id_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGENAME_Caption", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGENAME_Tooltip", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGENAME_Cls", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGENAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGENAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGENAME_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagename_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGENAME_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagename_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGENAME_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGENAME_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagename_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGENAME_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagename_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGENAME_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGENAME_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGENAME_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE_Caption", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_code_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE_Tooltip", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_code_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE_Cls", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_code_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_code_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_code_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagename_code_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagename_code_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_code_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagename_code_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagename_code_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_code_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_code_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_code_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEDATE_Caption", StringUtil.RTrim( Ddo_br_medicalimaging_imagedate_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEDATE_Tooltip", StringUtil.RTrim( Ddo_br_medicalimaging_imagedate_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEDATE_Cls", StringUtil.RTrim( Ddo_br_medicalimaging_imagedate_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEDATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_imagedate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEDATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_imagedate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEDATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagedate_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEDATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagedate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEDATE_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_imagedate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEDATE_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagedate_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEDATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagedate_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEDATE_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_imagedate_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEDATE_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_imagedate_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEDATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_imagedate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_Caption", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_Tooltip", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_Cls", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagehosp_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagehosp_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagehosp_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagehosp_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE_Caption", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_code_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE_Tooltip", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_code_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE_Cls", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_code_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_code_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_code_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagehosp_code_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagehosp_code_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_code_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagehosp_code_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagehosp_code_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_code_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_code_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_code_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEAGE_Caption", StringUtil.RTrim( Ddo_br_medicalimaging_imageage_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEAGE_Tooltip", StringUtil.RTrim( Ddo_br_medicalimaging_imageage_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEAGE_Cls", StringUtil.RTrim( Ddo_br_medicalimaging_imageage_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEAGE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_imageage_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEAGE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_imageage_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEAGE_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_imageage_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEAGE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_imageage_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEAGE_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_imageage_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEAGE_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_imageage_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEAGE_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_imageage_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEAGE_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_imageage_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEAGE_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_imageage_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEAGE_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_imageage_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGELOC_Caption", StringUtil.RTrim( Ddo_br_medicalimaging_imageloc_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGELOC_Tooltip", StringUtil.RTrim( Ddo_br_medicalimaging_imageloc_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGELOC_Cls", StringUtil.RTrim( Ddo_br_medicalimaging_imageloc_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGELOC_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_imageloc_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGELOC_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_imageloc_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGELOC_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_imageloc_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGELOC_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_imageloc_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGELOC_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_imageloc_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGELOC_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_imageloc_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGELOC_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_imageloc_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGELOC_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_imageloc_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGELOC_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_imageloc_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGELOC_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_imageloc_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE_Caption", StringUtil.RTrim( Ddo_br_medicalimaging_imageloc_code_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE_Tooltip", StringUtil.RTrim( Ddo_br_medicalimaging_imageloc_code_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE_Cls", StringUtil.RTrim( Ddo_br_medicalimaging_imageloc_code_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_imageloc_code_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_imageloc_code_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_imageloc_code_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_imageloc_code_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_imageloc_code_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_imageloc_code_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_imageloc_code_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_imageloc_code_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_imageloc_code_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_imageloc_code_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEORGAN_Caption", StringUtil.RTrim( Ddo_br_medicalimaging_imageorgan_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEORGAN_Tooltip", StringUtil.RTrim( Ddo_br_medicalimaging_imageorgan_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEORGAN_Cls", StringUtil.RTrim( Ddo_br_medicalimaging_imageorgan_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEORGAN_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_imageorgan_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEORGAN_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_imageorgan_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEORGAN_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_imageorgan_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEORGAN_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_imageorgan_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEORGAN_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_imageorgan_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEORGAN_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_imageorgan_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEORGAN_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_imageorgan_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEORGAN_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_imageorgan_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEORGAN_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_imageorgan_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEORGAN_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_imageorgan_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG_Caption", StringUtil.RTrim( Ddo_br_medicalimaging_preimagediag_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG_Tooltip", StringUtil.RTrim( Ddo_br_medicalimaging_preimagediag_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG_Cls", StringUtil.RTrim( Ddo_br_medicalimaging_preimagediag_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_preimagediag_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_preimagediag_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_preimagediag_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_preimagediag_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_preimagediag_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_preimagediag_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_preimagediag_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_preimagediag_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_preimagediag_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_preimagediag_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEDES_Caption", StringUtil.RTrim( Ddo_br_medicalimaging_imagedes_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEDES_Tooltip", StringUtil.RTrim( Ddo_br_medicalimaging_imagedes_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEDES_Cls", StringUtil.RTrim( Ddo_br_medicalimaging_imagedes_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEDES_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_imagedes_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEDES_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_imagedes_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEDES_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagedes_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEDES_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagedes_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEDES_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_imagedes_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEDES_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagedes_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEDES_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagedes_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEDES_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_imagedes_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEDES_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_imagedes_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEDES_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_imagedes_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_TUMORSIZE_Caption", StringUtil.RTrim( Ddo_br_medicalimaging_tumorsize_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_TUMORSIZE_Tooltip", StringUtil.RTrim( Ddo_br_medicalimaging_tumorsize_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_TUMORSIZE_Cls", StringUtil.RTrim( Ddo_br_medicalimaging_tumorsize_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_TUMORSIZE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_tumorsize_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_TUMORSIZE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_tumorsize_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_TUMORSIZE_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_tumorsize_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_TUMORSIZE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_tumorsize_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_TUMORSIZE_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_tumorsize_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_TUMORSIZE_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_tumorsize_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_TUMORSIZE_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_tumorsize_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_TUMORSIZE_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_tumorsize_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_TUMORSIZE_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_tumorsize_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_TUMORSIZE_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_tumorsize_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHTML_Caption", StringUtil.RTrim( Ddo_br_medicalimaging_imagehtml_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHTML_Tooltip", StringUtil.RTrim( Ddo_br_medicalimaging_imagehtml_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHTML_Cls", StringUtil.RTrim( Ddo_br_medicalimaging_imagehtml_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHTML_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_imagehtml_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHTML_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_imagehtml_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHTML_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagehtml_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHTML_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagehtml_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHTML_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_imagehtml_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHTML_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagehtml_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHTML_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagehtml_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHTML_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_imagehtml_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHTML_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_imagehtml_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHTML_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_imagehtml_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METASTASESDX_Caption", StringUtil.RTrim( Ddo_br_medicalimaging_metastasesdx_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METASTASESDX_Tooltip", StringUtil.RTrim( Ddo_br_medicalimaging_metastasesdx_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METASTASESDX_Cls", StringUtil.RTrim( Ddo_br_medicalimaging_metastasesdx_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METASTASESDX_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_metastasesdx_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METASTASESDX_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_metastasesdx_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METASTASESDX_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_metastasesdx_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METASTASESDX_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_metastasesdx_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METASTASESDX_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_metastasesdx_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METASTASESDX_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_metastasesdx_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METASTASESDX_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_metastasesdx_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METASTASESDX_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_metastasesdx_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METASTASESDX_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_metastasesdx_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METASTASESDX_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_metastasesdx_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METALOC_Caption", StringUtil.RTrim( Ddo_br_medicalimaging_metaloc_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METALOC_Tooltip", StringUtil.RTrim( Ddo_br_medicalimaging_metaloc_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METALOC_Cls", StringUtil.RTrim( Ddo_br_medicalimaging_metaloc_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METALOC_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_metaloc_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METALOC_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_metaloc_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METALOC_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_metaloc_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METALOC_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_metaloc_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METALOC_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_metaloc_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METALOC_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_metaloc_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METALOC_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_metaloc_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METALOC_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_metaloc_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METALOC_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_metaloc_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METALOC_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_metaloc_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METADATE_Caption", StringUtil.RTrim( Ddo_br_medicalimaging_metadate_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METADATE_Tooltip", StringUtil.RTrim( Ddo_br_medicalimaging_metadate_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METADATE_Cls", StringUtil.RTrim( Ddo_br_medicalimaging_metadate_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METADATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_metadate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METADATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_metadate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METADATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_metadate_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METADATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_metadate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METADATE_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_metadate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METADATE_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_metadate_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METADATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_metadate_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METADATE_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_metadate_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METADATE_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_metadate_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METADATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_metadate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimagingid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey", StringUtil.RTrim( Ddo_br_information_patientno_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_ID_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_id_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGENAME_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_code_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_imagedate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_code_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEAGE_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_imageage_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGELOC_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_imageloc_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_imageloc_code_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEORGAN_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_imageorgan_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_preimagediag_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEDES_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_imagedes_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_TUMORSIZE_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_tumorsize_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHTML_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_imagehtml_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METASTASESDX_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_metastasesdx_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METALOC_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_metaloc_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METADATE_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_metadate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGINGID_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimagingid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey", StringUtil.RTrim( Ddo_br_information_patientno_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_ID_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_id_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGENAME_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_code_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_imagedate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_code_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEAGE_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_imageage_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGELOC_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_imageloc_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_imageloc_code_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEORGAN_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_imageorgan_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_preimagediag_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEDES_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_imagedes_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_TUMORSIZE_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_tumorsize_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_IMAGEHTML_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_imagehtml_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METASTASESDX_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_metastasesdx_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METALOC_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_metaloc_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICALIMAGING_METADATE_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_metadate_Activeeventkey));
      }

      protected void RenderHtmlCloseForm5L2( )
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
         return "BR_MedicalImagingPrompt" ;
      }

      public override String GetPgmdesc( )
      {
         return "选择影像学" ;
      }

      protected void WB5L0( )
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
               if ( edtBR_MedicalImagingID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_MedicalImagingID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_MedicalImagingID_Title) ;
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
               if ( edtBR_MedicalImaging_ID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_MedicalImaging_ID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_MedicalImaging_ID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_MedicalImaging_ImageName_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_MedicalImaging_ImageName_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_MedicalImaging_ImageName_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_MedicalImaging_ImageName_Code_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_MedicalImaging_ImageName_Code_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_MedicalImaging_ImageName_Code_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_MedicalImaging_ImageDate_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_MedicalImaging_ImageDate_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_MedicalImaging_ImageDate_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_MedicalImaging_ImageHosp_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_MedicalImaging_ImageHosp_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_MedicalImaging_ImageHosp_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_MedicalImaging_ImageHosp_Code_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_MedicalImaging_ImageHosp_Code_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_MedicalImaging_ImageHosp_Code_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_MedicalImaging_ImageAge_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_MedicalImaging_ImageAge_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_MedicalImaging_ImageAge_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_MedicalImaging_ImageLoc_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_MedicalImaging_ImageLoc_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_MedicalImaging_ImageLoc_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_MedicalImaging_ImageLoc_Code_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_MedicalImaging_ImageLoc_Code_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_MedicalImaging_ImageLoc_Code_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_MedicalImaging_ImageOrgan_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_MedicalImaging_ImageOrgan_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_MedicalImaging_ImageOrgan_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_MedicalImaging_PreImageDiag_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_MedicalImaging_PreImageDiag_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_MedicalImaging_PreImageDiag_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_MedicalImaging_ImageDes_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_MedicalImaging_ImageDes_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_MedicalImaging_ImageDes_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_MedicalImaging_TumorSize_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_MedicalImaging_TumorSize_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_MedicalImaging_TumorSize_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_MedicalImaging_ImageHtml_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_MedicalImaging_ImageHtml_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_MedicalImaging_ImageHtml_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( cmbBR_MedicalImaging_MetastasesDX_Titleformat == 0 )
               {
                  context.SendWebValue( cmbBR_MedicalImaging_MetastasesDX.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( cmbBR_MedicalImaging_MetastasesDX.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_MedicalImaging_MetaLoc_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_MedicalImaging_MetaLoc_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_MedicalImaging_MetaLoc_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_MedicalImaging_MetaDate_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_MedicalImaging_MetaDate_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_MedicalImaging_MetaDate_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV44Select));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavSelect_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A225BR_MedicalImagingID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicalImagingID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicalImagingID_Titleformat), 4, 0, ".", "")));
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
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A227BR_MedicalImaging_ID), 10, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicalImaging_ID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicalImaging_ID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A228BR_MedicalImaging_ImageName);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicalImaging_ImageName_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicalImaging_ImageName_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A484BR_MedicalImaging_ImageName_Code);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicalImaging_ImageName_Code_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicalImaging_ImageName_Code_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A229BR_MedicalImaging_ImageDate, "9999/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicalImaging_ImageDate_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicalImaging_ImageDate_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A230BR_MedicalImaging_ImageHosp);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicalImaging_ImageHosp_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicalImaging_ImageHosp_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A485BR_MedicalImaging_ImageHosp_Code);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicalImaging_ImageHosp_Code_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicalImaging_ImageHosp_Code_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A231BR_MedicalImaging_ImageAge), 3, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicalImaging_ImageAge_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicalImaging_ImageAge_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A232BR_MedicalImaging_ImageLoc);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicalImaging_ImageLoc_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicalImaging_ImageLoc_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A486BR_MedicalImaging_ImageLoc_Code);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicalImaging_ImageLoc_Code_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicalImaging_ImageLoc_Code_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A233BR_MedicalImaging_ImageOrgan);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicalImaging_ImageOrgan_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicalImaging_ImageOrgan_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A234BR_MedicalImaging_PreImageDiag);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicalImaging_PreImageDiag_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicalImaging_PreImageDiag_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A235BR_MedicalImaging_ImageDes);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicalImaging_ImageDes_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicalImaging_ImageDes_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A236BR_MedicalImaging_TumorSize);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicalImaging_TumorSize_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicalImaging_TumorSize_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A334BR_MedicalImaging_ImageHtml);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicalImaging_ImageHtml_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicalImaging_ImageHtml_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A514BR_MedicalImaging_MetastasesDX);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( cmbBR_MedicalImaging_MetastasesDX.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbBR_MedicalImaging_MetastasesDX_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A515BR_MedicalImaging_MetaLoc);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicalImaging_MetaLoc_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicalImaging_MetaLoc_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A516BR_MedicalImaging_MetaDate, "9999/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicalImaging_MetaDate_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicalImaging_MetaDate_Titleformat), 4, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV41GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV43GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV42GridPageSize);
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
            ucDdo_br_medicalimagingid.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_medicalimagingid.SetProperty("DropDownOptionsData", AV13BR_MedicalImagingIDTitleFilterData);
            ucDdo_br_medicalimagingid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimagingid_Internalname, "DDO_BR_MEDICALIMAGINGIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Internalname, AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,42);\"", 0, edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImagingPrompt.htm");
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
            ucDdo_br_encounterid.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsData", AV15BR_EncounterIDTitleFilterData);
            ucDdo_br_encounterid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounterid_Internalname, "DDO_BR_ENCOUNTERIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, AV16ddo_BR_EncounterIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", 0, edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImagingPrompt.htm");
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
            ucDdo_br_information_patientno.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_information_patientno.SetProperty("DropDownOptionsData", AV17BR_Information_PatientNoTitleFilterData);
            ucDdo_br_information_patientno.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_information_patientno_Internalname, "DDO_BR_INFORMATION_PATIENTNOContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname, AV18ddo_BR_Information_PatientNoTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", 0, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImagingPrompt.htm");
            /* User Defined Control */
            ucDdo_br_medicalimaging_id.SetProperty("Caption", Ddo_br_medicalimaging_id_Caption);
            ucDdo_br_medicalimaging_id.SetProperty("Tooltip", Ddo_br_medicalimaging_id_Tooltip);
            ucDdo_br_medicalimaging_id.SetProperty("Cls", Ddo_br_medicalimaging_id_Cls);
            ucDdo_br_medicalimaging_id.SetProperty("DropDownOptionsType", Ddo_br_medicalimaging_id_Dropdownoptionstype);
            ucDdo_br_medicalimaging_id.SetProperty("IncludeSortASC", Ddo_br_medicalimaging_id_Includesortasc);
            ucDdo_br_medicalimaging_id.SetProperty("IncludeSortDSC", Ddo_br_medicalimaging_id_Includesortdsc);
            ucDdo_br_medicalimaging_id.SetProperty("IncludeFilter", Ddo_br_medicalimaging_id_Includefilter);
            ucDdo_br_medicalimaging_id.SetProperty("IncludeDataList", Ddo_br_medicalimaging_id_Includedatalist);
            ucDdo_br_medicalimaging_id.SetProperty("SortASC", Ddo_br_medicalimaging_id_Sortasc);
            ucDdo_br_medicalimaging_id.SetProperty("SortDSC", Ddo_br_medicalimaging_id_Sortdsc);
            ucDdo_br_medicalimaging_id.SetProperty("SearchButtonText", Ddo_br_medicalimaging_id_Searchbuttontext);
            ucDdo_br_medicalimaging_id.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_id.SetProperty("DropDownOptionsData", AV19BR_MedicalImaging_IDTitleFilterData);
            ucDdo_br_medicalimaging_id.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_id_Internalname, "DDO_BR_MEDICALIMAGING_IDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_idtitlecontrolidtoreplace_Internalname, AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", 0, edtavDdo_br_medicalimaging_idtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImagingPrompt.htm");
            /* User Defined Control */
            ucDdo_br_medicalimaging_imagename.SetProperty("Caption", Ddo_br_medicalimaging_imagename_Caption);
            ucDdo_br_medicalimaging_imagename.SetProperty("Tooltip", Ddo_br_medicalimaging_imagename_Tooltip);
            ucDdo_br_medicalimaging_imagename.SetProperty("Cls", Ddo_br_medicalimaging_imagename_Cls);
            ucDdo_br_medicalimaging_imagename.SetProperty("DropDownOptionsType", Ddo_br_medicalimaging_imagename_Dropdownoptionstype);
            ucDdo_br_medicalimaging_imagename.SetProperty("IncludeSortASC", Ddo_br_medicalimaging_imagename_Includesortasc);
            ucDdo_br_medicalimaging_imagename.SetProperty("IncludeSortDSC", Ddo_br_medicalimaging_imagename_Includesortdsc);
            ucDdo_br_medicalimaging_imagename.SetProperty("IncludeFilter", Ddo_br_medicalimaging_imagename_Includefilter);
            ucDdo_br_medicalimaging_imagename.SetProperty("IncludeDataList", Ddo_br_medicalimaging_imagename_Includedatalist);
            ucDdo_br_medicalimaging_imagename.SetProperty("SortASC", Ddo_br_medicalimaging_imagename_Sortasc);
            ucDdo_br_medicalimaging_imagename.SetProperty("SortDSC", Ddo_br_medicalimaging_imagename_Sortdsc);
            ucDdo_br_medicalimaging_imagename.SetProperty("SearchButtonText", Ddo_br_medicalimaging_imagename_Searchbuttontext);
            ucDdo_br_medicalimaging_imagename.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_imagename.SetProperty("DropDownOptionsData", AV21BR_MedicalImaging_ImageNameTitleFilterData);
            ucDdo_br_medicalimaging_imagename.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_imagename_Internalname, "DDO_BR_MEDICALIMAGING_IMAGENAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_imagenametitlecontrolidtoreplace_Internalname, AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", 0, edtavDdo_br_medicalimaging_imagenametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImagingPrompt.htm");
            /* User Defined Control */
            ucDdo_br_medicalimaging_imagename_code.SetProperty("Caption", Ddo_br_medicalimaging_imagename_code_Caption);
            ucDdo_br_medicalimaging_imagename_code.SetProperty("Tooltip", Ddo_br_medicalimaging_imagename_code_Tooltip);
            ucDdo_br_medicalimaging_imagename_code.SetProperty("Cls", Ddo_br_medicalimaging_imagename_code_Cls);
            ucDdo_br_medicalimaging_imagename_code.SetProperty("DropDownOptionsType", Ddo_br_medicalimaging_imagename_code_Dropdownoptionstype);
            ucDdo_br_medicalimaging_imagename_code.SetProperty("IncludeSortASC", Ddo_br_medicalimaging_imagename_code_Includesortasc);
            ucDdo_br_medicalimaging_imagename_code.SetProperty("IncludeSortDSC", Ddo_br_medicalimaging_imagename_code_Includesortdsc);
            ucDdo_br_medicalimaging_imagename_code.SetProperty("IncludeFilter", Ddo_br_medicalimaging_imagename_code_Includefilter);
            ucDdo_br_medicalimaging_imagename_code.SetProperty("IncludeDataList", Ddo_br_medicalimaging_imagename_code_Includedatalist);
            ucDdo_br_medicalimaging_imagename_code.SetProperty("SortASC", Ddo_br_medicalimaging_imagename_code_Sortasc);
            ucDdo_br_medicalimaging_imagename_code.SetProperty("SortDSC", Ddo_br_medicalimaging_imagename_code_Sortdsc);
            ucDdo_br_medicalimaging_imagename_code.SetProperty("SearchButtonText", Ddo_br_medicalimaging_imagename_code_Searchbuttontext);
            ucDdo_br_medicalimaging_imagename_code.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_imagename_code.SetProperty("DropDownOptionsData", AV48BR_MedicalImaging_ImageName_CodeTitleFilterData);
            ucDdo_br_medicalimaging_imagename_code.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_imagename_code_Internalname, "DDO_BR_MEDICALIMAGING_IMAGENAME_CODEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_imagename_codetitlecontrolidtoreplace_Internalname, AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", 0, edtavDdo_br_medicalimaging_imagename_codetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImagingPrompt.htm");
            /* User Defined Control */
            ucDdo_br_medicalimaging_imagedate.SetProperty("Caption", Ddo_br_medicalimaging_imagedate_Caption);
            ucDdo_br_medicalimaging_imagedate.SetProperty("Tooltip", Ddo_br_medicalimaging_imagedate_Tooltip);
            ucDdo_br_medicalimaging_imagedate.SetProperty("Cls", Ddo_br_medicalimaging_imagedate_Cls);
            ucDdo_br_medicalimaging_imagedate.SetProperty("DropDownOptionsType", Ddo_br_medicalimaging_imagedate_Dropdownoptionstype);
            ucDdo_br_medicalimaging_imagedate.SetProperty("IncludeSortASC", Ddo_br_medicalimaging_imagedate_Includesortasc);
            ucDdo_br_medicalimaging_imagedate.SetProperty("IncludeSortDSC", Ddo_br_medicalimaging_imagedate_Includesortdsc);
            ucDdo_br_medicalimaging_imagedate.SetProperty("IncludeFilter", Ddo_br_medicalimaging_imagedate_Includefilter);
            ucDdo_br_medicalimaging_imagedate.SetProperty("IncludeDataList", Ddo_br_medicalimaging_imagedate_Includedatalist);
            ucDdo_br_medicalimaging_imagedate.SetProperty("SortASC", Ddo_br_medicalimaging_imagedate_Sortasc);
            ucDdo_br_medicalimaging_imagedate.SetProperty("SortDSC", Ddo_br_medicalimaging_imagedate_Sortdsc);
            ucDdo_br_medicalimaging_imagedate.SetProperty("SearchButtonText", Ddo_br_medicalimaging_imagedate_Searchbuttontext);
            ucDdo_br_medicalimaging_imagedate.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_imagedate.SetProperty("DropDownOptionsData", AV23BR_MedicalImaging_ImageDateTitleFilterData);
            ucDdo_br_medicalimaging_imagedate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_imagedate_Internalname, "DDO_BR_MEDICALIMAGING_IMAGEDATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_imagedatetitlecontrolidtoreplace_Internalname, AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", 0, edtavDdo_br_medicalimaging_imagedatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImagingPrompt.htm");
            /* User Defined Control */
            ucDdo_br_medicalimaging_imagehosp.SetProperty("Caption", Ddo_br_medicalimaging_imagehosp_Caption);
            ucDdo_br_medicalimaging_imagehosp.SetProperty("Tooltip", Ddo_br_medicalimaging_imagehosp_Tooltip);
            ucDdo_br_medicalimaging_imagehosp.SetProperty("Cls", Ddo_br_medicalimaging_imagehosp_Cls);
            ucDdo_br_medicalimaging_imagehosp.SetProperty("DropDownOptionsType", Ddo_br_medicalimaging_imagehosp_Dropdownoptionstype);
            ucDdo_br_medicalimaging_imagehosp.SetProperty("IncludeSortASC", Ddo_br_medicalimaging_imagehosp_Includesortasc);
            ucDdo_br_medicalimaging_imagehosp.SetProperty("IncludeSortDSC", Ddo_br_medicalimaging_imagehosp_Includesortdsc);
            ucDdo_br_medicalimaging_imagehosp.SetProperty("IncludeFilter", Ddo_br_medicalimaging_imagehosp_Includefilter);
            ucDdo_br_medicalimaging_imagehosp.SetProperty("IncludeDataList", Ddo_br_medicalimaging_imagehosp_Includedatalist);
            ucDdo_br_medicalimaging_imagehosp.SetProperty("SortASC", Ddo_br_medicalimaging_imagehosp_Sortasc);
            ucDdo_br_medicalimaging_imagehosp.SetProperty("SortDSC", Ddo_br_medicalimaging_imagehosp_Sortdsc);
            ucDdo_br_medicalimaging_imagehosp.SetProperty("SearchButtonText", Ddo_br_medicalimaging_imagehosp_Searchbuttontext);
            ucDdo_br_medicalimaging_imagehosp.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_imagehosp.SetProperty("DropDownOptionsData", AV25BR_MedicalImaging_ImageHospTitleFilterData);
            ucDdo_br_medicalimaging_imagehosp.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_imagehosp_Internalname, "DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_imagehosptitlecontrolidtoreplace_Internalname, AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", 0, edtavDdo_br_medicalimaging_imagehosptitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImagingPrompt.htm");
            /* User Defined Control */
            ucDdo_br_medicalimaging_imagehosp_code.SetProperty("Caption", Ddo_br_medicalimaging_imagehosp_code_Caption);
            ucDdo_br_medicalimaging_imagehosp_code.SetProperty("Tooltip", Ddo_br_medicalimaging_imagehosp_code_Tooltip);
            ucDdo_br_medicalimaging_imagehosp_code.SetProperty("Cls", Ddo_br_medicalimaging_imagehosp_code_Cls);
            ucDdo_br_medicalimaging_imagehosp_code.SetProperty("DropDownOptionsType", Ddo_br_medicalimaging_imagehosp_code_Dropdownoptionstype);
            ucDdo_br_medicalimaging_imagehosp_code.SetProperty("IncludeSortASC", Ddo_br_medicalimaging_imagehosp_code_Includesortasc);
            ucDdo_br_medicalimaging_imagehosp_code.SetProperty("IncludeSortDSC", Ddo_br_medicalimaging_imagehosp_code_Includesortdsc);
            ucDdo_br_medicalimaging_imagehosp_code.SetProperty("IncludeFilter", Ddo_br_medicalimaging_imagehosp_code_Includefilter);
            ucDdo_br_medicalimaging_imagehosp_code.SetProperty("IncludeDataList", Ddo_br_medicalimaging_imagehosp_code_Includedatalist);
            ucDdo_br_medicalimaging_imagehosp_code.SetProperty("SortASC", Ddo_br_medicalimaging_imagehosp_code_Sortasc);
            ucDdo_br_medicalimaging_imagehosp_code.SetProperty("SortDSC", Ddo_br_medicalimaging_imagehosp_code_Sortdsc);
            ucDdo_br_medicalimaging_imagehosp_code.SetProperty("SearchButtonText", Ddo_br_medicalimaging_imagehosp_code_Searchbuttontext);
            ucDdo_br_medicalimaging_imagehosp_code.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_imagehosp_code.SetProperty("DropDownOptionsData", AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData);
            ucDdo_br_medicalimaging_imagehosp_code.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_imagehosp_code_Internalname, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_imagehosp_codetitlecontrolidtoreplace_Internalname, AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", 0, edtavDdo_br_medicalimaging_imagehosp_codetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImagingPrompt.htm");
            /* User Defined Control */
            ucDdo_br_medicalimaging_imageage.SetProperty("Caption", Ddo_br_medicalimaging_imageage_Caption);
            ucDdo_br_medicalimaging_imageage.SetProperty("Tooltip", Ddo_br_medicalimaging_imageage_Tooltip);
            ucDdo_br_medicalimaging_imageage.SetProperty("Cls", Ddo_br_medicalimaging_imageage_Cls);
            ucDdo_br_medicalimaging_imageage.SetProperty("DropDownOptionsType", Ddo_br_medicalimaging_imageage_Dropdownoptionstype);
            ucDdo_br_medicalimaging_imageage.SetProperty("IncludeSortASC", Ddo_br_medicalimaging_imageage_Includesortasc);
            ucDdo_br_medicalimaging_imageage.SetProperty("IncludeSortDSC", Ddo_br_medicalimaging_imageage_Includesortdsc);
            ucDdo_br_medicalimaging_imageage.SetProperty("IncludeFilter", Ddo_br_medicalimaging_imageage_Includefilter);
            ucDdo_br_medicalimaging_imageage.SetProperty("IncludeDataList", Ddo_br_medicalimaging_imageage_Includedatalist);
            ucDdo_br_medicalimaging_imageage.SetProperty("SortASC", Ddo_br_medicalimaging_imageage_Sortasc);
            ucDdo_br_medicalimaging_imageage.SetProperty("SortDSC", Ddo_br_medicalimaging_imageage_Sortdsc);
            ucDdo_br_medicalimaging_imageage.SetProperty("SearchButtonText", Ddo_br_medicalimaging_imageage_Searchbuttontext);
            ucDdo_br_medicalimaging_imageage.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_imageage.SetProperty("DropDownOptionsData", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
            ucDdo_br_medicalimaging_imageage.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_imageage_Internalname, "DDO_BR_MEDICALIMAGING_IMAGEAGEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_imageagetitlecontrolidtoreplace_Internalname, AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,60);\"", 0, edtavDdo_br_medicalimaging_imageagetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImagingPrompt.htm");
            /* User Defined Control */
            ucDdo_br_medicalimaging_imageloc.SetProperty("Caption", Ddo_br_medicalimaging_imageloc_Caption);
            ucDdo_br_medicalimaging_imageloc.SetProperty("Tooltip", Ddo_br_medicalimaging_imageloc_Tooltip);
            ucDdo_br_medicalimaging_imageloc.SetProperty("Cls", Ddo_br_medicalimaging_imageloc_Cls);
            ucDdo_br_medicalimaging_imageloc.SetProperty("DropDownOptionsType", Ddo_br_medicalimaging_imageloc_Dropdownoptionstype);
            ucDdo_br_medicalimaging_imageloc.SetProperty("IncludeSortASC", Ddo_br_medicalimaging_imageloc_Includesortasc);
            ucDdo_br_medicalimaging_imageloc.SetProperty("IncludeSortDSC", Ddo_br_medicalimaging_imageloc_Includesortdsc);
            ucDdo_br_medicalimaging_imageloc.SetProperty("IncludeFilter", Ddo_br_medicalimaging_imageloc_Includefilter);
            ucDdo_br_medicalimaging_imageloc.SetProperty("IncludeDataList", Ddo_br_medicalimaging_imageloc_Includedatalist);
            ucDdo_br_medicalimaging_imageloc.SetProperty("SortASC", Ddo_br_medicalimaging_imageloc_Sortasc);
            ucDdo_br_medicalimaging_imageloc.SetProperty("SortDSC", Ddo_br_medicalimaging_imageloc_Sortdsc);
            ucDdo_br_medicalimaging_imageloc.SetProperty("SearchButtonText", Ddo_br_medicalimaging_imageloc_Searchbuttontext);
            ucDdo_br_medicalimaging_imageloc.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_imageloc.SetProperty("DropDownOptionsData", AV29BR_MedicalImaging_ImageLocTitleFilterData);
            ucDdo_br_medicalimaging_imageloc.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_imageloc_Internalname, "DDO_BR_MEDICALIMAGING_IMAGELOCContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_imageloctitlecontrolidtoreplace_Internalname, AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,62);\"", 0, edtavDdo_br_medicalimaging_imageloctitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImagingPrompt.htm");
            /* User Defined Control */
            ucDdo_br_medicalimaging_imageloc_code.SetProperty("Caption", Ddo_br_medicalimaging_imageloc_code_Caption);
            ucDdo_br_medicalimaging_imageloc_code.SetProperty("Tooltip", Ddo_br_medicalimaging_imageloc_code_Tooltip);
            ucDdo_br_medicalimaging_imageloc_code.SetProperty("Cls", Ddo_br_medicalimaging_imageloc_code_Cls);
            ucDdo_br_medicalimaging_imageloc_code.SetProperty("DropDownOptionsType", Ddo_br_medicalimaging_imageloc_code_Dropdownoptionstype);
            ucDdo_br_medicalimaging_imageloc_code.SetProperty("IncludeSortASC", Ddo_br_medicalimaging_imageloc_code_Includesortasc);
            ucDdo_br_medicalimaging_imageloc_code.SetProperty("IncludeSortDSC", Ddo_br_medicalimaging_imageloc_code_Includesortdsc);
            ucDdo_br_medicalimaging_imageloc_code.SetProperty("IncludeFilter", Ddo_br_medicalimaging_imageloc_code_Includefilter);
            ucDdo_br_medicalimaging_imageloc_code.SetProperty("IncludeDataList", Ddo_br_medicalimaging_imageloc_code_Includedatalist);
            ucDdo_br_medicalimaging_imageloc_code.SetProperty("SortASC", Ddo_br_medicalimaging_imageloc_code_Sortasc);
            ucDdo_br_medicalimaging_imageloc_code.SetProperty("SortDSC", Ddo_br_medicalimaging_imageloc_code_Sortdsc);
            ucDdo_br_medicalimaging_imageloc_code.SetProperty("SearchButtonText", Ddo_br_medicalimaging_imageloc_code_Searchbuttontext);
            ucDdo_br_medicalimaging_imageloc_code.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_imageloc_code.SetProperty("DropDownOptionsData", AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData);
            ucDdo_br_medicalimaging_imageloc_code.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_imageloc_code_Internalname, "DDO_BR_MEDICALIMAGING_IMAGELOC_CODEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_imageloc_codetitlecontrolidtoreplace_Internalname, AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", 0, edtavDdo_br_medicalimaging_imageloc_codetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImagingPrompt.htm");
            /* User Defined Control */
            ucDdo_br_medicalimaging_imageorgan.SetProperty("Caption", Ddo_br_medicalimaging_imageorgan_Caption);
            ucDdo_br_medicalimaging_imageorgan.SetProperty("Tooltip", Ddo_br_medicalimaging_imageorgan_Tooltip);
            ucDdo_br_medicalimaging_imageorgan.SetProperty("Cls", Ddo_br_medicalimaging_imageorgan_Cls);
            ucDdo_br_medicalimaging_imageorgan.SetProperty("DropDownOptionsType", Ddo_br_medicalimaging_imageorgan_Dropdownoptionstype);
            ucDdo_br_medicalimaging_imageorgan.SetProperty("IncludeSortASC", Ddo_br_medicalimaging_imageorgan_Includesortasc);
            ucDdo_br_medicalimaging_imageorgan.SetProperty("IncludeSortDSC", Ddo_br_medicalimaging_imageorgan_Includesortdsc);
            ucDdo_br_medicalimaging_imageorgan.SetProperty("IncludeFilter", Ddo_br_medicalimaging_imageorgan_Includefilter);
            ucDdo_br_medicalimaging_imageorgan.SetProperty("IncludeDataList", Ddo_br_medicalimaging_imageorgan_Includedatalist);
            ucDdo_br_medicalimaging_imageorgan.SetProperty("SortASC", Ddo_br_medicalimaging_imageorgan_Sortasc);
            ucDdo_br_medicalimaging_imageorgan.SetProperty("SortDSC", Ddo_br_medicalimaging_imageorgan_Sortdsc);
            ucDdo_br_medicalimaging_imageorgan.SetProperty("SearchButtonText", Ddo_br_medicalimaging_imageorgan_Searchbuttontext);
            ucDdo_br_medicalimaging_imageorgan.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_imageorgan.SetProperty("DropDownOptionsData", AV31BR_MedicalImaging_ImageOrganTitleFilterData);
            ucDdo_br_medicalimaging_imageorgan.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_imageorgan_Internalname, "DDO_BR_MEDICALIMAGING_IMAGEORGANContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_imageorgantitlecontrolidtoreplace_Internalname, AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", 0, edtavDdo_br_medicalimaging_imageorgantitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImagingPrompt.htm");
            /* User Defined Control */
            ucDdo_br_medicalimaging_preimagediag.SetProperty("Caption", Ddo_br_medicalimaging_preimagediag_Caption);
            ucDdo_br_medicalimaging_preimagediag.SetProperty("Tooltip", Ddo_br_medicalimaging_preimagediag_Tooltip);
            ucDdo_br_medicalimaging_preimagediag.SetProperty("Cls", Ddo_br_medicalimaging_preimagediag_Cls);
            ucDdo_br_medicalimaging_preimagediag.SetProperty("DropDownOptionsType", Ddo_br_medicalimaging_preimagediag_Dropdownoptionstype);
            ucDdo_br_medicalimaging_preimagediag.SetProperty("IncludeSortASC", Ddo_br_medicalimaging_preimagediag_Includesortasc);
            ucDdo_br_medicalimaging_preimagediag.SetProperty("IncludeSortDSC", Ddo_br_medicalimaging_preimagediag_Includesortdsc);
            ucDdo_br_medicalimaging_preimagediag.SetProperty("IncludeFilter", Ddo_br_medicalimaging_preimagediag_Includefilter);
            ucDdo_br_medicalimaging_preimagediag.SetProperty("IncludeDataList", Ddo_br_medicalimaging_preimagediag_Includedatalist);
            ucDdo_br_medicalimaging_preimagediag.SetProperty("SortASC", Ddo_br_medicalimaging_preimagediag_Sortasc);
            ucDdo_br_medicalimaging_preimagediag.SetProperty("SortDSC", Ddo_br_medicalimaging_preimagediag_Sortdsc);
            ucDdo_br_medicalimaging_preimagediag.SetProperty("SearchButtonText", Ddo_br_medicalimaging_preimagediag_Searchbuttontext);
            ucDdo_br_medicalimaging_preimagediag.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_preimagediag.SetProperty("DropDownOptionsData", AV33BR_MedicalImaging_PreImageDiagTitleFilterData);
            ucDdo_br_medicalimaging_preimagediag.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_preimagediag_Internalname, "DDO_BR_MEDICALIMAGING_PREIMAGEDIAGContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_preimagediagtitlecontrolidtoreplace_Internalname, AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,68);\"", 0, edtavDdo_br_medicalimaging_preimagediagtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImagingPrompt.htm");
            /* User Defined Control */
            ucDdo_br_medicalimaging_imagedes.SetProperty("Caption", Ddo_br_medicalimaging_imagedes_Caption);
            ucDdo_br_medicalimaging_imagedes.SetProperty("Tooltip", Ddo_br_medicalimaging_imagedes_Tooltip);
            ucDdo_br_medicalimaging_imagedes.SetProperty("Cls", Ddo_br_medicalimaging_imagedes_Cls);
            ucDdo_br_medicalimaging_imagedes.SetProperty("DropDownOptionsType", Ddo_br_medicalimaging_imagedes_Dropdownoptionstype);
            ucDdo_br_medicalimaging_imagedes.SetProperty("IncludeSortASC", Ddo_br_medicalimaging_imagedes_Includesortasc);
            ucDdo_br_medicalimaging_imagedes.SetProperty("IncludeSortDSC", Ddo_br_medicalimaging_imagedes_Includesortdsc);
            ucDdo_br_medicalimaging_imagedes.SetProperty("IncludeFilter", Ddo_br_medicalimaging_imagedes_Includefilter);
            ucDdo_br_medicalimaging_imagedes.SetProperty("IncludeDataList", Ddo_br_medicalimaging_imagedes_Includedatalist);
            ucDdo_br_medicalimaging_imagedes.SetProperty("SortASC", Ddo_br_medicalimaging_imagedes_Sortasc);
            ucDdo_br_medicalimaging_imagedes.SetProperty("SortDSC", Ddo_br_medicalimaging_imagedes_Sortdsc);
            ucDdo_br_medicalimaging_imagedes.SetProperty("SearchButtonText", Ddo_br_medicalimaging_imagedes_Searchbuttontext);
            ucDdo_br_medicalimaging_imagedes.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_imagedes.SetProperty("DropDownOptionsData", AV35BR_MedicalImaging_ImageDesTitleFilterData);
            ucDdo_br_medicalimaging_imagedes.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_imagedes_Internalname, "DDO_BR_MEDICALIMAGING_IMAGEDESContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_imagedestitlecontrolidtoreplace_Internalname, AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,70);\"", 0, edtavDdo_br_medicalimaging_imagedestitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImagingPrompt.htm");
            /* User Defined Control */
            ucDdo_br_medicalimaging_tumorsize.SetProperty("Caption", Ddo_br_medicalimaging_tumorsize_Caption);
            ucDdo_br_medicalimaging_tumorsize.SetProperty("Tooltip", Ddo_br_medicalimaging_tumorsize_Tooltip);
            ucDdo_br_medicalimaging_tumorsize.SetProperty("Cls", Ddo_br_medicalimaging_tumorsize_Cls);
            ucDdo_br_medicalimaging_tumorsize.SetProperty("DropDownOptionsType", Ddo_br_medicalimaging_tumorsize_Dropdownoptionstype);
            ucDdo_br_medicalimaging_tumorsize.SetProperty("IncludeSortASC", Ddo_br_medicalimaging_tumorsize_Includesortasc);
            ucDdo_br_medicalimaging_tumorsize.SetProperty("IncludeSortDSC", Ddo_br_medicalimaging_tumorsize_Includesortdsc);
            ucDdo_br_medicalimaging_tumorsize.SetProperty("IncludeFilter", Ddo_br_medicalimaging_tumorsize_Includefilter);
            ucDdo_br_medicalimaging_tumorsize.SetProperty("IncludeDataList", Ddo_br_medicalimaging_tumorsize_Includedatalist);
            ucDdo_br_medicalimaging_tumorsize.SetProperty("SortASC", Ddo_br_medicalimaging_tumorsize_Sortasc);
            ucDdo_br_medicalimaging_tumorsize.SetProperty("SortDSC", Ddo_br_medicalimaging_tumorsize_Sortdsc);
            ucDdo_br_medicalimaging_tumorsize.SetProperty("SearchButtonText", Ddo_br_medicalimaging_tumorsize_Searchbuttontext);
            ucDdo_br_medicalimaging_tumorsize.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_tumorsize.SetProperty("DropDownOptionsData", AV37BR_MedicalImaging_TumorSizeTitleFilterData);
            ucDdo_br_medicalimaging_tumorsize.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_tumorsize_Internalname, "DDO_BR_MEDICALIMAGING_TUMORSIZEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_tumorsizetitlecontrolidtoreplace_Internalname, AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,72);\"", 0, edtavDdo_br_medicalimaging_tumorsizetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImagingPrompt.htm");
            /* User Defined Control */
            ucDdo_br_medicalimaging_imagehtml.SetProperty("Caption", Ddo_br_medicalimaging_imagehtml_Caption);
            ucDdo_br_medicalimaging_imagehtml.SetProperty("Tooltip", Ddo_br_medicalimaging_imagehtml_Tooltip);
            ucDdo_br_medicalimaging_imagehtml.SetProperty("Cls", Ddo_br_medicalimaging_imagehtml_Cls);
            ucDdo_br_medicalimaging_imagehtml.SetProperty("DropDownOptionsType", Ddo_br_medicalimaging_imagehtml_Dropdownoptionstype);
            ucDdo_br_medicalimaging_imagehtml.SetProperty("IncludeSortASC", Ddo_br_medicalimaging_imagehtml_Includesortasc);
            ucDdo_br_medicalimaging_imagehtml.SetProperty("IncludeSortDSC", Ddo_br_medicalimaging_imagehtml_Includesortdsc);
            ucDdo_br_medicalimaging_imagehtml.SetProperty("IncludeFilter", Ddo_br_medicalimaging_imagehtml_Includefilter);
            ucDdo_br_medicalimaging_imagehtml.SetProperty("IncludeDataList", Ddo_br_medicalimaging_imagehtml_Includedatalist);
            ucDdo_br_medicalimaging_imagehtml.SetProperty("SortASC", Ddo_br_medicalimaging_imagehtml_Sortasc);
            ucDdo_br_medicalimaging_imagehtml.SetProperty("SortDSC", Ddo_br_medicalimaging_imagehtml_Sortdsc);
            ucDdo_br_medicalimaging_imagehtml.SetProperty("SearchButtonText", Ddo_br_medicalimaging_imagehtml_Searchbuttontext);
            ucDdo_br_medicalimaging_imagehtml.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_imagehtml.SetProperty("DropDownOptionsData", AV46BR_MedicalImaging_ImageHtmlTitleFilterData);
            ucDdo_br_medicalimaging_imagehtml.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_imagehtml_Internalname, "DDO_BR_MEDICALIMAGING_IMAGEHTMLContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_imagehtmltitlecontrolidtoreplace_Internalname, AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,74);\"", 0, edtavDdo_br_medicalimaging_imagehtmltitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImagingPrompt.htm");
            /* User Defined Control */
            ucDdo_br_medicalimaging_metastasesdx.SetProperty("Caption", Ddo_br_medicalimaging_metastasesdx_Caption);
            ucDdo_br_medicalimaging_metastasesdx.SetProperty("Tooltip", Ddo_br_medicalimaging_metastasesdx_Tooltip);
            ucDdo_br_medicalimaging_metastasesdx.SetProperty("Cls", Ddo_br_medicalimaging_metastasesdx_Cls);
            ucDdo_br_medicalimaging_metastasesdx.SetProperty("DropDownOptionsType", Ddo_br_medicalimaging_metastasesdx_Dropdownoptionstype);
            ucDdo_br_medicalimaging_metastasesdx.SetProperty("IncludeSortASC", Ddo_br_medicalimaging_metastasesdx_Includesortasc);
            ucDdo_br_medicalimaging_metastasesdx.SetProperty("IncludeSortDSC", Ddo_br_medicalimaging_metastasesdx_Includesortdsc);
            ucDdo_br_medicalimaging_metastasesdx.SetProperty("IncludeFilter", Ddo_br_medicalimaging_metastasesdx_Includefilter);
            ucDdo_br_medicalimaging_metastasesdx.SetProperty("IncludeDataList", Ddo_br_medicalimaging_metastasesdx_Includedatalist);
            ucDdo_br_medicalimaging_metastasesdx.SetProperty("SortASC", Ddo_br_medicalimaging_metastasesdx_Sortasc);
            ucDdo_br_medicalimaging_metastasesdx.SetProperty("SortDSC", Ddo_br_medicalimaging_metastasesdx_Sortdsc);
            ucDdo_br_medicalimaging_metastasesdx.SetProperty("SearchButtonText", Ddo_br_medicalimaging_metastasesdx_Searchbuttontext);
            ucDdo_br_medicalimaging_metastasesdx.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_metastasesdx.SetProperty("DropDownOptionsData", AV54BR_MedicalImaging_MetastasesDXTitleFilterData);
            ucDdo_br_medicalimaging_metastasesdx.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_metastasesdx_Internalname, "DDO_BR_MEDICALIMAGING_METASTASESDXContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_metastasesdxtitlecontrolidtoreplace_Internalname, AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,76);\"", 0, edtavDdo_br_medicalimaging_metastasesdxtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImagingPrompt.htm");
            /* User Defined Control */
            ucDdo_br_medicalimaging_metaloc.SetProperty("Caption", Ddo_br_medicalimaging_metaloc_Caption);
            ucDdo_br_medicalimaging_metaloc.SetProperty("Tooltip", Ddo_br_medicalimaging_metaloc_Tooltip);
            ucDdo_br_medicalimaging_metaloc.SetProperty("Cls", Ddo_br_medicalimaging_metaloc_Cls);
            ucDdo_br_medicalimaging_metaloc.SetProperty("DropDownOptionsType", Ddo_br_medicalimaging_metaloc_Dropdownoptionstype);
            ucDdo_br_medicalimaging_metaloc.SetProperty("IncludeSortASC", Ddo_br_medicalimaging_metaloc_Includesortasc);
            ucDdo_br_medicalimaging_metaloc.SetProperty("IncludeSortDSC", Ddo_br_medicalimaging_metaloc_Includesortdsc);
            ucDdo_br_medicalimaging_metaloc.SetProperty("IncludeFilter", Ddo_br_medicalimaging_metaloc_Includefilter);
            ucDdo_br_medicalimaging_metaloc.SetProperty("IncludeDataList", Ddo_br_medicalimaging_metaloc_Includedatalist);
            ucDdo_br_medicalimaging_metaloc.SetProperty("SortASC", Ddo_br_medicalimaging_metaloc_Sortasc);
            ucDdo_br_medicalimaging_metaloc.SetProperty("SortDSC", Ddo_br_medicalimaging_metaloc_Sortdsc);
            ucDdo_br_medicalimaging_metaloc.SetProperty("SearchButtonText", Ddo_br_medicalimaging_metaloc_Searchbuttontext);
            ucDdo_br_medicalimaging_metaloc.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_metaloc.SetProperty("DropDownOptionsData", AV56BR_MedicalImaging_MetaLocTitleFilterData);
            ucDdo_br_medicalimaging_metaloc.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_metaloc_Internalname, "DDO_BR_MEDICALIMAGING_METALOCContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_metaloctitlecontrolidtoreplace_Internalname, AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,78);\"", 0, edtavDdo_br_medicalimaging_metaloctitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImagingPrompt.htm");
            /* User Defined Control */
            ucDdo_br_medicalimaging_metadate.SetProperty("Caption", Ddo_br_medicalimaging_metadate_Caption);
            ucDdo_br_medicalimaging_metadate.SetProperty("Tooltip", Ddo_br_medicalimaging_metadate_Tooltip);
            ucDdo_br_medicalimaging_metadate.SetProperty("Cls", Ddo_br_medicalimaging_metadate_Cls);
            ucDdo_br_medicalimaging_metadate.SetProperty("DropDownOptionsType", Ddo_br_medicalimaging_metadate_Dropdownoptionstype);
            ucDdo_br_medicalimaging_metadate.SetProperty("IncludeSortASC", Ddo_br_medicalimaging_metadate_Includesortasc);
            ucDdo_br_medicalimaging_metadate.SetProperty("IncludeSortDSC", Ddo_br_medicalimaging_metadate_Includesortdsc);
            ucDdo_br_medicalimaging_metadate.SetProperty("IncludeFilter", Ddo_br_medicalimaging_metadate_Includefilter);
            ucDdo_br_medicalimaging_metadate.SetProperty("IncludeDataList", Ddo_br_medicalimaging_metadate_Includedatalist);
            ucDdo_br_medicalimaging_metadate.SetProperty("SortASC", Ddo_br_medicalimaging_metadate_Sortasc);
            ucDdo_br_medicalimaging_metadate.SetProperty("SortDSC", Ddo_br_medicalimaging_metadate_Sortdsc);
            ucDdo_br_medicalimaging_metadate.SetProperty("SearchButtonText", Ddo_br_medicalimaging_metadate_Searchbuttontext);
            ucDdo_br_medicalimaging_metadate.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_metadate.SetProperty("DropDownOptionsData", AV58BR_MedicalImaging_MetaDateTitleFilterData);
            ucDdo_br_medicalimaging_metadate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_metadate_Internalname, "DDO_BR_MEDICALIMAGING_METADATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_metadatetitlecontrolidtoreplace_Internalname, AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,80);\"", 0, edtavDdo_br_medicalimaging_metadatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImagingPrompt.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 82,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,82);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicalImagingPrompt.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV12OrderedDsc), StringUtil.BoolToStr( AV12OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,83);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_MedicalImagingPrompt.htm");
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

      protected void START5L2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "选择影像学", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP5L0( ) ;
      }

      protected void WS5L2( )
      {
         START5L2( ) ;
         EVT5L2( ) ;
      }

      protected void EVT5L2( )
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
                           E115L2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E125L2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGINGID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E135L2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTERID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E145L2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E155L2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_ID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E165L2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_IMAGENAME.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E175L2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E185L2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_IMAGEDATE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E195L2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_IMAGEHOSP.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E205L2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E215L2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_IMAGEAGE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E225L2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_IMAGELOC.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E235L2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E245L2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_IMAGEORGAN.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E255L2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E265L2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_IMAGEDES.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E275L2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_TUMORSIZE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E285L2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_IMAGEHTML.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E295L2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_METASTASESDX.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E305L2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_METALOC.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E315L2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_METADATE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E325L2 ();
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
                           AV44Select = cgiGet( edtavSelect_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV44Select)) ? AV63Select_GXI : context.convertURL( context.PathToRelativeUrl( AV44Select))), !bGXsfl_12_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "SrcSet", context.GetImageSrcSet( AV44Select), true);
                           A225BR_MedicalImagingID = (long)(context.localUtil.CToN( cgiGet( edtBR_MedicalImagingID_Internalname), ".", ","));
                           A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
                           n19BR_EncounterID = false;
                           A36BR_Information_PatientNo = cgiGet( edtBR_Information_PatientNo_Internalname);
                           n36BR_Information_PatientNo = false;
                           A227BR_MedicalImaging_ID = (long)(context.localUtil.CToN( cgiGet( edtBR_MedicalImaging_ID_Internalname), ".", ","));
                           n227BR_MedicalImaging_ID = false;
                           A228BR_MedicalImaging_ImageName = cgiGet( edtBR_MedicalImaging_ImageName_Internalname);
                           n228BR_MedicalImaging_ImageName = false;
                           A484BR_MedicalImaging_ImageName_Code = cgiGet( edtBR_MedicalImaging_ImageName_Code_Internalname);
                           n484BR_MedicalImaging_ImageName_Code = false;
                           A229BR_MedicalImaging_ImageDate = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtBR_MedicalImaging_ImageDate_Internalname), 0));
                           n229BR_MedicalImaging_ImageDate = false;
                           A230BR_MedicalImaging_ImageHosp = cgiGet( edtBR_MedicalImaging_ImageHosp_Internalname);
                           n230BR_MedicalImaging_ImageHosp = false;
                           A485BR_MedicalImaging_ImageHosp_Code = cgiGet( edtBR_MedicalImaging_ImageHosp_Code_Internalname);
                           n485BR_MedicalImaging_ImageHosp_Code = false;
                           A231BR_MedicalImaging_ImageAge = (short)(context.localUtil.CToN( cgiGet( edtBR_MedicalImaging_ImageAge_Internalname), ".", ","));
                           n231BR_MedicalImaging_ImageAge = false;
                           A232BR_MedicalImaging_ImageLoc = cgiGet( edtBR_MedicalImaging_ImageLoc_Internalname);
                           n232BR_MedicalImaging_ImageLoc = false;
                           A486BR_MedicalImaging_ImageLoc_Code = cgiGet( edtBR_MedicalImaging_ImageLoc_Code_Internalname);
                           n486BR_MedicalImaging_ImageLoc_Code = false;
                           A233BR_MedicalImaging_ImageOrgan = cgiGet( edtBR_MedicalImaging_ImageOrgan_Internalname);
                           n233BR_MedicalImaging_ImageOrgan = false;
                           A234BR_MedicalImaging_PreImageDiag = cgiGet( edtBR_MedicalImaging_PreImageDiag_Internalname);
                           n234BR_MedicalImaging_PreImageDiag = false;
                           A235BR_MedicalImaging_ImageDes = cgiGet( edtBR_MedicalImaging_ImageDes_Internalname);
                           n235BR_MedicalImaging_ImageDes = false;
                           A236BR_MedicalImaging_TumorSize = cgiGet( edtBR_MedicalImaging_TumorSize_Internalname);
                           n236BR_MedicalImaging_TumorSize = false;
                           A334BR_MedicalImaging_ImageHtml = cgiGet( edtBR_MedicalImaging_ImageHtml_Internalname);
                           n334BR_MedicalImaging_ImageHtml = false;
                           cmbBR_MedicalImaging_MetastasesDX.Name = cmbBR_MedicalImaging_MetastasesDX_Internalname;
                           cmbBR_MedicalImaging_MetastasesDX.CurrentValue = cgiGet( cmbBR_MedicalImaging_MetastasesDX_Internalname);
                           A514BR_MedicalImaging_MetastasesDX = cgiGet( cmbBR_MedicalImaging_MetastasesDX_Internalname);
                           n514BR_MedicalImaging_MetastasesDX = false;
                           A515BR_MedicalImaging_MetaLoc = cgiGet( edtBR_MedicalImaging_MetaLoc_Internalname);
                           n515BR_MedicalImaging_MetaLoc = false;
                           A516BR_MedicalImaging_MetaDate = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtBR_MedicalImaging_MetaDate_Internalname), 0));
                           n516BR_MedicalImaging_MetaDate = false;
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E335L2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E345L2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E355L2 ();
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
                                       E365L2 ();
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

      protected void WE5L2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm5L2( ) ;
            }
         }
      }

      protected void PA5L2( )
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
               GX_FocusControl = edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Internalname;
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
                                       String AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace ,
                                       String AV16ddo_BR_EncounterIDTitleControlIdToReplace ,
                                       String AV18ddo_BR_Information_PatientNoTitleControlIdToReplace ,
                                       String AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace ,
                                       String AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace ,
                                       String AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace ,
                                       String AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace ,
                                       String AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace ,
                                       String AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace ,
                                       String AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace ,
                                       String AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace ,
                                       String AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace ,
                                       String AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace ,
                                       String AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace ,
                                       String AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace ,
                                       String AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace ,
                                       String AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace ,
                                       String AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace ,
                                       String AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace ,
                                       String AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF5L2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_MEDICALIMAGINGID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A225BR_MedicalImagingID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_MEDICALIMAGINGID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A225BR_MedicalImagingID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_MEDICALIMAGING_IMAGENAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A228BR_MedicalImaging_ImageName, "")), context));
         GxWebStd.gx_hidden_field( context, "BR_MEDICALIMAGING_IMAGENAME", A228BR_MedicalImaging_ImageName);
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
         RF5L2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV62Pgmname = "BR_MedicalImagingPrompt";
         context.Gx_err = 0;
      }

      protected void RF5L2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 12;
         /* Execute user event: Refresh */
         E345L2 ();
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
            /* Using cursor H005L2 */
            pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_12_idx = 1;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A85BR_Information_ID = H005L2_A85BR_Information_ID[0];
               n85BR_Information_ID = H005L2_n85BR_Information_ID[0];
               A516BR_MedicalImaging_MetaDate = H005L2_A516BR_MedicalImaging_MetaDate[0];
               n516BR_MedicalImaging_MetaDate = H005L2_n516BR_MedicalImaging_MetaDate[0];
               A515BR_MedicalImaging_MetaLoc = H005L2_A515BR_MedicalImaging_MetaLoc[0];
               n515BR_MedicalImaging_MetaLoc = H005L2_n515BR_MedicalImaging_MetaLoc[0];
               A514BR_MedicalImaging_MetastasesDX = H005L2_A514BR_MedicalImaging_MetastasesDX[0];
               n514BR_MedicalImaging_MetastasesDX = H005L2_n514BR_MedicalImaging_MetastasesDX[0];
               A334BR_MedicalImaging_ImageHtml = H005L2_A334BR_MedicalImaging_ImageHtml[0];
               n334BR_MedicalImaging_ImageHtml = H005L2_n334BR_MedicalImaging_ImageHtml[0];
               A236BR_MedicalImaging_TumorSize = H005L2_A236BR_MedicalImaging_TumorSize[0];
               n236BR_MedicalImaging_TumorSize = H005L2_n236BR_MedicalImaging_TumorSize[0];
               A235BR_MedicalImaging_ImageDes = H005L2_A235BR_MedicalImaging_ImageDes[0];
               n235BR_MedicalImaging_ImageDes = H005L2_n235BR_MedicalImaging_ImageDes[0];
               A234BR_MedicalImaging_PreImageDiag = H005L2_A234BR_MedicalImaging_PreImageDiag[0];
               n234BR_MedicalImaging_PreImageDiag = H005L2_n234BR_MedicalImaging_PreImageDiag[0];
               A233BR_MedicalImaging_ImageOrgan = H005L2_A233BR_MedicalImaging_ImageOrgan[0];
               n233BR_MedicalImaging_ImageOrgan = H005L2_n233BR_MedicalImaging_ImageOrgan[0];
               A486BR_MedicalImaging_ImageLoc_Code = H005L2_A486BR_MedicalImaging_ImageLoc_Code[0];
               n486BR_MedicalImaging_ImageLoc_Code = H005L2_n486BR_MedicalImaging_ImageLoc_Code[0];
               A232BR_MedicalImaging_ImageLoc = H005L2_A232BR_MedicalImaging_ImageLoc[0];
               n232BR_MedicalImaging_ImageLoc = H005L2_n232BR_MedicalImaging_ImageLoc[0];
               A231BR_MedicalImaging_ImageAge = H005L2_A231BR_MedicalImaging_ImageAge[0];
               n231BR_MedicalImaging_ImageAge = H005L2_n231BR_MedicalImaging_ImageAge[0];
               A485BR_MedicalImaging_ImageHosp_Code = H005L2_A485BR_MedicalImaging_ImageHosp_Code[0];
               n485BR_MedicalImaging_ImageHosp_Code = H005L2_n485BR_MedicalImaging_ImageHosp_Code[0];
               A230BR_MedicalImaging_ImageHosp = H005L2_A230BR_MedicalImaging_ImageHosp[0];
               n230BR_MedicalImaging_ImageHosp = H005L2_n230BR_MedicalImaging_ImageHosp[0];
               A229BR_MedicalImaging_ImageDate = H005L2_A229BR_MedicalImaging_ImageDate[0];
               n229BR_MedicalImaging_ImageDate = H005L2_n229BR_MedicalImaging_ImageDate[0];
               A484BR_MedicalImaging_ImageName_Code = H005L2_A484BR_MedicalImaging_ImageName_Code[0];
               n484BR_MedicalImaging_ImageName_Code = H005L2_n484BR_MedicalImaging_ImageName_Code[0];
               A228BR_MedicalImaging_ImageName = H005L2_A228BR_MedicalImaging_ImageName[0];
               n228BR_MedicalImaging_ImageName = H005L2_n228BR_MedicalImaging_ImageName[0];
               A227BR_MedicalImaging_ID = H005L2_A227BR_MedicalImaging_ID[0];
               n227BR_MedicalImaging_ID = H005L2_n227BR_MedicalImaging_ID[0];
               A36BR_Information_PatientNo = H005L2_A36BR_Information_PatientNo[0];
               n36BR_Information_PatientNo = H005L2_n36BR_Information_PatientNo[0];
               A19BR_EncounterID = H005L2_A19BR_EncounterID[0];
               n19BR_EncounterID = H005L2_n19BR_EncounterID[0];
               A225BR_MedicalImagingID = H005L2_A225BR_MedicalImagingID[0];
               A85BR_Information_ID = H005L2_A85BR_Information_ID[0];
               n85BR_Information_ID = H005L2_n85BR_Information_ID[0];
               A36BR_Information_PatientNo = H005L2_A36BR_Information_PatientNo[0];
               n36BR_Information_PatientNo = H005L2_n36BR_Information_PatientNo[0];
               E355L2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 12;
            WB5L0( ) ;
         }
         bGXsfl_12_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes5L2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_MEDICALIMAGINGID"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, context.localUtil.Format( (decimal)(A225BR_MedicalImagingID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_MEDICALIMAGING_IMAGENAME"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, StringUtil.RTrim( context.localUtil.Format( A228BR_MedicalImaging_ImageName, "")), context));
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
         /* Using cursor H005L3 */
         pr_default.execute(1);
         GRID_nRecordCount = H005L3_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_Information_PatientNoTitleControlIdToReplace, AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace, AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace, AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace, AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace, AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace, AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace, AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace, AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace, AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace, AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace, AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace, AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace, AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace, AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace, AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace, AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace, AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_Information_PatientNoTitleControlIdToReplace, AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace, AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace, AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace, AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace, AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace, AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace, AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace, AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace, AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace, AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace, AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace, AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace, AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace, AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace, AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace, AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace, AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_Information_PatientNoTitleControlIdToReplace, AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace, AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace, AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace, AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace, AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace, AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace, AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace, AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace, AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace, AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace, AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace, AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace, AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace, AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace, AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace, AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace, AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_Information_PatientNoTitleControlIdToReplace, AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace, AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace, AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace, AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace, AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace, AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace, AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace, AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace, AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace, AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace, AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace, AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace, AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace, AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace, AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace, AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace, AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_Information_PatientNoTitleControlIdToReplace, AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace, AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace, AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace, AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace, AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace, AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace, AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace, AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace, AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace, AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace, AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace, AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace, AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace, AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace, AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace, AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace, AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP5L0( )
      {
         /* Before Start, stand alone formulas. */
         AV62Pgmname = "BR_MedicalImagingPrompt";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E335L2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV39DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICALIMAGINGIDTITLEFILTERDATA"), AV13BR_MedicalImagingIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTERIDTITLEFILTERDATA"), AV15BR_EncounterIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_INFORMATION_PATIENTNOTITLEFILTERDATA"), AV17BR_Information_PatientNoTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICALIMAGING_IDTITLEFILTERDATA"), AV19BR_MedicalImaging_IDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA"), AV21BR_MedicalImaging_ImageNameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICALIMAGING_IMAGENAME_CODETITLEFILTERDATA"), AV48BR_MedicalImaging_ImageName_CodeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA"), AV23BR_MedicalImaging_ImageDateTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA"), AV25BR_MedicalImaging_ImageHospTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICALIMAGING_IMAGEHOSP_CODETITLEFILTERDATA"), AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA"), AV27BR_MedicalImaging_ImageAgeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICALIMAGING_IMAGELOCTITLEFILTERDATA"), AV29BR_MedicalImaging_ImageLocTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICALIMAGING_IMAGELOC_CODETITLEFILTERDATA"), AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICALIMAGING_IMAGEORGANTITLEFILTERDATA"), AV31BR_MedicalImaging_ImageOrganTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICALIMAGING_PREIMAGEDIAGTITLEFILTERDATA"), AV33BR_MedicalImaging_PreImageDiagTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICALIMAGING_IMAGEDESTITLEFILTERDATA"), AV35BR_MedicalImaging_ImageDesTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICALIMAGING_TUMORSIZETITLEFILTERDATA"), AV37BR_MedicalImaging_TumorSizeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICALIMAGING_IMAGEHTMLTITLEFILTERDATA"), AV46BR_MedicalImaging_ImageHtmlTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICALIMAGING_METASTASESDXTITLEFILTERDATA"), AV54BR_MedicalImaging_MetastasesDXTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICALIMAGING_METALOCTITLEFILTERDATA"), AV56BR_MedicalImaging_MetaLocTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICALIMAGING_METADATETITLEFILTERDATA"), AV58BR_MedicalImaging_MetaDateTitleFilterData);
            /* Read variables values. */
            AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace", AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace);
            AV16ddo_BR_EncounterIDTitleControlIdToReplace = cgiGet( edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_BR_EncounterIDTitleControlIdToReplace", AV16ddo_BR_EncounterIDTitleControlIdToReplace);
            AV18ddo_BR_Information_PatientNoTitleControlIdToReplace = cgiGet( edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_BR_Information_PatientNoTitleControlIdToReplace", AV18ddo_BR_Information_PatientNoTitleControlIdToReplace);
            AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_idtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace", AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace);
            AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_imagenametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace", AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace);
            AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_imagename_codetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace", AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace);
            AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_imagedatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace", AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace);
            AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_imagehosptitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace", AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace);
            AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_imagehosp_codetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace", AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace);
            AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_imageagetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace", AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace);
            AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_imageloctitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace", AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace);
            AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_imageloc_codetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace", AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace);
            AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_imageorgantitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace", AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace);
            AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_preimagediagtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace", AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace);
            AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_imagedestitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace", AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace);
            AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_tumorsizetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace", AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace);
            AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_imagehtmltitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace", AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace);
            AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_metastasesdxtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace", AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace);
            AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_metaloctitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace", AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace);
            AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_metadatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace", AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace);
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
            AV41GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV43GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV42GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_medicalimaging_id_Caption = cgiGet( "DDO_BR_MEDICALIMAGING_ID_Caption");
            Ddo_br_medicalimaging_id_Tooltip = cgiGet( "DDO_BR_MEDICALIMAGING_ID_Tooltip");
            Ddo_br_medicalimaging_id_Cls = cgiGet( "DDO_BR_MEDICALIMAGING_ID_Cls");
            Ddo_br_medicalimaging_id_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICALIMAGING_ID_Dropdownoptionstype");
            Ddo_br_medicalimaging_id_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICALIMAGING_ID_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_id_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_ID_Includesortasc"));
            Ddo_br_medicalimaging_id_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_ID_Includesortdsc"));
            Ddo_br_medicalimaging_id_Sortedstatus = cgiGet( "DDO_BR_MEDICALIMAGING_ID_Sortedstatus");
            Ddo_br_medicalimaging_id_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_ID_Includefilter"));
            Ddo_br_medicalimaging_id_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_ID_Includedatalist"));
            Ddo_br_medicalimaging_id_Sortasc = cgiGet( "DDO_BR_MEDICALIMAGING_ID_Sortasc");
            Ddo_br_medicalimaging_id_Sortdsc = cgiGet( "DDO_BR_MEDICALIMAGING_ID_Sortdsc");
            Ddo_br_medicalimaging_id_Searchbuttontext = cgiGet( "DDO_BR_MEDICALIMAGING_ID_Searchbuttontext");
            Ddo_br_medicalimaging_imagename_Caption = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGENAME_Caption");
            Ddo_br_medicalimaging_imagename_Tooltip = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGENAME_Tooltip");
            Ddo_br_medicalimaging_imagename_Cls = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGENAME_Cls");
            Ddo_br_medicalimaging_imagename_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGENAME_Dropdownoptionstype");
            Ddo_br_medicalimaging_imagename_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGENAME_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_imagename_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGENAME_Includesortasc"));
            Ddo_br_medicalimaging_imagename_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGENAME_Includesortdsc"));
            Ddo_br_medicalimaging_imagename_Sortedstatus = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGENAME_Sortedstatus");
            Ddo_br_medicalimaging_imagename_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGENAME_Includefilter"));
            Ddo_br_medicalimaging_imagename_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGENAME_Includedatalist"));
            Ddo_br_medicalimaging_imagename_Sortasc = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGENAME_Sortasc");
            Ddo_br_medicalimaging_imagename_Sortdsc = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGENAME_Sortdsc");
            Ddo_br_medicalimaging_imagename_Searchbuttontext = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGENAME_Searchbuttontext");
            Ddo_br_medicalimaging_imagename_code_Caption = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE_Caption");
            Ddo_br_medicalimaging_imagename_code_Tooltip = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE_Tooltip");
            Ddo_br_medicalimaging_imagename_code_Cls = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE_Cls");
            Ddo_br_medicalimaging_imagename_code_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE_Dropdownoptionstype");
            Ddo_br_medicalimaging_imagename_code_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_imagename_code_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE_Includesortasc"));
            Ddo_br_medicalimaging_imagename_code_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE_Includesortdsc"));
            Ddo_br_medicalimaging_imagename_code_Sortedstatus = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE_Sortedstatus");
            Ddo_br_medicalimaging_imagename_code_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE_Includefilter"));
            Ddo_br_medicalimaging_imagename_code_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE_Includedatalist"));
            Ddo_br_medicalimaging_imagename_code_Sortasc = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE_Sortasc");
            Ddo_br_medicalimaging_imagename_code_Sortdsc = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE_Sortdsc");
            Ddo_br_medicalimaging_imagename_code_Searchbuttontext = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE_Searchbuttontext");
            Ddo_br_medicalimaging_imagedate_Caption = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEDATE_Caption");
            Ddo_br_medicalimaging_imagedate_Tooltip = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEDATE_Tooltip");
            Ddo_br_medicalimaging_imagedate_Cls = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEDATE_Cls");
            Ddo_br_medicalimaging_imagedate_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEDATE_Dropdownoptionstype");
            Ddo_br_medicalimaging_imagedate_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEDATE_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_imagedate_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEDATE_Includesortasc"));
            Ddo_br_medicalimaging_imagedate_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEDATE_Includesortdsc"));
            Ddo_br_medicalimaging_imagedate_Sortedstatus = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEDATE_Sortedstatus");
            Ddo_br_medicalimaging_imagedate_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEDATE_Includefilter"));
            Ddo_br_medicalimaging_imagedate_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEDATE_Includedatalist"));
            Ddo_br_medicalimaging_imagedate_Sortasc = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEDATE_Sortasc");
            Ddo_br_medicalimaging_imagedate_Sortdsc = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEDATE_Sortdsc");
            Ddo_br_medicalimaging_imagedate_Searchbuttontext = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEDATE_Searchbuttontext");
            Ddo_br_medicalimaging_imagehosp_Caption = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHOSP_Caption");
            Ddo_br_medicalimaging_imagehosp_Tooltip = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHOSP_Tooltip");
            Ddo_br_medicalimaging_imagehosp_Cls = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHOSP_Cls");
            Ddo_br_medicalimaging_imagehosp_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHOSP_Dropdownoptionstype");
            Ddo_br_medicalimaging_imagehosp_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHOSP_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_imagehosp_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHOSP_Includesortasc"));
            Ddo_br_medicalimaging_imagehosp_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHOSP_Includesortdsc"));
            Ddo_br_medicalimaging_imagehosp_Sortedstatus = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHOSP_Sortedstatus");
            Ddo_br_medicalimaging_imagehosp_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHOSP_Includefilter"));
            Ddo_br_medicalimaging_imagehosp_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHOSP_Includedatalist"));
            Ddo_br_medicalimaging_imagehosp_Sortasc = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHOSP_Sortasc");
            Ddo_br_medicalimaging_imagehosp_Sortdsc = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHOSP_Sortdsc");
            Ddo_br_medicalimaging_imagehosp_Searchbuttontext = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHOSP_Searchbuttontext");
            Ddo_br_medicalimaging_imagehosp_code_Caption = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE_Caption");
            Ddo_br_medicalimaging_imagehosp_code_Tooltip = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE_Tooltip");
            Ddo_br_medicalimaging_imagehosp_code_Cls = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE_Cls");
            Ddo_br_medicalimaging_imagehosp_code_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE_Dropdownoptionstype");
            Ddo_br_medicalimaging_imagehosp_code_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_imagehosp_code_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE_Includesortasc"));
            Ddo_br_medicalimaging_imagehosp_code_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE_Includesortdsc"));
            Ddo_br_medicalimaging_imagehosp_code_Sortedstatus = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE_Sortedstatus");
            Ddo_br_medicalimaging_imagehosp_code_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE_Includefilter"));
            Ddo_br_medicalimaging_imagehosp_code_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE_Includedatalist"));
            Ddo_br_medicalimaging_imagehosp_code_Sortasc = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE_Sortasc");
            Ddo_br_medicalimaging_imagehosp_code_Sortdsc = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE_Sortdsc");
            Ddo_br_medicalimaging_imagehosp_code_Searchbuttontext = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE_Searchbuttontext");
            Ddo_br_medicalimaging_imageage_Caption = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEAGE_Caption");
            Ddo_br_medicalimaging_imageage_Tooltip = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEAGE_Tooltip");
            Ddo_br_medicalimaging_imageage_Cls = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEAGE_Cls");
            Ddo_br_medicalimaging_imageage_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEAGE_Dropdownoptionstype");
            Ddo_br_medicalimaging_imageage_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEAGE_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_imageage_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEAGE_Includesortasc"));
            Ddo_br_medicalimaging_imageage_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEAGE_Includesortdsc"));
            Ddo_br_medicalimaging_imageage_Sortedstatus = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEAGE_Sortedstatus");
            Ddo_br_medicalimaging_imageage_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEAGE_Includefilter"));
            Ddo_br_medicalimaging_imageage_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEAGE_Includedatalist"));
            Ddo_br_medicalimaging_imageage_Sortasc = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEAGE_Sortasc");
            Ddo_br_medicalimaging_imageage_Sortdsc = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEAGE_Sortdsc");
            Ddo_br_medicalimaging_imageage_Searchbuttontext = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEAGE_Searchbuttontext");
            Ddo_br_medicalimaging_imageloc_Caption = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGELOC_Caption");
            Ddo_br_medicalimaging_imageloc_Tooltip = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGELOC_Tooltip");
            Ddo_br_medicalimaging_imageloc_Cls = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGELOC_Cls");
            Ddo_br_medicalimaging_imageloc_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGELOC_Dropdownoptionstype");
            Ddo_br_medicalimaging_imageloc_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGELOC_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_imageloc_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGELOC_Includesortasc"));
            Ddo_br_medicalimaging_imageloc_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGELOC_Includesortdsc"));
            Ddo_br_medicalimaging_imageloc_Sortedstatus = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGELOC_Sortedstatus");
            Ddo_br_medicalimaging_imageloc_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGELOC_Includefilter"));
            Ddo_br_medicalimaging_imageloc_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGELOC_Includedatalist"));
            Ddo_br_medicalimaging_imageloc_Sortasc = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGELOC_Sortasc");
            Ddo_br_medicalimaging_imageloc_Sortdsc = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGELOC_Sortdsc");
            Ddo_br_medicalimaging_imageloc_Searchbuttontext = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGELOC_Searchbuttontext");
            Ddo_br_medicalimaging_imageloc_code_Caption = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE_Caption");
            Ddo_br_medicalimaging_imageloc_code_Tooltip = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE_Tooltip");
            Ddo_br_medicalimaging_imageloc_code_Cls = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE_Cls");
            Ddo_br_medicalimaging_imageloc_code_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE_Dropdownoptionstype");
            Ddo_br_medicalimaging_imageloc_code_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_imageloc_code_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE_Includesortasc"));
            Ddo_br_medicalimaging_imageloc_code_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE_Includesortdsc"));
            Ddo_br_medicalimaging_imageloc_code_Sortedstatus = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE_Sortedstatus");
            Ddo_br_medicalimaging_imageloc_code_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE_Includefilter"));
            Ddo_br_medicalimaging_imageloc_code_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE_Includedatalist"));
            Ddo_br_medicalimaging_imageloc_code_Sortasc = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE_Sortasc");
            Ddo_br_medicalimaging_imageloc_code_Sortdsc = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE_Sortdsc");
            Ddo_br_medicalimaging_imageloc_code_Searchbuttontext = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE_Searchbuttontext");
            Ddo_br_medicalimaging_imageorgan_Caption = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEORGAN_Caption");
            Ddo_br_medicalimaging_imageorgan_Tooltip = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEORGAN_Tooltip");
            Ddo_br_medicalimaging_imageorgan_Cls = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEORGAN_Cls");
            Ddo_br_medicalimaging_imageorgan_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEORGAN_Dropdownoptionstype");
            Ddo_br_medicalimaging_imageorgan_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEORGAN_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_imageorgan_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEORGAN_Includesortasc"));
            Ddo_br_medicalimaging_imageorgan_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEORGAN_Includesortdsc"));
            Ddo_br_medicalimaging_imageorgan_Sortedstatus = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEORGAN_Sortedstatus");
            Ddo_br_medicalimaging_imageorgan_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEORGAN_Includefilter"));
            Ddo_br_medicalimaging_imageorgan_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEORGAN_Includedatalist"));
            Ddo_br_medicalimaging_imageorgan_Sortasc = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEORGAN_Sortasc");
            Ddo_br_medicalimaging_imageorgan_Sortdsc = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEORGAN_Sortdsc");
            Ddo_br_medicalimaging_imageorgan_Searchbuttontext = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEORGAN_Searchbuttontext");
            Ddo_br_medicalimaging_preimagediag_Caption = cgiGet( "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG_Caption");
            Ddo_br_medicalimaging_preimagediag_Tooltip = cgiGet( "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG_Tooltip");
            Ddo_br_medicalimaging_preimagediag_Cls = cgiGet( "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG_Cls");
            Ddo_br_medicalimaging_preimagediag_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG_Dropdownoptionstype");
            Ddo_br_medicalimaging_preimagediag_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_preimagediag_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG_Includesortasc"));
            Ddo_br_medicalimaging_preimagediag_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG_Includesortdsc"));
            Ddo_br_medicalimaging_preimagediag_Sortedstatus = cgiGet( "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG_Sortedstatus");
            Ddo_br_medicalimaging_preimagediag_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG_Includefilter"));
            Ddo_br_medicalimaging_preimagediag_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG_Includedatalist"));
            Ddo_br_medicalimaging_preimagediag_Sortasc = cgiGet( "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG_Sortasc");
            Ddo_br_medicalimaging_preimagediag_Sortdsc = cgiGet( "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG_Sortdsc");
            Ddo_br_medicalimaging_preimagediag_Searchbuttontext = cgiGet( "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG_Searchbuttontext");
            Ddo_br_medicalimaging_imagedes_Caption = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEDES_Caption");
            Ddo_br_medicalimaging_imagedes_Tooltip = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEDES_Tooltip");
            Ddo_br_medicalimaging_imagedes_Cls = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEDES_Cls");
            Ddo_br_medicalimaging_imagedes_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEDES_Dropdownoptionstype");
            Ddo_br_medicalimaging_imagedes_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEDES_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_imagedes_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEDES_Includesortasc"));
            Ddo_br_medicalimaging_imagedes_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEDES_Includesortdsc"));
            Ddo_br_medicalimaging_imagedes_Sortedstatus = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEDES_Sortedstatus");
            Ddo_br_medicalimaging_imagedes_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEDES_Includefilter"));
            Ddo_br_medicalimaging_imagedes_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEDES_Includedatalist"));
            Ddo_br_medicalimaging_imagedes_Sortasc = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEDES_Sortasc");
            Ddo_br_medicalimaging_imagedes_Sortdsc = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEDES_Sortdsc");
            Ddo_br_medicalimaging_imagedes_Searchbuttontext = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEDES_Searchbuttontext");
            Ddo_br_medicalimaging_tumorsize_Caption = cgiGet( "DDO_BR_MEDICALIMAGING_TUMORSIZE_Caption");
            Ddo_br_medicalimaging_tumorsize_Tooltip = cgiGet( "DDO_BR_MEDICALIMAGING_TUMORSIZE_Tooltip");
            Ddo_br_medicalimaging_tumorsize_Cls = cgiGet( "DDO_BR_MEDICALIMAGING_TUMORSIZE_Cls");
            Ddo_br_medicalimaging_tumorsize_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICALIMAGING_TUMORSIZE_Dropdownoptionstype");
            Ddo_br_medicalimaging_tumorsize_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICALIMAGING_TUMORSIZE_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_tumorsize_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_TUMORSIZE_Includesortasc"));
            Ddo_br_medicalimaging_tumorsize_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_TUMORSIZE_Includesortdsc"));
            Ddo_br_medicalimaging_tumorsize_Sortedstatus = cgiGet( "DDO_BR_MEDICALIMAGING_TUMORSIZE_Sortedstatus");
            Ddo_br_medicalimaging_tumorsize_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_TUMORSIZE_Includefilter"));
            Ddo_br_medicalimaging_tumorsize_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_TUMORSIZE_Includedatalist"));
            Ddo_br_medicalimaging_tumorsize_Sortasc = cgiGet( "DDO_BR_MEDICALIMAGING_TUMORSIZE_Sortasc");
            Ddo_br_medicalimaging_tumorsize_Sortdsc = cgiGet( "DDO_BR_MEDICALIMAGING_TUMORSIZE_Sortdsc");
            Ddo_br_medicalimaging_tumorsize_Searchbuttontext = cgiGet( "DDO_BR_MEDICALIMAGING_TUMORSIZE_Searchbuttontext");
            Ddo_br_medicalimaging_imagehtml_Caption = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHTML_Caption");
            Ddo_br_medicalimaging_imagehtml_Tooltip = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHTML_Tooltip");
            Ddo_br_medicalimaging_imagehtml_Cls = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHTML_Cls");
            Ddo_br_medicalimaging_imagehtml_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHTML_Dropdownoptionstype");
            Ddo_br_medicalimaging_imagehtml_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHTML_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_imagehtml_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHTML_Includesortasc"));
            Ddo_br_medicalimaging_imagehtml_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHTML_Includesortdsc"));
            Ddo_br_medicalimaging_imagehtml_Sortedstatus = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHTML_Sortedstatus");
            Ddo_br_medicalimaging_imagehtml_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHTML_Includefilter"));
            Ddo_br_medicalimaging_imagehtml_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHTML_Includedatalist"));
            Ddo_br_medicalimaging_imagehtml_Sortasc = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHTML_Sortasc");
            Ddo_br_medicalimaging_imagehtml_Sortdsc = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHTML_Sortdsc");
            Ddo_br_medicalimaging_imagehtml_Searchbuttontext = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHTML_Searchbuttontext");
            Ddo_br_medicalimaging_metastasesdx_Caption = cgiGet( "DDO_BR_MEDICALIMAGING_METASTASESDX_Caption");
            Ddo_br_medicalimaging_metastasesdx_Tooltip = cgiGet( "DDO_BR_MEDICALIMAGING_METASTASESDX_Tooltip");
            Ddo_br_medicalimaging_metastasesdx_Cls = cgiGet( "DDO_BR_MEDICALIMAGING_METASTASESDX_Cls");
            Ddo_br_medicalimaging_metastasesdx_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICALIMAGING_METASTASESDX_Dropdownoptionstype");
            Ddo_br_medicalimaging_metastasesdx_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICALIMAGING_METASTASESDX_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_metastasesdx_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_METASTASESDX_Includesortasc"));
            Ddo_br_medicalimaging_metastasesdx_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_METASTASESDX_Includesortdsc"));
            Ddo_br_medicalimaging_metastasesdx_Sortedstatus = cgiGet( "DDO_BR_MEDICALIMAGING_METASTASESDX_Sortedstatus");
            Ddo_br_medicalimaging_metastasesdx_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_METASTASESDX_Includefilter"));
            Ddo_br_medicalimaging_metastasesdx_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_METASTASESDX_Includedatalist"));
            Ddo_br_medicalimaging_metastasesdx_Sortasc = cgiGet( "DDO_BR_MEDICALIMAGING_METASTASESDX_Sortasc");
            Ddo_br_medicalimaging_metastasesdx_Sortdsc = cgiGet( "DDO_BR_MEDICALIMAGING_METASTASESDX_Sortdsc");
            Ddo_br_medicalimaging_metastasesdx_Searchbuttontext = cgiGet( "DDO_BR_MEDICALIMAGING_METASTASESDX_Searchbuttontext");
            Ddo_br_medicalimaging_metaloc_Caption = cgiGet( "DDO_BR_MEDICALIMAGING_METALOC_Caption");
            Ddo_br_medicalimaging_metaloc_Tooltip = cgiGet( "DDO_BR_MEDICALIMAGING_METALOC_Tooltip");
            Ddo_br_medicalimaging_metaloc_Cls = cgiGet( "DDO_BR_MEDICALIMAGING_METALOC_Cls");
            Ddo_br_medicalimaging_metaloc_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICALIMAGING_METALOC_Dropdownoptionstype");
            Ddo_br_medicalimaging_metaloc_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICALIMAGING_METALOC_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_metaloc_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_METALOC_Includesortasc"));
            Ddo_br_medicalimaging_metaloc_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_METALOC_Includesortdsc"));
            Ddo_br_medicalimaging_metaloc_Sortedstatus = cgiGet( "DDO_BR_MEDICALIMAGING_METALOC_Sortedstatus");
            Ddo_br_medicalimaging_metaloc_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_METALOC_Includefilter"));
            Ddo_br_medicalimaging_metaloc_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_METALOC_Includedatalist"));
            Ddo_br_medicalimaging_metaloc_Sortasc = cgiGet( "DDO_BR_MEDICALIMAGING_METALOC_Sortasc");
            Ddo_br_medicalimaging_metaloc_Sortdsc = cgiGet( "DDO_BR_MEDICALIMAGING_METALOC_Sortdsc");
            Ddo_br_medicalimaging_metaloc_Searchbuttontext = cgiGet( "DDO_BR_MEDICALIMAGING_METALOC_Searchbuttontext");
            Ddo_br_medicalimaging_metadate_Caption = cgiGet( "DDO_BR_MEDICALIMAGING_METADATE_Caption");
            Ddo_br_medicalimaging_metadate_Tooltip = cgiGet( "DDO_BR_MEDICALIMAGING_METADATE_Tooltip");
            Ddo_br_medicalimaging_metadate_Cls = cgiGet( "DDO_BR_MEDICALIMAGING_METADATE_Cls");
            Ddo_br_medicalimaging_metadate_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICALIMAGING_METADATE_Dropdownoptionstype");
            Ddo_br_medicalimaging_metadate_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICALIMAGING_METADATE_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_metadate_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_METADATE_Includesortasc"));
            Ddo_br_medicalimaging_metadate_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_METADATE_Includesortdsc"));
            Ddo_br_medicalimaging_metadate_Sortedstatus = cgiGet( "DDO_BR_MEDICALIMAGING_METADATE_Sortedstatus");
            Ddo_br_medicalimaging_metadate_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_METADATE_Includefilter"));
            Ddo_br_medicalimaging_metadate_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICALIMAGING_METADATE_Includedatalist"));
            Ddo_br_medicalimaging_metadate_Sortasc = cgiGet( "DDO_BR_MEDICALIMAGING_METADATE_Sortasc");
            Ddo_br_medicalimaging_metadate_Sortdsc = cgiGet( "DDO_BR_MEDICALIMAGING_METADATE_Sortdsc");
            Ddo_br_medicalimaging_metadate_Searchbuttontext = cgiGet( "DDO_BR_MEDICALIMAGING_METADATE_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_medicalimagingid_Activeeventkey = cgiGet( "DDO_BR_MEDICALIMAGINGID_Activeeventkey");
            Ddo_br_encounterid_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTERID_Activeeventkey");
            Ddo_br_information_patientno_Activeeventkey = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey");
            Ddo_br_medicalimaging_id_Activeeventkey = cgiGet( "DDO_BR_MEDICALIMAGING_ID_Activeeventkey");
            Ddo_br_medicalimaging_imagename_Activeeventkey = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGENAME_Activeeventkey");
            Ddo_br_medicalimaging_imagename_code_Activeeventkey = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE_Activeeventkey");
            Ddo_br_medicalimaging_imagedate_Activeeventkey = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEDATE_Activeeventkey");
            Ddo_br_medicalimaging_imagehosp_Activeeventkey = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHOSP_Activeeventkey");
            Ddo_br_medicalimaging_imagehosp_code_Activeeventkey = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE_Activeeventkey");
            Ddo_br_medicalimaging_imageage_Activeeventkey = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEAGE_Activeeventkey");
            Ddo_br_medicalimaging_imageloc_Activeeventkey = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGELOC_Activeeventkey");
            Ddo_br_medicalimaging_imageloc_code_Activeeventkey = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE_Activeeventkey");
            Ddo_br_medicalimaging_imageorgan_Activeeventkey = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEORGAN_Activeeventkey");
            Ddo_br_medicalimaging_preimagediag_Activeeventkey = cgiGet( "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG_Activeeventkey");
            Ddo_br_medicalimaging_imagedes_Activeeventkey = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEDES_Activeeventkey");
            Ddo_br_medicalimaging_tumorsize_Activeeventkey = cgiGet( "DDO_BR_MEDICALIMAGING_TUMORSIZE_Activeeventkey");
            Ddo_br_medicalimaging_imagehtml_Activeeventkey = cgiGet( "DDO_BR_MEDICALIMAGING_IMAGEHTML_Activeeventkey");
            Ddo_br_medicalimaging_metastasesdx_Activeeventkey = cgiGet( "DDO_BR_MEDICALIMAGING_METASTASESDX_Activeeventkey");
            Ddo_br_medicalimaging_metaloc_Activeeventkey = cgiGet( "DDO_BR_MEDICALIMAGING_METALOC_Activeeventkey");
            Ddo_br_medicalimaging_metadate_Activeeventkey = cgiGet( "DDO_BR_MEDICALIMAGING_METADATE_Activeeventkey");
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
         E335L2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E335L2( )
      {
         /* Start Routine */
         GXt_boolean1 = AV5IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_MedicalImaging", out  GXt_boolean1) ;
         AV5IsAuthorized = GXt_boolean1;
         if ( ! AV5IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV62Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         divTablemain_Height = 493;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTablemain_Internalname, "Height", StringUtil.LTrim( StringUtil.Str( (decimal)(divTablemain_Height), 9, 0)), true);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_br_medicalimagingid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImagingID";
         ucDdo_br_medicalimagingid.SendProperty(context, "", false, Ddo_br_medicalimagingid_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimagingid_Titlecontrolidtoreplace);
         AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace = Ddo_br_medicalimagingid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace", AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace);
         edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Visible), 5, 0)), true);
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
         Ddo_br_medicalimaging_id_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_ID";
         ucDdo_br_medicalimaging_id.SendProperty(context, "", false, Ddo_br_medicalimaging_id_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_id_Titlecontrolidtoreplace);
         AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace = Ddo_br_medicalimaging_id_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace", AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_idtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicalimaging_idtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_idtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicalimaging_imagename_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_ImageName";
         ucDdo_br_medicalimaging_imagename.SendProperty(context, "", false, Ddo_br_medicalimaging_imagename_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_imagename_Titlecontrolidtoreplace);
         AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace = Ddo_br_medicalimaging_imagename_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace", AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_imagenametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicalimaging_imagenametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_imagenametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicalimaging_imagename_code_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_ImageName_Code";
         ucDdo_br_medicalimaging_imagename_code.SendProperty(context, "", false, Ddo_br_medicalimaging_imagename_code_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_imagename_code_Titlecontrolidtoreplace);
         AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace = Ddo_br_medicalimaging_imagename_code_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace", AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_imagename_codetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicalimaging_imagename_codetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_imagename_codetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicalimaging_imagedate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_ImageDate";
         ucDdo_br_medicalimaging_imagedate.SendProperty(context, "", false, Ddo_br_medicalimaging_imagedate_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_imagedate_Titlecontrolidtoreplace);
         AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace = Ddo_br_medicalimaging_imagedate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace", AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_imagedatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicalimaging_imagedatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_imagedatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicalimaging_imagehosp_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_ImageHosp";
         ucDdo_br_medicalimaging_imagehosp.SendProperty(context, "", false, Ddo_br_medicalimaging_imagehosp_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_imagehosp_Titlecontrolidtoreplace);
         AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace = Ddo_br_medicalimaging_imagehosp_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace", AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_imagehosptitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicalimaging_imagehosptitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_imagehosptitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicalimaging_imagehosp_code_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_ImageHosp_Code";
         ucDdo_br_medicalimaging_imagehosp_code.SendProperty(context, "", false, Ddo_br_medicalimaging_imagehosp_code_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_imagehosp_code_Titlecontrolidtoreplace);
         AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace = Ddo_br_medicalimaging_imagehosp_code_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace", AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_imagehosp_codetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicalimaging_imagehosp_codetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_imagehosp_codetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicalimaging_imageage_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_ImageAge";
         ucDdo_br_medicalimaging_imageage.SendProperty(context, "", false, Ddo_br_medicalimaging_imageage_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_imageage_Titlecontrolidtoreplace);
         AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace = Ddo_br_medicalimaging_imageage_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace", AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_imageagetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicalimaging_imageagetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_imageagetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicalimaging_imageloc_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_ImageLoc";
         ucDdo_br_medicalimaging_imageloc.SendProperty(context, "", false, Ddo_br_medicalimaging_imageloc_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_imageloc_Titlecontrolidtoreplace);
         AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace = Ddo_br_medicalimaging_imageloc_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace", AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_imageloctitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicalimaging_imageloctitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_imageloctitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicalimaging_imageloc_code_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_ImageLoc_Code";
         ucDdo_br_medicalimaging_imageloc_code.SendProperty(context, "", false, Ddo_br_medicalimaging_imageloc_code_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_imageloc_code_Titlecontrolidtoreplace);
         AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace = Ddo_br_medicalimaging_imageloc_code_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace", AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_imageloc_codetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicalimaging_imageloc_codetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_imageloc_codetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicalimaging_imageorgan_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_ImageOrgan";
         ucDdo_br_medicalimaging_imageorgan.SendProperty(context, "", false, Ddo_br_medicalimaging_imageorgan_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_imageorgan_Titlecontrolidtoreplace);
         AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace = Ddo_br_medicalimaging_imageorgan_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace", AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_imageorgantitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicalimaging_imageorgantitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_imageorgantitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicalimaging_preimagediag_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_PreImageDiag";
         ucDdo_br_medicalimaging_preimagediag.SendProperty(context, "", false, Ddo_br_medicalimaging_preimagediag_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_preimagediag_Titlecontrolidtoreplace);
         AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace = Ddo_br_medicalimaging_preimagediag_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace", AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_preimagediagtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicalimaging_preimagediagtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_preimagediagtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicalimaging_imagedes_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_ImageDes";
         ucDdo_br_medicalimaging_imagedes.SendProperty(context, "", false, Ddo_br_medicalimaging_imagedes_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_imagedes_Titlecontrolidtoreplace);
         AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace = Ddo_br_medicalimaging_imagedes_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace", AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_imagedestitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicalimaging_imagedestitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_imagedestitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicalimaging_tumorsize_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_TumorSize";
         ucDdo_br_medicalimaging_tumorsize.SendProperty(context, "", false, Ddo_br_medicalimaging_tumorsize_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_tumorsize_Titlecontrolidtoreplace);
         AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace = Ddo_br_medicalimaging_tumorsize_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace", AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_tumorsizetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicalimaging_tumorsizetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_tumorsizetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicalimaging_imagehtml_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_ImageHtml";
         ucDdo_br_medicalimaging_imagehtml.SendProperty(context, "", false, Ddo_br_medicalimaging_imagehtml_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_imagehtml_Titlecontrolidtoreplace);
         AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace = Ddo_br_medicalimaging_imagehtml_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace", AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_imagehtmltitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicalimaging_imagehtmltitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_imagehtmltitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicalimaging_metastasesdx_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_MetastasesDX";
         ucDdo_br_medicalimaging_metastasesdx.SendProperty(context, "", false, Ddo_br_medicalimaging_metastasesdx_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_metastasesdx_Titlecontrolidtoreplace);
         AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace = Ddo_br_medicalimaging_metastasesdx_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace", AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_metastasesdxtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicalimaging_metastasesdxtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_metastasesdxtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicalimaging_metaloc_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_MetaLoc";
         ucDdo_br_medicalimaging_metaloc.SendProperty(context, "", false, Ddo_br_medicalimaging_metaloc_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_metaloc_Titlecontrolidtoreplace);
         AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace = Ddo_br_medicalimaging_metaloc_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace", AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_metaloctitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicalimaging_metaloctitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_metaloctitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicalimaging_metadate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_MetaDate";
         ucDdo_br_medicalimaging_metadate.SendProperty(context, "", false, Ddo_br_medicalimaging_metadate_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_metadate_Titlecontrolidtoreplace);
         AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace = Ddo_br_medicalimaging_metadate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace", AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_metadatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicalimaging_metadatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_metadatetitlecontrolidtoreplace_Visible), 5, 0)), true);
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV39DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV39DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E345L2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV13BR_MedicalImagingIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17BR_Information_PatientNoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19BR_MedicalImaging_IDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_MedicalImaging_ImageNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV48BR_MedicalImaging_ImageName_CodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV23BR_MedicalImaging_ImageDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV25BR_MedicalImaging_ImageHospTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV27BR_MedicalImaging_ImageAgeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV29BR_MedicalImaging_ImageLocTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV31BR_MedicalImaging_ImageOrganTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV33BR_MedicalImaging_PreImageDiagTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV35BR_MedicalImaging_ImageDesTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV37BR_MedicalImaging_TumorSizeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV46BR_MedicalImaging_ImageHtmlTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV54BR_MedicalImaging_MetastasesDXTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV56BR_MedicalImaging_MetaLocTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV58BR_MedicalImaging_MetaDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         edtBR_MedicalImagingID_Titleformat = 2;
         edtBR_MedicalImagingID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "影像学主键", AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImagingID_Internalname, "Title", edtBR_MedicalImagingID_Title, !bGXsfl_12_Refreshing);
         edtBR_EncounterID_Titleformat = 2;
         edtBR_EncounterID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊信息主键", AV16ddo_BR_EncounterIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Title", edtBR_EncounterID_Title, !bGXsfl_12_Refreshing);
         edtBR_Information_PatientNo_Titleformat = 2;
         edtBR_Information_PatientNo_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "患者编号", AV18ddo_BR_Information_PatientNoTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_PatientNo_Internalname, "Title", edtBR_Information_PatientNo_Title, !bGXsfl_12_Refreshing);
         edtBR_MedicalImaging_ID_Titleformat = 2;
         edtBR_MedicalImaging_ID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "项目序号", AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_ID_Internalname, "Title", edtBR_MedicalImaging_ID_Title, !bGXsfl_12_Refreshing);
         edtBR_MedicalImaging_ImageName_Titleformat = 2;
         edtBR_MedicalImaging_ImageName_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "影像名称", AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_ImageName_Internalname, "Title", edtBR_MedicalImaging_ImageName_Title, !bGXsfl_12_Refreshing);
         edtBR_MedicalImaging_ImageName_Code_Titleformat = 2;
         edtBR_MedicalImaging_ImageName_Code_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "影像名称code", AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_ImageName_Code_Internalname, "Title", edtBR_MedicalImaging_ImageName_Code_Title, !bGXsfl_12_Refreshing);
         edtBR_MedicalImaging_ImageDate_Titleformat = 2;
         edtBR_MedicalImaging_ImageDate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "检查日期", AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_ImageDate_Internalname, "Title", edtBR_MedicalImaging_ImageDate_Title, !bGXsfl_12_Refreshing);
         edtBR_MedicalImaging_ImageHosp_Titleformat = 2;
         edtBR_MedicalImaging_ImageHosp_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "行检医院", AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_ImageHosp_Internalname, "Title", edtBR_MedicalImaging_ImageHosp_Title, !bGXsfl_12_Refreshing);
         edtBR_MedicalImaging_ImageHosp_Code_Titleformat = 2;
         edtBR_MedicalImaging_ImageHosp_Code_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "行检医院code", AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_ImageHosp_Code_Internalname, "Title", edtBR_MedicalImaging_ImageHosp_Code_Title, !bGXsfl_12_Refreshing);
         edtBR_MedicalImaging_ImageAge_Titleformat = 2;
         edtBR_MedicalImaging_ImageAge_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "年龄", AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_ImageAge_Internalname, "Title", edtBR_MedicalImaging_ImageAge_Title, !bGXsfl_12_Refreshing);
         edtBR_MedicalImaging_ImageLoc_Titleformat = 2;
         edtBR_MedicalImaging_ImageLoc_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "检查部位(位置)", AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_ImageLoc_Internalname, "Title", edtBR_MedicalImaging_ImageLoc_Title, !bGXsfl_12_Refreshing);
         edtBR_MedicalImaging_ImageLoc_Code_Titleformat = 2;
         edtBR_MedicalImaging_ImageLoc_Code_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "检查部位(位置)code", AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_ImageLoc_Code_Internalname, "Title", edtBR_MedicalImaging_ImageLoc_Code_Title, !bGXsfl_12_Refreshing);
         edtBR_MedicalImaging_ImageOrgan_Titleformat = 2;
         edtBR_MedicalImaging_ImageOrgan_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "检查部位(器官)", AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_ImageOrgan_Internalname, "Title", edtBR_MedicalImaging_ImageOrgan_Title, !bGXsfl_12_Refreshing);
         edtBR_MedicalImaging_PreImageDiag_Titleformat = 2;
         edtBR_MedicalImaging_PreImageDiag_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "影像前诊断", AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_PreImageDiag_Internalname, "Title", edtBR_MedicalImaging_PreImageDiag_Title, !bGXsfl_12_Refreshing);
         edtBR_MedicalImaging_ImageDes_Titleformat = 2;
         edtBR_MedicalImaging_ImageDes_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "图像描述", AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_ImageDes_Internalname, "Title", edtBR_MedicalImaging_ImageDes_Title, !bGXsfl_12_Refreshing);
         edtBR_MedicalImaging_TumorSize_Titleformat = 2;
         edtBR_MedicalImaging_TumorSize_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "肿瘤大小", AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_TumorSize_Internalname, "Title", edtBR_MedicalImaging_TumorSize_Title, !bGXsfl_12_Refreshing);
         edtBR_MedicalImaging_ImageHtml_Titleformat = 2;
         edtBR_MedicalImaging_ImageHtml_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "上传图片", AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_ImageHtml_Internalname, "Title", edtBR_MedicalImaging_ImageHtml_Title, !bGXsfl_12_Refreshing);
         cmbBR_MedicalImaging_MetastasesDX_Titleformat = 2;
         cmbBR_MedicalImaging_MetastasesDX.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "是否有肿瘤转移", AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_MedicalImaging_MetastasesDX_Internalname, "Title", cmbBR_MedicalImaging_MetastasesDX.Title.Text, !bGXsfl_12_Refreshing);
         edtBR_MedicalImaging_MetaLoc_Titleformat = 2;
         edtBR_MedicalImaging_MetaLoc_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "肿瘤转移部位", AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_MetaLoc_Internalname, "Title", edtBR_MedicalImaging_MetaLoc_Title, !bGXsfl_12_Refreshing);
         edtBR_MedicalImaging_MetaDate_Titleformat = 2;
         edtBR_MedicalImaging_MetaDate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "肿瘤转移时间", AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_MetaDate_Internalname, "Title", edtBR_MedicalImaging_MetaDate_Title, !bGXsfl_12_Refreshing);
         AV41GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV41GridCurrentPage), 10, 0)));
         AV42GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42GridPageSize), 10, 0)));
         AV43GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV43GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_MedicalImagingIDTitleFilterData", AV13BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_MedicalImaging_IDTitleFilterData", AV19BR_MedicalImaging_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_MedicalImaging_ImageNameTitleFilterData", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_MedicalImaging_ImageName_CodeTitleFilterData", AV48BR_MedicalImaging_ImageName_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_MedicalImaging_ImageDateTitleFilterData", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_MedicalImaging_ImageHospTitleFilterData", AV25BR_MedicalImaging_ImageHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData", AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_MedicalImaging_ImageAgeTitleFilterData", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_MedicalImaging_ImageLocTitleFilterData", AV29BR_MedicalImaging_ImageLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData", AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_MedicalImaging_ImageOrganTitleFilterData", AV31BR_MedicalImaging_ImageOrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_MedicalImaging_PreImageDiagTitleFilterData", AV33BR_MedicalImaging_PreImageDiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35BR_MedicalImaging_ImageDesTitleFilterData", AV35BR_MedicalImaging_ImageDesTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_MedicalImaging_TumorSizeTitleFilterData", AV37BR_MedicalImaging_TumorSizeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_MedicalImaging_ImageHtmlTitleFilterData", AV46BR_MedicalImaging_ImageHtmlTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_MedicalImaging_MetastasesDXTitleFilterData", AV54BR_MedicalImaging_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56BR_MedicalImaging_MetaLocTitleFilterData", AV56BR_MedicalImaging_MetaLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_MedicalImaging_MetaDateTitleFilterData", AV58BR_MedicalImaging_MetaDateTitleFilterData);
      }

      protected void E115L2( )
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
            AV40PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV40PageToGo) ;
         }
      }

      protected void E125L2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E135L2( )
      {
         /* Ddo_br_medicalimagingid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimagingid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 1;
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
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimagingid_Sortedstatus = "DSC";
            ucDdo_br_medicalimagingid.SendProperty(context, "", false, Ddo_br_medicalimagingid_Internalname, "SortedStatus", Ddo_br_medicalimagingid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_MedicalImagingIDTitleFilterData", AV13BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_MedicalImaging_IDTitleFilterData", AV19BR_MedicalImaging_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_MedicalImaging_ImageNameTitleFilterData", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_MedicalImaging_ImageName_CodeTitleFilterData", AV48BR_MedicalImaging_ImageName_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_MedicalImaging_ImageDateTitleFilterData", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_MedicalImaging_ImageHospTitleFilterData", AV25BR_MedicalImaging_ImageHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData", AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_MedicalImaging_ImageAgeTitleFilterData", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_MedicalImaging_ImageLocTitleFilterData", AV29BR_MedicalImaging_ImageLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData", AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_MedicalImaging_ImageOrganTitleFilterData", AV31BR_MedicalImaging_ImageOrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_MedicalImaging_PreImageDiagTitleFilterData", AV33BR_MedicalImaging_PreImageDiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35BR_MedicalImaging_ImageDesTitleFilterData", AV35BR_MedicalImaging_ImageDesTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_MedicalImaging_TumorSizeTitleFilterData", AV37BR_MedicalImaging_TumorSizeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_MedicalImaging_ImageHtmlTitleFilterData", AV46BR_MedicalImaging_ImageHtmlTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_MedicalImaging_MetastasesDXTitleFilterData", AV54BR_MedicalImaging_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56BR_MedicalImaging_MetaLocTitleFilterData", AV56BR_MedicalImaging_MetaLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_MedicalImaging_MetaDateTitleFilterData", AV58BR_MedicalImaging_MetaDateTitleFilterData);
      }

      protected void E145L2( )
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
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_MedicalImagingIDTitleFilterData", AV13BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_MedicalImaging_IDTitleFilterData", AV19BR_MedicalImaging_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_MedicalImaging_ImageNameTitleFilterData", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_MedicalImaging_ImageName_CodeTitleFilterData", AV48BR_MedicalImaging_ImageName_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_MedicalImaging_ImageDateTitleFilterData", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_MedicalImaging_ImageHospTitleFilterData", AV25BR_MedicalImaging_ImageHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData", AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_MedicalImaging_ImageAgeTitleFilterData", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_MedicalImaging_ImageLocTitleFilterData", AV29BR_MedicalImaging_ImageLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData", AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_MedicalImaging_ImageOrganTitleFilterData", AV31BR_MedicalImaging_ImageOrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_MedicalImaging_PreImageDiagTitleFilterData", AV33BR_MedicalImaging_PreImageDiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35BR_MedicalImaging_ImageDesTitleFilterData", AV35BR_MedicalImaging_ImageDesTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_MedicalImaging_TumorSizeTitleFilterData", AV37BR_MedicalImaging_TumorSizeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_MedicalImaging_ImageHtmlTitleFilterData", AV46BR_MedicalImaging_ImageHtmlTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_MedicalImaging_MetastasesDXTitleFilterData", AV54BR_MedicalImaging_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56BR_MedicalImaging_MetaLocTitleFilterData", AV56BR_MedicalImaging_MetaLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_MedicalImaging_MetaDateTitleFilterData", AV58BR_MedicalImaging_MetaDateTitleFilterData);
      }

      protected void E155L2( )
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
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_MedicalImagingIDTitleFilterData", AV13BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_MedicalImaging_IDTitleFilterData", AV19BR_MedicalImaging_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_MedicalImaging_ImageNameTitleFilterData", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_MedicalImaging_ImageName_CodeTitleFilterData", AV48BR_MedicalImaging_ImageName_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_MedicalImaging_ImageDateTitleFilterData", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_MedicalImaging_ImageHospTitleFilterData", AV25BR_MedicalImaging_ImageHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData", AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_MedicalImaging_ImageAgeTitleFilterData", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_MedicalImaging_ImageLocTitleFilterData", AV29BR_MedicalImaging_ImageLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData", AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_MedicalImaging_ImageOrganTitleFilterData", AV31BR_MedicalImaging_ImageOrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_MedicalImaging_PreImageDiagTitleFilterData", AV33BR_MedicalImaging_PreImageDiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35BR_MedicalImaging_ImageDesTitleFilterData", AV35BR_MedicalImaging_ImageDesTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_MedicalImaging_TumorSizeTitleFilterData", AV37BR_MedicalImaging_TumorSizeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_MedicalImaging_ImageHtmlTitleFilterData", AV46BR_MedicalImaging_ImageHtmlTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_MedicalImaging_MetastasesDXTitleFilterData", AV54BR_MedicalImaging_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56BR_MedicalImaging_MetaLocTitleFilterData", AV56BR_MedicalImaging_MetaLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_MedicalImaging_MetaDateTitleFilterData", AV58BR_MedicalImaging_MetaDateTitleFilterData);
      }

      protected void E165L2( )
      {
         /* Ddo_br_medicalimaging_id_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_id_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_id_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_id.SendProperty(context, "", false, Ddo_br_medicalimaging_id_Internalname, "SortedStatus", Ddo_br_medicalimaging_id_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_id_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_id_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_id.SendProperty(context, "", false, Ddo_br_medicalimaging_id_Internalname, "SortedStatus", Ddo_br_medicalimaging_id_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_MedicalImagingIDTitleFilterData", AV13BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_MedicalImaging_IDTitleFilterData", AV19BR_MedicalImaging_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_MedicalImaging_ImageNameTitleFilterData", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_MedicalImaging_ImageName_CodeTitleFilterData", AV48BR_MedicalImaging_ImageName_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_MedicalImaging_ImageDateTitleFilterData", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_MedicalImaging_ImageHospTitleFilterData", AV25BR_MedicalImaging_ImageHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData", AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_MedicalImaging_ImageAgeTitleFilterData", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_MedicalImaging_ImageLocTitleFilterData", AV29BR_MedicalImaging_ImageLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData", AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_MedicalImaging_ImageOrganTitleFilterData", AV31BR_MedicalImaging_ImageOrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_MedicalImaging_PreImageDiagTitleFilterData", AV33BR_MedicalImaging_PreImageDiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35BR_MedicalImaging_ImageDesTitleFilterData", AV35BR_MedicalImaging_ImageDesTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_MedicalImaging_TumorSizeTitleFilterData", AV37BR_MedicalImaging_TumorSizeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_MedicalImaging_ImageHtmlTitleFilterData", AV46BR_MedicalImaging_ImageHtmlTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_MedicalImaging_MetastasesDXTitleFilterData", AV54BR_MedicalImaging_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56BR_MedicalImaging_MetaLocTitleFilterData", AV56BR_MedicalImaging_MetaLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_MedicalImaging_MetaDateTitleFilterData", AV58BR_MedicalImaging_MetaDateTitleFilterData);
      }

      protected void E175L2( )
      {
         /* Ddo_br_medicalimaging_imagename_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_imagename_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_imagename_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_imagename.SendProperty(context, "", false, Ddo_br_medicalimaging_imagename_Internalname, "SortedStatus", Ddo_br_medicalimaging_imagename_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_imagename_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_imagename_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_imagename.SendProperty(context, "", false, Ddo_br_medicalimaging_imagename_Internalname, "SortedStatus", Ddo_br_medicalimaging_imagename_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_MedicalImagingIDTitleFilterData", AV13BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_MedicalImaging_IDTitleFilterData", AV19BR_MedicalImaging_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_MedicalImaging_ImageNameTitleFilterData", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_MedicalImaging_ImageName_CodeTitleFilterData", AV48BR_MedicalImaging_ImageName_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_MedicalImaging_ImageDateTitleFilterData", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_MedicalImaging_ImageHospTitleFilterData", AV25BR_MedicalImaging_ImageHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData", AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_MedicalImaging_ImageAgeTitleFilterData", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_MedicalImaging_ImageLocTitleFilterData", AV29BR_MedicalImaging_ImageLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData", AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_MedicalImaging_ImageOrganTitleFilterData", AV31BR_MedicalImaging_ImageOrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_MedicalImaging_PreImageDiagTitleFilterData", AV33BR_MedicalImaging_PreImageDiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35BR_MedicalImaging_ImageDesTitleFilterData", AV35BR_MedicalImaging_ImageDesTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_MedicalImaging_TumorSizeTitleFilterData", AV37BR_MedicalImaging_TumorSizeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_MedicalImaging_ImageHtmlTitleFilterData", AV46BR_MedicalImaging_ImageHtmlTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_MedicalImaging_MetastasesDXTitleFilterData", AV54BR_MedicalImaging_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56BR_MedicalImaging_MetaLocTitleFilterData", AV56BR_MedicalImaging_MetaLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_MedicalImaging_MetaDateTitleFilterData", AV58BR_MedicalImaging_MetaDateTitleFilterData);
      }

      protected void E185L2( )
      {
         /* Ddo_br_medicalimaging_imagename_code_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_imagename_code_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_imagename_code_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_imagename_code.SendProperty(context, "", false, Ddo_br_medicalimaging_imagename_code_Internalname, "SortedStatus", Ddo_br_medicalimaging_imagename_code_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_imagename_code_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_imagename_code_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_imagename_code.SendProperty(context, "", false, Ddo_br_medicalimaging_imagename_code_Internalname, "SortedStatus", Ddo_br_medicalimaging_imagename_code_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_MedicalImagingIDTitleFilterData", AV13BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_MedicalImaging_IDTitleFilterData", AV19BR_MedicalImaging_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_MedicalImaging_ImageNameTitleFilterData", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_MedicalImaging_ImageName_CodeTitleFilterData", AV48BR_MedicalImaging_ImageName_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_MedicalImaging_ImageDateTitleFilterData", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_MedicalImaging_ImageHospTitleFilterData", AV25BR_MedicalImaging_ImageHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData", AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_MedicalImaging_ImageAgeTitleFilterData", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_MedicalImaging_ImageLocTitleFilterData", AV29BR_MedicalImaging_ImageLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData", AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_MedicalImaging_ImageOrganTitleFilterData", AV31BR_MedicalImaging_ImageOrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_MedicalImaging_PreImageDiagTitleFilterData", AV33BR_MedicalImaging_PreImageDiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35BR_MedicalImaging_ImageDesTitleFilterData", AV35BR_MedicalImaging_ImageDesTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_MedicalImaging_TumorSizeTitleFilterData", AV37BR_MedicalImaging_TumorSizeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_MedicalImaging_ImageHtmlTitleFilterData", AV46BR_MedicalImaging_ImageHtmlTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_MedicalImaging_MetastasesDXTitleFilterData", AV54BR_MedicalImaging_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56BR_MedicalImaging_MetaLocTitleFilterData", AV56BR_MedicalImaging_MetaLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_MedicalImaging_MetaDateTitleFilterData", AV58BR_MedicalImaging_MetaDateTitleFilterData);
      }

      protected void E195L2( )
      {
         /* Ddo_br_medicalimaging_imagedate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_imagedate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_imagedate_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_imagedate.SendProperty(context, "", false, Ddo_br_medicalimaging_imagedate_Internalname, "SortedStatus", Ddo_br_medicalimaging_imagedate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_imagedate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_imagedate_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_imagedate.SendProperty(context, "", false, Ddo_br_medicalimaging_imagedate_Internalname, "SortedStatus", Ddo_br_medicalimaging_imagedate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_MedicalImagingIDTitleFilterData", AV13BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_MedicalImaging_IDTitleFilterData", AV19BR_MedicalImaging_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_MedicalImaging_ImageNameTitleFilterData", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_MedicalImaging_ImageName_CodeTitleFilterData", AV48BR_MedicalImaging_ImageName_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_MedicalImaging_ImageDateTitleFilterData", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_MedicalImaging_ImageHospTitleFilterData", AV25BR_MedicalImaging_ImageHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData", AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_MedicalImaging_ImageAgeTitleFilterData", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_MedicalImaging_ImageLocTitleFilterData", AV29BR_MedicalImaging_ImageLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData", AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_MedicalImaging_ImageOrganTitleFilterData", AV31BR_MedicalImaging_ImageOrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_MedicalImaging_PreImageDiagTitleFilterData", AV33BR_MedicalImaging_PreImageDiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35BR_MedicalImaging_ImageDesTitleFilterData", AV35BR_MedicalImaging_ImageDesTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_MedicalImaging_TumorSizeTitleFilterData", AV37BR_MedicalImaging_TumorSizeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_MedicalImaging_ImageHtmlTitleFilterData", AV46BR_MedicalImaging_ImageHtmlTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_MedicalImaging_MetastasesDXTitleFilterData", AV54BR_MedicalImaging_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56BR_MedicalImaging_MetaLocTitleFilterData", AV56BR_MedicalImaging_MetaLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_MedicalImaging_MetaDateTitleFilterData", AV58BR_MedicalImaging_MetaDateTitleFilterData);
      }

      protected void E205L2( )
      {
         /* Ddo_br_medicalimaging_imagehosp_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_imagehosp_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_imagehosp_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_imagehosp.SendProperty(context, "", false, Ddo_br_medicalimaging_imagehosp_Internalname, "SortedStatus", Ddo_br_medicalimaging_imagehosp_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_imagehosp_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_imagehosp_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_imagehosp.SendProperty(context, "", false, Ddo_br_medicalimaging_imagehosp_Internalname, "SortedStatus", Ddo_br_medicalimaging_imagehosp_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_MedicalImagingIDTitleFilterData", AV13BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_MedicalImaging_IDTitleFilterData", AV19BR_MedicalImaging_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_MedicalImaging_ImageNameTitleFilterData", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_MedicalImaging_ImageName_CodeTitleFilterData", AV48BR_MedicalImaging_ImageName_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_MedicalImaging_ImageDateTitleFilterData", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_MedicalImaging_ImageHospTitleFilterData", AV25BR_MedicalImaging_ImageHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData", AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_MedicalImaging_ImageAgeTitleFilterData", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_MedicalImaging_ImageLocTitleFilterData", AV29BR_MedicalImaging_ImageLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData", AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_MedicalImaging_ImageOrganTitleFilterData", AV31BR_MedicalImaging_ImageOrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_MedicalImaging_PreImageDiagTitleFilterData", AV33BR_MedicalImaging_PreImageDiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35BR_MedicalImaging_ImageDesTitleFilterData", AV35BR_MedicalImaging_ImageDesTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_MedicalImaging_TumorSizeTitleFilterData", AV37BR_MedicalImaging_TumorSizeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_MedicalImaging_ImageHtmlTitleFilterData", AV46BR_MedicalImaging_ImageHtmlTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_MedicalImaging_MetastasesDXTitleFilterData", AV54BR_MedicalImaging_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56BR_MedicalImaging_MetaLocTitleFilterData", AV56BR_MedicalImaging_MetaLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_MedicalImaging_MetaDateTitleFilterData", AV58BR_MedicalImaging_MetaDateTitleFilterData);
      }

      protected void E215L2( )
      {
         /* Ddo_br_medicalimaging_imagehosp_code_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_imagehosp_code_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_imagehosp_code_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_imagehosp_code.SendProperty(context, "", false, Ddo_br_medicalimaging_imagehosp_code_Internalname, "SortedStatus", Ddo_br_medicalimaging_imagehosp_code_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_imagehosp_code_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_imagehosp_code_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_imagehosp_code.SendProperty(context, "", false, Ddo_br_medicalimaging_imagehosp_code_Internalname, "SortedStatus", Ddo_br_medicalimaging_imagehosp_code_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_MedicalImagingIDTitleFilterData", AV13BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_MedicalImaging_IDTitleFilterData", AV19BR_MedicalImaging_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_MedicalImaging_ImageNameTitleFilterData", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_MedicalImaging_ImageName_CodeTitleFilterData", AV48BR_MedicalImaging_ImageName_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_MedicalImaging_ImageDateTitleFilterData", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_MedicalImaging_ImageHospTitleFilterData", AV25BR_MedicalImaging_ImageHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData", AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_MedicalImaging_ImageAgeTitleFilterData", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_MedicalImaging_ImageLocTitleFilterData", AV29BR_MedicalImaging_ImageLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData", AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_MedicalImaging_ImageOrganTitleFilterData", AV31BR_MedicalImaging_ImageOrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_MedicalImaging_PreImageDiagTitleFilterData", AV33BR_MedicalImaging_PreImageDiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35BR_MedicalImaging_ImageDesTitleFilterData", AV35BR_MedicalImaging_ImageDesTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_MedicalImaging_TumorSizeTitleFilterData", AV37BR_MedicalImaging_TumorSizeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_MedicalImaging_ImageHtmlTitleFilterData", AV46BR_MedicalImaging_ImageHtmlTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_MedicalImaging_MetastasesDXTitleFilterData", AV54BR_MedicalImaging_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56BR_MedicalImaging_MetaLocTitleFilterData", AV56BR_MedicalImaging_MetaLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_MedicalImaging_MetaDateTitleFilterData", AV58BR_MedicalImaging_MetaDateTitleFilterData);
      }

      protected void E225L2( )
      {
         /* Ddo_br_medicalimaging_imageage_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_imageage_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 10;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_imageage_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_imageage.SendProperty(context, "", false, Ddo_br_medicalimaging_imageage_Internalname, "SortedStatus", Ddo_br_medicalimaging_imageage_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_imageage_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 10;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_imageage_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_imageage.SendProperty(context, "", false, Ddo_br_medicalimaging_imageage_Internalname, "SortedStatus", Ddo_br_medicalimaging_imageage_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_MedicalImagingIDTitleFilterData", AV13BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_MedicalImaging_IDTitleFilterData", AV19BR_MedicalImaging_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_MedicalImaging_ImageNameTitleFilterData", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_MedicalImaging_ImageName_CodeTitleFilterData", AV48BR_MedicalImaging_ImageName_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_MedicalImaging_ImageDateTitleFilterData", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_MedicalImaging_ImageHospTitleFilterData", AV25BR_MedicalImaging_ImageHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData", AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_MedicalImaging_ImageAgeTitleFilterData", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_MedicalImaging_ImageLocTitleFilterData", AV29BR_MedicalImaging_ImageLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData", AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_MedicalImaging_ImageOrganTitleFilterData", AV31BR_MedicalImaging_ImageOrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_MedicalImaging_PreImageDiagTitleFilterData", AV33BR_MedicalImaging_PreImageDiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35BR_MedicalImaging_ImageDesTitleFilterData", AV35BR_MedicalImaging_ImageDesTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_MedicalImaging_TumorSizeTitleFilterData", AV37BR_MedicalImaging_TumorSizeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_MedicalImaging_ImageHtmlTitleFilterData", AV46BR_MedicalImaging_ImageHtmlTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_MedicalImaging_MetastasesDXTitleFilterData", AV54BR_MedicalImaging_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56BR_MedicalImaging_MetaLocTitleFilterData", AV56BR_MedicalImaging_MetaLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_MedicalImaging_MetaDateTitleFilterData", AV58BR_MedicalImaging_MetaDateTitleFilterData);
      }

      protected void E235L2( )
      {
         /* Ddo_br_medicalimaging_imageloc_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_imageloc_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_imageloc_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_imageloc.SendProperty(context, "", false, Ddo_br_medicalimaging_imageloc_Internalname, "SortedStatus", Ddo_br_medicalimaging_imageloc_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_imageloc_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_imageloc_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_imageloc.SendProperty(context, "", false, Ddo_br_medicalimaging_imageloc_Internalname, "SortedStatus", Ddo_br_medicalimaging_imageloc_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_MedicalImagingIDTitleFilterData", AV13BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_MedicalImaging_IDTitleFilterData", AV19BR_MedicalImaging_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_MedicalImaging_ImageNameTitleFilterData", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_MedicalImaging_ImageName_CodeTitleFilterData", AV48BR_MedicalImaging_ImageName_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_MedicalImaging_ImageDateTitleFilterData", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_MedicalImaging_ImageHospTitleFilterData", AV25BR_MedicalImaging_ImageHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData", AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_MedicalImaging_ImageAgeTitleFilterData", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_MedicalImaging_ImageLocTitleFilterData", AV29BR_MedicalImaging_ImageLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData", AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_MedicalImaging_ImageOrganTitleFilterData", AV31BR_MedicalImaging_ImageOrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_MedicalImaging_PreImageDiagTitleFilterData", AV33BR_MedicalImaging_PreImageDiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35BR_MedicalImaging_ImageDesTitleFilterData", AV35BR_MedicalImaging_ImageDesTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_MedicalImaging_TumorSizeTitleFilterData", AV37BR_MedicalImaging_TumorSizeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_MedicalImaging_ImageHtmlTitleFilterData", AV46BR_MedicalImaging_ImageHtmlTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_MedicalImaging_MetastasesDXTitleFilterData", AV54BR_MedicalImaging_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56BR_MedicalImaging_MetaLocTitleFilterData", AV56BR_MedicalImaging_MetaLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_MedicalImaging_MetaDateTitleFilterData", AV58BR_MedicalImaging_MetaDateTitleFilterData);
      }

      protected void E245L2( )
      {
         /* Ddo_br_medicalimaging_imageloc_code_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_imageloc_code_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_imageloc_code_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_imageloc_code.SendProperty(context, "", false, Ddo_br_medicalimaging_imageloc_code_Internalname, "SortedStatus", Ddo_br_medicalimaging_imageloc_code_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_imageloc_code_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_imageloc_code_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_imageloc_code.SendProperty(context, "", false, Ddo_br_medicalimaging_imageloc_code_Internalname, "SortedStatus", Ddo_br_medicalimaging_imageloc_code_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_MedicalImagingIDTitleFilterData", AV13BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_MedicalImaging_IDTitleFilterData", AV19BR_MedicalImaging_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_MedicalImaging_ImageNameTitleFilterData", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_MedicalImaging_ImageName_CodeTitleFilterData", AV48BR_MedicalImaging_ImageName_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_MedicalImaging_ImageDateTitleFilterData", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_MedicalImaging_ImageHospTitleFilterData", AV25BR_MedicalImaging_ImageHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData", AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_MedicalImaging_ImageAgeTitleFilterData", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_MedicalImaging_ImageLocTitleFilterData", AV29BR_MedicalImaging_ImageLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData", AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_MedicalImaging_ImageOrganTitleFilterData", AV31BR_MedicalImaging_ImageOrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_MedicalImaging_PreImageDiagTitleFilterData", AV33BR_MedicalImaging_PreImageDiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35BR_MedicalImaging_ImageDesTitleFilterData", AV35BR_MedicalImaging_ImageDesTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_MedicalImaging_TumorSizeTitleFilterData", AV37BR_MedicalImaging_TumorSizeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_MedicalImaging_ImageHtmlTitleFilterData", AV46BR_MedicalImaging_ImageHtmlTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_MedicalImaging_MetastasesDXTitleFilterData", AV54BR_MedicalImaging_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56BR_MedicalImaging_MetaLocTitleFilterData", AV56BR_MedicalImaging_MetaLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_MedicalImaging_MetaDateTitleFilterData", AV58BR_MedicalImaging_MetaDateTitleFilterData);
      }

      protected void E255L2( )
      {
         /* Ddo_br_medicalimaging_imageorgan_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_imageorgan_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 13;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_imageorgan_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_imageorgan.SendProperty(context, "", false, Ddo_br_medicalimaging_imageorgan_Internalname, "SortedStatus", Ddo_br_medicalimaging_imageorgan_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_imageorgan_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 13;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_imageorgan_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_imageorgan.SendProperty(context, "", false, Ddo_br_medicalimaging_imageorgan_Internalname, "SortedStatus", Ddo_br_medicalimaging_imageorgan_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_MedicalImagingIDTitleFilterData", AV13BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_MedicalImaging_IDTitleFilterData", AV19BR_MedicalImaging_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_MedicalImaging_ImageNameTitleFilterData", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_MedicalImaging_ImageName_CodeTitleFilterData", AV48BR_MedicalImaging_ImageName_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_MedicalImaging_ImageDateTitleFilterData", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_MedicalImaging_ImageHospTitleFilterData", AV25BR_MedicalImaging_ImageHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData", AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_MedicalImaging_ImageAgeTitleFilterData", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_MedicalImaging_ImageLocTitleFilterData", AV29BR_MedicalImaging_ImageLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData", AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_MedicalImaging_ImageOrganTitleFilterData", AV31BR_MedicalImaging_ImageOrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_MedicalImaging_PreImageDiagTitleFilterData", AV33BR_MedicalImaging_PreImageDiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35BR_MedicalImaging_ImageDesTitleFilterData", AV35BR_MedicalImaging_ImageDesTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_MedicalImaging_TumorSizeTitleFilterData", AV37BR_MedicalImaging_TumorSizeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_MedicalImaging_ImageHtmlTitleFilterData", AV46BR_MedicalImaging_ImageHtmlTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_MedicalImaging_MetastasesDXTitleFilterData", AV54BR_MedicalImaging_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56BR_MedicalImaging_MetaLocTitleFilterData", AV56BR_MedicalImaging_MetaLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_MedicalImaging_MetaDateTitleFilterData", AV58BR_MedicalImaging_MetaDateTitleFilterData);
      }

      protected void E265L2( )
      {
         /* Ddo_br_medicalimaging_preimagediag_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_preimagediag_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 14;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_preimagediag_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_preimagediag.SendProperty(context, "", false, Ddo_br_medicalimaging_preimagediag_Internalname, "SortedStatus", Ddo_br_medicalimaging_preimagediag_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_preimagediag_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 14;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_preimagediag_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_preimagediag.SendProperty(context, "", false, Ddo_br_medicalimaging_preimagediag_Internalname, "SortedStatus", Ddo_br_medicalimaging_preimagediag_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_MedicalImagingIDTitleFilterData", AV13BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_MedicalImaging_IDTitleFilterData", AV19BR_MedicalImaging_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_MedicalImaging_ImageNameTitleFilterData", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_MedicalImaging_ImageName_CodeTitleFilterData", AV48BR_MedicalImaging_ImageName_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_MedicalImaging_ImageDateTitleFilterData", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_MedicalImaging_ImageHospTitleFilterData", AV25BR_MedicalImaging_ImageHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData", AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_MedicalImaging_ImageAgeTitleFilterData", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_MedicalImaging_ImageLocTitleFilterData", AV29BR_MedicalImaging_ImageLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData", AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_MedicalImaging_ImageOrganTitleFilterData", AV31BR_MedicalImaging_ImageOrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_MedicalImaging_PreImageDiagTitleFilterData", AV33BR_MedicalImaging_PreImageDiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35BR_MedicalImaging_ImageDesTitleFilterData", AV35BR_MedicalImaging_ImageDesTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_MedicalImaging_TumorSizeTitleFilterData", AV37BR_MedicalImaging_TumorSizeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_MedicalImaging_ImageHtmlTitleFilterData", AV46BR_MedicalImaging_ImageHtmlTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_MedicalImaging_MetastasesDXTitleFilterData", AV54BR_MedicalImaging_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56BR_MedicalImaging_MetaLocTitleFilterData", AV56BR_MedicalImaging_MetaLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_MedicalImaging_MetaDateTitleFilterData", AV58BR_MedicalImaging_MetaDateTitleFilterData);
      }

      protected void E275L2( )
      {
         /* Ddo_br_medicalimaging_imagedes_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_imagedes_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 15;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_imagedes_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_imagedes.SendProperty(context, "", false, Ddo_br_medicalimaging_imagedes_Internalname, "SortedStatus", Ddo_br_medicalimaging_imagedes_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_imagedes_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 15;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_imagedes_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_imagedes.SendProperty(context, "", false, Ddo_br_medicalimaging_imagedes_Internalname, "SortedStatus", Ddo_br_medicalimaging_imagedes_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_MedicalImagingIDTitleFilterData", AV13BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_MedicalImaging_IDTitleFilterData", AV19BR_MedicalImaging_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_MedicalImaging_ImageNameTitleFilterData", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_MedicalImaging_ImageName_CodeTitleFilterData", AV48BR_MedicalImaging_ImageName_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_MedicalImaging_ImageDateTitleFilterData", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_MedicalImaging_ImageHospTitleFilterData", AV25BR_MedicalImaging_ImageHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData", AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_MedicalImaging_ImageAgeTitleFilterData", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_MedicalImaging_ImageLocTitleFilterData", AV29BR_MedicalImaging_ImageLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData", AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_MedicalImaging_ImageOrganTitleFilterData", AV31BR_MedicalImaging_ImageOrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_MedicalImaging_PreImageDiagTitleFilterData", AV33BR_MedicalImaging_PreImageDiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35BR_MedicalImaging_ImageDesTitleFilterData", AV35BR_MedicalImaging_ImageDesTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_MedicalImaging_TumorSizeTitleFilterData", AV37BR_MedicalImaging_TumorSizeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_MedicalImaging_ImageHtmlTitleFilterData", AV46BR_MedicalImaging_ImageHtmlTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_MedicalImaging_MetastasesDXTitleFilterData", AV54BR_MedicalImaging_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56BR_MedicalImaging_MetaLocTitleFilterData", AV56BR_MedicalImaging_MetaLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_MedicalImaging_MetaDateTitleFilterData", AV58BR_MedicalImaging_MetaDateTitleFilterData);
      }

      protected void E285L2( )
      {
         /* Ddo_br_medicalimaging_tumorsize_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_tumorsize_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 16;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_tumorsize_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_tumorsize.SendProperty(context, "", false, Ddo_br_medicalimaging_tumorsize_Internalname, "SortedStatus", Ddo_br_medicalimaging_tumorsize_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_tumorsize_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 16;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_tumorsize_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_tumorsize.SendProperty(context, "", false, Ddo_br_medicalimaging_tumorsize_Internalname, "SortedStatus", Ddo_br_medicalimaging_tumorsize_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_MedicalImagingIDTitleFilterData", AV13BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_MedicalImaging_IDTitleFilterData", AV19BR_MedicalImaging_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_MedicalImaging_ImageNameTitleFilterData", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_MedicalImaging_ImageName_CodeTitleFilterData", AV48BR_MedicalImaging_ImageName_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_MedicalImaging_ImageDateTitleFilterData", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_MedicalImaging_ImageHospTitleFilterData", AV25BR_MedicalImaging_ImageHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData", AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_MedicalImaging_ImageAgeTitleFilterData", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_MedicalImaging_ImageLocTitleFilterData", AV29BR_MedicalImaging_ImageLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData", AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_MedicalImaging_ImageOrganTitleFilterData", AV31BR_MedicalImaging_ImageOrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_MedicalImaging_PreImageDiagTitleFilterData", AV33BR_MedicalImaging_PreImageDiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35BR_MedicalImaging_ImageDesTitleFilterData", AV35BR_MedicalImaging_ImageDesTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_MedicalImaging_TumorSizeTitleFilterData", AV37BR_MedicalImaging_TumorSizeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_MedicalImaging_ImageHtmlTitleFilterData", AV46BR_MedicalImaging_ImageHtmlTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_MedicalImaging_MetastasesDXTitleFilterData", AV54BR_MedicalImaging_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56BR_MedicalImaging_MetaLocTitleFilterData", AV56BR_MedicalImaging_MetaLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_MedicalImaging_MetaDateTitleFilterData", AV58BR_MedicalImaging_MetaDateTitleFilterData);
      }

      protected void E295L2( )
      {
         /* Ddo_br_medicalimaging_imagehtml_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_imagehtml_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 17;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_imagehtml_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_imagehtml.SendProperty(context, "", false, Ddo_br_medicalimaging_imagehtml_Internalname, "SortedStatus", Ddo_br_medicalimaging_imagehtml_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_imagehtml_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 17;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_imagehtml_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_imagehtml.SendProperty(context, "", false, Ddo_br_medicalimaging_imagehtml_Internalname, "SortedStatus", Ddo_br_medicalimaging_imagehtml_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_MedicalImagingIDTitleFilterData", AV13BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_MedicalImaging_IDTitleFilterData", AV19BR_MedicalImaging_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_MedicalImaging_ImageNameTitleFilterData", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_MedicalImaging_ImageName_CodeTitleFilterData", AV48BR_MedicalImaging_ImageName_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_MedicalImaging_ImageDateTitleFilterData", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_MedicalImaging_ImageHospTitleFilterData", AV25BR_MedicalImaging_ImageHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData", AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_MedicalImaging_ImageAgeTitleFilterData", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_MedicalImaging_ImageLocTitleFilterData", AV29BR_MedicalImaging_ImageLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData", AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_MedicalImaging_ImageOrganTitleFilterData", AV31BR_MedicalImaging_ImageOrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_MedicalImaging_PreImageDiagTitleFilterData", AV33BR_MedicalImaging_PreImageDiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35BR_MedicalImaging_ImageDesTitleFilterData", AV35BR_MedicalImaging_ImageDesTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_MedicalImaging_TumorSizeTitleFilterData", AV37BR_MedicalImaging_TumorSizeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_MedicalImaging_ImageHtmlTitleFilterData", AV46BR_MedicalImaging_ImageHtmlTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_MedicalImaging_MetastasesDXTitleFilterData", AV54BR_MedicalImaging_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56BR_MedicalImaging_MetaLocTitleFilterData", AV56BR_MedicalImaging_MetaLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_MedicalImaging_MetaDateTitleFilterData", AV58BR_MedicalImaging_MetaDateTitleFilterData);
      }

      protected void E305L2( )
      {
         /* Ddo_br_medicalimaging_metastasesdx_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_metastasesdx_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 18;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_metastasesdx_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_metastasesdx.SendProperty(context, "", false, Ddo_br_medicalimaging_metastasesdx_Internalname, "SortedStatus", Ddo_br_medicalimaging_metastasesdx_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_metastasesdx_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 18;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_metastasesdx_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_metastasesdx.SendProperty(context, "", false, Ddo_br_medicalimaging_metastasesdx_Internalname, "SortedStatus", Ddo_br_medicalimaging_metastasesdx_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_MedicalImagingIDTitleFilterData", AV13BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_MedicalImaging_IDTitleFilterData", AV19BR_MedicalImaging_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_MedicalImaging_ImageNameTitleFilterData", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_MedicalImaging_ImageName_CodeTitleFilterData", AV48BR_MedicalImaging_ImageName_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_MedicalImaging_ImageDateTitleFilterData", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_MedicalImaging_ImageHospTitleFilterData", AV25BR_MedicalImaging_ImageHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData", AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_MedicalImaging_ImageAgeTitleFilterData", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_MedicalImaging_ImageLocTitleFilterData", AV29BR_MedicalImaging_ImageLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData", AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_MedicalImaging_ImageOrganTitleFilterData", AV31BR_MedicalImaging_ImageOrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_MedicalImaging_PreImageDiagTitleFilterData", AV33BR_MedicalImaging_PreImageDiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35BR_MedicalImaging_ImageDesTitleFilterData", AV35BR_MedicalImaging_ImageDesTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_MedicalImaging_TumorSizeTitleFilterData", AV37BR_MedicalImaging_TumorSizeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_MedicalImaging_ImageHtmlTitleFilterData", AV46BR_MedicalImaging_ImageHtmlTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_MedicalImaging_MetastasesDXTitleFilterData", AV54BR_MedicalImaging_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56BR_MedicalImaging_MetaLocTitleFilterData", AV56BR_MedicalImaging_MetaLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_MedicalImaging_MetaDateTitleFilterData", AV58BR_MedicalImaging_MetaDateTitleFilterData);
      }

      protected void E315L2( )
      {
         /* Ddo_br_medicalimaging_metaloc_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_metaloc_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 19;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_metaloc_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_metaloc.SendProperty(context, "", false, Ddo_br_medicalimaging_metaloc_Internalname, "SortedStatus", Ddo_br_medicalimaging_metaloc_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_metaloc_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 19;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_metaloc_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_metaloc.SendProperty(context, "", false, Ddo_br_medicalimaging_metaloc_Internalname, "SortedStatus", Ddo_br_medicalimaging_metaloc_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_MedicalImagingIDTitleFilterData", AV13BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_MedicalImaging_IDTitleFilterData", AV19BR_MedicalImaging_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_MedicalImaging_ImageNameTitleFilterData", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_MedicalImaging_ImageName_CodeTitleFilterData", AV48BR_MedicalImaging_ImageName_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_MedicalImaging_ImageDateTitleFilterData", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_MedicalImaging_ImageHospTitleFilterData", AV25BR_MedicalImaging_ImageHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData", AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_MedicalImaging_ImageAgeTitleFilterData", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_MedicalImaging_ImageLocTitleFilterData", AV29BR_MedicalImaging_ImageLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData", AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_MedicalImaging_ImageOrganTitleFilterData", AV31BR_MedicalImaging_ImageOrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_MedicalImaging_PreImageDiagTitleFilterData", AV33BR_MedicalImaging_PreImageDiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35BR_MedicalImaging_ImageDesTitleFilterData", AV35BR_MedicalImaging_ImageDesTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_MedicalImaging_TumorSizeTitleFilterData", AV37BR_MedicalImaging_TumorSizeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_MedicalImaging_ImageHtmlTitleFilterData", AV46BR_MedicalImaging_ImageHtmlTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_MedicalImaging_MetastasesDXTitleFilterData", AV54BR_MedicalImaging_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56BR_MedicalImaging_MetaLocTitleFilterData", AV56BR_MedicalImaging_MetaLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_MedicalImaging_MetaDateTitleFilterData", AV58BR_MedicalImaging_MetaDateTitleFilterData);
      }

      protected void E325L2( )
      {
         /* Ddo_br_medicalimaging_metadate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_metadate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 20;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_metadate_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_metadate.SendProperty(context, "", false, Ddo_br_medicalimaging_metadate_Internalname, "SortedStatus", Ddo_br_medicalimaging_metadate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_metadate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 20;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicalimaging_metadate_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_metadate.SendProperty(context, "", false, Ddo_br_medicalimaging_metadate_Internalname, "SortedStatus", Ddo_br_medicalimaging_metadate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_MedicalImagingIDTitleFilterData", AV13BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Information_PatientNoTitleFilterData", AV17BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_MedicalImaging_IDTitleFilterData", AV19BR_MedicalImaging_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_MedicalImaging_ImageNameTitleFilterData", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_MedicalImaging_ImageName_CodeTitleFilterData", AV48BR_MedicalImaging_ImageName_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_MedicalImaging_ImageDateTitleFilterData", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_MedicalImaging_ImageHospTitleFilterData", AV25BR_MedicalImaging_ImageHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData", AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_MedicalImaging_ImageAgeTitleFilterData", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_MedicalImaging_ImageLocTitleFilterData", AV29BR_MedicalImaging_ImageLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData", AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_MedicalImaging_ImageOrganTitleFilterData", AV31BR_MedicalImaging_ImageOrganTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_MedicalImaging_PreImageDiagTitleFilterData", AV33BR_MedicalImaging_PreImageDiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV35BR_MedicalImaging_ImageDesTitleFilterData", AV35BR_MedicalImaging_ImageDesTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_MedicalImaging_TumorSizeTitleFilterData", AV37BR_MedicalImaging_TumorSizeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_MedicalImaging_ImageHtmlTitleFilterData", AV46BR_MedicalImaging_ImageHtmlTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_MedicalImaging_MetastasesDXTitleFilterData", AV54BR_MedicalImaging_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV56BR_MedicalImaging_MetaLocTitleFilterData", AV56BR_MedicalImaging_MetaLocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_MedicalImaging_MetaDateTitleFilterData", AV58BR_MedicalImaging_MetaDateTitleFilterData);
      }

      private void E355L2( )
      {
         /* Grid_Load Routine */
         AV44Select = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSelect_Internalname, AV44Select);
         AV63Select_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
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
         E365L2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E365L2( )
      {
         /* Enter Routine */
         AV8InOutBR_MedicalImagingID = A225BR_MedicalImagingID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_MedicalImagingID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_MedicalImagingID), 18, 0)));
         AV45InOutBR_MedicalImaging_ImageName = A228BR_MedicalImaging_ImageName;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45InOutBR_MedicalImaging_ImageName", AV45InOutBR_MedicalImaging_ImageName);
         context.setWebReturnParms(new Object[] {(long)AV8InOutBR_MedicalImagingID,(String)AV45InOutBR_MedicalImaging_ImageName});
         context.setWebReturnParmsMetadata(new Object[] {"AV8InOutBR_MedicalImagingID","AV45InOutBR_MedicalImaging_ImageName"});
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
         AV8InOutBR_MedicalImagingID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_MedicalImagingID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_MedicalImagingID), 18, 0)));
         AV45InOutBR_MedicalImaging_ImageName = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45InOutBR_MedicalImaging_ImageName", AV45InOutBR_MedicalImaging_ImageName);
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
         PA5L2( ) ;
         WS5L2( ) ;
         WE5L2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279435520", true);
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
         context.AddJavascriptSource("br_medicalimagingprompt.js", "?20202279435520", false);
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
         edtBR_MedicalImagingID_Internalname = "BR_MEDICALIMAGINGID_"+sGXsfl_12_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_12_idx;
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO_"+sGXsfl_12_idx;
         edtBR_MedicalImaging_ID_Internalname = "BR_MEDICALIMAGING_ID_"+sGXsfl_12_idx;
         edtBR_MedicalImaging_ImageName_Internalname = "BR_MEDICALIMAGING_IMAGENAME_"+sGXsfl_12_idx;
         edtBR_MedicalImaging_ImageName_Code_Internalname = "BR_MEDICALIMAGING_IMAGENAME_CODE_"+sGXsfl_12_idx;
         edtBR_MedicalImaging_ImageDate_Internalname = "BR_MEDICALIMAGING_IMAGEDATE_"+sGXsfl_12_idx;
         edtBR_MedicalImaging_ImageHosp_Internalname = "BR_MEDICALIMAGING_IMAGEHOSP_"+sGXsfl_12_idx;
         edtBR_MedicalImaging_ImageHosp_Code_Internalname = "BR_MEDICALIMAGING_IMAGEHOSP_CODE_"+sGXsfl_12_idx;
         edtBR_MedicalImaging_ImageAge_Internalname = "BR_MEDICALIMAGING_IMAGEAGE_"+sGXsfl_12_idx;
         edtBR_MedicalImaging_ImageLoc_Internalname = "BR_MEDICALIMAGING_IMAGELOC_"+sGXsfl_12_idx;
         edtBR_MedicalImaging_ImageLoc_Code_Internalname = "BR_MEDICALIMAGING_IMAGELOC_CODE_"+sGXsfl_12_idx;
         edtBR_MedicalImaging_ImageOrgan_Internalname = "BR_MEDICALIMAGING_IMAGEORGAN_"+sGXsfl_12_idx;
         edtBR_MedicalImaging_PreImageDiag_Internalname = "BR_MEDICALIMAGING_PREIMAGEDIAG_"+sGXsfl_12_idx;
         edtBR_MedicalImaging_ImageDes_Internalname = "BR_MEDICALIMAGING_IMAGEDES_"+sGXsfl_12_idx;
         edtBR_MedicalImaging_TumorSize_Internalname = "BR_MEDICALIMAGING_TUMORSIZE_"+sGXsfl_12_idx;
         edtBR_MedicalImaging_ImageHtml_Internalname = "BR_MEDICALIMAGING_IMAGEHTML_"+sGXsfl_12_idx;
         cmbBR_MedicalImaging_MetastasesDX_Internalname = "BR_MEDICALIMAGING_METASTASESDX_"+sGXsfl_12_idx;
         edtBR_MedicalImaging_MetaLoc_Internalname = "BR_MEDICALIMAGING_METALOC_"+sGXsfl_12_idx;
         edtBR_MedicalImaging_MetaDate_Internalname = "BR_MEDICALIMAGING_METADATE_"+sGXsfl_12_idx;
      }

      protected void SubsflControlProps_fel_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_fel_idx;
         edtBR_MedicalImagingID_Internalname = "BR_MEDICALIMAGINGID_"+sGXsfl_12_fel_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_12_fel_idx;
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO_"+sGXsfl_12_fel_idx;
         edtBR_MedicalImaging_ID_Internalname = "BR_MEDICALIMAGING_ID_"+sGXsfl_12_fel_idx;
         edtBR_MedicalImaging_ImageName_Internalname = "BR_MEDICALIMAGING_IMAGENAME_"+sGXsfl_12_fel_idx;
         edtBR_MedicalImaging_ImageName_Code_Internalname = "BR_MEDICALIMAGING_IMAGENAME_CODE_"+sGXsfl_12_fel_idx;
         edtBR_MedicalImaging_ImageDate_Internalname = "BR_MEDICALIMAGING_IMAGEDATE_"+sGXsfl_12_fel_idx;
         edtBR_MedicalImaging_ImageHosp_Internalname = "BR_MEDICALIMAGING_IMAGEHOSP_"+sGXsfl_12_fel_idx;
         edtBR_MedicalImaging_ImageHosp_Code_Internalname = "BR_MEDICALIMAGING_IMAGEHOSP_CODE_"+sGXsfl_12_fel_idx;
         edtBR_MedicalImaging_ImageAge_Internalname = "BR_MEDICALIMAGING_IMAGEAGE_"+sGXsfl_12_fel_idx;
         edtBR_MedicalImaging_ImageLoc_Internalname = "BR_MEDICALIMAGING_IMAGELOC_"+sGXsfl_12_fel_idx;
         edtBR_MedicalImaging_ImageLoc_Code_Internalname = "BR_MEDICALIMAGING_IMAGELOC_CODE_"+sGXsfl_12_fel_idx;
         edtBR_MedicalImaging_ImageOrgan_Internalname = "BR_MEDICALIMAGING_IMAGEORGAN_"+sGXsfl_12_fel_idx;
         edtBR_MedicalImaging_PreImageDiag_Internalname = "BR_MEDICALIMAGING_PREIMAGEDIAG_"+sGXsfl_12_fel_idx;
         edtBR_MedicalImaging_ImageDes_Internalname = "BR_MEDICALIMAGING_IMAGEDES_"+sGXsfl_12_fel_idx;
         edtBR_MedicalImaging_TumorSize_Internalname = "BR_MEDICALIMAGING_TUMORSIZE_"+sGXsfl_12_fel_idx;
         edtBR_MedicalImaging_ImageHtml_Internalname = "BR_MEDICALIMAGING_IMAGEHTML_"+sGXsfl_12_fel_idx;
         cmbBR_MedicalImaging_MetastasesDX_Internalname = "BR_MEDICALIMAGING_METASTASESDX_"+sGXsfl_12_fel_idx;
         edtBR_MedicalImaging_MetaLoc_Internalname = "BR_MEDICALIMAGING_METALOC_"+sGXsfl_12_fel_idx;
         edtBR_MedicalImaging_MetaDate_Internalname = "BR_MEDICALIMAGING_METADATE_"+sGXsfl_12_fel_idx;
      }

      protected void sendrow_122( )
      {
         SubsflControlProps_122( ) ;
         WB5L0( ) ;
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
            AV44Select_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV44Select))&&String.IsNullOrEmpty(StringUtil.RTrim( AV63Select_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV44Select)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV44Select)) ? AV63Select_GXI : context.PathToRelativeUrl( AV44Select));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSelect_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSelect_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSelect_Jsonclick,"'"+""+"'"+",false,"+"'"+"EENTER."+sGXsfl_12_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV44Select_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
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
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImaging_ID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A227BR_MedicalImaging_ID), 10, 0, ".", "")),context.localUtil.Format( (decimal)(A227BR_MedicalImaging_ID), "ZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImaging_ID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImaging_ImageName_Internalname,(String)A228BR_MedicalImaging_ImageName,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImaging_ImageName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImaging_ImageName_Code_Internalname,(String)A484BR_MedicalImaging_ImageName_Code,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImaging_ImageName_Code_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImaging_ImageDate_Internalname,context.localUtil.Format(A229BR_MedicalImaging_ImageDate, "9999/99/99"),context.localUtil.Format( A229BR_MedicalImaging_ImageDate, "9999/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImaging_ImageDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Date",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImaging_ImageHosp_Internalname,(String)A230BR_MedicalImaging_ImageHosp,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImaging_ImageHosp_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImaging_ImageHosp_Code_Internalname,(String)A485BR_MedicalImaging_ImageHosp_Code,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImaging_ImageHosp_Code_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImaging_ImageAge_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A231BR_MedicalImaging_ImageAge), 3, 0, ".", "")),context.localUtil.Format( (decimal)(A231BR_MedicalImaging_ImageAge), "ZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImaging_ImageAge_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)3,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImaging_ImageLoc_Internalname,(String)A232BR_MedicalImaging_ImageLoc,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImaging_ImageLoc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)5000,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImaging_ImageLoc_Code_Internalname,(String)A486BR_MedicalImaging_ImageLoc_Code,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImaging_ImageLoc_Code_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImaging_ImageOrgan_Internalname,(String)A233BR_MedicalImaging_ImageOrgan,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImaging_ImageOrgan_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)5000,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImaging_PreImageDiag_Internalname,(String)A234BR_MedicalImaging_PreImageDiag,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImaging_PreImageDiag_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4000,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImaging_ImageDes_Internalname,(String)A235BR_MedicalImaging_ImageDes,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImaging_ImageDes_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9999,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImaging_TumorSize_Internalname,(String)A236BR_MedicalImaging_TumorSize,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImaging_TumorSize_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImaging_ImageHtml_Internalname,(String)A334BR_MedicalImaging_ImageHtml,(String)A334BR_MedicalImaging_ImageHtml,(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImaging_ImageHtml_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(int)2097152,(short)0,(short)1,(short)12,(short)1,(short)0,(short)-1,(bool)true,(String)"GeneXus\\Html",(String)"left",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbBR_MedicalImaging_MetastasesDX.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "BR_MEDICALIMAGING_METASTASESDX_" + sGXsfl_12_idx;
               cmbBR_MedicalImaging_MetastasesDX.Name = GXCCtl;
               cmbBR_MedicalImaging_MetastasesDX.WebTags = "";
               cmbBR_MedicalImaging_MetastasesDX.addItem("", "(请选择)", 0);
               cmbBR_MedicalImaging_MetastasesDX.addItem("否", "否", 0);
               cmbBR_MedicalImaging_MetastasesDX.addItem("是", "是", 0);
               cmbBR_MedicalImaging_MetastasesDX.addItem("不详", "不详", 0);
               if ( cmbBR_MedicalImaging_MetastasesDX.ItemCount > 0 )
               {
                  A514BR_MedicalImaging_MetastasesDX = cmbBR_MedicalImaging_MetastasesDX.getValidValue(A514BR_MedicalImaging_MetastasesDX);
                  n514BR_MedicalImaging_MetastasesDX = false;
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbBR_MedicalImaging_MetastasesDX,(String)cmbBR_MedicalImaging_MetastasesDX_Internalname,StringUtil.RTrim( A514BR_MedicalImaging_MetastasesDX),(short)1,(String)cmbBR_MedicalImaging_MetastasesDX_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"svchar",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbBR_MedicalImaging_MetastasesDX.CurrentValue = StringUtil.RTrim( A514BR_MedicalImaging_MetastasesDX);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_MedicalImaging_MetastasesDX_Internalname, "Values", (String)(cmbBR_MedicalImaging_MetastasesDX.ToJavascriptSource()), !bGXsfl_12_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImaging_MetaLoc_Internalname,(String)A515BR_MedicalImaging_MetaLoc,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImaging_MetaLoc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImaging_MetaDate_Internalname,context.localUtil.Format(A516BR_MedicalImaging_MetaDate, "9999/99/99"),context.localUtil.Format( A516BR_MedicalImaging_MetaDate, "9999/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImaging_MetaDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Date",(String)"right",(bool)false});
            send_integrity_lvl_hashes5L2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_12_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_12_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1));
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
         }
         /* End function sendrow_122 */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "BR_MEDICALIMAGING_METASTASESDX_" + sGXsfl_12_idx;
         cmbBR_MedicalImaging_MetastasesDX.Name = GXCCtl;
         cmbBR_MedicalImaging_MetastasesDX.WebTags = "";
         cmbBR_MedicalImaging_MetastasesDX.addItem("", "(请选择)", 0);
         cmbBR_MedicalImaging_MetastasesDX.addItem("否", "否", 0);
         cmbBR_MedicalImaging_MetastasesDX.addItem("是", "是", 0);
         cmbBR_MedicalImaging_MetastasesDX.addItem("不详", "不详", 0);
         if ( cmbBR_MedicalImaging_MetastasesDX.ItemCount > 0 )
         {
            A514BR_MedicalImaging_MetastasesDX = cmbBR_MedicalImaging_MetastasesDX.getValidValue(A514BR_MedicalImaging_MetastasesDX);
            n514BR_MedicalImaging_MetastasesDX = false;
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtavSelect_Internalname = "vSELECT";
         edtBR_MedicalImagingID_Internalname = "BR_MEDICALIMAGINGID";
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO";
         edtBR_MedicalImaging_ID_Internalname = "BR_MEDICALIMAGING_ID";
         edtBR_MedicalImaging_ImageName_Internalname = "BR_MEDICALIMAGING_IMAGENAME";
         edtBR_MedicalImaging_ImageName_Code_Internalname = "BR_MEDICALIMAGING_IMAGENAME_CODE";
         edtBR_MedicalImaging_ImageDate_Internalname = "BR_MEDICALIMAGING_IMAGEDATE";
         edtBR_MedicalImaging_ImageHosp_Internalname = "BR_MEDICALIMAGING_IMAGEHOSP";
         edtBR_MedicalImaging_ImageHosp_Code_Internalname = "BR_MEDICALIMAGING_IMAGEHOSP_CODE";
         edtBR_MedicalImaging_ImageAge_Internalname = "BR_MEDICALIMAGING_IMAGEAGE";
         edtBR_MedicalImaging_ImageLoc_Internalname = "BR_MEDICALIMAGING_IMAGELOC";
         edtBR_MedicalImaging_ImageLoc_Code_Internalname = "BR_MEDICALIMAGING_IMAGELOC_CODE";
         edtBR_MedicalImaging_ImageOrgan_Internalname = "BR_MEDICALIMAGING_IMAGEORGAN";
         edtBR_MedicalImaging_PreImageDiag_Internalname = "BR_MEDICALIMAGING_PREIMAGEDIAG";
         edtBR_MedicalImaging_ImageDes_Internalname = "BR_MEDICALIMAGING_IMAGEDES";
         edtBR_MedicalImaging_TumorSize_Internalname = "BR_MEDICALIMAGING_TUMORSIZE";
         edtBR_MedicalImaging_ImageHtml_Internalname = "BR_MEDICALIMAGING_IMAGEHTML";
         cmbBR_MedicalImaging_MetastasesDX_Internalname = "BR_MEDICALIMAGING_METASTASESDX";
         edtBR_MedicalImaging_MetaLoc_Internalname = "BR_MEDICALIMAGING_METALOC";
         edtBR_MedicalImaging_MetaDate_Internalname = "BR_MEDICALIMAGING_METADATE";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_medicalimagingid_Internalname = "DDO_BR_MEDICALIMAGINGID";
         edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE";
         Ddo_br_encounterid_Internalname = "DDO_BR_ENCOUNTERID";
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE";
         Ddo_br_information_patientno_Internalname = "DDO_BR_INFORMATION_PATIENTNO";
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname = "vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE";
         Ddo_br_medicalimaging_id_Internalname = "DDO_BR_MEDICALIMAGING_ID";
         edtavDdo_br_medicalimaging_idtitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICALIMAGING_IDTITLECONTROLIDTOREPLACE";
         Ddo_br_medicalimaging_imagename_Internalname = "DDO_BR_MEDICALIMAGING_IMAGENAME";
         edtavDdo_br_medicalimaging_imagenametitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE";
         Ddo_br_medicalimaging_imagename_code_Internalname = "DDO_BR_MEDICALIMAGING_IMAGENAME_CODE";
         edtavDdo_br_medicalimaging_imagename_codetitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICALIMAGING_IMAGENAME_CODETITLECONTROLIDTOREPLACE";
         Ddo_br_medicalimaging_imagedate_Internalname = "DDO_BR_MEDICALIMAGING_IMAGEDATE";
         edtavDdo_br_medicalimaging_imagedatetitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE";
         Ddo_br_medicalimaging_imagehosp_Internalname = "DDO_BR_MEDICALIMAGING_IMAGEHOSP";
         edtavDdo_br_medicalimaging_imagehosptitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE";
         Ddo_br_medicalimaging_imagehosp_code_Internalname = "DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE";
         edtavDdo_br_medicalimaging_imagehosp_codetitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICALIMAGING_IMAGEHOSP_CODETITLECONTROLIDTOREPLACE";
         Ddo_br_medicalimaging_imageage_Internalname = "DDO_BR_MEDICALIMAGING_IMAGEAGE";
         edtavDdo_br_medicalimaging_imageagetitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE";
         Ddo_br_medicalimaging_imageloc_Internalname = "DDO_BR_MEDICALIMAGING_IMAGELOC";
         edtavDdo_br_medicalimaging_imageloctitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICALIMAGING_IMAGELOCTITLECONTROLIDTOREPLACE";
         Ddo_br_medicalimaging_imageloc_code_Internalname = "DDO_BR_MEDICALIMAGING_IMAGELOC_CODE";
         edtavDdo_br_medicalimaging_imageloc_codetitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICALIMAGING_IMAGELOC_CODETITLECONTROLIDTOREPLACE";
         Ddo_br_medicalimaging_imageorgan_Internalname = "DDO_BR_MEDICALIMAGING_IMAGEORGAN";
         edtavDdo_br_medicalimaging_imageorgantitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICALIMAGING_IMAGEORGANTITLECONTROLIDTOREPLACE";
         Ddo_br_medicalimaging_preimagediag_Internalname = "DDO_BR_MEDICALIMAGING_PREIMAGEDIAG";
         edtavDdo_br_medicalimaging_preimagediagtitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICALIMAGING_PREIMAGEDIAGTITLECONTROLIDTOREPLACE";
         Ddo_br_medicalimaging_imagedes_Internalname = "DDO_BR_MEDICALIMAGING_IMAGEDES";
         edtavDdo_br_medicalimaging_imagedestitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICALIMAGING_IMAGEDESTITLECONTROLIDTOREPLACE";
         Ddo_br_medicalimaging_tumorsize_Internalname = "DDO_BR_MEDICALIMAGING_TUMORSIZE";
         edtavDdo_br_medicalimaging_tumorsizetitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICALIMAGING_TUMORSIZETITLECONTROLIDTOREPLACE";
         Ddo_br_medicalimaging_imagehtml_Internalname = "DDO_BR_MEDICALIMAGING_IMAGEHTML";
         edtavDdo_br_medicalimaging_imagehtmltitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICALIMAGING_IMAGEHTMLTITLECONTROLIDTOREPLACE";
         Ddo_br_medicalimaging_metastasesdx_Internalname = "DDO_BR_MEDICALIMAGING_METASTASESDX";
         edtavDdo_br_medicalimaging_metastasesdxtitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICALIMAGING_METASTASESDXTITLECONTROLIDTOREPLACE";
         Ddo_br_medicalimaging_metaloc_Internalname = "DDO_BR_MEDICALIMAGING_METALOC";
         edtavDdo_br_medicalimaging_metaloctitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICALIMAGING_METALOCTITLECONTROLIDTOREPLACE";
         Ddo_br_medicalimaging_metadate_Internalname = "DDO_BR_MEDICALIMAGING_METADATE";
         edtavDdo_br_medicalimaging_metadatetitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICALIMAGING_METADATETITLECONTROLIDTOREPLACE";
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
         edtBR_MedicalImaging_MetaDate_Jsonclick = "";
         edtBR_MedicalImaging_MetaLoc_Jsonclick = "";
         cmbBR_MedicalImaging_MetastasesDX_Jsonclick = "";
         edtBR_MedicalImaging_ImageHtml_Jsonclick = "";
         edtBR_MedicalImaging_TumorSize_Jsonclick = "";
         edtBR_MedicalImaging_ImageDes_Jsonclick = "";
         edtBR_MedicalImaging_PreImageDiag_Jsonclick = "";
         edtBR_MedicalImaging_ImageOrgan_Jsonclick = "";
         edtBR_MedicalImaging_ImageLoc_Code_Jsonclick = "";
         edtBR_MedicalImaging_ImageLoc_Jsonclick = "";
         edtBR_MedicalImaging_ImageAge_Jsonclick = "";
         edtBR_MedicalImaging_ImageHosp_Code_Jsonclick = "";
         edtBR_MedicalImaging_ImageHosp_Jsonclick = "";
         edtBR_MedicalImaging_ImageDate_Jsonclick = "";
         edtBR_MedicalImaging_ImageName_Code_Jsonclick = "";
         edtBR_MedicalImaging_ImageName_Jsonclick = "";
         edtBR_MedicalImaging_ID_Jsonclick = "";
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_EncounterID_Jsonclick = "";
         edtBR_MedicalImagingID_Jsonclick = "";
         edtavSelect_Jsonclick = "";
         edtavSelect_Visible = -1;
         edtavSelect_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_medicalimaging_metadatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medicalimaging_metaloctitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medicalimaging_metastasesdxtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medicalimaging_imagehtmltitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medicalimaging_tumorsizetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medicalimaging_imagedestitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medicalimaging_preimagediagtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medicalimaging_imageorgantitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medicalimaging_imageloc_codetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medicalimaging_imageloctitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medicalimaging_imageagetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medicalimaging_imagehosp_codetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medicalimaging_imagehosptitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medicalimaging_imagedatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medicalimaging_imagename_codetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medicalimaging_imagenametitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medicalimaging_idtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavSelect_Tooltiptext = "选择";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_MedicalImaging_MetaDate_Titleformat = 0;
         edtBR_MedicalImaging_MetaDate_Title = "肿瘤转移时间";
         edtBR_MedicalImaging_MetaLoc_Titleformat = 0;
         edtBR_MedicalImaging_MetaLoc_Title = "肿瘤转移部位";
         cmbBR_MedicalImaging_MetastasesDX_Titleformat = 0;
         cmbBR_MedicalImaging_MetastasesDX.Title.Text = "是否有肿瘤转移";
         edtBR_MedicalImaging_ImageHtml_Titleformat = 0;
         edtBR_MedicalImaging_ImageHtml_Title = "上传图片";
         edtBR_MedicalImaging_TumorSize_Titleformat = 0;
         edtBR_MedicalImaging_TumorSize_Title = "肿瘤大小";
         edtBR_MedicalImaging_ImageDes_Titleformat = 0;
         edtBR_MedicalImaging_ImageDes_Title = "图像描述";
         edtBR_MedicalImaging_PreImageDiag_Titleformat = 0;
         edtBR_MedicalImaging_PreImageDiag_Title = "影像前诊断";
         edtBR_MedicalImaging_ImageOrgan_Titleformat = 0;
         edtBR_MedicalImaging_ImageOrgan_Title = "检查部位(器官)";
         edtBR_MedicalImaging_ImageLoc_Code_Titleformat = 0;
         edtBR_MedicalImaging_ImageLoc_Code_Title = "检查部位(位置)code";
         edtBR_MedicalImaging_ImageLoc_Titleformat = 0;
         edtBR_MedicalImaging_ImageLoc_Title = "检查部位(位置)";
         edtBR_MedicalImaging_ImageAge_Titleformat = 0;
         edtBR_MedicalImaging_ImageAge_Title = "年龄";
         edtBR_MedicalImaging_ImageHosp_Code_Titleformat = 0;
         edtBR_MedicalImaging_ImageHosp_Code_Title = "行检医院code";
         edtBR_MedicalImaging_ImageHosp_Titleformat = 0;
         edtBR_MedicalImaging_ImageHosp_Title = "行检医院";
         edtBR_MedicalImaging_ImageDate_Titleformat = 0;
         edtBR_MedicalImaging_ImageDate_Title = "检查日期";
         edtBR_MedicalImaging_ImageName_Code_Titleformat = 0;
         edtBR_MedicalImaging_ImageName_Code_Title = "影像名称code";
         edtBR_MedicalImaging_ImageName_Titleformat = 0;
         edtBR_MedicalImaging_ImageName_Title = "影像名称";
         edtBR_MedicalImaging_ID_Titleformat = 0;
         edtBR_MedicalImaging_ID_Title = "项目序号";
         edtBR_Information_PatientNo_Titleformat = 0;
         edtBR_Information_PatientNo_Title = "患者编号";
         edtBR_EncounterID_Titleformat = 0;
         edtBR_EncounterID_Title = "就诊信息主键";
         edtBR_MedicalImagingID_Titleformat = 0;
         edtBR_MedicalImagingID_Title = "影像学主键";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         divTablemain_Height = 0;
         Ddo_br_medicalimaging_metadate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_metadate_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_metadate_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_metadate_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_metadate_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_metadate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_metadate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_metadate_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimaging_metadate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimaging_metadate_Cls = "ColumnSettings";
         Ddo_br_medicalimaging_metadate_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimaging_metadate_Caption = "";
         Ddo_br_medicalimaging_metaloc_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_metaloc_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_metaloc_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_metaloc_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_metaloc_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_metaloc_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_metaloc_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_metaloc_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimaging_metaloc_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimaging_metaloc_Cls = "ColumnSettings";
         Ddo_br_medicalimaging_metaloc_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimaging_metaloc_Caption = "";
         Ddo_br_medicalimaging_metastasesdx_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_metastasesdx_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_metastasesdx_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_metastasesdx_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_metastasesdx_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_metastasesdx_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_metastasesdx_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_metastasesdx_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimaging_metastasesdx_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimaging_metastasesdx_Cls = "ColumnSettings";
         Ddo_br_medicalimaging_metastasesdx_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimaging_metastasesdx_Caption = "";
         Ddo_br_medicalimaging_imagehtml_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_imagehtml_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_imagehtml_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_imagehtml_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_imagehtml_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_imagehtml_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_imagehtml_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_imagehtml_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimaging_imagehtml_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimaging_imagehtml_Cls = "ColumnSettings";
         Ddo_br_medicalimaging_imagehtml_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimaging_imagehtml_Caption = "";
         Ddo_br_medicalimaging_tumorsize_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_tumorsize_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_tumorsize_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_tumorsize_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_tumorsize_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_tumorsize_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_tumorsize_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_tumorsize_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimaging_tumorsize_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimaging_tumorsize_Cls = "ColumnSettings";
         Ddo_br_medicalimaging_tumorsize_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimaging_tumorsize_Caption = "";
         Ddo_br_medicalimaging_imagedes_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_imagedes_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_imagedes_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_imagedes_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_imagedes_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_imagedes_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_imagedes_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_imagedes_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimaging_imagedes_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimaging_imagedes_Cls = "ColumnSettings";
         Ddo_br_medicalimaging_imagedes_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimaging_imagedes_Caption = "";
         Ddo_br_medicalimaging_preimagediag_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_preimagediag_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_preimagediag_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_preimagediag_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_preimagediag_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_preimagediag_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_preimagediag_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_preimagediag_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimaging_preimagediag_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimaging_preimagediag_Cls = "ColumnSettings";
         Ddo_br_medicalimaging_preimagediag_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimaging_preimagediag_Caption = "";
         Ddo_br_medicalimaging_imageorgan_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_imageorgan_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_imageorgan_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_imageorgan_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_imageorgan_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_imageorgan_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_imageorgan_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_imageorgan_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimaging_imageorgan_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimaging_imageorgan_Cls = "ColumnSettings";
         Ddo_br_medicalimaging_imageorgan_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimaging_imageorgan_Caption = "";
         Ddo_br_medicalimaging_imageloc_code_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_imageloc_code_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_imageloc_code_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_imageloc_code_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_imageloc_code_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_imageloc_code_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_imageloc_code_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_imageloc_code_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimaging_imageloc_code_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimaging_imageloc_code_Cls = "ColumnSettings";
         Ddo_br_medicalimaging_imageloc_code_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimaging_imageloc_code_Caption = "";
         Ddo_br_medicalimaging_imageloc_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_imageloc_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_imageloc_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_imageloc_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_imageloc_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_imageloc_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_imageloc_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_imageloc_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimaging_imageloc_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimaging_imageloc_Cls = "ColumnSettings";
         Ddo_br_medicalimaging_imageloc_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimaging_imageloc_Caption = "";
         Ddo_br_medicalimaging_imageage_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_imageage_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_imageage_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_imageage_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_imageage_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_imageage_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_imageage_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_imageage_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimaging_imageage_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimaging_imageage_Cls = "ColumnSettings";
         Ddo_br_medicalimaging_imageage_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimaging_imageage_Caption = "";
         Ddo_br_medicalimaging_imagehosp_code_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_imagehosp_code_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_imagehosp_code_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_imagehosp_code_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_imagehosp_code_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_imagehosp_code_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_imagehosp_code_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_imagehosp_code_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimaging_imagehosp_code_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimaging_imagehosp_code_Cls = "ColumnSettings";
         Ddo_br_medicalimaging_imagehosp_code_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimaging_imagehosp_code_Caption = "";
         Ddo_br_medicalimaging_imagehosp_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_imagehosp_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_imagehosp_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_imagehosp_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_imagehosp_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_imagehosp_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_imagehosp_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_imagehosp_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimaging_imagehosp_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimaging_imagehosp_Cls = "ColumnSettings";
         Ddo_br_medicalimaging_imagehosp_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimaging_imagehosp_Caption = "";
         Ddo_br_medicalimaging_imagedate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_imagedate_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_imagedate_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_imagedate_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_imagedate_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_imagedate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_imagedate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_imagedate_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimaging_imagedate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimaging_imagedate_Cls = "ColumnSettings";
         Ddo_br_medicalimaging_imagedate_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimaging_imagedate_Caption = "";
         Ddo_br_medicalimaging_imagename_code_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_imagename_code_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_imagename_code_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_imagename_code_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_imagename_code_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_imagename_code_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_imagename_code_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_imagename_code_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimaging_imagename_code_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimaging_imagename_code_Cls = "ColumnSettings";
         Ddo_br_medicalimaging_imagename_code_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimaging_imagename_code_Caption = "";
         Ddo_br_medicalimaging_imagename_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_imagename_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_imagename_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_imagename_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_imagename_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_imagename_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_imagename_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_imagename_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimaging_imagename_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimaging_imagename_Cls = "ColumnSettings";
         Ddo_br_medicalimaging_imagename_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimaging_imagename_Caption = "";
         Ddo_br_medicalimaging_id_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_id_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_id_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_id_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_id_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_id_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_id_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_id_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimaging_id_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimaging_id_Cls = "ColumnSettings";
         Ddo_br_medicalimaging_id_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimaging_id_Caption = "";
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
         Form.Caption = "选择影像学";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAME_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSP_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOC_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_PREIMAGEDIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDESTITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_TUMORSIZETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHTMLTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METADATETITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV13BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_MedicalImaging_IDTitleFilterData',fld:'vBR_MEDICALIMAGING_IDTITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV48BR_MedicalImaging_ImageName_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAME_CODETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{av:'AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSP_CODETITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV29BR_MedicalImaging_ImageLocTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOCTITLEFILTERDATA',pic:''},{av:'AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOC_CODETITLEFILTERDATA',pic:''},{av:'AV31BR_MedicalImaging_ImageOrganTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEORGANTITLEFILTERDATA',pic:''},{av:'AV33BR_MedicalImaging_PreImageDiagTitleFilterData',fld:'vBR_MEDICALIMAGING_PREIMAGEDIAGTITLEFILTERDATA',pic:''},{av:'AV35BR_MedicalImaging_ImageDesTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDESTITLEFILTERDATA',pic:''},{av:'AV37BR_MedicalImaging_TumorSizeTitleFilterData',fld:'vBR_MEDICALIMAGING_TUMORSIZETITLEFILTERDATA',pic:''},{av:'AV46BR_MedicalImaging_ImageHtmlTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHTMLTITLEFILTERDATA',pic:''},{av:'AV54BR_MedicalImaging_MetastasesDXTitleFilterData',fld:'vBR_MEDICALIMAGING_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV56BR_MedicalImaging_MetaLocTitleFilterData',fld:'vBR_MEDICALIMAGING_METALOCTITLEFILTERDATA',pic:''},{av:'AV58BR_MedicalImaging_MetaDateTitleFilterData',fld:'vBR_MEDICALIMAGING_METADATETITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_MedicalImaging_ID_Titleformat',ctrl:'BR_MEDICALIMAGING_ID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ID_Title',ctrl:'BR_MEDICALIMAGING_ID',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDate_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDate_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageAge_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageAge_Title',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageOrgan_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageOrgan_Title',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_PreImageDiag_Titleformat',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Titleformat'},{av:'edtBR_MedicalImaging_PreImageDiag_Title',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDes_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDes_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Title'},{av:'edtBR_MedicalImaging_TumorSize_Titleformat',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_TumorSize_Title',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHtml_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHtml_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Title'},{av:'cmbBR_MedicalImaging_MetastasesDX'},{av:'edtBR_MedicalImaging_MetaLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaLoc_Title',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Title'},{av:'edtBR_MedicalImaging_MetaDate_Titleformat',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaDate_Title',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E115L2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAME_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSP_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOC_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_PREIMAGEDIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDESTITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_TUMORSIZETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHTMLTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METADATETITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E125L2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAME_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSP_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOC_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_PREIMAGEDIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDESTITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_TUMORSIZETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHTMLTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METADATETITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGINGID.ONOPTIONCLICKED","{handler:'E135L2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAME_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSP_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOC_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_PREIMAGEDIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDESTITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_TUMORSIZETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHTMLTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METADATETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medicalimagingid_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGINGID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGINGID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimagingid_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGINGID',prop:'SortedStatus'},{av:'AV13BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_MedicalImaging_IDTitleFilterData',fld:'vBR_MEDICALIMAGING_IDTITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV48BR_MedicalImaging_ImageName_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAME_CODETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{av:'AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSP_CODETITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV29BR_MedicalImaging_ImageLocTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOCTITLEFILTERDATA',pic:''},{av:'AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOC_CODETITLEFILTERDATA',pic:''},{av:'AV31BR_MedicalImaging_ImageOrganTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEORGANTITLEFILTERDATA',pic:''},{av:'AV33BR_MedicalImaging_PreImageDiagTitleFilterData',fld:'vBR_MEDICALIMAGING_PREIMAGEDIAGTITLEFILTERDATA',pic:''},{av:'AV35BR_MedicalImaging_ImageDesTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDESTITLEFILTERDATA',pic:''},{av:'AV37BR_MedicalImaging_TumorSizeTitleFilterData',fld:'vBR_MEDICALIMAGING_TUMORSIZETITLEFILTERDATA',pic:''},{av:'AV46BR_MedicalImaging_ImageHtmlTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHTMLTITLEFILTERDATA',pic:''},{av:'AV54BR_MedicalImaging_MetastasesDXTitleFilterData',fld:'vBR_MEDICALIMAGING_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV56BR_MedicalImaging_MetaLocTitleFilterData',fld:'vBR_MEDICALIMAGING_METALOCTITLEFILTERDATA',pic:''},{av:'AV58BR_MedicalImaging_MetaDateTitleFilterData',fld:'vBR_MEDICALIMAGING_METADATETITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_MedicalImaging_ID_Titleformat',ctrl:'BR_MEDICALIMAGING_ID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ID_Title',ctrl:'BR_MEDICALIMAGING_ID',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDate_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDate_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageAge_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageAge_Title',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageOrgan_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageOrgan_Title',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_PreImageDiag_Titleformat',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Titleformat'},{av:'edtBR_MedicalImaging_PreImageDiag_Title',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDes_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDes_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Title'},{av:'edtBR_MedicalImaging_TumorSize_Titleformat',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_TumorSize_Title',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHtml_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHtml_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Title'},{av:'cmbBR_MedicalImaging_MetastasesDX'},{av:'edtBR_MedicalImaging_MetaLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaLoc_Title',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Title'},{av:'edtBR_MedicalImaging_MetaDate_Titleformat',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaDate_Title',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED","{handler:'E145L2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAME_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSP_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOC_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_PREIMAGEDIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDESTITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_TUMORSIZETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHTMLTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METADATETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_encounterid_Activeeventkey',ctrl:'DDO_BR_ENCOUNTERID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'AV13BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_MedicalImaging_IDTitleFilterData',fld:'vBR_MEDICALIMAGING_IDTITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV48BR_MedicalImaging_ImageName_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAME_CODETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{av:'AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSP_CODETITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV29BR_MedicalImaging_ImageLocTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOCTITLEFILTERDATA',pic:''},{av:'AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOC_CODETITLEFILTERDATA',pic:''},{av:'AV31BR_MedicalImaging_ImageOrganTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEORGANTITLEFILTERDATA',pic:''},{av:'AV33BR_MedicalImaging_PreImageDiagTitleFilterData',fld:'vBR_MEDICALIMAGING_PREIMAGEDIAGTITLEFILTERDATA',pic:''},{av:'AV35BR_MedicalImaging_ImageDesTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDESTITLEFILTERDATA',pic:''},{av:'AV37BR_MedicalImaging_TumorSizeTitleFilterData',fld:'vBR_MEDICALIMAGING_TUMORSIZETITLEFILTERDATA',pic:''},{av:'AV46BR_MedicalImaging_ImageHtmlTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHTMLTITLEFILTERDATA',pic:''},{av:'AV54BR_MedicalImaging_MetastasesDXTitleFilterData',fld:'vBR_MEDICALIMAGING_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV56BR_MedicalImaging_MetaLocTitleFilterData',fld:'vBR_MEDICALIMAGING_METALOCTITLEFILTERDATA',pic:''},{av:'AV58BR_MedicalImaging_MetaDateTitleFilterData',fld:'vBR_MEDICALIMAGING_METADATETITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_MedicalImaging_ID_Titleformat',ctrl:'BR_MEDICALIMAGING_ID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ID_Title',ctrl:'BR_MEDICALIMAGING_ID',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDate_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDate_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageAge_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageAge_Title',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageOrgan_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageOrgan_Title',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_PreImageDiag_Titleformat',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Titleformat'},{av:'edtBR_MedicalImaging_PreImageDiag_Title',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDes_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDes_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Title'},{av:'edtBR_MedicalImaging_TumorSize_Titleformat',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_TumorSize_Title',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHtml_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHtml_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Title'},{av:'cmbBR_MedicalImaging_MetastasesDX'},{av:'edtBR_MedicalImaging_MetaLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaLoc_Title',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Title'},{av:'edtBR_MedicalImaging_MetaDate_Titleformat',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaDate_Title',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED","{handler:'E155L2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAME_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSP_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOC_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_PREIMAGEDIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDESTITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_TUMORSIZETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHTMLTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METADATETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_information_patientno_Activeeventkey',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'AV13BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_MedicalImaging_IDTitleFilterData',fld:'vBR_MEDICALIMAGING_IDTITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV48BR_MedicalImaging_ImageName_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAME_CODETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{av:'AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSP_CODETITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV29BR_MedicalImaging_ImageLocTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOCTITLEFILTERDATA',pic:''},{av:'AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOC_CODETITLEFILTERDATA',pic:''},{av:'AV31BR_MedicalImaging_ImageOrganTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEORGANTITLEFILTERDATA',pic:''},{av:'AV33BR_MedicalImaging_PreImageDiagTitleFilterData',fld:'vBR_MEDICALIMAGING_PREIMAGEDIAGTITLEFILTERDATA',pic:''},{av:'AV35BR_MedicalImaging_ImageDesTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDESTITLEFILTERDATA',pic:''},{av:'AV37BR_MedicalImaging_TumorSizeTitleFilterData',fld:'vBR_MEDICALIMAGING_TUMORSIZETITLEFILTERDATA',pic:''},{av:'AV46BR_MedicalImaging_ImageHtmlTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHTMLTITLEFILTERDATA',pic:''},{av:'AV54BR_MedicalImaging_MetastasesDXTitleFilterData',fld:'vBR_MEDICALIMAGING_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV56BR_MedicalImaging_MetaLocTitleFilterData',fld:'vBR_MEDICALIMAGING_METALOCTITLEFILTERDATA',pic:''},{av:'AV58BR_MedicalImaging_MetaDateTitleFilterData',fld:'vBR_MEDICALIMAGING_METADATETITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_MedicalImaging_ID_Titleformat',ctrl:'BR_MEDICALIMAGING_ID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ID_Title',ctrl:'BR_MEDICALIMAGING_ID',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDate_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDate_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageAge_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageAge_Title',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageOrgan_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageOrgan_Title',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_PreImageDiag_Titleformat',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Titleformat'},{av:'edtBR_MedicalImaging_PreImageDiag_Title',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDes_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDes_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Title'},{av:'edtBR_MedicalImaging_TumorSize_Titleformat',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_TumorSize_Title',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHtml_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHtml_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Title'},{av:'cmbBR_MedicalImaging_MetastasesDX'},{av:'edtBR_MedicalImaging_MetaLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaLoc_Title',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Title'},{av:'edtBR_MedicalImaging_MetaDate_Titleformat',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaDate_Title',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_ID.ONOPTIONCLICKED","{handler:'E165L2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAME_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSP_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOC_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_PREIMAGEDIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDESTITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_TUMORSIZETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHTMLTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METADATETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medicalimaging_id_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_ID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_ID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_id_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_ID',prop:'SortedStatus'},{av:'AV13BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_MedicalImaging_IDTitleFilterData',fld:'vBR_MEDICALIMAGING_IDTITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV48BR_MedicalImaging_ImageName_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAME_CODETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{av:'AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSP_CODETITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV29BR_MedicalImaging_ImageLocTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOCTITLEFILTERDATA',pic:''},{av:'AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOC_CODETITLEFILTERDATA',pic:''},{av:'AV31BR_MedicalImaging_ImageOrganTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEORGANTITLEFILTERDATA',pic:''},{av:'AV33BR_MedicalImaging_PreImageDiagTitleFilterData',fld:'vBR_MEDICALIMAGING_PREIMAGEDIAGTITLEFILTERDATA',pic:''},{av:'AV35BR_MedicalImaging_ImageDesTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDESTITLEFILTERDATA',pic:''},{av:'AV37BR_MedicalImaging_TumorSizeTitleFilterData',fld:'vBR_MEDICALIMAGING_TUMORSIZETITLEFILTERDATA',pic:''},{av:'AV46BR_MedicalImaging_ImageHtmlTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHTMLTITLEFILTERDATA',pic:''},{av:'AV54BR_MedicalImaging_MetastasesDXTitleFilterData',fld:'vBR_MEDICALIMAGING_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV56BR_MedicalImaging_MetaLocTitleFilterData',fld:'vBR_MEDICALIMAGING_METALOCTITLEFILTERDATA',pic:''},{av:'AV58BR_MedicalImaging_MetaDateTitleFilterData',fld:'vBR_MEDICALIMAGING_METADATETITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_MedicalImaging_ID_Titleformat',ctrl:'BR_MEDICALIMAGING_ID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ID_Title',ctrl:'BR_MEDICALIMAGING_ID',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDate_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDate_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageAge_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageAge_Title',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageOrgan_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageOrgan_Title',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_PreImageDiag_Titleformat',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Titleformat'},{av:'edtBR_MedicalImaging_PreImageDiag_Title',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDes_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDes_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Title'},{av:'edtBR_MedicalImaging_TumorSize_Titleformat',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_TumorSize_Title',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHtml_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHtml_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Title'},{av:'cmbBR_MedicalImaging_MetastasesDX'},{av:'edtBR_MedicalImaging_MetaLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaLoc_Title',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Title'},{av:'edtBR_MedicalImaging_MetaDate_Titleformat',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaDate_Title',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_IMAGENAME.ONOPTIONCLICKED","{handler:'E175L2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAME_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSP_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOC_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_PREIMAGEDIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDESTITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_TUMORSIZETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHTMLTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METADATETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medicalimaging_imagename_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_IMAGENAME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_IMAGENAME.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_imagename_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGENAME',prop:'SortedStatus'},{av:'AV13BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_MedicalImaging_IDTitleFilterData',fld:'vBR_MEDICALIMAGING_IDTITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV48BR_MedicalImaging_ImageName_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAME_CODETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{av:'AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSP_CODETITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV29BR_MedicalImaging_ImageLocTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOCTITLEFILTERDATA',pic:''},{av:'AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOC_CODETITLEFILTERDATA',pic:''},{av:'AV31BR_MedicalImaging_ImageOrganTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEORGANTITLEFILTERDATA',pic:''},{av:'AV33BR_MedicalImaging_PreImageDiagTitleFilterData',fld:'vBR_MEDICALIMAGING_PREIMAGEDIAGTITLEFILTERDATA',pic:''},{av:'AV35BR_MedicalImaging_ImageDesTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDESTITLEFILTERDATA',pic:''},{av:'AV37BR_MedicalImaging_TumorSizeTitleFilterData',fld:'vBR_MEDICALIMAGING_TUMORSIZETITLEFILTERDATA',pic:''},{av:'AV46BR_MedicalImaging_ImageHtmlTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHTMLTITLEFILTERDATA',pic:''},{av:'AV54BR_MedicalImaging_MetastasesDXTitleFilterData',fld:'vBR_MEDICALIMAGING_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV56BR_MedicalImaging_MetaLocTitleFilterData',fld:'vBR_MEDICALIMAGING_METALOCTITLEFILTERDATA',pic:''},{av:'AV58BR_MedicalImaging_MetaDateTitleFilterData',fld:'vBR_MEDICALIMAGING_METADATETITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_MedicalImaging_ID_Titleformat',ctrl:'BR_MEDICALIMAGING_ID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ID_Title',ctrl:'BR_MEDICALIMAGING_ID',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDate_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDate_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageAge_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageAge_Title',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageOrgan_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageOrgan_Title',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_PreImageDiag_Titleformat',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Titleformat'},{av:'edtBR_MedicalImaging_PreImageDiag_Title',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDes_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDes_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Title'},{av:'edtBR_MedicalImaging_TumorSize_Titleformat',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_TumorSize_Title',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHtml_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHtml_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Title'},{av:'cmbBR_MedicalImaging_MetastasesDX'},{av:'edtBR_MedicalImaging_MetaLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaLoc_Title',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Title'},{av:'edtBR_MedicalImaging_MetaDate_Titleformat',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaDate_Title',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_IMAGENAME_CODE.ONOPTIONCLICKED","{handler:'E185L2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAME_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSP_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOC_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_PREIMAGEDIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDESTITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_TUMORSIZETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHTMLTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METADATETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medicalimaging_imagename_code_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_IMAGENAME_CODE.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_imagename_code_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'SortedStatus'},{av:'AV13BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_MedicalImaging_IDTitleFilterData',fld:'vBR_MEDICALIMAGING_IDTITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV48BR_MedicalImaging_ImageName_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAME_CODETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{av:'AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSP_CODETITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV29BR_MedicalImaging_ImageLocTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOCTITLEFILTERDATA',pic:''},{av:'AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOC_CODETITLEFILTERDATA',pic:''},{av:'AV31BR_MedicalImaging_ImageOrganTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEORGANTITLEFILTERDATA',pic:''},{av:'AV33BR_MedicalImaging_PreImageDiagTitleFilterData',fld:'vBR_MEDICALIMAGING_PREIMAGEDIAGTITLEFILTERDATA',pic:''},{av:'AV35BR_MedicalImaging_ImageDesTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDESTITLEFILTERDATA',pic:''},{av:'AV37BR_MedicalImaging_TumorSizeTitleFilterData',fld:'vBR_MEDICALIMAGING_TUMORSIZETITLEFILTERDATA',pic:''},{av:'AV46BR_MedicalImaging_ImageHtmlTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHTMLTITLEFILTERDATA',pic:''},{av:'AV54BR_MedicalImaging_MetastasesDXTitleFilterData',fld:'vBR_MEDICALIMAGING_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV56BR_MedicalImaging_MetaLocTitleFilterData',fld:'vBR_MEDICALIMAGING_METALOCTITLEFILTERDATA',pic:''},{av:'AV58BR_MedicalImaging_MetaDateTitleFilterData',fld:'vBR_MEDICALIMAGING_METADATETITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_MedicalImaging_ID_Titleformat',ctrl:'BR_MEDICALIMAGING_ID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ID_Title',ctrl:'BR_MEDICALIMAGING_ID',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDate_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDate_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageAge_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageAge_Title',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageOrgan_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageOrgan_Title',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_PreImageDiag_Titleformat',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Titleformat'},{av:'edtBR_MedicalImaging_PreImageDiag_Title',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDes_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDes_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Title'},{av:'edtBR_MedicalImaging_TumorSize_Titleformat',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_TumorSize_Title',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHtml_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHtml_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Title'},{av:'cmbBR_MedicalImaging_MetastasesDX'},{av:'edtBR_MedicalImaging_MetaLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaLoc_Title',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Title'},{av:'edtBR_MedicalImaging_MetaDate_Titleformat',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaDate_Title',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_IMAGEDATE.ONOPTIONCLICKED","{handler:'E195L2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAME_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSP_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOC_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_PREIMAGEDIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDESTITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_TUMORSIZETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHTMLTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METADATETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medicalimaging_imagedate_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEDATE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_IMAGEDATE.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_imagedate_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEDATE',prop:'SortedStatus'},{av:'AV13BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_MedicalImaging_IDTitleFilterData',fld:'vBR_MEDICALIMAGING_IDTITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV48BR_MedicalImaging_ImageName_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAME_CODETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{av:'AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSP_CODETITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV29BR_MedicalImaging_ImageLocTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOCTITLEFILTERDATA',pic:''},{av:'AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOC_CODETITLEFILTERDATA',pic:''},{av:'AV31BR_MedicalImaging_ImageOrganTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEORGANTITLEFILTERDATA',pic:''},{av:'AV33BR_MedicalImaging_PreImageDiagTitleFilterData',fld:'vBR_MEDICALIMAGING_PREIMAGEDIAGTITLEFILTERDATA',pic:''},{av:'AV35BR_MedicalImaging_ImageDesTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDESTITLEFILTERDATA',pic:''},{av:'AV37BR_MedicalImaging_TumorSizeTitleFilterData',fld:'vBR_MEDICALIMAGING_TUMORSIZETITLEFILTERDATA',pic:''},{av:'AV46BR_MedicalImaging_ImageHtmlTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHTMLTITLEFILTERDATA',pic:''},{av:'AV54BR_MedicalImaging_MetastasesDXTitleFilterData',fld:'vBR_MEDICALIMAGING_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV56BR_MedicalImaging_MetaLocTitleFilterData',fld:'vBR_MEDICALIMAGING_METALOCTITLEFILTERDATA',pic:''},{av:'AV58BR_MedicalImaging_MetaDateTitleFilterData',fld:'vBR_MEDICALIMAGING_METADATETITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_MedicalImaging_ID_Titleformat',ctrl:'BR_MEDICALIMAGING_ID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ID_Title',ctrl:'BR_MEDICALIMAGING_ID',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDate_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDate_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageAge_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageAge_Title',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageOrgan_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageOrgan_Title',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_PreImageDiag_Titleformat',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Titleformat'},{av:'edtBR_MedicalImaging_PreImageDiag_Title',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDes_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDes_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Title'},{av:'edtBR_MedicalImaging_TumorSize_Titleformat',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_TumorSize_Title',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHtml_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHtml_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Title'},{av:'cmbBR_MedicalImaging_MetastasesDX'},{av:'edtBR_MedicalImaging_MetaLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaLoc_Title',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Title'},{av:'edtBR_MedicalImaging_MetaDate_Titleformat',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaDate_Title',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_IMAGEHOSP.ONOPTIONCLICKED","{handler:'E205L2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAME_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSP_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOC_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_PREIMAGEDIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDESTITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_TUMORSIZETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHTMLTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METADATETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medicalimaging_imagehosp_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEHOSP',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_IMAGEHOSP.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_imagehosp_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEHOSP',prop:'SortedStatus'},{av:'AV13BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_MedicalImaging_IDTitleFilterData',fld:'vBR_MEDICALIMAGING_IDTITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV48BR_MedicalImaging_ImageName_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAME_CODETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{av:'AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSP_CODETITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV29BR_MedicalImaging_ImageLocTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOCTITLEFILTERDATA',pic:''},{av:'AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOC_CODETITLEFILTERDATA',pic:''},{av:'AV31BR_MedicalImaging_ImageOrganTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEORGANTITLEFILTERDATA',pic:''},{av:'AV33BR_MedicalImaging_PreImageDiagTitleFilterData',fld:'vBR_MEDICALIMAGING_PREIMAGEDIAGTITLEFILTERDATA',pic:''},{av:'AV35BR_MedicalImaging_ImageDesTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDESTITLEFILTERDATA',pic:''},{av:'AV37BR_MedicalImaging_TumorSizeTitleFilterData',fld:'vBR_MEDICALIMAGING_TUMORSIZETITLEFILTERDATA',pic:''},{av:'AV46BR_MedicalImaging_ImageHtmlTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHTMLTITLEFILTERDATA',pic:''},{av:'AV54BR_MedicalImaging_MetastasesDXTitleFilterData',fld:'vBR_MEDICALIMAGING_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV56BR_MedicalImaging_MetaLocTitleFilterData',fld:'vBR_MEDICALIMAGING_METALOCTITLEFILTERDATA',pic:''},{av:'AV58BR_MedicalImaging_MetaDateTitleFilterData',fld:'vBR_MEDICALIMAGING_METADATETITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_MedicalImaging_ID_Titleformat',ctrl:'BR_MEDICALIMAGING_ID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ID_Title',ctrl:'BR_MEDICALIMAGING_ID',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDate_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDate_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageAge_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageAge_Title',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageOrgan_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageOrgan_Title',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_PreImageDiag_Titleformat',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Titleformat'},{av:'edtBR_MedicalImaging_PreImageDiag_Title',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDes_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDes_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Title'},{av:'edtBR_MedicalImaging_TumorSize_Titleformat',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_TumorSize_Title',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHtml_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHtml_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Title'},{av:'cmbBR_MedicalImaging_MetastasesDX'},{av:'edtBR_MedicalImaging_MetaLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaLoc_Title',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Title'},{av:'edtBR_MedicalImaging_MetaDate_Titleformat',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaDate_Title',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE.ONOPTIONCLICKED","{handler:'E215L2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAME_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSP_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOC_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_PREIMAGEDIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDESTITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_TUMORSIZETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHTMLTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METADATETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medicalimaging_imagehosp_code_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_imagehosp_code_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'SortedStatus'},{av:'AV13BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_MedicalImaging_IDTitleFilterData',fld:'vBR_MEDICALIMAGING_IDTITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV48BR_MedicalImaging_ImageName_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAME_CODETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{av:'AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSP_CODETITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV29BR_MedicalImaging_ImageLocTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOCTITLEFILTERDATA',pic:''},{av:'AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOC_CODETITLEFILTERDATA',pic:''},{av:'AV31BR_MedicalImaging_ImageOrganTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEORGANTITLEFILTERDATA',pic:''},{av:'AV33BR_MedicalImaging_PreImageDiagTitleFilterData',fld:'vBR_MEDICALIMAGING_PREIMAGEDIAGTITLEFILTERDATA',pic:''},{av:'AV35BR_MedicalImaging_ImageDesTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDESTITLEFILTERDATA',pic:''},{av:'AV37BR_MedicalImaging_TumorSizeTitleFilterData',fld:'vBR_MEDICALIMAGING_TUMORSIZETITLEFILTERDATA',pic:''},{av:'AV46BR_MedicalImaging_ImageHtmlTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHTMLTITLEFILTERDATA',pic:''},{av:'AV54BR_MedicalImaging_MetastasesDXTitleFilterData',fld:'vBR_MEDICALIMAGING_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV56BR_MedicalImaging_MetaLocTitleFilterData',fld:'vBR_MEDICALIMAGING_METALOCTITLEFILTERDATA',pic:''},{av:'AV58BR_MedicalImaging_MetaDateTitleFilterData',fld:'vBR_MEDICALIMAGING_METADATETITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_MedicalImaging_ID_Titleformat',ctrl:'BR_MEDICALIMAGING_ID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ID_Title',ctrl:'BR_MEDICALIMAGING_ID',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDate_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDate_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageAge_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageAge_Title',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageOrgan_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageOrgan_Title',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_PreImageDiag_Titleformat',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Titleformat'},{av:'edtBR_MedicalImaging_PreImageDiag_Title',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDes_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDes_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Title'},{av:'edtBR_MedicalImaging_TumorSize_Titleformat',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_TumorSize_Title',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHtml_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHtml_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Title'},{av:'cmbBR_MedicalImaging_MetastasesDX'},{av:'edtBR_MedicalImaging_MetaLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaLoc_Title',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Title'},{av:'edtBR_MedicalImaging_MetaDate_Titleformat',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaDate_Title',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_IMAGEAGE.ONOPTIONCLICKED","{handler:'E225L2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAME_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSP_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOC_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_PREIMAGEDIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDESTITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_TUMORSIZETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHTMLTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METADATETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medicalimaging_imageage_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEAGE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_IMAGEAGE.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_imageage_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEAGE',prop:'SortedStatus'},{av:'AV13BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_MedicalImaging_IDTitleFilterData',fld:'vBR_MEDICALIMAGING_IDTITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV48BR_MedicalImaging_ImageName_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAME_CODETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{av:'AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSP_CODETITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV29BR_MedicalImaging_ImageLocTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOCTITLEFILTERDATA',pic:''},{av:'AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOC_CODETITLEFILTERDATA',pic:''},{av:'AV31BR_MedicalImaging_ImageOrganTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEORGANTITLEFILTERDATA',pic:''},{av:'AV33BR_MedicalImaging_PreImageDiagTitleFilterData',fld:'vBR_MEDICALIMAGING_PREIMAGEDIAGTITLEFILTERDATA',pic:''},{av:'AV35BR_MedicalImaging_ImageDesTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDESTITLEFILTERDATA',pic:''},{av:'AV37BR_MedicalImaging_TumorSizeTitleFilterData',fld:'vBR_MEDICALIMAGING_TUMORSIZETITLEFILTERDATA',pic:''},{av:'AV46BR_MedicalImaging_ImageHtmlTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHTMLTITLEFILTERDATA',pic:''},{av:'AV54BR_MedicalImaging_MetastasesDXTitleFilterData',fld:'vBR_MEDICALIMAGING_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV56BR_MedicalImaging_MetaLocTitleFilterData',fld:'vBR_MEDICALIMAGING_METALOCTITLEFILTERDATA',pic:''},{av:'AV58BR_MedicalImaging_MetaDateTitleFilterData',fld:'vBR_MEDICALIMAGING_METADATETITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_MedicalImaging_ID_Titleformat',ctrl:'BR_MEDICALIMAGING_ID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ID_Title',ctrl:'BR_MEDICALIMAGING_ID',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDate_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDate_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageAge_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageAge_Title',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageOrgan_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageOrgan_Title',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_PreImageDiag_Titleformat',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Titleformat'},{av:'edtBR_MedicalImaging_PreImageDiag_Title',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDes_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDes_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Title'},{av:'edtBR_MedicalImaging_TumorSize_Titleformat',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_TumorSize_Title',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHtml_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHtml_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Title'},{av:'cmbBR_MedicalImaging_MetastasesDX'},{av:'edtBR_MedicalImaging_MetaLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaLoc_Title',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Title'},{av:'edtBR_MedicalImaging_MetaDate_Titleformat',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaDate_Title',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_IMAGELOC.ONOPTIONCLICKED","{handler:'E235L2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAME_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSP_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOC_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_PREIMAGEDIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDESTITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_TUMORSIZETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHTMLTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METADATETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medicalimaging_imageloc_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_IMAGELOC',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_IMAGELOC.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_imageloc_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGELOC',prop:'SortedStatus'},{av:'AV13BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_MedicalImaging_IDTitleFilterData',fld:'vBR_MEDICALIMAGING_IDTITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV48BR_MedicalImaging_ImageName_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAME_CODETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{av:'AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSP_CODETITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV29BR_MedicalImaging_ImageLocTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOCTITLEFILTERDATA',pic:''},{av:'AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOC_CODETITLEFILTERDATA',pic:''},{av:'AV31BR_MedicalImaging_ImageOrganTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEORGANTITLEFILTERDATA',pic:''},{av:'AV33BR_MedicalImaging_PreImageDiagTitleFilterData',fld:'vBR_MEDICALIMAGING_PREIMAGEDIAGTITLEFILTERDATA',pic:''},{av:'AV35BR_MedicalImaging_ImageDesTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDESTITLEFILTERDATA',pic:''},{av:'AV37BR_MedicalImaging_TumorSizeTitleFilterData',fld:'vBR_MEDICALIMAGING_TUMORSIZETITLEFILTERDATA',pic:''},{av:'AV46BR_MedicalImaging_ImageHtmlTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHTMLTITLEFILTERDATA',pic:''},{av:'AV54BR_MedicalImaging_MetastasesDXTitleFilterData',fld:'vBR_MEDICALIMAGING_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV56BR_MedicalImaging_MetaLocTitleFilterData',fld:'vBR_MEDICALIMAGING_METALOCTITLEFILTERDATA',pic:''},{av:'AV58BR_MedicalImaging_MetaDateTitleFilterData',fld:'vBR_MEDICALIMAGING_METADATETITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_MedicalImaging_ID_Titleformat',ctrl:'BR_MEDICALIMAGING_ID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ID_Title',ctrl:'BR_MEDICALIMAGING_ID',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDate_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDate_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageAge_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageAge_Title',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageOrgan_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageOrgan_Title',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_PreImageDiag_Titleformat',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Titleformat'},{av:'edtBR_MedicalImaging_PreImageDiag_Title',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDes_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDes_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Title'},{av:'edtBR_MedicalImaging_TumorSize_Titleformat',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_TumorSize_Title',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHtml_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHtml_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Title'},{av:'cmbBR_MedicalImaging_MetastasesDX'},{av:'edtBR_MedicalImaging_MetaLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaLoc_Title',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Title'},{av:'edtBR_MedicalImaging_MetaDate_Titleformat',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaDate_Title',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_IMAGELOC_CODE.ONOPTIONCLICKED","{handler:'E245L2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAME_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSP_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOC_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_PREIMAGEDIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDESTITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_TUMORSIZETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHTMLTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METADATETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medicalimaging_imageloc_code_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_IMAGELOC_CODE.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_imageloc_code_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'SortedStatus'},{av:'AV13BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_MedicalImaging_IDTitleFilterData',fld:'vBR_MEDICALIMAGING_IDTITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV48BR_MedicalImaging_ImageName_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAME_CODETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{av:'AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSP_CODETITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV29BR_MedicalImaging_ImageLocTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOCTITLEFILTERDATA',pic:''},{av:'AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOC_CODETITLEFILTERDATA',pic:''},{av:'AV31BR_MedicalImaging_ImageOrganTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEORGANTITLEFILTERDATA',pic:''},{av:'AV33BR_MedicalImaging_PreImageDiagTitleFilterData',fld:'vBR_MEDICALIMAGING_PREIMAGEDIAGTITLEFILTERDATA',pic:''},{av:'AV35BR_MedicalImaging_ImageDesTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDESTITLEFILTERDATA',pic:''},{av:'AV37BR_MedicalImaging_TumorSizeTitleFilterData',fld:'vBR_MEDICALIMAGING_TUMORSIZETITLEFILTERDATA',pic:''},{av:'AV46BR_MedicalImaging_ImageHtmlTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHTMLTITLEFILTERDATA',pic:''},{av:'AV54BR_MedicalImaging_MetastasesDXTitleFilterData',fld:'vBR_MEDICALIMAGING_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV56BR_MedicalImaging_MetaLocTitleFilterData',fld:'vBR_MEDICALIMAGING_METALOCTITLEFILTERDATA',pic:''},{av:'AV58BR_MedicalImaging_MetaDateTitleFilterData',fld:'vBR_MEDICALIMAGING_METADATETITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_MedicalImaging_ID_Titleformat',ctrl:'BR_MEDICALIMAGING_ID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ID_Title',ctrl:'BR_MEDICALIMAGING_ID',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDate_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDate_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageAge_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageAge_Title',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageOrgan_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageOrgan_Title',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_PreImageDiag_Titleformat',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Titleformat'},{av:'edtBR_MedicalImaging_PreImageDiag_Title',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDes_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDes_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Title'},{av:'edtBR_MedicalImaging_TumorSize_Titleformat',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_TumorSize_Title',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHtml_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHtml_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Title'},{av:'cmbBR_MedicalImaging_MetastasesDX'},{av:'edtBR_MedicalImaging_MetaLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaLoc_Title',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Title'},{av:'edtBR_MedicalImaging_MetaDate_Titleformat',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaDate_Title',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_IMAGEORGAN.ONOPTIONCLICKED","{handler:'E255L2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAME_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSP_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOC_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_PREIMAGEDIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDESTITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_TUMORSIZETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHTMLTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METADATETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medicalimaging_imageorgan_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEORGAN',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_IMAGEORGAN.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_imageorgan_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEORGAN',prop:'SortedStatus'},{av:'AV13BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_MedicalImaging_IDTitleFilterData',fld:'vBR_MEDICALIMAGING_IDTITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV48BR_MedicalImaging_ImageName_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAME_CODETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{av:'AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSP_CODETITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV29BR_MedicalImaging_ImageLocTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOCTITLEFILTERDATA',pic:''},{av:'AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOC_CODETITLEFILTERDATA',pic:''},{av:'AV31BR_MedicalImaging_ImageOrganTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEORGANTITLEFILTERDATA',pic:''},{av:'AV33BR_MedicalImaging_PreImageDiagTitleFilterData',fld:'vBR_MEDICALIMAGING_PREIMAGEDIAGTITLEFILTERDATA',pic:''},{av:'AV35BR_MedicalImaging_ImageDesTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDESTITLEFILTERDATA',pic:''},{av:'AV37BR_MedicalImaging_TumorSizeTitleFilterData',fld:'vBR_MEDICALIMAGING_TUMORSIZETITLEFILTERDATA',pic:''},{av:'AV46BR_MedicalImaging_ImageHtmlTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHTMLTITLEFILTERDATA',pic:''},{av:'AV54BR_MedicalImaging_MetastasesDXTitleFilterData',fld:'vBR_MEDICALIMAGING_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV56BR_MedicalImaging_MetaLocTitleFilterData',fld:'vBR_MEDICALIMAGING_METALOCTITLEFILTERDATA',pic:''},{av:'AV58BR_MedicalImaging_MetaDateTitleFilterData',fld:'vBR_MEDICALIMAGING_METADATETITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_MedicalImaging_ID_Titleformat',ctrl:'BR_MEDICALIMAGING_ID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ID_Title',ctrl:'BR_MEDICALIMAGING_ID',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDate_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDate_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageAge_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageAge_Title',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageOrgan_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageOrgan_Title',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_PreImageDiag_Titleformat',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Titleformat'},{av:'edtBR_MedicalImaging_PreImageDiag_Title',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDes_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDes_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Title'},{av:'edtBR_MedicalImaging_TumorSize_Titleformat',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_TumorSize_Title',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHtml_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHtml_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Title'},{av:'cmbBR_MedicalImaging_MetastasesDX'},{av:'edtBR_MedicalImaging_MetaLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaLoc_Title',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Title'},{av:'edtBR_MedicalImaging_MetaDate_Titleformat',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaDate_Title',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_PREIMAGEDIAG.ONOPTIONCLICKED","{handler:'E265L2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAME_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSP_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOC_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_PREIMAGEDIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDESTITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_TUMORSIZETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHTMLTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METADATETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medicalimaging_preimagediag_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_PREIMAGEDIAG.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_preimagediag_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'SortedStatus'},{av:'AV13BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_MedicalImaging_IDTitleFilterData',fld:'vBR_MEDICALIMAGING_IDTITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV48BR_MedicalImaging_ImageName_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAME_CODETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{av:'AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSP_CODETITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV29BR_MedicalImaging_ImageLocTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOCTITLEFILTERDATA',pic:''},{av:'AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOC_CODETITLEFILTERDATA',pic:''},{av:'AV31BR_MedicalImaging_ImageOrganTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEORGANTITLEFILTERDATA',pic:''},{av:'AV33BR_MedicalImaging_PreImageDiagTitleFilterData',fld:'vBR_MEDICALIMAGING_PREIMAGEDIAGTITLEFILTERDATA',pic:''},{av:'AV35BR_MedicalImaging_ImageDesTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDESTITLEFILTERDATA',pic:''},{av:'AV37BR_MedicalImaging_TumorSizeTitleFilterData',fld:'vBR_MEDICALIMAGING_TUMORSIZETITLEFILTERDATA',pic:''},{av:'AV46BR_MedicalImaging_ImageHtmlTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHTMLTITLEFILTERDATA',pic:''},{av:'AV54BR_MedicalImaging_MetastasesDXTitleFilterData',fld:'vBR_MEDICALIMAGING_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV56BR_MedicalImaging_MetaLocTitleFilterData',fld:'vBR_MEDICALIMAGING_METALOCTITLEFILTERDATA',pic:''},{av:'AV58BR_MedicalImaging_MetaDateTitleFilterData',fld:'vBR_MEDICALIMAGING_METADATETITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_MedicalImaging_ID_Titleformat',ctrl:'BR_MEDICALIMAGING_ID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ID_Title',ctrl:'BR_MEDICALIMAGING_ID',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDate_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDate_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageAge_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageAge_Title',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageOrgan_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageOrgan_Title',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_PreImageDiag_Titleformat',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Titleformat'},{av:'edtBR_MedicalImaging_PreImageDiag_Title',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDes_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDes_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Title'},{av:'edtBR_MedicalImaging_TumorSize_Titleformat',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_TumorSize_Title',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHtml_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHtml_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Title'},{av:'cmbBR_MedicalImaging_MetastasesDX'},{av:'edtBR_MedicalImaging_MetaLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaLoc_Title',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Title'},{av:'edtBR_MedicalImaging_MetaDate_Titleformat',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaDate_Title',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_IMAGEDES.ONOPTIONCLICKED","{handler:'E275L2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAME_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSP_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOC_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_PREIMAGEDIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDESTITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_TUMORSIZETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHTMLTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METADATETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medicalimaging_imagedes_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEDES',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_IMAGEDES.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_imagedes_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEDES',prop:'SortedStatus'},{av:'AV13BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_MedicalImaging_IDTitleFilterData',fld:'vBR_MEDICALIMAGING_IDTITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV48BR_MedicalImaging_ImageName_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAME_CODETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{av:'AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSP_CODETITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV29BR_MedicalImaging_ImageLocTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOCTITLEFILTERDATA',pic:''},{av:'AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOC_CODETITLEFILTERDATA',pic:''},{av:'AV31BR_MedicalImaging_ImageOrganTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEORGANTITLEFILTERDATA',pic:''},{av:'AV33BR_MedicalImaging_PreImageDiagTitleFilterData',fld:'vBR_MEDICALIMAGING_PREIMAGEDIAGTITLEFILTERDATA',pic:''},{av:'AV35BR_MedicalImaging_ImageDesTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDESTITLEFILTERDATA',pic:''},{av:'AV37BR_MedicalImaging_TumorSizeTitleFilterData',fld:'vBR_MEDICALIMAGING_TUMORSIZETITLEFILTERDATA',pic:''},{av:'AV46BR_MedicalImaging_ImageHtmlTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHTMLTITLEFILTERDATA',pic:''},{av:'AV54BR_MedicalImaging_MetastasesDXTitleFilterData',fld:'vBR_MEDICALIMAGING_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV56BR_MedicalImaging_MetaLocTitleFilterData',fld:'vBR_MEDICALIMAGING_METALOCTITLEFILTERDATA',pic:''},{av:'AV58BR_MedicalImaging_MetaDateTitleFilterData',fld:'vBR_MEDICALIMAGING_METADATETITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_MedicalImaging_ID_Titleformat',ctrl:'BR_MEDICALIMAGING_ID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ID_Title',ctrl:'BR_MEDICALIMAGING_ID',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDate_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDate_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageAge_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageAge_Title',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageOrgan_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageOrgan_Title',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_PreImageDiag_Titleformat',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Titleformat'},{av:'edtBR_MedicalImaging_PreImageDiag_Title',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDes_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDes_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Title'},{av:'edtBR_MedicalImaging_TumorSize_Titleformat',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_TumorSize_Title',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHtml_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHtml_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Title'},{av:'cmbBR_MedicalImaging_MetastasesDX'},{av:'edtBR_MedicalImaging_MetaLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaLoc_Title',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Title'},{av:'edtBR_MedicalImaging_MetaDate_Titleformat',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaDate_Title',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_TUMORSIZE.ONOPTIONCLICKED","{handler:'E285L2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAME_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSP_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOC_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_PREIMAGEDIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDESTITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_TUMORSIZETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHTMLTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METADATETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medicalimaging_tumorsize_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_TUMORSIZE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_TUMORSIZE.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_tumorsize_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_TUMORSIZE',prop:'SortedStatus'},{av:'AV13BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_MedicalImaging_IDTitleFilterData',fld:'vBR_MEDICALIMAGING_IDTITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV48BR_MedicalImaging_ImageName_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAME_CODETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{av:'AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSP_CODETITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV29BR_MedicalImaging_ImageLocTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOCTITLEFILTERDATA',pic:''},{av:'AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOC_CODETITLEFILTERDATA',pic:''},{av:'AV31BR_MedicalImaging_ImageOrganTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEORGANTITLEFILTERDATA',pic:''},{av:'AV33BR_MedicalImaging_PreImageDiagTitleFilterData',fld:'vBR_MEDICALIMAGING_PREIMAGEDIAGTITLEFILTERDATA',pic:''},{av:'AV35BR_MedicalImaging_ImageDesTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDESTITLEFILTERDATA',pic:''},{av:'AV37BR_MedicalImaging_TumorSizeTitleFilterData',fld:'vBR_MEDICALIMAGING_TUMORSIZETITLEFILTERDATA',pic:''},{av:'AV46BR_MedicalImaging_ImageHtmlTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHTMLTITLEFILTERDATA',pic:''},{av:'AV54BR_MedicalImaging_MetastasesDXTitleFilterData',fld:'vBR_MEDICALIMAGING_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV56BR_MedicalImaging_MetaLocTitleFilterData',fld:'vBR_MEDICALIMAGING_METALOCTITLEFILTERDATA',pic:''},{av:'AV58BR_MedicalImaging_MetaDateTitleFilterData',fld:'vBR_MEDICALIMAGING_METADATETITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_MedicalImaging_ID_Titleformat',ctrl:'BR_MEDICALIMAGING_ID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ID_Title',ctrl:'BR_MEDICALIMAGING_ID',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDate_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDate_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageAge_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageAge_Title',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageOrgan_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageOrgan_Title',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_PreImageDiag_Titleformat',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Titleformat'},{av:'edtBR_MedicalImaging_PreImageDiag_Title',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDes_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDes_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Title'},{av:'edtBR_MedicalImaging_TumorSize_Titleformat',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_TumorSize_Title',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHtml_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHtml_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Title'},{av:'cmbBR_MedicalImaging_MetastasesDX'},{av:'edtBR_MedicalImaging_MetaLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaLoc_Title',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Title'},{av:'edtBR_MedicalImaging_MetaDate_Titleformat',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaDate_Title',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_IMAGEHTML.ONOPTIONCLICKED","{handler:'E295L2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAME_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSP_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOC_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_PREIMAGEDIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDESTITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_TUMORSIZETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHTMLTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METADATETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medicalimaging_imagehtml_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEHTML',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_IMAGEHTML.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_imagehtml_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEHTML',prop:'SortedStatus'},{av:'AV13BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_MedicalImaging_IDTitleFilterData',fld:'vBR_MEDICALIMAGING_IDTITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV48BR_MedicalImaging_ImageName_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAME_CODETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{av:'AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSP_CODETITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV29BR_MedicalImaging_ImageLocTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOCTITLEFILTERDATA',pic:''},{av:'AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOC_CODETITLEFILTERDATA',pic:''},{av:'AV31BR_MedicalImaging_ImageOrganTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEORGANTITLEFILTERDATA',pic:''},{av:'AV33BR_MedicalImaging_PreImageDiagTitleFilterData',fld:'vBR_MEDICALIMAGING_PREIMAGEDIAGTITLEFILTERDATA',pic:''},{av:'AV35BR_MedicalImaging_ImageDesTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDESTITLEFILTERDATA',pic:''},{av:'AV37BR_MedicalImaging_TumorSizeTitleFilterData',fld:'vBR_MEDICALIMAGING_TUMORSIZETITLEFILTERDATA',pic:''},{av:'AV46BR_MedicalImaging_ImageHtmlTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHTMLTITLEFILTERDATA',pic:''},{av:'AV54BR_MedicalImaging_MetastasesDXTitleFilterData',fld:'vBR_MEDICALIMAGING_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV56BR_MedicalImaging_MetaLocTitleFilterData',fld:'vBR_MEDICALIMAGING_METALOCTITLEFILTERDATA',pic:''},{av:'AV58BR_MedicalImaging_MetaDateTitleFilterData',fld:'vBR_MEDICALIMAGING_METADATETITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_MedicalImaging_ID_Titleformat',ctrl:'BR_MEDICALIMAGING_ID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ID_Title',ctrl:'BR_MEDICALIMAGING_ID',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDate_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDate_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageAge_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageAge_Title',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageOrgan_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageOrgan_Title',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_PreImageDiag_Titleformat',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Titleformat'},{av:'edtBR_MedicalImaging_PreImageDiag_Title',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDes_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDes_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Title'},{av:'edtBR_MedicalImaging_TumorSize_Titleformat',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_TumorSize_Title',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHtml_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHtml_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Title'},{av:'cmbBR_MedicalImaging_MetastasesDX'},{av:'edtBR_MedicalImaging_MetaLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaLoc_Title',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Title'},{av:'edtBR_MedicalImaging_MetaDate_Titleformat',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaDate_Title',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_METASTASESDX.ONOPTIONCLICKED","{handler:'E305L2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAME_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSP_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOC_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_PREIMAGEDIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDESTITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_TUMORSIZETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHTMLTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METADATETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medicalimaging_metastasesdx_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_METASTASESDX',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_METASTASESDX.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_metastasesdx_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_METASTASESDX',prop:'SortedStatus'},{av:'AV13BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_MedicalImaging_IDTitleFilterData',fld:'vBR_MEDICALIMAGING_IDTITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV48BR_MedicalImaging_ImageName_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAME_CODETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{av:'AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSP_CODETITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV29BR_MedicalImaging_ImageLocTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOCTITLEFILTERDATA',pic:''},{av:'AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOC_CODETITLEFILTERDATA',pic:''},{av:'AV31BR_MedicalImaging_ImageOrganTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEORGANTITLEFILTERDATA',pic:''},{av:'AV33BR_MedicalImaging_PreImageDiagTitleFilterData',fld:'vBR_MEDICALIMAGING_PREIMAGEDIAGTITLEFILTERDATA',pic:''},{av:'AV35BR_MedicalImaging_ImageDesTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDESTITLEFILTERDATA',pic:''},{av:'AV37BR_MedicalImaging_TumorSizeTitleFilterData',fld:'vBR_MEDICALIMAGING_TUMORSIZETITLEFILTERDATA',pic:''},{av:'AV46BR_MedicalImaging_ImageHtmlTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHTMLTITLEFILTERDATA',pic:''},{av:'AV54BR_MedicalImaging_MetastasesDXTitleFilterData',fld:'vBR_MEDICALIMAGING_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV56BR_MedicalImaging_MetaLocTitleFilterData',fld:'vBR_MEDICALIMAGING_METALOCTITLEFILTERDATA',pic:''},{av:'AV58BR_MedicalImaging_MetaDateTitleFilterData',fld:'vBR_MEDICALIMAGING_METADATETITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_MedicalImaging_ID_Titleformat',ctrl:'BR_MEDICALIMAGING_ID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ID_Title',ctrl:'BR_MEDICALIMAGING_ID',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDate_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDate_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageAge_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageAge_Title',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageOrgan_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageOrgan_Title',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_PreImageDiag_Titleformat',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Titleformat'},{av:'edtBR_MedicalImaging_PreImageDiag_Title',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDes_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDes_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Title'},{av:'edtBR_MedicalImaging_TumorSize_Titleformat',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_TumorSize_Title',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHtml_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHtml_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Title'},{av:'cmbBR_MedicalImaging_MetastasesDX'},{av:'edtBR_MedicalImaging_MetaLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaLoc_Title',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Title'},{av:'edtBR_MedicalImaging_MetaDate_Titleformat',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaDate_Title',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_METALOC.ONOPTIONCLICKED","{handler:'E315L2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAME_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSP_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOC_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_PREIMAGEDIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDESTITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_TUMORSIZETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHTMLTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METADATETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medicalimaging_metaloc_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_METALOC',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_METALOC.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_metaloc_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_METALOC',prop:'SortedStatus'},{av:'AV13BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_MedicalImaging_IDTitleFilterData',fld:'vBR_MEDICALIMAGING_IDTITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV48BR_MedicalImaging_ImageName_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAME_CODETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{av:'AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSP_CODETITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV29BR_MedicalImaging_ImageLocTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOCTITLEFILTERDATA',pic:''},{av:'AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOC_CODETITLEFILTERDATA',pic:''},{av:'AV31BR_MedicalImaging_ImageOrganTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEORGANTITLEFILTERDATA',pic:''},{av:'AV33BR_MedicalImaging_PreImageDiagTitleFilterData',fld:'vBR_MEDICALIMAGING_PREIMAGEDIAGTITLEFILTERDATA',pic:''},{av:'AV35BR_MedicalImaging_ImageDesTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDESTITLEFILTERDATA',pic:''},{av:'AV37BR_MedicalImaging_TumorSizeTitleFilterData',fld:'vBR_MEDICALIMAGING_TUMORSIZETITLEFILTERDATA',pic:''},{av:'AV46BR_MedicalImaging_ImageHtmlTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHTMLTITLEFILTERDATA',pic:''},{av:'AV54BR_MedicalImaging_MetastasesDXTitleFilterData',fld:'vBR_MEDICALIMAGING_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV56BR_MedicalImaging_MetaLocTitleFilterData',fld:'vBR_MEDICALIMAGING_METALOCTITLEFILTERDATA',pic:''},{av:'AV58BR_MedicalImaging_MetaDateTitleFilterData',fld:'vBR_MEDICALIMAGING_METADATETITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_MedicalImaging_ID_Titleformat',ctrl:'BR_MEDICALIMAGING_ID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ID_Title',ctrl:'BR_MEDICALIMAGING_ID',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDate_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDate_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageAge_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageAge_Title',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageOrgan_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageOrgan_Title',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_PreImageDiag_Titleformat',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Titleformat'},{av:'edtBR_MedicalImaging_PreImageDiag_Title',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDes_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDes_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Title'},{av:'edtBR_MedicalImaging_TumorSize_Titleformat',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_TumorSize_Title',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHtml_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHtml_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Title'},{av:'cmbBR_MedicalImaging_MetastasesDX'},{av:'edtBR_MedicalImaging_MetaLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaLoc_Title',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Title'},{av:'edtBR_MedicalImaging_MetaDate_Titleformat',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaDate_Title',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_METADATE.ONOPTIONCLICKED","{handler:'E325L2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAME_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSP_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGELOC_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEORGANTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_PREIMAGEDIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDESTITLECONTROLIDTOREPLACE',pic:''},{av:'AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_TUMORSIZETITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHTMLTITLECONTROLIDTOREPLACE',pic:''},{av:'AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_METADATETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medicalimaging_metadate_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_METADATE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_METADATE.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_metadate_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_METADATE',prop:'SortedStatus'},{av:'AV13BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV19BR_MedicalImaging_IDTitleFilterData',fld:'vBR_MEDICALIMAGING_IDTITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV48BR_MedicalImaging_ImageName_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAME_CODETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{av:'AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSP_CODETITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV29BR_MedicalImaging_ImageLocTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOCTITLEFILTERDATA',pic:''},{av:'AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGELOC_CODETITLEFILTERDATA',pic:''},{av:'AV31BR_MedicalImaging_ImageOrganTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEORGANTITLEFILTERDATA',pic:''},{av:'AV33BR_MedicalImaging_PreImageDiagTitleFilterData',fld:'vBR_MEDICALIMAGING_PREIMAGEDIAGTITLEFILTERDATA',pic:''},{av:'AV35BR_MedicalImaging_ImageDesTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDESTITLEFILTERDATA',pic:''},{av:'AV37BR_MedicalImaging_TumorSizeTitleFilterData',fld:'vBR_MEDICALIMAGING_TUMORSIZETITLEFILTERDATA',pic:''},{av:'AV46BR_MedicalImaging_ImageHtmlTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHTMLTITLEFILTERDATA',pic:''},{av:'AV54BR_MedicalImaging_MetastasesDXTitleFilterData',fld:'vBR_MEDICALIMAGING_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV56BR_MedicalImaging_MetaLocTitleFilterData',fld:'vBR_MEDICALIMAGING_METALOCTITLEFILTERDATA',pic:''},{av:'AV58BR_MedicalImaging_MetaDateTitleFilterData',fld:'vBR_MEDICALIMAGING_METADATETITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_MedicalImaging_ID_Titleformat',ctrl:'BR_MEDICALIMAGING_ID',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ID_Title',ctrl:'BR_MEDICALIMAGING_ID',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDate_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDate_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageAge_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageAge_Title',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC',prop:'Title'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageLoc_Code_Title',ctrl:'BR_MEDICALIMAGING_IMAGELOC_CODE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageOrgan_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageOrgan_Title',ctrl:'BR_MEDICALIMAGING_IMAGEORGAN',prop:'Title'},{av:'edtBR_MedicalImaging_PreImageDiag_Titleformat',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Titleformat'},{av:'edtBR_MedicalImaging_PreImageDiag_Title',ctrl:'BR_MEDICALIMAGING_PREIMAGEDIAG',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDes_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDes_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDES',prop:'Title'},{av:'edtBR_MedicalImaging_TumorSize_Titleformat',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_TumorSize_Title',ctrl:'BR_MEDICALIMAGING_TUMORSIZE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHtml_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHtml_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHTML',prop:'Title'},{av:'cmbBR_MedicalImaging_MetastasesDX'},{av:'edtBR_MedicalImaging_MetaLoc_Titleformat',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaLoc_Title',ctrl:'BR_MEDICALIMAGING_METALOC',prop:'Title'},{av:'edtBR_MedicalImaging_MetaDate_Titleformat',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_MetaDate_Title',ctrl:'BR_MEDICALIMAGING_METADATE',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E355L2',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV44Select',fld:'vSELECT',pic:''},{av:'edtavSelect_Tooltiptext',ctrl:'vSELECT',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E365L2',iparms:[{av:'A225BR_MedicalImagingID',fld:'BR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A228BR_MedicalImaging_ImageName',fld:'BR_MEDICALIMAGING_IMAGENAME',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV8InOutBR_MedicalImagingID',fld:'vINOUTBR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV45InOutBR_MedicalImaging_ImageName',fld:'vINOUTBR_MEDICALIMAGING_IMAGENAME',pic:''}]}");
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
         wcpOAV45InOutBR_MedicalImaging_ImageName = "";
         Gridpaginationbar_Selectedpage = "";
         Ddo_br_medicalimagingid_Activeeventkey = "";
         Ddo_br_encounterid_Activeeventkey = "";
         Ddo_br_information_patientno_Activeeventkey = "";
         Ddo_br_medicalimaging_id_Activeeventkey = "";
         Ddo_br_medicalimaging_imagename_Activeeventkey = "";
         Ddo_br_medicalimaging_imagename_code_Activeeventkey = "";
         Ddo_br_medicalimaging_imagedate_Activeeventkey = "";
         Ddo_br_medicalimaging_imagehosp_Activeeventkey = "";
         Ddo_br_medicalimaging_imagehosp_code_Activeeventkey = "";
         Ddo_br_medicalimaging_imageage_Activeeventkey = "";
         Ddo_br_medicalimaging_imageloc_Activeeventkey = "";
         Ddo_br_medicalimaging_imageloc_code_Activeeventkey = "";
         Ddo_br_medicalimaging_imageorgan_Activeeventkey = "";
         Ddo_br_medicalimaging_preimagediag_Activeeventkey = "";
         Ddo_br_medicalimaging_imagedes_Activeeventkey = "";
         Ddo_br_medicalimaging_tumorsize_Activeeventkey = "";
         Ddo_br_medicalimaging_imagehtml_Activeeventkey = "";
         Ddo_br_medicalimaging_metastasesdx_Activeeventkey = "";
         Ddo_br_medicalimaging_metaloc_Activeeventkey = "";
         Ddo_br_medicalimaging_metadate_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace = "";
         AV16ddo_BR_EncounterIDTitleControlIdToReplace = "";
         AV18ddo_BR_Information_PatientNoTitleControlIdToReplace = "";
         AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace = "";
         AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace = "";
         AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace = "";
         AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace = "";
         AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace = "";
         AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace = "";
         AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace = "";
         AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace = "";
         AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace = "";
         AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace = "";
         AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace = "";
         AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace = "";
         AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace = "";
         AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace = "";
         AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace = "";
         AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace = "";
         AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace = "";
         GXKey = "";
         AV62Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV39DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV13BR_MedicalImagingIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17BR_Information_PatientNoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19BR_MedicalImaging_IDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_MedicalImaging_ImageNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV48BR_MedicalImaging_ImageName_CodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV23BR_MedicalImaging_ImageDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV25BR_MedicalImaging_ImageHospTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV27BR_MedicalImaging_ImageAgeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV29BR_MedicalImaging_ImageLocTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV31BR_MedicalImaging_ImageOrganTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV33BR_MedicalImaging_PreImageDiagTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV35BR_MedicalImaging_ImageDesTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV37BR_MedicalImaging_TumorSizeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV46BR_MedicalImaging_ImageHtmlTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV54BR_MedicalImaging_MetastasesDXTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV56BR_MedicalImaging_MetaLocTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV58BR_MedicalImaging_MetaDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_medicalimagingid_Sortedstatus = "";
         Ddo_br_encounterid_Sortedstatus = "";
         Ddo_br_information_patientno_Sortedstatus = "";
         Ddo_br_medicalimaging_id_Sortedstatus = "";
         Ddo_br_medicalimaging_imagename_Sortedstatus = "";
         Ddo_br_medicalimaging_imagename_code_Sortedstatus = "";
         Ddo_br_medicalimaging_imagedate_Sortedstatus = "";
         Ddo_br_medicalimaging_imagehosp_Sortedstatus = "";
         Ddo_br_medicalimaging_imagehosp_code_Sortedstatus = "";
         Ddo_br_medicalimaging_imageage_Sortedstatus = "";
         Ddo_br_medicalimaging_imageloc_Sortedstatus = "";
         Ddo_br_medicalimaging_imageloc_code_Sortedstatus = "";
         Ddo_br_medicalimaging_imageorgan_Sortedstatus = "";
         Ddo_br_medicalimaging_preimagediag_Sortedstatus = "";
         Ddo_br_medicalimaging_imagedes_Sortedstatus = "";
         Ddo_br_medicalimaging_tumorsize_Sortedstatus = "";
         Ddo_br_medicalimaging_imagehtml_Sortedstatus = "";
         Ddo_br_medicalimaging_metastasesdx_Sortedstatus = "";
         Ddo_br_medicalimaging_metaloc_Sortedstatus = "";
         Ddo_br_medicalimaging_metadate_Sortedstatus = "";
         GX_FocusControl = "";
         sPrefix = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV44Select = "";
         A36BR_Information_PatientNo = "";
         A228BR_MedicalImaging_ImageName = "";
         A484BR_MedicalImaging_ImageName_Code = "";
         A229BR_MedicalImaging_ImageDate = DateTime.MinValue;
         A230BR_MedicalImaging_ImageHosp = "";
         A485BR_MedicalImaging_ImageHosp_Code = "";
         A232BR_MedicalImaging_ImageLoc = "";
         A486BR_MedicalImaging_ImageLoc_Code = "";
         A233BR_MedicalImaging_ImageOrgan = "";
         A234BR_MedicalImaging_PreImageDiag = "";
         A235BR_MedicalImaging_ImageDes = "";
         A236BR_MedicalImaging_TumorSize = "";
         A334BR_MedicalImaging_ImageHtml = "";
         A514BR_MedicalImaging_MetastasesDX = "";
         A515BR_MedicalImaging_MetaLoc = "";
         A516BR_MedicalImaging_MetaDate = DateTime.MinValue;
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_medicalimagingid = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_br_encounterid = new GXUserControl();
         ucDdo_br_information_patientno = new GXUserControl();
         ucDdo_br_medicalimaging_id = new GXUserControl();
         ucDdo_br_medicalimaging_imagename = new GXUserControl();
         ucDdo_br_medicalimaging_imagename_code = new GXUserControl();
         ucDdo_br_medicalimaging_imagedate = new GXUserControl();
         ucDdo_br_medicalimaging_imagehosp = new GXUserControl();
         ucDdo_br_medicalimaging_imagehosp_code = new GXUserControl();
         ucDdo_br_medicalimaging_imageage = new GXUserControl();
         ucDdo_br_medicalimaging_imageloc = new GXUserControl();
         ucDdo_br_medicalimaging_imageloc_code = new GXUserControl();
         ucDdo_br_medicalimaging_imageorgan = new GXUserControl();
         ucDdo_br_medicalimaging_preimagediag = new GXUserControl();
         ucDdo_br_medicalimaging_imagedes = new GXUserControl();
         ucDdo_br_medicalimaging_tumorsize = new GXUserControl();
         ucDdo_br_medicalimaging_imagehtml = new GXUserControl();
         ucDdo_br_medicalimaging_metastasesdx = new GXUserControl();
         ucDdo_br_medicalimaging_metaloc = new GXUserControl();
         ucDdo_br_medicalimaging_metadate = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV63Select_GXI = "";
         scmdbuf = "";
         H005L2_A85BR_Information_ID = new long[1] ;
         H005L2_n85BR_Information_ID = new bool[] {false} ;
         H005L2_A516BR_MedicalImaging_MetaDate = new DateTime[] {DateTime.MinValue} ;
         H005L2_n516BR_MedicalImaging_MetaDate = new bool[] {false} ;
         H005L2_A515BR_MedicalImaging_MetaLoc = new String[] {""} ;
         H005L2_n515BR_MedicalImaging_MetaLoc = new bool[] {false} ;
         H005L2_A514BR_MedicalImaging_MetastasesDX = new String[] {""} ;
         H005L2_n514BR_MedicalImaging_MetastasesDX = new bool[] {false} ;
         H005L2_A334BR_MedicalImaging_ImageHtml = new String[] {""} ;
         H005L2_n334BR_MedicalImaging_ImageHtml = new bool[] {false} ;
         H005L2_A236BR_MedicalImaging_TumorSize = new String[] {""} ;
         H005L2_n236BR_MedicalImaging_TumorSize = new bool[] {false} ;
         H005L2_A235BR_MedicalImaging_ImageDes = new String[] {""} ;
         H005L2_n235BR_MedicalImaging_ImageDes = new bool[] {false} ;
         H005L2_A234BR_MedicalImaging_PreImageDiag = new String[] {""} ;
         H005L2_n234BR_MedicalImaging_PreImageDiag = new bool[] {false} ;
         H005L2_A233BR_MedicalImaging_ImageOrgan = new String[] {""} ;
         H005L2_n233BR_MedicalImaging_ImageOrgan = new bool[] {false} ;
         H005L2_A486BR_MedicalImaging_ImageLoc_Code = new String[] {""} ;
         H005L2_n486BR_MedicalImaging_ImageLoc_Code = new bool[] {false} ;
         H005L2_A232BR_MedicalImaging_ImageLoc = new String[] {""} ;
         H005L2_n232BR_MedicalImaging_ImageLoc = new bool[] {false} ;
         H005L2_A231BR_MedicalImaging_ImageAge = new short[1] ;
         H005L2_n231BR_MedicalImaging_ImageAge = new bool[] {false} ;
         H005L2_A485BR_MedicalImaging_ImageHosp_Code = new String[] {""} ;
         H005L2_n485BR_MedicalImaging_ImageHosp_Code = new bool[] {false} ;
         H005L2_A230BR_MedicalImaging_ImageHosp = new String[] {""} ;
         H005L2_n230BR_MedicalImaging_ImageHosp = new bool[] {false} ;
         H005L2_A229BR_MedicalImaging_ImageDate = new DateTime[] {DateTime.MinValue} ;
         H005L2_n229BR_MedicalImaging_ImageDate = new bool[] {false} ;
         H005L2_A484BR_MedicalImaging_ImageName_Code = new String[] {""} ;
         H005L2_n484BR_MedicalImaging_ImageName_Code = new bool[] {false} ;
         H005L2_A228BR_MedicalImaging_ImageName = new String[] {""} ;
         H005L2_n228BR_MedicalImaging_ImageName = new bool[] {false} ;
         H005L2_A227BR_MedicalImaging_ID = new long[1] ;
         H005L2_n227BR_MedicalImaging_ID = new bool[] {false} ;
         H005L2_A36BR_Information_PatientNo = new String[] {""} ;
         H005L2_n36BR_Information_PatientNo = new bool[] {false} ;
         H005L2_A19BR_EncounterID = new long[1] ;
         H005L2_n19BR_EncounterID = new bool[] {false} ;
         H005L2_A225BR_MedicalImagingID = new long[1] ;
         H005L3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_medicalimagingprompt__default(),
            new Object[][] {
                new Object[] {
               H005L2_A85BR_Information_ID, H005L2_n85BR_Information_ID, H005L2_A516BR_MedicalImaging_MetaDate, H005L2_n516BR_MedicalImaging_MetaDate, H005L2_A515BR_MedicalImaging_MetaLoc, H005L2_n515BR_MedicalImaging_MetaLoc, H005L2_A514BR_MedicalImaging_MetastasesDX, H005L2_n514BR_MedicalImaging_MetastasesDX, H005L2_A334BR_MedicalImaging_ImageHtml, H005L2_n334BR_MedicalImaging_ImageHtml,
               H005L2_A236BR_MedicalImaging_TumorSize, H005L2_n236BR_MedicalImaging_TumorSize, H005L2_A235BR_MedicalImaging_ImageDes, H005L2_n235BR_MedicalImaging_ImageDes, H005L2_A234BR_MedicalImaging_PreImageDiag, H005L2_n234BR_MedicalImaging_PreImageDiag, H005L2_A233BR_MedicalImaging_ImageOrgan, H005L2_n233BR_MedicalImaging_ImageOrgan, H005L2_A486BR_MedicalImaging_ImageLoc_Code, H005L2_n486BR_MedicalImaging_ImageLoc_Code,
               H005L2_A232BR_MedicalImaging_ImageLoc, H005L2_n232BR_MedicalImaging_ImageLoc, H005L2_A231BR_MedicalImaging_ImageAge, H005L2_n231BR_MedicalImaging_ImageAge, H005L2_A485BR_MedicalImaging_ImageHosp_Code, H005L2_n485BR_MedicalImaging_ImageHosp_Code, H005L2_A230BR_MedicalImaging_ImageHosp, H005L2_n230BR_MedicalImaging_ImageHosp, H005L2_A229BR_MedicalImaging_ImageDate, H005L2_n229BR_MedicalImaging_ImageDate,
               H005L2_A484BR_MedicalImaging_ImageName_Code, H005L2_n484BR_MedicalImaging_ImageName_Code, H005L2_A228BR_MedicalImaging_ImageName, H005L2_n228BR_MedicalImaging_ImageName, H005L2_A227BR_MedicalImaging_ID, H005L2_n227BR_MedicalImaging_ID, H005L2_A36BR_Information_PatientNo, H005L2_n36BR_Information_PatientNo, H005L2_A19BR_EncounterID, H005L2_n19BR_EncounterID,
               H005L2_A225BR_MedicalImagingID
               }
               , new Object[] {
               H005L3_AGRID_nRecordCount
               }
            }
         );
         AV62Pgmname = "BR_MedicalImagingPrompt";
         /* GeneXus formulas. */
         AV62Pgmname = "BR_MedicalImagingPrompt";
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
      private short edtBR_MedicalImagingID_Titleformat ;
      private short edtBR_EncounterID_Titleformat ;
      private short edtBR_Information_PatientNo_Titleformat ;
      private short edtBR_MedicalImaging_ID_Titleformat ;
      private short edtBR_MedicalImaging_ImageName_Titleformat ;
      private short edtBR_MedicalImaging_ImageName_Code_Titleformat ;
      private short edtBR_MedicalImaging_ImageDate_Titleformat ;
      private short edtBR_MedicalImaging_ImageHosp_Titleformat ;
      private short edtBR_MedicalImaging_ImageHosp_Code_Titleformat ;
      private short edtBR_MedicalImaging_ImageAge_Titleformat ;
      private short edtBR_MedicalImaging_ImageLoc_Titleformat ;
      private short edtBR_MedicalImaging_ImageLoc_Code_Titleformat ;
      private short edtBR_MedicalImaging_ImageOrgan_Titleformat ;
      private short edtBR_MedicalImaging_PreImageDiag_Titleformat ;
      private short edtBR_MedicalImaging_ImageDes_Titleformat ;
      private short edtBR_MedicalImaging_TumorSize_Titleformat ;
      private short edtBR_MedicalImaging_ImageHtml_Titleformat ;
      private short cmbBR_MedicalImaging_MetastasesDX_Titleformat ;
      private short edtBR_MedicalImaging_MetaLoc_Titleformat ;
      private short edtBR_MedicalImaging_MetaDate_Titleformat ;
      private short subGrid_Sortable ;
      private short A231BR_MedicalImaging_ImageAge ;
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
      private int edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medicalimaging_idtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medicalimaging_imagenametitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medicalimaging_imagename_codetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medicalimaging_imagedatetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medicalimaging_imagehosptitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medicalimaging_imagehosp_codetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medicalimaging_imageagetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medicalimaging_imageloctitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medicalimaging_imageloc_codetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medicalimaging_imageorgantitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medicalimaging_preimagediagtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medicalimaging_imagedestitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medicalimaging_tumorsizetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medicalimaging_imagehtmltitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medicalimaging_metastasesdxtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medicalimaging_metaloctitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medicalimaging_metadatetitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV40PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavSelect_Enabled ;
      private int edtavSelect_Visible ;
      private long AV8InOutBR_MedicalImagingID ;
      private long wcpOAV8InOutBR_MedicalImagingID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV41GridCurrentPage ;
      private long AV43GridRecordCount ;
      private long AV42GridPageSize ;
      private long A225BR_MedicalImagingID ;
      private long A19BR_EncounterID ;
      private long A227BR_MedicalImaging_ID ;
      private long GRID_nCurrentRecord ;
      private long A85BR_Information_ID ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_medicalimagingid_Activeeventkey ;
      private String Ddo_br_encounterid_Activeeventkey ;
      private String Ddo_br_information_patientno_Activeeventkey ;
      private String Ddo_br_medicalimaging_id_Activeeventkey ;
      private String Ddo_br_medicalimaging_imagename_Activeeventkey ;
      private String Ddo_br_medicalimaging_imagename_code_Activeeventkey ;
      private String Ddo_br_medicalimaging_imagedate_Activeeventkey ;
      private String Ddo_br_medicalimaging_imagehosp_Activeeventkey ;
      private String Ddo_br_medicalimaging_imagehosp_code_Activeeventkey ;
      private String Ddo_br_medicalimaging_imageage_Activeeventkey ;
      private String Ddo_br_medicalimaging_imageloc_Activeeventkey ;
      private String Ddo_br_medicalimaging_imageloc_code_Activeeventkey ;
      private String Ddo_br_medicalimaging_imageorgan_Activeeventkey ;
      private String Ddo_br_medicalimaging_preimagediag_Activeeventkey ;
      private String Ddo_br_medicalimaging_imagedes_Activeeventkey ;
      private String Ddo_br_medicalimaging_tumorsize_Activeeventkey ;
      private String Ddo_br_medicalimaging_imagehtml_Activeeventkey ;
      private String Ddo_br_medicalimaging_metastasesdx_Activeeventkey ;
      private String Ddo_br_medicalimaging_metaloc_Activeeventkey ;
      private String Ddo_br_medicalimaging_metadate_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_12_idx="0001" ;
      private String GXKey ;
      private String AV62Pgmname ;
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
      private String Ddo_br_medicalimagingid_Caption ;
      private String Ddo_br_medicalimagingid_Tooltip ;
      private String Ddo_br_medicalimagingid_Cls ;
      private String Ddo_br_medicalimagingid_Dropdownoptionstype ;
      private String Ddo_br_medicalimagingid_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimagingid_Sortedstatus ;
      private String Ddo_br_medicalimagingid_Sortasc ;
      private String Ddo_br_medicalimagingid_Sortdsc ;
      private String Ddo_br_medicalimagingid_Searchbuttontext ;
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
      private String Ddo_br_medicalimaging_id_Caption ;
      private String Ddo_br_medicalimaging_id_Tooltip ;
      private String Ddo_br_medicalimaging_id_Cls ;
      private String Ddo_br_medicalimaging_id_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_id_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_id_Sortedstatus ;
      private String Ddo_br_medicalimaging_id_Sortasc ;
      private String Ddo_br_medicalimaging_id_Sortdsc ;
      private String Ddo_br_medicalimaging_id_Searchbuttontext ;
      private String Ddo_br_medicalimaging_imagename_Caption ;
      private String Ddo_br_medicalimaging_imagename_Tooltip ;
      private String Ddo_br_medicalimaging_imagename_Cls ;
      private String Ddo_br_medicalimaging_imagename_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_imagename_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_imagename_Sortedstatus ;
      private String Ddo_br_medicalimaging_imagename_Sortasc ;
      private String Ddo_br_medicalimaging_imagename_Sortdsc ;
      private String Ddo_br_medicalimaging_imagename_Searchbuttontext ;
      private String Ddo_br_medicalimaging_imagename_code_Caption ;
      private String Ddo_br_medicalimaging_imagename_code_Tooltip ;
      private String Ddo_br_medicalimaging_imagename_code_Cls ;
      private String Ddo_br_medicalimaging_imagename_code_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_imagename_code_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_imagename_code_Sortedstatus ;
      private String Ddo_br_medicalimaging_imagename_code_Sortasc ;
      private String Ddo_br_medicalimaging_imagename_code_Sortdsc ;
      private String Ddo_br_medicalimaging_imagename_code_Searchbuttontext ;
      private String Ddo_br_medicalimaging_imagedate_Caption ;
      private String Ddo_br_medicalimaging_imagedate_Tooltip ;
      private String Ddo_br_medicalimaging_imagedate_Cls ;
      private String Ddo_br_medicalimaging_imagedate_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_imagedate_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_imagedate_Sortedstatus ;
      private String Ddo_br_medicalimaging_imagedate_Sortasc ;
      private String Ddo_br_medicalimaging_imagedate_Sortdsc ;
      private String Ddo_br_medicalimaging_imagedate_Searchbuttontext ;
      private String Ddo_br_medicalimaging_imagehosp_Caption ;
      private String Ddo_br_medicalimaging_imagehosp_Tooltip ;
      private String Ddo_br_medicalimaging_imagehosp_Cls ;
      private String Ddo_br_medicalimaging_imagehosp_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_imagehosp_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_imagehosp_Sortedstatus ;
      private String Ddo_br_medicalimaging_imagehosp_Sortasc ;
      private String Ddo_br_medicalimaging_imagehosp_Sortdsc ;
      private String Ddo_br_medicalimaging_imagehosp_Searchbuttontext ;
      private String Ddo_br_medicalimaging_imagehosp_code_Caption ;
      private String Ddo_br_medicalimaging_imagehosp_code_Tooltip ;
      private String Ddo_br_medicalimaging_imagehosp_code_Cls ;
      private String Ddo_br_medicalimaging_imagehosp_code_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_imagehosp_code_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_imagehosp_code_Sortedstatus ;
      private String Ddo_br_medicalimaging_imagehosp_code_Sortasc ;
      private String Ddo_br_medicalimaging_imagehosp_code_Sortdsc ;
      private String Ddo_br_medicalimaging_imagehosp_code_Searchbuttontext ;
      private String Ddo_br_medicalimaging_imageage_Caption ;
      private String Ddo_br_medicalimaging_imageage_Tooltip ;
      private String Ddo_br_medicalimaging_imageage_Cls ;
      private String Ddo_br_medicalimaging_imageage_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_imageage_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_imageage_Sortedstatus ;
      private String Ddo_br_medicalimaging_imageage_Sortasc ;
      private String Ddo_br_medicalimaging_imageage_Sortdsc ;
      private String Ddo_br_medicalimaging_imageage_Searchbuttontext ;
      private String Ddo_br_medicalimaging_imageloc_Caption ;
      private String Ddo_br_medicalimaging_imageloc_Tooltip ;
      private String Ddo_br_medicalimaging_imageloc_Cls ;
      private String Ddo_br_medicalimaging_imageloc_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_imageloc_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_imageloc_Sortedstatus ;
      private String Ddo_br_medicalimaging_imageloc_Sortasc ;
      private String Ddo_br_medicalimaging_imageloc_Sortdsc ;
      private String Ddo_br_medicalimaging_imageloc_Searchbuttontext ;
      private String Ddo_br_medicalimaging_imageloc_code_Caption ;
      private String Ddo_br_medicalimaging_imageloc_code_Tooltip ;
      private String Ddo_br_medicalimaging_imageloc_code_Cls ;
      private String Ddo_br_medicalimaging_imageloc_code_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_imageloc_code_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_imageloc_code_Sortedstatus ;
      private String Ddo_br_medicalimaging_imageloc_code_Sortasc ;
      private String Ddo_br_medicalimaging_imageloc_code_Sortdsc ;
      private String Ddo_br_medicalimaging_imageloc_code_Searchbuttontext ;
      private String Ddo_br_medicalimaging_imageorgan_Caption ;
      private String Ddo_br_medicalimaging_imageorgan_Tooltip ;
      private String Ddo_br_medicalimaging_imageorgan_Cls ;
      private String Ddo_br_medicalimaging_imageorgan_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_imageorgan_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_imageorgan_Sortedstatus ;
      private String Ddo_br_medicalimaging_imageorgan_Sortasc ;
      private String Ddo_br_medicalimaging_imageorgan_Sortdsc ;
      private String Ddo_br_medicalimaging_imageorgan_Searchbuttontext ;
      private String Ddo_br_medicalimaging_preimagediag_Caption ;
      private String Ddo_br_medicalimaging_preimagediag_Tooltip ;
      private String Ddo_br_medicalimaging_preimagediag_Cls ;
      private String Ddo_br_medicalimaging_preimagediag_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_preimagediag_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_preimagediag_Sortedstatus ;
      private String Ddo_br_medicalimaging_preimagediag_Sortasc ;
      private String Ddo_br_medicalimaging_preimagediag_Sortdsc ;
      private String Ddo_br_medicalimaging_preimagediag_Searchbuttontext ;
      private String Ddo_br_medicalimaging_imagedes_Caption ;
      private String Ddo_br_medicalimaging_imagedes_Tooltip ;
      private String Ddo_br_medicalimaging_imagedes_Cls ;
      private String Ddo_br_medicalimaging_imagedes_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_imagedes_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_imagedes_Sortedstatus ;
      private String Ddo_br_medicalimaging_imagedes_Sortasc ;
      private String Ddo_br_medicalimaging_imagedes_Sortdsc ;
      private String Ddo_br_medicalimaging_imagedes_Searchbuttontext ;
      private String Ddo_br_medicalimaging_tumorsize_Caption ;
      private String Ddo_br_medicalimaging_tumorsize_Tooltip ;
      private String Ddo_br_medicalimaging_tumorsize_Cls ;
      private String Ddo_br_medicalimaging_tumorsize_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_tumorsize_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_tumorsize_Sortedstatus ;
      private String Ddo_br_medicalimaging_tumorsize_Sortasc ;
      private String Ddo_br_medicalimaging_tumorsize_Sortdsc ;
      private String Ddo_br_medicalimaging_tumorsize_Searchbuttontext ;
      private String Ddo_br_medicalimaging_imagehtml_Caption ;
      private String Ddo_br_medicalimaging_imagehtml_Tooltip ;
      private String Ddo_br_medicalimaging_imagehtml_Cls ;
      private String Ddo_br_medicalimaging_imagehtml_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_imagehtml_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_imagehtml_Sortedstatus ;
      private String Ddo_br_medicalimaging_imagehtml_Sortasc ;
      private String Ddo_br_medicalimaging_imagehtml_Sortdsc ;
      private String Ddo_br_medicalimaging_imagehtml_Searchbuttontext ;
      private String Ddo_br_medicalimaging_metastasesdx_Caption ;
      private String Ddo_br_medicalimaging_metastasesdx_Tooltip ;
      private String Ddo_br_medicalimaging_metastasesdx_Cls ;
      private String Ddo_br_medicalimaging_metastasesdx_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_metastasesdx_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_metastasesdx_Sortedstatus ;
      private String Ddo_br_medicalimaging_metastasesdx_Sortasc ;
      private String Ddo_br_medicalimaging_metastasesdx_Sortdsc ;
      private String Ddo_br_medicalimaging_metastasesdx_Searchbuttontext ;
      private String Ddo_br_medicalimaging_metaloc_Caption ;
      private String Ddo_br_medicalimaging_metaloc_Tooltip ;
      private String Ddo_br_medicalimaging_metaloc_Cls ;
      private String Ddo_br_medicalimaging_metaloc_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_metaloc_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_metaloc_Sortedstatus ;
      private String Ddo_br_medicalimaging_metaloc_Sortasc ;
      private String Ddo_br_medicalimaging_metaloc_Sortdsc ;
      private String Ddo_br_medicalimaging_metaloc_Searchbuttontext ;
      private String Ddo_br_medicalimaging_metadate_Caption ;
      private String Ddo_br_medicalimaging_metadate_Tooltip ;
      private String Ddo_br_medicalimaging_metadate_Cls ;
      private String Ddo_br_medicalimaging_metadate_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_metadate_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_metadate_Sortedstatus ;
      private String Ddo_br_medicalimaging_metadate_Sortasc ;
      private String Ddo_br_medicalimaging_metadate_Sortdsc ;
      private String Ddo_br_medicalimaging_metadate_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtBR_MedicalImagingID_Title ;
      private String edtBR_EncounterID_Title ;
      private String edtBR_Information_PatientNo_Title ;
      private String edtBR_MedicalImaging_ID_Title ;
      private String edtBR_MedicalImaging_ImageName_Title ;
      private String edtBR_MedicalImaging_ImageName_Code_Title ;
      private String edtBR_MedicalImaging_ImageDate_Title ;
      private String edtBR_MedicalImaging_ImageHosp_Title ;
      private String edtBR_MedicalImaging_ImageHosp_Code_Title ;
      private String edtBR_MedicalImaging_ImageAge_Title ;
      private String edtBR_MedicalImaging_ImageLoc_Title ;
      private String edtBR_MedicalImaging_ImageLoc_Code_Title ;
      private String edtBR_MedicalImaging_ImageOrgan_Title ;
      private String edtBR_MedicalImaging_PreImageDiag_Title ;
      private String edtBR_MedicalImaging_ImageDes_Title ;
      private String edtBR_MedicalImaging_TumorSize_Title ;
      private String edtBR_MedicalImaging_ImageHtml_Title ;
      private String edtBR_MedicalImaging_MetaLoc_Title ;
      private String edtBR_MedicalImaging_MetaDate_Title ;
      private String subGrid_Header ;
      private String edtavSelect_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_medicalimagingid_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounterid_Internalname ;
      private String edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_information_patientno_Internalname ;
      private String edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medicalimaging_id_Internalname ;
      private String edtavDdo_br_medicalimaging_idtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medicalimaging_imagename_Internalname ;
      private String edtavDdo_br_medicalimaging_imagenametitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medicalimaging_imagename_code_Internalname ;
      private String edtavDdo_br_medicalimaging_imagename_codetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medicalimaging_imagedate_Internalname ;
      private String edtavDdo_br_medicalimaging_imagedatetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medicalimaging_imagehosp_Internalname ;
      private String edtavDdo_br_medicalimaging_imagehosptitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medicalimaging_imagehosp_code_Internalname ;
      private String edtavDdo_br_medicalimaging_imagehosp_codetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medicalimaging_imageage_Internalname ;
      private String edtavDdo_br_medicalimaging_imageagetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medicalimaging_imageloc_Internalname ;
      private String edtavDdo_br_medicalimaging_imageloctitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medicalimaging_imageloc_code_Internalname ;
      private String edtavDdo_br_medicalimaging_imageloc_codetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medicalimaging_imageorgan_Internalname ;
      private String edtavDdo_br_medicalimaging_imageorgantitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medicalimaging_preimagediag_Internalname ;
      private String edtavDdo_br_medicalimaging_preimagediagtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medicalimaging_imagedes_Internalname ;
      private String edtavDdo_br_medicalimaging_imagedestitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medicalimaging_tumorsize_Internalname ;
      private String edtavDdo_br_medicalimaging_tumorsizetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medicalimaging_imagehtml_Internalname ;
      private String edtavDdo_br_medicalimaging_imagehtmltitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medicalimaging_metastasesdx_Internalname ;
      private String edtavDdo_br_medicalimaging_metastasesdxtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medicalimaging_metaloc_Internalname ;
      private String edtavDdo_br_medicalimaging_metaloctitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medicalimaging_metadate_Internalname ;
      private String edtavDdo_br_medicalimaging_metadatetitlecontrolidtoreplace_Internalname ;
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
      private String edtBR_MedicalImagingID_Internalname ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_MedicalImaging_ID_Internalname ;
      private String edtBR_MedicalImaging_ImageName_Internalname ;
      private String edtBR_MedicalImaging_ImageName_Code_Internalname ;
      private String edtBR_MedicalImaging_ImageDate_Internalname ;
      private String edtBR_MedicalImaging_ImageHosp_Internalname ;
      private String edtBR_MedicalImaging_ImageHosp_Code_Internalname ;
      private String edtBR_MedicalImaging_ImageAge_Internalname ;
      private String edtBR_MedicalImaging_ImageLoc_Internalname ;
      private String edtBR_MedicalImaging_ImageLoc_Code_Internalname ;
      private String edtBR_MedicalImaging_ImageOrgan_Internalname ;
      private String edtBR_MedicalImaging_PreImageDiag_Internalname ;
      private String edtBR_MedicalImaging_ImageDes_Internalname ;
      private String edtBR_MedicalImaging_TumorSize_Internalname ;
      private String edtBR_MedicalImaging_ImageHtml_Internalname ;
      private String cmbBR_MedicalImaging_MetastasesDX_Internalname ;
      private String edtBR_MedicalImaging_MetaLoc_Internalname ;
      private String edtBR_MedicalImaging_MetaDate_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_12_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavSelect_Jsonclick ;
      private String ROClassString ;
      private String edtBR_MedicalImagingID_Jsonclick ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String edtBR_MedicalImaging_ID_Jsonclick ;
      private String edtBR_MedicalImaging_ImageName_Jsonclick ;
      private String edtBR_MedicalImaging_ImageName_Code_Jsonclick ;
      private String edtBR_MedicalImaging_ImageDate_Jsonclick ;
      private String edtBR_MedicalImaging_ImageHosp_Jsonclick ;
      private String edtBR_MedicalImaging_ImageHosp_Code_Jsonclick ;
      private String edtBR_MedicalImaging_ImageAge_Jsonclick ;
      private String edtBR_MedicalImaging_ImageLoc_Jsonclick ;
      private String edtBR_MedicalImaging_ImageLoc_Code_Jsonclick ;
      private String edtBR_MedicalImaging_ImageOrgan_Jsonclick ;
      private String edtBR_MedicalImaging_PreImageDiag_Jsonclick ;
      private String edtBR_MedicalImaging_ImageDes_Jsonclick ;
      private String edtBR_MedicalImaging_TumorSize_Jsonclick ;
      private String edtBR_MedicalImaging_ImageHtml_Jsonclick ;
      private String GXCCtl ;
      private String cmbBR_MedicalImaging_MetastasesDX_Jsonclick ;
      private String edtBR_MedicalImaging_MetaLoc_Jsonclick ;
      private String edtBR_MedicalImaging_MetaDate_Jsonclick ;
      private DateTime A229BR_MedicalImaging_ImageDate ;
      private DateTime A516BR_MedicalImaging_MetaDate ;
      private bool entryPointCalled ;
      private bool AV12OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_br_medicalimagingid_Includesortasc ;
      private bool Ddo_br_medicalimagingid_Includesortdsc ;
      private bool Ddo_br_medicalimagingid_Includefilter ;
      private bool Ddo_br_medicalimagingid_Includedatalist ;
      private bool Ddo_br_encounterid_Includesortasc ;
      private bool Ddo_br_encounterid_Includesortdsc ;
      private bool Ddo_br_encounterid_Includefilter ;
      private bool Ddo_br_encounterid_Includedatalist ;
      private bool Ddo_br_information_patientno_Includesortasc ;
      private bool Ddo_br_information_patientno_Includesortdsc ;
      private bool Ddo_br_information_patientno_Includefilter ;
      private bool Ddo_br_information_patientno_Includedatalist ;
      private bool Ddo_br_medicalimaging_id_Includesortasc ;
      private bool Ddo_br_medicalimaging_id_Includesortdsc ;
      private bool Ddo_br_medicalimaging_id_Includefilter ;
      private bool Ddo_br_medicalimaging_id_Includedatalist ;
      private bool Ddo_br_medicalimaging_imagename_Includesortasc ;
      private bool Ddo_br_medicalimaging_imagename_Includesortdsc ;
      private bool Ddo_br_medicalimaging_imagename_Includefilter ;
      private bool Ddo_br_medicalimaging_imagename_Includedatalist ;
      private bool Ddo_br_medicalimaging_imagename_code_Includesortasc ;
      private bool Ddo_br_medicalimaging_imagename_code_Includesortdsc ;
      private bool Ddo_br_medicalimaging_imagename_code_Includefilter ;
      private bool Ddo_br_medicalimaging_imagename_code_Includedatalist ;
      private bool Ddo_br_medicalimaging_imagedate_Includesortasc ;
      private bool Ddo_br_medicalimaging_imagedate_Includesortdsc ;
      private bool Ddo_br_medicalimaging_imagedate_Includefilter ;
      private bool Ddo_br_medicalimaging_imagedate_Includedatalist ;
      private bool Ddo_br_medicalimaging_imagehosp_Includesortasc ;
      private bool Ddo_br_medicalimaging_imagehosp_Includesortdsc ;
      private bool Ddo_br_medicalimaging_imagehosp_Includefilter ;
      private bool Ddo_br_medicalimaging_imagehosp_Includedatalist ;
      private bool Ddo_br_medicalimaging_imagehosp_code_Includesortasc ;
      private bool Ddo_br_medicalimaging_imagehosp_code_Includesortdsc ;
      private bool Ddo_br_medicalimaging_imagehosp_code_Includefilter ;
      private bool Ddo_br_medicalimaging_imagehosp_code_Includedatalist ;
      private bool Ddo_br_medicalimaging_imageage_Includesortasc ;
      private bool Ddo_br_medicalimaging_imageage_Includesortdsc ;
      private bool Ddo_br_medicalimaging_imageage_Includefilter ;
      private bool Ddo_br_medicalimaging_imageage_Includedatalist ;
      private bool Ddo_br_medicalimaging_imageloc_Includesortasc ;
      private bool Ddo_br_medicalimaging_imageloc_Includesortdsc ;
      private bool Ddo_br_medicalimaging_imageloc_Includefilter ;
      private bool Ddo_br_medicalimaging_imageloc_Includedatalist ;
      private bool Ddo_br_medicalimaging_imageloc_code_Includesortasc ;
      private bool Ddo_br_medicalimaging_imageloc_code_Includesortdsc ;
      private bool Ddo_br_medicalimaging_imageloc_code_Includefilter ;
      private bool Ddo_br_medicalimaging_imageloc_code_Includedatalist ;
      private bool Ddo_br_medicalimaging_imageorgan_Includesortasc ;
      private bool Ddo_br_medicalimaging_imageorgan_Includesortdsc ;
      private bool Ddo_br_medicalimaging_imageorgan_Includefilter ;
      private bool Ddo_br_medicalimaging_imageorgan_Includedatalist ;
      private bool Ddo_br_medicalimaging_preimagediag_Includesortasc ;
      private bool Ddo_br_medicalimaging_preimagediag_Includesortdsc ;
      private bool Ddo_br_medicalimaging_preimagediag_Includefilter ;
      private bool Ddo_br_medicalimaging_preimagediag_Includedatalist ;
      private bool Ddo_br_medicalimaging_imagedes_Includesortasc ;
      private bool Ddo_br_medicalimaging_imagedes_Includesortdsc ;
      private bool Ddo_br_medicalimaging_imagedes_Includefilter ;
      private bool Ddo_br_medicalimaging_imagedes_Includedatalist ;
      private bool Ddo_br_medicalimaging_tumorsize_Includesortasc ;
      private bool Ddo_br_medicalimaging_tumorsize_Includesortdsc ;
      private bool Ddo_br_medicalimaging_tumorsize_Includefilter ;
      private bool Ddo_br_medicalimaging_tumorsize_Includedatalist ;
      private bool Ddo_br_medicalimaging_imagehtml_Includesortasc ;
      private bool Ddo_br_medicalimaging_imagehtml_Includesortdsc ;
      private bool Ddo_br_medicalimaging_imagehtml_Includefilter ;
      private bool Ddo_br_medicalimaging_imagehtml_Includedatalist ;
      private bool Ddo_br_medicalimaging_metastasesdx_Includesortasc ;
      private bool Ddo_br_medicalimaging_metastasesdx_Includesortdsc ;
      private bool Ddo_br_medicalimaging_metastasesdx_Includefilter ;
      private bool Ddo_br_medicalimaging_metastasesdx_Includedatalist ;
      private bool Ddo_br_medicalimaging_metaloc_Includesortasc ;
      private bool Ddo_br_medicalimaging_metaloc_Includesortdsc ;
      private bool Ddo_br_medicalimaging_metaloc_Includefilter ;
      private bool Ddo_br_medicalimaging_metaloc_Includedatalist ;
      private bool Ddo_br_medicalimaging_metadate_Includesortasc ;
      private bool Ddo_br_medicalimaging_metadate_Includesortdsc ;
      private bool Ddo_br_medicalimaging_metadate_Includefilter ;
      private bool Ddo_br_medicalimaging_metadate_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_12_Refreshing=false ;
      private bool n19BR_EncounterID ;
      private bool n36BR_Information_PatientNo ;
      private bool n227BR_MedicalImaging_ID ;
      private bool n228BR_MedicalImaging_ImageName ;
      private bool n484BR_MedicalImaging_ImageName_Code ;
      private bool n229BR_MedicalImaging_ImageDate ;
      private bool n230BR_MedicalImaging_ImageHosp ;
      private bool n485BR_MedicalImaging_ImageHosp_Code ;
      private bool n231BR_MedicalImaging_ImageAge ;
      private bool n232BR_MedicalImaging_ImageLoc ;
      private bool n486BR_MedicalImaging_ImageLoc_Code ;
      private bool n233BR_MedicalImaging_ImageOrgan ;
      private bool n234BR_MedicalImaging_PreImageDiag ;
      private bool n235BR_MedicalImaging_ImageDes ;
      private bool n236BR_MedicalImaging_TumorSize ;
      private bool n334BR_MedicalImaging_ImageHtml ;
      private bool n514BR_MedicalImaging_MetastasesDX ;
      private bool n515BR_MedicalImaging_MetaLoc ;
      private bool n516BR_MedicalImaging_MetaDate ;
      private bool gxdyncontrolsrefreshing ;
      private bool n85BR_Information_ID ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool gx_refresh_fired ;
      private bool AV44Select_IsBlob ;
      private String A334BR_MedicalImaging_ImageHtml ;
      private String AV45InOutBR_MedicalImaging_ImageName ;
      private String wcpOAV45InOutBR_MedicalImaging_ImageName ;
      private String AV14ddo_BR_MedicalImagingIDTitleControlIdToReplace ;
      private String AV16ddo_BR_EncounterIDTitleControlIdToReplace ;
      private String AV18ddo_BR_Information_PatientNoTitleControlIdToReplace ;
      private String AV20ddo_BR_MedicalImaging_IDTitleControlIdToReplace ;
      private String AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace ;
      private String AV49ddo_BR_MedicalImaging_ImageName_CodeTitleControlIdToReplace ;
      private String AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace ;
      private String AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace ;
      private String AV51ddo_BR_MedicalImaging_ImageHosp_CodeTitleControlIdToReplace ;
      private String AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace ;
      private String AV30ddo_BR_MedicalImaging_ImageLocTitleControlIdToReplace ;
      private String AV53ddo_BR_MedicalImaging_ImageLoc_CodeTitleControlIdToReplace ;
      private String AV32ddo_BR_MedicalImaging_ImageOrganTitleControlIdToReplace ;
      private String AV34ddo_BR_MedicalImaging_PreImageDiagTitleControlIdToReplace ;
      private String AV36ddo_BR_MedicalImaging_ImageDesTitleControlIdToReplace ;
      private String AV38ddo_BR_MedicalImaging_TumorSizeTitleControlIdToReplace ;
      private String AV47ddo_BR_MedicalImaging_ImageHtmlTitleControlIdToReplace ;
      private String AV55ddo_BR_MedicalImaging_MetastasesDXTitleControlIdToReplace ;
      private String AV57ddo_BR_MedicalImaging_MetaLocTitleControlIdToReplace ;
      private String AV59ddo_BR_MedicalImaging_MetaDateTitleControlIdToReplace ;
      private String A36BR_Information_PatientNo ;
      private String A228BR_MedicalImaging_ImageName ;
      private String A484BR_MedicalImaging_ImageName_Code ;
      private String A230BR_MedicalImaging_ImageHosp ;
      private String A485BR_MedicalImaging_ImageHosp_Code ;
      private String A232BR_MedicalImaging_ImageLoc ;
      private String A486BR_MedicalImaging_ImageLoc_Code ;
      private String A233BR_MedicalImaging_ImageOrgan ;
      private String A234BR_MedicalImaging_PreImageDiag ;
      private String A235BR_MedicalImaging_ImageDes ;
      private String A236BR_MedicalImaging_TumorSize ;
      private String A514BR_MedicalImaging_MetastasesDX ;
      private String A515BR_MedicalImaging_MetaLoc ;
      private String AV63Select_GXI ;
      private String AV44Select ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_medicalimagingid ;
      private GXUserControl ucDdo_br_encounterid ;
      private GXUserControl ucDdo_br_information_patientno ;
      private GXUserControl ucDdo_br_medicalimaging_id ;
      private GXUserControl ucDdo_br_medicalimaging_imagename ;
      private GXUserControl ucDdo_br_medicalimaging_imagename_code ;
      private GXUserControl ucDdo_br_medicalimaging_imagedate ;
      private GXUserControl ucDdo_br_medicalimaging_imagehosp ;
      private GXUserControl ucDdo_br_medicalimaging_imagehosp_code ;
      private GXUserControl ucDdo_br_medicalimaging_imageage ;
      private GXUserControl ucDdo_br_medicalimaging_imageloc ;
      private GXUserControl ucDdo_br_medicalimaging_imageloc_code ;
      private GXUserControl ucDdo_br_medicalimaging_imageorgan ;
      private GXUserControl ucDdo_br_medicalimaging_preimagediag ;
      private GXUserControl ucDdo_br_medicalimaging_imagedes ;
      private GXUserControl ucDdo_br_medicalimaging_tumorsize ;
      private GXUserControl ucDdo_br_medicalimaging_imagehtml ;
      private GXUserControl ucDdo_br_medicalimaging_metastasesdx ;
      private GXUserControl ucDdo_br_medicalimaging_metaloc ;
      private GXUserControl ucDdo_br_medicalimaging_metadate ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private long aP0_InOutBR_MedicalImagingID ;
      private String aP1_InOutBR_MedicalImaging_ImageName ;
      private GXCombobox cmbBR_MedicalImaging_MetastasesDX ;
      private IDataStoreProvider pr_default ;
      private long[] H005L2_A85BR_Information_ID ;
      private bool[] H005L2_n85BR_Information_ID ;
      private DateTime[] H005L2_A516BR_MedicalImaging_MetaDate ;
      private bool[] H005L2_n516BR_MedicalImaging_MetaDate ;
      private String[] H005L2_A515BR_MedicalImaging_MetaLoc ;
      private bool[] H005L2_n515BR_MedicalImaging_MetaLoc ;
      private String[] H005L2_A514BR_MedicalImaging_MetastasesDX ;
      private bool[] H005L2_n514BR_MedicalImaging_MetastasesDX ;
      private String[] H005L2_A334BR_MedicalImaging_ImageHtml ;
      private bool[] H005L2_n334BR_MedicalImaging_ImageHtml ;
      private String[] H005L2_A236BR_MedicalImaging_TumorSize ;
      private bool[] H005L2_n236BR_MedicalImaging_TumorSize ;
      private String[] H005L2_A235BR_MedicalImaging_ImageDes ;
      private bool[] H005L2_n235BR_MedicalImaging_ImageDes ;
      private String[] H005L2_A234BR_MedicalImaging_PreImageDiag ;
      private bool[] H005L2_n234BR_MedicalImaging_PreImageDiag ;
      private String[] H005L2_A233BR_MedicalImaging_ImageOrgan ;
      private bool[] H005L2_n233BR_MedicalImaging_ImageOrgan ;
      private String[] H005L2_A486BR_MedicalImaging_ImageLoc_Code ;
      private bool[] H005L2_n486BR_MedicalImaging_ImageLoc_Code ;
      private String[] H005L2_A232BR_MedicalImaging_ImageLoc ;
      private bool[] H005L2_n232BR_MedicalImaging_ImageLoc ;
      private short[] H005L2_A231BR_MedicalImaging_ImageAge ;
      private bool[] H005L2_n231BR_MedicalImaging_ImageAge ;
      private String[] H005L2_A485BR_MedicalImaging_ImageHosp_Code ;
      private bool[] H005L2_n485BR_MedicalImaging_ImageHosp_Code ;
      private String[] H005L2_A230BR_MedicalImaging_ImageHosp ;
      private bool[] H005L2_n230BR_MedicalImaging_ImageHosp ;
      private DateTime[] H005L2_A229BR_MedicalImaging_ImageDate ;
      private bool[] H005L2_n229BR_MedicalImaging_ImageDate ;
      private String[] H005L2_A484BR_MedicalImaging_ImageName_Code ;
      private bool[] H005L2_n484BR_MedicalImaging_ImageName_Code ;
      private String[] H005L2_A228BR_MedicalImaging_ImageName ;
      private bool[] H005L2_n228BR_MedicalImaging_ImageName ;
      private long[] H005L2_A227BR_MedicalImaging_ID ;
      private bool[] H005L2_n227BR_MedicalImaging_ID ;
      private String[] H005L2_A36BR_Information_PatientNo ;
      private bool[] H005L2_n36BR_Information_PatientNo ;
      private long[] H005L2_A19BR_EncounterID ;
      private bool[] H005L2_n19BR_EncounterID ;
      private long[] H005L2_A225BR_MedicalImagingID ;
      private long[] H005L3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV13BR_MedicalImagingIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV15BR_EncounterIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV17BR_Information_PatientNoTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV19BR_MedicalImaging_IDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV21BR_MedicalImaging_ImageNameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV48BR_MedicalImaging_ImageName_CodeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV23BR_MedicalImaging_ImageDateTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV25BR_MedicalImaging_ImageHospTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV50BR_MedicalImaging_ImageHosp_CodeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV27BR_MedicalImaging_ImageAgeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV29BR_MedicalImaging_ImageLocTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV52BR_MedicalImaging_ImageLoc_CodeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV31BR_MedicalImaging_ImageOrganTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV33BR_MedicalImaging_PreImageDiagTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV35BR_MedicalImaging_ImageDesTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV37BR_MedicalImaging_TumorSizeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV46BR_MedicalImaging_ImageHtmlTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV54BR_MedicalImaging_MetastasesDXTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV56BR_MedicalImaging_MetaLocTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV58BR_MedicalImaging_MetaDateTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV39DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class br_medicalimagingprompt__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H005L2( IGxContext context ,
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
         sSelectString = " T2.[BR_Information_ID], T1.[BR_MedicalImaging_MetaDate], T1.[BR_MedicalImaging_MetaLoc], T1.[BR_MedicalImaging_MetastasesDX], T1.[BR_MedicalImaging_ImageHtml], T1.[BR_MedicalImaging_TumorSize], T1.[BR_MedicalImaging_ImageDes], T1.[BR_MedicalImaging_PreImageDiag], T1.[BR_MedicalImaging_ImageOrgan], T1.[BR_MedicalImaging_ImageLoc_Code], T1.[BR_MedicalImaging_ImageLoc], T1.[BR_MedicalImaging_ImageAge], T1.[BR_MedicalImaging_ImageHosp_Code], T1.[BR_MedicalImaging_ImageHosp], T1.[BR_MedicalImaging_ImageDate], T1.[BR_MedicalImaging_ImageName_Code], T1.[BR_MedicalImaging_ImageName], T1.[BR_MedicalImaging_ID], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_MedicalImagingID]";
         sFromString = " FROM (([BR_MedicalImaging] T1 WITH (NOLOCK) LEFT JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         sOrderString = "";
         if ( ( AV11OrderedBy == 1 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImagingID]";
         }
         else if ( ( AV11OrderedBy == 1 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImagingID] DESC";
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
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_ID]";
         }
         else if ( ( AV11OrderedBy == 4 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_ID] DESC";
         }
         else if ( ( AV11OrderedBy == 5 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_ImageName]";
         }
         else if ( ( AV11OrderedBy == 5 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_ImageName] DESC";
         }
         else if ( ( AV11OrderedBy == 6 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_ImageName_Code]";
         }
         else if ( ( AV11OrderedBy == 6 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_ImageName_Code] DESC";
         }
         else if ( ( AV11OrderedBy == 7 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_ImageDate]";
         }
         else if ( ( AV11OrderedBy == 7 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_ImageDate] DESC";
         }
         else if ( ( AV11OrderedBy == 8 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_ImageHosp]";
         }
         else if ( ( AV11OrderedBy == 8 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_ImageHosp] DESC";
         }
         else if ( ( AV11OrderedBy == 9 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_ImageHosp_Code]";
         }
         else if ( ( AV11OrderedBy == 9 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_ImageHosp_Code] DESC";
         }
         else if ( ( AV11OrderedBy == 10 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_ImageAge]";
         }
         else if ( ( AV11OrderedBy == 10 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_ImageAge] DESC";
         }
         else if ( ( AV11OrderedBy == 11 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_ImageLoc]";
         }
         else if ( ( AV11OrderedBy == 11 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_ImageLoc] DESC";
         }
         else if ( ( AV11OrderedBy == 12 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_ImageLoc_Code]";
         }
         else if ( ( AV11OrderedBy == 12 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_ImageLoc_Code] DESC";
         }
         else if ( ( AV11OrderedBy == 13 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_ImageOrgan]";
         }
         else if ( ( AV11OrderedBy == 13 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_ImageOrgan] DESC";
         }
         else if ( ( AV11OrderedBy == 14 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_PreImageDiag]";
         }
         else if ( ( AV11OrderedBy == 14 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_PreImageDiag] DESC";
         }
         else if ( ( AV11OrderedBy == 15 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_ImageDes]";
         }
         else if ( ( AV11OrderedBy == 15 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_ImageDes] DESC";
         }
         else if ( ( AV11OrderedBy == 16 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_TumorSize]";
         }
         else if ( ( AV11OrderedBy == 16 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_TumorSize] DESC";
         }
         else if ( ( AV11OrderedBy == 17 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_ImageHtml]";
         }
         else if ( ( AV11OrderedBy == 17 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_ImageHtml] DESC";
         }
         else if ( ( AV11OrderedBy == 18 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_MetastasesDX]";
         }
         else if ( ( AV11OrderedBy == 18 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_MetastasesDX] DESC";
         }
         else if ( ( AV11OrderedBy == 19 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_MetaLoc]";
         }
         else if ( ( AV11OrderedBy == 19 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_MetaLoc] DESC";
         }
         else if ( ( AV11OrderedBy == 20 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_MetaDate]";
         }
         else if ( ( AV11OrderedBy == 20 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImaging_MetaDate] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicalImagingID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H005L3( IGxContext context ,
                                             short AV11OrderedBy ,
                                             bool AV12OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM (([BR_MedicalImaging] T1 WITH (NOLOCK) LEFT JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
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
         else if ( ( AV11OrderedBy == 17 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 17 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 18 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 18 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 19 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 19 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 20 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 20 ) && ( AV12OrderedDsc ) )
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
                     return conditional_H005L2(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
               case 1 :
                     return conditional_H005L3(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
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
          Object[] prmH005L2 ;
          prmH005L2 = new Object[] {
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH005L3 ;
          prmH005L3 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H005L2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005L2,11,0,true,false )
             ,new CursorDef("H005L3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005L3,1,0,true,false )
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
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getLongVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((String[]) buf[18])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((String[]) buf[20])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((short[]) buf[22])[0] = rslt.getShort(12) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(12);
                ((String[]) buf[24])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(13);
                ((String[]) buf[26])[0] = rslt.getVarchar(14) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(14);
                ((DateTime[]) buf[28])[0] = rslt.getGXDate(15) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(15);
                ((String[]) buf[30])[0] = rslt.getVarchar(16) ;
                ((bool[]) buf[31])[0] = rslt.wasNull(16);
                ((String[]) buf[32])[0] = rslt.getVarchar(17) ;
                ((bool[]) buf[33])[0] = rslt.wasNull(17);
                ((long[]) buf[34])[0] = rslt.getLong(18) ;
                ((bool[]) buf[35])[0] = rslt.wasNull(18);
                ((String[]) buf[36])[0] = rslt.getVarchar(19) ;
                ((bool[]) buf[37])[0] = rslt.wasNull(19);
                ((long[]) buf[38])[0] = rslt.getLong(20) ;
                ((bool[]) buf[39])[0] = rslt.wasNull(20);
                ((long[]) buf[40])[0] = rslt.getLong(21) ;
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
