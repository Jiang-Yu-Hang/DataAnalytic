/*
               File: BR_MedicationPromptItl
        Description: Data Mgmt Portal -RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:47:24.24
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
   public class br_medicationpromptitl : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public br_medicationpromptitl( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_medicationpromptitl( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out long aP0_InOutBR_MedicationID ,
                           out String aP1_InOutBR_Medication_RXName ,
                           out decimal aP2_InOutBR_Medication_RXDose ,
                           out String aP3_InOutBR_Medication_RXUnit ,
                           out String aP4_InOutBR_Medication_RXName ,
                           out decimal aP5_InOutBR_Medication_RXDose ,
                           out String aP6_InOutBR_Medication_RXUnit )
      {
         this.AV8InOutBR_MedicationID = 0 ;
         this.AV65InOutBR_Medication_RXName = "" ;
         this.AV66InOutBR_Medication_RXDose = 0 ;
         this.AV67InOutBR_Medication_RXUnit = "" ;
         this.AV65InOutBR_Medication_RXName = "" ;
         this.AV66InOutBR_Medication_RXDose = 0 ;
         this.AV67InOutBR_Medication_RXUnit = "" ;
         executePrivate();
         aP0_InOutBR_MedicationID=this.AV8InOutBR_MedicationID;
         aP1_InOutBR_Medication_RXName=this.AV65InOutBR_Medication_RXName;
         aP2_InOutBR_Medication_RXDose=this.AV66InOutBR_Medication_RXDose;
         aP3_InOutBR_Medication_RXUnit=this.AV67InOutBR_Medication_RXUnit;
         aP4_InOutBR_Medication_RXName=this.AV65InOutBR_Medication_RXName;
         aP5_InOutBR_Medication_RXDose=this.AV66InOutBR_Medication_RXDose;
         aP6_InOutBR_Medication_RXUnit=this.AV67InOutBR_Medication_RXUnit;
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
               nRC_GXsfl_32 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_32_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_32_idx = GetNextPar( );
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
               AV62BR_Medication_RXName = GetNextPar( );
               AV10OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV11OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV70TFBR_Medication_RXUnit = GetNextPar( );
               AV71TFBR_Medication_RXUnit_Sel = GetNextPar( );
               AV21ddo_BR_Medication_RXNameTitleControlIdToReplace = GetNextPar( );
               AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace = GetNextPar( );
               AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace = GetNextPar( );
               AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace = GetNextPar( );
               AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace = GetNextPar( );
               AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace = GetNextPar( );
               AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace = GetNextPar( );
               AV74Pgmname = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV62BR_Medication_RXName, AV10OrderedBy, AV11OrderedDsc, AV70TFBR_Medication_RXUnit, AV71TFBR_Medication_RXUnit_Sel, AV21ddo_BR_Medication_RXNameTitleControlIdToReplace, AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace, AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace, AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace, AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace, AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace, AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace, AV74Pgmname) ;
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
               AV8InOutBR_MedicationID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_MedicationID), 18, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV65InOutBR_Medication_RXName = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV65InOutBR_Medication_RXName", AV65InOutBR_Medication_RXName);
                  AV66InOutBR_Medication_RXDose = NumberUtil.Val( GetNextPar( ), ".");
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV66InOutBR_Medication_RXDose", StringUtil.LTrim( StringUtil.Str( AV66InOutBR_Medication_RXDose, 15, 5)));
                  AV67InOutBR_Medication_RXUnit = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV67InOutBR_Medication_RXUnit", AV67InOutBR_Medication_RXUnit);
                  AV65InOutBR_Medication_RXName = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV65InOutBR_Medication_RXName", AV65InOutBR_Medication_RXName);
                  AV66InOutBR_Medication_RXDose = NumberUtil.Val( GetNextPar( ), ".");
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV66InOutBR_Medication_RXDose", StringUtil.LTrim( StringUtil.Str( AV66InOutBR_Medication_RXDose, 15, 5)));
                  AV67InOutBR_Medication_RXUnit = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV67InOutBR_Medication_RXUnit", AV67InOutBR_Medication_RXUnit);
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
            PA8G2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV74Pgmname = "BR_MedicationPromptItl";
               context.Gx_err = 0;
               WS8G2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE8G2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202279472446", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_medicationpromptitl.aspx") + "?" + UrlEncode("" +AV8InOutBR_MedicationID) + "," + UrlEncode(StringUtil.RTrim(AV65InOutBR_Medication_RXName)) + "," + UrlEncode(StringUtil.Str(AV66InOutBR_Medication_RXDose,15,5)) + "," + UrlEncode(StringUtil.RTrim(AV67InOutBR_Medication_RXUnit)) + "," + UrlEncode(StringUtil.RTrim(AV65InOutBR_Medication_RXName)) + "," + UrlEncode(StringUtil.Str(AV66InOutBR_Medication_RXDose,15,5)) + "," + UrlEncode(StringUtil.RTrim(AV67InOutBR_Medication_RXUnit))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vBR_MEDICATION_RXNAME", AV62BR_Medication_RXName);
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10OrderedBy), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV11OrderedDsc));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_RXUNIT", AV70TFBR_Medication_RXUnit);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_RXUNIT_SEL", AV71TFBR_Medication_RXUnit_Sel);
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_32", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_32), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV58GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV60GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV59GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV56DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV56DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_RXNAMETITLEFILTERDATA", AV20BR_Medication_RXNameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_RXNAMETITLEFILTERDATA", AV20BR_Medication_RXNameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_RXDOSETITLEFILTERDATA", AV26BR_Medication_RXDoseTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_RXDOSETITLEFILTERDATA", AV26BR_Medication_RXDoseTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_RXUNITTITLEFILTERDATA", AV28BR_Medication_RXUnitTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_RXUNITTITLEFILTERDATA", AV28BR_Medication_RXUnitTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA", AV30BR_Medication_RXFrequencyTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA", AV30BR_Medication_RXFrequencyTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA", AV32BR_Medication_RXQuantityTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA", AV32BR_Medication_RXQuantityTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA", AV34BR_Medication_RXDaysSupplyTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA", AV34BR_Medication_RXDaysSupplyTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA", AV42BR_Medication_AdmitStartDateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA", AV42BR_Medication_AdmitStartDateTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV74Pgmname));
         GxWebStd.gx_hidden_field( context, "vINOUTBR_MEDICATIONID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8InOutBR_MedicationID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINOUTBR_MEDICATION_RXNAME", AV65InOutBR_Medication_RXName);
         GxWebStd.gx_hidden_field( context, "vINOUTBR_MEDICATION_RXDOSE", StringUtil.LTrim( StringUtil.NToC( AV66InOutBR_Medication_RXDose, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINOUTBR_MEDICATION_RXUNIT", AV67InOutBR_Medication_RXUnit);
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Caption", StringUtil.RTrim( Ddo_br_medication_rxname_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Tooltip", StringUtil.RTrim( Ddo_br_medication_rxname_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Cls", StringUtil.RTrim( Ddo_br_medication_rxname_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_rxname_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_rxname_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_rxname_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_rxname_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_rxname_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_rxname_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_rxname_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Sortasc", StringUtil.RTrim( Ddo_br_medication_rxname_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Sortdsc", StringUtil.RTrim( Ddo_br_medication_rxname_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_rxname_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Caption", StringUtil.RTrim( Ddo_br_medication_rxdose_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Tooltip", StringUtil.RTrim( Ddo_br_medication_rxdose_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Cls", StringUtil.RTrim( Ddo_br_medication_rxdose_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_rxdose_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_rxdose_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_rxdose_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_rxdose_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_rxdose_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_rxdose_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_rxdose_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Sortasc", StringUtil.RTrim( Ddo_br_medication_rxdose_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Sortdsc", StringUtil.RTrim( Ddo_br_medication_rxdose_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_rxdose_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Caption", StringUtil.RTrim( Ddo_br_medication_rxunit_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Tooltip", StringUtil.RTrim( Ddo_br_medication_rxunit_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Cls", StringUtil.RTrim( Ddo_br_medication_rxunit_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_rxunit_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_rxunit_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_rxunit_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_rxunit_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_rxunit_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_rxunit_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Filtertype", StringUtil.RTrim( Ddo_br_medication_rxunit_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Filterisrange", StringUtil.BoolToStr( Ddo_br_medication_rxunit_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_rxunit_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Datalisttype", StringUtil.RTrim( Ddo_br_medication_rxunit_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Datalistproc", StringUtil.RTrim( Ddo_br_medication_rxunit_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_medication_rxunit_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Sortasc", StringUtil.RTrim( Ddo_br_medication_rxunit_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Sortdsc", StringUtil.RTrim( Ddo_br_medication_rxunit_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Loadingdata", StringUtil.RTrim( Ddo_br_medication_rxunit_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Cleanfilter", StringUtil.RTrim( Ddo_br_medication_rxunit_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Noresultsfound", StringUtil.RTrim( Ddo_br_medication_rxunit_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_rxunit_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Caption", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Tooltip", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Cls", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_rxfrequency_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_rxfrequency_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_rxfrequency_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_rxfrequency_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Sortasc", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Sortdsc", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Caption", StringUtil.RTrim( Ddo_br_medication_rxquantity_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Tooltip", StringUtil.RTrim( Ddo_br_medication_rxquantity_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Cls", StringUtil.RTrim( Ddo_br_medication_rxquantity_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_rxquantity_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_rxquantity_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_rxquantity_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_rxquantity_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_rxquantity_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_rxquantity_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_rxquantity_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Sortasc", StringUtil.RTrim( Ddo_br_medication_rxquantity_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Sortdsc", StringUtil.RTrim( Ddo_br_medication_rxquantity_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_rxquantity_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Caption", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Tooltip", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Cls", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_rxdayssupply_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_rxdayssupply_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_rxdayssupply_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_rxdayssupply_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Sortasc", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Sortdsc", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Caption", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Tooltip", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Cls", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_admitstartdate_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_admitstartdate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_admitstartdate_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_admitstartdate_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Sortasc", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Sortdsc", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxname_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxdose_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxunit_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_rxunit_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medication_rxunit_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxquantity_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxname_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxdose_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxunit_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_rxunit_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medication_rxunit_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxquantity_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Activeeventkey));
      }

      protected void RenderHtmlCloseForm8G2( )
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
         return "BR_MedicationPromptItl" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal -RAAP" ;
      }

      protected void WB8G0( )
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
            GxWebStd.gx_div_start( context, divUnnamedtabler_medication_rxname_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblFiltertextbr_medication_rxname_Internalname, "药物名称", "", "", lblFiltertextbr_medication_rxname_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicationPromptItl.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_medication_rxname_Internalname, "BR_Medication_RXName", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_32_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_medication_rxname_Internalname, AV62BR_Medication_RXName, StringUtil.RTrim( context.localUtil.Format( AV62BR_Medication_RXName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_medication_rxname_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_medication_rxname_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicationPromptItl.htm");
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
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"32\">") ;
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "药物治疗主键") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "就诊信息主键") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Medication_RXName_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Medication_RXName_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Medication_RXName_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Medication_RXDose_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Medication_RXDose_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Medication_RXDose_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Medication_RXUnit_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Medication_RXUnit_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Medication_RXUnit_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Medication_RXFrequency_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Medication_RXFrequency_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Medication_RXFrequency_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Medication_RXQuantity_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Medication_RXQuantity_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Medication_RXQuantity_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Medication_RXDaysSupply_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Medication_RXDaysSupply_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Medication_RXDaysSupply_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Medication_AdmitStartDate_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Medication_AdmitStartDate_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Medication_AdmitStartDate_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV61Select));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavSelect_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A119BR_MedicationID), 18, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A121BR_Medication_RXName);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Medication_RXName_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Medication_RXName_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A124BR_Medication_RXDose, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Medication_RXDose_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Medication_RXDose_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A125BR_Medication_RXUnit);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Medication_RXUnit_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Medication_RXUnit_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A126BR_Medication_RXFrequency);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Medication_RXFrequency_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Medication_RXFrequency_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A127BR_Medication_RXQuantity);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Medication_RXQuantity_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Medication_RXQuantity_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A128BR_Medication_RXDaysSupply, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Medication_RXDaysSupply_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Medication_RXDaysSupply_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A132BR_Medication_AdmitStartDate, "9999/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Medication_AdmitStartDate_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Medication_AdmitStartDate_Titleformat), 4, 0, ".", "")));
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
         if ( wbEnd == 32 )
         {
            wbEnd = 0;
            nRC_GXsfl_32 = (short)(nGXsfl_32_idx-1);
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV58GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV60GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV59GridPageSize);
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
            ucDdo_br_medication_rxname.SetProperty("Caption", Ddo_br_medication_rxname_Caption);
            ucDdo_br_medication_rxname.SetProperty("Tooltip", Ddo_br_medication_rxname_Tooltip);
            ucDdo_br_medication_rxname.SetProperty("Cls", Ddo_br_medication_rxname_Cls);
            ucDdo_br_medication_rxname.SetProperty("DropDownOptionsType", Ddo_br_medication_rxname_Dropdownoptionstype);
            ucDdo_br_medication_rxname.SetProperty("IncludeSortASC", Ddo_br_medication_rxname_Includesortasc);
            ucDdo_br_medication_rxname.SetProperty("IncludeSortDSC", Ddo_br_medication_rxname_Includesortdsc);
            ucDdo_br_medication_rxname.SetProperty("IncludeFilter", Ddo_br_medication_rxname_Includefilter);
            ucDdo_br_medication_rxname.SetProperty("IncludeDataList", Ddo_br_medication_rxname_Includedatalist);
            ucDdo_br_medication_rxname.SetProperty("SortASC", Ddo_br_medication_rxname_Sortasc);
            ucDdo_br_medication_rxname.SetProperty("SortDSC", Ddo_br_medication_rxname_Sortdsc);
            ucDdo_br_medication_rxname.SetProperty("SearchButtonText", Ddo_br_medication_rxname_Searchbuttontext);
            ucDdo_br_medication_rxname.SetProperty("DropDownOptionsTitleSettingsIcons", AV56DDO_TitleSettingsIcons);
            ucDdo_br_medication_rxname.SetProperty("DropDownOptionsData", AV20BR_Medication_RXNameTitleFilterData);
            ucDdo_br_medication_rxname.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_rxname_Internalname, "DDO_BR_MEDICATION_RXNAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'" + sGXsfl_32_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Internalname, AV21ddo_BR_Medication_RXNameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", 0, edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicationPromptItl.htm");
            /* User Defined Control */
            ucDdo_br_medication_rxdose.SetProperty("Caption", Ddo_br_medication_rxdose_Caption);
            ucDdo_br_medication_rxdose.SetProperty("Tooltip", Ddo_br_medication_rxdose_Tooltip);
            ucDdo_br_medication_rxdose.SetProperty("Cls", Ddo_br_medication_rxdose_Cls);
            ucDdo_br_medication_rxdose.SetProperty("DropDownOptionsType", Ddo_br_medication_rxdose_Dropdownoptionstype);
            ucDdo_br_medication_rxdose.SetProperty("IncludeSortASC", Ddo_br_medication_rxdose_Includesortasc);
            ucDdo_br_medication_rxdose.SetProperty("IncludeSortDSC", Ddo_br_medication_rxdose_Includesortdsc);
            ucDdo_br_medication_rxdose.SetProperty("IncludeFilter", Ddo_br_medication_rxdose_Includefilter);
            ucDdo_br_medication_rxdose.SetProperty("IncludeDataList", Ddo_br_medication_rxdose_Includedatalist);
            ucDdo_br_medication_rxdose.SetProperty("SortASC", Ddo_br_medication_rxdose_Sortasc);
            ucDdo_br_medication_rxdose.SetProperty("SortDSC", Ddo_br_medication_rxdose_Sortdsc);
            ucDdo_br_medication_rxdose.SetProperty("SearchButtonText", Ddo_br_medication_rxdose_Searchbuttontext);
            ucDdo_br_medication_rxdose.SetProperty("DropDownOptionsTitleSettingsIcons", AV56DDO_TitleSettingsIcons);
            ucDdo_br_medication_rxdose.SetProperty("DropDownOptionsData", AV26BR_Medication_RXDoseTitleFilterData);
            ucDdo_br_medication_rxdose.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_rxdose_Internalname, "DDO_BR_MEDICATION_RXDOSEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'" + sGXsfl_32_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Internalname, AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", 0, edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicationPromptItl.htm");
            /* User Defined Control */
            ucDdo_br_medication_rxunit.SetProperty("Caption", Ddo_br_medication_rxunit_Caption);
            ucDdo_br_medication_rxunit.SetProperty("Tooltip", Ddo_br_medication_rxunit_Tooltip);
            ucDdo_br_medication_rxunit.SetProperty("Cls", Ddo_br_medication_rxunit_Cls);
            ucDdo_br_medication_rxunit.SetProperty("DropDownOptionsType", Ddo_br_medication_rxunit_Dropdownoptionstype);
            ucDdo_br_medication_rxunit.SetProperty("IncludeSortASC", Ddo_br_medication_rxunit_Includesortasc);
            ucDdo_br_medication_rxunit.SetProperty("IncludeSortDSC", Ddo_br_medication_rxunit_Includesortdsc);
            ucDdo_br_medication_rxunit.SetProperty("IncludeFilter", Ddo_br_medication_rxunit_Includefilter);
            ucDdo_br_medication_rxunit.SetProperty("FilterType", Ddo_br_medication_rxunit_Filtertype);
            ucDdo_br_medication_rxunit.SetProperty("FilterIsRange", Ddo_br_medication_rxunit_Filterisrange);
            ucDdo_br_medication_rxunit.SetProperty("IncludeDataList", Ddo_br_medication_rxunit_Includedatalist);
            ucDdo_br_medication_rxunit.SetProperty("DataListType", Ddo_br_medication_rxunit_Datalisttype);
            ucDdo_br_medication_rxunit.SetProperty("DataListProc", Ddo_br_medication_rxunit_Datalistproc);
            ucDdo_br_medication_rxunit.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_medication_rxunit_Datalistupdateminimumcharacters);
            ucDdo_br_medication_rxunit.SetProperty("SortASC", Ddo_br_medication_rxunit_Sortasc);
            ucDdo_br_medication_rxunit.SetProperty("SortDSC", Ddo_br_medication_rxunit_Sortdsc);
            ucDdo_br_medication_rxunit.SetProperty("LoadingData", Ddo_br_medication_rxunit_Loadingdata);
            ucDdo_br_medication_rxunit.SetProperty("CleanFilter", Ddo_br_medication_rxunit_Cleanfilter);
            ucDdo_br_medication_rxunit.SetProperty("NoResultsFound", Ddo_br_medication_rxunit_Noresultsfound);
            ucDdo_br_medication_rxunit.SetProperty("SearchButtonText", Ddo_br_medication_rxunit_Searchbuttontext);
            ucDdo_br_medication_rxunit.SetProperty("DropDownOptionsTitleSettingsIcons", AV56DDO_TitleSettingsIcons);
            ucDdo_br_medication_rxunit.SetProperty("DropDownOptionsData", AV28BR_Medication_RXUnitTitleFilterData);
            ucDdo_br_medication_rxunit.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_rxunit_Internalname, "DDO_BR_MEDICATION_RXUNITContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'" + sGXsfl_32_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Internalname, AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", 0, edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicationPromptItl.htm");
            /* User Defined Control */
            ucDdo_br_medication_rxfrequency.SetProperty("Caption", Ddo_br_medication_rxfrequency_Caption);
            ucDdo_br_medication_rxfrequency.SetProperty("Tooltip", Ddo_br_medication_rxfrequency_Tooltip);
            ucDdo_br_medication_rxfrequency.SetProperty("Cls", Ddo_br_medication_rxfrequency_Cls);
            ucDdo_br_medication_rxfrequency.SetProperty("DropDownOptionsType", Ddo_br_medication_rxfrequency_Dropdownoptionstype);
            ucDdo_br_medication_rxfrequency.SetProperty("IncludeSortASC", Ddo_br_medication_rxfrequency_Includesortasc);
            ucDdo_br_medication_rxfrequency.SetProperty("IncludeSortDSC", Ddo_br_medication_rxfrequency_Includesortdsc);
            ucDdo_br_medication_rxfrequency.SetProperty("IncludeFilter", Ddo_br_medication_rxfrequency_Includefilter);
            ucDdo_br_medication_rxfrequency.SetProperty("IncludeDataList", Ddo_br_medication_rxfrequency_Includedatalist);
            ucDdo_br_medication_rxfrequency.SetProperty("SortASC", Ddo_br_medication_rxfrequency_Sortasc);
            ucDdo_br_medication_rxfrequency.SetProperty("SortDSC", Ddo_br_medication_rxfrequency_Sortdsc);
            ucDdo_br_medication_rxfrequency.SetProperty("SearchButtonText", Ddo_br_medication_rxfrequency_Searchbuttontext);
            ucDdo_br_medication_rxfrequency.SetProperty("DropDownOptionsTitleSettingsIcons", AV56DDO_TitleSettingsIcons);
            ucDdo_br_medication_rxfrequency.SetProperty("DropDownOptionsData", AV30BR_Medication_RXFrequencyTitleFilterData);
            ucDdo_br_medication_rxfrequency.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_rxfrequency_Internalname, "DDO_BR_MEDICATION_RXFREQUENCYContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'" + sGXsfl_32_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_rxfrequencytitlecontrolidtoreplace_Internalname, AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", 0, edtavDdo_br_medication_rxfrequencytitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicationPromptItl.htm");
            /* User Defined Control */
            ucDdo_br_medication_rxquantity.SetProperty("Caption", Ddo_br_medication_rxquantity_Caption);
            ucDdo_br_medication_rxquantity.SetProperty("Tooltip", Ddo_br_medication_rxquantity_Tooltip);
            ucDdo_br_medication_rxquantity.SetProperty("Cls", Ddo_br_medication_rxquantity_Cls);
            ucDdo_br_medication_rxquantity.SetProperty("DropDownOptionsType", Ddo_br_medication_rxquantity_Dropdownoptionstype);
            ucDdo_br_medication_rxquantity.SetProperty("IncludeSortASC", Ddo_br_medication_rxquantity_Includesortasc);
            ucDdo_br_medication_rxquantity.SetProperty("IncludeSortDSC", Ddo_br_medication_rxquantity_Includesortdsc);
            ucDdo_br_medication_rxquantity.SetProperty("IncludeFilter", Ddo_br_medication_rxquantity_Includefilter);
            ucDdo_br_medication_rxquantity.SetProperty("IncludeDataList", Ddo_br_medication_rxquantity_Includedatalist);
            ucDdo_br_medication_rxquantity.SetProperty("SortASC", Ddo_br_medication_rxquantity_Sortasc);
            ucDdo_br_medication_rxquantity.SetProperty("SortDSC", Ddo_br_medication_rxquantity_Sortdsc);
            ucDdo_br_medication_rxquantity.SetProperty("SearchButtonText", Ddo_br_medication_rxquantity_Searchbuttontext);
            ucDdo_br_medication_rxquantity.SetProperty("DropDownOptionsTitleSettingsIcons", AV56DDO_TitleSettingsIcons);
            ucDdo_br_medication_rxquantity.SetProperty("DropDownOptionsData", AV32BR_Medication_RXQuantityTitleFilterData);
            ucDdo_br_medication_rxquantity.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_rxquantity_Internalname, "DDO_BR_MEDICATION_RXQUANTITYContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'" + sGXsfl_32_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_rxquantitytitlecontrolidtoreplace_Internalname, AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", 0, edtavDdo_br_medication_rxquantitytitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicationPromptItl.htm");
            /* User Defined Control */
            ucDdo_br_medication_rxdayssupply.SetProperty("Caption", Ddo_br_medication_rxdayssupply_Caption);
            ucDdo_br_medication_rxdayssupply.SetProperty("Tooltip", Ddo_br_medication_rxdayssupply_Tooltip);
            ucDdo_br_medication_rxdayssupply.SetProperty("Cls", Ddo_br_medication_rxdayssupply_Cls);
            ucDdo_br_medication_rxdayssupply.SetProperty("DropDownOptionsType", Ddo_br_medication_rxdayssupply_Dropdownoptionstype);
            ucDdo_br_medication_rxdayssupply.SetProperty("IncludeSortASC", Ddo_br_medication_rxdayssupply_Includesortasc);
            ucDdo_br_medication_rxdayssupply.SetProperty("IncludeSortDSC", Ddo_br_medication_rxdayssupply_Includesortdsc);
            ucDdo_br_medication_rxdayssupply.SetProperty("IncludeFilter", Ddo_br_medication_rxdayssupply_Includefilter);
            ucDdo_br_medication_rxdayssupply.SetProperty("IncludeDataList", Ddo_br_medication_rxdayssupply_Includedatalist);
            ucDdo_br_medication_rxdayssupply.SetProperty("SortASC", Ddo_br_medication_rxdayssupply_Sortasc);
            ucDdo_br_medication_rxdayssupply.SetProperty("SortDSC", Ddo_br_medication_rxdayssupply_Sortdsc);
            ucDdo_br_medication_rxdayssupply.SetProperty("SearchButtonText", Ddo_br_medication_rxdayssupply_Searchbuttontext);
            ucDdo_br_medication_rxdayssupply.SetProperty("DropDownOptionsTitleSettingsIcons", AV56DDO_TitleSettingsIcons);
            ucDdo_br_medication_rxdayssupply.SetProperty("DropDownOptionsData", AV34BR_Medication_RXDaysSupplyTitleFilterData);
            ucDdo_br_medication_rxdayssupply.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_rxdayssupply_Internalname, "DDO_BR_MEDICATION_RXDAYSSUPPLYContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'" + sGXsfl_32_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_rxdayssupplytitlecontrolidtoreplace_Internalname, AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,61);\"", 0, edtavDdo_br_medication_rxdayssupplytitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicationPromptItl.htm");
            /* User Defined Control */
            ucDdo_br_medication_admitstartdate.SetProperty("Caption", Ddo_br_medication_admitstartdate_Caption);
            ucDdo_br_medication_admitstartdate.SetProperty("Tooltip", Ddo_br_medication_admitstartdate_Tooltip);
            ucDdo_br_medication_admitstartdate.SetProperty("Cls", Ddo_br_medication_admitstartdate_Cls);
            ucDdo_br_medication_admitstartdate.SetProperty("DropDownOptionsType", Ddo_br_medication_admitstartdate_Dropdownoptionstype);
            ucDdo_br_medication_admitstartdate.SetProperty("IncludeSortASC", Ddo_br_medication_admitstartdate_Includesortasc);
            ucDdo_br_medication_admitstartdate.SetProperty("IncludeSortDSC", Ddo_br_medication_admitstartdate_Includesortdsc);
            ucDdo_br_medication_admitstartdate.SetProperty("IncludeFilter", Ddo_br_medication_admitstartdate_Includefilter);
            ucDdo_br_medication_admitstartdate.SetProperty("IncludeDataList", Ddo_br_medication_admitstartdate_Includedatalist);
            ucDdo_br_medication_admitstartdate.SetProperty("SortASC", Ddo_br_medication_admitstartdate_Sortasc);
            ucDdo_br_medication_admitstartdate.SetProperty("SortDSC", Ddo_br_medication_admitstartdate_Sortdsc);
            ucDdo_br_medication_admitstartdate.SetProperty("SearchButtonText", Ddo_br_medication_admitstartdate_Searchbuttontext);
            ucDdo_br_medication_admitstartdate.SetProperty("DropDownOptionsTitleSettingsIcons", AV56DDO_TitleSettingsIcons);
            ucDdo_br_medication_admitstartdate.SetProperty("DropDownOptionsData", AV42BR_Medication_AdmitStartDateTitleFilterData);
            ucDdo_br_medication_admitstartdate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_admitstartdate_Internalname, "DDO_BR_MEDICATION_ADMITSTARTDATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'" + sGXsfl_32_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_admitstartdatetitlecontrolidtoreplace_Internalname, AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", 0, edtavDdo_br_medication_admitstartdatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicationPromptItl.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'" + sGXsfl_32_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,65);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicationPromptItl.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_32_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV11OrderedDsc), StringUtil.BoolToStr( AV11OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_MedicationPromptItl.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'" + sGXsfl_32_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_rxunit_Internalname, AV70TFBR_Medication_RXUnit, StringUtil.RTrim( context.localUtil.Format( AV70TFBR_Medication_RXUnit, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,67);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_rxunit_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_rxunit_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicationPromptItl.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'" + sGXsfl_32_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_rxunit_sel_Internalname, AV71TFBR_Medication_RXUnit_Sel, StringUtil.RTrim( context.localUtil.Format( AV71TFBR_Medication_RXUnit_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,68);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_rxunit_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_rxunit_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicationPromptItl.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 32 )
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

      protected void START8G2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "Data Mgmt Portal -RAAP", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP8G0( ) ;
      }

      protected void WS8G2( )
      {
         START8G2( ) ;
         EVT8G2( ) ;
      }

      protected void EVT8G2( )
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
                           E118G2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E128G2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E138G2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_RXDOSE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E148G2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_RXUNIT.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E158G2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_RXFREQUENCY.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E168G2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_RXQUANTITY.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E178G2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_RXDAYSSUPPLY.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E188G2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_ADMITSTARTDATE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E198G2 ();
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
                           nGXsfl_32_idx = (short)(NumberUtil.Val( sEvtType, "."));
                           sGXsfl_32_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_32_idx), 4, 0)), 4, "0");
                           SubsflControlProps_322( ) ;
                           AV61Select = cgiGet( edtavSelect_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV61Select)) ? AV75Select_GXI : context.convertURL( context.PathToRelativeUrl( AV61Select))), !bGXsfl_32_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "SrcSet", context.GetImageSrcSet( AV61Select), true);
                           A119BR_MedicationID = (long)(context.localUtil.CToN( cgiGet( edtBR_MedicationID_Internalname), ".", ","));
                           A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
                           A121BR_Medication_RXName = cgiGet( edtBR_Medication_RXName_Internalname);
                           n121BR_Medication_RXName = false;
                           A124BR_Medication_RXDose = context.localUtil.CToN( cgiGet( edtBR_Medication_RXDose_Internalname), ".", ",");
                           n124BR_Medication_RXDose = false;
                           A125BR_Medication_RXUnit = cgiGet( edtBR_Medication_RXUnit_Internalname);
                           n125BR_Medication_RXUnit = false;
                           A126BR_Medication_RXFrequency = cgiGet( edtBR_Medication_RXFrequency_Internalname);
                           n126BR_Medication_RXFrequency = false;
                           A127BR_Medication_RXQuantity = cgiGet( edtBR_Medication_RXQuantity_Internalname);
                           n127BR_Medication_RXQuantity = false;
                           A128BR_Medication_RXDaysSupply = context.localUtil.CToN( cgiGet( edtBR_Medication_RXDaysSupply_Internalname), ".", ",");
                           n128BR_Medication_RXDaysSupply = false;
                           A132BR_Medication_AdmitStartDate = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtBR_Medication_AdmitStartDate_Internalname), 0));
                           n132BR_Medication_AdmitStartDate = false;
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E208G2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E218G2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E228G2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    Rfr0gs = false;
                                    /* Set Refresh If Br_medication_rxname Changed */
                                    if ( StringUtil.StrCmp(cgiGet( "GXH_vBR_MEDICATION_RXNAME"), AV62BR_Medication_RXName) != 0 )
                                    {
                                       Rfr0gs = true;
                                    }
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
                                    /* Set Refresh If Tfbr_medication_rxunit Changed */
                                    if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_RXUNIT"), AV70TFBR_Medication_RXUnit) != 0 )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Tfbr_medication_rxunit_sel Changed */
                                    if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_RXUNIT_SEL"), AV71TFBR_Medication_RXUnit_Sel) != 0 )
                                    {
                                       Rfr0gs = true;
                                    }
                                    if ( ! Rfr0gs )
                                    {
                                       /* Execute user event: Enter */
                                       E238G2 ();
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

      protected void WE8G2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm8G2( ) ;
            }
         }
      }

      protected void PA8G2( )
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
               GX_FocusControl = edtavBr_medication_rxname_Internalname;
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
         SubsflControlProps_322( ) ;
         while ( nGXsfl_32_idx <= nRC_GXsfl_32 )
         {
            sendrow_322( ) ;
            nGXsfl_32_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_32_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_32_idx+1));
            sGXsfl_32_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_32_idx), 4, 0)), 4, "0");
            SubsflControlProps_322( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       String AV62BR_Medication_RXName ,
                                       short AV10OrderedBy ,
                                       bool AV11OrderedDsc ,
                                       String AV70TFBR_Medication_RXUnit ,
                                       String AV71TFBR_Medication_RXUnit_Sel ,
                                       String AV21ddo_BR_Medication_RXNameTitleControlIdToReplace ,
                                       String AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace ,
                                       String AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace ,
                                       String AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace ,
                                       String AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace ,
                                       String AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace ,
                                       String AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace ,
                                       String AV74Pgmname )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF8G2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_MEDICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A119BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_MEDICATIONID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A119BR_MedicationID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_MEDICATION_RXNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A121BR_Medication_RXName, "")), context));
         GxWebStd.gx_hidden_field( context, "BR_MEDICATION_RXNAME", A121BR_Medication_RXName);
         GxWebStd.gx_hidden_field( context, "gxhash_BR_MEDICATION_RXDOSE", GetSecureSignedToken( "", context.localUtil.Format( A124BR_Medication_RXDose, "ZZZZZZZZZ.ZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_MEDICATION_RXDOSE", StringUtil.LTrim( StringUtil.NToC( A124BR_Medication_RXDose, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_MEDICATION_RXUNIT", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A125BR_Medication_RXUnit, "")), context));
         GxWebStd.gx_hidden_field( context, "BR_MEDICATION_RXUNIT", A125BR_Medication_RXUnit);
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
         RF8G2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV74Pgmname = "BR_MedicationPromptItl";
         context.Gx_err = 0;
      }

      protected void RF8G2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 32;
         /* Execute user event: Refresh */
         E218G2 ();
         nGXsfl_32_idx = 1;
         sGXsfl_32_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_32_idx), 4, 0)), 4, "0");
         SubsflControlProps_322( ) ;
         bGXsfl_32_Refreshing = true;
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
            SubsflControlProps_322( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV62BR_Medication_RXName ,
                                                 AV71TFBR_Medication_RXUnit_Sel ,
                                                 AV70TFBR_Medication_RXUnit ,
                                                 A121BR_Medication_RXName ,
                                                 A125BR_Medication_RXUnit ,
                                                 AV10OrderedBy ,
                                                 AV11OrderedDsc ,
                                                 A19BR_EncounterID ,
                                                 AV64BR_EncounterID } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG,
                                                 TypeConstants.LONG
                                                 }
            } ) ;
            lV62BR_Medication_RXName = StringUtil.Concat( StringUtil.RTrim( AV62BR_Medication_RXName), "%", "");
            lV70TFBR_Medication_RXUnit = StringUtil.Concat( StringUtil.RTrim( AV70TFBR_Medication_RXUnit), "%", "");
            /* Using cursor H008G2 */
            pr_default.execute(0, new Object[] {AV64BR_EncounterID, lV62BR_Medication_RXName, lV70TFBR_Medication_RXUnit, AV71TFBR_Medication_RXUnit_Sel, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_32_idx = 1;
            sGXsfl_32_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_32_idx), 4, 0)), 4, "0");
            SubsflControlProps_322( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A132BR_Medication_AdmitStartDate = H008G2_A132BR_Medication_AdmitStartDate[0];
               n132BR_Medication_AdmitStartDate = H008G2_n132BR_Medication_AdmitStartDate[0];
               A128BR_Medication_RXDaysSupply = H008G2_A128BR_Medication_RXDaysSupply[0];
               n128BR_Medication_RXDaysSupply = H008G2_n128BR_Medication_RXDaysSupply[0];
               A127BR_Medication_RXQuantity = H008G2_A127BR_Medication_RXQuantity[0];
               n127BR_Medication_RXQuantity = H008G2_n127BR_Medication_RXQuantity[0];
               A126BR_Medication_RXFrequency = H008G2_A126BR_Medication_RXFrequency[0];
               n126BR_Medication_RXFrequency = H008G2_n126BR_Medication_RXFrequency[0];
               A125BR_Medication_RXUnit = H008G2_A125BR_Medication_RXUnit[0];
               n125BR_Medication_RXUnit = H008G2_n125BR_Medication_RXUnit[0];
               A124BR_Medication_RXDose = H008G2_A124BR_Medication_RXDose[0];
               n124BR_Medication_RXDose = H008G2_n124BR_Medication_RXDose[0];
               A121BR_Medication_RXName = H008G2_A121BR_Medication_RXName[0];
               n121BR_Medication_RXName = H008G2_n121BR_Medication_RXName[0];
               A19BR_EncounterID = H008G2_A19BR_EncounterID[0];
               A119BR_MedicationID = H008G2_A119BR_MedicationID[0];
               E228G2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 32;
            WB8G0( ) ;
         }
         bGXsfl_32_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes8G2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_MEDICATIONID"+"_"+sGXsfl_32_idx, GetSecureSignedToken( sGXsfl_32_idx, context.localUtil.Format( (decimal)(A119BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_MEDICATION_RXNAME"+"_"+sGXsfl_32_idx, GetSecureSignedToken( sGXsfl_32_idx, StringUtil.RTrim( context.localUtil.Format( A121BR_Medication_RXName, "")), context));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_MEDICATION_RXDOSE"+"_"+sGXsfl_32_idx, GetSecureSignedToken( sGXsfl_32_idx, context.localUtil.Format( A124BR_Medication_RXDose, "ZZZZZZZZZ.ZZ"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_MEDICATION_RXUNIT"+"_"+sGXsfl_32_idx, GetSecureSignedToken( sGXsfl_32_idx, StringUtil.RTrim( context.localUtil.Format( A125BR_Medication_RXUnit, "")), context));
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
                                              AV62BR_Medication_RXName ,
                                              AV71TFBR_Medication_RXUnit_Sel ,
                                              AV70TFBR_Medication_RXUnit ,
                                              A121BR_Medication_RXName ,
                                              A125BR_Medication_RXUnit ,
                                              AV10OrderedBy ,
                                              AV11OrderedDsc ,
                                              A19BR_EncounterID ,
                                              AV64BR_EncounterID } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG,
                                              TypeConstants.LONG
                                              }
         } ) ;
         lV62BR_Medication_RXName = StringUtil.Concat( StringUtil.RTrim( AV62BR_Medication_RXName), "%", "");
         lV70TFBR_Medication_RXUnit = StringUtil.Concat( StringUtil.RTrim( AV70TFBR_Medication_RXUnit), "%", "");
         /* Using cursor H008G3 */
         pr_default.execute(1, new Object[] {AV64BR_EncounterID, lV62BR_Medication_RXName, lV70TFBR_Medication_RXUnit, AV71TFBR_Medication_RXUnit_Sel});
         GRID_nRecordCount = H008G3_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV62BR_Medication_RXName, AV10OrderedBy, AV11OrderedDsc, AV70TFBR_Medication_RXUnit, AV71TFBR_Medication_RXUnit_Sel, AV21ddo_BR_Medication_RXNameTitleControlIdToReplace, AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace, AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace, AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace, AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace, AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace, AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace, AV74Pgmname) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV62BR_Medication_RXName, AV10OrderedBy, AV11OrderedDsc, AV70TFBR_Medication_RXUnit, AV71TFBR_Medication_RXUnit_Sel, AV21ddo_BR_Medication_RXNameTitleControlIdToReplace, AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace, AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace, AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace, AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace, AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace, AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace, AV74Pgmname) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV62BR_Medication_RXName, AV10OrderedBy, AV11OrderedDsc, AV70TFBR_Medication_RXUnit, AV71TFBR_Medication_RXUnit_Sel, AV21ddo_BR_Medication_RXNameTitleControlIdToReplace, AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace, AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace, AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace, AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace, AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace, AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace, AV74Pgmname) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV62BR_Medication_RXName, AV10OrderedBy, AV11OrderedDsc, AV70TFBR_Medication_RXUnit, AV71TFBR_Medication_RXUnit_Sel, AV21ddo_BR_Medication_RXNameTitleControlIdToReplace, AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace, AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace, AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace, AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace, AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace, AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace, AV74Pgmname) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV62BR_Medication_RXName, AV10OrderedBy, AV11OrderedDsc, AV70TFBR_Medication_RXUnit, AV71TFBR_Medication_RXUnit_Sel, AV21ddo_BR_Medication_RXNameTitleControlIdToReplace, AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace, AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace, AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace, AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace, AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace, AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace, AV74Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP8G0( )
      {
         /* Before Start, stand alone formulas. */
         AV74Pgmname = "BR_MedicationPromptItl";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E208G2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV56DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_RXNAMETITLEFILTERDATA"), AV20BR_Medication_RXNameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_RXDOSETITLEFILTERDATA"), AV26BR_Medication_RXDoseTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_RXUNITTITLEFILTERDATA"), AV28BR_Medication_RXUnitTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA"), AV30BR_Medication_RXFrequencyTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA"), AV32BR_Medication_RXQuantityTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA"), AV34BR_Medication_RXDaysSupplyTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA"), AV42BR_Medication_AdmitStartDateTitleFilterData);
            /* Read variables values. */
            AV62BR_Medication_RXName = cgiGet( edtavBr_medication_rxname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV62BR_Medication_RXName", AV62BR_Medication_RXName);
            AV21ddo_BR_Medication_RXNameTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ddo_BR_Medication_RXNameTitleControlIdToReplace", AV21ddo_BR_Medication_RXNameTitleControlIdToReplace);
            AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace", AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace);
            AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace", AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace);
            AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_rxfrequencytitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace", AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace);
            AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_rxquantitytitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace", AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace);
            AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_rxdayssupplytitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace", AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace);
            AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_admitstartdatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace", AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace);
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
            AV70TFBR_Medication_RXUnit = cgiGet( edtavTfbr_medication_rxunit_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV70TFBR_Medication_RXUnit", AV70TFBR_Medication_RXUnit);
            AV71TFBR_Medication_RXUnit_Sel = cgiGet( edtavTfbr_medication_rxunit_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV71TFBR_Medication_RXUnit_Sel", AV71TFBR_Medication_RXUnit_Sel);
            /* Read saved values. */
            nRC_GXsfl_32 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_32"), ".", ","));
            AV58GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV60GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV59GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_medication_rxname_Caption = cgiGet( "DDO_BR_MEDICATION_RXNAME_Caption");
            Ddo_br_medication_rxname_Tooltip = cgiGet( "DDO_BR_MEDICATION_RXNAME_Tooltip");
            Ddo_br_medication_rxname_Cls = cgiGet( "DDO_BR_MEDICATION_RXNAME_Cls");
            Ddo_br_medication_rxname_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_RXNAME_Dropdownoptionstype");
            Ddo_br_medication_rxname_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_RXNAME_Titlecontrolidtoreplace");
            Ddo_br_medication_rxname_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXNAME_Includesortasc"));
            Ddo_br_medication_rxname_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXNAME_Includesortdsc"));
            Ddo_br_medication_rxname_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_RXNAME_Sortedstatus");
            Ddo_br_medication_rxname_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXNAME_Includefilter"));
            Ddo_br_medication_rxname_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXNAME_Includedatalist"));
            Ddo_br_medication_rxname_Sortasc = cgiGet( "DDO_BR_MEDICATION_RXNAME_Sortasc");
            Ddo_br_medication_rxname_Sortdsc = cgiGet( "DDO_BR_MEDICATION_RXNAME_Sortdsc");
            Ddo_br_medication_rxname_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_RXNAME_Searchbuttontext");
            Ddo_br_medication_rxdose_Caption = cgiGet( "DDO_BR_MEDICATION_RXDOSE_Caption");
            Ddo_br_medication_rxdose_Tooltip = cgiGet( "DDO_BR_MEDICATION_RXDOSE_Tooltip");
            Ddo_br_medication_rxdose_Cls = cgiGet( "DDO_BR_MEDICATION_RXDOSE_Cls");
            Ddo_br_medication_rxdose_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_RXDOSE_Dropdownoptionstype");
            Ddo_br_medication_rxdose_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_RXDOSE_Titlecontrolidtoreplace");
            Ddo_br_medication_rxdose_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXDOSE_Includesortasc"));
            Ddo_br_medication_rxdose_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXDOSE_Includesortdsc"));
            Ddo_br_medication_rxdose_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_RXDOSE_Sortedstatus");
            Ddo_br_medication_rxdose_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXDOSE_Includefilter"));
            Ddo_br_medication_rxdose_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXDOSE_Includedatalist"));
            Ddo_br_medication_rxdose_Sortasc = cgiGet( "DDO_BR_MEDICATION_RXDOSE_Sortasc");
            Ddo_br_medication_rxdose_Sortdsc = cgiGet( "DDO_BR_MEDICATION_RXDOSE_Sortdsc");
            Ddo_br_medication_rxdose_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_RXDOSE_Searchbuttontext");
            Ddo_br_medication_rxunit_Caption = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Caption");
            Ddo_br_medication_rxunit_Tooltip = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Tooltip");
            Ddo_br_medication_rxunit_Cls = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Cls");
            Ddo_br_medication_rxunit_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Dropdownoptionstype");
            Ddo_br_medication_rxunit_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Titlecontrolidtoreplace");
            Ddo_br_medication_rxunit_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXUNIT_Includesortasc"));
            Ddo_br_medication_rxunit_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXUNIT_Includesortdsc"));
            Ddo_br_medication_rxunit_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Sortedstatus");
            Ddo_br_medication_rxunit_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXUNIT_Includefilter"));
            Ddo_br_medication_rxunit_Filtertype = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Filtertype");
            Ddo_br_medication_rxunit_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXUNIT_Filterisrange"));
            Ddo_br_medication_rxunit_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXUNIT_Includedatalist"));
            Ddo_br_medication_rxunit_Datalisttype = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Datalisttype");
            Ddo_br_medication_rxunit_Datalistproc = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Datalistproc");
            Ddo_br_medication_rxunit_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_MEDICATION_RXUNIT_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_medication_rxunit_Sortasc = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Sortasc");
            Ddo_br_medication_rxunit_Sortdsc = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Sortdsc");
            Ddo_br_medication_rxunit_Loadingdata = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Loadingdata");
            Ddo_br_medication_rxunit_Cleanfilter = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Cleanfilter");
            Ddo_br_medication_rxunit_Noresultsfound = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Noresultsfound");
            Ddo_br_medication_rxunit_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Searchbuttontext");
            Ddo_br_medication_rxfrequency_Caption = cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Caption");
            Ddo_br_medication_rxfrequency_Tooltip = cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Tooltip");
            Ddo_br_medication_rxfrequency_Cls = cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Cls");
            Ddo_br_medication_rxfrequency_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Dropdownoptionstype");
            Ddo_br_medication_rxfrequency_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Titlecontrolidtoreplace");
            Ddo_br_medication_rxfrequency_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Includesortasc"));
            Ddo_br_medication_rxfrequency_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Includesortdsc"));
            Ddo_br_medication_rxfrequency_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Sortedstatus");
            Ddo_br_medication_rxfrequency_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Includefilter"));
            Ddo_br_medication_rxfrequency_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Includedatalist"));
            Ddo_br_medication_rxfrequency_Sortasc = cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Sortasc");
            Ddo_br_medication_rxfrequency_Sortdsc = cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Sortdsc");
            Ddo_br_medication_rxfrequency_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Searchbuttontext");
            Ddo_br_medication_rxquantity_Caption = cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Caption");
            Ddo_br_medication_rxquantity_Tooltip = cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Tooltip");
            Ddo_br_medication_rxquantity_Cls = cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Cls");
            Ddo_br_medication_rxquantity_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Dropdownoptionstype");
            Ddo_br_medication_rxquantity_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Titlecontrolidtoreplace");
            Ddo_br_medication_rxquantity_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Includesortasc"));
            Ddo_br_medication_rxquantity_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Includesortdsc"));
            Ddo_br_medication_rxquantity_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Sortedstatus");
            Ddo_br_medication_rxquantity_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Includefilter"));
            Ddo_br_medication_rxquantity_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Includedatalist"));
            Ddo_br_medication_rxquantity_Sortasc = cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Sortasc");
            Ddo_br_medication_rxquantity_Sortdsc = cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Sortdsc");
            Ddo_br_medication_rxquantity_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Searchbuttontext");
            Ddo_br_medication_rxdayssupply_Caption = cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Caption");
            Ddo_br_medication_rxdayssupply_Tooltip = cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Tooltip");
            Ddo_br_medication_rxdayssupply_Cls = cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Cls");
            Ddo_br_medication_rxdayssupply_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Dropdownoptionstype");
            Ddo_br_medication_rxdayssupply_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Titlecontrolidtoreplace");
            Ddo_br_medication_rxdayssupply_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Includesortasc"));
            Ddo_br_medication_rxdayssupply_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Includesortdsc"));
            Ddo_br_medication_rxdayssupply_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Sortedstatus");
            Ddo_br_medication_rxdayssupply_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Includefilter"));
            Ddo_br_medication_rxdayssupply_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Includedatalist"));
            Ddo_br_medication_rxdayssupply_Sortasc = cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Sortasc");
            Ddo_br_medication_rxdayssupply_Sortdsc = cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Sortdsc");
            Ddo_br_medication_rxdayssupply_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Searchbuttontext");
            Ddo_br_medication_admitstartdate_Caption = cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Caption");
            Ddo_br_medication_admitstartdate_Tooltip = cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Tooltip");
            Ddo_br_medication_admitstartdate_Cls = cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Cls");
            Ddo_br_medication_admitstartdate_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Dropdownoptionstype");
            Ddo_br_medication_admitstartdate_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Titlecontrolidtoreplace");
            Ddo_br_medication_admitstartdate_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Includesortasc"));
            Ddo_br_medication_admitstartdate_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Includesortdsc"));
            Ddo_br_medication_admitstartdate_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Sortedstatus");
            Ddo_br_medication_admitstartdate_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Includefilter"));
            Ddo_br_medication_admitstartdate_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Includedatalist"));
            Ddo_br_medication_admitstartdate_Sortasc = cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Sortasc");
            Ddo_br_medication_admitstartdate_Sortdsc = cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Sortdsc");
            Ddo_br_medication_admitstartdate_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_medication_rxname_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_RXNAME_Activeeventkey");
            Ddo_br_medication_rxdose_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_RXDOSE_Activeeventkey");
            Ddo_br_medication_rxunit_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Activeeventkey");
            Ddo_br_medication_rxunit_Filteredtext_get = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Filteredtext_get");
            Ddo_br_medication_rxunit_Selectedvalue_get = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Selectedvalue_get");
            Ddo_br_medication_rxfrequency_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Activeeventkey");
            Ddo_br_medication_rxquantity_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Activeeventkey");
            Ddo_br_medication_rxdayssupply_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Activeeventkey");
            Ddo_br_medication_admitstartdate_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Activeeventkey");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( StringUtil.StrCmp(cgiGet( "GXH_vBR_MEDICATION_RXNAME"), AV62BR_Medication_RXName) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV10OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV11OrderedDsc )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_RXUNIT"), AV70TFBR_Medication_RXUnit) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_RXUNIT_SEL"), AV71TFBR_Medication_RXUnit_Sel) != 0 )
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
         E208G2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E208G2( )
      {
         /* Start Routine */
         AV64BR_EncounterID = (long)(NumberUtil.Val( AV63WebSession.Get("Medication_Br_EncounterID"), "."));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV64BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV64BR_EncounterID), 18, 0)));
         GXt_boolean1 = AV5IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Medication", out  GXt_boolean1) ;
         AV5IsAuthorized = GXt_boolean1;
         if ( ! AV5IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV74Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         divTablemain_Height = 493;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTablemain_Internalname, "Height", StringUtil.LTrim( StringUtil.Str( (decimal)(divTablemain_Height), 9, 0)), true);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         edtavTfbr_medication_rxunit_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_rxunit_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_rxunit_Visible), 5, 0)), true);
         edtavTfbr_medication_rxunit_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_rxunit_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_rxunit_sel_Visible), 5, 0)), true);
         Ddo_br_medication_rxname_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_RXName";
         ucDdo_br_medication_rxname.SendProperty(context, "", false, Ddo_br_medication_rxname_Internalname, "TitleControlIdToReplace", Ddo_br_medication_rxname_Titlecontrolidtoreplace);
         AV21ddo_BR_Medication_RXNameTitleControlIdToReplace = Ddo_br_medication_rxname_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ddo_BR_Medication_RXNameTitleControlIdToReplace", AV21ddo_BR_Medication_RXNameTitleControlIdToReplace);
         edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_rxdose_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_RXDose";
         ucDdo_br_medication_rxdose.SendProperty(context, "", false, Ddo_br_medication_rxdose_Internalname, "TitleControlIdToReplace", Ddo_br_medication_rxdose_Titlecontrolidtoreplace);
         AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace = Ddo_br_medication_rxdose_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace", AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace);
         edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_rxunit_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_RXUnit";
         ucDdo_br_medication_rxunit.SendProperty(context, "", false, Ddo_br_medication_rxunit_Internalname, "TitleControlIdToReplace", Ddo_br_medication_rxunit_Titlecontrolidtoreplace);
         AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace = Ddo_br_medication_rxunit_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace", AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace);
         edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_rxfrequency_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_RXFrequency";
         ucDdo_br_medication_rxfrequency.SendProperty(context, "", false, Ddo_br_medication_rxfrequency_Internalname, "TitleControlIdToReplace", Ddo_br_medication_rxfrequency_Titlecontrolidtoreplace);
         AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace = Ddo_br_medication_rxfrequency_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace", AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace);
         edtavDdo_br_medication_rxfrequencytitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_rxfrequencytitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_rxfrequencytitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_rxquantity_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_RXQuantity";
         ucDdo_br_medication_rxquantity.SendProperty(context, "", false, Ddo_br_medication_rxquantity_Internalname, "TitleControlIdToReplace", Ddo_br_medication_rxquantity_Titlecontrolidtoreplace);
         AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace = Ddo_br_medication_rxquantity_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace", AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace);
         edtavDdo_br_medication_rxquantitytitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_rxquantitytitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_rxquantitytitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_rxdayssupply_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_RXDaysSupply";
         ucDdo_br_medication_rxdayssupply.SendProperty(context, "", false, Ddo_br_medication_rxdayssupply_Internalname, "TitleControlIdToReplace", Ddo_br_medication_rxdayssupply_Titlecontrolidtoreplace);
         AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace = Ddo_br_medication_rxdayssupply_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace", AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace);
         edtavDdo_br_medication_rxdayssupplytitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_rxdayssupplytitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_rxdayssupplytitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_admitstartdate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_AdmitStartDate";
         ucDdo_br_medication_admitstartdate.SendProperty(context, "", false, Ddo_br_medication_admitstartdate_Internalname, "TitleControlIdToReplace", Ddo_br_medication_admitstartdate_Titlecontrolidtoreplace);
         AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace = Ddo_br_medication_admitstartdate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace", AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace);
         edtavDdo_br_medication_admitstartdatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_admitstartdatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_admitstartdatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "选择药物治疗";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         edtavOrderedby_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrderedby_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrderedby_Visible), 5, 0)), true);
         if ( AV10OrderedBy < 1 )
         {
            AV10OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
            S112 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
         edtavOrdereddsc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrdereddsc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrdereddsc_Visible), 5, 0)), true);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV56DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV56DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E218G2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV64BR_EncounterID = (long)(NumberUtil.Val( AV63WebSession.Get("Medication_Br_EncounterID"), "."));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV64BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV64BR_EncounterID), 18, 0)));
         AV20BR_Medication_RXNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV26BR_Medication_RXDoseTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28BR_Medication_RXUnitTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV30BR_Medication_RXFrequencyTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32BR_Medication_RXQuantityTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV34BR_Medication_RXDaysSupplyTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV42BR_Medication_AdmitStartDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         /* Execute user subroutine: 'SAVEGRIDSTATE' */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         edtBR_Medication_RXName_Titleformat = 2;
         edtBR_Medication_RXName_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "药物名称", AV21ddo_BR_Medication_RXNameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_RXName_Internalname, "Title", edtBR_Medication_RXName_Title, !bGXsfl_32_Refreshing);
         edtBR_Medication_RXDose_Titleformat = 2;
         edtBR_Medication_RXDose_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "药物剂量", AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_RXDose_Internalname, "Title", edtBR_Medication_RXDose_Title, !bGXsfl_32_Refreshing);
         edtBR_Medication_RXUnit_Titleformat = 2;
         edtBR_Medication_RXUnit_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "计量单位", AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_RXUnit_Internalname, "Title", edtBR_Medication_RXUnit_Title, !bGXsfl_32_Refreshing);
         edtBR_Medication_RXFrequency_Titleformat = 2;
         edtBR_Medication_RXFrequency_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "服药频率", AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_RXFrequency_Internalname, "Title", edtBR_Medication_RXFrequency_Title, !bGXsfl_32_Refreshing);
         edtBR_Medication_RXQuantity_Titleformat = 2;
         edtBR_Medication_RXQuantity_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "用药量", AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_RXQuantity_Internalname, "Title", edtBR_Medication_RXQuantity_Title, !bGXsfl_32_Refreshing);
         edtBR_Medication_RXDaysSupply_Titleformat = 2;
         edtBR_Medication_RXDaysSupply_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "服药天数", AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_RXDaysSupply_Internalname, "Title", edtBR_Medication_RXDaysSupply_Title, !bGXsfl_32_Refreshing);
         edtBR_Medication_AdmitStartDate_Titleformat = 2;
         edtBR_Medication_AdmitStartDate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "服药日期", AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_AdmitStartDate_Internalname, "Title", edtBR_Medication_AdmitStartDate_Title, !bGXsfl_32_Refreshing);
         AV58GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV58GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV58GridCurrentPage), 10, 0)));
         AV59GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV59GridPageSize), 10, 0)));
         AV60GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV60GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Medication_RXNameTitleFilterData", AV20BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Medication_RXDoseTitleFilterData", AV26BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Medication_RXUnitTitleFilterData", AV28BR_Medication_RXUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Medication_RXFrequencyTitleFilterData", AV30BR_Medication_RXFrequencyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Medication_RXQuantityTitleFilterData", AV32BR_Medication_RXQuantityTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Medication_RXDaysSupplyTitleFilterData", AV34BR_Medication_RXDaysSupplyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Medication_AdmitStartDateTitleFilterData", AV42BR_Medication_AdmitStartDateTitleFilterData);
      }

      protected void E118G2( )
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
            AV57PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV57PageToGo) ;
         }
      }

      protected void E128G2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E138G2( )
      {
         /* Ddo_br_medication_rxname_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_rxname_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S132 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV10OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_medication_rxname_Sortedstatus = "ASC";
            ucDdo_br_medication_rxname.SendProperty(context, "", false, Ddo_br_medication_rxname_Internalname, "SortedStatus", Ddo_br_medication_rxname_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_rxname_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S132 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV10OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_medication_rxname_Sortedstatus = "DSC";
            ucDdo_br_medication_rxname.SendProperty(context, "", false, Ddo_br_medication_rxname_Internalname, "SortedStatus", Ddo_br_medication_rxname_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Medication_RXNameTitleFilterData", AV20BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Medication_RXDoseTitleFilterData", AV26BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Medication_RXUnitTitleFilterData", AV28BR_Medication_RXUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Medication_RXFrequencyTitleFilterData", AV30BR_Medication_RXFrequencyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Medication_RXQuantityTitleFilterData", AV32BR_Medication_RXQuantityTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Medication_RXDaysSupplyTitleFilterData", AV34BR_Medication_RXDaysSupplyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Medication_AdmitStartDateTitleFilterData", AV42BR_Medication_AdmitStartDateTitleFilterData);
      }

      protected void E148G2( )
      {
         /* Ddo_br_medication_rxdose_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_rxdose_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S132 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV10OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_medication_rxdose_Sortedstatus = "ASC";
            ucDdo_br_medication_rxdose.SendProperty(context, "", false, Ddo_br_medication_rxdose_Internalname, "SortedStatus", Ddo_br_medication_rxdose_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_rxdose_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S132 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV10OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_medication_rxdose_Sortedstatus = "DSC";
            ucDdo_br_medication_rxdose.SendProperty(context, "", false, Ddo_br_medication_rxdose_Internalname, "SortedStatus", Ddo_br_medication_rxdose_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Medication_RXNameTitleFilterData", AV20BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Medication_RXDoseTitleFilterData", AV26BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Medication_RXUnitTitleFilterData", AV28BR_Medication_RXUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Medication_RXFrequencyTitleFilterData", AV30BR_Medication_RXFrequencyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Medication_RXQuantityTitleFilterData", AV32BR_Medication_RXQuantityTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Medication_RXDaysSupplyTitleFilterData", AV34BR_Medication_RXDaysSupplyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Medication_AdmitStartDateTitleFilterData", AV42BR_Medication_AdmitStartDateTitleFilterData);
      }

      protected void E158G2( )
      {
         /* Ddo_br_medication_rxunit_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_rxunit_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S132 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV10OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_medication_rxunit_Sortedstatus = "ASC";
            ucDdo_br_medication_rxunit.SendProperty(context, "", false, Ddo_br_medication_rxunit_Internalname, "SortedStatus", Ddo_br_medication_rxunit_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_rxunit_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S132 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV10OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_medication_rxunit_Sortedstatus = "DSC";
            ucDdo_br_medication_rxunit.SendProperty(context, "", false, Ddo_br_medication_rxunit_Internalname, "SortedStatus", Ddo_br_medication_rxunit_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_rxunit_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV70TFBR_Medication_RXUnit = Ddo_br_medication_rxunit_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV70TFBR_Medication_RXUnit", AV70TFBR_Medication_RXUnit);
            AV71TFBR_Medication_RXUnit_Sel = Ddo_br_medication_rxunit_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV71TFBR_Medication_RXUnit_Sel", AV71TFBR_Medication_RXUnit_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Medication_RXNameTitleFilterData", AV20BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Medication_RXDoseTitleFilterData", AV26BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Medication_RXUnitTitleFilterData", AV28BR_Medication_RXUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Medication_RXFrequencyTitleFilterData", AV30BR_Medication_RXFrequencyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Medication_RXQuantityTitleFilterData", AV32BR_Medication_RXQuantityTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Medication_RXDaysSupplyTitleFilterData", AV34BR_Medication_RXDaysSupplyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Medication_AdmitStartDateTitleFilterData", AV42BR_Medication_AdmitStartDateTitleFilterData);
      }

      protected void E168G2( )
      {
         /* Ddo_br_medication_rxfrequency_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_rxfrequency_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S132 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV10OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_medication_rxfrequency_Sortedstatus = "ASC";
            ucDdo_br_medication_rxfrequency.SendProperty(context, "", false, Ddo_br_medication_rxfrequency_Internalname, "SortedStatus", Ddo_br_medication_rxfrequency_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_rxfrequency_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S132 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV10OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_medication_rxfrequency_Sortedstatus = "DSC";
            ucDdo_br_medication_rxfrequency.SendProperty(context, "", false, Ddo_br_medication_rxfrequency_Internalname, "SortedStatus", Ddo_br_medication_rxfrequency_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Medication_RXNameTitleFilterData", AV20BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Medication_RXDoseTitleFilterData", AV26BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Medication_RXUnitTitleFilterData", AV28BR_Medication_RXUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Medication_RXFrequencyTitleFilterData", AV30BR_Medication_RXFrequencyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Medication_RXQuantityTitleFilterData", AV32BR_Medication_RXQuantityTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Medication_RXDaysSupplyTitleFilterData", AV34BR_Medication_RXDaysSupplyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Medication_AdmitStartDateTitleFilterData", AV42BR_Medication_AdmitStartDateTitleFilterData);
      }

      protected void E178G2( )
      {
         /* Ddo_br_medication_rxquantity_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_rxquantity_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S132 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV10OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_medication_rxquantity_Sortedstatus = "ASC";
            ucDdo_br_medication_rxquantity.SendProperty(context, "", false, Ddo_br_medication_rxquantity_Internalname, "SortedStatus", Ddo_br_medication_rxquantity_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_rxquantity_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S132 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV10OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_medication_rxquantity_Sortedstatus = "DSC";
            ucDdo_br_medication_rxquantity.SendProperty(context, "", false, Ddo_br_medication_rxquantity_Internalname, "SortedStatus", Ddo_br_medication_rxquantity_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Medication_RXNameTitleFilterData", AV20BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Medication_RXDoseTitleFilterData", AV26BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Medication_RXUnitTitleFilterData", AV28BR_Medication_RXUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Medication_RXFrequencyTitleFilterData", AV30BR_Medication_RXFrequencyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Medication_RXQuantityTitleFilterData", AV32BR_Medication_RXQuantityTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Medication_RXDaysSupplyTitleFilterData", AV34BR_Medication_RXDaysSupplyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Medication_AdmitStartDateTitleFilterData", AV42BR_Medication_AdmitStartDateTitleFilterData);
      }

      protected void E188G2( )
      {
         /* Ddo_br_medication_rxdayssupply_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_rxdayssupply_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S132 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV10OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_medication_rxdayssupply_Sortedstatus = "ASC";
            ucDdo_br_medication_rxdayssupply.SendProperty(context, "", false, Ddo_br_medication_rxdayssupply_Internalname, "SortedStatus", Ddo_br_medication_rxdayssupply_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_rxdayssupply_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S132 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV10OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_medication_rxdayssupply_Sortedstatus = "DSC";
            ucDdo_br_medication_rxdayssupply.SendProperty(context, "", false, Ddo_br_medication_rxdayssupply_Internalname, "SortedStatus", Ddo_br_medication_rxdayssupply_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Medication_RXNameTitleFilterData", AV20BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Medication_RXDoseTitleFilterData", AV26BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Medication_RXUnitTitleFilterData", AV28BR_Medication_RXUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Medication_RXFrequencyTitleFilterData", AV30BR_Medication_RXFrequencyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Medication_RXQuantityTitleFilterData", AV32BR_Medication_RXQuantityTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Medication_RXDaysSupplyTitleFilterData", AV34BR_Medication_RXDaysSupplyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Medication_AdmitStartDateTitleFilterData", AV42BR_Medication_AdmitStartDateTitleFilterData);
      }

      protected void E198G2( )
      {
         /* Ddo_br_medication_admitstartdate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_admitstartdate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S132 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV10OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_medication_admitstartdate_Sortedstatus = "ASC";
            ucDdo_br_medication_admitstartdate.SendProperty(context, "", false, Ddo_br_medication_admitstartdate_Internalname, "SortedStatus", Ddo_br_medication_admitstartdate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_admitstartdate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S132 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV10OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_medication_admitstartdate_Sortedstatus = "DSC";
            ucDdo_br_medication_admitstartdate.SendProperty(context, "", false, Ddo_br_medication_admitstartdate_Internalname, "SortedStatus", Ddo_br_medication_admitstartdate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Medication_RXNameTitleFilterData", AV20BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Medication_RXDoseTitleFilterData", AV26BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Medication_RXUnitTitleFilterData", AV28BR_Medication_RXUnitTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Medication_RXFrequencyTitleFilterData", AV30BR_Medication_RXFrequencyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Medication_RXQuantityTitleFilterData", AV32BR_Medication_RXQuantityTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Medication_RXDaysSupplyTitleFilterData", AV34BR_Medication_RXDaysSupplyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Medication_AdmitStartDateTitleFilterData", AV42BR_Medication_AdmitStartDateTitleFilterData);
      }

      private void E228G2( )
      {
         /* Grid_Load Routine */
         AV61Select = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSelect_Internalname, AV61Select);
         AV75Select_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         edtavSelect_Tooltiptext = "选择";
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 32;
         }
         sendrow_322( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_32_Refreshing )
         {
            context.DoAjaxLoad(32, GridRow);
         }
         /*  Sending Event outputs  */
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E238G2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E238G2( )
      {
         /* Enter Routine */
         AV8InOutBR_MedicationID = A119BR_MedicationID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_MedicationID), 18, 0)));
         AV65InOutBR_Medication_RXName = A121BR_Medication_RXName;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV65InOutBR_Medication_RXName", AV65InOutBR_Medication_RXName);
         AV66InOutBR_Medication_RXDose = A124BR_Medication_RXDose;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV66InOutBR_Medication_RXDose", StringUtil.LTrim( StringUtil.Str( AV66InOutBR_Medication_RXDose, 15, 5)));
         AV67InOutBR_Medication_RXUnit = A125BR_Medication_RXUnit;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV67InOutBR_Medication_RXUnit", AV67InOutBR_Medication_RXUnit);
         context.setWebReturnParms(new Object[] {(long)AV8InOutBR_MedicationID,(String)AV65InOutBR_Medication_RXName,(decimal)AV66InOutBR_Medication_RXDose,(String)AV67InOutBR_Medication_RXUnit,(String)AV65InOutBR_Medication_RXName,(decimal)AV66InOutBR_Medication_RXDose,(String)AV67InOutBR_Medication_RXUnit});
         context.setWebReturnParmsMetadata(new Object[] {"AV8InOutBR_MedicationID","AV65InOutBR_Medication_RXName","AV66InOutBR_Medication_RXDose","AV67InOutBR_Medication_RXUnit","AV65InOutBR_Medication_RXName","AV66InOutBR_Medication_RXDose","AV67InOutBR_Medication_RXUnit"});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
         /*  Sending Event outputs  */
      }

      protected void S132( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_br_medication_rxname_Sortedstatus = "";
         ucDdo_br_medication_rxname.SendProperty(context, "", false, Ddo_br_medication_rxname_Internalname, "SortedStatus", Ddo_br_medication_rxname_Sortedstatus);
         Ddo_br_medication_rxdose_Sortedstatus = "";
         ucDdo_br_medication_rxdose.SendProperty(context, "", false, Ddo_br_medication_rxdose_Internalname, "SortedStatus", Ddo_br_medication_rxdose_Sortedstatus);
         Ddo_br_medication_rxunit_Sortedstatus = "";
         ucDdo_br_medication_rxunit.SendProperty(context, "", false, Ddo_br_medication_rxunit_Internalname, "SortedStatus", Ddo_br_medication_rxunit_Sortedstatus);
         Ddo_br_medication_rxfrequency_Sortedstatus = "";
         ucDdo_br_medication_rxfrequency.SendProperty(context, "", false, Ddo_br_medication_rxfrequency_Internalname, "SortedStatus", Ddo_br_medication_rxfrequency_Sortedstatus);
         Ddo_br_medication_rxquantity_Sortedstatus = "";
         ucDdo_br_medication_rxquantity.SendProperty(context, "", false, Ddo_br_medication_rxquantity_Internalname, "SortedStatus", Ddo_br_medication_rxquantity_Sortedstatus);
         Ddo_br_medication_rxdayssupply_Sortedstatus = "";
         ucDdo_br_medication_rxdayssupply.SendProperty(context, "", false, Ddo_br_medication_rxdayssupply_Internalname, "SortedStatus", Ddo_br_medication_rxdayssupply_Sortedstatus);
         Ddo_br_medication_admitstartdate_Sortedstatus = "";
         ucDdo_br_medication_admitstartdate.SendProperty(context, "", false, Ddo_br_medication_admitstartdate_Internalname, "SortedStatus", Ddo_br_medication_admitstartdate_Sortedstatus);
      }

      protected void S112( )
      {
         /* 'SETDDOSORTEDSTATUS' Routine */
         /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         if ( AV10OrderedBy == 1 )
         {
            Ddo_br_medication_rxname_Sortedstatus = (AV11OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medication_rxname.SendProperty(context, "", false, Ddo_br_medication_rxname_Internalname, "SortedStatus", Ddo_br_medication_rxname_Sortedstatus);
         }
         else if ( AV10OrderedBy == 2 )
         {
            Ddo_br_medication_rxdose_Sortedstatus = (AV11OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medication_rxdose.SendProperty(context, "", false, Ddo_br_medication_rxdose_Internalname, "SortedStatus", Ddo_br_medication_rxdose_Sortedstatus);
         }
         else if ( AV10OrderedBy == 3 )
         {
            Ddo_br_medication_rxunit_Sortedstatus = (AV11OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medication_rxunit.SendProperty(context, "", false, Ddo_br_medication_rxunit_Internalname, "SortedStatus", Ddo_br_medication_rxunit_Sortedstatus);
         }
         else if ( AV10OrderedBy == 4 )
         {
            Ddo_br_medication_rxfrequency_Sortedstatus = (AV11OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medication_rxfrequency.SendProperty(context, "", false, Ddo_br_medication_rxfrequency_Internalname, "SortedStatus", Ddo_br_medication_rxfrequency_Sortedstatus);
         }
         else if ( AV10OrderedBy == 5 )
         {
            Ddo_br_medication_rxquantity_Sortedstatus = (AV11OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medication_rxquantity.SendProperty(context, "", false, Ddo_br_medication_rxquantity_Internalname, "SortedStatus", Ddo_br_medication_rxquantity_Sortedstatus);
         }
         else if ( AV10OrderedBy == 6 )
         {
            Ddo_br_medication_rxdayssupply_Sortedstatus = (AV11OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medication_rxdayssupply.SendProperty(context, "", false, Ddo_br_medication_rxdayssupply_Internalname, "SortedStatus", Ddo_br_medication_rxdayssupply_Sortedstatus);
         }
         else if ( AV10OrderedBy == 7 )
         {
            Ddo_br_medication_admitstartdate_Sortedstatus = (AV11OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medication_admitstartdate.SendProperty(context, "", false, Ddo_br_medication_admitstartdate_Internalname, "SortedStatus", Ddo_br_medication_admitstartdate_Sortedstatus);
         }
      }

      protected void S122( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV68GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV68GridState.gxTpr_Orderedby = AV10OrderedBy;
         AV68GridState.gxTpr_Ordereddsc = AV11OrderedDsc;
         AV68GridState.gxTpr_Filtervalues.Clear();
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV62BR_Medication_RXName)) )
         {
            AV69GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV69GridStateFilterValue.gxTpr_Name = "BR_MEDICATION_RXNAME";
            AV69GridStateFilterValue.gxTpr_Value = AV62BR_Medication_RXName;
            AV68GridState.gxTpr_Filtervalues.Add(AV69GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV70TFBR_Medication_RXUnit)) )
         {
            AV69GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV69GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_RXUNIT";
            AV69GridStateFilterValue.gxTpr_Value = AV70TFBR_Medication_RXUnit;
            AV68GridState.gxTpr_Filtervalues.Add(AV69GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV71TFBR_Medication_RXUnit_Sel)) )
         {
            AV69GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV69GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_RXUNIT_SEL";
            AV69GridStateFilterValue.gxTpr_Value = AV71TFBR_Medication_RXUnit_Sel;
            AV68GridState.gxTpr_Filtervalues.Add(AV69GridStateFilterValue, 0);
         }
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV74Pgmname+"GridState",  AV68GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV8InOutBR_MedicationID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_MedicationID), 18, 0)));
         AV65InOutBR_Medication_RXName = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV65InOutBR_Medication_RXName", AV65InOutBR_Medication_RXName);
         AV66InOutBR_Medication_RXDose = (decimal)(Convert.ToDecimal((decimal)getParm(obj,2)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV66InOutBR_Medication_RXDose", StringUtil.LTrim( StringUtil.Str( AV66InOutBR_Medication_RXDose, 15, 5)));
         AV67InOutBR_Medication_RXUnit = (String)getParm(obj,3);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV67InOutBR_Medication_RXUnit", AV67InOutBR_Medication_RXUnit);
         AV65InOutBR_Medication_RXName = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV65InOutBR_Medication_RXName", AV65InOutBR_Medication_RXName);
         AV66InOutBR_Medication_RXDose = (decimal)(Convert.ToDecimal((decimal)getParm(obj,2)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV66InOutBR_Medication_RXDose", StringUtil.LTrim( StringUtil.Str( AV66InOutBR_Medication_RXDose, 15, 5)));
         AV67InOutBR_Medication_RXUnit = (String)getParm(obj,3);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV67InOutBR_Medication_RXUnit", AV67InOutBR_Medication_RXUnit);
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
         PA8G2( ) ;
         WS8G2( ) ;
         WE8G2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020227947409", true);
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
         context.AddJavascriptSource("br_medicationpromptitl.js", "?2020227947409", false);
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

      protected void SubsflControlProps_322( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_32_idx;
         edtBR_MedicationID_Internalname = "BR_MEDICATIONID_"+sGXsfl_32_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_32_idx;
         edtBR_Medication_RXName_Internalname = "BR_MEDICATION_RXNAME_"+sGXsfl_32_idx;
         edtBR_Medication_RXDose_Internalname = "BR_MEDICATION_RXDOSE_"+sGXsfl_32_idx;
         edtBR_Medication_RXUnit_Internalname = "BR_MEDICATION_RXUNIT_"+sGXsfl_32_idx;
         edtBR_Medication_RXFrequency_Internalname = "BR_MEDICATION_RXFREQUENCY_"+sGXsfl_32_idx;
         edtBR_Medication_RXQuantity_Internalname = "BR_MEDICATION_RXQUANTITY_"+sGXsfl_32_idx;
         edtBR_Medication_RXDaysSupply_Internalname = "BR_MEDICATION_RXDAYSSUPPLY_"+sGXsfl_32_idx;
         edtBR_Medication_AdmitStartDate_Internalname = "BR_MEDICATION_ADMITSTARTDATE_"+sGXsfl_32_idx;
      }

      protected void SubsflControlProps_fel_322( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_32_fel_idx;
         edtBR_MedicationID_Internalname = "BR_MEDICATIONID_"+sGXsfl_32_fel_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_32_fel_idx;
         edtBR_Medication_RXName_Internalname = "BR_MEDICATION_RXNAME_"+sGXsfl_32_fel_idx;
         edtBR_Medication_RXDose_Internalname = "BR_MEDICATION_RXDOSE_"+sGXsfl_32_fel_idx;
         edtBR_Medication_RXUnit_Internalname = "BR_MEDICATION_RXUNIT_"+sGXsfl_32_fel_idx;
         edtBR_Medication_RXFrequency_Internalname = "BR_MEDICATION_RXFREQUENCY_"+sGXsfl_32_fel_idx;
         edtBR_Medication_RXQuantity_Internalname = "BR_MEDICATION_RXQUANTITY_"+sGXsfl_32_fel_idx;
         edtBR_Medication_RXDaysSupply_Internalname = "BR_MEDICATION_RXDAYSSUPPLY_"+sGXsfl_32_fel_idx;
         edtBR_Medication_AdmitStartDate_Internalname = "BR_MEDICATION_ADMITSTARTDATE_"+sGXsfl_32_fel_idx;
      }

      protected void sendrow_322( )
      {
         SubsflControlProps_322( ) ;
         WB8G0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_32_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_32_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_32_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavSelect_Enabled!=0)&&(edtavSelect_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 33,'',false,'',32)\"" : " ");
            ClassString = "SelectAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV61Select_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV61Select))&&String.IsNullOrEmpty(StringUtil.RTrim( AV75Select_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV61Select)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV61Select)) ? AV75Select_GXI : context.PathToRelativeUrl( AV61Select));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSelect_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSelect_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSelect_Jsonclick,"'"+""+"'"+",false,"+"'"+"EENTER."+sGXsfl_32_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV61Select_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicationID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A119BR_MedicationID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A119BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicationID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)32,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_EncounterID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_EncounterID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)32,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_RXName_Internalname,(String)A121BR_Medication_RXName,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_RXName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)32,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_RXDose_Internalname,StringUtil.LTrim( StringUtil.NToC( A124BR_Medication_RXDose, 15, 5, ".", "")),context.localUtil.Format( A124BR_Medication_RXDose, "ZZZZZZZZZ.ZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_RXDose_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)32,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_RXUnit_Internalname,(String)A125BR_Medication_RXUnit,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_RXUnit_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)32,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_RXFrequency_Internalname,(String)A126BR_Medication_RXFrequency,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_RXFrequency_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs hidden-sm",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)32,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_RXQuantity_Internalname,(String)A127BR_Medication_RXQuantity,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_RXQuantity_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs hidden-sm",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)32,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_RXDaysSupply_Internalname,StringUtil.LTrim( StringUtil.NToC( A128BR_Medication_RXDaysSupply, 15, 5, ".", "")),context.localUtil.Format( A128BR_Medication_RXDaysSupply, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_RXDaysSupply_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs hidden-sm",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)32,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_AdmitStartDate_Internalname,context.localUtil.Format(A132BR_Medication_AdmitStartDate, "9999/99/99"),context.localUtil.Format( A132BR_Medication_AdmitStartDate, "9999/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_AdmitStartDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs hidden-sm",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)32,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Date",(String)"right",(bool)false});
            send_integrity_lvl_hashes8G2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_32_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_32_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_32_idx+1));
            sGXsfl_32_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_32_idx), 4, 0)), 4, "0");
            SubsflControlProps_322( ) ;
         }
         /* End function sendrow_322 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblFiltertextbr_medication_rxname_Internalname = "FILTERTEXTBR_MEDICATION_RXNAME";
         edtavBr_medication_rxname_Internalname = "vBR_MEDICATION_RXNAME";
         divUnnamedtabler_medication_rxname_Internalname = "UNNAMEDTABLER_MEDICATION_RXNAME";
         divTableactions_Internalname = "TABLEACTIONS";
         divTableheader_Internalname = "TABLEHEADER";
         divLayout_tableheader_Internalname = "LAYOUT_TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         divHtml_dvpanel_tableheader_Internalname = "HTML_DVPANEL_TABLEHEADER";
         edtavSelect_Internalname = "vSELECT";
         edtBR_MedicationID_Internalname = "BR_MEDICATIONID";
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtBR_Medication_RXName_Internalname = "BR_MEDICATION_RXNAME";
         edtBR_Medication_RXDose_Internalname = "BR_MEDICATION_RXDOSE";
         edtBR_Medication_RXUnit_Internalname = "BR_MEDICATION_RXUNIT";
         edtBR_Medication_RXFrequency_Internalname = "BR_MEDICATION_RXFREQUENCY";
         edtBR_Medication_RXQuantity_Internalname = "BR_MEDICATION_RXQUANTITY";
         edtBR_Medication_RXDaysSupply_Internalname = "BR_MEDICATION_RXDAYSSUPPLY";
         edtBR_Medication_AdmitStartDate_Internalname = "BR_MEDICATION_ADMITSTARTDATE";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_medication_rxname_Internalname = "DDO_BR_MEDICATION_RXNAME";
         edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE";
         Ddo_br_medication_rxdose_Internalname = "DDO_BR_MEDICATION_RXDOSE";
         edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE";
         Ddo_br_medication_rxunit_Internalname = "DDO_BR_MEDICATION_RXUNIT";
         edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE";
         Ddo_br_medication_rxfrequency_Internalname = "DDO_BR_MEDICATION_RXFREQUENCY";
         edtavDdo_br_medication_rxfrequencytitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE";
         Ddo_br_medication_rxquantity_Internalname = "DDO_BR_MEDICATION_RXQUANTITY";
         edtavDdo_br_medication_rxquantitytitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE";
         Ddo_br_medication_rxdayssupply_Internalname = "DDO_BR_MEDICATION_RXDAYSSUPPLY";
         edtavDdo_br_medication_rxdayssupplytitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE";
         Ddo_br_medication_admitstartdate_Internalname = "DDO_BR_MEDICATION_ADMITSTARTDATE";
         edtavDdo_br_medication_admitstartdatetitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         edtavTfbr_medication_rxunit_Internalname = "vTFBR_MEDICATION_RXUNIT";
         edtavTfbr_medication_rxunit_sel_Internalname = "vTFBR_MEDICATION_RXUNIT_SEL";
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
         edtBR_Medication_AdmitStartDate_Jsonclick = "";
         edtBR_Medication_RXDaysSupply_Jsonclick = "";
         edtBR_Medication_RXQuantity_Jsonclick = "";
         edtBR_Medication_RXFrequency_Jsonclick = "";
         edtBR_Medication_RXUnit_Jsonclick = "";
         edtBR_Medication_RXDose_Jsonclick = "";
         edtBR_Medication_RXName_Jsonclick = "";
         edtBR_EncounterID_Jsonclick = "";
         edtBR_MedicationID_Jsonclick = "";
         edtavSelect_Jsonclick = "";
         edtavSelect_Visible = -1;
         edtavSelect_Enabled = 1;
         edtavTfbr_medication_rxunit_sel_Jsonclick = "";
         edtavTfbr_medication_rxunit_sel_Visible = 1;
         edtavTfbr_medication_rxunit_Jsonclick = "";
         edtavTfbr_medication_rxunit_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_medication_admitstartdatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medication_rxdayssupplytitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medication_rxquantitytitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medication_rxfrequencytitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavSelect_Tooltiptext = "选择";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Medication_AdmitStartDate_Titleformat = 0;
         edtBR_Medication_AdmitStartDate_Title = "服药日期";
         edtBR_Medication_RXDaysSupply_Titleformat = 0;
         edtBR_Medication_RXDaysSupply_Title = "服药天数";
         edtBR_Medication_RXQuantity_Titleformat = 0;
         edtBR_Medication_RXQuantity_Title = "用药量";
         edtBR_Medication_RXFrequency_Titleformat = 0;
         edtBR_Medication_RXFrequency_Title = "服药频率";
         edtBR_Medication_RXUnit_Titleformat = 0;
         edtBR_Medication_RXUnit_Title = "计量单位";
         edtBR_Medication_RXDose_Titleformat = 0;
         edtBR_Medication_RXDose_Title = "药物剂量";
         edtBR_Medication_RXName_Titleformat = 0;
         edtBR_Medication_RXName_Title = "药物名称";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         edtavBr_medication_rxname_Jsonclick = "";
         edtavBr_medication_rxname_Enabled = 1;
         divTablemain_Height = 0;
         Ddo_br_medication_admitstartdate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_admitstartdate_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_admitstartdate_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_admitstartdate_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medication_admitstartdate_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medication_admitstartdate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_admitstartdate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_admitstartdate_Titlecontrolidtoreplace = "";
         Ddo_br_medication_admitstartdate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_admitstartdate_Cls = "ColumnSettings";
         Ddo_br_medication_admitstartdate_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_admitstartdate_Caption = "";
         Ddo_br_medication_rxdayssupply_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_rxdayssupply_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_rxdayssupply_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_rxdayssupply_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medication_rxdayssupply_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medication_rxdayssupply_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_rxdayssupply_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_rxdayssupply_Titlecontrolidtoreplace = "";
         Ddo_br_medication_rxdayssupply_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_rxdayssupply_Cls = "ColumnSettings";
         Ddo_br_medication_rxdayssupply_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_rxdayssupply_Caption = "";
         Ddo_br_medication_rxquantity_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_rxquantity_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_rxquantity_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_rxquantity_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medication_rxquantity_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medication_rxquantity_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_rxquantity_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_rxquantity_Titlecontrolidtoreplace = "";
         Ddo_br_medication_rxquantity_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_rxquantity_Cls = "ColumnSettings";
         Ddo_br_medication_rxquantity_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_rxquantity_Caption = "";
         Ddo_br_medication_rxfrequency_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_rxfrequency_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_rxfrequency_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_rxfrequency_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medication_rxfrequency_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medication_rxfrequency_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_rxfrequency_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_rxfrequency_Titlecontrolidtoreplace = "";
         Ddo_br_medication_rxfrequency_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_rxfrequency_Cls = "ColumnSettings";
         Ddo_br_medication_rxfrequency_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_rxfrequency_Caption = "";
         Ddo_br_medication_rxunit_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_rxunit_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_medication_rxunit_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_medication_rxunit_Loadingdata = "WWP_TSLoading";
         Ddo_br_medication_rxunit_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_rxunit_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_rxunit_Datalistupdateminimumcharacters = 0;
         Ddo_br_medication_rxunit_Datalistproc = "BR_MedicationPromptGetFilterData";
         Ddo_br_medication_rxunit_Datalisttype = "Dynamic";
         Ddo_br_medication_rxunit_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_medication_rxunit_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_medication_rxunit_Filtertype = "Character";
         Ddo_br_medication_rxunit_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_medication_rxunit_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_rxunit_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_rxunit_Titlecontrolidtoreplace = "";
         Ddo_br_medication_rxunit_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_rxunit_Cls = "ColumnSettings";
         Ddo_br_medication_rxunit_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_rxunit_Caption = "";
         Ddo_br_medication_rxdose_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_rxdose_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_rxdose_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_rxdose_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medication_rxdose_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medication_rxdose_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_rxdose_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_rxdose_Titlecontrolidtoreplace = "";
         Ddo_br_medication_rxdose_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_rxdose_Cls = "ColumnSettings";
         Ddo_br_medication_rxdose_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_rxdose_Caption = "";
         Ddo_br_medication_rxname_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_rxname_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_rxname_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_rxname_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medication_rxname_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medication_rxname_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_rxname_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_rxname_Titlecontrolidtoreplace = "";
         Ddo_br_medication_rxname_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_rxname_Cls = "ColumnSettings";
         Ddo_br_medication_rxname_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_rxname_Caption = "";
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
         Form.Caption = "Data Mgmt Portal -RAAP";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV62BR_Medication_RXName',fld:'vBR_MEDICATION_RXNAME',pic:''},{av:'AV70TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV71TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV64BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV26BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV28BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'AV30BR_Medication_RXFrequencyTitleFilterData',fld:'vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXQuantityTitleFilterData',fld:'vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_RXDaysSupplyTitleFilterData',fld:'vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA',pic:''},{av:'AV42BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXUnit_Titleformat',ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'edtBR_Medication_RXUnit_Title',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'edtBR_Medication_RXFrequency_Titleformat',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Titleformat'},{av:'edtBR_Medication_RXFrequency_Title',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Title'},{av:'edtBR_Medication_RXQuantity_Titleformat',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Titleformat'},{av:'edtBR_Medication_RXQuantity_Title',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Title'},{av:'edtBR_Medication_RXDaysSupply_Titleformat',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Titleformat'},{av:'edtBR_Medication_RXDaysSupply_Title',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Title'},{av:'edtBR_Medication_AdmitStartDate_Titleformat',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'edtBR_Medication_AdmitStartDate_Title',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'AV58GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E118G2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV62BR_Medication_RXName',fld:'vBR_MEDICATION_RXNAME',pic:''},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV70TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV71TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E128G2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV62BR_Medication_RXName',fld:'vBR_MEDICATION_RXNAME',pic:''},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV70TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV71TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED","{handler:'E138G2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV62BR_Medication_RXName',fld:'vBR_MEDICATION_RXNAME',pic:''},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV70TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV71TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_br_medication_rxname_Activeeventkey',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_rxname_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'Ddo_br_medication_rxdose_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'Ddo_br_medication_rxunit_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'Ddo_br_medication_rxfrequency_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SortedStatus'},{av:'Ddo_br_medication_rxquantity_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SortedStatus'},{av:'Ddo_br_medication_rxdayssupply_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'SortedStatus'},{av:'Ddo_br_medication_admitstartdate_Sortedstatus',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'SortedStatus'},{av:'AV64BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV26BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV28BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'AV30BR_Medication_RXFrequencyTitleFilterData',fld:'vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXQuantityTitleFilterData',fld:'vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_RXDaysSupplyTitleFilterData',fld:'vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA',pic:''},{av:'AV42BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXUnit_Titleformat',ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'edtBR_Medication_RXUnit_Title',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'edtBR_Medication_RXFrequency_Titleformat',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Titleformat'},{av:'edtBR_Medication_RXFrequency_Title',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Title'},{av:'edtBR_Medication_RXQuantity_Titleformat',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Titleformat'},{av:'edtBR_Medication_RXQuantity_Title',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Title'},{av:'edtBR_Medication_RXDaysSupply_Titleformat',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Titleformat'},{av:'edtBR_Medication_RXDaysSupply_Title',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Title'},{av:'edtBR_Medication_AdmitStartDate_Titleformat',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'edtBR_Medication_AdmitStartDate_Title',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'AV58GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICATION_RXDOSE.ONOPTIONCLICKED","{handler:'E148G2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV62BR_Medication_RXName',fld:'vBR_MEDICATION_RXNAME',pic:''},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV70TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV71TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_br_medication_rxdose_Activeeventkey',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICATION_RXDOSE.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_rxdose_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'Ddo_br_medication_rxname_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'Ddo_br_medication_rxunit_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'Ddo_br_medication_rxfrequency_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SortedStatus'},{av:'Ddo_br_medication_rxquantity_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SortedStatus'},{av:'Ddo_br_medication_rxdayssupply_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'SortedStatus'},{av:'Ddo_br_medication_admitstartdate_Sortedstatus',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'SortedStatus'},{av:'AV64BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV26BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV28BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'AV30BR_Medication_RXFrequencyTitleFilterData',fld:'vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXQuantityTitleFilterData',fld:'vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_RXDaysSupplyTitleFilterData',fld:'vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA',pic:''},{av:'AV42BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXUnit_Titleformat',ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'edtBR_Medication_RXUnit_Title',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'edtBR_Medication_RXFrequency_Titleformat',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Titleformat'},{av:'edtBR_Medication_RXFrequency_Title',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Title'},{av:'edtBR_Medication_RXQuantity_Titleformat',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Titleformat'},{av:'edtBR_Medication_RXQuantity_Title',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Title'},{av:'edtBR_Medication_RXDaysSupply_Titleformat',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Titleformat'},{av:'edtBR_Medication_RXDaysSupply_Title',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Title'},{av:'edtBR_Medication_AdmitStartDate_Titleformat',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'edtBR_Medication_AdmitStartDate_Title',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'AV58GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICATION_RXUNIT.ONOPTIONCLICKED","{handler:'E158G2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV62BR_Medication_RXName',fld:'vBR_MEDICATION_RXNAME',pic:''},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV70TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV71TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_br_medication_rxunit_Activeeventkey',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'ActiveEventKey'},{av:'Ddo_br_medication_rxunit_Filteredtext_get',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'FilteredText_get'},{av:'Ddo_br_medication_rxunit_Selectedvalue_get',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_MEDICATION_RXUNIT.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_rxunit_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'AV70TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV71TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'Ddo_br_medication_rxname_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'Ddo_br_medication_rxdose_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'Ddo_br_medication_rxfrequency_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SortedStatus'},{av:'Ddo_br_medication_rxquantity_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SortedStatus'},{av:'Ddo_br_medication_rxdayssupply_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'SortedStatus'},{av:'Ddo_br_medication_admitstartdate_Sortedstatus',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'SortedStatus'},{av:'AV64BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV26BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV28BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'AV30BR_Medication_RXFrequencyTitleFilterData',fld:'vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXQuantityTitleFilterData',fld:'vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_RXDaysSupplyTitleFilterData',fld:'vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA',pic:''},{av:'AV42BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXUnit_Titleformat',ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'edtBR_Medication_RXUnit_Title',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'edtBR_Medication_RXFrequency_Titleformat',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Titleformat'},{av:'edtBR_Medication_RXFrequency_Title',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Title'},{av:'edtBR_Medication_RXQuantity_Titleformat',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Titleformat'},{av:'edtBR_Medication_RXQuantity_Title',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Title'},{av:'edtBR_Medication_RXDaysSupply_Titleformat',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Titleformat'},{av:'edtBR_Medication_RXDaysSupply_Title',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Title'},{av:'edtBR_Medication_AdmitStartDate_Titleformat',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'edtBR_Medication_AdmitStartDate_Title',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'AV58GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICATION_RXFREQUENCY.ONOPTIONCLICKED","{handler:'E168G2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV62BR_Medication_RXName',fld:'vBR_MEDICATION_RXNAME',pic:''},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV70TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV71TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_br_medication_rxfrequency_Activeeventkey',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICATION_RXFREQUENCY.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_rxfrequency_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SortedStatus'},{av:'Ddo_br_medication_rxname_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'Ddo_br_medication_rxdose_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'Ddo_br_medication_rxunit_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'Ddo_br_medication_rxquantity_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SortedStatus'},{av:'Ddo_br_medication_rxdayssupply_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'SortedStatus'},{av:'Ddo_br_medication_admitstartdate_Sortedstatus',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'SortedStatus'},{av:'AV64BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV26BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV28BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'AV30BR_Medication_RXFrequencyTitleFilterData',fld:'vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXQuantityTitleFilterData',fld:'vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_RXDaysSupplyTitleFilterData',fld:'vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA',pic:''},{av:'AV42BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXUnit_Titleformat',ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'edtBR_Medication_RXUnit_Title',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'edtBR_Medication_RXFrequency_Titleformat',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Titleformat'},{av:'edtBR_Medication_RXFrequency_Title',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Title'},{av:'edtBR_Medication_RXQuantity_Titleformat',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Titleformat'},{av:'edtBR_Medication_RXQuantity_Title',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Title'},{av:'edtBR_Medication_RXDaysSupply_Titleformat',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Titleformat'},{av:'edtBR_Medication_RXDaysSupply_Title',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Title'},{av:'edtBR_Medication_AdmitStartDate_Titleformat',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'edtBR_Medication_AdmitStartDate_Title',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'AV58GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICATION_RXQUANTITY.ONOPTIONCLICKED","{handler:'E178G2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV62BR_Medication_RXName',fld:'vBR_MEDICATION_RXNAME',pic:''},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV70TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV71TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_br_medication_rxquantity_Activeeventkey',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICATION_RXQUANTITY.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_rxquantity_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SortedStatus'},{av:'Ddo_br_medication_rxname_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'Ddo_br_medication_rxdose_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'Ddo_br_medication_rxunit_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'Ddo_br_medication_rxfrequency_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SortedStatus'},{av:'Ddo_br_medication_rxdayssupply_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'SortedStatus'},{av:'Ddo_br_medication_admitstartdate_Sortedstatus',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'SortedStatus'},{av:'AV64BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV26BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV28BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'AV30BR_Medication_RXFrequencyTitleFilterData',fld:'vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXQuantityTitleFilterData',fld:'vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_RXDaysSupplyTitleFilterData',fld:'vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA',pic:''},{av:'AV42BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXUnit_Titleformat',ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'edtBR_Medication_RXUnit_Title',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'edtBR_Medication_RXFrequency_Titleformat',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Titleformat'},{av:'edtBR_Medication_RXFrequency_Title',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Title'},{av:'edtBR_Medication_RXQuantity_Titleformat',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Titleformat'},{av:'edtBR_Medication_RXQuantity_Title',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Title'},{av:'edtBR_Medication_RXDaysSupply_Titleformat',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Titleformat'},{av:'edtBR_Medication_RXDaysSupply_Title',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Title'},{av:'edtBR_Medication_AdmitStartDate_Titleformat',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'edtBR_Medication_AdmitStartDate_Title',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'AV58GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICATION_RXDAYSSUPPLY.ONOPTIONCLICKED","{handler:'E188G2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV62BR_Medication_RXName',fld:'vBR_MEDICATION_RXNAME',pic:''},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV70TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV71TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_br_medication_rxdayssupply_Activeeventkey',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICATION_RXDAYSSUPPLY.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_rxdayssupply_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'SortedStatus'},{av:'Ddo_br_medication_rxname_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'Ddo_br_medication_rxdose_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'Ddo_br_medication_rxunit_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'Ddo_br_medication_rxfrequency_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SortedStatus'},{av:'Ddo_br_medication_rxquantity_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SortedStatus'},{av:'Ddo_br_medication_admitstartdate_Sortedstatus',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'SortedStatus'},{av:'AV64BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV26BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV28BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'AV30BR_Medication_RXFrequencyTitleFilterData',fld:'vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXQuantityTitleFilterData',fld:'vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_RXDaysSupplyTitleFilterData',fld:'vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA',pic:''},{av:'AV42BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXUnit_Titleformat',ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'edtBR_Medication_RXUnit_Title',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'edtBR_Medication_RXFrequency_Titleformat',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Titleformat'},{av:'edtBR_Medication_RXFrequency_Title',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Title'},{av:'edtBR_Medication_RXQuantity_Titleformat',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Titleformat'},{av:'edtBR_Medication_RXQuantity_Title',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Title'},{av:'edtBR_Medication_RXDaysSupply_Titleformat',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Titleformat'},{av:'edtBR_Medication_RXDaysSupply_Title',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Title'},{av:'edtBR_Medication_AdmitStartDate_Titleformat',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'edtBR_Medication_AdmitStartDate_Title',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'AV58GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICATION_ADMITSTARTDATE.ONOPTIONCLICKED","{handler:'E198G2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV62BR_Medication_RXName',fld:'vBR_MEDICATION_RXNAME',pic:''},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV70TFBR_Medication_RXUnit',fld:'vTFBR_MEDICATION_RXUNIT',pic:''},{av:'AV71TFBR_Medication_RXUnit_Sel',fld:'vTFBR_MEDICATION_RXUNIT_SEL',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV74Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_br_medication_admitstartdate_Activeeventkey',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICATION_ADMITSTARTDATE.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_admitstartdate_Sortedstatus',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'SortedStatus'},{av:'Ddo_br_medication_rxname_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'Ddo_br_medication_rxdose_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'Ddo_br_medication_rxunit_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'Ddo_br_medication_rxfrequency_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SortedStatus'},{av:'Ddo_br_medication_rxquantity_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SortedStatus'},{av:'Ddo_br_medication_rxdayssupply_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'SortedStatus'},{av:'AV64BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV26BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV28BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'AV30BR_Medication_RXFrequencyTitleFilterData',fld:'vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_RXQuantityTitleFilterData',fld:'vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_RXDaysSupplyTitleFilterData',fld:'vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA',pic:''},{av:'AV42BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXUnit_Titleformat',ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'edtBR_Medication_RXUnit_Title',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'edtBR_Medication_RXFrequency_Titleformat',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Titleformat'},{av:'edtBR_Medication_RXFrequency_Title',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Title'},{av:'edtBR_Medication_RXQuantity_Titleformat',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Titleformat'},{av:'edtBR_Medication_RXQuantity_Title',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Title'},{av:'edtBR_Medication_RXDaysSupply_Titleformat',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Titleformat'},{av:'edtBR_Medication_RXDaysSupply_Title',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Title'},{av:'edtBR_Medication_AdmitStartDate_Titleformat',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'edtBR_Medication_AdmitStartDate_Title',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'AV58GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV59GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV60GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E228G2',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV61Select',fld:'vSELECT',pic:''},{av:'edtavSelect_Tooltiptext',ctrl:'vSELECT',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E238G2',iparms:[{av:'A119BR_MedicationID',fld:'BR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A121BR_Medication_RXName',fld:'BR_MEDICATION_RXNAME',pic:'',hsh:true},{av:'A124BR_Medication_RXDose',fld:'BR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ',hsh:true},{av:'A125BR_Medication_RXUnit',fld:'BR_MEDICATION_RXUNIT',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV8InOutBR_MedicationID',fld:'vINOUTBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV65InOutBR_Medication_RXName',fld:'vINOUTBR_MEDICATION_RXNAME',pic:''},{av:'AV66InOutBR_Medication_RXDose',fld:'vINOUTBR_MEDICATION_RXDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV67InOutBR_Medication_RXUnit',fld:'vINOUTBR_MEDICATION_RXUNIT',pic:''}]}");
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
         Ddo_br_medication_rxname_Activeeventkey = "";
         Ddo_br_medication_rxdose_Activeeventkey = "";
         Ddo_br_medication_rxunit_Activeeventkey = "";
         Ddo_br_medication_rxunit_Filteredtext_get = "";
         Ddo_br_medication_rxunit_Selectedvalue_get = "";
         Ddo_br_medication_rxfrequency_Activeeventkey = "";
         Ddo_br_medication_rxquantity_Activeeventkey = "";
         Ddo_br_medication_rxdayssupply_Activeeventkey = "";
         Ddo_br_medication_admitstartdate_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV62BR_Medication_RXName = "";
         AV70TFBR_Medication_RXUnit = "";
         AV71TFBR_Medication_RXUnit_Sel = "";
         AV21ddo_BR_Medication_RXNameTitleControlIdToReplace = "";
         AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace = "";
         AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace = "";
         AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace = "";
         AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace = "";
         AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace = "";
         AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace = "";
         AV74Pgmname = "";
         GXKey = "";
         AV65InOutBR_Medication_RXName = "";
         AV67InOutBR_Medication_RXUnit = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV56DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV20BR_Medication_RXNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV26BR_Medication_RXDoseTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28BR_Medication_RXUnitTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV30BR_Medication_RXFrequencyTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32BR_Medication_RXQuantityTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV34BR_Medication_RXDaysSupplyTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV42BR_Medication_AdmitStartDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_medication_rxname_Sortedstatus = "";
         Ddo_br_medication_rxdose_Sortedstatus = "";
         Ddo_br_medication_rxunit_Sortedstatus = "";
         Ddo_br_medication_rxfrequency_Sortedstatus = "";
         Ddo_br_medication_rxquantity_Sortedstatus = "";
         Ddo_br_medication_rxdayssupply_Sortedstatus = "";
         Ddo_br_medication_admitstartdate_Sortedstatus = "";
         GX_FocusControl = "";
         sPrefix = "";
         ucDvpanel_tableheader = new GXUserControl();
         lblFiltertextbr_medication_rxname_Jsonclick = "";
         TempTags = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV61Select = "";
         A121BR_Medication_RXName = "";
         A125BR_Medication_RXUnit = "";
         A126BR_Medication_RXFrequency = "";
         A127BR_Medication_RXQuantity = "";
         A132BR_Medication_AdmitStartDate = DateTime.MinValue;
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_medication_rxname = new GXUserControl();
         ClassString = "";
         StyleString = "";
         ucDdo_br_medication_rxdose = new GXUserControl();
         ucDdo_br_medication_rxunit = new GXUserControl();
         ucDdo_br_medication_rxfrequency = new GXUserControl();
         ucDdo_br_medication_rxquantity = new GXUserControl();
         ucDdo_br_medication_rxdayssupply = new GXUserControl();
         ucDdo_br_medication_admitstartdate = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV75Select_GXI = "";
         scmdbuf = "";
         lV62BR_Medication_RXName = "";
         lV70TFBR_Medication_RXUnit = "";
         H008G2_A132BR_Medication_AdmitStartDate = new DateTime[] {DateTime.MinValue} ;
         H008G2_n132BR_Medication_AdmitStartDate = new bool[] {false} ;
         H008G2_A128BR_Medication_RXDaysSupply = new decimal[1] ;
         H008G2_n128BR_Medication_RXDaysSupply = new bool[] {false} ;
         H008G2_A127BR_Medication_RXQuantity = new String[] {""} ;
         H008G2_n127BR_Medication_RXQuantity = new bool[] {false} ;
         H008G2_A126BR_Medication_RXFrequency = new String[] {""} ;
         H008G2_n126BR_Medication_RXFrequency = new bool[] {false} ;
         H008G2_A125BR_Medication_RXUnit = new String[] {""} ;
         H008G2_n125BR_Medication_RXUnit = new bool[] {false} ;
         H008G2_A124BR_Medication_RXDose = new decimal[1] ;
         H008G2_n124BR_Medication_RXDose = new bool[] {false} ;
         H008G2_A121BR_Medication_RXName = new String[] {""} ;
         H008G2_n121BR_Medication_RXName = new bool[] {false} ;
         H008G2_A19BR_EncounterID = new long[1] ;
         H008G2_A119BR_MedicationID = new long[1] ;
         H008G3_AGRID_nRecordCount = new long[1] ;
         AV63WebSession = context.GetSession();
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         AV68GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV69GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_medicationpromptitl__default(),
            new Object[][] {
                new Object[] {
               H008G2_A132BR_Medication_AdmitStartDate, H008G2_n132BR_Medication_AdmitStartDate, H008G2_A128BR_Medication_RXDaysSupply, H008G2_n128BR_Medication_RXDaysSupply, H008G2_A127BR_Medication_RXQuantity, H008G2_n127BR_Medication_RXQuantity, H008G2_A126BR_Medication_RXFrequency, H008G2_n126BR_Medication_RXFrequency, H008G2_A125BR_Medication_RXUnit, H008G2_n125BR_Medication_RXUnit,
               H008G2_A124BR_Medication_RXDose, H008G2_n124BR_Medication_RXDose, H008G2_A121BR_Medication_RXName, H008G2_n121BR_Medication_RXName, H008G2_A19BR_EncounterID, H008G2_A119BR_MedicationID
               }
               , new Object[] {
               H008G3_AGRID_nRecordCount
               }
            }
         );
         AV74Pgmname = "BR_MedicationPromptItl";
         /* GeneXus formulas. */
         AV74Pgmname = "BR_MedicationPromptItl";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_32 ;
      private short nGXsfl_32_idx=1 ;
      private short GRID_nEOF ;
      private short AV10OrderedBy ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtBR_Medication_RXName_Titleformat ;
      private short edtBR_Medication_RXDose_Titleformat ;
      private short edtBR_Medication_RXUnit_Titleformat ;
      private short edtBR_Medication_RXFrequency_Titleformat ;
      private short edtBR_Medication_RXQuantity_Titleformat ;
      private short edtBR_Medication_RXDaysSupply_Titleformat ;
      private short edtBR_Medication_AdmitStartDate_Titleformat ;
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
      private int Ddo_br_medication_rxunit_Datalistupdateminimumcharacters ;
      private int divTablemain_Height ;
      private int edtavBr_medication_rxname_Enabled ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medication_rxfrequencytitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medication_rxquantitytitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medication_rxdayssupplytitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medication_admitstartdatetitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfbr_medication_rxunit_Visible ;
      private int edtavTfbr_medication_rxunit_sel_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV57PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavSelect_Enabled ;
      private int edtavSelect_Visible ;
      private long GRID_nFirstRecordOnPage ;
      private long AV8InOutBR_MedicationID ;
      private long AV58GridCurrentPage ;
      private long AV60GridRecordCount ;
      private long AV59GridPageSize ;
      private long A119BR_MedicationID ;
      private long A19BR_EncounterID ;
      private long GRID_nCurrentRecord ;
      private long AV64BR_EncounterID ;
      private long GRID_nRecordCount ;
      private decimal AV66InOutBR_Medication_RXDose ;
      private decimal A124BR_Medication_RXDose ;
      private decimal A128BR_Medication_RXDaysSupply ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_medication_rxname_Activeeventkey ;
      private String Ddo_br_medication_rxdose_Activeeventkey ;
      private String Ddo_br_medication_rxunit_Activeeventkey ;
      private String Ddo_br_medication_rxunit_Filteredtext_get ;
      private String Ddo_br_medication_rxunit_Selectedvalue_get ;
      private String Ddo_br_medication_rxfrequency_Activeeventkey ;
      private String Ddo_br_medication_rxquantity_Activeeventkey ;
      private String Ddo_br_medication_rxdayssupply_Activeeventkey ;
      private String Ddo_br_medication_admitstartdate_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_32_idx="0001" ;
      private String AV74Pgmname ;
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
      private String Ddo_br_medication_rxname_Caption ;
      private String Ddo_br_medication_rxname_Tooltip ;
      private String Ddo_br_medication_rxname_Cls ;
      private String Ddo_br_medication_rxname_Dropdownoptionstype ;
      private String Ddo_br_medication_rxname_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_rxname_Sortedstatus ;
      private String Ddo_br_medication_rxname_Sortasc ;
      private String Ddo_br_medication_rxname_Sortdsc ;
      private String Ddo_br_medication_rxname_Searchbuttontext ;
      private String Ddo_br_medication_rxdose_Caption ;
      private String Ddo_br_medication_rxdose_Tooltip ;
      private String Ddo_br_medication_rxdose_Cls ;
      private String Ddo_br_medication_rxdose_Dropdownoptionstype ;
      private String Ddo_br_medication_rxdose_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_rxdose_Sortedstatus ;
      private String Ddo_br_medication_rxdose_Sortasc ;
      private String Ddo_br_medication_rxdose_Sortdsc ;
      private String Ddo_br_medication_rxdose_Searchbuttontext ;
      private String Ddo_br_medication_rxunit_Caption ;
      private String Ddo_br_medication_rxunit_Tooltip ;
      private String Ddo_br_medication_rxunit_Cls ;
      private String Ddo_br_medication_rxunit_Dropdownoptionstype ;
      private String Ddo_br_medication_rxunit_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_rxunit_Sortedstatus ;
      private String Ddo_br_medication_rxunit_Filtertype ;
      private String Ddo_br_medication_rxunit_Datalisttype ;
      private String Ddo_br_medication_rxunit_Datalistproc ;
      private String Ddo_br_medication_rxunit_Sortasc ;
      private String Ddo_br_medication_rxunit_Sortdsc ;
      private String Ddo_br_medication_rxunit_Loadingdata ;
      private String Ddo_br_medication_rxunit_Cleanfilter ;
      private String Ddo_br_medication_rxunit_Noresultsfound ;
      private String Ddo_br_medication_rxunit_Searchbuttontext ;
      private String Ddo_br_medication_rxfrequency_Caption ;
      private String Ddo_br_medication_rxfrequency_Tooltip ;
      private String Ddo_br_medication_rxfrequency_Cls ;
      private String Ddo_br_medication_rxfrequency_Dropdownoptionstype ;
      private String Ddo_br_medication_rxfrequency_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_rxfrequency_Sortedstatus ;
      private String Ddo_br_medication_rxfrequency_Sortasc ;
      private String Ddo_br_medication_rxfrequency_Sortdsc ;
      private String Ddo_br_medication_rxfrequency_Searchbuttontext ;
      private String Ddo_br_medication_rxquantity_Caption ;
      private String Ddo_br_medication_rxquantity_Tooltip ;
      private String Ddo_br_medication_rxquantity_Cls ;
      private String Ddo_br_medication_rxquantity_Dropdownoptionstype ;
      private String Ddo_br_medication_rxquantity_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_rxquantity_Sortedstatus ;
      private String Ddo_br_medication_rxquantity_Sortasc ;
      private String Ddo_br_medication_rxquantity_Sortdsc ;
      private String Ddo_br_medication_rxquantity_Searchbuttontext ;
      private String Ddo_br_medication_rxdayssupply_Caption ;
      private String Ddo_br_medication_rxdayssupply_Tooltip ;
      private String Ddo_br_medication_rxdayssupply_Cls ;
      private String Ddo_br_medication_rxdayssupply_Dropdownoptionstype ;
      private String Ddo_br_medication_rxdayssupply_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_rxdayssupply_Sortedstatus ;
      private String Ddo_br_medication_rxdayssupply_Sortasc ;
      private String Ddo_br_medication_rxdayssupply_Sortdsc ;
      private String Ddo_br_medication_rxdayssupply_Searchbuttontext ;
      private String Ddo_br_medication_admitstartdate_Caption ;
      private String Ddo_br_medication_admitstartdate_Tooltip ;
      private String Ddo_br_medication_admitstartdate_Cls ;
      private String Ddo_br_medication_admitstartdate_Dropdownoptionstype ;
      private String Ddo_br_medication_admitstartdate_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_admitstartdate_Sortedstatus ;
      private String Ddo_br_medication_admitstartdate_Sortasc ;
      private String Ddo_br_medication_admitstartdate_Sortdsc ;
      private String Ddo_br_medication_admitstartdate_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divHtml_dvpanel_tableheader_Internalname ;
      private String Dvpanel_tableheader_Internalname ;
      private String divLayout_tableheader_Internalname ;
      private String divTableheader_Internalname ;
      private String divTableactions_Internalname ;
      private String divUnnamedtabler_medication_rxname_Internalname ;
      private String lblFiltertextbr_medication_rxname_Internalname ;
      private String lblFiltertextbr_medication_rxname_Jsonclick ;
      private String edtavBr_medication_rxname_Internalname ;
      private String TempTags ;
      private String edtavBr_medication_rxname_Jsonclick ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtBR_Medication_RXName_Title ;
      private String edtBR_Medication_RXDose_Title ;
      private String edtBR_Medication_RXUnit_Title ;
      private String edtBR_Medication_RXFrequency_Title ;
      private String edtBR_Medication_RXQuantity_Title ;
      private String edtBR_Medication_RXDaysSupply_Title ;
      private String edtBR_Medication_AdmitStartDate_Title ;
      private String subGrid_Header ;
      private String edtavSelect_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_medication_rxname_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medication_rxdose_Internalname ;
      private String edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medication_rxunit_Internalname ;
      private String edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medication_rxfrequency_Internalname ;
      private String edtavDdo_br_medication_rxfrequencytitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medication_rxquantity_Internalname ;
      private String edtavDdo_br_medication_rxquantitytitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medication_rxdayssupply_Internalname ;
      private String edtavDdo_br_medication_rxdayssupplytitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medication_admitstartdate_Internalname ;
      private String edtavDdo_br_medication_admitstartdatetitlecontrolidtoreplace_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavTfbr_medication_rxunit_Internalname ;
      private String edtavTfbr_medication_rxunit_Jsonclick ;
      private String edtavTfbr_medication_rxunit_sel_Internalname ;
      private String edtavTfbr_medication_rxunit_sel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavSelect_Internalname ;
      private String edtBR_MedicationID_Internalname ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_Medication_RXName_Internalname ;
      private String edtBR_Medication_RXDose_Internalname ;
      private String edtBR_Medication_RXUnit_Internalname ;
      private String edtBR_Medication_RXFrequency_Internalname ;
      private String edtBR_Medication_RXQuantity_Internalname ;
      private String edtBR_Medication_RXDaysSupply_Internalname ;
      private String edtBR_Medication_AdmitStartDate_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_32_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavSelect_Jsonclick ;
      private String ROClassString ;
      private String edtBR_MedicationID_Jsonclick ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Medication_RXName_Jsonclick ;
      private String edtBR_Medication_RXDose_Jsonclick ;
      private String edtBR_Medication_RXUnit_Jsonclick ;
      private String edtBR_Medication_RXFrequency_Jsonclick ;
      private String edtBR_Medication_RXQuantity_Jsonclick ;
      private String edtBR_Medication_RXDaysSupply_Jsonclick ;
      private String edtBR_Medication_AdmitStartDate_Jsonclick ;
      private DateTime A132BR_Medication_AdmitStartDate ;
      private bool entryPointCalled ;
      private bool AV11OrderedDsc ;
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
      private bool Ddo_br_medication_rxname_Includesortasc ;
      private bool Ddo_br_medication_rxname_Includesortdsc ;
      private bool Ddo_br_medication_rxname_Includefilter ;
      private bool Ddo_br_medication_rxname_Includedatalist ;
      private bool Ddo_br_medication_rxdose_Includesortasc ;
      private bool Ddo_br_medication_rxdose_Includesortdsc ;
      private bool Ddo_br_medication_rxdose_Includefilter ;
      private bool Ddo_br_medication_rxdose_Includedatalist ;
      private bool Ddo_br_medication_rxunit_Includesortasc ;
      private bool Ddo_br_medication_rxunit_Includesortdsc ;
      private bool Ddo_br_medication_rxunit_Includefilter ;
      private bool Ddo_br_medication_rxunit_Filterisrange ;
      private bool Ddo_br_medication_rxunit_Includedatalist ;
      private bool Ddo_br_medication_rxfrequency_Includesortasc ;
      private bool Ddo_br_medication_rxfrequency_Includesortdsc ;
      private bool Ddo_br_medication_rxfrequency_Includefilter ;
      private bool Ddo_br_medication_rxfrequency_Includedatalist ;
      private bool Ddo_br_medication_rxquantity_Includesortasc ;
      private bool Ddo_br_medication_rxquantity_Includesortdsc ;
      private bool Ddo_br_medication_rxquantity_Includefilter ;
      private bool Ddo_br_medication_rxquantity_Includedatalist ;
      private bool Ddo_br_medication_rxdayssupply_Includesortasc ;
      private bool Ddo_br_medication_rxdayssupply_Includesortdsc ;
      private bool Ddo_br_medication_rxdayssupply_Includefilter ;
      private bool Ddo_br_medication_rxdayssupply_Includedatalist ;
      private bool Ddo_br_medication_admitstartdate_Includesortasc ;
      private bool Ddo_br_medication_admitstartdate_Includesortdsc ;
      private bool Ddo_br_medication_admitstartdate_Includefilter ;
      private bool Ddo_br_medication_admitstartdate_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_32_Refreshing=false ;
      private bool n121BR_Medication_RXName ;
      private bool n124BR_Medication_RXDose ;
      private bool n125BR_Medication_RXUnit ;
      private bool n126BR_Medication_RXFrequency ;
      private bool n127BR_Medication_RXQuantity ;
      private bool n128BR_Medication_RXDaysSupply ;
      private bool n132BR_Medication_AdmitStartDate ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool gx_refresh_fired ;
      private bool AV61Select_IsBlob ;
      private String AV62BR_Medication_RXName ;
      private String AV70TFBR_Medication_RXUnit ;
      private String AV71TFBR_Medication_RXUnit_Sel ;
      private String AV21ddo_BR_Medication_RXNameTitleControlIdToReplace ;
      private String AV27ddo_BR_Medication_RXDoseTitleControlIdToReplace ;
      private String AV29ddo_BR_Medication_RXUnitTitleControlIdToReplace ;
      private String AV31ddo_BR_Medication_RXFrequencyTitleControlIdToReplace ;
      private String AV33ddo_BR_Medication_RXQuantityTitleControlIdToReplace ;
      private String AV35ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace ;
      private String AV43ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace ;
      private String AV65InOutBR_Medication_RXName ;
      private String AV67InOutBR_Medication_RXUnit ;
      private String A121BR_Medication_RXName ;
      private String A125BR_Medication_RXUnit ;
      private String A126BR_Medication_RXFrequency ;
      private String A127BR_Medication_RXQuantity ;
      private String AV75Select_GXI ;
      private String lV62BR_Medication_RXName ;
      private String lV70TFBR_Medication_RXUnit ;
      private String AV61Select ;
      private IGxSession AV63WebSession ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_medication_rxname ;
      private GXUserControl ucDdo_br_medication_rxdose ;
      private GXUserControl ucDdo_br_medication_rxunit ;
      private GXUserControl ucDdo_br_medication_rxfrequency ;
      private GXUserControl ucDdo_br_medication_rxquantity ;
      private GXUserControl ucDdo_br_medication_rxdayssupply ;
      private GXUserControl ucDdo_br_medication_admitstartdate ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private DateTime[] H008G2_A132BR_Medication_AdmitStartDate ;
      private bool[] H008G2_n132BR_Medication_AdmitStartDate ;
      private decimal[] H008G2_A128BR_Medication_RXDaysSupply ;
      private bool[] H008G2_n128BR_Medication_RXDaysSupply ;
      private String[] H008G2_A127BR_Medication_RXQuantity ;
      private bool[] H008G2_n127BR_Medication_RXQuantity ;
      private String[] H008G2_A126BR_Medication_RXFrequency ;
      private bool[] H008G2_n126BR_Medication_RXFrequency ;
      private String[] H008G2_A125BR_Medication_RXUnit ;
      private bool[] H008G2_n125BR_Medication_RXUnit ;
      private decimal[] H008G2_A124BR_Medication_RXDose ;
      private bool[] H008G2_n124BR_Medication_RXDose ;
      private String[] H008G2_A121BR_Medication_RXName ;
      private bool[] H008G2_n121BR_Medication_RXName ;
      private long[] H008G2_A19BR_EncounterID ;
      private long[] H008G2_A119BR_MedicationID ;
      private long[] H008G3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private long aP0_InOutBR_MedicationID ;
      private String aP1_InOutBR_Medication_RXName ;
      private decimal aP2_InOutBR_Medication_RXDose ;
      private String aP3_InOutBR_Medication_RXUnit ;
      private String aP4_InOutBR_Medication_RXName ;
      private decimal aP5_InOutBR_Medication_RXDose ;
      private String aP6_InOutBR_Medication_RXUnit ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV20BR_Medication_RXNameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV26BR_Medication_RXDoseTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV28BR_Medication_RXUnitTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV30BR_Medication_RXFrequencyTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV32BR_Medication_RXQuantityTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV34BR_Medication_RXDaysSupplyTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV42BR_Medication_AdmitStartDateTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV56DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV68GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV69GridStateFilterValue ;
   }

   public class br_medicationpromptitl__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H008G2( IGxContext context ,
                                             String AV62BR_Medication_RXName ,
                                             String AV71TFBR_Medication_RXUnit_Sel ,
                                             String AV70TFBR_Medication_RXUnit ,
                                             String A121BR_Medication_RXName ,
                                             String A125BR_Medication_RXUnit ,
                                             short AV10OrderedBy ,
                                             bool AV11OrderedDsc ,
                                             long A19BR_EncounterID ,
                                             long AV64BR_EncounterID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [BR_Medication_AdmitStartDate], [BR_Medication_RXDaysSupply], [BR_Medication_RXQuantity], [BR_Medication_RXFrequency], [BR_Medication_RXUnit], [BR_Medication_RXDose], [BR_Medication_RXName], [BR_EncounterID], [BR_MedicationID]";
         sFromString = " FROM [BR_Medication] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([BR_EncounterID] = @AV64BR_EncounterID)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV62BR_Medication_RXName)) )
         {
            sWhereString = sWhereString + " and ([BR_Medication_RXName] like '%' + @lV62BR_Medication_RXName + '%')";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV71TFBR_Medication_RXUnit_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV70TFBR_Medication_RXUnit)) ) )
         {
            sWhereString = sWhereString + " and ([BR_Medication_RXUnit] like @lV70TFBR_Medication_RXUnit)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV71TFBR_Medication_RXUnit_Sel)) )
         {
            sWhereString = sWhereString + " and ([BR_Medication_RXUnit] = @AV71TFBR_Medication_RXUnit_Sel)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ( AV10OrderedBy == 1 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicationID] DESC";
         }
         else if ( ( AV10OrderedBy == 1 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicationID]";
         }
         else if ( ( AV10OrderedBy == 2 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_RXDose]";
         }
         else if ( ( AV10OrderedBy == 2 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_RXDose] DESC";
         }
         else if ( ( AV10OrderedBy == 3 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_RXUnit]";
         }
         else if ( ( AV10OrderedBy == 3 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_RXUnit] DESC";
         }
         else if ( ( AV10OrderedBy == 4 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_RXFrequency]";
         }
         else if ( ( AV10OrderedBy == 4 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_RXFrequency] DESC";
         }
         else if ( ( AV10OrderedBy == 5 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_RXQuantity]";
         }
         else if ( ( AV10OrderedBy == 5 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_RXQuantity] DESC";
         }
         else if ( ( AV10OrderedBy == 6 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_RXDaysSupply]";
         }
         else if ( ( AV10OrderedBy == 6 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_RXDaysSupply] DESC";
         }
         else if ( ( AV10OrderedBy == 7 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_AdmitStartDate]";
         }
         else if ( ( AV10OrderedBy == 7 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_AdmitStartDate] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicationID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H008G3( IGxContext context ,
                                             String AV62BR_Medication_RXName ,
                                             String AV71TFBR_Medication_RXUnit_Sel ,
                                             String AV70TFBR_Medication_RXUnit ,
                                             String A121BR_Medication_RXName ,
                                             String A125BR_Medication_RXUnit ,
                                             short AV10OrderedBy ,
                                             bool AV11OrderedDsc ,
                                             long A19BR_EncounterID ,
                                             long AV64BR_EncounterID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [4] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [BR_Medication] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([BR_EncounterID] = @AV64BR_EncounterID)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV62BR_Medication_RXName)) )
         {
            sWhereString = sWhereString + " and ([BR_Medication_RXName] like '%' + @lV62BR_Medication_RXName + '%')";
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV71TFBR_Medication_RXUnit_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV70TFBR_Medication_RXUnit)) ) )
         {
            sWhereString = sWhereString + " and ([BR_Medication_RXUnit] like @lV70TFBR_Medication_RXUnit)";
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV71TFBR_Medication_RXUnit_Sel)) )
         {
            sWhereString = sWhereString + " and ([BR_Medication_RXUnit] = @AV71TFBR_Medication_RXUnit_Sel)";
         }
         else
         {
            GXv_int5[3] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
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
                     return conditional_H008G2(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (short)dynConstraints[5] , (bool)dynConstraints[6] , (long)dynConstraints[7] , (long)dynConstraints[8] );
               case 1 :
                     return conditional_H008G3(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (short)dynConstraints[5] , (bool)dynConstraints[6] , (long)dynConstraints[7] , (long)dynConstraints[8] );
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
          Object[] prmH008G2 ;
          prmH008G2 = new Object[] {
          new Object[] {"@AV64BR_EncounterID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV62BR_Medication_RXName",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV70TFBR_Medication_RXUnit",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV71TFBR_Medication_RXUnit_Sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH008G3 ;
          prmH008G3 = new Object[] {
          new Object[] {"@AV64BR_EncounterID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV62BR_Medication_RXName",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV70TFBR_Medication_RXUnit",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV71TFBR_Medication_RXUnit_Sel",SqlDbType.NVarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H008G2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH008G2,11,0,true,false )
             ,new CursorDef("H008G3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH008G3,1,0,true,false )
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
                ((DateTime[]) buf[0])[0] = rslt.getGXDate(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((decimal[]) buf[2])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((decimal[]) buf[10])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((long[]) buf[14])[0] = rslt.getLong(8) ;
                ((long[]) buf[15])[0] = rslt.getLong(9) ;
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
                   stmt.SetParameter(sIdx, (long)parms[7]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[8]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[9]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[11]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[12]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[13]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[4]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[5]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[6]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                return;
       }
    }

 }

}
