/*
               File: BR_MedicationWW
        Description:  药物治疗
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 12:0:8.84
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
   public class br_medicationww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_medicationww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_medicationww( IGxContext context )
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
               AV13OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV14OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV31TFBR_Medication_RXName = GetNextPar( );
               AV32TFBR_Medication_RXName_Sel = GetNextPar( );
               AV35TFBR_Medication_RXCode = GetNextPar( );
               AV36TFBR_Medication_RXCode_Sel = GetNextPar( );
               AV55TFBR_Medication_RXQuantity = GetNextPar( );
               AV56TFBR_Medication_RXQuantity_Sel = GetNextPar( );
               AV59TFBR_Medication_RXDaysSupply = NumberUtil.Val( GetNextPar( ), ".");
               AV60TFBR_Medication_RXDaysSupply_To = NumberUtil.Val( GetNextPar( ), ".");
               AV51TFBR_Medication_RXFrequency = GetNextPar( );
               AV122TFBR_Medication_RXFrequency_Sel = GetNextPar( );
               AV77TFBR_Medication_AdmitStartDate = context.localUtil.ParseDateParm( GetNextPar( ));
               AV78TFBR_Medication_AdmitStartDate_To = context.localUtil.ParseDateParm( GetNextPar( ));
               AV33ddo_BR_Medication_RXNameTitleControlIdToReplace = GetNextPar( );
               AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace = GetNextPar( );
               AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace = GetNextPar( );
               AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace = GetNextPar( );
               AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace = GetNextPar( );
               AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace = GetNextPar( );
               AV141Pgmname = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV31TFBR_Medication_RXName, AV32TFBR_Medication_RXName_Sel, AV35TFBR_Medication_RXCode, AV36TFBR_Medication_RXCode_Sel, AV55TFBR_Medication_RXQuantity, AV56TFBR_Medication_RXQuantity_Sel, AV59TFBR_Medication_RXDaysSupply, AV60TFBR_Medication_RXDaysSupply_To, AV51TFBR_Medication_RXFrequency, AV122TFBR_Medication_RXFrequency_Sel, AV77TFBR_Medication_AdmitStartDate, AV78TFBR_Medication_AdmitStartDate_To, AV33ddo_BR_Medication_RXNameTitleControlIdToReplace, AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace, AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace, AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace, AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace, AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace, AV141Pgmname) ;
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
         PA3K2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START3K2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2020227120914", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_medicationww.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_RXNAME", AV31TFBR_Medication_RXName);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_RXNAME_SEL", AV32TFBR_Medication_RXName_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_RXCODE", AV35TFBR_Medication_RXCode);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_RXCODE_SEL", AV36TFBR_Medication_RXCode_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_RXQUANTITY", AV55TFBR_Medication_RXQuantity);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_RXQUANTITY_SEL", AV56TFBR_Medication_RXQuantity_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_RXDAYSSUPPLY", StringUtil.LTrim( StringUtil.NToC( AV59TFBR_Medication_RXDaysSupply, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_RXDAYSSUPPLY_TO", StringUtil.LTrim( StringUtil.NToC( AV60TFBR_Medication_RXDaysSupply_To, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_RXFREQUENCY", AV51TFBR_Medication_RXFrequency);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_RXFREQUENCY_SEL", AV122TFBR_Medication_RXFrequency_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_ADMITSTARTDATE", context.localUtil.Format(AV77TFBR_Medication_AdmitStartDate, "9999/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_MEDICATION_ADMITSTARTDATE_TO", context.localUtil.Format(AV78TFBR_Medication_AdmitStartDate_To, "9999/99/99"));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_12", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_12), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV110GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV112GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV111GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV108DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV108DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_RXNAMETITLEFILTERDATA", AV30BR_Medication_RXNameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_RXNAMETITLEFILTERDATA", AV30BR_Medication_RXNameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_RXCODETITLEFILTERDATA", AV34BR_Medication_RXCodeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_RXCODETITLEFILTERDATA", AV34BR_Medication_RXCodeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA", AV54BR_Medication_RXQuantityTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA", AV54BR_Medication_RXQuantityTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA", AV58BR_Medication_RXDaysSupplyTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA", AV58BR_Medication_RXDaysSupplyTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA", AV50BR_Medication_RXFrequencyTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA", AV50BR_Medication_RXFrequencyTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA", AV76BR_Medication_AdmitStartDateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA", AV76BR_Medication_AdmitStartDateTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV141Pgmname));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Caption", StringUtil.RTrim( Ddo_br_medication_rxname_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Tooltip", StringUtil.RTrim( Ddo_br_medication_rxname_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Cls", StringUtil.RTrim( Ddo_br_medication_rxname_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Filteredtext_set", StringUtil.RTrim( Ddo_br_medication_rxname_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Selectedvalue_set", StringUtil.RTrim( Ddo_br_medication_rxname_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_rxname_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_rxname_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_rxname_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_rxname_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_rxname_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_rxname_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Filtertype", StringUtil.RTrim( Ddo_br_medication_rxname_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Filterisrange", StringUtil.BoolToStr( Ddo_br_medication_rxname_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_rxname_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Datalisttype", StringUtil.RTrim( Ddo_br_medication_rxname_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Datalistproc", StringUtil.RTrim( Ddo_br_medication_rxname_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_medication_rxname_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Sortasc", StringUtil.RTrim( Ddo_br_medication_rxname_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Sortdsc", StringUtil.RTrim( Ddo_br_medication_rxname_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Loadingdata", StringUtil.RTrim( Ddo_br_medication_rxname_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Cleanfilter", StringUtil.RTrim( Ddo_br_medication_rxname_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Noresultsfound", StringUtil.RTrim( Ddo_br_medication_rxname_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_rxname_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXCODE_Caption", StringUtil.RTrim( Ddo_br_medication_rxcode_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXCODE_Tooltip", StringUtil.RTrim( Ddo_br_medication_rxcode_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXCODE_Cls", StringUtil.RTrim( Ddo_br_medication_rxcode_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXCODE_Filteredtext_set", StringUtil.RTrim( Ddo_br_medication_rxcode_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXCODE_Selectedvalue_set", StringUtil.RTrim( Ddo_br_medication_rxcode_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXCODE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_rxcode_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXCODE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_rxcode_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXCODE_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_rxcode_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXCODE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_rxcode_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXCODE_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_rxcode_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXCODE_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_rxcode_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXCODE_Filtertype", StringUtil.RTrim( Ddo_br_medication_rxcode_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXCODE_Filterisrange", StringUtil.BoolToStr( Ddo_br_medication_rxcode_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXCODE_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_rxcode_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXCODE_Datalisttype", StringUtil.RTrim( Ddo_br_medication_rxcode_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXCODE_Datalistproc", StringUtil.RTrim( Ddo_br_medication_rxcode_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXCODE_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_medication_rxcode_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXCODE_Sortasc", StringUtil.RTrim( Ddo_br_medication_rxcode_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXCODE_Sortdsc", StringUtil.RTrim( Ddo_br_medication_rxcode_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXCODE_Loadingdata", StringUtil.RTrim( Ddo_br_medication_rxcode_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXCODE_Cleanfilter", StringUtil.RTrim( Ddo_br_medication_rxcode_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXCODE_Noresultsfound", StringUtil.RTrim( Ddo_br_medication_rxcode_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXCODE_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_rxcode_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Caption", StringUtil.RTrim( Ddo_br_medication_rxquantity_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Tooltip", StringUtil.RTrim( Ddo_br_medication_rxquantity_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Cls", StringUtil.RTrim( Ddo_br_medication_rxquantity_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Filteredtext_set", StringUtil.RTrim( Ddo_br_medication_rxquantity_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Selectedvalue_set", StringUtil.RTrim( Ddo_br_medication_rxquantity_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_rxquantity_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_rxquantity_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_rxquantity_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_rxquantity_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_rxquantity_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_rxquantity_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Filtertype", StringUtil.RTrim( Ddo_br_medication_rxquantity_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Filterisrange", StringUtil.BoolToStr( Ddo_br_medication_rxquantity_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_rxquantity_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Datalisttype", StringUtil.RTrim( Ddo_br_medication_rxquantity_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Datalistproc", StringUtil.RTrim( Ddo_br_medication_rxquantity_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_medication_rxquantity_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Sortasc", StringUtil.RTrim( Ddo_br_medication_rxquantity_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Sortdsc", StringUtil.RTrim( Ddo_br_medication_rxquantity_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Loadingdata", StringUtil.RTrim( Ddo_br_medication_rxquantity_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Cleanfilter", StringUtil.RTrim( Ddo_br_medication_rxquantity_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Noresultsfound", StringUtil.RTrim( Ddo_br_medication_rxquantity_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_rxquantity_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Caption", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Tooltip", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Cls", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Filteredtext_set", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Filteredtextto_set", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_rxdayssupply_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_rxdayssupply_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_rxdayssupply_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Filtertype", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Filterisrange", StringUtil.BoolToStr( Ddo_br_medication_rxdayssupply_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_rxdayssupply_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Sortasc", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Sortdsc", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Cleanfilter", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Rangefilterfrom", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Rangefilterto", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Caption", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Tooltip", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Cls", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Filteredtext_set", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Selectedvalue_set", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_rxfrequency_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_rxfrequency_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_rxfrequency_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Filtertype", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Filterisrange", StringUtil.BoolToStr( Ddo_br_medication_rxfrequency_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_rxfrequency_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Datalisttype", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Datalistproc", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_medication_rxfrequency_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Sortasc", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Sortdsc", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Loadingdata", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Cleanfilter", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Noresultsfound", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Caption", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Tooltip", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Cls", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Filteredtext_set", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Filteredtextto_set", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_admitstartdate_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_admitstartdate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_admitstartdate_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Filtertype", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Filterisrange", StringUtil.BoolToStr( Ddo_br_medication_admitstartdate_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_admitstartdate_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Sortasc", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Sortdsc", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Cleanfilter", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Rangefilterfrom", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Rangefilterto", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxname_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_rxname_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medication_rxname_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXCODE_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxcode_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXCODE_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_rxcode_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXCODE_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medication_rxcode_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxquantity_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_rxquantity_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medication_rxquantity_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Filteredtextto_get", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxname_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_rxname_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medication_rxname_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXCODE_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxcode_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXCODE_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_rxcode_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXCODE_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medication_rxcode_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxquantity_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_rxquantity_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXQUANTITY_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medication_rxquantity_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDAYSSUPPLY_Filteredtextto_get", StringUtil.RTrim( Ddo_br_medication_rxdayssupply_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXFREQUENCY_Selectedvalue_get", StringUtil.RTrim( Ddo_br_medication_rxfrequency_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Filteredtext_get", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_ADMITSTARTDATE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Filteredtextto_get));
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
            WE3K2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT3K2( ) ;
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
         return formatLink("br_medicationww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "BR_MedicationWW" ;
      }

      public override String GetPgmdesc( )
      {
         return " 药物治疗" ;
      }

      protected void WB3K0( )
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
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "TableMain", "left", "top", "", "", "div");
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "药物治疗主键") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "就诊信息主键") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(410), 4, 0))+"px"+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "患者编号") ;
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Medication_RXCode_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Medication_RXCode_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Medication_RXCode_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV113Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A119BR_MedicationID), 18, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A36BR_Information_PatientNo);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A121BR_Medication_RXName);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Medication_RXName_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Medication_RXName_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A122BR_Medication_RXCode);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Medication_RXCode_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Medication_RXCode_Titleformat), 4, 0, ".", "")));
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
               GridColumn.AddObjectProperty("Value", A126BR_Medication_RXFrequency);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Medication_RXFrequency_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Medication_RXFrequency_Titleformat), 4, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV110GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV112GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV111GridPageSize);
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
            ucDdo_br_medication_rxname.SetProperty("FilterType", Ddo_br_medication_rxname_Filtertype);
            ucDdo_br_medication_rxname.SetProperty("FilterIsRange", Ddo_br_medication_rxname_Filterisrange);
            ucDdo_br_medication_rxname.SetProperty("IncludeDataList", Ddo_br_medication_rxname_Includedatalist);
            ucDdo_br_medication_rxname.SetProperty("DataListType", Ddo_br_medication_rxname_Datalisttype);
            ucDdo_br_medication_rxname.SetProperty("DataListProc", Ddo_br_medication_rxname_Datalistproc);
            ucDdo_br_medication_rxname.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_medication_rxname_Datalistupdateminimumcharacters);
            ucDdo_br_medication_rxname.SetProperty("SortASC", Ddo_br_medication_rxname_Sortasc);
            ucDdo_br_medication_rxname.SetProperty("SortDSC", Ddo_br_medication_rxname_Sortdsc);
            ucDdo_br_medication_rxname.SetProperty("LoadingData", Ddo_br_medication_rxname_Loadingdata);
            ucDdo_br_medication_rxname.SetProperty("CleanFilter", Ddo_br_medication_rxname_Cleanfilter);
            ucDdo_br_medication_rxname.SetProperty("NoResultsFound", Ddo_br_medication_rxname_Noresultsfound);
            ucDdo_br_medication_rxname.SetProperty("SearchButtonText", Ddo_br_medication_rxname_Searchbuttontext);
            ucDdo_br_medication_rxname.SetProperty("DropDownOptionsTitleSettingsIcons", AV108DDO_TitleSettingsIcons);
            ucDdo_br_medication_rxname.SetProperty("DropDownOptionsData", AV30BR_Medication_RXNameTitleFilterData);
            ucDdo_br_medication_rxname.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_rxname_Internalname, "DDO_BR_MEDICATION_RXNAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Internalname, AV33ddo_BR_Medication_RXNameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,31);\"", 0, edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicationWW.htm");
            /* User Defined Control */
            ucDdo_br_medication_rxcode.SetProperty("Caption", Ddo_br_medication_rxcode_Caption);
            ucDdo_br_medication_rxcode.SetProperty("Tooltip", Ddo_br_medication_rxcode_Tooltip);
            ucDdo_br_medication_rxcode.SetProperty("Cls", Ddo_br_medication_rxcode_Cls);
            ucDdo_br_medication_rxcode.SetProperty("DropDownOptionsType", Ddo_br_medication_rxcode_Dropdownoptionstype);
            ucDdo_br_medication_rxcode.SetProperty("IncludeSortASC", Ddo_br_medication_rxcode_Includesortasc);
            ucDdo_br_medication_rxcode.SetProperty("IncludeSortDSC", Ddo_br_medication_rxcode_Includesortdsc);
            ucDdo_br_medication_rxcode.SetProperty("IncludeFilter", Ddo_br_medication_rxcode_Includefilter);
            ucDdo_br_medication_rxcode.SetProperty("FilterType", Ddo_br_medication_rxcode_Filtertype);
            ucDdo_br_medication_rxcode.SetProperty("FilterIsRange", Ddo_br_medication_rxcode_Filterisrange);
            ucDdo_br_medication_rxcode.SetProperty("IncludeDataList", Ddo_br_medication_rxcode_Includedatalist);
            ucDdo_br_medication_rxcode.SetProperty("DataListType", Ddo_br_medication_rxcode_Datalisttype);
            ucDdo_br_medication_rxcode.SetProperty("DataListProc", Ddo_br_medication_rxcode_Datalistproc);
            ucDdo_br_medication_rxcode.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_medication_rxcode_Datalistupdateminimumcharacters);
            ucDdo_br_medication_rxcode.SetProperty("SortASC", Ddo_br_medication_rxcode_Sortasc);
            ucDdo_br_medication_rxcode.SetProperty("SortDSC", Ddo_br_medication_rxcode_Sortdsc);
            ucDdo_br_medication_rxcode.SetProperty("LoadingData", Ddo_br_medication_rxcode_Loadingdata);
            ucDdo_br_medication_rxcode.SetProperty("CleanFilter", Ddo_br_medication_rxcode_Cleanfilter);
            ucDdo_br_medication_rxcode.SetProperty("NoResultsFound", Ddo_br_medication_rxcode_Noresultsfound);
            ucDdo_br_medication_rxcode.SetProperty("SearchButtonText", Ddo_br_medication_rxcode_Searchbuttontext);
            ucDdo_br_medication_rxcode.SetProperty("DropDownOptionsTitleSettingsIcons", AV108DDO_TitleSettingsIcons);
            ucDdo_br_medication_rxcode.SetProperty("DropDownOptionsData", AV34BR_Medication_RXCodeTitleFilterData);
            ucDdo_br_medication_rxcode.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_rxcode_Internalname, "DDO_BR_MEDICATION_RXCODEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_rxcodetitlecontrolidtoreplace_Internalname, AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", 0, edtavDdo_br_medication_rxcodetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicationWW.htm");
            /* User Defined Control */
            ucDdo_br_medication_rxquantity.SetProperty("Caption", Ddo_br_medication_rxquantity_Caption);
            ucDdo_br_medication_rxquantity.SetProperty("Tooltip", Ddo_br_medication_rxquantity_Tooltip);
            ucDdo_br_medication_rxquantity.SetProperty("Cls", Ddo_br_medication_rxquantity_Cls);
            ucDdo_br_medication_rxquantity.SetProperty("DropDownOptionsType", Ddo_br_medication_rxquantity_Dropdownoptionstype);
            ucDdo_br_medication_rxquantity.SetProperty("IncludeSortASC", Ddo_br_medication_rxquantity_Includesortasc);
            ucDdo_br_medication_rxquantity.SetProperty("IncludeSortDSC", Ddo_br_medication_rxquantity_Includesortdsc);
            ucDdo_br_medication_rxquantity.SetProperty("IncludeFilter", Ddo_br_medication_rxquantity_Includefilter);
            ucDdo_br_medication_rxquantity.SetProperty("FilterType", Ddo_br_medication_rxquantity_Filtertype);
            ucDdo_br_medication_rxquantity.SetProperty("FilterIsRange", Ddo_br_medication_rxquantity_Filterisrange);
            ucDdo_br_medication_rxquantity.SetProperty("IncludeDataList", Ddo_br_medication_rxquantity_Includedatalist);
            ucDdo_br_medication_rxquantity.SetProperty("DataListType", Ddo_br_medication_rxquantity_Datalisttype);
            ucDdo_br_medication_rxquantity.SetProperty("DataListProc", Ddo_br_medication_rxquantity_Datalistproc);
            ucDdo_br_medication_rxquantity.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_medication_rxquantity_Datalistupdateminimumcharacters);
            ucDdo_br_medication_rxquantity.SetProperty("SortASC", Ddo_br_medication_rxquantity_Sortasc);
            ucDdo_br_medication_rxquantity.SetProperty("SortDSC", Ddo_br_medication_rxquantity_Sortdsc);
            ucDdo_br_medication_rxquantity.SetProperty("LoadingData", Ddo_br_medication_rxquantity_Loadingdata);
            ucDdo_br_medication_rxquantity.SetProperty("CleanFilter", Ddo_br_medication_rxquantity_Cleanfilter);
            ucDdo_br_medication_rxquantity.SetProperty("NoResultsFound", Ddo_br_medication_rxquantity_Noresultsfound);
            ucDdo_br_medication_rxquantity.SetProperty("SearchButtonText", Ddo_br_medication_rxquantity_Searchbuttontext);
            ucDdo_br_medication_rxquantity.SetProperty("DropDownOptionsTitleSettingsIcons", AV108DDO_TitleSettingsIcons);
            ucDdo_br_medication_rxquantity.SetProperty("DropDownOptionsData", AV54BR_Medication_RXQuantityTitleFilterData);
            ucDdo_br_medication_rxquantity.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_rxquantity_Internalname, "DDO_BR_MEDICATION_RXQUANTITYContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_rxquantitytitlecontrolidtoreplace_Internalname, AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,35);\"", 0, edtavDdo_br_medication_rxquantitytitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicationWW.htm");
            /* User Defined Control */
            ucDdo_br_medication_rxdayssupply.SetProperty("Caption", Ddo_br_medication_rxdayssupply_Caption);
            ucDdo_br_medication_rxdayssupply.SetProperty("Tooltip", Ddo_br_medication_rxdayssupply_Tooltip);
            ucDdo_br_medication_rxdayssupply.SetProperty("Cls", Ddo_br_medication_rxdayssupply_Cls);
            ucDdo_br_medication_rxdayssupply.SetProperty("DropDownOptionsType", Ddo_br_medication_rxdayssupply_Dropdownoptionstype);
            ucDdo_br_medication_rxdayssupply.SetProperty("IncludeSortASC", Ddo_br_medication_rxdayssupply_Includesortasc);
            ucDdo_br_medication_rxdayssupply.SetProperty("IncludeSortDSC", Ddo_br_medication_rxdayssupply_Includesortdsc);
            ucDdo_br_medication_rxdayssupply.SetProperty("IncludeFilter", Ddo_br_medication_rxdayssupply_Includefilter);
            ucDdo_br_medication_rxdayssupply.SetProperty("FilterType", Ddo_br_medication_rxdayssupply_Filtertype);
            ucDdo_br_medication_rxdayssupply.SetProperty("FilterIsRange", Ddo_br_medication_rxdayssupply_Filterisrange);
            ucDdo_br_medication_rxdayssupply.SetProperty("IncludeDataList", Ddo_br_medication_rxdayssupply_Includedatalist);
            ucDdo_br_medication_rxdayssupply.SetProperty("SortASC", Ddo_br_medication_rxdayssupply_Sortasc);
            ucDdo_br_medication_rxdayssupply.SetProperty("SortDSC", Ddo_br_medication_rxdayssupply_Sortdsc);
            ucDdo_br_medication_rxdayssupply.SetProperty("CleanFilter", Ddo_br_medication_rxdayssupply_Cleanfilter);
            ucDdo_br_medication_rxdayssupply.SetProperty("RangeFilterFrom", Ddo_br_medication_rxdayssupply_Rangefilterfrom);
            ucDdo_br_medication_rxdayssupply.SetProperty("RangeFilterTo", Ddo_br_medication_rxdayssupply_Rangefilterto);
            ucDdo_br_medication_rxdayssupply.SetProperty("SearchButtonText", Ddo_br_medication_rxdayssupply_Searchbuttontext);
            ucDdo_br_medication_rxdayssupply.SetProperty("DropDownOptionsTitleSettingsIcons", AV108DDO_TitleSettingsIcons);
            ucDdo_br_medication_rxdayssupply.SetProperty("DropDownOptionsData", AV58BR_Medication_RXDaysSupplyTitleFilterData);
            ucDdo_br_medication_rxdayssupply.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_rxdayssupply_Internalname, "DDO_BR_MEDICATION_RXDAYSSUPPLYContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_rxdayssupplytitlecontrolidtoreplace_Internalname, AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", 0, edtavDdo_br_medication_rxdayssupplytitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicationWW.htm");
            /* User Defined Control */
            ucDdo_br_medication_rxfrequency.SetProperty("Caption", Ddo_br_medication_rxfrequency_Caption);
            ucDdo_br_medication_rxfrequency.SetProperty("Tooltip", Ddo_br_medication_rxfrequency_Tooltip);
            ucDdo_br_medication_rxfrequency.SetProperty("Cls", Ddo_br_medication_rxfrequency_Cls);
            ucDdo_br_medication_rxfrequency.SetProperty("DropDownOptionsType", Ddo_br_medication_rxfrequency_Dropdownoptionstype);
            ucDdo_br_medication_rxfrequency.SetProperty("IncludeSortASC", Ddo_br_medication_rxfrequency_Includesortasc);
            ucDdo_br_medication_rxfrequency.SetProperty("IncludeSortDSC", Ddo_br_medication_rxfrequency_Includesortdsc);
            ucDdo_br_medication_rxfrequency.SetProperty("IncludeFilter", Ddo_br_medication_rxfrequency_Includefilter);
            ucDdo_br_medication_rxfrequency.SetProperty("FilterType", Ddo_br_medication_rxfrequency_Filtertype);
            ucDdo_br_medication_rxfrequency.SetProperty("FilterIsRange", Ddo_br_medication_rxfrequency_Filterisrange);
            ucDdo_br_medication_rxfrequency.SetProperty("IncludeDataList", Ddo_br_medication_rxfrequency_Includedatalist);
            ucDdo_br_medication_rxfrequency.SetProperty("DataListType", Ddo_br_medication_rxfrequency_Datalisttype);
            ucDdo_br_medication_rxfrequency.SetProperty("DataListProc", Ddo_br_medication_rxfrequency_Datalistproc);
            ucDdo_br_medication_rxfrequency.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_medication_rxfrequency_Datalistupdateminimumcharacters);
            ucDdo_br_medication_rxfrequency.SetProperty("SortASC", Ddo_br_medication_rxfrequency_Sortasc);
            ucDdo_br_medication_rxfrequency.SetProperty("SortDSC", Ddo_br_medication_rxfrequency_Sortdsc);
            ucDdo_br_medication_rxfrequency.SetProperty("LoadingData", Ddo_br_medication_rxfrequency_Loadingdata);
            ucDdo_br_medication_rxfrequency.SetProperty("CleanFilter", Ddo_br_medication_rxfrequency_Cleanfilter);
            ucDdo_br_medication_rxfrequency.SetProperty("NoResultsFound", Ddo_br_medication_rxfrequency_Noresultsfound);
            ucDdo_br_medication_rxfrequency.SetProperty("SearchButtonText", Ddo_br_medication_rxfrequency_Searchbuttontext);
            ucDdo_br_medication_rxfrequency.SetProperty("DropDownOptionsTitleSettingsIcons", AV108DDO_TitleSettingsIcons);
            ucDdo_br_medication_rxfrequency.SetProperty("DropDownOptionsData", AV50BR_Medication_RXFrequencyTitleFilterData);
            ucDdo_br_medication_rxfrequency.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_rxfrequency_Internalname, "DDO_BR_MEDICATION_RXFREQUENCYContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_rxfrequencytitlecontrolidtoreplace_Internalname, AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", 0, edtavDdo_br_medication_rxfrequencytitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicationWW.htm");
            /* User Defined Control */
            ucDdo_br_medication_admitstartdate.SetProperty("Caption", Ddo_br_medication_admitstartdate_Caption);
            ucDdo_br_medication_admitstartdate.SetProperty("Tooltip", Ddo_br_medication_admitstartdate_Tooltip);
            ucDdo_br_medication_admitstartdate.SetProperty("Cls", Ddo_br_medication_admitstartdate_Cls);
            ucDdo_br_medication_admitstartdate.SetProperty("DropDownOptionsType", Ddo_br_medication_admitstartdate_Dropdownoptionstype);
            ucDdo_br_medication_admitstartdate.SetProperty("IncludeSortASC", Ddo_br_medication_admitstartdate_Includesortasc);
            ucDdo_br_medication_admitstartdate.SetProperty("IncludeSortDSC", Ddo_br_medication_admitstartdate_Includesortdsc);
            ucDdo_br_medication_admitstartdate.SetProperty("IncludeFilter", Ddo_br_medication_admitstartdate_Includefilter);
            ucDdo_br_medication_admitstartdate.SetProperty("FilterType", Ddo_br_medication_admitstartdate_Filtertype);
            ucDdo_br_medication_admitstartdate.SetProperty("FilterIsRange", Ddo_br_medication_admitstartdate_Filterisrange);
            ucDdo_br_medication_admitstartdate.SetProperty("IncludeDataList", Ddo_br_medication_admitstartdate_Includedatalist);
            ucDdo_br_medication_admitstartdate.SetProperty("SortASC", Ddo_br_medication_admitstartdate_Sortasc);
            ucDdo_br_medication_admitstartdate.SetProperty("SortDSC", Ddo_br_medication_admitstartdate_Sortdsc);
            ucDdo_br_medication_admitstartdate.SetProperty("CleanFilter", Ddo_br_medication_admitstartdate_Cleanfilter);
            ucDdo_br_medication_admitstartdate.SetProperty("RangeFilterFrom", Ddo_br_medication_admitstartdate_Rangefilterfrom);
            ucDdo_br_medication_admitstartdate.SetProperty("RangeFilterTo", Ddo_br_medication_admitstartdate_Rangefilterto);
            ucDdo_br_medication_admitstartdate.SetProperty("SearchButtonText", Ddo_br_medication_admitstartdate_Searchbuttontext);
            ucDdo_br_medication_admitstartdate.SetProperty("DropDownOptionsTitleSettingsIcons", AV108DDO_TitleSettingsIcons);
            ucDdo_br_medication_admitstartdate.SetProperty("DropDownOptionsData", AV76BR_Medication_AdmitStartDateTitleFilterData);
            ucDdo_br_medication_admitstartdate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_admitstartdate_Internalname, "DDO_BR_MEDICATION_ADMITSTARTDATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_admitstartdatetitlecontrolidtoreplace_Internalname, AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,41);\"", 0, edtavDdo_br_medication_admitstartdatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicationWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicationWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_MedicationWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_rxname_Internalname, AV31TFBR_Medication_RXName, StringUtil.RTrim( context.localUtil.Format( AV31TFBR_Medication_RXName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_rxname_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_rxname_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicationWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_rxname_sel_Internalname, AV32TFBR_Medication_RXName_Sel, StringUtil.RTrim( context.localUtil.Format( AV32TFBR_Medication_RXName_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_rxname_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_rxname_sel_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicationWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_rxcode_Internalname, AV35TFBR_Medication_RXCode, StringUtil.RTrim( context.localUtil.Format( AV35TFBR_Medication_RXCode, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,47);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_rxcode_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_rxcode_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicationWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_rxcode_sel_Internalname, AV36TFBR_Medication_RXCode_Sel, StringUtil.RTrim( context.localUtil.Format( AV36TFBR_Medication_RXCode_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_rxcode_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_rxcode_sel_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicationWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_rxquantity_Internalname, AV55TFBR_Medication_RXQuantity, StringUtil.RTrim( context.localUtil.Format( AV55TFBR_Medication_RXQuantity, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_rxquantity_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_rxquantity_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicationWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_rxquantity_sel_Internalname, AV56TFBR_Medication_RXQuantity_Sel, StringUtil.RTrim( context.localUtil.Format( AV56TFBR_Medication_RXQuantity_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_rxquantity_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_rxquantity_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicationWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_rxdayssupply_Internalname, StringUtil.LTrim( StringUtil.NToC( AV59TFBR_Medication_RXDaysSupply, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV59TFBR_Medication_RXDaysSupply, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_rxdayssupply_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_rxdayssupply_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicationWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_rxdayssupply_to_Internalname, StringUtil.LTrim( StringUtil.NToC( AV60TFBR_Medication_RXDaysSupply_To, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV60TFBR_Medication_RXDaysSupply_To, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_rxdayssupply_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_rxdayssupply_to_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicationWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_rxfrequency_Internalname, AV51TFBR_Medication_RXFrequency, StringUtil.RTrim( context.localUtil.Format( AV51TFBR_Medication_RXFrequency, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_rxfrequency_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_rxfrequency_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicationWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_rxfrequency_sel_Internalname, AV122TFBR_Medication_RXFrequency_Sel, StringUtil.RTrim( context.localUtil.Format( AV122TFBR_Medication_RXFrequency_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_rxfrequency_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_rxfrequency_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicationWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'" + sGXsfl_12_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfbr_medication_admitstartdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_admitstartdate_Internalname, context.localUtil.Format(AV77TFBR_Medication_AdmitStartDate, "9999/99/99"), context.localUtil.Format( AV77TFBR_Medication_AdmitStartDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_admitstartdate_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_admitstartdate_Visible, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicationWW.htm");
            GxWebStd.gx_bitmap( context, edtavTfbr_medication_admitstartdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfbr_medication_admitstartdate_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_MedicationWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_12_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfbr_medication_admitstartdate_to_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfbr_medication_admitstartdate_to_Internalname, context.localUtil.Format(AV78TFBR_Medication_AdmitStartDate_To, "9999/99/99"), context.localUtil.Format( AV78TFBR_Medication_AdmitStartDate_To, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_medication_admitstartdate_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_medication_admitstartdate_to_Visible, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicationWW.htm");
            GxWebStd.gx_bitmap( context, edtavTfbr_medication_admitstartdate_to_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfbr_medication_admitstartdate_to_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_MedicationWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divDdo_br_medication_admitstartdateauxdates_Internalname, 1, 0, "px", 0, "px", "Invisible", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'" + sGXsfl_12_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_br_medication_admitstartdateauxdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_br_medication_admitstartdateauxdate_Internalname, context.localUtil.Format(AV79DDO_BR_Medication_AdmitStartDateAuxDate, "9999/99/99"), context.localUtil.Format( AV79DDO_BR_Medication_AdmitStartDateAuxDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_br_medication_admitstartdateauxdate_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicationWW.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_br_medication_admitstartdateauxdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_MedicationWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'" + sGXsfl_12_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_br_medication_admitstartdateauxdateto_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_br_medication_admitstartdateauxdateto_Internalname, context.localUtil.Format(AV80DDO_BR_Medication_AdmitStartDateAuxDateTo, "9999/99/99"), context.localUtil.Format( AV80DDO_BR_Medication_AdmitStartDateAuxDateTo, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_br_medication_admitstartdateauxdateto_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicationWW.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_br_medication_admitstartdateauxdateto_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_MedicationWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
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

      protected void START3K2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", " 药物治疗", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP3K0( ) ;
      }

      protected void WS3K2( )
      {
         START3K2( ) ;
         EVT3K2( ) ;
      }

      protected void EVT3K2( )
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
                              E113K2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E123K2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E133K2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_RXCODE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E143K2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_RXQUANTITY.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E153K2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_RXDAYSSUPPLY.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E163K2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_RXFREQUENCY.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E173K2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_ADMITSTARTDATE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E183K2 ();
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
                              nGXsfl_12_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
                              SubsflControlProps_122( ) ;
                              AV113Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV113Display)) ? AV140Display_GXI : context.convertURL( context.PathToRelativeUrl( AV113Display))), !bGXsfl_12_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV113Display), true);
                              A119BR_MedicationID = (long)(context.localUtil.CToN( cgiGet( edtBR_MedicationID_Internalname), ".", ","));
                              A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
                              A36BR_Information_PatientNo = cgiGet( edtBR_Information_PatientNo_Internalname);
                              n36BR_Information_PatientNo = false;
                              A121BR_Medication_RXName = cgiGet( edtBR_Medication_RXName_Internalname);
                              n121BR_Medication_RXName = false;
                              A122BR_Medication_RXCode = cgiGet( edtBR_Medication_RXCode_Internalname);
                              n122BR_Medication_RXCode = false;
                              A127BR_Medication_RXQuantity = cgiGet( edtBR_Medication_RXQuantity_Internalname);
                              n127BR_Medication_RXQuantity = false;
                              A128BR_Medication_RXDaysSupply = context.localUtil.CToN( cgiGet( edtBR_Medication_RXDaysSupply_Internalname), ".", ",");
                              n128BR_Medication_RXDaysSupply = false;
                              A126BR_Medication_RXFrequency = cgiGet( edtBR_Medication_RXFrequency_Internalname);
                              n126BR_Medication_RXFrequency = false;
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
                                    E193K2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E203K2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E213K2 ();
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
                                       /* Set Refresh If Tfbr_medication_rxname Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_RXNAME"), AV31TFBR_Medication_RXName) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_rxname_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_RXNAME_SEL"), AV32TFBR_Medication_RXName_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_rxcode Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_RXCODE"), AV35TFBR_Medication_RXCode) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_rxcode_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_RXCODE_SEL"), AV36TFBR_Medication_RXCode_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_rxquantity Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_RXQUANTITY"), AV55TFBR_Medication_RXQuantity) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_rxquantity_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_RXQUANTITY_SEL"), AV56TFBR_Medication_RXQuantity_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_rxdayssupply Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATION_RXDAYSSUPPLY"), ".", ",") != AV59TFBR_Medication_RXDaysSupply )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_rxdayssupply_to Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATION_RXDAYSSUPPLY_TO"), ".", ",") != AV60TFBR_Medication_RXDaysSupply_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_rxfrequency Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_RXFREQUENCY"), AV51TFBR_Medication_RXFrequency) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_rxfrequency_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_RXFREQUENCY_SEL"), AV122TFBR_Medication_RXFrequency_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_admitstartdate Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFBR_MEDICATION_ADMITSTARTDATE"), 0) != AV77TFBR_Medication_AdmitStartDate )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_medication_admitstartdate_to Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFBR_MEDICATION_ADMITSTARTDATE_TO"), 0) != AV78TFBR_Medication_AdmitStartDate_To )
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

      protected void WE3K2( )
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

      protected void PA3K2( )
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
               GX_FocusControl = edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Internalname;
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
                                       short AV13OrderedBy ,
                                       bool AV14OrderedDsc ,
                                       String AV31TFBR_Medication_RXName ,
                                       String AV32TFBR_Medication_RXName_Sel ,
                                       String AV35TFBR_Medication_RXCode ,
                                       String AV36TFBR_Medication_RXCode_Sel ,
                                       String AV55TFBR_Medication_RXQuantity ,
                                       String AV56TFBR_Medication_RXQuantity_Sel ,
                                       decimal AV59TFBR_Medication_RXDaysSupply ,
                                       decimal AV60TFBR_Medication_RXDaysSupply_To ,
                                       String AV51TFBR_Medication_RXFrequency ,
                                       String AV122TFBR_Medication_RXFrequency_Sel ,
                                       DateTime AV77TFBR_Medication_AdmitStartDate ,
                                       DateTime AV78TFBR_Medication_AdmitStartDate_To ,
                                       String AV33ddo_BR_Medication_RXNameTitleControlIdToReplace ,
                                       String AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace ,
                                       String AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace ,
                                       String AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace ,
                                       String AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace ,
                                       String AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace ,
                                       String AV141Pgmname )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF3K2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
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
         RF3K2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV141Pgmname = "BR_MedicationWW";
         context.Gx_err = 0;
      }

      protected void RF3K2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 12;
         /* Execute user event: Refresh */
         E203K2 ();
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
                                                 AV129BR_MedicationWWDS_2_Tfbr_medication_rxname_sel ,
                                                 AV128BR_MedicationWWDS_1_Tfbr_medication_rxname ,
                                                 AV131BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel ,
                                                 AV130BR_MedicationWWDS_3_Tfbr_medication_rxcode ,
                                                 AV133BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel ,
                                                 AV132BR_MedicationWWDS_5_Tfbr_medication_rxquantity ,
                                                 AV134BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply ,
                                                 AV135BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to ,
                                                 AV137BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel ,
                                                 AV136BR_MedicationWWDS_9_Tfbr_medication_rxfrequency ,
                                                 AV138BR_MedicationWWDS_11_Tfbr_medication_admitstartdate ,
                                                 AV139BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to ,
                                                 A121BR_Medication_RXName ,
                                                 A122BR_Medication_RXCode ,
                                                 A127BR_Medication_RXQuantity ,
                                                 A128BR_Medication_RXDaysSupply ,
                                                 A126BR_Medication_RXFrequency ,
                                                 A132BR_Medication_AdmitStartDate ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING,
                                                 TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN,
                                                 TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV128BR_MedicationWWDS_1_Tfbr_medication_rxname = StringUtil.Concat( StringUtil.RTrim( AV128BR_MedicationWWDS_1_Tfbr_medication_rxname), "%", "");
            lV130BR_MedicationWWDS_3_Tfbr_medication_rxcode = StringUtil.Concat( StringUtil.RTrim( AV130BR_MedicationWWDS_3_Tfbr_medication_rxcode), "%", "");
            lV132BR_MedicationWWDS_5_Tfbr_medication_rxquantity = StringUtil.Concat( StringUtil.RTrim( AV132BR_MedicationWWDS_5_Tfbr_medication_rxquantity), "%", "");
            lV136BR_MedicationWWDS_9_Tfbr_medication_rxfrequency = StringUtil.Concat( StringUtil.RTrim( AV136BR_MedicationWWDS_9_Tfbr_medication_rxfrequency), "%", "");
            /* Using cursor H003K2 */
            pr_default.execute(0, new Object[] {lV128BR_MedicationWWDS_1_Tfbr_medication_rxname, AV129BR_MedicationWWDS_2_Tfbr_medication_rxname_sel, lV130BR_MedicationWWDS_3_Tfbr_medication_rxcode, AV131BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel, lV132BR_MedicationWWDS_5_Tfbr_medication_rxquantity, AV133BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel, AV134BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply, AV135BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to, lV136BR_MedicationWWDS_9_Tfbr_medication_rxfrequency, AV137BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel, AV138BR_MedicationWWDS_11_Tfbr_medication_admitstartdate, AV139BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_12_idx = 1;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A85BR_Information_ID = H003K2_A85BR_Information_ID[0];
               n85BR_Information_ID = H003K2_n85BR_Information_ID[0];
               A132BR_Medication_AdmitStartDate = H003K2_A132BR_Medication_AdmitStartDate[0];
               n132BR_Medication_AdmitStartDate = H003K2_n132BR_Medication_AdmitStartDate[0];
               A126BR_Medication_RXFrequency = H003K2_A126BR_Medication_RXFrequency[0];
               n126BR_Medication_RXFrequency = H003K2_n126BR_Medication_RXFrequency[0];
               A128BR_Medication_RXDaysSupply = H003K2_A128BR_Medication_RXDaysSupply[0];
               n128BR_Medication_RXDaysSupply = H003K2_n128BR_Medication_RXDaysSupply[0];
               A127BR_Medication_RXQuantity = H003K2_A127BR_Medication_RXQuantity[0];
               n127BR_Medication_RXQuantity = H003K2_n127BR_Medication_RXQuantity[0];
               A122BR_Medication_RXCode = H003K2_A122BR_Medication_RXCode[0];
               n122BR_Medication_RXCode = H003K2_n122BR_Medication_RXCode[0];
               A121BR_Medication_RXName = H003K2_A121BR_Medication_RXName[0];
               n121BR_Medication_RXName = H003K2_n121BR_Medication_RXName[0];
               A36BR_Information_PatientNo = H003K2_A36BR_Information_PatientNo[0];
               n36BR_Information_PatientNo = H003K2_n36BR_Information_PatientNo[0];
               A19BR_EncounterID = H003K2_A19BR_EncounterID[0];
               A119BR_MedicationID = H003K2_A119BR_MedicationID[0];
               A85BR_Information_ID = H003K2_A85BR_Information_ID[0];
               n85BR_Information_ID = H003K2_n85BR_Information_ID[0];
               A36BR_Information_PatientNo = H003K2_A36BR_Information_PatientNo[0];
               n36BR_Information_PatientNo = H003K2_n36BR_Information_PatientNo[0];
               E213K2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 12;
            WB3K0( ) ;
         }
         bGXsfl_12_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes3K2( )
      {
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
         AV128BR_MedicationWWDS_1_Tfbr_medication_rxname = AV31TFBR_Medication_RXName;
         AV129BR_MedicationWWDS_2_Tfbr_medication_rxname_sel = AV32TFBR_Medication_RXName_Sel;
         AV130BR_MedicationWWDS_3_Tfbr_medication_rxcode = AV35TFBR_Medication_RXCode;
         AV131BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel = AV36TFBR_Medication_RXCode_Sel;
         AV132BR_MedicationWWDS_5_Tfbr_medication_rxquantity = AV55TFBR_Medication_RXQuantity;
         AV133BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel = AV56TFBR_Medication_RXQuantity_Sel;
         AV134BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply = AV59TFBR_Medication_RXDaysSupply;
         AV135BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to = AV60TFBR_Medication_RXDaysSupply_To;
         AV136BR_MedicationWWDS_9_Tfbr_medication_rxfrequency = AV51TFBR_Medication_RXFrequency;
         AV137BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel = AV122TFBR_Medication_RXFrequency_Sel;
         AV138BR_MedicationWWDS_11_Tfbr_medication_admitstartdate = AV77TFBR_Medication_AdmitStartDate;
         AV139BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to = AV78TFBR_Medication_AdmitStartDate_To;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV129BR_MedicationWWDS_2_Tfbr_medication_rxname_sel ,
                                              AV128BR_MedicationWWDS_1_Tfbr_medication_rxname ,
                                              AV131BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel ,
                                              AV130BR_MedicationWWDS_3_Tfbr_medication_rxcode ,
                                              AV133BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel ,
                                              AV132BR_MedicationWWDS_5_Tfbr_medication_rxquantity ,
                                              AV134BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply ,
                                              AV135BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to ,
                                              AV137BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel ,
                                              AV136BR_MedicationWWDS_9_Tfbr_medication_rxfrequency ,
                                              AV138BR_MedicationWWDS_11_Tfbr_medication_admitstartdate ,
                                              AV139BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to ,
                                              A121BR_Medication_RXName ,
                                              A122BR_Medication_RXCode ,
                                              A127BR_Medication_RXQuantity ,
                                              A128BR_Medication_RXDaysSupply ,
                                              A126BR_Medication_RXFrequency ,
                                              A132BR_Medication_AdmitStartDate ,
                                              AV13OrderedBy ,
                                              AV14OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV128BR_MedicationWWDS_1_Tfbr_medication_rxname = StringUtil.Concat( StringUtil.RTrim( AV128BR_MedicationWWDS_1_Tfbr_medication_rxname), "%", "");
         lV130BR_MedicationWWDS_3_Tfbr_medication_rxcode = StringUtil.Concat( StringUtil.RTrim( AV130BR_MedicationWWDS_3_Tfbr_medication_rxcode), "%", "");
         lV132BR_MedicationWWDS_5_Tfbr_medication_rxquantity = StringUtil.Concat( StringUtil.RTrim( AV132BR_MedicationWWDS_5_Tfbr_medication_rxquantity), "%", "");
         lV136BR_MedicationWWDS_9_Tfbr_medication_rxfrequency = StringUtil.Concat( StringUtil.RTrim( AV136BR_MedicationWWDS_9_Tfbr_medication_rxfrequency), "%", "");
         /* Using cursor H003K3 */
         pr_default.execute(1, new Object[] {lV128BR_MedicationWWDS_1_Tfbr_medication_rxname, AV129BR_MedicationWWDS_2_Tfbr_medication_rxname_sel, lV130BR_MedicationWWDS_3_Tfbr_medication_rxcode, AV131BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel, lV132BR_MedicationWWDS_5_Tfbr_medication_rxquantity, AV133BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel, AV134BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply, AV135BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to, lV136BR_MedicationWWDS_9_Tfbr_medication_rxfrequency, AV137BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel, AV138BR_MedicationWWDS_11_Tfbr_medication_admitstartdate, AV139BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to});
         GRID_nRecordCount = H003K3_AGRID_nRecordCount[0];
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
         AV128BR_MedicationWWDS_1_Tfbr_medication_rxname = AV31TFBR_Medication_RXName;
         AV129BR_MedicationWWDS_2_Tfbr_medication_rxname_sel = AV32TFBR_Medication_RXName_Sel;
         AV130BR_MedicationWWDS_3_Tfbr_medication_rxcode = AV35TFBR_Medication_RXCode;
         AV131BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel = AV36TFBR_Medication_RXCode_Sel;
         AV132BR_MedicationWWDS_5_Tfbr_medication_rxquantity = AV55TFBR_Medication_RXQuantity;
         AV133BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel = AV56TFBR_Medication_RXQuantity_Sel;
         AV134BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply = AV59TFBR_Medication_RXDaysSupply;
         AV135BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to = AV60TFBR_Medication_RXDaysSupply_To;
         AV136BR_MedicationWWDS_9_Tfbr_medication_rxfrequency = AV51TFBR_Medication_RXFrequency;
         AV137BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel = AV122TFBR_Medication_RXFrequency_Sel;
         AV138BR_MedicationWWDS_11_Tfbr_medication_admitstartdate = AV77TFBR_Medication_AdmitStartDate;
         AV139BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to = AV78TFBR_Medication_AdmitStartDate_To;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV31TFBR_Medication_RXName, AV32TFBR_Medication_RXName_Sel, AV35TFBR_Medication_RXCode, AV36TFBR_Medication_RXCode_Sel, AV55TFBR_Medication_RXQuantity, AV56TFBR_Medication_RXQuantity_Sel, AV59TFBR_Medication_RXDaysSupply, AV60TFBR_Medication_RXDaysSupply_To, AV51TFBR_Medication_RXFrequency, AV122TFBR_Medication_RXFrequency_Sel, AV77TFBR_Medication_AdmitStartDate, AV78TFBR_Medication_AdmitStartDate_To, AV33ddo_BR_Medication_RXNameTitleControlIdToReplace, AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace, AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace, AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace, AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace, AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace, AV141Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV128BR_MedicationWWDS_1_Tfbr_medication_rxname = AV31TFBR_Medication_RXName;
         AV129BR_MedicationWWDS_2_Tfbr_medication_rxname_sel = AV32TFBR_Medication_RXName_Sel;
         AV130BR_MedicationWWDS_3_Tfbr_medication_rxcode = AV35TFBR_Medication_RXCode;
         AV131BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel = AV36TFBR_Medication_RXCode_Sel;
         AV132BR_MedicationWWDS_5_Tfbr_medication_rxquantity = AV55TFBR_Medication_RXQuantity;
         AV133BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel = AV56TFBR_Medication_RXQuantity_Sel;
         AV134BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply = AV59TFBR_Medication_RXDaysSupply;
         AV135BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to = AV60TFBR_Medication_RXDaysSupply_To;
         AV136BR_MedicationWWDS_9_Tfbr_medication_rxfrequency = AV51TFBR_Medication_RXFrequency;
         AV137BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel = AV122TFBR_Medication_RXFrequency_Sel;
         AV138BR_MedicationWWDS_11_Tfbr_medication_admitstartdate = AV77TFBR_Medication_AdmitStartDate;
         AV139BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to = AV78TFBR_Medication_AdmitStartDate_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV31TFBR_Medication_RXName, AV32TFBR_Medication_RXName_Sel, AV35TFBR_Medication_RXCode, AV36TFBR_Medication_RXCode_Sel, AV55TFBR_Medication_RXQuantity, AV56TFBR_Medication_RXQuantity_Sel, AV59TFBR_Medication_RXDaysSupply, AV60TFBR_Medication_RXDaysSupply_To, AV51TFBR_Medication_RXFrequency, AV122TFBR_Medication_RXFrequency_Sel, AV77TFBR_Medication_AdmitStartDate, AV78TFBR_Medication_AdmitStartDate_To, AV33ddo_BR_Medication_RXNameTitleControlIdToReplace, AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace, AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace, AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace, AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace, AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace, AV141Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV128BR_MedicationWWDS_1_Tfbr_medication_rxname = AV31TFBR_Medication_RXName;
         AV129BR_MedicationWWDS_2_Tfbr_medication_rxname_sel = AV32TFBR_Medication_RXName_Sel;
         AV130BR_MedicationWWDS_3_Tfbr_medication_rxcode = AV35TFBR_Medication_RXCode;
         AV131BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel = AV36TFBR_Medication_RXCode_Sel;
         AV132BR_MedicationWWDS_5_Tfbr_medication_rxquantity = AV55TFBR_Medication_RXQuantity;
         AV133BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel = AV56TFBR_Medication_RXQuantity_Sel;
         AV134BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply = AV59TFBR_Medication_RXDaysSupply;
         AV135BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to = AV60TFBR_Medication_RXDaysSupply_To;
         AV136BR_MedicationWWDS_9_Tfbr_medication_rxfrequency = AV51TFBR_Medication_RXFrequency;
         AV137BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel = AV122TFBR_Medication_RXFrequency_Sel;
         AV138BR_MedicationWWDS_11_Tfbr_medication_admitstartdate = AV77TFBR_Medication_AdmitStartDate;
         AV139BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to = AV78TFBR_Medication_AdmitStartDate_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV31TFBR_Medication_RXName, AV32TFBR_Medication_RXName_Sel, AV35TFBR_Medication_RXCode, AV36TFBR_Medication_RXCode_Sel, AV55TFBR_Medication_RXQuantity, AV56TFBR_Medication_RXQuantity_Sel, AV59TFBR_Medication_RXDaysSupply, AV60TFBR_Medication_RXDaysSupply_To, AV51TFBR_Medication_RXFrequency, AV122TFBR_Medication_RXFrequency_Sel, AV77TFBR_Medication_AdmitStartDate, AV78TFBR_Medication_AdmitStartDate_To, AV33ddo_BR_Medication_RXNameTitleControlIdToReplace, AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace, AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace, AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace, AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace, AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace, AV141Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV128BR_MedicationWWDS_1_Tfbr_medication_rxname = AV31TFBR_Medication_RXName;
         AV129BR_MedicationWWDS_2_Tfbr_medication_rxname_sel = AV32TFBR_Medication_RXName_Sel;
         AV130BR_MedicationWWDS_3_Tfbr_medication_rxcode = AV35TFBR_Medication_RXCode;
         AV131BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel = AV36TFBR_Medication_RXCode_Sel;
         AV132BR_MedicationWWDS_5_Tfbr_medication_rxquantity = AV55TFBR_Medication_RXQuantity;
         AV133BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel = AV56TFBR_Medication_RXQuantity_Sel;
         AV134BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply = AV59TFBR_Medication_RXDaysSupply;
         AV135BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to = AV60TFBR_Medication_RXDaysSupply_To;
         AV136BR_MedicationWWDS_9_Tfbr_medication_rxfrequency = AV51TFBR_Medication_RXFrequency;
         AV137BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel = AV122TFBR_Medication_RXFrequency_Sel;
         AV138BR_MedicationWWDS_11_Tfbr_medication_admitstartdate = AV77TFBR_Medication_AdmitStartDate;
         AV139BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to = AV78TFBR_Medication_AdmitStartDate_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV31TFBR_Medication_RXName, AV32TFBR_Medication_RXName_Sel, AV35TFBR_Medication_RXCode, AV36TFBR_Medication_RXCode_Sel, AV55TFBR_Medication_RXQuantity, AV56TFBR_Medication_RXQuantity_Sel, AV59TFBR_Medication_RXDaysSupply, AV60TFBR_Medication_RXDaysSupply_To, AV51TFBR_Medication_RXFrequency, AV122TFBR_Medication_RXFrequency_Sel, AV77TFBR_Medication_AdmitStartDate, AV78TFBR_Medication_AdmitStartDate_To, AV33ddo_BR_Medication_RXNameTitleControlIdToReplace, AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace, AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace, AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace, AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace, AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace, AV141Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV128BR_MedicationWWDS_1_Tfbr_medication_rxname = AV31TFBR_Medication_RXName;
         AV129BR_MedicationWWDS_2_Tfbr_medication_rxname_sel = AV32TFBR_Medication_RXName_Sel;
         AV130BR_MedicationWWDS_3_Tfbr_medication_rxcode = AV35TFBR_Medication_RXCode;
         AV131BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel = AV36TFBR_Medication_RXCode_Sel;
         AV132BR_MedicationWWDS_5_Tfbr_medication_rxquantity = AV55TFBR_Medication_RXQuantity;
         AV133BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel = AV56TFBR_Medication_RXQuantity_Sel;
         AV134BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply = AV59TFBR_Medication_RXDaysSupply;
         AV135BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to = AV60TFBR_Medication_RXDaysSupply_To;
         AV136BR_MedicationWWDS_9_Tfbr_medication_rxfrequency = AV51TFBR_Medication_RXFrequency;
         AV137BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel = AV122TFBR_Medication_RXFrequency_Sel;
         AV138BR_MedicationWWDS_11_Tfbr_medication_admitstartdate = AV77TFBR_Medication_AdmitStartDate;
         AV139BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to = AV78TFBR_Medication_AdmitStartDate_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV31TFBR_Medication_RXName, AV32TFBR_Medication_RXName_Sel, AV35TFBR_Medication_RXCode, AV36TFBR_Medication_RXCode_Sel, AV55TFBR_Medication_RXQuantity, AV56TFBR_Medication_RXQuantity_Sel, AV59TFBR_Medication_RXDaysSupply, AV60TFBR_Medication_RXDaysSupply_To, AV51TFBR_Medication_RXFrequency, AV122TFBR_Medication_RXFrequency_Sel, AV77TFBR_Medication_AdmitStartDate, AV78TFBR_Medication_AdmitStartDate_To, AV33ddo_BR_Medication_RXNameTitleControlIdToReplace, AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace, AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace, AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace, AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace, AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace, AV141Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP3K0( )
      {
         /* Before Start, stand alone formulas. */
         AV141Pgmname = "BR_MedicationWW";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E193K2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV108DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_RXNAMETITLEFILTERDATA"), AV30BR_Medication_RXNameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_RXCODETITLEFILTERDATA"), AV34BR_Medication_RXCodeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA"), AV54BR_Medication_RXQuantityTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA"), AV58BR_Medication_RXDaysSupplyTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA"), AV50BR_Medication_RXFrequencyTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA"), AV76BR_Medication_AdmitStartDateTitleFilterData);
            /* Read variables values. */
            AV33ddo_BR_Medication_RXNameTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33ddo_BR_Medication_RXNameTitleControlIdToReplace", AV33ddo_BR_Medication_RXNameTitleControlIdToReplace);
            AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_rxcodetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace", AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace);
            AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_rxquantitytitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace", AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace);
            AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_rxdayssupplytitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace", AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace);
            AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_rxfrequencytitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace", AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace);
            AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_admitstartdatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace", AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace);
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
            AV31TFBR_Medication_RXName = cgiGet( edtavTfbr_medication_rxname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31TFBR_Medication_RXName", AV31TFBR_Medication_RXName);
            AV32TFBR_Medication_RXName_Sel = cgiGet( edtavTfbr_medication_rxname_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32TFBR_Medication_RXName_Sel", AV32TFBR_Medication_RXName_Sel);
            AV35TFBR_Medication_RXCode = cgiGet( edtavTfbr_medication_rxcode_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35TFBR_Medication_RXCode", AV35TFBR_Medication_RXCode);
            AV36TFBR_Medication_RXCode_Sel = cgiGet( edtavTfbr_medication_rxcode_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36TFBR_Medication_RXCode_Sel", AV36TFBR_Medication_RXCode_Sel);
            AV55TFBR_Medication_RXQuantity = cgiGet( edtavTfbr_medication_rxquantity_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV55TFBR_Medication_RXQuantity", AV55TFBR_Medication_RXQuantity);
            AV56TFBR_Medication_RXQuantity_Sel = cgiGet( edtavTfbr_medication_rxquantity_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56TFBR_Medication_RXQuantity_Sel", AV56TFBR_Medication_RXQuantity_Sel);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_rxdayssupply_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_rxdayssupply_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_MEDICATION_RXDAYSSUPPLY");
               GX_FocusControl = edtavTfbr_medication_rxdayssupply_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV59TFBR_Medication_RXDaysSupply = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59TFBR_Medication_RXDaysSupply", StringUtil.LTrim( StringUtil.Str( AV59TFBR_Medication_RXDaysSupply, 15, 5)));
            }
            else
            {
               AV59TFBR_Medication_RXDaysSupply = context.localUtil.CToN( cgiGet( edtavTfbr_medication_rxdayssupply_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59TFBR_Medication_RXDaysSupply", StringUtil.LTrim( StringUtil.Str( AV59TFBR_Medication_RXDaysSupply, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_rxdayssupply_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_medication_rxdayssupply_to_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_MEDICATION_RXDAYSSUPPLY_TO");
               GX_FocusControl = edtavTfbr_medication_rxdayssupply_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV60TFBR_Medication_RXDaysSupply_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60TFBR_Medication_RXDaysSupply_To", StringUtil.LTrim( StringUtil.Str( AV60TFBR_Medication_RXDaysSupply_To, 15, 5)));
            }
            else
            {
               AV60TFBR_Medication_RXDaysSupply_To = context.localUtil.CToN( cgiGet( edtavTfbr_medication_rxdayssupply_to_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60TFBR_Medication_RXDaysSupply_To", StringUtil.LTrim( StringUtil.Str( AV60TFBR_Medication_RXDaysSupply_To, 15, 5)));
            }
            AV51TFBR_Medication_RXFrequency = cgiGet( edtavTfbr_medication_rxfrequency_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51TFBR_Medication_RXFrequency", AV51TFBR_Medication_RXFrequency);
            AV122TFBR_Medication_RXFrequency_Sel = cgiGet( edtavTfbr_medication_rxfrequency_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV122TFBR_Medication_RXFrequency_Sel", AV122TFBR_Medication_RXFrequency_Sel);
            if ( context.localUtil.VCDate( cgiGet( edtavTfbr_medication_admitstartdate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TFBR_Medication_Admit Start Date"}), 1, "vTFBR_MEDICATION_ADMITSTARTDATE");
               GX_FocusControl = edtavTfbr_medication_admitstartdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV77TFBR_Medication_AdmitStartDate = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV77TFBR_Medication_AdmitStartDate", context.localUtil.Format(AV77TFBR_Medication_AdmitStartDate, "9999/99/99"));
            }
            else
            {
               AV77TFBR_Medication_AdmitStartDate = context.localUtil.CToD( cgiGet( edtavTfbr_medication_admitstartdate_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV77TFBR_Medication_AdmitStartDate", context.localUtil.Format(AV77TFBR_Medication_AdmitStartDate, "9999/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavTfbr_medication_admitstartdate_to_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TFBR_Medication_Admit Start Date_To"}), 1, "vTFBR_MEDICATION_ADMITSTARTDATE_TO");
               GX_FocusControl = edtavTfbr_medication_admitstartdate_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV78TFBR_Medication_AdmitStartDate_To = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV78TFBR_Medication_AdmitStartDate_To", context.localUtil.Format(AV78TFBR_Medication_AdmitStartDate_To, "9999/99/99"));
            }
            else
            {
               AV78TFBR_Medication_AdmitStartDate_To = context.localUtil.CToD( cgiGet( edtavTfbr_medication_admitstartdate_to_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV78TFBR_Medication_AdmitStartDate_To", context.localUtil.Format(AV78TFBR_Medication_AdmitStartDate_To, "9999/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_br_medication_admitstartdateauxdate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_BR_Medication_Admit Start Date Aux Date"}), 1, "vDDO_BR_MEDICATION_ADMITSTARTDATEAUXDATE");
               GX_FocusControl = edtavDdo_br_medication_admitstartdateauxdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV79DDO_BR_Medication_AdmitStartDateAuxDate = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV79DDO_BR_Medication_AdmitStartDateAuxDate", context.localUtil.Format(AV79DDO_BR_Medication_AdmitStartDateAuxDate, "9999/99/99"));
            }
            else
            {
               AV79DDO_BR_Medication_AdmitStartDateAuxDate = context.localUtil.CToD( cgiGet( edtavDdo_br_medication_admitstartdateauxdate_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV79DDO_BR_Medication_AdmitStartDateAuxDate", context.localUtil.Format(AV79DDO_BR_Medication_AdmitStartDateAuxDate, "9999/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_br_medication_admitstartdateauxdateto_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_BR_Medication_Admit Start Date Aux Date To"}), 1, "vDDO_BR_MEDICATION_ADMITSTARTDATEAUXDATETO");
               GX_FocusControl = edtavDdo_br_medication_admitstartdateauxdateto_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV80DDO_BR_Medication_AdmitStartDateAuxDateTo = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV80DDO_BR_Medication_AdmitStartDateAuxDateTo", context.localUtil.Format(AV80DDO_BR_Medication_AdmitStartDateAuxDateTo, "9999/99/99"));
            }
            else
            {
               AV80DDO_BR_Medication_AdmitStartDateAuxDateTo = context.localUtil.CToD( cgiGet( edtavDdo_br_medication_admitstartdateauxdateto_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV80DDO_BR_Medication_AdmitStartDateAuxDateTo", context.localUtil.Format(AV80DDO_BR_Medication_AdmitStartDateAuxDateTo, "9999/99/99"));
            }
            /* Read saved values. */
            nRC_GXsfl_12 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_12"), ".", ","));
            AV110GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV112GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV111GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_medication_rxname_Caption = cgiGet( "DDO_BR_MEDICATION_RXNAME_Caption");
            Ddo_br_medication_rxname_Tooltip = cgiGet( "DDO_BR_MEDICATION_RXNAME_Tooltip");
            Ddo_br_medication_rxname_Cls = cgiGet( "DDO_BR_MEDICATION_RXNAME_Cls");
            Ddo_br_medication_rxname_Filteredtext_set = cgiGet( "DDO_BR_MEDICATION_RXNAME_Filteredtext_set");
            Ddo_br_medication_rxname_Selectedvalue_set = cgiGet( "DDO_BR_MEDICATION_RXNAME_Selectedvalue_set");
            Ddo_br_medication_rxname_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_RXNAME_Dropdownoptionstype");
            Ddo_br_medication_rxname_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_RXNAME_Titlecontrolidtoreplace");
            Ddo_br_medication_rxname_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXNAME_Includesortasc"));
            Ddo_br_medication_rxname_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXNAME_Includesortdsc"));
            Ddo_br_medication_rxname_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_RXNAME_Sortedstatus");
            Ddo_br_medication_rxname_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXNAME_Includefilter"));
            Ddo_br_medication_rxname_Filtertype = cgiGet( "DDO_BR_MEDICATION_RXNAME_Filtertype");
            Ddo_br_medication_rxname_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXNAME_Filterisrange"));
            Ddo_br_medication_rxname_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXNAME_Includedatalist"));
            Ddo_br_medication_rxname_Datalisttype = cgiGet( "DDO_BR_MEDICATION_RXNAME_Datalisttype");
            Ddo_br_medication_rxname_Datalistproc = cgiGet( "DDO_BR_MEDICATION_RXNAME_Datalistproc");
            Ddo_br_medication_rxname_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_MEDICATION_RXNAME_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_medication_rxname_Sortasc = cgiGet( "DDO_BR_MEDICATION_RXNAME_Sortasc");
            Ddo_br_medication_rxname_Sortdsc = cgiGet( "DDO_BR_MEDICATION_RXNAME_Sortdsc");
            Ddo_br_medication_rxname_Loadingdata = cgiGet( "DDO_BR_MEDICATION_RXNAME_Loadingdata");
            Ddo_br_medication_rxname_Cleanfilter = cgiGet( "DDO_BR_MEDICATION_RXNAME_Cleanfilter");
            Ddo_br_medication_rxname_Noresultsfound = cgiGet( "DDO_BR_MEDICATION_RXNAME_Noresultsfound");
            Ddo_br_medication_rxname_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_RXNAME_Searchbuttontext");
            Ddo_br_medication_rxcode_Caption = cgiGet( "DDO_BR_MEDICATION_RXCODE_Caption");
            Ddo_br_medication_rxcode_Tooltip = cgiGet( "DDO_BR_MEDICATION_RXCODE_Tooltip");
            Ddo_br_medication_rxcode_Cls = cgiGet( "DDO_BR_MEDICATION_RXCODE_Cls");
            Ddo_br_medication_rxcode_Filteredtext_set = cgiGet( "DDO_BR_MEDICATION_RXCODE_Filteredtext_set");
            Ddo_br_medication_rxcode_Selectedvalue_set = cgiGet( "DDO_BR_MEDICATION_RXCODE_Selectedvalue_set");
            Ddo_br_medication_rxcode_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_RXCODE_Dropdownoptionstype");
            Ddo_br_medication_rxcode_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_RXCODE_Titlecontrolidtoreplace");
            Ddo_br_medication_rxcode_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXCODE_Includesortasc"));
            Ddo_br_medication_rxcode_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXCODE_Includesortdsc"));
            Ddo_br_medication_rxcode_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_RXCODE_Sortedstatus");
            Ddo_br_medication_rxcode_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXCODE_Includefilter"));
            Ddo_br_medication_rxcode_Filtertype = cgiGet( "DDO_BR_MEDICATION_RXCODE_Filtertype");
            Ddo_br_medication_rxcode_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXCODE_Filterisrange"));
            Ddo_br_medication_rxcode_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXCODE_Includedatalist"));
            Ddo_br_medication_rxcode_Datalisttype = cgiGet( "DDO_BR_MEDICATION_RXCODE_Datalisttype");
            Ddo_br_medication_rxcode_Datalistproc = cgiGet( "DDO_BR_MEDICATION_RXCODE_Datalistproc");
            Ddo_br_medication_rxcode_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_MEDICATION_RXCODE_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_medication_rxcode_Sortasc = cgiGet( "DDO_BR_MEDICATION_RXCODE_Sortasc");
            Ddo_br_medication_rxcode_Sortdsc = cgiGet( "DDO_BR_MEDICATION_RXCODE_Sortdsc");
            Ddo_br_medication_rxcode_Loadingdata = cgiGet( "DDO_BR_MEDICATION_RXCODE_Loadingdata");
            Ddo_br_medication_rxcode_Cleanfilter = cgiGet( "DDO_BR_MEDICATION_RXCODE_Cleanfilter");
            Ddo_br_medication_rxcode_Noresultsfound = cgiGet( "DDO_BR_MEDICATION_RXCODE_Noresultsfound");
            Ddo_br_medication_rxcode_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_RXCODE_Searchbuttontext");
            Ddo_br_medication_rxquantity_Caption = cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Caption");
            Ddo_br_medication_rxquantity_Tooltip = cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Tooltip");
            Ddo_br_medication_rxquantity_Cls = cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Cls");
            Ddo_br_medication_rxquantity_Filteredtext_set = cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Filteredtext_set");
            Ddo_br_medication_rxquantity_Selectedvalue_set = cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Selectedvalue_set");
            Ddo_br_medication_rxquantity_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Dropdownoptionstype");
            Ddo_br_medication_rxquantity_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Titlecontrolidtoreplace");
            Ddo_br_medication_rxquantity_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Includesortasc"));
            Ddo_br_medication_rxquantity_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Includesortdsc"));
            Ddo_br_medication_rxquantity_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Sortedstatus");
            Ddo_br_medication_rxquantity_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Includefilter"));
            Ddo_br_medication_rxquantity_Filtertype = cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Filtertype");
            Ddo_br_medication_rxquantity_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Filterisrange"));
            Ddo_br_medication_rxquantity_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Includedatalist"));
            Ddo_br_medication_rxquantity_Datalisttype = cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Datalisttype");
            Ddo_br_medication_rxquantity_Datalistproc = cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Datalistproc");
            Ddo_br_medication_rxquantity_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_medication_rxquantity_Sortasc = cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Sortasc");
            Ddo_br_medication_rxquantity_Sortdsc = cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Sortdsc");
            Ddo_br_medication_rxquantity_Loadingdata = cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Loadingdata");
            Ddo_br_medication_rxquantity_Cleanfilter = cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Cleanfilter");
            Ddo_br_medication_rxquantity_Noresultsfound = cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Noresultsfound");
            Ddo_br_medication_rxquantity_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Searchbuttontext");
            Ddo_br_medication_rxdayssupply_Caption = cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Caption");
            Ddo_br_medication_rxdayssupply_Tooltip = cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Tooltip");
            Ddo_br_medication_rxdayssupply_Cls = cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Cls");
            Ddo_br_medication_rxdayssupply_Filteredtext_set = cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Filteredtext_set");
            Ddo_br_medication_rxdayssupply_Filteredtextto_set = cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Filteredtextto_set");
            Ddo_br_medication_rxdayssupply_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Dropdownoptionstype");
            Ddo_br_medication_rxdayssupply_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Titlecontrolidtoreplace");
            Ddo_br_medication_rxdayssupply_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Includesortasc"));
            Ddo_br_medication_rxdayssupply_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Includesortdsc"));
            Ddo_br_medication_rxdayssupply_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Sortedstatus");
            Ddo_br_medication_rxdayssupply_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Includefilter"));
            Ddo_br_medication_rxdayssupply_Filtertype = cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Filtertype");
            Ddo_br_medication_rxdayssupply_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Filterisrange"));
            Ddo_br_medication_rxdayssupply_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Includedatalist"));
            Ddo_br_medication_rxdayssupply_Sortasc = cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Sortasc");
            Ddo_br_medication_rxdayssupply_Sortdsc = cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Sortdsc");
            Ddo_br_medication_rxdayssupply_Cleanfilter = cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Cleanfilter");
            Ddo_br_medication_rxdayssupply_Rangefilterfrom = cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Rangefilterfrom");
            Ddo_br_medication_rxdayssupply_Rangefilterto = cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Rangefilterto");
            Ddo_br_medication_rxdayssupply_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Searchbuttontext");
            Ddo_br_medication_rxfrequency_Caption = cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Caption");
            Ddo_br_medication_rxfrequency_Tooltip = cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Tooltip");
            Ddo_br_medication_rxfrequency_Cls = cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Cls");
            Ddo_br_medication_rxfrequency_Filteredtext_set = cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Filteredtext_set");
            Ddo_br_medication_rxfrequency_Selectedvalue_set = cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Selectedvalue_set");
            Ddo_br_medication_rxfrequency_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Dropdownoptionstype");
            Ddo_br_medication_rxfrequency_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Titlecontrolidtoreplace");
            Ddo_br_medication_rxfrequency_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Includesortasc"));
            Ddo_br_medication_rxfrequency_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Includesortdsc"));
            Ddo_br_medication_rxfrequency_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Sortedstatus");
            Ddo_br_medication_rxfrequency_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Includefilter"));
            Ddo_br_medication_rxfrequency_Filtertype = cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Filtertype");
            Ddo_br_medication_rxfrequency_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Filterisrange"));
            Ddo_br_medication_rxfrequency_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Includedatalist"));
            Ddo_br_medication_rxfrequency_Datalisttype = cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Datalisttype");
            Ddo_br_medication_rxfrequency_Datalistproc = cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Datalistproc");
            Ddo_br_medication_rxfrequency_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_medication_rxfrequency_Sortasc = cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Sortasc");
            Ddo_br_medication_rxfrequency_Sortdsc = cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Sortdsc");
            Ddo_br_medication_rxfrequency_Loadingdata = cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Loadingdata");
            Ddo_br_medication_rxfrequency_Cleanfilter = cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Cleanfilter");
            Ddo_br_medication_rxfrequency_Noresultsfound = cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Noresultsfound");
            Ddo_br_medication_rxfrequency_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Searchbuttontext");
            Ddo_br_medication_admitstartdate_Caption = cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Caption");
            Ddo_br_medication_admitstartdate_Tooltip = cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Tooltip");
            Ddo_br_medication_admitstartdate_Cls = cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Cls");
            Ddo_br_medication_admitstartdate_Filteredtext_set = cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Filteredtext_set");
            Ddo_br_medication_admitstartdate_Filteredtextto_set = cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Filteredtextto_set");
            Ddo_br_medication_admitstartdate_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Dropdownoptionstype");
            Ddo_br_medication_admitstartdate_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Titlecontrolidtoreplace");
            Ddo_br_medication_admitstartdate_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Includesortasc"));
            Ddo_br_medication_admitstartdate_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Includesortdsc"));
            Ddo_br_medication_admitstartdate_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Sortedstatus");
            Ddo_br_medication_admitstartdate_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Includefilter"));
            Ddo_br_medication_admitstartdate_Filtertype = cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Filtertype");
            Ddo_br_medication_admitstartdate_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Filterisrange"));
            Ddo_br_medication_admitstartdate_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Includedatalist"));
            Ddo_br_medication_admitstartdate_Sortasc = cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Sortasc");
            Ddo_br_medication_admitstartdate_Sortdsc = cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Sortdsc");
            Ddo_br_medication_admitstartdate_Cleanfilter = cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Cleanfilter");
            Ddo_br_medication_admitstartdate_Rangefilterfrom = cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Rangefilterfrom");
            Ddo_br_medication_admitstartdate_Rangefilterto = cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Rangefilterto");
            Ddo_br_medication_admitstartdate_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_medication_rxname_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_RXNAME_Activeeventkey");
            Ddo_br_medication_rxname_Filteredtext_get = cgiGet( "DDO_BR_MEDICATION_RXNAME_Filteredtext_get");
            Ddo_br_medication_rxname_Selectedvalue_get = cgiGet( "DDO_BR_MEDICATION_RXNAME_Selectedvalue_get");
            Ddo_br_medication_rxcode_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_RXCODE_Activeeventkey");
            Ddo_br_medication_rxcode_Filteredtext_get = cgiGet( "DDO_BR_MEDICATION_RXCODE_Filteredtext_get");
            Ddo_br_medication_rxcode_Selectedvalue_get = cgiGet( "DDO_BR_MEDICATION_RXCODE_Selectedvalue_get");
            Ddo_br_medication_rxquantity_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Activeeventkey");
            Ddo_br_medication_rxquantity_Filteredtext_get = cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Filteredtext_get");
            Ddo_br_medication_rxquantity_Selectedvalue_get = cgiGet( "DDO_BR_MEDICATION_RXQUANTITY_Selectedvalue_get");
            Ddo_br_medication_rxdayssupply_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Activeeventkey");
            Ddo_br_medication_rxdayssupply_Filteredtext_get = cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Filteredtext_get");
            Ddo_br_medication_rxdayssupply_Filteredtextto_get = cgiGet( "DDO_BR_MEDICATION_RXDAYSSUPPLY_Filteredtextto_get");
            Ddo_br_medication_rxfrequency_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Activeeventkey");
            Ddo_br_medication_rxfrequency_Filteredtext_get = cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Filteredtext_get");
            Ddo_br_medication_rxfrequency_Selectedvalue_get = cgiGet( "DDO_BR_MEDICATION_RXFREQUENCY_Selectedvalue_get");
            Ddo_br_medication_admitstartdate_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Activeeventkey");
            Ddo_br_medication_admitstartdate_Filteredtext_get = cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Filteredtext_get");
            Ddo_br_medication_admitstartdate_Filteredtextto_get = cgiGet( "DDO_BR_MEDICATION_ADMITSTARTDATE_Filteredtextto_get");
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
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_RXNAME"), AV31TFBR_Medication_RXName) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_RXNAME_SEL"), AV32TFBR_Medication_RXName_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_RXCODE"), AV35TFBR_Medication_RXCode) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_RXCODE_SEL"), AV36TFBR_Medication_RXCode_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_RXQUANTITY"), AV55TFBR_Medication_RXQuantity) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_RXQUANTITY_SEL"), AV56TFBR_Medication_RXQuantity_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATION_RXDAYSSUPPLY"), ".", ",") != AV59TFBR_Medication_RXDaysSupply )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_MEDICATION_RXDAYSSUPPLY_TO"), ".", ",") != AV60TFBR_Medication_RXDaysSupply_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_RXFREQUENCY"), AV51TFBR_Medication_RXFrequency) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_MEDICATION_RXFREQUENCY_SEL"), AV122TFBR_Medication_RXFrequency_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vTFBR_MEDICATION_ADMITSTARTDATE"), 0) != AV77TFBR_Medication_AdmitStartDate )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vTFBR_MEDICATION_ADMITSTARTDATE_TO"), 0) != AV78TFBR_Medication_AdmitStartDate_To )
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
         E193K2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E193K2( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         edtavTfbr_medication_rxname_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_rxname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_rxname_Visible), 5, 0)), true);
         edtavTfbr_medication_rxname_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_rxname_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_rxname_sel_Visible), 5, 0)), true);
         edtavTfbr_medication_rxcode_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_rxcode_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_rxcode_Visible), 5, 0)), true);
         edtavTfbr_medication_rxcode_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_rxcode_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_rxcode_sel_Visible), 5, 0)), true);
         edtavTfbr_medication_rxquantity_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_rxquantity_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_rxquantity_Visible), 5, 0)), true);
         edtavTfbr_medication_rxquantity_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_rxquantity_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_rxquantity_sel_Visible), 5, 0)), true);
         edtavTfbr_medication_rxdayssupply_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_rxdayssupply_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_rxdayssupply_Visible), 5, 0)), true);
         edtavTfbr_medication_rxdayssupply_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_rxdayssupply_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_rxdayssupply_to_Visible), 5, 0)), true);
         edtavTfbr_medication_rxfrequency_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_rxfrequency_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_rxfrequency_Visible), 5, 0)), true);
         edtavTfbr_medication_rxfrequency_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_rxfrequency_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_rxfrequency_sel_Visible), 5, 0)), true);
         edtavTfbr_medication_admitstartdate_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_admitstartdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_admitstartdate_Visible), 5, 0)), true);
         edtavTfbr_medication_admitstartdate_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_medication_admitstartdate_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_medication_admitstartdate_to_Visible), 5, 0)), true);
         Ddo_br_medication_rxname_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_RXName";
         ucDdo_br_medication_rxname.SendProperty(context, "", false, Ddo_br_medication_rxname_Internalname, "TitleControlIdToReplace", Ddo_br_medication_rxname_Titlecontrolidtoreplace);
         AV33ddo_BR_Medication_RXNameTitleControlIdToReplace = Ddo_br_medication_rxname_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33ddo_BR_Medication_RXNameTitleControlIdToReplace", AV33ddo_BR_Medication_RXNameTitleControlIdToReplace);
         edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_rxcode_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_RXCode";
         ucDdo_br_medication_rxcode.SendProperty(context, "", false, Ddo_br_medication_rxcode_Internalname, "TitleControlIdToReplace", Ddo_br_medication_rxcode_Titlecontrolidtoreplace);
         AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace = Ddo_br_medication_rxcode_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace", AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace);
         edtavDdo_br_medication_rxcodetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_rxcodetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_rxcodetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_rxquantity_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_RXQuantity";
         ucDdo_br_medication_rxquantity.SendProperty(context, "", false, Ddo_br_medication_rxquantity_Internalname, "TitleControlIdToReplace", Ddo_br_medication_rxquantity_Titlecontrolidtoreplace);
         AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace = Ddo_br_medication_rxquantity_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace", AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace);
         edtavDdo_br_medication_rxquantitytitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_rxquantitytitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_rxquantitytitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_rxdayssupply_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_RXDaysSupply";
         ucDdo_br_medication_rxdayssupply.SendProperty(context, "", false, Ddo_br_medication_rxdayssupply_Internalname, "TitleControlIdToReplace", Ddo_br_medication_rxdayssupply_Titlecontrolidtoreplace);
         AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace = Ddo_br_medication_rxdayssupply_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace", AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace);
         edtavDdo_br_medication_rxdayssupplytitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_rxdayssupplytitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_rxdayssupplytitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_rxfrequency_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_RXFrequency";
         ucDdo_br_medication_rxfrequency.SendProperty(context, "", false, Ddo_br_medication_rxfrequency_Internalname, "TitleControlIdToReplace", Ddo_br_medication_rxfrequency_Titlecontrolidtoreplace);
         AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace = Ddo_br_medication_rxfrequency_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace", AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace);
         edtavDdo_br_medication_rxfrequencytitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_rxfrequencytitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_rxfrequencytitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_admitstartdate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_AdmitStartDate";
         ucDdo_br_medication_admitstartdate.SendProperty(context, "", false, Ddo_br_medication_admitstartdate_Internalname, "TitleControlIdToReplace", Ddo_br_medication_admitstartdate_Titlecontrolidtoreplace);
         AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace = Ddo_br_medication_admitstartdate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace", AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace);
         edtavDdo_br_medication_admitstartdatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_admitstartdatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_admitstartdatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " 药物治疗";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV108DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV108DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E203K2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV30BR_Medication_RXNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV34BR_Medication_RXCodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV54BR_Medication_RXQuantityTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV58BR_Medication_RXDaysSupplyTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV50BR_Medication_RXFrequencyTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV76BR_Medication_AdmitStartDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         /* Execute user subroutine: 'SAVEGRIDSTATE' */
         S142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         edtBR_Medication_RXName_Titleformat = 2;
         edtBR_Medication_RXName_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "药物名称", AV33ddo_BR_Medication_RXNameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_RXName_Internalname, "Title", edtBR_Medication_RXName_Title, !bGXsfl_12_Refreshing);
         edtBR_Medication_RXCode_Titleformat = 2;
         edtBR_Medication_RXCode_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "药物代码", AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_RXCode_Internalname, "Title", edtBR_Medication_RXCode_Title, !bGXsfl_12_Refreshing);
         edtBR_Medication_RXQuantity_Titleformat = 2;
         edtBR_Medication_RXQuantity_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "用药量", AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_RXQuantity_Internalname, "Title", edtBR_Medication_RXQuantity_Title, !bGXsfl_12_Refreshing);
         edtBR_Medication_RXDaysSupply_Titleformat = 2;
         edtBR_Medication_RXDaysSupply_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "服药天数", AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_RXDaysSupply_Internalname, "Title", edtBR_Medication_RXDaysSupply_Title, !bGXsfl_12_Refreshing);
         edtBR_Medication_RXFrequency_Titleformat = 2;
         edtBR_Medication_RXFrequency_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "服药频率", AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_RXFrequency_Internalname, "Title", edtBR_Medication_RXFrequency_Title, !bGXsfl_12_Refreshing);
         edtBR_Medication_AdmitStartDate_Titleformat = 2;
         edtBR_Medication_AdmitStartDate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "服药日期", AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_AdmitStartDate_Internalname, "Title", edtBR_Medication_AdmitStartDate_Title, !bGXsfl_12_Refreshing);
         AV110GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV110GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV110GridCurrentPage), 10, 0)));
         AV111GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV111GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV111GridPageSize), 10, 0)));
         AV112GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV112GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV112GridRecordCount), 10, 0)));
         AV128BR_MedicationWWDS_1_Tfbr_medication_rxname = AV31TFBR_Medication_RXName;
         AV129BR_MedicationWWDS_2_Tfbr_medication_rxname_sel = AV32TFBR_Medication_RXName_Sel;
         AV130BR_MedicationWWDS_3_Tfbr_medication_rxcode = AV35TFBR_Medication_RXCode;
         AV131BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel = AV36TFBR_Medication_RXCode_Sel;
         AV132BR_MedicationWWDS_5_Tfbr_medication_rxquantity = AV55TFBR_Medication_RXQuantity;
         AV133BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel = AV56TFBR_Medication_RXQuantity_Sel;
         AV134BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply = AV59TFBR_Medication_RXDaysSupply;
         AV135BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to = AV60TFBR_Medication_RXDaysSupply_To;
         AV136BR_MedicationWWDS_9_Tfbr_medication_rxfrequency = AV51TFBR_Medication_RXFrequency;
         AV137BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel = AV122TFBR_Medication_RXFrequency_Sel;
         AV138BR_MedicationWWDS_11_Tfbr_medication_admitstartdate = AV77TFBR_Medication_AdmitStartDate;
         AV139BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to = AV78TFBR_Medication_AdmitStartDate_To;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Medication_RXNameTitleFilterData", AV30BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Medication_RXCodeTitleFilterData", AV34BR_Medication_RXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_Medication_RXQuantityTitleFilterData", AV54BR_Medication_RXQuantityTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Medication_RXDaysSupplyTitleFilterData", AV58BR_Medication_RXDaysSupplyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Medication_RXFrequencyTitleFilterData", AV50BR_Medication_RXFrequencyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV76BR_Medication_AdmitStartDateTitleFilterData", AV76BR_Medication_AdmitStartDateTitleFilterData);
      }

      protected void E113K2( )
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
            AV109PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV109PageToGo) ;
         }
      }

      protected void E123K2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E133K2( )
      {
         /* Ddo_br_medication_rxname_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_rxname_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_medication_rxname_Sortedstatus = "ASC";
            ucDdo_br_medication_rxname.SendProperty(context, "", false, Ddo_br_medication_rxname_Internalname, "SortedStatus", Ddo_br_medication_rxname_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_rxname_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_medication_rxname_Sortedstatus = "DSC";
            ucDdo_br_medication_rxname.SendProperty(context, "", false, Ddo_br_medication_rxname_Internalname, "SortedStatus", Ddo_br_medication_rxname_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_rxname_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV31TFBR_Medication_RXName = Ddo_br_medication_rxname_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31TFBR_Medication_RXName", AV31TFBR_Medication_RXName);
            AV32TFBR_Medication_RXName_Sel = Ddo_br_medication_rxname_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32TFBR_Medication_RXName_Sel", AV32TFBR_Medication_RXName_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Medication_RXNameTitleFilterData", AV30BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Medication_RXCodeTitleFilterData", AV34BR_Medication_RXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_Medication_RXQuantityTitleFilterData", AV54BR_Medication_RXQuantityTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Medication_RXDaysSupplyTitleFilterData", AV58BR_Medication_RXDaysSupplyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Medication_RXFrequencyTitleFilterData", AV50BR_Medication_RXFrequencyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV76BR_Medication_AdmitStartDateTitleFilterData", AV76BR_Medication_AdmitStartDateTitleFilterData);
      }

      protected void E143K2( )
      {
         /* Ddo_br_medication_rxcode_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_rxcode_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_medication_rxcode_Sortedstatus = "ASC";
            ucDdo_br_medication_rxcode.SendProperty(context, "", false, Ddo_br_medication_rxcode_Internalname, "SortedStatus", Ddo_br_medication_rxcode_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_rxcode_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_medication_rxcode_Sortedstatus = "DSC";
            ucDdo_br_medication_rxcode.SendProperty(context, "", false, Ddo_br_medication_rxcode_Internalname, "SortedStatus", Ddo_br_medication_rxcode_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_rxcode_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV35TFBR_Medication_RXCode = Ddo_br_medication_rxcode_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35TFBR_Medication_RXCode", AV35TFBR_Medication_RXCode);
            AV36TFBR_Medication_RXCode_Sel = Ddo_br_medication_rxcode_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36TFBR_Medication_RXCode_Sel", AV36TFBR_Medication_RXCode_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Medication_RXNameTitleFilterData", AV30BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Medication_RXCodeTitleFilterData", AV34BR_Medication_RXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_Medication_RXQuantityTitleFilterData", AV54BR_Medication_RXQuantityTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Medication_RXDaysSupplyTitleFilterData", AV58BR_Medication_RXDaysSupplyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Medication_RXFrequencyTitleFilterData", AV50BR_Medication_RXFrequencyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV76BR_Medication_AdmitStartDateTitleFilterData", AV76BR_Medication_AdmitStartDateTitleFilterData);
      }

      protected void E153K2( )
      {
         /* Ddo_br_medication_rxquantity_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_rxquantity_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_medication_rxquantity_Sortedstatus = "ASC";
            ucDdo_br_medication_rxquantity.SendProperty(context, "", false, Ddo_br_medication_rxquantity_Internalname, "SortedStatus", Ddo_br_medication_rxquantity_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_rxquantity_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_medication_rxquantity_Sortedstatus = "DSC";
            ucDdo_br_medication_rxquantity.SendProperty(context, "", false, Ddo_br_medication_rxquantity_Internalname, "SortedStatus", Ddo_br_medication_rxquantity_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_rxquantity_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV55TFBR_Medication_RXQuantity = Ddo_br_medication_rxquantity_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV55TFBR_Medication_RXQuantity", AV55TFBR_Medication_RXQuantity);
            AV56TFBR_Medication_RXQuantity_Sel = Ddo_br_medication_rxquantity_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56TFBR_Medication_RXQuantity_Sel", AV56TFBR_Medication_RXQuantity_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Medication_RXNameTitleFilterData", AV30BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Medication_RXCodeTitleFilterData", AV34BR_Medication_RXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_Medication_RXQuantityTitleFilterData", AV54BR_Medication_RXQuantityTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Medication_RXDaysSupplyTitleFilterData", AV58BR_Medication_RXDaysSupplyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Medication_RXFrequencyTitleFilterData", AV50BR_Medication_RXFrequencyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV76BR_Medication_AdmitStartDateTitleFilterData", AV76BR_Medication_AdmitStartDateTitleFilterData);
      }

      protected void E163K2( )
      {
         /* Ddo_br_medication_rxdayssupply_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_rxdayssupply_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_medication_rxdayssupply_Sortedstatus = "ASC";
            ucDdo_br_medication_rxdayssupply.SendProperty(context, "", false, Ddo_br_medication_rxdayssupply_Internalname, "SortedStatus", Ddo_br_medication_rxdayssupply_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_rxdayssupply_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_medication_rxdayssupply_Sortedstatus = "DSC";
            ucDdo_br_medication_rxdayssupply.SendProperty(context, "", false, Ddo_br_medication_rxdayssupply_Internalname, "SortedStatus", Ddo_br_medication_rxdayssupply_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_rxdayssupply_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV59TFBR_Medication_RXDaysSupply = NumberUtil.Val( Ddo_br_medication_rxdayssupply_Filteredtext_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59TFBR_Medication_RXDaysSupply", StringUtil.LTrim( StringUtil.Str( AV59TFBR_Medication_RXDaysSupply, 15, 5)));
            AV60TFBR_Medication_RXDaysSupply_To = NumberUtil.Val( Ddo_br_medication_rxdayssupply_Filteredtextto_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60TFBR_Medication_RXDaysSupply_To", StringUtil.LTrim( StringUtil.Str( AV60TFBR_Medication_RXDaysSupply_To, 15, 5)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Medication_RXNameTitleFilterData", AV30BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Medication_RXCodeTitleFilterData", AV34BR_Medication_RXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_Medication_RXQuantityTitleFilterData", AV54BR_Medication_RXQuantityTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Medication_RXDaysSupplyTitleFilterData", AV58BR_Medication_RXDaysSupplyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Medication_RXFrequencyTitleFilterData", AV50BR_Medication_RXFrequencyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV76BR_Medication_AdmitStartDateTitleFilterData", AV76BR_Medication_AdmitStartDateTitleFilterData);
      }

      protected void E173K2( )
      {
         /* Ddo_br_medication_rxfrequency_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_rxfrequency_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_medication_rxfrequency_Sortedstatus = "ASC";
            ucDdo_br_medication_rxfrequency.SendProperty(context, "", false, Ddo_br_medication_rxfrequency_Internalname, "SortedStatus", Ddo_br_medication_rxfrequency_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_rxfrequency_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_medication_rxfrequency_Sortedstatus = "DSC";
            ucDdo_br_medication_rxfrequency.SendProperty(context, "", false, Ddo_br_medication_rxfrequency_Internalname, "SortedStatus", Ddo_br_medication_rxfrequency_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_rxfrequency_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV51TFBR_Medication_RXFrequency = Ddo_br_medication_rxfrequency_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51TFBR_Medication_RXFrequency", AV51TFBR_Medication_RXFrequency);
            AV122TFBR_Medication_RXFrequency_Sel = Ddo_br_medication_rxfrequency_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV122TFBR_Medication_RXFrequency_Sel", AV122TFBR_Medication_RXFrequency_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Medication_RXNameTitleFilterData", AV30BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Medication_RXCodeTitleFilterData", AV34BR_Medication_RXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_Medication_RXQuantityTitleFilterData", AV54BR_Medication_RXQuantityTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Medication_RXDaysSupplyTitleFilterData", AV58BR_Medication_RXDaysSupplyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Medication_RXFrequencyTitleFilterData", AV50BR_Medication_RXFrequencyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV76BR_Medication_AdmitStartDateTitleFilterData", AV76BR_Medication_AdmitStartDateTitleFilterData);
      }

      protected void E183K2( )
      {
         /* Ddo_br_medication_admitstartdate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_admitstartdate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_medication_admitstartdate_Sortedstatus = "ASC";
            ucDdo_br_medication_admitstartdate.SendProperty(context, "", false, Ddo_br_medication_admitstartdate_Internalname, "SortedStatus", Ddo_br_medication_admitstartdate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_admitstartdate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_medication_admitstartdate_Sortedstatus = "DSC";
            ucDdo_br_medication_admitstartdate.SendProperty(context, "", false, Ddo_br_medication_admitstartdate_Internalname, "SortedStatus", Ddo_br_medication_admitstartdate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_admitstartdate_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV77TFBR_Medication_AdmitStartDate = context.localUtil.CToD( Ddo_br_medication_admitstartdate_Filteredtext_get, 0);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV77TFBR_Medication_AdmitStartDate", context.localUtil.Format(AV77TFBR_Medication_AdmitStartDate, "9999/99/99"));
            AV78TFBR_Medication_AdmitStartDate_To = context.localUtil.CToD( Ddo_br_medication_admitstartdate_Filteredtextto_get, 0);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV78TFBR_Medication_AdmitStartDate_To", context.localUtil.Format(AV78TFBR_Medication_AdmitStartDate_To, "9999/99/99"));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Medication_RXNameTitleFilterData", AV30BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Medication_RXCodeTitleFilterData", AV34BR_Medication_RXCodeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54BR_Medication_RXQuantityTitleFilterData", AV54BR_Medication_RXQuantityTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV58BR_Medication_RXDaysSupplyTitleFilterData", AV58BR_Medication_RXDaysSupplyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Medication_RXFrequencyTitleFilterData", AV50BR_Medication_RXFrequencyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV76BR_Medication_AdmitStartDateTitleFilterData", AV76BR_Medication_AdmitStartDateTitleFilterData);
      }

      private void E213K2( )
      {
         /* Grid_Load Routine */
         AV113Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDisplay_Internalname, AV113Display);
         AV140Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = formatLink("br_medicationview.aspx") + "?" + UrlEncode("" +A119BR_MedicationID) + "," + UrlEncode(StringUtil.RTrim(""));
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

      protected void S152( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_br_medication_rxname_Sortedstatus = "";
         ucDdo_br_medication_rxname.SendProperty(context, "", false, Ddo_br_medication_rxname_Internalname, "SortedStatus", Ddo_br_medication_rxname_Sortedstatus);
         Ddo_br_medication_rxcode_Sortedstatus = "";
         ucDdo_br_medication_rxcode.SendProperty(context, "", false, Ddo_br_medication_rxcode_Internalname, "SortedStatus", Ddo_br_medication_rxcode_Sortedstatus);
         Ddo_br_medication_rxquantity_Sortedstatus = "";
         ucDdo_br_medication_rxquantity.SendProperty(context, "", false, Ddo_br_medication_rxquantity_Internalname, "SortedStatus", Ddo_br_medication_rxquantity_Sortedstatus);
         Ddo_br_medication_rxdayssupply_Sortedstatus = "";
         ucDdo_br_medication_rxdayssupply.SendProperty(context, "", false, Ddo_br_medication_rxdayssupply_Internalname, "SortedStatus", Ddo_br_medication_rxdayssupply_Sortedstatus);
         Ddo_br_medication_rxfrequency_Sortedstatus = "";
         ucDdo_br_medication_rxfrequency.SendProperty(context, "", false, Ddo_br_medication_rxfrequency_Internalname, "SortedStatus", Ddo_br_medication_rxfrequency_Sortedstatus);
         Ddo_br_medication_admitstartdate_Sortedstatus = "";
         ucDdo_br_medication_admitstartdate.SendProperty(context, "", false, Ddo_br_medication_admitstartdate_Internalname, "SortedStatus", Ddo_br_medication_admitstartdate_Sortedstatus);
      }

      protected void S132( )
      {
         /* 'SETDDOSORTEDSTATUS' Routine */
         /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
         S152 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         if ( AV13OrderedBy == 1 )
         {
            Ddo_br_medication_rxname_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medication_rxname.SendProperty(context, "", false, Ddo_br_medication_rxname_Internalname, "SortedStatus", Ddo_br_medication_rxname_Sortedstatus);
         }
         else if ( AV13OrderedBy == 2 )
         {
            Ddo_br_medication_rxcode_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medication_rxcode.SendProperty(context, "", false, Ddo_br_medication_rxcode_Internalname, "SortedStatus", Ddo_br_medication_rxcode_Sortedstatus);
         }
         else if ( AV13OrderedBy == 3 )
         {
            Ddo_br_medication_rxquantity_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medication_rxquantity.SendProperty(context, "", false, Ddo_br_medication_rxquantity_Internalname, "SortedStatus", Ddo_br_medication_rxquantity_Sortedstatus);
         }
         else if ( AV13OrderedBy == 4 )
         {
            Ddo_br_medication_rxdayssupply_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medication_rxdayssupply.SendProperty(context, "", false, Ddo_br_medication_rxdayssupply_Internalname, "SortedStatus", Ddo_br_medication_rxdayssupply_Sortedstatus);
         }
         else if ( AV13OrderedBy == 5 )
         {
            Ddo_br_medication_rxfrequency_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medication_rxfrequency.SendProperty(context, "", false, Ddo_br_medication_rxfrequency_Internalname, "SortedStatus", Ddo_br_medication_rxfrequency_Sortedstatus);
         }
         else if ( AV13OrderedBy == 6 )
         {
            Ddo_br_medication_admitstartdate_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_medication_admitstartdate.SendProperty(context, "", false, Ddo_br_medication_admitstartdate_Internalname, "SortedStatus", Ddo_br_medication_admitstartdate_Sortedstatus);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV15Session.Get(AV141Pgmname+"GridState"), "") == 0 )
         {
            AV11GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV141Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV11GridState.FromXml(AV15Session.Get(AV141Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
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
         AV142GXV1 = 1;
         while ( AV142GXV1 <= AV11GridState.gxTpr_Filtervalues.Count )
         {
            AV12GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV11GridState.gxTpr_Filtervalues.Item(AV142GXV1));
            if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXNAME") == 0 )
            {
               AV31TFBR_Medication_RXName = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31TFBR_Medication_RXName", AV31TFBR_Medication_RXName);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV31TFBR_Medication_RXName)) )
               {
                  Ddo_br_medication_rxname_Filteredtext_set = AV31TFBR_Medication_RXName;
                  ucDdo_br_medication_rxname.SendProperty(context, "", false, Ddo_br_medication_rxname_Internalname, "FilteredText_set", Ddo_br_medication_rxname_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXNAME_SEL") == 0 )
            {
               AV32TFBR_Medication_RXName_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32TFBR_Medication_RXName_Sel", AV32TFBR_Medication_RXName_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV32TFBR_Medication_RXName_Sel)) )
               {
                  Ddo_br_medication_rxname_Selectedvalue_set = AV32TFBR_Medication_RXName_Sel;
                  ucDdo_br_medication_rxname.SendProperty(context, "", false, Ddo_br_medication_rxname_Internalname, "SelectedValue_set", Ddo_br_medication_rxname_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXCODE") == 0 )
            {
               AV35TFBR_Medication_RXCode = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35TFBR_Medication_RXCode", AV35TFBR_Medication_RXCode);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV35TFBR_Medication_RXCode)) )
               {
                  Ddo_br_medication_rxcode_Filteredtext_set = AV35TFBR_Medication_RXCode;
                  ucDdo_br_medication_rxcode.SendProperty(context, "", false, Ddo_br_medication_rxcode_Internalname, "FilteredText_set", Ddo_br_medication_rxcode_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXCODE_SEL") == 0 )
            {
               AV36TFBR_Medication_RXCode_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36TFBR_Medication_RXCode_Sel", AV36TFBR_Medication_RXCode_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV36TFBR_Medication_RXCode_Sel)) )
               {
                  Ddo_br_medication_rxcode_Selectedvalue_set = AV36TFBR_Medication_RXCode_Sel;
                  ucDdo_br_medication_rxcode.SendProperty(context, "", false, Ddo_br_medication_rxcode_Internalname, "SelectedValue_set", Ddo_br_medication_rxcode_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXQUANTITY") == 0 )
            {
               AV55TFBR_Medication_RXQuantity = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV55TFBR_Medication_RXQuantity", AV55TFBR_Medication_RXQuantity);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55TFBR_Medication_RXQuantity)) )
               {
                  Ddo_br_medication_rxquantity_Filteredtext_set = AV55TFBR_Medication_RXQuantity;
                  ucDdo_br_medication_rxquantity.SendProperty(context, "", false, Ddo_br_medication_rxquantity_Internalname, "FilteredText_set", Ddo_br_medication_rxquantity_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXQUANTITY_SEL") == 0 )
            {
               AV56TFBR_Medication_RXQuantity_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56TFBR_Medication_RXQuantity_Sel", AV56TFBR_Medication_RXQuantity_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56TFBR_Medication_RXQuantity_Sel)) )
               {
                  Ddo_br_medication_rxquantity_Selectedvalue_set = AV56TFBR_Medication_RXQuantity_Sel;
                  ucDdo_br_medication_rxquantity.SendProperty(context, "", false, Ddo_br_medication_rxquantity_Internalname, "SelectedValue_set", Ddo_br_medication_rxquantity_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXDAYSSUPPLY") == 0 )
            {
               AV59TFBR_Medication_RXDaysSupply = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV59TFBR_Medication_RXDaysSupply", StringUtil.LTrim( StringUtil.Str( AV59TFBR_Medication_RXDaysSupply, 15, 5)));
               AV60TFBR_Medication_RXDaysSupply_To = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60TFBR_Medication_RXDaysSupply_To", StringUtil.LTrim( StringUtil.Str( AV60TFBR_Medication_RXDaysSupply_To, 15, 5)));
               if ( ! (Convert.ToDecimal(0)==AV59TFBR_Medication_RXDaysSupply) )
               {
                  Ddo_br_medication_rxdayssupply_Filteredtext_set = StringUtil.Str( AV59TFBR_Medication_RXDaysSupply, 15, 5);
                  ucDdo_br_medication_rxdayssupply.SendProperty(context, "", false, Ddo_br_medication_rxdayssupply_Internalname, "FilteredText_set", Ddo_br_medication_rxdayssupply_Filteredtext_set);
               }
               if ( ! (Convert.ToDecimal(0)==AV60TFBR_Medication_RXDaysSupply_To) )
               {
                  Ddo_br_medication_rxdayssupply_Filteredtextto_set = StringUtil.Str( AV60TFBR_Medication_RXDaysSupply_To, 15, 5);
                  ucDdo_br_medication_rxdayssupply.SendProperty(context, "", false, Ddo_br_medication_rxdayssupply_Internalname, "FilteredTextTo_set", Ddo_br_medication_rxdayssupply_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXFREQUENCY") == 0 )
            {
               AV51TFBR_Medication_RXFrequency = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51TFBR_Medication_RXFrequency", AV51TFBR_Medication_RXFrequency);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51TFBR_Medication_RXFrequency)) )
               {
                  Ddo_br_medication_rxfrequency_Filteredtext_set = AV51TFBR_Medication_RXFrequency;
                  ucDdo_br_medication_rxfrequency.SendProperty(context, "", false, Ddo_br_medication_rxfrequency_Internalname, "FilteredText_set", Ddo_br_medication_rxfrequency_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXFREQUENCY_SEL") == 0 )
            {
               AV122TFBR_Medication_RXFrequency_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV122TFBR_Medication_RXFrequency_Sel", AV122TFBR_Medication_RXFrequency_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV122TFBR_Medication_RXFrequency_Sel)) )
               {
                  Ddo_br_medication_rxfrequency_Selectedvalue_set = AV122TFBR_Medication_RXFrequency_Sel;
                  ucDdo_br_medication_rxfrequency.SendProperty(context, "", false, Ddo_br_medication_rxfrequency_Internalname, "SelectedValue_set", Ddo_br_medication_rxfrequency_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_ADMITSTARTDATE") == 0 )
            {
               AV77TFBR_Medication_AdmitStartDate = context.localUtil.CToD( AV12GridStateFilterValue.gxTpr_Value, 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV77TFBR_Medication_AdmitStartDate", context.localUtil.Format(AV77TFBR_Medication_AdmitStartDate, "9999/99/99"));
               AV78TFBR_Medication_AdmitStartDate_To = context.localUtil.CToD( AV12GridStateFilterValue.gxTpr_Valueto, 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV78TFBR_Medication_AdmitStartDate_To", context.localUtil.Format(AV78TFBR_Medication_AdmitStartDate_To, "9999/99/99"));
               if ( ! (DateTime.MinValue==AV77TFBR_Medication_AdmitStartDate) )
               {
                  Ddo_br_medication_admitstartdate_Filteredtext_set = context.localUtil.DToC( AV77TFBR_Medication_AdmitStartDate, 0, "/");
                  ucDdo_br_medication_admitstartdate.SendProperty(context, "", false, Ddo_br_medication_admitstartdate_Internalname, "FilteredText_set", Ddo_br_medication_admitstartdate_Filteredtext_set);
               }
               if ( ! (DateTime.MinValue==AV78TFBR_Medication_AdmitStartDate_To) )
               {
                  Ddo_br_medication_admitstartdate_Filteredtextto_set = context.localUtil.DToC( AV78TFBR_Medication_AdmitStartDate_To, 0, "/");
                  ucDdo_br_medication_admitstartdate.SendProperty(context, "", false, Ddo_br_medication_admitstartdate_Internalname, "FilteredTextTo_set", Ddo_br_medication_admitstartdate_Filteredtextto_set);
               }
            }
            AV142GXV1 = (int)(AV142GXV1+1);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV11GridState.gxTpr_Pagesize))) )
         {
            subGrid_Rows = (int)(NumberUtil.Val( AV11GridState.gxTpr_Pagesize, "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         }
         subgrid_gotopage( AV11GridState.gxTpr_Currentpage) ;
      }

      protected void S142( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV11GridState.FromXml(AV15Session.Get(AV141Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV11GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV11GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV11GridState.gxTpr_Filtervalues.Clear();
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV31TFBR_Medication_RXName)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_RXNAME";
            AV12GridStateFilterValue.gxTpr_Value = AV31TFBR_Medication_RXName;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV32TFBR_Medication_RXName_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_RXNAME_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV32TFBR_Medication_RXName_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV35TFBR_Medication_RXCode)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_RXCODE";
            AV12GridStateFilterValue.gxTpr_Value = AV35TFBR_Medication_RXCode;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV36TFBR_Medication_RXCode_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_RXCODE_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV36TFBR_Medication_RXCode_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55TFBR_Medication_RXQuantity)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_RXQUANTITY";
            AV12GridStateFilterValue.gxTpr_Value = AV55TFBR_Medication_RXQuantity;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56TFBR_Medication_RXQuantity_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_RXQUANTITY_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV56TFBR_Medication_RXQuantity_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (Convert.ToDecimal(0)==AV59TFBR_Medication_RXDaysSupply) && (Convert.ToDecimal(0)==AV60TFBR_Medication_RXDaysSupply_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_RXDAYSSUPPLY";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( AV59TFBR_Medication_RXDaysSupply, 15, 5);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( AV60TFBR_Medication_RXDaysSupply_To, 15, 5);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51TFBR_Medication_RXFrequency)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_RXFREQUENCY";
            AV12GridStateFilterValue.gxTpr_Value = AV51TFBR_Medication_RXFrequency;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV122TFBR_Medication_RXFrequency_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_RXFREQUENCY_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV122TFBR_Medication_RXFrequency_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (DateTime.MinValue==AV77TFBR_Medication_AdmitStartDate) && (DateTime.MinValue==AV78TFBR_Medication_AdmitStartDate_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_MEDICATION_ADMITSTARTDATE";
            AV12GridStateFilterValue.gxTpr_Value = context.localUtil.DToC( AV77TFBR_Medication_AdmitStartDate, 0, "/");
            AV12GridStateFilterValue.gxTpr_Valueto = context.localUtil.DToC( AV78TFBR_Medication_AdmitStartDate_To, 0, "/");
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         AV11GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV11GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV141Pgmname+"GridState",  AV11GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV141Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Medication";
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
         PA3K2( ) ;
         WS3K2( ) ;
         WE3K2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202271202437", true);
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
         context.AddJavascriptSource("br_medicationww.js", "?20202271202437", false);
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
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_12_idx;
         edtBR_MedicationID_Internalname = "BR_MEDICATIONID_"+sGXsfl_12_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_12_idx;
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO_"+sGXsfl_12_idx;
         edtBR_Medication_RXName_Internalname = "BR_MEDICATION_RXNAME_"+sGXsfl_12_idx;
         edtBR_Medication_RXCode_Internalname = "BR_MEDICATION_RXCODE_"+sGXsfl_12_idx;
         edtBR_Medication_RXQuantity_Internalname = "BR_MEDICATION_RXQUANTITY_"+sGXsfl_12_idx;
         edtBR_Medication_RXDaysSupply_Internalname = "BR_MEDICATION_RXDAYSSUPPLY_"+sGXsfl_12_idx;
         edtBR_Medication_RXFrequency_Internalname = "BR_MEDICATION_RXFREQUENCY_"+sGXsfl_12_idx;
         edtBR_Medication_AdmitStartDate_Internalname = "BR_MEDICATION_ADMITSTARTDATE_"+sGXsfl_12_idx;
      }

      protected void SubsflControlProps_fel_122( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_12_fel_idx;
         edtBR_MedicationID_Internalname = "BR_MEDICATIONID_"+sGXsfl_12_fel_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_12_fel_idx;
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO_"+sGXsfl_12_fel_idx;
         edtBR_Medication_RXName_Internalname = "BR_MEDICATION_RXNAME_"+sGXsfl_12_fel_idx;
         edtBR_Medication_RXCode_Internalname = "BR_MEDICATION_RXCODE_"+sGXsfl_12_fel_idx;
         edtBR_Medication_RXQuantity_Internalname = "BR_MEDICATION_RXQUANTITY_"+sGXsfl_12_fel_idx;
         edtBR_Medication_RXDaysSupply_Internalname = "BR_MEDICATION_RXDAYSSUPPLY_"+sGXsfl_12_fel_idx;
         edtBR_Medication_RXFrequency_Internalname = "BR_MEDICATION_RXFREQUENCY_"+sGXsfl_12_fel_idx;
         edtBR_Medication_AdmitStartDate_Internalname = "BR_MEDICATION_ADMITSTARTDATE_"+sGXsfl_12_fel_idx;
      }

      protected void sendrow_122( )
      {
         SubsflControlProps_122( ) ;
         WB3K0( ) ;
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
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV113Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV113Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV140Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV113Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV113Display)) ? AV140Display_GXI : context.PathToRelativeUrl( AV113Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV113Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicationID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A119BR_MedicationID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A119BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicationID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_EncounterID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_EncounterID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Information_PatientNo_Internalname,(String)A36BR_Information_PatientNo,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Information_PatientNo_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)410,(String)"px",(short)17,(String)"px",(short)2000,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_RXName_Internalname,(String)A121BR_Medication_RXName,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_RXName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_RXCode_Internalname,(String)A122BR_Medication_RXCode,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_RXCode_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_RXQuantity_Internalname,(String)A127BR_Medication_RXQuantity,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_RXQuantity_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_RXDaysSupply_Internalname,StringUtil.LTrim( StringUtil.NToC( A128BR_Medication_RXDaysSupply, 15, 5, ".", "")),context.localUtil.Format( A128BR_Medication_RXDaysSupply, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_RXDaysSupply_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_RXFrequency_Internalname,(String)A126BR_Medication_RXFrequency,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_RXFrequency_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_AdmitStartDate_Internalname,context.localUtil.Format(A132BR_Medication_AdmitStartDate, "9999/99/99"),context.localUtil.Format( A132BR_Medication_AdmitStartDate, "9999/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_AdmitStartDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Date",(String)"right",(bool)false});
            send_integrity_lvl_hashes3K2( ) ;
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
         edtavDisplay_Internalname = "vDISPLAY";
         edtBR_MedicationID_Internalname = "BR_MEDICATIONID";
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO";
         edtBR_Medication_RXName_Internalname = "BR_MEDICATION_RXNAME";
         edtBR_Medication_RXCode_Internalname = "BR_MEDICATION_RXCODE";
         edtBR_Medication_RXQuantity_Internalname = "BR_MEDICATION_RXQUANTITY";
         edtBR_Medication_RXDaysSupply_Internalname = "BR_MEDICATION_RXDAYSSUPPLY";
         edtBR_Medication_RXFrequency_Internalname = "BR_MEDICATION_RXFREQUENCY";
         edtBR_Medication_AdmitStartDate_Internalname = "BR_MEDICATION_ADMITSTARTDATE";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_medication_rxname_Internalname = "DDO_BR_MEDICATION_RXNAME";
         edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE";
         Ddo_br_medication_rxcode_Internalname = "DDO_BR_MEDICATION_RXCODE";
         edtavDdo_br_medication_rxcodetitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE";
         Ddo_br_medication_rxquantity_Internalname = "DDO_BR_MEDICATION_RXQUANTITY";
         edtavDdo_br_medication_rxquantitytitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE";
         Ddo_br_medication_rxdayssupply_Internalname = "DDO_BR_MEDICATION_RXDAYSSUPPLY";
         edtavDdo_br_medication_rxdayssupplytitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE";
         Ddo_br_medication_rxfrequency_Internalname = "DDO_BR_MEDICATION_RXFREQUENCY";
         edtavDdo_br_medication_rxfrequencytitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE";
         Ddo_br_medication_admitstartdate_Internalname = "DDO_BR_MEDICATION_ADMITSTARTDATE";
         edtavDdo_br_medication_admitstartdatetitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         edtavTfbr_medication_rxname_Internalname = "vTFBR_MEDICATION_RXNAME";
         edtavTfbr_medication_rxname_sel_Internalname = "vTFBR_MEDICATION_RXNAME_SEL";
         edtavTfbr_medication_rxcode_Internalname = "vTFBR_MEDICATION_RXCODE";
         edtavTfbr_medication_rxcode_sel_Internalname = "vTFBR_MEDICATION_RXCODE_SEL";
         edtavTfbr_medication_rxquantity_Internalname = "vTFBR_MEDICATION_RXQUANTITY";
         edtavTfbr_medication_rxquantity_sel_Internalname = "vTFBR_MEDICATION_RXQUANTITY_SEL";
         edtavTfbr_medication_rxdayssupply_Internalname = "vTFBR_MEDICATION_RXDAYSSUPPLY";
         edtavTfbr_medication_rxdayssupply_to_Internalname = "vTFBR_MEDICATION_RXDAYSSUPPLY_TO";
         edtavTfbr_medication_rxfrequency_Internalname = "vTFBR_MEDICATION_RXFREQUENCY";
         edtavTfbr_medication_rxfrequency_sel_Internalname = "vTFBR_MEDICATION_RXFREQUENCY_SEL";
         edtavTfbr_medication_admitstartdate_Internalname = "vTFBR_MEDICATION_ADMITSTARTDATE";
         edtavTfbr_medication_admitstartdate_to_Internalname = "vTFBR_MEDICATION_ADMITSTARTDATE_TO";
         edtavDdo_br_medication_admitstartdateauxdate_Internalname = "vDDO_BR_MEDICATION_ADMITSTARTDATEAUXDATE";
         edtavDdo_br_medication_admitstartdateauxdateto_Internalname = "vDDO_BR_MEDICATION_ADMITSTARTDATEAUXDATETO";
         divDdo_br_medication_admitstartdateauxdates_Internalname = "DDO_BR_MEDICATION_ADMITSTARTDATEAUXDATES";
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
         edtBR_Medication_RXFrequency_Jsonclick = "";
         edtBR_Medication_RXDaysSupply_Jsonclick = "";
         edtBR_Medication_RXQuantity_Jsonclick = "";
         edtBR_Medication_RXCode_Jsonclick = "";
         edtBR_Medication_RXName_Jsonclick = "";
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_EncounterID_Jsonclick = "";
         edtBR_MedicationID_Jsonclick = "";
         edtavDdo_br_medication_admitstartdateauxdateto_Jsonclick = "";
         edtavDdo_br_medication_admitstartdateauxdate_Jsonclick = "";
         edtavTfbr_medication_admitstartdate_to_Jsonclick = "";
         edtavTfbr_medication_admitstartdate_to_Visible = 1;
         edtavTfbr_medication_admitstartdate_Jsonclick = "";
         edtavTfbr_medication_admitstartdate_Visible = 1;
         edtavTfbr_medication_rxfrequency_sel_Jsonclick = "";
         edtavTfbr_medication_rxfrequency_sel_Visible = 1;
         edtavTfbr_medication_rxfrequency_Jsonclick = "";
         edtavTfbr_medication_rxfrequency_Visible = 1;
         edtavTfbr_medication_rxdayssupply_to_Jsonclick = "";
         edtavTfbr_medication_rxdayssupply_to_Visible = 1;
         edtavTfbr_medication_rxdayssupply_Jsonclick = "";
         edtavTfbr_medication_rxdayssupply_Visible = 1;
         edtavTfbr_medication_rxquantity_sel_Jsonclick = "";
         edtavTfbr_medication_rxquantity_sel_Visible = 1;
         edtavTfbr_medication_rxquantity_Jsonclick = "";
         edtavTfbr_medication_rxquantity_Visible = 1;
         edtavTfbr_medication_rxcode_sel_Jsonclick = "";
         edtavTfbr_medication_rxcode_sel_Visible = 1;
         edtavTfbr_medication_rxcode_Jsonclick = "";
         edtavTfbr_medication_rxcode_Visible = 1;
         edtavTfbr_medication_rxname_sel_Jsonclick = "";
         edtavTfbr_medication_rxname_sel_Visible = 1;
         edtavTfbr_medication_rxname_Jsonclick = "";
         edtavTfbr_medication_rxname_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_medication_admitstartdatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medication_rxfrequencytitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medication_rxdayssupplytitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medication_rxquantitytitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medication_rxcodetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Medication_AdmitStartDate_Titleformat = 0;
         edtBR_Medication_AdmitStartDate_Title = "服药日期";
         edtBR_Medication_RXFrequency_Titleformat = 0;
         edtBR_Medication_RXFrequency_Title = "服药频率";
         edtBR_Medication_RXDaysSupply_Titleformat = 0;
         edtBR_Medication_RXDaysSupply_Title = "服药天数";
         edtBR_Medication_RXQuantity_Titleformat = 0;
         edtBR_Medication_RXQuantity_Title = "用药量";
         edtBR_Medication_RXCode_Titleformat = 0;
         edtBR_Medication_RXCode_Title = "药物代码";
         edtBR_Medication_RXName_Titleformat = 0;
         edtBR_Medication_RXName_Title = "药物名称";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         Ddo_br_medication_admitstartdate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_admitstartdate_Rangefilterto = "WWP_TSTo";
         Ddo_br_medication_admitstartdate_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_medication_admitstartdate_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_medication_admitstartdate_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_admitstartdate_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_admitstartdate_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medication_admitstartdate_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_medication_admitstartdate_Filtertype = "Date";
         Ddo_br_medication_admitstartdate_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_medication_admitstartdate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_admitstartdate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_admitstartdate_Titlecontrolidtoreplace = "";
         Ddo_br_medication_admitstartdate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_admitstartdate_Cls = "ColumnSettings";
         Ddo_br_medication_admitstartdate_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_admitstartdate_Caption = "";
         Ddo_br_medication_rxfrequency_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_rxfrequency_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_medication_rxfrequency_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_medication_rxfrequency_Loadingdata = "WWP_TSLoading";
         Ddo_br_medication_rxfrequency_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_rxfrequency_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_rxfrequency_Datalistupdateminimumcharacters = 0;
         Ddo_br_medication_rxfrequency_Datalistproc = "BR_MedicationWWGetFilterData";
         Ddo_br_medication_rxfrequency_Datalisttype = "Dynamic";
         Ddo_br_medication_rxfrequency_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_medication_rxfrequency_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_medication_rxfrequency_Filtertype = "Character";
         Ddo_br_medication_rxfrequency_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_medication_rxfrequency_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_rxfrequency_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_rxfrequency_Titlecontrolidtoreplace = "";
         Ddo_br_medication_rxfrequency_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_rxfrequency_Cls = "ColumnSettings";
         Ddo_br_medication_rxfrequency_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_rxfrequency_Caption = "";
         Ddo_br_medication_rxdayssupply_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_rxdayssupply_Rangefilterto = "WWP_TSTo";
         Ddo_br_medication_rxdayssupply_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_medication_rxdayssupply_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_medication_rxdayssupply_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_rxdayssupply_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_rxdayssupply_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medication_rxdayssupply_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_medication_rxdayssupply_Filtertype = "Numeric";
         Ddo_br_medication_rxdayssupply_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_medication_rxdayssupply_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_rxdayssupply_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_rxdayssupply_Titlecontrolidtoreplace = "";
         Ddo_br_medication_rxdayssupply_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_rxdayssupply_Cls = "ColumnSettings";
         Ddo_br_medication_rxdayssupply_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_rxdayssupply_Caption = "";
         Ddo_br_medication_rxquantity_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_rxquantity_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_medication_rxquantity_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_medication_rxquantity_Loadingdata = "WWP_TSLoading";
         Ddo_br_medication_rxquantity_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_rxquantity_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_rxquantity_Datalistupdateminimumcharacters = 0;
         Ddo_br_medication_rxquantity_Datalistproc = "BR_MedicationWWGetFilterData";
         Ddo_br_medication_rxquantity_Datalisttype = "Dynamic";
         Ddo_br_medication_rxquantity_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_medication_rxquantity_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_medication_rxquantity_Filtertype = "Character";
         Ddo_br_medication_rxquantity_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_medication_rxquantity_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_rxquantity_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_rxquantity_Titlecontrolidtoreplace = "";
         Ddo_br_medication_rxquantity_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_rxquantity_Cls = "ColumnSettings";
         Ddo_br_medication_rxquantity_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_rxquantity_Caption = "";
         Ddo_br_medication_rxcode_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_rxcode_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_medication_rxcode_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_medication_rxcode_Loadingdata = "WWP_TSLoading";
         Ddo_br_medication_rxcode_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_rxcode_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_rxcode_Datalistupdateminimumcharacters = 0;
         Ddo_br_medication_rxcode_Datalistproc = "BR_MedicationWWGetFilterData";
         Ddo_br_medication_rxcode_Datalisttype = "Dynamic";
         Ddo_br_medication_rxcode_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_medication_rxcode_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_medication_rxcode_Filtertype = "Character";
         Ddo_br_medication_rxcode_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_medication_rxcode_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_rxcode_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_rxcode_Titlecontrolidtoreplace = "";
         Ddo_br_medication_rxcode_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_rxcode_Cls = "ColumnSettings";
         Ddo_br_medication_rxcode_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_rxcode_Caption = "";
         Ddo_br_medication_rxname_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_rxname_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_medication_rxname_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_medication_rxname_Loadingdata = "WWP_TSLoading";
         Ddo_br_medication_rxname_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_rxname_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_rxname_Datalistupdateminimumcharacters = 0;
         Ddo_br_medication_rxname_Datalistproc = "BR_MedicationWWGetFilterData";
         Ddo_br_medication_rxname_Datalisttype = "Dynamic";
         Ddo_br_medication_rxname_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_medication_rxname_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_medication_rxname_Filtertype = "Character";
         Ddo_br_medication_rxname_Includefilter = Convert.ToBoolean( -1);
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
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = " 药物治疗";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV33ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV31TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV32TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV35TFBR_Medication_RXCode',fld:'vTFBR_MEDICATION_RXCODE',pic:''},{av:'AV36TFBR_Medication_RXCode_Sel',fld:'vTFBR_MEDICATION_RXCODE_SEL',pic:''},{av:'AV55TFBR_Medication_RXQuantity',fld:'vTFBR_MEDICATION_RXQUANTITY',pic:''},{av:'AV56TFBR_Medication_RXQuantity_Sel',fld:'vTFBR_MEDICATION_RXQUANTITY_SEL',pic:''},{av:'AV59TFBR_Medication_RXDaysSupply',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_RXDaysSupply_To',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Medication_RXFrequency',fld:'vTFBR_MEDICATION_RXFREQUENCY',pic:''},{av:'AV122TFBR_Medication_RXFrequency_Sel',fld:'vTFBR_MEDICATION_RXFREQUENCY_SEL',pic:''},{av:'AV77TFBR_Medication_AdmitStartDate',fld:'vTFBR_MEDICATION_ADMITSTARTDATE',pic:''},{av:'AV78TFBR_Medication_AdmitStartDate_To',fld:'vTFBR_MEDICATION_ADMITSTARTDATE_TO',pic:''},{av:'AV141Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV30BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_RXCodeTitleFilterData',fld:'vBR_MEDICATION_RXCODETITLEFILTERDATA',pic:''},{av:'AV54BR_Medication_RXQuantityTitleFilterData',fld:'vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA',pic:''},{av:'AV58BR_Medication_RXDaysSupplyTitleFilterData',fld:'vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA',pic:''},{av:'AV50BR_Medication_RXFrequencyTitleFilterData',fld:'vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA',pic:''},{av:'AV76BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXCode_Titleformat',ctrl:'BR_MEDICATION_RXCODE',prop:'Titleformat'},{av:'edtBR_Medication_RXCode_Title',ctrl:'BR_MEDICATION_RXCODE',prop:'Title'},{av:'edtBR_Medication_RXQuantity_Titleformat',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Titleformat'},{av:'edtBR_Medication_RXQuantity_Title',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Title'},{av:'edtBR_Medication_RXDaysSupply_Titleformat',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Titleformat'},{av:'edtBR_Medication_RXDaysSupply_Title',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Title'},{av:'edtBR_Medication_RXFrequency_Titleformat',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Titleformat'},{av:'edtBR_Medication_RXFrequency_Title',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Title'},{av:'edtBR_Medication_AdmitStartDate_Titleformat',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'edtBR_Medication_AdmitStartDate_Title',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'AV110GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV111GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV112GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E113K2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV32TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV35TFBR_Medication_RXCode',fld:'vTFBR_MEDICATION_RXCODE',pic:''},{av:'AV36TFBR_Medication_RXCode_Sel',fld:'vTFBR_MEDICATION_RXCODE_SEL',pic:''},{av:'AV55TFBR_Medication_RXQuantity',fld:'vTFBR_MEDICATION_RXQUANTITY',pic:''},{av:'AV56TFBR_Medication_RXQuantity_Sel',fld:'vTFBR_MEDICATION_RXQUANTITY_SEL',pic:''},{av:'AV59TFBR_Medication_RXDaysSupply',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_RXDaysSupply_To',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Medication_RXFrequency',fld:'vTFBR_MEDICATION_RXFREQUENCY',pic:''},{av:'AV122TFBR_Medication_RXFrequency_Sel',fld:'vTFBR_MEDICATION_RXFREQUENCY_SEL',pic:''},{av:'AV77TFBR_Medication_AdmitStartDate',fld:'vTFBR_MEDICATION_ADMITSTARTDATE',pic:''},{av:'AV78TFBR_Medication_AdmitStartDate_To',fld:'vTFBR_MEDICATION_ADMITSTARTDATE_TO',pic:''},{av:'AV33ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV141Pgmname',fld:'vPGMNAME',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E123K2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV32TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV35TFBR_Medication_RXCode',fld:'vTFBR_MEDICATION_RXCODE',pic:''},{av:'AV36TFBR_Medication_RXCode_Sel',fld:'vTFBR_MEDICATION_RXCODE_SEL',pic:''},{av:'AV55TFBR_Medication_RXQuantity',fld:'vTFBR_MEDICATION_RXQUANTITY',pic:''},{av:'AV56TFBR_Medication_RXQuantity_Sel',fld:'vTFBR_MEDICATION_RXQUANTITY_SEL',pic:''},{av:'AV59TFBR_Medication_RXDaysSupply',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_RXDaysSupply_To',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Medication_RXFrequency',fld:'vTFBR_MEDICATION_RXFREQUENCY',pic:''},{av:'AV122TFBR_Medication_RXFrequency_Sel',fld:'vTFBR_MEDICATION_RXFREQUENCY_SEL',pic:''},{av:'AV77TFBR_Medication_AdmitStartDate',fld:'vTFBR_MEDICATION_ADMITSTARTDATE',pic:''},{av:'AV78TFBR_Medication_AdmitStartDate_To',fld:'vTFBR_MEDICATION_ADMITSTARTDATE_TO',pic:''},{av:'AV33ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV141Pgmname',fld:'vPGMNAME',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED","{handler:'E133K2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV32TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV35TFBR_Medication_RXCode',fld:'vTFBR_MEDICATION_RXCODE',pic:''},{av:'AV36TFBR_Medication_RXCode_Sel',fld:'vTFBR_MEDICATION_RXCODE_SEL',pic:''},{av:'AV55TFBR_Medication_RXQuantity',fld:'vTFBR_MEDICATION_RXQUANTITY',pic:''},{av:'AV56TFBR_Medication_RXQuantity_Sel',fld:'vTFBR_MEDICATION_RXQUANTITY_SEL',pic:''},{av:'AV59TFBR_Medication_RXDaysSupply',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_RXDaysSupply_To',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Medication_RXFrequency',fld:'vTFBR_MEDICATION_RXFREQUENCY',pic:''},{av:'AV122TFBR_Medication_RXFrequency_Sel',fld:'vTFBR_MEDICATION_RXFREQUENCY_SEL',pic:''},{av:'AV77TFBR_Medication_AdmitStartDate',fld:'vTFBR_MEDICATION_ADMITSTARTDATE',pic:''},{av:'AV78TFBR_Medication_AdmitStartDate_To',fld:'vTFBR_MEDICATION_ADMITSTARTDATE_TO',pic:''},{av:'AV33ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV141Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_br_medication_rxname_Activeeventkey',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'ActiveEventKey'},{av:'Ddo_br_medication_rxname_Filteredtext_get',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'FilteredText_get'},{av:'Ddo_br_medication_rxname_Selectedvalue_get',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_rxname_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'AV31TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV32TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'Ddo_br_medication_rxcode_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXCODE',prop:'SortedStatus'},{av:'Ddo_br_medication_rxquantity_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SortedStatus'},{av:'Ddo_br_medication_rxdayssupply_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'SortedStatus'},{av:'Ddo_br_medication_rxfrequency_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SortedStatus'},{av:'Ddo_br_medication_admitstartdate_Sortedstatus',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'SortedStatus'},{av:'AV30BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_RXCodeTitleFilterData',fld:'vBR_MEDICATION_RXCODETITLEFILTERDATA',pic:''},{av:'AV54BR_Medication_RXQuantityTitleFilterData',fld:'vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA',pic:''},{av:'AV58BR_Medication_RXDaysSupplyTitleFilterData',fld:'vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA',pic:''},{av:'AV50BR_Medication_RXFrequencyTitleFilterData',fld:'vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA',pic:''},{av:'AV76BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXCode_Titleformat',ctrl:'BR_MEDICATION_RXCODE',prop:'Titleformat'},{av:'edtBR_Medication_RXCode_Title',ctrl:'BR_MEDICATION_RXCODE',prop:'Title'},{av:'edtBR_Medication_RXQuantity_Titleformat',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Titleformat'},{av:'edtBR_Medication_RXQuantity_Title',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Title'},{av:'edtBR_Medication_RXDaysSupply_Titleformat',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Titleformat'},{av:'edtBR_Medication_RXDaysSupply_Title',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Title'},{av:'edtBR_Medication_RXFrequency_Titleformat',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Titleformat'},{av:'edtBR_Medication_RXFrequency_Title',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Title'},{av:'edtBR_Medication_AdmitStartDate_Titleformat',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'edtBR_Medication_AdmitStartDate_Title',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'AV110GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV111GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV112GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICATION_RXCODE.ONOPTIONCLICKED","{handler:'E143K2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV32TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV35TFBR_Medication_RXCode',fld:'vTFBR_MEDICATION_RXCODE',pic:''},{av:'AV36TFBR_Medication_RXCode_Sel',fld:'vTFBR_MEDICATION_RXCODE_SEL',pic:''},{av:'AV55TFBR_Medication_RXQuantity',fld:'vTFBR_MEDICATION_RXQUANTITY',pic:''},{av:'AV56TFBR_Medication_RXQuantity_Sel',fld:'vTFBR_MEDICATION_RXQUANTITY_SEL',pic:''},{av:'AV59TFBR_Medication_RXDaysSupply',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_RXDaysSupply_To',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Medication_RXFrequency',fld:'vTFBR_MEDICATION_RXFREQUENCY',pic:''},{av:'AV122TFBR_Medication_RXFrequency_Sel',fld:'vTFBR_MEDICATION_RXFREQUENCY_SEL',pic:''},{av:'AV77TFBR_Medication_AdmitStartDate',fld:'vTFBR_MEDICATION_ADMITSTARTDATE',pic:''},{av:'AV78TFBR_Medication_AdmitStartDate_To',fld:'vTFBR_MEDICATION_ADMITSTARTDATE_TO',pic:''},{av:'AV33ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV141Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_br_medication_rxcode_Activeeventkey',ctrl:'DDO_BR_MEDICATION_RXCODE',prop:'ActiveEventKey'},{av:'Ddo_br_medication_rxcode_Filteredtext_get',ctrl:'DDO_BR_MEDICATION_RXCODE',prop:'FilteredText_get'},{av:'Ddo_br_medication_rxcode_Selectedvalue_get',ctrl:'DDO_BR_MEDICATION_RXCODE',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_MEDICATION_RXCODE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_rxcode_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXCODE',prop:'SortedStatus'},{av:'AV35TFBR_Medication_RXCode',fld:'vTFBR_MEDICATION_RXCODE',pic:''},{av:'AV36TFBR_Medication_RXCode_Sel',fld:'vTFBR_MEDICATION_RXCODE_SEL',pic:''},{av:'Ddo_br_medication_rxname_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'Ddo_br_medication_rxquantity_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SortedStatus'},{av:'Ddo_br_medication_rxdayssupply_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'SortedStatus'},{av:'Ddo_br_medication_rxfrequency_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SortedStatus'},{av:'Ddo_br_medication_admitstartdate_Sortedstatus',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'SortedStatus'},{av:'AV30BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_RXCodeTitleFilterData',fld:'vBR_MEDICATION_RXCODETITLEFILTERDATA',pic:''},{av:'AV54BR_Medication_RXQuantityTitleFilterData',fld:'vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA',pic:''},{av:'AV58BR_Medication_RXDaysSupplyTitleFilterData',fld:'vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA',pic:''},{av:'AV50BR_Medication_RXFrequencyTitleFilterData',fld:'vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA',pic:''},{av:'AV76BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXCode_Titleformat',ctrl:'BR_MEDICATION_RXCODE',prop:'Titleformat'},{av:'edtBR_Medication_RXCode_Title',ctrl:'BR_MEDICATION_RXCODE',prop:'Title'},{av:'edtBR_Medication_RXQuantity_Titleformat',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Titleformat'},{av:'edtBR_Medication_RXQuantity_Title',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Title'},{av:'edtBR_Medication_RXDaysSupply_Titleformat',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Titleformat'},{av:'edtBR_Medication_RXDaysSupply_Title',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Title'},{av:'edtBR_Medication_RXFrequency_Titleformat',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Titleformat'},{av:'edtBR_Medication_RXFrequency_Title',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Title'},{av:'edtBR_Medication_AdmitStartDate_Titleformat',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'edtBR_Medication_AdmitStartDate_Title',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'AV110GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV111GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV112GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICATION_RXQUANTITY.ONOPTIONCLICKED","{handler:'E153K2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV32TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV35TFBR_Medication_RXCode',fld:'vTFBR_MEDICATION_RXCODE',pic:''},{av:'AV36TFBR_Medication_RXCode_Sel',fld:'vTFBR_MEDICATION_RXCODE_SEL',pic:''},{av:'AV55TFBR_Medication_RXQuantity',fld:'vTFBR_MEDICATION_RXQUANTITY',pic:''},{av:'AV56TFBR_Medication_RXQuantity_Sel',fld:'vTFBR_MEDICATION_RXQUANTITY_SEL',pic:''},{av:'AV59TFBR_Medication_RXDaysSupply',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_RXDaysSupply_To',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Medication_RXFrequency',fld:'vTFBR_MEDICATION_RXFREQUENCY',pic:''},{av:'AV122TFBR_Medication_RXFrequency_Sel',fld:'vTFBR_MEDICATION_RXFREQUENCY_SEL',pic:''},{av:'AV77TFBR_Medication_AdmitStartDate',fld:'vTFBR_MEDICATION_ADMITSTARTDATE',pic:''},{av:'AV78TFBR_Medication_AdmitStartDate_To',fld:'vTFBR_MEDICATION_ADMITSTARTDATE_TO',pic:''},{av:'AV33ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV141Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_br_medication_rxquantity_Activeeventkey',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'ActiveEventKey'},{av:'Ddo_br_medication_rxquantity_Filteredtext_get',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'FilteredText_get'},{av:'Ddo_br_medication_rxquantity_Selectedvalue_get',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_MEDICATION_RXQUANTITY.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_rxquantity_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SortedStatus'},{av:'AV55TFBR_Medication_RXQuantity',fld:'vTFBR_MEDICATION_RXQUANTITY',pic:''},{av:'AV56TFBR_Medication_RXQuantity_Sel',fld:'vTFBR_MEDICATION_RXQUANTITY_SEL',pic:''},{av:'Ddo_br_medication_rxname_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'Ddo_br_medication_rxcode_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXCODE',prop:'SortedStatus'},{av:'Ddo_br_medication_rxdayssupply_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'SortedStatus'},{av:'Ddo_br_medication_rxfrequency_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SortedStatus'},{av:'Ddo_br_medication_admitstartdate_Sortedstatus',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'SortedStatus'},{av:'AV30BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_RXCodeTitleFilterData',fld:'vBR_MEDICATION_RXCODETITLEFILTERDATA',pic:''},{av:'AV54BR_Medication_RXQuantityTitleFilterData',fld:'vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA',pic:''},{av:'AV58BR_Medication_RXDaysSupplyTitleFilterData',fld:'vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA',pic:''},{av:'AV50BR_Medication_RXFrequencyTitleFilterData',fld:'vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA',pic:''},{av:'AV76BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXCode_Titleformat',ctrl:'BR_MEDICATION_RXCODE',prop:'Titleformat'},{av:'edtBR_Medication_RXCode_Title',ctrl:'BR_MEDICATION_RXCODE',prop:'Title'},{av:'edtBR_Medication_RXQuantity_Titleformat',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Titleformat'},{av:'edtBR_Medication_RXQuantity_Title',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Title'},{av:'edtBR_Medication_RXDaysSupply_Titleformat',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Titleformat'},{av:'edtBR_Medication_RXDaysSupply_Title',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Title'},{av:'edtBR_Medication_RXFrequency_Titleformat',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Titleformat'},{av:'edtBR_Medication_RXFrequency_Title',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Title'},{av:'edtBR_Medication_AdmitStartDate_Titleformat',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'edtBR_Medication_AdmitStartDate_Title',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'AV110GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV111GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV112GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICATION_RXDAYSSUPPLY.ONOPTIONCLICKED","{handler:'E163K2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV32TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV35TFBR_Medication_RXCode',fld:'vTFBR_MEDICATION_RXCODE',pic:''},{av:'AV36TFBR_Medication_RXCode_Sel',fld:'vTFBR_MEDICATION_RXCODE_SEL',pic:''},{av:'AV55TFBR_Medication_RXQuantity',fld:'vTFBR_MEDICATION_RXQUANTITY',pic:''},{av:'AV56TFBR_Medication_RXQuantity_Sel',fld:'vTFBR_MEDICATION_RXQUANTITY_SEL',pic:''},{av:'AV59TFBR_Medication_RXDaysSupply',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_RXDaysSupply_To',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Medication_RXFrequency',fld:'vTFBR_MEDICATION_RXFREQUENCY',pic:''},{av:'AV122TFBR_Medication_RXFrequency_Sel',fld:'vTFBR_MEDICATION_RXFREQUENCY_SEL',pic:''},{av:'AV77TFBR_Medication_AdmitStartDate',fld:'vTFBR_MEDICATION_ADMITSTARTDATE',pic:''},{av:'AV78TFBR_Medication_AdmitStartDate_To',fld:'vTFBR_MEDICATION_ADMITSTARTDATE_TO',pic:''},{av:'AV33ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV141Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_br_medication_rxdayssupply_Activeeventkey',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'ActiveEventKey'},{av:'Ddo_br_medication_rxdayssupply_Filteredtext_get',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'FilteredText_get'},{av:'Ddo_br_medication_rxdayssupply_Filteredtextto_get',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_MEDICATION_RXDAYSSUPPLY.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_rxdayssupply_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'SortedStatus'},{av:'AV59TFBR_Medication_RXDaysSupply',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_RXDaysSupply_To',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'Ddo_br_medication_rxname_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'Ddo_br_medication_rxcode_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXCODE',prop:'SortedStatus'},{av:'Ddo_br_medication_rxquantity_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SortedStatus'},{av:'Ddo_br_medication_rxfrequency_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SortedStatus'},{av:'Ddo_br_medication_admitstartdate_Sortedstatus',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'SortedStatus'},{av:'AV30BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_RXCodeTitleFilterData',fld:'vBR_MEDICATION_RXCODETITLEFILTERDATA',pic:''},{av:'AV54BR_Medication_RXQuantityTitleFilterData',fld:'vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA',pic:''},{av:'AV58BR_Medication_RXDaysSupplyTitleFilterData',fld:'vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA',pic:''},{av:'AV50BR_Medication_RXFrequencyTitleFilterData',fld:'vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA',pic:''},{av:'AV76BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXCode_Titleformat',ctrl:'BR_MEDICATION_RXCODE',prop:'Titleformat'},{av:'edtBR_Medication_RXCode_Title',ctrl:'BR_MEDICATION_RXCODE',prop:'Title'},{av:'edtBR_Medication_RXQuantity_Titleformat',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Titleformat'},{av:'edtBR_Medication_RXQuantity_Title',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Title'},{av:'edtBR_Medication_RXDaysSupply_Titleformat',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Titleformat'},{av:'edtBR_Medication_RXDaysSupply_Title',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Title'},{av:'edtBR_Medication_RXFrequency_Titleformat',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Titleformat'},{av:'edtBR_Medication_RXFrequency_Title',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Title'},{av:'edtBR_Medication_AdmitStartDate_Titleformat',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'edtBR_Medication_AdmitStartDate_Title',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'AV110GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV111GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV112GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICATION_RXFREQUENCY.ONOPTIONCLICKED","{handler:'E173K2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV32TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV35TFBR_Medication_RXCode',fld:'vTFBR_MEDICATION_RXCODE',pic:''},{av:'AV36TFBR_Medication_RXCode_Sel',fld:'vTFBR_MEDICATION_RXCODE_SEL',pic:''},{av:'AV55TFBR_Medication_RXQuantity',fld:'vTFBR_MEDICATION_RXQUANTITY',pic:''},{av:'AV56TFBR_Medication_RXQuantity_Sel',fld:'vTFBR_MEDICATION_RXQUANTITY_SEL',pic:''},{av:'AV59TFBR_Medication_RXDaysSupply',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_RXDaysSupply_To',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Medication_RXFrequency',fld:'vTFBR_MEDICATION_RXFREQUENCY',pic:''},{av:'AV122TFBR_Medication_RXFrequency_Sel',fld:'vTFBR_MEDICATION_RXFREQUENCY_SEL',pic:''},{av:'AV77TFBR_Medication_AdmitStartDate',fld:'vTFBR_MEDICATION_ADMITSTARTDATE',pic:''},{av:'AV78TFBR_Medication_AdmitStartDate_To',fld:'vTFBR_MEDICATION_ADMITSTARTDATE_TO',pic:''},{av:'AV33ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV141Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_br_medication_rxfrequency_Activeeventkey',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'ActiveEventKey'},{av:'Ddo_br_medication_rxfrequency_Filteredtext_get',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'FilteredText_get'},{av:'Ddo_br_medication_rxfrequency_Selectedvalue_get',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_MEDICATION_RXFREQUENCY.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_rxfrequency_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SortedStatus'},{av:'AV51TFBR_Medication_RXFrequency',fld:'vTFBR_MEDICATION_RXFREQUENCY',pic:''},{av:'AV122TFBR_Medication_RXFrequency_Sel',fld:'vTFBR_MEDICATION_RXFREQUENCY_SEL',pic:''},{av:'Ddo_br_medication_rxname_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'Ddo_br_medication_rxcode_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXCODE',prop:'SortedStatus'},{av:'Ddo_br_medication_rxquantity_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SortedStatus'},{av:'Ddo_br_medication_rxdayssupply_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'SortedStatus'},{av:'Ddo_br_medication_admitstartdate_Sortedstatus',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'SortedStatus'},{av:'AV30BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_RXCodeTitleFilterData',fld:'vBR_MEDICATION_RXCODETITLEFILTERDATA',pic:''},{av:'AV54BR_Medication_RXQuantityTitleFilterData',fld:'vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA',pic:''},{av:'AV58BR_Medication_RXDaysSupplyTitleFilterData',fld:'vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA',pic:''},{av:'AV50BR_Medication_RXFrequencyTitleFilterData',fld:'vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA',pic:''},{av:'AV76BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXCode_Titleformat',ctrl:'BR_MEDICATION_RXCODE',prop:'Titleformat'},{av:'edtBR_Medication_RXCode_Title',ctrl:'BR_MEDICATION_RXCODE',prop:'Title'},{av:'edtBR_Medication_RXQuantity_Titleformat',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Titleformat'},{av:'edtBR_Medication_RXQuantity_Title',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Title'},{av:'edtBR_Medication_RXDaysSupply_Titleformat',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Titleformat'},{av:'edtBR_Medication_RXDaysSupply_Title',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Title'},{av:'edtBR_Medication_RXFrequency_Titleformat',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Titleformat'},{av:'edtBR_Medication_RXFrequency_Title',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Title'},{av:'edtBR_Medication_AdmitStartDate_Titleformat',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'edtBR_Medication_AdmitStartDate_Title',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'AV110GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV111GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV112GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICATION_ADMITSTARTDATE.ONOPTIONCLICKED","{handler:'E183K2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV31TFBR_Medication_RXName',fld:'vTFBR_MEDICATION_RXNAME',pic:''},{av:'AV32TFBR_Medication_RXName_Sel',fld:'vTFBR_MEDICATION_RXNAME_SEL',pic:''},{av:'AV35TFBR_Medication_RXCode',fld:'vTFBR_MEDICATION_RXCODE',pic:''},{av:'AV36TFBR_Medication_RXCode_Sel',fld:'vTFBR_MEDICATION_RXCODE_SEL',pic:''},{av:'AV55TFBR_Medication_RXQuantity',fld:'vTFBR_MEDICATION_RXQUANTITY',pic:''},{av:'AV56TFBR_Medication_RXQuantity_Sel',fld:'vTFBR_MEDICATION_RXQUANTITY_SEL',pic:''},{av:'AV59TFBR_Medication_RXDaysSupply',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV60TFBR_Medication_RXDaysSupply_To',fld:'vTFBR_MEDICATION_RXDAYSSUPPLY_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV51TFBR_Medication_RXFrequency',fld:'vTFBR_MEDICATION_RXFREQUENCY',pic:''},{av:'AV122TFBR_Medication_RXFrequency_Sel',fld:'vTFBR_MEDICATION_RXFREQUENCY_SEL',pic:''},{av:'AV77TFBR_Medication_AdmitStartDate',fld:'vTFBR_MEDICATION_ADMITSTARTDATE',pic:''},{av:'AV78TFBR_Medication_AdmitStartDate_To',fld:'vTFBR_MEDICATION_ADMITSTARTDATE_TO',pic:''},{av:'AV33ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXQUANTITYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDAYSSUPPLYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXFREQUENCYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV141Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_br_medication_admitstartdate_Activeeventkey',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'ActiveEventKey'},{av:'Ddo_br_medication_admitstartdate_Filteredtext_get',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'FilteredText_get'},{av:'Ddo_br_medication_admitstartdate_Filteredtextto_get',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_MEDICATION_ADMITSTARTDATE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_admitstartdate_Sortedstatus',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'SortedStatus'},{av:'AV77TFBR_Medication_AdmitStartDate',fld:'vTFBR_MEDICATION_ADMITSTARTDATE',pic:''},{av:'AV78TFBR_Medication_AdmitStartDate_To',fld:'vTFBR_MEDICATION_ADMITSTARTDATE_TO',pic:''},{av:'Ddo_br_medication_rxname_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'Ddo_br_medication_rxcode_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXCODE',prop:'SortedStatus'},{av:'Ddo_br_medication_rxquantity_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXQUANTITY',prop:'SortedStatus'},{av:'Ddo_br_medication_rxdayssupply_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDAYSSUPPLY',prop:'SortedStatus'},{av:'Ddo_br_medication_rxfrequency_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXFREQUENCY',prop:'SortedStatus'},{av:'AV30BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_RXCodeTitleFilterData',fld:'vBR_MEDICATION_RXCODETITLEFILTERDATA',pic:''},{av:'AV54BR_Medication_RXQuantityTitleFilterData',fld:'vBR_MEDICATION_RXQUANTITYTITLEFILTERDATA',pic:''},{av:'AV58BR_Medication_RXDaysSupplyTitleFilterData',fld:'vBR_MEDICATION_RXDAYSSUPPLYTITLEFILTERDATA',pic:''},{av:'AV50BR_Medication_RXFrequencyTitleFilterData',fld:'vBR_MEDICATION_RXFREQUENCYTITLEFILTERDATA',pic:''},{av:'AV76BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXCode_Titleformat',ctrl:'BR_MEDICATION_RXCODE',prop:'Titleformat'},{av:'edtBR_Medication_RXCode_Title',ctrl:'BR_MEDICATION_RXCODE',prop:'Title'},{av:'edtBR_Medication_RXQuantity_Titleformat',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Titleformat'},{av:'edtBR_Medication_RXQuantity_Title',ctrl:'BR_MEDICATION_RXQUANTITY',prop:'Title'},{av:'edtBR_Medication_RXDaysSupply_Titleformat',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Titleformat'},{av:'edtBR_Medication_RXDaysSupply_Title',ctrl:'BR_MEDICATION_RXDAYSSUPPLY',prop:'Title'},{av:'edtBR_Medication_RXFrequency_Titleformat',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Titleformat'},{av:'edtBR_Medication_RXFrequency_Title',ctrl:'BR_MEDICATION_RXFREQUENCY',prop:'Title'},{av:'edtBR_Medication_AdmitStartDate_Titleformat',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'edtBR_Medication_AdmitStartDate_Title',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'AV110GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV111GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV112GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E213K2',iparms:[{av:'A119BR_MedicationID',fld:'BR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV113Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'}]}");
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
         Ddo_br_medication_rxname_Filteredtext_get = "";
         Ddo_br_medication_rxname_Selectedvalue_get = "";
         Ddo_br_medication_rxcode_Activeeventkey = "";
         Ddo_br_medication_rxcode_Filteredtext_get = "";
         Ddo_br_medication_rxcode_Selectedvalue_get = "";
         Ddo_br_medication_rxquantity_Activeeventkey = "";
         Ddo_br_medication_rxquantity_Filteredtext_get = "";
         Ddo_br_medication_rxquantity_Selectedvalue_get = "";
         Ddo_br_medication_rxdayssupply_Activeeventkey = "";
         Ddo_br_medication_rxdayssupply_Filteredtext_get = "";
         Ddo_br_medication_rxdayssupply_Filteredtextto_get = "";
         Ddo_br_medication_rxfrequency_Activeeventkey = "";
         Ddo_br_medication_rxfrequency_Filteredtext_get = "";
         Ddo_br_medication_rxfrequency_Selectedvalue_get = "";
         Ddo_br_medication_admitstartdate_Activeeventkey = "";
         Ddo_br_medication_admitstartdate_Filteredtext_get = "";
         Ddo_br_medication_admitstartdate_Filteredtextto_get = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV31TFBR_Medication_RXName = "";
         AV32TFBR_Medication_RXName_Sel = "";
         AV35TFBR_Medication_RXCode = "";
         AV36TFBR_Medication_RXCode_Sel = "";
         AV55TFBR_Medication_RXQuantity = "";
         AV56TFBR_Medication_RXQuantity_Sel = "";
         AV51TFBR_Medication_RXFrequency = "";
         AV122TFBR_Medication_RXFrequency_Sel = "";
         AV77TFBR_Medication_AdmitStartDate = DateTime.MinValue;
         AV78TFBR_Medication_AdmitStartDate_To = DateTime.MinValue;
         AV33ddo_BR_Medication_RXNameTitleControlIdToReplace = "";
         AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace = "";
         AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace = "";
         AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace = "";
         AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace = "";
         AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace = "";
         AV141Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV108DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV30BR_Medication_RXNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV34BR_Medication_RXCodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV54BR_Medication_RXQuantityTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV58BR_Medication_RXDaysSupplyTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV50BR_Medication_RXFrequencyTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV76BR_Medication_AdmitStartDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_medication_rxname_Filteredtext_set = "";
         Ddo_br_medication_rxname_Selectedvalue_set = "";
         Ddo_br_medication_rxname_Sortedstatus = "";
         Ddo_br_medication_rxcode_Filteredtext_set = "";
         Ddo_br_medication_rxcode_Selectedvalue_set = "";
         Ddo_br_medication_rxcode_Sortedstatus = "";
         Ddo_br_medication_rxquantity_Filteredtext_set = "";
         Ddo_br_medication_rxquantity_Selectedvalue_set = "";
         Ddo_br_medication_rxquantity_Sortedstatus = "";
         Ddo_br_medication_rxdayssupply_Filteredtext_set = "";
         Ddo_br_medication_rxdayssupply_Filteredtextto_set = "";
         Ddo_br_medication_rxdayssupply_Sortedstatus = "";
         Ddo_br_medication_rxfrequency_Filteredtext_set = "";
         Ddo_br_medication_rxfrequency_Selectedvalue_set = "";
         Ddo_br_medication_rxfrequency_Sortedstatus = "";
         Ddo_br_medication_admitstartdate_Filteredtext_set = "";
         Ddo_br_medication_admitstartdate_Filteredtextto_set = "";
         Ddo_br_medication_admitstartdate_Sortedstatus = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV113Display = "";
         A36BR_Information_PatientNo = "";
         A121BR_Medication_RXName = "";
         A122BR_Medication_RXCode = "";
         A127BR_Medication_RXQuantity = "";
         A126BR_Medication_RXFrequency = "";
         A132BR_Medication_AdmitStartDate = DateTime.MinValue;
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_medication_rxname = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_br_medication_rxcode = new GXUserControl();
         ucDdo_br_medication_rxquantity = new GXUserControl();
         ucDdo_br_medication_rxdayssupply = new GXUserControl();
         ucDdo_br_medication_rxfrequency = new GXUserControl();
         ucDdo_br_medication_admitstartdate = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         AV79DDO_BR_Medication_AdmitStartDateAuxDate = DateTime.MinValue;
         AV80DDO_BR_Medication_AdmitStartDateAuxDateTo = DateTime.MinValue;
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV140Display_GXI = "";
         scmdbuf = "";
         lV128BR_MedicationWWDS_1_Tfbr_medication_rxname = "";
         lV130BR_MedicationWWDS_3_Tfbr_medication_rxcode = "";
         lV132BR_MedicationWWDS_5_Tfbr_medication_rxquantity = "";
         lV136BR_MedicationWWDS_9_Tfbr_medication_rxfrequency = "";
         AV129BR_MedicationWWDS_2_Tfbr_medication_rxname_sel = "";
         AV128BR_MedicationWWDS_1_Tfbr_medication_rxname = "";
         AV131BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel = "";
         AV130BR_MedicationWWDS_3_Tfbr_medication_rxcode = "";
         AV133BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel = "";
         AV132BR_MedicationWWDS_5_Tfbr_medication_rxquantity = "";
         AV137BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel = "";
         AV136BR_MedicationWWDS_9_Tfbr_medication_rxfrequency = "";
         AV138BR_MedicationWWDS_11_Tfbr_medication_admitstartdate = DateTime.MinValue;
         AV139BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to = DateTime.MinValue;
         H003K2_A85BR_Information_ID = new long[1] ;
         H003K2_n85BR_Information_ID = new bool[] {false} ;
         H003K2_A132BR_Medication_AdmitStartDate = new DateTime[] {DateTime.MinValue} ;
         H003K2_n132BR_Medication_AdmitStartDate = new bool[] {false} ;
         H003K2_A126BR_Medication_RXFrequency = new String[] {""} ;
         H003K2_n126BR_Medication_RXFrequency = new bool[] {false} ;
         H003K2_A128BR_Medication_RXDaysSupply = new decimal[1] ;
         H003K2_n128BR_Medication_RXDaysSupply = new bool[] {false} ;
         H003K2_A127BR_Medication_RXQuantity = new String[] {""} ;
         H003K2_n127BR_Medication_RXQuantity = new bool[] {false} ;
         H003K2_A122BR_Medication_RXCode = new String[] {""} ;
         H003K2_n122BR_Medication_RXCode = new bool[] {false} ;
         H003K2_A121BR_Medication_RXName = new String[] {""} ;
         H003K2_n121BR_Medication_RXName = new bool[] {false} ;
         H003K2_A36BR_Information_PatientNo = new String[] {""} ;
         H003K2_n36BR_Information_PatientNo = new bool[] {false} ;
         H003K2_A19BR_EncounterID = new long[1] ;
         H003K2_A119BR_MedicationID = new long[1] ;
         H003K3_AGRID_nRecordCount = new long[1] ;
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_medicationww__default(),
            new Object[][] {
                new Object[] {
               H003K2_A85BR_Information_ID, H003K2_n85BR_Information_ID, H003K2_A132BR_Medication_AdmitStartDate, H003K2_n132BR_Medication_AdmitStartDate, H003K2_A126BR_Medication_RXFrequency, H003K2_n126BR_Medication_RXFrequency, H003K2_A128BR_Medication_RXDaysSupply, H003K2_n128BR_Medication_RXDaysSupply, H003K2_A127BR_Medication_RXQuantity, H003K2_n127BR_Medication_RXQuantity,
               H003K2_A122BR_Medication_RXCode, H003K2_n122BR_Medication_RXCode, H003K2_A121BR_Medication_RXName, H003K2_n121BR_Medication_RXName, H003K2_A36BR_Information_PatientNo, H003K2_n36BR_Information_PatientNo, H003K2_A19BR_EncounterID, H003K2_A119BR_MedicationID
               }
               , new Object[] {
               H003K3_AGRID_nRecordCount
               }
            }
         );
         AV141Pgmname = "BR_MedicationWW";
         /* GeneXus formulas. */
         AV141Pgmname = "BR_MedicationWW";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_12 ;
      private short nGXsfl_12_idx=1 ;
      private short GRID_nEOF ;
      private short AV13OrderedBy ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtBR_Medication_RXName_Titleformat ;
      private short edtBR_Medication_RXCode_Titleformat ;
      private short edtBR_Medication_RXQuantity_Titleformat ;
      private short edtBR_Medication_RXDaysSupply_Titleformat ;
      private short edtBR_Medication_RXFrequency_Titleformat ;
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
      private int Ddo_br_medication_rxname_Datalistupdateminimumcharacters ;
      private int Ddo_br_medication_rxcode_Datalistupdateminimumcharacters ;
      private int Ddo_br_medication_rxquantity_Datalistupdateminimumcharacters ;
      private int Ddo_br_medication_rxfrequency_Datalistupdateminimumcharacters ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medication_rxcodetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medication_rxquantitytitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medication_rxdayssupplytitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medication_rxfrequencytitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medication_admitstartdatetitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfbr_medication_rxname_Visible ;
      private int edtavTfbr_medication_rxname_sel_Visible ;
      private int edtavTfbr_medication_rxcode_Visible ;
      private int edtavTfbr_medication_rxcode_sel_Visible ;
      private int edtavTfbr_medication_rxquantity_Visible ;
      private int edtavTfbr_medication_rxquantity_sel_Visible ;
      private int edtavTfbr_medication_rxdayssupply_Visible ;
      private int edtavTfbr_medication_rxdayssupply_to_Visible ;
      private int edtavTfbr_medication_rxfrequency_Visible ;
      private int edtavTfbr_medication_rxfrequency_sel_Visible ;
      private int edtavTfbr_medication_admitstartdate_Visible ;
      private int edtavTfbr_medication_admitstartdate_to_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV109PageToGo ;
      private int AV142GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV110GridCurrentPage ;
      private long AV112GridRecordCount ;
      private long AV111GridPageSize ;
      private long A119BR_MedicationID ;
      private long A19BR_EncounterID ;
      private long GRID_nCurrentRecord ;
      private long A85BR_Information_ID ;
      private long GRID_nRecordCount ;
      private decimal AV59TFBR_Medication_RXDaysSupply ;
      private decimal AV60TFBR_Medication_RXDaysSupply_To ;
      private decimal A128BR_Medication_RXDaysSupply ;
      private decimal AV134BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply ;
      private decimal AV135BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_medication_rxname_Activeeventkey ;
      private String Ddo_br_medication_rxname_Filteredtext_get ;
      private String Ddo_br_medication_rxname_Selectedvalue_get ;
      private String Ddo_br_medication_rxcode_Activeeventkey ;
      private String Ddo_br_medication_rxcode_Filteredtext_get ;
      private String Ddo_br_medication_rxcode_Selectedvalue_get ;
      private String Ddo_br_medication_rxquantity_Activeeventkey ;
      private String Ddo_br_medication_rxquantity_Filteredtext_get ;
      private String Ddo_br_medication_rxquantity_Selectedvalue_get ;
      private String Ddo_br_medication_rxdayssupply_Activeeventkey ;
      private String Ddo_br_medication_rxdayssupply_Filteredtext_get ;
      private String Ddo_br_medication_rxdayssupply_Filteredtextto_get ;
      private String Ddo_br_medication_rxfrequency_Activeeventkey ;
      private String Ddo_br_medication_rxfrequency_Filteredtext_get ;
      private String Ddo_br_medication_rxfrequency_Selectedvalue_get ;
      private String Ddo_br_medication_admitstartdate_Activeeventkey ;
      private String Ddo_br_medication_admitstartdate_Filteredtext_get ;
      private String Ddo_br_medication_admitstartdate_Filteredtextto_get ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_12_idx="0001" ;
      private String AV141Pgmname ;
      private String GXKey ;
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
      private String Ddo_br_medication_rxname_Caption ;
      private String Ddo_br_medication_rxname_Tooltip ;
      private String Ddo_br_medication_rxname_Cls ;
      private String Ddo_br_medication_rxname_Filteredtext_set ;
      private String Ddo_br_medication_rxname_Selectedvalue_set ;
      private String Ddo_br_medication_rxname_Dropdownoptionstype ;
      private String Ddo_br_medication_rxname_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_rxname_Sortedstatus ;
      private String Ddo_br_medication_rxname_Filtertype ;
      private String Ddo_br_medication_rxname_Datalisttype ;
      private String Ddo_br_medication_rxname_Datalistproc ;
      private String Ddo_br_medication_rxname_Sortasc ;
      private String Ddo_br_medication_rxname_Sortdsc ;
      private String Ddo_br_medication_rxname_Loadingdata ;
      private String Ddo_br_medication_rxname_Cleanfilter ;
      private String Ddo_br_medication_rxname_Noresultsfound ;
      private String Ddo_br_medication_rxname_Searchbuttontext ;
      private String Ddo_br_medication_rxcode_Caption ;
      private String Ddo_br_medication_rxcode_Tooltip ;
      private String Ddo_br_medication_rxcode_Cls ;
      private String Ddo_br_medication_rxcode_Filteredtext_set ;
      private String Ddo_br_medication_rxcode_Selectedvalue_set ;
      private String Ddo_br_medication_rxcode_Dropdownoptionstype ;
      private String Ddo_br_medication_rxcode_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_rxcode_Sortedstatus ;
      private String Ddo_br_medication_rxcode_Filtertype ;
      private String Ddo_br_medication_rxcode_Datalisttype ;
      private String Ddo_br_medication_rxcode_Datalistproc ;
      private String Ddo_br_medication_rxcode_Sortasc ;
      private String Ddo_br_medication_rxcode_Sortdsc ;
      private String Ddo_br_medication_rxcode_Loadingdata ;
      private String Ddo_br_medication_rxcode_Cleanfilter ;
      private String Ddo_br_medication_rxcode_Noresultsfound ;
      private String Ddo_br_medication_rxcode_Searchbuttontext ;
      private String Ddo_br_medication_rxquantity_Caption ;
      private String Ddo_br_medication_rxquantity_Tooltip ;
      private String Ddo_br_medication_rxquantity_Cls ;
      private String Ddo_br_medication_rxquantity_Filteredtext_set ;
      private String Ddo_br_medication_rxquantity_Selectedvalue_set ;
      private String Ddo_br_medication_rxquantity_Dropdownoptionstype ;
      private String Ddo_br_medication_rxquantity_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_rxquantity_Sortedstatus ;
      private String Ddo_br_medication_rxquantity_Filtertype ;
      private String Ddo_br_medication_rxquantity_Datalisttype ;
      private String Ddo_br_medication_rxquantity_Datalistproc ;
      private String Ddo_br_medication_rxquantity_Sortasc ;
      private String Ddo_br_medication_rxquantity_Sortdsc ;
      private String Ddo_br_medication_rxquantity_Loadingdata ;
      private String Ddo_br_medication_rxquantity_Cleanfilter ;
      private String Ddo_br_medication_rxquantity_Noresultsfound ;
      private String Ddo_br_medication_rxquantity_Searchbuttontext ;
      private String Ddo_br_medication_rxdayssupply_Caption ;
      private String Ddo_br_medication_rxdayssupply_Tooltip ;
      private String Ddo_br_medication_rxdayssupply_Cls ;
      private String Ddo_br_medication_rxdayssupply_Filteredtext_set ;
      private String Ddo_br_medication_rxdayssupply_Filteredtextto_set ;
      private String Ddo_br_medication_rxdayssupply_Dropdownoptionstype ;
      private String Ddo_br_medication_rxdayssupply_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_rxdayssupply_Sortedstatus ;
      private String Ddo_br_medication_rxdayssupply_Filtertype ;
      private String Ddo_br_medication_rxdayssupply_Sortasc ;
      private String Ddo_br_medication_rxdayssupply_Sortdsc ;
      private String Ddo_br_medication_rxdayssupply_Cleanfilter ;
      private String Ddo_br_medication_rxdayssupply_Rangefilterfrom ;
      private String Ddo_br_medication_rxdayssupply_Rangefilterto ;
      private String Ddo_br_medication_rxdayssupply_Searchbuttontext ;
      private String Ddo_br_medication_rxfrequency_Caption ;
      private String Ddo_br_medication_rxfrequency_Tooltip ;
      private String Ddo_br_medication_rxfrequency_Cls ;
      private String Ddo_br_medication_rxfrequency_Filteredtext_set ;
      private String Ddo_br_medication_rxfrequency_Selectedvalue_set ;
      private String Ddo_br_medication_rxfrequency_Dropdownoptionstype ;
      private String Ddo_br_medication_rxfrequency_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_rxfrequency_Sortedstatus ;
      private String Ddo_br_medication_rxfrequency_Filtertype ;
      private String Ddo_br_medication_rxfrequency_Datalisttype ;
      private String Ddo_br_medication_rxfrequency_Datalistproc ;
      private String Ddo_br_medication_rxfrequency_Sortasc ;
      private String Ddo_br_medication_rxfrequency_Sortdsc ;
      private String Ddo_br_medication_rxfrequency_Loadingdata ;
      private String Ddo_br_medication_rxfrequency_Cleanfilter ;
      private String Ddo_br_medication_rxfrequency_Noresultsfound ;
      private String Ddo_br_medication_rxfrequency_Searchbuttontext ;
      private String Ddo_br_medication_admitstartdate_Caption ;
      private String Ddo_br_medication_admitstartdate_Tooltip ;
      private String Ddo_br_medication_admitstartdate_Cls ;
      private String Ddo_br_medication_admitstartdate_Filteredtext_set ;
      private String Ddo_br_medication_admitstartdate_Filteredtextto_set ;
      private String Ddo_br_medication_admitstartdate_Dropdownoptionstype ;
      private String Ddo_br_medication_admitstartdate_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_admitstartdate_Sortedstatus ;
      private String Ddo_br_medication_admitstartdate_Filtertype ;
      private String Ddo_br_medication_admitstartdate_Sortasc ;
      private String Ddo_br_medication_admitstartdate_Sortdsc ;
      private String Ddo_br_medication_admitstartdate_Cleanfilter ;
      private String Ddo_br_medication_admitstartdate_Rangefilterfrom ;
      private String Ddo_br_medication_admitstartdate_Rangefilterto ;
      private String Ddo_br_medication_admitstartdate_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtBR_Medication_RXName_Title ;
      private String edtBR_Medication_RXCode_Title ;
      private String edtBR_Medication_RXQuantity_Title ;
      private String edtBR_Medication_RXDaysSupply_Title ;
      private String edtBR_Medication_RXFrequency_Title ;
      private String edtBR_Medication_AdmitStartDate_Title ;
      private String subGrid_Header ;
      private String edtavDisplay_Link ;
      private String edtavDisplay_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_medication_rxname_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medication_rxcode_Internalname ;
      private String edtavDdo_br_medication_rxcodetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medication_rxquantity_Internalname ;
      private String edtavDdo_br_medication_rxquantitytitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medication_rxdayssupply_Internalname ;
      private String edtavDdo_br_medication_rxdayssupplytitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medication_rxfrequency_Internalname ;
      private String edtavDdo_br_medication_rxfrequencytitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medication_admitstartdate_Internalname ;
      private String edtavDdo_br_medication_admitstartdatetitlecontrolidtoreplace_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavTfbr_medication_rxname_Internalname ;
      private String edtavTfbr_medication_rxname_Jsonclick ;
      private String edtavTfbr_medication_rxname_sel_Internalname ;
      private String edtavTfbr_medication_rxname_sel_Jsonclick ;
      private String edtavTfbr_medication_rxcode_Internalname ;
      private String edtavTfbr_medication_rxcode_Jsonclick ;
      private String edtavTfbr_medication_rxcode_sel_Internalname ;
      private String edtavTfbr_medication_rxcode_sel_Jsonclick ;
      private String edtavTfbr_medication_rxquantity_Internalname ;
      private String edtavTfbr_medication_rxquantity_Jsonclick ;
      private String edtavTfbr_medication_rxquantity_sel_Internalname ;
      private String edtavTfbr_medication_rxquantity_sel_Jsonclick ;
      private String edtavTfbr_medication_rxdayssupply_Internalname ;
      private String edtavTfbr_medication_rxdayssupply_Jsonclick ;
      private String edtavTfbr_medication_rxdayssupply_to_Internalname ;
      private String edtavTfbr_medication_rxdayssupply_to_Jsonclick ;
      private String edtavTfbr_medication_rxfrequency_Internalname ;
      private String edtavTfbr_medication_rxfrequency_Jsonclick ;
      private String edtavTfbr_medication_rxfrequency_sel_Internalname ;
      private String edtavTfbr_medication_rxfrequency_sel_Jsonclick ;
      private String edtavTfbr_medication_admitstartdate_Internalname ;
      private String edtavTfbr_medication_admitstartdate_Jsonclick ;
      private String edtavTfbr_medication_admitstartdate_to_Internalname ;
      private String edtavTfbr_medication_admitstartdate_to_Jsonclick ;
      private String divDdo_br_medication_admitstartdateauxdates_Internalname ;
      private String edtavDdo_br_medication_admitstartdateauxdate_Internalname ;
      private String edtavDdo_br_medication_admitstartdateauxdate_Jsonclick ;
      private String edtavDdo_br_medication_admitstartdateauxdateto_Internalname ;
      private String edtavDdo_br_medication_admitstartdateauxdateto_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDisplay_Internalname ;
      private String edtBR_MedicationID_Internalname ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_Medication_RXName_Internalname ;
      private String edtBR_Medication_RXCode_Internalname ;
      private String edtBR_Medication_RXQuantity_Internalname ;
      private String edtBR_Medication_RXDaysSupply_Internalname ;
      private String edtBR_Medication_RXFrequency_Internalname ;
      private String edtBR_Medication_AdmitStartDate_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_12_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtBR_MedicationID_Jsonclick ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String edtBR_Medication_RXName_Jsonclick ;
      private String edtBR_Medication_RXCode_Jsonclick ;
      private String edtBR_Medication_RXQuantity_Jsonclick ;
      private String edtBR_Medication_RXDaysSupply_Jsonclick ;
      private String edtBR_Medication_RXFrequency_Jsonclick ;
      private String edtBR_Medication_AdmitStartDate_Jsonclick ;
      private DateTime AV77TFBR_Medication_AdmitStartDate ;
      private DateTime AV78TFBR_Medication_AdmitStartDate_To ;
      private DateTime A132BR_Medication_AdmitStartDate ;
      private DateTime AV79DDO_BR_Medication_AdmitStartDateAuxDate ;
      private DateTime AV80DDO_BR_Medication_AdmitStartDateAuxDateTo ;
      private DateTime AV138BR_MedicationWWDS_11_Tfbr_medication_admitstartdate ;
      private DateTime AV139BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to ;
      private bool entryPointCalled ;
      private bool AV14OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_br_medication_rxname_Includesortasc ;
      private bool Ddo_br_medication_rxname_Includesortdsc ;
      private bool Ddo_br_medication_rxname_Includefilter ;
      private bool Ddo_br_medication_rxname_Filterisrange ;
      private bool Ddo_br_medication_rxname_Includedatalist ;
      private bool Ddo_br_medication_rxcode_Includesortasc ;
      private bool Ddo_br_medication_rxcode_Includesortdsc ;
      private bool Ddo_br_medication_rxcode_Includefilter ;
      private bool Ddo_br_medication_rxcode_Filterisrange ;
      private bool Ddo_br_medication_rxcode_Includedatalist ;
      private bool Ddo_br_medication_rxquantity_Includesortasc ;
      private bool Ddo_br_medication_rxquantity_Includesortdsc ;
      private bool Ddo_br_medication_rxquantity_Includefilter ;
      private bool Ddo_br_medication_rxquantity_Filterisrange ;
      private bool Ddo_br_medication_rxquantity_Includedatalist ;
      private bool Ddo_br_medication_rxdayssupply_Includesortasc ;
      private bool Ddo_br_medication_rxdayssupply_Includesortdsc ;
      private bool Ddo_br_medication_rxdayssupply_Includefilter ;
      private bool Ddo_br_medication_rxdayssupply_Filterisrange ;
      private bool Ddo_br_medication_rxdayssupply_Includedatalist ;
      private bool Ddo_br_medication_rxfrequency_Includesortasc ;
      private bool Ddo_br_medication_rxfrequency_Includesortdsc ;
      private bool Ddo_br_medication_rxfrequency_Includefilter ;
      private bool Ddo_br_medication_rxfrequency_Filterisrange ;
      private bool Ddo_br_medication_rxfrequency_Includedatalist ;
      private bool Ddo_br_medication_admitstartdate_Includesortasc ;
      private bool Ddo_br_medication_admitstartdate_Includesortdsc ;
      private bool Ddo_br_medication_admitstartdate_Includefilter ;
      private bool Ddo_br_medication_admitstartdate_Filterisrange ;
      private bool Ddo_br_medication_admitstartdate_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_12_Refreshing=false ;
      private bool n36BR_Information_PatientNo ;
      private bool n121BR_Medication_RXName ;
      private bool n122BR_Medication_RXCode ;
      private bool n127BR_Medication_RXQuantity ;
      private bool n128BR_Medication_RXDaysSupply ;
      private bool n126BR_Medication_RXFrequency ;
      private bool n132BR_Medication_AdmitStartDate ;
      private bool gxdyncontrolsrefreshing ;
      private bool n85BR_Information_ID ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV113Display_IsBlob ;
      private String AV31TFBR_Medication_RXName ;
      private String AV32TFBR_Medication_RXName_Sel ;
      private String AV35TFBR_Medication_RXCode ;
      private String AV36TFBR_Medication_RXCode_Sel ;
      private String AV55TFBR_Medication_RXQuantity ;
      private String AV56TFBR_Medication_RXQuantity_Sel ;
      private String AV51TFBR_Medication_RXFrequency ;
      private String AV122TFBR_Medication_RXFrequency_Sel ;
      private String AV33ddo_BR_Medication_RXNameTitleControlIdToReplace ;
      private String AV37ddo_BR_Medication_RXCodeTitleControlIdToReplace ;
      private String AV57ddo_BR_Medication_RXQuantityTitleControlIdToReplace ;
      private String AV61ddo_BR_Medication_RXDaysSupplyTitleControlIdToReplace ;
      private String AV53ddo_BR_Medication_RXFrequencyTitleControlIdToReplace ;
      private String AV81ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace ;
      private String A36BR_Information_PatientNo ;
      private String A121BR_Medication_RXName ;
      private String A122BR_Medication_RXCode ;
      private String A127BR_Medication_RXQuantity ;
      private String A126BR_Medication_RXFrequency ;
      private String AV140Display_GXI ;
      private String lV128BR_MedicationWWDS_1_Tfbr_medication_rxname ;
      private String lV130BR_MedicationWWDS_3_Tfbr_medication_rxcode ;
      private String lV132BR_MedicationWWDS_5_Tfbr_medication_rxquantity ;
      private String lV136BR_MedicationWWDS_9_Tfbr_medication_rxfrequency ;
      private String AV129BR_MedicationWWDS_2_Tfbr_medication_rxname_sel ;
      private String AV128BR_MedicationWWDS_1_Tfbr_medication_rxname ;
      private String AV131BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel ;
      private String AV130BR_MedicationWWDS_3_Tfbr_medication_rxcode ;
      private String AV133BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel ;
      private String AV132BR_MedicationWWDS_5_Tfbr_medication_rxquantity ;
      private String AV137BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel ;
      private String AV136BR_MedicationWWDS_9_Tfbr_medication_rxfrequency ;
      private String AV113Display ;
      private IGxSession AV15Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_medication_rxname ;
      private GXUserControl ucDdo_br_medication_rxcode ;
      private GXUserControl ucDdo_br_medication_rxquantity ;
      private GXUserControl ucDdo_br_medication_rxdayssupply ;
      private GXUserControl ucDdo_br_medication_rxfrequency ;
      private GXUserControl ucDdo_br_medication_admitstartdate ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] H003K2_A85BR_Information_ID ;
      private bool[] H003K2_n85BR_Information_ID ;
      private DateTime[] H003K2_A132BR_Medication_AdmitStartDate ;
      private bool[] H003K2_n132BR_Medication_AdmitStartDate ;
      private String[] H003K2_A126BR_Medication_RXFrequency ;
      private bool[] H003K2_n126BR_Medication_RXFrequency ;
      private decimal[] H003K2_A128BR_Medication_RXDaysSupply ;
      private bool[] H003K2_n128BR_Medication_RXDaysSupply ;
      private String[] H003K2_A127BR_Medication_RXQuantity ;
      private bool[] H003K2_n127BR_Medication_RXQuantity ;
      private String[] H003K2_A122BR_Medication_RXCode ;
      private bool[] H003K2_n122BR_Medication_RXCode ;
      private String[] H003K2_A121BR_Medication_RXName ;
      private bool[] H003K2_n121BR_Medication_RXName ;
      private String[] H003K2_A36BR_Information_PatientNo ;
      private bool[] H003K2_n36BR_Information_PatientNo ;
      private long[] H003K2_A19BR_EncounterID ;
      private long[] H003K2_A119BR_MedicationID ;
      private long[] H003K3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV30BR_Medication_RXNameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV34BR_Medication_RXCodeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV54BR_Medication_RXQuantityTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV58BR_Medication_RXDaysSupplyTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV50BR_Medication_RXFrequencyTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV76BR_Medication_AdmitStartDateTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV11GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV12GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV108DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class br_medicationww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H003K2( IGxContext context ,
                                             String AV129BR_MedicationWWDS_2_Tfbr_medication_rxname_sel ,
                                             String AV128BR_MedicationWWDS_1_Tfbr_medication_rxname ,
                                             String AV131BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel ,
                                             String AV130BR_MedicationWWDS_3_Tfbr_medication_rxcode ,
                                             String AV133BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel ,
                                             String AV132BR_MedicationWWDS_5_Tfbr_medication_rxquantity ,
                                             decimal AV134BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply ,
                                             decimal AV135BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to ,
                                             String AV137BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel ,
                                             String AV136BR_MedicationWWDS_9_Tfbr_medication_rxfrequency ,
                                             DateTime AV138BR_MedicationWWDS_11_Tfbr_medication_admitstartdate ,
                                             DateTime AV139BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to ,
                                             String A121BR_Medication_RXName ,
                                             String A122BR_Medication_RXCode ,
                                             String A127BR_Medication_RXQuantity ,
                                             decimal A128BR_Medication_RXDaysSupply ,
                                             String A126BR_Medication_RXFrequency ,
                                             DateTime A132BR_Medication_AdmitStartDate ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [15] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " T2.[BR_Information_ID], T1.[BR_Medication_AdmitStartDate], T1.[BR_Medication_RXFrequency], T1.[BR_Medication_RXDaysSupply], T1.[BR_Medication_RXQuantity], T1.[BR_Medication_RXCode], T1.[BR_Medication_RXName], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_MedicationID]";
         sFromString = " FROM (([BR_Medication] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         sOrderString = "";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV129BR_MedicationWWDS_2_Tfbr_medication_rxname_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV128BR_MedicationWWDS_1_Tfbr_medication_rxname)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Medication_RXName] like @lV128BR_MedicationWWDS_1_Tfbr_medication_rxname)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Medication_RXName] like @lV128BR_MedicationWWDS_1_Tfbr_medication_rxname)";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV129BR_MedicationWWDS_2_Tfbr_medication_rxname_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Medication_RXName] = @AV129BR_MedicationWWDS_2_Tfbr_medication_rxname_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Medication_RXName] = @AV129BR_MedicationWWDS_2_Tfbr_medication_rxname_sel)";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV131BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV130BR_MedicationWWDS_3_Tfbr_medication_rxcode)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Medication_RXCode] like @lV130BR_MedicationWWDS_3_Tfbr_medication_rxcode)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Medication_RXCode] like @lV130BR_MedicationWWDS_3_Tfbr_medication_rxcode)";
            }
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV131BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Medication_RXCode] = @AV131BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Medication_RXCode] = @AV131BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel)";
            }
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV133BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV132BR_MedicationWWDS_5_Tfbr_medication_rxquantity)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Medication_RXQuantity] like @lV132BR_MedicationWWDS_5_Tfbr_medication_rxquantity)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Medication_RXQuantity] like @lV132BR_MedicationWWDS_5_Tfbr_medication_rxquantity)";
            }
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV133BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Medication_RXQuantity] = @AV133BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Medication_RXQuantity] = @AV133BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel)";
            }
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV134BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Medication_RXDaysSupply] >= @AV134BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Medication_RXDaysSupply] >= @AV134BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply)";
            }
         }
         else
         {
            GXv_int2[6] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV135BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Medication_RXDaysSupply] <= @AV135BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Medication_RXDaysSupply] <= @AV135BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to)";
            }
         }
         else
         {
            GXv_int2[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV137BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV136BR_MedicationWWDS_9_Tfbr_medication_rxfrequency)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Medication_RXFrequency] like @lV136BR_MedicationWWDS_9_Tfbr_medication_rxfrequency)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Medication_RXFrequency] like @lV136BR_MedicationWWDS_9_Tfbr_medication_rxfrequency)";
            }
         }
         else
         {
            GXv_int2[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV137BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Medication_RXFrequency] = @AV137BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Medication_RXFrequency] = @AV137BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel)";
            }
         }
         else
         {
            GXv_int2[9] = 1;
         }
         if ( ! (DateTime.MinValue==AV138BR_MedicationWWDS_11_Tfbr_medication_admitstartdate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Medication_AdmitStartDate] >= @AV138BR_MedicationWWDS_11_Tfbr_medication_admitstartdate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Medication_AdmitStartDate] >= @AV138BR_MedicationWWDS_11_Tfbr_medication_admitstartdate)";
            }
         }
         else
         {
            GXv_int2[10] = 1;
         }
         if ( ! (DateTime.MinValue==AV139BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Medication_AdmitStartDate] <= @AV139BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Medication_AdmitStartDate] <= @AV139BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to)";
            }
         }
         else
         {
            GXv_int2[11] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Medication_RXName]";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Medication_RXName] DESC";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Medication_RXCode]";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Medication_RXCode] DESC";
         }
         else if ( ( AV13OrderedBy == 3 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Medication_RXQuantity]";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Medication_RXQuantity] DESC";
         }
         else if ( ( AV13OrderedBy == 4 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Medication_RXDaysSupply]";
         }
         else if ( ( AV13OrderedBy == 4 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Medication_RXDaysSupply] DESC";
         }
         else if ( ( AV13OrderedBy == 5 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Medication_RXFrequency]";
         }
         else if ( ( AV13OrderedBy == 5 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Medication_RXFrequency] DESC";
         }
         else if ( ( AV13OrderedBy == 6 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Medication_AdmitStartDate]";
         }
         else if ( ( AV13OrderedBy == 6 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Medication_AdmitStartDate] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicationID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_H003K3( IGxContext context ,
                                             String AV129BR_MedicationWWDS_2_Tfbr_medication_rxname_sel ,
                                             String AV128BR_MedicationWWDS_1_Tfbr_medication_rxname ,
                                             String AV131BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel ,
                                             String AV130BR_MedicationWWDS_3_Tfbr_medication_rxcode ,
                                             String AV133BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel ,
                                             String AV132BR_MedicationWWDS_5_Tfbr_medication_rxquantity ,
                                             decimal AV134BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply ,
                                             decimal AV135BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to ,
                                             String AV137BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel ,
                                             String AV136BR_MedicationWWDS_9_Tfbr_medication_rxfrequency ,
                                             DateTime AV138BR_MedicationWWDS_11_Tfbr_medication_admitstartdate ,
                                             DateTime AV139BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to ,
                                             String A121BR_Medication_RXName ,
                                             String A122BR_Medication_RXCode ,
                                             String A127BR_Medication_RXQuantity ,
                                             decimal A128BR_Medication_RXDaysSupply ,
                                             String A126BR_Medication_RXFrequency ,
                                             DateTime A132BR_Medication_AdmitStartDate ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [12] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM (([BR_Medication] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV129BR_MedicationWWDS_2_Tfbr_medication_rxname_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV128BR_MedicationWWDS_1_Tfbr_medication_rxname)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Medication_RXName] like @lV128BR_MedicationWWDS_1_Tfbr_medication_rxname)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Medication_RXName] like @lV128BR_MedicationWWDS_1_Tfbr_medication_rxname)";
            }
         }
         else
         {
            GXv_int4[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV129BR_MedicationWWDS_2_Tfbr_medication_rxname_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Medication_RXName] = @AV129BR_MedicationWWDS_2_Tfbr_medication_rxname_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Medication_RXName] = @AV129BR_MedicationWWDS_2_Tfbr_medication_rxname_sel)";
            }
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV131BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV130BR_MedicationWWDS_3_Tfbr_medication_rxcode)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Medication_RXCode] like @lV130BR_MedicationWWDS_3_Tfbr_medication_rxcode)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Medication_RXCode] like @lV130BR_MedicationWWDS_3_Tfbr_medication_rxcode)";
            }
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV131BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Medication_RXCode] = @AV131BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Medication_RXCode] = @AV131BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel)";
            }
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV133BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV132BR_MedicationWWDS_5_Tfbr_medication_rxquantity)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Medication_RXQuantity] like @lV132BR_MedicationWWDS_5_Tfbr_medication_rxquantity)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Medication_RXQuantity] like @lV132BR_MedicationWWDS_5_Tfbr_medication_rxquantity)";
            }
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV133BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Medication_RXQuantity] = @AV133BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Medication_RXQuantity] = @AV133BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel)";
            }
         }
         else
         {
            GXv_int4[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV134BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Medication_RXDaysSupply] >= @AV134BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Medication_RXDaysSupply] >= @AV134BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply)";
            }
         }
         else
         {
            GXv_int4[6] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV135BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Medication_RXDaysSupply] <= @AV135BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Medication_RXDaysSupply] <= @AV135BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to)";
            }
         }
         else
         {
            GXv_int4[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV137BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV136BR_MedicationWWDS_9_Tfbr_medication_rxfrequency)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Medication_RXFrequency] like @lV136BR_MedicationWWDS_9_Tfbr_medication_rxfrequency)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Medication_RXFrequency] like @lV136BR_MedicationWWDS_9_Tfbr_medication_rxfrequency)";
            }
         }
         else
         {
            GXv_int4[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV137BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Medication_RXFrequency] = @AV137BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Medication_RXFrequency] = @AV137BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel)";
            }
         }
         else
         {
            GXv_int4[9] = 1;
         }
         if ( ! (DateTime.MinValue==AV138BR_MedicationWWDS_11_Tfbr_medication_admitstartdate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Medication_AdmitStartDate] >= @AV138BR_MedicationWWDS_11_Tfbr_medication_admitstartdate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Medication_AdmitStartDate] >= @AV138BR_MedicationWWDS_11_Tfbr_medication_admitstartdate)";
            }
         }
         else
         {
            GXv_int4[10] = 1;
         }
         if ( ! (DateTime.MinValue==AV139BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Medication_AdmitStartDate] <= @AV139BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Medication_AdmitStartDate] <= @AV139BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to)";
            }
         }
         else
         {
            GXv_int4[11] = 1;
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
         GXv_Object5[0] = scmdbuf;
         GXv_Object5[1] = GXv_int4;
         return GXv_Object5 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H003K2(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (decimal)dynConstraints[6] , (decimal)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (DateTime)dynConstraints[10] , (DateTime)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (decimal)dynConstraints[15] , (String)dynConstraints[16] , (DateTime)dynConstraints[17] , (short)dynConstraints[18] , (bool)dynConstraints[19] );
               case 1 :
                     return conditional_H003K3(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (decimal)dynConstraints[6] , (decimal)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (DateTime)dynConstraints[10] , (DateTime)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (decimal)dynConstraints[15] , (String)dynConstraints[16] , (DateTime)dynConstraints[17] , (short)dynConstraints[18] , (bool)dynConstraints[19] );
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
          Object[] prmH003K2 ;
          prmH003K2 = new Object[] {
          new Object[] {"@lV128BR_MedicationWWDS_1_Tfbr_medication_rxname",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV129BR_MedicationWWDS_2_Tfbr_medication_rxname_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV130BR_MedicationWWDS_3_Tfbr_medication_rxcode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV131BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV132BR_MedicationWWDS_5_Tfbr_medication_rxquantity",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV133BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV134BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV135BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV136BR_MedicationWWDS_9_Tfbr_medication_rxfrequency",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV137BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV138BR_MedicationWWDS_11_Tfbr_medication_admitstartdate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV139BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH003K3 ;
          prmH003K3 = new Object[] {
          new Object[] {"@lV128BR_MedicationWWDS_1_Tfbr_medication_rxname",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV129BR_MedicationWWDS_2_Tfbr_medication_rxname_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV130BR_MedicationWWDS_3_Tfbr_medication_rxcode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV131BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV132BR_MedicationWWDS_5_Tfbr_medication_rxquantity",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV133BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV134BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV135BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV136BR_MedicationWWDS_9_Tfbr_medication_rxfrequency",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV137BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV138BR_MedicationWWDS_11_Tfbr_medication_admitstartdate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV139BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to",SqlDbType.DateTime,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H003K2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003K2,11,0,true,false )
             ,new CursorDef("H003K3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003K3,1,0,true,false )
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
                ((decimal[]) buf[6])[0] = rslt.getDecimal(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((long[]) buf[16])[0] = rslt.getLong(9) ;
                ((long[]) buf[17])[0] = rslt.getLong(10) ;
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
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
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
                   stmt.SetParameter(sIdx, (decimal)parms[21]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[22]);
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
                   stmt.SetParameter(sIdx, (DateTime)parms[25]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[26]);
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
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
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
                   stmt.SetParameter(sIdx, (decimal)parms[18]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[19]);
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
                   stmt.SetParameter(sIdx, (DateTime)parms[22]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[23]);
                }
                return;
       }
    }

 }

}
