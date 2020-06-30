/*
               File: BR_VitalWW
        Description:  生命体征
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:45:46.8
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
   public class br_vitalww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_vitalww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_vitalww( IGxContext context )
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
               AV17TFBR_VitalID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV18TFBR_VitalID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV21TFBR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV22TFBR_EncounterID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV25TFBR_Information_PatientNo = GetNextPar( );
               AV26TFBR_Information_PatientNo_Sel = GetNextPar( );
               AV29TFBR_Vital_VitalID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV30TFBR_Vital_VitalID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV33TFBR_Vital_MeasureDate = context.localUtil.ParseDateParm( GetNextPar( ));
               AV34TFBR_Vital_MeasureDate_To = context.localUtil.ParseDateParm( GetNextPar( ));
               AV39TFBR_Vital_Temperature = NumberUtil.Val( GetNextPar( ), ".");
               AV40TFBR_Vital_Temperature_To = NumberUtil.Val( GetNextPar( ), ".");
               AV43TFBR_Vital_Pulse = NumberUtil.Val( GetNextPar( ), ".");
               AV44TFBR_Vital_Pulse_To = NumberUtil.Val( GetNextPar( ), ".");
               AV47TFBR_Vital_Respiration = NumberUtil.Val( GetNextPar( ), ".");
               AV48TFBR_Vital_Respiration_To = NumberUtil.Val( GetNextPar( ), ".");
               AV51TFBR_Vital_Systolic = NumberUtil.Val( GetNextPar( ), ".");
               AV52TFBR_Vital_Systolic_To = NumberUtil.Val( GetNextPar( ), ".");
               AV55TFBR_Vital_Diastolic = NumberUtil.Val( GetNextPar( ), ".");
               AV56TFBR_Vital_Diastolic_To = NumberUtil.Val( GetNextPar( ), ".");
               AV59TFBR_Vital_Height = NumberUtil.Val( GetNextPar( ), ".");
               AV60TFBR_Vital_Height_To = NumberUtil.Val( GetNextPar( ), ".");
               AV63TFBR_Vital_Weight = NumberUtil.Val( GetNextPar( ), ".");
               AV64TFBR_Vital_Weight_To = NumberUtil.Val( GetNextPar( ), ".");
               AV19ddo_BR_VitalIDTitleControlIdToReplace = GetNextPar( );
               AV23ddo_BR_EncounterIDTitleControlIdToReplace = GetNextPar( );
               AV27ddo_BR_Information_PatientNoTitleControlIdToReplace = GetNextPar( );
               AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace = GetNextPar( );
               AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace = GetNextPar( );
               AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace = GetNextPar( );
               AV45ddo_BR_Vital_PulseTitleControlIdToReplace = GetNextPar( );
               AV49ddo_BR_Vital_RespirationTitleControlIdToReplace = GetNextPar( );
               AV53ddo_BR_Vital_SystolicTitleControlIdToReplace = GetNextPar( );
               AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace = GetNextPar( );
               AV61ddo_BR_Vital_HeightTitleControlIdToReplace = GetNextPar( );
               AV65ddo_BR_Vital_WeightTitleControlIdToReplace = GetNextPar( );
               AV107Pgmname = GetNextPar( );
               AV73IsAuthorized_Update = StringUtil.StrToBool( GetNextPar( ));
               AV75IsAuthorized_Delete = StringUtil.StrToBool( GetNextPar( ));
               AV76IsAuthorized_BR_Information_PatientNo = StringUtil.StrToBool( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_VitalID, AV18TFBR_VitalID_To, AV21TFBR_EncounterID, AV22TFBR_EncounterID_To, AV25TFBR_Information_PatientNo, AV26TFBR_Information_PatientNo_Sel, AV29TFBR_Vital_VitalID, AV30TFBR_Vital_VitalID_To, AV33TFBR_Vital_MeasureDate, AV34TFBR_Vital_MeasureDate_To, AV39TFBR_Vital_Temperature, AV40TFBR_Vital_Temperature_To, AV43TFBR_Vital_Pulse, AV44TFBR_Vital_Pulse_To, AV47TFBR_Vital_Respiration, AV48TFBR_Vital_Respiration_To, AV51TFBR_Vital_Systolic, AV52TFBR_Vital_Systolic_To, AV55TFBR_Vital_Diastolic, AV56TFBR_Vital_Diastolic_To, AV59TFBR_Vital_Height, AV60TFBR_Vital_Height_To, AV63TFBR_Vital_Weight, AV64TFBR_Vital_Weight_To, AV19ddo_BR_VitalIDTitleControlIdToReplace, AV23ddo_BR_EncounterIDTitleControlIdToReplace, AV27ddo_BR_Information_PatientNoTitleControlIdToReplace, AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace, AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace, AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace, AV45ddo_BR_Vital_PulseTitleControlIdToReplace, AV49ddo_BR_Vital_RespirationTitleControlIdToReplace, AV53ddo_BR_Vital_SystolicTitleControlIdToReplace, AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace, AV61ddo_BR_Vital_HeightTitleControlIdToReplace, AV65ddo_BR_Vital_WeightTitleControlIdToReplace, AV107Pgmname, AV73IsAuthorized_Update, AV75IsAuthorized_Delete, AV76IsAuthorized_BR_Information_PatientNo) ;
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
         PA5Y2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START5Y2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202279454679", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-zh.js", "?"+context.GetBuildNumber( 127771), false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_vitalww.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_VITALID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFBR_VitalID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_VITALID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFBR_VitalID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21TFBR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_ENCOUNTERID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22TFBR_EncounterID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_INFORMATION_PATIENTNO", AV25TFBR_Information_PatientNo);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_INFORMATION_PATIENTNO_SEL", AV26TFBR_Information_PatientNo_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_VITAL_VITALID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV29TFBR_Vital_VitalID), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_VITAL_VITALID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV30TFBR_Vital_VitalID_To), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_VITAL_MEASUREDATE", context.localUtil.Format(AV33TFBR_Vital_MeasureDate, "9999/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_VITAL_MEASUREDATE_TO", context.localUtil.Format(AV34TFBR_Vital_MeasureDate_To, "9999/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_VITAL_TEMPERATURE", StringUtil.LTrim( StringUtil.NToC( AV39TFBR_Vital_Temperature, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_VITAL_TEMPERATURE_TO", StringUtil.LTrim( StringUtil.NToC( AV40TFBR_Vital_Temperature_To, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_VITAL_PULSE", StringUtil.LTrim( StringUtil.NToC( AV43TFBR_Vital_Pulse, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_VITAL_PULSE_TO", StringUtil.LTrim( StringUtil.NToC( AV44TFBR_Vital_Pulse_To, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_VITAL_RESPIRATION", StringUtil.LTrim( StringUtil.NToC( AV47TFBR_Vital_Respiration, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_VITAL_RESPIRATION_TO", StringUtil.LTrim( StringUtil.NToC( AV48TFBR_Vital_Respiration_To, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_VITAL_SYSTOLIC", StringUtil.LTrim( StringUtil.NToC( AV51TFBR_Vital_Systolic, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_VITAL_SYSTOLIC_TO", StringUtil.LTrim( StringUtil.NToC( AV52TFBR_Vital_Systolic_To, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_VITAL_DIASTOLIC", StringUtil.LTrim( StringUtil.NToC( AV55TFBR_Vital_Diastolic, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_VITAL_DIASTOLIC_TO", StringUtil.LTrim( StringUtil.NToC( AV56TFBR_Vital_Diastolic_To, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_VITAL_HEIGHT", StringUtil.LTrim( StringUtil.NToC( AV59TFBR_Vital_Height, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_VITAL_HEIGHT_TO", StringUtil.LTrim( StringUtil.NToC( AV60TFBR_Vital_Height_To, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_VITAL_WEIGHT", StringUtil.LTrim( StringUtil.NToC( AV63TFBR_Vital_Weight, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_VITAL_WEIGHT_TO", StringUtil.LTrim( StringUtil.NToC( AV64TFBR_Vital_Weight_To, 15, 5, ".", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_31", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_31), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV68GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV70GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV69GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV66DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV66DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_VITALIDTITLEFILTERDATA", AV16BR_VitalIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_VITALIDTITLEFILTERDATA", AV16BR_VitalIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTERIDTITLEFILTERDATA", AV20BR_EncounterIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTERIDTITLEFILTERDATA", AV20BR_EncounterIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_INFORMATION_PATIENTNOTITLEFILTERDATA", AV24BR_Information_PatientNoTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_INFORMATION_PATIENTNOTITLEFILTERDATA", AV24BR_Information_PatientNoTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_VITAL_VITALIDTITLEFILTERDATA", AV28BR_Vital_VitalIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_VITAL_VITALIDTITLEFILTERDATA", AV28BR_Vital_VitalIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_VITAL_MEASUREDATETITLEFILTERDATA", AV32BR_Vital_MeasureDateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_VITAL_MEASUREDATETITLEFILTERDATA", AV32BR_Vital_MeasureDateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_VITAL_TEMPERATURETITLEFILTERDATA", AV38BR_Vital_TemperatureTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_VITAL_TEMPERATURETITLEFILTERDATA", AV38BR_Vital_TemperatureTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_VITAL_PULSETITLEFILTERDATA", AV42BR_Vital_PulseTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_VITAL_PULSETITLEFILTERDATA", AV42BR_Vital_PulseTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_VITAL_RESPIRATIONTITLEFILTERDATA", AV46BR_Vital_RespirationTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_VITAL_RESPIRATIONTITLEFILTERDATA", AV46BR_Vital_RespirationTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_VITAL_SYSTOLICTITLEFILTERDATA", AV50BR_Vital_SystolicTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_VITAL_SYSTOLICTITLEFILTERDATA", AV50BR_Vital_SystolicTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_VITAL_DIASTOLICTITLEFILTERDATA", AV54BR_Vital_DiastolicTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_VITAL_DIASTOLICTITLEFILTERDATA", AV54BR_Vital_DiastolicTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_VITAL_HEIGHTTITLEFILTERDATA", AV58BR_Vital_HeightTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_VITAL_HEIGHTTITLEFILTERDATA", AV58BR_Vital_HeightTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_VITAL_WEIGHTTITLEFILTERDATA", AV62BR_Vital_WeightTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_VITAL_WEIGHTTITLEFILTERDATA", AV62BR_Vital_WeightTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV107Pgmname));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_UPDATE", AV73IsAuthorized_Update);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_DELETE", AV75IsAuthorized_Delete);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_BR_INFORMATION_PATIENTNO", AV76IsAuthorized_BR_Information_PatientNo);
         GxWebStd.gx_hidden_field( context, "gxhash_vISAUTHORIZED_BR_INFORMATION_PATIENTNO", GetSecureSignedToken( "", AV76IsAuthorized_BR_Information_PatientNo, context));
         GxWebStd.gx_hidden_field( context, "BR_INFORMATION_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Caption", StringUtil.RTrim( Ddo_br_vitalid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Tooltip", StringUtil.RTrim( Ddo_br_vitalid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Cls", StringUtil.RTrim( Ddo_br_vitalid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Filteredtext_set", StringUtil.RTrim( Ddo_br_vitalid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Filteredtextto_set", StringUtil.RTrim( Ddo_br_vitalid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_vitalid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_vitalid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Includesortasc", StringUtil.BoolToStr( Ddo_br_vitalid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_vitalid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Sortedstatus", StringUtil.RTrim( Ddo_br_vitalid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Includefilter", StringUtil.BoolToStr( Ddo_br_vitalid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Filtertype", StringUtil.RTrim( Ddo_br_vitalid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Filterisrange", StringUtil.BoolToStr( Ddo_br_vitalid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Includedatalist", StringUtil.BoolToStr( Ddo_br_vitalid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Sortasc", StringUtil.RTrim( Ddo_br_vitalid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Sortdsc", StringUtil.RTrim( Ddo_br_vitalid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Cleanfilter", StringUtil.RTrim( Ddo_br_vitalid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Rangefilterfrom", StringUtil.RTrim( Ddo_br_vitalid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Rangefilterto", StringUtil.RTrim( Ddo_br_vitalid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Searchbuttontext", StringUtil.RTrim( Ddo_br_vitalid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Caption", StringUtil.RTrim( Ddo_br_encounterid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Tooltip", StringUtil.RTrim( Ddo_br_encounterid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Cls", StringUtil.RTrim( Ddo_br_encounterid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtext_set", StringUtil.RTrim( Ddo_br_encounterid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtextto_set", StringUtil.RTrim( Ddo_br_encounterid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounterid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounterid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounterid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounterid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Sortedstatus", StringUtil.RTrim( Ddo_br_encounterid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Includefilter", StringUtil.BoolToStr( Ddo_br_encounterid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filtertype", StringUtil.RTrim( Ddo_br_encounterid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filterisrange", StringUtil.BoolToStr( Ddo_br_encounterid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounterid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Sortasc", StringUtil.RTrim( Ddo_br_encounterid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Sortdsc", StringUtil.RTrim( Ddo_br_encounterid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Cleanfilter", StringUtil.RTrim( Ddo_br_encounterid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Rangefilterfrom", StringUtil.RTrim( Ddo_br_encounterid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Rangefilterto", StringUtil.RTrim( Ddo_br_encounterid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounterid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Caption", StringUtil.RTrim( Ddo_br_information_patientno_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Tooltip", StringUtil.RTrim( Ddo_br_information_patientno_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Cls", StringUtil.RTrim( Ddo_br_information_patientno_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Filteredtext_set", StringUtil.RTrim( Ddo_br_information_patientno_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Selectedvalue_set", StringUtil.RTrim( Ddo_br_information_patientno_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_information_patientno_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_information_patientno_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Includesortasc", StringUtil.BoolToStr( Ddo_br_information_patientno_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Includesortdsc", StringUtil.BoolToStr( Ddo_br_information_patientno_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Sortedstatus", StringUtil.RTrim( Ddo_br_information_patientno_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Includefilter", StringUtil.BoolToStr( Ddo_br_information_patientno_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Filtertype", StringUtil.RTrim( Ddo_br_information_patientno_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Filterisrange", StringUtil.BoolToStr( Ddo_br_information_patientno_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Includedatalist", StringUtil.BoolToStr( Ddo_br_information_patientno_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Datalisttype", StringUtil.RTrim( Ddo_br_information_patientno_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Datalistproc", StringUtil.RTrim( Ddo_br_information_patientno_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_information_patientno_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Sortasc", StringUtil.RTrim( Ddo_br_information_patientno_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Sortdsc", StringUtil.RTrim( Ddo_br_information_patientno_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Loadingdata", StringUtil.RTrim( Ddo_br_information_patientno_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Cleanfilter", StringUtil.RTrim( Ddo_br_information_patientno_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Noresultsfound", StringUtil.RTrim( Ddo_br_information_patientno_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Searchbuttontext", StringUtil.RTrim( Ddo_br_information_patientno_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Caption", StringUtil.RTrim( Ddo_br_vital_vitalid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Tooltip", StringUtil.RTrim( Ddo_br_vital_vitalid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Cls", StringUtil.RTrim( Ddo_br_vital_vitalid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Filteredtext_set", StringUtil.RTrim( Ddo_br_vital_vitalid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Filteredtextto_set", StringUtil.RTrim( Ddo_br_vital_vitalid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_vital_vitalid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_vital_vitalid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Includesortasc", StringUtil.BoolToStr( Ddo_br_vital_vitalid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_vital_vitalid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Sortedstatus", StringUtil.RTrim( Ddo_br_vital_vitalid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Includefilter", StringUtil.BoolToStr( Ddo_br_vital_vitalid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Filtertype", StringUtil.RTrim( Ddo_br_vital_vitalid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Filterisrange", StringUtil.BoolToStr( Ddo_br_vital_vitalid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Includedatalist", StringUtil.BoolToStr( Ddo_br_vital_vitalid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Sortasc", StringUtil.RTrim( Ddo_br_vital_vitalid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Sortdsc", StringUtil.RTrim( Ddo_br_vital_vitalid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Cleanfilter", StringUtil.RTrim( Ddo_br_vital_vitalid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Rangefilterfrom", StringUtil.RTrim( Ddo_br_vital_vitalid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Rangefilterto", StringUtil.RTrim( Ddo_br_vital_vitalid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Searchbuttontext", StringUtil.RTrim( Ddo_br_vital_vitalid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Caption", StringUtil.RTrim( Ddo_br_vital_measuredate_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Tooltip", StringUtil.RTrim( Ddo_br_vital_measuredate_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Cls", StringUtil.RTrim( Ddo_br_vital_measuredate_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Filteredtext_set", StringUtil.RTrim( Ddo_br_vital_measuredate_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Filteredtextto_set", StringUtil.RTrim( Ddo_br_vital_measuredate_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_vital_measuredate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_vital_measuredate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_vital_measuredate_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_vital_measuredate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Sortedstatus", StringUtil.RTrim( Ddo_br_vital_measuredate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Includefilter", StringUtil.BoolToStr( Ddo_br_vital_measuredate_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Filtertype", StringUtil.RTrim( Ddo_br_vital_measuredate_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Filterisrange", StringUtil.BoolToStr( Ddo_br_vital_measuredate_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_vital_measuredate_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Sortasc", StringUtil.RTrim( Ddo_br_vital_measuredate_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Sortdsc", StringUtil.RTrim( Ddo_br_vital_measuredate_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Cleanfilter", StringUtil.RTrim( Ddo_br_vital_measuredate_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Rangefilterfrom", StringUtil.RTrim( Ddo_br_vital_measuredate_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Rangefilterto", StringUtil.RTrim( Ddo_br_vital_measuredate_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_vital_measuredate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Caption", StringUtil.RTrim( Ddo_br_vital_temperature_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Tooltip", StringUtil.RTrim( Ddo_br_vital_temperature_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Cls", StringUtil.RTrim( Ddo_br_vital_temperature_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Filteredtext_set", StringUtil.RTrim( Ddo_br_vital_temperature_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Filteredtextto_set", StringUtil.RTrim( Ddo_br_vital_temperature_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_vital_temperature_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_vital_temperature_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Includesortasc", StringUtil.BoolToStr( Ddo_br_vital_temperature_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_vital_temperature_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Sortedstatus", StringUtil.RTrim( Ddo_br_vital_temperature_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Includefilter", StringUtil.BoolToStr( Ddo_br_vital_temperature_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Filtertype", StringUtil.RTrim( Ddo_br_vital_temperature_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Filterisrange", StringUtil.BoolToStr( Ddo_br_vital_temperature_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Includedatalist", StringUtil.BoolToStr( Ddo_br_vital_temperature_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Sortasc", StringUtil.RTrim( Ddo_br_vital_temperature_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Sortdsc", StringUtil.RTrim( Ddo_br_vital_temperature_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Cleanfilter", StringUtil.RTrim( Ddo_br_vital_temperature_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Rangefilterfrom", StringUtil.RTrim( Ddo_br_vital_temperature_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Rangefilterto", StringUtil.RTrim( Ddo_br_vital_temperature_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Searchbuttontext", StringUtil.RTrim( Ddo_br_vital_temperature_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Caption", StringUtil.RTrim( Ddo_br_vital_pulse_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Tooltip", StringUtil.RTrim( Ddo_br_vital_pulse_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Cls", StringUtil.RTrim( Ddo_br_vital_pulse_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Filteredtext_set", StringUtil.RTrim( Ddo_br_vital_pulse_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Filteredtextto_set", StringUtil.RTrim( Ddo_br_vital_pulse_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_vital_pulse_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_vital_pulse_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Includesortasc", StringUtil.BoolToStr( Ddo_br_vital_pulse_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_vital_pulse_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Sortedstatus", StringUtil.RTrim( Ddo_br_vital_pulse_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Includefilter", StringUtil.BoolToStr( Ddo_br_vital_pulse_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Filtertype", StringUtil.RTrim( Ddo_br_vital_pulse_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Filterisrange", StringUtil.BoolToStr( Ddo_br_vital_pulse_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Includedatalist", StringUtil.BoolToStr( Ddo_br_vital_pulse_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Sortasc", StringUtil.RTrim( Ddo_br_vital_pulse_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Sortdsc", StringUtil.RTrim( Ddo_br_vital_pulse_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Cleanfilter", StringUtil.RTrim( Ddo_br_vital_pulse_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Rangefilterfrom", StringUtil.RTrim( Ddo_br_vital_pulse_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Rangefilterto", StringUtil.RTrim( Ddo_br_vital_pulse_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Searchbuttontext", StringUtil.RTrim( Ddo_br_vital_pulse_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Caption", StringUtil.RTrim( Ddo_br_vital_respiration_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Tooltip", StringUtil.RTrim( Ddo_br_vital_respiration_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Cls", StringUtil.RTrim( Ddo_br_vital_respiration_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Filteredtext_set", StringUtil.RTrim( Ddo_br_vital_respiration_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Filteredtextto_set", StringUtil.RTrim( Ddo_br_vital_respiration_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_vital_respiration_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_vital_respiration_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Includesortasc", StringUtil.BoolToStr( Ddo_br_vital_respiration_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Includesortdsc", StringUtil.BoolToStr( Ddo_br_vital_respiration_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Sortedstatus", StringUtil.RTrim( Ddo_br_vital_respiration_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Includefilter", StringUtil.BoolToStr( Ddo_br_vital_respiration_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Filtertype", StringUtil.RTrim( Ddo_br_vital_respiration_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Filterisrange", StringUtil.BoolToStr( Ddo_br_vital_respiration_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Includedatalist", StringUtil.BoolToStr( Ddo_br_vital_respiration_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Sortasc", StringUtil.RTrim( Ddo_br_vital_respiration_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Sortdsc", StringUtil.RTrim( Ddo_br_vital_respiration_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Cleanfilter", StringUtil.RTrim( Ddo_br_vital_respiration_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Rangefilterfrom", StringUtil.RTrim( Ddo_br_vital_respiration_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Rangefilterto", StringUtil.RTrim( Ddo_br_vital_respiration_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Searchbuttontext", StringUtil.RTrim( Ddo_br_vital_respiration_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Caption", StringUtil.RTrim( Ddo_br_vital_systolic_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Tooltip", StringUtil.RTrim( Ddo_br_vital_systolic_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Cls", StringUtil.RTrim( Ddo_br_vital_systolic_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Filteredtext_set", StringUtil.RTrim( Ddo_br_vital_systolic_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Filteredtextto_set", StringUtil.RTrim( Ddo_br_vital_systolic_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_vital_systolic_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_vital_systolic_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Includesortasc", StringUtil.BoolToStr( Ddo_br_vital_systolic_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Includesortdsc", StringUtil.BoolToStr( Ddo_br_vital_systolic_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Sortedstatus", StringUtil.RTrim( Ddo_br_vital_systolic_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Includefilter", StringUtil.BoolToStr( Ddo_br_vital_systolic_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Filtertype", StringUtil.RTrim( Ddo_br_vital_systolic_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Filterisrange", StringUtil.BoolToStr( Ddo_br_vital_systolic_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Includedatalist", StringUtil.BoolToStr( Ddo_br_vital_systolic_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Sortasc", StringUtil.RTrim( Ddo_br_vital_systolic_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Sortdsc", StringUtil.RTrim( Ddo_br_vital_systolic_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Cleanfilter", StringUtil.RTrim( Ddo_br_vital_systolic_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Rangefilterfrom", StringUtil.RTrim( Ddo_br_vital_systolic_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Rangefilterto", StringUtil.RTrim( Ddo_br_vital_systolic_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Searchbuttontext", StringUtil.RTrim( Ddo_br_vital_systolic_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Caption", StringUtil.RTrim( Ddo_br_vital_diastolic_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Tooltip", StringUtil.RTrim( Ddo_br_vital_diastolic_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Cls", StringUtil.RTrim( Ddo_br_vital_diastolic_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Filteredtext_set", StringUtil.RTrim( Ddo_br_vital_diastolic_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Filteredtextto_set", StringUtil.RTrim( Ddo_br_vital_diastolic_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_vital_diastolic_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_vital_diastolic_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Includesortasc", StringUtil.BoolToStr( Ddo_br_vital_diastolic_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Includesortdsc", StringUtil.BoolToStr( Ddo_br_vital_diastolic_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Sortedstatus", StringUtil.RTrim( Ddo_br_vital_diastolic_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Includefilter", StringUtil.BoolToStr( Ddo_br_vital_diastolic_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Filtertype", StringUtil.RTrim( Ddo_br_vital_diastolic_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Filterisrange", StringUtil.BoolToStr( Ddo_br_vital_diastolic_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Includedatalist", StringUtil.BoolToStr( Ddo_br_vital_diastolic_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Sortasc", StringUtil.RTrim( Ddo_br_vital_diastolic_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Sortdsc", StringUtil.RTrim( Ddo_br_vital_diastolic_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Cleanfilter", StringUtil.RTrim( Ddo_br_vital_diastolic_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Rangefilterfrom", StringUtil.RTrim( Ddo_br_vital_diastolic_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Rangefilterto", StringUtil.RTrim( Ddo_br_vital_diastolic_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Searchbuttontext", StringUtil.RTrim( Ddo_br_vital_diastolic_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Caption", StringUtil.RTrim( Ddo_br_vital_height_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Tooltip", StringUtil.RTrim( Ddo_br_vital_height_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Cls", StringUtil.RTrim( Ddo_br_vital_height_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Filteredtext_set", StringUtil.RTrim( Ddo_br_vital_height_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Filteredtextto_set", StringUtil.RTrim( Ddo_br_vital_height_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_vital_height_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_vital_height_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Includesortasc", StringUtil.BoolToStr( Ddo_br_vital_height_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Includesortdsc", StringUtil.BoolToStr( Ddo_br_vital_height_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Sortedstatus", StringUtil.RTrim( Ddo_br_vital_height_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Includefilter", StringUtil.BoolToStr( Ddo_br_vital_height_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Filtertype", StringUtil.RTrim( Ddo_br_vital_height_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Filterisrange", StringUtil.BoolToStr( Ddo_br_vital_height_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Includedatalist", StringUtil.BoolToStr( Ddo_br_vital_height_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Sortasc", StringUtil.RTrim( Ddo_br_vital_height_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Sortdsc", StringUtil.RTrim( Ddo_br_vital_height_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Cleanfilter", StringUtil.RTrim( Ddo_br_vital_height_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Rangefilterfrom", StringUtil.RTrim( Ddo_br_vital_height_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Rangefilterto", StringUtil.RTrim( Ddo_br_vital_height_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Searchbuttontext", StringUtil.RTrim( Ddo_br_vital_height_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Caption", StringUtil.RTrim( Ddo_br_vital_weight_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Tooltip", StringUtil.RTrim( Ddo_br_vital_weight_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Cls", StringUtil.RTrim( Ddo_br_vital_weight_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Filteredtext_set", StringUtil.RTrim( Ddo_br_vital_weight_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Filteredtextto_set", StringUtil.RTrim( Ddo_br_vital_weight_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_vital_weight_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_vital_weight_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Includesortasc", StringUtil.BoolToStr( Ddo_br_vital_weight_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Includesortdsc", StringUtil.BoolToStr( Ddo_br_vital_weight_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Sortedstatus", StringUtil.RTrim( Ddo_br_vital_weight_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Includefilter", StringUtil.BoolToStr( Ddo_br_vital_weight_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Filtertype", StringUtil.RTrim( Ddo_br_vital_weight_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Filterisrange", StringUtil.BoolToStr( Ddo_br_vital_weight_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Includedatalist", StringUtil.BoolToStr( Ddo_br_vital_weight_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Sortasc", StringUtil.RTrim( Ddo_br_vital_weight_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Sortdsc", StringUtil.RTrim( Ddo_br_vital_weight_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Cleanfilter", StringUtil.RTrim( Ddo_br_vital_weight_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Rangefilterfrom", StringUtil.RTrim( Ddo_br_vital_weight_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Rangefilterto", StringUtil.RTrim( Ddo_br_vital_weight_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Searchbuttontext", StringUtil.RTrim( Ddo_br_vital_weight_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Activeeventkey", StringUtil.RTrim( Ddo_br_vitalid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Filteredtext_get", StringUtil.RTrim( Ddo_br_vitalid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_vitalid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtext_get", StringUtil.RTrim( Ddo_br_encounterid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_encounterid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey", StringUtil.RTrim( Ddo_br_information_patientno_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Filteredtext_get", StringUtil.RTrim( Ddo_br_information_patientno_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Selectedvalue_get", StringUtil.RTrim( Ddo_br_information_patientno_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_vitalid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Filteredtext_get", StringUtil.RTrim( Ddo_br_vital_vitalid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_vital_vitalid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_measuredate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Filteredtext_get", StringUtil.RTrim( Ddo_br_vital_measuredate_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_vital_measuredate_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_temperature_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Filteredtext_get", StringUtil.RTrim( Ddo_br_vital_temperature_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_vital_temperature_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_pulse_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Filteredtext_get", StringUtil.RTrim( Ddo_br_vital_pulse_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_vital_pulse_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_respiration_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Filteredtext_get", StringUtil.RTrim( Ddo_br_vital_respiration_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Filteredtextto_get", StringUtil.RTrim( Ddo_br_vital_respiration_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_systolic_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Filteredtext_get", StringUtil.RTrim( Ddo_br_vital_systolic_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Filteredtextto_get", StringUtil.RTrim( Ddo_br_vital_systolic_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_diastolic_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Filteredtext_get", StringUtil.RTrim( Ddo_br_vital_diastolic_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Filteredtextto_get", StringUtil.RTrim( Ddo_br_vital_diastolic_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_height_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Filteredtext_get", StringUtil.RTrim( Ddo_br_vital_height_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Filteredtextto_get", StringUtil.RTrim( Ddo_br_vital_height_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_weight_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Filteredtext_get", StringUtil.RTrim( Ddo_br_vital_weight_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Filteredtextto_get", StringUtil.RTrim( Ddo_br_vital_weight_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Activeeventkey", StringUtil.RTrim( Ddo_br_vitalid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Filteredtext_get", StringUtil.RTrim( Ddo_br_vitalid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_vitalid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtext_get", StringUtil.RTrim( Ddo_br_encounterid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_encounterid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey", StringUtil.RTrim( Ddo_br_information_patientno_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Filteredtext_get", StringUtil.RTrim( Ddo_br_information_patientno_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Selectedvalue_get", StringUtil.RTrim( Ddo_br_information_patientno_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_vitalid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Filteredtext_get", StringUtil.RTrim( Ddo_br_vital_vitalid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_vital_vitalid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_measuredate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Filteredtext_get", StringUtil.RTrim( Ddo_br_vital_measuredate_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_vital_measuredate_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_temperature_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Filteredtext_get", StringUtil.RTrim( Ddo_br_vital_temperature_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_vital_temperature_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_pulse_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Filteredtext_get", StringUtil.RTrim( Ddo_br_vital_pulse_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_vital_pulse_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_respiration_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Filteredtext_get", StringUtil.RTrim( Ddo_br_vital_respiration_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Filteredtextto_get", StringUtil.RTrim( Ddo_br_vital_respiration_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_systolic_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Filteredtext_get", StringUtil.RTrim( Ddo_br_vital_systolic_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Filteredtextto_get", StringUtil.RTrim( Ddo_br_vital_systolic_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_diastolic_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Filteredtext_get", StringUtil.RTrim( Ddo_br_vital_diastolic_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Filteredtextto_get", StringUtil.RTrim( Ddo_br_vital_diastolic_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_height_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Filteredtext_get", StringUtil.RTrim( Ddo_br_vital_height_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Filteredtextto_get", StringUtil.RTrim( Ddo_br_vital_height_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_weight_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Filteredtext_get", StringUtil.RTrim( Ddo_br_vital_weight_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Filteredtextto_get", StringUtil.RTrim( Ddo_br_vital_weight_Filteredtextto_get));
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
            WE5Y2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT5Y2( ) ;
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
         return formatLink("br_vitalww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "BR_VitalWW" ;
      }

      public override String GetPgmdesc( )
      {
         return " 生命体征" ;
      }

      protected void WB5Y0( )
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
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(31), 2, 0)+","+"null"+");", "插入", bttBtninsert_Jsonclick, 5, "插入", "", StyleString, ClassString, bttBtninsert_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_VitalWW.htm");
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
               if ( edtBR_VitalID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_VitalID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_VitalID_Title) ;
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
               if ( edtBR_Vital_VitalID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Vital_VitalID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Vital_VitalID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Vital_MeasureDate_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Vital_MeasureDate_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Vital_MeasureDate_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Vital_Temperature_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Vital_Temperature_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Vital_Temperature_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Vital_Pulse_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Vital_Pulse_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Vital_Pulse_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Vital_Respiration_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Vital_Respiration_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Vital_Respiration_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Vital_Systolic_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Vital_Systolic_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Vital_Systolic_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Vital_Diastolic_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Vital_Diastolic_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Vital_Diastolic_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Vital_Height_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Vital_Height_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Vital_Height_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Vital_Weight_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Vital_Weight_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Vital_Weight_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV71Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV72Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV74Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A150BR_VitalID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_VitalID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_VitalID_Titleformat), 4, 0, ".", "")));
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
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtBR_Information_PatientNo_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A151BR_Vital_VitalID), 10, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Vital_VitalID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Vital_VitalID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A152BR_Vital_MeasureDate, "9999/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Vital_MeasureDate_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Vital_MeasureDate_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A153BR_Vital_Temperature, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Vital_Temperature_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Vital_Temperature_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A154BR_Vital_Pulse, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Vital_Pulse_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Vital_Pulse_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A155BR_Vital_Respiration, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Vital_Respiration_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Vital_Respiration_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A156BR_Vital_Systolic, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Vital_Systolic_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Vital_Systolic_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A157BR_Vital_Diastolic, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Vital_Diastolic_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Vital_Diastolic_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A158BR_Vital_Height, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Vital_Height_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Vital_Height_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A159BR_Vital_Weight, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Vital_Weight_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Vital_Weight_Titleformat), 4, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV68GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV70GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV69GridPageSize);
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
            ucDdo_br_vitalid.SetProperty("Caption", Ddo_br_vitalid_Caption);
            ucDdo_br_vitalid.SetProperty("Tooltip", Ddo_br_vitalid_Tooltip);
            ucDdo_br_vitalid.SetProperty("Cls", Ddo_br_vitalid_Cls);
            ucDdo_br_vitalid.SetProperty("DropDownOptionsType", Ddo_br_vitalid_Dropdownoptionstype);
            ucDdo_br_vitalid.SetProperty("IncludeSortASC", Ddo_br_vitalid_Includesortasc);
            ucDdo_br_vitalid.SetProperty("IncludeSortDSC", Ddo_br_vitalid_Includesortdsc);
            ucDdo_br_vitalid.SetProperty("IncludeFilter", Ddo_br_vitalid_Includefilter);
            ucDdo_br_vitalid.SetProperty("FilterType", Ddo_br_vitalid_Filtertype);
            ucDdo_br_vitalid.SetProperty("FilterIsRange", Ddo_br_vitalid_Filterisrange);
            ucDdo_br_vitalid.SetProperty("IncludeDataList", Ddo_br_vitalid_Includedatalist);
            ucDdo_br_vitalid.SetProperty("SortASC", Ddo_br_vitalid_Sortasc);
            ucDdo_br_vitalid.SetProperty("SortDSC", Ddo_br_vitalid_Sortdsc);
            ucDdo_br_vitalid.SetProperty("CleanFilter", Ddo_br_vitalid_Cleanfilter);
            ucDdo_br_vitalid.SetProperty("RangeFilterFrom", Ddo_br_vitalid_Rangefilterfrom);
            ucDdo_br_vitalid.SetProperty("RangeFilterTo", Ddo_br_vitalid_Rangefilterto);
            ucDdo_br_vitalid.SetProperty("SearchButtonText", Ddo_br_vitalid_Searchbuttontext);
            ucDdo_br_vitalid.SetProperty("DropDownOptionsTitleSettingsIcons", AV66DDO_TitleSettingsIcons);
            ucDdo_br_vitalid.SetProperty("DropDownOptionsData", AV16BR_VitalIDTitleFilterData);
            ucDdo_br_vitalid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_vitalid_Internalname, "DDO_BR_VITALIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_vitalidtitlecontrolidtoreplace_Internalname, AV19ddo_BR_VitalIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", 0, edtavDdo_br_vitalidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_VitalWW.htm");
            /* User Defined Control */
            ucDdo_br_encounterid.SetProperty("Caption", Ddo_br_encounterid_Caption);
            ucDdo_br_encounterid.SetProperty("Tooltip", Ddo_br_encounterid_Tooltip);
            ucDdo_br_encounterid.SetProperty("Cls", Ddo_br_encounterid_Cls);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsType", Ddo_br_encounterid_Dropdownoptionstype);
            ucDdo_br_encounterid.SetProperty("IncludeSortASC", Ddo_br_encounterid_Includesortasc);
            ucDdo_br_encounterid.SetProperty("IncludeSortDSC", Ddo_br_encounterid_Includesortdsc);
            ucDdo_br_encounterid.SetProperty("IncludeFilter", Ddo_br_encounterid_Includefilter);
            ucDdo_br_encounterid.SetProperty("FilterType", Ddo_br_encounterid_Filtertype);
            ucDdo_br_encounterid.SetProperty("FilterIsRange", Ddo_br_encounterid_Filterisrange);
            ucDdo_br_encounterid.SetProperty("IncludeDataList", Ddo_br_encounterid_Includedatalist);
            ucDdo_br_encounterid.SetProperty("SortASC", Ddo_br_encounterid_Sortasc);
            ucDdo_br_encounterid.SetProperty("SortDSC", Ddo_br_encounterid_Sortdsc);
            ucDdo_br_encounterid.SetProperty("CleanFilter", Ddo_br_encounterid_Cleanfilter);
            ucDdo_br_encounterid.SetProperty("RangeFilterFrom", Ddo_br_encounterid_Rangefilterfrom);
            ucDdo_br_encounterid.SetProperty("RangeFilterTo", Ddo_br_encounterid_Rangefilterto);
            ucDdo_br_encounterid.SetProperty("SearchButtonText", Ddo_br_encounterid_Searchbuttontext);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsTitleSettingsIcons", AV66DDO_TitleSettingsIcons);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsData", AV20BR_EncounterIDTitleFilterData);
            ucDdo_br_encounterid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounterid_Internalname, "DDO_BR_ENCOUNTERIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, AV23ddo_BR_EncounterIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", 0, edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_VitalWW.htm");
            /* User Defined Control */
            ucDdo_br_information_patientno.SetProperty("Caption", Ddo_br_information_patientno_Caption);
            ucDdo_br_information_patientno.SetProperty("Tooltip", Ddo_br_information_patientno_Tooltip);
            ucDdo_br_information_patientno.SetProperty("Cls", Ddo_br_information_patientno_Cls);
            ucDdo_br_information_patientno.SetProperty("DropDownOptionsType", Ddo_br_information_patientno_Dropdownoptionstype);
            ucDdo_br_information_patientno.SetProperty("IncludeSortASC", Ddo_br_information_patientno_Includesortasc);
            ucDdo_br_information_patientno.SetProperty("IncludeSortDSC", Ddo_br_information_patientno_Includesortdsc);
            ucDdo_br_information_patientno.SetProperty("IncludeFilter", Ddo_br_information_patientno_Includefilter);
            ucDdo_br_information_patientno.SetProperty("FilterType", Ddo_br_information_patientno_Filtertype);
            ucDdo_br_information_patientno.SetProperty("FilterIsRange", Ddo_br_information_patientno_Filterisrange);
            ucDdo_br_information_patientno.SetProperty("IncludeDataList", Ddo_br_information_patientno_Includedatalist);
            ucDdo_br_information_patientno.SetProperty("DataListType", Ddo_br_information_patientno_Datalisttype);
            ucDdo_br_information_patientno.SetProperty("DataListProc", Ddo_br_information_patientno_Datalistproc);
            ucDdo_br_information_patientno.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_information_patientno_Datalistupdateminimumcharacters);
            ucDdo_br_information_patientno.SetProperty("SortASC", Ddo_br_information_patientno_Sortasc);
            ucDdo_br_information_patientno.SetProperty("SortDSC", Ddo_br_information_patientno_Sortdsc);
            ucDdo_br_information_patientno.SetProperty("LoadingData", Ddo_br_information_patientno_Loadingdata);
            ucDdo_br_information_patientno.SetProperty("CleanFilter", Ddo_br_information_patientno_Cleanfilter);
            ucDdo_br_information_patientno.SetProperty("NoResultsFound", Ddo_br_information_patientno_Noresultsfound);
            ucDdo_br_information_patientno.SetProperty("SearchButtonText", Ddo_br_information_patientno_Searchbuttontext);
            ucDdo_br_information_patientno.SetProperty("DropDownOptionsTitleSettingsIcons", AV66DDO_TitleSettingsIcons);
            ucDdo_br_information_patientno.SetProperty("DropDownOptionsData", AV24BR_Information_PatientNoTitleFilterData);
            ucDdo_br_information_patientno.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_information_patientno_Internalname, "DDO_BR_INFORMATION_PATIENTNOContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname, AV27ddo_BR_Information_PatientNoTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", 0, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_VitalWW.htm");
            /* User Defined Control */
            ucDdo_br_vital_vitalid.SetProperty("Caption", Ddo_br_vital_vitalid_Caption);
            ucDdo_br_vital_vitalid.SetProperty("Tooltip", Ddo_br_vital_vitalid_Tooltip);
            ucDdo_br_vital_vitalid.SetProperty("Cls", Ddo_br_vital_vitalid_Cls);
            ucDdo_br_vital_vitalid.SetProperty("DropDownOptionsType", Ddo_br_vital_vitalid_Dropdownoptionstype);
            ucDdo_br_vital_vitalid.SetProperty("IncludeSortASC", Ddo_br_vital_vitalid_Includesortasc);
            ucDdo_br_vital_vitalid.SetProperty("IncludeSortDSC", Ddo_br_vital_vitalid_Includesortdsc);
            ucDdo_br_vital_vitalid.SetProperty("IncludeFilter", Ddo_br_vital_vitalid_Includefilter);
            ucDdo_br_vital_vitalid.SetProperty("FilterType", Ddo_br_vital_vitalid_Filtertype);
            ucDdo_br_vital_vitalid.SetProperty("FilterIsRange", Ddo_br_vital_vitalid_Filterisrange);
            ucDdo_br_vital_vitalid.SetProperty("IncludeDataList", Ddo_br_vital_vitalid_Includedatalist);
            ucDdo_br_vital_vitalid.SetProperty("SortASC", Ddo_br_vital_vitalid_Sortasc);
            ucDdo_br_vital_vitalid.SetProperty("SortDSC", Ddo_br_vital_vitalid_Sortdsc);
            ucDdo_br_vital_vitalid.SetProperty("CleanFilter", Ddo_br_vital_vitalid_Cleanfilter);
            ucDdo_br_vital_vitalid.SetProperty("RangeFilterFrom", Ddo_br_vital_vitalid_Rangefilterfrom);
            ucDdo_br_vital_vitalid.SetProperty("RangeFilterTo", Ddo_br_vital_vitalid_Rangefilterto);
            ucDdo_br_vital_vitalid.SetProperty("SearchButtonText", Ddo_br_vital_vitalid_Searchbuttontext);
            ucDdo_br_vital_vitalid.SetProperty("DropDownOptionsTitleSettingsIcons", AV66DDO_TitleSettingsIcons);
            ucDdo_br_vital_vitalid.SetProperty("DropDownOptionsData", AV28BR_Vital_VitalIDTitleFilterData);
            ucDdo_br_vital_vitalid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_vital_vitalid_Internalname, "DDO_BR_VITAL_VITALIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_vital_vitalidtitlecontrolidtoreplace_Internalname, AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,61);\"", 0, edtavDdo_br_vital_vitalidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_VitalWW.htm");
            /* User Defined Control */
            ucDdo_br_vital_measuredate.SetProperty("Caption", Ddo_br_vital_measuredate_Caption);
            ucDdo_br_vital_measuredate.SetProperty("Tooltip", Ddo_br_vital_measuredate_Tooltip);
            ucDdo_br_vital_measuredate.SetProperty("Cls", Ddo_br_vital_measuredate_Cls);
            ucDdo_br_vital_measuredate.SetProperty("DropDownOptionsType", Ddo_br_vital_measuredate_Dropdownoptionstype);
            ucDdo_br_vital_measuredate.SetProperty("IncludeSortASC", Ddo_br_vital_measuredate_Includesortasc);
            ucDdo_br_vital_measuredate.SetProperty("IncludeSortDSC", Ddo_br_vital_measuredate_Includesortdsc);
            ucDdo_br_vital_measuredate.SetProperty("IncludeFilter", Ddo_br_vital_measuredate_Includefilter);
            ucDdo_br_vital_measuredate.SetProperty("FilterType", Ddo_br_vital_measuredate_Filtertype);
            ucDdo_br_vital_measuredate.SetProperty("FilterIsRange", Ddo_br_vital_measuredate_Filterisrange);
            ucDdo_br_vital_measuredate.SetProperty("IncludeDataList", Ddo_br_vital_measuredate_Includedatalist);
            ucDdo_br_vital_measuredate.SetProperty("SortASC", Ddo_br_vital_measuredate_Sortasc);
            ucDdo_br_vital_measuredate.SetProperty("SortDSC", Ddo_br_vital_measuredate_Sortdsc);
            ucDdo_br_vital_measuredate.SetProperty("CleanFilter", Ddo_br_vital_measuredate_Cleanfilter);
            ucDdo_br_vital_measuredate.SetProperty("RangeFilterFrom", Ddo_br_vital_measuredate_Rangefilterfrom);
            ucDdo_br_vital_measuredate.SetProperty("RangeFilterTo", Ddo_br_vital_measuredate_Rangefilterto);
            ucDdo_br_vital_measuredate.SetProperty("SearchButtonText", Ddo_br_vital_measuredate_Searchbuttontext);
            ucDdo_br_vital_measuredate.SetProperty("DropDownOptionsTitleSettingsIcons", AV66DDO_TitleSettingsIcons);
            ucDdo_br_vital_measuredate.SetProperty("DropDownOptionsData", AV32BR_Vital_MeasureDateTitleFilterData);
            ucDdo_br_vital_measuredate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_vital_measuredate_Internalname, "DDO_BR_VITAL_MEASUREDATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Internalname, AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", 0, edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_VitalWW.htm");
            /* User Defined Control */
            ucDdo_br_vital_temperature.SetProperty("Caption", Ddo_br_vital_temperature_Caption);
            ucDdo_br_vital_temperature.SetProperty("Tooltip", Ddo_br_vital_temperature_Tooltip);
            ucDdo_br_vital_temperature.SetProperty("Cls", Ddo_br_vital_temperature_Cls);
            ucDdo_br_vital_temperature.SetProperty("DropDownOptionsType", Ddo_br_vital_temperature_Dropdownoptionstype);
            ucDdo_br_vital_temperature.SetProperty("IncludeSortASC", Ddo_br_vital_temperature_Includesortasc);
            ucDdo_br_vital_temperature.SetProperty("IncludeSortDSC", Ddo_br_vital_temperature_Includesortdsc);
            ucDdo_br_vital_temperature.SetProperty("IncludeFilter", Ddo_br_vital_temperature_Includefilter);
            ucDdo_br_vital_temperature.SetProperty("FilterType", Ddo_br_vital_temperature_Filtertype);
            ucDdo_br_vital_temperature.SetProperty("FilterIsRange", Ddo_br_vital_temperature_Filterisrange);
            ucDdo_br_vital_temperature.SetProperty("IncludeDataList", Ddo_br_vital_temperature_Includedatalist);
            ucDdo_br_vital_temperature.SetProperty("SortASC", Ddo_br_vital_temperature_Sortasc);
            ucDdo_br_vital_temperature.SetProperty("SortDSC", Ddo_br_vital_temperature_Sortdsc);
            ucDdo_br_vital_temperature.SetProperty("CleanFilter", Ddo_br_vital_temperature_Cleanfilter);
            ucDdo_br_vital_temperature.SetProperty("RangeFilterFrom", Ddo_br_vital_temperature_Rangefilterfrom);
            ucDdo_br_vital_temperature.SetProperty("RangeFilterTo", Ddo_br_vital_temperature_Rangefilterto);
            ucDdo_br_vital_temperature.SetProperty("SearchButtonText", Ddo_br_vital_temperature_Searchbuttontext);
            ucDdo_br_vital_temperature.SetProperty("DropDownOptionsTitleSettingsIcons", AV66DDO_TitleSettingsIcons);
            ucDdo_br_vital_temperature.SetProperty("DropDownOptionsData", AV38BR_Vital_TemperatureTitleFilterData);
            ucDdo_br_vital_temperature.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_vital_temperature_Internalname, "DDO_BR_VITAL_TEMPERATUREContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Internalname, AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,65);\"", 0, edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_VitalWW.htm");
            /* User Defined Control */
            ucDdo_br_vital_pulse.SetProperty("Caption", Ddo_br_vital_pulse_Caption);
            ucDdo_br_vital_pulse.SetProperty("Tooltip", Ddo_br_vital_pulse_Tooltip);
            ucDdo_br_vital_pulse.SetProperty("Cls", Ddo_br_vital_pulse_Cls);
            ucDdo_br_vital_pulse.SetProperty("DropDownOptionsType", Ddo_br_vital_pulse_Dropdownoptionstype);
            ucDdo_br_vital_pulse.SetProperty("IncludeSortASC", Ddo_br_vital_pulse_Includesortasc);
            ucDdo_br_vital_pulse.SetProperty("IncludeSortDSC", Ddo_br_vital_pulse_Includesortdsc);
            ucDdo_br_vital_pulse.SetProperty("IncludeFilter", Ddo_br_vital_pulse_Includefilter);
            ucDdo_br_vital_pulse.SetProperty("FilterType", Ddo_br_vital_pulse_Filtertype);
            ucDdo_br_vital_pulse.SetProperty("FilterIsRange", Ddo_br_vital_pulse_Filterisrange);
            ucDdo_br_vital_pulse.SetProperty("IncludeDataList", Ddo_br_vital_pulse_Includedatalist);
            ucDdo_br_vital_pulse.SetProperty("SortASC", Ddo_br_vital_pulse_Sortasc);
            ucDdo_br_vital_pulse.SetProperty("SortDSC", Ddo_br_vital_pulse_Sortdsc);
            ucDdo_br_vital_pulse.SetProperty("CleanFilter", Ddo_br_vital_pulse_Cleanfilter);
            ucDdo_br_vital_pulse.SetProperty("RangeFilterFrom", Ddo_br_vital_pulse_Rangefilterfrom);
            ucDdo_br_vital_pulse.SetProperty("RangeFilterTo", Ddo_br_vital_pulse_Rangefilterto);
            ucDdo_br_vital_pulse.SetProperty("SearchButtonText", Ddo_br_vital_pulse_Searchbuttontext);
            ucDdo_br_vital_pulse.SetProperty("DropDownOptionsTitleSettingsIcons", AV66DDO_TitleSettingsIcons);
            ucDdo_br_vital_pulse.SetProperty("DropDownOptionsData", AV42BR_Vital_PulseTitleFilterData);
            ucDdo_br_vital_pulse.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_vital_pulse_Internalname, "DDO_BR_VITAL_PULSEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_vital_pulsetitlecontrolidtoreplace_Internalname, AV45ddo_BR_Vital_PulseTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,67);\"", 0, edtavDdo_br_vital_pulsetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_VitalWW.htm");
            /* User Defined Control */
            ucDdo_br_vital_respiration.SetProperty("Caption", Ddo_br_vital_respiration_Caption);
            ucDdo_br_vital_respiration.SetProperty("Tooltip", Ddo_br_vital_respiration_Tooltip);
            ucDdo_br_vital_respiration.SetProperty("Cls", Ddo_br_vital_respiration_Cls);
            ucDdo_br_vital_respiration.SetProperty("DropDownOptionsType", Ddo_br_vital_respiration_Dropdownoptionstype);
            ucDdo_br_vital_respiration.SetProperty("IncludeSortASC", Ddo_br_vital_respiration_Includesortasc);
            ucDdo_br_vital_respiration.SetProperty("IncludeSortDSC", Ddo_br_vital_respiration_Includesortdsc);
            ucDdo_br_vital_respiration.SetProperty("IncludeFilter", Ddo_br_vital_respiration_Includefilter);
            ucDdo_br_vital_respiration.SetProperty("FilterType", Ddo_br_vital_respiration_Filtertype);
            ucDdo_br_vital_respiration.SetProperty("FilterIsRange", Ddo_br_vital_respiration_Filterisrange);
            ucDdo_br_vital_respiration.SetProperty("IncludeDataList", Ddo_br_vital_respiration_Includedatalist);
            ucDdo_br_vital_respiration.SetProperty("SortASC", Ddo_br_vital_respiration_Sortasc);
            ucDdo_br_vital_respiration.SetProperty("SortDSC", Ddo_br_vital_respiration_Sortdsc);
            ucDdo_br_vital_respiration.SetProperty("CleanFilter", Ddo_br_vital_respiration_Cleanfilter);
            ucDdo_br_vital_respiration.SetProperty("RangeFilterFrom", Ddo_br_vital_respiration_Rangefilterfrom);
            ucDdo_br_vital_respiration.SetProperty("RangeFilterTo", Ddo_br_vital_respiration_Rangefilterto);
            ucDdo_br_vital_respiration.SetProperty("SearchButtonText", Ddo_br_vital_respiration_Searchbuttontext);
            ucDdo_br_vital_respiration.SetProperty("DropDownOptionsTitleSettingsIcons", AV66DDO_TitleSettingsIcons);
            ucDdo_br_vital_respiration.SetProperty("DropDownOptionsData", AV46BR_Vital_RespirationTitleFilterData);
            ucDdo_br_vital_respiration.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_vital_respiration_Internalname, "DDO_BR_VITAL_RESPIRATIONContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_vital_respirationtitlecontrolidtoreplace_Internalname, AV49ddo_BR_Vital_RespirationTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,69);\"", 0, edtavDdo_br_vital_respirationtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_VitalWW.htm");
            /* User Defined Control */
            ucDdo_br_vital_systolic.SetProperty("Caption", Ddo_br_vital_systolic_Caption);
            ucDdo_br_vital_systolic.SetProperty("Tooltip", Ddo_br_vital_systolic_Tooltip);
            ucDdo_br_vital_systolic.SetProperty("Cls", Ddo_br_vital_systolic_Cls);
            ucDdo_br_vital_systolic.SetProperty("DropDownOptionsType", Ddo_br_vital_systolic_Dropdownoptionstype);
            ucDdo_br_vital_systolic.SetProperty("IncludeSortASC", Ddo_br_vital_systolic_Includesortasc);
            ucDdo_br_vital_systolic.SetProperty("IncludeSortDSC", Ddo_br_vital_systolic_Includesortdsc);
            ucDdo_br_vital_systolic.SetProperty("IncludeFilter", Ddo_br_vital_systolic_Includefilter);
            ucDdo_br_vital_systolic.SetProperty("FilterType", Ddo_br_vital_systolic_Filtertype);
            ucDdo_br_vital_systolic.SetProperty("FilterIsRange", Ddo_br_vital_systolic_Filterisrange);
            ucDdo_br_vital_systolic.SetProperty("IncludeDataList", Ddo_br_vital_systolic_Includedatalist);
            ucDdo_br_vital_systolic.SetProperty("SortASC", Ddo_br_vital_systolic_Sortasc);
            ucDdo_br_vital_systolic.SetProperty("SortDSC", Ddo_br_vital_systolic_Sortdsc);
            ucDdo_br_vital_systolic.SetProperty("CleanFilter", Ddo_br_vital_systolic_Cleanfilter);
            ucDdo_br_vital_systolic.SetProperty("RangeFilterFrom", Ddo_br_vital_systolic_Rangefilterfrom);
            ucDdo_br_vital_systolic.SetProperty("RangeFilterTo", Ddo_br_vital_systolic_Rangefilterto);
            ucDdo_br_vital_systolic.SetProperty("SearchButtonText", Ddo_br_vital_systolic_Searchbuttontext);
            ucDdo_br_vital_systolic.SetProperty("DropDownOptionsTitleSettingsIcons", AV66DDO_TitleSettingsIcons);
            ucDdo_br_vital_systolic.SetProperty("DropDownOptionsData", AV50BR_Vital_SystolicTitleFilterData);
            ucDdo_br_vital_systolic.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_vital_systolic_Internalname, "DDO_BR_VITAL_SYSTOLICContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_vital_systolictitlecontrolidtoreplace_Internalname, AV53ddo_BR_Vital_SystolicTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,71);\"", 0, edtavDdo_br_vital_systolictitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_VitalWW.htm");
            /* User Defined Control */
            ucDdo_br_vital_diastolic.SetProperty("Caption", Ddo_br_vital_diastolic_Caption);
            ucDdo_br_vital_diastolic.SetProperty("Tooltip", Ddo_br_vital_diastolic_Tooltip);
            ucDdo_br_vital_diastolic.SetProperty("Cls", Ddo_br_vital_diastolic_Cls);
            ucDdo_br_vital_diastolic.SetProperty("DropDownOptionsType", Ddo_br_vital_diastolic_Dropdownoptionstype);
            ucDdo_br_vital_diastolic.SetProperty("IncludeSortASC", Ddo_br_vital_diastolic_Includesortasc);
            ucDdo_br_vital_diastolic.SetProperty("IncludeSortDSC", Ddo_br_vital_diastolic_Includesortdsc);
            ucDdo_br_vital_diastolic.SetProperty("IncludeFilter", Ddo_br_vital_diastolic_Includefilter);
            ucDdo_br_vital_diastolic.SetProperty("FilterType", Ddo_br_vital_diastolic_Filtertype);
            ucDdo_br_vital_diastolic.SetProperty("FilterIsRange", Ddo_br_vital_diastolic_Filterisrange);
            ucDdo_br_vital_diastolic.SetProperty("IncludeDataList", Ddo_br_vital_diastolic_Includedatalist);
            ucDdo_br_vital_diastolic.SetProperty("SortASC", Ddo_br_vital_diastolic_Sortasc);
            ucDdo_br_vital_diastolic.SetProperty("SortDSC", Ddo_br_vital_diastolic_Sortdsc);
            ucDdo_br_vital_diastolic.SetProperty("CleanFilter", Ddo_br_vital_diastolic_Cleanfilter);
            ucDdo_br_vital_diastolic.SetProperty("RangeFilterFrom", Ddo_br_vital_diastolic_Rangefilterfrom);
            ucDdo_br_vital_diastolic.SetProperty("RangeFilterTo", Ddo_br_vital_diastolic_Rangefilterto);
            ucDdo_br_vital_diastolic.SetProperty("SearchButtonText", Ddo_br_vital_diastolic_Searchbuttontext);
            ucDdo_br_vital_diastolic.SetProperty("DropDownOptionsTitleSettingsIcons", AV66DDO_TitleSettingsIcons);
            ucDdo_br_vital_diastolic.SetProperty("DropDownOptionsData", AV54BR_Vital_DiastolicTitleFilterData);
            ucDdo_br_vital_diastolic.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_vital_diastolic_Internalname, "DDO_BR_VITAL_DIASTOLICContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_vital_diastolictitlecontrolidtoreplace_Internalname, AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,73);\"", 0, edtavDdo_br_vital_diastolictitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_VitalWW.htm");
            /* User Defined Control */
            ucDdo_br_vital_height.SetProperty("Caption", Ddo_br_vital_height_Caption);
            ucDdo_br_vital_height.SetProperty("Tooltip", Ddo_br_vital_height_Tooltip);
            ucDdo_br_vital_height.SetProperty("Cls", Ddo_br_vital_height_Cls);
            ucDdo_br_vital_height.SetProperty("DropDownOptionsType", Ddo_br_vital_height_Dropdownoptionstype);
            ucDdo_br_vital_height.SetProperty("IncludeSortASC", Ddo_br_vital_height_Includesortasc);
            ucDdo_br_vital_height.SetProperty("IncludeSortDSC", Ddo_br_vital_height_Includesortdsc);
            ucDdo_br_vital_height.SetProperty("IncludeFilter", Ddo_br_vital_height_Includefilter);
            ucDdo_br_vital_height.SetProperty("FilterType", Ddo_br_vital_height_Filtertype);
            ucDdo_br_vital_height.SetProperty("FilterIsRange", Ddo_br_vital_height_Filterisrange);
            ucDdo_br_vital_height.SetProperty("IncludeDataList", Ddo_br_vital_height_Includedatalist);
            ucDdo_br_vital_height.SetProperty("SortASC", Ddo_br_vital_height_Sortasc);
            ucDdo_br_vital_height.SetProperty("SortDSC", Ddo_br_vital_height_Sortdsc);
            ucDdo_br_vital_height.SetProperty("CleanFilter", Ddo_br_vital_height_Cleanfilter);
            ucDdo_br_vital_height.SetProperty("RangeFilterFrom", Ddo_br_vital_height_Rangefilterfrom);
            ucDdo_br_vital_height.SetProperty("RangeFilterTo", Ddo_br_vital_height_Rangefilterto);
            ucDdo_br_vital_height.SetProperty("SearchButtonText", Ddo_br_vital_height_Searchbuttontext);
            ucDdo_br_vital_height.SetProperty("DropDownOptionsTitleSettingsIcons", AV66DDO_TitleSettingsIcons);
            ucDdo_br_vital_height.SetProperty("DropDownOptionsData", AV58BR_Vital_HeightTitleFilterData);
            ucDdo_br_vital_height.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_vital_height_Internalname, "DDO_BR_VITAL_HEIGHTContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 75,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_vital_heighttitlecontrolidtoreplace_Internalname, AV61ddo_BR_Vital_HeightTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,75);\"", 0, edtavDdo_br_vital_heighttitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_VitalWW.htm");
            /* User Defined Control */
            ucDdo_br_vital_weight.SetProperty("Caption", Ddo_br_vital_weight_Caption);
            ucDdo_br_vital_weight.SetProperty("Tooltip", Ddo_br_vital_weight_Tooltip);
            ucDdo_br_vital_weight.SetProperty("Cls", Ddo_br_vital_weight_Cls);
            ucDdo_br_vital_weight.SetProperty("DropDownOptionsType", Ddo_br_vital_weight_Dropdownoptionstype);
            ucDdo_br_vital_weight.SetProperty("IncludeSortASC", Ddo_br_vital_weight_Includesortasc);
            ucDdo_br_vital_weight.SetProperty("IncludeSortDSC", Ddo_br_vital_weight_Includesortdsc);
            ucDdo_br_vital_weight.SetProperty("IncludeFilter", Ddo_br_vital_weight_Includefilter);
            ucDdo_br_vital_weight.SetProperty("FilterType", Ddo_br_vital_weight_Filtertype);
            ucDdo_br_vital_weight.SetProperty("FilterIsRange", Ddo_br_vital_weight_Filterisrange);
            ucDdo_br_vital_weight.SetProperty("IncludeDataList", Ddo_br_vital_weight_Includedatalist);
            ucDdo_br_vital_weight.SetProperty("SortASC", Ddo_br_vital_weight_Sortasc);
            ucDdo_br_vital_weight.SetProperty("SortDSC", Ddo_br_vital_weight_Sortdsc);
            ucDdo_br_vital_weight.SetProperty("CleanFilter", Ddo_br_vital_weight_Cleanfilter);
            ucDdo_br_vital_weight.SetProperty("RangeFilterFrom", Ddo_br_vital_weight_Rangefilterfrom);
            ucDdo_br_vital_weight.SetProperty("RangeFilterTo", Ddo_br_vital_weight_Rangefilterto);
            ucDdo_br_vital_weight.SetProperty("SearchButtonText", Ddo_br_vital_weight_Searchbuttontext);
            ucDdo_br_vital_weight.SetProperty("DropDownOptionsTitleSettingsIcons", AV66DDO_TitleSettingsIcons);
            ucDdo_br_vital_weight.SetProperty("DropDownOptionsData", AV62BR_Vital_WeightTitleFilterData);
            ucDdo_br_vital_weight.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_vital_weight_Internalname, "DDO_BR_VITAL_WEIGHTContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_vital_weighttitlecontrolidtoreplace_Internalname, AV65ddo_BR_Vital_WeightTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,77);\"", 0, edtavDdo_br_vital_weighttitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_VitalWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 79,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,79);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,80);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_VitalWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_vitalid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFBR_VitalID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV17TFBR_VitalID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,81);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_vitalid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_vitalid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 82,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_vitalid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFBR_VitalID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV18TFBR_VitalID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,82);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_vitalid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_vitalid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_encounterid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21TFBR_EncounterID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV21TFBR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,83);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_encounterid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_encounterid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 84,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_encounterid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22TFBR_EncounterID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV22TFBR_EncounterID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,84);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_encounterid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_encounterid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 85,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_information_patientno_Internalname, AV25TFBR_Information_PatientNo, StringUtil.RTrim( context.localUtil.Format( AV25TFBR_Information_PatientNo, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,85);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_information_patientno_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_information_patientno_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_VitalWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_information_patientno_sel_Internalname, AV26TFBR_Information_PatientNo_Sel, StringUtil.RTrim( context.localUtil.Format( AV26TFBR_Information_PatientNo_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,86);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_information_patientno_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_information_patientno_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_VitalWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 87,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_vital_vitalid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV29TFBR_Vital_VitalID), 10, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV29TFBR_Vital_VitalID), "ZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,87);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_vital_vitalid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_vital_vitalid_Visible, 1, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 88,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_vital_vitalid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV30TFBR_Vital_VitalID_To), 10, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV30TFBR_Vital_VitalID_To), "ZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,88);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_vital_vitalid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_vital_vitalid_to_Visible, 1, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 89,'',false,'" + sGXsfl_31_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfbr_vital_measuredate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfbr_vital_measuredate_Internalname, context.localUtil.Format(AV33TFBR_Vital_MeasureDate, "9999/99/99"), context.localUtil.Format( AV33TFBR_Vital_MeasureDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,89);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_vital_measuredate_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_vital_measuredate_Visible, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalWW.htm");
            GxWebStd.gx_bitmap( context, edtavTfbr_vital_measuredate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfbr_vital_measuredate_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_VitalWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 90,'',false,'" + sGXsfl_31_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfbr_vital_measuredate_to_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfbr_vital_measuredate_to_Internalname, context.localUtil.Format(AV34TFBR_Vital_MeasureDate_To, "9999/99/99"), context.localUtil.Format( AV34TFBR_Vital_MeasureDate_To, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,90);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_vital_measuredate_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_vital_measuredate_to_Visible, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalWW.htm");
            GxWebStd.gx_bitmap( context, edtavTfbr_vital_measuredate_to_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfbr_vital_measuredate_to_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_VitalWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divDdo_br_vital_measuredateauxdates_Internalname, 1, 0, "px", 0, "px", "Invisible", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 92,'',false,'" + sGXsfl_31_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_br_vital_measuredateauxdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_br_vital_measuredateauxdate_Internalname, context.localUtil.Format(AV35DDO_BR_Vital_MeasureDateAuxDate, "9999/99/99"), context.localUtil.Format( AV35DDO_BR_Vital_MeasureDateAuxDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,92);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_br_vital_measuredateauxdate_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalWW.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_br_vital_measuredateauxdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_VitalWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'" + sGXsfl_31_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_br_vital_measuredateauxdateto_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_br_vital_measuredateauxdateto_Internalname, context.localUtil.Format(AV36DDO_BR_Vital_MeasureDateAuxDateTo, "9999/99/99"), context.localUtil.Format( AV36DDO_BR_Vital_MeasureDateAuxDateTo, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,93);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_br_vital_measuredateauxdateto_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalWW.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_br_vital_measuredateauxdateto_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_VitalWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 94,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_vital_temperature_Internalname, StringUtil.LTrim( StringUtil.NToC( AV39TFBR_Vital_Temperature, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV39TFBR_Vital_Temperature, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,94);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_vital_temperature_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_vital_temperature_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 95,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_vital_temperature_to_Internalname, StringUtil.LTrim( StringUtil.NToC( AV40TFBR_Vital_Temperature_To, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV40TFBR_Vital_Temperature_To, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,95);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_vital_temperature_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_vital_temperature_to_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 96,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_vital_pulse_Internalname, StringUtil.LTrim( StringUtil.NToC( AV43TFBR_Vital_Pulse, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV43TFBR_Vital_Pulse, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,96);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_vital_pulse_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_vital_pulse_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 97,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_vital_pulse_to_Internalname, StringUtil.LTrim( StringUtil.NToC( AV44TFBR_Vital_Pulse_To, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV44TFBR_Vital_Pulse_To, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,97);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_vital_pulse_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_vital_pulse_to_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_vital_respiration_Internalname, StringUtil.LTrim( StringUtil.NToC( AV47TFBR_Vital_Respiration, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV47TFBR_Vital_Respiration, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,98);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_vital_respiration_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_vital_respiration_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 99,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_vital_respiration_to_Internalname, StringUtil.LTrim( StringUtil.NToC( AV48TFBR_Vital_Respiration_To, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV48TFBR_Vital_Respiration_To, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,99);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_vital_respiration_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_vital_respiration_to_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 100,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_vital_systolic_Internalname, StringUtil.LTrim( StringUtil.NToC( AV51TFBR_Vital_Systolic, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV51TFBR_Vital_Systolic, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,100);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_vital_systolic_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_vital_systolic_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 101,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_vital_systolic_to_Internalname, StringUtil.LTrim( StringUtil.NToC( AV52TFBR_Vital_Systolic_To, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV52TFBR_Vital_Systolic_To, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,101);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_vital_systolic_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_vital_systolic_to_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 102,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_vital_diastolic_Internalname, StringUtil.LTrim( StringUtil.NToC( AV55TFBR_Vital_Diastolic, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV55TFBR_Vital_Diastolic, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,102);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_vital_diastolic_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_vital_diastolic_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 103,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_vital_diastolic_to_Internalname, StringUtil.LTrim( StringUtil.NToC( AV56TFBR_Vital_Diastolic_To, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV56TFBR_Vital_Diastolic_To, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,103);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_vital_diastolic_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_vital_diastolic_to_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 104,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_vital_height_Internalname, StringUtil.LTrim( StringUtil.NToC( AV59TFBR_Vital_Height, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV59TFBR_Vital_Height, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,104);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_vital_height_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_vital_height_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 105,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_vital_height_to_Internalname, StringUtil.LTrim( StringUtil.NToC( AV60TFBR_Vital_Height_To, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV60TFBR_Vital_Height_To, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,105);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_vital_height_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_vital_height_to_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 106,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_vital_weight_Internalname, StringUtil.LTrim( StringUtil.NToC( AV63TFBR_Vital_Weight, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV63TFBR_Vital_Weight, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,106);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_vital_weight_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_vital_weight_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 107,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_vital_weight_to_Internalname, StringUtil.LTrim( StringUtil.NToC( AV64TFBR_Vital_Weight_To, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV64TFBR_Vital_Weight_To, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,107);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_vital_weight_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_vital_weight_to_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalWW.htm");
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

      protected void START5Y2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", " 生命体征", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP5Y0( ) ;
      }

      protected void WS5Y2( )
      {
         START5Y2( ) ;
         EVT5Y2( ) ;
      }

      protected void EVT5Y2( )
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
                              E115Y2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E125Y2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_VITALID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E135Y2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTERID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E145Y2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E155Y2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_VITAL_VITALID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E165Y2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_VITAL_MEASUREDATE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E175Y2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_VITAL_TEMPERATURE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E185Y2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_VITAL_PULSE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E195Y2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_VITAL_RESPIRATION.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E205Y2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_VITAL_SYSTOLIC.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E215Y2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_VITAL_DIASTOLIC.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E225Y2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_VITAL_HEIGHT.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E235Y2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_VITAL_WEIGHT.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E245Y2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E255Y2 ();
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
                              AV71Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV71Display)) ? AV104Display_GXI : context.convertURL( context.PathToRelativeUrl( AV71Display))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV71Display), true);
                              AV72Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV72Update)) ? AV105Update_GXI : context.convertURL( context.PathToRelativeUrl( AV72Update))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV72Update), true);
                              AV74Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV74Delete)) ? AV106Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV74Delete))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV74Delete), true);
                              A150BR_VitalID = (long)(context.localUtil.CToN( cgiGet( edtBR_VitalID_Internalname), ".", ","));
                              A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
                              A36BR_Information_PatientNo = cgiGet( edtBR_Information_PatientNo_Internalname);
                              n36BR_Information_PatientNo = false;
                              A151BR_Vital_VitalID = (long)(context.localUtil.CToN( cgiGet( edtBR_Vital_VitalID_Internalname), ".", ","));
                              n151BR_Vital_VitalID = false;
                              A152BR_Vital_MeasureDate = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtBR_Vital_MeasureDate_Internalname), 0));
                              n152BR_Vital_MeasureDate = false;
                              A153BR_Vital_Temperature = context.localUtil.CToN( cgiGet( edtBR_Vital_Temperature_Internalname), ".", ",");
                              n153BR_Vital_Temperature = false;
                              A154BR_Vital_Pulse = context.localUtil.CToN( cgiGet( edtBR_Vital_Pulse_Internalname), ".", ",");
                              n154BR_Vital_Pulse = false;
                              A155BR_Vital_Respiration = context.localUtil.CToN( cgiGet( edtBR_Vital_Respiration_Internalname), ".", ",");
                              n155BR_Vital_Respiration = false;
                              A156BR_Vital_Systolic = context.localUtil.CToN( cgiGet( edtBR_Vital_Systolic_Internalname), ".", ",");
                              n156BR_Vital_Systolic = false;
                              A157BR_Vital_Diastolic = context.localUtil.CToN( cgiGet( edtBR_Vital_Diastolic_Internalname), ".", ",");
                              n157BR_Vital_Diastolic = false;
                              A158BR_Vital_Height = context.localUtil.CToN( cgiGet( edtBR_Vital_Height_Internalname), ".", ",");
                              n158BR_Vital_Height = false;
                              A159BR_Vital_Weight = context.localUtil.CToN( cgiGet( edtBR_Vital_Weight_Internalname), ".", ",");
                              n159BR_Vital_Weight = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E265Y2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E275Y2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E285Y2 ();
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
                                       /* Set Refresh If Tfbr_vitalid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITALID"), ".", ",") != Convert.ToDecimal( AV17TFBR_VitalID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_vitalid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITALID_TO"), ".", ",") != Convert.ToDecimal( AV18TFBR_VitalID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_encounterid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_ENCOUNTERID"), ".", ",") != Convert.ToDecimal( AV21TFBR_EncounterID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_encounterid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_ENCOUNTERID_TO"), ".", ",") != Convert.ToDecimal( AV22TFBR_EncounterID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_information_patientno Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_INFORMATION_PATIENTNO"), AV25TFBR_Information_PatientNo) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_information_patientno_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_INFORMATION_PATIENTNO_SEL"), AV26TFBR_Information_PatientNo_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_vital_vitalid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_VITALID"), ".", ",") != Convert.ToDecimal( AV29TFBR_Vital_VitalID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_vital_vitalid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_VITALID_TO"), ".", ",") != Convert.ToDecimal( AV30TFBR_Vital_VitalID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_vital_measuredate Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFBR_VITAL_MEASUREDATE"), 0) != AV33TFBR_Vital_MeasureDate )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_vital_measuredate_to Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFBR_VITAL_MEASUREDATE_TO"), 0) != AV34TFBR_Vital_MeasureDate_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_vital_temperature Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_TEMPERATURE"), ".", ",") != AV39TFBR_Vital_Temperature )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_vital_temperature_to Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_TEMPERATURE_TO"), ".", ",") != AV40TFBR_Vital_Temperature_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_vital_pulse Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_PULSE"), ".", ",") != AV43TFBR_Vital_Pulse )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_vital_pulse_to Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_PULSE_TO"), ".", ",") != AV44TFBR_Vital_Pulse_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_vital_respiration Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_RESPIRATION"), ".", ",") != AV47TFBR_Vital_Respiration )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_vital_respiration_to Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_RESPIRATION_TO"), ".", ",") != AV48TFBR_Vital_Respiration_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_vital_systolic Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_SYSTOLIC"), ".", ",") != AV51TFBR_Vital_Systolic )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_vital_systolic_to Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_SYSTOLIC_TO"), ".", ",") != AV52TFBR_Vital_Systolic_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_vital_diastolic Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_DIASTOLIC"), ".", ",") != AV55TFBR_Vital_Diastolic )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_vital_diastolic_to Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_DIASTOLIC_TO"), ".", ",") != AV56TFBR_Vital_Diastolic_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_vital_height Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_HEIGHT"), ".", ",") != AV59TFBR_Vital_Height )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_vital_height_to Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_HEIGHT_TO"), ".", ",") != AV60TFBR_Vital_Height_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_vital_weight Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_WEIGHT"), ".", ",") != AV63TFBR_Vital_Weight )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_vital_weight_to Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_WEIGHT_TO"), ".", ",") != AV64TFBR_Vital_Weight_To )
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

      protected void WE5Y2( )
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

      protected void PA5Y2( )
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
               GX_FocusControl = edtavDdo_br_vitalidtitlecontrolidtoreplace_Internalname;
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
                                       long AV17TFBR_VitalID ,
                                       long AV18TFBR_VitalID_To ,
                                       long AV21TFBR_EncounterID ,
                                       long AV22TFBR_EncounterID_To ,
                                       String AV25TFBR_Information_PatientNo ,
                                       String AV26TFBR_Information_PatientNo_Sel ,
                                       long AV29TFBR_Vital_VitalID ,
                                       long AV30TFBR_Vital_VitalID_To ,
                                       DateTime AV33TFBR_Vital_MeasureDate ,
                                       DateTime AV34TFBR_Vital_MeasureDate_To ,
                                       decimal AV39TFBR_Vital_Temperature ,
                                       decimal AV40TFBR_Vital_Temperature_To ,
                                       decimal AV43TFBR_Vital_Pulse ,
                                       decimal AV44TFBR_Vital_Pulse_To ,
                                       decimal AV47TFBR_Vital_Respiration ,
                                       decimal AV48TFBR_Vital_Respiration_To ,
                                       decimal AV51TFBR_Vital_Systolic ,
                                       decimal AV52TFBR_Vital_Systolic_To ,
                                       decimal AV55TFBR_Vital_Diastolic ,
                                       decimal AV56TFBR_Vital_Diastolic_To ,
                                       decimal AV59TFBR_Vital_Height ,
                                       decimal AV60TFBR_Vital_Height_To ,
                                       decimal AV63TFBR_Vital_Weight ,
                                       decimal AV64TFBR_Vital_Weight_To ,
                                       String AV19ddo_BR_VitalIDTitleControlIdToReplace ,
                                       String AV23ddo_BR_EncounterIDTitleControlIdToReplace ,
                                       String AV27ddo_BR_Information_PatientNoTitleControlIdToReplace ,
                                       String AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace ,
                                       String AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace ,
                                       String AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace ,
                                       String AV45ddo_BR_Vital_PulseTitleControlIdToReplace ,
                                       String AV49ddo_BR_Vital_RespirationTitleControlIdToReplace ,
                                       String AV53ddo_BR_Vital_SystolicTitleControlIdToReplace ,
                                       String AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace ,
                                       String AV61ddo_BR_Vital_HeightTitleControlIdToReplace ,
                                       String AV65ddo_BR_Vital_WeightTitleControlIdToReplace ,
                                       String AV107Pgmname ,
                                       bool AV73IsAuthorized_Update ,
                                       bool AV75IsAuthorized_Delete ,
                                       bool AV76IsAuthorized_BR_Information_PatientNo )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF5Y2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_VITALID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A150BR_VitalID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_VITALID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A150BR_VitalID), 18, 0, ".", "")));
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
         RF5Y2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV107Pgmname = "BR_VitalWW";
         context.Gx_err = 0;
      }

      protected void RF5Y2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 31;
         /* Execute user event: Refresh */
         E275Y2 ();
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
                                                 AV80BR_VitalWWDS_1_Tfbr_vitalid ,
                                                 AV81BR_VitalWWDS_2_Tfbr_vitalid_to ,
                                                 AV82BR_VitalWWDS_3_Tfbr_encounterid ,
                                                 AV83BR_VitalWWDS_4_Tfbr_encounterid_to ,
                                                 AV85BR_VitalWWDS_6_Tfbr_information_patientno_sel ,
                                                 AV84BR_VitalWWDS_5_Tfbr_information_patientno ,
                                                 AV86BR_VitalWWDS_7_Tfbr_vital_vitalid ,
                                                 AV87BR_VitalWWDS_8_Tfbr_vital_vitalid_to ,
                                                 AV88BR_VitalWWDS_9_Tfbr_vital_measuredate ,
                                                 AV89BR_VitalWWDS_10_Tfbr_vital_measuredate_to ,
                                                 AV90BR_VitalWWDS_11_Tfbr_vital_temperature ,
                                                 AV91BR_VitalWWDS_12_Tfbr_vital_temperature_to ,
                                                 AV92BR_VitalWWDS_13_Tfbr_vital_pulse ,
                                                 AV93BR_VitalWWDS_14_Tfbr_vital_pulse_to ,
                                                 AV94BR_VitalWWDS_15_Tfbr_vital_respiration ,
                                                 AV95BR_VitalWWDS_16_Tfbr_vital_respiration_to ,
                                                 AV96BR_VitalWWDS_17_Tfbr_vital_systolic ,
                                                 AV97BR_VitalWWDS_18_Tfbr_vital_systolic_to ,
                                                 AV98BR_VitalWWDS_19_Tfbr_vital_diastolic ,
                                                 AV99BR_VitalWWDS_20_Tfbr_vital_diastolic_to ,
                                                 AV100BR_VitalWWDS_21_Tfbr_vital_height ,
                                                 AV101BR_VitalWWDS_22_Tfbr_vital_height_to ,
                                                 AV102BR_VitalWWDS_23_Tfbr_vital_weight ,
                                                 AV103BR_VitalWWDS_24_Tfbr_vital_weight_to ,
                                                 A150BR_VitalID ,
                                                 A19BR_EncounterID ,
                                                 A36BR_Information_PatientNo ,
                                                 A151BR_Vital_VitalID ,
                                                 A152BR_Vital_MeasureDate ,
                                                 A153BR_Vital_Temperature ,
                                                 A154BR_Vital_Pulse ,
                                                 A155BR_Vital_Respiration ,
                                                 A156BR_Vital_Systolic ,
                                                 A157BR_Vital_Diastolic ,
                                                 A158BR_Vital_Height ,
                                                 A159BR_Vital_Weight ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.DATE, TypeConstants.DATE,
                                                 TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL,
                                                 TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN,
                                                 TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN,
                                                 TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV84BR_VitalWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV84BR_VitalWWDS_5_Tfbr_information_patientno), "%", "");
            /* Using cursor H005Y2 */
            pr_default.execute(0, new Object[] {AV80BR_VitalWWDS_1_Tfbr_vitalid, AV81BR_VitalWWDS_2_Tfbr_vitalid_to, AV82BR_VitalWWDS_3_Tfbr_encounterid, AV83BR_VitalWWDS_4_Tfbr_encounterid_to, lV84BR_VitalWWDS_5_Tfbr_information_patientno, AV85BR_VitalWWDS_6_Tfbr_information_patientno_sel, AV86BR_VitalWWDS_7_Tfbr_vital_vitalid, AV87BR_VitalWWDS_8_Tfbr_vital_vitalid_to, AV88BR_VitalWWDS_9_Tfbr_vital_measuredate, AV89BR_VitalWWDS_10_Tfbr_vital_measuredate_to, AV90BR_VitalWWDS_11_Tfbr_vital_temperature, AV91BR_VitalWWDS_12_Tfbr_vital_temperature_to, AV92BR_VitalWWDS_13_Tfbr_vital_pulse, AV93BR_VitalWWDS_14_Tfbr_vital_pulse_to, AV94BR_VitalWWDS_15_Tfbr_vital_respiration, AV95BR_VitalWWDS_16_Tfbr_vital_respiration_to, AV96BR_VitalWWDS_17_Tfbr_vital_systolic, AV97BR_VitalWWDS_18_Tfbr_vital_systolic_to, AV98BR_VitalWWDS_19_Tfbr_vital_diastolic, AV99BR_VitalWWDS_20_Tfbr_vital_diastolic_to, AV100BR_VitalWWDS_21_Tfbr_vital_height, AV101BR_VitalWWDS_22_Tfbr_vital_height_to, AV102BR_VitalWWDS_23_Tfbr_vital_weight, AV103BR_VitalWWDS_24_Tfbr_vital_weight_to, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_31_idx = 1;
            sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
            SubsflControlProps_312( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A85BR_Information_ID = H005Y2_A85BR_Information_ID[0];
               n85BR_Information_ID = H005Y2_n85BR_Information_ID[0];
               A159BR_Vital_Weight = H005Y2_A159BR_Vital_Weight[0];
               n159BR_Vital_Weight = H005Y2_n159BR_Vital_Weight[0];
               A158BR_Vital_Height = H005Y2_A158BR_Vital_Height[0];
               n158BR_Vital_Height = H005Y2_n158BR_Vital_Height[0];
               A157BR_Vital_Diastolic = H005Y2_A157BR_Vital_Diastolic[0];
               n157BR_Vital_Diastolic = H005Y2_n157BR_Vital_Diastolic[0];
               A156BR_Vital_Systolic = H005Y2_A156BR_Vital_Systolic[0];
               n156BR_Vital_Systolic = H005Y2_n156BR_Vital_Systolic[0];
               A155BR_Vital_Respiration = H005Y2_A155BR_Vital_Respiration[0];
               n155BR_Vital_Respiration = H005Y2_n155BR_Vital_Respiration[0];
               A154BR_Vital_Pulse = H005Y2_A154BR_Vital_Pulse[0];
               n154BR_Vital_Pulse = H005Y2_n154BR_Vital_Pulse[0];
               A153BR_Vital_Temperature = H005Y2_A153BR_Vital_Temperature[0];
               n153BR_Vital_Temperature = H005Y2_n153BR_Vital_Temperature[0];
               A152BR_Vital_MeasureDate = H005Y2_A152BR_Vital_MeasureDate[0];
               n152BR_Vital_MeasureDate = H005Y2_n152BR_Vital_MeasureDate[0];
               A151BR_Vital_VitalID = H005Y2_A151BR_Vital_VitalID[0];
               n151BR_Vital_VitalID = H005Y2_n151BR_Vital_VitalID[0];
               A36BR_Information_PatientNo = H005Y2_A36BR_Information_PatientNo[0];
               n36BR_Information_PatientNo = H005Y2_n36BR_Information_PatientNo[0];
               A19BR_EncounterID = H005Y2_A19BR_EncounterID[0];
               A150BR_VitalID = H005Y2_A150BR_VitalID[0];
               A85BR_Information_ID = H005Y2_A85BR_Information_ID[0];
               n85BR_Information_ID = H005Y2_n85BR_Information_ID[0];
               A36BR_Information_PatientNo = H005Y2_A36BR_Information_PatientNo[0];
               n36BR_Information_PatientNo = H005Y2_n36BR_Information_PatientNo[0];
               E285Y2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 31;
            WB5Y0( ) ;
         }
         bGXsfl_31_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes5Y2( )
      {
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_BR_INFORMATION_PATIENTNO", AV76IsAuthorized_BR_Information_PatientNo);
         GxWebStd.gx_hidden_field( context, "gxhash_vISAUTHORIZED_BR_INFORMATION_PATIENTNO", GetSecureSignedToken( "", AV76IsAuthorized_BR_Information_PatientNo, context));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_VITALID"+"_"+sGXsfl_31_idx, GetSecureSignedToken( sGXsfl_31_idx, context.localUtil.Format( (decimal)(A150BR_VitalID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         AV80BR_VitalWWDS_1_Tfbr_vitalid = AV17TFBR_VitalID;
         AV81BR_VitalWWDS_2_Tfbr_vitalid_to = AV18TFBR_VitalID_To;
         AV82BR_VitalWWDS_3_Tfbr_encounterid = AV21TFBR_EncounterID;
         AV83BR_VitalWWDS_4_Tfbr_encounterid_to = AV22TFBR_EncounterID_To;
         AV84BR_VitalWWDS_5_Tfbr_information_patientno = AV25TFBR_Information_PatientNo;
         AV85BR_VitalWWDS_6_Tfbr_information_patientno_sel = AV26TFBR_Information_PatientNo_Sel;
         AV86BR_VitalWWDS_7_Tfbr_vital_vitalid = AV29TFBR_Vital_VitalID;
         AV87BR_VitalWWDS_8_Tfbr_vital_vitalid_to = AV30TFBR_Vital_VitalID_To;
         AV88BR_VitalWWDS_9_Tfbr_vital_measuredate = AV33TFBR_Vital_MeasureDate;
         AV89BR_VitalWWDS_10_Tfbr_vital_measuredate_to = AV34TFBR_Vital_MeasureDate_To;
         AV90BR_VitalWWDS_11_Tfbr_vital_temperature = AV39TFBR_Vital_Temperature;
         AV91BR_VitalWWDS_12_Tfbr_vital_temperature_to = AV40TFBR_Vital_Temperature_To;
         AV92BR_VitalWWDS_13_Tfbr_vital_pulse = AV43TFBR_Vital_Pulse;
         AV93BR_VitalWWDS_14_Tfbr_vital_pulse_to = AV44TFBR_Vital_Pulse_To;
         AV94BR_VitalWWDS_15_Tfbr_vital_respiration = AV47TFBR_Vital_Respiration;
         AV95BR_VitalWWDS_16_Tfbr_vital_respiration_to = AV48TFBR_Vital_Respiration_To;
         AV96BR_VitalWWDS_17_Tfbr_vital_systolic = AV51TFBR_Vital_Systolic;
         AV97BR_VitalWWDS_18_Tfbr_vital_systolic_to = AV52TFBR_Vital_Systolic_To;
         AV98BR_VitalWWDS_19_Tfbr_vital_diastolic = AV55TFBR_Vital_Diastolic;
         AV99BR_VitalWWDS_20_Tfbr_vital_diastolic_to = AV56TFBR_Vital_Diastolic_To;
         AV100BR_VitalWWDS_21_Tfbr_vital_height = AV59TFBR_Vital_Height;
         AV101BR_VitalWWDS_22_Tfbr_vital_height_to = AV60TFBR_Vital_Height_To;
         AV102BR_VitalWWDS_23_Tfbr_vital_weight = AV63TFBR_Vital_Weight;
         AV103BR_VitalWWDS_24_Tfbr_vital_weight_to = AV64TFBR_Vital_Weight_To;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV80BR_VitalWWDS_1_Tfbr_vitalid ,
                                              AV81BR_VitalWWDS_2_Tfbr_vitalid_to ,
                                              AV82BR_VitalWWDS_3_Tfbr_encounterid ,
                                              AV83BR_VitalWWDS_4_Tfbr_encounterid_to ,
                                              AV85BR_VitalWWDS_6_Tfbr_information_patientno_sel ,
                                              AV84BR_VitalWWDS_5_Tfbr_information_patientno ,
                                              AV86BR_VitalWWDS_7_Tfbr_vital_vitalid ,
                                              AV87BR_VitalWWDS_8_Tfbr_vital_vitalid_to ,
                                              AV88BR_VitalWWDS_9_Tfbr_vital_measuredate ,
                                              AV89BR_VitalWWDS_10_Tfbr_vital_measuredate_to ,
                                              AV90BR_VitalWWDS_11_Tfbr_vital_temperature ,
                                              AV91BR_VitalWWDS_12_Tfbr_vital_temperature_to ,
                                              AV92BR_VitalWWDS_13_Tfbr_vital_pulse ,
                                              AV93BR_VitalWWDS_14_Tfbr_vital_pulse_to ,
                                              AV94BR_VitalWWDS_15_Tfbr_vital_respiration ,
                                              AV95BR_VitalWWDS_16_Tfbr_vital_respiration_to ,
                                              AV96BR_VitalWWDS_17_Tfbr_vital_systolic ,
                                              AV97BR_VitalWWDS_18_Tfbr_vital_systolic_to ,
                                              AV98BR_VitalWWDS_19_Tfbr_vital_diastolic ,
                                              AV99BR_VitalWWDS_20_Tfbr_vital_diastolic_to ,
                                              AV100BR_VitalWWDS_21_Tfbr_vital_height ,
                                              AV101BR_VitalWWDS_22_Tfbr_vital_height_to ,
                                              AV102BR_VitalWWDS_23_Tfbr_vital_weight ,
                                              AV103BR_VitalWWDS_24_Tfbr_vital_weight_to ,
                                              A150BR_VitalID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A151BR_Vital_VitalID ,
                                              A152BR_Vital_MeasureDate ,
                                              A153BR_Vital_Temperature ,
                                              A154BR_Vital_Pulse ,
                                              A155BR_Vital_Respiration ,
                                              A156BR_Vital_Systolic ,
                                              A157BR_Vital_Diastolic ,
                                              A158BR_Vital_Height ,
                                              A159BR_Vital_Weight ,
                                              AV13OrderedBy ,
                                              AV14OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.DATE, TypeConstants.DATE,
                                              TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL,
                                              TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN,
                                              TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN,
                                              TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV84BR_VitalWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV84BR_VitalWWDS_5_Tfbr_information_patientno), "%", "");
         /* Using cursor H005Y3 */
         pr_default.execute(1, new Object[] {AV80BR_VitalWWDS_1_Tfbr_vitalid, AV81BR_VitalWWDS_2_Tfbr_vitalid_to, AV82BR_VitalWWDS_3_Tfbr_encounterid, AV83BR_VitalWWDS_4_Tfbr_encounterid_to, lV84BR_VitalWWDS_5_Tfbr_information_patientno, AV85BR_VitalWWDS_6_Tfbr_information_patientno_sel, AV86BR_VitalWWDS_7_Tfbr_vital_vitalid, AV87BR_VitalWWDS_8_Tfbr_vital_vitalid_to, AV88BR_VitalWWDS_9_Tfbr_vital_measuredate, AV89BR_VitalWWDS_10_Tfbr_vital_measuredate_to, AV90BR_VitalWWDS_11_Tfbr_vital_temperature, AV91BR_VitalWWDS_12_Tfbr_vital_temperature_to, AV92BR_VitalWWDS_13_Tfbr_vital_pulse, AV93BR_VitalWWDS_14_Tfbr_vital_pulse_to, AV94BR_VitalWWDS_15_Tfbr_vital_respiration, AV95BR_VitalWWDS_16_Tfbr_vital_respiration_to, AV96BR_VitalWWDS_17_Tfbr_vital_systolic, AV97BR_VitalWWDS_18_Tfbr_vital_systolic_to, AV98BR_VitalWWDS_19_Tfbr_vital_diastolic, AV99BR_VitalWWDS_20_Tfbr_vital_diastolic_to, AV100BR_VitalWWDS_21_Tfbr_vital_height, AV101BR_VitalWWDS_22_Tfbr_vital_height_to, AV102BR_VitalWWDS_23_Tfbr_vital_weight, AV103BR_VitalWWDS_24_Tfbr_vital_weight_to});
         GRID_nRecordCount = H005Y3_AGRID_nRecordCount[0];
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
         AV80BR_VitalWWDS_1_Tfbr_vitalid = AV17TFBR_VitalID;
         AV81BR_VitalWWDS_2_Tfbr_vitalid_to = AV18TFBR_VitalID_To;
         AV82BR_VitalWWDS_3_Tfbr_encounterid = AV21TFBR_EncounterID;
         AV83BR_VitalWWDS_4_Tfbr_encounterid_to = AV22TFBR_EncounterID_To;
         AV84BR_VitalWWDS_5_Tfbr_information_patientno = AV25TFBR_Information_PatientNo;
         AV85BR_VitalWWDS_6_Tfbr_information_patientno_sel = AV26TFBR_Information_PatientNo_Sel;
         AV86BR_VitalWWDS_7_Tfbr_vital_vitalid = AV29TFBR_Vital_VitalID;
         AV87BR_VitalWWDS_8_Tfbr_vital_vitalid_to = AV30TFBR_Vital_VitalID_To;
         AV88BR_VitalWWDS_9_Tfbr_vital_measuredate = AV33TFBR_Vital_MeasureDate;
         AV89BR_VitalWWDS_10_Tfbr_vital_measuredate_to = AV34TFBR_Vital_MeasureDate_To;
         AV90BR_VitalWWDS_11_Tfbr_vital_temperature = AV39TFBR_Vital_Temperature;
         AV91BR_VitalWWDS_12_Tfbr_vital_temperature_to = AV40TFBR_Vital_Temperature_To;
         AV92BR_VitalWWDS_13_Tfbr_vital_pulse = AV43TFBR_Vital_Pulse;
         AV93BR_VitalWWDS_14_Tfbr_vital_pulse_to = AV44TFBR_Vital_Pulse_To;
         AV94BR_VitalWWDS_15_Tfbr_vital_respiration = AV47TFBR_Vital_Respiration;
         AV95BR_VitalWWDS_16_Tfbr_vital_respiration_to = AV48TFBR_Vital_Respiration_To;
         AV96BR_VitalWWDS_17_Tfbr_vital_systolic = AV51TFBR_Vital_Systolic;
         AV97BR_VitalWWDS_18_Tfbr_vital_systolic_to = AV52TFBR_Vital_Systolic_To;
         AV98BR_VitalWWDS_19_Tfbr_vital_diastolic = AV55TFBR_Vital_Diastolic;
         AV99BR_VitalWWDS_20_Tfbr_vital_diastolic_to = AV56TFBR_Vital_Diastolic_To;
         AV100BR_VitalWWDS_21_Tfbr_vital_height = AV59TFBR_Vital_Height;
         AV101BR_VitalWWDS_22_Tfbr_vital_height_to = AV60TFBR_Vital_Height_To;
         AV102BR_VitalWWDS_23_Tfbr_vital_weight = AV63TFBR_Vital_Weight;
         AV103BR_VitalWWDS_24_Tfbr_vital_weight_to = AV64TFBR_Vital_Weight_To;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_VitalID, AV18TFBR_VitalID_To, AV21TFBR_EncounterID, AV22TFBR_EncounterID_To, AV25TFBR_Information_PatientNo, AV26TFBR_Information_PatientNo_Sel, AV29TFBR_Vital_VitalID, AV30TFBR_Vital_VitalID_To, AV33TFBR_Vital_MeasureDate, AV34TFBR_Vital_MeasureDate_To, AV39TFBR_Vital_Temperature, AV40TFBR_Vital_Temperature_To, AV43TFBR_Vital_Pulse, AV44TFBR_Vital_Pulse_To, AV47TFBR_Vital_Respiration, AV48TFBR_Vital_Respiration_To, AV51TFBR_Vital_Systolic, AV52TFBR_Vital_Systolic_To, AV55TFBR_Vital_Diastolic, AV56TFBR_Vital_Diastolic_To, AV59TFBR_Vital_Height, AV60TFBR_Vital_Height_To, AV63TFBR_Vital_Weight, AV64TFBR_Vital_Weight_To, AV19ddo_BR_VitalIDTitleControlIdToReplace, AV23ddo_BR_EncounterIDTitleControlIdToReplace, AV27ddo_BR_Information_PatientNoTitleControlIdToReplace, AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace, AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace, AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace, AV45ddo_BR_Vital_PulseTitleControlIdToReplace, AV49ddo_BR_Vital_RespirationTitleControlIdToReplace, AV53ddo_BR_Vital_SystolicTitleControlIdToReplace, AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace, AV61ddo_BR_Vital_HeightTitleControlIdToReplace, AV65ddo_BR_Vital_WeightTitleControlIdToReplace, AV107Pgmname, AV73IsAuthorized_Update, AV75IsAuthorized_Delete, AV76IsAuthorized_BR_Information_PatientNo) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV80BR_VitalWWDS_1_Tfbr_vitalid = AV17TFBR_VitalID;
         AV81BR_VitalWWDS_2_Tfbr_vitalid_to = AV18TFBR_VitalID_To;
         AV82BR_VitalWWDS_3_Tfbr_encounterid = AV21TFBR_EncounterID;
         AV83BR_VitalWWDS_4_Tfbr_encounterid_to = AV22TFBR_EncounterID_To;
         AV84BR_VitalWWDS_5_Tfbr_information_patientno = AV25TFBR_Information_PatientNo;
         AV85BR_VitalWWDS_6_Tfbr_information_patientno_sel = AV26TFBR_Information_PatientNo_Sel;
         AV86BR_VitalWWDS_7_Tfbr_vital_vitalid = AV29TFBR_Vital_VitalID;
         AV87BR_VitalWWDS_8_Tfbr_vital_vitalid_to = AV30TFBR_Vital_VitalID_To;
         AV88BR_VitalWWDS_9_Tfbr_vital_measuredate = AV33TFBR_Vital_MeasureDate;
         AV89BR_VitalWWDS_10_Tfbr_vital_measuredate_to = AV34TFBR_Vital_MeasureDate_To;
         AV90BR_VitalWWDS_11_Tfbr_vital_temperature = AV39TFBR_Vital_Temperature;
         AV91BR_VitalWWDS_12_Tfbr_vital_temperature_to = AV40TFBR_Vital_Temperature_To;
         AV92BR_VitalWWDS_13_Tfbr_vital_pulse = AV43TFBR_Vital_Pulse;
         AV93BR_VitalWWDS_14_Tfbr_vital_pulse_to = AV44TFBR_Vital_Pulse_To;
         AV94BR_VitalWWDS_15_Tfbr_vital_respiration = AV47TFBR_Vital_Respiration;
         AV95BR_VitalWWDS_16_Tfbr_vital_respiration_to = AV48TFBR_Vital_Respiration_To;
         AV96BR_VitalWWDS_17_Tfbr_vital_systolic = AV51TFBR_Vital_Systolic;
         AV97BR_VitalWWDS_18_Tfbr_vital_systolic_to = AV52TFBR_Vital_Systolic_To;
         AV98BR_VitalWWDS_19_Tfbr_vital_diastolic = AV55TFBR_Vital_Diastolic;
         AV99BR_VitalWWDS_20_Tfbr_vital_diastolic_to = AV56TFBR_Vital_Diastolic_To;
         AV100BR_VitalWWDS_21_Tfbr_vital_height = AV59TFBR_Vital_Height;
         AV101BR_VitalWWDS_22_Tfbr_vital_height_to = AV60TFBR_Vital_Height_To;
         AV102BR_VitalWWDS_23_Tfbr_vital_weight = AV63TFBR_Vital_Weight;
         AV103BR_VitalWWDS_24_Tfbr_vital_weight_to = AV64TFBR_Vital_Weight_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_VitalID, AV18TFBR_VitalID_To, AV21TFBR_EncounterID, AV22TFBR_EncounterID_To, AV25TFBR_Information_PatientNo, AV26TFBR_Information_PatientNo_Sel, AV29TFBR_Vital_VitalID, AV30TFBR_Vital_VitalID_To, AV33TFBR_Vital_MeasureDate, AV34TFBR_Vital_MeasureDate_To, AV39TFBR_Vital_Temperature, AV40TFBR_Vital_Temperature_To, AV43TFBR_Vital_Pulse, AV44TFBR_Vital_Pulse_To, AV47TFBR_Vital_Respiration, AV48TFBR_Vital_Respiration_To, AV51TFBR_Vital_Systolic, AV52TFBR_Vital_Systolic_To, AV55TFBR_Vital_Diastolic, AV56TFBR_Vital_Diastolic_To, AV59TFBR_Vital_Height, AV60TFBR_Vital_Height_To, AV63TFBR_Vital_Weight, AV64TFBR_Vital_Weight_To, AV19ddo_BR_VitalIDTitleControlIdToReplace, AV23ddo_BR_EncounterIDTitleControlIdToReplace, AV27ddo_BR_Information_PatientNoTitleControlIdToReplace, AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace, AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace, AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace, AV45ddo_BR_Vital_PulseTitleControlIdToReplace, AV49ddo_BR_Vital_RespirationTitleControlIdToReplace, AV53ddo_BR_Vital_SystolicTitleControlIdToReplace, AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace, AV61ddo_BR_Vital_HeightTitleControlIdToReplace, AV65ddo_BR_Vital_WeightTitleControlIdToReplace, AV107Pgmname, AV73IsAuthorized_Update, AV75IsAuthorized_Delete, AV76IsAuthorized_BR_Information_PatientNo) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV80BR_VitalWWDS_1_Tfbr_vitalid = AV17TFBR_VitalID;
         AV81BR_VitalWWDS_2_Tfbr_vitalid_to = AV18TFBR_VitalID_To;
         AV82BR_VitalWWDS_3_Tfbr_encounterid = AV21TFBR_EncounterID;
         AV83BR_VitalWWDS_4_Tfbr_encounterid_to = AV22TFBR_EncounterID_To;
         AV84BR_VitalWWDS_5_Tfbr_information_patientno = AV25TFBR_Information_PatientNo;
         AV85BR_VitalWWDS_6_Tfbr_information_patientno_sel = AV26TFBR_Information_PatientNo_Sel;
         AV86BR_VitalWWDS_7_Tfbr_vital_vitalid = AV29TFBR_Vital_VitalID;
         AV87BR_VitalWWDS_8_Tfbr_vital_vitalid_to = AV30TFBR_Vital_VitalID_To;
         AV88BR_VitalWWDS_9_Tfbr_vital_measuredate = AV33TFBR_Vital_MeasureDate;
         AV89BR_VitalWWDS_10_Tfbr_vital_measuredate_to = AV34TFBR_Vital_MeasureDate_To;
         AV90BR_VitalWWDS_11_Tfbr_vital_temperature = AV39TFBR_Vital_Temperature;
         AV91BR_VitalWWDS_12_Tfbr_vital_temperature_to = AV40TFBR_Vital_Temperature_To;
         AV92BR_VitalWWDS_13_Tfbr_vital_pulse = AV43TFBR_Vital_Pulse;
         AV93BR_VitalWWDS_14_Tfbr_vital_pulse_to = AV44TFBR_Vital_Pulse_To;
         AV94BR_VitalWWDS_15_Tfbr_vital_respiration = AV47TFBR_Vital_Respiration;
         AV95BR_VitalWWDS_16_Tfbr_vital_respiration_to = AV48TFBR_Vital_Respiration_To;
         AV96BR_VitalWWDS_17_Tfbr_vital_systolic = AV51TFBR_Vital_Systolic;
         AV97BR_VitalWWDS_18_Tfbr_vital_systolic_to = AV52TFBR_Vital_Systolic_To;
         AV98BR_VitalWWDS_19_Tfbr_vital_diastolic = AV55TFBR_Vital_Diastolic;
         AV99BR_VitalWWDS_20_Tfbr_vital_diastolic_to = AV56TFBR_Vital_Diastolic_To;
         AV100BR_VitalWWDS_21_Tfbr_vital_height = AV59TFBR_Vital_Height;
         AV101BR_VitalWWDS_22_Tfbr_vital_height_to = AV60TFBR_Vital_Height_To;
         AV102BR_VitalWWDS_23_Tfbr_vital_weight = AV63TFBR_Vital_Weight;
         AV103BR_VitalWWDS_24_Tfbr_vital_weight_to = AV64TFBR_Vital_Weight_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_VitalID, AV18TFBR_VitalID_To, AV21TFBR_EncounterID, AV22TFBR_EncounterID_To, AV25TFBR_Information_PatientNo, AV26TFBR_Information_PatientNo_Sel, AV29TFBR_Vital_VitalID, AV30TFBR_Vital_VitalID_To, AV33TFBR_Vital_MeasureDate, AV34TFBR_Vital_MeasureDate_To, AV39TFBR_Vital_Temperature, AV40TFBR_Vital_Temperature_To, AV43TFBR_Vital_Pulse, AV44TFBR_Vital_Pulse_To, AV47TFBR_Vital_Respiration, AV48TFBR_Vital_Respiration_To, AV51TFBR_Vital_Systolic, AV52TFBR_Vital_Systolic_To, AV55TFBR_Vital_Diastolic, AV56TFBR_Vital_Diastolic_To, AV59TFBR_Vital_Height, AV60TFBR_Vital_Height_To, AV63TFBR_Vital_Weight, AV64TFBR_Vital_Weight_To, AV19ddo_BR_VitalIDTitleControlIdToReplace, AV23ddo_BR_EncounterIDTitleControlIdToReplace, AV27ddo_BR_Information_PatientNoTitleControlIdToReplace, AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace, AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace, AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace, AV45ddo_BR_Vital_PulseTitleControlIdToReplace, AV49ddo_BR_Vital_RespirationTitleControlIdToReplace, AV53ddo_BR_Vital_SystolicTitleControlIdToReplace, AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace, AV61ddo_BR_Vital_HeightTitleControlIdToReplace, AV65ddo_BR_Vital_WeightTitleControlIdToReplace, AV107Pgmname, AV73IsAuthorized_Update, AV75IsAuthorized_Delete, AV76IsAuthorized_BR_Information_PatientNo) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV80BR_VitalWWDS_1_Tfbr_vitalid = AV17TFBR_VitalID;
         AV81BR_VitalWWDS_2_Tfbr_vitalid_to = AV18TFBR_VitalID_To;
         AV82BR_VitalWWDS_3_Tfbr_encounterid = AV21TFBR_EncounterID;
         AV83BR_VitalWWDS_4_Tfbr_encounterid_to = AV22TFBR_EncounterID_To;
         AV84BR_VitalWWDS_5_Tfbr_information_patientno = AV25TFBR_Information_PatientNo;
         AV85BR_VitalWWDS_6_Tfbr_information_patientno_sel = AV26TFBR_Information_PatientNo_Sel;
         AV86BR_VitalWWDS_7_Tfbr_vital_vitalid = AV29TFBR_Vital_VitalID;
         AV87BR_VitalWWDS_8_Tfbr_vital_vitalid_to = AV30TFBR_Vital_VitalID_To;
         AV88BR_VitalWWDS_9_Tfbr_vital_measuredate = AV33TFBR_Vital_MeasureDate;
         AV89BR_VitalWWDS_10_Tfbr_vital_measuredate_to = AV34TFBR_Vital_MeasureDate_To;
         AV90BR_VitalWWDS_11_Tfbr_vital_temperature = AV39TFBR_Vital_Temperature;
         AV91BR_VitalWWDS_12_Tfbr_vital_temperature_to = AV40TFBR_Vital_Temperature_To;
         AV92BR_VitalWWDS_13_Tfbr_vital_pulse = AV43TFBR_Vital_Pulse;
         AV93BR_VitalWWDS_14_Tfbr_vital_pulse_to = AV44TFBR_Vital_Pulse_To;
         AV94BR_VitalWWDS_15_Tfbr_vital_respiration = AV47TFBR_Vital_Respiration;
         AV95BR_VitalWWDS_16_Tfbr_vital_respiration_to = AV48TFBR_Vital_Respiration_To;
         AV96BR_VitalWWDS_17_Tfbr_vital_systolic = AV51TFBR_Vital_Systolic;
         AV97BR_VitalWWDS_18_Tfbr_vital_systolic_to = AV52TFBR_Vital_Systolic_To;
         AV98BR_VitalWWDS_19_Tfbr_vital_diastolic = AV55TFBR_Vital_Diastolic;
         AV99BR_VitalWWDS_20_Tfbr_vital_diastolic_to = AV56TFBR_Vital_Diastolic_To;
         AV100BR_VitalWWDS_21_Tfbr_vital_height = AV59TFBR_Vital_Height;
         AV101BR_VitalWWDS_22_Tfbr_vital_height_to = AV60TFBR_Vital_Height_To;
         AV102BR_VitalWWDS_23_Tfbr_vital_weight = AV63TFBR_Vital_Weight;
         AV103BR_VitalWWDS_24_Tfbr_vital_weight_to = AV64TFBR_Vital_Weight_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_VitalID, AV18TFBR_VitalID_To, AV21TFBR_EncounterID, AV22TFBR_EncounterID_To, AV25TFBR_Information_PatientNo, AV26TFBR_Information_PatientNo_Sel, AV29TFBR_Vital_VitalID, AV30TFBR_Vital_VitalID_To, AV33TFBR_Vital_MeasureDate, AV34TFBR_Vital_MeasureDate_To, AV39TFBR_Vital_Temperature, AV40TFBR_Vital_Temperature_To, AV43TFBR_Vital_Pulse, AV44TFBR_Vital_Pulse_To, AV47TFBR_Vital_Respiration, AV48TFBR_Vital_Respiration_To, AV51TFBR_Vital_Systolic, AV52TFBR_Vital_Systolic_To, AV55TFBR_Vital_Diastolic, AV56TFBR_Vital_Diastolic_To, AV59TFBR_Vital_Height, AV60TFBR_Vital_Height_To, AV63TFBR_Vital_Weight, AV64TFBR_Vital_Weight_To, AV19ddo_BR_VitalIDTitleControlIdToReplace, AV23ddo_BR_EncounterIDTitleControlIdToReplace, AV27ddo_BR_Information_PatientNoTitleControlIdToReplace, AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace, AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace, AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace, AV45ddo_BR_Vital_PulseTitleControlIdToReplace, AV49ddo_BR_Vital_RespirationTitleControlIdToReplace, AV53ddo_BR_Vital_SystolicTitleControlIdToReplace, AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace, AV61ddo_BR_Vital_HeightTitleControlIdToReplace, AV65ddo_BR_Vital_WeightTitleControlIdToReplace, AV107Pgmname, AV73IsAuthorized_Update, AV75IsAuthorized_Delete, AV76IsAuthorized_BR_Information_PatientNo) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV80BR_VitalWWDS_1_Tfbr_vitalid = AV17TFBR_VitalID;
         AV81BR_VitalWWDS_2_Tfbr_vitalid_to = AV18TFBR_VitalID_To;
         AV82BR_VitalWWDS_3_Tfbr_encounterid = AV21TFBR_EncounterID;
         AV83BR_VitalWWDS_4_Tfbr_encounterid_to = AV22TFBR_EncounterID_To;
         AV84BR_VitalWWDS_5_Tfbr_information_patientno = AV25TFBR_Information_PatientNo;
         AV85BR_VitalWWDS_6_Tfbr_information_patientno_sel = AV26TFBR_Information_PatientNo_Sel;
         AV86BR_VitalWWDS_7_Tfbr_vital_vitalid = AV29TFBR_Vital_VitalID;
         AV87BR_VitalWWDS_8_Tfbr_vital_vitalid_to = AV30TFBR_Vital_VitalID_To;
         AV88BR_VitalWWDS_9_Tfbr_vital_measuredate = AV33TFBR_Vital_MeasureDate;
         AV89BR_VitalWWDS_10_Tfbr_vital_measuredate_to = AV34TFBR_Vital_MeasureDate_To;
         AV90BR_VitalWWDS_11_Tfbr_vital_temperature = AV39TFBR_Vital_Temperature;
         AV91BR_VitalWWDS_12_Tfbr_vital_temperature_to = AV40TFBR_Vital_Temperature_To;
         AV92BR_VitalWWDS_13_Tfbr_vital_pulse = AV43TFBR_Vital_Pulse;
         AV93BR_VitalWWDS_14_Tfbr_vital_pulse_to = AV44TFBR_Vital_Pulse_To;
         AV94BR_VitalWWDS_15_Tfbr_vital_respiration = AV47TFBR_Vital_Respiration;
         AV95BR_VitalWWDS_16_Tfbr_vital_respiration_to = AV48TFBR_Vital_Respiration_To;
         AV96BR_VitalWWDS_17_Tfbr_vital_systolic = AV51TFBR_Vital_Systolic;
         AV97BR_VitalWWDS_18_Tfbr_vital_systolic_to = AV52TFBR_Vital_Systolic_To;
         AV98BR_VitalWWDS_19_Tfbr_vital_diastolic = AV55TFBR_Vital_Diastolic;
         AV99BR_VitalWWDS_20_Tfbr_vital_diastolic_to = AV56TFBR_Vital_Diastolic_To;
         AV100BR_VitalWWDS_21_Tfbr_vital_height = AV59TFBR_Vital_Height;
         AV101BR_VitalWWDS_22_Tfbr_vital_height_to = AV60TFBR_Vital_Height_To;
         AV102BR_VitalWWDS_23_Tfbr_vital_weight = AV63TFBR_Vital_Weight;
         AV103BR_VitalWWDS_24_Tfbr_vital_weight_to = AV64TFBR_Vital_Weight_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_VitalID, AV18TFBR_VitalID_To, AV21TFBR_EncounterID, AV22TFBR_EncounterID_To, AV25TFBR_Information_PatientNo, AV26TFBR_Information_PatientNo_Sel, AV29TFBR_Vital_VitalID, AV30TFBR_Vital_VitalID_To, AV33TFBR_Vital_MeasureDate, AV34TFBR_Vital_MeasureDate_To, AV39TFBR_Vital_Temperature, AV40TFBR_Vital_Temperature_To, AV43TFBR_Vital_Pulse, AV44TFBR_Vital_Pulse_To, AV47TFBR_Vital_Respiration, AV48TFBR_Vital_Respiration_To, AV51TFBR_Vital_Systolic, AV52TFBR_Vital_Systolic_To, AV55TFBR_Vital_Diastolic, AV56TFBR_Vital_Diastolic_To, AV59TFBR_Vital_Height, AV60TFBR_Vital_Height_To, AV63TFBR_Vital_Weight, AV64TFBR_Vital_Weight_To, AV19ddo_BR_VitalIDTitleControlIdToReplace, AV23ddo_BR_EncounterIDTitleControlIdToReplace, AV27ddo_BR_Information_PatientNoTitleControlIdToReplace, AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace, AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace, AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace, AV45ddo_BR_Vital_PulseTitleControlIdToReplace, AV49ddo_BR_Vital_RespirationTitleControlIdToReplace, AV53ddo_BR_Vital_SystolicTitleControlIdToReplace, AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace, AV61ddo_BR_Vital_HeightTitleControlIdToReplace, AV65ddo_BR_Vital_WeightTitleControlIdToReplace, AV107Pgmname, AV73IsAuthorized_Update, AV75IsAuthorized_Delete, AV76IsAuthorized_BR_Information_PatientNo) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP5Y0( )
      {
         /* Before Start, stand alone formulas. */
         AV107Pgmname = "BR_VitalWW";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E265Y2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV66DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_VITALIDTITLEFILTERDATA"), AV16BR_VitalIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTERIDTITLEFILTERDATA"), AV20BR_EncounterIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_INFORMATION_PATIENTNOTITLEFILTERDATA"), AV24BR_Information_PatientNoTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_VITAL_VITALIDTITLEFILTERDATA"), AV28BR_Vital_VitalIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_VITAL_MEASUREDATETITLEFILTERDATA"), AV32BR_Vital_MeasureDateTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_VITAL_TEMPERATURETITLEFILTERDATA"), AV38BR_Vital_TemperatureTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_VITAL_PULSETITLEFILTERDATA"), AV42BR_Vital_PulseTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_VITAL_RESPIRATIONTITLEFILTERDATA"), AV46BR_Vital_RespirationTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_VITAL_SYSTOLICTITLEFILTERDATA"), AV50BR_Vital_SystolicTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_VITAL_DIASTOLICTITLEFILTERDATA"), AV54BR_Vital_DiastolicTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_VITAL_HEIGHTTITLEFILTERDATA"), AV58BR_Vital_HeightTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_VITAL_WEIGHTTITLEFILTERDATA"), AV62BR_Vital_WeightTitleFilterData);
            /* Read variables values. */
            AV19ddo_BR_VitalIDTitleControlIdToReplace = cgiGet( edtavDdo_br_vitalidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_VitalIDTitleControlIdToReplace", AV19ddo_BR_VitalIDTitleControlIdToReplace);
            AV23ddo_BR_EncounterIDTitleControlIdToReplace = cgiGet( edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_EncounterIDTitleControlIdToReplace", AV23ddo_BR_EncounterIDTitleControlIdToReplace);
            AV27ddo_BR_Information_PatientNoTitleControlIdToReplace = cgiGet( edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_Information_PatientNoTitleControlIdToReplace", AV27ddo_BR_Information_PatientNoTitleControlIdToReplace);
            AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace = cgiGet( edtavDdo_br_vital_vitalidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace", AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace);
            AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace = cgiGet( edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace", AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace);
            AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace = cgiGet( edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace", AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace);
            AV45ddo_BR_Vital_PulseTitleControlIdToReplace = cgiGet( edtavDdo_br_vital_pulsetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45ddo_BR_Vital_PulseTitleControlIdToReplace", AV45ddo_BR_Vital_PulseTitleControlIdToReplace);
            AV49ddo_BR_Vital_RespirationTitleControlIdToReplace = cgiGet( edtavDdo_br_vital_respirationtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49ddo_BR_Vital_RespirationTitleControlIdToReplace", AV49ddo_BR_Vital_RespirationTitleControlIdToReplace);
            AV53ddo_BR_Vital_SystolicTitleControlIdToReplace = cgiGet( edtavDdo_br_vital_systolictitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV53ddo_BR_Vital_SystolicTitleControlIdToReplace", AV53ddo_BR_Vital_SystolicTitleControlIdToReplace);
            AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace = cgiGet( edtavDdo_br_vital_diastolictitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace", AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace);
            AV61ddo_BR_Vital_HeightTitleControlIdToReplace = cgiGet( edtavDdo_br_vital_heighttitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV61ddo_BR_Vital_HeightTitleControlIdToReplace", AV61ddo_BR_Vital_HeightTitleControlIdToReplace);
            AV65ddo_BR_Vital_WeightTitleControlIdToReplace = cgiGet( edtavDdo_br_vital_weighttitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV65ddo_BR_Vital_WeightTitleControlIdToReplace", AV65ddo_BR_Vital_WeightTitleControlIdToReplace);
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
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vitalid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vitalid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_VITALID");
               GX_FocusControl = edtavTfbr_vitalid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV17TFBR_VitalID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_VitalID), 18, 0)));
            }
            else
            {
               AV17TFBR_VitalID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_vitalid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_VitalID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vitalid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vitalid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_VITALID_TO");
               GX_FocusControl = edtavTfbr_vitalid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV18TFBR_VitalID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_VitalID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_VitalID_To), 18, 0)));
            }
            else
            {
               AV18TFBR_VitalID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_vitalid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_VitalID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_VitalID_To), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_ENCOUNTERID");
               GX_FocusControl = edtavTfbr_encounterid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV21TFBR_EncounterID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_EncounterID), 18, 0)));
            }
            else
            {
               AV21TFBR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_EncounterID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_ENCOUNTERID_TO");
               GX_FocusControl = edtavTfbr_encounterid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV22TFBR_EncounterID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_EncounterID_To), 18, 0)));
            }
            else
            {
               AV22TFBR_EncounterID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_EncounterID_To), 18, 0)));
            }
            AV25TFBR_Information_PatientNo = cgiGet( edtavTfbr_information_patientno_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_Information_PatientNo", AV25TFBR_Information_PatientNo);
            AV26TFBR_Information_PatientNo_Sel = cgiGet( edtavTfbr_information_patientno_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_Information_PatientNo_Sel", AV26TFBR_Information_PatientNo_Sel);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_vitalid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_vitalid_Internalname), ".", ",") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_VITAL_VITALID");
               GX_FocusControl = edtavTfbr_vital_vitalid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV29TFBR_Vital_VitalID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_Vital_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29TFBR_Vital_VitalID), 10, 0)));
            }
            else
            {
               AV29TFBR_Vital_VitalID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_vital_vitalid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_Vital_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29TFBR_Vital_VitalID), 10, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_vitalid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_vitalid_to_Internalname), ".", ",") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_VITAL_VITALID_TO");
               GX_FocusControl = edtavTfbr_vital_vitalid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV30TFBR_Vital_VitalID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_Vital_VitalID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30TFBR_Vital_VitalID_To), 10, 0)));
            }
            else
            {
               AV30TFBR_Vital_VitalID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_vital_vitalid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_Vital_VitalID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30TFBR_Vital_VitalID_To), 10, 0)));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavTfbr_vital_measuredate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TFBR_Vital_Measure Date"}), 1, "vTFBR_VITAL_MEASUREDATE");
               GX_FocusControl = edtavTfbr_vital_measuredate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV33TFBR_Vital_MeasureDate = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TFBR_Vital_MeasureDate", context.localUtil.Format(AV33TFBR_Vital_MeasureDate, "9999/99/99"));
            }
            else
            {
               AV33TFBR_Vital_MeasureDate = context.localUtil.CToD( cgiGet( edtavTfbr_vital_measuredate_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TFBR_Vital_MeasureDate", context.localUtil.Format(AV33TFBR_Vital_MeasureDate, "9999/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavTfbr_vital_measuredate_to_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TFBR_Vital_Measure Date_To"}), 1, "vTFBR_VITAL_MEASUREDATE_TO");
               GX_FocusControl = edtavTfbr_vital_measuredate_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV34TFBR_Vital_MeasureDate_To = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFBR_Vital_MeasureDate_To", context.localUtil.Format(AV34TFBR_Vital_MeasureDate_To, "9999/99/99"));
            }
            else
            {
               AV34TFBR_Vital_MeasureDate_To = context.localUtil.CToD( cgiGet( edtavTfbr_vital_measuredate_to_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFBR_Vital_MeasureDate_To", context.localUtil.Format(AV34TFBR_Vital_MeasureDate_To, "9999/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_br_vital_measuredateauxdate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_BR_Vital_Measure Date Aux Date"}), 1, "vDDO_BR_VITAL_MEASUREDATEAUXDATE");
               GX_FocusControl = edtavDdo_br_vital_measuredateauxdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV35DDO_BR_Vital_MeasureDateAuxDate = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35DDO_BR_Vital_MeasureDateAuxDate", context.localUtil.Format(AV35DDO_BR_Vital_MeasureDateAuxDate, "9999/99/99"));
            }
            else
            {
               AV35DDO_BR_Vital_MeasureDateAuxDate = context.localUtil.CToD( cgiGet( edtavDdo_br_vital_measuredateauxdate_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35DDO_BR_Vital_MeasureDateAuxDate", context.localUtil.Format(AV35DDO_BR_Vital_MeasureDateAuxDate, "9999/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_br_vital_measuredateauxdateto_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_BR_Vital_Measure Date Aux Date To"}), 1, "vDDO_BR_VITAL_MEASUREDATEAUXDATETO");
               GX_FocusControl = edtavDdo_br_vital_measuredateauxdateto_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV36DDO_BR_Vital_MeasureDateAuxDateTo = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36DDO_BR_Vital_MeasureDateAuxDateTo", context.localUtil.Format(AV36DDO_BR_Vital_MeasureDateAuxDateTo, "9999/99/99"));
            }
            else
            {
               AV36DDO_BR_Vital_MeasureDateAuxDateTo = context.localUtil.CToD( cgiGet( edtavDdo_br_vital_measuredateauxdateto_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36DDO_BR_Vital_MeasureDateAuxDateTo", context.localUtil.Format(AV36DDO_BR_Vital_MeasureDateAuxDateTo, "9999/99/99"));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_temperature_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_temperature_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_VITAL_TEMPERATURE");
               GX_FocusControl = edtavTfbr_vital_temperature_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV39TFBR_Vital_Temperature = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39TFBR_Vital_Temperature", StringUtil.LTrim( StringUtil.Str( AV39TFBR_Vital_Temperature, 15, 5)));
            }
            else
            {
               AV39TFBR_Vital_Temperature = context.localUtil.CToN( cgiGet( edtavTfbr_vital_temperature_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39TFBR_Vital_Temperature", StringUtil.LTrim( StringUtil.Str( AV39TFBR_Vital_Temperature, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_temperature_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_temperature_to_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_VITAL_TEMPERATURE_TO");
               GX_FocusControl = edtavTfbr_vital_temperature_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV40TFBR_Vital_Temperature_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40TFBR_Vital_Temperature_To", StringUtil.LTrim( StringUtil.Str( AV40TFBR_Vital_Temperature_To, 15, 5)));
            }
            else
            {
               AV40TFBR_Vital_Temperature_To = context.localUtil.CToN( cgiGet( edtavTfbr_vital_temperature_to_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40TFBR_Vital_Temperature_To", StringUtil.LTrim( StringUtil.Str( AV40TFBR_Vital_Temperature_To, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_pulse_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_pulse_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_VITAL_PULSE");
               GX_FocusControl = edtavTfbr_vital_pulse_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV43TFBR_Vital_Pulse = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43TFBR_Vital_Pulse", StringUtil.LTrim( StringUtil.Str( AV43TFBR_Vital_Pulse, 15, 5)));
            }
            else
            {
               AV43TFBR_Vital_Pulse = context.localUtil.CToN( cgiGet( edtavTfbr_vital_pulse_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43TFBR_Vital_Pulse", StringUtil.LTrim( StringUtil.Str( AV43TFBR_Vital_Pulse, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_pulse_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_pulse_to_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_VITAL_PULSE_TO");
               GX_FocusControl = edtavTfbr_vital_pulse_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV44TFBR_Vital_Pulse_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44TFBR_Vital_Pulse_To", StringUtil.LTrim( StringUtil.Str( AV44TFBR_Vital_Pulse_To, 15, 5)));
            }
            else
            {
               AV44TFBR_Vital_Pulse_To = context.localUtil.CToN( cgiGet( edtavTfbr_vital_pulse_to_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44TFBR_Vital_Pulse_To", StringUtil.LTrim( StringUtil.Str( AV44TFBR_Vital_Pulse_To, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_respiration_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_respiration_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_VITAL_RESPIRATION");
               GX_FocusControl = edtavTfbr_vital_respiration_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV47TFBR_Vital_Respiration = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47TFBR_Vital_Respiration", StringUtil.LTrim( StringUtil.Str( AV47TFBR_Vital_Respiration, 15, 5)));
            }
            else
            {
               AV47TFBR_Vital_Respiration = context.localUtil.CToN( cgiGet( edtavTfbr_vital_respiration_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47TFBR_Vital_Respiration", StringUtil.LTrim( StringUtil.Str( AV47TFBR_Vital_Respiration, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_respiration_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_respiration_to_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_VITAL_RESPIRATION_TO");
               GX_FocusControl = edtavTfbr_vital_respiration_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV48TFBR_Vital_Respiration_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48TFBR_Vital_Respiration_To", StringUtil.LTrim( StringUtil.Str( AV48TFBR_Vital_Respiration_To, 15, 5)));
            }
            else
            {
               AV48TFBR_Vital_Respiration_To = context.localUtil.CToN( cgiGet( edtavTfbr_vital_respiration_to_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48TFBR_Vital_Respiration_To", StringUtil.LTrim( StringUtil.Str( AV48TFBR_Vital_Respiration_To, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_systolic_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_systolic_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_VITAL_SYSTOLIC");
               GX_FocusControl = edtavTfbr_vital_systolic_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV51TFBR_Vital_Systolic = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51TFBR_Vital_Systolic", StringUtil.LTrim( StringUtil.Str( AV51TFBR_Vital_Systolic, 15, 5)));
            }
            else
            {
               AV51TFBR_Vital_Systolic = context.localUtil.CToN( cgiGet( edtavTfbr_vital_systolic_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51TFBR_Vital_Systolic", StringUtil.LTrim( StringUtil.Str( AV51TFBR_Vital_Systolic, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_systolic_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_systolic_to_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_VITAL_SYSTOLIC_TO");
               GX_FocusControl = edtavTfbr_vital_systolic_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV52TFBR_Vital_Systolic_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52TFBR_Vital_Systolic_To", StringUtil.LTrim( StringUtil.Str( AV52TFBR_Vital_Systolic_To, 15, 5)));
            }
            else
            {
               AV52TFBR_Vital_Systolic_To = context.localUtil.CToN( cgiGet( edtavTfbr_vital_systolic_to_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52TFBR_Vital_Systolic_To", StringUtil.LTrim( StringUtil.Str( AV52TFBR_Vital_Systolic_To, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_diastolic_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_diastolic_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_VITAL_DIASTOLIC");
               GX_FocusControl = edtavTfbr_vital_diastolic_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV55TFBR_Vital_Diastolic = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV55TFBR_Vital_Diastolic", StringUtil.LTrim( StringUtil.Str( AV55TFBR_Vital_Diastolic, 15, 5)));
            }
            else
            {
               AV55TFBR_Vital_Diastolic = context.localUtil.CToN( cgiGet( edtavTfbr_vital_diastolic_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV55TFBR_Vital_Diastolic", StringUtil.LTrim( StringUtil.Str( AV55TFBR_Vital_Diastolic, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_diastolic_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_diastolic_to_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_VITAL_DIASTOLIC_TO");
               GX_FocusControl = edtavTfbr_vital_diastolic_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV56TFBR_Vital_Diastolic_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56TFBR_Vital_Diastolic_To", StringUtil.LTrim( StringUtil.Str( AV56TFBR_Vital_Diastolic_To, 15, 5)));
            }
            else
            {
               AV56TFBR_Vital_Diastolic_To = context.localUtil.CToN( cgiGet( edtavTfbr_vital_diastolic_to_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56TFBR_Vital_Diastolic_To", StringUtil.LTrim( StringUtil.Str( AV56TFBR_Vital_Diastolic_To, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_height_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_height_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_VITAL_HEIGHT");
               GX_FocusControl = edtavTfbr_vital_height_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV59TFBR_Vital_Height = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59TFBR_Vital_Height", StringUtil.LTrim( StringUtil.Str( AV59TFBR_Vital_Height, 15, 5)));
            }
            else
            {
               AV59TFBR_Vital_Height = context.localUtil.CToN( cgiGet( edtavTfbr_vital_height_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59TFBR_Vital_Height", StringUtil.LTrim( StringUtil.Str( AV59TFBR_Vital_Height, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_height_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_height_to_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_VITAL_HEIGHT_TO");
               GX_FocusControl = edtavTfbr_vital_height_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV60TFBR_Vital_Height_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60TFBR_Vital_Height_To", StringUtil.LTrim( StringUtil.Str( AV60TFBR_Vital_Height_To, 15, 5)));
            }
            else
            {
               AV60TFBR_Vital_Height_To = context.localUtil.CToN( cgiGet( edtavTfbr_vital_height_to_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60TFBR_Vital_Height_To", StringUtil.LTrim( StringUtil.Str( AV60TFBR_Vital_Height_To, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_weight_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_weight_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_VITAL_WEIGHT");
               GX_FocusControl = edtavTfbr_vital_weight_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV63TFBR_Vital_Weight = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV63TFBR_Vital_Weight", StringUtil.LTrim( StringUtil.Str( AV63TFBR_Vital_Weight, 15, 5)));
            }
            else
            {
               AV63TFBR_Vital_Weight = context.localUtil.CToN( cgiGet( edtavTfbr_vital_weight_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV63TFBR_Vital_Weight", StringUtil.LTrim( StringUtil.Str( AV63TFBR_Vital_Weight, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_weight_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_weight_to_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_VITAL_WEIGHT_TO");
               GX_FocusControl = edtavTfbr_vital_weight_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV64TFBR_Vital_Weight_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV64TFBR_Vital_Weight_To", StringUtil.LTrim( StringUtil.Str( AV64TFBR_Vital_Weight_To, 15, 5)));
            }
            else
            {
               AV64TFBR_Vital_Weight_To = context.localUtil.CToN( cgiGet( edtavTfbr_vital_weight_to_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV64TFBR_Vital_Weight_To", StringUtil.LTrim( StringUtil.Str( AV64TFBR_Vital_Weight_To, 15, 5)));
            }
            /* Read saved values. */
            nRC_GXsfl_31 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_31"), ".", ","));
            AV68GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV70GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV69GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_vitalid_Caption = cgiGet( "DDO_BR_VITALID_Caption");
            Ddo_br_vitalid_Tooltip = cgiGet( "DDO_BR_VITALID_Tooltip");
            Ddo_br_vitalid_Cls = cgiGet( "DDO_BR_VITALID_Cls");
            Ddo_br_vitalid_Filteredtext_set = cgiGet( "DDO_BR_VITALID_Filteredtext_set");
            Ddo_br_vitalid_Filteredtextto_set = cgiGet( "DDO_BR_VITALID_Filteredtextto_set");
            Ddo_br_vitalid_Dropdownoptionstype = cgiGet( "DDO_BR_VITALID_Dropdownoptionstype");
            Ddo_br_vitalid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_VITALID_Titlecontrolidtoreplace");
            Ddo_br_vitalid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITALID_Includesortasc"));
            Ddo_br_vitalid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITALID_Includesortdsc"));
            Ddo_br_vitalid_Sortedstatus = cgiGet( "DDO_BR_VITALID_Sortedstatus");
            Ddo_br_vitalid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_VITALID_Includefilter"));
            Ddo_br_vitalid_Filtertype = cgiGet( "DDO_BR_VITALID_Filtertype");
            Ddo_br_vitalid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_VITALID_Filterisrange"));
            Ddo_br_vitalid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_VITALID_Includedatalist"));
            Ddo_br_vitalid_Sortasc = cgiGet( "DDO_BR_VITALID_Sortasc");
            Ddo_br_vitalid_Sortdsc = cgiGet( "DDO_BR_VITALID_Sortdsc");
            Ddo_br_vitalid_Cleanfilter = cgiGet( "DDO_BR_VITALID_Cleanfilter");
            Ddo_br_vitalid_Rangefilterfrom = cgiGet( "DDO_BR_VITALID_Rangefilterfrom");
            Ddo_br_vitalid_Rangefilterto = cgiGet( "DDO_BR_VITALID_Rangefilterto");
            Ddo_br_vitalid_Searchbuttontext = cgiGet( "DDO_BR_VITALID_Searchbuttontext");
            Ddo_br_encounterid_Caption = cgiGet( "DDO_BR_ENCOUNTERID_Caption");
            Ddo_br_encounterid_Tooltip = cgiGet( "DDO_BR_ENCOUNTERID_Tooltip");
            Ddo_br_encounterid_Cls = cgiGet( "DDO_BR_ENCOUNTERID_Cls");
            Ddo_br_encounterid_Filteredtext_set = cgiGet( "DDO_BR_ENCOUNTERID_Filteredtext_set");
            Ddo_br_encounterid_Filteredtextto_set = cgiGet( "DDO_BR_ENCOUNTERID_Filteredtextto_set");
            Ddo_br_encounterid_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTERID_Dropdownoptionstype");
            Ddo_br_encounterid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTERID_Titlecontrolidtoreplace");
            Ddo_br_encounterid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Includesortasc"));
            Ddo_br_encounterid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Includesortdsc"));
            Ddo_br_encounterid_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTERID_Sortedstatus");
            Ddo_br_encounterid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Includefilter"));
            Ddo_br_encounterid_Filtertype = cgiGet( "DDO_BR_ENCOUNTERID_Filtertype");
            Ddo_br_encounterid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Filterisrange"));
            Ddo_br_encounterid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Includedatalist"));
            Ddo_br_encounterid_Sortasc = cgiGet( "DDO_BR_ENCOUNTERID_Sortasc");
            Ddo_br_encounterid_Sortdsc = cgiGet( "DDO_BR_ENCOUNTERID_Sortdsc");
            Ddo_br_encounterid_Cleanfilter = cgiGet( "DDO_BR_ENCOUNTERID_Cleanfilter");
            Ddo_br_encounterid_Rangefilterfrom = cgiGet( "DDO_BR_ENCOUNTERID_Rangefilterfrom");
            Ddo_br_encounterid_Rangefilterto = cgiGet( "DDO_BR_ENCOUNTERID_Rangefilterto");
            Ddo_br_encounterid_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTERID_Searchbuttontext");
            Ddo_br_information_patientno_Caption = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Caption");
            Ddo_br_information_patientno_Tooltip = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Tooltip");
            Ddo_br_information_patientno_Cls = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Cls");
            Ddo_br_information_patientno_Filteredtext_set = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Filteredtext_set");
            Ddo_br_information_patientno_Selectedvalue_set = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Selectedvalue_set");
            Ddo_br_information_patientno_Dropdownoptionstype = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Dropdownoptionstype");
            Ddo_br_information_patientno_Titlecontrolidtoreplace = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Titlecontrolidtoreplace");
            Ddo_br_information_patientno_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Includesortasc"));
            Ddo_br_information_patientno_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Includesortdsc"));
            Ddo_br_information_patientno_Sortedstatus = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Sortedstatus");
            Ddo_br_information_patientno_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Includefilter"));
            Ddo_br_information_patientno_Filtertype = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Filtertype");
            Ddo_br_information_patientno_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Filterisrange"));
            Ddo_br_information_patientno_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Includedatalist"));
            Ddo_br_information_patientno_Datalisttype = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Datalisttype");
            Ddo_br_information_patientno_Datalistproc = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Datalistproc");
            Ddo_br_information_patientno_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_information_patientno_Sortasc = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Sortasc");
            Ddo_br_information_patientno_Sortdsc = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Sortdsc");
            Ddo_br_information_patientno_Loadingdata = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Loadingdata");
            Ddo_br_information_patientno_Cleanfilter = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Cleanfilter");
            Ddo_br_information_patientno_Noresultsfound = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Noresultsfound");
            Ddo_br_information_patientno_Searchbuttontext = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Searchbuttontext");
            Ddo_br_vital_vitalid_Caption = cgiGet( "DDO_BR_VITAL_VITALID_Caption");
            Ddo_br_vital_vitalid_Tooltip = cgiGet( "DDO_BR_VITAL_VITALID_Tooltip");
            Ddo_br_vital_vitalid_Cls = cgiGet( "DDO_BR_VITAL_VITALID_Cls");
            Ddo_br_vital_vitalid_Filteredtext_set = cgiGet( "DDO_BR_VITAL_VITALID_Filteredtext_set");
            Ddo_br_vital_vitalid_Filteredtextto_set = cgiGet( "DDO_BR_VITAL_VITALID_Filteredtextto_set");
            Ddo_br_vital_vitalid_Dropdownoptionstype = cgiGet( "DDO_BR_VITAL_VITALID_Dropdownoptionstype");
            Ddo_br_vital_vitalid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_VITAL_VITALID_Titlecontrolidtoreplace");
            Ddo_br_vital_vitalid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_VITALID_Includesortasc"));
            Ddo_br_vital_vitalid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_VITALID_Includesortdsc"));
            Ddo_br_vital_vitalid_Sortedstatus = cgiGet( "DDO_BR_VITAL_VITALID_Sortedstatus");
            Ddo_br_vital_vitalid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_VITALID_Includefilter"));
            Ddo_br_vital_vitalid_Filtertype = cgiGet( "DDO_BR_VITAL_VITALID_Filtertype");
            Ddo_br_vital_vitalid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_VITALID_Filterisrange"));
            Ddo_br_vital_vitalid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_VITALID_Includedatalist"));
            Ddo_br_vital_vitalid_Sortasc = cgiGet( "DDO_BR_VITAL_VITALID_Sortasc");
            Ddo_br_vital_vitalid_Sortdsc = cgiGet( "DDO_BR_VITAL_VITALID_Sortdsc");
            Ddo_br_vital_vitalid_Cleanfilter = cgiGet( "DDO_BR_VITAL_VITALID_Cleanfilter");
            Ddo_br_vital_vitalid_Rangefilterfrom = cgiGet( "DDO_BR_VITAL_VITALID_Rangefilterfrom");
            Ddo_br_vital_vitalid_Rangefilterto = cgiGet( "DDO_BR_VITAL_VITALID_Rangefilterto");
            Ddo_br_vital_vitalid_Searchbuttontext = cgiGet( "DDO_BR_VITAL_VITALID_Searchbuttontext");
            Ddo_br_vital_measuredate_Caption = cgiGet( "DDO_BR_VITAL_MEASUREDATE_Caption");
            Ddo_br_vital_measuredate_Tooltip = cgiGet( "DDO_BR_VITAL_MEASUREDATE_Tooltip");
            Ddo_br_vital_measuredate_Cls = cgiGet( "DDO_BR_VITAL_MEASUREDATE_Cls");
            Ddo_br_vital_measuredate_Filteredtext_set = cgiGet( "DDO_BR_VITAL_MEASUREDATE_Filteredtext_set");
            Ddo_br_vital_measuredate_Filteredtextto_set = cgiGet( "DDO_BR_VITAL_MEASUREDATE_Filteredtextto_set");
            Ddo_br_vital_measuredate_Dropdownoptionstype = cgiGet( "DDO_BR_VITAL_MEASUREDATE_Dropdownoptionstype");
            Ddo_br_vital_measuredate_Titlecontrolidtoreplace = cgiGet( "DDO_BR_VITAL_MEASUREDATE_Titlecontrolidtoreplace");
            Ddo_br_vital_measuredate_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_MEASUREDATE_Includesortasc"));
            Ddo_br_vital_measuredate_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_MEASUREDATE_Includesortdsc"));
            Ddo_br_vital_measuredate_Sortedstatus = cgiGet( "DDO_BR_VITAL_MEASUREDATE_Sortedstatus");
            Ddo_br_vital_measuredate_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_MEASUREDATE_Includefilter"));
            Ddo_br_vital_measuredate_Filtertype = cgiGet( "DDO_BR_VITAL_MEASUREDATE_Filtertype");
            Ddo_br_vital_measuredate_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_MEASUREDATE_Filterisrange"));
            Ddo_br_vital_measuredate_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_MEASUREDATE_Includedatalist"));
            Ddo_br_vital_measuredate_Sortasc = cgiGet( "DDO_BR_VITAL_MEASUREDATE_Sortasc");
            Ddo_br_vital_measuredate_Sortdsc = cgiGet( "DDO_BR_VITAL_MEASUREDATE_Sortdsc");
            Ddo_br_vital_measuredate_Cleanfilter = cgiGet( "DDO_BR_VITAL_MEASUREDATE_Cleanfilter");
            Ddo_br_vital_measuredate_Rangefilterfrom = cgiGet( "DDO_BR_VITAL_MEASUREDATE_Rangefilterfrom");
            Ddo_br_vital_measuredate_Rangefilterto = cgiGet( "DDO_BR_VITAL_MEASUREDATE_Rangefilterto");
            Ddo_br_vital_measuredate_Searchbuttontext = cgiGet( "DDO_BR_VITAL_MEASUREDATE_Searchbuttontext");
            Ddo_br_vital_temperature_Caption = cgiGet( "DDO_BR_VITAL_TEMPERATURE_Caption");
            Ddo_br_vital_temperature_Tooltip = cgiGet( "DDO_BR_VITAL_TEMPERATURE_Tooltip");
            Ddo_br_vital_temperature_Cls = cgiGet( "DDO_BR_VITAL_TEMPERATURE_Cls");
            Ddo_br_vital_temperature_Filteredtext_set = cgiGet( "DDO_BR_VITAL_TEMPERATURE_Filteredtext_set");
            Ddo_br_vital_temperature_Filteredtextto_set = cgiGet( "DDO_BR_VITAL_TEMPERATURE_Filteredtextto_set");
            Ddo_br_vital_temperature_Dropdownoptionstype = cgiGet( "DDO_BR_VITAL_TEMPERATURE_Dropdownoptionstype");
            Ddo_br_vital_temperature_Titlecontrolidtoreplace = cgiGet( "DDO_BR_VITAL_TEMPERATURE_Titlecontrolidtoreplace");
            Ddo_br_vital_temperature_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_TEMPERATURE_Includesortasc"));
            Ddo_br_vital_temperature_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_TEMPERATURE_Includesortdsc"));
            Ddo_br_vital_temperature_Sortedstatus = cgiGet( "DDO_BR_VITAL_TEMPERATURE_Sortedstatus");
            Ddo_br_vital_temperature_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_TEMPERATURE_Includefilter"));
            Ddo_br_vital_temperature_Filtertype = cgiGet( "DDO_BR_VITAL_TEMPERATURE_Filtertype");
            Ddo_br_vital_temperature_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_TEMPERATURE_Filterisrange"));
            Ddo_br_vital_temperature_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_TEMPERATURE_Includedatalist"));
            Ddo_br_vital_temperature_Sortasc = cgiGet( "DDO_BR_VITAL_TEMPERATURE_Sortasc");
            Ddo_br_vital_temperature_Sortdsc = cgiGet( "DDO_BR_VITAL_TEMPERATURE_Sortdsc");
            Ddo_br_vital_temperature_Cleanfilter = cgiGet( "DDO_BR_VITAL_TEMPERATURE_Cleanfilter");
            Ddo_br_vital_temperature_Rangefilterfrom = cgiGet( "DDO_BR_VITAL_TEMPERATURE_Rangefilterfrom");
            Ddo_br_vital_temperature_Rangefilterto = cgiGet( "DDO_BR_VITAL_TEMPERATURE_Rangefilterto");
            Ddo_br_vital_temperature_Searchbuttontext = cgiGet( "DDO_BR_VITAL_TEMPERATURE_Searchbuttontext");
            Ddo_br_vital_pulse_Caption = cgiGet( "DDO_BR_VITAL_PULSE_Caption");
            Ddo_br_vital_pulse_Tooltip = cgiGet( "DDO_BR_VITAL_PULSE_Tooltip");
            Ddo_br_vital_pulse_Cls = cgiGet( "DDO_BR_VITAL_PULSE_Cls");
            Ddo_br_vital_pulse_Filteredtext_set = cgiGet( "DDO_BR_VITAL_PULSE_Filteredtext_set");
            Ddo_br_vital_pulse_Filteredtextto_set = cgiGet( "DDO_BR_VITAL_PULSE_Filteredtextto_set");
            Ddo_br_vital_pulse_Dropdownoptionstype = cgiGet( "DDO_BR_VITAL_PULSE_Dropdownoptionstype");
            Ddo_br_vital_pulse_Titlecontrolidtoreplace = cgiGet( "DDO_BR_VITAL_PULSE_Titlecontrolidtoreplace");
            Ddo_br_vital_pulse_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_PULSE_Includesortasc"));
            Ddo_br_vital_pulse_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_PULSE_Includesortdsc"));
            Ddo_br_vital_pulse_Sortedstatus = cgiGet( "DDO_BR_VITAL_PULSE_Sortedstatus");
            Ddo_br_vital_pulse_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_PULSE_Includefilter"));
            Ddo_br_vital_pulse_Filtertype = cgiGet( "DDO_BR_VITAL_PULSE_Filtertype");
            Ddo_br_vital_pulse_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_PULSE_Filterisrange"));
            Ddo_br_vital_pulse_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_PULSE_Includedatalist"));
            Ddo_br_vital_pulse_Sortasc = cgiGet( "DDO_BR_VITAL_PULSE_Sortasc");
            Ddo_br_vital_pulse_Sortdsc = cgiGet( "DDO_BR_VITAL_PULSE_Sortdsc");
            Ddo_br_vital_pulse_Cleanfilter = cgiGet( "DDO_BR_VITAL_PULSE_Cleanfilter");
            Ddo_br_vital_pulse_Rangefilterfrom = cgiGet( "DDO_BR_VITAL_PULSE_Rangefilterfrom");
            Ddo_br_vital_pulse_Rangefilterto = cgiGet( "DDO_BR_VITAL_PULSE_Rangefilterto");
            Ddo_br_vital_pulse_Searchbuttontext = cgiGet( "DDO_BR_VITAL_PULSE_Searchbuttontext");
            Ddo_br_vital_respiration_Caption = cgiGet( "DDO_BR_VITAL_RESPIRATION_Caption");
            Ddo_br_vital_respiration_Tooltip = cgiGet( "DDO_BR_VITAL_RESPIRATION_Tooltip");
            Ddo_br_vital_respiration_Cls = cgiGet( "DDO_BR_VITAL_RESPIRATION_Cls");
            Ddo_br_vital_respiration_Filteredtext_set = cgiGet( "DDO_BR_VITAL_RESPIRATION_Filteredtext_set");
            Ddo_br_vital_respiration_Filteredtextto_set = cgiGet( "DDO_BR_VITAL_RESPIRATION_Filteredtextto_set");
            Ddo_br_vital_respiration_Dropdownoptionstype = cgiGet( "DDO_BR_VITAL_RESPIRATION_Dropdownoptionstype");
            Ddo_br_vital_respiration_Titlecontrolidtoreplace = cgiGet( "DDO_BR_VITAL_RESPIRATION_Titlecontrolidtoreplace");
            Ddo_br_vital_respiration_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_RESPIRATION_Includesortasc"));
            Ddo_br_vital_respiration_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_RESPIRATION_Includesortdsc"));
            Ddo_br_vital_respiration_Sortedstatus = cgiGet( "DDO_BR_VITAL_RESPIRATION_Sortedstatus");
            Ddo_br_vital_respiration_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_RESPIRATION_Includefilter"));
            Ddo_br_vital_respiration_Filtertype = cgiGet( "DDO_BR_VITAL_RESPIRATION_Filtertype");
            Ddo_br_vital_respiration_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_RESPIRATION_Filterisrange"));
            Ddo_br_vital_respiration_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_RESPIRATION_Includedatalist"));
            Ddo_br_vital_respiration_Sortasc = cgiGet( "DDO_BR_VITAL_RESPIRATION_Sortasc");
            Ddo_br_vital_respiration_Sortdsc = cgiGet( "DDO_BR_VITAL_RESPIRATION_Sortdsc");
            Ddo_br_vital_respiration_Cleanfilter = cgiGet( "DDO_BR_VITAL_RESPIRATION_Cleanfilter");
            Ddo_br_vital_respiration_Rangefilterfrom = cgiGet( "DDO_BR_VITAL_RESPIRATION_Rangefilterfrom");
            Ddo_br_vital_respiration_Rangefilterto = cgiGet( "DDO_BR_VITAL_RESPIRATION_Rangefilterto");
            Ddo_br_vital_respiration_Searchbuttontext = cgiGet( "DDO_BR_VITAL_RESPIRATION_Searchbuttontext");
            Ddo_br_vital_systolic_Caption = cgiGet( "DDO_BR_VITAL_SYSTOLIC_Caption");
            Ddo_br_vital_systolic_Tooltip = cgiGet( "DDO_BR_VITAL_SYSTOLIC_Tooltip");
            Ddo_br_vital_systolic_Cls = cgiGet( "DDO_BR_VITAL_SYSTOLIC_Cls");
            Ddo_br_vital_systolic_Filteredtext_set = cgiGet( "DDO_BR_VITAL_SYSTOLIC_Filteredtext_set");
            Ddo_br_vital_systolic_Filteredtextto_set = cgiGet( "DDO_BR_VITAL_SYSTOLIC_Filteredtextto_set");
            Ddo_br_vital_systolic_Dropdownoptionstype = cgiGet( "DDO_BR_VITAL_SYSTOLIC_Dropdownoptionstype");
            Ddo_br_vital_systolic_Titlecontrolidtoreplace = cgiGet( "DDO_BR_VITAL_SYSTOLIC_Titlecontrolidtoreplace");
            Ddo_br_vital_systolic_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_SYSTOLIC_Includesortasc"));
            Ddo_br_vital_systolic_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_SYSTOLIC_Includesortdsc"));
            Ddo_br_vital_systolic_Sortedstatus = cgiGet( "DDO_BR_VITAL_SYSTOLIC_Sortedstatus");
            Ddo_br_vital_systolic_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_SYSTOLIC_Includefilter"));
            Ddo_br_vital_systolic_Filtertype = cgiGet( "DDO_BR_VITAL_SYSTOLIC_Filtertype");
            Ddo_br_vital_systolic_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_SYSTOLIC_Filterisrange"));
            Ddo_br_vital_systolic_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_SYSTOLIC_Includedatalist"));
            Ddo_br_vital_systolic_Sortasc = cgiGet( "DDO_BR_VITAL_SYSTOLIC_Sortasc");
            Ddo_br_vital_systolic_Sortdsc = cgiGet( "DDO_BR_VITAL_SYSTOLIC_Sortdsc");
            Ddo_br_vital_systolic_Cleanfilter = cgiGet( "DDO_BR_VITAL_SYSTOLIC_Cleanfilter");
            Ddo_br_vital_systolic_Rangefilterfrom = cgiGet( "DDO_BR_VITAL_SYSTOLIC_Rangefilterfrom");
            Ddo_br_vital_systolic_Rangefilterto = cgiGet( "DDO_BR_VITAL_SYSTOLIC_Rangefilterto");
            Ddo_br_vital_systolic_Searchbuttontext = cgiGet( "DDO_BR_VITAL_SYSTOLIC_Searchbuttontext");
            Ddo_br_vital_diastolic_Caption = cgiGet( "DDO_BR_VITAL_DIASTOLIC_Caption");
            Ddo_br_vital_diastolic_Tooltip = cgiGet( "DDO_BR_VITAL_DIASTOLIC_Tooltip");
            Ddo_br_vital_diastolic_Cls = cgiGet( "DDO_BR_VITAL_DIASTOLIC_Cls");
            Ddo_br_vital_diastolic_Filteredtext_set = cgiGet( "DDO_BR_VITAL_DIASTOLIC_Filteredtext_set");
            Ddo_br_vital_diastolic_Filteredtextto_set = cgiGet( "DDO_BR_VITAL_DIASTOLIC_Filteredtextto_set");
            Ddo_br_vital_diastolic_Dropdownoptionstype = cgiGet( "DDO_BR_VITAL_DIASTOLIC_Dropdownoptionstype");
            Ddo_br_vital_diastolic_Titlecontrolidtoreplace = cgiGet( "DDO_BR_VITAL_DIASTOLIC_Titlecontrolidtoreplace");
            Ddo_br_vital_diastolic_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_DIASTOLIC_Includesortasc"));
            Ddo_br_vital_diastolic_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_DIASTOLIC_Includesortdsc"));
            Ddo_br_vital_diastolic_Sortedstatus = cgiGet( "DDO_BR_VITAL_DIASTOLIC_Sortedstatus");
            Ddo_br_vital_diastolic_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_DIASTOLIC_Includefilter"));
            Ddo_br_vital_diastolic_Filtertype = cgiGet( "DDO_BR_VITAL_DIASTOLIC_Filtertype");
            Ddo_br_vital_diastolic_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_DIASTOLIC_Filterisrange"));
            Ddo_br_vital_diastolic_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_DIASTOLIC_Includedatalist"));
            Ddo_br_vital_diastolic_Sortasc = cgiGet( "DDO_BR_VITAL_DIASTOLIC_Sortasc");
            Ddo_br_vital_diastolic_Sortdsc = cgiGet( "DDO_BR_VITAL_DIASTOLIC_Sortdsc");
            Ddo_br_vital_diastolic_Cleanfilter = cgiGet( "DDO_BR_VITAL_DIASTOLIC_Cleanfilter");
            Ddo_br_vital_diastolic_Rangefilterfrom = cgiGet( "DDO_BR_VITAL_DIASTOLIC_Rangefilterfrom");
            Ddo_br_vital_diastolic_Rangefilterto = cgiGet( "DDO_BR_VITAL_DIASTOLIC_Rangefilterto");
            Ddo_br_vital_diastolic_Searchbuttontext = cgiGet( "DDO_BR_VITAL_DIASTOLIC_Searchbuttontext");
            Ddo_br_vital_height_Caption = cgiGet( "DDO_BR_VITAL_HEIGHT_Caption");
            Ddo_br_vital_height_Tooltip = cgiGet( "DDO_BR_VITAL_HEIGHT_Tooltip");
            Ddo_br_vital_height_Cls = cgiGet( "DDO_BR_VITAL_HEIGHT_Cls");
            Ddo_br_vital_height_Filteredtext_set = cgiGet( "DDO_BR_VITAL_HEIGHT_Filteredtext_set");
            Ddo_br_vital_height_Filteredtextto_set = cgiGet( "DDO_BR_VITAL_HEIGHT_Filteredtextto_set");
            Ddo_br_vital_height_Dropdownoptionstype = cgiGet( "DDO_BR_VITAL_HEIGHT_Dropdownoptionstype");
            Ddo_br_vital_height_Titlecontrolidtoreplace = cgiGet( "DDO_BR_VITAL_HEIGHT_Titlecontrolidtoreplace");
            Ddo_br_vital_height_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_HEIGHT_Includesortasc"));
            Ddo_br_vital_height_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_HEIGHT_Includesortdsc"));
            Ddo_br_vital_height_Sortedstatus = cgiGet( "DDO_BR_VITAL_HEIGHT_Sortedstatus");
            Ddo_br_vital_height_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_HEIGHT_Includefilter"));
            Ddo_br_vital_height_Filtertype = cgiGet( "DDO_BR_VITAL_HEIGHT_Filtertype");
            Ddo_br_vital_height_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_HEIGHT_Filterisrange"));
            Ddo_br_vital_height_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_HEIGHT_Includedatalist"));
            Ddo_br_vital_height_Sortasc = cgiGet( "DDO_BR_VITAL_HEIGHT_Sortasc");
            Ddo_br_vital_height_Sortdsc = cgiGet( "DDO_BR_VITAL_HEIGHT_Sortdsc");
            Ddo_br_vital_height_Cleanfilter = cgiGet( "DDO_BR_VITAL_HEIGHT_Cleanfilter");
            Ddo_br_vital_height_Rangefilterfrom = cgiGet( "DDO_BR_VITAL_HEIGHT_Rangefilterfrom");
            Ddo_br_vital_height_Rangefilterto = cgiGet( "DDO_BR_VITAL_HEIGHT_Rangefilterto");
            Ddo_br_vital_height_Searchbuttontext = cgiGet( "DDO_BR_VITAL_HEIGHT_Searchbuttontext");
            Ddo_br_vital_weight_Caption = cgiGet( "DDO_BR_VITAL_WEIGHT_Caption");
            Ddo_br_vital_weight_Tooltip = cgiGet( "DDO_BR_VITAL_WEIGHT_Tooltip");
            Ddo_br_vital_weight_Cls = cgiGet( "DDO_BR_VITAL_WEIGHT_Cls");
            Ddo_br_vital_weight_Filteredtext_set = cgiGet( "DDO_BR_VITAL_WEIGHT_Filteredtext_set");
            Ddo_br_vital_weight_Filteredtextto_set = cgiGet( "DDO_BR_VITAL_WEIGHT_Filteredtextto_set");
            Ddo_br_vital_weight_Dropdownoptionstype = cgiGet( "DDO_BR_VITAL_WEIGHT_Dropdownoptionstype");
            Ddo_br_vital_weight_Titlecontrolidtoreplace = cgiGet( "DDO_BR_VITAL_WEIGHT_Titlecontrolidtoreplace");
            Ddo_br_vital_weight_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_WEIGHT_Includesortasc"));
            Ddo_br_vital_weight_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_WEIGHT_Includesortdsc"));
            Ddo_br_vital_weight_Sortedstatus = cgiGet( "DDO_BR_VITAL_WEIGHT_Sortedstatus");
            Ddo_br_vital_weight_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_WEIGHT_Includefilter"));
            Ddo_br_vital_weight_Filtertype = cgiGet( "DDO_BR_VITAL_WEIGHT_Filtertype");
            Ddo_br_vital_weight_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_WEIGHT_Filterisrange"));
            Ddo_br_vital_weight_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_WEIGHT_Includedatalist"));
            Ddo_br_vital_weight_Sortasc = cgiGet( "DDO_BR_VITAL_WEIGHT_Sortasc");
            Ddo_br_vital_weight_Sortdsc = cgiGet( "DDO_BR_VITAL_WEIGHT_Sortdsc");
            Ddo_br_vital_weight_Cleanfilter = cgiGet( "DDO_BR_VITAL_WEIGHT_Cleanfilter");
            Ddo_br_vital_weight_Rangefilterfrom = cgiGet( "DDO_BR_VITAL_WEIGHT_Rangefilterfrom");
            Ddo_br_vital_weight_Rangefilterto = cgiGet( "DDO_BR_VITAL_WEIGHT_Rangefilterto");
            Ddo_br_vital_weight_Searchbuttontext = cgiGet( "DDO_BR_VITAL_WEIGHT_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_vitalid_Activeeventkey = cgiGet( "DDO_BR_VITALID_Activeeventkey");
            Ddo_br_vitalid_Filteredtext_get = cgiGet( "DDO_BR_VITALID_Filteredtext_get");
            Ddo_br_vitalid_Filteredtextto_get = cgiGet( "DDO_BR_VITALID_Filteredtextto_get");
            Ddo_br_encounterid_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTERID_Activeeventkey");
            Ddo_br_encounterid_Filteredtext_get = cgiGet( "DDO_BR_ENCOUNTERID_Filteredtext_get");
            Ddo_br_encounterid_Filteredtextto_get = cgiGet( "DDO_BR_ENCOUNTERID_Filteredtextto_get");
            Ddo_br_information_patientno_Activeeventkey = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey");
            Ddo_br_information_patientno_Filteredtext_get = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Filteredtext_get");
            Ddo_br_information_patientno_Selectedvalue_get = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Selectedvalue_get");
            Ddo_br_vital_vitalid_Activeeventkey = cgiGet( "DDO_BR_VITAL_VITALID_Activeeventkey");
            Ddo_br_vital_vitalid_Filteredtext_get = cgiGet( "DDO_BR_VITAL_VITALID_Filteredtext_get");
            Ddo_br_vital_vitalid_Filteredtextto_get = cgiGet( "DDO_BR_VITAL_VITALID_Filteredtextto_get");
            Ddo_br_vital_measuredate_Activeeventkey = cgiGet( "DDO_BR_VITAL_MEASUREDATE_Activeeventkey");
            Ddo_br_vital_measuredate_Filteredtext_get = cgiGet( "DDO_BR_VITAL_MEASUREDATE_Filteredtext_get");
            Ddo_br_vital_measuredate_Filteredtextto_get = cgiGet( "DDO_BR_VITAL_MEASUREDATE_Filteredtextto_get");
            Ddo_br_vital_temperature_Activeeventkey = cgiGet( "DDO_BR_VITAL_TEMPERATURE_Activeeventkey");
            Ddo_br_vital_temperature_Filteredtext_get = cgiGet( "DDO_BR_VITAL_TEMPERATURE_Filteredtext_get");
            Ddo_br_vital_temperature_Filteredtextto_get = cgiGet( "DDO_BR_VITAL_TEMPERATURE_Filteredtextto_get");
            Ddo_br_vital_pulse_Activeeventkey = cgiGet( "DDO_BR_VITAL_PULSE_Activeeventkey");
            Ddo_br_vital_pulse_Filteredtext_get = cgiGet( "DDO_BR_VITAL_PULSE_Filteredtext_get");
            Ddo_br_vital_pulse_Filteredtextto_get = cgiGet( "DDO_BR_VITAL_PULSE_Filteredtextto_get");
            Ddo_br_vital_respiration_Activeeventkey = cgiGet( "DDO_BR_VITAL_RESPIRATION_Activeeventkey");
            Ddo_br_vital_respiration_Filteredtext_get = cgiGet( "DDO_BR_VITAL_RESPIRATION_Filteredtext_get");
            Ddo_br_vital_respiration_Filteredtextto_get = cgiGet( "DDO_BR_VITAL_RESPIRATION_Filteredtextto_get");
            Ddo_br_vital_systolic_Activeeventkey = cgiGet( "DDO_BR_VITAL_SYSTOLIC_Activeeventkey");
            Ddo_br_vital_systolic_Filteredtext_get = cgiGet( "DDO_BR_VITAL_SYSTOLIC_Filteredtext_get");
            Ddo_br_vital_systolic_Filteredtextto_get = cgiGet( "DDO_BR_VITAL_SYSTOLIC_Filteredtextto_get");
            Ddo_br_vital_diastolic_Activeeventkey = cgiGet( "DDO_BR_VITAL_DIASTOLIC_Activeeventkey");
            Ddo_br_vital_diastolic_Filteredtext_get = cgiGet( "DDO_BR_VITAL_DIASTOLIC_Filteredtext_get");
            Ddo_br_vital_diastolic_Filteredtextto_get = cgiGet( "DDO_BR_VITAL_DIASTOLIC_Filteredtextto_get");
            Ddo_br_vital_height_Activeeventkey = cgiGet( "DDO_BR_VITAL_HEIGHT_Activeeventkey");
            Ddo_br_vital_height_Filteredtext_get = cgiGet( "DDO_BR_VITAL_HEIGHT_Filteredtext_get");
            Ddo_br_vital_height_Filteredtextto_get = cgiGet( "DDO_BR_VITAL_HEIGHT_Filteredtextto_get");
            Ddo_br_vital_weight_Activeeventkey = cgiGet( "DDO_BR_VITAL_WEIGHT_Activeeventkey");
            Ddo_br_vital_weight_Filteredtext_get = cgiGet( "DDO_BR_VITAL_WEIGHT_Filteredtext_get");
            Ddo_br_vital_weight_Filteredtextto_get = cgiGet( "DDO_BR_VITAL_WEIGHT_Filteredtextto_get");
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
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITALID"), ".", ",") != Convert.ToDecimal( AV17TFBR_VitalID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITALID_TO"), ".", ",") != Convert.ToDecimal( AV18TFBR_VitalID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_ENCOUNTERID"), ".", ",") != Convert.ToDecimal( AV21TFBR_EncounterID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_ENCOUNTERID_TO"), ".", ",") != Convert.ToDecimal( AV22TFBR_EncounterID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_INFORMATION_PATIENTNO"), AV25TFBR_Information_PatientNo) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_INFORMATION_PATIENTNO_SEL"), AV26TFBR_Information_PatientNo_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_VITALID"), ".", ",") != Convert.ToDecimal( AV29TFBR_Vital_VitalID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_VITALID_TO"), ".", ",") != Convert.ToDecimal( AV30TFBR_Vital_VitalID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vTFBR_VITAL_MEASUREDATE"), 0) != AV33TFBR_Vital_MeasureDate )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vTFBR_VITAL_MEASUREDATE_TO"), 0) != AV34TFBR_Vital_MeasureDate_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_TEMPERATURE"), ".", ",") != AV39TFBR_Vital_Temperature )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_TEMPERATURE_TO"), ".", ",") != AV40TFBR_Vital_Temperature_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_PULSE"), ".", ",") != AV43TFBR_Vital_Pulse )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_PULSE_TO"), ".", ",") != AV44TFBR_Vital_Pulse_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_RESPIRATION"), ".", ",") != AV47TFBR_Vital_Respiration )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_RESPIRATION_TO"), ".", ",") != AV48TFBR_Vital_Respiration_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_SYSTOLIC"), ".", ",") != AV51TFBR_Vital_Systolic )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_SYSTOLIC_TO"), ".", ",") != AV52TFBR_Vital_Systolic_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_DIASTOLIC"), ".", ",") != AV55TFBR_Vital_Diastolic )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_DIASTOLIC_TO"), ".", ",") != AV56TFBR_Vital_Diastolic_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_HEIGHT"), ".", ",") != AV59TFBR_Vital_Height )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_HEIGHT_TO"), ".", ",") != AV60TFBR_Vital_Height_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_WEIGHT"), ".", ",") != AV63TFBR_Vital_Weight )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_VITAL_WEIGHT_TO"), ".", ",") != AV64TFBR_Vital_Weight_To )
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
         E265Y2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E265Y2( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GXt_boolean1 = AV76IsAuthorized_BR_Information_PatientNo;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Information", out  GXt_boolean1) ;
         AV76IsAuthorized_BR_Information_PatientNo = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV76IsAuthorized_BR_Information_PatientNo", AV76IsAuthorized_BR_Information_PatientNo);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vISAUTHORIZED_BR_INFORMATION_PATIENTNO", GetSecureSignedToken( "", AV76IsAuthorized_BR_Information_PatientNo, context));
         edtavTfbr_vitalid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_vitalid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_vitalid_Visible), 5, 0)), true);
         edtavTfbr_vitalid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_vitalid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_vitalid_to_Visible), 5, 0)), true);
         edtavTfbr_encounterid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_encounterid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_encounterid_Visible), 5, 0)), true);
         edtavTfbr_encounterid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_encounterid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_encounterid_to_Visible), 5, 0)), true);
         edtavTfbr_information_patientno_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_information_patientno_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_information_patientno_Visible), 5, 0)), true);
         edtavTfbr_information_patientno_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_information_patientno_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_information_patientno_sel_Visible), 5, 0)), true);
         edtavTfbr_vital_vitalid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_vital_vitalid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_vital_vitalid_Visible), 5, 0)), true);
         edtavTfbr_vital_vitalid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_vital_vitalid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_vital_vitalid_to_Visible), 5, 0)), true);
         edtavTfbr_vital_measuredate_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_vital_measuredate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_vital_measuredate_Visible), 5, 0)), true);
         edtavTfbr_vital_measuredate_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_vital_measuredate_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_vital_measuredate_to_Visible), 5, 0)), true);
         edtavTfbr_vital_temperature_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_vital_temperature_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_vital_temperature_Visible), 5, 0)), true);
         edtavTfbr_vital_temperature_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_vital_temperature_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_vital_temperature_to_Visible), 5, 0)), true);
         edtavTfbr_vital_pulse_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_vital_pulse_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_vital_pulse_Visible), 5, 0)), true);
         edtavTfbr_vital_pulse_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_vital_pulse_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_vital_pulse_to_Visible), 5, 0)), true);
         edtavTfbr_vital_respiration_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_vital_respiration_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_vital_respiration_Visible), 5, 0)), true);
         edtavTfbr_vital_respiration_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_vital_respiration_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_vital_respiration_to_Visible), 5, 0)), true);
         edtavTfbr_vital_systolic_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_vital_systolic_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_vital_systolic_Visible), 5, 0)), true);
         edtavTfbr_vital_systolic_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_vital_systolic_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_vital_systolic_to_Visible), 5, 0)), true);
         edtavTfbr_vital_diastolic_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_vital_diastolic_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_vital_diastolic_Visible), 5, 0)), true);
         edtavTfbr_vital_diastolic_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_vital_diastolic_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_vital_diastolic_to_Visible), 5, 0)), true);
         edtavTfbr_vital_height_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_vital_height_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_vital_height_Visible), 5, 0)), true);
         edtavTfbr_vital_height_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_vital_height_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_vital_height_to_Visible), 5, 0)), true);
         edtavTfbr_vital_weight_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_vital_weight_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_vital_weight_Visible), 5, 0)), true);
         edtavTfbr_vital_weight_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_vital_weight_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_vital_weight_to_Visible), 5, 0)), true);
         Ddo_br_vitalid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_VitalID";
         ucDdo_br_vitalid.SendProperty(context, "", false, Ddo_br_vitalid_Internalname, "TitleControlIdToReplace", Ddo_br_vitalid_Titlecontrolidtoreplace);
         AV19ddo_BR_VitalIDTitleControlIdToReplace = Ddo_br_vitalid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_VitalIDTitleControlIdToReplace", AV19ddo_BR_VitalIDTitleControlIdToReplace);
         edtavDdo_br_vitalidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_vitalidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_vitalidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounterid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_EncounterID";
         ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "TitleControlIdToReplace", Ddo_br_encounterid_Titlecontrolidtoreplace);
         AV23ddo_BR_EncounterIDTitleControlIdToReplace = Ddo_br_encounterid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_EncounterIDTitleControlIdToReplace", AV23ddo_BR_EncounterIDTitleControlIdToReplace);
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_information_patientno_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Information_PatientNo";
         ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "TitleControlIdToReplace", Ddo_br_information_patientno_Titlecontrolidtoreplace);
         AV27ddo_BR_Information_PatientNoTitleControlIdToReplace = Ddo_br_information_patientno_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_Information_PatientNoTitleControlIdToReplace", AV27ddo_BR_Information_PatientNoTitleControlIdToReplace);
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_vital_vitalid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Vital_VitalID";
         ucDdo_br_vital_vitalid.SendProperty(context, "", false, Ddo_br_vital_vitalid_Internalname, "TitleControlIdToReplace", Ddo_br_vital_vitalid_Titlecontrolidtoreplace);
         AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace = Ddo_br_vital_vitalid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace", AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace);
         edtavDdo_br_vital_vitalidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_vital_vitalidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_vital_vitalidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_vital_measuredate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Vital_MeasureDate";
         ucDdo_br_vital_measuredate.SendProperty(context, "", false, Ddo_br_vital_measuredate_Internalname, "TitleControlIdToReplace", Ddo_br_vital_measuredate_Titlecontrolidtoreplace);
         AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace = Ddo_br_vital_measuredate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace", AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace);
         edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_vital_temperature_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Vital_Temperature";
         ucDdo_br_vital_temperature.SendProperty(context, "", false, Ddo_br_vital_temperature_Internalname, "TitleControlIdToReplace", Ddo_br_vital_temperature_Titlecontrolidtoreplace);
         AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace = Ddo_br_vital_temperature_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace", AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace);
         edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_vital_pulse_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Vital_Pulse";
         ucDdo_br_vital_pulse.SendProperty(context, "", false, Ddo_br_vital_pulse_Internalname, "TitleControlIdToReplace", Ddo_br_vital_pulse_Titlecontrolidtoreplace);
         AV45ddo_BR_Vital_PulseTitleControlIdToReplace = Ddo_br_vital_pulse_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45ddo_BR_Vital_PulseTitleControlIdToReplace", AV45ddo_BR_Vital_PulseTitleControlIdToReplace);
         edtavDdo_br_vital_pulsetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_vital_pulsetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_vital_pulsetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_vital_respiration_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Vital_Respiration";
         ucDdo_br_vital_respiration.SendProperty(context, "", false, Ddo_br_vital_respiration_Internalname, "TitleControlIdToReplace", Ddo_br_vital_respiration_Titlecontrolidtoreplace);
         AV49ddo_BR_Vital_RespirationTitleControlIdToReplace = Ddo_br_vital_respiration_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49ddo_BR_Vital_RespirationTitleControlIdToReplace", AV49ddo_BR_Vital_RespirationTitleControlIdToReplace);
         edtavDdo_br_vital_respirationtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_vital_respirationtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_vital_respirationtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_vital_systolic_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Vital_Systolic";
         ucDdo_br_vital_systolic.SendProperty(context, "", false, Ddo_br_vital_systolic_Internalname, "TitleControlIdToReplace", Ddo_br_vital_systolic_Titlecontrolidtoreplace);
         AV53ddo_BR_Vital_SystolicTitleControlIdToReplace = Ddo_br_vital_systolic_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV53ddo_BR_Vital_SystolicTitleControlIdToReplace", AV53ddo_BR_Vital_SystolicTitleControlIdToReplace);
         edtavDdo_br_vital_systolictitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_vital_systolictitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_vital_systolictitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_vital_diastolic_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Vital_Diastolic";
         ucDdo_br_vital_diastolic.SendProperty(context, "", false, Ddo_br_vital_diastolic_Internalname, "TitleControlIdToReplace", Ddo_br_vital_diastolic_Titlecontrolidtoreplace);
         AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace = Ddo_br_vital_diastolic_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace", AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace);
         edtavDdo_br_vital_diastolictitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_vital_diastolictitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_vital_diastolictitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_vital_height_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Vital_Height";
         ucDdo_br_vital_height.SendProperty(context, "", false, Ddo_br_vital_height_Internalname, "TitleControlIdToReplace", Ddo_br_vital_height_Titlecontrolidtoreplace);
         AV61ddo_BR_Vital_HeightTitleControlIdToReplace = Ddo_br_vital_height_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV61ddo_BR_Vital_HeightTitleControlIdToReplace", AV61ddo_BR_Vital_HeightTitleControlIdToReplace);
         edtavDdo_br_vital_heighttitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_vital_heighttitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_vital_heighttitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_vital_weight_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Vital_Weight";
         ucDdo_br_vital_weight.SendProperty(context, "", false, Ddo_br_vital_weight_Internalname, "TitleControlIdToReplace", Ddo_br_vital_weight_Titlecontrolidtoreplace);
         AV65ddo_BR_Vital_WeightTitleControlIdToReplace = Ddo_br_vital_weight_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV65ddo_BR_Vital_WeightTitleControlIdToReplace", AV65ddo_BR_Vital_WeightTitleControlIdToReplace);
         edtavDdo_br_vital_weighttitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_vital_weighttitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_vital_weighttitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " 生命体征";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV66DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV66DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E275Y2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV16BR_VitalIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_Information_PatientNoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28BR_Vital_VitalIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32BR_Vital_MeasureDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV38BR_Vital_TemperatureTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV42BR_Vital_PulseTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV46BR_Vital_RespirationTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV50BR_Vital_SystolicTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV54BR_Vital_DiastolicTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV58BR_Vital_HeightTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV62BR_Vital_WeightTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
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
         edtBR_VitalID_Titleformat = 2;
         edtBR_VitalID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "生命体征主键", AV19ddo_BR_VitalIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_VitalID_Internalname, "Title", edtBR_VitalID_Title, !bGXsfl_31_Refreshing);
         edtBR_EncounterID_Titleformat = 2;
         edtBR_EncounterID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊信息主键", AV23ddo_BR_EncounterIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Title", edtBR_EncounterID_Title, !bGXsfl_31_Refreshing);
         edtBR_Information_PatientNo_Titleformat = 2;
         edtBR_Information_PatientNo_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "患者编号", AV27ddo_BR_Information_PatientNoTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_PatientNo_Internalname, "Title", edtBR_Information_PatientNo_Title, !bGXsfl_31_Refreshing);
         edtBR_Vital_VitalID_Titleformat = 2;
         edtBR_Vital_VitalID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "指标序号", AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Vital_VitalID_Internalname, "Title", edtBR_Vital_VitalID_Title, !bGXsfl_31_Refreshing);
         edtBR_Vital_MeasureDate_Titleformat = 2;
         edtBR_Vital_MeasureDate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "测量日期", AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Vital_MeasureDate_Internalname, "Title", edtBR_Vital_MeasureDate_Title, !bGXsfl_31_Refreshing);
         edtBR_Vital_Temperature_Titleformat = 2;
         edtBR_Vital_Temperature_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "体温(℃)", AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Vital_Temperature_Internalname, "Title", edtBR_Vital_Temperature_Title, !bGXsfl_31_Refreshing);
         edtBR_Vital_Pulse_Titleformat = 2;
         edtBR_Vital_Pulse_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "脉搏(次/分钟)", AV45ddo_BR_Vital_PulseTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Vital_Pulse_Internalname, "Title", edtBR_Vital_Pulse_Title, !bGXsfl_31_Refreshing);
         edtBR_Vital_Respiration_Titleformat = 2;
         edtBR_Vital_Respiration_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "呼吸频率(次/分钟)", AV49ddo_BR_Vital_RespirationTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Vital_Respiration_Internalname, "Title", edtBR_Vital_Respiration_Title, !bGXsfl_31_Refreshing);
         edtBR_Vital_Systolic_Titleformat = 2;
         edtBR_Vital_Systolic_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Hg)", AV53ddo_BR_Vital_SystolicTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Vital_Systolic_Internalname, "Title", edtBR_Vital_Systolic_Title, !bGXsfl_31_Refreshing);
         edtBR_Vital_Diastolic_Titleformat = 2;
         edtBR_Vital_Diastolic_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Hg)", AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Vital_Diastolic_Internalname, "Title", edtBR_Vital_Diastolic_Title, !bGXsfl_31_Refreshing);
         edtBR_Vital_Height_Titleformat = 2;
         edtBR_Vital_Height_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "身高(cm)", AV61ddo_BR_Vital_HeightTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Vital_Height_Internalname, "Title", edtBR_Vital_Height_Title, !bGXsfl_31_Refreshing);
         edtBR_Vital_Weight_Titleformat = 2;
         edtBR_Vital_Weight_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "体重(kg)", AV65ddo_BR_Vital_WeightTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Vital_Weight_Internalname, "Title", edtBR_Vital_Weight_Title, !bGXsfl_31_Refreshing);
         AV68GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV68GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV68GridCurrentPage), 10, 0)));
         AV69GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV69GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV69GridPageSize), 10, 0)));
         AV70GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV70GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV70GridRecordCount), 10, 0)));
         AV80BR_VitalWWDS_1_Tfbr_vitalid = AV17TFBR_VitalID;
         AV81BR_VitalWWDS_2_Tfbr_vitalid_to = AV18TFBR_VitalID_To;
         AV82BR_VitalWWDS_3_Tfbr_encounterid = AV21TFBR_EncounterID;
         AV83BR_VitalWWDS_4_Tfbr_encounterid_to = AV22TFBR_EncounterID_To;
         AV84BR_VitalWWDS_5_Tfbr_information_patientno = AV25TFBR_Information_PatientNo;
         AV85BR_VitalWWDS_6_Tfbr_information_patientno_sel = AV26TFBR_Information_PatientNo_Sel;
         AV86BR_VitalWWDS_7_Tfbr_vital_vitalid = AV29TFBR_Vital_VitalID;
         AV87BR_VitalWWDS_8_Tfbr_vital_vitalid_to = AV30TFBR_Vital_VitalID_To;
         AV88BR_VitalWWDS_9_Tfbr_vital_measuredate = AV33TFBR_Vital_MeasureDate;
         AV89BR_VitalWWDS_10_Tfbr_vital_measuredate_to = AV34TFBR_Vital_MeasureDate_To;
         AV90BR_VitalWWDS_11_Tfbr_vital_temperature = AV39TFBR_Vital_Temperature;
         AV91BR_VitalWWDS_12_Tfbr_vital_temperature_to = AV40TFBR_Vital_Temperature_To;
         AV92BR_VitalWWDS_13_Tfbr_vital_pulse = AV43TFBR_Vital_Pulse;
         AV93BR_VitalWWDS_14_Tfbr_vital_pulse_to = AV44TFBR_Vital_Pulse_To;
         AV94BR_VitalWWDS_15_Tfbr_vital_respiration = AV47TFBR_Vital_Respiration;
         AV95BR_VitalWWDS_16_Tfbr_vital_respiration_to = AV48TFBR_Vital_Respiration_To;
         AV96BR_VitalWWDS_17_Tfbr_vital_systolic = AV51TFBR_Vital_Systolic;
         AV97BR_VitalWWDS_18_Tfbr_vital_systolic_to = AV52TFBR_Vital_Systolic_To;
         AV98BR_VitalWWDS_19_Tfbr_vital_diastolic = AV55TFBR_Vital_Diastolic;
         AV99BR_VitalWWDS_20_Tfbr_vital_diastolic_to = AV56TFBR_Vital_Diastolic_To;
         AV100BR_VitalWWDS_21_Tfbr_vital_height = AV59TFBR_Vital_Height;
         AV101BR_VitalWWDS_22_Tfbr_vital_height_to = AV60TFBR_Vital_Height_To;
         AV102BR_VitalWWDS_23_Tfbr_vital_weight = AV63TFBR_Vital_Weight;
         AV103BR_VitalWWDS_24_Tfbr_vital_weight_to = AV64TFBR_Vital_Weight_To;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_VitalIDTitleFilterData", AV16BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Information_PatientNoTitleFilterData", AV24BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Vital_VitalIDTitleFilterData", AV28BR_Vital_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Vital_MeasureDateTitleFilterData", AV32BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Vital_TemperatureTitleFilterData", AV38BR_Vital_TemperatureTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Vital_PulseTitleFilterData", AV42BR_Vital_PulseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_Vital_RespirationTitleFilterData", AV46BR_Vital_RespirationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Vital_SystolicTitleFilterData", AV50BR_Vital_SystolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_Vital_DiastolicTitleFilterData", AV54BR_Vital_DiastolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Vital_HeightTitleFilterData", AV58BR_Vital_HeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Vital_WeightTitleFilterData", AV62BR_Vital_WeightTitleFilterData);
      }

      protected void E115Y2( )
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
            AV67PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV67PageToGo) ;
         }
      }

      protected void E125Y2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E135Y2( )
      {
         /* Ddo_br_vitalid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_vitalid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_vitalid_Sortedstatus = "ASC";
            ucDdo_br_vitalid.SendProperty(context, "", false, Ddo_br_vitalid_Internalname, "SortedStatus", Ddo_br_vitalid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_vitalid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_vitalid_Sortedstatus = "DSC";
            ucDdo_br_vitalid.SendProperty(context, "", false, Ddo_br_vitalid_Internalname, "SortedStatus", Ddo_br_vitalid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_vitalid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV17TFBR_VitalID = (long)(NumberUtil.Val( Ddo_br_vitalid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_VitalID), 18, 0)));
            AV18TFBR_VitalID_To = (long)(NumberUtil.Val( Ddo_br_vitalid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_VitalID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_VitalID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_VitalIDTitleFilterData", AV16BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Information_PatientNoTitleFilterData", AV24BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Vital_VitalIDTitleFilterData", AV28BR_Vital_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Vital_MeasureDateTitleFilterData", AV32BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Vital_TemperatureTitleFilterData", AV38BR_Vital_TemperatureTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Vital_PulseTitleFilterData", AV42BR_Vital_PulseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_Vital_RespirationTitleFilterData", AV46BR_Vital_RespirationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Vital_SystolicTitleFilterData", AV50BR_Vital_SystolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_Vital_DiastolicTitleFilterData", AV54BR_Vital_DiastolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Vital_HeightTitleFilterData", AV58BR_Vital_HeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Vital_WeightTitleFilterData", AV62BR_Vital_WeightTitleFilterData);
      }

      protected void E145Y2( )
      {
         /* Ddo_br_encounterid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounterid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_encounterid_Sortedstatus = "ASC";
            ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounterid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_encounterid_Sortedstatus = "DSC";
            ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounterid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV21TFBR_EncounterID = (long)(NumberUtil.Val( Ddo_br_encounterid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_EncounterID), 18, 0)));
            AV22TFBR_EncounterID_To = (long)(NumberUtil.Val( Ddo_br_encounterid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_EncounterID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_VitalIDTitleFilterData", AV16BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Information_PatientNoTitleFilterData", AV24BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Vital_VitalIDTitleFilterData", AV28BR_Vital_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Vital_MeasureDateTitleFilterData", AV32BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Vital_TemperatureTitleFilterData", AV38BR_Vital_TemperatureTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Vital_PulseTitleFilterData", AV42BR_Vital_PulseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_Vital_RespirationTitleFilterData", AV46BR_Vital_RespirationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Vital_SystolicTitleFilterData", AV50BR_Vital_SystolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_Vital_DiastolicTitleFilterData", AV54BR_Vital_DiastolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Vital_HeightTitleFilterData", AV58BR_Vital_HeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Vital_WeightTitleFilterData", AV62BR_Vital_WeightTitleFilterData);
      }

      protected void E155Y2( )
      {
         /* Ddo_br_information_patientno_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_information_patientno_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_information_patientno_Sortedstatus = "ASC";
            ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "SortedStatus", Ddo_br_information_patientno_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_information_patientno_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_information_patientno_Sortedstatus = "DSC";
            ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "SortedStatus", Ddo_br_information_patientno_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_information_patientno_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV25TFBR_Information_PatientNo = Ddo_br_information_patientno_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_Information_PatientNo", AV25TFBR_Information_PatientNo);
            AV26TFBR_Information_PatientNo_Sel = Ddo_br_information_patientno_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_Information_PatientNo_Sel", AV26TFBR_Information_PatientNo_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_VitalIDTitleFilterData", AV16BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Information_PatientNoTitleFilterData", AV24BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Vital_VitalIDTitleFilterData", AV28BR_Vital_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Vital_MeasureDateTitleFilterData", AV32BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Vital_TemperatureTitleFilterData", AV38BR_Vital_TemperatureTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Vital_PulseTitleFilterData", AV42BR_Vital_PulseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_Vital_RespirationTitleFilterData", AV46BR_Vital_RespirationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Vital_SystolicTitleFilterData", AV50BR_Vital_SystolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_Vital_DiastolicTitleFilterData", AV54BR_Vital_DiastolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Vital_HeightTitleFilterData", AV58BR_Vital_HeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Vital_WeightTitleFilterData", AV62BR_Vital_WeightTitleFilterData);
      }

      protected void E165Y2( )
      {
         /* Ddo_br_vital_vitalid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_vital_vitalid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_vital_vitalid_Sortedstatus = "ASC";
            ucDdo_br_vital_vitalid.SendProperty(context, "", false, Ddo_br_vital_vitalid_Internalname, "SortedStatus", Ddo_br_vital_vitalid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_vitalid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_vital_vitalid_Sortedstatus = "DSC";
            ucDdo_br_vital_vitalid.SendProperty(context, "", false, Ddo_br_vital_vitalid_Internalname, "SortedStatus", Ddo_br_vital_vitalid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_vitalid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV29TFBR_Vital_VitalID = (long)(NumberUtil.Val( Ddo_br_vital_vitalid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_Vital_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29TFBR_Vital_VitalID), 10, 0)));
            AV30TFBR_Vital_VitalID_To = (long)(NumberUtil.Val( Ddo_br_vital_vitalid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_Vital_VitalID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30TFBR_Vital_VitalID_To), 10, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_VitalIDTitleFilterData", AV16BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Information_PatientNoTitleFilterData", AV24BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Vital_VitalIDTitleFilterData", AV28BR_Vital_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Vital_MeasureDateTitleFilterData", AV32BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Vital_TemperatureTitleFilterData", AV38BR_Vital_TemperatureTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Vital_PulseTitleFilterData", AV42BR_Vital_PulseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_Vital_RespirationTitleFilterData", AV46BR_Vital_RespirationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Vital_SystolicTitleFilterData", AV50BR_Vital_SystolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_Vital_DiastolicTitleFilterData", AV54BR_Vital_DiastolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Vital_HeightTitleFilterData", AV58BR_Vital_HeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Vital_WeightTitleFilterData", AV62BR_Vital_WeightTitleFilterData);
      }

      protected void E175Y2( )
      {
         /* Ddo_br_vital_measuredate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_vital_measuredate_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_vital_measuredate_Sortedstatus = "ASC";
            ucDdo_br_vital_measuredate.SendProperty(context, "", false, Ddo_br_vital_measuredate_Internalname, "SortedStatus", Ddo_br_vital_measuredate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_measuredate_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_vital_measuredate_Sortedstatus = "DSC";
            ucDdo_br_vital_measuredate.SendProperty(context, "", false, Ddo_br_vital_measuredate_Internalname, "SortedStatus", Ddo_br_vital_measuredate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_measuredate_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV33TFBR_Vital_MeasureDate = context.localUtil.CToD( Ddo_br_vital_measuredate_Filteredtext_get, 0);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TFBR_Vital_MeasureDate", context.localUtil.Format(AV33TFBR_Vital_MeasureDate, "9999/99/99"));
            AV34TFBR_Vital_MeasureDate_To = context.localUtil.CToD( Ddo_br_vital_measuredate_Filteredtextto_get, 0);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFBR_Vital_MeasureDate_To", context.localUtil.Format(AV34TFBR_Vital_MeasureDate_To, "9999/99/99"));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_VitalIDTitleFilterData", AV16BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Information_PatientNoTitleFilterData", AV24BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Vital_VitalIDTitleFilterData", AV28BR_Vital_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Vital_MeasureDateTitleFilterData", AV32BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Vital_TemperatureTitleFilterData", AV38BR_Vital_TemperatureTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Vital_PulseTitleFilterData", AV42BR_Vital_PulseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_Vital_RespirationTitleFilterData", AV46BR_Vital_RespirationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Vital_SystolicTitleFilterData", AV50BR_Vital_SystolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_Vital_DiastolicTitleFilterData", AV54BR_Vital_DiastolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Vital_HeightTitleFilterData", AV58BR_Vital_HeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Vital_WeightTitleFilterData", AV62BR_Vital_WeightTitleFilterData);
      }

      protected void E185Y2( )
      {
         /* Ddo_br_vital_temperature_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_vital_temperature_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_vital_temperature_Sortedstatus = "ASC";
            ucDdo_br_vital_temperature.SendProperty(context, "", false, Ddo_br_vital_temperature_Internalname, "SortedStatus", Ddo_br_vital_temperature_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_temperature_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_vital_temperature_Sortedstatus = "DSC";
            ucDdo_br_vital_temperature.SendProperty(context, "", false, Ddo_br_vital_temperature_Internalname, "SortedStatus", Ddo_br_vital_temperature_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_temperature_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV39TFBR_Vital_Temperature = NumberUtil.Val( Ddo_br_vital_temperature_Filteredtext_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39TFBR_Vital_Temperature", StringUtil.LTrim( StringUtil.Str( AV39TFBR_Vital_Temperature, 15, 5)));
            AV40TFBR_Vital_Temperature_To = NumberUtil.Val( Ddo_br_vital_temperature_Filteredtextto_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40TFBR_Vital_Temperature_To", StringUtil.LTrim( StringUtil.Str( AV40TFBR_Vital_Temperature_To, 15, 5)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_VitalIDTitleFilterData", AV16BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Information_PatientNoTitleFilterData", AV24BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Vital_VitalIDTitleFilterData", AV28BR_Vital_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Vital_MeasureDateTitleFilterData", AV32BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Vital_TemperatureTitleFilterData", AV38BR_Vital_TemperatureTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Vital_PulseTitleFilterData", AV42BR_Vital_PulseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_Vital_RespirationTitleFilterData", AV46BR_Vital_RespirationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Vital_SystolicTitleFilterData", AV50BR_Vital_SystolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_Vital_DiastolicTitleFilterData", AV54BR_Vital_DiastolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Vital_HeightTitleFilterData", AV58BR_Vital_HeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Vital_WeightTitleFilterData", AV62BR_Vital_WeightTitleFilterData);
      }

      protected void E195Y2( )
      {
         /* Ddo_br_vital_pulse_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_vital_pulse_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_vital_pulse_Sortedstatus = "ASC";
            ucDdo_br_vital_pulse.SendProperty(context, "", false, Ddo_br_vital_pulse_Internalname, "SortedStatus", Ddo_br_vital_pulse_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_pulse_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_vital_pulse_Sortedstatus = "DSC";
            ucDdo_br_vital_pulse.SendProperty(context, "", false, Ddo_br_vital_pulse_Internalname, "SortedStatus", Ddo_br_vital_pulse_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_pulse_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV43TFBR_Vital_Pulse = NumberUtil.Val( Ddo_br_vital_pulse_Filteredtext_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43TFBR_Vital_Pulse", StringUtil.LTrim( StringUtil.Str( AV43TFBR_Vital_Pulse, 15, 5)));
            AV44TFBR_Vital_Pulse_To = NumberUtil.Val( Ddo_br_vital_pulse_Filteredtextto_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44TFBR_Vital_Pulse_To", StringUtil.LTrim( StringUtil.Str( AV44TFBR_Vital_Pulse_To, 15, 5)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_VitalIDTitleFilterData", AV16BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Information_PatientNoTitleFilterData", AV24BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Vital_VitalIDTitleFilterData", AV28BR_Vital_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Vital_MeasureDateTitleFilterData", AV32BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Vital_TemperatureTitleFilterData", AV38BR_Vital_TemperatureTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Vital_PulseTitleFilterData", AV42BR_Vital_PulseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_Vital_RespirationTitleFilterData", AV46BR_Vital_RespirationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Vital_SystolicTitleFilterData", AV50BR_Vital_SystolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_Vital_DiastolicTitleFilterData", AV54BR_Vital_DiastolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Vital_HeightTitleFilterData", AV58BR_Vital_HeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Vital_WeightTitleFilterData", AV62BR_Vital_WeightTitleFilterData);
      }

      protected void E205Y2( )
      {
         /* Ddo_br_vital_respiration_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_vital_respiration_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_vital_respiration_Sortedstatus = "ASC";
            ucDdo_br_vital_respiration.SendProperty(context, "", false, Ddo_br_vital_respiration_Internalname, "SortedStatus", Ddo_br_vital_respiration_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_respiration_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_vital_respiration_Sortedstatus = "DSC";
            ucDdo_br_vital_respiration.SendProperty(context, "", false, Ddo_br_vital_respiration_Internalname, "SortedStatus", Ddo_br_vital_respiration_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_respiration_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV47TFBR_Vital_Respiration = NumberUtil.Val( Ddo_br_vital_respiration_Filteredtext_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47TFBR_Vital_Respiration", StringUtil.LTrim( StringUtil.Str( AV47TFBR_Vital_Respiration, 15, 5)));
            AV48TFBR_Vital_Respiration_To = NumberUtil.Val( Ddo_br_vital_respiration_Filteredtextto_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48TFBR_Vital_Respiration_To", StringUtil.LTrim( StringUtil.Str( AV48TFBR_Vital_Respiration_To, 15, 5)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_VitalIDTitleFilterData", AV16BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Information_PatientNoTitleFilterData", AV24BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Vital_VitalIDTitleFilterData", AV28BR_Vital_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Vital_MeasureDateTitleFilterData", AV32BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Vital_TemperatureTitleFilterData", AV38BR_Vital_TemperatureTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Vital_PulseTitleFilterData", AV42BR_Vital_PulseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_Vital_RespirationTitleFilterData", AV46BR_Vital_RespirationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Vital_SystolicTitleFilterData", AV50BR_Vital_SystolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_Vital_DiastolicTitleFilterData", AV54BR_Vital_DiastolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Vital_HeightTitleFilterData", AV58BR_Vital_HeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Vital_WeightTitleFilterData", AV62BR_Vital_WeightTitleFilterData);
      }

      protected void E215Y2( )
      {
         /* Ddo_br_vital_systolic_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_vital_systolic_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_vital_systolic_Sortedstatus = "ASC";
            ucDdo_br_vital_systolic.SendProperty(context, "", false, Ddo_br_vital_systolic_Internalname, "SortedStatus", Ddo_br_vital_systolic_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_systolic_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_vital_systolic_Sortedstatus = "DSC";
            ucDdo_br_vital_systolic.SendProperty(context, "", false, Ddo_br_vital_systolic_Internalname, "SortedStatus", Ddo_br_vital_systolic_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_systolic_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV51TFBR_Vital_Systolic = NumberUtil.Val( Ddo_br_vital_systolic_Filteredtext_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51TFBR_Vital_Systolic", StringUtil.LTrim( StringUtil.Str( AV51TFBR_Vital_Systolic, 15, 5)));
            AV52TFBR_Vital_Systolic_To = NumberUtil.Val( Ddo_br_vital_systolic_Filteredtextto_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52TFBR_Vital_Systolic_To", StringUtil.LTrim( StringUtil.Str( AV52TFBR_Vital_Systolic_To, 15, 5)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_VitalIDTitleFilterData", AV16BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Information_PatientNoTitleFilterData", AV24BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Vital_VitalIDTitleFilterData", AV28BR_Vital_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Vital_MeasureDateTitleFilterData", AV32BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Vital_TemperatureTitleFilterData", AV38BR_Vital_TemperatureTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Vital_PulseTitleFilterData", AV42BR_Vital_PulseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_Vital_RespirationTitleFilterData", AV46BR_Vital_RespirationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Vital_SystolicTitleFilterData", AV50BR_Vital_SystolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_Vital_DiastolicTitleFilterData", AV54BR_Vital_DiastolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Vital_HeightTitleFilterData", AV58BR_Vital_HeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Vital_WeightTitleFilterData", AV62BR_Vital_WeightTitleFilterData);
      }

      protected void E225Y2( )
      {
         /* Ddo_br_vital_diastolic_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_vital_diastolic_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 10;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_vital_diastolic_Sortedstatus = "ASC";
            ucDdo_br_vital_diastolic.SendProperty(context, "", false, Ddo_br_vital_diastolic_Internalname, "SortedStatus", Ddo_br_vital_diastolic_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_diastolic_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 10;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_vital_diastolic_Sortedstatus = "DSC";
            ucDdo_br_vital_diastolic.SendProperty(context, "", false, Ddo_br_vital_diastolic_Internalname, "SortedStatus", Ddo_br_vital_diastolic_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_diastolic_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV55TFBR_Vital_Diastolic = NumberUtil.Val( Ddo_br_vital_diastolic_Filteredtext_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV55TFBR_Vital_Diastolic", StringUtil.LTrim( StringUtil.Str( AV55TFBR_Vital_Diastolic, 15, 5)));
            AV56TFBR_Vital_Diastolic_To = NumberUtil.Val( Ddo_br_vital_diastolic_Filteredtextto_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56TFBR_Vital_Diastolic_To", StringUtil.LTrim( StringUtil.Str( AV56TFBR_Vital_Diastolic_To, 15, 5)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_VitalIDTitleFilterData", AV16BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Information_PatientNoTitleFilterData", AV24BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Vital_VitalIDTitleFilterData", AV28BR_Vital_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Vital_MeasureDateTitleFilterData", AV32BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Vital_TemperatureTitleFilterData", AV38BR_Vital_TemperatureTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Vital_PulseTitleFilterData", AV42BR_Vital_PulseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_Vital_RespirationTitleFilterData", AV46BR_Vital_RespirationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Vital_SystolicTitleFilterData", AV50BR_Vital_SystolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_Vital_DiastolicTitleFilterData", AV54BR_Vital_DiastolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Vital_HeightTitleFilterData", AV58BR_Vital_HeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Vital_WeightTitleFilterData", AV62BR_Vital_WeightTitleFilterData);
      }

      protected void E235Y2( )
      {
         /* Ddo_br_vital_height_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_vital_height_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_vital_height_Sortedstatus = "ASC";
            ucDdo_br_vital_height.SendProperty(context, "", false, Ddo_br_vital_height_Internalname, "SortedStatus", Ddo_br_vital_height_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_height_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_vital_height_Sortedstatus = "DSC";
            ucDdo_br_vital_height.SendProperty(context, "", false, Ddo_br_vital_height_Internalname, "SortedStatus", Ddo_br_vital_height_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_height_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV59TFBR_Vital_Height = NumberUtil.Val( Ddo_br_vital_height_Filteredtext_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59TFBR_Vital_Height", StringUtil.LTrim( StringUtil.Str( AV59TFBR_Vital_Height, 15, 5)));
            AV60TFBR_Vital_Height_To = NumberUtil.Val( Ddo_br_vital_height_Filteredtextto_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60TFBR_Vital_Height_To", StringUtil.LTrim( StringUtil.Str( AV60TFBR_Vital_Height_To, 15, 5)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_VitalIDTitleFilterData", AV16BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Information_PatientNoTitleFilterData", AV24BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Vital_VitalIDTitleFilterData", AV28BR_Vital_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Vital_MeasureDateTitleFilterData", AV32BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Vital_TemperatureTitleFilterData", AV38BR_Vital_TemperatureTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Vital_PulseTitleFilterData", AV42BR_Vital_PulseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_Vital_RespirationTitleFilterData", AV46BR_Vital_RespirationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Vital_SystolicTitleFilterData", AV50BR_Vital_SystolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_Vital_DiastolicTitleFilterData", AV54BR_Vital_DiastolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Vital_HeightTitleFilterData", AV58BR_Vital_HeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Vital_WeightTitleFilterData", AV62BR_Vital_WeightTitleFilterData);
      }

      protected void E245Y2( )
      {
         /* Ddo_br_vital_weight_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_vital_weight_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_vital_weight_Sortedstatus = "ASC";
            ucDdo_br_vital_weight.SendProperty(context, "", false, Ddo_br_vital_weight_Internalname, "SortedStatus", Ddo_br_vital_weight_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_weight_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_vital_weight_Sortedstatus = "DSC";
            ucDdo_br_vital_weight.SendProperty(context, "", false, Ddo_br_vital_weight_Internalname, "SortedStatus", Ddo_br_vital_weight_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_weight_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV63TFBR_Vital_Weight = NumberUtil.Val( Ddo_br_vital_weight_Filteredtext_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV63TFBR_Vital_Weight", StringUtil.LTrim( StringUtil.Str( AV63TFBR_Vital_Weight, 15, 5)));
            AV64TFBR_Vital_Weight_To = NumberUtil.Val( Ddo_br_vital_weight_Filteredtextto_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV64TFBR_Vital_Weight_To", StringUtil.LTrim( StringUtil.Str( AV64TFBR_Vital_Weight_To, 15, 5)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_VitalIDTitleFilterData", AV16BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Information_PatientNoTitleFilterData", AV24BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Vital_VitalIDTitleFilterData", AV28BR_Vital_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Vital_MeasureDateTitleFilterData", AV32BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Vital_TemperatureTitleFilterData", AV38BR_Vital_TemperatureTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Vital_PulseTitleFilterData", AV42BR_Vital_PulseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_Vital_RespirationTitleFilterData", AV46BR_Vital_RespirationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Vital_SystolicTitleFilterData", AV50BR_Vital_SystolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_Vital_DiastolicTitleFilterData", AV54BR_Vital_DiastolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Vital_HeightTitleFilterData", AV58BR_Vital_HeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV62BR_Vital_WeightTitleFilterData", AV62BR_Vital_WeightTitleFilterData);
      }

      private void E285Y2( )
      {
         /* Grid_Load Routine */
         AV71Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDisplay_Internalname, AV71Display);
         AV104Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = formatLink("br_vitalview.aspx") + "?" + UrlEncode("" +A150BR_VitalID) + "," + UrlEncode(StringUtil.RTrim(""));
         AV72Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV72Update);
         AV105Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavUpdate_Tooltiptext = "修改";
         if ( AV73IsAuthorized_Update )
         {
            edtavUpdate_Link = formatLink("br_vital.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A150BR_VitalID);
         }
         AV74Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV74Delete);
         AV106Delete_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavDelete_Tooltiptext = "删除";
         if ( AV75IsAuthorized_Delete )
         {
            edtavDelete_Link = formatLink("br_vital.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A150BR_VitalID);
         }
         if ( AV76IsAuthorized_BR_Information_PatientNo )
         {
            edtBR_Information_PatientNo_Link = formatLink("br_informationview.aspx") + "?" + UrlEncode("" +A85BR_Information_ID) + "," + UrlEncode(StringUtil.RTrim(""));
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

      protected void E255Y2( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("br_vital.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S162( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_br_vitalid_Sortedstatus = "";
         ucDdo_br_vitalid.SendProperty(context, "", false, Ddo_br_vitalid_Internalname, "SortedStatus", Ddo_br_vitalid_Sortedstatus);
         Ddo_br_encounterid_Sortedstatus = "";
         ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
         Ddo_br_information_patientno_Sortedstatus = "";
         ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "SortedStatus", Ddo_br_information_patientno_Sortedstatus);
         Ddo_br_vital_vitalid_Sortedstatus = "";
         ucDdo_br_vital_vitalid.SendProperty(context, "", false, Ddo_br_vital_vitalid_Internalname, "SortedStatus", Ddo_br_vital_vitalid_Sortedstatus);
         Ddo_br_vital_measuredate_Sortedstatus = "";
         ucDdo_br_vital_measuredate.SendProperty(context, "", false, Ddo_br_vital_measuredate_Internalname, "SortedStatus", Ddo_br_vital_measuredate_Sortedstatus);
         Ddo_br_vital_temperature_Sortedstatus = "";
         ucDdo_br_vital_temperature.SendProperty(context, "", false, Ddo_br_vital_temperature_Internalname, "SortedStatus", Ddo_br_vital_temperature_Sortedstatus);
         Ddo_br_vital_pulse_Sortedstatus = "";
         ucDdo_br_vital_pulse.SendProperty(context, "", false, Ddo_br_vital_pulse_Internalname, "SortedStatus", Ddo_br_vital_pulse_Sortedstatus);
         Ddo_br_vital_respiration_Sortedstatus = "";
         ucDdo_br_vital_respiration.SendProperty(context, "", false, Ddo_br_vital_respiration_Internalname, "SortedStatus", Ddo_br_vital_respiration_Sortedstatus);
         Ddo_br_vital_systolic_Sortedstatus = "";
         ucDdo_br_vital_systolic.SendProperty(context, "", false, Ddo_br_vital_systolic_Internalname, "SortedStatus", Ddo_br_vital_systolic_Sortedstatus);
         Ddo_br_vital_diastolic_Sortedstatus = "";
         ucDdo_br_vital_diastolic.SendProperty(context, "", false, Ddo_br_vital_diastolic_Internalname, "SortedStatus", Ddo_br_vital_diastolic_Sortedstatus);
         Ddo_br_vital_height_Sortedstatus = "";
         ucDdo_br_vital_height.SendProperty(context, "", false, Ddo_br_vital_height_Internalname, "SortedStatus", Ddo_br_vital_height_Sortedstatus);
         Ddo_br_vital_weight_Sortedstatus = "";
         ucDdo_br_vital_weight.SendProperty(context, "", false, Ddo_br_vital_weight_Internalname, "SortedStatus", Ddo_br_vital_weight_Sortedstatus);
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
            Ddo_br_vitalid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_vitalid.SendProperty(context, "", false, Ddo_br_vitalid_Internalname, "SortedStatus", Ddo_br_vitalid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 2 )
         {
            Ddo_br_encounterid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 3 )
         {
            Ddo_br_information_patientno_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "SortedStatus", Ddo_br_information_patientno_Sortedstatus);
         }
         else if ( AV13OrderedBy == 4 )
         {
            Ddo_br_vital_vitalid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_vital_vitalid.SendProperty(context, "", false, Ddo_br_vital_vitalid_Internalname, "SortedStatus", Ddo_br_vital_vitalid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 5 )
         {
            Ddo_br_vital_measuredate_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_vital_measuredate.SendProperty(context, "", false, Ddo_br_vital_measuredate_Internalname, "SortedStatus", Ddo_br_vital_measuredate_Sortedstatus);
         }
         else if ( AV13OrderedBy == 6 )
         {
            Ddo_br_vital_temperature_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_vital_temperature.SendProperty(context, "", false, Ddo_br_vital_temperature_Internalname, "SortedStatus", Ddo_br_vital_temperature_Sortedstatus);
         }
         else if ( AV13OrderedBy == 7 )
         {
            Ddo_br_vital_pulse_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_vital_pulse.SendProperty(context, "", false, Ddo_br_vital_pulse_Internalname, "SortedStatus", Ddo_br_vital_pulse_Sortedstatus);
         }
         else if ( AV13OrderedBy == 8 )
         {
            Ddo_br_vital_respiration_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_vital_respiration.SendProperty(context, "", false, Ddo_br_vital_respiration_Internalname, "SortedStatus", Ddo_br_vital_respiration_Sortedstatus);
         }
         else if ( AV13OrderedBy == 9 )
         {
            Ddo_br_vital_systolic_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_vital_systolic.SendProperty(context, "", false, Ddo_br_vital_systolic_Internalname, "SortedStatus", Ddo_br_vital_systolic_Sortedstatus);
         }
         else if ( AV13OrderedBy == 10 )
         {
            Ddo_br_vital_diastolic_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_vital_diastolic.SendProperty(context, "", false, Ddo_br_vital_diastolic_Internalname, "SortedStatus", Ddo_br_vital_diastolic_Sortedstatus);
         }
         else if ( AV13OrderedBy == 11 )
         {
            Ddo_br_vital_height_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_vital_height.SendProperty(context, "", false, Ddo_br_vital_height_Internalname, "SortedStatus", Ddo_br_vital_height_Sortedstatus);
         }
         else if ( AV13OrderedBy == 12 )
         {
            Ddo_br_vital_weight_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_vital_weight.SendProperty(context, "", false, Ddo_br_vital_weight_Internalname, "SortedStatus", Ddo_br_vital_weight_Sortedstatus);
         }
      }

      protected void S142( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean1 = AV73IsAuthorized_Update;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Vital", out  GXt_boolean1) ;
         AV73IsAuthorized_Update = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV73IsAuthorized_Update", AV73IsAuthorized_Update);
         if ( ! ( AV73IsAuthorized_Update ) )
         {
            edtavUpdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_31_Refreshing);
         }
         GXt_boolean1 = AV75IsAuthorized_Delete;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Vital", out  GXt_boolean1) ;
         AV75IsAuthorized_Delete = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV75IsAuthorized_Delete", AV75IsAuthorized_Delete);
         if ( ! ( AV75IsAuthorized_Delete ) )
         {
            edtavDelete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Visible), 5, 0)), !bGXsfl_31_Refreshing);
         }
         GXt_boolean1 = AV77TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Vital", out  GXt_boolean1) ;
         AV77TempBoolean = GXt_boolean1;
         if ( ! ( AV77TempBoolean ) )
         {
            bttBtninsert_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtninsert_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtninsert_Visible), 5, 0)), true);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV15Session.Get(AV107Pgmname+"GridState"), "") == 0 )
         {
            AV11GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV107Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV11GridState.FromXml(AV15Session.Get(AV107Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
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
         AV108GXV1 = 1;
         while ( AV108GXV1 <= AV11GridState.gxTpr_Filtervalues.Count )
         {
            AV12GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV11GridState.gxTpr_Filtervalues.Item(AV108GXV1));
            if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_VITALID") == 0 )
            {
               AV17TFBR_VitalID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_VitalID), 18, 0)));
               AV18TFBR_VitalID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_VitalID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_VitalID_To), 18, 0)));
               if ( ! (0==AV17TFBR_VitalID) )
               {
                  Ddo_br_vitalid_Filteredtext_set = StringUtil.Str( (decimal)(AV17TFBR_VitalID), 18, 0);
                  ucDdo_br_vitalid.SendProperty(context, "", false, Ddo_br_vitalid_Internalname, "FilteredText_set", Ddo_br_vitalid_Filteredtext_set);
               }
               if ( ! (0==AV18TFBR_VitalID_To) )
               {
                  Ddo_br_vitalid_Filteredtextto_set = StringUtil.Str( (decimal)(AV18TFBR_VitalID_To), 18, 0);
                  ucDdo_br_vitalid.SendProperty(context, "", false, Ddo_br_vitalid_Internalname, "FilteredTextTo_set", Ddo_br_vitalid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTERID") == 0 )
            {
               AV21TFBR_EncounterID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_EncounterID), 18, 0)));
               AV22TFBR_EncounterID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_EncounterID_To), 18, 0)));
               if ( ! (0==AV21TFBR_EncounterID) )
               {
                  Ddo_br_encounterid_Filteredtext_set = StringUtil.Str( (decimal)(AV21TFBR_EncounterID), 18, 0);
                  ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "FilteredText_set", Ddo_br_encounterid_Filteredtext_set);
               }
               if ( ! (0==AV22TFBR_EncounterID_To) )
               {
                  Ddo_br_encounterid_Filteredtextto_set = StringUtil.Str( (decimal)(AV22TFBR_EncounterID_To), 18, 0);
                  ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "FilteredTextTo_set", Ddo_br_encounterid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_INFORMATION_PATIENTNO") == 0 )
            {
               AV25TFBR_Information_PatientNo = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_Information_PatientNo", AV25TFBR_Information_PatientNo);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV25TFBR_Information_PatientNo)) )
               {
                  Ddo_br_information_patientno_Filteredtext_set = AV25TFBR_Information_PatientNo;
                  ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "FilteredText_set", Ddo_br_information_patientno_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_INFORMATION_PATIENTNO_SEL") == 0 )
            {
               AV26TFBR_Information_PatientNo_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_Information_PatientNo_Sel", AV26TFBR_Information_PatientNo_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26TFBR_Information_PatientNo_Sel)) )
               {
                  Ddo_br_information_patientno_Selectedvalue_set = AV26TFBR_Information_PatientNo_Sel;
                  ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "SelectedValue_set", Ddo_br_information_patientno_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_VITAL_VITALID") == 0 )
            {
               AV29TFBR_Vital_VitalID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_Vital_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29TFBR_Vital_VitalID), 10, 0)));
               AV30TFBR_Vital_VitalID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_Vital_VitalID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30TFBR_Vital_VitalID_To), 10, 0)));
               if ( ! (0==AV29TFBR_Vital_VitalID) )
               {
                  Ddo_br_vital_vitalid_Filteredtext_set = StringUtil.Str( (decimal)(AV29TFBR_Vital_VitalID), 10, 0);
                  ucDdo_br_vital_vitalid.SendProperty(context, "", false, Ddo_br_vital_vitalid_Internalname, "FilteredText_set", Ddo_br_vital_vitalid_Filteredtext_set);
               }
               if ( ! (0==AV30TFBR_Vital_VitalID_To) )
               {
                  Ddo_br_vital_vitalid_Filteredtextto_set = StringUtil.Str( (decimal)(AV30TFBR_Vital_VitalID_To), 10, 0);
                  ucDdo_br_vital_vitalid.SendProperty(context, "", false, Ddo_br_vital_vitalid_Internalname, "FilteredTextTo_set", Ddo_br_vital_vitalid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_VITAL_MEASUREDATE") == 0 )
            {
               AV33TFBR_Vital_MeasureDate = context.localUtil.CToD( AV12GridStateFilterValue.gxTpr_Value, 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TFBR_Vital_MeasureDate", context.localUtil.Format(AV33TFBR_Vital_MeasureDate, "9999/99/99"));
               AV34TFBR_Vital_MeasureDate_To = context.localUtil.CToD( AV12GridStateFilterValue.gxTpr_Valueto, 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFBR_Vital_MeasureDate_To", context.localUtil.Format(AV34TFBR_Vital_MeasureDate_To, "9999/99/99"));
               if ( ! (DateTime.MinValue==AV33TFBR_Vital_MeasureDate) )
               {
                  Ddo_br_vital_measuredate_Filteredtext_set = context.localUtil.DToC( AV33TFBR_Vital_MeasureDate, 0, "/");
                  ucDdo_br_vital_measuredate.SendProperty(context, "", false, Ddo_br_vital_measuredate_Internalname, "FilteredText_set", Ddo_br_vital_measuredate_Filteredtext_set);
               }
               if ( ! (DateTime.MinValue==AV34TFBR_Vital_MeasureDate_To) )
               {
                  Ddo_br_vital_measuredate_Filteredtextto_set = context.localUtil.DToC( AV34TFBR_Vital_MeasureDate_To, 0, "/");
                  ucDdo_br_vital_measuredate.SendProperty(context, "", false, Ddo_br_vital_measuredate_Internalname, "FilteredTextTo_set", Ddo_br_vital_measuredate_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_VITAL_TEMPERATURE") == 0 )
            {
               AV39TFBR_Vital_Temperature = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39TFBR_Vital_Temperature", StringUtil.LTrim( StringUtil.Str( AV39TFBR_Vital_Temperature, 15, 5)));
               AV40TFBR_Vital_Temperature_To = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40TFBR_Vital_Temperature_To", StringUtil.LTrim( StringUtil.Str( AV40TFBR_Vital_Temperature_To, 15, 5)));
               if ( ! (Convert.ToDecimal(0)==AV39TFBR_Vital_Temperature) )
               {
                  Ddo_br_vital_temperature_Filteredtext_set = StringUtil.Str( AV39TFBR_Vital_Temperature, 15, 5);
                  ucDdo_br_vital_temperature.SendProperty(context, "", false, Ddo_br_vital_temperature_Internalname, "FilteredText_set", Ddo_br_vital_temperature_Filteredtext_set);
               }
               if ( ! (Convert.ToDecimal(0)==AV40TFBR_Vital_Temperature_To) )
               {
                  Ddo_br_vital_temperature_Filteredtextto_set = StringUtil.Str( AV40TFBR_Vital_Temperature_To, 15, 5);
                  ucDdo_br_vital_temperature.SendProperty(context, "", false, Ddo_br_vital_temperature_Internalname, "FilteredTextTo_set", Ddo_br_vital_temperature_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_VITAL_PULSE") == 0 )
            {
               AV43TFBR_Vital_Pulse = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43TFBR_Vital_Pulse", StringUtil.LTrim( StringUtil.Str( AV43TFBR_Vital_Pulse, 15, 5)));
               AV44TFBR_Vital_Pulse_To = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44TFBR_Vital_Pulse_To", StringUtil.LTrim( StringUtil.Str( AV44TFBR_Vital_Pulse_To, 15, 5)));
               if ( ! (Convert.ToDecimal(0)==AV43TFBR_Vital_Pulse) )
               {
                  Ddo_br_vital_pulse_Filteredtext_set = StringUtil.Str( AV43TFBR_Vital_Pulse, 15, 5);
                  ucDdo_br_vital_pulse.SendProperty(context, "", false, Ddo_br_vital_pulse_Internalname, "FilteredText_set", Ddo_br_vital_pulse_Filteredtext_set);
               }
               if ( ! (Convert.ToDecimal(0)==AV44TFBR_Vital_Pulse_To) )
               {
                  Ddo_br_vital_pulse_Filteredtextto_set = StringUtil.Str( AV44TFBR_Vital_Pulse_To, 15, 5);
                  ucDdo_br_vital_pulse.SendProperty(context, "", false, Ddo_br_vital_pulse_Internalname, "FilteredTextTo_set", Ddo_br_vital_pulse_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_VITAL_RESPIRATION") == 0 )
            {
               AV47TFBR_Vital_Respiration = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47TFBR_Vital_Respiration", StringUtil.LTrim( StringUtil.Str( AV47TFBR_Vital_Respiration, 15, 5)));
               AV48TFBR_Vital_Respiration_To = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48TFBR_Vital_Respiration_To", StringUtil.LTrim( StringUtil.Str( AV48TFBR_Vital_Respiration_To, 15, 5)));
               if ( ! (Convert.ToDecimal(0)==AV47TFBR_Vital_Respiration) )
               {
                  Ddo_br_vital_respiration_Filteredtext_set = StringUtil.Str( AV47TFBR_Vital_Respiration, 15, 5);
                  ucDdo_br_vital_respiration.SendProperty(context, "", false, Ddo_br_vital_respiration_Internalname, "FilteredText_set", Ddo_br_vital_respiration_Filteredtext_set);
               }
               if ( ! (Convert.ToDecimal(0)==AV48TFBR_Vital_Respiration_To) )
               {
                  Ddo_br_vital_respiration_Filteredtextto_set = StringUtil.Str( AV48TFBR_Vital_Respiration_To, 15, 5);
                  ucDdo_br_vital_respiration.SendProperty(context, "", false, Ddo_br_vital_respiration_Internalname, "FilteredTextTo_set", Ddo_br_vital_respiration_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_VITAL_SYSTOLIC") == 0 )
            {
               AV51TFBR_Vital_Systolic = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51TFBR_Vital_Systolic", StringUtil.LTrim( StringUtil.Str( AV51TFBR_Vital_Systolic, 15, 5)));
               AV52TFBR_Vital_Systolic_To = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52TFBR_Vital_Systolic_To", StringUtil.LTrim( StringUtil.Str( AV52TFBR_Vital_Systolic_To, 15, 5)));
               if ( ! (Convert.ToDecimal(0)==AV51TFBR_Vital_Systolic) )
               {
                  Ddo_br_vital_systolic_Filteredtext_set = StringUtil.Str( AV51TFBR_Vital_Systolic, 15, 5);
                  ucDdo_br_vital_systolic.SendProperty(context, "", false, Ddo_br_vital_systolic_Internalname, "FilteredText_set", Ddo_br_vital_systolic_Filteredtext_set);
               }
               if ( ! (Convert.ToDecimal(0)==AV52TFBR_Vital_Systolic_To) )
               {
                  Ddo_br_vital_systolic_Filteredtextto_set = StringUtil.Str( AV52TFBR_Vital_Systolic_To, 15, 5);
                  ucDdo_br_vital_systolic.SendProperty(context, "", false, Ddo_br_vital_systolic_Internalname, "FilteredTextTo_set", Ddo_br_vital_systolic_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_VITAL_DIASTOLIC") == 0 )
            {
               AV55TFBR_Vital_Diastolic = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV55TFBR_Vital_Diastolic", StringUtil.LTrim( StringUtil.Str( AV55TFBR_Vital_Diastolic, 15, 5)));
               AV56TFBR_Vital_Diastolic_To = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56TFBR_Vital_Diastolic_To", StringUtil.LTrim( StringUtil.Str( AV56TFBR_Vital_Diastolic_To, 15, 5)));
               if ( ! (Convert.ToDecimal(0)==AV55TFBR_Vital_Diastolic) )
               {
                  Ddo_br_vital_diastolic_Filteredtext_set = StringUtil.Str( AV55TFBR_Vital_Diastolic, 15, 5);
                  ucDdo_br_vital_diastolic.SendProperty(context, "", false, Ddo_br_vital_diastolic_Internalname, "FilteredText_set", Ddo_br_vital_diastolic_Filteredtext_set);
               }
               if ( ! (Convert.ToDecimal(0)==AV56TFBR_Vital_Diastolic_To) )
               {
                  Ddo_br_vital_diastolic_Filteredtextto_set = StringUtil.Str( AV56TFBR_Vital_Diastolic_To, 15, 5);
                  ucDdo_br_vital_diastolic.SendProperty(context, "", false, Ddo_br_vital_diastolic_Internalname, "FilteredTextTo_set", Ddo_br_vital_diastolic_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_VITAL_HEIGHT") == 0 )
            {
               AV59TFBR_Vital_Height = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59TFBR_Vital_Height", StringUtil.LTrim( StringUtil.Str( AV59TFBR_Vital_Height, 15, 5)));
               AV60TFBR_Vital_Height_To = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60TFBR_Vital_Height_To", StringUtil.LTrim( StringUtil.Str( AV60TFBR_Vital_Height_To, 15, 5)));
               if ( ! (Convert.ToDecimal(0)==AV59TFBR_Vital_Height) )
               {
                  Ddo_br_vital_height_Filteredtext_set = StringUtil.Str( AV59TFBR_Vital_Height, 15, 5);
                  ucDdo_br_vital_height.SendProperty(context, "", false, Ddo_br_vital_height_Internalname, "FilteredText_set", Ddo_br_vital_height_Filteredtext_set);
               }
               if ( ! (Convert.ToDecimal(0)==AV60TFBR_Vital_Height_To) )
               {
                  Ddo_br_vital_height_Filteredtextto_set = StringUtil.Str( AV60TFBR_Vital_Height_To, 15, 5);
                  ucDdo_br_vital_height.SendProperty(context, "", false, Ddo_br_vital_height_Internalname, "FilteredTextTo_set", Ddo_br_vital_height_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_VITAL_WEIGHT") == 0 )
            {
               AV63TFBR_Vital_Weight = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV63TFBR_Vital_Weight", StringUtil.LTrim( StringUtil.Str( AV63TFBR_Vital_Weight, 15, 5)));
               AV64TFBR_Vital_Weight_To = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV64TFBR_Vital_Weight_To", StringUtil.LTrim( StringUtil.Str( AV64TFBR_Vital_Weight_To, 15, 5)));
               if ( ! (Convert.ToDecimal(0)==AV63TFBR_Vital_Weight) )
               {
                  Ddo_br_vital_weight_Filteredtext_set = StringUtil.Str( AV63TFBR_Vital_Weight, 15, 5);
                  ucDdo_br_vital_weight.SendProperty(context, "", false, Ddo_br_vital_weight_Internalname, "FilteredText_set", Ddo_br_vital_weight_Filteredtext_set);
               }
               if ( ! (Convert.ToDecimal(0)==AV64TFBR_Vital_Weight_To) )
               {
                  Ddo_br_vital_weight_Filteredtextto_set = StringUtil.Str( AV64TFBR_Vital_Weight_To, 15, 5);
                  ucDdo_br_vital_weight.SendProperty(context, "", false, Ddo_br_vital_weight_Internalname, "FilteredTextTo_set", Ddo_br_vital_weight_Filteredtextto_set);
               }
            }
            AV108GXV1 = (int)(AV108GXV1+1);
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
         AV11GridState.FromXml(AV15Session.Get(AV107Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV11GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV11GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV11GridState.gxTpr_Filtervalues.Clear();
         if ( ! ( (0==AV17TFBR_VitalID) && (0==AV18TFBR_VitalID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_VITALID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV17TFBR_VitalID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV18TFBR_VitalID_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (0==AV21TFBR_EncounterID) && (0==AV22TFBR_EncounterID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_ENCOUNTERID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV21TFBR_EncounterID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV22TFBR_EncounterID_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV25TFBR_Information_PatientNo)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_INFORMATION_PATIENTNO";
            AV12GridStateFilterValue.gxTpr_Value = AV25TFBR_Information_PatientNo;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26TFBR_Information_PatientNo_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_INFORMATION_PATIENTNO_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV26TFBR_Information_PatientNo_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (0==AV29TFBR_Vital_VitalID) && (0==AV30TFBR_Vital_VitalID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_VITAL_VITALID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV29TFBR_Vital_VitalID), 10, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV30TFBR_Vital_VitalID_To), 10, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (DateTime.MinValue==AV33TFBR_Vital_MeasureDate) && (DateTime.MinValue==AV34TFBR_Vital_MeasureDate_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_VITAL_MEASUREDATE";
            AV12GridStateFilterValue.gxTpr_Value = context.localUtil.DToC( AV33TFBR_Vital_MeasureDate, 0, "/");
            AV12GridStateFilterValue.gxTpr_Valueto = context.localUtil.DToC( AV34TFBR_Vital_MeasureDate_To, 0, "/");
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (Convert.ToDecimal(0)==AV39TFBR_Vital_Temperature) && (Convert.ToDecimal(0)==AV40TFBR_Vital_Temperature_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_VITAL_TEMPERATURE";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( AV39TFBR_Vital_Temperature, 15, 5);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( AV40TFBR_Vital_Temperature_To, 15, 5);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (Convert.ToDecimal(0)==AV43TFBR_Vital_Pulse) && (Convert.ToDecimal(0)==AV44TFBR_Vital_Pulse_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_VITAL_PULSE";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( AV43TFBR_Vital_Pulse, 15, 5);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( AV44TFBR_Vital_Pulse_To, 15, 5);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (Convert.ToDecimal(0)==AV47TFBR_Vital_Respiration) && (Convert.ToDecimal(0)==AV48TFBR_Vital_Respiration_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_VITAL_RESPIRATION";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( AV47TFBR_Vital_Respiration, 15, 5);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( AV48TFBR_Vital_Respiration_To, 15, 5);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (Convert.ToDecimal(0)==AV51TFBR_Vital_Systolic) && (Convert.ToDecimal(0)==AV52TFBR_Vital_Systolic_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_VITAL_SYSTOLIC";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( AV51TFBR_Vital_Systolic, 15, 5);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( AV52TFBR_Vital_Systolic_To, 15, 5);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (Convert.ToDecimal(0)==AV55TFBR_Vital_Diastolic) && (Convert.ToDecimal(0)==AV56TFBR_Vital_Diastolic_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_VITAL_DIASTOLIC";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( AV55TFBR_Vital_Diastolic, 15, 5);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( AV56TFBR_Vital_Diastolic_To, 15, 5);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (Convert.ToDecimal(0)==AV59TFBR_Vital_Height) && (Convert.ToDecimal(0)==AV60TFBR_Vital_Height_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_VITAL_HEIGHT";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( AV59TFBR_Vital_Height, 15, 5);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( AV60TFBR_Vital_Height_To, 15, 5);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (Convert.ToDecimal(0)==AV63TFBR_Vital_Weight) && (Convert.ToDecimal(0)==AV64TFBR_Vital_Weight_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_VITAL_WEIGHT";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( AV63TFBR_Vital_Weight, 15, 5);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( AV64TFBR_Vital_Weight_To, 15, 5);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         AV11GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV11GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV107Pgmname+"GridState",  AV11GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV107Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Vital";
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
         PA5Y2( ) ;
         WS5Y2( ) ;
         WE5Y2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279462174", true);
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
         context.AddJavascriptSource("br_vitalww.js", "?20202279462175", false);
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
         edtBR_VitalID_Internalname = "BR_VITALID_"+sGXsfl_31_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_31_idx;
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO_"+sGXsfl_31_idx;
         edtBR_Vital_VitalID_Internalname = "BR_VITAL_VITALID_"+sGXsfl_31_idx;
         edtBR_Vital_MeasureDate_Internalname = "BR_VITAL_MEASUREDATE_"+sGXsfl_31_idx;
         edtBR_Vital_Temperature_Internalname = "BR_VITAL_TEMPERATURE_"+sGXsfl_31_idx;
         edtBR_Vital_Pulse_Internalname = "BR_VITAL_PULSE_"+sGXsfl_31_idx;
         edtBR_Vital_Respiration_Internalname = "BR_VITAL_RESPIRATION_"+sGXsfl_31_idx;
         edtBR_Vital_Systolic_Internalname = "BR_VITAL_SYSTOLIC_"+sGXsfl_31_idx;
         edtBR_Vital_Diastolic_Internalname = "BR_VITAL_DIASTOLIC_"+sGXsfl_31_idx;
         edtBR_Vital_Height_Internalname = "BR_VITAL_HEIGHT_"+sGXsfl_31_idx;
         edtBR_Vital_Weight_Internalname = "BR_VITAL_WEIGHT_"+sGXsfl_31_idx;
      }

      protected void SubsflControlProps_fel_312( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_31_fel_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_31_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_31_fel_idx;
         edtBR_VitalID_Internalname = "BR_VITALID_"+sGXsfl_31_fel_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_31_fel_idx;
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO_"+sGXsfl_31_fel_idx;
         edtBR_Vital_VitalID_Internalname = "BR_VITAL_VITALID_"+sGXsfl_31_fel_idx;
         edtBR_Vital_MeasureDate_Internalname = "BR_VITAL_MEASUREDATE_"+sGXsfl_31_fel_idx;
         edtBR_Vital_Temperature_Internalname = "BR_VITAL_TEMPERATURE_"+sGXsfl_31_fel_idx;
         edtBR_Vital_Pulse_Internalname = "BR_VITAL_PULSE_"+sGXsfl_31_fel_idx;
         edtBR_Vital_Respiration_Internalname = "BR_VITAL_RESPIRATION_"+sGXsfl_31_fel_idx;
         edtBR_Vital_Systolic_Internalname = "BR_VITAL_SYSTOLIC_"+sGXsfl_31_fel_idx;
         edtBR_Vital_Diastolic_Internalname = "BR_VITAL_DIASTOLIC_"+sGXsfl_31_fel_idx;
         edtBR_Vital_Height_Internalname = "BR_VITAL_HEIGHT_"+sGXsfl_31_fel_idx;
         edtBR_Vital_Weight_Internalname = "BR_VITAL_WEIGHT_"+sGXsfl_31_fel_idx;
      }

      protected void sendrow_312( )
      {
         SubsflControlProps_312( ) ;
         WB5Y0( ) ;
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
            AV71Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV71Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV104Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV71Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV71Display)) ? AV104Display_GXI : context.PathToRelativeUrl( AV71Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV71Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV72Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV72Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV105Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV72Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV72Update)) ? AV105Update_GXI : context.PathToRelativeUrl( AV72Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavUpdate_Visible,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV72Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "DeleteAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV74Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV74Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV106Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV74Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV74Delete)) ? AV106Delete_GXI : context.PathToRelativeUrl( AV74Delete));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)edtavDelete_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavDelete_Visible,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV74Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_VitalID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A150BR_VitalID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A150BR_VitalID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_VitalID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_EncounterID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_EncounterID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Information_PatientNo_Internalname,(String)A36BR_Information_PatientNo,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtBR_Information_PatientNo_Link,(String)"",(String)"",(String)"",(String)edtBR_Information_PatientNo_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)410,(String)"px",(short)17,(String)"px",(short)2000,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Vital_VitalID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A151BR_Vital_VitalID), 10, 0, ".", "")),context.localUtil.Format( (decimal)(A151BR_Vital_VitalID), "ZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Vital_VitalID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Vital_MeasureDate_Internalname,context.localUtil.Format(A152BR_Vital_MeasureDate, "9999/99/99"),context.localUtil.Format( A152BR_Vital_MeasureDate, "9999/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Vital_MeasureDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Date",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Vital_Temperature_Internalname,StringUtil.LTrim( StringUtil.NToC( A153BR_Vital_Temperature, 15, 5, ".", "")),context.localUtil.Format( A153BR_Vital_Temperature, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Vital_Temperature_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Vital_Pulse_Internalname,StringUtil.LTrim( StringUtil.NToC( A154BR_Vital_Pulse, 15, 5, ".", "")),context.localUtil.Format( A154BR_Vital_Pulse, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Vital_Pulse_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Vital_Respiration_Internalname,StringUtil.LTrim( StringUtil.NToC( A155BR_Vital_Respiration, 15, 5, ".", "")),context.localUtil.Format( A155BR_Vital_Respiration, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Vital_Respiration_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Vital_Systolic_Internalname,StringUtil.LTrim( StringUtil.NToC( A156BR_Vital_Systolic, 15, 5, ".", "")),context.localUtil.Format( A156BR_Vital_Systolic, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Vital_Systolic_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Vital_Diastolic_Internalname,StringUtil.LTrim( StringUtil.NToC( A157BR_Vital_Diastolic, 15, 5, ".", "")),context.localUtil.Format( A157BR_Vital_Diastolic, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Vital_Diastolic_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Vital_Height_Internalname,StringUtil.LTrim( StringUtil.NToC( A158BR_Vital_Height, 15, 5, ".", "")),context.localUtil.Format( A158BR_Vital_Height, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Vital_Height_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Vital_Weight_Internalname,StringUtil.LTrim( StringUtil.NToC( A159BR_Vital_Weight, 15, 5, ".", "")),context.localUtil.Format( A159BR_Vital_Weight, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Vital_Weight_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            send_integrity_lvl_hashes5Y2( ) ;
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
         edtBR_VitalID_Internalname = "BR_VITALID";
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO";
         edtBR_Vital_VitalID_Internalname = "BR_VITAL_VITALID";
         edtBR_Vital_MeasureDate_Internalname = "BR_VITAL_MEASUREDATE";
         edtBR_Vital_Temperature_Internalname = "BR_VITAL_TEMPERATURE";
         edtBR_Vital_Pulse_Internalname = "BR_VITAL_PULSE";
         edtBR_Vital_Respiration_Internalname = "BR_VITAL_RESPIRATION";
         edtBR_Vital_Systolic_Internalname = "BR_VITAL_SYSTOLIC";
         edtBR_Vital_Diastolic_Internalname = "BR_VITAL_DIASTOLIC";
         edtBR_Vital_Height_Internalname = "BR_VITAL_HEIGHT";
         edtBR_Vital_Weight_Internalname = "BR_VITAL_WEIGHT";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_vitalid_Internalname = "DDO_BR_VITALID";
         edtavDdo_br_vitalidtitlecontrolidtoreplace_Internalname = "vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE";
         Ddo_br_encounterid_Internalname = "DDO_BR_ENCOUNTERID";
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE";
         Ddo_br_information_patientno_Internalname = "DDO_BR_INFORMATION_PATIENTNO";
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname = "vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE";
         Ddo_br_vital_vitalid_Internalname = "DDO_BR_VITAL_VITALID";
         edtavDdo_br_vital_vitalidtitlecontrolidtoreplace_Internalname = "vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE";
         Ddo_br_vital_measuredate_Internalname = "DDO_BR_VITAL_MEASUREDATE";
         edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Internalname = "vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE";
         Ddo_br_vital_temperature_Internalname = "DDO_BR_VITAL_TEMPERATURE";
         edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Internalname = "vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE";
         Ddo_br_vital_pulse_Internalname = "DDO_BR_VITAL_PULSE";
         edtavDdo_br_vital_pulsetitlecontrolidtoreplace_Internalname = "vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE";
         Ddo_br_vital_respiration_Internalname = "DDO_BR_VITAL_RESPIRATION";
         edtavDdo_br_vital_respirationtitlecontrolidtoreplace_Internalname = "vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE";
         Ddo_br_vital_systolic_Internalname = "DDO_BR_VITAL_SYSTOLIC";
         edtavDdo_br_vital_systolictitlecontrolidtoreplace_Internalname = "vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE";
         Ddo_br_vital_diastolic_Internalname = "DDO_BR_VITAL_DIASTOLIC";
         edtavDdo_br_vital_diastolictitlecontrolidtoreplace_Internalname = "vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE";
         Ddo_br_vital_height_Internalname = "DDO_BR_VITAL_HEIGHT";
         edtavDdo_br_vital_heighttitlecontrolidtoreplace_Internalname = "vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE";
         Ddo_br_vital_weight_Internalname = "DDO_BR_VITAL_WEIGHT";
         edtavDdo_br_vital_weighttitlecontrolidtoreplace_Internalname = "vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         edtavTfbr_vitalid_Internalname = "vTFBR_VITALID";
         edtavTfbr_vitalid_to_Internalname = "vTFBR_VITALID_TO";
         edtavTfbr_encounterid_Internalname = "vTFBR_ENCOUNTERID";
         edtavTfbr_encounterid_to_Internalname = "vTFBR_ENCOUNTERID_TO";
         edtavTfbr_information_patientno_Internalname = "vTFBR_INFORMATION_PATIENTNO";
         edtavTfbr_information_patientno_sel_Internalname = "vTFBR_INFORMATION_PATIENTNO_SEL";
         edtavTfbr_vital_vitalid_Internalname = "vTFBR_VITAL_VITALID";
         edtavTfbr_vital_vitalid_to_Internalname = "vTFBR_VITAL_VITALID_TO";
         edtavTfbr_vital_measuredate_Internalname = "vTFBR_VITAL_MEASUREDATE";
         edtavTfbr_vital_measuredate_to_Internalname = "vTFBR_VITAL_MEASUREDATE_TO";
         edtavDdo_br_vital_measuredateauxdate_Internalname = "vDDO_BR_VITAL_MEASUREDATEAUXDATE";
         edtavDdo_br_vital_measuredateauxdateto_Internalname = "vDDO_BR_VITAL_MEASUREDATEAUXDATETO";
         divDdo_br_vital_measuredateauxdates_Internalname = "DDO_BR_VITAL_MEASUREDATEAUXDATES";
         edtavTfbr_vital_temperature_Internalname = "vTFBR_VITAL_TEMPERATURE";
         edtavTfbr_vital_temperature_to_Internalname = "vTFBR_VITAL_TEMPERATURE_TO";
         edtavTfbr_vital_pulse_Internalname = "vTFBR_VITAL_PULSE";
         edtavTfbr_vital_pulse_to_Internalname = "vTFBR_VITAL_PULSE_TO";
         edtavTfbr_vital_respiration_Internalname = "vTFBR_VITAL_RESPIRATION";
         edtavTfbr_vital_respiration_to_Internalname = "vTFBR_VITAL_RESPIRATION_TO";
         edtavTfbr_vital_systolic_Internalname = "vTFBR_VITAL_SYSTOLIC";
         edtavTfbr_vital_systolic_to_Internalname = "vTFBR_VITAL_SYSTOLIC_TO";
         edtavTfbr_vital_diastolic_Internalname = "vTFBR_VITAL_DIASTOLIC";
         edtavTfbr_vital_diastolic_to_Internalname = "vTFBR_VITAL_DIASTOLIC_TO";
         edtavTfbr_vital_height_Internalname = "vTFBR_VITAL_HEIGHT";
         edtavTfbr_vital_height_to_Internalname = "vTFBR_VITAL_HEIGHT_TO";
         edtavTfbr_vital_weight_Internalname = "vTFBR_VITAL_WEIGHT";
         edtavTfbr_vital_weight_to_Internalname = "vTFBR_VITAL_WEIGHT_TO";
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
         edtBR_Vital_Weight_Jsonclick = "";
         edtBR_Vital_Height_Jsonclick = "";
         edtBR_Vital_Diastolic_Jsonclick = "";
         edtBR_Vital_Systolic_Jsonclick = "";
         edtBR_Vital_Respiration_Jsonclick = "";
         edtBR_Vital_Pulse_Jsonclick = "";
         edtBR_Vital_Temperature_Jsonclick = "";
         edtBR_Vital_MeasureDate_Jsonclick = "";
         edtBR_Vital_VitalID_Jsonclick = "";
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_EncounterID_Jsonclick = "";
         edtBR_VitalID_Jsonclick = "";
         edtavTfbr_vital_weight_to_Jsonclick = "";
         edtavTfbr_vital_weight_to_Visible = 1;
         edtavTfbr_vital_weight_Jsonclick = "";
         edtavTfbr_vital_weight_Visible = 1;
         edtavTfbr_vital_height_to_Jsonclick = "";
         edtavTfbr_vital_height_to_Visible = 1;
         edtavTfbr_vital_height_Jsonclick = "";
         edtavTfbr_vital_height_Visible = 1;
         edtavTfbr_vital_diastolic_to_Jsonclick = "";
         edtavTfbr_vital_diastolic_to_Visible = 1;
         edtavTfbr_vital_diastolic_Jsonclick = "";
         edtavTfbr_vital_diastolic_Visible = 1;
         edtavTfbr_vital_systolic_to_Jsonclick = "";
         edtavTfbr_vital_systolic_to_Visible = 1;
         edtavTfbr_vital_systolic_Jsonclick = "";
         edtavTfbr_vital_systolic_Visible = 1;
         edtavTfbr_vital_respiration_to_Jsonclick = "";
         edtavTfbr_vital_respiration_to_Visible = 1;
         edtavTfbr_vital_respiration_Jsonclick = "";
         edtavTfbr_vital_respiration_Visible = 1;
         edtavTfbr_vital_pulse_to_Jsonclick = "";
         edtavTfbr_vital_pulse_to_Visible = 1;
         edtavTfbr_vital_pulse_Jsonclick = "";
         edtavTfbr_vital_pulse_Visible = 1;
         edtavTfbr_vital_temperature_to_Jsonclick = "";
         edtavTfbr_vital_temperature_to_Visible = 1;
         edtavTfbr_vital_temperature_Jsonclick = "";
         edtavTfbr_vital_temperature_Visible = 1;
         edtavDdo_br_vital_measuredateauxdateto_Jsonclick = "";
         edtavDdo_br_vital_measuredateauxdate_Jsonclick = "";
         edtavTfbr_vital_measuredate_to_Jsonclick = "";
         edtavTfbr_vital_measuredate_to_Visible = 1;
         edtavTfbr_vital_measuredate_Jsonclick = "";
         edtavTfbr_vital_measuredate_Visible = 1;
         edtavTfbr_vital_vitalid_to_Jsonclick = "";
         edtavTfbr_vital_vitalid_to_Visible = 1;
         edtavTfbr_vital_vitalid_Jsonclick = "";
         edtavTfbr_vital_vitalid_Visible = 1;
         edtavTfbr_information_patientno_sel_Jsonclick = "";
         edtavTfbr_information_patientno_sel_Visible = 1;
         edtavTfbr_information_patientno_Jsonclick = "";
         edtavTfbr_information_patientno_Visible = 1;
         edtavTfbr_encounterid_to_Jsonclick = "";
         edtavTfbr_encounterid_to_Visible = 1;
         edtavTfbr_encounterid_Jsonclick = "";
         edtavTfbr_encounterid_Visible = 1;
         edtavTfbr_vitalid_to_Jsonclick = "";
         edtavTfbr_vitalid_to_Visible = 1;
         edtavTfbr_vitalid_Jsonclick = "";
         edtavTfbr_vitalid_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_vital_weighttitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_vital_heighttitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_vital_diastolictitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_vital_systolictitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_vital_respirationtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_vital_pulsetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_vital_vitalidtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_vitalidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtBR_Information_PatientNo_Link = "";
         edtavDelete_Tooltiptext = "删除";
         edtavDelete_Link = "";
         edtavUpdate_Tooltiptext = "修改";
         edtavUpdate_Link = "";
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Vital_Weight_Titleformat = 0;
         edtBR_Vital_Weight_Title = "体重(kg)";
         edtBR_Vital_Height_Titleformat = 0;
         edtBR_Vital_Height_Title = "身高(cm)";
         edtBR_Vital_Diastolic_Titleformat = 0;
         edtBR_Vital_Diastolic_Title = "Hg)";
         edtBR_Vital_Systolic_Titleformat = 0;
         edtBR_Vital_Systolic_Title = "Hg)";
         edtBR_Vital_Respiration_Titleformat = 0;
         edtBR_Vital_Respiration_Title = "呼吸频率(次/分钟)";
         edtBR_Vital_Pulse_Titleformat = 0;
         edtBR_Vital_Pulse_Title = "脉搏(次/分钟)";
         edtBR_Vital_Temperature_Titleformat = 0;
         edtBR_Vital_Temperature_Title = "体温(℃)";
         edtBR_Vital_MeasureDate_Titleformat = 0;
         edtBR_Vital_MeasureDate_Title = "测量日期";
         edtBR_Vital_VitalID_Titleformat = 0;
         edtBR_Vital_VitalID_Title = "指标序号";
         edtBR_Information_PatientNo_Titleformat = 0;
         edtBR_Information_PatientNo_Title = "患者编号";
         edtBR_EncounterID_Titleformat = 0;
         edtBR_EncounterID_Title = "就诊信息主键";
         edtBR_VitalID_Titleformat = 0;
         edtBR_VitalID_Title = "生命体征主键";
         edtavDelete_Visible = -1;
         edtavUpdate_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         bttBtninsert_Visible = 1;
         Ddo_br_vital_weight_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_vital_weight_Rangefilterto = "WWP_TSTo";
         Ddo_br_vital_weight_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_vital_weight_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_vital_weight_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_vital_weight_Sortasc = "WWP_TSSortASC";
         Ddo_br_vital_weight_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_vital_weight_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_vital_weight_Filtertype = "Numeric";
         Ddo_br_vital_weight_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_vital_weight_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_vital_weight_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_vital_weight_Titlecontrolidtoreplace = "";
         Ddo_br_vital_weight_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_vital_weight_Cls = "ColumnSettings";
         Ddo_br_vital_weight_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_vital_weight_Caption = "";
         Ddo_br_vital_height_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_vital_height_Rangefilterto = "WWP_TSTo";
         Ddo_br_vital_height_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_vital_height_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_vital_height_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_vital_height_Sortasc = "WWP_TSSortASC";
         Ddo_br_vital_height_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_vital_height_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_vital_height_Filtertype = "Numeric";
         Ddo_br_vital_height_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_vital_height_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_vital_height_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_vital_height_Titlecontrolidtoreplace = "";
         Ddo_br_vital_height_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_vital_height_Cls = "ColumnSettings";
         Ddo_br_vital_height_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_vital_height_Caption = "";
         Ddo_br_vital_diastolic_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_vital_diastolic_Rangefilterto = "WWP_TSTo";
         Ddo_br_vital_diastolic_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_vital_diastolic_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_vital_diastolic_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_vital_diastolic_Sortasc = "WWP_TSSortASC";
         Ddo_br_vital_diastolic_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_vital_diastolic_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_vital_diastolic_Filtertype = "Numeric";
         Ddo_br_vital_diastolic_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_vital_diastolic_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_vital_diastolic_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_vital_diastolic_Titlecontrolidtoreplace = "";
         Ddo_br_vital_diastolic_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_vital_diastolic_Cls = "ColumnSettings";
         Ddo_br_vital_diastolic_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_vital_diastolic_Caption = "";
         Ddo_br_vital_systolic_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_vital_systolic_Rangefilterto = "WWP_TSTo";
         Ddo_br_vital_systolic_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_vital_systolic_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_vital_systolic_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_vital_systolic_Sortasc = "WWP_TSSortASC";
         Ddo_br_vital_systolic_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_vital_systolic_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_vital_systolic_Filtertype = "Numeric";
         Ddo_br_vital_systolic_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_vital_systolic_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_vital_systolic_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_vital_systolic_Titlecontrolidtoreplace = "";
         Ddo_br_vital_systolic_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_vital_systolic_Cls = "ColumnSettings";
         Ddo_br_vital_systolic_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_vital_systolic_Caption = "";
         Ddo_br_vital_respiration_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_vital_respiration_Rangefilterto = "WWP_TSTo";
         Ddo_br_vital_respiration_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_vital_respiration_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_vital_respiration_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_vital_respiration_Sortasc = "WWP_TSSortASC";
         Ddo_br_vital_respiration_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_vital_respiration_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_vital_respiration_Filtertype = "Numeric";
         Ddo_br_vital_respiration_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_vital_respiration_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_vital_respiration_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_vital_respiration_Titlecontrolidtoreplace = "";
         Ddo_br_vital_respiration_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_vital_respiration_Cls = "ColumnSettings";
         Ddo_br_vital_respiration_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_vital_respiration_Caption = "";
         Ddo_br_vital_pulse_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_vital_pulse_Rangefilterto = "WWP_TSTo";
         Ddo_br_vital_pulse_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_vital_pulse_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_vital_pulse_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_vital_pulse_Sortasc = "WWP_TSSortASC";
         Ddo_br_vital_pulse_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_vital_pulse_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_vital_pulse_Filtertype = "Numeric";
         Ddo_br_vital_pulse_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_vital_pulse_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_vital_pulse_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_vital_pulse_Titlecontrolidtoreplace = "";
         Ddo_br_vital_pulse_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_vital_pulse_Cls = "ColumnSettings";
         Ddo_br_vital_pulse_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_vital_pulse_Caption = "";
         Ddo_br_vital_temperature_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_vital_temperature_Rangefilterto = "WWP_TSTo";
         Ddo_br_vital_temperature_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_vital_temperature_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_vital_temperature_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_vital_temperature_Sortasc = "WWP_TSSortASC";
         Ddo_br_vital_temperature_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_vital_temperature_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_vital_temperature_Filtertype = "Numeric";
         Ddo_br_vital_temperature_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_vital_temperature_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_vital_temperature_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_vital_temperature_Titlecontrolidtoreplace = "";
         Ddo_br_vital_temperature_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_vital_temperature_Cls = "ColumnSettings";
         Ddo_br_vital_temperature_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_vital_temperature_Caption = "";
         Ddo_br_vital_measuredate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_vital_measuredate_Rangefilterto = "WWP_TSTo";
         Ddo_br_vital_measuredate_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_vital_measuredate_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_vital_measuredate_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_vital_measuredate_Sortasc = "WWP_TSSortASC";
         Ddo_br_vital_measuredate_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_vital_measuredate_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_vital_measuredate_Filtertype = "Date";
         Ddo_br_vital_measuredate_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_vital_measuredate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_vital_measuredate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_vital_measuredate_Titlecontrolidtoreplace = "";
         Ddo_br_vital_measuredate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_vital_measuredate_Cls = "ColumnSettings";
         Ddo_br_vital_measuredate_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_vital_measuredate_Caption = "";
         Ddo_br_vital_vitalid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_vital_vitalid_Rangefilterto = "WWP_TSTo";
         Ddo_br_vital_vitalid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_vital_vitalid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_vital_vitalid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_vital_vitalid_Sortasc = "WWP_TSSortASC";
         Ddo_br_vital_vitalid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_vital_vitalid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_vital_vitalid_Filtertype = "Numeric";
         Ddo_br_vital_vitalid_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_vital_vitalid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_vital_vitalid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_vital_vitalid_Titlecontrolidtoreplace = "";
         Ddo_br_vital_vitalid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_vital_vitalid_Cls = "ColumnSettings";
         Ddo_br_vital_vitalid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_vital_vitalid_Caption = "";
         Ddo_br_information_patientno_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_information_patientno_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_information_patientno_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_information_patientno_Loadingdata = "WWP_TSLoading";
         Ddo_br_information_patientno_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_information_patientno_Sortasc = "WWP_TSSortASC";
         Ddo_br_information_patientno_Datalistupdateminimumcharacters = 0;
         Ddo_br_information_patientno_Datalistproc = "BR_VitalWWGetFilterData";
         Ddo_br_information_patientno_Datalisttype = "Dynamic";
         Ddo_br_information_patientno_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_information_patientno_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_information_patientno_Filtertype = "Character";
         Ddo_br_information_patientno_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_information_patientno_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_information_patientno_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_information_patientno_Titlecontrolidtoreplace = "";
         Ddo_br_information_patientno_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_information_patientno_Cls = "ColumnSettings";
         Ddo_br_information_patientno_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_information_patientno_Caption = "";
         Ddo_br_encounterid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounterid_Rangefilterto = "WWP_TSTo";
         Ddo_br_encounterid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_encounterid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_encounterid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounterid_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounterid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounterid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_encounterid_Filtertype = "Numeric";
         Ddo_br_encounterid_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_encounterid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounterid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounterid_Titlecontrolidtoreplace = "";
         Ddo_br_encounterid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounterid_Cls = "ColumnSettings";
         Ddo_br_encounterid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounterid_Caption = "";
         Ddo_br_vitalid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_vitalid_Rangefilterto = "WWP_TSTo";
         Ddo_br_vitalid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_vitalid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_vitalid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_vitalid_Sortasc = "WWP_TSSortASC";
         Ddo_br_vitalid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_vitalid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_vitalid_Filtertype = "Numeric";
         Ddo_br_vitalid_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_vitalid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_vitalid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_vitalid_Titlecontrolidtoreplace = "";
         Ddo_br_vitalid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_vitalid_Cls = "ColumnSettings";
         Ddo_br_vitalid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_vitalid_Caption = "";
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
         Form.Caption = " 生命体征";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV73IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV75IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV19ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Vital_PulseTitleControlIdToReplace',fld:'vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Vital_RespirationTitleControlIdToReplace',fld:'vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Vital_SystolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Vital_HeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV17TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_Vital_VitalID',fld:'vTFBR_VITAL_VITALID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_Vital_VitalID_To',fld:'vTFBR_VITAL_VITALID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV34TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'AV39TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV40TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV43TFBR_Vital_Pulse',fld:'vTFBR_VITAL_PULSE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV44TFBR_Vital_Pulse_To',fld:'vTFBR_VITAL_PULSE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV47TFBR_Vital_Respiration',fld:'vTFBR_VITAL_RESPIRATION',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV48TFBR_Vital_Respiration_To',fld:'vTFBR_VITAL_RESPIRATION_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Vital_Systolic',fld:'vTFBR_VITAL_SYSTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV52TFBR_Vital_Systolic_To',fld:'vTFBR_VITAL_SYSTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV55TFBR_Vital_Diastolic',fld:'vTFBR_VITAL_DIASTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Vital_Diastolic_To',fld:'vTFBR_VITAL_DIASTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV59TFBR_Vital_Height',fld:'vTFBR_VITAL_HEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Vital_Height_To',fld:'vTFBR_VITAL_HEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV63TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV64TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV107Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV76IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV16BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV28BR_Vital_VitalIDTitleFilterData',fld:'vBR_VITAL_VITALIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV38BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'AV42BR_Vital_PulseTitleFilterData',fld:'vBR_VITAL_PULSETITLEFILTERDATA',pic:''},{av:'AV46BR_Vital_RespirationTitleFilterData',fld:'vBR_VITAL_RESPIRATIONTITLEFILTERDATA',pic:''},{av:'AV50BR_Vital_SystolicTitleFilterData',fld:'vBR_VITAL_SYSTOLICTITLEFILTERDATA',pic:''},{av:'AV54BR_Vital_DiastolicTitleFilterData',fld:'vBR_VITAL_DIASTOLICTITLEFILTERDATA',pic:''},{av:'AV58BR_Vital_HeightTitleFilterData',fld:'vBR_VITAL_HEIGHTTITLEFILTERDATA',pic:''},{av:'AV62BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Vital_VitalID_Titleformat',ctrl:'BR_VITAL_VITALID',prop:'Titleformat'},{av:'edtBR_Vital_VitalID_Title',ctrl:'BR_VITAL_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'edtBR_Vital_Pulse_Titleformat',ctrl:'BR_VITAL_PULSE',prop:'Titleformat'},{av:'edtBR_Vital_Pulse_Title',ctrl:'BR_VITAL_PULSE',prop:'Title'},{av:'edtBR_Vital_Respiration_Titleformat',ctrl:'BR_VITAL_RESPIRATION',prop:'Titleformat'},{av:'edtBR_Vital_Respiration_Title',ctrl:'BR_VITAL_RESPIRATION',prop:'Title'},{av:'edtBR_Vital_Systolic_Titleformat',ctrl:'BR_VITAL_SYSTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Systolic_Title',ctrl:'BR_VITAL_SYSTOLIC',prop:'Title'},{av:'edtBR_Vital_Diastolic_Titleformat',ctrl:'BR_VITAL_DIASTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Diastolic_Title',ctrl:'BR_VITAL_DIASTOLIC',prop:'Title'},{av:'edtBR_Vital_Height_Titleformat',ctrl:'BR_VITAL_HEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Height_Title',ctrl:'BR_VITAL_HEIGHT',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'AV68GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV69GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV70GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV73IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV75IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E115Y2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_Vital_VitalID',fld:'vTFBR_VITAL_VITALID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_Vital_VitalID_To',fld:'vTFBR_VITAL_VITALID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV34TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'AV39TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV40TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV43TFBR_Vital_Pulse',fld:'vTFBR_VITAL_PULSE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV44TFBR_Vital_Pulse_To',fld:'vTFBR_VITAL_PULSE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV47TFBR_Vital_Respiration',fld:'vTFBR_VITAL_RESPIRATION',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV48TFBR_Vital_Respiration_To',fld:'vTFBR_VITAL_RESPIRATION_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Vital_Systolic',fld:'vTFBR_VITAL_SYSTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV52TFBR_Vital_Systolic_To',fld:'vTFBR_VITAL_SYSTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV55TFBR_Vital_Diastolic',fld:'vTFBR_VITAL_DIASTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Vital_Diastolic_To',fld:'vTFBR_VITAL_DIASTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV59TFBR_Vital_Height',fld:'vTFBR_VITAL_HEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Vital_Height_To',fld:'vTFBR_VITAL_HEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV63TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV64TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV19ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Vital_PulseTitleControlIdToReplace',fld:'vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Vital_RespirationTitleControlIdToReplace',fld:'vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Vital_SystolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Vital_HeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV107Pgmname',fld:'vPGMNAME',pic:''},{av:'AV73IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV75IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV76IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E125Y2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_Vital_VitalID',fld:'vTFBR_VITAL_VITALID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_Vital_VitalID_To',fld:'vTFBR_VITAL_VITALID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV34TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'AV39TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV40TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV43TFBR_Vital_Pulse',fld:'vTFBR_VITAL_PULSE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV44TFBR_Vital_Pulse_To',fld:'vTFBR_VITAL_PULSE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV47TFBR_Vital_Respiration',fld:'vTFBR_VITAL_RESPIRATION',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV48TFBR_Vital_Respiration_To',fld:'vTFBR_VITAL_RESPIRATION_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Vital_Systolic',fld:'vTFBR_VITAL_SYSTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV52TFBR_Vital_Systolic_To',fld:'vTFBR_VITAL_SYSTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV55TFBR_Vital_Diastolic',fld:'vTFBR_VITAL_DIASTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Vital_Diastolic_To',fld:'vTFBR_VITAL_DIASTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV59TFBR_Vital_Height',fld:'vTFBR_VITAL_HEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Vital_Height_To',fld:'vTFBR_VITAL_HEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV63TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV64TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV19ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Vital_PulseTitleControlIdToReplace',fld:'vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Vital_RespirationTitleControlIdToReplace',fld:'vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Vital_SystolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Vital_HeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV107Pgmname',fld:'vPGMNAME',pic:''},{av:'AV73IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV75IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV76IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_VITALID.ONOPTIONCLICKED","{handler:'E135Y2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_Vital_VitalID',fld:'vTFBR_VITAL_VITALID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_Vital_VitalID_To',fld:'vTFBR_VITAL_VITALID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV34TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'AV39TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV40TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV43TFBR_Vital_Pulse',fld:'vTFBR_VITAL_PULSE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV44TFBR_Vital_Pulse_To',fld:'vTFBR_VITAL_PULSE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV47TFBR_Vital_Respiration',fld:'vTFBR_VITAL_RESPIRATION',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV48TFBR_Vital_Respiration_To',fld:'vTFBR_VITAL_RESPIRATION_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Vital_Systolic',fld:'vTFBR_VITAL_SYSTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV52TFBR_Vital_Systolic_To',fld:'vTFBR_VITAL_SYSTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV55TFBR_Vital_Diastolic',fld:'vTFBR_VITAL_DIASTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Vital_Diastolic_To',fld:'vTFBR_VITAL_DIASTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV59TFBR_Vital_Height',fld:'vTFBR_VITAL_HEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Vital_Height_To',fld:'vTFBR_VITAL_HEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV63TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV64TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV19ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Vital_PulseTitleControlIdToReplace',fld:'vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Vital_RespirationTitleControlIdToReplace',fld:'vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Vital_SystolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Vital_HeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV107Pgmname',fld:'vPGMNAME',pic:''},{av:'AV73IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV75IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV76IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_vitalid_Activeeventkey',ctrl:'DDO_BR_VITALID',prop:'ActiveEventKey'},{av:'Ddo_br_vitalid_Filteredtext_get',ctrl:'DDO_BR_VITALID',prop:'FilteredText_get'},{av:'Ddo_br_vitalid_Filteredtextto_get',ctrl:'DDO_BR_VITALID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_VITALID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_vitalid_Sortedstatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'AV17TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_vital_vitalid_Sortedstatus',ctrl:'DDO_BR_VITAL_VITALID',prop:'SortedStatus'},{av:'Ddo_br_vital_measuredate_Sortedstatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'Ddo_br_vital_temperature_Sortedstatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'},{av:'Ddo_br_vital_pulse_Sortedstatus',ctrl:'DDO_BR_VITAL_PULSE',prop:'SortedStatus'},{av:'Ddo_br_vital_respiration_Sortedstatus',ctrl:'DDO_BR_VITAL_RESPIRATION',prop:'SortedStatus'},{av:'Ddo_br_vital_systolic_Sortedstatus',ctrl:'DDO_BR_VITAL_SYSTOLIC',prop:'SortedStatus'},{av:'Ddo_br_vital_diastolic_Sortedstatus',ctrl:'DDO_BR_VITAL_DIASTOLIC',prop:'SortedStatus'},{av:'Ddo_br_vital_height_Sortedstatus',ctrl:'DDO_BR_VITAL_HEIGHT',prop:'SortedStatus'},{av:'Ddo_br_vital_weight_Sortedstatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'AV16BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV28BR_Vital_VitalIDTitleFilterData',fld:'vBR_VITAL_VITALIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV38BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'AV42BR_Vital_PulseTitleFilterData',fld:'vBR_VITAL_PULSETITLEFILTERDATA',pic:''},{av:'AV46BR_Vital_RespirationTitleFilterData',fld:'vBR_VITAL_RESPIRATIONTITLEFILTERDATA',pic:''},{av:'AV50BR_Vital_SystolicTitleFilterData',fld:'vBR_VITAL_SYSTOLICTITLEFILTERDATA',pic:''},{av:'AV54BR_Vital_DiastolicTitleFilterData',fld:'vBR_VITAL_DIASTOLICTITLEFILTERDATA',pic:''},{av:'AV58BR_Vital_HeightTitleFilterData',fld:'vBR_VITAL_HEIGHTTITLEFILTERDATA',pic:''},{av:'AV62BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Vital_VitalID_Titleformat',ctrl:'BR_VITAL_VITALID',prop:'Titleformat'},{av:'edtBR_Vital_VitalID_Title',ctrl:'BR_VITAL_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'edtBR_Vital_Pulse_Titleformat',ctrl:'BR_VITAL_PULSE',prop:'Titleformat'},{av:'edtBR_Vital_Pulse_Title',ctrl:'BR_VITAL_PULSE',prop:'Title'},{av:'edtBR_Vital_Respiration_Titleformat',ctrl:'BR_VITAL_RESPIRATION',prop:'Titleformat'},{av:'edtBR_Vital_Respiration_Title',ctrl:'BR_VITAL_RESPIRATION',prop:'Title'},{av:'edtBR_Vital_Systolic_Titleformat',ctrl:'BR_VITAL_SYSTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Systolic_Title',ctrl:'BR_VITAL_SYSTOLIC',prop:'Title'},{av:'edtBR_Vital_Diastolic_Titleformat',ctrl:'BR_VITAL_DIASTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Diastolic_Title',ctrl:'BR_VITAL_DIASTOLIC',prop:'Title'},{av:'edtBR_Vital_Height_Titleformat',ctrl:'BR_VITAL_HEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Height_Title',ctrl:'BR_VITAL_HEIGHT',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'AV68GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV69GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV70GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV73IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV75IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED","{handler:'E145Y2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_Vital_VitalID',fld:'vTFBR_VITAL_VITALID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_Vital_VitalID_To',fld:'vTFBR_VITAL_VITALID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV34TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'AV39TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV40TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV43TFBR_Vital_Pulse',fld:'vTFBR_VITAL_PULSE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV44TFBR_Vital_Pulse_To',fld:'vTFBR_VITAL_PULSE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV47TFBR_Vital_Respiration',fld:'vTFBR_VITAL_RESPIRATION',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV48TFBR_Vital_Respiration_To',fld:'vTFBR_VITAL_RESPIRATION_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Vital_Systolic',fld:'vTFBR_VITAL_SYSTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV52TFBR_Vital_Systolic_To',fld:'vTFBR_VITAL_SYSTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV55TFBR_Vital_Diastolic',fld:'vTFBR_VITAL_DIASTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Vital_Diastolic_To',fld:'vTFBR_VITAL_DIASTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV59TFBR_Vital_Height',fld:'vTFBR_VITAL_HEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Vital_Height_To',fld:'vTFBR_VITAL_HEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV63TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV64TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV19ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Vital_PulseTitleControlIdToReplace',fld:'vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Vital_RespirationTitleControlIdToReplace',fld:'vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Vital_SystolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Vital_HeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV107Pgmname',fld:'vPGMNAME',pic:''},{av:'AV73IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV75IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV76IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_encounterid_Activeeventkey',ctrl:'DDO_BR_ENCOUNTERID',prop:'ActiveEventKey'},{av:'Ddo_br_encounterid_Filteredtext_get',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredText_get'},{av:'Ddo_br_encounterid_Filteredtextto_get',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_vitalid_Sortedstatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_vital_vitalid_Sortedstatus',ctrl:'DDO_BR_VITAL_VITALID',prop:'SortedStatus'},{av:'Ddo_br_vital_measuredate_Sortedstatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'Ddo_br_vital_temperature_Sortedstatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'},{av:'Ddo_br_vital_pulse_Sortedstatus',ctrl:'DDO_BR_VITAL_PULSE',prop:'SortedStatus'},{av:'Ddo_br_vital_respiration_Sortedstatus',ctrl:'DDO_BR_VITAL_RESPIRATION',prop:'SortedStatus'},{av:'Ddo_br_vital_systolic_Sortedstatus',ctrl:'DDO_BR_VITAL_SYSTOLIC',prop:'SortedStatus'},{av:'Ddo_br_vital_diastolic_Sortedstatus',ctrl:'DDO_BR_VITAL_DIASTOLIC',prop:'SortedStatus'},{av:'Ddo_br_vital_height_Sortedstatus',ctrl:'DDO_BR_VITAL_HEIGHT',prop:'SortedStatus'},{av:'Ddo_br_vital_weight_Sortedstatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'AV16BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV28BR_Vital_VitalIDTitleFilterData',fld:'vBR_VITAL_VITALIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV38BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'AV42BR_Vital_PulseTitleFilterData',fld:'vBR_VITAL_PULSETITLEFILTERDATA',pic:''},{av:'AV46BR_Vital_RespirationTitleFilterData',fld:'vBR_VITAL_RESPIRATIONTITLEFILTERDATA',pic:''},{av:'AV50BR_Vital_SystolicTitleFilterData',fld:'vBR_VITAL_SYSTOLICTITLEFILTERDATA',pic:''},{av:'AV54BR_Vital_DiastolicTitleFilterData',fld:'vBR_VITAL_DIASTOLICTITLEFILTERDATA',pic:''},{av:'AV58BR_Vital_HeightTitleFilterData',fld:'vBR_VITAL_HEIGHTTITLEFILTERDATA',pic:''},{av:'AV62BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Vital_VitalID_Titleformat',ctrl:'BR_VITAL_VITALID',prop:'Titleformat'},{av:'edtBR_Vital_VitalID_Title',ctrl:'BR_VITAL_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'edtBR_Vital_Pulse_Titleformat',ctrl:'BR_VITAL_PULSE',prop:'Titleformat'},{av:'edtBR_Vital_Pulse_Title',ctrl:'BR_VITAL_PULSE',prop:'Title'},{av:'edtBR_Vital_Respiration_Titleformat',ctrl:'BR_VITAL_RESPIRATION',prop:'Titleformat'},{av:'edtBR_Vital_Respiration_Title',ctrl:'BR_VITAL_RESPIRATION',prop:'Title'},{av:'edtBR_Vital_Systolic_Titleformat',ctrl:'BR_VITAL_SYSTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Systolic_Title',ctrl:'BR_VITAL_SYSTOLIC',prop:'Title'},{av:'edtBR_Vital_Diastolic_Titleformat',ctrl:'BR_VITAL_DIASTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Diastolic_Title',ctrl:'BR_VITAL_DIASTOLIC',prop:'Title'},{av:'edtBR_Vital_Height_Titleformat',ctrl:'BR_VITAL_HEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Height_Title',ctrl:'BR_VITAL_HEIGHT',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'AV68GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV69GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV70GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV73IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV75IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED","{handler:'E155Y2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_Vital_VitalID',fld:'vTFBR_VITAL_VITALID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_Vital_VitalID_To',fld:'vTFBR_VITAL_VITALID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV34TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'AV39TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV40TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV43TFBR_Vital_Pulse',fld:'vTFBR_VITAL_PULSE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV44TFBR_Vital_Pulse_To',fld:'vTFBR_VITAL_PULSE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV47TFBR_Vital_Respiration',fld:'vTFBR_VITAL_RESPIRATION',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV48TFBR_Vital_Respiration_To',fld:'vTFBR_VITAL_RESPIRATION_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Vital_Systolic',fld:'vTFBR_VITAL_SYSTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV52TFBR_Vital_Systolic_To',fld:'vTFBR_VITAL_SYSTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV55TFBR_Vital_Diastolic',fld:'vTFBR_VITAL_DIASTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Vital_Diastolic_To',fld:'vTFBR_VITAL_DIASTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV59TFBR_Vital_Height',fld:'vTFBR_VITAL_HEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Vital_Height_To',fld:'vTFBR_VITAL_HEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV63TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV64TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV19ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Vital_PulseTitleControlIdToReplace',fld:'vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Vital_RespirationTitleControlIdToReplace',fld:'vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Vital_SystolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Vital_HeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV107Pgmname',fld:'vPGMNAME',pic:''},{av:'AV73IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV75IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV76IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_information_patientno_Activeeventkey',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'ActiveEventKey'},{av:'Ddo_br_information_patientno_Filteredtext_get',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'FilteredText_get'},{av:'Ddo_br_information_patientno_Selectedvalue_get',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'Ddo_br_vitalid_Sortedstatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_vital_vitalid_Sortedstatus',ctrl:'DDO_BR_VITAL_VITALID',prop:'SortedStatus'},{av:'Ddo_br_vital_measuredate_Sortedstatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'Ddo_br_vital_temperature_Sortedstatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'},{av:'Ddo_br_vital_pulse_Sortedstatus',ctrl:'DDO_BR_VITAL_PULSE',prop:'SortedStatus'},{av:'Ddo_br_vital_respiration_Sortedstatus',ctrl:'DDO_BR_VITAL_RESPIRATION',prop:'SortedStatus'},{av:'Ddo_br_vital_systolic_Sortedstatus',ctrl:'DDO_BR_VITAL_SYSTOLIC',prop:'SortedStatus'},{av:'Ddo_br_vital_diastolic_Sortedstatus',ctrl:'DDO_BR_VITAL_DIASTOLIC',prop:'SortedStatus'},{av:'Ddo_br_vital_height_Sortedstatus',ctrl:'DDO_BR_VITAL_HEIGHT',prop:'SortedStatus'},{av:'Ddo_br_vital_weight_Sortedstatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'AV16BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV28BR_Vital_VitalIDTitleFilterData',fld:'vBR_VITAL_VITALIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV38BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'AV42BR_Vital_PulseTitleFilterData',fld:'vBR_VITAL_PULSETITLEFILTERDATA',pic:''},{av:'AV46BR_Vital_RespirationTitleFilterData',fld:'vBR_VITAL_RESPIRATIONTITLEFILTERDATA',pic:''},{av:'AV50BR_Vital_SystolicTitleFilterData',fld:'vBR_VITAL_SYSTOLICTITLEFILTERDATA',pic:''},{av:'AV54BR_Vital_DiastolicTitleFilterData',fld:'vBR_VITAL_DIASTOLICTITLEFILTERDATA',pic:''},{av:'AV58BR_Vital_HeightTitleFilterData',fld:'vBR_VITAL_HEIGHTTITLEFILTERDATA',pic:''},{av:'AV62BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Vital_VitalID_Titleformat',ctrl:'BR_VITAL_VITALID',prop:'Titleformat'},{av:'edtBR_Vital_VitalID_Title',ctrl:'BR_VITAL_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'edtBR_Vital_Pulse_Titleformat',ctrl:'BR_VITAL_PULSE',prop:'Titleformat'},{av:'edtBR_Vital_Pulse_Title',ctrl:'BR_VITAL_PULSE',prop:'Title'},{av:'edtBR_Vital_Respiration_Titleformat',ctrl:'BR_VITAL_RESPIRATION',prop:'Titleformat'},{av:'edtBR_Vital_Respiration_Title',ctrl:'BR_VITAL_RESPIRATION',prop:'Title'},{av:'edtBR_Vital_Systolic_Titleformat',ctrl:'BR_VITAL_SYSTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Systolic_Title',ctrl:'BR_VITAL_SYSTOLIC',prop:'Title'},{av:'edtBR_Vital_Diastolic_Titleformat',ctrl:'BR_VITAL_DIASTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Diastolic_Title',ctrl:'BR_VITAL_DIASTOLIC',prop:'Title'},{av:'edtBR_Vital_Height_Titleformat',ctrl:'BR_VITAL_HEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Height_Title',ctrl:'BR_VITAL_HEIGHT',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'AV68GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV69GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV70GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV73IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV75IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_VITAL_VITALID.ONOPTIONCLICKED","{handler:'E165Y2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_Vital_VitalID',fld:'vTFBR_VITAL_VITALID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_Vital_VitalID_To',fld:'vTFBR_VITAL_VITALID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV34TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'AV39TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV40TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV43TFBR_Vital_Pulse',fld:'vTFBR_VITAL_PULSE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV44TFBR_Vital_Pulse_To',fld:'vTFBR_VITAL_PULSE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV47TFBR_Vital_Respiration',fld:'vTFBR_VITAL_RESPIRATION',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV48TFBR_Vital_Respiration_To',fld:'vTFBR_VITAL_RESPIRATION_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Vital_Systolic',fld:'vTFBR_VITAL_SYSTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV52TFBR_Vital_Systolic_To',fld:'vTFBR_VITAL_SYSTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV55TFBR_Vital_Diastolic',fld:'vTFBR_VITAL_DIASTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Vital_Diastolic_To',fld:'vTFBR_VITAL_DIASTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV59TFBR_Vital_Height',fld:'vTFBR_VITAL_HEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Vital_Height_To',fld:'vTFBR_VITAL_HEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV63TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV64TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV19ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Vital_PulseTitleControlIdToReplace',fld:'vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Vital_RespirationTitleControlIdToReplace',fld:'vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Vital_SystolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Vital_HeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV107Pgmname',fld:'vPGMNAME',pic:''},{av:'AV73IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV75IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV76IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_vital_vitalid_Activeeventkey',ctrl:'DDO_BR_VITAL_VITALID',prop:'ActiveEventKey'},{av:'Ddo_br_vital_vitalid_Filteredtext_get',ctrl:'DDO_BR_VITAL_VITALID',prop:'FilteredText_get'},{av:'Ddo_br_vital_vitalid_Filteredtextto_get',ctrl:'DDO_BR_VITAL_VITALID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_VITAL_VITALID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_vital_vitalid_Sortedstatus',ctrl:'DDO_BR_VITAL_VITALID',prop:'SortedStatus'},{av:'AV29TFBR_Vital_VitalID',fld:'vTFBR_VITAL_VITALID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_Vital_VitalID_To',fld:'vTFBR_VITAL_VITALID_TO',pic:'ZZZZZZZZZZ'},{av:'Ddo_br_vitalid_Sortedstatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_vital_measuredate_Sortedstatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'Ddo_br_vital_temperature_Sortedstatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'},{av:'Ddo_br_vital_pulse_Sortedstatus',ctrl:'DDO_BR_VITAL_PULSE',prop:'SortedStatus'},{av:'Ddo_br_vital_respiration_Sortedstatus',ctrl:'DDO_BR_VITAL_RESPIRATION',prop:'SortedStatus'},{av:'Ddo_br_vital_systolic_Sortedstatus',ctrl:'DDO_BR_VITAL_SYSTOLIC',prop:'SortedStatus'},{av:'Ddo_br_vital_diastolic_Sortedstatus',ctrl:'DDO_BR_VITAL_DIASTOLIC',prop:'SortedStatus'},{av:'Ddo_br_vital_height_Sortedstatus',ctrl:'DDO_BR_VITAL_HEIGHT',prop:'SortedStatus'},{av:'Ddo_br_vital_weight_Sortedstatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'AV16BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV28BR_Vital_VitalIDTitleFilterData',fld:'vBR_VITAL_VITALIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV38BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'AV42BR_Vital_PulseTitleFilterData',fld:'vBR_VITAL_PULSETITLEFILTERDATA',pic:''},{av:'AV46BR_Vital_RespirationTitleFilterData',fld:'vBR_VITAL_RESPIRATIONTITLEFILTERDATA',pic:''},{av:'AV50BR_Vital_SystolicTitleFilterData',fld:'vBR_VITAL_SYSTOLICTITLEFILTERDATA',pic:''},{av:'AV54BR_Vital_DiastolicTitleFilterData',fld:'vBR_VITAL_DIASTOLICTITLEFILTERDATA',pic:''},{av:'AV58BR_Vital_HeightTitleFilterData',fld:'vBR_VITAL_HEIGHTTITLEFILTERDATA',pic:''},{av:'AV62BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Vital_VitalID_Titleformat',ctrl:'BR_VITAL_VITALID',prop:'Titleformat'},{av:'edtBR_Vital_VitalID_Title',ctrl:'BR_VITAL_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'edtBR_Vital_Pulse_Titleformat',ctrl:'BR_VITAL_PULSE',prop:'Titleformat'},{av:'edtBR_Vital_Pulse_Title',ctrl:'BR_VITAL_PULSE',prop:'Title'},{av:'edtBR_Vital_Respiration_Titleformat',ctrl:'BR_VITAL_RESPIRATION',prop:'Titleformat'},{av:'edtBR_Vital_Respiration_Title',ctrl:'BR_VITAL_RESPIRATION',prop:'Title'},{av:'edtBR_Vital_Systolic_Titleformat',ctrl:'BR_VITAL_SYSTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Systolic_Title',ctrl:'BR_VITAL_SYSTOLIC',prop:'Title'},{av:'edtBR_Vital_Diastolic_Titleformat',ctrl:'BR_VITAL_DIASTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Diastolic_Title',ctrl:'BR_VITAL_DIASTOLIC',prop:'Title'},{av:'edtBR_Vital_Height_Titleformat',ctrl:'BR_VITAL_HEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Height_Title',ctrl:'BR_VITAL_HEIGHT',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'AV68GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV69GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV70GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV73IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV75IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_VITAL_MEASUREDATE.ONOPTIONCLICKED","{handler:'E175Y2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_Vital_VitalID',fld:'vTFBR_VITAL_VITALID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_Vital_VitalID_To',fld:'vTFBR_VITAL_VITALID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV34TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'AV39TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV40TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV43TFBR_Vital_Pulse',fld:'vTFBR_VITAL_PULSE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV44TFBR_Vital_Pulse_To',fld:'vTFBR_VITAL_PULSE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV47TFBR_Vital_Respiration',fld:'vTFBR_VITAL_RESPIRATION',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV48TFBR_Vital_Respiration_To',fld:'vTFBR_VITAL_RESPIRATION_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Vital_Systolic',fld:'vTFBR_VITAL_SYSTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV52TFBR_Vital_Systolic_To',fld:'vTFBR_VITAL_SYSTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV55TFBR_Vital_Diastolic',fld:'vTFBR_VITAL_DIASTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Vital_Diastolic_To',fld:'vTFBR_VITAL_DIASTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV59TFBR_Vital_Height',fld:'vTFBR_VITAL_HEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Vital_Height_To',fld:'vTFBR_VITAL_HEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV63TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV64TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV19ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Vital_PulseTitleControlIdToReplace',fld:'vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Vital_RespirationTitleControlIdToReplace',fld:'vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Vital_SystolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Vital_HeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV107Pgmname',fld:'vPGMNAME',pic:''},{av:'AV73IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV75IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV76IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_vital_measuredate_Activeeventkey',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'ActiveEventKey'},{av:'Ddo_br_vital_measuredate_Filteredtext_get',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'FilteredText_get'},{av:'Ddo_br_vital_measuredate_Filteredtextto_get',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_VITAL_MEASUREDATE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_vital_measuredate_Sortedstatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'AV33TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV34TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'Ddo_br_vitalid_Sortedstatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_vital_vitalid_Sortedstatus',ctrl:'DDO_BR_VITAL_VITALID',prop:'SortedStatus'},{av:'Ddo_br_vital_temperature_Sortedstatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'},{av:'Ddo_br_vital_pulse_Sortedstatus',ctrl:'DDO_BR_VITAL_PULSE',prop:'SortedStatus'},{av:'Ddo_br_vital_respiration_Sortedstatus',ctrl:'DDO_BR_VITAL_RESPIRATION',prop:'SortedStatus'},{av:'Ddo_br_vital_systolic_Sortedstatus',ctrl:'DDO_BR_VITAL_SYSTOLIC',prop:'SortedStatus'},{av:'Ddo_br_vital_diastolic_Sortedstatus',ctrl:'DDO_BR_VITAL_DIASTOLIC',prop:'SortedStatus'},{av:'Ddo_br_vital_height_Sortedstatus',ctrl:'DDO_BR_VITAL_HEIGHT',prop:'SortedStatus'},{av:'Ddo_br_vital_weight_Sortedstatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'AV16BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV28BR_Vital_VitalIDTitleFilterData',fld:'vBR_VITAL_VITALIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV38BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'AV42BR_Vital_PulseTitleFilterData',fld:'vBR_VITAL_PULSETITLEFILTERDATA',pic:''},{av:'AV46BR_Vital_RespirationTitleFilterData',fld:'vBR_VITAL_RESPIRATIONTITLEFILTERDATA',pic:''},{av:'AV50BR_Vital_SystolicTitleFilterData',fld:'vBR_VITAL_SYSTOLICTITLEFILTERDATA',pic:''},{av:'AV54BR_Vital_DiastolicTitleFilterData',fld:'vBR_VITAL_DIASTOLICTITLEFILTERDATA',pic:''},{av:'AV58BR_Vital_HeightTitleFilterData',fld:'vBR_VITAL_HEIGHTTITLEFILTERDATA',pic:''},{av:'AV62BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Vital_VitalID_Titleformat',ctrl:'BR_VITAL_VITALID',prop:'Titleformat'},{av:'edtBR_Vital_VitalID_Title',ctrl:'BR_VITAL_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'edtBR_Vital_Pulse_Titleformat',ctrl:'BR_VITAL_PULSE',prop:'Titleformat'},{av:'edtBR_Vital_Pulse_Title',ctrl:'BR_VITAL_PULSE',prop:'Title'},{av:'edtBR_Vital_Respiration_Titleformat',ctrl:'BR_VITAL_RESPIRATION',prop:'Titleformat'},{av:'edtBR_Vital_Respiration_Title',ctrl:'BR_VITAL_RESPIRATION',prop:'Title'},{av:'edtBR_Vital_Systolic_Titleformat',ctrl:'BR_VITAL_SYSTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Systolic_Title',ctrl:'BR_VITAL_SYSTOLIC',prop:'Title'},{av:'edtBR_Vital_Diastolic_Titleformat',ctrl:'BR_VITAL_DIASTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Diastolic_Title',ctrl:'BR_VITAL_DIASTOLIC',prop:'Title'},{av:'edtBR_Vital_Height_Titleformat',ctrl:'BR_VITAL_HEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Height_Title',ctrl:'BR_VITAL_HEIGHT',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'AV68GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV69GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV70GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV73IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV75IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_VITAL_TEMPERATURE.ONOPTIONCLICKED","{handler:'E185Y2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_Vital_VitalID',fld:'vTFBR_VITAL_VITALID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_Vital_VitalID_To',fld:'vTFBR_VITAL_VITALID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV34TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'AV39TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV40TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV43TFBR_Vital_Pulse',fld:'vTFBR_VITAL_PULSE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV44TFBR_Vital_Pulse_To',fld:'vTFBR_VITAL_PULSE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV47TFBR_Vital_Respiration',fld:'vTFBR_VITAL_RESPIRATION',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV48TFBR_Vital_Respiration_To',fld:'vTFBR_VITAL_RESPIRATION_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Vital_Systolic',fld:'vTFBR_VITAL_SYSTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV52TFBR_Vital_Systolic_To',fld:'vTFBR_VITAL_SYSTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV55TFBR_Vital_Diastolic',fld:'vTFBR_VITAL_DIASTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Vital_Diastolic_To',fld:'vTFBR_VITAL_DIASTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV59TFBR_Vital_Height',fld:'vTFBR_VITAL_HEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Vital_Height_To',fld:'vTFBR_VITAL_HEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV63TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV64TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV19ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Vital_PulseTitleControlIdToReplace',fld:'vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Vital_RespirationTitleControlIdToReplace',fld:'vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Vital_SystolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Vital_HeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV107Pgmname',fld:'vPGMNAME',pic:''},{av:'AV73IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV75IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV76IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_vital_temperature_Activeeventkey',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'ActiveEventKey'},{av:'Ddo_br_vital_temperature_Filteredtext_get',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'FilteredText_get'},{av:'Ddo_br_vital_temperature_Filteredtextto_get',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_VITAL_TEMPERATURE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_vital_temperature_Sortedstatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'},{av:'AV39TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV40TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'Ddo_br_vitalid_Sortedstatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_vital_vitalid_Sortedstatus',ctrl:'DDO_BR_VITAL_VITALID',prop:'SortedStatus'},{av:'Ddo_br_vital_measuredate_Sortedstatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'Ddo_br_vital_pulse_Sortedstatus',ctrl:'DDO_BR_VITAL_PULSE',prop:'SortedStatus'},{av:'Ddo_br_vital_respiration_Sortedstatus',ctrl:'DDO_BR_VITAL_RESPIRATION',prop:'SortedStatus'},{av:'Ddo_br_vital_systolic_Sortedstatus',ctrl:'DDO_BR_VITAL_SYSTOLIC',prop:'SortedStatus'},{av:'Ddo_br_vital_diastolic_Sortedstatus',ctrl:'DDO_BR_VITAL_DIASTOLIC',prop:'SortedStatus'},{av:'Ddo_br_vital_height_Sortedstatus',ctrl:'DDO_BR_VITAL_HEIGHT',prop:'SortedStatus'},{av:'Ddo_br_vital_weight_Sortedstatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'AV16BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV28BR_Vital_VitalIDTitleFilterData',fld:'vBR_VITAL_VITALIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV38BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'AV42BR_Vital_PulseTitleFilterData',fld:'vBR_VITAL_PULSETITLEFILTERDATA',pic:''},{av:'AV46BR_Vital_RespirationTitleFilterData',fld:'vBR_VITAL_RESPIRATIONTITLEFILTERDATA',pic:''},{av:'AV50BR_Vital_SystolicTitleFilterData',fld:'vBR_VITAL_SYSTOLICTITLEFILTERDATA',pic:''},{av:'AV54BR_Vital_DiastolicTitleFilterData',fld:'vBR_VITAL_DIASTOLICTITLEFILTERDATA',pic:''},{av:'AV58BR_Vital_HeightTitleFilterData',fld:'vBR_VITAL_HEIGHTTITLEFILTERDATA',pic:''},{av:'AV62BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Vital_VitalID_Titleformat',ctrl:'BR_VITAL_VITALID',prop:'Titleformat'},{av:'edtBR_Vital_VitalID_Title',ctrl:'BR_VITAL_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'edtBR_Vital_Pulse_Titleformat',ctrl:'BR_VITAL_PULSE',prop:'Titleformat'},{av:'edtBR_Vital_Pulse_Title',ctrl:'BR_VITAL_PULSE',prop:'Title'},{av:'edtBR_Vital_Respiration_Titleformat',ctrl:'BR_VITAL_RESPIRATION',prop:'Titleformat'},{av:'edtBR_Vital_Respiration_Title',ctrl:'BR_VITAL_RESPIRATION',prop:'Title'},{av:'edtBR_Vital_Systolic_Titleformat',ctrl:'BR_VITAL_SYSTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Systolic_Title',ctrl:'BR_VITAL_SYSTOLIC',prop:'Title'},{av:'edtBR_Vital_Diastolic_Titleformat',ctrl:'BR_VITAL_DIASTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Diastolic_Title',ctrl:'BR_VITAL_DIASTOLIC',prop:'Title'},{av:'edtBR_Vital_Height_Titleformat',ctrl:'BR_VITAL_HEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Height_Title',ctrl:'BR_VITAL_HEIGHT',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'AV68GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV69GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV70GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV73IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV75IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_VITAL_PULSE.ONOPTIONCLICKED","{handler:'E195Y2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_Vital_VitalID',fld:'vTFBR_VITAL_VITALID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_Vital_VitalID_To',fld:'vTFBR_VITAL_VITALID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV34TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'AV39TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV40TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV43TFBR_Vital_Pulse',fld:'vTFBR_VITAL_PULSE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV44TFBR_Vital_Pulse_To',fld:'vTFBR_VITAL_PULSE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV47TFBR_Vital_Respiration',fld:'vTFBR_VITAL_RESPIRATION',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV48TFBR_Vital_Respiration_To',fld:'vTFBR_VITAL_RESPIRATION_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Vital_Systolic',fld:'vTFBR_VITAL_SYSTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV52TFBR_Vital_Systolic_To',fld:'vTFBR_VITAL_SYSTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV55TFBR_Vital_Diastolic',fld:'vTFBR_VITAL_DIASTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Vital_Diastolic_To',fld:'vTFBR_VITAL_DIASTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV59TFBR_Vital_Height',fld:'vTFBR_VITAL_HEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Vital_Height_To',fld:'vTFBR_VITAL_HEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV63TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV64TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV19ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Vital_PulseTitleControlIdToReplace',fld:'vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Vital_RespirationTitleControlIdToReplace',fld:'vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Vital_SystolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Vital_HeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV107Pgmname',fld:'vPGMNAME',pic:''},{av:'AV73IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV75IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV76IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_vital_pulse_Activeeventkey',ctrl:'DDO_BR_VITAL_PULSE',prop:'ActiveEventKey'},{av:'Ddo_br_vital_pulse_Filteredtext_get',ctrl:'DDO_BR_VITAL_PULSE',prop:'FilteredText_get'},{av:'Ddo_br_vital_pulse_Filteredtextto_get',ctrl:'DDO_BR_VITAL_PULSE',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_VITAL_PULSE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_vital_pulse_Sortedstatus',ctrl:'DDO_BR_VITAL_PULSE',prop:'SortedStatus'},{av:'AV43TFBR_Vital_Pulse',fld:'vTFBR_VITAL_PULSE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV44TFBR_Vital_Pulse_To',fld:'vTFBR_VITAL_PULSE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'Ddo_br_vitalid_Sortedstatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_vital_vitalid_Sortedstatus',ctrl:'DDO_BR_VITAL_VITALID',prop:'SortedStatus'},{av:'Ddo_br_vital_measuredate_Sortedstatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'Ddo_br_vital_temperature_Sortedstatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'},{av:'Ddo_br_vital_respiration_Sortedstatus',ctrl:'DDO_BR_VITAL_RESPIRATION',prop:'SortedStatus'},{av:'Ddo_br_vital_systolic_Sortedstatus',ctrl:'DDO_BR_VITAL_SYSTOLIC',prop:'SortedStatus'},{av:'Ddo_br_vital_diastolic_Sortedstatus',ctrl:'DDO_BR_VITAL_DIASTOLIC',prop:'SortedStatus'},{av:'Ddo_br_vital_height_Sortedstatus',ctrl:'DDO_BR_VITAL_HEIGHT',prop:'SortedStatus'},{av:'Ddo_br_vital_weight_Sortedstatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'AV16BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV28BR_Vital_VitalIDTitleFilterData',fld:'vBR_VITAL_VITALIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV38BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'AV42BR_Vital_PulseTitleFilterData',fld:'vBR_VITAL_PULSETITLEFILTERDATA',pic:''},{av:'AV46BR_Vital_RespirationTitleFilterData',fld:'vBR_VITAL_RESPIRATIONTITLEFILTERDATA',pic:''},{av:'AV50BR_Vital_SystolicTitleFilterData',fld:'vBR_VITAL_SYSTOLICTITLEFILTERDATA',pic:''},{av:'AV54BR_Vital_DiastolicTitleFilterData',fld:'vBR_VITAL_DIASTOLICTITLEFILTERDATA',pic:''},{av:'AV58BR_Vital_HeightTitleFilterData',fld:'vBR_VITAL_HEIGHTTITLEFILTERDATA',pic:''},{av:'AV62BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Vital_VitalID_Titleformat',ctrl:'BR_VITAL_VITALID',prop:'Titleformat'},{av:'edtBR_Vital_VitalID_Title',ctrl:'BR_VITAL_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'edtBR_Vital_Pulse_Titleformat',ctrl:'BR_VITAL_PULSE',prop:'Titleformat'},{av:'edtBR_Vital_Pulse_Title',ctrl:'BR_VITAL_PULSE',prop:'Title'},{av:'edtBR_Vital_Respiration_Titleformat',ctrl:'BR_VITAL_RESPIRATION',prop:'Titleformat'},{av:'edtBR_Vital_Respiration_Title',ctrl:'BR_VITAL_RESPIRATION',prop:'Title'},{av:'edtBR_Vital_Systolic_Titleformat',ctrl:'BR_VITAL_SYSTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Systolic_Title',ctrl:'BR_VITAL_SYSTOLIC',prop:'Title'},{av:'edtBR_Vital_Diastolic_Titleformat',ctrl:'BR_VITAL_DIASTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Diastolic_Title',ctrl:'BR_VITAL_DIASTOLIC',prop:'Title'},{av:'edtBR_Vital_Height_Titleformat',ctrl:'BR_VITAL_HEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Height_Title',ctrl:'BR_VITAL_HEIGHT',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'AV68GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV69GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV70GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV73IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV75IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_VITAL_RESPIRATION.ONOPTIONCLICKED","{handler:'E205Y2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_Vital_VitalID',fld:'vTFBR_VITAL_VITALID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_Vital_VitalID_To',fld:'vTFBR_VITAL_VITALID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV34TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'AV39TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV40TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV43TFBR_Vital_Pulse',fld:'vTFBR_VITAL_PULSE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV44TFBR_Vital_Pulse_To',fld:'vTFBR_VITAL_PULSE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV47TFBR_Vital_Respiration',fld:'vTFBR_VITAL_RESPIRATION',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV48TFBR_Vital_Respiration_To',fld:'vTFBR_VITAL_RESPIRATION_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Vital_Systolic',fld:'vTFBR_VITAL_SYSTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV52TFBR_Vital_Systolic_To',fld:'vTFBR_VITAL_SYSTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV55TFBR_Vital_Diastolic',fld:'vTFBR_VITAL_DIASTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Vital_Diastolic_To',fld:'vTFBR_VITAL_DIASTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV59TFBR_Vital_Height',fld:'vTFBR_VITAL_HEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Vital_Height_To',fld:'vTFBR_VITAL_HEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV63TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV64TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV19ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Vital_PulseTitleControlIdToReplace',fld:'vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Vital_RespirationTitleControlIdToReplace',fld:'vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Vital_SystolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Vital_HeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV107Pgmname',fld:'vPGMNAME',pic:''},{av:'AV73IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV75IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV76IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_vital_respiration_Activeeventkey',ctrl:'DDO_BR_VITAL_RESPIRATION',prop:'ActiveEventKey'},{av:'Ddo_br_vital_respiration_Filteredtext_get',ctrl:'DDO_BR_VITAL_RESPIRATION',prop:'FilteredText_get'},{av:'Ddo_br_vital_respiration_Filteredtextto_get',ctrl:'DDO_BR_VITAL_RESPIRATION',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_VITAL_RESPIRATION.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_vital_respiration_Sortedstatus',ctrl:'DDO_BR_VITAL_RESPIRATION',prop:'SortedStatus'},{av:'AV47TFBR_Vital_Respiration',fld:'vTFBR_VITAL_RESPIRATION',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV48TFBR_Vital_Respiration_To',fld:'vTFBR_VITAL_RESPIRATION_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'Ddo_br_vitalid_Sortedstatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_vital_vitalid_Sortedstatus',ctrl:'DDO_BR_VITAL_VITALID',prop:'SortedStatus'},{av:'Ddo_br_vital_measuredate_Sortedstatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'Ddo_br_vital_temperature_Sortedstatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'},{av:'Ddo_br_vital_pulse_Sortedstatus',ctrl:'DDO_BR_VITAL_PULSE',prop:'SortedStatus'},{av:'Ddo_br_vital_systolic_Sortedstatus',ctrl:'DDO_BR_VITAL_SYSTOLIC',prop:'SortedStatus'},{av:'Ddo_br_vital_diastolic_Sortedstatus',ctrl:'DDO_BR_VITAL_DIASTOLIC',prop:'SortedStatus'},{av:'Ddo_br_vital_height_Sortedstatus',ctrl:'DDO_BR_VITAL_HEIGHT',prop:'SortedStatus'},{av:'Ddo_br_vital_weight_Sortedstatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'AV16BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV28BR_Vital_VitalIDTitleFilterData',fld:'vBR_VITAL_VITALIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV38BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'AV42BR_Vital_PulseTitleFilterData',fld:'vBR_VITAL_PULSETITLEFILTERDATA',pic:''},{av:'AV46BR_Vital_RespirationTitleFilterData',fld:'vBR_VITAL_RESPIRATIONTITLEFILTERDATA',pic:''},{av:'AV50BR_Vital_SystolicTitleFilterData',fld:'vBR_VITAL_SYSTOLICTITLEFILTERDATA',pic:''},{av:'AV54BR_Vital_DiastolicTitleFilterData',fld:'vBR_VITAL_DIASTOLICTITLEFILTERDATA',pic:''},{av:'AV58BR_Vital_HeightTitleFilterData',fld:'vBR_VITAL_HEIGHTTITLEFILTERDATA',pic:''},{av:'AV62BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Vital_VitalID_Titleformat',ctrl:'BR_VITAL_VITALID',prop:'Titleformat'},{av:'edtBR_Vital_VitalID_Title',ctrl:'BR_VITAL_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'edtBR_Vital_Pulse_Titleformat',ctrl:'BR_VITAL_PULSE',prop:'Titleformat'},{av:'edtBR_Vital_Pulse_Title',ctrl:'BR_VITAL_PULSE',prop:'Title'},{av:'edtBR_Vital_Respiration_Titleformat',ctrl:'BR_VITAL_RESPIRATION',prop:'Titleformat'},{av:'edtBR_Vital_Respiration_Title',ctrl:'BR_VITAL_RESPIRATION',prop:'Title'},{av:'edtBR_Vital_Systolic_Titleformat',ctrl:'BR_VITAL_SYSTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Systolic_Title',ctrl:'BR_VITAL_SYSTOLIC',prop:'Title'},{av:'edtBR_Vital_Diastolic_Titleformat',ctrl:'BR_VITAL_DIASTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Diastolic_Title',ctrl:'BR_VITAL_DIASTOLIC',prop:'Title'},{av:'edtBR_Vital_Height_Titleformat',ctrl:'BR_VITAL_HEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Height_Title',ctrl:'BR_VITAL_HEIGHT',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'AV68GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV69GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV70GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV73IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV75IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_VITAL_SYSTOLIC.ONOPTIONCLICKED","{handler:'E215Y2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_Vital_VitalID',fld:'vTFBR_VITAL_VITALID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_Vital_VitalID_To',fld:'vTFBR_VITAL_VITALID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV34TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'AV39TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV40TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV43TFBR_Vital_Pulse',fld:'vTFBR_VITAL_PULSE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV44TFBR_Vital_Pulse_To',fld:'vTFBR_VITAL_PULSE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV47TFBR_Vital_Respiration',fld:'vTFBR_VITAL_RESPIRATION',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV48TFBR_Vital_Respiration_To',fld:'vTFBR_VITAL_RESPIRATION_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Vital_Systolic',fld:'vTFBR_VITAL_SYSTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV52TFBR_Vital_Systolic_To',fld:'vTFBR_VITAL_SYSTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV55TFBR_Vital_Diastolic',fld:'vTFBR_VITAL_DIASTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Vital_Diastolic_To',fld:'vTFBR_VITAL_DIASTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV59TFBR_Vital_Height',fld:'vTFBR_VITAL_HEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Vital_Height_To',fld:'vTFBR_VITAL_HEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV63TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV64TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV19ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Vital_PulseTitleControlIdToReplace',fld:'vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Vital_RespirationTitleControlIdToReplace',fld:'vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Vital_SystolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Vital_HeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV107Pgmname',fld:'vPGMNAME',pic:''},{av:'AV73IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV75IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV76IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_vital_systolic_Activeeventkey',ctrl:'DDO_BR_VITAL_SYSTOLIC',prop:'ActiveEventKey'},{av:'Ddo_br_vital_systolic_Filteredtext_get',ctrl:'DDO_BR_VITAL_SYSTOLIC',prop:'FilteredText_get'},{av:'Ddo_br_vital_systolic_Filteredtextto_get',ctrl:'DDO_BR_VITAL_SYSTOLIC',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_VITAL_SYSTOLIC.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_vital_systolic_Sortedstatus',ctrl:'DDO_BR_VITAL_SYSTOLIC',prop:'SortedStatus'},{av:'AV51TFBR_Vital_Systolic',fld:'vTFBR_VITAL_SYSTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV52TFBR_Vital_Systolic_To',fld:'vTFBR_VITAL_SYSTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'Ddo_br_vitalid_Sortedstatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_vital_vitalid_Sortedstatus',ctrl:'DDO_BR_VITAL_VITALID',prop:'SortedStatus'},{av:'Ddo_br_vital_measuredate_Sortedstatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'Ddo_br_vital_temperature_Sortedstatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'},{av:'Ddo_br_vital_pulse_Sortedstatus',ctrl:'DDO_BR_VITAL_PULSE',prop:'SortedStatus'},{av:'Ddo_br_vital_respiration_Sortedstatus',ctrl:'DDO_BR_VITAL_RESPIRATION',prop:'SortedStatus'},{av:'Ddo_br_vital_diastolic_Sortedstatus',ctrl:'DDO_BR_VITAL_DIASTOLIC',prop:'SortedStatus'},{av:'Ddo_br_vital_height_Sortedstatus',ctrl:'DDO_BR_VITAL_HEIGHT',prop:'SortedStatus'},{av:'Ddo_br_vital_weight_Sortedstatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'AV16BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV28BR_Vital_VitalIDTitleFilterData',fld:'vBR_VITAL_VITALIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV38BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'AV42BR_Vital_PulseTitleFilterData',fld:'vBR_VITAL_PULSETITLEFILTERDATA',pic:''},{av:'AV46BR_Vital_RespirationTitleFilterData',fld:'vBR_VITAL_RESPIRATIONTITLEFILTERDATA',pic:''},{av:'AV50BR_Vital_SystolicTitleFilterData',fld:'vBR_VITAL_SYSTOLICTITLEFILTERDATA',pic:''},{av:'AV54BR_Vital_DiastolicTitleFilterData',fld:'vBR_VITAL_DIASTOLICTITLEFILTERDATA',pic:''},{av:'AV58BR_Vital_HeightTitleFilterData',fld:'vBR_VITAL_HEIGHTTITLEFILTERDATA',pic:''},{av:'AV62BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Vital_VitalID_Titleformat',ctrl:'BR_VITAL_VITALID',prop:'Titleformat'},{av:'edtBR_Vital_VitalID_Title',ctrl:'BR_VITAL_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'edtBR_Vital_Pulse_Titleformat',ctrl:'BR_VITAL_PULSE',prop:'Titleformat'},{av:'edtBR_Vital_Pulse_Title',ctrl:'BR_VITAL_PULSE',prop:'Title'},{av:'edtBR_Vital_Respiration_Titleformat',ctrl:'BR_VITAL_RESPIRATION',prop:'Titleformat'},{av:'edtBR_Vital_Respiration_Title',ctrl:'BR_VITAL_RESPIRATION',prop:'Title'},{av:'edtBR_Vital_Systolic_Titleformat',ctrl:'BR_VITAL_SYSTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Systolic_Title',ctrl:'BR_VITAL_SYSTOLIC',prop:'Title'},{av:'edtBR_Vital_Diastolic_Titleformat',ctrl:'BR_VITAL_DIASTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Diastolic_Title',ctrl:'BR_VITAL_DIASTOLIC',prop:'Title'},{av:'edtBR_Vital_Height_Titleformat',ctrl:'BR_VITAL_HEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Height_Title',ctrl:'BR_VITAL_HEIGHT',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'AV68GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV69GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV70GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV73IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV75IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_VITAL_DIASTOLIC.ONOPTIONCLICKED","{handler:'E225Y2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_Vital_VitalID',fld:'vTFBR_VITAL_VITALID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_Vital_VitalID_To',fld:'vTFBR_VITAL_VITALID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV34TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'AV39TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV40TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV43TFBR_Vital_Pulse',fld:'vTFBR_VITAL_PULSE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV44TFBR_Vital_Pulse_To',fld:'vTFBR_VITAL_PULSE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV47TFBR_Vital_Respiration',fld:'vTFBR_VITAL_RESPIRATION',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV48TFBR_Vital_Respiration_To',fld:'vTFBR_VITAL_RESPIRATION_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Vital_Systolic',fld:'vTFBR_VITAL_SYSTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV52TFBR_Vital_Systolic_To',fld:'vTFBR_VITAL_SYSTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV55TFBR_Vital_Diastolic',fld:'vTFBR_VITAL_DIASTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Vital_Diastolic_To',fld:'vTFBR_VITAL_DIASTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV59TFBR_Vital_Height',fld:'vTFBR_VITAL_HEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Vital_Height_To',fld:'vTFBR_VITAL_HEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV63TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV64TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV19ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Vital_PulseTitleControlIdToReplace',fld:'vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Vital_RespirationTitleControlIdToReplace',fld:'vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Vital_SystolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Vital_HeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV107Pgmname',fld:'vPGMNAME',pic:''},{av:'AV73IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV75IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV76IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_vital_diastolic_Activeeventkey',ctrl:'DDO_BR_VITAL_DIASTOLIC',prop:'ActiveEventKey'},{av:'Ddo_br_vital_diastolic_Filteredtext_get',ctrl:'DDO_BR_VITAL_DIASTOLIC',prop:'FilteredText_get'},{av:'Ddo_br_vital_diastolic_Filteredtextto_get',ctrl:'DDO_BR_VITAL_DIASTOLIC',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_VITAL_DIASTOLIC.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_vital_diastolic_Sortedstatus',ctrl:'DDO_BR_VITAL_DIASTOLIC',prop:'SortedStatus'},{av:'AV55TFBR_Vital_Diastolic',fld:'vTFBR_VITAL_DIASTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Vital_Diastolic_To',fld:'vTFBR_VITAL_DIASTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'Ddo_br_vitalid_Sortedstatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_vital_vitalid_Sortedstatus',ctrl:'DDO_BR_VITAL_VITALID',prop:'SortedStatus'},{av:'Ddo_br_vital_measuredate_Sortedstatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'Ddo_br_vital_temperature_Sortedstatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'},{av:'Ddo_br_vital_pulse_Sortedstatus',ctrl:'DDO_BR_VITAL_PULSE',prop:'SortedStatus'},{av:'Ddo_br_vital_respiration_Sortedstatus',ctrl:'DDO_BR_VITAL_RESPIRATION',prop:'SortedStatus'},{av:'Ddo_br_vital_systolic_Sortedstatus',ctrl:'DDO_BR_VITAL_SYSTOLIC',prop:'SortedStatus'},{av:'Ddo_br_vital_height_Sortedstatus',ctrl:'DDO_BR_VITAL_HEIGHT',prop:'SortedStatus'},{av:'Ddo_br_vital_weight_Sortedstatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'AV16BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV28BR_Vital_VitalIDTitleFilterData',fld:'vBR_VITAL_VITALIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV38BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'AV42BR_Vital_PulseTitleFilterData',fld:'vBR_VITAL_PULSETITLEFILTERDATA',pic:''},{av:'AV46BR_Vital_RespirationTitleFilterData',fld:'vBR_VITAL_RESPIRATIONTITLEFILTERDATA',pic:''},{av:'AV50BR_Vital_SystolicTitleFilterData',fld:'vBR_VITAL_SYSTOLICTITLEFILTERDATA',pic:''},{av:'AV54BR_Vital_DiastolicTitleFilterData',fld:'vBR_VITAL_DIASTOLICTITLEFILTERDATA',pic:''},{av:'AV58BR_Vital_HeightTitleFilterData',fld:'vBR_VITAL_HEIGHTTITLEFILTERDATA',pic:''},{av:'AV62BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Vital_VitalID_Titleformat',ctrl:'BR_VITAL_VITALID',prop:'Titleformat'},{av:'edtBR_Vital_VitalID_Title',ctrl:'BR_VITAL_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'edtBR_Vital_Pulse_Titleformat',ctrl:'BR_VITAL_PULSE',prop:'Titleformat'},{av:'edtBR_Vital_Pulse_Title',ctrl:'BR_VITAL_PULSE',prop:'Title'},{av:'edtBR_Vital_Respiration_Titleformat',ctrl:'BR_VITAL_RESPIRATION',prop:'Titleformat'},{av:'edtBR_Vital_Respiration_Title',ctrl:'BR_VITAL_RESPIRATION',prop:'Title'},{av:'edtBR_Vital_Systolic_Titleformat',ctrl:'BR_VITAL_SYSTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Systolic_Title',ctrl:'BR_VITAL_SYSTOLIC',prop:'Title'},{av:'edtBR_Vital_Diastolic_Titleformat',ctrl:'BR_VITAL_DIASTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Diastolic_Title',ctrl:'BR_VITAL_DIASTOLIC',prop:'Title'},{av:'edtBR_Vital_Height_Titleformat',ctrl:'BR_VITAL_HEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Height_Title',ctrl:'BR_VITAL_HEIGHT',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'AV68GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV69GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV70GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV73IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV75IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_VITAL_HEIGHT.ONOPTIONCLICKED","{handler:'E235Y2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_Vital_VitalID',fld:'vTFBR_VITAL_VITALID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_Vital_VitalID_To',fld:'vTFBR_VITAL_VITALID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV34TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'AV39TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV40TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV43TFBR_Vital_Pulse',fld:'vTFBR_VITAL_PULSE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV44TFBR_Vital_Pulse_To',fld:'vTFBR_VITAL_PULSE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV47TFBR_Vital_Respiration',fld:'vTFBR_VITAL_RESPIRATION',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV48TFBR_Vital_Respiration_To',fld:'vTFBR_VITAL_RESPIRATION_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Vital_Systolic',fld:'vTFBR_VITAL_SYSTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV52TFBR_Vital_Systolic_To',fld:'vTFBR_VITAL_SYSTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV55TFBR_Vital_Diastolic',fld:'vTFBR_VITAL_DIASTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Vital_Diastolic_To',fld:'vTFBR_VITAL_DIASTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV59TFBR_Vital_Height',fld:'vTFBR_VITAL_HEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Vital_Height_To',fld:'vTFBR_VITAL_HEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV63TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV64TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV19ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Vital_PulseTitleControlIdToReplace',fld:'vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Vital_RespirationTitleControlIdToReplace',fld:'vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Vital_SystolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Vital_HeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV107Pgmname',fld:'vPGMNAME',pic:''},{av:'AV73IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV75IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV76IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_vital_height_Activeeventkey',ctrl:'DDO_BR_VITAL_HEIGHT',prop:'ActiveEventKey'},{av:'Ddo_br_vital_height_Filteredtext_get',ctrl:'DDO_BR_VITAL_HEIGHT',prop:'FilteredText_get'},{av:'Ddo_br_vital_height_Filteredtextto_get',ctrl:'DDO_BR_VITAL_HEIGHT',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_VITAL_HEIGHT.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_vital_height_Sortedstatus',ctrl:'DDO_BR_VITAL_HEIGHT',prop:'SortedStatus'},{av:'AV59TFBR_Vital_Height',fld:'vTFBR_VITAL_HEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Vital_Height_To',fld:'vTFBR_VITAL_HEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'Ddo_br_vitalid_Sortedstatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_vital_vitalid_Sortedstatus',ctrl:'DDO_BR_VITAL_VITALID',prop:'SortedStatus'},{av:'Ddo_br_vital_measuredate_Sortedstatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'Ddo_br_vital_temperature_Sortedstatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'},{av:'Ddo_br_vital_pulse_Sortedstatus',ctrl:'DDO_BR_VITAL_PULSE',prop:'SortedStatus'},{av:'Ddo_br_vital_respiration_Sortedstatus',ctrl:'DDO_BR_VITAL_RESPIRATION',prop:'SortedStatus'},{av:'Ddo_br_vital_systolic_Sortedstatus',ctrl:'DDO_BR_VITAL_SYSTOLIC',prop:'SortedStatus'},{av:'Ddo_br_vital_diastolic_Sortedstatus',ctrl:'DDO_BR_VITAL_DIASTOLIC',prop:'SortedStatus'},{av:'Ddo_br_vital_weight_Sortedstatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'AV16BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV28BR_Vital_VitalIDTitleFilterData',fld:'vBR_VITAL_VITALIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV38BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'AV42BR_Vital_PulseTitleFilterData',fld:'vBR_VITAL_PULSETITLEFILTERDATA',pic:''},{av:'AV46BR_Vital_RespirationTitleFilterData',fld:'vBR_VITAL_RESPIRATIONTITLEFILTERDATA',pic:''},{av:'AV50BR_Vital_SystolicTitleFilterData',fld:'vBR_VITAL_SYSTOLICTITLEFILTERDATA',pic:''},{av:'AV54BR_Vital_DiastolicTitleFilterData',fld:'vBR_VITAL_DIASTOLICTITLEFILTERDATA',pic:''},{av:'AV58BR_Vital_HeightTitleFilterData',fld:'vBR_VITAL_HEIGHTTITLEFILTERDATA',pic:''},{av:'AV62BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Vital_VitalID_Titleformat',ctrl:'BR_VITAL_VITALID',prop:'Titleformat'},{av:'edtBR_Vital_VitalID_Title',ctrl:'BR_VITAL_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'edtBR_Vital_Pulse_Titleformat',ctrl:'BR_VITAL_PULSE',prop:'Titleformat'},{av:'edtBR_Vital_Pulse_Title',ctrl:'BR_VITAL_PULSE',prop:'Title'},{av:'edtBR_Vital_Respiration_Titleformat',ctrl:'BR_VITAL_RESPIRATION',prop:'Titleformat'},{av:'edtBR_Vital_Respiration_Title',ctrl:'BR_VITAL_RESPIRATION',prop:'Title'},{av:'edtBR_Vital_Systolic_Titleformat',ctrl:'BR_VITAL_SYSTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Systolic_Title',ctrl:'BR_VITAL_SYSTOLIC',prop:'Title'},{av:'edtBR_Vital_Diastolic_Titleformat',ctrl:'BR_VITAL_DIASTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Diastolic_Title',ctrl:'BR_VITAL_DIASTOLIC',prop:'Title'},{av:'edtBR_Vital_Height_Titleformat',ctrl:'BR_VITAL_HEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Height_Title',ctrl:'BR_VITAL_HEIGHT',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'AV68GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV69GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV70GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV73IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV75IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_VITAL_WEIGHT.ONOPTIONCLICKED","{handler:'E245Y2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_Vital_VitalID',fld:'vTFBR_VITAL_VITALID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_Vital_VitalID_To',fld:'vTFBR_VITAL_VITALID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV34TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'AV39TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV40TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV43TFBR_Vital_Pulse',fld:'vTFBR_VITAL_PULSE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV44TFBR_Vital_Pulse_To',fld:'vTFBR_VITAL_PULSE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV47TFBR_Vital_Respiration',fld:'vTFBR_VITAL_RESPIRATION',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV48TFBR_Vital_Respiration_To',fld:'vTFBR_VITAL_RESPIRATION_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Vital_Systolic',fld:'vTFBR_VITAL_SYSTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV52TFBR_Vital_Systolic_To',fld:'vTFBR_VITAL_SYSTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV55TFBR_Vital_Diastolic',fld:'vTFBR_VITAL_DIASTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV56TFBR_Vital_Diastolic_To',fld:'vTFBR_VITAL_DIASTOLIC_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV59TFBR_Vital_Height',fld:'vTFBR_VITAL_HEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Vital_Height_To',fld:'vTFBR_VITAL_HEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV63TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV64TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV19ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Vital_PulseTitleControlIdToReplace',fld:'vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Vital_RespirationTitleControlIdToReplace',fld:'vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Vital_SystolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Vital_HeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV65ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV107Pgmname',fld:'vPGMNAME',pic:''},{av:'AV73IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV75IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV76IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_vital_weight_Activeeventkey',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'ActiveEventKey'},{av:'Ddo_br_vital_weight_Filteredtext_get',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'FilteredText_get'},{av:'Ddo_br_vital_weight_Filteredtextto_get',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_VITAL_WEIGHT.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_vital_weight_Sortedstatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'AV63TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV64TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'Ddo_br_vitalid_Sortedstatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_vital_vitalid_Sortedstatus',ctrl:'DDO_BR_VITAL_VITALID',prop:'SortedStatus'},{av:'Ddo_br_vital_measuredate_Sortedstatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'Ddo_br_vital_temperature_Sortedstatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'},{av:'Ddo_br_vital_pulse_Sortedstatus',ctrl:'DDO_BR_VITAL_PULSE',prop:'SortedStatus'},{av:'Ddo_br_vital_respiration_Sortedstatus',ctrl:'DDO_BR_VITAL_RESPIRATION',prop:'SortedStatus'},{av:'Ddo_br_vital_systolic_Sortedstatus',ctrl:'DDO_BR_VITAL_SYSTOLIC',prop:'SortedStatus'},{av:'Ddo_br_vital_diastolic_Sortedstatus',ctrl:'DDO_BR_VITAL_DIASTOLIC',prop:'SortedStatus'},{av:'Ddo_br_vital_height_Sortedstatus',ctrl:'DDO_BR_VITAL_HEIGHT',prop:'SortedStatus'},{av:'AV16BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV28BR_Vital_VitalIDTitleFilterData',fld:'vBR_VITAL_VITALIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV38BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'AV42BR_Vital_PulseTitleFilterData',fld:'vBR_VITAL_PULSETITLEFILTERDATA',pic:''},{av:'AV46BR_Vital_RespirationTitleFilterData',fld:'vBR_VITAL_RESPIRATIONTITLEFILTERDATA',pic:''},{av:'AV50BR_Vital_SystolicTitleFilterData',fld:'vBR_VITAL_SYSTOLICTITLEFILTERDATA',pic:''},{av:'AV54BR_Vital_DiastolicTitleFilterData',fld:'vBR_VITAL_DIASTOLICTITLEFILTERDATA',pic:''},{av:'AV58BR_Vital_HeightTitleFilterData',fld:'vBR_VITAL_HEIGHTTITLEFILTERDATA',pic:''},{av:'AV62BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Vital_VitalID_Titleformat',ctrl:'BR_VITAL_VITALID',prop:'Titleformat'},{av:'edtBR_Vital_VitalID_Title',ctrl:'BR_VITAL_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'edtBR_Vital_Pulse_Titleformat',ctrl:'BR_VITAL_PULSE',prop:'Titleformat'},{av:'edtBR_Vital_Pulse_Title',ctrl:'BR_VITAL_PULSE',prop:'Title'},{av:'edtBR_Vital_Respiration_Titleformat',ctrl:'BR_VITAL_RESPIRATION',prop:'Titleformat'},{av:'edtBR_Vital_Respiration_Title',ctrl:'BR_VITAL_RESPIRATION',prop:'Title'},{av:'edtBR_Vital_Systolic_Titleformat',ctrl:'BR_VITAL_SYSTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Systolic_Title',ctrl:'BR_VITAL_SYSTOLIC',prop:'Title'},{av:'edtBR_Vital_Diastolic_Titleformat',ctrl:'BR_VITAL_DIASTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Diastolic_Title',ctrl:'BR_VITAL_DIASTOLIC',prop:'Title'},{av:'edtBR_Vital_Height_Titleformat',ctrl:'BR_VITAL_HEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Height_Title',ctrl:'BR_VITAL_HEIGHT',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'AV68GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV69GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV70GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV73IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV75IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E285Y2',iparms:[{av:'A150BR_VitalID',fld:'BR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV73IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV75IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV76IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'A85BR_Information_ID',fld:'BR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV71Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'},{av:'AV72Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV74Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'},{av:'edtBR_Information_PatientNo_Link',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E255Y2',iparms:[{av:'A150BR_VitalID',fld:'BR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
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
         Ddo_br_vitalid_Activeeventkey = "";
         Ddo_br_vitalid_Filteredtext_get = "";
         Ddo_br_vitalid_Filteredtextto_get = "";
         Ddo_br_encounterid_Activeeventkey = "";
         Ddo_br_encounterid_Filteredtext_get = "";
         Ddo_br_encounterid_Filteredtextto_get = "";
         Ddo_br_information_patientno_Activeeventkey = "";
         Ddo_br_information_patientno_Filteredtext_get = "";
         Ddo_br_information_patientno_Selectedvalue_get = "";
         Ddo_br_vital_vitalid_Activeeventkey = "";
         Ddo_br_vital_vitalid_Filteredtext_get = "";
         Ddo_br_vital_vitalid_Filteredtextto_get = "";
         Ddo_br_vital_measuredate_Activeeventkey = "";
         Ddo_br_vital_measuredate_Filteredtext_get = "";
         Ddo_br_vital_measuredate_Filteredtextto_get = "";
         Ddo_br_vital_temperature_Activeeventkey = "";
         Ddo_br_vital_temperature_Filteredtext_get = "";
         Ddo_br_vital_temperature_Filteredtextto_get = "";
         Ddo_br_vital_pulse_Activeeventkey = "";
         Ddo_br_vital_pulse_Filteredtext_get = "";
         Ddo_br_vital_pulse_Filteredtextto_get = "";
         Ddo_br_vital_respiration_Activeeventkey = "";
         Ddo_br_vital_respiration_Filteredtext_get = "";
         Ddo_br_vital_respiration_Filteredtextto_get = "";
         Ddo_br_vital_systolic_Activeeventkey = "";
         Ddo_br_vital_systolic_Filteredtext_get = "";
         Ddo_br_vital_systolic_Filteredtextto_get = "";
         Ddo_br_vital_diastolic_Activeeventkey = "";
         Ddo_br_vital_diastolic_Filteredtext_get = "";
         Ddo_br_vital_diastolic_Filteredtextto_get = "";
         Ddo_br_vital_height_Activeeventkey = "";
         Ddo_br_vital_height_Filteredtext_get = "";
         Ddo_br_vital_height_Filteredtextto_get = "";
         Ddo_br_vital_weight_Activeeventkey = "";
         Ddo_br_vital_weight_Filteredtext_get = "";
         Ddo_br_vital_weight_Filteredtextto_get = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV25TFBR_Information_PatientNo = "";
         AV26TFBR_Information_PatientNo_Sel = "";
         AV33TFBR_Vital_MeasureDate = DateTime.MinValue;
         AV34TFBR_Vital_MeasureDate_To = DateTime.MinValue;
         AV19ddo_BR_VitalIDTitleControlIdToReplace = "";
         AV23ddo_BR_EncounterIDTitleControlIdToReplace = "";
         AV27ddo_BR_Information_PatientNoTitleControlIdToReplace = "";
         AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace = "";
         AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace = "";
         AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace = "";
         AV45ddo_BR_Vital_PulseTitleControlIdToReplace = "";
         AV49ddo_BR_Vital_RespirationTitleControlIdToReplace = "";
         AV53ddo_BR_Vital_SystolicTitleControlIdToReplace = "";
         AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace = "";
         AV61ddo_BR_Vital_HeightTitleControlIdToReplace = "";
         AV65ddo_BR_Vital_WeightTitleControlIdToReplace = "";
         AV107Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV66DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV16BR_VitalIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_Information_PatientNoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28BR_Vital_VitalIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32BR_Vital_MeasureDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV38BR_Vital_TemperatureTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV42BR_Vital_PulseTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV46BR_Vital_RespirationTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV50BR_Vital_SystolicTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV54BR_Vital_DiastolicTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV58BR_Vital_HeightTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV62BR_Vital_WeightTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_vitalid_Filteredtext_set = "";
         Ddo_br_vitalid_Filteredtextto_set = "";
         Ddo_br_vitalid_Sortedstatus = "";
         Ddo_br_encounterid_Filteredtext_set = "";
         Ddo_br_encounterid_Filteredtextto_set = "";
         Ddo_br_encounterid_Sortedstatus = "";
         Ddo_br_information_patientno_Filteredtext_set = "";
         Ddo_br_information_patientno_Selectedvalue_set = "";
         Ddo_br_information_patientno_Sortedstatus = "";
         Ddo_br_vital_vitalid_Filteredtext_set = "";
         Ddo_br_vital_vitalid_Filteredtextto_set = "";
         Ddo_br_vital_vitalid_Sortedstatus = "";
         Ddo_br_vital_measuredate_Filteredtext_set = "";
         Ddo_br_vital_measuredate_Filteredtextto_set = "";
         Ddo_br_vital_measuredate_Sortedstatus = "";
         Ddo_br_vital_temperature_Filteredtext_set = "";
         Ddo_br_vital_temperature_Filteredtextto_set = "";
         Ddo_br_vital_temperature_Sortedstatus = "";
         Ddo_br_vital_pulse_Filteredtext_set = "";
         Ddo_br_vital_pulse_Filteredtextto_set = "";
         Ddo_br_vital_pulse_Sortedstatus = "";
         Ddo_br_vital_respiration_Filteredtext_set = "";
         Ddo_br_vital_respiration_Filteredtextto_set = "";
         Ddo_br_vital_respiration_Sortedstatus = "";
         Ddo_br_vital_systolic_Filteredtext_set = "";
         Ddo_br_vital_systolic_Filteredtextto_set = "";
         Ddo_br_vital_systolic_Sortedstatus = "";
         Ddo_br_vital_diastolic_Filteredtext_set = "";
         Ddo_br_vital_diastolic_Filteredtextto_set = "";
         Ddo_br_vital_diastolic_Sortedstatus = "";
         Ddo_br_vital_height_Filteredtext_set = "";
         Ddo_br_vital_height_Filteredtextto_set = "";
         Ddo_br_vital_height_Sortedstatus = "";
         Ddo_br_vital_weight_Filteredtext_set = "";
         Ddo_br_vital_weight_Filteredtextto_set = "";
         Ddo_br_vital_weight_Sortedstatus = "";
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
         AV71Display = "";
         AV72Update = "";
         AV74Delete = "";
         A36BR_Information_PatientNo = "";
         A152BR_Vital_MeasureDate = DateTime.MinValue;
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_vitalid = new GXUserControl();
         ucDdo_br_encounterid = new GXUserControl();
         ucDdo_br_information_patientno = new GXUserControl();
         ucDdo_br_vital_vitalid = new GXUserControl();
         ucDdo_br_vital_measuredate = new GXUserControl();
         ucDdo_br_vital_temperature = new GXUserControl();
         ucDdo_br_vital_pulse = new GXUserControl();
         ucDdo_br_vital_respiration = new GXUserControl();
         ucDdo_br_vital_systolic = new GXUserControl();
         ucDdo_br_vital_diastolic = new GXUserControl();
         ucDdo_br_vital_height = new GXUserControl();
         ucDdo_br_vital_weight = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         AV35DDO_BR_Vital_MeasureDateAuxDate = DateTime.MinValue;
         AV36DDO_BR_Vital_MeasureDateAuxDateTo = DateTime.MinValue;
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV104Display_GXI = "";
         AV105Update_GXI = "";
         AV106Delete_GXI = "";
         scmdbuf = "";
         lV84BR_VitalWWDS_5_Tfbr_information_patientno = "";
         AV85BR_VitalWWDS_6_Tfbr_information_patientno_sel = "";
         AV84BR_VitalWWDS_5_Tfbr_information_patientno = "";
         AV88BR_VitalWWDS_9_Tfbr_vital_measuredate = DateTime.MinValue;
         AV89BR_VitalWWDS_10_Tfbr_vital_measuredate_to = DateTime.MinValue;
         H005Y2_A85BR_Information_ID = new long[1] ;
         H005Y2_n85BR_Information_ID = new bool[] {false} ;
         H005Y2_A159BR_Vital_Weight = new decimal[1] ;
         H005Y2_n159BR_Vital_Weight = new bool[] {false} ;
         H005Y2_A158BR_Vital_Height = new decimal[1] ;
         H005Y2_n158BR_Vital_Height = new bool[] {false} ;
         H005Y2_A157BR_Vital_Diastolic = new decimal[1] ;
         H005Y2_n157BR_Vital_Diastolic = new bool[] {false} ;
         H005Y2_A156BR_Vital_Systolic = new decimal[1] ;
         H005Y2_n156BR_Vital_Systolic = new bool[] {false} ;
         H005Y2_A155BR_Vital_Respiration = new decimal[1] ;
         H005Y2_n155BR_Vital_Respiration = new bool[] {false} ;
         H005Y2_A154BR_Vital_Pulse = new decimal[1] ;
         H005Y2_n154BR_Vital_Pulse = new bool[] {false} ;
         H005Y2_A153BR_Vital_Temperature = new decimal[1] ;
         H005Y2_n153BR_Vital_Temperature = new bool[] {false} ;
         H005Y2_A152BR_Vital_MeasureDate = new DateTime[] {DateTime.MinValue} ;
         H005Y2_n152BR_Vital_MeasureDate = new bool[] {false} ;
         H005Y2_A151BR_Vital_VitalID = new long[1] ;
         H005Y2_n151BR_Vital_VitalID = new bool[] {false} ;
         H005Y2_A36BR_Information_PatientNo = new String[] {""} ;
         H005Y2_n36BR_Information_PatientNo = new bool[] {false} ;
         H005Y2_A19BR_EncounterID = new long[1] ;
         H005Y2_A150BR_VitalID = new long[1] ;
         H005Y3_AGRID_nRecordCount = new long[1] ;
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_vitalww__default(),
            new Object[][] {
                new Object[] {
               H005Y2_A85BR_Information_ID, H005Y2_n85BR_Information_ID, H005Y2_A159BR_Vital_Weight, H005Y2_n159BR_Vital_Weight, H005Y2_A158BR_Vital_Height, H005Y2_n158BR_Vital_Height, H005Y2_A157BR_Vital_Diastolic, H005Y2_n157BR_Vital_Diastolic, H005Y2_A156BR_Vital_Systolic, H005Y2_n156BR_Vital_Systolic,
               H005Y2_A155BR_Vital_Respiration, H005Y2_n155BR_Vital_Respiration, H005Y2_A154BR_Vital_Pulse, H005Y2_n154BR_Vital_Pulse, H005Y2_A153BR_Vital_Temperature, H005Y2_n153BR_Vital_Temperature, H005Y2_A152BR_Vital_MeasureDate, H005Y2_n152BR_Vital_MeasureDate, H005Y2_A151BR_Vital_VitalID, H005Y2_n151BR_Vital_VitalID,
               H005Y2_A36BR_Information_PatientNo, H005Y2_n36BR_Information_PatientNo, H005Y2_A19BR_EncounterID, H005Y2_A150BR_VitalID
               }
               , new Object[] {
               H005Y3_AGRID_nRecordCount
               }
            }
         );
         AV107Pgmname = "BR_VitalWW";
         /* GeneXus formulas. */
         AV107Pgmname = "BR_VitalWW";
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
      private short edtBR_VitalID_Titleformat ;
      private short edtBR_EncounterID_Titleformat ;
      private short edtBR_Information_PatientNo_Titleformat ;
      private short edtBR_Vital_VitalID_Titleformat ;
      private short edtBR_Vital_MeasureDate_Titleformat ;
      private short edtBR_Vital_Temperature_Titleformat ;
      private short edtBR_Vital_Pulse_Titleformat ;
      private short edtBR_Vital_Respiration_Titleformat ;
      private short edtBR_Vital_Systolic_Titleformat ;
      private short edtBR_Vital_Diastolic_Titleformat ;
      private short edtBR_Vital_Height_Titleformat ;
      private short edtBR_Vital_Weight_Titleformat ;
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
      private int Ddo_br_information_patientno_Datalistupdateminimumcharacters ;
      private int bttBtninsert_Visible ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavUpdate_Visible ;
      private int edtavDelete_Visible ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_br_vitalidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_vital_vitalidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_vital_pulsetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_vital_respirationtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_vital_systolictitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_vital_diastolictitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_vital_heighttitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_vital_weighttitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfbr_vitalid_Visible ;
      private int edtavTfbr_vitalid_to_Visible ;
      private int edtavTfbr_encounterid_Visible ;
      private int edtavTfbr_encounterid_to_Visible ;
      private int edtavTfbr_information_patientno_Visible ;
      private int edtavTfbr_information_patientno_sel_Visible ;
      private int edtavTfbr_vital_vitalid_Visible ;
      private int edtavTfbr_vital_vitalid_to_Visible ;
      private int edtavTfbr_vital_measuredate_Visible ;
      private int edtavTfbr_vital_measuredate_to_Visible ;
      private int edtavTfbr_vital_temperature_Visible ;
      private int edtavTfbr_vital_temperature_to_Visible ;
      private int edtavTfbr_vital_pulse_Visible ;
      private int edtavTfbr_vital_pulse_to_Visible ;
      private int edtavTfbr_vital_respiration_Visible ;
      private int edtavTfbr_vital_respiration_to_Visible ;
      private int edtavTfbr_vital_systolic_Visible ;
      private int edtavTfbr_vital_systolic_to_Visible ;
      private int edtavTfbr_vital_diastolic_Visible ;
      private int edtavTfbr_vital_diastolic_to_Visible ;
      private int edtavTfbr_vital_height_Visible ;
      private int edtavTfbr_vital_height_to_Visible ;
      private int edtavTfbr_vital_weight_Visible ;
      private int edtavTfbr_vital_weight_to_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV67PageToGo ;
      private int AV108GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV17TFBR_VitalID ;
      private long AV18TFBR_VitalID_To ;
      private long AV21TFBR_EncounterID ;
      private long AV22TFBR_EncounterID_To ;
      private long AV29TFBR_Vital_VitalID ;
      private long AV30TFBR_Vital_VitalID_To ;
      private long AV68GridCurrentPage ;
      private long AV70GridRecordCount ;
      private long AV69GridPageSize ;
      private long A85BR_Information_ID ;
      private long A150BR_VitalID ;
      private long A19BR_EncounterID ;
      private long A151BR_Vital_VitalID ;
      private long GRID_nCurrentRecord ;
      private long AV80BR_VitalWWDS_1_Tfbr_vitalid ;
      private long AV81BR_VitalWWDS_2_Tfbr_vitalid_to ;
      private long AV82BR_VitalWWDS_3_Tfbr_encounterid ;
      private long AV83BR_VitalWWDS_4_Tfbr_encounterid_to ;
      private long AV86BR_VitalWWDS_7_Tfbr_vital_vitalid ;
      private long AV87BR_VitalWWDS_8_Tfbr_vital_vitalid_to ;
      private long GRID_nRecordCount ;
      private decimal AV39TFBR_Vital_Temperature ;
      private decimal AV40TFBR_Vital_Temperature_To ;
      private decimal AV43TFBR_Vital_Pulse ;
      private decimal AV44TFBR_Vital_Pulse_To ;
      private decimal AV47TFBR_Vital_Respiration ;
      private decimal AV48TFBR_Vital_Respiration_To ;
      private decimal AV51TFBR_Vital_Systolic ;
      private decimal AV52TFBR_Vital_Systolic_To ;
      private decimal AV55TFBR_Vital_Diastolic ;
      private decimal AV56TFBR_Vital_Diastolic_To ;
      private decimal AV59TFBR_Vital_Height ;
      private decimal AV60TFBR_Vital_Height_To ;
      private decimal AV63TFBR_Vital_Weight ;
      private decimal AV64TFBR_Vital_Weight_To ;
      private decimal A153BR_Vital_Temperature ;
      private decimal A154BR_Vital_Pulse ;
      private decimal A155BR_Vital_Respiration ;
      private decimal A156BR_Vital_Systolic ;
      private decimal A157BR_Vital_Diastolic ;
      private decimal A158BR_Vital_Height ;
      private decimal A159BR_Vital_Weight ;
      private decimal AV90BR_VitalWWDS_11_Tfbr_vital_temperature ;
      private decimal AV91BR_VitalWWDS_12_Tfbr_vital_temperature_to ;
      private decimal AV92BR_VitalWWDS_13_Tfbr_vital_pulse ;
      private decimal AV93BR_VitalWWDS_14_Tfbr_vital_pulse_to ;
      private decimal AV94BR_VitalWWDS_15_Tfbr_vital_respiration ;
      private decimal AV95BR_VitalWWDS_16_Tfbr_vital_respiration_to ;
      private decimal AV96BR_VitalWWDS_17_Tfbr_vital_systolic ;
      private decimal AV97BR_VitalWWDS_18_Tfbr_vital_systolic_to ;
      private decimal AV98BR_VitalWWDS_19_Tfbr_vital_diastolic ;
      private decimal AV99BR_VitalWWDS_20_Tfbr_vital_diastolic_to ;
      private decimal AV100BR_VitalWWDS_21_Tfbr_vital_height ;
      private decimal AV101BR_VitalWWDS_22_Tfbr_vital_height_to ;
      private decimal AV102BR_VitalWWDS_23_Tfbr_vital_weight ;
      private decimal AV103BR_VitalWWDS_24_Tfbr_vital_weight_to ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_vitalid_Activeeventkey ;
      private String Ddo_br_vitalid_Filteredtext_get ;
      private String Ddo_br_vitalid_Filteredtextto_get ;
      private String Ddo_br_encounterid_Activeeventkey ;
      private String Ddo_br_encounterid_Filteredtext_get ;
      private String Ddo_br_encounterid_Filteredtextto_get ;
      private String Ddo_br_information_patientno_Activeeventkey ;
      private String Ddo_br_information_patientno_Filteredtext_get ;
      private String Ddo_br_information_patientno_Selectedvalue_get ;
      private String Ddo_br_vital_vitalid_Activeeventkey ;
      private String Ddo_br_vital_vitalid_Filteredtext_get ;
      private String Ddo_br_vital_vitalid_Filteredtextto_get ;
      private String Ddo_br_vital_measuredate_Activeeventkey ;
      private String Ddo_br_vital_measuredate_Filteredtext_get ;
      private String Ddo_br_vital_measuredate_Filteredtextto_get ;
      private String Ddo_br_vital_temperature_Activeeventkey ;
      private String Ddo_br_vital_temperature_Filteredtext_get ;
      private String Ddo_br_vital_temperature_Filteredtextto_get ;
      private String Ddo_br_vital_pulse_Activeeventkey ;
      private String Ddo_br_vital_pulse_Filteredtext_get ;
      private String Ddo_br_vital_pulse_Filteredtextto_get ;
      private String Ddo_br_vital_respiration_Activeeventkey ;
      private String Ddo_br_vital_respiration_Filteredtext_get ;
      private String Ddo_br_vital_respiration_Filteredtextto_get ;
      private String Ddo_br_vital_systolic_Activeeventkey ;
      private String Ddo_br_vital_systolic_Filteredtext_get ;
      private String Ddo_br_vital_systolic_Filteredtextto_get ;
      private String Ddo_br_vital_diastolic_Activeeventkey ;
      private String Ddo_br_vital_diastolic_Filteredtext_get ;
      private String Ddo_br_vital_diastolic_Filteredtextto_get ;
      private String Ddo_br_vital_height_Activeeventkey ;
      private String Ddo_br_vital_height_Filteredtext_get ;
      private String Ddo_br_vital_height_Filteredtextto_get ;
      private String Ddo_br_vital_weight_Activeeventkey ;
      private String Ddo_br_vital_weight_Filteredtext_get ;
      private String Ddo_br_vital_weight_Filteredtextto_get ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_31_idx="0001" ;
      private String AV107Pgmname ;
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
      private String Ddo_br_vitalid_Caption ;
      private String Ddo_br_vitalid_Tooltip ;
      private String Ddo_br_vitalid_Cls ;
      private String Ddo_br_vitalid_Filteredtext_set ;
      private String Ddo_br_vitalid_Filteredtextto_set ;
      private String Ddo_br_vitalid_Dropdownoptionstype ;
      private String Ddo_br_vitalid_Titlecontrolidtoreplace ;
      private String Ddo_br_vitalid_Sortedstatus ;
      private String Ddo_br_vitalid_Filtertype ;
      private String Ddo_br_vitalid_Sortasc ;
      private String Ddo_br_vitalid_Sortdsc ;
      private String Ddo_br_vitalid_Cleanfilter ;
      private String Ddo_br_vitalid_Rangefilterfrom ;
      private String Ddo_br_vitalid_Rangefilterto ;
      private String Ddo_br_vitalid_Searchbuttontext ;
      private String Ddo_br_encounterid_Caption ;
      private String Ddo_br_encounterid_Tooltip ;
      private String Ddo_br_encounterid_Cls ;
      private String Ddo_br_encounterid_Filteredtext_set ;
      private String Ddo_br_encounterid_Filteredtextto_set ;
      private String Ddo_br_encounterid_Dropdownoptionstype ;
      private String Ddo_br_encounterid_Titlecontrolidtoreplace ;
      private String Ddo_br_encounterid_Sortedstatus ;
      private String Ddo_br_encounterid_Filtertype ;
      private String Ddo_br_encounterid_Sortasc ;
      private String Ddo_br_encounterid_Sortdsc ;
      private String Ddo_br_encounterid_Cleanfilter ;
      private String Ddo_br_encounterid_Rangefilterfrom ;
      private String Ddo_br_encounterid_Rangefilterto ;
      private String Ddo_br_encounterid_Searchbuttontext ;
      private String Ddo_br_information_patientno_Caption ;
      private String Ddo_br_information_patientno_Tooltip ;
      private String Ddo_br_information_patientno_Cls ;
      private String Ddo_br_information_patientno_Filteredtext_set ;
      private String Ddo_br_information_patientno_Selectedvalue_set ;
      private String Ddo_br_information_patientno_Dropdownoptionstype ;
      private String Ddo_br_information_patientno_Titlecontrolidtoreplace ;
      private String Ddo_br_information_patientno_Sortedstatus ;
      private String Ddo_br_information_patientno_Filtertype ;
      private String Ddo_br_information_patientno_Datalisttype ;
      private String Ddo_br_information_patientno_Datalistproc ;
      private String Ddo_br_information_patientno_Sortasc ;
      private String Ddo_br_information_patientno_Sortdsc ;
      private String Ddo_br_information_patientno_Loadingdata ;
      private String Ddo_br_information_patientno_Cleanfilter ;
      private String Ddo_br_information_patientno_Noresultsfound ;
      private String Ddo_br_information_patientno_Searchbuttontext ;
      private String Ddo_br_vital_vitalid_Caption ;
      private String Ddo_br_vital_vitalid_Tooltip ;
      private String Ddo_br_vital_vitalid_Cls ;
      private String Ddo_br_vital_vitalid_Filteredtext_set ;
      private String Ddo_br_vital_vitalid_Filteredtextto_set ;
      private String Ddo_br_vital_vitalid_Dropdownoptionstype ;
      private String Ddo_br_vital_vitalid_Titlecontrolidtoreplace ;
      private String Ddo_br_vital_vitalid_Sortedstatus ;
      private String Ddo_br_vital_vitalid_Filtertype ;
      private String Ddo_br_vital_vitalid_Sortasc ;
      private String Ddo_br_vital_vitalid_Sortdsc ;
      private String Ddo_br_vital_vitalid_Cleanfilter ;
      private String Ddo_br_vital_vitalid_Rangefilterfrom ;
      private String Ddo_br_vital_vitalid_Rangefilterto ;
      private String Ddo_br_vital_vitalid_Searchbuttontext ;
      private String Ddo_br_vital_measuredate_Caption ;
      private String Ddo_br_vital_measuredate_Tooltip ;
      private String Ddo_br_vital_measuredate_Cls ;
      private String Ddo_br_vital_measuredate_Filteredtext_set ;
      private String Ddo_br_vital_measuredate_Filteredtextto_set ;
      private String Ddo_br_vital_measuredate_Dropdownoptionstype ;
      private String Ddo_br_vital_measuredate_Titlecontrolidtoreplace ;
      private String Ddo_br_vital_measuredate_Sortedstatus ;
      private String Ddo_br_vital_measuredate_Filtertype ;
      private String Ddo_br_vital_measuredate_Sortasc ;
      private String Ddo_br_vital_measuredate_Sortdsc ;
      private String Ddo_br_vital_measuredate_Cleanfilter ;
      private String Ddo_br_vital_measuredate_Rangefilterfrom ;
      private String Ddo_br_vital_measuredate_Rangefilterto ;
      private String Ddo_br_vital_measuredate_Searchbuttontext ;
      private String Ddo_br_vital_temperature_Caption ;
      private String Ddo_br_vital_temperature_Tooltip ;
      private String Ddo_br_vital_temperature_Cls ;
      private String Ddo_br_vital_temperature_Filteredtext_set ;
      private String Ddo_br_vital_temperature_Filteredtextto_set ;
      private String Ddo_br_vital_temperature_Dropdownoptionstype ;
      private String Ddo_br_vital_temperature_Titlecontrolidtoreplace ;
      private String Ddo_br_vital_temperature_Sortedstatus ;
      private String Ddo_br_vital_temperature_Filtertype ;
      private String Ddo_br_vital_temperature_Sortasc ;
      private String Ddo_br_vital_temperature_Sortdsc ;
      private String Ddo_br_vital_temperature_Cleanfilter ;
      private String Ddo_br_vital_temperature_Rangefilterfrom ;
      private String Ddo_br_vital_temperature_Rangefilterto ;
      private String Ddo_br_vital_temperature_Searchbuttontext ;
      private String Ddo_br_vital_pulse_Caption ;
      private String Ddo_br_vital_pulse_Tooltip ;
      private String Ddo_br_vital_pulse_Cls ;
      private String Ddo_br_vital_pulse_Filteredtext_set ;
      private String Ddo_br_vital_pulse_Filteredtextto_set ;
      private String Ddo_br_vital_pulse_Dropdownoptionstype ;
      private String Ddo_br_vital_pulse_Titlecontrolidtoreplace ;
      private String Ddo_br_vital_pulse_Sortedstatus ;
      private String Ddo_br_vital_pulse_Filtertype ;
      private String Ddo_br_vital_pulse_Sortasc ;
      private String Ddo_br_vital_pulse_Sortdsc ;
      private String Ddo_br_vital_pulse_Cleanfilter ;
      private String Ddo_br_vital_pulse_Rangefilterfrom ;
      private String Ddo_br_vital_pulse_Rangefilterto ;
      private String Ddo_br_vital_pulse_Searchbuttontext ;
      private String Ddo_br_vital_respiration_Caption ;
      private String Ddo_br_vital_respiration_Tooltip ;
      private String Ddo_br_vital_respiration_Cls ;
      private String Ddo_br_vital_respiration_Filteredtext_set ;
      private String Ddo_br_vital_respiration_Filteredtextto_set ;
      private String Ddo_br_vital_respiration_Dropdownoptionstype ;
      private String Ddo_br_vital_respiration_Titlecontrolidtoreplace ;
      private String Ddo_br_vital_respiration_Sortedstatus ;
      private String Ddo_br_vital_respiration_Filtertype ;
      private String Ddo_br_vital_respiration_Sortasc ;
      private String Ddo_br_vital_respiration_Sortdsc ;
      private String Ddo_br_vital_respiration_Cleanfilter ;
      private String Ddo_br_vital_respiration_Rangefilterfrom ;
      private String Ddo_br_vital_respiration_Rangefilterto ;
      private String Ddo_br_vital_respiration_Searchbuttontext ;
      private String Ddo_br_vital_systolic_Caption ;
      private String Ddo_br_vital_systolic_Tooltip ;
      private String Ddo_br_vital_systolic_Cls ;
      private String Ddo_br_vital_systolic_Filteredtext_set ;
      private String Ddo_br_vital_systolic_Filteredtextto_set ;
      private String Ddo_br_vital_systolic_Dropdownoptionstype ;
      private String Ddo_br_vital_systolic_Titlecontrolidtoreplace ;
      private String Ddo_br_vital_systolic_Sortedstatus ;
      private String Ddo_br_vital_systolic_Filtertype ;
      private String Ddo_br_vital_systolic_Sortasc ;
      private String Ddo_br_vital_systolic_Sortdsc ;
      private String Ddo_br_vital_systolic_Cleanfilter ;
      private String Ddo_br_vital_systolic_Rangefilterfrom ;
      private String Ddo_br_vital_systolic_Rangefilterto ;
      private String Ddo_br_vital_systolic_Searchbuttontext ;
      private String Ddo_br_vital_diastolic_Caption ;
      private String Ddo_br_vital_diastolic_Tooltip ;
      private String Ddo_br_vital_diastolic_Cls ;
      private String Ddo_br_vital_diastolic_Filteredtext_set ;
      private String Ddo_br_vital_diastolic_Filteredtextto_set ;
      private String Ddo_br_vital_diastolic_Dropdownoptionstype ;
      private String Ddo_br_vital_diastolic_Titlecontrolidtoreplace ;
      private String Ddo_br_vital_diastolic_Sortedstatus ;
      private String Ddo_br_vital_diastolic_Filtertype ;
      private String Ddo_br_vital_diastolic_Sortasc ;
      private String Ddo_br_vital_diastolic_Sortdsc ;
      private String Ddo_br_vital_diastolic_Cleanfilter ;
      private String Ddo_br_vital_diastolic_Rangefilterfrom ;
      private String Ddo_br_vital_diastolic_Rangefilterto ;
      private String Ddo_br_vital_diastolic_Searchbuttontext ;
      private String Ddo_br_vital_height_Caption ;
      private String Ddo_br_vital_height_Tooltip ;
      private String Ddo_br_vital_height_Cls ;
      private String Ddo_br_vital_height_Filteredtext_set ;
      private String Ddo_br_vital_height_Filteredtextto_set ;
      private String Ddo_br_vital_height_Dropdownoptionstype ;
      private String Ddo_br_vital_height_Titlecontrolidtoreplace ;
      private String Ddo_br_vital_height_Sortedstatus ;
      private String Ddo_br_vital_height_Filtertype ;
      private String Ddo_br_vital_height_Sortasc ;
      private String Ddo_br_vital_height_Sortdsc ;
      private String Ddo_br_vital_height_Cleanfilter ;
      private String Ddo_br_vital_height_Rangefilterfrom ;
      private String Ddo_br_vital_height_Rangefilterto ;
      private String Ddo_br_vital_height_Searchbuttontext ;
      private String Ddo_br_vital_weight_Caption ;
      private String Ddo_br_vital_weight_Tooltip ;
      private String Ddo_br_vital_weight_Cls ;
      private String Ddo_br_vital_weight_Filteredtext_set ;
      private String Ddo_br_vital_weight_Filteredtextto_set ;
      private String Ddo_br_vital_weight_Dropdownoptionstype ;
      private String Ddo_br_vital_weight_Titlecontrolidtoreplace ;
      private String Ddo_br_vital_weight_Sortedstatus ;
      private String Ddo_br_vital_weight_Filtertype ;
      private String Ddo_br_vital_weight_Sortasc ;
      private String Ddo_br_vital_weight_Sortdsc ;
      private String Ddo_br_vital_weight_Cleanfilter ;
      private String Ddo_br_vital_weight_Rangefilterfrom ;
      private String Ddo_br_vital_weight_Rangefilterto ;
      private String Ddo_br_vital_weight_Searchbuttontext ;
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
      private String edtBR_VitalID_Title ;
      private String edtBR_EncounterID_Title ;
      private String edtBR_Information_PatientNo_Title ;
      private String edtBR_Vital_VitalID_Title ;
      private String edtBR_Vital_MeasureDate_Title ;
      private String edtBR_Vital_Temperature_Title ;
      private String edtBR_Vital_Pulse_Title ;
      private String edtBR_Vital_Respiration_Title ;
      private String edtBR_Vital_Systolic_Title ;
      private String edtBR_Vital_Diastolic_Title ;
      private String edtBR_Vital_Height_Title ;
      private String edtBR_Vital_Weight_Title ;
      private String subGrid_Header ;
      private String edtavDisplay_Link ;
      private String edtavDisplay_Tooltiptext ;
      private String edtavUpdate_Link ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavDelete_Link ;
      private String edtavDelete_Tooltiptext ;
      private String edtBR_Information_PatientNo_Link ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_vitalid_Internalname ;
      private String edtavDdo_br_vitalidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounterid_Internalname ;
      private String edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_information_patientno_Internalname ;
      private String edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_vital_vitalid_Internalname ;
      private String edtavDdo_br_vital_vitalidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_vital_measuredate_Internalname ;
      private String edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_vital_temperature_Internalname ;
      private String edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_vital_pulse_Internalname ;
      private String edtavDdo_br_vital_pulsetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_vital_respiration_Internalname ;
      private String edtavDdo_br_vital_respirationtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_vital_systolic_Internalname ;
      private String edtavDdo_br_vital_systolictitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_vital_diastolic_Internalname ;
      private String edtavDdo_br_vital_diastolictitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_vital_height_Internalname ;
      private String edtavDdo_br_vital_heighttitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_vital_weight_Internalname ;
      private String edtavDdo_br_vital_weighttitlecontrolidtoreplace_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavTfbr_vitalid_Internalname ;
      private String edtavTfbr_vitalid_Jsonclick ;
      private String edtavTfbr_vitalid_to_Internalname ;
      private String edtavTfbr_vitalid_to_Jsonclick ;
      private String edtavTfbr_encounterid_Internalname ;
      private String edtavTfbr_encounterid_Jsonclick ;
      private String edtavTfbr_encounterid_to_Internalname ;
      private String edtavTfbr_encounterid_to_Jsonclick ;
      private String edtavTfbr_information_patientno_Internalname ;
      private String edtavTfbr_information_patientno_Jsonclick ;
      private String edtavTfbr_information_patientno_sel_Internalname ;
      private String edtavTfbr_information_patientno_sel_Jsonclick ;
      private String edtavTfbr_vital_vitalid_Internalname ;
      private String edtavTfbr_vital_vitalid_Jsonclick ;
      private String edtavTfbr_vital_vitalid_to_Internalname ;
      private String edtavTfbr_vital_vitalid_to_Jsonclick ;
      private String edtavTfbr_vital_measuredate_Internalname ;
      private String edtavTfbr_vital_measuredate_Jsonclick ;
      private String edtavTfbr_vital_measuredate_to_Internalname ;
      private String edtavTfbr_vital_measuredate_to_Jsonclick ;
      private String divDdo_br_vital_measuredateauxdates_Internalname ;
      private String edtavDdo_br_vital_measuredateauxdate_Internalname ;
      private String edtavDdo_br_vital_measuredateauxdate_Jsonclick ;
      private String edtavDdo_br_vital_measuredateauxdateto_Internalname ;
      private String edtavDdo_br_vital_measuredateauxdateto_Jsonclick ;
      private String edtavTfbr_vital_temperature_Internalname ;
      private String edtavTfbr_vital_temperature_Jsonclick ;
      private String edtavTfbr_vital_temperature_to_Internalname ;
      private String edtavTfbr_vital_temperature_to_Jsonclick ;
      private String edtavTfbr_vital_pulse_Internalname ;
      private String edtavTfbr_vital_pulse_Jsonclick ;
      private String edtavTfbr_vital_pulse_to_Internalname ;
      private String edtavTfbr_vital_pulse_to_Jsonclick ;
      private String edtavTfbr_vital_respiration_Internalname ;
      private String edtavTfbr_vital_respiration_Jsonclick ;
      private String edtavTfbr_vital_respiration_to_Internalname ;
      private String edtavTfbr_vital_respiration_to_Jsonclick ;
      private String edtavTfbr_vital_systolic_Internalname ;
      private String edtavTfbr_vital_systolic_Jsonclick ;
      private String edtavTfbr_vital_systolic_to_Internalname ;
      private String edtavTfbr_vital_systolic_to_Jsonclick ;
      private String edtavTfbr_vital_diastolic_Internalname ;
      private String edtavTfbr_vital_diastolic_Jsonclick ;
      private String edtavTfbr_vital_diastolic_to_Internalname ;
      private String edtavTfbr_vital_diastolic_to_Jsonclick ;
      private String edtavTfbr_vital_height_Internalname ;
      private String edtavTfbr_vital_height_Jsonclick ;
      private String edtavTfbr_vital_height_to_Internalname ;
      private String edtavTfbr_vital_height_to_Jsonclick ;
      private String edtavTfbr_vital_weight_Internalname ;
      private String edtavTfbr_vital_weight_Jsonclick ;
      private String edtavTfbr_vital_weight_to_Internalname ;
      private String edtavTfbr_vital_weight_to_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDisplay_Internalname ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String edtBR_VitalID_Internalname ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_Vital_VitalID_Internalname ;
      private String edtBR_Vital_MeasureDate_Internalname ;
      private String edtBR_Vital_Temperature_Internalname ;
      private String edtBR_Vital_Pulse_Internalname ;
      private String edtBR_Vital_Respiration_Internalname ;
      private String edtBR_Vital_Systolic_Internalname ;
      private String edtBR_Vital_Diastolic_Internalname ;
      private String edtBR_Vital_Height_Internalname ;
      private String edtBR_Vital_Weight_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_31_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtBR_VitalID_Jsonclick ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String edtBR_Vital_VitalID_Jsonclick ;
      private String edtBR_Vital_MeasureDate_Jsonclick ;
      private String edtBR_Vital_Temperature_Jsonclick ;
      private String edtBR_Vital_Pulse_Jsonclick ;
      private String edtBR_Vital_Respiration_Jsonclick ;
      private String edtBR_Vital_Systolic_Jsonclick ;
      private String edtBR_Vital_Diastolic_Jsonclick ;
      private String edtBR_Vital_Height_Jsonclick ;
      private String edtBR_Vital_Weight_Jsonclick ;
      private DateTime AV33TFBR_Vital_MeasureDate ;
      private DateTime AV34TFBR_Vital_MeasureDate_To ;
      private DateTime A152BR_Vital_MeasureDate ;
      private DateTime AV35DDO_BR_Vital_MeasureDateAuxDate ;
      private DateTime AV36DDO_BR_Vital_MeasureDateAuxDateTo ;
      private DateTime AV88BR_VitalWWDS_9_Tfbr_vital_measuredate ;
      private DateTime AV89BR_VitalWWDS_10_Tfbr_vital_measuredate_to ;
      private bool entryPointCalled ;
      private bool AV14OrderedDsc ;
      private bool AV73IsAuthorized_Update ;
      private bool AV75IsAuthorized_Delete ;
      private bool AV76IsAuthorized_BR_Information_PatientNo ;
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
      private bool Ddo_br_vitalid_Includesortasc ;
      private bool Ddo_br_vitalid_Includesortdsc ;
      private bool Ddo_br_vitalid_Includefilter ;
      private bool Ddo_br_vitalid_Filterisrange ;
      private bool Ddo_br_vitalid_Includedatalist ;
      private bool Ddo_br_encounterid_Includesortasc ;
      private bool Ddo_br_encounterid_Includesortdsc ;
      private bool Ddo_br_encounterid_Includefilter ;
      private bool Ddo_br_encounterid_Filterisrange ;
      private bool Ddo_br_encounterid_Includedatalist ;
      private bool Ddo_br_information_patientno_Includesortasc ;
      private bool Ddo_br_information_patientno_Includesortdsc ;
      private bool Ddo_br_information_patientno_Includefilter ;
      private bool Ddo_br_information_patientno_Filterisrange ;
      private bool Ddo_br_information_patientno_Includedatalist ;
      private bool Ddo_br_vital_vitalid_Includesortasc ;
      private bool Ddo_br_vital_vitalid_Includesortdsc ;
      private bool Ddo_br_vital_vitalid_Includefilter ;
      private bool Ddo_br_vital_vitalid_Filterisrange ;
      private bool Ddo_br_vital_vitalid_Includedatalist ;
      private bool Ddo_br_vital_measuredate_Includesortasc ;
      private bool Ddo_br_vital_measuredate_Includesortdsc ;
      private bool Ddo_br_vital_measuredate_Includefilter ;
      private bool Ddo_br_vital_measuredate_Filterisrange ;
      private bool Ddo_br_vital_measuredate_Includedatalist ;
      private bool Ddo_br_vital_temperature_Includesortasc ;
      private bool Ddo_br_vital_temperature_Includesortdsc ;
      private bool Ddo_br_vital_temperature_Includefilter ;
      private bool Ddo_br_vital_temperature_Filterisrange ;
      private bool Ddo_br_vital_temperature_Includedatalist ;
      private bool Ddo_br_vital_pulse_Includesortasc ;
      private bool Ddo_br_vital_pulse_Includesortdsc ;
      private bool Ddo_br_vital_pulse_Includefilter ;
      private bool Ddo_br_vital_pulse_Filterisrange ;
      private bool Ddo_br_vital_pulse_Includedatalist ;
      private bool Ddo_br_vital_respiration_Includesortasc ;
      private bool Ddo_br_vital_respiration_Includesortdsc ;
      private bool Ddo_br_vital_respiration_Includefilter ;
      private bool Ddo_br_vital_respiration_Filterisrange ;
      private bool Ddo_br_vital_respiration_Includedatalist ;
      private bool Ddo_br_vital_systolic_Includesortasc ;
      private bool Ddo_br_vital_systolic_Includesortdsc ;
      private bool Ddo_br_vital_systolic_Includefilter ;
      private bool Ddo_br_vital_systolic_Filterisrange ;
      private bool Ddo_br_vital_systolic_Includedatalist ;
      private bool Ddo_br_vital_diastolic_Includesortasc ;
      private bool Ddo_br_vital_diastolic_Includesortdsc ;
      private bool Ddo_br_vital_diastolic_Includefilter ;
      private bool Ddo_br_vital_diastolic_Filterisrange ;
      private bool Ddo_br_vital_diastolic_Includedatalist ;
      private bool Ddo_br_vital_height_Includesortasc ;
      private bool Ddo_br_vital_height_Includesortdsc ;
      private bool Ddo_br_vital_height_Includefilter ;
      private bool Ddo_br_vital_height_Filterisrange ;
      private bool Ddo_br_vital_height_Includedatalist ;
      private bool Ddo_br_vital_weight_Includesortasc ;
      private bool Ddo_br_vital_weight_Includesortdsc ;
      private bool Ddo_br_vital_weight_Includefilter ;
      private bool Ddo_br_vital_weight_Filterisrange ;
      private bool Ddo_br_vital_weight_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_31_Refreshing=false ;
      private bool n36BR_Information_PatientNo ;
      private bool n151BR_Vital_VitalID ;
      private bool n152BR_Vital_MeasureDate ;
      private bool n153BR_Vital_Temperature ;
      private bool n154BR_Vital_Pulse ;
      private bool n155BR_Vital_Respiration ;
      private bool n156BR_Vital_Systolic ;
      private bool n157BR_Vital_Diastolic ;
      private bool n158BR_Vital_Height ;
      private bool n159BR_Vital_Weight ;
      private bool gxdyncontrolsrefreshing ;
      private bool n85BR_Information_ID ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV77TempBoolean ;
      private bool GXt_boolean1 ;
      private bool AV71Display_IsBlob ;
      private bool AV72Update_IsBlob ;
      private bool AV74Delete_IsBlob ;
      private String AV25TFBR_Information_PatientNo ;
      private String AV26TFBR_Information_PatientNo_Sel ;
      private String AV19ddo_BR_VitalIDTitleControlIdToReplace ;
      private String AV23ddo_BR_EncounterIDTitleControlIdToReplace ;
      private String AV27ddo_BR_Information_PatientNoTitleControlIdToReplace ;
      private String AV31ddo_BR_Vital_VitalIDTitleControlIdToReplace ;
      private String AV37ddo_BR_Vital_MeasureDateTitleControlIdToReplace ;
      private String AV41ddo_BR_Vital_TemperatureTitleControlIdToReplace ;
      private String AV45ddo_BR_Vital_PulseTitleControlIdToReplace ;
      private String AV49ddo_BR_Vital_RespirationTitleControlIdToReplace ;
      private String AV53ddo_BR_Vital_SystolicTitleControlIdToReplace ;
      private String AV57ddo_BR_Vital_DiastolicTitleControlIdToReplace ;
      private String AV61ddo_BR_Vital_HeightTitleControlIdToReplace ;
      private String AV65ddo_BR_Vital_WeightTitleControlIdToReplace ;
      private String A36BR_Information_PatientNo ;
      private String AV104Display_GXI ;
      private String AV105Update_GXI ;
      private String AV106Delete_GXI ;
      private String lV84BR_VitalWWDS_5_Tfbr_information_patientno ;
      private String AV85BR_VitalWWDS_6_Tfbr_information_patientno_sel ;
      private String AV84BR_VitalWWDS_5_Tfbr_information_patientno ;
      private String AV71Display ;
      private String AV72Update ;
      private String AV74Delete ;
      private IGxSession AV15Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_vitalid ;
      private GXUserControl ucDdo_br_encounterid ;
      private GXUserControl ucDdo_br_information_patientno ;
      private GXUserControl ucDdo_br_vital_vitalid ;
      private GXUserControl ucDdo_br_vital_measuredate ;
      private GXUserControl ucDdo_br_vital_temperature ;
      private GXUserControl ucDdo_br_vital_pulse ;
      private GXUserControl ucDdo_br_vital_respiration ;
      private GXUserControl ucDdo_br_vital_systolic ;
      private GXUserControl ucDdo_br_vital_diastolic ;
      private GXUserControl ucDdo_br_vital_height ;
      private GXUserControl ucDdo_br_vital_weight ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] H005Y2_A85BR_Information_ID ;
      private bool[] H005Y2_n85BR_Information_ID ;
      private decimal[] H005Y2_A159BR_Vital_Weight ;
      private bool[] H005Y2_n159BR_Vital_Weight ;
      private decimal[] H005Y2_A158BR_Vital_Height ;
      private bool[] H005Y2_n158BR_Vital_Height ;
      private decimal[] H005Y2_A157BR_Vital_Diastolic ;
      private bool[] H005Y2_n157BR_Vital_Diastolic ;
      private decimal[] H005Y2_A156BR_Vital_Systolic ;
      private bool[] H005Y2_n156BR_Vital_Systolic ;
      private decimal[] H005Y2_A155BR_Vital_Respiration ;
      private bool[] H005Y2_n155BR_Vital_Respiration ;
      private decimal[] H005Y2_A154BR_Vital_Pulse ;
      private bool[] H005Y2_n154BR_Vital_Pulse ;
      private decimal[] H005Y2_A153BR_Vital_Temperature ;
      private bool[] H005Y2_n153BR_Vital_Temperature ;
      private DateTime[] H005Y2_A152BR_Vital_MeasureDate ;
      private bool[] H005Y2_n152BR_Vital_MeasureDate ;
      private long[] H005Y2_A151BR_Vital_VitalID ;
      private bool[] H005Y2_n151BR_Vital_VitalID ;
      private String[] H005Y2_A36BR_Information_PatientNo ;
      private bool[] H005Y2_n36BR_Information_PatientNo ;
      private long[] H005Y2_A19BR_EncounterID ;
      private long[] H005Y2_A150BR_VitalID ;
      private long[] H005Y3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV16BR_VitalIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV20BR_EncounterIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV24BR_Information_PatientNoTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV28BR_Vital_VitalIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV32BR_Vital_MeasureDateTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV38BR_Vital_TemperatureTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV42BR_Vital_PulseTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV46BR_Vital_RespirationTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV50BR_Vital_SystolicTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV54BR_Vital_DiastolicTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV58BR_Vital_HeightTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV62BR_Vital_WeightTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV11GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV12GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV66DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class br_vitalww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H005Y2( IGxContext context ,
                                             long AV80BR_VitalWWDS_1_Tfbr_vitalid ,
                                             long AV81BR_VitalWWDS_2_Tfbr_vitalid_to ,
                                             long AV82BR_VitalWWDS_3_Tfbr_encounterid ,
                                             long AV83BR_VitalWWDS_4_Tfbr_encounterid_to ,
                                             String AV85BR_VitalWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV84BR_VitalWWDS_5_Tfbr_information_patientno ,
                                             long AV86BR_VitalWWDS_7_Tfbr_vital_vitalid ,
                                             long AV87BR_VitalWWDS_8_Tfbr_vital_vitalid_to ,
                                             DateTime AV88BR_VitalWWDS_9_Tfbr_vital_measuredate ,
                                             DateTime AV89BR_VitalWWDS_10_Tfbr_vital_measuredate_to ,
                                             decimal AV90BR_VitalWWDS_11_Tfbr_vital_temperature ,
                                             decimal AV91BR_VitalWWDS_12_Tfbr_vital_temperature_to ,
                                             decimal AV92BR_VitalWWDS_13_Tfbr_vital_pulse ,
                                             decimal AV93BR_VitalWWDS_14_Tfbr_vital_pulse_to ,
                                             decimal AV94BR_VitalWWDS_15_Tfbr_vital_respiration ,
                                             decimal AV95BR_VitalWWDS_16_Tfbr_vital_respiration_to ,
                                             decimal AV96BR_VitalWWDS_17_Tfbr_vital_systolic ,
                                             decimal AV97BR_VitalWWDS_18_Tfbr_vital_systolic_to ,
                                             decimal AV98BR_VitalWWDS_19_Tfbr_vital_diastolic ,
                                             decimal AV99BR_VitalWWDS_20_Tfbr_vital_diastolic_to ,
                                             decimal AV100BR_VitalWWDS_21_Tfbr_vital_height ,
                                             decimal AV101BR_VitalWWDS_22_Tfbr_vital_height_to ,
                                             decimal AV102BR_VitalWWDS_23_Tfbr_vital_weight ,
                                             decimal AV103BR_VitalWWDS_24_Tfbr_vital_weight_to ,
                                             long A150BR_VitalID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             long A151BR_Vital_VitalID ,
                                             DateTime A152BR_Vital_MeasureDate ,
                                             decimal A153BR_Vital_Temperature ,
                                             decimal A154BR_Vital_Pulse ,
                                             decimal A155BR_Vital_Respiration ,
                                             decimal A156BR_Vital_Systolic ,
                                             decimal A157BR_Vital_Diastolic ,
                                             decimal A158BR_Vital_Height ,
                                             decimal A159BR_Vital_Weight ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [27] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " T2.[BR_Information_ID], T1.[BR_Vital_Weight], T1.[BR_Vital_Height], T1.[BR_Vital_Diastolic], T1.[BR_Vital_Systolic], T1.[BR_Vital_Respiration], T1.[BR_Vital_Pulse], T1.[BR_Vital_Temperature], T1.[BR_Vital_MeasureDate], T1.[BR_Vital_VitalID], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_VitalID]";
         sFromString = " FROM (([BR_Vital] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         sOrderString = "";
         if ( ! (0==AV80BR_VitalWWDS_1_Tfbr_vitalid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_VitalID] >= @AV80BR_VitalWWDS_1_Tfbr_vitalid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_VitalID] >= @AV80BR_VitalWWDS_1_Tfbr_vitalid)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ! (0==AV81BR_VitalWWDS_2_Tfbr_vitalid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_VitalID] <= @AV81BR_VitalWWDS_2_Tfbr_vitalid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_VitalID] <= @AV81BR_VitalWWDS_2_Tfbr_vitalid_to)";
            }
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV82BR_VitalWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV82BR_VitalWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV82BR_VitalWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (0==AV83BR_VitalWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV83BR_VitalWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV83BR_VitalWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_VitalWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_VitalWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV84BR_VitalWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV84BR_VitalWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_VitalWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV85BR_VitalWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV85BR_VitalWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (0==AV86BR_VitalWWDS_7_Tfbr_vital_vitalid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_VitalID] >= @AV86BR_VitalWWDS_7_Tfbr_vital_vitalid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_VitalID] >= @AV86BR_VitalWWDS_7_Tfbr_vital_vitalid)";
            }
         }
         else
         {
            GXv_int3[6] = 1;
         }
         if ( ! (0==AV87BR_VitalWWDS_8_Tfbr_vital_vitalid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_VitalID] <= @AV87BR_VitalWWDS_8_Tfbr_vital_vitalid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_VitalID] <= @AV87BR_VitalWWDS_8_Tfbr_vital_vitalid_to)";
            }
         }
         else
         {
            GXv_int3[7] = 1;
         }
         if ( ! (DateTime.MinValue==AV88BR_VitalWWDS_9_Tfbr_vital_measuredate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_MeasureDate] >= @AV88BR_VitalWWDS_9_Tfbr_vital_measuredate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_MeasureDate] >= @AV88BR_VitalWWDS_9_Tfbr_vital_measuredate)";
            }
         }
         else
         {
            GXv_int3[8] = 1;
         }
         if ( ! (DateTime.MinValue==AV89BR_VitalWWDS_10_Tfbr_vital_measuredate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_MeasureDate] <= @AV89BR_VitalWWDS_10_Tfbr_vital_measuredate_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_MeasureDate] <= @AV89BR_VitalWWDS_10_Tfbr_vital_measuredate_to)";
            }
         }
         else
         {
            GXv_int3[9] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV90BR_VitalWWDS_11_Tfbr_vital_temperature) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Temperature] >= @AV90BR_VitalWWDS_11_Tfbr_vital_temperature)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Temperature] >= @AV90BR_VitalWWDS_11_Tfbr_vital_temperature)";
            }
         }
         else
         {
            GXv_int3[10] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV91BR_VitalWWDS_12_Tfbr_vital_temperature_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Temperature] <= @AV91BR_VitalWWDS_12_Tfbr_vital_temperature_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Temperature] <= @AV91BR_VitalWWDS_12_Tfbr_vital_temperature_to)";
            }
         }
         else
         {
            GXv_int3[11] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV92BR_VitalWWDS_13_Tfbr_vital_pulse) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Pulse] >= @AV92BR_VitalWWDS_13_Tfbr_vital_pulse)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Pulse] >= @AV92BR_VitalWWDS_13_Tfbr_vital_pulse)";
            }
         }
         else
         {
            GXv_int3[12] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV93BR_VitalWWDS_14_Tfbr_vital_pulse_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Pulse] <= @AV93BR_VitalWWDS_14_Tfbr_vital_pulse_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Pulse] <= @AV93BR_VitalWWDS_14_Tfbr_vital_pulse_to)";
            }
         }
         else
         {
            GXv_int3[13] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV94BR_VitalWWDS_15_Tfbr_vital_respiration) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Respiration] >= @AV94BR_VitalWWDS_15_Tfbr_vital_respiration)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Respiration] >= @AV94BR_VitalWWDS_15_Tfbr_vital_respiration)";
            }
         }
         else
         {
            GXv_int3[14] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV95BR_VitalWWDS_16_Tfbr_vital_respiration_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Respiration] <= @AV95BR_VitalWWDS_16_Tfbr_vital_respiration_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Respiration] <= @AV95BR_VitalWWDS_16_Tfbr_vital_respiration_to)";
            }
         }
         else
         {
            GXv_int3[15] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV96BR_VitalWWDS_17_Tfbr_vital_systolic) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Systolic] >= @AV96BR_VitalWWDS_17_Tfbr_vital_systolic)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Systolic] >= @AV96BR_VitalWWDS_17_Tfbr_vital_systolic)";
            }
         }
         else
         {
            GXv_int3[16] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV97BR_VitalWWDS_18_Tfbr_vital_systolic_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Systolic] <= @AV97BR_VitalWWDS_18_Tfbr_vital_systolic_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Systolic] <= @AV97BR_VitalWWDS_18_Tfbr_vital_systolic_to)";
            }
         }
         else
         {
            GXv_int3[17] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV98BR_VitalWWDS_19_Tfbr_vital_diastolic) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Diastolic] >= @AV98BR_VitalWWDS_19_Tfbr_vital_diastolic)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Diastolic] >= @AV98BR_VitalWWDS_19_Tfbr_vital_diastolic)";
            }
         }
         else
         {
            GXv_int3[18] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV99BR_VitalWWDS_20_Tfbr_vital_diastolic_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Diastolic] <= @AV99BR_VitalWWDS_20_Tfbr_vital_diastolic_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Diastolic] <= @AV99BR_VitalWWDS_20_Tfbr_vital_diastolic_to)";
            }
         }
         else
         {
            GXv_int3[19] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV100BR_VitalWWDS_21_Tfbr_vital_height) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Height] >= @AV100BR_VitalWWDS_21_Tfbr_vital_height)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Height] >= @AV100BR_VitalWWDS_21_Tfbr_vital_height)";
            }
         }
         else
         {
            GXv_int3[20] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV101BR_VitalWWDS_22_Tfbr_vital_height_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Height] <= @AV101BR_VitalWWDS_22_Tfbr_vital_height_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Height] <= @AV101BR_VitalWWDS_22_Tfbr_vital_height_to)";
            }
         }
         else
         {
            GXv_int3[21] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV102BR_VitalWWDS_23_Tfbr_vital_weight) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Weight] >= @AV102BR_VitalWWDS_23_Tfbr_vital_weight)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Weight] >= @AV102BR_VitalWWDS_23_Tfbr_vital_weight)";
            }
         }
         else
         {
            GXv_int3[22] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV103BR_VitalWWDS_24_Tfbr_vital_weight_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Weight] <= @AV103BR_VitalWWDS_24_Tfbr_vital_weight_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Weight] <= @AV103BR_VitalWWDS_24_Tfbr_vital_weight_to)";
            }
         }
         else
         {
            GXv_int3[23] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_VitalID]";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_VitalID] DESC";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_EncounterID]";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_EncounterID] DESC";
         }
         else if ( ( AV13OrderedBy == 3 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T3.[BR_Information_PatientNo]";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T3.[BR_Information_PatientNo] DESC";
         }
         else if ( ( AV13OrderedBy == 4 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_VitalID]";
         }
         else if ( ( AV13OrderedBy == 4 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_VitalID] DESC";
         }
         else if ( ( AV13OrderedBy == 5 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_MeasureDate]";
         }
         else if ( ( AV13OrderedBy == 5 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_MeasureDate] DESC";
         }
         else if ( ( AV13OrderedBy == 6 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_Temperature]";
         }
         else if ( ( AV13OrderedBy == 6 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_Temperature] DESC";
         }
         else if ( ( AV13OrderedBy == 7 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_Pulse]";
         }
         else if ( ( AV13OrderedBy == 7 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_Pulse] DESC";
         }
         else if ( ( AV13OrderedBy == 8 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_Respiration]";
         }
         else if ( ( AV13OrderedBy == 8 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_Respiration] DESC";
         }
         else if ( ( AV13OrderedBy == 9 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_Systolic]";
         }
         else if ( ( AV13OrderedBy == 9 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_Systolic] DESC";
         }
         else if ( ( AV13OrderedBy == 10 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_Diastolic]";
         }
         else if ( ( AV13OrderedBy == 10 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_Diastolic] DESC";
         }
         else if ( ( AV13OrderedBy == 11 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_Height]";
         }
         else if ( ( AV13OrderedBy == 11 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_Height] DESC";
         }
         else if ( ( AV13OrderedBy == 12 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_Weight]";
         }
         else if ( ( AV13OrderedBy == 12 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_Weight] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_VitalID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H005Y3( IGxContext context ,
                                             long AV80BR_VitalWWDS_1_Tfbr_vitalid ,
                                             long AV81BR_VitalWWDS_2_Tfbr_vitalid_to ,
                                             long AV82BR_VitalWWDS_3_Tfbr_encounterid ,
                                             long AV83BR_VitalWWDS_4_Tfbr_encounterid_to ,
                                             String AV85BR_VitalWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV84BR_VitalWWDS_5_Tfbr_information_patientno ,
                                             long AV86BR_VitalWWDS_7_Tfbr_vital_vitalid ,
                                             long AV87BR_VitalWWDS_8_Tfbr_vital_vitalid_to ,
                                             DateTime AV88BR_VitalWWDS_9_Tfbr_vital_measuredate ,
                                             DateTime AV89BR_VitalWWDS_10_Tfbr_vital_measuredate_to ,
                                             decimal AV90BR_VitalWWDS_11_Tfbr_vital_temperature ,
                                             decimal AV91BR_VitalWWDS_12_Tfbr_vital_temperature_to ,
                                             decimal AV92BR_VitalWWDS_13_Tfbr_vital_pulse ,
                                             decimal AV93BR_VitalWWDS_14_Tfbr_vital_pulse_to ,
                                             decimal AV94BR_VitalWWDS_15_Tfbr_vital_respiration ,
                                             decimal AV95BR_VitalWWDS_16_Tfbr_vital_respiration_to ,
                                             decimal AV96BR_VitalWWDS_17_Tfbr_vital_systolic ,
                                             decimal AV97BR_VitalWWDS_18_Tfbr_vital_systolic_to ,
                                             decimal AV98BR_VitalWWDS_19_Tfbr_vital_diastolic ,
                                             decimal AV99BR_VitalWWDS_20_Tfbr_vital_diastolic_to ,
                                             decimal AV100BR_VitalWWDS_21_Tfbr_vital_height ,
                                             decimal AV101BR_VitalWWDS_22_Tfbr_vital_height_to ,
                                             decimal AV102BR_VitalWWDS_23_Tfbr_vital_weight ,
                                             decimal AV103BR_VitalWWDS_24_Tfbr_vital_weight_to ,
                                             long A150BR_VitalID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             long A151BR_Vital_VitalID ,
                                             DateTime A152BR_Vital_MeasureDate ,
                                             decimal A153BR_Vital_Temperature ,
                                             decimal A154BR_Vital_Pulse ,
                                             decimal A155BR_Vital_Respiration ,
                                             decimal A156BR_Vital_Systolic ,
                                             decimal A157BR_Vital_Diastolic ,
                                             decimal A158BR_Vital_Height ,
                                             decimal A159BR_Vital_Weight ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [24] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM (([BR_Vital] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV80BR_VitalWWDS_1_Tfbr_vitalid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_VitalID] >= @AV80BR_VitalWWDS_1_Tfbr_vitalid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_VitalID] >= @AV80BR_VitalWWDS_1_Tfbr_vitalid)";
            }
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ! (0==AV81BR_VitalWWDS_2_Tfbr_vitalid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_VitalID] <= @AV81BR_VitalWWDS_2_Tfbr_vitalid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_VitalID] <= @AV81BR_VitalWWDS_2_Tfbr_vitalid_to)";
            }
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( ! (0==AV82BR_VitalWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV82BR_VitalWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV82BR_VitalWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! (0==AV83BR_VitalWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV83BR_VitalWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV83BR_VitalWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_VitalWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_VitalWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV84BR_VitalWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV84BR_VitalWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_VitalWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV85BR_VitalWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV85BR_VitalWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( ! (0==AV86BR_VitalWWDS_7_Tfbr_vital_vitalid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_VitalID] >= @AV86BR_VitalWWDS_7_Tfbr_vital_vitalid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_VitalID] >= @AV86BR_VitalWWDS_7_Tfbr_vital_vitalid)";
            }
         }
         else
         {
            GXv_int5[6] = 1;
         }
         if ( ! (0==AV87BR_VitalWWDS_8_Tfbr_vital_vitalid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_VitalID] <= @AV87BR_VitalWWDS_8_Tfbr_vital_vitalid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_VitalID] <= @AV87BR_VitalWWDS_8_Tfbr_vital_vitalid_to)";
            }
         }
         else
         {
            GXv_int5[7] = 1;
         }
         if ( ! (DateTime.MinValue==AV88BR_VitalWWDS_9_Tfbr_vital_measuredate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_MeasureDate] >= @AV88BR_VitalWWDS_9_Tfbr_vital_measuredate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_MeasureDate] >= @AV88BR_VitalWWDS_9_Tfbr_vital_measuredate)";
            }
         }
         else
         {
            GXv_int5[8] = 1;
         }
         if ( ! (DateTime.MinValue==AV89BR_VitalWWDS_10_Tfbr_vital_measuredate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_MeasureDate] <= @AV89BR_VitalWWDS_10_Tfbr_vital_measuredate_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_MeasureDate] <= @AV89BR_VitalWWDS_10_Tfbr_vital_measuredate_to)";
            }
         }
         else
         {
            GXv_int5[9] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV90BR_VitalWWDS_11_Tfbr_vital_temperature) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Temperature] >= @AV90BR_VitalWWDS_11_Tfbr_vital_temperature)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Temperature] >= @AV90BR_VitalWWDS_11_Tfbr_vital_temperature)";
            }
         }
         else
         {
            GXv_int5[10] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV91BR_VitalWWDS_12_Tfbr_vital_temperature_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Temperature] <= @AV91BR_VitalWWDS_12_Tfbr_vital_temperature_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Temperature] <= @AV91BR_VitalWWDS_12_Tfbr_vital_temperature_to)";
            }
         }
         else
         {
            GXv_int5[11] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV92BR_VitalWWDS_13_Tfbr_vital_pulse) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Pulse] >= @AV92BR_VitalWWDS_13_Tfbr_vital_pulse)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Pulse] >= @AV92BR_VitalWWDS_13_Tfbr_vital_pulse)";
            }
         }
         else
         {
            GXv_int5[12] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV93BR_VitalWWDS_14_Tfbr_vital_pulse_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Pulse] <= @AV93BR_VitalWWDS_14_Tfbr_vital_pulse_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Pulse] <= @AV93BR_VitalWWDS_14_Tfbr_vital_pulse_to)";
            }
         }
         else
         {
            GXv_int5[13] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV94BR_VitalWWDS_15_Tfbr_vital_respiration) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Respiration] >= @AV94BR_VitalWWDS_15_Tfbr_vital_respiration)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Respiration] >= @AV94BR_VitalWWDS_15_Tfbr_vital_respiration)";
            }
         }
         else
         {
            GXv_int5[14] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV95BR_VitalWWDS_16_Tfbr_vital_respiration_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Respiration] <= @AV95BR_VitalWWDS_16_Tfbr_vital_respiration_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Respiration] <= @AV95BR_VitalWWDS_16_Tfbr_vital_respiration_to)";
            }
         }
         else
         {
            GXv_int5[15] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV96BR_VitalWWDS_17_Tfbr_vital_systolic) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Systolic] >= @AV96BR_VitalWWDS_17_Tfbr_vital_systolic)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Systolic] >= @AV96BR_VitalWWDS_17_Tfbr_vital_systolic)";
            }
         }
         else
         {
            GXv_int5[16] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV97BR_VitalWWDS_18_Tfbr_vital_systolic_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Systolic] <= @AV97BR_VitalWWDS_18_Tfbr_vital_systolic_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Systolic] <= @AV97BR_VitalWWDS_18_Tfbr_vital_systolic_to)";
            }
         }
         else
         {
            GXv_int5[17] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV98BR_VitalWWDS_19_Tfbr_vital_diastolic) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Diastolic] >= @AV98BR_VitalWWDS_19_Tfbr_vital_diastolic)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Diastolic] >= @AV98BR_VitalWWDS_19_Tfbr_vital_diastolic)";
            }
         }
         else
         {
            GXv_int5[18] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV99BR_VitalWWDS_20_Tfbr_vital_diastolic_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Diastolic] <= @AV99BR_VitalWWDS_20_Tfbr_vital_diastolic_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Diastolic] <= @AV99BR_VitalWWDS_20_Tfbr_vital_diastolic_to)";
            }
         }
         else
         {
            GXv_int5[19] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV100BR_VitalWWDS_21_Tfbr_vital_height) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Height] >= @AV100BR_VitalWWDS_21_Tfbr_vital_height)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Height] >= @AV100BR_VitalWWDS_21_Tfbr_vital_height)";
            }
         }
         else
         {
            GXv_int5[20] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV101BR_VitalWWDS_22_Tfbr_vital_height_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Height] <= @AV101BR_VitalWWDS_22_Tfbr_vital_height_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Height] <= @AV101BR_VitalWWDS_22_Tfbr_vital_height_to)";
            }
         }
         else
         {
            GXv_int5[21] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV102BR_VitalWWDS_23_Tfbr_vital_weight) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Weight] >= @AV102BR_VitalWWDS_23_Tfbr_vital_weight)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Weight] >= @AV102BR_VitalWWDS_23_Tfbr_vital_weight)";
            }
         }
         else
         {
            GXv_int5[22] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV103BR_VitalWWDS_24_Tfbr_vital_weight_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Weight] <= @AV103BR_VitalWWDS_24_Tfbr_vital_weight_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Weight] <= @AV103BR_VitalWWDS_24_Tfbr_vital_weight_to)";
            }
         }
         else
         {
            GXv_int5[23] = 1;
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
         else if ( ( AV13OrderedBy == 8 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 8 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 9 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 9 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 10 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 10 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 11 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 11 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 12 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 12 ) && ( AV14OrderedDsc ) )
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
                     return conditional_H005Y2(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (DateTime)dynConstraints[8] , (DateTime)dynConstraints[9] , (decimal)dynConstraints[10] , (decimal)dynConstraints[11] , (decimal)dynConstraints[12] , (decimal)dynConstraints[13] , (decimal)dynConstraints[14] , (decimal)dynConstraints[15] , (decimal)dynConstraints[16] , (decimal)dynConstraints[17] , (decimal)dynConstraints[18] , (decimal)dynConstraints[19] , (decimal)dynConstraints[20] , (decimal)dynConstraints[21] , (decimal)dynConstraints[22] , (decimal)dynConstraints[23] , (long)dynConstraints[24] , (long)dynConstraints[25] , (String)dynConstraints[26] , (long)dynConstraints[27] , (DateTime)dynConstraints[28] , (decimal)dynConstraints[29] , (decimal)dynConstraints[30] , (decimal)dynConstraints[31] , (decimal)dynConstraints[32] , (decimal)dynConstraints[33] , (decimal)dynConstraints[34] , (decimal)dynConstraints[35] , (short)dynConstraints[36] , (bool)dynConstraints[37] );
               case 1 :
                     return conditional_H005Y3(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (DateTime)dynConstraints[8] , (DateTime)dynConstraints[9] , (decimal)dynConstraints[10] , (decimal)dynConstraints[11] , (decimal)dynConstraints[12] , (decimal)dynConstraints[13] , (decimal)dynConstraints[14] , (decimal)dynConstraints[15] , (decimal)dynConstraints[16] , (decimal)dynConstraints[17] , (decimal)dynConstraints[18] , (decimal)dynConstraints[19] , (decimal)dynConstraints[20] , (decimal)dynConstraints[21] , (decimal)dynConstraints[22] , (decimal)dynConstraints[23] , (long)dynConstraints[24] , (long)dynConstraints[25] , (String)dynConstraints[26] , (long)dynConstraints[27] , (DateTime)dynConstraints[28] , (decimal)dynConstraints[29] , (decimal)dynConstraints[30] , (decimal)dynConstraints[31] , (decimal)dynConstraints[32] , (decimal)dynConstraints[33] , (decimal)dynConstraints[34] , (decimal)dynConstraints[35] , (short)dynConstraints[36] , (bool)dynConstraints[37] );
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
          Object[] prmH005Y2 ;
          prmH005Y2 = new Object[] {
          new Object[] {"@AV80BR_VitalWWDS_1_Tfbr_vitalid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV81BR_VitalWWDS_2_Tfbr_vitalid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV82BR_VitalWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV83BR_VitalWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV84BR_VitalWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV85BR_VitalWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV86BR_VitalWWDS_7_Tfbr_vital_vitalid",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV87BR_VitalWWDS_8_Tfbr_vital_vitalid_to",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV88BR_VitalWWDS_9_Tfbr_vital_measuredate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV89BR_VitalWWDS_10_Tfbr_vital_measuredate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV90BR_VitalWWDS_11_Tfbr_vital_temperature",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV91BR_VitalWWDS_12_Tfbr_vital_temperature_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV92BR_VitalWWDS_13_Tfbr_vital_pulse",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV93BR_VitalWWDS_14_Tfbr_vital_pulse_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV94BR_VitalWWDS_15_Tfbr_vital_respiration",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV95BR_VitalWWDS_16_Tfbr_vital_respiration_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV96BR_VitalWWDS_17_Tfbr_vital_systolic",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV97BR_VitalWWDS_18_Tfbr_vital_systolic_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV98BR_VitalWWDS_19_Tfbr_vital_diastolic",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV99BR_VitalWWDS_20_Tfbr_vital_diastolic_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV100BR_VitalWWDS_21_Tfbr_vital_height",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV101BR_VitalWWDS_22_Tfbr_vital_height_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV102BR_VitalWWDS_23_Tfbr_vital_weight",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV103BR_VitalWWDS_24_Tfbr_vital_weight_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH005Y3 ;
          prmH005Y3 = new Object[] {
          new Object[] {"@AV80BR_VitalWWDS_1_Tfbr_vitalid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV81BR_VitalWWDS_2_Tfbr_vitalid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV82BR_VitalWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV83BR_VitalWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV84BR_VitalWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV85BR_VitalWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV86BR_VitalWWDS_7_Tfbr_vital_vitalid",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV87BR_VitalWWDS_8_Tfbr_vital_vitalid_to",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV88BR_VitalWWDS_9_Tfbr_vital_measuredate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV89BR_VitalWWDS_10_Tfbr_vital_measuredate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV90BR_VitalWWDS_11_Tfbr_vital_temperature",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV91BR_VitalWWDS_12_Tfbr_vital_temperature_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV92BR_VitalWWDS_13_Tfbr_vital_pulse",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV93BR_VitalWWDS_14_Tfbr_vital_pulse_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV94BR_VitalWWDS_15_Tfbr_vital_respiration",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV95BR_VitalWWDS_16_Tfbr_vital_respiration_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV96BR_VitalWWDS_17_Tfbr_vital_systolic",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV97BR_VitalWWDS_18_Tfbr_vital_systolic_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV98BR_VitalWWDS_19_Tfbr_vital_diastolic",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV99BR_VitalWWDS_20_Tfbr_vital_diastolic_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV100BR_VitalWWDS_21_Tfbr_vital_height",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV101BR_VitalWWDS_22_Tfbr_vital_height_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV102BR_VitalWWDS_23_Tfbr_vital_weight",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV103BR_VitalWWDS_24_Tfbr_vital_weight_to",SqlDbType.Decimal,15,5}
          } ;
          def= new CursorDef[] {
              new CursorDef("H005Y2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005Y2,11,0,true,false )
             ,new CursorDef("H005Y3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005Y3,1,0,true,false )
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
                ((decimal[]) buf[2])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((decimal[]) buf[4])[0] = rslt.getDecimal(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((decimal[]) buf[6])[0] = rslt.getDecimal(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((decimal[]) buf[8])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((decimal[]) buf[10])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((decimal[]) buf[12])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((decimal[]) buf[14])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((DateTime[]) buf[16])[0] = rslt.getGXDate(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((long[]) buf[18])[0] = rslt.getLong(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((String[]) buf[20])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((long[]) buf[22])[0] = rslt.getLong(12) ;
                ((long[]) buf[23])[0] = rslt.getLong(13) ;
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
                   stmt.SetParameter(sIdx, (long)parms[27]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[28]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[29]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[30]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[31]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[32]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[33]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[34]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[35]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[36]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[37]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[38]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[39]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[40]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[41]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[42]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[43]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[44]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[45]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[46]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[47]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[48]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[49]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[50]);
                }
                if ( (short)parms[24] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[51]);
                }
                if ( (short)parms[25] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[52]);
                }
                if ( (short)parms[26] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[53]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[24]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[25]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[26]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[27]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[28]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[29]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[30]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[31]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[32]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[33]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[34]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[35]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[36]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[37]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[38]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[39]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[40]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[41]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[42]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[43]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[44]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[45]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[46]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[47]);
                }
                return;
       }
    }

 }

}
