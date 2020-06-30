/*
               File: BR_LabPrompt
        Description: 选择实验室检查
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 12:0:31.90
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
   public class br_labprompt : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public br_labprompt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_labprompt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_InOutBR_LabID )
      {
         this.AV8InOutBR_LabID = aP0_InOutBR_LabID;
         executePrivate();
         aP0_InOutBR_LabID=this.AV8InOutBR_LabID;
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
               AV10OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV11OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV13ddo_BR_LabIDTitleControlIdToReplace = GetNextPar( );
               AV15ddo_BR_EncounterIDTitleControlIdToReplace = GetNextPar( );
               AV17ddo_BR_Information_PatientNoTitleControlIdToReplace = GetNextPar( );
               AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace = GetNextPar( );
               AV19ddo_BR_Lab_TestIDTitleControlIdToReplace = GetNextPar( );
               AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace = GetNextPar( );
               AV23ddo_BR_Lab_TestNameTitleControlIdToReplace = GetNextPar( );
               AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace = GetNextPar( );
               AV63ddo_BR_Lab_AgeTitleControlIdToReplace = GetNextPar( );
               AV65ddo_BR_Lab_DiagTitleControlIdToReplace = GetNextPar( );
               AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace = GetNextPar( );
               AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace = GetNextPar( );
               AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace = GetNextPar( );
               AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace = GetNextPar( );
               AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace = GetNextPar( );
               AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace = GetNextPar( );
               AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace = GetNextPar( );
               AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace = GetNextPar( );
               AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace = GetNextPar( );
               AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace = GetNextPar( );
               AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace = GetNextPar( );
               AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace = GetNextPar( );
               AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_LabIDTitleControlIdToReplace, AV15ddo_BR_EncounterIDTitleControlIdToReplace, AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace, AV19ddo_BR_Lab_TestIDTitleControlIdToReplace, AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace, AV23ddo_BR_Lab_TestNameTitleControlIdToReplace, AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace, AV63ddo_BR_Lab_AgeTitleControlIdToReplace, AV65ddo_BR_Lab_DiagTitleControlIdToReplace, AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace, AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace, AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace, AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace, AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace, AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace, AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace, AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace, AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace, AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace, AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace, AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace, AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace) ;
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
               AV8InOutBR_LabID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_LabID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_LabID), 18, 0)));
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
            PA3H2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV72Pgmname = "BR_LabPrompt";
               context.Gx_err = 0;
               WS3H2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE3H2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202271203247", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_labprompt.aspx") + "?" + UrlEncode("" +AV8InOutBR_LabID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV54GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV56GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV55GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV52DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV52DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_LABIDTITLEFILTERDATA", AV12BR_LabIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_LABIDTITLEFILTERDATA", AV12BR_LabIDTitleFilterData);
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_LAB_SAMPLEIDTITLEFILTERDATA", AV58BR_Lab_SampleIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_LAB_SAMPLEIDTITLEFILTERDATA", AV58BR_Lab_SampleIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_LAB_TESTIDTITLEFILTERDATA", AV18BR_Lab_TestIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_LAB_TESTIDTITLEFILTERDATA", AV18BR_Lab_TestIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_LAB_TESTCODETITLEFILTERDATA", AV20BR_Lab_TestCodeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_LAB_TESTCODETITLEFILTERDATA", AV20BR_Lab_TestCodeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_LAB_TESTNAMETITLEFILTERDATA", AV22BR_Lab_TestNameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_LAB_TESTNAMETITLEFILTERDATA", AV22BR_Lab_TestNameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_LAB_TESTENGNAMETITLEFILTERDATA", AV60BR_Lab_TestEngNameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_LAB_TESTENGNAMETITLEFILTERDATA", AV60BR_Lab_TestEngNameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_LAB_AGETITLEFILTERDATA", AV62BR_Lab_AgeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_LAB_AGETITLEFILTERDATA", AV62BR_Lab_AgeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_LAB_DIAGTITLEFILTERDATA", AV64BR_Lab_DiagTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_LAB_DIAGTITLEFILTERDATA", AV64BR_Lab_DiagTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_LAB_SPECIMENDATETITLEFILTERDATA", AV24BR_Lab_SpecimenDateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_LAB_SPECIMENDATETITLEFILTERDATA", AV24BR_Lab_SpecimenDateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_LAB_RECEIVINGTIMETITLEFILTERDATA", AV66BR_Lab_ReceivingTimeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_LAB_RECEIVINGTIMETITLEFILTERDATA", AV66BR_Lab_ReceivingTimeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_LAB_REPORTTIMETITLEFILTERDATA", AV68BR_Lab_ReportTimeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_LAB_REPORTTIMETITLEFILTERDATA", AV68BR_Lab_ReportTimeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_LAB_SPECIMENSOURCETITLEFILTERDATA", AV26BR_Lab_SpecimenSourceTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_LAB_SPECIMENSOURCETITLEFILTERDATA", AV26BR_Lab_SpecimenSourceTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_LAB_RESULTQUALTITLEFILTERDATA", AV32BR_Lab_ResultQualTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_LAB_RESULTQUALTITLEFILTERDATA", AV32BR_Lab_ResultQualTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_LAB_RESULTNUMTITLEFILTERDATA", AV34BR_Lab_ResultNumTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_LAB_RESULTNUMTITLEFILTERDATA", AV34BR_Lab_ResultNumTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_LAB_RESULTUNITTITLEFILTERDATA", AV36BR_Lab_ResultUnitTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_LAB_RESULTUNITTITLEFILTERDATA", AV36BR_Lab_ResultUnitTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_LAB_ABNINDTITLEFILTERDATA", AV38BR_Lab_AbnIndTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_LAB_ABNINDTITLEFILTERDATA", AV38BR_Lab_AbnIndTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_LAB_NORMRANGELOWTITLEFILTERDATA", AV40BR_Lab_NormRangeLowTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_LAB_NORMRANGELOWTITLEFILTERDATA", AV40BR_Lab_NormRangeLowTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_LAB_NORMRANGEHIGHTITLEFILTERDATA", AV42BR_Lab_NormRangeHighTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_LAB_NORMRANGEHIGHTITLEFILTERDATA", AV42BR_Lab_NormRangeHighTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_LAB_TESTMETHODTITLEFILTERDATA", AV44BR_Lab_TestMethodTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_LAB_TESTMETHODTITLEFILTERDATA", AV44BR_Lab_TestMethodTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_LAB_INSTRUMENTNAMETITLEFILTERDATA", AV48BR_Lab_InstrumentNameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_LAB_INSTRUMENTNAMETITLEFILTERDATA", AV48BR_Lab_InstrumentNameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_LAB_INSTRUMENTCODETITLEFILTERDATA", AV50BR_Lab_InstrumentCodeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_LAB_INSTRUMENTCODETITLEFILTERDATA", AV50BR_Lab_InstrumentCodeTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vINOUTBR_LABID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8InOutBR_LabID), 18, 0, ".", "")));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_LABID_Caption", StringUtil.RTrim( Ddo_br_labid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LABID_Tooltip", StringUtil.RTrim( Ddo_br_labid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LABID_Cls", StringUtil.RTrim( Ddo_br_labid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LABID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_labid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LABID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_labid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LABID_Includesortasc", StringUtil.BoolToStr( Ddo_br_labid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LABID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_labid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LABID_Sortedstatus", StringUtil.RTrim( Ddo_br_labid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LABID_Includefilter", StringUtil.BoolToStr( Ddo_br_labid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LABID_Includedatalist", StringUtil.BoolToStr( Ddo_br_labid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LABID_Sortasc", StringUtil.RTrim( Ddo_br_labid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LABID_Sortdsc", StringUtil.RTrim( Ddo_br_labid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LABID_Searchbuttontext", StringUtil.RTrim( Ddo_br_labid_Searchbuttontext));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SAMPLEID_Caption", StringUtil.RTrim( Ddo_br_lab_sampleid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SAMPLEID_Tooltip", StringUtil.RTrim( Ddo_br_lab_sampleid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SAMPLEID_Cls", StringUtil.RTrim( Ddo_br_lab_sampleid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SAMPLEID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_lab_sampleid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SAMPLEID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_lab_sampleid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SAMPLEID_Includesortasc", StringUtil.BoolToStr( Ddo_br_lab_sampleid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SAMPLEID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_lab_sampleid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SAMPLEID_Sortedstatus", StringUtil.RTrim( Ddo_br_lab_sampleid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SAMPLEID_Includefilter", StringUtil.BoolToStr( Ddo_br_lab_sampleid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SAMPLEID_Includedatalist", StringUtil.BoolToStr( Ddo_br_lab_sampleid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SAMPLEID_Sortasc", StringUtil.RTrim( Ddo_br_lab_sampleid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SAMPLEID_Sortdsc", StringUtil.RTrim( Ddo_br_lab_sampleid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SAMPLEID_Searchbuttontext", StringUtil.RTrim( Ddo_br_lab_sampleid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTID_Caption", StringUtil.RTrim( Ddo_br_lab_testid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTID_Tooltip", StringUtil.RTrim( Ddo_br_lab_testid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTID_Cls", StringUtil.RTrim( Ddo_br_lab_testid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_lab_testid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_lab_testid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTID_Includesortasc", StringUtil.BoolToStr( Ddo_br_lab_testid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_lab_testid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTID_Sortedstatus", StringUtil.RTrim( Ddo_br_lab_testid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTID_Includefilter", StringUtil.BoolToStr( Ddo_br_lab_testid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTID_Includedatalist", StringUtil.BoolToStr( Ddo_br_lab_testid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTID_Sortasc", StringUtil.RTrim( Ddo_br_lab_testid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTID_Sortdsc", StringUtil.RTrim( Ddo_br_lab_testid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTID_Searchbuttontext", StringUtil.RTrim( Ddo_br_lab_testid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTCODE_Caption", StringUtil.RTrim( Ddo_br_lab_testcode_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTCODE_Tooltip", StringUtil.RTrim( Ddo_br_lab_testcode_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTCODE_Cls", StringUtil.RTrim( Ddo_br_lab_testcode_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTCODE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_lab_testcode_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTCODE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_lab_testcode_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTCODE_Includesortasc", StringUtil.BoolToStr( Ddo_br_lab_testcode_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTCODE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_lab_testcode_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTCODE_Sortedstatus", StringUtil.RTrim( Ddo_br_lab_testcode_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTCODE_Includefilter", StringUtil.BoolToStr( Ddo_br_lab_testcode_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTCODE_Includedatalist", StringUtil.BoolToStr( Ddo_br_lab_testcode_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTCODE_Sortasc", StringUtil.RTrim( Ddo_br_lab_testcode_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTCODE_Sortdsc", StringUtil.RTrim( Ddo_br_lab_testcode_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTCODE_Searchbuttontext", StringUtil.RTrim( Ddo_br_lab_testcode_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTNAME_Caption", StringUtil.RTrim( Ddo_br_lab_testname_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTNAME_Tooltip", StringUtil.RTrim( Ddo_br_lab_testname_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTNAME_Cls", StringUtil.RTrim( Ddo_br_lab_testname_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTNAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_lab_testname_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTNAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_lab_testname_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTNAME_Includesortasc", StringUtil.BoolToStr( Ddo_br_lab_testname_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTNAME_Includesortdsc", StringUtil.BoolToStr( Ddo_br_lab_testname_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTNAME_Sortedstatus", StringUtil.RTrim( Ddo_br_lab_testname_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTNAME_Includefilter", StringUtil.BoolToStr( Ddo_br_lab_testname_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTNAME_Includedatalist", StringUtil.BoolToStr( Ddo_br_lab_testname_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTNAME_Sortasc", StringUtil.RTrim( Ddo_br_lab_testname_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTNAME_Sortdsc", StringUtil.RTrim( Ddo_br_lab_testname_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTNAME_Searchbuttontext", StringUtil.RTrim( Ddo_br_lab_testname_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTENGNAME_Caption", StringUtil.RTrim( Ddo_br_lab_testengname_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTENGNAME_Tooltip", StringUtil.RTrim( Ddo_br_lab_testengname_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTENGNAME_Cls", StringUtil.RTrim( Ddo_br_lab_testengname_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTENGNAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_lab_testengname_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTENGNAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_lab_testengname_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTENGNAME_Includesortasc", StringUtil.BoolToStr( Ddo_br_lab_testengname_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTENGNAME_Includesortdsc", StringUtil.BoolToStr( Ddo_br_lab_testengname_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTENGNAME_Sortedstatus", StringUtil.RTrim( Ddo_br_lab_testengname_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTENGNAME_Includefilter", StringUtil.BoolToStr( Ddo_br_lab_testengname_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTENGNAME_Includedatalist", StringUtil.BoolToStr( Ddo_br_lab_testengname_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTENGNAME_Sortasc", StringUtil.RTrim( Ddo_br_lab_testengname_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTENGNAME_Sortdsc", StringUtil.RTrim( Ddo_br_lab_testengname_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTENGNAME_Searchbuttontext", StringUtil.RTrim( Ddo_br_lab_testengname_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_AGE_Caption", StringUtil.RTrim( Ddo_br_lab_age_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_AGE_Tooltip", StringUtil.RTrim( Ddo_br_lab_age_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_AGE_Cls", StringUtil.RTrim( Ddo_br_lab_age_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_AGE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_lab_age_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_AGE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_lab_age_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_AGE_Includesortasc", StringUtil.BoolToStr( Ddo_br_lab_age_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_AGE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_lab_age_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_AGE_Sortedstatus", StringUtil.RTrim( Ddo_br_lab_age_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_AGE_Includefilter", StringUtil.BoolToStr( Ddo_br_lab_age_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_AGE_Includedatalist", StringUtil.BoolToStr( Ddo_br_lab_age_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_AGE_Sortasc", StringUtil.RTrim( Ddo_br_lab_age_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_AGE_Sortdsc", StringUtil.RTrim( Ddo_br_lab_age_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_AGE_Searchbuttontext", StringUtil.RTrim( Ddo_br_lab_age_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_DIAG_Caption", StringUtil.RTrim( Ddo_br_lab_diag_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_DIAG_Tooltip", StringUtil.RTrim( Ddo_br_lab_diag_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_DIAG_Cls", StringUtil.RTrim( Ddo_br_lab_diag_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_DIAG_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_lab_diag_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_DIAG_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_lab_diag_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_DIAG_Includesortasc", StringUtil.BoolToStr( Ddo_br_lab_diag_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_DIAG_Includesortdsc", StringUtil.BoolToStr( Ddo_br_lab_diag_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_DIAG_Sortedstatus", StringUtil.RTrim( Ddo_br_lab_diag_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_DIAG_Includefilter", StringUtil.BoolToStr( Ddo_br_lab_diag_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_DIAG_Includedatalist", StringUtil.BoolToStr( Ddo_br_lab_diag_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_DIAG_Sortasc", StringUtil.RTrim( Ddo_br_lab_diag_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_DIAG_Sortdsc", StringUtil.RTrim( Ddo_br_lab_diag_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_DIAG_Searchbuttontext", StringUtil.RTrim( Ddo_br_lab_diag_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SPECIMENDATE_Caption", StringUtil.RTrim( Ddo_br_lab_specimendate_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SPECIMENDATE_Tooltip", StringUtil.RTrim( Ddo_br_lab_specimendate_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SPECIMENDATE_Cls", StringUtil.RTrim( Ddo_br_lab_specimendate_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SPECIMENDATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_lab_specimendate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SPECIMENDATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_lab_specimendate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SPECIMENDATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_lab_specimendate_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SPECIMENDATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_lab_specimendate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SPECIMENDATE_Sortedstatus", StringUtil.RTrim( Ddo_br_lab_specimendate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SPECIMENDATE_Includefilter", StringUtil.BoolToStr( Ddo_br_lab_specimendate_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SPECIMENDATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_lab_specimendate_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SPECIMENDATE_Sortasc", StringUtil.RTrim( Ddo_br_lab_specimendate_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SPECIMENDATE_Sortdsc", StringUtil.RTrim( Ddo_br_lab_specimendate_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SPECIMENDATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_lab_specimendate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RECEIVINGTIME_Caption", StringUtil.RTrim( Ddo_br_lab_receivingtime_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RECEIVINGTIME_Tooltip", StringUtil.RTrim( Ddo_br_lab_receivingtime_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RECEIVINGTIME_Cls", StringUtil.RTrim( Ddo_br_lab_receivingtime_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RECEIVINGTIME_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_lab_receivingtime_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RECEIVINGTIME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_lab_receivingtime_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RECEIVINGTIME_Includesortasc", StringUtil.BoolToStr( Ddo_br_lab_receivingtime_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RECEIVINGTIME_Includesortdsc", StringUtil.BoolToStr( Ddo_br_lab_receivingtime_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RECEIVINGTIME_Sortedstatus", StringUtil.RTrim( Ddo_br_lab_receivingtime_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RECEIVINGTIME_Includefilter", StringUtil.BoolToStr( Ddo_br_lab_receivingtime_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RECEIVINGTIME_Includedatalist", StringUtil.BoolToStr( Ddo_br_lab_receivingtime_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RECEIVINGTIME_Sortasc", StringUtil.RTrim( Ddo_br_lab_receivingtime_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RECEIVINGTIME_Sortdsc", StringUtil.RTrim( Ddo_br_lab_receivingtime_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RECEIVINGTIME_Searchbuttontext", StringUtil.RTrim( Ddo_br_lab_receivingtime_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_REPORTTIME_Caption", StringUtil.RTrim( Ddo_br_lab_reporttime_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_REPORTTIME_Tooltip", StringUtil.RTrim( Ddo_br_lab_reporttime_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_REPORTTIME_Cls", StringUtil.RTrim( Ddo_br_lab_reporttime_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_REPORTTIME_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_lab_reporttime_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_REPORTTIME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_lab_reporttime_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_REPORTTIME_Includesortasc", StringUtil.BoolToStr( Ddo_br_lab_reporttime_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_REPORTTIME_Includesortdsc", StringUtil.BoolToStr( Ddo_br_lab_reporttime_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_REPORTTIME_Sortedstatus", StringUtil.RTrim( Ddo_br_lab_reporttime_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_REPORTTIME_Includefilter", StringUtil.BoolToStr( Ddo_br_lab_reporttime_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_REPORTTIME_Includedatalist", StringUtil.BoolToStr( Ddo_br_lab_reporttime_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_REPORTTIME_Sortasc", StringUtil.RTrim( Ddo_br_lab_reporttime_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_REPORTTIME_Sortdsc", StringUtil.RTrim( Ddo_br_lab_reporttime_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_REPORTTIME_Searchbuttontext", StringUtil.RTrim( Ddo_br_lab_reporttime_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SPECIMENSOURCE_Caption", StringUtil.RTrim( Ddo_br_lab_specimensource_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SPECIMENSOURCE_Tooltip", StringUtil.RTrim( Ddo_br_lab_specimensource_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SPECIMENSOURCE_Cls", StringUtil.RTrim( Ddo_br_lab_specimensource_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SPECIMENSOURCE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_lab_specimensource_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SPECIMENSOURCE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_lab_specimensource_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SPECIMENSOURCE_Includesortasc", StringUtil.BoolToStr( Ddo_br_lab_specimensource_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SPECIMENSOURCE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_lab_specimensource_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SPECIMENSOURCE_Sortedstatus", StringUtil.RTrim( Ddo_br_lab_specimensource_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SPECIMENSOURCE_Includefilter", StringUtil.BoolToStr( Ddo_br_lab_specimensource_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SPECIMENSOURCE_Includedatalist", StringUtil.BoolToStr( Ddo_br_lab_specimensource_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SPECIMENSOURCE_Sortasc", StringUtil.RTrim( Ddo_br_lab_specimensource_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SPECIMENSOURCE_Sortdsc", StringUtil.RTrim( Ddo_br_lab_specimensource_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SPECIMENSOURCE_Searchbuttontext", StringUtil.RTrim( Ddo_br_lab_specimensource_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTQUAL_Caption", StringUtil.RTrim( Ddo_br_lab_resultqual_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTQUAL_Tooltip", StringUtil.RTrim( Ddo_br_lab_resultqual_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTQUAL_Cls", StringUtil.RTrim( Ddo_br_lab_resultqual_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTQUAL_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_lab_resultqual_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTQUAL_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_lab_resultqual_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTQUAL_Includesortasc", StringUtil.BoolToStr( Ddo_br_lab_resultqual_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTQUAL_Includesortdsc", StringUtil.BoolToStr( Ddo_br_lab_resultqual_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTQUAL_Sortedstatus", StringUtil.RTrim( Ddo_br_lab_resultqual_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTQUAL_Includefilter", StringUtil.BoolToStr( Ddo_br_lab_resultqual_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTQUAL_Includedatalist", StringUtil.BoolToStr( Ddo_br_lab_resultqual_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTQUAL_Sortasc", StringUtil.RTrim( Ddo_br_lab_resultqual_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTQUAL_Sortdsc", StringUtil.RTrim( Ddo_br_lab_resultqual_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTQUAL_Searchbuttontext", StringUtil.RTrim( Ddo_br_lab_resultqual_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTNUM_Caption", StringUtil.RTrim( Ddo_br_lab_resultnum_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTNUM_Tooltip", StringUtil.RTrim( Ddo_br_lab_resultnum_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTNUM_Cls", StringUtil.RTrim( Ddo_br_lab_resultnum_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTNUM_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_lab_resultnum_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTNUM_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_lab_resultnum_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTNUM_Includesortasc", StringUtil.BoolToStr( Ddo_br_lab_resultnum_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTNUM_Includesortdsc", StringUtil.BoolToStr( Ddo_br_lab_resultnum_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTNUM_Sortedstatus", StringUtil.RTrim( Ddo_br_lab_resultnum_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTNUM_Includefilter", StringUtil.BoolToStr( Ddo_br_lab_resultnum_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTNUM_Includedatalist", StringUtil.BoolToStr( Ddo_br_lab_resultnum_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTNUM_Sortasc", StringUtil.RTrim( Ddo_br_lab_resultnum_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTNUM_Sortdsc", StringUtil.RTrim( Ddo_br_lab_resultnum_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTNUM_Searchbuttontext", StringUtil.RTrim( Ddo_br_lab_resultnum_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTUNIT_Caption", StringUtil.RTrim( Ddo_br_lab_resultunit_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTUNIT_Tooltip", StringUtil.RTrim( Ddo_br_lab_resultunit_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTUNIT_Cls", StringUtil.RTrim( Ddo_br_lab_resultunit_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTUNIT_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_lab_resultunit_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTUNIT_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_lab_resultunit_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTUNIT_Includesortasc", StringUtil.BoolToStr( Ddo_br_lab_resultunit_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTUNIT_Includesortdsc", StringUtil.BoolToStr( Ddo_br_lab_resultunit_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTUNIT_Sortedstatus", StringUtil.RTrim( Ddo_br_lab_resultunit_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTUNIT_Includefilter", StringUtil.BoolToStr( Ddo_br_lab_resultunit_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTUNIT_Includedatalist", StringUtil.BoolToStr( Ddo_br_lab_resultunit_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTUNIT_Sortasc", StringUtil.RTrim( Ddo_br_lab_resultunit_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTUNIT_Sortdsc", StringUtil.RTrim( Ddo_br_lab_resultunit_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTUNIT_Searchbuttontext", StringUtil.RTrim( Ddo_br_lab_resultunit_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_ABNIND_Caption", StringUtil.RTrim( Ddo_br_lab_abnind_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_ABNIND_Tooltip", StringUtil.RTrim( Ddo_br_lab_abnind_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_ABNIND_Cls", StringUtil.RTrim( Ddo_br_lab_abnind_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_ABNIND_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_lab_abnind_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_ABNIND_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_lab_abnind_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_ABNIND_Includesortasc", StringUtil.BoolToStr( Ddo_br_lab_abnind_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_ABNIND_Includesortdsc", StringUtil.BoolToStr( Ddo_br_lab_abnind_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_ABNIND_Sortedstatus", StringUtil.RTrim( Ddo_br_lab_abnind_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_ABNIND_Includefilter", StringUtil.BoolToStr( Ddo_br_lab_abnind_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_ABNIND_Includedatalist", StringUtil.BoolToStr( Ddo_br_lab_abnind_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_ABNIND_Sortasc", StringUtil.RTrim( Ddo_br_lab_abnind_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_ABNIND_Sortdsc", StringUtil.RTrim( Ddo_br_lab_abnind_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_ABNIND_Searchbuttontext", StringUtil.RTrim( Ddo_br_lab_abnind_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_NORMRANGELOW_Caption", StringUtil.RTrim( Ddo_br_lab_normrangelow_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_NORMRANGELOW_Tooltip", StringUtil.RTrim( Ddo_br_lab_normrangelow_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_NORMRANGELOW_Cls", StringUtil.RTrim( Ddo_br_lab_normrangelow_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_NORMRANGELOW_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_lab_normrangelow_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_NORMRANGELOW_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_lab_normrangelow_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_NORMRANGELOW_Includesortasc", StringUtil.BoolToStr( Ddo_br_lab_normrangelow_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_NORMRANGELOW_Includesortdsc", StringUtil.BoolToStr( Ddo_br_lab_normrangelow_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_NORMRANGELOW_Sortedstatus", StringUtil.RTrim( Ddo_br_lab_normrangelow_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_NORMRANGELOW_Includefilter", StringUtil.BoolToStr( Ddo_br_lab_normrangelow_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_NORMRANGELOW_Includedatalist", StringUtil.BoolToStr( Ddo_br_lab_normrangelow_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_NORMRANGELOW_Sortasc", StringUtil.RTrim( Ddo_br_lab_normrangelow_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_NORMRANGELOW_Sortdsc", StringUtil.RTrim( Ddo_br_lab_normrangelow_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_NORMRANGELOW_Searchbuttontext", StringUtil.RTrim( Ddo_br_lab_normrangelow_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_NORMRANGEHIGH_Caption", StringUtil.RTrim( Ddo_br_lab_normrangehigh_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_NORMRANGEHIGH_Tooltip", StringUtil.RTrim( Ddo_br_lab_normrangehigh_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_NORMRANGEHIGH_Cls", StringUtil.RTrim( Ddo_br_lab_normrangehigh_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_NORMRANGEHIGH_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_lab_normrangehigh_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_NORMRANGEHIGH_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_lab_normrangehigh_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_NORMRANGEHIGH_Includesortasc", StringUtil.BoolToStr( Ddo_br_lab_normrangehigh_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_NORMRANGEHIGH_Includesortdsc", StringUtil.BoolToStr( Ddo_br_lab_normrangehigh_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_NORMRANGEHIGH_Sortedstatus", StringUtil.RTrim( Ddo_br_lab_normrangehigh_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_NORMRANGEHIGH_Includefilter", StringUtil.BoolToStr( Ddo_br_lab_normrangehigh_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_NORMRANGEHIGH_Includedatalist", StringUtil.BoolToStr( Ddo_br_lab_normrangehigh_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_NORMRANGEHIGH_Sortasc", StringUtil.RTrim( Ddo_br_lab_normrangehigh_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_NORMRANGEHIGH_Sortdsc", StringUtil.RTrim( Ddo_br_lab_normrangehigh_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_NORMRANGEHIGH_Searchbuttontext", StringUtil.RTrim( Ddo_br_lab_normrangehigh_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTMETHOD_Caption", StringUtil.RTrim( Ddo_br_lab_testmethod_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTMETHOD_Tooltip", StringUtil.RTrim( Ddo_br_lab_testmethod_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTMETHOD_Cls", StringUtil.RTrim( Ddo_br_lab_testmethod_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTMETHOD_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_lab_testmethod_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTMETHOD_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_lab_testmethod_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTMETHOD_Includesortasc", StringUtil.BoolToStr( Ddo_br_lab_testmethod_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTMETHOD_Includesortdsc", StringUtil.BoolToStr( Ddo_br_lab_testmethod_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTMETHOD_Sortedstatus", StringUtil.RTrim( Ddo_br_lab_testmethod_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTMETHOD_Includefilter", StringUtil.BoolToStr( Ddo_br_lab_testmethod_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTMETHOD_Includedatalist", StringUtil.BoolToStr( Ddo_br_lab_testmethod_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTMETHOD_Sortasc", StringUtil.RTrim( Ddo_br_lab_testmethod_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTMETHOD_Sortdsc", StringUtil.RTrim( Ddo_br_lab_testmethod_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTMETHOD_Searchbuttontext", StringUtil.RTrim( Ddo_br_lab_testmethod_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_INSTRUMENTNAME_Caption", StringUtil.RTrim( Ddo_br_lab_instrumentname_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_INSTRUMENTNAME_Tooltip", StringUtil.RTrim( Ddo_br_lab_instrumentname_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_INSTRUMENTNAME_Cls", StringUtil.RTrim( Ddo_br_lab_instrumentname_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_INSTRUMENTNAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_lab_instrumentname_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_INSTRUMENTNAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_lab_instrumentname_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_INSTRUMENTNAME_Includesortasc", StringUtil.BoolToStr( Ddo_br_lab_instrumentname_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_INSTRUMENTNAME_Includesortdsc", StringUtil.BoolToStr( Ddo_br_lab_instrumentname_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_INSTRUMENTNAME_Sortedstatus", StringUtil.RTrim( Ddo_br_lab_instrumentname_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_INSTRUMENTNAME_Includefilter", StringUtil.BoolToStr( Ddo_br_lab_instrumentname_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_INSTRUMENTNAME_Includedatalist", StringUtil.BoolToStr( Ddo_br_lab_instrumentname_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_INSTRUMENTNAME_Sortasc", StringUtil.RTrim( Ddo_br_lab_instrumentname_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_INSTRUMENTNAME_Sortdsc", StringUtil.RTrim( Ddo_br_lab_instrumentname_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_INSTRUMENTNAME_Searchbuttontext", StringUtil.RTrim( Ddo_br_lab_instrumentname_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_INSTRUMENTCODE_Caption", StringUtil.RTrim( Ddo_br_lab_instrumentcode_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_INSTRUMENTCODE_Tooltip", StringUtil.RTrim( Ddo_br_lab_instrumentcode_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_INSTRUMENTCODE_Cls", StringUtil.RTrim( Ddo_br_lab_instrumentcode_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_INSTRUMENTCODE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_lab_instrumentcode_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_INSTRUMENTCODE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_lab_instrumentcode_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_INSTRUMENTCODE_Includesortasc", StringUtil.BoolToStr( Ddo_br_lab_instrumentcode_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_INSTRUMENTCODE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_lab_instrumentcode_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_INSTRUMENTCODE_Sortedstatus", StringUtil.RTrim( Ddo_br_lab_instrumentcode_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_INSTRUMENTCODE_Includefilter", StringUtil.BoolToStr( Ddo_br_lab_instrumentcode_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_INSTRUMENTCODE_Includedatalist", StringUtil.BoolToStr( Ddo_br_lab_instrumentcode_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_INSTRUMENTCODE_Sortasc", StringUtil.RTrim( Ddo_br_lab_instrumentcode_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_INSTRUMENTCODE_Sortdsc", StringUtil.RTrim( Ddo_br_lab_instrumentcode_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_INSTRUMENTCODE_Searchbuttontext", StringUtil.RTrim( Ddo_br_lab_instrumentcode_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LABID_Activeeventkey", StringUtil.RTrim( Ddo_br_labid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey", StringUtil.RTrim( Ddo_br_information_patientno_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SAMPLEID_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_sampleid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTID_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_testid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTCODE_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_testcode_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTNAME_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_testname_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTENGNAME_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_testengname_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_AGE_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_age_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_DIAG_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_diag_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SPECIMENDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_specimendate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RECEIVINGTIME_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_receivingtime_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_REPORTTIME_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_reporttime_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SPECIMENSOURCE_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_specimensource_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTQUAL_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_resultqual_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTNUM_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_resultnum_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTUNIT_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_resultunit_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_ABNIND_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_abnind_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_NORMRANGELOW_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_normrangelow_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_NORMRANGEHIGH_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_normrangehigh_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTMETHOD_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_testmethod_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_INSTRUMENTNAME_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_instrumentname_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_INSTRUMENTCODE_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_instrumentcode_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LABID_Activeeventkey", StringUtil.RTrim( Ddo_br_labid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey", StringUtil.RTrim( Ddo_br_information_patientno_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SAMPLEID_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_sampleid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTID_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_testid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTCODE_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_testcode_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTNAME_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_testname_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTENGNAME_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_testengname_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_AGE_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_age_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_DIAG_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_diag_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SPECIMENDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_specimendate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RECEIVINGTIME_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_receivingtime_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_REPORTTIME_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_reporttime_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_SPECIMENSOURCE_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_specimensource_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTQUAL_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_resultqual_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTNUM_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_resultnum_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_RESULTUNIT_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_resultunit_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_ABNIND_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_abnind_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_NORMRANGELOW_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_normrangelow_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_NORMRANGEHIGH_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_normrangehigh_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_TESTMETHOD_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_testmethod_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_INSTRUMENTNAME_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_instrumentname_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_LAB_INSTRUMENTCODE_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_instrumentcode_Activeeventkey));
      }

      protected void RenderHtmlCloseForm3H2( )
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
         return "BR_LabPrompt" ;
      }

      public override String GetPgmdesc( )
      {
         return "选择实验室检查" ;
      }

      protected void WB3H0( )
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
               if ( edtBR_LabID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_LabID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_LabID_Title) ;
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Lab_SampleID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Lab_SampleID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Lab_SampleID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Lab_TestID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Lab_TestID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Lab_TestID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Lab_TestCode_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Lab_TestCode_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Lab_TestCode_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Lab_TestName_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Lab_TestName_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Lab_TestName_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Lab_TestEngName_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Lab_TestEngName_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Lab_TestEngName_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Lab_Age_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Lab_Age_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Lab_Age_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Lab_Diag_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Lab_Diag_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Lab_Diag_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Lab_SpecimenDate_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Lab_SpecimenDate_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Lab_SpecimenDate_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Lab_ReceivingTime_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Lab_ReceivingTime_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Lab_ReceivingTime_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Lab_ReportTime_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Lab_ReportTime_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Lab_ReportTime_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Lab_SpecimenSource_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Lab_SpecimenSource_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Lab_SpecimenSource_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Lab_ResultQual_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Lab_ResultQual_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Lab_ResultQual_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Lab_ResultNum_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Lab_ResultNum_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Lab_ResultNum_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Lab_ResultUnit_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Lab_ResultUnit_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Lab_ResultUnit_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Lab_AbnInd_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Lab_AbnInd_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Lab_AbnInd_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Lab_NormRangeLow_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Lab_NormRangeLow_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Lab_NormRangeLow_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Lab_NormRangeHigh_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Lab_NormRangeHigh_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Lab_NormRangeHigh_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Lab_TestMethod_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Lab_TestMethod_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Lab_TestMethod_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Lab_InstrumentName_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Lab_InstrumentName_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Lab_InstrumentName_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Lab_InstrumentCode_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Lab_InstrumentCode_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Lab_InstrumentCode_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV57Select));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavSelect_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A101BR_LabID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_LabID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_LabID_Titleformat), 4, 0, ".", "")));
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
               GridColumn.AddObjectProperty("Value", A224BR_Lab_SampleID);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Lab_SampleID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Lab_SampleID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A102BR_Lab_TestID), 10, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Lab_TestID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Lab_TestID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A103BR_Lab_TestCode);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Lab_TestCode_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Lab_TestCode_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A104BR_Lab_TestName);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Lab_TestName_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Lab_TestName_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A261BR_Lab_TestEngName);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Lab_TestEngName_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Lab_TestEngName_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A262BR_Lab_Age), 3, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Lab_Age_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Lab_Age_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A263BR_Lab_Diag);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Lab_Diag_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Lab_Diag_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.TToC( A105BR_Lab_SpecimenDate, 10, 8, 0, 0, "/", ":", " "));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Lab_SpecimenDate_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Lab_SpecimenDate_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.TToC( A264BR_Lab_ReceivingTime, 10, 8, 0, 0, "/", ":", " "));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Lab_ReceivingTime_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Lab_ReceivingTime_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.TToC( A265BR_Lab_ReportTime, 10, 8, 0, 0, "/", ":", " "));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Lab_ReportTime_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Lab_ReportTime_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A106BR_Lab_SpecimenSource);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Lab_SpecimenSource_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Lab_SpecimenSource_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A109BR_Lab_ResultQual);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Lab_ResultQual_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Lab_ResultQual_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A110BR_Lab_ResultNum);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Lab_ResultNum_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Lab_ResultNum_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A111BR_Lab_ResultUnit);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Lab_ResultUnit_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Lab_ResultUnit_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A112BR_Lab_AbnInd);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Lab_AbnInd_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Lab_AbnInd_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A113BR_Lab_NormRangeLow);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Lab_NormRangeLow_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Lab_NormRangeLow_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A114BR_Lab_NormRangeHigh);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Lab_NormRangeHigh_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Lab_NormRangeHigh_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A115BR_Lab_TestMethod);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Lab_TestMethod_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Lab_TestMethod_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A117BR_Lab_InstrumentName);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Lab_InstrumentName_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Lab_InstrumentName_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A118BR_Lab_InstrumentCode);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Lab_InstrumentCode_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Lab_InstrumentCode_Titleformat), 4, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV54GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV56GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV55GridPageSize);
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
            ucDdo_br_labid.SetProperty("Caption", Ddo_br_labid_Caption);
            ucDdo_br_labid.SetProperty("Tooltip", Ddo_br_labid_Tooltip);
            ucDdo_br_labid.SetProperty("Cls", Ddo_br_labid_Cls);
            ucDdo_br_labid.SetProperty("DropDownOptionsType", Ddo_br_labid_Dropdownoptionstype);
            ucDdo_br_labid.SetProperty("IncludeSortASC", Ddo_br_labid_Includesortasc);
            ucDdo_br_labid.SetProperty("IncludeSortDSC", Ddo_br_labid_Includesortdsc);
            ucDdo_br_labid.SetProperty("IncludeFilter", Ddo_br_labid_Includefilter);
            ucDdo_br_labid.SetProperty("IncludeDataList", Ddo_br_labid_Includedatalist);
            ucDdo_br_labid.SetProperty("SortASC", Ddo_br_labid_Sortasc);
            ucDdo_br_labid.SetProperty("SortDSC", Ddo_br_labid_Sortdsc);
            ucDdo_br_labid.SetProperty("SearchButtonText", Ddo_br_labid_Searchbuttontext);
            ucDdo_br_labid.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_labid.SetProperty("DropDownOptionsData", AV12BR_LabIDTitleFilterData);
            ucDdo_br_labid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_labid_Internalname, "DDO_BR_LABIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_labidtitlecontrolidtoreplace_Internalname, AV13ddo_BR_LabIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"", 0, edtavDdo_br_labidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_LabPrompt.htm");
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
            ucDdo_br_encounterid.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsData", AV14BR_EncounterIDTitleFilterData);
            ucDdo_br_encounterid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounterid_Internalname, "DDO_BR_ENCOUNTERIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, AV15ddo_BR_EncounterIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,47);\"", 0, edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_LabPrompt.htm");
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
            ucDdo_br_information_patientno.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_information_patientno.SetProperty("DropDownOptionsData", AV16BR_Information_PatientNoTitleFilterData);
            ucDdo_br_information_patientno.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_information_patientno_Internalname, "DDO_BR_INFORMATION_PATIENTNOContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname, AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", 0, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_LabPrompt.htm");
            /* User Defined Control */
            ucDdo_br_lab_sampleid.SetProperty("Caption", Ddo_br_lab_sampleid_Caption);
            ucDdo_br_lab_sampleid.SetProperty("Tooltip", Ddo_br_lab_sampleid_Tooltip);
            ucDdo_br_lab_sampleid.SetProperty("Cls", Ddo_br_lab_sampleid_Cls);
            ucDdo_br_lab_sampleid.SetProperty("DropDownOptionsType", Ddo_br_lab_sampleid_Dropdownoptionstype);
            ucDdo_br_lab_sampleid.SetProperty("IncludeSortASC", Ddo_br_lab_sampleid_Includesortasc);
            ucDdo_br_lab_sampleid.SetProperty("IncludeSortDSC", Ddo_br_lab_sampleid_Includesortdsc);
            ucDdo_br_lab_sampleid.SetProperty("IncludeFilter", Ddo_br_lab_sampleid_Includefilter);
            ucDdo_br_lab_sampleid.SetProperty("IncludeDataList", Ddo_br_lab_sampleid_Includedatalist);
            ucDdo_br_lab_sampleid.SetProperty("SortASC", Ddo_br_lab_sampleid_Sortasc);
            ucDdo_br_lab_sampleid.SetProperty("SortDSC", Ddo_br_lab_sampleid_Sortdsc);
            ucDdo_br_lab_sampleid.SetProperty("SearchButtonText", Ddo_br_lab_sampleid_Searchbuttontext);
            ucDdo_br_lab_sampleid.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_lab_sampleid.SetProperty("DropDownOptionsData", AV58BR_Lab_SampleIDTitleFilterData);
            ucDdo_br_lab_sampleid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_lab_sampleid_Internalname, "DDO_BR_LAB_SAMPLEIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_lab_sampleidtitlecontrolidtoreplace_Internalname, AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", 0, edtavDdo_br_lab_sampleidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_LabPrompt.htm");
            /* User Defined Control */
            ucDdo_br_lab_testid.SetProperty("Caption", Ddo_br_lab_testid_Caption);
            ucDdo_br_lab_testid.SetProperty("Tooltip", Ddo_br_lab_testid_Tooltip);
            ucDdo_br_lab_testid.SetProperty("Cls", Ddo_br_lab_testid_Cls);
            ucDdo_br_lab_testid.SetProperty("DropDownOptionsType", Ddo_br_lab_testid_Dropdownoptionstype);
            ucDdo_br_lab_testid.SetProperty("IncludeSortASC", Ddo_br_lab_testid_Includesortasc);
            ucDdo_br_lab_testid.SetProperty("IncludeSortDSC", Ddo_br_lab_testid_Includesortdsc);
            ucDdo_br_lab_testid.SetProperty("IncludeFilter", Ddo_br_lab_testid_Includefilter);
            ucDdo_br_lab_testid.SetProperty("IncludeDataList", Ddo_br_lab_testid_Includedatalist);
            ucDdo_br_lab_testid.SetProperty("SortASC", Ddo_br_lab_testid_Sortasc);
            ucDdo_br_lab_testid.SetProperty("SortDSC", Ddo_br_lab_testid_Sortdsc);
            ucDdo_br_lab_testid.SetProperty("SearchButtonText", Ddo_br_lab_testid_Searchbuttontext);
            ucDdo_br_lab_testid.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_lab_testid.SetProperty("DropDownOptionsData", AV18BR_Lab_TestIDTitleFilterData);
            ucDdo_br_lab_testid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_lab_testid_Internalname, "DDO_BR_LAB_TESTIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_lab_testidtitlecontrolidtoreplace_Internalname, AV19ddo_BR_Lab_TestIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", 0, edtavDdo_br_lab_testidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_LabPrompt.htm");
            /* User Defined Control */
            ucDdo_br_lab_testcode.SetProperty("Caption", Ddo_br_lab_testcode_Caption);
            ucDdo_br_lab_testcode.SetProperty("Tooltip", Ddo_br_lab_testcode_Tooltip);
            ucDdo_br_lab_testcode.SetProperty("Cls", Ddo_br_lab_testcode_Cls);
            ucDdo_br_lab_testcode.SetProperty("DropDownOptionsType", Ddo_br_lab_testcode_Dropdownoptionstype);
            ucDdo_br_lab_testcode.SetProperty("IncludeSortASC", Ddo_br_lab_testcode_Includesortasc);
            ucDdo_br_lab_testcode.SetProperty("IncludeSortDSC", Ddo_br_lab_testcode_Includesortdsc);
            ucDdo_br_lab_testcode.SetProperty("IncludeFilter", Ddo_br_lab_testcode_Includefilter);
            ucDdo_br_lab_testcode.SetProperty("IncludeDataList", Ddo_br_lab_testcode_Includedatalist);
            ucDdo_br_lab_testcode.SetProperty("SortASC", Ddo_br_lab_testcode_Sortasc);
            ucDdo_br_lab_testcode.SetProperty("SortDSC", Ddo_br_lab_testcode_Sortdsc);
            ucDdo_br_lab_testcode.SetProperty("SearchButtonText", Ddo_br_lab_testcode_Searchbuttontext);
            ucDdo_br_lab_testcode.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_lab_testcode.SetProperty("DropDownOptionsData", AV20BR_Lab_TestCodeTitleFilterData);
            ucDdo_br_lab_testcode.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_lab_testcode_Internalname, "DDO_BR_LAB_TESTCODEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_lab_testcodetitlecontrolidtoreplace_Internalname, AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", 0, edtavDdo_br_lab_testcodetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_LabPrompt.htm");
            /* User Defined Control */
            ucDdo_br_lab_testname.SetProperty("Caption", Ddo_br_lab_testname_Caption);
            ucDdo_br_lab_testname.SetProperty("Tooltip", Ddo_br_lab_testname_Tooltip);
            ucDdo_br_lab_testname.SetProperty("Cls", Ddo_br_lab_testname_Cls);
            ucDdo_br_lab_testname.SetProperty("DropDownOptionsType", Ddo_br_lab_testname_Dropdownoptionstype);
            ucDdo_br_lab_testname.SetProperty("IncludeSortASC", Ddo_br_lab_testname_Includesortasc);
            ucDdo_br_lab_testname.SetProperty("IncludeSortDSC", Ddo_br_lab_testname_Includesortdsc);
            ucDdo_br_lab_testname.SetProperty("IncludeFilter", Ddo_br_lab_testname_Includefilter);
            ucDdo_br_lab_testname.SetProperty("IncludeDataList", Ddo_br_lab_testname_Includedatalist);
            ucDdo_br_lab_testname.SetProperty("SortASC", Ddo_br_lab_testname_Sortasc);
            ucDdo_br_lab_testname.SetProperty("SortDSC", Ddo_br_lab_testname_Sortdsc);
            ucDdo_br_lab_testname.SetProperty("SearchButtonText", Ddo_br_lab_testname_Searchbuttontext);
            ucDdo_br_lab_testname.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_lab_testname.SetProperty("DropDownOptionsData", AV22BR_Lab_TestNameTitleFilterData);
            ucDdo_br_lab_testname.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_lab_testname_Internalname, "DDO_BR_LAB_TESTNAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_lab_testnametitlecontrolidtoreplace_Internalname, AV23ddo_BR_Lab_TestNameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", 0, edtavDdo_br_lab_testnametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_LabPrompt.htm");
            /* User Defined Control */
            ucDdo_br_lab_testengname.SetProperty("Caption", Ddo_br_lab_testengname_Caption);
            ucDdo_br_lab_testengname.SetProperty("Tooltip", Ddo_br_lab_testengname_Tooltip);
            ucDdo_br_lab_testengname.SetProperty("Cls", Ddo_br_lab_testengname_Cls);
            ucDdo_br_lab_testengname.SetProperty("DropDownOptionsType", Ddo_br_lab_testengname_Dropdownoptionstype);
            ucDdo_br_lab_testengname.SetProperty("IncludeSortASC", Ddo_br_lab_testengname_Includesortasc);
            ucDdo_br_lab_testengname.SetProperty("IncludeSortDSC", Ddo_br_lab_testengname_Includesortdsc);
            ucDdo_br_lab_testengname.SetProperty("IncludeFilter", Ddo_br_lab_testengname_Includefilter);
            ucDdo_br_lab_testengname.SetProperty("IncludeDataList", Ddo_br_lab_testengname_Includedatalist);
            ucDdo_br_lab_testengname.SetProperty("SortASC", Ddo_br_lab_testengname_Sortasc);
            ucDdo_br_lab_testengname.SetProperty("SortDSC", Ddo_br_lab_testengname_Sortdsc);
            ucDdo_br_lab_testengname.SetProperty("SearchButtonText", Ddo_br_lab_testengname_Searchbuttontext);
            ucDdo_br_lab_testengname.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_lab_testengname.SetProperty("DropDownOptionsData", AV60BR_Lab_TestEngNameTitleFilterData);
            ucDdo_br_lab_testengname.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_lab_testengname_Internalname, "DDO_BR_LAB_TESTENGNAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_lab_testengnametitlecontrolidtoreplace_Internalname, AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", 0, edtavDdo_br_lab_testengnametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_LabPrompt.htm");
            /* User Defined Control */
            ucDdo_br_lab_age.SetProperty("Caption", Ddo_br_lab_age_Caption);
            ucDdo_br_lab_age.SetProperty("Tooltip", Ddo_br_lab_age_Tooltip);
            ucDdo_br_lab_age.SetProperty("Cls", Ddo_br_lab_age_Cls);
            ucDdo_br_lab_age.SetProperty("DropDownOptionsType", Ddo_br_lab_age_Dropdownoptionstype);
            ucDdo_br_lab_age.SetProperty("IncludeSortASC", Ddo_br_lab_age_Includesortasc);
            ucDdo_br_lab_age.SetProperty("IncludeSortDSC", Ddo_br_lab_age_Includesortdsc);
            ucDdo_br_lab_age.SetProperty("IncludeFilter", Ddo_br_lab_age_Includefilter);
            ucDdo_br_lab_age.SetProperty("IncludeDataList", Ddo_br_lab_age_Includedatalist);
            ucDdo_br_lab_age.SetProperty("SortASC", Ddo_br_lab_age_Sortasc);
            ucDdo_br_lab_age.SetProperty("SortDSC", Ddo_br_lab_age_Sortdsc);
            ucDdo_br_lab_age.SetProperty("SearchButtonText", Ddo_br_lab_age_Searchbuttontext);
            ucDdo_br_lab_age.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_lab_age.SetProperty("DropDownOptionsData", AV62BR_Lab_AgeTitleFilterData);
            ucDdo_br_lab_age.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_lab_age_Internalname, "DDO_BR_LAB_AGEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_lab_agetitlecontrolidtoreplace_Internalname, AV63ddo_BR_Lab_AgeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,61);\"", 0, edtavDdo_br_lab_agetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_LabPrompt.htm");
            /* User Defined Control */
            ucDdo_br_lab_diag.SetProperty("Caption", Ddo_br_lab_diag_Caption);
            ucDdo_br_lab_diag.SetProperty("Tooltip", Ddo_br_lab_diag_Tooltip);
            ucDdo_br_lab_diag.SetProperty("Cls", Ddo_br_lab_diag_Cls);
            ucDdo_br_lab_diag.SetProperty("DropDownOptionsType", Ddo_br_lab_diag_Dropdownoptionstype);
            ucDdo_br_lab_diag.SetProperty("IncludeSortASC", Ddo_br_lab_diag_Includesortasc);
            ucDdo_br_lab_diag.SetProperty("IncludeSortDSC", Ddo_br_lab_diag_Includesortdsc);
            ucDdo_br_lab_diag.SetProperty("IncludeFilter", Ddo_br_lab_diag_Includefilter);
            ucDdo_br_lab_diag.SetProperty("IncludeDataList", Ddo_br_lab_diag_Includedatalist);
            ucDdo_br_lab_diag.SetProperty("SortASC", Ddo_br_lab_diag_Sortasc);
            ucDdo_br_lab_diag.SetProperty("SortDSC", Ddo_br_lab_diag_Sortdsc);
            ucDdo_br_lab_diag.SetProperty("SearchButtonText", Ddo_br_lab_diag_Searchbuttontext);
            ucDdo_br_lab_diag.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_lab_diag.SetProperty("DropDownOptionsData", AV64BR_Lab_DiagTitleFilterData);
            ucDdo_br_lab_diag.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_lab_diag_Internalname, "DDO_BR_LAB_DIAGContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_lab_diagtitlecontrolidtoreplace_Internalname, AV65ddo_BR_Lab_DiagTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", 0, edtavDdo_br_lab_diagtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_LabPrompt.htm");
            /* User Defined Control */
            ucDdo_br_lab_specimendate.SetProperty("Caption", Ddo_br_lab_specimendate_Caption);
            ucDdo_br_lab_specimendate.SetProperty("Tooltip", Ddo_br_lab_specimendate_Tooltip);
            ucDdo_br_lab_specimendate.SetProperty("Cls", Ddo_br_lab_specimendate_Cls);
            ucDdo_br_lab_specimendate.SetProperty("DropDownOptionsType", Ddo_br_lab_specimendate_Dropdownoptionstype);
            ucDdo_br_lab_specimendate.SetProperty("IncludeSortASC", Ddo_br_lab_specimendate_Includesortasc);
            ucDdo_br_lab_specimendate.SetProperty("IncludeSortDSC", Ddo_br_lab_specimendate_Includesortdsc);
            ucDdo_br_lab_specimendate.SetProperty("IncludeFilter", Ddo_br_lab_specimendate_Includefilter);
            ucDdo_br_lab_specimendate.SetProperty("IncludeDataList", Ddo_br_lab_specimendate_Includedatalist);
            ucDdo_br_lab_specimendate.SetProperty("SortASC", Ddo_br_lab_specimendate_Sortasc);
            ucDdo_br_lab_specimendate.SetProperty("SortDSC", Ddo_br_lab_specimendate_Sortdsc);
            ucDdo_br_lab_specimendate.SetProperty("SearchButtonText", Ddo_br_lab_specimendate_Searchbuttontext);
            ucDdo_br_lab_specimendate.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_lab_specimendate.SetProperty("DropDownOptionsData", AV24BR_Lab_SpecimenDateTitleFilterData);
            ucDdo_br_lab_specimendate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_lab_specimendate_Internalname, "DDO_BR_LAB_SPECIMENDATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_lab_specimendatetitlecontrolidtoreplace_Internalname, AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,65);\"", 0, edtavDdo_br_lab_specimendatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_LabPrompt.htm");
            /* User Defined Control */
            ucDdo_br_lab_receivingtime.SetProperty("Caption", Ddo_br_lab_receivingtime_Caption);
            ucDdo_br_lab_receivingtime.SetProperty("Tooltip", Ddo_br_lab_receivingtime_Tooltip);
            ucDdo_br_lab_receivingtime.SetProperty("Cls", Ddo_br_lab_receivingtime_Cls);
            ucDdo_br_lab_receivingtime.SetProperty("DropDownOptionsType", Ddo_br_lab_receivingtime_Dropdownoptionstype);
            ucDdo_br_lab_receivingtime.SetProperty("IncludeSortASC", Ddo_br_lab_receivingtime_Includesortasc);
            ucDdo_br_lab_receivingtime.SetProperty("IncludeSortDSC", Ddo_br_lab_receivingtime_Includesortdsc);
            ucDdo_br_lab_receivingtime.SetProperty("IncludeFilter", Ddo_br_lab_receivingtime_Includefilter);
            ucDdo_br_lab_receivingtime.SetProperty("IncludeDataList", Ddo_br_lab_receivingtime_Includedatalist);
            ucDdo_br_lab_receivingtime.SetProperty("SortASC", Ddo_br_lab_receivingtime_Sortasc);
            ucDdo_br_lab_receivingtime.SetProperty("SortDSC", Ddo_br_lab_receivingtime_Sortdsc);
            ucDdo_br_lab_receivingtime.SetProperty("SearchButtonText", Ddo_br_lab_receivingtime_Searchbuttontext);
            ucDdo_br_lab_receivingtime.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_lab_receivingtime.SetProperty("DropDownOptionsData", AV66BR_Lab_ReceivingTimeTitleFilterData);
            ucDdo_br_lab_receivingtime.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_lab_receivingtime_Internalname, "DDO_BR_LAB_RECEIVINGTIMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_lab_receivingtimetitlecontrolidtoreplace_Internalname, AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,67);\"", 0, edtavDdo_br_lab_receivingtimetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_LabPrompt.htm");
            /* User Defined Control */
            ucDdo_br_lab_reporttime.SetProperty("Caption", Ddo_br_lab_reporttime_Caption);
            ucDdo_br_lab_reporttime.SetProperty("Tooltip", Ddo_br_lab_reporttime_Tooltip);
            ucDdo_br_lab_reporttime.SetProperty("Cls", Ddo_br_lab_reporttime_Cls);
            ucDdo_br_lab_reporttime.SetProperty("DropDownOptionsType", Ddo_br_lab_reporttime_Dropdownoptionstype);
            ucDdo_br_lab_reporttime.SetProperty("IncludeSortASC", Ddo_br_lab_reporttime_Includesortasc);
            ucDdo_br_lab_reporttime.SetProperty("IncludeSortDSC", Ddo_br_lab_reporttime_Includesortdsc);
            ucDdo_br_lab_reporttime.SetProperty("IncludeFilter", Ddo_br_lab_reporttime_Includefilter);
            ucDdo_br_lab_reporttime.SetProperty("IncludeDataList", Ddo_br_lab_reporttime_Includedatalist);
            ucDdo_br_lab_reporttime.SetProperty("SortASC", Ddo_br_lab_reporttime_Sortasc);
            ucDdo_br_lab_reporttime.SetProperty("SortDSC", Ddo_br_lab_reporttime_Sortdsc);
            ucDdo_br_lab_reporttime.SetProperty("SearchButtonText", Ddo_br_lab_reporttime_Searchbuttontext);
            ucDdo_br_lab_reporttime.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_lab_reporttime.SetProperty("DropDownOptionsData", AV68BR_Lab_ReportTimeTitleFilterData);
            ucDdo_br_lab_reporttime.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_lab_reporttime_Internalname, "DDO_BR_LAB_REPORTTIMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_lab_reporttimetitlecontrolidtoreplace_Internalname, AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,69);\"", 0, edtavDdo_br_lab_reporttimetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_LabPrompt.htm");
            /* User Defined Control */
            ucDdo_br_lab_specimensource.SetProperty("Caption", Ddo_br_lab_specimensource_Caption);
            ucDdo_br_lab_specimensource.SetProperty("Tooltip", Ddo_br_lab_specimensource_Tooltip);
            ucDdo_br_lab_specimensource.SetProperty("Cls", Ddo_br_lab_specimensource_Cls);
            ucDdo_br_lab_specimensource.SetProperty("DropDownOptionsType", Ddo_br_lab_specimensource_Dropdownoptionstype);
            ucDdo_br_lab_specimensource.SetProperty("IncludeSortASC", Ddo_br_lab_specimensource_Includesortasc);
            ucDdo_br_lab_specimensource.SetProperty("IncludeSortDSC", Ddo_br_lab_specimensource_Includesortdsc);
            ucDdo_br_lab_specimensource.SetProperty("IncludeFilter", Ddo_br_lab_specimensource_Includefilter);
            ucDdo_br_lab_specimensource.SetProperty("IncludeDataList", Ddo_br_lab_specimensource_Includedatalist);
            ucDdo_br_lab_specimensource.SetProperty("SortASC", Ddo_br_lab_specimensource_Sortasc);
            ucDdo_br_lab_specimensource.SetProperty("SortDSC", Ddo_br_lab_specimensource_Sortdsc);
            ucDdo_br_lab_specimensource.SetProperty("SearchButtonText", Ddo_br_lab_specimensource_Searchbuttontext);
            ucDdo_br_lab_specimensource.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_lab_specimensource.SetProperty("DropDownOptionsData", AV26BR_Lab_SpecimenSourceTitleFilterData);
            ucDdo_br_lab_specimensource.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_lab_specimensource_Internalname, "DDO_BR_LAB_SPECIMENSOURCEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_lab_specimensourcetitlecontrolidtoreplace_Internalname, AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,71);\"", 0, edtavDdo_br_lab_specimensourcetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_LabPrompt.htm");
            /* User Defined Control */
            ucDdo_br_lab_resultqual.SetProperty("Caption", Ddo_br_lab_resultqual_Caption);
            ucDdo_br_lab_resultqual.SetProperty("Tooltip", Ddo_br_lab_resultqual_Tooltip);
            ucDdo_br_lab_resultqual.SetProperty("Cls", Ddo_br_lab_resultqual_Cls);
            ucDdo_br_lab_resultqual.SetProperty("DropDownOptionsType", Ddo_br_lab_resultqual_Dropdownoptionstype);
            ucDdo_br_lab_resultqual.SetProperty("IncludeSortASC", Ddo_br_lab_resultqual_Includesortasc);
            ucDdo_br_lab_resultqual.SetProperty("IncludeSortDSC", Ddo_br_lab_resultqual_Includesortdsc);
            ucDdo_br_lab_resultqual.SetProperty("IncludeFilter", Ddo_br_lab_resultqual_Includefilter);
            ucDdo_br_lab_resultqual.SetProperty("IncludeDataList", Ddo_br_lab_resultqual_Includedatalist);
            ucDdo_br_lab_resultqual.SetProperty("SortASC", Ddo_br_lab_resultqual_Sortasc);
            ucDdo_br_lab_resultqual.SetProperty("SortDSC", Ddo_br_lab_resultqual_Sortdsc);
            ucDdo_br_lab_resultqual.SetProperty("SearchButtonText", Ddo_br_lab_resultqual_Searchbuttontext);
            ucDdo_br_lab_resultqual.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_lab_resultqual.SetProperty("DropDownOptionsData", AV32BR_Lab_ResultQualTitleFilterData);
            ucDdo_br_lab_resultqual.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_lab_resultqual_Internalname, "DDO_BR_LAB_RESULTQUALContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_lab_resultqualtitlecontrolidtoreplace_Internalname, AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,73);\"", 0, edtavDdo_br_lab_resultqualtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_LabPrompt.htm");
            /* User Defined Control */
            ucDdo_br_lab_resultnum.SetProperty("Caption", Ddo_br_lab_resultnum_Caption);
            ucDdo_br_lab_resultnum.SetProperty("Tooltip", Ddo_br_lab_resultnum_Tooltip);
            ucDdo_br_lab_resultnum.SetProperty("Cls", Ddo_br_lab_resultnum_Cls);
            ucDdo_br_lab_resultnum.SetProperty("DropDownOptionsType", Ddo_br_lab_resultnum_Dropdownoptionstype);
            ucDdo_br_lab_resultnum.SetProperty("IncludeSortASC", Ddo_br_lab_resultnum_Includesortasc);
            ucDdo_br_lab_resultnum.SetProperty("IncludeSortDSC", Ddo_br_lab_resultnum_Includesortdsc);
            ucDdo_br_lab_resultnum.SetProperty("IncludeFilter", Ddo_br_lab_resultnum_Includefilter);
            ucDdo_br_lab_resultnum.SetProperty("IncludeDataList", Ddo_br_lab_resultnum_Includedatalist);
            ucDdo_br_lab_resultnum.SetProperty("SortASC", Ddo_br_lab_resultnum_Sortasc);
            ucDdo_br_lab_resultnum.SetProperty("SortDSC", Ddo_br_lab_resultnum_Sortdsc);
            ucDdo_br_lab_resultnum.SetProperty("SearchButtonText", Ddo_br_lab_resultnum_Searchbuttontext);
            ucDdo_br_lab_resultnum.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_lab_resultnum.SetProperty("DropDownOptionsData", AV34BR_Lab_ResultNumTitleFilterData);
            ucDdo_br_lab_resultnum.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_lab_resultnum_Internalname, "DDO_BR_LAB_RESULTNUMContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 75,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_lab_resultnumtitlecontrolidtoreplace_Internalname, AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,75);\"", 0, edtavDdo_br_lab_resultnumtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_LabPrompt.htm");
            /* User Defined Control */
            ucDdo_br_lab_resultunit.SetProperty("Caption", Ddo_br_lab_resultunit_Caption);
            ucDdo_br_lab_resultunit.SetProperty("Tooltip", Ddo_br_lab_resultunit_Tooltip);
            ucDdo_br_lab_resultunit.SetProperty("Cls", Ddo_br_lab_resultunit_Cls);
            ucDdo_br_lab_resultunit.SetProperty("DropDownOptionsType", Ddo_br_lab_resultunit_Dropdownoptionstype);
            ucDdo_br_lab_resultunit.SetProperty("IncludeSortASC", Ddo_br_lab_resultunit_Includesortasc);
            ucDdo_br_lab_resultunit.SetProperty("IncludeSortDSC", Ddo_br_lab_resultunit_Includesortdsc);
            ucDdo_br_lab_resultunit.SetProperty("IncludeFilter", Ddo_br_lab_resultunit_Includefilter);
            ucDdo_br_lab_resultunit.SetProperty("IncludeDataList", Ddo_br_lab_resultunit_Includedatalist);
            ucDdo_br_lab_resultunit.SetProperty("SortASC", Ddo_br_lab_resultunit_Sortasc);
            ucDdo_br_lab_resultunit.SetProperty("SortDSC", Ddo_br_lab_resultunit_Sortdsc);
            ucDdo_br_lab_resultunit.SetProperty("SearchButtonText", Ddo_br_lab_resultunit_Searchbuttontext);
            ucDdo_br_lab_resultunit.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_lab_resultunit.SetProperty("DropDownOptionsData", AV36BR_Lab_ResultUnitTitleFilterData);
            ucDdo_br_lab_resultunit.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_lab_resultunit_Internalname, "DDO_BR_LAB_RESULTUNITContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_lab_resultunittitlecontrolidtoreplace_Internalname, AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,77);\"", 0, edtavDdo_br_lab_resultunittitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_LabPrompt.htm");
            /* User Defined Control */
            ucDdo_br_lab_abnind.SetProperty("Caption", Ddo_br_lab_abnind_Caption);
            ucDdo_br_lab_abnind.SetProperty("Tooltip", Ddo_br_lab_abnind_Tooltip);
            ucDdo_br_lab_abnind.SetProperty("Cls", Ddo_br_lab_abnind_Cls);
            ucDdo_br_lab_abnind.SetProperty("DropDownOptionsType", Ddo_br_lab_abnind_Dropdownoptionstype);
            ucDdo_br_lab_abnind.SetProperty("IncludeSortASC", Ddo_br_lab_abnind_Includesortasc);
            ucDdo_br_lab_abnind.SetProperty("IncludeSortDSC", Ddo_br_lab_abnind_Includesortdsc);
            ucDdo_br_lab_abnind.SetProperty("IncludeFilter", Ddo_br_lab_abnind_Includefilter);
            ucDdo_br_lab_abnind.SetProperty("IncludeDataList", Ddo_br_lab_abnind_Includedatalist);
            ucDdo_br_lab_abnind.SetProperty("SortASC", Ddo_br_lab_abnind_Sortasc);
            ucDdo_br_lab_abnind.SetProperty("SortDSC", Ddo_br_lab_abnind_Sortdsc);
            ucDdo_br_lab_abnind.SetProperty("SearchButtonText", Ddo_br_lab_abnind_Searchbuttontext);
            ucDdo_br_lab_abnind.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_lab_abnind.SetProperty("DropDownOptionsData", AV38BR_Lab_AbnIndTitleFilterData);
            ucDdo_br_lab_abnind.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_lab_abnind_Internalname, "DDO_BR_LAB_ABNINDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 79,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_lab_abnindtitlecontrolidtoreplace_Internalname, AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,79);\"", 0, edtavDdo_br_lab_abnindtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_LabPrompt.htm");
            /* User Defined Control */
            ucDdo_br_lab_normrangelow.SetProperty("Caption", Ddo_br_lab_normrangelow_Caption);
            ucDdo_br_lab_normrangelow.SetProperty("Tooltip", Ddo_br_lab_normrangelow_Tooltip);
            ucDdo_br_lab_normrangelow.SetProperty("Cls", Ddo_br_lab_normrangelow_Cls);
            ucDdo_br_lab_normrangelow.SetProperty("DropDownOptionsType", Ddo_br_lab_normrangelow_Dropdownoptionstype);
            ucDdo_br_lab_normrangelow.SetProperty("IncludeSortASC", Ddo_br_lab_normrangelow_Includesortasc);
            ucDdo_br_lab_normrangelow.SetProperty("IncludeSortDSC", Ddo_br_lab_normrangelow_Includesortdsc);
            ucDdo_br_lab_normrangelow.SetProperty("IncludeFilter", Ddo_br_lab_normrangelow_Includefilter);
            ucDdo_br_lab_normrangelow.SetProperty("IncludeDataList", Ddo_br_lab_normrangelow_Includedatalist);
            ucDdo_br_lab_normrangelow.SetProperty("SortASC", Ddo_br_lab_normrangelow_Sortasc);
            ucDdo_br_lab_normrangelow.SetProperty("SortDSC", Ddo_br_lab_normrangelow_Sortdsc);
            ucDdo_br_lab_normrangelow.SetProperty("SearchButtonText", Ddo_br_lab_normrangelow_Searchbuttontext);
            ucDdo_br_lab_normrangelow.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_lab_normrangelow.SetProperty("DropDownOptionsData", AV40BR_Lab_NormRangeLowTitleFilterData);
            ucDdo_br_lab_normrangelow.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_lab_normrangelow_Internalname, "DDO_BR_LAB_NORMRANGELOWContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_lab_normrangelowtitlecontrolidtoreplace_Internalname, AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,81);\"", 0, edtavDdo_br_lab_normrangelowtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_LabPrompt.htm");
            /* User Defined Control */
            ucDdo_br_lab_normrangehigh.SetProperty("Caption", Ddo_br_lab_normrangehigh_Caption);
            ucDdo_br_lab_normrangehigh.SetProperty("Tooltip", Ddo_br_lab_normrangehigh_Tooltip);
            ucDdo_br_lab_normrangehigh.SetProperty("Cls", Ddo_br_lab_normrangehigh_Cls);
            ucDdo_br_lab_normrangehigh.SetProperty("DropDownOptionsType", Ddo_br_lab_normrangehigh_Dropdownoptionstype);
            ucDdo_br_lab_normrangehigh.SetProperty("IncludeSortASC", Ddo_br_lab_normrangehigh_Includesortasc);
            ucDdo_br_lab_normrangehigh.SetProperty("IncludeSortDSC", Ddo_br_lab_normrangehigh_Includesortdsc);
            ucDdo_br_lab_normrangehigh.SetProperty("IncludeFilter", Ddo_br_lab_normrangehigh_Includefilter);
            ucDdo_br_lab_normrangehigh.SetProperty("IncludeDataList", Ddo_br_lab_normrangehigh_Includedatalist);
            ucDdo_br_lab_normrangehigh.SetProperty("SortASC", Ddo_br_lab_normrangehigh_Sortasc);
            ucDdo_br_lab_normrangehigh.SetProperty("SortDSC", Ddo_br_lab_normrangehigh_Sortdsc);
            ucDdo_br_lab_normrangehigh.SetProperty("SearchButtonText", Ddo_br_lab_normrangehigh_Searchbuttontext);
            ucDdo_br_lab_normrangehigh.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_lab_normrangehigh.SetProperty("DropDownOptionsData", AV42BR_Lab_NormRangeHighTitleFilterData);
            ucDdo_br_lab_normrangehigh.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_lab_normrangehigh_Internalname, "DDO_BR_LAB_NORMRANGEHIGHContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_lab_normrangehightitlecontrolidtoreplace_Internalname, AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,83);\"", 0, edtavDdo_br_lab_normrangehightitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_LabPrompt.htm");
            /* User Defined Control */
            ucDdo_br_lab_testmethod.SetProperty("Caption", Ddo_br_lab_testmethod_Caption);
            ucDdo_br_lab_testmethod.SetProperty("Tooltip", Ddo_br_lab_testmethod_Tooltip);
            ucDdo_br_lab_testmethod.SetProperty("Cls", Ddo_br_lab_testmethod_Cls);
            ucDdo_br_lab_testmethod.SetProperty("DropDownOptionsType", Ddo_br_lab_testmethod_Dropdownoptionstype);
            ucDdo_br_lab_testmethod.SetProperty("IncludeSortASC", Ddo_br_lab_testmethod_Includesortasc);
            ucDdo_br_lab_testmethod.SetProperty("IncludeSortDSC", Ddo_br_lab_testmethod_Includesortdsc);
            ucDdo_br_lab_testmethod.SetProperty("IncludeFilter", Ddo_br_lab_testmethod_Includefilter);
            ucDdo_br_lab_testmethod.SetProperty("IncludeDataList", Ddo_br_lab_testmethod_Includedatalist);
            ucDdo_br_lab_testmethod.SetProperty("SortASC", Ddo_br_lab_testmethod_Sortasc);
            ucDdo_br_lab_testmethod.SetProperty("SortDSC", Ddo_br_lab_testmethod_Sortdsc);
            ucDdo_br_lab_testmethod.SetProperty("SearchButtonText", Ddo_br_lab_testmethod_Searchbuttontext);
            ucDdo_br_lab_testmethod.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_lab_testmethod.SetProperty("DropDownOptionsData", AV44BR_Lab_TestMethodTitleFilterData);
            ucDdo_br_lab_testmethod.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_lab_testmethod_Internalname, "DDO_BR_LAB_TESTMETHODContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 85,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_lab_testmethodtitlecontrolidtoreplace_Internalname, AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,85);\"", 0, edtavDdo_br_lab_testmethodtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_LabPrompt.htm");
            /* User Defined Control */
            ucDdo_br_lab_instrumentname.SetProperty("Caption", Ddo_br_lab_instrumentname_Caption);
            ucDdo_br_lab_instrumentname.SetProperty("Tooltip", Ddo_br_lab_instrumentname_Tooltip);
            ucDdo_br_lab_instrumentname.SetProperty("Cls", Ddo_br_lab_instrumentname_Cls);
            ucDdo_br_lab_instrumentname.SetProperty("DropDownOptionsType", Ddo_br_lab_instrumentname_Dropdownoptionstype);
            ucDdo_br_lab_instrumentname.SetProperty("IncludeSortASC", Ddo_br_lab_instrumentname_Includesortasc);
            ucDdo_br_lab_instrumentname.SetProperty("IncludeSortDSC", Ddo_br_lab_instrumentname_Includesortdsc);
            ucDdo_br_lab_instrumentname.SetProperty("IncludeFilter", Ddo_br_lab_instrumentname_Includefilter);
            ucDdo_br_lab_instrumentname.SetProperty("IncludeDataList", Ddo_br_lab_instrumentname_Includedatalist);
            ucDdo_br_lab_instrumentname.SetProperty("SortASC", Ddo_br_lab_instrumentname_Sortasc);
            ucDdo_br_lab_instrumentname.SetProperty("SortDSC", Ddo_br_lab_instrumentname_Sortdsc);
            ucDdo_br_lab_instrumentname.SetProperty("SearchButtonText", Ddo_br_lab_instrumentname_Searchbuttontext);
            ucDdo_br_lab_instrumentname.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_lab_instrumentname.SetProperty("DropDownOptionsData", AV48BR_Lab_InstrumentNameTitleFilterData);
            ucDdo_br_lab_instrumentname.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_lab_instrumentname_Internalname, "DDO_BR_LAB_INSTRUMENTNAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 87,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_lab_instrumentnametitlecontrolidtoreplace_Internalname, AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,87);\"", 0, edtavDdo_br_lab_instrumentnametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_LabPrompt.htm");
            /* User Defined Control */
            ucDdo_br_lab_instrumentcode.SetProperty("Caption", Ddo_br_lab_instrumentcode_Caption);
            ucDdo_br_lab_instrumentcode.SetProperty("Tooltip", Ddo_br_lab_instrumentcode_Tooltip);
            ucDdo_br_lab_instrumentcode.SetProperty("Cls", Ddo_br_lab_instrumentcode_Cls);
            ucDdo_br_lab_instrumentcode.SetProperty("DropDownOptionsType", Ddo_br_lab_instrumentcode_Dropdownoptionstype);
            ucDdo_br_lab_instrumentcode.SetProperty("IncludeSortASC", Ddo_br_lab_instrumentcode_Includesortasc);
            ucDdo_br_lab_instrumentcode.SetProperty("IncludeSortDSC", Ddo_br_lab_instrumentcode_Includesortdsc);
            ucDdo_br_lab_instrumentcode.SetProperty("IncludeFilter", Ddo_br_lab_instrumentcode_Includefilter);
            ucDdo_br_lab_instrumentcode.SetProperty("IncludeDataList", Ddo_br_lab_instrumentcode_Includedatalist);
            ucDdo_br_lab_instrumentcode.SetProperty("SortASC", Ddo_br_lab_instrumentcode_Sortasc);
            ucDdo_br_lab_instrumentcode.SetProperty("SortDSC", Ddo_br_lab_instrumentcode_Sortdsc);
            ucDdo_br_lab_instrumentcode.SetProperty("SearchButtonText", Ddo_br_lab_instrumentcode_Searchbuttontext);
            ucDdo_br_lab_instrumentcode.SetProperty("DropDownOptionsTitleSettingsIcons", AV52DDO_TitleSettingsIcons);
            ucDdo_br_lab_instrumentcode.SetProperty("DropDownOptionsData", AV50BR_Lab_InstrumentCodeTitleFilterData);
            ucDdo_br_lab_instrumentcode.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_lab_instrumentcode_Internalname, "DDO_BR_LAB_INSTRUMENTCODEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 89,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_lab_instrumentcodetitlecontrolidtoreplace_Internalname, AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,89);\"", 0, edtavDdo_br_lab_instrumentcodetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_LabPrompt.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,91);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_LabPrompt.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 92,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV11OrderedDsc), StringUtil.BoolToStr( AV11OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,92);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_LabPrompt.htm");
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

      protected void START3H2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "选择实验室检查", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP3H0( ) ;
      }

      protected void WS3H2( )
      {
         START3H2( ) ;
         EVT3H2( ) ;
      }

      protected void EVT3H2( )
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
                           E113H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E123H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_LABID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E133H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTERID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E143H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E153H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_LAB_SAMPLEID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E163H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_LAB_TESTID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E173H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_LAB_TESTCODE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E183H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_LAB_TESTNAME.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E193H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_LAB_TESTENGNAME.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E203H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_LAB_AGE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E213H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_LAB_DIAG.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E223H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_LAB_SPECIMENDATE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E233H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_LAB_RECEIVINGTIME.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E243H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_LAB_REPORTTIME.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E253H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_LAB_SPECIMENSOURCE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E263H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_LAB_RESULTQUAL.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E273H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_LAB_RESULTNUM.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E283H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_LAB_RESULTUNIT.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E293H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_LAB_ABNIND.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E303H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_LAB_NORMRANGELOW.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E313H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_LAB_NORMRANGEHIGH.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E323H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_LAB_TESTMETHOD.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E333H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_LAB_INSTRUMENTNAME.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E343H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_LAB_INSTRUMENTCODE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E353H2 ();
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
                           AV57Select = cgiGet( edtavSelect_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV57Select)) ? AV73Select_GXI : context.convertURL( context.PathToRelativeUrl( AV57Select))), !bGXsfl_12_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "SrcSet", context.GetImageSrcSet( AV57Select), true);
                           A101BR_LabID = (long)(context.localUtil.CToN( cgiGet( edtBR_LabID_Internalname), ".", ","));
                           A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
                           A36BR_Information_PatientNo = cgiGet( edtBR_Information_PatientNo_Internalname);
                           n36BR_Information_PatientNo = false;
                           A224BR_Lab_SampleID = cgiGet( edtBR_Lab_SampleID_Internalname);
                           n224BR_Lab_SampleID = false;
                           A102BR_Lab_TestID = (long)(context.localUtil.CToN( cgiGet( edtBR_Lab_TestID_Internalname), ".", ","));
                           n102BR_Lab_TestID = false;
                           A103BR_Lab_TestCode = cgiGet( edtBR_Lab_TestCode_Internalname);
                           n103BR_Lab_TestCode = false;
                           A104BR_Lab_TestName = cgiGet( edtBR_Lab_TestName_Internalname);
                           n104BR_Lab_TestName = false;
                           A261BR_Lab_TestEngName = cgiGet( edtBR_Lab_TestEngName_Internalname);
                           n261BR_Lab_TestEngName = false;
                           A262BR_Lab_Age = (short)(context.localUtil.CToN( cgiGet( edtBR_Lab_Age_Internalname), ".", ","));
                           n262BR_Lab_Age = false;
                           A263BR_Lab_Diag = cgiGet( edtBR_Lab_Diag_Internalname);
                           n263BR_Lab_Diag = false;
                           A105BR_Lab_SpecimenDate = context.localUtil.CToT( cgiGet( edtBR_Lab_SpecimenDate_Internalname), 0);
                           n105BR_Lab_SpecimenDate = false;
                           A264BR_Lab_ReceivingTime = context.localUtil.CToT( cgiGet( edtBR_Lab_ReceivingTime_Internalname), 0);
                           n264BR_Lab_ReceivingTime = false;
                           A265BR_Lab_ReportTime = context.localUtil.CToT( cgiGet( edtBR_Lab_ReportTime_Internalname), 0);
                           n265BR_Lab_ReportTime = false;
                           A106BR_Lab_SpecimenSource = cgiGet( edtBR_Lab_SpecimenSource_Internalname);
                           n106BR_Lab_SpecimenSource = false;
                           A109BR_Lab_ResultQual = cgiGet( edtBR_Lab_ResultQual_Internalname);
                           n109BR_Lab_ResultQual = false;
                           A110BR_Lab_ResultNum = cgiGet( edtBR_Lab_ResultNum_Internalname);
                           n110BR_Lab_ResultNum = false;
                           A111BR_Lab_ResultUnit = cgiGet( edtBR_Lab_ResultUnit_Internalname);
                           n111BR_Lab_ResultUnit = false;
                           A112BR_Lab_AbnInd = cgiGet( edtBR_Lab_AbnInd_Internalname);
                           n112BR_Lab_AbnInd = false;
                           A113BR_Lab_NormRangeLow = cgiGet( edtBR_Lab_NormRangeLow_Internalname);
                           n113BR_Lab_NormRangeLow = false;
                           A114BR_Lab_NormRangeHigh = cgiGet( edtBR_Lab_NormRangeHigh_Internalname);
                           n114BR_Lab_NormRangeHigh = false;
                           A115BR_Lab_TestMethod = cgiGet( edtBR_Lab_TestMethod_Internalname);
                           n115BR_Lab_TestMethod = false;
                           A117BR_Lab_InstrumentName = cgiGet( edtBR_Lab_InstrumentName_Internalname);
                           n117BR_Lab_InstrumentName = false;
                           A118BR_Lab_InstrumentCode = cgiGet( edtBR_Lab_InstrumentCode_Internalname);
                           n118BR_Lab_InstrumentCode = false;
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E363H2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E373H2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E383H2 ();
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
                                       E393H2 ();
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

      protected void WE3H2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm3H2( ) ;
            }
         }
      }

      protected void PA3H2( )
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
               GX_FocusControl = edtavDdo_br_labidtitlecontrolidtoreplace_Internalname;
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
                                       String AV13ddo_BR_LabIDTitleControlIdToReplace ,
                                       String AV15ddo_BR_EncounterIDTitleControlIdToReplace ,
                                       String AV17ddo_BR_Information_PatientNoTitleControlIdToReplace ,
                                       String AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace ,
                                       String AV19ddo_BR_Lab_TestIDTitleControlIdToReplace ,
                                       String AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace ,
                                       String AV23ddo_BR_Lab_TestNameTitleControlIdToReplace ,
                                       String AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace ,
                                       String AV63ddo_BR_Lab_AgeTitleControlIdToReplace ,
                                       String AV65ddo_BR_Lab_DiagTitleControlIdToReplace ,
                                       String AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace ,
                                       String AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace ,
                                       String AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace ,
                                       String AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace ,
                                       String AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace ,
                                       String AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace ,
                                       String AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace ,
                                       String AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace ,
                                       String AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace ,
                                       String AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace ,
                                       String AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace ,
                                       String AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace ,
                                       String AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF3H2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_LABID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A101BR_LabID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_LABID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A101BR_LabID), 18, 0, ".", "")));
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
         RF3H2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV72Pgmname = "BR_LabPrompt";
         context.Gx_err = 0;
      }

      protected void RF3H2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 12;
         /* Execute user event: Refresh */
         E373H2 ();
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
            /* Using cursor H003H2 */
            pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_12_idx = 1;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A85BR_Information_ID = H003H2_A85BR_Information_ID[0];
               n85BR_Information_ID = H003H2_n85BR_Information_ID[0];
               A118BR_Lab_InstrumentCode = H003H2_A118BR_Lab_InstrumentCode[0];
               n118BR_Lab_InstrumentCode = H003H2_n118BR_Lab_InstrumentCode[0];
               A117BR_Lab_InstrumentName = H003H2_A117BR_Lab_InstrumentName[0];
               n117BR_Lab_InstrumentName = H003H2_n117BR_Lab_InstrumentName[0];
               A115BR_Lab_TestMethod = H003H2_A115BR_Lab_TestMethod[0];
               n115BR_Lab_TestMethod = H003H2_n115BR_Lab_TestMethod[0];
               A114BR_Lab_NormRangeHigh = H003H2_A114BR_Lab_NormRangeHigh[0];
               n114BR_Lab_NormRangeHigh = H003H2_n114BR_Lab_NormRangeHigh[0];
               A113BR_Lab_NormRangeLow = H003H2_A113BR_Lab_NormRangeLow[0];
               n113BR_Lab_NormRangeLow = H003H2_n113BR_Lab_NormRangeLow[0];
               A112BR_Lab_AbnInd = H003H2_A112BR_Lab_AbnInd[0];
               n112BR_Lab_AbnInd = H003H2_n112BR_Lab_AbnInd[0];
               A111BR_Lab_ResultUnit = H003H2_A111BR_Lab_ResultUnit[0];
               n111BR_Lab_ResultUnit = H003H2_n111BR_Lab_ResultUnit[0];
               A110BR_Lab_ResultNum = H003H2_A110BR_Lab_ResultNum[0];
               n110BR_Lab_ResultNum = H003H2_n110BR_Lab_ResultNum[0];
               A109BR_Lab_ResultQual = H003H2_A109BR_Lab_ResultQual[0];
               n109BR_Lab_ResultQual = H003H2_n109BR_Lab_ResultQual[0];
               A106BR_Lab_SpecimenSource = H003H2_A106BR_Lab_SpecimenSource[0];
               n106BR_Lab_SpecimenSource = H003H2_n106BR_Lab_SpecimenSource[0];
               A265BR_Lab_ReportTime = H003H2_A265BR_Lab_ReportTime[0];
               n265BR_Lab_ReportTime = H003H2_n265BR_Lab_ReportTime[0];
               A264BR_Lab_ReceivingTime = H003H2_A264BR_Lab_ReceivingTime[0];
               n264BR_Lab_ReceivingTime = H003H2_n264BR_Lab_ReceivingTime[0];
               A105BR_Lab_SpecimenDate = H003H2_A105BR_Lab_SpecimenDate[0];
               n105BR_Lab_SpecimenDate = H003H2_n105BR_Lab_SpecimenDate[0];
               A263BR_Lab_Diag = H003H2_A263BR_Lab_Diag[0];
               n263BR_Lab_Diag = H003H2_n263BR_Lab_Diag[0];
               A262BR_Lab_Age = H003H2_A262BR_Lab_Age[0];
               n262BR_Lab_Age = H003H2_n262BR_Lab_Age[0];
               A261BR_Lab_TestEngName = H003H2_A261BR_Lab_TestEngName[0];
               n261BR_Lab_TestEngName = H003H2_n261BR_Lab_TestEngName[0];
               A104BR_Lab_TestName = H003H2_A104BR_Lab_TestName[0];
               n104BR_Lab_TestName = H003H2_n104BR_Lab_TestName[0];
               A103BR_Lab_TestCode = H003H2_A103BR_Lab_TestCode[0];
               n103BR_Lab_TestCode = H003H2_n103BR_Lab_TestCode[0];
               A102BR_Lab_TestID = H003H2_A102BR_Lab_TestID[0];
               n102BR_Lab_TestID = H003H2_n102BR_Lab_TestID[0];
               A224BR_Lab_SampleID = H003H2_A224BR_Lab_SampleID[0];
               n224BR_Lab_SampleID = H003H2_n224BR_Lab_SampleID[0];
               A36BR_Information_PatientNo = H003H2_A36BR_Information_PatientNo[0];
               n36BR_Information_PatientNo = H003H2_n36BR_Information_PatientNo[0];
               A19BR_EncounterID = H003H2_A19BR_EncounterID[0];
               A101BR_LabID = H003H2_A101BR_LabID[0];
               A85BR_Information_ID = H003H2_A85BR_Information_ID[0];
               n85BR_Information_ID = H003H2_n85BR_Information_ID[0];
               A36BR_Information_PatientNo = H003H2_A36BR_Information_PatientNo[0];
               n36BR_Information_PatientNo = H003H2_n36BR_Information_PatientNo[0];
               E383H2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 12;
            WB3H0( ) ;
         }
         bGXsfl_12_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes3H2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_LABID"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, context.localUtil.Format( (decimal)(A101BR_LabID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         /* Using cursor H003H3 */
         pr_default.execute(1);
         GRID_nRecordCount = H003H3_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_LabIDTitleControlIdToReplace, AV15ddo_BR_EncounterIDTitleControlIdToReplace, AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace, AV19ddo_BR_Lab_TestIDTitleControlIdToReplace, AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace, AV23ddo_BR_Lab_TestNameTitleControlIdToReplace, AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace, AV63ddo_BR_Lab_AgeTitleControlIdToReplace, AV65ddo_BR_Lab_DiagTitleControlIdToReplace, AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace, AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace, AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace, AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace, AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace, AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace, AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace, AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace, AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace, AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace, AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace, AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace, AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_LabIDTitleControlIdToReplace, AV15ddo_BR_EncounterIDTitleControlIdToReplace, AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace, AV19ddo_BR_Lab_TestIDTitleControlIdToReplace, AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace, AV23ddo_BR_Lab_TestNameTitleControlIdToReplace, AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace, AV63ddo_BR_Lab_AgeTitleControlIdToReplace, AV65ddo_BR_Lab_DiagTitleControlIdToReplace, AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace, AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace, AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace, AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace, AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace, AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace, AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace, AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace, AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace, AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace, AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace, AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace, AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_LabIDTitleControlIdToReplace, AV15ddo_BR_EncounterIDTitleControlIdToReplace, AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace, AV19ddo_BR_Lab_TestIDTitleControlIdToReplace, AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace, AV23ddo_BR_Lab_TestNameTitleControlIdToReplace, AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace, AV63ddo_BR_Lab_AgeTitleControlIdToReplace, AV65ddo_BR_Lab_DiagTitleControlIdToReplace, AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace, AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace, AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace, AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace, AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace, AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace, AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace, AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace, AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace, AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace, AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace, AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace, AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_LabIDTitleControlIdToReplace, AV15ddo_BR_EncounterIDTitleControlIdToReplace, AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace, AV19ddo_BR_Lab_TestIDTitleControlIdToReplace, AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace, AV23ddo_BR_Lab_TestNameTitleControlIdToReplace, AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace, AV63ddo_BR_Lab_AgeTitleControlIdToReplace, AV65ddo_BR_Lab_DiagTitleControlIdToReplace, AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace, AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace, AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace, AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace, AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace, AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace, AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace, AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace, AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace, AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace, AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace, AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace, AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_LabIDTitleControlIdToReplace, AV15ddo_BR_EncounterIDTitleControlIdToReplace, AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace, AV19ddo_BR_Lab_TestIDTitleControlIdToReplace, AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace, AV23ddo_BR_Lab_TestNameTitleControlIdToReplace, AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace, AV63ddo_BR_Lab_AgeTitleControlIdToReplace, AV65ddo_BR_Lab_DiagTitleControlIdToReplace, AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace, AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace, AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace, AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace, AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace, AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace, AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace, AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace, AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace, AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace, AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace, AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace, AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP3H0( )
      {
         /* Before Start, stand alone formulas. */
         AV72Pgmname = "BR_LabPrompt";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E363H2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV52DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_LABIDTITLEFILTERDATA"), AV12BR_LabIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTERIDTITLEFILTERDATA"), AV14BR_EncounterIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_INFORMATION_PATIENTNOTITLEFILTERDATA"), AV16BR_Information_PatientNoTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_LAB_SAMPLEIDTITLEFILTERDATA"), AV58BR_Lab_SampleIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_LAB_TESTIDTITLEFILTERDATA"), AV18BR_Lab_TestIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_LAB_TESTCODETITLEFILTERDATA"), AV20BR_Lab_TestCodeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_LAB_TESTNAMETITLEFILTERDATA"), AV22BR_Lab_TestNameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_LAB_TESTENGNAMETITLEFILTERDATA"), AV60BR_Lab_TestEngNameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_LAB_AGETITLEFILTERDATA"), AV62BR_Lab_AgeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_LAB_DIAGTITLEFILTERDATA"), AV64BR_Lab_DiagTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_LAB_SPECIMENDATETITLEFILTERDATA"), AV24BR_Lab_SpecimenDateTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_LAB_RECEIVINGTIMETITLEFILTERDATA"), AV66BR_Lab_ReceivingTimeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_LAB_REPORTTIMETITLEFILTERDATA"), AV68BR_Lab_ReportTimeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_LAB_SPECIMENSOURCETITLEFILTERDATA"), AV26BR_Lab_SpecimenSourceTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_LAB_RESULTQUALTITLEFILTERDATA"), AV32BR_Lab_ResultQualTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_LAB_RESULTNUMTITLEFILTERDATA"), AV34BR_Lab_ResultNumTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_LAB_RESULTUNITTITLEFILTERDATA"), AV36BR_Lab_ResultUnitTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_LAB_ABNINDTITLEFILTERDATA"), AV38BR_Lab_AbnIndTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_LAB_NORMRANGELOWTITLEFILTERDATA"), AV40BR_Lab_NormRangeLowTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_LAB_NORMRANGEHIGHTITLEFILTERDATA"), AV42BR_Lab_NormRangeHighTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_LAB_TESTMETHODTITLEFILTERDATA"), AV44BR_Lab_TestMethodTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_LAB_INSTRUMENTNAMETITLEFILTERDATA"), AV48BR_Lab_InstrumentNameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_LAB_INSTRUMENTCODETITLEFILTERDATA"), AV50BR_Lab_InstrumentCodeTitleFilterData);
            /* Read variables values. */
            AV13ddo_BR_LabIDTitleControlIdToReplace = cgiGet( edtavDdo_br_labidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13ddo_BR_LabIDTitleControlIdToReplace", AV13ddo_BR_LabIDTitleControlIdToReplace);
            AV15ddo_BR_EncounterIDTitleControlIdToReplace = cgiGet( edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ddo_BR_EncounterIDTitleControlIdToReplace", AV15ddo_BR_EncounterIDTitleControlIdToReplace);
            AV17ddo_BR_Information_PatientNoTitleControlIdToReplace = cgiGet( edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17ddo_BR_Information_PatientNoTitleControlIdToReplace", AV17ddo_BR_Information_PatientNoTitleControlIdToReplace);
            AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace = cgiGet( edtavDdo_br_lab_sampleidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace", AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace);
            AV19ddo_BR_Lab_TestIDTitleControlIdToReplace = cgiGet( edtavDdo_br_lab_testidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_Lab_TestIDTitleControlIdToReplace", AV19ddo_BR_Lab_TestIDTitleControlIdToReplace);
            AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace = cgiGet( edtavDdo_br_lab_testcodetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace", AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace);
            AV23ddo_BR_Lab_TestNameTitleControlIdToReplace = cgiGet( edtavDdo_br_lab_testnametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_Lab_TestNameTitleControlIdToReplace", AV23ddo_BR_Lab_TestNameTitleControlIdToReplace);
            AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace = cgiGet( edtavDdo_br_lab_testengnametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace", AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace);
            AV63ddo_BR_Lab_AgeTitleControlIdToReplace = cgiGet( edtavDdo_br_lab_agetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV63ddo_BR_Lab_AgeTitleControlIdToReplace", AV63ddo_BR_Lab_AgeTitleControlIdToReplace);
            AV65ddo_BR_Lab_DiagTitleControlIdToReplace = cgiGet( edtavDdo_br_lab_diagtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV65ddo_BR_Lab_DiagTitleControlIdToReplace", AV65ddo_BR_Lab_DiagTitleControlIdToReplace);
            AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace = cgiGet( edtavDdo_br_lab_specimendatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace", AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace);
            AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace = cgiGet( edtavDdo_br_lab_receivingtimetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace", AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace);
            AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace = cgiGet( edtavDdo_br_lab_reporttimetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace", AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace);
            AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace = cgiGet( edtavDdo_br_lab_specimensourcetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace", AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace);
            AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace = cgiGet( edtavDdo_br_lab_resultqualtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace", AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace);
            AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace = cgiGet( edtavDdo_br_lab_resultnumtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace", AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace);
            AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace = cgiGet( edtavDdo_br_lab_resultunittitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace", AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace);
            AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace = cgiGet( edtavDdo_br_lab_abnindtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace", AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace);
            AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace = cgiGet( edtavDdo_br_lab_normrangelowtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace", AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace);
            AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace = cgiGet( edtavDdo_br_lab_normrangehightitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace", AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace);
            AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace = cgiGet( edtavDdo_br_lab_testmethodtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace", AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace);
            AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace = cgiGet( edtavDdo_br_lab_instrumentnametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace", AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace);
            AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace = cgiGet( edtavDdo_br_lab_instrumentcodetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace", AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace);
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
            AV54GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV56GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV55GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_labid_Caption = cgiGet( "DDO_BR_LABID_Caption");
            Ddo_br_labid_Tooltip = cgiGet( "DDO_BR_LABID_Tooltip");
            Ddo_br_labid_Cls = cgiGet( "DDO_BR_LABID_Cls");
            Ddo_br_labid_Dropdownoptionstype = cgiGet( "DDO_BR_LABID_Dropdownoptionstype");
            Ddo_br_labid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_LABID_Titlecontrolidtoreplace");
            Ddo_br_labid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_LABID_Includesortasc"));
            Ddo_br_labid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_LABID_Includesortdsc"));
            Ddo_br_labid_Sortedstatus = cgiGet( "DDO_BR_LABID_Sortedstatus");
            Ddo_br_labid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_LABID_Includefilter"));
            Ddo_br_labid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_LABID_Includedatalist"));
            Ddo_br_labid_Sortasc = cgiGet( "DDO_BR_LABID_Sortasc");
            Ddo_br_labid_Sortdsc = cgiGet( "DDO_BR_LABID_Sortdsc");
            Ddo_br_labid_Searchbuttontext = cgiGet( "DDO_BR_LABID_Searchbuttontext");
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
            Ddo_br_lab_sampleid_Caption = cgiGet( "DDO_BR_LAB_SAMPLEID_Caption");
            Ddo_br_lab_sampleid_Tooltip = cgiGet( "DDO_BR_LAB_SAMPLEID_Tooltip");
            Ddo_br_lab_sampleid_Cls = cgiGet( "DDO_BR_LAB_SAMPLEID_Cls");
            Ddo_br_lab_sampleid_Dropdownoptionstype = cgiGet( "DDO_BR_LAB_SAMPLEID_Dropdownoptionstype");
            Ddo_br_lab_sampleid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_LAB_SAMPLEID_Titlecontrolidtoreplace");
            Ddo_br_lab_sampleid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_SAMPLEID_Includesortasc"));
            Ddo_br_lab_sampleid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_SAMPLEID_Includesortdsc"));
            Ddo_br_lab_sampleid_Sortedstatus = cgiGet( "DDO_BR_LAB_SAMPLEID_Sortedstatus");
            Ddo_br_lab_sampleid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_SAMPLEID_Includefilter"));
            Ddo_br_lab_sampleid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_SAMPLEID_Includedatalist"));
            Ddo_br_lab_sampleid_Sortasc = cgiGet( "DDO_BR_LAB_SAMPLEID_Sortasc");
            Ddo_br_lab_sampleid_Sortdsc = cgiGet( "DDO_BR_LAB_SAMPLEID_Sortdsc");
            Ddo_br_lab_sampleid_Searchbuttontext = cgiGet( "DDO_BR_LAB_SAMPLEID_Searchbuttontext");
            Ddo_br_lab_testid_Caption = cgiGet( "DDO_BR_LAB_TESTID_Caption");
            Ddo_br_lab_testid_Tooltip = cgiGet( "DDO_BR_LAB_TESTID_Tooltip");
            Ddo_br_lab_testid_Cls = cgiGet( "DDO_BR_LAB_TESTID_Cls");
            Ddo_br_lab_testid_Dropdownoptionstype = cgiGet( "DDO_BR_LAB_TESTID_Dropdownoptionstype");
            Ddo_br_lab_testid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_LAB_TESTID_Titlecontrolidtoreplace");
            Ddo_br_lab_testid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_TESTID_Includesortasc"));
            Ddo_br_lab_testid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_TESTID_Includesortdsc"));
            Ddo_br_lab_testid_Sortedstatus = cgiGet( "DDO_BR_LAB_TESTID_Sortedstatus");
            Ddo_br_lab_testid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_TESTID_Includefilter"));
            Ddo_br_lab_testid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_TESTID_Includedatalist"));
            Ddo_br_lab_testid_Sortasc = cgiGet( "DDO_BR_LAB_TESTID_Sortasc");
            Ddo_br_lab_testid_Sortdsc = cgiGet( "DDO_BR_LAB_TESTID_Sortdsc");
            Ddo_br_lab_testid_Searchbuttontext = cgiGet( "DDO_BR_LAB_TESTID_Searchbuttontext");
            Ddo_br_lab_testcode_Caption = cgiGet( "DDO_BR_LAB_TESTCODE_Caption");
            Ddo_br_lab_testcode_Tooltip = cgiGet( "DDO_BR_LAB_TESTCODE_Tooltip");
            Ddo_br_lab_testcode_Cls = cgiGet( "DDO_BR_LAB_TESTCODE_Cls");
            Ddo_br_lab_testcode_Dropdownoptionstype = cgiGet( "DDO_BR_LAB_TESTCODE_Dropdownoptionstype");
            Ddo_br_lab_testcode_Titlecontrolidtoreplace = cgiGet( "DDO_BR_LAB_TESTCODE_Titlecontrolidtoreplace");
            Ddo_br_lab_testcode_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_TESTCODE_Includesortasc"));
            Ddo_br_lab_testcode_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_TESTCODE_Includesortdsc"));
            Ddo_br_lab_testcode_Sortedstatus = cgiGet( "DDO_BR_LAB_TESTCODE_Sortedstatus");
            Ddo_br_lab_testcode_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_TESTCODE_Includefilter"));
            Ddo_br_lab_testcode_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_TESTCODE_Includedatalist"));
            Ddo_br_lab_testcode_Sortasc = cgiGet( "DDO_BR_LAB_TESTCODE_Sortasc");
            Ddo_br_lab_testcode_Sortdsc = cgiGet( "DDO_BR_LAB_TESTCODE_Sortdsc");
            Ddo_br_lab_testcode_Searchbuttontext = cgiGet( "DDO_BR_LAB_TESTCODE_Searchbuttontext");
            Ddo_br_lab_testname_Caption = cgiGet( "DDO_BR_LAB_TESTNAME_Caption");
            Ddo_br_lab_testname_Tooltip = cgiGet( "DDO_BR_LAB_TESTNAME_Tooltip");
            Ddo_br_lab_testname_Cls = cgiGet( "DDO_BR_LAB_TESTNAME_Cls");
            Ddo_br_lab_testname_Dropdownoptionstype = cgiGet( "DDO_BR_LAB_TESTNAME_Dropdownoptionstype");
            Ddo_br_lab_testname_Titlecontrolidtoreplace = cgiGet( "DDO_BR_LAB_TESTNAME_Titlecontrolidtoreplace");
            Ddo_br_lab_testname_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_TESTNAME_Includesortasc"));
            Ddo_br_lab_testname_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_TESTNAME_Includesortdsc"));
            Ddo_br_lab_testname_Sortedstatus = cgiGet( "DDO_BR_LAB_TESTNAME_Sortedstatus");
            Ddo_br_lab_testname_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_TESTNAME_Includefilter"));
            Ddo_br_lab_testname_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_TESTNAME_Includedatalist"));
            Ddo_br_lab_testname_Sortasc = cgiGet( "DDO_BR_LAB_TESTNAME_Sortasc");
            Ddo_br_lab_testname_Sortdsc = cgiGet( "DDO_BR_LAB_TESTNAME_Sortdsc");
            Ddo_br_lab_testname_Searchbuttontext = cgiGet( "DDO_BR_LAB_TESTNAME_Searchbuttontext");
            Ddo_br_lab_testengname_Caption = cgiGet( "DDO_BR_LAB_TESTENGNAME_Caption");
            Ddo_br_lab_testengname_Tooltip = cgiGet( "DDO_BR_LAB_TESTENGNAME_Tooltip");
            Ddo_br_lab_testengname_Cls = cgiGet( "DDO_BR_LAB_TESTENGNAME_Cls");
            Ddo_br_lab_testengname_Dropdownoptionstype = cgiGet( "DDO_BR_LAB_TESTENGNAME_Dropdownoptionstype");
            Ddo_br_lab_testengname_Titlecontrolidtoreplace = cgiGet( "DDO_BR_LAB_TESTENGNAME_Titlecontrolidtoreplace");
            Ddo_br_lab_testengname_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_TESTENGNAME_Includesortasc"));
            Ddo_br_lab_testengname_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_TESTENGNAME_Includesortdsc"));
            Ddo_br_lab_testengname_Sortedstatus = cgiGet( "DDO_BR_LAB_TESTENGNAME_Sortedstatus");
            Ddo_br_lab_testengname_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_TESTENGNAME_Includefilter"));
            Ddo_br_lab_testengname_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_TESTENGNAME_Includedatalist"));
            Ddo_br_lab_testengname_Sortasc = cgiGet( "DDO_BR_LAB_TESTENGNAME_Sortasc");
            Ddo_br_lab_testengname_Sortdsc = cgiGet( "DDO_BR_LAB_TESTENGNAME_Sortdsc");
            Ddo_br_lab_testengname_Searchbuttontext = cgiGet( "DDO_BR_LAB_TESTENGNAME_Searchbuttontext");
            Ddo_br_lab_age_Caption = cgiGet( "DDO_BR_LAB_AGE_Caption");
            Ddo_br_lab_age_Tooltip = cgiGet( "DDO_BR_LAB_AGE_Tooltip");
            Ddo_br_lab_age_Cls = cgiGet( "DDO_BR_LAB_AGE_Cls");
            Ddo_br_lab_age_Dropdownoptionstype = cgiGet( "DDO_BR_LAB_AGE_Dropdownoptionstype");
            Ddo_br_lab_age_Titlecontrolidtoreplace = cgiGet( "DDO_BR_LAB_AGE_Titlecontrolidtoreplace");
            Ddo_br_lab_age_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_AGE_Includesortasc"));
            Ddo_br_lab_age_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_AGE_Includesortdsc"));
            Ddo_br_lab_age_Sortedstatus = cgiGet( "DDO_BR_LAB_AGE_Sortedstatus");
            Ddo_br_lab_age_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_AGE_Includefilter"));
            Ddo_br_lab_age_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_AGE_Includedatalist"));
            Ddo_br_lab_age_Sortasc = cgiGet( "DDO_BR_LAB_AGE_Sortasc");
            Ddo_br_lab_age_Sortdsc = cgiGet( "DDO_BR_LAB_AGE_Sortdsc");
            Ddo_br_lab_age_Searchbuttontext = cgiGet( "DDO_BR_LAB_AGE_Searchbuttontext");
            Ddo_br_lab_diag_Caption = cgiGet( "DDO_BR_LAB_DIAG_Caption");
            Ddo_br_lab_diag_Tooltip = cgiGet( "DDO_BR_LAB_DIAG_Tooltip");
            Ddo_br_lab_diag_Cls = cgiGet( "DDO_BR_LAB_DIAG_Cls");
            Ddo_br_lab_diag_Dropdownoptionstype = cgiGet( "DDO_BR_LAB_DIAG_Dropdownoptionstype");
            Ddo_br_lab_diag_Titlecontrolidtoreplace = cgiGet( "DDO_BR_LAB_DIAG_Titlecontrolidtoreplace");
            Ddo_br_lab_diag_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_DIAG_Includesortasc"));
            Ddo_br_lab_diag_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_DIAG_Includesortdsc"));
            Ddo_br_lab_diag_Sortedstatus = cgiGet( "DDO_BR_LAB_DIAG_Sortedstatus");
            Ddo_br_lab_diag_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_DIAG_Includefilter"));
            Ddo_br_lab_diag_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_DIAG_Includedatalist"));
            Ddo_br_lab_diag_Sortasc = cgiGet( "DDO_BR_LAB_DIAG_Sortasc");
            Ddo_br_lab_diag_Sortdsc = cgiGet( "DDO_BR_LAB_DIAG_Sortdsc");
            Ddo_br_lab_diag_Searchbuttontext = cgiGet( "DDO_BR_LAB_DIAG_Searchbuttontext");
            Ddo_br_lab_specimendate_Caption = cgiGet( "DDO_BR_LAB_SPECIMENDATE_Caption");
            Ddo_br_lab_specimendate_Tooltip = cgiGet( "DDO_BR_LAB_SPECIMENDATE_Tooltip");
            Ddo_br_lab_specimendate_Cls = cgiGet( "DDO_BR_LAB_SPECIMENDATE_Cls");
            Ddo_br_lab_specimendate_Dropdownoptionstype = cgiGet( "DDO_BR_LAB_SPECIMENDATE_Dropdownoptionstype");
            Ddo_br_lab_specimendate_Titlecontrolidtoreplace = cgiGet( "DDO_BR_LAB_SPECIMENDATE_Titlecontrolidtoreplace");
            Ddo_br_lab_specimendate_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_SPECIMENDATE_Includesortasc"));
            Ddo_br_lab_specimendate_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_SPECIMENDATE_Includesortdsc"));
            Ddo_br_lab_specimendate_Sortedstatus = cgiGet( "DDO_BR_LAB_SPECIMENDATE_Sortedstatus");
            Ddo_br_lab_specimendate_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_SPECIMENDATE_Includefilter"));
            Ddo_br_lab_specimendate_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_SPECIMENDATE_Includedatalist"));
            Ddo_br_lab_specimendate_Sortasc = cgiGet( "DDO_BR_LAB_SPECIMENDATE_Sortasc");
            Ddo_br_lab_specimendate_Sortdsc = cgiGet( "DDO_BR_LAB_SPECIMENDATE_Sortdsc");
            Ddo_br_lab_specimendate_Searchbuttontext = cgiGet( "DDO_BR_LAB_SPECIMENDATE_Searchbuttontext");
            Ddo_br_lab_receivingtime_Caption = cgiGet( "DDO_BR_LAB_RECEIVINGTIME_Caption");
            Ddo_br_lab_receivingtime_Tooltip = cgiGet( "DDO_BR_LAB_RECEIVINGTIME_Tooltip");
            Ddo_br_lab_receivingtime_Cls = cgiGet( "DDO_BR_LAB_RECEIVINGTIME_Cls");
            Ddo_br_lab_receivingtime_Dropdownoptionstype = cgiGet( "DDO_BR_LAB_RECEIVINGTIME_Dropdownoptionstype");
            Ddo_br_lab_receivingtime_Titlecontrolidtoreplace = cgiGet( "DDO_BR_LAB_RECEIVINGTIME_Titlecontrolidtoreplace");
            Ddo_br_lab_receivingtime_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_RECEIVINGTIME_Includesortasc"));
            Ddo_br_lab_receivingtime_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_RECEIVINGTIME_Includesortdsc"));
            Ddo_br_lab_receivingtime_Sortedstatus = cgiGet( "DDO_BR_LAB_RECEIVINGTIME_Sortedstatus");
            Ddo_br_lab_receivingtime_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_RECEIVINGTIME_Includefilter"));
            Ddo_br_lab_receivingtime_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_RECEIVINGTIME_Includedatalist"));
            Ddo_br_lab_receivingtime_Sortasc = cgiGet( "DDO_BR_LAB_RECEIVINGTIME_Sortasc");
            Ddo_br_lab_receivingtime_Sortdsc = cgiGet( "DDO_BR_LAB_RECEIVINGTIME_Sortdsc");
            Ddo_br_lab_receivingtime_Searchbuttontext = cgiGet( "DDO_BR_LAB_RECEIVINGTIME_Searchbuttontext");
            Ddo_br_lab_reporttime_Caption = cgiGet( "DDO_BR_LAB_REPORTTIME_Caption");
            Ddo_br_lab_reporttime_Tooltip = cgiGet( "DDO_BR_LAB_REPORTTIME_Tooltip");
            Ddo_br_lab_reporttime_Cls = cgiGet( "DDO_BR_LAB_REPORTTIME_Cls");
            Ddo_br_lab_reporttime_Dropdownoptionstype = cgiGet( "DDO_BR_LAB_REPORTTIME_Dropdownoptionstype");
            Ddo_br_lab_reporttime_Titlecontrolidtoreplace = cgiGet( "DDO_BR_LAB_REPORTTIME_Titlecontrolidtoreplace");
            Ddo_br_lab_reporttime_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_REPORTTIME_Includesortasc"));
            Ddo_br_lab_reporttime_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_REPORTTIME_Includesortdsc"));
            Ddo_br_lab_reporttime_Sortedstatus = cgiGet( "DDO_BR_LAB_REPORTTIME_Sortedstatus");
            Ddo_br_lab_reporttime_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_REPORTTIME_Includefilter"));
            Ddo_br_lab_reporttime_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_REPORTTIME_Includedatalist"));
            Ddo_br_lab_reporttime_Sortasc = cgiGet( "DDO_BR_LAB_REPORTTIME_Sortasc");
            Ddo_br_lab_reporttime_Sortdsc = cgiGet( "DDO_BR_LAB_REPORTTIME_Sortdsc");
            Ddo_br_lab_reporttime_Searchbuttontext = cgiGet( "DDO_BR_LAB_REPORTTIME_Searchbuttontext");
            Ddo_br_lab_specimensource_Caption = cgiGet( "DDO_BR_LAB_SPECIMENSOURCE_Caption");
            Ddo_br_lab_specimensource_Tooltip = cgiGet( "DDO_BR_LAB_SPECIMENSOURCE_Tooltip");
            Ddo_br_lab_specimensource_Cls = cgiGet( "DDO_BR_LAB_SPECIMENSOURCE_Cls");
            Ddo_br_lab_specimensource_Dropdownoptionstype = cgiGet( "DDO_BR_LAB_SPECIMENSOURCE_Dropdownoptionstype");
            Ddo_br_lab_specimensource_Titlecontrolidtoreplace = cgiGet( "DDO_BR_LAB_SPECIMENSOURCE_Titlecontrolidtoreplace");
            Ddo_br_lab_specimensource_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_SPECIMENSOURCE_Includesortasc"));
            Ddo_br_lab_specimensource_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_SPECIMENSOURCE_Includesortdsc"));
            Ddo_br_lab_specimensource_Sortedstatus = cgiGet( "DDO_BR_LAB_SPECIMENSOURCE_Sortedstatus");
            Ddo_br_lab_specimensource_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_SPECIMENSOURCE_Includefilter"));
            Ddo_br_lab_specimensource_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_SPECIMENSOURCE_Includedatalist"));
            Ddo_br_lab_specimensource_Sortasc = cgiGet( "DDO_BR_LAB_SPECIMENSOURCE_Sortasc");
            Ddo_br_lab_specimensource_Sortdsc = cgiGet( "DDO_BR_LAB_SPECIMENSOURCE_Sortdsc");
            Ddo_br_lab_specimensource_Searchbuttontext = cgiGet( "DDO_BR_LAB_SPECIMENSOURCE_Searchbuttontext");
            Ddo_br_lab_resultqual_Caption = cgiGet( "DDO_BR_LAB_RESULTQUAL_Caption");
            Ddo_br_lab_resultqual_Tooltip = cgiGet( "DDO_BR_LAB_RESULTQUAL_Tooltip");
            Ddo_br_lab_resultqual_Cls = cgiGet( "DDO_BR_LAB_RESULTQUAL_Cls");
            Ddo_br_lab_resultqual_Dropdownoptionstype = cgiGet( "DDO_BR_LAB_RESULTQUAL_Dropdownoptionstype");
            Ddo_br_lab_resultqual_Titlecontrolidtoreplace = cgiGet( "DDO_BR_LAB_RESULTQUAL_Titlecontrolidtoreplace");
            Ddo_br_lab_resultqual_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_RESULTQUAL_Includesortasc"));
            Ddo_br_lab_resultqual_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_RESULTQUAL_Includesortdsc"));
            Ddo_br_lab_resultqual_Sortedstatus = cgiGet( "DDO_BR_LAB_RESULTQUAL_Sortedstatus");
            Ddo_br_lab_resultqual_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_RESULTQUAL_Includefilter"));
            Ddo_br_lab_resultqual_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_RESULTQUAL_Includedatalist"));
            Ddo_br_lab_resultqual_Sortasc = cgiGet( "DDO_BR_LAB_RESULTQUAL_Sortasc");
            Ddo_br_lab_resultqual_Sortdsc = cgiGet( "DDO_BR_LAB_RESULTQUAL_Sortdsc");
            Ddo_br_lab_resultqual_Searchbuttontext = cgiGet( "DDO_BR_LAB_RESULTQUAL_Searchbuttontext");
            Ddo_br_lab_resultnum_Caption = cgiGet( "DDO_BR_LAB_RESULTNUM_Caption");
            Ddo_br_lab_resultnum_Tooltip = cgiGet( "DDO_BR_LAB_RESULTNUM_Tooltip");
            Ddo_br_lab_resultnum_Cls = cgiGet( "DDO_BR_LAB_RESULTNUM_Cls");
            Ddo_br_lab_resultnum_Dropdownoptionstype = cgiGet( "DDO_BR_LAB_RESULTNUM_Dropdownoptionstype");
            Ddo_br_lab_resultnum_Titlecontrolidtoreplace = cgiGet( "DDO_BR_LAB_RESULTNUM_Titlecontrolidtoreplace");
            Ddo_br_lab_resultnum_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_RESULTNUM_Includesortasc"));
            Ddo_br_lab_resultnum_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_RESULTNUM_Includesortdsc"));
            Ddo_br_lab_resultnum_Sortedstatus = cgiGet( "DDO_BR_LAB_RESULTNUM_Sortedstatus");
            Ddo_br_lab_resultnum_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_RESULTNUM_Includefilter"));
            Ddo_br_lab_resultnum_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_RESULTNUM_Includedatalist"));
            Ddo_br_lab_resultnum_Sortasc = cgiGet( "DDO_BR_LAB_RESULTNUM_Sortasc");
            Ddo_br_lab_resultnum_Sortdsc = cgiGet( "DDO_BR_LAB_RESULTNUM_Sortdsc");
            Ddo_br_lab_resultnum_Searchbuttontext = cgiGet( "DDO_BR_LAB_RESULTNUM_Searchbuttontext");
            Ddo_br_lab_resultunit_Caption = cgiGet( "DDO_BR_LAB_RESULTUNIT_Caption");
            Ddo_br_lab_resultunit_Tooltip = cgiGet( "DDO_BR_LAB_RESULTUNIT_Tooltip");
            Ddo_br_lab_resultunit_Cls = cgiGet( "DDO_BR_LAB_RESULTUNIT_Cls");
            Ddo_br_lab_resultunit_Dropdownoptionstype = cgiGet( "DDO_BR_LAB_RESULTUNIT_Dropdownoptionstype");
            Ddo_br_lab_resultunit_Titlecontrolidtoreplace = cgiGet( "DDO_BR_LAB_RESULTUNIT_Titlecontrolidtoreplace");
            Ddo_br_lab_resultunit_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_RESULTUNIT_Includesortasc"));
            Ddo_br_lab_resultunit_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_RESULTUNIT_Includesortdsc"));
            Ddo_br_lab_resultunit_Sortedstatus = cgiGet( "DDO_BR_LAB_RESULTUNIT_Sortedstatus");
            Ddo_br_lab_resultunit_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_RESULTUNIT_Includefilter"));
            Ddo_br_lab_resultunit_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_RESULTUNIT_Includedatalist"));
            Ddo_br_lab_resultunit_Sortasc = cgiGet( "DDO_BR_LAB_RESULTUNIT_Sortasc");
            Ddo_br_lab_resultunit_Sortdsc = cgiGet( "DDO_BR_LAB_RESULTUNIT_Sortdsc");
            Ddo_br_lab_resultunit_Searchbuttontext = cgiGet( "DDO_BR_LAB_RESULTUNIT_Searchbuttontext");
            Ddo_br_lab_abnind_Caption = cgiGet( "DDO_BR_LAB_ABNIND_Caption");
            Ddo_br_lab_abnind_Tooltip = cgiGet( "DDO_BR_LAB_ABNIND_Tooltip");
            Ddo_br_lab_abnind_Cls = cgiGet( "DDO_BR_LAB_ABNIND_Cls");
            Ddo_br_lab_abnind_Dropdownoptionstype = cgiGet( "DDO_BR_LAB_ABNIND_Dropdownoptionstype");
            Ddo_br_lab_abnind_Titlecontrolidtoreplace = cgiGet( "DDO_BR_LAB_ABNIND_Titlecontrolidtoreplace");
            Ddo_br_lab_abnind_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_ABNIND_Includesortasc"));
            Ddo_br_lab_abnind_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_ABNIND_Includesortdsc"));
            Ddo_br_lab_abnind_Sortedstatus = cgiGet( "DDO_BR_LAB_ABNIND_Sortedstatus");
            Ddo_br_lab_abnind_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_ABNIND_Includefilter"));
            Ddo_br_lab_abnind_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_ABNIND_Includedatalist"));
            Ddo_br_lab_abnind_Sortasc = cgiGet( "DDO_BR_LAB_ABNIND_Sortasc");
            Ddo_br_lab_abnind_Sortdsc = cgiGet( "DDO_BR_LAB_ABNIND_Sortdsc");
            Ddo_br_lab_abnind_Searchbuttontext = cgiGet( "DDO_BR_LAB_ABNIND_Searchbuttontext");
            Ddo_br_lab_normrangelow_Caption = cgiGet( "DDO_BR_LAB_NORMRANGELOW_Caption");
            Ddo_br_lab_normrangelow_Tooltip = cgiGet( "DDO_BR_LAB_NORMRANGELOW_Tooltip");
            Ddo_br_lab_normrangelow_Cls = cgiGet( "DDO_BR_LAB_NORMRANGELOW_Cls");
            Ddo_br_lab_normrangelow_Dropdownoptionstype = cgiGet( "DDO_BR_LAB_NORMRANGELOW_Dropdownoptionstype");
            Ddo_br_lab_normrangelow_Titlecontrolidtoreplace = cgiGet( "DDO_BR_LAB_NORMRANGELOW_Titlecontrolidtoreplace");
            Ddo_br_lab_normrangelow_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_NORMRANGELOW_Includesortasc"));
            Ddo_br_lab_normrangelow_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_NORMRANGELOW_Includesortdsc"));
            Ddo_br_lab_normrangelow_Sortedstatus = cgiGet( "DDO_BR_LAB_NORMRANGELOW_Sortedstatus");
            Ddo_br_lab_normrangelow_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_NORMRANGELOW_Includefilter"));
            Ddo_br_lab_normrangelow_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_NORMRANGELOW_Includedatalist"));
            Ddo_br_lab_normrangelow_Sortasc = cgiGet( "DDO_BR_LAB_NORMRANGELOW_Sortasc");
            Ddo_br_lab_normrangelow_Sortdsc = cgiGet( "DDO_BR_LAB_NORMRANGELOW_Sortdsc");
            Ddo_br_lab_normrangelow_Searchbuttontext = cgiGet( "DDO_BR_LAB_NORMRANGELOW_Searchbuttontext");
            Ddo_br_lab_normrangehigh_Caption = cgiGet( "DDO_BR_LAB_NORMRANGEHIGH_Caption");
            Ddo_br_lab_normrangehigh_Tooltip = cgiGet( "DDO_BR_LAB_NORMRANGEHIGH_Tooltip");
            Ddo_br_lab_normrangehigh_Cls = cgiGet( "DDO_BR_LAB_NORMRANGEHIGH_Cls");
            Ddo_br_lab_normrangehigh_Dropdownoptionstype = cgiGet( "DDO_BR_LAB_NORMRANGEHIGH_Dropdownoptionstype");
            Ddo_br_lab_normrangehigh_Titlecontrolidtoreplace = cgiGet( "DDO_BR_LAB_NORMRANGEHIGH_Titlecontrolidtoreplace");
            Ddo_br_lab_normrangehigh_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_NORMRANGEHIGH_Includesortasc"));
            Ddo_br_lab_normrangehigh_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_NORMRANGEHIGH_Includesortdsc"));
            Ddo_br_lab_normrangehigh_Sortedstatus = cgiGet( "DDO_BR_LAB_NORMRANGEHIGH_Sortedstatus");
            Ddo_br_lab_normrangehigh_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_NORMRANGEHIGH_Includefilter"));
            Ddo_br_lab_normrangehigh_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_NORMRANGEHIGH_Includedatalist"));
            Ddo_br_lab_normrangehigh_Sortasc = cgiGet( "DDO_BR_LAB_NORMRANGEHIGH_Sortasc");
            Ddo_br_lab_normrangehigh_Sortdsc = cgiGet( "DDO_BR_LAB_NORMRANGEHIGH_Sortdsc");
            Ddo_br_lab_normrangehigh_Searchbuttontext = cgiGet( "DDO_BR_LAB_NORMRANGEHIGH_Searchbuttontext");
            Ddo_br_lab_testmethod_Caption = cgiGet( "DDO_BR_LAB_TESTMETHOD_Caption");
            Ddo_br_lab_testmethod_Tooltip = cgiGet( "DDO_BR_LAB_TESTMETHOD_Tooltip");
            Ddo_br_lab_testmethod_Cls = cgiGet( "DDO_BR_LAB_TESTMETHOD_Cls");
            Ddo_br_lab_testmethod_Dropdownoptionstype = cgiGet( "DDO_BR_LAB_TESTMETHOD_Dropdownoptionstype");
            Ddo_br_lab_testmethod_Titlecontrolidtoreplace = cgiGet( "DDO_BR_LAB_TESTMETHOD_Titlecontrolidtoreplace");
            Ddo_br_lab_testmethod_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_TESTMETHOD_Includesortasc"));
            Ddo_br_lab_testmethod_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_TESTMETHOD_Includesortdsc"));
            Ddo_br_lab_testmethod_Sortedstatus = cgiGet( "DDO_BR_LAB_TESTMETHOD_Sortedstatus");
            Ddo_br_lab_testmethod_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_TESTMETHOD_Includefilter"));
            Ddo_br_lab_testmethod_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_TESTMETHOD_Includedatalist"));
            Ddo_br_lab_testmethod_Sortasc = cgiGet( "DDO_BR_LAB_TESTMETHOD_Sortasc");
            Ddo_br_lab_testmethod_Sortdsc = cgiGet( "DDO_BR_LAB_TESTMETHOD_Sortdsc");
            Ddo_br_lab_testmethod_Searchbuttontext = cgiGet( "DDO_BR_LAB_TESTMETHOD_Searchbuttontext");
            Ddo_br_lab_instrumentname_Caption = cgiGet( "DDO_BR_LAB_INSTRUMENTNAME_Caption");
            Ddo_br_lab_instrumentname_Tooltip = cgiGet( "DDO_BR_LAB_INSTRUMENTNAME_Tooltip");
            Ddo_br_lab_instrumentname_Cls = cgiGet( "DDO_BR_LAB_INSTRUMENTNAME_Cls");
            Ddo_br_lab_instrumentname_Dropdownoptionstype = cgiGet( "DDO_BR_LAB_INSTRUMENTNAME_Dropdownoptionstype");
            Ddo_br_lab_instrumentname_Titlecontrolidtoreplace = cgiGet( "DDO_BR_LAB_INSTRUMENTNAME_Titlecontrolidtoreplace");
            Ddo_br_lab_instrumentname_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_INSTRUMENTNAME_Includesortasc"));
            Ddo_br_lab_instrumentname_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_INSTRUMENTNAME_Includesortdsc"));
            Ddo_br_lab_instrumentname_Sortedstatus = cgiGet( "DDO_BR_LAB_INSTRUMENTNAME_Sortedstatus");
            Ddo_br_lab_instrumentname_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_INSTRUMENTNAME_Includefilter"));
            Ddo_br_lab_instrumentname_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_INSTRUMENTNAME_Includedatalist"));
            Ddo_br_lab_instrumentname_Sortasc = cgiGet( "DDO_BR_LAB_INSTRUMENTNAME_Sortasc");
            Ddo_br_lab_instrumentname_Sortdsc = cgiGet( "DDO_BR_LAB_INSTRUMENTNAME_Sortdsc");
            Ddo_br_lab_instrumentname_Searchbuttontext = cgiGet( "DDO_BR_LAB_INSTRUMENTNAME_Searchbuttontext");
            Ddo_br_lab_instrumentcode_Caption = cgiGet( "DDO_BR_LAB_INSTRUMENTCODE_Caption");
            Ddo_br_lab_instrumentcode_Tooltip = cgiGet( "DDO_BR_LAB_INSTRUMENTCODE_Tooltip");
            Ddo_br_lab_instrumentcode_Cls = cgiGet( "DDO_BR_LAB_INSTRUMENTCODE_Cls");
            Ddo_br_lab_instrumentcode_Dropdownoptionstype = cgiGet( "DDO_BR_LAB_INSTRUMENTCODE_Dropdownoptionstype");
            Ddo_br_lab_instrumentcode_Titlecontrolidtoreplace = cgiGet( "DDO_BR_LAB_INSTRUMENTCODE_Titlecontrolidtoreplace");
            Ddo_br_lab_instrumentcode_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_INSTRUMENTCODE_Includesortasc"));
            Ddo_br_lab_instrumentcode_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_INSTRUMENTCODE_Includesortdsc"));
            Ddo_br_lab_instrumentcode_Sortedstatus = cgiGet( "DDO_BR_LAB_INSTRUMENTCODE_Sortedstatus");
            Ddo_br_lab_instrumentcode_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_INSTRUMENTCODE_Includefilter"));
            Ddo_br_lab_instrumentcode_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_LAB_INSTRUMENTCODE_Includedatalist"));
            Ddo_br_lab_instrumentcode_Sortasc = cgiGet( "DDO_BR_LAB_INSTRUMENTCODE_Sortasc");
            Ddo_br_lab_instrumentcode_Sortdsc = cgiGet( "DDO_BR_LAB_INSTRUMENTCODE_Sortdsc");
            Ddo_br_lab_instrumentcode_Searchbuttontext = cgiGet( "DDO_BR_LAB_INSTRUMENTCODE_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_labid_Activeeventkey = cgiGet( "DDO_BR_LABID_Activeeventkey");
            Ddo_br_encounterid_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTERID_Activeeventkey");
            Ddo_br_information_patientno_Activeeventkey = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey");
            Ddo_br_lab_sampleid_Activeeventkey = cgiGet( "DDO_BR_LAB_SAMPLEID_Activeeventkey");
            Ddo_br_lab_testid_Activeeventkey = cgiGet( "DDO_BR_LAB_TESTID_Activeeventkey");
            Ddo_br_lab_testcode_Activeeventkey = cgiGet( "DDO_BR_LAB_TESTCODE_Activeeventkey");
            Ddo_br_lab_testname_Activeeventkey = cgiGet( "DDO_BR_LAB_TESTNAME_Activeeventkey");
            Ddo_br_lab_testengname_Activeeventkey = cgiGet( "DDO_BR_LAB_TESTENGNAME_Activeeventkey");
            Ddo_br_lab_age_Activeeventkey = cgiGet( "DDO_BR_LAB_AGE_Activeeventkey");
            Ddo_br_lab_diag_Activeeventkey = cgiGet( "DDO_BR_LAB_DIAG_Activeeventkey");
            Ddo_br_lab_specimendate_Activeeventkey = cgiGet( "DDO_BR_LAB_SPECIMENDATE_Activeeventkey");
            Ddo_br_lab_receivingtime_Activeeventkey = cgiGet( "DDO_BR_LAB_RECEIVINGTIME_Activeeventkey");
            Ddo_br_lab_reporttime_Activeeventkey = cgiGet( "DDO_BR_LAB_REPORTTIME_Activeeventkey");
            Ddo_br_lab_specimensource_Activeeventkey = cgiGet( "DDO_BR_LAB_SPECIMENSOURCE_Activeeventkey");
            Ddo_br_lab_resultqual_Activeeventkey = cgiGet( "DDO_BR_LAB_RESULTQUAL_Activeeventkey");
            Ddo_br_lab_resultnum_Activeeventkey = cgiGet( "DDO_BR_LAB_RESULTNUM_Activeeventkey");
            Ddo_br_lab_resultunit_Activeeventkey = cgiGet( "DDO_BR_LAB_RESULTUNIT_Activeeventkey");
            Ddo_br_lab_abnind_Activeeventkey = cgiGet( "DDO_BR_LAB_ABNIND_Activeeventkey");
            Ddo_br_lab_normrangelow_Activeeventkey = cgiGet( "DDO_BR_LAB_NORMRANGELOW_Activeeventkey");
            Ddo_br_lab_normrangehigh_Activeeventkey = cgiGet( "DDO_BR_LAB_NORMRANGEHIGH_Activeeventkey");
            Ddo_br_lab_testmethod_Activeeventkey = cgiGet( "DDO_BR_LAB_TESTMETHOD_Activeeventkey");
            Ddo_br_lab_instrumentname_Activeeventkey = cgiGet( "DDO_BR_LAB_INSTRUMENTNAME_Activeeventkey");
            Ddo_br_lab_instrumentcode_Activeeventkey = cgiGet( "DDO_BR_LAB_INSTRUMENTCODE_Activeeventkey");
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
         E363H2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E363H2( )
      {
         /* Start Routine */
         GXt_boolean1 = AV5IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Lab", out  GXt_boolean1) ;
         AV5IsAuthorized = GXt_boolean1;
         if ( ! AV5IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV72Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         divTablemain_Height = 493;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTablemain_Internalname, "Height", StringUtil.LTrim( StringUtil.Str( (decimal)(divTablemain_Height), 9, 0)), true);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_br_labid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_LabID";
         ucDdo_br_labid.SendProperty(context, "", false, Ddo_br_labid_Internalname, "TitleControlIdToReplace", Ddo_br_labid_Titlecontrolidtoreplace);
         AV13ddo_BR_LabIDTitleControlIdToReplace = Ddo_br_labid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13ddo_BR_LabIDTitleControlIdToReplace", AV13ddo_BR_LabIDTitleControlIdToReplace);
         edtavDdo_br_labidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_labidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_labidtitlecontrolidtoreplace_Visible), 5, 0)), true);
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
         Ddo_br_lab_sampleid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Lab_SampleID";
         ucDdo_br_lab_sampleid.SendProperty(context, "", false, Ddo_br_lab_sampleid_Internalname, "TitleControlIdToReplace", Ddo_br_lab_sampleid_Titlecontrolidtoreplace);
         AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace = Ddo_br_lab_sampleid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace", AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace);
         edtavDdo_br_lab_sampleidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_lab_sampleidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_lab_sampleidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_lab_testid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Lab_TestID";
         ucDdo_br_lab_testid.SendProperty(context, "", false, Ddo_br_lab_testid_Internalname, "TitleControlIdToReplace", Ddo_br_lab_testid_Titlecontrolidtoreplace);
         AV19ddo_BR_Lab_TestIDTitleControlIdToReplace = Ddo_br_lab_testid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_Lab_TestIDTitleControlIdToReplace", AV19ddo_BR_Lab_TestIDTitleControlIdToReplace);
         edtavDdo_br_lab_testidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_lab_testidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_lab_testidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_lab_testcode_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Lab_TestCode";
         ucDdo_br_lab_testcode.SendProperty(context, "", false, Ddo_br_lab_testcode_Internalname, "TitleControlIdToReplace", Ddo_br_lab_testcode_Titlecontrolidtoreplace);
         AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace = Ddo_br_lab_testcode_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace", AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace);
         edtavDdo_br_lab_testcodetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_lab_testcodetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_lab_testcodetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_lab_testname_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Lab_TestName";
         ucDdo_br_lab_testname.SendProperty(context, "", false, Ddo_br_lab_testname_Internalname, "TitleControlIdToReplace", Ddo_br_lab_testname_Titlecontrolidtoreplace);
         AV23ddo_BR_Lab_TestNameTitleControlIdToReplace = Ddo_br_lab_testname_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_Lab_TestNameTitleControlIdToReplace", AV23ddo_BR_Lab_TestNameTitleControlIdToReplace);
         edtavDdo_br_lab_testnametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_lab_testnametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_lab_testnametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_lab_testengname_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Lab_TestEngName";
         ucDdo_br_lab_testengname.SendProperty(context, "", false, Ddo_br_lab_testengname_Internalname, "TitleControlIdToReplace", Ddo_br_lab_testengname_Titlecontrolidtoreplace);
         AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace = Ddo_br_lab_testengname_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace", AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace);
         edtavDdo_br_lab_testengnametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_lab_testengnametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_lab_testengnametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_lab_age_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Lab_Age";
         ucDdo_br_lab_age.SendProperty(context, "", false, Ddo_br_lab_age_Internalname, "TitleControlIdToReplace", Ddo_br_lab_age_Titlecontrolidtoreplace);
         AV63ddo_BR_Lab_AgeTitleControlIdToReplace = Ddo_br_lab_age_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV63ddo_BR_Lab_AgeTitleControlIdToReplace", AV63ddo_BR_Lab_AgeTitleControlIdToReplace);
         edtavDdo_br_lab_agetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_lab_agetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_lab_agetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_lab_diag_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Lab_Diag";
         ucDdo_br_lab_diag.SendProperty(context, "", false, Ddo_br_lab_diag_Internalname, "TitleControlIdToReplace", Ddo_br_lab_diag_Titlecontrolidtoreplace);
         AV65ddo_BR_Lab_DiagTitleControlIdToReplace = Ddo_br_lab_diag_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV65ddo_BR_Lab_DiagTitleControlIdToReplace", AV65ddo_BR_Lab_DiagTitleControlIdToReplace);
         edtavDdo_br_lab_diagtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_lab_diagtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_lab_diagtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_lab_specimendate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Lab_SpecimenDate";
         ucDdo_br_lab_specimendate.SendProperty(context, "", false, Ddo_br_lab_specimendate_Internalname, "TitleControlIdToReplace", Ddo_br_lab_specimendate_Titlecontrolidtoreplace);
         AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace = Ddo_br_lab_specimendate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace", AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace);
         edtavDdo_br_lab_specimendatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_lab_specimendatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_lab_specimendatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_lab_receivingtime_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Lab_ReceivingTime";
         ucDdo_br_lab_receivingtime.SendProperty(context, "", false, Ddo_br_lab_receivingtime_Internalname, "TitleControlIdToReplace", Ddo_br_lab_receivingtime_Titlecontrolidtoreplace);
         AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace = Ddo_br_lab_receivingtime_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace", AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace);
         edtavDdo_br_lab_receivingtimetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_lab_receivingtimetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_lab_receivingtimetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_lab_reporttime_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Lab_ReportTime";
         ucDdo_br_lab_reporttime.SendProperty(context, "", false, Ddo_br_lab_reporttime_Internalname, "TitleControlIdToReplace", Ddo_br_lab_reporttime_Titlecontrolidtoreplace);
         AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace = Ddo_br_lab_reporttime_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace", AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace);
         edtavDdo_br_lab_reporttimetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_lab_reporttimetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_lab_reporttimetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_lab_specimensource_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Lab_SpecimenSource";
         ucDdo_br_lab_specimensource.SendProperty(context, "", false, Ddo_br_lab_specimensource_Internalname, "TitleControlIdToReplace", Ddo_br_lab_specimensource_Titlecontrolidtoreplace);
         AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace = Ddo_br_lab_specimensource_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace", AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace);
         edtavDdo_br_lab_specimensourcetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_lab_specimensourcetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_lab_specimensourcetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_lab_resultqual_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Lab_ResultQual";
         ucDdo_br_lab_resultqual.SendProperty(context, "", false, Ddo_br_lab_resultqual_Internalname, "TitleControlIdToReplace", Ddo_br_lab_resultqual_Titlecontrolidtoreplace);
         AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace = Ddo_br_lab_resultqual_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace", AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace);
         edtavDdo_br_lab_resultqualtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_lab_resultqualtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_lab_resultqualtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_lab_resultnum_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Lab_ResultNum";
         ucDdo_br_lab_resultnum.SendProperty(context, "", false, Ddo_br_lab_resultnum_Internalname, "TitleControlIdToReplace", Ddo_br_lab_resultnum_Titlecontrolidtoreplace);
         AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace = Ddo_br_lab_resultnum_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace", AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace);
         edtavDdo_br_lab_resultnumtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_lab_resultnumtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_lab_resultnumtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_lab_resultunit_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Lab_ResultUnit";
         ucDdo_br_lab_resultunit.SendProperty(context, "", false, Ddo_br_lab_resultunit_Internalname, "TitleControlIdToReplace", Ddo_br_lab_resultunit_Titlecontrolidtoreplace);
         AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace = Ddo_br_lab_resultunit_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace", AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace);
         edtavDdo_br_lab_resultunittitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_lab_resultunittitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_lab_resultunittitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_lab_abnind_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Lab_AbnInd";
         ucDdo_br_lab_abnind.SendProperty(context, "", false, Ddo_br_lab_abnind_Internalname, "TitleControlIdToReplace", Ddo_br_lab_abnind_Titlecontrolidtoreplace);
         AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace = Ddo_br_lab_abnind_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace", AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace);
         edtavDdo_br_lab_abnindtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_lab_abnindtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_lab_abnindtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_lab_normrangelow_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Lab_NormRangeLow";
         ucDdo_br_lab_normrangelow.SendProperty(context, "", false, Ddo_br_lab_normrangelow_Internalname, "TitleControlIdToReplace", Ddo_br_lab_normrangelow_Titlecontrolidtoreplace);
         AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace = Ddo_br_lab_normrangelow_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace", AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace);
         edtavDdo_br_lab_normrangelowtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_lab_normrangelowtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_lab_normrangelowtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_lab_normrangehigh_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Lab_NormRangeHigh";
         ucDdo_br_lab_normrangehigh.SendProperty(context, "", false, Ddo_br_lab_normrangehigh_Internalname, "TitleControlIdToReplace", Ddo_br_lab_normrangehigh_Titlecontrolidtoreplace);
         AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace = Ddo_br_lab_normrangehigh_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace", AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace);
         edtavDdo_br_lab_normrangehightitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_lab_normrangehightitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_lab_normrangehightitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_lab_testmethod_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Lab_TestMethod";
         ucDdo_br_lab_testmethod.SendProperty(context, "", false, Ddo_br_lab_testmethod_Internalname, "TitleControlIdToReplace", Ddo_br_lab_testmethod_Titlecontrolidtoreplace);
         AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace = Ddo_br_lab_testmethod_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace", AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace);
         edtavDdo_br_lab_testmethodtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_lab_testmethodtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_lab_testmethodtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_lab_instrumentname_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Lab_InstrumentName";
         ucDdo_br_lab_instrumentname.SendProperty(context, "", false, Ddo_br_lab_instrumentname_Internalname, "TitleControlIdToReplace", Ddo_br_lab_instrumentname_Titlecontrolidtoreplace);
         AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace = Ddo_br_lab_instrumentname_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace", AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace);
         edtavDdo_br_lab_instrumentnametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_lab_instrumentnametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_lab_instrumentnametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_lab_instrumentcode_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Lab_InstrumentCode";
         ucDdo_br_lab_instrumentcode.SendProperty(context, "", false, Ddo_br_lab_instrumentcode_Internalname, "TitleControlIdToReplace", Ddo_br_lab_instrumentcode_Titlecontrolidtoreplace);
         AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace = Ddo_br_lab_instrumentcode_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace", AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace);
         edtavDdo_br_lab_instrumentcodetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_lab_instrumentcodetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_lab_instrumentcodetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "选择实验室检查";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV52DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV52DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E373H2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV12BR_LabIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV14BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV16BR_Information_PatientNoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV58BR_Lab_SampleIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV18BR_Lab_TestIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_Lab_TestCodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV22BR_Lab_TestNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV60BR_Lab_TestEngNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV62BR_Lab_AgeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV64BR_Lab_DiagTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_Lab_SpecimenDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV66BR_Lab_ReceivingTimeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV68BR_Lab_ReportTimeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV26BR_Lab_SpecimenSourceTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32BR_Lab_ResultQualTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV34BR_Lab_ResultNumTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV36BR_Lab_ResultUnitTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV38BR_Lab_AbnIndTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV40BR_Lab_NormRangeLowTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV42BR_Lab_NormRangeHighTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV44BR_Lab_TestMethodTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV48BR_Lab_InstrumentNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV50BR_Lab_InstrumentCodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         edtBR_LabID_Titleformat = 2;
         edtBR_LabID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "实验室检查主键", AV13ddo_BR_LabIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_LabID_Internalname, "Title", edtBR_LabID_Title, !bGXsfl_12_Refreshing);
         edtBR_EncounterID_Titleformat = 2;
         edtBR_EncounterID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊信息主键", AV15ddo_BR_EncounterIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Title", edtBR_EncounterID_Title, !bGXsfl_12_Refreshing);
         edtBR_Information_PatientNo_Titleformat = 2;
         edtBR_Information_PatientNo_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "患者编号", AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_PatientNo_Internalname, "Title", edtBR_Information_PatientNo_Title, !bGXsfl_12_Refreshing);
         edtBR_Lab_SampleID_Titleformat = 2;
         edtBR_Lab_SampleID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "ID", AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_SampleID_Internalname, "Title", edtBR_Lab_SampleID_Title, !bGXsfl_12_Refreshing);
         edtBR_Lab_TestID_Titleformat = 2;
         edtBR_Lab_TestID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "项目序号", AV19ddo_BR_Lab_TestIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_TestID_Internalname, "Title", edtBR_Lab_TestID_Title, !bGXsfl_12_Refreshing);
         edtBR_Lab_TestCode_Titleformat = 2;
         edtBR_Lab_TestCode_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "项目代码", AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_TestCode_Internalname, "Title", edtBR_Lab_TestCode_Title, !bGXsfl_12_Refreshing);
         edtBR_Lab_TestName_Titleformat = 2;
         edtBR_Lab_TestName_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "项目名称", AV23ddo_BR_Lab_TestNameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_TestName_Internalname, "Title", edtBR_Lab_TestName_Title, !bGXsfl_12_Refreshing);
         edtBR_Lab_TestEngName_Titleformat = 2;
         edtBR_Lab_TestEngName_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "项目英文名称", AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_TestEngName_Internalname, "Title", edtBR_Lab_TestEngName_Title, !bGXsfl_12_Refreshing);
         edtBR_Lab_Age_Titleformat = 2;
         edtBR_Lab_Age_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "年龄", AV63ddo_BR_Lab_AgeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_Age_Internalname, "Title", edtBR_Lab_Age_Title, !bGXsfl_12_Refreshing);
         edtBR_Lab_Diag_Titleformat = 2;
         edtBR_Lab_Diag_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "临床诊断", AV65ddo_BR_Lab_DiagTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_Diag_Internalname, "Title", edtBR_Lab_Diag_Title, !bGXsfl_12_Refreshing);
         edtBR_Lab_SpecimenDate_Titleformat = 2;
         edtBR_Lab_SpecimenDate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "采样时间", AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_SpecimenDate_Internalname, "Title", edtBR_Lab_SpecimenDate_Title, !bGXsfl_12_Refreshing);
         edtBR_Lab_ReceivingTime_Titleformat = 2;
         edtBR_Lab_ReceivingTime_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "接收时间", AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_ReceivingTime_Internalname, "Title", edtBR_Lab_ReceivingTime_Title, !bGXsfl_12_Refreshing);
         edtBR_Lab_ReportTime_Titleformat = 2;
         edtBR_Lab_ReportTime_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "报告时间", AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_ReportTime_Internalname, "Title", edtBR_Lab_ReportTime_Title, !bGXsfl_12_Refreshing);
         edtBR_Lab_SpecimenSource_Titleformat = 2;
         edtBR_Lab_SpecimenSource_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "标本种类", AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_SpecimenSource_Internalname, "Title", edtBR_Lab_SpecimenSource_Title, !bGXsfl_12_Refreshing);
         edtBR_Lab_ResultQual_Titleformat = 2;
         edtBR_Lab_ResultQual_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "定性结果", AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_ResultQual_Internalname, "Title", edtBR_Lab_ResultQual_Title, !bGXsfl_12_Refreshing);
         edtBR_Lab_ResultNum_Titleformat = 2;
         edtBR_Lab_ResultNum_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "定量结果", AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_ResultNum_Internalname, "Title", edtBR_Lab_ResultNum_Title, !bGXsfl_12_Refreshing);
         edtBR_Lab_ResultUnit_Titleformat = 2;
         edtBR_Lab_ResultUnit_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "结果单位", AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_ResultUnit_Internalname, "Title", edtBR_Lab_ResultUnit_Title, !bGXsfl_12_Refreshing);
         edtBR_Lab_AbnInd_Titleformat = 2;
         edtBR_Lab_AbnInd_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "结果提示", AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_AbnInd_Internalname, "Title", edtBR_Lab_AbnInd_Title, !bGXsfl_12_Refreshing);
         edtBR_Lab_NormRangeLow_Titleformat = 2;
         edtBR_Lab_NormRangeLow_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "参考值下限", AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_NormRangeLow_Internalname, "Title", edtBR_Lab_NormRangeLow_Title, !bGXsfl_12_Refreshing);
         edtBR_Lab_NormRangeHigh_Titleformat = 2;
         edtBR_Lab_NormRangeHigh_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "参考值上限", AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_NormRangeHigh_Internalname, "Title", edtBR_Lab_NormRangeHigh_Title, !bGXsfl_12_Refreshing);
         edtBR_Lab_TestMethod_Titleformat = 2;
         edtBR_Lab_TestMethod_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "检测方法", AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_TestMethod_Internalname, "Title", edtBR_Lab_TestMethod_Title, !bGXsfl_12_Refreshing);
         edtBR_Lab_InstrumentName_Titleformat = 2;
         edtBR_Lab_InstrumentName_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "设备名称", AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_InstrumentName_Internalname, "Title", edtBR_Lab_InstrumentName_Title, !bGXsfl_12_Refreshing);
         edtBR_Lab_InstrumentCode_Titleformat = 2;
         edtBR_Lab_InstrumentCode_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "设备编码", AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_InstrumentCode_Internalname, "Title", edtBR_Lab_InstrumentCode_Title, !bGXsfl_12_Refreshing);
         AV54GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV54GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV54GridCurrentPage), 10, 0)));
         AV55GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV55GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV55GridPageSize), 10, 0)));
         AV56GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV56GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_LabIDTitleFilterData", AV12BR_LabIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Lab_SampleIDTitleFilterData", AV58BR_Lab_SampleIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Lab_TestIDTitleFilterData", AV18BR_Lab_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Lab_TestCodeTitleFilterData", AV20BR_Lab_TestCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Lab_TestNameTitleFilterData", AV22BR_Lab_TestNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV60BR_Lab_TestEngNameTitleFilterData", AV60BR_Lab_TestEngNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Lab_AgeTitleFilterData", AV62BR_Lab_AgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV64BR_Lab_DiagTitleFilterData", AV64BR_Lab_DiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Lab_SpecimenDateTitleFilterData", AV24BR_Lab_SpecimenDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Lab_ReceivingTimeTitleFilterData", AV66BR_Lab_ReceivingTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68BR_Lab_ReportTimeTitleFilterData", AV68BR_Lab_ReportTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Lab_SpecimenSourceTitleFilterData", AV26BR_Lab_SpecimenSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Lab_ResultQualTitleFilterData", AV32BR_Lab_ResultQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Lab_ResultNumTitleFilterData", AV34BR_Lab_ResultNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Lab_ResultUnitTitleFilterData", AV36BR_Lab_ResultUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Lab_AbnIndTitleFilterData", AV38BR_Lab_AbnIndTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Lab_NormRangeLowTitleFilterData", AV40BR_Lab_NormRangeLowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Lab_NormRangeHighTitleFilterData", AV42BR_Lab_NormRangeHighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Lab_TestMethodTitleFilterData", AV44BR_Lab_TestMethodTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Lab_InstrumentNameTitleFilterData", AV48BR_Lab_InstrumentNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Lab_InstrumentCodeTitleFilterData", AV50BR_Lab_InstrumentCodeTitleFilterData);
      }

      protected void E113H2( )
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
            AV53PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV53PageToGo) ;
         }
      }

      protected void E123H2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E133H2( )
      {
         /* Ddo_br_labid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_labid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_labid_Sortedstatus = "ASC";
            ucDdo_br_labid.SendProperty(context, "", false, Ddo_br_labid_Internalname, "SortedStatus", Ddo_br_labid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_labid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_labid_Sortedstatus = "DSC";
            ucDdo_br_labid.SendProperty(context, "", false, Ddo_br_labid_Internalname, "SortedStatus", Ddo_br_labid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_LabIDTitleFilterData", AV12BR_LabIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Lab_SampleIDTitleFilterData", AV58BR_Lab_SampleIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Lab_TestIDTitleFilterData", AV18BR_Lab_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Lab_TestCodeTitleFilterData", AV20BR_Lab_TestCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Lab_TestNameTitleFilterData", AV22BR_Lab_TestNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV60BR_Lab_TestEngNameTitleFilterData", AV60BR_Lab_TestEngNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Lab_AgeTitleFilterData", AV62BR_Lab_AgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV64BR_Lab_DiagTitleFilterData", AV64BR_Lab_DiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Lab_SpecimenDateTitleFilterData", AV24BR_Lab_SpecimenDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Lab_ReceivingTimeTitleFilterData", AV66BR_Lab_ReceivingTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68BR_Lab_ReportTimeTitleFilterData", AV68BR_Lab_ReportTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Lab_SpecimenSourceTitleFilterData", AV26BR_Lab_SpecimenSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Lab_ResultQualTitleFilterData", AV32BR_Lab_ResultQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Lab_ResultNumTitleFilterData", AV34BR_Lab_ResultNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Lab_ResultUnitTitleFilterData", AV36BR_Lab_ResultUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Lab_AbnIndTitleFilterData", AV38BR_Lab_AbnIndTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Lab_NormRangeLowTitleFilterData", AV40BR_Lab_NormRangeLowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Lab_NormRangeHighTitleFilterData", AV42BR_Lab_NormRangeHighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Lab_TestMethodTitleFilterData", AV44BR_Lab_TestMethodTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Lab_InstrumentNameTitleFilterData", AV48BR_Lab_InstrumentNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Lab_InstrumentCodeTitleFilterData", AV50BR_Lab_InstrumentCodeTitleFilterData);
      }

      protected void E143H2( )
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
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_LabIDTitleFilterData", AV12BR_LabIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Lab_SampleIDTitleFilterData", AV58BR_Lab_SampleIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Lab_TestIDTitleFilterData", AV18BR_Lab_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Lab_TestCodeTitleFilterData", AV20BR_Lab_TestCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Lab_TestNameTitleFilterData", AV22BR_Lab_TestNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV60BR_Lab_TestEngNameTitleFilterData", AV60BR_Lab_TestEngNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Lab_AgeTitleFilterData", AV62BR_Lab_AgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV64BR_Lab_DiagTitleFilterData", AV64BR_Lab_DiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Lab_SpecimenDateTitleFilterData", AV24BR_Lab_SpecimenDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Lab_ReceivingTimeTitleFilterData", AV66BR_Lab_ReceivingTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68BR_Lab_ReportTimeTitleFilterData", AV68BR_Lab_ReportTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Lab_SpecimenSourceTitleFilterData", AV26BR_Lab_SpecimenSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Lab_ResultQualTitleFilterData", AV32BR_Lab_ResultQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Lab_ResultNumTitleFilterData", AV34BR_Lab_ResultNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Lab_ResultUnitTitleFilterData", AV36BR_Lab_ResultUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Lab_AbnIndTitleFilterData", AV38BR_Lab_AbnIndTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Lab_NormRangeLowTitleFilterData", AV40BR_Lab_NormRangeLowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Lab_NormRangeHighTitleFilterData", AV42BR_Lab_NormRangeHighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Lab_TestMethodTitleFilterData", AV44BR_Lab_TestMethodTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Lab_InstrumentNameTitleFilterData", AV48BR_Lab_InstrumentNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Lab_InstrumentCodeTitleFilterData", AV50BR_Lab_InstrumentCodeTitleFilterData);
      }

      protected void E153H2( )
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
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_LabIDTitleFilterData", AV12BR_LabIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Lab_SampleIDTitleFilterData", AV58BR_Lab_SampleIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Lab_TestIDTitleFilterData", AV18BR_Lab_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Lab_TestCodeTitleFilterData", AV20BR_Lab_TestCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Lab_TestNameTitleFilterData", AV22BR_Lab_TestNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV60BR_Lab_TestEngNameTitleFilterData", AV60BR_Lab_TestEngNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Lab_AgeTitleFilterData", AV62BR_Lab_AgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV64BR_Lab_DiagTitleFilterData", AV64BR_Lab_DiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Lab_SpecimenDateTitleFilterData", AV24BR_Lab_SpecimenDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Lab_ReceivingTimeTitleFilterData", AV66BR_Lab_ReceivingTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68BR_Lab_ReportTimeTitleFilterData", AV68BR_Lab_ReportTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Lab_SpecimenSourceTitleFilterData", AV26BR_Lab_SpecimenSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Lab_ResultQualTitleFilterData", AV32BR_Lab_ResultQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Lab_ResultNumTitleFilterData", AV34BR_Lab_ResultNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Lab_ResultUnitTitleFilterData", AV36BR_Lab_ResultUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Lab_AbnIndTitleFilterData", AV38BR_Lab_AbnIndTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Lab_NormRangeLowTitleFilterData", AV40BR_Lab_NormRangeLowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Lab_NormRangeHighTitleFilterData", AV42BR_Lab_NormRangeHighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Lab_TestMethodTitleFilterData", AV44BR_Lab_TestMethodTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Lab_InstrumentNameTitleFilterData", AV48BR_Lab_InstrumentNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Lab_InstrumentCodeTitleFilterData", AV50BR_Lab_InstrumentCodeTitleFilterData);
      }

      protected void E163H2( )
      {
         /* Ddo_br_lab_sampleid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_lab_sampleid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_sampleid_Sortedstatus = "ASC";
            ucDdo_br_lab_sampleid.SendProperty(context, "", false, Ddo_br_lab_sampleid_Internalname, "SortedStatus", Ddo_br_lab_sampleid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_lab_sampleid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_sampleid_Sortedstatus = "DSC";
            ucDdo_br_lab_sampleid.SendProperty(context, "", false, Ddo_br_lab_sampleid_Internalname, "SortedStatus", Ddo_br_lab_sampleid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_LabIDTitleFilterData", AV12BR_LabIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Lab_SampleIDTitleFilterData", AV58BR_Lab_SampleIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Lab_TestIDTitleFilterData", AV18BR_Lab_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Lab_TestCodeTitleFilterData", AV20BR_Lab_TestCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Lab_TestNameTitleFilterData", AV22BR_Lab_TestNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV60BR_Lab_TestEngNameTitleFilterData", AV60BR_Lab_TestEngNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Lab_AgeTitleFilterData", AV62BR_Lab_AgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV64BR_Lab_DiagTitleFilterData", AV64BR_Lab_DiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Lab_SpecimenDateTitleFilterData", AV24BR_Lab_SpecimenDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Lab_ReceivingTimeTitleFilterData", AV66BR_Lab_ReceivingTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68BR_Lab_ReportTimeTitleFilterData", AV68BR_Lab_ReportTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Lab_SpecimenSourceTitleFilterData", AV26BR_Lab_SpecimenSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Lab_ResultQualTitleFilterData", AV32BR_Lab_ResultQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Lab_ResultNumTitleFilterData", AV34BR_Lab_ResultNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Lab_ResultUnitTitleFilterData", AV36BR_Lab_ResultUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Lab_AbnIndTitleFilterData", AV38BR_Lab_AbnIndTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Lab_NormRangeLowTitleFilterData", AV40BR_Lab_NormRangeLowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Lab_NormRangeHighTitleFilterData", AV42BR_Lab_NormRangeHighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Lab_TestMethodTitleFilterData", AV44BR_Lab_TestMethodTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Lab_InstrumentNameTitleFilterData", AV48BR_Lab_InstrumentNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Lab_InstrumentCodeTitleFilterData", AV50BR_Lab_InstrumentCodeTitleFilterData);
      }

      protected void E173H2( )
      {
         /* Ddo_br_lab_testid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_lab_testid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_testid_Sortedstatus = "ASC";
            ucDdo_br_lab_testid.SendProperty(context, "", false, Ddo_br_lab_testid_Internalname, "SortedStatus", Ddo_br_lab_testid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_lab_testid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_testid_Sortedstatus = "DSC";
            ucDdo_br_lab_testid.SendProperty(context, "", false, Ddo_br_lab_testid_Internalname, "SortedStatus", Ddo_br_lab_testid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_LabIDTitleFilterData", AV12BR_LabIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Lab_SampleIDTitleFilterData", AV58BR_Lab_SampleIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Lab_TestIDTitleFilterData", AV18BR_Lab_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Lab_TestCodeTitleFilterData", AV20BR_Lab_TestCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Lab_TestNameTitleFilterData", AV22BR_Lab_TestNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV60BR_Lab_TestEngNameTitleFilterData", AV60BR_Lab_TestEngNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Lab_AgeTitleFilterData", AV62BR_Lab_AgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV64BR_Lab_DiagTitleFilterData", AV64BR_Lab_DiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Lab_SpecimenDateTitleFilterData", AV24BR_Lab_SpecimenDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Lab_ReceivingTimeTitleFilterData", AV66BR_Lab_ReceivingTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68BR_Lab_ReportTimeTitleFilterData", AV68BR_Lab_ReportTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Lab_SpecimenSourceTitleFilterData", AV26BR_Lab_SpecimenSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Lab_ResultQualTitleFilterData", AV32BR_Lab_ResultQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Lab_ResultNumTitleFilterData", AV34BR_Lab_ResultNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Lab_ResultUnitTitleFilterData", AV36BR_Lab_ResultUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Lab_AbnIndTitleFilterData", AV38BR_Lab_AbnIndTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Lab_NormRangeLowTitleFilterData", AV40BR_Lab_NormRangeLowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Lab_NormRangeHighTitleFilterData", AV42BR_Lab_NormRangeHighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Lab_TestMethodTitleFilterData", AV44BR_Lab_TestMethodTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Lab_InstrumentNameTitleFilterData", AV48BR_Lab_InstrumentNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Lab_InstrumentCodeTitleFilterData", AV50BR_Lab_InstrumentCodeTitleFilterData);
      }

      protected void E183H2( )
      {
         /* Ddo_br_lab_testcode_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_lab_testcode_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_testcode_Sortedstatus = "ASC";
            ucDdo_br_lab_testcode.SendProperty(context, "", false, Ddo_br_lab_testcode_Internalname, "SortedStatus", Ddo_br_lab_testcode_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_lab_testcode_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_testcode_Sortedstatus = "DSC";
            ucDdo_br_lab_testcode.SendProperty(context, "", false, Ddo_br_lab_testcode_Internalname, "SortedStatus", Ddo_br_lab_testcode_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_LabIDTitleFilterData", AV12BR_LabIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Lab_SampleIDTitleFilterData", AV58BR_Lab_SampleIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Lab_TestIDTitleFilterData", AV18BR_Lab_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Lab_TestCodeTitleFilterData", AV20BR_Lab_TestCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Lab_TestNameTitleFilterData", AV22BR_Lab_TestNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV60BR_Lab_TestEngNameTitleFilterData", AV60BR_Lab_TestEngNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Lab_AgeTitleFilterData", AV62BR_Lab_AgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV64BR_Lab_DiagTitleFilterData", AV64BR_Lab_DiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Lab_SpecimenDateTitleFilterData", AV24BR_Lab_SpecimenDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Lab_ReceivingTimeTitleFilterData", AV66BR_Lab_ReceivingTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68BR_Lab_ReportTimeTitleFilterData", AV68BR_Lab_ReportTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Lab_SpecimenSourceTitleFilterData", AV26BR_Lab_SpecimenSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Lab_ResultQualTitleFilterData", AV32BR_Lab_ResultQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Lab_ResultNumTitleFilterData", AV34BR_Lab_ResultNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Lab_ResultUnitTitleFilterData", AV36BR_Lab_ResultUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Lab_AbnIndTitleFilterData", AV38BR_Lab_AbnIndTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Lab_NormRangeLowTitleFilterData", AV40BR_Lab_NormRangeLowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Lab_NormRangeHighTitleFilterData", AV42BR_Lab_NormRangeHighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Lab_TestMethodTitleFilterData", AV44BR_Lab_TestMethodTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Lab_InstrumentNameTitleFilterData", AV48BR_Lab_InstrumentNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Lab_InstrumentCodeTitleFilterData", AV50BR_Lab_InstrumentCodeTitleFilterData);
      }

      protected void E193H2( )
      {
         /* Ddo_br_lab_testname_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_lab_testname_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_testname_Sortedstatus = "ASC";
            ucDdo_br_lab_testname.SendProperty(context, "", false, Ddo_br_lab_testname_Internalname, "SortedStatus", Ddo_br_lab_testname_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_lab_testname_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_testname_Sortedstatus = "DSC";
            ucDdo_br_lab_testname.SendProperty(context, "", false, Ddo_br_lab_testname_Internalname, "SortedStatus", Ddo_br_lab_testname_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_LabIDTitleFilterData", AV12BR_LabIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Lab_SampleIDTitleFilterData", AV58BR_Lab_SampleIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Lab_TestIDTitleFilterData", AV18BR_Lab_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Lab_TestCodeTitleFilterData", AV20BR_Lab_TestCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Lab_TestNameTitleFilterData", AV22BR_Lab_TestNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV60BR_Lab_TestEngNameTitleFilterData", AV60BR_Lab_TestEngNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Lab_AgeTitleFilterData", AV62BR_Lab_AgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV64BR_Lab_DiagTitleFilterData", AV64BR_Lab_DiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Lab_SpecimenDateTitleFilterData", AV24BR_Lab_SpecimenDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Lab_ReceivingTimeTitleFilterData", AV66BR_Lab_ReceivingTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68BR_Lab_ReportTimeTitleFilterData", AV68BR_Lab_ReportTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Lab_SpecimenSourceTitleFilterData", AV26BR_Lab_SpecimenSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Lab_ResultQualTitleFilterData", AV32BR_Lab_ResultQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Lab_ResultNumTitleFilterData", AV34BR_Lab_ResultNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Lab_ResultUnitTitleFilterData", AV36BR_Lab_ResultUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Lab_AbnIndTitleFilterData", AV38BR_Lab_AbnIndTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Lab_NormRangeLowTitleFilterData", AV40BR_Lab_NormRangeLowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Lab_NormRangeHighTitleFilterData", AV42BR_Lab_NormRangeHighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Lab_TestMethodTitleFilterData", AV44BR_Lab_TestMethodTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Lab_InstrumentNameTitleFilterData", AV48BR_Lab_InstrumentNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Lab_InstrumentCodeTitleFilterData", AV50BR_Lab_InstrumentCodeTitleFilterData);
      }

      protected void E203H2( )
      {
         /* Ddo_br_lab_testengname_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_lab_testengname_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_testengname_Sortedstatus = "ASC";
            ucDdo_br_lab_testengname.SendProperty(context, "", false, Ddo_br_lab_testengname_Internalname, "SortedStatus", Ddo_br_lab_testengname_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_lab_testengname_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_testengname_Sortedstatus = "DSC";
            ucDdo_br_lab_testengname.SendProperty(context, "", false, Ddo_br_lab_testengname_Internalname, "SortedStatus", Ddo_br_lab_testengname_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_LabIDTitleFilterData", AV12BR_LabIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Lab_SampleIDTitleFilterData", AV58BR_Lab_SampleIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Lab_TestIDTitleFilterData", AV18BR_Lab_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Lab_TestCodeTitleFilterData", AV20BR_Lab_TestCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Lab_TestNameTitleFilterData", AV22BR_Lab_TestNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV60BR_Lab_TestEngNameTitleFilterData", AV60BR_Lab_TestEngNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Lab_AgeTitleFilterData", AV62BR_Lab_AgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV64BR_Lab_DiagTitleFilterData", AV64BR_Lab_DiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Lab_SpecimenDateTitleFilterData", AV24BR_Lab_SpecimenDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Lab_ReceivingTimeTitleFilterData", AV66BR_Lab_ReceivingTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68BR_Lab_ReportTimeTitleFilterData", AV68BR_Lab_ReportTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Lab_SpecimenSourceTitleFilterData", AV26BR_Lab_SpecimenSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Lab_ResultQualTitleFilterData", AV32BR_Lab_ResultQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Lab_ResultNumTitleFilterData", AV34BR_Lab_ResultNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Lab_ResultUnitTitleFilterData", AV36BR_Lab_ResultUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Lab_AbnIndTitleFilterData", AV38BR_Lab_AbnIndTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Lab_NormRangeLowTitleFilterData", AV40BR_Lab_NormRangeLowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Lab_NormRangeHighTitleFilterData", AV42BR_Lab_NormRangeHighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Lab_TestMethodTitleFilterData", AV44BR_Lab_TestMethodTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Lab_InstrumentNameTitleFilterData", AV48BR_Lab_InstrumentNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Lab_InstrumentCodeTitleFilterData", AV50BR_Lab_InstrumentCodeTitleFilterData);
      }

      protected void E213H2( )
      {
         /* Ddo_br_lab_age_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_lab_age_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_age_Sortedstatus = "ASC";
            ucDdo_br_lab_age.SendProperty(context, "", false, Ddo_br_lab_age_Internalname, "SortedStatus", Ddo_br_lab_age_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_lab_age_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_age_Sortedstatus = "DSC";
            ucDdo_br_lab_age.SendProperty(context, "", false, Ddo_br_lab_age_Internalname, "SortedStatus", Ddo_br_lab_age_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_LabIDTitleFilterData", AV12BR_LabIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Lab_SampleIDTitleFilterData", AV58BR_Lab_SampleIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Lab_TestIDTitleFilterData", AV18BR_Lab_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Lab_TestCodeTitleFilterData", AV20BR_Lab_TestCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Lab_TestNameTitleFilterData", AV22BR_Lab_TestNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV60BR_Lab_TestEngNameTitleFilterData", AV60BR_Lab_TestEngNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Lab_AgeTitleFilterData", AV62BR_Lab_AgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV64BR_Lab_DiagTitleFilterData", AV64BR_Lab_DiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Lab_SpecimenDateTitleFilterData", AV24BR_Lab_SpecimenDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Lab_ReceivingTimeTitleFilterData", AV66BR_Lab_ReceivingTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68BR_Lab_ReportTimeTitleFilterData", AV68BR_Lab_ReportTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Lab_SpecimenSourceTitleFilterData", AV26BR_Lab_SpecimenSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Lab_ResultQualTitleFilterData", AV32BR_Lab_ResultQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Lab_ResultNumTitleFilterData", AV34BR_Lab_ResultNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Lab_ResultUnitTitleFilterData", AV36BR_Lab_ResultUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Lab_AbnIndTitleFilterData", AV38BR_Lab_AbnIndTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Lab_NormRangeLowTitleFilterData", AV40BR_Lab_NormRangeLowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Lab_NormRangeHighTitleFilterData", AV42BR_Lab_NormRangeHighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Lab_TestMethodTitleFilterData", AV44BR_Lab_TestMethodTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Lab_InstrumentNameTitleFilterData", AV48BR_Lab_InstrumentNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Lab_InstrumentCodeTitleFilterData", AV50BR_Lab_InstrumentCodeTitleFilterData);
      }

      protected void E223H2( )
      {
         /* Ddo_br_lab_diag_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_lab_diag_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 10;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_diag_Sortedstatus = "ASC";
            ucDdo_br_lab_diag.SendProperty(context, "", false, Ddo_br_lab_diag_Internalname, "SortedStatus", Ddo_br_lab_diag_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_lab_diag_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 10;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_diag_Sortedstatus = "DSC";
            ucDdo_br_lab_diag.SendProperty(context, "", false, Ddo_br_lab_diag_Internalname, "SortedStatus", Ddo_br_lab_diag_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_LabIDTitleFilterData", AV12BR_LabIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Lab_SampleIDTitleFilterData", AV58BR_Lab_SampleIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Lab_TestIDTitleFilterData", AV18BR_Lab_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Lab_TestCodeTitleFilterData", AV20BR_Lab_TestCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Lab_TestNameTitleFilterData", AV22BR_Lab_TestNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV60BR_Lab_TestEngNameTitleFilterData", AV60BR_Lab_TestEngNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Lab_AgeTitleFilterData", AV62BR_Lab_AgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV64BR_Lab_DiagTitleFilterData", AV64BR_Lab_DiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Lab_SpecimenDateTitleFilterData", AV24BR_Lab_SpecimenDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Lab_ReceivingTimeTitleFilterData", AV66BR_Lab_ReceivingTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68BR_Lab_ReportTimeTitleFilterData", AV68BR_Lab_ReportTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Lab_SpecimenSourceTitleFilterData", AV26BR_Lab_SpecimenSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Lab_ResultQualTitleFilterData", AV32BR_Lab_ResultQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Lab_ResultNumTitleFilterData", AV34BR_Lab_ResultNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Lab_ResultUnitTitleFilterData", AV36BR_Lab_ResultUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Lab_AbnIndTitleFilterData", AV38BR_Lab_AbnIndTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Lab_NormRangeLowTitleFilterData", AV40BR_Lab_NormRangeLowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Lab_NormRangeHighTitleFilterData", AV42BR_Lab_NormRangeHighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Lab_TestMethodTitleFilterData", AV44BR_Lab_TestMethodTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Lab_InstrumentNameTitleFilterData", AV48BR_Lab_InstrumentNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Lab_InstrumentCodeTitleFilterData", AV50BR_Lab_InstrumentCodeTitleFilterData);
      }

      protected void E233H2( )
      {
         /* Ddo_br_lab_specimendate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_lab_specimendate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_specimendate_Sortedstatus = "ASC";
            ucDdo_br_lab_specimendate.SendProperty(context, "", false, Ddo_br_lab_specimendate_Internalname, "SortedStatus", Ddo_br_lab_specimendate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_lab_specimendate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_specimendate_Sortedstatus = "DSC";
            ucDdo_br_lab_specimendate.SendProperty(context, "", false, Ddo_br_lab_specimendate_Internalname, "SortedStatus", Ddo_br_lab_specimendate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_LabIDTitleFilterData", AV12BR_LabIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Lab_SampleIDTitleFilterData", AV58BR_Lab_SampleIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Lab_TestIDTitleFilterData", AV18BR_Lab_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Lab_TestCodeTitleFilterData", AV20BR_Lab_TestCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Lab_TestNameTitleFilterData", AV22BR_Lab_TestNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV60BR_Lab_TestEngNameTitleFilterData", AV60BR_Lab_TestEngNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Lab_AgeTitleFilterData", AV62BR_Lab_AgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV64BR_Lab_DiagTitleFilterData", AV64BR_Lab_DiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Lab_SpecimenDateTitleFilterData", AV24BR_Lab_SpecimenDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Lab_ReceivingTimeTitleFilterData", AV66BR_Lab_ReceivingTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68BR_Lab_ReportTimeTitleFilterData", AV68BR_Lab_ReportTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Lab_SpecimenSourceTitleFilterData", AV26BR_Lab_SpecimenSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Lab_ResultQualTitleFilterData", AV32BR_Lab_ResultQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Lab_ResultNumTitleFilterData", AV34BR_Lab_ResultNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Lab_ResultUnitTitleFilterData", AV36BR_Lab_ResultUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Lab_AbnIndTitleFilterData", AV38BR_Lab_AbnIndTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Lab_NormRangeLowTitleFilterData", AV40BR_Lab_NormRangeLowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Lab_NormRangeHighTitleFilterData", AV42BR_Lab_NormRangeHighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Lab_TestMethodTitleFilterData", AV44BR_Lab_TestMethodTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Lab_InstrumentNameTitleFilterData", AV48BR_Lab_InstrumentNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Lab_InstrumentCodeTitleFilterData", AV50BR_Lab_InstrumentCodeTitleFilterData);
      }

      protected void E243H2( )
      {
         /* Ddo_br_lab_receivingtime_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_lab_receivingtime_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_receivingtime_Sortedstatus = "ASC";
            ucDdo_br_lab_receivingtime.SendProperty(context, "", false, Ddo_br_lab_receivingtime_Internalname, "SortedStatus", Ddo_br_lab_receivingtime_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_lab_receivingtime_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_receivingtime_Sortedstatus = "DSC";
            ucDdo_br_lab_receivingtime.SendProperty(context, "", false, Ddo_br_lab_receivingtime_Internalname, "SortedStatus", Ddo_br_lab_receivingtime_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_LabIDTitleFilterData", AV12BR_LabIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Lab_SampleIDTitleFilterData", AV58BR_Lab_SampleIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Lab_TestIDTitleFilterData", AV18BR_Lab_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Lab_TestCodeTitleFilterData", AV20BR_Lab_TestCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Lab_TestNameTitleFilterData", AV22BR_Lab_TestNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV60BR_Lab_TestEngNameTitleFilterData", AV60BR_Lab_TestEngNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Lab_AgeTitleFilterData", AV62BR_Lab_AgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV64BR_Lab_DiagTitleFilterData", AV64BR_Lab_DiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Lab_SpecimenDateTitleFilterData", AV24BR_Lab_SpecimenDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Lab_ReceivingTimeTitleFilterData", AV66BR_Lab_ReceivingTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68BR_Lab_ReportTimeTitleFilterData", AV68BR_Lab_ReportTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Lab_SpecimenSourceTitleFilterData", AV26BR_Lab_SpecimenSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Lab_ResultQualTitleFilterData", AV32BR_Lab_ResultQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Lab_ResultNumTitleFilterData", AV34BR_Lab_ResultNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Lab_ResultUnitTitleFilterData", AV36BR_Lab_ResultUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Lab_AbnIndTitleFilterData", AV38BR_Lab_AbnIndTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Lab_NormRangeLowTitleFilterData", AV40BR_Lab_NormRangeLowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Lab_NormRangeHighTitleFilterData", AV42BR_Lab_NormRangeHighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Lab_TestMethodTitleFilterData", AV44BR_Lab_TestMethodTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Lab_InstrumentNameTitleFilterData", AV48BR_Lab_InstrumentNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Lab_InstrumentCodeTitleFilterData", AV50BR_Lab_InstrumentCodeTitleFilterData);
      }

      protected void E253H2( )
      {
         /* Ddo_br_lab_reporttime_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_lab_reporttime_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 13;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_reporttime_Sortedstatus = "ASC";
            ucDdo_br_lab_reporttime.SendProperty(context, "", false, Ddo_br_lab_reporttime_Internalname, "SortedStatus", Ddo_br_lab_reporttime_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_lab_reporttime_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 13;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_reporttime_Sortedstatus = "DSC";
            ucDdo_br_lab_reporttime.SendProperty(context, "", false, Ddo_br_lab_reporttime_Internalname, "SortedStatus", Ddo_br_lab_reporttime_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_LabIDTitleFilterData", AV12BR_LabIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Lab_SampleIDTitleFilterData", AV58BR_Lab_SampleIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Lab_TestIDTitleFilterData", AV18BR_Lab_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Lab_TestCodeTitleFilterData", AV20BR_Lab_TestCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Lab_TestNameTitleFilterData", AV22BR_Lab_TestNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV60BR_Lab_TestEngNameTitleFilterData", AV60BR_Lab_TestEngNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Lab_AgeTitleFilterData", AV62BR_Lab_AgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV64BR_Lab_DiagTitleFilterData", AV64BR_Lab_DiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Lab_SpecimenDateTitleFilterData", AV24BR_Lab_SpecimenDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Lab_ReceivingTimeTitleFilterData", AV66BR_Lab_ReceivingTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68BR_Lab_ReportTimeTitleFilterData", AV68BR_Lab_ReportTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Lab_SpecimenSourceTitleFilterData", AV26BR_Lab_SpecimenSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Lab_ResultQualTitleFilterData", AV32BR_Lab_ResultQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Lab_ResultNumTitleFilterData", AV34BR_Lab_ResultNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Lab_ResultUnitTitleFilterData", AV36BR_Lab_ResultUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Lab_AbnIndTitleFilterData", AV38BR_Lab_AbnIndTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Lab_NormRangeLowTitleFilterData", AV40BR_Lab_NormRangeLowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Lab_NormRangeHighTitleFilterData", AV42BR_Lab_NormRangeHighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Lab_TestMethodTitleFilterData", AV44BR_Lab_TestMethodTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Lab_InstrumentNameTitleFilterData", AV48BR_Lab_InstrumentNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Lab_InstrumentCodeTitleFilterData", AV50BR_Lab_InstrumentCodeTitleFilterData);
      }

      protected void E263H2( )
      {
         /* Ddo_br_lab_specimensource_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_lab_specimensource_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 14;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_specimensource_Sortedstatus = "ASC";
            ucDdo_br_lab_specimensource.SendProperty(context, "", false, Ddo_br_lab_specimensource_Internalname, "SortedStatus", Ddo_br_lab_specimensource_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_lab_specimensource_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 14;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_specimensource_Sortedstatus = "DSC";
            ucDdo_br_lab_specimensource.SendProperty(context, "", false, Ddo_br_lab_specimensource_Internalname, "SortedStatus", Ddo_br_lab_specimensource_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_LabIDTitleFilterData", AV12BR_LabIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Lab_SampleIDTitleFilterData", AV58BR_Lab_SampleIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Lab_TestIDTitleFilterData", AV18BR_Lab_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Lab_TestCodeTitleFilterData", AV20BR_Lab_TestCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Lab_TestNameTitleFilterData", AV22BR_Lab_TestNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV60BR_Lab_TestEngNameTitleFilterData", AV60BR_Lab_TestEngNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Lab_AgeTitleFilterData", AV62BR_Lab_AgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV64BR_Lab_DiagTitleFilterData", AV64BR_Lab_DiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Lab_SpecimenDateTitleFilterData", AV24BR_Lab_SpecimenDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Lab_ReceivingTimeTitleFilterData", AV66BR_Lab_ReceivingTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68BR_Lab_ReportTimeTitleFilterData", AV68BR_Lab_ReportTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Lab_SpecimenSourceTitleFilterData", AV26BR_Lab_SpecimenSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Lab_ResultQualTitleFilterData", AV32BR_Lab_ResultQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Lab_ResultNumTitleFilterData", AV34BR_Lab_ResultNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Lab_ResultUnitTitleFilterData", AV36BR_Lab_ResultUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Lab_AbnIndTitleFilterData", AV38BR_Lab_AbnIndTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Lab_NormRangeLowTitleFilterData", AV40BR_Lab_NormRangeLowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Lab_NormRangeHighTitleFilterData", AV42BR_Lab_NormRangeHighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Lab_TestMethodTitleFilterData", AV44BR_Lab_TestMethodTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Lab_InstrumentNameTitleFilterData", AV48BR_Lab_InstrumentNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Lab_InstrumentCodeTitleFilterData", AV50BR_Lab_InstrumentCodeTitleFilterData);
      }

      protected void E273H2( )
      {
         /* Ddo_br_lab_resultqual_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_lab_resultqual_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 15;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_resultqual_Sortedstatus = "ASC";
            ucDdo_br_lab_resultqual.SendProperty(context, "", false, Ddo_br_lab_resultqual_Internalname, "SortedStatus", Ddo_br_lab_resultqual_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_lab_resultqual_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 15;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_resultqual_Sortedstatus = "DSC";
            ucDdo_br_lab_resultqual.SendProperty(context, "", false, Ddo_br_lab_resultqual_Internalname, "SortedStatus", Ddo_br_lab_resultqual_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_LabIDTitleFilterData", AV12BR_LabIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Lab_SampleIDTitleFilterData", AV58BR_Lab_SampleIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Lab_TestIDTitleFilterData", AV18BR_Lab_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Lab_TestCodeTitleFilterData", AV20BR_Lab_TestCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Lab_TestNameTitleFilterData", AV22BR_Lab_TestNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV60BR_Lab_TestEngNameTitleFilterData", AV60BR_Lab_TestEngNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Lab_AgeTitleFilterData", AV62BR_Lab_AgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV64BR_Lab_DiagTitleFilterData", AV64BR_Lab_DiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Lab_SpecimenDateTitleFilterData", AV24BR_Lab_SpecimenDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Lab_ReceivingTimeTitleFilterData", AV66BR_Lab_ReceivingTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68BR_Lab_ReportTimeTitleFilterData", AV68BR_Lab_ReportTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Lab_SpecimenSourceTitleFilterData", AV26BR_Lab_SpecimenSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Lab_ResultQualTitleFilterData", AV32BR_Lab_ResultQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Lab_ResultNumTitleFilterData", AV34BR_Lab_ResultNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Lab_ResultUnitTitleFilterData", AV36BR_Lab_ResultUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Lab_AbnIndTitleFilterData", AV38BR_Lab_AbnIndTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Lab_NormRangeLowTitleFilterData", AV40BR_Lab_NormRangeLowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Lab_NormRangeHighTitleFilterData", AV42BR_Lab_NormRangeHighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Lab_TestMethodTitleFilterData", AV44BR_Lab_TestMethodTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Lab_InstrumentNameTitleFilterData", AV48BR_Lab_InstrumentNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Lab_InstrumentCodeTitleFilterData", AV50BR_Lab_InstrumentCodeTitleFilterData);
      }

      protected void E283H2( )
      {
         /* Ddo_br_lab_resultnum_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_lab_resultnum_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 16;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_resultnum_Sortedstatus = "ASC";
            ucDdo_br_lab_resultnum.SendProperty(context, "", false, Ddo_br_lab_resultnum_Internalname, "SortedStatus", Ddo_br_lab_resultnum_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_lab_resultnum_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 16;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_resultnum_Sortedstatus = "DSC";
            ucDdo_br_lab_resultnum.SendProperty(context, "", false, Ddo_br_lab_resultnum_Internalname, "SortedStatus", Ddo_br_lab_resultnum_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_LabIDTitleFilterData", AV12BR_LabIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Lab_SampleIDTitleFilterData", AV58BR_Lab_SampleIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Lab_TestIDTitleFilterData", AV18BR_Lab_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Lab_TestCodeTitleFilterData", AV20BR_Lab_TestCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Lab_TestNameTitleFilterData", AV22BR_Lab_TestNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV60BR_Lab_TestEngNameTitleFilterData", AV60BR_Lab_TestEngNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Lab_AgeTitleFilterData", AV62BR_Lab_AgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV64BR_Lab_DiagTitleFilterData", AV64BR_Lab_DiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Lab_SpecimenDateTitleFilterData", AV24BR_Lab_SpecimenDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Lab_ReceivingTimeTitleFilterData", AV66BR_Lab_ReceivingTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68BR_Lab_ReportTimeTitleFilterData", AV68BR_Lab_ReportTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Lab_SpecimenSourceTitleFilterData", AV26BR_Lab_SpecimenSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Lab_ResultQualTitleFilterData", AV32BR_Lab_ResultQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Lab_ResultNumTitleFilterData", AV34BR_Lab_ResultNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Lab_ResultUnitTitleFilterData", AV36BR_Lab_ResultUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Lab_AbnIndTitleFilterData", AV38BR_Lab_AbnIndTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Lab_NormRangeLowTitleFilterData", AV40BR_Lab_NormRangeLowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Lab_NormRangeHighTitleFilterData", AV42BR_Lab_NormRangeHighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Lab_TestMethodTitleFilterData", AV44BR_Lab_TestMethodTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Lab_InstrumentNameTitleFilterData", AV48BR_Lab_InstrumentNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Lab_InstrumentCodeTitleFilterData", AV50BR_Lab_InstrumentCodeTitleFilterData);
      }

      protected void E293H2( )
      {
         /* Ddo_br_lab_resultunit_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_lab_resultunit_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 17;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_resultunit_Sortedstatus = "ASC";
            ucDdo_br_lab_resultunit.SendProperty(context, "", false, Ddo_br_lab_resultunit_Internalname, "SortedStatus", Ddo_br_lab_resultunit_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_lab_resultunit_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 17;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_resultunit_Sortedstatus = "DSC";
            ucDdo_br_lab_resultunit.SendProperty(context, "", false, Ddo_br_lab_resultunit_Internalname, "SortedStatus", Ddo_br_lab_resultunit_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_LabIDTitleFilterData", AV12BR_LabIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Lab_SampleIDTitleFilterData", AV58BR_Lab_SampleIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Lab_TestIDTitleFilterData", AV18BR_Lab_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Lab_TestCodeTitleFilterData", AV20BR_Lab_TestCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Lab_TestNameTitleFilterData", AV22BR_Lab_TestNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV60BR_Lab_TestEngNameTitleFilterData", AV60BR_Lab_TestEngNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Lab_AgeTitleFilterData", AV62BR_Lab_AgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV64BR_Lab_DiagTitleFilterData", AV64BR_Lab_DiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Lab_SpecimenDateTitleFilterData", AV24BR_Lab_SpecimenDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Lab_ReceivingTimeTitleFilterData", AV66BR_Lab_ReceivingTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68BR_Lab_ReportTimeTitleFilterData", AV68BR_Lab_ReportTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Lab_SpecimenSourceTitleFilterData", AV26BR_Lab_SpecimenSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Lab_ResultQualTitleFilterData", AV32BR_Lab_ResultQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Lab_ResultNumTitleFilterData", AV34BR_Lab_ResultNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Lab_ResultUnitTitleFilterData", AV36BR_Lab_ResultUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Lab_AbnIndTitleFilterData", AV38BR_Lab_AbnIndTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Lab_NormRangeLowTitleFilterData", AV40BR_Lab_NormRangeLowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Lab_NormRangeHighTitleFilterData", AV42BR_Lab_NormRangeHighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Lab_TestMethodTitleFilterData", AV44BR_Lab_TestMethodTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Lab_InstrumentNameTitleFilterData", AV48BR_Lab_InstrumentNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Lab_InstrumentCodeTitleFilterData", AV50BR_Lab_InstrumentCodeTitleFilterData);
      }

      protected void E303H2( )
      {
         /* Ddo_br_lab_abnind_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_lab_abnind_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 18;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_abnind_Sortedstatus = "ASC";
            ucDdo_br_lab_abnind.SendProperty(context, "", false, Ddo_br_lab_abnind_Internalname, "SortedStatus", Ddo_br_lab_abnind_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_lab_abnind_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 18;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_abnind_Sortedstatus = "DSC";
            ucDdo_br_lab_abnind.SendProperty(context, "", false, Ddo_br_lab_abnind_Internalname, "SortedStatus", Ddo_br_lab_abnind_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_LabIDTitleFilterData", AV12BR_LabIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Lab_SampleIDTitleFilterData", AV58BR_Lab_SampleIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Lab_TestIDTitleFilterData", AV18BR_Lab_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Lab_TestCodeTitleFilterData", AV20BR_Lab_TestCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Lab_TestNameTitleFilterData", AV22BR_Lab_TestNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV60BR_Lab_TestEngNameTitleFilterData", AV60BR_Lab_TestEngNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Lab_AgeTitleFilterData", AV62BR_Lab_AgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV64BR_Lab_DiagTitleFilterData", AV64BR_Lab_DiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Lab_SpecimenDateTitleFilterData", AV24BR_Lab_SpecimenDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Lab_ReceivingTimeTitleFilterData", AV66BR_Lab_ReceivingTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68BR_Lab_ReportTimeTitleFilterData", AV68BR_Lab_ReportTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Lab_SpecimenSourceTitleFilterData", AV26BR_Lab_SpecimenSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Lab_ResultQualTitleFilterData", AV32BR_Lab_ResultQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Lab_ResultNumTitleFilterData", AV34BR_Lab_ResultNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Lab_ResultUnitTitleFilterData", AV36BR_Lab_ResultUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Lab_AbnIndTitleFilterData", AV38BR_Lab_AbnIndTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Lab_NormRangeLowTitleFilterData", AV40BR_Lab_NormRangeLowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Lab_NormRangeHighTitleFilterData", AV42BR_Lab_NormRangeHighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Lab_TestMethodTitleFilterData", AV44BR_Lab_TestMethodTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Lab_InstrumentNameTitleFilterData", AV48BR_Lab_InstrumentNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Lab_InstrumentCodeTitleFilterData", AV50BR_Lab_InstrumentCodeTitleFilterData);
      }

      protected void E313H2( )
      {
         /* Ddo_br_lab_normrangelow_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_lab_normrangelow_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 19;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_normrangelow_Sortedstatus = "ASC";
            ucDdo_br_lab_normrangelow.SendProperty(context, "", false, Ddo_br_lab_normrangelow_Internalname, "SortedStatus", Ddo_br_lab_normrangelow_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_lab_normrangelow_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 19;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_normrangelow_Sortedstatus = "DSC";
            ucDdo_br_lab_normrangelow.SendProperty(context, "", false, Ddo_br_lab_normrangelow_Internalname, "SortedStatus", Ddo_br_lab_normrangelow_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_LabIDTitleFilterData", AV12BR_LabIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Lab_SampleIDTitleFilterData", AV58BR_Lab_SampleIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Lab_TestIDTitleFilterData", AV18BR_Lab_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Lab_TestCodeTitleFilterData", AV20BR_Lab_TestCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Lab_TestNameTitleFilterData", AV22BR_Lab_TestNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV60BR_Lab_TestEngNameTitleFilterData", AV60BR_Lab_TestEngNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Lab_AgeTitleFilterData", AV62BR_Lab_AgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV64BR_Lab_DiagTitleFilterData", AV64BR_Lab_DiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Lab_SpecimenDateTitleFilterData", AV24BR_Lab_SpecimenDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Lab_ReceivingTimeTitleFilterData", AV66BR_Lab_ReceivingTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68BR_Lab_ReportTimeTitleFilterData", AV68BR_Lab_ReportTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Lab_SpecimenSourceTitleFilterData", AV26BR_Lab_SpecimenSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Lab_ResultQualTitleFilterData", AV32BR_Lab_ResultQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Lab_ResultNumTitleFilterData", AV34BR_Lab_ResultNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Lab_ResultUnitTitleFilterData", AV36BR_Lab_ResultUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Lab_AbnIndTitleFilterData", AV38BR_Lab_AbnIndTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Lab_NormRangeLowTitleFilterData", AV40BR_Lab_NormRangeLowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Lab_NormRangeHighTitleFilterData", AV42BR_Lab_NormRangeHighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Lab_TestMethodTitleFilterData", AV44BR_Lab_TestMethodTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Lab_InstrumentNameTitleFilterData", AV48BR_Lab_InstrumentNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Lab_InstrumentCodeTitleFilterData", AV50BR_Lab_InstrumentCodeTitleFilterData);
      }

      protected void E323H2( )
      {
         /* Ddo_br_lab_normrangehigh_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_lab_normrangehigh_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 20;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_normrangehigh_Sortedstatus = "ASC";
            ucDdo_br_lab_normrangehigh.SendProperty(context, "", false, Ddo_br_lab_normrangehigh_Internalname, "SortedStatus", Ddo_br_lab_normrangehigh_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_lab_normrangehigh_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 20;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_normrangehigh_Sortedstatus = "DSC";
            ucDdo_br_lab_normrangehigh.SendProperty(context, "", false, Ddo_br_lab_normrangehigh_Internalname, "SortedStatus", Ddo_br_lab_normrangehigh_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_LabIDTitleFilterData", AV12BR_LabIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Lab_SampleIDTitleFilterData", AV58BR_Lab_SampleIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Lab_TestIDTitleFilterData", AV18BR_Lab_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Lab_TestCodeTitleFilterData", AV20BR_Lab_TestCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Lab_TestNameTitleFilterData", AV22BR_Lab_TestNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV60BR_Lab_TestEngNameTitleFilterData", AV60BR_Lab_TestEngNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Lab_AgeTitleFilterData", AV62BR_Lab_AgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV64BR_Lab_DiagTitleFilterData", AV64BR_Lab_DiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Lab_SpecimenDateTitleFilterData", AV24BR_Lab_SpecimenDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Lab_ReceivingTimeTitleFilterData", AV66BR_Lab_ReceivingTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68BR_Lab_ReportTimeTitleFilterData", AV68BR_Lab_ReportTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Lab_SpecimenSourceTitleFilterData", AV26BR_Lab_SpecimenSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Lab_ResultQualTitleFilterData", AV32BR_Lab_ResultQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Lab_ResultNumTitleFilterData", AV34BR_Lab_ResultNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Lab_ResultUnitTitleFilterData", AV36BR_Lab_ResultUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Lab_AbnIndTitleFilterData", AV38BR_Lab_AbnIndTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Lab_NormRangeLowTitleFilterData", AV40BR_Lab_NormRangeLowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Lab_NormRangeHighTitleFilterData", AV42BR_Lab_NormRangeHighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Lab_TestMethodTitleFilterData", AV44BR_Lab_TestMethodTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Lab_InstrumentNameTitleFilterData", AV48BR_Lab_InstrumentNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Lab_InstrumentCodeTitleFilterData", AV50BR_Lab_InstrumentCodeTitleFilterData);
      }

      protected void E333H2( )
      {
         /* Ddo_br_lab_testmethod_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_lab_testmethod_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 21;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_testmethod_Sortedstatus = "ASC";
            ucDdo_br_lab_testmethod.SendProperty(context, "", false, Ddo_br_lab_testmethod_Internalname, "SortedStatus", Ddo_br_lab_testmethod_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_lab_testmethod_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 21;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_testmethod_Sortedstatus = "DSC";
            ucDdo_br_lab_testmethod.SendProperty(context, "", false, Ddo_br_lab_testmethod_Internalname, "SortedStatus", Ddo_br_lab_testmethod_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_LabIDTitleFilterData", AV12BR_LabIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Lab_SampleIDTitleFilterData", AV58BR_Lab_SampleIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Lab_TestIDTitleFilterData", AV18BR_Lab_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Lab_TestCodeTitleFilterData", AV20BR_Lab_TestCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Lab_TestNameTitleFilterData", AV22BR_Lab_TestNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV60BR_Lab_TestEngNameTitleFilterData", AV60BR_Lab_TestEngNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Lab_AgeTitleFilterData", AV62BR_Lab_AgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV64BR_Lab_DiagTitleFilterData", AV64BR_Lab_DiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Lab_SpecimenDateTitleFilterData", AV24BR_Lab_SpecimenDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Lab_ReceivingTimeTitleFilterData", AV66BR_Lab_ReceivingTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68BR_Lab_ReportTimeTitleFilterData", AV68BR_Lab_ReportTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Lab_SpecimenSourceTitleFilterData", AV26BR_Lab_SpecimenSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Lab_ResultQualTitleFilterData", AV32BR_Lab_ResultQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Lab_ResultNumTitleFilterData", AV34BR_Lab_ResultNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Lab_ResultUnitTitleFilterData", AV36BR_Lab_ResultUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Lab_AbnIndTitleFilterData", AV38BR_Lab_AbnIndTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Lab_NormRangeLowTitleFilterData", AV40BR_Lab_NormRangeLowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Lab_NormRangeHighTitleFilterData", AV42BR_Lab_NormRangeHighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Lab_TestMethodTitleFilterData", AV44BR_Lab_TestMethodTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Lab_InstrumentNameTitleFilterData", AV48BR_Lab_InstrumentNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Lab_InstrumentCodeTitleFilterData", AV50BR_Lab_InstrumentCodeTitleFilterData);
      }

      protected void E343H2( )
      {
         /* Ddo_br_lab_instrumentname_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_lab_instrumentname_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 22;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_instrumentname_Sortedstatus = "ASC";
            ucDdo_br_lab_instrumentname.SendProperty(context, "", false, Ddo_br_lab_instrumentname_Internalname, "SortedStatus", Ddo_br_lab_instrumentname_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_lab_instrumentname_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 22;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_instrumentname_Sortedstatus = "DSC";
            ucDdo_br_lab_instrumentname.SendProperty(context, "", false, Ddo_br_lab_instrumentname_Internalname, "SortedStatus", Ddo_br_lab_instrumentname_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_LabIDTitleFilterData", AV12BR_LabIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Lab_SampleIDTitleFilterData", AV58BR_Lab_SampleIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Lab_TestIDTitleFilterData", AV18BR_Lab_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Lab_TestCodeTitleFilterData", AV20BR_Lab_TestCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Lab_TestNameTitleFilterData", AV22BR_Lab_TestNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV60BR_Lab_TestEngNameTitleFilterData", AV60BR_Lab_TestEngNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Lab_AgeTitleFilterData", AV62BR_Lab_AgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV64BR_Lab_DiagTitleFilterData", AV64BR_Lab_DiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Lab_SpecimenDateTitleFilterData", AV24BR_Lab_SpecimenDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Lab_ReceivingTimeTitleFilterData", AV66BR_Lab_ReceivingTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68BR_Lab_ReportTimeTitleFilterData", AV68BR_Lab_ReportTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Lab_SpecimenSourceTitleFilterData", AV26BR_Lab_SpecimenSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Lab_ResultQualTitleFilterData", AV32BR_Lab_ResultQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Lab_ResultNumTitleFilterData", AV34BR_Lab_ResultNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Lab_ResultUnitTitleFilterData", AV36BR_Lab_ResultUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Lab_AbnIndTitleFilterData", AV38BR_Lab_AbnIndTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Lab_NormRangeLowTitleFilterData", AV40BR_Lab_NormRangeLowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Lab_NormRangeHighTitleFilterData", AV42BR_Lab_NormRangeHighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Lab_TestMethodTitleFilterData", AV44BR_Lab_TestMethodTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Lab_InstrumentNameTitleFilterData", AV48BR_Lab_InstrumentNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Lab_InstrumentCodeTitleFilterData", AV50BR_Lab_InstrumentCodeTitleFilterData);
      }

      protected void E353H2( )
      {
         /* Ddo_br_lab_instrumentcode_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_lab_instrumentcode_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 23;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_instrumentcode_Sortedstatus = "ASC";
            ucDdo_br_lab_instrumentcode.SendProperty(context, "", false, Ddo_br_lab_instrumentcode_Internalname, "SortedStatus", Ddo_br_lab_instrumentcode_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_lab_instrumentcode_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 23;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_lab_instrumentcode_Sortedstatus = "DSC";
            ucDdo_br_lab_instrumentcode.SendProperty(context, "", false, Ddo_br_lab_instrumentcode_Internalname, "SortedStatus", Ddo_br_lab_instrumentcode_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_LabIDTitleFilterData", AV12BR_LabIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Lab_SampleIDTitleFilterData", AV58BR_Lab_SampleIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Lab_TestIDTitleFilterData", AV18BR_Lab_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Lab_TestCodeTitleFilterData", AV20BR_Lab_TestCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Lab_TestNameTitleFilterData", AV22BR_Lab_TestNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV60BR_Lab_TestEngNameTitleFilterData", AV60BR_Lab_TestEngNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Lab_AgeTitleFilterData", AV62BR_Lab_AgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV64BR_Lab_DiagTitleFilterData", AV64BR_Lab_DiagTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Lab_SpecimenDateTitleFilterData", AV24BR_Lab_SpecimenDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Lab_ReceivingTimeTitleFilterData", AV66BR_Lab_ReceivingTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV68BR_Lab_ReportTimeTitleFilterData", AV68BR_Lab_ReportTimeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Lab_SpecimenSourceTitleFilterData", AV26BR_Lab_SpecimenSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Lab_ResultQualTitleFilterData", AV32BR_Lab_ResultQualTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Lab_ResultNumTitleFilterData", AV34BR_Lab_ResultNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Lab_ResultUnitTitleFilterData", AV36BR_Lab_ResultUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Lab_AbnIndTitleFilterData", AV38BR_Lab_AbnIndTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Lab_NormRangeLowTitleFilterData", AV40BR_Lab_NormRangeLowTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Lab_NormRangeHighTitleFilterData", AV42BR_Lab_NormRangeHighTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Lab_TestMethodTitleFilterData", AV44BR_Lab_TestMethodTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Lab_InstrumentNameTitleFilterData", AV48BR_Lab_InstrumentNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Lab_InstrumentCodeTitleFilterData", AV50BR_Lab_InstrumentCodeTitleFilterData);
      }

      private void E383H2( )
      {
         /* Grid_Load Routine */
         AV57Select = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSelect_Internalname, AV57Select);
         AV73Select_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
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
         E393H2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E393H2( )
      {
         /* Enter Routine */
         AV8InOutBR_LabID = A101BR_LabID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_LabID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_LabID), 18, 0)));
         context.setWebReturnParms(new Object[] {(long)AV8InOutBR_LabID});
         context.setWebReturnParmsMetadata(new Object[] {"AV8InOutBR_LabID"});
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
         AV8InOutBR_LabID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_LabID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_LabID), 18, 0)));
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
         PA3H2( ) ;
         WS3H2( ) ;
         WE3H2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202271212669", true);
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
         context.AddJavascriptSource("br_labprompt.js", "?20202271212669", false);
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
         edtBR_LabID_Internalname = "BR_LABID_"+sGXsfl_12_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_12_idx;
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO_"+sGXsfl_12_idx;
         edtBR_Lab_SampleID_Internalname = "BR_LAB_SAMPLEID_"+sGXsfl_12_idx;
         edtBR_Lab_TestID_Internalname = "BR_LAB_TESTID_"+sGXsfl_12_idx;
         edtBR_Lab_TestCode_Internalname = "BR_LAB_TESTCODE_"+sGXsfl_12_idx;
         edtBR_Lab_TestName_Internalname = "BR_LAB_TESTNAME_"+sGXsfl_12_idx;
         edtBR_Lab_TestEngName_Internalname = "BR_LAB_TESTENGNAME_"+sGXsfl_12_idx;
         edtBR_Lab_Age_Internalname = "BR_LAB_AGE_"+sGXsfl_12_idx;
         edtBR_Lab_Diag_Internalname = "BR_LAB_DIAG_"+sGXsfl_12_idx;
         edtBR_Lab_SpecimenDate_Internalname = "BR_LAB_SPECIMENDATE_"+sGXsfl_12_idx;
         edtBR_Lab_ReceivingTime_Internalname = "BR_LAB_RECEIVINGTIME_"+sGXsfl_12_idx;
         edtBR_Lab_ReportTime_Internalname = "BR_LAB_REPORTTIME_"+sGXsfl_12_idx;
         edtBR_Lab_SpecimenSource_Internalname = "BR_LAB_SPECIMENSOURCE_"+sGXsfl_12_idx;
         edtBR_Lab_ResultQual_Internalname = "BR_LAB_RESULTQUAL_"+sGXsfl_12_idx;
         edtBR_Lab_ResultNum_Internalname = "BR_LAB_RESULTNUM_"+sGXsfl_12_idx;
         edtBR_Lab_ResultUnit_Internalname = "BR_LAB_RESULTUNIT_"+sGXsfl_12_idx;
         edtBR_Lab_AbnInd_Internalname = "BR_LAB_ABNIND_"+sGXsfl_12_idx;
         edtBR_Lab_NormRangeLow_Internalname = "BR_LAB_NORMRANGELOW_"+sGXsfl_12_idx;
         edtBR_Lab_NormRangeHigh_Internalname = "BR_LAB_NORMRANGEHIGH_"+sGXsfl_12_idx;
         edtBR_Lab_TestMethod_Internalname = "BR_LAB_TESTMETHOD_"+sGXsfl_12_idx;
         edtBR_Lab_InstrumentName_Internalname = "BR_LAB_INSTRUMENTNAME_"+sGXsfl_12_idx;
         edtBR_Lab_InstrumentCode_Internalname = "BR_LAB_INSTRUMENTCODE_"+sGXsfl_12_idx;
      }

      protected void SubsflControlProps_fel_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_fel_idx;
         edtBR_LabID_Internalname = "BR_LABID_"+sGXsfl_12_fel_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_12_fel_idx;
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO_"+sGXsfl_12_fel_idx;
         edtBR_Lab_SampleID_Internalname = "BR_LAB_SAMPLEID_"+sGXsfl_12_fel_idx;
         edtBR_Lab_TestID_Internalname = "BR_LAB_TESTID_"+sGXsfl_12_fel_idx;
         edtBR_Lab_TestCode_Internalname = "BR_LAB_TESTCODE_"+sGXsfl_12_fel_idx;
         edtBR_Lab_TestName_Internalname = "BR_LAB_TESTNAME_"+sGXsfl_12_fel_idx;
         edtBR_Lab_TestEngName_Internalname = "BR_LAB_TESTENGNAME_"+sGXsfl_12_fel_idx;
         edtBR_Lab_Age_Internalname = "BR_LAB_AGE_"+sGXsfl_12_fel_idx;
         edtBR_Lab_Diag_Internalname = "BR_LAB_DIAG_"+sGXsfl_12_fel_idx;
         edtBR_Lab_SpecimenDate_Internalname = "BR_LAB_SPECIMENDATE_"+sGXsfl_12_fel_idx;
         edtBR_Lab_ReceivingTime_Internalname = "BR_LAB_RECEIVINGTIME_"+sGXsfl_12_fel_idx;
         edtBR_Lab_ReportTime_Internalname = "BR_LAB_REPORTTIME_"+sGXsfl_12_fel_idx;
         edtBR_Lab_SpecimenSource_Internalname = "BR_LAB_SPECIMENSOURCE_"+sGXsfl_12_fel_idx;
         edtBR_Lab_ResultQual_Internalname = "BR_LAB_RESULTQUAL_"+sGXsfl_12_fel_idx;
         edtBR_Lab_ResultNum_Internalname = "BR_LAB_RESULTNUM_"+sGXsfl_12_fel_idx;
         edtBR_Lab_ResultUnit_Internalname = "BR_LAB_RESULTUNIT_"+sGXsfl_12_fel_idx;
         edtBR_Lab_AbnInd_Internalname = "BR_LAB_ABNIND_"+sGXsfl_12_fel_idx;
         edtBR_Lab_NormRangeLow_Internalname = "BR_LAB_NORMRANGELOW_"+sGXsfl_12_fel_idx;
         edtBR_Lab_NormRangeHigh_Internalname = "BR_LAB_NORMRANGEHIGH_"+sGXsfl_12_fel_idx;
         edtBR_Lab_TestMethod_Internalname = "BR_LAB_TESTMETHOD_"+sGXsfl_12_fel_idx;
         edtBR_Lab_InstrumentName_Internalname = "BR_LAB_INSTRUMENTNAME_"+sGXsfl_12_fel_idx;
         edtBR_Lab_InstrumentCode_Internalname = "BR_LAB_INSTRUMENTCODE_"+sGXsfl_12_fel_idx;
      }

      protected void sendrow_122( )
      {
         SubsflControlProps_122( ) ;
         WB3H0( ) ;
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
            AV57Select_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV57Select))&&String.IsNullOrEmpty(StringUtil.RTrim( AV73Select_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV57Select)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV57Select)) ? AV73Select_GXI : context.PathToRelativeUrl( AV57Select));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSelect_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSelect_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSelect_Jsonclick,"'"+""+"'"+",false,"+"'"+"EENTER."+sGXsfl_12_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV57Select_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_LabID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A101BR_LabID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A101BR_LabID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_LabID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
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
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Lab_SampleID_Internalname,(String)A224BR_Lab_SampleID,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Lab_SampleID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Lab_TestID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A102BR_Lab_TestID), 10, 0, ".", "")),context.localUtil.Format( (decimal)(A102BR_Lab_TestID), "ZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Lab_TestID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Lab_TestCode_Internalname,(String)A103BR_Lab_TestCode,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Lab_TestCode_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Lab_TestName_Internalname,(String)A104BR_Lab_TestName,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Lab_TestName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Lab_TestEngName_Internalname,(String)A261BR_Lab_TestEngName,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Lab_TestEngName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Lab_Age_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A262BR_Lab_Age), 3, 0, ".", "")),context.localUtil.Format( (decimal)(A262BR_Lab_Age), "ZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Lab_Age_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)3,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Lab_Diag_Internalname,(String)A263BR_Lab_Diag,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Lab_Diag_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Lab_SpecimenDate_Internalname,context.localUtil.TToC( A105BR_Lab_SpecimenDate, 10, 8, 0, 0, "/", ":", " "),context.localUtil.Format( A105BR_Lab_SpecimenDate, "9999/99/99 99:99:99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Lab_SpecimenDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)19,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_DataTime",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Lab_ReceivingTime_Internalname,context.localUtil.TToC( A264BR_Lab_ReceivingTime, 10, 8, 0, 0, "/", ":", " "),context.localUtil.Format( A264BR_Lab_ReceivingTime, "9999/99/99 99:99:99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Lab_ReceivingTime_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)19,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_DataTime",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Lab_ReportTime_Internalname,context.localUtil.TToC( A265BR_Lab_ReportTime, 10, 8, 0, 0, "/", ":", " "),context.localUtil.Format( A265BR_Lab_ReportTime, "9999/99/99 99:99:99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Lab_ReportTime_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)19,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_DataTime",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Lab_SpecimenSource_Internalname,(String)A106BR_Lab_SpecimenSource,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Lab_SpecimenSource_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Lab_ResultQual_Internalname,(String)A109BR_Lab_ResultQual,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Lab_ResultQual_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)500,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Lab_ResultNum_Internalname,(String)A110BR_Lab_ResultNum,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Lab_ResultNum_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)500,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Lab_ResultUnit_Internalname,(String)A111BR_Lab_ResultUnit,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Lab_ResultUnit_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Lab_AbnInd_Internalname,(String)A112BR_Lab_AbnInd,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Lab_AbnInd_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Lab_NormRangeLow_Internalname,(String)A113BR_Lab_NormRangeLow,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Lab_NormRangeLow_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Lab_NormRangeHigh_Internalname,(String)A114BR_Lab_NormRangeHigh,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Lab_NormRangeHigh_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Lab_TestMethod_Internalname,(String)A115BR_Lab_TestMethod,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Lab_TestMethod_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Lab_InstrumentName_Internalname,(String)A117BR_Lab_InstrumentName,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Lab_InstrumentName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)200,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Lab_InstrumentCode_Internalname,(String)A118BR_Lab_InstrumentCode,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Lab_InstrumentCode_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes3H2( ) ;
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
         edtBR_LabID_Internalname = "BR_LABID";
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO";
         edtBR_Lab_SampleID_Internalname = "BR_LAB_SAMPLEID";
         edtBR_Lab_TestID_Internalname = "BR_LAB_TESTID";
         edtBR_Lab_TestCode_Internalname = "BR_LAB_TESTCODE";
         edtBR_Lab_TestName_Internalname = "BR_LAB_TESTNAME";
         edtBR_Lab_TestEngName_Internalname = "BR_LAB_TESTENGNAME";
         edtBR_Lab_Age_Internalname = "BR_LAB_AGE";
         edtBR_Lab_Diag_Internalname = "BR_LAB_DIAG";
         edtBR_Lab_SpecimenDate_Internalname = "BR_LAB_SPECIMENDATE";
         edtBR_Lab_ReceivingTime_Internalname = "BR_LAB_RECEIVINGTIME";
         edtBR_Lab_ReportTime_Internalname = "BR_LAB_REPORTTIME";
         edtBR_Lab_SpecimenSource_Internalname = "BR_LAB_SPECIMENSOURCE";
         edtBR_Lab_ResultQual_Internalname = "BR_LAB_RESULTQUAL";
         edtBR_Lab_ResultNum_Internalname = "BR_LAB_RESULTNUM";
         edtBR_Lab_ResultUnit_Internalname = "BR_LAB_RESULTUNIT";
         edtBR_Lab_AbnInd_Internalname = "BR_LAB_ABNIND";
         edtBR_Lab_NormRangeLow_Internalname = "BR_LAB_NORMRANGELOW";
         edtBR_Lab_NormRangeHigh_Internalname = "BR_LAB_NORMRANGEHIGH";
         edtBR_Lab_TestMethod_Internalname = "BR_LAB_TESTMETHOD";
         edtBR_Lab_InstrumentName_Internalname = "BR_LAB_INSTRUMENTNAME";
         edtBR_Lab_InstrumentCode_Internalname = "BR_LAB_INSTRUMENTCODE";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_labid_Internalname = "DDO_BR_LABID";
         edtavDdo_br_labidtitlecontrolidtoreplace_Internalname = "vDDO_BR_LABIDTITLECONTROLIDTOREPLACE";
         Ddo_br_encounterid_Internalname = "DDO_BR_ENCOUNTERID";
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE";
         Ddo_br_information_patientno_Internalname = "DDO_BR_INFORMATION_PATIENTNO";
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname = "vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE";
         Ddo_br_lab_sampleid_Internalname = "DDO_BR_LAB_SAMPLEID";
         edtavDdo_br_lab_sampleidtitlecontrolidtoreplace_Internalname = "vDDO_BR_LAB_SAMPLEIDTITLECONTROLIDTOREPLACE";
         Ddo_br_lab_testid_Internalname = "DDO_BR_LAB_TESTID";
         edtavDdo_br_lab_testidtitlecontrolidtoreplace_Internalname = "vDDO_BR_LAB_TESTIDTITLECONTROLIDTOREPLACE";
         Ddo_br_lab_testcode_Internalname = "DDO_BR_LAB_TESTCODE";
         edtavDdo_br_lab_testcodetitlecontrolidtoreplace_Internalname = "vDDO_BR_LAB_TESTCODETITLECONTROLIDTOREPLACE";
         Ddo_br_lab_testname_Internalname = "DDO_BR_LAB_TESTNAME";
         edtavDdo_br_lab_testnametitlecontrolidtoreplace_Internalname = "vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE";
         Ddo_br_lab_testengname_Internalname = "DDO_BR_LAB_TESTENGNAME";
         edtavDdo_br_lab_testengnametitlecontrolidtoreplace_Internalname = "vDDO_BR_LAB_TESTENGNAMETITLECONTROLIDTOREPLACE";
         Ddo_br_lab_age_Internalname = "DDO_BR_LAB_AGE";
         edtavDdo_br_lab_agetitlecontrolidtoreplace_Internalname = "vDDO_BR_LAB_AGETITLECONTROLIDTOREPLACE";
         Ddo_br_lab_diag_Internalname = "DDO_BR_LAB_DIAG";
         edtavDdo_br_lab_diagtitlecontrolidtoreplace_Internalname = "vDDO_BR_LAB_DIAGTITLECONTROLIDTOREPLACE";
         Ddo_br_lab_specimendate_Internalname = "DDO_BR_LAB_SPECIMENDATE";
         edtavDdo_br_lab_specimendatetitlecontrolidtoreplace_Internalname = "vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE";
         Ddo_br_lab_receivingtime_Internalname = "DDO_BR_LAB_RECEIVINGTIME";
         edtavDdo_br_lab_receivingtimetitlecontrolidtoreplace_Internalname = "vDDO_BR_LAB_RECEIVINGTIMETITLECONTROLIDTOREPLACE";
         Ddo_br_lab_reporttime_Internalname = "DDO_BR_LAB_REPORTTIME";
         edtavDdo_br_lab_reporttimetitlecontrolidtoreplace_Internalname = "vDDO_BR_LAB_REPORTTIMETITLECONTROLIDTOREPLACE";
         Ddo_br_lab_specimensource_Internalname = "DDO_BR_LAB_SPECIMENSOURCE";
         edtavDdo_br_lab_specimensourcetitlecontrolidtoreplace_Internalname = "vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE";
         Ddo_br_lab_resultqual_Internalname = "DDO_BR_LAB_RESULTQUAL";
         edtavDdo_br_lab_resultqualtitlecontrolidtoreplace_Internalname = "vDDO_BR_LAB_RESULTQUALTITLECONTROLIDTOREPLACE";
         Ddo_br_lab_resultnum_Internalname = "DDO_BR_LAB_RESULTNUM";
         edtavDdo_br_lab_resultnumtitlecontrolidtoreplace_Internalname = "vDDO_BR_LAB_RESULTNUMTITLECONTROLIDTOREPLACE";
         Ddo_br_lab_resultunit_Internalname = "DDO_BR_LAB_RESULTUNIT";
         edtavDdo_br_lab_resultunittitlecontrolidtoreplace_Internalname = "vDDO_BR_LAB_RESULTUNITTITLECONTROLIDTOREPLACE";
         Ddo_br_lab_abnind_Internalname = "DDO_BR_LAB_ABNIND";
         edtavDdo_br_lab_abnindtitlecontrolidtoreplace_Internalname = "vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE";
         Ddo_br_lab_normrangelow_Internalname = "DDO_BR_LAB_NORMRANGELOW";
         edtavDdo_br_lab_normrangelowtitlecontrolidtoreplace_Internalname = "vDDO_BR_LAB_NORMRANGELOWTITLECONTROLIDTOREPLACE";
         Ddo_br_lab_normrangehigh_Internalname = "DDO_BR_LAB_NORMRANGEHIGH";
         edtavDdo_br_lab_normrangehightitlecontrolidtoreplace_Internalname = "vDDO_BR_LAB_NORMRANGEHIGHTITLECONTROLIDTOREPLACE";
         Ddo_br_lab_testmethod_Internalname = "DDO_BR_LAB_TESTMETHOD";
         edtavDdo_br_lab_testmethodtitlecontrolidtoreplace_Internalname = "vDDO_BR_LAB_TESTMETHODTITLECONTROLIDTOREPLACE";
         Ddo_br_lab_instrumentname_Internalname = "DDO_BR_LAB_INSTRUMENTNAME";
         edtavDdo_br_lab_instrumentnametitlecontrolidtoreplace_Internalname = "vDDO_BR_LAB_INSTRUMENTNAMETITLECONTROLIDTOREPLACE";
         Ddo_br_lab_instrumentcode_Internalname = "DDO_BR_LAB_INSTRUMENTCODE";
         edtavDdo_br_lab_instrumentcodetitlecontrolidtoreplace_Internalname = "vDDO_BR_LAB_INSTRUMENTCODETITLECONTROLIDTOREPLACE";
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
         edtBR_Lab_InstrumentCode_Jsonclick = "";
         edtBR_Lab_InstrumentName_Jsonclick = "";
         edtBR_Lab_TestMethod_Jsonclick = "";
         edtBR_Lab_NormRangeHigh_Jsonclick = "";
         edtBR_Lab_NormRangeLow_Jsonclick = "";
         edtBR_Lab_AbnInd_Jsonclick = "";
         edtBR_Lab_ResultUnit_Jsonclick = "";
         edtBR_Lab_ResultNum_Jsonclick = "";
         edtBR_Lab_ResultQual_Jsonclick = "";
         edtBR_Lab_SpecimenSource_Jsonclick = "";
         edtBR_Lab_ReportTime_Jsonclick = "";
         edtBR_Lab_ReceivingTime_Jsonclick = "";
         edtBR_Lab_SpecimenDate_Jsonclick = "";
         edtBR_Lab_Diag_Jsonclick = "";
         edtBR_Lab_Age_Jsonclick = "";
         edtBR_Lab_TestEngName_Jsonclick = "";
         edtBR_Lab_TestName_Jsonclick = "";
         edtBR_Lab_TestCode_Jsonclick = "";
         edtBR_Lab_TestID_Jsonclick = "";
         edtBR_Lab_SampleID_Jsonclick = "";
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_EncounterID_Jsonclick = "";
         edtBR_LabID_Jsonclick = "";
         edtavSelect_Jsonclick = "";
         edtavSelect_Visible = -1;
         edtavSelect_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_lab_instrumentcodetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_lab_instrumentnametitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_lab_testmethodtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_lab_normrangehightitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_lab_normrangelowtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_lab_abnindtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_lab_resultunittitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_lab_resultnumtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_lab_resultqualtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_lab_specimensourcetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_lab_reporttimetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_lab_receivingtimetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_lab_specimendatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_lab_diagtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_lab_agetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_lab_testengnametitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_lab_testnametitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_lab_testcodetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_lab_testidtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_lab_sampleidtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_labidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavSelect_Tooltiptext = "选择";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Lab_InstrumentCode_Titleformat = 0;
         edtBR_Lab_InstrumentCode_Title = "设备编码";
         edtBR_Lab_InstrumentName_Titleformat = 0;
         edtBR_Lab_InstrumentName_Title = "设备名称";
         edtBR_Lab_TestMethod_Titleformat = 0;
         edtBR_Lab_TestMethod_Title = "检测方法";
         edtBR_Lab_NormRangeHigh_Titleformat = 0;
         edtBR_Lab_NormRangeHigh_Title = "参考值上限";
         edtBR_Lab_NormRangeLow_Titleformat = 0;
         edtBR_Lab_NormRangeLow_Title = "参考值下限";
         edtBR_Lab_AbnInd_Titleformat = 0;
         edtBR_Lab_AbnInd_Title = "结果提示";
         edtBR_Lab_ResultUnit_Titleformat = 0;
         edtBR_Lab_ResultUnit_Title = "结果单位";
         edtBR_Lab_ResultNum_Titleformat = 0;
         edtBR_Lab_ResultNum_Title = "定量结果";
         edtBR_Lab_ResultQual_Titleformat = 0;
         edtBR_Lab_ResultQual_Title = "定性结果";
         edtBR_Lab_SpecimenSource_Titleformat = 0;
         edtBR_Lab_SpecimenSource_Title = "标本种类";
         edtBR_Lab_ReportTime_Titleformat = 0;
         edtBR_Lab_ReportTime_Title = "报告时间";
         edtBR_Lab_ReceivingTime_Titleformat = 0;
         edtBR_Lab_ReceivingTime_Title = "接收时间";
         edtBR_Lab_SpecimenDate_Titleformat = 0;
         edtBR_Lab_SpecimenDate_Title = "采样时间";
         edtBR_Lab_Diag_Titleformat = 0;
         edtBR_Lab_Diag_Title = "临床诊断";
         edtBR_Lab_Age_Titleformat = 0;
         edtBR_Lab_Age_Title = "年龄";
         edtBR_Lab_TestEngName_Titleformat = 0;
         edtBR_Lab_TestEngName_Title = "项目英文名称";
         edtBR_Lab_TestName_Titleformat = 0;
         edtBR_Lab_TestName_Title = "项目名称";
         edtBR_Lab_TestCode_Titleformat = 0;
         edtBR_Lab_TestCode_Title = "项目代码";
         edtBR_Lab_TestID_Titleformat = 0;
         edtBR_Lab_TestID_Title = "项目序号";
         edtBR_Lab_SampleID_Titleformat = 0;
         edtBR_Lab_SampleID_Title = "ID";
         edtBR_Information_PatientNo_Titleformat = 0;
         edtBR_Information_PatientNo_Title = "患者编号";
         edtBR_EncounterID_Titleformat = 0;
         edtBR_EncounterID_Title = "就诊信息主键";
         edtBR_LabID_Titleformat = 0;
         edtBR_LabID_Title = "实验室检查主键";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         divTablemain_Height = 0;
         Ddo_br_lab_instrumentcode_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_lab_instrumentcode_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_lab_instrumentcode_Sortasc = "WWP_TSSortASC";
         Ddo_br_lab_instrumentcode_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_lab_instrumentcode_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_lab_instrumentcode_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_lab_instrumentcode_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_lab_instrumentcode_Titlecontrolidtoreplace = "";
         Ddo_br_lab_instrumentcode_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_lab_instrumentcode_Cls = "ColumnSettings";
         Ddo_br_lab_instrumentcode_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_lab_instrumentcode_Caption = "";
         Ddo_br_lab_instrumentname_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_lab_instrumentname_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_lab_instrumentname_Sortasc = "WWP_TSSortASC";
         Ddo_br_lab_instrumentname_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_lab_instrumentname_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_lab_instrumentname_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_lab_instrumentname_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_lab_instrumentname_Titlecontrolidtoreplace = "";
         Ddo_br_lab_instrumentname_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_lab_instrumentname_Cls = "ColumnSettings";
         Ddo_br_lab_instrumentname_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_lab_instrumentname_Caption = "";
         Ddo_br_lab_testmethod_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_lab_testmethod_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_lab_testmethod_Sortasc = "WWP_TSSortASC";
         Ddo_br_lab_testmethod_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_lab_testmethod_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_lab_testmethod_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_lab_testmethod_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_lab_testmethod_Titlecontrolidtoreplace = "";
         Ddo_br_lab_testmethod_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_lab_testmethod_Cls = "ColumnSettings";
         Ddo_br_lab_testmethod_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_lab_testmethod_Caption = "";
         Ddo_br_lab_normrangehigh_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_lab_normrangehigh_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_lab_normrangehigh_Sortasc = "WWP_TSSortASC";
         Ddo_br_lab_normrangehigh_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_lab_normrangehigh_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_lab_normrangehigh_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_lab_normrangehigh_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_lab_normrangehigh_Titlecontrolidtoreplace = "";
         Ddo_br_lab_normrangehigh_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_lab_normrangehigh_Cls = "ColumnSettings";
         Ddo_br_lab_normrangehigh_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_lab_normrangehigh_Caption = "";
         Ddo_br_lab_normrangelow_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_lab_normrangelow_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_lab_normrangelow_Sortasc = "WWP_TSSortASC";
         Ddo_br_lab_normrangelow_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_lab_normrangelow_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_lab_normrangelow_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_lab_normrangelow_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_lab_normrangelow_Titlecontrolidtoreplace = "";
         Ddo_br_lab_normrangelow_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_lab_normrangelow_Cls = "ColumnSettings";
         Ddo_br_lab_normrangelow_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_lab_normrangelow_Caption = "";
         Ddo_br_lab_abnind_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_lab_abnind_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_lab_abnind_Sortasc = "WWP_TSSortASC";
         Ddo_br_lab_abnind_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_lab_abnind_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_lab_abnind_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_lab_abnind_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_lab_abnind_Titlecontrolidtoreplace = "";
         Ddo_br_lab_abnind_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_lab_abnind_Cls = "ColumnSettings";
         Ddo_br_lab_abnind_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_lab_abnind_Caption = "";
         Ddo_br_lab_resultunit_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_lab_resultunit_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_lab_resultunit_Sortasc = "WWP_TSSortASC";
         Ddo_br_lab_resultunit_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_lab_resultunit_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_lab_resultunit_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_lab_resultunit_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_lab_resultunit_Titlecontrolidtoreplace = "";
         Ddo_br_lab_resultunit_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_lab_resultunit_Cls = "ColumnSettings";
         Ddo_br_lab_resultunit_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_lab_resultunit_Caption = "";
         Ddo_br_lab_resultnum_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_lab_resultnum_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_lab_resultnum_Sortasc = "WWP_TSSortASC";
         Ddo_br_lab_resultnum_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_lab_resultnum_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_lab_resultnum_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_lab_resultnum_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_lab_resultnum_Titlecontrolidtoreplace = "";
         Ddo_br_lab_resultnum_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_lab_resultnum_Cls = "ColumnSettings";
         Ddo_br_lab_resultnum_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_lab_resultnum_Caption = "";
         Ddo_br_lab_resultqual_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_lab_resultqual_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_lab_resultqual_Sortasc = "WWP_TSSortASC";
         Ddo_br_lab_resultqual_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_lab_resultqual_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_lab_resultqual_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_lab_resultqual_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_lab_resultqual_Titlecontrolidtoreplace = "";
         Ddo_br_lab_resultqual_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_lab_resultqual_Cls = "ColumnSettings";
         Ddo_br_lab_resultqual_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_lab_resultqual_Caption = "";
         Ddo_br_lab_specimensource_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_lab_specimensource_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_lab_specimensource_Sortasc = "WWP_TSSortASC";
         Ddo_br_lab_specimensource_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_lab_specimensource_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_lab_specimensource_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_lab_specimensource_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_lab_specimensource_Titlecontrolidtoreplace = "";
         Ddo_br_lab_specimensource_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_lab_specimensource_Cls = "ColumnSettings";
         Ddo_br_lab_specimensource_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_lab_specimensource_Caption = "";
         Ddo_br_lab_reporttime_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_lab_reporttime_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_lab_reporttime_Sortasc = "WWP_TSSortASC";
         Ddo_br_lab_reporttime_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_lab_reporttime_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_lab_reporttime_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_lab_reporttime_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_lab_reporttime_Titlecontrolidtoreplace = "";
         Ddo_br_lab_reporttime_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_lab_reporttime_Cls = "ColumnSettings";
         Ddo_br_lab_reporttime_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_lab_reporttime_Caption = "";
         Ddo_br_lab_receivingtime_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_lab_receivingtime_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_lab_receivingtime_Sortasc = "WWP_TSSortASC";
         Ddo_br_lab_receivingtime_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_lab_receivingtime_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_lab_receivingtime_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_lab_receivingtime_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_lab_receivingtime_Titlecontrolidtoreplace = "";
         Ddo_br_lab_receivingtime_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_lab_receivingtime_Cls = "ColumnSettings";
         Ddo_br_lab_receivingtime_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_lab_receivingtime_Caption = "";
         Ddo_br_lab_specimendate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_lab_specimendate_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_lab_specimendate_Sortasc = "WWP_TSSortASC";
         Ddo_br_lab_specimendate_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_lab_specimendate_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_lab_specimendate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_lab_specimendate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_lab_specimendate_Titlecontrolidtoreplace = "";
         Ddo_br_lab_specimendate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_lab_specimendate_Cls = "ColumnSettings";
         Ddo_br_lab_specimendate_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_lab_specimendate_Caption = "";
         Ddo_br_lab_diag_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_lab_diag_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_lab_diag_Sortasc = "WWP_TSSortASC";
         Ddo_br_lab_diag_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_lab_diag_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_lab_diag_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_lab_diag_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_lab_diag_Titlecontrolidtoreplace = "";
         Ddo_br_lab_diag_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_lab_diag_Cls = "ColumnSettings";
         Ddo_br_lab_diag_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_lab_diag_Caption = "";
         Ddo_br_lab_age_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_lab_age_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_lab_age_Sortasc = "WWP_TSSortASC";
         Ddo_br_lab_age_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_lab_age_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_lab_age_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_lab_age_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_lab_age_Titlecontrolidtoreplace = "";
         Ddo_br_lab_age_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_lab_age_Cls = "ColumnSettings";
         Ddo_br_lab_age_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_lab_age_Caption = "";
         Ddo_br_lab_testengname_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_lab_testengname_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_lab_testengname_Sortasc = "WWP_TSSortASC";
         Ddo_br_lab_testengname_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_lab_testengname_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_lab_testengname_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_lab_testengname_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_lab_testengname_Titlecontrolidtoreplace = "";
         Ddo_br_lab_testengname_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_lab_testengname_Cls = "ColumnSettings";
         Ddo_br_lab_testengname_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_lab_testengname_Caption = "";
         Ddo_br_lab_testname_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_lab_testname_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_lab_testname_Sortasc = "WWP_TSSortASC";
         Ddo_br_lab_testname_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_lab_testname_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_lab_testname_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_lab_testname_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_lab_testname_Titlecontrolidtoreplace = "";
         Ddo_br_lab_testname_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_lab_testname_Cls = "ColumnSettings";
         Ddo_br_lab_testname_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_lab_testname_Caption = "";
         Ddo_br_lab_testcode_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_lab_testcode_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_lab_testcode_Sortasc = "WWP_TSSortASC";
         Ddo_br_lab_testcode_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_lab_testcode_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_lab_testcode_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_lab_testcode_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_lab_testcode_Titlecontrolidtoreplace = "";
         Ddo_br_lab_testcode_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_lab_testcode_Cls = "ColumnSettings";
         Ddo_br_lab_testcode_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_lab_testcode_Caption = "";
         Ddo_br_lab_testid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_lab_testid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_lab_testid_Sortasc = "WWP_TSSortASC";
         Ddo_br_lab_testid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_lab_testid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_lab_testid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_lab_testid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_lab_testid_Titlecontrolidtoreplace = "";
         Ddo_br_lab_testid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_lab_testid_Cls = "ColumnSettings";
         Ddo_br_lab_testid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_lab_testid_Caption = "";
         Ddo_br_lab_sampleid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_lab_sampleid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_lab_sampleid_Sortasc = "WWP_TSSortASC";
         Ddo_br_lab_sampleid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_lab_sampleid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_lab_sampleid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_lab_sampleid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_lab_sampleid_Titlecontrolidtoreplace = "";
         Ddo_br_lab_sampleid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_lab_sampleid_Cls = "ColumnSettings";
         Ddo_br_lab_sampleid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_lab_sampleid_Caption = "";
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
         Ddo_br_labid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_labid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_labid_Sortasc = "WWP_TSSortASC";
         Ddo_br_labid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_labid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_labid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_labid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_labid_Titlecontrolidtoreplace = "";
         Ddo_br_labid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_labid_Cls = "ColumnSettings";
         Ddo_br_labid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_labid_Caption = "";
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
         Form.Caption = "选择实验室检查";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_SAMPLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Lab_TestIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTENGNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_BR_Lab_AgeTitleControlIdToReplace',fld:'vDDO_BR_LAB_AGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Lab_DiagTitleControlIdToReplace',fld:'vDDO_BR_LAB_DIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_RECEIVINGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_REPORTTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGELOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGEHIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTMETHODTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV12BR_LabIDTitleFilterData',fld:'vBR_LABIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV58BR_Lab_SampleIDTitleFilterData',fld:'vBR_LAB_SAMPLEIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Lab_TestIDTitleFilterData',fld:'vBR_LAB_TESTIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Lab_TestCodeTitleFilterData',fld:'vBR_LAB_TESTCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Lab_TestNameTitleFilterData',fld:'vBR_LAB_TESTNAMETITLEFILTERDATA',pic:''},{av:'AV60BR_Lab_TestEngNameTitleFilterData',fld:'vBR_LAB_TESTENGNAMETITLEFILTERDATA',pic:''},{av:'AV62BR_Lab_AgeTitleFilterData',fld:'vBR_LAB_AGETITLEFILTERDATA',pic:''},{av:'AV64BR_Lab_DiagTitleFilterData',fld:'vBR_LAB_DIAGTITLEFILTERDATA',pic:''},{av:'AV24BR_Lab_SpecimenDateTitleFilterData',fld:'vBR_LAB_SPECIMENDATETITLEFILTERDATA',pic:''},{av:'AV66BR_Lab_ReceivingTimeTitleFilterData',fld:'vBR_LAB_RECEIVINGTIMETITLEFILTERDATA',pic:''},{av:'AV68BR_Lab_ReportTimeTitleFilterData',fld:'vBR_LAB_REPORTTIMETITLEFILTERDATA',pic:''},{av:'AV26BR_Lab_SpecimenSourceTitleFilterData',fld:'vBR_LAB_SPECIMENSOURCETITLEFILTERDATA',pic:''},{av:'AV32BR_Lab_ResultQualTitleFilterData',fld:'vBR_LAB_RESULTQUALTITLEFILTERDATA',pic:''},{av:'AV34BR_Lab_ResultNumTitleFilterData',fld:'vBR_LAB_RESULTNUMTITLEFILTERDATA',pic:''},{av:'AV36BR_Lab_ResultUnitTitleFilterData',fld:'vBR_LAB_RESULTUNITTITLEFILTERDATA',pic:''},{av:'AV38BR_Lab_AbnIndTitleFilterData',fld:'vBR_LAB_ABNINDTITLEFILTERDATA',pic:''},{av:'AV40BR_Lab_NormRangeLowTitleFilterData',fld:'vBR_LAB_NORMRANGELOWTITLEFILTERDATA',pic:''},{av:'AV42BR_Lab_NormRangeHighTitleFilterData',fld:'vBR_LAB_NORMRANGEHIGHTITLEFILTERDATA',pic:''},{av:'AV44BR_Lab_TestMethodTitleFilterData',fld:'vBR_LAB_TESTMETHODTITLEFILTERDATA',pic:''},{av:'AV48BR_Lab_InstrumentNameTitleFilterData',fld:'vBR_LAB_INSTRUMENTNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Lab_InstrumentCodeTitleFilterData',fld:'vBR_LAB_INSTRUMENTCODETITLEFILTERDATA',pic:''},{av:'edtBR_LabID_Titleformat',ctrl:'BR_LABID',prop:'Titleformat'},{av:'edtBR_LabID_Title',ctrl:'BR_LABID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Lab_SampleID_Titleformat',ctrl:'BR_LAB_SAMPLEID',prop:'Titleformat'},{av:'edtBR_Lab_SampleID_Title',ctrl:'BR_LAB_SAMPLEID',prop:'Title'},{av:'edtBR_Lab_TestID_Titleformat',ctrl:'BR_LAB_TESTID',prop:'Titleformat'},{av:'edtBR_Lab_TestID_Title',ctrl:'BR_LAB_TESTID',prop:'Title'},{av:'edtBR_Lab_TestCode_Titleformat',ctrl:'BR_LAB_TESTCODE',prop:'Titleformat'},{av:'edtBR_Lab_TestCode_Title',ctrl:'BR_LAB_TESTCODE',prop:'Title'},{av:'edtBR_Lab_TestName_Titleformat',ctrl:'BR_LAB_TESTNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestName_Title',ctrl:'BR_LAB_TESTNAME',prop:'Title'},{av:'edtBR_Lab_TestEngName_Titleformat',ctrl:'BR_LAB_TESTENGNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestEngName_Title',ctrl:'BR_LAB_TESTENGNAME',prop:'Title'},{av:'edtBR_Lab_Age_Titleformat',ctrl:'BR_LAB_AGE',prop:'Titleformat'},{av:'edtBR_Lab_Age_Title',ctrl:'BR_LAB_AGE',prop:'Title'},{av:'edtBR_Lab_Diag_Titleformat',ctrl:'BR_LAB_DIAG',prop:'Titleformat'},{av:'edtBR_Lab_Diag_Title',ctrl:'BR_LAB_DIAG',prop:'Title'},{av:'edtBR_Lab_SpecimenDate_Titleformat',ctrl:'BR_LAB_SPECIMENDATE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenDate_Title',ctrl:'BR_LAB_SPECIMENDATE',prop:'Title'},{av:'edtBR_Lab_ReceivingTime_Titleformat',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReceivingTime_Title',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Title'},{av:'edtBR_Lab_ReportTime_Titleformat',ctrl:'BR_LAB_REPORTTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReportTime_Title',ctrl:'BR_LAB_REPORTTIME',prop:'Title'},{av:'edtBR_Lab_SpecimenSource_Titleformat',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenSource_Title',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Title'},{av:'edtBR_Lab_ResultQual_Titleformat',ctrl:'BR_LAB_RESULTQUAL',prop:'Titleformat'},{av:'edtBR_Lab_ResultQual_Title',ctrl:'BR_LAB_RESULTQUAL',prop:'Title'},{av:'edtBR_Lab_ResultNum_Titleformat',ctrl:'BR_LAB_RESULTNUM',prop:'Titleformat'},{av:'edtBR_Lab_ResultNum_Title',ctrl:'BR_LAB_RESULTNUM',prop:'Title'},{av:'edtBR_Lab_ResultUnit_Titleformat',ctrl:'BR_LAB_RESULTUNIT',prop:'Titleformat'},{av:'edtBR_Lab_ResultUnit_Title',ctrl:'BR_LAB_RESULTUNIT',prop:'Title'},{av:'edtBR_Lab_AbnInd_Titleformat',ctrl:'BR_LAB_ABNIND',prop:'Titleformat'},{av:'edtBR_Lab_AbnInd_Title',ctrl:'BR_LAB_ABNIND',prop:'Title'},{av:'edtBR_Lab_NormRangeLow_Titleformat',ctrl:'BR_LAB_NORMRANGELOW',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeLow_Title',ctrl:'BR_LAB_NORMRANGELOW',prop:'Title'},{av:'edtBR_Lab_NormRangeHigh_Titleformat',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeHigh_Title',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Title'},{av:'edtBR_Lab_TestMethod_Titleformat',ctrl:'BR_LAB_TESTMETHOD',prop:'Titleformat'},{av:'edtBR_Lab_TestMethod_Title',ctrl:'BR_LAB_TESTMETHOD',prop:'Title'},{av:'edtBR_Lab_InstrumentName_Titleformat',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentName_Title',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Title'},{av:'edtBR_Lab_InstrumentCode_Titleformat',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentCode_Title',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E113H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_SAMPLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Lab_TestIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTENGNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_BR_Lab_AgeTitleControlIdToReplace',fld:'vDDO_BR_LAB_AGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Lab_DiagTitleControlIdToReplace',fld:'vDDO_BR_LAB_DIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_RECEIVINGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_REPORTTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGELOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGEHIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTMETHODTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E123H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_SAMPLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Lab_TestIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTENGNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_BR_Lab_AgeTitleControlIdToReplace',fld:'vDDO_BR_LAB_AGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Lab_DiagTitleControlIdToReplace',fld:'vDDO_BR_LAB_DIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_RECEIVINGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_REPORTTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGELOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGEHIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTMETHODTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_LABID.ONOPTIONCLICKED","{handler:'E133H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_SAMPLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Lab_TestIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTENGNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_BR_Lab_AgeTitleControlIdToReplace',fld:'vDDO_BR_LAB_AGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Lab_DiagTitleControlIdToReplace',fld:'vDDO_BR_LAB_DIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_RECEIVINGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_REPORTTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGELOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGEHIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTMETHODTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_labid_Activeeventkey',ctrl:'DDO_BR_LABID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_LABID.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_labid_Sortedstatus',ctrl:'DDO_BR_LABID',prop:'SortedStatus'},{av:'AV12BR_LabIDTitleFilterData',fld:'vBR_LABIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV58BR_Lab_SampleIDTitleFilterData',fld:'vBR_LAB_SAMPLEIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Lab_TestIDTitleFilterData',fld:'vBR_LAB_TESTIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Lab_TestCodeTitleFilterData',fld:'vBR_LAB_TESTCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Lab_TestNameTitleFilterData',fld:'vBR_LAB_TESTNAMETITLEFILTERDATA',pic:''},{av:'AV60BR_Lab_TestEngNameTitleFilterData',fld:'vBR_LAB_TESTENGNAMETITLEFILTERDATA',pic:''},{av:'AV62BR_Lab_AgeTitleFilterData',fld:'vBR_LAB_AGETITLEFILTERDATA',pic:''},{av:'AV64BR_Lab_DiagTitleFilterData',fld:'vBR_LAB_DIAGTITLEFILTERDATA',pic:''},{av:'AV24BR_Lab_SpecimenDateTitleFilterData',fld:'vBR_LAB_SPECIMENDATETITLEFILTERDATA',pic:''},{av:'AV66BR_Lab_ReceivingTimeTitleFilterData',fld:'vBR_LAB_RECEIVINGTIMETITLEFILTERDATA',pic:''},{av:'AV68BR_Lab_ReportTimeTitleFilterData',fld:'vBR_LAB_REPORTTIMETITLEFILTERDATA',pic:''},{av:'AV26BR_Lab_SpecimenSourceTitleFilterData',fld:'vBR_LAB_SPECIMENSOURCETITLEFILTERDATA',pic:''},{av:'AV32BR_Lab_ResultQualTitleFilterData',fld:'vBR_LAB_RESULTQUALTITLEFILTERDATA',pic:''},{av:'AV34BR_Lab_ResultNumTitleFilterData',fld:'vBR_LAB_RESULTNUMTITLEFILTERDATA',pic:''},{av:'AV36BR_Lab_ResultUnitTitleFilterData',fld:'vBR_LAB_RESULTUNITTITLEFILTERDATA',pic:''},{av:'AV38BR_Lab_AbnIndTitleFilterData',fld:'vBR_LAB_ABNINDTITLEFILTERDATA',pic:''},{av:'AV40BR_Lab_NormRangeLowTitleFilterData',fld:'vBR_LAB_NORMRANGELOWTITLEFILTERDATA',pic:''},{av:'AV42BR_Lab_NormRangeHighTitleFilterData',fld:'vBR_LAB_NORMRANGEHIGHTITLEFILTERDATA',pic:''},{av:'AV44BR_Lab_TestMethodTitleFilterData',fld:'vBR_LAB_TESTMETHODTITLEFILTERDATA',pic:''},{av:'AV48BR_Lab_InstrumentNameTitleFilterData',fld:'vBR_LAB_INSTRUMENTNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Lab_InstrumentCodeTitleFilterData',fld:'vBR_LAB_INSTRUMENTCODETITLEFILTERDATA',pic:''},{av:'edtBR_LabID_Titleformat',ctrl:'BR_LABID',prop:'Titleformat'},{av:'edtBR_LabID_Title',ctrl:'BR_LABID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Lab_SampleID_Titleformat',ctrl:'BR_LAB_SAMPLEID',prop:'Titleformat'},{av:'edtBR_Lab_SampleID_Title',ctrl:'BR_LAB_SAMPLEID',prop:'Title'},{av:'edtBR_Lab_TestID_Titleformat',ctrl:'BR_LAB_TESTID',prop:'Titleformat'},{av:'edtBR_Lab_TestID_Title',ctrl:'BR_LAB_TESTID',prop:'Title'},{av:'edtBR_Lab_TestCode_Titleformat',ctrl:'BR_LAB_TESTCODE',prop:'Titleformat'},{av:'edtBR_Lab_TestCode_Title',ctrl:'BR_LAB_TESTCODE',prop:'Title'},{av:'edtBR_Lab_TestName_Titleformat',ctrl:'BR_LAB_TESTNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestName_Title',ctrl:'BR_LAB_TESTNAME',prop:'Title'},{av:'edtBR_Lab_TestEngName_Titleformat',ctrl:'BR_LAB_TESTENGNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestEngName_Title',ctrl:'BR_LAB_TESTENGNAME',prop:'Title'},{av:'edtBR_Lab_Age_Titleformat',ctrl:'BR_LAB_AGE',prop:'Titleformat'},{av:'edtBR_Lab_Age_Title',ctrl:'BR_LAB_AGE',prop:'Title'},{av:'edtBR_Lab_Diag_Titleformat',ctrl:'BR_LAB_DIAG',prop:'Titleformat'},{av:'edtBR_Lab_Diag_Title',ctrl:'BR_LAB_DIAG',prop:'Title'},{av:'edtBR_Lab_SpecimenDate_Titleformat',ctrl:'BR_LAB_SPECIMENDATE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenDate_Title',ctrl:'BR_LAB_SPECIMENDATE',prop:'Title'},{av:'edtBR_Lab_ReceivingTime_Titleformat',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReceivingTime_Title',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Title'},{av:'edtBR_Lab_ReportTime_Titleformat',ctrl:'BR_LAB_REPORTTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReportTime_Title',ctrl:'BR_LAB_REPORTTIME',prop:'Title'},{av:'edtBR_Lab_SpecimenSource_Titleformat',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenSource_Title',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Title'},{av:'edtBR_Lab_ResultQual_Titleformat',ctrl:'BR_LAB_RESULTQUAL',prop:'Titleformat'},{av:'edtBR_Lab_ResultQual_Title',ctrl:'BR_LAB_RESULTQUAL',prop:'Title'},{av:'edtBR_Lab_ResultNum_Titleformat',ctrl:'BR_LAB_RESULTNUM',prop:'Titleformat'},{av:'edtBR_Lab_ResultNum_Title',ctrl:'BR_LAB_RESULTNUM',prop:'Title'},{av:'edtBR_Lab_ResultUnit_Titleformat',ctrl:'BR_LAB_RESULTUNIT',prop:'Titleformat'},{av:'edtBR_Lab_ResultUnit_Title',ctrl:'BR_LAB_RESULTUNIT',prop:'Title'},{av:'edtBR_Lab_AbnInd_Titleformat',ctrl:'BR_LAB_ABNIND',prop:'Titleformat'},{av:'edtBR_Lab_AbnInd_Title',ctrl:'BR_LAB_ABNIND',prop:'Title'},{av:'edtBR_Lab_NormRangeLow_Titleformat',ctrl:'BR_LAB_NORMRANGELOW',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeLow_Title',ctrl:'BR_LAB_NORMRANGELOW',prop:'Title'},{av:'edtBR_Lab_NormRangeHigh_Titleformat',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeHigh_Title',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Title'},{av:'edtBR_Lab_TestMethod_Titleformat',ctrl:'BR_LAB_TESTMETHOD',prop:'Titleformat'},{av:'edtBR_Lab_TestMethod_Title',ctrl:'BR_LAB_TESTMETHOD',prop:'Title'},{av:'edtBR_Lab_InstrumentName_Titleformat',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentName_Title',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Title'},{av:'edtBR_Lab_InstrumentCode_Titleformat',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentCode_Title',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED","{handler:'E143H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_SAMPLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Lab_TestIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTENGNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_BR_Lab_AgeTitleControlIdToReplace',fld:'vDDO_BR_LAB_AGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Lab_DiagTitleControlIdToReplace',fld:'vDDO_BR_LAB_DIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_RECEIVINGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_REPORTTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGELOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGEHIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTMETHODTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_encounterid_Activeeventkey',ctrl:'DDO_BR_ENCOUNTERID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'AV12BR_LabIDTitleFilterData',fld:'vBR_LABIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV58BR_Lab_SampleIDTitleFilterData',fld:'vBR_LAB_SAMPLEIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Lab_TestIDTitleFilterData',fld:'vBR_LAB_TESTIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Lab_TestCodeTitleFilterData',fld:'vBR_LAB_TESTCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Lab_TestNameTitleFilterData',fld:'vBR_LAB_TESTNAMETITLEFILTERDATA',pic:''},{av:'AV60BR_Lab_TestEngNameTitleFilterData',fld:'vBR_LAB_TESTENGNAMETITLEFILTERDATA',pic:''},{av:'AV62BR_Lab_AgeTitleFilterData',fld:'vBR_LAB_AGETITLEFILTERDATA',pic:''},{av:'AV64BR_Lab_DiagTitleFilterData',fld:'vBR_LAB_DIAGTITLEFILTERDATA',pic:''},{av:'AV24BR_Lab_SpecimenDateTitleFilterData',fld:'vBR_LAB_SPECIMENDATETITLEFILTERDATA',pic:''},{av:'AV66BR_Lab_ReceivingTimeTitleFilterData',fld:'vBR_LAB_RECEIVINGTIMETITLEFILTERDATA',pic:''},{av:'AV68BR_Lab_ReportTimeTitleFilterData',fld:'vBR_LAB_REPORTTIMETITLEFILTERDATA',pic:''},{av:'AV26BR_Lab_SpecimenSourceTitleFilterData',fld:'vBR_LAB_SPECIMENSOURCETITLEFILTERDATA',pic:''},{av:'AV32BR_Lab_ResultQualTitleFilterData',fld:'vBR_LAB_RESULTQUALTITLEFILTERDATA',pic:''},{av:'AV34BR_Lab_ResultNumTitleFilterData',fld:'vBR_LAB_RESULTNUMTITLEFILTERDATA',pic:''},{av:'AV36BR_Lab_ResultUnitTitleFilterData',fld:'vBR_LAB_RESULTUNITTITLEFILTERDATA',pic:''},{av:'AV38BR_Lab_AbnIndTitleFilterData',fld:'vBR_LAB_ABNINDTITLEFILTERDATA',pic:''},{av:'AV40BR_Lab_NormRangeLowTitleFilterData',fld:'vBR_LAB_NORMRANGELOWTITLEFILTERDATA',pic:''},{av:'AV42BR_Lab_NormRangeHighTitleFilterData',fld:'vBR_LAB_NORMRANGEHIGHTITLEFILTERDATA',pic:''},{av:'AV44BR_Lab_TestMethodTitleFilterData',fld:'vBR_LAB_TESTMETHODTITLEFILTERDATA',pic:''},{av:'AV48BR_Lab_InstrumentNameTitleFilterData',fld:'vBR_LAB_INSTRUMENTNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Lab_InstrumentCodeTitleFilterData',fld:'vBR_LAB_INSTRUMENTCODETITLEFILTERDATA',pic:''},{av:'edtBR_LabID_Titleformat',ctrl:'BR_LABID',prop:'Titleformat'},{av:'edtBR_LabID_Title',ctrl:'BR_LABID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Lab_SampleID_Titleformat',ctrl:'BR_LAB_SAMPLEID',prop:'Titleformat'},{av:'edtBR_Lab_SampleID_Title',ctrl:'BR_LAB_SAMPLEID',prop:'Title'},{av:'edtBR_Lab_TestID_Titleformat',ctrl:'BR_LAB_TESTID',prop:'Titleformat'},{av:'edtBR_Lab_TestID_Title',ctrl:'BR_LAB_TESTID',prop:'Title'},{av:'edtBR_Lab_TestCode_Titleformat',ctrl:'BR_LAB_TESTCODE',prop:'Titleformat'},{av:'edtBR_Lab_TestCode_Title',ctrl:'BR_LAB_TESTCODE',prop:'Title'},{av:'edtBR_Lab_TestName_Titleformat',ctrl:'BR_LAB_TESTNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestName_Title',ctrl:'BR_LAB_TESTNAME',prop:'Title'},{av:'edtBR_Lab_TestEngName_Titleformat',ctrl:'BR_LAB_TESTENGNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestEngName_Title',ctrl:'BR_LAB_TESTENGNAME',prop:'Title'},{av:'edtBR_Lab_Age_Titleformat',ctrl:'BR_LAB_AGE',prop:'Titleformat'},{av:'edtBR_Lab_Age_Title',ctrl:'BR_LAB_AGE',prop:'Title'},{av:'edtBR_Lab_Diag_Titleformat',ctrl:'BR_LAB_DIAG',prop:'Titleformat'},{av:'edtBR_Lab_Diag_Title',ctrl:'BR_LAB_DIAG',prop:'Title'},{av:'edtBR_Lab_SpecimenDate_Titleformat',ctrl:'BR_LAB_SPECIMENDATE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenDate_Title',ctrl:'BR_LAB_SPECIMENDATE',prop:'Title'},{av:'edtBR_Lab_ReceivingTime_Titleformat',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReceivingTime_Title',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Title'},{av:'edtBR_Lab_ReportTime_Titleformat',ctrl:'BR_LAB_REPORTTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReportTime_Title',ctrl:'BR_LAB_REPORTTIME',prop:'Title'},{av:'edtBR_Lab_SpecimenSource_Titleformat',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenSource_Title',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Title'},{av:'edtBR_Lab_ResultQual_Titleformat',ctrl:'BR_LAB_RESULTQUAL',prop:'Titleformat'},{av:'edtBR_Lab_ResultQual_Title',ctrl:'BR_LAB_RESULTQUAL',prop:'Title'},{av:'edtBR_Lab_ResultNum_Titleformat',ctrl:'BR_LAB_RESULTNUM',prop:'Titleformat'},{av:'edtBR_Lab_ResultNum_Title',ctrl:'BR_LAB_RESULTNUM',prop:'Title'},{av:'edtBR_Lab_ResultUnit_Titleformat',ctrl:'BR_LAB_RESULTUNIT',prop:'Titleformat'},{av:'edtBR_Lab_ResultUnit_Title',ctrl:'BR_LAB_RESULTUNIT',prop:'Title'},{av:'edtBR_Lab_AbnInd_Titleformat',ctrl:'BR_LAB_ABNIND',prop:'Titleformat'},{av:'edtBR_Lab_AbnInd_Title',ctrl:'BR_LAB_ABNIND',prop:'Title'},{av:'edtBR_Lab_NormRangeLow_Titleformat',ctrl:'BR_LAB_NORMRANGELOW',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeLow_Title',ctrl:'BR_LAB_NORMRANGELOW',prop:'Title'},{av:'edtBR_Lab_NormRangeHigh_Titleformat',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeHigh_Title',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Title'},{av:'edtBR_Lab_TestMethod_Titleformat',ctrl:'BR_LAB_TESTMETHOD',prop:'Titleformat'},{av:'edtBR_Lab_TestMethod_Title',ctrl:'BR_LAB_TESTMETHOD',prop:'Title'},{av:'edtBR_Lab_InstrumentName_Titleformat',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentName_Title',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Title'},{av:'edtBR_Lab_InstrumentCode_Titleformat',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentCode_Title',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED","{handler:'E153H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_SAMPLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Lab_TestIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTENGNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_BR_Lab_AgeTitleControlIdToReplace',fld:'vDDO_BR_LAB_AGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Lab_DiagTitleControlIdToReplace',fld:'vDDO_BR_LAB_DIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_RECEIVINGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_REPORTTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGELOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGEHIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTMETHODTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_information_patientno_Activeeventkey',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'AV12BR_LabIDTitleFilterData',fld:'vBR_LABIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV58BR_Lab_SampleIDTitleFilterData',fld:'vBR_LAB_SAMPLEIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Lab_TestIDTitleFilterData',fld:'vBR_LAB_TESTIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Lab_TestCodeTitleFilterData',fld:'vBR_LAB_TESTCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Lab_TestNameTitleFilterData',fld:'vBR_LAB_TESTNAMETITLEFILTERDATA',pic:''},{av:'AV60BR_Lab_TestEngNameTitleFilterData',fld:'vBR_LAB_TESTENGNAMETITLEFILTERDATA',pic:''},{av:'AV62BR_Lab_AgeTitleFilterData',fld:'vBR_LAB_AGETITLEFILTERDATA',pic:''},{av:'AV64BR_Lab_DiagTitleFilterData',fld:'vBR_LAB_DIAGTITLEFILTERDATA',pic:''},{av:'AV24BR_Lab_SpecimenDateTitleFilterData',fld:'vBR_LAB_SPECIMENDATETITLEFILTERDATA',pic:''},{av:'AV66BR_Lab_ReceivingTimeTitleFilterData',fld:'vBR_LAB_RECEIVINGTIMETITLEFILTERDATA',pic:''},{av:'AV68BR_Lab_ReportTimeTitleFilterData',fld:'vBR_LAB_REPORTTIMETITLEFILTERDATA',pic:''},{av:'AV26BR_Lab_SpecimenSourceTitleFilterData',fld:'vBR_LAB_SPECIMENSOURCETITLEFILTERDATA',pic:''},{av:'AV32BR_Lab_ResultQualTitleFilterData',fld:'vBR_LAB_RESULTQUALTITLEFILTERDATA',pic:''},{av:'AV34BR_Lab_ResultNumTitleFilterData',fld:'vBR_LAB_RESULTNUMTITLEFILTERDATA',pic:''},{av:'AV36BR_Lab_ResultUnitTitleFilterData',fld:'vBR_LAB_RESULTUNITTITLEFILTERDATA',pic:''},{av:'AV38BR_Lab_AbnIndTitleFilterData',fld:'vBR_LAB_ABNINDTITLEFILTERDATA',pic:''},{av:'AV40BR_Lab_NormRangeLowTitleFilterData',fld:'vBR_LAB_NORMRANGELOWTITLEFILTERDATA',pic:''},{av:'AV42BR_Lab_NormRangeHighTitleFilterData',fld:'vBR_LAB_NORMRANGEHIGHTITLEFILTERDATA',pic:''},{av:'AV44BR_Lab_TestMethodTitleFilterData',fld:'vBR_LAB_TESTMETHODTITLEFILTERDATA',pic:''},{av:'AV48BR_Lab_InstrumentNameTitleFilterData',fld:'vBR_LAB_INSTRUMENTNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Lab_InstrumentCodeTitleFilterData',fld:'vBR_LAB_INSTRUMENTCODETITLEFILTERDATA',pic:''},{av:'edtBR_LabID_Titleformat',ctrl:'BR_LABID',prop:'Titleformat'},{av:'edtBR_LabID_Title',ctrl:'BR_LABID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Lab_SampleID_Titleformat',ctrl:'BR_LAB_SAMPLEID',prop:'Titleformat'},{av:'edtBR_Lab_SampleID_Title',ctrl:'BR_LAB_SAMPLEID',prop:'Title'},{av:'edtBR_Lab_TestID_Titleformat',ctrl:'BR_LAB_TESTID',prop:'Titleformat'},{av:'edtBR_Lab_TestID_Title',ctrl:'BR_LAB_TESTID',prop:'Title'},{av:'edtBR_Lab_TestCode_Titleformat',ctrl:'BR_LAB_TESTCODE',prop:'Titleformat'},{av:'edtBR_Lab_TestCode_Title',ctrl:'BR_LAB_TESTCODE',prop:'Title'},{av:'edtBR_Lab_TestName_Titleformat',ctrl:'BR_LAB_TESTNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestName_Title',ctrl:'BR_LAB_TESTNAME',prop:'Title'},{av:'edtBR_Lab_TestEngName_Titleformat',ctrl:'BR_LAB_TESTENGNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestEngName_Title',ctrl:'BR_LAB_TESTENGNAME',prop:'Title'},{av:'edtBR_Lab_Age_Titleformat',ctrl:'BR_LAB_AGE',prop:'Titleformat'},{av:'edtBR_Lab_Age_Title',ctrl:'BR_LAB_AGE',prop:'Title'},{av:'edtBR_Lab_Diag_Titleformat',ctrl:'BR_LAB_DIAG',prop:'Titleformat'},{av:'edtBR_Lab_Diag_Title',ctrl:'BR_LAB_DIAG',prop:'Title'},{av:'edtBR_Lab_SpecimenDate_Titleformat',ctrl:'BR_LAB_SPECIMENDATE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenDate_Title',ctrl:'BR_LAB_SPECIMENDATE',prop:'Title'},{av:'edtBR_Lab_ReceivingTime_Titleformat',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReceivingTime_Title',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Title'},{av:'edtBR_Lab_ReportTime_Titleformat',ctrl:'BR_LAB_REPORTTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReportTime_Title',ctrl:'BR_LAB_REPORTTIME',prop:'Title'},{av:'edtBR_Lab_SpecimenSource_Titleformat',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenSource_Title',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Title'},{av:'edtBR_Lab_ResultQual_Titleformat',ctrl:'BR_LAB_RESULTQUAL',prop:'Titleformat'},{av:'edtBR_Lab_ResultQual_Title',ctrl:'BR_LAB_RESULTQUAL',prop:'Title'},{av:'edtBR_Lab_ResultNum_Titleformat',ctrl:'BR_LAB_RESULTNUM',prop:'Titleformat'},{av:'edtBR_Lab_ResultNum_Title',ctrl:'BR_LAB_RESULTNUM',prop:'Title'},{av:'edtBR_Lab_ResultUnit_Titleformat',ctrl:'BR_LAB_RESULTUNIT',prop:'Titleformat'},{av:'edtBR_Lab_ResultUnit_Title',ctrl:'BR_LAB_RESULTUNIT',prop:'Title'},{av:'edtBR_Lab_AbnInd_Titleformat',ctrl:'BR_LAB_ABNIND',prop:'Titleformat'},{av:'edtBR_Lab_AbnInd_Title',ctrl:'BR_LAB_ABNIND',prop:'Title'},{av:'edtBR_Lab_NormRangeLow_Titleformat',ctrl:'BR_LAB_NORMRANGELOW',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeLow_Title',ctrl:'BR_LAB_NORMRANGELOW',prop:'Title'},{av:'edtBR_Lab_NormRangeHigh_Titleformat',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeHigh_Title',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Title'},{av:'edtBR_Lab_TestMethod_Titleformat',ctrl:'BR_LAB_TESTMETHOD',prop:'Titleformat'},{av:'edtBR_Lab_TestMethod_Title',ctrl:'BR_LAB_TESTMETHOD',prop:'Title'},{av:'edtBR_Lab_InstrumentName_Titleformat',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentName_Title',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Title'},{av:'edtBR_Lab_InstrumentCode_Titleformat',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentCode_Title',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_LAB_SAMPLEID.ONOPTIONCLICKED","{handler:'E163H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_SAMPLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Lab_TestIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTENGNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_BR_Lab_AgeTitleControlIdToReplace',fld:'vDDO_BR_LAB_AGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Lab_DiagTitleControlIdToReplace',fld:'vDDO_BR_LAB_DIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_RECEIVINGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_REPORTTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGELOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGEHIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTMETHODTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_lab_sampleid_Activeeventkey',ctrl:'DDO_BR_LAB_SAMPLEID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_LAB_SAMPLEID.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_lab_sampleid_Sortedstatus',ctrl:'DDO_BR_LAB_SAMPLEID',prop:'SortedStatus'},{av:'AV12BR_LabIDTitleFilterData',fld:'vBR_LABIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV58BR_Lab_SampleIDTitleFilterData',fld:'vBR_LAB_SAMPLEIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Lab_TestIDTitleFilterData',fld:'vBR_LAB_TESTIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Lab_TestCodeTitleFilterData',fld:'vBR_LAB_TESTCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Lab_TestNameTitleFilterData',fld:'vBR_LAB_TESTNAMETITLEFILTERDATA',pic:''},{av:'AV60BR_Lab_TestEngNameTitleFilterData',fld:'vBR_LAB_TESTENGNAMETITLEFILTERDATA',pic:''},{av:'AV62BR_Lab_AgeTitleFilterData',fld:'vBR_LAB_AGETITLEFILTERDATA',pic:''},{av:'AV64BR_Lab_DiagTitleFilterData',fld:'vBR_LAB_DIAGTITLEFILTERDATA',pic:''},{av:'AV24BR_Lab_SpecimenDateTitleFilterData',fld:'vBR_LAB_SPECIMENDATETITLEFILTERDATA',pic:''},{av:'AV66BR_Lab_ReceivingTimeTitleFilterData',fld:'vBR_LAB_RECEIVINGTIMETITLEFILTERDATA',pic:''},{av:'AV68BR_Lab_ReportTimeTitleFilterData',fld:'vBR_LAB_REPORTTIMETITLEFILTERDATA',pic:''},{av:'AV26BR_Lab_SpecimenSourceTitleFilterData',fld:'vBR_LAB_SPECIMENSOURCETITLEFILTERDATA',pic:''},{av:'AV32BR_Lab_ResultQualTitleFilterData',fld:'vBR_LAB_RESULTQUALTITLEFILTERDATA',pic:''},{av:'AV34BR_Lab_ResultNumTitleFilterData',fld:'vBR_LAB_RESULTNUMTITLEFILTERDATA',pic:''},{av:'AV36BR_Lab_ResultUnitTitleFilterData',fld:'vBR_LAB_RESULTUNITTITLEFILTERDATA',pic:''},{av:'AV38BR_Lab_AbnIndTitleFilterData',fld:'vBR_LAB_ABNINDTITLEFILTERDATA',pic:''},{av:'AV40BR_Lab_NormRangeLowTitleFilterData',fld:'vBR_LAB_NORMRANGELOWTITLEFILTERDATA',pic:''},{av:'AV42BR_Lab_NormRangeHighTitleFilterData',fld:'vBR_LAB_NORMRANGEHIGHTITLEFILTERDATA',pic:''},{av:'AV44BR_Lab_TestMethodTitleFilterData',fld:'vBR_LAB_TESTMETHODTITLEFILTERDATA',pic:''},{av:'AV48BR_Lab_InstrumentNameTitleFilterData',fld:'vBR_LAB_INSTRUMENTNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Lab_InstrumentCodeTitleFilterData',fld:'vBR_LAB_INSTRUMENTCODETITLEFILTERDATA',pic:''},{av:'edtBR_LabID_Titleformat',ctrl:'BR_LABID',prop:'Titleformat'},{av:'edtBR_LabID_Title',ctrl:'BR_LABID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Lab_SampleID_Titleformat',ctrl:'BR_LAB_SAMPLEID',prop:'Titleformat'},{av:'edtBR_Lab_SampleID_Title',ctrl:'BR_LAB_SAMPLEID',prop:'Title'},{av:'edtBR_Lab_TestID_Titleformat',ctrl:'BR_LAB_TESTID',prop:'Titleformat'},{av:'edtBR_Lab_TestID_Title',ctrl:'BR_LAB_TESTID',prop:'Title'},{av:'edtBR_Lab_TestCode_Titleformat',ctrl:'BR_LAB_TESTCODE',prop:'Titleformat'},{av:'edtBR_Lab_TestCode_Title',ctrl:'BR_LAB_TESTCODE',prop:'Title'},{av:'edtBR_Lab_TestName_Titleformat',ctrl:'BR_LAB_TESTNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestName_Title',ctrl:'BR_LAB_TESTNAME',prop:'Title'},{av:'edtBR_Lab_TestEngName_Titleformat',ctrl:'BR_LAB_TESTENGNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestEngName_Title',ctrl:'BR_LAB_TESTENGNAME',prop:'Title'},{av:'edtBR_Lab_Age_Titleformat',ctrl:'BR_LAB_AGE',prop:'Titleformat'},{av:'edtBR_Lab_Age_Title',ctrl:'BR_LAB_AGE',prop:'Title'},{av:'edtBR_Lab_Diag_Titleformat',ctrl:'BR_LAB_DIAG',prop:'Titleformat'},{av:'edtBR_Lab_Diag_Title',ctrl:'BR_LAB_DIAG',prop:'Title'},{av:'edtBR_Lab_SpecimenDate_Titleformat',ctrl:'BR_LAB_SPECIMENDATE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenDate_Title',ctrl:'BR_LAB_SPECIMENDATE',prop:'Title'},{av:'edtBR_Lab_ReceivingTime_Titleformat',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReceivingTime_Title',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Title'},{av:'edtBR_Lab_ReportTime_Titleformat',ctrl:'BR_LAB_REPORTTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReportTime_Title',ctrl:'BR_LAB_REPORTTIME',prop:'Title'},{av:'edtBR_Lab_SpecimenSource_Titleformat',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenSource_Title',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Title'},{av:'edtBR_Lab_ResultQual_Titleformat',ctrl:'BR_LAB_RESULTQUAL',prop:'Titleformat'},{av:'edtBR_Lab_ResultQual_Title',ctrl:'BR_LAB_RESULTQUAL',prop:'Title'},{av:'edtBR_Lab_ResultNum_Titleformat',ctrl:'BR_LAB_RESULTNUM',prop:'Titleformat'},{av:'edtBR_Lab_ResultNum_Title',ctrl:'BR_LAB_RESULTNUM',prop:'Title'},{av:'edtBR_Lab_ResultUnit_Titleformat',ctrl:'BR_LAB_RESULTUNIT',prop:'Titleformat'},{av:'edtBR_Lab_ResultUnit_Title',ctrl:'BR_LAB_RESULTUNIT',prop:'Title'},{av:'edtBR_Lab_AbnInd_Titleformat',ctrl:'BR_LAB_ABNIND',prop:'Titleformat'},{av:'edtBR_Lab_AbnInd_Title',ctrl:'BR_LAB_ABNIND',prop:'Title'},{av:'edtBR_Lab_NormRangeLow_Titleformat',ctrl:'BR_LAB_NORMRANGELOW',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeLow_Title',ctrl:'BR_LAB_NORMRANGELOW',prop:'Title'},{av:'edtBR_Lab_NormRangeHigh_Titleformat',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeHigh_Title',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Title'},{av:'edtBR_Lab_TestMethod_Titleformat',ctrl:'BR_LAB_TESTMETHOD',prop:'Titleformat'},{av:'edtBR_Lab_TestMethod_Title',ctrl:'BR_LAB_TESTMETHOD',prop:'Title'},{av:'edtBR_Lab_InstrumentName_Titleformat',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentName_Title',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Title'},{av:'edtBR_Lab_InstrumentCode_Titleformat',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentCode_Title',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_LAB_TESTID.ONOPTIONCLICKED","{handler:'E173H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_SAMPLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Lab_TestIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTENGNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_BR_Lab_AgeTitleControlIdToReplace',fld:'vDDO_BR_LAB_AGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Lab_DiagTitleControlIdToReplace',fld:'vDDO_BR_LAB_DIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_RECEIVINGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_REPORTTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGELOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGEHIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTMETHODTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_lab_testid_Activeeventkey',ctrl:'DDO_BR_LAB_TESTID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_LAB_TESTID.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_lab_testid_Sortedstatus',ctrl:'DDO_BR_LAB_TESTID',prop:'SortedStatus'},{av:'AV12BR_LabIDTitleFilterData',fld:'vBR_LABIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV58BR_Lab_SampleIDTitleFilterData',fld:'vBR_LAB_SAMPLEIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Lab_TestIDTitleFilterData',fld:'vBR_LAB_TESTIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Lab_TestCodeTitleFilterData',fld:'vBR_LAB_TESTCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Lab_TestNameTitleFilterData',fld:'vBR_LAB_TESTNAMETITLEFILTERDATA',pic:''},{av:'AV60BR_Lab_TestEngNameTitleFilterData',fld:'vBR_LAB_TESTENGNAMETITLEFILTERDATA',pic:''},{av:'AV62BR_Lab_AgeTitleFilterData',fld:'vBR_LAB_AGETITLEFILTERDATA',pic:''},{av:'AV64BR_Lab_DiagTitleFilterData',fld:'vBR_LAB_DIAGTITLEFILTERDATA',pic:''},{av:'AV24BR_Lab_SpecimenDateTitleFilterData',fld:'vBR_LAB_SPECIMENDATETITLEFILTERDATA',pic:''},{av:'AV66BR_Lab_ReceivingTimeTitleFilterData',fld:'vBR_LAB_RECEIVINGTIMETITLEFILTERDATA',pic:''},{av:'AV68BR_Lab_ReportTimeTitleFilterData',fld:'vBR_LAB_REPORTTIMETITLEFILTERDATA',pic:''},{av:'AV26BR_Lab_SpecimenSourceTitleFilterData',fld:'vBR_LAB_SPECIMENSOURCETITLEFILTERDATA',pic:''},{av:'AV32BR_Lab_ResultQualTitleFilterData',fld:'vBR_LAB_RESULTQUALTITLEFILTERDATA',pic:''},{av:'AV34BR_Lab_ResultNumTitleFilterData',fld:'vBR_LAB_RESULTNUMTITLEFILTERDATA',pic:''},{av:'AV36BR_Lab_ResultUnitTitleFilterData',fld:'vBR_LAB_RESULTUNITTITLEFILTERDATA',pic:''},{av:'AV38BR_Lab_AbnIndTitleFilterData',fld:'vBR_LAB_ABNINDTITLEFILTERDATA',pic:''},{av:'AV40BR_Lab_NormRangeLowTitleFilterData',fld:'vBR_LAB_NORMRANGELOWTITLEFILTERDATA',pic:''},{av:'AV42BR_Lab_NormRangeHighTitleFilterData',fld:'vBR_LAB_NORMRANGEHIGHTITLEFILTERDATA',pic:''},{av:'AV44BR_Lab_TestMethodTitleFilterData',fld:'vBR_LAB_TESTMETHODTITLEFILTERDATA',pic:''},{av:'AV48BR_Lab_InstrumentNameTitleFilterData',fld:'vBR_LAB_INSTRUMENTNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Lab_InstrumentCodeTitleFilterData',fld:'vBR_LAB_INSTRUMENTCODETITLEFILTERDATA',pic:''},{av:'edtBR_LabID_Titleformat',ctrl:'BR_LABID',prop:'Titleformat'},{av:'edtBR_LabID_Title',ctrl:'BR_LABID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Lab_SampleID_Titleformat',ctrl:'BR_LAB_SAMPLEID',prop:'Titleformat'},{av:'edtBR_Lab_SampleID_Title',ctrl:'BR_LAB_SAMPLEID',prop:'Title'},{av:'edtBR_Lab_TestID_Titleformat',ctrl:'BR_LAB_TESTID',prop:'Titleformat'},{av:'edtBR_Lab_TestID_Title',ctrl:'BR_LAB_TESTID',prop:'Title'},{av:'edtBR_Lab_TestCode_Titleformat',ctrl:'BR_LAB_TESTCODE',prop:'Titleformat'},{av:'edtBR_Lab_TestCode_Title',ctrl:'BR_LAB_TESTCODE',prop:'Title'},{av:'edtBR_Lab_TestName_Titleformat',ctrl:'BR_LAB_TESTNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestName_Title',ctrl:'BR_LAB_TESTNAME',prop:'Title'},{av:'edtBR_Lab_TestEngName_Titleformat',ctrl:'BR_LAB_TESTENGNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestEngName_Title',ctrl:'BR_LAB_TESTENGNAME',prop:'Title'},{av:'edtBR_Lab_Age_Titleformat',ctrl:'BR_LAB_AGE',prop:'Titleformat'},{av:'edtBR_Lab_Age_Title',ctrl:'BR_LAB_AGE',prop:'Title'},{av:'edtBR_Lab_Diag_Titleformat',ctrl:'BR_LAB_DIAG',prop:'Titleformat'},{av:'edtBR_Lab_Diag_Title',ctrl:'BR_LAB_DIAG',prop:'Title'},{av:'edtBR_Lab_SpecimenDate_Titleformat',ctrl:'BR_LAB_SPECIMENDATE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenDate_Title',ctrl:'BR_LAB_SPECIMENDATE',prop:'Title'},{av:'edtBR_Lab_ReceivingTime_Titleformat',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReceivingTime_Title',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Title'},{av:'edtBR_Lab_ReportTime_Titleformat',ctrl:'BR_LAB_REPORTTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReportTime_Title',ctrl:'BR_LAB_REPORTTIME',prop:'Title'},{av:'edtBR_Lab_SpecimenSource_Titleformat',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenSource_Title',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Title'},{av:'edtBR_Lab_ResultQual_Titleformat',ctrl:'BR_LAB_RESULTQUAL',prop:'Titleformat'},{av:'edtBR_Lab_ResultQual_Title',ctrl:'BR_LAB_RESULTQUAL',prop:'Title'},{av:'edtBR_Lab_ResultNum_Titleformat',ctrl:'BR_LAB_RESULTNUM',prop:'Titleformat'},{av:'edtBR_Lab_ResultNum_Title',ctrl:'BR_LAB_RESULTNUM',prop:'Title'},{av:'edtBR_Lab_ResultUnit_Titleformat',ctrl:'BR_LAB_RESULTUNIT',prop:'Titleformat'},{av:'edtBR_Lab_ResultUnit_Title',ctrl:'BR_LAB_RESULTUNIT',prop:'Title'},{av:'edtBR_Lab_AbnInd_Titleformat',ctrl:'BR_LAB_ABNIND',prop:'Titleformat'},{av:'edtBR_Lab_AbnInd_Title',ctrl:'BR_LAB_ABNIND',prop:'Title'},{av:'edtBR_Lab_NormRangeLow_Titleformat',ctrl:'BR_LAB_NORMRANGELOW',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeLow_Title',ctrl:'BR_LAB_NORMRANGELOW',prop:'Title'},{av:'edtBR_Lab_NormRangeHigh_Titleformat',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeHigh_Title',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Title'},{av:'edtBR_Lab_TestMethod_Titleformat',ctrl:'BR_LAB_TESTMETHOD',prop:'Titleformat'},{av:'edtBR_Lab_TestMethod_Title',ctrl:'BR_LAB_TESTMETHOD',prop:'Title'},{av:'edtBR_Lab_InstrumentName_Titleformat',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentName_Title',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Title'},{av:'edtBR_Lab_InstrumentCode_Titleformat',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentCode_Title',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_LAB_TESTCODE.ONOPTIONCLICKED","{handler:'E183H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_SAMPLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Lab_TestIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTENGNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_BR_Lab_AgeTitleControlIdToReplace',fld:'vDDO_BR_LAB_AGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Lab_DiagTitleControlIdToReplace',fld:'vDDO_BR_LAB_DIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_RECEIVINGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_REPORTTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGELOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGEHIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTMETHODTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_lab_testcode_Activeeventkey',ctrl:'DDO_BR_LAB_TESTCODE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_LAB_TESTCODE.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_lab_testcode_Sortedstatus',ctrl:'DDO_BR_LAB_TESTCODE',prop:'SortedStatus'},{av:'AV12BR_LabIDTitleFilterData',fld:'vBR_LABIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV58BR_Lab_SampleIDTitleFilterData',fld:'vBR_LAB_SAMPLEIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Lab_TestIDTitleFilterData',fld:'vBR_LAB_TESTIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Lab_TestCodeTitleFilterData',fld:'vBR_LAB_TESTCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Lab_TestNameTitleFilterData',fld:'vBR_LAB_TESTNAMETITLEFILTERDATA',pic:''},{av:'AV60BR_Lab_TestEngNameTitleFilterData',fld:'vBR_LAB_TESTENGNAMETITLEFILTERDATA',pic:''},{av:'AV62BR_Lab_AgeTitleFilterData',fld:'vBR_LAB_AGETITLEFILTERDATA',pic:''},{av:'AV64BR_Lab_DiagTitleFilterData',fld:'vBR_LAB_DIAGTITLEFILTERDATA',pic:''},{av:'AV24BR_Lab_SpecimenDateTitleFilterData',fld:'vBR_LAB_SPECIMENDATETITLEFILTERDATA',pic:''},{av:'AV66BR_Lab_ReceivingTimeTitleFilterData',fld:'vBR_LAB_RECEIVINGTIMETITLEFILTERDATA',pic:''},{av:'AV68BR_Lab_ReportTimeTitleFilterData',fld:'vBR_LAB_REPORTTIMETITLEFILTERDATA',pic:''},{av:'AV26BR_Lab_SpecimenSourceTitleFilterData',fld:'vBR_LAB_SPECIMENSOURCETITLEFILTERDATA',pic:''},{av:'AV32BR_Lab_ResultQualTitleFilterData',fld:'vBR_LAB_RESULTQUALTITLEFILTERDATA',pic:''},{av:'AV34BR_Lab_ResultNumTitleFilterData',fld:'vBR_LAB_RESULTNUMTITLEFILTERDATA',pic:''},{av:'AV36BR_Lab_ResultUnitTitleFilterData',fld:'vBR_LAB_RESULTUNITTITLEFILTERDATA',pic:''},{av:'AV38BR_Lab_AbnIndTitleFilterData',fld:'vBR_LAB_ABNINDTITLEFILTERDATA',pic:''},{av:'AV40BR_Lab_NormRangeLowTitleFilterData',fld:'vBR_LAB_NORMRANGELOWTITLEFILTERDATA',pic:''},{av:'AV42BR_Lab_NormRangeHighTitleFilterData',fld:'vBR_LAB_NORMRANGEHIGHTITLEFILTERDATA',pic:''},{av:'AV44BR_Lab_TestMethodTitleFilterData',fld:'vBR_LAB_TESTMETHODTITLEFILTERDATA',pic:''},{av:'AV48BR_Lab_InstrumentNameTitleFilterData',fld:'vBR_LAB_INSTRUMENTNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Lab_InstrumentCodeTitleFilterData',fld:'vBR_LAB_INSTRUMENTCODETITLEFILTERDATA',pic:''},{av:'edtBR_LabID_Titleformat',ctrl:'BR_LABID',prop:'Titleformat'},{av:'edtBR_LabID_Title',ctrl:'BR_LABID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Lab_SampleID_Titleformat',ctrl:'BR_LAB_SAMPLEID',prop:'Titleformat'},{av:'edtBR_Lab_SampleID_Title',ctrl:'BR_LAB_SAMPLEID',prop:'Title'},{av:'edtBR_Lab_TestID_Titleformat',ctrl:'BR_LAB_TESTID',prop:'Titleformat'},{av:'edtBR_Lab_TestID_Title',ctrl:'BR_LAB_TESTID',prop:'Title'},{av:'edtBR_Lab_TestCode_Titleformat',ctrl:'BR_LAB_TESTCODE',prop:'Titleformat'},{av:'edtBR_Lab_TestCode_Title',ctrl:'BR_LAB_TESTCODE',prop:'Title'},{av:'edtBR_Lab_TestName_Titleformat',ctrl:'BR_LAB_TESTNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestName_Title',ctrl:'BR_LAB_TESTNAME',prop:'Title'},{av:'edtBR_Lab_TestEngName_Titleformat',ctrl:'BR_LAB_TESTENGNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestEngName_Title',ctrl:'BR_LAB_TESTENGNAME',prop:'Title'},{av:'edtBR_Lab_Age_Titleformat',ctrl:'BR_LAB_AGE',prop:'Titleformat'},{av:'edtBR_Lab_Age_Title',ctrl:'BR_LAB_AGE',prop:'Title'},{av:'edtBR_Lab_Diag_Titleformat',ctrl:'BR_LAB_DIAG',prop:'Titleformat'},{av:'edtBR_Lab_Diag_Title',ctrl:'BR_LAB_DIAG',prop:'Title'},{av:'edtBR_Lab_SpecimenDate_Titleformat',ctrl:'BR_LAB_SPECIMENDATE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenDate_Title',ctrl:'BR_LAB_SPECIMENDATE',prop:'Title'},{av:'edtBR_Lab_ReceivingTime_Titleformat',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReceivingTime_Title',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Title'},{av:'edtBR_Lab_ReportTime_Titleformat',ctrl:'BR_LAB_REPORTTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReportTime_Title',ctrl:'BR_LAB_REPORTTIME',prop:'Title'},{av:'edtBR_Lab_SpecimenSource_Titleformat',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenSource_Title',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Title'},{av:'edtBR_Lab_ResultQual_Titleformat',ctrl:'BR_LAB_RESULTQUAL',prop:'Titleformat'},{av:'edtBR_Lab_ResultQual_Title',ctrl:'BR_LAB_RESULTQUAL',prop:'Title'},{av:'edtBR_Lab_ResultNum_Titleformat',ctrl:'BR_LAB_RESULTNUM',prop:'Titleformat'},{av:'edtBR_Lab_ResultNum_Title',ctrl:'BR_LAB_RESULTNUM',prop:'Title'},{av:'edtBR_Lab_ResultUnit_Titleformat',ctrl:'BR_LAB_RESULTUNIT',prop:'Titleformat'},{av:'edtBR_Lab_ResultUnit_Title',ctrl:'BR_LAB_RESULTUNIT',prop:'Title'},{av:'edtBR_Lab_AbnInd_Titleformat',ctrl:'BR_LAB_ABNIND',prop:'Titleformat'},{av:'edtBR_Lab_AbnInd_Title',ctrl:'BR_LAB_ABNIND',prop:'Title'},{av:'edtBR_Lab_NormRangeLow_Titleformat',ctrl:'BR_LAB_NORMRANGELOW',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeLow_Title',ctrl:'BR_LAB_NORMRANGELOW',prop:'Title'},{av:'edtBR_Lab_NormRangeHigh_Titleformat',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeHigh_Title',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Title'},{av:'edtBR_Lab_TestMethod_Titleformat',ctrl:'BR_LAB_TESTMETHOD',prop:'Titleformat'},{av:'edtBR_Lab_TestMethod_Title',ctrl:'BR_LAB_TESTMETHOD',prop:'Title'},{av:'edtBR_Lab_InstrumentName_Titleformat',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentName_Title',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Title'},{av:'edtBR_Lab_InstrumentCode_Titleformat',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentCode_Title',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_LAB_TESTNAME.ONOPTIONCLICKED","{handler:'E193H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_SAMPLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Lab_TestIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTENGNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_BR_Lab_AgeTitleControlIdToReplace',fld:'vDDO_BR_LAB_AGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Lab_DiagTitleControlIdToReplace',fld:'vDDO_BR_LAB_DIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_RECEIVINGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_REPORTTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGELOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGEHIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTMETHODTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_lab_testname_Activeeventkey',ctrl:'DDO_BR_LAB_TESTNAME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_LAB_TESTNAME.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_lab_testname_Sortedstatus',ctrl:'DDO_BR_LAB_TESTNAME',prop:'SortedStatus'},{av:'AV12BR_LabIDTitleFilterData',fld:'vBR_LABIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV58BR_Lab_SampleIDTitleFilterData',fld:'vBR_LAB_SAMPLEIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Lab_TestIDTitleFilterData',fld:'vBR_LAB_TESTIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Lab_TestCodeTitleFilterData',fld:'vBR_LAB_TESTCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Lab_TestNameTitleFilterData',fld:'vBR_LAB_TESTNAMETITLEFILTERDATA',pic:''},{av:'AV60BR_Lab_TestEngNameTitleFilterData',fld:'vBR_LAB_TESTENGNAMETITLEFILTERDATA',pic:''},{av:'AV62BR_Lab_AgeTitleFilterData',fld:'vBR_LAB_AGETITLEFILTERDATA',pic:''},{av:'AV64BR_Lab_DiagTitleFilterData',fld:'vBR_LAB_DIAGTITLEFILTERDATA',pic:''},{av:'AV24BR_Lab_SpecimenDateTitleFilterData',fld:'vBR_LAB_SPECIMENDATETITLEFILTERDATA',pic:''},{av:'AV66BR_Lab_ReceivingTimeTitleFilterData',fld:'vBR_LAB_RECEIVINGTIMETITLEFILTERDATA',pic:''},{av:'AV68BR_Lab_ReportTimeTitleFilterData',fld:'vBR_LAB_REPORTTIMETITLEFILTERDATA',pic:''},{av:'AV26BR_Lab_SpecimenSourceTitleFilterData',fld:'vBR_LAB_SPECIMENSOURCETITLEFILTERDATA',pic:''},{av:'AV32BR_Lab_ResultQualTitleFilterData',fld:'vBR_LAB_RESULTQUALTITLEFILTERDATA',pic:''},{av:'AV34BR_Lab_ResultNumTitleFilterData',fld:'vBR_LAB_RESULTNUMTITLEFILTERDATA',pic:''},{av:'AV36BR_Lab_ResultUnitTitleFilterData',fld:'vBR_LAB_RESULTUNITTITLEFILTERDATA',pic:''},{av:'AV38BR_Lab_AbnIndTitleFilterData',fld:'vBR_LAB_ABNINDTITLEFILTERDATA',pic:''},{av:'AV40BR_Lab_NormRangeLowTitleFilterData',fld:'vBR_LAB_NORMRANGELOWTITLEFILTERDATA',pic:''},{av:'AV42BR_Lab_NormRangeHighTitleFilterData',fld:'vBR_LAB_NORMRANGEHIGHTITLEFILTERDATA',pic:''},{av:'AV44BR_Lab_TestMethodTitleFilterData',fld:'vBR_LAB_TESTMETHODTITLEFILTERDATA',pic:''},{av:'AV48BR_Lab_InstrumentNameTitleFilterData',fld:'vBR_LAB_INSTRUMENTNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Lab_InstrumentCodeTitleFilterData',fld:'vBR_LAB_INSTRUMENTCODETITLEFILTERDATA',pic:''},{av:'edtBR_LabID_Titleformat',ctrl:'BR_LABID',prop:'Titleformat'},{av:'edtBR_LabID_Title',ctrl:'BR_LABID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Lab_SampleID_Titleformat',ctrl:'BR_LAB_SAMPLEID',prop:'Titleformat'},{av:'edtBR_Lab_SampleID_Title',ctrl:'BR_LAB_SAMPLEID',prop:'Title'},{av:'edtBR_Lab_TestID_Titleformat',ctrl:'BR_LAB_TESTID',prop:'Titleformat'},{av:'edtBR_Lab_TestID_Title',ctrl:'BR_LAB_TESTID',prop:'Title'},{av:'edtBR_Lab_TestCode_Titleformat',ctrl:'BR_LAB_TESTCODE',prop:'Titleformat'},{av:'edtBR_Lab_TestCode_Title',ctrl:'BR_LAB_TESTCODE',prop:'Title'},{av:'edtBR_Lab_TestName_Titleformat',ctrl:'BR_LAB_TESTNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestName_Title',ctrl:'BR_LAB_TESTNAME',prop:'Title'},{av:'edtBR_Lab_TestEngName_Titleformat',ctrl:'BR_LAB_TESTENGNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestEngName_Title',ctrl:'BR_LAB_TESTENGNAME',prop:'Title'},{av:'edtBR_Lab_Age_Titleformat',ctrl:'BR_LAB_AGE',prop:'Titleformat'},{av:'edtBR_Lab_Age_Title',ctrl:'BR_LAB_AGE',prop:'Title'},{av:'edtBR_Lab_Diag_Titleformat',ctrl:'BR_LAB_DIAG',prop:'Titleformat'},{av:'edtBR_Lab_Diag_Title',ctrl:'BR_LAB_DIAG',prop:'Title'},{av:'edtBR_Lab_SpecimenDate_Titleformat',ctrl:'BR_LAB_SPECIMENDATE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenDate_Title',ctrl:'BR_LAB_SPECIMENDATE',prop:'Title'},{av:'edtBR_Lab_ReceivingTime_Titleformat',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReceivingTime_Title',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Title'},{av:'edtBR_Lab_ReportTime_Titleformat',ctrl:'BR_LAB_REPORTTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReportTime_Title',ctrl:'BR_LAB_REPORTTIME',prop:'Title'},{av:'edtBR_Lab_SpecimenSource_Titleformat',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenSource_Title',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Title'},{av:'edtBR_Lab_ResultQual_Titleformat',ctrl:'BR_LAB_RESULTQUAL',prop:'Titleformat'},{av:'edtBR_Lab_ResultQual_Title',ctrl:'BR_LAB_RESULTQUAL',prop:'Title'},{av:'edtBR_Lab_ResultNum_Titleformat',ctrl:'BR_LAB_RESULTNUM',prop:'Titleformat'},{av:'edtBR_Lab_ResultNum_Title',ctrl:'BR_LAB_RESULTNUM',prop:'Title'},{av:'edtBR_Lab_ResultUnit_Titleformat',ctrl:'BR_LAB_RESULTUNIT',prop:'Titleformat'},{av:'edtBR_Lab_ResultUnit_Title',ctrl:'BR_LAB_RESULTUNIT',prop:'Title'},{av:'edtBR_Lab_AbnInd_Titleformat',ctrl:'BR_LAB_ABNIND',prop:'Titleformat'},{av:'edtBR_Lab_AbnInd_Title',ctrl:'BR_LAB_ABNIND',prop:'Title'},{av:'edtBR_Lab_NormRangeLow_Titleformat',ctrl:'BR_LAB_NORMRANGELOW',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeLow_Title',ctrl:'BR_LAB_NORMRANGELOW',prop:'Title'},{av:'edtBR_Lab_NormRangeHigh_Titleformat',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeHigh_Title',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Title'},{av:'edtBR_Lab_TestMethod_Titleformat',ctrl:'BR_LAB_TESTMETHOD',prop:'Titleformat'},{av:'edtBR_Lab_TestMethod_Title',ctrl:'BR_LAB_TESTMETHOD',prop:'Title'},{av:'edtBR_Lab_InstrumentName_Titleformat',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentName_Title',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Title'},{av:'edtBR_Lab_InstrumentCode_Titleformat',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentCode_Title',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_LAB_TESTENGNAME.ONOPTIONCLICKED","{handler:'E203H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_SAMPLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Lab_TestIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTENGNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_BR_Lab_AgeTitleControlIdToReplace',fld:'vDDO_BR_LAB_AGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Lab_DiagTitleControlIdToReplace',fld:'vDDO_BR_LAB_DIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_RECEIVINGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_REPORTTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGELOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGEHIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTMETHODTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_lab_testengname_Activeeventkey',ctrl:'DDO_BR_LAB_TESTENGNAME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_LAB_TESTENGNAME.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_lab_testengname_Sortedstatus',ctrl:'DDO_BR_LAB_TESTENGNAME',prop:'SortedStatus'},{av:'AV12BR_LabIDTitleFilterData',fld:'vBR_LABIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV58BR_Lab_SampleIDTitleFilterData',fld:'vBR_LAB_SAMPLEIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Lab_TestIDTitleFilterData',fld:'vBR_LAB_TESTIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Lab_TestCodeTitleFilterData',fld:'vBR_LAB_TESTCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Lab_TestNameTitleFilterData',fld:'vBR_LAB_TESTNAMETITLEFILTERDATA',pic:''},{av:'AV60BR_Lab_TestEngNameTitleFilterData',fld:'vBR_LAB_TESTENGNAMETITLEFILTERDATA',pic:''},{av:'AV62BR_Lab_AgeTitleFilterData',fld:'vBR_LAB_AGETITLEFILTERDATA',pic:''},{av:'AV64BR_Lab_DiagTitleFilterData',fld:'vBR_LAB_DIAGTITLEFILTERDATA',pic:''},{av:'AV24BR_Lab_SpecimenDateTitleFilterData',fld:'vBR_LAB_SPECIMENDATETITLEFILTERDATA',pic:''},{av:'AV66BR_Lab_ReceivingTimeTitleFilterData',fld:'vBR_LAB_RECEIVINGTIMETITLEFILTERDATA',pic:''},{av:'AV68BR_Lab_ReportTimeTitleFilterData',fld:'vBR_LAB_REPORTTIMETITLEFILTERDATA',pic:''},{av:'AV26BR_Lab_SpecimenSourceTitleFilterData',fld:'vBR_LAB_SPECIMENSOURCETITLEFILTERDATA',pic:''},{av:'AV32BR_Lab_ResultQualTitleFilterData',fld:'vBR_LAB_RESULTQUALTITLEFILTERDATA',pic:''},{av:'AV34BR_Lab_ResultNumTitleFilterData',fld:'vBR_LAB_RESULTNUMTITLEFILTERDATA',pic:''},{av:'AV36BR_Lab_ResultUnitTitleFilterData',fld:'vBR_LAB_RESULTUNITTITLEFILTERDATA',pic:''},{av:'AV38BR_Lab_AbnIndTitleFilterData',fld:'vBR_LAB_ABNINDTITLEFILTERDATA',pic:''},{av:'AV40BR_Lab_NormRangeLowTitleFilterData',fld:'vBR_LAB_NORMRANGELOWTITLEFILTERDATA',pic:''},{av:'AV42BR_Lab_NormRangeHighTitleFilterData',fld:'vBR_LAB_NORMRANGEHIGHTITLEFILTERDATA',pic:''},{av:'AV44BR_Lab_TestMethodTitleFilterData',fld:'vBR_LAB_TESTMETHODTITLEFILTERDATA',pic:''},{av:'AV48BR_Lab_InstrumentNameTitleFilterData',fld:'vBR_LAB_INSTRUMENTNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Lab_InstrumentCodeTitleFilterData',fld:'vBR_LAB_INSTRUMENTCODETITLEFILTERDATA',pic:''},{av:'edtBR_LabID_Titleformat',ctrl:'BR_LABID',prop:'Titleformat'},{av:'edtBR_LabID_Title',ctrl:'BR_LABID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Lab_SampleID_Titleformat',ctrl:'BR_LAB_SAMPLEID',prop:'Titleformat'},{av:'edtBR_Lab_SampleID_Title',ctrl:'BR_LAB_SAMPLEID',prop:'Title'},{av:'edtBR_Lab_TestID_Titleformat',ctrl:'BR_LAB_TESTID',prop:'Titleformat'},{av:'edtBR_Lab_TestID_Title',ctrl:'BR_LAB_TESTID',prop:'Title'},{av:'edtBR_Lab_TestCode_Titleformat',ctrl:'BR_LAB_TESTCODE',prop:'Titleformat'},{av:'edtBR_Lab_TestCode_Title',ctrl:'BR_LAB_TESTCODE',prop:'Title'},{av:'edtBR_Lab_TestName_Titleformat',ctrl:'BR_LAB_TESTNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestName_Title',ctrl:'BR_LAB_TESTNAME',prop:'Title'},{av:'edtBR_Lab_TestEngName_Titleformat',ctrl:'BR_LAB_TESTENGNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestEngName_Title',ctrl:'BR_LAB_TESTENGNAME',prop:'Title'},{av:'edtBR_Lab_Age_Titleformat',ctrl:'BR_LAB_AGE',prop:'Titleformat'},{av:'edtBR_Lab_Age_Title',ctrl:'BR_LAB_AGE',prop:'Title'},{av:'edtBR_Lab_Diag_Titleformat',ctrl:'BR_LAB_DIAG',prop:'Titleformat'},{av:'edtBR_Lab_Diag_Title',ctrl:'BR_LAB_DIAG',prop:'Title'},{av:'edtBR_Lab_SpecimenDate_Titleformat',ctrl:'BR_LAB_SPECIMENDATE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenDate_Title',ctrl:'BR_LAB_SPECIMENDATE',prop:'Title'},{av:'edtBR_Lab_ReceivingTime_Titleformat',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReceivingTime_Title',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Title'},{av:'edtBR_Lab_ReportTime_Titleformat',ctrl:'BR_LAB_REPORTTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReportTime_Title',ctrl:'BR_LAB_REPORTTIME',prop:'Title'},{av:'edtBR_Lab_SpecimenSource_Titleformat',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenSource_Title',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Title'},{av:'edtBR_Lab_ResultQual_Titleformat',ctrl:'BR_LAB_RESULTQUAL',prop:'Titleformat'},{av:'edtBR_Lab_ResultQual_Title',ctrl:'BR_LAB_RESULTQUAL',prop:'Title'},{av:'edtBR_Lab_ResultNum_Titleformat',ctrl:'BR_LAB_RESULTNUM',prop:'Titleformat'},{av:'edtBR_Lab_ResultNum_Title',ctrl:'BR_LAB_RESULTNUM',prop:'Title'},{av:'edtBR_Lab_ResultUnit_Titleformat',ctrl:'BR_LAB_RESULTUNIT',prop:'Titleformat'},{av:'edtBR_Lab_ResultUnit_Title',ctrl:'BR_LAB_RESULTUNIT',prop:'Title'},{av:'edtBR_Lab_AbnInd_Titleformat',ctrl:'BR_LAB_ABNIND',prop:'Titleformat'},{av:'edtBR_Lab_AbnInd_Title',ctrl:'BR_LAB_ABNIND',prop:'Title'},{av:'edtBR_Lab_NormRangeLow_Titleformat',ctrl:'BR_LAB_NORMRANGELOW',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeLow_Title',ctrl:'BR_LAB_NORMRANGELOW',prop:'Title'},{av:'edtBR_Lab_NormRangeHigh_Titleformat',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeHigh_Title',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Title'},{av:'edtBR_Lab_TestMethod_Titleformat',ctrl:'BR_LAB_TESTMETHOD',prop:'Titleformat'},{av:'edtBR_Lab_TestMethod_Title',ctrl:'BR_LAB_TESTMETHOD',prop:'Title'},{av:'edtBR_Lab_InstrumentName_Titleformat',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentName_Title',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Title'},{av:'edtBR_Lab_InstrumentCode_Titleformat',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentCode_Title',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_LAB_AGE.ONOPTIONCLICKED","{handler:'E213H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_SAMPLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Lab_TestIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTENGNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_BR_Lab_AgeTitleControlIdToReplace',fld:'vDDO_BR_LAB_AGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Lab_DiagTitleControlIdToReplace',fld:'vDDO_BR_LAB_DIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_RECEIVINGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_REPORTTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGELOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGEHIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTMETHODTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_lab_age_Activeeventkey',ctrl:'DDO_BR_LAB_AGE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_LAB_AGE.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_lab_age_Sortedstatus',ctrl:'DDO_BR_LAB_AGE',prop:'SortedStatus'},{av:'AV12BR_LabIDTitleFilterData',fld:'vBR_LABIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV58BR_Lab_SampleIDTitleFilterData',fld:'vBR_LAB_SAMPLEIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Lab_TestIDTitleFilterData',fld:'vBR_LAB_TESTIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Lab_TestCodeTitleFilterData',fld:'vBR_LAB_TESTCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Lab_TestNameTitleFilterData',fld:'vBR_LAB_TESTNAMETITLEFILTERDATA',pic:''},{av:'AV60BR_Lab_TestEngNameTitleFilterData',fld:'vBR_LAB_TESTENGNAMETITLEFILTERDATA',pic:''},{av:'AV62BR_Lab_AgeTitleFilterData',fld:'vBR_LAB_AGETITLEFILTERDATA',pic:''},{av:'AV64BR_Lab_DiagTitleFilterData',fld:'vBR_LAB_DIAGTITLEFILTERDATA',pic:''},{av:'AV24BR_Lab_SpecimenDateTitleFilterData',fld:'vBR_LAB_SPECIMENDATETITLEFILTERDATA',pic:''},{av:'AV66BR_Lab_ReceivingTimeTitleFilterData',fld:'vBR_LAB_RECEIVINGTIMETITLEFILTERDATA',pic:''},{av:'AV68BR_Lab_ReportTimeTitleFilterData',fld:'vBR_LAB_REPORTTIMETITLEFILTERDATA',pic:''},{av:'AV26BR_Lab_SpecimenSourceTitleFilterData',fld:'vBR_LAB_SPECIMENSOURCETITLEFILTERDATA',pic:''},{av:'AV32BR_Lab_ResultQualTitleFilterData',fld:'vBR_LAB_RESULTQUALTITLEFILTERDATA',pic:''},{av:'AV34BR_Lab_ResultNumTitleFilterData',fld:'vBR_LAB_RESULTNUMTITLEFILTERDATA',pic:''},{av:'AV36BR_Lab_ResultUnitTitleFilterData',fld:'vBR_LAB_RESULTUNITTITLEFILTERDATA',pic:''},{av:'AV38BR_Lab_AbnIndTitleFilterData',fld:'vBR_LAB_ABNINDTITLEFILTERDATA',pic:''},{av:'AV40BR_Lab_NormRangeLowTitleFilterData',fld:'vBR_LAB_NORMRANGELOWTITLEFILTERDATA',pic:''},{av:'AV42BR_Lab_NormRangeHighTitleFilterData',fld:'vBR_LAB_NORMRANGEHIGHTITLEFILTERDATA',pic:''},{av:'AV44BR_Lab_TestMethodTitleFilterData',fld:'vBR_LAB_TESTMETHODTITLEFILTERDATA',pic:''},{av:'AV48BR_Lab_InstrumentNameTitleFilterData',fld:'vBR_LAB_INSTRUMENTNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Lab_InstrumentCodeTitleFilterData',fld:'vBR_LAB_INSTRUMENTCODETITLEFILTERDATA',pic:''},{av:'edtBR_LabID_Titleformat',ctrl:'BR_LABID',prop:'Titleformat'},{av:'edtBR_LabID_Title',ctrl:'BR_LABID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Lab_SampleID_Titleformat',ctrl:'BR_LAB_SAMPLEID',prop:'Titleformat'},{av:'edtBR_Lab_SampleID_Title',ctrl:'BR_LAB_SAMPLEID',prop:'Title'},{av:'edtBR_Lab_TestID_Titleformat',ctrl:'BR_LAB_TESTID',prop:'Titleformat'},{av:'edtBR_Lab_TestID_Title',ctrl:'BR_LAB_TESTID',prop:'Title'},{av:'edtBR_Lab_TestCode_Titleformat',ctrl:'BR_LAB_TESTCODE',prop:'Titleformat'},{av:'edtBR_Lab_TestCode_Title',ctrl:'BR_LAB_TESTCODE',prop:'Title'},{av:'edtBR_Lab_TestName_Titleformat',ctrl:'BR_LAB_TESTNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestName_Title',ctrl:'BR_LAB_TESTNAME',prop:'Title'},{av:'edtBR_Lab_TestEngName_Titleformat',ctrl:'BR_LAB_TESTENGNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestEngName_Title',ctrl:'BR_LAB_TESTENGNAME',prop:'Title'},{av:'edtBR_Lab_Age_Titleformat',ctrl:'BR_LAB_AGE',prop:'Titleformat'},{av:'edtBR_Lab_Age_Title',ctrl:'BR_LAB_AGE',prop:'Title'},{av:'edtBR_Lab_Diag_Titleformat',ctrl:'BR_LAB_DIAG',prop:'Titleformat'},{av:'edtBR_Lab_Diag_Title',ctrl:'BR_LAB_DIAG',prop:'Title'},{av:'edtBR_Lab_SpecimenDate_Titleformat',ctrl:'BR_LAB_SPECIMENDATE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenDate_Title',ctrl:'BR_LAB_SPECIMENDATE',prop:'Title'},{av:'edtBR_Lab_ReceivingTime_Titleformat',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReceivingTime_Title',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Title'},{av:'edtBR_Lab_ReportTime_Titleformat',ctrl:'BR_LAB_REPORTTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReportTime_Title',ctrl:'BR_LAB_REPORTTIME',prop:'Title'},{av:'edtBR_Lab_SpecimenSource_Titleformat',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenSource_Title',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Title'},{av:'edtBR_Lab_ResultQual_Titleformat',ctrl:'BR_LAB_RESULTQUAL',prop:'Titleformat'},{av:'edtBR_Lab_ResultQual_Title',ctrl:'BR_LAB_RESULTQUAL',prop:'Title'},{av:'edtBR_Lab_ResultNum_Titleformat',ctrl:'BR_LAB_RESULTNUM',prop:'Titleformat'},{av:'edtBR_Lab_ResultNum_Title',ctrl:'BR_LAB_RESULTNUM',prop:'Title'},{av:'edtBR_Lab_ResultUnit_Titleformat',ctrl:'BR_LAB_RESULTUNIT',prop:'Titleformat'},{av:'edtBR_Lab_ResultUnit_Title',ctrl:'BR_LAB_RESULTUNIT',prop:'Title'},{av:'edtBR_Lab_AbnInd_Titleformat',ctrl:'BR_LAB_ABNIND',prop:'Titleformat'},{av:'edtBR_Lab_AbnInd_Title',ctrl:'BR_LAB_ABNIND',prop:'Title'},{av:'edtBR_Lab_NormRangeLow_Titleformat',ctrl:'BR_LAB_NORMRANGELOW',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeLow_Title',ctrl:'BR_LAB_NORMRANGELOW',prop:'Title'},{av:'edtBR_Lab_NormRangeHigh_Titleformat',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeHigh_Title',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Title'},{av:'edtBR_Lab_TestMethod_Titleformat',ctrl:'BR_LAB_TESTMETHOD',prop:'Titleformat'},{av:'edtBR_Lab_TestMethod_Title',ctrl:'BR_LAB_TESTMETHOD',prop:'Title'},{av:'edtBR_Lab_InstrumentName_Titleformat',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentName_Title',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Title'},{av:'edtBR_Lab_InstrumentCode_Titleformat',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentCode_Title',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_LAB_DIAG.ONOPTIONCLICKED","{handler:'E223H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_SAMPLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Lab_TestIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTENGNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_BR_Lab_AgeTitleControlIdToReplace',fld:'vDDO_BR_LAB_AGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Lab_DiagTitleControlIdToReplace',fld:'vDDO_BR_LAB_DIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_RECEIVINGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_REPORTTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGELOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGEHIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTMETHODTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_lab_diag_Activeeventkey',ctrl:'DDO_BR_LAB_DIAG',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_LAB_DIAG.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_lab_diag_Sortedstatus',ctrl:'DDO_BR_LAB_DIAG',prop:'SortedStatus'},{av:'AV12BR_LabIDTitleFilterData',fld:'vBR_LABIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV58BR_Lab_SampleIDTitleFilterData',fld:'vBR_LAB_SAMPLEIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Lab_TestIDTitleFilterData',fld:'vBR_LAB_TESTIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Lab_TestCodeTitleFilterData',fld:'vBR_LAB_TESTCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Lab_TestNameTitleFilterData',fld:'vBR_LAB_TESTNAMETITLEFILTERDATA',pic:''},{av:'AV60BR_Lab_TestEngNameTitleFilterData',fld:'vBR_LAB_TESTENGNAMETITLEFILTERDATA',pic:''},{av:'AV62BR_Lab_AgeTitleFilterData',fld:'vBR_LAB_AGETITLEFILTERDATA',pic:''},{av:'AV64BR_Lab_DiagTitleFilterData',fld:'vBR_LAB_DIAGTITLEFILTERDATA',pic:''},{av:'AV24BR_Lab_SpecimenDateTitleFilterData',fld:'vBR_LAB_SPECIMENDATETITLEFILTERDATA',pic:''},{av:'AV66BR_Lab_ReceivingTimeTitleFilterData',fld:'vBR_LAB_RECEIVINGTIMETITLEFILTERDATA',pic:''},{av:'AV68BR_Lab_ReportTimeTitleFilterData',fld:'vBR_LAB_REPORTTIMETITLEFILTERDATA',pic:''},{av:'AV26BR_Lab_SpecimenSourceTitleFilterData',fld:'vBR_LAB_SPECIMENSOURCETITLEFILTERDATA',pic:''},{av:'AV32BR_Lab_ResultQualTitleFilterData',fld:'vBR_LAB_RESULTQUALTITLEFILTERDATA',pic:''},{av:'AV34BR_Lab_ResultNumTitleFilterData',fld:'vBR_LAB_RESULTNUMTITLEFILTERDATA',pic:''},{av:'AV36BR_Lab_ResultUnitTitleFilterData',fld:'vBR_LAB_RESULTUNITTITLEFILTERDATA',pic:''},{av:'AV38BR_Lab_AbnIndTitleFilterData',fld:'vBR_LAB_ABNINDTITLEFILTERDATA',pic:''},{av:'AV40BR_Lab_NormRangeLowTitleFilterData',fld:'vBR_LAB_NORMRANGELOWTITLEFILTERDATA',pic:''},{av:'AV42BR_Lab_NormRangeHighTitleFilterData',fld:'vBR_LAB_NORMRANGEHIGHTITLEFILTERDATA',pic:''},{av:'AV44BR_Lab_TestMethodTitleFilterData',fld:'vBR_LAB_TESTMETHODTITLEFILTERDATA',pic:''},{av:'AV48BR_Lab_InstrumentNameTitleFilterData',fld:'vBR_LAB_INSTRUMENTNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Lab_InstrumentCodeTitleFilterData',fld:'vBR_LAB_INSTRUMENTCODETITLEFILTERDATA',pic:''},{av:'edtBR_LabID_Titleformat',ctrl:'BR_LABID',prop:'Titleformat'},{av:'edtBR_LabID_Title',ctrl:'BR_LABID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Lab_SampleID_Titleformat',ctrl:'BR_LAB_SAMPLEID',prop:'Titleformat'},{av:'edtBR_Lab_SampleID_Title',ctrl:'BR_LAB_SAMPLEID',prop:'Title'},{av:'edtBR_Lab_TestID_Titleformat',ctrl:'BR_LAB_TESTID',prop:'Titleformat'},{av:'edtBR_Lab_TestID_Title',ctrl:'BR_LAB_TESTID',prop:'Title'},{av:'edtBR_Lab_TestCode_Titleformat',ctrl:'BR_LAB_TESTCODE',prop:'Titleformat'},{av:'edtBR_Lab_TestCode_Title',ctrl:'BR_LAB_TESTCODE',prop:'Title'},{av:'edtBR_Lab_TestName_Titleformat',ctrl:'BR_LAB_TESTNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestName_Title',ctrl:'BR_LAB_TESTNAME',prop:'Title'},{av:'edtBR_Lab_TestEngName_Titleformat',ctrl:'BR_LAB_TESTENGNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestEngName_Title',ctrl:'BR_LAB_TESTENGNAME',prop:'Title'},{av:'edtBR_Lab_Age_Titleformat',ctrl:'BR_LAB_AGE',prop:'Titleformat'},{av:'edtBR_Lab_Age_Title',ctrl:'BR_LAB_AGE',prop:'Title'},{av:'edtBR_Lab_Diag_Titleformat',ctrl:'BR_LAB_DIAG',prop:'Titleformat'},{av:'edtBR_Lab_Diag_Title',ctrl:'BR_LAB_DIAG',prop:'Title'},{av:'edtBR_Lab_SpecimenDate_Titleformat',ctrl:'BR_LAB_SPECIMENDATE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenDate_Title',ctrl:'BR_LAB_SPECIMENDATE',prop:'Title'},{av:'edtBR_Lab_ReceivingTime_Titleformat',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReceivingTime_Title',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Title'},{av:'edtBR_Lab_ReportTime_Titleformat',ctrl:'BR_LAB_REPORTTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReportTime_Title',ctrl:'BR_LAB_REPORTTIME',prop:'Title'},{av:'edtBR_Lab_SpecimenSource_Titleformat',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenSource_Title',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Title'},{av:'edtBR_Lab_ResultQual_Titleformat',ctrl:'BR_LAB_RESULTQUAL',prop:'Titleformat'},{av:'edtBR_Lab_ResultQual_Title',ctrl:'BR_LAB_RESULTQUAL',prop:'Title'},{av:'edtBR_Lab_ResultNum_Titleformat',ctrl:'BR_LAB_RESULTNUM',prop:'Titleformat'},{av:'edtBR_Lab_ResultNum_Title',ctrl:'BR_LAB_RESULTNUM',prop:'Title'},{av:'edtBR_Lab_ResultUnit_Titleformat',ctrl:'BR_LAB_RESULTUNIT',prop:'Titleformat'},{av:'edtBR_Lab_ResultUnit_Title',ctrl:'BR_LAB_RESULTUNIT',prop:'Title'},{av:'edtBR_Lab_AbnInd_Titleformat',ctrl:'BR_LAB_ABNIND',prop:'Titleformat'},{av:'edtBR_Lab_AbnInd_Title',ctrl:'BR_LAB_ABNIND',prop:'Title'},{av:'edtBR_Lab_NormRangeLow_Titleformat',ctrl:'BR_LAB_NORMRANGELOW',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeLow_Title',ctrl:'BR_LAB_NORMRANGELOW',prop:'Title'},{av:'edtBR_Lab_NormRangeHigh_Titleformat',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeHigh_Title',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Title'},{av:'edtBR_Lab_TestMethod_Titleformat',ctrl:'BR_LAB_TESTMETHOD',prop:'Titleformat'},{av:'edtBR_Lab_TestMethod_Title',ctrl:'BR_LAB_TESTMETHOD',prop:'Title'},{av:'edtBR_Lab_InstrumentName_Titleformat',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentName_Title',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Title'},{av:'edtBR_Lab_InstrumentCode_Titleformat',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentCode_Title',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_LAB_SPECIMENDATE.ONOPTIONCLICKED","{handler:'E233H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_SAMPLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Lab_TestIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTENGNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_BR_Lab_AgeTitleControlIdToReplace',fld:'vDDO_BR_LAB_AGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Lab_DiagTitleControlIdToReplace',fld:'vDDO_BR_LAB_DIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_RECEIVINGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_REPORTTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGELOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGEHIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTMETHODTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_lab_specimendate_Activeeventkey',ctrl:'DDO_BR_LAB_SPECIMENDATE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_LAB_SPECIMENDATE.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_lab_specimendate_Sortedstatus',ctrl:'DDO_BR_LAB_SPECIMENDATE',prop:'SortedStatus'},{av:'AV12BR_LabIDTitleFilterData',fld:'vBR_LABIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV58BR_Lab_SampleIDTitleFilterData',fld:'vBR_LAB_SAMPLEIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Lab_TestIDTitleFilterData',fld:'vBR_LAB_TESTIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Lab_TestCodeTitleFilterData',fld:'vBR_LAB_TESTCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Lab_TestNameTitleFilterData',fld:'vBR_LAB_TESTNAMETITLEFILTERDATA',pic:''},{av:'AV60BR_Lab_TestEngNameTitleFilterData',fld:'vBR_LAB_TESTENGNAMETITLEFILTERDATA',pic:''},{av:'AV62BR_Lab_AgeTitleFilterData',fld:'vBR_LAB_AGETITLEFILTERDATA',pic:''},{av:'AV64BR_Lab_DiagTitleFilterData',fld:'vBR_LAB_DIAGTITLEFILTERDATA',pic:''},{av:'AV24BR_Lab_SpecimenDateTitleFilterData',fld:'vBR_LAB_SPECIMENDATETITLEFILTERDATA',pic:''},{av:'AV66BR_Lab_ReceivingTimeTitleFilterData',fld:'vBR_LAB_RECEIVINGTIMETITLEFILTERDATA',pic:''},{av:'AV68BR_Lab_ReportTimeTitleFilterData',fld:'vBR_LAB_REPORTTIMETITLEFILTERDATA',pic:''},{av:'AV26BR_Lab_SpecimenSourceTitleFilterData',fld:'vBR_LAB_SPECIMENSOURCETITLEFILTERDATA',pic:''},{av:'AV32BR_Lab_ResultQualTitleFilterData',fld:'vBR_LAB_RESULTQUALTITLEFILTERDATA',pic:''},{av:'AV34BR_Lab_ResultNumTitleFilterData',fld:'vBR_LAB_RESULTNUMTITLEFILTERDATA',pic:''},{av:'AV36BR_Lab_ResultUnitTitleFilterData',fld:'vBR_LAB_RESULTUNITTITLEFILTERDATA',pic:''},{av:'AV38BR_Lab_AbnIndTitleFilterData',fld:'vBR_LAB_ABNINDTITLEFILTERDATA',pic:''},{av:'AV40BR_Lab_NormRangeLowTitleFilterData',fld:'vBR_LAB_NORMRANGELOWTITLEFILTERDATA',pic:''},{av:'AV42BR_Lab_NormRangeHighTitleFilterData',fld:'vBR_LAB_NORMRANGEHIGHTITLEFILTERDATA',pic:''},{av:'AV44BR_Lab_TestMethodTitleFilterData',fld:'vBR_LAB_TESTMETHODTITLEFILTERDATA',pic:''},{av:'AV48BR_Lab_InstrumentNameTitleFilterData',fld:'vBR_LAB_INSTRUMENTNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Lab_InstrumentCodeTitleFilterData',fld:'vBR_LAB_INSTRUMENTCODETITLEFILTERDATA',pic:''},{av:'edtBR_LabID_Titleformat',ctrl:'BR_LABID',prop:'Titleformat'},{av:'edtBR_LabID_Title',ctrl:'BR_LABID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Lab_SampleID_Titleformat',ctrl:'BR_LAB_SAMPLEID',prop:'Titleformat'},{av:'edtBR_Lab_SampleID_Title',ctrl:'BR_LAB_SAMPLEID',prop:'Title'},{av:'edtBR_Lab_TestID_Titleformat',ctrl:'BR_LAB_TESTID',prop:'Titleformat'},{av:'edtBR_Lab_TestID_Title',ctrl:'BR_LAB_TESTID',prop:'Title'},{av:'edtBR_Lab_TestCode_Titleformat',ctrl:'BR_LAB_TESTCODE',prop:'Titleformat'},{av:'edtBR_Lab_TestCode_Title',ctrl:'BR_LAB_TESTCODE',prop:'Title'},{av:'edtBR_Lab_TestName_Titleformat',ctrl:'BR_LAB_TESTNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestName_Title',ctrl:'BR_LAB_TESTNAME',prop:'Title'},{av:'edtBR_Lab_TestEngName_Titleformat',ctrl:'BR_LAB_TESTENGNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestEngName_Title',ctrl:'BR_LAB_TESTENGNAME',prop:'Title'},{av:'edtBR_Lab_Age_Titleformat',ctrl:'BR_LAB_AGE',prop:'Titleformat'},{av:'edtBR_Lab_Age_Title',ctrl:'BR_LAB_AGE',prop:'Title'},{av:'edtBR_Lab_Diag_Titleformat',ctrl:'BR_LAB_DIAG',prop:'Titleformat'},{av:'edtBR_Lab_Diag_Title',ctrl:'BR_LAB_DIAG',prop:'Title'},{av:'edtBR_Lab_SpecimenDate_Titleformat',ctrl:'BR_LAB_SPECIMENDATE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenDate_Title',ctrl:'BR_LAB_SPECIMENDATE',prop:'Title'},{av:'edtBR_Lab_ReceivingTime_Titleformat',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReceivingTime_Title',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Title'},{av:'edtBR_Lab_ReportTime_Titleformat',ctrl:'BR_LAB_REPORTTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReportTime_Title',ctrl:'BR_LAB_REPORTTIME',prop:'Title'},{av:'edtBR_Lab_SpecimenSource_Titleformat',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenSource_Title',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Title'},{av:'edtBR_Lab_ResultQual_Titleformat',ctrl:'BR_LAB_RESULTQUAL',prop:'Titleformat'},{av:'edtBR_Lab_ResultQual_Title',ctrl:'BR_LAB_RESULTQUAL',prop:'Title'},{av:'edtBR_Lab_ResultNum_Titleformat',ctrl:'BR_LAB_RESULTNUM',prop:'Titleformat'},{av:'edtBR_Lab_ResultNum_Title',ctrl:'BR_LAB_RESULTNUM',prop:'Title'},{av:'edtBR_Lab_ResultUnit_Titleformat',ctrl:'BR_LAB_RESULTUNIT',prop:'Titleformat'},{av:'edtBR_Lab_ResultUnit_Title',ctrl:'BR_LAB_RESULTUNIT',prop:'Title'},{av:'edtBR_Lab_AbnInd_Titleformat',ctrl:'BR_LAB_ABNIND',prop:'Titleformat'},{av:'edtBR_Lab_AbnInd_Title',ctrl:'BR_LAB_ABNIND',prop:'Title'},{av:'edtBR_Lab_NormRangeLow_Titleformat',ctrl:'BR_LAB_NORMRANGELOW',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeLow_Title',ctrl:'BR_LAB_NORMRANGELOW',prop:'Title'},{av:'edtBR_Lab_NormRangeHigh_Titleformat',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeHigh_Title',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Title'},{av:'edtBR_Lab_TestMethod_Titleformat',ctrl:'BR_LAB_TESTMETHOD',prop:'Titleformat'},{av:'edtBR_Lab_TestMethod_Title',ctrl:'BR_LAB_TESTMETHOD',prop:'Title'},{av:'edtBR_Lab_InstrumentName_Titleformat',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentName_Title',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Title'},{av:'edtBR_Lab_InstrumentCode_Titleformat',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentCode_Title',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_LAB_RECEIVINGTIME.ONOPTIONCLICKED","{handler:'E243H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_SAMPLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Lab_TestIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTENGNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_BR_Lab_AgeTitleControlIdToReplace',fld:'vDDO_BR_LAB_AGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Lab_DiagTitleControlIdToReplace',fld:'vDDO_BR_LAB_DIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_RECEIVINGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_REPORTTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGELOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGEHIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTMETHODTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_lab_receivingtime_Activeeventkey',ctrl:'DDO_BR_LAB_RECEIVINGTIME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_LAB_RECEIVINGTIME.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_lab_receivingtime_Sortedstatus',ctrl:'DDO_BR_LAB_RECEIVINGTIME',prop:'SortedStatus'},{av:'AV12BR_LabIDTitleFilterData',fld:'vBR_LABIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV58BR_Lab_SampleIDTitleFilterData',fld:'vBR_LAB_SAMPLEIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Lab_TestIDTitleFilterData',fld:'vBR_LAB_TESTIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Lab_TestCodeTitleFilterData',fld:'vBR_LAB_TESTCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Lab_TestNameTitleFilterData',fld:'vBR_LAB_TESTNAMETITLEFILTERDATA',pic:''},{av:'AV60BR_Lab_TestEngNameTitleFilterData',fld:'vBR_LAB_TESTENGNAMETITLEFILTERDATA',pic:''},{av:'AV62BR_Lab_AgeTitleFilterData',fld:'vBR_LAB_AGETITLEFILTERDATA',pic:''},{av:'AV64BR_Lab_DiagTitleFilterData',fld:'vBR_LAB_DIAGTITLEFILTERDATA',pic:''},{av:'AV24BR_Lab_SpecimenDateTitleFilterData',fld:'vBR_LAB_SPECIMENDATETITLEFILTERDATA',pic:''},{av:'AV66BR_Lab_ReceivingTimeTitleFilterData',fld:'vBR_LAB_RECEIVINGTIMETITLEFILTERDATA',pic:''},{av:'AV68BR_Lab_ReportTimeTitleFilterData',fld:'vBR_LAB_REPORTTIMETITLEFILTERDATA',pic:''},{av:'AV26BR_Lab_SpecimenSourceTitleFilterData',fld:'vBR_LAB_SPECIMENSOURCETITLEFILTERDATA',pic:''},{av:'AV32BR_Lab_ResultQualTitleFilterData',fld:'vBR_LAB_RESULTQUALTITLEFILTERDATA',pic:''},{av:'AV34BR_Lab_ResultNumTitleFilterData',fld:'vBR_LAB_RESULTNUMTITLEFILTERDATA',pic:''},{av:'AV36BR_Lab_ResultUnitTitleFilterData',fld:'vBR_LAB_RESULTUNITTITLEFILTERDATA',pic:''},{av:'AV38BR_Lab_AbnIndTitleFilterData',fld:'vBR_LAB_ABNINDTITLEFILTERDATA',pic:''},{av:'AV40BR_Lab_NormRangeLowTitleFilterData',fld:'vBR_LAB_NORMRANGELOWTITLEFILTERDATA',pic:''},{av:'AV42BR_Lab_NormRangeHighTitleFilterData',fld:'vBR_LAB_NORMRANGEHIGHTITLEFILTERDATA',pic:''},{av:'AV44BR_Lab_TestMethodTitleFilterData',fld:'vBR_LAB_TESTMETHODTITLEFILTERDATA',pic:''},{av:'AV48BR_Lab_InstrumentNameTitleFilterData',fld:'vBR_LAB_INSTRUMENTNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Lab_InstrumentCodeTitleFilterData',fld:'vBR_LAB_INSTRUMENTCODETITLEFILTERDATA',pic:''},{av:'edtBR_LabID_Titleformat',ctrl:'BR_LABID',prop:'Titleformat'},{av:'edtBR_LabID_Title',ctrl:'BR_LABID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Lab_SampleID_Titleformat',ctrl:'BR_LAB_SAMPLEID',prop:'Titleformat'},{av:'edtBR_Lab_SampleID_Title',ctrl:'BR_LAB_SAMPLEID',prop:'Title'},{av:'edtBR_Lab_TestID_Titleformat',ctrl:'BR_LAB_TESTID',prop:'Titleformat'},{av:'edtBR_Lab_TestID_Title',ctrl:'BR_LAB_TESTID',prop:'Title'},{av:'edtBR_Lab_TestCode_Titleformat',ctrl:'BR_LAB_TESTCODE',prop:'Titleformat'},{av:'edtBR_Lab_TestCode_Title',ctrl:'BR_LAB_TESTCODE',prop:'Title'},{av:'edtBR_Lab_TestName_Titleformat',ctrl:'BR_LAB_TESTNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestName_Title',ctrl:'BR_LAB_TESTNAME',prop:'Title'},{av:'edtBR_Lab_TestEngName_Titleformat',ctrl:'BR_LAB_TESTENGNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestEngName_Title',ctrl:'BR_LAB_TESTENGNAME',prop:'Title'},{av:'edtBR_Lab_Age_Titleformat',ctrl:'BR_LAB_AGE',prop:'Titleformat'},{av:'edtBR_Lab_Age_Title',ctrl:'BR_LAB_AGE',prop:'Title'},{av:'edtBR_Lab_Diag_Titleformat',ctrl:'BR_LAB_DIAG',prop:'Titleformat'},{av:'edtBR_Lab_Diag_Title',ctrl:'BR_LAB_DIAG',prop:'Title'},{av:'edtBR_Lab_SpecimenDate_Titleformat',ctrl:'BR_LAB_SPECIMENDATE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenDate_Title',ctrl:'BR_LAB_SPECIMENDATE',prop:'Title'},{av:'edtBR_Lab_ReceivingTime_Titleformat',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReceivingTime_Title',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Title'},{av:'edtBR_Lab_ReportTime_Titleformat',ctrl:'BR_LAB_REPORTTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReportTime_Title',ctrl:'BR_LAB_REPORTTIME',prop:'Title'},{av:'edtBR_Lab_SpecimenSource_Titleformat',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenSource_Title',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Title'},{av:'edtBR_Lab_ResultQual_Titleformat',ctrl:'BR_LAB_RESULTQUAL',prop:'Titleformat'},{av:'edtBR_Lab_ResultQual_Title',ctrl:'BR_LAB_RESULTQUAL',prop:'Title'},{av:'edtBR_Lab_ResultNum_Titleformat',ctrl:'BR_LAB_RESULTNUM',prop:'Titleformat'},{av:'edtBR_Lab_ResultNum_Title',ctrl:'BR_LAB_RESULTNUM',prop:'Title'},{av:'edtBR_Lab_ResultUnit_Titleformat',ctrl:'BR_LAB_RESULTUNIT',prop:'Titleformat'},{av:'edtBR_Lab_ResultUnit_Title',ctrl:'BR_LAB_RESULTUNIT',prop:'Title'},{av:'edtBR_Lab_AbnInd_Titleformat',ctrl:'BR_LAB_ABNIND',prop:'Titleformat'},{av:'edtBR_Lab_AbnInd_Title',ctrl:'BR_LAB_ABNIND',prop:'Title'},{av:'edtBR_Lab_NormRangeLow_Titleformat',ctrl:'BR_LAB_NORMRANGELOW',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeLow_Title',ctrl:'BR_LAB_NORMRANGELOW',prop:'Title'},{av:'edtBR_Lab_NormRangeHigh_Titleformat',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeHigh_Title',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Title'},{av:'edtBR_Lab_TestMethod_Titleformat',ctrl:'BR_LAB_TESTMETHOD',prop:'Titleformat'},{av:'edtBR_Lab_TestMethod_Title',ctrl:'BR_LAB_TESTMETHOD',prop:'Title'},{av:'edtBR_Lab_InstrumentName_Titleformat',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentName_Title',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Title'},{av:'edtBR_Lab_InstrumentCode_Titleformat',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentCode_Title',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_LAB_REPORTTIME.ONOPTIONCLICKED","{handler:'E253H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_SAMPLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Lab_TestIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTENGNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_BR_Lab_AgeTitleControlIdToReplace',fld:'vDDO_BR_LAB_AGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Lab_DiagTitleControlIdToReplace',fld:'vDDO_BR_LAB_DIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_RECEIVINGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_REPORTTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGELOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGEHIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTMETHODTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_lab_reporttime_Activeeventkey',ctrl:'DDO_BR_LAB_REPORTTIME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_LAB_REPORTTIME.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_lab_reporttime_Sortedstatus',ctrl:'DDO_BR_LAB_REPORTTIME',prop:'SortedStatus'},{av:'AV12BR_LabIDTitleFilterData',fld:'vBR_LABIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV58BR_Lab_SampleIDTitleFilterData',fld:'vBR_LAB_SAMPLEIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Lab_TestIDTitleFilterData',fld:'vBR_LAB_TESTIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Lab_TestCodeTitleFilterData',fld:'vBR_LAB_TESTCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Lab_TestNameTitleFilterData',fld:'vBR_LAB_TESTNAMETITLEFILTERDATA',pic:''},{av:'AV60BR_Lab_TestEngNameTitleFilterData',fld:'vBR_LAB_TESTENGNAMETITLEFILTERDATA',pic:''},{av:'AV62BR_Lab_AgeTitleFilterData',fld:'vBR_LAB_AGETITLEFILTERDATA',pic:''},{av:'AV64BR_Lab_DiagTitleFilterData',fld:'vBR_LAB_DIAGTITLEFILTERDATA',pic:''},{av:'AV24BR_Lab_SpecimenDateTitleFilterData',fld:'vBR_LAB_SPECIMENDATETITLEFILTERDATA',pic:''},{av:'AV66BR_Lab_ReceivingTimeTitleFilterData',fld:'vBR_LAB_RECEIVINGTIMETITLEFILTERDATA',pic:''},{av:'AV68BR_Lab_ReportTimeTitleFilterData',fld:'vBR_LAB_REPORTTIMETITLEFILTERDATA',pic:''},{av:'AV26BR_Lab_SpecimenSourceTitleFilterData',fld:'vBR_LAB_SPECIMENSOURCETITLEFILTERDATA',pic:''},{av:'AV32BR_Lab_ResultQualTitleFilterData',fld:'vBR_LAB_RESULTQUALTITLEFILTERDATA',pic:''},{av:'AV34BR_Lab_ResultNumTitleFilterData',fld:'vBR_LAB_RESULTNUMTITLEFILTERDATA',pic:''},{av:'AV36BR_Lab_ResultUnitTitleFilterData',fld:'vBR_LAB_RESULTUNITTITLEFILTERDATA',pic:''},{av:'AV38BR_Lab_AbnIndTitleFilterData',fld:'vBR_LAB_ABNINDTITLEFILTERDATA',pic:''},{av:'AV40BR_Lab_NormRangeLowTitleFilterData',fld:'vBR_LAB_NORMRANGELOWTITLEFILTERDATA',pic:''},{av:'AV42BR_Lab_NormRangeHighTitleFilterData',fld:'vBR_LAB_NORMRANGEHIGHTITLEFILTERDATA',pic:''},{av:'AV44BR_Lab_TestMethodTitleFilterData',fld:'vBR_LAB_TESTMETHODTITLEFILTERDATA',pic:''},{av:'AV48BR_Lab_InstrumentNameTitleFilterData',fld:'vBR_LAB_INSTRUMENTNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Lab_InstrumentCodeTitleFilterData',fld:'vBR_LAB_INSTRUMENTCODETITLEFILTERDATA',pic:''},{av:'edtBR_LabID_Titleformat',ctrl:'BR_LABID',prop:'Titleformat'},{av:'edtBR_LabID_Title',ctrl:'BR_LABID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Lab_SampleID_Titleformat',ctrl:'BR_LAB_SAMPLEID',prop:'Titleformat'},{av:'edtBR_Lab_SampleID_Title',ctrl:'BR_LAB_SAMPLEID',prop:'Title'},{av:'edtBR_Lab_TestID_Titleformat',ctrl:'BR_LAB_TESTID',prop:'Titleformat'},{av:'edtBR_Lab_TestID_Title',ctrl:'BR_LAB_TESTID',prop:'Title'},{av:'edtBR_Lab_TestCode_Titleformat',ctrl:'BR_LAB_TESTCODE',prop:'Titleformat'},{av:'edtBR_Lab_TestCode_Title',ctrl:'BR_LAB_TESTCODE',prop:'Title'},{av:'edtBR_Lab_TestName_Titleformat',ctrl:'BR_LAB_TESTNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestName_Title',ctrl:'BR_LAB_TESTNAME',prop:'Title'},{av:'edtBR_Lab_TestEngName_Titleformat',ctrl:'BR_LAB_TESTENGNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestEngName_Title',ctrl:'BR_LAB_TESTENGNAME',prop:'Title'},{av:'edtBR_Lab_Age_Titleformat',ctrl:'BR_LAB_AGE',prop:'Titleformat'},{av:'edtBR_Lab_Age_Title',ctrl:'BR_LAB_AGE',prop:'Title'},{av:'edtBR_Lab_Diag_Titleformat',ctrl:'BR_LAB_DIAG',prop:'Titleformat'},{av:'edtBR_Lab_Diag_Title',ctrl:'BR_LAB_DIAG',prop:'Title'},{av:'edtBR_Lab_SpecimenDate_Titleformat',ctrl:'BR_LAB_SPECIMENDATE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenDate_Title',ctrl:'BR_LAB_SPECIMENDATE',prop:'Title'},{av:'edtBR_Lab_ReceivingTime_Titleformat',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReceivingTime_Title',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Title'},{av:'edtBR_Lab_ReportTime_Titleformat',ctrl:'BR_LAB_REPORTTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReportTime_Title',ctrl:'BR_LAB_REPORTTIME',prop:'Title'},{av:'edtBR_Lab_SpecimenSource_Titleformat',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenSource_Title',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Title'},{av:'edtBR_Lab_ResultQual_Titleformat',ctrl:'BR_LAB_RESULTQUAL',prop:'Titleformat'},{av:'edtBR_Lab_ResultQual_Title',ctrl:'BR_LAB_RESULTQUAL',prop:'Title'},{av:'edtBR_Lab_ResultNum_Titleformat',ctrl:'BR_LAB_RESULTNUM',prop:'Titleformat'},{av:'edtBR_Lab_ResultNum_Title',ctrl:'BR_LAB_RESULTNUM',prop:'Title'},{av:'edtBR_Lab_ResultUnit_Titleformat',ctrl:'BR_LAB_RESULTUNIT',prop:'Titleformat'},{av:'edtBR_Lab_ResultUnit_Title',ctrl:'BR_LAB_RESULTUNIT',prop:'Title'},{av:'edtBR_Lab_AbnInd_Titleformat',ctrl:'BR_LAB_ABNIND',prop:'Titleformat'},{av:'edtBR_Lab_AbnInd_Title',ctrl:'BR_LAB_ABNIND',prop:'Title'},{av:'edtBR_Lab_NormRangeLow_Titleformat',ctrl:'BR_LAB_NORMRANGELOW',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeLow_Title',ctrl:'BR_LAB_NORMRANGELOW',prop:'Title'},{av:'edtBR_Lab_NormRangeHigh_Titleformat',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeHigh_Title',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Title'},{av:'edtBR_Lab_TestMethod_Titleformat',ctrl:'BR_LAB_TESTMETHOD',prop:'Titleformat'},{av:'edtBR_Lab_TestMethod_Title',ctrl:'BR_LAB_TESTMETHOD',prop:'Title'},{av:'edtBR_Lab_InstrumentName_Titleformat',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentName_Title',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Title'},{av:'edtBR_Lab_InstrumentCode_Titleformat',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentCode_Title',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_LAB_SPECIMENSOURCE.ONOPTIONCLICKED","{handler:'E263H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_SAMPLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Lab_TestIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTENGNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_BR_Lab_AgeTitleControlIdToReplace',fld:'vDDO_BR_LAB_AGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Lab_DiagTitleControlIdToReplace',fld:'vDDO_BR_LAB_DIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_RECEIVINGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_REPORTTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGELOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGEHIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTMETHODTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_lab_specimensource_Activeeventkey',ctrl:'DDO_BR_LAB_SPECIMENSOURCE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_LAB_SPECIMENSOURCE.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_lab_specimensource_Sortedstatus',ctrl:'DDO_BR_LAB_SPECIMENSOURCE',prop:'SortedStatus'},{av:'AV12BR_LabIDTitleFilterData',fld:'vBR_LABIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV58BR_Lab_SampleIDTitleFilterData',fld:'vBR_LAB_SAMPLEIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Lab_TestIDTitleFilterData',fld:'vBR_LAB_TESTIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Lab_TestCodeTitleFilterData',fld:'vBR_LAB_TESTCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Lab_TestNameTitleFilterData',fld:'vBR_LAB_TESTNAMETITLEFILTERDATA',pic:''},{av:'AV60BR_Lab_TestEngNameTitleFilterData',fld:'vBR_LAB_TESTENGNAMETITLEFILTERDATA',pic:''},{av:'AV62BR_Lab_AgeTitleFilterData',fld:'vBR_LAB_AGETITLEFILTERDATA',pic:''},{av:'AV64BR_Lab_DiagTitleFilterData',fld:'vBR_LAB_DIAGTITLEFILTERDATA',pic:''},{av:'AV24BR_Lab_SpecimenDateTitleFilterData',fld:'vBR_LAB_SPECIMENDATETITLEFILTERDATA',pic:''},{av:'AV66BR_Lab_ReceivingTimeTitleFilterData',fld:'vBR_LAB_RECEIVINGTIMETITLEFILTERDATA',pic:''},{av:'AV68BR_Lab_ReportTimeTitleFilterData',fld:'vBR_LAB_REPORTTIMETITLEFILTERDATA',pic:''},{av:'AV26BR_Lab_SpecimenSourceTitleFilterData',fld:'vBR_LAB_SPECIMENSOURCETITLEFILTERDATA',pic:''},{av:'AV32BR_Lab_ResultQualTitleFilterData',fld:'vBR_LAB_RESULTQUALTITLEFILTERDATA',pic:''},{av:'AV34BR_Lab_ResultNumTitleFilterData',fld:'vBR_LAB_RESULTNUMTITLEFILTERDATA',pic:''},{av:'AV36BR_Lab_ResultUnitTitleFilterData',fld:'vBR_LAB_RESULTUNITTITLEFILTERDATA',pic:''},{av:'AV38BR_Lab_AbnIndTitleFilterData',fld:'vBR_LAB_ABNINDTITLEFILTERDATA',pic:''},{av:'AV40BR_Lab_NormRangeLowTitleFilterData',fld:'vBR_LAB_NORMRANGELOWTITLEFILTERDATA',pic:''},{av:'AV42BR_Lab_NormRangeHighTitleFilterData',fld:'vBR_LAB_NORMRANGEHIGHTITLEFILTERDATA',pic:''},{av:'AV44BR_Lab_TestMethodTitleFilterData',fld:'vBR_LAB_TESTMETHODTITLEFILTERDATA',pic:''},{av:'AV48BR_Lab_InstrumentNameTitleFilterData',fld:'vBR_LAB_INSTRUMENTNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Lab_InstrumentCodeTitleFilterData',fld:'vBR_LAB_INSTRUMENTCODETITLEFILTERDATA',pic:''},{av:'edtBR_LabID_Titleformat',ctrl:'BR_LABID',prop:'Titleformat'},{av:'edtBR_LabID_Title',ctrl:'BR_LABID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Lab_SampleID_Titleformat',ctrl:'BR_LAB_SAMPLEID',prop:'Titleformat'},{av:'edtBR_Lab_SampleID_Title',ctrl:'BR_LAB_SAMPLEID',prop:'Title'},{av:'edtBR_Lab_TestID_Titleformat',ctrl:'BR_LAB_TESTID',prop:'Titleformat'},{av:'edtBR_Lab_TestID_Title',ctrl:'BR_LAB_TESTID',prop:'Title'},{av:'edtBR_Lab_TestCode_Titleformat',ctrl:'BR_LAB_TESTCODE',prop:'Titleformat'},{av:'edtBR_Lab_TestCode_Title',ctrl:'BR_LAB_TESTCODE',prop:'Title'},{av:'edtBR_Lab_TestName_Titleformat',ctrl:'BR_LAB_TESTNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestName_Title',ctrl:'BR_LAB_TESTNAME',prop:'Title'},{av:'edtBR_Lab_TestEngName_Titleformat',ctrl:'BR_LAB_TESTENGNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestEngName_Title',ctrl:'BR_LAB_TESTENGNAME',prop:'Title'},{av:'edtBR_Lab_Age_Titleformat',ctrl:'BR_LAB_AGE',prop:'Titleformat'},{av:'edtBR_Lab_Age_Title',ctrl:'BR_LAB_AGE',prop:'Title'},{av:'edtBR_Lab_Diag_Titleformat',ctrl:'BR_LAB_DIAG',prop:'Titleformat'},{av:'edtBR_Lab_Diag_Title',ctrl:'BR_LAB_DIAG',prop:'Title'},{av:'edtBR_Lab_SpecimenDate_Titleformat',ctrl:'BR_LAB_SPECIMENDATE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenDate_Title',ctrl:'BR_LAB_SPECIMENDATE',prop:'Title'},{av:'edtBR_Lab_ReceivingTime_Titleformat',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReceivingTime_Title',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Title'},{av:'edtBR_Lab_ReportTime_Titleformat',ctrl:'BR_LAB_REPORTTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReportTime_Title',ctrl:'BR_LAB_REPORTTIME',prop:'Title'},{av:'edtBR_Lab_SpecimenSource_Titleformat',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenSource_Title',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Title'},{av:'edtBR_Lab_ResultQual_Titleformat',ctrl:'BR_LAB_RESULTQUAL',prop:'Titleformat'},{av:'edtBR_Lab_ResultQual_Title',ctrl:'BR_LAB_RESULTQUAL',prop:'Title'},{av:'edtBR_Lab_ResultNum_Titleformat',ctrl:'BR_LAB_RESULTNUM',prop:'Titleformat'},{av:'edtBR_Lab_ResultNum_Title',ctrl:'BR_LAB_RESULTNUM',prop:'Title'},{av:'edtBR_Lab_ResultUnit_Titleformat',ctrl:'BR_LAB_RESULTUNIT',prop:'Titleformat'},{av:'edtBR_Lab_ResultUnit_Title',ctrl:'BR_LAB_RESULTUNIT',prop:'Title'},{av:'edtBR_Lab_AbnInd_Titleformat',ctrl:'BR_LAB_ABNIND',prop:'Titleformat'},{av:'edtBR_Lab_AbnInd_Title',ctrl:'BR_LAB_ABNIND',prop:'Title'},{av:'edtBR_Lab_NormRangeLow_Titleformat',ctrl:'BR_LAB_NORMRANGELOW',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeLow_Title',ctrl:'BR_LAB_NORMRANGELOW',prop:'Title'},{av:'edtBR_Lab_NormRangeHigh_Titleformat',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeHigh_Title',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Title'},{av:'edtBR_Lab_TestMethod_Titleformat',ctrl:'BR_LAB_TESTMETHOD',prop:'Titleformat'},{av:'edtBR_Lab_TestMethod_Title',ctrl:'BR_LAB_TESTMETHOD',prop:'Title'},{av:'edtBR_Lab_InstrumentName_Titleformat',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentName_Title',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Title'},{av:'edtBR_Lab_InstrumentCode_Titleformat',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentCode_Title',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_LAB_RESULTQUAL.ONOPTIONCLICKED","{handler:'E273H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_SAMPLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Lab_TestIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTENGNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_BR_Lab_AgeTitleControlIdToReplace',fld:'vDDO_BR_LAB_AGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Lab_DiagTitleControlIdToReplace',fld:'vDDO_BR_LAB_DIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_RECEIVINGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_REPORTTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGELOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGEHIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTMETHODTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_lab_resultqual_Activeeventkey',ctrl:'DDO_BR_LAB_RESULTQUAL',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_LAB_RESULTQUAL.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_lab_resultqual_Sortedstatus',ctrl:'DDO_BR_LAB_RESULTQUAL',prop:'SortedStatus'},{av:'AV12BR_LabIDTitleFilterData',fld:'vBR_LABIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV58BR_Lab_SampleIDTitleFilterData',fld:'vBR_LAB_SAMPLEIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Lab_TestIDTitleFilterData',fld:'vBR_LAB_TESTIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Lab_TestCodeTitleFilterData',fld:'vBR_LAB_TESTCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Lab_TestNameTitleFilterData',fld:'vBR_LAB_TESTNAMETITLEFILTERDATA',pic:''},{av:'AV60BR_Lab_TestEngNameTitleFilterData',fld:'vBR_LAB_TESTENGNAMETITLEFILTERDATA',pic:''},{av:'AV62BR_Lab_AgeTitleFilterData',fld:'vBR_LAB_AGETITLEFILTERDATA',pic:''},{av:'AV64BR_Lab_DiagTitleFilterData',fld:'vBR_LAB_DIAGTITLEFILTERDATA',pic:''},{av:'AV24BR_Lab_SpecimenDateTitleFilterData',fld:'vBR_LAB_SPECIMENDATETITLEFILTERDATA',pic:''},{av:'AV66BR_Lab_ReceivingTimeTitleFilterData',fld:'vBR_LAB_RECEIVINGTIMETITLEFILTERDATA',pic:''},{av:'AV68BR_Lab_ReportTimeTitleFilterData',fld:'vBR_LAB_REPORTTIMETITLEFILTERDATA',pic:''},{av:'AV26BR_Lab_SpecimenSourceTitleFilterData',fld:'vBR_LAB_SPECIMENSOURCETITLEFILTERDATA',pic:''},{av:'AV32BR_Lab_ResultQualTitleFilterData',fld:'vBR_LAB_RESULTQUALTITLEFILTERDATA',pic:''},{av:'AV34BR_Lab_ResultNumTitleFilterData',fld:'vBR_LAB_RESULTNUMTITLEFILTERDATA',pic:''},{av:'AV36BR_Lab_ResultUnitTitleFilterData',fld:'vBR_LAB_RESULTUNITTITLEFILTERDATA',pic:''},{av:'AV38BR_Lab_AbnIndTitleFilterData',fld:'vBR_LAB_ABNINDTITLEFILTERDATA',pic:''},{av:'AV40BR_Lab_NormRangeLowTitleFilterData',fld:'vBR_LAB_NORMRANGELOWTITLEFILTERDATA',pic:''},{av:'AV42BR_Lab_NormRangeHighTitleFilterData',fld:'vBR_LAB_NORMRANGEHIGHTITLEFILTERDATA',pic:''},{av:'AV44BR_Lab_TestMethodTitleFilterData',fld:'vBR_LAB_TESTMETHODTITLEFILTERDATA',pic:''},{av:'AV48BR_Lab_InstrumentNameTitleFilterData',fld:'vBR_LAB_INSTRUMENTNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Lab_InstrumentCodeTitleFilterData',fld:'vBR_LAB_INSTRUMENTCODETITLEFILTERDATA',pic:''},{av:'edtBR_LabID_Titleformat',ctrl:'BR_LABID',prop:'Titleformat'},{av:'edtBR_LabID_Title',ctrl:'BR_LABID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Lab_SampleID_Titleformat',ctrl:'BR_LAB_SAMPLEID',prop:'Titleformat'},{av:'edtBR_Lab_SampleID_Title',ctrl:'BR_LAB_SAMPLEID',prop:'Title'},{av:'edtBR_Lab_TestID_Titleformat',ctrl:'BR_LAB_TESTID',prop:'Titleformat'},{av:'edtBR_Lab_TestID_Title',ctrl:'BR_LAB_TESTID',prop:'Title'},{av:'edtBR_Lab_TestCode_Titleformat',ctrl:'BR_LAB_TESTCODE',prop:'Titleformat'},{av:'edtBR_Lab_TestCode_Title',ctrl:'BR_LAB_TESTCODE',prop:'Title'},{av:'edtBR_Lab_TestName_Titleformat',ctrl:'BR_LAB_TESTNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestName_Title',ctrl:'BR_LAB_TESTNAME',prop:'Title'},{av:'edtBR_Lab_TestEngName_Titleformat',ctrl:'BR_LAB_TESTENGNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestEngName_Title',ctrl:'BR_LAB_TESTENGNAME',prop:'Title'},{av:'edtBR_Lab_Age_Titleformat',ctrl:'BR_LAB_AGE',prop:'Titleformat'},{av:'edtBR_Lab_Age_Title',ctrl:'BR_LAB_AGE',prop:'Title'},{av:'edtBR_Lab_Diag_Titleformat',ctrl:'BR_LAB_DIAG',prop:'Titleformat'},{av:'edtBR_Lab_Diag_Title',ctrl:'BR_LAB_DIAG',prop:'Title'},{av:'edtBR_Lab_SpecimenDate_Titleformat',ctrl:'BR_LAB_SPECIMENDATE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenDate_Title',ctrl:'BR_LAB_SPECIMENDATE',prop:'Title'},{av:'edtBR_Lab_ReceivingTime_Titleformat',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReceivingTime_Title',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Title'},{av:'edtBR_Lab_ReportTime_Titleformat',ctrl:'BR_LAB_REPORTTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReportTime_Title',ctrl:'BR_LAB_REPORTTIME',prop:'Title'},{av:'edtBR_Lab_SpecimenSource_Titleformat',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenSource_Title',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Title'},{av:'edtBR_Lab_ResultQual_Titleformat',ctrl:'BR_LAB_RESULTQUAL',prop:'Titleformat'},{av:'edtBR_Lab_ResultQual_Title',ctrl:'BR_LAB_RESULTQUAL',prop:'Title'},{av:'edtBR_Lab_ResultNum_Titleformat',ctrl:'BR_LAB_RESULTNUM',prop:'Titleformat'},{av:'edtBR_Lab_ResultNum_Title',ctrl:'BR_LAB_RESULTNUM',prop:'Title'},{av:'edtBR_Lab_ResultUnit_Titleformat',ctrl:'BR_LAB_RESULTUNIT',prop:'Titleformat'},{av:'edtBR_Lab_ResultUnit_Title',ctrl:'BR_LAB_RESULTUNIT',prop:'Title'},{av:'edtBR_Lab_AbnInd_Titleformat',ctrl:'BR_LAB_ABNIND',prop:'Titleformat'},{av:'edtBR_Lab_AbnInd_Title',ctrl:'BR_LAB_ABNIND',prop:'Title'},{av:'edtBR_Lab_NormRangeLow_Titleformat',ctrl:'BR_LAB_NORMRANGELOW',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeLow_Title',ctrl:'BR_LAB_NORMRANGELOW',prop:'Title'},{av:'edtBR_Lab_NormRangeHigh_Titleformat',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeHigh_Title',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Title'},{av:'edtBR_Lab_TestMethod_Titleformat',ctrl:'BR_LAB_TESTMETHOD',prop:'Titleformat'},{av:'edtBR_Lab_TestMethod_Title',ctrl:'BR_LAB_TESTMETHOD',prop:'Title'},{av:'edtBR_Lab_InstrumentName_Titleformat',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentName_Title',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Title'},{av:'edtBR_Lab_InstrumentCode_Titleformat',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentCode_Title',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_LAB_RESULTNUM.ONOPTIONCLICKED","{handler:'E283H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_SAMPLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Lab_TestIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTENGNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_BR_Lab_AgeTitleControlIdToReplace',fld:'vDDO_BR_LAB_AGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Lab_DiagTitleControlIdToReplace',fld:'vDDO_BR_LAB_DIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_RECEIVINGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_REPORTTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGELOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGEHIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTMETHODTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_lab_resultnum_Activeeventkey',ctrl:'DDO_BR_LAB_RESULTNUM',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_LAB_RESULTNUM.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_lab_resultnum_Sortedstatus',ctrl:'DDO_BR_LAB_RESULTNUM',prop:'SortedStatus'},{av:'AV12BR_LabIDTitleFilterData',fld:'vBR_LABIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV58BR_Lab_SampleIDTitleFilterData',fld:'vBR_LAB_SAMPLEIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Lab_TestIDTitleFilterData',fld:'vBR_LAB_TESTIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Lab_TestCodeTitleFilterData',fld:'vBR_LAB_TESTCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Lab_TestNameTitleFilterData',fld:'vBR_LAB_TESTNAMETITLEFILTERDATA',pic:''},{av:'AV60BR_Lab_TestEngNameTitleFilterData',fld:'vBR_LAB_TESTENGNAMETITLEFILTERDATA',pic:''},{av:'AV62BR_Lab_AgeTitleFilterData',fld:'vBR_LAB_AGETITLEFILTERDATA',pic:''},{av:'AV64BR_Lab_DiagTitleFilterData',fld:'vBR_LAB_DIAGTITLEFILTERDATA',pic:''},{av:'AV24BR_Lab_SpecimenDateTitleFilterData',fld:'vBR_LAB_SPECIMENDATETITLEFILTERDATA',pic:''},{av:'AV66BR_Lab_ReceivingTimeTitleFilterData',fld:'vBR_LAB_RECEIVINGTIMETITLEFILTERDATA',pic:''},{av:'AV68BR_Lab_ReportTimeTitleFilterData',fld:'vBR_LAB_REPORTTIMETITLEFILTERDATA',pic:''},{av:'AV26BR_Lab_SpecimenSourceTitleFilterData',fld:'vBR_LAB_SPECIMENSOURCETITLEFILTERDATA',pic:''},{av:'AV32BR_Lab_ResultQualTitleFilterData',fld:'vBR_LAB_RESULTQUALTITLEFILTERDATA',pic:''},{av:'AV34BR_Lab_ResultNumTitleFilterData',fld:'vBR_LAB_RESULTNUMTITLEFILTERDATA',pic:''},{av:'AV36BR_Lab_ResultUnitTitleFilterData',fld:'vBR_LAB_RESULTUNITTITLEFILTERDATA',pic:''},{av:'AV38BR_Lab_AbnIndTitleFilterData',fld:'vBR_LAB_ABNINDTITLEFILTERDATA',pic:''},{av:'AV40BR_Lab_NormRangeLowTitleFilterData',fld:'vBR_LAB_NORMRANGELOWTITLEFILTERDATA',pic:''},{av:'AV42BR_Lab_NormRangeHighTitleFilterData',fld:'vBR_LAB_NORMRANGEHIGHTITLEFILTERDATA',pic:''},{av:'AV44BR_Lab_TestMethodTitleFilterData',fld:'vBR_LAB_TESTMETHODTITLEFILTERDATA',pic:''},{av:'AV48BR_Lab_InstrumentNameTitleFilterData',fld:'vBR_LAB_INSTRUMENTNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Lab_InstrumentCodeTitleFilterData',fld:'vBR_LAB_INSTRUMENTCODETITLEFILTERDATA',pic:''},{av:'edtBR_LabID_Titleformat',ctrl:'BR_LABID',prop:'Titleformat'},{av:'edtBR_LabID_Title',ctrl:'BR_LABID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Lab_SampleID_Titleformat',ctrl:'BR_LAB_SAMPLEID',prop:'Titleformat'},{av:'edtBR_Lab_SampleID_Title',ctrl:'BR_LAB_SAMPLEID',prop:'Title'},{av:'edtBR_Lab_TestID_Titleformat',ctrl:'BR_LAB_TESTID',prop:'Titleformat'},{av:'edtBR_Lab_TestID_Title',ctrl:'BR_LAB_TESTID',prop:'Title'},{av:'edtBR_Lab_TestCode_Titleformat',ctrl:'BR_LAB_TESTCODE',prop:'Titleformat'},{av:'edtBR_Lab_TestCode_Title',ctrl:'BR_LAB_TESTCODE',prop:'Title'},{av:'edtBR_Lab_TestName_Titleformat',ctrl:'BR_LAB_TESTNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestName_Title',ctrl:'BR_LAB_TESTNAME',prop:'Title'},{av:'edtBR_Lab_TestEngName_Titleformat',ctrl:'BR_LAB_TESTENGNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestEngName_Title',ctrl:'BR_LAB_TESTENGNAME',prop:'Title'},{av:'edtBR_Lab_Age_Titleformat',ctrl:'BR_LAB_AGE',prop:'Titleformat'},{av:'edtBR_Lab_Age_Title',ctrl:'BR_LAB_AGE',prop:'Title'},{av:'edtBR_Lab_Diag_Titleformat',ctrl:'BR_LAB_DIAG',prop:'Titleformat'},{av:'edtBR_Lab_Diag_Title',ctrl:'BR_LAB_DIAG',prop:'Title'},{av:'edtBR_Lab_SpecimenDate_Titleformat',ctrl:'BR_LAB_SPECIMENDATE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenDate_Title',ctrl:'BR_LAB_SPECIMENDATE',prop:'Title'},{av:'edtBR_Lab_ReceivingTime_Titleformat',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReceivingTime_Title',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Title'},{av:'edtBR_Lab_ReportTime_Titleformat',ctrl:'BR_LAB_REPORTTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReportTime_Title',ctrl:'BR_LAB_REPORTTIME',prop:'Title'},{av:'edtBR_Lab_SpecimenSource_Titleformat',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenSource_Title',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Title'},{av:'edtBR_Lab_ResultQual_Titleformat',ctrl:'BR_LAB_RESULTQUAL',prop:'Titleformat'},{av:'edtBR_Lab_ResultQual_Title',ctrl:'BR_LAB_RESULTQUAL',prop:'Title'},{av:'edtBR_Lab_ResultNum_Titleformat',ctrl:'BR_LAB_RESULTNUM',prop:'Titleformat'},{av:'edtBR_Lab_ResultNum_Title',ctrl:'BR_LAB_RESULTNUM',prop:'Title'},{av:'edtBR_Lab_ResultUnit_Titleformat',ctrl:'BR_LAB_RESULTUNIT',prop:'Titleformat'},{av:'edtBR_Lab_ResultUnit_Title',ctrl:'BR_LAB_RESULTUNIT',prop:'Title'},{av:'edtBR_Lab_AbnInd_Titleformat',ctrl:'BR_LAB_ABNIND',prop:'Titleformat'},{av:'edtBR_Lab_AbnInd_Title',ctrl:'BR_LAB_ABNIND',prop:'Title'},{av:'edtBR_Lab_NormRangeLow_Titleformat',ctrl:'BR_LAB_NORMRANGELOW',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeLow_Title',ctrl:'BR_LAB_NORMRANGELOW',prop:'Title'},{av:'edtBR_Lab_NormRangeHigh_Titleformat',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeHigh_Title',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Title'},{av:'edtBR_Lab_TestMethod_Titleformat',ctrl:'BR_LAB_TESTMETHOD',prop:'Titleformat'},{av:'edtBR_Lab_TestMethod_Title',ctrl:'BR_LAB_TESTMETHOD',prop:'Title'},{av:'edtBR_Lab_InstrumentName_Titleformat',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentName_Title',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Title'},{av:'edtBR_Lab_InstrumentCode_Titleformat',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentCode_Title',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_LAB_RESULTUNIT.ONOPTIONCLICKED","{handler:'E293H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_SAMPLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Lab_TestIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTENGNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_BR_Lab_AgeTitleControlIdToReplace',fld:'vDDO_BR_LAB_AGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Lab_DiagTitleControlIdToReplace',fld:'vDDO_BR_LAB_DIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_RECEIVINGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_REPORTTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGELOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGEHIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTMETHODTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_lab_resultunit_Activeeventkey',ctrl:'DDO_BR_LAB_RESULTUNIT',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_LAB_RESULTUNIT.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_lab_resultunit_Sortedstatus',ctrl:'DDO_BR_LAB_RESULTUNIT',prop:'SortedStatus'},{av:'AV12BR_LabIDTitleFilterData',fld:'vBR_LABIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV58BR_Lab_SampleIDTitleFilterData',fld:'vBR_LAB_SAMPLEIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Lab_TestIDTitleFilterData',fld:'vBR_LAB_TESTIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Lab_TestCodeTitleFilterData',fld:'vBR_LAB_TESTCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Lab_TestNameTitleFilterData',fld:'vBR_LAB_TESTNAMETITLEFILTERDATA',pic:''},{av:'AV60BR_Lab_TestEngNameTitleFilterData',fld:'vBR_LAB_TESTENGNAMETITLEFILTERDATA',pic:''},{av:'AV62BR_Lab_AgeTitleFilterData',fld:'vBR_LAB_AGETITLEFILTERDATA',pic:''},{av:'AV64BR_Lab_DiagTitleFilterData',fld:'vBR_LAB_DIAGTITLEFILTERDATA',pic:''},{av:'AV24BR_Lab_SpecimenDateTitleFilterData',fld:'vBR_LAB_SPECIMENDATETITLEFILTERDATA',pic:''},{av:'AV66BR_Lab_ReceivingTimeTitleFilterData',fld:'vBR_LAB_RECEIVINGTIMETITLEFILTERDATA',pic:''},{av:'AV68BR_Lab_ReportTimeTitleFilterData',fld:'vBR_LAB_REPORTTIMETITLEFILTERDATA',pic:''},{av:'AV26BR_Lab_SpecimenSourceTitleFilterData',fld:'vBR_LAB_SPECIMENSOURCETITLEFILTERDATA',pic:''},{av:'AV32BR_Lab_ResultQualTitleFilterData',fld:'vBR_LAB_RESULTQUALTITLEFILTERDATA',pic:''},{av:'AV34BR_Lab_ResultNumTitleFilterData',fld:'vBR_LAB_RESULTNUMTITLEFILTERDATA',pic:''},{av:'AV36BR_Lab_ResultUnitTitleFilterData',fld:'vBR_LAB_RESULTUNITTITLEFILTERDATA',pic:''},{av:'AV38BR_Lab_AbnIndTitleFilterData',fld:'vBR_LAB_ABNINDTITLEFILTERDATA',pic:''},{av:'AV40BR_Lab_NormRangeLowTitleFilterData',fld:'vBR_LAB_NORMRANGELOWTITLEFILTERDATA',pic:''},{av:'AV42BR_Lab_NormRangeHighTitleFilterData',fld:'vBR_LAB_NORMRANGEHIGHTITLEFILTERDATA',pic:''},{av:'AV44BR_Lab_TestMethodTitleFilterData',fld:'vBR_LAB_TESTMETHODTITLEFILTERDATA',pic:''},{av:'AV48BR_Lab_InstrumentNameTitleFilterData',fld:'vBR_LAB_INSTRUMENTNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Lab_InstrumentCodeTitleFilterData',fld:'vBR_LAB_INSTRUMENTCODETITLEFILTERDATA',pic:''},{av:'edtBR_LabID_Titleformat',ctrl:'BR_LABID',prop:'Titleformat'},{av:'edtBR_LabID_Title',ctrl:'BR_LABID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Lab_SampleID_Titleformat',ctrl:'BR_LAB_SAMPLEID',prop:'Titleformat'},{av:'edtBR_Lab_SampleID_Title',ctrl:'BR_LAB_SAMPLEID',prop:'Title'},{av:'edtBR_Lab_TestID_Titleformat',ctrl:'BR_LAB_TESTID',prop:'Titleformat'},{av:'edtBR_Lab_TestID_Title',ctrl:'BR_LAB_TESTID',prop:'Title'},{av:'edtBR_Lab_TestCode_Titleformat',ctrl:'BR_LAB_TESTCODE',prop:'Titleformat'},{av:'edtBR_Lab_TestCode_Title',ctrl:'BR_LAB_TESTCODE',prop:'Title'},{av:'edtBR_Lab_TestName_Titleformat',ctrl:'BR_LAB_TESTNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestName_Title',ctrl:'BR_LAB_TESTNAME',prop:'Title'},{av:'edtBR_Lab_TestEngName_Titleformat',ctrl:'BR_LAB_TESTENGNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestEngName_Title',ctrl:'BR_LAB_TESTENGNAME',prop:'Title'},{av:'edtBR_Lab_Age_Titleformat',ctrl:'BR_LAB_AGE',prop:'Titleformat'},{av:'edtBR_Lab_Age_Title',ctrl:'BR_LAB_AGE',prop:'Title'},{av:'edtBR_Lab_Diag_Titleformat',ctrl:'BR_LAB_DIAG',prop:'Titleformat'},{av:'edtBR_Lab_Diag_Title',ctrl:'BR_LAB_DIAG',prop:'Title'},{av:'edtBR_Lab_SpecimenDate_Titleformat',ctrl:'BR_LAB_SPECIMENDATE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenDate_Title',ctrl:'BR_LAB_SPECIMENDATE',prop:'Title'},{av:'edtBR_Lab_ReceivingTime_Titleformat',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReceivingTime_Title',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Title'},{av:'edtBR_Lab_ReportTime_Titleformat',ctrl:'BR_LAB_REPORTTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReportTime_Title',ctrl:'BR_LAB_REPORTTIME',prop:'Title'},{av:'edtBR_Lab_SpecimenSource_Titleformat',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenSource_Title',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Title'},{av:'edtBR_Lab_ResultQual_Titleformat',ctrl:'BR_LAB_RESULTQUAL',prop:'Titleformat'},{av:'edtBR_Lab_ResultQual_Title',ctrl:'BR_LAB_RESULTQUAL',prop:'Title'},{av:'edtBR_Lab_ResultNum_Titleformat',ctrl:'BR_LAB_RESULTNUM',prop:'Titleformat'},{av:'edtBR_Lab_ResultNum_Title',ctrl:'BR_LAB_RESULTNUM',prop:'Title'},{av:'edtBR_Lab_ResultUnit_Titleformat',ctrl:'BR_LAB_RESULTUNIT',prop:'Titleformat'},{av:'edtBR_Lab_ResultUnit_Title',ctrl:'BR_LAB_RESULTUNIT',prop:'Title'},{av:'edtBR_Lab_AbnInd_Titleformat',ctrl:'BR_LAB_ABNIND',prop:'Titleformat'},{av:'edtBR_Lab_AbnInd_Title',ctrl:'BR_LAB_ABNIND',prop:'Title'},{av:'edtBR_Lab_NormRangeLow_Titleformat',ctrl:'BR_LAB_NORMRANGELOW',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeLow_Title',ctrl:'BR_LAB_NORMRANGELOW',prop:'Title'},{av:'edtBR_Lab_NormRangeHigh_Titleformat',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeHigh_Title',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Title'},{av:'edtBR_Lab_TestMethod_Titleformat',ctrl:'BR_LAB_TESTMETHOD',prop:'Titleformat'},{av:'edtBR_Lab_TestMethod_Title',ctrl:'BR_LAB_TESTMETHOD',prop:'Title'},{av:'edtBR_Lab_InstrumentName_Titleformat',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentName_Title',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Title'},{av:'edtBR_Lab_InstrumentCode_Titleformat',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentCode_Title',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_LAB_ABNIND.ONOPTIONCLICKED","{handler:'E303H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_SAMPLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Lab_TestIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTENGNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_BR_Lab_AgeTitleControlIdToReplace',fld:'vDDO_BR_LAB_AGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Lab_DiagTitleControlIdToReplace',fld:'vDDO_BR_LAB_DIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_RECEIVINGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_REPORTTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGELOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGEHIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTMETHODTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_lab_abnind_Activeeventkey',ctrl:'DDO_BR_LAB_ABNIND',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_LAB_ABNIND.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_lab_abnind_Sortedstatus',ctrl:'DDO_BR_LAB_ABNIND',prop:'SortedStatus'},{av:'AV12BR_LabIDTitleFilterData',fld:'vBR_LABIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV58BR_Lab_SampleIDTitleFilterData',fld:'vBR_LAB_SAMPLEIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Lab_TestIDTitleFilterData',fld:'vBR_LAB_TESTIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Lab_TestCodeTitleFilterData',fld:'vBR_LAB_TESTCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Lab_TestNameTitleFilterData',fld:'vBR_LAB_TESTNAMETITLEFILTERDATA',pic:''},{av:'AV60BR_Lab_TestEngNameTitleFilterData',fld:'vBR_LAB_TESTENGNAMETITLEFILTERDATA',pic:''},{av:'AV62BR_Lab_AgeTitleFilterData',fld:'vBR_LAB_AGETITLEFILTERDATA',pic:''},{av:'AV64BR_Lab_DiagTitleFilterData',fld:'vBR_LAB_DIAGTITLEFILTERDATA',pic:''},{av:'AV24BR_Lab_SpecimenDateTitleFilterData',fld:'vBR_LAB_SPECIMENDATETITLEFILTERDATA',pic:''},{av:'AV66BR_Lab_ReceivingTimeTitleFilterData',fld:'vBR_LAB_RECEIVINGTIMETITLEFILTERDATA',pic:''},{av:'AV68BR_Lab_ReportTimeTitleFilterData',fld:'vBR_LAB_REPORTTIMETITLEFILTERDATA',pic:''},{av:'AV26BR_Lab_SpecimenSourceTitleFilterData',fld:'vBR_LAB_SPECIMENSOURCETITLEFILTERDATA',pic:''},{av:'AV32BR_Lab_ResultQualTitleFilterData',fld:'vBR_LAB_RESULTQUALTITLEFILTERDATA',pic:''},{av:'AV34BR_Lab_ResultNumTitleFilterData',fld:'vBR_LAB_RESULTNUMTITLEFILTERDATA',pic:''},{av:'AV36BR_Lab_ResultUnitTitleFilterData',fld:'vBR_LAB_RESULTUNITTITLEFILTERDATA',pic:''},{av:'AV38BR_Lab_AbnIndTitleFilterData',fld:'vBR_LAB_ABNINDTITLEFILTERDATA',pic:''},{av:'AV40BR_Lab_NormRangeLowTitleFilterData',fld:'vBR_LAB_NORMRANGELOWTITLEFILTERDATA',pic:''},{av:'AV42BR_Lab_NormRangeHighTitleFilterData',fld:'vBR_LAB_NORMRANGEHIGHTITLEFILTERDATA',pic:''},{av:'AV44BR_Lab_TestMethodTitleFilterData',fld:'vBR_LAB_TESTMETHODTITLEFILTERDATA',pic:''},{av:'AV48BR_Lab_InstrumentNameTitleFilterData',fld:'vBR_LAB_INSTRUMENTNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Lab_InstrumentCodeTitleFilterData',fld:'vBR_LAB_INSTRUMENTCODETITLEFILTERDATA',pic:''},{av:'edtBR_LabID_Titleformat',ctrl:'BR_LABID',prop:'Titleformat'},{av:'edtBR_LabID_Title',ctrl:'BR_LABID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Lab_SampleID_Titleformat',ctrl:'BR_LAB_SAMPLEID',prop:'Titleformat'},{av:'edtBR_Lab_SampleID_Title',ctrl:'BR_LAB_SAMPLEID',prop:'Title'},{av:'edtBR_Lab_TestID_Titleformat',ctrl:'BR_LAB_TESTID',prop:'Titleformat'},{av:'edtBR_Lab_TestID_Title',ctrl:'BR_LAB_TESTID',prop:'Title'},{av:'edtBR_Lab_TestCode_Titleformat',ctrl:'BR_LAB_TESTCODE',prop:'Titleformat'},{av:'edtBR_Lab_TestCode_Title',ctrl:'BR_LAB_TESTCODE',prop:'Title'},{av:'edtBR_Lab_TestName_Titleformat',ctrl:'BR_LAB_TESTNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestName_Title',ctrl:'BR_LAB_TESTNAME',prop:'Title'},{av:'edtBR_Lab_TestEngName_Titleformat',ctrl:'BR_LAB_TESTENGNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestEngName_Title',ctrl:'BR_LAB_TESTENGNAME',prop:'Title'},{av:'edtBR_Lab_Age_Titleformat',ctrl:'BR_LAB_AGE',prop:'Titleformat'},{av:'edtBR_Lab_Age_Title',ctrl:'BR_LAB_AGE',prop:'Title'},{av:'edtBR_Lab_Diag_Titleformat',ctrl:'BR_LAB_DIAG',prop:'Titleformat'},{av:'edtBR_Lab_Diag_Title',ctrl:'BR_LAB_DIAG',prop:'Title'},{av:'edtBR_Lab_SpecimenDate_Titleformat',ctrl:'BR_LAB_SPECIMENDATE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenDate_Title',ctrl:'BR_LAB_SPECIMENDATE',prop:'Title'},{av:'edtBR_Lab_ReceivingTime_Titleformat',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReceivingTime_Title',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Title'},{av:'edtBR_Lab_ReportTime_Titleformat',ctrl:'BR_LAB_REPORTTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReportTime_Title',ctrl:'BR_LAB_REPORTTIME',prop:'Title'},{av:'edtBR_Lab_SpecimenSource_Titleformat',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenSource_Title',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Title'},{av:'edtBR_Lab_ResultQual_Titleformat',ctrl:'BR_LAB_RESULTQUAL',prop:'Titleformat'},{av:'edtBR_Lab_ResultQual_Title',ctrl:'BR_LAB_RESULTQUAL',prop:'Title'},{av:'edtBR_Lab_ResultNum_Titleformat',ctrl:'BR_LAB_RESULTNUM',prop:'Titleformat'},{av:'edtBR_Lab_ResultNum_Title',ctrl:'BR_LAB_RESULTNUM',prop:'Title'},{av:'edtBR_Lab_ResultUnit_Titleformat',ctrl:'BR_LAB_RESULTUNIT',prop:'Titleformat'},{av:'edtBR_Lab_ResultUnit_Title',ctrl:'BR_LAB_RESULTUNIT',prop:'Title'},{av:'edtBR_Lab_AbnInd_Titleformat',ctrl:'BR_LAB_ABNIND',prop:'Titleformat'},{av:'edtBR_Lab_AbnInd_Title',ctrl:'BR_LAB_ABNIND',prop:'Title'},{av:'edtBR_Lab_NormRangeLow_Titleformat',ctrl:'BR_LAB_NORMRANGELOW',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeLow_Title',ctrl:'BR_LAB_NORMRANGELOW',prop:'Title'},{av:'edtBR_Lab_NormRangeHigh_Titleformat',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeHigh_Title',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Title'},{av:'edtBR_Lab_TestMethod_Titleformat',ctrl:'BR_LAB_TESTMETHOD',prop:'Titleformat'},{av:'edtBR_Lab_TestMethod_Title',ctrl:'BR_LAB_TESTMETHOD',prop:'Title'},{av:'edtBR_Lab_InstrumentName_Titleformat',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentName_Title',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Title'},{av:'edtBR_Lab_InstrumentCode_Titleformat',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentCode_Title',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_LAB_NORMRANGELOW.ONOPTIONCLICKED","{handler:'E313H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_SAMPLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Lab_TestIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTENGNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_BR_Lab_AgeTitleControlIdToReplace',fld:'vDDO_BR_LAB_AGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Lab_DiagTitleControlIdToReplace',fld:'vDDO_BR_LAB_DIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_RECEIVINGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_REPORTTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGELOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGEHIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTMETHODTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_lab_normrangelow_Activeeventkey',ctrl:'DDO_BR_LAB_NORMRANGELOW',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_LAB_NORMRANGELOW.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_lab_normrangelow_Sortedstatus',ctrl:'DDO_BR_LAB_NORMRANGELOW',prop:'SortedStatus'},{av:'AV12BR_LabIDTitleFilterData',fld:'vBR_LABIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV58BR_Lab_SampleIDTitleFilterData',fld:'vBR_LAB_SAMPLEIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Lab_TestIDTitleFilterData',fld:'vBR_LAB_TESTIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Lab_TestCodeTitleFilterData',fld:'vBR_LAB_TESTCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Lab_TestNameTitleFilterData',fld:'vBR_LAB_TESTNAMETITLEFILTERDATA',pic:''},{av:'AV60BR_Lab_TestEngNameTitleFilterData',fld:'vBR_LAB_TESTENGNAMETITLEFILTERDATA',pic:''},{av:'AV62BR_Lab_AgeTitleFilterData',fld:'vBR_LAB_AGETITLEFILTERDATA',pic:''},{av:'AV64BR_Lab_DiagTitleFilterData',fld:'vBR_LAB_DIAGTITLEFILTERDATA',pic:''},{av:'AV24BR_Lab_SpecimenDateTitleFilterData',fld:'vBR_LAB_SPECIMENDATETITLEFILTERDATA',pic:''},{av:'AV66BR_Lab_ReceivingTimeTitleFilterData',fld:'vBR_LAB_RECEIVINGTIMETITLEFILTERDATA',pic:''},{av:'AV68BR_Lab_ReportTimeTitleFilterData',fld:'vBR_LAB_REPORTTIMETITLEFILTERDATA',pic:''},{av:'AV26BR_Lab_SpecimenSourceTitleFilterData',fld:'vBR_LAB_SPECIMENSOURCETITLEFILTERDATA',pic:''},{av:'AV32BR_Lab_ResultQualTitleFilterData',fld:'vBR_LAB_RESULTQUALTITLEFILTERDATA',pic:''},{av:'AV34BR_Lab_ResultNumTitleFilterData',fld:'vBR_LAB_RESULTNUMTITLEFILTERDATA',pic:''},{av:'AV36BR_Lab_ResultUnitTitleFilterData',fld:'vBR_LAB_RESULTUNITTITLEFILTERDATA',pic:''},{av:'AV38BR_Lab_AbnIndTitleFilterData',fld:'vBR_LAB_ABNINDTITLEFILTERDATA',pic:''},{av:'AV40BR_Lab_NormRangeLowTitleFilterData',fld:'vBR_LAB_NORMRANGELOWTITLEFILTERDATA',pic:''},{av:'AV42BR_Lab_NormRangeHighTitleFilterData',fld:'vBR_LAB_NORMRANGEHIGHTITLEFILTERDATA',pic:''},{av:'AV44BR_Lab_TestMethodTitleFilterData',fld:'vBR_LAB_TESTMETHODTITLEFILTERDATA',pic:''},{av:'AV48BR_Lab_InstrumentNameTitleFilterData',fld:'vBR_LAB_INSTRUMENTNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Lab_InstrumentCodeTitleFilterData',fld:'vBR_LAB_INSTRUMENTCODETITLEFILTERDATA',pic:''},{av:'edtBR_LabID_Titleformat',ctrl:'BR_LABID',prop:'Titleformat'},{av:'edtBR_LabID_Title',ctrl:'BR_LABID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Lab_SampleID_Titleformat',ctrl:'BR_LAB_SAMPLEID',prop:'Titleformat'},{av:'edtBR_Lab_SampleID_Title',ctrl:'BR_LAB_SAMPLEID',prop:'Title'},{av:'edtBR_Lab_TestID_Titleformat',ctrl:'BR_LAB_TESTID',prop:'Titleformat'},{av:'edtBR_Lab_TestID_Title',ctrl:'BR_LAB_TESTID',prop:'Title'},{av:'edtBR_Lab_TestCode_Titleformat',ctrl:'BR_LAB_TESTCODE',prop:'Titleformat'},{av:'edtBR_Lab_TestCode_Title',ctrl:'BR_LAB_TESTCODE',prop:'Title'},{av:'edtBR_Lab_TestName_Titleformat',ctrl:'BR_LAB_TESTNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestName_Title',ctrl:'BR_LAB_TESTNAME',prop:'Title'},{av:'edtBR_Lab_TestEngName_Titleformat',ctrl:'BR_LAB_TESTENGNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestEngName_Title',ctrl:'BR_LAB_TESTENGNAME',prop:'Title'},{av:'edtBR_Lab_Age_Titleformat',ctrl:'BR_LAB_AGE',prop:'Titleformat'},{av:'edtBR_Lab_Age_Title',ctrl:'BR_LAB_AGE',prop:'Title'},{av:'edtBR_Lab_Diag_Titleformat',ctrl:'BR_LAB_DIAG',prop:'Titleformat'},{av:'edtBR_Lab_Diag_Title',ctrl:'BR_LAB_DIAG',prop:'Title'},{av:'edtBR_Lab_SpecimenDate_Titleformat',ctrl:'BR_LAB_SPECIMENDATE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenDate_Title',ctrl:'BR_LAB_SPECIMENDATE',prop:'Title'},{av:'edtBR_Lab_ReceivingTime_Titleformat',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReceivingTime_Title',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Title'},{av:'edtBR_Lab_ReportTime_Titleformat',ctrl:'BR_LAB_REPORTTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReportTime_Title',ctrl:'BR_LAB_REPORTTIME',prop:'Title'},{av:'edtBR_Lab_SpecimenSource_Titleformat',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenSource_Title',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Title'},{av:'edtBR_Lab_ResultQual_Titleformat',ctrl:'BR_LAB_RESULTQUAL',prop:'Titleformat'},{av:'edtBR_Lab_ResultQual_Title',ctrl:'BR_LAB_RESULTQUAL',prop:'Title'},{av:'edtBR_Lab_ResultNum_Titleformat',ctrl:'BR_LAB_RESULTNUM',prop:'Titleformat'},{av:'edtBR_Lab_ResultNum_Title',ctrl:'BR_LAB_RESULTNUM',prop:'Title'},{av:'edtBR_Lab_ResultUnit_Titleformat',ctrl:'BR_LAB_RESULTUNIT',prop:'Titleformat'},{av:'edtBR_Lab_ResultUnit_Title',ctrl:'BR_LAB_RESULTUNIT',prop:'Title'},{av:'edtBR_Lab_AbnInd_Titleformat',ctrl:'BR_LAB_ABNIND',prop:'Titleformat'},{av:'edtBR_Lab_AbnInd_Title',ctrl:'BR_LAB_ABNIND',prop:'Title'},{av:'edtBR_Lab_NormRangeLow_Titleformat',ctrl:'BR_LAB_NORMRANGELOW',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeLow_Title',ctrl:'BR_LAB_NORMRANGELOW',prop:'Title'},{av:'edtBR_Lab_NormRangeHigh_Titleformat',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeHigh_Title',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Title'},{av:'edtBR_Lab_TestMethod_Titleformat',ctrl:'BR_LAB_TESTMETHOD',prop:'Titleformat'},{av:'edtBR_Lab_TestMethod_Title',ctrl:'BR_LAB_TESTMETHOD',prop:'Title'},{av:'edtBR_Lab_InstrumentName_Titleformat',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentName_Title',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Title'},{av:'edtBR_Lab_InstrumentCode_Titleformat',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentCode_Title',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_LAB_NORMRANGEHIGH.ONOPTIONCLICKED","{handler:'E323H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_SAMPLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Lab_TestIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTENGNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_BR_Lab_AgeTitleControlIdToReplace',fld:'vDDO_BR_LAB_AGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Lab_DiagTitleControlIdToReplace',fld:'vDDO_BR_LAB_DIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_RECEIVINGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_REPORTTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGELOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGEHIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTMETHODTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_lab_normrangehigh_Activeeventkey',ctrl:'DDO_BR_LAB_NORMRANGEHIGH',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_LAB_NORMRANGEHIGH.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_lab_normrangehigh_Sortedstatus',ctrl:'DDO_BR_LAB_NORMRANGEHIGH',prop:'SortedStatus'},{av:'AV12BR_LabIDTitleFilterData',fld:'vBR_LABIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV58BR_Lab_SampleIDTitleFilterData',fld:'vBR_LAB_SAMPLEIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Lab_TestIDTitleFilterData',fld:'vBR_LAB_TESTIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Lab_TestCodeTitleFilterData',fld:'vBR_LAB_TESTCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Lab_TestNameTitleFilterData',fld:'vBR_LAB_TESTNAMETITLEFILTERDATA',pic:''},{av:'AV60BR_Lab_TestEngNameTitleFilterData',fld:'vBR_LAB_TESTENGNAMETITLEFILTERDATA',pic:''},{av:'AV62BR_Lab_AgeTitleFilterData',fld:'vBR_LAB_AGETITLEFILTERDATA',pic:''},{av:'AV64BR_Lab_DiagTitleFilterData',fld:'vBR_LAB_DIAGTITLEFILTERDATA',pic:''},{av:'AV24BR_Lab_SpecimenDateTitleFilterData',fld:'vBR_LAB_SPECIMENDATETITLEFILTERDATA',pic:''},{av:'AV66BR_Lab_ReceivingTimeTitleFilterData',fld:'vBR_LAB_RECEIVINGTIMETITLEFILTERDATA',pic:''},{av:'AV68BR_Lab_ReportTimeTitleFilterData',fld:'vBR_LAB_REPORTTIMETITLEFILTERDATA',pic:''},{av:'AV26BR_Lab_SpecimenSourceTitleFilterData',fld:'vBR_LAB_SPECIMENSOURCETITLEFILTERDATA',pic:''},{av:'AV32BR_Lab_ResultQualTitleFilterData',fld:'vBR_LAB_RESULTQUALTITLEFILTERDATA',pic:''},{av:'AV34BR_Lab_ResultNumTitleFilterData',fld:'vBR_LAB_RESULTNUMTITLEFILTERDATA',pic:''},{av:'AV36BR_Lab_ResultUnitTitleFilterData',fld:'vBR_LAB_RESULTUNITTITLEFILTERDATA',pic:''},{av:'AV38BR_Lab_AbnIndTitleFilterData',fld:'vBR_LAB_ABNINDTITLEFILTERDATA',pic:''},{av:'AV40BR_Lab_NormRangeLowTitleFilterData',fld:'vBR_LAB_NORMRANGELOWTITLEFILTERDATA',pic:''},{av:'AV42BR_Lab_NormRangeHighTitleFilterData',fld:'vBR_LAB_NORMRANGEHIGHTITLEFILTERDATA',pic:''},{av:'AV44BR_Lab_TestMethodTitleFilterData',fld:'vBR_LAB_TESTMETHODTITLEFILTERDATA',pic:''},{av:'AV48BR_Lab_InstrumentNameTitleFilterData',fld:'vBR_LAB_INSTRUMENTNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Lab_InstrumentCodeTitleFilterData',fld:'vBR_LAB_INSTRUMENTCODETITLEFILTERDATA',pic:''},{av:'edtBR_LabID_Titleformat',ctrl:'BR_LABID',prop:'Titleformat'},{av:'edtBR_LabID_Title',ctrl:'BR_LABID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Lab_SampleID_Titleformat',ctrl:'BR_LAB_SAMPLEID',prop:'Titleformat'},{av:'edtBR_Lab_SampleID_Title',ctrl:'BR_LAB_SAMPLEID',prop:'Title'},{av:'edtBR_Lab_TestID_Titleformat',ctrl:'BR_LAB_TESTID',prop:'Titleformat'},{av:'edtBR_Lab_TestID_Title',ctrl:'BR_LAB_TESTID',prop:'Title'},{av:'edtBR_Lab_TestCode_Titleformat',ctrl:'BR_LAB_TESTCODE',prop:'Titleformat'},{av:'edtBR_Lab_TestCode_Title',ctrl:'BR_LAB_TESTCODE',prop:'Title'},{av:'edtBR_Lab_TestName_Titleformat',ctrl:'BR_LAB_TESTNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestName_Title',ctrl:'BR_LAB_TESTNAME',prop:'Title'},{av:'edtBR_Lab_TestEngName_Titleformat',ctrl:'BR_LAB_TESTENGNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestEngName_Title',ctrl:'BR_LAB_TESTENGNAME',prop:'Title'},{av:'edtBR_Lab_Age_Titleformat',ctrl:'BR_LAB_AGE',prop:'Titleformat'},{av:'edtBR_Lab_Age_Title',ctrl:'BR_LAB_AGE',prop:'Title'},{av:'edtBR_Lab_Diag_Titleformat',ctrl:'BR_LAB_DIAG',prop:'Titleformat'},{av:'edtBR_Lab_Diag_Title',ctrl:'BR_LAB_DIAG',prop:'Title'},{av:'edtBR_Lab_SpecimenDate_Titleformat',ctrl:'BR_LAB_SPECIMENDATE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenDate_Title',ctrl:'BR_LAB_SPECIMENDATE',prop:'Title'},{av:'edtBR_Lab_ReceivingTime_Titleformat',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReceivingTime_Title',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Title'},{av:'edtBR_Lab_ReportTime_Titleformat',ctrl:'BR_LAB_REPORTTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReportTime_Title',ctrl:'BR_LAB_REPORTTIME',prop:'Title'},{av:'edtBR_Lab_SpecimenSource_Titleformat',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenSource_Title',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Title'},{av:'edtBR_Lab_ResultQual_Titleformat',ctrl:'BR_LAB_RESULTQUAL',prop:'Titleformat'},{av:'edtBR_Lab_ResultQual_Title',ctrl:'BR_LAB_RESULTQUAL',prop:'Title'},{av:'edtBR_Lab_ResultNum_Titleformat',ctrl:'BR_LAB_RESULTNUM',prop:'Titleformat'},{av:'edtBR_Lab_ResultNum_Title',ctrl:'BR_LAB_RESULTNUM',prop:'Title'},{av:'edtBR_Lab_ResultUnit_Titleformat',ctrl:'BR_LAB_RESULTUNIT',prop:'Titleformat'},{av:'edtBR_Lab_ResultUnit_Title',ctrl:'BR_LAB_RESULTUNIT',prop:'Title'},{av:'edtBR_Lab_AbnInd_Titleformat',ctrl:'BR_LAB_ABNIND',prop:'Titleformat'},{av:'edtBR_Lab_AbnInd_Title',ctrl:'BR_LAB_ABNIND',prop:'Title'},{av:'edtBR_Lab_NormRangeLow_Titleformat',ctrl:'BR_LAB_NORMRANGELOW',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeLow_Title',ctrl:'BR_LAB_NORMRANGELOW',prop:'Title'},{av:'edtBR_Lab_NormRangeHigh_Titleformat',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeHigh_Title',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Title'},{av:'edtBR_Lab_TestMethod_Titleformat',ctrl:'BR_LAB_TESTMETHOD',prop:'Titleformat'},{av:'edtBR_Lab_TestMethod_Title',ctrl:'BR_LAB_TESTMETHOD',prop:'Title'},{av:'edtBR_Lab_InstrumentName_Titleformat',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentName_Title',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Title'},{av:'edtBR_Lab_InstrumentCode_Titleformat',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentCode_Title',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_LAB_TESTMETHOD.ONOPTIONCLICKED","{handler:'E333H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_SAMPLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Lab_TestIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTENGNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_BR_Lab_AgeTitleControlIdToReplace',fld:'vDDO_BR_LAB_AGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Lab_DiagTitleControlIdToReplace',fld:'vDDO_BR_LAB_DIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_RECEIVINGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_REPORTTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGELOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGEHIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTMETHODTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_lab_testmethod_Activeeventkey',ctrl:'DDO_BR_LAB_TESTMETHOD',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_LAB_TESTMETHOD.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_lab_testmethod_Sortedstatus',ctrl:'DDO_BR_LAB_TESTMETHOD',prop:'SortedStatus'},{av:'AV12BR_LabIDTitleFilterData',fld:'vBR_LABIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV58BR_Lab_SampleIDTitleFilterData',fld:'vBR_LAB_SAMPLEIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Lab_TestIDTitleFilterData',fld:'vBR_LAB_TESTIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Lab_TestCodeTitleFilterData',fld:'vBR_LAB_TESTCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Lab_TestNameTitleFilterData',fld:'vBR_LAB_TESTNAMETITLEFILTERDATA',pic:''},{av:'AV60BR_Lab_TestEngNameTitleFilterData',fld:'vBR_LAB_TESTENGNAMETITLEFILTERDATA',pic:''},{av:'AV62BR_Lab_AgeTitleFilterData',fld:'vBR_LAB_AGETITLEFILTERDATA',pic:''},{av:'AV64BR_Lab_DiagTitleFilterData',fld:'vBR_LAB_DIAGTITLEFILTERDATA',pic:''},{av:'AV24BR_Lab_SpecimenDateTitleFilterData',fld:'vBR_LAB_SPECIMENDATETITLEFILTERDATA',pic:''},{av:'AV66BR_Lab_ReceivingTimeTitleFilterData',fld:'vBR_LAB_RECEIVINGTIMETITLEFILTERDATA',pic:''},{av:'AV68BR_Lab_ReportTimeTitleFilterData',fld:'vBR_LAB_REPORTTIMETITLEFILTERDATA',pic:''},{av:'AV26BR_Lab_SpecimenSourceTitleFilterData',fld:'vBR_LAB_SPECIMENSOURCETITLEFILTERDATA',pic:''},{av:'AV32BR_Lab_ResultQualTitleFilterData',fld:'vBR_LAB_RESULTQUALTITLEFILTERDATA',pic:''},{av:'AV34BR_Lab_ResultNumTitleFilterData',fld:'vBR_LAB_RESULTNUMTITLEFILTERDATA',pic:''},{av:'AV36BR_Lab_ResultUnitTitleFilterData',fld:'vBR_LAB_RESULTUNITTITLEFILTERDATA',pic:''},{av:'AV38BR_Lab_AbnIndTitleFilterData',fld:'vBR_LAB_ABNINDTITLEFILTERDATA',pic:''},{av:'AV40BR_Lab_NormRangeLowTitleFilterData',fld:'vBR_LAB_NORMRANGELOWTITLEFILTERDATA',pic:''},{av:'AV42BR_Lab_NormRangeHighTitleFilterData',fld:'vBR_LAB_NORMRANGEHIGHTITLEFILTERDATA',pic:''},{av:'AV44BR_Lab_TestMethodTitleFilterData',fld:'vBR_LAB_TESTMETHODTITLEFILTERDATA',pic:''},{av:'AV48BR_Lab_InstrumentNameTitleFilterData',fld:'vBR_LAB_INSTRUMENTNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Lab_InstrumentCodeTitleFilterData',fld:'vBR_LAB_INSTRUMENTCODETITLEFILTERDATA',pic:''},{av:'edtBR_LabID_Titleformat',ctrl:'BR_LABID',prop:'Titleformat'},{av:'edtBR_LabID_Title',ctrl:'BR_LABID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Lab_SampleID_Titleformat',ctrl:'BR_LAB_SAMPLEID',prop:'Titleformat'},{av:'edtBR_Lab_SampleID_Title',ctrl:'BR_LAB_SAMPLEID',prop:'Title'},{av:'edtBR_Lab_TestID_Titleformat',ctrl:'BR_LAB_TESTID',prop:'Titleformat'},{av:'edtBR_Lab_TestID_Title',ctrl:'BR_LAB_TESTID',prop:'Title'},{av:'edtBR_Lab_TestCode_Titleformat',ctrl:'BR_LAB_TESTCODE',prop:'Titleformat'},{av:'edtBR_Lab_TestCode_Title',ctrl:'BR_LAB_TESTCODE',prop:'Title'},{av:'edtBR_Lab_TestName_Titleformat',ctrl:'BR_LAB_TESTNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestName_Title',ctrl:'BR_LAB_TESTNAME',prop:'Title'},{av:'edtBR_Lab_TestEngName_Titleformat',ctrl:'BR_LAB_TESTENGNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestEngName_Title',ctrl:'BR_LAB_TESTENGNAME',prop:'Title'},{av:'edtBR_Lab_Age_Titleformat',ctrl:'BR_LAB_AGE',prop:'Titleformat'},{av:'edtBR_Lab_Age_Title',ctrl:'BR_LAB_AGE',prop:'Title'},{av:'edtBR_Lab_Diag_Titleformat',ctrl:'BR_LAB_DIAG',prop:'Titleformat'},{av:'edtBR_Lab_Diag_Title',ctrl:'BR_LAB_DIAG',prop:'Title'},{av:'edtBR_Lab_SpecimenDate_Titleformat',ctrl:'BR_LAB_SPECIMENDATE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenDate_Title',ctrl:'BR_LAB_SPECIMENDATE',prop:'Title'},{av:'edtBR_Lab_ReceivingTime_Titleformat',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReceivingTime_Title',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Title'},{av:'edtBR_Lab_ReportTime_Titleformat',ctrl:'BR_LAB_REPORTTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReportTime_Title',ctrl:'BR_LAB_REPORTTIME',prop:'Title'},{av:'edtBR_Lab_SpecimenSource_Titleformat',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenSource_Title',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Title'},{av:'edtBR_Lab_ResultQual_Titleformat',ctrl:'BR_LAB_RESULTQUAL',prop:'Titleformat'},{av:'edtBR_Lab_ResultQual_Title',ctrl:'BR_LAB_RESULTQUAL',prop:'Title'},{av:'edtBR_Lab_ResultNum_Titleformat',ctrl:'BR_LAB_RESULTNUM',prop:'Titleformat'},{av:'edtBR_Lab_ResultNum_Title',ctrl:'BR_LAB_RESULTNUM',prop:'Title'},{av:'edtBR_Lab_ResultUnit_Titleformat',ctrl:'BR_LAB_RESULTUNIT',prop:'Titleformat'},{av:'edtBR_Lab_ResultUnit_Title',ctrl:'BR_LAB_RESULTUNIT',prop:'Title'},{av:'edtBR_Lab_AbnInd_Titleformat',ctrl:'BR_LAB_ABNIND',prop:'Titleformat'},{av:'edtBR_Lab_AbnInd_Title',ctrl:'BR_LAB_ABNIND',prop:'Title'},{av:'edtBR_Lab_NormRangeLow_Titleformat',ctrl:'BR_LAB_NORMRANGELOW',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeLow_Title',ctrl:'BR_LAB_NORMRANGELOW',prop:'Title'},{av:'edtBR_Lab_NormRangeHigh_Titleformat',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeHigh_Title',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Title'},{av:'edtBR_Lab_TestMethod_Titleformat',ctrl:'BR_LAB_TESTMETHOD',prop:'Titleformat'},{av:'edtBR_Lab_TestMethod_Title',ctrl:'BR_LAB_TESTMETHOD',prop:'Title'},{av:'edtBR_Lab_InstrumentName_Titleformat',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentName_Title',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Title'},{av:'edtBR_Lab_InstrumentCode_Titleformat',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentCode_Title',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_LAB_INSTRUMENTNAME.ONOPTIONCLICKED","{handler:'E343H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_SAMPLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Lab_TestIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTENGNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_BR_Lab_AgeTitleControlIdToReplace',fld:'vDDO_BR_LAB_AGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Lab_DiagTitleControlIdToReplace',fld:'vDDO_BR_LAB_DIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_RECEIVINGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_REPORTTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGELOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGEHIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTMETHODTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_lab_instrumentname_Activeeventkey',ctrl:'DDO_BR_LAB_INSTRUMENTNAME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_LAB_INSTRUMENTNAME.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_lab_instrumentname_Sortedstatus',ctrl:'DDO_BR_LAB_INSTRUMENTNAME',prop:'SortedStatus'},{av:'AV12BR_LabIDTitleFilterData',fld:'vBR_LABIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV58BR_Lab_SampleIDTitleFilterData',fld:'vBR_LAB_SAMPLEIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Lab_TestIDTitleFilterData',fld:'vBR_LAB_TESTIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Lab_TestCodeTitleFilterData',fld:'vBR_LAB_TESTCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Lab_TestNameTitleFilterData',fld:'vBR_LAB_TESTNAMETITLEFILTERDATA',pic:''},{av:'AV60BR_Lab_TestEngNameTitleFilterData',fld:'vBR_LAB_TESTENGNAMETITLEFILTERDATA',pic:''},{av:'AV62BR_Lab_AgeTitleFilterData',fld:'vBR_LAB_AGETITLEFILTERDATA',pic:''},{av:'AV64BR_Lab_DiagTitleFilterData',fld:'vBR_LAB_DIAGTITLEFILTERDATA',pic:''},{av:'AV24BR_Lab_SpecimenDateTitleFilterData',fld:'vBR_LAB_SPECIMENDATETITLEFILTERDATA',pic:''},{av:'AV66BR_Lab_ReceivingTimeTitleFilterData',fld:'vBR_LAB_RECEIVINGTIMETITLEFILTERDATA',pic:''},{av:'AV68BR_Lab_ReportTimeTitleFilterData',fld:'vBR_LAB_REPORTTIMETITLEFILTERDATA',pic:''},{av:'AV26BR_Lab_SpecimenSourceTitleFilterData',fld:'vBR_LAB_SPECIMENSOURCETITLEFILTERDATA',pic:''},{av:'AV32BR_Lab_ResultQualTitleFilterData',fld:'vBR_LAB_RESULTQUALTITLEFILTERDATA',pic:''},{av:'AV34BR_Lab_ResultNumTitleFilterData',fld:'vBR_LAB_RESULTNUMTITLEFILTERDATA',pic:''},{av:'AV36BR_Lab_ResultUnitTitleFilterData',fld:'vBR_LAB_RESULTUNITTITLEFILTERDATA',pic:''},{av:'AV38BR_Lab_AbnIndTitleFilterData',fld:'vBR_LAB_ABNINDTITLEFILTERDATA',pic:''},{av:'AV40BR_Lab_NormRangeLowTitleFilterData',fld:'vBR_LAB_NORMRANGELOWTITLEFILTERDATA',pic:''},{av:'AV42BR_Lab_NormRangeHighTitleFilterData',fld:'vBR_LAB_NORMRANGEHIGHTITLEFILTERDATA',pic:''},{av:'AV44BR_Lab_TestMethodTitleFilterData',fld:'vBR_LAB_TESTMETHODTITLEFILTERDATA',pic:''},{av:'AV48BR_Lab_InstrumentNameTitleFilterData',fld:'vBR_LAB_INSTRUMENTNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Lab_InstrumentCodeTitleFilterData',fld:'vBR_LAB_INSTRUMENTCODETITLEFILTERDATA',pic:''},{av:'edtBR_LabID_Titleformat',ctrl:'BR_LABID',prop:'Titleformat'},{av:'edtBR_LabID_Title',ctrl:'BR_LABID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Lab_SampleID_Titleformat',ctrl:'BR_LAB_SAMPLEID',prop:'Titleformat'},{av:'edtBR_Lab_SampleID_Title',ctrl:'BR_LAB_SAMPLEID',prop:'Title'},{av:'edtBR_Lab_TestID_Titleformat',ctrl:'BR_LAB_TESTID',prop:'Titleformat'},{av:'edtBR_Lab_TestID_Title',ctrl:'BR_LAB_TESTID',prop:'Title'},{av:'edtBR_Lab_TestCode_Titleformat',ctrl:'BR_LAB_TESTCODE',prop:'Titleformat'},{av:'edtBR_Lab_TestCode_Title',ctrl:'BR_LAB_TESTCODE',prop:'Title'},{av:'edtBR_Lab_TestName_Titleformat',ctrl:'BR_LAB_TESTNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestName_Title',ctrl:'BR_LAB_TESTNAME',prop:'Title'},{av:'edtBR_Lab_TestEngName_Titleformat',ctrl:'BR_LAB_TESTENGNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestEngName_Title',ctrl:'BR_LAB_TESTENGNAME',prop:'Title'},{av:'edtBR_Lab_Age_Titleformat',ctrl:'BR_LAB_AGE',prop:'Titleformat'},{av:'edtBR_Lab_Age_Title',ctrl:'BR_LAB_AGE',prop:'Title'},{av:'edtBR_Lab_Diag_Titleformat',ctrl:'BR_LAB_DIAG',prop:'Titleformat'},{av:'edtBR_Lab_Diag_Title',ctrl:'BR_LAB_DIAG',prop:'Title'},{av:'edtBR_Lab_SpecimenDate_Titleformat',ctrl:'BR_LAB_SPECIMENDATE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenDate_Title',ctrl:'BR_LAB_SPECIMENDATE',prop:'Title'},{av:'edtBR_Lab_ReceivingTime_Titleformat',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReceivingTime_Title',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Title'},{av:'edtBR_Lab_ReportTime_Titleformat',ctrl:'BR_LAB_REPORTTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReportTime_Title',ctrl:'BR_LAB_REPORTTIME',prop:'Title'},{av:'edtBR_Lab_SpecimenSource_Titleformat',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenSource_Title',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Title'},{av:'edtBR_Lab_ResultQual_Titleformat',ctrl:'BR_LAB_RESULTQUAL',prop:'Titleformat'},{av:'edtBR_Lab_ResultQual_Title',ctrl:'BR_LAB_RESULTQUAL',prop:'Title'},{av:'edtBR_Lab_ResultNum_Titleformat',ctrl:'BR_LAB_RESULTNUM',prop:'Titleformat'},{av:'edtBR_Lab_ResultNum_Title',ctrl:'BR_LAB_RESULTNUM',prop:'Title'},{av:'edtBR_Lab_ResultUnit_Titleformat',ctrl:'BR_LAB_RESULTUNIT',prop:'Titleformat'},{av:'edtBR_Lab_ResultUnit_Title',ctrl:'BR_LAB_RESULTUNIT',prop:'Title'},{av:'edtBR_Lab_AbnInd_Titleformat',ctrl:'BR_LAB_ABNIND',prop:'Titleformat'},{av:'edtBR_Lab_AbnInd_Title',ctrl:'BR_LAB_ABNIND',prop:'Title'},{av:'edtBR_Lab_NormRangeLow_Titleformat',ctrl:'BR_LAB_NORMRANGELOW',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeLow_Title',ctrl:'BR_LAB_NORMRANGELOW',prop:'Title'},{av:'edtBR_Lab_NormRangeHigh_Titleformat',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeHigh_Title',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Title'},{av:'edtBR_Lab_TestMethod_Titleformat',ctrl:'BR_LAB_TESTMETHOD',prop:'Titleformat'},{av:'edtBR_Lab_TestMethod_Title',ctrl:'BR_LAB_TESTMETHOD',prop:'Title'},{av:'edtBR_Lab_InstrumentName_Titleformat',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentName_Title',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Title'},{av:'edtBR_Lab_InstrumentCode_Titleformat',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentCode_Title',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_LAB_INSTRUMENTCODE.ONOPTIONCLICKED","{handler:'E353H2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_SAMPLEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Lab_TestIDTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTENGNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV63ddo_BR_Lab_AgeTitleControlIdToReplace',fld:'vDDO_BR_LAB_AGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Lab_DiagTitleControlIdToReplace',fld:'vDDO_BR_LAB_DIAGTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_RECEIVINGTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace',fld:'vDDO_BR_LAB_REPORTTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTQUALTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace',fld:'vDDO_BR_LAB_RESULTUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGELOWTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace',fld:'vDDO_BR_LAB_NORMRANGEHIGHTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTMETHODTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace',fld:'vDDO_BR_LAB_INSTRUMENTCODETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_lab_instrumentcode_Activeeventkey',ctrl:'DDO_BR_LAB_INSTRUMENTCODE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_LAB_INSTRUMENTCODE.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_lab_instrumentcode_Sortedstatus',ctrl:'DDO_BR_LAB_INSTRUMENTCODE',prop:'SortedStatus'},{av:'AV12BR_LabIDTitleFilterData',fld:'vBR_LABIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV58BR_Lab_SampleIDTitleFilterData',fld:'vBR_LAB_SAMPLEIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Lab_TestIDTitleFilterData',fld:'vBR_LAB_TESTIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Lab_TestCodeTitleFilterData',fld:'vBR_LAB_TESTCODETITLEFILTERDATA',pic:''},{av:'AV22BR_Lab_TestNameTitleFilterData',fld:'vBR_LAB_TESTNAMETITLEFILTERDATA',pic:''},{av:'AV60BR_Lab_TestEngNameTitleFilterData',fld:'vBR_LAB_TESTENGNAMETITLEFILTERDATA',pic:''},{av:'AV62BR_Lab_AgeTitleFilterData',fld:'vBR_LAB_AGETITLEFILTERDATA',pic:''},{av:'AV64BR_Lab_DiagTitleFilterData',fld:'vBR_LAB_DIAGTITLEFILTERDATA',pic:''},{av:'AV24BR_Lab_SpecimenDateTitleFilterData',fld:'vBR_LAB_SPECIMENDATETITLEFILTERDATA',pic:''},{av:'AV66BR_Lab_ReceivingTimeTitleFilterData',fld:'vBR_LAB_RECEIVINGTIMETITLEFILTERDATA',pic:''},{av:'AV68BR_Lab_ReportTimeTitleFilterData',fld:'vBR_LAB_REPORTTIMETITLEFILTERDATA',pic:''},{av:'AV26BR_Lab_SpecimenSourceTitleFilterData',fld:'vBR_LAB_SPECIMENSOURCETITLEFILTERDATA',pic:''},{av:'AV32BR_Lab_ResultQualTitleFilterData',fld:'vBR_LAB_RESULTQUALTITLEFILTERDATA',pic:''},{av:'AV34BR_Lab_ResultNumTitleFilterData',fld:'vBR_LAB_RESULTNUMTITLEFILTERDATA',pic:''},{av:'AV36BR_Lab_ResultUnitTitleFilterData',fld:'vBR_LAB_RESULTUNITTITLEFILTERDATA',pic:''},{av:'AV38BR_Lab_AbnIndTitleFilterData',fld:'vBR_LAB_ABNINDTITLEFILTERDATA',pic:''},{av:'AV40BR_Lab_NormRangeLowTitleFilterData',fld:'vBR_LAB_NORMRANGELOWTITLEFILTERDATA',pic:''},{av:'AV42BR_Lab_NormRangeHighTitleFilterData',fld:'vBR_LAB_NORMRANGEHIGHTITLEFILTERDATA',pic:''},{av:'AV44BR_Lab_TestMethodTitleFilterData',fld:'vBR_LAB_TESTMETHODTITLEFILTERDATA',pic:''},{av:'AV48BR_Lab_InstrumentNameTitleFilterData',fld:'vBR_LAB_INSTRUMENTNAMETITLEFILTERDATA',pic:''},{av:'AV50BR_Lab_InstrumentCodeTitleFilterData',fld:'vBR_LAB_INSTRUMENTCODETITLEFILTERDATA',pic:''},{av:'edtBR_LabID_Titleformat',ctrl:'BR_LABID',prop:'Titleformat'},{av:'edtBR_LabID_Title',ctrl:'BR_LABID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Lab_SampleID_Titleformat',ctrl:'BR_LAB_SAMPLEID',prop:'Titleformat'},{av:'edtBR_Lab_SampleID_Title',ctrl:'BR_LAB_SAMPLEID',prop:'Title'},{av:'edtBR_Lab_TestID_Titleformat',ctrl:'BR_LAB_TESTID',prop:'Titleformat'},{av:'edtBR_Lab_TestID_Title',ctrl:'BR_LAB_TESTID',prop:'Title'},{av:'edtBR_Lab_TestCode_Titleformat',ctrl:'BR_LAB_TESTCODE',prop:'Titleformat'},{av:'edtBR_Lab_TestCode_Title',ctrl:'BR_LAB_TESTCODE',prop:'Title'},{av:'edtBR_Lab_TestName_Titleformat',ctrl:'BR_LAB_TESTNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestName_Title',ctrl:'BR_LAB_TESTNAME',prop:'Title'},{av:'edtBR_Lab_TestEngName_Titleformat',ctrl:'BR_LAB_TESTENGNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestEngName_Title',ctrl:'BR_LAB_TESTENGNAME',prop:'Title'},{av:'edtBR_Lab_Age_Titleformat',ctrl:'BR_LAB_AGE',prop:'Titleformat'},{av:'edtBR_Lab_Age_Title',ctrl:'BR_LAB_AGE',prop:'Title'},{av:'edtBR_Lab_Diag_Titleformat',ctrl:'BR_LAB_DIAG',prop:'Titleformat'},{av:'edtBR_Lab_Diag_Title',ctrl:'BR_LAB_DIAG',prop:'Title'},{av:'edtBR_Lab_SpecimenDate_Titleformat',ctrl:'BR_LAB_SPECIMENDATE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenDate_Title',ctrl:'BR_LAB_SPECIMENDATE',prop:'Title'},{av:'edtBR_Lab_ReceivingTime_Titleformat',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReceivingTime_Title',ctrl:'BR_LAB_RECEIVINGTIME',prop:'Title'},{av:'edtBR_Lab_ReportTime_Titleformat',ctrl:'BR_LAB_REPORTTIME',prop:'Titleformat'},{av:'edtBR_Lab_ReportTime_Title',ctrl:'BR_LAB_REPORTTIME',prop:'Title'},{av:'edtBR_Lab_SpecimenSource_Titleformat',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenSource_Title',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Title'},{av:'edtBR_Lab_ResultQual_Titleformat',ctrl:'BR_LAB_RESULTQUAL',prop:'Titleformat'},{av:'edtBR_Lab_ResultQual_Title',ctrl:'BR_LAB_RESULTQUAL',prop:'Title'},{av:'edtBR_Lab_ResultNum_Titleformat',ctrl:'BR_LAB_RESULTNUM',prop:'Titleformat'},{av:'edtBR_Lab_ResultNum_Title',ctrl:'BR_LAB_RESULTNUM',prop:'Title'},{av:'edtBR_Lab_ResultUnit_Titleformat',ctrl:'BR_LAB_RESULTUNIT',prop:'Titleformat'},{av:'edtBR_Lab_ResultUnit_Title',ctrl:'BR_LAB_RESULTUNIT',prop:'Title'},{av:'edtBR_Lab_AbnInd_Titleformat',ctrl:'BR_LAB_ABNIND',prop:'Titleformat'},{av:'edtBR_Lab_AbnInd_Title',ctrl:'BR_LAB_ABNIND',prop:'Title'},{av:'edtBR_Lab_NormRangeLow_Titleformat',ctrl:'BR_LAB_NORMRANGELOW',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeLow_Title',ctrl:'BR_LAB_NORMRANGELOW',prop:'Title'},{av:'edtBR_Lab_NormRangeHigh_Titleformat',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Titleformat'},{av:'edtBR_Lab_NormRangeHigh_Title',ctrl:'BR_LAB_NORMRANGEHIGH',prop:'Title'},{av:'edtBR_Lab_TestMethod_Titleformat',ctrl:'BR_LAB_TESTMETHOD',prop:'Titleformat'},{av:'edtBR_Lab_TestMethod_Title',ctrl:'BR_LAB_TESTMETHOD',prop:'Title'},{av:'edtBR_Lab_InstrumentName_Titleformat',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentName_Title',ctrl:'BR_LAB_INSTRUMENTNAME',prop:'Title'},{av:'edtBR_Lab_InstrumentCode_Titleformat',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Titleformat'},{av:'edtBR_Lab_InstrumentCode_Title',ctrl:'BR_LAB_INSTRUMENTCODE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E383H2',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV57Select',fld:'vSELECT',pic:''},{av:'edtavSelect_Tooltiptext',ctrl:'vSELECT',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E393H2',iparms:[{av:'A101BR_LabID',fld:'BR_LABID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV8InOutBR_LabID',fld:'vINOUTBR_LABID',pic:'ZZZZZZZZZZZZZZZZZZ'}]}");
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
         Ddo_br_labid_Activeeventkey = "";
         Ddo_br_encounterid_Activeeventkey = "";
         Ddo_br_information_patientno_Activeeventkey = "";
         Ddo_br_lab_sampleid_Activeeventkey = "";
         Ddo_br_lab_testid_Activeeventkey = "";
         Ddo_br_lab_testcode_Activeeventkey = "";
         Ddo_br_lab_testname_Activeeventkey = "";
         Ddo_br_lab_testengname_Activeeventkey = "";
         Ddo_br_lab_age_Activeeventkey = "";
         Ddo_br_lab_diag_Activeeventkey = "";
         Ddo_br_lab_specimendate_Activeeventkey = "";
         Ddo_br_lab_receivingtime_Activeeventkey = "";
         Ddo_br_lab_reporttime_Activeeventkey = "";
         Ddo_br_lab_specimensource_Activeeventkey = "";
         Ddo_br_lab_resultqual_Activeeventkey = "";
         Ddo_br_lab_resultnum_Activeeventkey = "";
         Ddo_br_lab_resultunit_Activeeventkey = "";
         Ddo_br_lab_abnind_Activeeventkey = "";
         Ddo_br_lab_normrangelow_Activeeventkey = "";
         Ddo_br_lab_normrangehigh_Activeeventkey = "";
         Ddo_br_lab_testmethod_Activeeventkey = "";
         Ddo_br_lab_instrumentname_Activeeventkey = "";
         Ddo_br_lab_instrumentcode_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV13ddo_BR_LabIDTitleControlIdToReplace = "";
         AV15ddo_BR_EncounterIDTitleControlIdToReplace = "";
         AV17ddo_BR_Information_PatientNoTitleControlIdToReplace = "";
         AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace = "";
         AV19ddo_BR_Lab_TestIDTitleControlIdToReplace = "";
         AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace = "";
         AV23ddo_BR_Lab_TestNameTitleControlIdToReplace = "";
         AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace = "";
         AV63ddo_BR_Lab_AgeTitleControlIdToReplace = "";
         AV65ddo_BR_Lab_DiagTitleControlIdToReplace = "";
         AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace = "";
         AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace = "";
         AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace = "";
         AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace = "";
         AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace = "";
         AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace = "";
         AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace = "";
         AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace = "";
         AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace = "";
         AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace = "";
         AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace = "";
         AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace = "";
         AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace = "";
         GXKey = "";
         AV72Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV52DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV12BR_LabIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV14BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV16BR_Information_PatientNoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV58BR_Lab_SampleIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV18BR_Lab_TestIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_Lab_TestCodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV22BR_Lab_TestNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV60BR_Lab_TestEngNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV62BR_Lab_AgeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV64BR_Lab_DiagTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_Lab_SpecimenDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV66BR_Lab_ReceivingTimeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV68BR_Lab_ReportTimeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV26BR_Lab_SpecimenSourceTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32BR_Lab_ResultQualTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV34BR_Lab_ResultNumTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV36BR_Lab_ResultUnitTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV38BR_Lab_AbnIndTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV40BR_Lab_NormRangeLowTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV42BR_Lab_NormRangeHighTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV44BR_Lab_TestMethodTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV48BR_Lab_InstrumentNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV50BR_Lab_InstrumentCodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_labid_Sortedstatus = "";
         Ddo_br_encounterid_Sortedstatus = "";
         Ddo_br_information_patientno_Sortedstatus = "";
         Ddo_br_lab_sampleid_Sortedstatus = "";
         Ddo_br_lab_testid_Sortedstatus = "";
         Ddo_br_lab_testcode_Sortedstatus = "";
         Ddo_br_lab_testname_Sortedstatus = "";
         Ddo_br_lab_testengname_Sortedstatus = "";
         Ddo_br_lab_age_Sortedstatus = "";
         Ddo_br_lab_diag_Sortedstatus = "";
         Ddo_br_lab_specimendate_Sortedstatus = "";
         Ddo_br_lab_receivingtime_Sortedstatus = "";
         Ddo_br_lab_reporttime_Sortedstatus = "";
         Ddo_br_lab_specimensource_Sortedstatus = "";
         Ddo_br_lab_resultqual_Sortedstatus = "";
         Ddo_br_lab_resultnum_Sortedstatus = "";
         Ddo_br_lab_resultunit_Sortedstatus = "";
         Ddo_br_lab_abnind_Sortedstatus = "";
         Ddo_br_lab_normrangelow_Sortedstatus = "";
         Ddo_br_lab_normrangehigh_Sortedstatus = "";
         Ddo_br_lab_testmethod_Sortedstatus = "";
         Ddo_br_lab_instrumentname_Sortedstatus = "";
         Ddo_br_lab_instrumentcode_Sortedstatus = "";
         GX_FocusControl = "";
         sPrefix = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV57Select = "";
         A36BR_Information_PatientNo = "";
         A224BR_Lab_SampleID = "";
         A103BR_Lab_TestCode = "";
         A104BR_Lab_TestName = "";
         A261BR_Lab_TestEngName = "";
         A263BR_Lab_Diag = "";
         A105BR_Lab_SpecimenDate = (DateTime)(DateTime.MinValue);
         A264BR_Lab_ReceivingTime = (DateTime)(DateTime.MinValue);
         A265BR_Lab_ReportTime = (DateTime)(DateTime.MinValue);
         A106BR_Lab_SpecimenSource = "";
         A109BR_Lab_ResultQual = "";
         A110BR_Lab_ResultNum = "";
         A111BR_Lab_ResultUnit = "";
         A112BR_Lab_AbnInd = "";
         A113BR_Lab_NormRangeLow = "";
         A114BR_Lab_NormRangeHigh = "";
         A115BR_Lab_TestMethod = "";
         A117BR_Lab_InstrumentName = "";
         A118BR_Lab_InstrumentCode = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_labid = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_br_encounterid = new GXUserControl();
         ucDdo_br_information_patientno = new GXUserControl();
         ucDdo_br_lab_sampleid = new GXUserControl();
         ucDdo_br_lab_testid = new GXUserControl();
         ucDdo_br_lab_testcode = new GXUserControl();
         ucDdo_br_lab_testname = new GXUserControl();
         ucDdo_br_lab_testengname = new GXUserControl();
         ucDdo_br_lab_age = new GXUserControl();
         ucDdo_br_lab_diag = new GXUserControl();
         ucDdo_br_lab_specimendate = new GXUserControl();
         ucDdo_br_lab_receivingtime = new GXUserControl();
         ucDdo_br_lab_reporttime = new GXUserControl();
         ucDdo_br_lab_specimensource = new GXUserControl();
         ucDdo_br_lab_resultqual = new GXUserControl();
         ucDdo_br_lab_resultnum = new GXUserControl();
         ucDdo_br_lab_resultunit = new GXUserControl();
         ucDdo_br_lab_abnind = new GXUserControl();
         ucDdo_br_lab_normrangelow = new GXUserControl();
         ucDdo_br_lab_normrangehigh = new GXUserControl();
         ucDdo_br_lab_testmethod = new GXUserControl();
         ucDdo_br_lab_instrumentname = new GXUserControl();
         ucDdo_br_lab_instrumentcode = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV73Select_GXI = "";
         scmdbuf = "";
         H003H2_A85BR_Information_ID = new long[1] ;
         H003H2_n85BR_Information_ID = new bool[] {false} ;
         H003H2_A118BR_Lab_InstrumentCode = new String[] {""} ;
         H003H2_n118BR_Lab_InstrumentCode = new bool[] {false} ;
         H003H2_A117BR_Lab_InstrumentName = new String[] {""} ;
         H003H2_n117BR_Lab_InstrumentName = new bool[] {false} ;
         H003H2_A115BR_Lab_TestMethod = new String[] {""} ;
         H003H2_n115BR_Lab_TestMethod = new bool[] {false} ;
         H003H2_A114BR_Lab_NormRangeHigh = new String[] {""} ;
         H003H2_n114BR_Lab_NormRangeHigh = new bool[] {false} ;
         H003H2_A113BR_Lab_NormRangeLow = new String[] {""} ;
         H003H2_n113BR_Lab_NormRangeLow = new bool[] {false} ;
         H003H2_A112BR_Lab_AbnInd = new String[] {""} ;
         H003H2_n112BR_Lab_AbnInd = new bool[] {false} ;
         H003H2_A111BR_Lab_ResultUnit = new String[] {""} ;
         H003H2_n111BR_Lab_ResultUnit = new bool[] {false} ;
         H003H2_A110BR_Lab_ResultNum = new String[] {""} ;
         H003H2_n110BR_Lab_ResultNum = new bool[] {false} ;
         H003H2_A109BR_Lab_ResultQual = new String[] {""} ;
         H003H2_n109BR_Lab_ResultQual = new bool[] {false} ;
         H003H2_A106BR_Lab_SpecimenSource = new String[] {""} ;
         H003H2_n106BR_Lab_SpecimenSource = new bool[] {false} ;
         H003H2_A265BR_Lab_ReportTime = new DateTime[] {DateTime.MinValue} ;
         H003H2_n265BR_Lab_ReportTime = new bool[] {false} ;
         H003H2_A264BR_Lab_ReceivingTime = new DateTime[] {DateTime.MinValue} ;
         H003H2_n264BR_Lab_ReceivingTime = new bool[] {false} ;
         H003H2_A105BR_Lab_SpecimenDate = new DateTime[] {DateTime.MinValue} ;
         H003H2_n105BR_Lab_SpecimenDate = new bool[] {false} ;
         H003H2_A263BR_Lab_Diag = new String[] {""} ;
         H003H2_n263BR_Lab_Diag = new bool[] {false} ;
         H003H2_A262BR_Lab_Age = new short[1] ;
         H003H2_n262BR_Lab_Age = new bool[] {false} ;
         H003H2_A261BR_Lab_TestEngName = new String[] {""} ;
         H003H2_n261BR_Lab_TestEngName = new bool[] {false} ;
         H003H2_A104BR_Lab_TestName = new String[] {""} ;
         H003H2_n104BR_Lab_TestName = new bool[] {false} ;
         H003H2_A103BR_Lab_TestCode = new String[] {""} ;
         H003H2_n103BR_Lab_TestCode = new bool[] {false} ;
         H003H2_A102BR_Lab_TestID = new long[1] ;
         H003H2_n102BR_Lab_TestID = new bool[] {false} ;
         H003H2_A224BR_Lab_SampleID = new String[] {""} ;
         H003H2_n224BR_Lab_SampleID = new bool[] {false} ;
         H003H2_A36BR_Information_PatientNo = new String[] {""} ;
         H003H2_n36BR_Information_PatientNo = new bool[] {false} ;
         H003H2_A19BR_EncounterID = new long[1] ;
         H003H2_A101BR_LabID = new long[1] ;
         H003H3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_labprompt__default(),
            new Object[][] {
                new Object[] {
               H003H2_A85BR_Information_ID, H003H2_n85BR_Information_ID, H003H2_A118BR_Lab_InstrumentCode, H003H2_n118BR_Lab_InstrumentCode, H003H2_A117BR_Lab_InstrumentName, H003H2_n117BR_Lab_InstrumentName, H003H2_A115BR_Lab_TestMethod, H003H2_n115BR_Lab_TestMethod, H003H2_A114BR_Lab_NormRangeHigh, H003H2_n114BR_Lab_NormRangeHigh,
               H003H2_A113BR_Lab_NormRangeLow, H003H2_n113BR_Lab_NormRangeLow, H003H2_A112BR_Lab_AbnInd, H003H2_n112BR_Lab_AbnInd, H003H2_A111BR_Lab_ResultUnit, H003H2_n111BR_Lab_ResultUnit, H003H2_A110BR_Lab_ResultNum, H003H2_n110BR_Lab_ResultNum, H003H2_A109BR_Lab_ResultQual, H003H2_n109BR_Lab_ResultQual,
               H003H2_A106BR_Lab_SpecimenSource, H003H2_n106BR_Lab_SpecimenSource, H003H2_A265BR_Lab_ReportTime, H003H2_n265BR_Lab_ReportTime, H003H2_A264BR_Lab_ReceivingTime, H003H2_n264BR_Lab_ReceivingTime, H003H2_A105BR_Lab_SpecimenDate, H003H2_n105BR_Lab_SpecimenDate, H003H2_A263BR_Lab_Diag, H003H2_n263BR_Lab_Diag,
               H003H2_A262BR_Lab_Age, H003H2_n262BR_Lab_Age, H003H2_A261BR_Lab_TestEngName, H003H2_n261BR_Lab_TestEngName, H003H2_A104BR_Lab_TestName, H003H2_n104BR_Lab_TestName, H003H2_A103BR_Lab_TestCode, H003H2_n103BR_Lab_TestCode, H003H2_A102BR_Lab_TestID, H003H2_n102BR_Lab_TestID,
               H003H2_A224BR_Lab_SampleID, H003H2_n224BR_Lab_SampleID, H003H2_A36BR_Information_PatientNo, H003H2_n36BR_Information_PatientNo, H003H2_A19BR_EncounterID, H003H2_A101BR_LabID
               }
               , new Object[] {
               H003H3_AGRID_nRecordCount
               }
            }
         );
         AV72Pgmname = "BR_LabPrompt";
         /* GeneXus formulas. */
         AV72Pgmname = "BR_LabPrompt";
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
      private short edtBR_LabID_Titleformat ;
      private short edtBR_EncounterID_Titleformat ;
      private short edtBR_Information_PatientNo_Titleformat ;
      private short edtBR_Lab_SampleID_Titleformat ;
      private short edtBR_Lab_TestID_Titleformat ;
      private short edtBR_Lab_TestCode_Titleformat ;
      private short edtBR_Lab_TestName_Titleformat ;
      private short edtBR_Lab_TestEngName_Titleformat ;
      private short edtBR_Lab_Age_Titleformat ;
      private short edtBR_Lab_Diag_Titleformat ;
      private short edtBR_Lab_SpecimenDate_Titleformat ;
      private short edtBR_Lab_ReceivingTime_Titleformat ;
      private short edtBR_Lab_ReportTime_Titleformat ;
      private short edtBR_Lab_SpecimenSource_Titleformat ;
      private short edtBR_Lab_ResultQual_Titleformat ;
      private short edtBR_Lab_ResultNum_Titleformat ;
      private short edtBR_Lab_ResultUnit_Titleformat ;
      private short edtBR_Lab_AbnInd_Titleformat ;
      private short edtBR_Lab_NormRangeLow_Titleformat ;
      private short edtBR_Lab_NormRangeHigh_Titleformat ;
      private short edtBR_Lab_TestMethod_Titleformat ;
      private short edtBR_Lab_InstrumentName_Titleformat ;
      private short edtBR_Lab_InstrumentCode_Titleformat ;
      private short subGrid_Sortable ;
      private short A262BR_Lab_Age ;
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
      private int edtavDdo_br_labidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_lab_sampleidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_lab_testidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_lab_testcodetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_lab_testnametitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_lab_testengnametitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_lab_agetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_lab_diagtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_lab_specimendatetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_lab_receivingtimetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_lab_reporttimetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_lab_specimensourcetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_lab_resultqualtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_lab_resultnumtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_lab_resultunittitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_lab_abnindtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_lab_normrangelowtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_lab_normrangehightitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_lab_testmethodtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_lab_instrumentnametitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_lab_instrumentcodetitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV53PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavSelect_Enabled ;
      private int edtavSelect_Visible ;
      private long AV8InOutBR_LabID ;
      private long wcpOAV8InOutBR_LabID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV54GridCurrentPage ;
      private long AV56GridRecordCount ;
      private long AV55GridPageSize ;
      private long A101BR_LabID ;
      private long A19BR_EncounterID ;
      private long A102BR_Lab_TestID ;
      private long GRID_nCurrentRecord ;
      private long A85BR_Information_ID ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_labid_Activeeventkey ;
      private String Ddo_br_encounterid_Activeeventkey ;
      private String Ddo_br_information_patientno_Activeeventkey ;
      private String Ddo_br_lab_sampleid_Activeeventkey ;
      private String Ddo_br_lab_testid_Activeeventkey ;
      private String Ddo_br_lab_testcode_Activeeventkey ;
      private String Ddo_br_lab_testname_Activeeventkey ;
      private String Ddo_br_lab_testengname_Activeeventkey ;
      private String Ddo_br_lab_age_Activeeventkey ;
      private String Ddo_br_lab_diag_Activeeventkey ;
      private String Ddo_br_lab_specimendate_Activeeventkey ;
      private String Ddo_br_lab_receivingtime_Activeeventkey ;
      private String Ddo_br_lab_reporttime_Activeeventkey ;
      private String Ddo_br_lab_specimensource_Activeeventkey ;
      private String Ddo_br_lab_resultqual_Activeeventkey ;
      private String Ddo_br_lab_resultnum_Activeeventkey ;
      private String Ddo_br_lab_resultunit_Activeeventkey ;
      private String Ddo_br_lab_abnind_Activeeventkey ;
      private String Ddo_br_lab_normrangelow_Activeeventkey ;
      private String Ddo_br_lab_normrangehigh_Activeeventkey ;
      private String Ddo_br_lab_testmethod_Activeeventkey ;
      private String Ddo_br_lab_instrumentname_Activeeventkey ;
      private String Ddo_br_lab_instrumentcode_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_12_idx="0001" ;
      private String GXKey ;
      private String AV72Pgmname ;
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
      private String Ddo_br_labid_Caption ;
      private String Ddo_br_labid_Tooltip ;
      private String Ddo_br_labid_Cls ;
      private String Ddo_br_labid_Dropdownoptionstype ;
      private String Ddo_br_labid_Titlecontrolidtoreplace ;
      private String Ddo_br_labid_Sortedstatus ;
      private String Ddo_br_labid_Sortasc ;
      private String Ddo_br_labid_Sortdsc ;
      private String Ddo_br_labid_Searchbuttontext ;
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
      private String Ddo_br_lab_sampleid_Caption ;
      private String Ddo_br_lab_sampleid_Tooltip ;
      private String Ddo_br_lab_sampleid_Cls ;
      private String Ddo_br_lab_sampleid_Dropdownoptionstype ;
      private String Ddo_br_lab_sampleid_Titlecontrolidtoreplace ;
      private String Ddo_br_lab_sampleid_Sortedstatus ;
      private String Ddo_br_lab_sampleid_Sortasc ;
      private String Ddo_br_lab_sampleid_Sortdsc ;
      private String Ddo_br_lab_sampleid_Searchbuttontext ;
      private String Ddo_br_lab_testid_Caption ;
      private String Ddo_br_lab_testid_Tooltip ;
      private String Ddo_br_lab_testid_Cls ;
      private String Ddo_br_lab_testid_Dropdownoptionstype ;
      private String Ddo_br_lab_testid_Titlecontrolidtoreplace ;
      private String Ddo_br_lab_testid_Sortedstatus ;
      private String Ddo_br_lab_testid_Sortasc ;
      private String Ddo_br_lab_testid_Sortdsc ;
      private String Ddo_br_lab_testid_Searchbuttontext ;
      private String Ddo_br_lab_testcode_Caption ;
      private String Ddo_br_lab_testcode_Tooltip ;
      private String Ddo_br_lab_testcode_Cls ;
      private String Ddo_br_lab_testcode_Dropdownoptionstype ;
      private String Ddo_br_lab_testcode_Titlecontrolidtoreplace ;
      private String Ddo_br_lab_testcode_Sortedstatus ;
      private String Ddo_br_lab_testcode_Sortasc ;
      private String Ddo_br_lab_testcode_Sortdsc ;
      private String Ddo_br_lab_testcode_Searchbuttontext ;
      private String Ddo_br_lab_testname_Caption ;
      private String Ddo_br_lab_testname_Tooltip ;
      private String Ddo_br_lab_testname_Cls ;
      private String Ddo_br_lab_testname_Dropdownoptionstype ;
      private String Ddo_br_lab_testname_Titlecontrolidtoreplace ;
      private String Ddo_br_lab_testname_Sortedstatus ;
      private String Ddo_br_lab_testname_Sortasc ;
      private String Ddo_br_lab_testname_Sortdsc ;
      private String Ddo_br_lab_testname_Searchbuttontext ;
      private String Ddo_br_lab_testengname_Caption ;
      private String Ddo_br_lab_testengname_Tooltip ;
      private String Ddo_br_lab_testengname_Cls ;
      private String Ddo_br_lab_testengname_Dropdownoptionstype ;
      private String Ddo_br_lab_testengname_Titlecontrolidtoreplace ;
      private String Ddo_br_lab_testengname_Sortedstatus ;
      private String Ddo_br_lab_testengname_Sortasc ;
      private String Ddo_br_lab_testengname_Sortdsc ;
      private String Ddo_br_lab_testengname_Searchbuttontext ;
      private String Ddo_br_lab_age_Caption ;
      private String Ddo_br_lab_age_Tooltip ;
      private String Ddo_br_lab_age_Cls ;
      private String Ddo_br_lab_age_Dropdownoptionstype ;
      private String Ddo_br_lab_age_Titlecontrolidtoreplace ;
      private String Ddo_br_lab_age_Sortedstatus ;
      private String Ddo_br_lab_age_Sortasc ;
      private String Ddo_br_lab_age_Sortdsc ;
      private String Ddo_br_lab_age_Searchbuttontext ;
      private String Ddo_br_lab_diag_Caption ;
      private String Ddo_br_lab_diag_Tooltip ;
      private String Ddo_br_lab_diag_Cls ;
      private String Ddo_br_lab_diag_Dropdownoptionstype ;
      private String Ddo_br_lab_diag_Titlecontrolidtoreplace ;
      private String Ddo_br_lab_diag_Sortedstatus ;
      private String Ddo_br_lab_diag_Sortasc ;
      private String Ddo_br_lab_diag_Sortdsc ;
      private String Ddo_br_lab_diag_Searchbuttontext ;
      private String Ddo_br_lab_specimendate_Caption ;
      private String Ddo_br_lab_specimendate_Tooltip ;
      private String Ddo_br_lab_specimendate_Cls ;
      private String Ddo_br_lab_specimendate_Dropdownoptionstype ;
      private String Ddo_br_lab_specimendate_Titlecontrolidtoreplace ;
      private String Ddo_br_lab_specimendate_Sortedstatus ;
      private String Ddo_br_lab_specimendate_Sortasc ;
      private String Ddo_br_lab_specimendate_Sortdsc ;
      private String Ddo_br_lab_specimendate_Searchbuttontext ;
      private String Ddo_br_lab_receivingtime_Caption ;
      private String Ddo_br_lab_receivingtime_Tooltip ;
      private String Ddo_br_lab_receivingtime_Cls ;
      private String Ddo_br_lab_receivingtime_Dropdownoptionstype ;
      private String Ddo_br_lab_receivingtime_Titlecontrolidtoreplace ;
      private String Ddo_br_lab_receivingtime_Sortedstatus ;
      private String Ddo_br_lab_receivingtime_Sortasc ;
      private String Ddo_br_lab_receivingtime_Sortdsc ;
      private String Ddo_br_lab_receivingtime_Searchbuttontext ;
      private String Ddo_br_lab_reporttime_Caption ;
      private String Ddo_br_lab_reporttime_Tooltip ;
      private String Ddo_br_lab_reporttime_Cls ;
      private String Ddo_br_lab_reporttime_Dropdownoptionstype ;
      private String Ddo_br_lab_reporttime_Titlecontrolidtoreplace ;
      private String Ddo_br_lab_reporttime_Sortedstatus ;
      private String Ddo_br_lab_reporttime_Sortasc ;
      private String Ddo_br_lab_reporttime_Sortdsc ;
      private String Ddo_br_lab_reporttime_Searchbuttontext ;
      private String Ddo_br_lab_specimensource_Caption ;
      private String Ddo_br_lab_specimensource_Tooltip ;
      private String Ddo_br_lab_specimensource_Cls ;
      private String Ddo_br_lab_specimensource_Dropdownoptionstype ;
      private String Ddo_br_lab_specimensource_Titlecontrolidtoreplace ;
      private String Ddo_br_lab_specimensource_Sortedstatus ;
      private String Ddo_br_lab_specimensource_Sortasc ;
      private String Ddo_br_lab_specimensource_Sortdsc ;
      private String Ddo_br_lab_specimensource_Searchbuttontext ;
      private String Ddo_br_lab_resultqual_Caption ;
      private String Ddo_br_lab_resultqual_Tooltip ;
      private String Ddo_br_lab_resultqual_Cls ;
      private String Ddo_br_lab_resultqual_Dropdownoptionstype ;
      private String Ddo_br_lab_resultqual_Titlecontrolidtoreplace ;
      private String Ddo_br_lab_resultqual_Sortedstatus ;
      private String Ddo_br_lab_resultqual_Sortasc ;
      private String Ddo_br_lab_resultqual_Sortdsc ;
      private String Ddo_br_lab_resultqual_Searchbuttontext ;
      private String Ddo_br_lab_resultnum_Caption ;
      private String Ddo_br_lab_resultnum_Tooltip ;
      private String Ddo_br_lab_resultnum_Cls ;
      private String Ddo_br_lab_resultnum_Dropdownoptionstype ;
      private String Ddo_br_lab_resultnum_Titlecontrolidtoreplace ;
      private String Ddo_br_lab_resultnum_Sortedstatus ;
      private String Ddo_br_lab_resultnum_Sortasc ;
      private String Ddo_br_lab_resultnum_Sortdsc ;
      private String Ddo_br_lab_resultnum_Searchbuttontext ;
      private String Ddo_br_lab_resultunit_Caption ;
      private String Ddo_br_lab_resultunit_Tooltip ;
      private String Ddo_br_lab_resultunit_Cls ;
      private String Ddo_br_lab_resultunit_Dropdownoptionstype ;
      private String Ddo_br_lab_resultunit_Titlecontrolidtoreplace ;
      private String Ddo_br_lab_resultunit_Sortedstatus ;
      private String Ddo_br_lab_resultunit_Sortasc ;
      private String Ddo_br_lab_resultunit_Sortdsc ;
      private String Ddo_br_lab_resultunit_Searchbuttontext ;
      private String Ddo_br_lab_abnind_Caption ;
      private String Ddo_br_lab_abnind_Tooltip ;
      private String Ddo_br_lab_abnind_Cls ;
      private String Ddo_br_lab_abnind_Dropdownoptionstype ;
      private String Ddo_br_lab_abnind_Titlecontrolidtoreplace ;
      private String Ddo_br_lab_abnind_Sortedstatus ;
      private String Ddo_br_lab_abnind_Sortasc ;
      private String Ddo_br_lab_abnind_Sortdsc ;
      private String Ddo_br_lab_abnind_Searchbuttontext ;
      private String Ddo_br_lab_normrangelow_Caption ;
      private String Ddo_br_lab_normrangelow_Tooltip ;
      private String Ddo_br_lab_normrangelow_Cls ;
      private String Ddo_br_lab_normrangelow_Dropdownoptionstype ;
      private String Ddo_br_lab_normrangelow_Titlecontrolidtoreplace ;
      private String Ddo_br_lab_normrangelow_Sortedstatus ;
      private String Ddo_br_lab_normrangelow_Sortasc ;
      private String Ddo_br_lab_normrangelow_Sortdsc ;
      private String Ddo_br_lab_normrangelow_Searchbuttontext ;
      private String Ddo_br_lab_normrangehigh_Caption ;
      private String Ddo_br_lab_normrangehigh_Tooltip ;
      private String Ddo_br_lab_normrangehigh_Cls ;
      private String Ddo_br_lab_normrangehigh_Dropdownoptionstype ;
      private String Ddo_br_lab_normrangehigh_Titlecontrolidtoreplace ;
      private String Ddo_br_lab_normrangehigh_Sortedstatus ;
      private String Ddo_br_lab_normrangehigh_Sortasc ;
      private String Ddo_br_lab_normrangehigh_Sortdsc ;
      private String Ddo_br_lab_normrangehigh_Searchbuttontext ;
      private String Ddo_br_lab_testmethod_Caption ;
      private String Ddo_br_lab_testmethod_Tooltip ;
      private String Ddo_br_lab_testmethod_Cls ;
      private String Ddo_br_lab_testmethod_Dropdownoptionstype ;
      private String Ddo_br_lab_testmethod_Titlecontrolidtoreplace ;
      private String Ddo_br_lab_testmethod_Sortedstatus ;
      private String Ddo_br_lab_testmethod_Sortasc ;
      private String Ddo_br_lab_testmethod_Sortdsc ;
      private String Ddo_br_lab_testmethod_Searchbuttontext ;
      private String Ddo_br_lab_instrumentname_Caption ;
      private String Ddo_br_lab_instrumentname_Tooltip ;
      private String Ddo_br_lab_instrumentname_Cls ;
      private String Ddo_br_lab_instrumentname_Dropdownoptionstype ;
      private String Ddo_br_lab_instrumentname_Titlecontrolidtoreplace ;
      private String Ddo_br_lab_instrumentname_Sortedstatus ;
      private String Ddo_br_lab_instrumentname_Sortasc ;
      private String Ddo_br_lab_instrumentname_Sortdsc ;
      private String Ddo_br_lab_instrumentname_Searchbuttontext ;
      private String Ddo_br_lab_instrumentcode_Caption ;
      private String Ddo_br_lab_instrumentcode_Tooltip ;
      private String Ddo_br_lab_instrumentcode_Cls ;
      private String Ddo_br_lab_instrumentcode_Dropdownoptionstype ;
      private String Ddo_br_lab_instrumentcode_Titlecontrolidtoreplace ;
      private String Ddo_br_lab_instrumentcode_Sortedstatus ;
      private String Ddo_br_lab_instrumentcode_Sortasc ;
      private String Ddo_br_lab_instrumentcode_Sortdsc ;
      private String Ddo_br_lab_instrumentcode_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtBR_LabID_Title ;
      private String edtBR_EncounterID_Title ;
      private String edtBR_Information_PatientNo_Title ;
      private String edtBR_Lab_SampleID_Title ;
      private String edtBR_Lab_TestID_Title ;
      private String edtBR_Lab_TestCode_Title ;
      private String edtBR_Lab_TestName_Title ;
      private String edtBR_Lab_TestEngName_Title ;
      private String edtBR_Lab_Age_Title ;
      private String edtBR_Lab_Diag_Title ;
      private String edtBR_Lab_SpecimenDate_Title ;
      private String edtBR_Lab_ReceivingTime_Title ;
      private String edtBR_Lab_ReportTime_Title ;
      private String edtBR_Lab_SpecimenSource_Title ;
      private String edtBR_Lab_ResultQual_Title ;
      private String edtBR_Lab_ResultNum_Title ;
      private String edtBR_Lab_ResultUnit_Title ;
      private String edtBR_Lab_AbnInd_Title ;
      private String edtBR_Lab_NormRangeLow_Title ;
      private String edtBR_Lab_NormRangeHigh_Title ;
      private String edtBR_Lab_TestMethod_Title ;
      private String edtBR_Lab_InstrumentName_Title ;
      private String edtBR_Lab_InstrumentCode_Title ;
      private String subGrid_Header ;
      private String edtavSelect_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_labid_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_br_labidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounterid_Internalname ;
      private String edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_information_patientno_Internalname ;
      private String edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_lab_sampleid_Internalname ;
      private String edtavDdo_br_lab_sampleidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_lab_testid_Internalname ;
      private String edtavDdo_br_lab_testidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_lab_testcode_Internalname ;
      private String edtavDdo_br_lab_testcodetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_lab_testname_Internalname ;
      private String edtavDdo_br_lab_testnametitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_lab_testengname_Internalname ;
      private String edtavDdo_br_lab_testengnametitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_lab_age_Internalname ;
      private String edtavDdo_br_lab_agetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_lab_diag_Internalname ;
      private String edtavDdo_br_lab_diagtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_lab_specimendate_Internalname ;
      private String edtavDdo_br_lab_specimendatetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_lab_receivingtime_Internalname ;
      private String edtavDdo_br_lab_receivingtimetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_lab_reporttime_Internalname ;
      private String edtavDdo_br_lab_reporttimetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_lab_specimensource_Internalname ;
      private String edtavDdo_br_lab_specimensourcetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_lab_resultqual_Internalname ;
      private String edtavDdo_br_lab_resultqualtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_lab_resultnum_Internalname ;
      private String edtavDdo_br_lab_resultnumtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_lab_resultunit_Internalname ;
      private String edtavDdo_br_lab_resultunittitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_lab_abnind_Internalname ;
      private String edtavDdo_br_lab_abnindtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_lab_normrangelow_Internalname ;
      private String edtavDdo_br_lab_normrangelowtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_lab_normrangehigh_Internalname ;
      private String edtavDdo_br_lab_normrangehightitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_lab_testmethod_Internalname ;
      private String edtavDdo_br_lab_testmethodtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_lab_instrumentname_Internalname ;
      private String edtavDdo_br_lab_instrumentnametitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_lab_instrumentcode_Internalname ;
      private String edtavDdo_br_lab_instrumentcodetitlecontrolidtoreplace_Internalname ;
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
      private String edtBR_LabID_Internalname ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_Lab_SampleID_Internalname ;
      private String edtBR_Lab_TestID_Internalname ;
      private String edtBR_Lab_TestCode_Internalname ;
      private String edtBR_Lab_TestName_Internalname ;
      private String edtBR_Lab_TestEngName_Internalname ;
      private String edtBR_Lab_Age_Internalname ;
      private String edtBR_Lab_Diag_Internalname ;
      private String edtBR_Lab_SpecimenDate_Internalname ;
      private String edtBR_Lab_ReceivingTime_Internalname ;
      private String edtBR_Lab_ReportTime_Internalname ;
      private String edtBR_Lab_SpecimenSource_Internalname ;
      private String edtBR_Lab_ResultQual_Internalname ;
      private String edtBR_Lab_ResultNum_Internalname ;
      private String edtBR_Lab_ResultUnit_Internalname ;
      private String edtBR_Lab_AbnInd_Internalname ;
      private String edtBR_Lab_NormRangeLow_Internalname ;
      private String edtBR_Lab_NormRangeHigh_Internalname ;
      private String edtBR_Lab_TestMethod_Internalname ;
      private String edtBR_Lab_InstrumentName_Internalname ;
      private String edtBR_Lab_InstrumentCode_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_12_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavSelect_Jsonclick ;
      private String ROClassString ;
      private String edtBR_LabID_Jsonclick ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String edtBR_Lab_SampleID_Jsonclick ;
      private String edtBR_Lab_TestID_Jsonclick ;
      private String edtBR_Lab_TestCode_Jsonclick ;
      private String edtBR_Lab_TestName_Jsonclick ;
      private String edtBR_Lab_TestEngName_Jsonclick ;
      private String edtBR_Lab_Age_Jsonclick ;
      private String edtBR_Lab_Diag_Jsonclick ;
      private String edtBR_Lab_SpecimenDate_Jsonclick ;
      private String edtBR_Lab_ReceivingTime_Jsonclick ;
      private String edtBR_Lab_ReportTime_Jsonclick ;
      private String edtBR_Lab_SpecimenSource_Jsonclick ;
      private String edtBR_Lab_ResultQual_Jsonclick ;
      private String edtBR_Lab_ResultNum_Jsonclick ;
      private String edtBR_Lab_ResultUnit_Jsonclick ;
      private String edtBR_Lab_AbnInd_Jsonclick ;
      private String edtBR_Lab_NormRangeLow_Jsonclick ;
      private String edtBR_Lab_NormRangeHigh_Jsonclick ;
      private String edtBR_Lab_TestMethod_Jsonclick ;
      private String edtBR_Lab_InstrumentName_Jsonclick ;
      private String edtBR_Lab_InstrumentCode_Jsonclick ;
      private DateTime A105BR_Lab_SpecimenDate ;
      private DateTime A264BR_Lab_ReceivingTime ;
      private DateTime A265BR_Lab_ReportTime ;
      private bool entryPointCalled ;
      private bool AV11OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_br_labid_Includesortasc ;
      private bool Ddo_br_labid_Includesortdsc ;
      private bool Ddo_br_labid_Includefilter ;
      private bool Ddo_br_labid_Includedatalist ;
      private bool Ddo_br_encounterid_Includesortasc ;
      private bool Ddo_br_encounterid_Includesortdsc ;
      private bool Ddo_br_encounterid_Includefilter ;
      private bool Ddo_br_encounterid_Includedatalist ;
      private bool Ddo_br_information_patientno_Includesortasc ;
      private bool Ddo_br_information_patientno_Includesortdsc ;
      private bool Ddo_br_information_patientno_Includefilter ;
      private bool Ddo_br_information_patientno_Includedatalist ;
      private bool Ddo_br_lab_sampleid_Includesortasc ;
      private bool Ddo_br_lab_sampleid_Includesortdsc ;
      private bool Ddo_br_lab_sampleid_Includefilter ;
      private bool Ddo_br_lab_sampleid_Includedatalist ;
      private bool Ddo_br_lab_testid_Includesortasc ;
      private bool Ddo_br_lab_testid_Includesortdsc ;
      private bool Ddo_br_lab_testid_Includefilter ;
      private bool Ddo_br_lab_testid_Includedatalist ;
      private bool Ddo_br_lab_testcode_Includesortasc ;
      private bool Ddo_br_lab_testcode_Includesortdsc ;
      private bool Ddo_br_lab_testcode_Includefilter ;
      private bool Ddo_br_lab_testcode_Includedatalist ;
      private bool Ddo_br_lab_testname_Includesortasc ;
      private bool Ddo_br_lab_testname_Includesortdsc ;
      private bool Ddo_br_lab_testname_Includefilter ;
      private bool Ddo_br_lab_testname_Includedatalist ;
      private bool Ddo_br_lab_testengname_Includesortasc ;
      private bool Ddo_br_lab_testengname_Includesortdsc ;
      private bool Ddo_br_lab_testengname_Includefilter ;
      private bool Ddo_br_lab_testengname_Includedatalist ;
      private bool Ddo_br_lab_age_Includesortasc ;
      private bool Ddo_br_lab_age_Includesortdsc ;
      private bool Ddo_br_lab_age_Includefilter ;
      private bool Ddo_br_lab_age_Includedatalist ;
      private bool Ddo_br_lab_diag_Includesortasc ;
      private bool Ddo_br_lab_diag_Includesortdsc ;
      private bool Ddo_br_lab_diag_Includefilter ;
      private bool Ddo_br_lab_diag_Includedatalist ;
      private bool Ddo_br_lab_specimendate_Includesortasc ;
      private bool Ddo_br_lab_specimendate_Includesortdsc ;
      private bool Ddo_br_lab_specimendate_Includefilter ;
      private bool Ddo_br_lab_specimendate_Includedatalist ;
      private bool Ddo_br_lab_receivingtime_Includesortasc ;
      private bool Ddo_br_lab_receivingtime_Includesortdsc ;
      private bool Ddo_br_lab_receivingtime_Includefilter ;
      private bool Ddo_br_lab_receivingtime_Includedatalist ;
      private bool Ddo_br_lab_reporttime_Includesortasc ;
      private bool Ddo_br_lab_reporttime_Includesortdsc ;
      private bool Ddo_br_lab_reporttime_Includefilter ;
      private bool Ddo_br_lab_reporttime_Includedatalist ;
      private bool Ddo_br_lab_specimensource_Includesortasc ;
      private bool Ddo_br_lab_specimensource_Includesortdsc ;
      private bool Ddo_br_lab_specimensource_Includefilter ;
      private bool Ddo_br_lab_specimensource_Includedatalist ;
      private bool Ddo_br_lab_resultqual_Includesortasc ;
      private bool Ddo_br_lab_resultqual_Includesortdsc ;
      private bool Ddo_br_lab_resultqual_Includefilter ;
      private bool Ddo_br_lab_resultqual_Includedatalist ;
      private bool Ddo_br_lab_resultnum_Includesortasc ;
      private bool Ddo_br_lab_resultnum_Includesortdsc ;
      private bool Ddo_br_lab_resultnum_Includefilter ;
      private bool Ddo_br_lab_resultnum_Includedatalist ;
      private bool Ddo_br_lab_resultunit_Includesortasc ;
      private bool Ddo_br_lab_resultunit_Includesortdsc ;
      private bool Ddo_br_lab_resultunit_Includefilter ;
      private bool Ddo_br_lab_resultunit_Includedatalist ;
      private bool Ddo_br_lab_abnind_Includesortasc ;
      private bool Ddo_br_lab_abnind_Includesortdsc ;
      private bool Ddo_br_lab_abnind_Includefilter ;
      private bool Ddo_br_lab_abnind_Includedatalist ;
      private bool Ddo_br_lab_normrangelow_Includesortasc ;
      private bool Ddo_br_lab_normrangelow_Includesortdsc ;
      private bool Ddo_br_lab_normrangelow_Includefilter ;
      private bool Ddo_br_lab_normrangelow_Includedatalist ;
      private bool Ddo_br_lab_normrangehigh_Includesortasc ;
      private bool Ddo_br_lab_normrangehigh_Includesortdsc ;
      private bool Ddo_br_lab_normrangehigh_Includefilter ;
      private bool Ddo_br_lab_normrangehigh_Includedatalist ;
      private bool Ddo_br_lab_testmethod_Includesortasc ;
      private bool Ddo_br_lab_testmethod_Includesortdsc ;
      private bool Ddo_br_lab_testmethod_Includefilter ;
      private bool Ddo_br_lab_testmethod_Includedatalist ;
      private bool Ddo_br_lab_instrumentname_Includesortasc ;
      private bool Ddo_br_lab_instrumentname_Includesortdsc ;
      private bool Ddo_br_lab_instrumentname_Includefilter ;
      private bool Ddo_br_lab_instrumentname_Includedatalist ;
      private bool Ddo_br_lab_instrumentcode_Includesortasc ;
      private bool Ddo_br_lab_instrumentcode_Includesortdsc ;
      private bool Ddo_br_lab_instrumentcode_Includefilter ;
      private bool Ddo_br_lab_instrumentcode_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_12_Refreshing=false ;
      private bool n36BR_Information_PatientNo ;
      private bool n224BR_Lab_SampleID ;
      private bool n102BR_Lab_TestID ;
      private bool n103BR_Lab_TestCode ;
      private bool n104BR_Lab_TestName ;
      private bool n261BR_Lab_TestEngName ;
      private bool n262BR_Lab_Age ;
      private bool n263BR_Lab_Diag ;
      private bool n105BR_Lab_SpecimenDate ;
      private bool n264BR_Lab_ReceivingTime ;
      private bool n265BR_Lab_ReportTime ;
      private bool n106BR_Lab_SpecimenSource ;
      private bool n109BR_Lab_ResultQual ;
      private bool n110BR_Lab_ResultNum ;
      private bool n111BR_Lab_ResultUnit ;
      private bool n112BR_Lab_AbnInd ;
      private bool n113BR_Lab_NormRangeLow ;
      private bool n114BR_Lab_NormRangeHigh ;
      private bool n115BR_Lab_TestMethod ;
      private bool n117BR_Lab_InstrumentName ;
      private bool n118BR_Lab_InstrumentCode ;
      private bool gxdyncontrolsrefreshing ;
      private bool n85BR_Information_ID ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool gx_refresh_fired ;
      private bool AV57Select_IsBlob ;
      private String AV13ddo_BR_LabIDTitleControlIdToReplace ;
      private String AV15ddo_BR_EncounterIDTitleControlIdToReplace ;
      private String AV17ddo_BR_Information_PatientNoTitleControlIdToReplace ;
      private String AV59ddo_BR_Lab_SampleIDTitleControlIdToReplace ;
      private String AV19ddo_BR_Lab_TestIDTitleControlIdToReplace ;
      private String AV21ddo_BR_Lab_TestCodeTitleControlIdToReplace ;
      private String AV23ddo_BR_Lab_TestNameTitleControlIdToReplace ;
      private String AV61ddo_BR_Lab_TestEngNameTitleControlIdToReplace ;
      private String AV63ddo_BR_Lab_AgeTitleControlIdToReplace ;
      private String AV65ddo_BR_Lab_DiagTitleControlIdToReplace ;
      private String AV25ddo_BR_Lab_SpecimenDateTitleControlIdToReplace ;
      private String AV67ddo_BR_Lab_ReceivingTimeTitleControlIdToReplace ;
      private String AV69ddo_BR_Lab_ReportTimeTitleControlIdToReplace ;
      private String AV27ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace ;
      private String AV33ddo_BR_Lab_ResultQualTitleControlIdToReplace ;
      private String AV35ddo_BR_Lab_ResultNumTitleControlIdToReplace ;
      private String AV37ddo_BR_Lab_ResultUnitTitleControlIdToReplace ;
      private String AV39ddo_BR_Lab_AbnIndTitleControlIdToReplace ;
      private String AV41ddo_BR_Lab_NormRangeLowTitleControlIdToReplace ;
      private String AV43ddo_BR_Lab_NormRangeHighTitleControlIdToReplace ;
      private String AV45ddo_BR_Lab_TestMethodTitleControlIdToReplace ;
      private String AV49ddo_BR_Lab_InstrumentNameTitleControlIdToReplace ;
      private String AV51ddo_BR_Lab_InstrumentCodeTitleControlIdToReplace ;
      private String A36BR_Information_PatientNo ;
      private String A224BR_Lab_SampleID ;
      private String A103BR_Lab_TestCode ;
      private String A104BR_Lab_TestName ;
      private String A261BR_Lab_TestEngName ;
      private String A263BR_Lab_Diag ;
      private String A106BR_Lab_SpecimenSource ;
      private String A109BR_Lab_ResultQual ;
      private String A110BR_Lab_ResultNum ;
      private String A111BR_Lab_ResultUnit ;
      private String A112BR_Lab_AbnInd ;
      private String A113BR_Lab_NormRangeLow ;
      private String A114BR_Lab_NormRangeHigh ;
      private String A115BR_Lab_TestMethod ;
      private String A117BR_Lab_InstrumentName ;
      private String A118BR_Lab_InstrumentCode ;
      private String AV73Select_GXI ;
      private String AV57Select ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_labid ;
      private GXUserControl ucDdo_br_encounterid ;
      private GXUserControl ucDdo_br_information_patientno ;
      private GXUserControl ucDdo_br_lab_sampleid ;
      private GXUserControl ucDdo_br_lab_testid ;
      private GXUserControl ucDdo_br_lab_testcode ;
      private GXUserControl ucDdo_br_lab_testname ;
      private GXUserControl ucDdo_br_lab_testengname ;
      private GXUserControl ucDdo_br_lab_age ;
      private GXUserControl ucDdo_br_lab_diag ;
      private GXUserControl ucDdo_br_lab_specimendate ;
      private GXUserControl ucDdo_br_lab_receivingtime ;
      private GXUserControl ucDdo_br_lab_reporttime ;
      private GXUserControl ucDdo_br_lab_specimensource ;
      private GXUserControl ucDdo_br_lab_resultqual ;
      private GXUserControl ucDdo_br_lab_resultnum ;
      private GXUserControl ucDdo_br_lab_resultunit ;
      private GXUserControl ucDdo_br_lab_abnind ;
      private GXUserControl ucDdo_br_lab_normrangelow ;
      private GXUserControl ucDdo_br_lab_normrangehigh ;
      private GXUserControl ucDdo_br_lab_testmethod ;
      private GXUserControl ucDdo_br_lab_instrumentname ;
      private GXUserControl ucDdo_br_lab_instrumentcode ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private long aP0_InOutBR_LabID ;
      private IDataStoreProvider pr_default ;
      private long[] H003H2_A85BR_Information_ID ;
      private bool[] H003H2_n85BR_Information_ID ;
      private String[] H003H2_A118BR_Lab_InstrumentCode ;
      private bool[] H003H2_n118BR_Lab_InstrumentCode ;
      private String[] H003H2_A117BR_Lab_InstrumentName ;
      private bool[] H003H2_n117BR_Lab_InstrumentName ;
      private String[] H003H2_A115BR_Lab_TestMethod ;
      private bool[] H003H2_n115BR_Lab_TestMethod ;
      private String[] H003H2_A114BR_Lab_NormRangeHigh ;
      private bool[] H003H2_n114BR_Lab_NormRangeHigh ;
      private String[] H003H2_A113BR_Lab_NormRangeLow ;
      private bool[] H003H2_n113BR_Lab_NormRangeLow ;
      private String[] H003H2_A112BR_Lab_AbnInd ;
      private bool[] H003H2_n112BR_Lab_AbnInd ;
      private String[] H003H2_A111BR_Lab_ResultUnit ;
      private bool[] H003H2_n111BR_Lab_ResultUnit ;
      private String[] H003H2_A110BR_Lab_ResultNum ;
      private bool[] H003H2_n110BR_Lab_ResultNum ;
      private String[] H003H2_A109BR_Lab_ResultQual ;
      private bool[] H003H2_n109BR_Lab_ResultQual ;
      private String[] H003H2_A106BR_Lab_SpecimenSource ;
      private bool[] H003H2_n106BR_Lab_SpecimenSource ;
      private DateTime[] H003H2_A265BR_Lab_ReportTime ;
      private bool[] H003H2_n265BR_Lab_ReportTime ;
      private DateTime[] H003H2_A264BR_Lab_ReceivingTime ;
      private bool[] H003H2_n264BR_Lab_ReceivingTime ;
      private DateTime[] H003H2_A105BR_Lab_SpecimenDate ;
      private bool[] H003H2_n105BR_Lab_SpecimenDate ;
      private String[] H003H2_A263BR_Lab_Diag ;
      private bool[] H003H2_n263BR_Lab_Diag ;
      private short[] H003H2_A262BR_Lab_Age ;
      private bool[] H003H2_n262BR_Lab_Age ;
      private String[] H003H2_A261BR_Lab_TestEngName ;
      private bool[] H003H2_n261BR_Lab_TestEngName ;
      private String[] H003H2_A104BR_Lab_TestName ;
      private bool[] H003H2_n104BR_Lab_TestName ;
      private String[] H003H2_A103BR_Lab_TestCode ;
      private bool[] H003H2_n103BR_Lab_TestCode ;
      private long[] H003H2_A102BR_Lab_TestID ;
      private bool[] H003H2_n102BR_Lab_TestID ;
      private String[] H003H2_A224BR_Lab_SampleID ;
      private bool[] H003H2_n224BR_Lab_SampleID ;
      private String[] H003H2_A36BR_Information_PatientNo ;
      private bool[] H003H2_n36BR_Information_PatientNo ;
      private long[] H003H2_A19BR_EncounterID ;
      private long[] H003H2_A101BR_LabID ;
      private long[] H003H3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV12BR_LabIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV14BR_EncounterIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV16BR_Information_PatientNoTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV58BR_Lab_SampleIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV18BR_Lab_TestIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV20BR_Lab_TestCodeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV22BR_Lab_TestNameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV60BR_Lab_TestEngNameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV62BR_Lab_AgeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV64BR_Lab_DiagTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV24BR_Lab_SpecimenDateTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV66BR_Lab_ReceivingTimeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV68BR_Lab_ReportTimeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV26BR_Lab_SpecimenSourceTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV32BR_Lab_ResultQualTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV34BR_Lab_ResultNumTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV36BR_Lab_ResultUnitTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV38BR_Lab_AbnIndTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV40BR_Lab_NormRangeLowTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV42BR_Lab_NormRangeHighTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV44BR_Lab_TestMethodTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV48BR_Lab_InstrumentNameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV50BR_Lab_InstrumentCodeTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV52DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class br_labprompt__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H003H2( IGxContext context ,
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
         sSelectString = " T2.[BR_Information_ID], T1.[BR_Lab_InstrumentCode], T1.[BR_Lab_InstrumentName], T1.[BR_Lab_TestMethod], T1.[BR_Lab_NormRangeHigh], T1.[BR_Lab_NormRangeLow], T1.[BR_Lab_AbnInd], T1.[BR_Lab_ResultUnit], T1.[BR_Lab_ResultNum], T1.[BR_Lab_ResultQual], T1.[BR_Lab_SpecimenSource], T1.[BR_Lab_ReportTime], T1.[BR_Lab_ReceivingTime], T1.[BR_Lab_SpecimenDate], T1.[BR_Lab_Diag], T1.[BR_Lab_Age], T1.[BR_Lab_TestEngName], T1.[BR_Lab_TestName], T1.[BR_Lab_TestCode], T1.[BR_Lab_TestID], T1.[BR_Lab_SampleID], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_LabID]";
         sFromString = " FROM (([BR_Lab] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         sOrderString = "";
         if ( ( AV10OrderedBy == 1 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_LabID]";
         }
         else if ( ( AV10OrderedBy == 1 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_LabID] DESC";
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
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_SampleID]";
         }
         else if ( ( AV10OrderedBy == 4 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_SampleID] DESC";
         }
         else if ( ( AV10OrderedBy == 5 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_TestID]";
         }
         else if ( ( AV10OrderedBy == 5 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_TestID] DESC";
         }
         else if ( ( AV10OrderedBy == 6 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_TestCode]";
         }
         else if ( ( AV10OrderedBy == 6 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_TestCode] DESC";
         }
         else if ( ( AV10OrderedBy == 7 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_TestName]";
         }
         else if ( ( AV10OrderedBy == 7 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_TestName] DESC";
         }
         else if ( ( AV10OrderedBy == 8 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_TestEngName]";
         }
         else if ( ( AV10OrderedBy == 8 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_TestEngName] DESC";
         }
         else if ( ( AV10OrderedBy == 9 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_Age]";
         }
         else if ( ( AV10OrderedBy == 9 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_Age] DESC";
         }
         else if ( ( AV10OrderedBy == 10 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_Diag]";
         }
         else if ( ( AV10OrderedBy == 10 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_Diag] DESC";
         }
         else if ( ( AV10OrderedBy == 11 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_SpecimenDate]";
         }
         else if ( ( AV10OrderedBy == 11 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_SpecimenDate] DESC";
         }
         else if ( ( AV10OrderedBy == 12 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_ReceivingTime]";
         }
         else if ( ( AV10OrderedBy == 12 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_ReceivingTime] DESC";
         }
         else if ( ( AV10OrderedBy == 13 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_ReportTime]";
         }
         else if ( ( AV10OrderedBy == 13 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_ReportTime] DESC";
         }
         else if ( ( AV10OrderedBy == 14 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_SpecimenSource]";
         }
         else if ( ( AV10OrderedBy == 14 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_SpecimenSource] DESC";
         }
         else if ( ( AV10OrderedBy == 15 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_ResultQual]";
         }
         else if ( ( AV10OrderedBy == 15 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_ResultQual] DESC";
         }
         else if ( ( AV10OrderedBy == 16 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_ResultNum]";
         }
         else if ( ( AV10OrderedBy == 16 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_ResultNum] DESC";
         }
         else if ( ( AV10OrderedBy == 17 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_ResultUnit]";
         }
         else if ( ( AV10OrderedBy == 17 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_ResultUnit] DESC";
         }
         else if ( ( AV10OrderedBy == 18 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_AbnInd]";
         }
         else if ( ( AV10OrderedBy == 18 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_AbnInd] DESC";
         }
         else if ( ( AV10OrderedBy == 19 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_NormRangeLow]";
         }
         else if ( ( AV10OrderedBy == 19 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_NormRangeLow] DESC";
         }
         else if ( ( AV10OrderedBy == 20 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_NormRangeHigh]";
         }
         else if ( ( AV10OrderedBy == 20 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_NormRangeHigh] DESC";
         }
         else if ( ( AV10OrderedBy == 21 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_TestMethod]";
         }
         else if ( ( AV10OrderedBy == 21 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_TestMethod] DESC";
         }
         else if ( ( AV10OrderedBy == 22 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_InstrumentName]";
         }
         else if ( ( AV10OrderedBy == 22 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_InstrumentName] DESC";
         }
         else if ( ( AV10OrderedBy == 23 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_InstrumentCode]";
         }
         else if ( ( AV10OrderedBy == 23 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Lab_InstrumentCode] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_LabID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H003H3( IGxContext context ,
                                             short AV10OrderedBy ,
                                             bool AV11OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM (([BR_Lab] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
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
         else if ( ( AV10OrderedBy == 17 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 17 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 18 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 18 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 19 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 19 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 20 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 20 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 21 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 21 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 22 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 22 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 23 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 23 ) && ( AV11OrderedDsc ) )
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
                     return conditional_H003H2(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
               case 1 :
                     return conditional_H003H3(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
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
          Object[] prmH003H2 ;
          prmH003H2 = new Object[] {
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH003H3 ;
          prmH003H3 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H003H2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003H2,11,0,true,false )
             ,new CursorDef("H003H3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003H3,1,0,true,false )
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
                ((DateTime[]) buf[22])[0] = rslt.getGXDateTime(12) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(12);
                ((DateTime[]) buf[24])[0] = rslt.getGXDateTime(13) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(13);
                ((DateTime[]) buf[26])[0] = rslt.getGXDateTime(14) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(14);
                ((String[]) buf[28])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(15);
                ((short[]) buf[30])[0] = rslt.getShort(16) ;
                ((bool[]) buf[31])[0] = rslt.wasNull(16);
                ((String[]) buf[32])[0] = rslt.getVarchar(17) ;
                ((bool[]) buf[33])[0] = rslt.wasNull(17);
                ((String[]) buf[34])[0] = rslt.getVarchar(18) ;
                ((bool[]) buf[35])[0] = rslt.wasNull(18);
                ((String[]) buf[36])[0] = rslt.getVarchar(19) ;
                ((bool[]) buf[37])[0] = rslt.wasNull(19);
                ((long[]) buf[38])[0] = rslt.getLong(20) ;
                ((bool[]) buf[39])[0] = rslt.wasNull(20);
                ((String[]) buf[40])[0] = rslt.getVarchar(21) ;
                ((bool[]) buf[41])[0] = rslt.wasNull(21);
                ((String[]) buf[42])[0] = rslt.getVarchar(22) ;
                ((bool[]) buf[43])[0] = rslt.wasNull(22);
                ((long[]) buf[44])[0] = rslt.getLong(23) ;
                ((long[]) buf[45])[0] = rslt.getLong(24) ;
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
