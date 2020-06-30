/*
               File: BR_Medication_DetailPrompt
        Description: 选择药物治疗药物详情
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:14:22.38
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
   public class br_medication_detailprompt : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public br_medication_detailprompt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_medication_detailprompt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_InOutBR_Medication_DetailID )
      {
         this.AV8InOutBR_Medication_DetailID = aP0_InOutBR_Medication_DetailID;
         executePrivate();
         aP0_InOutBR_Medication_DetailID=this.AV8InOutBR_Medication_DetailID;
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
               AV14ddo_BR_Medication_DetailIDTitleControlIdToReplace = GetNextPar( );
               AV16ddo_BR_Medication_SchemeIDTitleControlIdToReplace = GetNextPar( );
               AV30ddo_BR_Medication_Drug_NameTitleControlIdToReplace = GetNextPar( );
               AV32ddo_BR_Medication_Drug_NumTitleControlIdToReplace = GetNextPar( );
               AV34ddo_BR_Medication_Drug_UnitTitleControlIdToReplace = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Medication_DetailIDTitleControlIdToReplace, AV16ddo_BR_Medication_SchemeIDTitleControlIdToReplace, AV30ddo_BR_Medication_Drug_NameTitleControlIdToReplace, AV32ddo_BR_Medication_Drug_NumTitleControlIdToReplace, AV34ddo_BR_Medication_Drug_UnitTitleControlIdToReplace) ;
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
               AV8InOutBR_Medication_DetailID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_Medication_DetailID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_Medication_DetailID), 18, 0)));
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
            PA5S2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV37Pgmname = "BR_Medication_DetailPrompt";
               context.Gx_err = 0;
               WS5S2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE5S2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022815142247", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_medication_detailprompt.aspx") + "?" + UrlEncode("" +AV8InOutBR_Medication_DetailID)+"\">") ;
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_DETAILIDTITLEFILTERDATA", AV13BR_Medication_DetailIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_DETAILIDTITLEFILTERDATA", AV13BR_Medication_DetailIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA", AV15BR_Medication_SchemeIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA", AV15BR_Medication_SchemeIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA", AV29BR_Medication_Drug_NameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA", AV29BR_Medication_Drug_NameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA", AV31BR_Medication_Drug_NumTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA", AV31BR_Medication_Drug_NumTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA", AV33BR_Medication_Drug_UnitTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA", AV33BR_Medication_Drug_UnitTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vINOUTBR_MEDICATION_DETAILID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8InOutBR_Medication_DetailID), 18, 0, ".", "")));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Caption", StringUtil.RTrim( Ddo_br_medication_detailid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Tooltip", StringUtil.RTrim( Ddo_br_medication_detailid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Cls", StringUtil.RTrim( Ddo_br_medication_detailid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_detailid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_detailid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_detailid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_detailid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_detailid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_detailid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_detailid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Sortasc", StringUtil.RTrim( Ddo_br_medication_detailid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Sortdsc", StringUtil.RTrim( Ddo_br_medication_detailid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_detailid_Searchbuttontext));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Caption", StringUtil.RTrim( Ddo_br_medication_drug_name_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Tooltip", StringUtil.RTrim( Ddo_br_medication_drug_name_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Cls", StringUtil.RTrim( Ddo_br_medication_drug_name_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_drug_name_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_drug_name_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_drug_name_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_drug_name_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_drug_name_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_drug_name_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_drug_name_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Sortasc", StringUtil.RTrim( Ddo_br_medication_drug_name_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Sortdsc", StringUtil.RTrim( Ddo_br_medication_drug_name_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_drug_name_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Caption", StringUtil.RTrim( Ddo_br_medication_drug_num_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Tooltip", StringUtil.RTrim( Ddo_br_medication_drug_num_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Cls", StringUtil.RTrim( Ddo_br_medication_drug_num_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_drug_num_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_drug_num_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_drug_num_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_drug_num_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_drug_num_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_drug_num_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_drug_num_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Sortasc", StringUtil.RTrim( Ddo_br_medication_drug_num_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Sortdsc", StringUtil.RTrim( Ddo_br_medication_drug_num_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_drug_num_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Caption", StringUtil.RTrim( Ddo_br_medication_drug_unit_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Tooltip", StringUtil.RTrim( Ddo_br_medication_drug_unit_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Cls", StringUtil.RTrim( Ddo_br_medication_drug_unit_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_drug_unit_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_drug_unit_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_drug_unit_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_drug_unit_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_drug_unit_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_drug_unit_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_drug_unit_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Sortasc", StringUtil.RTrim( Ddo_br_medication_drug_unit_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Sortdsc", StringUtil.RTrim( Ddo_br_medication_drug_unit_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_drug_unit_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_detailid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_schemeid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_drug_name_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_drug_num_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_drug_unit_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DETAILID_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_detailid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_SCHEMEID_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_schemeid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NAME_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_drug_name_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_NUM_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_drug_num_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_MEDICATION_DRUG_UNIT_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_drug_unit_Activeeventkey));
      }

      protected void RenderHtmlCloseForm5S2( )
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
         return "BR_Medication_DetailPrompt" ;
      }

      public override String GetPgmdesc( )
      {
         return "选择药物治疗药物详情" ;
      }

      protected void WB5S0( )
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
               if ( edtBR_Medication_DetailID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Medication_DetailID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Medication_DetailID_Title) ;
               }
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Medication_Drug_Name_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Medication_Drug_Name_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Medication_Drug_Name_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Medication_Drug_Num_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Medication_Drug_Num_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Medication_Drug_Num_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Medication_Drug_Unit_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Medication_Drug_Unit_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Medication_Drug_Unit_Title) ;
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
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A301BR_Medication_DetailID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Medication_DetailID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Medication_DetailID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A296BR_Medication_SchemeID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Medication_SchemeID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Medication_SchemeID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A310BR_Medication_Drug_Name);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Medication_Drug_Name_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Medication_Drug_Name_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A311BR_Medication_Drug_Num, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Medication_Drug_Num_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Medication_Drug_Num_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A312BR_Medication_Drug_Unit);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Medication_Drug_Unit_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Medication_Drug_Unit_Titleformat), 4, 0, ".", "")));
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
            ucDdo_br_medication_detailid.SetProperty("Caption", Ddo_br_medication_detailid_Caption);
            ucDdo_br_medication_detailid.SetProperty("Tooltip", Ddo_br_medication_detailid_Tooltip);
            ucDdo_br_medication_detailid.SetProperty("Cls", Ddo_br_medication_detailid_Cls);
            ucDdo_br_medication_detailid.SetProperty("DropDownOptionsType", Ddo_br_medication_detailid_Dropdownoptionstype);
            ucDdo_br_medication_detailid.SetProperty("IncludeSortASC", Ddo_br_medication_detailid_Includesortasc);
            ucDdo_br_medication_detailid.SetProperty("IncludeSortDSC", Ddo_br_medication_detailid_Includesortdsc);
            ucDdo_br_medication_detailid.SetProperty("IncludeFilter", Ddo_br_medication_detailid_Includefilter);
            ucDdo_br_medication_detailid.SetProperty("IncludeDataList", Ddo_br_medication_detailid_Includedatalist);
            ucDdo_br_medication_detailid.SetProperty("SortASC", Ddo_br_medication_detailid_Sortasc);
            ucDdo_br_medication_detailid.SetProperty("SortDSC", Ddo_br_medication_detailid_Sortdsc);
            ucDdo_br_medication_detailid.SetProperty("SearchButtonText", Ddo_br_medication_detailid_Searchbuttontext);
            ucDdo_br_medication_detailid.SetProperty("DropDownOptionsTitleSettingsIcons", AV23DDO_TitleSettingsIcons);
            ucDdo_br_medication_detailid.SetProperty("DropDownOptionsData", AV13BR_Medication_DetailIDTitleFilterData);
            ucDdo_br_medication_detailid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_detailid_Internalname, "DDO_BR_MEDICATION_DETAILIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_detailidtitlecontrolidtoreplace_Internalname, AV14ddo_BR_Medication_DetailIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,27);\"", 0, edtavDdo_br_medication_detailidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Medication_DetailPrompt.htm");
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
            ucDdo_br_medication_schemeid.SetProperty("DropDownOptionsTitleSettingsIcons", AV23DDO_TitleSettingsIcons);
            ucDdo_br_medication_schemeid.SetProperty("DropDownOptionsData", AV15BR_Medication_SchemeIDTitleFilterData);
            ucDdo_br_medication_schemeid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_schemeid_Internalname, "DDO_BR_MEDICATION_SCHEMEIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Internalname, AV16ddo_BR_Medication_SchemeIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", 0, edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Medication_DetailPrompt.htm");
            /* User Defined Control */
            ucDdo_br_medication_drug_name.SetProperty("Caption", Ddo_br_medication_drug_name_Caption);
            ucDdo_br_medication_drug_name.SetProperty("Tooltip", Ddo_br_medication_drug_name_Tooltip);
            ucDdo_br_medication_drug_name.SetProperty("Cls", Ddo_br_medication_drug_name_Cls);
            ucDdo_br_medication_drug_name.SetProperty("DropDownOptionsType", Ddo_br_medication_drug_name_Dropdownoptionstype);
            ucDdo_br_medication_drug_name.SetProperty("IncludeSortASC", Ddo_br_medication_drug_name_Includesortasc);
            ucDdo_br_medication_drug_name.SetProperty("IncludeSortDSC", Ddo_br_medication_drug_name_Includesortdsc);
            ucDdo_br_medication_drug_name.SetProperty("IncludeFilter", Ddo_br_medication_drug_name_Includefilter);
            ucDdo_br_medication_drug_name.SetProperty("IncludeDataList", Ddo_br_medication_drug_name_Includedatalist);
            ucDdo_br_medication_drug_name.SetProperty("SortASC", Ddo_br_medication_drug_name_Sortasc);
            ucDdo_br_medication_drug_name.SetProperty("SortDSC", Ddo_br_medication_drug_name_Sortdsc);
            ucDdo_br_medication_drug_name.SetProperty("SearchButtonText", Ddo_br_medication_drug_name_Searchbuttontext);
            ucDdo_br_medication_drug_name.SetProperty("DropDownOptionsTitleSettingsIcons", AV23DDO_TitleSettingsIcons);
            ucDdo_br_medication_drug_name.SetProperty("DropDownOptionsData", AV29BR_Medication_Drug_NameTitleFilterData);
            ucDdo_br_medication_drug_name.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_drug_name_Internalname, "DDO_BR_MEDICATION_DRUG_NAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_drug_nametitlecontrolidtoreplace_Internalname, AV30ddo_BR_Medication_Drug_NameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,31);\"", 0, edtavDdo_br_medication_drug_nametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Medication_DetailPrompt.htm");
            /* User Defined Control */
            ucDdo_br_medication_drug_num.SetProperty("Caption", Ddo_br_medication_drug_num_Caption);
            ucDdo_br_medication_drug_num.SetProperty("Tooltip", Ddo_br_medication_drug_num_Tooltip);
            ucDdo_br_medication_drug_num.SetProperty("Cls", Ddo_br_medication_drug_num_Cls);
            ucDdo_br_medication_drug_num.SetProperty("DropDownOptionsType", Ddo_br_medication_drug_num_Dropdownoptionstype);
            ucDdo_br_medication_drug_num.SetProperty("IncludeSortASC", Ddo_br_medication_drug_num_Includesortasc);
            ucDdo_br_medication_drug_num.SetProperty("IncludeSortDSC", Ddo_br_medication_drug_num_Includesortdsc);
            ucDdo_br_medication_drug_num.SetProperty("IncludeFilter", Ddo_br_medication_drug_num_Includefilter);
            ucDdo_br_medication_drug_num.SetProperty("IncludeDataList", Ddo_br_medication_drug_num_Includedatalist);
            ucDdo_br_medication_drug_num.SetProperty("SortASC", Ddo_br_medication_drug_num_Sortasc);
            ucDdo_br_medication_drug_num.SetProperty("SortDSC", Ddo_br_medication_drug_num_Sortdsc);
            ucDdo_br_medication_drug_num.SetProperty("SearchButtonText", Ddo_br_medication_drug_num_Searchbuttontext);
            ucDdo_br_medication_drug_num.SetProperty("DropDownOptionsTitleSettingsIcons", AV23DDO_TitleSettingsIcons);
            ucDdo_br_medication_drug_num.SetProperty("DropDownOptionsData", AV31BR_Medication_Drug_NumTitleFilterData);
            ucDdo_br_medication_drug_num.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_drug_num_Internalname, "DDO_BR_MEDICATION_DRUG_NUMContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_drug_numtitlecontrolidtoreplace_Internalname, AV32ddo_BR_Medication_Drug_NumTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", 0, edtavDdo_br_medication_drug_numtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Medication_DetailPrompt.htm");
            /* User Defined Control */
            ucDdo_br_medication_drug_unit.SetProperty("Caption", Ddo_br_medication_drug_unit_Caption);
            ucDdo_br_medication_drug_unit.SetProperty("Tooltip", Ddo_br_medication_drug_unit_Tooltip);
            ucDdo_br_medication_drug_unit.SetProperty("Cls", Ddo_br_medication_drug_unit_Cls);
            ucDdo_br_medication_drug_unit.SetProperty("DropDownOptionsType", Ddo_br_medication_drug_unit_Dropdownoptionstype);
            ucDdo_br_medication_drug_unit.SetProperty("IncludeSortASC", Ddo_br_medication_drug_unit_Includesortasc);
            ucDdo_br_medication_drug_unit.SetProperty("IncludeSortDSC", Ddo_br_medication_drug_unit_Includesortdsc);
            ucDdo_br_medication_drug_unit.SetProperty("IncludeFilter", Ddo_br_medication_drug_unit_Includefilter);
            ucDdo_br_medication_drug_unit.SetProperty("IncludeDataList", Ddo_br_medication_drug_unit_Includedatalist);
            ucDdo_br_medication_drug_unit.SetProperty("SortASC", Ddo_br_medication_drug_unit_Sortasc);
            ucDdo_br_medication_drug_unit.SetProperty("SortDSC", Ddo_br_medication_drug_unit_Sortdsc);
            ucDdo_br_medication_drug_unit.SetProperty("SearchButtonText", Ddo_br_medication_drug_unit_Searchbuttontext);
            ucDdo_br_medication_drug_unit.SetProperty("DropDownOptionsTitleSettingsIcons", AV23DDO_TitleSettingsIcons);
            ucDdo_br_medication_drug_unit.SetProperty("DropDownOptionsData", AV33BR_Medication_Drug_UnitTitleFilterData);
            ucDdo_br_medication_drug_unit.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_drug_unit_Internalname, "DDO_BR_MEDICATION_DRUG_UNITContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_drug_unittitlecontrolidtoreplace_Internalname, AV34ddo_BR_Medication_Drug_UnitTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,35);\"", 0, edtavDdo_br_medication_drug_unittitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Medication_DetailPrompt.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Medication_DetailPrompt.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV12OrderedDsc), StringUtil.BoolToStr( AV12OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_Medication_DetailPrompt.htm");
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

      protected void START5S2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "选择药物治疗药物详情", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP5S0( ) ;
      }

      protected void WS5S2( )
      {
         START5S2( ) ;
         EVT5S2( ) ;
      }

      protected void EVT5S2( )
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
                           E115S2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E125S2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_DETAILID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E135S2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_SCHEMEID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E145S2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_DRUG_NAME.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E155S2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_DRUG_NUM.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E165S2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_DRUG_UNIT.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E175S2 ();
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
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV28Select)) ? AV38Select_GXI : context.convertURL( context.PathToRelativeUrl( AV28Select))), !bGXsfl_12_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "SrcSet", context.GetImageSrcSet( AV28Select), true);
                           A301BR_Medication_DetailID = (long)(context.localUtil.CToN( cgiGet( edtBR_Medication_DetailID_Internalname), ".", ","));
                           A296BR_Medication_SchemeID = (long)(context.localUtil.CToN( cgiGet( edtBR_Medication_SchemeID_Internalname), ".", ","));
                           n296BR_Medication_SchemeID = false;
                           A310BR_Medication_Drug_Name = cgiGet( edtBR_Medication_Drug_Name_Internalname);
                           n310BR_Medication_Drug_Name = false;
                           A311BR_Medication_Drug_Num = context.localUtil.CToN( cgiGet( edtBR_Medication_Drug_Num_Internalname), ".", ",");
                           n311BR_Medication_Drug_Num = false;
                           A312BR_Medication_Drug_Unit = cgiGet( edtBR_Medication_Drug_Unit_Internalname);
                           n312BR_Medication_Drug_Unit = false;
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E185S2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E195S2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E205S2 ();
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
                                       E215S2 ();
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

      protected void WE5S2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm5S2( ) ;
            }
         }
      }

      protected void PA5S2( )
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
               GX_FocusControl = edtavDdo_br_medication_detailidtitlecontrolidtoreplace_Internalname;
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
                                       String AV14ddo_BR_Medication_DetailIDTitleControlIdToReplace ,
                                       String AV16ddo_BR_Medication_SchemeIDTitleControlIdToReplace ,
                                       String AV30ddo_BR_Medication_Drug_NameTitleControlIdToReplace ,
                                       String AV32ddo_BR_Medication_Drug_NumTitleControlIdToReplace ,
                                       String AV34ddo_BR_Medication_Drug_UnitTitleControlIdToReplace )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF5S2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_MEDICATION_DETAILID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A301BR_Medication_DetailID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_MEDICATION_DETAILID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A301BR_Medication_DetailID), 18, 0, ".", "")));
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
         RF5S2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV37Pgmname = "BR_Medication_DetailPrompt";
         context.Gx_err = 0;
      }

      protected void RF5S2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 12;
         /* Execute user event: Refresh */
         E195S2 ();
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
            /* Using cursor H005S2 */
            pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_12_idx = 1;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A312BR_Medication_Drug_Unit = H005S2_A312BR_Medication_Drug_Unit[0];
               n312BR_Medication_Drug_Unit = H005S2_n312BR_Medication_Drug_Unit[0];
               A311BR_Medication_Drug_Num = H005S2_A311BR_Medication_Drug_Num[0];
               n311BR_Medication_Drug_Num = H005S2_n311BR_Medication_Drug_Num[0];
               A310BR_Medication_Drug_Name = H005S2_A310BR_Medication_Drug_Name[0];
               n310BR_Medication_Drug_Name = H005S2_n310BR_Medication_Drug_Name[0];
               A296BR_Medication_SchemeID = H005S2_A296BR_Medication_SchemeID[0];
               n296BR_Medication_SchemeID = H005S2_n296BR_Medication_SchemeID[0];
               A301BR_Medication_DetailID = H005S2_A301BR_Medication_DetailID[0];
               E205S2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 12;
            WB5S0( ) ;
         }
         bGXsfl_12_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes5S2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_MEDICATION_DETAILID"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, context.localUtil.Format( (decimal)(A301BR_Medication_DetailID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         /* Using cursor H005S3 */
         pr_default.execute(1);
         GRID_nRecordCount = H005S3_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Medication_DetailIDTitleControlIdToReplace, AV16ddo_BR_Medication_SchemeIDTitleControlIdToReplace, AV30ddo_BR_Medication_Drug_NameTitleControlIdToReplace, AV32ddo_BR_Medication_Drug_NumTitleControlIdToReplace, AV34ddo_BR_Medication_Drug_UnitTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Medication_DetailIDTitleControlIdToReplace, AV16ddo_BR_Medication_SchemeIDTitleControlIdToReplace, AV30ddo_BR_Medication_Drug_NameTitleControlIdToReplace, AV32ddo_BR_Medication_Drug_NumTitleControlIdToReplace, AV34ddo_BR_Medication_Drug_UnitTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Medication_DetailIDTitleControlIdToReplace, AV16ddo_BR_Medication_SchemeIDTitleControlIdToReplace, AV30ddo_BR_Medication_Drug_NameTitleControlIdToReplace, AV32ddo_BR_Medication_Drug_NumTitleControlIdToReplace, AV34ddo_BR_Medication_Drug_UnitTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Medication_DetailIDTitleControlIdToReplace, AV16ddo_BR_Medication_SchemeIDTitleControlIdToReplace, AV30ddo_BR_Medication_Drug_NameTitleControlIdToReplace, AV32ddo_BR_Medication_Drug_NumTitleControlIdToReplace, AV34ddo_BR_Medication_Drug_UnitTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Medication_DetailIDTitleControlIdToReplace, AV16ddo_BR_Medication_SchemeIDTitleControlIdToReplace, AV30ddo_BR_Medication_Drug_NameTitleControlIdToReplace, AV32ddo_BR_Medication_Drug_NumTitleControlIdToReplace, AV34ddo_BR_Medication_Drug_UnitTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP5S0( )
      {
         /* Before Start, stand alone formulas. */
         AV37Pgmname = "BR_Medication_DetailPrompt";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E185S2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV23DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_DETAILIDTITLEFILTERDATA"), AV13BR_Medication_DetailIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA"), AV15BR_Medication_SchemeIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA"), AV29BR_Medication_Drug_NameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA"), AV31BR_Medication_Drug_NumTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA"), AV33BR_Medication_Drug_UnitTitleFilterData);
            /* Read variables values. */
            AV14ddo_BR_Medication_DetailIDTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_detailidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_BR_Medication_DetailIDTitleControlIdToReplace", AV14ddo_BR_Medication_DetailIDTitleControlIdToReplace);
            AV16ddo_BR_Medication_SchemeIDTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_BR_Medication_SchemeIDTitleControlIdToReplace", AV16ddo_BR_Medication_SchemeIDTitleControlIdToReplace);
            AV30ddo_BR_Medication_Drug_NameTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_drug_nametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30ddo_BR_Medication_Drug_NameTitleControlIdToReplace", AV30ddo_BR_Medication_Drug_NameTitleControlIdToReplace);
            AV32ddo_BR_Medication_Drug_NumTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_drug_numtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32ddo_BR_Medication_Drug_NumTitleControlIdToReplace", AV32ddo_BR_Medication_Drug_NumTitleControlIdToReplace);
            AV34ddo_BR_Medication_Drug_UnitTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_drug_unittitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34ddo_BR_Medication_Drug_UnitTitleControlIdToReplace", AV34ddo_BR_Medication_Drug_UnitTitleControlIdToReplace);
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
            Ddo_br_medication_detailid_Caption = cgiGet( "DDO_BR_MEDICATION_DETAILID_Caption");
            Ddo_br_medication_detailid_Tooltip = cgiGet( "DDO_BR_MEDICATION_DETAILID_Tooltip");
            Ddo_br_medication_detailid_Cls = cgiGet( "DDO_BR_MEDICATION_DETAILID_Cls");
            Ddo_br_medication_detailid_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_DETAILID_Dropdownoptionstype");
            Ddo_br_medication_detailid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_DETAILID_Titlecontrolidtoreplace");
            Ddo_br_medication_detailid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DETAILID_Includesortasc"));
            Ddo_br_medication_detailid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DETAILID_Includesortdsc"));
            Ddo_br_medication_detailid_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_DETAILID_Sortedstatus");
            Ddo_br_medication_detailid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DETAILID_Includefilter"));
            Ddo_br_medication_detailid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DETAILID_Includedatalist"));
            Ddo_br_medication_detailid_Sortasc = cgiGet( "DDO_BR_MEDICATION_DETAILID_Sortasc");
            Ddo_br_medication_detailid_Sortdsc = cgiGet( "DDO_BR_MEDICATION_DETAILID_Sortdsc");
            Ddo_br_medication_detailid_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_DETAILID_Searchbuttontext");
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
            Ddo_br_medication_drug_name_Caption = cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Caption");
            Ddo_br_medication_drug_name_Tooltip = cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Tooltip");
            Ddo_br_medication_drug_name_Cls = cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Cls");
            Ddo_br_medication_drug_name_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Dropdownoptionstype");
            Ddo_br_medication_drug_name_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Titlecontrolidtoreplace");
            Ddo_br_medication_drug_name_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Includesortasc"));
            Ddo_br_medication_drug_name_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Includesortdsc"));
            Ddo_br_medication_drug_name_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Sortedstatus");
            Ddo_br_medication_drug_name_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Includefilter"));
            Ddo_br_medication_drug_name_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Includedatalist"));
            Ddo_br_medication_drug_name_Sortasc = cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Sortasc");
            Ddo_br_medication_drug_name_Sortdsc = cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Sortdsc");
            Ddo_br_medication_drug_name_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Searchbuttontext");
            Ddo_br_medication_drug_num_Caption = cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Caption");
            Ddo_br_medication_drug_num_Tooltip = cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Tooltip");
            Ddo_br_medication_drug_num_Cls = cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Cls");
            Ddo_br_medication_drug_num_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Dropdownoptionstype");
            Ddo_br_medication_drug_num_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Titlecontrolidtoreplace");
            Ddo_br_medication_drug_num_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Includesortasc"));
            Ddo_br_medication_drug_num_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Includesortdsc"));
            Ddo_br_medication_drug_num_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Sortedstatus");
            Ddo_br_medication_drug_num_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Includefilter"));
            Ddo_br_medication_drug_num_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Includedatalist"));
            Ddo_br_medication_drug_num_Sortasc = cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Sortasc");
            Ddo_br_medication_drug_num_Sortdsc = cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Sortdsc");
            Ddo_br_medication_drug_num_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Searchbuttontext");
            Ddo_br_medication_drug_unit_Caption = cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Caption");
            Ddo_br_medication_drug_unit_Tooltip = cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Tooltip");
            Ddo_br_medication_drug_unit_Cls = cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Cls");
            Ddo_br_medication_drug_unit_Dropdownoptionstype = cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Dropdownoptionstype");
            Ddo_br_medication_drug_unit_Titlecontrolidtoreplace = cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Titlecontrolidtoreplace");
            Ddo_br_medication_drug_unit_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Includesortasc"));
            Ddo_br_medication_drug_unit_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Includesortdsc"));
            Ddo_br_medication_drug_unit_Sortedstatus = cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Sortedstatus");
            Ddo_br_medication_drug_unit_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Includefilter"));
            Ddo_br_medication_drug_unit_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Includedatalist"));
            Ddo_br_medication_drug_unit_Sortasc = cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Sortasc");
            Ddo_br_medication_drug_unit_Sortdsc = cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Sortdsc");
            Ddo_br_medication_drug_unit_Searchbuttontext = cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_medication_detailid_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_DETAILID_Activeeventkey");
            Ddo_br_medication_schemeid_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_SCHEMEID_Activeeventkey");
            Ddo_br_medication_drug_name_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_DRUG_NAME_Activeeventkey");
            Ddo_br_medication_drug_num_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_DRUG_NUM_Activeeventkey");
            Ddo_br_medication_drug_unit_Activeeventkey = cgiGet( "DDO_BR_MEDICATION_DRUG_UNIT_Activeeventkey");
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
         E185S2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E185S2( )
      {
         /* Start Routine */
         GXt_boolean1 = AV5IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Medication_Detail", out  GXt_boolean1) ;
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
         Ddo_br_medication_detailid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_DetailID";
         ucDdo_br_medication_detailid.SendProperty(context, "", false, Ddo_br_medication_detailid_Internalname, "TitleControlIdToReplace", Ddo_br_medication_detailid_Titlecontrolidtoreplace);
         AV14ddo_BR_Medication_DetailIDTitleControlIdToReplace = Ddo_br_medication_detailid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_BR_Medication_DetailIDTitleControlIdToReplace", AV14ddo_BR_Medication_DetailIDTitleControlIdToReplace);
         edtavDdo_br_medication_detailidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_detailidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_detailidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_schemeid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_SchemeID";
         ucDdo_br_medication_schemeid.SendProperty(context, "", false, Ddo_br_medication_schemeid_Internalname, "TitleControlIdToReplace", Ddo_br_medication_schemeid_Titlecontrolidtoreplace);
         AV16ddo_BR_Medication_SchemeIDTitleControlIdToReplace = Ddo_br_medication_schemeid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_BR_Medication_SchemeIDTitleControlIdToReplace", AV16ddo_BR_Medication_SchemeIDTitleControlIdToReplace);
         edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_drug_name_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_Drug_Name";
         ucDdo_br_medication_drug_name.SendProperty(context, "", false, Ddo_br_medication_drug_name_Internalname, "TitleControlIdToReplace", Ddo_br_medication_drug_name_Titlecontrolidtoreplace);
         AV30ddo_BR_Medication_Drug_NameTitleControlIdToReplace = Ddo_br_medication_drug_name_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30ddo_BR_Medication_Drug_NameTitleControlIdToReplace", AV30ddo_BR_Medication_Drug_NameTitleControlIdToReplace);
         edtavDdo_br_medication_drug_nametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_drug_nametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_drug_nametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_drug_num_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_Drug_Num";
         ucDdo_br_medication_drug_num.SendProperty(context, "", false, Ddo_br_medication_drug_num_Internalname, "TitleControlIdToReplace", Ddo_br_medication_drug_num_Titlecontrolidtoreplace);
         AV32ddo_BR_Medication_Drug_NumTitleControlIdToReplace = Ddo_br_medication_drug_num_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32ddo_BR_Medication_Drug_NumTitleControlIdToReplace", AV32ddo_BR_Medication_Drug_NumTitleControlIdToReplace);
         edtavDdo_br_medication_drug_numtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_drug_numtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_drug_numtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_drug_unit_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_Drug_Unit";
         ucDdo_br_medication_drug_unit.SendProperty(context, "", false, Ddo_br_medication_drug_unit_Internalname, "TitleControlIdToReplace", Ddo_br_medication_drug_unit_Titlecontrolidtoreplace);
         AV34ddo_BR_Medication_Drug_UnitTitleControlIdToReplace = Ddo_br_medication_drug_unit_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34ddo_BR_Medication_Drug_UnitTitleControlIdToReplace", AV34ddo_BR_Medication_Drug_UnitTitleControlIdToReplace);
         edtavDdo_br_medication_drug_unittitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_medication_drug_unittitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_drug_unittitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "选择药物治疗药物详情";
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

      protected void E195S2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV13BR_Medication_DetailIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15BR_Medication_SchemeIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV29BR_Medication_Drug_NameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV31BR_Medication_Drug_NumTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV33BR_Medication_Drug_UnitTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         edtBR_Medication_DetailID_Titleformat = 2;
         edtBR_Medication_DetailID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "药物治疗药物详情主键", AV14ddo_BR_Medication_DetailIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_DetailID_Internalname, "Title", edtBR_Medication_DetailID_Title, !bGXsfl_12_Refreshing);
         edtBR_Medication_SchemeID_Titleformat = 2;
         edtBR_Medication_SchemeID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "药物治疗化疗方案主键", AV16ddo_BR_Medication_SchemeIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_SchemeID_Internalname, "Title", edtBR_Medication_SchemeID_Title, !bGXsfl_12_Refreshing);
         edtBR_Medication_Drug_Name_Titleformat = 2;
         edtBR_Medication_Drug_Name_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "药物名称", AV30ddo_BR_Medication_Drug_NameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_Drug_Name_Internalname, "Title", edtBR_Medication_Drug_Name_Title, !bGXsfl_12_Refreshing);
         edtBR_Medication_Drug_Num_Titleformat = 2;
         edtBR_Medication_Drug_Num_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "数量", AV32ddo_BR_Medication_Drug_NumTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_Drug_Num_Internalname, "Title", edtBR_Medication_Drug_Num_Title, !bGXsfl_12_Refreshing);
         edtBR_Medication_Drug_Unit_Titleformat = 2;
         edtBR_Medication_Drug_Unit_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "单位", AV34ddo_BR_Medication_Drug_UnitTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_Drug_Unit_Internalname, "Title", edtBR_Medication_Drug_Unit_Title, !bGXsfl_12_Refreshing);
         AV25GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25GridCurrentPage), 10, 0)));
         AV26GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26GridPageSize), 10, 0)));
         AV27GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV27GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Medication_DetailIDTitleFilterData", AV13BR_Medication_DetailIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_Medication_SchemeIDTitleFilterData", AV15BR_Medication_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_Medication_Drug_NameTitleFilterData", AV29BR_Medication_Drug_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_Medication_Drug_NumTitleFilterData", AV31BR_Medication_Drug_NumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_Medication_Drug_UnitTitleFilterData", AV33BR_Medication_Drug_UnitTitleFilterData);
      }

      protected void E115S2( )
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

      protected void E125S2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E135S2( )
      {
         /* Ddo_br_medication_detailid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_detailid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medication_detailid_Sortedstatus = "ASC";
            ucDdo_br_medication_detailid.SendProperty(context, "", false, Ddo_br_medication_detailid_Internalname, "SortedStatus", Ddo_br_medication_detailid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_detailid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medication_detailid_Sortedstatus = "DSC";
            ucDdo_br_medication_detailid.SendProperty(context, "", false, Ddo_br_medication_detailid_Internalname, "SortedStatus", Ddo_br_medication_detailid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Medication_DetailIDTitleFilterData", AV13BR_Medication_DetailIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_Medication_SchemeIDTitleFilterData", AV15BR_Medication_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_Medication_Drug_NameTitleFilterData", AV29BR_Medication_Drug_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_Medication_Drug_NumTitleFilterData", AV31BR_Medication_Drug_NumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_Medication_Drug_UnitTitleFilterData", AV33BR_Medication_Drug_UnitTitleFilterData);
      }

      protected void E145S2( )
      {
         /* Ddo_br_medication_schemeid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_schemeid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 2;
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
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medication_schemeid_Sortedstatus = "DSC";
            ucDdo_br_medication_schemeid.SendProperty(context, "", false, Ddo_br_medication_schemeid_Internalname, "SortedStatus", Ddo_br_medication_schemeid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Medication_DetailIDTitleFilterData", AV13BR_Medication_DetailIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_Medication_SchemeIDTitleFilterData", AV15BR_Medication_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_Medication_Drug_NameTitleFilterData", AV29BR_Medication_Drug_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_Medication_Drug_NumTitleFilterData", AV31BR_Medication_Drug_NumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_Medication_Drug_UnitTitleFilterData", AV33BR_Medication_Drug_UnitTitleFilterData);
      }

      protected void E155S2( )
      {
         /* Ddo_br_medication_drug_name_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_drug_name_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medication_drug_name_Sortedstatus = "ASC";
            ucDdo_br_medication_drug_name.SendProperty(context, "", false, Ddo_br_medication_drug_name_Internalname, "SortedStatus", Ddo_br_medication_drug_name_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_drug_name_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medication_drug_name_Sortedstatus = "DSC";
            ucDdo_br_medication_drug_name.SendProperty(context, "", false, Ddo_br_medication_drug_name_Internalname, "SortedStatus", Ddo_br_medication_drug_name_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Medication_DetailIDTitleFilterData", AV13BR_Medication_DetailIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_Medication_SchemeIDTitleFilterData", AV15BR_Medication_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_Medication_Drug_NameTitleFilterData", AV29BR_Medication_Drug_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_Medication_Drug_NumTitleFilterData", AV31BR_Medication_Drug_NumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_Medication_Drug_UnitTitleFilterData", AV33BR_Medication_Drug_UnitTitleFilterData);
      }

      protected void E165S2( )
      {
         /* Ddo_br_medication_drug_num_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_drug_num_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medication_drug_num_Sortedstatus = "ASC";
            ucDdo_br_medication_drug_num.SendProperty(context, "", false, Ddo_br_medication_drug_num_Internalname, "SortedStatus", Ddo_br_medication_drug_num_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_drug_num_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medication_drug_num_Sortedstatus = "DSC";
            ucDdo_br_medication_drug_num.SendProperty(context, "", false, Ddo_br_medication_drug_num_Internalname, "SortedStatus", Ddo_br_medication_drug_num_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Medication_DetailIDTitleFilterData", AV13BR_Medication_DetailIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_Medication_SchemeIDTitleFilterData", AV15BR_Medication_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_Medication_Drug_NameTitleFilterData", AV29BR_Medication_Drug_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_Medication_Drug_NumTitleFilterData", AV31BR_Medication_Drug_NumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_Medication_Drug_UnitTitleFilterData", AV33BR_Medication_Drug_UnitTitleFilterData);
      }

      protected void E175S2( )
      {
         /* Ddo_br_medication_drug_unit_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_drug_unit_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medication_drug_unit_Sortedstatus = "ASC";
            ucDdo_br_medication_drug_unit.SendProperty(context, "", false, Ddo_br_medication_drug_unit_Internalname, "SortedStatus", Ddo_br_medication_drug_unit_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_drug_unit_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_medication_drug_unit_Sortedstatus = "DSC";
            ucDdo_br_medication_drug_unit.SendProperty(context, "", false, Ddo_br_medication_drug_unit_Internalname, "SortedStatus", Ddo_br_medication_drug_unit_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Medication_DetailIDTitleFilterData", AV13BR_Medication_DetailIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_Medication_SchemeIDTitleFilterData", AV15BR_Medication_SchemeIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_Medication_Drug_NameTitleFilterData", AV29BR_Medication_Drug_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_Medication_Drug_NumTitleFilterData", AV31BR_Medication_Drug_NumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_Medication_Drug_UnitTitleFilterData", AV33BR_Medication_Drug_UnitTitleFilterData);
      }

      private void E205S2( )
      {
         /* Grid_Load Routine */
         AV28Select = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSelect_Internalname, AV28Select);
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
         E215S2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E215S2( )
      {
         /* Enter Routine */
         AV8InOutBR_Medication_DetailID = A301BR_Medication_DetailID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_Medication_DetailID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_Medication_DetailID), 18, 0)));
         context.setWebReturnParms(new Object[] {(long)AV8InOutBR_Medication_DetailID});
         context.setWebReturnParmsMetadata(new Object[] {"AV8InOutBR_Medication_DetailID"});
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
         AV8InOutBR_Medication_DetailID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_Medication_DetailID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_Medication_DetailID), 18, 0)));
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
         PA5S2( ) ;
         WS5S2( ) ;
         WE5S2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022815143119", true);
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
         context.AddJavascriptSource("br_medication_detailprompt.js", "?202022815143119", false);
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
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_idx;
         edtBR_Medication_DetailID_Internalname = "BR_MEDICATION_DETAILID_"+sGXsfl_12_idx;
         edtBR_Medication_SchemeID_Internalname = "BR_MEDICATION_SCHEMEID_"+sGXsfl_12_idx;
         edtBR_Medication_Drug_Name_Internalname = "BR_MEDICATION_DRUG_NAME_"+sGXsfl_12_idx;
         edtBR_Medication_Drug_Num_Internalname = "BR_MEDICATION_DRUG_NUM_"+sGXsfl_12_idx;
         edtBR_Medication_Drug_Unit_Internalname = "BR_MEDICATION_DRUG_UNIT_"+sGXsfl_12_idx;
      }

      protected void SubsflControlProps_fel_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_fel_idx;
         edtBR_Medication_DetailID_Internalname = "BR_MEDICATION_DETAILID_"+sGXsfl_12_fel_idx;
         edtBR_Medication_SchemeID_Internalname = "BR_MEDICATION_SCHEMEID_"+sGXsfl_12_fel_idx;
         edtBR_Medication_Drug_Name_Internalname = "BR_MEDICATION_DRUG_NAME_"+sGXsfl_12_fel_idx;
         edtBR_Medication_Drug_Num_Internalname = "BR_MEDICATION_DRUG_NUM_"+sGXsfl_12_fel_idx;
         edtBR_Medication_Drug_Unit_Internalname = "BR_MEDICATION_DRUG_UNIT_"+sGXsfl_12_fel_idx;
      }

      protected void sendrow_122( )
      {
         SubsflControlProps_122( ) ;
         WB5S0( ) ;
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
            AV28Select_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV28Select))&&String.IsNullOrEmpty(StringUtil.RTrim( AV38Select_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV28Select)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV28Select)) ? AV38Select_GXI : context.PathToRelativeUrl( AV28Select));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSelect_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSelect_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSelect_Jsonclick,"'"+""+"'"+",false,"+"'"+"EENTER."+sGXsfl_12_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV28Select_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_DetailID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A301BR_Medication_DetailID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A301BR_Medication_DetailID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_DetailID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
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
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_Drug_Name_Internalname,(String)A310BR_Medication_Drug_Name,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_Drug_Name_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_Drug_Num_Internalname,StringUtil.LTrim( StringUtil.NToC( A311BR_Medication_Drug_Num, 15, 5, ".", "")),context.localUtil.Format( A311BR_Medication_Drug_Num, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_Drug_Num_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_Drug_Unit_Internalname,(String)A312BR_Medication_Drug_Unit,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_Drug_Unit_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes5S2( ) ;
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
         edtBR_Medication_DetailID_Internalname = "BR_MEDICATION_DETAILID";
         edtBR_Medication_SchemeID_Internalname = "BR_MEDICATION_SCHEMEID";
         edtBR_Medication_Drug_Name_Internalname = "BR_MEDICATION_DRUG_NAME";
         edtBR_Medication_Drug_Num_Internalname = "BR_MEDICATION_DRUG_NUM";
         edtBR_Medication_Drug_Unit_Internalname = "BR_MEDICATION_DRUG_UNIT";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_medication_detailid_Internalname = "DDO_BR_MEDICATION_DETAILID";
         edtavDdo_br_medication_detailidtitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE";
         Ddo_br_medication_schemeid_Internalname = "DDO_BR_MEDICATION_SCHEMEID";
         edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE";
         Ddo_br_medication_drug_name_Internalname = "DDO_BR_MEDICATION_DRUG_NAME";
         edtavDdo_br_medication_drug_nametitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE";
         Ddo_br_medication_drug_num_Internalname = "DDO_BR_MEDICATION_DRUG_NUM";
         edtavDdo_br_medication_drug_numtitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE";
         Ddo_br_medication_drug_unit_Internalname = "DDO_BR_MEDICATION_DRUG_UNIT";
         edtavDdo_br_medication_drug_unittitlecontrolidtoreplace_Internalname = "vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE";
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
         edtBR_Medication_Drug_Unit_Jsonclick = "";
         edtBR_Medication_Drug_Num_Jsonclick = "";
         edtBR_Medication_Drug_Name_Jsonclick = "";
         edtBR_Medication_SchemeID_Jsonclick = "";
         edtBR_Medication_DetailID_Jsonclick = "";
         edtavSelect_Jsonclick = "";
         edtavSelect_Visible = -1;
         edtavSelect_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_medication_drug_unittitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medication_drug_numtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medication_drug_nametitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medication_detailidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavSelect_Tooltiptext = "选择";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Medication_Drug_Unit_Titleformat = 0;
         edtBR_Medication_Drug_Unit_Title = "单位";
         edtBR_Medication_Drug_Num_Titleformat = 0;
         edtBR_Medication_Drug_Num_Title = "数量";
         edtBR_Medication_Drug_Name_Titleformat = 0;
         edtBR_Medication_Drug_Name_Title = "药物名称";
         edtBR_Medication_SchemeID_Titleformat = 0;
         edtBR_Medication_SchemeID_Title = "药物治疗化疗方案主键";
         edtBR_Medication_DetailID_Titleformat = 0;
         edtBR_Medication_DetailID_Title = "药物治疗药物详情主键";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         divTablemain_Height = 0;
         Ddo_br_medication_drug_unit_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_drug_unit_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_drug_unit_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_drug_unit_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medication_drug_unit_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medication_drug_unit_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_drug_unit_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_drug_unit_Titlecontrolidtoreplace = "";
         Ddo_br_medication_drug_unit_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_drug_unit_Cls = "ColumnSettings";
         Ddo_br_medication_drug_unit_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_drug_unit_Caption = "";
         Ddo_br_medication_drug_num_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_drug_num_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_drug_num_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_drug_num_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medication_drug_num_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medication_drug_num_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_drug_num_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_drug_num_Titlecontrolidtoreplace = "";
         Ddo_br_medication_drug_num_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_drug_num_Cls = "ColumnSettings";
         Ddo_br_medication_drug_num_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_drug_num_Caption = "";
         Ddo_br_medication_drug_name_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_drug_name_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_drug_name_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_drug_name_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medication_drug_name_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medication_drug_name_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_drug_name_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_drug_name_Titlecontrolidtoreplace = "";
         Ddo_br_medication_drug_name_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_drug_name_Cls = "ColumnSettings";
         Ddo_br_medication_drug_name_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_drug_name_Caption = "";
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
         Ddo_br_medication_detailid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_detailid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_detailid_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_detailid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medication_detailid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medication_detailid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_detailid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_detailid_Titlecontrolidtoreplace = "";
         Ddo_br_medication_detailid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_detailid_Cls = "ColumnSettings";
         Ddo_br_medication_detailid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_detailid_Caption = "";
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
         Form.Caption = "选择药物治疗药物详情";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Medication_DetailIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV13BR_Medication_DetailIDTitleFilterData',fld:'vBR_MEDICATION_DETAILIDTITLEFILTERDATA',pic:''},{av:'AV15BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV29BR_Medication_Drug_NameTitleFilterData',fld:'vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA',pic:''},{av:'AV31BR_Medication_Drug_NumTitleFilterData',fld:'vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA',pic:''},{av:'AV33BR_Medication_Drug_UnitTitleFilterData',fld:'vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA',pic:''},{av:'edtBR_Medication_DetailID_Titleformat',ctrl:'BR_MEDICATION_DETAILID',prop:'Titleformat'},{av:'edtBR_Medication_DetailID_Title',ctrl:'BR_MEDICATION_DETAILID',prop:'Title'},{av:'edtBR_Medication_SchemeID_Titleformat',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'edtBR_Medication_SchemeID_Title',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{av:'edtBR_Medication_Drug_Name_Titleformat',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Name_Title',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Title'},{av:'edtBR_Medication_Drug_Num_Titleformat',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Num_Title',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Title'},{av:'edtBR_Medication_Drug_Unit_Titleformat',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Unit_Title',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Title'},{av:'AV25GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV26GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV27GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E115S2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Medication_DetailIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E125S2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Medication_DetailIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_MEDICATION_DETAILID.ONOPTIONCLICKED","{handler:'E135S2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Medication_DetailIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medication_detailid_Activeeventkey',ctrl:'DDO_BR_MEDICATION_DETAILID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICATION_DETAILID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_detailid_Sortedstatus',ctrl:'DDO_BR_MEDICATION_DETAILID',prop:'SortedStatus'},{av:'AV13BR_Medication_DetailIDTitleFilterData',fld:'vBR_MEDICATION_DETAILIDTITLEFILTERDATA',pic:''},{av:'AV15BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV29BR_Medication_Drug_NameTitleFilterData',fld:'vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA',pic:''},{av:'AV31BR_Medication_Drug_NumTitleFilterData',fld:'vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA',pic:''},{av:'AV33BR_Medication_Drug_UnitTitleFilterData',fld:'vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA',pic:''},{av:'edtBR_Medication_DetailID_Titleformat',ctrl:'BR_MEDICATION_DETAILID',prop:'Titleformat'},{av:'edtBR_Medication_DetailID_Title',ctrl:'BR_MEDICATION_DETAILID',prop:'Title'},{av:'edtBR_Medication_SchemeID_Titleformat',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'edtBR_Medication_SchemeID_Title',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{av:'edtBR_Medication_Drug_Name_Titleformat',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Name_Title',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Title'},{av:'edtBR_Medication_Drug_Num_Titleformat',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Num_Title',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Title'},{av:'edtBR_Medication_Drug_Unit_Titleformat',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Unit_Title',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Title'},{av:'AV25GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV26GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV27GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICATION_SCHEMEID.ONOPTIONCLICKED","{handler:'E145S2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Medication_DetailIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medication_schemeid_Activeeventkey',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICATION_SCHEMEID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_schemeid_Sortedstatus',ctrl:'DDO_BR_MEDICATION_SCHEMEID',prop:'SortedStatus'},{av:'AV13BR_Medication_DetailIDTitleFilterData',fld:'vBR_MEDICATION_DETAILIDTITLEFILTERDATA',pic:''},{av:'AV15BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV29BR_Medication_Drug_NameTitleFilterData',fld:'vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA',pic:''},{av:'AV31BR_Medication_Drug_NumTitleFilterData',fld:'vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA',pic:''},{av:'AV33BR_Medication_Drug_UnitTitleFilterData',fld:'vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA',pic:''},{av:'edtBR_Medication_DetailID_Titleformat',ctrl:'BR_MEDICATION_DETAILID',prop:'Titleformat'},{av:'edtBR_Medication_DetailID_Title',ctrl:'BR_MEDICATION_DETAILID',prop:'Title'},{av:'edtBR_Medication_SchemeID_Titleformat',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'edtBR_Medication_SchemeID_Title',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{av:'edtBR_Medication_Drug_Name_Titleformat',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Name_Title',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Title'},{av:'edtBR_Medication_Drug_Num_Titleformat',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Num_Title',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Title'},{av:'edtBR_Medication_Drug_Unit_Titleformat',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Unit_Title',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Title'},{av:'AV25GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV26GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV27GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICATION_DRUG_NAME.ONOPTIONCLICKED","{handler:'E155S2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Medication_DetailIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medication_drug_name_Activeeventkey',ctrl:'DDO_BR_MEDICATION_DRUG_NAME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICATION_DRUG_NAME.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_drug_name_Sortedstatus',ctrl:'DDO_BR_MEDICATION_DRUG_NAME',prop:'SortedStatus'},{av:'AV13BR_Medication_DetailIDTitleFilterData',fld:'vBR_MEDICATION_DETAILIDTITLEFILTERDATA',pic:''},{av:'AV15BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV29BR_Medication_Drug_NameTitleFilterData',fld:'vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA',pic:''},{av:'AV31BR_Medication_Drug_NumTitleFilterData',fld:'vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA',pic:''},{av:'AV33BR_Medication_Drug_UnitTitleFilterData',fld:'vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA',pic:''},{av:'edtBR_Medication_DetailID_Titleformat',ctrl:'BR_MEDICATION_DETAILID',prop:'Titleformat'},{av:'edtBR_Medication_DetailID_Title',ctrl:'BR_MEDICATION_DETAILID',prop:'Title'},{av:'edtBR_Medication_SchemeID_Titleformat',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'edtBR_Medication_SchemeID_Title',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{av:'edtBR_Medication_Drug_Name_Titleformat',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Name_Title',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Title'},{av:'edtBR_Medication_Drug_Num_Titleformat',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Num_Title',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Title'},{av:'edtBR_Medication_Drug_Unit_Titleformat',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Unit_Title',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Title'},{av:'AV25GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV26GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV27GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICATION_DRUG_NUM.ONOPTIONCLICKED","{handler:'E165S2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Medication_DetailIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medication_drug_num_Activeeventkey',ctrl:'DDO_BR_MEDICATION_DRUG_NUM',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICATION_DRUG_NUM.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_drug_num_Sortedstatus',ctrl:'DDO_BR_MEDICATION_DRUG_NUM',prop:'SortedStatus'},{av:'AV13BR_Medication_DetailIDTitleFilterData',fld:'vBR_MEDICATION_DETAILIDTITLEFILTERDATA',pic:''},{av:'AV15BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV29BR_Medication_Drug_NameTitleFilterData',fld:'vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA',pic:''},{av:'AV31BR_Medication_Drug_NumTitleFilterData',fld:'vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA',pic:''},{av:'AV33BR_Medication_Drug_UnitTitleFilterData',fld:'vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA',pic:''},{av:'edtBR_Medication_DetailID_Titleformat',ctrl:'BR_MEDICATION_DETAILID',prop:'Titleformat'},{av:'edtBR_Medication_DetailID_Title',ctrl:'BR_MEDICATION_DETAILID',prop:'Title'},{av:'edtBR_Medication_SchemeID_Titleformat',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'edtBR_Medication_SchemeID_Title',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{av:'edtBR_Medication_Drug_Name_Titleformat',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Name_Title',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Title'},{av:'edtBR_Medication_Drug_Num_Titleformat',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Num_Title',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Title'},{av:'edtBR_Medication_Drug_Unit_Titleformat',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Unit_Title',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Title'},{av:'AV25GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV26GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV27GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_MEDICATION_DRUG_UNIT.ONOPTIONCLICKED","{handler:'E175S2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Medication_DetailIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DETAILIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_Medication_SchemeIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_SCHEMEIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Medication_Drug_NameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_Medication_Drug_NumTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_NUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Medication_Drug_UnitTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_DRUG_UNITTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_medication_drug_unit_Activeeventkey',ctrl:'DDO_BR_MEDICATION_DRUG_UNIT',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICATION_DRUG_UNIT.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_drug_unit_Sortedstatus',ctrl:'DDO_BR_MEDICATION_DRUG_UNIT',prop:'SortedStatus'},{av:'AV13BR_Medication_DetailIDTitleFilterData',fld:'vBR_MEDICATION_DETAILIDTITLEFILTERDATA',pic:''},{av:'AV15BR_Medication_SchemeIDTitleFilterData',fld:'vBR_MEDICATION_SCHEMEIDTITLEFILTERDATA',pic:''},{av:'AV29BR_Medication_Drug_NameTitleFilterData',fld:'vBR_MEDICATION_DRUG_NAMETITLEFILTERDATA',pic:''},{av:'AV31BR_Medication_Drug_NumTitleFilterData',fld:'vBR_MEDICATION_DRUG_NUMTITLEFILTERDATA',pic:''},{av:'AV33BR_Medication_Drug_UnitTitleFilterData',fld:'vBR_MEDICATION_DRUG_UNITTITLEFILTERDATA',pic:''},{av:'edtBR_Medication_DetailID_Titleformat',ctrl:'BR_MEDICATION_DETAILID',prop:'Titleformat'},{av:'edtBR_Medication_DetailID_Title',ctrl:'BR_MEDICATION_DETAILID',prop:'Title'},{av:'edtBR_Medication_SchemeID_Titleformat',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Titleformat'},{av:'edtBR_Medication_SchemeID_Title',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Title'},{av:'edtBR_Medication_Drug_Name_Titleformat',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Name_Title',ctrl:'BR_MEDICATION_DRUG_NAME',prop:'Title'},{av:'edtBR_Medication_Drug_Num_Titleformat',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Num_Title',ctrl:'BR_MEDICATION_DRUG_NUM',prop:'Title'},{av:'edtBR_Medication_Drug_Unit_Titleformat',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Titleformat'},{av:'edtBR_Medication_Drug_Unit_Title',ctrl:'BR_MEDICATION_DRUG_UNIT',prop:'Title'},{av:'AV25GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV26GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV27GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E205S2',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV28Select',fld:'vSELECT',pic:''},{av:'edtavSelect_Tooltiptext',ctrl:'vSELECT',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E215S2',iparms:[{av:'A301BR_Medication_DetailID',fld:'BR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV8InOutBR_Medication_DetailID',fld:'vINOUTBR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ'}]}");
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
         Ddo_br_medication_detailid_Activeeventkey = "";
         Ddo_br_medication_schemeid_Activeeventkey = "";
         Ddo_br_medication_drug_name_Activeeventkey = "";
         Ddo_br_medication_drug_num_Activeeventkey = "";
         Ddo_br_medication_drug_unit_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV14ddo_BR_Medication_DetailIDTitleControlIdToReplace = "";
         AV16ddo_BR_Medication_SchemeIDTitleControlIdToReplace = "";
         AV30ddo_BR_Medication_Drug_NameTitleControlIdToReplace = "";
         AV32ddo_BR_Medication_Drug_NumTitleControlIdToReplace = "";
         AV34ddo_BR_Medication_Drug_UnitTitleControlIdToReplace = "";
         GXKey = "";
         AV37Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV23DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV13BR_Medication_DetailIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15BR_Medication_SchemeIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV29BR_Medication_Drug_NameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV31BR_Medication_Drug_NumTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV33BR_Medication_Drug_UnitTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_medication_detailid_Sortedstatus = "";
         Ddo_br_medication_schemeid_Sortedstatus = "";
         Ddo_br_medication_drug_name_Sortedstatus = "";
         Ddo_br_medication_drug_num_Sortedstatus = "";
         Ddo_br_medication_drug_unit_Sortedstatus = "";
         GX_FocusControl = "";
         sPrefix = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV28Select = "";
         A310BR_Medication_Drug_Name = "";
         A312BR_Medication_Drug_Unit = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_medication_detailid = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_br_medication_schemeid = new GXUserControl();
         ucDdo_br_medication_drug_name = new GXUserControl();
         ucDdo_br_medication_drug_num = new GXUserControl();
         ucDdo_br_medication_drug_unit = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV38Select_GXI = "";
         scmdbuf = "";
         H005S2_A312BR_Medication_Drug_Unit = new String[] {""} ;
         H005S2_n312BR_Medication_Drug_Unit = new bool[] {false} ;
         H005S2_A311BR_Medication_Drug_Num = new decimal[1] ;
         H005S2_n311BR_Medication_Drug_Num = new bool[] {false} ;
         H005S2_A310BR_Medication_Drug_Name = new String[] {""} ;
         H005S2_n310BR_Medication_Drug_Name = new bool[] {false} ;
         H005S2_A296BR_Medication_SchemeID = new long[1] ;
         H005S2_n296BR_Medication_SchemeID = new bool[] {false} ;
         H005S2_A301BR_Medication_DetailID = new long[1] ;
         H005S3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_medication_detailprompt__default(),
            new Object[][] {
                new Object[] {
               H005S2_A312BR_Medication_Drug_Unit, H005S2_n312BR_Medication_Drug_Unit, H005S2_A311BR_Medication_Drug_Num, H005S2_n311BR_Medication_Drug_Num, H005S2_A310BR_Medication_Drug_Name, H005S2_n310BR_Medication_Drug_Name, H005S2_A296BR_Medication_SchemeID, H005S2_n296BR_Medication_SchemeID, H005S2_A301BR_Medication_DetailID
               }
               , new Object[] {
               H005S3_AGRID_nRecordCount
               }
            }
         );
         AV37Pgmname = "BR_Medication_DetailPrompt";
         /* GeneXus formulas. */
         AV37Pgmname = "BR_Medication_DetailPrompt";
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
      private short edtBR_Medication_DetailID_Titleformat ;
      private short edtBR_Medication_SchemeID_Titleformat ;
      private short edtBR_Medication_Drug_Name_Titleformat ;
      private short edtBR_Medication_Drug_Num_Titleformat ;
      private short edtBR_Medication_Drug_Unit_Titleformat ;
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
      private int edtavDdo_br_medication_detailidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medication_drug_nametitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medication_drug_numtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medication_drug_unittitlecontrolidtoreplace_Visible ;
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
      private long AV8InOutBR_Medication_DetailID ;
      private long wcpOAV8InOutBR_Medication_DetailID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV25GridCurrentPage ;
      private long AV27GridRecordCount ;
      private long AV26GridPageSize ;
      private long A301BR_Medication_DetailID ;
      private long A296BR_Medication_SchemeID ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private decimal A311BR_Medication_Drug_Num ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_medication_detailid_Activeeventkey ;
      private String Ddo_br_medication_schemeid_Activeeventkey ;
      private String Ddo_br_medication_drug_name_Activeeventkey ;
      private String Ddo_br_medication_drug_num_Activeeventkey ;
      private String Ddo_br_medication_drug_unit_Activeeventkey ;
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
      private String Ddo_br_medication_detailid_Caption ;
      private String Ddo_br_medication_detailid_Tooltip ;
      private String Ddo_br_medication_detailid_Cls ;
      private String Ddo_br_medication_detailid_Dropdownoptionstype ;
      private String Ddo_br_medication_detailid_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_detailid_Sortedstatus ;
      private String Ddo_br_medication_detailid_Sortasc ;
      private String Ddo_br_medication_detailid_Sortdsc ;
      private String Ddo_br_medication_detailid_Searchbuttontext ;
      private String Ddo_br_medication_schemeid_Caption ;
      private String Ddo_br_medication_schemeid_Tooltip ;
      private String Ddo_br_medication_schemeid_Cls ;
      private String Ddo_br_medication_schemeid_Dropdownoptionstype ;
      private String Ddo_br_medication_schemeid_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_schemeid_Sortedstatus ;
      private String Ddo_br_medication_schemeid_Sortasc ;
      private String Ddo_br_medication_schemeid_Sortdsc ;
      private String Ddo_br_medication_schemeid_Searchbuttontext ;
      private String Ddo_br_medication_drug_name_Caption ;
      private String Ddo_br_medication_drug_name_Tooltip ;
      private String Ddo_br_medication_drug_name_Cls ;
      private String Ddo_br_medication_drug_name_Dropdownoptionstype ;
      private String Ddo_br_medication_drug_name_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_drug_name_Sortedstatus ;
      private String Ddo_br_medication_drug_name_Sortasc ;
      private String Ddo_br_medication_drug_name_Sortdsc ;
      private String Ddo_br_medication_drug_name_Searchbuttontext ;
      private String Ddo_br_medication_drug_num_Caption ;
      private String Ddo_br_medication_drug_num_Tooltip ;
      private String Ddo_br_medication_drug_num_Cls ;
      private String Ddo_br_medication_drug_num_Dropdownoptionstype ;
      private String Ddo_br_medication_drug_num_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_drug_num_Sortedstatus ;
      private String Ddo_br_medication_drug_num_Sortasc ;
      private String Ddo_br_medication_drug_num_Sortdsc ;
      private String Ddo_br_medication_drug_num_Searchbuttontext ;
      private String Ddo_br_medication_drug_unit_Caption ;
      private String Ddo_br_medication_drug_unit_Tooltip ;
      private String Ddo_br_medication_drug_unit_Cls ;
      private String Ddo_br_medication_drug_unit_Dropdownoptionstype ;
      private String Ddo_br_medication_drug_unit_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_drug_unit_Sortedstatus ;
      private String Ddo_br_medication_drug_unit_Sortasc ;
      private String Ddo_br_medication_drug_unit_Sortdsc ;
      private String Ddo_br_medication_drug_unit_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtBR_Medication_DetailID_Title ;
      private String edtBR_Medication_SchemeID_Title ;
      private String edtBR_Medication_Drug_Name_Title ;
      private String edtBR_Medication_Drug_Num_Title ;
      private String edtBR_Medication_Drug_Unit_Title ;
      private String subGrid_Header ;
      private String edtavSelect_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_medication_detailid_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_br_medication_detailidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medication_schemeid_Internalname ;
      private String edtavDdo_br_medication_schemeidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medication_drug_name_Internalname ;
      private String edtavDdo_br_medication_drug_nametitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medication_drug_num_Internalname ;
      private String edtavDdo_br_medication_drug_numtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medication_drug_unit_Internalname ;
      private String edtavDdo_br_medication_drug_unittitlecontrolidtoreplace_Internalname ;
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
      private String edtBR_Medication_DetailID_Internalname ;
      private String edtBR_Medication_SchemeID_Internalname ;
      private String edtBR_Medication_Drug_Name_Internalname ;
      private String edtBR_Medication_Drug_Num_Internalname ;
      private String edtBR_Medication_Drug_Unit_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_12_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavSelect_Jsonclick ;
      private String ROClassString ;
      private String edtBR_Medication_DetailID_Jsonclick ;
      private String edtBR_Medication_SchemeID_Jsonclick ;
      private String edtBR_Medication_Drug_Name_Jsonclick ;
      private String edtBR_Medication_Drug_Num_Jsonclick ;
      private String edtBR_Medication_Drug_Unit_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV12OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_br_medication_detailid_Includesortasc ;
      private bool Ddo_br_medication_detailid_Includesortdsc ;
      private bool Ddo_br_medication_detailid_Includefilter ;
      private bool Ddo_br_medication_detailid_Includedatalist ;
      private bool Ddo_br_medication_schemeid_Includesortasc ;
      private bool Ddo_br_medication_schemeid_Includesortdsc ;
      private bool Ddo_br_medication_schemeid_Includefilter ;
      private bool Ddo_br_medication_schemeid_Includedatalist ;
      private bool Ddo_br_medication_drug_name_Includesortasc ;
      private bool Ddo_br_medication_drug_name_Includesortdsc ;
      private bool Ddo_br_medication_drug_name_Includefilter ;
      private bool Ddo_br_medication_drug_name_Includedatalist ;
      private bool Ddo_br_medication_drug_num_Includesortasc ;
      private bool Ddo_br_medication_drug_num_Includesortdsc ;
      private bool Ddo_br_medication_drug_num_Includefilter ;
      private bool Ddo_br_medication_drug_num_Includedatalist ;
      private bool Ddo_br_medication_drug_unit_Includesortasc ;
      private bool Ddo_br_medication_drug_unit_Includesortdsc ;
      private bool Ddo_br_medication_drug_unit_Includefilter ;
      private bool Ddo_br_medication_drug_unit_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_12_Refreshing=false ;
      private bool n296BR_Medication_SchemeID ;
      private bool n310BR_Medication_Drug_Name ;
      private bool n311BR_Medication_Drug_Num ;
      private bool n312BR_Medication_Drug_Unit ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool gx_refresh_fired ;
      private bool AV28Select_IsBlob ;
      private String AV14ddo_BR_Medication_DetailIDTitleControlIdToReplace ;
      private String AV16ddo_BR_Medication_SchemeIDTitleControlIdToReplace ;
      private String AV30ddo_BR_Medication_Drug_NameTitleControlIdToReplace ;
      private String AV32ddo_BR_Medication_Drug_NumTitleControlIdToReplace ;
      private String AV34ddo_BR_Medication_Drug_UnitTitleControlIdToReplace ;
      private String A310BR_Medication_Drug_Name ;
      private String A312BR_Medication_Drug_Unit ;
      private String AV38Select_GXI ;
      private String AV28Select ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_medication_detailid ;
      private GXUserControl ucDdo_br_medication_schemeid ;
      private GXUserControl ucDdo_br_medication_drug_name ;
      private GXUserControl ucDdo_br_medication_drug_num ;
      private GXUserControl ucDdo_br_medication_drug_unit ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private long aP0_InOutBR_Medication_DetailID ;
      private IDataStoreProvider pr_default ;
      private String[] H005S2_A312BR_Medication_Drug_Unit ;
      private bool[] H005S2_n312BR_Medication_Drug_Unit ;
      private decimal[] H005S2_A311BR_Medication_Drug_Num ;
      private bool[] H005S2_n311BR_Medication_Drug_Num ;
      private String[] H005S2_A310BR_Medication_Drug_Name ;
      private bool[] H005S2_n310BR_Medication_Drug_Name ;
      private long[] H005S2_A296BR_Medication_SchemeID ;
      private bool[] H005S2_n296BR_Medication_SchemeID ;
      private long[] H005S2_A301BR_Medication_DetailID ;
      private long[] H005S3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV13BR_Medication_DetailIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV15BR_Medication_SchemeIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV29BR_Medication_Drug_NameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV31BR_Medication_Drug_NumTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV33BR_Medication_Drug_UnitTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV23DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class br_medication_detailprompt__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H005S2( IGxContext context ,
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
         sSelectString = " [BR_Medication_Drug_Unit], [BR_Medication_Drug_Num], [BR_Medication_Drug_Name], [BR_Medication_SchemeID], [BR_Medication_DetailID]";
         sFromString = " FROM [BR_Medication_Detail] WITH (NOLOCK)";
         sOrderString = "";
         if ( ( AV11OrderedBy == 1 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_DetailID]";
         }
         else if ( ( AV11OrderedBy == 1 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_DetailID] DESC";
         }
         else if ( ( AV11OrderedBy == 2 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_SchemeID]";
         }
         else if ( ( AV11OrderedBy == 2 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_SchemeID] DESC";
         }
         else if ( ( AV11OrderedBy == 3 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_Drug_Name]";
         }
         else if ( ( AV11OrderedBy == 3 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_Drug_Name] DESC";
         }
         else if ( ( AV11OrderedBy == 4 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_Drug_Num]";
         }
         else if ( ( AV11OrderedBy == 4 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_Drug_Num] DESC";
         }
         else if ( ( AV11OrderedBy == 5 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_Drug_Unit]";
         }
         else if ( ( AV11OrderedBy == 5 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_Drug_Unit] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Medication_DetailID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H005S3( IGxContext context ,
                                             short AV11OrderedBy ,
                                             bool AV12OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [BR_Medication_Detail] WITH (NOLOCK)";
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
                     return conditional_H005S2(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
               case 1 :
                     return conditional_H005S3(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
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
          Object[] prmH005S2 ;
          prmH005S2 = new Object[] {
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH005S3 ;
          prmH005S3 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H005S2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005S2,11,0,true,false )
             ,new CursorDef("H005S3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005S3,1,0,true,false )
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
                ((long[]) buf[6])[0] = rslt.getLong(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((long[]) buf[8])[0] = rslt.getLong(5) ;
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
