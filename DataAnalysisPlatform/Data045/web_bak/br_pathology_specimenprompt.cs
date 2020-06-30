/*
               File: BR_Pathology_SpecimenPrompt
        Description: 选择病理学送检组织
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:43:23.89
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
   public class br_pathology_specimenprompt : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public br_pathology_specimenprompt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_pathology_specimenprompt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_InOutBR_Pathology_SpecimenID ,
                           ref String aP1_InOutBR_Pathology_Specimen_Name )
      {
         this.AV8InOutBR_Pathology_SpecimenID = aP0_InOutBR_Pathology_SpecimenID;
         this.AV9InOutBR_Pathology_Specimen_Name = aP1_InOutBR_Pathology_Specimen_Name;
         executePrivate();
         aP0_InOutBR_Pathology_SpecimenID=this.AV8InOutBR_Pathology_SpecimenID;
         aP1_InOutBR_Pathology_Specimen_Name=this.AV9InOutBR_Pathology_Specimen_Name;
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
               AV14ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace = GetNextPar( );
               AV16ddo_BR_PathologyIDTitleControlIdToReplace = GetNextPar( );
               AV18ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace, AV16ddo_BR_PathologyIDTitleControlIdToReplace, AV18ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace) ;
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
               AV8InOutBR_Pathology_SpecimenID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_Pathology_SpecimenID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_Pathology_SpecimenID), 18, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV9InOutBR_Pathology_Specimen_Name = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutBR_Pathology_Specimen_Name", AV9InOutBR_Pathology_Specimen_Name);
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
            PA5O2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV27Pgmname = "BR_Pathology_SpecimenPrompt";
               context.Gx_err = 0;
               WS5O2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE5O2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202279432397", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_pathology_specimenprompt.aspx") + "?" + UrlEncode("" +AV8InOutBR_Pathology_SpecimenID) + "," + UrlEncode(StringUtil.RTrim(AV9InOutBR_Pathology_Specimen_Name))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV23GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV19DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV19DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_SPECIMENIDTITLEFILTERDATA", AV13BR_Pathology_SpecimenIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_SPECIMENIDTITLEFILTERDATA", AV13BR_Pathology_SpecimenIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGYIDTITLEFILTERDATA", AV15BR_PathologyIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGYIDTITLEFILTERDATA", AV15BR_PathologyIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_SPECIMEN_NAMETITLEFILTERDATA", AV17BR_Pathology_Specimen_NameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_SPECIMEN_NAMETITLEFILTERDATA", AV17BR_Pathology_Specimen_NameTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vINOUTBR_PATHOLOGY_SPECIMENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8InOutBR_Pathology_SpecimenID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINOUTBR_PATHOLOGY_SPECIMEN_NAME", AV9InOutBR_Pathology_Specimen_Name);
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Caption", StringUtil.RTrim( Ddo_br_pathology_specimenid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Tooltip", StringUtil.RTrim( Ddo_br_pathology_specimenid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Cls", StringUtil.RTrim( Ddo_br_pathology_specimenid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_specimenid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_specimenid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_specimenid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_specimenid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_specimenid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_specimenid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_specimenid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Sortasc", StringUtil.RTrim( Ddo_br_pathology_specimenid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_specimenid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_specimenid_Searchbuttontext));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Caption", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Tooltip", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Cls", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_specimen_name_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_specimen_name_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_specimen_name_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_specimen_name_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Sortasc", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_specimenid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMENID_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_specimenid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_specimen_name_Activeeventkey));
      }

      protected void RenderHtmlCloseForm5O2( )
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
         return "BR_Pathology_SpecimenPrompt" ;
      }

      public override String GetPgmdesc( )
      {
         return "选择病理学送检组织" ;
      }

      protected void WB5O0( )
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
               if ( edtBR_Pathology_SpecimenID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_SpecimenID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_SpecimenID_Title) ;
               }
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Pathology_Specimen_Name_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_Specimen_Name_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_Specimen_Name_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV24Select));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavSelect_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A274BR_Pathology_SpecimenID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_SpecimenID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_SpecimenID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A226BR_PathologyID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_PathologyID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_PathologyID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A275BR_Pathology_Specimen_Name);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_Specimen_Name_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_Specimen_Name_Titleformat), 4, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV21GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV23GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV22GridPageSize);
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
            ucDdo_br_pathology_specimenid.SetProperty("Caption", Ddo_br_pathology_specimenid_Caption);
            ucDdo_br_pathology_specimenid.SetProperty("Tooltip", Ddo_br_pathology_specimenid_Tooltip);
            ucDdo_br_pathology_specimenid.SetProperty("Cls", Ddo_br_pathology_specimenid_Cls);
            ucDdo_br_pathology_specimenid.SetProperty("DropDownOptionsType", Ddo_br_pathology_specimenid_Dropdownoptionstype);
            ucDdo_br_pathology_specimenid.SetProperty("IncludeSortASC", Ddo_br_pathology_specimenid_Includesortasc);
            ucDdo_br_pathology_specimenid.SetProperty("IncludeSortDSC", Ddo_br_pathology_specimenid_Includesortdsc);
            ucDdo_br_pathology_specimenid.SetProperty("IncludeFilter", Ddo_br_pathology_specimenid_Includefilter);
            ucDdo_br_pathology_specimenid.SetProperty("IncludeDataList", Ddo_br_pathology_specimenid_Includedatalist);
            ucDdo_br_pathology_specimenid.SetProperty("SortASC", Ddo_br_pathology_specimenid_Sortasc);
            ucDdo_br_pathology_specimenid.SetProperty("SortDSC", Ddo_br_pathology_specimenid_Sortdsc);
            ucDdo_br_pathology_specimenid.SetProperty("SearchButtonText", Ddo_br_pathology_specimenid_Searchbuttontext);
            ucDdo_br_pathology_specimenid.SetProperty("DropDownOptionsTitleSettingsIcons", AV19DDO_TitleSettingsIcons);
            ucDdo_br_pathology_specimenid.SetProperty("DropDownOptionsData", AV13BR_Pathology_SpecimenIDTitleFilterData);
            ucDdo_br_pathology_specimenid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_specimenid_Internalname, "DDO_BR_PATHOLOGY_SPECIMENIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_specimenidtitlecontrolidtoreplace_Internalname, AV14ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,25);\"", 0, edtavDdo_br_pathology_specimenidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_SpecimenPrompt.htm");
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
            ucDdo_br_pathologyid.SetProperty("DropDownOptionsTitleSettingsIcons", AV19DDO_TitleSettingsIcons);
            ucDdo_br_pathologyid.SetProperty("DropDownOptionsData", AV15BR_PathologyIDTitleFilterData);
            ucDdo_br_pathologyid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathologyid_Internalname, "DDO_BR_PATHOLOGYIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname, AV16ddo_BR_PathologyIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,27);\"", 0, edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_SpecimenPrompt.htm");
            /* User Defined Control */
            ucDdo_br_pathology_specimen_name.SetProperty("Caption", Ddo_br_pathology_specimen_name_Caption);
            ucDdo_br_pathology_specimen_name.SetProperty("Tooltip", Ddo_br_pathology_specimen_name_Tooltip);
            ucDdo_br_pathology_specimen_name.SetProperty("Cls", Ddo_br_pathology_specimen_name_Cls);
            ucDdo_br_pathology_specimen_name.SetProperty("DropDownOptionsType", Ddo_br_pathology_specimen_name_Dropdownoptionstype);
            ucDdo_br_pathology_specimen_name.SetProperty("IncludeSortASC", Ddo_br_pathology_specimen_name_Includesortasc);
            ucDdo_br_pathology_specimen_name.SetProperty("IncludeSortDSC", Ddo_br_pathology_specimen_name_Includesortdsc);
            ucDdo_br_pathology_specimen_name.SetProperty("IncludeFilter", Ddo_br_pathology_specimen_name_Includefilter);
            ucDdo_br_pathology_specimen_name.SetProperty("IncludeDataList", Ddo_br_pathology_specimen_name_Includedatalist);
            ucDdo_br_pathology_specimen_name.SetProperty("SortASC", Ddo_br_pathology_specimen_name_Sortasc);
            ucDdo_br_pathology_specimen_name.SetProperty("SortDSC", Ddo_br_pathology_specimen_name_Sortdsc);
            ucDdo_br_pathology_specimen_name.SetProperty("SearchButtonText", Ddo_br_pathology_specimen_name_Searchbuttontext);
            ucDdo_br_pathology_specimen_name.SetProperty("DropDownOptionsTitleSettingsIcons", AV19DDO_TitleSettingsIcons);
            ucDdo_br_pathology_specimen_name.SetProperty("DropDownOptionsData", AV17BR_Pathology_Specimen_NameTitleFilterData);
            ucDdo_br_pathology_specimen_name.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_specimen_name_Internalname, "DDO_BR_PATHOLOGY_SPECIMEN_NAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_specimen_nametitlecontrolidtoreplace_Internalname, AV18ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", 0, edtavDdo_br_pathology_specimen_nametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology_SpecimenPrompt.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,31);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_SpecimenPrompt.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV12OrderedDsc), StringUtil.BoolToStr( AV12OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,32);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_Pathology_SpecimenPrompt.htm");
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

      protected void START5O2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "选择病理学送检组织", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP5O0( ) ;
      }

      protected void WS5O2( )
      {
         START5O2( ) ;
         EVT5O2( ) ;
      }

      protected void EVT5O2( )
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
                           E115O2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E125O2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_SPECIMENID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E135O2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGYID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E145O2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_SPECIMEN_NAME.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E155O2 ();
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
                           AV24Select = cgiGet( edtavSelect_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV24Select)) ? AV28Select_GXI : context.convertURL( context.PathToRelativeUrl( AV24Select))), !bGXsfl_12_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "SrcSet", context.GetImageSrcSet( AV24Select), true);
                           A274BR_Pathology_SpecimenID = (long)(context.localUtil.CToN( cgiGet( edtBR_Pathology_SpecimenID_Internalname), ".", ","));
                           A226BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( edtBR_PathologyID_Internalname), ".", ","));
                           n226BR_PathologyID = false;
                           A275BR_Pathology_Specimen_Name = cgiGet( edtBR_Pathology_Specimen_Name_Internalname);
                           n275BR_Pathology_Specimen_Name = false;
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E165O2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E175O2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E185O2 ();
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
                                       E195O2 ();
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

      protected void WE5O2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm5O2( ) ;
            }
         }
      }

      protected void PA5O2( )
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
               GX_FocusControl = edtavDdo_br_pathology_specimenidtitlecontrolidtoreplace_Internalname;
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
                                       String AV14ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace ,
                                       String AV16ddo_BR_PathologyIDTitleControlIdToReplace ,
                                       String AV18ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF5O2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PATHOLOGY_SPECIMENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A274BR_Pathology_SpecimenID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_PATHOLOGY_SPECIMENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A274BR_Pathology_SpecimenID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PATHOLOGY_SPECIMEN_NAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A275BR_Pathology_Specimen_Name, "")), context));
         GxWebStd.gx_hidden_field( context, "BR_PATHOLOGY_SPECIMEN_NAME", A275BR_Pathology_Specimen_Name);
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
         RF5O2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV27Pgmname = "BR_Pathology_SpecimenPrompt";
         context.Gx_err = 0;
      }

      protected void RF5O2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 12;
         /* Execute user event: Refresh */
         E175O2 ();
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
            /* Using cursor H005O2 */
            pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_12_idx = 1;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A275BR_Pathology_Specimen_Name = H005O2_A275BR_Pathology_Specimen_Name[0];
               n275BR_Pathology_Specimen_Name = H005O2_n275BR_Pathology_Specimen_Name[0];
               A226BR_PathologyID = H005O2_A226BR_PathologyID[0];
               n226BR_PathologyID = H005O2_n226BR_PathologyID[0];
               A274BR_Pathology_SpecimenID = H005O2_A274BR_Pathology_SpecimenID[0];
               E185O2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 12;
            WB5O0( ) ;
         }
         bGXsfl_12_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes5O2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PATHOLOGY_SPECIMENID"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, context.localUtil.Format( (decimal)(A274BR_Pathology_SpecimenID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PATHOLOGY_SPECIMEN_NAME"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, StringUtil.RTrim( context.localUtil.Format( A275BR_Pathology_Specimen_Name, "")), context));
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
         /* Using cursor H005O3 */
         pr_default.execute(1);
         GRID_nRecordCount = H005O3_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace, AV16ddo_BR_PathologyIDTitleControlIdToReplace, AV18ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace, AV16ddo_BR_PathologyIDTitleControlIdToReplace, AV18ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace, AV16ddo_BR_PathologyIDTitleControlIdToReplace, AV18ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace, AV16ddo_BR_PathologyIDTitleControlIdToReplace, AV18ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace, AV16ddo_BR_PathologyIDTitleControlIdToReplace, AV18ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP5O0( )
      {
         /* Before Start, stand alone formulas. */
         AV27Pgmname = "BR_Pathology_SpecimenPrompt";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E165O2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV19DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_SPECIMENIDTITLEFILTERDATA"), AV13BR_Pathology_SpecimenIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGYIDTITLEFILTERDATA"), AV15BR_PathologyIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_SPECIMEN_NAMETITLEFILTERDATA"), AV17BR_Pathology_Specimen_NameTitleFilterData);
            /* Read variables values. */
            AV14ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_specimenidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace", AV14ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace);
            AV16ddo_BR_PathologyIDTitleControlIdToReplace = cgiGet( edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_BR_PathologyIDTitleControlIdToReplace", AV16ddo_BR_PathologyIDTitleControlIdToReplace);
            AV18ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_specimen_nametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace", AV18ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace);
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
            AV21GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV23GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV22GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_pathology_specimenid_Caption = cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Caption");
            Ddo_br_pathology_specimenid_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Tooltip");
            Ddo_br_pathology_specimenid_Cls = cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Cls");
            Ddo_br_pathology_specimenid_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Dropdownoptionstype");
            Ddo_br_pathology_specimenid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Titlecontrolidtoreplace");
            Ddo_br_pathology_specimenid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Includesortasc"));
            Ddo_br_pathology_specimenid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Includesortdsc"));
            Ddo_br_pathology_specimenid_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Sortedstatus");
            Ddo_br_pathology_specimenid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Includefilter"));
            Ddo_br_pathology_specimenid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Includedatalist"));
            Ddo_br_pathology_specimenid_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Sortasc");
            Ddo_br_pathology_specimenid_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Sortdsc");
            Ddo_br_pathology_specimenid_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Searchbuttontext");
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
            Ddo_br_pathology_specimen_name_Caption = cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Caption");
            Ddo_br_pathology_specimen_name_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Tooltip");
            Ddo_br_pathology_specimen_name_Cls = cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Cls");
            Ddo_br_pathology_specimen_name_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Dropdownoptionstype");
            Ddo_br_pathology_specimen_name_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Titlecontrolidtoreplace");
            Ddo_br_pathology_specimen_name_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Includesortasc"));
            Ddo_br_pathology_specimen_name_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Includesortdsc"));
            Ddo_br_pathology_specimen_name_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Sortedstatus");
            Ddo_br_pathology_specimen_name_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Includefilter"));
            Ddo_br_pathology_specimen_name_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Includedatalist"));
            Ddo_br_pathology_specimen_name_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Sortasc");
            Ddo_br_pathology_specimen_name_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Sortdsc");
            Ddo_br_pathology_specimen_name_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_pathology_specimenid_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_SPECIMENID_Activeeventkey");
            Ddo_br_pathologyid_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGYID_Activeeventkey");
            Ddo_br_pathology_specimen_name_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_SPECIMEN_NAME_Activeeventkey");
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
         E165O2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E165O2( )
      {
         /* Start Routine */
         GXt_boolean1 = AV5IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Pathology_Specimen", out  GXt_boolean1) ;
         AV5IsAuthorized = GXt_boolean1;
         if ( ! AV5IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV27Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         divTablemain_Height = 493;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTablemain_Internalname, "Height", StringUtil.LTrim( StringUtil.Str( (decimal)(divTablemain_Height), 9, 0)), true);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_br_pathology_specimenid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_SpecimenID";
         ucDdo_br_pathology_specimenid.SendProperty(context, "", false, Ddo_br_pathology_specimenid_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_specimenid_Titlecontrolidtoreplace);
         AV14ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace = Ddo_br_pathology_specimenid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace", AV14ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace);
         edtavDdo_br_pathology_specimenidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_specimenidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_specimenidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathologyid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_PathologyID";
         ucDdo_br_pathologyid.SendProperty(context, "", false, Ddo_br_pathologyid_Internalname, "TitleControlIdToReplace", Ddo_br_pathologyid_Titlecontrolidtoreplace);
         AV16ddo_BR_PathologyIDTitleControlIdToReplace = Ddo_br_pathologyid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_BR_PathologyIDTitleControlIdToReplace", AV16ddo_BR_PathologyIDTitleControlIdToReplace);
         edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_specimen_name_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_Specimen_Name";
         ucDdo_br_pathology_specimen_name.SendProperty(context, "", false, Ddo_br_pathology_specimen_name_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_specimen_name_Titlecontrolidtoreplace);
         AV18ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace = Ddo_br_pathology_specimen_name_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace", AV18ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace);
         edtavDdo_br_pathology_specimen_nametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_specimen_nametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_specimen_nametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "选择病理学送检组织";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV19DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV19DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E175O2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV13BR_Pathology_SpecimenIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15BR_PathologyIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17BR_Pathology_Specimen_NameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         edtBR_Pathology_SpecimenID_Titleformat = 2;
         edtBR_Pathology_SpecimenID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "病理学送检组织主键", AV14ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_SpecimenID_Internalname, "Title", edtBR_Pathology_SpecimenID_Title, !bGXsfl_12_Refreshing);
         edtBR_PathologyID_Titleformat = 2;
         edtBR_PathologyID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "病理学主键", AV16ddo_BR_PathologyIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_Internalname, "Title", edtBR_PathologyID_Title, !bGXsfl_12_Refreshing);
         edtBR_Pathology_Specimen_Name_Titleformat = 2;
         edtBR_Pathology_Specimen_Name_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "送检组织名称", AV18ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Specimen_Name_Internalname, "Title", edtBR_Pathology_Specimen_Name_Title, !bGXsfl_12_Refreshing);
         AV21GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21GridCurrentPage), 10, 0)));
         AV22GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22GridPageSize), 10, 0)));
         AV23GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV23GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Pathology_SpecimenIDTitleFilterData", AV13BR_Pathology_SpecimenIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_PathologyIDTitleFilterData", AV15BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Pathology_Specimen_NameTitleFilterData", AV17BR_Pathology_Specimen_NameTitleFilterData);
      }

      protected void E115O2( )
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
            AV20PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV20PageToGo) ;
         }
      }

      protected void E125O2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E135O2( )
      {
         /* Ddo_br_pathology_specimenid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_specimenid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_specimenid_Sortedstatus = "ASC";
            ucDdo_br_pathology_specimenid.SendProperty(context, "", false, Ddo_br_pathology_specimenid_Internalname, "SortedStatus", Ddo_br_pathology_specimenid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_specimenid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_specimenid_Sortedstatus = "DSC";
            ucDdo_br_pathology_specimenid.SendProperty(context, "", false, Ddo_br_pathology_specimenid_Internalname, "SortedStatus", Ddo_br_pathology_specimenid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Pathology_SpecimenIDTitleFilterData", AV13BR_Pathology_SpecimenIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_PathologyIDTitleFilterData", AV15BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Pathology_Specimen_NameTitleFilterData", AV17BR_Pathology_Specimen_NameTitleFilterData);
      }

      protected void E145O2( )
      {
         /* Ddo_br_pathologyid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathologyid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 2;
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
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathologyid_Sortedstatus = "DSC";
            ucDdo_br_pathologyid.SendProperty(context, "", false, Ddo_br_pathologyid_Internalname, "SortedStatus", Ddo_br_pathologyid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Pathology_SpecimenIDTitleFilterData", AV13BR_Pathology_SpecimenIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_PathologyIDTitleFilterData", AV15BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Pathology_Specimen_NameTitleFilterData", AV17BR_Pathology_Specimen_NameTitleFilterData);
      }

      protected void E155O2( )
      {
         /* Ddo_br_pathology_specimen_name_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_specimen_name_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_specimen_name_Sortedstatus = "ASC";
            ucDdo_br_pathology_specimen_name.SendProperty(context, "", false, Ddo_br_pathology_specimen_name_Internalname, "SortedStatus", Ddo_br_pathology_specimen_name_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_specimen_name_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_pathology_specimen_name_Sortedstatus = "DSC";
            ucDdo_br_pathology_specimen_name.SendProperty(context, "", false, Ddo_br_pathology_specimen_name_Internalname, "SortedStatus", Ddo_br_pathology_specimen_name_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Pathology_SpecimenIDTitleFilterData", AV13BR_Pathology_SpecimenIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_PathologyIDTitleFilterData", AV15BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Pathology_Specimen_NameTitleFilterData", AV17BR_Pathology_Specimen_NameTitleFilterData);
      }

      private void E185O2( )
      {
         /* Grid_Load Routine */
         AV24Select = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSelect_Internalname, AV24Select);
         AV28Select_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
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
         E195O2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E195O2( )
      {
         /* Enter Routine */
         AV8InOutBR_Pathology_SpecimenID = A274BR_Pathology_SpecimenID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_Pathology_SpecimenID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_Pathology_SpecimenID), 18, 0)));
         AV9InOutBR_Pathology_Specimen_Name = A275BR_Pathology_Specimen_Name;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutBR_Pathology_Specimen_Name", AV9InOutBR_Pathology_Specimen_Name);
         context.setWebReturnParms(new Object[] {(long)AV8InOutBR_Pathology_SpecimenID,(String)AV9InOutBR_Pathology_Specimen_Name});
         context.setWebReturnParmsMetadata(new Object[] {"AV8InOutBR_Pathology_SpecimenID","AV9InOutBR_Pathology_Specimen_Name"});
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
         AV8InOutBR_Pathology_SpecimenID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_Pathology_SpecimenID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_Pathology_SpecimenID), 18, 0)));
         AV9InOutBR_Pathology_Specimen_Name = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutBR_Pathology_Specimen_Name", AV9InOutBR_Pathology_Specimen_Name);
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
         PA5O2( ) ;
         WS5O2( ) ;
         WE5O2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279433020", true);
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
         context.AddJavascriptSource("br_pathology_specimenprompt.js", "?20202279433020", false);
         context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false);
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
         edtBR_Pathology_SpecimenID_Internalname = "BR_PATHOLOGY_SPECIMENID_"+sGXsfl_12_idx;
         edtBR_PathologyID_Internalname = "BR_PATHOLOGYID_"+sGXsfl_12_idx;
         edtBR_Pathology_Specimen_Name_Internalname = "BR_PATHOLOGY_SPECIMEN_NAME_"+sGXsfl_12_idx;
      }

      protected void SubsflControlProps_fel_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_fel_idx;
         edtBR_Pathology_SpecimenID_Internalname = "BR_PATHOLOGY_SPECIMENID_"+sGXsfl_12_fel_idx;
         edtBR_PathologyID_Internalname = "BR_PATHOLOGYID_"+sGXsfl_12_fel_idx;
         edtBR_Pathology_Specimen_Name_Internalname = "BR_PATHOLOGY_SPECIMEN_NAME_"+sGXsfl_12_fel_idx;
      }

      protected void sendrow_122( )
      {
         SubsflControlProps_122( ) ;
         WB5O0( ) ;
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
            AV24Select_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV24Select))&&String.IsNullOrEmpty(StringUtil.RTrim( AV28Select_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV24Select)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV24Select)) ? AV28Select_GXI : context.PathToRelativeUrl( AV24Select));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSelect_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSelect_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSelect_Jsonclick,"'"+""+"'"+",false,"+"'"+"EENTER."+sGXsfl_12_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV24Select_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_SpecimenID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A274BR_Pathology_SpecimenID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A274BR_Pathology_SpecimenID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_SpecimenID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
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
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_Specimen_Name_Internalname,(String)A275BR_Pathology_Specimen_Name,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_Specimen_Name_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes5O2( ) ;
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
         edtBR_Pathology_SpecimenID_Internalname = "BR_PATHOLOGY_SPECIMENID";
         edtBR_PathologyID_Internalname = "BR_PATHOLOGYID";
         edtBR_Pathology_Specimen_Name_Internalname = "BR_PATHOLOGY_SPECIMEN_NAME";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_pathology_specimenid_Internalname = "DDO_BR_PATHOLOGY_SPECIMENID";
         edtavDdo_br_pathology_specimenidtitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_SPECIMENIDTITLECONTROLIDTOREPLACE";
         Ddo_br_pathologyid_Internalname = "DDO_BR_PATHOLOGYID";
         edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_specimen_name_Internalname = "DDO_BR_PATHOLOGY_SPECIMEN_NAME";
         edtavDdo_br_pathology_specimen_nametitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_SPECIMEN_NAMETITLECONTROLIDTOREPLACE";
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
         edtBR_Pathology_Specimen_Name_Jsonclick = "";
         edtBR_PathologyID_Jsonclick = "";
         edtBR_Pathology_SpecimenID_Jsonclick = "";
         edtavSelect_Jsonclick = "";
         edtavSelect_Visible = -1;
         edtavSelect_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_pathology_specimen_nametitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathology_specimenidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavSelect_Tooltiptext = "选择";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Pathology_Specimen_Name_Titleformat = 0;
         edtBR_Pathology_Specimen_Name_Title = "送检组织名称";
         edtBR_PathologyID_Titleformat = 0;
         edtBR_PathologyID_Title = "病理学主键";
         edtBR_Pathology_SpecimenID_Titleformat = 0;
         edtBR_Pathology_SpecimenID_Title = "病理学送检组织主键";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         divTablemain_Height = 0;
         Ddo_br_pathology_specimen_name_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_specimen_name_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_specimen_name_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_specimen_name_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_specimen_name_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathology_specimen_name_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_specimen_name_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_specimen_name_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_specimen_name_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_specimen_name_Cls = "ColumnSettings";
         Ddo_br_pathology_specimen_name_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_specimen_name_Caption = "";
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
         Ddo_br_pathology_specimenid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_specimenid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_specimenid_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_specimenid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_specimenid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathology_specimenid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_specimenid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_specimenid_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_specimenid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_specimenid_Cls = "ColumnSettings";
         Ddo_br_pathology_specimenid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_specimenid_Caption = "";
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
         Form.Caption = "选择病理学送检组织";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMENIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMEN_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV13BR_Pathology_SpecimenIDTitleFilterData',fld:'vBR_PATHOLOGY_SPECIMENIDTITLEFILTERDATA',pic:''},{av:'AV15BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Pathology_Specimen_NameTitleFilterData',fld:'vBR_PATHOLOGY_SPECIMEN_NAMETITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_SpecimenID_Titleformat',ctrl:'BR_PATHOLOGY_SPECIMENID',prop:'Titleformat'},{av:'edtBR_Pathology_SpecimenID_Title',ctrl:'BR_PATHOLOGY_SPECIMENID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Specimen_Name_Titleformat',ctrl:'BR_PATHOLOGY_SPECIMEN_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Specimen_Name_Title',ctrl:'BR_PATHOLOGY_SPECIMEN_NAME',prop:'Title'},{av:'AV21GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV22GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV23GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E115O2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMENIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMEN_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E125O2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMENIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMEN_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_SPECIMENID.ONOPTIONCLICKED","{handler:'E135O2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMENIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMEN_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_pathology_specimenid_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_SPECIMENID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_SPECIMENID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_specimenid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_SPECIMENID',prop:'SortedStatus'},{av:'AV13BR_Pathology_SpecimenIDTitleFilterData',fld:'vBR_PATHOLOGY_SPECIMENIDTITLEFILTERDATA',pic:''},{av:'AV15BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Pathology_Specimen_NameTitleFilterData',fld:'vBR_PATHOLOGY_SPECIMEN_NAMETITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_SpecimenID_Titleformat',ctrl:'BR_PATHOLOGY_SPECIMENID',prop:'Titleformat'},{av:'edtBR_Pathology_SpecimenID_Title',ctrl:'BR_PATHOLOGY_SPECIMENID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Specimen_Name_Titleformat',ctrl:'BR_PATHOLOGY_SPECIMEN_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Specimen_Name_Title',ctrl:'BR_PATHOLOGY_SPECIMEN_NAME',prop:'Title'},{av:'AV21GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV22GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV23GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PATHOLOGYID.ONOPTIONCLICKED","{handler:'E145O2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMENIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMEN_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_pathologyid_Activeeventkey',ctrl:'DDO_BR_PATHOLOGYID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGYID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'AV13BR_Pathology_SpecimenIDTitleFilterData',fld:'vBR_PATHOLOGY_SPECIMENIDTITLEFILTERDATA',pic:''},{av:'AV15BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Pathology_Specimen_NameTitleFilterData',fld:'vBR_PATHOLOGY_SPECIMEN_NAMETITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_SpecimenID_Titleformat',ctrl:'BR_PATHOLOGY_SPECIMENID',prop:'Titleformat'},{av:'edtBR_Pathology_SpecimenID_Title',ctrl:'BR_PATHOLOGY_SPECIMENID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Specimen_Name_Titleformat',ctrl:'BR_PATHOLOGY_SPECIMEN_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Specimen_Name_Title',ctrl:'BR_PATHOLOGY_SPECIMEN_NAME',prop:'Title'},{av:'AV21GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV22GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV23GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_SPECIMEN_NAME.ONOPTIONCLICKED","{handler:'E155O2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMENIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_SPECIMEN_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_pathology_specimen_name_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_SPECIMEN_NAME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_SPECIMEN_NAME.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_specimen_name_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_SPECIMEN_NAME',prop:'SortedStatus'},{av:'AV13BR_Pathology_SpecimenIDTitleFilterData',fld:'vBR_PATHOLOGY_SPECIMENIDTITLEFILTERDATA',pic:''},{av:'AV15BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Pathology_Specimen_NameTitleFilterData',fld:'vBR_PATHOLOGY_SPECIMEN_NAMETITLEFILTERDATA',pic:''},{av:'edtBR_Pathology_SpecimenID_Titleformat',ctrl:'BR_PATHOLOGY_SPECIMENID',prop:'Titleformat'},{av:'edtBR_Pathology_SpecimenID_Title',ctrl:'BR_PATHOLOGY_SPECIMENID',prop:'Title'},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_Pathology_Specimen_Name_Titleformat',ctrl:'BR_PATHOLOGY_SPECIMEN_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Specimen_Name_Title',ctrl:'BR_PATHOLOGY_SPECIMEN_NAME',prop:'Title'},{av:'AV21GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV22GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV23GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E185O2',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV24Select',fld:'vSELECT',pic:''},{av:'edtavSelect_Tooltiptext',ctrl:'vSELECT',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E195O2',iparms:[{av:'A274BR_Pathology_SpecimenID',fld:'BR_PATHOLOGY_SPECIMENID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A275BR_Pathology_Specimen_Name',fld:'BR_PATHOLOGY_SPECIMEN_NAME',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV8InOutBR_Pathology_SpecimenID',fld:'vINOUTBR_PATHOLOGY_SPECIMENID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV9InOutBR_Pathology_Specimen_Name',fld:'vINOUTBR_PATHOLOGY_SPECIMEN_NAME',pic:''}]}");
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
         wcpOAV9InOutBR_Pathology_Specimen_Name = "";
         Gridpaginationbar_Selectedpage = "";
         Ddo_br_pathology_specimenid_Activeeventkey = "";
         Ddo_br_pathologyid_Activeeventkey = "";
         Ddo_br_pathology_specimen_name_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV14ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace = "";
         AV16ddo_BR_PathologyIDTitleControlIdToReplace = "";
         AV18ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace = "";
         GXKey = "";
         AV27Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV19DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV13BR_Pathology_SpecimenIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15BR_PathologyIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17BR_Pathology_Specimen_NameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_pathology_specimenid_Sortedstatus = "";
         Ddo_br_pathologyid_Sortedstatus = "";
         Ddo_br_pathology_specimen_name_Sortedstatus = "";
         GX_FocusControl = "";
         sPrefix = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV24Select = "";
         A275BR_Pathology_Specimen_Name = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_pathology_specimenid = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_br_pathologyid = new GXUserControl();
         ucDdo_br_pathology_specimen_name = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV28Select_GXI = "";
         scmdbuf = "";
         H005O2_A275BR_Pathology_Specimen_Name = new String[] {""} ;
         H005O2_n275BR_Pathology_Specimen_Name = new bool[] {false} ;
         H005O2_A226BR_PathologyID = new long[1] ;
         H005O2_n226BR_PathologyID = new bool[] {false} ;
         H005O2_A274BR_Pathology_SpecimenID = new long[1] ;
         H005O3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_pathology_specimenprompt__default(),
            new Object[][] {
                new Object[] {
               H005O2_A275BR_Pathology_Specimen_Name, H005O2_n275BR_Pathology_Specimen_Name, H005O2_A226BR_PathologyID, H005O2_n226BR_PathologyID, H005O2_A274BR_Pathology_SpecimenID
               }
               , new Object[] {
               H005O3_AGRID_nRecordCount
               }
            }
         );
         AV27Pgmname = "BR_Pathology_SpecimenPrompt";
         /* GeneXus formulas. */
         AV27Pgmname = "BR_Pathology_SpecimenPrompt";
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
      private short edtBR_Pathology_SpecimenID_Titleformat ;
      private short edtBR_PathologyID_Titleformat ;
      private short edtBR_Pathology_Specimen_Name_Titleformat ;
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
      private int edtavDdo_br_pathology_specimenidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_specimen_nametitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV20PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavSelect_Enabled ;
      private int edtavSelect_Visible ;
      private long AV8InOutBR_Pathology_SpecimenID ;
      private long wcpOAV8InOutBR_Pathology_SpecimenID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV21GridCurrentPage ;
      private long AV23GridRecordCount ;
      private long AV22GridPageSize ;
      private long A274BR_Pathology_SpecimenID ;
      private long A226BR_PathologyID ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_pathology_specimenid_Activeeventkey ;
      private String Ddo_br_pathologyid_Activeeventkey ;
      private String Ddo_br_pathology_specimen_name_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_12_idx="0001" ;
      private String GXKey ;
      private String AV27Pgmname ;
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
      private String Ddo_br_pathology_specimenid_Caption ;
      private String Ddo_br_pathology_specimenid_Tooltip ;
      private String Ddo_br_pathology_specimenid_Cls ;
      private String Ddo_br_pathology_specimenid_Dropdownoptionstype ;
      private String Ddo_br_pathology_specimenid_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_specimenid_Sortedstatus ;
      private String Ddo_br_pathology_specimenid_Sortasc ;
      private String Ddo_br_pathology_specimenid_Sortdsc ;
      private String Ddo_br_pathology_specimenid_Searchbuttontext ;
      private String Ddo_br_pathologyid_Caption ;
      private String Ddo_br_pathologyid_Tooltip ;
      private String Ddo_br_pathologyid_Cls ;
      private String Ddo_br_pathologyid_Dropdownoptionstype ;
      private String Ddo_br_pathologyid_Titlecontrolidtoreplace ;
      private String Ddo_br_pathologyid_Sortedstatus ;
      private String Ddo_br_pathologyid_Sortasc ;
      private String Ddo_br_pathologyid_Sortdsc ;
      private String Ddo_br_pathologyid_Searchbuttontext ;
      private String Ddo_br_pathology_specimen_name_Caption ;
      private String Ddo_br_pathology_specimen_name_Tooltip ;
      private String Ddo_br_pathology_specimen_name_Cls ;
      private String Ddo_br_pathology_specimen_name_Dropdownoptionstype ;
      private String Ddo_br_pathology_specimen_name_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_specimen_name_Sortedstatus ;
      private String Ddo_br_pathology_specimen_name_Sortasc ;
      private String Ddo_br_pathology_specimen_name_Sortdsc ;
      private String Ddo_br_pathology_specimen_name_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtBR_Pathology_SpecimenID_Title ;
      private String edtBR_PathologyID_Title ;
      private String edtBR_Pathology_Specimen_Name_Title ;
      private String subGrid_Header ;
      private String edtavSelect_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_pathology_specimenid_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_br_pathology_specimenidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathologyid_Internalname ;
      private String edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_specimen_name_Internalname ;
      private String edtavDdo_br_pathology_specimen_nametitlecontrolidtoreplace_Internalname ;
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
      private String edtBR_Pathology_SpecimenID_Internalname ;
      private String edtBR_PathologyID_Internalname ;
      private String edtBR_Pathology_Specimen_Name_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_12_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavSelect_Jsonclick ;
      private String ROClassString ;
      private String edtBR_Pathology_SpecimenID_Jsonclick ;
      private String edtBR_PathologyID_Jsonclick ;
      private String edtBR_Pathology_Specimen_Name_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV12OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_br_pathology_specimenid_Includesortasc ;
      private bool Ddo_br_pathology_specimenid_Includesortdsc ;
      private bool Ddo_br_pathology_specimenid_Includefilter ;
      private bool Ddo_br_pathology_specimenid_Includedatalist ;
      private bool Ddo_br_pathologyid_Includesortasc ;
      private bool Ddo_br_pathologyid_Includesortdsc ;
      private bool Ddo_br_pathologyid_Includefilter ;
      private bool Ddo_br_pathologyid_Includedatalist ;
      private bool Ddo_br_pathology_specimen_name_Includesortasc ;
      private bool Ddo_br_pathology_specimen_name_Includesortdsc ;
      private bool Ddo_br_pathology_specimen_name_Includefilter ;
      private bool Ddo_br_pathology_specimen_name_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_12_Refreshing=false ;
      private bool n226BR_PathologyID ;
      private bool n275BR_Pathology_Specimen_Name ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool gx_refresh_fired ;
      private bool AV24Select_IsBlob ;
      private String AV9InOutBR_Pathology_Specimen_Name ;
      private String wcpOAV9InOutBR_Pathology_Specimen_Name ;
      private String AV14ddo_BR_Pathology_SpecimenIDTitleControlIdToReplace ;
      private String AV16ddo_BR_PathologyIDTitleControlIdToReplace ;
      private String AV18ddo_BR_Pathology_Specimen_NameTitleControlIdToReplace ;
      private String A275BR_Pathology_Specimen_Name ;
      private String AV28Select_GXI ;
      private String AV24Select ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_pathology_specimenid ;
      private GXUserControl ucDdo_br_pathologyid ;
      private GXUserControl ucDdo_br_pathology_specimen_name ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private long aP0_InOutBR_Pathology_SpecimenID ;
      private String aP1_InOutBR_Pathology_Specimen_Name ;
      private IDataStoreProvider pr_default ;
      private String[] H005O2_A275BR_Pathology_Specimen_Name ;
      private bool[] H005O2_n275BR_Pathology_Specimen_Name ;
      private long[] H005O2_A226BR_PathologyID ;
      private bool[] H005O2_n226BR_PathologyID ;
      private long[] H005O2_A274BR_Pathology_SpecimenID ;
      private long[] H005O3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV13BR_Pathology_SpecimenIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV15BR_PathologyIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV17BR_Pathology_Specimen_NameTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV19DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class br_pathology_specimenprompt__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H005O2( IGxContext context ,
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
         sSelectString = " [BR_Pathology_Specimen_Name], [BR_PathologyID], [BR_Pathology_SpecimenID]";
         sFromString = " FROM [BR_Pathology_Specimen] WITH (NOLOCK)";
         sOrderString = "";
         if ( ( AV11OrderedBy == 1 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_SpecimenID]";
         }
         else if ( ( AV11OrderedBy == 1 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_SpecimenID] DESC";
         }
         else if ( ( AV11OrderedBy == 2 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_PathologyID]";
         }
         else if ( ( AV11OrderedBy == 2 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_PathologyID] DESC";
         }
         else if ( ( AV11OrderedBy == 3 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Specimen_Name]";
         }
         else if ( ( AV11OrderedBy == 3 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_Specimen_Name] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Pathology_SpecimenID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H005O3( IGxContext context ,
                                             short AV11OrderedBy ,
                                             bool AV12OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [BR_Pathology_Specimen] WITH (NOLOCK)";
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
                     return conditional_H005O2(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
               case 1 :
                     return conditional_H005O3(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
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
          Object[] prmH005O2 ;
          prmH005O2 = new Object[] {
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH005O3 ;
          prmH005O3 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H005O2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005O2,11,0,true,false )
             ,new CursorDef("H005O3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005O3,1,0,true,false )
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
                ((long[]) buf[2])[0] = rslt.getLong(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((long[]) buf[4])[0] = rslt.getLong(3) ;
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
