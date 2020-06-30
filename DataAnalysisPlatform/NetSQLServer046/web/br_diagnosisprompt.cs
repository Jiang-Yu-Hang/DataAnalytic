/*
               File: BR_DiagnosisPrompt
        Description: 选择诊断
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:59:14.66
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
   public class br_diagnosisprompt : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public br_diagnosisprompt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_diagnosisprompt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_InOutBR_DiagnosisID )
      {
         this.AV8InOutBR_DiagnosisID = aP0_InOutBR_DiagnosisID;
         executePrivate();
         aP0_InOutBR_DiagnosisID=this.AV8InOutBR_DiagnosisID;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbBR_Diagnosis_InitialDX = new GXCombobox();
         cmbBR_Diagnosis_MetastasesDX = new GXCombobox();
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
               AV10OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV11OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV13ddo_BR_DiagnosisIDTitleControlIdToReplace = GetNextPar( );
               AV15ddo_BR_EncounterIDTitleControlIdToReplace = GetNextPar( );
               AV17ddo_BR_Information_PatientNoTitleControlIdToReplace = GetNextPar( );
               AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace = GetNextPar( );
               AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace = GetNextPar( );
               AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace = GetNextPar( );
               AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace = GetNextPar( );
               AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace = GetNextPar( );
               AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace = GetNextPar( );
               AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace = GetNextPar( );
               AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace = GetNextPar( );
               AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace = GetNextPar( );
               AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace = GetNextPar( );
               AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace = GetNextPar( );
               AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace = GetNextPar( );
               AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_DiagnosisIDTitleControlIdToReplace, AV15ddo_BR_EncounterIDTitleControlIdToReplace, AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace, AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace, AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace, AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace, AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace, AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace, AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace, AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace, AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace, AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace, AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace, AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace, AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace) ;
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
               AV8InOutBR_DiagnosisID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_DiagnosisID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_DiagnosisID), 18, 0)));
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
            PA3D2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV52Pgmname = "BR_DiagnosisPrompt";
               context.Gx_err = 0;
               WS3D2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE3D2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022711591498", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_diagnosisprompt.aspx") + "?" + UrlEncode("" +AV8InOutBR_DiagnosisID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10OrderedBy), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV11OrderedDsc));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_12", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_12), 4, 0, ".", "")));
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_DIAGNOSISIDTITLEFILTERDATA", AV12BR_DiagnosisIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_DIAGNOSISIDTITLEFILTERDATA", AV12BR_DiagnosisIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTERIDTITLEFILTERDATA", AV14BR_EncounterIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTERIDTITLEFILTERDATA", AV14BR_EncounterIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_INFORMATION_PATIENTNOTITLEFILTERDATA", AV16BR_Information_PatientNoTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_INFORMATION_PATIENTNOTITLEFILTERDATA", AV16BR_Information_PatientNoTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_DIAGNOSIS_NOTITLEFILTERDATA", AV40BR_Diagnosis_NoTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_DIAGNOSIS_NOTITLEFILTERDATA", AV40BR_Diagnosis_NoTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_DIAGNOSIS_DXIDTITLEFILTERDATA", AV18BR_Diagnosis_DXIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_DIAGNOSIS_DXIDTITLEFILTERDATA", AV18BR_Diagnosis_DXIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_DIAGNOSIS_DXCODETITLEFILTERDATA", AV20BR_Diagnosis_DXCodeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_DIAGNOSIS_DXCODETITLEFILTERDATA", AV20BR_Diagnosis_DXCodeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA", AV22BR_Diagnosis_DXTypeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA", AV22BR_Diagnosis_DXTypeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_DIAGNOSIS_DXTYPE_CODETITLEFILTERDATA", AV42BR_Diagnosis_DXType_CodeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_DIAGNOSIS_DXTYPE_CODETITLEFILTERDATA", AV42BR_Diagnosis_DXType_CodeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA", AV24BR_Diagnosis_DXTsourceTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA", AV24BR_Diagnosis_DXTsourceTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_DIAGNOSIS_DXTSOURCE_CODETITLEFILTERDATA", AV44BR_Diagnosis_DXTsource_CodeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_DIAGNOSIS_DXTSOURCE_CODETITLEFILTERDATA", AV44BR_Diagnosis_DXTsource_CodeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA", AV26BR_Diagnosis_DXDescriptionTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA", AV26BR_Diagnosis_DXDescriptionTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_DIAGNOSIS_INITIALDXTITLEFILTERDATA", AV28BR_Diagnosis_InitialDXTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_DIAGNOSIS_INITIALDXTITLEFILTERDATA", AV28BR_Diagnosis_InitialDXTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_DIAGNOSIS_INITIALDX_CODETITLEFILTERDATA", AV46BR_Diagnosis_InitialDX_CodeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_DIAGNOSIS_INITIALDX_CODETITLEFILTERDATA", AV46BR_Diagnosis_InitialDX_CodeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_DIAGNOSIS_METASTASESDXTITLEFILTERDATA", AV30BR_Diagnosis_MetastasesDXTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_DIAGNOSIS_METASTASESDXTITLEFILTERDATA", AV30BR_Diagnosis_MetastasesDXTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_DIAGNOSIS_METASTASESDX_CODETITLEFILTERDATA", AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_DIAGNOSIS_METASTASESDX_CODETITLEFILTERDATA", AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_DIAGNOSIS_DXSOURCETITLEFILTERDATA", AV38BR_Diagnosis_DXSourceTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_DIAGNOSIS_DXSOURCETITLEFILTERDATA", AV38BR_Diagnosis_DXSourceTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vINOUTBR_DIAGNOSISID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8InOutBR_DiagnosisID), 18, 0, ".", "")));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSISID_Caption", StringUtil.RTrim( Ddo_br_diagnosisid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSISID_Tooltip", StringUtil.RTrim( Ddo_br_diagnosisid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSISID_Cls", StringUtil.RTrim( Ddo_br_diagnosisid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSISID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_diagnosisid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSISID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_diagnosisid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSISID_Includesortasc", StringUtil.BoolToStr( Ddo_br_diagnosisid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSISID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_diagnosisid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSISID_Sortedstatus", StringUtil.RTrim( Ddo_br_diagnosisid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSISID_Includefilter", StringUtil.BoolToStr( Ddo_br_diagnosisid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSISID_Includedatalist", StringUtil.BoolToStr( Ddo_br_diagnosisid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSISID_Sortasc", StringUtil.RTrim( Ddo_br_diagnosisid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSISID_Sortdsc", StringUtil.RTrim( Ddo_br_diagnosisid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSISID_Searchbuttontext", StringUtil.RTrim( Ddo_br_diagnosisid_Searchbuttontext));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_NO_Caption", StringUtil.RTrim( Ddo_br_diagnosis_no_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_NO_Tooltip", StringUtil.RTrim( Ddo_br_diagnosis_no_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_NO_Cls", StringUtil.RTrim( Ddo_br_diagnosis_no_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_NO_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_diagnosis_no_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_NO_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_diagnosis_no_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_NO_Includesortasc", StringUtil.BoolToStr( Ddo_br_diagnosis_no_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_NO_Includesortdsc", StringUtil.BoolToStr( Ddo_br_diagnosis_no_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_NO_Sortedstatus", StringUtil.RTrim( Ddo_br_diagnosis_no_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_NO_Includefilter", StringUtil.BoolToStr( Ddo_br_diagnosis_no_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_NO_Includedatalist", StringUtil.BoolToStr( Ddo_br_diagnosis_no_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_NO_Sortasc", StringUtil.RTrim( Ddo_br_diagnosis_no_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_NO_Sortdsc", StringUtil.RTrim( Ddo_br_diagnosis_no_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_NO_Searchbuttontext", StringUtil.RTrim( Ddo_br_diagnosis_no_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXID_Caption", StringUtil.RTrim( Ddo_br_diagnosis_dxid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXID_Tooltip", StringUtil.RTrim( Ddo_br_diagnosis_dxid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXID_Cls", StringUtil.RTrim( Ddo_br_diagnosis_dxid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_diagnosis_dxid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_diagnosis_dxid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXID_Includesortasc", StringUtil.BoolToStr( Ddo_br_diagnosis_dxid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_diagnosis_dxid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXID_Sortedstatus", StringUtil.RTrim( Ddo_br_diagnosis_dxid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXID_Includefilter", StringUtil.BoolToStr( Ddo_br_diagnosis_dxid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXID_Includedatalist", StringUtil.BoolToStr( Ddo_br_diagnosis_dxid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXID_Sortasc", StringUtil.RTrim( Ddo_br_diagnosis_dxid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXID_Sortdsc", StringUtil.RTrim( Ddo_br_diagnosis_dxid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXID_Searchbuttontext", StringUtil.RTrim( Ddo_br_diagnosis_dxid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXCODE_Caption", StringUtil.RTrim( Ddo_br_diagnosis_dxcode_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXCODE_Tooltip", StringUtil.RTrim( Ddo_br_diagnosis_dxcode_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXCODE_Cls", StringUtil.RTrim( Ddo_br_diagnosis_dxcode_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXCODE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_diagnosis_dxcode_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXCODE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_diagnosis_dxcode_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXCODE_Includesortasc", StringUtil.BoolToStr( Ddo_br_diagnosis_dxcode_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXCODE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_diagnosis_dxcode_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXCODE_Sortedstatus", StringUtil.RTrim( Ddo_br_diagnosis_dxcode_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXCODE_Includefilter", StringUtil.BoolToStr( Ddo_br_diagnosis_dxcode_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXCODE_Includedatalist", StringUtil.BoolToStr( Ddo_br_diagnosis_dxcode_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXCODE_Sortasc", StringUtil.RTrim( Ddo_br_diagnosis_dxcode_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXCODE_Sortdsc", StringUtil.RTrim( Ddo_br_diagnosis_dxcode_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXCODE_Searchbuttontext", StringUtil.RTrim( Ddo_br_diagnosis_dxcode_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTYPE_Caption", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTYPE_Tooltip", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTYPE_Cls", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTYPE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTYPE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTYPE_Includesortasc", StringUtil.BoolToStr( Ddo_br_diagnosis_dxtype_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTYPE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_diagnosis_dxtype_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTYPE_Sortedstatus", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTYPE_Includefilter", StringUtil.BoolToStr( Ddo_br_diagnosis_dxtype_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTYPE_Includedatalist", StringUtil.BoolToStr( Ddo_br_diagnosis_dxtype_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTYPE_Sortasc", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTYPE_Sortdsc", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTYPE_Searchbuttontext", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTYPE_CODE_Caption", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_code_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTYPE_CODE_Tooltip", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_code_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTYPE_CODE_Cls", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_code_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTYPE_CODE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_code_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTYPE_CODE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_code_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTYPE_CODE_Includesortasc", StringUtil.BoolToStr( Ddo_br_diagnosis_dxtype_code_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTYPE_CODE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_diagnosis_dxtype_code_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTYPE_CODE_Sortedstatus", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_code_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTYPE_CODE_Includefilter", StringUtil.BoolToStr( Ddo_br_diagnosis_dxtype_code_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTYPE_CODE_Includedatalist", StringUtil.BoolToStr( Ddo_br_diagnosis_dxtype_code_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTYPE_CODE_Sortasc", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_code_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTYPE_CODE_Sortdsc", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_code_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTYPE_CODE_Searchbuttontext", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_code_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTSOURCE_Caption", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTSOURCE_Tooltip", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTSOURCE_Cls", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTSOURCE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTSOURCE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTSOURCE_Includesortasc", StringUtil.BoolToStr( Ddo_br_diagnosis_dxtsource_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTSOURCE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_diagnosis_dxtsource_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTSOURCE_Sortedstatus", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTSOURCE_Includefilter", StringUtil.BoolToStr( Ddo_br_diagnosis_dxtsource_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTSOURCE_Includedatalist", StringUtil.BoolToStr( Ddo_br_diagnosis_dxtsource_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTSOURCE_Sortasc", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTSOURCE_Sortdsc", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTSOURCE_Searchbuttontext", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE_Caption", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_code_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE_Tooltip", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_code_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE_Cls", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_code_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_code_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_code_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE_Includesortasc", StringUtil.BoolToStr( Ddo_br_diagnosis_dxtsource_code_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_diagnosis_dxtsource_code_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE_Sortedstatus", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_code_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE_Includefilter", StringUtil.BoolToStr( Ddo_br_diagnosis_dxtsource_code_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE_Includedatalist", StringUtil.BoolToStr( Ddo_br_diagnosis_dxtsource_code_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE_Sortasc", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_code_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE_Sortdsc", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_code_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE_Searchbuttontext", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_code_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXDESCRIPTION_Caption", StringUtil.RTrim( Ddo_br_diagnosis_dxdescription_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXDESCRIPTION_Tooltip", StringUtil.RTrim( Ddo_br_diagnosis_dxdescription_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXDESCRIPTION_Cls", StringUtil.RTrim( Ddo_br_diagnosis_dxdescription_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXDESCRIPTION_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_diagnosis_dxdescription_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXDESCRIPTION_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_diagnosis_dxdescription_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXDESCRIPTION_Includesortasc", StringUtil.BoolToStr( Ddo_br_diagnosis_dxdescription_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXDESCRIPTION_Includesortdsc", StringUtil.BoolToStr( Ddo_br_diagnosis_dxdescription_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXDESCRIPTION_Sortedstatus", StringUtil.RTrim( Ddo_br_diagnosis_dxdescription_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXDESCRIPTION_Includefilter", StringUtil.BoolToStr( Ddo_br_diagnosis_dxdescription_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXDESCRIPTION_Includedatalist", StringUtil.BoolToStr( Ddo_br_diagnosis_dxdescription_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXDESCRIPTION_Sortasc", StringUtil.RTrim( Ddo_br_diagnosis_dxdescription_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXDESCRIPTION_Sortdsc", StringUtil.RTrim( Ddo_br_diagnosis_dxdescription_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXDESCRIPTION_Searchbuttontext", StringUtil.RTrim( Ddo_br_diagnosis_dxdescription_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_INITIALDX_Caption", StringUtil.RTrim( Ddo_br_diagnosis_initialdx_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_INITIALDX_Tooltip", StringUtil.RTrim( Ddo_br_diagnosis_initialdx_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_INITIALDX_Cls", StringUtil.RTrim( Ddo_br_diagnosis_initialdx_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_INITIALDX_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_diagnosis_initialdx_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_INITIALDX_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_diagnosis_initialdx_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_INITIALDX_Includesortasc", StringUtil.BoolToStr( Ddo_br_diagnosis_initialdx_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_INITIALDX_Includesortdsc", StringUtil.BoolToStr( Ddo_br_diagnosis_initialdx_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_INITIALDX_Sortedstatus", StringUtil.RTrim( Ddo_br_diagnosis_initialdx_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_INITIALDX_Includefilter", StringUtil.BoolToStr( Ddo_br_diagnosis_initialdx_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_INITIALDX_Includedatalist", StringUtil.BoolToStr( Ddo_br_diagnosis_initialdx_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_INITIALDX_Sortasc", StringUtil.RTrim( Ddo_br_diagnosis_initialdx_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_INITIALDX_Sortdsc", StringUtil.RTrim( Ddo_br_diagnosis_initialdx_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_INITIALDX_Searchbuttontext", StringUtil.RTrim( Ddo_br_diagnosis_initialdx_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_INITIALDX_CODE_Caption", StringUtil.RTrim( Ddo_br_diagnosis_initialdx_code_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_INITIALDX_CODE_Tooltip", StringUtil.RTrim( Ddo_br_diagnosis_initialdx_code_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_INITIALDX_CODE_Cls", StringUtil.RTrim( Ddo_br_diagnosis_initialdx_code_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_INITIALDX_CODE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_diagnosis_initialdx_code_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_INITIALDX_CODE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_diagnosis_initialdx_code_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_INITIALDX_CODE_Includesortasc", StringUtil.BoolToStr( Ddo_br_diagnosis_initialdx_code_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_INITIALDX_CODE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_diagnosis_initialdx_code_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_INITIALDX_CODE_Sortedstatus", StringUtil.RTrim( Ddo_br_diagnosis_initialdx_code_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_INITIALDX_CODE_Includefilter", StringUtil.BoolToStr( Ddo_br_diagnosis_initialdx_code_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_INITIALDX_CODE_Includedatalist", StringUtil.BoolToStr( Ddo_br_diagnosis_initialdx_code_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_INITIALDX_CODE_Sortasc", StringUtil.RTrim( Ddo_br_diagnosis_initialdx_code_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_INITIALDX_CODE_Sortdsc", StringUtil.RTrim( Ddo_br_diagnosis_initialdx_code_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_INITIALDX_CODE_Searchbuttontext", StringUtil.RTrim( Ddo_br_diagnosis_initialdx_code_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_METASTASESDX_Caption", StringUtil.RTrim( Ddo_br_diagnosis_metastasesdx_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_METASTASESDX_Tooltip", StringUtil.RTrim( Ddo_br_diagnosis_metastasesdx_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_METASTASESDX_Cls", StringUtil.RTrim( Ddo_br_diagnosis_metastasesdx_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_METASTASESDX_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_diagnosis_metastasesdx_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_METASTASESDX_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_diagnosis_metastasesdx_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_METASTASESDX_Includesortasc", StringUtil.BoolToStr( Ddo_br_diagnosis_metastasesdx_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_METASTASESDX_Includesortdsc", StringUtil.BoolToStr( Ddo_br_diagnosis_metastasesdx_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_METASTASESDX_Sortedstatus", StringUtil.RTrim( Ddo_br_diagnosis_metastasesdx_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_METASTASESDX_Includefilter", StringUtil.BoolToStr( Ddo_br_diagnosis_metastasesdx_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_METASTASESDX_Includedatalist", StringUtil.BoolToStr( Ddo_br_diagnosis_metastasesdx_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_METASTASESDX_Sortasc", StringUtil.RTrim( Ddo_br_diagnosis_metastasesdx_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_METASTASESDX_Sortdsc", StringUtil.RTrim( Ddo_br_diagnosis_metastasesdx_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_METASTASESDX_Searchbuttontext", StringUtil.RTrim( Ddo_br_diagnosis_metastasesdx_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_METASTASESDX_CODE_Caption", StringUtil.RTrim( Ddo_br_diagnosis_metastasesdx_code_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_METASTASESDX_CODE_Tooltip", StringUtil.RTrim( Ddo_br_diagnosis_metastasesdx_code_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_METASTASESDX_CODE_Cls", StringUtil.RTrim( Ddo_br_diagnosis_metastasesdx_code_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_METASTASESDX_CODE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_diagnosis_metastasesdx_code_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_METASTASESDX_CODE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_diagnosis_metastasesdx_code_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_METASTASESDX_CODE_Includesortasc", StringUtil.BoolToStr( Ddo_br_diagnosis_metastasesdx_code_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_METASTASESDX_CODE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_diagnosis_metastasesdx_code_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_METASTASESDX_CODE_Sortedstatus", StringUtil.RTrim( Ddo_br_diagnosis_metastasesdx_code_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_METASTASESDX_CODE_Includefilter", StringUtil.BoolToStr( Ddo_br_diagnosis_metastasesdx_code_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_METASTASESDX_CODE_Includedatalist", StringUtil.BoolToStr( Ddo_br_diagnosis_metastasesdx_code_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_METASTASESDX_CODE_Sortasc", StringUtil.RTrim( Ddo_br_diagnosis_metastasesdx_code_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_METASTASESDX_CODE_Sortdsc", StringUtil.RTrim( Ddo_br_diagnosis_metastasesdx_code_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_METASTASESDX_CODE_Searchbuttontext", StringUtil.RTrim( Ddo_br_diagnosis_metastasesdx_code_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXSOURCE_Caption", StringUtil.RTrim( Ddo_br_diagnosis_dxsource_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXSOURCE_Tooltip", StringUtil.RTrim( Ddo_br_diagnosis_dxsource_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXSOURCE_Cls", StringUtil.RTrim( Ddo_br_diagnosis_dxsource_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXSOURCE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_diagnosis_dxsource_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXSOURCE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_diagnosis_dxsource_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXSOURCE_Includesortasc", StringUtil.BoolToStr( Ddo_br_diagnosis_dxsource_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXSOURCE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_diagnosis_dxsource_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXSOURCE_Sortedstatus", StringUtil.RTrim( Ddo_br_diagnosis_dxsource_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXSOURCE_Includefilter", StringUtil.BoolToStr( Ddo_br_diagnosis_dxsource_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXSOURCE_Includedatalist", StringUtil.BoolToStr( Ddo_br_diagnosis_dxsource_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXSOURCE_Sortasc", StringUtil.RTrim( Ddo_br_diagnosis_dxsource_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXSOURCE_Sortdsc", StringUtil.RTrim( Ddo_br_diagnosis_dxsource_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXSOURCE_Searchbuttontext", StringUtil.RTrim( Ddo_br_diagnosis_dxsource_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSISID_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosisid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey", StringUtil.RTrim( Ddo_br_information_patientno_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_NO_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_no_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXID_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_dxid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXCODE_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_dxcode_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTYPE_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTYPE_CODE_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_code_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTSOURCE_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_code_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXDESCRIPTION_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_dxdescription_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_INITIALDX_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_initialdx_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_INITIALDX_CODE_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_initialdx_code_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_METASTASESDX_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_metastasesdx_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_METASTASESDX_CODE_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_metastasesdx_code_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXSOURCE_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_dxsource_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSISID_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosisid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey", StringUtil.RTrim( Ddo_br_information_patientno_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_NO_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_no_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXID_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_dxid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXCODE_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_dxcode_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTYPE_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTYPE_CODE_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_dxtype_code_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTSOURCE_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_dxtsource_code_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXDESCRIPTION_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_dxdescription_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_INITIALDX_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_initialdx_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_INITIALDX_CODE_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_initialdx_code_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_METASTASESDX_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_metastasesdx_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_METASTASESDX_CODE_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_metastasesdx_code_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DIAGNOSIS_DXSOURCE_Activeeventkey", StringUtil.RTrim( Ddo_br_diagnosis_dxsource_Activeeventkey));
      }

      protected void RenderHtmlCloseForm3D2( )
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
         return "BR_DiagnosisPrompt" ;
      }

      public override String GetPgmdesc( )
      {
         return "选择诊断" ;
      }

      protected void WB3D0( )
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
               if ( edtBR_DiagnosisID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_DiagnosisID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_DiagnosisID_Title) ;
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
               if ( edtBR_Diagnosis_No_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Diagnosis_No_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Diagnosis_No_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Diagnosis_DXID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Diagnosis_DXID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Diagnosis_DXID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Diagnosis_DXCode_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Diagnosis_DXCode_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Diagnosis_DXCode_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Diagnosis_DXType_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Diagnosis_DXType_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Diagnosis_DXType_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Diagnosis_DXType_Code_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Diagnosis_DXType_Code_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Diagnosis_DXType_Code_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Diagnosis_DXTsource_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Diagnosis_DXTsource_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Diagnosis_DXTsource_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Diagnosis_DXTsource_Code_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Diagnosis_DXTsource_Code_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Diagnosis_DXTsource_Code_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Diagnosis_DXDescription_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Diagnosis_DXDescription_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Diagnosis_DXDescription_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( cmbBR_Diagnosis_InitialDX_Titleformat == 0 )
               {
                  context.SendWebValue( cmbBR_Diagnosis_InitialDX.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( cmbBR_Diagnosis_InitialDX.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Diagnosis_InitialDX_Code_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Diagnosis_InitialDX_Code_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Diagnosis_InitialDX_Code_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( cmbBR_Diagnosis_MetastasesDX_Titleformat == 0 )
               {
                  context.SendWebValue( cmbBR_Diagnosis_MetastasesDX.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( cmbBR_Diagnosis_MetastasesDX.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Diagnosis_MetastasesDX_Code_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Diagnosis_MetastasesDX_Code_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Diagnosis_MetastasesDX_Code_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Diagnosis_DXSource_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Diagnosis_DXSource_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Diagnosis_DXSource_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV37Select));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavSelect_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A64BR_DiagnosisID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_DiagnosisID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_DiagnosisID_Titleformat), 4, 0, ".", "")));
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
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A513BR_Diagnosis_No), 10, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Diagnosis_No_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Diagnosis_No_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A65BR_Diagnosis_DXID);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Diagnosis_DXID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Diagnosis_DXID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A66BR_Diagnosis_DXCode);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Diagnosis_DXCode_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Diagnosis_DXCode_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A67BR_Diagnosis_DXType);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Diagnosis_DXType_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Diagnosis_DXType_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A466BR_Diagnosis_DXType_Code);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Diagnosis_DXType_Code_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Diagnosis_DXType_Code_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A68BR_Diagnosis_DXTsource);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Diagnosis_DXTsource_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Diagnosis_DXTsource_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A467BR_Diagnosis_DXTsource_Code);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Diagnosis_DXTsource_Code_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Diagnosis_DXTsource_Code_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A69BR_Diagnosis_DXDescription);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Diagnosis_DXDescription_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Diagnosis_DXDescription_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A70BR_Diagnosis_InitialDX);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( cmbBR_Diagnosis_InitialDX.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbBR_Diagnosis_InitialDX_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A503BR_Diagnosis_InitialDX_Code);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Diagnosis_InitialDX_Code_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Diagnosis_InitialDX_Code_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A71BR_Diagnosis_MetastasesDX);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( cmbBR_Diagnosis_MetastasesDX.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbBR_Diagnosis_MetastasesDX_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A504BR_Diagnosis_MetastasesDX_Code);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Diagnosis_MetastasesDX_Code_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Diagnosis_MetastasesDX_Code_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A260BR_Diagnosis_DXSource);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Diagnosis_DXSource_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Diagnosis_DXSource_Titleformat), 4, 0, ".", "")));
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
            ucDdo_br_diagnosisid.SetProperty("Caption", Ddo_br_diagnosisid_Caption);
            ucDdo_br_diagnosisid.SetProperty("Tooltip", Ddo_br_diagnosisid_Tooltip);
            ucDdo_br_diagnosisid.SetProperty("Cls", Ddo_br_diagnosisid_Cls);
            ucDdo_br_diagnosisid.SetProperty("DropDownOptionsType", Ddo_br_diagnosisid_Dropdownoptionstype);
            ucDdo_br_diagnosisid.SetProperty("IncludeSortASC", Ddo_br_diagnosisid_Includesortasc);
            ucDdo_br_diagnosisid.SetProperty("IncludeSortDSC", Ddo_br_diagnosisid_Includesortdsc);
            ucDdo_br_diagnosisid.SetProperty("IncludeFilter", Ddo_br_diagnosisid_Includefilter);
            ucDdo_br_diagnosisid.SetProperty("IncludeDataList", Ddo_br_diagnosisid_Includedatalist);
            ucDdo_br_diagnosisid.SetProperty("SortASC", Ddo_br_diagnosisid_Sortasc);
            ucDdo_br_diagnosisid.SetProperty("SortDSC", Ddo_br_diagnosisid_Sortdsc);
            ucDdo_br_diagnosisid.SetProperty("SearchButtonText", Ddo_br_diagnosisid_Searchbuttontext);
            ucDdo_br_diagnosisid.SetProperty("DropDownOptionsTitleSettingsIcons", AV32DDO_TitleSettingsIcons);
            ucDdo_br_diagnosisid.SetProperty("DropDownOptionsData", AV12BR_DiagnosisIDTitleFilterData);
            ucDdo_br_diagnosisid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_diagnosisid_Internalname, "DDO_BR_DIAGNOSISIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_diagnosisidtitlecontrolidtoreplace_Internalname, AV13ddo_BR_DiagnosisIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", 0, edtavDdo_br_diagnosisidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_DiagnosisPrompt.htm");
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
            ucDdo_br_encounterid.SetProperty("DropDownOptionsTitleSettingsIcons", AV32DDO_TitleSettingsIcons);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsData", AV14BR_EncounterIDTitleFilterData);
            ucDdo_br_encounterid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounterid_Internalname, "DDO_BR_ENCOUNTERIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, AV15ddo_BR_EncounterIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,40);\"", 0, edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_DiagnosisPrompt.htm");
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
            ucDdo_br_information_patientno.SetProperty("DropDownOptionsTitleSettingsIcons", AV32DDO_TitleSettingsIcons);
            ucDdo_br_information_patientno.SetProperty("DropDownOptionsData", AV16BR_Information_PatientNoTitleFilterData);
            ucDdo_br_information_patientno.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_information_patientno_Internalname, "DDO_BR_INFORMATION_PATIENTNOContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname, AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,42);\"", 0, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_DiagnosisPrompt.htm");
            /* User Defined Control */
            ucDdo_br_diagnosis_no.SetProperty("Caption", Ddo_br_diagnosis_no_Caption);
            ucDdo_br_diagnosis_no.SetProperty("Tooltip", Ddo_br_diagnosis_no_Tooltip);
            ucDdo_br_diagnosis_no.SetProperty("Cls", Ddo_br_diagnosis_no_Cls);
            ucDdo_br_diagnosis_no.SetProperty("DropDownOptionsType", Ddo_br_diagnosis_no_Dropdownoptionstype);
            ucDdo_br_diagnosis_no.SetProperty("IncludeSortASC", Ddo_br_diagnosis_no_Includesortasc);
            ucDdo_br_diagnosis_no.SetProperty("IncludeSortDSC", Ddo_br_diagnosis_no_Includesortdsc);
            ucDdo_br_diagnosis_no.SetProperty("IncludeFilter", Ddo_br_diagnosis_no_Includefilter);
            ucDdo_br_diagnosis_no.SetProperty("IncludeDataList", Ddo_br_diagnosis_no_Includedatalist);
            ucDdo_br_diagnosis_no.SetProperty("SortASC", Ddo_br_diagnosis_no_Sortasc);
            ucDdo_br_diagnosis_no.SetProperty("SortDSC", Ddo_br_diagnosis_no_Sortdsc);
            ucDdo_br_diagnosis_no.SetProperty("SearchButtonText", Ddo_br_diagnosis_no_Searchbuttontext);
            ucDdo_br_diagnosis_no.SetProperty("DropDownOptionsTitleSettingsIcons", AV32DDO_TitleSettingsIcons);
            ucDdo_br_diagnosis_no.SetProperty("DropDownOptionsData", AV40BR_Diagnosis_NoTitleFilterData);
            ucDdo_br_diagnosis_no.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_diagnosis_no_Internalname, "DDO_BR_DIAGNOSIS_NOContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_diagnosis_notitlecontrolidtoreplace_Internalname, AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", 0, edtavDdo_br_diagnosis_notitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_DiagnosisPrompt.htm");
            /* User Defined Control */
            ucDdo_br_diagnosis_dxid.SetProperty("Caption", Ddo_br_diagnosis_dxid_Caption);
            ucDdo_br_diagnosis_dxid.SetProperty("Tooltip", Ddo_br_diagnosis_dxid_Tooltip);
            ucDdo_br_diagnosis_dxid.SetProperty("Cls", Ddo_br_diagnosis_dxid_Cls);
            ucDdo_br_diagnosis_dxid.SetProperty("DropDownOptionsType", Ddo_br_diagnosis_dxid_Dropdownoptionstype);
            ucDdo_br_diagnosis_dxid.SetProperty("IncludeSortASC", Ddo_br_diagnosis_dxid_Includesortasc);
            ucDdo_br_diagnosis_dxid.SetProperty("IncludeSortDSC", Ddo_br_diagnosis_dxid_Includesortdsc);
            ucDdo_br_diagnosis_dxid.SetProperty("IncludeFilter", Ddo_br_diagnosis_dxid_Includefilter);
            ucDdo_br_diagnosis_dxid.SetProperty("IncludeDataList", Ddo_br_diagnosis_dxid_Includedatalist);
            ucDdo_br_diagnosis_dxid.SetProperty("SortASC", Ddo_br_diagnosis_dxid_Sortasc);
            ucDdo_br_diagnosis_dxid.SetProperty("SortDSC", Ddo_br_diagnosis_dxid_Sortdsc);
            ucDdo_br_diagnosis_dxid.SetProperty("SearchButtonText", Ddo_br_diagnosis_dxid_Searchbuttontext);
            ucDdo_br_diagnosis_dxid.SetProperty("DropDownOptionsTitleSettingsIcons", AV32DDO_TitleSettingsIcons);
            ucDdo_br_diagnosis_dxid.SetProperty("DropDownOptionsData", AV18BR_Diagnosis_DXIDTitleFilterData);
            ucDdo_br_diagnosis_dxid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_diagnosis_dxid_Internalname, "DDO_BR_DIAGNOSIS_DXIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_diagnosis_dxidtitlecontrolidtoreplace_Internalname, AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", 0, edtavDdo_br_diagnosis_dxidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_DiagnosisPrompt.htm");
            /* User Defined Control */
            ucDdo_br_diagnosis_dxcode.SetProperty("Caption", Ddo_br_diagnosis_dxcode_Caption);
            ucDdo_br_diagnosis_dxcode.SetProperty("Tooltip", Ddo_br_diagnosis_dxcode_Tooltip);
            ucDdo_br_diagnosis_dxcode.SetProperty("Cls", Ddo_br_diagnosis_dxcode_Cls);
            ucDdo_br_diagnosis_dxcode.SetProperty("DropDownOptionsType", Ddo_br_diagnosis_dxcode_Dropdownoptionstype);
            ucDdo_br_diagnosis_dxcode.SetProperty("IncludeSortASC", Ddo_br_diagnosis_dxcode_Includesortasc);
            ucDdo_br_diagnosis_dxcode.SetProperty("IncludeSortDSC", Ddo_br_diagnosis_dxcode_Includesortdsc);
            ucDdo_br_diagnosis_dxcode.SetProperty("IncludeFilter", Ddo_br_diagnosis_dxcode_Includefilter);
            ucDdo_br_diagnosis_dxcode.SetProperty("IncludeDataList", Ddo_br_diagnosis_dxcode_Includedatalist);
            ucDdo_br_diagnosis_dxcode.SetProperty("SortASC", Ddo_br_diagnosis_dxcode_Sortasc);
            ucDdo_br_diagnosis_dxcode.SetProperty("SortDSC", Ddo_br_diagnosis_dxcode_Sortdsc);
            ucDdo_br_diagnosis_dxcode.SetProperty("SearchButtonText", Ddo_br_diagnosis_dxcode_Searchbuttontext);
            ucDdo_br_diagnosis_dxcode.SetProperty("DropDownOptionsTitleSettingsIcons", AV32DDO_TitleSettingsIcons);
            ucDdo_br_diagnosis_dxcode.SetProperty("DropDownOptionsData", AV20BR_Diagnosis_DXCodeTitleFilterData);
            ucDdo_br_diagnosis_dxcode.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_diagnosis_dxcode_Internalname, "DDO_BR_DIAGNOSIS_DXCODEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_diagnosis_dxcodetitlecontrolidtoreplace_Internalname, AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", 0, edtavDdo_br_diagnosis_dxcodetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_DiagnosisPrompt.htm");
            /* User Defined Control */
            ucDdo_br_diagnosis_dxtype.SetProperty("Caption", Ddo_br_diagnosis_dxtype_Caption);
            ucDdo_br_diagnosis_dxtype.SetProperty("Tooltip", Ddo_br_diagnosis_dxtype_Tooltip);
            ucDdo_br_diagnosis_dxtype.SetProperty("Cls", Ddo_br_diagnosis_dxtype_Cls);
            ucDdo_br_diagnosis_dxtype.SetProperty("DropDownOptionsType", Ddo_br_diagnosis_dxtype_Dropdownoptionstype);
            ucDdo_br_diagnosis_dxtype.SetProperty("IncludeSortASC", Ddo_br_diagnosis_dxtype_Includesortasc);
            ucDdo_br_diagnosis_dxtype.SetProperty("IncludeSortDSC", Ddo_br_diagnosis_dxtype_Includesortdsc);
            ucDdo_br_diagnosis_dxtype.SetProperty("IncludeFilter", Ddo_br_diagnosis_dxtype_Includefilter);
            ucDdo_br_diagnosis_dxtype.SetProperty("IncludeDataList", Ddo_br_diagnosis_dxtype_Includedatalist);
            ucDdo_br_diagnosis_dxtype.SetProperty("SortASC", Ddo_br_diagnosis_dxtype_Sortasc);
            ucDdo_br_diagnosis_dxtype.SetProperty("SortDSC", Ddo_br_diagnosis_dxtype_Sortdsc);
            ucDdo_br_diagnosis_dxtype.SetProperty("SearchButtonText", Ddo_br_diagnosis_dxtype_Searchbuttontext);
            ucDdo_br_diagnosis_dxtype.SetProperty("DropDownOptionsTitleSettingsIcons", AV32DDO_TitleSettingsIcons);
            ucDdo_br_diagnosis_dxtype.SetProperty("DropDownOptionsData", AV22BR_Diagnosis_DXTypeTitleFilterData);
            ucDdo_br_diagnosis_dxtype.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_diagnosis_dxtype_Internalname, "DDO_BR_DIAGNOSIS_DXTYPEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_diagnosis_dxtypetitlecontrolidtoreplace_Internalname, AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", 0, edtavDdo_br_diagnosis_dxtypetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_DiagnosisPrompt.htm");
            /* User Defined Control */
            ucDdo_br_diagnosis_dxtype_code.SetProperty("Caption", Ddo_br_diagnosis_dxtype_code_Caption);
            ucDdo_br_diagnosis_dxtype_code.SetProperty("Tooltip", Ddo_br_diagnosis_dxtype_code_Tooltip);
            ucDdo_br_diagnosis_dxtype_code.SetProperty("Cls", Ddo_br_diagnosis_dxtype_code_Cls);
            ucDdo_br_diagnosis_dxtype_code.SetProperty("DropDownOptionsType", Ddo_br_diagnosis_dxtype_code_Dropdownoptionstype);
            ucDdo_br_diagnosis_dxtype_code.SetProperty("IncludeSortASC", Ddo_br_diagnosis_dxtype_code_Includesortasc);
            ucDdo_br_diagnosis_dxtype_code.SetProperty("IncludeSortDSC", Ddo_br_diagnosis_dxtype_code_Includesortdsc);
            ucDdo_br_diagnosis_dxtype_code.SetProperty("IncludeFilter", Ddo_br_diagnosis_dxtype_code_Includefilter);
            ucDdo_br_diagnosis_dxtype_code.SetProperty("IncludeDataList", Ddo_br_diagnosis_dxtype_code_Includedatalist);
            ucDdo_br_diagnosis_dxtype_code.SetProperty("SortASC", Ddo_br_diagnosis_dxtype_code_Sortasc);
            ucDdo_br_diagnosis_dxtype_code.SetProperty("SortDSC", Ddo_br_diagnosis_dxtype_code_Sortdsc);
            ucDdo_br_diagnosis_dxtype_code.SetProperty("SearchButtonText", Ddo_br_diagnosis_dxtype_code_Searchbuttontext);
            ucDdo_br_diagnosis_dxtype_code.SetProperty("DropDownOptionsTitleSettingsIcons", AV32DDO_TitleSettingsIcons);
            ucDdo_br_diagnosis_dxtype_code.SetProperty("DropDownOptionsData", AV42BR_Diagnosis_DXType_CodeTitleFilterData);
            ucDdo_br_diagnosis_dxtype_code.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_diagnosis_dxtype_code_Internalname, "DDO_BR_DIAGNOSIS_DXTYPE_CODEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_diagnosis_dxtype_codetitlecontrolidtoreplace_Internalname, AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", 0, edtavDdo_br_diagnosis_dxtype_codetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_DiagnosisPrompt.htm");
            /* User Defined Control */
            ucDdo_br_diagnosis_dxtsource.SetProperty("Caption", Ddo_br_diagnosis_dxtsource_Caption);
            ucDdo_br_diagnosis_dxtsource.SetProperty("Tooltip", Ddo_br_diagnosis_dxtsource_Tooltip);
            ucDdo_br_diagnosis_dxtsource.SetProperty("Cls", Ddo_br_diagnosis_dxtsource_Cls);
            ucDdo_br_diagnosis_dxtsource.SetProperty("DropDownOptionsType", Ddo_br_diagnosis_dxtsource_Dropdownoptionstype);
            ucDdo_br_diagnosis_dxtsource.SetProperty("IncludeSortASC", Ddo_br_diagnosis_dxtsource_Includesortasc);
            ucDdo_br_diagnosis_dxtsource.SetProperty("IncludeSortDSC", Ddo_br_diagnosis_dxtsource_Includesortdsc);
            ucDdo_br_diagnosis_dxtsource.SetProperty("IncludeFilter", Ddo_br_diagnosis_dxtsource_Includefilter);
            ucDdo_br_diagnosis_dxtsource.SetProperty("IncludeDataList", Ddo_br_diagnosis_dxtsource_Includedatalist);
            ucDdo_br_diagnosis_dxtsource.SetProperty("SortASC", Ddo_br_diagnosis_dxtsource_Sortasc);
            ucDdo_br_diagnosis_dxtsource.SetProperty("SortDSC", Ddo_br_diagnosis_dxtsource_Sortdsc);
            ucDdo_br_diagnosis_dxtsource.SetProperty("SearchButtonText", Ddo_br_diagnosis_dxtsource_Searchbuttontext);
            ucDdo_br_diagnosis_dxtsource.SetProperty("DropDownOptionsTitleSettingsIcons", AV32DDO_TitleSettingsIcons);
            ucDdo_br_diagnosis_dxtsource.SetProperty("DropDownOptionsData", AV24BR_Diagnosis_DXTsourceTitleFilterData);
            ucDdo_br_diagnosis_dxtsource.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_diagnosis_dxtsource_Internalname, "DDO_BR_DIAGNOSIS_DXTSOURCEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_diagnosis_dxtsourcetitlecontrolidtoreplace_Internalname, AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", 0, edtavDdo_br_diagnosis_dxtsourcetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_DiagnosisPrompt.htm");
            /* User Defined Control */
            ucDdo_br_diagnosis_dxtsource_code.SetProperty("Caption", Ddo_br_diagnosis_dxtsource_code_Caption);
            ucDdo_br_diagnosis_dxtsource_code.SetProperty("Tooltip", Ddo_br_diagnosis_dxtsource_code_Tooltip);
            ucDdo_br_diagnosis_dxtsource_code.SetProperty("Cls", Ddo_br_diagnosis_dxtsource_code_Cls);
            ucDdo_br_diagnosis_dxtsource_code.SetProperty("DropDownOptionsType", Ddo_br_diagnosis_dxtsource_code_Dropdownoptionstype);
            ucDdo_br_diagnosis_dxtsource_code.SetProperty("IncludeSortASC", Ddo_br_diagnosis_dxtsource_code_Includesortasc);
            ucDdo_br_diagnosis_dxtsource_code.SetProperty("IncludeSortDSC", Ddo_br_diagnosis_dxtsource_code_Includesortdsc);
            ucDdo_br_diagnosis_dxtsource_code.SetProperty("IncludeFilter", Ddo_br_diagnosis_dxtsource_code_Includefilter);
            ucDdo_br_diagnosis_dxtsource_code.SetProperty("IncludeDataList", Ddo_br_diagnosis_dxtsource_code_Includedatalist);
            ucDdo_br_diagnosis_dxtsource_code.SetProperty("SortASC", Ddo_br_diagnosis_dxtsource_code_Sortasc);
            ucDdo_br_diagnosis_dxtsource_code.SetProperty("SortDSC", Ddo_br_diagnosis_dxtsource_code_Sortdsc);
            ucDdo_br_diagnosis_dxtsource_code.SetProperty("SearchButtonText", Ddo_br_diagnosis_dxtsource_code_Searchbuttontext);
            ucDdo_br_diagnosis_dxtsource_code.SetProperty("DropDownOptionsTitleSettingsIcons", AV32DDO_TitleSettingsIcons);
            ucDdo_br_diagnosis_dxtsource_code.SetProperty("DropDownOptionsData", AV44BR_Diagnosis_DXTsource_CodeTitleFilterData);
            ucDdo_br_diagnosis_dxtsource_code.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_diagnosis_dxtsource_code_Internalname, "DDO_BR_DIAGNOSIS_DXTSOURCE_CODEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_diagnosis_dxtsource_codetitlecontrolidtoreplace_Internalname, AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", 0, edtavDdo_br_diagnosis_dxtsource_codetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_DiagnosisPrompt.htm");
            /* User Defined Control */
            ucDdo_br_diagnosis_dxdescription.SetProperty("Caption", Ddo_br_diagnosis_dxdescription_Caption);
            ucDdo_br_diagnosis_dxdescription.SetProperty("Tooltip", Ddo_br_diagnosis_dxdescription_Tooltip);
            ucDdo_br_diagnosis_dxdescription.SetProperty("Cls", Ddo_br_diagnosis_dxdescription_Cls);
            ucDdo_br_diagnosis_dxdescription.SetProperty("DropDownOptionsType", Ddo_br_diagnosis_dxdescription_Dropdownoptionstype);
            ucDdo_br_diagnosis_dxdescription.SetProperty("IncludeSortASC", Ddo_br_diagnosis_dxdescription_Includesortasc);
            ucDdo_br_diagnosis_dxdescription.SetProperty("IncludeSortDSC", Ddo_br_diagnosis_dxdescription_Includesortdsc);
            ucDdo_br_diagnosis_dxdescription.SetProperty("IncludeFilter", Ddo_br_diagnosis_dxdescription_Includefilter);
            ucDdo_br_diagnosis_dxdescription.SetProperty("IncludeDataList", Ddo_br_diagnosis_dxdescription_Includedatalist);
            ucDdo_br_diagnosis_dxdescription.SetProperty("SortASC", Ddo_br_diagnosis_dxdescription_Sortasc);
            ucDdo_br_diagnosis_dxdescription.SetProperty("SortDSC", Ddo_br_diagnosis_dxdescription_Sortdsc);
            ucDdo_br_diagnosis_dxdescription.SetProperty("SearchButtonText", Ddo_br_diagnosis_dxdescription_Searchbuttontext);
            ucDdo_br_diagnosis_dxdescription.SetProperty("DropDownOptionsTitleSettingsIcons", AV32DDO_TitleSettingsIcons);
            ucDdo_br_diagnosis_dxdescription.SetProperty("DropDownOptionsData", AV26BR_Diagnosis_DXDescriptionTitleFilterData);
            ucDdo_br_diagnosis_dxdescription.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_diagnosis_dxdescription_Internalname, "DDO_BR_DIAGNOSIS_DXDESCRIPTIONContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_diagnosis_dxdescriptiontitlecontrolidtoreplace_Internalname, AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", 0, edtavDdo_br_diagnosis_dxdescriptiontitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_DiagnosisPrompt.htm");
            /* User Defined Control */
            ucDdo_br_diagnosis_initialdx.SetProperty("Caption", Ddo_br_diagnosis_initialdx_Caption);
            ucDdo_br_diagnosis_initialdx.SetProperty("Tooltip", Ddo_br_diagnosis_initialdx_Tooltip);
            ucDdo_br_diagnosis_initialdx.SetProperty("Cls", Ddo_br_diagnosis_initialdx_Cls);
            ucDdo_br_diagnosis_initialdx.SetProperty("DropDownOptionsType", Ddo_br_diagnosis_initialdx_Dropdownoptionstype);
            ucDdo_br_diagnosis_initialdx.SetProperty("IncludeSortASC", Ddo_br_diagnosis_initialdx_Includesortasc);
            ucDdo_br_diagnosis_initialdx.SetProperty("IncludeSortDSC", Ddo_br_diagnosis_initialdx_Includesortdsc);
            ucDdo_br_diagnosis_initialdx.SetProperty("IncludeFilter", Ddo_br_diagnosis_initialdx_Includefilter);
            ucDdo_br_diagnosis_initialdx.SetProperty("IncludeDataList", Ddo_br_diagnosis_initialdx_Includedatalist);
            ucDdo_br_diagnosis_initialdx.SetProperty("SortASC", Ddo_br_diagnosis_initialdx_Sortasc);
            ucDdo_br_diagnosis_initialdx.SetProperty("SortDSC", Ddo_br_diagnosis_initialdx_Sortdsc);
            ucDdo_br_diagnosis_initialdx.SetProperty("SearchButtonText", Ddo_br_diagnosis_initialdx_Searchbuttontext);
            ucDdo_br_diagnosis_initialdx.SetProperty("DropDownOptionsTitleSettingsIcons", AV32DDO_TitleSettingsIcons);
            ucDdo_br_diagnosis_initialdx.SetProperty("DropDownOptionsData", AV28BR_Diagnosis_InitialDXTitleFilterData);
            ucDdo_br_diagnosis_initialdx.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_diagnosis_initialdx_Internalname, "DDO_BR_DIAGNOSIS_INITIALDXContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_diagnosis_initialdxtitlecontrolidtoreplace_Internalname, AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,60);\"", 0, edtavDdo_br_diagnosis_initialdxtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_DiagnosisPrompt.htm");
            /* User Defined Control */
            ucDdo_br_diagnosis_initialdx_code.SetProperty("Caption", Ddo_br_diagnosis_initialdx_code_Caption);
            ucDdo_br_diagnosis_initialdx_code.SetProperty("Tooltip", Ddo_br_diagnosis_initialdx_code_Tooltip);
            ucDdo_br_diagnosis_initialdx_code.SetProperty("Cls", Ddo_br_diagnosis_initialdx_code_Cls);
            ucDdo_br_diagnosis_initialdx_code.SetProperty("DropDownOptionsType", Ddo_br_diagnosis_initialdx_code_Dropdownoptionstype);
            ucDdo_br_diagnosis_initialdx_code.SetProperty("IncludeSortASC", Ddo_br_diagnosis_initialdx_code_Includesortasc);
            ucDdo_br_diagnosis_initialdx_code.SetProperty("IncludeSortDSC", Ddo_br_diagnosis_initialdx_code_Includesortdsc);
            ucDdo_br_diagnosis_initialdx_code.SetProperty("IncludeFilter", Ddo_br_diagnosis_initialdx_code_Includefilter);
            ucDdo_br_diagnosis_initialdx_code.SetProperty("IncludeDataList", Ddo_br_diagnosis_initialdx_code_Includedatalist);
            ucDdo_br_diagnosis_initialdx_code.SetProperty("SortASC", Ddo_br_diagnosis_initialdx_code_Sortasc);
            ucDdo_br_diagnosis_initialdx_code.SetProperty("SortDSC", Ddo_br_diagnosis_initialdx_code_Sortdsc);
            ucDdo_br_diagnosis_initialdx_code.SetProperty("SearchButtonText", Ddo_br_diagnosis_initialdx_code_Searchbuttontext);
            ucDdo_br_diagnosis_initialdx_code.SetProperty("DropDownOptionsTitleSettingsIcons", AV32DDO_TitleSettingsIcons);
            ucDdo_br_diagnosis_initialdx_code.SetProperty("DropDownOptionsData", AV46BR_Diagnosis_InitialDX_CodeTitleFilterData);
            ucDdo_br_diagnosis_initialdx_code.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_diagnosis_initialdx_code_Internalname, "DDO_BR_DIAGNOSIS_INITIALDX_CODEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_diagnosis_initialdx_codetitlecontrolidtoreplace_Internalname, AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,62);\"", 0, edtavDdo_br_diagnosis_initialdx_codetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_DiagnosisPrompt.htm");
            /* User Defined Control */
            ucDdo_br_diagnosis_metastasesdx.SetProperty("Caption", Ddo_br_diagnosis_metastasesdx_Caption);
            ucDdo_br_diagnosis_metastasesdx.SetProperty("Tooltip", Ddo_br_diagnosis_metastasesdx_Tooltip);
            ucDdo_br_diagnosis_metastasesdx.SetProperty("Cls", Ddo_br_diagnosis_metastasesdx_Cls);
            ucDdo_br_diagnosis_metastasesdx.SetProperty("DropDownOptionsType", Ddo_br_diagnosis_metastasesdx_Dropdownoptionstype);
            ucDdo_br_diagnosis_metastasesdx.SetProperty("IncludeSortASC", Ddo_br_diagnosis_metastasesdx_Includesortasc);
            ucDdo_br_diagnosis_metastasesdx.SetProperty("IncludeSortDSC", Ddo_br_diagnosis_metastasesdx_Includesortdsc);
            ucDdo_br_diagnosis_metastasesdx.SetProperty("IncludeFilter", Ddo_br_diagnosis_metastasesdx_Includefilter);
            ucDdo_br_diagnosis_metastasesdx.SetProperty("IncludeDataList", Ddo_br_diagnosis_metastasesdx_Includedatalist);
            ucDdo_br_diagnosis_metastasesdx.SetProperty("SortASC", Ddo_br_diagnosis_metastasesdx_Sortasc);
            ucDdo_br_diagnosis_metastasesdx.SetProperty("SortDSC", Ddo_br_diagnosis_metastasesdx_Sortdsc);
            ucDdo_br_diagnosis_metastasesdx.SetProperty("SearchButtonText", Ddo_br_diagnosis_metastasesdx_Searchbuttontext);
            ucDdo_br_diagnosis_metastasesdx.SetProperty("DropDownOptionsTitleSettingsIcons", AV32DDO_TitleSettingsIcons);
            ucDdo_br_diagnosis_metastasesdx.SetProperty("DropDownOptionsData", AV30BR_Diagnosis_MetastasesDXTitleFilterData);
            ucDdo_br_diagnosis_metastasesdx.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_diagnosis_metastasesdx_Internalname, "DDO_BR_DIAGNOSIS_METASTASESDXContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_diagnosis_metastasesdxtitlecontrolidtoreplace_Internalname, AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", 0, edtavDdo_br_diagnosis_metastasesdxtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_DiagnosisPrompt.htm");
            /* User Defined Control */
            ucDdo_br_diagnosis_metastasesdx_code.SetProperty("Caption", Ddo_br_diagnosis_metastasesdx_code_Caption);
            ucDdo_br_diagnosis_metastasesdx_code.SetProperty("Tooltip", Ddo_br_diagnosis_metastasesdx_code_Tooltip);
            ucDdo_br_diagnosis_metastasesdx_code.SetProperty("Cls", Ddo_br_diagnosis_metastasesdx_code_Cls);
            ucDdo_br_diagnosis_metastasesdx_code.SetProperty("DropDownOptionsType", Ddo_br_diagnosis_metastasesdx_code_Dropdownoptionstype);
            ucDdo_br_diagnosis_metastasesdx_code.SetProperty("IncludeSortASC", Ddo_br_diagnosis_metastasesdx_code_Includesortasc);
            ucDdo_br_diagnosis_metastasesdx_code.SetProperty("IncludeSortDSC", Ddo_br_diagnosis_metastasesdx_code_Includesortdsc);
            ucDdo_br_diagnosis_metastasesdx_code.SetProperty("IncludeFilter", Ddo_br_diagnosis_metastasesdx_code_Includefilter);
            ucDdo_br_diagnosis_metastasesdx_code.SetProperty("IncludeDataList", Ddo_br_diagnosis_metastasesdx_code_Includedatalist);
            ucDdo_br_diagnosis_metastasesdx_code.SetProperty("SortASC", Ddo_br_diagnosis_metastasesdx_code_Sortasc);
            ucDdo_br_diagnosis_metastasesdx_code.SetProperty("SortDSC", Ddo_br_diagnosis_metastasesdx_code_Sortdsc);
            ucDdo_br_diagnosis_metastasesdx_code.SetProperty("SearchButtonText", Ddo_br_diagnosis_metastasesdx_code_Searchbuttontext);
            ucDdo_br_diagnosis_metastasesdx_code.SetProperty("DropDownOptionsTitleSettingsIcons", AV32DDO_TitleSettingsIcons);
            ucDdo_br_diagnosis_metastasesdx_code.SetProperty("DropDownOptionsData", AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData);
            ucDdo_br_diagnosis_metastasesdx_code.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_diagnosis_metastasesdx_code_Internalname, "DDO_BR_DIAGNOSIS_METASTASESDX_CODEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_diagnosis_metastasesdx_codetitlecontrolidtoreplace_Internalname, AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", 0, edtavDdo_br_diagnosis_metastasesdx_codetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_DiagnosisPrompt.htm");
            /* User Defined Control */
            ucDdo_br_diagnosis_dxsource.SetProperty("Caption", Ddo_br_diagnosis_dxsource_Caption);
            ucDdo_br_diagnosis_dxsource.SetProperty("Tooltip", Ddo_br_diagnosis_dxsource_Tooltip);
            ucDdo_br_diagnosis_dxsource.SetProperty("Cls", Ddo_br_diagnosis_dxsource_Cls);
            ucDdo_br_diagnosis_dxsource.SetProperty("DropDownOptionsType", Ddo_br_diagnosis_dxsource_Dropdownoptionstype);
            ucDdo_br_diagnosis_dxsource.SetProperty("IncludeSortASC", Ddo_br_diagnosis_dxsource_Includesortasc);
            ucDdo_br_diagnosis_dxsource.SetProperty("IncludeSortDSC", Ddo_br_diagnosis_dxsource_Includesortdsc);
            ucDdo_br_diagnosis_dxsource.SetProperty("IncludeFilter", Ddo_br_diagnosis_dxsource_Includefilter);
            ucDdo_br_diagnosis_dxsource.SetProperty("IncludeDataList", Ddo_br_diagnosis_dxsource_Includedatalist);
            ucDdo_br_diagnosis_dxsource.SetProperty("SortASC", Ddo_br_diagnosis_dxsource_Sortasc);
            ucDdo_br_diagnosis_dxsource.SetProperty("SortDSC", Ddo_br_diagnosis_dxsource_Sortdsc);
            ucDdo_br_diagnosis_dxsource.SetProperty("SearchButtonText", Ddo_br_diagnosis_dxsource_Searchbuttontext);
            ucDdo_br_diagnosis_dxsource.SetProperty("DropDownOptionsTitleSettingsIcons", AV32DDO_TitleSettingsIcons);
            ucDdo_br_diagnosis_dxsource.SetProperty("DropDownOptionsData", AV38BR_Diagnosis_DXSourceTitleFilterData);
            ucDdo_br_diagnosis_dxsource.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_diagnosis_dxsource_Internalname, "DDO_BR_DIAGNOSIS_DXSOURCEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_diagnosis_dxsourcetitlecontrolidtoreplace_Internalname, AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,68);\"", 0, edtavDdo_br_diagnosis_dxsourcetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_DiagnosisPrompt.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,70);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_DiagnosisPrompt.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV11OrderedDsc), StringUtil.BoolToStr( AV11OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,71);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_DiagnosisPrompt.htm");
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

      protected void START3D2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "选择诊断", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP3D0( ) ;
      }

      protected void WS3D2( )
      {
         START3D2( ) ;
         EVT3D2( ) ;
      }

      protected void EVT3D2( )
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
                           E113D2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E123D2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_DIAGNOSISID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E133D2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTERID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E143D2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E153D2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_DIAGNOSIS_NO.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E163D2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_DIAGNOSIS_DXID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E173D2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_DIAGNOSIS_DXCODE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E183D2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_DIAGNOSIS_DXTYPE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E193D2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_DIAGNOSIS_DXTYPE_CODE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E203D2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_DIAGNOSIS_DXTSOURCE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E213D2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E223D2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_DIAGNOSIS_DXDESCRIPTION.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E233D2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_DIAGNOSIS_INITIALDX.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E243D2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_DIAGNOSIS_INITIALDX_CODE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E253D2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_DIAGNOSIS_METASTASESDX.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E263D2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_DIAGNOSIS_METASTASESDX_CODE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E273D2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_DIAGNOSIS_DXSOURCE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E283D2 ();
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
                           AV37Select = cgiGet( edtavSelect_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV37Select)) ? AV53Select_GXI : context.convertURL( context.PathToRelativeUrl( AV37Select))), !bGXsfl_12_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "SrcSet", context.GetImageSrcSet( AV37Select), true);
                           A64BR_DiagnosisID = (long)(context.localUtil.CToN( cgiGet( edtBR_DiagnosisID_Internalname), ".", ","));
                           A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
                           A36BR_Information_PatientNo = cgiGet( edtBR_Information_PatientNo_Internalname);
                           n36BR_Information_PatientNo = false;
                           A513BR_Diagnosis_No = (long)(context.localUtil.CToN( cgiGet( edtBR_Diagnosis_No_Internalname), ".", ","));
                           n513BR_Diagnosis_No = false;
                           A65BR_Diagnosis_DXID = cgiGet( edtBR_Diagnosis_DXID_Internalname);
                           n65BR_Diagnosis_DXID = false;
                           A66BR_Diagnosis_DXCode = cgiGet( edtBR_Diagnosis_DXCode_Internalname);
                           n66BR_Diagnosis_DXCode = false;
                           A67BR_Diagnosis_DXType = cgiGet( edtBR_Diagnosis_DXType_Internalname);
                           n67BR_Diagnosis_DXType = false;
                           A466BR_Diagnosis_DXType_Code = cgiGet( edtBR_Diagnosis_DXType_Code_Internalname);
                           n466BR_Diagnosis_DXType_Code = false;
                           A68BR_Diagnosis_DXTsource = cgiGet( edtBR_Diagnosis_DXTsource_Internalname);
                           n68BR_Diagnosis_DXTsource = false;
                           A467BR_Diagnosis_DXTsource_Code = cgiGet( edtBR_Diagnosis_DXTsource_Code_Internalname);
                           n467BR_Diagnosis_DXTsource_Code = false;
                           A69BR_Diagnosis_DXDescription = cgiGet( edtBR_Diagnosis_DXDescription_Internalname);
                           n69BR_Diagnosis_DXDescription = false;
                           cmbBR_Diagnosis_InitialDX.Name = cmbBR_Diagnosis_InitialDX_Internalname;
                           cmbBR_Diagnosis_InitialDX.CurrentValue = cgiGet( cmbBR_Diagnosis_InitialDX_Internalname);
                           A70BR_Diagnosis_InitialDX = cgiGet( cmbBR_Diagnosis_InitialDX_Internalname);
                           n70BR_Diagnosis_InitialDX = false;
                           A503BR_Diagnosis_InitialDX_Code = cgiGet( edtBR_Diagnosis_InitialDX_Code_Internalname);
                           n503BR_Diagnosis_InitialDX_Code = false;
                           cmbBR_Diagnosis_MetastasesDX.Name = cmbBR_Diagnosis_MetastasesDX_Internalname;
                           cmbBR_Diagnosis_MetastasesDX.CurrentValue = cgiGet( cmbBR_Diagnosis_MetastasesDX_Internalname);
                           A71BR_Diagnosis_MetastasesDX = cgiGet( cmbBR_Diagnosis_MetastasesDX_Internalname);
                           n71BR_Diagnosis_MetastasesDX = false;
                           A504BR_Diagnosis_MetastasesDX_Code = cgiGet( edtBR_Diagnosis_MetastasesDX_Code_Internalname);
                           n504BR_Diagnosis_MetastasesDX_Code = false;
                           A260BR_Diagnosis_DXSource = cgiGet( edtBR_Diagnosis_DXSource_Internalname);
                           n260BR_Diagnosis_DXSource = false;
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E293D2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E303D2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E313D2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    Rfr0gs = false;
                                    /* Set Refresh If Orderedby Changed */
                                    if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV10OrderedBy )) )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Ordereddsc Changed */
                                    if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV11OrderedDsc )
                                    {
                                       Rfr0gs = true;
                                    }
                                    if ( ! Rfr0gs )
                                    {
                                       /* Execute user event: Enter */
                                       E323D2 ();
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

      protected void WE3D2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm3D2( ) ;
            }
         }
      }

      protected void PA3D2( )
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
               GX_FocusControl = edtavDdo_br_diagnosisidtitlecontrolidtoreplace_Internalname;
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
                                       short AV10OrderedBy ,
                                       bool AV11OrderedDsc ,
                                       String AV13ddo_BR_DiagnosisIDTitleControlIdToReplace ,
                                       String AV15ddo_BR_EncounterIDTitleControlIdToReplace ,
                                       String AV17ddo_BR_Information_PatientNoTitleControlIdToReplace ,
                                       String AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace ,
                                       String AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace ,
                                       String AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace ,
                                       String AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace ,
                                       String AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace ,
                                       String AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace ,
                                       String AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace ,
                                       String AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace ,
                                       String AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace ,
                                       String AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace ,
                                       String AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace ,
                                       String AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace ,
                                       String AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF3D2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_DIAGNOSISID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A64BR_DiagnosisID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_DIAGNOSISID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A64BR_DiagnosisID), 18, 0, ".", "")));
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
         RF3D2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV52Pgmname = "BR_DiagnosisPrompt";
         context.Gx_err = 0;
      }

      protected void RF3D2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 12;
         /* Execute user event: Refresh */
         E303D2 ();
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
                                                 AV10OrderedBy ,
                                                 AV11OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            /* Using cursor H003D2 */
            pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_12_idx = 1;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A85BR_Information_ID = H003D2_A85BR_Information_ID[0];
               n85BR_Information_ID = H003D2_n85BR_Information_ID[0];
               A260BR_Diagnosis_DXSource = H003D2_A260BR_Diagnosis_DXSource[0];
               n260BR_Diagnosis_DXSource = H003D2_n260BR_Diagnosis_DXSource[0];
               A504BR_Diagnosis_MetastasesDX_Code = H003D2_A504BR_Diagnosis_MetastasesDX_Code[0];
               n504BR_Diagnosis_MetastasesDX_Code = H003D2_n504BR_Diagnosis_MetastasesDX_Code[0];
               A71BR_Diagnosis_MetastasesDX = H003D2_A71BR_Diagnosis_MetastasesDX[0];
               n71BR_Diagnosis_MetastasesDX = H003D2_n71BR_Diagnosis_MetastasesDX[0];
               A503BR_Diagnosis_InitialDX_Code = H003D2_A503BR_Diagnosis_InitialDX_Code[0];
               n503BR_Diagnosis_InitialDX_Code = H003D2_n503BR_Diagnosis_InitialDX_Code[0];
               A70BR_Diagnosis_InitialDX = H003D2_A70BR_Diagnosis_InitialDX[0];
               n70BR_Diagnosis_InitialDX = H003D2_n70BR_Diagnosis_InitialDX[0];
               A69BR_Diagnosis_DXDescription = H003D2_A69BR_Diagnosis_DXDescription[0];
               n69BR_Diagnosis_DXDescription = H003D2_n69BR_Diagnosis_DXDescription[0];
               A467BR_Diagnosis_DXTsource_Code = H003D2_A467BR_Diagnosis_DXTsource_Code[0];
               n467BR_Diagnosis_DXTsource_Code = H003D2_n467BR_Diagnosis_DXTsource_Code[0];
               A68BR_Diagnosis_DXTsource = H003D2_A68BR_Diagnosis_DXTsource[0];
               n68BR_Diagnosis_DXTsource = H003D2_n68BR_Diagnosis_DXTsource[0];
               A466BR_Diagnosis_DXType_Code = H003D2_A466BR_Diagnosis_DXType_Code[0];
               n466BR_Diagnosis_DXType_Code = H003D2_n466BR_Diagnosis_DXType_Code[0];
               A67BR_Diagnosis_DXType = H003D2_A67BR_Diagnosis_DXType[0];
               n67BR_Diagnosis_DXType = H003D2_n67BR_Diagnosis_DXType[0];
               A66BR_Diagnosis_DXCode = H003D2_A66BR_Diagnosis_DXCode[0];
               n66BR_Diagnosis_DXCode = H003D2_n66BR_Diagnosis_DXCode[0];
               A65BR_Diagnosis_DXID = H003D2_A65BR_Diagnosis_DXID[0];
               n65BR_Diagnosis_DXID = H003D2_n65BR_Diagnosis_DXID[0];
               A513BR_Diagnosis_No = H003D2_A513BR_Diagnosis_No[0];
               n513BR_Diagnosis_No = H003D2_n513BR_Diagnosis_No[0];
               A36BR_Information_PatientNo = H003D2_A36BR_Information_PatientNo[0];
               n36BR_Information_PatientNo = H003D2_n36BR_Information_PatientNo[0];
               A19BR_EncounterID = H003D2_A19BR_EncounterID[0];
               A64BR_DiagnosisID = H003D2_A64BR_DiagnosisID[0];
               A85BR_Information_ID = H003D2_A85BR_Information_ID[0];
               n85BR_Information_ID = H003D2_n85BR_Information_ID[0];
               A36BR_Information_PatientNo = H003D2_A36BR_Information_PatientNo[0];
               n36BR_Information_PatientNo = H003D2_n36BR_Information_PatientNo[0];
               E313D2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 12;
            WB3D0( ) ;
         }
         bGXsfl_12_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes3D2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_DIAGNOSISID"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, context.localUtil.Format( (decimal)(A64BR_DiagnosisID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
                                              AV10OrderedBy ,
                                              AV11OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         /* Using cursor H003D3 */
         pr_default.execute(1);
         GRID_nRecordCount = H003D3_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_DiagnosisIDTitleControlIdToReplace, AV15ddo_BR_EncounterIDTitleControlIdToReplace, AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace, AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace, AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace, AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace, AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace, AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace, AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace, AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace, AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace, AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace, AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace, AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace, AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_DiagnosisIDTitleControlIdToReplace, AV15ddo_BR_EncounterIDTitleControlIdToReplace, AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace, AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace, AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace, AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace, AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace, AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace, AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace, AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace, AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace, AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace, AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace, AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace, AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_DiagnosisIDTitleControlIdToReplace, AV15ddo_BR_EncounterIDTitleControlIdToReplace, AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace, AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace, AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace, AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace, AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace, AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace, AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace, AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace, AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace, AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace, AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace, AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace, AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_DiagnosisIDTitleControlIdToReplace, AV15ddo_BR_EncounterIDTitleControlIdToReplace, AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace, AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace, AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace, AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace, AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace, AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace, AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace, AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace, AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace, AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace, AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace, AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace, AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_DiagnosisIDTitleControlIdToReplace, AV15ddo_BR_EncounterIDTitleControlIdToReplace, AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace, AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace, AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace, AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace, AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace, AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace, AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace, AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace, AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace, AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace, AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace, AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace, AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP3D0( )
      {
         /* Before Start, stand alone formulas. */
         AV52Pgmname = "BR_DiagnosisPrompt";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E293D2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV32DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_DIAGNOSISIDTITLEFILTERDATA"), AV12BR_DiagnosisIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTERIDTITLEFILTERDATA"), AV14BR_EncounterIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_INFORMATION_PATIENTNOTITLEFILTERDATA"), AV16BR_Information_PatientNoTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_DIAGNOSIS_NOTITLEFILTERDATA"), AV40BR_Diagnosis_NoTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_DIAGNOSIS_DXIDTITLEFILTERDATA"), AV18BR_Diagnosis_DXIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_DIAGNOSIS_DXCODETITLEFILTERDATA"), AV20BR_Diagnosis_DXCodeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA"), AV22BR_Diagnosis_DXTypeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_DIAGNOSIS_DXTYPE_CODETITLEFILTERDATA"), AV42BR_Diagnosis_DXType_CodeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA"), AV24BR_Diagnosis_DXTsourceTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_DIAGNOSIS_DXTSOURCE_CODETITLEFILTERDATA"), AV44BR_Diagnosis_DXTsource_CodeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA"), AV26BR_Diagnosis_DXDescriptionTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_DIAGNOSIS_INITIALDXTITLEFILTERDATA"), AV28BR_Diagnosis_InitialDXTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_DIAGNOSIS_INITIALDX_CODETITLEFILTERDATA"), AV46BR_Diagnosis_InitialDX_CodeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_DIAGNOSIS_METASTASESDXTITLEFILTERDATA"), AV30BR_Diagnosis_MetastasesDXTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_DIAGNOSIS_METASTASESDX_CODETITLEFILTERDATA"), AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_DIAGNOSIS_DXSOURCETITLEFILTERDATA"), AV38BR_Diagnosis_DXSourceTitleFilterData);
            /* Read variables values. */
            AV13ddo_BR_DiagnosisIDTitleControlIdToReplace = cgiGet( edtavDdo_br_diagnosisidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13ddo_BR_DiagnosisIDTitleControlIdToReplace", AV13ddo_BR_DiagnosisIDTitleControlIdToReplace);
            AV15ddo_BR_EncounterIDTitleControlIdToReplace = cgiGet( edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ddo_BR_EncounterIDTitleControlIdToReplace", AV15ddo_BR_EncounterIDTitleControlIdToReplace);
            AV17ddo_BR_Information_PatientNoTitleControlIdToReplace = cgiGet( edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17ddo_BR_Information_PatientNoTitleControlIdToReplace", AV17ddo_BR_Information_PatientNoTitleControlIdToReplace);
            AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace = cgiGet( edtavDdo_br_diagnosis_notitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace", AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace);
            AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace = cgiGet( edtavDdo_br_diagnosis_dxidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace", AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace);
            AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace = cgiGet( edtavDdo_br_diagnosis_dxcodetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace", AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace);
            AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace = cgiGet( edtavDdo_br_diagnosis_dxtypetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace", AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace);
            AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace = cgiGet( edtavDdo_br_diagnosis_dxtype_codetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace", AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace);
            AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace = cgiGet( edtavDdo_br_diagnosis_dxtsourcetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace", AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace);
            AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace = cgiGet( edtavDdo_br_diagnosis_dxtsource_codetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace", AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace);
            AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace = cgiGet( edtavDdo_br_diagnosis_dxdescriptiontitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace", AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace);
            AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace = cgiGet( edtavDdo_br_diagnosis_initialdxtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace", AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace);
            AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace = cgiGet( edtavDdo_br_diagnosis_initialdx_codetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace", AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace);
            AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace = cgiGet( edtavDdo_br_diagnosis_metastasesdxtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace", AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace);
            AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace = cgiGet( edtavDdo_br_diagnosis_metastasesdx_codetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace", AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace);
            AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace = cgiGet( edtavDdo_br_diagnosis_dxsourcetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace", AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDEREDBY");
               GX_FocusControl = edtavOrderedby_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10OrderedBy = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            }
            else
            {
               AV10OrderedBy = (short)(context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            }
            AV11OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            /* Read saved values. */
            nRC_GXsfl_12 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_12"), ".", ","));
            AV34GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV36GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV35GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_diagnosisid_Caption = cgiGet( "DDO_BR_DIAGNOSISID_Caption");
            Ddo_br_diagnosisid_Tooltip = cgiGet( "DDO_BR_DIAGNOSISID_Tooltip");
            Ddo_br_diagnosisid_Cls = cgiGet( "DDO_BR_DIAGNOSISID_Cls");
            Ddo_br_diagnosisid_Dropdownoptionstype = cgiGet( "DDO_BR_DIAGNOSISID_Dropdownoptionstype");
            Ddo_br_diagnosisid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_DIAGNOSISID_Titlecontrolidtoreplace");
            Ddo_br_diagnosisid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSISID_Includesortasc"));
            Ddo_br_diagnosisid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSISID_Includesortdsc"));
            Ddo_br_diagnosisid_Sortedstatus = cgiGet( "DDO_BR_DIAGNOSISID_Sortedstatus");
            Ddo_br_diagnosisid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSISID_Includefilter"));
            Ddo_br_diagnosisid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSISID_Includedatalist"));
            Ddo_br_diagnosisid_Sortasc = cgiGet( "DDO_BR_DIAGNOSISID_Sortasc");
            Ddo_br_diagnosisid_Sortdsc = cgiGet( "DDO_BR_DIAGNOSISID_Sortdsc");
            Ddo_br_diagnosisid_Searchbuttontext = cgiGet( "DDO_BR_DIAGNOSISID_Searchbuttontext");
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
            Ddo_br_diagnosis_no_Caption = cgiGet( "DDO_BR_DIAGNOSIS_NO_Caption");
            Ddo_br_diagnosis_no_Tooltip = cgiGet( "DDO_BR_DIAGNOSIS_NO_Tooltip");
            Ddo_br_diagnosis_no_Cls = cgiGet( "DDO_BR_DIAGNOSIS_NO_Cls");
            Ddo_br_diagnosis_no_Dropdownoptionstype = cgiGet( "DDO_BR_DIAGNOSIS_NO_Dropdownoptionstype");
            Ddo_br_diagnosis_no_Titlecontrolidtoreplace = cgiGet( "DDO_BR_DIAGNOSIS_NO_Titlecontrolidtoreplace");
            Ddo_br_diagnosis_no_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_NO_Includesortasc"));
            Ddo_br_diagnosis_no_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_NO_Includesortdsc"));
            Ddo_br_diagnosis_no_Sortedstatus = cgiGet( "DDO_BR_DIAGNOSIS_NO_Sortedstatus");
            Ddo_br_diagnosis_no_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_NO_Includefilter"));
            Ddo_br_diagnosis_no_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_NO_Includedatalist"));
            Ddo_br_diagnosis_no_Sortasc = cgiGet( "DDO_BR_DIAGNOSIS_NO_Sortasc");
            Ddo_br_diagnosis_no_Sortdsc = cgiGet( "DDO_BR_DIAGNOSIS_NO_Sortdsc");
            Ddo_br_diagnosis_no_Searchbuttontext = cgiGet( "DDO_BR_DIAGNOSIS_NO_Searchbuttontext");
            Ddo_br_diagnosis_dxid_Caption = cgiGet( "DDO_BR_DIAGNOSIS_DXID_Caption");
            Ddo_br_diagnosis_dxid_Tooltip = cgiGet( "DDO_BR_DIAGNOSIS_DXID_Tooltip");
            Ddo_br_diagnosis_dxid_Cls = cgiGet( "DDO_BR_DIAGNOSIS_DXID_Cls");
            Ddo_br_diagnosis_dxid_Dropdownoptionstype = cgiGet( "DDO_BR_DIAGNOSIS_DXID_Dropdownoptionstype");
            Ddo_br_diagnosis_dxid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_DIAGNOSIS_DXID_Titlecontrolidtoreplace");
            Ddo_br_diagnosis_dxid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXID_Includesortasc"));
            Ddo_br_diagnosis_dxid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXID_Includesortdsc"));
            Ddo_br_diagnosis_dxid_Sortedstatus = cgiGet( "DDO_BR_DIAGNOSIS_DXID_Sortedstatus");
            Ddo_br_diagnosis_dxid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXID_Includefilter"));
            Ddo_br_diagnosis_dxid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXID_Includedatalist"));
            Ddo_br_diagnosis_dxid_Sortasc = cgiGet( "DDO_BR_DIAGNOSIS_DXID_Sortasc");
            Ddo_br_diagnosis_dxid_Sortdsc = cgiGet( "DDO_BR_DIAGNOSIS_DXID_Sortdsc");
            Ddo_br_diagnosis_dxid_Searchbuttontext = cgiGet( "DDO_BR_DIAGNOSIS_DXID_Searchbuttontext");
            Ddo_br_diagnosis_dxcode_Caption = cgiGet( "DDO_BR_DIAGNOSIS_DXCODE_Caption");
            Ddo_br_diagnosis_dxcode_Tooltip = cgiGet( "DDO_BR_DIAGNOSIS_DXCODE_Tooltip");
            Ddo_br_diagnosis_dxcode_Cls = cgiGet( "DDO_BR_DIAGNOSIS_DXCODE_Cls");
            Ddo_br_diagnosis_dxcode_Dropdownoptionstype = cgiGet( "DDO_BR_DIAGNOSIS_DXCODE_Dropdownoptionstype");
            Ddo_br_diagnosis_dxcode_Titlecontrolidtoreplace = cgiGet( "DDO_BR_DIAGNOSIS_DXCODE_Titlecontrolidtoreplace");
            Ddo_br_diagnosis_dxcode_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXCODE_Includesortasc"));
            Ddo_br_diagnosis_dxcode_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXCODE_Includesortdsc"));
            Ddo_br_diagnosis_dxcode_Sortedstatus = cgiGet( "DDO_BR_DIAGNOSIS_DXCODE_Sortedstatus");
            Ddo_br_diagnosis_dxcode_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXCODE_Includefilter"));
            Ddo_br_diagnosis_dxcode_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXCODE_Includedatalist"));
            Ddo_br_diagnosis_dxcode_Sortasc = cgiGet( "DDO_BR_DIAGNOSIS_DXCODE_Sortasc");
            Ddo_br_diagnosis_dxcode_Sortdsc = cgiGet( "DDO_BR_DIAGNOSIS_DXCODE_Sortdsc");
            Ddo_br_diagnosis_dxcode_Searchbuttontext = cgiGet( "DDO_BR_DIAGNOSIS_DXCODE_Searchbuttontext");
            Ddo_br_diagnosis_dxtype_Caption = cgiGet( "DDO_BR_DIAGNOSIS_DXTYPE_Caption");
            Ddo_br_diagnosis_dxtype_Tooltip = cgiGet( "DDO_BR_DIAGNOSIS_DXTYPE_Tooltip");
            Ddo_br_diagnosis_dxtype_Cls = cgiGet( "DDO_BR_DIAGNOSIS_DXTYPE_Cls");
            Ddo_br_diagnosis_dxtype_Dropdownoptionstype = cgiGet( "DDO_BR_DIAGNOSIS_DXTYPE_Dropdownoptionstype");
            Ddo_br_diagnosis_dxtype_Titlecontrolidtoreplace = cgiGet( "DDO_BR_DIAGNOSIS_DXTYPE_Titlecontrolidtoreplace");
            Ddo_br_diagnosis_dxtype_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXTYPE_Includesortasc"));
            Ddo_br_diagnosis_dxtype_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXTYPE_Includesortdsc"));
            Ddo_br_diagnosis_dxtype_Sortedstatus = cgiGet( "DDO_BR_DIAGNOSIS_DXTYPE_Sortedstatus");
            Ddo_br_diagnosis_dxtype_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXTYPE_Includefilter"));
            Ddo_br_diagnosis_dxtype_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXTYPE_Includedatalist"));
            Ddo_br_diagnosis_dxtype_Sortasc = cgiGet( "DDO_BR_DIAGNOSIS_DXTYPE_Sortasc");
            Ddo_br_diagnosis_dxtype_Sortdsc = cgiGet( "DDO_BR_DIAGNOSIS_DXTYPE_Sortdsc");
            Ddo_br_diagnosis_dxtype_Searchbuttontext = cgiGet( "DDO_BR_DIAGNOSIS_DXTYPE_Searchbuttontext");
            Ddo_br_diagnosis_dxtype_code_Caption = cgiGet( "DDO_BR_DIAGNOSIS_DXTYPE_CODE_Caption");
            Ddo_br_diagnosis_dxtype_code_Tooltip = cgiGet( "DDO_BR_DIAGNOSIS_DXTYPE_CODE_Tooltip");
            Ddo_br_diagnosis_dxtype_code_Cls = cgiGet( "DDO_BR_DIAGNOSIS_DXTYPE_CODE_Cls");
            Ddo_br_diagnosis_dxtype_code_Dropdownoptionstype = cgiGet( "DDO_BR_DIAGNOSIS_DXTYPE_CODE_Dropdownoptionstype");
            Ddo_br_diagnosis_dxtype_code_Titlecontrolidtoreplace = cgiGet( "DDO_BR_DIAGNOSIS_DXTYPE_CODE_Titlecontrolidtoreplace");
            Ddo_br_diagnosis_dxtype_code_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXTYPE_CODE_Includesortasc"));
            Ddo_br_diagnosis_dxtype_code_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXTYPE_CODE_Includesortdsc"));
            Ddo_br_diagnosis_dxtype_code_Sortedstatus = cgiGet( "DDO_BR_DIAGNOSIS_DXTYPE_CODE_Sortedstatus");
            Ddo_br_diagnosis_dxtype_code_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXTYPE_CODE_Includefilter"));
            Ddo_br_diagnosis_dxtype_code_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXTYPE_CODE_Includedatalist"));
            Ddo_br_diagnosis_dxtype_code_Sortasc = cgiGet( "DDO_BR_DIAGNOSIS_DXTYPE_CODE_Sortasc");
            Ddo_br_diagnosis_dxtype_code_Sortdsc = cgiGet( "DDO_BR_DIAGNOSIS_DXTYPE_CODE_Sortdsc");
            Ddo_br_diagnosis_dxtype_code_Searchbuttontext = cgiGet( "DDO_BR_DIAGNOSIS_DXTYPE_CODE_Searchbuttontext");
            Ddo_br_diagnosis_dxtsource_Caption = cgiGet( "DDO_BR_DIAGNOSIS_DXTSOURCE_Caption");
            Ddo_br_diagnosis_dxtsource_Tooltip = cgiGet( "DDO_BR_DIAGNOSIS_DXTSOURCE_Tooltip");
            Ddo_br_diagnosis_dxtsource_Cls = cgiGet( "DDO_BR_DIAGNOSIS_DXTSOURCE_Cls");
            Ddo_br_diagnosis_dxtsource_Dropdownoptionstype = cgiGet( "DDO_BR_DIAGNOSIS_DXTSOURCE_Dropdownoptionstype");
            Ddo_br_diagnosis_dxtsource_Titlecontrolidtoreplace = cgiGet( "DDO_BR_DIAGNOSIS_DXTSOURCE_Titlecontrolidtoreplace");
            Ddo_br_diagnosis_dxtsource_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXTSOURCE_Includesortasc"));
            Ddo_br_diagnosis_dxtsource_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXTSOURCE_Includesortdsc"));
            Ddo_br_diagnosis_dxtsource_Sortedstatus = cgiGet( "DDO_BR_DIAGNOSIS_DXTSOURCE_Sortedstatus");
            Ddo_br_diagnosis_dxtsource_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXTSOURCE_Includefilter"));
            Ddo_br_diagnosis_dxtsource_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXTSOURCE_Includedatalist"));
            Ddo_br_diagnosis_dxtsource_Sortasc = cgiGet( "DDO_BR_DIAGNOSIS_DXTSOURCE_Sortasc");
            Ddo_br_diagnosis_dxtsource_Sortdsc = cgiGet( "DDO_BR_DIAGNOSIS_DXTSOURCE_Sortdsc");
            Ddo_br_diagnosis_dxtsource_Searchbuttontext = cgiGet( "DDO_BR_DIAGNOSIS_DXTSOURCE_Searchbuttontext");
            Ddo_br_diagnosis_dxtsource_code_Caption = cgiGet( "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE_Caption");
            Ddo_br_diagnosis_dxtsource_code_Tooltip = cgiGet( "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE_Tooltip");
            Ddo_br_diagnosis_dxtsource_code_Cls = cgiGet( "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE_Cls");
            Ddo_br_diagnosis_dxtsource_code_Dropdownoptionstype = cgiGet( "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE_Dropdownoptionstype");
            Ddo_br_diagnosis_dxtsource_code_Titlecontrolidtoreplace = cgiGet( "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE_Titlecontrolidtoreplace");
            Ddo_br_diagnosis_dxtsource_code_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE_Includesortasc"));
            Ddo_br_diagnosis_dxtsource_code_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE_Includesortdsc"));
            Ddo_br_diagnosis_dxtsource_code_Sortedstatus = cgiGet( "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE_Sortedstatus");
            Ddo_br_diagnosis_dxtsource_code_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE_Includefilter"));
            Ddo_br_diagnosis_dxtsource_code_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE_Includedatalist"));
            Ddo_br_diagnosis_dxtsource_code_Sortasc = cgiGet( "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE_Sortasc");
            Ddo_br_diagnosis_dxtsource_code_Sortdsc = cgiGet( "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE_Sortdsc");
            Ddo_br_diagnosis_dxtsource_code_Searchbuttontext = cgiGet( "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE_Searchbuttontext");
            Ddo_br_diagnosis_dxdescription_Caption = cgiGet( "DDO_BR_DIAGNOSIS_DXDESCRIPTION_Caption");
            Ddo_br_diagnosis_dxdescription_Tooltip = cgiGet( "DDO_BR_DIAGNOSIS_DXDESCRIPTION_Tooltip");
            Ddo_br_diagnosis_dxdescription_Cls = cgiGet( "DDO_BR_DIAGNOSIS_DXDESCRIPTION_Cls");
            Ddo_br_diagnosis_dxdescription_Dropdownoptionstype = cgiGet( "DDO_BR_DIAGNOSIS_DXDESCRIPTION_Dropdownoptionstype");
            Ddo_br_diagnosis_dxdescription_Titlecontrolidtoreplace = cgiGet( "DDO_BR_DIAGNOSIS_DXDESCRIPTION_Titlecontrolidtoreplace");
            Ddo_br_diagnosis_dxdescription_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXDESCRIPTION_Includesortasc"));
            Ddo_br_diagnosis_dxdescription_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXDESCRIPTION_Includesortdsc"));
            Ddo_br_diagnosis_dxdescription_Sortedstatus = cgiGet( "DDO_BR_DIAGNOSIS_DXDESCRIPTION_Sortedstatus");
            Ddo_br_diagnosis_dxdescription_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXDESCRIPTION_Includefilter"));
            Ddo_br_diagnosis_dxdescription_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXDESCRIPTION_Includedatalist"));
            Ddo_br_diagnosis_dxdescription_Sortasc = cgiGet( "DDO_BR_DIAGNOSIS_DXDESCRIPTION_Sortasc");
            Ddo_br_diagnosis_dxdescription_Sortdsc = cgiGet( "DDO_BR_DIAGNOSIS_DXDESCRIPTION_Sortdsc");
            Ddo_br_diagnosis_dxdescription_Searchbuttontext = cgiGet( "DDO_BR_DIAGNOSIS_DXDESCRIPTION_Searchbuttontext");
            Ddo_br_diagnosis_initialdx_Caption = cgiGet( "DDO_BR_DIAGNOSIS_INITIALDX_Caption");
            Ddo_br_diagnosis_initialdx_Tooltip = cgiGet( "DDO_BR_DIAGNOSIS_INITIALDX_Tooltip");
            Ddo_br_diagnosis_initialdx_Cls = cgiGet( "DDO_BR_DIAGNOSIS_INITIALDX_Cls");
            Ddo_br_diagnosis_initialdx_Dropdownoptionstype = cgiGet( "DDO_BR_DIAGNOSIS_INITIALDX_Dropdownoptionstype");
            Ddo_br_diagnosis_initialdx_Titlecontrolidtoreplace = cgiGet( "DDO_BR_DIAGNOSIS_INITIALDX_Titlecontrolidtoreplace");
            Ddo_br_diagnosis_initialdx_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_INITIALDX_Includesortasc"));
            Ddo_br_diagnosis_initialdx_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_INITIALDX_Includesortdsc"));
            Ddo_br_diagnosis_initialdx_Sortedstatus = cgiGet( "DDO_BR_DIAGNOSIS_INITIALDX_Sortedstatus");
            Ddo_br_diagnosis_initialdx_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_INITIALDX_Includefilter"));
            Ddo_br_diagnosis_initialdx_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_INITIALDX_Includedatalist"));
            Ddo_br_diagnosis_initialdx_Sortasc = cgiGet( "DDO_BR_DIAGNOSIS_INITIALDX_Sortasc");
            Ddo_br_diagnosis_initialdx_Sortdsc = cgiGet( "DDO_BR_DIAGNOSIS_INITIALDX_Sortdsc");
            Ddo_br_diagnosis_initialdx_Searchbuttontext = cgiGet( "DDO_BR_DIAGNOSIS_INITIALDX_Searchbuttontext");
            Ddo_br_diagnosis_initialdx_code_Caption = cgiGet( "DDO_BR_DIAGNOSIS_INITIALDX_CODE_Caption");
            Ddo_br_diagnosis_initialdx_code_Tooltip = cgiGet( "DDO_BR_DIAGNOSIS_INITIALDX_CODE_Tooltip");
            Ddo_br_diagnosis_initialdx_code_Cls = cgiGet( "DDO_BR_DIAGNOSIS_INITIALDX_CODE_Cls");
            Ddo_br_diagnosis_initialdx_code_Dropdownoptionstype = cgiGet( "DDO_BR_DIAGNOSIS_INITIALDX_CODE_Dropdownoptionstype");
            Ddo_br_diagnosis_initialdx_code_Titlecontrolidtoreplace = cgiGet( "DDO_BR_DIAGNOSIS_INITIALDX_CODE_Titlecontrolidtoreplace");
            Ddo_br_diagnosis_initialdx_code_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_INITIALDX_CODE_Includesortasc"));
            Ddo_br_diagnosis_initialdx_code_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_INITIALDX_CODE_Includesortdsc"));
            Ddo_br_diagnosis_initialdx_code_Sortedstatus = cgiGet( "DDO_BR_DIAGNOSIS_INITIALDX_CODE_Sortedstatus");
            Ddo_br_diagnosis_initialdx_code_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_INITIALDX_CODE_Includefilter"));
            Ddo_br_diagnosis_initialdx_code_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_INITIALDX_CODE_Includedatalist"));
            Ddo_br_diagnosis_initialdx_code_Sortasc = cgiGet( "DDO_BR_DIAGNOSIS_INITIALDX_CODE_Sortasc");
            Ddo_br_diagnosis_initialdx_code_Sortdsc = cgiGet( "DDO_BR_DIAGNOSIS_INITIALDX_CODE_Sortdsc");
            Ddo_br_diagnosis_initialdx_code_Searchbuttontext = cgiGet( "DDO_BR_DIAGNOSIS_INITIALDX_CODE_Searchbuttontext");
            Ddo_br_diagnosis_metastasesdx_Caption = cgiGet( "DDO_BR_DIAGNOSIS_METASTASESDX_Caption");
            Ddo_br_diagnosis_metastasesdx_Tooltip = cgiGet( "DDO_BR_DIAGNOSIS_METASTASESDX_Tooltip");
            Ddo_br_diagnosis_metastasesdx_Cls = cgiGet( "DDO_BR_DIAGNOSIS_METASTASESDX_Cls");
            Ddo_br_diagnosis_metastasesdx_Dropdownoptionstype = cgiGet( "DDO_BR_DIAGNOSIS_METASTASESDX_Dropdownoptionstype");
            Ddo_br_diagnosis_metastasesdx_Titlecontrolidtoreplace = cgiGet( "DDO_BR_DIAGNOSIS_METASTASESDX_Titlecontrolidtoreplace");
            Ddo_br_diagnosis_metastasesdx_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_METASTASESDX_Includesortasc"));
            Ddo_br_diagnosis_metastasesdx_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_METASTASESDX_Includesortdsc"));
            Ddo_br_diagnosis_metastasesdx_Sortedstatus = cgiGet( "DDO_BR_DIAGNOSIS_METASTASESDX_Sortedstatus");
            Ddo_br_diagnosis_metastasesdx_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_METASTASESDX_Includefilter"));
            Ddo_br_diagnosis_metastasesdx_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_METASTASESDX_Includedatalist"));
            Ddo_br_diagnosis_metastasesdx_Sortasc = cgiGet( "DDO_BR_DIAGNOSIS_METASTASESDX_Sortasc");
            Ddo_br_diagnosis_metastasesdx_Sortdsc = cgiGet( "DDO_BR_DIAGNOSIS_METASTASESDX_Sortdsc");
            Ddo_br_diagnosis_metastasesdx_Searchbuttontext = cgiGet( "DDO_BR_DIAGNOSIS_METASTASESDX_Searchbuttontext");
            Ddo_br_diagnosis_metastasesdx_code_Caption = cgiGet( "DDO_BR_DIAGNOSIS_METASTASESDX_CODE_Caption");
            Ddo_br_diagnosis_metastasesdx_code_Tooltip = cgiGet( "DDO_BR_DIAGNOSIS_METASTASESDX_CODE_Tooltip");
            Ddo_br_diagnosis_metastasesdx_code_Cls = cgiGet( "DDO_BR_DIAGNOSIS_METASTASESDX_CODE_Cls");
            Ddo_br_diagnosis_metastasesdx_code_Dropdownoptionstype = cgiGet( "DDO_BR_DIAGNOSIS_METASTASESDX_CODE_Dropdownoptionstype");
            Ddo_br_diagnosis_metastasesdx_code_Titlecontrolidtoreplace = cgiGet( "DDO_BR_DIAGNOSIS_METASTASESDX_CODE_Titlecontrolidtoreplace");
            Ddo_br_diagnosis_metastasesdx_code_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_METASTASESDX_CODE_Includesortasc"));
            Ddo_br_diagnosis_metastasesdx_code_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_METASTASESDX_CODE_Includesortdsc"));
            Ddo_br_diagnosis_metastasesdx_code_Sortedstatus = cgiGet( "DDO_BR_DIAGNOSIS_METASTASESDX_CODE_Sortedstatus");
            Ddo_br_diagnosis_metastasesdx_code_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_METASTASESDX_CODE_Includefilter"));
            Ddo_br_diagnosis_metastasesdx_code_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_METASTASESDX_CODE_Includedatalist"));
            Ddo_br_diagnosis_metastasesdx_code_Sortasc = cgiGet( "DDO_BR_DIAGNOSIS_METASTASESDX_CODE_Sortasc");
            Ddo_br_diagnosis_metastasesdx_code_Sortdsc = cgiGet( "DDO_BR_DIAGNOSIS_METASTASESDX_CODE_Sortdsc");
            Ddo_br_diagnosis_metastasesdx_code_Searchbuttontext = cgiGet( "DDO_BR_DIAGNOSIS_METASTASESDX_CODE_Searchbuttontext");
            Ddo_br_diagnosis_dxsource_Caption = cgiGet( "DDO_BR_DIAGNOSIS_DXSOURCE_Caption");
            Ddo_br_diagnosis_dxsource_Tooltip = cgiGet( "DDO_BR_DIAGNOSIS_DXSOURCE_Tooltip");
            Ddo_br_diagnosis_dxsource_Cls = cgiGet( "DDO_BR_DIAGNOSIS_DXSOURCE_Cls");
            Ddo_br_diagnosis_dxsource_Dropdownoptionstype = cgiGet( "DDO_BR_DIAGNOSIS_DXSOURCE_Dropdownoptionstype");
            Ddo_br_diagnosis_dxsource_Titlecontrolidtoreplace = cgiGet( "DDO_BR_DIAGNOSIS_DXSOURCE_Titlecontrolidtoreplace");
            Ddo_br_diagnosis_dxsource_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXSOURCE_Includesortasc"));
            Ddo_br_diagnosis_dxsource_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXSOURCE_Includesortdsc"));
            Ddo_br_diagnosis_dxsource_Sortedstatus = cgiGet( "DDO_BR_DIAGNOSIS_DXSOURCE_Sortedstatus");
            Ddo_br_diagnosis_dxsource_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXSOURCE_Includefilter"));
            Ddo_br_diagnosis_dxsource_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_DIAGNOSIS_DXSOURCE_Includedatalist"));
            Ddo_br_diagnosis_dxsource_Sortasc = cgiGet( "DDO_BR_DIAGNOSIS_DXSOURCE_Sortasc");
            Ddo_br_diagnosis_dxsource_Sortdsc = cgiGet( "DDO_BR_DIAGNOSIS_DXSOURCE_Sortdsc");
            Ddo_br_diagnosis_dxsource_Searchbuttontext = cgiGet( "DDO_BR_DIAGNOSIS_DXSOURCE_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_diagnosisid_Activeeventkey = cgiGet( "DDO_BR_DIAGNOSISID_Activeeventkey");
            Ddo_br_encounterid_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTERID_Activeeventkey");
            Ddo_br_information_patientno_Activeeventkey = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey");
            Ddo_br_diagnosis_no_Activeeventkey = cgiGet( "DDO_BR_DIAGNOSIS_NO_Activeeventkey");
            Ddo_br_diagnosis_dxid_Activeeventkey = cgiGet( "DDO_BR_DIAGNOSIS_DXID_Activeeventkey");
            Ddo_br_diagnosis_dxcode_Activeeventkey = cgiGet( "DDO_BR_DIAGNOSIS_DXCODE_Activeeventkey");
            Ddo_br_diagnosis_dxtype_Activeeventkey = cgiGet( "DDO_BR_DIAGNOSIS_DXTYPE_Activeeventkey");
            Ddo_br_diagnosis_dxtype_code_Activeeventkey = cgiGet( "DDO_BR_DIAGNOSIS_DXTYPE_CODE_Activeeventkey");
            Ddo_br_diagnosis_dxtsource_Activeeventkey = cgiGet( "DDO_BR_DIAGNOSIS_DXTSOURCE_Activeeventkey");
            Ddo_br_diagnosis_dxtsource_code_Activeeventkey = cgiGet( "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE_Activeeventkey");
            Ddo_br_diagnosis_dxdescription_Activeeventkey = cgiGet( "DDO_BR_DIAGNOSIS_DXDESCRIPTION_Activeeventkey");
            Ddo_br_diagnosis_initialdx_Activeeventkey = cgiGet( "DDO_BR_DIAGNOSIS_INITIALDX_Activeeventkey");
            Ddo_br_diagnosis_initialdx_code_Activeeventkey = cgiGet( "DDO_BR_DIAGNOSIS_INITIALDX_CODE_Activeeventkey");
            Ddo_br_diagnosis_metastasesdx_Activeeventkey = cgiGet( "DDO_BR_DIAGNOSIS_METASTASESDX_Activeeventkey");
            Ddo_br_diagnosis_metastasesdx_code_Activeeventkey = cgiGet( "DDO_BR_DIAGNOSIS_METASTASESDX_CODE_Activeeventkey");
            Ddo_br_diagnosis_dxsource_Activeeventkey = cgiGet( "DDO_BR_DIAGNOSIS_DXSOURCE_Activeeventkey");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV10OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV11OrderedDsc )
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
         E293D2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E293D2( )
      {
         /* Start Routine */
         GXt_boolean1 = AV5IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Diagnosis", out  GXt_boolean1) ;
         AV5IsAuthorized = GXt_boolean1;
         if ( ! AV5IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV52Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         divTablemain_Height = 493;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTablemain_Internalname, "Height", StringUtil.LTrim( StringUtil.Str( (decimal)(divTablemain_Height), 9, 0)), true);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_br_diagnosisid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_DiagnosisID";
         ucDdo_br_diagnosisid.SendProperty(context, "", false, Ddo_br_diagnosisid_Internalname, "TitleControlIdToReplace", Ddo_br_diagnosisid_Titlecontrolidtoreplace);
         AV13ddo_BR_DiagnosisIDTitleControlIdToReplace = Ddo_br_diagnosisid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13ddo_BR_DiagnosisIDTitleControlIdToReplace", AV13ddo_BR_DiagnosisIDTitleControlIdToReplace);
         edtavDdo_br_diagnosisidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_diagnosisidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_diagnosisidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounterid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_EncounterID";
         ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "TitleControlIdToReplace", Ddo_br_encounterid_Titlecontrolidtoreplace);
         AV15ddo_BR_EncounterIDTitleControlIdToReplace = Ddo_br_encounterid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ddo_BR_EncounterIDTitleControlIdToReplace", AV15ddo_BR_EncounterIDTitleControlIdToReplace);
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_information_patientno_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Information_PatientNo";
         ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "TitleControlIdToReplace", Ddo_br_information_patientno_Titlecontrolidtoreplace);
         AV17ddo_BR_Information_PatientNoTitleControlIdToReplace = Ddo_br_information_patientno_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17ddo_BR_Information_PatientNoTitleControlIdToReplace", AV17ddo_BR_Information_PatientNoTitleControlIdToReplace);
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_diagnosis_no_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Diagnosis_No";
         ucDdo_br_diagnosis_no.SendProperty(context, "", false, Ddo_br_diagnosis_no_Internalname, "TitleControlIdToReplace", Ddo_br_diagnosis_no_Titlecontrolidtoreplace);
         AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace = Ddo_br_diagnosis_no_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace", AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace);
         edtavDdo_br_diagnosis_notitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_diagnosis_notitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_diagnosis_notitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_diagnosis_dxid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Diagnosis_DXID";
         ucDdo_br_diagnosis_dxid.SendProperty(context, "", false, Ddo_br_diagnosis_dxid_Internalname, "TitleControlIdToReplace", Ddo_br_diagnosis_dxid_Titlecontrolidtoreplace);
         AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace = Ddo_br_diagnosis_dxid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace", AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace);
         edtavDdo_br_diagnosis_dxidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_diagnosis_dxidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_diagnosis_dxidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_diagnosis_dxcode_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Diagnosis_DXCode";
         ucDdo_br_diagnosis_dxcode.SendProperty(context, "", false, Ddo_br_diagnosis_dxcode_Internalname, "TitleControlIdToReplace", Ddo_br_diagnosis_dxcode_Titlecontrolidtoreplace);
         AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace = Ddo_br_diagnosis_dxcode_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace", AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace);
         edtavDdo_br_diagnosis_dxcodetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_diagnosis_dxcodetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_diagnosis_dxcodetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_diagnosis_dxtype_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Diagnosis_DXType";
         ucDdo_br_diagnosis_dxtype.SendProperty(context, "", false, Ddo_br_diagnosis_dxtype_Internalname, "TitleControlIdToReplace", Ddo_br_diagnosis_dxtype_Titlecontrolidtoreplace);
         AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace = Ddo_br_diagnosis_dxtype_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace", AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace);
         edtavDdo_br_diagnosis_dxtypetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_diagnosis_dxtypetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_diagnosis_dxtypetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_diagnosis_dxtype_code_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Diagnosis_DXType_Code";
         ucDdo_br_diagnosis_dxtype_code.SendProperty(context, "", false, Ddo_br_diagnosis_dxtype_code_Internalname, "TitleControlIdToReplace", Ddo_br_diagnosis_dxtype_code_Titlecontrolidtoreplace);
         AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace = Ddo_br_diagnosis_dxtype_code_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace", AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace);
         edtavDdo_br_diagnosis_dxtype_codetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_diagnosis_dxtype_codetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_diagnosis_dxtype_codetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_diagnosis_dxtsource_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Diagnosis_DXTsource";
         ucDdo_br_diagnosis_dxtsource.SendProperty(context, "", false, Ddo_br_diagnosis_dxtsource_Internalname, "TitleControlIdToReplace", Ddo_br_diagnosis_dxtsource_Titlecontrolidtoreplace);
         AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace = Ddo_br_diagnosis_dxtsource_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace", AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace);
         edtavDdo_br_diagnosis_dxtsourcetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_diagnosis_dxtsourcetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_diagnosis_dxtsourcetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_diagnosis_dxtsource_code_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Diagnosis_DXTsource_Code";
         ucDdo_br_diagnosis_dxtsource_code.SendProperty(context, "", false, Ddo_br_diagnosis_dxtsource_code_Internalname, "TitleControlIdToReplace", Ddo_br_diagnosis_dxtsource_code_Titlecontrolidtoreplace);
         AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace = Ddo_br_diagnosis_dxtsource_code_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace", AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace);
         edtavDdo_br_diagnosis_dxtsource_codetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_diagnosis_dxtsource_codetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_diagnosis_dxtsource_codetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_diagnosis_dxdescription_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Diagnosis_DXDescription";
         ucDdo_br_diagnosis_dxdescription.SendProperty(context, "", false, Ddo_br_diagnosis_dxdescription_Internalname, "TitleControlIdToReplace", Ddo_br_diagnosis_dxdescription_Titlecontrolidtoreplace);
         AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace = Ddo_br_diagnosis_dxdescription_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace", AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace);
         edtavDdo_br_diagnosis_dxdescriptiontitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_diagnosis_dxdescriptiontitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_diagnosis_dxdescriptiontitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_diagnosis_initialdx_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Diagnosis_InitialDX";
         ucDdo_br_diagnosis_initialdx.SendProperty(context, "", false, Ddo_br_diagnosis_initialdx_Internalname, "TitleControlIdToReplace", Ddo_br_diagnosis_initialdx_Titlecontrolidtoreplace);
         AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace = Ddo_br_diagnosis_initialdx_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace", AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace);
         edtavDdo_br_diagnosis_initialdxtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_diagnosis_initialdxtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_diagnosis_initialdxtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_diagnosis_initialdx_code_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Diagnosis_InitialDX_Code";
         ucDdo_br_diagnosis_initialdx_code.SendProperty(context, "", false, Ddo_br_diagnosis_initialdx_code_Internalname, "TitleControlIdToReplace", Ddo_br_diagnosis_initialdx_code_Titlecontrolidtoreplace);
         AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace = Ddo_br_diagnosis_initialdx_code_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace", AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace);
         edtavDdo_br_diagnosis_initialdx_codetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_diagnosis_initialdx_codetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_diagnosis_initialdx_codetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_diagnosis_metastasesdx_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Diagnosis_MetastasesDX";
         ucDdo_br_diagnosis_metastasesdx.SendProperty(context, "", false, Ddo_br_diagnosis_metastasesdx_Internalname, "TitleControlIdToReplace", Ddo_br_diagnosis_metastasesdx_Titlecontrolidtoreplace);
         AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace = Ddo_br_diagnosis_metastasesdx_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace", AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace);
         edtavDdo_br_diagnosis_metastasesdxtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_diagnosis_metastasesdxtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_diagnosis_metastasesdxtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_diagnosis_metastasesdx_code_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Diagnosis_MetastasesDX_Code";
         ucDdo_br_diagnosis_metastasesdx_code.SendProperty(context, "", false, Ddo_br_diagnosis_metastasesdx_code_Internalname, "TitleControlIdToReplace", Ddo_br_diagnosis_metastasesdx_code_Titlecontrolidtoreplace);
         AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace = Ddo_br_diagnosis_metastasesdx_code_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace", AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace);
         edtavDdo_br_diagnosis_metastasesdx_codetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_diagnosis_metastasesdx_codetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_diagnosis_metastasesdx_codetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_diagnosis_dxsource_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Diagnosis_DXSource";
         ucDdo_br_diagnosis_dxsource.SendProperty(context, "", false, Ddo_br_diagnosis_dxsource_Internalname, "TitleControlIdToReplace", Ddo_br_diagnosis_dxsource_Titlecontrolidtoreplace);
         AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace = Ddo_br_diagnosis_dxsource_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace", AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace);
         edtavDdo_br_diagnosis_dxsourcetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_diagnosis_dxsourcetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_diagnosis_dxsourcetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "选择Data Mgmt Portal - RAAP";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         edtavOrderedby_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrderedby_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrderedby_Visible), 5, 0)), true);
         if ( AV10OrderedBy < 1 )
         {
            AV10OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
         }
         edtavOrdereddsc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrdereddsc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrdereddsc_Visible), 5, 0)), true);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV32DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV32DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E303D2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV12BR_DiagnosisIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV14BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV16BR_Information_PatientNoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV40BR_Diagnosis_NoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV18BR_Diagnosis_DXIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_Diagnosis_DXCodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV22BR_Diagnosis_DXTypeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV42BR_Diagnosis_DXType_CodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_Diagnosis_DXTsourceTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV44BR_Diagnosis_DXTsource_CodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV26BR_Diagnosis_DXDescriptionTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28BR_Diagnosis_InitialDXTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV46BR_Diagnosis_InitialDX_CodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV30BR_Diagnosis_MetastasesDXTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV38BR_Diagnosis_DXSourceTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         edtBR_DiagnosisID_Titleformat = 2;
         edtBR_DiagnosisID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "诊断主键", AV13ddo_BR_DiagnosisIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_DiagnosisID_Internalname, "Title", edtBR_DiagnosisID_Title, !bGXsfl_12_Refreshing);
         edtBR_EncounterID_Titleformat = 2;
         edtBR_EncounterID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊信息主键", AV15ddo_BR_EncounterIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Title", edtBR_EncounterID_Title, !bGXsfl_12_Refreshing);
         edtBR_Information_PatientNo_Titleformat = 2;
         edtBR_Information_PatientNo_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "患者编号", AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_PatientNo_Internalname, "Title", edtBR_Information_PatientNo_Title, !bGXsfl_12_Refreshing);
         edtBR_Diagnosis_No_Titleformat = 2;
         edtBR_Diagnosis_No_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "诊断次序", AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Diagnosis_No_Internalname, "Title", edtBR_Diagnosis_No_Title, !bGXsfl_12_Refreshing);
         edtBR_Diagnosis_DXID_Titleformat = 2;
         edtBR_Diagnosis_DXID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "疾病序号", AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Diagnosis_DXID_Internalname, "Title", edtBR_Diagnosis_DXID_Title, !bGXsfl_12_Refreshing);
         edtBR_Diagnosis_DXCode_Titleformat = 2;
         edtBR_Diagnosis_DXCode_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "疾病代码", AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Diagnosis_DXCode_Internalname, "Title", edtBR_Diagnosis_DXCode_Title, !bGXsfl_12_Refreshing);
         edtBR_Diagnosis_DXType_Titleformat = 2;
         edtBR_Diagnosis_DXType_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "疾病类型", AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Diagnosis_DXType_Internalname, "Title", edtBR_Diagnosis_DXType_Title, !bGXsfl_12_Refreshing);
         edtBR_Diagnosis_DXType_Code_Titleformat = 2;
         edtBR_Diagnosis_DXType_Code_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "疾病类型code", AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Diagnosis_DXType_Code_Internalname, "Title", edtBR_Diagnosis_DXType_Code_Title, !bGXsfl_12_Refreshing);
         edtBR_Diagnosis_DXTsource_Titleformat = 2;
         edtBR_Diagnosis_DXTsource_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "诊断来源", AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Diagnosis_DXTsource_Internalname, "Title", edtBR_Diagnosis_DXTsource_Title, !bGXsfl_12_Refreshing);
         edtBR_Diagnosis_DXTsource_Code_Titleformat = 2;
         edtBR_Diagnosis_DXTsource_Code_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "诊断来源code", AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Diagnosis_DXTsource_Code_Internalname, "Title", edtBR_Diagnosis_DXTsource_Code_Title, !bGXsfl_12_Refreshing);
         edtBR_Diagnosis_DXDescription_Titleformat = 2;
         edtBR_Diagnosis_DXDescription_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "诊断名称", AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Diagnosis_DXDescription_Internalname, "Title", edtBR_Diagnosis_DXDescription_Title, !bGXsfl_12_Refreshing);
         cmbBR_Diagnosis_InitialDX_Titleformat = 2;
         cmbBR_Diagnosis_InitialDX.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "是否为原发肿瘤", AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Diagnosis_InitialDX_Internalname, "Title", cmbBR_Diagnosis_InitialDX.Title.Text, !bGXsfl_12_Refreshing);
         edtBR_Diagnosis_InitialDX_Code_Titleformat = 2;
         edtBR_Diagnosis_InitialDX_Code_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "是否为原发肿瘤code", AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Diagnosis_InitialDX_Code_Internalname, "Title", edtBR_Diagnosis_InitialDX_Code_Title, !bGXsfl_12_Refreshing);
         cmbBR_Diagnosis_MetastasesDX_Titleformat = 2;
         cmbBR_Diagnosis_MetastasesDX.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "是否为转移肿瘤", AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Diagnosis_MetastasesDX_Internalname, "Title", cmbBR_Diagnosis_MetastasesDX.Title.Text, !bGXsfl_12_Refreshing);
         edtBR_Diagnosis_MetastasesDX_Code_Titleformat = 2;
         edtBR_Diagnosis_MetastasesDX_Code_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "是否为转移肿瘤code", AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Diagnosis_MetastasesDX_Code_Internalname, "Title", edtBR_Diagnosis_MetastasesDX_Code_Title, !bGXsfl_12_Refreshing);
         edtBR_Diagnosis_DXSource_Titleformat = 2;
         edtBR_Diagnosis_DXSource_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "转移肿瘤来源", AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Diagnosis_DXSource_Internalname, "Title", edtBR_Diagnosis_DXSource_Title, !bGXsfl_12_Refreshing);
         AV34GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34GridCurrentPage), 10, 0)));
         AV35GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV35GridPageSize), 10, 0)));
         AV36GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV36GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_DiagnosisIDTitleFilterData", AV12BR_DiagnosisIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Diagnosis_NoTitleFilterData", AV40BR_Diagnosis_NoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Diagnosis_DXIDTitleFilterData", AV18BR_Diagnosis_DXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Diagnosis_DXCodeTitleFilterData", AV20BR_Diagnosis_DXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Diagnosis_DXTypeTitleFilterData", AV22BR_Diagnosis_DXTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Diagnosis_DXType_CodeTitleFilterData", AV42BR_Diagnosis_DXType_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Diagnosis_DXTsourceTitleFilterData", AV24BR_Diagnosis_DXTsourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Diagnosis_DXTsource_CodeTitleFilterData", AV44BR_Diagnosis_DXTsource_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Diagnosis_DXDescriptionTitleFilterData", AV26BR_Diagnosis_DXDescriptionTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Diagnosis_InitialDXTitleFilterData", AV28BR_Diagnosis_InitialDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_Diagnosis_InitialDX_CodeTitleFilterData", AV46BR_Diagnosis_InitialDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Diagnosis_MetastasesDXTitleFilterData", AV30BR_Diagnosis_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData", AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Diagnosis_DXSourceTitleFilterData", AV38BR_Diagnosis_DXSourceTitleFilterData);
      }

      protected void E113D2( )
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

      protected void E123D2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E133D2( )
      {
         /* Ddo_br_diagnosisid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_diagnosisid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_diagnosisid_Sortedstatus = "ASC";
            ucDdo_br_diagnosisid.SendProperty(context, "", false, Ddo_br_diagnosisid_Internalname, "SortedStatus", Ddo_br_diagnosisid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_diagnosisid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_diagnosisid_Sortedstatus = "DSC";
            ucDdo_br_diagnosisid.SendProperty(context, "", false, Ddo_br_diagnosisid_Internalname, "SortedStatus", Ddo_br_diagnosisid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_DiagnosisIDTitleFilterData", AV12BR_DiagnosisIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Diagnosis_NoTitleFilterData", AV40BR_Diagnosis_NoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Diagnosis_DXIDTitleFilterData", AV18BR_Diagnosis_DXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Diagnosis_DXCodeTitleFilterData", AV20BR_Diagnosis_DXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Diagnosis_DXTypeTitleFilterData", AV22BR_Diagnosis_DXTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Diagnosis_DXType_CodeTitleFilterData", AV42BR_Diagnosis_DXType_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Diagnosis_DXTsourceTitleFilterData", AV24BR_Diagnosis_DXTsourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Diagnosis_DXTsource_CodeTitleFilterData", AV44BR_Diagnosis_DXTsource_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Diagnosis_DXDescriptionTitleFilterData", AV26BR_Diagnosis_DXDescriptionTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Diagnosis_InitialDXTitleFilterData", AV28BR_Diagnosis_InitialDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_Diagnosis_InitialDX_CodeTitleFilterData", AV46BR_Diagnosis_InitialDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Diagnosis_MetastasesDXTitleFilterData", AV30BR_Diagnosis_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData", AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Diagnosis_DXSourceTitleFilterData", AV38BR_Diagnosis_DXSourceTitleFilterData);
      }

      protected void E143D2( )
      {
         /* Ddo_br_encounterid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounterid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_encounterid_Sortedstatus = "ASC";
            ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounterid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_encounterid_Sortedstatus = "DSC";
            ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_DiagnosisIDTitleFilterData", AV12BR_DiagnosisIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Diagnosis_NoTitleFilterData", AV40BR_Diagnosis_NoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Diagnosis_DXIDTitleFilterData", AV18BR_Diagnosis_DXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Diagnosis_DXCodeTitleFilterData", AV20BR_Diagnosis_DXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Diagnosis_DXTypeTitleFilterData", AV22BR_Diagnosis_DXTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Diagnosis_DXType_CodeTitleFilterData", AV42BR_Diagnosis_DXType_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Diagnosis_DXTsourceTitleFilterData", AV24BR_Diagnosis_DXTsourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Diagnosis_DXTsource_CodeTitleFilterData", AV44BR_Diagnosis_DXTsource_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Diagnosis_DXDescriptionTitleFilterData", AV26BR_Diagnosis_DXDescriptionTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Diagnosis_InitialDXTitleFilterData", AV28BR_Diagnosis_InitialDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_Diagnosis_InitialDX_CodeTitleFilterData", AV46BR_Diagnosis_InitialDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Diagnosis_MetastasesDXTitleFilterData", AV30BR_Diagnosis_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData", AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Diagnosis_DXSourceTitleFilterData", AV38BR_Diagnosis_DXSourceTitleFilterData);
      }

      protected void E153D2( )
      {
         /* Ddo_br_information_patientno_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_information_patientno_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_information_patientno_Sortedstatus = "ASC";
            ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "SortedStatus", Ddo_br_information_patientno_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_information_patientno_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_information_patientno_Sortedstatus = "DSC";
            ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "SortedStatus", Ddo_br_information_patientno_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_DiagnosisIDTitleFilterData", AV12BR_DiagnosisIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Diagnosis_NoTitleFilterData", AV40BR_Diagnosis_NoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Diagnosis_DXIDTitleFilterData", AV18BR_Diagnosis_DXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Diagnosis_DXCodeTitleFilterData", AV20BR_Diagnosis_DXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Diagnosis_DXTypeTitleFilterData", AV22BR_Diagnosis_DXTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Diagnosis_DXType_CodeTitleFilterData", AV42BR_Diagnosis_DXType_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Diagnosis_DXTsourceTitleFilterData", AV24BR_Diagnosis_DXTsourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Diagnosis_DXTsource_CodeTitleFilterData", AV44BR_Diagnosis_DXTsource_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Diagnosis_DXDescriptionTitleFilterData", AV26BR_Diagnosis_DXDescriptionTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Diagnosis_InitialDXTitleFilterData", AV28BR_Diagnosis_InitialDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_Diagnosis_InitialDX_CodeTitleFilterData", AV46BR_Diagnosis_InitialDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Diagnosis_MetastasesDXTitleFilterData", AV30BR_Diagnosis_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData", AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Diagnosis_DXSourceTitleFilterData", AV38BR_Diagnosis_DXSourceTitleFilterData);
      }

      protected void E163D2( )
      {
         /* Ddo_br_diagnosis_no_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_diagnosis_no_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_diagnosis_no_Sortedstatus = "ASC";
            ucDdo_br_diagnosis_no.SendProperty(context, "", false, Ddo_br_diagnosis_no_Internalname, "SortedStatus", Ddo_br_diagnosis_no_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_diagnosis_no_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_diagnosis_no_Sortedstatus = "DSC";
            ucDdo_br_diagnosis_no.SendProperty(context, "", false, Ddo_br_diagnosis_no_Internalname, "SortedStatus", Ddo_br_diagnosis_no_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_DiagnosisIDTitleFilterData", AV12BR_DiagnosisIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Diagnosis_NoTitleFilterData", AV40BR_Diagnosis_NoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Diagnosis_DXIDTitleFilterData", AV18BR_Diagnosis_DXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Diagnosis_DXCodeTitleFilterData", AV20BR_Diagnosis_DXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Diagnosis_DXTypeTitleFilterData", AV22BR_Diagnosis_DXTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Diagnosis_DXType_CodeTitleFilterData", AV42BR_Diagnosis_DXType_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Diagnosis_DXTsourceTitleFilterData", AV24BR_Diagnosis_DXTsourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Diagnosis_DXTsource_CodeTitleFilterData", AV44BR_Diagnosis_DXTsource_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Diagnosis_DXDescriptionTitleFilterData", AV26BR_Diagnosis_DXDescriptionTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Diagnosis_InitialDXTitleFilterData", AV28BR_Diagnosis_InitialDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_Diagnosis_InitialDX_CodeTitleFilterData", AV46BR_Diagnosis_InitialDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Diagnosis_MetastasesDXTitleFilterData", AV30BR_Diagnosis_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData", AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Diagnosis_DXSourceTitleFilterData", AV38BR_Diagnosis_DXSourceTitleFilterData);
      }

      protected void E173D2( )
      {
         /* Ddo_br_diagnosis_dxid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_diagnosis_dxid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_diagnosis_dxid_Sortedstatus = "ASC";
            ucDdo_br_diagnosis_dxid.SendProperty(context, "", false, Ddo_br_diagnosis_dxid_Internalname, "SortedStatus", Ddo_br_diagnosis_dxid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_diagnosis_dxid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_diagnosis_dxid_Sortedstatus = "DSC";
            ucDdo_br_diagnosis_dxid.SendProperty(context, "", false, Ddo_br_diagnosis_dxid_Internalname, "SortedStatus", Ddo_br_diagnosis_dxid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_DiagnosisIDTitleFilterData", AV12BR_DiagnosisIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Diagnosis_NoTitleFilterData", AV40BR_Diagnosis_NoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Diagnosis_DXIDTitleFilterData", AV18BR_Diagnosis_DXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Diagnosis_DXCodeTitleFilterData", AV20BR_Diagnosis_DXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Diagnosis_DXTypeTitleFilterData", AV22BR_Diagnosis_DXTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Diagnosis_DXType_CodeTitleFilterData", AV42BR_Diagnosis_DXType_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Diagnosis_DXTsourceTitleFilterData", AV24BR_Diagnosis_DXTsourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Diagnosis_DXTsource_CodeTitleFilterData", AV44BR_Diagnosis_DXTsource_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Diagnosis_DXDescriptionTitleFilterData", AV26BR_Diagnosis_DXDescriptionTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Diagnosis_InitialDXTitleFilterData", AV28BR_Diagnosis_InitialDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_Diagnosis_InitialDX_CodeTitleFilterData", AV46BR_Diagnosis_InitialDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Diagnosis_MetastasesDXTitleFilterData", AV30BR_Diagnosis_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData", AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Diagnosis_DXSourceTitleFilterData", AV38BR_Diagnosis_DXSourceTitleFilterData);
      }

      protected void E183D2( )
      {
         /* Ddo_br_diagnosis_dxcode_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_diagnosis_dxcode_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_diagnosis_dxcode_Sortedstatus = "ASC";
            ucDdo_br_diagnosis_dxcode.SendProperty(context, "", false, Ddo_br_diagnosis_dxcode_Internalname, "SortedStatus", Ddo_br_diagnosis_dxcode_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_diagnosis_dxcode_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_diagnosis_dxcode_Sortedstatus = "DSC";
            ucDdo_br_diagnosis_dxcode.SendProperty(context, "", false, Ddo_br_diagnosis_dxcode_Internalname, "SortedStatus", Ddo_br_diagnosis_dxcode_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_DiagnosisIDTitleFilterData", AV12BR_DiagnosisIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Diagnosis_NoTitleFilterData", AV40BR_Diagnosis_NoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Diagnosis_DXIDTitleFilterData", AV18BR_Diagnosis_DXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Diagnosis_DXCodeTitleFilterData", AV20BR_Diagnosis_DXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Diagnosis_DXTypeTitleFilterData", AV22BR_Diagnosis_DXTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Diagnosis_DXType_CodeTitleFilterData", AV42BR_Diagnosis_DXType_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Diagnosis_DXTsourceTitleFilterData", AV24BR_Diagnosis_DXTsourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Diagnosis_DXTsource_CodeTitleFilterData", AV44BR_Diagnosis_DXTsource_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Diagnosis_DXDescriptionTitleFilterData", AV26BR_Diagnosis_DXDescriptionTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Diagnosis_InitialDXTitleFilterData", AV28BR_Diagnosis_InitialDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_Diagnosis_InitialDX_CodeTitleFilterData", AV46BR_Diagnosis_InitialDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Diagnosis_MetastasesDXTitleFilterData", AV30BR_Diagnosis_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData", AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Diagnosis_DXSourceTitleFilterData", AV38BR_Diagnosis_DXSourceTitleFilterData);
      }

      protected void E193D2( )
      {
         /* Ddo_br_diagnosis_dxtype_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_diagnosis_dxtype_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_diagnosis_dxtype_Sortedstatus = "ASC";
            ucDdo_br_diagnosis_dxtype.SendProperty(context, "", false, Ddo_br_diagnosis_dxtype_Internalname, "SortedStatus", Ddo_br_diagnosis_dxtype_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_diagnosis_dxtype_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_diagnosis_dxtype_Sortedstatus = "DSC";
            ucDdo_br_diagnosis_dxtype.SendProperty(context, "", false, Ddo_br_diagnosis_dxtype_Internalname, "SortedStatus", Ddo_br_diagnosis_dxtype_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_DiagnosisIDTitleFilterData", AV12BR_DiagnosisIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Diagnosis_NoTitleFilterData", AV40BR_Diagnosis_NoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Diagnosis_DXIDTitleFilterData", AV18BR_Diagnosis_DXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Diagnosis_DXCodeTitleFilterData", AV20BR_Diagnosis_DXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Diagnosis_DXTypeTitleFilterData", AV22BR_Diagnosis_DXTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Diagnosis_DXType_CodeTitleFilterData", AV42BR_Diagnosis_DXType_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Diagnosis_DXTsourceTitleFilterData", AV24BR_Diagnosis_DXTsourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Diagnosis_DXTsource_CodeTitleFilterData", AV44BR_Diagnosis_DXTsource_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Diagnosis_DXDescriptionTitleFilterData", AV26BR_Diagnosis_DXDescriptionTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Diagnosis_InitialDXTitleFilterData", AV28BR_Diagnosis_InitialDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_Diagnosis_InitialDX_CodeTitleFilterData", AV46BR_Diagnosis_InitialDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Diagnosis_MetastasesDXTitleFilterData", AV30BR_Diagnosis_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData", AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Diagnosis_DXSourceTitleFilterData", AV38BR_Diagnosis_DXSourceTitleFilterData);
      }

      protected void E203D2( )
      {
         /* Ddo_br_diagnosis_dxtype_code_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_diagnosis_dxtype_code_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_diagnosis_dxtype_code_Sortedstatus = "ASC";
            ucDdo_br_diagnosis_dxtype_code.SendProperty(context, "", false, Ddo_br_diagnosis_dxtype_code_Internalname, "SortedStatus", Ddo_br_diagnosis_dxtype_code_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_diagnosis_dxtype_code_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_diagnosis_dxtype_code_Sortedstatus = "DSC";
            ucDdo_br_diagnosis_dxtype_code.SendProperty(context, "", false, Ddo_br_diagnosis_dxtype_code_Internalname, "SortedStatus", Ddo_br_diagnosis_dxtype_code_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_DiagnosisIDTitleFilterData", AV12BR_DiagnosisIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Diagnosis_NoTitleFilterData", AV40BR_Diagnosis_NoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Diagnosis_DXIDTitleFilterData", AV18BR_Diagnosis_DXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Diagnosis_DXCodeTitleFilterData", AV20BR_Diagnosis_DXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Diagnosis_DXTypeTitleFilterData", AV22BR_Diagnosis_DXTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Diagnosis_DXType_CodeTitleFilterData", AV42BR_Diagnosis_DXType_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Diagnosis_DXTsourceTitleFilterData", AV24BR_Diagnosis_DXTsourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Diagnosis_DXTsource_CodeTitleFilterData", AV44BR_Diagnosis_DXTsource_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Diagnosis_DXDescriptionTitleFilterData", AV26BR_Diagnosis_DXDescriptionTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Diagnosis_InitialDXTitleFilterData", AV28BR_Diagnosis_InitialDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_Diagnosis_InitialDX_CodeTitleFilterData", AV46BR_Diagnosis_InitialDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Diagnosis_MetastasesDXTitleFilterData", AV30BR_Diagnosis_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData", AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Diagnosis_DXSourceTitleFilterData", AV38BR_Diagnosis_DXSourceTitleFilterData);
      }

      protected void E213D2( )
      {
         /* Ddo_br_diagnosis_dxtsource_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_diagnosis_dxtsource_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_diagnosis_dxtsource_Sortedstatus = "ASC";
            ucDdo_br_diagnosis_dxtsource.SendProperty(context, "", false, Ddo_br_diagnosis_dxtsource_Internalname, "SortedStatus", Ddo_br_diagnosis_dxtsource_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_diagnosis_dxtsource_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_diagnosis_dxtsource_Sortedstatus = "DSC";
            ucDdo_br_diagnosis_dxtsource.SendProperty(context, "", false, Ddo_br_diagnosis_dxtsource_Internalname, "SortedStatus", Ddo_br_diagnosis_dxtsource_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_DiagnosisIDTitleFilterData", AV12BR_DiagnosisIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Diagnosis_NoTitleFilterData", AV40BR_Diagnosis_NoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Diagnosis_DXIDTitleFilterData", AV18BR_Diagnosis_DXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Diagnosis_DXCodeTitleFilterData", AV20BR_Diagnosis_DXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Diagnosis_DXTypeTitleFilterData", AV22BR_Diagnosis_DXTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Diagnosis_DXType_CodeTitleFilterData", AV42BR_Diagnosis_DXType_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Diagnosis_DXTsourceTitleFilterData", AV24BR_Diagnosis_DXTsourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Diagnosis_DXTsource_CodeTitleFilterData", AV44BR_Diagnosis_DXTsource_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Diagnosis_DXDescriptionTitleFilterData", AV26BR_Diagnosis_DXDescriptionTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Diagnosis_InitialDXTitleFilterData", AV28BR_Diagnosis_InitialDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_Diagnosis_InitialDX_CodeTitleFilterData", AV46BR_Diagnosis_InitialDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Diagnosis_MetastasesDXTitleFilterData", AV30BR_Diagnosis_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData", AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Diagnosis_DXSourceTitleFilterData", AV38BR_Diagnosis_DXSourceTitleFilterData);
      }

      protected void E223D2( )
      {
         /* Ddo_br_diagnosis_dxtsource_code_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_diagnosis_dxtsource_code_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 10;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_diagnosis_dxtsource_code_Sortedstatus = "ASC";
            ucDdo_br_diagnosis_dxtsource_code.SendProperty(context, "", false, Ddo_br_diagnosis_dxtsource_code_Internalname, "SortedStatus", Ddo_br_diagnosis_dxtsource_code_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_diagnosis_dxtsource_code_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 10;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_diagnosis_dxtsource_code_Sortedstatus = "DSC";
            ucDdo_br_diagnosis_dxtsource_code.SendProperty(context, "", false, Ddo_br_diagnosis_dxtsource_code_Internalname, "SortedStatus", Ddo_br_diagnosis_dxtsource_code_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_DiagnosisIDTitleFilterData", AV12BR_DiagnosisIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Diagnosis_NoTitleFilterData", AV40BR_Diagnosis_NoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Diagnosis_DXIDTitleFilterData", AV18BR_Diagnosis_DXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Diagnosis_DXCodeTitleFilterData", AV20BR_Diagnosis_DXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Diagnosis_DXTypeTitleFilterData", AV22BR_Diagnosis_DXTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Diagnosis_DXType_CodeTitleFilterData", AV42BR_Diagnosis_DXType_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Diagnosis_DXTsourceTitleFilterData", AV24BR_Diagnosis_DXTsourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Diagnosis_DXTsource_CodeTitleFilterData", AV44BR_Diagnosis_DXTsource_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Diagnosis_DXDescriptionTitleFilterData", AV26BR_Diagnosis_DXDescriptionTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Diagnosis_InitialDXTitleFilterData", AV28BR_Diagnosis_InitialDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_Diagnosis_InitialDX_CodeTitleFilterData", AV46BR_Diagnosis_InitialDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Diagnosis_MetastasesDXTitleFilterData", AV30BR_Diagnosis_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData", AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Diagnosis_DXSourceTitleFilterData", AV38BR_Diagnosis_DXSourceTitleFilterData);
      }

      protected void E233D2( )
      {
         /* Ddo_br_diagnosis_dxdescription_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_diagnosis_dxdescription_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_diagnosis_dxdescription_Sortedstatus = "ASC";
            ucDdo_br_diagnosis_dxdescription.SendProperty(context, "", false, Ddo_br_diagnosis_dxdescription_Internalname, "SortedStatus", Ddo_br_diagnosis_dxdescription_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_diagnosis_dxdescription_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_diagnosis_dxdescription_Sortedstatus = "DSC";
            ucDdo_br_diagnosis_dxdescription.SendProperty(context, "", false, Ddo_br_diagnosis_dxdescription_Internalname, "SortedStatus", Ddo_br_diagnosis_dxdescription_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_DiagnosisIDTitleFilterData", AV12BR_DiagnosisIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Diagnosis_NoTitleFilterData", AV40BR_Diagnosis_NoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Diagnosis_DXIDTitleFilterData", AV18BR_Diagnosis_DXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Diagnosis_DXCodeTitleFilterData", AV20BR_Diagnosis_DXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Diagnosis_DXTypeTitleFilterData", AV22BR_Diagnosis_DXTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Diagnosis_DXType_CodeTitleFilterData", AV42BR_Diagnosis_DXType_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Diagnosis_DXTsourceTitleFilterData", AV24BR_Diagnosis_DXTsourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Diagnosis_DXTsource_CodeTitleFilterData", AV44BR_Diagnosis_DXTsource_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Diagnosis_DXDescriptionTitleFilterData", AV26BR_Diagnosis_DXDescriptionTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Diagnosis_InitialDXTitleFilterData", AV28BR_Diagnosis_InitialDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_Diagnosis_InitialDX_CodeTitleFilterData", AV46BR_Diagnosis_InitialDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Diagnosis_MetastasesDXTitleFilterData", AV30BR_Diagnosis_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData", AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Diagnosis_DXSourceTitleFilterData", AV38BR_Diagnosis_DXSourceTitleFilterData);
      }

      protected void E243D2( )
      {
         /* Ddo_br_diagnosis_initialdx_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_diagnosis_initialdx_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_diagnosis_initialdx_Sortedstatus = "ASC";
            ucDdo_br_diagnosis_initialdx.SendProperty(context, "", false, Ddo_br_diagnosis_initialdx_Internalname, "SortedStatus", Ddo_br_diagnosis_initialdx_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_diagnosis_initialdx_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_diagnosis_initialdx_Sortedstatus = "DSC";
            ucDdo_br_diagnosis_initialdx.SendProperty(context, "", false, Ddo_br_diagnosis_initialdx_Internalname, "SortedStatus", Ddo_br_diagnosis_initialdx_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_DiagnosisIDTitleFilterData", AV12BR_DiagnosisIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Diagnosis_NoTitleFilterData", AV40BR_Diagnosis_NoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Diagnosis_DXIDTitleFilterData", AV18BR_Diagnosis_DXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Diagnosis_DXCodeTitleFilterData", AV20BR_Diagnosis_DXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Diagnosis_DXTypeTitleFilterData", AV22BR_Diagnosis_DXTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Diagnosis_DXType_CodeTitleFilterData", AV42BR_Diagnosis_DXType_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Diagnosis_DXTsourceTitleFilterData", AV24BR_Diagnosis_DXTsourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Diagnosis_DXTsource_CodeTitleFilterData", AV44BR_Diagnosis_DXTsource_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Diagnosis_DXDescriptionTitleFilterData", AV26BR_Diagnosis_DXDescriptionTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Diagnosis_InitialDXTitleFilterData", AV28BR_Diagnosis_InitialDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_Diagnosis_InitialDX_CodeTitleFilterData", AV46BR_Diagnosis_InitialDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Diagnosis_MetastasesDXTitleFilterData", AV30BR_Diagnosis_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData", AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Diagnosis_DXSourceTitleFilterData", AV38BR_Diagnosis_DXSourceTitleFilterData);
      }

      protected void E253D2( )
      {
         /* Ddo_br_diagnosis_initialdx_code_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_diagnosis_initialdx_code_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 13;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_diagnosis_initialdx_code_Sortedstatus = "ASC";
            ucDdo_br_diagnosis_initialdx_code.SendProperty(context, "", false, Ddo_br_diagnosis_initialdx_code_Internalname, "SortedStatus", Ddo_br_diagnosis_initialdx_code_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_diagnosis_initialdx_code_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 13;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_diagnosis_initialdx_code_Sortedstatus = "DSC";
            ucDdo_br_diagnosis_initialdx_code.SendProperty(context, "", false, Ddo_br_diagnosis_initialdx_code_Internalname, "SortedStatus", Ddo_br_diagnosis_initialdx_code_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_DiagnosisIDTitleFilterData", AV12BR_DiagnosisIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Diagnosis_NoTitleFilterData", AV40BR_Diagnosis_NoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Diagnosis_DXIDTitleFilterData", AV18BR_Diagnosis_DXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Diagnosis_DXCodeTitleFilterData", AV20BR_Diagnosis_DXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Diagnosis_DXTypeTitleFilterData", AV22BR_Diagnosis_DXTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Diagnosis_DXType_CodeTitleFilterData", AV42BR_Diagnosis_DXType_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Diagnosis_DXTsourceTitleFilterData", AV24BR_Diagnosis_DXTsourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Diagnosis_DXTsource_CodeTitleFilterData", AV44BR_Diagnosis_DXTsource_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Diagnosis_DXDescriptionTitleFilterData", AV26BR_Diagnosis_DXDescriptionTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Diagnosis_InitialDXTitleFilterData", AV28BR_Diagnosis_InitialDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_Diagnosis_InitialDX_CodeTitleFilterData", AV46BR_Diagnosis_InitialDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Diagnosis_MetastasesDXTitleFilterData", AV30BR_Diagnosis_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData", AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Diagnosis_DXSourceTitleFilterData", AV38BR_Diagnosis_DXSourceTitleFilterData);
      }

      protected void E263D2( )
      {
         /* Ddo_br_diagnosis_metastasesdx_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_diagnosis_metastasesdx_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 14;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_diagnosis_metastasesdx_Sortedstatus = "ASC";
            ucDdo_br_diagnosis_metastasesdx.SendProperty(context, "", false, Ddo_br_diagnosis_metastasesdx_Internalname, "SortedStatus", Ddo_br_diagnosis_metastasesdx_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_diagnosis_metastasesdx_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 14;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_diagnosis_metastasesdx_Sortedstatus = "DSC";
            ucDdo_br_diagnosis_metastasesdx.SendProperty(context, "", false, Ddo_br_diagnosis_metastasesdx_Internalname, "SortedStatus", Ddo_br_diagnosis_metastasesdx_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_DiagnosisIDTitleFilterData", AV12BR_DiagnosisIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Diagnosis_NoTitleFilterData", AV40BR_Diagnosis_NoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Diagnosis_DXIDTitleFilterData", AV18BR_Diagnosis_DXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Diagnosis_DXCodeTitleFilterData", AV20BR_Diagnosis_DXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Diagnosis_DXTypeTitleFilterData", AV22BR_Diagnosis_DXTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Diagnosis_DXType_CodeTitleFilterData", AV42BR_Diagnosis_DXType_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Diagnosis_DXTsourceTitleFilterData", AV24BR_Diagnosis_DXTsourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Diagnosis_DXTsource_CodeTitleFilterData", AV44BR_Diagnosis_DXTsource_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Diagnosis_DXDescriptionTitleFilterData", AV26BR_Diagnosis_DXDescriptionTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Diagnosis_InitialDXTitleFilterData", AV28BR_Diagnosis_InitialDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_Diagnosis_InitialDX_CodeTitleFilterData", AV46BR_Diagnosis_InitialDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Diagnosis_MetastasesDXTitleFilterData", AV30BR_Diagnosis_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData", AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Diagnosis_DXSourceTitleFilterData", AV38BR_Diagnosis_DXSourceTitleFilterData);
      }

      protected void E273D2( )
      {
         /* Ddo_br_diagnosis_metastasesdx_code_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_diagnosis_metastasesdx_code_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 15;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_diagnosis_metastasesdx_code_Sortedstatus = "ASC";
            ucDdo_br_diagnosis_metastasesdx_code.SendProperty(context, "", false, Ddo_br_diagnosis_metastasesdx_code_Internalname, "SortedStatus", Ddo_br_diagnosis_metastasesdx_code_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_diagnosis_metastasesdx_code_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 15;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_diagnosis_metastasesdx_code_Sortedstatus = "DSC";
            ucDdo_br_diagnosis_metastasesdx_code.SendProperty(context, "", false, Ddo_br_diagnosis_metastasesdx_code_Internalname, "SortedStatus", Ddo_br_diagnosis_metastasesdx_code_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_DiagnosisIDTitleFilterData", AV12BR_DiagnosisIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Diagnosis_NoTitleFilterData", AV40BR_Diagnosis_NoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Diagnosis_DXIDTitleFilterData", AV18BR_Diagnosis_DXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Diagnosis_DXCodeTitleFilterData", AV20BR_Diagnosis_DXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Diagnosis_DXTypeTitleFilterData", AV22BR_Diagnosis_DXTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Diagnosis_DXType_CodeTitleFilterData", AV42BR_Diagnosis_DXType_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Diagnosis_DXTsourceTitleFilterData", AV24BR_Diagnosis_DXTsourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Diagnosis_DXTsource_CodeTitleFilterData", AV44BR_Diagnosis_DXTsource_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Diagnosis_DXDescriptionTitleFilterData", AV26BR_Diagnosis_DXDescriptionTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Diagnosis_InitialDXTitleFilterData", AV28BR_Diagnosis_InitialDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_Diagnosis_InitialDX_CodeTitleFilterData", AV46BR_Diagnosis_InitialDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Diagnosis_MetastasesDXTitleFilterData", AV30BR_Diagnosis_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData", AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Diagnosis_DXSourceTitleFilterData", AV38BR_Diagnosis_DXSourceTitleFilterData);
      }

      protected void E283D2( )
      {
         /* Ddo_br_diagnosis_dxsource_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_diagnosis_dxsource_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 16;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_diagnosis_dxsource_Sortedstatus = "ASC";
            ucDdo_br_diagnosis_dxsource.SendProperty(context, "", false, Ddo_br_diagnosis_dxsource_Internalname, "SortedStatus", Ddo_br_diagnosis_dxsource_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_diagnosis_dxsource_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 16;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_diagnosis_dxsource_Sortedstatus = "DSC";
            ucDdo_br_diagnosis_dxsource.SendProperty(context, "", false, Ddo_br_diagnosis_dxsource_Internalname, "SortedStatus", Ddo_br_diagnosis_dxsource_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_DiagnosisIDTitleFilterData", AV12BR_DiagnosisIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Diagnosis_NoTitleFilterData", AV40BR_Diagnosis_NoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Diagnosis_DXIDTitleFilterData", AV18BR_Diagnosis_DXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Diagnosis_DXCodeTitleFilterData", AV20BR_Diagnosis_DXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Diagnosis_DXTypeTitleFilterData", AV22BR_Diagnosis_DXTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Diagnosis_DXType_CodeTitleFilterData", AV42BR_Diagnosis_DXType_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Diagnosis_DXTsourceTitleFilterData", AV24BR_Diagnosis_DXTsourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Diagnosis_DXTsource_CodeTitleFilterData", AV44BR_Diagnosis_DXTsource_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Diagnosis_DXDescriptionTitleFilterData", AV26BR_Diagnosis_DXDescriptionTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Diagnosis_InitialDXTitleFilterData", AV28BR_Diagnosis_InitialDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_Diagnosis_InitialDX_CodeTitleFilterData", AV46BR_Diagnosis_InitialDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Diagnosis_MetastasesDXTitleFilterData", AV30BR_Diagnosis_MetastasesDXTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData", AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Diagnosis_DXSourceTitleFilterData", AV38BR_Diagnosis_DXSourceTitleFilterData);
      }

      private void E313D2( )
      {
         /* Grid_Load Routine */
         AV37Select = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSelect_Internalname, AV37Select);
         AV53Select_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
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
         E323D2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E323D2( )
      {
         /* Enter Routine */
         AV8InOutBR_DiagnosisID = A64BR_DiagnosisID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_DiagnosisID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_DiagnosisID), 18, 0)));
         context.setWebReturnParms(new Object[] {(long)AV8InOutBR_DiagnosisID});
         context.setWebReturnParmsMetadata(new Object[] {"AV8InOutBR_DiagnosisID"});
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
         AV8InOutBR_DiagnosisID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_DiagnosisID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_DiagnosisID), 18, 0)));
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
         PA3D2( ) ;
         WS3D2( ) ;
         WE3D2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022711595050", true);
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
         context.AddJavascriptSource("br_diagnosisprompt.js", "?202022711595050", false);
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
         edtBR_DiagnosisID_Internalname = "BR_DIAGNOSISID_"+sGXsfl_12_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_12_idx;
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO_"+sGXsfl_12_idx;
         edtBR_Diagnosis_No_Internalname = "BR_DIAGNOSIS_NO_"+sGXsfl_12_idx;
         edtBR_Diagnosis_DXID_Internalname = "BR_DIAGNOSIS_DXID_"+sGXsfl_12_idx;
         edtBR_Diagnosis_DXCode_Internalname = "BR_DIAGNOSIS_DXCODE_"+sGXsfl_12_idx;
         edtBR_Diagnosis_DXType_Internalname = "BR_DIAGNOSIS_DXTYPE_"+sGXsfl_12_idx;
         edtBR_Diagnosis_DXType_Code_Internalname = "BR_DIAGNOSIS_DXTYPE_CODE_"+sGXsfl_12_idx;
         edtBR_Diagnosis_DXTsource_Internalname = "BR_DIAGNOSIS_DXTSOURCE_"+sGXsfl_12_idx;
         edtBR_Diagnosis_DXTsource_Code_Internalname = "BR_DIAGNOSIS_DXTSOURCE_CODE_"+sGXsfl_12_idx;
         edtBR_Diagnosis_DXDescription_Internalname = "BR_DIAGNOSIS_DXDESCRIPTION_"+sGXsfl_12_idx;
         cmbBR_Diagnosis_InitialDX_Internalname = "BR_DIAGNOSIS_INITIALDX_"+sGXsfl_12_idx;
         edtBR_Diagnosis_InitialDX_Code_Internalname = "BR_DIAGNOSIS_INITIALDX_CODE_"+sGXsfl_12_idx;
         cmbBR_Diagnosis_MetastasesDX_Internalname = "BR_DIAGNOSIS_METASTASESDX_"+sGXsfl_12_idx;
         edtBR_Diagnosis_MetastasesDX_Code_Internalname = "BR_DIAGNOSIS_METASTASESDX_CODE_"+sGXsfl_12_idx;
         edtBR_Diagnosis_DXSource_Internalname = "BR_DIAGNOSIS_DXSOURCE_"+sGXsfl_12_idx;
      }

      protected void SubsflControlProps_fel_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_fel_idx;
         edtBR_DiagnosisID_Internalname = "BR_DIAGNOSISID_"+sGXsfl_12_fel_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_12_fel_idx;
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO_"+sGXsfl_12_fel_idx;
         edtBR_Diagnosis_No_Internalname = "BR_DIAGNOSIS_NO_"+sGXsfl_12_fel_idx;
         edtBR_Diagnosis_DXID_Internalname = "BR_DIAGNOSIS_DXID_"+sGXsfl_12_fel_idx;
         edtBR_Diagnosis_DXCode_Internalname = "BR_DIAGNOSIS_DXCODE_"+sGXsfl_12_fel_idx;
         edtBR_Diagnosis_DXType_Internalname = "BR_DIAGNOSIS_DXTYPE_"+sGXsfl_12_fel_idx;
         edtBR_Diagnosis_DXType_Code_Internalname = "BR_DIAGNOSIS_DXTYPE_CODE_"+sGXsfl_12_fel_idx;
         edtBR_Diagnosis_DXTsource_Internalname = "BR_DIAGNOSIS_DXTSOURCE_"+sGXsfl_12_fel_idx;
         edtBR_Diagnosis_DXTsource_Code_Internalname = "BR_DIAGNOSIS_DXTSOURCE_CODE_"+sGXsfl_12_fel_idx;
         edtBR_Diagnosis_DXDescription_Internalname = "BR_DIAGNOSIS_DXDESCRIPTION_"+sGXsfl_12_fel_idx;
         cmbBR_Diagnosis_InitialDX_Internalname = "BR_DIAGNOSIS_INITIALDX_"+sGXsfl_12_fel_idx;
         edtBR_Diagnosis_InitialDX_Code_Internalname = "BR_DIAGNOSIS_INITIALDX_CODE_"+sGXsfl_12_fel_idx;
         cmbBR_Diagnosis_MetastasesDX_Internalname = "BR_DIAGNOSIS_METASTASESDX_"+sGXsfl_12_fel_idx;
         edtBR_Diagnosis_MetastasesDX_Code_Internalname = "BR_DIAGNOSIS_METASTASESDX_CODE_"+sGXsfl_12_fel_idx;
         edtBR_Diagnosis_DXSource_Internalname = "BR_DIAGNOSIS_DXSOURCE_"+sGXsfl_12_fel_idx;
      }

      protected void sendrow_122( )
      {
         SubsflControlProps_122( ) ;
         WB3D0( ) ;
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
            AV37Select_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV37Select))&&String.IsNullOrEmpty(StringUtil.RTrim( AV53Select_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV37Select)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV37Select)) ? AV53Select_GXI : context.PathToRelativeUrl( AV37Select));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSelect_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSelect_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSelect_Jsonclick,"'"+""+"'"+",false,"+"'"+"EENTER."+sGXsfl_12_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV37Select_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_DiagnosisID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A64BR_DiagnosisID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A64BR_DiagnosisID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_DiagnosisID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
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
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Diagnosis_No_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A513BR_Diagnosis_No), 10, 0, ".", "")),context.localUtil.Format( (decimal)(A513BR_Diagnosis_No), "ZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Diagnosis_No_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Diagnosis_DXID_Internalname,(String)A65BR_Diagnosis_DXID,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Diagnosis_DXID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Diagnosis_DXCode_Internalname,(String)A66BR_Diagnosis_DXCode,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Diagnosis_DXCode_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Diagnosis_DXType_Internalname,(String)A67BR_Diagnosis_DXType,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Diagnosis_DXType_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Diagnosis_DXType_Code_Internalname,(String)A466BR_Diagnosis_DXType_Code,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Diagnosis_DXType_Code_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Diagnosis_DXTsource_Internalname,(String)A68BR_Diagnosis_DXTsource,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Diagnosis_DXTsource_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Diagnosis_DXTsource_Code_Internalname,(String)A467BR_Diagnosis_DXTsource_Code,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Diagnosis_DXTsource_Code_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Diagnosis_DXDescription_Internalname,(String)A69BR_Diagnosis_DXDescription,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Diagnosis_DXDescription_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbBR_Diagnosis_InitialDX.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "BR_DIAGNOSIS_INITIALDX_" + sGXsfl_12_idx;
               cmbBR_Diagnosis_InitialDX.Name = GXCCtl;
               cmbBR_Diagnosis_InitialDX.WebTags = "";
               cmbBR_Diagnosis_InitialDX.addItem("", "(请选择)", 0);
               cmbBR_Diagnosis_InitialDX.addItem("否", "否", 0);
               cmbBR_Diagnosis_InitialDX.addItem("是", "是", 0);
               cmbBR_Diagnosis_InitialDX.addItem("不详", "不详", 0);
               if ( cmbBR_Diagnosis_InitialDX.ItemCount > 0 )
               {
                  A70BR_Diagnosis_InitialDX = cmbBR_Diagnosis_InitialDX.getValidValue(A70BR_Diagnosis_InitialDX);
                  n70BR_Diagnosis_InitialDX = false;
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbBR_Diagnosis_InitialDX,(String)cmbBR_Diagnosis_InitialDX_Internalname,StringUtil.RTrim( A70BR_Diagnosis_InitialDX),(short)1,(String)cmbBR_Diagnosis_InitialDX_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"svchar",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbBR_Diagnosis_InitialDX.CurrentValue = StringUtil.RTrim( A70BR_Diagnosis_InitialDX);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Diagnosis_InitialDX_Internalname, "Values", (String)(cmbBR_Diagnosis_InitialDX.ToJavascriptSource()), !bGXsfl_12_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Diagnosis_InitialDX_Code_Internalname,(String)A503BR_Diagnosis_InitialDX_Code,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Diagnosis_InitialDX_Code_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbBR_Diagnosis_MetastasesDX.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "BR_DIAGNOSIS_METASTASESDX_" + sGXsfl_12_idx;
               cmbBR_Diagnosis_MetastasesDX.Name = GXCCtl;
               cmbBR_Diagnosis_MetastasesDX.WebTags = "";
               cmbBR_Diagnosis_MetastasesDX.addItem("", "(请选择)", 0);
               cmbBR_Diagnosis_MetastasesDX.addItem("否", "否", 0);
               cmbBR_Diagnosis_MetastasesDX.addItem("是", "是", 0);
               cmbBR_Diagnosis_MetastasesDX.addItem("不详", "不详", 0);
               if ( cmbBR_Diagnosis_MetastasesDX.ItemCount > 0 )
               {
                  A71BR_Diagnosis_MetastasesDX = cmbBR_Diagnosis_MetastasesDX.getValidValue(A71BR_Diagnosis_MetastasesDX);
                  n71BR_Diagnosis_MetastasesDX = false;
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbBR_Diagnosis_MetastasesDX,(String)cmbBR_Diagnosis_MetastasesDX_Internalname,StringUtil.RTrim( A71BR_Diagnosis_MetastasesDX),(short)1,(String)cmbBR_Diagnosis_MetastasesDX_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"svchar",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbBR_Diagnosis_MetastasesDX.CurrentValue = StringUtil.RTrim( A71BR_Diagnosis_MetastasesDX);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Diagnosis_MetastasesDX_Internalname, "Values", (String)(cmbBR_Diagnosis_MetastasesDX.ToJavascriptSource()), !bGXsfl_12_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Diagnosis_MetastasesDX_Code_Internalname,(String)A504BR_Diagnosis_MetastasesDX_Code,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Diagnosis_MetastasesDX_Code_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Diagnosis_DXSource_Internalname,(String)A260BR_Diagnosis_DXSource,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Diagnosis_DXSource_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes3D2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_12_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_12_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1));
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
         }
         /* End function sendrow_122 */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "BR_DIAGNOSIS_INITIALDX_" + sGXsfl_12_idx;
         cmbBR_Diagnosis_InitialDX.Name = GXCCtl;
         cmbBR_Diagnosis_InitialDX.WebTags = "";
         cmbBR_Diagnosis_InitialDX.addItem("", "(请选择)", 0);
         cmbBR_Diagnosis_InitialDX.addItem("否", "否", 0);
         cmbBR_Diagnosis_InitialDX.addItem("是", "是", 0);
         cmbBR_Diagnosis_InitialDX.addItem("不详", "不详", 0);
         if ( cmbBR_Diagnosis_InitialDX.ItemCount > 0 )
         {
            A70BR_Diagnosis_InitialDX = cmbBR_Diagnosis_InitialDX.getValidValue(A70BR_Diagnosis_InitialDX);
            n70BR_Diagnosis_InitialDX = false;
         }
         GXCCtl = "BR_DIAGNOSIS_METASTASESDX_" + sGXsfl_12_idx;
         cmbBR_Diagnosis_MetastasesDX.Name = GXCCtl;
         cmbBR_Diagnosis_MetastasesDX.WebTags = "";
         cmbBR_Diagnosis_MetastasesDX.addItem("", "(请选择)", 0);
         cmbBR_Diagnosis_MetastasesDX.addItem("否", "否", 0);
         cmbBR_Diagnosis_MetastasesDX.addItem("是", "是", 0);
         cmbBR_Diagnosis_MetastasesDX.addItem("不详", "不详", 0);
         if ( cmbBR_Diagnosis_MetastasesDX.ItemCount > 0 )
         {
            A71BR_Diagnosis_MetastasesDX = cmbBR_Diagnosis_MetastasesDX.getValidValue(A71BR_Diagnosis_MetastasesDX);
            n71BR_Diagnosis_MetastasesDX = false;
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtavSelect_Internalname = "vSELECT";
         edtBR_DiagnosisID_Internalname = "BR_DIAGNOSISID";
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO";
         edtBR_Diagnosis_No_Internalname = "BR_DIAGNOSIS_NO";
         edtBR_Diagnosis_DXID_Internalname = "BR_DIAGNOSIS_DXID";
         edtBR_Diagnosis_DXCode_Internalname = "BR_DIAGNOSIS_DXCODE";
         edtBR_Diagnosis_DXType_Internalname = "BR_DIAGNOSIS_DXTYPE";
         edtBR_Diagnosis_DXType_Code_Internalname = "BR_DIAGNOSIS_DXTYPE_CODE";
         edtBR_Diagnosis_DXTsource_Internalname = "BR_DIAGNOSIS_DXTSOURCE";
         edtBR_Diagnosis_DXTsource_Code_Internalname = "BR_DIAGNOSIS_DXTSOURCE_CODE";
         edtBR_Diagnosis_DXDescription_Internalname = "BR_DIAGNOSIS_DXDESCRIPTION";
         cmbBR_Diagnosis_InitialDX_Internalname = "BR_DIAGNOSIS_INITIALDX";
         edtBR_Diagnosis_InitialDX_Code_Internalname = "BR_DIAGNOSIS_INITIALDX_CODE";
         cmbBR_Diagnosis_MetastasesDX_Internalname = "BR_DIAGNOSIS_METASTASESDX";
         edtBR_Diagnosis_MetastasesDX_Code_Internalname = "BR_DIAGNOSIS_METASTASESDX_CODE";
         edtBR_Diagnosis_DXSource_Internalname = "BR_DIAGNOSIS_DXSOURCE";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_diagnosisid_Internalname = "DDO_BR_DIAGNOSISID";
         edtavDdo_br_diagnosisidtitlecontrolidtoreplace_Internalname = "vDDO_BR_DIAGNOSISIDTITLECONTROLIDTOREPLACE";
         Ddo_br_encounterid_Internalname = "DDO_BR_ENCOUNTERID";
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE";
         Ddo_br_information_patientno_Internalname = "DDO_BR_INFORMATION_PATIENTNO";
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname = "vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE";
         Ddo_br_diagnosis_no_Internalname = "DDO_BR_DIAGNOSIS_NO";
         edtavDdo_br_diagnosis_notitlecontrolidtoreplace_Internalname = "vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE";
         Ddo_br_diagnosis_dxid_Internalname = "DDO_BR_DIAGNOSIS_DXID";
         edtavDdo_br_diagnosis_dxidtitlecontrolidtoreplace_Internalname = "vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE";
         Ddo_br_diagnosis_dxcode_Internalname = "DDO_BR_DIAGNOSIS_DXCODE";
         edtavDdo_br_diagnosis_dxcodetitlecontrolidtoreplace_Internalname = "vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE";
         Ddo_br_diagnosis_dxtype_Internalname = "DDO_BR_DIAGNOSIS_DXTYPE";
         edtavDdo_br_diagnosis_dxtypetitlecontrolidtoreplace_Internalname = "vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE";
         Ddo_br_diagnosis_dxtype_code_Internalname = "DDO_BR_DIAGNOSIS_DXTYPE_CODE";
         edtavDdo_br_diagnosis_dxtype_codetitlecontrolidtoreplace_Internalname = "vDDO_BR_DIAGNOSIS_DXTYPE_CODETITLECONTROLIDTOREPLACE";
         Ddo_br_diagnosis_dxtsource_Internalname = "DDO_BR_DIAGNOSIS_DXTSOURCE";
         edtavDdo_br_diagnosis_dxtsourcetitlecontrolidtoreplace_Internalname = "vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE";
         Ddo_br_diagnosis_dxtsource_code_Internalname = "DDO_BR_DIAGNOSIS_DXTSOURCE_CODE";
         edtavDdo_br_diagnosis_dxtsource_codetitlecontrolidtoreplace_Internalname = "vDDO_BR_DIAGNOSIS_DXTSOURCE_CODETITLECONTROLIDTOREPLACE";
         Ddo_br_diagnosis_dxdescription_Internalname = "DDO_BR_DIAGNOSIS_DXDESCRIPTION";
         edtavDdo_br_diagnosis_dxdescriptiontitlecontrolidtoreplace_Internalname = "vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE";
         Ddo_br_diagnosis_initialdx_Internalname = "DDO_BR_DIAGNOSIS_INITIALDX";
         edtavDdo_br_diagnosis_initialdxtitlecontrolidtoreplace_Internalname = "vDDO_BR_DIAGNOSIS_INITIALDXTITLECONTROLIDTOREPLACE";
         Ddo_br_diagnosis_initialdx_code_Internalname = "DDO_BR_DIAGNOSIS_INITIALDX_CODE";
         edtavDdo_br_diagnosis_initialdx_codetitlecontrolidtoreplace_Internalname = "vDDO_BR_DIAGNOSIS_INITIALDX_CODETITLECONTROLIDTOREPLACE";
         Ddo_br_diagnosis_metastasesdx_Internalname = "DDO_BR_DIAGNOSIS_METASTASESDX";
         edtavDdo_br_diagnosis_metastasesdxtitlecontrolidtoreplace_Internalname = "vDDO_BR_DIAGNOSIS_METASTASESDXTITLECONTROLIDTOREPLACE";
         Ddo_br_diagnosis_metastasesdx_code_Internalname = "DDO_BR_DIAGNOSIS_METASTASESDX_CODE";
         edtavDdo_br_diagnosis_metastasesdx_codetitlecontrolidtoreplace_Internalname = "vDDO_BR_DIAGNOSIS_METASTASESDX_CODETITLECONTROLIDTOREPLACE";
         Ddo_br_diagnosis_dxsource_Internalname = "DDO_BR_DIAGNOSIS_DXSOURCE";
         edtavDdo_br_diagnosis_dxsourcetitlecontrolidtoreplace_Internalname = "vDDO_BR_DIAGNOSIS_DXSOURCETITLECONTROLIDTOREPLACE";
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
         edtBR_Diagnosis_DXSource_Jsonclick = "";
         edtBR_Diagnosis_MetastasesDX_Code_Jsonclick = "";
         cmbBR_Diagnosis_MetastasesDX_Jsonclick = "";
         edtBR_Diagnosis_InitialDX_Code_Jsonclick = "";
         cmbBR_Diagnosis_InitialDX_Jsonclick = "";
         edtBR_Diagnosis_DXDescription_Jsonclick = "";
         edtBR_Diagnosis_DXTsource_Code_Jsonclick = "";
         edtBR_Diagnosis_DXTsource_Jsonclick = "";
         edtBR_Diagnosis_DXType_Code_Jsonclick = "";
         edtBR_Diagnosis_DXType_Jsonclick = "";
         edtBR_Diagnosis_DXCode_Jsonclick = "";
         edtBR_Diagnosis_DXID_Jsonclick = "";
         edtBR_Diagnosis_No_Jsonclick = "";
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_EncounterID_Jsonclick = "";
         edtBR_DiagnosisID_Jsonclick = "";
         edtavSelect_Jsonclick = "";
         edtavSelect_Visible = -1;
         edtavSelect_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_diagnosis_dxsourcetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_diagnosis_metastasesdx_codetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_diagnosis_metastasesdxtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_diagnosis_initialdx_codetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_diagnosis_initialdxtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_diagnosis_dxdescriptiontitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_diagnosis_dxtsource_codetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_diagnosis_dxtsourcetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_diagnosis_dxtype_codetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_diagnosis_dxtypetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_diagnosis_dxcodetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_diagnosis_dxidtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_diagnosis_notitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_diagnosisidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavSelect_Tooltiptext = "选择";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Diagnosis_DXSource_Titleformat = 0;
         edtBR_Diagnosis_DXSource_Title = "转移肿瘤来源";
         edtBR_Diagnosis_MetastasesDX_Code_Titleformat = 0;
         edtBR_Diagnosis_MetastasesDX_Code_Title = "是否为转移肿瘤code";
         cmbBR_Diagnosis_MetastasesDX_Titleformat = 0;
         cmbBR_Diagnosis_MetastasesDX.Title.Text = "是否为转移肿瘤";
         edtBR_Diagnosis_InitialDX_Code_Titleformat = 0;
         edtBR_Diagnosis_InitialDX_Code_Title = "是否为原发肿瘤code";
         cmbBR_Diagnosis_InitialDX_Titleformat = 0;
         cmbBR_Diagnosis_InitialDX.Title.Text = "是否为原发肿瘤";
         edtBR_Diagnosis_DXDescription_Titleformat = 0;
         edtBR_Diagnosis_DXDescription_Title = "诊断名称";
         edtBR_Diagnosis_DXTsource_Code_Titleformat = 0;
         edtBR_Diagnosis_DXTsource_Code_Title = "诊断来源code";
         edtBR_Diagnosis_DXTsource_Titleformat = 0;
         edtBR_Diagnosis_DXTsource_Title = "诊断来源";
         edtBR_Diagnosis_DXType_Code_Titleformat = 0;
         edtBR_Diagnosis_DXType_Code_Title = "疾病类型code";
         edtBR_Diagnosis_DXType_Titleformat = 0;
         edtBR_Diagnosis_DXType_Title = "疾病类型";
         edtBR_Diagnosis_DXCode_Titleformat = 0;
         edtBR_Diagnosis_DXCode_Title = "疾病代码";
         edtBR_Diagnosis_DXID_Titleformat = 0;
         edtBR_Diagnosis_DXID_Title = "疾病序号";
         edtBR_Diagnosis_No_Titleformat = 0;
         edtBR_Diagnosis_No_Title = "诊断次序";
         edtBR_Information_PatientNo_Titleformat = 0;
         edtBR_Information_PatientNo_Title = "患者编号";
         edtBR_EncounterID_Titleformat = 0;
         edtBR_EncounterID_Title = "就诊信息主键";
         edtBR_DiagnosisID_Titleformat = 0;
         edtBR_DiagnosisID_Title = "诊断主键";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         divTablemain_Height = 0;
         Ddo_br_diagnosis_dxsource_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_diagnosis_dxsource_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_diagnosis_dxsource_Sortasc = "WWP_TSSortASC";
         Ddo_br_diagnosis_dxsource_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_dxsource_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_dxsource_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_dxsource_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_dxsource_Titlecontrolidtoreplace = "";
         Ddo_br_diagnosis_dxsource_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_diagnosis_dxsource_Cls = "ColumnSettings";
         Ddo_br_diagnosis_dxsource_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_diagnosis_dxsource_Caption = "";
         Ddo_br_diagnosis_metastasesdx_code_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_diagnosis_metastasesdx_code_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_diagnosis_metastasesdx_code_Sortasc = "WWP_TSSortASC";
         Ddo_br_diagnosis_metastasesdx_code_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_metastasesdx_code_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_metastasesdx_code_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_metastasesdx_code_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_metastasesdx_code_Titlecontrolidtoreplace = "";
         Ddo_br_diagnosis_metastasesdx_code_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_diagnosis_metastasesdx_code_Cls = "ColumnSettings";
         Ddo_br_diagnosis_metastasesdx_code_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_diagnosis_metastasesdx_code_Caption = "";
         Ddo_br_diagnosis_metastasesdx_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_diagnosis_metastasesdx_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_diagnosis_metastasesdx_Sortasc = "WWP_TSSortASC";
         Ddo_br_diagnosis_metastasesdx_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_metastasesdx_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_metastasesdx_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_metastasesdx_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_metastasesdx_Titlecontrolidtoreplace = "";
         Ddo_br_diagnosis_metastasesdx_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_diagnosis_metastasesdx_Cls = "ColumnSettings";
         Ddo_br_diagnosis_metastasesdx_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_diagnosis_metastasesdx_Caption = "";
         Ddo_br_diagnosis_initialdx_code_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_diagnosis_initialdx_code_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_diagnosis_initialdx_code_Sortasc = "WWP_TSSortASC";
         Ddo_br_diagnosis_initialdx_code_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_initialdx_code_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_initialdx_code_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_initialdx_code_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_initialdx_code_Titlecontrolidtoreplace = "";
         Ddo_br_diagnosis_initialdx_code_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_diagnosis_initialdx_code_Cls = "ColumnSettings";
         Ddo_br_diagnosis_initialdx_code_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_diagnosis_initialdx_code_Caption = "";
         Ddo_br_diagnosis_initialdx_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_diagnosis_initialdx_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_diagnosis_initialdx_Sortasc = "WWP_TSSortASC";
         Ddo_br_diagnosis_initialdx_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_initialdx_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_initialdx_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_initialdx_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_initialdx_Titlecontrolidtoreplace = "";
         Ddo_br_diagnosis_initialdx_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_diagnosis_initialdx_Cls = "ColumnSettings";
         Ddo_br_diagnosis_initialdx_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_diagnosis_initialdx_Caption = "";
         Ddo_br_diagnosis_dxdescription_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_diagnosis_dxdescription_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_diagnosis_dxdescription_Sortasc = "WWP_TSSortASC";
         Ddo_br_diagnosis_dxdescription_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_dxdescription_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_dxdescription_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_dxdescription_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_dxdescription_Titlecontrolidtoreplace = "";
         Ddo_br_diagnosis_dxdescription_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_diagnosis_dxdescription_Cls = "ColumnSettings";
         Ddo_br_diagnosis_dxdescription_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_diagnosis_dxdescription_Caption = "";
         Ddo_br_diagnosis_dxtsource_code_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_diagnosis_dxtsource_code_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_diagnosis_dxtsource_code_Sortasc = "WWP_TSSortASC";
         Ddo_br_diagnosis_dxtsource_code_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_dxtsource_code_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_dxtsource_code_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_dxtsource_code_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_dxtsource_code_Titlecontrolidtoreplace = "";
         Ddo_br_diagnosis_dxtsource_code_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_diagnosis_dxtsource_code_Cls = "ColumnSettings";
         Ddo_br_diagnosis_dxtsource_code_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_diagnosis_dxtsource_code_Caption = "";
         Ddo_br_diagnosis_dxtsource_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_diagnosis_dxtsource_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_diagnosis_dxtsource_Sortasc = "WWP_TSSortASC";
         Ddo_br_diagnosis_dxtsource_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_dxtsource_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_dxtsource_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_dxtsource_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_dxtsource_Titlecontrolidtoreplace = "";
         Ddo_br_diagnosis_dxtsource_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_diagnosis_dxtsource_Cls = "ColumnSettings";
         Ddo_br_diagnosis_dxtsource_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_diagnosis_dxtsource_Caption = "";
         Ddo_br_diagnosis_dxtype_code_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_diagnosis_dxtype_code_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_diagnosis_dxtype_code_Sortasc = "WWP_TSSortASC";
         Ddo_br_diagnosis_dxtype_code_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_dxtype_code_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_dxtype_code_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_dxtype_code_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_dxtype_code_Titlecontrolidtoreplace = "";
         Ddo_br_diagnosis_dxtype_code_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_diagnosis_dxtype_code_Cls = "ColumnSettings";
         Ddo_br_diagnosis_dxtype_code_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_diagnosis_dxtype_code_Caption = "";
         Ddo_br_diagnosis_dxtype_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_diagnosis_dxtype_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_diagnosis_dxtype_Sortasc = "WWP_TSSortASC";
         Ddo_br_diagnosis_dxtype_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_dxtype_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_dxtype_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_dxtype_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_dxtype_Titlecontrolidtoreplace = "";
         Ddo_br_diagnosis_dxtype_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_diagnosis_dxtype_Cls = "ColumnSettings";
         Ddo_br_diagnosis_dxtype_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_diagnosis_dxtype_Caption = "";
         Ddo_br_diagnosis_dxcode_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_diagnosis_dxcode_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_diagnosis_dxcode_Sortasc = "WWP_TSSortASC";
         Ddo_br_diagnosis_dxcode_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_dxcode_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_dxcode_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_dxcode_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_dxcode_Titlecontrolidtoreplace = "";
         Ddo_br_diagnosis_dxcode_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_diagnosis_dxcode_Cls = "ColumnSettings";
         Ddo_br_diagnosis_dxcode_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_diagnosis_dxcode_Caption = "";
         Ddo_br_diagnosis_dxid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_diagnosis_dxid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_diagnosis_dxid_Sortasc = "WWP_TSSortASC";
         Ddo_br_diagnosis_dxid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_dxid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_dxid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_dxid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_dxid_Titlecontrolidtoreplace = "";
         Ddo_br_diagnosis_dxid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_diagnosis_dxid_Cls = "ColumnSettings";
         Ddo_br_diagnosis_dxid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_diagnosis_dxid_Caption = "";
         Ddo_br_diagnosis_no_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_diagnosis_no_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_diagnosis_no_Sortasc = "WWP_TSSortASC";
         Ddo_br_diagnosis_no_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_no_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_diagnosis_no_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_no_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_diagnosis_no_Titlecontrolidtoreplace = "";
         Ddo_br_diagnosis_no_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_diagnosis_no_Cls = "ColumnSettings";
         Ddo_br_diagnosis_no_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_diagnosis_no_Caption = "";
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
         Ddo_br_diagnosisid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_diagnosisid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_diagnosisid_Sortasc = "WWP_TSSortASC";
         Ddo_br_diagnosisid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_diagnosisid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_diagnosisid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_diagnosisid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_diagnosisid_Titlecontrolidtoreplace = "";
         Ddo_br_diagnosisid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_diagnosisid_Cls = "ColumnSettings";
         Ddo_br_diagnosisid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_diagnosisid_Caption = "";
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
         Form.Caption = "选择诊断";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_DiagnosisIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSISIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV12BR_DiagnosisIDTitleFilterData',fld:'vBR_DIAGNOSISIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV40BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV18BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{av:'AV42BR_Diagnosis_DXType_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPE_CODETITLEFILTERDATA',pic:''},{av:'AV24BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV44BR_Diagnosis_DXTsource_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCE_CODETITLEFILTERDATA',pic:''},{av:'AV26BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV28BR_Diagnosis_InitialDXTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDXTITLEFILTERDATA',pic:''},{av:'AV46BR_Diagnosis_InitialDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDX_CODETITLEFILTERDATA',pic:''},{av:'AV30BR_Diagnosis_MetastasesDXTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDX_CODETITLEFILTERDATA',pic:''},{av:'AV38BR_Diagnosis_DXSourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXSOURCETITLEFILTERDATA',pic:''},{av:'edtBR_DiagnosisID_Titleformat',ctrl:'BR_DIAGNOSISID',prop:'Titleformat'},{av:'edtBR_DiagnosisID_Title',ctrl:'BR_DIAGNOSISID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Diagnosis_No_Titleformat',ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'edtBR_Diagnosis_No_Title',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{av:'edtBR_Diagnosis_DXID_Titleformat',ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXID_Title',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{av:'edtBR_Diagnosis_DXCode_Titleformat',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXCode_Title',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Title',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Code_Title',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Code_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXDescription_Titleformat',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXDescription_Title',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{av:'cmbBR_Diagnosis_InitialDX'},{av:'edtBR_Diagnosis_InitialDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_InitialDX_Code_Title',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Title'},{av:'cmbBR_Diagnosis_MetastasesDX'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Title',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXSource_Titleformat',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXSource_Title',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E113D2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_DiagnosisIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSISIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E123D2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_DiagnosisIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSISIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_DIAGNOSISID.ONOPTIONCLICKED","{handler:'E133D2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_DiagnosisIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSISIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_diagnosisid_Activeeventkey',ctrl:'DDO_BR_DIAGNOSISID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_DIAGNOSISID.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_diagnosisid_Sortedstatus',ctrl:'DDO_BR_DIAGNOSISID',prop:'SortedStatus'},{av:'AV12BR_DiagnosisIDTitleFilterData',fld:'vBR_DIAGNOSISIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV40BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV18BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{av:'AV42BR_Diagnosis_DXType_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPE_CODETITLEFILTERDATA',pic:''},{av:'AV24BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV44BR_Diagnosis_DXTsource_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCE_CODETITLEFILTERDATA',pic:''},{av:'AV26BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV28BR_Diagnosis_InitialDXTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDXTITLEFILTERDATA',pic:''},{av:'AV46BR_Diagnosis_InitialDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDX_CODETITLEFILTERDATA',pic:''},{av:'AV30BR_Diagnosis_MetastasesDXTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDX_CODETITLEFILTERDATA',pic:''},{av:'AV38BR_Diagnosis_DXSourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXSOURCETITLEFILTERDATA',pic:''},{av:'edtBR_DiagnosisID_Titleformat',ctrl:'BR_DIAGNOSISID',prop:'Titleformat'},{av:'edtBR_DiagnosisID_Title',ctrl:'BR_DIAGNOSISID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Diagnosis_No_Titleformat',ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'edtBR_Diagnosis_No_Title',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{av:'edtBR_Diagnosis_DXID_Titleformat',ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXID_Title',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{av:'edtBR_Diagnosis_DXCode_Titleformat',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXCode_Title',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Title',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Code_Title',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Code_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXDescription_Titleformat',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXDescription_Title',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{av:'cmbBR_Diagnosis_InitialDX'},{av:'edtBR_Diagnosis_InitialDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_InitialDX_Code_Title',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Title'},{av:'cmbBR_Diagnosis_MetastasesDX'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Title',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXSource_Titleformat',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXSource_Title',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED","{handler:'E143D2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_DiagnosisIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSISIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_encounterid_Activeeventkey',ctrl:'DDO_BR_ENCOUNTERID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'AV12BR_DiagnosisIDTitleFilterData',fld:'vBR_DIAGNOSISIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV40BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV18BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{av:'AV42BR_Diagnosis_DXType_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPE_CODETITLEFILTERDATA',pic:''},{av:'AV24BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV44BR_Diagnosis_DXTsource_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCE_CODETITLEFILTERDATA',pic:''},{av:'AV26BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV28BR_Diagnosis_InitialDXTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDXTITLEFILTERDATA',pic:''},{av:'AV46BR_Diagnosis_InitialDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDX_CODETITLEFILTERDATA',pic:''},{av:'AV30BR_Diagnosis_MetastasesDXTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDX_CODETITLEFILTERDATA',pic:''},{av:'AV38BR_Diagnosis_DXSourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXSOURCETITLEFILTERDATA',pic:''},{av:'edtBR_DiagnosisID_Titleformat',ctrl:'BR_DIAGNOSISID',prop:'Titleformat'},{av:'edtBR_DiagnosisID_Title',ctrl:'BR_DIAGNOSISID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Diagnosis_No_Titleformat',ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'edtBR_Diagnosis_No_Title',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{av:'edtBR_Diagnosis_DXID_Titleformat',ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXID_Title',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{av:'edtBR_Diagnosis_DXCode_Titleformat',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXCode_Title',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Title',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Code_Title',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Code_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXDescription_Titleformat',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXDescription_Title',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{av:'cmbBR_Diagnosis_InitialDX'},{av:'edtBR_Diagnosis_InitialDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_InitialDX_Code_Title',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Title'},{av:'cmbBR_Diagnosis_MetastasesDX'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Title',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXSource_Titleformat',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXSource_Title',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED","{handler:'E153D2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_DiagnosisIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSISIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_information_patientno_Activeeventkey',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'AV12BR_DiagnosisIDTitleFilterData',fld:'vBR_DIAGNOSISIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV40BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV18BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{av:'AV42BR_Diagnosis_DXType_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPE_CODETITLEFILTERDATA',pic:''},{av:'AV24BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV44BR_Diagnosis_DXTsource_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCE_CODETITLEFILTERDATA',pic:''},{av:'AV26BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV28BR_Diagnosis_InitialDXTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDXTITLEFILTERDATA',pic:''},{av:'AV46BR_Diagnosis_InitialDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDX_CODETITLEFILTERDATA',pic:''},{av:'AV30BR_Diagnosis_MetastasesDXTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDX_CODETITLEFILTERDATA',pic:''},{av:'AV38BR_Diagnosis_DXSourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXSOURCETITLEFILTERDATA',pic:''},{av:'edtBR_DiagnosisID_Titleformat',ctrl:'BR_DIAGNOSISID',prop:'Titleformat'},{av:'edtBR_DiagnosisID_Title',ctrl:'BR_DIAGNOSISID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Diagnosis_No_Titleformat',ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'edtBR_Diagnosis_No_Title',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{av:'edtBR_Diagnosis_DXID_Titleformat',ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXID_Title',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{av:'edtBR_Diagnosis_DXCode_Titleformat',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXCode_Title',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Title',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Code_Title',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Code_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXDescription_Titleformat',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXDescription_Title',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{av:'cmbBR_Diagnosis_InitialDX'},{av:'edtBR_Diagnosis_InitialDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_InitialDX_Code_Title',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Title'},{av:'cmbBR_Diagnosis_MetastasesDX'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Title',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXSource_Titleformat',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXSource_Title',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_DIAGNOSIS_NO.ONOPTIONCLICKED","{handler:'E163D2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_DiagnosisIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSISIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_diagnosis_no_Activeeventkey',ctrl:'DDO_BR_DIAGNOSIS_NO',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_DIAGNOSIS_NO.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_diagnosis_no_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_NO',prop:'SortedStatus'},{av:'AV12BR_DiagnosisIDTitleFilterData',fld:'vBR_DIAGNOSISIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV40BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV18BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{av:'AV42BR_Diagnosis_DXType_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPE_CODETITLEFILTERDATA',pic:''},{av:'AV24BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV44BR_Diagnosis_DXTsource_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCE_CODETITLEFILTERDATA',pic:''},{av:'AV26BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV28BR_Diagnosis_InitialDXTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDXTITLEFILTERDATA',pic:''},{av:'AV46BR_Diagnosis_InitialDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDX_CODETITLEFILTERDATA',pic:''},{av:'AV30BR_Diagnosis_MetastasesDXTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDX_CODETITLEFILTERDATA',pic:''},{av:'AV38BR_Diagnosis_DXSourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXSOURCETITLEFILTERDATA',pic:''},{av:'edtBR_DiagnosisID_Titleformat',ctrl:'BR_DIAGNOSISID',prop:'Titleformat'},{av:'edtBR_DiagnosisID_Title',ctrl:'BR_DIAGNOSISID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Diagnosis_No_Titleformat',ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'edtBR_Diagnosis_No_Title',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{av:'edtBR_Diagnosis_DXID_Titleformat',ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXID_Title',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{av:'edtBR_Diagnosis_DXCode_Titleformat',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXCode_Title',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Title',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Code_Title',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Code_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXDescription_Titleformat',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXDescription_Title',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{av:'cmbBR_Diagnosis_InitialDX'},{av:'edtBR_Diagnosis_InitialDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_InitialDX_Code_Title',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Title'},{av:'cmbBR_Diagnosis_MetastasesDX'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Title',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXSource_Titleformat',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXSource_Title',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_DIAGNOSIS_DXID.ONOPTIONCLICKED","{handler:'E173D2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_DiagnosisIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSISIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_diagnosis_dxid_Activeeventkey',ctrl:'DDO_BR_DIAGNOSIS_DXID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_DIAGNOSIS_DXID.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_diagnosis_dxid_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXID',prop:'SortedStatus'},{av:'AV12BR_DiagnosisIDTitleFilterData',fld:'vBR_DIAGNOSISIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV40BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV18BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{av:'AV42BR_Diagnosis_DXType_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPE_CODETITLEFILTERDATA',pic:''},{av:'AV24BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV44BR_Diagnosis_DXTsource_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCE_CODETITLEFILTERDATA',pic:''},{av:'AV26BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV28BR_Diagnosis_InitialDXTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDXTITLEFILTERDATA',pic:''},{av:'AV46BR_Diagnosis_InitialDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDX_CODETITLEFILTERDATA',pic:''},{av:'AV30BR_Diagnosis_MetastasesDXTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDX_CODETITLEFILTERDATA',pic:''},{av:'AV38BR_Diagnosis_DXSourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXSOURCETITLEFILTERDATA',pic:''},{av:'edtBR_DiagnosisID_Titleformat',ctrl:'BR_DIAGNOSISID',prop:'Titleformat'},{av:'edtBR_DiagnosisID_Title',ctrl:'BR_DIAGNOSISID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Diagnosis_No_Titleformat',ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'edtBR_Diagnosis_No_Title',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{av:'edtBR_Diagnosis_DXID_Titleformat',ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXID_Title',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{av:'edtBR_Diagnosis_DXCode_Titleformat',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXCode_Title',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Title',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Code_Title',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Code_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXDescription_Titleformat',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXDescription_Title',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{av:'cmbBR_Diagnosis_InitialDX'},{av:'edtBR_Diagnosis_InitialDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_InitialDX_Code_Title',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Title'},{av:'cmbBR_Diagnosis_MetastasesDX'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Title',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXSource_Titleformat',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXSource_Title',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_DIAGNOSIS_DXCODE.ONOPTIONCLICKED","{handler:'E183D2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_DiagnosisIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSISIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_diagnosis_dxcode_Activeeventkey',ctrl:'DDO_BR_DIAGNOSIS_DXCODE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_DIAGNOSIS_DXCODE.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_diagnosis_dxcode_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXCODE',prop:'SortedStatus'},{av:'AV12BR_DiagnosisIDTitleFilterData',fld:'vBR_DIAGNOSISIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV40BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV18BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{av:'AV42BR_Diagnosis_DXType_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPE_CODETITLEFILTERDATA',pic:''},{av:'AV24BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV44BR_Diagnosis_DXTsource_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCE_CODETITLEFILTERDATA',pic:''},{av:'AV26BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV28BR_Diagnosis_InitialDXTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDXTITLEFILTERDATA',pic:''},{av:'AV46BR_Diagnosis_InitialDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDX_CODETITLEFILTERDATA',pic:''},{av:'AV30BR_Diagnosis_MetastasesDXTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDX_CODETITLEFILTERDATA',pic:''},{av:'AV38BR_Diagnosis_DXSourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXSOURCETITLEFILTERDATA',pic:''},{av:'edtBR_DiagnosisID_Titleformat',ctrl:'BR_DIAGNOSISID',prop:'Titleformat'},{av:'edtBR_DiagnosisID_Title',ctrl:'BR_DIAGNOSISID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Diagnosis_No_Titleformat',ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'edtBR_Diagnosis_No_Title',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{av:'edtBR_Diagnosis_DXID_Titleformat',ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXID_Title',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{av:'edtBR_Diagnosis_DXCode_Titleformat',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXCode_Title',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Title',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Code_Title',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Code_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXDescription_Titleformat',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXDescription_Title',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{av:'cmbBR_Diagnosis_InitialDX'},{av:'edtBR_Diagnosis_InitialDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_InitialDX_Code_Title',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Title'},{av:'cmbBR_Diagnosis_MetastasesDX'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Title',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXSource_Titleformat',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXSource_Title',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_DIAGNOSIS_DXTYPE.ONOPTIONCLICKED","{handler:'E193D2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_DiagnosisIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSISIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_diagnosis_dxtype_Activeeventkey',ctrl:'DDO_BR_DIAGNOSIS_DXTYPE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_DIAGNOSIS_DXTYPE.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_diagnosis_dxtype_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXTYPE',prop:'SortedStatus'},{av:'AV12BR_DiagnosisIDTitleFilterData',fld:'vBR_DIAGNOSISIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV40BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV18BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{av:'AV42BR_Diagnosis_DXType_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPE_CODETITLEFILTERDATA',pic:''},{av:'AV24BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV44BR_Diagnosis_DXTsource_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCE_CODETITLEFILTERDATA',pic:''},{av:'AV26BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV28BR_Diagnosis_InitialDXTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDXTITLEFILTERDATA',pic:''},{av:'AV46BR_Diagnosis_InitialDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDX_CODETITLEFILTERDATA',pic:''},{av:'AV30BR_Diagnosis_MetastasesDXTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDX_CODETITLEFILTERDATA',pic:''},{av:'AV38BR_Diagnosis_DXSourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXSOURCETITLEFILTERDATA',pic:''},{av:'edtBR_DiagnosisID_Titleformat',ctrl:'BR_DIAGNOSISID',prop:'Titleformat'},{av:'edtBR_DiagnosisID_Title',ctrl:'BR_DIAGNOSISID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Diagnosis_No_Titleformat',ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'edtBR_Diagnosis_No_Title',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{av:'edtBR_Diagnosis_DXID_Titleformat',ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXID_Title',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{av:'edtBR_Diagnosis_DXCode_Titleformat',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXCode_Title',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Title',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Code_Title',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Code_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXDescription_Titleformat',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXDescription_Title',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{av:'cmbBR_Diagnosis_InitialDX'},{av:'edtBR_Diagnosis_InitialDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_InitialDX_Code_Title',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Title'},{av:'cmbBR_Diagnosis_MetastasesDX'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Title',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXSource_Titleformat',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXSource_Title',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_DIAGNOSIS_DXTYPE_CODE.ONOPTIONCLICKED","{handler:'E203D2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_DiagnosisIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSISIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_diagnosis_dxtype_code_Activeeventkey',ctrl:'DDO_BR_DIAGNOSIS_DXTYPE_CODE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_DIAGNOSIS_DXTYPE_CODE.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_diagnosis_dxtype_code_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXTYPE_CODE',prop:'SortedStatus'},{av:'AV12BR_DiagnosisIDTitleFilterData',fld:'vBR_DIAGNOSISIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV40BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV18BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{av:'AV42BR_Diagnosis_DXType_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPE_CODETITLEFILTERDATA',pic:''},{av:'AV24BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV44BR_Diagnosis_DXTsource_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCE_CODETITLEFILTERDATA',pic:''},{av:'AV26BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV28BR_Diagnosis_InitialDXTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDXTITLEFILTERDATA',pic:''},{av:'AV46BR_Diagnosis_InitialDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDX_CODETITLEFILTERDATA',pic:''},{av:'AV30BR_Diagnosis_MetastasesDXTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDX_CODETITLEFILTERDATA',pic:''},{av:'AV38BR_Diagnosis_DXSourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXSOURCETITLEFILTERDATA',pic:''},{av:'edtBR_DiagnosisID_Titleformat',ctrl:'BR_DIAGNOSISID',prop:'Titleformat'},{av:'edtBR_DiagnosisID_Title',ctrl:'BR_DIAGNOSISID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Diagnosis_No_Titleformat',ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'edtBR_Diagnosis_No_Title',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{av:'edtBR_Diagnosis_DXID_Titleformat',ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXID_Title',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{av:'edtBR_Diagnosis_DXCode_Titleformat',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXCode_Title',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Title',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Code_Title',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Code_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXDescription_Titleformat',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXDescription_Title',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{av:'cmbBR_Diagnosis_InitialDX'},{av:'edtBR_Diagnosis_InitialDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_InitialDX_Code_Title',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Title'},{av:'cmbBR_Diagnosis_MetastasesDX'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Title',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXSource_Titleformat',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXSource_Title',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_DIAGNOSIS_DXTSOURCE.ONOPTIONCLICKED","{handler:'E213D2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_DiagnosisIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSISIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_diagnosis_dxtsource_Activeeventkey',ctrl:'DDO_BR_DIAGNOSIS_DXTSOURCE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_DIAGNOSIS_DXTSOURCE.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_diagnosis_dxtsource_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXTSOURCE',prop:'SortedStatus'},{av:'AV12BR_DiagnosisIDTitleFilterData',fld:'vBR_DIAGNOSISIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV40BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV18BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{av:'AV42BR_Diagnosis_DXType_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPE_CODETITLEFILTERDATA',pic:''},{av:'AV24BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV44BR_Diagnosis_DXTsource_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCE_CODETITLEFILTERDATA',pic:''},{av:'AV26BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV28BR_Diagnosis_InitialDXTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDXTITLEFILTERDATA',pic:''},{av:'AV46BR_Diagnosis_InitialDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDX_CODETITLEFILTERDATA',pic:''},{av:'AV30BR_Diagnosis_MetastasesDXTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDX_CODETITLEFILTERDATA',pic:''},{av:'AV38BR_Diagnosis_DXSourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXSOURCETITLEFILTERDATA',pic:''},{av:'edtBR_DiagnosisID_Titleformat',ctrl:'BR_DIAGNOSISID',prop:'Titleformat'},{av:'edtBR_DiagnosisID_Title',ctrl:'BR_DIAGNOSISID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Diagnosis_No_Titleformat',ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'edtBR_Diagnosis_No_Title',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{av:'edtBR_Diagnosis_DXID_Titleformat',ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXID_Title',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{av:'edtBR_Diagnosis_DXCode_Titleformat',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXCode_Title',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Title',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Code_Title',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Code_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXDescription_Titleformat',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXDescription_Title',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{av:'cmbBR_Diagnosis_InitialDX'},{av:'edtBR_Diagnosis_InitialDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_InitialDX_Code_Title',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Title'},{av:'cmbBR_Diagnosis_MetastasesDX'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Title',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXSource_Titleformat',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXSource_Title',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_DIAGNOSIS_DXTSOURCE_CODE.ONOPTIONCLICKED","{handler:'E223D2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_DiagnosisIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSISIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_diagnosis_dxtsource_code_Activeeventkey',ctrl:'DDO_BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_DIAGNOSIS_DXTSOURCE_CODE.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_diagnosis_dxtsource_code_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'SortedStatus'},{av:'AV12BR_DiagnosisIDTitleFilterData',fld:'vBR_DIAGNOSISIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV40BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV18BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{av:'AV42BR_Diagnosis_DXType_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPE_CODETITLEFILTERDATA',pic:''},{av:'AV24BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV44BR_Diagnosis_DXTsource_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCE_CODETITLEFILTERDATA',pic:''},{av:'AV26BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV28BR_Diagnosis_InitialDXTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDXTITLEFILTERDATA',pic:''},{av:'AV46BR_Diagnosis_InitialDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDX_CODETITLEFILTERDATA',pic:''},{av:'AV30BR_Diagnosis_MetastasesDXTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDX_CODETITLEFILTERDATA',pic:''},{av:'AV38BR_Diagnosis_DXSourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXSOURCETITLEFILTERDATA',pic:''},{av:'edtBR_DiagnosisID_Titleformat',ctrl:'BR_DIAGNOSISID',prop:'Titleformat'},{av:'edtBR_DiagnosisID_Title',ctrl:'BR_DIAGNOSISID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Diagnosis_No_Titleformat',ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'edtBR_Diagnosis_No_Title',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{av:'edtBR_Diagnosis_DXID_Titleformat',ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXID_Title',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{av:'edtBR_Diagnosis_DXCode_Titleformat',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXCode_Title',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Title',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Code_Title',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Code_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXDescription_Titleformat',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXDescription_Title',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{av:'cmbBR_Diagnosis_InitialDX'},{av:'edtBR_Diagnosis_InitialDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_InitialDX_Code_Title',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Title'},{av:'cmbBR_Diagnosis_MetastasesDX'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Title',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXSource_Titleformat',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXSource_Title',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_DIAGNOSIS_DXDESCRIPTION.ONOPTIONCLICKED","{handler:'E233D2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_DiagnosisIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSISIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_diagnosis_dxdescription_Activeeventkey',ctrl:'DDO_BR_DIAGNOSIS_DXDESCRIPTION',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_DIAGNOSIS_DXDESCRIPTION.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_diagnosis_dxdescription_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXDESCRIPTION',prop:'SortedStatus'},{av:'AV12BR_DiagnosisIDTitleFilterData',fld:'vBR_DIAGNOSISIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV40BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV18BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{av:'AV42BR_Diagnosis_DXType_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPE_CODETITLEFILTERDATA',pic:''},{av:'AV24BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV44BR_Diagnosis_DXTsource_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCE_CODETITLEFILTERDATA',pic:''},{av:'AV26BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV28BR_Diagnosis_InitialDXTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDXTITLEFILTERDATA',pic:''},{av:'AV46BR_Diagnosis_InitialDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDX_CODETITLEFILTERDATA',pic:''},{av:'AV30BR_Diagnosis_MetastasesDXTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDX_CODETITLEFILTERDATA',pic:''},{av:'AV38BR_Diagnosis_DXSourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXSOURCETITLEFILTERDATA',pic:''},{av:'edtBR_DiagnosisID_Titleformat',ctrl:'BR_DIAGNOSISID',prop:'Titleformat'},{av:'edtBR_DiagnosisID_Title',ctrl:'BR_DIAGNOSISID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Diagnosis_No_Titleformat',ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'edtBR_Diagnosis_No_Title',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{av:'edtBR_Diagnosis_DXID_Titleformat',ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXID_Title',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{av:'edtBR_Diagnosis_DXCode_Titleformat',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXCode_Title',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Title',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Code_Title',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Code_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXDescription_Titleformat',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXDescription_Title',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{av:'cmbBR_Diagnosis_InitialDX'},{av:'edtBR_Diagnosis_InitialDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_InitialDX_Code_Title',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Title'},{av:'cmbBR_Diagnosis_MetastasesDX'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Title',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXSource_Titleformat',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXSource_Title',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_DIAGNOSIS_INITIALDX.ONOPTIONCLICKED","{handler:'E243D2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_DiagnosisIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSISIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_diagnosis_initialdx_Activeeventkey',ctrl:'DDO_BR_DIAGNOSIS_INITIALDX',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_DIAGNOSIS_INITIALDX.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_diagnosis_initialdx_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_INITIALDX',prop:'SortedStatus'},{av:'AV12BR_DiagnosisIDTitleFilterData',fld:'vBR_DIAGNOSISIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV40BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV18BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{av:'AV42BR_Diagnosis_DXType_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPE_CODETITLEFILTERDATA',pic:''},{av:'AV24BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV44BR_Diagnosis_DXTsource_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCE_CODETITLEFILTERDATA',pic:''},{av:'AV26BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV28BR_Diagnosis_InitialDXTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDXTITLEFILTERDATA',pic:''},{av:'AV46BR_Diagnosis_InitialDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDX_CODETITLEFILTERDATA',pic:''},{av:'AV30BR_Diagnosis_MetastasesDXTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDX_CODETITLEFILTERDATA',pic:''},{av:'AV38BR_Diagnosis_DXSourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXSOURCETITLEFILTERDATA',pic:''},{av:'edtBR_DiagnosisID_Titleformat',ctrl:'BR_DIAGNOSISID',prop:'Titleformat'},{av:'edtBR_DiagnosisID_Title',ctrl:'BR_DIAGNOSISID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Diagnosis_No_Titleformat',ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'edtBR_Diagnosis_No_Title',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{av:'edtBR_Diagnosis_DXID_Titleformat',ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXID_Title',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{av:'edtBR_Diagnosis_DXCode_Titleformat',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXCode_Title',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Title',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Code_Title',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Code_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXDescription_Titleformat',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXDescription_Title',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{av:'cmbBR_Diagnosis_InitialDX'},{av:'edtBR_Diagnosis_InitialDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_InitialDX_Code_Title',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Title'},{av:'cmbBR_Diagnosis_MetastasesDX'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Title',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXSource_Titleformat',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXSource_Title',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_DIAGNOSIS_INITIALDX_CODE.ONOPTIONCLICKED","{handler:'E253D2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_DiagnosisIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSISIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_diagnosis_initialdx_code_Activeeventkey',ctrl:'DDO_BR_DIAGNOSIS_INITIALDX_CODE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_DIAGNOSIS_INITIALDX_CODE.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_diagnosis_initialdx_code_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_INITIALDX_CODE',prop:'SortedStatus'},{av:'AV12BR_DiagnosisIDTitleFilterData',fld:'vBR_DIAGNOSISIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV40BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV18BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{av:'AV42BR_Diagnosis_DXType_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPE_CODETITLEFILTERDATA',pic:''},{av:'AV24BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV44BR_Diagnosis_DXTsource_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCE_CODETITLEFILTERDATA',pic:''},{av:'AV26BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV28BR_Diagnosis_InitialDXTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDXTITLEFILTERDATA',pic:''},{av:'AV46BR_Diagnosis_InitialDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDX_CODETITLEFILTERDATA',pic:''},{av:'AV30BR_Diagnosis_MetastasesDXTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDX_CODETITLEFILTERDATA',pic:''},{av:'AV38BR_Diagnosis_DXSourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXSOURCETITLEFILTERDATA',pic:''},{av:'edtBR_DiagnosisID_Titleformat',ctrl:'BR_DIAGNOSISID',prop:'Titleformat'},{av:'edtBR_DiagnosisID_Title',ctrl:'BR_DIAGNOSISID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Diagnosis_No_Titleformat',ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'edtBR_Diagnosis_No_Title',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{av:'edtBR_Diagnosis_DXID_Titleformat',ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXID_Title',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{av:'edtBR_Diagnosis_DXCode_Titleformat',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXCode_Title',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Title',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Code_Title',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Code_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXDescription_Titleformat',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXDescription_Title',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{av:'cmbBR_Diagnosis_InitialDX'},{av:'edtBR_Diagnosis_InitialDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_InitialDX_Code_Title',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Title'},{av:'cmbBR_Diagnosis_MetastasesDX'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Title',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXSource_Titleformat',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXSource_Title',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_DIAGNOSIS_METASTASESDX.ONOPTIONCLICKED","{handler:'E263D2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_DiagnosisIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSISIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_diagnosis_metastasesdx_Activeeventkey',ctrl:'DDO_BR_DIAGNOSIS_METASTASESDX',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_DIAGNOSIS_METASTASESDX.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_diagnosis_metastasesdx_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_METASTASESDX',prop:'SortedStatus'},{av:'AV12BR_DiagnosisIDTitleFilterData',fld:'vBR_DIAGNOSISIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV40BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV18BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{av:'AV42BR_Diagnosis_DXType_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPE_CODETITLEFILTERDATA',pic:''},{av:'AV24BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV44BR_Diagnosis_DXTsource_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCE_CODETITLEFILTERDATA',pic:''},{av:'AV26BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV28BR_Diagnosis_InitialDXTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDXTITLEFILTERDATA',pic:''},{av:'AV46BR_Diagnosis_InitialDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDX_CODETITLEFILTERDATA',pic:''},{av:'AV30BR_Diagnosis_MetastasesDXTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDX_CODETITLEFILTERDATA',pic:''},{av:'AV38BR_Diagnosis_DXSourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXSOURCETITLEFILTERDATA',pic:''},{av:'edtBR_DiagnosisID_Titleformat',ctrl:'BR_DIAGNOSISID',prop:'Titleformat'},{av:'edtBR_DiagnosisID_Title',ctrl:'BR_DIAGNOSISID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Diagnosis_No_Titleformat',ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'edtBR_Diagnosis_No_Title',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{av:'edtBR_Diagnosis_DXID_Titleformat',ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXID_Title',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{av:'edtBR_Diagnosis_DXCode_Titleformat',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXCode_Title',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Title',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Code_Title',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Code_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXDescription_Titleformat',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXDescription_Title',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{av:'cmbBR_Diagnosis_InitialDX'},{av:'edtBR_Diagnosis_InitialDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_InitialDX_Code_Title',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Title'},{av:'cmbBR_Diagnosis_MetastasesDX'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Title',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXSource_Titleformat',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXSource_Title',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_DIAGNOSIS_METASTASESDX_CODE.ONOPTIONCLICKED","{handler:'E273D2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_DiagnosisIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSISIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_diagnosis_metastasesdx_code_Activeeventkey',ctrl:'DDO_BR_DIAGNOSIS_METASTASESDX_CODE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_DIAGNOSIS_METASTASESDX_CODE.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_diagnosis_metastasesdx_code_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_METASTASESDX_CODE',prop:'SortedStatus'},{av:'AV12BR_DiagnosisIDTitleFilterData',fld:'vBR_DIAGNOSISIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV40BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV18BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{av:'AV42BR_Diagnosis_DXType_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPE_CODETITLEFILTERDATA',pic:''},{av:'AV24BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV44BR_Diagnosis_DXTsource_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCE_CODETITLEFILTERDATA',pic:''},{av:'AV26BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV28BR_Diagnosis_InitialDXTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDXTITLEFILTERDATA',pic:''},{av:'AV46BR_Diagnosis_InitialDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDX_CODETITLEFILTERDATA',pic:''},{av:'AV30BR_Diagnosis_MetastasesDXTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDX_CODETITLEFILTERDATA',pic:''},{av:'AV38BR_Diagnosis_DXSourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXSOURCETITLEFILTERDATA',pic:''},{av:'edtBR_DiagnosisID_Titleformat',ctrl:'BR_DIAGNOSISID',prop:'Titleformat'},{av:'edtBR_DiagnosisID_Title',ctrl:'BR_DIAGNOSISID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Diagnosis_No_Titleformat',ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'edtBR_Diagnosis_No_Title',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{av:'edtBR_Diagnosis_DXID_Titleformat',ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXID_Title',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{av:'edtBR_Diagnosis_DXCode_Titleformat',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXCode_Title',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Title',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Code_Title',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Code_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXDescription_Titleformat',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXDescription_Title',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{av:'cmbBR_Diagnosis_InitialDX'},{av:'edtBR_Diagnosis_InitialDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_InitialDX_Code_Title',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Title'},{av:'cmbBR_Diagnosis_MetastasesDX'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Title',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXSource_Titleformat',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXSource_Title',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_DIAGNOSIS_DXSOURCE.ONOPTIONCLICKED","{handler:'E283D2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_DiagnosisIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSISIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_NOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTYPE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXTSOURCE_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXDESCRIPTIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_INITIALDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_METASTASESDX_CODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace',fld:'vDDO_BR_DIAGNOSIS_DXSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_diagnosis_dxsource_Activeeventkey',ctrl:'DDO_BR_DIAGNOSIS_DXSOURCE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_DIAGNOSIS_DXSOURCE.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_diagnosis_dxsource_Sortedstatus',ctrl:'DDO_BR_DIAGNOSIS_DXSOURCE',prop:'SortedStatus'},{av:'AV12BR_DiagnosisIDTitleFilterData',fld:'vBR_DIAGNOSISIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV40BR_Diagnosis_NoTitleFilterData',fld:'vBR_DIAGNOSIS_NOTITLEFILTERDATA',pic:''},{av:'AV18BR_Diagnosis_DXIDTitleFilterData',fld:'vBR_DIAGNOSIS_DXIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Diagnosis_DXCodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Diagnosis_DXTypeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPETITLEFILTERDATA',pic:''},{av:'AV42BR_Diagnosis_DXType_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTYPE_CODETITLEFILTERDATA',pic:''},{av:'AV24BR_Diagnosis_DXTsourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCETITLEFILTERDATA',pic:''},{av:'AV44BR_Diagnosis_DXTsource_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_DXTSOURCE_CODETITLEFILTERDATA',pic:''},{av:'AV26BR_Diagnosis_DXDescriptionTitleFilterData',fld:'vBR_DIAGNOSIS_DXDESCRIPTIONTITLEFILTERDATA',pic:''},{av:'AV28BR_Diagnosis_InitialDXTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDXTITLEFILTERDATA',pic:''},{av:'AV46BR_Diagnosis_InitialDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_INITIALDX_CODETITLEFILTERDATA',pic:''},{av:'AV30BR_Diagnosis_MetastasesDXTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDXTITLEFILTERDATA',pic:''},{av:'AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData',fld:'vBR_DIAGNOSIS_METASTASESDX_CODETITLEFILTERDATA',pic:''},{av:'AV38BR_Diagnosis_DXSourceTitleFilterData',fld:'vBR_DIAGNOSIS_DXSOURCETITLEFILTERDATA',pic:''},{av:'edtBR_DiagnosisID_Titleformat',ctrl:'BR_DIAGNOSISID',prop:'Titleformat'},{av:'edtBR_DiagnosisID_Title',ctrl:'BR_DIAGNOSISID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Diagnosis_No_Titleformat',ctrl:'BR_DIAGNOSIS_NO',prop:'Titleformat'},{av:'edtBR_Diagnosis_No_Title',ctrl:'BR_DIAGNOSIS_NO',prop:'Title'},{av:'edtBR_Diagnosis_DXID_Titleformat',ctrl:'BR_DIAGNOSIS_DXID',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXID_Title',ctrl:'BR_DIAGNOSIS_DXID',prop:'Title'},{av:'edtBR_Diagnosis_DXCode_Titleformat',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXCode_Title',ctrl:'BR_DIAGNOSIS_DXCODE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Title',ctrl:'BR_DIAGNOSIS_DXTYPE',prop:'Title'},{av:'edtBR_Diagnosis_DXType_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXType_Code_Title',ctrl:'BR_DIAGNOSIS_DXTYPE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE',prop:'Title'},{av:'edtBR_Diagnosis_DXTsource_Code_Titleformat',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXTsource_Code_Title',ctrl:'BR_DIAGNOSIS_DXTSOURCE_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXDescription_Titleformat',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXDescription_Title',ctrl:'BR_DIAGNOSIS_DXDESCRIPTION',prop:'Title'},{av:'cmbBR_Diagnosis_InitialDX'},{av:'edtBR_Diagnosis_InitialDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_InitialDX_Code_Title',ctrl:'BR_DIAGNOSIS_INITIALDX_CODE',prop:'Title'},{av:'cmbBR_Diagnosis_MetastasesDX'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Titleformat',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Titleformat'},{av:'edtBR_Diagnosis_MetastasesDX_Code_Title',ctrl:'BR_DIAGNOSIS_METASTASESDX_CODE',prop:'Title'},{av:'edtBR_Diagnosis_DXSource_Titleformat',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Titleformat'},{av:'edtBR_Diagnosis_DXSource_Title',ctrl:'BR_DIAGNOSIS_DXSOURCE',prop:'Title'},{av:'AV34GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV35GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV36GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E313D2',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV37Select',fld:'vSELECT',pic:''},{av:'edtavSelect_Tooltiptext',ctrl:'vSELECT',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E323D2',iparms:[{av:'A64BR_DiagnosisID',fld:'BR_DIAGNOSISID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV8InOutBR_DiagnosisID',fld:'vINOUTBR_DIAGNOSISID',pic:'ZZZZZZZZZZZZZZZZZZ'}]}");
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
         Ddo_br_diagnosisid_Activeeventkey = "";
         Ddo_br_encounterid_Activeeventkey = "";
         Ddo_br_information_patientno_Activeeventkey = "";
         Ddo_br_diagnosis_no_Activeeventkey = "";
         Ddo_br_diagnosis_dxid_Activeeventkey = "";
         Ddo_br_diagnosis_dxcode_Activeeventkey = "";
         Ddo_br_diagnosis_dxtype_Activeeventkey = "";
         Ddo_br_diagnosis_dxtype_code_Activeeventkey = "";
         Ddo_br_diagnosis_dxtsource_Activeeventkey = "";
         Ddo_br_diagnosis_dxtsource_code_Activeeventkey = "";
         Ddo_br_diagnosis_dxdescription_Activeeventkey = "";
         Ddo_br_diagnosis_initialdx_Activeeventkey = "";
         Ddo_br_diagnosis_initialdx_code_Activeeventkey = "";
         Ddo_br_diagnosis_metastasesdx_Activeeventkey = "";
         Ddo_br_diagnosis_metastasesdx_code_Activeeventkey = "";
         Ddo_br_diagnosis_dxsource_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV13ddo_BR_DiagnosisIDTitleControlIdToReplace = "";
         AV15ddo_BR_EncounterIDTitleControlIdToReplace = "";
         AV17ddo_BR_Information_PatientNoTitleControlIdToReplace = "";
         AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace = "";
         AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace = "";
         AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace = "";
         AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace = "";
         AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace = "";
         AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace = "";
         AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace = "";
         AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace = "";
         AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace = "";
         AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace = "";
         AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace = "";
         AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace = "";
         AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace = "";
         GXKey = "";
         AV52Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV32DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV12BR_DiagnosisIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV14BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV16BR_Information_PatientNoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV40BR_Diagnosis_NoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV18BR_Diagnosis_DXIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_Diagnosis_DXCodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV22BR_Diagnosis_DXTypeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV42BR_Diagnosis_DXType_CodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_Diagnosis_DXTsourceTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV44BR_Diagnosis_DXTsource_CodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV26BR_Diagnosis_DXDescriptionTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28BR_Diagnosis_InitialDXTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV46BR_Diagnosis_InitialDX_CodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV30BR_Diagnosis_MetastasesDXTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV38BR_Diagnosis_DXSourceTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_diagnosisid_Sortedstatus = "";
         Ddo_br_encounterid_Sortedstatus = "";
         Ddo_br_information_patientno_Sortedstatus = "";
         Ddo_br_diagnosis_no_Sortedstatus = "";
         Ddo_br_diagnosis_dxid_Sortedstatus = "";
         Ddo_br_diagnosis_dxcode_Sortedstatus = "";
         Ddo_br_diagnosis_dxtype_Sortedstatus = "";
         Ddo_br_diagnosis_dxtype_code_Sortedstatus = "";
         Ddo_br_diagnosis_dxtsource_Sortedstatus = "";
         Ddo_br_diagnosis_dxtsource_code_Sortedstatus = "";
         Ddo_br_diagnosis_dxdescription_Sortedstatus = "";
         Ddo_br_diagnosis_initialdx_Sortedstatus = "";
         Ddo_br_diagnosis_initialdx_code_Sortedstatus = "";
         Ddo_br_diagnosis_metastasesdx_Sortedstatus = "";
         Ddo_br_diagnosis_metastasesdx_code_Sortedstatus = "";
         Ddo_br_diagnosis_dxsource_Sortedstatus = "";
         GX_FocusControl = "";
         sPrefix = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV37Select = "";
         A36BR_Information_PatientNo = "";
         A65BR_Diagnosis_DXID = "";
         A66BR_Diagnosis_DXCode = "";
         A67BR_Diagnosis_DXType = "";
         A466BR_Diagnosis_DXType_Code = "";
         A68BR_Diagnosis_DXTsource = "";
         A467BR_Diagnosis_DXTsource_Code = "";
         A69BR_Diagnosis_DXDescription = "";
         A70BR_Diagnosis_InitialDX = "";
         A503BR_Diagnosis_InitialDX_Code = "";
         A71BR_Diagnosis_MetastasesDX = "";
         A504BR_Diagnosis_MetastasesDX_Code = "";
         A260BR_Diagnosis_DXSource = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_diagnosisid = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_br_encounterid = new GXUserControl();
         ucDdo_br_information_patientno = new GXUserControl();
         ucDdo_br_diagnosis_no = new GXUserControl();
         ucDdo_br_diagnosis_dxid = new GXUserControl();
         ucDdo_br_diagnosis_dxcode = new GXUserControl();
         ucDdo_br_diagnosis_dxtype = new GXUserControl();
         ucDdo_br_diagnosis_dxtype_code = new GXUserControl();
         ucDdo_br_diagnosis_dxtsource = new GXUserControl();
         ucDdo_br_diagnosis_dxtsource_code = new GXUserControl();
         ucDdo_br_diagnosis_dxdescription = new GXUserControl();
         ucDdo_br_diagnosis_initialdx = new GXUserControl();
         ucDdo_br_diagnosis_initialdx_code = new GXUserControl();
         ucDdo_br_diagnosis_metastasesdx = new GXUserControl();
         ucDdo_br_diagnosis_metastasesdx_code = new GXUserControl();
         ucDdo_br_diagnosis_dxsource = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV53Select_GXI = "";
         scmdbuf = "";
         H003D2_A85BR_Information_ID = new long[1] ;
         H003D2_n85BR_Information_ID = new bool[] {false} ;
         H003D2_A260BR_Diagnosis_DXSource = new String[] {""} ;
         H003D2_n260BR_Diagnosis_DXSource = new bool[] {false} ;
         H003D2_A504BR_Diagnosis_MetastasesDX_Code = new String[] {""} ;
         H003D2_n504BR_Diagnosis_MetastasesDX_Code = new bool[] {false} ;
         H003D2_A71BR_Diagnosis_MetastasesDX = new String[] {""} ;
         H003D2_n71BR_Diagnosis_MetastasesDX = new bool[] {false} ;
         H003D2_A503BR_Diagnosis_InitialDX_Code = new String[] {""} ;
         H003D2_n503BR_Diagnosis_InitialDX_Code = new bool[] {false} ;
         H003D2_A70BR_Diagnosis_InitialDX = new String[] {""} ;
         H003D2_n70BR_Diagnosis_InitialDX = new bool[] {false} ;
         H003D2_A69BR_Diagnosis_DXDescription = new String[] {""} ;
         H003D2_n69BR_Diagnosis_DXDescription = new bool[] {false} ;
         H003D2_A467BR_Diagnosis_DXTsource_Code = new String[] {""} ;
         H003D2_n467BR_Diagnosis_DXTsource_Code = new bool[] {false} ;
         H003D2_A68BR_Diagnosis_DXTsource = new String[] {""} ;
         H003D2_n68BR_Diagnosis_DXTsource = new bool[] {false} ;
         H003D2_A466BR_Diagnosis_DXType_Code = new String[] {""} ;
         H003D2_n466BR_Diagnosis_DXType_Code = new bool[] {false} ;
         H003D2_A67BR_Diagnosis_DXType = new String[] {""} ;
         H003D2_n67BR_Diagnosis_DXType = new bool[] {false} ;
         H003D2_A66BR_Diagnosis_DXCode = new String[] {""} ;
         H003D2_n66BR_Diagnosis_DXCode = new bool[] {false} ;
         H003D2_A65BR_Diagnosis_DXID = new String[] {""} ;
         H003D2_n65BR_Diagnosis_DXID = new bool[] {false} ;
         H003D2_A513BR_Diagnosis_No = new long[1] ;
         H003D2_n513BR_Diagnosis_No = new bool[] {false} ;
         H003D2_A36BR_Information_PatientNo = new String[] {""} ;
         H003D2_n36BR_Information_PatientNo = new bool[] {false} ;
         H003D2_A19BR_EncounterID = new long[1] ;
         H003D2_A64BR_DiagnosisID = new long[1] ;
         H003D3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_diagnosisprompt__default(),
            new Object[][] {
                new Object[] {
               H003D2_A85BR_Information_ID, H003D2_n85BR_Information_ID, H003D2_A260BR_Diagnosis_DXSource, H003D2_n260BR_Diagnosis_DXSource, H003D2_A504BR_Diagnosis_MetastasesDX_Code, H003D2_n504BR_Diagnosis_MetastasesDX_Code, H003D2_A71BR_Diagnosis_MetastasesDX, H003D2_n71BR_Diagnosis_MetastasesDX, H003D2_A503BR_Diagnosis_InitialDX_Code, H003D2_n503BR_Diagnosis_InitialDX_Code,
               H003D2_A70BR_Diagnosis_InitialDX, H003D2_n70BR_Diagnosis_InitialDX, H003D2_A69BR_Diagnosis_DXDescription, H003D2_n69BR_Diagnosis_DXDescription, H003D2_A467BR_Diagnosis_DXTsource_Code, H003D2_n467BR_Diagnosis_DXTsource_Code, H003D2_A68BR_Diagnosis_DXTsource, H003D2_n68BR_Diagnosis_DXTsource, H003D2_A466BR_Diagnosis_DXType_Code, H003D2_n466BR_Diagnosis_DXType_Code,
               H003D2_A67BR_Diagnosis_DXType, H003D2_n67BR_Diagnosis_DXType, H003D2_A66BR_Diagnosis_DXCode, H003D2_n66BR_Diagnosis_DXCode, H003D2_A65BR_Diagnosis_DXID, H003D2_n65BR_Diagnosis_DXID, H003D2_A513BR_Diagnosis_No, H003D2_n513BR_Diagnosis_No, H003D2_A36BR_Information_PatientNo, H003D2_n36BR_Information_PatientNo,
               H003D2_A19BR_EncounterID, H003D2_A64BR_DiagnosisID
               }
               , new Object[] {
               H003D3_AGRID_nRecordCount
               }
            }
         );
         AV52Pgmname = "BR_DiagnosisPrompt";
         /* GeneXus formulas. */
         AV52Pgmname = "BR_DiagnosisPrompt";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_12 ;
      private short nGXsfl_12_idx=1 ;
      private short GRID_nEOF ;
      private short AV10OrderedBy ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtBR_DiagnosisID_Titleformat ;
      private short edtBR_EncounterID_Titleformat ;
      private short edtBR_Information_PatientNo_Titleformat ;
      private short edtBR_Diagnosis_No_Titleformat ;
      private short edtBR_Diagnosis_DXID_Titleformat ;
      private short edtBR_Diagnosis_DXCode_Titleformat ;
      private short edtBR_Diagnosis_DXType_Titleformat ;
      private short edtBR_Diagnosis_DXType_Code_Titleformat ;
      private short edtBR_Diagnosis_DXTsource_Titleformat ;
      private short edtBR_Diagnosis_DXTsource_Code_Titleformat ;
      private short edtBR_Diagnosis_DXDescription_Titleformat ;
      private short cmbBR_Diagnosis_InitialDX_Titleformat ;
      private short edtBR_Diagnosis_InitialDX_Code_Titleformat ;
      private short cmbBR_Diagnosis_MetastasesDX_Titleformat ;
      private short edtBR_Diagnosis_MetastasesDX_Code_Titleformat ;
      private short edtBR_Diagnosis_DXSource_Titleformat ;
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
      private int edtavDdo_br_diagnosisidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_diagnosis_notitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_diagnosis_dxidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_diagnosis_dxcodetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_diagnosis_dxtypetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_diagnosis_dxtype_codetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_diagnosis_dxtsourcetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_diagnosis_dxtsource_codetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_diagnosis_dxdescriptiontitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_diagnosis_initialdxtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_diagnosis_initialdx_codetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_diagnosis_metastasesdxtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_diagnosis_metastasesdx_codetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_diagnosis_dxsourcetitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV33PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavSelect_Enabled ;
      private int edtavSelect_Visible ;
      private long AV8InOutBR_DiagnosisID ;
      private long wcpOAV8InOutBR_DiagnosisID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV34GridCurrentPage ;
      private long AV36GridRecordCount ;
      private long AV35GridPageSize ;
      private long A64BR_DiagnosisID ;
      private long A19BR_EncounterID ;
      private long A513BR_Diagnosis_No ;
      private long GRID_nCurrentRecord ;
      private long A85BR_Information_ID ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_diagnosisid_Activeeventkey ;
      private String Ddo_br_encounterid_Activeeventkey ;
      private String Ddo_br_information_patientno_Activeeventkey ;
      private String Ddo_br_diagnosis_no_Activeeventkey ;
      private String Ddo_br_diagnosis_dxid_Activeeventkey ;
      private String Ddo_br_diagnosis_dxcode_Activeeventkey ;
      private String Ddo_br_diagnosis_dxtype_Activeeventkey ;
      private String Ddo_br_diagnosis_dxtype_code_Activeeventkey ;
      private String Ddo_br_diagnosis_dxtsource_Activeeventkey ;
      private String Ddo_br_diagnosis_dxtsource_code_Activeeventkey ;
      private String Ddo_br_diagnosis_dxdescription_Activeeventkey ;
      private String Ddo_br_diagnosis_initialdx_Activeeventkey ;
      private String Ddo_br_diagnosis_initialdx_code_Activeeventkey ;
      private String Ddo_br_diagnosis_metastasesdx_Activeeventkey ;
      private String Ddo_br_diagnosis_metastasesdx_code_Activeeventkey ;
      private String Ddo_br_diagnosis_dxsource_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_12_idx="0001" ;
      private String GXKey ;
      private String AV52Pgmname ;
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
      private String Ddo_br_diagnosisid_Caption ;
      private String Ddo_br_diagnosisid_Tooltip ;
      private String Ddo_br_diagnosisid_Cls ;
      private String Ddo_br_diagnosisid_Dropdownoptionstype ;
      private String Ddo_br_diagnosisid_Titlecontrolidtoreplace ;
      private String Ddo_br_diagnosisid_Sortedstatus ;
      private String Ddo_br_diagnosisid_Sortasc ;
      private String Ddo_br_diagnosisid_Sortdsc ;
      private String Ddo_br_diagnosisid_Searchbuttontext ;
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
      private String Ddo_br_diagnosis_no_Caption ;
      private String Ddo_br_diagnosis_no_Tooltip ;
      private String Ddo_br_diagnosis_no_Cls ;
      private String Ddo_br_diagnosis_no_Dropdownoptionstype ;
      private String Ddo_br_diagnosis_no_Titlecontrolidtoreplace ;
      private String Ddo_br_diagnosis_no_Sortedstatus ;
      private String Ddo_br_diagnosis_no_Sortasc ;
      private String Ddo_br_diagnosis_no_Sortdsc ;
      private String Ddo_br_diagnosis_no_Searchbuttontext ;
      private String Ddo_br_diagnosis_dxid_Caption ;
      private String Ddo_br_diagnosis_dxid_Tooltip ;
      private String Ddo_br_diagnosis_dxid_Cls ;
      private String Ddo_br_diagnosis_dxid_Dropdownoptionstype ;
      private String Ddo_br_diagnosis_dxid_Titlecontrolidtoreplace ;
      private String Ddo_br_diagnosis_dxid_Sortedstatus ;
      private String Ddo_br_diagnosis_dxid_Sortasc ;
      private String Ddo_br_diagnosis_dxid_Sortdsc ;
      private String Ddo_br_diagnosis_dxid_Searchbuttontext ;
      private String Ddo_br_diagnosis_dxcode_Caption ;
      private String Ddo_br_diagnosis_dxcode_Tooltip ;
      private String Ddo_br_diagnosis_dxcode_Cls ;
      private String Ddo_br_diagnosis_dxcode_Dropdownoptionstype ;
      private String Ddo_br_diagnosis_dxcode_Titlecontrolidtoreplace ;
      private String Ddo_br_diagnosis_dxcode_Sortedstatus ;
      private String Ddo_br_diagnosis_dxcode_Sortasc ;
      private String Ddo_br_diagnosis_dxcode_Sortdsc ;
      private String Ddo_br_diagnosis_dxcode_Searchbuttontext ;
      private String Ddo_br_diagnosis_dxtype_Caption ;
      private String Ddo_br_diagnosis_dxtype_Tooltip ;
      private String Ddo_br_diagnosis_dxtype_Cls ;
      private String Ddo_br_diagnosis_dxtype_Dropdownoptionstype ;
      private String Ddo_br_diagnosis_dxtype_Titlecontrolidtoreplace ;
      private String Ddo_br_diagnosis_dxtype_Sortedstatus ;
      private String Ddo_br_diagnosis_dxtype_Sortasc ;
      private String Ddo_br_diagnosis_dxtype_Sortdsc ;
      private String Ddo_br_diagnosis_dxtype_Searchbuttontext ;
      private String Ddo_br_diagnosis_dxtype_code_Caption ;
      private String Ddo_br_diagnosis_dxtype_code_Tooltip ;
      private String Ddo_br_diagnosis_dxtype_code_Cls ;
      private String Ddo_br_diagnosis_dxtype_code_Dropdownoptionstype ;
      private String Ddo_br_diagnosis_dxtype_code_Titlecontrolidtoreplace ;
      private String Ddo_br_diagnosis_dxtype_code_Sortedstatus ;
      private String Ddo_br_diagnosis_dxtype_code_Sortasc ;
      private String Ddo_br_diagnosis_dxtype_code_Sortdsc ;
      private String Ddo_br_diagnosis_dxtype_code_Searchbuttontext ;
      private String Ddo_br_diagnosis_dxtsource_Caption ;
      private String Ddo_br_diagnosis_dxtsource_Tooltip ;
      private String Ddo_br_diagnosis_dxtsource_Cls ;
      private String Ddo_br_diagnosis_dxtsource_Dropdownoptionstype ;
      private String Ddo_br_diagnosis_dxtsource_Titlecontrolidtoreplace ;
      private String Ddo_br_diagnosis_dxtsource_Sortedstatus ;
      private String Ddo_br_diagnosis_dxtsource_Sortasc ;
      private String Ddo_br_diagnosis_dxtsource_Sortdsc ;
      private String Ddo_br_diagnosis_dxtsource_Searchbuttontext ;
      private String Ddo_br_diagnosis_dxtsource_code_Caption ;
      private String Ddo_br_diagnosis_dxtsource_code_Tooltip ;
      private String Ddo_br_diagnosis_dxtsource_code_Cls ;
      private String Ddo_br_diagnosis_dxtsource_code_Dropdownoptionstype ;
      private String Ddo_br_diagnosis_dxtsource_code_Titlecontrolidtoreplace ;
      private String Ddo_br_diagnosis_dxtsource_code_Sortedstatus ;
      private String Ddo_br_diagnosis_dxtsource_code_Sortasc ;
      private String Ddo_br_diagnosis_dxtsource_code_Sortdsc ;
      private String Ddo_br_diagnosis_dxtsource_code_Searchbuttontext ;
      private String Ddo_br_diagnosis_dxdescription_Caption ;
      private String Ddo_br_diagnosis_dxdescription_Tooltip ;
      private String Ddo_br_diagnosis_dxdescription_Cls ;
      private String Ddo_br_diagnosis_dxdescription_Dropdownoptionstype ;
      private String Ddo_br_diagnosis_dxdescription_Titlecontrolidtoreplace ;
      private String Ddo_br_diagnosis_dxdescription_Sortedstatus ;
      private String Ddo_br_diagnosis_dxdescription_Sortasc ;
      private String Ddo_br_diagnosis_dxdescription_Sortdsc ;
      private String Ddo_br_diagnosis_dxdescription_Searchbuttontext ;
      private String Ddo_br_diagnosis_initialdx_Caption ;
      private String Ddo_br_diagnosis_initialdx_Tooltip ;
      private String Ddo_br_diagnosis_initialdx_Cls ;
      private String Ddo_br_diagnosis_initialdx_Dropdownoptionstype ;
      private String Ddo_br_diagnosis_initialdx_Titlecontrolidtoreplace ;
      private String Ddo_br_diagnosis_initialdx_Sortedstatus ;
      private String Ddo_br_diagnosis_initialdx_Sortasc ;
      private String Ddo_br_diagnosis_initialdx_Sortdsc ;
      private String Ddo_br_diagnosis_initialdx_Searchbuttontext ;
      private String Ddo_br_diagnosis_initialdx_code_Caption ;
      private String Ddo_br_diagnosis_initialdx_code_Tooltip ;
      private String Ddo_br_diagnosis_initialdx_code_Cls ;
      private String Ddo_br_diagnosis_initialdx_code_Dropdownoptionstype ;
      private String Ddo_br_diagnosis_initialdx_code_Titlecontrolidtoreplace ;
      private String Ddo_br_diagnosis_initialdx_code_Sortedstatus ;
      private String Ddo_br_diagnosis_initialdx_code_Sortasc ;
      private String Ddo_br_diagnosis_initialdx_code_Sortdsc ;
      private String Ddo_br_diagnosis_initialdx_code_Searchbuttontext ;
      private String Ddo_br_diagnosis_metastasesdx_Caption ;
      private String Ddo_br_diagnosis_metastasesdx_Tooltip ;
      private String Ddo_br_diagnosis_metastasesdx_Cls ;
      private String Ddo_br_diagnosis_metastasesdx_Dropdownoptionstype ;
      private String Ddo_br_diagnosis_metastasesdx_Titlecontrolidtoreplace ;
      private String Ddo_br_diagnosis_metastasesdx_Sortedstatus ;
      private String Ddo_br_diagnosis_metastasesdx_Sortasc ;
      private String Ddo_br_diagnosis_metastasesdx_Sortdsc ;
      private String Ddo_br_diagnosis_metastasesdx_Searchbuttontext ;
      private String Ddo_br_diagnosis_metastasesdx_code_Caption ;
      private String Ddo_br_diagnosis_metastasesdx_code_Tooltip ;
      private String Ddo_br_diagnosis_metastasesdx_code_Cls ;
      private String Ddo_br_diagnosis_metastasesdx_code_Dropdownoptionstype ;
      private String Ddo_br_diagnosis_metastasesdx_code_Titlecontrolidtoreplace ;
      private String Ddo_br_diagnosis_metastasesdx_code_Sortedstatus ;
      private String Ddo_br_diagnosis_metastasesdx_code_Sortasc ;
      private String Ddo_br_diagnosis_metastasesdx_code_Sortdsc ;
      private String Ddo_br_diagnosis_metastasesdx_code_Searchbuttontext ;
      private String Ddo_br_diagnosis_dxsource_Caption ;
      private String Ddo_br_diagnosis_dxsource_Tooltip ;
      private String Ddo_br_diagnosis_dxsource_Cls ;
      private String Ddo_br_diagnosis_dxsource_Dropdownoptionstype ;
      private String Ddo_br_diagnosis_dxsource_Titlecontrolidtoreplace ;
      private String Ddo_br_diagnosis_dxsource_Sortedstatus ;
      private String Ddo_br_diagnosis_dxsource_Sortasc ;
      private String Ddo_br_diagnosis_dxsource_Sortdsc ;
      private String Ddo_br_diagnosis_dxsource_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtBR_DiagnosisID_Title ;
      private String edtBR_EncounterID_Title ;
      private String edtBR_Information_PatientNo_Title ;
      private String edtBR_Diagnosis_No_Title ;
      private String edtBR_Diagnosis_DXID_Title ;
      private String edtBR_Diagnosis_DXCode_Title ;
      private String edtBR_Diagnosis_DXType_Title ;
      private String edtBR_Diagnosis_DXType_Code_Title ;
      private String edtBR_Diagnosis_DXTsource_Title ;
      private String edtBR_Diagnosis_DXTsource_Code_Title ;
      private String edtBR_Diagnosis_DXDescription_Title ;
      private String edtBR_Diagnosis_InitialDX_Code_Title ;
      private String edtBR_Diagnosis_MetastasesDX_Code_Title ;
      private String edtBR_Diagnosis_DXSource_Title ;
      private String subGrid_Header ;
      private String edtavSelect_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_diagnosisid_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_br_diagnosisidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounterid_Internalname ;
      private String edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_information_patientno_Internalname ;
      private String edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_diagnosis_no_Internalname ;
      private String edtavDdo_br_diagnosis_notitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_diagnosis_dxid_Internalname ;
      private String edtavDdo_br_diagnosis_dxidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_diagnosis_dxcode_Internalname ;
      private String edtavDdo_br_diagnosis_dxcodetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_diagnosis_dxtype_Internalname ;
      private String edtavDdo_br_diagnosis_dxtypetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_diagnosis_dxtype_code_Internalname ;
      private String edtavDdo_br_diagnosis_dxtype_codetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_diagnosis_dxtsource_Internalname ;
      private String edtavDdo_br_diagnosis_dxtsourcetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_diagnosis_dxtsource_code_Internalname ;
      private String edtavDdo_br_diagnosis_dxtsource_codetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_diagnosis_dxdescription_Internalname ;
      private String edtavDdo_br_diagnosis_dxdescriptiontitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_diagnosis_initialdx_Internalname ;
      private String edtavDdo_br_diagnosis_initialdxtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_diagnosis_initialdx_code_Internalname ;
      private String edtavDdo_br_diagnosis_initialdx_codetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_diagnosis_metastasesdx_Internalname ;
      private String edtavDdo_br_diagnosis_metastasesdxtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_diagnosis_metastasesdx_code_Internalname ;
      private String edtavDdo_br_diagnosis_metastasesdx_codetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_diagnosis_dxsource_Internalname ;
      private String edtavDdo_br_diagnosis_dxsourcetitlecontrolidtoreplace_Internalname ;
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
      private String edtBR_DiagnosisID_Internalname ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_Diagnosis_No_Internalname ;
      private String edtBR_Diagnosis_DXID_Internalname ;
      private String edtBR_Diagnosis_DXCode_Internalname ;
      private String edtBR_Diagnosis_DXType_Internalname ;
      private String edtBR_Diagnosis_DXType_Code_Internalname ;
      private String edtBR_Diagnosis_DXTsource_Internalname ;
      private String edtBR_Diagnosis_DXTsource_Code_Internalname ;
      private String edtBR_Diagnosis_DXDescription_Internalname ;
      private String cmbBR_Diagnosis_InitialDX_Internalname ;
      private String edtBR_Diagnosis_InitialDX_Code_Internalname ;
      private String cmbBR_Diagnosis_MetastasesDX_Internalname ;
      private String edtBR_Diagnosis_MetastasesDX_Code_Internalname ;
      private String edtBR_Diagnosis_DXSource_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_12_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavSelect_Jsonclick ;
      private String ROClassString ;
      private String edtBR_DiagnosisID_Jsonclick ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String edtBR_Diagnosis_No_Jsonclick ;
      private String edtBR_Diagnosis_DXID_Jsonclick ;
      private String edtBR_Diagnosis_DXCode_Jsonclick ;
      private String edtBR_Diagnosis_DXType_Jsonclick ;
      private String edtBR_Diagnosis_DXType_Code_Jsonclick ;
      private String edtBR_Diagnosis_DXTsource_Jsonclick ;
      private String edtBR_Diagnosis_DXTsource_Code_Jsonclick ;
      private String edtBR_Diagnosis_DXDescription_Jsonclick ;
      private String GXCCtl ;
      private String cmbBR_Diagnosis_InitialDX_Jsonclick ;
      private String edtBR_Diagnosis_InitialDX_Code_Jsonclick ;
      private String cmbBR_Diagnosis_MetastasesDX_Jsonclick ;
      private String edtBR_Diagnosis_MetastasesDX_Code_Jsonclick ;
      private String edtBR_Diagnosis_DXSource_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV11OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_br_diagnosisid_Includesortasc ;
      private bool Ddo_br_diagnosisid_Includesortdsc ;
      private bool Ddo_br_diagnosisid_Includefilter ;
      private bool Ddo_br_diagnosisid_Includedatalist ;
      private bool Ddo_br_encounterid_Includesortasc ;
      private bool Ddo_br_encounterid_Includesortdsc ;
      private bool Ddo_br_encounterid_Includefilter ;
      private bool Ddo_br_encounterid_Includedatalist ;
      private bool Ddo_br_information_patientno_Includesortasc ;
      private bool Ddo_br_information_patientno_Includesortdsc ;
      private bool Ddo_br_information_patientno_Includefilter ;
      private bool Ddo_br_information_patientno_Includedatalist ;
      private bool Ddo_br_diagnosis_no_Includesortasc ;
      private bool Ddo_br_diagnosis_no_Includesortdsc ;
      private bool Ddo_br_diagnosis_no_Includefilter ;
      private bool Ddo_br_diagnosis_no_Includedatalist ;
      private bool Ddo_br_diagnosis_dxid_Includesortasc ;
      private bool Ddo_br_diagnosis_dxid_Includesortdsc ;
      private bool Ddo_br_diagnosis_dxid_Includefilter ;
      private bool Ddo_br_diagnosis_dxid_Includedatalist ;
      private bool Ddo_br_diagnosis_dxcode_Includesortasc ;
      private bool Ddo_br_diagnosis_dxcode_Includesortdsc ;
      private bool Ddo_br_diagnosis_dxcode_Includefilter ;
      private bool Ddo_br_diagnosis_dxcode_Includedatalist ;
      private bool Ddo_br_diagnosis_dxtype_Includesortasc ;
      private bool Ddo_br_diagnosis_dxtype_Includesortdsc ;
      private bool Ddo_br_diagnosis_dxtype_Includefilter ;
      private bool Ddo_br_diagnosis_dxtype_Includedatalist ;
      private bool Ddo_br_diagnosis_dxtype_code_Includesortasc ;
      private bool Ddo_br_diagnosis_dxtype_code_Includesortdsc ;
      private bool Ddo_br_diagnosis_dxtype_code_Includefilter ;
      private bool Ddo_br_diagnosis_dxtype_code_Includedatalist ;
      private bool Ddo_br_diagnosis_dxtsource_Includesortasc ;
      private bool Ddo_br_diagnosis_dxtsource_Includesortdsc ;
      private bool Ddo_br_diagnosis_dxtsource_Includefilter ;
      private bool Ddo_br_diagnosis_dxtsource_Includedatalist ;
      private bool Ddo_br_diagnosis_dxtsource_code_Includesortasc ;
      private bool Ddo_br_diagnosis_dxtsource_code_Includesortdsc ;
      private bool Ddo_br_diagnosis_dxtsource_code_Includefilter ;
      private bool Ddo_br_diagnosis_dxtsource_code_Includedatalist ;
      private bool Ddo_br_diagnosis_dxdescription_Includesortasc ;
      private bool Ddo_br_diagnosis_dxdescription_Includesortdsc ;
      private bool Ddo_br_diagnosis_dxdescription_Includefilter ;
      private bool Ddo_br_diagnosis_dxdescription_Includedatalist ;
      private bool Ddo_br_diagnosis_initialdx_Includesortasc ;
      private bool Ddo_br_diagnosis_initialdx_Includesortdsc ;
      private bool Ddo_br_diagnosis_initialdx_Includefilter ;
      private bool Ddo_br_diagnosis_initialdx_Includedatalist ;
      private bool Ddo_br_diagnosis_initialdx_code_Includesortasc ;
      private bool Ddo_br_diagnosis_initialdx_code_Includesortdsc ;
      private bool Ddo_br_diagnosis_initialdx_code_Includefilter ;
      private bool Ddo_br_diagnosis_initialdx_code_Includedatalist ;
      private bool Ddo_br_diagnosis_metastasesdx_Includesortasc ;
      private bool Ddo_br_diagnosis_metastasesdx_Includesortdsc ;
      private bool Ddo_br_diagnosis_metastasesdx_Includefilter ;
      private bool Ddo_br_diagnosis_metastasesdx_Includedatalist ;
      private bool Ddo_br_diagnosis_metastasesdx_code_Includesortasc ;
      private bool Ddo_br_diagnosis_metastasesdx_code_Includesortdsc ;
      private bool Ddo_br_diagnosis_metastasesdx_code_Includefilter ;
      private bool Ddo_br_diagnosis_metastasesdx_code_Includedatalist ;
      private bool Ddo_br_diagnosis_dxsource_Includesortasc ;
      private bool Ddo_br_diagnosis_dxsource_Includesortdsc ;
      private bool Ddo_br_diagnosis_dxsource_Includefilter ;
      private bool Ddo_br_diagnosis_dxsource_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_12_Refreshing=false ;
      private bool n36BR_Information_PatientNo ;
      private bool n513BR_Diagnosis_No ;
      private bool n65BR_Diagnosis_DXID ;
      private bool n66BR_Diagnosis_DXCode ;
      private bool n67BR_Diagnosis_DXType ;
      private bool n466BR_Diagnosis_DXType_Code ;
      private bool n68BR_Diagnosis_DXTsource ;
      private bool n467BR_Diagnosis_DXTsource_Code ;
      private bool n69BR_Diagnosis_DXDescription ;
      private bool n70BR_Diagnosis_InitialDX ;
      private bool n503BR_Diagnosis_InitialDX_Code ;
      private bool n71BR_Diagnosis_MetastasesDX ;
      private bool n504BR_Diagnosis_MetastasesDX_Code ;
      private bool n260BR_Diagnosis_DXSource ;
      private bool gxdyncontrolsrefreshing ;
      private bool n85BR_Information_ID ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool gx_refresh_fired ;
      private bool AV37Select_IsBlob ;
      private String AV13ddo_BR_DiagnosisIDTitleControlIdToReplace ;
      private String AV15ddo_BR_EncounterIDTitleControlIdToReplace ;
      private String AV17ddo_BR_Information_PatientNoTitleControlIdToReplace ;
      private String AV41ddo_BR_Diagnosis_NoTitleControlIdToReplace ;
      private String AV19ddo_BR_Diagnosis_DXIDTitleControlIdToReplace ;
      private String AV21ddo_BR_Diagnosis_DXCodeTitleControlIdToReplace ;
      private String AV23ddo_BR_Diagnosis_DXTypeTitleControlIdToReplace ;
      private String AV43ddo_BR_Diagnosis_DXType_CodeTitleControlIdToReplace ;
      private String AV25ddo_BR_Diagnosis_DXTsourceTitleControlIdToReplace ;
      private String AV45ddo_BR_Diagnosis_DXTsource_CodeTitleControlIdToReplace ;
      private String AV27ddo_BR_Diagnosis_DXDescriptionTitleControlIdToReplace ;
      private String AV29ddo_BR_Diagnosis_InitialDXTitleControlIdToReplace ;
      private String AV47ddo_BR_Diagnosis_InitialDX_CodeTitleControlIdToReplace ;
      private String AV31ddo_BR_Diagnosis_MetastasesDXTitleControlIdToReplace ;
      private String AV49ddo_BR_Diagnosis_MetastasesDX_CodeTitleControlIdToReplace ;
      private String AV39ddo_BR_Diagnosis_DXSourceTitleControlIdToReplace ;
      private String A36BR_Information_PatientNo ;
      private String A65BR_Diagnosis_DXID ;
      private String A66BR_Diagnosis_DXCode ;
      private String A67BR_Diagnosis_DXType ;
      private String A466BR_Diagnosis_DXType_Code ;
      private String A68BR_Diagnosis_DXTsource ;
      private String A467BR_Diagnosis_DXTsource_Code ;
      private String A69BR_Diagnosis_DXDescription ;
      private String A70BR_Diagnosis_InitialDX ;
      private String A503BR_Diagnosis_InitialDX_Code ;
      private String A71BR_Diagnosis_MetastasesDX ;
      private String A504BR_Diagnosis_MetastasesDX_Code ;
      private String A260BR_Diagnosis_DXSource ;
      private String AV53Select_GXI ;
      private String AV37Select ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_diagnosisid ;
      private GXUserControl ucDdo_br_encounterid ;
      private GXUserControl ucDdo_br_information_patientno ;
      private GXUserControl ucDdo_br_diagnosis_no ;
      private GXUserControl ucDdo_br_diagnosis_dxid ;
      private GXUserControl ucDdo_br_diagnosis_dxcode ;
      private GXUserControl ucDdo_br_diagnosis_dxtype ;
      private GXUserControl ucDdo_br_diagnosis_dxtype_code ;
      private GXUserControl ucDdo_br_diagnosis_dxtsource ;
      private GXUserControl ucDdo_br_diagnosis_dxtsource_code ;
      private GXUserControl ucDdo_br_diagnosis_dxdescription ;
      private GXUserControl ucDdo_br_diagnosis_initialdx ;
      private GXUserControl ucDdo_br_diagnosis_initialdx_code ;
      private GXUserControl ucDdo_br_diagnosis_metastasesdx ;
      private GXUserControl ucDdo_br_diagnosis_metastasesdx_code ;
      private GXUserControl ucDdo_br_diagnosis_dxsource ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private long aP0_InOutBR_DiagnosisID ;
      private GXCombobox cmbBR_Diagnosis_InitialDX ;
      private GXCombobox cmbBR_Diagnosis_MetastasesDX ;
      private IDataStoreProvider pr_default ;
      private long[] H003D2_A85BR_Information_ID ;
      private bool[] H003D2_n85BR_Information_ID ;
      private String[] H003D2_A260BR_Diagnosis_DXSource ;
      private bool[] H003D2_n260BR_Diagnosis_DXSource ;
      private String[] H003D2_A504BR_Diagnosis_MetastasesDX_Code ;
      private bool[] H003D2_n504BR_Diagnosis_MetastasesDX_Code ;
      private String[] H003D2_A71BR_Diagnosis_MetastasesDX ;
      private bool[] H003D2_n71BR_Diagnosis_MetastasesDX ;
      private String[] H003D2_A503BR_Diagnosis_InitialDX_Code ;
      private bool[] H003D2_n503BR_Diagnosis_InitialDX_Code ;
      private String[] H003D2_A70BR_Diagnosis_InitialDX ;
      private bool[] H003D2_n70BR_Diagnosis_InitialDX ;
      private String[] H003D2_A69BR_Diagnosis_DXDescription ;
      private bool[] H003D2_n69BR_Diagnosis_DXDescription ;
      private String[] H003D2_A467BR_Diagnosis_DXTsource_Code ;
      private bool[] H003D2_n467BR_Diagnosis_DXTsource_Code ;
      private String[] H003D2_A68BR_Diagnosis_DXTsource ;
      private bool[] H003D2_n68BR_Diagnosis_DXTsource ;
      private String[] H003D2_A466BR_Diagnosis_DXType_Code ;
      private bool[] H003D2_n466BR_Diagnosis_DXType_Code ;
      private String[] H003D2_A67BR_Diagnosis_DXType ;
      private bool[] H003D2_n67BR_Diagnosis_DXType ;
      private String[] H003D2_A66BR_Diagnosis_DXCode ;
      private bool[] H003D2_n66BR_Diagnosis_DXCode ;
      private String[] H003D2_A65BR_Diagnosis_DXID ;
      private bool[] H003D2_n65BR_Diagnosis_DXID ;
      private long[] H003D2_A513BR_Diagnosis_No ;
      private bool[] H003D2_n513BR_Diagnosis_No ;
      private String[] H003D2_A36BR_Information_PatientNo ;
      private bool[] H003D2_n36BR_Information_PatientNo ;
      private long[] H003D2_A19BR_EncounterID ;
      private long[] H003D2_A64BR_DiagnosisID ;
      private long[] H003D3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV12BR_DiagnosisIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV14BR_EncounterIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV16BR_Information_PatientNoTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV40BR_Diagnosis_NoTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV18BR_Diagnosis_DXIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV20BR_Diagnosis_DXCodeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV22BR_Diagnosis_DXTypeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV42BR_Diagnosis_DXType_CodeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV24BR_Diagnosis_DXTsourceTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV44BR_Diagnosis_DXTsource_CodeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV26BR_Diagnosis_DXDescriptionTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV28BR_Diagnosis_InitialDXTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV46BR_Diagnosis_InitialDX_CodeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV30BR_Diagnosis_MetastasesDXTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV48BR_Diagnosis_MetastasesDX_CodeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV38BR_Diagnosis_DXSourceTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV32DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class br_diagnosisprompt__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H003D2( IGxContext context ,
                                             short AV10OrderedBy ,
                                             bool AV11OrderedDsc )
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
         sSelectString = " T2.[BR_Information_ID], T1.[BR_Diagnosis_DXSource], T1.[BR_Diagnosis_MetastasesDX_Code], T1.[BR_Diagnosis_MetastasesDX], T1.[BR_Diagnosis_InitialDX_Code], T1.[BR_Diagnosis_InitialDX], T1.[BR_Diagnosis_DXDescription], T1.[BR_Diagnosis_DXTsource_Code], T1.[BR_Diagnosis_DXTsource], T1.[BR_Diagnosis_DXType_Code], T1.[BR_Diagnosis_DXType], T1.[BR_Diagnosis_DXCode], T1.[BR_Diagnosis_DXID], T1.[BR_Diagnosis_No], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_DiagnosisID]";
         sFromString = " FROM (([BR_Diagnosis] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         sOrderString = "";
         if ( ( AV10OrderedBy == 1 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_DiagnosisID]";
         }
         else if ( ( AV10OrderedBy == 1 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_DiagnosisID] DESC";
         }
         else if ( ( AV10OrderedBy == 2 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_EncounterID]";
         }
         else if ( ( AV10OrderedBy == 2 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_EncounterID] DESC";
         }
         else if ( ( AV10OrderedBy == 3 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T3.[BR_Information_PatientNo]";
         }
         else if ( ( AV10OrderedBy == 3 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T3.[BR_Information_PatientNo] DESC";
         }
         else if ( ( AV10OrderedBy == 4 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Diagnosis_No]";
         }
         else if ( ( AV10OrderedBy == 4 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Diagnosis_No] DESC";
         }
         else if ( ( AV10OrderedBy == 5 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Diagnosis_DXID]";
         }
         else if ( ( AV10OrderedBy == 5 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Diagnosis_DXID] DESC";
         }
         else if ( ( AV10OrderedBy == 6 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Diagnosis_DXCode]";
         }
         else if ( ( AV10OrderedBy == 6 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Diagnosis_DXCode] DESC";
         }
         else if ( ( AV10OrderedBy == 7 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Diagnosis_DXType]";
         }
         else if ( ( AV10OrderedBy == 7 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Diagnosis_DXType] DESC";
         }
         else if ( ( AV10OrderedBy == 8 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Diagnosis_DXType_Code]";
         }
         else if ( ( AV10OrderedBy == 8 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Diagnosis_DXType_Code] DESC";
         }
         else if ( ( AV10OrderedBy == 9 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Diagnosis_DXTsource]";
         }
         else if ( ( AV10OrderedBy == 9 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Diagnosis_DXTsource] DESC";
         }
         else if ( ( AV10OrderedBy == 10 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Diagnosis_DXTsource_Code]";
         }
         else if ( ( AV10OrderedBy == 10 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Diagnosis_DXTsource_Code] DESC";
         }
         else if ( ( AV10OrderedBy == 11 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Diagnosis_DXDescription]";
         }
         else if ( ( AV10OrderedBy == 11 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Diagnosis_DXDescription] DESC";
         }
         else if ( ( AV10OrderedBy == 12 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Diagnosis_InitialDX]";
         }
         else if ( ( AV10OrderedBy == 12 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Diagnosis_InitialDX] DESC";
         }
         else if ( ( AV10OrderedBy == 13 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Diagnosis_InitialDX_Code]";
         }
         else if ( ( AV10OrderedBy == 13 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Diagnosis_InitialDX_Code] DESC";
         }
         else if ( ( AV10OrderedBy == 14 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Diagnosis_MetastasesDX]";
         }
         else if ( ( AV10OrderedBy == 14 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Diagnosis_MetastasesDX] DESC";
         }
         else if ( ( AV10OrderedBy == 15 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Diagnosis_MetastasesDX_Code]";
         }
         else if ( ( AV10OrderedBy == 15 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Diagnosis_MetastasesDX_Code] DESC";
         }
         else if ( ( AV10OrderedBy == 16 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Diagnosis_DXSource]";
         }
         else if ( ( AV10OrderedBy == 16 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Diagnosis_DXSource] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_DiagnosisID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H003D3( IGxContext context ,
                                             short AV10OrderedBy ,
                                             bool AV11OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM (([BR_Diagnosis] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ( AV10OrderedBy == 1 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 1 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 2 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 2 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 3 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 3 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 4 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 4 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 5 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 5 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 6 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 6 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 7 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 7 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 8 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 8 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 9 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 9 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 10 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 10 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 11 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 11 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 12 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 12 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 13 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 13 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 14 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 14 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 15 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 15 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 16 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 16 ) && ( AV11OrderedDsc ) )
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
                     return conditional_H003D2(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
               case 1 :
                     return conditional_H003D3(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
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
          Object[] prmH003D2 ;
          prmH003D2 = new Object[] {
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH003D3 ;
          prmH003D3 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H003D2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003D2,11,0,true,false )
             ,new CursorDef("H003D3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003D3,1,0,true,false )
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
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
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
                ((String[]) buf[22])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(12);
                ((String[]) buf[24])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(13);
                ((long[]) buf[26])[0] = rslt.getLong(14) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(14);
                ((String[]) buf[28])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(15);
                ((long[]) buf[30])[0] = rslt.getLong(16) ;
                ((long[]) buf[31])[0] = rslt.getLong(17) ;
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
