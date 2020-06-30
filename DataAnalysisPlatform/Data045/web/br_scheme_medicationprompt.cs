/*
               File: BR_Scheme_MedicationPrompt
        Description: 选择化疗方案药物详情
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:15:30.56
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
   public class br_scheme_medicationprompt : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public br_scheme_medicationprompt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_scheme_medicationprompt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_InOutBR_Scheme_MedicationID )
      {
         this.AV8InOutBR_Scheme_MedicationID = aP0_InOutBR_Scheme_MedicationID;
         executePrivate();
         aP0_InOutBR_Scheme_MedicationID=this.AV8InOutBR_Scheme_MedicationID;
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
               AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace = GetNextPar( );
               AV15ddo_BR_SchemeIDTitleControlIdToReplace = GetNextPar( );
               AV17ddo_BR_MedicationIDTitleControlIdToReplace = GetNextPar( );
               AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = GetNextPar( );
               AV21ddo_BR_Medication_RXNameTitleControlIdToReplace = GetNextPar( );
               AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace = GetNextPar( );
               AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace, AV15ddo_BR_SchemeIDTitleControlIdToReplace, AV17ddo_BR_MedicationIDTitleControlIdToReplace, AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, AV21ddo_BR_Medication_RXNameTitleControlIdToReplace, AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace, AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace) ;
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
               AV8InOutBR_Scheme_MedicationID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_Scheme_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_Scheme_MedicationID), 18, 0)));
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
            PA6O2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV37Pgmname = "BR_Scheme_MedicationPrompt";
               context.Gx_err = 0;
               WS6O2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE6O2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022815153069", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_scheme_medicationprompt.aspx") + "?" + UrlEncode("" +AV8InOutBR_Scheme_MedicationID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV28GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV30GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV29GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV26DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV26DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA", AV12BR_Scheme_MedicationIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA", AV12BR_Scheme_MedicationIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_SCHEMEIDTITLEFILTERDATA", AV14BR_SchemeIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_SCHEMEIDTITLEFILTERDATA", AV14BR_SchemeIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATIONIDTITLEFILTERDATA", AV16BR_MedicationIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATIONIDTITLEFILTERDATA", AV16BR_MedicationIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA", AV18BR_Scheme_Chem_RegimensTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA", AV18BR_Scheme_Chem_RegimensTitleFilterData);
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_RXDOSETITLEFILTERDATA", AV22BR_Medication_RXDoseTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_RXDOSETITLEFILTERDATA", AV22BR_Medication_RXDoseTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_RXUNITTITLEFILTERDATA", AV24BR_Medication_RXUnitTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_RXUNITTITLEFILTERDATA", AV24BR_Medication_RXUnitTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vINOUTBR_SCHEME_MEDICATIONID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8InOutBR_Scheme_MedicationID), 18, 0, ".", "")));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Caption", StringUtil.RTrim( Ddo_br_scheme_medicationid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Tooltip", StringUtil.RTrim( Ddo_br_scheme_medicationid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Cls", StringUtil.RTrim( Ddo_br_scheme_medicationid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_scheme_medicationid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_scheme_medicationid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Includesortasc", StringUtil.BoolToStr( Ddo_br_scheme_medicationid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_scheme_medicationid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Sortedstatus", StringUtil.RTrim( Ddo_br_scheme_medicationid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Includefilter", StringUtil.BoolToStr( Ddo_br_scheme_medicationid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Includedatalist", StringUtil.BoolToStr( Ddo_br_scheme_medicationid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Sortasc", StringUtil.RTrim( Ddo_br_scheme_medicationid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Sortdsc", StringUtil.RTrim( Ddo_br_scheme_medicationid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Searchbuttontext", StringUtil.RTrim( Ddo_br_scheme_medicationid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Caption", StringUtil.RTrim( Ddo_br_schemeid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Tooltip", StringUtil.RTrim( Ddo_br_schemeid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Cls", StringUtil.RTrim( Ddo_br_schemeid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_schemeid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_schemeid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Includesortasc", StringUtil.BoolToStr( Ddo_br_schemeid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_schemeid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Sortedstatus", StringUtil.RTrim( Ddo_br_schemeid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Includefilter", StringUtil.BoolToStr( Ddo_br_schemeid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Includedatalist", StringUtil.BoolToStr( Ddo_br_schemeid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Sortasc", StringUtil.RTrim( Ddo_br_schemeid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Sortdsc", StringUtil.RTrim( Ddo_br_schemeid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Searchbuttontext", StringUtil.RTrim( Ddo_br_schemeid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Caption", StringUtil.RTrim( Ddo_br_medicationid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Tooltip", StringUtil.RTrim( Ddo_br_medicationid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Cls", StringUtil.RTrim( Ddo_br_medicationid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicationid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicationid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicationid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicationid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Sortedstatus", StringUtil.RTrim( Ddo_br_medicationid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Includefilter", StringUtil.BoolToStr( Ddo_br_medicationid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicationid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Sortasc", StringUtil.RTrim( Ddo_br_medicationid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Sortdsc", StringUtil.RTrim( Ddo_br_medicationid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicationid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Caption", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Tooltip", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Cls", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Includesortasc", StringUtil.BoolToStr( Ddo_br_scheme_chem_regimens_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Includesortdsc", StringUtil.BoolToStr( Ddo_br_scheme_chem_regimens_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Sortedstatus", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Includefilter", StringUtil.BoolToStr( Ddo_br_scheme_chem_regimens_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Includedatalist", StringUtil.BoolToStr( Ddo_br_scheme_chem_regimens_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Sortasc", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Sortdsc", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Searchbuttontext", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Searchbuttontext));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_rxunit_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Sortasc", StringUtil.RTrim( Ddo_br_medication_rxunit_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Sortdsc", StringUtil.RTrim( Ddo_br_medication_rxunit_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_rxunit_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Activeeventkey", StringUtil.RTrim( Ddo_br_scheme_medicationid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Activeeventkey", StringUtil.RTrim( Ddo_br_schemeid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Activeeventkey", StringUtil.RTrim( Ddo_br_medicationid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Activeeventkey", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxname_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxdose_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxunit_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_MEDICATIONID_Activeeventkey", StringUtil.RTrim( Ddo_br_scheme_medicationid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEMEID_Activeeventkey", StringUtil.RTrim( Ddo_br_schemeid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Activeeventkey", StringUtil.RTrim( Ddo_br_medicationid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_SCHEME_CHEM_REGIMENS_Activeeventkey", StringUtil.RTrim( Ddo_br_scheme_chem_regimens_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXNAME_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxname_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXDOSE_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxdose_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_RXUNIT_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxunit_Activeeventkey));
      }

      protected void RenderHtmlCloseForm6O2( )
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
         return "BR_Scheme_MedicationPrompt" ;
      }

      public override String GetPgmdesc( )
      {
         return "选择化疗方案药物详情" ;
      }

      protected void WB6O0( )
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
               if ( edtBR_Scheme_MedicationID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Scheme_MedicationID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Scheme_MedicationID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_SchemeID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_SchemeID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_SchemeID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_MedicationID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_MedicationID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_MedicationID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Scheme_Chem_Regimens_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Scheme_Chem_Regimens_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Scheme_Chem_Regimens_Title) ;
               }
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV31Select));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavSelect_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A332BR_Scheme_MedicationID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Scheme_MedicationID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Scheme_MedicationID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A327BR_SchemeID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_SchemeID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_SchemeID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A119BR_MedicationID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicationID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicationID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A328BR_Scheme_Chem_Regimens);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Scheme_Chem_Regimens_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Scheme_Chem_Regimens_Titleformat), 4, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV28GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV30GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV29GridPageSize);
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
            ucDdo_br_scheme_medicationid.SetProperty("Caption", Ddo_br_scheme_medicationid_Caption);
            ucDdo_br_scheme_medicationid.SetProperty("Tooltip", Ddo_br_scheme_medicationid_Tooltip);
            ucDdo_br_scheme_medicationid.SetProperty("Cls", Ddo_br_scheme_medicationid_Cls);
            ucDdo_br_scheme_medicationid.SetProperty("DropDownOptionsType", Ddo_br_scheme_medicationid_Dropdownoptionstype);
            ucDdo_br_scheme_medicationid.SetProperty("IncludeSortASC", Ddo_br_scheme_medicationid_Includesortasc);
            ucDdo_br_scheme_medicationid.SetProperty("IncludeSortDSC", Ddo_br_scheme_medicationid_Includesortdsc);
            ucDdo_br_scheme_medicationid.SetProperty("IncludeFilter", Ddo_br_scheme_medicationid_Includefilter);
            ucDdo_br_scheme_medicationid.SetProperty("IncludeDataList", Ddo_br_scheme_medicationid_Includedatalist);
            ucDdo_br_scheme_medicationid.SetProperty("SortASC", Ddo_br_scheme_medicationid_Sortasc);
            ucDdo_br_scheme_medicationid.SetProperty("SortDSC", Ddo_br_scheme_medicationid_Sortdsc);
            ucDdo_br_scheme_medicationid.SetProperty("SearchButtonText", Ddo_br_scheme_medicationid_Searchbuttontext);
            ucDdo_br_scheme_medicationid.SetProperty("DropDownOptionsTitleSettingsIcons", AV26DDO_TitleSettingsIcons);
            ucDdo_br_scheme_medicationid.SetProperty("DropDownOptionsData", AV12BR_Scheme_MedicationIDTitleFilterData);
            ucDdo_br_scheme_medicationid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_scheme_medicationid_Internalname, "DDO_BR_SCHEME_MEDICATIONIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_scheme_medicationidtitlecontrolidtoreplace_Internalname, AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", 0, edtavDdo_br_scheme_medicationidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Scheme_MedicationPrompt.htm");
            /* User Defined Control */
            ucDdo_br_schemeid.SetProperty("Caption", Ddo_br_schemeid_Caption);
            ucDdo_br_schemeid.SetProperty("Tooltip", Ddo_br_schemeid_Tooltip);
            ucDdo_br_schemeid.SetProperty("Cls", Ddo_br_schemeid_Cls);
            ucDdo_br_schemeid.SetProperty("DropDownOptionsType", Ddo_br_schemeid_Dropdownoptionstype);
            ucDdo_br_schemeid.SetProperty("IncludeSortASC", Ddo_br_schemeid_Includesortasc);
            ucDdo_br_schemeid.SetProperty("IncludeSortDSC", Ddo_br_schemeid_Includesortdsc);
            ucDdo_br_schemeid.SetProperty("IncludeFilter", Ddo_br_schemeid_Includefilter);
            ucDdo_br_schemeid.SetProperty("IncludeDataList", Ddo_br_schemeid_Includedatalist);
            ucDdo_br_schemeid.SetProperty("SortASC", Ddo_br_schemeid_Sortasc);
            ucDdo_br_schemeid.SetProperty("SortDSC", Ddo_br_schemeid_Sortdsc);
            ucDdo_br_schemeid.SetProperty("SearchButtonText", Ddo_br_schemeid_Searchbuttontext);
            ucDdo_br_schemeid.SetProperty("DropDownOptionsTitleSettingsIcons", AV26DDO_TitleSettingsIcons);
            ucDdo_br_schemeid.SetProperty("DropDownOptionsData", AV14BR_SchemeIDTitleFilterData);
            ucDdo_br_schemeid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_schemeid_Internalname, "DDO_BR_SCHEMEIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_schemeidtitlecontrolidtoreplace_Internalname, AV15ddo_BR_SchemeIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,31);\"", 0, edtavDdo_br_schemeidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Scheme_MedicationPrompt.htm");
            /* User Defined Control */
            ucDdo_br_medicationid.SetProperty("Caption", Ddo_br_medicationid_Caption);
            ucDdo_br_medicationid.SetProperty("Tooltip", Ddo_br_medicationid_Tooltip);
            ucDdo_br_medicationid.SetProperty("Cls", Ddo_br_medicationid_Cls);
            ucDdo_br_medicationid.SetProperty("DropDownOptionsType", Ddo_br_medicationid_Dropdownoptionstype);
            ucDdo_br_medicationid.SetProperty("IncludeSortASC", Ddo_br_medicationid_Includesortasc);
            ucDdo_br_medicationid.SetProperty("IncludeSortDSC", Ddo_br_medicationid_Includesortdsc);
            ucDdo_br_medicationid.SetProperty("IncludeFilter", Ddo_br_medicationid_Includefilter);
            ucDdo_br_medicationid.SetProperty("IncludeDataList", Ddo_br_medicationid_Includedatalist);
            ucDdo_br_medicationid.SetProperty("SortASC", Ddo_br_medicationid_Sortasc);
            ucDdo_br_medicationid.SetProperty("SortDSC", Ddo_br_medicationid_Sortdsc);
            ucDdo_br_medicationid.SetProperty("SearchButtonText", Ddo_br_medicationid_Searchbuttontext);
            ucDdo_br_medicationid.SetProperty("DropDownOptionsTitleSettingsIcons", AV26DDO_TitleSettingsIcons);
            ucDdo_br_medicationid.SetProperty("DropDownOptionsData", AV16BR_MedicationIDTitleFilterData);
            ucDdo_br_medicationid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicationid_Internalname, "DDO_BR_MEDICATIONIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicationidtitlecontrolidtoreplace_Internalname, AV17ddo_BR_MedicationIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", 0, edtavDdo_br_medicationidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Scheme_MedicationPrompt.htm");
            /* User Defined Control */
            ucDdo_br_scheme_chem_regimens.SetProperty("Caption", Ddo_br_scheme_chem_regimens_Caption);
            ucDdo_br_scheme_chem_regimens.SetProperty("Tooltip", Ddo_br_scheme_chem_regimens_Tooltip);
            ucDdo_br_scheme_chem_regimens.SetProperty("Cls", Ddo_br_scheme_chem_regimens_Cls);
            ucDdo_br_scheme_chem_regimens.SetProperty("DropDownOptionsType", Ddo_br_scheme_chem_regimens_Dropdownoptionstype);
            ucDdo_br_scheme_chem_regimens.SetProperty("IncludeSortASC", Ddo_br_scheme_chem_regimens_Includesortasc);
            ucDdo_br_scheme_chem_regimens.SetProperty("IncludeSortDSC", Ddo_br_scheme_chem_regimens_Includesortdsc);
            ucDdo_br_scheme_chem_regimens.SetProperty("IncludeFilter", Ddo_br_scheme_chem_regimens_Includefilter);
            ucDdo_br_scheme_chem_regimens.SetProperty("IncludeDataList", Ddo_br_scheme_chem_regimens_Includedatalist);
            ucDdo_br_scheme_chem_regimens.SetProperty("SortASC", Ddo_br_scheme_chem_regimens_Sortasc);
            ucDdo_br_scheme_chem_regimens.SetProperty("SortDSC", Ddo_br_scheme_chem_regimens_Sortdsc);
            ucDdo_br_scheme_chem_regimens.SetProperty("SearchButtonText", Ddo_br_scheme_chem_regimens_Searchbuttontext);
            ucDdo_br_scheme_chem_regimens.SetProperty("DropDownOptionsTitleSettingsIcons", AV26DDO_TitleSettingsIcons);
            ucDdo_br_scheme_chem_regimens.SetProperty("DropDownOptionsData", AV18BR_Scheme_Chem_RegimensTitleFilterData);
            ucDdo_br_scheme_chem_regimens.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_scheme_chem_regimens_Internalname, "DDO_BR_SCHEME_CHEM_REGIMENSContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Internalname, AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,35);\"", 0, edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Scheme_MedicationPrompt.htm");
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
            ucDdo_br_medication_rxname.SetProperty("DropDownOptionsTitleSettingsIcons", AV26DDO_TitleSettingsIcons);
            ucDdo_br_medication_rxname.SetProperty("DropDownOptionsData", AV20BR_Medication_RXNameTitleFilterData);
            ucDdo_br_medication_rxname.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_rxname_Internalname, "DDO_BR_MEDICATION_RXNAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Internalname, AV21ddo_BR_Medication_RXNameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", 0, edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Scheme_MedicationPrompt.htm");
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
            ucDdo_br_medication_rxdose.SetProperty("DropDownOptionsTitleSettingsIcons", AV26DDO_TitleSettingsIcons);
            ucDdo_br_medication_rxdose.SetProperty("DropDownOptionsData", AV22BR_Medication_RXDoseTitleFilterData);
            ucDdo_br_medication_rxdose.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_rxdose_Internalname, "DDO_BR_MEDICATION_RXDOSEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Internalname, AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", 0, edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Scheme_MedicationPrompt.htm");
            /* User Defined Control */
            ucDdo_br_medication_rxunit.SetProperty("Caption", Ddo_br_medication_rxunit_Caption);
            ucDdo_br_medication_rxunit.SetProperty("Tooltip", Ddo_br_medication_rxunit_Tooltip);
            ucDdo_br_medication_rxunit.SetProperty("Cls", Ddo_br_medication_rxunit_Cls);
            ucDdo_br_medication_rxunit.SetProperty("DropDownOptionsType", Ddo_br_medication_rxunit_Dropdownoptionstype);
            ucDdo_br_medication_rxunit.SetProperty("IncludeSortASC", Ddo_br_medication_rxunit_Includesortasc);
            ucDdo_br_medication_rxunit.SetProperty("IncludeSortDSC", Ddo_br_medication_rxunit_Includesortdsc);
            ucDdo_br_medication_rxunit.SetProperty("IncludeFilter", Ddo_br_medication_rxunit_Includefilter);
            ucDdo_br_medication_rxunit.SetProperty("IncludeDataList", Ddo_br_medication_rxunit_Includedatalist);
            ucDdo_br_medication_rxunit.SetProperty("SortASC", Ddo_br_medication_rxunit_Sortasc);
            ucDdo_br_medication_rxunit.SetProperty("SortDSC", Ddo_br_medication_rxunit_Sortdsc);
            ucDdo_br_medication_rxunit.SetProperty("SearchButtonText", Ddo_br_medication_rxunit_Searchbuttontext);
            ucDdo_br_medication_rxunit.SetProperty("DropDownOptionsTitleSettingsIcons", AV26DDO_TitleSettingsIcons);
            ucDdo_br_medication_rxunit.SetProperty("DropDownOptionsData", AV24BR_Medication_RXUnitTitleFilterData);
            ucDdo_br_medication_rxunit.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_rxunit_Internalname, "DDO_BR_MEDICATION_RXUNITContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Internalname, AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,41);\"", 0, edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Scheme_MedicationPrompt.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Scheme_MedicationPrompt.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV11OrderedDsc), StringUtil.BoolToStr( AV11OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_Scheme_MedicationPrompt.htm");
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

      protected void START6O2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "选择化疗方案药物详情", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP6O0( ) ;
      }

      protected void WS6O2( )
      {
         START6O2( ) ;
         EVT6O2( ) ;
      }

      protected void EVT6O2( )
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
                           E116O2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E126O2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_SCHEME_MEDICATIONID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E136O2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_SCHEMEID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E146O2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATIONID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E156O2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_SCHEME_CHEM_REGIMENS.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E166O2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E176O2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_RXDOSE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E186O2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_RXUNIT.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E196O2 ();
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
                           AV31Select = cgiGet( edtavSelect_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV31Select)) ? AV38Select_GXI : context.convertURL( context.PathToRelativeUrl( AV31Select))), !bGXsfl_12_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "SrcSet", context.GetImageSrcSet( AV31Select), true);
                           A332BR_Scheme_MedicationID = (long)(context.localUtil.CToN( cgiGet( edtBR_Scheme_MedicationID_Internalname), ".", ","));
                           A327BR_SchemeID = (long)(context.localUtil.CToN( cgiGet( edtBR_SchemeID_Internalname), ".", ","));
                           n327BR_SchemeID = false;
                           A119BR_MedicationID = (long)(context.localUtil.CToN( cgiGet( edtBR_MedicationID_Internalname), ".", ","));
                           n119BR_MedicationID = false;
                           A328BR_Scheme_Chem_Regimens = cgiGet( edtBR_Scheme_Chem_Regimens_Internalname);
                           n328BR_Scheme_Chem_Regimens = false;
                           A121BR_Medication_RXName = cgiGet( edtBR_Medication_RXName_Internalname);
                           n121BR_Medication_RXName = false;
                           A124BR_Medication_RXDose = context.localUtil.CToN( cgiGet( edtBR_Medication_RXDose_Internalname), ".", ",");
                           n124BR_Medication_RXDose = false;
                           A125BR_Medication_RXUnit = cgiGet( edtBR_Medication_RXUnit_Internalname);
                           n125BR_Medication_RXUnit = false;
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E206O2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E216O2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E226O2 ();
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
                                       E236O2 ();
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

      protected void WE6O2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm6O2( ) ;
            }
         }
      }

      protected void PA6O2( )
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
               GX_FocusControl = edtavDdo_br_scheme_medicationidtitlecontrolidtoreplace_Internalname;
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
                                       String AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace ,
                                       String AV15ddo_BR_SchemeIDTitleControlIdToReplace ,
                                       String AV17ddo_BR_MedicationIDTitleControlIdToReplace ,
                                       String AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace ,
                                       String AV21ddo_BR_Medication_RXNameTitleControlIdToReplace ,
                                       String AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace ,
                                       String AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF6O2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_SCHEME_MEDICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A332BR_Scheme_MedicationID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_SCHEME_MEDICATIONID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A332BR_Scheme_MedicationID), 18, 0, ".", "")));
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
         RF6O2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV37Pgmname = "BR_Scheme_MedicationPrompt";
         context.Gx_err = 0;
      }

      protected void RF6O2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 12;
         /* Execute user event: Refresh */
         E216O2 ();
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
            /* Using cursor H006O2 */
            pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_12_idx = 1;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A125BR_Medication_RXUnit = H006O2_A125BR_Medication_RXUnit[0];
               n125BR_Medication_RXUnit = H006O2_n125BR_Medication_RXUnit[0];
               A124BR_Medication_RXDose = H006O2_A124BR_Medication_RXDose[0];
               n124BR_Medication_RXDose = H006O2_n124BR_Medication_RXDose[0];
               A121BR_Medication_RXName = H006O2_A121BR_Medication_RXName[0];
               n121BR_Medication_RXName = H006O2_n121BR_Medication_RXName[0];
               A328BR_Scheme_Chem_Regimens = H006O2_A328BR_Scheme_Chem_Regimens[0];
               n328BR_Scheme_Chem_Regimens = H006O2_n328BR_Scheme_Chem_Regimens[0];
               A119BR_MedicationID = H006O2_A119BR_MedicationID[0];
               n119BR_MedicationID = H006O2_n119BR_MedicationID[0];
               A327BR_SchemeID = H006O2_A327BR_SchemeID[0];
               n327BR_SchemeID = H006O2_n327BR_SchemeID[0];
               A332BR_Scheme_MedicationID = H006O2_A332BR_Scheme_MedicationID[0];
               A125BR_Medication_RXUnit = H006O2_A125BR_Medication_RXUnit[0];
               n125BR_Medication_RXUnit = H006O2_n125BR_Medication_RXUnit[0];
               A124BR_Medication_RXDose = H006O2_A124BR_Medication_RXDose[0];
               n124BR_Medication_RXDose = H006O2_n124BR_Medication_RXDose[0];
               A121BR_Medication_RXName = H006O2_A121BR_Medication_RXName[0];
               n121BR_Medication_RXName = H006O2_n121BR_Medication_RXName[0];
               A328BR_Scheme_Chem_Regimens = H006O2_A328BR_Scheme_Chem_Regimens[0];
               n328BR_Scheme_Chem_Regimens = H006O2_n328BR_Scheme_Chem_Regimens[0];
               E226O2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 12;
            WB6O0( ) ;
         }
         bGXsfl_12_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes6O2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_SCHEME_MEDICATIONID"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, context.localUtil.Format( (decimal)(A332BR_Scheme_MedicationID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         /* Using cursor H006O3 */
         pr_default.execute(1);
         GRID_nRecordCount = H006O3_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace, AV15ddo_BR_SchemeIDTitleControlIdToReplace, AV17ddo_BR_MedicationIDTitleControlIdToReplace, AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, AV21ddo_BR_Medication_RXNameTitleControlIdToReplace, AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace, AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace, AV15ddo_BR_SchemeIDTitleControlIdToReplace, AV17ddo_BR_MedicationIDTitleControlIdToReplace, AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, AV21ddo_BR_Medication_RXNameTitleControlIdToReplace, AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace, AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace, AV15ddo_BR_SchemeIDTitleControlIdToReplace, AV17ddo_BR_MedicationIDTitleControlIdToReplace, AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, AV21ddo_BR_Medication_RXNameTitleControlIdToReplace, AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace, AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace, AV15ddo_BR_SchemeIDTitleControlIdToReplace, AV17ddo_BR_MedicationIDTitleControlIdToReplace, AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, AV21ddo_BR_Medication_RXNameTitleControlIdToReplace, AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace, AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace, AV15ddo_BR_SchemeIDTitleControlIdToReplace, AV17ddo_BR_MedicationIDTitleControlIdToReplace, AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, AV21ddo_BR_Medication_RXNameTitleControlIdToReplace, AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace, AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP6O0( )
      {
         /* Before Start, stand alone formulas. */
         AV37Pgmname = "BR_Scheme_MedicationPrompt";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E206O2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV26DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA"), AV12BR_Scheme_MedicationIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_SCHEMEIDTITLEFILTERDATA"), AV14BR_SchemeIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATIONIDTITLEFILTERDATA"), AV16BR_MedicationIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA"), AV18BR_Scheme_Chem_RegimensTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_RXNAMETITLEFILTERDATA"), AV20BR_Medication_RXNameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_RXDOSETITLEFILTERDATA"), AV22BR_Medication_RXDoseTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_RXUNITTITLEFILTERDATA"), AV24BR_Medication_RXUnitTitleFilterData);
            /* Read variables values. */
            AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace = cgiGet( edtavDdo_br_scheme_medicationidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace", AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace);
            AV15ddo_BR_SchemeIDTitleControlIdToReplace = cgiGet( edtavDdo_br_schemeidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ddo_BR_SchemeIDTitleControlIdToReplace", AV15ddo_BR_SchemeIDTitleControlIdToReplace);
            AV17ddo_BR_MedicationIDTitleControlIdToReplace = cgiGet( edtavDdo_br_medicationidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17ddo_BR_MedicationIDTitleControlIdToReplace", AV17ddo_BR_MedicationIDTitleControlIdToReplace);
            AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = cgiGet( edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace", AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace);
            AV21ddo_BR_Medication_RXNameTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ddo_BR_Medication_RXNameTitleControlIdToReplace", AV21ddo_BR_Medication_RXNameTitleControlIdToReplace);
            AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace", AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace);
            AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace", AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace);
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
            AV28GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV30GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV29GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_scheme_medicationid_Caption = cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Caption");
            Ddo_br_scheme_medicationid_Tooltip = cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Tooltip");
            Ddo_br_scheme_medicationid_Cls = cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Cls");
            Ddo_br_scheme_medicationid_Dropdownoptionstype = cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Dropdownoptionstype");
            Ddo_br_scheme_medicationid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Titlecontrolidtoreplace");
            Ddo_br_scheme_medicationid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Includesortasc"));
            Ddo_br_scheme_medicationid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Includesortdsc"));
            Ddo_br_scheme_medicationid_Sortedstatus = cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Sortedstatus");
            Ddo_br_scheme_medicationid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Includefilter"));
            Ddo_br_scheme_medicationid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Includedatalist"));
            Ddo_br_scheme_medicationid_Sortasc = cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Sortasc");
            Ddo_br_scheme_medicationid_Sortdsc = cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Sortdsc");
            Ddo_br_scheme_medicationid_Searchbuttontext = cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Searchbuttontext");
            Ddo_br_schemeid_Caption = cgiGet( "DDO_BR_SCHEMEID_Caption");
            Ddo_br_schemeid_Tooltip = cgiGet( "DDO_BR_SCHEMEID_Tooltip");
            Ddo_br_schemeid_Cls = cgiGet( "DDO_BR_SCHEMEID_Cls");
            Ddo_br_schemeid_Dropdownoptionstype = cgiGet( "DDO_BR_SCHEMEID_Dropdownoptionstype");
            Ddo_br_schemeid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_SCHEMEID_Titlecontrolidtoreplace");
            Ddo_br_schemeid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEMEID_Includesortasc"));
            Ddo_br_schemeid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEMEID_Includesortdsc"));
            Ddo_br_schemeid_Sortedstatus = cgiGet( "DDO_BR_SCHEMEID_Sortedstatus");
            Ddo_br_schemeid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEMEID_Includefilter"));
            Ddo_br_schemeid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEMEID_Includedatalist"));
            Ddo_br_schemeid_Sortasc = cgiGet( "DDO_BR_SCHEMEID_Sortasc");
            Ddo_br_schemeid_Sortdsc = cgiGet( "DDO_BR_SCHEMEID_Sortdsc");
            Ddo_br_schemeid_Searchbuttontext = cgiGet( "DDO_BR_SCHEMEID_Searchbuttontext");
            Ddo_br_medicationid_Caption = cgiGet( "DDO_BR_MEDICATIONID_Caption");
            Ddo_br_medicationid_Tooltip = cgiGet( "DDO_BR_MEDICATIONID_Tooltip");
            Ddo_br_medicationid_Cls = cgiGet( "DDO_BR_MEDICATIONID_Cls");
            Ddo_br_medicationid_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATIONID_Dropdownoptionstype");
            Ddo_br_medicationid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATIONID_Titlecontrolidtoreplace");
            Ddo_br_medicationid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATIONID_Includesortasc"));
            Ddo_br_medicationid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATIONID_Includesortdsc"));
            Ddo_br_medicationid_Sortedstatus = cgiGet( "DDO_BR_MEDICATIONID_Sortedstatus");
            Ddo_br_medicationid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATIONID_Includefilter"));
            Ddo_br_medicationid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATIONID_Includedatalist"));
            Ddo_br_medicationid_Sortasc = cgiGet( "DDO_BR_MEDICATIONID_Sortasc");
            Ddo_br_medicationid_Sortdsc = cgiGet( "DDO_BR_MEDICATIONID_Sortdsc");
            Ddo_br_medicationid_Searchbuttontext = cgiGet( "DDO_BR_MEDICATIONID_Searchbuttontext");
            Ddo_br_scheme_chem_regimens_Caption = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Caption");
            Ddo_br_scheme_chem_regimens_Tooltip = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Tooltip");
            Ddo_br_scheme_chem_regimens_Cls = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Cls");
            Ddo_br_scheme_chem_regimens_Dropdownoptionstype = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Dropdownoptionstype");
            Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Titlecontrolidtoreplace");
            Ddo_br_scheme_chem_regimens_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Includesortasc"));
            Ddo_br_scheme_chem_regimens_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Includesortdsc"));
            Ddo_br_scheme_chem_regimens_Sortedstatus = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Sortedstatus");
            Ddo_br_scheme_chem_regimens_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Includefilter"));
            Ddo_br_scheme_chem_regimens_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Includedatalist"));
            Ddo_br_scheme_chem_regimens_Sortasc = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Sortasc");
            Ddo_br_scheme_chem_regimens_Sortdsc = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Sortdsc");
            Ddo_br_scheme_chem_regimens_Searchbuttontext = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Searchbuttontext");
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
            Ddo_br_medication_rxunit_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_RXUNIT_Includedatalist"));
            Ddo_br_medication_rxunit_Sortasc = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Sortasc");
            Ddo_br_medication_rxunit_Sortdsc = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Sortdsc");
            Ddo_br_medication_rxunit_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_scheme_medicationid_Activeeventkey = cgiGet( "DDO_BR_SCHEME_MEDICATIONID_Activeeventkey");
            Ddo_br_schemeid_Activeeventkey = cgiGet( "DDO_BR_SCHEMEID_Activeeventkey");
            Ddo_br_medicationid_Activeeventkey = cgiGet( "DDO_BR_MEDICATIONID_Activeeventkey");
            Ddo_br_scheme_chem_regimens_Activeeventkey = cgiGet( "DDO_BR_SCHEME_CHEM_REGIMENS_Activeeventkey");
            Ddo_br_medication_rxname_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_RXNAME_Activeeventkey");
            Ddo_br_medication_rxdose_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_RXDOSE_Activeeventkey");
            Ddo_br_medication_rxunit_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_RXUNIT_Activeeventkey");
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
         E206O2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E206O2( )
      {
         /* Start Routine */
         GXt_boolean1 = AV5IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Scheme_Medication", out  GXt_boolean1) ;
         AV5IsAuthorized = GXt_boolean1;
         if ( ! AV5IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV37Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         divTablemain_Height = 493;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTablemain_Internalname, "Height", StringUtil.LTrim( StringUtil.Str( (decimal)(divTablemain_Height), 9, 0)), true);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_br_scheme_medicationid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Scheme_MedicationID";
         ucDdo_br_scheme_medicationid.SendProperty(context, "", false, Ddo_br_scheme_medicationid_Internalname, "TitleControlIdToReplace", Ddo_br_scheme_medicationid_Titlecontrolidtoreplace);
         AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace = Ddo_br_scheme_medicationid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace", AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace);
         edtavDdo_br_scheme_medicationidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_scheme_medicationidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_scheme_medicationidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_schemeid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_SchemeID";
         ucDdo_br_schemeid.SendProperty(context, "", false, Ddo_br_schemeid_Internalname, "TitleControlIdToReplace", Ddo_br_schemeid_Titlecontrolidtoreplace);
         AV15ddo_BR_SchemeIDTitleControlIdToReplace = Ddo_br_schemeid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ddo_BR_SchemeIDTitleControlIdToReplace", AV15ddo_BR_SchemeIDTitleControlIdToReplace);
         edtavDdo_br_schemeidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_schemeidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_schemeidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicationid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicationID";
         ucDdo_br_medicationid.SendProperty(context, "", false, Ddo_br_medicationid_Internalname, "TitleControlIdToReplace", Ddo_br_medicationid_Titlecontrolidtoreplace);
         AV17ddo_BR_MedicationIDTitleControlIdToReplace = Ddo_br_medicationid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17ddo_BR_MedicationIDTitleControlIdToReplace", AV17ddo_BR_MedicationIDTitleControlIdToReplace);
         edtavDdo_br_medicationidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicationidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicationidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Scheme_Chem_Regimens";
         ucDdo_br_scheme_chem_regimens.SendProperty(context, "", false, Ddo_br_scheme_chem_regimens_Internalname, "TitleControlIdToReplace", Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace);
         AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace", AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace);
         edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_rxname_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_RXName";
         ucDdo_br_medication_rxname.SendProperty(context, "", false, Ddo_br_medication_rxname_Internalname, "TitleControlIdToReplace", Ddo_br_medication_rxname_Titlecontrolidtoreplace);
         AV21ddo_BR_Medication_RXNameTitleControlIdToReplace = Ddo_br_medication_rxname_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ddo_BR_Medication_RXNameTitleControlIdToReplace", AV21ddo_BR_Medication_RXNameTitleControlIdToReplace);
         edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_rxdose_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_RXDose";
         ucDdo_br_medication_rxdose.SendProperty(context, "", false, Ddo_br_medication_rxdose_Internalname, "TitleControlIdToReplace", Ddo_br_medication_rxdose_Titlecontrolidtoreplace);
         AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace = Ddo_br_medication_rxdose_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace", AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace);
         edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_rxunit_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_RXUnit";
         ucDdo_br_medication_rxunit.SendProperty(context, "", false, Ddo_br_medication_rxunit_Internalname, "TitleControlIdToReplace", Ddo_br_medication_rxunit_Titlecontrolidtoreplace);
         AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace = Ddo_br_medication_rxunit_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace", AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace);
         edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "选择化疗方案药物详情";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV26DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV26DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E216O2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV12BR_Scheme_MedicationIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV14BR_SchemeIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV16BR_MedicationIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV18BR_Scheme_Chem_RegimensTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_Medication_RXNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV22BR_Medication_RXDoseTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_Medication_RXUnitTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         edtBR_Scheme_MedicationID_Titleformat = 2;
         edtBR_Scheme_MedicationID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "化疗方案药物详情主键", AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Scheme_MedicationID_Internalname, "Title", edtBR_Scheme_MedicationID_Title, !bGXsfl_12_Refreshing);
         edtBR_SchemeID_Titleformat = 2;
         edtBR_SchemeID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "化疗方案主键", AV15ddo_BR_SchemeIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_SchemeID_Internalname, "Title", edtBR_SchemeID_Title, !bGXsfl_12_Refreshing);
         edtBR_MedicationID_Titleformat = 2;
         edtBR_MedicationID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "药物治疗主键", AV17ddo_BR_MedicationIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicationID_Internalname, "Title", edtBR_MedicationID_Title, !bGXsfl_12_Refreshing);
         edtBR_Scheme_Chem_Regimens_Titleformat = 2;
         edtBR_Scheme_Chem_Regimens_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "化疗方案", AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Scheme_Chem_Regimens_Internalname, "Title", edtBR_Scheme_Chem_Regimens_Title, !bGXsfl_12_Refreshing);
         edtBR_Medication_RXName_Titleformat = 2;
         edtBR_Medication_RXName_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "药物名称", AV21ddo_BR_Medication_RXNameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_RXName_Internalname, "Title", edtBR_Medication_RXName_Title, !bGXsfl_12_Refreshing);
         edtBR_Medication_RXDose_Titleformat = 2;
         edtBR_Medication_RXDose_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "药物剂量", AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_RXDose_Internalname, "Title", edtBR_Medication_RXDose_Title, !bGXsfl_12_Refreshing);
         edtBR_Medication_RXUnit_Titleformat = 2;
         edtBR_Medication_RXUnit_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "计量单位", AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_RXUnit_Internalname, "Title", edtBR_Medication_RXUnit_Title, !bGXsfl_12_Refreshing);
         AV28GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28GridCurrentPage), 10, 0)));
         AV29GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29GridPageSize), 10, 0)));
         AV30GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_Scheme_MedicationIDTitleFilterData", AV12BR_Scheme_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_SchemeIDTitleFilterData", AV14BR_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_MedicationIDTitleFilterData", AV16BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Scheme_Chem_RegimensTitleFilterData", AV18BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Medication_RXNameTitleFilterData", AV20BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Medication_RXDoseTitleFilterData", AV22BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Medication_RXUnitTitleFilterData", AV24BR_Medication_RXUnitTitleFilterData);
      }

      protected void E116O2( )
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
            AV27PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV27PageToGo) ;
         }
      }

      protected void E126O2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E136O2( )
      {
         /* Ddo_br_scheme_medicationid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_scheme_medicationid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_scheme_medicationid_Sortedstatus = "ASC";
            ucDdo_br_scheme_medicationid.SendProperty(context, "", false, Ddo_br_scheme_medicationid_Internalname, "SortedStatus", Ddo_br_scheme_medicationid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_scheme_medicationid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_scheme_medicationid_Sortedstatus = "DSC";
            ucDdo_br_scheme_medicationid.SendProperty(context, "", false, Ddo_br_scheme_medicationid_Internalname, "SortedStatus", Ddo_br_scheme_medicationid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_Scheme_MedicationIDTitleFilterData", AV12BR_Scheme_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_SchemeIDTitleFilterData", AV14BR_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_MedicationIDTitleFilterData", AV16BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Scheme_Chem_RegimensTitleFilterData", AV18BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Medication_RXNameTitleFilterData", AV20BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Medication_RXDoseTitleFilterData", AV22BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Medication_RXUnitTitleFilterData", AV24BR_Medication_RXUnitTitleFilterData);
      }

      protected void E146O2( )
      {
         /* Ddo_br_schemeid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_schemeid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_schemeid_Sortedstatus = "ASC";
            ucDdo_br_schemeid.SendProperty(context, "", false, Ddo_br_schemeid_Internalname, "SortedStatus", Ddo_br_schemeid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_schemeid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_schemeid_Sortedstatus = "DSC";
            ucDdo_br_schemeid.SendProperty(context, "", false, Ddo_br_schemeid_Internalname, "SortedStatus", Ddo_br_schemeid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_Scheme_MedicationIDTitleFilterData", AV12BR_Scheme_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_SchemeIDTitleFilterData", AV14BR_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_MedicationIDTitleFilterData", AV16BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Scheme_Chem_RegimensTitleFilterData", AV18BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Medication_RXNameTitleFilterData", AV20BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Medication_RXDoseTitleFilterData", AV22BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Medication_RXUnitTitleFilterData", AV24BR_Medication_RXUnitTitleFilterData);
      }

      protected void E156O2( )
      {
         /* Ddo_br_medicationid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicationid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_medicationid_Sortedstatus = "ASC";
            ucDdo_br_medicationid.SendProperty(context, "", false, Ddo_br_medicationid_Internalname, "SortedStatus", Ddo_br_medicationid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicationid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_medicationid_Sortedstatus = "DSC";
            ucDdo_br_medicationid.SendProperty(context, "", false, Ddo_br_medicationid_Internalname, "SortedStatus", Ddo_br_medicationid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_Scheme_MedicationIDTitleFilterData", AV12BR_Scheme_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_SchemeIDTitleFilterData", AV14BR_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_MedicationIDTitleFilterData", AV16BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Scheme_Chem_RegimensTitleFilterData", AV18BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Medication_RXNameTitleFilterData", AV20BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Medication_RXDoseTitleFilterData", AV22BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Medication_RXUnitTitleFilterData", AV24BR_Medication_RXUnitTitleFilterData);
      }

      protected void E166O2( )
      {
         /* Ddo_br_scheme_chem_regimens_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_scheme_chem_regimens_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_scheme_chem_regimens_Sortedstatus = "ASC";
            ucDdo_br_scheme_chem_regimens.SendProperty(context, "", false, Ddo_br_scheme_chem_regimens_Internalname, "SortedStatus", Ddo_br_scheme_chem_regimens_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_scheme_chem_regimens_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_scheme_chem_regimens_Sortedstatus = "DSC";
            ucDdo_br_scheme_chem_regimens.SendProperty(context, "", false, Ddo_br_scheme_chem_regimens_Internalname, "SortedStatus", Ddo_br_scheme_chem_regimens_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_Scheme_MedicationIDTitleFilterData", AV12BR_Scheme_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_SchemeIDTitleFilterData", AV14BR_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_MedicationIDTitleFilterData", AV16BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Scheme_Chem_RegimensTitleFilterData", AV18BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Medication_RXNameTitleFilterData", AV20BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Medication_RXDoseTitleFilterData", AV22BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Medication_RXUnitTitleFilterData", AV24BR_Medication_RXUnitTitleFilterData);
      }

      protected void E176O2( )
      {
         /* Ddo_br_medication_rxname_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_rxname_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 5;
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
            AV10OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_medication_rxname_Sortedstatus = "DSC";
            ucDdo_br_medication_rxname.SendProperty(context, "", false, Ddo_br_medication_rxname_Internalname, "SortedStatus", Ddo_br_medication_rxname_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_Scheme_MedicationIDTitleFilterData", AV12BR_Scheme_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_SchemeIDTitleFilterData", AV14BR_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_MedicationIDTitleFilterData", AV16BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Scheme_Chem_RegimensTitleFilterData", AV18BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Medication_RXNameTitleFilterData", AV20BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Medication_RXDoseTitleFilterData", AV22BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Medication_RXUnitTitleFilterData", AV24BR_Medication_RXUnitTitleFilterData);
      }

      protected void E186O2( )
      {
         /* Ddo_br_medication_rxdose_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_rxdose_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 6;
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
            AV10OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_medication_rxdose_Sortedstatus = "DSC";
            ucDdo_br_medication_rxdose.SendProperty(context, "", false, Ddo_br_medication_rxdose_Internalname, "SortedStatus", Ddo_br_medication_rxdose_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_Scheme_MedicationIDTitleFilterData", AV12BR_Scheme_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_SchemeIDTitleFilterData", AV14BR_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_MedicationIDTitleFilterData", AV16BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Scheme_Chem_RegimensTitleFilterData", AV18BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Medication_RXNameTitleFilterData", AV20BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Medication_RXDoseTitleFilterData", AV22BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Medication_RXUnitTitleFilterData", AV24BR_Medication_RXUnitTitleFilterData);
      }

      protected void E196O2( )
      {
         /* Ddo_br_medication_rxunit_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_rxunit_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 7;
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
            AV10OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_medication_rxunit_Sortedstatus = "DSC";
            ucDdo_br_medication_rxunit.SendProperty(context, "", false, Ddo_br_medication_rxunit_Internalname, "SortedStatus", Ddo_br_medication_rxunit_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_Scheme_MedicationIDTitleFilterData", AV12BR_Scheme_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_SchemeIDTitleFilterData", AV14BR_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_MedicationIDTitleFilterData", AV16BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Scheme_Chem_RegimensTitleFilterData", AV18BR_Scheme_Chem_RegimensTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Medication_RXNameTitleFilterData", AV20BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Medication_RXDoseTitleFilterData", AV22BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Medication_RXUnitTitleFilterData", AV24BR_Medication_RXUnitTitleFilterData);
      }

      private void E226O2( )
      {
         /* Grid_Load Routine */
         AV31Select = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSelect_Internalname, AV31Select);
         AV38Select_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
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
         E236O2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E236O2( )
      {
         /* Enter Routine */
         AV8InOutBR_Scheme_MedicationID = A332BR_Scheme_MedicationID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_Scheme_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_Scheme_MedicationID), 18, 0)));
         context.setWebReturnParms(new Object[] {(long)AV8InOutBR_Scheme_MedicationID});
         context.setWebReturnParmsMetadata(new Object[] {"AV8InOutBR_Scheme_MedicationID"});
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
         AV8InOutBR_Scheme_MedicationID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_Scheme_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_Scheme_MedicationID), 18, 0)));
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
         PA6O2( ) ;
         WS6O2( ) ;
         WE6O2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022815154260", true);
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
         context.AddJavascriptSource("br_scheme_medicationprompt.js", "?202022815154260", false);
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

      protected void SubsflControlProps_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_idx;
         edtBR_Scheme_MedicationID_Internalname = "BR_SCHEME_MEDICATIONID_"+sGXsfl_12_idx;
         edtBR_SchemeID_Internalname = "BR_SCHEMEID_"+sGXsfl_12_idx;
         edtBR_MedicationID_Internalname = "BR_MEDICATIONID_"+sGXsfl_12_idx;
         edtBR_Scheme_Chem_Regimens_Internalname = "BR_SCHEME_CHEM_REGIMENS_"+sGXsfl_12_idx;
         edtBR_Medication_RXName_Internalname = "BR_MEDICATION_RXNAME_"+sGXsfl_12_idx;
         edtBR_Medication_RXDose_Internalname = "BR_MEDICATION_RXDOSE_"+sGXsfl_12_idx;
         edtBR_Medication_RXUnit_Internalname = "BR_MEDICATION_RXUNIT_"+sGXsfl_12_idx;
      }

      protected void SubsflControlProps_fel_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_fel_idx;
         edtBR_Scheme_MedicationID_Internalname = "BR_SCHEME_MEDICATIONID_"+sGXsfl_12_fel_idx;
         edtBR_SchemeID_Internalname = "BR_SCHEMEID_"+sGXsfl_12_fel_idx;
         edtBR_MedicationID_Internalname = "BR_MEDICATIONID_"+sGXsfl_12_fel_idx;
         edtBR_Scheme_Chem_Regimens_Internalname = "BR_SCHEME_CHEM_REGIMENS_"+sGXsfl_12_fel_idx;
         edtBR_Medication_RXName_Internalname = "BR_MEDICATION_RXNAME_"+sGXsfl_12_fel_idx;
         edtBR_Medication_RXDose_Internalname = "BR_MEDICATION_RXDOSE_"+sGXsfl_12_fel_idx;
         edtBR_Medication_RXUnit_Internalname = "BR_MEDICATION_RXUNIT_"+sGXsfl_12_fel_idx;
      }

      protected void sendrow_122( )
      {
         SubsflControlProps_122( ) ;
         WB6O0( ) ;
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
            AV31Select_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV31Select))&&String.IsNullOrEmpty(StringUtil.RTrim( AV38Select_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV31Select)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV31Select)) ? AV38Select_GXI : context.PathToRelativeUrl( AV31Select));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSelect_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSelect_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSelect_Jsonclick,"'"+""+"'"+",false,"+"'"+"EENTER."+sGXsfl_12_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV31Select_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Scheme_MedicationID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A332BR_Scheme_MedicationID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A332BR_Scheme_MedicationID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Scheme_MedicationID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_SchemeID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A327BR_SchemeID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A327BR_SchemeID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_SchemeID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicationID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A119BR_MedicationID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A119BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicationID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Scheme_Chem_Regimens_Internalname,(String)A328BR_Scheme_Chem_Regimens,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Scheme_Chem_Regimens_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
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
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_RXDose_Internalname,StringUtil.LTrim( StringUtil.NToC( A124BR_Medication_RXDose, 15, 5, ".", "")),context.localUtil.Format( A124BR_Medication_RXDose, "ZZZZZZZZZ.ZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_RXDose_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_RXUnit_Internalname,(String)A125BR_Medication_RXUnit,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_RXUnit_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes6O2( ) ;
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
         edtBR_Scheme_MedicationID_Internalname = "BR_SCHEME_MEDICATIONID";
         edtBR_SchemeID_Internalname = "BR_SCHEMEID";
         edtBR_MedicationID_Internalname = "BR_MEDICATIONID";
         edtBR_Scheme_Chem_Regimens_Internalname = "BR_SCHEME_CHEM_REGIMENS";
         edtBR_Medication_RXName_Internalname = "BR_MEDICATION_RXNAME";
         edtBR_Medication_RXDose_Internalname = "BR_MEDICATION_RXDOSE";
         edtBR_Medication_RXUnit_Internalname = "BR_MEDICATION_RXUNIT";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_scheme_medicationid_Internalname = "DDO_BR_SCHEME_MEDICATIONID";
         edtavDdo_br_scheme_medicationidtitlecontrolidtoreplace_Internalname = "vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE";
         Ddo_br_schemeid_Internalname = "DDO_BR_SCHEMEID";
         edtavDdo_br_schemeidtitlecontrolidtoreplace_Internalname = "vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE";
         Ddo_br_medicationid_Internalname = "DDO_BR_MEDICATIONID";
         edtavDdo_br_medicationidtitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE";
         Ddo_br_scheme_chem_regimens_Internalname = "DDO_BR_SCHEME_CHEM_REGIMENS";
         edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Internalname = "vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE";
         Ddo_br_medication_rxname_Internalname = "DDO_BR_MEDICATION_RXNAME";
         edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE";
         Ddo_br_medication_rxdose_Internalname = "DDO_BR_MEDICATION_RXDOSE";
         edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE";
         Ddo_br_medication_rxunit_Internalname = "DDO_BR_MEDICATION_RXUNIT";
         edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE";
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
         edtBR_Medication_RXUnit_Jsonclick = "";
         edtBR_Medication_RXDose_Jsonclick = "";
         edtBR_Medication_RXName_Jsonclick = "";
         edtBR_Scheme_Chem_Regimens_Jsonclick = "";
         edtBR_MedicationID_Jsonclick = "";
         edtBR_SchemeID_Jsonclick = "";
         edtBR_Scheme_MedicationID_Jsonclick = "";
         edtavSelect_Jsonclick = "";
         edtavSelect_Visible = -1;
         edtavSelect_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medicationidtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_schemeidtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_scheme_medicationidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavSelect_Tooltiptext = "选择";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Medication_RXUnit_Titleformat = 0;
         edtBR_Medication_RXUnit_Title = "计量单位";
         edtBR_Medication_RXDose_Titleformat = 0;
         edtBR_Medication_RXDose_Title = "药物剂量";
         edtBR_Medication_RXName_Titleformat = 0;
         edtBR_Medication_RXName_Title = "药物名称";
         edtBR_Scheme_Chem_Regimens_Titleformat = 0;
         edtBR_Scheme_Chem_Regimens_Title = "化疗方案";
         edtBR_MedicationID_Titleformat = 0;
         edtBR_MedicationID_Title = "药物治疗主键";
         edtBR_SchemeID_Titleformat = 0;
         edtBR_SchemeID_Title = "化疗方案主键";
         edtBR_Scheme_MedicationID_Titleformat = 0;
         edtBR_Scheme_MedicationID_Title = "化疗方案药物详情主键";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         divTablemain_Height = 0;
         Ddo_br_medication_rxunit_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_rxunit_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_rxunit_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_rxunit_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medication_rxunit_Includefilter = Convert.ToBoolean( 0);
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
         Ddo_br_scheme_chem_regimens_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_scheme_chem_regimens_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_scheme_chem_regimens_Sortasc = "WWP_TSSortASC";
         Ddo_br_scheme_chem_regimens_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_scheme_chem_regimens_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_scheme_chem_regimens_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_scheme_chem_regimens_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace = "";
         Ddo_br_scheme_chem_regimens_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_scheme_chem_regimens_Cls = "ColumnSettings";
         Ddo_br_scheme_chem_regimens_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_scheme_chem_regimens_Caption = "";
         Ddo_br_medicationid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicationid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicationid_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicationid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicationid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medicationid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicationid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicationid_Titlecontrolidtoreplace = "";
         Ddo_br_medicationid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicationid_Cls = "ColumnSettings";
         Ddo_br_medicationid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicationid_Caption = "";
         Ddo_br_schemeid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_schemeid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_schemeid_Sortasc = "WWP_TSSortASC";
         Ddo_br_schemeid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_schemeid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_schemeid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_schemeid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_schemeid_Titlecontrolidtoreplace = "";
         Ddo_br_schemeid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_schemeid_Cls = "ColumnSettings";
         Ddo_br_schemeid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_schemeid_Caption = "";
         Ddo_br_scheme_medicationid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_scheme_medicationid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_scheme_medicationid_Sortasc = "WWP_TSSortASC";
         Ddo_br_scheme_medicationid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_scheme_medicationid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_scheme_medicationid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_scheme_medicationid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_scheme_medicationid_Titlecontrolidtoreplace = "";
         Ddo_br_scheme_medicationid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_scheme_medicationid_Cls = "ColumnSettings";
         Ddo_br_scheme_medicationid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_scheme_medicationid_Caption = "";
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
         Form.Caption = "选择化疗方案药物详情";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV12BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV14BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV16BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV22BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV24BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'edtBR_Scheme_MedicationID_Titleformat',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_Scheme_MedicationID_Title',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{av:'edtBR_SchemeID_Titleformat',ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'edtBR_SchemeID_Title',ctrl:'BR_SCHEMEID',prop:'Title'},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXUnit_Titleformat',ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'edtBR_Medication_RXUnit_Title',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV28GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV29GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV30GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E116O2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E126O2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_SCHEME_MEDICATIONID.ONOPTIONCLICKED","{handler:'E136O2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_scheme_medicationid_Activeeventkey',ctrl:'DDO_BR_SCHEME_MEDICATIONID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_SCHEME_MEDICATIONID.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_scheme_medicationid_Sortedstatus',ctrl:'DDO_BR_SCHEME_MEDICATIONID',prop:'SortedStatus'},{av:'AV12BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV14BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV16BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV22BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV24BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'edtBR_Scheme_MedicationID_Titleformat',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_Scheme_MedicationID_Title',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{av:'edtBR_SchemeID_Titleformat',ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'edtBR_SchemeID_Title',ctrl:'BR_SCHEMEID',prop:'Title'},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXUnit_Titleformat',ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'edtBR_Medication_RXUnit_Title',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV28GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV29GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV30GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_SCHEMEID.ONOPTIONCLICKED","{handler:'E146O2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_schemeid_Activeeventkey',ctrl:'DDO_BR_SCHEMEID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_SCHEMEID.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_schemeid_Sortedstatus',ctrl:'DDO_BR_SCHEMEID',prop:'SortedStatus'},{av:'AV12BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV14BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV16BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV22BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV24BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'edtBR_Scheme_MedicationID_Titleformat',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_Scheme_MedicationID_Title',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{av:'edtBR_SchemeID_Titleformat',ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'edtBR_SchemeID_Title',ctrl:'BR_SCHEMEID',prop:'Title'},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXUnit_Titleformat',ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'edtBR_Medication_RXUnit_Title',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV28GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV29GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV30GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICATIONID.ONOPTIONCLICKED","{handler:'E156O2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medicationid_Activeeventkey',ctrl:'DDO_BR_MEDICATIONID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICATIONID.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicationid_Sortedstatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'AV12BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV14BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV16BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV22BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV24BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'edtBR_Scheme_MedicationID_Titleformat',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_Scheme_MedicationID_Title',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{av:'edtBR_SchemeID_Titleformat',ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'edtBR_SchemeID_Title',ctrl:'BR_SCHEMEID',prop:'Title'},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXUnit_Titleformat',ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'edtBR_Medication_RXUnit_Title',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV28GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV29GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV30GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_SCHEME_CHEM_REGIMENS.ONOPTIONCLICKED","{handler:'E166O2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_scheme_chem_regimens_Activeeventkey',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_SCHEME_CHEM_REGIMENS.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_scheme_chem_regimens_Sortedstatus',ctrl:'DDO_BR_SCHEME_CHEM_REGIMENS',prop:'SortedStatus'},{av:'AV12BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV14BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV16BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV22BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV24BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'edtBR_Scheme_MedicationID_Titleformat',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_Scheme_MedicationID_Title',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{av:'edtBR_SchemeID_Titleformat',ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'edtBR_SchemeID_Title',ctrl:'BR_SCHEMEID',prop:'Title'},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXUnit_Titleformat',ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'edtBR_Medication_RXUnit_Title',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV28GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV29GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV30GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED","{handler:'E176O2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medication_rxname_Activeeventkey',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_rxname_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'AV12BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV14BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV16BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV22BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV24BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'edtBR_Scheme_MedicationID_Titleformat',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_Scheme_MedicationID_Title',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{av:'edtBR_SchemeID_Titleformat',ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'edtBR_SchemeID_Title',ctrl:'BR_SCHEMEID',prop:'Title'},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXUnit_Titleformat',ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'edtBR_Medication_RXUnit_Title',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV28GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV29GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV30GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICATION_RXDOSE.ONOPTIONCLICKED","{handler:'E186O2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medication_rxdose_Activeeventkey',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICATION_RXDOSE.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_rxdose_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'AV12BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV14BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV16BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV22BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV24BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'edtBR_Scheme_MedicationID_Titleformat',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_Scheme_MedicationID_Title',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{av:'edtBR_SchemeID_Titleformat',ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'edtBR_SchemeID_Title',ctrl:'BR_SCHEMEID',prop:'Title'},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXUnit_Titleformat',ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'edtBR_Medication_RXUnit_Title',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV28GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV29GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV30GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICATION_RXUNIT.ONOPTIONCLICKED","{handler:'E196O2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace',fld:'vDDO_BR_SCHEME_CHEM_REGIMENSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXUNITTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medication_rxunit_Activeeventkey',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICATION_RXUNIT.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_rxunit_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXUNIT',prop:'SortedStatus'},{av:'AV12BR_Scheme_MedicationIDTitleFilterData',fld:'vBR_SCHEME_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV14BR_SchemeIDTitleFilterData',fld:'vBR_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV16BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Scheme_Chem_RegimensTitleFilterData',fld:'vBR_SCHEME_CHEM_REGIMENSTITLEFILTERDATA',pic:''},{av:'AV20BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV22BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV24BR_Medication_RXUnitTitleFilterData',fld:'vBR_MEDICATION_RXUNITTITLEFILTERDATA',pic:''},{av:'edtBR_Scheme_MedicationID_Titleformat',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_Scheme_MedicationID_Title',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Title'},{av:'edtBR_SchemeID_Titleformat',ctrl:'BR_SCHEMEID',prop:'Titleformat'},{av:'edtBR_SchemeID_Title',ctrl:'BR_SCHEMEID',prop:'Title'},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Scheme_Chem_Regimens_Titleformat',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Titleformat'},{av:'edtBR_Scheme_Chem_Regimens_Title',ctrl:'BR_SCHEME_CHEM_REGIMENS',prop:'Title'},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXUnit_Titleformat',ctrl:'BR_MEDICATION_RXUNIT',prop:'Titleformat'},{av:'edtBR_Medication_RXUnit_Title',ctrl:'BR_MEDICATION_RXUNIT',prop:'Title'},{av:'AV28GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV29GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV30GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E226O2',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV31Select',fld:'vSELECT',pic:''},{av:'edtavSelect_Tooltiptext',ctrl:'vSELECT',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E236O2',iparms:[{av:'A332BR_Scheme_MedicationID',fld:'BR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV8InOutBR_Scheme_MedicationID',fld:'vINOUTBR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'}]}");
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
         Ddo_br_scheme_medicationid_Activeeventkey = "";
         Ddo_br_schemeid_Activeeventkey = "";
         Ddo_br_medicationid_Activeeventkey = "";
         Ddo_br_scheme_chem_regimens_Activeeventkey = "";
         Ddo_br_medication_rxname_Activeeventkey = "";
         Ddo_br_medication_rxdose_Activeeventkey = "";
         Ddo_br_medication_rxunit_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace = "";
         AV15ddo_BR_SchemeIDTitleControlIdToReplace = "";
         AV17ddo_BR_MedicationIDTitleControlIdToReplace = "";
         AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace = "";
         AV21ddo_BR_Medication_RXNameTitleControlIdToReplace = "";
         AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace = "";
         AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace = "";
         GXKey = "";
         AV37Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV26DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV12BR_Scheme_MedicationIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV14BR_SchemeIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV16BR_MedicationIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV18BR_Scheme_Chem_RegimensTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_Medication_RXNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV22BR_Medication_RXDoseTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_Medication_RXUnitTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_scheme_medicationid_Sortedstatus = "";
         Ddo_br_schemeid_Sortedstatus = "";
         Ddo_br_medicationid_Sortedstatus = "";
         Ddo_br_scheme_chem_regimens_Sortedstatus = "";
         Ddo_br_medication_rxname_Sortedstatus = "";
         Ddo_br_medication_rxdose_Sortedstatus = "";
         Ddo_br_medication_rxunit_Sortedstatus = "";
         GX_FocusControl = "";
         sPrefix = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV31Select = "";
         A328BR_Scheme_Chem_Regimens = "";
         A121BR_Medication_RXName = "";
         A125BR_Medication_RXUnit = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_scheme_medicationid = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_br_schemeid = new GXUserControl();
         ucDdo_br_medicationid = new GXUserControl();
         ucDdo_br_scheme_chem_regimens = new GXUserControl();
         ucDdo_br_medication_rxname = new GXUserControl();
         ucDdo_br_medication_rxdose = new GXUserControl();
         ucDdo_br_medication_rxunit = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV38Select_GXI = "";
         scmdbuf = "";
         H006O2_A125BR_Medication_RXUnit = new String[] {""} ;
         H006O2_n125BR_Medication_RXUnit = new bool[] {false} ;
         H006O2_A124BR_Medication_RXDose = new decimal[1] ;
         H006O2_n124BR_Medication_RXDose = new bool[] {false} ;
         H006O2_A121BR_Medication_RXName = new String[] {""} ;
         H006O2_n121BR_Medication_RXName = new bool[] {false} ;
         H006O2_A328BR_Scheme_Chem_Regimens = new String[] {""} ;
         H006O2_n328BR_Scheme_Chem_Regimens = new bool[] {false} ;
         H006O2_A119BR_MedicationID = new long[1] ;
         H006O2_n119BR_MedicationID = new bool[] {false} ;
         H006O2_A327BR_SchemeID = new long[1] ;
         H006O2_n327BR_SchemeID = new bool[] {false} ;
         H006O2_A332BR_Scheme_MedicationID = new long[1] ;
         H006O3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_scheme_medicationprompt__default(),
            new Object[][] {
                new Object[] {
               H006O2_A125BR_Medication_RXUnit, H006O2_n125BR_Medication_RXUnit, H006O2_A124BR_Medication_RXDose, H006O2_n124BR_Medication_RXDose, H006O2_A121BR_Medication_RXName, H006O2_n121BR_Medication_RXName, H006O2_A328BR_Scheme_Chem_Regimens, H006O2_n328BR_Scheme_Chem_Regimens, H006O2_A119BR_MedicationID, H006O2_n119BR_MedicationID,
               H006O2_A327BR_SchemeID, H006O2_n327BR_SchemeID, H006O2_A332BR_Scheme_MedicationID
               }
               , new Object[] {
               H006O3_AGRID_nRecordCount
               }
            }
         );
         AV37Pgmname = "BR_Scheme_MedicationPrompt";
         /* GeneXus formulas. */
         AV37Pgmname = "BR_Scheme_MedicationPrompt";
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
      private short edtBR_Scheme_MedicationID_Titleformat ;
      private short edtBR_SchemeID_Titleformat ;
      private short edtBR_MedicationID_Titleformat ;
      private short edtBR_Scheme_Chem_Regimens_Titleformat ;
      private short edtBR_Medication_RXName_Titleformat ;
      private short edtBR_Medication_RXDose_Titleformat ;
      private short edtBR_Medication_RXUnit_Titleformat ;
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
      private int edtavDdo_br_scheme_medicationidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_schemeidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medicationidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV27PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavSelect_Enabled ;
      private int edtavSelect_Visible ;
      private long AV8InOutBR_Scheme_MedicationID ;
      private long wcpOAV8InOutBR_Scheme_MedicationID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV28GridCurrentPage ;
      private long AV30GridRecordCount ;
      private long AV29GridPageSize ;
      private long A332BR_Scheme_MedicationID ;
      private long A327BR_SchemeID ;
      private long A119BR_MedicationID ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private decimal A124BR_Medication_RXDose ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_scheme_medicationid_Activeeventkey ;
      private String Ddo_br_schemeid_Activeeventkey ;
      private String Ddo_br_medicationid_Activeeventkey ;
      private String Ddo_br_scheme_chem_regimens_Activeeventkey ;
      private String Ddo_br_medication_rxname_Activeeventkey ;
      private String Ddo_br_medication_rxdose_Activeeventkey ;
      private String Ddo_br_medication_rxunit_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_12_idx="0001" ;
      private String GXKey ;
      private String AV37Pgmname ;
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
      private String Ddo_br_scheme_medicationid_Caption ;
      private String Ddo_br_scheme_medicationid_Tooltip ;
      private String Ddo_br_scheme_medicationid_Cls ;
      private String Ddo_br_scheme_medicationid_Dropdownoptionstype ;
      private String Ddo_br_scheme_medicationid_Titlecontrolidtoreplace ;
      private String Ddo_br_scheme_medicationid_Sortedstatus ;
      private String Ddo_br_scheme_medicationid_Sortasc ;
      private String Ddo_br_scheme_medicationid_Sortdsc ;
      private String Ddo_br_scheme_medicationid_Searchbuttontext ;
      private String Ddo_br_schemeid_Caption ;
      private String Ddo_br_schemeid_Tooltip ;
      private String Ddo_br_schemeid_Cls ;
      private String Ddo_br_schemeid_Dropdownoptionstype ;
      private String Ddo_br_schemeid_Titlecontrolidtoreplace ;
      private String Ddo_br_schemeid_Sortedstatus ;
      private String Ddo_br_schemeid_Sortasc ;
      private String Ddo_br_schemeid_Sortdsc ;
      private String Ddo_br_schemeid_Searchbuttontext ;
      private String Ddo_br_medicationid_Caption ;
      private String Ddo_br_medicationid_Tooltip ;
      private String Ddo_br_medicationid_Cls ;
      private String Ddo_br_medicationid_Dropdownoptionstype ;
      private String Ddo_br_medicationid_Titlecontrolidtoreplace ;
      private String Ddo_br_medicationid_Sortedstatus ;
      private String Ddo_br_medicationid_Sortasc ;
      private String Ddo_br_medicationid_Sortdsc ;
      private String Ddo_br_medicationid_Searchbuttontext ;
      private String Ddo_br_scheme_chem_regimens_Caption ;
      private String Ddo_br_scheme_chem_regimens_Tooltip ;
      private String Ddo_br_scheme_chem_regimens_Cls ;
      private String Ddo_br_scheme_chem_regimens_Dropdownoptionstype ;
      private String Ddo_br_scheme_chem_regimens_Titlecontrolidtoreplace ;
      private String Ddo_br_scheme_chem_regimens_Sortedstatus ;
      private String Ddo_br_scheme_chem_regimens_Sortasc ;
      private String Ddo_br_scheme_chem_regimens_Sortdsc ;
      private String Ddo_br_scheme_chem_regimens_Searchbuttontext ;
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
      private String Ddo_br_medication_rxunit_Sortasc ;
      private String Ddo_br_medication_rxunit_Sortdsc ;
      private String Ddo_br_medication_rxunit_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtBR_Scheme_MedicationID_Title ;
      private String edtBR_SchemeID_Title ;
      private String edtBR_MedicationID_Title ;
      private String edtBR_Scheme_Chem_Regimens_Title ;
      private String edtBR_Medication_RXName_Title ;
      private String edtBR_Medication_RXDose_Title ;
      private String edtBR_Medication_RXUnit_Title ;
      private String subGrid_Header ;
      private String edtavSelect_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_scheme_medicationid_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_br_scheme_medicationidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_schemeid_Internalname ;
      private String edtavDdo_br_schemeidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medicationid_Internalname ;
      private String edtavDdo_br_medicationidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_scheme_chem_regimens_Internalname ;
      private String edtavDdo_br_scheme_chem_regimenstitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medication_rxname_Internalname ;
      private String edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medication_rxdose_Internalname ;
      private String edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medication_rxunit_Internalname ;
      private String edtavDdo_br_medication_rxunittitlecontrolidtoreplace_Internalname ;
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
      private String edtBR_Scheme_MedicationID_Internalname ;
      private String edtBR_SchemeID_Internalname ;
      private String edtBR_MedicationID_Internalname ;
      private String edtBR_Scheme_Chem_Regimens_Internalname ;
      private String edtBR_Medication_RXName_Internalname ;
      private String edtBR_Medication_RXDose_Internalname ;
      private String edtBR_Medication_RXUnit_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_12_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavSelect_Jsonclick ;
      private String ROClassString ;
      private String edtBR_Scheme_MedicationID_Jsonclick ;
      private String edtBR_SchemeID_Jsonclick ;
      private String edtBR_MedicationID_Jsonclick ;
      private String edtBR_Scheme_Chem_Regimens_Jsonclick ;
      private String edtBR_Medication_RXName_Jsonclick ;
      private String edtBR_Medication_RXDose_Jsonclick ;
      private String edtBR_Medication_RXUnit_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV11OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_br_scheme_medicationid_Includesortasc ;
      private bool Ddo_br_scheme_medicationid_Includesortdsc ;
      private bool Ddo_br_scheme_medicationid_Includefilter ;
      private bool Ddo_br_scheme_medicationid_Includedatalist ;
      private bool Ddo_br_schemeid_Includesortasc ;
      private bool Ddo_br_schemeid_Includesortdsc ;
      private bool Ddo_br_schemeid_Includefilter ;
      private bool Ddo_br_schemeid_Includedatalist ;
      private bool Ddo_br_medicationid_Includesortasc ;
      private bool Ddo_br_medicationid_Includesortdsc ;
      private bool Ddo_br_medicationid_Includefilter ;
      private bool Ddo_br_medicationid_Includedatalist ;
      private bool Ddo_br_scheme_chem_regimens_Includesortasc ;
      private bool Ddo_br_scheme_chem_regimens_Includesortdsc ;
      private bool Ddo_br_scheme_chem_regimens_Includefilter ;
      private bool Ddo_br_scheme_chem_regimens_Includedatalist ;
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
      private bool Ddo_br_medication_rxunit_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_12_Refreshing=false ;
      private bool n327BR_SchemeID ;
      private bool n119BR_MedicationID ;
      private bool n328BR_Scheme_Chem_Regimens ;
      private bool n121BR_Medication_RXName ;
      private bool n124BR_Medication_RXDose ;
      private bool n125BR_Medication_RXUnit ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool gx_refresh_fired ;
      private bool AV31Select_IsBlob ;
      private String AV13ddo_BR_Scheme_MedicationIDTitleControlIdToReplace ;
      private String AV15ddo_BR_SchemeIDTitleControlIdToReplace ;
      private String AV17ddo_BR_MedicationIDTitleControlIdToReplace ;
      private String AV19ddo_BR_Scheme_Chem_RegimensTitleControlIdToReplace ;
      private String AV21ddo_BR_Medication_RXNameTitleControlIdToReplace ;
      private String AV23ddo_BR_Medication_RXDoseTitleControlIdToReplace ;
      private String AV25ddo_BR_Medication_RXUnitTitleControlIdToReplace ;
      private String A328BR_Scheme_Chem_Regimens ;
      private String A121BR_Medication_RXName ;
      private String A125BR_Medication_RXUnit ;
      private String AV38Select_GXI ;
      private String AV31Select ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_scheme_medicationid ;
      private GXUserControl ucDdo_br_schemeid ;
      private GXUserControl ucDdo_br_medicationid ;
      private GXUserControl ucDdo_br_scheme_chem_regimens ;
      private GXUserControl ucDdo_br_medication_rxname ;
      private GXUserControl ucDdo_br_medication_rxdose ;
      private GXUserControl ucDdo_br_medication_rxunit ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private long aP0_InOutBR_Scheme_MedicationID ;
      private IDataStoreProvider pr_default ;
      private String[] H006O2_A125BR_Medication_RXUnit ;
      private bool[] H006O2_n125BR_Medication_RXUnit ;
      private decimal[] H006O2_A124BR_Medication_RXDose ;
      private bool[] H006O2_n124BR_Medication_RXDose ;
      private String[] H006O2_A121BR_Medication_RXName ;
      private bool[] H006O2_n121BR_Medication_RXName ;
      private String[] H006O2_A328BR_Scheme_Chem_Regimens ;
      private bool[] H006O2_n328BR_Scheme_Chem_Regimens ;
      private long[] H006O2_A119BR_MedicationID ;
      private bool[] H006O2_n119BR_MedicationID ;
      private long[] H006O2_A327BR_SchemeID ;
      private bool[] H006O2_n327BR_SchemeID ;
      private long[] H006O2_A332BR_Scheme_MedicationID ;
      private long[] H006O3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV12BR_Scheme_MedicationIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV14BR_SchemeIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV16BR_MedicationIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV18BR_Scheme_Chem_RegimensTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV20BR_Medication_RXNameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV22BR_Medication_RXDoseTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV24BR_Medication_RXUnitTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV26DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class br_scheme_medicationprompt__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H006O2( IGxContext context ,
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
         sSelectString = " T2.[BR_Medication_RXUnit], T2.[BR_Medication_RXDose], T2.[BR_Medication_RXName], T3.[BR_Scheme_Chem_Regimens], T1.[BR_MedicationID], T1.[BR_SchemeID], T1.[BR_Scheme_MedicationID]";
         sFromString = " FROM (([BR_Scheme_Medication] T1 WITH (NOLOCK) LEFT JOIN [BR_Medication] T2 WITH (NOLOCK) ON T2.[BR_MedicationID] = T1.[BR_MedicationID]) LEFT JOIN [BR_Scheme] T3 WITH (NOLOCK) ON T3.[BR_SchemeID] = T1.[BR_SchemeID])";
         sOrderString = "";
         if ( ( AV10OrderedBy == 1 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Scheme_MedicationID]";
         }
         else if ( ( AV10OrderedBy == 1 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Scheme_MedicationID] DESC";
         }
         else if ( ( AV10OrderedBy == 2 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_SchemeID]";
         }
         else if ( ( AV10OrderedBy == 2 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_SchemeID] DESC";
         }
         else if ( ( AV10OrderedBy == 3 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicationID]";
         }
         else if ( ( AV10OrderedBy == 3 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_MedicationID] DESC";
         }
         else if ( ( AV10OrderedBy == 4 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T3.[BR_Scheme_Chem_Regimens]";
         }
         else if ( ( AV10OrderedBy == 4 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T3.[BR_Scheme_Chem_Regimens] DESC";
         }
         else if ( ( AV10OrderedBy == 5 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T2.[BR_Medication_RXName]";
         }
         else if ( ( AV10OrderedBy == 5 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T2.[BR_Medication_RXName] DESC";
         }
         else if ( ( AV10OrderedBy == 6 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T2.[BR_Medication_RXDose]";
         }
         else if ( ( AV10OrderedBy == 6 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T2.[BR_Medication_RXDose] DESC";
         }
         else if ( ( AV10OrderedBy == 7 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T2.[BR_Medication_RXUnit]";
         }
         else if ( ( AV10OrderedBy == 7 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T2.[BR_Medication_RXUnit] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Scheme_MedicationID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H006O3( IGxContext context ,
                                             short AV10OrderedBy ,
                                             bool AV11OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM (([BR_Scheme_Medication] T1 WITH (NOLOCK) LEFT JOIN [BR_Medication] T3 WITH (NOLOCK) ON T3.[BR_MedicationID] = T1.[BR_MedicationID]) LEFT JOIN [BR_Scheme] T2 WITH (NOLOCK) ON T2.[BR_SchemeID] = T1.[BR_SchemeID])";
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
                     return conditional_H006O2(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
               case 1 :
                     return conditional_H006O3(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
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
          Object[] prmH006O2 ;
          prmH006O2 = new Object[] {
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH006O3 ;
          prmH006O3 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H006O2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH006O2,11,0,true,false )
             ,new CursorDef("H006O3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH006O3,1,0,true,false )
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
                ((decimal[]) buf[2])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((long[]) buf[8])[0] = rslt.getLong(5) ;
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
