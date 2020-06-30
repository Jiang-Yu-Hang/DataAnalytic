/*
               File: BR_Medication_SchemePrompt
        Description: 选择药物治疗化疗方案
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:44:43.24
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
   public class br_medication_schemeprompt : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public br_medication_schemeprompt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_medication_schemeprompt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_InOutBR_Medication_SchemeID )
      {
         this.AV8InOutBR_Medication_SchemeID = aP0_InOutBR_Medication_SchemeID;
         executePrivate();
         aP0_InOutBR_Medication_SchemeID=this.AV8InOutBR_Medication_SchemeID;
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
               AV14ddo_BR_Medication_SchemeIDTitleControlIdToReplace = GetNextPar( );
               AV16ddo_BR_MedicationIDTitleControlIdToReplace = GetNextPar( );
               AV33ddo_BR_Medication_Chem_NameTitleControlIdToReplace = GetNextPar( );
               AV35ddo_BR_Medication_Chem_CycleTitleControlIdToReplace = GetNextPar( );
               AV37ddo_BR_Medication_Chem_LineTitleControlIdToReplace = GetNextPar( );
               AV41ddo_BR_Medication_Chem_DetailTitleControlIdToReplace = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Medication_SchemeIDTitleControlIdToReplace, AV16ddo_BR_MedicationIDTitleControlIdToReplace, AV33ddo_BR_Medication_Chem_NameTitleControlIdToReplace, AV35ddo_BR_Medication_Chem_CycleTitleControlIdToReplace, AV37ddo_BR_Medication_Chem_LineTitleControlIdToReplace, AV41ddo_BR_Medication_Chem_DetailTitleControlIdToReplace) ;
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
               AV8InOutBR_Medication_SchemeID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_Medication_SchemeID), 18, 0)));
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
            PA5R2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV44Pgmname = "BR_Medication_SchemePrompt";
               context.Gx_err = 0;
               WS5R2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE5R2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202279444336", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_medication_schemeprompt.aspx") + "?" + UrlEncode("" +AV8InOutBR_Medication_SchemeID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV27GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV29GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV28GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV25DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV25DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA", AV13BR_Medication_SchemeIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA", AV13BR_Medication_SchemeIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATIONIDTITLEFILTERDATA", AV15BR_MedicationIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATIONIDTITLEFILTERDATA", AV15BR_MedicationIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_CHEM_NAMETITLEFILTERDATA", AV32BR_Medication_Chem_NameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_CHEM_NAMETITLEFILTERDATA", AV32BR_Medication_Chem_NameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_CHEM_CYCLETITLEFILTERDATA", AV34BR_Medication_Chem_CycleTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_CHEM_CYCLETITLEFILTERDATA", AV34BR_Medication_Chem_CycleTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_CHEM_LINETITLEFILTERDATA", AV36BR_Medication_Chem_LineTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_CHEM_LINETITLEFILTERDATA", AV36BR_Medication_Chem_LineTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_CHEM_DETAILTITLEFILTERDATA", AV40BR_Medication_Chem_DetailTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_CHEM_DETAILTITLEFILTERDATA", AV40BR_Medication_Chem_DetailTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vINOUTBR_MEDICATION_SCHEMEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8InOutBR_Medication_SchemeID), 18, 0, ".", "")));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Caption", StringUtil.RTrim( Ddo_br_medication_schemeid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Tooltip", StringUtil.RTrim( Ddo_br_medication_schemeid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Cls", StringUtil.RTrim( Ddo_br_medication_schemeid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_schemeid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_schemeid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_schemeid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_schemeid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_schemeid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_schemeid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_schemeid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Sortasc", StringUtil.RTrim( Ddo_br_medication_schemeid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Sortdsc", StringUtil.RTrim( Ddo_br_medication_schemeid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_schemeid_Searchbuttontext));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Caption", StringUtil.RTrim( Ddo_br_medication_chem_name_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Tooltip", StringUtil.RTrim( Ddo_br_medication_chem_name_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Cls", StringUtil.RTrim( Ddo_br_medication_chem_name_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_chem_name_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_chem_name_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_chem_name_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_chem_name_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_chem_name_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_chem_name_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_chem_name_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Sortasc", StringUtil.RTrim( Ddo_br_medication_chem_name_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Sortdsc", StringUtil.RTrim( Ddo_br_medication_chem_name_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_chem_name_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Caption", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Tooltip", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Cls", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_chem_cycle_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_chem_cycle_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_chem_cycle_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_chem_cycle_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Sortasc", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Sortdsc", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Caption", StringUtil.RTrim( Ddo_br_medication_chem_line_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Tooltip", StringUtil.RTrim( Ddo_br_medication_chem_line_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Cls", StringUtil.RTrim( Ddo_br_medication_chem_line_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_chem_line_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_chem_line_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_chem_line_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_chem_line_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_chem_line_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_chem_line_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_chem_line_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Sortasc", StringUtil.RTrim( Ddo_br_medication_chem_line_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Sortdsc", StringUtil.RTrim( Ddo_br_medication_chem_line_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_chem_line_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Caption", StringUtil.RTrim( Ddo_br_medication_chem_detail_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Tooltip", StringUtil.RTrim( Ddo_br_medication_chem_detail_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Cls", StringUtil.RTrim( Ddo_br_medication_chem_detail_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_chem_detail_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_chem_detail_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_chem_detail_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_chem_detail_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_chem_detail_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_chem_detail_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_chem_detail_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Sortasc", StringUtil.RTrim( Ddo_br_medication_chem_detail_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Sortdsc", StringUtil.RTrim( Ddo_br_medication_chem_detail_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_chem_detail_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_schemeid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Activeeventkey", StringUtil.RTrim( Ddo_br_medicationid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_chem_name_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_chem_line_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_chem_detail_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_schemeid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATIONID_Activeeventkey", StringUtil.RTrim( Ddo_br_medicationid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_NAME_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_chem_name_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_CYCLE_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_chem_cycle_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_LINE_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_chem_line_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_CHEM_DETAIL_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_chem_detail_Activeeventkey));
      }

      protected void RenderHtmlCloseForm5R2( )
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
         return "BR_Medication_SchemePrompt" ;
      }

      public override String GetPgmdesc( )
      {
         return "选择药物治疗化疗方案" ;
      }

      protected void WB5R0( )
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
               if ( edtBR_Medication_SchemeID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Medication_SchemeID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Medication_SchemeID_Title) ;
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
               if ( edtBR_Medication_Chem_Name_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Medication_Chem_Name_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Medication_Chem_Name_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Medication_Chem_Cycle_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Medication_Chem_Cycle_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Medication_Chem_Cycle_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Medication_Chem_Line_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Medication_Chem_Line_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Medication_Chem_Line_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Medication_Chem_Detail_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Medication_Chem_Detail_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Medication_Chem_Detail_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV30Select));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavSelect_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A296BR_Medication_SchemeID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Medication_SchemeID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Medication_SchemeID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A119BR_MedicationID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicationID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicationID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A305BR_Medication_Chem_Name);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Medication_Chem_Name_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Medication_Chem_Name_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A306BR_Medication_Chem_Cycle, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Medication_Chem_Cycle_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Medication_Chem_Cycle_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A307BR_Medication_Chem_Line);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Medication_Chem_Line_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Medication_Chem_Line_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A313BR_Medication_Chem_Detail);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Medication_Chem_Detail_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Medication_Chem_Detail_Titleformat), 4, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV27GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV29GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV28GridPageSize);
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
            ucDdo_br_medication_schemeid.SetProperty("Caption", Ddo_br_medication_schemeid_Caption);
            ucDdo_br_medication_schemeid.SetProperty("Tooltip", Ddo_br_medication_schemeid_Tooltip);
            ucDdo_br_medication_schemeid.SetProperty("Cls", Ddo_br_medication_schemeid_Cls);
            ucDdo_br_medication_schemeid.SetProperty("DropDownOptionsType", Ddo_br_medication_schemeid_Dropdownoptionstype);
            ucDdo_br_medication_schemeid.SetProperty("IncludeSortASC", Ddo_br_medication_schemeid_Includesortasc);
            ucDdo_br_medication_schemeid.SetProperty("IncludeSortDSC", Ddo_br_medication_schemeid_Includesortdsc);
            ucDdo_br_medication_schemeid.SetProperty("IncludeFilter", Ddo_br_medication_schemeid_Includefilter);
            ucDdo_br_medication_schemeid.SetProperty("IncludeDataList", Ddo_br_medication_schemeid_Includedatalist);
            ucDdo_br_medication_schemeid.SetProperty("SortASC", Ddo_br_medication_schemeid_Sortasc);
            ucDdo_br_medication_schemeid.SetProperty("SortDSC", Ddo_br_medication_schemeid_Sortdsc);
            ucDdo_br_medication_schemeid.SetProperty("SearchButtonText", Ddo_br_medication_schemeid_Searchbuttontext);
            ucDdo_br_medication_schemeid.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_br_medication_schemeid.SetProperty("DropDownOptionsData", AV13BR_Medication_SchemeIDTitleFilterData);
            ucDdo_br_medication_schemeid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_schemeid_Internalname, "DDO_BR_MEDICATION_SCHEMEIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Internalname, AV14ddo_BR_Medication_SchemeIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,28);\"", 0, edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Medication_SchemePrompt.htm");
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
            ucDdo_br_medicationid.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_br_medicationid.SetProperty("DropDownOptionsData", AV15BR_MedicationIDTitleFilterData);
            ucDdo_br_medicationid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicationid_Internalname, "DDO_BR_MEDICATIONIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicationidtitlecontrolidtoreplace_Internalname, AV16ddo_BR_MedicationIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,30);\"", 0, edtavDdo_br_medicationidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Medication_SchemePrompt.htm");
            /* User Defined Control */
            ucDdo_br_medication_chem_name.SetProperty("Caption", Ddo_br_medication_chem_name_Caption);
            ucDdo_br_medication_chem_name.SetProperty("Tooltip", Ddo_br_medication_chem_name_Tooltip);
            ucDdo_br_medication_chem_name.SetProperty("Cls", Ddo_br_medication_chem_name_Cls);
            ucDdo_br_medication_chem_name.SetProperty("DropDownOptionsType", Ddo_br_medication_chem_name_Dropdownoptionstype);
            ucDdo_br_medication_chem_name.SetProperty("IncludeSortASC", Ddo_br_medication_chem_name_Includesortasc);
            ucDdo_br_medication_chem_name.SetProperty("IncludeSortDSC", Ddo_br_medication_chem_name_Includesortdsc);
            ucDdo_br_medication_chem_name.SetProperty("IncludeFilter", Ddo_br_medication_chem_name_Includefilter);
            ucDdo_br_medication_chem_name.SetProperty("IncludeDataList", Ddo_br_medication_chem_name_Includedatalist);
            ucDdo_br_medication_chem_name.SetProperty("SortASC", Ddo_br_medication_chem_name_Sortasc);
            ucDdo_br_medication_chem_name.SetProperty("SortDSC", Ddo_br_medication_chem_name_Sortdsc);
            ucDdo_br_medication_chem_name.SetProperty("SearchButtonText", Ddo_br_medication_chem_name_Searchbuttontext);
            ucDdo_br_medication_chem_name.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_br_medication_chem_name.SetProperty("DropDownOptionsData", AV32BR_Medication_Chem_NameTitleFilterData);
            ucDdo_br_medication_chem_name.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_chem_name_Internalname, "DDO_BR_MEDICATION_CHEM_NAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_chem_nametitlecontrolidtoreplace_Internalname, AV33ddo_BR_Medication_Chem_NameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,32);\"", 0, edtavDdo_br_medication_chem_nametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Medication_SchemePrompt.htm");
            /* User Defined Control */
            ucDdo_br_medication_chem_cycle.SetProperty("Caption", Ddo_br_medication_chem_cycle_Caption);
            ucDdo_br_medication_chem_cycle.SetProperty("Tooltip", Ddo_br_medication_chem_cycle_Tooltip);
            ucDdo_br_medication_chem_cycle.SetProperty("Cls", Ddo_br_medication_chem_cycle_Cls);
            ucDdo_br_medication_chem_cycle.SetProperty("DropDownOptionsType", Ddo_br_medication_chem_cycle_Dropdownoptionstype);
            ucDdo_br_medication_chem_cycle.SetProperty("IncludeSortASC", Ddo_br_medication_chem_cycle_Includesortasc);
            ucDdo_br_medication_chem_cycle.SetProperty("IncludeSortDSC", Ddo_br_medication_chem_cycle_Includesortdsc);
            ucDdo_br_medication_chem_cycle.SetProperty("IncludeFilter", Ddo_br_medication_chem_cycle_Includefilter);
            ucDdo_br_medication_chem_cycle.SetProperty("IncludeDataList", Ddo_br_medication_chem_cycle_Includedatalist);
            ucDdo_br_medication_chem_cycle.SetProperty("SortASC", Ddo_br_medication_chem_cycle_Sortasc);
            ucDdo_br_medication_chem_cycle.SetProperty("SortDSC", Ddo_br_medication_chem_cycle_Sortdsc);
            ucDdo_br_medication_chem_cycle.SetProperty("SearchButtonText", Ddo_br_medication_chem_cycle_Searchbuttontext);
            ucDdo_br_medication_chem_cycle.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_br_medication_chem_cycle.SetProperty("DropDownOptionsData", AV34BR_Medication_Chem_CycleTitleFilterData);
            ucDdo_br_medication_chem_cycle.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_chem_cycle_Internalname, "DDO_BR_MEDICATION_CHEM_CYCLEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_chem_cycletitlecontrolidtoreplace_Internalname, AV35ddo_BR_Medication_Chem_CycleTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", 0, edtavDdo_br_medication_chem_cycletitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Medication_SchemePrompt.htm");
            /* User Defined Control */
            ucDdo_br_medication_chem_line.SetProperty("Caption", Ddo_br_medication_chem_line_Caption);
            ucDdo_br_medication_chem_line.SetProperty("Tooltip", Ddo_br_medication_chem_line_Tooltip);
            ucDdo_br_medication_chem_line.SetProperty("Cls", Ddo_br_medication_chem_line_Cls);
            ucDdo_br_medication_chem_line.SetProperty("DropDownOptionsType", Ddo_br_medication_chem_line_Dropdownoptionstype);
            ucDdo_br_medication_chem_line.SetProperty("IncludeSortASC", Ddo_br_medication_chem_line_Includesortasc);
            ucDdo_br_medication_chem_line.SetProperty("IncludeSortDSC", Ddo_br_medication_chem_line_Includesortdsc);
            ucDdo_br_medication_chem_line.SetProperty("IncludeFilter", Ddo_br_medication_chem_line_Includefilter);
            ucDdo_br_medication_chem_line.SetProperty("IncludeDataList", Ddo_br_medication_chem_line_Includedatalist);
            ucDdo_br_medication_chem_line.SetProperty("SortASC", Ddo_br_medication_chem_line_Sortasc);
            ucDdo_br_medication_chem_line.SetProperty("SortDSC", Ddo_br_medication_chem_line_Sortdsc);
            ucDdo_br_medication_chem_line.SetProperty("SearchButtonText", Ddo_br_medication_chem_line_Searchbuttontext);
            ucDdo_br_medication_chem_line.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_br_medication_chem_line.SetProperty("DropDownOptionsData", AV36BR_Medication_Chem_LineTitleFilterData);
            ucDdo_br_medication_chem_line.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_chem_line_Internalname, "DDO_BR_MEDICATION_CHEM_LINEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_chem_linetitlecontrolidtoreplace_Internalname, AV37ddo_BR_Medication_Chem_LineTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,36);\"", 0, edtavDdo_br_medication_chem_linetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Medication_SchemePrompt.htm");
            /* User Defined Control */
            ucDdo_br_medication_chem_detail.SetProperty("Caption", Ddo_br_medication_chem_detail_Caption);
            ucDdo_br_medication_chem_detail.SetProperty("Tooltip", Ddo_br_medication_chem_detail_Tooltip);
            ucDdo_br_medication_chem_detail.SetProperty("Cls", Ddo_br_medication_chem_detail_Cls);
            ucDdo_br_medication_chem_detail.SetProperty("DropDownOptionsType", Ddo_br_medication_chem_detail_Dropdownoptionstype);
            ucDdo_br_medication_chem_detail.SetProperty("IncludeSortASC", Ddo_br_medication_chem_detail_Includesortasc);
            ucDdo_br_medication_chem_detail.SetProperty("IncludeSortDSC", Ddo_br_medication_chem_detail_Includesortdsc);
            ucDdo_br_medication_chem_detail.SetProperty("IncludeFilter", Ddo_br_medication_chem_detail_Includefilter);
            ucDdo_br_medication_chem_detail.SetProperty("IncludeDataList", Ddo_br_medication_chem_detail_Includedatalist);
            ucDdo_br_medication_chem_detail.SetProperty("SortASC", Ddo_br_medication_chem_detail_Sortasc);
            ucDdo_br_medication_chem_detail.SetProperty("SortDSC", Ddo_br_medication_chem_detail_Sortdsc);
            ucDdo_br_medication_chem_detail.SetProperty("SearchButtonText", Ddo_br_medication_chem_detail_Searchbuttontext);
            ucDdo_br_medication_chem_detail.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_br_medication_chem_detail.SetProperty("DropDownOptionsData", AV40BR_Medication_Chem_DetailTitleFilterData);
            ucDdo_br_medication_chem_detail.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_chem_detail_Internalname, "DDO_BR_MEDICATION_CHEM_DETAILContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_chem_detailtitlecontrolidtoreplace_Internalname, AV41ddo_BR_Medication_Chem_DetailTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", 0, edtavDdo_br_medication_chem_detailtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Medication_SchemePrompt.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,40);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Medication_SchemePrompt.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV12OrderedDsc), StringUtil.BoolToStr( AV12OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,41);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_Medication_SchemePrompt.htm");
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

      protected void START5R2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "选择药物治疗化疗方案", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP5R0( ) ;
      }

      protected void WS5R2( )
      {
         START5R2( ) ;
         EVT5R2( ) ;
      }

      protected void EVT5R2( )
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
                           E115R2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E125R2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_SCHEMEID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E135R2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATIONID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E145R2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_CHEM_NAME.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E155R2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_CHEM_CYCLE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E165R2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_CHEM_LINE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E175R2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_CHEM_DETAIL.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E185R2 ();
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
                           AV30Select = cgiGet( edtavSelect_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV30Select)) ? AV45Select_GXI : context.convertURL( context.PathToRelativeUrl( AV30Select))), !bGXsfl_12_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "SrcSet", context.GetImageSrcSet( AV30Select), true);
                           A296BR_Medication_SchemeID = (long)(context.localUtil.CToN( cgiGet( edtBR_Medication_SchemeID_Internalname), ".", ","));
                           A119BR_MedicationID = (long)(context.localUtil.CToN( cgiGet( edtBR_MedicationID_Internalname), ".", ","));
                           n119BR_MedicationID = false;
                           A305BR_Medication_Chem_Name = cgiGet( edtBR_Medication_Chem_Name_Internalname);
                           n305BR_Medication_Chem_Name = false;
                           A306BR_Medication_Chem_Cycle = context.localUtil.CToN( cgiGet( edtBR_Medication_Chem_Cycle_Internalname), ".", ",");
                           n306BR_Medication_Chem_Cycle = false;
                           A307BR_Medication_Chem_Line = cgiGet( edtBR_Medication_Chem_Line_Internalname);
                           n307BR_Medication_Chem_Line = false;
                           A313BR_Medication_Chem_Detail = cgiGet( edtBR_Medication_Chem_Detail_Internalname);
                           n313BR_Medication_Chem_Detail = false;
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E195R2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E205R2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E215R2 ();
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
                                       E225R2 ();
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

      protected void WE5R2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm5R2( ) ;
            }
         }
      }

      protected void PA5R2( )
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
               GX_FocusControl = edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Internalname;
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
                                       String AV14ddo_BR_Medication_SchemeIDTitleControlIdToReplace ,
                                       String AV16ddo_BR_MedicationIDTitleControlIdToReplace ,
                                       String AV33ddo_BR_Medication_Chem_NameTitleControlIdToReplace ,
                                       String AV35ddo_BR_Medication_Chem_CycleTitleControlIdToReplace ,
                                       String AV37ddo_BR_Medication_Chem_LineTitleControlIdToReplace ,
                                       String AV41ddo_BR_Medication_Chem_DetailTitleControlIdToReplace )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF5R2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_MEDICATION_SCHEMEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A296BR_Medication_SchemeID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_MEDICATION_SCHEMEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A296BR_Medication_SchemeID), 18, 0, ".", "")));
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
         RF5R2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV44Pgmname = "BR_Medication_SchemePrompt";
         context.Gx_err = 0;
      }

      protected void RF5R2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 12;
         /* Execute user event: Refresh */
         E205R2 ();
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
            /* Using cursor H005R2 */
            pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_12_idx = 1;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A313BR_Medication_Chem_Detail = H005R2_A313BR_Medication_Chem_Detail[0];
               n313BR_Medication_Chem_Detail = H005R2_n313BR_Medication_Chem_Detail[0];
               A307BR_Medication_Chem_Line = H005R2_A307BR_Medication_Chem_Line[0];
               n307BR_Medication_Chem_Line = H005R2_n307BR_Medication_Chem_Line[0];
               A306BR_Medication_Chem_Cycle = H005R2_A306BR_Medication_Chem_Cycle[0];
               n306BR_Medication_Chem_Cycle = H005R2_n306BR_Medication_Chem_Cycle[0];
               A305BR_Medication_Chem_Name = H005R2_A305BR_Medication_Chem_Name[0];
               n305BR_Medication_Chem_Name = H005R2_n305BR_Medication_Chem_Name[0];
               A119BR_MedicationID = H005R2_A119BR_MedicationID[0];
               n119BR_MedicationID = H005R2_n119BR_MedicationID[0];
               A296BR_Medication_SchemeID = H005R2_A296BR_Medication_SchemeID[0];
               E215R2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 12;
            WB5R0( ) ;
         }
         bGXsfl_12_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes5R2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_MEDICATION_SCHEMEID"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, context.localUtil.Format( (decimal)(A296BR_Medication_SchemeID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         /* Using cursor H005R3 */
         pr_default.execute(1);
         GRID_nRecordCount = H005R3_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Medication_SchemeIDTitleControlIdToReplace, AV16ddo_BR_MedicationIDTitleControlIdToReplace, AV33ddo_BR_Medication_Chem_NameTitleControlIdToReplace, AV35ddo_BR_Medication_Chem_CycleTitleControlIdToReplace, AV37ddo_BR_Medication_Chem_LineTitleControlIdToReplace, AV41ddo_BR_Medication_Chem_DetailTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Medication_SchemeIDTitleControlIdToReplace, AV16ddo_BR_MedicationIDTitleControlIdToReplace, AV33ddo_BR_Medication_Chem_NameTitleControlIdToReplace, AV35ddo_BR_Medication_Chem_CycleTitleControlIdToReplace, AV37ddo_BR_Medication_Chem_LineTitleControlIdToReplace, AV41ddo_BR_Medication_Chem_DetailTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Medication_SchemeIDTitleControlIdToReplace, AV16ddo_BR_MedicationIDTitleControlIdToReplace, AV33ddo_BR_Medication_Chem_NameTitleControlIdToReplace, AV35ddo_BR_Medication_Chem_CycleTitleControlIdToReplace, AV37ddo_BR_Medication_Chem_LineTitleControlIdToReplace, AV41ddo_BR_Medication_Chem_DetailTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Medication_SchemeIDTitleControlIdToReplace, AV16ddo_BR_MedicationIDTitleControlIdToReplace, AV33ddo_BR_Medication_Chem_NameTitleControlIdToReplace, AV35ddo_BR_Medication_Chem_CycleTitleControlIdToReplace, AV37ddo_BR_Medication_Chem_LineTitleControlIdToReplace, AV41ddo_BR_Medication_Chem_DetailTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Medication_SchemeIDTitleControlIdToReplace, AV16ddo_BR_MedicationIDTitleControlIdToReplace, AV33ddo_BR_Medication_Chem_NameTitleControlIdToReplace, AV35ddo_BR_Medication_Chem_CycleTitleControlIdToReplace, AV37ddo_BR_Medication_Chem_LineTitleControlIdToReplace, AV41ddo_BR_Medication_Chem_DetailTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP5R0( )
      {
         /* Before Start, stand alone formulas. */
         AV44Pgmname = "BR_Medication_SchemePrompt";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E195R2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV25DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA"), AV13BR_Medication_SchemeIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATIONIDTITLEFILTERDATA"), AV15BR_MedicationIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_CHEM_NAMETITLEFILTERDATA"), AV32BR_Medication_Chem_NameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_CHEM_CYCLETITLEFILTERDATA"), AV34BR_Medication_Chem_CycleTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_CHEM_LINETITLEFILTERDATA"), AV36BR_Medication_Chem_LineTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_CHEM_DETAILTITLEFILTERDATA"), AV40BR_Medication_Chem_DetailTitleFilterData);
            /* Read variables values. */
            AV14ddo_BR_Medication_SchemeIDTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_BR_Medication_SchemeIDTitleControlIdToReplace", AV14ddo_BR_Medication_SchemeIDTitleControlIdToReplace);
            AV16ddo_BR_MedicationIDTitleControlIdToReplace = cgiGet( edtavDdo_br_medicationidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_BR_MedicationIDTitleControlIdToReplace", AV16ddo_BR_MedicationIDTitleControlIdToReplace);
            AV33ddo_BR_Medication_Chem_NameTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_chem_nametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33ddo_BR_Medication_Chem_NameTitleControlIdToReplace", AV33ddo_BR_Medication_Chem_NameTitleControlIdToReplace);
            AV35ddo_BR_Medication_Chem_CycleTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_chem_cycletitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_BR_Medication_Chem_CycleTitleControlIdToReplace", AV35ddo_BR_Medication_Chem_CycleTitleControlIdToReplace);
            AV37ddo_BR_Medication_Chem_LineTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_chem_linetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37ddo_BR_Medication_Chem_LineTitleControlIdToReplace", AV37ddo_BR_Medication_Chem_LineTitleControlIdToReplace);
            AV41ddo_BR_Medication_Chem_DetailTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_chem_detailtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41ddo_BR_Medication_Chem_DetailTitleControlIdToReplace", AV41ddo_BR_Medication_Chem_DetailTitleControlIdToReplace);
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
            AV27GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV29GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV28GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_medication_schemeid_Caption = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Caption");
            Ddo_br_medication_schemeid_Tooltip = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Tooltip");
            Ddo_br_medication_schemeid_Cls = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Cls");
            Ddo_br_medication_schemeid_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Dropdownoptionstype");
            Ddo_br_medication_schemeid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Titlecontrolidtoreplace");
            Ddo_br_medication_schemeid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Includesortasc"));
            Ddo_br_medication_schemeid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Includesortdsc"));
            Ddo_br_medication_schemeid_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Sortedstatus");
            Ddo_br_medication_schemeid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Includefilter"));
            Ddo_br_medication_schemeid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Includedatalist"));
            Ddo_br_medication_schemeid_Sortasc = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Sortasc");
            Ddo_br_medication_schemeid_Sortdsc = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Sortdsc");
            Ddo_br_medication_schemeid_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Searchbuttontext");
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
            Ddo_br_medication_chem_name_Caption = cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Caption");
            Ddo_br_medication_chem_name_Tooltip = cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Tooltip");
            Ddo_br_medication_chem_name_Cls = cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Cls");
            Ddo_br_medication_chem_name_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Dropdownoptionstype");
            Ddo_br_medication_chem_name_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Titlecontrolidtoreplace");
            Ddo_br_medication_chem_name_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Includesortasc"));
            Ddo_br_medication_chem_name_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Includesortdsc"));
            Ddo_br_medication_chem_name_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Sortedstatus");
            Ddo_br_medication_chem_name_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Includefilter"));
            Ddo_br_medication_chem_name_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Includedatalist"));
            Ddo_br_medication_chem_name_Sortasc = cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Sortasc");
            Ddo_br_medication_chem_name_Sortdsc = cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Sortdsc");
            Ddo_br_medication_chem_name_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Searchbuttontext");
            Ddo_br_medication_chem_cycle_Caption = cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Caption");
            Ddo_br_medication_chem_cycle_Tooltip = cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Tooltip");
            Ddo_br_medication_chem_cycle_Cls = cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Cls");
            Ddo_br_medication_chem_cycle_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Dropdownoptionstype");
            Ddo_br_medication_chem_cycle_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Titlecontrolidtoreplace");
            Ddo_br_medication_chem_cycle_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Includesortasc"));
            Ddo_br_medication_chem_cycle_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Includesortdsc"));
            Ddo_br_medication_chem_cycle_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Sortedstatus");
            Ddo_br_medication_chem_cycle_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Includefilter"));
            Ddo_br_medication_chem_cycle_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Includedatalist"));
            Ddo_br_medication_chem_cycle_Sortasc = cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Sortasc");
            Ddo_br_medication_chem_cycle_Sortdsc = cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Sortdsc");
            Ddo_br_medication_chem_cycle_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Searchbuttontext");
            Ddo_br_medication_chem_line_Caption = cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Caption");
            Ddo_br_medication_chem_line_Tooltip = cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Tooltip");
            Ddo_br_medication_chem_line_Cls = cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Cls");
            Ddo_br_medication_chem_line_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Dropdownoptionstype");
            Ddo_br_medication_chem_line_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Titlecontrolidtoreplace");
            Ddo_br_medication_chem_line_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Includesortasc"));
            Ddo_br_medication_chem_line_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Includesortdsc"));
            Ddo_br_medication_chem_line_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Sortedstatus");
            Ddo_br_medication_chem_line_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Includefilter"));
            Ddo_br_medication_chem_line_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Includedatalist"));
            Ddo_br_medication_chem_line_Sortasc = cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Sortasc");
            Ddo_br_medication_chem_line_Sortdsc = cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Sortdsc");
            Ddo_br_medication_chem_line_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Searchbuttontext");
            Ddo_br_medication_chem_detail_Caption = cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Caption");
            Ddo_br_medication_chem_detail_Tooltip = cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Tooltip");
            Ddo_br_medication_chem_detail_Cls = cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Cls");
            Ddo_br_medication_chem_detail_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Dropdownoptionstype");
            Ddo_br_medication_chem_detail_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Titlecontrolidtoreplace");
            Ddo_br_medication_chem_detail_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Includesortasc"));
            Ddo_br_medication_chem_detail_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Includesortdsc"));
            Ddo_br_medication_chem_detail_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Sortedstatus");
            Ddo_br_medication_chem_detail_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Includefilter"));
            Ddo_br_medication_chem_detail_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Includedatalist"));
            Ddo_br_medication_chem_detail_Sortasc = cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Sortasc");
            Ddo_br_medication_chem_detail_Sortdsc = cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Sortdsc");
            Ddo_br_medication_chem_detail_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_medication_schemeid_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Activeeventkey");
            Ddo_br_medicationid_Activeeventkey = cgiGet( "DDO_BR_MEDICATIONID_Activeeventkey");
            Ddo_br_medication_chem_name_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_CHEM_NAME_Activeeventkey");
            Ddo_br_medication_chem_cycle_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_CHEM_CYCLE_Activeeventkey");
            Ddo_br_medication_chem_line_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_CHEM_LINE_Activeeventkey");
            Ddo_br_medication_chem_detail_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_CHEM_DETAIL_Activeeventkey");
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
         E195R2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E195R2( )
      {
         /* Start Routine */
         GXt_boolean1 = AV5IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Medication_Scheme", out  GXt_boolean1) ;
         AV5IsAuthorized = GXt_boolean1;
         if ( ! AV5IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV44Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         divTablemain_Height = 493;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTablemain_Internalname, "Height", StringUtil.LTrim( StringUtil.Str( (decimal)(divTablemain_Height), 9, 0)), true);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_br_medication_schemeid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_SchemeID";
         ucDdo_br_medication_schemeid.SendProperty(context, "", false, Ddo_br_medication_schemeid_Internalname, "TitleControlIdToReplace", Ddo_br_medication_schemeid_Titlecontrolidtoreplace);
         AV14ddo_BR_Medication_SchemeIDTitleControlIdToReplace = Ddo_br_medication_schemeid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_BR_Medication_SchemeIDTitleControlIdToReplace", AV14ddo_BR_Medication_SchemeIDTitleControlIdToReplace);
         edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicationid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicationID";
         ucDdo_br_medicationid.SendProperty(context, "", false, Ddo_br_medicationid_Internalname, "TitleControlIdToReplace", Ddo_br_medicationid_Titlecontrolidtoreplace);
         AV16ddo_BR_MedicationIDTitleControlIdToReplace = Ddo_br_medicationid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_BR_MedicationIDTitleControlIdToReplace", AV16ddo_BR_MedicationIDTitleControlIdToReplace);
         edtavDdo_br_medicationidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medicationidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicationidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_chem_name_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_Chem_Name";
         ucDdo_br_medication_chem_name.SendProperty(context, "", false, Ddo_br_medication_chem_name_Internalname, "TitleControlIdToReplace", Ddo_br_medication_chem_name_Titlecontrolidtoreplace);
         AV33ddo_BR_Medication_Chem_NameTitleControlIdToReplace = Ddo_br_medication_chem_name_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33ddo_BR_Medication_Chem_NameTitleControlIdToReplace", AV33ddo_BR_Medication_Chem_NameTitleControlIdToReplace);
         edtavDdo_br_medication_chem_nametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_chem_nametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_chem_nametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_chem_cycle_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_Chem_Cycle";
         ucDdo_br_medication_chem_cycle.SendProperty(context, "", false, Ddo_br_medication_chem_cycle_Internalname, "TitleControlIdToReplace", Ddo_br_medication_chem_cycle_Titlecontrolidtoreplace);
         AV35ddo_BR_Medication_Chem_CycleTitleControlIdToReplace = Ddo_br_medication_chem_cycle_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_BR_Medication_Chem_CycleTitleControlIdToReplace", AV35ddo_BR_Medication_Chem_CycleTitleControlIdToReplace);
         edtavDdo_br_medication_chem_cycletitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_chem_cycletitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_chem_cycletitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_chem_line_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_Chem_Line";
         ucDdo_br_medication_chem_line.SendProperty(context, "", false, Ddo_br_medication_chem_line_Internalname, "TitleControlIdToReplace", Ddo_br_medication_chem_line_Titlecontrolidtoreplace);
         AV37ddo_BR_Medication_Chem_LineTitleControlIdToReplace = Ddo_br_medication_chem_line_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37ddo_BR_Medication_Chem_LineTitleControlIdToReplace", AV37ddo_BR_Medication_Chem_LineTitleControlIdToReplace);
         edtavDdo_br_medication_chem_linetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_chem_linetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_chem_linetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_chem_detail_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_Chem_Detail";
         ucDdo_br_medication_chem_detail.SendProperty(context, "", false, Ddo_br_medication_chem_detail_Internalname, "TitleControlIdToReplace", Ddo_br_medication_chem_detail_Titlecontrolidtoreplace);
         AV41ddo_BR_Medication_Chem_DetailTitleControlIdToReplace = Ddo_br_medication_chem_detail_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41ddo_BR_Medication_Chem_DetailTitleControlIdToReplace", AV41ddo_BR_Medication_Chem_DetailTitleControlIdToReplace);
         edtavDdo_br_medication_chem_detailtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_chem_detailtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_chem_detailtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "选择药物治疗化疗方案";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV25DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV25DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E205R2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV13BR_Medication_SchemeIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15BR_MedicationIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32BR_Medication_Chem_NameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV34BR_Medication_Chem_CycleTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV36BR_Medication_Chem_LineTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV40BR_Medication_Chem_DetailTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         edtBR_Medication_SchemeID_Titleformat = 2;
         edtBR_Medication_SchemeID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "药物治疗化疗方案主键", AV14ddo_BR_Medication_SchemeIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_SchemeID_Internalname, "Title", edtBR_Medication_SchemeID_Title, !bGXsfl_12_Refreshing);
         edtBR_MedicationID_Titleformat = 2;
         edtBR_MedicationID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "药物治疗主键", AV16ddo_BR_MedicationIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicationID_Internalname, "Title", edtBR_MedicationID_Title, !bGXsfl_12_Refreshing);
         edtBR_Medication_Chem_Name_Titleformat = 2;
         edtBR_Medication_Chem_Name_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "化疗方案名称", AV33ddo_BR_Medication_Chem_NameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_Chem_Name_Internalname, "Title", edtBR_Medication_Chem_Name_Title, !bGXsfl_12_Refreshing);
         edtBR_Medication_Chem_Cycle_Titleformat = 2;
         edtBR_Medication_Chem_Cycle_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "周期", AV35ddo_BR_Medication_Chem_CycleTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_Chem_Cycle_Internalname, "Title", edtBR_Medication_Chem_Cycle_Title, !bGXsfl_12_Refreshing);
         edtBR_Medication_Chem_Line_Titleformat = 2;
         edtBR_Medication_Chem_Line_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "线级", AV37ddo_BR_Medication_Chem_LineTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_Chem_Line_Internalname, "Title", edtBR_Medication_Chem_Line_Title, !bGXsfl_12_Refreshing);
         edtBR_Medication_Chem_Detail_Titleformat = 2;
         edtBR_Medication_Chem_Detail_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "描述化疗方案", AV41ddo_BR_Medication_Chem_DetailTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_Chem_Detail_Internalname, "Title", edtBR_Medication_Chem_Detail_Title, !bGXsfl_12_Refreshing);
         AV27GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV27GridCurrentPage), 10, 0)));
         AV28GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28GridPageSize), 10, 0)));
         AV29GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Medication_SchemeIDTitleFilterData", AV13BR_Medication_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_MedicationIDTitleFilterData", AV15BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Medication_Chem_NameTitleFilterData", AV32BR_Medication_Chem_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Medication_Chem_CycleTitleFilterData", AV34BR_Medication_Chem_CycleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Medication_Chem_LineTitleFilterData", AV36BR_Medication_Chem_LineTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Medication_Chem_DetailTitleFilterData", AV40BR_Medication_Chem_DetailTitleFilterData);
      }

      protected void E115R2( )
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
            AV26PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV26PageToGo) ;
         }
      }

      protected void E125R2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E135R2( )
      {
         /* Ddo_br_medication_schemeid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_schemeid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medication_schemeid_Sortedstatus = "ASC";
            ucDdo_br_medication_schemeid.SendProperty(context, "", false, Ddo_br_medication_schemeid_Internalname, "SortedStatus", Ddo_br_medication_schemeid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_schemeid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medication_schemeid_Sortedstatus = "DSC";
            ucDdo_br_medication_schemeid.SendProperty(context, "", false, Ddo_br_medication_schemeid_Internalname, "SortedStatus", Ddo_br_medication_schemeid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Medication_SchemeIDTitleFilterData", AV13BR_Medication_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_MedicationIDTitleFilterData", AV15BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Medication_Chem_NameTitleFilterData", AV32BR_Medication_Chem_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Medication_Chem_CycleTitleFilterData", AV34BR_Medication_Chem_CycleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Medication_Chem_LineTitleFilterData", AV36BR_Medication_Chem_LineTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Medication_Chem_DetailTitleFilterData", AV40BR_Medication_Chem_DetailTitleFilterData);
      }

      protected void E145R2( )
      {
         /* Ddo_br_medicationid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicationid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicationid_Sortedstatus = "ASC";
            ucDdo_br_medicationid.SendProperty(context, "", false, Ddo_br_medicationid_Internalname, "SortedStatus", Ddo_br_medicationid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicationid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medicationid_Sortedstatus = "DSC";
            ucDdo_br_medicationid.SendProperty(context, "", false, Ddo_br_medicationid_Internalname, "SortedStatus", Ddo_br_medicationid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Medication_SchemeIDTitleFilterData", AV13BR_Medication_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_MedicationIDTitleFilterData", AV15BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Medication_Chem_NameTitleFilterData", AV32BR_Medication_Chem_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Medication_Chem_CycleTitleFilterData", AV34BR_Medication_Chem_CycleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Medication_Chem_LineTitleFilterData", AV36BR_Medication_Chem_LineTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Medication_Chem_DetailTitleFilterData", AV40BR_Medication_Chem_DetailTitleFilterData);
      }

      protected void E155R2( )
      {
         /* Ddo_br_medication_chem_name_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_chem_name_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medication_chem_name_Sortedstatus = "ASC";
            ucDdo_br_medication_chem_name.SendProperty(context, "", false, Ddo_br_medication_chem_name_Internalname, "SortedStatus", Ddo_br_medication_chem_name_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_chem_name_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medication_chem_name_Sortedstatus = "DSC";
            ucDdo_br_medication_chem_name.SendProperty(context, "", false, Ddo_br_medication_chem_name_Internalname, "SortedStatus", Ddo_br_medication_chem_name_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Medication_SchemeIDTitleFilterData", AV13BR_Medication_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_MedicationIDTitleFilterData", AV15BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Medication_Chem_NameTitleFilterData", AV32BR_Medication_Chem_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Medication_Chem_CycleTitleFilterData", AV34BR_Medication_Chem_CycleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Medication_Chem_LineTitleFilterData", AV36BR_Medication_Chem_LineTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Medication_Chem_DetailTitleFilterData", AV40BR_Medication_Chem_DetailTitleFilterData);
      }

      protected void E165R2( )
      {
         /* Ddo_br_medication_chem_cycle_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_chem_cycle_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medication_chem_cycle_Sortedstatus = "ASC";
            ucDdo_br_medication_chem_cycle.SendProperty(context, "", false, Ddo_br_medication_chem_cycle_Internalname, "SortedStatus", Ddo_br_medication_chem_cycle_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_chem_cycle_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medication_chem_cycle_Sortedstatus = "DSC";
            ucDdo_br_medication_chem_cycle.SendProperty(context, "", false, Ddo_br_medication_chem_cycle_Internalname, "SortedStatus", Ddo_br_medication_chem_cycle_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Medication_SchemeIDTitleFilterData", AV13BR_Medication_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_MedicationIDTitleFilterData", AV15BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Medication_Chem_NameTitleFilterData", AV32BR_Medication_Chem_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Medication_Chem_CycleTitleFilterData", AV34BR_Medication_Chem_CycleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Medication_Chem_LineTitleFilterData", AV36BR_Medication_Chem_LineTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Medication_Chem_DetailTitleFilterData", AV40BR_Medication_Chem_DetailTitleFilterData);
      }

      protected void E175R2( )
      {
         /* Ddo_br_medication_chem_line_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_chem_line_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medication_chem_line_Sortedstatus = "ASC";
            ucDdo_br_medication_chem_line.SendProperty(context, "", false, Ddo_br_medication_chem_line_Internalname, "SortedStatus", Ddo_br_medication_chem_line_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_chem_line_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medication_chem_line_Sortedstatus = "DSC";
            ucDdo_br_medication_chem_line.SendProperty(context, "", false, Ddo_br_medication_chem_line_Internalname, "SortedStatus", Ddo_br_medication_chem_line_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Medication_SchemeIDTitleFilterData", AV13BR_Medication_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_MedicationIDTitleFilterData", AV15BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Medication_Chem_NameTitleFilterData", AV32BR_Medication_Chem_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Medication_Chem_CycleTitleFilterData", AV34BR_Medication_Chem_CycleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Medication_Chem_LineTitleFilterData", AV36BR_Medication_Chem_LineTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Medication_Chem_DetailTitleFilterData", AV40BR_Medication_Chem_DetailTitleFilterData);
      }

      protected void E185R2( )
      {
         /* Ddo_br_medication_chem_detail_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_chem_detail_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medication_chem_detail_Sortedstatus = "ASC";
            ucDdo_br_medication_chem_detail.SendProperty(context, "", false, Ddo_br_medication_chem_detail_Internalname, "SortedStatus", Ddo_br_medication_chem_detail_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_chem_detail_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medication_chem_detail_Sortedstatus = "DSC";
            ucDdo_br_medication_chem_detail.SendProperty(context, "", false, Ddo_br_medication_chem_detail_Internalname, "SortedStatus", Ddo_br_medication_chem_detail_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Medication_SchemeIDTitleFilterData", AV13BR_Medication_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_MedicationIDTitleFilterData", AV15BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Medication_Chem_NameTitleFilterData", AV32BR_Medication_Chem_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Medication_Chem_CycleTitleFilterData", AV34BR_Medication_Chem_CycleTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Medication_Chem_LineTitleFilterData", AV36BR_Medication_Chem_LineTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Medication_Chem_DetailTitleFilterData", AV40BR_Medication_Chem_DetailTitleFilterData);
      }

      private void E215R2( )
      {
         /* Grid_Load Routine */
         AV30Select = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSelect_Internalname, AV30Select);
         AV45Select_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
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
         E225R2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E225R2( )
      {
         /* Enter Routine */
         AV8InOutBR_Medication_SchemeID = A296BR_Medication_SchemeID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_Medication_SchemeID), 18, 0)));
         context.setWebReturnParms(new Object[] {(long)AV8InOutBR_Medication_SchemeID});
         context.setWebReturnParmsMetadata(new Object[] {"AV8InOutBR_Medication_SchemeID"});
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
         AV8InOutBR_Medication_SchemeID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_Medication_SchemeID), 18, 0)));
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
         PA5R2( ) ;
         WS5R2( ) ;
         WE5R2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279445469", true);
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
         context.AddJavascriptSource("br_medication_schemeprompt.js", "?20202279445469", false);
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
         edtBR_Medication_SchemeID_Internalname = "BR_MEDICATION_SCHEMEID_"+sGXsfl_12_idx;
         edtBR_MedicationID_Internalname = "BR_MEDICATIONID_"+sGXsfl_12_idx;
         edtBR_Medication_Chem_Name_Internalname = "BR_MEDICATION_CHEM_NAME_"+sGXsfl_12_idx;
         edtBR_Medication_Chem_Cycle_Internalname = "BR_MEDICATION_CHEM_CYCLE_"+sGXsfl_12_idx;
         edtBR_Medication_Chem_Line_Internalname = "BR_MEDICATION_CHEM_LINE_"+sGXsfl_12_idx;
         edtBR_Medication_Chem_Detail_Internalname = "BR_MEDICATION_CHEM_DETAIL_"+sGXsfl_12_idx;
      }

      protected void SubsflControlProps_fel_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_fel_idx;
         edtBR_Medication_SchemeID_Internalname = "BR_MEDICATION_SCHEMEID_"+sGXsfl_12_fel_idx;
         edtBR_MedicationID_Internalname = "BR_MEDICATIONID_"+sGXsfl_12_fel_idx;
         edtBR_Medication_Chem_Name_Internalname = "BR_MEDICATION_CHEM_NAME_"+sGXsfl_12_fel_idx;
         edtBR_Medication_Chem_Cycle_Internalname = "BR_MEDICATION_CHEM_CYCLE_"+sGXsfl_12_fel_idx;
         edtBR_Medication_Chem_Line_Internalname = "BR_MEDICATION_CHEM_LINE_"+sGXsfl_12_fel_idx;
         edtBR_Medication_Chem_Detail_Internalname = "BR_MEDICATION_CHEM_DETAIL_"+sGXsfl_12_fel_idx;
      }

      protected void sendrow_122( )
      {
         SubsflControlProps_122( ) ;
         WB5R0( ) ;
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
            AV30Select_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV30Select))&&String.IsNullOrEmpty(StringUtil.RTrim( AV45Select_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV30Select)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV30Select)) ? AV45Select_GXI : context.PathToRelativeUrl( AV30Select));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSelect_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSelect_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSelect_Jsonclick,"'"+""+"'"+",false,"+"'"+"EENTER."+sGXsfl_12_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV30Select_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_SchemeID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A296BR_Medication_SchemeID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A296BR_Medication_SchemeID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_SchemeID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
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
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_Chem_Name_Internalname,(String)A305BR_Medication_Chem_Name,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_Chem_Name_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_Chem_Cycle_Internalname,StringUtil.LTrim( StringUtil.NToC( A306BR_Medication_Chem_Cycle, 15, 5, ".", "")),context.localUtil.Format( A306BR_Medication_Chem_Cycle, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_Chem_Cycle_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_Chem_Line_Internalname,(String)A307BR_Medication_Chem_Line,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_Chem_Line_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_Chem_Detail_Internalname,(String)A313BR_Medication_Chem_Detail,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_Chem_Detail_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes5R2( ) ;
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
         edtBR_Medication_SchemeID_Internalname = "BR_MEDICATION_SCHEMEID";
         edtBR_MedicationID_Internalname = "BR_MEDICATIONID";
         edtBR_Medication_Chem_Name_Internalname = "BR_MEDICATION_CHEM_NAME";
         edtBR_Medication_Chem_Cycle_Internalname = "BR_MEDICATION_CHEM_CYCLE";
         edtBR_Medication_Chem_Line_Internalname = "BR_MEDICATION_CHEM_LINE";
         edtBR_Medication_Chem_Detail_Internalname = "BR_MEDICATION_CHEM_DETAIL";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_medication_schemeid_Internalname = "DDO_BR_MEDICATION_SCHEMEID";
         edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE";
         Ddo_br_medicationid_Internalname = "DDO_BR_MEDICATIONID";
         edtavDdo_br_medicationidtitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE";
         Ddo_br_medication_chem_name_Internalname = "DDO_BR_MEDICATION_CHEM_NAME";
         edtavDdo_br_medication_chem_nametitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE";
         Ddo_br_medication_chem_cycle_Internalname = "DDO_BR_MEDICATION_CHEM_CYCLE";
         edtavDdo_br_medication_chem_cycletitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE";
         Ddo_br_medication_chem_line_Internalname = "DDO_BR_MEDICATION_CHEM_LINE";
         edtavDdo_br_medication_chem_linetitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE";
         Ddo_br_medication_chem_detail_Internalname = "DDO_BR_MEDICATION_CHEM_DETAIL";
         edtavDdo_br_medication_chem_detailtitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE";
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
         edtBR_Medication_Chem_Detail_Jsonclick = "";
         edtBR_Medication_Chem_Line_Jsonclick = "";
         edtBR_Medication_Chem_Cycle_Jsonclick = "";
         edtBR_Medication_Chem_Name_Jsonclick = "";
         edtBR_MedicationID_Jsonclick = "";
         edtBR_Medication_SchemeID_Jsonclick = "";
         edtavSelect_Jsonclick = "";
         edtavSelect_Visible = -1;
         edtavSelect_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_medication_chem_detailtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medication_chem_linetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medication_chem_cycletitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medication_chem_nametitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medicationidtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavSelect_Tooltiptext = "选择";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Medication_Chem_Detail_Titleformat = 0;
         edtBR_Medication_Chem_Detail_Title = "描述化疗方案";
         edtBR_Medication_Chem_Line_Titleformat = 0;
         edtBR_Medication_Chem_Line_Title = "线级";
         edtBR_Medication_Chem_Cycle_Titleformat = 0;
         edtBR_Medication_Chem_Cycle_Title = "周期";
         edtBR_Medication_Chem_Name_Titleformat = 0;
         edtBR_Medication_Chem_Name_Title = "化疗方案名称";
         edtBR_MedicationID_Titleformat = 0;
         edtBR_MedicationID_Title = "药物治疗主键";
         edtBR_Medication_SchemeID_Titleformat = 0;
         edtBR_Medication_SchemeID_Title = "药物治疗化疗方案主键";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         divTablemain_Height = 0;
         Ddo_br_medication_chem_detail_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_chem_detail_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_chem_detail_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_chem_detail_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medication_chem_detail_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medication_chem_detail_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_chem_detail_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_chem_detail_Titlecontrolidtoreplace = "";
         Ddo_br_medication_chem_detail_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_chem_detail_Cls = "ColumnSettings";
         Ddo_br_medication_chem_detail_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_chem_detail_Caption = "";
         Ddo_br_medication_chem_line_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_chem_line_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_chem_line_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_chem_line_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medication_chem_line_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medication_chem_line_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_chem_line_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_chem_line_Titlecontrolidtoreplace = "";
         Ddo_br_medication_chem_line_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_chem_line_Cls = "ColumnSettings";
         Ddo_br_medication_chem_line_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_chem_line_Caption = "";
         Ddo_br_medication_chem_cycle_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_chem_cycle_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_chem_cycle_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_chem_cycle_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medication_chem_cycle_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medication_chem_cycle_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_chem_cycle_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_chem_cycle_Titlecontrolidtoreplace = "";
         Ddo_br_medication_chem_cycle_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_chem_cycle_Cls = "ColumnSettings";
         Ddo_br_medication_chem_cycle_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_chem_cycle_Caption = "";
         Ddo_br_medication_chem_name_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_chem_name_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_chem_name_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_chem_name_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medication_chem_name_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medication_chem_name_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_chem_name_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_chem_name_Titlecontrolidtoreplace = "";
         Ddo_br_medication_chem_name_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_chem_name_Cls = "ColumnSettings";
         Ddo_br_medication_chem_name_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_chem_name_Caption = "";
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
         Ddo_br_medication_schemeid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_schemeid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_schemeid_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_schemeid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medication_schemeid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medication_schemeid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_schemeid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_schemeid_Titlecontrolidtoreplace = "";
         Ddo_br_medication_schemeid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_schemeid_Cls = "ColumnSettings";
         Ddo_br_medication_schemeid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_schemeid_Caption = "";
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
         Form.Caption = "选择药物治疗化疗方案";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Medication_Chem_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Medication_Chem_LineTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Medication_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV13BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV15BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_Chem_NameTitleFilterData',fld:'vBR_MEDICATION_CHEM_NAMETITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_Chem_CycleTitleFilterData',fld:'vBR_MEDICATION_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV36BR_Medication_Chem_LineTitleFilterData',fld:'vBR_MEDICATION_CHEM_LINETITLEFILTERDATA',pic:''},{av:'AV40BR_Medication_Chem_DetailTitleFilterData',fld:'vBR_MEDICATION_CHEM_DETAILTITLEFILTERDATA',pic:''},{av:'edtBR_Medication_SchemeID_Titleformat',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'edtBR_Medication_SchemeID_Title',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Medication_Chem_Name_Titleformat',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Name_Title',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Title'},{av:'edtBR_Medication_Chem_Cycle_Titleformat',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Cycle_Title',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Title'},{av:'edtBR_Medication_Chem_Line_Titleformat',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Line_Title',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Title'},{av:'edtBR_Medication_Chem_Detail_Titleformat',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Detail_Title',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E115R2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Medication_Chem_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Medication_Chem_LineTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Medication_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E125R2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Medication_Chem_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Medication_Chem_LineTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Medication_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_MEDICATION_SCHEMEID.ONOPTIONCLICKED","{handler:'E135R2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Medication_Chem_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Medication_Chem_LineTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Medication_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medication_schemeid_Activeeventkey',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICATION_SCHEMEID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_schemeid_Sortedstatus',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'SortedStatus'},{av:'AV13BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV15BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_Chem_NameTitleFilterData',fld:'vBR_MEDICATION_CHEM_NAMETITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_Chem_CycleTitleFilterData',fld:'vBR_MEDICATION_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV36BR_Medication_Chem_LineTitleFilterData',fld:'vBR_MEDICATION_CHEM_LINETITLEFILTERDATA',pic:''},{av:'AV40BR_Medication_Chem_DetailTitleFilterData',fld:'vBR_MEDICATION_CHEM_DETAILTITLEFILTERDATA',pic:''},{av:'edtBR_Medication_SchemeID_Titleformat',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'edtBR_Medication_SchemeID_Title',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Medication_Chem_Name_Titleformat',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Name_Title',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Title'},{av:'edtBR_Medication_Chem_Cycle_Titleformat',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Cycle_Title',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Title'},{av:'edtBR_Medication_Chem_Line_Titleformat',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Line_Title',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Title'},{av:'edtBR_Medication_Chem_Detail_Titleformat',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Detail_Title',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICATIONID.ONOPTIONCLICKED","{handler:'E145R2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Medication_Chem_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Medication_Chem_LineTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Medication_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medicationid_Activeeventkey',ctrl:'DDO_BR_MEDICATIONID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICATIONID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicationid_Sortedstatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'AV13BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV15BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_Chem_NameTitleFilterData',fld:'vBR_MEDICATION_CHEM_NAMETITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_Chem_CycleTitleFilterData',fld:'vBR_MEDICATION_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV36BR_Medication_Chem_LineTitleFilterData',fld:'vBR_MEDICATION_CHEM_LINETITLEFILTERDATA',pic:''},{av:'AV40BR_Medication_Chem_DetailTitleFilterData',fld:'vBR_MEDICATION_CHEM_DETAILTITLEFILTERDATA',pic:''},{av:'edtBR_Medication_SchemeID_Titleformat',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'edtBR_Medication_SchemeID_Title',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Medication_Chem_Name_Titleformat',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Name_Title',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Title'},{av:'edtBR_Medication_Chem_Cycle_Titleformat',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Cycle_Title',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Title'},{av:'edtBR_Medication_Chem_Line_Titleformat',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Line_Title',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Title'},{av:'edtBR_Medication_Chem_Detail_Titleformat',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Detail_Title',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICATION_CHEM_NAME.ONOPTIONCLICKED","{handler:'E155R2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Medication_Chem_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Medication_Chem_LineTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Medication_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medication_chem_name_Activeeventkey',ctrl:'DDO_BR_MEDICATION_CHEM_NAME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICATION_CHEM_NAME.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_chem_name_Sortedstatus',ctrl:'DDO_BR_MEDICATION_CHEM_NAME',prop:'SortedStatus'},{av:'AV13BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV15BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_Chem_NameTitleFilterData',fld:'vBR_MEDICATION_CHEM_NAMETITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_Chem_CycleTitleFilterData',fld:'vBR_MEDICATION_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV36BR_Medication_Chem_LineTitleFilterData',fld:'vBR_MEDICATION_CHEM_LINETITLEFILTERDATA',pic:''},{av:'AV40BR_Medication_Chem_DetailTitleFilterData',fld:'vBR_MEDICATION_CHEM_DETAILTITLEFILTERDATA',pic:''},{av:'edtBR_Medication_SchemeID_Titleformat',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'edtBR_Medication_SchemeID_Title',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Medication_Chem_Name_Titleformat',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Name_Title',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Title'},{av:'edtBR_Medication_Chem_Cycle_Titleformat',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Cycle_Title',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Title'},{av:'edtBR_Medication_Chem_Line_Titleformat',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Line_Title',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Title'},{av:'edtBR_Medication_Chem_Detail_Titleformat',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Detail_Title',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICATION_CHEM_CYCLE.ONOPTIONCLICKED","{handler:'E165R2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Medication_Chem_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Medication_Chem_LineTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Medication_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medication_chem_cycle_Activeeventkey',ctrl:'DDO_BR_MEDICATION_CHEM_CYCLE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICATION_CHEM_CYCLE.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_chem_cycle_Sortedstatus',ctrl:'DDO_BR_MEDICATION_CHEM_CYCLE',prop:'SortedStatus'},{av:'AV13BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV15BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_Chem_NameTitleFilterData',fld:'vBR_MEDICATION_CHEM_NAMETITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_Chem_CycleTitleFilterData',fld:'vBR_MEDICATION_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV36BR_Medication_Chem_LineTitleFilterData',fld:'vBR_MEDICATION_CHEM_LINETITLEFILTERDATA',pic:''},{av:'AV40BR_Medication_Chem_DetailTitleFilterData',fld:'vBR_MEDICATION_CHEM_DETAILTITLEFILTERDATA',pic:''},{av:'edtBR_Medication_SchemeID_Titleformat',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'edtBR_Medication_SchemeID_Title',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Medication_Chem_Name_Titleformat',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Name_Title',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Title'},{av:'edtBR_Medication_Chem_Cycle_Titleformat',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Cycle_Title',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Title'},{av:'edtBR_Medication_Chem_Line_Titleformat',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Line_Title',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Title'},{av:'edtBR_Medication_Chem_Detail_Titleformat',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Detail_Title',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICATION_CHEM_LINE.ONOPTIONCLICKED","{handler:'E175R2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Medication_Chem_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Medication_Chem_LineTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Medication_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medication_chem_line_Activeeventkey',ctrl:'DDO_BR_MEDICATION_CHEM_LINE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICATION_CHEM_LINE.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_chem_line_Sortedstatus',ctrl:'DDO_BR_MEDICATION_CHEM_LINE',prop:'SortedStatus'},{av:'AV13BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV15BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_Chem_NameTitleFilterData',fld:'vBR_MEDICATION_CHEM_NAMETITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_Chem_CycleTitleFilterData',fld:'vBR_MEDICATION_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV36BR_Medication_Chem_LineTitleFilterData',fld:'vBR_MEDICATION_CHEM_LINETITLEFILTERDATA',pic:''},{av:'AV40BR_Medication_Chem_DetailTitleFilterData',fld:'vBR_MEDICATION_CHEM_DETAILTITLEFILTERDATA',pic:''},{av:'edtBR_Medication_SchemeID_Titleformat',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'edtBR_Medication_SchemeID_Title',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Medication_Chem_Name_Titleformat',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Name_Title',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Title'},{av:'edtBR_Medication_Chem_Cycle_Titleformat',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Cycle_Title',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Title'},{av:'edtBR_Medication_Chem_Line_Titleformat',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Line_Title',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Title'},{av:'edtBR_Medication_Chem_Detail_Titleformat',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Detail_Title',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICATION_CHEM_DETAIL.ONOPTIONCLICKED","{handler:'E185R2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Medication_Chem_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Medication_Chem_CycleTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_CYCLETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Medication_Chem_LineTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_LINETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Medication_Chem_DetailTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_CHEM_DETAILTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medication_chem_detail_Activeeventkey',ctrl:'DDO_BR_MEDICATION_CHEM_DETAIL',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICATION_CHEM_DETAIL.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_chem_detail_Sortedstatus',ctrl:'DDO_BR_MEDICATION_CHEM_DETAIL',prop:'SortedStatus'},{av:'AV13BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV15BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Medication_Chem_NameTitleFilterData',fld:'vBR_MEDICATION_CHEM_NAMETITLEFILTERDATA',pic:''},{av:'AV34BR_Medication_Chem_CycleTitleFilterData',fld:'vBR_MEDICATION_CHEM_CYCLETITLEFILTERDATA',pic:''},{av:'AV36BR_Medication_Chem_LineTitleFilterData',fld:'vBR_MEDICATION_CHEM_LINETITLEFILTERDATA',pic:''},{av:'AV40BR_Medication_Chem_DetailTitleFilterData',fld:'vBR_MEDICATION_CHEM_DETAILTITLEFILTERDATA',pic:''},{av:'edtBR_Medication_SchemeID_Titleformat',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'edtBR_Medication_SchemeID_Title',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Medication_Chem_Name_Titleformat',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Name_Title',ctrl:'BR_MEDICATION_CHEM_NAME',prop:'Title'},{av:'edtBR_Medication_Chem_Cycle_Titleformat',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Cycle_Title',ctrl:'BR_MEDICATION_CHEM_CYCLE',prop:'Title'},{av:'edtBR_Medication_Chem_Line_Titleformat',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Line_Title',ctrl:'BR_MEDICATION_CHEM_LINE',prop:'Title'},{av:'edtBR_Medication_Chem_Detail_Titleformat',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Titleformat'},{av:'edtBR_Medication_Chem_Detail_Title',ctrl:'BR_MEDICATION_CHEM_DETAIL',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E215R2',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV30Select',fld:'vSELECT',pic:''},{av:'edtavSelect_Tooltiptext',ctrl:'vSELECT',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E225R2',iparms:[{av:'A296BR_Medication_SchemeID',fld:'BR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV8InOutBR_Medication_SchemeID',fld:'vINOUTBR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'}]}");
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
         Ddo_br_medication_schemeid_Activeeventkey = "";
         Ddo_br_medicationid_Activeeventkey = "";
         Ddo_br_medication_chem_name_Activeeventkey = "";
         Ddo_br_medication_chem_cycle_Activeeventkey = "";
         Ddo_br_medication_chem_line_Activeeventkey = "";
         Ddo_br_medication_chem_detail_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV14ddo_BR_Medication_SchemeIDTitleControlIdToReplace = "";
         AV16ddo_BR_MedicationIDTitleControlIdToReplace = "";
         AV33ddo_BR_Medication_Chem_NameTitleControlIdToReplace = "";
         AV35ddo_BR_Medication_Chem_CycleTitleControlIdToReplace = "";
         AV37ddo_BR_Medication_Chem_LineTitleControlIdToReplace = "";
         AV41ddo_BR_Medication_Chem_DetailTitleControlIdToReplace = "";
         GXKey = "";
         AV44Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV25DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV13BR_Medication_SchemeIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15BR_MedicationIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32BR_Medication_Chem_NameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV34BR_Medication_Chem_CycleTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV36BR_Medication_Chem_LineTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV40BR_Medication_Chem_DetailTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_medication_schemeid_Sortedstatus = "";
         Ddo_br_medicationid_Sortedstatus = "";
         Ddo_br_medication_chem_name_Sortedstatus = "";
         Ddo_br_medication_chem_cycle_Sortedstatus = "";
         Ddo_br_medication_chem_line_Sortedstatus = "";
         Ddo_br_medication_chem_detail_Sortedstatus = "";
         GX_FocusControl = "";
         sPrefix = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV30Select = "";
         A305BR_Medication_Chem_Name = "";
         A307BR_Medication_Chem_Line = "";
         A313BR_Medication_Chem_Detail = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_medication_schemeid = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_br_medicationid = new GXUserControl();
         ucDdo_br_medication_chem_name = new GXUserControl();
         ucDdo_br_medication_chem_cycle = new GXUserControl();
         ucDdo_br_medication_chem_line = new GXUserControl();
         ucDdo_br_medication_chem_detail = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV45Select_GXI = "";
         scmdbuf = "";
         H005R2_A313BR_Medication_Chem_Detail = new String[] {""} ;
         H005R2_n313BR_Medication_Chem_Detail = new bool[] {false} ;
         H005R2_A307BR_Medication_Chem_Line = new String[] {""} ;
         H005R2_n307BR_Medication_Chem_Line = new bool[] {false} ;
         H005R2_A306BR_Medication_Chem_Cycle = new decimal[1] ;
         H005R2_n306BR_Medication_Chem_Cycle = new bool[] {false} ;
         H005R2_A305BR_Medication_Chem_Name = new String[] {""} ;
         H005R2_n305BR_Medication_Chem_Name = new bool[] {false} ;
         H005R2_A119BR_MedicationID = new long[1] ;
         H005R2_n119BR_MedicationID = new bool[] {false} ;
         H005R2_A296BR_Medication_SchemeID = new long[1] ;
         H005R3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_medication_schemeprompt__default(),
            new Object[][] {
                new Object[] {
               H005R2_A313BR_Medication_Chem_Detail, H005R2_n313BR_Medication_Chem_Detail, H005R2_A307BR_Medication_Chem_Line, H005R2_n307BR_Medication_Chem_Line, H005R2_A306BR_Medication_Chem_Cycle, H005R2_n306BR_Medication_Chem_Cycle, H005R2_A305BR_Medication_Chem_Name, H005R2_n305BR_Medication_Chem_Name, H005R2_A119BR_MedicationID, H005R2_n119BR_MedicationID,
               H005R2_A296BR_Medication_SchemeID
               }
               , new Object[] {
               H005R3_AGRID_nRecordCount
               }
            }
         );
         AV44Pgmname = "BR_Medication_SchemePrompt";
         /* GeneXus formulas. */
         AV44Pgmname = "BR_Medication_SchemePrompt";
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
      private short edtBR_Medication_SchemeID_Titleformat ;
      private short edtBR_MedicationID_Titleformat ;
      private short edtBR_Medication_Chem_Name_Titleformat ;
      private short edtBR_Medication_Chem_Cycle_Titleformat ;
      private short edtBR_Medication_Chem_Line_Titleformat ;
      private short edtBR_Medication_Chem_Detail_Titleformat ;
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
      private int edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medicationidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medication_chem_nametitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medication_chem_cycletitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medication_chem_linetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medication_chem_detailtitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV26PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavSelect_Enabled ;
      private int edtavSelect_Visible ;
      private long AV8InOutBR_Medication_SchemeID ;
      private long wcpOAV8InOutBR_Medication_SchemeID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV27GridCurrentPage ;
      private long AV29GridRecordCount ;
      private long AV28GridPageSize ;
      private long A296BR_Medication_SchemeID ;
      private long A119BR_MedicationID ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private decimal A306BR_Medication_Chem_Cycle ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_medication_schemeid_Activeeventkey ;
      private String Ddo_br_medicationid_Activeeventkey ;
      private String Ddo_br_medication_chem_name_Activeeventkey ;
      private String Ddo_br_medication_chem_cycle_Activeeventkey ;
      private String Ddo_br_medication_chem_line_Activeeventkey ;
      private String Ddo_br_medication_chem_detail_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_12_idx="0001" ;
      private String GXKey ;
      private String AV44Pgmname ;
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
      private String Ddo_br_medication_schemeid_Caption ;
      private String Ddo_br_medication_schemeid_Tooltip ;
      private String Ddo_br_medication_schemeid_Cls ;
      private String Ddo_br_medication_schemeid_Dropdownoptionstype ;
      private String Ddo_br_medication_schemeid_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_schemeid_Sortedstatus ;
      private String Ddo_br_medication_schemeid_Sortasc ;
      private String Ddo_br_medication_schemeid_Sortdsc ;
      private String Ddo_br_medication_schemeid_Searchbuttontext ;
      private String Ddo_br_medicationid_Caption ;
      private String Ddo_br_medicationid_Tooltip ;
      private String Ddo_br_medicationid_Cls ;
      private String Ddo_br_medicationid_Dropdownoptionstype ;
      private String Ddo_br_medicationid_Titlecontrolidtoreplace ;
      private String Ddo_br_medicationid_Sortedstatus ;
      private String Ddo_br_medicationid_Sortasc ;
      private String Ddo_br_medicationid_Sortdsc ;
      private String Ddo_br_medicationid_Searchbuttontext ;
      private String Ddo_br_medication_chem_name_Caption ;
      private String Ddo_br_medication_chem_name_Tooltip ;
      private String Ddo_br_medication_chem_name_Cls ;
      private String Ddo_br_medication_chem_name_Dropdownoptionstype ;
      private String Ddo_br_medication_chem_name_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_chem_name_Sortedstatus ;
      private String Ddo_br_medication_chem_name_Sortasc ;
      private String Ddo_br_medication_chem_name_Sortdsc ;
      private String Ddo_br_medication_chem_name_Searchbuttontext ;
      private String Ddo_br_medication_chem_cycle_Caption ;
      private String Ddo_br_medication_chem_cycle_Tooltip ;
      private String Ddo_br_medication_chem_cycle_Cls ;
      private String Ddo_br_medication_chem_cycle_Dropdownoptionstype ;
      private String Ddo_br_medication_chem_cycle_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_chem_cycle_Sortedstatus ;
      private String Ddo_br_medication_chem_cycle_Sortasc ;
      private String Ddo_br_medication_chem_cycle_Sortdsc ;
      private String Ddo_br_medication_chem_cycle_Searchbuttontext ;
      private String Ddo_br_medication_chem_line_Caption ;
      private String Ddo_br_medication_chem_line_Tooltip ;
      private String Ddo_br_medication_chem_line_Cls ;
      private String Ddo_br_medication_chem_line_Dropdownoptionstype ;
      private String Ddo_br_medication_chem_line_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_chem_line_Sortedstatus ;
      private String Ddo_br_medication_chem_line_Sortasc ;
      private String Ddo_br_medication_chem_line_Sortdsc ;
      private String Ddo_br_medication_chem_line_Searchbuttontext ;
      private String Ddo_br_medication_chem_detail_Caption ;
      private String Ddo_br_medication_chem_detail_Tooltip ;
      private String Ddo_br_medication_chem_detail_Cls ;
      private String Ddo_br_medication_chem_detail_Dropdownoptionstype ;
      private String Ddo_br_medication_chem_detail_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_chem_detail_Sortedstatus ;
      private String Ddo_br_medication_chem_detail_Sortasc ;
      private String Ddo_br_medication_chem_detail_Sortdsc ;
      private String Ddo_br_medication_chem_detail_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtBR_Medication_SchemeID_Title ;
      private String edtBR_MedicationID_Title ;
      private String edtBR_Medication_Chem_Name_Title ;
      private String edtBR_Medication_Chem_Cycle_Title ;
      private String edtBR_Medication_Chem_Line_Title ;
      private String edtBR_Medication_Chem_Detail_Title ;
      private String subGrid_Header ;
      private String edtavSelect_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_medication_schemeid_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medicationid_Internalname ;
      private String edtavDdo_br_medicationidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medication_chem_name_Internalname ;
      private String edtavDdo_br_medication_chem_nametitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medication_chem_cycle_Internalname ;
      private String edtavDdo_br_medication_chem_cycletitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medication_chem_line_Internalname ;
      private String edtavDdo_br_medication_chem_linetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medication_chem_detail_Internalname ;
      private String edtavDdo_br_medication_chem_detailtitlecontrolidtoreplace_Internalname ;
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
      private String edtBR_Medication_SchemeID_Internalname ;
      private String edtBR_MedicationID_Internalname ;
      private String edtBR_Medication_Chem_Name_Internalname ;
      private String edtBR_Medication_Chem_Cycle_Internalname ;
      private String edtBR_Medication_Chem_Line_Internalname ;
      private String edtBR_Medication_Chem_Detail_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_12_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavSelect_Jsonclick ;
      private String ROClassString ;
      private String edtBR_Medication_SchemeID_Jsonclick ;
      private String edtBR_MedicationID_Jsonclick ;
      private String edtBR_Medication_Chem_Name_Jsonclick ;
      private String edtBR_Medication_Chem_Cycle_Jsonclick ;
      private String edtBR_Medication_Chem_Line_Jsonclick ;
      private String edtBR_Medication_Chem_Detail_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV12OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_br_medication_schemeid_Includesortasc ;
      private bool Ddo_br_medication_schemeid_Includesortdsc ;
      private bool Ddo_br_medication_schemeid_Includefilter ;
      private bool Ddo_br_medication_schemeid_Includedatalist ;
      private bool Ddo_br_medicationid_Includesortasc ;
      private bool Ddo_br_medicationid_Includesortdsc ;
      private bool Ddo_br_medicationid_Includefilter ;
      private bool Ddo_br_medicationid_Includedatalist ;
      private bool Ddo_br_medication_chem_name_Includesortasc ;
      private bool Ddo_br_medication_chem_name_Includesortdsc ;
      private bool Ddo_br_medication_chem_name_Includefilter ;
      private bool Ddo_br_medication_chem_name_Includedatalist ;
      private bool Ddo_br_medication_chem_cycle_Includesortasc ;
      private bool Ddo_br_medication_chem_cycle_Includesortdsc ;
      private bool Ddo_br_medication_chem_cycle_Includefilter ;
      private bool Ddo_br_medication_chem_cycle_Includedatalist ;
      private bool Ddo_br_medication_chem_line_Includesortasc ;
      private bool Ddo_br_medication_chem_line_Includesortdsc ;
      private bool Ddo_br_medication_chem_line_Includefilter ;
      private bool Ddo_br_medication_chem_line_Includedatalist ;
      private bool Ddo_br_medication_chem_detail_Includesortasc ;
      private bool Ddo_br_medication_chem_detail_Includesortdsc ;
      private bool Ddo_br_medication_chem_detail_Includefilter ;
      private bool Ddo_br_medication_chem_detail_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_12_Refreshing=false ;
      private bool n119BR_MedicationID ;
      private bool n305BR_Medication_Chem_Name ;
      private bool n306BR_Medication_Chem_Cycle ;
      private bool n307BR_Medication_Chem_Line ;
      private bool n313BR_Medication_Chem_Detail ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool gx_refresh_fired ;
      private bool AV30Select_IsBlob ;
      private String AV14ddo_BR_Medication_SchemeIDTitleControlIdToReplace ;
      private String AV16ddo_BR_MedicationIDTitleControlIdToReplace ;
      private String AV33ddo_BR_Medication_Chem_NameTitleControlIdToReplace ;
      private String AV35ddo_BR_Medication_Chem_CycleTitleControlIdToReplace ;
      private String AV37ddo_BR_Medication_Chem_LineTitleControlIdToReplace ;
      private String AV41ddo_BR_Medication_Chem_DetailTitleControlIdToReplace ;
      private String A305BR_Medication_Chem_Name ;
      private String A307BR_Medication_Chem_Line ;
      private String A313BR_Medication_Chem_Detail ;
      private String AV45Select_GXI ;
      private String AV30Select ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_medication_schemeid ;
      private GXUserControl ucDdo_br_medicationid ;
      private GXUserControl ucDdo_br_medication_chem_name ;
      private GXUserControl ucDdo_br_medication_chem_cycle ;
      private GXUserControl ucDdo_br_medication_chem_line ;
      private GXUserControl ucDdo_br_medication_chem_detail ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private long aP0_InOutBR_Medication_SchemeID ;
      private IDataStoreProvider pr_default ;
      private String[] H005R2_A313BR_Medication_Chem_Detail ;
      private bool[] H005R2_n313BR_Medication_Chem_Detail ;
      private String[] H005R2_A307BR_Medication_Chem_Line ;
      private bool[] H005R2_n307BR_Medication_Chem_Line ;
      private decimal[] H005R2_A306BR_Medication_Chem_Cycle ;
      private bool[] H005R2_n306BR_Medication_Chem_Cycle ;
      private String[] H005R2_A305BR_Medication_Chem_Name ;
      private bool[] H005R2_n305BR_Medication_Chem_Name ;
      private long[] H005R2_A119BR_MedicationID ;
      private bool[] H005R2_n119BR_MedicationID ;
      private long[] H005R2_A296BR_Medication_SchemeID ;
      private long[] H005R3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV13BR_Medication_SchemeIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV15BR_MedicationIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV32BR_Medication_Chem_NameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV34BR_Medication_Chem_CycleTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV36BR_Medication_Chem_LineTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV40BR_Medication_Chem_DetailTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV25DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class br_medication_schemeprompt__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H005R2( IGxContext context ,
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
         sSelectString = " [BR_Medication_Chem_Detail], [BR_Medication_Chem_Line], [BR_Medication_Chem_Cycle], [BR_Medication_Chem_Name], [BR_MedicationID], [BR_Medication_SchemeID]";
         sFromString = " FROM [BR_Medication_Scheme] WITH (NOLOCK)";
         sOrderString = "";
         if ( ( AV11OrderedBy == 1 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_SchemeID]";
         }
         else if ( ( AV11OrderedBy == 1 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_SchemeID] DESC";
         }
         else if ( ( AV11OrderedBy == 2 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicationID]";
         }
         else if ( ( AV11OrderedBy == 2 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicationID] DESC";
         }
         else if ( ( AV11OrderedBy == 3 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_Chem_Name]";
         }
         else if ( ( AV11OrderedBy == 3 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_Chem_Name] DESC";
         }
         else if ( ( AV11OrderedBy == 4 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_Chem_Cycle]";
         }
         else if ( ( AV11OrderedBy == 4 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_Chem_Cycle] DESC";
         }
         else if ( ( AV11OrderedBy == 5 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_Chem_Line]";
         }
         else if ( ( AV11OrderedBy == 5 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_Chem_Line] DESC";
         }
         else if ( ( AV11OrderedBy == 6 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_Chem_Detail]";
         }
         else if ( ( AV11OrderedBy == 6 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_Chem_Detail] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_SchemeID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H005R3( IGxContext context ,
                                             short AV11OrderedBy ,
                                             bool AV12OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [BR_Medication_Scheme] WITH (NOLOCK)";
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
                     return conditional_H005R2(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
               case 1 :
                     return conditional_H005R3(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
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
          Object[] prmH005R2 ;
          prmH005R2 = new Object[] {
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH005R3 ;
          prmH005R3 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H005R2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005R2,11,0,true,false )
             ,new CursorDef("H005R3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005R3,1,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((decimal[]) buf[4])[0] = rslt.getDecimal(3) ;
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
